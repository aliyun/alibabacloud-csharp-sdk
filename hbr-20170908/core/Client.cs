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
            this._signatureAlgorithm = "v2";
            this._endpointRule = "regional";
            this._endpointMap = new Dictionary<string, string>
            {
                {"ap-northeast-2-pop", "hbr.aliyuncs.com"},
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Registers a Container Service for Kubernetes (ACK) cluster.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddContainerClusterRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AddContainerClusterResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Registers a Container Service for Kubernetes (ACK) cluster.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddContainerClusterRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AddContainerClusterResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Registers a Container Service for Kubernetes (ACK) cluster.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddContainerClusterRequest
        /// </param>
        /// 
        /// <returns>
        /// AddContainerClusterResponse
        /// </returns>
        public AddContainerClusterResponse AddContainerCluster(AddContainerClusterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddContainerClusterWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Registers a Container Service for Kubernetes (ACK) cluster.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddContainerClusterRequest
        /// </param>
        /// 
        /// <returns>
        /// AddContainerClusterResponse
        /// </returns>
        public async Task<AddContainerClusterResponse> AddContainerClusterAsync(AddContainerClusterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddContainerClusterWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Cancels a backup job.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CancelBackupJobRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CancelBackupJobResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Cancels a backup job.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CancelBackupJobRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CancelBackupJobResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Cancels a backup job.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CancelBackupJobRequest
        /// </param>
        /// 
        /// <returns>
        /// CancelBackupJobResponse
        /// </returns>
        public CancelBackupJobResponse CancelBackupJob(CancelBackupJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CancelBackupJobWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Cancels a backup job.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CancelBackupJobRequest
        /// </param>
        /// 
        /// <returns>
        /// CancelBackupJobResponse
        /// </returns>
        public async Task<CancelBackupJobResponse> CancelBackupJobAsync(CancelBackupJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CancelBackupJobWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Cancels a restore job.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CancelRestoreJobRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CancelRestoreJobResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Cancels a restore job.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CancelRestoreJobRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CancelRestoreJobResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Cancels a restore job.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CancelRestoreJobRequest
        /// </param>
        /// 
        /// <returns>
        /// CancelRestoreJobResponse
        /// </returns>
        public CancelRestoreJobResponse CancelRestoreJob(CancelRestoreJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CancelRestoreJobWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Cancels a restore job.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CancelRestoreJobRequest
        /// </param>
        /// 
        /// <returns>
        /// CancelRestoreJobResponse
        /// </returns>
        public async Task<CancelRestoreJobResponse> CancelRestoreJobAsync(CancelRestoreJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CancelRestoreJobWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Changes the resource group to which an instance belongs.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  In the Cloud Backup console, you can use resource groups to manage resources such as backup vaults, Cloud Backup clients, and SAP HANA instances.</para>
        /// <list type="bullet">
        /// <item><description>A resource is a cloud service entity that you create on Alibaba Cloud, such as an Elastic Compute Service (ECS) instance, a backup vault, or an SAP HANA instance.</description></item>
        /// <item><description>You can sort resources owned by your Alibaba Cloud account into various resource groups. Resource groups facilitate resource management among multiple projects or applications within your Alibaba Cloud account and simplify permission management.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ChangeResourceGroupRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ChangeResourceGroupResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Changes the resource group to which an instance belongs.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  In the Cloud Backup console, you can use resource groups to manage resources such as backup vaults, Cloud Backup clients, and SAP HANA instances.</para>
        /// <list type="bullet">
        /// <item><description>A resource is a cloud service entity that you create on Alibaba Cloud, such as an Elastic Compute Service (ECS) instance, a backup vault, or an SAP HANA instance.</description></item>
        /// <item><description>You can sort resources owned by your Alibaba Cloud account into various resource groups. Resource groups facilitate resource management among multiple projects or applications within your Alibaba Cloud account and simplify permission management.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ChangeResourceGroupRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ChangeResourceGroupResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Changes the resource group to which an instance belongs.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  In the Cloud Backup console, you can use resource groups to manage resources such as backup vaults, Cloud Backup clients, and SAP HANA instances.</para>
        /// <list type="bullet">
        /// <item><description>A resource is a cloud service entity that you create on Alibaba Cloud, such as an Elastic Compute Service (ECS) instance, a backup vault, or an SAP HANA instance.</description></item>
        /// <item><description>You can sort resources owned by your Alibaba Cloud account into various resource groups. Resource groups facilitate resource management among multiple projects or applications within your Alibaba Cloud account and simplify permission management.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ChangeResourceGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// ChangeResourceGroupResponse
        /// </returns>
        public ChangeResourceGroupResponse ChangeResourceGroup(ChangeResourceGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ChangeResourceGroupWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Changes the resource group to which an instance belongs.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  In the Cloud Backup console, you can use resource groups to manage resources such as backup vaults, Cloud Backup clients, and SAP HANA instances.</para>
        /// <list type="bullet">
        /// <item><description>A resource is a cloud service entity that you create on Alibaba Cloud, such as an Elastic Compute Service (ECS) instance, a backup vault, or an SAP HANA instance.</description></item>
        /// <item><description>You can sort resources owned by your Alibaba Cloud account into various resource groups. Resource groups facilitate resource management among multiple projects or applications within your Alibaba Cloud account and simplify permission management.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ChangeResourceGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// ChangeResourceGroupResponse
        /// </returns>
        public async Task<ChangeResourceGroupResponse> ChangeResourceGroupAsync(ChangeResourceGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ChangeResourceGroupWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Checks whether the user has permissions to access the current resource or page.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CheckRoleRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CheckRoleResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Checks whether the user has permissions to access the current resource or page.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CheckRoleRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CheckRoleResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Checks whether the user has permissions to access the current resource or page.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CheckRoleRequest
        /// </param>
        /// 
        /// <returns>
        /// CheckRoleResponse
        /// </returns>
        public CheckRoleResponse CheckRole(CheckRoleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CheckRoleWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Checks whether the user has permissions to access the current resource or page.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CheckRoleRequest
        /// </param>
        /// 
        /// <returns>
        /// CheckRoleResponse
        /// </returns>
        public async Task<CheckRoleResponse> CheckRoleAsync(CheckRoleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CheckRoleWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a backup job.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// CreateBackupJobRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateBackupJobResponse
        /// </returns>
        public CreateBackupJobResponse CreateBackupJobWithOptions(CreateBackupJobRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateBackupJobShrinkRequest request = new CreateBackupJobShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Detail))
            {
                request.DetailShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Detail, "Detail", "json");
            }
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DetailShrink))
            {
                query["Detail"] = request.DetailShrink;
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a backup job.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// CreateBackupJobRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateBackupJobResponse
        /// </returns>
        public async Task<CreateBackupJobResponse> CreateBackupJobWithOptionsAsync(CreateBackupJobRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateBackupJobShrinkRequest request = new CreateBackupJobShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Detail))
            {
                request.DetailShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Detail, "Detail", "json");
            }
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DetailShrink))
            {
                query["Detail"] = request.DetailShrink;
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a backup job.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateBackupJobRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateBackupJobResponse
        /// </returns>
        public CreateBackupJobResponse CreateBackupJob(CreateBackupJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateBackupJobWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a backup job.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateBackupJobRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateBackupJobResponse
        /// </returns>
        public async Task<CreateBackupJobResponse> CreateBackupJobAsync(CreateBackupJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateBackupJobWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Create a backup plan.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>A backup plan associates data sources with backup policies and other necessary information for backups. After the execution of a backup plan, it generates a backup task that records the progress and results of the backup. If the backup task is successful, a backup snapshot is created. You can use the backup snapshot to create a recovery task.</description></item>
        /// <item><description>A backup plan supports only one type of data source.</description></item>
        /// <item><description>A backup plan supports only a single fixed interval backup cycle strategy.</description></item>
        /// <item><description>A backup plan can back up to only one backup vault.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// CreateBackupPlanRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateBackupPlanResponse
        /// </returns>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Disabled))
            {
                query["Disabled"] = request.Disabled;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSourceId))
            {
                body["DataSourceId"] = request.DataSourceId;
            }
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Create a backup plan.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>A backup plan associates data sources with backup policies and other necessary information for backups. After the execution of a backup plan, it generates a backup task that records the progress and results of the backup. If the backup task is successful, a backup snapshot is created. You can use the backup snapshot to create a recovery task.</description></item>
        /// <item><description>A backup plan supports only one type of data source.</description></item>
        /// <item><description>A backup plan supports only a single fixed interval backup cycle strategy.</description></item>
        /// <item><description>A backup plan can back up to only one backup vault.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// CreateBackupPlanRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateBackupPlanResponse
        /// </returns>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Disabled))
            {
                query["Disabled"] = request.Disabled;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSourceId))
            {
                body["DataSourceId"] = request.DataSourceId;
            }
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Create a backup plan.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>A backup plan associates data sources with backup policies and other necessary information for backups. After the execution of a backup plan, it generates a backup task that records the progress and results of the backup. If the backup task is successful, a backup snapshot is created. You can use the backup snapshot to create a recovery task.</description></item>
        /// <item><description>A backup plan supports only one type of data source.</description></item>
        /// <item><description>A backup plan supports only a single fixed interval backup cycle strategy.</description></item>
        /// <item><description>A backup plan can back up to only one backup vault.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateBackupPlanRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateBackupPlanResponse
        /// </returns>
        public CreateBackupPlanResponse CreateBackupPlan(CreateBackupPlanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateBackupPlanWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Create a backup plan.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>A backup plan associates data sources with backup policies and other necessary information for backups. After the execution of a backup plan, it generates a backup task that records the progress and results of the backup. If the backup task is successful, a backup snapshot is created. You can use the backup snapshot to create a recovery task.</description></item>
        /// <item><description>A backup plan supports only one type of data source.</description></item>
        /// <item><description>A backup plan supports only a single fixed interval backup cycle strategy.</description></item>
        /// <item><description>A backup plan can back up to only one backup vault.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateBackupPlanRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateBackupPlanResponse
        /// </returns>
        public async Task<CreateBackupPlanResponse> CreateBackupPlanAsync(CreateBackupPlanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateBackupPlanWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Installs one or more Cloud Backup clients on specified instances.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you call this operation, make sure that you fully understand the billing methods and pricing of Cloud Backup. For more information, see <a href="https://help.aliyun.com/document_detail/89062.html">Billing methods and billable items</a>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateClientsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateClientsResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Installs one or more Cloud Backup clients on specified instances.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you call this operation, make sure that you fully understand the billing methods and pricing of Cloud Backup. For more information, see <a href="https://help.aliyun.com/document_detail/89062.html">Billing methods and billable items</a>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateClientsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateClientsResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Installs one or more Cloud Backup clients on specified instances.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you call this operation, make sure that you fully understand the billing methods and pricing of Cloud Backup. For more information, see <a href="https://help.aliyun.com/document_detail/89062.html">Billing methods and billable items</a>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateClientsRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateClientsResponse
        /// </returns>
        public CreateClientsResponse CreateClients(CreateClientsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateClientsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Installs one or more Cloud Backup clients on specified instances.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you call this operation, make sure that you fully understand the billing methods and pricing of Cloud Backup. For more information, see <a href="https://help.aliyun.com/document_detail/89062.html">Billing methods and billable items</a>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateClientsRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateClientsResponse
        /// </returns>
        public async Task<CreateClientsResponse> CreateClientsAsync(CreateClientsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateClientsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a backup plan for an SAP HANA instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  A backup plan defines the data source, backup policy, and other configurations. After you execute a backup plan, a backup job is generated to record the backup progress and the backup result. If a backup job is completed, a backup snapshot is generated. You can use a backup snapshot to create a restore job.</para>
        /// <list type="bullet">
        /// <item><description>You can specify only one type of data source in a backup plan.</description></item>
        /// <item><description>You can specify only one interval as a backup cycle in a backup plan.</description></item>
        /// <item><description>Each backup plan allows you to back up data to only one backup vault.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateHanaBackupPlanRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateHanaBackupPlanResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a backup plan for an SAP HANA instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  A backup plan defines the data source, backup policy, and other configurations. After you execute a backup plan, a backup job is generated to record the backup progress and the backup result. If a backup job is completed, a backup snapshot is generated. You can use a backup snapshot to create a restore job.</para>
        /// <list type="bullet">
        /// <item><description>You can specify only one type of data source in a backup plan.</description></item>
        /// <item><description>You can specify only one interval as a backup cycle in a backup plan.</description></item>
        /// <item><description>Each backup plan allows you to back up data to only one backup vault.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateHanaBackupPlanRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateHanaBackupPlanResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a backup plan for an SAP HANA instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  A backup plan defines the data source, backup policy, and other configurations. After you execute a backup plan, a backup job is generated to record the backup progress and the backup result. If a backup job is completed, a backup snapshot is generated. You can use a backup snapshot to create a restore job.</para>
        /// <list type="bullet">
        /// <item><description>You can specify only one type of data source in a backup plan.</description></item>
        /// <item><description>You can specify only one interval as a backup cycle in a backup plan.</description></item>
        /// <item><description>Each backup plan allows you to back up data to only one backup vault.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateHanaBackupPlanRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateHanaBackupPlanResponse
        /// </returns>
        public CreateHanaBackupPlanResponse CreateHanaBackupPlan(CreateHanaBackupPlanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateHanaBackupPlanWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a backup plan for an SAP HANA instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  A backup plan defines the data source, backup policy, and other configurations. After you execute a backup plan, a backup job is generated to record the backup progress and the backup result. If a backup job is completed, a backup snapshot is generated. You can use a backup snapshot to create a restore job.</para>
        /// <list type="bullet">
        /// <item><description>You can specify only one type of data source in a backup plan.</description></item>
        /// <item><description>You can specify only one interval as a backup cycle in a backup plan.</description></item>
        /// <item><description>Each backup plan allows you to back up data to only one backup vault.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateHanaBackupPlanRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateHanaBackupPlanResponse
        /// </returns>
        public async Task<CreateHanaBackupPlanResponse> CreateHanaBackupPlanAsync(CreateHanaBackupPlanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateHanaBackupPlanWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Registers an SAP HANA instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>To register an SAP HANA instance, you must configure the SAP HANA connection information. After the SAP HANA instance is registered, Cloud Backup installs a backup client on the node of the SAP HANA instance.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateHanaInstanceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateHanaInstanceResponse
        /// </returns>
        public CreateHanaInstanceResponse CreateHanaInstanceWithOptions(CreateHanaInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlertSetting))
            {
                query["AlertSetting"] = request.AlertSetting;
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Registers an SAP HANA instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>To register an SAP HANA instance, you must configure the SAP HANA connection information. After the SAP HANA instance is registered, Cloud Backup installs a backup client on the node of the SAP HANA instance.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateHanaInstanceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateHanaInstanceResponse
        /// </returns>
        public async Task<CreateHanaInstanceResponse> CreateHanaInstanceWithOptionsAsync(CreateHanaInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlertSetting))
            {
                query["AlertSetting"] = request.AlertSetting;
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Registers an SAP HANA instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>To register an SAP HANA instance, you must configure the SAP HANA connection information. After the SAP HANA instance is registered, Cloud Backup installs a backup client on the node of the SAP HANA instance.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateHanaInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateHanaInstanceResponse
        /// </returns>
        public CreateHanaInstanceResponse CreateHanaInstance(CreateHanaInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateHanaInstanceWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Registers an SAP HANA instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>To register an SAP HANA instance, you must configure the SAP HANA connection information. After the SAP HANA instance is registered, Cloud Backup installs a backup client on the node of the SAP HANA instance.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateHanaInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateHanaInstanceResponse
        /// </returns>
        public async Task<CreateHanaInstanceResponse> CreateHanaInstanceAsync(CreateHanaInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateHanaInstanceWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a restore job for an SAP HANA database.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>If you call this operation to restore a database, the database is restored to a specified state. Proceed with caution. For more information, see <a href="https://help.aliyun.com/document_detail/101178.html">Restore databases to an SAP HANA instance</a>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateHanaRestoreRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateHanaRestoreResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a restore job for an SAP HANA database.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>If you call this operation to restore a database, the database is restored to a specified state. Proceed with caution. For more information, see <a href="https://help.aliyun.com/document_detail/101178.html">Restore databases to an SAP HANA instance</a>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateHanaRestoreRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateHanaRestoreResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a restore job for an SAP HANA database.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>If you call this operation to restore a database, the database is restored to a specified state. Proceed with caution. For more information, see <a href="https://help.aliyun.com/document_detail/101178.html">Restore databases to an SAP HANA instance</a>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateHanaRestoreRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateHanaRestoreResponse
        /// </returns>
        public CreateHanaRestoreResponse CreateHanaRestore(CreateHanaRestoreRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateHanaRestoreWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a restore job for an SAP HANA database.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>If you call this operation to restore a database, the database is restored to a specified state. Proceed with caution. For more information, see <a href="https://help.aliyun.com/document_detail/101178.html">Restore databases to an SAP HANA instance</a>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateHanaRestoreRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateHanaRestoreResponse
        /// </returns>
        public async Task<CreateHanaRestoreResponse> CreateHanaRestoreAsync(CreateHanaRestoreRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateHanaRestoreWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Binds one or more data sources to a backup policy.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  You can bind data sources to only one policy in each request.</para>
        /// <list type="bullet">
        /// <item><description>Elastic Compute Service (ECS) instances can be bound to only one policy.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// CreatePolicyBindingsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreatePolicyBindingsResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Binds one or more data sources to a backup policy.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  You can bind data sources to only one policy in each request.</para>
        /// <list type="bullet">
        /// <item><description>Elastic Compute Service (ECS) instances can be bound to only one policy.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// CreatePolicyBindingsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreatePolicyBindingsResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Binds one or more data sources to a backup policy.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  You can bind data sources to only one policy in each request.</para>
        /// <list type="bullet">
        /// <item><description>Elastic Compute Service (ECS) instances can be bound to only one policy.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreatePolicyBindingsRequest
        /// </param>
        /// 
        /// <returns>
        /// CreatePolicyBindingsResponse
        /// </returns>
        public CreatePolicyBindingsResponse CreatePolicyBindings(CreatePolicyBindingsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreatePolicyBindingsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Binds one or more data sources to a backup policy.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  You can bind data sources to only one policy in each request.</para>
        /// <list type="bullet">
        /// <item><description>Elastic Compute Service (ECS) instances can be bound to only one policy.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreatePolicyBindingsRequest
        /// </param>
        /// 
        /// <returns>
        /// CreatePolicyBindingsResponse
        /// </returns>
        public async Task<CreatePolicyBindingsResponse> CreatePolicyBindingsAsync(CreatePolicyBindingsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreatePolicyBindingsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a backup policy.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>A backup policy records the information required for backup. After you execute a backup policy, a backup job is generated to record the backup progress and the backup result. If a backup job is completed, a backup snapshot is generated. You can use a backup snapshot to create a restore job.</para>
        /// <list type="bullet">
        /// <item><description>A backup policy supports multiple data sources. The data sources can be only Elastic Compute Service (ECS) instances.</description></item>
        /// <item><description>You can specify only one interval as a backup cycle in a backup policy.</description></item>
        /// <item><description>Each backup policy allows you to back up data to only one backup vault.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// CreatePolicyV2Request
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreatePolicyV2Response
        /// </returns>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyType))
            {
                body["PolicyType"] = request.PolicyType;
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a backup policy.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>A backup policy records the information required for backup. After you execute a backup policy, a backup job is generated to record the backup progress and the backup result. If a backup job is completed, a backup snapshot is generated. You can use a backup snapshot to create a restore job.</para>
        /// <list type="bullet">
        /// <item><description>A backup policy supports multiple data sources. The data sources can be only Elastic Compute Service (ECS) instances.</description></item>
        /// <item><description>You can specify only one interval as a backup cycle in a backup policy.</description></item>
        /// <item><description>Each backup policy allows you to back up data to only one backup vault.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// CreatePolicyV2Request
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreatePolicyV2Response
        /// </returns>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyType))
            {
                body["PolicyType"] = request.PolicyType;
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a backup policy.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>A backup policy records the information required for backup. After you execute a backup policy, a backup job is generated to record the backup progress and the backup result. If a backup job is completed, a backup snapshot is generated. You can use a backup snapshot to create a restore job.</para>
        /// <list type="bullet">
        /// <item><description>A backup policy supports multiple data sources. The data sources can be only Elastic Compute Service (ECS) instances.</description></item>
        /// <item><description>You can specify only one interval as a backup cycle in a backup policy.</description></item>
        /// <item><description>Each backup policy allows you to back up data to only one backup vault.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreatePolicyV2Request
        /// </param>
        /// 
        /// <returns>
        /// CreatePolicyV2Response
        /// </returns>
        public CreatePolicyV2Response CreatePolicyV2(CreatePolicyV2Request request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreatePolicyV2WithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a backup policy.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>A backup policy records the information required for backup. After you execute a backup policy, a backup job is generated to record the backup progress and the backup result. If a backup job is completed, a backup snapshot is generated. You can use a backup snapshot to create a restore job.</para>
        /// <list type="bullet">
        /// <item><description>A backup policy supports multiple data sources. The data sources can be only Elastic Compute Service (ECS) instances.</description></item>
        /// <item><description>You can specify only one interval as a backup cycle in a backup policy.</description></item>
        /// <item><description>Each backup policy allows you to back up data to only one backup vault.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreatePolicyV2Request
        /// </param>
        /// 
        /// <returns>
        /// CreatePolicyV2Response
        /// </returns>
        public async Task<CreatePolicyV2Response> CreatePolicyV2Async(CreatePolicyV2Request request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreatePolicyV2WithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a mirror vault.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>After a backup vault is created, the backup vault is in the INITIALIZING state, and the system automatically runs an initialization task to initialize the backup vault. After the initialization task is completed, the backup vault is in the CREATED state.Call this operation in the region where the mirror vault resides, which is specified by the VaultRegionId parameter.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateReplicationVaultRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateReplicationVaultResponse
        /// </returns>
        public CreateReplicationVaultResponse CreateReplicationVaultWithOptions(CreateReplicationVaultRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a mirror vault.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>After a backup vault is created, the backup vault is in the INITIALIZING state, and the system automatically runs an initialization task to initialize the backup vault. After the initialization task is completed, the backup vault is in the CREATED state.Call this operation in the region where the mirror vault resides, which is specified by the VaultRegionId parameter.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateReplicationVaultRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateReplicationVaultResponse
        /// </returns>
        public async Task<CreateReplicationVaultResponse> CreateReplicationVaultWithOptionsAsync(CreateReplicationVaultRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a mirror vault.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>After a backup vault is created, the backup vault is in the INITIALIZING state, and the system automatically runs an initialization task to initialize the backup vault. After the initialization task is completed, the backup vault is in the CREATED state.Call this operation in the region where the mirror vault resides, which is specified by the VaultRegionId parameter.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateReplicationVaultRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateReplicationVaultResponse
        /// </returns>
        public CreateReplicationVaultResponse CreateReplicationVault(CreateReplicationVaultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateReplicationVaultWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a mirror vault.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>After a backup vault is created, the backup vault is in the INITIALIZING state, and the system automatically runs an initialization task to initialize the backup vault. After the initialization task is completed, the backup vault is in the CREATED state.Call this operation in the region where the mirror vault resides, which is specified by the VaultRegionId parameter.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateReplicationVaultRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateReplicationVaultResponse
        /// </returns>
        public async Task<CreateReplicationVaultResponse> CreateReplicationVaultAsync(CreateReplicationVaultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateReplicationVaultWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Create a restore job.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>Create a restore job based on the selected snapshot and the restore destination.</description></item>
        /// <item><description>Currently, the data source type must match the restore destination data source type.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// CreateRestoreJobRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateRestoreJobResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Create a restore job.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>Create a restore job based on the selected snapshot and the restore destination.</description></item>
        /// <item><description>Currently, the data source type must match the restore destination data source type.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// CreateRestoreJobRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateRestoreJobResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Create a restore job.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>Create a restore job based on the selected snapshot and the restore destination.</description></item>
        /// <item><description>Currently, the data source type must match the restore destination data source type.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateRestoreJobRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateRestoreJobResponse
        /// </returns>
        public CreateRestoreJobResponse CreateRestoreJob(CreateRestoreJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateRestoreJobWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Create a restore job.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>Create a restore job based on the selected snapshot and the restore destination.</description></item>
        /// <item><description>Currently, the data source type must match the restore destination data source type.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateRestoreJobRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateRestoreJobResponse
        /// </returns>
        public async Task<CreateRestoreJobResponse> CreateRestoreJobAsync(CreateRestoreJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateRestoreJobWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Generates the parameters and signature required for a file upload URL.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <ol>
        /// <item><description>You can directly upload a file to Object Storage Service (OSS) by using a form based on the returned value of this operation.</description></item>
        /// <item><description>For more information about how to upload a file to OSS by using a form, see OSS documentation.</description></item>
        /// <item><description>The system periodically deletes files that are uploaded to OSS.</description></item>
        /// </ol>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateTempFileUploadUrlRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateTempFileUploadUrlResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Generates the parameters and signature required for a file upload URL.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <ol>
        /// <item><description>You can directly upload a file to Object Storage Service (OSS) by using a form based on the returned value of this operation.</description></item>
        /// <item><description>For more information about how to upload a file to OSS by using a form, see OSS documentation.</description></item>
        /// <item><description>The system periodically deletes files that are uploaded to OSS.</description></item>
        /// </ol>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateTempFileUploadUrlRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateTempFileUploadUrlResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Generates the parameters and signature required for a file upload URL.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <ol>
        /// <item><description>You can directly upload a file to Object Storage Service (OSS) by using a form based on the returned value of this operation.</description></item>
        /// <item><description>For more information about how to upload a file to OSS by using a form, see OSS documentation.</description></item>
        /// <item><description>The system periodically deletes files that are uploaded to OSS.</description></item>
        /// </ol>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateTempFileUploadUrlRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateTempFileUploadUrlResponse
        /// </returns>
        public CreateTempFileUploadUrlResponse CreateTempFileUploadUrl(CreateTempFileUploadUrlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateTempFileUploadUrlWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Generates the parameters and signature required for a file upload URL.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <ol>
        /// <item><description>You can directly upload a file to Object Storage Service (OSS) by using a form based on the returned value of this operation.</description></item>
        /// <item><description>For more information about how to upload a file to OSS by using a form, see OSS documentation.</description></item>
        /// <item><description>The system periodically deletes files that are uploaded to OSS.</description></item>
        /// </ol>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateTempFileUploadUrlRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateTempFileUploadUrlResponse
        /// </returns>
        public async Task<CreateTempFileUploadUrlResponse> CreateTempFileUploadUrlAsync(CreateTempFileUploadUrlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateTempFileUploadUrlWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a backup vault.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  Each Alibaba Cloud account can create up to 100 backup vaults.</para>
        /// <list type="bullet">
        /// <item><description>After a backup vault is created, the backup vault is in the INITIALIZING state, and the system automatically runs an initialization task to initialize the backup vault. After the initialization task is completed, the backup vault is in the CREATED state. A backup job can use a backup vault to store backup data only if the backup vault is in the CREATED state.
        /// **
        /// <b>Note</b> Before you call this operation, make sure that you fully understand the billing of Cloud Backup.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateVaultRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateVaultResponse
        /// </returns>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WormEnabled))
            {
                query["WormEnabled"] = request.WormEnabled;
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a backup vault.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  Each Alibaba Cloud account can create up to 100 backup vaults.</para>
        /// <list type="bullet">
        /// <item><description>After a backup vault is created, the backup vault is in the INITIALIZING state, and the system automatically runs an initialization task to initialize the backup vault. After the initialization task is completed, the backup vault is in the CREATED state. A backup job can use a backup vault to store backup data only if the backup vault is in the CREATED state.
        /// **
        /// <b>Note</b> Before you call this operation, make sure that you fully understand the billing of Cloud Backup.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateVaultRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateVaultResponse
        /// </returns>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WormEnabled))
            {
                query["WormEnabled"] = request.WormEnabled;
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a backup vault.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  Each Alibaba Cloud account can create up to 100 backup vaults.</para>
        /// <list type="bullet">
        /// <item><description>After a backup vault is created, the backup vault is in the INITIALIZING state, and the system automatically runs an initialization task to initialize the backup vault. After the initialization task is completed, the backup vault is in the CREATED state. A backup job can use a backup vault to store backup data only if the backup vault is in the CREATED state.
        /// **
        /// <b>Note</b> Before you call this operation, make sure that you fully understand the billing of Cloud Backup.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateVaultRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateVaultResponse
        /// </returns>
        public CreateVaultResponse CreateVault(CreateVaultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateVaultWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a backup vault.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  Each Alibaba Cloud account can create up to 100 backup vaults.</para>
        /// <list type="bullet">
        /// <item><description>After a backup vault is created, the backup vault is in the INITIALIZING state, and the system automatically runs an initialization task to initialize the backup vault. After the initialization task is completed, the backup vault is in the CREATED state. A backup job can use a backup vault to store backup data only if the backup vault is in the CREATED state.
        /// **
        /// <b>Note</b> Before you call this operation, make sure that you fully understand the billing of Cloud Backup.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateVaultRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateVaultResponse
        /// </returns>
        public async Task<CreateVaultResponse> CreateVaultAsync(CreateVaultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateVaultWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Removes the Elastic Compute Service (ECS) instance that is used for restoration only in ECS Backup Essential Edition.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// DeleteAirEcsInstanceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteAirEcsInstanceResponse
        /// </returns>
        public DeleteAirEcsInstanceResponse DeleteAirEcsInstanceWithOptions(DeleteAirEcsInstanceRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DeleteAirEcsInstanceShrinkRequest request = new DeleteAirEcsInstanceShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.UninstallClientSourceTypes))
            {
                request.UninstallClientSourceTypesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.UninstallClientSourceTypes, "UninstallClientSourceTypes", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EcsInstanceId))
            {
                query["EcsInstanceId"] = request.EcsInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UninstallClientSourceTypesShrink))
            {
                query["UninstallClientSourceTypes"] = request.UninstallClientSourceTypesShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteAirEcsInstance",
                Version = "2017-09-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteAirEcsInstanceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Removes the Elastic Compute Service (ECS) instance that is used for restoration only in ECS Backup Essential Edition.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// DeleteAirEcsInstanceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteAirEcsInstanceResponse
        /// </returns>
        public async Task<DeleteAirEcsInstanceResponse> DeleteAirEcsInstanceWithOptionsAsync(DeleteAirEcsInstanceRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DeleteAirEcsInstanceShrinkRequest request = new DeleteAirEcsInstanceShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.UninstallClientSourceTypes))
            {
                request.UninstallClientSourceTypesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.UninstallClientSourceTypes, "UninstallClientSourceTypes", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EcsInstanceId))
            {
                query["EcsInstanceId"] = request.EcsInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UninstallClientSourceTypesShrink))
            {
                query["UninstallClientSourceTypes"] = request.UninstallClientSourceTypesShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteAirEcsInstance",
                Version = "2017-09-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteAirEcsInstanceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Removes the Elastic Compute Service (ECS) instance that is used for restoration only in ECS Backup Essential Edition.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteAirEcsInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteAirEcsInstanceResponse
        /// </returns>
        public DeleteAirEcsInstanceResponse DeleteAirEcsInstance(DeleteAirEcsInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteAirEcsInstanceWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Removes the Elastic Compute Service (ECS) instance that is used for restoration only in ECS Backup Essential Edition.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteAirEcsInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteAirEcsInstanceResponse
        /// </returns>
        public async Task<DeleteAirEcsInstanceResponse> DeleteAirEcsInstanceAsync(DeleteAirEcsInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteAirEcsInstanceWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a Cloud Backup client.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  You cannot delete the active Cloud Backup clients that receive heartbeat packets within 1 hour. You can call the UninstallBackupClients operation to uninstall a Cloud Backup client. Then, the client becomes inactive.</para>
        /// <list type="bullet">
        /// <item><description>When you perform this operation, resources that are associated with the client are also deleted, including:<list type="bullet">
        /// <item><description>Backup plans</description></item>
        /// <item><description>Backup jobs</description></item>
        /// <item><description>Snapshots</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteBackupClientRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteBackupClientResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a Cloud Backup client.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  You cannot delete the active Cloud Backup clients that receive heartbeat packets within 1 hour. You can call the UninstallBackupClients operation to uninstall a Cloud Backup client. Then, the client becomes inactive.</para>
        /// <list type="bullet">
        /// <item><description>When you perform this operation, resources that are associated with the client are also deleted, including:<list type="bullet">
        /// <item><description>Backup plans</description></item>
        /// <item><description>Backup jobs</description></item>
        /// <item><description>Snapshots</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteBackupClientRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteBackupClientResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a Cloud Backup client.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  You cannot delete the active Cloud Backup clients that receive heartbeat packets within 1 hour. You can call the UninstallBackupClients operation to uninstall a Cloud Backup client. Then, the client becomes inactive.</para>
        /// <list type="bullet">
        /// <item><description>When you perform this operation, resources that are associated with the client are also deleted, including:<list type="bullet">
        /// <item><description>Backup plans</description></item>
        /// <item><description>Backup jobs</description></item>
        /// <item><description>Snapshots</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteBackupClientRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteBackupClientResponse
        /// </returns>
        public DeleteBackupClientResponse DeleteBackupClient(DeleteBackupClientRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteBackupClientWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a Cloud Backup client.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  You cannot delete the active Cloud Backup clients that receive heartbeat packets within 1 hour. You can call the UninstallBackupClients operation to uninstall a Cloud Backup client. Then, the client becomes inactive.</para>
        /// <list type="bullet">
        /// <item><description>When you perform this operation, resources that are associated with the client are also deleted, including:<list type="bullet">
        /// <item><description>Backup plans</description></item>
        /// <item><description>Backup jobs</description></item>
        /// <item><description>Snapshots</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteBackupClientRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteBackupClientResponse
        /// </returns>
        public async Task<DeleteBackupClientResponse> DeleteBackupClientAsync(DeleteBackupClientRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteBackupClientWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes the resources that are related to one or more HBR clients.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation deletes only the resources that are related to HBR clients. The resources include backup plans, backup jobs, and backup snapshots. The operation does not delete HBR clients.</para>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// DeleteBackupClientResourceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteBackupClientResourceResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes the resources that are related to one or more HBR clients.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation deletes only the resources that are related to HBR clients. The resources include backup plans, backup jobs, and backup snapshots. The operation does not delete HBR clients.</para>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// DeleteBackupClientResourceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteBackupClientResourceResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes the resources that are related to one or more HBR clients.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation deletes only the resources that are related to HBR clients. The resources include backup plans, backup jobs, and backup snapshots. The operation does not delete HBR clients.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteBackupClientResourceRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteBackupClientResourceResponse
        /// </returns>
        public DeleteBackupClientResourceResponse DeleteBackupClientResource(DeleteBackupClientResourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteBackupClientResourceWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes the resources that are related to one or more HBR clients.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation deletes only the resources that are related to HBR clients. The resources include backup plans, backup jobs, and backup snapshots. The operation does not delete HBR clients.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteBackupClientResourceRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteBackupClientResourceResponse
        /// </returns>
        public async Task<DeleteBackupClientResourceResponse> DeleteBackupClientResourceAsync(DeleteBackupClientResourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteBackupClientResourceWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a backup plan.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  If you delete a backup plan, the backup jobs are also deleted.</para>
        /// <list type="bullet">
        /// <item><description>If you delete a backup plan, the created snapshot files are not deleted.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteBackupPlanRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteBackupPlanResponse
        /// </returns>
        public DeleteBackupPlanResponse DeleteBackupPlanWithOptions(DeleteBackupPlanRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PlanId))
            {
                query["PlanId"] = request.PlanId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RequireNoRunningJobs))
            {
                query["RequireNoRunningJobs"] = request.RequireNoRunningJobs;
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a backup plan.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  If you delete a backup plan, the backup jobs are also deleted.</para>
        /// <list type="bullet">
        /// <item><description>If you delete a backup plan, the created snapshot files are not deleted.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteBackupPlanRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteBackupPlanResponse
        /// </returns>
        public async Task<DeleteBackupPlanResponse> DeleteBackupPlanWithOptionsAsync(DeleteBackupPlanRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PlanId))
            {
                query["PlanId"] = request.PlanId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RequireNoRunningJobs))
            {
                query["RequireNoRunningJobs"] = request.RequireNoRunningJobs;
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a backup plan.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  If you delete a backup plan, the backup jobs are also deleted.</para>
        /// <list type="bullet">
        /// <item><description>If you delete a backup plan, the created snapshot files are not deleted.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteBackupPlanRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteBackupPlanResponse
        /// </returns>
        public DeleteBackupPlanResponse DeleteBackupPlan(DeleteBackupPlanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteBackupPlanWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a backup plan.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  If you delete a backup plan, the backup jobs are also deleted.</para>
        /// <list type="bullet">
        /// <item><description>If you delete a backup plan, the created snapshot files are not deleted.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteBackupPlanRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteBackupPlanResponse
        /// </returns>
        public async Task<DeleteBackupPlanResponse> DeleteBackupPlanAsync(DeleteBackupPlanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteBackupPlanWithOptionsAsync(request, runtime);
        }

        /// <param name="request">
        /// DeleteClientRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteClientResponse
        /// </returns>
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

        /// <param name="request">
        /// DeleteClientRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteClientResponse
        /// </returns>
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

        /// <param name="request">
        /// DeleteClientRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteClientResponse
        /// </returns>
        public DeleteClientResponse DeleteClient(DeleteClientRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteClientWithOptions(request, runtime);
        }

        /// <param name="request">
        /// DeleteClientRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteClientResponse
        /// </returns>
        public async Task<DeleteClientResponse> DeleteClientAsync(DeleteClientRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteClientWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an SAP HANA backup plan.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteHanaBackupPlanRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteHanaBackupPlanResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an SAP HANA backup plan.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteHanaBackupPlanRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteHanaBackupPlanResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an SAP HANA backup plan.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteHanaBackupPlanRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteHanaBackupPlanResponse
        /// </returns>
        public DeleteHanaBackupPlanResponse DeleteHanaBackupPlan(DeleteHanaBackupPlanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteHanaBackupPlanWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an SAP HANA backup plan.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteHanaBackupPlanRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteHanaBackupPlanResponse
        /// </returns>
        public async Task<DeleteHanaBackupPlanResponse> DeleteHanaBackupPlanAsync(DeleteHanaBackupPlanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteHanaBackupPlanWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an SAP HANA instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>If you delete an SAP HANA instance, the existing backup data is also deleted and the running backup and restore jobs fail to be completed. Before you delete the SAP HANA instance, make sure that you no longer need the backup data of the instance and no backup or restore jobs are running for the instance. To delete an SAP HANA instance, you must specify the security identifier (SID) of the instance. The SID is three characters in length and starts with a letter. For more information, see <a href="https://answers.sap.com/questions/555192/how-to-find-sid-user-and-instance-number-of-hana-d.html?">How to find sid user and instance number of HANA db?</a></para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteHanaInstanceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteHanaInstanceResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an SAP HANA instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>If you delete an SAP HANA instance, the existing backup data is also deleted and the running backup and restore jobs fail to be completed. Before you delete the SAP HANA instance, make sure that you no longer need the backup data of the instance and no backup or restore jobs are running for the instance. To delete an SAP HANA instance, you must specify the security identifier (SID) of the instance. The SID is three characters in length and starts with a letter. For more information, see <a href="https://answers.sap.com/questions/555192/how-to-find-sid-user-and-instance-number-of-hana-d.html?">How to find sid user and instance number of HANA db?</a></para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteHanaInstanceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteHanaInstanceResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an SAP HANA instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>If you delete an SAP HANA instance, the existing backup data is also deleted and the running backup and restore jobs fail to be completed. Before you delete the SAP HANA instance, make sure that you no longer need the backup data of the instance and no backup or restore jobs are running for the instance. To delete an SAP HANA instance, you must specify the security identifier (SID) of the instance. The SID is three characters in length and starts with a letter. For more information, see <a href="https://answers.sap.com/questions/555192/how-to-find-sid-user-and-instance-number-of-hana-d.html?">How to find sid user and instance number of HANA db?</a></para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteHanaInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteHanaInstanceResponse
        /// </returns>
        public DeleteHanaInstanceResponse DeleteHanaInstance(DeleteHanaInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteHanaInstanceWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an SAP HANA instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>If you delete an SAP HANA instance, the existing backup data is also deleted and the running backup and restore jobs fail to be completed. Before you delete the SAP HANA instance, make sure that you no longer need the backup data of the instance and no backup or restore jobs are running for the instance. To delete an SAP HANA instance, you must specify the security identifier (SID) of the instance. The SID is three characters in length and starts with a letter. For more information, see <a href="https://answers.sap.com/questions/555192/how-to-find-sid-user-and-instance-number-of-hana-d.html?">How to find sid user and instance number of HANA db?</a></para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteHanaInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteHanaInstanceResponse
        /// </returns>
        public async Task<DeleteHanaInstanceResponse> DeleteHanaInstanceAsync(DeleteHanaInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteHanaInstanceWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Disassociates one or more data sources from a backup policy. After you disassociate the data sources from the backup policy, the backup policy no longer protects the data sources. Proceed with caution.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// DeletePolicyBindingRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeletePolicyBindingResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Disassociates one or more data sources from a backup policy. After you disassociate the data sources from the backup policy, the backup policy no longer protects the data sources. Proceed with caution.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// DeletePolicyBindingRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeletePolicyBindingResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Disassociates one or more data sources from a backup policy. After you disassociate the data sources from the backup policy, the backup policy no longer protects the data sources. Proceed with caution.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeletePolicyBindingRequest
        /// </param>
        /// 
        /// <returns>
        /// DeletePolicyBindingResponse
        /// </returns>
        public DeletePolicyBindingResponse DeletePolicyBinding(DeletePolicyBindingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeletePolicyBindingWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Disassociates one or more data sources from a backup policy. After you disassociate the data sources from the backup policy, the backup policy no longer protects the data sources. Proceed with caution.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeletePolicyBindingRequest
        /// </param>
        /// 
        /// <returns>
        /// DeletePolicyBindingResponse
        /// </returns>
        public async Task<DeletePolicyBindingResponse> DeletePolicyBindingAsync(DeletePolicyBindingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeletePolicyBindingWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a backup policy.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>If you delete a backup policy, the backup policy is disassociated with all data sources. Proceed with caution.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeletePolicyV2Request
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeletePolicyV2Response
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a backup policy.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>If you delete a backup policy, the backup policy is disassociated with all data sources. Proceed with caution.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeletePolicyV2Request
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeletePolicyV2Response
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a backup policy.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>If you delete a backup policy, the backup policy is disassociated with all data sources. Proceed with caution.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeletePolicyV2Request
        /// </param>
        /// 
        /// <returns>
        /// DeletePolicyV2Response
        /// </returns>
        public DeletePolicyV2Response DeletePolicyV2(DeletePolicyV2Request request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeletePolicyV2WithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a backup policy.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>If you delete a backup policy, the backup policy is disassociated with all data sources. Proceed with caution.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeletePolicyV2Request
        /// </param>
        /// 
        /// <returns>
        /// DeletePolicyV2Response
        /// </returns>
        public async Task<DeletePolicyV2Response> DeletePolicyV2Async(DeletePolicyV2Request request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeletePolicyV2WithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a backup snapshot.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteSnapshotRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteSnapshotResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a backup snapshot.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteSnapshotRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteSnapshotResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a backup snapshot.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteSnapshotRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteSnapshotResponse
        /// </returns>
        public DeleteSnapshotResponse DeleteSnapshot(DeleteSnapshotRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteSnapshotWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a backup snapshot.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteSnapshotRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteSnapshotResponse
        /// </returns>
        public async Task<DeleteSnapshotResponse> DeleteSnapshotAsync(DeleteSnapshotRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteSnapshotWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Cancels a protected disk.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteUdmDiskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteUdmDiskResponse
        /// </returns>
        public DeleteUdmDiskResponse DeleteUdmDiskWithOptions(DeleteUdmDiskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DiskId))
            {
                query["DiskId"] = request.DiskId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteUdmDisk",
                Version = "2017-09-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteUdmDiskResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Cancels a protected disk.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteUdmDiskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteUdmDiskResponse
        /// </returns>
        public async Task<DeleteUdmDiskResponse> DeleteUdmDiskWithOptionsAsync(DeleteUdmDiskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DiskId))
            {
                query["DiskId"] = request.DiskId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteUdmDisk",
                Version = "2017-09-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteUdmDiskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Cancels a protected disk.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteUdmDiskRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteUdmDiskResponse
        /// </returns>
        public DeleteUdmDiskResponse DeleteUdmDisk(DeleteUdmDiskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteUdmDiskWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Cancels a protected disk.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteUdmDiskRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteUdmDiskResponse
        /// </returns>
        public async Task<DeleteUdmDiskResponse> DeleteUdmDiskAsync(DeleteUdmDiskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteUdmDiskWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Stops protection for Elastic Compute Service (ECS) instance backup.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteUdmEcsInstanceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteUdmEcsInstanceResponse
        /// </returns>
        public DeleteUdmEcsInstanceResponse DeleteUdmEcsInstanceWithOptions(DeleteUdmEcsInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteUdmEcsInstance",
                Version = "2017-09-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteUdmEcsInstanceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Stops protection for Elastic Compute Service (ECS) instance backup.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteUdmEcsInstanceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteUdmEcsInstanceResponse
        /// </returns>
        public async Task<DeleteUdmEcsInstanceResponse> DeleteUdmEcsInstanceWithOptionsAsync(DeleteUdmEcsInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteUdmEcsInstance",
                Version = "2017-09-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteUdmEcsInstanceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Stops protection for Elastic Compute Service (ECS) instance backup.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteUdmEcsInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteUdmEcsInstanceResponse
        /// </returns>
        public DeleteUdmEcsInstanceResponse DeleteUdmEcsInstance(DeleteUdmEcsInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteUdmEcsInstanceWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Stops protection for Elastic Compute Service (ECS) instance backup.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteUdmEcsInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteUdmEcsInstanceResponse
        /// </returns>
        public async Task<DeleteUdmEcsInstanceResponse> DeleteUdmEcsInstanceAsync(DeleteUdmEcsInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteUdmEcsInstanceWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a backup vault.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  You cannot delete a backup vault within 2 hours after the backup vault is created or a backup vault that is in the INITIALIZING state.</para>
        /// <list type="bullet">
        /// <item><description>After you delete a backup vault, all resources that are associated with the backup vault are deleted. The resources include the Cloud Backup client of the old version, backup plans, backup jobs, snapshots, and restore jobs.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteVaultRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteVaultResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a backup vault.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  You cannot delete a backup vault within 2 hours after the backup vault is created or a backup vault that is in the INITIALIZING state.</para>
        /// <list type="bullet">
        /// <item><description>After you delete a backup vault, all resources that are associated with the backup vault are deleted. The resources include the Cloud Backup client of the old version, backup plans, backup jobs, snapshots, and restore jobs.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteVaultRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteVaultResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a backup vault.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  You cannot delete a backup vault within 2 hours after the backup vault is created or a backup vault that is in the INITIALIZING state.</para>
        /// <list type="bullet">
        /// <item><description>After you delete a backup vault, all resources that are associated with the backup vault are deleted. The resources include the Cloud Backup client of the old version, backup plans, backup jobs, snapshots, and restore jobs.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteVaultRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteVaultResponse
        /// </returns>
        public DeleteVaultResponse DeleteVault(DeleteVaultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteVaultWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a backup vault.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  You cannot delete a backup vault within 2 hours after the backup vault is created or a backup vault that is in the INITIALIZING state.</para>
        /// <list type="bullet">
        /// <item><description>After you delete a backup vault, all resources that are associated with the backup vault are deleted. The resources include the Cloud Backup client of the old version, backup plans, backup jobs, snapshots, and restore jobs.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteVaultRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteVaultResponse
        /// </returns>
        public async Task<DeleteVaultResponse> DeleteVaultAsync(DeleteVaultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteVaultWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about one or more HBR clients that meet the specified conditions.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// DescribeBackupClientsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeBackupClientsResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about one or more HBR clients that meet the specified conditions.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// DescribeBackupClientsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeBackupClientsResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about one or more HBR clients that meet the specified conditions.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeBackupClientsRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeBackupClientsResponse
        /// </returns>
        public DescribeBackupClientsResponse DescribeBackupClients(DescribeBackupClientsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeBackupClientsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about one or more HBR clients that meet the specified conditions.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeBackupClientsRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeBackupClientsResponse
        /// </returns>
        public async Task<DescribeBackupClientsResponse> DescribeBackupClientsAsync(DescribeBackupClientsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeBackupClientsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about one or more backup jobs that meet the specified conditions.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeBackupJobs2Request
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeBackupJobs2Response
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about one or more backup jobs that meet the specified conditions.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeBackupJobs2Request
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeBackupJobs2Response
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about one or more backup jobs that meet the specified conditions.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeBackupJobs2Request
        /// </param>
        /// 
        /// <returns>
        /// DescribeBackupJobs2Response
        /// </returns>
        public DescribeBackupJobs2Response DescribeBackupJobs2(DescribeBackupJobs2Request request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeBackupJobs2WithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about one or more backup jobs that meet the specified conditions.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeBackupJobs2Request
        /// </param>
        /// 
        /// <returns>
        /// DescribeBackupJobs2Response
        /// </returns>
        public async Task<DescribeBackupJobs2Response> DescribeBackupJobs2Async(DescribeBackupJobs2Request request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeBackupJobs2WithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about one or more backup plans that meet the specified conditions.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeBackupPlansRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeBackupPlansResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about one or more backup plans that meet the specified conditions.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeBackupPlansRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeBackupPlansResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about one or more backup plans that meet the specified conditions.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeBackupPlansRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeBackupPlansResponse
        /// </returns>
        public DescribeBackupPlansResponse DescribeBackupPlans(DescribeBackupPlansRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeBackupPlansWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about one or more backup plans that meet the specified conditions.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeBackupPlansRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeBackupPlansResponse
        /// </returns>
        public async Task<DescribeBackupPlansResponse> DescribeBackupPlansAsync(DescribeBackupPlansRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeBackupPlansWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries one or more Cloud Backup clients that meet the specified conditions.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation is applicable only to SAP HANA backup. For Cloud Backup clients of other data sources, call the DescribeBackupClients operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeClientsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeClientsResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries one or more Cloud Backup clients that meet the specified conditions.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation is applicable only to SAP HANA backup. For Cloud Backup clients of other data sources, call the DescribeBackupClients operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeClientsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeClientsResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries one or more Cloud Backup clients that meet the specified conditions.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation is applicable only to SAP HANA backup. For Cloud Backup clients of other data sources, call the DescribeBackupClients operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeClientsRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeClientsResponse
        /// </returns>
        public DescribeClientsResponse DescribeClients(DescribeClientsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeClientsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries one or more Cloud Backup clients that meet the specified conditions.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation is applicable only to SAP HANA backup. For Cloud Backup clients of other data sources, call the DescribeBackupClients operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeClientsRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeClientsResponse
        /// </returns>
        public async Task<DescribeClientsResponse> DescribeClientsAsync(DescribeClientsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeClientsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries one or more container clusters that meet the specified conditions.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call this operation to query only Container Service for Kubernetes (ACK) clusters.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeContainerClusterRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeContainerClusterResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries one or more container clusters that meet the specified conditions.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call this operation to query only Container Service for Kubernetes (ACK) clusters.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeContainerClusterRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeContainerClusterResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries one or more container clusters that meet the specified conditions.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call this operation to query only Container Service for Kubernetes (ACK) clusters.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeContainerClusterRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeContainerClusterResponse
        /// </returns>
        public DescribeContainerClusterResponse DescribeContainerCluster(DescribeContainerClusterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeContainerClusterWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries one or more container clusters that meet the specified conditions.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call this operation to query only Container Service for Kubernetes (ACK) clusters.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeContainerClusterRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeContainerClusterResponse
        /// </returns>
        public async Task<DescribeContainerClusterResponse> DescribeContainerClusterAsync(DescribeContainerClusterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeContainerClusterWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about the accounts used in cross-account backup.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeCrossAccountsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeCrossAccountsResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about the accounts used in cross-account backup.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeCrossAccountsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeCrossAccountsResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about the accounts used in cross-account backup.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeCrossAccountsRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeCrossAccountsResponse
        /// </returns>
        public DescribeCrossAccountsResponse DescribeCrossAccounts(DescribeCrossAccountsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeCrossAccountsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about the accounts used in cross-account backup.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeCrossAccountsRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeCrossAccountsResponse
        /// </returns>
        public async Task<DescribeCrossAccountsResponse> DescribeCrossAccountsAsync(DescribeCrossAccountsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeCrossAccountsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries one or more SAP HANA backup plans that meet the specified conditions.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeHanaBackupPlansRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeHanaBackupPlansResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries one or more SAP HANA backup plans that meet the specified conditions.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeHanaBackupPlansRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeHanaBackupPlansResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries one or more SAP HANA backup plans that meet the specified conditions.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeHanaBackupPlansRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeHanaBackupPlansResponse
        /// </returns>
        public DescribeHanaBackupPlansResponse DescribeHanaBackupPlans(DescribeHanaBackupPlansRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeHanaBackupPlansWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries one or more SAP HANA backup plans that meet the specified conditions.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeHanaBackupPlansRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeHanaBackupPlansResponse
        /// </returns>
        public async Task<DescribeHanaBackupPlansResponse> DescribeHanaBackupPlansAsync(DescribeHanaBackupPlansRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeHanaBackupPlansWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the backup parameters of an SAP HANA database.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>If you want to query the backup retention period of a database, you can call the DescribeHanaRetentionSetting operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeHanaBackupSettingRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeHanaBackupSettingResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the backup parameters of an SAP HANA database.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>If you want to query the backup retention period of a database, you can call the DescribeHanaRetentionSetting operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeHanaBackupSettingRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeHanaBackupSettingResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the backup parameters of an SAP HANA database.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>If you want to query the backup retention period of a database, you can call the DescribeHanaRetentionSetting operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeHanaBackupSettingRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeHanaBackupSettingResponse
        /// </returns>
        public DescribeHanaBackupSettingResponse DescribeHanaBackupSetting(DescribeHanaBackupSettingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeHanaBackupSettingWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the backup parameters of an SAP HANA database.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>If you want to query the backup retention period of a database, you can call the DescribeHanaRetentionSetting operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeHanaBackupSettingRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeHanaBackupSettingResponse
        /// </returns>
        public async Task<DescribeHanaBackupSettingResponse> DescribeHanaBackupSettingAsync(DescribeHanaBackupSettingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeHanaBackupSettingWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries one or more SAP HANA backups that meet the specified conditions.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>After you call the DescribeHanaBackupsAsync operation to query the SAP HANA backups that meet the specified conditions, call the DescribeTask operation to query the final result.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeHanaBackupsAsyncRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeHanaBackupsAsyncResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries one or more SAP HANA backups that meet the specified conditions.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>After you call the DescribeHanaBackupsAsync operation to query the SAP HANA backups that meet the specified conditions, call the DescribeTask operation to query the final result.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeHanaBackupsAsyncRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeHanaBackupsAsyncResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries one or more SAP HANA backups that meet the specified conditions.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>After you call the DescribeHanaBackupsAsync operation to query the SAP HANA backups that meet the specified conditions, call the DescribeTask operation to query the final result.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeHanaBackupsAsyncRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeHanaBackupsAsyncResponse
        /// </returns>
        public DescribeHanaBackupsAsyncResponse DescribeHanaBackupsAsync(DescribeHanaBackupsAsyncRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeHanaBackupsAsyncWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries one or more SAP HANA backups that meet the specified conditions.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>After you call the DescribeHanaBackupsAsync operation to query the SAP HANA backups that meet the specified conditions, call the DescribeTask operation to query the final result.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeHanaBackupsAsyncRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeHanaBackupsAsyncResponse
        /// </returns>
        public async Task<DescribeHanaBackupsAsyncResponse> DescribeHanaBackupsAsyncAsync(DescribeHanaBackupsAsyncRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeHanaBackupsAsyncWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about SAP HANA databases.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>After you register an SAP HANA instance and install a Cloud Backup client on the instance, you can call this operation to query the information about SAP HANA databases. You can call the StartHanaDatabaseAsync operation to start a database and call the StopHanaDatabaseAsync operation to stop a database.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeHanaDatabasesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeHanaDatabasesResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about SAP HANA databases.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>After you register an SAP HANA instance and install a Cloud Backup client on the instance, you can call this operation to query the information about SAP HANA databases. You can call the StartHanaDatabaseAsync operation to start a database and call the StopHanaDatabaseAsync operation to stop a database.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeHanaDatabasesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeHanaDatabasesResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about SAP HANA databases.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>After you register an SAP HANA instance and install a Cloud Backup client on the instance, you can call this operation to query the information about SAP HANA databases. You can call the StartHanaDatabaseAsync operation to start a database and call the StopHanaDatabaseAsync operation to stop a database.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeHanaDatabasesRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeHanaDatabasesResponse
        /// </returns>
        public DescribeHanaDatabasesResponse DescribeHanaDatabases(DescribeHanaDatabasesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeHanaDatabasesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about SAP HANA databases.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>After you register an SAP HANA instance and install a Cloud Backup client on the instance, you can call this operation to query the information about SAP HANA databases. You can call the StartHanaDatabaseAsync operation to start a database and call the StopHanaDatabaseAsync operation to stop a database.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeHanaDatabasesRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeHanaDatabasesResponse
        /// </returns>
        public async Task<DescribeHanaDatabasesResponse> DescribeHanaDatabasesAsync(DescribeHanaDatabasesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeHanaDatabasesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries one or more SAP HANA instances that meet the specified conditions.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeHanaInstancesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeHanaInstancesResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries one or more SAP HANA instances that meet the specified conditions.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeHanaInstancesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeHanaInstancesResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries one or more SAP HANA instances that meet the specified conditions.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeHanaInstancesRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeHanaInstancesResponse
        /// </returns>
        public DescribeHanaInstancesResponse DescribeHanaInstances(DescribeHanaInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeHanaInstancesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries one or more SAP HANA instances that meet the specified conditions.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeHanaInstancesRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeHanaInstancesResponse
        /// </returns>
        public async Task<DescribeHanaInstancesResponse> DescribeHanaInstancesAsync(DescribeHanaInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeHanaInstancesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries one or more SAP HANA restore jobs that meet the specified conditions.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeHanaRestoresRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeHanaRestoresResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries one or more SAP HANA restore jobs that meet the specified conditions.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeHanaRestoresRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeHanaRestoresResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries one or more SAP HANA restore jobs that meet the specified conditions.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeHanaRestoresRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeHanaRestoresResponse
        /// </returns>
        public DescribeHanaRestoresResponse DescribeHanaRestores(DescribeHanaRestoresRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeHanaRestoresWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries one or more SAP HANA restore jobs that meet the specified conditions.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeHanaRestoresRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeHanaRestoresResponse
        /// </returns>
        public async Task<DescribeHanaRestoresResponse> DescribeHanaRestoresAsync(DescribeHanaRestoresRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeHanaRestoresWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the backup retention period of an SAP HANA database.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  If you want to query the backup parameters of a database, you can call the DescribeHanaBackupSetting operation.</para>
        /// <list type="bullet">
        /// <item><description>Cloud Backup deletes the expired catalogs and data that are related to Backint and file backup. The deleted catalogs and data cannot be restored. We recommend that you set the retention period based on your business requirements.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeHanaRetentionSettingRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeHanaRetentionSettingResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the backup retention period of an SAP HANA database.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  If you want to query the backup parameters of a database, you can call the DescribeHanaBackupSetting operation.</para>
        /// <list type="bullet">
        /// <item><description>Cloud Backup deletes the expired catalogs and data that are related to Backint and file backup. The deleted catalogs and data cannot be restored. We recommend that you set the retention period based on your business requirements.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeHanaRetentionSettingRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeHanaRetentionSettingResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the backup retention period of an SAP HANA database.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  If you want to query the backup parameters of a database, you can call the DescribeHanaBackupSetting operation.</para>
        /// <list type="bullet">
        /// <item><description>Cloud Backup deletes the expired catalogs and data that are related to Backint and file backup. The deleted catalogs and data cannot be restored. We recommend that you set the retention period based on your business requirements.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeHanaRetentionSettingRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeHanaRetentionSettingResponse
        /// </returns>
        public DescribeHanaRetentionSettingResponse DescribeHanaRetentionSetting(DescribeHanaRetentionSettingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeHanaRetentionSettingWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the backup retention period of an SAP HANA database.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  If you want to query the backup parameters of a database, you can call the DescribeHanaBackupSetting operation.</para>
        /// <list type="bullet">
        /// <item><description>Cloud Backup deletes the expired catalogs and data that are related to Backint and file backup. The deleted catalogs and data cannot be restored. We recommend that you set the retention period based on your business requirements.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeHanaRetentionSettingRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeHanaRetentionSettingResponse
        /// </returns>
        public async Task<DescribeHanaRetentionSettingResponse> DescribeHanaRetentionSettingAsync(DescribeHanaRetentionSettingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeHanaRetentionSettingWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details about Tablestore instances that are backed up.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeOtsTableSnapshotsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeOtsTableSnapshotsResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details about Tablestore instances that are backed up.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeOtsTableSnapshotsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeOtsTableSnapshotsResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details about Tablestore instances that are backed up.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeOtsTableSnapshotsRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeOtsTableSnapshotsResponse
        /// </returns>
        public DescribeOtsTableSnapshotsResponse DescribeOtsTableSnapshots(DescribeOtsTableSnapshotsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeOtsTableSnapshotsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details about Tablestore instances that are backed up.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeOtsTableSnapshotsRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeOtsTableSnapshotsResponse
        /// </returns>
        public async Task<DescribeOtsTableSnapshotsResponse> DescribeOtsTableSnapshotsAsync(DescribeOtsTableSnapshotsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeOtsTableSnapshotsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries one or more backup policies.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribePoliciesV2Request
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribePoliciesV2Response
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries one or more backup policies.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribePoliciesV2Request
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribePoliciesV2Response
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries one or more backup policies.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribePoliciesV2Request
        /// </param>
        /// 
        /// <returns>
        /// DescribePoliciesV2Response
        /// </returns>
        public DescribePoliciesV2Response DescribePoliciesV2(DescribePoliciesV2Request request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribePoliciesV2WithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries one or more backup policies.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribePoliciesV2Request
        /// </param>
        /// 
        /// <returns>
        /// DescribePoliciesV2Response
        /// </returns>
        public async Task<DescribePoliciesV2Response> DescribePoliciesV2Async(DescribePoliciesV2Request request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribePoliciesV2WithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Query one or more data sources bound to a policy, or query one or more policies bound to a data source.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// DescribePolicyBindingsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribePolicyBindingsResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Query one or more data sources bound to a policy, or query one or more policies bound to a data source.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// DescribePolicyBindingsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribePolicyBindingsResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Query one or more data sources bound to a policy, or query one or more policies bound to a data source.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribePolicyBindingsRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribePolicyBindingsResponse
        /// </returns>
        public DescribePolicyBindingsResponse DescribePolicyBindings(DescribePolicyBindingsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribePolicyBindingsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Query one or more data sources bound to a policy, or query one or more policies bound to a data source.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribePolicyBindingsRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribePolicyBindingsResponse
        /// </returns>
        public async Task<DescribePolicyBindingsResponse> DescribePolicyBindingsAsync(DescribePolicyBindingsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribePolicyBindingsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the tables of a restorable Tablestore instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeRecoverableOtsInstancesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeRecoverableOtsInstancesResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the tables of a restorable Tablestore instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeRecoverableOtsInstancesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeRecoverableOtsInstancesResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the tables of a restorable Tablestore instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeRecoverableOtsInstancesRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeRecoverableOtsInstancesResponse
        /// </returns>
        public DescribeRecoverableOtsInstancesResponse DescribeRecoverableOtsInstances(DescribeRecoverableOtsInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeRecoverableOtsInstancesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the tables of a restorable Tablestore instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeRecoverableOtsInstancesRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeRecoverableOtsInstancesResponse
        /// </returns>
        public async Task<DescribeRecoverableOtsInstancesResponse> DescribeRecoverableOtsInstancesAsync(DescribeRecoverableOtsInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeRecoverableOtsInstancesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries available regions.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeRegionsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeRegionsResponse
        /// </returns>
        public DescribeRegionsResponse DescribeRegionsWithOptions(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries available regions.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeRegionsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeRegionsResponse
        /// </returns>
        public async Task<DescribeRegionsResponse> DescribeRegionsWithOptionsAsync(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries available regions.</para>
        /// </summary>
        /// 
        /// <returns>
        /// DescribeRegionsResponse
        /// </returns>
        public DescribeRegionsResponse DescribeRegions()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeRegionsWithOptions(runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries available regions.</para>
        /// </summary>
        /// 
        /// <returns>
        /// DescribeRegionsResponse
        /// </returns>
        public async Task<DescribeRegionsResponse> DescribeRegionsAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeRegionsWithOptionsAsync(runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries one or more restore jobs that meet the specified conditions.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeRestoreJobs2Request
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeRestoreJobs2Response
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries one or more restore jobs that meet the specified conditions.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeRestoreJobs2Request
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeRestoreJobs2Response
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries one or more restore jobs that meet the specified conditions.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeRestoreJobs2Request
        /// </param>
        /// 
        /// <returns>
        /// DescribeRestoreJobs2Response
        /// </returns>
        public DescribeRestoreJobs2Response DescribeRestoreJobs2(DescribeRestoreJobs2Request request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeRestoreJobs2WithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries one or more restore jobs that meet the specified conditions.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeRestoreJobs2Request
        /// </param>
        /// 
        /// <returns>
        /// DescribeRestoreJobs2Response
        /// </returns>
        public async Task<DescribeRestoreJobs2Response> DescribeRestoreJobs2Async(DescribeRestoreJobs2Request request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeRestoreJobs2WithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries an asynchronous job.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeTaskResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries an asynchronous job.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeTaskResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries an asynchronous job.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeTaskResponse
        /// </returns>
        public DescribeTaskResponse DescribeTask(DescribeTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeTaskWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries an asynchronous job.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeTaskResponse
        /// </returns>
        public async Task<DescribeTaskResponse> DescribeTaskAsync(DescribeTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeTaskWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the backup snapshots of an Elastic Compute Service (ECS) instance.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// DescribeUdmSnapshotsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeUdmSnapshotsResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the backup snapshots of an Elastic Compute Service (ECS) instance.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// DescribeUdmSnapshotsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeUdmSnapshotsResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the backup snapshots of an Elastic Compute Service (ECS) instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeUdmSnapshotsRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeUdmSnapshotsResponse
        /// </returns>
        public DescribeUdmSnapshotsResponse DescribeUdmSnapshots(DescribeUdmSnapshotsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeUdmSnapshotsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the backup snapshots of an Elastic Compute Service (ECS) instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeUdmSnapshotsRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeUdmSnapshotsResponse
        /// </returns>
        public async Task<DescribeUdmSnapshotsResponse> DescribeUdmSnapshotsAsync(DescribeUdmSnapshotsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeUdmSnapshotsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the regions that support cross-region replication.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeVaultReplicationRegionsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeVaultReplicationRegionsResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the regions that support cross-region replication.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeVaultReplicationRegionsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeVaultReplicationRegionsResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the regions that support cross-region replication.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeVaultReplicationRegionsRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeVaultReplicationRegionsResponse
        /// </returns>
        public DescribeVaultReplicationRegionsResponse DescribeVaultReplicationRegions(DescribeVaultReplicationRegionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeVaultReplicationRegionsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the regions that support cross-region replication.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeVaultReplicationRegionsRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeVaultReplicationRegionsResponse
        /// </returns>
        public async Task<DescribeVaultReplicationRegionsResponse> DescribeVaultReplicationRegionsAsync(DescribeVaultReplicationRegionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeVaultReplicationRegionsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about one or more backup vaults that meet the specified conditions.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeVaultsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeVaultsResponse
        /// </returns>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VaultName))
            {
                query["VaultName"] = request.VaultName;
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about one or more backup vaults that meet the specified conditions.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeVaultsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeVaultsResponse
        /// </returns>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VaultName))
            {
                query["VaultName"] = request.VaultName;
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about one or more backup vaults that meet the specified conditions.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeVaultsRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeVaultsResponse
        /// </returns>
        public DescribeVaultsResponse DescribeVaults(DescribeVaultsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeVaultsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about one or more backup vaults that meet the specified conditions.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeVaultsRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeVaultsResponse
        /// </returns>
        public async Task<DescribeVaultsResponse> DescribeVaultsAsync(DescribeVaultsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeVaultsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an internal mount target created by Cloud Backup.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  If the request is successful, the mount target is deleted.</para>
        /// <list type="bullet">
        /// <item><description>After you create a backup plan for an Apsara File Storage NAS file system, HBR automatically creates a mount target for the file system. You can call this operation to delete the mount target. In the <b>Status</b> column of the mount target of the NAS file system, the following information is displayed: <b>This mount target is created by an Alibaba Cloud internal service and cannot be operated. Service name: HBR</b>.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DetachNasFileSystemRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DetachNasFileSystemResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an internal mount target created by Cloud Backup.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  If the request is successful, the mount target is deleted.</para>
        /// <list type="bullet">
        /// <item><description>After you create a backup plan for an Apsara File Storage NAS file system, HBR automatically creates a mount target for the file system. You can call this operation to delete the mount target. In the <b>Status</b> column of the mount target of the NAS file system, the following information is displayed: <b>This mount target is created by an Alibaba Cloud internal service and cannot be operated. Service name: HBR</b>.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DetachNasFileSystemRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DetachNasFileSystemResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an internal mount target created by Cloud Backup.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  If the request is successful, the mount target is deleted.</para>
        /// <list type="bullet">
        /// <item><description>After you create a backup plan for an Apsara File Storage NAS file system, HBR automatically creates a mount target for the file system. You can call this operation to delete the mount target. In the <b>Status</b> column of the mount target of the NAS file system, the following information is displayed: <b>This mount target is created by an Alibaba Cloud internal service and cannot be operated. Service name: HBR</b>.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DetachNasFileSystemRequest
        /// </param>
        /// 
        /// <returns>
        /// DetachNasFileSystemResponse
        /// </returns>
        public DetachNasFileSystemResponse DetachNasFileSystem(DetachNasFileSystemRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DetachNasFileSystemWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an internal mount target created by Cloud Backup.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  If the request is successful, the mount target is deleted.</para>
        /// <list type="bullet">
        /// <item><description>After you create a backup plan for an Apsara File Storage NAS file system, HBR automatically creates a mount target for the file system. You can call this operation to delete the mount target. In the <b>Status</b> column of the mount target of the NAS file system, the following information is displayed: <b>This mount target is created by an Alibaba Cloud internal service and cannot be operated. Service name: HBR</b>.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DetachNasFileSystemRequest
        /// </param>
        /// 
        /// <returns>
        /// DetachNasFileSystemResponse
        /// </returns>
        public async Task<DetachNasFileSystemResponse> DetachNasFileSystemAsync(DetachNasFileSystemRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DetachNasFileSystemWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Disables a backup plan.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>After you call this operation, the backup plan is suspended. In the DescribeBackupPlans operation, the Disabled parameter is set to true.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DisableBackupPlanRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DisableBackupPlanResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Disables a backup plan.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>After you call this operation, the backup plan is suspended. In the DescribeBackupPlans operation, the Disabled parameter is set to true.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DisableBackupPlanRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DisableBackupPlanResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Disables a backup plan.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>After you call this operation, the backup plan is suspended. In the DescribeBackupPlans operation, the Disabled parameter is set to true.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DisableBackupPlanRequest
        /// </param>
        /// 
        /// <returns>
        /// DisableBackupPlanResponse
        /// </returns>
        public DisableBackupPlanResponse DisableBackupPlan(DisableBackupPlanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DisableBackupPlanWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Disables a backup plan.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>After you call this operation, the backup plan is suspended. In the DescribeBackupPlans operation, the Disabled parameter is set to true.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DisableBackupPlanRequest
        /// </param>
        /// 
        /// <returns>
        /// DisableBackupPlanResponse
        /// </returns>
        public async Task<DisableBackupPlanResponse> DisableBackupPlanAsync(DisableBackupPlanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DisableBackupPlanWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Disables an SAP HANA backup plan.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>To enable the backup plan again, call the EnableHanaBackupPlan operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DisableHanaBackupPlanRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DisableHanaBackupPlanResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Disables an SAP HANA backup plan.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>To enable the backup plan again, call the EnableHanaBackupPlan operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DisableHanaBackupPlanRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DisableHanaBackupPlanResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Disables an SAP HANA backup plan.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>To enable the backup plan again, call the EnableHanaBackupPlan operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DisableHanaBackupPlanRequest
        /// </param>
        /// 
        /// <returns>
        /// DisableHanaBackupPlanResponse
        /// </returns>
        public DisableHanaBackupPlanResponse DisableHanaBackupPlan(DisableHanaBackupPlanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DisableHanaBackupPlanWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Disables an SAP HANA backup plan.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>To enable the backup plan again, call the EnableHanaBackupPlan operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DisableHanaBackupPlanRequest
        /// </param>
        /// 
        /// <returns>
        /// DisableHanaBackupPlanResponse
        /// </returns>
        public async Task<DisableHanaBackupPlanResponse> DisableHanaBackupPlanAsync(DisableHanaBackupPlanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DisableHanaBackupPlanWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Enables a backup plan.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>After you call this operation, the backup plan is restarted (Disabled is set to false in the DescribeBackupPlans operation). Cloud Backup continues to perform backups based on the policy specified in the backup plan.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// EnableBackupPlanRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// EnableBackupPlanResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Enables a backup plan.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>After you call this operation, the backup plan is restarted (Disabled is set to false in the DescribeBackupPlans operation). Cloud Backup continues to perform backups based on the policy specified in the backup plan.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// EnableBackupPlanRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// EnableBackupPlanResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Enables a backup plan.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>After you call this operation, the backup plan is restarted (Disabled is set to false in the DescribeBackupPlans operation). Cloud Backup continues to perform backups based on the policy specified in the backup plan.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// EnableBackupPlanRequest
        /// </param>
        /// 
        /// <returns>
        /// EnableBackupPlanResponse
        /// </returns>
        public EnableBackupPlanResponse EnableBackupPlan(EnableBackupPlanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return EnableBackupPlanWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Enables a backup plan.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>After you call this operation, the backup plan is restarted (Disabled is set to false in the DescribeBackupPlans operation). Cloud Backup continues to perform backups based on the policy specified in the backup plan.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// EnableBackupPlanRequest
        /// </param>
        /// 
        /// <returns>
        /// EnableBackupPlanResponse
        /// </returns>
        public async Task<EnableBackupPlanResponse> EnableBackupPlanAsync(EnableBackupPlanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await EnableBackupPlanWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Enables an SAP HANA backup plan.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>To disable the backup plan again, call the DisableHanaBackupPlan operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// EnableHanaBackupPlanRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// EnableHanaBackupPlanResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Enables an SAP HANA backup plan.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>To disable the backup plan again, call the DisableHanaBackupPlan operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// EnableHanaBackupPlanRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// EnableHanaBackupPlanResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Enables an SAP HANA backup plan.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>To disable the backup plan again, call the DisableHanaBackupPlan operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// EnableHanaBackupPlanRequest
        /// </param>
        /// 
        /// <returns>
        /// EnableHanaBackupPlanResponse
        /// </returns>
        public EnableHanaBackupPlanResponse EnableHanaBackupPlan(EnableHanaBackupPlanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return EnableHanaBackupPlanWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Enables an SAP HANA backup plan.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>To disable the backup plan again, call the DisableHanaBackupPlan operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// EnableHanaBackupPlanRequest
        /// </param>
        /// 
        /// <returns>
        /// EnableHanaBackupPlanResponse
        /// </returns>
        public async Task<EnableHanaBackupPlanResponse> EnableHanaBackupPlanAsync(EnableHanaBackupPlanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await EnableHanaBackupPlanWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Executes a backup plan.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ExecuteBackupPlanRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ExecuteBackupPlanResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Executes a backup plan.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ExecuteBackupPlanRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ExecuteBackupPlanResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Executes a backup plan.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ExecuteBackupPlanRequest
        /// </param>
        /// 
        /// <returns>
        /// ExecuteBackupPlanResponse
        /// </returns>
        public ExecuteBackupPlanResponse ExecuteBackupPlan(ExecuteBackupPlanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ExecuteBackupPlanWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Executes a backup plan.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ExecuteBackupPlanRequest
        /// </param>
        /// 
        /// <returns>
        /// ExecuteBackupPlanResponse
        /// </returns>
        public async Task<ExecuteBackupPlanResponse> ExecuteBackupPlanAsync(ExecuteBackupPlanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ExecuteBackupPlanWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Execute a policy for one or all bound data sources.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ExecutePolicyV2Request
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ExecutePolicyV2Response
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Execute a policy for one or all bound data sources.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ExecutePolicyV2Request
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ExecutePolicyV2Response
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Execute a policy for one or all bound data sources.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ExecutePolicyV2Request
        /// </param>
        /// 
        /// <returns>
        /// ExecutePolicyV2Response
        /// </returns>
        public ExecutePolicyV2Response ExecutePolicyV2(ExecutePolicyV2Request request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ExecutePolicyV2WithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Execute a policy for one or all bound data sources.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ExecutePolicyV2Request
        /// </param>
        /// 
        /// <returns>
        /// ExecutePolicyV2Response
        /// </returns>
        public async Task<ExecutePolicyV2Response> ExecutePolicyV2Async(ExecutePolicyV2Request request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ExecutePolicyV2WithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Generates a Resource Access Management (RAM) policy.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GenerateRamPolicyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GenerateRamPolicyResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Generates a Resource Access Management (RAM) policy.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GenerateRamPolicyRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GenerateRamPolicyResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Generates a Resource Access Management (RAM) policy.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GenerateRamPolicyRequest
        /// </param>
        /// 
        /// <returns>
        /// GenerateRamPolicyResponse
        /// </returns>
        public GenerateRamPolicyResponse GenerateRamPolicy(GenerateRamPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GenerateRamPolicyWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Generates a Resource Access Management (RAM) policy.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GenerateRamPolicyRequest
        /// </param>
        /// 
        /// <returns>
        /// GenerateRamPolicyResponse
        /// </returns>
        public async Task<GenerateRamPolicyResponse> GenerateRamPolicyAsync(GenerateRamPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GenerateRamPolicyWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains download links of files such as job reports.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetTempFileDownloadLinkRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetTempFileDownloadLinkResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains download links of files such as job reports.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetTempFileDownloadLinkRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetTempFileDownloadLinkResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains download links of files such as job reports.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetTempFileDownloadLinkRequest
        /// </param>
        /// 
        /// <returns>
        /// GetTempFileDownloadLinkResponse
        /// </returns>
        public GetTempFileDownloadLinkResponse GetTempFileDownloadLink(GetTempFileDownloadLinkRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetTempFileDownloadLinkWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains download links of files such as job reports.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetTempFileDownloadLinkRequest
        /// </param>
        /// 
        /// <returns>
        /// GetTempFileDownloadLinkResponse
        /// </returns>
        public async Task<GetTempFileDownloadLinkResponse> GetTempFileDownloadLinkAsync(GetTempFileDownloadLinkRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetTempFileDownloadLinkWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Installs an HBR client on one or more Elastic Compute Service (ECS) instances.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  This operation creates an asynchronous job at the backend and calls Cloud Assistant to install an HBR client on an ECS instance.</para>
        /// <list type="bullet">
        /// <item><description>You can call the <a href="https://help.aliyun.com/document_detail/431265.html">DescribeTask</a> operation to query the execution result of an asynchronous job.</description></item>
        /// <item><description>The timeout period of an asynchronous job is 15 minutes. We recommend that you call the DescribeTask operation to run the first query 60 seconds after you call the InstallBackupClients operation to install HBR clients. Then, run the next queries at an interval of 30 seconds.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// InstallBackupClientsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// InstallBackupClientsResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Installs an HBR client on one or more Elastic Compute Service (ECS) instances.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  This operation creates an asynchronous job at the backend and calls Cloud Assistant to install an HBR client on an ECS instance.</para>
        /// <list type="bullet">
        /// <item><description>You can call the <a href="https://help.aliyun.com/document_detail/431265.html">DescribeTask</a> operation to query the execution result of an asynchronous job.</description></item>
        /// <item><description>The timeout period of an asynchronous job is 15 minutes. We recommend that you call the DescribeTask operation to run the first query 60 seconds after you call the InstallBackupClients operation to install HBR clients. Then, run the next queries at an interval of 30 seconds.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// InstallBackupClientsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// InstallBackupClientsResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Installs an HBR client on one or more Elastic Compute Service (ECS) instances.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  This operation creates an asynchronous job at the backend and calls Cloud Assistant to install an HBR client on an ECS instance.</para>
        /// <list type="bullet">
        /// <item><description>You can call the <a href="https://help.aliyun.com/document_detail/431265.html">DescribeTask</a> operation to query the execution result of an asynchronous job.</description></item>
        /// <item><description>The timeout period of an asynchronous job is 15 minutes. We recommend that you call the DescribeTask operation to run the first query 60 seconds after you call the InstallBackupClients operation to install HBR clients. Then, run the next queries at an interval of 30 seconds.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// InstallBackupClientsRequest
        /// </param>
        /// 
        /// <returns>
        /// InstallBackupClientsResponse
        /// </returns>
        public InstallBackupClientsResponse InstallBackupClients(InstallBackupClientsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return InstallBackupClientsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Installs an HBR client on one or more Elastic Compute Service (ECS) instances.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  This operation creates an asynchronous job at the backend and calls Cloud Assistant to install an HBR client on an ECS instance.</para>
        /// <list type="bullet">
        /// <item><description>You can call the <a href="https://help.aliyun.com/document_detail/431265.html">DescribeTask</a> operation to query the execution result of an asynchronous job.</description></item>
        /// <item><description>The timeout period of an asynchronous job is 15 minutes. We recommend that you call the DescribeTask operation to run the first query 60 seconds after you call the InstallBackupClients operation to install HBR clients. Then, run the next queries at an interval of 30 seconds.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// InstallBackupClientsRequest
        /// </param>
        /// 
        /// <returns>
        /// InstallBackupClientsResponse
        /// </returns>
        public async Task<InstallBackupClientsResponse> InstallBackupClientsAsync(InstallBackupClientsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await InstallBackupClientsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Activates Cloud Backup.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// OpenHbrServiceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// OpenHbrServiceResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Activates Cloud Backup.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// OpenHbrServiceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// OpenHbrServiceResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Activates Cloud Backup.</para>
        /// </summary>
        /// 
        /// <returns>
        /// OpenHbrServiceResponse
        /// </returns>
        public OpenHbrServiceResponse OpenHbrService()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return OpenHbrServiceWithOptions(runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Activates Cloud Backup.</para>
        /// </summary>
        /// 
        /// <returns>
        /// OpenHbrServiceResponse
        /// </returns>
        public async Task<OpenHbrServiceResponse> OpenHbrServiceAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await OpenHbrServiceWithOptionsAsync(runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about one or more backup snapshots that meet the specified conditions.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// SearchHistoricalSnapshotsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SearchHistoricalSnapshotsResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about one or more backup snapshots that meet the specified conditions.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// SearchHistoricalSnapshotsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SearchHistoricalSnapshotsResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about one or more backup snapshots that meet the specified conditions.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SearchHistoricalSnapshotsRequest
        /// </param>
        /// 
        /// <returns>
        /// SearchHistoricalSnapshotsResponse
        /// </returns>
        public SearchHistoricalSnapshotsResponse SearchHistoricalSnapshots(SearchHistoricalSnapshotsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SearchHistoricalSnapshotsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about one or more backup snapshots that meet the specified conditions.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SearchHistoricalSnapshotsRequest
        /// </param>
        /// 
        /// <returns>
        /// SearchHistoricalSnapshotsResponse
        /// </returns>
        public async Task<SearchHistoricalSnapshotsResponse> SearchHistoricalSnapshotsAsync(SearchHistoricalSnapshotsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SearchHistoricalSnapshotsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Starts an SAP HANA database.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>To stop the database again, call the StopHanaDatabaseAsync operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// StartHanaDatabaseAsyncRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// StartHanaDatabaseAsyncResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Starts an SAP HANA database.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>To stop the database again, call the StopHanaDatabaseAsync operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// StartHanaDatabaseAsyncRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// StartHanaDatabaseAsyncResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Starts an SAP HANA database.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>To stop the database again, call the StopHanaDatabaseAsync operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// StartHanaDatabaseAsyncRequest
        /// </param>
        /// 
        /// <returns>
        /// StartHanaDatabaseAsyncResponse
        /// </returns>
        public StartHanaDatabaseAsyncResponse StartHanaDatabaseAsync(StartHanaDatabaseAsyncRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StartHanaDatabaseAsyncWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Starts an SAP HANA database.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>To stop the database again, call the StopHanaDatabaseAsync operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// StartHanaDatabaseAsyncRequest
        /// </param>
        /// 
        /// <returns>
        /// StartHanaDatabaseAsyncResponse
        /// </returns>
        public async Task<StartHanaDatabaseAsyncResponse> StartHanaDatabaseAsyncAsync(StartHanaDatabaseAsyncRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StartHanaDatabaseAsyncWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Stops an SAP HANA database.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>To start the database again, call the StartHanaDatabaseAsync operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// StopHanaDatabaseAsyncRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// StopHanaDatabaseAsyncResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Stops an SAP HANA database.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>To start the database again, call the StartHanaDatabaseAsync operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// StopHanaDatabaseAsyncRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// StopHanaDatabaseAsyncResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Stops an SAP HANA database.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>To start the database again, call the StartHanaDatabaseAsync operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// StopHanaDatabaseAsyncRequest
        /// </param>
        /// 
        /// <returns>
        /// StopHanaDatabaseAsyncResponse
        /// </returns>
        public StopHanaDatabaseAsyncResponse StopHanaDatabaseAsync(StopHanaDatabaseAsyncRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StopHanaDatabaseAsyncWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Stops an SAP HANA database.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>To start the database again, call the StartHanaDatabaseAsync operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// StopHanaDatabaseAsyncRequest
        /// </param>
        /// 
        /// <returns>
        /// StopHanaDatabaseAsyncResponse
        /// </returns>
        public async Task<StopHanaDatabaseAsyncResponse> StopHanaDatabaseAsyncAsync(StopHanaDatabaseAsyncRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StopHanaDatabaseAsyncWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Uninstalls a Cloud Backup client from one or more Elastic Compute Service (ECS) instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  This operation creates an asynchronous job at the backend and calls Cloud Assistant to uninstall a backup client from an ECS instance.</para>
        /// <list type="bullet">
        /// <item><description>You can call the DescribeTask operation to query the execution result of an asynchronous job.</description></item>
        /// <item><description>The timeout period of an asynchronous job is 15 minutes. We recommend that you call the DescribeTask operation to run the first query 30 seconds after you call the UninstallBackupClients operation to uninstall backup clients. Then, run the next queries at an interval of 30 seconds.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// UninstallBackupClientsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UninstallBackupClientsResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Uninstalls a Cloud Backup client from one or more Elastic Compute Service (ECS) instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  This operation creates an asynchronous job at the backend and calls Cloud Assistant to uninstall a backup client from an ECS instance.</para>
        /// <list type="bullet">
        /// <item><description>You can call the DescribeTask operation to query the execution result of an asynchronous job.</description></item>
        /// <item><description>The timeout period of an asynchronous job is 15 minutes. We recommend that you call the DescribeTask operation to run the first query 30 seconds after you call the UninstallBackupClients operation to uninstall backup clients. Then, run the next queries at an interval of 30 seconds.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// UninstallBackupClientsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UninstallBackupClientsResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Uninstalls a Cloud Backup client from one or more Elastic Compute Service (ECS) instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  This operation creates an asynchronous job at the backend and calls Cloud Assistant to uninstall a backup client from an ECS instance.</para>
        /// <list type="bullet">
        /// <item><description>You can call the DescribeTask operation to query the execution result of an asynchronous job.</description></item>
        /// <item><description>The timeout period of an asynchronous job is 15 minutes. We recommend that you call the DescribeTask operation to run the first query 30 seconds after you call the UninstallBackupClients operation to uninstall backup clients. Then, run the next queries at an interval of 30 seconds.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// UninstallBackupClientsRequest
        /// </param>
        /// 
        /// <returns>
        /// UninstallBackupClientsResponse
        /// </returns>
        public UninstallBackupClientsResponse UninstallBackupClients(UninstallBackupClientsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UninstallBackupClientsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Uninstalls a Cloud Backup client from one or more Elastic Compute Service (ECS) instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  This operation creates an asynchronous job at the backend and calls Cloud Assistant to uninstall a backup client from an ECS instance.</para>
        /// <list type="bullet">
        /// <item><description>You can call the DescribeTask operation to query the execution result of an asynchronous job.</description></item>
        /// <item><description>The timeout period of an asynchronous job is 15 minutes. We recommend that you call the DescribeTask operation to run the first query 30 seconds after you call the UninstallBackupClients operation to uninstall backup clients. Then, run the next queries at an interval of 30 seconds.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// UninstallBackupClientsRequest
        /// </param>
        /// 
        /// <returns>
        /// UninstallBackupClientsResponse
        /// </returns>
        public async Task<UninstallBackupClientsResponse> UninstallBackupClientsAsync(UninstallBackupClientsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UninstallBackupClientsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Uninstalls an HBR client.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>If you call this operation, the specified HBR client is uninstalled. To reinstall the HBR client, call the CreateClients operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UninstallClientRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UninstallClientResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Uninstalls an HBR client.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>If you call this operation, the specified HBR client is uninstalled. To reinstall the HBR client, call the CreateClients operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UninstallClientRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UninstallClientResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Uninstalls an HBR client.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>If you call this operation, the specified HBR client is uninstalled. To reinstall the HBR client, call the CreateClients operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UninstallClientRequest
        /// </param>
        /// 
        /// <returns>
        /// UninstallClientResponse
        /// </returns>
        public UninstallClientResponse UninstallClient(UninstallClientRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UninstallClientWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Uninstalls an HBR client.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>If you call this operation, the specified HBR client is uninstalled. To reinstall the HBR client, call the CreateClients operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UninstallClientRequest
        /// </param>
        /// 
        /// <returns>
        /// UninstallClientResponse
        /// </returns>
        public async Task<UninstallClientResponse> UninstallClientAsync(UninstallClientRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UninstallClientWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates a backup plan.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// UpdateBackupPlanRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateBackupPlanResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates a backup plan.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// UpdateBackupPlanRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateBackupPlanResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates a backup plan.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateBackupPlanRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateBackupPlanResponse
        /// </returns>
        public UpdateBackupPlanResponse UpdateBackupPlan(UpdateBackupPlanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateBackupPlanWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates a backup plan.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateBackupPlanRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateBackupPlanResponse
        /// </returns>
        public async Task<UpdateBackupPlanResponse> UpdateBackupPlanAsync(UpdateBackupPlanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateBackupPlanWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the configurations of an HBR client.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call this operation to update the configurations of both the old and new HBR clients.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateClientSettingsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateClientSettingsResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the configurations of an HBR client.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call this operation to update the configurations of both the old and new HBR clients.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateClientSettingsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateClientSettingsResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the configurations of an HBR client.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call this operation to update the configurations of both the old and new HBR clients.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateClientSettingsRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateClientSettingsResponse
        /// </returns>
        public UpdateClientSettingsResponse UpdateClientSettings(UpdateClientSettingsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateClientSettingsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the configurations of an HBR client.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call this operation to update the configurations of both the old and new HBR clients.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateClientSettingsRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateClientSettingsResponse
        /// </returns>
        public async Task<UpdateClientSettingsResponse> UpdateClientSettingsAsync(UpdateClientSettingsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateClientSettingsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Update container cluster information, including the container cluster name, network type, etc.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateContainerClusterRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateContainerClusterResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Update container cluster information, including the container cluster name, network type, etc.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateContainerClusterRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateContainerClusterResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Update container cluster information, including the container cluster name, network type, etc.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateContainerClusterRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateContainerClusterResponse
        /// </returns>
        public UpdateContainerClusterResponse UpdateContainerCluster(UpdateContainerClusterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateContainerClusterWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Update container cluster information, including the container cluster name, network type, etc.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateContainerClusterRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateContainerClusterResponse
        /// </returns>
        public async Task<UpdateContainerClusterResponse> UpdateContainerClusterAsync(UpdateContainerClusterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateContainerClusterWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates an SAP HANA backup plan.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  A backup plan defines the data source, backup policy, and other configurations. After you execute a backup plan, a backup job is generated to record the backup progress and the backup result. If a backup job is completed, a backup snapshot is generated. You can use a backup snapshot to create a restore job.</para>
        /// <list type="bullet">
        /// <item><description>You can specify only one type of data source in a backup plan.</description></item>
        /// <item><description>You can specify only one interval as a backup cycle in a backup plan.</description></item>
        /// <item><description>Each backup plan allows you to back up data to only one backup vault.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateHanaBackupPlanRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateHanaBackupPlanResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates an SAP HANA backup plan.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  A backup plan defines the data source, backup policy, and other configurations. After you execute a backup plan, a backup job is generated to record the backup progress and the backup result. If a backup job is completed, a backup snapshot is generated. You can use a backup snapshot to create a restore job.</para>
        /// <list type="bullet">
        /// <item><description>You can specify only one type of data source in a backup plan.</description></item>
        /// <item><description>You can specify only one interval as a backup cycle in a backup plan.</description></item>
        /// <item><description>Each backup plan allows you to back up data to only one backup vault.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateHanaBackupPlanRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateHanaBackupPlanResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates an SAP HANA backup plan.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  A backup plan defines the data source, backup policy, and other configurations. After you execute a backup plan, a backup job is generated to record the backup progress and the backup result. If a backup job is completed, a backup snapshot is generated. You can use a backup snapshot to create a restore job.</para>
        /// <list type="bullet">
        /// <item><description>You can specify only one type of data source in a backup plan.</description></item>
        /// <item><description>You can specify only one interval as a backup cycle in a backup plan.</description></item>
        /// <item><description>Each backup plan allows you to back up data to only one backup vault.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateHanaBackupPlanRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateHanaBackupPlanResponse
        /// </returns>
        public UpdateHanaBackupPlanResponse UpdateHanaBackupPlan(UpdateHanaBackupPlanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateHanaBackupPlanWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates an SAP HANA backup plan.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  A backup plan defines the data source, backup policy, and other configurations. After you execute a backup plan, a backup job is generated to record the backup progress and the backup result. If a backup job is completed, a backup snapshot is generated. You can use a backup snapshot to create a restore job.</para>
        /// <list type="bullet">
        /// <item><description>You can specify only one type of data source in a backup plan.</description></item>
        /// <item><description>You can specify only one interval as a backup cycle in a backup plan.</description></item>
        /// <item><description>Each backup plan allows you to back up data to only one backup vault.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateHanaBackupPlanRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateHanaBackupPlanResponse
        /// </returns>
        public async Task<UpdateHanaBackupPlanResponse> UpdateHanaBackupPlanAsync(UpdateHanaBackupPlanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateHanaBackupPlanWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the backup parameters of an SAP HANA database.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call the UpdateHanaRetentionSetting operation to update the backup retention period of a database.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateHanaBackupSettingRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateHanaBackupSettingResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the backup parameters of an SAP HANA database.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call the UpdateHanaRetentionSetting operation to update the backup retention period of a database.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateHanaBackupSettingRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateHanaBackupSettingResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the backup parameters of an SAP HANA database.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call the UpdateHanaRetentionSetting operation to update the backup retention period of a database.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateHanaBackupSettingRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateHanaBackupSettingResponse
        /// </returns>
        public UpdateHanaBackupSettingResponse UpdateHanaBackupSetting(UpdateHanaBackupSettingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateHanaBackupSettingWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the backup parameters of an SAP HANA database.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call the UpdateHanaRetentionSetting operation to update the backup retention period of a database.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateHanaBackupSettingRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateHanaBackupSettingResponse
        /// </returns>
        public async Task<UpdateHanaBackupSettingResponse> UpdateHanaBackupSettingAsync(UpdateHanaBackupSettingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateHanaBackupSettingWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates an SAP HANA instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateHanaInstanceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateHanaInstanceResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates an SAP HANA instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateHanaInstanceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateHanaInstanceResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates an SAP HANA instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateHanaInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateHanaInstanceResponse
        /// </returns>
        public UpdateHanaInstanceResponse UpdateHanaInstance(UpdateHanaInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateHanaInstanceWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates an SAP HANA instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateHanaInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateHanaInstanceResponse
        /// </returns>
        public async Task<UpdateHanaInstanceResponse> UpdateHanaInstanceAsync(UpdateHanaInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateHanaInstanceWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the backup retention period of an SAP HANA database.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  If you want to update the backup parameters of a database, you can call the UpdateHanaBackupSetting operation.</para>
        /// <list type="bullet">
        /// <item><description>Cloud Backup deletes the expired catalogs and data that are related to Backint and file backup. The deleted catalogs and data cannot be restored. We recommend that you set the retention period based on your business requirements.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateHanaRetentionSettingRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateHanaRetentionSettingResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the backup retention period of an SAP HANA database.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  If you want to update the backup parameters of a database, you can call the UpdateHanaBackupSetting operation.</para>
        /// <list type="bullet">
        /// <item><description>Cloud Backup deletes the expired catalogs and data that are related to Backint and file backup. The deleted catalogs and data cannot be restored. We recommend that you set the retention period based on your business requirements.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateHanaRetentionSettingRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateHanaRetentionSettingResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the backup retention period of an SAP HANA database.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  If you want to update the backup parameters of a database, you can call the UpdateHanaBackupSetting operation.</para>
        /// <list type="bullet">
        /// <item><description>Cloud Backup deletes the expired catalogs and data that are related to Backint and file backup. The deleted catalogs and data cannot be restored. We recommend that you set the retention period based on your business requirements.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateHanaRetentionSettingRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateHanaRetentionSettingResponse
        /// </returns>
        public UpdateHanaRetentionSettingResponse UpdateHanaRetentionSetting(UpdateHanaRetentionSettingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateHanaRetentionSettingWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the backup retention period of an SAP HANA database.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  If you want to update the backup parameters of a database, you can call the UpdateHanaBackupSetting operation.</para>
        /// <list type="bullet">
        /// <item><description>Cloud Backup deletes the expired catalogs and data that are related to Backint and file backup. The deleted catalogs and data cannot be restored. We recommend that you set the retention period based on your business requirements.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateHanaRetentionSettingRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateHanaRetentionSettingResponse
        /// </returns>
        public async Task<UpdateHanaRetentionSettingResponse> UpdateHanaRetentionSettingAsync(UpdateHanaRetentionSettingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateHanaRetentionSettingWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the association between a backup policy and a data source.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// UpdatePolicyBindingRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdatePolicyBindingResponse
        /// </returns>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Exclude))
            {
                query["Exclude"] = request.Exclude;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Include))
            {
                query["Include"] = request.Include;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyBindingDescription))
            {
                query["PolicyBindingDescription"] = request.PolicyBindingDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Source))
            {
                query["Source"] = request.Source;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceType))
            {
                query["SourceType"] = request.SourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SpeedLimit))
            {
                query["SpeedLimit"] = request.SpeedLimit;
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the association between a backup policy and a data source.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// UpdatePolicyBindingRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdatePolicyBindingResponse
        /// </returns>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Exclude))
            {
                query["Exclude"] = request.Exclude;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Include))
            {
                query["Include"] = request.Include;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyBindingDescription))
            {
                query["PolicyBindingDescription"] = request.PolicyBindingDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Source))
            {
                query["Source"] = request.Source;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceType))
            {
                query["SourceType"] = request.SourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SpeedLimit))
            {
                query["SpeedLimit"] = request.SpeedLimit;
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the association between a backup policy and a data source.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdatePolicyBindingRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdatePolicyBindingResponse
        /// </returns>
        public UpdatePolicyBindingResponse UpdatePolicyBinding(UpdatePolicyBindingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdatePolicyBindingWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the association between a backup policy and a data source.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdatePolicyBindingRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdatePolicyBindingResponse
        /// </returns>
        public async Task<UpdatePolicyBindingResponse> UpdatePolicyBindingAsync(UpdatePolicyBindingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdatePolicyBindingWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies a backup policy.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>If you modify a backup policy, the modification takes effect on all data sources that are bound to the backup policy. Proceed with caution.</para>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// UpdatePolicyV2Request
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdatePolicyV2Response
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies a backup policy.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>If you modify a backup policy, the modification takes effect on all data sources that are bound to the backup policy. Proceed with caution.</para>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// UpdatePolicyV2Request
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdatePolicyV2Response
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies a backup policy.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>If you modify a backup policy, the modification takes effect on all data sources that are bound to the backup policy. Proceed with caution.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdatePolicyV2Request
        /// </param>
        /// 
        /// <returns>
        /// UpdatePolicyV2Response
        /// </returns>
        public UpdatePolicyV2Response UpdatePolicyV2(UpdatePolicyV2Request request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdatePolicyV2WithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies a backup policy.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>If you modify a backup policy, the modification takes effect on all data sources that are bound to the backup policy. Proceed with caution.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdatePolicyV2Request
        /// </param>
        /// 
        /// <returns>
        /// UpdatePolicyV2Response
        /// </returns>
        public async Task<UpdatePolicyV2Response> UpdatePolicyV2Async(UpdatePolicyV2Request request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdatePolicyV2WithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the configuration information about the backup vault.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateVaultRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateVaultResponse
        /// </returns>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WormEnabled))
            {
                query["WormEnabled"] = request.WormEnabled;
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the configuration information about the backup vault.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateVaultRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateVaultResponse
        /// </returns>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WormEnabled))
            {
                query["WormEnabled"] = request.WormEnabled;
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the configuration information about the backup vault.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateVaultRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateVaultResponse
        /// </returns>
        public UpdateVaultResponse UpdateVault(UpdateVaultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateVaultWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the configuration information about the backup vault.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateVaultRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateVaultResponse
        /// </returns>
        public async Task<UpdateVaultResponse> UpdateVaultAsync(UpdateVaultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateVaultWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Upgrades an HBR client on one or more Elastic Compute Service (ECS) instances.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  This operation creates an asynchronous job at the backend and calls Cloud Assistant to upgrade an HBR client that is installed on an ECS instance.</para>
        /// <list type="bullet">
        /// <item><description>You can call the DescribeTask operation to query the execution result of an asynchronous job.</description></item>
        /// <item><description>The timeout period of an asynchronous job is 15 minutes.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// UpgradeBackupClientsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpgradeBackupClientsResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Upgrades an HBR client on one or more Elastic Compute Service (ECS) instances.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  This operation creates an asynchronous job at the backend and calls Cloud Assistant to upgrade an HBR client that is installed on an ECS instance.</para>
        /// <list type="bullet">
        /// <item><description>You can call the DescribeTask operation to query the execution result of an asynchronous job.</description></item>
        /// <item><description>The timeout period of an asynchronous job is 15 minutes.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// UpgradeBackupClientsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpgradeBackupClientsResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Upgrades an HBR client on one or more Elastic Compute Service (ECS) instances.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  This operation creates an asynchronous job at the backend and calls Cloud Assistant to upgrade an HBR client that is installed on an ECS instance.</para>
        /// <list type="bullet">
        /// <item><description>You can call the DescribeTask operation to query the execution result of an asynchronous job.</description></item>
        /// <item><description>The timeout period of an asynchronous job is 15 minutes.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// UpgradeBackupClientsRequest
        /// </param>
        /// 
        /// <returns>
        /// UpgradeBackupClientsResponse
        /// </returns>
        public UpgradeBackupClientsResponse UpgradeBackupClients(UpgradeBackupClientsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpgradeBackupClientsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Upgrades an HBR client on one or more Elastic Compute Service (ECS) instances.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  This operation creates an asynchronous job at the backend and calls Cloud Assistant to upgrade an HBR client that is installed on an ECS instance.</para>
        /// <list type="bullet">
        /// <item><description>You can call the DescribeTask operation to query the execution result of an asynchronous job.</description></item>
        /// <item><description>The timeout period of an asynchronous job is 15 minutes.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// UpgradeBackupClientsRequest
        /// </param>
        /// 
        /// <returns>
        /// UpgradeBackupClientsResponse
        /// </returns>
        public async Task<UpgradeBackupClientsResponse> UpgradeBackupClientsAsync(UpgradeBackupClientsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpgradeBackupClientsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Upgrades the Cloud Backup client.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call this operation to upgrade a Cloud Backup client to the latest version. After the Cloud Backup client is upgraded, the version of the client cannot be rolled back.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpgradeClientRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpgradeClientResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Upgrades the Cloud Backup client.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call this operation to upgrade a Cloud Backup client to the latest version. After the Cloud Backup client is upgraded, the version of the client cannot be rolled back.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpgradeClientRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpgradeClientResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Upgrades the Cloud Backup client.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call this operation to upgrade a Cloud Backup client to the latest version. After the Cloud Backup client is upgraded, the version of the client cannot be rolled back.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpgradeClientRequest
        /// </param>
        /// 
        /// <returns>
        /// UpgradeClientResponse
        /// </returns>
        public UpgradeClientResponse UpgradeClient(UpgradeClientRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpgradeClientWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Upgrades the Cloud Backup client.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call this operation to upgrade a Cloud Backup client to the latest version. After the Cloud Backup client is upgraded, the version of the client cannot be rolled back.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpgradeClientRequest
        /// </param>
        /// 
        /// <returns>
        /// UpgradeClientResponse
        /// </returns>
        public async Task<UpgradeClientResponse> UpgradeClientAsync(UpgradeClientRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpgradeClientWithOptionsAsync(request, runtime);
        }

    }
}
