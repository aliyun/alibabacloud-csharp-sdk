// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Adcp20220101.Models;

namespace AlibabaCloud.SDK.Adcp20220101
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "central";
            this._endpointMap = new Dictionary<string, string>
            {
                {"cn-beijing", "adcp.cn-beijing.aliyuncs.com"},
                {"cn-zhangjiakou", "adcp.cn-zhangjiakou.aliyuncs.com"},
                {"cn-hangzhou", "adcp.cn-hangzhou.aliyuncs.com"},
                {"cn-shanghai", "adcp.cn-shanghai.aliyuncs.com"},
                {"cn-shenzhen", "adcp.cn-shenzhen.aliyuncs.com"},
                {"cn-heyuan", "adcp.cn-heyuan.aliyuncs.com"},
                {"cn-hongkong", "adcp.cn-hongkong.aliyuncs.com"},
                {"ap-northeast-1", "adcp.ap-northeast-1.aliyuncs.com"},
                {"ap-southeast-1", "adcp.ap-southeast-1.aliyuncs.com"},
                {"ap-southeast-5", "adcp.ap-southeast-5.aliyuncs.com"},
                {"ap-south-1", "adcp.ap-south-1.aliyuncs.com"},
                {"ap-southeast-2", "adcp.ap-southeast-2.aliyuncs.com"},
                {"ap-southeast-3", "adcp.ap-southeast-3.aliyuncs.com"},
                {"cn-chengdu", "adcp-vpc.cn-chengdu.aliyuncs.com"},
                {"cn-huhehaote", "adcp.cn-huhehaote.aliyuncs.com"},
                {"cn-qingdao", "adcp.cn-qingdao.aliyuncs.com"},
                {"cn-shanghai-finance-1", "adcp-vpc.cn-shanghai-finance-1.aliyuncs.com"},
                {"cn-wulanchabu", "adcp.cn-wulanchabu.aliyuncs.com"},
                {"eu-central-1", "adcp.eu-central-1.aliyuncs.com"},
                {"eu-west-1", "adcp-vpc.eu-west-1.aliyuncs.com"},
                {"me-east-1", "adcp.me-east-1.aliyuncs.com"},
                {"us-east-1", "adcp.us-east-1.aliyuncs.com"},
                {"us-west-1", "adcp.us-west-1.aliyuncs.com"},
            };
            CheckConfig(config);
            this._endpoint = GetEndpoint("adcp", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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

        /**
         * @summary You can search for API operations, call and debug API operations online, and dynamically generate executable sample code for SDKs.
         *
         * @param request AttachClusterToHubRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return AttachClusterToHubResponse
         */
        public AttachClusterToHubResponse AttachClusterToHubWithOptions(AttachClusterToHubRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AttachToMesh))
            {
                query["AttachToMesh"] = request.AttachToMesh;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterIds))
            {
                body["ClusterIds"] = request.ClusterIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AttachClusterToHub",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AttachClusterToHubResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary You can search for API operations, call and debug API operations online, and dynamically generate executable sample code for SDKs.
         *
         * @param request AttachClusterToHubRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return AttachClusterToHubResponse
         */
        public async Task<AttachClusterToHubResponse> AttachClusterToHubWithOptionsAsync(AttachClusterToHubRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AttachToMesh))
            {
                query["AttachToMesh"] = request.AttachToMesh;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterIds))
            {
                body["ClusterIds"] = request.ClusterIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AttachClusterToHub",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AttachClusterToHubResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary You can search for API operations, call and debug API operations online, and dynamically generate executable sample code for SDKs.
         *
         * @param request AttachClusterToHubRequest
         * @return AttachClusterToHubResponse
         */
        public AttachClusterToHubResponse AttachClusterToHub(AttachClusterToHubRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AttachClusterToHubWithOptions(request, runtime);
        }

        /**
         * @summary You can search for API operations, call and debug API operations online, and dynamically generate executable sample code for SDKs.
         *
         * @param request AttachClusterToHubRequest
         * @return AttachClusterToHubResponse
         */
        public async Task<AttachClusterToHubResponse> AttachClusterToHubAsync(AttachClusterToHubRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AttachClusterToHubWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 更新资源组
         *
         * @param request ChangeResourceGroupRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ChangeResourceGroupResponse
         */
        public ChangeResourceGroupResponse ChangeResourceGroupWithOptions(ChangeResourceGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NewResourceGroupId))
            {
                query["NewResourceGroupId"] = request.NewResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceId))
            {
                query["ResourceId"] = request.ResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["ResourceType"] = request.ResourceType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ChangeResourceGroup",
                Version = "2022-01-01",
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
         * @summary 更新资源组
         *
         * @param request ChangeResourceGroupRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ChangeResourceGroupResponse
         */
        public async Task<ChangeResourceGroupResponse> ChangeResourceGroupWithOptionsAsync(ChangeResourceGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NewResourceGroupId))
            {
                query["NewResourceGroupId"] = request.NewResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceId))
            {
                query["ResourceId"] = request.ResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["ResourceType"] = request.ResourceType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ChangeResourceGroup",
                Version = "2022-01-01",
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
         * @summary 更新资源组
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
         * @summary 更新资源组
         *
         * @param request ChangeResourceGroupRequest
         * @return ChangeResourceGroupResponse
         */
        public async Task<ChangeResourceGroupResponse> ChangeResourceGroupAsync(ChangeResourceGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ChangeResourceGroupWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Creates a master instance in Alibaba Cloud Distributed Cloud Container Platform (ACK One).
         *
         * @param tmpReq CreateHubClusterRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateHubClusterResponse
         */
        public CreateHubClusterResponse CreateHubClusterWithOptions(CreateHubClusterRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateHubClusterShrinkRequest request = new CreateHubClusterShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Tag))
            {
                request.TagShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Tag, "Tag", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagShrink))
            {
                query["Tag"] = request.TagShrink;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApiServerPublicEip))
            {
                body["ApiServerPublicEip"] = request.ApiServerPublicEip;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ArgoServerEnabled))
            {
                body["ArgoServerEnabled"] = request.ArgoServerEnabled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuditLogEnabled))
            {
                body["AuditLogEnabled"] = request.AuditLogEnabled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsEnterpriseSecurityGroup))
            {
                body["IsEnterpriseSecurityGroup"] = request.IsEnterpriseSecurityGroup;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PriceLimit))
            {
                body["PriceLimit"] = request.PriceLimit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Profile))
            {
                body["Profile"] = request.Profile;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupID))
            {
                body["ResourceGroupID"] = request.ResourceGroupID;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VSwitches))
            {
                body["VSwitches"] = request.VSwitches;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcId))
            {
                body["VpcId"] = request.VpcId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkflowScheduleMode))
            {
                body["WorkflowScheduleMode"] = request.WorkflowScheduleMode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateHubCluster",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateHubClusterResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Creates a master instance in Alibaba Cloud Distributed Cloud Container Platform (ACK One).
         *
         * @param tmpReq CreateHubClusterRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateHubClusterResponse
         */
        public async Task<CreateHubClusterResponse> CreateHubClusterWithOptionsAsync(CreateHubClusterRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateHubClusterShrinkRequest request = new CreateHubClusterShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Tag))
            {
                request.TagShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Tag, "Tag", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagShrink))
            {
                query["Tag"] = request.TagShrink;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApiServerPublicEip))
            {
                body["ApiServerPublicEip"] = request.ApiServerPublicEip;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ArgoServerEnabled))
            {
                body["ArgoServerEnabled"] = request.ArgoServerEnabled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuditLogEnabled))
            {
                body["AuditLogEnabled"] = request.AuditLogEnabled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsEnterpriseSecurityGroup))
            {
                body["IsEnterpriseSecurityGroup"] = request.IsEnterpriseSecurityGroup;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PriceLimit))
            {
                body["PriceLimit"] = request.PriceLimit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Profile))
            {
                body["Profile"] = request.Profile;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupID))
            {
                body["ResourceGroupID"] = request.ResourceGroupID;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VSwitches))
            {
                body["VSwitches"] = request.VSwitches;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcId))
            {
                body["VpcId"] = request.VpcId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkflowScheduleMode))
            {
                body["WorkflowScheduleMode"] = request.WorkflowScheduleMode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateHubCluster",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateHubClusterResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Creates a master instance in Alibaba Cloud Distributed Cloud Container Platform (ACK One).
         *
         * @param request CreateHubClusterRequest
         * @return CreateHubClusterResponse
         */
        public CreateHubClusterResponse CreateHubCluster(CreateHubClusterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateHubClusterWithOptions(request, runtime);
        }

        /**
         * @summary Creates a master instance in Alibaba Cloud Distributed Cloud Container Platform (ACK One).
         *
         * @param request CreateHubClusterRequest
         * @return CreateHubClusterResponse
         */
        public async Task<CreateHubClusterResponse> CreateHubClusterAsync(CreateHubClusterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateHubClusterWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Deletes a master cluster in Alibaba Cloud Distributed Cloud Container Platform (ACK One).
         *
         * @param tmpReq DeleteHubClusterRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteHubClusterResponse
         */
        public DeleteHubClusterResponse DeleteHubClusterWithOptions(DeleteHubClusterRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DeleteHubClusterShrinkRequest request = new DeleteHubClusterShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.RetainResources))
            {
                request.RetainResourcesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.RetainResources, "RetainResources", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Force))
            {
                query["Force"] = request.Force;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RetainResourcesShrink))
            {
                query["RetainResources"] = request.RetainResourcesShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteHubCluster",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteHubClusterResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Deletes a master cluster in Alibaba Cloud Distributed Cloud Container Platform (ACK One).
         *
         * @param tmpReq DeleteHubClusterRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteHubClusterResponse
         */
        public async Task<DeleteHubClusterResponse> DeleteHubClusterWithOptionsAsync(DeleteHubClusterRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DeleteHubClusterShrinkRequest request = new DeleteHubClusterShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.RetainResources))
            {
                request.RetainResourcesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.RetainResources, "RetainResources", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Force))
            {
                query["Force"] = request.Force;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RetainResourcesShrink))
            {
                query["RetainResources"] = request.RetainResourcesShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteHubCluster",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteHubClusterResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Deletes a master cluster in Alibaba Cloud Distributed Cloud Container Platform (ACK One).
         *
         * @param request DeleteHubClusterRequest
         * @return DeleteHubClusterResponse
         */
        public DeleteHubClusterResponse DeleteHubCluster(DeleteHubClusterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteHubClusterWithOptions(request, runtime);
        }

        /**
         * @summary Deletes a master cluster in Alibaba Cloud Distributed Cloud Container Platform (ACK One).
         *
         * @param request DeleteHubClusterRequest
         * @return DeleteHubClusterResponse
         */
        public async Task<DeleteHubClusterResponse> DeleteHubClusterAsync(DeleteHubClusterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteHubClusterWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Deletes a policy for associated clusters.
         *
         * @param tmpReq DeletePolicyInstanceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeletePolicyInstanceResponse
         */
        public DeletePolicyInstanceResponse DeletePolicyInstanceWithOptions(DeletePolicyInstanceRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DeletePolicyInstanceShrinkRequest request = new DeletePolicyInstanceShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ClusterIds))
            {
                request.ClusterIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ClusterIds, "ClusterIds", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterIdsShrink))
            {
                query["ClusterIds"] = request.ClusterIdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyName))
            {
                query["PolicyName"] = request.PolicyName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeletePolicyInstance",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeletePolicyInstanceResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Deletes a policy for associated clusters.
         *
         * @param tmpReq DeletePolicyInstanceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeletePolicyInstanceResponse
         */
        public async Task<DeletePolicyInstanceResponse> DeletePolicyInstanceWithOptionsAsync(DeletePolicyInstanceRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DeletePolicyInstanceShrinkRequest request = new DeletePolicyInstanceShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ClusterIds))
            {
                request.ClusterIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ClusterIds, "ClusterIds", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterIdsShrink))
            {
                query["ClusterIds"] = request.ClusterIdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyName))
            {
                query["PolicyName"] = request.PolicyName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeletePolicyInstance",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeletePolicyInstanceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Deletes a policy for associated clusters.
         *
         * @param request DeletePolicyInstanceRequest
         * @return DeletePolicyInstanceResponse
         */
        public DeletePolicyInstanceResponse DeletePolicyInstance(DeletePolicyInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeletePolicyInstanceWithOptions(request, runtime);
        }

        /**
         * @summary Deletes a policy for associated clusters.
         *
         * @param request DeletePolicyInstanceRequest
         * @return DeletePolicyInstanceResponse
         */
        public async Task<DeletePolicyInstanceResponse> DeletePolicyInstanceAsync(DeletePolicyInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeletePolicyInstanceWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Deletes the role-based access control (RBAC) permissions of a RAM user.
         *
         * @param request DeleteUserPermissionRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteUserPermissionResponse
         */
        public DeleteUserPermissionResponse DeleteUserPermissionWithOptions(DeleteUserPermissionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["UserId"] = request.UserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteUserPermission",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteUserPermissionResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Deletes the role-based access control (RBAC) permissions of a RAM user.
         *
         * @param request DeleteUserPermissionRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteUserPermissionResponse
         */
        public async Task<DeleteUserPermissionResponse> DeleteUserPermissionWithOptionsAsync(DeleteUserPermissionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["UserId"] = request.UserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteUserPermission",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteUserPermissionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Deletes the role-based access control (RBAC) permissions of a RAM user.
         *
         * @param request DeleteUserPermissionRequest
         * @return DeleteUserPermissionResponse
         */
        public DeleteUserPermissionResponse DeleteUserPermission(DeleteUserPermissionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteUserPermissionWithOptions(request, runtime);
        }

        /**
         * @summary Deletes the role-based access control (RBAC) permissions of a RAM user.
         *
         * @param request DeleteUserPermissionRequest
         * @return DeleteUserPermissionResponse
         */
        public async Task<DeleteUserPermissionResponse> DeleteUserPermissionAsync(DeleteUserPermissionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteUserPermissionWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Deploys a policy instance in the clusters that are associated with a master instance.
         *
         * @param tmpReq DeployPolicyInstanceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeployPolicyInstanceResponse
         */
        public DeployPolicyInstanceResponse DeployPolicyInstanceWithOptions(DeployPolicyInstanceRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DeployPolicyInstanceShrinkRequest request = new DeployPolicyInstanceShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ClusterIds))
            {
                request.ClusterIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ClusterIds, "ClusterIds", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Namespaces))
            {
                request.NamespacesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Namespaces, "Namespaces", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterIdsShrink))
            {
                query["ClusterIds"] = request.ClusterIdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NamespacesShrink))
            {
                query["Namespaces"] = request.NamespacesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyAction))
            {
                query["PolicyAction"] = request.PolicyAction;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyName))
            {
                query["PolicyName"] = request.PolicyName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeployPolicyInstance",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeployPolicyInstanceResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Deploys a policy instance in the clusters that are associated with a master instance.
         *
         * @param tmpReq DeployPolicyInstanceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeployPolicyInstanceResponse
         */
        public async Task<DeployPolicyInstanceResponse> DeployPolicyInstanceWithOptionsAsync(DeployPolicyInstanceRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DeployPolicyInstanceShrinkRequest request = new DeployPolicyInstanceShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ClusterIds))
            {
                request.ClusterIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ClusterIds, "ClusterIds", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Namespaces))
            {
                request.NamespacesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Namespaces, "Namespaces", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterIdsShrink))
            {
                query["ClusterIds"] = request.ClusterIdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NamespacesShrink))
            {
                query["Namespaces"] = request.NamespacesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyAction))
            {
                query["PolicyAction"] = request.PolicyAction;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyName))
            {
                query["PolicyName"] = request.PolicyName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeployPolicyInstance",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeployPolicyInstanceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Deploys a policy instance in the clusters that are associated with a master instance.
         *
         * @param request DeployPolicyInstanceRequest
         * @return DeployPolicyInstanceResponse
         */
        public DeployPolicyInstanceResponse DeployPolicyInstance(DeployPolicyInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeployPolicyInstanceWithOptions(request, runtime);
        }

        /**
         * @summary Deploys a policy instance in the clusters that are associated with a master instance.
         *
         * @param request DeployPolicyInstanceRequest
         * @return DeployPolicyInstanceResponse
         */
        public async Task<DeployPolicyInstanceResponse> DeployPolicyInstanceAsync(DeployPolicyInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeployPolicyInstanceWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the details of a master instance in Alibaba Cloud Distributed Cloud Container Platform (ACK One).
         *
         * @param request DescribeHubClusterDetailsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeHubClusterDetailsResponse
         */
        public DescribeHubClusterDetailsResponse DescribeHubClusterDetailsWithOptions(DescribeHubClusterDetailsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeHubClusterDetails",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeHubClusterDetailsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the details of a master instance in Alibaba Cloud Distributed Cloud Container Platform (ACK One).
         *
         * @param request DescribeHubClusterDetailsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeHubClusterDetailsResponse
         */
        public async Task<DescribeHubClusterDetailsResponse> DescribeHubClusterDetailsWithOptionsAsync(DescribeHubClusterDetailsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeHubClusterDetails",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeHubClusterDetailsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the details of a master instance in Alibaba Cloud Distributed Cloud Container Platform (ACK One).
         *
         * @param request DescribeHubClusterDetailsRequest
         * @return DescribeHubClusterDetailsResponse
         */
        public DescribeHubClusterDetailsResponse DescribeHubClusterDetails(DescribeHubClusterDetailsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeHubClusterDetailsWithOptions(request, runtime);
        }

        /**
         * @summary Queries the details of a master instance in Alibaba Cloud Distributed Cloud Container Platform (ACK One).
         *
         * @param request DescribeHubClusterDetailsRequest
         * @return DescribeHubClusterDetailsResponse
         */
        public async Task<DescribeHubClusterDetailsResponse> DescribeHubClusterDetailsAsync(DescribeHubClusterDetailsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeHubClusterDetailsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the kubeconfig file of a Distributed Cloud Container Platform for Kubernetes (ACK One) cluster. In addition to the Container Service for Kubernetes (ACK) console, you can also use the Kubernetes CLI kubectl to manage clusters and applications. If you use kubectl to manage an ACK cluster, you must obtain the kubeconfig file of the cluster and use kubectl to connect to the cluster.
         *
         * @param request DescribeHubClusterKubeconfigRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeHubClusterKubeconfigResponse
         */
        public DescribeHubClusterKubeconfigResponse DescribeHubClusterKubeconfigWithOptions(DescribeHubClusterKubeconfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PrivateIpAddress))
            {
                query["PrivateIpAddress"] = request.PrivateIpAddress;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeHubClusterKubeconfig",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeHubClusterKubeconfigResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the kubeconfig file of a Distributed Cloud Container Platform for Kubernetes (ACK One) cluster. In addition to the Container Service for Kubernetes (ACK) console, you can also use the Kubernetes CLI kubectl to manage clusters and applications. If you use kubectl to manage an ACK cluster, you must obtain the kubeconfig file of the cluster and use kubectl to connect to the cluster.
         *
         * @param request DescribeHubClusterKubeconfigRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeHubClusterKubeconfigResponse
         */
        public async Task<DescribeHubClusterKubeconfigResponse> DescribeHubClusterKubeconfigWithOptionsAsync(DescribeHubClusterKubeconfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PrivateIpAddress))
            {
                query["PrivateIpAddress"] = request.PrivateIpAddress;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeHubClusterKubeconfig",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeHubClusterKubeconfigResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the kubeconfig file of a Distributed Cloud Container Platform for Kubernetes (ACK One) cluster. In addition to the Container Service for Kubernetes (ACK) console, you can also use the Kubernetes CLI kubectl to manage clusters and applications. If you use kubectl to manage an ACK cluster, you must obtain the kubeconfig file of the cluster and use kubectl to connect to the cluster.
         *
         * @param request DescribeHubClusterKubeconfigRequest
         * @return DescribeHubClusterKubeconfigResponse
         */
        public DescribeHubClusterKubeconfigResponse DescribeHubClusterKubeconfig(DescribeHubClusterKubeconfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeHubClusterKubeconfigWithOptions(request, runtime);
        }

        /**
         * @summary Queries the kubeconfig file of a Distributed Cloud Container Platform for Kubernetes (ACK One) cluster. In addition to the Container Service for Kubernetes (ACK) console, you can also use the Kubernetes CLI kubectl to manage clusters and applications. If you use kubectl to manage an ACK cluster, you must obtain the kubeconfig file of the cluster and use kubectl to connect to the cluster.
         *
         * @param request DescribeHubClusterKubeconfigRequest
         * @return DescribeHubClusterKubeconfigResponse
         */
        public async Task<DescribeHubClusterKubeconfigResponse> DescribeHubClusterKubeconfigAsync(DescribeHubClusterKubeconfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeHubClusterKubeconfigWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the logs of the Fleet instance of a multi-cluster fleet of Distributed Cloud Container Platform for Kubernetes (ACK One).
         *
         * @param request DescribeHubClusterLogsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeHubClusterLogsResponse
         */
        public DescribeHubClusterLogsResponse DescribeHubClusterLogsWithOptions(DescribeHubClusterLogsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeHubClusterLogs",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeHubClusterLogsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the logs of the Fleet instance of a multi-cluster fleet of Distributed Cloud Container Platform for Kubernetes (ACK One).
         *
         * @param request DescribeHubClusterLogsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeHubClusterLogsResponse
         */
        public async Task<DescribeHubClusterLogsResponse> DescribeHubClusterLogsWithOptionsAsync(DescribeHubClusterLogsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeHubClusterLogs",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeHubClusterLogsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the logs of the Fleet instance of a multi-cluster fleet of Distributed Cloud Container Platform for Kubernetes (ACK One).
         *
         * @param request DescribeHubClusterLogsRequest
         * @return DescribeHubClusterLogsResponse
         */
        public DescribeHubClusterLogsResponse DescribeHubClusterLogs(DescribeHubClusterLogsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeHubClusterLogsWithOptions(request, runtime);
        }

        /**
         * @summary Queries the logs of the Fleet instance of a multi-cluster fleet of Distributed Cloud Container Platform for Kubernetes (ACK One).
         *
         * @param request DescribeHubClusterLogsRequest
         * @return DescribeHubClusterLogsResponse
         */
        public async Task<DescribeHubClusterLogsResponse> DescribeHubClusterLogsAsync(DescribeHubClusterLogsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeHubClusterLogsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the Distributed Cloud Container Platform for Kubernetes (ACK One) clusters that are created by the current user.
         *
         * @param tmpReq DescribeHubClustersRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeHubClustersResponse
         */
        public DescribeHubClustersResponse DescribeHubClustersWithOptions(DescribeHubClustersRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DescribeHubClustersShrinkRequest request = new DescribeHubClustersShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Tag))
            {
                request.TagShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Tag, "Tag", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Profile))
            {
                query["Profile"] = request.Profile;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagShrink))
            {
                query["Tag"] = request.TagShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeHubClusters",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeHubClustersResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the Distributed Cloud Container Platform for Kubernetes (ACK One) clusters that are created by the current user.
         *
         * @param tmpReq DescribeHubClustersRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeHubClustersResponse
         */
        public async Task<DescribeHubClustersResponse> DescribeHubClustersWithOptionsAsync(DescribeHubClustersRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DescribeHubClustersShrinkRequest request = new DescribeHubClustersShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Tag))
            {
                request.TagShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Tag, "Tag", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Profile))
            {
                query["Profile"] = request.Profile;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagShrink))
            {
                query["Tag"] = request.TagShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeHubClusters",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeHubClustersResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the Distributed Cloud Container Platform for Kubernetes (ACK One) clusters that are created by the current user.
         *
         * @param request DescribeHubClustersRequest
         * @return DescribeHubClustersResponse
         */
        public DescribeHubClustersResponse DescribeHubClusters(DescribeHubClustersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeHubClustersWithOptions(request, runtime);
        }

        /**
         * @summary Queries the Distributed Cloud Container Platform for Kubernetes (ACK One) clusters that are created by the current user.
         *
         * @param request DescribeHubClustersRequest
         * @return DescribeHubClustersResponse
         */
        public async Task<DescribeHubClustersResponse> DescribeHubClustersAsync(DescribeHubClustersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeHubClustersWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Alibaba Cloud CLI allows you to search for API operations, call and debug API operations online, and dynamically generate executable sample code for SDKs.
         *
         * @param request DescribeManagedClustersRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeManagedClustersResponse
         */
        public DescribeManagedClustersResponse DescribeManagedClustersWithOptions(DescribeManagedClustersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeManagedClusters",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeManagedClustersResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Alibaba Cloud CLI allows you to search for API operations, call and debug API operations online, and dynamically generate executable sample code for SDKs.
         *
         * @param request DescribeManagedClustersRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeManagedClustersResponse
         */
        public async Task<DescribeManagedClustersResponse> DescribeManagedClustersWithOptionsAsync(DescribeManagedClustersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeManagedClusters",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeManagedClustersResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Alibaba Cloud CLI allows you to search for API operations, call and debug API operations online, and dynamically generate executable sample code for SDKs.
         *
         * @param request DescribeManagedClustersRequest
         * @return DescribeManagedClustersResponse
         */
        public DescribeManagedClustersResponse DescribeManagedClusters(DescribeManagedClustersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeManagedClustersWithOptions(request, runtime);
        }

        /**
         * @summary Alibaba Cloud CLI allows you to search for API operations, call and debug API operations online, and dynamically generate executable sample code for SDKs.
         *
         * @param request DescribeManagedClustersRequest
         * @return DescribeManagedClustersResponse
         */
        public async Task<DescribeManagedClustersResponse> DescribeManagedClustersAsync(DescribeManagedClustersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeManagedClustersWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries a list of policies.
         *
         * @param request DescribePoliciesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribePoliciesResponse
         */
        public DescribePoliciesResponse DescribePoliciesWithOptions(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribePolicies",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribePoliciesResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries a list of policies.
         *
         * @param request DescribePoliciesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribePoliciesResponse
         */
        public async Task<DescribePoliciesResponse> DescribePoliciesWithOptionsAsync(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribePolicies",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribePoliciesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries a list of policies.
         *
         * @return DescribePoliciesResponse
         */
        public DescribePoliciesResponse DescribePolicies()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribePoliciesWithOptions(runtime);
        }

        /**
         * @summary Queries a list of policies.
         *
         * @return DescribePoliciesResponse
         */
        public async Task<DescribePoliciesResponse> DescribePoliciesAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribePoliciesWithOptionsAsync(runtime);
        }

        /**
         * @summary Queries detailed information about a policy.
         *
         * @param request DescribePolicyDetailsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribePolicyDetailsResponse
         */
        public DescribePolicyDetailsResponse DescribePolicyDetailsWithOptions(DescribePolicyDetailsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyName))
            {
                query["PolicyName"] = request.PolicyName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribePolicyDetails",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribePolicyDetailsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries detailed information about a policy.
         *
         * @param request DescribePolicyDetailsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribePolicyDetailsResponse
         */
        public async Task<DescribePolicyDetailsResponse> DescribePolicyDetailsWithOptionsAsync(DescribePolicyDetailsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyName))
            {
                query["PolicyName"] = request.PolicyName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribePolicyDetails",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribePolicyDetailsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries detailed information about a policy.
         *
         * @param request DescribePolicyDetailsRequest
         * @return DescribePolicyDetailsResponse
         */
        public DescribePolicyDetailsResponse DescribePolicyDetails(DescribePolicyDetailsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribePolicyDetailsWithOptions(request, runtime);
        }

        /**
         * @summary Queries detailed information about a policy.
         *
         * @param request DescribePolicyDetailsRequest
         * @return DescribePolicyDetailsResponse
         */
        public async Task<DescribePolicyDetailsResponse> DescribePolicyDetailsAsync(DescribePolicyDetailsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribePolicyDetailsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries detailed information about the policies used by the clusters that are associated with a master instance.
         *
         * @param request DescribePolicyGovernanceInClusterRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribePolicyGovernanceInClusterResponse
         */
        public DescribePolicyGovernanceInClusterResponse DescribePolicyGovernanceInClusterWithOptions(DescribePolicyGovernanceInClusterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribePolicyGovernanceInCluster",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribePolicyGovernanceInClusterResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries detailed information about the policies used by the clusters that are associated with a master instance.
         *
         * @param request DescribePolicyGovernanceInClusterRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribePolicyGovernanceInClusterResponse
         */
        public async Task<DescribePolicyGovernanceInClusterResponse> DescribePolicyGovernanceInClusterWithOptionsAsync(DescribePolicyGovernanceInClusterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribePolicyGovernanceInCluster",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribePolicyGovernanceInClusterResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries detailed information about the policies used by the clusters that are associated with a master instance.
         *
         * @param request DescribePolicyGovernanceInClusterRequest
         * @return DescribePolicyGovernanceInClusterResponse
         */
        public DescribePolicyGovernanceInClusterResponse DescribePolicyGovernanceInCluster(DescribePolicyGovernanceInClusterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribePolicyGovernanceInClusterWithOptions(request, runtime);
        }

        /**
         * @summary Queries detailed information about the policies used by the clusters that are associated with a master instance.
         *
         * @param request DescribePolicyGovernanceInClusterRequest
         * @return DescribePolicyGovernanceInClusterResponse
         */
        public async Task<DescribePolicyGovernanceInClusterResponse> DescribePolicyGovernanceInClusterAsync(DescribePolicyGovernanceInClusterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribePolicyGovernanceInClusterWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries policy instances that are deployed in the clusters associated with a master instance.
         *
         * @param request DescribePolicyInstancesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribePolicyInstancesResponse
         */
        public DescribePolicyInstancesResponse DescribePolicyInstancesWithOptions(DescribePolicyInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyName))
            {
                query["PolicyName"] = request.PolicyName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribePolicyInstances",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribePolicyInstancesResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries policy instances that are deployed in the clusters associated with a master instance.
         *
         * @param request DescribePolicyInstancesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribePolicyInstancesResponse
         */
        public async Task<DescribePolicyInstancesResponse> DescribePolicyInstancesWithOptionsAsync(DescribePolicyInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyName))
            {
                query["PolicyName"] = request.PolicyName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribePolicyInstances",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribePolicyInstancesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries policy instances that are deployed in the clusters associated with a master instance.
         *
         * @param request DescribePolicyInstancesRequest
         * @return DescribePolicyInstancesResponse
         */
        public DescribePolicyInstancesResponse DescribePolicyInstances(DescribePolicyInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribePolicyInstancesWithOptions(request, runtime);
        }

        /**
         * @summary Queries policy instances that are deployed in the clusters associated with a master instance.
         *
         * @param request DescribePolicyInstancesRequest
         * @return DescribePolicyInstancesResponse
         */
        public async Task<DescribePolicyInstancesResponse> DescribePolicyInstancesAsync(DescribePolicyInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribePolicyInstancesWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries detailed information about policy instances that are deployed in the clusters associated with a master instance.
         *
         * @param request DescribePolicyInstancesStatusRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribePolicyInstancesStatusResponse
         */
        public DescribePolicyInstancesStatusResponse DescribePolicyInstancesStatusWithOptions(DescribePolicyInstancesStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribePolicyInstancesStatus",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribePolicyInstancesStatusResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries detailed information about policy instances that are deployed in the clusters associated with a master instance.
         *
         * @param request DescribePolicyInstancesStatusRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribePolicyInstancesStatusResponse
         */
        public async Task<DescribePolicyInstancesStatusResponse> DescribePolicyInstancesStatusWithOptionsAsync(DescribePolicyInstancesStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribePolicyInstancesStatus",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribePolicyInstancesStatusResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries detailed information about policy instances that are deployed in the clusters associated with a master instance.
         *
         * @param request DescribePolicyInstancesStatusRequest
         * @return DescribePolicyInstancesStatusResponse
         */
        public DescribePolicyInstancesStatusResponse DescribePolicyInstancesStatus(DescribePolicyInstancesStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribePolicyInstancesStatusWithOptions(request, runtime);
        }

        /**
         * @summary Queries detailed information about policy instances that are deployed in the clusters associated with a master instance.
         *
         * @param request DescribePolicyInstancesStatusRequest
         * @return DescribePolicyInstancesStatusResponse
         */
        public async Task<DescribePolicyInstancesStatusResponse> DescribePolicyInstancesStatusAsync(DescribePolicyInstancesStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribePolicyInstancesStatusWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 查询地域列表
         *
         * @param request DescribeRegionsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeRegionsResponse
         */
        public DescribeRegionsResponse DescribeRegionsWithOptions(DescribeRegionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeRegions",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeRegionsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 查询地域列表
         *
         * @param request DescribeRegionsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeRegionsResponse
         */
        public async Task<DescribeRegionsResponse> DescribeRegionsWithOptionsAsync(DescribeRegionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeRegions",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeRegionsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 查询地域列表
         *
         * @param request DescribeRegionsRequest
         * @return DescribeRegionsResponse
         */
        public DescribeRegionsResponse DescribeRegions(DescribeRegionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeRegionsWithOptions(request, runtime);
        }

        /**
         * @summary 查询地域列表
         *
         * @param request DescribeRegionsRequest
         * @return DescribeRegionsResponse
         */
        public async Task<DescribeRegionsResponse> DescribeRegionsAsync(DescribeRegionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeRegionsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Query the permissions of a Resource Access Management (RAM) user.
         *
         * @param request DescribeUserPermissionsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeUserPermissionsResponse
         */
        public DescribeUserPermissionsResponse DescribeUserPermissionsWithOptions(DescribeUserPermissionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["UserId"] = request.UserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeUserPermissions",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeUserPermissionsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Query the permissions of a Resource Access Management (RAM) user.
         *
         * @param request DescribeUserPermissionsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeUserPermissionsResponse
         */
        public async Task<DescribeUserPermissionsResponse> DescribeUserPermissionsWithOptionsAsync(DescribeUserPermissionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["UserId"] = request.UserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeUserPermissions",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeUserPermissionsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Query the permissions of a Resource Access Management (RAM) user.
         *
         * @param request DescribeUserPermissionsRequest
         * @return DescribeUserPermissionsResponse
         */
        public DescribeUserPermissionsResponse DescribeUserPermissions(DescribeUserPermissionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeUserPermissionsWithOptions(request, runtime);
        }

        /**
         * @summary Query the permissions of a Resource Access Management (RAM) user.
         *
         * @param request DescribeUserPermissionsRequest
         * @return DescribeUserPermissionsResponse
         */
        public async Task<DescribeUserPermissionsResponse> DescribeUserPermissionsAsync(DescribeUserPermissionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeUserPermissionsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Alibaba Cloud CLI allows you to search for API operations, call and debug API operations online, and dynamically generate executable sample code for SDKs.
         *
         * @param request DetachClusterFromHubRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DetachClusterFromHubResponse
         */
        public DetachClusterFromHubResponse DetachClusterFromHubWithOptions(DetachClusterFromHubRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DetachFromMesh))
            {
                query["DetachFromMesh"] = request.DetachFromMesh;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterIds))
            {
                body["ClusterIds"] = request.ClusterIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DetachClusterFromHub",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DetachClusterFromHubResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Alibaba Cloud CLI allows you to search for API operations, call and debug API operations online, and dynamically generate executable sample code for SDKs.
         *
         * @param request DetachClusterFromHubRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DetachClusterFromHubResponse
         */
        public async Task<DetachClusterFromHubResponse> DetachClusterFromHubWithOptionsAsync(DetachClusterFromHubRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DetachFromMesh))
            {
                query["DetachFromMesh"] = request.DetachFromMesh;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterIds))
            {
                body["ClusterIds"] = request.ClusterIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DetachClusterFromHub",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DetachClusterFromHubResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Alibaba Cloud CLI allows you to search for API operations, call and debug API operations online, and dynamically generate executable sample code for SDKs.
         *
         * @param request DetachClusterFromHubRequest
         * @return DetachClusterFromHubResponse
         */
        public DetachClusterFromHubResponse DetachClusterFromHub(DetachClusterFromHubRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DetachClusterFromHubWithOptions(request, runtime);
        }

        /**
         * @summary Alibaba Cloud CLI allows you to search for API operations, call and debug API operations online, and dynamically generate executable sample code for SDKs.
         *
         * @param request DetachClusterFromHubRequest
         * @return DetachClusterFromHubResponse
         */
        public async Task<DetachClusterFromHubResponse> DetachClusterFromHubAsync(DetachClusterFromHubRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DetachClusterFromHubWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Grants role-based access control (RBAC) permissions to Resource Access Management (RAM) users or RAM roles. System policies can be attached to RAM users to grant only the operation permissions on Distributed Cloud Container Platform for Kubernetes (ACK One) cluster resources. The operation permissions include creating and viewing instances. If you want to perform operations on Kubernetes resources in a specific cluster by using a RAM user or assuming a RAM role, such as creating GitOps applications and Argo workflows, you must grant RBAC permissions to the RAM user or RAM role to perform operations on the specified ACK One cluster and namespace. This topic describes how to grant RBAC permissions to a RAM user or RAM role.
         *
         * @description *   To call this API operation to grant permissions to a RAM user or RAM role on a specific cluster, you must use an Alibaba Cloud account, the account that is used to create the cluster, or a RAM user that has the cluster administrator permissions. A regular RAM user does not have the permissions to call this operation.
         * *   Before you grant RBAC permissions to a RAM user or RAM role on a cluster, you must grant the operation permissions to the RAM user or RAM role on the specified cluster. For more information, see [Attach a system permission policy to a RAM user or RAM role](https://help.aliyun.com/document_detail/613486.html).
         * For more information, see [Authorization overview](https://help.aliyun.com/document_detail/613468.html).
         *
         * @param request GrantUserPermissionRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GrantUserPermissionResponse
         */
        public GrantUserPermissionResponse GrantUserPermissionWithOptions(GrantUserPermissionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsRamRole))
            {
                query["IsRamRole"] = request.IsRamRole;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                query["Namespace"] = request.Namespace;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleName))
            {
                query["RoleName"] = request.RoleName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleType))
            {
                query["RoleType"] = request.RoleType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["UserId"] = request.UserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GrantUserPermission",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GrantUserPermissionResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Grants role-based access control (RBAC) permissions to Resource Access Management (RAM) users or RAM roles. System policies can be attached to RAM users to grant only the operation permissions on Distributed Cloud Container Platform for Kubernetes (ACK One) cluster resources. The operation permissions include creating and viewing instances. If you want to perform operations on Kubernetes resources in a specific cluster by using a RAM user or assuming a RAM role, such as creating GitOps applications and Argo workflows, you must grant RBAC permissions to the RAM user or RAM role to perform operations on the specified ACK One cluster and namespace. This topic describes how to grant RBAC permissions to a RAM user or RAM role.
         *
         * @description *   To call this API operation to grant permissions to a RAM user or RAM role on a specific cluster, you must use an Alibaba Cloud account, the account that is used to create the cluster, or a RAM user that has the cluster administrator permissions. A regular RAM user does not have the permissions to call this operation.
         * *   Before you grant RBAC permissions to a RAM user or RAM role on a cluster, you must grant the operation permissions to the RAM user or RAM role on the specified cluster. For more information, see [Attach a system permission policy to a RAM user or RAM role](https://help.aliyun.com/document_detail/613486.html).
         * For more information, see [Authorization overview](https://help.aliyun.com/document_detail/613468.html).
         *
         * @param request GrantUserPermissionRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GrantUserPermissionResponse
         */
        public async Task<GrantUserPermissionResponse> GrantUserPermissionWithOptionsAsync(GrantUserPermissionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsRamRole))
            {
                query["IsRamRole"] = request.IsRamRole;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                query["Namespace"] = request.Namespace;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleName))
            {
                query["RoleName"] = request.RoleName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleType))
            {
                query["RoleType"] = request.RoleType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["UserId"] = request.UserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GrantUserPermission",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GrantUserPermissionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Grants role-based access control (RBAC) permissions to Resource Access Management (RAM) users or RAM roles. System policies can be attached to RAM users to grant only the operation permissions on Distributed Cloud Container Platform for Kubernetes (ACK One) cluster resources. The operation permissions include creating and viewing instances. If you want to perform operations on Kubernetes resources in a specific cluster by using a RAM user or assuming a RAM role, such as creating GitOps applications and Argo workflows, you must grant RBAC permissions to the RAM user or RAM role to perform operations on the specified ACK One cluster and namespace. This topic describes how to grant RBAC permissions to a RAM user or RAM role.
         *
         * @description *   To call this API operation to grant permissions to a RAM user or RAM role on a specific cluster, you must use an Alibaba Cloud account, the account that is used to create the cluster, or a RAM user that has the cluster administrator permissions. A regular RAM user does not have the permissions to call this operation.
         * *   Before you grant RBAC permissions to a RAM user or RAM role on a cluster, you must grant the operation permissions to the RAM user or RAM role on the specified cluster. For more information, see [Attach a system permission policy to a RAM user or RAM role](https://help.aliyun.com/document_detail/613486.html).
         * For more information, see [Authorization overview](https://help.aliyun.com/document_detail/613468.html).
         *
         * @param request GrantUserPermissionRequest
         * @return GrantUserPermissionResponse
         */
        public GrantUserPermissionResponse GrantUserPermission(GrantUserPermissionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GrantUserPermissionWithOptions(request, runtime);
        }

        /**
         * @summary Grants role-based access control (RBAC) permissions to Resource Access Management (RAM) users or RAM roles. System policies can be attached to RAM users to grant only the operation permissions on Distributed Cloud Container Platform for Kubernetes (ACK One) cluster resources. The operation permissions include creating and viewing instances. If you want to perform operations on Kubernetes resources in a specific cluster by using a RAM user or assuming a RAM role, such as creating GitOps applications and Argo workflows, you must grant RBAC permissions to the RAM user or RAM role to perform operations on the specified ACK One cluster and namespace. This topic describes how to grant RBAC permissions to a RAM user or RAM role.
         *
         * @description *   To call this API operation to grant permissions to a RAM user or RAM role on a specific cluster, you must use an Alibaba Cloud account, the account that is used to create the cluster, or a RAM user that has the cluster administrator permissions. A regular RAM user does not have the permissions to call this operation.
         * *   Before you grant RBAC permissions to a RAM user or RAM role on a cluster, you must grant the operation permissions to the RAM user or RAM role on the specified cluster. For more information, see [Attach a system permission policy to a RAM user or RAM role](https://help.aliyun.com/document_detail/613486.html).
         * For more information, see [Authorization overview](https://help.aliyun.com/document_detail/613468.html).
         *
         * @param request GrantUserPermissionRequest
         * @return GrantUserPermissionResponse
         */
        public async Task<GrantUserPermissionResponse> GrantUserPermissionAsync(GrantUserPermissionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GrantUserPermissionWithOptionsAsync(request, runtime);
        }

        /**
         * @deprecated OpenAPI GrantUserPermissions is deprecated, please use adcp::2022-01-01::GrantUserPermission instead.
         *
         * @summary Grant permissions to a Resource Access Management (RAM) user.
         *
         * @param tmpReq GrantUserPermissionsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GrantUserPermissionsResponse
         */
        // Deprecated
        public GrantUserPermissionsResponse GrantUserPermissionsWithOptions(GrantUserPermissionsRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GrantUserPermissionsShrinkRequest request = new GrantUserPermissionsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Permissions))
            {
                request.PermissionsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Permissions, "Permissions", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PermissionsShrink))
            {
                query["Permissions"] = request.PermissionsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["UserId"] = request.UserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GrantUserPermissions",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GrantUserPermissionsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @deprecated OpenAPI GrantUserPermissions is deprecated, please use adcp::2022-01-01::GrantUserPermission instead.
         *
         * @summary Grant permissions to a Resource Access Management (RAM) user.
         *
         * @param tmpReq GrantUserPermissionsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GrantUserPermissionsResponse
         */
        // Deprecated
        public async Task<GrantUserPermissionsResponse> GrantUserPermissionsWithOptionsAsync(GrantUserPermissionsRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GrantUserPermissionsShrinkRequest request = new GrantUserPermissionsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Permissions))
            {
                request.PermissionsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Permissions, "Permissions", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PermissionsShrink))
            {
                query["Permissions"] = request.PermissionsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["UserId"] = request.UserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GrantUserPermissions",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GrantUserPermissionsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @deprecated OpenAPI GrantUserPermissions is deprecated, please use adcp::2022-01-01::GrantUserPermission instead.
         *
         * @summary Grant permissions to a Resource Access Management (RAM) user.
         *
         * @param request GrantUserPermissionsRequest
         * @return GrantUserPermissionsResponse
         */
        // Deprecated
        public GrantUserPermissionsResponse GrantUserPermissions(GrantUserPermissionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GrantUserPermissionsWithOptions(request, runtime);
        }

        /**
         * @deprecated OpenAPI GrantUserPermissions is deprecated, please use adcp::2022-01-01::GrantUserPermission instead.
         *
         * @summary Grant permissions to a Resource Access Management (RAM) user.
         *
         * @param request GrantUserPermissionsRequest
         * @return GrantUserPermissionsResponse
         */
        // Deprecated
        public async Task<GrantUserPermissionsResponse> GrantUserPermissionsAsync(GrantUserPermissionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GrantUserPermissionsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Updates the configurations of a Container Service for Kubernetes (ACK) cluster that serves as a master instance.
         *
         * @param tmpReq UpdateHubClusterFeatureRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateHubClusterFeatureResponse
         */
        public UpdateHubClusterFeatureResponse UpdateHubClusterFeatureWithOptions(UpdateHubClusterFeatureRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateHubClusterFeatureShrinkRequest request = new UpdateHubClusterFeatureShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.AccessControlList))
            {
                request.AccessControlListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.AccessControlList, "AccessControlList", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.VSwitches))
            {
                request.VSwitchesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.VSwitches, "VSwitches", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessControlListShrink))
            {
                query["AccessControlList"] = request.AccessControlListShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApiServerEipId))
            {
                query["ApiServerEipId"] = request.ApiServerEipId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ArgoCDEnabled))
            {
                query["ArgoCDEnabled"] = request.ArgoCDEnabled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ArgoCDHAEnabled))
            {
                query["ArgoCDHAEnabled"] = request.ArgoCDHAEnabled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ArgoEventsEnabled))
            {
                query["ArgoEventsEnabled"] = request.ArgoEventsEnabled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ArgoServerEnabled))
            {
                query["ArgoServerEnabled"] = request.ArgoServerEnabled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuditLogEnabled))
            {
                query["AuditLogEnabled"] = request.AuditLogEnabled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeletionProtection))
            {
                query["DeletionProtection"] = request.DeletionProtection;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableMesh))
            {
                query["EnableMesh"] = request.EnableMesh;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GatewayEnabled))
            {
                query["GatewayEnabled"] = request.GatewayEnabled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MonitorEnabled))
            {
                query["MonitorEnabled"] = request.MonitorEnabled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PriceLimit))
            {
                query["PriceLimit"] = request.PriceLimit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PublicAccessEnabled))
            {
                query["PublicAccessEnabled"] = request.PublicAccessEnabled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PublicApiServerEnabled))
            {
                query["PublicApiServerEnabled"] = request.PublicApiServerEnabled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VSwitchesShrink))
            {
                query["VSwitches"] = request.VSwitchesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkflowScheduleMode))
            {
                query["WorkflowScheduleMode"] = request.WorkflowScheduleMode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateHubClusterFeature",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateHubClusterFeatureResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Updates the configurations of a Container Service for Kubernetes (ACK) cluster that serves as a master instance.
         *
         * @param tmpReq UpdateHubClusterFeatureRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateHubClusterFeatureResponse
         */
        public async Task<UpdateHubClusterFeatureResponse> UpdateHubClusterFeatureWithOptionsAsync(UpdateHubClusterFeatureRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateHubClusterFeatureShrinkRequest request = new UpdateHubClusterFeatureShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.AccessControlList))
            {
                request.AccessControlListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.AccessControlList, "AccessControlList", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.VSwitches))
            {
                request.VSwitchesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.VSwitches, "VSwitches", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessControlListShrink))
            {
                query["AccessControlList"] = request.AccessControlListShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApiServerEipId))
            {
                query["ApiServerEipId"] = request.ApiServerEipId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ArgoCDEnabled))
            {
                query["ArgoCDEnabled"] = request.ArgoCDEnabled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ArgoCDHAEnabled))
            {
                query["ArgoCDHAEnabled"] = request.ArgoCDHAEnabled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ArgoEventsEnabled))
            {
                query["ArgoEventsEnabled"] = request.ArgoEventsEnabled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ArgoServerEnabled))
            {
                query["ArgoServerEnabled"] = request.ArgoServerEnabled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuditLogEnabled))
            {
                query["AuditLogEnabled"] = request.AuditLogEnabled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeletionProtection))
            {
                query["DeletionProtection"] = request.DeletionProtection;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableMesh))
            {
                query["EnableMesh"] = request.EnableMesh;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GatewayEnabled))
            {
                query["GatewayEnabled"] = request.GatewayEnabled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MonitorEnabled))
            {
                query["MonitorEnabled"] = request.MonitorEnabled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PriceLimit))
            {
                query["PriceLimit"] = request.PriceLimit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PublicAccessEnabled))
            {
                query["PublicAccessEnabled"] = request.PublicAccessEnabled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PublicApiServerEnabled))
            {
                query["PublicApiServerEnabled"] = request.PublicApiServerEnabled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VSwitchesShrink))
            {
                query["VSwitches"] = request.VSwitchesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkflowScheduleMode))
            {
                query["WorkflowScheduleMode"] = request.WorkflowScheduleMode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateHubClusterFeature",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateHubClusterFeatureResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Updates the configurations of a Container Service for Kubernetes (ACK) cluster that serves as a master instance.
         *
         * @param request UpdateHubClusterFeatureRequest
         * @return UpdateHubClusterFeatureResponse
         */
        public UpdateHubClusterFeatureResponse UpdateHubClusterFeature(UpdateHubClusterFeatureRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateHubClusterFeatureWithOptions(request, runtime);
        }

        /**
         * @summary Updates the configurations of a Container Service for Kubernetes (ACK) cluster that serves as a master instance.
         *
         * @param request UpdateHubClusterFeatureRequest
         * @return UpdateHubClusterFeatureResponse
         */
        public async Task<UpdateHubClusterFeatureResponse> UpdateHubClusterFeatureAsync(UpdateHubClusterFeatureRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateHubClusterFeatureWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Updates the role-based access control (RBAC) permissions of a RAM user.
         *
         * @param request UpdateUserPermissionRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateUserPermissionResponse
         */
        public UpdateUserPermissionResponse UpdateUserPermissionWithOptions(UpdateUserPermissionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                query["Namespace"] = request.Namespace;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleName))
            {
                query["RoleName"] = request.RoleName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleType))
            {
                query["RoleType"] = request.RoleType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["UserId"] = request.UserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateUserPermission",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateUserPermissionResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Updates the role-based access control (RBAC) permissions of a RAM user.
         *
         * @param request UpdateUserPermissionRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateUserPermissionResponse
         */
        public async Task<UpdateUserPermissionResponse> UpdateUserPermissionWithOptionsAsync(UpdateUserPermissionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                query["Namespace"] = request.Namespace;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleName))
            {
                query["RoleName"] = request.RoleName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RoleType))
            {
                query["RoleType"] = request.RoleType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["UserId"] = request.UserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateUserPermission",
                Version = "2022-01-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateUserPermissionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Updates the role-based access control (RBAC) permissions of a RAM user.
         *
         * @param request UpdateUserPermissionRequest
         * @return UpdateUserPermissionResponse
         */
        public UpdateUserPermissionResponse UpdateUserPermission(UpdateUserPermissionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateUserPermissionWithOptions(request, runtime);
        }

        /**
         * @summary Updates the role-based access control (RBAC) permissions of a RAM user.
         *
         * @param request UpdateUserPermissionRequest
         * @return UpdateUserPermissionResponse
         */
        public async Task<UpdateUserPermissionResponse> UpdateUserPermissionAsync(UpdateUserPermissionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateUserPermissionWithOptionsAsync(request, runtime);
        }

    }
}
