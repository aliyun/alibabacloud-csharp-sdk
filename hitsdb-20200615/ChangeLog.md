2026-01-22 Version: 5.2.2
- Update API GetLindormV2Instance: add response parameters Body.EnableFS.
- Update API GetLindormV2Instance: add response parameters Body.EnableStoreTDE.
- Update API GetLindormV2InstanceDetails: add response parameters Body.EnableFs.
- Update API GetLindormV2InstanceDetails: add response parameters Body.EnableStoreTDE.


2026-01-12 Version: 5.2.1
- Update API ListLdpsComputeGroups: add response parameters Body.GroupList.$.RayInteractiveAccessAddr.
- Update API ListLdpsComputeGroups: add response parameters Body.GroupList.$.RayVpcWebUIAddr.


2025-12-24 Version: 5.2.0
- Support API GetInstanceSummary.


2025-12-12 Version: 5.1.0
- Support API UpdateLindormV2WhiteIpList.
- Update API CreateAutoScalingConfig: add request parameters StorageCapacityMax.
- Update API GetLindormV2Instance: add response parameters Body.EngineList.$.NodeGroup.$.IsScaleSpecGroup.
- Update API ListAutoScalingConfigs: add request parameters ScaleTypes.
- Update API ListAutoScalingConfigs: add response parameters Body.Data.ScaleConfigs.$.StorageCapacityMax.
- Update API ListAutoScalingRecords: add request parameters ScaleTypes.
- Update API ModifyAutoScalingConfig: add request parameters ScaleRuleList.
- Update API ModifyAutoScalingConfig: add request parameters StorageCapacityMax.


2025-12-04 Version: 5.0.0
- Support API ChangeResourceGroup.
- Support API CheckLdpsColumnarIndexStatus.
- Support API CreateAutoScalingConfig.
- Support API CreateAutoScalingRule.
- Support API CreateLdpsComputeGroup.
- Support API CreateLindormV2Instance.
- Support API DeleteAutoScalingConfig.
- Support API DeleteAutoScalingRule.
- Support API DeleteCustomResource.
- Support API DeleteLdpsComputeGroup.
- Support API DeployLdpsSemiManagedComponent.
- Support API GetAutoScalingConfig.
- Support API GetAutoScalingRule.
- Support API GetClientSourceIp.
- Support API GetEngineDefaultAuth.
- Support API GetInstanceSecurityGroups.
- Support API GetLdpsComputeGroup.
- Support API GetLindormEngineConfig.
- Support API GetLindormFsUsedDetail.
- Support API GetLindormV2Instance.
- Support API GetLindormV2InstanceDetails.
- Support API GetLindormV2InstanceEngineList.
- Support API GetLindormV2InstanceForTerraform.
- Support API GetLindormV2InstanceSecurityGroups.
- Support API GetLindormV2StorageUsage.
- Support API GetLindormV2StreamEngineInfo.
- Support API ListAutoScalingConfigs.
- Support API ListAutoScalingRecords.
- Support API ListAutoScalingRules.
- Support API ListLdpsComputeGroups.
- Support API MigrateSingleZoneToMultiZone.
- Support API ModifyAutoScalingConfig.
- Support API ModifyAutoScalingRule.
- Support API ModifyLindormV2Instance.
- Support API ModifyLindormV2InstanceSecurityGroups.
- Support API ModifyLindormV2WhiteIpList.
- Support API OpenComputeEngine.
- Support API OpenComputePreCheck.
- Support API OpenLdpsColumnarIndex.
- Support API ReleaseLindormV2Instance.
- Support API RestartLdpsComputeGroup.
- Support API SetDefaultOlapComputeGroup.
- Support API SwitchLSQLV3MySQLService.
- Support API UpdateInstanceSecurityGroups.
- Support API UpdateLdpsComputeGroup.
- Support API UpdateLindormInstanceAttribute.
- Support API UpdateLindormV2Instance.
- Support API UpdateLindormV2InstanceParameter.
- Support API UpgradeLindormV2StreamEngine.
- Delete API CreateLdpsNamespace.
- Update API CreateLindormInstance: add request parameters AutoRenewDuration.
- Update API CreateLindormInstance: add request parameters AutoRenewal.
- Update API CreateLindormInstance: add request parameters LtsNum.
- Update API CreateLindormInstance: add request parameters LtsSpec.
- Update API CreateLindormInstance: add request parameters Tag.
- Update API CreateLindormInstance: add response parameters Body.AccessDeniedDetail.
- Update API GetInstanceIpWhiteList: add response parameters Body.AccessDeniedDetail.
- Update API GetLindormInstance: add response parameters Body.ArchiveStorage.
- Update API GetLindormInstance: add response parameters Body.EnableLProxy.
- Update API GetLindormInstance: add response parameters Body.EnableStoreTDE.
- Update API GetLindormInstance: add response parameters Body.EngineList.$.ArbiterCoreCount.
- Update API GetLindormInstance: add response parameters Body.EngineList.$.PrimaryCoreCount.
- Update API GetLindormInstance: add response parameters Body.EngineList.$.Specification.
- Update API GetLindormInstance: add response parameters Body.EngineList.$.StandbyCoreCount.
- Update API GetLindormInstanceEngineList: add response parameters Body.AccessDeniedDetail.
- Update API GetLindormInstanceList: add response parameters Body.InstanceList.$.CreateErrorCode.
- Update API GetLindormInstanceList: add response parameters Body.InstanceList.$.EnableColumn.
- Update API GetLindormInstanceList: add response parameters Body.InstanceList.$.EnableLts.
- Update API GetLindormInstanceList: add response parameters Body.InstanceList.$.EnableMessage.
- Update API GetLindormInstanceList: add response parameters Body.InstanceList.$.EnableRow.
- Update API GetLindormInstanceList: add response parameters Body.InstanceList.$.EnableVector.
- Update API ModifyInstancePayType: add response parameters Body.AccessDeniedDetail.
- Update API RenewLindormInstance: add response parameters Body.AccessDeniedDetail.
- Update API UpdateInstanceIpWhiteList: add response parameters Body.AccessDeniedDetail.


2023-11-23 Version: 3.0.9
- Generated csharp 2020-06-15 for hitsdb.

2023-11-23 Version: 4.0.0
- Generated csharp 2020-06-15 for hitsdb.

2023-08-15 Version: 3.1.0
- Generated csharp 2020-06-15 for hitsdb.

2022-11-15 Version: 3.0.6
- Add renew and modify instance pay type api.

2022-08-15 Version: 3.0.5
- Update Lindorm OpenAPI.

2022-04-25 Version: 3.0.4
- OpenAPI for Lindorm.

2021-12-14 Version: 1.0.1
- AMP version.

2021-02-20 Version: 1.0.0
- AMP Version Change.

