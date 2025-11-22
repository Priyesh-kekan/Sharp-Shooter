using Cinemachine;
using StarterAssets;
using System.Runtime.ExceptionServices;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class ActiveWeapon : MonoBehaviour
{
    [SerializeField] WeaponSO startingWeapon;
    [SerializeField] WeaponSO weaponSO;
    [SerializeField] GameObject zoomEffect;
    [SerializeField] float zoomsens;
    [SerializeField] TMP_Text currentAmmoUI;
    [SerializeField] TMP_Text totalAmmoUI;

    Weapon currentWeapon;
    CinemachineVirtualCamera virtualCamera;
    FirstPersonController fpc; 

    float initTime;
    float defaultFOV;
    float defaultZoomsens;
    int currentAmmo;

    private void Start()
    {
        currentWeapon = FindFirstObjectByType<Weapon>();
        SwitchWeapon(startingWeapon);
        virtualCamera = FindFirstObjectByType<CinemachineVirtualCamera>();
        fpc = FindFirstObjectByType<FirstPersonController>();
        initTime = 10;
        defaultFOV = virtualCamera.m_Lens.FieldOfView;
        defaultZoomsens = 1;  
    }
    private void Update()
    {
        initTime += Time.deltaTime;
        HandleShoot();
        HandleZoom();

        if (Keyboard.current.escapeKey.wasPressedThisFrame)
        {
            Application.Quit();
            Debug.Log("Game Exit");
        }
    }

    private void HandleZoom()
    {
        if (!weaponSO.canZoom) return;
        if (Input.GetKey(KeyCode.Mouse1))
        {
            Debug.Log("Right Click");
            virtualCamera.m_Lens.FieldOfView = weaponSO.zoomFOV;
            zoomEffect.SetActive(true);
            fpc.ChangeSens(zoomsens);
        }
        else
        {
            virtualCamera.m_Lens.FieldOfView = defaultFOV;
            zoomEffect.SetActive(false);
            fpc.ChangeSens(defaultZoomsens);
        }
    }

    private void HandleShoot()
    {
        if (Input.GetKey(KeyCode.Mouse0) && currentAmmo > 0)
        {
            if (initTime >= weaponSO.fireRate)
            {
                currentWeapon.Shoot(weaponSO);
                ChangeAmmo(-1);
                currentAmmoUI.text = currentAmmo.ToString("D2");
                initTime = 0;
            }

        }
    }

    public void SwitchWeapon(WeaponSO weaponSO)
    {
        Debug.Log("Weapon changed!" + weaponSO.name);

        if (currentWeapon)
        {
            Destroy(currentWeapon.gameObject);
        }

        totalAmmoUI.text = weaponSO.magazineSize.ToString("D2");
        currentAmmo = weaponSO.magazineSize;
        currentAmmoUI.text = weaponSO.magazineSize.ToString("D2");
        Weapon NewWeapon = Instantiate(weaponSO.weaponPrefab, transform).GetComponent<Weapon>();
        currentWeapon = NewWeapon;
        this.weaponSO = weaponSO;
    }

    public void ChangeAmmo(int amount)
    {
        currentAmmo += amount;
        currentAmmoUI.text = currentAmmo.ToString("D2");
    }
}
