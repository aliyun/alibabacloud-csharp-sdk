// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Emr20210320.Models;

namespace AlibabaCloud.SDK.Emr20210320
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "regional";
            this._endpointMap = new Dictionary<string, string>
            {
                {"cn-beijing", "emr.aliyuncs.com"},
                {"cn-hangzhou", "emr.aliyuncs.com"},
                {"cn-shanghai", "emr.aliyuncs.com"},
                {"cn-shenzhen", "emr.aliyuncs.com"},
                {"ap-southeast-1", "emr.aliyuncs.com"},
                {"us-west-1", "emr.aliyuncs.com"},
                {"cn-shanghai-finance-1", "emr.aliyuncs.com"},
                {"cn-shenzhen-finance-1", "emr.aliyuncs.com"},
                {"cn-north-2-gov-1", "emr.aliyuncs.com"},
                {"ap-northeast-2-pop", "emr.aliyuncs.com"},
                {"cn-beijing-finance-1", "emr.aliyuncs.com"},
                {"cn-beijing-finance-pop", "emr.aliyuncs.com"},
                {"cn-beijing-gov-1", "emr.aliyuncs.com"},
                {"cn-beijing-nu16-b01", "emr.aliyuncs.com"},
                {"cn-edge-1", "emr.aliyuncs.com"},
                {"cn-fujian", "emr.aliyuncs.com"},
                {"cn-haidian-cm12-c01", "emr.aliyuncs.com"},
                {"cn-hangzhou-bj-b01", "emr.aliyuncs.com"},
                {"cn-hangzhou-finance", "emr.aliyuncs.com"},
                {"cn-hangzhou-internal-prod-1", "emr.aliyuncs.com"},
                {"cn-hangzhou-internal-test-1", "emr.aliyuncs.com"},
                {"cn-hangzhou-internal-test-2", "emr.aliyuncs.com"},
                {"cn-hangzhou-internal-test-3", "emr.aliyuncs.com"},
                {"cn-hangzhou-test-306", "emr.aliyuncs.com"},
                {"cn-hongkong-finance-pop", "emr.aliyuncs.com"},
                {"cn-huhehaote-nebula-1", "emr.aliyuncs.com"},
                {"cn-qingdao-nebula", "emr.aliyuncs.com"},
                {"cn-shanghai-et15-b01", "emr.aliyuncs.com"},
                {"cn-shanghai-et2-b01", "emr.aliyuncs.com"},
                {"cn-shanghai-inner", "emr.aliyuncs.com"},
                {"cn-shanghai-internal-test-1", "emr.aliyuncs.com"},
                {"cn-shenzhen-inner", "emr.aliyuncs.com"},
                {"cn-shenzhen-st4-d01", "emr.aliyuncs.com"},
                {"cn-shenzhen-su18-b01", "emr.aliyuncs.com"},
                {"cn-wuhan", "emr.aliyuncs.com"},
                {"cn-yushanfang", "emr.aliyuncs.com"},
                {"cn-zhangbei", "emr.aliyuncs.com"},
                {"cn-zhangbei-na61-b01", "emr.aliyuncs.com"},
                {"cn-zhangjiakou-na62-a01", "emr.aliyuncs.com"},
                {"cn-zhengzhou-nebula-1", "emr.aliyuncs.com"},
                {"eu-west-1-oxs", "emr.aliyuncs.com"},
                {"rus-west-1-pop", "emr.aliyuncs.com"},
            };
            CheckConfig(config);
            this._endpoint = GetEndpoint("emr", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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
         * @param request CreateApiTemplateRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateApiTemplateResponse
         */
        public CreateApiTemplateResponse CreateApiTemplateWithOptions(CreateApiTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApiName))
            {
                query["ApiName"] = request.ApiName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Content))
            {
                query["Content"] = request.Content;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateName))
            {
                query["TemplateName"] = request.TemplateName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateApiTemplate",
                Version = "2021-03-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateApiTemplateResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request CreateApiTemplateRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateApiTemplateResponse
         */
        public async Task<CreateApiTemplateResponse> CreateApiTemplateWithOptionsAsync(CreateApiTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApiName))
            {
                query["ApiName"] = request.ApiName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Content))
            {
                query["Content"] = request.Content;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateName))
            {
                query["TemplateName"] = request.TemplateName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateApiTemplate",
                Version = "2021-03-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateApiTemplateResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request CreateApiTemplateRequest
         * @return CreateApiTemplateResponse
         */
        public CreateApiTemplateResponse CreateApiTemplate(CreateApiTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateApiTemplateWithOptions(request, runtime);
        }

        /**
         * @param request CreateApiTemplateRequest
         * @return CreateApiTemplateResponse
         */
        public async Task<CreateApiTemplateResponse> CreateApiTemplateAsync(CreateApiTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateApiTemplateWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Creates a pay-as-you-go or subscription cluster.
         *
         * @param request CreateClusterRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateClusterResponse
         */
        public CreateClusterResponse CreateClusterWithOptions(CreateClusterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplicationConfigs))
            {
                query["ApplicationConfigs"] = request.ApplicationConfigs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Applications))
            {
                query["Applications"] = request.Applications;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BootstrapScripts))
            {
                query["BootstrapScripts"] = request.BootstrapScripts;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterName))
            {
                query["ClusterName"] = request.ClusterName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterType))
            {
                query["ClusterType"] = request.ClusterType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeployMode))
            {
                query["DeployMode"] = request.DeployMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeAttributes))
            {
                query["NodeAttributes"] = request.NodeAttributes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeGroups))
            {
                query["NodeGroups"] = request.NodeGroups;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PaymentType))
            {
                query["PaymentType"] = request.PaymentType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReleaseVersion))
            {
                query["ReleaseVersion"] = request.ReleaseVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityMode))
            {
                query["SecurityMode"] = request.SecurityMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubscriptionConfig))
            {
                query["SubscriptionConfig"] = request.SubscriptionConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tags))
            {
                query["Tags"] = request.Tags;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateCluster",
                Version = "2021-03-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateClusterResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Creates a pay-as-you-go or subscription cluster.
         *
         * @param request CreateClusterRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateClusterResponse
         */
        public async Task<CreateClusterResponse> CreateClusterWithOptionsAsync(CreateClusterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplicationConfigs))
            {
                query["ApplicationConfigs"] = request.ApplicationConfigs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Applications))
            {
                query["Applications"] = request.Applications;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BootstrapScripts))
            {
                query["BootstrapScripts"] = request.BootstrapScripts;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterName))
            {
                query["ClusterName"] = request.ClusterName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterType))
            {
                query["ClusterType"] = request.ClusterType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeployMode))
            {
                query["DeployMode"] = request.DeployMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeAttributes))
            {
                query["NodeAttributes"] = request.NodeAttributes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeGroups))
            {
                query["NodeGroups"] = request.NodeGroups;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PaymentType))
            {
                query["PaymentType"] = request.PaymentType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReleaseVersion))
            {
                query["ReleaseVersion"] = request.ReleaseVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityMode))
            {
                query["SecurityMode"] = request.SecurityMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubscriptionConfig))
            {
                query["SubscriptionConfig"] = request.SubscriptionConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tags))
            {
                query["Tags"] = request.Tags;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateCluster",
                Version = "2021-03-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateClusterResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Creates a pay-as-you-go or subscription cluster.
         *
         * @param request CreateClusterRequest
         * @return CreateClusterResponse
         */
        public CreateClusterResponse CreateCluster(CreateClusterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateClusterWithOptions(request, runtime);
        }

        /**
         * @summary Creates a pay-as-you-go or subscription cluster.
         *
         * @param request CreateClusterRequest
         * @return CreateClusterResponse
         */
        public async Task<CreateClusterResponse> CreateClusterAsync(CreateClusterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateClusterWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Creates a node group.
         *
         * @description 创建节点组。
         *
         * @param request CreateNodeGroupRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateNodeGroupResponse
         */
        public CreateNodeGroupResponse CreateNodeGroupWithOptions(CreateNodeGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeGroup))
            {
                query["NodeGroup"] = request.NodeGroup;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateNodeGroup",
                Version = "2021-03-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateNodeGroupResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Creates a node group.
         *
         * @description 创建节点组。
         *
         * @param request CreateNodeGroupRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateNodeGroupResponse
         */
        public async Task<CreateNodeGroupResponse> CreateNodeGroupWithOptionsAsync(CreateNodeGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeGroup))
            {
                query["NodeGroup"] = request.NodeGroup;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateNodeGroup",
                Version = "2021-03-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateNodeGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Creates a node group.
         *
         * @description 创建节点组。
         *
         * @param request CreateNodeGroupRequest
         * @return CreateNodeGroupResponse
         */
        public CreateNodeGroupResponse CreateNodeGroup(CreateNodeGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateNodeGroupWithOptions(request, runtime);
        }

        /**
         * @summary Creates a node group.
         *
         * @description 创建节点组。
         *
         * @param request CreateNodeGroupRequest
         * @return CreateNodeGroupResponse
         */
        public async Task<CreateNodeGroupResponse> CreateNodeGroupAsync(CreateNodeGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateNodeGroupWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Perform a scale-out operation on the target node group.
         *
         * @description 缩容节点。
         *
         * @param request DecreaseNodesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DecreaseNodesResponse
         */
        public DecreaseNodesResponse DecreaseNodesWithOptions(DecreaseNodesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DecreaseNodeCount))
            {
                query["DecreaseNodeCount"] = request.DecreaseNodeCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeGroupId))
            {
                query["NodeGroupId"] = request.NodeGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeIds))
            {
                query["NodeIds"] = request.NodeIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DecreaseNodes",
                Version = "2021-03-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DecreaseNodesResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Perform a scale-out operation on the target node group.
         *
         * @description 缩容节点。
         *
         * @param request DecreaseNodesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DecreaseNodesResponse
         */
        public async Task<DecreaseNodesResponse> DecreaseNodesWithOptionsAsync(DecreaseNodesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DecreaseNodeCount))
            {
                query["DecreaseNodeCount"] = request.DecreaseNodeCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeGroupId))
            {
                query["NodeGroupId"] = request.NodeGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeIds))
            {
                query["NodeIds"] = request.NodeIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DecreaseNodes",
                Version = "2021-03-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DecreaseNodesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Perform a scale-out operation on the target node group.
         *
         * @description 缩容节点。
         *
         * @param request DecreaseNodesRequest
         * @return DecreaseNodesResponse
         */
        public DecreaseNodesResponse DecreaseNodes(DecreaseNodesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DecreaseNodesWithOptions(request, runtime);
        }

        /**
         * @summary Perform a scale-out operation on the target node group.
         *
         * @description 缩容节点。
         *
         * @param request DecreaseNodesRequest
         * @return DecreaseNodesResponse
         */
        public async Task<DecreaseNodesResponse> DecreaseNodesAsync(DecreaseNodesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DecreaseNodesWithOptionsAsync(request, runtime);
        }

        /**
         * @description 创建集群模板
         *
         * @param request DeleteApiTemplateRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteApiTemplateResponse
         */
        public DeleteApiTemplateResponse DeleteApiTemplateWithOptions(DeleteApiTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApiName))
            {
                query["ApiName"] = request.ApiName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateId))
            {
                query["TemplateId"] = request.TemplateId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteApiTemplate",
                Version = "2021-03-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteApiTemplateResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @description 创建集群模板
         *
         * @param request DeleteApiTemplateRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteApiTemplateResponse
         */
        public async Task<DeleteApiTemplateResponse> DeleteApiTemplateWithOptionsAsync(DeleteApiTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApiName))
            {
                query["ApiName"] = request.ApiName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateId))
            {
                query["TemplateId"] = request.TemplateId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteApiTemplate",
                Version = "2021-03-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteApiTemplateResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @description 创建集群模板
         *
         * @param request DeleteApiTemplateRequest
         * @return DeleteApiTemplateResponse
         */
        public DeleteApiTemplateResponse DeleteApiTemplate(DeleteApiTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteApiTemplateWithOptions(request, runtime);
        }

        /**
         * @description 创建集群模板
         *
         * @param request DeleteApiTemplateRequest
         * @return DeleteApiTemplateResponse
         */
        public async Task<DeleteApiTemplateResponse> DeleteApiTemplateAsync(DeleteApiTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteApiTemplateWithOptionsAsync(request, runtime);
        }

        /**
         * @param request DeleteClusterRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteClusterResponse
         */
        public DeleteClusterResponse DeleteClusterWithOptions(DeleteClusterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteCluster",
                Version = "2021-03-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteClusterResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request DeleteClusterRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteClusterResponse
         */
        public async Task<DeleteClusterResponse> DeleteClusterWithOptionsAsync(DeleteClusterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteCluster",
                Version = "2021-03-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteClusterResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request DeleteClusterRequest
         * @return DeleteClusterResponse
         */
        public DeleteClusterResponse DeleteCluster(DeleteClusterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteClusterWithOptions(request, runtime);
        }

        /**
         * @param request DeleteClusterRequest
         * @return DeleteClusterResponse
         */
        public async Task<DeleteClusterResponse> DeleteClusterAsync(DeleteClusterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteClusterWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 获取API模板详情
         *
         * @param request GetApiTemplateRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetApiTemplateResponse
         */
        public GetApiTemplateResponse GetApiTemplateWithOptions(GetApiTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateId))
            {
                query["TemplateId"] = request.TemplateId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetApiTemplate",
                Version = "2021-03-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetApiTemplateResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 获取API模板详情
         *
         * @param request GetApiTemplateRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetApiTemplateResponse
         */
        public async Task<GetApiTemplateResponse> GetApiTemplateWithOptionsAsync(GetApiTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateId))
            {
                query["TemplateId"] = request.TemplateId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetApiTemplate",
                Version = "2021-03-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetApiTemplateResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 获取API模板详情
         *
         * @param request GetApiTemplateRequest
         * @return GetApiTemplateResponse
         */
        public GetApiTemplateResponse GetApiTemplate(GetApiTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetApiTemplateWithOptions(request, runtime);
        }

        /**
         * @summary 获取API模板详情
         *
         * @param request GetApiTemplateRequest
         * @return GetApiTemplateResponse
         */
        public async Task<GetApiTemplateResponse> GetApiTemplateAsync(GetApiTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetApiTemplateWithOptionsAsync(request, runtime);
        }

        /**
         * @description 查询应用详情。
         *
         * @param request GetApplicationRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetApplicationResponse
         */
        public GetApplicationResponse GetApplicationWithOptions(GetApplicationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplicationName))
            {
                query["ApplicationName"] = request.ApplicationName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetApplication",
                Version = "2021-03-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetApplicationResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @description 查询应用详情。
         *
         * @param request GetApplicationRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetApplicationResponse
         */
        public async Task<GetApplicationResponse> GetApplicationWithOptionsAsync(GetApplicationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplicationName))
            {
                query["ApplicationName"] = request.ApplicationName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetApplication",
                Version = "2021-03-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetApplicationResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @description 查询应用详情。
         *
         * @param request GetApplicationRequest
         * @return GetApplicationResponse
         */
        public GetApplicationResponse GetApplication(GetApplicationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetApplicationWithOptions(request, runtime);
        }

        /**
         * @description 查询应用详情。
         *
         * @param request GetApplicationRequest
         * @return GetApplicationResponse
         */
        public async Task<GetApplicationResponse> GetApplicationAsync(GetApplicationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetApplicationWithOptionsAsync(request, runtime);
        }

        /**
         * @description 获取弹性伸缩活动详情。
         *
         * @param request GetAutoScalingActivityRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetAutoScalingActivityResponse
         */
        public GetAutoScalingActivityResponse GetAutoScalingActivityWithOptions(GetAutoScalingActivityRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScalingActivityId))
            {
                query["ScalingActivityId"] = request.ScalingActivityId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAutoScalingActivity",
                Version = "2021-03-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAutoScalingActivityResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @description 获取弹性伸缩活动详情。
         *
         * @param request GetAutoScalingActivityRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetAutoScalingActivityResponse
         */
        public async Task<GetAutoScalingActivityResponse> GetAutoScalingActivityWithOptionsAsync(GetAutoScalingActivityRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScalingActivityId))
            {
                query["ScalingActivityId"] = request.ScalingActivityId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAutoScalingActivity",
                Version = "2021-03-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAutoScalingActivityResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @description 获取弹性伸缩活动详情。
         *
         * @param request GetAutoScalingActivityRequest
         * @return GetAutoScalingActivityResponse
         */
        public GetAutoScalingActivityResponse GetAutoScalingActivity(GetAutoScalingActivityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetAutoScalingActivityWithOptions(request, runtime);
        }

        /**
         * @description 获取弹性伸缩活动详情。
         *
         * @param request GetAutoScalingActivityRequest
         * @return GetAutoScalingActivityResponse
         */
        public async Task<GetAutoScalingActivityResponse> GetAutoScalingActivityAsync(GetAutoScalingActivityRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetAutoScalingActivityWithOptionsAsync(request, runtime);
        }

        /**
         * @param request GetAutoScalingPolicyRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetAutoScalingPolicyResponse
         */
        public GetAutoScalingPolicyResponse GetAutoScalingPolicyWithOptions(GetAutoScalingPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeGroupId))
            {
                query["NodeGroupId"] = request.NodeGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAutoScalingPolicy",
                Version = "2021-03-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAutoScalingPolicyResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request GetAutoScalingPolicyRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetAutoScalingPolicyResponse
         */
        public async Task<GetAutoScalingPolicyResponse> GetAutoScalingPolicyWithOptionsAsync(GetAutoScalingPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeGroupId))
            {
                query["NodeGroupId"] = request.NodeGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAutoScalingPolicy",
                Version = "2021-03-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAutoScalingPolicyResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request GetAutoScalingPolicyRequest
         * @return GetAutoScalingPolicyResponse
         */
        public GetAutoScalingPolicyResponse GetAutoScalingPolicy(GetAutoScalingPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetAutoScalingPolicyWithOptions(request, runtime);
        }

        /**
         * @param request GetAutoScalingPolicyRequest
         * @return GetAutoScalingPolicyResponse
         */
        public async Task<GetAutoScalingPolicyResponse> GetAutoScalingPolicyAsync(GetAutoScalingPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetAutoScalingPolicyWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Obtains the details of a cluster.
         *
         * @param request GetClusterRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetClusterResponse
         */
        public GetClusterResponse GetClusterWithOptions(GetClusterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetCluster",
                Version = "2021-03-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetClusterResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Obtains the details of a cluster.
         *
         * @param request GetClusterRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetClusterResponse
         */
        public async Task<GetClusterResponse> GetClusterWithOptionsAsync(GetClusterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetCluster",
                Version = "2021-03-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetClusterResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Obtains the details of a cluster.
         *
         * @param request GetClusterRequest
         * @return GetClusterResponse
         */
        public GetClusterResponse GetCluster(GetClusterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetClusterWithOptions(request, runtime);
        }

        /**
         * @summary Obtains the details of a cluster.
         *
         * @param request GetClusterRequest
         * @return GetClusterResponse
         */
        public async Task<GetClusterResponse> GetClusterAsync(GetClusterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetClusterWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Obtains job analysis information on E-MapReduce (EMR) Doctor.
         *
         * @description get one doctor analysis app
         *
         * @param request GetDoctorApplicationRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetDoctorApplicationResponse
         */
        public GetDoctorApplicationResponse GetDoctorApplicationWithOptions(GetDoctorApplicationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DateTime))
            {
                query["DateTime"] = request.DateTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDoctorApplication",
                Version = "2021-03-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDoctorApplicationResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Obtains job analysis information on E-MapReduce (EMR) Doctor.
         *
         * @description get one doctor analysis app
         *
         * @param request GetDoctorApplicationRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetDoctorApplicationResponse
         */
        public async Task<GetDoctorApplicationResponse> GetDoctorApplicationWithOptionsAsync(GetDoctorApplicationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DateTime))
            {
                query["DateTime"] = request.DateTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDoctorApplication",
                Version = "2021-03-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDoctorApplicationResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Obtains job analysis information on E-MapReduce (EMR) Doctor.
         *
         * @description get one doctor analysis app
         *
         * @param request GetDoctorApplicationRequest
         * @return GetDoctorApplicationResponse
         */
        public GetDoctorApplicationResponse GetDoctorApplication(GetDoctorApplicationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetDoctorApplicationWithOptions(request, runtime);
        }

        /**
         * @summary Obtains job analysis information on E-MapReduce (EMR) Doctor.
         *
         * @description get one doctor analysis app
         *
         * @param request GetDoctorApplicationRequest
         * @return GetDoctorApplicationResponse
         */
        public async Task<GetDoctorApplicationResponse> GetDoctorApplicationAsync(GetDoctorApplicationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetDoctorApplicationWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Obtains the information about resource usage in a cluster on E-MapReduce (EMR) Doctor.
         *
         * @description get one specific luster engine queue by <type, name>
         *
         * @param request GetDoctorComputeSummaryRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetDoctorComputeSummaryResponse
         */
        public GetDoctorComputeSummaryResponse GetDoctorComputeSummaryWithOptions(GetDoctorComputeSummaryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ComponentInfo))
            {
                query["ComponentInfo"] = request.ComponentInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DateTime))
            {
                query["DateTime"] = request.DateTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDoctorComputeSummary",
                Version = "2021-03-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDoctorComputeSummaryResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Obtains the information about resource usage in a cluster on E-MapReduce (EMR) Doctor.
         *
         * @description get one specific luster engine queue by <type, name>
         *
         * @param request GetDoctorComputeSummaryRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetDoctorComputeSummaryResponse
         */
        public async Task<GetDoctorComputeSummaryResponse> GetDoctorComputeSummaryWithOptionsAsync(GetDoctorComputeSummaryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ComponentInfo))
            {
                query["ComponentInfo"] = request.ComponentInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DateTime))
            {
                query["DateTime"] = request.DateTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDoctorComputeSummary",
                Version = "2021-03-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDoctorComputeSummaryResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Obtains the information about resource usage in a cluster on E-MapReduce (EMR) Doctor.
         *
         * @description get one specific luster engine queue by <type, name>
         *
         * @param request GetDoctorComputeSummaryRequest
         * @return GetDoctorComputeSummaryResponse
         */
        public GetDoctorComputeSummaryResponse GetDoctorComputeSummary(GetDoctorComputeSummaryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetDoctorComputeSummaryWithOptions(request, runtime);
        }

        /**
         * @summary Obtains the information about resource usage in a cluster on E-MapReduce (EMR) Doctor.
         *
         * @description get one specific luster engine queue by <type, name>
         *
         * @param request GetDoctorComputeSummaryRequest
         * @return GetDoctorComputeSummaryResponse
         */
        public async Task<GetDoctorComputeSummaryResponse> GetDoctorComputeSummaryAsync(GetDoctorComputeSummaryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetDoctorComputeSummaryWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Obtains the metrics of an HBase cluster.
         *
         * @description get Doctor HBaseCluster
         *
         * @param request GetDoctorHBaseClusterRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetDoctorHBaseClusterResponse
         */
        public GetDoctorHBaseClusterResponse GetDoctorHBaseClusterWithOptions(GetDoctorHBaseClusterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DateTime))
            {
                query["DateTime"] = request.DateTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDoctorHBaseCluster",
                Version = "2021-03-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDoctorHBaseClusterResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Obtains the metrics of an HBase cluster.
         *
         * @description get Doctor HBaseCluster
         *
         * @param request GetDoctorHBaseClusterRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetDoctorHBaseClusterResponse
         */
        public async Task<GetDoctorHBaseClusterResponse> GetDoctorHBaseClusterWithOptionsAsync(GetDoctorHBaseClusterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DateTime))
            {
                query["DateTime"] = request.DateTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDoctorHBaseCluster",
                Version = "2021-03-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDoctorHBaseClusterResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Obtains the metrics of an HBase cluster.
         *
         * @description get Doctor HBaseCluster
         *
         * @param request GetDoctorHBaseClusterRequest
         * @return GetDoctorHBaseClusterResponse
         */
        public GetDoctorHBaseClusterResponse GetDoctorHBaseCluster(GetDoctorHBaseClusterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetDoctorHBaseClusterWithOptions(request, runtime);
        }

        /**
         * @summary Obtains the metrics of an HBase cluster.
         *
         * @description get Doctor HBaseCluster
         *
         * @param request GetDoctorHBaseClusterRequest
         * @return GetDoctorHBaseClusterResponse
         */
        public async Task<GetDoctorHBaseClusterResponse> GetDoctorHBaseClusterAsync(GetDoctorHBaseClusterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetDoctorHBaseClusterWithOptionsAsync(request, runtime);
        }

        /**
         * @description list Doctor HBaseRegions
         *
         * @param request GetDoctorHBaseRegionRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetDoctorHBaseRegionResponse
         */
        public GetDoctorHBaseRegionResponse GetDoctorHBaseRegionWithOptions(GetDoctorHBaseRegionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DateTime))
            {
                query["DateTime"] = request.DateTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HbaseRegionId))
            {
                query["HbaseRegionId"] = request.HbaseRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDoctorHBaseRegion",
                Version = "2021-03-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDoctorHBaseRegionResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @description list Doctor HBaseRegions
         *
         * @param request GetDoctorHBaseRegionRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetDoctorHBaseRegionResponse
         */
        public async Task<GetDoctorHBaseRegionResponse> GetDoctorHBaseRegionWithOptionsAsync(GetDoctorHBaseRegionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DateTime))
            {
                query["DateTime"] = request.DateTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HbaseRegionId))
            {
                query["HbaseRegionId"] = request.HbaseRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDoctorHBaseRegion",
                Version = "2021-03-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDoctorHBaseRegionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @description list Doctor HBaseRegions
         *
         * @param request GetDoctorHBaseRegionRequest
         * @return GetDoctorHBaseRegionResponse
         */
        public GetDoctorHBaseRegionResponse GetDoctorHBaseRegion(GetDoctorHBaseRegionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetDoctorHBaseRegionWithOptions(request, runtime);
        }

        /**
         * @description list Doctor HBaseRegions
         *
         * @param request GetDoctorHBaseRegionRequest
         * @return GetDoctorHBaseRegionResponse
         */
        public async Task<GetDoctorHBaseRegionResponse> GetDoctorHBaseRegionAsync(GetDoctorHBaseRegionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetDoctorHBaseRegionWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Obtains the information about an HBase region server.
         *
         * @description get Doctor HBaseRegionServer
         *
         * @param request GetDoctorHBaseRegionServerRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetDoctorHBaseRegionServerResponse
         */
        public GetDoctorHBaseRegionServerResponse GetDoctorHBaseRegionServerWithOptions(GetDoctorHBaseRegionServerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DateTime))
            {
                query["DateTime"] = request.DateTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionServerHost))
            {
                query["RegionServerHost"] = request.RegionServerHost;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDoctorHBaseRegionServer",
                Version = "2021-03-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDoctorHBaseRegionServerResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Obtains the information about an HBase region server.
         *
         * @description get Doctor HBaseRegionServer
         *
         * @param request GetDoctorHBaseRegionServerRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetDoctorHBaseRegionServerResponse
         */
        public async Task<GetDoctorHBaseRegionServerResponse> GetDoctorHBaseRegionServerWithOptionsAsync(GetDoctorHBaseRegionServerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DateTime))
            {
                query["DateTime"] = request.DateTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionServerHost))
            {
                query["RegionServerHost"] = request.RegionServerHost;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDoctorHBaseRegionServer",
                Version = "2021-03-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDoctorHBaseRegionServerResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Obtains the information about an HBase region server.
         *
         * @description get Doctor HBaseRegionServer
         *
         * @param request GetDoctorHBaseRegionServerRequest
         * @return GetDoctorHBaseRegionServerResponse
         */
        public GetDoctorHBaseRegionServerResponse GetDoctorHBaseRegionServer(GetDoctorHBaseRegionServerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetDoctorHBaseRegionServerWithOptions(request, runtime);
        }

        /**
         * @summary Obtains the information about an HBase region server.
         *
         * @description get Doctor HBaseRegionServer
         *
         * @param request GetDoctorHBaseRegionServerRequest
         * @return GetDoctorHBaseRegionServerResponse
         */
        public async Task<GetDoctorHBaseRegionServerResponse> GetDoctorHBaseRegionServerAsync(GetDoctorHBaseRegionServerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetDoctorHBaseRegionServerWithOptionsAsync(request, runtime);
        }

        /**
         * @description get Doctor HBaseTable
         *
         * @param request GetDoctorHBaseTableRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetDoctorHBaseTableResponse
         */
        public GetDoctorHBaseTableResponse GetDoctorHBaseTableWithOptions(GetDoctorHBaseTableRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DateTime))
            {
                query["DateTime"] = request.DateTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TableName))
            {
                query["TableName"] = request.TableName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDoctorHBaseTable",
                Version = "2021-03-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDoctorHBaseTableResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @description get Doctor HBaseTable
         *
         * @param request GetDoctorHBaseTableRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetDoctorHBaseTableResponse
         */
        public async Task<GetDoctorHBaseTableResponse> GetDoctorHBaseTableWithOptionsAsync(GetDoctorHBaseTableRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DateTime))
            {
                query["DateTime"] = request.DateTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TableName))
            {
                query["TableName"] = request.TableName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDoctorHBaseTable",
                Version = "2021-03-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDoctorHBaseTableResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @description get Doctor HBaseTable
         *
         * @param request GetDoctorHBaseTableRequest
         * @return GetDoctorHBaseTableResponse
         */
        public GetDoctorHBaseTableResponse GetDoctorHBaseTable(GetDoctorHBaseTableRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetDoctorHBaseTableWithOptions(request, runtime);
        }

        /**
         * @description get Doctor HBaseTable
         *
         * @param request GetDoctorHBaseTableRequest
         * @return GetDoctorHBaseTableResponse
         */
        public async Task<GetDoctorHBaseTableResponse> GetDoctorHBaseTableAsync(GetDoctorHBaseTableRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetDoctorHBaseTableWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Obtains the analysis results of the Hadoop Distributed File System (HDFS) storage resources of a cluster on E-MapReduce (EMR) Doctor.
         *
         * @description list Doctor HBaseTableRegions
         *
         * @param request GetDoctorHDFSClusterRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetDoctorHDFSClusterResponse
         */
        public GetDoctorHDFSClusterResponse GetDoctorHDFSClusterWithOptions(GetDoctorHDFSClusterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DateTime))
            {
                query["DateTime"] = request.DateTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDoctorHDFSCluster",
                Version = "2021-03-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDoctorHDFSClusterResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Obtains the analysis results of the Hadoop Distributed File System (HDFS) storage resources of a cluster on E-MapReduce (EMR) Doctor.
         *
         * @description list Doctor HBaseTableRegions
         *
         * @param request GetDoctorHDFSClusterRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetDoctorHDFSClusterResponse
         */
        public async Task<GetDoctorHDFSClusterResponse> GetDoctorHDFSClusterWithOptionsAsync(GetDoctorHDFSClusterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DateTime))
            {
                query["DateTime"] = request.DateTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDoctorHDFSCluster",
                Version = "2021-03-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDoctorHDFSClusterResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Obtains the analysis results of the Hadoop Distributed File System (HDFS) storage resources of a cluster on E-MapReduce (EMR) Doctor.
         *
         * @description list Doctor HBaseTableRegions
         *
         * @param request GetDoctorHDFSClusterRequest
         * @return GetDoctorHDFSClusterResponse
         */
        public GetDoctorHDFSClusterResponse GetDoctorHDFSCluster(GetDoctorHDFSClusterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetDoctorHDFSClusterWithOptions(request, runtime);
        }

        /**
         * @summary Obtains the analysis results of the Hadoop Distributed File System (HDFS) storage resources of a cluster on E-MapReduce (EMR) Doctor.
         *
         * @description list Doctor HBaseTableRegions
         *
         * @param request GetDoctorHDFSClusterRequest
         * @return GetDoctorHDFSClusterResponse
         */
        public async Task<GetDoctorHDFSClusterResponse> GetDoctorHDFSClusterAsync(GetDoctorHDFSClusterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetDoctorHDFSClusterWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Obtains the analysis results of a specific Hadoop Distributed File System (HDFS) directory of a cluster. The depth of the directory is not greater than five.
         *
         * @description get Doctor HDFSNode
         *
         * @param request GetDoctorHDFSDirectoryRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetDoctorHDFSDirectoryResponse
         */
        public GetDoctorHDFSDirectoryResponse GetDoctorHDFSDirectoryWithOptions(GetDoctorHDFSDirectoryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DateTime))
            {
                query["DateTime"] = request.DateTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DirPath))
            {
                query["DirPath"] = request.DirPath;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDoctorHDFSDirectory",
                Version = "2021-03-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDoctorHDFSDirectoryResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Obtains the analysis results of a specific Hadoop Distributed File System (HDFS) directory of a cluster. The depth of the directory is not greater than five.
         *
         * @description get Doctor HDFSNode
         *
         * @param request GetDoctorHDFSDirectoryRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetDoctorHDFSDirectoryResponse
         */
        public async Task<GetDoctorHDFSDirectoryResponse> GetDoctorHDFSDirectoryWithOptionsAsync(GetDoctorHDFSDirectoryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DateTime))
            {
                query["DateTime"] = request.DateTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DirPath))
            {
                query["DirPath"] = request.DirPath;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDoctorHDFSDirectory",
                Version = "2021-03-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDoctorHDFSDirectoryResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Obtains the analysis results of a specific Hadoop Distributed File System (HDFS) directory of a cluster. The depth of the directory is not greater than five.
         *
         * @description get Doctor HDFSNode
         *
         * @param request GetDoctorHDFSDirectoryRequest
         * @return GetDoctorHDFSDirectoryResponse
         */
        public GetDoctorHDFSDirectoryResponse GetDoctorHDFSDirectory(GetDoctorHDFSDirectoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetDoctorHDFSDirectoryWithOptions(request, runtime);
        }

        /**
         * @summary Obtains the analysis results of a specific Hadoop Distributed File System (HDFS) directory of a cluster. The depth of the directory is not greater than five.
         *
         * @description get Doctor HDFSNode
         *
         * @param request GetDoctorHDFSDirectoryRequest
         * @return GetDoctorHDFSDirectoryResponse
         */
        public async Task<GetDoctorHDFSDirectoryResponse> GetDoctorHDFSDirectoryAsync(GetDoctorHDFSDirectoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetDoctorHDFSDirectoryWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Obtains the analysis results of Hadoop Distributed File System (HDFS) storage resources for a specific owner or group on E-MapReduce (EMR) Doctor.
         *
         * @description get Doctor HDFS UGI
         *
         * @param request GetDoctorHDFSUGIRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetDoctorHDFSUGIResponse
         */
        public GetDoctorHDFSUGIResponse GetDoctorHDFSUGIWithOptions(GetDoctorHDFSUGIRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DateTime))
            {
                query["DateTime"] = request.DateTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["Type"] = request.Type;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDoctorHDFSUGI",
                Version = "2021-03-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDoctorHDFSUGIResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Obtains the analysis results of Hadoop Distributed File System (HDFS) storage resources for a specific owner or group on E-MapReduce (EMR) Doctor.
         *
         * @description get Doctor HDFS UGI
         *
         * @param request GetDoctorHDFSUGIRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetDoctorHDFSUGIResponse
         */
        public async Task<GetDoctorHDFSUGIResponse> GetDoctorHDFSUGIWithOptionsAsync(GetDoctorHDFSUGIRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DateTime))
            {
                query["DateTime"] = request.DateTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["Type"] = request.Type;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDoctorHDFSUGI",
                Version = "2021-03-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDoctorHDFSUGIResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Obtains the analysis results of Hadoop Distributed File System (HDFS) storage resources for a specific owner or group on E-MapReduce (EMR) Doctor.
         *
         * @description get Doctor HDFS UGI
         *
         * @param request GetDoctorHDFSUGIRequest
         * @return GetDoctorHDFSUGIResponse
         */
        public GetDoctorHDFSUGIResponse GetDoctorHDFSUGI(GetDoctorHDFSUGIRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetDoctorHDFSUGIWithOptions(request, runtime);
        }

        /**
         * @summary Obtains the analysis results of Hadoop Distributed File System (HDFS) storage resources for a specific owner or group on E-MapReduce (EMR) Doctor.
         *
         * @description get Doctor HDFS UGI
         *
         * @param request GetDoctorHDFSUGIRequest
         * @return GetDoctorHDFSUGIResponse
         */
        public async Task<GetDoctorHDFSUGIResponse> GetDoctorHDFSUGIAsync(GetDoctorHDFSUGIRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetDoctorHDFSUGIWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Obtains the analysis results of a Hive cluster.
         *
         * @description list Doctor Hive Cluster
         *
         * @param request GetDoctorHiveClusterRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetDoctorHiveClusterResponse
         */
        public GetDoctorHiveClusterResponse GetDoctorHiveClusterWithOptions(GetDoctorHiveClusterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DateTime))
            {
                query["DateTime"] = request.DateTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDoctorHiveCluster",
                Version = "2021-03-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDoctorHiveClusterResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Obtains the analysis results of a Hive cluster.
         *
         * @description list Doctor Hive Cluster
         *
         * @param request GetDoctorHiveClusterRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetDoctorHiveClusterResponse
         */
        public async Task<GetDoctorHiveClusterResponse> GetDoctorHiveClusterWithOptionsAsync(GetDoctorHiveClusterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DateTime))
            {
                query["DateTime"] = request.DateTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDoctorHiveCluster",
                Version = "2021-03-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDoctorHiveClusterResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Obtains the analysis results of a Hive cluster.
         *
         * @description list Doctor Hive Cluster
         *
         * @param request GetDoctorHiveClusterRequest
         * @return GetDoctorHiveClusterResponse
         */
        public GetDoctorHiveClusterResponse GetDoctorHiveCluster(GetDoctorHiveClusterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetDoctorHiveClusterWithOptions(request, runtime);
        }

        /**
         * @summary Obtains the analysis results of a Hive cluster.
         *
         * @description list Doctor Hive Cluster
         *
         * @param request GetDoctorHiveClusterRequest
         * @return GetDoctorHiveClusterResponse
         */
        public async Task<GetDoctorHiveClusterResponse> GetDoctorHiveClusterAsync(GetDoctorHiveClusterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetDoctorHiveClusterWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Obtains the analysis results of a Hive database.
         *
         * @description get Doctor Hive Database
         *
         * @param request GetDoctorHiveDatabaseRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetDoctorHiveDatabaseResponse
         */
        public GetDoctorHiveDatabaseResponse GetDoctorHiveDatabaseWithOptions(GetDoctorHiveDatabaseRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DateTime))
            {
                query["DateTime"] = request.DateTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDoctorHiveDatabase",
                Version = "2021-03-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDoctorHiveDatabaseResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Obtains the analysis results of a Hive database.
         *
         * @description get Doctor Hive Database
         *
         * @param request GetDoctorHiveDatabaseRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetDoctorHiveDatabaseResponse
         */
        public async Task<GetDoctorHiveDatabaseResponse> GetDoctorHiveDatabaseWithOptionsAsync(GetDoctorHiveDatabaseRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DateTime))
            {
                query["DateTime"] = request.DateTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDoctorHiveDatabase",
                Version = "2021-03-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDoctorHiveDatabaseResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Obtains the analysis results of a Hive database.
         *
         * @description get Doctor Hive Database
         *
         * @param request GetDoctorHiveDatabaseRequest
         * @return GetDoctorHiveDatabaseResponse
         */
        public GetDoctorHiveDatabaseResponse GetDoctorHiveDatabase(GetDoctorHiveDatabaseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetDoctorHiveDatabaseWithOptions(request, runtime);
        }

        /**
         * @summary Obtains the analysis results of a Hive database.
         *
         * @description get Doctor Hive Database
         *
         * @param request GetDoctorHiveDatabaseRequest
         * @return GetDoctorHiveDatabaseResponse
         */
        public async Task<GetDoctorHiveDatabaseResponse> GetDoctorHiveDatabaseAsync(GetDoctorHiveDatabaseRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetDoctorHiveDatabaseWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Obtains the analysis results of a specific Hive table in a cluster on E-MapReduce (EMR) Doctor.
         *
         * @description get Doctor Hive Table
         *
         * @param request GetDoctorHiveTableRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetDoctorHiveTableResponse
         */
        public GetDoctorHiveTableResponse GetDoctorHiveTableWithOptions(GetDoctorHiveTableRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DateTime))
            {
                query["DateTime"] = request.DateTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TableName))
            {
                query["TableName"] = request.TableName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDoctorHiveTable",
                Version = "2021-03-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDoctorHiveTableResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Obtains the analysis results of a specific Hive table in a cluster on E-MapReduce (EMR) Doctor.
         *
         * @description get Doctor Hive Table
         *
         * @param request GetDoctorHiveTableRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetDoctorHiveTableResponse
         */
        public async Task<GetDoctorHiveTableResponse> GetDoctorHiveTableWithOptionsAsync(GetDoctorHiveTableRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DateTime))
            {
                query["DateTime"] = request.DateTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TableName))
            {
                query["TableName"] = request.TableName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDoctorHiveTable",
                Version = "2021-03-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDoctorHiveTableResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Obtains the analysis results of a specific Hive table in a cluster on E-MapReduce (EMR) Doctor.
         *
         * @description get Doctor Hive Table
         *
         * @param request GetDoctorHiveTableRequest
         * @return GetDoctorHiveTableResponse
         */
        public GetDoctorHiveTableResponse GetDoctorHiveTable(GetDoctorHiveTableRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetDoctorHiveTableWithOptions(request, runtime);
        }

        /**
         * @summary Obtains the analysis results of a specific Hive table in a cluster on E-MapReduce (EMR) Doctor.
         *
         * @description get Doctor Hive Table
         *
         * @param request GetDoctorHiveTableRequest
         * @return GetDoctorHiveTableResponse
         */
        public async Task<GetDoctorHiveTableResponse> GetDoctorHiveTableAsync(GetDoctorHiveTableRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetDoctorHiveTableWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Obtains the basic running information about a job on E-MapReduce (EMR) Doctor.
         *
         * @description Get realtime job by yarn
         *
         * @param request GetDoctorJobRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetDoctorJobResponse
         */
        public GetDoctorJobResponse GetDoctorJobWithOptions(GetDoctorJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDoctorJob",
                Version = "2021-03-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDoctorJobResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Obtains the basic running information about a job on E-MapReduce (EMR) Doctor.
         *
         * @description Get realtime job by yarn
         *
         * @param request GetDoctorJobRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetDoctorJobResponse
         */
        public async Task<GetDoctorJobResponse> GetDoctorJobWithOptionsAsync(GetDoctorJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDoctorJob",
                Version = "2021-03-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDoctorJobResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Obtains the basic running information about a job on E-MapReduce (EMR) Doctor.
         *
         * @description Get realtime job by yarn
         *
         * @param request GetDoctorJobRequest
         * @return GetDoctorJobResponse
         */
        public GetDoctorJobResponse GetDoctorJob(GetDoctorJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetDoctorJobWithOptions(request, runtime);
        }

        /**
         * @summary Obtains the basic running information about a job on E-MapReduce (EMR) Doctor.
         *
         * @description Get realtime job by yarn
         *
         * @param request GetDoctorJobRequest
         * @return GetDoctorJobResponse
         */
        public async Task<GetDoctorJobResponse> GetDoctorJobAsync(GetDoctorJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetDoctorJobWithOptionsAsync(request, runtime);
        }

        /**
         * @description get specify component's report analysis by emr doctor
         *
         * @param request GetDoctorReportComponentSummaryRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetDoctorReportComponentSummaryResponse
         */
        public GetDoctorReportComponentSummaryResponse GetDoctorReportComponentSummaryWithOptions(GetDoctorReportComponentSummaryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ComponentType))
            {
                query["ComponentType"] = request.ComponentType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DateTime))
            {
                query["DateTime"] = request.DateTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDoctorReportComponentSummary",
                Version = "2021-03-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDoctorReportComponentSummaryResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @description get specify component's report analysis by emr doctor
         *
         * @param request GetDoctorReportComponentSummaryRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetDoctorReportComponentSummaryResponse
         */
        public async Task<GetDoctorReportComponentSummaryResponse> GetDoctorReportComponentSummaryWithOptionsAsync(GetDoctorReportComponentSummaryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ComponentType))
            {
                query["ComponentType"] = request.ComponentType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DateTime))
            {
                query["DateTime"] = request.DateTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetDoctorReportComponentSummary",
                Version = "2021-03-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetDoctorReportComponentSummaryResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @description get specify component's report analysis by emr doctor
         *
         * @param request GetDoctorReportComponentSummaryRequest
         * @return GetDoctorReportComponentSummaryResponse
         */
        public GetDoctorReportComponentSummaryResponse GetDoctorReportComponentSummary(GetDoctorReportComponentSummaryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetDoctorReportComponentSummaryWithOptions(request, runtime);
        }

        /**
         * @description get specify component's report analysis by emr doctor
         *
         * @param request GetDoctorReportComponentSummaryRequest
         * @return GetDoctorReportComponentSummaryResponse
         */
        public async Task<GetDoctorReportComponentSummaryResponse> GetDoctorReportComponentSummaryAsync(GetDoctorReportComponentSummaryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetDoctorReportComponentSummaryWithOptionsAsync(request, runtime);
        }

        /**
         * @summary You can call this operation to obtain the details of a node group.
         *
         * @description 获取节点组详情。
         *
         * @param request GetNodeGroupRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetNodeGroupResponse
         */
        public GetNodeGroupResponse GetNodeGroupWithOptions(GetNodeGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeGroupId))
            {
                query["NodeGroupId"] = request.NodeGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetNodeGroup",
                Version = "2021-03-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetNodeGroupResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary You can call this operation to obtain the details of a node group.
         *
         * @description 获取节点组详情。
         *
         * @param request GetNodeGroupRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetNodeGroupResponse
         */
        public async Task<GetNodeGroupResponse> GetNodeGroupWithOptionsAsync(GetNodeGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeGroupId))
            {
                query["NodeGroupId"] = request.NodeGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetNodeGroup",
                Version = "2021-03-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetNodeGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary You can call this operation to obtain the details of a node group.
         *
         * @description 获取节点组详情。
         *
         * @param request GetNodeGroupRequest
         * @return GetNodeGroupResponse
         */
        public GetNodeGroupResponse GetNodeGroup(GetNodeGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetNodeGroupWithOptions(request, runtime);
        }

        /**
         * @summary You can call this operation to obtain the details of a node group.
         *
         * @description 获取节点组详情。
         *
         * @param request GetNodeGroupRequest
         * @return GetNodeGroupResponse
         */
        public async Task<GetNodeGroupResponse> GetNodeGroupAsync(GetNodeGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetNodeGroupWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Gets the details of an asynchronous operation.
         *
         * @description 获取操作详情。
         *
         * @param request GetOperationRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetOperationResponse
         */
        public GetOperationResponse GetOperationWithOptions(GetOperationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperationId))
            {
                query["OperationId"] = request.OperationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetOperation",
                Version = "2021-03-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetOperationResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Gets the details of an asynchronous operation.
         *
         * @description 获取操作详情。
         *
         * @param request GetOperationRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetOperationResponse
         */
        public async Task<GetOperationResponse> GetOperationWithOptionsAsync(GetOperationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperationId))
            {
                query["OperationId"] = request.OperationId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetOperation",
                Version = "2021-03-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetOperationResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Gets the details of an asynchronous operation.
         *
         * @description 获取操作详情。
         *
         * @param request GetOperationRequest
         * @return GetOperationResponse
         */
        public GetOperationResponse GetOperation(GetOperationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetOperationWithOptions(request, runtime);
        }

        /**
         * @summary Gets the details of an asynchronous operation.
         *
         * @description 获取操作详情。
         *
         * @param request GetOperationRequest
         * @return GetOperationResponse
         */
        public async Task<GetOperationResponse> GetOperationAsync(GetOperationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetOperationWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Scale out the node group.
         *
         * @param request IncreaseNodesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return IncreaseNodesResponse
         */
        public IncreaseNodesResponse IncreaseNodesWithOptions(IncreaseNodesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplicationConfigs))
            {
                query["ApplicationConfigs"] = request.ApplicationConfigs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoPayOrder))
            {
                query["AutoPayOrder"] = request.AutoPayOrder;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncreaseNodeCount))
            {
                query["IncreaseNodeCount"] = request.IncreaseNodeCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MinIncreaseNodeCount))
            {
                query["MinIncreaseNodeCount"] = request.MinIncreaseNodeCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeGroupId))
            {
                query["NodeGroupId"] = request.NodeGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PaymentDuration))
            {
                query["PaymentDuration"] = request.PaymentDuration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PaymentDurationUnit))
            {
                query["PaymentDurationUnit"] = request.PaymentDurationUnit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "IncreaseNodes",
                Version = "2021-03-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<IncreaseNodesResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Scale out the node group.
         *
         * @param request IncreaseNodesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return IncreaseNodesResponse
         */
        public async Task<IncreaseNodesResponse> IncreaseNodesWithOptionsAsync(IncreaseNodesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplicationConfigs))
            {
                query["ApplicationConfigs"] = request.ApplicationConfigs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoPayOrder))
            {
                query["AutoPayOrder"] = request.AutoPayOrder;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncreaseNodeCount))
            {
                query["IncreaseNodeCount"] = request.IncreaseNodeCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MinIncreaseNodeCount))
            {
                query["MinIncreaseNodeCount"] = request.MinIncreaseNodeCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeGroupId))
            {
                query["NodeGroupId"] = request.NodeGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PaymentDuration))
            {
                query["PaymentDuration"] = request.PaymentDuration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PaymentDurationUnit))
            {
                query["PaymentDurationUnit"] = request.PaymentDurationUnit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "IncreaseNodes",
                Version = "2021-03-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<IncreaseNodesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Scale out the node group.
         *
         * @param request IncreaseNodesRequest
         * @return IncreaseNodesResponse
         */
        public IncreaseNodesResponse IncreaseNodes(IncreaseNodesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return IncreaseNodesWithOptions(request, runtime);
        }

        /**
         * @summary Scale out the node group.
         *
         * @param request IncreaseNodesRequest
         * @return IncreaseNodesResponse
         */
        public async Task<IncreaseNodesResponse> IncreaseNodesAsync(IncreaseNodesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await IncreaseNodesWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Add an EMR resource to the target resource group. A resource can belong to only one resource group.
         *
         * @param request JoinResourceGroupRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return JoinResourceGroupResponse
         */
        public JoinResourceGroupResponse JoinResourceGroupWithOptions(JoinResourceGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
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
                Action = "JoinResourceGroup",
                Version = "2021-03-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<JoinResourceGroupResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Add an EMR resource to the target resource group. A resource can belong to only one resource group.
         *
         * @param request JoinResourceGroupRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return JoinResourceGroupResponse
         */
        public async Task<JoinResourceGroupResponse> JoinResourceGroupWithOptionsAsync(JoinResourceGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
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
                Action = "JoinResourceGroup",
                Version = "2021-03-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<JoinResourceGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Add an EMR resource to the target resource group. A resource can belong to only one resource group.
         *
         * @param request JoinResourceGroupRequest
         * @return JoinResourceGroupResponse
         */
        public JoinResourceGroupResponse JoinResourceGroup(JoinResourceGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return JoinResourceGroupWithOptions(request, runtime);
        }

        /**
         * @summary Add an EMR resource to the target resource group. A resource can belong to only one resource group.
         *
         * @param request JoinResourceGroupRequest
         * @return JoinResourceGroupResponse
         */
        public async Task<JoinResourceGroupResponse> JoinResourceGroupAsync(JoinResourceGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await JoinResourceGroupWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 查询API模板
         *
         * @param request ListApiTemplatesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListApiTemplatesResponse
         */
        public ListApiTemplatesResponse ListApiTemplatesWithOptions(ListApiTemplatesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApiName))
            {
                query["ApiName"] = request.ApiName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateId))
            {
                query["TemplateId"] = request.TemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateIds))
            {
                query["TemplateIds"] = request.TemplateIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateName))
            {
                query["TemplateName"] = request.TemplateName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListApiTemplates",
                Version = "2021-03-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListApiTemplatesResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 查询API模板
         *
         * @param request ListApiTemplatesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListApiTemplatesResponse
         */
        public async Task<ListApiTemplatesResponse> ListApiTemplatesWithOptionsAsync(ListApiTemplatesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApiName))
            {
                query["ApiName"] = request.ApiName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateId))
            {
                query["TemplateId"] = request.TemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateIds))
            {
                query["TemplateIds"] = request.TemplateIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateName))
            {
                query["TemplateName"] = request.TemplateName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListApiTemplates",
                Version = "2021-03-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListApiTemplatesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 查询API模板
         *
         * @param request ListApiTemplatesRequest
         * @return ListApiTemplatesResponse
         */
        public ListApiTemplatesResponse ListApiTemplates(ListApiTemplatesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListApiTemplatesWithOptions(request, runtime);
        }

        /**
         * @summary 查询API模板
         *
         * @param request ListApiTemplatesRequest
         * @return ListApiTemplatesResponse
         */
        public async Task<ListApiTemplatesResponse> ListApiTemplatesAsync(ListApiTemplatesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListApiTemplatesWithOptionsAsync(request, runtime);
        }

        /**
         * @description 查询应用配置。
         *
         * @param request ListApplicationConfigsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListApplicationConfigsResponse
         */
        public ListApplicationConfigsResponse ListApplicationConfigsWithOptions(ListApplicationConfigsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplicationName))
            {
                query["ApplicationName"] = request.ApplicationName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigFileName))
            {
                query["ConfigFileName"] = request.ConfigFileName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigItemKey))
            {
                query["ConfigItemKey"] = request.ConfigItemKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigItemValue))
            {
                query["ConfigItemValue"] = request.ConfigItemValue;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeGroupId))
            {
                query["NodeGroupId"] = request.NodeGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeId))
            {
                query["NodeId"] = request.NodeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListApplicationConfigs",
                Version = "2021-03-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListApplicationConfigsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @description 查询应用配置。
         *
         * @param request ListApplicationConfigsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListApplicationConfigsResponse
         */
        public async Task<ListApplicationConfigsResponse> ListApplicationConfigsWithOptionsAsync(ListApplicationConfigsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplicationName))
            {
                query["ApplicationName"] = request.ApplicationName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigFileName))
            {
                query["ConfigFileName"] = request.ConfigFileName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigItemKey))
            {
                query["ConfigItemKey"] = request.ConfigItemKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigItemValue))
            {
                query["ConfigItemValue"] = request.ConfigItemValue;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeGroupId))
            {
                query["NodeGroupId"] = request.NodeGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeId))
            {
                query["NodeId"] = request.NodeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListApplicationConfigs",
                Version = "2021-03-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListApplicationConfigsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @description 查询应用配置。
         *
         * @param request ListApplicationConfigsRequest
         * @return ListApplicationConfigsResponse
         */
        public ListApplicationConfigsResponse ListApplicationConfigs(ListApplicationConfigsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListApplicationConfigsWithOptions(request, runtime);
        }

        /**
         * @description 查询应用配置。
         *
         * @param request ListApplicationConfigsRequest
         * @return ListApplicationConfigsResponse
         */
        public async Task<ListApplicationConfigsResponse> ListApplicationConfigsAsync(ListApplicationConfigsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListApplicationConfigsWithOptionsAsync(request, runtime);
        }

        /**
         * @description 查询应用列表。
         *
         * @param request ListApplicationsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListApplicationsResponse
         */
        public ListApplicationsResponse ListApplicationsWithOptions(ListApplicationsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplicationNames))
            {
                query["ApplicationNames"] = request.ApplicationNames;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListApplications",
                Version = "2021-03-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListApplicationsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @description 查询应用列表。
         *
         * @param request ListApplicationsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListApplicationsResponse
         */
        public async Task<ListApplicationsResponse> ListApplicationsWithOptionsAsync(ListApplicationsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplicationNames))
            {
                query["ApplicationNames"] = request.ApplicationNames;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListApplications",
                Version = "2021-03-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListApplicationsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @description 查询应用列表。
         *
         * @param request ListApplicationsRequest
         * @return ListApplicationsResponse
         */
        public ListApplicationsResponse ListApplications(ListApplicationsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListApplicationsWithOptions(request, runtime);
        }

        /**
         * @description 查询应用列表。
         *
         * @param request ListApplicationsRequest
         * @return ListApplicationsResponse
         */
        public async Task<ListApplicationsResponse> ListApplicationsAsync(ListApplicationsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListApplicationsWithOptionsAsync(request, runtime);
        }

        /**
         * @description 查询弹性伸缩活动列表。
         *
         * @param request ListAutoScalingActivitiesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListAutoScalingActivitiesResponse
         */
        public ListAutoScalingActivitiesResponse ListAutoScalingActivitiesWithOptions(ListAutoScalingActivitiesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeGroupId))
            {
                query["NodeGroupId"] = request.NodeGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScalingActivityStates))
            {
                query["ScalingActivityStates"] = request.ScalingActivityStates;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScalingActivityType))
            {
                query["ScalingActivityType"] = request.ScalingActivityType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScalingRuleName))
            {
                query["ScalingRuleName"] = request.ScalingRuleName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListAutoScalingActivities",
                Version = "2021-03-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAutoScalingActivitiesResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @description 查询弹性伸缩活动列表。
         *
         * @param request ListAutoScalingActivitiesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListAutoScalingActivitiesResponse
         */
        public async Task<ListAutoScalingActivitiesResponse> ListAutoScalingActivitiesWithOptionsAsync(ListAutoScalingActivitiesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeGroupId))
            {
                query["NodeGroupId"] = request.NodeGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScalingActivityStates))
            {
                query["ScalingActivityStates"] = request.ScalingActivityStates;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScalingActivityType))
            {
                query["ScalingActivityType"] = request.ScalingActivityType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScalingRuleName))
            {
                query["ScalingRuleName"] = request.ScalingRuleName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListAutoScalingActivities",
                Version = "2021-03-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAutoScalingActivitiesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @description 查询弹性伸缩活动列表。
         *
         * @param request ListAutoScalingActivitiesRequest
         * @return ListAutoScalingActivitiesResponse
         */
        public ListAutoScalingActivitiesResponse ListAutoScalingActivities(ListAutoScalingActivitiesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListAutoScalingActivitiesWithOptions(request, runtime);
        }

        /**
         * @description 查询弹性伸缩活动列表。
         *
         * @param request ListAutoScalingActivitiesRequest
         * @return ListAutoScalingActivitiesResponse
         */
        public async Task<ListAutoScalingActivitiesResponse> ListAutoScalingActivitiesAsync(ListAutoScalingActivitiesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListAutoScalingActivitiesWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries E-MapReduce (EMR) clusters.
         *
         * @param request ListClustersRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListClustersResponse
         */
        public ListClustersResponse ListClustersWithOptions(ListClustersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterIds))
            {
                query["ClusterIds"] = request.ClusterIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterName))
            {
                query["ClusterName"] = request.ClusterName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterStates))
            {
                query["ClusterStates"] = request.ClusterStates;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterTypes))
            {
                query["ClusterTypes"] = request.ClusterTypes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PaymentTypes))
            {
                query["PaymentTypes"] = request.PaymentTypes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tags))
            {
                query["Tags"] = request.Tags;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListClusters",
                Version = "2021-03-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListClustersResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries E-MapReduce (EMR) clusters.
         *
         * @param request ListClustersRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListClustersResponse
         */
        public async Task<ListClustersResponse> ListClustersWithOptionsAsync(ListClustersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterIds))
            {
                query["ClusterIds"] = request.ClusterIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterName))
            {
                query["ClusterName"] = request.ClusterName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterStates))
            {
                query["ClusterStates"] = request.ClusterStates;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterTypes))
            {
                query["ClusterTypes"] = request.ClusterTypes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PaymentTypes))
            {
                query["PaymentTypes"] = request.PaymentTypes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tags))
            {
                query["Tags"] = request.Tags;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListClusters",
                Version = "2021-03-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListClustersResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries E-MapReduce (EMR) clusters.
         *
         * @param request ListClustersRequest
         * @return ListClustersResponse
         */
        public ListClustersResponse ListClusters(ListClustersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListClustersWithOptions(request, runtime);
        }

        /**
         * @summary Queries E-MapReduce (EMR) clusters.
         *
         * @param request ListClustersRequest
         * @return ListClustersResponse
         */
        public async Task<ListClustersResponse> ListClustersAsync(ListClustersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListClustersWithOptionsAsync(request, runtime);
        }

        /**
         * @description 查询组件实例列表。
         *
         * @param request ListComponentInstancesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListComponentInstancesResponse
         */
        public ListComponentInstancesResponse ListComponentInstancesWithOptions(ListComponentInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplicationNames))
            {
                query["ApplicationNames"] = request.ApplicationNames;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ComponentNames))
            {
                query["ComponentNames"] = request.ComponentNames;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ComponentStates))
            {
                query["ComponentStates"] = request.ComponentStates;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeIds))
            {
                query["NodeIds"] = request.NodeIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeNames))
            {
                query["NodeNames"] = request.NodeNames;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListComponentInstances",
                Version = "2021-03-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListComponentInstancesResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @description 查询组件实例列表。
         *
         * @param request ListComponentInstancesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListComponentInstancesResponse
         */
        public async Task<ListComponentInstancesResponse> ListComponentInstancesWithOptionsAsync(ListComponentInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplicationNames))
            {
                query["ApplicationNames"] = request.ApplicationNames;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ComponentNames))
            {
                query["ComponentNames"] = request.ComponentNames;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ComponentStates))
            {
                query["ComponentStates"] = request.ComponentStates;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeIds))
            {
                query["NodeIds"] = request.NodeIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeNames))
            {
                query["NodeNames"] = request.NodeNames;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListComponentInstances",
                Version = "2021-03-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListComponentInstancesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @description 查询组件实例列表。
         *
         * @param request ListComponentInstancesRequest
         * @return ListComponentInstancesResponse
         */
        public ListComponentInstancesResponse ListComponentInstances(ListComponentInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListComponentInstancesWithOptions(request, runtime);
        }

        /**
         * @description 查询组件实例列表。
         *
         * @param request ListComponentInstancesRequest
         * @return ListComponentInstancesResponse
         */
        public async Task<ListComponentInstancesResponse> ListComponentInstancesAsync(ListComponentInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListComponentInstancesWithOptionsAsync(request, runtime);
        }

        /**
         * @description 查询组件列表。
         *
         * @param request ListComponentsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListComponentsResponse
         */
        public ListComponentsResponse ListComponentsWithOptions(ListComponentsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplicationNames))
            {
                query["ApplicationNames"] = request.ApplicationNames;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ComponentNames))
            {
                query["ComponentNames"] = request.ComponentNames;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ComponentStates))
            {
                query["ComponentStates"] = request.ComponentStates;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncludeExpiredConfig))
            {
                query["IncludeExpiredConfig"] = request.IncludeExpiredConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListComponents",
                Version = "2021-03-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListComponentsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @description 查询组件列表。
         *
         * @param request ListComponentsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListComponentsResponse
         */
        public async Task<ListComponentsResponse> ListComponentsWithOptionsAsync(ListComponentsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplicationNames))
            {
                query["ApplicationNames"] = request.ApplicationNames;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ComponentNames))
            {
                query["ComponentNames"] = request.ComponentNames;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ComponentStates))
            {
                query["ComponentStates"] = request.ComponentStates;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IncludeExpiredConfig))
            {
                query["IncludeExpiredConfig"] = request.IncludeExpiredConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListComponents",
                Version = "2021-03-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListComponentsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @description 查询组件列表。
         *
         * @param request ListComponentsRequest
         * @return ListComponentsResponse
         */
        public ListComponentsResponse ListComponents(ListComponentsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListComponentsWithOptions(request, runtime);
        }

        /**
         * @description 查询组件列表。
         *
         * @param request ListComponentsRequest
         * @return ListComponentsResponse
         */
        public async Task<ListComponentsResponse> ListComponentsAsync(ListComponentsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListComponentsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Obtains the analysis results of multiple jobs on E-MapReduce (EMR) Doctor.
         *
         * @description list all doctor analysis apps
         *
         * @param request ListDoctorApplicationsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListDoctorApplicationsResponse
         */
        public ListDoctorApplicationsResponse ListDoctorApplicationsWithOptions(ListDoctorApplicationsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppIds))
            {
                query["AppIds"] = request.AppIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DateTime))
            {
                query["DateTime"] = request.DateTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderBy))
            {
                query["OrderBy"] = request.OrderBy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderType))
            {
                query["OrderType"] = request.OrderType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Queues))
            {
                query["Queues"] = request.Queues;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Types))
            {
                query["Types"] = request.Types;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Users))
            {
                query["Users"] = request.Users;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListDoctorApplications",
                Version = "2021-03-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDoctorApplicationsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Obtains the analysis results of multiple jobs on E-MapReduce (EMR) Doctor.
         *
         * @description list all doctor analysis apps
         *
         * @param request ListDoctorApplicationsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListDoctorApplicationsResponse
         */
        public async Task<ListDoctorApplicationsResponse> ListDoctorApplicationsWithOptionsAsync(ListDoctorApplicationsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppIds))
            {
                query["AppIds"] = request.AppIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DateTime))
            {
                query["DateTime"] = request.DateTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderBy))
            {
                query["OrderBy"] = request.OrderBy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderType))
            {
                query["OrderType"] = request.OrderType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Queues))
            {
                query["Queues"] = request.Queues;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Types))
            {
                query["Types"] = request.Types;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Users))
            {
                query["Users"] = request.Users;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListDoctorApplications",
                Version = "2021-03-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDoctorApplicationsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Obtains the analysis results of multiple jobs on E-MapReduce (EMR) Doctor.
         *
         * @description list all doctor analysis apps
         *
         * @param request ListDoctorApplicationsRequest
         * @return ListDoctorApplicationsResponse
         */
        public ListDoctorApplicationsResponse ListDoctorApplications(ListDoctorApplicationsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListDoctorApplicationsWithOptions(request, runtime);
        }

        /**
         * @summary Obtains the analysis results of multiple jobs on E-MapReduce (EMR) Doctor.
         *
         * @description list all doctor analysis apps
         *
         * @param request ListDoctorApplicationsRequest
         * @return ListDoctorApplicationsResponse
         */
        public async Task<ListDoctorApplicationsResponse> ListDoctorApplicationsAsync(ListDoctorApplicationsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListDoctorApplicationsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Obtains the information about resource usage by resource type in a cluster on E-MapReduce (EMR) Doctor.
         *
         * @description list Doctor analysis result of cluster engine queue view
         *
         * @param request ListDoctorComputeSummaryRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListDoctorComputeSummaryResponse
         */
        public ListDoctorComputeSummaryResponse ListDoctorComputeSummaryWithOptions(ListDoctorComputeSummaryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ComponentTypes))
            {
                query["ComponentTypes"] = request.ComponentTypes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DateTime))
            {
                query["DateTime"] = request.DateTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderBy))
            {
                query["OrderBy"] = request.OrderBy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderType))
            {
                query["OrderType"] = request.OrderType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListDoctorComputeSummary",
                Version = "2021-03-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDoctorComputeSummaryResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Obtains the information about resource usage by resource type in a cluster on E-MapReduce (EMR) Doctor.
         *
         * @description list Doctor analysis result of cluster engine queue view
         *
         * @param request ListDoctorComputeSummaryRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListDoctorComputeSummaryResponse
         */
        public async Task<ListDoctorComputeSummaryResponse> ListDoctorComputeSummaryWithOptionsAsync(ListDoctorComputeSummaryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ComponentTypes))
            {
                query["ComponentTypes"] = request.ComponentTypes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DateTime))
            {
                query["DateTime"] = request.DateTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderBy))
            {
                query["OrderBy"] = request.OrderBy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderType))
            {
                query["OrderType"] = request.OrderType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListDoctorComputeSummary",
                Version = "2021-03-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDoctorComputeSummaryResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Obtains the information about resource usage by resource type in a cluster on E-MapReduce (EMR) Doctor.
         *
         * @description list Doctor analysis result of cluster engine queue view
         *
         * @param request ListDoctorComputeSummaryRequest
         * @return ListDoctorComputeSummaryResponse
         */
        public ListDoctorComputeSummaryResponse ListDoctorComputeSummary(ListDoctorComputeSummaryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListDoctorComputeSummaryWithOptions(request, runtime);
        }

        /**
         * @summary Obtains the information about resource usage by resource type in a cluster on E-MapReduce (EMR) Doctor.
         *
         * @description list Doctor analysis result of cluster engine queue view
         *
         * @param request ListDoctorComputeSummaryRequest
         * @return ListDoctorComputeSummaryResponse
         */
        public async Task<ListDoctorComputeSummaryResponse> ListDoctorComputeSummaryAsync(ListDoctorComputeSummaryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListDoctorComputeSummaryWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Obtains the information about multiple HBase RegionServers at a time.
         *
         * @description list Doctor HBaseRegionServers
         *
         * @param request ListDoctorHBaseRegionServersRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListDoctorHBaseRegionServersResponse
         */
        public ListDoctorHBaseRegionServersResponse ListDoctorHBaseRegionServersWithOptions(ListDoctorHBaseRegionServersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DateTime))
            {
                query["DateTime"] = request.DateTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderBy))
            {
                query["OrderBy"] = request.OrderBy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderType))
            {
                query["OrderType"] = request.OrderType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionServerHosts))
            {
                query["RegionServerHosts"] = request.RegionServerHosts;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListDoctorHBaseRegionServers",
                Version = "2021-03-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDoctorHBaseRegionServersResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Obtains the information about multiple HBase RegionServers at a time.
         *
         * @description list Doctor HBaseRegionServers
         *
         * @param request ListDoctorHBaseRegionServersRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListDoctorHBaseRegionServersResponse
         */
        public async Task<ListDoctorHBaseRegionServersResponse> ListDoctorHBaseRegionServersWithOptionsAsync(ListDoctorHBaseRegionServersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DateTime))
            {
                query["DateTime"] = request.DateTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderBy))
            {
                query["OrderBy"] = request.OrderBy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderType))
            {
                query["OrderType"] = request.OrderType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionServerHosts))
            {
                query["RegionServerHosts"] = request.RegionServerHosts;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListDoctorHBaseRegionServers",
                Version = "2021-03-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDoctorHBaseRegionServersResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Obtains the information about multiple HBase RegionServers at a time.
         *
         * @description list Doctor HBaseRegionServers
         *
         * @param request ListDoctorHBaseRegionServersRequest
         * @return ListDoctorHBaseRegionServersResponse
         */
        public ListDoctorHBaseRegionServersResponse ListDoctorHBaseRegionServers(ListDoctorHBaseRegionServersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListDoctorHBaseRegionServersWithOptions(request, runtime);
        }

        /**
         * @summary Obtains the information about multiple HBase RegionServers at a time.
         *
         * @description list Doctor HBaseRegionServers
         *
         * @param request ListDoctorHBaseRegionServersRequest
         * @return ListDoctorHBaseRegionServersResponse
         */
        public async Task<ListDoctorHBaseRegionServersResponse> ListDoctorHBaseRegionServersAsync(ListDoctorHBaseRegionServersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListDoctorHBaseRegionServersWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Obtains the information about multiple HBase tables at a time.
         *
         * @description list Doctor HBaseTables
         *
         * @param request ListDoctorHBaseTablesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListDoctorHBaseTablesResponse
         */
        public ListDoctorHBaseTablesResponse ListDoctorHBaseTablesWithOptions(ListDoctorHBaseTablesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DateTime))
            {
                query["DateTime"] = request.DateTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderBy))
            {
                query["OrderBy"] = request.OrderBy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderType))
            {
                query["OrderType"] = request.OrderType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TableNames))
            {
                query["TableNames"] = request.TableNames;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListDoctorHBaseTables",
                Version = "2021-03-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDoctorHBaseTablesResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Obtains the information about multiple HBase tables at a time.
         *
         * @description list Doctor HBaseTables
         *
         * @param request ListDoctorHBaseTablesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListDoctorHBaseTablesResponse
         */
        public async Task<ListDoctorHBaseTablesResponse> ListDoctorHBaseTablesWithOptionsAsync(ListDoctorHBaseTablesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DateTime))
            {
                query["DateTime"] = request.DateTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderBy))
            {
                query["OrderBy"] = request.OrderBy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderType))
            {
                query["OrderType"] = request.OrderType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TableNames))
            {
                query["TableNames"] = request.TableNames;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListDoctorHBaseTables",
                Version = "2021-03-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDoctorHBaseTablesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Obtains the information about multiple HBase tables at a time.
         *
         * @description list Doctor HBaseTables
         *
         * @param request ListDoctorHBaseTablesRequest
         * @return ListDoctorHBaseTablesResponse
         */
        public ListDoctorHBaseTablesResponse ListDoctorHBaseTables(ListDoctorHBaseTablesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListDoctorHBaseTablesWithOptions(request, runtime);
        }

        /**
         * @summary Obtains the information about multiple HBase tables at a time.
         *
         * @description list Doctor HBaseTables
         *
         * @param request ListDoctorHBaseTablesRequest
         * @return ListDoctorHBaseTablesResponse
         */
        public async Task<ListDoctorHBaseTablesResponse> ListDoctorHBaseTablesAsync(ListDoctorHBaseTablesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListDoctorHBaseTablesWithOptionsAsync(request, runtime);
        }

        /**
         * @description list Doctor HDFSNodes
         *
         * @param request ListDoctorHDFSDirectoriesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListDoctorHDFSDirectoriesResponse
         */
        public ListDoctorHDFSDirectoriesResponse ListDoctorHDFSDirectoriesWithOptions(ListDoctorHDFSDirectoriesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DateTime))
            {
                query["DateTime"] = request.DateTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DirPath))
            {
                query["DirPath"] = request.DirPath;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderBy))
            {
                query["OrderBy"] = request.OrderBy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderType))
            {
                query["OrderType"] = request.OrderType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListDoctorHDFSDirectories",
                Version = "2021-03-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDoctorHDFSDirectoriesResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @description list Doctor HDFSNodes
         *
         * @param request ListDoctorHDFSDirectoriesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListDoctorHDFSDirectoriesResponse
         */
        public async Task<ListDoctorHDFSDirectoriesResponse> ListDoctorHDFSDirectoriesWithOptionsAsync(ListDoctorHDFSDirectoriesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DateTime))
            {
                query["DateTime"] = request.DateTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DirPath))
            {
                query["DirPath"] = request.DirPath;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderBy))
            {
                query["OrderBy"] = request.OrderBy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderType))
            {
                query["OrderType"] = request.OrderType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListDoctorHDFSDirectories",
                Version = "2021-03-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDoctorHDFSDirectoriesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @description list Doctor HDFSNodes
         *
         * @param request ListDoctorHDFSDirectoriesRequest
         * @return ListDoctorHDFSDirectoriesResponse
         */
        public ListDoctorHDFSDirectoriesResponse ListDoctorHDFSDirectories(ListDoctorHDFSDirectoriesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListDoctorHDFSDirectoriesWithOptions(request, runtime);
        }

        /**
         * @description list Doctor HDFSNodes
         *
         * @param request ListDoctorHDFSDirectoriesRequest
         * @return ListDoctorHDFSDirectoriesResponse
         */
        public async Task<ListDoctorHDFSDirectoriesResponse> ListDoctorHDFSDirectoriesAsync(ListDoctorHDFSDirectoriesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListDoctorHDFSDirectoriesWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Obtains the analysis results of Hadoop Distributed File System (HDFS) storage resources for multiple owners or groups at a time on E-MapReduce (EMR) Doctor.
         *
         * @description list Doctor HDFS UGIs
         *
         * @param request ListDoctorHDFSUGIRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListDoctorHDFSUGIResponse
         */
        public ListDoctorHDFSUGIResponse ListDoctorHDFSUGIWithOptions(ListDoctorHDFSUGIRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DateTime))
            {
                query["DateTime"] = request.DateTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderBy))
            {
                query["OrderBy"] = request.OrderBy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderType))
            {
                query["OrderType"] = request.OrderType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["Type"] = request.Type;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListDoctorHDFSUGI",
                Version = "2021-03-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDoctorHDFSUGIResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Obtains the analysis results of Hadoop Distributed File System (HDFS) storage resources for multiple owners or groups at a time on E-MapReduce (EMR) Doctor.
         *
         * @description list Doctor HDFS UGIs
         *
         * @param request ListDoctorHDFSUGIRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListDoctorHDFSUGIResponse
         */
        public async Task<ListDoctorHDFSUGIResponse> ListDoctorHDFSUGIWithOptionsAsync(ListDoctorHDFSUGIRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DateTime))
            {
                query["DateTime"] = request.DateTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderBy))
            {
                query["OrderBy"] = request.OrderBy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderType))
            {
                query["OrderType"] = request.OrderType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["Type"] = request.Type;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListDoctorHDFSUGI",
                Version = "2021-03-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDoctorHDFSUGIResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Obtains the analysis results of Hadoop Distributed File System (HDFS) storage resources for multiple owners or groups at a time on E-MapReduce (EMR) Doctor.
         *
         * @description list Doctor HDFS UGIs
         *
         * @param request ListDoctorHDFSUGIRequest
         * @return ListDoctorHDFSUGIResponse
         */
        public ListDoctorHDFSUGIResponse ListDoctorHDFSUGI(ListDoctorHDFSUGIRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListDoctorHDFSUGIWithOptions(request, runtime);
        }

        /**
         * @summary Obtains the analysis results of Hadoop Distributed File System (HDFS) storage resources for multiple owners or groups at a time on E-MapReduce (EMR) Doctor.
         *
         * @description list Doctor HDFS UGIs
         *
         * @param request ListDoctorHDFSUGIRequest
         * @return ListDoctorHDFSUGIResponse
         */
        public async Task<ListDoctorHDFSUGIResponse> ListDoctorHDFSUGIAsync(ListDoctorHDFSUGIRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListDoctorHDFSUGIWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Obtains the analysis results of multiple Hive databases at a time.
         *
         * @description list Doctor Hive Databases
         *
         * @param request ListDoctorHiveDatabasesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListDoctorHiveDatabasesResponse
         */
        public ListDoctorHiveDatabasesResponse ListDoctorHiveDatabasesWithOptions(ListDoctorHiveDatabasesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatabaseNames))
            {
                query["DatabaseNames"] = request.DatabaseNames;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DateTime))
            {
                query["DateTime"] = request.DateTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderBy))
            {
                query["OrderBy"] = request.OrderBy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderType))
            {
                query["OrderType"] = request.OrderType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListDoctorHiveDatabases",
                Version = "2021-03-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDoctorHiveDatabasesResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Obtains the analysis results of multiple Hive databases at a time.
         *
         * @description list Doctor Hive Databases
         *
         * @param request ListDoctorHiveDatabasesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListDoctorHiveDatabasesResponse
         */
        public async Task<ListDoctorHiveDatabasesResponse> ListDoctorHiveDatabasesWithOptionsAsync(ListDoctorHiveDatabasesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DatabaseNames))
            {
                query["DatabaseNames"] = request.DatabaseNames;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DateTime))
            {
                query["DateTime"] = request.DateTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderBy))
            {
                query["OrderBy"] = request.OrderBy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderType))
            {
                query["OrderType"] = request.OrderType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListDoctorHiveDatabases",
                Version = "2021-03-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDoctorHiveDatabasesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Obtains the analysis results of multiple Hive databases at a time.
         *
         * @description list Doctor Hive Databases
         *
         * @param request ListDoctorHiveDatabasesRequest
         * @return ListDoctorHiveDatabasesResponse
         */
        public ListDoctorHiveDatabasesResponse ListDoctorHiveDatabases(ListDoctorHiveDatabasesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListDoctorHiveDatabasesWithOptions(request, runtime);
        }

        /**
         * @summary Obtains the analysis results of multiple Hive databases at a time.
         *
         * @description list Doctor Hive Databases
         *
         * @param request ListDoctorHiveDatabasesRequest
         * @return ListDoctorHiveDatabasesResponse
         */
        public async Task<ListDoctorHiveDatabasesResponse> ListDoctorHiveDatabasesAsync(ListDoctorHiveDatabasesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListDoctorHiveDatabasesWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Obtains the analysis results of multiple Hive tables at a time on E-MapReduce (EMR) Doctor.
         *
         * @description list Doctor Hive Tables
         *
         * @param request ListDoctorHiveTablesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListDoctorHiveTablesResponse
         */
        public ListDoctorHiveTablesResponse ListDoctorHiveTablesWithOptions(ListDoctorHiveTablesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DateTime))
            {
                query["DateTime"] = request.DateTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderBy))
            {
                query["OrderBy"] = request.OrderBy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderType))
            {
                query["OrderType"] = request.OrderType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TableNames))
            {
                query["TableNames"] = request.TableNames;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListDoctorHiveTables",
                Version = "2021-03-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDoctorHiveTablesResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Obtains the analysis results of multiple Hive tables at a time on E-MapReduce (EMR) Doctor.
         *
         * @description list Doctor Hive Tables
         *
         * @param request ListDoctorHiveTablesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListDoctorHiveTablesResponse
         */
        public async Task<ListDoctorHiveTablesResponse> ListDoctorHiveTablesWithOptionsAsync(ListDoctorHiveTablesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DateTime))
            {
                query["DateTime"] = request.DateTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderBy))
            {
                query["OrderBy"] = request.OrderBy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderType))
            {
                query["OrderType"] = request.OrderType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TableNames))
            {
                query["TableNames"] = request.TableNames;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListDoctorHiveTables",
                Version = "2021-03-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDoctorHiveTablesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Obtains the analysis results of multiple Hive tables at a time on E-MapReduce (EMR) Doctor.
         *
         * @description list Doctor Hive Tables
         *
         * @param request ListDoctorHiveTablesRequest
         * @return ListDoctorHiveTablesResponse
         */
        public ListDoctorHiveTablesResponse ListDoctorHiveTables(ListDoctorHiveTablesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListDoctorHiveTablesWithOptions(request, runtime);
        }

        /**
         * @summary Obtains the analysis results of multiple Hive tables at a time on E-MapReduce (EMR) Doctor.
         *
         * @description list Doctor Hive Tables
         *
         * @param request ListDoctorHiveTablesRequest
         * @return ListDoctorHiveTablesResponse
         */
        public async Task<ListDoctorHiveTablesResponse> ListDoctorHiveTablesAsync(ListDoctorHiveTablesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListDoctorHiveTablesWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Obtains the basic running information about multiple jobs at a time on E-MapReduce (EMR) Doctor.
         *
         * @description list realtime jobs by yarn
         *
         * @param request ListDoctorJobsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListDoctorJobsResponse
         */
        public ListDoctorJobsResponse ListDoctorJobsWithOptions(ListDoctorJobsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppIds))
            {
                query["AppIds"] = request.AppIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndRange))
            {
                query["EndRange"] = request.EndRange;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderBy))
            {
                query["OrderBy"] = request.OrderBy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderType))
            {
                query["OrderType"] = request.OrderType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Queues))
            {
                query["Queues"] = request.Queues;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartRange))
            {
                query["StartRange"] = request.StartRange;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Types))
            {
                query["Types"] = request.Types;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Users))
            {
                query["Users"] = request.Users;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListDoctorJobs",
                Version = "2021-03-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDoctorJobsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Obtains the basic running information about multiple jobs at a time on E-MapReduce (EMR) Doctor.
         *
         * @description list realtime jobs by yarn
         *
         * @param request ListDoctorJobsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListDoctorJobsResponse
         */
        public async Task<ListDoctorJobsResponse> ListDoctorJobsWithOptionsAsync(ListDoctorJobsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppIds))
            {
                query["AppIds"] = request.AppIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndRange))
            {
                query["EndRange"] = request.EndRange;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderBy))
            {
                query["OrderBy"] = request.OrderBy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderType))
            {
                query["OrderType"] = request.OrderType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Queues))
            {
                query["Queues"] = request.Queues;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartRange))
            {
                query["StartRange"] = request.StartRange;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Types))
            {
                query["Types"] = request.Types;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Users))
            {
                query["Users"] = request.Users;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListDoctorJobs",
                Version = "2021-03-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDoctorJobsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Obtains the basic running information about multiple jobs at a time on E-MapReduce (EMR) Doctor.
         *
         * @description list realtime jobs by yarn
         *
         * @param request ListDoctorJobsRequest
         * @return ListDoctorJobsResponse
         */
        public ListDoctorJobsResponse ListDoctorJobs(ListDoctorJobsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListDoctorJobsWithOptions(request, runtime);
        }

        /**
         * @summary Obtains the basic running information about multiple jobs at a time on E-MapReduce (EMR) Doctor.
         *
         * @description list realtime jobs by yarn
         *
         * @param request ListDoctorJobsRequest
         * @return ListDoctorJobsResponse
         */
        public async Task<ListDoctorJobsResponse> ListDoctorJobsAsync(ListDoctorJobsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListDoctorJobsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Obtains the summary of basic running information about multiple jobs at a time on E-MapReduce (EMR) Doctor.
         *
         * @description list stats groupBy jobs by yarn
         *
         * @param request ListDoctorJobsStatsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListDoctorJobsStatsResponse
         */
        public ListDoctorJobsStatsResponse ListDoctorJobsStatsWithOptions(ListDoctorJobsStatsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndRange))
            {
                query["EndRange"] = request.EndRange;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupBy))
            {
                query["GroupBy"] = request.GroupBy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderBy))
            {
                query["OrderBy"] = request.OrderBy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderType))
            {
                query["OrderType"] = request.OrderType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartRange))
            {
                query["StartRange"] = request.StartRange;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListDoctorJobsStats",
                Version = "2021-03-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDoctorJobsStatsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Obtains the summary of basic running information about multiple jobs at a time on E-MapReduce (EMR) Doctor.
         *
         * @description list stats groupBy jobs by yarn
         *
         * @param request ListDoctorJobsStatsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListDoctorJobsStatsResponse
         */
        public async Task<ListDoctorJobsStatsResponse> ListDoctorJobsStatsWithOptionsAsync(ListDoctorJobsStatsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndRange))
            {
                query["EndRange"] = request.EndRange;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupBy))
            {
                query["GroupBy"] = request.GroupBy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderBy))
            {
                query["OrderBy"] = request.OrderBy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderType))
            {
                query["OrderType"] = request.OrderType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartRange))
            {
                query["StartRange"] = request.StartRange;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListDoctorJobsStats",
                Version = "2021-03-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDoctorJobsStatsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Obtains the summary of basic running information about multiple jobs at a time on E-MapReduce (EMR) Doctor.
         *
         * @description list stats groupBy jobs by yarn
         *
         * @param request ListDoctorJobsStatsRequest
         * @return ListDoctorJobsStatsResponse
         */
        public ListDoctorJobsStatsResponse ListDoctorJobsStats(ListDoctorJobsStatsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListDoctorJobsStatsWithOptions(request, runtime);
        }

        /**
         * @summary Obtains the summary of basic running information about multiple jobs at a time on E-MapReduce (EMR) Doctor.
         *
         * @description list stats groupBy jobs by yarn
         *
         * @param request ListDoctorJobsStatsRequest
         * @return ListDoctorJobsStatsResponse
         */
        public async Task<ListDoctorJobsStatsResponse> ListDoctorJobsStatsAsync(ListDoctorJobsStatsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListDoctorJobsStatsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Obtains the overall analysis result reports of E-MapReduce (EMR) Doctor at a time.
         *
         * @description list all reports analysis by emr doctor
         *
         * @param request ListDoctorReportsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListDoctorReportsResponse
         */
        public ListDoctorReportsResponse ListDoctorReportsWithOptions(ListDoctorReportsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListDoctorReports",
                Version = "2021-03-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDoctorReportsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Obtains the overall analysis result reports of E-MapReduce (EMR) Doctor at a time.
         *
         * @description list all reports analysis by emr doctor
         *
         * @param request ListDoctorReportsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListDoctorReportsResponse
         */
        public async Task<ListDoctorReportsResponse> ListDoctorReportsWithOptionsAsync(ListDoctorReportsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListDoctorReports",
                Version = "2021-03-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDoctorReportsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Obtains the overall analysis result reports of E-MapReduce (EMR) Doctor at a time.
         *
         * @description list all reports analysis by emr doctor
         *
         * @param request ListDoctorReportsRequest
         * @return ListDoctorReportsResponse
         */
        public ListDoctorReportsResponse ListDoctorReports(ListDoctorReportsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListDoctorReportsWithOptions(request, runtime);
        }

        /**
         * @summary Obtains the overall analysis result reports of E-MapReduce (EMR) Doctor at a time.
         *
         * @description list all reports analysis by emr doctor
         *
         * @param request ListDoctorReportsRequest
         * @return ListDoctorReportsResponse
         */
        public async Task<ListDoctorReportsResponse> ListDoctorReportsAsync(ListDoctorReportsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListDoctorReportsWithOptionsAsync(request, runtime);
        }

        /**
         * @param request ListInstanceTypesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListInstanceTypesResponse
         */
        public ListInstanceTypesResponse ListInstanceTypesWithOptions(ListInstanceTypesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterType))
            {
                query["ClusterType"] = request.ClusterType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeployMode))
            {
                query["DeployMode"] = request.DeployMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceType))
            {
                query["InstanceType"] = request.InstanceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsModification))
            {
                query["IsModification"] = request.IsModification;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeGroupId))
            {
                query["NodeGroupId"] = request.NodeGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeGroupType))
            {
                query["NodeGroupType"] = request.NodeGroupType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PaymentType))
            {
                query["PaymentType"] = request.PaymentType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReleaseVersion))
            {
                query["ReleaseVersion"] = request.ReleaseVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ZoneId))
            {
                query["ZoneId"] = request.ZoneId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListInstanceTypes",
                Version = "2021-03-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListInstanceTypesResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request ListInstanceTypesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListInstanceTypesResponse
         */
        public async Task<ListInstanceTypesResponse> ListInstanceTypesWithOptionsAsync(ListInstanceTypesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterType))
            {
                query["ClusterType"] = request.ClusterType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeployMode))
            {
                query["DeployMode"] = request.DeployMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceType))
            {
                query["InstanceType"] = request.InstanceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsModification))
            {
                query["IsModification"] = request.IsModification;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeGroupId))
            {
                query["NodeGroupId"] = request.NodeGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeGroupType))
            {
                query["NodeGroupType"] = request.NodeGroupType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PaymentType))
            {
                query["PaymentType"] = request.PaymentType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReleaseVersion))
            {
                query["ReleaseVersion"] = request.ReleaseVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ZoneId))
            {
                query["ZoneId"] = request.ZoneId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListInstanceTypes",
                Version = "2021-03-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListInstanceTypesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request ListInstanceTypesRequest
         * @return ListInstanceTypesResponse
         */
        public ListInstanceTypesResponse ListInstanceTypes(ListInstanceTypesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListInstanceTypesWithOptions(request, runtime);
        }

        /**
         * @param request ListInstanceTypesRequest
         * @return ListInstanceTypesResponse
         */
        public async Task<ListInstanceTypesResponse> ListInstanceTypesAsync(ListInstanceTypesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListInstanceTypesWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the list of node groups in an EMR cluster.
         *
         * @param request ListNodeGroupsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListNodeGroupsResponse
         */
        public ListNodeGroupsResponse ListNodeGroupsWithOptions(ListNodeGroupsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeGroupIds))
            {
                query["NodeGroupIds"] = request.NodeGroupIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeGroupNames))
            {
                query["NodeGroupNames"] = request.NodeGroupNames;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeGroupStates))
            {
                query["NodeGroupStates"] = request.NodeGroupStates;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeGroupTypes))
            {
                query["NodeGroupTypes"] = request.NodeGroupTypes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListNodeGroups",
                Version = "2021-03-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListNodeGroupsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the list of node groups in an EMR cluster.
         *
         * @param request ListNodeGroupsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListNodeGroupsResponse
         */
        public async Task<ListNodeGroupsResponse> ListNodeGroupsWithOptionsAsync(ListNodeGroupsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeGroupIds))
            {
                query["NodeGroupIds"] = request.NodeGroupIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeGroupNames))
            {
                query["NodeGroupNames"] = request.NodeGroupNames;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeGroupStates))
            {
                query["NodeGroupStates"] = request.NodeGroupStates;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeGroupTypes))
            {
                query["NodeGroupTypes"] = request.NodeGroupTypes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListNodeGroups",
                Version = "2021-03-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListNodeGroupsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the list of node groups in an EMR cluster.
         *
         * @param request ListNodeGroupsRequest
         * @return ListNodeGroupsResponse
         */
        public ListNodeGroupsResponse ListNodeGroups(ListNodeGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListNodeGroupsWithOptions(request, runtime);
        }

        /**
         * @summary Queries the list of node groups in an EMR cluster.
         *
         * @param request ListNodeGroupsRequest
         * @return ListNodeGroupsResponse
         */
        public async Task<ListNodeGroupsResponse> ListNodeGroupsAsync(ListNodeGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListNodeGroupsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the node list of an EMR cluster.
         *
         * @param request ListNodesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListNodesResponse
         */
        public ListNodesResponse ListNodesWithOptions(ListNodesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeGroupIds))
            {
                query["NodeGroupIds"] = request.NodeGroupIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeIds))
            {
                query["NodeIds"] = request.NodeIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeNames))
            {
                query["NodeNames"] = request.NodeNames;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeStates))
            {
                query["NodeStates"] = request.NodeStates;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PrivateIps))
            {
                query["PrivateIps"] = request.PrivateIps;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PublicIps))
            {
                query["PublicIps"] = request.PublicIps;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tags))
            {
                query["Tags"] = request.Tags;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListNodes",
                Version = "2021-03-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListNodesResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the node list of an EMR cluster.
         *
         * @param request ListNodesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListNodesResponse
         */
        public async Task<ListNodesResponse> ListNodesWithOptionsAsync(ListNodesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeGroupIds))
            {
                query["NodeGroupIds"] = request.NodeGroupIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeIds))
            {
                query["NodeIds"] = request.NodeIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeNames))
            {
                query["NodeNames"] = request.NodeNames;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeStates))
            {
                query["NodeStates"] = request.NodeStates;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PrivateIps))
            {
                query["PrivateIps"] = request.PrivateIps;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PublicIps))
            {
                query["PublicIps"] = request.PublicIps;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tags))
            {
                query["Tags"] = request.Tags;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListNodes",
                Version = "2021-03-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListNodesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the node list of an EMR cluster.
         *
         * @param request ListNodesRequest
         * @return ListNodesResponse
         */
        public ListNodesResponse ListNodes(ListNodesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListNodesWithOptions(request, runtime);
        }

        /**
         * @summary Queries the node list of an EMR cluster.
         *
         * @param request ListNodesRequest
         * @return ListNodesResponse
         */
        public async Task<ListNodesResponse> ListNodesAsync(ListNodesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListNodesWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the major E-MapReduce (EMR) versions.
         *
         * @description 查询主版本。
         *
         * @param request ListReleaseVersionsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListReleaseVersionsResponse
         */
        public ListReleaseVersionsResponse ListReleaseVersionsWithOptions(ListReleaseVersionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterType))
            {
                query["ClusterType"] = request.ClusterType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IaasType))
            {
                query["IaasType"] = request.IaasType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListReleaseVersions",
                Version = "2021-03-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListReleaseVersionsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the major E-MapReduce (EMR) versions.
         *
         * @description 查询主版本。
         *
         * @param request ListReleaseVersionsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListReleaseVersionsResponse
         */
        public async Task<ListReleaseVersionsResponse> ListReleaseVersionsWithOptionsAsync(ListReleaseVersionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterType))
            {
                query["ClusterType"] = request.ClusterType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IaasType))
            {
                query["IaasType"] = request.IaasType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListReleaseVersions",
                Version = "2021-03-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListReleaseVersionsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the major E-MapReduce (EMR) versions.
         *
         * @description 查询主版本。
         *
         * @param request ListReleaseVersionsRequest
         * @return ListReleaseVersionsResponse
         */
        public ListReleaseVersionsResponse ListReleaseVersions(ListReleaseVersionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListReleaseVersionsWithOptions(request, runtime);
        }

        /**
         * @summary Queries the major E-MapReduce (EMR) versions.
         *
         * @description 查询主版本。
         *
         * @param request ListReleaseVersionsRequest
         * @return ListReleaseVersionsResponse
         */
        public async Task<ListReleaseVersionsResponse> ListReleaseVersionsAsync(ListReleaseVersionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListReleaseVersionsWithOptionsAsync(request, runtime);
        }

        /**
         * @description 查询集群脚本。
         *
         * @param request ListScriptsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListScriptsResponse
         */
        public ListScriptsResponse ListScriptsWithOptions(ListScriptsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScriptType))
            {
                query["ScriptType"] = request.ScriptType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListScripts",
                Version = "2021-03-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListScriptsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @description 查询集群脚本。
         *
         * @param request ListScriptsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListScriptsResponse
         */
        public async Task<ListScriptsResponse> ListScriptsWithOptionsAsync(ListScriptsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScriptType))
            {
                query["ScriptType"] = request.ScriptType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListScripts",
                Version = "2021-03-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListScriptsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @description 查询集群脚本。
         *
         * @param request ListScriptsRequest
         * @return ListScriptsResponse
         */
        public ListScriptsResponse ListScripts(ListScriptsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListScriptsWithOptions(request, runtime);
        }

        /**
         * @description 查询集群脚本。
         *
         * @param request ListScriptsRequest
         * @return ListScriptsResponse
         */
        public async Task<ListScriptsResponse> ListScriptsAsync(ListScriptsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListScriptsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the tags that are bound to an EMR cluster.
         *
         * @param request ListTagResourcesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListTagResourcesResponse
         */
        public ListTagResourcesResponse ListTagResourcesWithOptions(ListTagResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceIds))
            {
                query["ResourceIds"] = request.ResourceIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["ResourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tags))
            {
                query["Tags"] = request.Tags;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTagResources",
                Version = "2021-03-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTagResourcesResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the tags that are bound to an EMR cluster.
         *
         * @param request ListTagResourcesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListTagResourcesResponse
         */
        public async Task<ListTagResourcesResponse> ListTagResourcesWithOptionsAsync(ListTagResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceIds))
            {
                query["ResourceIds"] = request.ResourceIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["ResourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tags))
            {
                query["Tags"] = request.Tags;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTagResources",
                Version = "2021-03-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTagResourcesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the tags that are bound to an EMR cluster.
         *
         * @param request ListTagResourcesRequest
         * @return ListTagResourcesResponse
         */
        public ListTagResourcesResponse ListTagResources(ListTagResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListTagResourcesWithOptions(request, runtime);
        }

        /**
         * @summary Queries the tags that are bound to an EMR cluster.
         *
         * @param request ListTagResourcesRequest
         * @return ListTagResourcesResponse
         */
        public async Task<ListTagResourcesResponse> ListTagResourcesAsync(ListTagResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListTagResourcesWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Configures auto scaling rules.
         *
         * @description You can call this operation to configure auto scaling policies.
         *
         * @param request PutAutoScalingPolicyRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return PutAutoScalingPolicyResponse
         */
        public PutAutoScalingPolicyResponse PutAutoScalingPolicyWithOptions(PutAutoScalingPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Constraints))
            {
                query["Constraints"] = request.Constraints;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeGroupId))
            {
                query["NodeGroupId"] = request.NodeGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScalingRules))
            {
                query["ScalingRules"] = request.ScalingRules;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PutAutoScalingPolicy",
                Version = "2021-03-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PutAutoScalingPolicyResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Configures auto scaling rules.
         *
         * @description You can call this operation to configure auto scaling policies.
         *
         * @param request PutAutoScalingPolicyRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return PutAutoScalingPolicyResponse
         */
        public async Task<PutAutoScalingPolicyResponse> PutAutoScalingPolicyWithOptionsAsync(PutAutoScalingPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Constraints))
            {
                query["Constraints"] = request.Constraints;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeGroupId))
            {
                query["NodeGroupId"] = request.NodeGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScalingRules))
            {
                query["ScalingRules"] = request.ScalingRules;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PutAutoScalingPolicy",
                Version = "2021-03-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PutAutoScalingPolicyResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Configures auto scaling rules.
         *
         * @description You can call this operation to configure auto scaling policies.
         *
         * @param request PutAutoScalingPolicyRequest
         * @return PutAutoScalingPolicyResponse
         */
        public PutAutoScalingPolicyResponse PutAutoScalingPolicy(PutAutoScalingPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return PutAutoScalingPolicyWithOptions(request, runtime);
        }

        /**
         * @summary Configures auto scaling rules.
         *
         * @description You can call this operation to configure auto scaling policies.
         *
         * @param request PutAutoScalingPolicyRequest
         * @return PutAutoScalingPolicyResponse
         */
        public async Task<PutAutoScalingPolicyResponse> PutAutoScalingPolicyAsync(PutAutoScalingPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await PutAutoScalingPolicyWithOptionsAsync(request, runtime);
        }

        /**
         * @param request RemoveAutoScalingPolicyRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RemoveAutoScalingPolicyResponse
         */
        public RemoveAutoScalingPolicyResponse RemoveAutoScalingPolicyWithOptions(RemoveAutoScalingPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeGroupId))
            {
                query["NodeGroupId"] = request.NodeGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RemoveAutoScalingPolicy",
                Version = "2021-03-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RemoveAutoScalingPolicyResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request RemoveAutoScalingPolicyRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RemoveAutoScalingPolicyResponse
         */
        public async Task<RemoveAutoScalingPolicyResponse> RemoveAutoScalingPolicyWithOptionsAsync(RemoveAutoScalingPolicyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeGroupId))
            {
                query["NodeGroupId"] = request.NodeGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RemoveAutoScalingPolicy",
                Version = "2021-03-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RemoveAutoScalingPolicyResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request RemoveAutoScalingPolicyRequest
         * @return RemoveAutoScalingPolicyResponse
         */
        public RemoveAutoScalingPolicyResponse RemoveAutoScalingPolicy(RemoveAutoScalingPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RemoveAutoScalingPolicyWithOptions(request, runtime);
        }

        /**
         * @param request RemoveAutoScalingPolicyRequest
         * @return RemoveAutoScalingPolicyResponse
         */
        public async Task<RemoveAutoScalingPolicyResponse> RemoveAutoScalingPolicyAsync(RemoveAutoScalingPolicyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RemoveAutoScalingPolicyWithOptionsAsync(request, runtime);
        }

        /**
         * @description 执行集群模板
         *
         * @param request RunApiTemplateRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RunApiTemplateResponse
         */
        public RunApiTemplateResponse RunApiTemplateWithOptions(RunApiTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApiName))
            {
                query["ApiName"] = request.ApiName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateId))
            {
                query["TemplateId"] = request.TemplateId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RunApiTemplate",
                Version = "2021-03-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RunApiTemplateResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @description 执行集群模板
         *
         * @param request RunApiTemplateRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RunApiTemplateResponse
         */
        public async Task<RunApiTemplateResponse> RunApiTemplateWithOptionsAsync(RunApiTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApiName))
            {
                query["ApiName"] = request.ApiName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateId))
            {
                query["TemplateId"] = request.TemplateId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RunApiTemplate",
                Version = "2021-03-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RunApiTemplateResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @description 执行集群模板
         *
         * @param request RunApiTemplateRequest
         * @return RunApiTemplateResponse
         */
        public RunApiTemplateResponse RunApiTemplate(RunApiTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RunApiTemplateWithOptions(request, runtime);
        }

        /**
         * @description 执行集群模板
         *
         * @param request RunApiTemplateRequest
         * @return RunApiTemplateResponse
         */
        public async Task<RunApiTemplateResponse> RunApiTemplateAsync(RunApiTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RunApiTemplateWithOptionsAsync(request, runtime);
        }

        /**
         * @param request RunApplicationActionRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RunApplicationActionResponse
         */
        public RunApplicationActionResponse RunApplicationActionWithOptions(RunApplicationActionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ActionName))
            {
                query["ActionName"] = request.ActionName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BatchSize))
            {
                query["BatchSize"] = request.BatchSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ComponentInstanceSelector))
            {
                query["ComponentInstanceSelector"] = request.ComponentInstanceSelector;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExecuteStrategy))
            {
                query["ExecuteStrategy"] = request.ExecuteStrategy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Interval))
            {
                query["Interval"] = request.Interval;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RollingExecute))
            {
                query["RollingExecute"] = request.RollingExecute;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RunApplicationAction",
                Version = "2021-03-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RunApplicationActionResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request RunApplicationActionRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RunApplicationActionResponse
         */
        public async Task<RunApplicationActionResponse> RunApplicationActionWithOptionsAsync(RunApplicationActionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ActionName))
            {
                query["ActionName"] = request.ActionName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BatchSize))
            {
                query["BatchSize"] = request.BatchSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ComponentInstanceSelector))
            {
                query["ComponentInstanceSelector"] = request.ComponentInstanceSelector;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExecuteStrategy))
            {
                query["ExecuteStrategy"] = request.ExecuteStrategy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Interval))
            {
                query["Interval"] = request.Interval;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RollingExecute))
            {
                query["RollingExecute"] = request.RollingExecute;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RunApplicationAction",
                Version = "2021-03-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RunApplicationActionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request RunApplicationActionRequest
         * @return RunApplicationActionResponse
         */
        public RunApplicationActionResponse RunApplicationAction(RunApplicationActionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RunApplicationActionWithOptions(request, runtime);
        }

        /**
         * @param request RunApplicationActionRequest
         * @return RunApplicationActionResponse
         */
        public async Task<RunApplicationActionResponse> RunApplicationActionAsync(RunApplicationActionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RunApplicationActionWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Bind tags to a specified EMR cluster.
         *
         * @param request TagResourcesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return TagResourcesResponse
         */
        public TagResourcesResponse TagResourcesWithOptions(TagResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceIds))
            {
                query["ResourceIds"] = request.ResourceIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["ResourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tags))
            {
                query["Tags"] = request.Tags;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TagResources",
                Version = "2021-03-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<TagResourcesResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Bind tags to a specified EMR cluster.
         *
         * @param request TagResourcesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return TagResourcesResponse
         */
        public async Task<TagResourcesResponse> TagResourcesWithOptionsAsync(TagResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceIds))
            {
                query["ResourceIds"] = request.ResourceIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["ResourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tags))
            {
                query["Tags"] = request.Tags;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TagResources",
                Version = "2021-03-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<TagResourcesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Bind tags to a specified EMR cluster.
         *
         * @param request TagResourcesRequest
         * @return TagResourcesResponse
         */
        public TagResourcesResponse TagResources(TagResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return TagResourcesWithOptions(request, runtime);
        }

        /**
         * @summary Bind tags to a specified EMR cluster.
         *
         * @param request TagResourcesRequest
         * @return TagResourcesResponse
         */
        public async Task<TagResourcesResponse> TagResourcesAsync(TagResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await TagResourcesWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Unbinds tags from a specified column in an EMR cluster. If the tag is not bound to other resources, the tag is automatically deleted.
         *
         * @description 删除指定资源标签。
         *
         * @param request UntagResourcesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UntagResourcesResponse
         */
        public UntagResourcesResponse UntagResourcesWithOptions(UntagResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.All))
            {
                query["All"] = request.All;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceIds))
            {
                query["ResourceIds"] = request.ResourceIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["ResourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagKeys))
            {
                query["TagKeys"] = request.TagKeys;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UntagResources",
                Version = "2021-03-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UntagResourcesResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Unbinds tags from a specified column in an EMR cluster. If the tag is not bound to other resources, the tag is automatically deleted.
         *
         * @description 删除指定资源标签。
         *
         * @param request UntagResourcesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UntagResourcesResponse
         */
        public async Task<UntagResourcesResponse> UntagResourcesWithOptionsAsync(UntagResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.All))
            {
                query["All"] = request.All;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceIds))
            {
                query["ResourceIds"] = request.ResourceIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["ResourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagKeys))
            {
                query["TagKeys"] = request.TagKeys;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UntagResources",
                Version = "2021-03-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UntagResourcesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Unbinds tags from a specified column in an EMR cluster. If the tag is not bound to other resources, the tag is automatically deleted.
         *
         * @description 删除指定资源标签。
         *
         * @param request UntagResourcesRequest
         * @return UntagResourcesResponse
         */
        public UntagResourcesResponse UntagResources(UntagResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UntagResourcesWithOptions(request, runtime);
        }

        /**
         * @summary Unbinds tags from a specified column in an EMR cluster. If the tag is not bound to other resources, the tag is automatically deleted.
         *
         * @description 删除指定资源标签。
         *
         * @param request UntagResourcesRequest
         * @return UntagResourcesResponse
         */
        public async Task<UntagResourcesResponse> UntagResourcesAsync(UntagResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UntagResourcesWithOptionsAsync(request, runtime);
        }

        /**
         * @description 修改集群模板
         *
         * @param request UpdateApiTemplateRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateApiTemplateResponse
         */
        public UpdateApiTemplateResponse UpdateApiTemplateWithOptions(UpdateApiTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApiName))
            {
                query["ApiName"] = request.ApiName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Content))
            {
                query["Content"] = request.Content;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateId))
            {
                query["TemplateId"] = request.TemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateName))
            {
                query["TemplateName"] = request.TemplateName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateApiTemplate",
                Version = "2021-03-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateApiTemplateResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @description 修改集群模板
         *
         * @param request UpdateApiTemplateRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateApiTemplateResponse
         */
        public async Task<UpdateApiTemplateResponse> UpdateApiTemplateWithOptionsAsync(UpdateApiTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApiName))
            {
                query["ApiName"] = request.ApiName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Content))
            {
                query["Content"] = request.Content;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateId))
            {
                query["TemplateId"] = request.TemplateId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateName))
            {
                query["TemplateName"] = request.TemplateName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateApiTemplate",
                Version = "2021-03-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateApiTemplateResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @description 修改集群模板
         *
         * @param request UpdateApiTemplateRequest
         * @return UpdateApiTemplateResponse
         */
        public UpdateApiTemplateResponse UpdateApiTemplate(UpdateApiTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateApiTemplateWithOptions(request, runtime);
        }

        /**
         * @description 修改集群模板
         *
         * @param request UpdateApiTemplateRequest
         * @return UpdateApiTemplateResponse
         */
        public async Task<UpdateApiTemplateResponse> UpdateApiTemplateAsync(UpdateApiTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateApiTemplateWithOptionsAsync(request, runtime);
        }

        /**
         * @param request UpdateApplicationConfigsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateApplicationConfigsResponse
         */
        public UpdateApplicationConfigsResponse UpdateApplicationConfigsWithOptions(UpdateApplicationConfigsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplicationConfigs))
            {
                query["ApplicationConfigs"] = request.ApplicationConfigs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplicationName))
            {
                query["ApplicationName"] = request.ApplicationName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigAction))
            {
                query["ConfigAction"] = request.ConfigAction;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigScope))
            {
                query["ConfigScope"] = request.ConfigScope;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeGroupId))
            {
                query["NodeGroupId"] = request.NodeGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeId))
            {
                query["NodeId"] = request.NodeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateApplicationConfigs",
                Version = "2021-03-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateApplicationConfigsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request UpdateApplicationConfigsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateApplicationConfigsResponse
         */
        public async Task<UpdateApplicationConfigsResponse> UpdateApplicationConfigsWithOptionsAsync(UpdateApplicationConfigsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplicationConfigs))
            {
                query["ApplicationConfigs"] = request.ApplicationConfigs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApplicationName))
            {
                query["ApplicationName"] = request.ApplicationName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigAction))
            {
                query["ConfigAction"] = request.ConfigAction;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfigScope))
            {
                query["ConfigScope"] = request.ConfigScope;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeGroupId))
            {
                query["NodeGroupId"] = request.NodeGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeId))
            {
                query["NodeId"] = request.NodeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateApplicationConfigs",
                Version = "2021-03-20",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateApplicationConfigsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request UpdateApplicationConfigsRequest
         * @return UpdateApplicationConfigsResponse
         */
        public UpdateApplicationConfigsResponse UpdateApplicationConfigs(UpdateApplicationConfigsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateApplicationConfigsWithOptions(request, runtime);
        }

        /**
         * @param request UpdateApplicationConfigsRequest
         * @return UpdateApplicationConfigsResponse
         */
        public async Task<UpdateApplicationConfigsResponse> UpdateApplicationConfigsAsync(UpdateApplicationConfigsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateApplicationConfigsWithOptionsAsync(request, runtime);
        }

    }
}
