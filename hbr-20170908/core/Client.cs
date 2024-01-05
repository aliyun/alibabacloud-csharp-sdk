// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Hbr20170908.Models;

namespace AlibabaCloud.SDK.Hbr20170908
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "regional";
            this._endpointMap = new Dictionary<string, string>
            {
                {"ap-northeast-2-pop", "hbr.aliyuncs.com"},
                {"cn-beijing-finance-1", "hbr.aliyuncs.com"},
                {"cn-beijing-finance-pop", "hbr.aliyuncs.com"},
                {"cn-beijing-gov-1", "hbr.aliyuncs.com"},
                {"cn-beijing-nu16-b01", "hbr.aliyuncs.com"},
                {"cn-edge-1", "hbr.aliyuncs.com"},
                {"cn-fujian", "hbr.aliyuncs.com"},
                {"cn-haidian-cm12-c01", "hbr.aliyuncs.com"},
                {"cn-hangzhou-bj-b01", "hbr.aliyuncs.com"},
                {"cn-hangzhou-internal-prod-1", "hbr.aliyuncs.com"},
                {"cn-hangzhou-internal-test-1", "hbr.aliyuncs.com"},
                {"cn-hangzhou-internal-test-2", "hbr.aliyuncs.com"},
                {"cn-hangzhou-internal-test-3", "hbr.aliyuncs.com"},
                {"cn-hangzhou-test-306", "hbr.aliyuncs.com"},
                {"cn-hongkong-finance-pop", "hbr.aliyuncs.com"},
                {"cn-huhehaote-nebula-1", "hbr.aliyuncs.com"},
                {"cn-qingdao-nebula", "hbr.aliyuncs.com"},
                {"cn-shanghai-et15-b01", "hbr.aliyuncs.com"},
                {"cn-shanghai-et2-b01", "hbr.aliyuncs.com"},
                {"cn-shanghai-inner", "hbr.aliyuncs.com"},
                {"cn-shanghai-internal-test-1", "hbr.aliyuncs.com"},
                {"cn-shenzhen-inner", "hbr.aliyuncs.com"},
                {"cn-shenzhen-st4-d01", "hbr.aliyuncs.com"},
                {"cn-shenzhen-su18-b01", "hbr.aliyuncs.com"},
                {"cn-wuhan", "hbr.aliyuncs.com"},
                {"cn-wulanchabu", "hbr.aliyuncs.com"},
                {"cn-yushanfang", "hbr.aliyuncs.com"},
                {"cn-zhangbei", "hbr.aliyuncs.com"},
                {"cn-zhangbei-na61-b01", "hbr.aliyuncs.com"},
                {"cn-zhangjiakou-na62-a01", "hbr.aliyuncs.com"},
                {"cn-zhengzhou-nebula-1", "hbr.aliyuncs.com"},
                {"eu-west-1-oxs", "hbr.aliyuncs.com"},
                {"rus-west-1-pop", "hbr.aliyuncs.com"},
            };
            CheckConfig(config);
            this._endpoint = GetEndpoint("hbr", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
        }


        public string GetEndpoint(string productId, string regionId, string endpointRule, string network, string suffix, Dictionary<string, string> endpointMap, string endpoint)
        {
            if (!AlibabaCloud.TeaUtil.Common.Empty(endpoint))
            {
                return endpoint;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(endpointMap) && !AlibabaCloud.TeaUtil.Common.Empty(endpointMap.Get(regionId)))
            {
                return endpointMap.Get(regionId);
            }
            return AlibabaCloud.EndpointUtil.Common.GetEndpointRules(productId, regionId, endpointRule, network, suffix);
        }

        public AddContainerClusterResponse AddContainerClusterWithOptions(AddContainerClusterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterType))
            {
                query["ClusterType"] = request.ClusterType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Identifier))
            {
                query["Identifier"] = request.Identifier;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NetworkType))
            {
                query["NetworkType"] = request.NetworkType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddContainerCluster",
                Version = "2017-09-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddContainerClusterResponse>(CallApi(params_, req, runtime));
        }

        public async Task<AddContainerClusterResponse> AddContainerClusterWithOptionsAsync(AddContainerClusterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterType))
            {
                query["ClusterType"] = request.ClusterType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Identifier))
            {
                query["Identifier"] = request.Identifier;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NetworkType))
            {
                query["NetworkType"] = request.NetworkType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddContainerCluster",
                Version = "2017-09-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddContainerClusterResponse>(await CallApiAsync(params_, req, runtime));
        }

        public AddContainerClusterResponse AddContainerCluster(AddContainerClusterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddContainerClusterWithOptions(request, runtime);
        }

        public async Task<AddContainerClusterResponse> AddContainerClusterAsync(AddContainerClusterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddContainerClusterWithOptionsAsync(request, runtime);
        }

        public AttachNasFileSystemResponse AttachNasFileSystemWithOptions(AttachNasFileSystemRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreateTime))
            {
                query["CreateTime"] = request.CreateTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CrossAccountRoleName))
            {
                query["CrossAccountRoleName"] = request.CrossAccountRoleName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CrossAccountType))
            {
                query["CrossAccountType"] = request.CrossAccountType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CrossAccountUserId))
            {
                query["CrossAccountUserId"] = request.CrossAccountUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileSystemId))
            {
                query["FileSystemId"] = request.FileSystemId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AttachNasFileSystem",
                Version = "2017-09-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AttachNasFileSystemResponse>(CallApi(params_, req, runtime));
        }

        public async Task<AttachNasFileSystemResponse> AttachNasFileSystemWithOptionsAsync(AttachNasFileSystemRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreateTime))
            {
                query["CreateTime"] = request.CreateTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CrossAccountRoleName))
            {
                query["CrossAccountRoleName"] = request.CrossAccountRoleName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CrossAccountType))
            {
                query["CrossAccountType"] = request.CrossAccountType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CrossAccountUserId))
            {
                query["CrossAccountUserId"] = request.CrossAccountUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileSystemId))
            {
                query["FileSystemId"] = request.FileSystemId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AttachNasFileSystem",
                Version = "2017-09-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AttachNasFileSystemResponse>(await CallApiAsync(params_, req, runtime));
        }

        public AttachNasFileSystemResponse AttachNasFileSystem(AttachNasFileSystemRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AttachNasFileSystemWithOptions(request, runtime);
        }

        public async Task<AttachNasFileSystemResponse> AttachNasFileSystemAsync(AttachNasFileSystemRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AttachNasFileSystemWithOptionsAsync(request, runtime);
        }

        public CancelBackupJobResponse CancelBackupJobWithOptions(CancelBackupJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobId))
            {
                query["JobId"] = request.JobId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VaultId))
            {
                query["VaultId"] = request.VaultId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CancelBackupJob",
                Version = "2017-09-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CancelBackupJobResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CancelBackupJobResponse> CancelBackupJobWithOptionsAsync(CancelBackupJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobId))
            {
                query["JobId"] = request.JobId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VaultId))
            {
                query["VaultId"] = request.VaultId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CancelBackupJob",
                Version = "2017-09-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CancelBackupJobResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CancelBackupJobResponse CancelBackupJob(CancelBackupJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CancelBackupJobWithOptions(request, runtime);
        }

        public async Task<CancelBackupJobResponse> CancelBackupJobAsync(CancelBackupJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CancelBackupJobWithOptionsAsync(request, runtime);
        }

        public CancelRestoreJobResponse CancelRestoreJobWithOptions(CancelRestoreJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RestoreId))
            {
                query["RestoreId"] = request.RestoreId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VaultId))
            {
                query["VaultId"] = request.VaultId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CancelRestoreJob",
                Version = "2017-09-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CancelRestoreJobResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CancelRestoreJobResponse> CancelRestoreJobWithOptionsAsync(CancelRestoreJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RestoreId))
            {
                query["RestoreId"] = request.RestoreId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VaultId))
            {
                query["VaultId"] = request.VaultId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CancelRestoreJob",
                Version = "2017-09-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CancelRestoreJobResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CancelRestoreJobResponse CancelRestoreJob(CancelRestoreJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CancelRestoreJobWithOptions(request, runtime);
        }

        public async Task<CancelRestoreJobResponse> CancelRestoreJobAsync(CancelRestoreJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CancelRestoreJobWithOptionsAsync(request, runtime);
        }

        /**
          * *   In the Hybrid Backup Recovery (HBR), you can use resource groups to manage resources such as backup vaults, backup clients, and SAP HANA instances.
          * *   A resource is a cloud service entity that you create on Alibaba Cloud, such as an ECS instance, a backup vault, or an SAP HANA instance.
          * *   You can sort resources owned by your Alibaba Cloud account into various resource groups. This facilitates resource management among multiple projects or applications within your Alibaba Cloud account and simplifies permission management.
          *
          * @param request ChangeResourceGroupRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return ChangeResourceGroupResponse
         */
        public ChangeResourceGroupResponse ChangeResourceGroupWithOptions(ChangeResourceGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NewResourceGroupId))
            {
                body["NewResourceGroupId"] = request.NewResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceId))
            {
                body["ResourceId"] = request.ResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                body["ResourceType"] = request.ResourceType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ChangeResourceGroup",
                Version = "2017-09-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ChangeResourceGroupResponse>(CallApi(params_, req, runtime));
        }

        /**
          * *   In the Hybrid Backup Recovery (HBR), you can use resource groups to manage resources such as backup vaults, backup clients, and SAP HANA instances.
          * *   A resource is a cloud service entity that you create on Alibaba Cloud, such as an ECS instance, a backup vault, or an SAP HANA instance.
          * *   You can sort resources owned by your Alibaba Cloud account into various resource groups. This facilitates resource management among multiple projects or applications within your Alibaba Cloud account and simplifies permission management.
          *
          * @param request ChangeResourceGroupRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return ChangeResourceGroupResponse
         */
        public async Task<ChangeResourceGroupResponse> ChangeResourceGroupWithOptionsAsync(ChangeResourceGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NewResourceGroupId))
            {
                body["NewResourceGroupId"] = request.NewResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceId))
            {
                body["ResourceId"] = request.ResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                body["ResourceType"] = request.ResourceType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ChangeResourceGroup",
                Version = "2017-09-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ChangeResourceGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * *   In the Hybrid Backup Recovery (HBR), you can use resource groups to manage resources such as backup vaults, backup clients, and SAP HANA instances.
          * *   A resource is a cloud service entity that you create on Alibaba Cloud, such as an ECS instance, a backup vault, or an SAP HANA instance.
          * *   You can sort resources owned by your Alibaba Cloud account into various resource groups. This facilitates resource management among multiple projects or applications within your Alibaba Cloud account and simplifies permission management.
          *
          * @param request ChangeResourceGroupRequest
          * @return ChangeResourceGroupResponse
         */
        public ChangeResourceGroupResponse ChangeResourceGroup(ChangeResourceGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ChangeResourceGroupWithOptions(request, runtime);
        }

        /**
          * *   In the Hybrid Backup Recovery (HBR), you can use resource groups to manage resources such as backup vaults, backup clients, and SAP HANA instances.
          * *   A resource is a cloud service entity that you create on Alibaba Cloud, such as an ECS instance, a backup vault, or an SAP HANA instance.
          * *   You can sort resources owned by your Alibaba Cloud account into various resource groups. This facilitates resource management among multiple projects or applications within your Alibaba Cloud account and simplifies permission management.
          *
          * @param request ChangeResourceGroupRequest
          * @return ChangeResourceGroupResponse
         */
        public async Task<ChangeResourceGroupResponse> ChangeResourceGroupAsync(ChangeResourceGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ChangeResourceGroupWithOptionsAsync(request, runtime);
        }

        public CheckRoleResponse CheckRoleWithOptions(CheckRoleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CheckRoleType))
            {
                query["CheckRoleType"] = request.CheckRoleType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CrossAccountRoleName))
            {
                query["CrossAccountRoleName"] = request.CrossAccountRoleName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CrossAccountUserId))
            {
                query["CrossAccountUserId"] = request.CrossAccountUserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CheckRole",
                Version = "2017-09-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CheckRoleResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CheckRoleResponse> CheckRoleWithOptionsAsync(CheckRoleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CheckRoleType))
            {
                query["CheckRoleType"] = request.CheckRoleType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CrossAccountRoleName))
            {
                query["CrossAccountRoleName"] = request.CrossAccountRoleName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CrossAccountUserId))
            {
                query["CrossAccountUserId"] = request.CrossAccountUserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CheckRole",
                Version = "2017-09-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CheckRoleResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CheckRoleResponse CheckRole(CheckRoleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CheckRoleWithOptions(request, runtime);
        }

        public async Task<CheckRoleResponse> CheckRoleAsync(CheckRoleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CheckRoleWithOptionsAsync(request, runtime);
        }

        public CreateBackupJobResponse CreateBackupJobWithOptions(CreateBackupJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackupType))
            {
                query["BackupType"] = request.BackupType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContainerClusterId))
            {
                query["ContainerClusterId"] = request.ContainerClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContainerResources))
            {
                query["ContainerResources"] = request.ContainerResources;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CrossAccountRoleName))
            {
                query["CrossAccountRoleName"] = request.CrossAccountRoleName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CrossAccountType))
            {
                query["CrossAccountType"] = request.CrossAccountType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CrossAccountUserId))
            {
                query["CrossAccountUserId"] = request.CrossAccountUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Exclude))
            {
                query["Exclude"] = request.Exclude;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Include))
            {
                query["Include"] = request.Include;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InitiatedByAck))
            {
                query["InitiatedByAck"] = request.InitiatedByAck;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobName))
            {
                query["JobName"] = request.JobName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Options))
            {
                query["Options"] = request.Options;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Retention))
            {
                query["Retention"] = request.Retention;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceType))
            {
                query["SourceType"] = request.SourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SpeedLimit))
            {
                query["SpeedLimit"] = request.SpeedLimit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VaultId))
            {
                query["VaultId"] = request.VaultId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateBackupJob",
                Version = "2017-09-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateBackupJobResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateBackupJobResponse> CreateBackupJobWithOptionsAsync(CreateBackupJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackupType))
            {
                query["BackupType"] = request.BackupType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContainerClusterId))
            {
                query["ContainerClusterId"] = request.ContainerClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContainerResources))
            {
                query["ContainerResources"] = request.ContainerResources;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CrossAccountRoleName))
            {
                query["CrossAccountRoleName"] = request.CrossAccountRoleName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CrossAccountType))
            {
                query["CrossAccountType"] = request.CrossAccountType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CrossAccountUserId))
            {
                query["CrossAccountUserId"] = request.CrossAccountUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Exclude))
            {
                query["Exclude"] = request.Exclude;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Include))
            {
                query["Include"] = request.Include;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InitiatedByAck))
            {
                query["InitiatedByAck"] = request.InitiatedByAck;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobName))
            {
                query["JobName"] = request.JobName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Options))
            {
                query["Options"] = request.Options;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Retention))
            {
                query["Retention"] = request.Retention;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceType))
            {
                query["SourceType"] = request.SourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SpeedLimit))
            {
                query["SpeedLimit"] = request.SpeedLimit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VaultId))
            {
                query["VaultId"] = request.VaultId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateBackupJob",
                Version = "2017-09-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateBackupJobResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateBackupJobResponse CreateBackupJob(CreateBackupJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateBackupJobWithOptions(request, runtime);
        }

        public async Task<CreateBackupJobResponse> CreateBackupJobAsync(CreateBackupJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateBackupJobWithOptionsAsync(request, runtime);
        }

        /**
          * *   A backup schedule defines the data source, backup policy, and other configurations. After you execute a backup schedule, a backup job is generated to record the backup progress and the backup result. If a backup job is complete, a backup snapshot is generated. You can use a backup snapshot to create a restore job.
          * *   You can specify only one type of data source in a backup schedule.
          * *   You can specify only one interval as a backup cycle in a backup schedule.
          * *   Each backup schedule allows you to back up data to only one backup vault.
          *
          * @param tmpReq CreateBackupPlanRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return CreateBackupPlanResponse
         */
        public CreateBackupPlanResponse CreateBackupPlanWithOptions(CreateBackupPlanRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateBackupPlanShrinkRequest request = new CreateBackupPlanShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DestDataSourceDetail))
            {
                request.DestDataSourceDetailShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DestDataSourceDetail, "DestDataSourceDetail", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Detail))
            {
                request.DetailShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Detail, "Detail", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.OtsDetail))
            {
                request.OtsDetailShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.OtsDetail, "OtsDetail", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackupType))
            {
                query["BackupType"] = request.BackupType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Bucket))
            {
                query["Bucket"] = request.Bucket;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChangeListPath))
            {
                query["ChangeListPath"] = request.ChangeListPath;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreateTime))
            {
                query["CreateTime"] = request.CreateTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CrossAccountRoleName))
            {
                query["CrossAccountRoleName"] = request.CrossAccountRoleName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CrossAccountType))
            {
                query["CrossAccountType"] = request.CrossAccountType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CrossAccountUserId))
            {
                query["CrossAccountUserId"] = request.CrossAccountUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestDataSourceDetailShrink))
            {
                query["DestDataSourceDetail"] = request.DestDataSourceDetailShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestDataSourceId))
            {
                query["DestDataSourceId"] = request.DestDataSourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestSourceType))
            {
                query["DestSourceType"] = request.DestSourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DetailShrink))
            {
                query["Detail"] = request.DetailShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileSystemId))
            {
                query["FileSystemId"] = request.FileSystemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeepLatestSnapshots))
            {
                query["KeepLatestSnapshots"] = request.KeepLatestSnapshots;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PlanName))
            {
                query["PlanName"] = request.PlanName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Prefix))
            {
                query["Prefix"] = request.Prefix;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Retention))
            {
                query["Retention"] = request.Retention;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Schedule))
            {
                query["Schedule"] = request.Schedule;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceType))
            {
                query["SourceType"] = request.SourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UdmRegionId))
            {
                query["UdmRegionId"] = request.UdmRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VaultId))
            {
                query["VaultId"] = request.VaultId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Exclude))
            {
                body["Exclude"] = request.Exclude;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Include))
            {
                body["Include"] = request.Include;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceName))
            {
                body["InstanceName"] = request.InstanceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Options))
            {
                body["Options"] = request.Options;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OtsDetailShrink))
            {
                body["OtsDetail"] = request.OtsDetailShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Path))
            {
                body["Path"] = request.Path;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Rule))
            {
                body["Rule"] = request.Rule;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SpeedLimit))
            {
                body["SpeedLimit"] = request.SpeedLimit;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateBackupPlan",
                Version = "2017-09-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateBackupPlanResponse>(CallApi(params_, req, runtime));
        }

        /**
          * *   A backup schedule defines the data source, backup policy, and other configurations. After you execute a backup schedule, a backup job is generated to record the backup progress and the backup result. If a backup job is complete, a backup snapshot is generated. You can use a backup snapshot to create a restore job.
          * *   You can specify only one type of data source in a backup schedule.
          * *   You can specify only one interval as a backup cycle in a backup schedule.
          * *   Each backup schedule allows you to back up data to only one backup vault.
          *
          * @param tmpReq CreateBackupPlanRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return CreateBackupPlanResponse
         */
        public async Task<CreateBackupPlanResponse> CreateBackupPlanWithOptionsAsync(CreateBackupPlanRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateBackupPlanShrinkRequest request = new CreateBackupPlanShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DestDataSourceDetail))
            {
                request.DestDataSourceDetailShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DestDataSourceDetail, "DestDataSourceDetail", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Detail))
            {
                request.DetailShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Detail, "Detail", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.OtsDetail))
            {
                request.OtsDetailShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.OtsDetail, "OtsDetail", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackupType))
            {
                query["BackupType"] = request.BackupType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Bucket))
            {
                query["Bucket"] = request.Bucket;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChangeListPath))
            {
                query["ChangeListPath"] = request.ChangeListPath;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreateTime))
            {
                query["CreateTime"] = request.CreateTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CrossAccountRoleName))
            {
                query["CrossAccountRoleName"] = request.CrossAccountRoleName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CrossAccountType))
            {
                query["CrossAccountType"] = request.CrossAccountType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CrossAccountUserId))
            {
                query["CrossAccountUserId"] = request.CrossAccountUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestDataSourceDetailShrink))
            {
                query["DestDataSourceDetail"] = request.DestDataSourceDetailShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestDataSourceId))
            {
                query["DestDataSourceId"] = request.DestDataSourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestSourceType))
            {
                query["DestSourceType"] = request.DestSourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DetailShrink))
            {
                query["Detail"] = request.DetailShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileSystemId))
            {
                query["FileSystemId"] = request.FileSystemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeepLatestSnapshots))
            {
                query["KeepLatestSnapshots"] = request.KeepLatestSnapshots;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PlanName))
            {
                query["PlanName"] = request.PlanName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Prefix))
            {
                query["Prefix"] = request.Prefix;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Retention))
            {
                query["Retention"] = request.Retention;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Schedule))
            {
                query["Schedule"] = request.Schedule;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceType))
            {
                query["SourceType"] = request.SourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UdmRegionId))
            {
                query["UdmRegionId"] = request.UdmRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VaultId))
            {
                query["VaultId"] = request.VaultId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Exclude))
            {
                body["Exclude"] = request.Exclude;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Include))
            {
                body["Include"] = request.Include;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceName))
            {
                body["InstanceName"] = request.InstanceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Options))
            {
                body["Options"] = request.Options;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OtsDetailShrink))
            {
                body["OtsDetail"] = request.OtsDetailShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Path))
            {
                body["Path"] = request.Path;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Rule))
            {
                body["Rule"] = request.Rule;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SpeedLimit))
            {
                body["SpeedLimit"] = request.SpeedLimit;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateBackupPlan",
                Version = "2017-09-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateBackupPlanResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * *   A backup schedule defines the data source, backup policy, and other configurations. After you execute a backup schedule, a backup job is generated to record the backup progress and the backup result. If a backup job is complete, a backup snapshot is generated. You can use a backup snapshot to create a restore job.
          * *   You can specify only one type of data source in a backup schedule.
          * *   You can specify only one interval as a backup cycle in a backup schedule.
          * *   Each backup schedule allows you to back up data to only one backup vault.
          *
          * @param request CreateBackupPlanRequest
          * @return CreateBackupPlanResponse
         */
        public CreateBackupPlanResponse CreateBackupPlan(CreateBackupPlanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateBackupPlanWithOptions(request, runtime);
        }

        /**
          * *   A backup schedule defines the data source, backup policy, and other configurations. After you execute a backup schedule, a backup job is generated to record the backup progress and the backup result. If a backup job is complete, a backup snapshot is generated. You can use a backup snapshot to create a restore job.
          * *   You can specify only one type of data source in a backup schedule.
          * *   You can specify only one interval as a backup cycle in a backup schedule.
          * *   Each backup schedule allows you to back up data to only one backup vault.
          *
          * @param request CreateBackupPlanRequest
          * @return CreateBackupPlanResponse
         */
        public async Task<CreateBackupPlanResponse> CreateBackupPlanAsync(CreateBackupPlanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateBackupPlanWithOptionsAsync(request, runtime);
        }

        /**
          * Before you call this operation, make sure that you fully understand the billing methods and pricing of Hybrid Backup Recovery (HBR). For more information, see [Billable items and billing methods](~~89062~~).
          *
          * @param request CreateClientsRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return CreateClientsResponse
         */
        public CreateClientsResponse CreateClientsWithOptions(CreateClientsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlertSetting))
            {
                query["AlertSetting"] = request.AlertSetting;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientInfo))
            {
                query["ClientInfo"] = request.ClientInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UseHttps))
            {
                query["UseHttps"] = request.UseHttps;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VaultId))
            {
                query["VaultId"] = request.VaultId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateClients",
                Version = "2017-09-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateClientsResponse>(CallApi(params_, req, runtime));
        }

        /**
          * Before you call this operation, make sure that you fully understand the billing methods and pricing of Hybrid Backup Recovery (HBR). For more information, see [Billable items and billing methods](~~89062~~).
          *
          * @param request CreateClientsRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return CreateClientsResponse
         */
        public async Task<CreateClientsResponse> CreateClientsWithOptionsAsync(CreateClientsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlertSetting))
            {
                query["AlertSetting"] = request.AlertSetting;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientInfo))
            {
                query["ClientInfo"] = request.ClientInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UseHttps))
            {
                query["UseHttps"] = request.UseHttps;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VaultId))
            {
                query["VaultId"] = request.VaultId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateClients",
                Version = "2017-09-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateClientsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * Before you call this operation, make sure that you fully understand the billing methods and pricing of Hybrid Backup Recovery (HBR). For more information, see [Billable items and billing methods](~~89062~~).
          *
          * @param request CreateClientsRequest
          * @return CreateClientsResponse
         */
        public CreateClientsResponse CreateClients(CreateClientsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateClientsWithOptions(request, runtime);
        }

        /**
          * Before you call this operation, make sure that you fully understand the billing methods and pricing of Hybrid Backup Recovery (HBR). For more information, see [Billable items and billing methods](~~89062~~).
          *
          * @param request CreateClientsRequest
          * @return CreateClientsResponse
         */
        public async Task<CreateClientsResponse> CreateClientsAsync(CreateClientsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateClientsWithOptionsAsync(request, runtime);
        }

        /**
          * *   A backup plan defines the data source, backup policy, and other configurations. After you execute a backup plan, a backup job is generated to record the backup progress and the backup result. If a backup job is completed, a backup snapshot is generated. You can use a backup snapshot to create a restore job.
          * *   You can specify only one type of data source in a backup plan.
          * *   You can specify only one interval as a backup cycle in a backup plan.
          * *   Each backup plan allows you to back up data to only one backup vault.
          *
          * @param request CreateHanaBackupPlanRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return CreateHanaBackupPlanResponse
         */
        public CreateHanaBackupPlanResponse CreateHanaBackupPlanWithOptions(CreateHanaBackupPlanRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackupPrefix))
            {
                query["BackupPrefix"] = request.BackupPrefix;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackupType))
            {
                query["BackupType"] = request.BackupType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatabaseName))
            {
                query["DatabaseName"] = request.DatabaseName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PlanName))
            {
                query["PlanName"] = request.PlanName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Schedule))
            {
                query["Schedule"] = request.Schedule;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VaultId))
            {
                query["VaultId"] = request.VaultId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateHanaBackupPlan",
                Version = "2017-09-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateHanaBackupPlanResponse>(CallApi(params_, req, runtime));
        }

        /**
          * *   A backup plan defines the data source, backup policy, and other configurations. After you execute a backup plan, a backup job is generated to record the backup progress and the backup result. If a backup job is completed, a backup snapshot is generated. You can use a backup snapshot to create a restore job.
          * *   You can specify only one type of data source in a backup plan.
          * *   You can specify only one interval as a backup cycle in a backup plan.
          * *   Each backup plan allows you to back up data to only one backup vault.
          *
          * @param request CreateHanaBackupPlanRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return CreateHanaBackupPlanResponse
         */
        public async Task<CreateHanaBackupPlanResponse> CreateHanaBackupPlanWithOptionsAsync(CreateHanaBackupPlanRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackupPrefix))
            {
                query["BackupPrefix"] = request.BackupPrefix;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackupType))
            {
                query["BackupType"] = request.BackupType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatabaseName))
            {
                query["DatabaseName"] = request.DatabaseName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PlanName))
            {
                query["PlanName"] = request.PlanName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Schedule))
            {
                query["Schedule"] = request.Schedule;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VaultId))
            {
                query["VaultId"] = request.VaultId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateHanaBackupPlan",
                Version = "2017-09-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateHanaBackupPlanResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * *   A backup plan defines the data source, backup policy, and other configurations. After you execute a backup plan, a backup job is generated to record the backup progress and the backup result. If a backup job is completed, a backup snapshot is generated. You can use a backup snapshot to create a restore job.
          * *   You can specify only one type of data source in a backup plan.
          * *   You can specify only one interval as a backup cycle in a backup plan.
          * *   Each backup plan allows you to back up data to only one backup vault.
          *
          * @param request CreateHanaBackupPlanRequest
          * @return CreateHanaBackupPlanResponse
         */
        public CreateHanaBackupPlanResponse CreateHanaBackupPlan(CreateHanaBackupPlanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateHanaBackupPlanWithOptions(request, runtime);
        }

        /**
          * *   A backup plan defines the data source, backup policy, and other configurations. After you execute a backup plan, a backup job is generated to record the backup progress and the backup result. If a backup job is completed, a backup snapshot is generated. You can use a backup snapshot to create a restore job.
          * *   You can specify only one type of data source in a backup plan.
          * *   You can specify only one interval as a backup cycle in a backup plan.
          * *   Each backup plan allows you to back up data to only one backup vault.
          *
          * @param request CreateHanaBackupPlanRequest
          * @return CreateHanaBackupPlanResponse
         */
        public async Task<CreateHanaBackupPlanResponse> CreateHanaBackupPlanAsync(CreateHanaBackupPlanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateHanaBackupPlanWithOptionsAsync(request, runtime);
        }

        /**
          * To register an SAP HANA instance, you must configure the connection parameters of the SAP HANA instance. After the SAP HANA instance is registered, HBR installs an HBR client on the ECS instance that hosts the SAP HANA instance.
          *
          * @param request CreateHanaInstanceRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return CreateHanaInstanceResponse
         */
        public CreateHanaInstanceResponse CreateHanaInstanceWithOptions(CreateHanaInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlertSetting))
            {
                query["AlertSetting"] = request.AlertSetting;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EcsInstanceId))
            {
                query["EcsInstanceId"] = request.EcsInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HanaName))
            {
                query["HanaName"] = request.HanaName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Host))
            {
                query["Host"] = request.Host;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceNumber))
            {
                query["InstanceNumber"] = request.InstanceNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Password))
            {
                query["Password"] = request.Password;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Sid))
            {
                query["Sid"] = request.Sid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UseSsl))
            {
                query["UseSsl"] = request.UseSsl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserName))
            {
                query["UserName"] = request.UserName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ValidateCertificate))
            {
                query["ValidateCertificate"] = request.ValidateCertificate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VaultId))
            {
                query["VaultId"] = request.VaultId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateHanaInstance",
                Version = "2017-09-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateHanaInstanceResponse>(CallApi(params_, req, runtime));
        }

        /**
          * To register an SAP HANA instance, you must configure the connection parameters of the SAP HANA instance. After the SAP HANA instance is registered, HBR installs an HBR client on the ECS instance that hosts the SAP HANA instance.
          *
          * @param request CreateHanaInstanceRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return CreateHanaInstanceResponse
         */
        public async Task<CreateHanaInstanceResponse> CreateHanaInstanceWithOptionsAsync(CreateHanaInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlertSetting))
            {
                query["AlertSetting"] = request.AlertSetting;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EcsInstanceId))
            {
                query["EcsInstanceId"] = request.EcsInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HanaName))
            {
                query["HanaName"] = request.HanaName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Host))
            {
                query["Host"] = request.Host;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceNumber))
            {
                query["InstanceNumber"] = request.InstanceNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Password))
            {
                query["Password"] = request.Password;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Sid))
            {
                query["Sid"] = request.Sid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UseSsl))
            {
                query["UseSsl"] = request.UseSsl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserName))
            {
                query["UserName"] = request.UserName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ValidateCertificate))
            {
                query["ValidateCertificate"] = request.ValidateCertificate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VaultId))
            {
                query["VaultId"] = request.VaultId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateHanaInstance",
                Version = "2017-09-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateHanaInstanceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * To register an SAP HANA instance, you must configure the connection parameters of the SAP HANA instance. After the SAP HANA instance is registered, HBR installs an HBR client on the ECS instance that hosts the SAP HANA instance.
          *
          * @param request CreateHanaInstanceRequest
          * @return CreateHanaInstanceResponse
         */
        public CreateHanaInstanceResponse CreateHanaInstance(CreateHanaInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateHanaInstanceWithOptions(request, runtime);
        }

        /**
          * To register an SAP HANA instance, you must configure the connection parameters of the SAP HANA instance. After the SAP HANA instance is registered, HBR installs an HBR client on the ECS instance that hosts the SAP HANA instance.
          *
          * @param request CreateHanaInstanceRequest
          * @return CreateHanaInstanceResponse
         */
        public async Task<CreateHanaInstanceResponse> CreateHanaInstanceAsync(CreateHanaInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateHanaInstanceWithOptionsAsync(request, runtime);
        }

        /**
          * If you call this operation to restore a database, the database is restored to a specified state. Proceed with caution. For more information, see [Restore databases to an SAP HANA instance](~~101178~~).
          *
          * @param request CreateHanaRestoreRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return CreateHanaRestoreResponse
         */
        public CreateHanaRestoreResponse CreateHanaRestoreWithOptions(CreateHanaRestoreRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackupId))
            {
                query["BackupId"] = request.BackupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackupPrefix))
            {
                query["BackupPrefix"] = request.BackupPrefix;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CheckAccess))
            {
                query["CheckAccess"] = request.CheckAccess;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClearLog))
            {
                query["ClearLog"] = request.ClearLog;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatabaseName))
            {
                query["DatabaseName"] = request.DatabaseName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogPosition))
            {
                query["LogPosition"] = request.LogPosition;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MasterClientId))
            {
                query["MasterClientId"] = request.MasterClientId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mode))
            {
                query["Mode"] = request.Mode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecoveryPointInTime))
            {
                query["RecoveryPointInTime"] = request.RecoveryPointInTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SidAdmin))
            {
                query["SidAdmin"] = request.SidAdmin;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Source))
            {
                query["Source"] = request.Source;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceClusterId))
            {
                query["SourceClusterId"] = request.SourceClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SystemCopy))
            {
                query["SystemCopy"] = request.SystemCopy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UseCatalog))
            {
                query["UseCatalog"] = request.UseCatalog;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UseDelta))
            {
                query["UseDelta"] = request.UseDelta;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VaultId))
            {
                query["VaultId"] = request.VaultId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VolumeId))
            {
                query["VolumeId"] = request.VolumeId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateHanaRestore",
                Version = "2017-09-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateHanaRestoreResponse>(CallApi(params_, req, runtime));
        }

        /**
          * If you call this operation to restore a database, the database is restored to a specified state. Proceed with caution. For more information, see [Restore databases to an SAP HANA instance](~~101178~~).
          *
          * @param request CreateHanaRestoreRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return CreateHanaRestoreResponse
         */
        public async Task<CreateHanaRestoreResponse> CreateHanaRestoreWithOptionsAsync(CreateHanaRestoreRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackupId))
            {
                query["BackupId"] = request.BackupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackupPrefix))
            {
                query["BackupPrefix"] = request.BackupPrefix;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CheckAccess))
            {
                query["CheckAccess"] = request.CheckAccess;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClearLog))
            {
                query["ClearLog"] = request.ClearLog;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatabaseName))
            {
                query["DatabaseName"] = request.DatabaseName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogPosition))
            {
                query["LogPosition"] = request.LogPosition;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MasterClientId))
            {
                query["MasterClientId"] = request.MasterClientId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mode))
            {
                query["Mode"] = request.Mode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecoveryPointInTime))
            {
                query["RecoveryPointInTime"] = request.RecoveryPointInTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SidAdmin))
            {
                query["SidAdmin"] = request.SidAdmin;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Source))
            {
                query["Source"] = request.Source;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceClusterId))
            {
                query["SourceClusterId"] = request.SourceClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SystemCopy))
            {
                query["SystemCopy"] = request.SystemCopy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UseCatalog))
            {
                query["UseCatalog"] = request.UseCatalog;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UseDelta))
            {
                query["UseDelta"] = request.UseDelta;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VaultId))
            {
                query["VaultId"] = request.VaultId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VolumeId))
            {
                query["VolumeId"] = request.VolumeId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateHanaRestore",
                Version = "2017-09-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateHanaRestoreResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * If you call this operation to restore a database, the database is restored to a specified state. Proceed with caution. For more information, see [Restore databases to an SAP HANA instance](~~101178~~).
          *
          * @param request CreateHanaRestoreRequest
          * @return CreateHanaRestoreResponse
         */
        public CreateHanaRestoreResponse CreateHanaRestore(CreateHanaRestoreRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateHanaRestoreWithOptions(request, runtime);
        }

        /**
          * If you call this operation to restore a database, the database is restored to a specified state. Proceed with caution. For more information, see [Restore databases to an SAP HANA instance](~~101178~~).
          *
          * @param request CreateHanaRestoreRequest
          * @return CreateHanaRestoreResponse
         */
        public async Task<CreateHanaRestoreResponse> CreateHanaRestoreAsync(CreateHanaRestoreRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateHanaRestoreWithOptionsAsync(request, runtime);
        }

        /**
          * *   You can bind data sources to only one policy in each request.
          * *   Elastic Compute Service (ECS) instances can be bound to only one policy.
          *
          * @param tmpReq CreatePolicyBindingsRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return CreatePolicyBindingsResponse
         */
        public CreatePolicyBindingsResponse CreatePolicyBindingsWithOptions(CreatePolicyBindingsRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreatePolicyBindingsShrinkRequest request = new CreatePolicyBindingsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.PolicyBindingList))
            {
                request.PolicyBindingListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.PolicyBindingList, "PolicyBindingList", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyBindingListShrink))
            {
                query["PolicyBindingList"] = request.PolicyBindingListShrink;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyId))
            {
                body["PolicyId"] = request.PolicyId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreatePolicyBindings",
                Version = "2017-09-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreatePolicyBindingsResponse>(CallApi(params_, req, runtime));
        }

        /**
          * *   You can bind data sources to only one policy in each request.
          * *   Elastic Compute Service (ECS) instances can be bound to only one policy.
          *
          * @param tmpReq CreatePolicyBindingsRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return CreatePolicyBindingsResponse
         */
        public async Task<CreatePolicyBindingsResponse> CreatePolicyBindingsWithOptionsAsync(CreatePolicyBindingsRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreatePolicyBindingsShrinkRequest request = new CreatePolicyBindingsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.PolicyBindingList))
            {
                request.PolicyBindingListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.PolicyBindingList, "PolicyBindingList", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyBindingListShrink))
            {
                query["PolicyBindingList"] = request.PolicyBindingListShrink;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyId))
            {
                body["PolicyId"] = request.PolicyId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreatePolicyBindings",
                Version = "2017-09-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreatePolicyBindingsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * *   You can bind data sources to only one policy in each request.
          * *   Elastic Compute Service (ECS) instances can be bound to only one policy.
          *
          * @param request CreatePolicyBindingsRequest
          * @return CreatePolicyBindingsResponse
         */
        public CreatePolicyBindingsResponse CreatePolicyBindings(CreatePolicyBindingsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreatePolicyBindingsWithOptions(request, runtime);
        }

        /**
          * *   You can bind data sources to only one policy in each request.
          * *   Elastic Compute Service (ECS) instances can be bound to only one policy.
          *
          * @param request CreatePolicyBindingsRequest
          * @return CreatePolicyBindingsResponse
         */
        public async Task<CreatePolicyBindingsResponse> CreatePolicyBindingsAsync(CreatePolicyBindingsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreatePolicyBindingsWithOptionsAsync(request, runtime);
        }

        /**
          * A backup policy records the information required for backup. After you execute a backup policy, a backup job is generated to record the backup progress and the backup result. If a backup job is completed, a backup snapshot is generated. You can use a backup snapshot to create a restore job.
          * *   A backup policy supports multiple data sources. The data sources can be only Elastic Compute Service (ECS) instances.
          * *   You can specify only one interval as a backup cycle in a backup policy.
          * *   Each backup policy allows you to back up data to only one backup vault.
          *
          * @param tmpReq CreatePolicyV2Request
          * @param runtime runtime options for this request RuntimeOptions
          * @return CreatePolicyV2Response
         */
        public CreatePolicyV2Response CreatePolicyV2WithOptions(CreatePolicyV2Request tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreatePolicyV2ShrinkRequest request = new CreatePolicyV2ShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Rules))
            {
                request.RulesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Rules, "Rules", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyDescription))
            {
                body["PolicyDescription"] = request.PolicyDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyName))
            {
                body["PolicyName"] = request.PolicyName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RulesShrink))
            {
                body["Rules"] = request.RulesShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreatePolicyV2",
                Version = "2017-09-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreatePolicyV2Response>(CallApi(params_, req, runtime));
        }

        /**
          * A backup policy records the information required for backup. After you execute a backup policy, a backup job is generated to record the backup progress and the backup result. If a backup job is completed, a backup snapshot is generated. You can use a backup snapshot to create a restore job.
          * *   A backup policy supports multiple data sources. The data sources can be only Elastic Compute Service (ECS) instances.
          * *   You can specify only one interval as a backup cycle in a backup policy.
          * *   Each backup policy allows you to back up data to only one backup vault.
          *
          * @param tmpReq CreatePolicyV2Request
          * @param runtime runtime options for this request RuntimeOptions
          * @return CreatePolicyV2Response
         */
        public async Task<CreatePolicyV2Response> CreatePolicyV2WithOptionsAsync(CreatePolicyV2Request tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreatePolicyV2ShrinkRequest request = new CreatePolicyV2ShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Rules))
            {
                request.RulesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Rules, "Rules", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyDescription))
            {
                body["PolicyDescription"] = request.PolicyDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyName))
            {
                body["PolicyName"] = request.PolicyName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RulesShrink))
            {
                body["Rules"] = request.RulesShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreatePolicyV2",
                Version = "2017-09-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreatePolicyV2Response>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * A backup policy records the information required for backup. After you execute a backup policy, a backup job is generated to record the backup progress and the backup result. If a backup job is completed, a backup snapshot is generated. You can use a backup snapshot to create a restore job.
          * *   A backup policy supports multiple data sources. The data sources can be only Elastic Compute Service (ECS) instances.
          * *   You can specify only one interval as a backup cycle in a backup policy.
          * *   Each backup policy allows you to back up data to only one backup vault.
          *
          * @param request CreatePolicyV2Request
          * @return CreatePolicyV2Response
         */
        public CreatePolicyV2Response CreatePolicyV2(CreatePolicyV2Request request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreatePolicyV2WithOptions(request, runtime);
        }

        /**
          * A backup policy records the information required for backup. After you execute a backup policy, a backup job is generated to record the backup progress and the backup result. If a backup job is completed, a backup snapshot is generated. You can use a backup snapshot to create a restore job.
          * *   A backup policy supports multiple data sources. The data sources can be only Elastic Compute Service (ECS) instances.
          * *   You can specify only one interval as a backup cycle in a backup policy.
          * *   Each backup policy allows you to back up data to only one backup vault.
          *
          * @param request CreatePolicyV2Request
          * @return CreatePolicyV2Response
         */
        public async Task<CreatePolicyV2Response> CreatePolicyV2Async(CreatePolicyV2Request request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreatePolicyV2WithOptionsAsync(request, runtime);
        }

        /**
          * After a backup vault is created, the backup vault is in the INITIALIZING state, and the system automatically runs an initialization task to initialize the backup vault. After the initialization task is completed, the backup vault is in the CREATED state.
          *
          * @param request CreateReplicationVaultRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return CreateReplicationVaultResponse
         */
        public CreateReplicationVaultResponse CreateReplicationVaultWithOptions(CreateReplicationVaultRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RedundancyType))
            {
                query["RedundancyType"] = request.RedundancyType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReplicationSourceRegionId))
            {
                query["ReplicationSourceRegionId"] = request.ReplicationSourceRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReplicationSourceVaultId))
            {
                query["ReplicationSourceVaultId"] = request.ReplicationSourceVaultId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VaultName))
            {
                query["VaultName"] = request.VaultName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VaultRegionId))
            {
                query["VaultRegionId"] = request.VaultRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VaultStorageClass))
            {
                query["VaultStorageClass"] = request.VaultStorageClass;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateReplicationVault",
                Version = "2017-09-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateReplicationVaultResponse>(CallApi(params_, req, runtime));
        }

        /**
          * After a backup vault is created, the backup vault is in the INITIALIZING state, and the system automatically runs an initialization task to initialize the backup vault. After the initialization task is completed, the backup vault is in the CREATED state.
          *
          * @param request CreateReplicationVaultRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return CreateReplicationVaultResponse
         */
        public async Task<CreateReplicationVaultResponse> CreateReplicationVaultWithOptionsAsync(CreateReplicationVaultRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RedundancyType))
            {
                query["RedundancyType"] = request.RedundancyType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReplicationSourceRegionId))
            {
                query["ReplicationSourceRegionId"] = request.ReplicationSourceRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReplicationSourceVaultId))
            {
                query["ReplicationSourceVaultId"] = request.ReplicationSourceVaultId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VaultName))
            {
                query["VaultName"] = request.VaultName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VaultRegionId))
            {
                query["VaultRegionId"] = request.VaultRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VaultStorageClass))
            {
                query["VaultStorageClass"] = request.VaultStorageClass;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateReplicationVault",
                Version = "2017-09-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateReplicationVaultResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * After a backup vault is created, the backup vault is in the INITIALIZING state, and the system automatically runs an initialization task to initialize the backup vault. After the initialization task is completed, the backup vault is in the CREATED state.
          *
          * @param request CreateReplicationVaultRequest
          * @return CreateReplicationVaultResponse
         */
        public CreateReplicationVaultResponse CreateReplicationVault(CreateReplicationVaultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateReplicationVaultWithOptions(request, runtime);
        }

        /**
          * After a backup vault is created, the backup vault is in the INITIALIZING state, and the system automatically runs an initialization task to initialize the backup vault. After the initialization task is completed, the backup vault is in the CREATED state.
          *
          * @param request CreateReplicationVaultRequest
          * @return CreateReplicationVaultResponse
         */
        public async Task<CreateReplicationVaultResponse> CreateReplicationVaultAsync(CreateReplicationVaultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateReplicationVaultWithOptionsAsync(request, runtime);
        }

        /**
          * *   You must create a restore job based on the specified backup snapshot and restore destination.
          * *   The type of the data source from which you restore data must be the same as the type of the restore destination.
          *
          * @param tmpReq CreateRestoreJobRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return CreateRestoreJobResponse
         */
        public CreateRestoreJobResponse CreateRestoreJobWithOptions(CreateRestoreJobRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateRestoreJobShrinkRequest request = new CreateRestoreJobShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.FailbackDetail))
            {
                request.FailbackDetailShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.FailbackDetail, "FailbackDetail", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.OtsDetail))
            {
                request.OtsDetailShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.OtsDetail, "OtsDetail", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.UdmDetail))
            {
                request.UdmDetailShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.UdmDetail, "UdmDetail", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CrossAccountRoleName))
            {
                query["CrossAccountRoleName"] = request.CrossAccountRoleName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CrossAccountType))
            {
                query["CrossAccountType"] = request.CrossAccountType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CrossAccountUserId))
            {
                query["CrossAccountUserId"] = request.CrossAccountUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FailbackDetailShrink))
            {
                query["FailbackDetail"] = request.FailbackDetailShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InitiatedByAck))
            {
                query["InitiatedByAck"] = request.InitiatedByAck;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Options))
            {
                query["Options"] = request.Options;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RestoreType))
            {
                query["RestoreType"] = request.RestoreType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SnapshotHash))
            {
                query["SnapshotHash"] = request.SnapshotHash;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SnapshotId))
            {
                query["SnapshotId"] = request.SnapshotId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceType))
            {
                query["SourceType"] = request.SourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetBucket))
            {
                query["TargetBucket"] = request.TargetBucket;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetContainer))
            {
                query["TargetContainer"] = request.TargetContainer;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetContainerClusterId))
            {
                query["TargetContainerClusterId"] = request.TargetContainerClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetCreateTime))
            {
                query["TargetCreateTime"] = request.TargetCreateTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetFileSystemId))
            {
                query["TargetFileSystemId"] = request.TargetFileSystemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetInstanceName))
            {
                query["TargetInstanceName"] = request.TargetInstanceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetPrefix))
            {
                query["TargetPrefix"] = request.TargetPrefix;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetTableName))
            {
                query["TargetTableName"] = request.TargetTableName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetTime))
            {
                query["TargetTime"] = request.TargetTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UdmDetailShrink))
            {
                query["UdmDetail"] = request.UdmDetailShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UdmRegionId))
            {
                query["UdmRegionId"] = request.UdmRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VaultId))
            {
                query["VaultId"] = request.VaultId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Exclude))
            {
                body["Exclude"] = request.Exclude;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Include))
            {
                body["Include"] = request.Include;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OtsDetailShrink))
            {
                body["OtsDetail"] = request.OtsDetailShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetInstanceId))
            {
                body["TargetInstanceId"] = request.TargetInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetPath))
            {
                body["TargetPath"] = request.TargetPath;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateRestoreJob",
                Version = "2017-09-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateRestoreJobResponse>(CallApi(params_, req, runtime));
        }

        /**
          * *   You must create a restore job based on the specified backup snapshot and restore destination.
          * *   The type of the data source from which you restore data must be the same as the type of the restore destination.
          *
          * @param tmpReq CreateRestoreJobRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return CreateRestoreJobResponse
         */
        public async Task<CreateRestoreJobResponse> CreateRestoreJobWithOptionsAsync(CreateRestoreJobRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateRestoreJobShrinkRequest request = new CreateRestoreJobShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.FailbackDetail))
            {
                request.FailbackDetailShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.FailbackDetail, "FailbackDetail", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.OtsDetail))
            {
                request.OtsDetailShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.OtsDetail, "OtsDetail", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.UdmDetail))
            {
                request.UdmDetailShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.UdmDetail, "UdmDetail", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CrossAccountRoleName))
            {
                query["CrossAccountRoleName"] = request.CrossAccountRoleName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CrossAccountType))
            {
                query["CrossAccountType"] = request.CrossAccountType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CrossAccountUserId))
            {
                query["CrossAccountUserId"] = request.CrossAccountUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FailbackDetailShrink))
            {
                query["FailbackDetail"] = request.FailbackDetailShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InitiatedByAck))
            {
                query["InitiatedByAck"] = request.InitiatedByAck;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Options))
            {
                query["Options"] = request.Options;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RestoreType))
            {
                query["RestoreType"] = request.RestoreType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SnapshotHash))
            {
                query["SnapshotHash"] = request.SnapshotHash;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SnapshotId))
            {
                query["SnapshotId"] = request.SnapshotId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceType))
            {
                query["SourceType"] = request.SourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetBucket))
            {
                query["TargetBucket"] = request.TargetBucket;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetContainer))
            {
                query["TargetContainer"] = request.TargetContainer;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetContainerClusterId))
            {
                query["TargetContainerClusterId"] = request.TargetContainerClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetCreateTime))
            {
                query["TargetCreateTime"] = request.TargetCreateTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetFileSystemId))
            {
                query["TargetFileSystemId"] = request.TargetFileSystemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetInstanceName))
            {
                query["TargetInstanceName"] = request.TargetInstanceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetPrefix))
            {
                query["TargetPrefix"] = request.TargetPrefix;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetTableName))
            {
                query["TargetTableName"] = request.TargetTableName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetTime))
            {
                query["TargetTime"] = request.TargetTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UdmDetailShrink))
            {
                query["UdmDetail"] = request.UdmDetailShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UdmRegionId))
            {
                query["UdmRegionId"] = request.UdmRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VaultId))
            {
                query["VaultId"] = request.VaultId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Exclude))
            {
                body["Exclude"] = request.Exclude;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Include))
            {
                body["Include"] = request.Include;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OtsDetailShrink))
            {
                body["OtsDetail"] = request.OtsDetailShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetInstanceId))
            {
                body["TargetInstanceId"] = request.TargetInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetPath))
            {
                body["TargetPath"] = request.TargetPath;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateRestoreJob",
                Version = "2017-09-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateRestoreJobResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * *   You must create a restore job based on the specified backup snapshot and restore destination.
          * *   The type of the data source from which you restore data must be the same as the type of the restore destination.
          *
          * @param request CreateRestoreJobRequest
          * @return CreateRestoreJobResponse
         */
        public CreateRestoreJobResponse CreateRestoreJob(CreateRestoreJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateRestoreJobWithOptions(request, runtime);
        }

        /**
          * *   You must create a restore job based on the specified backup snapshot and restore destination.
          * *   The type of the data source from which you restore data must be the same as the type of the restore destination.
          *
          * @param request CreateRestoreJobRequest
          * @return CreateRestoreJobResponse
         */
        public async Task<CreateRestoreJobResponse> CreateRestoreJobAsync(CreateRestoreJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateRestoreJobWithOptionsAsync(request, runtime);
        }

        /**
          * 1.  You can directly upload a file to Object Storage Service (OSS) by using a form based on the returned value of this operation.
          * 2.  For more information about how to upload a file to OSS by using a form, see OSS documentation.
          * 3.  The system periodically deletes files that are uploaded to OSS.
          *
          * @param request CreateTempFileUploadUrlRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return CreateTempFileUploadUrlResponse
         */
        public CreateTempFileUploadUrlResponse CreateTempFileUploadUrlWithOptions(CreateTempFileUploadUrlRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileName))
            {
                query["FileName"] = request.FileName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateTempFileUploadUrl",
                Version = "2017-09-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateTempFileUploadUrlResponse>(CallApi(params_, req, runtime));
        }

        /**
          * 1.  You can directly upload a file to Object Storage Service (OSS) by using a form based on the returned value of this operation.
          * 2.  For more information about how to upload a file to OSS by using a form, see OSS documentation.
          * 3.  The system periodically deletes files that are uploaded to OSS.
          *
          * @param request CreateTempFileUploadUrlRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return CreateTempFileUploadUrlResponse
         */
        public async Task<CreateTempFileUploadUrlResponse> CreateTempFileUploadUrlWithOptionsAsync(CreateTempFileUploadUrlRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileName))
            {
                query["FileName"] = request.FileName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateTempFileUploadUrl",
                Version = "2017-09-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateTempFileUploadUrlResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * 1.  You can directly upload a file to Object Storage Service (OSS) by using a form based on the returned value of this operation.
          * 2.  For more information about how to upload a file to OSS by using a form, see OSS documentation.
          * 3.  The system periodically deletes files that are uploaded to OSS.
          *
          * @param request CreateTempFileUploadUrlRequest
          * @return CreateTempFileUploadUrlResponse
         */
        public CreateTempFileUploadUrlResponse CreateTempFileUploadUrl(CreateTempFileUploadUrlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateTempFileUploadUrlWithOptions(request, runtime);
        }

        /**
          * 1.  You can directly upload a file to Object Storage Service (OSS) by using a form based on the returned value of this operation.
          * 2.  For more information about how to upload a file to OSS by using a form, see OSS documentation.
          * 3.  The system periodically deletes files that are uploaded to OSS.
          *
          * @param request CreateTempFileUploadUrlRequest
          * @return CreateTempFileUploadUrlResponse
         */
        public async Task<CreateTempFileUploadUrlResponse> CreateTempFileUploadUrlAsync(CreateTempFileUploadUrlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateTempFileUploadUrlWithOptionsAsync(request, runtime);
        }

        /**
          * *   Each Alibaba Cloud account can create up to 100 backup vaults.
          * *   After a backup vault is created, the backup vault is in the INITIALIZING state, and the system automatically runs an initialization task to initialize the backup vault. After the initialization task is completed, the backup vault is in the CREATED state. A backup job can use a backup vault to store backup data only if the backup vault is in the CREATED state.
          *
          * @param request CreateVaultRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return CreateVaultResponse
         */
        public CreateVaultResponse CreateVaultWithOptions(CreateVaultRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EncryptType))
            {
                query["EncryptType"] = request.EncryptType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KmsKeyId))
            {
                query["KmsKeyId"] = request.KmsKeyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VaultName))
            {
                query["VaultName"] = request.VaultName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VaultRegionId))
            {
                query["VaultRegionId"] = request.VaultRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VaultStorageClass))
            {
                query["VaultStorageClass"] = request.VaultStorageClass;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VaultType))
            {
                query["VaultType"] = request.VaultType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateVault",
                Version = "2017-09-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateVaultResponse>(CallApi(params_, req, runtime));
        }

        /**
          * *   Each Alibaba Cloud account can create up to 100 backup vaults.
          * *   After a backup vault is created, the backup vault is in the INITIALIZING state, and the system automatically runs an initialization task to initialize the backup vault. After the initialization task is completed, the backup vault is in the CREATED state. A backup job can use a backup vault to store backup data only if the backup vault is in the CREATED state.
          *
          * @param request CreateVaultRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return CreateVaultResponse
         */
        public async Task<CreateVaultResponse> CreateVaultWithOptionsAsync(CreateVaultRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EncryptType))
            {
                query["EncryptType"] = request.EncryptType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KmsKeyId))
            {
                query["KmsKeyId"] = request.KmsKeyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VaultName))
            {
                query["VaultName"] = request.VaultName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VaultRegionId))
            {
                query["VaultRegionId"] = request.VaultRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VaultStorageClass))
            {
                query["VaultStorageClass"] = request.VaultStorageClass;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VaultType))
            {
                query["VaultType"] = request.VaultType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateVault",
                Version = "2017-09-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateVaultResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * *   Each Alibaba Cloud account can create up to 100 backup vaults.
          * *   After a backup vault is created, the backup vault is in the INITIALIZING state, and the system automatically runs an initialization task to initialize the backup vault. After the initialization task is completed, the backup vault is in the CREATED state. A backup job can use a backup vault to store backup data only if the backup vault is in the CREATED state.
          *
          * @param request CreateVaultRequest
          * @return CreateVaultResponse
         */
        public CreateVaultResponse CreateVault(CreateVaultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateVaultWithOptions(request, runtime);
        }

        /**
          * *   Each Alibaba Cloud account can create up to 100 backup vaults.
          * *   After a backup vault is created, the backup vault is in the INITIALIZING state, and the system automatically runs an initialization task to initialize the backup vault. After the initialization task is completed, the backup vault is in the CREATED state. A backup job can use a backup vault to store backup data only if the backup vault is in the CREATED state.
          *
          * @param request CreateVaultRequest
          * @return CreateVaultResponse
         */
        public async Task<CreateVaultResponse> CreateVaultAsync(CreateVaultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateVaultWithOptionsAsync(request, runtime);
        }

        /**
          * *   You cannot delete an active backup client from which a heartbeat packet is received within the previous hour. After you call the UninstallBackupClients operation to uninstall a backup client, the status of the backup client changes to inactive.
          * *   This operation deletes the resources that are related to the backup client. The following resources are included:
          *     *   Backup plans
          *     *   Backup jobs
          *     *   Backup files
          *
          * @param request DeleteBackupClientRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DeleteBackupClientResponse
         */
        public DeleteBackupClientResponse DeleteBackupClientWithOptions(DeleteBackupClientRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientId))
            {
                query["ClientId"] = request.ClientId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteBackupClient",
                Version = "2017-09-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteBackupClientResponse>(CallApi(params_, req, runtime));
        }

        /**
          * *   You cannot delete an active backup client from which a heartbeat packet is received within the previous hour. After you call the UninstallBackupClients operation to uninstall a backup client, the status of the backup client changes to inactive.
          * *   This operation deletes the resources that are related to the backup client. The following resources are included:
          *     *   Backup plans
          *     *   Backup jobs
          *     *   Backup files
          *
          * @param request DeleteBackupClientRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DeleteBackupClientResponse
         */
        public async Task<DeleteBackupClientResponse> DeleteBackupClientWithOptionsAsync(DeleteBackupClientRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientId))
            {
                query["ClientId"] = request.ClientId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteBackupClient",
                Version = "2017-09-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteBackupClientResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * *   You cannot delete an active backup client from which a heartbeat packet is received within the previous hour. After you call the UninstallBackupClients operation to uninstall a backup client, the status of the backup client changes to inactive.
          * *   This operation deletes the resources that are related to the backup client. The following resources are included:
          *     *   Backup plans
          *     *   Backup jobs
          *     *   Backup files
          *
          * @param request DeleteBackupClientRequest
          * @return DeleteBackupClientResponse
         */
        public DeleteBackupClientResponse DeleteBackupClient(DeleteBackupClientRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteBackupClientWithOptions(request, runtime);
        }

        /**
          * *   You cannot delete an active backup client from which a heartbeat packet is received within the previous hour. After you call the UninstallBackupClients operation to uninstall a backup client, the status of the backup client changes to inactive.
          * *   This operation deletes the resources that are related to the backup client. The following resources are included:
          *     *   Backup plans
          *     *   Backup jobs
          *     *   Backup files
          *
          * @param request DeleteBackupClientRequest
          * @return DeleteBackupClientResponse
         */
        public async Task<DeleteBackupClientResponse> DeleteBackupClientAsync(DeleteBackupClientRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteBackupClientWithOptionsAsync(request, runtime);
        }

        /**
          * This operation deletes only the resources that are related to HBR clients. The resources include backup plans, backup jobs, and backup snapshots. The operation does not delete HBR clients.
          *
          * @param tmpReq DeleteBackupClientResourceRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DeleteBackupClientResourceResponse
         */
        public DeleteBackupClientResourceResponse DeleteBackupClientResourceWithOptions(DeleteBackupClientResourceRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DeleteBackupClientResourceShrinkRequest request = new DeleteBackupClientResourceShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ClientIds))
            {
                request.ClientIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ClientIds, "ClientIds", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientIdsShrink))
            {
                query["ClientIds"] = request.ClientIdsShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteBackupClientResource",
                Version = "2017-09-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteBackupClientResourceResponse>(CallApi(params_, req, runtime));
        }

        /**
          * This operation deletes only the resources that are related to HBR clients. The resources include backup plans, backup jobs, and backup snapshots. The operation does not delete HBR clients.
          *
          * @param tmpReq DeleteBackupClientResourceRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DeleteBackupClientResourceResponse
         */
        public async Task<DeleteBackupClientResourceResponse> DeleteBackupClientResourceWithOptionsAsync(DeleteBackupClientResourceRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DeleteBackupClientResourceShrinkRequest request = new DeleteBackupClientResourceShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ClientIds))
            {
                request.ClientIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ClientIds, "ClientIds", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientIdsShrink))
            {
                query["ClientIds"] = request.ClientIdsShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteBackupClientResource",
                Version = "2017-09-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteBackupClientResourceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * This operation deletes only the resources that are related to HBR clients. The resources include backup plans, backup jobs, and backup snapshots. The operation does not delete HBR clients.
          *
          * @param request DeleteBackupClientResourceRequest
          * @return DeleteBackupClientResourceResponse
         */
        public DeleteBackupClientResourceResponse DeleteBackupClientResource(DeleteBackupClientResourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteBackupClientResourceWithOptions(request, runtime);
        }

        /**
          * This operation deletes only the resources that are related to HBR clients. The resources include backup plans, backup jobs, and backup snapshots. The operation does not delete HBR clients.
          *
          * @param request DeleteBackupClientResourceRequest
          * @return DeleteBackupClientResourceResponse
         */
        public async Task<DeleteBackupClientResourceResponse> DeleteBackupClientResourceAsync(DeleteBackupClientResourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteBackupClientResourceWithOptionsAsync(request, runtime);
        }

        /**
          * *   If you delete a backup plan, the backup jobs are also deleted.
          * *   If you delete a backup plan, the created snapshot files are not deleted.
          *
          * @param request DeleteBackupPlanRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DeleteBackupPlanResponse
         */
        public DeleteBackupPlanResponse DeleteBackupPlanWithOptions(DeleteBackupPlanRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PlanId))
            {
                query["PlanId"] = request.PlanId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceType))
            {
                query["SourceType"] = request.SourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VaultId))
            {
                query["VaultId"] = request.VaultId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteBackupPlan",
                Version = "2017-09-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteBackupPlanResponse>(CallApi(params_, req, runtime));
        }

        /**
          * *   If you delete a backup plan, the backup jobs are also deleted.
          * *   If you delete a backup plan, the created snapshot files are not deleted.
          *
          * @param request DeleteBackupPlanRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DeleteBackupPlanResponse
         */
        public async Task<DeleteBackupPlanResponse> DeleteBackupPlanWithOptionsAsync(DeleteBackupPlanRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PlanId))
            {
                query["PlanId"] = request.PlanId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceType))
            {
                query["SourceType"] = request.SourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VaultId))
            {
                query["VaultId"] = request.VaultId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteBackupPlan",
                Version = "2017-09-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteBackupPlanResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * *   If you delete a backup plan, the backup jobs are also deleted.
          * *   If you delete a backup plan, the created snapshot files are not deleted.
          *
          * @param request DeleteBackupPlanRequest
          * @return DeleteBackupPlanResponse
         */
        public DeleteBackupPlanResponse DeleteBackupPlan(DeleteBackupPlanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteBackupPlanWithOptions(request, runtime);
        }

        /**
          * *   If you delete a backup plan, the backup jobs are also deleted.
          * *   If you delete a backup plan, the created snapshot files are not deleted.
          *
          * @param request DeleteBackupPlanRequest
          * @return DeleteBackupPlanResponse
         */
        public async Task<DeleteBackupPlanResponse> DeleteBackupPlanAsync(DeleteBackupPlanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteBackupPlanWithOptionsAsync(request, runtime);
        }

        public DeleteClientResponse DeleteClientWithOptions(DeleteClientRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientId))
            {
                query["ClientId"] = request.ClientId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VaultId))
            {
                query["VaultId"] = request.VaultId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteClient",
                Version = "2017-09-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteClientResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeleteClientResponse> DeleteClientWithOptionsAsync(DeleteClientRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientId))
            {
                query["ClientId"] = request.ClientId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VaultId))
            {
                query["VaultId"] = request.VaultId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteClient",
                Version = "2017-09-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteClientResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DeleteClientResponse DeleteClient(DeleteClientRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteClientWithOptions(request, runtime);
        }

        public async Task<DeleteClientResponse> DeleteClientAsync(DeleteClientRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteClientWithOptionsAsync(request, runtime);
        }

        public DeleteHanaBackupPlanResponse DeleteHanaBackupPlanWithOptions(DeleteHanaBackupPlanRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PlanId))
            {
                query["PlanId"] = request.PlanId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VaultId))
            {
                query["VaultId"] = request.VaultId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteHanaBackupPlan",
                Version = "2017-09-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteHanaBackupPlanResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeleteHanaBackupPlanResponse> DeleteHanaBackupPlanWithOptionsAsync(DeleteHanaBackupPlanRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PlanId))
            {
                query["PlanId"] = request.PlanId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VaultId))
            {
                query["VaultId"] = request.VaultId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteHanaBackupPlan",
                Version = "2017-09-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteHanaBackupPlanResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DeleteHanaBackupPlanResponse DeleteHanaBackupPlan(DeleteHanaBackupPlanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteHanaBackupPlanWithOptions(request, runtime);
        }

        public async Task<DeleteHanaBackupPlanResponse> DeleteHanaBackupPlanAsync(DeleteHanaBackupPlanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteHanaBackupPlanWithOptionsAsync(request, runtime);
        }

        /**
          * If you delete an SAP HANA instance, the existing backup data is also deleted and the running backup and restore jobs fail to be completed. Before you delete the SAP HANA instance, make sure that you no longer need the data in the HBR client of the instance and no backup or restore jobs are running for the instance. To delete an SAP HANA instance, you must specify the security identifier (SID) of the instance. The SID is three characters in length and starts with a letter. For more information, see [How to find sid user and instance number of HANA db?](https://answers.sap.com/questions/555192/how-to-find-sid-user-and-instance-number-of-hana-d.html?)
          *
          * @param request DeleteHanaInstanceRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DeleteHanaInstanceResponse
         */
        public DeleteHanaInstanceResponse DeleteHanaInstanceWithOptions(DeleteHanaInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Sid))
            {
                query["Sid"] = request.Sid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VaultId))
            {
                query["VaultId"] = request.VaultId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteHanaInstance",
                Version = "2017-09-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteHanaInstanceResponse>(CallApi(params_, req, runtime));
        }

        /**
          * If you delete an SAP HANA instance, the existing backup data is also deleted and the running backup and restore jobs fail to be completed. Before you delete the SAP HANA instance, make sure that you no longer need the data in the HBR client of the instance and no backup or restore jobs are running for the instance. To delete an SAP HANA instance, you must specify the security identifier (SID) of the instance. The SID is three characters in length and starts with a letter. For more information, see [How to find sid user and instance number of HANA db?](https://answers.sap.com/questions/555192/how-to-find-sid-user-and-instance-number-of-hana-d.html?)
          *
          * @param request DeleteHanaInstanceRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DeleteHanaInstanceResponse
         */
        public async Task<DeleteHanaInstanceResponse> DeleteHanaInstanceWithOptionsAsync(DeleteHanaInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Sid))
            {
                query["Sid"] = request.Sid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VaultId))
            {
                query["VaultId"] = request.VaultId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteHanaInstance",
                Version = "2017-09-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteHanaInstanceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * If you delete an SAP HANA instance, the existing backup data is also deleted and the running backup and restore jobs fail to be completed. Before you delete the SAP HANA instance, make sure that you no longer need the data in the HBR client of the instance and no backup or restore jobs are running for the instance. To delete an SAP HANA instance, you must specify the security identifier (SID) of the instance. The SID is three characters in length and starts with a letter. For more information, see [How to find sid user and instance number of HANA db?](https://answers.sap.com/questions/555192/how-to-find-sid-user-and-instance-number-of-hana-d.html?)
          *
          * @param request DeleteHanaInstanceRequest
          * @return DeleteHanaInstanceResponse
         */
        public DeleteHanaInstanceResponse DeleteHanaInstance(DeleteHanaInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteHanaInstanceWithOptions(request, runtime);
        }

        /**
          * If you delete an SAP HANA instance, the existing backup data is also deleted and the running backup and restore jobs fail to be completed. Before you delete the SAP HANA instance, make sure that you no longer need the data in the HBR client of the instance and no backup or restore jobs are running for the instance. To delete an SAP HANA instance, you must specify the security identifier (SID) of the instance. The SID is three characters in length and starts with a letter. For more information, see [How to find sid user and instance number of HANA db?](https://answers.sap.com/questions/555192/how-to-find-sid-user-and-instance-number-of-hana-d.html?)
          *
          * @param request DeleteHanaInstanceRequest
          * @return DeleteHanaInstanceResponse
         */
        public async Task<DeleteHanaInstanceResponse> DeleteHanaInstanceAsync(DeleteHanaInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteHanaInstanceWithOptionsAsync(request, runtime);
        }

        public DeletePolicyBindingResponse DeletePolicyBindingWithOptions(DeletePolicyBindingRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DeletePolicyBindingShrinkRequest request = new DeletePolicyBindingShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DataSourceIds))
            {
                request.DataSourceIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DataSourceIds, "DataSourceIds", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceType))
            {
                query["SourceType"] = request.SourceType;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSourceIdsShrink))
            {
                body["DataSourceIds"] = request.DataSourceIdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyId))
            {
                body["PolicyId"] = request.PolicyId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeletePolicyBinding",
                Version = "2017-09-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeletePolicyBindingResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeletePolicyBindingResponse> DeletePolicyBindingWithOptionsAsync(DeletePolicyBindingRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DeletePolicyBindingShrinkRequest request = new DeletePolicyBindingShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DataSourceIds))
            {
                request.DataSourceIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DataSourceIds, "DataSourceIds", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceType))
            {
                query["SourceType"] = request.SourceType;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSourceIdsShrink))
            {
                body["DataSourceIds"] = request.DataSourceIdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyId))
            {
                body["PolicyId"] = request.PolicyId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeletePolicyBinding",
                Version = "2017-09-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeletePolicyBindingResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DeletePolicyBindingResponse DeletePolicyBinding(DeletePolicyBindingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeletePolicyBindingWithOptions(request, runtime);
        }

        public async Task<DeletePolicyBindingResponse> DeletePolicyBindingAsync(DeletePolicyBindingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeletePolicyBindingWithOptionsAsync(request, runtime);
        }

        /**
          * If you delete a backup policy, the backup policy is disassociated with all data sources. Proceed with caution.
          *
          * @param request DeletePolicyV2Request
          * @param runtime runtime options for this request RuntimeOptions
          * @return DeletePolicyV2Response
         */
        public DeletePolicyV2Response DeletePolicyV2WithOptions(DeletePolicyV2Request request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyId))
            {
                body["PolicyId"] = request.PolicyId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeletePolicyV2",
                Version = "2017-09-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeletePolicyV2Response>(CallApi(params_, req, runtime));
        }

        /**
          * If you delete a backup policy, the backup policy is disassociated with all data sources. Proceed with caution.
          *
          * @param request DeletePolicyV2Request
          * @param runtime runtime options for this request RuntimeOptions
          * @return DeletePolicyV2Response
         */
        public async Task<DeletePolicyV2Response> DeletePolicyV2WithOptionsAsync(DeletePolicyV2Request request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyId))
            {
                body["PolicyId"] = request.PolicyId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeletePolicyV2",
                Version = "2017-09-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeletePolicyV2Response>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * If you delete a backup policy, the backup policy is disassociated with all data sources. Proceed with caution.
          *
          * @param request DeletePolicyV2Request
          * @return DeletePolicyV2Response
         */
        public DeletePolicyV2Response DeletePolicyV2(DeletePolicyV2Request request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeletePolicyV2WithOptions(request, runtime);
        }

        /**
          * If you delete a backup policy, the backup policy is disassociated with all data sources. Proceed with caution.
          *
          * @param request DeletePolicyV2Request
          * @return DeletePolicyV2Response
         */
        public async Task<DeletePolicyV2Response> DeletePolicyV2Async(DeletePolicyV2Request request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeletePolicyV2WithOptionsAsync(request, runtime);
        }

        /**
          * If you delete the most recent backup file for a data source, you must set the `Force parameter to true`. Otherwise, an error occurs.
          *
          * @param request DeleteSnapshotRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DeleteSnapshotResponse
         */
        public DeleteSnapshotResponse DeleteSnapshotWithOptions(DeleteSnapshotRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientId))
            {
                query["ClientId"] = request.ClientId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Force))
            {
                query["Force"] = request.Force;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SnapshotId))
            {
                query["SnapshotId"] = request.SnapshotId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceType))
            {
                query["SourceType"] = request.SourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Token))
            {
                query["Token"] = request.Token;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VaultId))
            {
                query["VaultId"] = request.VaultId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteSnapshot",
                Version = "2017-09-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteSnapshotResponse>(CallApi(params_, req, runtime));
        }

        /**
          * If you delete the most recent backup file for a data source, you must set the `Force parameter to true`. Otherwise, an error occurs.
          *
          * @param request DeleteSnapshotRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DeleteSnapshotResponse
         */
        public async Task<DeleteSnapshotResponse> DeleteSnapshotWithOptionsAsync(DeleteSnapshotRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientId))
            {
                query["ClientId"] = request.ClientId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Force))
            {
                query["Force"] = request.Force;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SnapshotId))
            {
                query["SnapshotId"] = request.SnapshotId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceType))
            {
                query["SourceType"] = request.SourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Token))
            {
                query["Token"] = request.Token;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VaultId))
            {
                query["VaultId"] = request.VaultId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteSnapshot",
                Version = "2017-09-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteSnapshotResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * If you delete the most recent backup file for a data source, you must set the `Force parameter to true`. Otherwise, an error occurs.
          *
          * @param request DeleteSnapshotRequest
          * @return DeleteSnapshotResponse
         */
        public DeleteSnapshotResponse DeleteSnapshot(DeleteSnapshotRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteSnapshotWithOptions(request, runtime);
        }

        /**
          * If you delete the most recent backup file for a data source, you must set the `Force parameter to true`. Otherwise, an error occurs.
          *
          * @param request DeleteSnapshotRequest
          * @return DeleteSnapshotResponse
         */
        public async Task<DeleteSnapshotResponse> DeleteSnapshotAsync(DeleteSnapshotRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteSnapshotWithOptionsAsync(request, runtime);
        }

        /**
          * *   You cannot delete a backup vault within 2 hours after the backup vault is created or a backup vault that is in the INITIALIZING state.
          * *   After you delete a backup vault, all resources that are associated with the backup vault are deleted. The resources include backup clients of earlier versions, backup plans, backup jobs, snapshots, and restore jobs.
          *
          * @param request DeleteVaultRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DeleteVaultResponse
         */
        public DeleteVaultResponse DeleteVaultWithOptions(DeleteVaultRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Token))
            {
                query["Token"] = request.Token;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VaultId))
            {
                query["VaultId"] = request.VaultId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteVault",
                Version = "2017-09-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteVaultResponse>(CallApi(params_, req, runtime));
        }

        /**
          * *   You cannot delete a backup vault within 2 hours after the backup vault is created or a backup vault that is in the INITIALIZING state.
          * *   After you delete a backup vault, all resources that are associated with the backup vault are deleted. The resources include backup clients of earlier versions, backup plans, backup jobs, snapshots, and restore jobs.
          *
          * @param request DeleteVaultRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DeleteVaultResponse
         */
        public async Task<DeleteVaultResponse> DeleteVaultWithOptionsAsync(DeleteVaultRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Token))
            {
                query["Token"] = request.Token;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VaultId))
            {
                query["VaultId"] = request.VaultId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteVault",
                Version = "2017-09-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteVaultResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * *   You cannot delete a backup vault within 2 hours after the backup vault is created or a backup vault that is in the INITIALIZING state.
          * *   After you delete a backup vault, all resources that are associated with the backup vault are deleted. The resources include backup clients of earlier versions, backup plans, backup jobs, snapshots, and restore jobs.
          *
          * @param request DeleteVaultRequest
          * @return DeleteVaultResponse
         */
        public DeleteVaultResponse DeleteVault(DeleteVaultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteVaultWithOptions(request, runtime);
        }

        /**
          * *   You cannot delete a backup vault within 2 hours after the backup vault is created or a backup vault that is in the INITIALIZING state.
          * *   After you delete a backup vault, all resources that are associated with the backup vault are deleted. The resources include backup clients of earlier versions, backup plans, backup jobs, snapshots, and restore jobs.
          *
          * @param request DeleteVaultRequest
          * @return DeleteVaultResponse
         */
        public async Task<DeleteVaultResponse> DeleteVaultAsync(DeleteVaultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteVaultWithOptionsAsync(request, runtime);
        }

        public DescribeBackupClientsResponse DescribeBackupClientsWithOptions(DescribeBackupClientsRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DescribeBackupClientsShrinkRequest request = new DescribeBackupClientsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ClientIds))
            {
                request.ClientIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ClientIds, "ClientIds", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.InstanceIds))
            {
                request.InstanceIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.InstanceIds, "InstanceIds", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientType))
            {
                query["ClientType"] = request.ClientType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CrossAccountRoleName))
            {
                query["CrossAccountRoleName"] = request.CrossAccountRoleName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CrossAccountType))
            {
                query["CrossAccountType"] = request.CrossAccountType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CrossAccountUserId))
            {
                query["CrossAccountUserId"] = request.CrossAccountUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientIdsShrink))
            {
                body["ClientIds"] = request.ClientIdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceIdsShrink))
            {
                body["InstanceIds"] = request.InstanceIdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                body["Tag"] = request.Tag;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeBackupClients",
                Version = "2017-09-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeBackupClientsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeBackupClientsResponse> DescribeBackupClientsWithOptionsAsync(DescribeBackupClientsRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DescribeBackupClientsShrinkRequest request = new DescribeBackupClientsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ClientIds))
            {
                request.ClientIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ClientIds, "ClientIds", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.InstanceIds))
            {
                request.InstanceIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.InstanceIds, "InstanceIds", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientType))
            {
                query["ClientType"] = request.ClientType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CrossAccountRoleName))
            {
                query["CrossAccountRoleName"] = request.CrossAccountRoleName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CrossAccountType))
            {
                query["CrossAccountType"] = request.CrossAccountType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CrossAccountUserId))
            {
                query["CrossAccountUserId"] = request.CrossAccountUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientIdsShrink))
            {
                body["ClientIds"] = request.ClientIdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceIdsShrink))
            {
                body["InstanceIds"] = request.InstanceIdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                body["Tag"] = request.Tag;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeBackupClients",
                Version = "2017-09-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeBackupClientsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeBackupClientsResponse DescribeBackupClients(DescribeBackupClientsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeBackupClientsWithOptions(request, runtime);
        }

        public async Task<DescribeBackupClientsResponse> DescribeBackupClientsAsync(DescribeBackupClientsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeBackupClientsWithOptionsAsync(request, runtime);
        }

        public DescribeBackupJobs2Response DescribeBackupJobs2WithOptions(DescribeBackupJobs2Request request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Filters))
            {
                query["Filters"] = request.Filters;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortDirection))
            {
                query["SortDirection"] = request.SortDirection;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceType))
            {
                query["SourceType"] = request.SourceType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeBackupJobs2",
                Version = "2017-09-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeBackupJobs2Response>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeBackupJobs2Response> DescribeBackupJobs2WithOptionsAsync(DescribeBackupJobs2Request request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Filters))
            {
                query["Filters"] = request.Filters;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortDirection))
            {
                query["SortDirection"] = request.SortDirection;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceType))
            {
                query["SourceType"] = request.SourceType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeBackupJobs2",
                Version = "2017-09-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeBackupJobs2Response>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeBackupJobs2Response DescribeBackupJobs2(DescribeBackupJobs2Request request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeBackupJobs2WithOptions(request, runtime);
        }

        public async Task<DescribeBackupJobs2Response> DescribeBackupJobs2Async(DescribeBackupJobs2Request request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeBackupJobs2WithOptionsAsync(request, runtime);
        }

        public DescribeBackupPlansResponse DescribeBackupPlansWithOptions(DescribeBackupPlansRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Filters))
            {
                query["Filters"] = request.Filters;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceType))
            {
                query["SourceType"] = request.SourceType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeBackupPlans",
                Version = "2017-09-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeBackupPlansResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeBackupPlansResponse> DescribeBackupPlansWithOptionsAsync(DescribeBackupPlansRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Filters))
            {
                query["Filters"] = request.Filters;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceType))
            {
                query["SourceType"] = request.SourceType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeBackupPlans",
                Version = "2017-09-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeBackupPlansResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeBackupPlansResponse DescribeBackupPlans(DescribeBackupPlansRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeBackupPlansWithOptions(request, runtime);
        }

        public async Task<DescribeBackupPlansResponse> DescribeBackupPlansAsync(DescribeBackupPlansRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeBackupPlansWithOptionsAsync(request, runtime);
        }

        /**
          * This operation is applicable only to SAP HANA backup. For backup clients of other data sources, call the DescribeBackupClients operation.
          *
          * @param request DescribeClientsRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeClientsResponse
         */
        public DescribeClientsResponse DescribeClientsWithOptions(DescribeClientsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientId))
            {
                query["ClientId"] = request.ClientId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientType))
            {
                query["ClientType"] = request.ClientType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceType))
            {
                query["SourceType"] = request.SourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VaultId))
            {
                query["VaultId"] = request.VaultId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeClients",
                Version = "2017-09-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeClientsResponse>(CallApi(params_, req, runtime));
        }

        /**
          * This operation is applicable only to SAP HANA backup. For backup clients of other data sources, call the DescribeBackupClients operation.
          *
          * @param request DescribeClientsRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeClientsResponse
         */
        public async Task<DescribeClientsResponse> DescribeClientsWithOptionsAsync(DescribeClientsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientId))
            {
                query["ClientId"] = request.ClientId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientType))
            {
                query["ClientType"] = request.ClientType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceType))
            {
                query["SourceType"] = request.SourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VaultId))
            {
                query["VaultId"] = request.VaultId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeClients",
                Version = "2017-09-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeClientsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * This operation is applicable only to SAP HANA backup. For backup clients of other data sources, call the DescribeBackupClients operation.
          *
          * @param request DescribeClientsRequest
          * @return DescribeClientsResponse
         */
        public DescribeClientsResponse DescribeClients(DescribeClientsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeClientsWithOptions(request, runtime);
        }

        /**
          * This operation is applicable only to SAP HANA backup. For backup clients of other data sources, call the DescribeBackupClients operation.
          *
          * @param request DescribeClientsRequest
          * @return DescribeClientsResponse
         */
        public async Task<DescribeClientsResponse> DescribeClientsAsync(DescribeClientsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeClientsWithOptionsAsync(request, runtime);
        }

        /**
          * You can call this operation to query only Container Service for Kubernetes (ACK) clusters.
          *
          * @param request DescribeContainerClusterRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeContainerClusterResponse
         */
        public DescribeContainerClusterResponse DescribeContainerClusterWithOptions(DescribeContainerClusterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Identifier))
            {
                query["Identifier"] = request.Identifier;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeContainerCluster",
                Version = "2017-09-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeContainerClusterResponse>(CallApi(params_, req, runtime));
        }

        /**
          * You can call this operation to query only Container Service for Kubernetes (ACK) clusters.
          *
          * @param request DescribeContainerClusterRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeContainerClusterResponse
         */
        public async Task<DescribeContainerClusterResponse> DescribeContainerClusterWithOptionsAsync(DescribeContainerClusterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Identifier))
            {
                query["Identifier"] = request.Identifier;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeContainerCluster",
                Version = "2017-09-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeContainerClusterResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * You can call this operation to query only Container Service for Kubernetes (ACK) clusters.
          *
          * @param request DescribeContainerClusterRequest
          * @return DescribeContainerClusterResponse
         */
        public DescribeContainerClusterResponse DescribeContainerCluster(DescribeContainerClusterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeContainerClusterWithOptions(request, runtime);
        }

        /**
          * You can call this operation to query only Container Service for Kubernetes (ACK) clusters.
          *
          * @param request DescribeContainerClusterRequest
          * @return DescribeContainerClusterResponse
         */
        public async Task<DescribeContainerClusterResponse> DescribeContainerClusterAsync(DescribeContainerClusterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeContainerClusterWithOptionsAsync(request, runtime);
        }

        public DescribeCrossAccountsResponse DescribeCrossAccountsWithOptions(DescribeCrossAccountsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeCrossAccounts",
                Version = "2017-09-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeCrossAccountsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeCrossAccountsResponse> DescribeCrossAccountsWithOptionsAsync(DescribeCrossAccountsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeCrossAccounts",
                Version = "2017-09-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeCrossAccountsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeCrossAccountsResponse DescribeCrossAccounts(DescribeCrossAccountsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeCrossAccountsWithOptions(request, runtime);
        }

        public async Task<DescribeCrossAccountsResponse> DescribeCrossAccountsAsync(DescribeCrossAccountsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeCrossAccountsWithOptionsAsync(request, runtime);
        }

        public DescribeHanaBackupPlansResponse DescribeHanaBackupPlansWithOptions(DescribeHanaBackupPlansRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatabaseName))
            {
                query["DatabaseName"] = request.DatabaseName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VaultId))
            {
                query["VaultId"] = request.VaultId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeHanaBackupPlans",
                Version = "2017-09-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeHanaBackupPlansResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeHanaBackupPlansResponse> DescribeHanaBackupPlansWithOptionsAsync(DescribeHanaBackupPlansRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatabaseName))
            {
                query["DatabaseName"] = request.DatabaseName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VaultId))
            {
                query["VaultId"] = request.VaultId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeHanaBackupPlans",
                Version = "2017-09-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeHanaBackupPlansResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeHanaBackupPlansResponse DescribeHanaBackupPlans(DescribeHanaBackupPlansRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeHanaBackupPlansWithOptions(request, runtime);
        }

        public async Task<DescribeHanaBackupPlansResponse> DescribeHanaBackupPlansAsync(DescribeHanaBackupPlansRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeHanaBackupPlansWithOptionsAsync(request, runtime);
        }

        /**
          * If you want to query the backup retention period of a database, you can call the DescribeHanaRetentionSetting operation.
          *
          * @param request DescribeHanaBackupSettingRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeHanaBackupSettingResponse
         */
        public DescribeHanaBackupSettingResponse DescribeHanaBackupSettingWithOptions(DescribeHanaBackupSettingRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatabaseName))
            {
                query["DatabaseName"] = request.DatabaseName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VaultId))
            {
                query["VaultId"] = request.VaultId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeHanaBackupSetting",
                Version = "2017-09-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeHanaBackupSettingResponse>(CallApi(params_, req, runtime));
        }

        /**
          * If you want to query the backup retention period of a database, you can call the DescribeHanaRetentionSetting operation.
          *
          * @param request DescribeHanaBackupSettingRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeHanaBackupSettingResponse
         */
        public async Task<DescribeHanaBackupSettingResponse> DescribeHanaBackupSettingWithOptionsAsync(DescribeHanaBackupSettingRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatabaseName))
            {
                query["DatabaseName"] = request.DatabaseName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VaultId))
            {
                query["VaultId"] = request.VaultId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeHanaBackupSetting",
                Version = "2017-09-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeHanaBackupSettingResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * If you want to query the backup retention period of a database, you can call the DescribeHanaRetentionSetting operation.
          *
          * @param request DescribeHanaBackupSettingRequest
          * @return DescribeHanaBackupSettingResponse
         */
        public DescribeHanaBackupSettingResponse DescribeHanaBackupSetting(DescribeHanaBackupSettingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeHanaBackupSettingWithOptions(request, runtime);
        }

        /**
          * If you want to query the backup retention period of a database, you can call the DescribeHanaRetentionSetting operation.
          *
          * @param request DescribeHanaBackupSettingRequest
          * @return DescribeHanaBackupSettingResponse
         */
        public async Task<DescribeHanaBackupSettingResponse> DescribeHanaBackupSettingAsync(DescribeHanaBackupSettingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeHanaBackupSettingWithOptionsAsync(request, runtime);
        }

        /**
          * After you call the DescribeHanaBackupsAsync operation to query the SAP HANA backups that meet the specified conditions, call the DescribeTask operation to query the execution result of the asynchronous job.
          *
          * @param request DescribeHanaBackupsAsyncRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeHanaBackupsAsyncResponse
         */
        public DescribeHanaBackupsAsyncResponse DescribeHanaBackupsAsyncWithOptions(DescribeHanaBackupsAsyncRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatabaseName))
            {
                query["DatabaseName"] = request.DatabaseName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncludeDifferential))
            {
                query["IncludeDifferential"] = request.IncludeDifferential;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncludeIncremental))
            {
                query["IncludeIncremental"] = request.IncludeIncremental;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncludeLog))
            {
                query["IncludeLog"] = request.IncludeLog;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogPosition))
            {
                query["LogPosition"] = request.LogPosition;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mode))
            {
                query["Mode"] = request.Mode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecoveryPointInTime))
            {
                query["RecoveryPointInTime"] = request.RecoveryPointInTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Source))
            {
                query["Source"] = request.Source;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceClusterId))
            {
                query["SourceClusterId"] = request.SourceClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SystemCopy))
            {
                query["SystemCopy"] = request.SystemCopy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UseBackint))
            {
                query["UseBackint"] = request.UseBackint;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VaultId))
            {
                query["VaultId"] = request.VaultId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VolumeId))
            {
                query["VolumeId"] = request.VolumeId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeHanaBackupsAsync",
                Version = "2017-09-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeHanaBackupsAsyncResponse>(CallApi(params_, req, runtime));
        }

        /**
          * After you call the DescribeHanaBackupsAsync operation to query the SAP HANA backups that meet the specified conditions, call the DescribeTask operation to query the execution result of the asynchronous job.
          *
          * @param request DescribeHanaBackupsAsyncRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeHanaBackupsAsyncResponse
         */
        public async Task<DescribeHanaBackupsAsyncResponse> DescribeHanaBackupsAsyncWithOptionsAsync(DescribeHanaBackupsAsyncRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatabaseName))
            {
                query["DatabaseName"] = request.DatabaseName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncludeDifferential))
            {
                query["IncludeDifferential"] = request.IncludeDifferential;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncludeIncremental))
            {
                query["IncludeIncremental"] = request.IncludeIncremental;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncludeLog))
            {
                query["IncludeLog"] = request.IncludeLog;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogPosition))
            {
                query["LogPosition"] = request.LogPosition;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mode))
            {
                query["Mode"] = request.Mode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecoveryPointInTime))
            {
                query["RecoveryPointInTime"] = request.RecoveryPointInTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Source))
            {
                query["Source"] = request.Source;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceClusterId))
            {
                query["SourceClusterId"] = request.SourceClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SystemCopy))
            {
                query["SystemCopy"] = request.SystemCopy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UseBackint))
            {
                query["UseBackint"] = request.UseBackint;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VaultId))
            {
                query["VaultId"] = request.VaultId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VolumeId))
            {
                query["VolumeId"] = request.VolumeId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeHanaBackupsAsync",
                Version = "2017-09-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeHanaBackupsAsyncResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * After you call the DescribeHanaBackupsAsync operation to query the SAP HANA backups that meet the specified conditions, call the DescribeTask operation to query the execution result of the asynchronous job.
          *
          * @param request DescribeHanaBackupsAsyncRequest
          * @return DescribeHanaBackupsAsyncResponse
         */
        public DescribeHanaBackupsAsyncResponse DescribeHanaBackupsAsync(DescribeHanaBackupsAsyncRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeHanaBackupsAsyncWithOptions(request, runtime);
        }

        /**
          * After you call the DescribeHanaBackupsAsync operation to query the SAP HANA backups that meet the specified conditions, call the DescribeTask operation to query the execution result of the asynchronous job.
          *
          * @param request DescribeHanaBackupsAsyncRequest
          * @return DescribeHanaBackupsAsyncResponse
         */
        public async Task<DescribeHanaBackupsAsyncResponse> DescribeHanaBackupsAsyncAsync(DescribeHanaBackupsAsyncRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeHanaBackupsAsyncWithOptionsAsync(request, runtime);
        }

        /**
          * After you register an SAP HANA instance and install a backup client on the instance, you can call this operation to query the information about SAP HANA databases. You can call the StartHanaDatabaseAsync operation to start a database and call the StopHanaDatabaseAsync operation to stop a database.
          *
          * @param request DescribeHanaDatabasesRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeHanaDatabasesResponse
         */
        public DescribeHanaDatabasesResponse DescribeHanaDatabasesWithOptions(DescribeHanaDatabasesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VaultId))
            {
                query["VaultId"] = request.VaultId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeHanaDatabases",
                Version = "2017-09-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeHanaDatabasesResponse>(CallApi(params_, req, runtime));
        }

        /**
          * After you register an SAP HANA instance and install a backup client on the instance, you can call this operation to query the information about SAP HANA databases. You can call the StartHanaDatabaseAsync operation to start a database and call the StopHanaDatabaseAsync operation to stop a database.
          *
          * @param request DescribeHanaDatabasesRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeHanaDatabasesResponse
         */
        public async Task<DescribeHanaDatabasesResponse> DescribeHanaDatabasesWithOptionsAsync(DescribeHanaDatabasesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VaultId))
            {
                query["VaultId"] = request.VaultId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeHanaDatabases",
                Version = "2017-09-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeHanaDatabasesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * After you register an SAP HANA instance and install a backup client on the instance, you can call this operation to query the information about SAP HANA databases. You can call the StartHanaDatabaseAsync operation to start a database and call the StopHanaDatabaseAsync operation to stop a database.
          *
          * @param request DescribeHanaDatabasesRequest
          * @return DescribeHanaDatabasesResponse
         */
        public DescribeHanaDatabasesResponse DescribeHanaDatabases(DescribeHanaDatabasesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeHanaDatabasesWithOptions(request, runtime);
        }

        /**
          * After you register an SAP HANA instance and install a backup client on the instance, you can call this operation to query the information about SAP HANA databases. You can call the StartHanaDatabaseAsync operation to start a database and call the StopHanaDatabaseAsync operation to stop a database.
          *
          * @param request DescribeHanaDatabasesRequest
          * @return DescribeHanaDatabasesResponse
         */
        public async Task<DescribeHanaDatabasesResponse> DescribeHanaDatabasesAsync(DescribeHanaDatabasesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeHanaDatabasesWithOptionsAsync(request, runtime);
        }

        public DescribeHanaInstancesResponse DescribeHanaInstancesWithOptions(DescribeHanaInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VaultId))
            {
                query["VaultId"] = request.VaultId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                body["Tag"] = request.Tag;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeHanaInstances",
                Version = "2017-09-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeHanaInstancesResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeHanaInstancesResponse> DescribeHanaInstancesWithOptionsAsync(DescribeHanaInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VaultId))
            {
                query["VaultId"] = request.VaultId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                body["Tag"] = request.Tag;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeHanaInstances",
                Version = "2017-09-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeHanaInstancesResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeHanaInstancesResponse DescribeHanaInstances(DescribeHanaInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeHanaInstancesWithOptions(request, runtime);
        }

        public async Task<DescribeHanaInstancesResponse> DescribeHanaInstancesAsync(DescribeHanaInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeHanaInstancesWithOptionsAsync(request, runtime);
        }

        public DescribeHanaRestoresResponse DescribeHanaRestoresWithOptions(DescribeHanaRestoresRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackupId))
            {
                query["BackupId"] = request.BackupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatabaseName))
            {
                query["DatabaseName"] = request.DatabaseName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RestoreId))
            {
                query["RestoreId"] = request.RestoreId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RestoreStatus))
            {
                query["RestoreStatus"] = request.RestoreStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VaultId))
            {
                query["VaultId"] = request.VaultId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeHanaRestores",
                Version = "2017-09-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeHanaRestoresResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeHanaRestoresResponse> DescribeHanaRestoresWithOptionsAsync(DescribeHanaRestoresRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackupId))
            {
                query["BackupId"] = request.BackupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatabaseName))
            {
                query["DatabaseName"] = request.DatabaseName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RestoreId))
            {
                query["RestoreId"] = request.RestoreId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RestoreStatus))
            {
                query["RestoreStatus"] = request.RestoreStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VaultId))
            {
                query["VaultId"] = request.VaultId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeHanaRestores",
                Version = "2017-09-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeHanaRestoresResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeHanaRestoresResponse DescribeHanaRestores(DescribeHanaRestoresRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeHanaRestoresWithOptions(request, runtime);
        }

        public async Task<DescribeHanaRestoresResponse> DescribeHanaRestoresAsync(DescribeHanaRestoresRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeHanaRestoresWithOptionsAsync(request, runtime);
        }

        /**
          * *   If you want to query the backup parameters of a database, you can call the DescribeHanaBackupSetting operation.
          * *   HBR deletes the expired catalogs and data that are related to Backint and file backup. The deleted catalogs and data cannot be restored. We recommend that you set the retention period based on your business requirements.
          *
          * @param request DescribeHanaRetentionSettingRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeHanaRetentionSettingResponse
         */
        public DescribeHanaRetentionSettingResponse DescribeHanaRetentionSettingWithOptions(DescribeHanaRetentionSettingRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatabaseName))
            {
                query["DatabaseName"] = request.DatabaseName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VaultId))
            {
                query["VaultId"] = request.VaultId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeHanaRetentionSetting",
                Version = "2017-09-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeHanaRetentionSettingResponse>(CallApi(params_, req, runtime));
        }

        /**
          * *   If you want to query the backup parameters of a database, you can call the DescribeHanaBackupSetting operation.
          * *   HBR deletes the expired catalogs and data that are related to Backint and file backup. The deleted catalogs and data cannot be restored. We recommend that you set the retention period based on your business requirements.
          *
          * @param request DescribeHanaRetentionSettingRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DescribeHanaRetentionSettingResponse
         */
        public async Task<DescribeHanaRetentionSettingResponse> DescribeHanaRetentionSettingWithOptionsAsync(DescribeHanaRetentionSettingRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatabaseName))
            {
                query["DatabaseName"] = request.DatabaseName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VaultId))
            {
                query["VaultId"] = request.VaultId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeHanaRetentionSetting",
                Version = "2017-09-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeHanaRetentionSettingResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * *   If you want to query the backup parameters of a database, you can call the DescribeHanaBackupSetting operation.
          * *   HBR deletes the expired catalogs and data that are related to Backint and file backup. The deleted catalogs and data cannot be restored. We recommend that you set the retention period based on your business requirements.
          *
          * @param request DescribeHanaRetentionSettingRequest
          * @return DescribeHanaRetentionSettingResponse
         */
        public DescribeHanaRetentionSettingResponse DescribeHanaRetentionSetting(DescribeHanaRetentionSettingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeHanaRetentionSettingWithOptions(request, runtime);
        }

        /**
          * *   If you want to query the backup parameters of a database, you can call the DescribeHanaBackupSetting operation.
          * *   HBR deletes the expired catalogs and data that are related to Backint and file backup. The deleted catalogs and data cannot be restored. We recommend that you set the retention period based on your business requirements.
          *
          * @param request DescribeHanaRetentionSettingRequest
          * @return DescribeHanaRetentionSettingResponse
         */
        public async Task<DescribeHanaRetentionSettingResponse> DescribeHanaRetentionSettingAsync(DescribeHanaRetentionSettingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeHanaRetentionSettingWithOptionsAsync(request, runtime);
        }

        public DescribeOtsTableSnapshotsResponse DescribeOtsTableSnapshotsWithOptions(DescribeOtsTableSnapshotsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CrossAccountRoleName))
            {
                query["CrossAccountRoleName"] = request.CrossAccountRoleName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CrossAccountType))
            {
                query["CrossAccountType"] = request.CrossAccountType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CrossAccountUserId))
            {
                query["CrossAccountUserId"] = request.CrossAccountUserId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                body["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Limit))
            {
                body["Limit"] = request.Limit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                body["NextToken"] = request.NextToken;
            }
            Dictionary<string, object> bodyFlat = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OtsInstances))
            {
                bodyFlat["OtsInstances"] = request.OtsInstances;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SnapshotIds))
            {
                bodyFlat["SnapshotIds"] = request.SnapshotIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                body["StartTime"] = request.StartTime;
            }
            body = TeaConverter.merge<object>
            (
                body,
                AlibabaCloud.OpenApiUtil.Client.Query(bodyFlat)
            );
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeOtsTableSnapshots",
                Version = "2017-09-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeOtsTableSnapshotsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeOtsTableSnapshotsResponse> DescribeOtsTableSnapshotsWithOptionsAsync(DescribeOtsTableSnapshotsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CrossAccountRoleName))
            {
                query["CrossAccountRoleName"] = request.CrossAccountRoleName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CrossAccountType))
            {
                query["CrossAccountType"] = request.CrossAccountType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CrossAccountUserId))
            {
                query["CrossAccountUserId"] = request.CrossAccountUserId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                body["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Limit))
            {
                body["Limit"] = request.Limit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                body["NextToken"] = request.NextToken;
            }
            Dictionary<string, object> bodyFlat = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OtsInstances))
            {
                bodyFlat["OtsInstances"] = request.OtsInstances;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SnapshotIds))
            {
                bodyFlat["SnapshotIds"] = request.SnapshotIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                body["StartTime"] = request.StartTime;
            }
            body = TeaConverter.merge<object>
            (
                body,
                AlibabaCloud.OpenApiUtil.Client.Query(bodyFlat)
            );
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeOtsTableSnapshots",
                Version = "2017-09-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeOtsTableSnapshotsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeOtsTableSnapshotsResponse DescribeOtsTableSnapshots(DescribeOtsTableSnapshotsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeOtsTableSnapshotsWithOptions(request, runtime);
        }

        public async Task<DescribeOtsTableSnapshotsResponse> DescribeOtsTableSnapshotsAsync(DescribeOtsTableSnapshotsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeOtsTableSnapshotsWithOptionsAsync(request, runtime);
        }

        public DescribePoliciesV2Response DescribePoliciesV2WithOptions(DescribePoliciesV2Request request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                body["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                body["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyId))
            {
                body["PolicyId"] = request.PolicyId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribePoliciesV2",
                Version = "2017-09-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribePoliciesV2Response>(CallApi(params_, req, runtime));
        }

        public async Task<DescribePoliciesV2Response> DescribePoliciesV2WithOptionsAsync(DescribePoliciesV2Request request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                body["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                body["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyId))
            {
                body["PolicyId"] = request.PolicyId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribePoliciesV2",
                Version = "2017-09-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribePoliciesV2Response>(await CallApiAsync(params_, req, runtime));
        }

        public DescribePoliciesV2Response DescribePoliciesV2(DescribePoliciesV2Request request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribePoliciesV2WithOptions(request, runtime);
        }

        public async Task<DescribePoliciesV2Response> DescribePoliciesV2Async(DescribePoliciesV2Request request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribePoliciesV2WithOptionsAsync(request, runtime);
        }

        public DescribePolicyBindingsResponse DescribePolicyBindingsWithOptions(DescribePolicyBindingsRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DescribePolicyBindingsShrinkRequest request = new DescribePolicyBindingsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DataSourceIds))
            {
                request.DataSourceIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DataSourceIds, "DataSourceIds", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Filters))
            {
                query["Filters"] = request.Filters;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceType))
            {
                query["SourceType"] = request.SourceType;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSourceIdsShrink))
            {
                body["DataSourceIds"] = request.DataSourceIdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                body["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                body["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyId))
            {
                body["PolicyId"] = request.PolicyId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribePolicyBindings",
                Version = "2017-09-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribePolicyBindingsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribePolicyBindingsResponse> DescribePolicyBindingsWithOptionsAsync(DescribePolicyBindingsRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DescribePolicyBindingsShrinkRequest request = new DescribePolicyBindingsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DataSourceIds))
            {
                request.DataSourceIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DataSourceIds, "DataSourceIds", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Filters))
            {
                query["Filters"] = request.Filters;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceType))
            {
                query["SourceType"] = request.SourceType;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSourceIdsShrink))
            {
                body["DataSourceIds"] = request.DataSourceIdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                body["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                body["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyId))
            {
                body["PolicyId"] = request.PolicyId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribePolicyBindings",
                Version = "2017-09-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribePolicyBindingsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribePolicyBindingsResponse DescribePolicyBindings(DescribePolicyBindingsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribePolicyBindingsWithOptions(request, runtime);
        }

        public async Task<DescribePolicyBindingsResponse> DescribePolicyBindingsAsync(DescribePolicyBindingsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribePolicyBindingsWithOptionsAsync(request, runtime);
        }

        public DescribeRecoverableOtsInstancesResponse DescribeRecoverableOtsInstancesWithOptions(DescribeRecoverableOtsInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CrossAccountRoleName))
            {
                query["CrossAccountRoleName"] = request.CrossAccountRoleName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CrossAccountType))
            {
                query["CrossAccountType"] = request.CrossAccountType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CrossAccountUserId))
            {
                query["CrossAccountUserId"] = request.CrossAccountUserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeRecoverableOtsInstances",
                Version = "2017-09-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeRecoverableOtsInstancesResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeRecoverableOtsInstancesResponse> DescribeRecoverableOtsInstancesWithOptionsAsync(DescribeRecoverableOtsInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CrossAccountRoleName))
            {
                query["CrossAccountRoleName"] = request.CrossAccountRoleName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CrossAccountType))
            {
                query["CrossAccountType"] = request.CrossAccountType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CrossAccountUserId))
            {
                query["CrossAccountUserId"] = request.CrossAccountUserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeRecoverableOtsInstances",
                Version = "2017-09-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeRecoverableOtsInstancesResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeRecoverableOtsInstancesResponse DescribeRecoverableOtsInstances(DescribeRecoverableOtsInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeRecoverableOtsInstancesWithOptions(request, runtime);
        }

        public async Task<DescribeRecoverableOtsInstancesResponse> DescribeRecoverableOtsInstancesAsync(DescribeRecoverableOtsInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeRecoverableOtsInstancesWithOptionsAsync(request, runtime);
        }

        public DescribeRegionsResponse DescribeRegionsWithOptions(DescribeRegionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NeedVaultCount))
            {
                query["NeedVaultCount"] = request.NeedVaultCount;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeRegions",
                Version = "2017-09-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeRegionsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeRegionsResponse> DescribeRegionsWithOptionsAsync(DescribeRegionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NeedVaultCount))
            {
                query["NeedVaultCount"] = request.NeedVaultCount;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeRegions",
                Version = "2017-09-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeRegionsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeRegionsResponse DescribeRegions(DescribeRegionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeRegionsWithOptions(request, runtime);
        }

        public async Task<DescribeRegionsResponse> DescribeRegionsAsync(DescribeRegionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeRegionsWithOptionsAsync(request, runtime);
        }

        public DescribeRestoreJobs2Response DescribeRestoreJobs2WithOptions(DescribeRestoreJobs2Request request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Filters))
            {
                query["Filters"] = request.Filters;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RestoreType))
            {
                query["RestoreType"] = request.RestoreType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeRestoreJobs2",
                Version = "2017-09-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeRestoreJobs2Response>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeRestoreJobs2Response> DescribeRestoreJobs2WithOptionsAsync(DescribeRestoreJobs2Request request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Filters))
            {
                query["Filters"] = request.Filters;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RestoreType))
            {
                query["RestoreType"] = request.RestoreType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeRestoreJobs2",
                Version = "2017-09-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeRestoreJobs2Response>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeRestoreJobs2Response DescribeRestoreJobs2(DescribeRestoreJobs2Request request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeRestoreJobs2WithOptions(request, runtime);
        }

        public async Task<DescribeRestoreJobs2Response> DescribeRestoreJobs2Async(DescribeRestoreJobs2Request request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeRestoreJobs2WithOptionsAsync(request, runtime);
        }

        public DescribeTaskResponse DescribeTaskWithOptions(DescribeTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                query["TaskId"] = request.TaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Token))
            {
                query["Token"] = request.Token;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeTask",
                Version = "2017-09-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeTaskResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeTaskResponse> DescribeTaskWithOptionsAsync(DescribeTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                query["TaskId"] = request.TaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Token))
            {
                query["Token"] = request.Token;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeTask",
                Version = "2017-09-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeTaskResponse DescribeTask(DescribeTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeTaskWithOptions(request, runtime);
        }

        public async Task<DescribeTaskResponse> DescribeTaskAsync(DescribeTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeTaskWithOptionsAsync(request, runtime);
        }

        public DescribeUdmSnapshotsResponse DescribeUdmSnapshotsWithOptions(DescribeUdmSnapshotsRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DescribeUdmSnapshotsShrinkRequest request = new DescribeUdmSnapshotsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SnapshotIds))
            {
                request.SnapshotIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SnapshotIds, "SnapshotIds", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DiskId))
            {
                query["DiskId"] = request.DiskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobId))
            {
                query["JobId"] = request.JobId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceType))
            {
                query["SourceType"] = request.SourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UdmRegionId))
            {
                query["UdmRegionId"] = request.UdmRegionId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SnapshotIdsShrink))
            {
                body["SnapshotIds"] = request.SnapshotIdsShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeUdmSnapshots",
                Version = "2017-09-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeUdmSnapshotsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeUdmSnapshotsResponse> DescribeUdmSnapshotsWithOptionsAsync(DescribeUdmSnapshotsRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DescribeUdmSnapshotsShrinkRequest request = new DescribeUdmSnapshotsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SnapshotIds))
            {
                request.SnapshotIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SnapshotIds, "SnapshotIds", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DiskId))
            {
                query["DiskId"] = request.DiskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobId))
            {
                query["JobId"] = request.JobId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceType))
            {
                query["SourceType"] = request.SourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UdmRegionId))
            {
                query["UdmRegionId"] = request.UdmRegionId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SnapshotIdsShrink))
            {
                body["SnapshotIds"] = request.SnapshotIdsShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeUdmSnapshots",
                Version = "2017-09-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeUdmSnapshotsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeUdmSnapshotsResponse DescribeUdmSnapshots(DescribeUdmSnapshotsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeUdmSnapshotsWithOptions(request, runtime);
        }

        public async Task<DescribeUdmSnapshotsResponse> DescribeUdmSnapshotsAsync(DescribeUdmSnapshotsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeUdmSnapshotsWithOptionsAsync(request, runtime);
        }

        public DescribeVaultReplicationRegionsResponse DescribeVaultReplicationRegionsWithOptions(DescribeVaultReplicationRegionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Token))
            {
                query["Token"] = request.Token;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VaultId))
            {
                query["VaultId"] = request.VaultId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeVaultReplicationRegions",
                Version = "2017-09-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeVaultReplicationRegionsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeVaultReplicationRegionsResponse> DescribeVaultReplicationRegionsWithOptionsAsync(DescribeVaultReplicationRegionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Token))
            {
                query["Token"] = request.Token;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VaultId))
            {
                query["VaultId"] = request.VaultId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeVaultReplicationRegions",
                Version = "2017-09-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeVaultReplicationRegionsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeVaultReplicationRegionsResponse DescribeVaultReplicationRegions(DescribeVaultReplicationRegionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeVaultReplicationRegionsWithOptions(request, runtime);
        }

        public async Task<DescribeVaultReplicationRegionsResponse> DescribeVaultReplicationRegionsAsync(DescribeVaultReplicationRegionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeVaultReplicationRegionsWithOptionsAsync(request, runtime);
        }

        public DescribeVaultsResponse DescribeVaultsWithOptions(DescribeVaultsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VaultId))
            {
                query["VaultId"] = request.VaultId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VaultRegionId))
            {
                query["VaultRegionId"] = request.VaultRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VaultType))
            {
                query["VaultType"] = request.VaultType;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                body["Tag"] = request.Tag;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeVaults",
                Version = "2017-09-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeVaultsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeVaultsResponse> DescribeVaultsWithOptionsAsync(DescribeVaultsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VaultId))
            {
                query["VaultId"] = request.VaultId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VaultRegionId))
            {
                query["VaultRegionId"] = request.VaultRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VaultType))
            {
                query["VaultType"] = request.VaultType;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                body["Tag"] = request.Tag;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeVaults",
                Version = "2017-09-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeVaultsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeVaultsResponse DescribeVaults(DescribeVaultsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeVaultsWithOptions(request, runtime);
        }

        public async Task<DescribeVaultsResponse> DescribeVaultsAsync(DescribeVaultsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeVaultsWithOptionsAsync(request, runtime);
        }

        /**
          * *   If the request is successful, the mount target is deleted.
          * *   After you create a backup plan for an Apsara File Storage NAS file system, HBR automatically creates a mount target for the file system. You can call this operation to delete the mount target. In the **Status** column of the mount target of the NAS file system, the following information is displayed: **This mount target is created by an Alibaba Cloud internal service and cannot be operated. Service name: HBR**.
          *
          * @param request DetachNasFileSystemRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DetachNasFileSystemResponse
         */
        public DetachNasFileSystemResponse DetachNasFileSystemWithOptions(DetachNasFileSystemRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreateTime))
            {
                query["CreateTime"] = request.CreateTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CrossAccountRoleName))
            {
                query["CrossAccountRoleName"] = request.CrossAccountRoleName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CrossAccountType))
            {
                query["CrossAccountType"] = request.CrossAccountType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CrossAccountUserId))
            {
                query["CrossAccountUserId"] = request.CrossAccountUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileSystemId))
            {
                query["FileSystemId"] = request.FileSystemId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DetachNasFileSystem",
                Version = "2017-09-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DetachNasFileSystemResponse>(CallApi(params_, req, runtime));
        }

        /**
          * *   If the request is successful, the mount target is deleted.
          * *   After you create a backup plan for an Apsara File Storage NAS file system, HBR automatically creates a mount target for the file system. You can call this operation to delete the mount target. In the **Status** column of the mount target of the NAS file system, the following information is displayed: **This mount target is created by an Alibaba Cloud internal service and cannot be operated. Service name: HBR**.
          *
          * @param request DetachNasFileSystemRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DetachNasFileSystemResponse
         */
        public async Task<DetachNasFileSystemResponse> DetachNasFileSystemWithOptionsAsync(DetachNasFileSystemRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreateTime))
            {
                query["CreateTime"] = request.CreateTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CrossAccountRoleName))
            {
                query["CrossAccountRoleName"] = request.CrossAccountRoleName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CrossAccountType))
            {
                query["CrossAccountType"] = request.CrossAccountType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CrossAccountUserId))
            {
                query["CrossAccountUserId"] = request.CrossAccountUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileSystemId))
            {
                query["FileSystemId"] = request.FileSystemId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DetachNasFileSystem",
                Version = "2017-09-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DetachNasFileSystemResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * *   If the request is successful, the mount target is deleted.
          * *   After you create a backup plan for an Apsara File Storage NAS file system, HBR automatically creates a mount target for the file system. You can call this operation to delete the mount target. In the **Status** column of the mount target of the NAS file system, the following information is displayed: **This mount target is created by an Alibaba Cloud internal service and cannot be operated. Service name: HBR**.
          *
          * @param request DetachNasFileSystemRequest
          * @return DetachNasFileSystemResponse
         */
        public DetachNasFileSystemResponse DetachNasFileSystem(DetachNasFileSystemRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DetachNasFileSystemWithOptions(request, runtime);
        }

        /**
          * *   If the request is successful, the mount target is deleted.
          * *   After you create a backup plan for an Apsara File Storage NAS file system, HBR automatically creates a mount target for the file system. You can call this operation to delete the mount target. In the **Status** column of the mount target of the NAS file system, the following information is displayed: **This mount target is created by an Alibaba Cloud internal service and cannot be operated. Service name: HBR**.
          *
          * @param request DetachNasFileSystemRequest
          * @return DetachNasFileSystemResponse
         */
        public async Task<DetachNasFileSystemResponse> DetachNasFileSystemAsync(DetachNasFileSystemRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DetachNasFileSystemWithOptionsAsync(request, runtime);
        }

        /**
          * If the request is successful, the specified backup plan is disabled. If you call the DescribeBackupPlans operation to query backup plans, the Disabled parameter is set to true for the backup plan.
          *
          * @param request DisableBackupPlanRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DisableBackupPlanResponse
         */
        public DisableBackupPlanResponse DisableBackupPlanWithOptions(DisableBackupPlanRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PlanId))
            {
                query["PlanId"] = request.PlanId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceType))
            {
                query["SourceType"] = request.SourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VaultId))
            {
                query["VaultId"] = request.VaultId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DisableBackupPlan",
                Version = "2017-09-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DisableBackupPlanResponse>(CallApi(params_, req, runtime));
        }

        /**
          * If the request is successful, the specified backup plan is disabled. If you call the DescribeBackupPlans operation to query backup plans, the Disabled parameter is set to true for the backup plan.
          *
          * @param request DisableBackupPlanRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DisableBackupPlanResponse
         */
        public async Task<DisableBackupPlanResponse> DisableBackupPlanWithOptionsAsync(DisableBackupPlanRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PlanId))
            {
                query["PlanId"] = request.PlanId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceType))
            {
                query["SourceType"] = request.SourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VaultId))
            {
                query["VaultId"] = request.VaultId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DisableBackupPlan",
                Version = "2017-09-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DisableBackupPlanResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * If the request is successful, the specified backup plan is disabled. If you call the DescribeBackupPlans operation to query backup plans, the Disabled parameter is set to true for the backup plan.
          *
          * @param request DisableBackupPlanRequest
          * @return DisableBackupPlanResponse
         */
        public DisableBackupPlanResponse DisableBackupPlan(DisableBackupPlanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DisableBackupPlanWithOptions(request, runtime);
        }

        /**
          * If the request is successful, the specified backup plan is disabled. If you call the DescribeBackupPlans operation to query backup plans, the Disabled parameter is set to true for the backup plan.
          *
          * @param request DisableBackupPlanRequest
          * @return DisableBackupPlanResponse
         */
        public async Task<DisableBackupPlanResponse> DisableBackupPlanAsync(DisableBackupPlanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DisableBackupPlanWithOptionsAsync(request, runtime);
        }

        /**
          * To enable the backup plan again, call the EnableHanaBackupPlan operation.
          *
          * @param request DisableHanaBackupPlanRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DisableHanaBackupPlanResponse
         */
        public DisableHanaBackupPlanResponse DisableHanaBackupPlanWithOptions(DisableHanaBackupPlanRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PlanId))
            {
                query["PlanId"] = request.PlanId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VaultId))
            {
                query["VaultId"] = request.VaultId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DisableHanaBackupPlan",
                Version = "2017-09-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DisableHanaBackupPlanResponse>(CallApi(params_, req, runtime));
        }

        /**
          * To enable the backup plan again, call the EnableHanaBackupPlan operation.
          *
          * @param request DisableHanaBackupPlanRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DisableHanaBackupPlanResponse
         */
        public async Task<DisableHanaBackupPlanResponse> DisableHanaBackupPlanWithOptionsAsync(DisableHanaBackupPlanRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PlanId))
            {
                query["PlanId"] = request.PlanId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VaultId))
            {
                query["VaultId"] = request.VaultId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DisableHanaBackupPlan",
                Version = "2017-09-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DisableHanaBackupPlanResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * To enable the backup plan again, call the EnableHanaBackupPlan operation.
          *
          * @param request DisableHanaBackupPlanRequest
          * @return DisableHanaBackupPlanResponse
         */
        public DisableHanaBackupPlanResponse DisableHanaBackupPlan(DisableHanaBackupPlanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DisableHanaBackupPlanWithOptions(request, runtime);
        }

        /**
          * To enable the backup plan again, call the EnableHanaBackupPlan operation.
          *
          * @param request DisableHanaBackupPlanRequest
          * @return DisableHanaBackupPlanResponse
         */
        public async Task<DisableHanaBackupPlanResponse> DisableHanaBackupPlanAsync(DisableHanaBackupPlanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DisableHanaBackupPlanWithOptionsAsync(request, runtime);
        }

        /**
          * If the request is successful, the system enables the backup plan and backs up data based on the polices that are specified in the backup plan. If you call the DescribeBackupPlans operation to query backup plans, the Disabled parameter is automatically set to false for the backup plan.
          *
          * @param request EnableBackupPlanRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return EnableBackupPlanResponse
         */
        public EnableBackupPlanResponse EnableBackupPlanWithOptions(EnableBackupPlanRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PlanId))
            {
                query["PlanId"] = request.PlanId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceType))
            {
                query["SourceType"] = request.SourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VaultId))
            {
                query["VaultId"] = request.VaultId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "EnableBackupPlan",
                Version = "2017-09-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<EnableBackupPlanResponse>(CallApi(params_, req, runtime));
        }

        /**
          * If the request is successful, the system enables the backup plan and backs up data based on the polices that are specified in the backup plan. If you call the DescribeBackupPlans operation to query backup plans, the Disabled parameter is automatically set to false for the backup plan.
          *
          * @param request EnableBackupPlanRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return EnableBackupPlanResponse
         */
        public async Task<EnableBackupPlanResponse> EnableBackupPlanWithOptionsAsync(EnableBackupPlanRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PlanId))
            {
                query["PlanId"] = request.PlanId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceType))
            {
                query["SourceType"] = request.SourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VaultId))
            {
                query["VaultId"] = request.VaultId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "EnableBackupPlan",
                Version = "2017-09-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<EnableBackupPlanResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * If the request is successful, the system enables the backup plan and backs up data based on the polices that are specified in the backup plan. If you call the DescribeBackupPlans operation to query backup plans, the Disabled parameter is automatically set to false for the backup plan.
          *
          * @param request EnableBackupPlanRequest
          * @return EnableBackupPlanResponse
         */
        public EnableBackupPlanResponse EnableBackupPlan(EnableBackupPlanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return EnableBackupPlanWithOptions(request, runtime);
        }

        /**
          * If the request is successful, the system enables the backup plan and backs up data based on the polices that are specified in the backup plan. If you call the DescribeBackupPlans operation to query backup plans, the Disabled parameter is automatically set to false for the backup plan.
          *
          * @param request EnableBackupPlanRequest
          * @return EnableBackupPlanResponse
         */
        public async Task<EnableBackupPlanResponse> EnableBackupPlanAsync(EnableBackupPlanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await EnableBackupPlanWithOptionsAsync(request, runtime);
        }

        /**
          * To disable the backup plan again, call the DisableHanaBackupPlan operation.
          *
          * @param request EnableHanaBackupPlanRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return EnableHanaBackupPlanResponse
         */
        public EnableHanaBackupPlanResponse EnableHanaBackupPlanWithOptions(EnableHanaBackupPlanRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PlanId))
            {
                query["PlanId"] = request.PlanId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VaultId))
            {
                query["VaultId"] = request.VaultId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "EnableHanaBackupPlan",
                Version = "2017-09-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<EnableHanaBackupPlanResponse>(CallApi(params_, req, runtime));
        }

        /**
          * To disable the backup plan again, call the DisableHanaBackupPlan operation.
          *
          * @param request EnableHanaBackupPlanRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return EnableHanaBackupPlanResponse
         */
        public async Task<EnableHanaBackupPlanResponse> EnableHanaBackupPlanWithOptionsAsync(EnableHanaBackupPlanRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PlanId))
            {
                query["PlanId"] = request.PlanId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VaultId))
            {
                query["VaultId"] = request.VaultId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "EnableHanaBackupPlan",
                Version = "2017-09-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<EnableHanaBackupPlanResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * To disable the backup plan again, call the DisableHanaBackupPlan operation.
          *
          * @param request EnableHanaBackupPlanRequest
          * @return EnableHanaBackupPlanResponse
         */
        public EnableHanaBackupPlanResponse EnableHanaBackupPlan(EnableHanaBackupPlanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return EnableHanaBackupPlanWithOptions(request, runtime);
        }

        /**
          * To disable the backup plan again, call the DisableHanaBackupPlan operation.
          *
          * @param request EnableHanaBackupPlanRequest
          * @return EnableHanaBackupPlanResponse
         */
        public async Task<EnableHanaBackupPlanResponse> EnableHanaBackupPlanAsync(EnableHanaBackupPlanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await EnableHanaBackupPlanWithOptionsAsync(request, runtime);
        }

        public ExecuteBackupPlanResponse ExecuteBackupPlanWithOptions(ExecuteBackupPlanRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PlanId))
            {
                query["PlanId"] = request.PlanId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleId))
            {
                query["RuleId"] = request.RuleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceType))
            {
                query["SourceType"] = request.SourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VaultId))
            {
                query["VaultId"] = request.VaultId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ExecuteBackupPlan",
                Version = "2017-09-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ExecuteBackupPlanResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ExecuteBackupPlanResponse> ExecuteBackupPlanWithOptionsAsync(ExecuteBackupPlanRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PlanId))
            {
                query["PlanId"] = request.PlanId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleId))
            {
                query["RuleId"] = request.RuleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceType))
            {
                query["SourceType"] = request.SourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VaultId))
            {
                query["VaultId"] = request.VaultId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ExecuteBackupPlan",
                Version = "2017-09-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ExecuteBackupPlanResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ExecuteBackupPlanResponse ExecuteBackupPlan(ExecuteBackupPlanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ExecuteBackupPlanWithOptions(request, runtime);
        }

        public async Task<ExecuteBackupPlanResponse> ExecuteBackupPlanAsync(ExecuteBackupPlanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ExecuteBackupPlanWithOptionsAsync(request, runtime);
        }

        public ExecutePolicyV2Response ExecutePolicyV2WithOptions(ExecutePolicyV2Request request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleId))
            {
                query["RuleId"] = request.RuleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceType))
            {
                query["SourceType"] = request.SourceType;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSourceId))
            {
                body["DataSourceId"] = request.DataSourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyId))
            {
                body["PolicyId"] = request.PolicyId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ExecutePolicyV2",
                Version = "2017-09-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ExecutePolicyV2Response>(CallApi(params_, req, runtime));
        }

        public async Task<ExecutePolicyV2Response> ExecutePolicyV2WithOptionsAsync(ExecutePolicyV2Request request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleId))
            {
                query["RuleId"] = request.RuleId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceType))
            {
                query["SourceType"] = request.SourceType;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSourceId))
            {
                body["DataSourceId"] = request.DataSourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyId))
            {
                body["PolicyId"] = request.PolicyId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ExecutePolicyV2",
                Version = "2017-09-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ExecutePolicyV2Response>(await CallApiAsync(params_, req, runtime));
        }

        public ExecutePolicyV2Response ExecutePolicyV2(ExecutePolicyV2Request request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ExecutePolicyV2WithOptions(request, runtime);
        }

        public async Task<ExecutePolicyV2Response> ExecutePolicyV2Async(ExecutePolicyV2Request request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ExecutePolicyV2WithOptionsAsync(request, runtime);
        }

        public GenerateRamPolicyResponse GenerateRamPolicyWithOptions(GenerateRamPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ActionType))
            {
                query["ActionType"] = request.ActionType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RequireBasePolicy))
            {
                query["RequireBasePolicy"] = request.RequireBasePolicy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VaultId))
            {
                query["VaultId"] = request.VaultId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GenerateRamPolicy",
                Version = "2017-09-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GenerateRamPolicyResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GenerateRamPolicyResponse> GenerateRamPolicyWithOptionsAsync(GenerateRamPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ActionType))
            {
                query["ActionType"] = request.ActionType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RequireBasePolicy))
            {
                query["RequireBasePolicy"] = request.RequireBasePolicy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VaultId))
            {
                query["VaultId"] = request.VaultId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GenerateRamPolicy",
                Version = "2017-09-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GenerateRamPolicyResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GenerateRamPolicyResponse GenerateRamPolicy(GenerateRamPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GenerateRamPolicyWithOptions(request, runtime);
        }

        public async Task<GenerateRamPolicyResponse> GenerateRamPolicyAsync(GenerateRamPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GenerateRamPolicyWithOptionsAsync(request, runtime);
        }

        public GetTempFileDownloadLinkResponse GetTempFileDownloadLinkWithOptions(GetTempFileDownloadLinkRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TempFileKey))
            {
                query["TempFileKey"] = request.TempFileKey;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetTempFileDownloadLink",
                Version = "2017-09-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTempFileDownloadLinkResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetTempFileDownloadLinkResponse> GetTempFileDownloadLinkWithOptionsAsync(GetTempFileDownloadLinkRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TempFileKey))
            {
                query["TempFileKey"] = request.TempFileKey;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetTempFileDownloadLink",
                Version = "2017-09-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTempFileDownloadLinkResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetTempFileDownloadLinkResponse GetTempFileDownloadLink(GetTempFileDownloadLinkRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetTempFileDownloadLinkWithOptions(request, runtime);
        }

        public async Task<GetTempFileDownloadLinkResponse> GetTempFileDownloadLinkAsync(GetTempFileDownloadLinkRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetTempFileDownloadLinkWithOptionsAsync(request, runtime);
        }

        /**
          * *   This operation creates an asynchronous job at the backend and calls Cloud Assistant to install an HBR client on an ECS instance.
          * *   You can call the [DescribeTask](~~431265~~) operation to query the execution result of an asynchronous job.
          * *   The timeout period of an asynchronous job is 15 minutes. We recommend that you call the DescribeTask operation to run the first query 60 seconds after you call the InstallBackupClients operation to install HBR clients. Then, run the next queries at an interval of 30 seconds.
          *
          * @param tmpReq InstallBackupClientsRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return InstallBackupClientsResponse
         */
        public InstallBackupClientsResponse InstallBackupClientsWithOptions(InstallBackupClientsRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            InstallBackupClientsShrinkRequest request = new InstallBackupClientsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.InstanceIds))
            {
                request.InstanceIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.InstanceIds, "InstanceIds", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CrossAccountRoleName))
            {
                query["CrossAccountRoleName"] = request.CrossAccountRoleName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CrossAccountType))
            {
                query["CrossAccountType"] = request.CrossAccountType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CrossAccountUserId))
            {
                query["CrossAccountUserId"] = request.CrossAccountUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceIdsShrink))
            {
                query["InstanceIds"] = request.InstanceIdsShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "InstallBackupClients",
                Version = "2017-09-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<InstallBackupClientsResponse>(CallApi(params_, req, runtime));
        }

        /**
          * *   This operation creates an asynchronous job at the backend and calls Cloud Assistant to install an HBR client on an ECS instance.
          * *   You can call the [DescribeTask](~~431265~~) operation to query the execution result of an asynchronous job.
          * *   The timeout period of an asynchronous job is 15 minutes. We recommend that you call the DescribeTask operation to run the first query 60 seconds after you call the InstallBackupClients operation to install HBR clients. Then, run the next queries at an interval of 30 seconds.
          *
          * @param tmpReq InstallBackupClientsRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return InstallBackupClientsResponse
         */
        public async Task<InstallBackupClientsResponse> InstallBackupClientsWithOptionsAsync(InstallBackupClientsRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            InstallBackupClientsShrinkRequest request = new InstallBackupClientsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.InstanceIds))
            {
                request.InstanceIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.InstanceIds, "InstanceIds", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CrossAccountRoleName))
            {
                query["CrossAccountRoleName"] = request.CrossAccountRoleName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CrossAccountType))
            {
                query["CrossAccountType"] = request.CrossAccountType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CrossAccountUserId))
            {
                query["CrossAccountUserId"] = request.CrossAccountUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceIdsShrink))
            {
                query["InstanceIds"] = request.InstanceIdsShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "InstallBackupClients",
                Version = "2017-09-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<InstallBackupClientsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * *   This operation creates an asynchronous job at the backend and calls Cloud Assistant to install an HBR client on an ECS instance.
          * *   You can call the [DescribeTask](~~431265~~) operation to query the execution result of an asynchronous job.
          * *   The timeout period of an asynchronous job is 15 minutes. We recommend that you call the DescribeTask operation to run the first query 60 seconds after you call the InstallBackupClients operation to install HBR clients. Then, run the next queries at an interval of 30 seconds.
          *
          * @param request InstallBackupClientsRequest
          * @return InstallBackupClientsResponse
         */
        public InstallBackupClientsResponse InstallBackupClients(InstallBackupClientsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return InstallBackupClientsWithOptions(request, runtime);
        }

        /**
          * *   This operation creates an asynchronous job at the backend and calls Cloud Assistant to install an HBR client on an ECS instance.
          * *   You can call the [DescribeTask](~~431265~~) operation to query the execution result of an asynchronous job.
          * *   The timeout period of an asynchronous job is 15 minutes. We recommend that you call the DescribeTask operation to run the first query 60 seconds after you call the InstallBackupClients operation to install HBR clients. Then, run the next queries at an interval of 30 seconds.
          *
          * @param request InstallBackupClientsRequest
          * @return InstallBackupClientsResponse
         */
        public async Task<InstallBackupClientsResponse> InstallBackupClientsAsync(InstallBackupClientsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await InstallBackupClientsWithOptionsAsync(request, runtime);
        }

        public OpenHbrServiceResponse OpenHbrServiceWithOptions(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "OpenHbrService",
                Version = "2017-09-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<OpenHbrServiceResponse>(CallApi(params_, req, runtime));
        }

        public async Task<OpenHbrServiceResponse> OpenHbrServiceWithOptionsAsync(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "OpenHbrService",
                Version = "2017-09-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<OpenHbrServiceResponse>(await CallApiAsync(params_, req, runtime));
        }

        public OpenHbrServiceResponse OpenHbrService()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return OpenHbrServiceWithOptions(runtime);
        }

        public async Task<OpenHbrServiceResponse> OpenHbrServiceAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await OpenHbrServiceWithOptionsAsync(runtime);
        }

        public SearchHistoricalSnapshotsResponse SearchHistoricalSnapshotsWithOptions(SearchHistoricalSnapshotsRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            SearchHistoricalSnapshotsShrinkRequest request = new SearchHistoricalSnapshotsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Query))
            {
                request.QueryShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Query, "Query", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Limit))
            {
                query["Limit"] = request.Limit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Order))
            {
                query["Order"] = request.Order;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueryShrink))
            {
                query["Query"] = request.QueryShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortBy))
            {
                query["SortBy"] = request.SortBy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceType))
            {
                query["SourceType"] = request.SourceType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SearchHistoricalSnapshots",
                Version = "2017-09-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SearchHistoricalSnapshotsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<SearchHistoricalSnapshotsResponse> SearchHistoricalSnapshotsWithOptionsAsync(SearchHistoricalSnapshotsRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            SearchHistoricalSnapshotsShrinkRequest request = new SearchHistoricalSnapshotsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Query))
            {
                request.QueryShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Query, "Query", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Limit))
            {
                query["Limit"] = request.Limit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Order))
            {
                query["Order"] = request.Order;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueryShrink))
            {
                query["Query"] = request.QueryShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortBy))
            {
                query["SortBy"] = request.SortBy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceType))
            {
                query["SourceType"] = request.SourceType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SearchHistoricalSnapshots",
                Version = "2017-09-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SearchHistoricalSnapshotsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public SearchHistoricalSnapshotsResponse SearchHistoricalSnapshots(SearchHistoricalSnapshotsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SearchHistoricalSnapshotsWithOptions(request, runtime);
        }

        public async Task<SearchHistoricalSnapshotsResponse> SearchHistoricalSnapshotsAsync(SearchHistoricalSnapshotsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SearchHistoricalSnapshotsWithOptionsAsync(request, runtime);
        }

        /**
          * To stop the database again, call the StopHanaDatabaseAsync operation.
          *
          * @param request StartHanaDatabaseAsyncRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return StartHanaDatabaseAsyncResponse
         */
        public StartHanaDatabaseAsyncResponse StartHanaDatabaseAsyncWithOptions(StartHanaDatabaseAsyncRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatabaseName))
            {
                query["DatabaseName"] = request.DatabaseName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VaultId))
            {
                query["VaultId"] = request.VaultId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StartHanaDatabaseAsync",
                Version = "2017-09-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<StartHanaDatabaseAsyncResponse>(CallApi(params_, req, runtime));
        }

        /**
          * To stop the database again, call the StopHanaDatabaseAsync operation.
          *
          * @param request StartHanaDatabaseAsyncRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return StartHanaDatabaseAsyncResponse
         */
        public async Task<StartHanaDatabaseAsyncResponse> StartHanaDatabaseAsyncWithOptionsAsync(StartHanaDatabaseAsyncRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatabaseName))
            {
                query["DatabaseName"] = request.DatabaseName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VaultId))
            {
                query["VaultId"] = request.VaultId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StartHanaDatabaseAsync",
                Version = "2017-09-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<StartHanaDatabaseAsyncResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * To stop the database again, call the StopHanaDatabaseAsync operation.
          *
          * @param request StartHanaDatabaseAsyncRequest
          * @return StartHanaDatabaseAsyncResponse
         */
        public StartHanaDatabaseAsyncResponse StartHanaDatabaseAsync(StartHanaDatabaseAsyncRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StartHanaDatabaseAsyncWithOptions(request, runtime);
        }

        /**
          * To stop the database again, call the StopHanaDatabaseAsync operation.
          *
          * @param request StartHanaDatabaseAsyncRequest
          * @return StartHanaDatabaseAsyncResponse
         */
        public async Task<StartHanaDatabaseAsyncResponse> StartHanaDatabaseAsyncAsync(StartHanaDatabaseAsyncRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StartHanaDatabaseAsyncWithOptionsAsync(request, runtime);
        }

        /**
          * To start the database again, call the StartHanaDatabaseAsync operation.
          *
          * @param request StopHanaDatabaseAsyncRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return StopHanaDatabaseAsyncResponse
         */
        public StopHanaDatabaseAsyncResponse StopHanaDatabaseAsyncWithOptions(StopHanaDatabaseAsyncRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatabaseName))
            {
                query["DatabaseName"] = request.DatabaseName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VaultId))
            {
                query["VaultId"] = request.VaultId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StopHanaDatabaseAsync",
                Version = "2017-09-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<StopHanaDatabaseAsyncResponse>(CallApi(params_, req, runtime));
        }

        /**
          * To start the database again, call the StartHanaDatabaseAsync operation.
          *
          * @param request StopHanaDatabaseAsyncRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return StopHanaDatabaseAsyncResponse
         */
        public async Task<StopHanaDatabaseAsyncResponse> StopHanaDatabaseAsyncWithOptionsAsync(StopHanaDatabaseAsyncRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatabaseName))
            {
                query["DatabaseName"] = request.DatabaseName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VaultId))
            {
                query["VaultId"] = request.VaultId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StopHanaDatabaseAsync",
                Version = "2017-09-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<StopHanaDatabaseAsyncResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * To start the database again, call the StartHanaDatabaseAsync operation.
          *
          * @param request StopHanaDatabaseAsyncRequest
          * @return StopHanaDatabaseAsyncResponse
         */
        public StopHanaDatabaseAsyncResponse StopHanaDatabaseAsync(StopHanaDatabaseAsyncRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StopHanaDatabaseAsyncWithOptions(request, runtime);
        }

        /**
          * To start the database again, call the StartHanaDatabaseAsync operation.
          *
          * @param request StopHanaDatabaseAsyncRequest
          * @return StopHanaDatabaseAsyncResponse
         */
        public async Task<StopHanaDatabaseAsyncResponse> StopHanaDatabaseAsyncAsync(StopHanaDatabaseAsyncRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StopHanaDatabaseAsyncWithOptionsAsync(request, runtime);
        }

        /**
          * *   This operation creates an asynchronous job at the backend and calls Cloud Assistant to uninstall a backup client from an ECS instance.
          * *   You can call the DescribeTask operation to query the execution result of an asynchronous job.
          * *   The timeout period of an asynchronous job is 15 minutes. We recommend that you call the DescribeTask operation to run the first query 30 seconds after you call the UninstallBackupClients operation to uninstall backup clients. Then, run the next queries at an interval of 30 seconds.
          *
          * @param tmpReq UninstallBackupClientsRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return UninstallBackupClientsResponse
         */
        public UninstallBackupClientsResponse UninstallBackupClientsWithOptions(UninstallBackupClientsRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UninstallBackupClientsShrinkRequest request = new UninstallBackupClientsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ClientIds))
            {
                request.ClientIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ClientIds, "ClientIds", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.InstanceIds))
            {
                request.InstanceIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.InstanceIds, "InstanceIds", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientIdsShrink))
            {
                query["ClientIds"] = request.ClientIdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CrossAccountRoleName))
            {
                query["CrossAccountRoleName"] = request.CrossAccountRoleName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CrossAccountType))
            {
                query["CrossAccountType"] = request.CrossAccountType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CrossAccountUserId))
            {
                query["CrossAccountUserId"] = request.CrossAccountUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceIdsShrink))
            {
                query["InstanceIds"] = request.InstanceIdsShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UninstallBackupClients",
                Version = "2017-09-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UninstallBackupClientsResponse>(CallApi(params_, req, runtime));
        }

        /**
          * *   This operation creates an asynchronous job at the backend and calls Cloud Assistant to uninstall a backup client from an ECS instance.
          * *   You can call the DescribeTask operation to query the execution result of an asynchronous job.
          * *   The timeout period of an asynchronous job is 15 minutes. We recommend that you call the DescribeTask operation to run the first query 30 seconds after you call the UninstallBackupClients operation to uninstall backup clients. Then, run the next queries at an interval of 30 seconds.
          *
          * @param tmpReq UninstallBackupClientsRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return UninstallBackupClientsResponse
         */
        public async Task<UninstallBackupClientsResponse> UninstallBackupClientsWithOptionsAsync(UninstallBackupClientsRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UninstallBackupClientsShrinkRequest request = new UninstallBackupClientsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ClientIds))
            {
                request.ClientIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ClientIds, "ClientIds", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.InstanceIds))
            {
                request.InstanceIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.InstanceIds, "InstanceIds", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientIdsShrink))
            {
                query["ClientIds"] = request.ClientIdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CrossAccountRoleName))
            {
                query["CrossAccountRoleName"] = request.CrossAccountRoleName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CrossAccountType))
            {
                query["CrossAccountType"] = request.CrossAccountType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CrossAccountUserId))
            {
                query["CrossAccountUserId"] = request.CrossAccountUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceIdsShrink))
            {
                query["InstanceIds"] = request.InstanceIdsShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UninstallBackupClients",
                Version = "2017-09-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UninstallBackupClientsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * *   This operation creates an asynchronous job at the backend and calls Cloud Assistant to uninstall a backup client from an ECS instance.
          * *   You can call the DescribeTask operation to query the execution result of an asynchronous job.
          * *   The timeout period of an asynchronous job is 15 minutes. We recommend that you call the DescribeTask operation to run the first query 30 seconds after you call the UninstallBackupClients operation to uninstall backup clients. Then, run the next queries at an interval of 30 seconds.
          *
          * @param request UninstallBackupClientsRequest
          * @return UninstallBackupClientsResponse
         */
        public UninstallBackupClientsResponse UninstallBackupClients(UninstallBackupClientsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UninstallBackupClientsWithOptions(request, runtime);
        }

        /**
          * *   This operation creates an asynchronous job at the backend and calls Cloud Assistant to uninstall a backup client from an ECS instance.
          * *   You can call the DescribeTask operation to query the execution result of an asynchronous job.
          * *   The timeout period of an asynchronous job is 15 minutes. We recommend that you call the DescribeTask operation to run the first query 30 seconds after you call the UninstallBackupClients operation to uninstall backup clients. Then, run the next queries at an interval of 30 seconds.
          *
          * @param request UninstallBackupClientsRequest
          * @return UninstallBackupClientsResponse
         */
        public async Task<UninstallBackupClientsResponse> UninstallBackupClientsAsync(UninstallBackupClientsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UninstallBackupClientsWithOptionsAsync(request, runtime);
        }

        /**
          * If you call this operation, the specified HBR client is uninstalled. To reinstall the HBR client, call the CreateClients operation.
          *
          * @param request UninstallClientRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return UninstallClientResponse
         */
        public UninstallClientResponse UninstallClientWithOptions(UninstallClientRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientId))
            {
                query["ClientId"] = request.ClientId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VaultId))
            {
                query["VaultId"] = request.VaultId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UninstallClient",
                Version = "2017-09-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UninstallClientResponse>(CallApi(params_, req, runtime));
        }

        /**
          * If you call this operation, the specified HBR client is uninstalled. To reinstall the HBR client, call the CreateClients operation.
          *
          * @param request UninstallClientRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return UninstallClientResponse
         */
        public async Task<UninstallClientResponse> UninstallClientWithOptionsAsync(UninstallClientRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientId))
            {
                query["ClientId"] = request.ClientId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VaultId))
            {
                query["VaultId"] = request.VaultId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UninstallClient",
                Version = "2017-09-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UninstallClientResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * If you call this operation, the specified HBR client is uninstalled. To reinstall the HBR client, call the CreateClients operation.
          *
          * @param request UninstallClientRequest
          * @return UninstallClientResponse
         */
        public UninstallClientResponse UninstallClient(UninstallClientRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UninstallClientWithOptions(request, runtime);
        }

        /**
          * If you call this operation, the specified HBR client is uninstalled. To reinstall the HBR client, call the CreateClients operation.
          *
          * @param request UninstallClientRequest
          * @return UninstallClientResponse
         */
        public async Task<UninstallClientResponse> UninstallClientAsync(UninstallClientRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UninstallClientWithOptionsAsync(request, runtime);
        }

        public UpdateBackupPlanResponse UpdateBackupPlanWithOptions(UpdateBackupPlanRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateBackupPlanShrinkRequest request = new UpdateBackupPlanShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Detail))
            {
                request.DetailShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Detail, "Detail", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.OtsDetail))
            {
                request.OtsDetailShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.OtsDetail, "OtsDetail", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChangeListPath))
            {
                query["ChangeListPath"] = request.ChangeListPath;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DetailShrink))
            {
                query["Detail"] = request.DetailShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeepLatestSnapshots))
            {
                query["KeepLatestSnapshots"] = request.KeepLatestSnapshots;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Path))
            {
                query["Path"] = request.Path;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PlanId))
            {
                query["PlanId"] = request.PlanId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PlanName))
            {
                query["PlanName"] = request.PlanName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Prefix))
            {
                query["Prefix"] = request.Prefix;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Retention))
            {
                query["Retention"] = request.Retention;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Schedule))
            {
                query["Schedule"] = request.Schedule;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceType))
            {
                query["SourceType"] = request.SourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SpeedLimit))
            {
                query["SpeedLimit"] = request.SpeedLimit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UpdatePaths))
            {
                query["UpdatePaths"] = request.UpdatePaths;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VaultId))
            {
                query["VaultId"] = request.VaultId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Exclude))
            {
                body["Exclude"] = request.Exclude;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Include))
            {
                body["Include"] = request.Include;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Options))
            {
                body["Options"] = request.Options;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OtsDetailShrink))
            {
                body["OtsDetail"] = request.OtsDetailShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Rule))
            {
                body["Rule"] = request.Rule;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateBackupPlan",
                Version = "2017-09-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateBackupPlanResponse>(CallApi(params_, req, runtime));
        }

        public async Task<UpdateBackupPlanResponse> UpdateBackupPlanWithOptionsAsync(UpdateBackupPlanRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateBackupPlanShrinkRequest request = new UpdateBackupPlanShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Detail))
            {
                request.DetailShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Detail, "Detail", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.OtsDetail))
            {
                request.OtsDetailShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.OtsDetail, "OtsDetail", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChangeListPath))
            {
                query["ChangeListPath"] = request.ChangeListPath;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DetailShrink))
            {
                query["Detail"] = request.DetailShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeepLatestSnapshots))
            {
                query["KeepLatestSnapshots"] = request.KeepLatestSnapshots;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Path))
            {
                query["Path"] = request.Path;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PlanId))
            {
                query["PlanId"] = request.PlanId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PlanName))
            {
                query["PlanName"] = request.PlanName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Prefix))
            {
                query["Prefix"] = request.Prefix;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Retention))
            {
                query["Retention"] = request.Retention;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Schedule))
            {
                query["Schedule"] = request.Schedule;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceType))
            {
                query["SourceType"] = request.SourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SpeedLimit))
            {
                query["SpeedLimit"] = request.SpeedLimit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UpdatePaths))
            {
                query["UpdatePaths"] = request.UpdatePaths;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VaultId))
            {
                query["VaultId"] = request.VaultId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Exclude))
            {
                body["Exclude"] = request.Exclude;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Include))
            {
                body["Include"] = request.Include;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Options))
            {
                body["Options"] = request.Options;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OtsDetailShrink))
            {
                body["OtsDetail"] = request.OtsDetailShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Rule))
            {
                body["Rule"] = request.Rule;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateBackupPlan",
                Version = "2017-09-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateBackupPlanResponse>(await CallApiAsync(params_, req, runtime));
        }

        public UpdateBackupPlanResponse UpdateBackupPlan(UpdateBackupPlanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateBackupPlanWithOptions(request, runtime);
        }

        public async Task<UpdateBackupPlanResponse> UpdateBackupPlanAsync(UpdateBackupPlanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateBackupPlanWithOptionsAsync(request, runtime);
        }

        /**
          * You can call this operation to update the configurations of both the old and new HBR clients.
          *
          * @param request UpdateClientSettingsRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return UpdateClientSettingsResponse
         */
        public UpdateClientSettingsResponse UpdateClientSettingsWithOptions(UpdateClientSettingsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlertOnPartialComplete))
            {
                query["AlertOnPartialComplete"] = request.AlertOnPartialComplete;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientId))
            {
                query["ClientId"] = request.ClientId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataNetworkType))
            {
                query["DataNetworkType"] = request.DataNetworkType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataProxySetting))
            {
                query["DataProxySetting"] = request.DataProxySetting;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxCpuCore))
            {
                query["MaxCpuCore"] = request.MaxCpuCore;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxMemory))
            {
                query["MaxMemory"] = request.MaxMemory;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxWorker))
            {
                query["MaxWorker"] = request.MaxWorker;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProxyHost))
            {
                query["ProxyHost"] = request.ProxyHost;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProxyPassword))
            {
                query["ProxyPassword"] = request.ProxyPassword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProxyPort))
            {
                query["ProxyPort"] = request.ProxyPort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProxyUser))
            {
                query["ProxyUser"] = request.ProxyUser;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UseHttps))
            {
                query["UseHttps"] = request.UseHttps;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VaultId))
            {
                query["VaultId"] = request.VaultId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateClientSettings",
                Version = "2017-09-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateClientSettingsResponse>(CallApi(params_, req, runtime));
        }

        /**
          * You can call this operation to update the configurations of both the old and new HBR clients.
          *
          * @param request UpdateClientSettingsRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return UpdateClientSettingsResponse
         */
        public async Task<UpdateClientSettingsResponse> UpdateClientSettingsWithOptionsAsync(UpdateClientSettingsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlertOnPartialComplete))
            {
                query["AlertOnPartialComplete"] = request.AlertOnPartialComplete;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientId))
            {
                query["ClientId"] = request.ClientId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataNetworkType))
            {
                query["DataNetworkType"] = request.DataNetworkType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataProxySetting))
            {
                query["DataProxySetting"] = request.DataProxySetting;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxCpuCore))
            {
                query["MaxCpuCore"] = request.MaxCpuCore;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxMemory))
            {
                query["MaxMemory"] = request.MaxMemory;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxWorker))
            {
                query["MaxWorker"] = request.MaxWorker;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProxyHost))
            {
                query["ProxyHost"] = request.ProxyHost;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProxyPassword))
            {
                query["ProxyPassword"] = request.ProxyPassword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProxyPort))
            {
                query["ProxyPort"] = request.ProxyPort;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProxyUser))
            {
                query["ProxyUser"] = request.ProxyUser;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UseHttps))
            {
                query["UseHttps"] = request.UseHttps;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VaultId))
            {
                query["VaultId"] = request.VaultId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateClientSettings",
                Version = "2017-09-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateClientSettingsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * You can call this operation to update the configurations of both the old and new HBR clients.
          *
          * @param request UpdateClientSettingsRequest
          * @return UpdateClientSettingsResponse
         */
        public UpdateClientSettingsResponse UpdateClientSettings(UpdateClientSettingsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateClientSettingsWithOptions(request, runtime);
        }

        /**
          * You can call this operation to update the configurations of both the old and new HBR clients.
          *
          * @param request UpdateClientSettingsRequest
          * @return UpdateClientSettingsResponse
         */
        public async Task<UpdateClientSettingsResponse> UpdateClientSettingsAsync(UpdateClientSettingsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateClientSettingsWithOptionsAsync(request, runtime);
        }

        public UpdateContainerClusterResponse UpdateContainerClusterWithOptions(UpdateContainerClusterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NetworkType))
            {
                query["NetworkType"] = request.NetworkType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RenewToken))
            {
                query["RenewToken"] = request.RenewToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateContainerCluster",
                Version = "2017-09-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateContainerClusterResponse>(CallApi(params_, req, runtime));
        }

        public async Task<UpdateContainerClusterResponse> UpdateContainerClusterWithOptionsAsync(UpdateContainerClusterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NetworkType))
            {
                query["NetworkType"] = request.NetworkType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RenewToken))
            {
                query["RenewToken"] = request.RenewToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateContainerCluster",
                Version = "2017-09-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateContainerClusterResponse>(await CallApiAsync(params_, req, runtime));
        }

        public UpdateContainerClusterResponse UpdateContainerCluster(UpdateContainerClusterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateContainerClusterWithOptions(request, runtime);
        }

        public async Task<UpdateContainerClusterResponse> UpdateContainerClusterAsync(UpdateContainerClusterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateContainerClusterWithOptionsAsync(request, runtime);
        }

        /**
          * *   A backup plan defines the data source, backup policy, and other configurations. After you execute a backup plan, a backup job is generated to record the backup progress and the backup result. If a backup job is completed, a backup snapshot is generated. You can use a backup snapshot to create a restore job.
          * *   You can specify only one type of data source in a backup plan.
          * *   You can specify only one interval as a backup cycle in a backup plan.
          * *   Each backup plan allows you to back up data to only one backup vault.
          *
          * @param request UpdateHanaBackupPlanRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return UpdateHanaBackupPlanResponse
         */
        public UpdateHanaBackupPlanResponse UpdateHanaBackupPlanWithOptions(UpdateHanaBackupPlanRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackupPrefix))
            {
                query["BackupPrefix"] = request.BackupPrefix;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PlanId))
            {
                query["PlanId"] = request.PlanId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PlanName))
            {
                query["PlanName"] = request.PlanName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Schedule))
            {
                query["Schedule"] = request.Schedule;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VaultId))
            {
                query["VaultId"] = request.VaultId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateHanaBackupPlan",
                Version = "2017-09-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateHanaBackupPlanResponse>(CallApi(params_, req, runtime));
        }

        /**
          * *   A backup plan defines the data source, backup policy, and other configurations. After you execute a backup plan, a backup job is generated to record the backup progress and the backup result. If a backup job is completed, a backup snapshot is generated. You can use a backup snapshot to create a restore job.
          * *   You can specify only one type of data source in a backup plan.
          * *   You can specify only one interval as a backup cycle in a backup plan.
          * *   Each backup plan allows you to back up data to only one backup vault.
          *
          * @param request UpdateHanaBackupPlanRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return UpdateHanaBackupPlanResponse
         */
        public async Task<UpdateHanaBackupPlanResponse> UpdateHanaBackupPlanWithOptionsAsync(UpdateHanaBackupPlanRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BackupPrefix))
            {
                query["BackupPrefix"] = request.BackupPrefix;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PlanId))
            {
                query["PlanId"] = request.PlanId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PlanName))
            {
                query["PlanName"] = request.PlanName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Schedule))
            {
                query["Schedule"] = request.Schedule;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VaultId))
            {
                query["VaultId"] = request.VaultId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateHanaBackupPlan",
                Version = "2017-09-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateHanaBackupPlanResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * *   A backup plan defines the data source, backup policy, and other configurations. After you execute a backup plan, a backup job is generated to record the backup progress and the backup result. If a backup job is completed, a backup snapshot is generated. You can use a backup snapshot to create a restore job.
          * *   You can specify only one type of data source in a backup plan.
          * *   You can specify only one interval as a backup cycle in a backup plan.
          * *   Each backup plan allows you to back up data to only one backup vault.
          *
          * @param request UpdateHanaBackupPlanRequest
          * @return UpdateHanaBackupPlanResponse
         */
        public UpdateHanaBackupPlanResponse UpdateHanaBackupPlan(UpdateHanaBackupPlanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateHanaBackupPlanWithOptions(request, runtime);
        }

        /**
          * *   A backup plan defines the data source, backup policy, and other configurations. After you execute a backup plan, a backup job is generated to record the backup progress and the backup result. If a backup job is completed, a backup snapshot is generated. You can use a backup snapshot to create a restore job.
          * *   You can specify only one type of data source in a backup plan.
          * *   You can specify only one interval as a backup cycle in a backup plan.
          * *   Each backup plan allows you to back up data to only one backup vault.
          *
          * @param request UpdateHanaBackupPlanRequest
          * @return UpdateHanaBackupPlanResponse
         */
        public async Task<UpdateHanaBackupPlanResponse> UpdateHanaBackupPlanAsync(UpdateHanaBackupPlanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateHanaBackupPlanWithOptionsAsync(request, runtime);
        }

        /**
          * You can call the UpdateHanaRetentionSetting operation to update the backup retention period of a database.
          *
          * @param request UpdateHanaBackupSettingRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return UpdateHanaBackupSettingResponse
         */
        public UpdateHanaBackupSettingResponse UpdateHanaBackupSettingWithOptions(UpdateHanaBackupSettingRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CatalogBackupParameterFile))
            {
                query["CatalogBackupParameterFile"] = request.CatalogBackupParameterFile;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CatalogBackupUsingBackint))
            {
                query["CatalogBackupUsingBackint"] = request.CatalogBackupUsingBackint;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataBackupParameterFile))
            {
                query["DataBackupParameterFile"] = request.DataBackupParameterFile;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatabaseName))
            {
                query["DatabaseName"] = request.DatabaseName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableAutoLogBackup))
            {
                query["EnableAutoLogBackup"] = request.EnableAutoLogBackup;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogBackupParameterFile))
            {
                query["LogBackupParameterFile"] = request.LogBackupParameterFile;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogBackupTimeout))
            {
                query["LogBackupTimeout"] = request.LogBackupTimeout;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogBackupUsingBackint))
            {
                query["LogBackupUsingBackint"] = request.LogBackupUsingBackint;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VaultId))
            {
                query["VaultId"] = request.VaultId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateHanaBackupSetting",
                Version = "2017-09-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateHanaBackupSettingResponse>(CallApi(params_, req, runtime));
        }

        /**
          * You can call the UpdateHanaRetentionSetting operation to update the backup retention period of a database.
          *
          * @param request UpdateHanaBackupSettingRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return UpdateHanaBackupSettingResponse
         */
        public async Task<UpdateHanaBackupSettingResponse> UpdateHanaBackupSettingWithOptionsAsync(UpdateHanaBackupSettingRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CatalogBackupParameterFile))
            {
                query["CatalogBackupParameterFile"] = request.CatalogBackupParameterFile;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CatalogBackupUsingBackint))
            {
                query["CatalogBackupUsingBackint"] = request.CatalogBackupUsingBackint;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataBackupParameterFile))
            {
                query["DataBackupParameterFile"] = request.DataBackupParameterFile;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatabaseName))
            {
                query["DatabaseName"] = request.DatabaseName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableAutoLogBackup))
            {
                query["EnableAutoLogBackup"] = request.EnableAutoLogBackup;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogBackupParameterFile))
            {
                query["LogBackupParameterFile"] = request.LogBackupParameterFile;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogBackupTimeout))
            {
                query["LogBackupTimeout"] = request.LogBackupTimeout;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogBackupUsingBackint))
            {
                query["LogBackupUsingBackint"] = request.LogBackupUsingBackint;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VaultId))
            {
                query["VaultId"] = request.VaultId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateHanaBackupSetting",
                Version = "2017-09-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateHanaBackupSettingResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * You can call the UpdateHanaRetentionSetting operation to update the backup retention period of a database.
          *
          * @param request UpdateHanaBackupSettingRequest
          * @return UpdateHanaBackupSettingResponse
         */
        public UpdateHanaBackupSettingResponse UpdateHanaBackupSetting(UpdateHanaBackupSettingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateHanaBackupSettingWithOptions(request, runtime);
        }

        /**
          * You can call the UpdateHanaRetentionSetting operation to update the backup retention period of a database.
          *
          * @param request UpdateHanaBackupSettingRequest
          * @return UpdateHanaBackupSettingResponse
         */
        public async Task<UpdateHanaBackupSettingResponse> UpdateHanaBackupSettingAsync(UpdateHanaBackupSettingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateHanaBackupSettingWithOptionsAsync(request, runtime);
        }

        public UpdateHanaInstanceResponse UpdateHanaInstanceWithOptions(UpdateHanaInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlertSetting))
            {
                query["AlertSetting"] = request.AlertSetting;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HanaName))
            {
                query["HanaName"] = request.HanaName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Host))
            {
                query["Host"] = request.Host;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceNumber))
            {
                query["InstanceNumber"] = request.InstanceNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Password))
            {
                query["Password"] = request.Password;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UseSsl))
            {
                query["UseSsl"] = request.UseSsl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserName))
            {
                query["UserName"] = request.UserName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ValidateCertificate))
            {
                query["ValidateCertificate"] = request.ValidateCertificate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VaultId))
            {
                query["VaultId"] = request.VaultId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateHanaInstance",
                Version = "2017-09-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateHanaInstanceResponse>(CallApi(params_, req, runtime));
        }

        public async Task<UpdateHanaInstanceResponse> UpdateHanaInstanceWithOptionsAsync(UpdateHanaInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlertSetting))
            {
                query["AlertSetting"] = request.AlertSetting;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HanaName))
            {
                query["HanaName"] = request.HanaName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Host))
            {
                query["Host"] = request.Host;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceNumber))
            {
                query["InstanceNumber"] = request.InstanceNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Password))
            {
                query["Password"] = request.Password;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UseSsl))
            {
                query["UseSsl"] = request.UseSsl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserName))
            {
                query["UserName"] = request.UserName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ValidateCertificate))
            {
                query["ValidateCertificate"] = request.ValidateCertificate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VaultId))
            {
                query["VaultId"] = request.VaultId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateHanaInstance",
                Version = "2017-09-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateHanaInstanceResponse>(await CallApiAsync(params_, req, runtime));
        }

        public UpdateHanaInstanceResponse UpdateHanaInstance(UpdateHanaInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateHanaInstanceWithOptions(request, runtime);
        }

        public async Task<UpdateHanaInstanceResponse> UpdateHanaInstanceAsync(UpdateHanaInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateHanaInstanceWithOptionsAsync(request, runtime);
        }

        /**
          * *   If you want to update the backup parameters of a database, you can call the UpdateHanaBackupSetting operation.
          * *   HBR deletes the expired catalogs and data that are related to Backint and file backup. The deleted catalogs and data cannot be restored. We recommend that you set the retention period based on your business requirements.
          *
          * @param request UpdateHanaRetentionSettingRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return UpdateHanaRetentionSettingResponse
         */
        public UpdateHanaRetentionSettingResponse UpdateHanaRetentionSettingWithOptions(UpdateHanaRetentionSettingRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatabaseName))
            {
                query["DatabaseName"] = request.DatabaseName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Disabled))
            {
                query["Disabled"] = request.Disabled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RetentionDays))
            {
                query["RetentionDays"] = request.RetentionDays;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Schedule))
            {
                query["Schedule"] = request.Schedule;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VaultId))
            {
                query["VaultId"] = request.VaultId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateHanaRetentionSetting",
                Version = "2017-09-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateHanaRetentionSettingResponse>(CallApi(params_, req, runtime));
        }

        /**
          * *   If you want to update the backup parameters of a database, you can call the UpdateHanaBackupSetting operation.
          * *   HBR deletes the expired catalogs and data that are related to Backint and file backup. The deleted catalogs and data cannot be restored. We recommend that you set the retention period based on your business requirements.
          *
          * @param request UpdateHanaRetentionSettingRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return UpdateHanaRetentionSettingResponse
         */
        public async Task<UpdateHanaRetentionSettingResponse> UpdateHanaRetentionSettingWithOptionsAsync(UpdateHanaRetentionSettingRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatabaseName))
            {
                query["DatabaseName"] = request.DatabaseName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Disabled))
            {
                query["Disabled"] = request.Disabled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RetentionDays))
            {
                query["RetentionDays"] = request.RetentionDays;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Schedule))
            {
                query["Schedule"] = request.Schedule;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VaultId))
            {
                query["VaultId"] = request.VaultId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateHanaRetentionSetting",
                Version = "2017-09-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateHanaRetentionSettingResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * *   If you want to update the backup parameters of a database, you can call the UpdateHanaBackupSetting operation.
          * *   HBR deletes the expired catalogs and data that are related to Backint and file backup. The deleted catalogs and data cannot be restored. We recommend that you set the retention period based on your business requirements.
          *
          * @param request UpdateHanaRetentionSettingRequest
          * @return UpdateHanaRetentionSettingResponse
         */
        public UpdateHanaRetentionSettingResponse UpdateHanaRetentionSetting(UpdateHanaRetentionSettingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateHanaRetentionSettingWithOptions(request, runtime);
        }

        /**
          * *   If you want to update the backup parameters of a database, you can call the UpdateHanaBackupSetting operation.
          * *   HBR deletes the expired catalogs and data that are related to Backint and file backup. The deleted catalogs and data cannot be restored. We recommend that you set the retention period based on your business requirements.
          *
          * @param request UpdateHanaRetentionSettingRequest
          * @return UpdateHanaRetentionSettingResponse
         */
        public async Task<UpdateHanaRetentionSettingResponse> UpdateHanaRetentionSettingAsync(UpdateHanaRetentionSettingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateHanaRetentionSettingWithOptionsAsync(request, runtime);
        }

        public UpdatePolicyBindingResponse UpdatePolicyBindingWithOptions(UpdatePolicyBindingRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdatePolicyBindingShrinkRequest request = new UpdatePolicyBindingShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.AdvancedOptions))
            {
                request.AdvancedOptionsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.AdvancedOptions, "AdvancedOptions", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AdvancedOptionsShrink))
            {
                query["AdvancedOptions"] = request.AdvancedOptionsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Disabled))
            {
                query["Disabled"] = request.Disabled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyBindingDescription))
            {
                query["PolicyBindingDescription"] = request.PolicyBindingDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceType))
            {
                query["SourceType"] = request.SourceType;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSourceId))
            {
                body["DataSourceId"] = request.DataSourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyId))
            {
                body["PolicyId"] = request.PolicyId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdatePolicyBinding",
                Version = "2017-09-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdatePolicyBindingResponse>(CallApi(params_, req, runtime));
        }

        public async Task<UpdatePolicyBindingResponse> UpdatePolicyBindingWithOptionsAsync(UpdatePolicyBindingRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdatePolicyBindingShrinkRequest request = new UpdatePolicyBindingShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.AdvancedOptions))
            {
                request.AdvancedOptionsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.AdvancedOptions, "AdvancedOptions", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AdvancedOptionsShrink))
            {
                query["AdvancedOptions"] = request.AdvancedOptionsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Disabled))
            {
                query["Disabled"] = request.Disabled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyBindingDescription))
            {
                query["PolicyBindingDescription"] = request.PolicyBindingDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceType))
            {
                query["SourceType"] = request.SourceType;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSourceId))
            {
                body["DataSourceId"] = request.DataSourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyId))
            {
                body["PolicyId"] = request.PolicyId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdatePolicyBinding",
                Version = "2017-09-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdatePolicyBindingResponse>(await CallApiAsync(params_, req, runtime));
        }

        public UpdatePolicyBindingResponse UpdatePolicyBinding(UpdatePolicyBindingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdatePolicyBindingWithOptions(request, runtime);
        }

        public async Task<UpdatePolicyBindingResponse> UpdatePolicyBindingAsync(UpdatePolicyBindingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdatePolicyBindingWithOptionsAsync(request, runtime);
        }

        /**
          * If you modify a backup policy, the modification takes effect on all data sources that are bound to the backup policy. Proceed with caution.
          *
          * @param tmpReq UpdatePolicyV2Request
          * @param runtime runtime options for this request RuntimeOptions
          * @return UpdatePolicyV2Response
         */
        public UpdatePolicyV2Response UpdatePolicyV2WithOptions(UpdatePolicyV2Request tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdatePolicyV2ShrinkRequest request = new UpdatePolicyV2ShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Rules))
            {
                request.RulesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Rules, "Rules", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyDescription))
            {
                body["PolicyDescription"] = request.PolicyDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyId))
            {
                body["PolicyId"] = request.PolicyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyName))
            {
                body["PolicyName"] = request.PolicyName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RulesShrink))
            {
                body["Rules"] = request.RulesShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdatePolicyV2",
                Version = "2017-09-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdatePolicyV2Response>(CallApi(params_, req, runtime));
        }

        /**
          * If you modify a backup policy, the modification takes effect on all data sources that are bound to the backup policy. Proceed with caution.
          *
          * @param tmpReq UpdatePolicyV2Request
          * @param runtime runtime options for this request RuntimeOptions
          * @return UpdatePolicyV2Response
         */
        public async Task<UpdatePolicyV2Response> UpdatePolicyV2WithOptionsAsync(UpdatePolicyV2Request tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdatePolicyV2ShrinkRequest request = new UpdatePolicyV2ShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Rules))
            {
                request.RulesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Rules, "Rules", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyDescription))
            {
                body["PolicyDescription"] = request.PolicyDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyId))
            {
                body["PolicyId"] = request.PolicyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyName))
            {
                body["PolicyName"] = request.PolicyName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RulesShrink))
            {
                body["Rules"] = request.RulesShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdatePolicyV2",
                Version = "2017-09-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdatePolicyV2Response>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * If you modify a backup policy, the modification takes effect on all data sources that are bound to the backup policy. Proceed with caution.
          *
          * @param request UpdatePolicyV2Request
          * @return UpdatePolicyV2Response
         */
        public UpdatePolicyV2Response UpdatePolicyV2(UpdatePolicyV2Request request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdatePolicyV2WithOptions(request, runtime);
        }

        /**
          * If you modify a backup policy, the modification takes effect on all data sources that are bound to the backup policy. Proceed with caution.
          *
          * @param request UpdatePolicyV2Request
          * @return UpdatePolicyV2Response
         */
        public async Task<UpdatePolicyV2Response> UpdatePolicyV2Async(UpdatePolicyV2Request request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdatePolicyV2WithOptionsAsync(request, runtime);
        }

        public UpdateVaultResponse UpdateVaultWithOptions(UpdateVaultRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VaultId))
            {
                query["VaultId"] = request.VaultId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VaultName))
            {
                query["VaultName"] = request.VaultName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateVault",
                Version = "2017-09-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateVaultResponse>(CallApi(params_, req, runtime));
        }

        public async Task<UpdateVaultResponse> UpdateVaultWithOptionsAsync(UpdateVaultRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VaultId))
            {
                query["VaultId"] = request.VaultId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VaultName))
            {
                query["VaultName"] = request.VaultName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateVault",
                Version = "2017-09-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateVaultResponse>(await CallApiAsync(params_, req, runtime));
        }

        public UpdateVaultResponse UpdateVault(UpdateVaultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateVaultWithOptions(request, runtime);
        }

        public async Task<UpdateVaultResponse> UpdateVaultAsync(UpdateVaultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateVaultWithOptionsAsync(request, runtime);
        }

        /**
          * *   This operation creates an asynchronous job at the backend and calls Cloud Assistant to upgrade an HBR client that is installed on an ECS instance.
          * *   You can call the DescribeTask operation to query the execution result of an asynchronous job.
          * *   The timeout period of an asynchronous job is 15 minutes.
          *
          * @param tmpReq UpgradeBackupClientsRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return UpgradeBackupClientsResponse
         */
        public UpgradeBackupClientsResponse UpgradeBackupClientsWithOptions(UpgradeBackupClientsRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpgradeBackupClientsShrinkRequest request = new UpgradeBackupClientsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ClientIds))
            {
                request.ClientIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ClientIds, "ClientIds", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.InstanceIds))
            {
                request.InstanceIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.InstanceIds, "InstanceIds", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientIdsShrink))
            {
                query["ClientIds"] = request.ClientIdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CrossAccountRoleName))
            {
                query["CrossAccountRoleName"] = request.CrossAccountRoleName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CrossAccountType))
            {
                query["CrossAccountType"] = request.CrossAccountType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CrossAccountUserId))
            {
                query["CrossAccountUserId"] = request.CrossAccountUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceIdsShrink))
            {
                query["InstanceIds"] = request.InstanceIdsShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpgradeBackupClients",
                Version = "2017-09-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpgradeBackupClientsResponse>(CallApi(params_, req, runtime));
        }

        /**
          * *   This operation creates an asynchronous job at the backend and calls Cloud Assistant to upgrade an HBR client that is installed on an ECS instance.
          * *   You can call the DescribeTask operation to query the execution result of an asynchronous job.
          * *   The timeout period of an asynchronous job is 15 minutes.
          *
          * @param tmpReq UpgradeBackupClientsRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return UpgradeBackupClientsResponse
         */
        public async Task<UpgradeBackupClientsResponse> UpgradeBackupClientsWithOptionsAsync(UpgradeBackupClientsRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpgradeBackupClientsShrinkRequest request = new UpgradeBackupClientsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ClientIds))
            {
                request.ClientIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ClientIds, "ClientIds", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.InstanceIds))
            {
                request.InstanceIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.InstanceIds, "InstanceIds", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientIdsShrink))
            {
                query["ClientIds"] = request.ClientIdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CrossAccountRoleName))
            {
                query["CrossAccountRoleName"] = request.CrossAccountRoleName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CrossAccountType))
            {
                query["CrossAccountType"] = request.CrossAccountType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CrossAccountUserId))
            {
                query["CrossAccountUserId"] = request.CrossAccountUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceIdsShrink))
            {
                query["InstanceIds"] = request.InstanceIdsShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpgradeBackupClients",
                Version = "2017-09-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpgradeBackupClientsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * *   This operation creates an asynchronous job at the backend and calls Cloud Assistant to upgrade an HBR client that is installed on an ECS instance.
          * *   You can call the DescribeTask operation to query the execution result of an asynchronous job.
          * *   The timeout period of an asynchronous job is 15 minutes.
          *
          * @param request UpgradeBackupClientsRequest
          * @return UpgradeBackupClientsResponse
         */
        public UpgradeBackupClientsResponse UpgradeBackupClients(UpgradeBackupClientsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpgradeBackupClientsWithOptions(request, runtime);
        }

        /**
          * *   This operation creates an asynchronous job at the backend and calls Cloud Assistant to upgrade an HBR client that is installed on an ECS instance.
          * *   You can call the DescribeTask operation to query the execution result of an asynchronous job.
          * *   The timeout period of an asynchronous job is 15 minutes.
          *
          * @param request UpgradeBackupClientsRequest
          * @return UpgradeBackupClientsResponse
         */
        public async Task<UpgradeBackupClientsResponse> UpgradeBackupClientsAsync(UpgradeBackupClientsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpgradeBackupClientsWithOptionsAsync(request, runtime);
        }

        /**
          * You can call this operation to upgrade a backup client to the latest version. After the backup client is upgraded, the version of the backup client cannot be rolled back.
          *
          * @param request UpgradeClientRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return UpgradeClientResponse
         */
        public UpgradeClientResponse UpgradeClientWithOptions(UpgradeClientRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientId))
            {
                query["ClientId"] = request.ClientId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VaultId))
            {
                query["VaultId"] = request.VaultId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpgradeClient",
                Version = "2017-09-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpgradeClientResponse>(CallApi(params_, req, runtime));
        }

        /**
          * You can call this operation to upgrade a backup client to the latest version. After the backup client is upgraded, the version of the backup client cannot be rolled back.
          *
          * @param request UpgradeClientRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return UpgradeClientResponse
         */
        public async Task<UpgradeClientResponse> UpgradeClientWithOptionsAsync(UpgradeClientRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientId))
            {
                query["ClientId"] = request.ClientId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VaultId))
            {
                query["VaultId"] = request.VaultId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpgradeClient",
                Version = "2017-09-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpgradeClientResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * You can call this operation to upgrade a backup client to the latest version. After the backup client is upgraded, the version of the backup client cannot be rolled back.
          *
          * @param request UpgradeClientRequest
          * @return UpgradeClientResponse
         */
        public UpgradeClientResponse UpgradeClient(UpgradeClientRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpgradeClientWithOptions(request, runtime);
        }

        /**
          * You can call this operation to upgrade a backup client to the latest version. After the backup client is upgraded, the version of the backup client cannot be rolled back.
          *
          * @param request UpgradeClientRequest
          * @return UpgradeClientResponse
         */
        public async Task<UpgradeClientResponse> UpgradeClientAsync(UpgradeClientRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpgradeClientWithOptionsAsync(request, runtime);
        }

    }
}
