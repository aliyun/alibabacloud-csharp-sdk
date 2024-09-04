// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.CS20151215.Models;

namespace AlibabaCloud.SDK.CS20151215
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._signatureAlgorithm = "v2";
            this._endpointRule = "regional";
            this._endpointMap = new Dictionary<string, string>
            {
                {"ap-northeast-2-pop", "cs.aliyuncs.com"},
                {"cn-beijing-finance-pop", "cs.aliyuncs.com"},
                {"cn-beijing-gov-1", "cs.aliyuncs.com"},
                {"cn-beijing-nu16-b01", "cs.aliyuncs.com"},
                {"cn-edge-1", "cs.aliyuncs.com"},
                {"cn-fujian", "cs.aliyuncs.com"},
                {"cn-haidian-cm12-c01", "cs.aliyuncs.com"},
                {"cn-hangzhou-bj-b01", "cs.aliyuncs.com"},
                {"cn-hangzhou-internal-prod-1", "cs.aliyuncs.com"},
                {"cn-hangzhou-internal-test-1", "cs.aliyuncs.com"},
                {"cn-hangzhou-internal-test-2", "cs.aliyuncs.com"},
                {"cn-hangzhou-internal-test-3", "cs.aliyuncs.com"},
                {"cn-hangzhou-test-306", "cs.aliyuncs.com"},
                {"cn-hongkong-finance-pop", "cs.aliyuncs.com"},
                {"cn-qingdao-nebula", "cs.aliyuncs.com"},
                {"cn-shanghai-et15-b01", "cs.aliyuncs.com"},
                {"cn-shanghai-et2-b01", "cs.aliyuncs.com"},
                {"cn-shanghai-inner", "cs.aliyuncs.com"},
                {"cn-shanghai-internal-test-1", "cs.aliyuncs.com"},
                {"cn-shenzhen-inner", "cs.aliyuncs.com"},
                {"cn-shenzhen-st4-d01", "cs.aliyuncs.com"},
                {"cn-shenzhen-su18-b01", "cs.aliyuncs.com"},
                {"cn-wuhan", "cs.aliyuncs.com"},
                {"cn-yushanfang", "cs.aliyuncs.com"},
                {"cn-zhangbei", "cs.aliyuncs.com"},
                {"cn-zhangbei-na61-b01", "cs.aliyuncs.com"},
                {"cn-zhangjiakou-na62-a01", "cs.aliyuncs.com"},
                {"cn-zhengzhou-nebula-1", "cs.aliyuncs.com"},
                {"eu-west-1-oxs", "cs.aliyuncs.com"},
                {"rus-west-1-pop", "cs.aliyuncs.com"},
            };
            CheckConfig(config);
            this._endpoint = GetEndpoint("cs", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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
         * @summary You can call the AttachInstances operation to add existing Elastic Compute Service (ECS) instances to a cluster.
         *
         * @param request AttachInstancesRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return AttachInstancesResponse
         */
        public AttachInstancesResponse AttachInstancesWithOptions(string ClusterId, AttachInstancesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CpuPolicy))
            {
                body["cpu_policy"] = request.CpuPolicy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FormatDisk))
            {
                body["format_disk"] = request.FormatDisk;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageId))
            {
                body["image_id"] = request.ImageId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Instances))
            {
                body["instances"] = request.Instances;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsEdgeWorker))
            {
                body["is_edge_worker"] = request.IsEdgeWorker;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeepInstanceName))
            {
                body["keep_instance_name"] = request.KeepInstanceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeyPair))
            {
                body["key_pair"] = request.KeyPair;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodepoolId))
            {
                body["nodepool_id"] = request.NodepoolId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Password))
            {
                body["password"] = request.Password;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RdsInstances))
            {
                body["rds_instances"] = request.RdsInstances;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Runtime))
            {
                body["runtime"] = request.Runtime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tags))
            {
                body["tags"] = request.Tags;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserData))
            {
                body["user_data"] = request.UserData;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AttachInstances",
                Version = "2015-12-15",
                Protocol = "HTTPS",
                Pathname = "/clusters/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId) + "/attach",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<AttachInstancesResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary You can call the AttachInstances operation to add existing Elastic Compute Service (ECS) instances to a cluster.
         *
         * @param request AttachInstancesRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return AttachInstancesResponse
         */
        public async Task<AttachInstancesResponse> AttachInstancesWithOptionsAsync(string ClusterId, AttachInstancesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CpuPolicy))
            {
                body["cpu_policy"] = request.CpuPolicy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FormatDisk))
            {
                body["format_disk"] = request.FormatDisk;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageId))
            {
                body["image_id"] = request.ImageId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Instances))
            {
                body["instances"] = request.Instances;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsEdgeWorker))
            {
                body["is_edge_worker"] = request.IsEdgeWorker;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeepInstanceName))
            {
                body["keep_instance_name"] = request.KeepInstanceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeyPair))
            {
                body["key_pair"] = request.KeyPair;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodepoolId))
            {
                body["nodepool_id"] = request.NodepoolId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Password))
            {
                body["password"] = request.Password;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RdsInstances))
            {
                body["rds_instances"] = request.RdsInstances;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Runtime))
            {
                body["runtime"] = request.Runtime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tags))
            {
                body["tags"] = request.Tags;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserData))
            {
                body["user_data"] = request.UserData;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AttachInstances",
                Version = "2015-12-15",
                Protocol = "HTTPS",
                Pathname = "/clusters/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId) + "/attach",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<AttachInstancesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary You can call the AttachInstances operation to add existing Elastic Compute Service (ECS) instances to a cluster.
         *
         * @param request AttachInstancesRequest
         * @return AttachInstancesResponse
         */
        public AttachInstancesResponse AttachInstances(string ClusterId, AttachInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return AttachInstancesWithOptions(ClusterId, request, headers, runtime);
        }

        /**
         * @summary You can call the AttachInstances operation to add existing Elastic Compute Service (ECS) instances to a cluster.
         *
         * @param request AttachInstancesRequest
         * @return AttachInstancesResponse
         */
        public async Task<AttachInstancesResponse> AttachInstancesAsync(string ClusterId, AttachInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await AttachInstancesWithOptionsAsync(ClusterId, request, headers, runtime);
        }

        /**
         * @summary Adds existing nodes to a specific node pool. You can add existing ECS instances to a specific node pool in a Container Service for Kubernetes (ACK) cluster as worker nodes. You can also add removed worker nodes back to the node pool.
         *
         * @param request AttachInstancesToNodePoolRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return AttachInstancesToNodePoolResponse
         */
        public AttachInstancesToNodePoolResponse AttachInstancesToNodePoolWithOptions(string ClusterId, string NodepoolId, AttachInstancesToNodePoolRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FormatDisk))
            {
                body["format_disk"] = request.FormatDisk;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Instances))
            {
                body["instances"] = request.Instances;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeepInstanceName))
            {
                body["keep_instance_name"] = request.KeepInstanceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Password))
            {
                body["password"] = request.Password;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AttachInstancesToNodePool",
                Version = "2015-12-15",
                Protocol = "HTTPS",
                Pathname = "/clusters/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId) + "/nodepools/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(NodepoolId) + "/attach",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<AttachInstancesToNodePoolResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Adds existing nodes to a specific node pool. You can add existing ECS instances to a specific node pool in a Container Service for Kubernetes (ACK) cluster as worker nodes. You can also add removed worker nodes back to the node pool.
         *
         * @param request AttachInstancesToNodePoolRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return AttachInstancesToNodePoolResponse
         */
        public async Task<AttachInstancesToNodePoolResponse> AttachInstancesToNodePoolWithOptionsAsync(string ClusterId, string NodepoolId, AttachInstancesToNodePoolRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FormatDisk))
            {
                body["format_disk"] = request.FormatDisk;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Instances))
            {
                body["instances"] = request.Instances;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeepInstanceName))
            {
                body["keep_instance_name"] = request.KeepInstanceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Password))
            {
                body["password"] = request.Password;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AttachInstancesToNodePool",
                Version = "2015-12-15",
                Protocol = "HTTPS",
                Pathname = "/clusters/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId) + "/nodepools/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(NodepoolId) + "/attach",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<AttachInstancesToNodePoolResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Adds existing nodes to a specific node pool. You can add existing ECS instances to a specific node pool in a Container Service for Kubernetes (ACK) cluster as worker nodes. You can also add removed worker nodes back to the node pool.
         *
         * @param request AttachInstancesToNodePoolRequest
         * @return AttachInstancesToNodePoolResponse
         */
        public AttachInstancesToNodePoolResponse AttachInstancesToNodePool(string ClusterId, string NodepoolId, AttachInstancesToNodePoolRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return AttachInstancesToNodePoolWithOptions(ClusterId, NodepoolId, request, headers, runtime);
        }

        /**
         * @summary Adds existing nodes to a specific node pool. You can add existing ECS instances to a specific node pool in a Container Service for Kubernetes (ACK) cluster as worker nodes. You can also add removed worker nodes back to the node pool.
         *
         * @param request AttachInstancesToNodePoolRequest
         * @return AttachInstancesToNodePoolResponse
         */
        public async Task<AttachInstancesToNodePoolResponse> AttachInstancesToNodePoolAsync(string ClusterId, string NodepoolId, AttachInstancesToNodePoolRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await AttachInstancesToNodePoolWithOptionsAsync(ClusterId, NodepoolId, request, headers, runtime);
        }

        /**
         * @deprecated OpenAPI CancelClusterUpgrade is deprecated
         *
         * @summary You can call the CancelClusterUpgrade operation to cancel the update of a cluster.
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CancelClusterUpgradeResponse
         */
        // Deprecated
        public CancelClusterUpgradeResponse CancelClusterUpgradeWithOptions(string ClusterId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CancelClusterUpgrade",
                Version = "2015-12-15",
                Protocol = "HTTPS",
                Pathname = "/api/v2/clusters/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId) + "/upgrade/cancel",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<CancelClusterUpgradeResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @deprecated OpenAPI CancelClusterUpgrade is deprecated
         *
         * @summary You can call the CancelClusterUpgrade operation to cancel the update of a cluster.
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CancelClusterUpgradeResponse
         */
        // Deprecated
        public async Task<CancelClusterUpgradeResponse> CancelClusterUpgradeWithOptionsAsync(string ClusterId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CancelClusterUpgrade",
                Version = "2015-12-15",
                Protocol = "HTTPS",
                Pathname = "/api/v2/clusters/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId) + "/upgrade/cancel",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<CancelClusterUpgradeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @deprecated OpenAPI CancelClusterUpgrade is deprecated
         *
         * @summary You can call the CancelClusterUpgrade operation to cancel the update of a cluster.
         *
         * @return CancelClusterUpgradeResponse
         */
        // Deprecated
        public CancelClusterUpgradeResponse CancelClusterUpgrade(string ClusterId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CancelClusterUpgradeWithOptions(ClusterId, headers, runtime);
        }

        /**
         * @deprecated OpenAPI CancelClusterUpgrade is deprecated
         *
         * @summary You can call the CancelClusterUpgrade operation to cancel the update of a cluster.
         *
         * @return CancelClusterUpgradeResponse
         */
        // Deprecated
        public async Task<CancelClusterUpgradeResponse> CancelClusterUpgradeAsync(string ClusterId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CancelClusterUpgradeWithOptionsAsync(ClusterId, headers, runtime);
        }

        /**
         * @deprecated OpenAPI CancelComponentUpgrade is deprecated
         *
         * @summary You can call the CancelComponentUpgrade operation to cancel the update of a component.
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CancelComponentUpgradeResponse
         */
        // Deprecated
        public CancelComponentUpgradeResponse CancelComponentUpgradeWithOptions(string clusterId, string componentId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CancelComponentUpgrade",
                Version = "2015-12-15",
                Protocol = "HTTPS",
                Pathname = "/clusters/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(clusterId) + "/components/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(componentId) + "/cancel",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<CancelComponentUpgradeResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @deprecated OpenAPI CancelComponentUpgrade is deprecated
         *
         * @summary You can call the CancelComponentUpgrade operation to cancel the update of a component.
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CancelComponentUpgradeResponse
         */
        // Deprecated
        public async Task<CancelComponentUpgradeResponse> CancelComponentUpgradeWithOptionsAsync(string clusterId, string componentId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CancelComponentUpgrade",
                Version = "2015-12-15",
                Protocol = "HTTPS",
                Pathname = "/clusters/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(clusterId) + "/components/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(componentId) + "/cancel",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<CancelComponentUpgradeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @deprecated OpenAPI CancelComponentUpgrade is deprecated
         *
         * @summary You can call the CancelComponentUpgrade operation to cancel the update of a component.
         *
         * @return CancelComponentUpgradeResponse
         */
        // Deprecated
        public CancelComponentUpgradeResponse CancelComponentUpgrade(string clusterId, string componentId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CancelComponentUpgradeWithOptions(clusterId, componentId, headers, runtime);
        }

        /**
         * @deprecated OpenAPI CancelComponentUpgrade is deprecated
         *
         * @summary You can call the CancelComponentUpgrade operation to cancel the update of a component.
         *
         * @return CancelComponentUpgradeResponse
         */
        // Deprecated
        public async Task<CancelComponentUpgradeResponse> CancelComponentUpgradeAsync(string clusterId, string componentId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CancelComponentUpgradeWithOptionsAsync(clusterId, componentId, headers, runtime);
        }

        /**
         * @summary You can call the CancelOperationPlan operation to cancel a pending auto O\\\\\\&M plan.
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CancelOperationPlanResponse
         */
        public CancelOperationPlanResponse CancelOperationPlanWithOptions(string planId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CancelOperationPlan",
                Version = "2015-12-15",
                Protocol = "HTTPS",
                Pathname = "/operation/plans/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(planId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CancelOperationPlanResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary You can call the CancelOperationPlan operation to cancel a pending auto O\\\\\\&M plan.
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CancelOperationPlanResponse
         */
        public async Task<CancelOperationPlanResponse> CancelOperationPlanWithOptionsAsync(string planId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CancelOperationPlan",
                Version = "2015-12-15",
                Protocol = "HTTPS",
                Pathname = "/operation/plans/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(planId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CancelOperationPlanResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary You can call the CancelOperationPlan operation to cancel a pending auto O\\\\\\&M plan.
         *
         * @return CancelOperationPlanResponse
         */
        public CancelOperationPlanResponse CancelOperationPlan(string planId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CancelOperationPlanWithOptions(planId, headers, runtime);
        }

        /**
         * @summary You can call the CancelOperationPlan operation to cancel a pending auto O\\\\\\&M plan.
         *
         * @return CancelOperationPlanResponse
         */
        public async Task<CancelOperationPlanResponse> CancelOperationPlanAsync(string planId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CancelOperationPlanWithOptionsAsync(planId, headers, runtime);
        }

        /**
         * @summary Cancels the execution of a cluster task.
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CancelTaskResponse
         */
        public CancelTaskResponse CancelTaskWithOptions(string taskId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CancelTask",
                Version = "2015-12-15",
                Protocol = "HTTPS",
                Pathname = "/tasks/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(taskId) + "/cancel",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<CancelTaskResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Cancels the execution of a cluster task.
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CancelTaskResponse
         */
        public async Task<CancelTaskResponse> CancelTaskWithOptionsAsync(string taskId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CancelTask",
                Version = "2015-12-15",
                Protocol = "HTTPS",
                Pathname = "/tasks/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(taskId) + "/cancel",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<CancelTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Cancels the execution of a cluster task.
         *
         * @return CancelTaskResponse
         */
        public CancelTaskResponse CancelTask(string taskId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CancelTaskWithOptions(taskId, headers, runtime);
        }

        /**
         * @summary Cancels the execution of a cluster task.
         *
         * @return CancelTaskResponse
         */
        public async Task<CancelTaskResponse> CancelTaskAsync(string taskId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CancelTaskWithOptionsAsync(taskId, headers, runtime);
        }

        /**
         * @deprecated OpenAPI CancelWorkflow is deprecated
         *
         * @summary You can call the CancelWorkflow operation to cancel an ongoing workflow.
         *
         * @param request CancelWorkflowRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CancelWorkflowResponse
         */
        // Deprecated
        public CancelWorkflowResponse CancelWorkflowWithOptions(string workflowName, CancelWorkflowRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Action))
            {
                body["action"] = request.Action;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CancelWorkflow",
                Version = "2015-12-15",
                Protocol = "HTTPS",
                Pathname = "/gs/workflow/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workflowName),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<CancelWorkflowResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @deprecated OpenAPI CancelWorkflow is deprecated
         *
         * @summary You can call the CancelWorkflow operation to cancel an ongoing workflow.
         *
         * @param request CancelWorkflowRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CancelWorkflowResponse
         */
        // Deprecated
        public async Task<CancelWorkflowResponse> CancelWorkflowWithOptionsAsync(string workflowName, CancelWorkflowRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Action))
            {
                body["action"] = request.Action;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CancelWorkflow",
                Version = "2015-12-15",
                Protocol = "HTTPS",
                Pathname = "/gs/workflow/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workflowName),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<CancelWorkflowResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @deprecated OpenAPI CancelWorkflow is deprecated
         *
         * @summary You can call the CancelWorkflow operation to cancel an ongoing workflow.
         *
         * @param request CancelWorkflowRequest
         * @return CancelWorkflowResponse
         */
        // Deprecated
        public CancelWorkflowResponse CancelWorkflow(string workflowName, CancelWorkflowRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CancelWorkflowWithOptions(workflowName, request, headers, runtime);
        }

        /**
         * @deprecated OpenAPI CancelWorkflow is deprecated
         *
         * @summary You can call the CancelWorkflow operation to cancel an ongoing workflow.
         *
         * @param request CancelWorkflowRequest
         * @return CancelWorkflowResponse
         */
        // Deprecated
        public async Task<CancelWorkflowResponse> CancelWorkflowAsync(string workflowName, CancelWorkflowRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CancelWorkflowWithOptionsAsync(workflowName, request, headers, runtime);
        }

        /**
         * @summary Queries the current log configuration of control plane components, including the log retention period and the log collection component. Container Service for Kubernetes (ACK) managed clusters can collect the logs of control plane components and deliver the logs to projects in Simple Log Service. These control plane components include Kube API Server, Kube Scheduler, Kube Controller Manager, and Cloud Controller Manager.
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CheckControlPlaneLogEnableResponse
         */
        public CheckControlPlaneLogEnableResponse CheckControlPlaneLogEnableWithOptions(string ClusterId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CheckControlPlaneLogEnable",
                Version = "2015-12-15",
                Protocol = "HTTPS",
                Pathname = "/clusters/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId) + "/controlplanelog",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CheckControlPlaneLogEnableResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the current log configuration of control plane components, including the log retention period and the log collection component. Container Service for Kubernetes (ACK) managed clusters can collect the logs of control plane components and deliver the logs to projects in Simple Log Service. These control plane components include Kube API Server, Kube Scheduler, Kube Controller Manager, and Cloud Controller Manager.
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CheckControlPlaneLogEnableResponse
         */
        public async Task<CheckControlPlaneLogEnableResponse> CheckControlPlaneLogEnableWithOptionsAsync(string ClusterId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CheckControlPlaneLogEnable",
                Version = "2015-12-15",
                Protocol = "HTTPS",
                Pathname = "/clusters/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId) + "/controlplanelog",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CheckControlPlaneLogEnableResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the current log configuration of control plane components, including the log retention period and the log collection component. Container Service for Kubernetes (ACK) managed clusters can collect the logs of control plane components and deliver the logs to projects in Simple Log Service. These control plane components include Kube API Server, Kube Scheduler, Kube Controller Manager, and Cloud Controller Manager.
         *
         * @return CheckControlPlaneLogEnableResponse
         */
        public CheckControlPlaneLogEnableResponse CheckControlPlaneLogEnable(string ClusterId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CheckControlPlaneLogEnableWithOptions(ClusterId, headers, runtime);
        }

        /**
         * @summary Queries the current log configuration of control plane components, including the log retention period and the log collection component. Container Service for Kubernetes (ACK) managed clusters can collect the logs of control plane components and deliver the logs to projects in Simple Log Service. These control plane components include Kube API Server, Kube Scheduler, Kube Controller Manager, and Cloud Controller Manager.
         *
         * @return CheckControlPlaneLogEnableResponse
         */
        public async Task<CheckControlPlaneLogEnableResponse> CheckControlPlaneLogEnableAsync(string ClusterId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CheckControlPlaneLogEnableWithOptionsAsync(ClusterId, headers, runtime);
        }

        /**
         * @summary 检查是否授权指定服务角色
         *
         * @param request CheckServiceRoleRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CheckServiceRoleResponse
         */
        public CheckServiceRoleResponse CheckServiceRoleWithOptions(CheckServiceRoleRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Roles))
            {
                body["roles"] = request.Roles;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CheckServiceRole",
                Version = "2015-12-15",
                Protocol = "HTTPS",
                Pathname = "/ram/check-service-role",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CheckServiceRoleResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 检查是否授权指定服务角色
         *
         * @param request CheckServiceRoleRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CheckServiceRoleResponse
         */
        public async Task<CheckServiceRoleResponse> CheckServiceRoleWithOptionsAsync(CheckServiceRoleRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Roles))
            {
                body["roles"] = request.Roles;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CheckServiceRole",
                Version = "2015-12-15",
                Protocol = "HTTPS",
                Pathname = "/ram/check-service-role",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CheckServiceRoleResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 检查是否授权指定服务角色
         *
         * @param request CheckServiceRoleRequest
         * @return CheckServiceRoleResponse
         */
        public CheckServiceRoleResponse CheckServiceRole(CheckServiceRoleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CheckServiceRoleWithOptions(request, headers, runtime);
        }

        /**
         * @summary 检查是否授权指定服务角色
         *
         * @param request CheckServiceRoleRequest
         * @return CheckServiceRoleResponse
         */
        public async Task<CheckServiceRoleResponse> CheckServiceRoleAsync(CheckServiceRoleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CheckServiceRoleWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary You can call the CleanClusterUserPermissions operation to delete kubeconfig files that may pose potential risks from a user and revoke Role-Based Access Control (RBAC) permissions on a cluster.
         *
         * @description > 
         * *   To call this operation, make sure that you have the AliyunCSFullAccess permissions.
         * *   You cannot revoke the permissions of an Alibaba Cloud account.
         * *   You cannot revoke the permissions of the account that you use to call this operation.
         *
         * @param request CleanClusterUserPermissionsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CleanClusterUserPermissionsResponse
         */
        public CleanClusterUserPermissionsResponse CleanClusterUserPermissionsWithOptions(string ClusterId, string Uid, CleanClusterUserPermissionsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Force))
            {
                query["Force"] = request.Force;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CleanClusterUserPermissions",
                Version = "2015-12-15",
                Protocol = "HTTPS",
                Pathname = "/cluster/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId) + "/user/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(Uid) + "/permissions",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<CleanClusterUserPermissionsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary You can call the CleanClusterUserPermissions operation to delete kubeconfig files that may pose potential risks from a user and revoke Role-Based Access Control (RBAC) permissions on a cluster.
         *
         * @description > 
         * *   To call this operation, make sure that you have the AliyunCSFullAccess permissions.
         * *   You cannot revoke the permissions of an Alibaba Cloud account.
         * *   You cannot revoke the permissions of the account that you use to call this operation.
         *
         * @param request CleanClusterUserPermissionsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CleanClusterUserPermissionsResponse
         */
        public async Task<CleanClusterUserPermissionsResponse> CleanClusterUserPermissionsWithOptionsAsync(string ClusterId, string Uid, CleanClusterUserPermissionsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Force))
            {
                query["Force"] = request.Force;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CleanClusterUserPermissions",
                Version = "2015-12-15",
                Protocol = "HTTPS",
                Pathname = "/cluster/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId) + "/user/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(Uid) + "/permissions",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<CleanClusterUserPermissionsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary You can call the CleanClusterUserPermissions operation to delete kubeconfig files that may pose potential risks from a user and revoke Role-Based Access Control (RBAC) permissions on a cluster.
         *
         * @description > 
         * *   To call this operation, make sure that you have the AliyunCSFullAccess permissions.
         * *   You cannot revoke the permissions of an Alibaba Cloud account.
         * *   You cannot revoke the permissions of the account that you use to call this operation.
         *
         * @param request CleanClusterUserPermissionsRequest
         * @return CleanClusterUserPermissionsResponse
         */
        public CleanClusterUserPermissionsResponse CleanClusterUserPermissions(string ClusterId, string Uid, CleanClusterUserPermissionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CleanClusterUserPermissionsWithOptions(ClusterId, Uid, request, headers, runtime);
        }

        /**
         * @summary You can call the CleanClusterUserPermissions operation to delete kubeconfig files that may pose potential risks from a user and revoke Role-Based Access Control (RBAC) permissions on a cluster.
         *
         * @description > 
         * *   To call this operation, make sure that you have the AliyunCSFullAccess permissions.
         * *   You cannot revoke the permissions of an Alibaba Cloud account.
         * *   You cannot revoke the permissions of the account that you use to call this operation.
         *
         * @param request CleanClusterUserPermissionsRequest
         * @return CleanClusterUserPermissionsResponse
         */
        public async Task<CleanClusterUserPermissionsResponse> CleanClusterUserPermissionsAsync(string ClusterId, string Uid, CleanClusterUserPermissionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CleanClusterUserPermissionsWithOptionsAsync(ClusterId, Uid, request, headers, runtime);
        }

        /**
         * @summary You can call the CleanUserPermissions operation to delete the kubeconfig files of the specified users and revoke the relevant Role-Based Access Control (RBAC) permissions. This API operation is suitable for scenarios where employees have resigned or the accounts of employees are locked.
         *
         * @description >- To call this operation, make sure that you have the AliyunCSFullAccess permissions.
         * >- You cannot revoke the permissions of an Alibaba Cloud account.
         * >- You cannot revoke the permissions of the account that you use to call this operation.
         *
         * @param tmpReq CleanUserPermissionsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CleanUserPermissionsResponse
         */
        public CleanUserPermissionsResponse CleanUserPermissionsWithOptions(string Uid, CleanUserPermissionsRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CleanUserPermissionsShrinkRequest request = new CleanUserPermissionsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ClusterIds))
            {
                request.ClusterIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ClusterIds, "ClusterIds", "simple");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterIdsShrink))
            {
                query["ClusterIds"] = request.ClusterIdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Force))
            {
                query["Force"] = request.Force;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CleanUserPermissions",
                Version = "2015-12-15",
                Protocol = "HTTPS",
                Pathname = "/users/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(Uid) + "/permissions",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CleanUserPermissionsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary You can call the CleanUserPermissions operation to delete the kubeconfig files of the specified users and revoke the relevant Role-Based Access Control (RBAC) permissions. This API operation is suitable for scenarios where employees have resigned or the accounts of employees are locked.
         *
         * @description >- To call this operation, make sure that you have the AliyunCSFullAccess permissions.
         * >- You cannot revoke the permissions of an Alibaba Cloud account.
         * >- You cannot revoke the permissions of the account that you use to call this operation.
         *
         * @param tmpReq CleanUserPermissionsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CleanUserPermissionsResponse
         */
        public async Task<CleanUserPermissionsResponse> CleanUserPermissionsWithOptionsAsync(string Uid, CleanUserPermissionsRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CleanUserPermissionsShrinkRequest request = new CleanUserPermissionsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ClusterIds))
            {
                request.ClusterIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ClusterIds, "ClusterIds", "simple");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterIdsShrink))
            {
                query["ClusterIds"] = request.ClusterIdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Force))
            {
                query["Force"] = request.Force;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CleanUserPermissions",
                Version = "2015-12-15",
                Protocol = "HTTPS",
                Pathname = "/users/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(Uid) + "/permissions",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CleanUserPermissionsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary You can call the CleanUserPermissions operation to delete the kubeconfig files of the specified users and revoke the relevant Role-Based Access Control (RBAC) permissions. This API operation is suitable for scenarios where employees have resigned or the accounts of employees are locked.
         *
         * @description >- To call this operation, make sure that you have the AliyunCSFullAccess permissions.
         * >- You cannot revoke the permissions of an Alibaba Cloud account.
         * >- You cannot revoke the permissions of the account that you use to call this operation.
         *
         * @param request CleanUserPermissionsRequest
         * @return CleanUserPermissionsResponse
         */
        public CleanUserPermissionsResponse CleanUserPermissions(string Uid, CleanUserPermissionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CleanUserPermissionsWithOptions(Uid, request, headers, runtime);
        }

        /**
         * @summary You can call the CleanUserPermissions operation to delete the kubeconfig files of the specified users and revoke the relevant Role-Based Access Control (RBAC) permissions. This API operation is suitable for scenarios where employees have resigned or the accounts of employees are locked.
         *
         * @description >- To call this operation, make sure that you have the AliyunCSFullAccess permissions.
         * >- You cannot revoke the permissions of an Alibaba Cloud account.
         * >- You cannot revoke the permissions of the account that you use to call this operation.
         *
         * @param request CleanUserPermissionsRequest
         * @return CleanUserPermissionsResponse
         */
        public async Task<CleanUserPermissionsResponse> CleanUserPermissionsAsync(string Uid, CleanUserPermissionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CleanUserPermissionsWithOptionsAsync(Uid, request, headers, runtime);
        }

        /**
         * @summary Creates a scaling configuration to allow the system to scale resources based on the given scaling rules. When you create a scaling configuration, you can specify the scaling metrics, thresholds, scaling order, and scaling interval.
         *
         * @param request CreateAutoscalingConfigRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateAutoscalingConfigResponse
         */
        public CreateAutoscalingConfigResponse CreateAutoscalingConfigWithOptions(string ClusterId, CreateAutoscalingConfigRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CoolDownDuration))
            {
                body["cool_down_duration"] = request.CoolDownDuration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DaemonsetEvictionForNodes))
            {
                body["daemonset_eviction_for_nodes"] = request.DaemonsetEvictionForNodes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Expander))
            {
                body["expander"] = request.Expander;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GpuUtilizationThreshold))
            {
                body["gpu_utilization_threshold"] = request.GpuUtilizationThreshold;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxGracefulTerminationSec))
            {
                body["max_graceful_termination_sec"] = request.MaxGracefulTerminationSec;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MinReplicaCount))
            {
                body["min_replica_count"] = request.MinReplicaCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecycleNodeDeletionEnabled))
            {
                body["recycle_node_deletion_enabled"] = request.RecycleNodeDeletionEnabled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScaleDownEnabled))
            {
                body["scale_down_enabled"] = request.ScaleDownEnabled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScaleUpFromZero))
            {
                body["scale_up_from_zero"] = request.ScaleUpFromZero;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScanInterval))
            {
                body["scan_interval"] = request.ScanInterval;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SkipNodesWithLocalStorage))
            {
                body["skip_nodes_with_local_storage"] = request.SkipNodesWithLocalStorage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SkipNodesWithSystemPods))
            {
                body["skip_nodes_with_system_pods"] = request.SkipNodesWithSystemPods;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnneededDuration))
            {
                body["unneeded_duration"] = request.UnneededDuration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UtilizationThreshold))
            {
                body["utilization_threshold"] = request.UtilizationThreshold;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateAutoscalingConfig",
                Version = "2015-12-15",
                Protocol = "HTTPS",
                Pathname = "/cluster/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId) + "/autoscale/config/",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<CreateAutoscalingConfigResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Creates a scaling configuration to allow the system to scale resources based on the given scaling rules. When you create a scaling configuration, you can specify the scaling metrics, thresholds, scaling order, and scaling interval.
         *
         * @param request CreateAutoscalingConfigRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateAutoscalingConfigResponse
         */
        public async Task<CreateAutoscalingConfigResponse> CreateAutoscalingConfigWithOptionsAsync(string ClusterId, CreateAutoscalingConfigRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CoolDownDuration))
            {
                body["cool_down_duration"] = request.CoolDownDuration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DaemonsetEvictionForNodes))
            {
                body["daemonset_eviction_for_nodes"] = request.DaemonsetEvictionForNodes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Expander))
            {
                body["expander"] = request.Expander;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GpuUtilizationThreshold))
            {
                body["gpu_utilization_threshold"] = request.GpuUtilizationThreshold;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxGracefulTerminationSec))
            {
                body["max_graceful_termination_sec"] = request.MaxGracefulTerminationSec;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MinReplicaCount))
            {
                body["min_replica_count"] = request.MinReplicaCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecycleNodeDeletionEnabled))
            {
                body["recycle_node_deletion_enabled"] = request.RecycleNodeDeletionEnabled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScaleDownEnabled))
            {
                body["scale_down_enabled"] = request.ScaleDownEnabled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScaleUpFromZero))
            {
                body["scale_up_from_zero"] = request.ScaleUpFromZero;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScanInterval))
            {
                body["scan_interval"] = request.ScanInterval;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SkipNodesWithLocalStorage))
            {
                body["skip_nodes_with_local_storage"] = request.SkipNodesWithLocalStorage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SkipNodesWithSystemPods))
            {
                body["skip_nodes_with_system_pods"] = request.SkipNodesWithSystemPods;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UnneededDuration))
            {
                body["unneeded_duration"] = request.UnneededDuration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UtilizationThreshold))
            {
                body["utilization_threshold"] = request.UtilizationThreshold;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateAutoscalingConfig",
                Version = "2015-12-15",
                Protocol = "HTTPS",
                Pathname = "/cluster/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId) + "/autoscale/config/",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<CreateAutoscalingConfigResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Creates a scaling configuration to allow the system to scale resources based on the given scaling rules. When you create a scaling configuration, you can specify the scaling metrics, thresholds, scaling order, and scaling interval.
         *
         * @param request CreateAutoscalingConfigRequest
         * @return CreateAutoscalingConfigResponse
         */
        public CreateAutoscalingConfigResponse CreateAutoscalingConfig(string ClusterId, CreateAutoscalingConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateAutoscalingConfigWithOptions(ClusterId, request, headers, runtime);
        }

        /**
         * @summary Creates a scaling configuration to allow the system to scale resources based on the given scaling rules. When you create a scaling configuration, you can specify the scaling metrics, thresholds, scaling order, and scaling interval.
         *
         * @param request CreateAutoscalingConfigRequest
         * @return CreateAutoscalingConfigResponse
         */
        public async Task<CreateAutoscalingConfigResponse> CreateAutoscalingConfigAsync(string ClusterId, CreateAutoscalingConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateAutoscalingConfigWithOptionsAsync(ClusterId, request, headers, runtime);
        }

        /**
         * @summary You can call the CreateCluster operation to create a Container Service for Kubernetes (ACK) cluster. ACK clusters include ACK managed clusters, ACK dedicated clusters, ACK Serverless clusters, ACK Edge clusters, ACK clusters that support sandboxed containers, and registered clusters. For more information about how to create different types of ACK clusters, see the following usage notes.
         *
         * @description This topic describes all parameters for creating an ACK cluster. You can create the following types of ACK clusters.
         * *   [Create an ACK managed cluster](https://help.aliyun.com/document_detail/90776.html)
         * *   [Create an ACK dedicated cluster](https://help.aliyun.com/document_detail/197620.html)
         * *   [Create an ACK Serverless cluster](https://help.aliyun.com/document_detail/144246.html)
         * *   [Create an ACK Edge cluster](https://help.aliyun.com/document_detail/128204.html)
         * *   [Create an ACK Basic cluster that supports sandboxed containers](https://help.aliyun.com/document_detail/196321.html)
         * *   [Create an ACK Pro cluster that supports sandboxed containers](https://help.aliyun.com/document_detail/140623.html)
         *
         * @param request CreateClusterRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateClusterResponse
         */
        public CreateClusterResponse CreateClusterWithOptions(CreateClusterRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessControlList))
            {
                body["access_control_list"] = request.AccessControlList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Addons))
            {
                body["addons"] = request.Addons;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApiAudiences))
            {
                body["api_audiences"] = request.ApiAudiences;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChargeType))
            {
                body["charge_type"] = request.ChargeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CisEnabled))
            {
                body["cis_enabled"] = request.CisEnabled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CloudMonitorFlags))
            {
                body["cloud_monitor_flags"] = request.CloudMonitorFlags;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterDomain))
            {
                body["cluster_domain"] = request.ClusterDomain;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterSpec))
            {
                body["cluster_spec"] = request.ClusterSpec;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterType))
            {
                body["cluster_type"] = request.ClusterType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContainerCidr))
            {
                body["container_cidr"] = request.ContainerCidr;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ControlplaneLogComponents))
            {
                body["controlplane_log_components"] = request.ControlplaneLogComponents;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ControlplaneLogProject))
            {
                body["controlplane_log_project"] = request.ControlplaneLogProject;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ControlplaneLogTtl))
            {
                body["controlplane_log_ttl"] = request.ControlplaneLogTtl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CpuPolicy))
            {
                body["cpu_policy"] = request.CpuPolicy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomSan))
            {
                body["custom_san"] = request.CustomSan;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeletionProtection))
            {
                body["deletion_protection"] = request.DeletionProtection;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisableRollback))
            {
                body["disable_rollback"] = request.DisableRollback;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableRrsa))
            {
                body["enable_rrsa"] = request.EnableRrsa;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EncryptionProviderKey))
            {
                body["encryption_provider_key"] = request.EncryptionProviderKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndpointPublicAccess))
            {
                body["endpoint_public_access"] = request.EndpointPublicAccess;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FormatDisk))
            {
                body["format_disk"] = request.FormatDisk;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageId))
            {
                body["image_id"] = request.ImageId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageType))
            {
                body["image_type"] = request.ImageType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Instances))
            {
                body["instances"] = request.Instances;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IpStack))
            {
                body["ip_stack"] = request.IpStack;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsEnterpriseSecurityGroup))
            {
                body["is_enterprise_security_group"] = request.IsEnterpriseSecurityGroup;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeepInstanceName))
            {
                body["keep_instance_name"] = request.KeepInstanceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeyPair))
            {
                body["key_pair"] = request.KeyPair;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KubernetesVersion))
            {
                body["kubernetes_version"] = request.KubernetesVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoadBalancerId))
            {
                body["load_balancer_id"] = request.LoadBalancerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoadBalancerSpec))
            {
                body["load_balancer_spec"] = request.LoadBalancerSpec;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoggingType))
            {
                body["logging_type"] = request.LoggingType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoginPassword))
            {
                body["login_password"] = request.LoginPassword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MasterAutoRenew))
            {
                body["master_auto_renew"] = request.MasterAutoRenew;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MasterAutoRenewPeriod))
            {
                body["master_auto_renew_period"] = request.MasterAutoRenewPeriod;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MasterCount))
            {
                body["master_count"] = request.MasterCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MasterInstanceChargeType))
            {
                body["master_instance_charge_type"] = request.MasterInstanceChargeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MasterInstanceTypes))
            {
                body["master_instance_types"] = request.MasterInstanceTypes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MasterPeriod))
            {
                body["master_period"] = request.MasterPeriod;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MasterPeriodUnit))
            {
                body["master_period_unit"] = request.MasterPeriodUnit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MasterSystemDiskCategory))
            {
                body["master_system_disk_category"] = request.MasterSystemDiskCategory;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MasterSystemDiskPerformanceLevel))
            {
                body["master_system_disk_performance_level"] = request.MasterSystemDiskPerformanceLevel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MasterSystemDiskSize))
            {
                body["master_system_disk_size"] = request.MasterSystemDiskSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MasterSystemDiskSnapshotPolicyId))
            {
                body["master_system_disk_snapshot_policy_id"] = request.MasterSystemDiskSnapshotPolicyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MasterVswitchIds))
            {
                body["master_vswitch_ids"] = request.MasterVswitchIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NatGateway))
            {
                body["nat_gateway"] = request.NatGateway;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeCidrMask))
            {
                body["node_cidr_mask"] = request.NodeCidrMask;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeNameMode))
            {
                body["node_name_mode"] = request.NodeNameMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodePortRange))
            {
                body["node_port_range"] = request.NodePortRange;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Nodepools))
            {
                body["nodepools"] = request.Nodepools;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NumOfNodes))
            {
                body["num_of_nodes"] = request.NumOfNodes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OsType))
            {
                body["os_type"] = request.OsType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Period))
            {
                body["period"] = request.Period;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PeriodUnit))
            {
                body["period_unit"] = request.PeriodUnit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Platform))
            {
                body["platform"] = request.Platform;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PodVswitchIds))
            {
                body["pod_vswitch_ids"] = request.PodVswitchIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Profile))
            {
                body["profile"] = request.Profile;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProxyMode))
            {
                body["proxy_mode"] = request.ProxyMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RdsInstances))
            {
                body["rds_instances"] = request.RdsInstances;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["region_id"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                body["resource_group_id"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Runtime))
            {
                body["runtime"] = request.Runtime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityGroupId))
            {
                body["security_group_id"] = request.SecurityGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityHardeningOs))
            {
                body["security_hardening_os"] = request.SecurityHardeningOs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceAccountIssuer))
            {
                body["service_account_issuer"] = request.ServiceAccountIssuer;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceCidr))
            {
                body["service_cidr"] = request.ServiceCidr;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceDiscoveryTypes))
            {
                body["service_discovery_types"] = request.ServiceDiscoveryTypes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SnatEntry))
            {
                body["snat_entry"] = request.SnatEntry;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SocEnabled))
            {
                body["soc_enabled"] = request.SocEnabled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SshFlags))
            {
                body["ssh_flags"] = request.SshFlags;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tags))
            {
                body["tags"] = request.Tags;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Taints))
            {
                body["taints"] = request.Taints;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TimeoutMins))
            {
                body["timeout_mins"] = request.TimeoutMins;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Timezone))
            {
                body["timezone"] = request.Timezone;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserCa))
            {
                body["user_ca"] = request.UserCa;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserData))
            {
                body["user_data"] = request.UserData;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Vpcid))
            {
                body["vpcid"] = request.Vpcid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VswitchIds))
            {
                body["vswitch_ids"] = request.VswitchIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkerAutoRenew))
            {
                body["worker_auto_renew"] = request.WorkerAutoRenew;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkerAutoRenewPeriod))
            {
                body["worker_auto_renew_period"] = request.WorkerAutoRenewPeriod;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkerDataDisks))
            {
                body["worker_data_disks"] = request.WorkerDataDisks;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkerInstanceChargeType))
            {
                body["worker_instance_charge_type"] = request.WorkerInstanceChargeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkerInstanceTypes))
            {
                body["worker_instance_types"] = request.WorkerInstanceTypes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkerPeriod))
            {
                body["worker_period"] = request.WorkerPeriod;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkerPeriodUnit))
            {
                body["worker_period_unit"] = request.WorkerPeriodUnit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkerSystemDiskCategory))
            {
                body["worker_system_disk_category"] = request.WorkerSystemDiskCategory;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkerSystemDiskPerformanceLevel))
            {
                body["worker_system_disk_performance_level"] = request.WorkerSystemDiskPerformanceLevel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkerSystemDiskSize))
            {
                body["worker_system_disk_size"] = request.WorkerSystemDiskSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkerSystemDiskSnapshotPolicyId))
            {
                body["worker_system_disk_snapshot_policy_id"] = request.WorkerSystemDiskSnapshotPolicyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkerVswitchIds))
            {
                body["worker_vswitch_ids"] = request.WorkerVswitchIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ZoneId))
            {
                body["zone_id"] = request.ZoneId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateCluster",
                Version = "2015-12-15",
                Protocol = "HTTPS",
                Pathname = "/clusters",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateClusterResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary You can call the CreateCluster operation to create a Container Service for Kubernetes (ACK) cluster. ACK clusters include ACK managed clusters, ACK dedicated clusters, ACK Serverless clusters, ACK Edge clusters, ACK clusters that support sandboxed containers, and registered clusters. For more information about how to create different types of ACK clusters, see the following usage notes.
         *
         * @description This topic describes all parameters for creating an ACK cluster. You can create the following types of ACK clusters.
         * *   [Create an ACK managed cluster](https://help.aliyun.com/document_detail/90776.html)
         * *   [Create an ACK dedicated cluster](https://help.aliyun.com/document_detail/197620.html)
         * *   [Create an ACK Serverless cluster](https://help.aliyun.com/document_detail/144246.html)
         * *   [Create an ACK Edge cluster](https://help.aliyun.com/document_detail/128204.html)
         * *   [Create an ACK Basic cluster that supports sandboxed containers](https://help.aliyun.com/document_detail/196321.html)
         * *   [Create an ACK Pro cluster that supports sandboxed containers](https://help.aliyun.com/document_detail/140623.html)
         *
         * @param request CreateClusterRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateClusterResponse
         */
        public async Task<CreateClusterResponse> CreateClusterWithOptionsAsync(CreateClusterRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessControlList))
            {
                body["access_control_list"] = request.AccessControlList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Addons))
            {
                body["addons"] = request.Addons;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApiAudiences))
            {
                body["api_audiences"] = request.ApiAudiences;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChargeType))
            {
                body["charge_type"] = request.ChargeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CisEnabled))
            {
                body["cis_enabled"] = request.CisEnabled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CloudMonitorFlags))
            {
                body["cloud_monitor_flags"] = request.CloudMonitorFlags;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterDomain))
            {
                body["cluster_domain"] = request.ClusterDomain;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterSpec))
            {
                body["cluster_spec"] = request.ClusterSpec;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterType))
            {
                body["cluster_type"] = request.ClusterType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContainerCidr))
            {
                body["container_cidr"] = request.ContainerCidr;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ControlplaneLogComponents))
            {
                body["controlplane_log_components"] = request.ControlplaneLogComponents;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ControlplaneLogProject))
            {
                body["controlplane_log_project"] = request.ControlplaneLogProject;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ControlplaneLogTtl))
            {
                body["controlplane_log_ttl"] = request.ControlplaneLogTtl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CpuPolicy))
            {
                body["cpu_policy"] = request.CpuPolicy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomSan))
            {
                body["custom_san"] = request.CustomSan;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeletionProtection))
            {
                body["deletion_protection"] = request.DeletionProtection;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisableRollback))
            {
                body["disable_rollback"] = request.DisableRollback;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableRrsa))
            {
                body["enable_rrsa"] = request.EnableRrsa;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EncryptionProviderKey))
            {
                body["encryption_provider_key"] = request.EncryptionProviderKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndpointPublicAccess))
            {
                body["endpoint_public_access"] = request.EndpointPublicAccess;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FormatDisk))
            {
                body["format_disk"] = request.FormatDisk;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageId))
            {
                body["image_id"] = request.ImageId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageType))
            {
                body["image_type"] = request.ImageType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Instances))
            {
                body["instances"] = request.Instances;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IpStack))
            {
                body["ip_stack"] = request.IpStack;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsEnterpriseSecurityGroup))
            {
                body["is_enterprise_security_group"] = request.IsEnterpriseSecurityGroup;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeepInstanceName))
            {
                body["keep_instance_name"] = request.KeepInstanceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeyPair))
            {
                body["key_pair"] = request.KeyPair;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KubernetesVersion))
            {
                body["kubernetes_version"] = request.KubernetesVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoadBalancerId))
            {
                body["load_balancer_id"] = request.LoadBalancerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoadBalancerSpec))
            {
                body["load_balancer_spec"] = request.LoadBalancerSpec;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoggingType))
            {
                body["logging_type"] = request.LoggingType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoginPassword))
            {
                body["login_password"] = request.LoginPassword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MasterAutoRenew))
            {
                body["master_auto_renew"] = request.MasterAutoRenew;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MasterAutoRenewPeriod))
            {
                body["master_auto_renew_period"] = request.MasterAutoRenewPeriod;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MasterCount))
            {
                body["master_count"] = request.MasterCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MasterInstanceChargeType))
            {
                body["master_instance_charge_type"] = request.MasterInstanceChargeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MasterInstanceTypes))
            {
                body["master_instance_types"] = request.MasterInstanceTypes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MasterPeriod))
            {
                body["master_period"] = request.MasterPeriod;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MasterPeriodUnit))
            {
                body["master_period_unit"] = request.MasterPeriodUnit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MasterSystemDiskCategory))
            {
                body["master_system_disk_category"] = request.MasterSystemDiskCategory;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MasterSystemDiskPerformanceLevel))
            {
                body["master_system_disk_performance_level"] = request.MasterSystemDiskPerformanceLevel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MasterSystemDiskSize))
            {
                body["master_system_disk_size"] = request.MasterSystemDiskSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MasterSystemDiskSnapshotPolicyId))
            {
                body["master_system_disk_snapshot_policy_id"] = request.MasterSystemDiskSnapshotPolicyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MasterVswitchIds))
            {
                body["master_vswitch_ids"] = request.MasterVswitchIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NatGateway))
            {
                body["nat_gateway"] = request.NatGateway;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeCidrMask))
            {
                body["node_cidr_mask"] = request.NodeCidrMask;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeNameMode))
            {
                body["node_name_mode"] = request.NodeNameMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodePortRange))
            {
                body["node_port_range"] = request.NodePortRange;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Nodepools))
            {
                body["nodepools"] = request.Nodepools;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NumOfNodes))
            {
                body["num_of_nodes"] = request.NumOfNodes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OsType))
            {
                body["os_type"] = request.OsType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Period))
            {
                body["period"] = request.Period;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PeriodUnit))
            {
                body["period_unit"] = request.PeriodUnit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Platform))
            {
                body["platform"] = request.Platform;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PodVswitchIds))
            {
                body["pod_vswitch_ids"] = request.PodVswitchIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Profile))
            {
                body["profile"] = request.Profile;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProxyMode))
            {
                body["proxy_mode"] = request.ProxyMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RdsInstances))
            {
                body["rds_instances"] = request.RdsInstances;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["region_id"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                body["resource_group_id"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Runtime))
            {
                body["runtime"] = request.Runtime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityGroupId))
            {
                body["security_group_id"] = request.SecurityGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityHardeningOs))
            {
                body["security_hardening_os"] = request.SecurityHardeningOs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceAccountIssuer))
            {
                body["service_account_issuer"] = request.ServiceAccountIssuer;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceCidr))
            {
                body["service_cidr"] = request.ServiceCidr;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceDiscoveryTypes))
            {
                body["service_discovery_types"] = request.ServiceDiscoveryTypes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SnatEntry))
            {
                body["snat_entry"] = request.SnatEntry;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SocEnabled))
            {
                body["soc_enabled"] = request.SocEnabled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SshFlags))
            {
                body["ssh_flags"] = request.SshFlags;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tags))
            {
                body["tags"] = request.Tags;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Taints))
            {
                body["taints"] = request.Taints;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TimeoutMins))
            {
                body["timeout_mins"] = request.TimeoutMins;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Timezone))
            {
                body["timezone"] = request.Timezone;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserCa))
            {
                body["user_ca"] = request.UserCa;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserData))
            {
                body["user_data"] = request.UserData;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Vpcid))
            {
                body["vpcid"] = request.Vpcid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VswitchIds))
            {
                body["vswitch_ids"] = request.VswitchIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkerAutoRenew))
            {
                body["worker_auto_renew"] = request.WorkerAutoRenew;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkerAutoRenewPeriod))
            {
                body["worker_auto_renew_period"] = request.WorkerAutoRenewPeriod;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkerDataDisks))
            {
                body["worker_data_disks"] = request.WorkerDataDisks;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkerInstanceChargeType))
            {
                body["worker_instance_charge_type"] = request.WorkerInstanceChargeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkerInstanceTypes))
            {
                body["worker_instance_types"] = request.WorkerInstanceTypes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkerPeriod))
            {
                body["worker_period"] = request.WorkerPeriod;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkerPeriodUnit))
            {
                body["worker_period_unit"] = request.WorkerPeriodUnit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkerSystemDiskCategory))
            {
                body["worker_system_disk_category"] = request.WorkerSystemDiskCategory;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkerSystemDiskPerformanceLevel))
            {
                body["worker_system_disk_performance_level"] = request.WorkerSystemDiskPerformanceLevel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkerSystemDiskSize))
            {
                body["worker_system_disk_size"] = request.WorkerSystemDiskSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkerSystemDiskSnapshotPolicyId))
            {
                body["worker_system_disk_snapshot_policy_id"] = request.WorkerSystemDiskSnapshotPolicyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkerVswitchIds))
            {
                body["worker_vswitch_ids"] = request.WorkerVswitchIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ZoneId))
            {
                body["zone_id"] = request.ZoneId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateCluster",
                Version = "2015-12-15",
                Protocol = "HTTPS",
                Pathname = "/clusters",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateClusterResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary You can call the CreateCluster operation to create a Container Service for Kubernetes (ACK) cluster. ACK clusters include ACK managed clusters, ACK dedicated clusters, ACK Serverless clusters, ACK Edge clusters, ACK clusters that support sandboxed containers, and registered clusters. For more information about how to create different types of ACK clusters, see the following usage notes.
         *
         * @description This topic describes all parameters for creating an ACK cluster. You can create the following types of ACK clusters.
         * *   [Create an ACK managed cluster](https://help.aliyun.com/document_detail/90776.html)
         * *   [Create an ACK dedicated cluster](https://help.aliyun.com/document_detail/197620.html)
         * *   [Create an ACK Serverless cluster](https://help.aliyun.com/document_detail/144246.html)
         * *   [Create an ACK Edge cluster](https://help.aliyun.com/document_detail/128204.html)
         * *   [Create an ACK Basic cluster that supports sandboxed containers](https://help.aliyun.com/document_detail/196321.html)
         * *   [Create an ACK Pro cluster that supports sandboxed containers](https://help.aliyun.com/document_detail/140623.html)
         *
         * @param request CreateClusterRequest
         * @return CreateClusterResponse
         */
        public CreateClusterResponse CreateCluster(CreateClusterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateClusterWithOptions(request, headers, runtime);
        }

        /**
         * @summary You can call the CreateCluster operation to create a Container Service for Kubernetes (ACK) cluster. ACK clusters include ACK managed clusters, ACK dedicated clusters, ACK Serverless clusters, ACK Edge clusters, ACK clusters that support sandboxed containers, and registered clusters. For more information about how to create different types of ACK clusters, see the following usage notes.
         *
         * @description This topic describes all parameters for creating an ACK cluster. You can create the following types of ACK clusters.
         * *   [Create an ACK managed cluster](https://help.aliyun.com/document_detail/90776.html)
         * *   [Create an ACK dedicated cluster](https://help.aliyun.com/document_detail/197620.html)
         * *   [Create an ACK Serverless cluster](https://help.aliyun.com/document_detail/144246.html)
         * *   [Create an ACK Edge cluster](https://help.aliyun.com/document_detail/128204.html)
         * *   [Create an ACK Basic cluster that supports sandboxed containers](https://help.aliyun.com/document_detail/196321.html)
         * *   [Create an ACK Pro cluster that supports sandboxed containers](https://help.aliyun.com/document_detail/140623.html)
         *
         * @param request CreateClusterRequest
         * @return CreateClusterResponse
         */
        public async Task<CreateClusterResponse> CreateClusterAsync(CreateClusterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateClusterWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 发起集群诊断
         *
         * @param request CreateClusterDiagnosisRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateClusterDiagnosisResponse
         */
        public CreateClusterDiagnosisResponse CreateClusterDiagnosisWithOptions(string clusterId, CreateClusterDiagnosisRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Target))
            {
                body["target"] = request.Target;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                body["type"] = request.Type;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateClusterDiagnosis",
                Version = "2015-12-15",
                Protocol = "HTTPS",
                Pathname = "/clusters/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(clusterId) + "/diagnosis",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateClusterDiagnosisResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 发起集群诊断
         *
         * @param request CreateClusterDiagnosisRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateClusterDiagnosisResponse
         */
        public async Task<CreateClusterDiagnosisResponse> CreateClusterDiagnosisWithOptionsAsync(string clusterId, CreateClusterDiagnosisRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Target))
            {
                body["target"] = request.Target;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                body["type"] = request.Type;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateClusterDiagnosis",
                Version = "2015-12-15",
                Protocol = "HTTPS",
                Pathname = "/clusters/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(clusterId) + "/diagnosis",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateClusterDiagnosisResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 发起集群诊断
         *
         * @param request CreateClusterDiagnosisRequest
         * @return CreateClusterDiagnosisResponse
         */
        public CreateClusterDiagnosisResponse CreateClusterDiagnosis(string clusterId, CreateClusterDiagnosisRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateClusterDiagnosisWithOptions(clusterId, request, headers, runtime);
        }

        /**
         * @summary 发起集群诊断
         *
         * @param request CreateClusterDiagnosisRequest
         * @return CreateClusterDiagnosisResponse
         */
        public async Task<CreateClusterDiagnosisResponse> CreateClusterDiagnosisAsync(string clusterId, CreateClusterDiagnosisRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateClusterDiagnosisWithOptionsAsync(clusterId, request, headers, runtime);
        }

        /**
         * @summary Creates a node pool for a Container Service for Kubernetes (ACK) cluster. You can use node pools to facilitate node management. For example, you can schedule, configure, or maintain nodes by node pool, and enable auto scaling for a node pool. We recommend that you use a managed node pool, which can help automate specific O\\&M tasks for nodes, such as Common Vulnerabilities and Exposures (CVE) patching and node repair. This reduces your O\\&M workload.
         *
         * @param request CreateClusterNodePoolRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateClusterNodePoolResponse
         */
        public CreateClusterNodePoolResponse CreateClusterNodePoolWithOptions(string ClusterId, CreateClusterNodePoolRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoScaling))
            {
                body["auto_scaling"] = request.AutoScaling;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Count))
            {
                body["count"] = request.Count;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InterconnectConfig))
            {
                body["interconnect_config"] = request.InterconnectConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InterconnectMode))
            {
                body["interconnect_mode"] = request.InterconnectMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KubernetesConfig))
            {
                body["kubernetes_config"] = request.KubernetesConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Management))
            {
                body["management"] = request.Management;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxNodes))
            {
                body["max_nodes"] = request.MaxNodes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeConfig))
            {
                body["node_config"] = request.NodeConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodepoolInfo))
            {
                body["nodepool_info"] = request.NodepoolInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScalingGroup))
            {
                body["scaling_group"] = request.ScalingGroup;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TeeConfig))
            {
                body["tee_config"] = request.TeeConfig;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateClusterNodePool",
                Version = "2015-12-15",
                Protocol = "HTTPS",
                Pathname = "/clusters/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId) + "/nodepools",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateClusterNodePoolResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Creates a node pool for a Container Service for Kubernetes (ACK) cluster. You can use node pools to facilitate node management. For example, you can schedule, configure, or maintain nodes by node pool, and enable auto scaling for a node pool. We recommend that you use a managed node pool, which can help automate specific O\\&M tasks for nodes, such as Common Vulnerabilities and Exposures (CVE) patching and node repair. This reduces your O\\&M workload.
         *
         * @param request CreateClusterNodePoolRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateClusterNodePoolResponse
         */
        public async Task<CreateClusterNodePoolResponse> CreateClusterNodePoolWithOptionsAsync(string ClusterId, CreateClusterNodePoolRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoScaling))
            {
                body["auto_scaling"] = request.AutoScaling;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Count))
            {
                body["count"] = request.Count;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InterconnectConfig))
            {
                body["interconnect_config"] = request.InterconnectConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InterconnectMode))
            {
                body["interconnect_mode"] = request.InterconnectMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KubernetesConfig))
            {
                body["kubernetes_config"] = request.KubernetesConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Management))
            {
                body["management"] = request.Management;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxNodes))
            {
                body["max_nodes"] = request.MaxNodes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeConfig))
            {
                body["node_config"] = request.NodeConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodepoolInfo))
            {
                body["nodepool_info"] = request.NodepoolInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScalingGroup))
            {
                body["scaling_group"] = request.ScalingGroup;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TeeConfig))
            {
                body["tee_config"] = request.TeeConfig;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateClusterNodePool",
                Version = "2015-12-15",
                Protocol = "HTTPS",
                Pathname = "/clusters/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId) + "/nodepools",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateClusterNodePoolResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Creates a node pool for a Container Service for Kubernetes (ACK) cluster. You can use node pools to facilitate node management. For example, you can schedule, configure, or maintain nodes by node pool, and enable auto scaling for a node pool. We recommend that you use a managed node pool, which can help automate specific O\\&M tasks for nodes, such as Common Vulnerabilities and Exposures (CVE) patching and node repair. This reduces your O\\&M workload.
         *
         * @param request CreateClusterNodePoolRequest
         * @return CreateClusterNodePoolResponse
         */
        public CreateClusterNodePoolResponse CreateClusterNodePool(string ClusterId, CreateClusterNodePoolRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateClusterNodePoolWithOptions(ClusterId, request, headers, runtime);
        }

        /**
         * @summary Creates a node pool for a Container Service for Kubernetes (ACK) cluster. You can use node pools to facilitate node management. For example, you can schedule, configure, or maintain nodes by node pool, and enable auto scaling for a node pool. We recommend that you use a managed node pool, which can help automate specific O\\&M tasks for nodes, such as Common Vulnerabilities and Exposures (CVE) patching and node repair. This reduces your O\\&M workload.
         *
         * @param request CreateClusterNodePoolRequest
         * @return CreateClusterNodePoolResponse
         */
        public async Task<CreateClusterNodePoolResponse> CreateClusterNodePoolAsync(string ClusterId, CreateClusterNodePoolRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateClusterNodePoolWithOptionsAsync(ClusterId, request, headers, runtime);
        }

        /**
         * @summary You can call the CreateEdgeMachine operation to activate a cloud-native box.
         *
         * @param request CreateEdgeMachineRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateEdgeMachineResponse
         */
        public CreateEdgeMachineResponse CreateEdgeMachineWithOptions(CreateEdgeMachineRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Hostname))
            {
                body["hostname"] = request.Hostname;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Model))
            {
                body["model"] = request.Model;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Sn))
            {
                body["sn"] = request.Sn;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateEdgeMachine",
                Version = "2015-12-15",
                Protocol = "HTTPS",
                Pathname = "/edge_machines",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateEdgeMachineResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary You can call the CreateEdgeMachine operation to activate a cloud-native box.
         *
         * @param request CreateEdgeMachineRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateEdgeMachineResponse
         */
        public async Task<CreateEdgeMachineResponse> CreateEdgeMachineWithOptionsAsync(CreateEdgeMachineRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Hostname))
            {
                body["hostname"] = request.Hostname;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Model))
            {
                body["model"] = request.Model;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Sn))
            {
                body["sn"] = request.Sn;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateEdgeMachine",
                Version = "2015-12-15",
                Protocol = "HTTPS",
                Pathname = "/edge_machines",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateEdgeMachineResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary You can call the CreateEdgeMachine operation to activate a cloud-native box.
         *
         * @param request CreateEdgeMachineRequest
         * @return CreateEdgeMachineResponse
         */
        public CreateEdgeMachineResponse CreateEdgeMachine(CreateEdgeMachineRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateEdgeMachineWithOptions(request, headers, runtime);
        }

        /**
         * @summary You can call the CreateEdgeMachine operation to activate a cloud-native box.
         *
         * @param request CreateEdgeMachineRequest
         * @return CreateEdgeMachineResponse
         */
        public async Task<CreateEdgeMachineResponse> CreateEdgeMachineAsync(CreateEdgeMachineRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateEdgeMachineWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary You can call the CreateKubernetesTrigger operation to create a trigger for an application.
         *
         * @param request CreateKubernetesTriggerRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateKubernetesTriggerResponse
         */
        public CreateKubernetesTriggerResponse CreateKubernetesTriggerWithOptions(CreateKubernetesTriggerRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Action))
            {
                body["action"] = request.Action;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                body["cluster_id"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectId))
            {
                body["project_id"] = request.ProjectId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                body["type"] = request.Type;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateKubernetesTrigger",
                Version = "2015-12-15",
                Protocol = "HTTPS",
                Pathname = "/triggers",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateKubernetesTriggerResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary You can call the CreateKubernetesTrigger operation to create a trigger for an application.
         *
         * @param request CreateKubernetesTriggerRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateKubernetesTriggerResponse
         */
        public async Task<CreateKubernetesTriggerResponse> CreateKubernetesTriggerWithOptionsAsync(CreateKubernetesTriggerRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Action))
            {
                body["action"] = request.Action;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                body["cluster_id"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectId))
            {
                body["project_id"] = request.ProjectId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                body["type"] = request.Type;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateKubernetesTrigger",
                Version = "2015-12-15",
                Protocol = "HTTPS",
                Pathname = "/triggers",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateKubernetesTriggerResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary You can call the CreateKubernetesTrigger operation to create a trigger for an application.
         *
         * @param request CreateKubernetesTriggerRequest
         * @return CreateKubernetesTriggerResponse
         */
        public CreateKubernetesTriggerResponse CreateKubernetesTrigger(CreateKubernetesTriggerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateKubernetesTriggerWithOptions(request, headers, runtime);
        }

        /**
         * @summary You can call the CreateKubernetesTrigger operation to create a trigger for an application.
         *
         * @param request CreateKubernetesTriggerRequest
         * @return CreateKubernetesTriggerResponse
         */
        public async Task<CreateKubernetesTriggerResponse> CreateKubernetesTriggerAsync(CreateKubernetesTriggerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateKubernetesTriggerWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary Creates an orchestration template. An orchestration template defines and describes a group of Kubernetes resources. It declaratively describes the configuration of an application or how an application runs. You can use orchestration templates to manage resources in Kubernetes clusters and automate resource deployment, such as pods, Services, Deployments, ConfigMaps, and persistent volumes (PVs).
         *
         * @param request CreateTemplateRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateTemplateResponse
         */
        public CreateTemplateResponse CreateTemplateWithOptions(CreateTemplateRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tags))
            {
                body["tags"] = request.Tags;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Template))
            {
                body["template"] = request.Template;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateType))
            {
                body["template_type"] = request.TemplateType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateTemplate",
                Version = "2015-12-15",
                Protocol = "HTTPS",
                Pathname = "/templates",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateTemplateResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Creates an orchestration template. An orchestration template defines and describes a group of Kubernetes resources. It declaratively describes the configuration of an application or how an application runs. You can use orchestration templates to manage resources in Kubernetes clusters and automate resource deployment, such as pods, Services, Deployments, ConfigMaps, and persistent volumes (PVs).
         *
         * @param request CreateTemplateRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateTemplateResponse
         */
        public async Task<CreateTemplateResponse> CreateTemplateWithOptionsAsync(CreateTemplateRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tags))
            {
                body["tags"] = request.Tags;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Template))
            {
                body["template"] = request.Template;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateType))
            {
                body["template_type"] = request.TemplateType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateTemplate",
                Version = "2015-12-15",
                Protocol = "HTTPS",
                Pathname = "/templates",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateTemplateResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Creates an orchestration template. An orchestration template defines and describes a group of Kubernetes resources. It declaratively describes the configuration of an application or how an application runs. You can use orchestration templates to manage resources in Kubernetes clusters and automate resource deployment, such as pods, Services, Deployments, ConfigMaps, and persistent volumes (PVs).
         *
         * @param request CreateTemplateRequest
         * @return CreateTemplateResponse
         */
        public CreateTemplateResponse CreateTemplate(CreateTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateTemplateWithOptions(request, headers, runtime);
        }

        /**
         * @summary Creates an orchestration template. An orchestration template defines and describes a group of Kubernetes resources. It declaratively describes the configuration of an application or how an application runs. You can use orchestration templates to manage resources in Kubernetes clusters and automate resource deployment, such as pods, Services, Deployments, ConfigMaps, and persistent volumes (PVs).
         *
         * @param request CreateTemplateRequest
         * @return CreateTemplateResponse
         */
        public async Task<CreateTemplateResponse> CreateTemplateAsync(CreateTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateTemplateWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary You can call the CreateTrigger operation to create a trigger for an application.
         *
         * @param request CreateTriggerRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateTriggerResponse
         */
        public CreateTriggerResponse CreateTriggerWithOptions(string clusterId, CreateTriggerRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Action))
            {
                body["action"] = request.Action;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                body["cluster_id"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectId))
            {
                body["project_id"] = request.ProjectId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                body["type"] = request.Type;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateTrigger",
                Version = "2015-12-15",
                Protocol = "HTTPS",
                Pathname = "/clusters/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(clusterId) + "/triggers",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateTriggerResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary You can call the CreateTrigger operation to create a trigger for an application.
         *
         * @param request CreateTriggerRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateTriggerResponse
         */
        public async Task<CreateTriggerResponse> CreateTriggerWithOptionsAsync(string clusterId, CreateTriggerRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Action))
            {
                body["action"] = request.Action;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                body["cluster_id"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectId))
            {
                body["project_id"] = request.ProjectId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                body["type"] = request.Type;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateTrigger",
                Version = "2015-12-15",
                Protocol = "HTTPS",
                Pathname = "/clusters/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(clusterId) + "/triggers",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateTriggerResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary You can call the CreateTrigger operation to create a trigger for an application.
         *
         * @param request CreateTriggerRequest
         * @return CreateTriggerResponse
         */
        public CreateTriggerResponse CreateTrigger(string clusterId, CreateTriggerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateTriggerWithOptions(clusterId, request, headers, runtime);
        }

        /**
         * @summary You can call the CreateTrigger operation to create a trigger for an application.
         *
         * @param request CreateTriggerRequest
         * @return CreateTriggerResponse
         */
        public async Task<CreateTriggerResponse> CreateTriggerAsync(string clusterId, CreateTriggerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateTriggerWithOptionsAsync(clusterId, request, headers, runtime);
        }

        /**
         * @summary 删除ACK报警联系人
         *
         * @param tmpReq DeleteAlertContactRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteAlertContactResponse
         */
        public DeleteAlertContactResponse DeleteAlertContactWithOptions(DeleteAlertContactRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DeleteAlertContactShrinkRequest request = new DeleteAlertContactShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ContactIds))
            {
                request.ContactIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ContactIds, "contact_ids", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactIdsShrink))
            {
                query["contact_ids"] = request.ContactIdsShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteAlertContact",
                Version = "2015-12-15",
                Protocol = "HTTPS",
                Pathname = "/alert/contacts",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "array",
            };
            return TeaModel.ToObject<DeleteAlertContactResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 删除ACK报警联系人
         *
         * @param tmpReq DeleteAlertContactRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteAlertContactResponse
         */
        public async Task<DeleteAlertContactResponse> DeleteAlertContactWithOptionsAsync(DeleteAlertContactRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DeleteAlertContactShrinkRequest request = new DeleteAlertContactShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ContactIds))
            {
                request.ContactIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ContactIds, "contact_ids", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactIdsShrink))
            {
                query["contact_ids"] = request.ContactIdsShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteAlertContact",
                Version = "2015-12-15",
                Protocol = "HTTPS",
                Pathname = "/alert/contacts",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "array",
            };
            return TeaModel.ToObject<DeleteAlertContactResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 删除ACK报警联系人
         *
         * @param request DeleteAlertContactRequest
         * @return DeleteAlertContactResponse
         */
        public DeleteAlertContactResponse DeleteAlertContact(DeleteAlertContactRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteAlertContactWithOptions(request, headers, runtime);
        }

        /**
         * @summary 删除ACK报警联系人
         *
         * @param request DeleteAlertContactRequest
         * @return DeleteAlertContactResponse
         */
        public async Task<DeleteAlertContactResponse> DeleteAlertContactAsync(DeleteAlertContactRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteAlertContactWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 删除ACK报警联系人分组
         *
         * @param tmpReq DeleteAlertContactGroupRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteAlertContactGroupResponse
         */
        public DeleteAlertContactGroupResponse DeleteAlertContactGroupWithOptions(DeleteAlertContactGroupRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DeleteAlertContactGroupShrinkRequest request = new DeleteAlertContactGroupShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ContactGroupIds))
            {
                request.ContactGroupIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ContactGroupIds, "contact_group_ids", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactGroupIdsShrink))
            {
                query["contact_group_ids"] = request.ContactGroupIdsShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteAlertContactGroup",
                Version = "2015-12-15",
                Protocol = "HTTPS",
                Pathname = "/alert/contact_groups",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "array",
            };
            return TeaModel.ToObject<DeleteAlertContactGroupResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 删除ACK报警联系人分组
         *
         * @param tmpReq DeleteAlertContactGroupRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteAlertContactGroupResponse
         */
        public async Task<DeleteAlertContactGroupResponse> DeleteAlertContactGroupWithOptionsAsync(DeleteAlertContactGroupRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DeleteAlertContactGroupShrinkRequest request = new DeleteAlertContactGroupShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ContactGroupIds))
            {
                request.ContactGroupIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ContactGroupIds, "contact_group_ids", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactGroupIdsShrink))
            {
                query["contact_group_ids"] = request.ContactGroupIdsShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteAlertContactGroup",
                Version = "2015-12-15",
                Protocol = "HTTPS",
                Pathname = "/alert/contact_groups",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "array",
            };
            return TeaModel.ToObject<DeleteAlertContactGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 删除ACK报警联系人分组
         *
         * @param request DeleteAlertContactGroupRequest
         * @return DeleteAlertContactGroupResponse
         */
        public DeleteAlertContactGroupResponse DeleteAlertContactGroup(DeleteAlertContactGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteAlertContactGroupWithOptions(request, headers, runtime);
        }

        /**
         * @summary 删除ACK报警联系人分组
         *
         * @param request DeleteAlertContactGroupRequest
         * @return DeleteAlertContactGroupResponse
         */
        public async Task<DeleteAlertContactGroupResponse> DeleteAlertContactGroupAsync(DeleteAlertContactGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteAlertContactGroupWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary You can call the DeleteCluster operation to delete a cluster and specify whether to delete or retain the relevant cluster resources. Before you delete a cluster, you must manually delete workloads in the cluster, such as Deployments, StatefulSets, Jobs, and CronJobs. Otherwise, you may fail to delete the cluster.
         *
         * @param tmpReq DeleteClusterRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteClusterResponse
         */
        public DeleteClusterResponse DeleteClusterWithOptions(string ClusterId, DeleteClusterRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DeleteClusterShrinkRequest request = new DeleteClusterShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DeleteOptions))
            {
                request.DeleteOptionsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DeleteOptions, "delete_options", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.RetainResources))
            {
                request.RetainResourcesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.RetainResources, "retain_resources", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeleteOptionsShrink))
            {
                query["delete_options"] = request.DeleteOptionsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeepSlb))
            {
                query["keep_slb"] = request.KeepSlb;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RetainAllResources))
            {
                query["retain_all_resources"] = request.RetainAllResources;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RetainResourcesShrink))
            {
                query["retain_resources"] = request.RetainResourcesShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteCluster",
                Version = "2015-12-15",
                Protocol = "HTTPS",
                Pathname = "/clusters/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteClusterResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary You can call the DeleteCluster operation to delete a cluster and specify whether to delete or retain the relevant cluster resources. Before you delete a cluster, you must manually delete workloads in the cluster, such as Deployments, StatefulSets, Jobs, and CronJobs. Otherwise, you may fail to delete the cluster.
         *
         * @param tmpReq DeleteClusterRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteClusterResponse
         */
        public async Task<DeleteClusterResponse> DeleteClusterWithOptionsAsync(string ClusterId, DeleteClusterRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DeleteClusterShrinkRequest request = new DeleteClusterShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DeleteOptions))
            {
                request.DeleteOptionsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DeleteOptions, "delete_options", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.RetainResources))
            {
                request.RetainResourcesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.RetainResources, "retain_resources", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeleteOptionsShrink))
            {
                query["delete_options"] = request.DeleteOptionsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeepSlb))
            {
                query["keep_slb"] = request.KeepSlb;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RetainAllResources))
            {
                query["retain_all_resources"] = request.RetainAllResources;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RetainResourcesShrink))
            {
                query["retain_resources"] = request.RetainResourcesShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteCluster",
                Version = "2015-12-15",
                Protocol = "HTTPS",
                Pathname = "/clusters/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteClusterResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary You can call the DeleteCluster operation to delete a cluster and specify whether to delete or retain the relevant cluster resources. Before you delete a cluster, you must manually delete workloads in the cluster, such as Deployments, StatefulSets, Jobs, and CronJobs. Otherwise, you may fail to delete the cluster.
         *
         * @param request DeleteClusterRequest
         * @return DeleteClusterResponse
         */
        public DeleteClusterResponse DeleteCluster(string ClusterId, DeleteClusterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteClusterWithOptions(ClusterId, request, headers, runtime);
        }

        /**
         * @summary You can call the DeleteCluster operation to delete a cluster and specify whether to delete or retain the relevant cluster resources. Before you delete a cluster, you must manually delete workloads in the cluster, such as Deployments, StatefulSets, Jobs, and CronJobs. Otherwise, you may fail to delete the cluster.
         *
         * @param request DeleteClusterRequest
         * @return DeleteClusterResponse
         */
        public async Task<DeleteClusterResponse> DeleteClusterAsync(string ClusterId, DeleteClusterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteClusterWithOptionsAsync(ClusterId, request, headers, runtime);
        }

        /**
         * @summary You can call the DeleteClusterNodepool operation to delete a node pool by node pool ID.
         *
         * @param request DeleteClusterNodepoolRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteClusterNodepoolResponse
         */
        public DeleteClusterNodepoolResponse DeleteClusterNodepoolWithOptions(string ClusterId, string NodepoolId, DeleteClusterNodepoolRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Force))
            {
                query["force"] = request.Force;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteClusterNodepool",
                Version = "2015-12-15",
                Protocol = "HTTPS",
                Pathname = "/clusters/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId) + "/nodepools/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(NodepoolId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteClusterNodepoolResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary You can call the DeleteClusterNodepool operation to delete a node pool by node pool ID.
         *
         * @param request DeleteClusterNodepoolRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteClusterNodepoolResponse
         */
        public async Task<DeleteClusterNodepoolResponse> DeleteClusterNodepoolWithOptionsAsync(string ClusterId, string NodepoolId, DeleteClusterNodepoolRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Force))
            {
                query["force"] = request.Force;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteClusterNodepool",
                Version = "2015-12-15",
                Protocol = "HTTPS",
                Pathname = "/clusters/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId) + "/nodepools/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(NodepoolId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteClusterNodepoolResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary You can call the DeleteClusterNodepool operation to delete a node pool by node pool ID.
         *
         * @param request DeleteClusterNodepoolRequest
         * @return DeleteClusterNodepoolResponse
         */
        public DeleteClusterNodepoolResponse DeleteClusterNodepool(string ClusterId, string NodepoolId, DeleteClusterNodepoolRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteClusterNodepoolWithOptions(ClusterId, NodepoolId, request, headers, runtime);
        }

        /**
         * @summary You can call the DeleteClusterNodepool operation to delete a node pool by node pool ID.
         *
         * @param request DeleteClusterNodepoolRequest
         * @return DeleteClusterNodepoolResponse
         */
        public async Task<DeleteClusterNodepoolResponse> DeleteClusterNodepoolAsync(string ClusterId, string NodepoolId, DeleteClusterNodepoolRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteClusterNodepoolWithOptionsAsync(ClusterId, NodepoolId, request, headers, runtime);
        }

        /**
         * @summary Removes nodes from a Container Service for Kubernetes (ACK) cluster. When you remove nodes, you can specify whether to release the Elastic Compute Service (ECS) instances and drain the nodes. When you remove nodes, pods on the nodes are migrated. This may adversely affect your businesses. We recommend that you back up data and perform this operation during off-peak hours.
         *
         * @description > 
         * *   When you remove a node, the pods that run on the node are migrated to other nodes. This may cause service interruptions. We recommend that you remove nodes during off-peak hours. - The operation may have unexpected risks. Back up the data before you perform this operation. - When the system removes a node, it sets the status of the node to Unschedulable. - The system removes only worker nodes. It does not remove master nodes.
         *
         * @param request DeleteClusterNodesRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteClusterNodesResponse
         */
        public DeleteClusterNodesResponse DeleteClusterNodesWithOptions(string ClusterId, DeleteClusterNodesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DrainNode))
            {
                body["drain_node"] = request.DrainNode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Nodes))
            {
                body["nodes"] = request.Nodes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReleaseNode))
            {
                body["release_node"] = request.ReleaseNode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteClusterNodes",
                Version = "2015-12-15",
                Protocol = "HTTPS",
                Pathname = "/clusters/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId) + "/nodes",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteClusterNodesResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Removes nodes from a Container Service for Kubernetes (ACK) cluster. When you remove nodes, you can specify whether to release the Elastic Compute Service (ECS) instances and drain the nodes. When you remove nodes, pods on the nodes are migrated. This may adversely affect your businesses. We recommend that you back up data and perform this operation during off-peak hours.
         *
         * @description > 
         * *   When you remove a node, the pods that run on the node are migrated to other nodes. This may cause service interruptions. We recommend that you remove nodes during off-peak hours. - The operation may have unexpected risks. Back up the data before you perform this operation. - When the system removes a node, it sets the status of the node to Unschedulable. - The system removes only worker nodes. It does not remove master nodes.
         *
         * @param request DeleteClusterNodesRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteClusterNodesResponse
         */
        public async Task<DeleteClusterNodesResponse> DeleteClusterNodesWithOptionsAsync(string ClusterId, DeleteClusterNodesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DrainNode))
            {
                body["drain_node"] = request.DrainNode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Nodes))
            {
                body["nodes"] = request.Nodes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReleaseNode))
            {
                body["release_node"] = request.ReleaseNode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteClusterNodes",
                Version = "2015-12-15",
                Protocol = "HTTPS",
                Pathname = "/clusters/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId) + "/nodes",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteClusterNodesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Removes nodes from a Container Service for Kubernetes (ACK) cluster. When you remove nodes, you can specify whether to release the Elastic Compute Service (ECS) instances and drain the nodes. When you remove nodes, pods on the nodes are migrated. This may adversely affect your businesses. We recommend that you back up data and perform this operation during off-peak hours.
         *
         * @description > 
         * *   When you remove a node, the pods that run on the node are migrated to other nodes. This may cause service interruptions. We recommend that you remove nodes during off-peak hours. - The operation may have unexpected risks. Back up the data before you perform this operation. - When the system removes a node, it sets the status of the node to Unschedulable. - The system removes only worker nodes. It does not remove master nodes.
         *
         * @param request DeleteClusterNodesRequest
         * @return DeleteClusterNodesResponse
         */
        public DeleteClusterNodesResponse DeleteClusterNodes(string ClusterId, DeleteClusterNodesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteClusterNodesWithOptions(ClusterId, request, headers, runtime);
        }

        /**
         * @summary Removes nodes from a Container Service for Kubernetes (ACK) cluster. When you remove nodes, you can specify whether to release the Elastic Compute Service (ECS) instances and drain the nodes. When you remove nodes, pods on the nodes are migrated. This may adversely affect your businesses. We recommend that you back up data and perform this operation during off-peak hours.
         *
         * @description > 
         * *   When you remove a node, the pods that run on the node are migrated to other nodes. This may cause service interruptions. We recommend that you remove nodes during off-peak hours. - The operation may have unexpected risks. Back up the data before you perform this operation. - When the system removes a node, it sets the status of the node to Unschedulable. - The system removes only worker nodes. It does not remove master nodes.
         *
         * @param request DeleteClusterNodesRequest
         * @return DeleteClusterNodesResponse
         */
        public async Task<DeleteClusterNodesResponse> DeleteClusterNodesAsync(string ClusterId, DeleteClusterNodesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteClusterNodesWithOptionsAsync(ClusterId, request, headers, runtime);
        }

        /**
         * @summary You can call the DeleteEdgeMachine operation to delete a cloud-native box.
         *
         * @param request DeleteEdgeMachineRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteEdgeMachineResponse
         */
        public DeleteEdgeMachineResponse DeleteEdgeMachineWithOptions(string edgeMachineid, DeleteEdgeMachineRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Force))
            {
                query["force"] = request.Force;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteEdgeMachine",
                Version = "2015-12-15",
                Protocol = "HTTPS",
                Pathname = "/edge_machines/%5Bedge_machineid%5D",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<DeleteEdgeMachineResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary You can call the DeleteEdgeMachine operation to delete a cloud-native box.
         *
         * @param request DeleteEdgeMachineRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteEdgeMachineResponse
         */
        public async Task<DeleteEdgeMachineResponse> DeleteEdgeMachineWithOptionsAsync(string edgeMachineid, DeleteEdgeMachineRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Force))
            {
                query["force"] = request.Force;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteEdgeMachine",
                Version = "2015-12-15",
                Protocol = "HTTPS",
                Pathname = "/edge_machines/%5Bedge_machineid%5D",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<DeleteEdgeMachineResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary You can call the DeleteEdgeMachine operation to delete a cloud-native box.
         *
         * @param request DeleteEdgeMachineRequest
         * @return DeleteEdgeMachineResponse
         */
        public DeleteEdgeMachineResponse DeleteEdgeMachine(string edgeMachineid, DeleteEdgeMachineRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteEdgeMachineWithOptions(edgeMachineid, request, headers, runtime);
        }

        /**
         * @summary You can call the DeleteEdgeMachine operation to delete a cloud-native box.
         *
         * @param request DeleteEdgeMachineRequest
         * @return DeleteEdgeMachineResponse
         */
        public async Task<DeleteEdgeMachineResponse> DeleteEdgeMachineAsync(string edgeMachineid, DeleteEdgeMachineRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteEdgeMachineWithOptionsAsync(edgeMachineid, request, headers, runtime);
        }

        /**
         * @summary You can call the DeleteKubernetesTrigger operation to delete an application trigger by trigger ID
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteKubernetesTriggerResponse
         */
        public DeleteKubernetesTriggerResponse DeleteKubernetesTriggerWithOptions(string Id, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteKubernetesTrigger",
                Version = "2015-12-15",
                Protocol = "HTTPS",
                Pathname = "/triggers/revoke/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(Id),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<DeleteKubernetesTriggerResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary You can call the DeleteKubernetesTrigger operation to delete an application trigger by trigger ID
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteKubernetesTriggerResponse
         */
        public async Task<DeleteKubernetesTriggerResponse> DeleteKubernetesTriggerWithOptionsAsync(string Id, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteKubernetesTrigger",
                Version = "2015-12-15",
                Protocol = "HTTPS",
                Pathname = "/triggers/revoke/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(Id),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<DeleteKubernetesTriggerResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary You can call the DeleteKubernetesTrigger operation to delete an application trigger by trigger ID
         *
         * @return DeleteKubernetesTriggerResponse
         */
        public DeleteKubernetesTriggerResponse DeleteKubernetesTrigger(string Id)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteKubernetesTriggerWithOptions(Id, headers, runtime);
        }

        /**
         * @summary You can call the DeleteKubernetesTrigger operation to delete an application trigger by trigger ID
         *
         * @return DeleteKubernetesTriggerResponse
         */
        public async Task<DeleteKubernetesTriggerResponse> DeleteKubernetesTriggerAsync(string Id)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteKubernetesTriggerWithOptionsAsync(Id, headers, runtime);
        }

        /**
         * @summary Deletes policy instances in a Container Service for Kubernetes (ACK) cluster.
         *
         * @param request DeletePolicyInstanceRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeletePolicyInstanceResponse
         */
        public DeletePolicyInstanceResponse DeletePolicyInstanceWithOptions(string clusterId, string policyName, DeletePolicyInstanceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceName))
            {
                query["instance_name"] = request.InstanceName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeletePolicyInstance",
                Version = "2015-12-15",
                Protocol = "HTTPS",
                Pathname = "/clusters/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(clusterId) + "/policies/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(policyName),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeletePolicyInstanceResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Deletes policy instances in a Container Service for Kubernetes (ACK) cluster.
         *
         * @param request DeletePolicyInstanceRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeletePolicyInstanceResponse
         */
        public async Task<DeletePolicyInstanceResponse> DeletePolicyInstanceWithOptionsAsync(string clusterId, string policyName, DeletePolicyInstanceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceName))
            {
                query["instance_name"] = request.InstanceName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeletePolicyInstance",
                Version = "2015-12-15",
                Protocol = "HTTPS",
                Pathname = "/clusters/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(clusterId) + "/policies/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(policyName),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeletePolicyInstanceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Deletes policy instances in a Container Service for Kubernetes (ACK) cluster.
         *
         * @param request DeletePolicyInstanceRequest
         * @return DeletePolicyInstanceResponse
         */
        public DeletePolicyInstanceResponse DeletePolicyInstance(string clusterId, string policyName, DeletePolicyInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeletePolicyInstanceWithOptions(clusterId, policyName, request, headers, runtime);
        }

        /**
         * @summary Deletes policy instances in a Container Service for Kubernetes (ACK) cluster.
         *
         * @param request DeletePolicyInstanceRequest
         * @return DeletePolicyInstanceResponse
         */
        public async Task<DeletePolicyInstanceResponse> DeletePolicyInstanceAsync(string clusterId, string policyName, DeletePolicyInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeletePolicyInstanceWithOptionsAsync(clusterId, policyName, request, headers, runtime);
        }

        /**
         * @summary Deletes the orchestration templates that you no longer need.
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteTemplateResponse
         */
        public DeleteTemplateResponse DeleteTemplateWithOptions(string TemplateId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteTemplate",
                Version = "2015-12-15",
                Protocol = "HTTPS",
                Pathname = "/templates/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(TemplateId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<DeleteTemplateResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Deletes the orchestration templates that you no longer need.
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteTemplateResponse
         */
        public async Task<DeleteTemplateResponse> DeleteTemplateWithOptionsAsync(string TemplateId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteTemplate",
                Version = "2015-12-15",
                Protocol = "HTTPS",
                Pathname = "/templates/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(TemplateId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<DeleteTemplateResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Deletes the orchestration templates that you no longer need.
         *
         * @return DeleteTemplateResponse
         */
        public DeleteTemplateResponse DeleteTemplate(string TemplateId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteTemplateWithOptions(TemplateId, headers, runtime);
        }

        /**
         * @summary Deletes the orchestration templates that you no longer need.
         *
         * @return DeleteTemplateResponse
         */
        public async Task<DeleteTemplateResponse> DeleteTemplateAsync(string TemplateId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteTemplateWithOptionsAsync(TemplateId, headers, runtime);
        }

        /**
         * @summary You can call the DeleteTrigger operation to delete an application trigger.
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteTriggerResponse
         */
        public DeleteTriggerResponse DeleteTriggerWithOptions(string clusterId, string Id, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteTrigger",
                Version = "2015-12-15",
                Protocol = "HTTPS",
                Pathname = "/clusters/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(clusterId) + "/triggers/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(Id),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<DeleteTriggerResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary You can call the DeleteTrigger operation to delete an application trigger.
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteTriggerResponse
         */
        public async Task<DeleteTriggerResponse> DeleteTriggerWithOptionsAsync(string clusterId, string Id, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteTrigger",
                Version = "2015-12-15",
                Protocol = "HTTPS",
                Pathname = "/clusters/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(clusterId) + "/triggers/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(Id),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<DeleteTriggerResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary You can call the DeleteTrigger operation to delete an application trigger.
         *
         * @return DeleteTriggerResponse
         */
        public DeleteTriggerResponse DeleteTrigger(string clusterId, string Id)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteTriggerWithOptions(clusterId, Id, headers, runtime);
        }

        /**
         * @summary You can call the DeleteTrigger operation to delete an application trigger.
         *
         * @return DeleteTriggerResponse
         */
        public async Task<DeleteTriggerResponse> DeleteTriggerAsync(string clusterId, string Id)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteTriggerWithOptionsAsync(clusterId, Id, headers, runtime);
        }

        /**
         * @summary Deploys a policy in the specified namespaces of a specific Container Service for Kubernetes (ACK) cluster. You can create and deploy a security policy by specifying the policy type, action of the policy such as alerting or denying, and namespaces to which the policy applies.
         *
         * @param request DeployPolicyInstanceRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeployPolicyInstanceResponse
         */
        public DeployPolicyInstanceResponse DeployPolicyInstanceWithOptions(string clusterId, string policyName, DeployPolicyInstanceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Action))
            {
                body["action"] = request.Action;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespaces))
            {
                body["namespaces"] = request.Namespaces;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Parameters))
            {
                body["parameters"] = request.Parameters;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeployPolicyInstance",
                Version = "2015-12-15",
                Protocol = "HTTPS",
                Pathname = "/clusters/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(clusterId) + "/policies/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(policyName),
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeployPolicyInstanceResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Deploys a policy in the specified namespaces of a specific Container Service for Kubernetes (ACK) cluster. You can create and deploy a security policy by specifying the policy type, action of the policy such as alerting or denying, and namespaces to which the policy applies.
         *
         * @param request DeployPolicyInstanceRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeployPolicyInstanceResponse
         */
        public async Task<DeployPolicyInstanceResponse> DeployPolicyInstanceWithOptionsAsync(string clusterId, string policyName, DeployPolicyInstanceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Action))
            {
                body["action"] = request.Action;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespaces))
            {
                body["namespaces"] = request.Namespaces;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Parameters))
            {
                body["parameters"] = request.Parameters;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeployPolicyInstance",
                Version = "2015-12-15",
                Protocol = "HTTPS",
                Pathname = "/clusters/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(clusterId) + "/policies/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(policyName),
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeployPolicyInstanceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Deploys a policy in the specified namespaces of a specific Container Service for Kubernetes (ACK) cluster. You can create and deploy a security policy by specifying the policy type, action of the policy such as alerting or denying, and namespaces to which the policy applies.
         *
         * @param request DeployPolicyInstanceRequest
         * @return DeployPolicyInstanceResponse
         */
        public DeployPolicyInstanceResponse DeployPolicyInstance(string clusterId, string policyName, DeployPolicyInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeployPolicyInstanceWithOptions(clusterId, policyName, request, headers, runtime);
        }

        /**
         * @summary Deploys a policy in the specified namespaces of a specific Container Service for Kubernetes (ACK) cluster. You can create and deploy a security policy by specifying the policy type, action of the policy such as alerting or denying, and namespaces to which the policy applies.
         *
         * @param request DeployPolicyInstanceRequest
         * @return DeployPolicyInstanceResponse
         */
        public async Task<DeployPolicyInstanceResponse> DeployPolicyInstanceAsync(string clusterId, string policyName, DeployPolicyInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeployPolicyInstanceWithOptionsAsync(clusterId, policyName, request, headers, runtime);
        }

        /**
         * @deprecated OpenAPI DescirbeWorkflow is deprecated
         *
         * @summary You can call the DescirbeWorkflow operation to query detailed information about a workflow.
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescirbeWorkflowResponse
         */
        // Deprecated
        public DescirbeWorkflowResponse DescirbeWorkflowWithOptions(string workflowName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescirbeWorkflow",
                Version = "2015-12-15",
                Protocol = "HTTPS",
                Pathname = "/gs/workflow/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workflowName),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescirbeWorkflowResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @deprecated OpenAPI DescirbeWorkflow is deprecated
         *
         * @summary You can call the DescirbeWorkflow operation to query detailed information about a workflow.
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescirbeWorkflowResponse
         */
        // Deprecated
        public async Task<DescirbeWorkflowResponse> DescirbeWorkflowWithOptionsAsync(string workflowName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescirbeWorkflow",
                Version = "2015-12-15",
                Protocol = "HTTPS",
                Pathname = "/gs/workflow/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workflowName),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescirbeWorkflowResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @deprecated OpenAPI DescirbeWorkflow is deprecated
         *
         * @summary You can call the DescirbeWorkflow operation to query detailed information about a workflow.
         *
         * @return DescirbeWorkflowResponse
         */
        // Deprecated
        public DescirbeWorkflowResponse DescirbeWorkflow(string workflowName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescirbeWorkflowWithOptions(workflowName, headers, runtime);
        }

        /**
         * @deprecated OpenAPI DescirbeWorkflow is deprecated
         *
         * @summary You can call the DescirbeWorkflow operation to query detailed information about a workflow.
         *
         * @return DescirbeWorkflowResponse
         */
        // Deprecated
        public async Task<DescirbeWorkflowResponse> DescirbeWorkflowAsync(string workflowName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescirbeWorkflowWithOptionsAsync(workflowName, headers, runtime);
        }

        /**
         * @summary 查询指定集群组件
         *
         * @param request DescribeAddonRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeAddonResponse
         */
        public DescribeAddonResponse DescribeAddonWithOptions(string addonName, DescribeAddonRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["cluster_id"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterSpec))
            {
                query["cluster_spec"] = request.ClusterSpec;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterType))
            {
                query["cluster_type"] = request.ClusterType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterVersion))
            {
                query["cluster_version"] = request.ClusterVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Profile))
            {
                query["profile"] = request.Profile;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["region_id"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Version))
            {
                query["version"] = request.Version;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeAddon",
                Version = "2015-12-15",
                Protocol = "HTTPS",
                Pathname = "/addons/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(addonName),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAddonResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 查询指定集群组件
         *
         * @param request DescribeAddonRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeAddonResponse
         */
        public async Task<DescribeAddonResponse> DescribeAddonWithOptionsAsync(string addonName, DescribeAddonRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["cluster_id"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterSpec))
            {
                query["cluster_spec"] = request.ClusterSpec;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterType))
            {
                query["cluster_type"] = request.ClusterType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterVersion))
            {
                query["cluster_version"] = request.ClusterVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Profile))
            {
                query["profile"] = request.Profile;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["region_id"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Version))
            {
                query["version"] = request.Version;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeAddon",
                Version = "2015-12-15",
                Protocol = "HTTPS",
                Pathname = "/addons/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(addonName),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAddonResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 查询指定集群组件
         *
         * @param request DescribeAddonRequest
         * @return DescribeAddonResponse
         */
        public DescribeAddonResponse DescribeAddon(string addonName, DescribeAddonRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeAddonWithOptions(addonName, request, headers, runtime);
        }

        /**
         * @summary 查询指定集群组件
         *
         * @param request DescribeAddonRequest
         * @return DescribeAddonResponse
         */
        public async Task<DescribeAddonResponse> DescribeAddonAsync(string addonName, DescribeAddonRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeAddonWithOptionsAsync(addonName, request, headers, runtime);
        }

        /**
         * @deprecated OpenAPI DescribeAddons is deprecated
         *
         * @summary You can call the DescribeAddons operation to query the details about all components that are supported by Container Service for Kubernetes (ACK).
         *
         * @param request DescribeAddonsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeAddonsResponse
         */
        // Deprecated
        public DescribeAddonsResponse DescribeAddonsWithOptions(DescribeAddonsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterProfile))
            {
                query["cluster_profile"] = request.ClusterProfile;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterSpec))
            {
                query["cluster_spec"] = request.ClusterSpec;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterType))
            {
                query["cluster_type"] = request.ClusterType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterVersion))
            {
                query["cluster_version"] = request.ClusterVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                query["region"] = request.Region;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeAddons",
                Version = "2015-12-15",
                Protocol = "HTTPS",
                Pathname = "/clusters/components/metadata",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAddonsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @deprecated OpenAPI DescribeAddons is deprecated
         *
         * @summary You can call the DescribeAddons operation to query the details about all components that are supported by Container Service for Kubernetes (ACK).
         *
         * @param request DescribeAddonsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeAddonsResponse
         */
        // Deprecated
        public async Task<DescribeAddonsResponse> DescribeAddonsWithOptionsAsync(DescribeAddonsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterProfile))
            {
                query["cluster_profile"] = request.ClusterProfile;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterSpec))
            {
                query["cluster_spec"] = request.ClusterSpec;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterType))
            {
                query["cluster_type"] = request.ClusterType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterVersion))
            {
                query["cluster_version"] = request.ClusterVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                query["region"] = request.Region;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeAddons",
                Version = "2015-12-15",
                Protocol = "HTTPS",
                Pathname = "/clusters/components/metadata",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAddonsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @deprecated OpenAPI DescribeAddons is deprecated
         *
         * @summary You can call the DescribeAddons operation to query the details about all components that are supported by Container Service for Kubernetes (ACK).
         *
         * @param request DescribeAddonsRequest
         * @return DescribeAddonsResponse
         */
        // Deprecated
        public DescribeAddonsResponse DescribeAddons(DescribeAddonsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeAddonsWithOptions(request, headers, runtime);
        }

        /**
         * @deprecated OpenAPI DescribeAddons is deprecated
         *
         * @summary You can call the DescribeAddons operation to query the details about all components that are supported by Container Service for Kubernetes (ACK).
         *
         * @param request DescribeAddonsRequest
         * @return DescribeAddonsResponse
         */
        // Deprecated
        public async Task<DescribeAddonsResponse> DescribeAddonsAsync(DescribeAddonsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeAddonsWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @deprecated OpenAPI DescribeClusterAddonInstance is deprecated
         *
         * @summary You can call the DescribeClusterAddonInstance operation to query the information about a cluster component, including the version, status, and configuration of the component.
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeClusterAddonInstanceResponse
         */
        // Deprecated
        public DescribeClusterAddonInstanceResponse DescribeClusterAddonInstanceWithOptions(string ClusterID, string AddonName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeClusterAddonInstance",
                Version = "2015-12-15",
                Protocol = "HTTPS",
                Pathname = "/clusters/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterID) + "/components/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(AddonName) + "/instance",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeClusterAddonInstanceResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @deprecated OpenAPI DescribeClusterAddonInstance is deprecated
         *
         * @summary You can call the DescribeClusterAddonInstance operation to query the information about a cluster component, including the version, status, and configuration of the component.
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeClusterAddonInstanceResponse
         */
        // Deprecated
        public async Task<DescribeClusterAddonInstanceResponse> DescribeClusterAddonInstanceWithOptionsAsync(string ClusterID, string AddonName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeClusterAddonInstance",
                Version = "2015-12-15",
                Protocol = "HTTPS",
                Pathname = "/clusters/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterID) + "/components/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(AddonName) + "/instance",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeClusterAddonInstanceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @deprecated OpenAPI DescribeClusterAddonInstance is deprecated
         *
         * @summary You can call the DescribeClusterAddonInstance operation to query the information about a cluster component, including the version, status, and configuration of the component.
         *
         * @return DescribeClusterAddonInstanceResponse
         */
        // Deprecated
        public DescribeClusterAddonInstanceResponse DescribeClusterAddonInstance(string ClusterID, string AddonName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeClusterAddonInstanceWithOptions(ClusterID, AddonName, headers, runtime);
        }

        /**
         * @deprecated OpenAPI DescribeClusterAddonInstance is deprecated
         *
         * @summary You can call the DescribeClusterAddonInstance operation to query the information about a cluster component, including the version, status, and configuration of the component.
         *
         * @return DescribeClusterAddonInstanceResponse
         */
        // Deprecated
        public async Task<DescribeClusterAddonInstanceResponse> DescribeClusterAddonInstanceAsync(string ClusterID, string AddonName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeClusterAddonInstanceWithOptionsAsync(ClusterID, AddonName, headers, runtime);
        }

        /**
         * @deprecated OpenAPI DescribeClusterAddonMetadata is deprecated
         *
         * @summary You can call the DescribeClusterAddonMetadata operation to query the metadata of a component version. The metadata includes the component version and available parameters.
         *
         * @param request DescribeClusterAddonMetadataRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeClusterAddonMetadataResponse
         */
        // Deprecated
        public DescribeClusterAddonMetadataResponse DescribeClusterAddonMetadataWithOptions(string clusterId, string componentId, DescribeClusterAddonMetadataRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Version))
            {
                query["version"] = request.Version;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeClusterAddonMetadata",
                Version = "2015-12-15",
                Protocol = "HTTPS",
                Pathname = "/clusters/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(clusterId) + "/components/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(componentId) + "/metadata",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeClusterAddonMetadataResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @deprecated OpenAPI DescribeClusterAddonMetadata is deprecated
         *
         * @summary You can call the DescribeClusterAddonMetadata operation to query the metadata of a component version. The metadata includes the component version and available parameters.
         *
         * @param request DescribeClusterAddonMetadataRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeClusterAddonMetadataResponse
         */
        // Deprecated
        public async Task<DescribeClusterAddonMetadataResponse> DescribeClusterAddonMetadataWithOptionsAsync(string clusterId, string componentId, DescribeClusterAddonMetadataRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Version))
            {
                query["version"] = request.Version;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeClusterAddonMetadata",
                Version = "2015-12-15",
                Protocol = "HTTPS",
                Pathname = "/clusters/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(clusterId) + "/components/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(componentId) + "/metadata",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeClusterAddonMetadataResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @deprecated OpenAPI DescribeClusterAddonMetadata is deprecated
         *
         * @summary You can call the DescribeClusterAddonMetadata operation to query the metadata of a component version. The metadata includes the component version and available parameters.
         *
         * @param request DescribeClusterAddonMetadataRequest
         * @return DescribeClusterAddonMetadataResponse
         */
        // Deprecated
        public DescribeClusterAddonMetadataResponse DescribeClusterAddonMetadata(string clusterId, string componentId, DescribeClusterAddonMetadataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeClusterAddonMetadataWithOptions(clusterId, componentId, request, headers, runtime);
        }

        /**
         * @deprecated OpenAPI DescribeClusterAddonMetadata is deprecated
         *
         * @summary You can call the DescribeClusterAddonMetadata operation to query the metadata of a component version. The metadata includes the component version and available parameters.
         *
         * @param request DescribeClusterAddonMetadataRequest
         * @return DescribeClusterAddonMetadataResponse
         */
        // Deprecated
        public async Task<DescribeClusterAddonMetadataResponse> DescribeClusterAddonMetadataAsync(string clusterId, string componentId, DescribeClusterAddonMetadataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeClusterAddonMetadataWithOptionsAsync(clusterId, componentId, request, headers, runtime);
        }

        /**
         * @deprecated OpenAPI DescribeClusterAddonUpgradeStatus is deprecated
         *
         * @summary You can call the DescribeClusterAddonUpgradeStatus operation to query the update progress of a cluster component.
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeClusterAddonUpgradeStatusResponse
         */
        // Deprecated
        public DescribeClusterAddonUpgradeStatusResponse DescribeClusterAddonUpgradeStatusWithOptions(string ClusterId, string ComponentId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeClusterAddonUpgradeStatus",
                Version = "2015-12-15",
                Protocol = "HTTPS",
                Pathname = "/clusters/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId) + "/components/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ComponentId) + "/upgradestatus",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeClusterAddonUpgradeStatusResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @deprecated OpenAPI DescribeClusterAddonUpgradeStatus is deprecated
         *
         * @summary You can call the DescribeClusterAddonUpgradeStatus operation to query the update progress of a cluster component.
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeClusterAddonUpgradeStatusResponse
         */
        // Deprecated
        public async Task<DescribeClusterAddonUpgradeStatusResponse> DescribeClusterAddonUpgradeStatusWithOptionsAsync(string ClusterId, string ComponentId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeClusterAddonUpgradeStatus",
                Version = "2015-12-15",
                Protocol = "HTTPS",
                Pathname = "/clusters/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId) + "/components/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ComponentId) + "/upgradestatus",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeClusterAddonUpgradeStatusResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @deprecated OpenAPI DescribeClusterAddonUpgradeStatus is deprecated
         *
         * @summary You can call the DescribeClusterAddonUpgradeStatus operation to query the update progress of a cluster component.
         *
         * @return DescribeClusterAddonUpgradeStatusResponse
         */
        // Deprecated
        public DescribeClusterAddonUpgradeStatusResponse DescribeClusterAddonUpgradeStatus(string ClusterId, string ComponentId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeClusterAddonUpgradeStatusWithOptions(ClusterId, ComponentId, headers, runtime);
        }

        /**
         * @deprecated OpenAPI DescribeClusterAddonUpgradeStatus is deprecated
         *
         * @summary You can call the DescribeClusterAddonUpgradeStatus operation to query the update progress of a cluster component.
         *
         * @return DescribeClusterAddonUpgradeStatusResponse
         */
        // Deprecated
        public async Task<DescribeClusterAddonUpgradeStatusResponse> DescribeClusterAddonUpgradeStatusAsync(string ClusterId, string ComponentId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeClusterAddonUpgradeStatusWithOptionsAsync(ClusterId, ComponentId, headers, runtime);
        }

        /**
         * @deprecated OpenAPI DescribeClusterAddonsUpgradeStatus is deprecated
         *
         * @summary You can call the DescribeClusterAddonsUpgradeStatus operation to query the update progress of a component by component name.
         *
         * @param tmpReq DescribeClusterAddonsUpgradeStatusRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeClusterAddonsUpgradeStatusResponse
         */
        // Deprecated
        public DescribeClusterAddonsUpgradeStatusResponse DescribeClusterAddonsUpgradeStatusWithOptions(string ClusterId, DescribeClusterAddonsUpgradeStatusRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DescribeClusterAddonsUpgradeStatusShrinkRequest request = new DescribeClusterAddonsUpgradeStatusShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ComponentIds))
            {
                request.ComponentIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ComponentIds, "componentIds", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ComponentIdsShrink))
            {
                query["componentIds"] = request.ComponentIdsShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeClusterAddonsUpgradeStatus",
                Version = "2015-12-15",
                Protocol = "HTTPS",
                Pathname = "/clusters/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId) + "/components/upgradestatus",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeClusterAddonsUpgradeStatusResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @deprecated OpenAPI DescribeClusterAddonsUpgradeStatus is deprecated
         *
         * @summary You can call the DescribeClusterAddonsUpgradeStatus operation to query the update progress of a component by component name.
         *
         * @param tmpReq DescribeClusterAddonsUpgradeStatusRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeClusterAddonsUpgradeStatusResponse
         */
        // Deprecated
        public async Task<DescribeClusterAddonsUpgradeStatusResponse> DescribeClusterAddonsUpgradeStatusWithOptionsAsync(string ClusterId, DescribeClusterAddonsUpgradeStatusRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DescribeClusterAddonsUpgradeStatusShrinkRequest request = new DescribeClusterAddonsUpgradeStatusShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ComponentIds))
            {
                request.ComponentIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ComponentIds, "componentIds", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ComponentIdsShrink))
            {
                query["componentIds"] = request.ComponentIdsShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeClusterAddonsUpgradeStatus",
                Version = "2015-12-15",
                Protocol = "HTTPS",
                Pathname = "/clusters/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId) + "/components/upgradestatus",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeClusterAddonsUpgradeStatusResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @deprecated OpenAPI DescribeClusterAddonsUpgradeStatus is deprecated
         *
         * @summary You can call the DescribeClusterAddonsUpgradeStatus operation to query the update progress of a component by component name.
         *
         * @param request DescribeClusterAddonsUpgradeStatusRequest
         * @return DescribeClusterAddonsUpgradeStatusResponse
         */
        // Deprecated
        public DescribeClusterAddonsUpgradeStatusResponse DescribeClusterAddonsUpgradeStatus(string ClusterId, DescribeClusterAddonsUpgradeStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeClusterAddonsUpgradeStatusWithOptions(ClusterId, request, headers, runtime);
        }

        /**
         * @deprecated OpenAPI DescribeClusterAddonsUpgradeStatus is deprecated
         *
         * @summary You can call the DescribeClusterAddonsUpgradeStatus operation to query the update progress of a component by component name.
         *
         * @param request DescribeClusterAddonsUpgradeStatusRequest
         * @return DescribeClusterAddonsUpgradeStatusResponse
         */
        // Deprecated
        public async Task<DescribeClusterAddonsUpgradeStatusResponse> DescribeClusterAddonsUpgradeStatusAsync(string ClusterId, DescribeClusterAddonsUpgradeStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeClusterAddonsUpgradeStatusWithOptionsAsync(ClusterId, request, headers, runtime);
        }

        /**
         * @deprecated OpenAPI DescribeClusterAddonsVersion is deprecated
         *
         * @summary You can call the DescribeClusterAddonsVersion operation to query the details about all components in a cluster by cluster ID.
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeClusterAddonsVersionResponse
         */
        // Deprecated
        public DescribeClusterAddonsVersionResponse DescribeClusterAddonsVersionWithOptions(string ClusterId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeClusterAddonsVersion",
                Version = "2015-12-15",
                Protocol = "HTTPS",
                Pathname = "/clusters/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId) + "/components/version",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeClusterAddonsVersionResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @deprecated OpenAPI DescribeClusterAddonsVersion is deprecated
         *
         * @summary You can call the DescribeClusterAddonsVersion operation to query the details about all components in a cluster by cluster ID.
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeClusterAddonsVersionResponse
         */
        // Deprecated
        public async Task<DescribeClusterAddonsVersionResponse> DescribeClusterAddonsVersionWithOptionsAsync(string ClusterId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeClusterAddonsVersion",
                Version = "2015-12-15",
                Protocol = "HTTPS",
                Pathname = "/clusters/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId) + "/components/version",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeClusterAddonsVersionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @deprecated OpenAPI DescribeClusterAddonsVersion is deprecated
         *
         * @summary You can call the DescribeClusterAddonsVersion operation to query the details about all components in a cluster by cluster ID.
         *
         * @return DescribeClusterAddonsVersionResponse
         */
        // Deprecated
        public DescribeClusterAddonsVersionResponse DescribeClusterAddonsVersion(string ClusterId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeClusterAddonsVersionWithOptions(ClusterId, headers, runtime);
        }

        /**
         * @deprecated OpenAPI DescribeClusterAddonsVersion is deprecated
         *
         * @summary You can call the DescribeClusterAddonsVersion operation to query the details about all components in a cluster by cluster ID.
         *
         * @return DescribeClusterAddonsVersionResponse
         */
        // Deprecated
        public async Task<DescribeClusterAddonsVersionResponse> DescribeClusterAddonsVersionAsync(string ClusterId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeClusterAddonsVersionWithOptionsAsync(ClusterId, headers, runtime);
        }

        /**
         * @summary Queries the script that is used to add existing nodes to a Container Service for Kubernetes (ACK) cluster. You can manually add existing Elastic Compute Service (ECS) instances to an ACK cluster as worker nodes or re-add the worker nodes that you have removed to a node pool.
         *
         * @param request DescribeClusterAttachScriptsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeClusterAttachScriptsResponse
         */
        public DescribeClusterAttachScriptsResponse DescribeClusterAttachScriptsWithOptions(string ClusterId, DescribeClusterAttachScriptsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Arch))
            {
                body["arch"] = request.Arch;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FormatDisk))
            {
                body["format_disk"] = request.FormatDisk;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeepInstanceName))
            {
                body["keep_instance_name"] = request.KeepInstanceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodepoolId))
            {
                body["nodepool_id"] = request.NodepoolId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Options))
            {
                body["options"] = request.Options;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RdsInstances))
            {
                body["rds_instances"] = request.RdsInstances;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeClusterAttachScripts",
                Version = "2015-12-15",
                Protocol = "HTTPS",
                Pathname = "/clusters/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId) + "/attachscript",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "string",
            };
            return TeaModel.ToObject<DescribeClusterAttachScriptsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the script that is used to add existing nodes to a Container Service for Kubernetes (ACK) cluster. You can manually add existing Elastic Compute Service (ECS) instances to an ACK cluster as worker nodes or re-add the worker nodes that you have removed to a node pool.
         *
         * @param request DescribeClusterAttachScriptsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeClusterAttachScriptsResponse
         */
        public async Task<DescribeClusterAttachScriptsResponse> DescribeClusterAttachScriptsWithOptionsAsync(string ClusterId, DescribeClusterAttachScriptsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Arch))
            {
                body["arch"] = request.Arch;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FormatDisk))
            {
                body["format_disk"] = request.FormatDisk;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeepInstanceName))
            {
                body["keep_instance_name"] = request.KeepInstanceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodepoolId))
            {
                body["nodepool_id"] = request.NodepoolId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Options))
            {
                body["options"] = request.Options;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RdsInstances))
            {
                body["rds_instances"] = request.RdsInstances;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeClusterAttachScripts",
                Version = "2015-12-15",
                Protocol = "HTTPS",
                Pathname = "/clusters/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId) + "/attachscript",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "string",
            };
            return TeaModel.ToObject<DescribeClusterAttachScriptsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the script that is used to add existing nodes to a Container Service for Kubernetes (ACK) cluster. You can manually add existing Elastic Compute Service (ECS) instances to an ACK cluster as worker nodes or re-add the worker nodes that you have removed to a node pool.
         *
         * @param request DescribeClusterAttachScriptsRequest
         * @return DescribeClusterAttachScriptsResponse
         */
        public DescribeClusterAttachScriptsResponse DescribeClusterAttachScripts(string ClusterId, DescribeClusterAttachScriptsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeClusterAttachScriptsWithOptions(ClusterId, request, headers, runtime);
        }

        /**
         * @summary Queries the script that is used to add existing nodes to a Container Service for Kubernetes (ACK) cluster. You can manually add existing Elastic Compute Service (ECS) instances to an ACK cluster as worker nodes or re-add the worker nodes that you have removed to a node pool.
         *
         * @param request DescribeClusterAttachScriptsRequest
         * @return DescribeClusterAttachScriptsResponse
         */
        public async Task<DescribeClusterAttachScriptsResponse> DescribeClusterAttachScriptsAsync(string ClusterId, DescribeClusterAttachScriptsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeClusterAttachScriptsWithOptionsAsync(ClusterId, request, headers, runtime);
        }

        /**
         * @summary You can call the DescribeClusterDetail operation to query the details of a Container Service for Kubernetes (ACK) cluster by cluster ID.
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeClusterDetailResponse
         */
        public DescribeClusterDetailResponse DescribeClusterDetailWithOptions(string ClusterId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeClusterDetail",
                Version = "2015-12-15",
                Protocol = "HTTPS",
                Pathname = "/clusters/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeClusterDetailResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary You can call the DescribeClusterDetail operation to query the details of a Container Service for Kubernetes (ACK) cluster by cluster ID.
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeClusterDetailResponse
         */
        public async Task<DescribeClusterDetailResponse> DescribeClusterDetailWithOptionsAsync(string ClusterId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeClusterDetail",
                Version = "2015-12-15",
                Protocol = "HTTPS",
                Pathname = "/clusters/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeClusterDetailResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary You can call the DescribeClusterDetail operation to query the details of a Container Service for Kubernetes (ACK) cluster by cluster ID.
         *
         * @return DescribeClusterDetailResponse
         */
        public DescribeClusterDetailResponse DescribeClusterDetail(string ClusterId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeClusterDetailWithOptions(ClusterId, headers, runtime);
        }

        /**
         * @summary You can call the DescribeClusterDetail operation to query the details of a Container Service for Kubernetes (ACK) cluster by cluster ID.
         *
         * @return DescribeClusterDetailResponse
         */
        public async Task<DescribeClusterDetailResponse> DescribeClusterDetailAsync(string ClusterId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeClusterDetailWithOptionsAsync(ClusterId, headers, runtime);
        }

        /**
         * @summary Queries events and event details in a Container Service for Kubernetes (ACK) cluster, including the severity level, status, and start time of each event. Events are generated when clusters created, modified, and updated, node pools are created and scaled out, and components are installed.
         *
         * @param request DescribeClusterEventsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeClusterEventsResponse
         */
        public DescribeClusterEventsResponse DescribeClusterEventsWithOptions(string ClusterId, DescribeClusterEventsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["page_number"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["page_size"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                query["task_id"] = request.TaskId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeClusterEvents",
                Version = "2015-12-15",
                Protocol = "HTTPS",
                Pathname = "/clusters/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId) + "/events",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeClusterEventsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries events and event details in a Container Service for Kubernetes (ACK) cluster, including the severity level, status, and start time of each event. Events are generated when clusters created, modified, and updated, node pools are created and scaled out, and components are installed.
         *
         * @param request DescribeClusterEventsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeClusterEventsResponse
         */
        public async Task<DescribeClusterEventsResponse> DescribeClusterEventsWithOptionsAsync(string ClusterId, DescribeClusterEventsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["page_number"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["page_size"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                query["task_id"] = request.TaskId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeClusterEvents",
                Version = "2015-12-15",
                Protocol = "HTTPS",
                Pathname = "/clusters/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId) + "/events",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeClusterEventsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries events and event details in a Container Service for Kubernetes (ACK) cluster, including the severity level, status, and start time of each event. Events are generated when clusters created, modified, and updated, node pools are created and scaled out, and components are installed.
         *
         * @param request DescribeClusterEventsRequest
         * @return DescribeClusterEventsResponse
         */
        public DescribeClusterEventsResponse DescribeClusterEvents(string ClusterId, DescribeClusterEventsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeClusterEventsWithOptions(ClusterId, request, headers, runtime);
        }

        /**
         * @summary Queries events and event details in a Container Service for Kubernetes (ACK) cluster, including the severity level, status, and start time of each event. Events are generated when clusters created, modified, and updated, node pools are created and scaled out, and components are installed.
         *
         * @param request DescribeClusterEventsRequest
         * @return DescribeClusterEventsResponse
         */
        public async Task<DescribeClusterEventsResponse> DescribeClusterEventsAsync(string ClusterId, DescribeClusterEventsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeClusterEventsWithOptionsAsync(ClusterId, request, headers, runtime);
        }

        /**
         * @summary Queries the cluster log to help analyze cluster issues and locate the cause.
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeClusterLogsResponse
         */
        public DescribeClusterLogsResponse DescribeClusterLogsWithOptions(string ClusterId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeClusterLogs",
                Version = "2015-12-15",
                Protocol = "HTTPS",
                Pathname = "/clusters/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId) + "/logs",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "array",
            };
            return TeaModel.ToObject<DescribeClusterLogsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the cluster log to help analyze cluster issues and locate the cause.
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeClusterLogsResponse
         */
        public async Task<DescribeClusterLogsResponse> DescribeClusterLogsWithOptionsAsync(string ClusterId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeClusterLogs",
                Version = "2015-12-15",
                Protocol = "HTTPS",
                Pathname = "/clusters/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId) + "/logs",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "array",
            };
            return TeaModel.ToObject<DescribeClusterLogsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the cluster log to help analyze cluster issues and locate the cause.
         *
         * @return DescribeClusterLogsResponse
         */
        public DescribeClusterLogsResponse DescribeClusterLogs(string ClusterId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeClusterLogsWithOptions(ClusterId, headers, runtime);
        }

        /**
         * @summary Queries the cluster log to help analyze cluster issues and locate the cause.
         *
         * @return DescribeClusterLogsResponse
         */
        public async Task<DescribeClusterLogsResponse> DescribeClusterLogsAsync(string ClusterId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeClusterLogsWithOptionsAsync(ClusterId, headers, runtime);
        }

        /**
         * @summary You can call the DescribeClusterNodePoolDetail.html operation to query the details about a node pool in a cluster by node pool ID.
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeClusterNodePoolDetailResponse
         */
        public DescribeClusterNodePoolDetailResponse DescribeClusterNodePoolDetailWithOptions(string ClusterId, string NodepoolId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeClusterNodePoolDetail",
                Version = "2015-12-15",
                Protocol = "HTTPS",
                Pathname = "/clusters/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId) + "/nodepools/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(NodepoolId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeClusterNodePoolDetailResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary You can call the DescribeClusterNodePoolDetail.html operation to query the details about a node pool in a cluster by node pool ID.
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeClusterNodePoolDetailResponse
         */
        public async Task<DescribeClusterNodePoolDetailResponse> DescribeClusterNodePoolDetailWithOptionsAsync(string ClusterId, string NodepoolId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeClusterNodePoolDetail",
                Version = "2015-12-15",
                Protocol = "HTTPS",
                Pathname = "/clusters/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId) + "/nodepools/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(NodepoolId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeClusterNodePoolDetailResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary You can call the DescribeClusterNodePoolDetail.html operation to query the details about a node pool in a cluster by node pool ID.
         *
         * @return DescribeClusterNodePoolDetailResponse
         */
        public DescribeClusterNodePoolDetailResponse DescribeClusterNodePoolDetail(string ClusterId, string NodepoolId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeClusterNodePoolDetailWithOptions(ClusterId, NodepoolId, headers, runtime);
        }

        /**
         * @summary You can call the DescribeClusterNodePoolDetail.html operation to query the details about a node pool in a cluster by node pool ID.
         *
         * @return DescribeClusterNodePoolDetailResponse
         */
        public async Task<DescribeClusterNodePoolDetailResponse> DescribeClusterNodePoolDetailAsync(string ClusterId, string NodepoolId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeClusterNodePoolDetailWithOptionsAsync(ClusterId, NodepoolId, headers, runtime);
        }

        /**
         * @summary Queries node pools in a Container Service for Kubernetes (ACK) cluster.
         *
         * @param request DescribeClusterNodePoolsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeClusterNodePoolsResponse
         */
        public DescribeClusterNodePoolsResponse DescribeClusterNodePoolsWithOptions(string ClusterId, DescribeClusterNodePoolsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodepoolName))
            {
                query["NodepoolName"] = request.NodepoolName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeClusterNodePools",
                Version = "2015-12-15",
                Protocol = "HTTPS",
                Pathname = "/clusters/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId) + "/nodepools",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeClusterNodePoolsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries node pools in a Container Service for Kubernetes (ACK) cluster.
         *
         * @param request DescribeClusterNodePoolsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeClusterNodePoolsResponse
         */
        public async Task<DescribeClusterNodePoolsResponse> DescribeClusterNodePoolsWithOptionsAsync(string ClusterId, DescribeClusterNodePoolsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodepoolName))
            {
                query["NodepoolName"] = request.NodepoolName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeClusterNodePools",
                Version = "2015-12-15",
                Protocol = "HTTPS",
                Pathname = "/clusters/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId) + "/nodepools",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeClusterNodePoolsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries node pools in a Container Service for Kubernetes (ACK) cluster.
         *
         * @param request DescribeClusterNodePoolsRequest
         * @return DescribeClusterNodePoolsResponse
         */
        public DescribeClusterNodePoolsResponse DescribeClusterNodePools(string ClusterId, DescribeClusterNodePoolsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeClusterNodePoolsWithOptions(ClusterId, request, headers, runtime);
        }

        /**
         * @summary Queries node pools in a Container Service for Kubernetes (ACK) cluster.
         *
         * @param request DescribeClusterNodePoolsRequest
         * @return DescribeClusterNodePoolsResponse
         */
        public async Task<DescribeClusterNodePoolsResponse> DescribeClusterNodePoolsAsync(string ClusterId, DescribeClusterNodePoolsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeClusterNodePoolsWithOptionsAsync(ClusterId, request, headers, runtime);
        }

        /**
         * @summary You can call the DescribeClusterNodes operation to query the details about all nodes in a cluster by cluster ID.
         *
         * @param request DescribeClusterNodesRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeClusterNodesResponse
         */
        public DescribeClusterNodesResponse DescribeClusterNodesWithOptions(string ClusterId, DescribeClusterNodesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceIds))
            {
                query["instanceIds"] = request.InstanceIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodepoolId))
            {
                query["nodepool_id"] = request.NodepoolId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.State))
            {
                query["state"] = request.State;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeClusterNodes",
                Version = "2015-12-15",
                Protocol = "HTTPS",
                Pathname = "/clusters/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId) + "/nodes",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeClusterNodesResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary You can call the DescribeClusterNodes operation to query the details about all nodes in a cluster by cluster ID.
         *
         * @param request DescribeClusterNodesRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeClusterNodesResponse
         */
        public async Task<DescribeClusterNodesResponse> DescribeClusterNodesWithOptionsAsync(string ClusterId, DescribeClusterNodesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceIds))
            {
                query["instanceIds"] = request.InstanceIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodepoolId))
            {
                query["nodepool_id"] = request.NodepoolId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.State))
            {
                query["state"] = request.State;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeClusterNodes",
                Version = "2015-12-15",
                Protocol = "HTTPS",
                Pathname = "/clusters/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId) + "/nodes",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeClusterNodesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary You can call the DescribeClusterNodes operation to query the details about all nodes in a cluster by cluster ID.
         *
         * @param request DescribeClusterNodesRequest
         * @return DescribeClusterNodesResponse
         */
        public DescribeClusterNodesResponse DescribeClusterNodes(string ClusterId, DescribeClusterNodesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeClusterNodesWithOptions(ClusterId, request, headers, runtime);
        }

        /**
         * @summary You can call the DescribeClusterNodes operation to query the details about all nodes in a cluster by cluster ID.
         *
         * @param request DescribeClusterNodesRequest
         * @return DescribeClusterNodesResponse
         */
        public async Task<DescribeClusterNodesResponse> DescribeClusterNodesAsync(string ClusterId, DescribeClusterNodesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeClusterNodesWithOptionsAsync(ClusterId, request, headers, runtime);
        }

        /**
         * @summary You can call the DescribeClusterResources operation to query all resources in a cluster by cluster ID.
         *
         * @param request DescribeClusterResourcesRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeClusterResourcesResponse
         */
        public DescribeClusterResourcesResponse DescribeClusterResourcesWithOptions(string ClusterId, DescribeClusterResourcesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WithAddonResources))
            {
                query["with_addon_resources"] = request.WithAddonResources;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeClusterResources",
                Version = "2015-12-15",
                Protocol = "HTTPS",
                Pathname = "/clusters/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId) + "/resources",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "array",
            };
            return TeaModel.ToObject<DescribeClusterResourcesResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary You can call the DescribeClusterResources operation to query all resources in a cluster by cluster ID.
         *
         * @param request DescribeClusterResourcesRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeClusterResourcesResponse
         */
        public async Task<DescribeClusterResourcesResponse> DescribeClusterResourcesWithOptionsAsync(string ClusterId, DescribeClusterResourcesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WithAddonResources))
            {
                query["with_addon_resources"] = request.WithAddonResources;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeClusterResources",
                Version = "2015-12-15",
                Protocol = "HTTPS",
                Pathname = "/clusters/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId) + "/resources",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "array",
            };
            return TeaModel.ToObject<DescribeClusterResourcesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary You can call the DescribeClusterResources operation to query all resources in a cluster by cluster ID.
         *
         * @param request DescribeClusterResourcesRequest
         * @return DescribeClusterResourcesResponse
         */
        public DescribeClusterResourcesResponse DescribeClusterResources(string ClusterId, DescribeClusterResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeClusterResourcesWithOptions(ClusterId, request, headers, runtime);
        }

        /**
         * @summary You can call the DescribeClusterResources operation to query all resources in a cluster by cluster ID.
         *
         * @param request DescribeClusterResourcesRequest
         * @return DescribeClusterResourcesResponse
         */
        public async Task<DescribeClusterResourcesResponse> DescribeClusterResourcesAsync(string ClusterId, DescribeClusterResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeClusterResourcesWithOptionsAsync(ClusterId, request, headers, runtime);
        }

        /**
         * @summary Queries tasks in a Container Service for Kubernetes (ACK) cluster.
         *
         * @param request DescribeClusterTasksRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeClusterTasksResponse
         */
        public DescribeClusterTasksResponse DescribeClusterTasksWithOptions(string clusterId, DescribeClusterTasksRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["page_number"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["page_size"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeClusterTasks",
                Version = "2015-12-15",
                Protocol = "HTTPS",
                Pathname = "/clusters/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(clusterId) + "/tasks",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeClusterTasksResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries tasks in a Container Service for Kubernetes (ACK) cluster.
         *
         * @param request DescribeClusterTasksRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeClusterTasksResponse
         */
        public async Task<DescribeClusterTasksResponse> DescribeClusterTasksWithOptionsAsync(string clusterId, DescribeClusterTasksRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["page_number"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["page_size"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeClusterTasks",
                Version = "2015-12-15",
                Protocol = "HTTPS",
                Pathname = "/clusters/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(clusterId) + "/tasks",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeClusterTasksResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries tasks in a Container Service for Kubernetes (ACK) cluster.
         *
         * @param request DescribeClusterTasksRequest
         * @return DescribeClusterTasksResponse
         */
        public DescribeClusterTasksResponse DescribeClusterTasks(string clusterId, DescribeClusterTasksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeClusterTasksWithOptions(clusterId, request, headers, runtime);
        }

        /**
         * @summary Queries tasks in a Container Service for Kubernetes (ACK) cluster.
         *
         * @param request DescribeClusterTasksRequest
         * @return DescribeClusterTasksResponse
         */
        public async Task<DescribeClusterTasksResponse> DescribeClusterTasksAsync(string clusterId, DescribeClusterTasksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeClusterTasksWithOptionsAsync(clusterId, request, headers, runtime);
        }

        /**
         * @summary Kubeconfig files store identity and authentication information that is used by clients to access Container Service for Kubernetes (ACK) clusters. To use a kubectl client to manage an ACK cluster, you need to use the corresponding kubeconfig file to connect to the ACK cluster. We recommend that you keep kubeconfig files confidential and revoke kubeconfig files that are not in use. This helps prevent data leaks caused by the disclosure of kubeconfig files.
         *
         * @description **
         * ****The default validity period of a kubeconfig file is 3 years. Two months before a kubeconfig file expires, you can renew it in the Container Service for Kubernetes (ACK) console or by calling API operations. After a kubeconfig file is renewed, the secret is valid for 3 years. The previous kubeconfig secret remains valid until expiration. We recommend that you renew your kubeconfig file at the earliest opportunity.
         *
         * @param request DescribeClusterUserKubeconfigRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeClusterUserKubeconfigResponse
         */
        public DescribeClusterUserKubeconfigResponse DescribeClusterUserKubeconfigWithOptions(string ClusterId, DescribeClusterUserKubeconfigRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PrivateIpAddress))
            {
                query["PrivateIpAddress"] = request.PrivateIpAddress;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemporaryDurationMinutes))
            {
                query["TemporaryDurationMinutes"] = request.TemporaryDurationMinutes;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeClusterUserKubeconfig",
                Version = "2015-12-15",
                Protocol = "HTTPS",
                Pathname = "/k8s/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId) + "/user_config",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeClusterUserKubeconfigResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Kubeconfig files store identity and authentication information that is used by clients to access Container Service for Kubernetes (ACK) clusters. To use a kubectl client to manage an ACK cluster, you need to use the corresponding kubeconfig file to connect to the ACK cluster. We recommend that you keep kubeconfig files confidential and revoke kubeconfig files that are not in use. This helps prevent data leaks caused by the disclosure of kubeconfig files.
         *
         * @description **
         * ****The default validity period of a kubeconfig file is 3 years. Two months before a kubeconfig file expires, you can renew it in the Container Service for Kubernetes (ACK) console or by calling API operations. After a kubeconfig file is renewed, the secret is valid for 3 years. The previous kubeconfig secret remains valid until expiration. We recommend that you renew your kubeconfig file at the earliest opportunity.
         *
         * @param request DescribeClusterUserKubeconfigRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeClusterUserKubeconfigResponse
         */
        public async Task<DescribeClusterUserKubeconfigResponse> DescribeClusterUserKubeconfigWithOptionsAsync(string ClusterId, DescribeClusterUserKubeconfigRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PrivateIpAddress))
            {
                query["PrivateIpAddress"] = request.PrivateIpAddress;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemporaryDurationMinutes))
            {
                query["TemporaryDurationMinutes"] = request.TemporaryDurationMinutes;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeClusterUserKubeconfig",
                Version = "2015-12-15",
                Protocol = "HTTPS",
                Pathname = "/k8s/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId) + "/user_config",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeClusterUserKubeconfigResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Kubeconfig files store identity and authentication information that is used by clients to access Container Service for Kubernetes (ACK) clusters. To use a kubectl client to manage an ACK cluster, you need to use the corresponding kubeconfig file to connect to the ACK cluster. We recommend that you keep kubeconfig files confidential and revoke kubeconfig files that are not in use. This helps prevent data leaks caused by the disclosure of kubeconfig files.
         *
         * @description **
         * ****The default validity period of a kubeconfig file is 3 years. Two months before a kubeconfig file expires, you can renew it in the Container Service for Kubernetes (ACK) console or by calling API operations. After a kubeconfig file is renewed, the secret is valid for 3 years. The previous kubeconfig secret remains valid until expiration. We recommend that you renew your kubeconfig file at the earliest opportunity.
         *
         * @param request DescribeClusterUserKubeconfigRequest
         * @return DescribeClusterUserKubeconfigResponse
         */
        public DescribeClusterUserKubeconfigResponse DescribeClusterUserKubeconfig(string ClusterId, DescribeClusterUserKubeconfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeClusterUserKubeconfigWithOptions(ClusterId, request, headers, runtime);
        }

        /**
         * @summary Kubeconfig files store identity and authentication information that is used by clients to access Container Service for Kubernetes (ACK) clusters. To use a kubectl client to manage an ACK cluster, you need to use the corresponding kubeconfig file to connect to the ACK cluster. We recommend that you keep kubeconfig files confidential and revoke kubeconfig files that are not in use. This helps prevent data leaks caused by the disclosure of kubeconfig files.
         *
         * @description **
         * ****The default validity period of a kubeconfig file is 3 years. Two months before a kubeconfig file expires, you can renew it in the Container Service for Kubernetes (ACK) console or by calling API operations. After a kubeconfig file is renewed, the secret is valid for 3 years. The previous kubeconfig secret remains valid until expiration. We recommend that you renew your kubeconfig file at the earliest opportunity.
         *
         * @param request DescribeClusterUserKubeconfigRequest
         * @return DescribeClusterUserKubeconfigResponse
         */
        public async Task<DescribeClusterUserKubeconfigResponse> DescribeClusterUserKubeconfigAsync(string ClusterId, DescribeClusterUserKubeconfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeClusterUserKubeconfigWithOptionsAsync(ClusterId, request, headers, runtime);
        }

        /**
         * @deprecated OpenAPI DescribeClusterV2UserKubeconfig is deprecated
         *
         * @summary 获取集群kubeconfig接口
         *
         * @param request DescribeClusterV2UserKubeconfigRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeClusterV2UserKubeconfigResponse
         */
        // Deprecated
        public DescribeClusterV2UserKubeconfigResponse DescribeClusterV2UserKubeconfigWithOptions(string ClusterId, DescribeClusterV2UserKubeconfigRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PrivateIpAddress))
            {
                query["PrivateIpAddress"] = request.PrivateIpAddress;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeClusterV2UserKubeconfig",
                Version = "2015-12-15",
                Protocol = "HTTPS",
                Pathname = "/api/v2/k8s/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId) + "/user_config",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeClusterV2UserKubeconfigResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @deprecated OpenAPI DescribeClusterV2UserKubeconfig is deprecated
         *
         * @summary 获取集群kubeconfig接口
         *
         * @param request DescribeClusterV2UserKubeconfigRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeClusterV2UserKubeconfigResponse
         */
        // Deprecated
        public async Task<DescribeClusterV2UserKubeconfigResponse> DescribeClusterV2UserKubeconfigWithOptionsAsync(string ClusterId, DescribeClusterV2UserKubeconfigRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PrivateIpAddress))
            {
                query["PrivateIpAddress"] = request.PrivateIpAddress;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeClusterV2UserKubeconfig",
                Version = "2015-12-15",
                Protocol = "HTTPS",
                Pathname = "/api/v2/k8s/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId) + "/user_config",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeClusterV2UserKubeconfigResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @deprecated OpenAPI DescribeClusterV2UserKubeconfig is deprecated
         *
         * @summary 获取集群kubeconfig接口
         *
         * @param request DescribeClusterV2UserKubeconfigRequest
         * @return DescribeClusterV2UserKubeconfigResponse
         */
        // Deprecated
        public DescribeClusterV2UserKubeconfigResponse DescribeClusterV2UserKubeconfig(string ClusterId, DescribeClusterV2UserKubeconfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeClusterV2UserKubeconfigWithOptions(ClusterId, request, headers, runtime);
        }

        /**
         * @deprecated OpenAPI DescribeClusterV2UserKubeconfig is deprecated
         *
         * @summary 获取集群kubeconfig接口
         *
         * @param request DescribeClusterV2UserKubeconfigRequest
         * @return DescribeClusterV2UserKubeconfigResponse
         */
        // Deprecated
        public async Task<DescribeClusterV2UserKubeconfigResponse> DescribeClusterV2UserKubeconfigAsync(string ClusterId, DescribeClusterV2UserKubeconfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeClusterV2UserKubeconfigWithOptionsAsync(ClusterId, request, headers, runtime);
        }

        /**
         * @summary Queries the security vulnerability details of a cluster by cluster ID. The details include vulnerability name, vulnerability type, and vulnerability severity. We recommend that you scan your cluster on a regular basis to ensure cluster security.
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeClusterVulsResponse
         */
        public DescribeClusterVulsResponse DescribeClusterVulsWithOptions(string clusterId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeClusterVuls",
                Version = "2015-12-15",
                Protocol = "HTTPS",
                Pathname = "/clusters/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(clusterId) + "/vuls",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeClusterVulsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the security vulnerability details of a cluster by cluster ID. The details include vulnerability name, vulnerability type, and vulnerability severity. We recommend that you scan your cluster on a regular basis to ensure cluster security.
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeClusterVulsResponse
         */
        public async Task<DescribeClusterVulsResponse> DescribeClusterVulsWithOptionsAsync(string clusterId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeClusterVuls",
                Version = "2015-12-15",
                Protocol = "HTTPS",
                Pathname = "/clusters/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(clusterId) + "/vuls",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeClusterVulsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the security vulnerability details of a cluster by cluster ID. The details include vulnerability name, vulnerability type, and vulnerability severity. We recommend that you scan your cluster on a regular basis to ensure cluster security.
         *
         * @return DescribeClusterVulsResponse
         */
        public DescribeClusterVulsResponse DescribeClusterVuls(string clusterId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeClusterVulsWithOptions(clusterId, headers, runtime);
        }

        /**
         * @summary Queries the security vulnerability details of a cluster by cluster ID. The details include vulnerability name, vulnerability type, and vulnerability severity. We recommend that you scan your cluster on a regular basis to ensure cluster security.
         *
         * @return DescribeClusterVulsResponse
         */
        public async Task<DescribeClusterVulsResponse> DescribeClusterVulsAsync(string clusterId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeClusterVulsWithOptionsAsync(clusterId, headers, runtime);
        }

        /**
         * @deprecated OpenAPI DescribeClusters is deprecated
         *
         * @summary You can call the DescribeClusters operation to query all the clusters that belong to the current Alibaba Cloud account, including Kubernetes clusters and Swarm clusters.
         *
         * @param request DescribeClustersRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeClustersResponse
         */
        // Deprecated
        public DescribeClustersResponse DescribeClustersWithOptions(DescribeClustersRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterType))
            {
                query["clusterType"] = request.ClusterType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["resource_group_id"] = request.ResourceGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeClusters",
                Version = "2015-12-15",
                Protocol = "HTTPS",
                Pathname = "/clusters",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "array",
            };
            return TeaModel.ToObject<DescribeClustersResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @deprecated OpenAPI DescribeClusters is deprecated
         *
         * @summary You can call the DescribeClusters operation to query all the clusters that belong to the current Alibaba Cloud account, including Kubernetes clusters and Swarm clusters.
         *
         * @param request DescribeClustersRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeClustersResponse
         */
        // Deprecated
        public async Task<DescribeClustersResponse> DescribeClustersWithOptionsAsync(DescribeClustersRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterType))
            {
                query["clusterType"] = request.ClusterType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["resource_group_id"] = request.ResourceGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeClusters",
                Version = "2015-12-15",
                Protocol = "HTTPS",
                Pathname = "/clusters",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "array",
            };
            return TeaModel.ToObject<DescribeClustersResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @deprecated OpenAPI DescribeClusters is deprecated
         *
         * @summary You can call the DescribeClusters operation to query all the clusters that belong to the current Alibaba Cloud account, including Kubernetes clusters and Swarm clusters.
         *
         * @param request DescribeClustersRequest
         * @return DescribeClustersResponse
         */
        // Deprecated
        public DescribeClustersResponse DescribeClusters(DescribeClustersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeClustersWithOptions(request, headers, runtime);
        }

        /**
         * @deprecated OpenAPI DescribeClusters is deprecated
         *
         * @summary You can call the DescribeClusters operation to query all the clusters that belong to the current Alibaba Cloud account, including Kubernetes clusters and Swarm clusters.
         *
         * @param request DescribeClustersRequest
         * @return DescribeClustersResponse
         */
        // Deprecated
        public async Task<DescribeClustersResponse> DescribeClustersAsync(DescribeClustersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeClustersWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary You can call the DescribeClustersV1 operation to query the details about all Container Service for Kubernetes (ACK) clusters.
         *
         * @param request DescribeClustersV1Request
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeClustersV1Response
         */
        public DescribeClustersV1Response DescribeClustersV1WithOptions(DescribeClustersV1Request request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["cluster_id"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterSpec))
            {
                query["cluster_spec"] = request.ClusterSpec;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterType))
            {
                query["cluster_type"] = request.ClusterType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["page_number"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["page_size"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Profile))
            {
                query["profile"] = request.Profile;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["region_id"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeClustersV1",
                Version = "2015-12-15",
                Protocol = "HTTPS",
                Pathname = "/api/v1/clusters",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeClustersV1Response>(CallApi(params_, req, runtime));
        }

        /**
         * @summary You can call the DescribeClustersV1 operation to query the details about all Container Service for Kubernetes (ACK) clusters.
         *
         * @param request DescribeClustersV1Request
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeClustersV1Response
         */
        public async Task<DescribeClustersV1Response> DescribeClustersV1WithOptionsAsync(DescribeClustersV1Request request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["cluster_id"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterSpec))
            {
                query["cluster_spec"] = request.ClusterSpec;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterType))
            {
                query["cluster_type"] = request.ClusterType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["page_number"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["page_size"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Profile))
            {
                query["profile"] = request.Profile;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["region_id"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeClustersV1",
                Version = "2015-12-15",
                Protocol = "HTTPS",
                Pathname = "/api/v1/clusters",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeClustersV1Response>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary You can call the DescribeClustersV1 operation to query the details about all Container Service for Kubernetes (ACK) clusters.
         *
         * @param request DescribeClustersV1Request
         * @return DescribeClustersV1Response
         */
        public DescribeClustersV1Response DescribeClustersV1(DescribeClustersV1Request request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeClustersV1WithOptions(request, headers, runtime);
        }

        /**
         * @summary You can call the DescribeClustersV1 operation to query the details about all Container Service for Kubernetes (ACK) clusters.
         *
         * @param request DescribeClustersV1Request
         * @return DescribeClustersV1Response
         */
        public async Task<DescribeClustersV1Response> DescribeClustersV1Async(DescribeClustersV1Request request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeClustersV1WithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary You can call the DescribeEdgeMachineActiveProcess operation to query the activation progress of a cloud-native box.
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeEdgeMachineActiveProcessResponse
         */
        public DescribeEdgeMachineActiveProcessResponse DescribeEdgeMachineActiveProcessWithOptions(string edgeMachineid, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeEdgeMachineActiveProcess",
                Version = "2015-12-15",
                Protocol = "HTTPS",
                Pathname = "/edge_machines/%5Bedge_machineid%5D/activeprocess",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeEdgeMachineActiveProcessResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary You can call the DescribeEdgeMachineActiveProcess operation to query the activation progress of a cloud-native box.
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeEdgeMachineActiveProcessResponse
         */
        public async Task<DescribeEdgeMachineActiveProcessResponse> DescribeEdgeMachineActiveProcessWithOptionsAsync(string edgeMachineid, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeEdgeMachineActiveProcess",
                Version = "2015-12-15",
                Protocol = "HTTPS",
                Pathname = "/edge_machines/%5Bedge_machineid%5D/activeprocess",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeEdgeMachineActiveProcessResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary You can call the DescribeEdgeMachineActiveProcess operation to query the activation progress of a cloud-native box.
         *
         * @return DescribeEdgeMachineActiveProcessResponse
         */
        public DescribeEdgeMachineActiveProcessResponse DescribeEdgeMachineActiveProcess(string edgeMachineid)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeEdgeMachineActiveProcessWithOptions(edgeMachineid, headers, runtime);
        }

        /**
         * @summary You can call the DescribeEdgeMachineActiveProcess operation to query the activation progress of a cloud-native box.
         *
         * @return DescribeEdgeMachineActiveProcessResponse
         */
        public async Task<DescribeEdgeMachineActiveProcessResponse> DescribeEdgeMachineActiveProcessAsync(string edgeMachineid)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeEdgeMachineActiveProcessWithOptionsAsync(edgeMachineid, headers, runtime);
        }

        /**
         * @summary You can call the DescribeEdgeMachineModels operation to query the cloud-native box models.
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeEdgeMachineModelsResponse
         */
        public DescribeEdgeMachineModelsResponse DescribeEdgeMachineModelsWithOptions(Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeEdgeMachineModels",
                Version = "2015-12-15",
                Protocol = "HTTPS",
                Pathname = "/edge_machines/models",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeEdgeMachineModelsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary You can call the DescribeEdgeMachineModels operation to query the cloud-native box models.
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeEdgeMachineModelsResponse
         */
        public async Task<DescribeEdgeMachineModelsResponse> DescribeEdgeMachineModelsWithOptionsAsync(Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeEdgeMachineModels",
                Version = "2015-12-15",
                Protocol = "HTTPS",
                Pathname = "/edge_machines/models",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeEdgeMachineModelsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary You can call the DescribeEdgeMachineModels operation to query the cloud-native box models.
         *
         * @return DescribeEdgeMachineModelsResponse
         */
        public DescribeEdgeMachineModelsResponse DescribeEdgeMachineModels()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeEdgeMachineModelsWithOptions(headers, runtime);
        }

        /**
         * @summary You can call the DescribeEdgeMachineModels operation to query the cloud-native box models.
         *
         * @return DescribeEdgeMachineModelsResponse
         */
        public async Task<DescribeEdgeMachineModelsResponse> DescribeEdgeMachineModelsAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeEdgeMachineModelsWithOptionsAsync(headers, runtime);
        }

        /**
         * @summary You can call the DescribeEdgeMachineTunnelConfigDetail operation to obtain the SSH token of a cloud-native box.
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeEdgeMachineTunnelConfigDetailResponse
         */
        public DescribeEdgeMachineTunnelConfigDetailResponse DescribeEdgeMachineTunnelConfigDetailWithOptions(string edgeMachineid, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeEdgeMachineTunnelConfigDetail",
                Version = "2015-12-15",
                Protocol = "HTTPS",
                Pathname = "/edge_machines/%5Bedge_machineid%5D/tunnelconfig",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeEdgeMachineTunnelConfigDetailResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary You can call the DescribeEdgeMachineTunnelConfigDetail operation to obtain the SSH token of a cloud-native box.
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeEdgeMachineTunnelConfigDetailResponse
         */
        public async Task<DescribeEdgeMachineTunnelConfigDetailResponse> DescribeEdgeMachineTunnelConfigDetailWithOptionsAsync(string edgeMachineid, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeEdgeMachineTunnelConfigDetail",
                Version = "2015-12-15",
                Protocol = "HTTPS",
                Pathname = "/edge_machines/%5Bedge_machineid%5D/tunnelconfig",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeEdgeMachineTunnelConfigDetailResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary You can call the DescribeEdgeMachineTunnelConfigDetail operation to obtain the SSH token of a cloud-native box.
         *
         * @return DescribeEdgeMachineTunnelConfigDetailResponse
         */
        public DescribeEdgeMachineTunnelConfigDetailResponse DescribeEdgeMachineTunnelConfigDetail(string edgeMachineid)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeEdgeMachineTunnelConfigDetailWithOptions(edgeMachineid, headers, runtime);
        }

        /**
         * @summary You can call the DescribeEdgeMachineTunnelConfigDetail operation to obtain the SSH token of a cloud-native box.
         *
         * @return DescribeEdgeMachineTunnelConfigDetailResponse
         */
        public async Task<DescribeEdgeMachineTunnelConfigDetailResponse> DescribeEdgeMachineTunnelConfigDetailAsync(string edgeMachineid)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeEdgeMachineTunnelConfigDetailWithOptionsAsync(edgeMachineid, headers, runtime);
        }

        /**
         * @summary You can call the DescribeEdgeMachines operation to query a list of cloud-native boxes.
         *
         * @param request DescribeEdgeMachinesRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeEdgeMachinesResponse
         */
        public DescribeEdgeMachinesResponse DescribeEdgeMachinesWithOptions(DescribeEdgeMachinesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Hostname))
            {
                query["hostname"] = request.Hostname;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LifeState))
            {
                query["life_state"] = request.LifeState;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Model))
            {
                query["model"] = request.Model;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OnlineState))
            {
                query["online_state"] = request.OnlineState;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["page_number"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["page_size"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeEdgeMachines",
                Version = "2015-12-15",
                Protocol = "HTTPS",
                Pathname = "/edge_machines",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeEdgeMachinesResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary You can call the DescribeEdgeMachines operation to query a list of cloud-native boxes.
         *
         * @param request DescribeEdgeMachinesRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeEdgeMachinesResponse
         */
        public async Task<DescribeEdgeMachinesResponse> DescribeEdgeMachinesWithOptionsAsync(DescribeEdgeMachinesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Hostname))
            {
                query["hostname"] = request.Hostname;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LifeState))
            {
                query["life_state"] = request.LifeState;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Model))
            {
                query["model"] = request.Model;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OnlineState))
            {
                query["online_state"] = request.OnlineState;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["page_number"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["page_size"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeEdgeMachines",
                Version = "2015-12-15",
                Protocol = "HTTPS",
                Pathname = "/edge_machines",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeEdgeMachinesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary You can call the DescribeEdgeMachines operation to query a list of cloud-native boxes.
         *
         * @param request DescribeEdgeMachinesRequest
         * @return DescribeEdgeMachinesResponse
         */
        public DescribeEdgeMachinesResponse DescribeEdgeMachines(DescribeEdgeMachinesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeEdgeMachinesWithOptions(request, headers, runtime);
        }

        /**
         * @summary You can call the DescribeEdgeMachines operation to query a list of cloud-native boxes.
         *
         * @param request DescribeEdgeMachinesRequest
         * @return DescribeEdgeMachinesResponse
         */
        public async Task<DescribeEdgeMachinesResponse> DescribeEdgeMachinesAsync(DescribeEdgeMachinesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeEdgeMachinesWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary Queries detailed information about a type of events, including the severity level, status, and start time of each event. Events are generated when clusters are created, modified, and updated, node pools are created and scaled out, and components are installed.
         *
         * @param request DescribeEventsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeEventsResponse
         */
        public DescribeEventsResponse DescribeEventsWithOptions(DescribeEventsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["cluster_id"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["page_number"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["page_size"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["type"] = request.Type;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeEvents",
                Version = "2015-12-15",
                Protocol = "HTTPS",
                Pathname = "/events",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeEventsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries detailed information about a type of events, including the severity level, status, and start time of each event. Events are generated when clusters are created, modified, and updated, node pools are created and scaled out, and components are installed.
         *
         * @param request DescribeEventsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeEventsResponse
         */
        public async Task<DescribeEventsResponse> DescribeEventsWithOptionsAsync(DescribeEventsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["cluster_id"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["page_number"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["page_size"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["type"] = request.Type;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeEvents",
                Version = "2015-12-15",
                Protocol = "HTTPS",
                Pathname = "/events",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeEventsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries detailed information about a type of events, including the severity level, status, and start time of each event. Events are generated when clusters are created, modified, and updated, node pools are created and scaled out, and components are installed.
         *
         * @param request DescribeEventsRequest
         * @return DescribeEventsResponse
         */
        public DescribeEventsResponse DescribeEvents(DescribeEventsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeEventsWithOptions(request, headers, runtime);
        }

        /**
         * @summary Queries detailed information about a type of events, including the severity level, status, and start time of each event. Events are generated when clusters are created, modified, and updated, node pools are created and scaled out, and components are installed.
         *
         * @param request DescribeEventsRequest
         * @return DescribeEventsResponse
         */
        public async Task<DescribeEventsResponse> DescribeEventsAsync(DescribeEventsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeEventsWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary You can call the DescribeExternalAgent operation to query the agent configurations of a registered cluster by cluster ID.
         *
         * @description For more information, see [Register an external Kubernetes cluster](https://help.aliyun.com/document_detail/121053.html).
         *
         * @param request DescribeExternalAgentRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeExternalAgentResponse
         */
        public DescribeExternalAgentResponse DescribeExternalAgentWithOptions(string ClusterId, DescribeExternalAgentRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentMode))
            {
                query["AgentMode"] = request.AgentMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PrivateIpAddress))
            {
                query["PrivateIpAddress"] = request.PrivateIpAddress;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeExternalAgent",
                Version = "2015-12-15",
                Protocol = "HTTPS",
                Pathname = "/k8s/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId) + "/external/agent/deployment",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeExternalAgentResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary You can call the DescribeExternalAgent operation to query the agent configurations of a registered cluster by cluster ID.
         *
         * @description For more information, see [Register an external Kubernetes cluster](https://help.aliyun.com/document_detail/121053.html).
         *
         * @param request DescribeExternalAgentRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeExternalAgentResponse
         */
        public async Task<DescribeExternalAgentResponse> DescribeExternalAgentWithOptionsAsync(string ClusterId, DescribeExternalAgentRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AgentMode))
            {
                query["AgentMode"] = request.AgentMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PrivateIpAddress))
            {
                query["PrivateIpAddress"] = request.PrivateIpAddress;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeExternalAgent",
                Version = "2015-12-15",
                Protocol = "HTTPS",
                Pathname = "/k8s/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId) + "/external/agent/deployment",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeExternalAgentResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary You can call the DescribeExternalAgent operation to query the agent configurations of a registered cluster by cluster ID.
         *
         * @description For more information, see [Register an external Kubernetes cluster](https://help.aliyun.com/document_detail/121053.html).
         *
         * @param request DescribeExternalAgentRequest
         * @return DescribeExternalAgentResponse
         */
        public DescribeExternalAgentResponse DescribeExternalAgent(string ClusterId, DescribeExternalAgentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeExternalAgentWithOptions(ClusterId, request, headers, runtime);
        }

        /**
         * @summary You can call the DescribeExternalAgent operation to query the agent configurations of a registered cluster by cluster ID.
         *
         * @description For more information, see [Register an external Kubernetes cluster](https://help.aliyun.com/document_detail/121053.html).
         *
         * @param request DescribeExternalAgentRequest
         * @return DescribeExternalAgentResponse
         */
        public async Task<DescribeExternalAgentResponse> DescribeExternalAgentAsync(string ClusterId, DescribeExternalAgentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeExternalAgentWithOptionsAsync(ClusterId, request, headers, runtime);
        }

        /**
         * @summary Queries the detailed information about Kubernetes versions, including the version number, release date, expiration date, compatible OSs, and runtime.
         *
         * @param request DescribeKubernetesVersionMetadataRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeKubernetesVersionMetadataResponse
         */
        public DescribeKubernetesVersionMetadataResponse DescribeKubernetesVersionMetadataWithOptions(DescribeKubernetesVersionMetadataRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterType))
            {
                query["ClusterType"] = request.ClusterType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KubernetesVersion))
            {
                query["KubernetesVersion"] = request.KubernetesVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mode))
            {
                query["Mode"] = request.Mode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Profile))
            {
                query["Profile"] = request.Profile;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueryUpgradableVersion))
            {
                query["QueryUpgradableVersion"] = request.QueryUpgradableVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                query["Region"] = request.Region;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Runtime))
            {
                query["runtime"] = request.Runtime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeKubernetesVersionMetadata",
                Version = "2015-12-15",
                Protocol = "HTTPS",
                Pathname = "/api/v1/metadata/versions",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "array",
            };
            return TeaModel.ToObject<DescribeKubernetesVersionMetadataResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the detailed information about Kubernetes versions, including the version number, release date, expiration date, compatible OSs, and runtime.
         *
         * @param request DescribeKubernetesVersionMetadataRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeKubernetesVersionMetadataResponse
         */
        public async Task<DescribeKubernetesVersionMetadataResponse> DescribeKubernetesVersionMetadataWithOptionsAsync(DescribeKubernetesVersionMetadataRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterType))
            {
                query["ClusterType"] = request.ClusterType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KubernetesVersion))
            {
                query["KubernetesVersion"] = request.KubernetesVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mode))
            {
                query["Mode"] = request.Mode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Profile))
            {
                query["Profile"] = request.Profile;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueryUpgradableVersion))
            {
                query["QueryUpgradableVersion"] = request.QueryUpgradableVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                query["Region"] = request.Region;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Runtime))
            {
                query["runtime"] = request.Runtime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeKubernetesVersionMetadata",
                Version = "2015-12-15",
                Protocol = "HTTPS",
                Pathname = "/api/v1/metadata/versions",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "array",
            };
            return TeaModel.ToObject<DescribeKubernetesVersionMetadataResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the detailed information about Kubernetes versions, including the version number, release date, expiration date, compatible OSs, and runtime.
         *
         * @param request DescribeKubernetesVersionMetadataRequest
         * @return DescribeKubernetesVersionMetadataResponse
         */
        public DescribeKubernetesVersionMetadataResponse DescribeKubernetesVersionMetadata(DescribeKubernetesVersionMetadataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeKubernetesVersionMetadataWithOptions(request, headers, runtime);
        }

        /**
         * @summary Queries the detailed information about Kubernetes versions, including the version number, release date, expiration date, compatible OSs, and runtime.
         *
         * @param request DescribeKubernetesVersionMetadataRequest
         * @return DescribeKubernetesVersionMetadataResponse
         */
        public async Task<DescribeKubernetesVersionMetadataResponse> DescribeKubernetesVersionMetadataAsync(DescribeKubernetesVersionMetadataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeKubernetesVersionMetadataWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary Queries the vulnerability information of a node pool, such as vulnerability names and severity levels, by specifying the ID of the node pool. We recommend that you periodically scan node pools for vulnerabilities to enhance cluster security.
         *
         * @param request DescribeNodePoolVulsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeNodePoolVulsResponse
         */
        public DescribeNodePoolVulsResponse DescribeNodePoolVulsWithOptions(string clusterId, string nodepoolId, DescribeNodePoolVulsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Necessity))
            {
                query["necessity"] = request.Necessity;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeNodePoolVuls",
                Version = "2015-12-15",
                Protocol = "HTTPS",
                Pathname = "/clusters/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(clusterId) + "/nodepools/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(nodepoolId) + "/vuls",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeNodePoolVulsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the vulnerability information of a node pool, such as vulnerability names and severity levels, by specifying the ID of the node pool. We recommend that you periodically scan node pools for vulnerabilities to enhance cluster security.
         *
         * @param request DescribeNodePoolVulsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeNodePoolVulsResponse
         */
        public async Task<DescribeNodePoolVulsResponse> DescribeNodePoolVulsWithOptionsAsync(string clusterId, string nodepoolId, DescribeNodePoolVulsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Necessity))
            {
                query["necessity"] = request.Necessity;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeNodePoolVuls",
                Version = "2015-12-15",
                Protocol = "HTTPS",
                Pathname = "/clusters/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(clusterId) + "/nodepools/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(nodepoolId) + "/vuls",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeNodePoolVulsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the vulnerability information of a node pool, such as vulnerability names and severity levels, by specifying the ID of the node pool. We recommend that you periodically scan node pools for vulnerabilities to enhance cluster security.
         *
         * @param request DescribeNodePoolVulsRequest
         * @return DescribeNodePoolVulsResponse
         */
        public DescribeNodePoolVulsResponse DescribeNodePoolVuls(string clusterId, string nodepoolId, DescribeNodePoolVulsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeNodePoolVulsWithOptions(clusterId, nodepoolId, request, headers, runtime);
        }

        /**
         * @summary Queries the vulnerability information of a node pool, such as vulnerability names and severity levels, by specifying the ID of the node pool. We recommend that you periodically scan node pools for vulnerabilities to enhance cluster security.
         *
         * @param request DescribeNodePoolVulsRequest
         * @return DescribeNodePoolVulsResponse
         */
        public async Task<DescribeNodePoolVulsResponse> DescribeNodePoolVulsAsync(string clusterId, string nodepoolId, DescribeNodePoolVulsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeNodePoolVulsWithOptionsAsync(clusterId, nodepoolId, request, headers, runtime);
        }

        /**
         * @summary Queries the policies for a Container Service for Kubernetes (ACK) cluster. Container security policies for ACK clusters offer a variety of built-in policies, including cis-k8s, infra, k8s-general, and PodSecurityPolicy. You can use these policies to ensure the security of containers running in a production environment.
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribePoliciesResponse
         */
        public DescribePoliciesResponse DescribePoliciesWithOptions(Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribePolicies",
                Version = "2015-12-15",
                Protocol = "HTTPS",
                Pathname = "/policies",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribePoliciesResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the policies for a Container Service for Kubernetes (ACK) cluster. Container security policies for ACK clusters offer a variety of built-in policies, including cis-k8s, infra, k8s-general, and PodSecurityPolicy. You can use these policies to ensure the security of containers running in a production environment.
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribePoliciesResponse
         */
        public async Task<DescribePoliciesResponse> DescribePoliciesWithOptionsAsync(Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribePolicies",
                Version = "2015-12-15",
                Protocol = "HTTPS",
                Pathname = "/policies",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribePoliciesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the policies for a Container Service for Kubernetes (ACK) cluster. Container security policies for ACK clusters offer a variety of built-in policies, including cis-k8s, infra, k8s-general, and PodSecurityPolicy. You can use these policies to ensure the security of containers running in a production environment.
         *
         * @return DescribePoliciesResponse
         */
        public DescribePoliciesResponse DescribePolicies()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribePoliciesWithOptions(headers, runtime);
        }

        /**
         * @summary Queries the policies for a Container Service for Kubernetes (ACK) cluster. Container security policies for ACK clusters offer a variety of built-in policies, including cis-k8s, infra, k8s-general, and PodSecurityPolicy. You can use these policies to ensure the security of containers running in a production environment.
         *
         * @return DescribePoliciesResponse
         */
        public async Task<DescribePoliciesResponse> DescribePoliciesAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribePoliciesWithOptionsAsync(headers, runtime);
        }

        /**
         * @summary Container security policies for Container Service for Kubernetes (ACK) clusters offer a variety of built-in policies, including cis-k8s, infra, k8s-general, and PodSecurityPolicy. You can use these policies to ensure the security of containers running in a production environment. You can call the DescribePolicyDetails operation to query information about a policy, such as the content, action, and severity level of the policy.
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribePolicyDetailsResponse
         */
        public DescribePolicyDetailsResponse DescribePolicyDetailsWithOptions(string policyName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribePolicyDetails",
                Version = "2015-12-15",
                Protocol = "HTTPS",
                Pathname = "/policies/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(policyName),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribePolicyDetailsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Container security policies for Container Service for Kubernetes (ACK) clusters offer a variety of built-in policies, including cis-k8s, infra, k8s-general, and PodSecurityPolicy. You can use these policies to ensure the security of containers running in a production environment. You can call the DescribePolicyDetails operation to query information about a policy, such as the content, action, and severity level of the policy.
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribePolicyDetailsResponse
         */
        public async Task<DescribePolicyDetailsResponse> DescribePolicyDetailsWithOptionsAsync(string policyName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribePolicyDetails",
                Version = "2015-12-15",
                Protocol = "HTTPS",
                Pathname = "/policies/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(policyName),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribePolicyDetailsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Container security policies for Container Service for Kubernetes (ACK) clusters offer a variety of built-in policies, including cis-k8s, infra, k8s-general, and PodSecurityPolicy. You can use these policies to ensure the security of containers running in a production environment. You can call the DescribePolicyDetails operation to query information about a policy, such as the content, action, and severity level of the policy.
         *
         * @return DescribePolicyDetailsResponse
         */
        public DescribePolicyDetailsResponse DescribePolicyDetails(string policyName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribePolicyDetailsWithOptions(policyName, headers, runtime);
        }

        /**
         * @summary Container security policies for Container Service for Kubernetes (ACK) clusters offer a variety of built-in policies, including cis-k8s, infra, k8s-general, and PodSecurityPolicy. You can use these policies to ensure the security of containers running in a production environment. You can call the DescribePolicyDetails operation to query information about a policy, such as the content, action, and severity level of the policy.
         *
         * @return DescribePolicyDetailsResponse
         */
        public async Task<DescribePolicyDetailsResponse> DescribePolicyDetailsAsync(string policyName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribePolicyDetailsWithOptionsAsync(policyName, headers, runtime);
        }

        /**
         * @summary Queries the details of policies for a Container Service for Kubernetes (ACK) cluster. For example, you can query the number of multi-level policies that are enabled for the cluster, audit logs of the policies, and denying and alerting information. Container security policies for ACK clusters offer a variety of built-in policies, such as cis-k8s, infra, k8s-general, and PodSecurityPolicy. You can use these policies to ensure the security of containers running in a production environment.
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribePolicyGovernanceInClusterResponse
         */
        public DescribePolicyGovernanceInClusterResponse DescribePolicyGovernanceInClusterWithOptions(string clusterId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribePolicyGovernanceInCluster",
                Version = "2015-12-15",
                Protocol = "HTTPS",
                Pathname = "/clusters/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(clusterId) + "/policygovernance",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribePolicyGovernanceInClusterResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the details of policies for a Container Service for Kubernetes (ACK) cluster. For example, you can query the number of multi-level policies that are enabled for the cluster, audit logs of the policies, and denying and alerting information. Container security policies for ACK clusters offer a variety of built-in policies, such as cis-k8s, infra, k8s-general, and PodSecurityPolicy. You can use these policies to ensure the security of containers running in a production environment.
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribePolicyGovernanceInClusterResponse
         */
        public async Task<DescribePolicyGovernanceInClusterResponse> DescribePolicyGovernanceInClusterWithOptionsAsync(string clusterId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribePolicyGovernanceInCluster",
                Version = "2015-12-15",
                Protocol = "HTTPS",
                Pathname = "/clusters/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(clusterId) + "/policygovernance",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribePolicyGovernanceInClusterResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the details of policies for a Container Service for Kubernetes (ACK) cluster. For example, you can query the number of multi-level policies that are enabled for the cluster, audit logs of the policies, and denying and alerting information. Container security policies for ACK clusters offer a variety of built-in policies, such as cis-k8s, infra, k8s-general, and PodSecurityPolicy. You can use these policies to ensure the security of containers running in a production environment.
         *
         * @return DescribePolicyGovernanceInClusterResponse
         */
        public DescribePolicyGovernanceInClusterResponse DescribePolicyGovernanceInCluster(string clusterId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribePolicyGovernanceInClusterWithOptions(clusterId, headers, runtime);
        }

        /**
         * @summary Queries the details of policies for a Container Service for Kubernetes (ACK) cluster. For example, you can query the number of multi-level policies that are enabled for the cluster, audit logs of the policies, and denying and alerting information. Container security policies for ACK clusters offer a variety of built-in policies, such as cis-k8s, infra, k8s-general, and PodSecurityPolicy. You can use these policies to ensure the security of containers running in a production environment.
         *
         * @return DescribePolicyGovernanceInClusterResponse
         */
        public async Task<DescribePolicyGovernanceInClusterResponse> DescribePolicyGovernanceInClusterAsync(string clusterId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribePolicyGovernanceInClusterWithOptionsAsync(clusterId, headers, runtime);
        }

        /**
         * @summary Queries the detailed information about policy instances of the specified type in a Container Service for Kubernetes (ACK) cluster, such as the policy description and severity level. You can choose a type of security policy for an ACK cluster, specify the action and applicable scope of the policy, and then create and deploy a policy instance.
         *
         * @param request DescribePolicyInstancesRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribePolicyInstancesResponse
         */
        public DescribePolicyInstancesResponse DescribePolicyInstancesWithOptions(string clusterId, DescribePolicyInstancesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceName))
            {
                query["instance_name"] = request.InstanceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyName))
            {
                query["policy_name"] = request.PolicyName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribePolicyInstances",
                Version = "2015-12-15",
                Protocol = "HTTPS",
                Pathname = "/clusters/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(clusterId) + "/policies",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "array",
            };
            return TeaModel.ToObject<DescribePolicyInstancesResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the detailed information about policy instances of the specified type in a Container Service for Kubernetes (ACK) cluster, such as the policy description and severity level. You can choose a type of security policy for an ACK cluster, specify the action and applicable scope of the policy, and then create and deploy a policy instance.
         *
         * @param request DescribePolicyInstancesRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribePolicyInstancesResponse
         */
        public async Task<DescribePolicyInstancesResponse> DescribePolicyInstancesWithOptionsAsync(string clusterId, DescribePolicyInstancesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceName))
            {
                query["instance_name"] = request.InstanceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyName))
            {
                query["policy_name"] = request.PolicyName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribePolicyInstances",
                Version = "2015-12-15",
                Protocol = "HTTPS",
                Pathname = "/clusters/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(clusterId) + "/policies",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "array",
            };
            return TeaModel.ToObject<DescribePolicyInstancesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the detailed information about policy instances of the specified type in a Container Service for Kubernetes (ACK) cluster, such as the policy description and severity level. You can choose a type of security policy for an ACK cluster, specify the action and applicable scope of the policy, and then create and deploy a policy instance.
         *
         * @param request DescribePolicyInstancesRequest
         * @return DescribePolicyInstancesResponse
         */
        public DescribePolicyInstancesResponse DescribePolicyInstances(string clusterId, DescribePolicyInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribePolicyInstancesWithOptions(clusterId, request, headers, runtime);
        }

        /**
         * @summary Queries the detailed information about policy instances of the specified type in a Container Service for Kubernetes (ACK) cluster, such as the policy description and severity level. You can choose a type of security policy for an ACK cluster, specify the action and applicable scope of the policy, and then create and deploy a policy instance.
         *
         * @param request DescribePolicyInstancesRequest
         * @return DescribePolicyInstancesResponse
         */
        public async Task<DescribePolicyInstancesResponse> DescribePolicyInstancesAsync(string clusterId, DescribePolicyInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribePolicyInstancesWithOptionsAsync(clusterId, request, headers, runtime);
        }

        /**
         * @summary Queries the deployment of policy instances in the current Container Service for Kubernetes (ACK) cluster, including the number of policy instances of each type and the number of policy types of each severity level.
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribePolicyInstancesStatusResponse
         */
        public DescribePolicyInstancesStatusResponse DescribePolicyInstancesStatusWithOptions(string clusterId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribePolicyInstancesStatus",
                Version = "2015-12-15",
                Protocol = "HTTPS",
                Pathname = "/clusters/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(clusterId) + "/policies/status",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribePolicyInstancesStatusResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the deployment of policy instances in the current Container Service for Kubernetes (ACK) cluster, including the number of policy instances of each type and the number of policy types of each severity level.
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribePolicyInstancesStatusResponse
         */
        public async Task<DescribePolicyInstancesStatusResponse> DescribePolicyInstancesStatusWithOptionsAsync(string clusterId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribePolicyInstancesStatus",
                Version = "2015-12-15",
                Protocol = "HTTPS",
                Pathname = "/clusters/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(clusterId) + "/policies/status",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribePolicyInstancesStatusResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the deployment of policy instances in the current Container Service for Kubernetes (ACK) cluster, including the number of policy instances of each type and the number of policy types of each severity level.
         *
         * @return DescribePolicyInstancesStatusResponse
         */
        public DescribePolicyInstancesStatusResponse DescribePolicyInstancesStatus(string clusterId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribePolicyInstancesStatusWithOptions(clusterId, headers, runtime);
        }

        /**
         * @summary Queries the deployment of policy instances in the current Container Service for Kubernetes (ACK) cluster, including the number of policy instances of each type and the number of policy types of each severity level.
         *
         * @return DescribePolicyInstancesStatusResponse
         */
        public async Task<DescribePolicyInstancesStatusResponse> DescribePolicyInstancesStatusAsync(string clusterId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribePolicyInstancesStatusWithOptionsAsync(clusterId, headers, runtime);
        }

        /**
         * @summary Queries whether the deletion protection feature is enabled for the specified resources. The resources that you can query include namespaces and Services.
         *
         * @param request DescribeResourcesDeleteProtectionRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeResourcesDeleteProtectionResponse
         */
        public DescribeResourcesDeleteProtectionResponse DescribeResourcesDeleteProtectionWithOptions(string ClusterId, string ResourceType, DescribeResourcesDeleteProtectionRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                query["namespace"] = request.Namespace;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Resources))
            {
                query["resources"] = request.Resources;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeResourcesDeleteProtection",
                Version = "2015-12-15",
                Protocol = "HTTPS",
                Pathname = "/clusters/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId) + "/resources/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ResourceType) + "/protection",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "array",
            };
            return TeaModel.ToObject<DescribeResourcesDeleteProtectionResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries whether the deletion protection feature is enabled for the specified resources. The resources that you can query include namespaces and Services.
         *
         * @param request DescribeResourcesDeleteProtectionRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeResourcesDeleteProtectionResponse
         */
        public async Task<DescribeResourcesDeleteProtectionResponse> DescribeResourcesDeleteProtectionWithOptionsAsync(string ClusterId, string ResourceType, DescribeResourcesDeleteProtectionRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                query["namespace"] = request.Namespace;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Resources))
            {
                query["resources"] = request.Resources;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeResourcesDeleteProtection",
                Version = "2015-12-15",
                Protocol = "HTTPS",
                Pathname = "/clusters/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId) + "/resources/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ResourceType) + "/protection",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "array",
            };
            return TeaModel.ToObject<DescribeResourcesDeleteProtectionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries whether the deletion protection feature is enabled for the specified resources. The resources that you can query include namespaces and Services.
         *
         * @param request DescribeResourcesDeleteProtectionRequest
         * @return DescribeResourcesDeleteProtectionResponse
         */
        public DescribeResourcesDeleteProtectionResponse DescribeResourcesDeleteProtection(string ClusterId, string ResourceType, DescribeResourcesDeleteProtectionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeResourcesDeleteProtectionWithOptions(ClusterId, ResourceType, request, headers, runtime);
        }

        /**
         * @summary Queries whether the deletion protection feature is enabled for the specified resources. The resources that you can query include namespaces and Services.
         *
         * @param request DescribeResourcesDeleteProtectionRequest
         * @return DescribeResourcesDeleteProtectionResponse
         */
        public async Task<DescribeResourcesDeleteProtectionResponse> DescribeResourcesDeleteProtectionAsync(string ClusterId, string ResourceType, DescribeResourcesDeleteProtectionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeResourcesDeleteProtectionWithOptionsAsync(ClusterId, ResourceType, request, headers, runtime);
        }

        /**
         * @summary Queries or issues the kubeconfig credentials of a Resource Access Management (RAM) user or RAM role of the account. If you are the permission manager of a Container Service for Kubernetes (ACK) cluster, you can issue the kubeconfig credentials to a specific RAM user or RAM role of the account by using the Alibaba Cloud account. The kubeconfig credentials, which are used to connect to the ACK cluster, contain the identity information about the RAM user or RAM role.
         *
         * @description **
         * ****Only Alibaba Cloud accounts can call this API operation.
         *
         * @param request DescribeSubaccountK8sClusterUserConfigRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeSubaccountK8sClusterUserConfigResponse
         */
        public DescribeSubaccountK8sClusterUserConfigResponse DescribeSubaccountK8sClusterUserConfigWithOptions(string ClusterId, string Uid, DescribeSubaccountK8sClusterUserConfigRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PrivateIpAddress))
            {
                query["PrivateIpAddress"] = request.PrivateIpAddress;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemporaryDurationMinutes))
            {
                query["TemporaryDurationMinutes"] = request.TemporaryDurationMinutes;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeSubaccountK8sClusterUserConfig",
                Version = "2015-12-15",
                Protocol = "HTTPS",
                Pathname = "/k8s/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId) + "/users/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(Uid) + "/user_config",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeSubaccountK8sClusterUserConfigResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries or issues the kubeconfig credentials of a Resource Access Management (RAM) user or RAM role of the account. If you are the permission manager of a Container Service for Kubernetes (ACK) cluster, you can issue the kubeconfig credentials to a specific RAM user or RAM role of the account by using the Alibaba Cloud account. The kubeconfig credentials, which are used to connect to the ACK cluster, contain the identity information about the RAM user or RAM role.
         *
         * @description **
         * ****Only Alibaba Cloud accounts can call this API operation.
         *
         * @param request DescribeSubaccountK8sClusterUserConfigRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeSubaccountK8sClusterUserConfigResponse
         */
        public async Task<DescribeSubaccountK8sClusterUserConfigResponse> DescribeSubaccountK8sClusterUserConfigWithOptionsAsync(string ClusterId, string Uid, DescribeSubaccountK8sClusterUserConfigRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PrivateIpAddress))
            {
                query["PrivateIpAddress"] = request.PrivateIpAddress;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemporaryDurationMinutes))
            {
                query["TemporaryDurationMinutes"] = request.TemporaryDurationMinutes;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeSubaccountK8sClusterUserConfig",
                Version = "2015-12-15",
                Protocol = "HTTPS",
                Pathname = "/k8s/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId) + "/users/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(Uid) + "/user_config",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeSubaccountK8sClusterUserConfigResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries or issues the kubeconfig credentials of a Resource Access Management (RAM) user or RAM role of the account. If you are the permission manager of a Container Service for Kubernetes (ACK) cluster, you can issue the kubeconfig credentials to a specific RAM user or RAM role of the account by using the Alibaba Cloud account. The kubeconfig credentials, which are used to connect to the ACK cluster, contain the identity information about the RAM user or RAM role.
         *
         * @description **
         * ****Only Alibaba Cloud accounts can call this API operation.
         *
         * @param request DescribeSubaccountK8sClusterUserConfigRequest
         * @return DescribeSubaccountK8sClusterUserConfigResponse
         */
        public DescribeSubaccountK8sClusterUserConfigResponse DescribeSubaccountK8sClusterUserConfig(string ClusterId, string Uid, DescribeSubaccountK8sClusterUserConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeSubaccountK8sClusterUserConfigWithOptions(ClusterId, Uid, request, headers, runtime);
        }

        /**
         * @summary Queries or issues the kubeconfig credentials of a Resource Access Management (RAM) user or RAM role of the account. If you are the permission manager of a Container Service for Kubernetes (ACK) cluster, you can issue the kubeconfig credentials to a specific RAM user or RAM role of the account by using the Alibaba Cloud account. The kubeconfig credentials, which are used to connect to the ACK cluster, contain the identity information about the RAM user or RAM role.
         *
         * @description **
         * ****Only Alibaba Cloud accounts can call this API operation.
         *
         * @param request DescribeSubaccountK8sClusterUserConfigRequest
         * @return DescribeSubaccountK8sClusterUserConfigResponse
         */
        public async Task<DescribeSubaccountK8sClusterUserConfigResponse> DescribeSubaccountK8sClusterUserConfigAsync(string ClusterId, string Uid, DescribeSubaccountK8sClusterUserConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeSubaccountK8sClusterUserConfigWithOptionsAsync(ClusterId, Uid, request, headers, runtime);
        }

        /**
         * @summary Queries detailed information about a task, such as the task type, status, and progress.
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeTaskInfoResponse
         */
        public DescribeTaskInfoResponse DescribeTaskInfoWithOptions(string taskId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeTaskInfo",
                Version = "2015-12-15",
                Protocol = "HTTPS",
                Pathname = "/tasks/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(taskId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeTaskInfoResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries detailed information about a task, such as the task type, status, and progress.
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeTaskInfoResponse
         */
        public async Task<DescribeTaskInfoResponse> DescribeTaskInfoWithOptionsAsync(string taskId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeTaskInfo",
                Version = "2015-12-15",
                Protocol = "HTTPS",
                Pathname = "/tasks/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(taskId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeTaskInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries detailed information about a task, such as the task type, status, and progress.
         *
         * @return DescribeTaskInfoResponse
         */
        public DescribeTaskInfoResponse DescribeTaskInfo(string taskId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeTaskInfoWithOptions(taskId, headers, runtime);
        }

        /**
         * @summary Queries detailed information about a task, such as the task type, status, and progress.
         *
         * @return DescribeTaskInfoResponse
         */
        public async Task<DescribeTaskInfoResponse> DescribeTaskInfoAsync(string taskId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeTaskInfoWithOptionsAsync(taskId, headers, runtime);
        }

        /**
         * @summary An orchestration template defines and describes a group of Kubernetes resources. It declaratively describes the configuration of an application or how an application runs. You can call the DescribeTemplates API operation to query orchestration templates and their detailed information, including access permissions, YAML content, and labels.
         *
         * @param request DescribeTemplateAttributeRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeTemplateAttributeResponse
         */
        public DescribeTemplateAttributeResponse DescribeTemplateAttributeWithOptions(string TemplateId, DescribeTemplateAttributeRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateType))
            {
                query["template_type"] = request.TemplateType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeTemplateAttribute",
                Version = "2015-12-15",
                Protocol = "HTTPS",
                Pathname = "/templates/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(TemplateId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "array",
            };
            return TeaModel.ToObject<DescribeTemplateAttributeResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary An orchestration template defines and describes a group of Kubernetes resources. It declaratively describes the configuration of an application or how an application runs. You can call the DescribeTemplates API operation to query orchestration templates and their detailed information, including access permissions, YAML content, and labels.
         *
         * @param request DescribeTemplateAttributeRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeTemplateAttributeResponse
         */
        public async Task<DescribeTemplateAttributeResponse> DescribeTemplateAttributeWithOptionsAsync(string TemplateId, DescribeTemplateAttributeRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateType))
            {
                query["template_type"] = request.TemplateType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeTemplateAttribute",
                Version = "2015-12-15",
                Protocol = "HTTPS",
                Pathname = "/templates/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(TemplateId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "array",
            };
            return TeaModel.ToObject<DescribeTemplateAttributeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary An orchestration template defines and describes a group of Kubernetes resources. It declaratively describes the configuration of an application or how an application runs. You can call the DescribeTemplates API operation to query orchestration templates and their detailed information, including access permissions, YAML content, and labels.
         *
         * @param request DescribeTemplateAttributeRequest
         * @return DescribeTemplateAttributeResponse
         */
        public DescribeTemplateAttributeResponse DescribeTemplateAttribute(string TemplateId, DescribeTemplateAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeTemplateAttributeWithOptions(TemplateId, request, headers, runtime);
        }

        /**
         * @summary An orchestration template defines and describes a group of Kubernetes resources. It declaratively describes the configuration of an application or how an application runs. You can call the DescribeTemplates API operation to query orchestration templates and their detailed information, including access permissions, YAML content, and labels.
         *
         * @param request DescribeTemplateAttributeRequest
         * @return DescribeTemplateAttributeResponse
         */
        public async Task<DescribeTemplateAttributeResponse> DescribeTemplateAttributeAsync(string TemplateId, DescribeTemplateAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeTemplateAttributeWithOptionsAsync(TemplateId, request, headers, runtime);
        }

        /**
         * @summary An orchestration template defines and describes a group of Kubernetes resources. It declaratively describes the configuration of an application or how an application runs. You can call the DescribeTemplates API operation to query orchestration templates and their detailed information, including access permissions, YAML content, and labels.
         *
         * @param request DescribeTemplatesRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeTemplatesResponse
         */
        public DescribeTemplatesResponse DescribeTemplatesWithOptions(DescribeTemplatesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNum))
            {
                query["page_num"] = request.PageNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["page_size"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateType))
            {
                query["template_type"] = request.TemplateType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeTemplates",
                Version = "2015-12-15",
                Protocol = "HTTPS",
                Pathname = "/templates",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeTemplatesResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary An orchestration template defines and describes a group of Kubernetes resources. It declaratively describes the configuration of an application or how an application runs. You can call the DescribeTemplates API operation to query orchestration templates and their detailed information, including access permissions, YAML content, and labels.
         *
         * @param request DescribeTemplatesRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeTemplatesResponse
         */
        public async Task<DescribeTemplatesResponse> DescribeTemplatesWithOptionsAsync(DescribeTemplatesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNum))
            {
                query["page_num"] = request.PageNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["page_size"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateType))
            {
                query["template_type"] = request.TemplateType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeTemplates",
                Version = "2015-12-15",
                Protocol = "HTTPS",
                Pathname = "/templates",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeTemplatesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary An orchestration template defines and describes a group of Kubernetes resources. It declaratively describes the configuration of an application or how an application runs. You can call the DescribeTemplates API operation to query orchestration templates and their detailed information, including access permissions, YAML content, and labels.
         *
         * @param request DescribeTemplatesRequest
         * @return DescribeTemplatesResponse
         */
        public DescribeTemplatesResponse DescribeTemplates(DescribeTemplatesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeTemplatesWithOptions(request, headers, runtime);
        }

        /**
         * @summary An orchestration template defines and describes a group of Kubernetes resources. It declaratively describes the configuration of an application or how an application runs. You can call the DescribeTemplates API operation to query orchestration templates and their detailed information, including access permissions, YAML content, and labels.
         *
         * @param request DescribeTemplatesRequest
         * @return DescribeTemplatesResponse
         */
        public async Task<DescribeTemplatesResponse> DescribeTemplatesAsync(DescribeTemplatesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeTemplatesWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary You can call the DescribeTrigger operation to query triggers.
         *
         * @param request DescribeTriggerRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeTriggerResponse
         */
        public DescribeTriggerResponse DescribeTriggerWithOptions(string clusterId, DescribeTriggerRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                query["Namespace"] = request.Namespace;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["Type"] = request.Type;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Action))
            {
                query["action"] = request.Action;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeTrigger",
                Version = "2015-12-15",
                Protocol = "HTTPS",
                Pathname = "/clusters/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(clusterId) + "/triggers",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "array",
            };
            return TeaModel.ToObject<DescribeTriggerResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary You can call the DescribeTrigger operation to query triggers.
         *
         * @param request DescribeTriggerRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeTriggerResponse
         */
        public async Task<DescribeTriggerResponse> DescribeTriggerWithOptionsAsync(string clusterId, DescribeTriggerRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                query["Namespace"] = request.Namespace;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["Type"] = request.Type;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Action))
            {
                query["action"] = request.Action;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeTrigger",
                Version = "2015-12-15",
                Protocol = "HTTPS",
                Pathname = "/clusters/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(clusterId) + "/triggers",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "array",
            };
            return TeaModel.ToObject<DescribeTriggerResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary You can call the DescribeTrigger operation to query triggers.
         *
         * @param request DescribeTriggerRequest
         * @return DescribeTriggerResponse
         */
        public DescribeTriggerResponse DescribeTrigger(string clusterId, DescribeTriggerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeTriggerWithOptions(clusterId, request, headers, runtime);
        }

        /**
         * @summary You can call the DescribeTrigger operation to query triggers.
         *
         * @param request DescribeTriggerRequest
         * @return DescribeTriggerResponse
         */
        public async Task<DescribeTriggerResponse> DescribeTriggerAsync(string clusterId, DescribeTriggerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeTriggerWithOptionsAsync(clusterId, request, headers, runtime);
        }

        /**
         * @summary Queries the Role-Based Access Control (RBAC) permissions that are granted to the current Resource Access Management (RAM) user or RAM role on a Container Service for Kubernetes (ACK) cluster. You can use Kubernetes namespaces to limit users from accessing resources in an ACK cluster. Users that are granted RBAC permissions only on one namespace cannot access resources in other namespaces.
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeUserClusterNamespacesResponse
         */
        public DescribeUserClusterNamespacesResponse DescribeUserClusterNamespacesWithOptions(string ClusterId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeUserClusterNamespaces",
                Version = "2015-12-15",
                Protocol = "HTTPS",
                Pathname = "/api/v2/k8s/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId) + "/namespaces",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "array",
            };
            return TeaModel.ToObject<DescribeUserClusterNamespacesResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the Role-Based Access Control (RBAC) permissions that are granted to the current Resource Access Management (RAM) user or RAM role on a Container Service for Kubernetes (ACK) cluster. You can use Kubernetes namespaces to limit users from accessing resources in an ACK cluster. Users that are granted RBAC permissions only on one namespace cannot access resources in other namespaces.
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeUserClusterNamespacesResponse
         */
        public async Task<DescribeUserClusterNamespacesResponse> DescribeUserClusterNamespacesWithOptionsAsync(string ClusterId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeUserClusterNamespaces",
                Version = "2015-12-15",
                Protocol = "HTTPS",
                Pathname = "/api/v2/k8s/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId) + "/namespaces",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "array",
            };
            return TeaModel.ToObject<DescribeUserClusterNamespacesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the Role-Based Access Control (RBAC) permissions that are granted to the current Resource Access Management (RAM) user or RAM role on a Container Service for Kubernetes (ACK) cluster. You can use Kubernetes namespaces to limit users from accessing resources in an ACK cluster. Users that are granted RBAC permissions only on one namespace cannot access resources in other namespaces.
         *
         * @return DescribeUserClusterNamespacesResponse
         */
        public DescribeUserClusterNamespacesResponse DescribeUserClusterNamespaces(string ClusterId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeUserClusterNamespacesWithOptions(ClusterId, headers, runtime);
        }

        /**
         * @summary Queries the Role-Based Access Control (RBAC) permissions that are granted to the current Resource Access Management (RAM) user or RAM role on a Container Service for Kubernetes (ACK) cluster. You can use Kubernetes namespaces to limit users from accessing resources in an ACK cluster. Users that are granted RBAC permissions only on one namespace cannot access resources in other namespaces.
         *
         * @return DescribeUserClusterNamespacesResponse
         */
        public async Task<DescribeUserClusterNamespacesResponse> DescribeUserClusterNamespacesAsync(string ClusterId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeUserClusterNamespacesWithOptionsAsync(ClusterId, headers, runtime);
        }

        /**
         * @summary In an Container Service for Kubernetes (ACK) cluster, you can create and specify different Resource Access Management (RAM) users or roles to have different access permissions. This ensures access control and resource isolation. You can call the DescribeUserPermission operation to query the permissions that are granted to a RAM user or RAM role on ACK clusters, including the resources that are allowed to access, the scope of the permissions, the predefined role, and the permission source.
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeUserPermissionResponse
         */
        public DescribeUserPermissionResponse DescribeUserPermissionWithOptions(string uid, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeUserPermission",
                Version = "2015-12-15",
                Protocol = "HTTPS",
                Pathname = "/permissions/users/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(uid),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "array",
            };
            return TeaModel.ToObject<DescribeUserPermissionResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary In an Container Service for Kubernetes (ACK) cluster, you can create and specify different Resource Access Management (RAM) users or roles to have different access permissions. This ensures access control and resource isolation. You can call the DescribeUserPermission operation to query the permissions that are granted to a RAM user or RAM role on ACK clusters, including the resources that are allowed to access, the scope of the permissions, the predefined role, and the permission source.
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeUserPermissionResponse
         */
        public async Task<DescribeUserPermissionResponse> DescribeUserPermissionWithOptionsAsync(string uid, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeUserPermission",
                Version = "2015-12-15",
                Protocol = "HTTPS",
                Pathname = "/permissions/users/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(uid),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "array",
            };
            return TeaModel.ToObject<DescribeUserPermissionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary In an Container Service for Kubernetes (ACK) cluster, you can create and specify different Resource Access Management (RAM) users or roles to have different access permissions. This ensures access control and resource isolation. You can call the DescribeUserPermission operation to query the permissions that are granted to a RAM user or RAM role on ACK clusters, including the resources that are allowed to access, the scope of the permissions, the predefined role, and the permission source.
         *
         * @return DescribeUserPermissionResponse
         */
        public DescribeUserPermissionResponse DescribeUserPermission(string uid)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeUserPermissionWithOptions(uid, headers, runtime);
        }

        /**
         * @summary In an Container Service for Kubernetes (ACK) cluster, you can create and specify different Resource Access Management (RAM) users or roles to have different access permissions. This ensures access control and resource isolation. You can call the DescribeUserPermission operation to query the permissions that are granted to a RAM user or RAM role on ACK clusters, including the resources that are allowed to access, the scope of the permissions, the predefined role, and the permission source.
         *
         * @return DescribeUserPermissionResponse
         */
        public async Task<DescribeUserPermissionResponse> DescribeUserPermissionAsync(string uid)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeUserPermissionWithOptionsAsync(uid, headers, runtime);
        }

        /**
         * @summary Queries quotas related to Container Service for Kubernetes (ACK) clusters, node pools, and nodes. To increase a quota, submit an application in the Quota Center console.
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeUserQuotaResponse
         */
        public DescribeUserQuotaResponse DescribeUserQuotaWithOptions(Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeUserQuota",
                Version = "2015-12-15",
                Protocol = "HTTPS",
                Pathname = "/quota",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeUserQuotaResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries quotas related to Container Service for Kubernetes (ACK) clusters, node pools, and nodes. To increase a quota, submit an application in the Quota Center console.
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeUserQuotaResponse
         */
        public async Task<DescribeUserQuotaResponse> DescribeUserQuotaWithOptionsAsync(Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeUserQuota",
                Version = "2015-12-15",
                Protocol = "HTTPS",
                Pathname = "/quota",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeUserQuotaResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries quotas related to Container Service for Kubernetes (ACK) clusters, node pools, and nodes. To increase a quota, submit an application in the Quota Center console.
         *
         * @return DescribeUserQuotaResponse
         */
        public DescribeUserQuotaResponse DescribeUserQuota()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeUserQuotaWithOptions(headers, runtime);
        }

        /**
         * @summary Queries quotas related to Container Service for Kubernetes (ACK) clusters, node pools, and nodes. To increase a quota, submit an application in the Quota Center console.
         *
         * @return DescribeUserQuotaResponse
         */
        public async Task<DescribeUserQuotaResponse> DescribeUserQuotaAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeUserQuotaWithOptionsAsync(headers, runtime);
        }

        /**
         * @deprecated OpenAPI DescribeWorkflows is deprecated
         *
         * @summary You can call the DescribeWorkflows operation to query all workflows.
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeWorkflowsResponse
         */
        // Deprecated
        public DescribeWorkflowsResponse DescribeWorkflowsWithOptions(Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeWorkflows",
                Version = "2015-12-15",
                Protocol = "HTTPS",
                Pathname = "/gs/workflows",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeWorkflowsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @deprecated OpenAPI DescribeWorkflows is deprecated
         *
         * @summary You can call the DescribeWorkflows operation to query all workflows.
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeWorkflowsResponse
         */
        // Deprecated
        public async Task<DescribeWorkflowsResponse> DescribeWorkflowsWithOptionsAsync(Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeWorkflows",
                Version = "2015-12-15",
                Protocol = "HTTPS",
                Pathname = "/gs/workflows",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeWorkflowsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @deprecated OpenAPI DescribeWorkflows is deprecated
         *
         * @summary You can call the DescribeWorkflows operation to query all workflows.
         *
         * @return DescribeWorkflowsResponse
         */
        // Deprecated
        public DescribeWorkflowsResponse DescribeWorkflows()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeWorkflowsWithOptions(headers, runtime);
        }

        /**
         * @deprecated OpenAPI DescribeWorkflows is deprecated
         *
         * @summary You can call the DescribeWorkflows operation to query all workflows.
         *
         * @return DescribeWorkflowsResponse
         */
        // Deprecated
        public async Task<DescribeWorkflowsResponse> DescribeWorkflowsAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeWorkflowsWithOptionsAsync(headers, runtime);
        }

        /**
         * @summary You can call the EdgeClusterAddEdgeMachine operation to add a cloud-native box to a Container Service for Kubernetes (ACK) Edge cluster.
         *
         * @param request EdgeClusterAddEdgeMachineRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return EdgeClusterAddEdgeMachineResponse
         */
        public EdgeClusterAddEdgeMachineResponse EdgeClusterAddEdgeMachineWithOptions(string clusterid, string edgeMachineid, EdgeClusterAddEdgeMachineRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Expired))
            {
                body["expired"] = request.Expired;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodepoolId))
            {
                body["nodepool_id"] = request.NodepoolId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Options))
            {
                body["options"] = request.Options;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "EdgeClusterAddEdgeMachine",
                Version = "2015-12-15",
                Protocol = "HTTPS",
                Pathname = "/clusters/%5Bclusterid%5D/attachedgemachine/%5Bedge_machineid%5D",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<EdgeClusterAddEdgeMachineResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary You can call the EdgeClusterAddEdgeMachine operation to add a cloud-native box to a Container Service for Kubernetes (ACK) Edge cluster.
         *
         * @param request EdgeClusterAddEdgeMachineRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return EdgeClusterAddEdgeMachineResponse
         */
        public async Task<EdgeClusterAddEdgeMachineResponse> EdgeClusterAddEdgeMachineWithOptionsAsync(string clusterid, string edgeMachineid, EdgeClusterAddEdgeMachineRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Expired))
            {
                body["expired"] = request.Expired;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodepoolId))
            {
                body["nodepool_id"] = request.NodepoolId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Options))
            {
                body["options"] = request.Options;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "EdgeClusterAddEdgeMachine",
                Version = "2015-12-15",
                Protocol = "HTTPS",
                Pathname = "/clusters/%5Bclusterid%5D/attachedgemachine/%5Bedge_machineid%5D",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<EdgeClusterAddEdgeMachineResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary You can call the EdgeClusterAddEdgeMachine operation to add a cloud-native box to a Container Service for Kubernetes (ACK) Edge cluster.
         *
         * @param request EdgeClusterAddEdgeMachineRequest
         * @return EdgeClusterAddEdgeMachineResponse
         */
        public EdgeClusterAddEdgeMachineResponse EdgeClusterAddEdgeMachine(string clusterid, string edgeMachineid, EdgeClusterAddEdgeMachineRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return EdgeClusterAddEdgeMachineWithOptions(clusterid, edgeMachineid, request, headers, runtime);
        }

        /**
         * @summary You can call the EdgeClusterAddEdgeMachine operation to add a cloud-native box to a Container Service for Kubernetes (ACK) Edge cluster.
         *
         * @param request EdgeClusterAddEdgeMachineRequest
         * @return EdgeClusterAddEdgeMachineResponse
         */
        public async Task<EdgeClusterAddEdgeMachineResponse> EdgeClusterAddEdgeMachineAsync(string clusterid, string edgeMachineid, EdgeClusterAddEdgeMachineRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await EdgeClusterAddEdgeMachineWithOptionsAsync(clusterid, edgeMachineid, request, headers, runtime);
        }

        /**
         * @summary Patches node vulnerabilities in a node pool to enhance node security. Cloud Security provided by Alibaba Cloud periodically scans Elastic Compute Service (ECS) instances for vulnerabilities and provides suggestions on how to patch the detected vulnerabilities. Vulnerability patching may require node restarts. Make sure that your cluster has sufficient idle nodes for node draining.
         *
         * @description 1.  The Common Vulnerabilities and Exposures (CVE) patching feature is developed based on Security Center. To use this feature, you must purchase the Security Center Ultimate Edition that supports Container Service for Kubernetes (ACK).
         * 2.  ACK may need to restart nodes to patch certain vulnerabilities. ACK drains a node before the node restarts. Make sure that the ACK cluster has sufficient idle nodes to host the pods evicted from the trained nodes. For example, you can scale out a node pool before you patch vulnerabilities for the nodes in the node pool.
         * 3.  Security Center ensures the compatibility of CVE patches. We recommend that you check the compatibility of a CVE patch with your application before you install the patch. You can pause or cancel a CVE patching task anytime.
         * 4.  CVE patching is a progressive task that consists of multiple batches. After you pause or cancel a CVE patching task, ACK continues to process the dispatched batches. Only the batches that have not been dispatched are paused or canceled.
         *
         * @param request FixNodePoolVulsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return FixNodePoolVulsResponse
         */
        public FixNodePoolVulsResponse FixNodePoolVulsWithOptions(string clusterId, string nodepoolId, FixNodePoolVulsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoRestart))
            {
                body["auto_restart"] = request.AutoRestart;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Nodes))
            {
                body["nodes"] = request.Nodes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RolloutPolicy))
            {
                body["rollout_policy"] = request.RolloutPolicy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Vuls))
            {
                body["vuls"] = request.Vuls;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "FixNodePoolVuls",
                Version = "2015-12-15",
                Protocol = "HTTPS",
                Pathname = "/clusters/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(clusterId) + "/nodepools/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(nodepoolId) + "/vuls/fix",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<FixNodePoolVulsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Patches node vulnerabilities in a node pool to enhance node security. Cloud Security provided by Alibaba Cloud periodically scans Elastic Compute Service (ECS) instances for vulnerabilities and provides suggestions on how to patch the detected vulnerabilities. Vulnerability patching may require node restarts. Make sure that your cluster has sufficient idle nodes for node draining.
         *
         * @description 1.  The Common Vulnerabilities and Exposures (CVE) patching feature is developed based on Security Center. To use this feature, you must purchase the Security Center Ultimate Edition that supports Container Service for Kubernetes (ACK).
         * 2.  ACK may need to restart nodes to patch certain vulnerabilities. ACK drains a node before the node restarts. Make sure that the ACK cluster has sufficient idle nodes to host the pods evicted from the trained nodes. For example, you can scale out a node pool before you patch vulnerabilities for the nodes in the node pool.
         * 3.  Security Center ensures the compatibility of CVE patches. We recommend that you check the compatibility of a CVE patch with your application before you install the patch. You can pause or cancel a CVE patching task anytime.
         * 4.  CVE patching is a progressive task that consists of multiple batches. After you pause or cancel a CVE patching task, ACK continues to process the dispatched batches. Only the batches that have not been dispatched are paused or canceled.
         *
         * @param request FixNodePoolVulsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return FixNodePoolVulsResponse
         */
        public async Task<FixNodePoolVulsResponse> FixNodePoolVulsWithOptionsAsync(string clusterId, string nodepoolId, FixNodePoolVulsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoRestart))
            {
                body["auto_restart"] = request.AutoRestart;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Nodes))
            {
                body["nodes"] = request.Nodes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RolloutPolicy))
            {
                body["rollout_policy"] = request.RolloutPolicy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Vuls))
            {
                body["vuls"] = request.Vuls;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "FixNodePoolVuls",
                Version = "2015-12-15",
                Protocol = "HTTPS",
                Pathname = "/clusters/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(clusterId) + "/nodepools/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(nodepoolId) + "/vuls/fix",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<FixNodePoolVulsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Patches node vulnerabilities in a node pool to enhance node security. Cloud Security provided by Alibaba Cloud periodically scans Elastic Compute Service (ECS) instances for vulnerabilities and provides suggestions on how to patch the detected vulnerabilities. Vulnerability patching may require node restarts. Make sure that your cluster has sufficient idle nodes for node draining.
         *
         * @description 1.  The Common Vulnerabilities and Exposures (CVE) patching feature is developed based on Security Center. To use this feature, you must purchase the Security Center Ultimate Edition that supports Container Service for Kubernetes (ACK).
         * 2.  ACK may need to restart nodes to patch certain vulnerabilities. ACK drains a node before the node restarts. Make sure that the ACK cluster has sufficient idle nodes to host the pods evicted from the trained nodes. For example, you can scale out a node pool before you patch vulnerabilities for the nodes in the node pool.
         * 3.  Security Center ensures the compatibility of CVE patches. We recommend that you check the compatibility of a CVE patch with your application before you install the patch. You can pause or cancel a CVE patching task anytime.
         * 4.  CVE patching is a progressive task that consists of multiple batches. After you pause or cancel a CVE patching task, ACK continues to process the dispatched batches. Only the batches that have not been dispatched are paused or canceled.
         *
         * @param request FixNodePoolVulsRequest
         * @return FixNodePoolVulsResponse
         */
        public FixNodePoolVulsResponse FixNodePoolVuls(string clusterId, string nodepoolId, FixNodePoolVulsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return FixNodePoolVulsWithOptions(clusterId, nodepoolId, request, headers, runtime);
        }

        /**
         * @summary Patches node vulnerabilities in a node pool to enhance node security. Cloud Security provided by Alibaba Cloud periodically scans Elastic Compute Service (ECS) instances for vulnerabilities and provides suggestions on how to patch the detected vulnerabilities. Vulnerability patching may require node restarts. Make sure that your cluster has sufficient idle nodes for node draining.
         *
         * @description 1.  The Common Vulnerabilities and Exposures (CVE) patching feature is developed based on Security Center. To use this feature, you must purchase the Security Center Ultimate Edition that supports Container Service for Kubernetes (ACK).
         * 2.  ACK may need to restart nodes to patch certain vulnerabilities. ACK drains a node before the node restarts. Make sure that the ACK cluster has sufficient idle nodes to host the pods evicted from the trained nodes. For example, you can scale out a node pool before you patch vulnerabilities for the nodes in the node pool.
         * 3.  Security Center ensures the compatibility of CVE patches. We recommend that you check the compatibility of a CVE patch with your application before you install the patch. You can pause or cancel a CVE patching task anytime.
         * 4.  CVE patching is a progressive task that consists of multiple batches. After you pause or cancel a CVE patching task, ACK continues to process the dispatched batches. Only the batches that have not been dispatched are paused or canceled.
         *
         * @param request FixNodePoolVulsRequest
         * @return FixNodePoolVulsResponse
         */
        public async Task<FixNodePoolVulsResponse> FixNodePoolVulsAsync(string clusterId, string nodepoolId, FixNodePoolVulsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await FixNodePoolVulsWithOptionsAsync(clusterId, nodepoolId, request, headers, runtime);
        }

        /**
         * @summary You can call the GetClusterAddonInstance operation to query the information of a component instance in a cluster, including the version, configurations, and log status of the component instance.
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetClusterAddonInstanceResponse
         */
        public GetClusterAddonInstanceResponse GetClusterAddonInstanceWithOptions(string clusterId, string instanceName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetClusterAddonInstance",
                Version = "2015-12-15",
                Protocol = "HTTPS",
                Pathname = "/clusters/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(clusterId) + "/addon_instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceName),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetClusterAddonInstanceResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary You can call the GetClusterAddonInstance operation to query the information of a component instance in a cluster, including the version, configurations, and log status of the component instance.
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetClusterAddonInstanceResponse
         */
        public async Task<GetClusterAddonInstanceResponse> GetClusterAddonInstanceWithOptionsAsync(string clusterId, string instanceName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetClusterAddonInstance",
                Version = "2015-12-15",
                Protocol = "HTTPS",
                Pathname = "/clusters/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(clusterId) + "/addon_instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceName),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetClusterAddonInstanceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary You can call the GetClusterAddonInstance operation to query the information of a component instance in a cluster, including the version, configurations, and log status of the component instance.
         *
         * @return GetClusterAddonInstanceResponse
         */
        public GetClusterAddonInstanceResponse GetClusterAddonInstance(string clusterId, string instanceName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetClusterAddonInstanceWithOptions(clusterId, instanceName, headers, runtime);
        }

        /**
         * @summary You can call the GetClusterAddonInstance operation to query the information of a component instance in a cluster, including the version, configurations, and log status of the component instance.
         *
         * @return GetClusterAddonInstanceResponse
         */
        public async Task<GetClusterAddonInstanceResponse> GetClusterAddonInstanceAsync(string clusterId, string instanceName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetClusterAddonInstanceWithOptionsAsync(clusterId, instanceName, headers, runtime);
        }

        /**
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetClusterAuditProjectResponse
         */
        public GetClusterAuditProjectResponse GetClusterAuditProjectWithOptions(string clusterid, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetClusterAuditProject",
                Version = "2015-12-15",
                Protocol = "HTTPS",
                Pathname = "/clusters/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(clusterid) + "/audit",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetClusterAuditProjectResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetClusterAuditProjectResponse
         */
        public async Task<GetClusterAuditProjectResponse> GetClusterAuditProjectWithOptionsAsync(string clusterid, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetClusterAuditProject",
                Version = "2015-12-15",
                Protocol = "HTTPS",
                Pathname = "/clusters/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(clusterid) + "/audit",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetClusterAuditProjectResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @return GetClusterAuditProjectResponse
         */
        public GetClusterAuditProjectResponse GetClusterAuditProject(string clusterid)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetClusterAuditProjectWithOptions(clusterid, headers, runtime);
        }

        /**
         * @return GetClusterAuditProjectResponse
         */
        public async Task<GetClusterAuditProjectResponse> GetClusterAuditProjectAsync(string clusterid)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetClusterAuditProjectWithOptionsAsync(clusterid, headers, runtime);
        }

        /**
         * @summary Queries a cluster check task by cluster ID and task ID. You can view the status, check items, creation time, and end time of the task. Container Intelligence Service (CIS) provides a variety of Kubernetes cluster check features, including cluster update check, cluster migration check, component installation check, component update check, and node pool check.
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetClusterCheckResponse
         */
        public GetClusterCheckResponse GetClusterCheckWithOptions(string clusterId, string checkId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetClusterCheck",
                Version = "2015-12-15",
                Protocol = "HTTPS",
                Pathname = "/clusters/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(clusterId) + "/checks/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(checkId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetClusterCheckResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries a cluster check task by cluster ID and task ID. You can view the status, check items, creation time, and end time of the task. Container Intelligence Service (CIS) provides a variety of Kubernetes cluster check features, including cluster update check, cluster migration check, component installation check, component update check, and node pool check.
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetClusterCheckResponse
         */
        public async Task<GetClusterCheckResponse> GetClusterCheckWithOptionsAsync(string clusterId, string checkId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetClusterCheck",
                Version = "2015-12-15",
                Protocol = "HTTPS",
                Pathname = "/clusters/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(clusterId) + "/checks/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(checkId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetClusterCheckResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries a cluster check task by cluster ID and task ID. You can view the status, check items, creation time, and end time of the task. Container Intelligence Service (CIS) provides a variety of Kubernetes cluster check features, including cluster update check, cluster migration check, component installation check, component update check, and node pool check.
         *
         * @return GetClusterCheckResponse
         */
        public GetClusterCheckResponse GetClusterCheck(string clusterId, string checkId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetClusterCheckWithOptions(clusterId, checkId, headers, runtime);
        }

        /**
         * @summary Queries a cluster check task by cluster ID and task ID. You can view the status, check items, creation time, and end time of the task. Container Intelligence Service (CIS) provides a variety of Kubernetes cluster check features, including cluster update check, cluster migration check, component installation check, component update check, and node pool check.
         *
         * @return GetClusterCheckResponse
         */
        public async Task<GetClusterCheckResponse> GetClusterCheckAsync(string clusterId, string checkId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetClusterCheckWithOptionsAsync(clusterId, checkId, headers, runtime);
        }

        /**
         * @summary 获取集群诊断检查项
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetClusterDiagnosisCheckItemsResponse
         */
        public GetClusterDiagnosisCheckItemsResponse GetClusterDiagnosisCheckItemsWithOptions(string clusterId, string diagnosisId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetClusterDiagnosisCheckItems",
                Version = "2015-12-15",
                Protocol = "HTTPS",
                Pathname = "/clusters/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(clusterId) + "/diagnosis/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(diagnosisId) + "/check_items",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetClusterDiagnosisCheckItemsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 获取集群诊断检查项
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetClusterDiagnosisCheckItemsResponse
         */
        public async Task<GetClusterDiagnosisCheckItemsResponse> GetClusterDiagnosisCheckItemsWithOptionsAsync(string clusterId, string diagnosisId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetClusterDiagnosisCheckItems",
                Version = "2015-12-15",
                Protocol = "HTTPS",
                Pathname = "/clusters/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(clusterId) + "/diagnosis/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(diagnosisId) + "/check_items",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetClusterDiagnosisCheckItemsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 获取集群诊断检查项
         *
         * @return GetClusterDiagnosisCheckItemsResponse
         */
        public GetClusterDiagnosisCheckItemsResponse GetClusterDiagnosisCheckItems(string clusterId, string diagnosisId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetClusterDiagnosisCheckItemsWithOptions(clusterId, diagnosisId, headers, runtime);
        }

        /**
         * @summary 获取集群诊断检查项
         *
         * @return GetClusterDiagnosisCheckItemsResponse
         */
        public async Task<GetClusterDiagnosisCheckItemsResponse> GetClusterDiagnosisCheckItemsAsync(string clusterId, string diagnosisId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetClusterDiagnosisCheckItemsWithOptionsAsync(clusterId, diagnosisId, headers, runtime);
        }

        /**
         * @summary 获取集群诊断结果
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetClusterDiagnosisResultResponse
         */
        public GetClusterDiagnosisResultResponse GetClusterDiagnosisResultWithOptions(string clusterId, string diagnosisId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetClusterDiagnosisResult",
                Version = "2015-12-15",
                Protocol = "HTTPS",
                Pathname = "/clusters/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(clusterId) + "/diagnosis/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(diagnosisId) + "/result",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetClusterDiagnosisResultResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 获取集群诊断结果
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetClusterDiagnosisResultResponse
         */
        public async Task<GetClusterDiagnosisResultResponse> GetClusterDiagnosisResultWithOptionsAsync(string clusterId, string diagnosisId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetClusterDiagnosisResult",
                Version = "2015-12-15",
                Protocol = "HTTPS",
                Pathname = "/clusters/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(clusterId) + "/diagnosis/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(diagnosisId) + "/result",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetClusterDiagnosisResultResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 获取集群诊断结果
         *
         * @return GetClusterDiagnosisResultResponse
         */
        public GetClusterDiagnosisResultResponse GetClusterDiagnosisResult(string clusterId, string diagnosisId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetClusterDiagnosisResultWithOptions(clusterId, diagnosisId, headers, runtime);
        }

        /**
         * @summary 获取集群诊断结果
         *
         * @return GetClusterDiagnosisResultResponse
         */
        public async Task<GetClusterDiagnosisResultResponse> GetClusterDiagnosisResultAsync(string clusterId, string diagnosisId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetClusterDiagnosisResultWithOptionsAsync(clusterId, diagnosisId, headers, runtime);
        }

        /**
         * @summary You can call the GetKubernetesTrigger operationto query the triggers of an application by application name.
         *
         * @param request GetKubernetesTriggerRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetKubernetesTriggerResponse
         */
        public GetKubernetesTriggerResponse GetKubernetesTriggerWithOptions(string ClusterId, GetKubernetesTriggerRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                query["Namespace"] = request.Namespace;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["Type"] = request.Type;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Action))
            {
                query["action"] = request.Action;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetKubernetesTrigger",
                Version = "2015-12-15",
                Protocol = "HTTPS",
                Pathname = "/triggers/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "array",
            };
            return TeaModel.ToObject<GetKubernetesTriggerResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary You can call the GetKubernetesTrigger operationto query the triggers of an application by application name.
         *
         * @param request GetKubernetesTriggerRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetKubernetesTriggerResponse
         */
        public async Task<GetKubernetesTriggerResponse> GetKubernetesTriggerWithOptionsAsync(string ClusterId, GetKubernetesTriggerRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                query["Namespace"] = request.Namespace;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["Type"] = request.Type;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Action))
            {
                query["action"] = request.Action;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetKubernetesTrigger",
                Version = "2015-12-15",
                Protocol = "HTTPS",
                Pathname = "/triggers/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "array",
            };
            return TeaModel.ToObject<GetKubernetesTriggerResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary You can call the GetKubernetesTrigger operationto query the triggers of an application by application name.
         *
         * @param request GetKubernetesTriggerRequest
         * @return GetKubernetesTriggerResponse
         */
        public GetKubernetesTriggerResponse GetKubernetesTrigger(string ClusterId, GetKubernetesTriggerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetKubernetesTriggerWithOptions(ClusterId, request, headers, runtime);
        }

        /**
         * @summary You can call the GetKubernetesTrigger operationto query the triggers of an application by application name.
         *
         * @param request GetKubernetesTriggerRequest
         * @return GetKubernetesTriggerResponse
         */
        public async Task<GetKubernetesTriggerResponse> GetKubernetesTriggerAsync(string ClusterId, GetKubernetesTriggerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetKubernetesTriggerWithOptionsAsync(ClusterId, request, headers, runtime);
        }

        /**
         * @deprecated OpenAPI GetUpgradeStatus is deprecated
         *
         * @summary You can call the GetUpgradeStatus operation to query the update progress of a cluster by cluster ID.
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetUpgradeStatusResponse
         */
        // Deprecated
        public GetUpgradeStatusResponse GetUpgradeStatusWithOptions(string ClusterId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetUpgradeStatus",
                Version = "2015-12-15",
                Protocol = "HTTPS",
                Pathname = "/api/v2/clusters/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId) + "/upgrade/status",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetUpgradeStatusResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @deprecated OpenAPI GetUpgradeStatus is deprecated
         *
         * @summary You can call the GetUpgradeStatus operation to query the update progress of a cluster by cluster ID.
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetUpgradeStatusResponse
         */
        // Deprecated
        public async Task<GetUpgradeStatusResponse> GetUpgradeStatusWithOptionsAsync(string ClusterId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetUpgradeStatus",
                Version = "2015-12-15",
                Protocol = "HTTPS",
                Pathname = "/api/v2/clusters/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId) + "/upgrade/status",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetUpgradeStatusResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @deprecated OpenAPI GetUpgradeStatus is deprecated
         *
         * @summary You can call the GetUpgradeStatus operation to query the update progress of a cluster by cluster ID.
         *
         * @return GetUpgradeStatusResponse
         */
        // Deprecated
        public GetUpgradeStatusResponse GetUpgradeStatus(string ClusterId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetUpgradeStatusWithOptions(ClusterId, headers, runtime);
        }

        /**
         * @deprecated OpenAPI GetUpgradeStatus is deprecated
         *
         * @summary You can call the GetUpgradeStatus operation to query the update progress of a cluster by cluster ID.
         *
         * @return GetUpgradeStatusResponse
         */
        // Deprecated
        public async Task<GetUpgradeStatusResponse> GetUpgradeStatusAsync(string ClusterId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetUpgradeStatusWithOptionsAsync(ClusterId, headers, runtime);
        }

        /**
         * @summary Updates the role-based access control (RBAC) permissions of a Resource Access Management (RAM) user or RAM role. By default, you do not have the RBAC permissions on a Container Service for Kubernetes (ACK) cluster if you are not the cluster owner or you are not using an Alibaba Cloud account. You can call this operation to specify the resources that can be accessed, permission scope, and predefined roles. This helps you better manage the access control on resources in ACK clusters.
         *
         * @description **Precautions**:
         * *   Make sure that you have attached a RAM policy that has at least the read-only permissions on the cluster to the RAM user or RAM role in the RAM console. Otherwise, the `ErrorRamPolicyConfig` error code is returned when you call the operation. For more information about how to authorize a RAM user by attaching RAM policies, see [Create a custom RAM policy](https://help.aliyun.com/document_detail/86485.html).
         * *   If you use a RAM user to call the operation, make sure that the RAM user has the permissions to modify the permissions of other RAM users or RAM roles. Otherwise, the `StatusForbidden` or `ForbiddenGrantPermissions` error code is returned when you call the operation. For more information, see [Use a RAM user to grant RBAC permissions to other RAM users](https://help.aliyun.com/document_detail/119035.html).
         * *   If you update full permissions, the existing permissions of the RAM user or RAM role on the cluster are overwritten. You must specify all the permissions that you want to grant to the RAM user or RAM role in the request parameters when you call the operation.
         *
         * @param request GrantPermissionsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GrantPermissionsResponse
         */
        public GrantPermissionsResponse GrantPermissionsWithOptions(string uid, GrantPermissionsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.TeaUtil.Common.ToArray(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GrantPermissions",
                Version = "2015-12-15",
                Protocol = "HTTPS",
                Pathname = "/permissions/users/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(uid),
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<GrantPermissionsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Updates the role-based access control (RBAC) permissions of a Resource Access Management (RAM) user or RAM role. By default, you do not have the RBAC permissions on a Container Service for Kubernetes (ACK) cluster if you are not the cluster owner or you are not using an Alibaba Cloud account. You can call this operation to specify the resources that can be accessed, permission scope, and predefined roles. This helps you better manage the access control on resources in ACK clusters.
         *
         * @description **Precautions**:
         * *   Make sure that you have attached a RAM policy that has at least the read-only permissions on the cluster to the RAM user or RAM role in the RAM console. Otherwise, the `ErrorRamPolicyConfig` error code is returned when you call the operation. For more information about how to authorize a RAM user by attaching RAM policies, see [Create a custom RAM policy](https://help.aliyun.com/document_detail/86485.html).
         * *   If you use a RAM user to call the operation, make sure that the RAM user has the permissions to modify the permissions of other RAM users or RAM roles. Otherwise, the `StatusForbidden` or `ForbiddenGrantPermissions` error code is returned when you call the operation. For more information, see [Use a RAM user to grant RBAC permissions to other RAM users](https://help.aliyun.com/document_detail/119035.html).
         * *   If you update full permissions, the existing permissions of the RAM user or RAM role on the cluster are overwritten. You must specify all the permissions that you want to grant to the RAM user or RAM role in the request parameters when you call the operation.
         *
         * @param request GrantPermissionsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GrantPermissionsResponse
         */
        public async Task<GrantPermissionsResponse> GrantPermissionsWithOptionsAsync(string uid, GrantPermissionsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.TeaUtil.Common.ToArray(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GrantPermissions",
                Version = "2015-12-15",
                Protocol = "HTTPS",
                Pathname = "/permissions/users/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(uid),
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<GrantPermissionsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Updates the role-based access control (RBAC) permissions of a Resource Access Management (RAM) user or RAM role. By default, you do not have the RBAC permissions on a Container Service for Kubernetes (ACK) cluster if you are not the cluster owner or you are not using an Alibaba Cloud account. You can call this operation to specify the resources that can be accessed, permission scope, and predefined roles. This helps you better manage the access control on resources in ACK clusters.
         *
         * @description **Precautions**:
         * *   Make sure that you have attached a RAM policy that has at least the read-only permissions on the cluster to the RAM user or RAM role in the RAM console. Otherwise, the `ErrorRamPolicyConfig` error code is returned when you call the operation. For more information about how to authorize a RAM user by attaching RAM policies, see [Create a custom RAM policy](https://help.aliyun.com/document_detail/86485.html).
         * *   If you use a RAM user to call the operation, make sure that the RAM user has the permissions to modify the permissions of other RAM users or RAM roles. Otherwise, the `StatusForbidden` or `ForbiddenGrantPermissions` error code is returned when you call the operation. For more information, see [Use a RAM user to grant RBAC permissions to other RAM users](https://help.aliyun.com/document_detail/119035.html).
         * *   If you update full permissions, the existing permissions of the RAM user or RAM role on the cluster are overwritten. You must specify all the permissions that you want to grant to the RAM user or RAM role in the request parameters when you call the operation.
         *
         * @param request GrantPermissionsRequest
         * @return GrantPermissionsResponse
         */
        public GrantPermissionsResponse GrantPermissions(string uid, GrantPermissionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GrantPermissionsWithOptions(uid, request, headers, runtime);
        }

        /**
         * @summary Updates the role-based access control (RBAC) permissions of a Resource Access Management (RAM) user or RAM role. By default, you do not have the RBAC permissions on a Container Service for Kubernetes (ACK) cluster if you are not the cluster owner or you are not using an Alibaba Cloud account. You can call this operation to specify the resources that can be accessed, permission scope, and predefined roles. This helps you better manage the access control on resources in ACK clusters.
         *
         * @description **Precautions**:
         * *   Make sure that you have attached a RAM policy that has at least the read-only permissions on the cluster to the RAM user or RAM role in the RAM console. Otherwise, the `ErrorRamPolicyConfig` error code is returned when you call the operation. For more information about how to authorize a RAM user by attaching RAM policies, see [Create a custom RAM policy](https://help.aliyun.com/document_detail/86485.html).
         * *   If you use a RAM user to call the operation, make sure that the RAM user has the permissions to modify the permissions of other RAM users or RAM roles. Otherwise, the `StatusForbidden` or `ForbiddenGrantPermissions` error code is returned when you call the operation. For more information, see [Use a RAM user to grant RBAC permissions to other RAM users](https://help.aliyun.com/document_detail/119035.html).
         * *   If you update full permissions, the existing permissions of the RAM user or RAM role on the cluster are overwritten. You must specify all the permissions that you want to grant to the RAM user or RAM role in the request parameters when you call the operation.
         *
         * @param request GrantPermissionsRequest
         * @return GrantPermissionsResponse
         */
        public async Task<GrantPermissionsResponse> GrantPermissionsAsync(string uid, GrantPermissionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GrantPermissionsWithOptionsAsync(uid, request, headers, runtime);
        }

        /**
         * @summary Installs a component by specifying the name and version of the component. To enhance Kubernetes capabilities, you can install a variety of components in Container Service for Kubernetes (ACK) clusters, such as fully-managed core components and application, logging and monitoring, network, storage, and security group components.
         *
         * @param request InstallClusterAddonsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return InstallClusterAddonsResponse
         */
        public InstallClusterAddonsResponse InstallClusterAddonsWithOptions(string ClusterId, InstallClusterAddonsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.TeaUtil.Common.ToArray(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "InstallClusterAddons",
                Version = "2015-12-15",
                Protocol = "HTTPS",
                Pathname = "/clusters/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId) + "/components/install",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<InstallClusterAddonsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Installs a component by specifying the name and version of the component. To enhance Kubernetes capabilities, you can install a variety of components in Container Service for Kubernetes (ACK) clusters, such as fully-managed core components and application, logging and monitoring, network, storage, and security group components.
         *
         * @param request InstallClusterAddonsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return InstallClusterAddonsResponse
         */
        public async Task<InstallClusterAddonsResponse> InstallClusterAddonsWithOptionsAsync(string ClusterId, InstallClusterAddonsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.TeaUtil.Common.ToArray(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "InstallClusterAddons",
                Version = "2015-12-15",
                Protocol = "HTTPS",
                Pathname = "/clusters/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId) + "/components/install",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<InstallClusterAddonsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Installs a component by specifying the name and version of the component. To enhance Kubernetes capabilities, you can install a variety of components in Container Service for Kubernetes (ACK) clusters, such as fully-managed core components and application, logging and monitoring, network, storage, and security group components.
         *
         * @param request InstallClusterAddonsRequest
         * @return InstallClusterAddonsResponse
         */
        public InstallClusterAddonsResponse InstallClusterAddons(string ClusterId, InstallClusterAddonsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return InstallClusterAddonsWithOptions(ClusterId, request, headers, runtime);
        }

        /**
         * @summary Installs a component by specifying the name and version of the component. To enhance Kubernetes capabilities, you can install a variety of components in Container Service for Kubernetes (ACK) clusters, such as fully-managed core components and application, logging and monitoring, network, storage, and security group components.
         *
         * @param request InstallClusterAddonsRequest
         * @return InstallClusterAddonsResponse
         */
        public async Task<InstallClusterAddonsResponse> InstallClusterAddonsAsync(string ClusterId, InstallClusterAddonsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await InstallClusterAddonsWithOptionsAsync(ClusterId, request, headers, runtime);
        }

        /**
         * @summary You can call the ListAddons operation to query all available components in a cluster. You can query all available components in a cluster by specifying the ID of the cluster. You can also specify parameters such as the region, cluster type, cluster subtype (profile), cluster specification, and cluster version to get a list of available components in clusters that meet the conditions.
         *
         * @param request ListAddonsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListAddonsResponse
         */
        public ListAddonsResponse ListAddonsWithOptions(ListAddonsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["cluster_id"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterSpec))
            {
                query["cluster_spec"] = request.ClusterSpec;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterType))
            {
                query["cluster_type"] = request.ClusterType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterVersion))
            {
                query["cluster_version"] = request.ClusterVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Profile))
            {
                query["profile"] = request.Profile;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["region_id"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListAddons",
                Version = "2015-12-15",
                Protocol = "HTTPS",
                Pathname = "/addons",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAddonsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary You can call the ListAddons operation to query all available components in a cluster. You can query all available components in a cluster by specifying the ID of the cluster. You can also specify parameters such as the region, cluster type, cluster subtype (profile), cluster specification, and cluster version to get a list of available components in clusters that meet the conditions.
         *
         * @param request ListAddonsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListAddonsResponse
         */
        public async Task<ListAddonsResponse> ListAddonsWithOptionsAsync(ListAddonsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["cluster_id"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterSpec))
            {
                query["cluster_spec"] = request.ClusterSpec;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterType))
            {
                query["cluster_type"] = request.ClusterType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterVersion))
            {
                query["cluster_version"] = request.ClusterVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Profile))
            {
                query["profile"] = request.Profile;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["region_id"] = request.RegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListAddons",
                Version = "2015-12-15",
                Protocol = "HTTPS",
                Pathname = "/addons",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAddonsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary You can call the ListAddons operation to query all available components in a cluster. You can query all available components in a cluster by specifying the ID of the cluster. You can also specify parameters such as the region, cluster type, cluster subtype (profile), cluster specification, and cluster version to get a list of available components in clusters that meet the conditions.
         *
         * @param request ListAddonsRequest
         * @return ListAddonsResponse
         */
        public ListAddonsResponse ListAddons(ListAddonsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListAddonsWithOptions(request, headers, runtime);
        }

        /**
         * @summary You can call the ListAddons operation to query all available components in a cluster. You can query all available components in a cluster by specifying the ID of the cluster. You can also specify parameters such as the region, cluster type, cluster subtype (profile), cluster specification, and cluster version to get a list of available components in clusters that meet the conditions.
         *
         * @param request ListAddonsRequest
         * @return ListAddonsResponse
         */
        public async Task<ListAddonsResponse> ListAddonsAsync(ListAddonsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListAddonsWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary You can call the ListClusterAddonInstances operation to query information about the components that are installed in a cluster.
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListClusterAddonInstancesResponse
         */
        public ListClusterAddonInstancesResponse ListClusterAddonInstancesWithOptions(string clusterId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListClusterAddonInstances",
                Version = "2015-12-15",
                Protocol = "HTTPS",
                Pathname = "/clusters/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(clusterId) + "/addon_instances",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListClusterAddonInstancesResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary You can call the ListClusterAddonInstances operation to query information about the components that are installed in a cluster.
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListClusterAddonInstancesResponse
         */
        public async Task<ListClusterAddonInstancesResponse> ListClusterAddonInstancesWithOptionsAsync(string clusterId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListClusterAddonInstances",
                Version = "2015-12-15",
                Protocol = "HTTPS",
                Pathname = "/clusters/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(clusterId) + "/addon_instances",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListClusterAddonInstancesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary You can call the ListClusterAddonInstances operation to query information about the components that are installed in a cluster.
         *
         * @return ListClusterAddonInstancesResponse
         */
        public ListClusterAddonInstancesResponse ListClusterAddonInstances(string clusterId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListClusterAddonInstancesWithOptions(clusterId, headers, runtime);
        }

        /**
         * @summary You can call the ListClusterAddonInstances operation to query information about the components that are installed in a cluster.
         *
         * @return ListClusterAddonInstancesResponse
         */
        public async Task<ListClusterAddonInstancesResponse> ListClusterAddonInstancesAsync(string clusterId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListClusterAddonInstancesWithOptionsAsync(clusterId, headers, runtime);
        }

        /**
         * @summary You can call the ListClusterChecks operation to query all the cluster check results of a cluster.
         *
         * @param request ListClusterChecksRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListClusterChecksResponse
         */
        public ListClusterChecksResponse ListClusterChecksWithOptions(string clusterId, ListClusterChecksRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Target))
            {
                query["target"] = request.Target;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["type"] = request.Type;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListClusterChecks",
                Version = "2015-12-15",
                Protocol = "HTTPS",
                Pathname = "/clusters/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(clusterId) + "/checks",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListClusterChecksResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary You can call the ListClusterChecks operation to query all the cluster check results of a cluster.
         *
         * @param request ListClusterChecksRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListClusterChecksResponse
         */
        public async Task<ListClusterChecksResponse> ListClusterChecksWithOptionsAsync(string clusterId, ListClusterChecksRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Target))
            {
                query["target"] = request.Target;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["type"] = request.Type;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListClusterChecks",
                Version = "2015-12-15",
                Protocol = "HTTPS",
                Pathname = "/clusters/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(clusterId) + "/checks",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListClusterChecksResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary You can call the ListClusterChecks operation to query all the cluster check results of a cluster.
         *
         * @param request ListClusterChecksRequest
         * @return ListClusterChecksResponse
         */
        public ListClusterChecksResponse ListClusterChecks(string clusterId, ListClusterChecksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListClusterChecksWithOptions(clusterId, request, headers, runtime);
        }

        /**
         * @summary You can call the ListClusterChecks operation to query all the cluster check results of a cluster.
         *
         * @param request ListClusterChecksRequest
         * @return ListClusterChecksResponse
         */
        public async Task<ListClusterChecksResponse> ListClusterChecksAsync(string clusterId, ListClusterChecksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListClusterChecksWithOptionsAsync(clusterId, request, headers, runtime);
        }

        /**
         * @summary You can call the ListClusterKubeconfigStates operation to query the kubeconfig files that are issued to users for the current cluster and the status of the kubeconfig files.
         *
         * @description > 
         * *   To call this operation, make sure that you have ram:ListUsers and ram:ListRoles permissions.
         * *   To call this operation, make sure that you have the AliyunCSFullAccess permissions.
         *
         * @param request ListClusterKubeconfigStatesRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListClusterKubeconfigStatesResponse
         */
        public ListClusterKubeconfigStatesResponse ListClusterKubeconfigStatesWithOptions(string ClusterId, ListClusterKubeconfigStatesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListClusterKubeconfigStates",
                Version = "2015-12-15",
                Protocol = "HTTPS",
                Pathname = "/clusters/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId) + "/kubeconfig/states",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListClusterKubeconfigStatesResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary You can call the ListClusterKubeconfigStates operation to query the kubeconfig files that are issued to users for the current cluster and the status of the kubeconfig files.
         *
         * @description > 
         * *   To call this operation, make sure that you have ram:ListUsers and ram:ListRoles permissions.
         * *   To call this operation, make sure that you have the AliyunCSFullAccess permissions.
         *
         * @param request ListClusterKubeconfigStatesRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListClusterKubeconfigStatesResponse
         */
        public async Task<ListClusterKubeconfigStatesResponse> ListClusterKubeconfigStatesWithOptionsAsync(string ClusterId, ListClusterKubeconfigStatesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListClusterKubeconfigStates",
                Version = "2015-12-15",
                Protocol = "HTTPS",
                Pathname = "/clusters/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId) + "/kubeconfig/states",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListClusterKubeconfigStatesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary You can call the ListClusterKubeconfigStates operation to query the kubeconfig files that are issued to users for the current cluster and the status of the kubeconfig files.
         *
         * @description > 
         * *   To call this operation, make sure that you have ram:ListUsers and ram:ListRoles permissions.
         * *   To call this operation, make sure that you have the AliyunCSFullAccess permissions.
         *
         * @param request ListClusterKubeconfigStatesRequest
         * @return ListClusterKubeconfigStatesResponse
         */
        public ListClusterKubeconfigStatesResponse ListClusterKubeconfigStates(string ClusterId, ListClusterKubeconfigStatesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListClusterKubeconfigStatesWithOptions(ClusterId, request, headers, runtime);
        }

        /**
         * @summary You can call the ListClusterKubeconfigStates operation to query the kubeconfig files that are issued to users for the current cluster and the status of the kubeconfig files.
         *
         * @description > 
         * *   To call this operation, make sure that you have ram:ListUsers and ram:ListRoles permissions.
         * *   To call this operation, make sure that you have the AliyunCSFullAccess permissions.
         *
         * @param request ListClusterKubeconfigStatesRequest
         * @return ListClusterKubeconfigStatesResponse
         */
        public async Task<ListClusterKubeconfigStatesResponse> ListClusterKubeconfigStatesAsync(string ClusterId, ListClusterKubeconfigStatesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListClusterKubeconfigStatesWithOptionsAsync(ClusterId, request, headers, runtime);
        }

        /**
         * @summary 获取自动运维执行计划列表
         *
         * @param request ListOperationPlansRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListOperationPlansResponse
         */
        public ListOperationPlansResponse ListOperationPlansWithOptions(ListOperationPlansRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["cluster_id"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["type"] = request.Type;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListOperationPlans",
                Version = "2015-12-15",
                Protocol = "HTTPS",
                Pathname = "/operation/plans",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListOperationPlansResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 获取自动运维执行计划列表
         *
         * @param request ListOperationPlansRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListOperationPlansResponse
         */
        public async Task<ListOperationPlansResponse> ListOperationPlansWithOptionsAsync(ListOperationPlansRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["cluster_id"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["type"] = request.Type;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListOperationPlans",
                Version = "2015-12-15",
                Protocol = "HTTPS",
                Pathname = "/operation/plans",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListOperationPlansResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 获取自动运维执行计划列表
         *
         * @param request ListOperationPlansRequest
         * @return ListOperationPlansResponse
         */
        public ListOperationPlansResponse ListOperationPlans(ListOperationPlansRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListOperationPlansWithOptions(request, headers, runtime);
        }

        /**
         * @summary 获取自动运维执行计划列表
         *
         * @param request ListOperationPlansRequest
         * @return ListOperationPlansResponse
         */
        public async Task<ListOperationPlansResponse> ListOperationPlansAsync(ListOperationPlansRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListOperationPlansWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary Queries resource labels and the detailed information, such as the key-value pairs of the labels and the clusters to which the labels are added. You can use labels to classify and manage Container Service for Kubernetes (ACK) clusters in order to meet monitoring, cost analysis, and tenant isolation requirements.
         *
         * @param tmpReq ListTagResourcesRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListTagResourcesResponse
         */
        public ListTagResourcesResponse ListTagResourcesWithOptions(ListTagResourcesRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListTagResourcesShrinkRequest request = new ListTagResourcesShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ResourceIds))
            {
                request.ResourceIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ResourceIds, "resource_ids", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Tags))
            {
                request.TagsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Tags, "tags", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["next_token"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["region_id"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceIdsShrink))
            {
                query["resource_ids"] = request.ResourceIdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["resource_type"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagsShrink))
            {
                query["tags"] = request.TagsShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTagResources",
                Version = "2015-12-15",
                Protocol = "HTTPS",
                Pathname = "/tags",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTagResourcesResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries resource labels and the detailed information, such as the key-value pairs of the labels and the clusters to which the labels are added. You can use labels to classify and manage Container Service for Kubernetes (ACK) clusters in order to meet monitoring, cost analysis, and tenant isolation requirements.
         *
         * @param tmpReq ListTagResourcesRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListTagResourcesResponse
         */
        public async Task<ListTagResourcesResponse> ListTagResourcesWithOptionsAsync(ListTagResourcesRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListTagResourcesShrinkRequest request = new ListTagResourcesShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ResourceIds))
            {
                request.ResourceIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ResourceIds, "resource_ids", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Tags))
            {
                request.TagsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Tags, "tags", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["next_token"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["region_id"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceIdsShrink))
            {
                query["resource_ids"] = request.ResourceIdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["resource_type"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagsShrink))
            {
                query["tags"] = request.TagsShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTagResources",
                Version = "2015-12-15",
                Protocol = "HTTPS",
                Pathname = "/tags",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTagResourcesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries resource labels and the detailed information, such as the key-value pairs of the labels and the clusters to which the labels are added. You can use labels to classify and manage Container Service for Kubernetes (ACK) clusters in order to meet monitoring, cost analysis, and tenant isolation requirements.
         *
         * @param request ListTagResourcesRequest
         * @return ListTagResourcesResponse
         */
        public ListTagResourcesResponse ListTagResources(ListTagResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListTagResourcesWithOptions(request, headers, runtime);
        }

        /**
         * @summary Queries resource labels and the detailed information, such as the key-value pairs of the labels and the clusters to which the labels are added. You can use labels to classify and manage Container Service for Kubernetes (ACK) clusters in order to meet monitoring, cost analysis, and tenant isolation requirements.
         *
         * @param request ListTagResourcesRequest
         * @return ListTagResourcesResponse
         */
        public async Task<ListTagResourcesResponse> ListTagResourcesAsync(ListTagResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListTagResourcesWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary You can call the ListUserKubeConfigStates operation to query the status of the kubeconfig files of all clusters managed by the current user.
         *
         * @description >  To call this operation, make sure that you have the AliyunCSFullAccess permissions.
         *
         * @param request ListUserKubeConfigStatesRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListUserKubeConfigStatesResponse
         */
        public ListUserKubeConfigStatesResponse ListUserKubeConfigStatesWithOptions(string Uid, ListUserKubeConfigStatesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["page_number"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["page_size"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListUserKubeConfigStates",
                Version = "2015-12-15",
                Protocol = "HTTPS",
                Pathname = "/users/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(Uid) + "/kubeconfig/states",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListUserKubeConfigStatesResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary You can call the ListUserKubeConfigStates operation to query the status of the kubeconfig files of all clusters managed by the current user.
         *
         * @description >  To call this operation, make sure that you have the AliyunCSFullAccess permissions.
         *
         * @param request ListUserKubeConfigStatesRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListUserKubeConfigStatesResponse
         */
        public async Task<ListUserKubeConfigStatesResponse> ListUserKubeConfigStatesWithOptionsAsync(string Uid, ListUserKubeConfigStatesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["page_number"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["page_size"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListUserKubeConfigStates",
                Version = "2015-12-15",
                Protocol = "HTTPS",
                Pathname = "/users/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(Uid) + "/kubeconfig/states",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListUserKubeConfigStatesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary You can call the ListUserKubeConfigStates operation to query the status of the kubeconfig files of all clusters managed by the current user.
         *
         * @description >  To call this operation, make sure that you have the AliyunCSFullAccess permissions.
         *
         * @param request ListUserKubeConfigStatesRequest
         * @return ListUserKubeConfigStatesResponse
         */
        public ListUserKubeConfigStatesResponse ListUserKubeConfigStates(string Uid, ListUserKubeConfigStatesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListUserKubeConfigStatesWithOptions(Uid, request, headers, runtime);
        }

        /**
         * @summary You can call the ListUserKubeConfigStates operation to query the status of the kubeconfig files of all clusters managed by the current user.
         *
         * @description >  To call this operation, make sure that you have the AliyunCSFullAccess permissions.
         *
         * @param request ListUserKubeConfigStatesRequest
         * @return ListUserKubeConfigStatesResponse
         */
        public async Task<ListUserKubeConfigStatesResponse> ListUserKubeConfigStatesAsync(string Uid, ListUserKubeConfigStatesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListUserKubeConfigStatesWithOptionsAsync(Uid, request, headers, runtime);
        }

        /**
         * @summary Container Service for Kubernetes (ACK) Pro clusters are developed based on ACK Basic clusters. ACK Pro clusters provide all benefits of ACK managed clusters, such as fully-managed control planes and control plane high availability. In addition, ACK Pro clusters provide you with enhanced reliability, security, and schedulability. ACK Pro clusters are covered by the SLA that supports compensation clauses. ACK Pro clusters are suitable for large-scale businesses that require high stability and security in production environments. We recommend that you migrate from ACK Basic clusters to ACK Pro clusters.
         *
         * @param request MigrateClusterRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return MigrateClusterResponse
         */
        public MigrateClusterResponse MigrateClusterWithOptions(string clusterId, MigrateClusterRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OssBucketEndpoint))
            {
                body["oss_bucket_endpoint"] = request.OssBucketEndpoint;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OssBucketName))
            {
                body["oss_bucket_name"] = request.OssBucketName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "MigrateCluster",
                Version = "2015-12-15",
                Protocol = "HTTPS",
                Pathname = "/clusters/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(clusterId) + "/migrate",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<MigrateClusterResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Container Service for Kubernetes (ACK) Pro clusters are developed based on ACK Basic clusters. ACK Pro clusters provide all benefits of ACK managed clusters, such as fully-managed control planes and control plane high availability. In addition, ACK Pro clusters provide you with enhanced reliability, security, and schedulability. ACK Pro clusters are covered by the SLA that supports compensation clauses. ACK Pro clusters are suitable for large-scale businesses that require high stability and security in production environments. We recommend that you migrate from ACK Basic clusters to ACK Pro clusters.
         *
         * @param request MigrateClusterRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return MigrateClusterResponse
         */
        public async Task<MigrateClusterResponse> MigrateClusterWithOptionsAsync(string clusterId, MigrateClusterRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OssBucketEndpoint))
            {
                body["oss_bucket_endpoint"] = request.OssBucketEndpoint;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OssBucketName))
            {
                body["oss_bucket_name"] = request.OssBucketName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "MigrateCluster",
                Version = "2015-12-15",
                Protocol = "HTTPS",
                Pathname = "/clusters/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(clusterId) + "/migrate",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<MigrateClusterResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Container Service for Kubernetes (ACK) Pro clusters are developed based on ACK Basic clusters. ACK Pro clusters provide all benefits of ACK managed clusters, such as fully-managed control planes and control plane high availability. In addition, ACK Pro clusters provide you with enhanced reliability, security, and schedulability. ACK Pro clusters are covered by the SLA that supports compensation clauses. ACK Pro clusters are suitable for large-scale businesses that require high stability and security in production environments. We recommend that you migrate from ACK Basic clusters to ACK Pro clusters.
         *
         * @param request MigrateClusterRequest
         * @return MigrateClusterResponse
         */
        public MigrateClusterResponse MigrateCluster(string clusterId, MigrateClusterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return MigrateClusterWithOptions(clusterId, request, headers, runtime);
        }

        /**
         * @summary Container Service for Kubernetes (ACK) Pro clusters are developed based on ACK Basic clusters. ACK Pro clusters provide all benefits of ACK managed clusters, such as fully-managed control planes and control plane high availability. In addition, ACK Pro clusters provide you with enhanced reliability, security, and schedulability. ACK Pro clusters are covered by the SLA that supports compensation clauses. ACK Pro clusters are suitable for large-scale businesses that require high stability and security in production environments. We recommend that you migrate from ACK Basic clusters to ACK Pro clusters.
         *
         * @param request MigrateClusterRequest
         * @return MigrateClusterResponse
         */
        public async Task<MigrateClusterResponse> MigrateClusterAsync(string clusterId, MigrateClusterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await MigrateClusterWithOptionsAsync(clusterId, request, headers, runtime);
        }

        /**
         * @summary You can call the ModifyCluster operation to modify the cluster configurations by cluster ID.
         *
         * @param request ModifyClusterRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyClusterResponse
         */
        public ModifyClusterResponse ModifyClusterWithOptions(string ClusterId, ModifyClusterRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessControlList))
            {
                body["access_control_list"] = request.AccessControlList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApiServerCustomCertSans))
            {
                body["api_server_custom_cert_sans"] = request.ApiServerCustomCertSans;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApiServerEip))
            {
                body["api_server_eip"] = request.ApiServerEip;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApiServerEipId))
            {
                body["api_server_eip_id"] = request.ApiServerEipId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterName))
            {
                body["cluster_name"] = request.ClusterName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeletionProtection))
            {
                body["deletion_protection"] = request.DeletionProtection;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableRrsa))
            {
                body["enable_rrsa"] = request.EnableRrsa;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IngressDomainRebinding))
            {
                body["ingress_domain_rebinding"] = request.IngressDomainRebinding;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IngressLoadbalancerId))
            {
                body["ingress_loadbalancer_id"] = request.IngressLoadbalancerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceDeletionProtection))
            {
                body["instance_deletion_protection"] = request.InstanceDeletionProtection;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaintenanceWindow))
            {
                body["maintenance_window"] = request.MaintenanceWindow;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperationPolicy))
            {
                body["operation_policy"] = request.OperationPolicy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                body["resource_group_id"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SystemEventsLogging))
            {
                body["system_events_logging"] = request.SystemEventsLogging;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyCluster",
                Version = "2015-12-15",
                Protocol = "HTTPS",
                Pathname = "/api/v2/clusters/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyClusterResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary You can call the ModifyCluster operation to modify the cluster configurations by cluster ID.
         *
         * @param request ModifyClusterRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyClusterResponse
         */
        public async Task<ModifyClusterResponse> ModifyClusterWithOptionsAsync(string ClusterId, ModifyClusterRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccessControlList))
            {
                body["access_control_list"] = request.AccessControlList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApiServerCustomCertSans))
            {
                body["api_server_custom_cert_sans"] = request.ApiServerCustomCertSans;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApiServerEip))
            {
                body["api_server_eip"] = request.ApiServerEip;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApiServerEipId))
            {
                body["api_server_eip_id"] = request.ApiServerEipId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterName))
            {
                body["cluster_name"] = request.ClusterName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeletionProtection))
            {
                body["deletion_protection"] = request.DeletionProtection;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableRrsa))
            {
                body["enable_rrsa"] = request.EnableRrsa;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IngressDomainRebinding))
            {
                body["ingress_domain_rebinding"] = request.IngressDomainRebinding;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IngressLoadbalancerId))
            {
                body["ingress_loadbalancer_id"] = request.IngressLoadbalancerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceDeletionProtection))
            {
                body["instance_deletion_protection"] = request.InstanceDeletionProtection;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaintenanceWindow))
            {
                body["maintenance_window"] = request.MaintenanceWindow;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperationPolicy))
            {
                body["operation_policy"] = request.OperationPolicy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                body["resource_group_id"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SystemEventsLogging))
            {
                body["system_events_logging"] = request.SystemEventsLogging;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyCluster",
                Version = "2015-12-15",
                Protocol = "HTTPS",
                Pathname = "/api/v2/clusters/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyClusterResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary You can call the ModifyCluster operation to modify the cluster configurations by cluster ID.
         *
         * @param request ModifyClusterRequest
         * @return ModifyClusterResponse
         */
        public ModifyClusterResponse ModifyCluster(string ClusterId, ModifyClusterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ModifyClusterWithOptions(ClusterId, request, headers, runtime);
        }

        /**
         * @summary You can call the ModifyCluster operation to modify the cluster configurations by cluster ID.
         *
         * @param request ModifyClusterRequest
         * @return ModifyClusterResponse
         */
        public async Task<ModifyClusterResponse> ModifyClusterAsync(string ClusterId, ModifyClusterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ModifyClusterWithOptionsAsync(ClusterId, request, headers, runtime);
        }

        /**
         * @summary Modifies the configuration of a cluster component. This operation may affect your businesses. We recommend that you assess the impact, back up data, and perform the operation during off-peak hours.
         *
         * @description You can use this API operation to modify the components in a Container Service for Kubernetes (ACK) cluster or the control plane components in an ACK Pro cluster.
         * *   To query the customizable parameters of a component, call the `DescribeClusterAddonMetadata` API operation. For more information, see [Query the metadata of a specified component version](https://www.alibabacloud.com/help/zh/container-service-for-kubernetes/latest/query).
         * *   For more information about the customizable parameters of control plane components in ACK Pro clusters, see [Customize the parameters of control plane components in ACK Pro clusters](https://www.alibabacloud.com/help/zh/container-service-for-kubernetes/latest/customize-control-plane-parameters-for-a-professional-kubernetes-cluster).
         * After you call this operation, the component may be redeployed and restarted. We recommend that you assess the impact before you call this operation.
         *
         * @param request ModifyClusterAddonRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyClusterAddonResponse
         */
        public ModifyClusterAddonResponse ModifyClusterAddonWithOptions(string clusterId, string componentId, ModifyClusterAddonRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Config))
            {
                body["config"] = request.Config;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyClusterAddon",
                Version = "2015-12-15",
                Protocol = "HTTPS",
                Pathname = "/clusters/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(clusterId) + "/components/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(componentId) + "/config",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<ModifyClusterAddonResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Modifies the configuration of a cluster component. This operation may affect your businesses. We recommend that you assess the impact, back up data, and perform the operation during off-peak hours.
         *
         * @description You can use this API operation to modify the components in a Container Service for Kubernetes (ACK) cluster or the control plane components in an ACK Pro cluster.
         * *   To query the customizable parameters of a component, call the `DescribeClusterAddonMetadata` API operation. For more information, see [Query the metadata of a specified component version](https://www.alibabacloud.com/help/zh/container-service-for-kubernetes/latest/query).
         * *   For more information about the customizable parameters of control plane components in ACK Pro clusters, see [Customize the parameters of control plane components in ACK Pro clusters](https://www.alibabacloud.com/help/zh/container-service-for-kubernetes/latest/customize-control-plane-parameters-for-a-professional-kubernetes-cluster).
         * After you call this operation, the component may be redeployed and restarted. We recommend that you assess the impact before you call this operation.
         *
         * @param request ModifyClusterAddonRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyClusterAddonResponse
         */
        public async Task<ModifyClusterAddonResponse> ModifyClusterAddonWithOptionsAsync(string clusterId, string componentId, ModifyClusterAddonRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Config))
            {
                body["config"] = request.Config;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyClusterAddon",
                Version = "2015-12-15",
                Protocol = "HTTPS",
                Pathname = "/clusters/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(clusterId) + "/components/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(componentId) + "/config",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<ModifyClusterAddonResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Modifies the configuration of a cluster component. This operation may affect your businesses. We recommend that you assess the impact, back up data, and perform the operation during off-peak hours.
         *
         * @description You can use this API operation to modify the components in a Container Service for Kubernetes (ACK) cluster or the control plane components in an ACK Pro cluster.
         * *   To query the customizable parameters of a component, call the `DescribeClusterAddonMetadata` API operation. For more information, see [Query the metadata of a specified component version](https://www.alibabacloud.com/help/zh/container-service-for-kubernetes/latest/query).
         * *   For more information about the customizable parameters of control plane components in ACK Pro clusters, see [Customize the parameters of control plane components in ACK Pro clusters](https://www.alibabacloud.com/help/zh/container-service-for-kubernetes/latest/customize-control-plane-parameters-for-a-professional-kubernetes-cluster).
         * After you call this operation, the component may be redeployed and restarted. We recommend that you assess the impact before you call this operation.
         *
         * @param request ModifyClusterAddonRequest
         * @return ModifyClusterAddonResponse
         */
        public ModifyClusterAddonResponse ModifyClusterAddon(string clusterId, string componentId, ModifyClusterAddonRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ModifyClusterAddonWithOptions(clusterId, componentId, request, headers, runtime);
        }

        /**
         * @summary Modifies the configuration of a cluster component. This operation may affect your businesses. We recommend that you assess the impact, back up data, and perform the operation during off-peak hours.
         *
         * @description You can use this API operation to modify the components in a Container Service for Kubernetes (ACK) cluster or the control plane components in an ACK Pro cluster.
         * *   To query the customizable parameters of a component, call the `DescribeClusterAddonMetadata` API operation. For more information, see [Query the metadata of a specified component version](https://www.alibabacloud.com/help/zh/container-service-for-kubernetes/latest/query).
         * *   For more information about the customizable parameters of control plane components in ACK Pro clusters, see [Customize the parameters of control plane components in ACK Pro clusters](https://www.alibabacloud.com/help/zh/container-service-for-kubernetes/latest/customize-control-plane-parameters-for-a-professional-kubernetes-cluster).
         * After you call this operation, the component may be redeployed and restarted. We recommend that you assess the impact before you call this operation.
         *
         * @param request ModifyClusterAddonRequest
         * @return ModifyClusterAddonResponse
         */
        public async Task<ModifyClusterAddonResponse> ModifyClusterAddonAsync(string clusterId, string componentId, ModifyClusterAddonRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ModifyClusterAddonWithOptionsAsync(clusterId, componentId, request, headers, runtime);
        }

        /**
         * @summary This API operation applies only to Container Service for Kubernetes (ACK) managed clusters.
         *
         * @param request ModifyClusterConfigurationRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyClusterConfigurationResponse
         */
        public ModifyClusterConfigurationResponse ModifyClusterConfigurationWithOptions(string ClusterId, ModifyClusterConfigurationRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomizeConfig))
            {
                body["customize_config"] = request.CustomizeConfig;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyClusterConfiguration",
                Version = "2015-12-15",
                Protocol = "HTTPS",
                Pathname = "/clusters/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId) + "/configuration",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<ModifyClusterConfigurationResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary This API operation applies only to Container Service for Kubernetes (ACK) managed clusters.
         *
         * @param request ModifyClusterConfigurationRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyClusterConfigurationResponse
         */
        public async Task<ModifyClusterConfigurationResponse> ModifyClusterConfigurationWithOptionsAsync(string ClusterId, ModifyClusterConfigurationRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomizeConfig))
            {
                body["customize_config"] = request.CustomizeConfig;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyClusterConfiguration",
                Version = "2015-12-15",
                Protocol = "HTTPS",
                Pathname = "/clusters/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId) + "/configuration",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<ModifyClusterConfigurationResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary This API operation applies only to Container Service for Kubernetes (ACK) managed clusters.
         *
         * @param request ModifyClusterConfigurationRequest
         * @return ModifyClusterConfigurationResponse
         */
        public ModifyClusterConfigurationResponse ModifyClusterConfiguration(string ClusterId, ModifyClusterConfigurationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ModifyClusterConfigurationWithOptions(ClusterId, request, headers, runtime);
        }

        /**
         * @summary This API operation applies only to Container Service for Kubernetes (ACK) managed clusters.
         *
         * @param request ModifyClusterConfigurationRequest
         * @return ModifyClusterConfigurationResponse
         */
        public async Task<ModifyClusterConfigurationResponse> ModifyClusterConfigurationAsync(string ClusterId, ModifyClusterConfigurationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ModifyClusterConfigurationWithOptionsAsync(ClusterId, request, headers, runtime);
        }

        /**
         * @summary You can call the ModifyClusterNodePool operation to modify the configuration of a node pool with the specified node pool ID.
         *
         * @param request ModifyClusterNodePoolRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyClusterNodePoolResponse
         */
        public ModifyClusterNodePoolResponse ModifyClusterNodePoolWithOptions(string ClusterId, string NodepoolId, ModifyClusterNodePoolRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoScaling))
            {
                body["auto_scaling"] = request.AutoScaling;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Concurrency))
            {
                body["concurrency"] = request.Concurrency;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KubernetesConfig))
            {
                body["kubernetes_config"] = request.KubernetesConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Management))
            {
                body["management"] = request.Management;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodepoolInfo))
            {
                body["nodepool_info"] = request.NodepoolInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScalingGroup))
            {
                body["scaling_group"] = request.ScalingGroup;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TeeConfig))
            {
                body["tee_config"] = request.TeeConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UpdateNodes))
            {
                body["update_nodes"] = request.UpdateNodes;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyClusterNodePool",
                Version = "2015-12-15",
                Protocol = "HTTPS",
                Pathname = "/clusters/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId) + "/nodepools/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(NodepoolId),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyClusterNodePoolResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary You can call the ModifyClusterNodePool operation to modify the configuration of a node pool with the specified node pool ID.
         *
         * @param request ModifyClusterNodePoolRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyClusterNodePoolResponse
         */
        public async Task<ModifyClusterNodePoolResponse> ModifyClusterNodePoolWithOptionsAsync(string ClusterId, string NodepoolId, ModifyClusterNodePoolRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoScaling))
            {
                body["auto_scaling"] = request.AutoScaling;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Concurrency))
            {
                body["concurrency"] = request.Concurrency;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KubernetesConfig))
            {
                body["kubernetes_config"] = request.KubernetesConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Management))
            {
                body["management"] = request.Management;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodepoolInfo))
            {
                body["nodepool_info"] = request.NodepoolInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScalingGroup))
            {
                body["scaling_group"] = request.ScalingGroup;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TeeConfig))
            {
                body["tee_config"] = request.TeeConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UpdateNodes))
            {
                body["update_nodes"] = request.UpdateNodes;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyClusterNodePool",
                Version = "2015-12-15",
                Protocol = "HTTPS",
                Pathname = "/clusters/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId) + "/nodepools/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(NodepoolId),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyClusterNodePoolResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary You can call the ModifyClusterNodePool operation to modify the configuration of a node pool with the specified node pool ID.
         *
         * @param request ModifyClusterNodePoolRequest
         * @return ModifyClusterNodePoolResponse
         */
        public ModifyClusterNodePoolResponse ModifyClusterNodePool(string ClusterId, string NodepoolId, ModifyClusterNodePoolRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ModifyClusterNodePoolWithOptions(ClusterId, NodepoolId, request, headers, runtime);
        }

        /**
         * @summary You can call the ModifyClusterNodePool operation to modify the configuration of a node pool with the specified node pool ID.
         *
         * @param request ModifyClusterNodePoolRequest
         * @return ModifyClusterNodePoolResponse
         */
        public async Task<ModifyClusterNodePoolResponse> ModifyClusterNodePoolAsync(string ClusterId, string NodepoolId, ModifyClusterNodePoolRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ModifyClusterNodePoolWithOptionsAsync(ClusterId, NodepoolId, request, headers, runtime);
        }

        /**
         * @summary Modifies the labels of a Container Service for Kubernetes (ACK) cluster. You can use labels (key-value pairs) to classify and manage ACK clusters in order to meet monitoring, cost analysis, and tenant isolation requirements.
         *
         * @param request ModifyClusterTagsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyClusterTagsResponse
         */
        public ModifyClusterTagsResponse ModifyClusterTagsWithOptions(string ClusterId, ModifyClusterTagsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.TeaUtil.Common.ToArray(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyClusterTags",
                Version = "2015-12-15",
                Protocol = "HTTPS",
                Pathname = "/clusters/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId) + "/tags",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<ModifyClusterTagsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Modifies the labels of a Container Service for Kubernetes (ACK) cluster. You can use labels (key-value pairs) to classify and manage ACK clusters in order to meet monitoring, cost analysis, and tenant isolation requirements.
         *
         * @param request ModifyClusterTagsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyClusterTagsResponse
         */
        public async Task<ModifyClusterTagsResponse> ModifyClusterTagsWithOptionsAsync(string ClusterId, ModifyClusterTagsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.TeaUtil.Common.ToArray(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyClusterTags",
                Version = "2015-12-15",
                Protocol = "HTTPS",
                Pathname = "/clusters/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId) + "/tags",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<ModifyClusterTagsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Modifies the labels of a Container Service for Kubernetes (ACK) cluster. You can use labels (key-value pairs) to classify and manage ACK clusters in order to meet monitoring, cost analysis, and tenant isolation requirements.
         *
         * @param request ModifyClusterTagsRequest
         * @return ModifyClusterTagsResponse
         */
        public ModifyClusterTagsResponse ModifyClusterTags(string ClusterId, ModifyClusterTagsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ModifyClusterTagsWithOptions(ClusterId, request, headers, runtime);
        }

        /**
         * @summary Modifies the labels of a Container Service for Kubernetes (ACK) cluster. You can use labels (key-value pairs) to classify and manage ACK clusters in order to meet monitoring, cost analysis, and tenant isolation requirements.
         *
         * @param request ModifyClusterTagsRequest
         * @return ModifyClusterTagsResponse
         */
        public async Task<ModifyClusterTagsResponse> ModifyClusterTagsAsync(string ClusterId, ModifyClusterTagsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ModifyClusterTagsWithOptionsAsync(ClusterId, request, headers, runtime);
        }

        /**
         * @summary Modifies the configuration of a node pool, such as the kubelet configuration and node rolling update configuration. After you modify the node pool configuration, nodes are batch updated and the kubelet on each node is restarted. This may adversely affect the nodes and workloads. We recommend that you perform this operation during off-peak hours.
         *
         * @description >  Container Service for Kubernetes (ACK) allows you to modify the kubelet configuration of nodes in a node pool. After you modify the kubelet configuration, the new configuration immediately takes effect on existing nodes in the node pool and is automatically applied to newly added nodes.
         *
         * @param request ModifyNodePoolNodeConfigRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyNodePoolNodeConfigResponse
         */
        public ModifyNodePoolNodeConfigResponse ModifyNodePoolNodeConfigWithOptions(string ClusterId, string NodepoolId, ModifyNodePoolNodeConfigRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KubeletConfig))
            {
                body["kubelet_config"] = request.KubeletConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OsConfig))
            {
                body["os_config"] = request.OsConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RollingPolicy))
            {
                body["rolling_policy"] = request.RollingPolicy;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyNodePoolNodeConfig",
                Version = "2015-12-15",
                Protocol = "HTTPS",
                Pathname = "/clusters/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId) + "/nodepools/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(NodepoolId) + "/node_config",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyNodePoolNodeConfigResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Modifies the configuration of a node pool, such as the kubelet configuration and node rolling update configuration. After you modify the node pool configuration, nodes are batch updated and the kubelet on each node is restarted. This may adversely affect the nodes and workloads. We recommend that you perform this operation during off-peak hours.
         *
         * @description >  Container Service for Kubernetes (ACK) allows you to modify the kubelet configuration of nodes in a node pool. After you modify the kubelet configuration, the new configuration immediately takes effect on existing nodes in the node pool and is automatically applied to newly added nodes.
         *
         * @param request ModifyNodePoolNodeConfigRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyNodePoolNodeConfigResponse
         */
        public async Task<ModifyNodePoolNodeConfigResponse> ModifyNodePoolNodeConfigWithOptionsAsync(string ClusterId, string NodepoolId, ModifyNodePoolNodeConfigRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KubeletConfig))
            {
                body["kubelet_config"] = request.KubeletConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OsConfig))
            {
                body["os_config"] = request.OsConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RollingPolicy))
            {
                body["rolling_policy"] = request.RollingPolicy;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyNodePoolNodeConfig",
                Version = "2015-12-15",
                Protocol = "HTTPS",
                Pathname = "/clusters/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId) + "/nodepools/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(NodepoolId) + "/node_config",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyNodePoolNodeConfigResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Modifies the configuration of a node pool, such as the kubelet configuration and node rolling update configuration. After you modify the node pool configuration, nodes are batch updated and the kubelet on each node is restarted. This may adversely affect the nodes and workloads. We recommend that you perform this operation during off-peak hours.
         *
         * @description >  Container Service for Kubernetes (ACK) allows you to modify the kubelet configuration of nodes in a node pool. After you modify the kubelet configuration, the new configuration immediately takes effect on existing nodes in the node pool and is automatically applied to newly added nodes.
         *
         * @param request ModifyNodePoolNodeConfigRequest
         * @return ModifyNodePoolNodeConfigResponse
         */
        public ModifyNodePoolNodeConfigResponse ModifyNodePoolNodeConfig(string ClusterId, string NodepoolId, ModifyNodePoolNodeConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ModifyNodePoolNodeConfigWithOptions(ClusterId, NodepoolId, request, headers, runtime);
        }

        /**
         * @summary Modifies the configuration of a node pool, such as the kubelet configuration and node rolling update configuration. After you modify the node pool configuration, nodes are batch updated and the kubelet on each node is restarted. This may adversely affect the nodes and workloads. We recommend that you perform this operation during off-peak hours.
         *
         * @description >  Container Service for Kubernetes (ACK) allows you to modify the kubelet configuration of nodes in a node pool. After you modify the kubelet configuration, the new configuration immediately takes effect on existing nodes in the node pool and is automatically applied to newly added nodes.
         *
         * @param request ModifyNodePoolNodeConfigRequest
         * @return ModifyNodePoolNodeConfigResponse
         */
        public async Task<ModifyNodePoolNodeConfigResponse> ModifyNodePoolNodeConfigAsync(string ClusterId, string NodepoolId, ModifyNodePoolNodeConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ModifyNodePoolNodeConfigWithOptionsAsync(ClusterId, NodepoolId, request, headers, runtime);
        }

        /**
         * @summary Updates a policy in a specific Container Service for Kubernetes (ACK) cluster. You can modify the action of the policy such as alerting or denying and namespaces to which the policy applies.
         *
         * @param request ModifyPolicyInstanceRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyPolicyInstanceResponse
         */
        public ModifyPolicyInstanceResponse ModifyPolicyInstanceWithOptions(string clusterId, string policyName, ModifyPolicyInstanceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Action))
            {
                body["action"] = request.Action;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceName))
            {
                body["instance_name"] = request.InstanceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespaces))
            {
                body["namespaces"] = request.Namespaces;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Parameters))
            {
                body["parameters"] = request.Parameters;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyPolicyInstance",
                Version = "2015-12-15",
                Protocol = "HTTPS",
                Pathname = "/clusters/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(clusterId) + "/policies/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(policyName),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyPolicyInstanceResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Updates a policy in a specific Container Service for Kubernetes (ACK) cluster. You can modify the action of the policy such as alerting or denying and namespaces to which the policy applies.
         *
         * @param request ModifyPolicyInstanceRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyPolicyInstanceResponse
         */
        public async Task<ModifyPolicyInstanceResponse> ModifyPolicyInstanceWithOptionsAsync(string clusterId, string policyName, ModifyPolicyInstanceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Action))
            {
                body["action"] = request.Action;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceName))
            {
                body["instance_name"] = request.InstanceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespaces))
            {
                body["namespaces"] = request.Namespaces;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Parameters))
            {
                body["parameters"] = request.Parameters;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyPolicyInstance",
                Version = "2015-12-15",
                Protocol = "HTTPS",
                Pathname = "/clusters/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(clusterId) + "/policies/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(policyName),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyPolicyInstanceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Updates a policy in a specific Container Service for Kubernetes (ACK) cluster. You can modify the action of the policy such as alerting or denying and namespaces to which the policy applies.
         *
         * @param request ModifyPolicyInstanceRequest
         * @return ModifyPolicyInstanceResponse
         */
        public ModifyPolicyInstanceResponse ModifyPolicyInstance(string clusterId, string policyName, ModifyPolicyInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ModifyPolicyInstanceWithOptions(clusterId, policyName, request, headers, runtime);
        }

        /**
         * @summary Updates a policy in a specific Container Service for Kubernetes (ACK) cluster. You can modify the action of the policy such as alerting or denying and namespaces to which the policy applies.
         *
         * @param request ModifyPolicyInstanceRequest
         * @return ModifyPolicyInstanceResponse
         */
        public async Task<ModifyPolicyInstanceResponse> ModifyPolicyInstanceAsync(string clusterId, string policyName, ModifyPolicyInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ModifyPolicyInstanceWithOptionsAsync(clusterId, policyName, request, headers, runtime);
        }

        /**
         * @summary You can call the OpenAckService operation to activate Container Service for Kubernetes (ACK).
         *
         * @description *   You can activate ACK by using Alibaba Cloud accounts.
         * *   To activate ACK by using RAM users, you need to grant the AdministratorAccess permission to the RAM users.
         *
         * @param request OpenAckServiceRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return OpenAckServiceResponse
         */
        public OpenAckServiceResponse OpenAckServiceWithOptions(OpenAckServiceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["type"] = request.Type;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "OpenAckService",
                Version = "2015-12-15",
                Protocol = "HTTPS",
                Pathname = "/service/open",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<OpenAckServiceResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary You can call the OpenAckService operation to activate Container Service for Kubernetes (ACK).
         *
         * @description *   You can activate ACK by using Alibaba Cloud accounts.
         * *   To activate ACK by using RAM users, you need to grant the AdministratorAccess permission to the RAM users.
         *
         * @param request OpenAckServiceRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return OpenAckServiceResponse
         */
        public async Task<OpenAckServiceResponse> OpenAckServiceWithOptionsAsync(OpenAckServiceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["type"] = request.Type;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "OpenAckService",
                Version = "2015-12-15",
                Protocol = "HTTPS",
                Pathname = "/service/open",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<OpenAckServiceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary You can call the OpenAckService operation to activate Container Service for Kubernetes (ACK).
         *
         * @description *   You can activate ACK by using Alibaba Cloud accounts.
         * *   To activate ACK by using RAM users, you need to grant the AdministratorAccess permission to the RAM users.
         *
         * @param request OpenAckServiceRequest
         * @return OpenAckServiceResponse
         */
        public OpenAckServiceResponse OpenAckService(OpenAckServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return OpenAckServiceWithOptions(request, headers, runtime);
        }

        /**
         * @summary You can call the OpenAckService operation to activate Container Service for Kubernetes (ACK).
         *
         * @description *   You can activate ACK by using Alibaba Cloud accounts.
         * *   To activate ACK by using RAM users, you need to grant the AdministratorAccess permission to the RAM users.
         *
         * @param request OpenAckServiceRequest
         * @return OpenAckServiceResponse
         */
        public async Task<OpenAckServiceResponse> OpenAckServiceAsync(OpenAckServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await OpenAckServiceWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @deprecated OpenAPI PauseClusterUpgrade is deprecated
         *
         * @summary You can call the PauseClusterUpgrade operation to pause the update of a Container Service for Kubernetes (ACK) cluster.
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return PauseClusterUpgradeResponse
         */
        // Deprecated
        public PauseClusterUpgradeResponse PauseClusterUpgradeWithOptions(string ClusterId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PauseClusterUpgrade",
                Version = "2015-12-15",
                Protocol = "HTTPS",
                Pathname = "/api/v2/clusters/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId) + "/upgrade/pause",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<PauseClusterUpgradeResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @deprecated OpenAPI PauseClusterUpgrade is deprecated
         *
         * @summary You can call the PauseClusterUpgrade operation to pause the update of a Container Service for Kubernetes (ACK) cluster.
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return PauseClusterUpgradeResponse
         */
        // Deprecated
        public async Task<PauseClusterUpgradeResponse> PauseClusterUpgradeWithOptionsAsync(string ClusterId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PauseClusterUpgrade",
                Version = "2015-12-15",
                Protocol = "HTTPS",
                Pathname = "/api/v2/clusters/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId) + "/upgrade/pause",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<PauseClusterUpgradeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @deprecated OpenAPI PauseClusterUpgrade is deprecated
         *
         * @summary You can call the PauseClusterUpgrade operation to pause the update of a Container Service for Kubernetes (ACK) cluster.
         *
         * @return PauseClusterUpgradeResponse
         */
        // Deprecated
        public PauseClusterUpgradeResponse PauseClusterUpgrade(string ClusterId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return PauseClusterUpgradeWithOptions(ClusterId, headers, runtime);
        }

        /**
         * @deprecated OpenAPI PauseClusterUpgrade is deprecated
         *
         * @summary You can call the PauseClusterUpgrade operation to pause the update of a Container Service for Kubernetes (ACK) cluster.
         *
         * @return PauseClusterUpgradeResponse
         */
        // Deprecated
        public async Task<PauseClusterUpgradeResponse> PauseClusterUpgradeAsync(string ClusterId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await PauseClusterUpgradeWithOptionsAsync(ClusterId, headers, runtime);
        }

        /**
         * @deprecated OpenAPI PauseComponentUpgrade is deprecated
         *
         * @summary You can call the PauseComponentUpgrade operation to pause the update of a component.
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return PauseComponentUpgradeResponse
         */
        // Deprecated
        public PauseComponentUpgradeResponse PauseComponentUpgradeWithOptions(string clusterid, string componentid, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PauseComponentUpgrade",
                Version = "2015-12-15",
                Protocol = "HTTPS",
                Pathname = "/clusters/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(clusterid) + "/components/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(componentid) + "/pause",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<PauseComponentUpgradeResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @deprecated OpenAPI PauseComponentUpgrade is deprecated
         *
         * @summary You can call the PauseComponentUpgrade operation to pause the update of a component.
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return PauseComponentUpgradeResponse
         */
        // Deprecated
        public async Task<PauseComponentUpgradeResponse> PauseComponentUpgradeWithOptionsAsync(string clusterid, string componentid, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PauseComponentUpgrade",
                Version = "2015-12-15",
                Protocol = "HTTPS",
                Pathname = "/clusters/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(clusterid) + "/components/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(componentid) + "/pause",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<PauseComponentUpgradeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @deprecated OpenAPI PauseComponentUpgrade is deprecated
         *
         * @summary You can call the PauseComponentUpgrade operation to pause the update of a component.
         *
         * @return PauseComponentUpgradeResponse
         */
        // Deprecated
        public PauseComponentUpgradeResponse PauseComponentUpgrade(string clusterid, string componentid)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return PauseComponentUpgradeWithOptions(clusterid, componentid, headers, runtime);
        }

        /**
         * @deprecated OpenAPI PauseComponentUpgrade is deprecated
         *
         * @summary You can call the PauseComponentUpgrade operation to pause the update of a component.
         *
         * @return PauseComponentUpgradeResponse
         */
        // Deprecated
        public async Task<PauseComponentUpgradeResponse> PauseComponentUpgradeAsync(string clusterid, string componentid)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await PauseComponentUpgradeWithOptionsAsync(clusterid, componentid, headers, runtime);
        }

        /**
         * @summary Pauses an on-going task.
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return PauseTaskResponse
         */
        public PauseTaskResponse PauseTaskWithOptions(string taskId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PauseTask",
                Version = "2015-12-15",
                Protocol = "HTTPS",
                Pathname = "/tasks/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(taskId) + "/pause",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<PauseTaskResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Pauses an on-going task.
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return PauseTaskResponse
         */
        public async Task<PauseTaskResponse> PauseTaskWithOptionsAsync(string taskId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PauseTask",
                Version = "2015-12-15",
                Protocol = "HTTPS",
                Pathname = "/tasks/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(taskId) + "/pause",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<PauseTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Pauses an on-going task.
         *
         * @return PauseTaskResponse
         */
        public PauseTaskResponse PauseTask(string taskId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return PauseTaskWithOptions(taskId, headers, runtime);
        }

        /**
         * @summary Pauses an on-going task.
         *
         * @return PauseTaskResponse
         */
        public async Task<PauseTaskResponse> PauseTaskAsync(string taskId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await PauseTaskWithOptionsAsync(taskId, headers, runtime);
        }

        /**
         * @deprecated OpenAPI RemoveClusterNodes is deprecated
         *
         * @summary You can call the RemoveClusterNodes operation to remove nodes from a Container Service for Kubernetes (ACK) cluster.
         *
         * @description ****
         * *   When you remove a node, the pods that run on the node are migrated to other nodes. This may cause service interruptions. We recommend that you remove nodes during off-peak hours.
         * *   Unknown errors may occur when you remove nodes. Before you remove nodes, back up the data on the nodes.
         * *   Nodes remain in the Unschedulable state when they are being removed.
         * *   You can remove only worker nodes. You cannot remove master nodes.
         *
         * @param request RemoveClusterNodesRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return RemoveClusterNodesResponse
         */
        // Deprecated
        public RemoveClusterNodesResponse RemoveClusterNodesWithOptions(string ClusterId, RemoveClusterNodesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DrainNode))
            {
                body["drain_node"] = request.DrainNode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Nodes))
            {
                body["nodes"] = request.Nodes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReleaseNode))
            {
                body["release_node"] = request.ReleaseNode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RemoveClusterNodes",
                Version = "2015-12-15",
                Protocol = "HTTPS",
                Pathname = "/api/v2/clusters/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId) + "/nodes/remove",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<RemoveClusterNodesResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @deprecated OpenAPI RemoveClusterNodes is deprecated
         *
         * @summary You can call the RemoveClusterNodes operation to remove nodes from a Container Service for Kubernetes (ACK) cluster.
         *
         * @description ****
         * *   When you remove a node, the pods that run on the node are migrated to other nodes. This may cause service interruptions. We recommend that you remove nodes during off-peak hours.
         * *   Unknown errors may occur when you remove nodes. Before you remove nodes, back up the data on the nodes.
         * *   Nodes remain in the Unschedulable state when they are being removed.
         * *   You can remove only worker nodes. You cannot remove master nodes.
         *
         * @param request RemoveClusterNodesRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return RemoveClusterNodesResponse
         */
        // Deprecated
        public async Task<RemoveClusterNodesResponse> RemoveClusterNodesWithOptionsAsync(string ClusterId, RemoveClusterNodesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DrainNode))
            {
                body["drain_node"] = request.DrainNode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Nodes))
            {
                body["nodes"] = request.Nodes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReleaseNode))
            {
                body["release_node"] = request.ReleaseNode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RemoveClusterNodes",
                Version = "2015-12-15",
                Protocol = "HTTPS",
                Pathname = "/api/v2/clusters/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId) + "/nodes/remove",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<RemoveClusterNodesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @deprecated OpenAPI RemoveClusterNodes is deprecated
         *
         * @summary You can call the RemoveClusterNodes operation to remove nodes from a Container Service for Kubernetes (ACK) cluster.
         *
         * @description ****
         * *   When you remove a node, the pods that run on the node are migrated to other nodes. This may cause service interruptions. We recommend that you remove nodes during off-peak hours.
         * *   Unknown errors may occur when you remove nodes. Before you remove nodes, back up the data on the nodes.
         * *   Nodes remain in the Unschedulable state when they are being removed.
         * *   You can remove only worker nodes. You cannot remove master nodes.
         *
         * @param request RemoveClusterNodesRequest
         * @return RemoveClusterNodesResponse
         */
        // Deprecated
        public RemoveClusterNodesResponse RemoveClusterNodes(string ClusterId, RemoveClusterNodesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return RemoveClusterNodesWithOptions(ClusterId, request, headers, runtime);
        }

        /**
         * @deprecated OpenAPI RemoveClusterNodes is deprecated
         *
         * @summary You can call the RemoveClusterNodes operation to remove nodes from a Container Service for Kubernetes (ACK) cluster.
         *
         * @description ****
         * *   When you remove a node, the pods that run on the node are migrated to other nodes. This may cause service interruptions. We recommend that you remove nodes during off-peak hours.
         * *   Unknown errors may occur when you remove nodes. Before you remove nodes, back up the data on the nodes.
         * *   Nodes remain in the Unschedulable state when they are being removed.
         * *   You can remove only worker nodes. You cannot remove master nodes.
         *
         * @param request RemoveClusterNodesRequest
         * @return RemoveClusterNodesResponse
         */
        // Deprecated
        public async Task<RemoveClusterNodesResponse> RemoveClusterNodesAsync(string ClusterId, RemoveClusterNodesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await RemoveClusterNodesWithOptionsAsync(ClusterId, request, headers, runtime);
        }

        /**
         * @summary Removes nodes from a node pool.
         *
         * @description **
         * ****
         * *   When you remove a node, the pods that run on the node are migrated to other nodes. This may cause service interruptions. We recommend that you remove nodes during off-peak hours. - The operation may have unexpected risks. Back up the data before you perform this operation. - When the system removes a node, it sets the status of the node to Unschedulable. - The system removes only worker nodes. It does not remove master nodes.
         *
         * @param tmpReq RemoveNodePoolNodesRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return RemoveNodePoolNodesResponse
         */
        public RemoveNodePoolNodesResponse RemoveNodePoolNodesWithOptions(string ClusterId, string NodepoolId, RemoveNodePoolNodesRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            RemoveNodePoolNodesShrinkRequest request = new RemoveNodePoolNodesShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.InstanceIds))
            {
                request.InstanceIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.InstanceIds, "instance_ids", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Nodes))
            {
                request.NodesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Nodes, "nodes", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Concurrency))
            {
                query["concurrency"] = request.Concurrency;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DrainNode))
            {
                query["drain_node"] = request.DrainNode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceIdsShrink))
            {
                query["instance_ids"] = request.InstanceIdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodesShrink))
            {
                query["nodes"] = request.NodesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReleaseNode))
            {
                query["release_node"] = request.ReleaseNode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RemoveNodePoolNodes",
                Version = "2015-12-15",
                Protocol = "HTTPS",
                Pathname = "/clusters/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId) + "/nodepools/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(NodepoolId) + "/nodes",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RemoveNodePoolNodesResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Removes nodes from a node pool.
         *
         * @description **
         * ****
         * *   When you remove a node, the pods that run on the node are migrated to other nodes. This may cause service interruptions. We recommend that you remove nodes during off-peak hours. - The operation may have unexpected risks. Back up the data before you perform this operation. - When the system removes a node, it sets the status of the node to Unschedulable. - The system removes only worker nodes. It does not remove master nodes.
         *
         * @param tmpReq RemoveNodePoolNodesRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return RemoveNodePoolNodesResponse
         */
        public async Task<RemoveNodePoolNodesResponse> RemoveNodePoolNodesWithOptionsAsync(string ClusterId, string NodepoolId, RemoveNodePoolNodesRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            RemoveNodePoolNodesShrinkRequest request = new RemoveNodePoolNodesShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.InstanceIds))
            {
                request.InstanceIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.InstanceIds, "instance_ids", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Nodes))
            {
                request.NodesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Nodes, "nodes", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Concurrency))
            {
                query["concurrency"] = request.Concurrency;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DrainNode))
            {
                query["drain_node"] = request.DrainNode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceIdsShrink))
            {
                query["instance_ids"] = request.InstanceIdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodesShrink))
            {
                query["nodes"] = request.NodesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReleaseNode))
            {
                query["release_node"] = request.ReleaseNode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RemoveNodePoolNodes",
                Version = "2015-12-15",
                Protocol = "HTTPS",
                Pathname = "/clusters/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId) + "/nodepools/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(NodepoolId) + "/nodes",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RemoveNodePoolNodesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Removes nodes from a node pool.
         *
         * @description **
         * ****
         * *   When you remove a node, the pods that run on the node are migrated to other nodes. This may cause service interruptions. We recommend that you remove nodes during off-peak hours. - The operation may have unexpected risks. Back up the data before you perform this operation. - When the system removes a node, it sets the status of the node to Unschedulable. - The system removes only worker nodes. It does not remove master nodes.
         *
         * @param request RemoveNodePoolNodesRequest
         * @return RemoveNodePoolNodesResponse
         */
        public RemoveNodePoolNodesResponse RemoveNodePoolNodes(string ClusterId, string NodepoolId, RemoveNodePoolNodesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return RemoveNodePoolNodesWithOptions(ClusterId, NodepoolId, request, headers, runtime);
        }

        /**
         * @summary Removes nodes from a node pool.
         *
         * @description **
         * ****
         * *   When you remove a node, the pods that run on the node are migrated to other nodes. This may cause service interruptions. We recommend that you remove nodes during off-peak hours. - The operation may have unexpected risks. Back up the data before you perform this operation. - When the system removes a node, it sets the status of the node to Unschedulable. - The system removes only worker nodes. It does not remove master nodes.
         *
         * @param request RemoveNodePoolNodesRequest
         * @return RemoveNodePoolNodesResponse
         */
        public async Task<RemoveNodePoolNodesResponse> RemoveNodePoolNodesAsync(string ClusterId, string NodepoolId, RemoveNodePoolNodesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await RemoveNodePoolNodesWithOptionsAsync(ClusterId, NodepoolId, request, headers, runtime);
        }

        /**
         * @deprecated OpenAPI RemoveWorkflow is deprecated
         *
         * @summary You can call the RemoveWorkflow operation to delete a workflow.
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return RemoveWorkflowResponse
         */
        // Deprecated
        public RemoveWorkflowResponse RemoveWorkflowWithOptions(string workflowName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RemoveWorkflow",
                Version = "2015-12-15",
                Protocol = "HTTPS",
                Pathname = "/gs/workflow/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workflowName),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<RemoveWorkflowResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @deprecated OpenAPI RemoveWorkflow is deprecated
         *
         * @summary You can call the RemoveWorkflow operation to delete a workflow.
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return RemoveWorkflowResponse
         */
        // Deprecated
        public async Task<RemoveWorkflowResponse> RemoveWorkflowWithOptionsAsync(string workflowName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RemoveWorkflow",
                Version = "2015-12-15",
                Protocol = "HTTPS",
                Pathname = "/gs/workflow/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workflowName),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<RemoveWorkflowResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @deprecated OpenAPI RemoveWorkflow is deprecated
         *
         * @summary You can call the RemoveWorkflow operation to delete a workflow.
         *
         * @return RemoveWorkflowResponse
         */
        // Deprecated
        public RemoveWorkflowResponse RemoveWorkflow(string workflowName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return RemoveWorkflowWithOptions(workflowName, headers, runtime);
        }

        /**
         * @deprecated OpenAPI RemoveWorkflow is deprecated
         *
         * @summary You can call the RemoveWorkflow operation to delete a workflow.
         *
         * @return RemoveWorkflowResponse
         */
        // Deprecated
        public async Task<RemoveWorkflowResponse> RemoveWorkflowAsync(string workflowName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await RemoveWorkflowWithOptionsAsync(workflowName, headers, runtime);
        }

        /**
         * @summary You can call the RepairClusterNodePool operation to fix issues on specified nodes in a managed node pool.
         *
         * @param request RepairClusterNodePoolRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return RepairClusterNodePoolResponse
         */
        public RepairClusterNodePoolResponse RepairClusterNodePoolWithOptions(string clusterId, string nodepoolId, RepairClusterNodePoolRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoRestart))
            {
                body["auto_restart"] = request.AutoRestart;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Nodes))
            {
                body["nodes"] = request.Nodes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Operations))
            {
                body["operations"] = request.Operations;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RepairClusterNodePool",
                Version = "2015-12-15",
                Protocol = "HTTPS",
                Pathname = "/clusters/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(clusterId) + "/nodepools/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(nodepoolId) + "/repair",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RepairClusterNodePoolResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary You can call the RepairClusterNodePool operation to fix issues on specified nodes in a managed node pool.
         *
         * @param request RepairClusterNodePoolRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return RepairClusterNodePoolResponse
         */
        public async Task<RepairClusterNodePoolResponse> RepairClusterNodePoolWithOptionsAsync(string clusterId, string nodepoolId, RepairClusterNodePoolRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoRestart))
            {
                body["auto_restart"] = request.AutoRestart;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Nodes))
            {
                body["nodes"] = request.Nodes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Operations))
            {
                body["operations"] = request.Operations;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RepairClusterNodePool",
                Version = "2015-12-15",
                Protocol = "HTTPS",
                Pathname = "/clusters/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(clusterId) + "/nodepools/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(nodepoolId) + "/repair",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RepairClusterNodePoolResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary You can call the RepairClusterNodePool operation to fix issues on specified nodes in a managed node pool.
         *
         * @param request RepairClusterNodePoolRequest
         * @return RepairClusterNodePoolResponse
         */
        public RepairClusterNodePoolResponse RepairClusterNodePool(string clusterId, string nodepoolId, RepairClusterNodePoolRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return RepairClusterNodePoolWithOptions(clusterId, nodepoolId, request, headers, runtime);
        }

        /**
         * @summary You can call the RepairClusterNodePool operation to fix issues on specified nodes in a managed node pool.
         *
         * @param request RepairClusterNodePoolRequest
         * @return RepairClusterNodePoolResponse
         */
        public async Task<RepairClusterNodePoolResponse> RepairClusterNodePoolAsync(string clusterId, string nodepoolId, RepairClusterNodePoolRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await RepairClusterNodePoolWithOptionsAsync(clusterId, nodepoolId, request, headers, runtime);
        }

        /**
         * @deprecated OpenAPI ResumeComponentUpgrade is deprecated
         *
         * @summary You can call the ResumeComponentUpgrade operation to resume the update of a component.
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ResumeComponentUpgradeResponse
         */
        // Deprecated
        public ResumeComponentUpgradeResponse ResumeComponentUpgradeWithOptions(string clusterid, string componentid, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ResumeComponentUpgrade",
                Version = "2015-12-15",
                Protocol = "HTTPS",
                Pathname = "/clusters/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(clusterid) + "/components/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(componentid) + "/resume",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<ResumeComponentUpgradeResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @deprecated OpenAPI ResumeComponentUpgrade is deprecated
         *
         * @summary You can call the ResumeComponentUpgrade operation to resume the update of a component.
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ResumeComponentUpgradeResponse
         */
        // Deprecated
        public async Task<ResumeComponentUpgradeResponse> ResumeComponentUpgradeWithOptionsAsync(string clusterid, string componentid, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ResumeComponentUpgrade",
                Version = "2015-12-15",
                Protocol = "HTTPS",
                Pathname = "/clusters/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(clusterid) + "/components/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(componentid) + "/resume",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<ResumeComponentUpgradeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @deprecated OpenAPI ResumeComponentUpgrade is deprecated
         *
         * @summary You can call the ResumeComponentUpgrade operation to resume the update of a component.
         *
         * @return ResumeComponentUpgradeResponse
         */
        // Deprecated
        public ResumeComponentUpgradeResponse ResumeComponentUpgrade(string clusterid, string componentid)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ResumeComponentUpgradeWithOptions(clusterid, componentid, headers, runtime);
        }

        /**
         * @deprecated OpenAPI ResumeComponentUpgrade is deprecated
         *
         * @summary You can call the ResumeComponentUpgrade operation to resume the update of a component.
         *
         * @return ResumeComponentUpgradeResponse
         */
        // Deprecated
        public async Task<ResumeComponentUpgradeResponse> ResumeComponentUpgradeAsync(string clusterid, string componentid)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ResumeComponentUpgradeWithOptionsAsync(clusterid, componentid, headers, runtime);
        }

        /**
         * @summary You can call the ResumeTask operation to resume a task.
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ResumeTaskResponse
         */
        public ResumeTaskResponse ResumeTaskWithOptions(string taskId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ResumeTask",
                Version = "2015-12-15",
                Protocol = "HTTPS",
                Pathname = "/tasks/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(taskId) + "/resume",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<ResumeTaskResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary You can call the ResumeTask operation to resume a task.
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ResumeTaskResponse
         */
        public async Task<ResumeTaskResponse> ResumeTaskWithOptionsAsync(string taskId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ResumeTask",
                Version = "2015-12-15",
                Protocol = "HTTPS",
                Pathname = "/tasks/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(taskId) + "/resume",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<ResumeTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary You can call the ResumeTask operation to resume a task.
         *
         * @return ResumeTaskResponse
         */
        public ResumeTaskResponse ResumeTask(string taskId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ResumeTaskWithOptions(taskId, headers, runtime);
        }

        /**
         * @summary You can call the ResumeTask operation to resume a task.
         *
         * @return ResumeTaskResponse
         */
        public async Task<ResumeTaskResponse> ResumeTaskAsync(string taskId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ResumeTaskWithOptionsAsync(taskId, headers, runtime);
        }

        /**
         * @deprecated OpenAPI ResumeUpgradeCluster is deprecated
         *
         * @summary You can call the ResumeUpgradeCluster operation to resume the update of a cluster by cluster ID.
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ResumeUpgradeClusterResponse
         */
        // Deprecated
        public ResumeUpgradeClusterResponse ResumeUpgradeClusterWithOptions(string ClusterId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ResumeUpgradeCluster",
                Version = "2015-12-15",
                Protocol = "HTTPS",
                Pathname = "/api/v2/clusters/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId) + "/upgrade/resume",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<ResumeUpgradeClusterResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @deprecated OpenAPI ResumeUpgradeCluster is deprecated
         *
         * @summary You can call the ResumeUpgradeCluster operation to resume the update of a cluster by cluster ID.
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ResumeUpgradeClusterResponse
         */
        // Deprecated
        public async Task<ResumeUpgradeClusterResponse> ResumeUpgradeClusterWithOptionsAsync(string ClusterId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ResumeUpgradeCluster",
                Version = "2015-12-15",
                Protocol = "HTTPS",
                Pathname = "/api/v2/clusters/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId) + "/upgrade/resume",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<ResumeUpgradeClusterResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @deprecated OpenAPI ResumeUpgradeCluster is deprecated
         *
         * @summary You can call the ResumeUpgradeCluster operation to resume the update of a cluster by cluster ID.
         *
         * @return ResumeUpgradeClusterResponse
         */
        // Deprecated
        public ResumeUpgradeClusterResponse ResumeUpgradeCluster(string ClusterId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ResumeUpgradeClusterWithOptions(ClusterId, headers, runtime);
        }

        /**
         * @deprecated OpenAPI ResumeUpgradeCluster is deprecated
         *
         * @summary You can call the ResumeUpgradeCluster operation to resume the update of a cluster by cluster ID.
         *
         * @return ResumeUpgradeClusterResponse
         */
        // Deprecated
        public async Task<ResumeUpgradeClusterResponse> ResumeUpgradeClusterAsync(string ClusterId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ResumeUpgradeClusterWithOptionsAsync(ClusterId, headers, runtime);
        }

        /**
         * @summary You can call the RevokeK8sClusterKubeConfig operation to revoke the kubeconfig file that the current Resource Access Management (RAM) user uses to log on to a Kubernetes cluster. The kubeconfig file contains the identity information of the RAM user.
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return RevokeK8sClusterKubeConfigResponse
         */
        public RevokeK8sClusterKubeConfigResponse RevokeK8sClusterKubeConfigWithOptions(string ClusterId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RevokeK8sClusterKubeConfig",
                Version = "2015-12-15",
                Protocol = "HTTPS",
                Pathname = "/k8s/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId) + "/certs",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RevokeK8sClusterKubeConfigResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary You can call the RevokeK8sClusterKubeConfig operation to revoke the kubeconfig file that the current Resource Access Management (RAM) user uses to log on to a Kubernetes cluster. The kubeconfig file contains the identity information of the RAM user.
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return RevokeK8sClusterKubeConfigResponse
         */
        public async Task<RevokeK8sClusterKubeConfigResponse> RevokeK8sClusterKubeConfigWithOptionsAsync(string ClusterId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RevokeK8sClusterKubeConfig",
                Version = "2015-12-15",
                Protocol = "HTTPS",
                Pathname = "/k8s/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId) + "/certs",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RevokeK8sClusterKubeConfigResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary You can call the RevokeK8sClusterKubeConfig operation to revoke the kubeconfig file that the current Resource Access Management (RAM) user uses to log on to a Kubernetes cluster. The kubeconfig file contains the identity information of the RAM user.
         *
         * @return RevokeK8sClusterKubeConfigResponse
         */
        public RevokeK8sClusterKubeConfigResponse RevokeK8sClusterKubeConfig(string ClusterId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return RevokeK8sClusterKubeConfigWithOptions(ClusterId, headers, runtime);
        }

        /**
         * @summary You can call the RevokeK8sClusterKubeConfig operation to revoke the kubeconfig file that the current Resource Access Management (RAM) user uses to log on to a Kubernetes cluster. The kubeconfig file contains the identity information of the RAM user.
         *
         * @return RevokeK8sClusterKubeConfigResponse
         */
        public async Task<RevokeK8sClusterKubeConfigResponse> RevokeK8sClusterKubeConfigAsync(string ClusterId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await RevokeK8sClusterKubeConfigWithOptionsAsync(ClusterId, headers, runtime);
        }

        /**
         * @summary Initiates cluster checks such as cluster update checks.
         *
         * @param request RunClusterCheckRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return RunClusterCheckResponse
         */
        public RunClusterCheckResponse RunClusterCheckWithOptions(string clusterId, RunClusterCheckRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Options))
            {
                body["options"] = request.Options;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Target))
            {
                body["target"] = request.Target;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                body["type"] = request.Type;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RunClusterCheck",
                Version = "2015-12-15",
                Protocol = "HTTPS",
                Pathname = "/clusters/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(clusterId) + "/checks",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RunClusterCheckResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Initiates cluster checks such as cluster update checks.
         *
         * @param request RunClusterCheckRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return RunClusterCheckResponse
         */
        public async Task<RunClusterCheckResponse> RunClusterCheckWithOptionsAsync(string clusterId, RunClusterCheckRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Options))
            {
                body["options"] = request.Options;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Target))
            {
                body["target"] = request.Target;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                body["type"] = request.Type;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RunClusterCheck",
                Version = "2015-12-15",
                Protocol = "HTTPS",
                Pathname = "/clusters/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(clusterId) + "/checks",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RunClusterCheckResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Initiates cluster checks such as cluster update checks.
         *
         * @param request RunClusterCheckRequest
         * @return RunClusterCheckResponse
         */
        public RunClusterCheckResponse RunClusterCheck(string clusterId, RunClusterCheckRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return RunClusterCheckWithOptions(clusterId, request, headers, runtime);
        }

        /**
         * @summary Initiates cluster checks such as cluster update checks.
         *
         * @param request RunClusterCheckRequest
         * @return RunClusterCheckResponse
         */
        public async Task<RunClusterCheckResponse> RunClusterCheckAsync(string clusterId, RunClusterCheckRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await RunClusterCheckWithOptionsAsync(clusterId, request, headers, runtime);
        }

        /**
         * @deprecated OpenAPI ScaleCluster is deprecated
         *
         * @summary 扩容Kubernetes集群
         *
         * @param request ScaleClusterRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ScaleClusterResponse
         */
        // Deprecated
        public ScaleClusterResponse ScaleClusterWithOptions(string ClusterId, ScaleClusterRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CloudMonitorFlags))
            {
                body["cloud_monitor_flags"] = request.CloudMonitorFlags;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Count))
            {
                body["count"] = request.Count;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CpuPolicy))
            {
                body["cpu_policy"] = request.CpuPolicy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisableRollback))
            {
                body["disable_rollback"] = request.DisableRollback;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeyPair))
            {
                body["key_pair"] = request.KeyPair;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoginPassword))
            {
                body["login_password"] = request.LoginPassword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tags))
            {
                body["tags"] = request.Tags;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Taints))
            {
                body["taints"] = request.Taints;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VswitchIds))
            {
                body["vswitch_ids"] = request.VswitchIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkerAutoRenew))
            {
                body["worker_auto_renew"] = request.WorkerAutoRenew;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkerAutoRenewPeriod))
            {
                body["worker_auto_renew_period"] = request.WorkerAutoRenewPeriod;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkerDataDisk))
            {
                body["worker_data_disk"] = request.WorkerDataDisk;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkerDataDisks))
            {
                body["worker_data_disks"] = request.WorkerDataDisks;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkerInstanceChargeType))
            {
                body["worker_instance_charge_type"] = request.WorkerInstanceChargeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkerInstanceTypes))
            {
                body["worker_instance_types"] = request.WorkerInstanceTypes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkerPeriod))
            {
                body["worker_period"] = request.WorkerPeriod;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkerPeriodUnit))
            {
                body["worker_period_unit"] = request.WorkerPeriodUnit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkerSystemDiskCategory))
            {
                body["worker_system_disk_category"] = request.WorkerSystemDiskCategory;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkerSystemDiskSize))
            {
                body["worker_system_disk_size"] = request.WorkerSystemDiskSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ScaleCluster",
                Version = "2015-12-15",
                Protocol = "HTTPS",
                Pathname = "/clusters/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ScaleClusterResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @deprecated OpenAPI ScaleCluster is deprecated
         *
         * @summary 扩容Kubernetes集群
         *
         * @param request ScaleClusterRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ScaleClusterResponse
         */
        // Deprecated
        public async Task<ScaleClusterResponse> ScaleClusterWithOptionsAsync(string ClusterId, ScaleClusterRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CloudMonitorFlags))
            {
                body["cloud_monitor_flags"] = request.CloudMonitorFlags;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Count))
            {
                body["count"] = request.Count;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CpuPolicy))
            {
                body["cpu_policy"] = request.CpuPolicy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisableRollback))
            {
                body["disable_rollback"] = request.DisableRollback;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeyPair))
            {
                body["key_pair"] = request.KeyPair;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoginPassword))
            {
                body["login_password"] = request.LoginPassword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tags))
            {
                body["tags"] = request.Tags;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Taints))
            {
                body["taints"] = request.Taints;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VswitchIds))
            {
                body["vswitch_ids"] = request.VswitchIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkerAutoRenew))
            {
                body["worker_auto_renew"] = request.WorkerAutoRenew;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkerAutoRenewPeriod))
            {
                body["worker_auto_renew_period"] = request.WorkerAutoRenewPeriod;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkerDataDisk))
            {
                body["worker_data_disk"] = request.WorkerDataDisk;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkerDataDisks))
            {
                body["worker_data_disks"] = request.WorkerDataDisks;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkerInstanceChargeType))
            {
                body["worker_instance_charge_type"] = request.WorkerInstanceChargeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkerInstanceTypes))
            {
                body["worker_instance_types"] = request.WorkerInstanceTypes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkerPeriod))
            {
                body["worker_period"] = request.WorkerPeriod;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkerPeriodUnit))
            {
                body["worker_period_unit"] = request.WorkerPeriodUnit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkerSystemDiskCategory))
            {
                body["worker_system_disk_category"] = request.WorkerSystemDiskCategory;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkerSystemDiskSize))
            {
                body["worker_system_disk_size"] = request.WorkerSystemDiskSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ScaleCluster",
                Version = "2015-12-15",
                Protocol = "HTTPS",
                Pathname = "/clusters/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ScaleClusterResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @deprecated OpenAPI ScaleCluster is deprecated
         *
         * @summary 扩容Kubernetes集群
         *
         * @param request ScaleClusterRequest
         * @return ScaleClusterResponse
         */
        // Deprecated
        public ScaleClusterResponse ScaleCluster(string ClusterId, ScaleClusterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ScaleClusterWithOptions(ClusterId, request, headers, runtime);
        }

        /**
         * @deprecated OpenAPI ScaleCluster is deprecated
         *
         * @summary 扩容Kubernetes集群
         *
         * @param request ScaleClusterRequest
         * @return ScaleClusterResponse
         */
        // Deprecated
        public async Task<ScaleClusterResponse> ScaleClusterAsync(string ClusterId, ScaleClusterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ScaleClusterWithOptionsAsync(ClusterId, request, headers, runtime);
        }

        /**
         * @summary You can call the ScaleClusterNodePool operation to scale out a node pool by node pool ID.
         *
         * @param request ScaleClusterNodePoolRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ScaleClusterNodePoolResponse
         */
        public ScaleClusterNodePoolResponse ScaleClusterNodePoolWithOptions(string ClusterId, string NodepoolId, ScaleClusterNodePoolRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Count))
            {
                body["count"] = request.Count;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ScaleClusterNodePool",
                Version = "2015-12-15",
                Protocol = "HTTPS",
                Pathname = "/clusters/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId) + "/nodepools/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(NodepoolId),
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ScaleClusterNodePoolResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary You can call the ScaleClusterNodePool operation to scale out a node pool by node pool ID.
         *
         * @param request ScaleClusterNodePoolRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ScaleClusterNodePoolResponse
         */
        public async Task<ScaleClusterNodePoolResponse> ScaleClusterNodePoolWithOptionsAsync(string ClusterId, string NodepoolId, ScaleClusterNodePoolRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Count))
            {
                body["count"] = request.Count;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ScaleClusterNodePool",
                Version = "2015-12-15",
                Protocol = "HTTPS",
                Pathname = "/clusters/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId) + "/nodepools/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(NodepoolId),
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ScaleClusterNodePoolResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary You can call the ScaleClusterNodePool operation to scale out a node pool by node pool ID.
         *
         * @param request ScaleClusterNodePoolRequest
         * @return ScaleClusterNodePoolResponse
         */
        public ScaleClusterNodePoolResponse ScaleClusterNodePool(string ClusterId, string NodepoolId, ScaleClusterNodePoolRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ScaleClusterNodePoolWithOptions(ClusterId, NodepoolId, request, headers, runtime);
        }

        /**
         * @summary You can call the ScaleClusterNodePool operation to scale out a node pool by node pool ID.
         *
         * @param request ScaleClusterNodePoolRequest
         * @return ScaleClusterNodePoolResponse
         */
        public async Task<ScaleClusterNodePoolResponse> ScaleClusterNodePoolAsync(string ClusterId, string NodepoolId, ScaleClusterNodePoolRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ScaleClusterNodePoolWithOptionsAsync(ClusterId, NodepoolId, request, headers, runtime);
        }

        /**
         * @summary You can call the ScaleOutCluster operation to scale out a cluster by cluster ID.
         *
         * @description **
         * ****The ScaleOutCluster API operation is phased out. You must call the node pool-related API operations to manage nodes. If you want to add worker nodes to a Container Service for Kubernetes (ACK) cluster, call the ScaleClusterNodePool API operation. For more information, see [ScaleClusterNodePool](https://help.aliyun.com/document_detail/184928.html).
         *
         * @param request ScaleOutClusterRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ScaleOutClusterResponse
         */
        public ScaleOutClusterResponse ScaleOutClusterWithOptions(string ClusterId, ScaleOutClusterRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CloudMonitorFlags))
            {
                body["cloud_monitor_flags"] = request.CloudMonitorFlags;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Count))
            {
                body["count"] = request.Count;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CpuPolicy))
            {
                body["cpu_policy"] = request.CpuPolicy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageId))
            {
                body["image_id"] = request.ImageId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeyPair))
            {
                body["key_pair"] = request.KeyPair;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoginPassword))
            {
                body["login_password"] = request.LoginPassword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RdsInstances))
            {
                body["rds_instances"] = request.RdsInstances;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Runtime))
            {
                body["runtime"] = request.Runtime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tags))
            {
                body["tags"] = request.Tags;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Taints))
            {
                body["taints"] = request.Taints;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserData))
            {
                body["user_data"] = request.UserData;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VswitchIds))
            {
                body["vswitch_ids"] = request.VswitchIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkerAutoRenew))
            {
                body["worker_auto_renew"] = request.WorkerAutoRenew;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkerAutoRenewPeriod))
            {
                body["worker_auto_renew_period"] = request.WorkerAutoRenewPeriod;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkerDataDisks))
            {
                body["worker_data_disks"] = request.WorkerDataDisks;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkerInstanceChargeType))
            {
                body["worker_instance_charge_type"] = request.WorkerInstanceChargeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkerInstanceTypes))
            {
                body["worker_instance_types"] = request.WorkerInstanceTypes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkerPeriod))
            {
                body["worker_period"] = request.WorkerPeriod;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkerPeriodUnit))
            {
                body["worker_period_unit"] = request.WorkerPeriodUnit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkerSystemDiskCategory))
            {
                body["worker_system_disk_category"] = request.WorkerSystemDiskCategory;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkerSystemDiskSize))
            {
                body["worker_system_disk_size"] = request.WorkerSystemDiskSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ScaleOutCluster",
                Version = "2015-12-15",
                Protocol = "HTTPS",
                Pathname = "/api/v2/clusters/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId),
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ScaleOutClusterResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary You can call the ScaleOutCluster operation to scale out a cluster by cluster ID.
         *
         * @description **
         * ****The ScaleOutCluster API operation is phased out. You must call the node pool-related API operations to manage nodes. If you want to add worker nodes to a Container Service for Kubernetes (ACK) cluster, call the ScaleClusterNodePool API operation. For more information, see [ScaleClusterNodePool](https://help.aliyun.com/document_detail/184928.html).
         *
         * @param request ScaleOutClusterRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ScaleOutClusterResponse
         */
        public async Task<ScaleOutClusterResponse> ScaleOutClusterWithOptionsAsync(string ClusterId, ScaleOutClusterRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CloudMonitorFlags))
            {
                body["cloud_monitor_flags"] = request.CloudMonitorFlags;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Count))
            {
                body["count"] = request.Count;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CpuPolicy))
            {
                body["cpu_policy"] = request.CpuPolicy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageId))
            {
                body["image_id"] = request.ImageId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeyPair))
            {
                body["key_pair"] = request.KeyPair;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LoginPassword))
            {
                body["login_password"] = request.LoginPassword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RdsInstances))
            {
                body["rds_instances"] = request.RdsInstances;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Runtime))
            {
                body["runtime"] = request.Runtime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tags))
            {
                body["tags"] = request.Tags;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Taints))
            {
                body["taints"] = request.Taints;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserData))
            {
                body["user_data"] = request.UserData;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VswitchIds))
            {
                body["vswitch_ids"] = request.VswitchIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkerAutoRenew))
            {
                body["worker_auto_renew"] = request.WorkerAutoRenew;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkerAutoRenewPeriod))
            {
                body["worker_auto_renew_period"] = request.WorkerAutoRenewPeriod;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkerDataDisks))
            {
                body["worker_data_disks"] = request.WorkerDataDisks;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkerInstanceChargeType))
            {
                body["worker_instance_charge_type"] = request.WorkerInstanceChargeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkerInstanceTypes))
            {
                body["worker_instance_types"] = request.WorkerInstanceTypes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkerPeriod))
            {
                body["worker_period"] = request.WorkerPeriod;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkerPeriodUnit))
            {
                body["worker_period_unit"] = request.WorkerPeriodUnit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkerSystemDiskCategory))
            {
                body["worker_system_disk_category"] = request.WorkerSystemDiskCategory;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkerSystemDiskSize))
            {
                body["worker_system_disk_size"] = request.WorkerSystemDiskSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ScaleOutCluster",
                Version = "2015-12-15",
                Protocol = "HTTPS",
                Pathname = "/api/v2/clusters/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId),
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ScaleOutClusterResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary You can call the ScaleOutCluster operation to scale out a cluster by cluster ID.
         *
         * @description **
         * ****The ScaleOutCluster API operation is phased out. You must call the node pool-related API operations to manage nodes. If you want to add worker nodes to a Container Service for Kubernetes (ACK) cluster, call the ScaleClusterNodePool API operation. For more information, see [ScaleClusterNodePool](https://help.aliyun.com/document_detail/184928.html).
         *
         * @param request ScaleOutClusterRequest
         * @return ScaleOutClusterResponse
         */
        public ScaleOutClusterResponse ScaleOutCluster(string ClusterId, ScaleOutClusterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ScaleOutClusterWithOptions(ClusterId, request, headers, runtime);
        }

        /**
         * @summary You can call the ScaleOutCluster operation to scale out a cluster by cluster ID.
         *
         * @description **
         * ****The ScaleOutCluster API operation is phased out. You must call the node pool-related API operations to manage nodes. If you want to add worker nodes to a Container Service for Kubernetes (ACK) cluster, call the ScaleClusterNodePool API operation. For more information, see [ScaleClusterNodePool](https://help.aliyun.com/document_detail/184928.html).
         *
         * @param request ScaleOutClusterRequest
         * @return ScaleOutClusterResponse
         */
        public async Task<ScaleOutClusterResponse> ScaleOutClusterAsync(string ClusterId, ScaleOutClusterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ScaleOutClusterWithOptionsAsync(ClusterId, request, headers, runtime);
        }

        /**
         * @summary The cluster ID.
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ScanClusterVulsResponse
         */
        public ScanClusterVulsResponse ScanClusterVulsWithOptions(string clusterId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ScanClusterVuls",
                Version = "2015-12-15",
                Protocol = "HTTPS",
                Pathname = "/clusters/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(clusterId) + "/vuls/scan",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ScanClusterVulsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary The cluster ID.
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ScanClusterVulsResponse
         */
        public async Task<ScanClusterVulsResponse> ScanClusterVulsWithOptionsAsync(string clusterId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ScanClusterVuls",
                Version = "2015-12-15",
                Protocol = "HTTPS",
                Pathname = "/clusters/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(clusterId) + "/vuls/scan",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ScanClusterVulsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary The cluster ID.
         *
         * @return ScanClusterVulsResponse
         */
        public ScanClusterVulsResponse ScanClusterVuls(string clusterId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ScanClusterVulsWithOptions(clusterId, headers, runtime);
        }

        /**
         * @summary The cluster ID.
         *
         * @return ScanClusterVulsResponse
         */
        public async Task<ScanClusterVulsResponse> ScanClusterVulsAsync(string clusterId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ScanClusterVulsWithOptionsAsync(clusterId, headers, runtime);
        }

        /**
         * @param request StartAlertRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return StartAlertResponse
         */
        public StartAlertResponse StartAlertWithOptions(string ClusterId, StartAlertRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlertRuleGroupName))
            {
                body["alert_rule_group_name"] = request.AlertRuleGroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlertRuleName))
            {
                body["alert_rule_name"] = request.AlertRuleName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StartAlert",
                Version = "2015-12-15",
                Protocol = "HTTPS",
                Pathname = "/alert/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId) + "/alert_rule/start",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<StartAlertResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @param request StartAlertRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return StartAlertResponse
         */
        public async Task<StartAlertResponse> StartAlertWithOptionsAsync(string ClusterId, StartAlertRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlertRuleGroupName))
            {
                body["alert_rule_group_name"] = request.AlertRuleGroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlertRuleName))
            {
                body["alert_rule_name"] = request.AlertRuleName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StartAlert",
                Version = "2015-12-15",
                Protocol = "HTTPS",
                Pathname = "/alert/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId) + "/alert_rule/start",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<StartAlertResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @param request StartAlertRequest
         * @return StartAlertResponse
         */
        public StartAlertResponse StartAlert(string ClusterId, StartAlertRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return StartAlertWithOptions(ClusterId, request, headers, runtime);
        }

        /**
         * @param request StartAlertRequest
         * @return StartAlertResponse
         */
        public async Task<StartAlertResponse> StartAlertAsync(string ClusterId, StartAlertRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await StartAlertWithOptionsAsync(ClusterId, request, headers, runtime);
        }

        /**
         * @deprecated OpenAPI StartWorkflow is deprecated
         *
         * @summary You can call the StartWorkflow operation to create a workflow.
         *
         * @param request StartWorkflowRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return StartWorkflowResponse
         */
        // Deprecated
        public StartWorkflowResponse StartWorkflowWithOptions(StartWorkflowRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MappingBamOutFilename))
            {
                body["mapping_bam_out_filename"] = request.MappingBamOutFilename;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MappingBamOutPath))
            {
                body["mapping_bam_out_path"] = request.MappingBamOutPath;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MappingBucketName))
            {
                body["mapping_bucket_name"] = request.MappingBucketName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MappingFastqFirstFilename))
            {
                body["mapping_fastq_first_filename"] = request.MappingFastqFirstFilename;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MappingFastqPath))
            {
                body["mapping_fastq_path"] = request.MappingFastqPath;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MappingFastqSecondFilename))
            {
                body["mapping_fastq_second_filename"] = request.MappingFastqSecondFilename;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MappingIsMarkDup))
            {
                body["mapping_is_mark_dup"] = request.MappingIsMarkDup;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MappingOssRegion))
            {
                body["mapping_oss_region"] = request.MappingOssRegion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MappingReferencePath))
            {
                body["mapping_reference_path"] = request.MappingReferencePath;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Service))
            {
                body["service"] = request.Service;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WgsBucketName))
            {
                body["wgs_bucket_name"] = request.WgsBucketName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WgsFastqFirstFilename))
            {
                body["wgs_fastq_first_filename"] = request.WgsFastqFirstFilename;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WgsFastqPath))
            {
                body["wgs_fastq_path"] = request.WgsFastqPath;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WgsFastqSecondFilename))
            {
                body["wgs_fastq_second_filename"] = request.WgsFastqSecondFilename;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WgsOssRegion))
            {
                body["wgs_oss_region"] = request.WgsOssRegion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WgsReferencePath))
            {
                body["wgs_reference_path"] = request.WgsReferencePath;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WgsVcfOutFilename))
            {
                body["wgs_vcf_out_filename"] = request.WgsVcfOutFilename;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WgsVcfOutPath))
            {
                body["wgs_vcf_out_path"] = request.WgsVcfOutPath;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkflowType))
            {
                body["workflow_type"] = request.WorkflowType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StartWorkflow",
                Version = "2015-12-15",
                Protocol = "HTTPS",
                Pathname = "/gs/workflow",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<StartWorkflowResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @deprecated OpenAPI StartWorkflow is deprecated
         *
         * @summary You can call the StartWorkflow operation to create a workflow.
         *
         * @param request StartWorkflowRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return StartWorkflowResponse
         */
        // Deprecated
        public async Task<StartWorkflowResponse> StartWorkflowWithOptionsAsync(StartWorkflowRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MappingBamOutFilename))
            {
                body["mapping_bam_out_filename"] = request.MappingBamOutFilename;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MappingBamOutPath))
            {
                body["mapping_bam_out_path"] = request.MappingBamOutPath;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MappingBucketName))
            {
                body["mapping_bucket_name"] = request.MappingBucketName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MappingFastqFirstFilename))
            {
                body["mapping_fastq_first_filename"] = request.MappingFastqFirstFilename;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MappingFastqPath))
            {
                body["mapping_fastq_path"] = request.MappingFastqPath;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MappingFastqSecondFilename))
            {
                body["mapping_fastq_second_filename"] = request.MappingFastqSecondFilename;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MappingIsMarkDup))
            {
                body["mapping_is_mark_dup"] = request.MappingIsMarkDup;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MappingOssRegion))
            {
                body["mapping_oss_region"] = request.MappingOssRegion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MappingReferencePath))
            {
                body["mapping_reference_path"] = request.MappingReferencePath;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Service))
            {
                body["service"] = request.Service;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WgsBucketName))
            {
                body["wgs_bucket_name"] = request.WgsBucketName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WgsFastqFirstFilename))
            {
                body["wgs_fastq_first_filename"] = request.WgsFastqFirstFilename;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WgsFastqPath))
            {
                body["wgs_fastq_path"] = request.WgsFastqPath;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WgsFastqSecondFilename))
            {
                body["wgs_fastq_second_filename"] = request.WgsFastqSecondFilename;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WgsOssRegion))
            {
                body["wgs_oss_region"] = request.WgsOssRegion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WgsReferencePath))
            {
                body["wgs_reference_path"] = request.WgsReferencePath;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WgsVcfOutFilename))
            {
                body["wgs_vcf_out_filename"] = request.WgsVcfOutFilename;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WgsVcfOutPath))
            {
                body["wgs_vcf_out_path"] = request.WgsVcfOutPath;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkflowType))
            {
                body["workflow_type"] = request.WorkflowType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StartWorkflow",
                Version = "2015-12-15",
                Protocol = "HTTPS",
                Pathname = "/gs/workflow",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<StartWorkflowResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @deprecated OpenAPI StartWorkflow is deprecated
         *
         * @summary You can call the StartWorkflow operation to create a workflow.
         *
         * @param request StartWorkflowRequest
         * @return StartWorkflowResponse
         */
        // Deprecated
        public StartWorkflowResponse StartWorkflow(StartWorkflowRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return StartWorkflowWithOptions(request, headers, runtime);
        }

        /**
         * @deprecated OpenAPI StartWorkflow is deprecated
         *
         * @summary You can call the StartWorkflow operation to create a workflow.
         *
         * @param request StartWorkflowRequest
         * @return StartWorkflowResponse
         */
        // Deprecated
        public async Task<StartWorkflowResponse> StartWorkflowAsync(StartWorkflowRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await StartWorkflowWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary You can call the StopAlert operation to disable an alert rule or an alert rule set in the alert center of Container Service for Kubernetes (ACK).
         *
         * @param request StopAlertRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return StopAlertResponse
         */
        public StopAlertResponse StopAlertWithOptions(string ClusterId, StopAlertRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlertRuleGroupName))
            {
                body["alert_rule_group_name"] = request.AlertRuleGroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlertRuleName))
            {
                body["alert_rule_name"] = request.AlertRuleName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StopAlert",
                Version = "2015-12-15",
                Protocol = "HTTPS",
                Pathname = "/alert/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId) + "/alert_rule/stop",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<StopAlertResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary You can call the StopAlert operation to disable an alert rule or an alert rule set in the alert center of Container Service for Kubernetes (ACK).
         *
         * @param request StopAlertRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return StopAlertResponse
         */
        public async Task<StopAlertResponse> StopAlertWithOptionsAsync(string ClusterId, StopAlertRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlertRuleGroupName))
            {
                body["alert_rule_group_name"] = request.AlertRuleGroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlertRuleName))
            {
                body["alert_rule_name"] = request.AlertRuleName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StopAlert",
                Version = "2015-12-15",
                Protocol = "HTTPS",
                Pathname = "/alert/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId) + "/alert_rule/stop",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<StopAlertResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary You can call the StopAlert operation to disable an alert rule or an alert rule set in the alert center of Container Service for Kubernetes (ACK).
         *
         * @param request StopAlertRequest
         * @return StopAlertResponse
         */
        public StopAlertResponse StopAlert(string ClusterId, StopAlertRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return StopAlertWithOptions(ClusterId, request, headers, runtime);
        }

        /**
         * @summary You can call the StopAlert operation to disable an alert rule or an alert rule set in the alert center of Container Service for Kubernetes (ACK).
         *
         * @param request StopAlertRequest
         * @return StopAlertResponse
         */
        public async Task<StopAlertResponse> StopAlertAsync(string ClusterId, StopAlertRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await StopAlertWithOptionsAsync(ClusterId, request, headers, runtime);
        }

        /**
         * @summary Synchronizes the information about a node pool, including the metadata and node information of the node pool.
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return SyncClusterNodePoolResponse
         */
        public SyncClusterNodePoolResponse SyncClusterNodePoolWithOptions(string ClusterId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SyncClusterNodePool",
                Version = "2015-12-15",
                Protocol = "HTTPS",
                Pathname = "/clusters/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId) + "/sync_nodepools",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<SyncClusterNodePoolResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Synchronizes the information about a node pool, including the metadata and node information of the node pool.
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return SyncClusterNodePoolResponse
         */
        public async Task<SyncClusterNodePoolResponse> SyncClusterNodePoolWithOptionsAsync(string ClusterId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SyncClusterNodePool",
                Version = "2015-12-15",
                Protocol = "HTTPS",
                Pathname = "/clusters/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId) + "/sync_nodepools",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<SyncClusterNodePoolResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Synchronizes the information about a node pool, including the metadata and node information of the node pool.
         *
         * @return SyncClusterNodePoolResponse
         */
        public SyncClusterNodePoolResponse SyncClusterNodePool(string ClusterId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return SyncClusterNodePoolWithOptions(ClusterId, headers, runtime);
        }

        /**
         * @summary Synchronizes the information about a node pool, including the metadata and node information of the node pool.
         *
         * @return SyncClusterNodePoolResponse
         */
        public async Task<SyncClusterNodePoolResponse> SyncClusterNodePoolAsync(string ClusterId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await SyncClusterNodePoolWithOptionsAsync(ClusterId, headers, runtime);
        }

        /**
         * @summary Adds labels to a Container Service for Kubernetes (ACK) cluster. You can use labels to classify and manage ACK clusters in order to meet monitoring, cost analysis, and tenant isolation requirements.
         *
         * @param request TagResourcesRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return TagResourcesResponse
         */
        public TagResourcesResponse TagResourcesWithOptions(TagResourcesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["region_id"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceIds))
            {
                body["resource_ids"] = request.ResourceIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                body["resource_type"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tags))
            {
                body["tags"] = request.Tags;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TagResources",
                Version = "2015-12-15",
                Protocol = "HTTPS",
                Pathname = "/tags",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<TagResourcesResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Adds labels to a Container Service for Kubernetes (ACK) cluster. You can use labels to classify and manage ACK clusters in order to meet monitoring, cost analysis, and tenant isolation requirements.
         *
         * @param request TagResourcesRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return TagResourcesResponse
         */
        public async Task<TagResourcesResponse> TagResourcesWithOptionsAsync(TagResourcesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["region_id"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceIds))
            {
                body["resource_ids"] = request.ResourceIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                body["resource_type"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tags))
            {
                body["tags"] = request.Tags;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TagResources",
                Version = "2015-12-15",
                Protocol = "HTTPS",
                Pathname = "/tags",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<TagResourcesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Adds labels to a Container Service for Kubernetes (ACK) cluster. You can use labels to classify and manage ACK clusters in order to meet monitoring, cost analysis, and tenant isolation requirements.
         *
         * @param request TagResourcesRequest
         * @return TagResourcesResponse
         */
        public TagResourcesResponse TagResources(TagResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return TagResourcesWithOptions(request, headers, runtime);
        }

        /**
         * @summary Adds labels to a Container Service for Kubernetes (ACK) cluster. You can use labels to classify and manage ACK clusters in order to meet monitoring, cost analysis, and tenant isolation requirements.
         *
         * @param request TagResourcesRequest
         * @return TagResourcesResponse
         */
        public async Task<TagResourcesResponse> TagResourcesAsync(TagResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await TagResourcesWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary Uninstalls components that you no longer need from a cluster. You must specify the name of the components and specify whether to release associated Alibaba Cloud resources from the cluster.
         *
         * @param request UnInstallClusterAddonsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UnInstallClusterAddonsResponse
         */
        public UnInstallClusterAddonsResponse UnInstallClusterAddonsWithOptions(string ClusterId, UnInstallClusterAddonsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.TeaUtil.Common.ToArray(request.Addons),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UnInstallClusterAddons",
                Version = "2015-12-15",
                Protocol = "HTTPS",
                Pathname = "/clusters/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId) + "/components/uninstall",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<UnInstallClusterAddonsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Uninstalls components that you no longer need from a cluster. You must specify the name of the components and specify whether to release associated Alibaba Cloud resources from the cluster.
         *
         * @param request UnInstallClusterAddonsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UnInstallClusterAddonsResponse
         */
        public async Task<UnInstallClusterAddonsResponse> UnInstallClusterAddonsWithOptionsAsync(string ClusterId, UnInstallClusterAddonsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.TeaUtil.Common.ToArray(request.Addons),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UnInstallClusterAddons",
                Version = "2015-12-15",
                Protocol = "HTTPS",
                Pathname = "/clusters/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId) + "/components/uninstall",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<UnInstallClusterAddonsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Uninstalls components that you no longer need from a cluster. You must specify the name of the components and specify whether to release associated Alibaba Cloud resources from the cluster.
         *
         * @param request UnInstallClusterAddonsRequest
         * @return UnInstallClusterAddonsResponse
         */
        public UnInstallClusterAddonsResponse UnInstallClusterAddons(string ClusterId, UnInstallClusterAddonsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UnInstallClusterAddonsWithOptions(ClusterId, request, headers, runtime);
        }

        /**
         * @summary Uninstalls components that you no longer need from a cluster. You must specify the name of the components and specify whether to release associated Alibaba Cloud resources from the cluster.
         *
         * @param request UnInstallClusterAddonsRequest
         * @return UnInstallClusterAddonsResponse
         */
        public async Task<UnInstallClusterAddonsResponse> UnInstallClusterAddonsAsync(string ClusterId, UnInstallClusterAddonsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UnInstallClusterAddonsWithOptionsAsync(ClusterId, request, headers, runtime);
        }

        /**
         * @summary Removes labels from a Container Service for Kubernetes (ACK) cluster.
         *
         * @param tmpReq UntagResourcesRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UntagResourcesResponse
         */
        public UntagResourcesResponse UntagResourcesWithOptions(UntagResourcesRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UntagResourcesShrinkRequest request = new UntagResourcesShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ResourceIds))
            {
                request.ResourceIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ResourceIds, "resource_ids", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TagKeys))
            {
                request.TagKeysShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TagKeys, "tag_keys", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.All))
            {
                query["all"] = request.All;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["region_id"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceIdsShrink))
            {
                query["resource_ids"] = request.ResourceIdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["resource_type"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagKeysShrink))
            {
                query["tag_keys"] = request.TagKeysShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UntagResources",
                Version = "2015-12-15",
                Protocol = "HTTPS",
                Pathname = "/tags",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UntagResourcesResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Removes labels from a Container Service for Kubernetes (ACK) cluster.
         *
         * @param tmpReq UntagResourcesRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UntagResourcesResponse
         */
        public async Task<UntagResourcesResponse> UntagResourcesWithOptionsAsync(UntagResourcesRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UntagResourcesShrinkRequest request = new UntagResourcesShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ResourceIds))
            {
                request.ResourceIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ResourceIds, "resource_ids", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TagKeys))
            {
                request.TagKeysShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TagKeys, "tag_keys", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.All))
            {
                query["all"] = request.All;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["region_id"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceIdsShrink))
            {
                query["resource_ids"] = request.ResourceIdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["resource_type"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagKeysShrink))
            {
                query["tag_keys"] = request.TagKeysShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UntagResources",
                Version = "2015-12-15",
                Protocol = "HTTPS",
                Pathname = "/tags",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UntagResourcesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Removes labels from a Container Service for Kubernetes (ACK) cluster.
         *
         * @param request UntagResourcesRequest
         * @return UntagResourcesResponse
         */
        public UntagResourcesResponse UntagResources(UntagResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UntagResourcesWithOptions(request, headers, runtime);
        }

        /**
         * @summary Removes labels from a Container Service for Kubernetes (ACK) cluster.
         *
         * @param request UntagResourcesRequest
         * @return UntagResourcesResponse
         */
        public async Task<UntagResourcesResponse> UntagResourcesAsync(UntagResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UntagResourcesWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary You can call the UpdateClusterAuditLogConfig operation to enable or disable the audit log feature in a Container Service for Kubernetes (ACK) cluster and update the audit log configuration. This operation also allows you to record requests to the Kubernetes API and the responses, which can be used to trace cluster operation history and troubleshoot cluster issues.
         *
         * @description Before you call this operation, ensure that you understand the billing methods and pricing of [Simple Log Service](https://www.aliyun.com/price/product#/sls/detail/sls) (SLS).
         *
         * @param request UpdateClusterAuditLogConfigRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateClusterAuditLogConfigResponse
         */
        public UpdateClusterAuditLogConfigResponse UpdateClusterAuditLogConfigWithOptions(string clusterid, UpdateClusterAuditLogConfigRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Disable))
            {
                body["disable"] = request.Disable;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SlsProjectName))
            {
                body["sls_project_name"] = request.SlsProjectName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateClusterAuditLogConfig",
                Version = "2015-12-15",
                Protocol = "HTTPS",
                Pathname = "/clusters/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(clusterid) + "/audit_log",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateClusterAuditLogConfigResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary You can call the UpdateClusterAuditLogConfig operation to enable or disable the audit log feature in a Container Service for Kubernetes (ACK) cluster and update the audit log configuration. This operation also allows you to record requests to the Kubernetes API and the responses, which can be used to trace cluster operation history and troubleshoot cluster issues.
         *
         * @description Before you call this operation, ensure that you understand the billing methods and pricing of [Simple Log Service](https://www.aliyun.com/price/product#/sls/detail/sls) (SLS).
         *
         * @param request UpdateClusterAuditLogConfigRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateClusterAuditLogConfigResponse
         */
        public async Task<UpdateClusterAuditLogConfigResponse> UpdateClusterAuditLogConfigWithOptionsAsync(string clusterid, UpdateClusterAuditLogConfigRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Disable))
            {
                body["disable"] = request.Disable;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SlsProjectName))
            {
                body["sls_project_name"] = request.SlsProjectName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateClusterAuditLogConfig",
                Version = "2015-12-15",
                Protocol = "HTTPS",
                Pathname = "/clusters/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(clusterid) + "/audit_log",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateClusterAuditLogConfigResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary You can call the UpdateClusterAuditLogConfig operation to enable or disable the audit log feature in a Container Service for Kubernetes (ACK) cluster and update the audit log configuration. This operation also allows you to record requests to the Kubernetes API and the responses, which can be used to trace cluster operation history and troubleshoot cluster issues.
         *
         * @description Before you call this operation, ensure that you understand the billing methods and pricing of [Simple Log Service](https://www.aliyun.com/price/product#/sls/detail/sls) (SLS).
         *
         * @param request UpdateClusterAuditLogConfigRequest
         * @return UpdateClusterAuditLogConfigResponse
         */
        public UpdateClusterAuditLogConfigResponse UpdateClusterAuditLogConfig(string clusterid, UpdateClusterAuditLogConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateClusterAuditLogConfigWithOptions(clusterid, request, headers, runtime);
        }

        /**
         * @summary You can call the UpdateClusterAuditLogConfig operation to enable or disable the audit log feature in a Container Service for Kubernetes (ACK) cluster and update the audit log configuration. This operation also allows you to record requests to the Kubernetes API and the responses, which can be used to trace cluster operation history and troubleshoot cluster issues.
         *
         * @description Before you call this operation, ensure that you understand the billing methods and pricing of [Simple Log Service](https://www.aliyun.com/price/product#/sls/detail/sls) (SLS).
         *
         * @param request UpdateClusterAuditLogConfigRequest
         * @return UpdateClusterAuditLogConfigResponse
         */
        public async Task<UpdateClusterAuditLogConfigResponse> UpdateClusterAuditLogConfigAsync(string clusterid, UpdateClusterAuditLogConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateClusterAuditLogConfigWithOptionsAsync(clusterid, request, headers, runtime);
        }

        /**
         * @summary 为集群中报警规则集设置订阅的通知对象联系人组
         *
         * @param request UpdateContactGroupForAlertRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateContactGroupForAlertResponse
         */
        public UpdateContactGroupForAlertResponse UpdateContactGroupForAlertWithOptions(string ClusterId, UpdateContactGroupForAlertRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlertRuleGroupName))
            {
                body["alert_rule_group_name"] = request.AlertRuleGroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactGroupIds))
            {
                body["contact_group_ids"] = request.ContactGroupIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CrName))
            {
                body["cr_name"] = request.CrName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                body["namespace"] = request.Namespace;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateContactGroupForAlert",
                Version = "2015-12-15",
                Protocol = "HTTPS",
                Pathname = "/alert/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId) + "/alert_rule/contact_groups",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateContactGroupForAlertResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 为集群中报警规则集设置订阅的通知对象联系人组
         *
         * @param request UpdateContactGroupForAlertRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateContactGroupForAlertResponse
         */
        public async Task<UpdateContactGroupForAlertResponse> UpdateContactGroupForAlertWithOptionsAsync(string ClusterId, UpdateContactGroupForAlertRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlertRuleGroupName))
            {
                body["alert_rule_group_name"] = request.AlertRuleGroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContactGroupIds))
            {
                body["contact_group_ids"] = request.ContactGroupIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CrName))
            {
                body["cr_name"] = request.CrName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                body["namespace"] = request.Namespace;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateContactGroupForAlert",
                Version = "2015-12-15",
                Protocol = "HTTPS",
                Pathname = "/alert/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId) + "/alert_rule/contact_groups",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateContactGroupForAlertResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 为集群中报警规则集设置订阅的通知对象联系人组
         *
         * @param request UpdateContactGroupForAlertRequest
         * @return UpdateContactGroupForAlertResponse
         */
        public UpdateContactGroupForAlertResponse UpdateContactGroupForAlert(string ClusterId, UpdateContactGroupForAlertRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateContactGroupForAlertWithOptions(ClusterId, request, headers, runtime);
        }

        /**
         * @summary 为集群中报警规则集设置订阅的通知对象联系人组
         *
         * @param request UpdateContactGroupForAlertRequest
         * @return UpdateContactGroupForAlertResponse
         */
        public async Task<UpdateContactGroupForAlertResponse> UpdateContactGroupForAlertAsync(string ClusterId, UpdateContactGroupForAlertRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateContactGroupForAlertWithOptionsAsync(ClusterId, request, headers, runtime);
        }

        /**
         * @summary You can call the UpdateControlPlaneLog operation to modify the log collection configurations for control plane components in a Container Service for Kubernetes (ACK) managed cluster.
         *
         * @param request UpdateControlPlaneLogRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateControlPlaneLogResponse
         */
        public UpdateControlPlaneLogResponse UpdateControlPlaneLogWithOptions(string ClusterId, UpdateControlPlaneLogRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Aliuid))
            {
                body["aliuid"] = request.Aliuid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Components))
            {
                body["components"] = request.Components;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogProject))
            {
                body["log_project"] = request.LogProject;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogTtl))
            {
                body["log_ttl"] = request.LogTtl;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateControlPlaneLog",
                Version = "2015-12-15",
                Protocol = "HTTPS",
                Pathname = "/clusters/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId) + "/controlplanelog",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateControlPlaneLogResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary You can call the UpdateControlPlaneLog operation to modify the log collection configurations for control plane components in a Container Service for Kubernetes (ACK) managed cluster.
         *
         * @param request UpdateControlPlaneLogRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateControlPlaneLogResponse
         */
        public async Task<UpdateControlPlaneLogResponse> UpdateControlPlaneLogWithOptionsAsync(string ClusterId, UpdateControlPlaneLogRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Aliuid))
            {
                body["aliuid"] = request.Aliuid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Components))
            {
                body["components"] = request.Components;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogProject))
            {
                body["log_project"] = request.LogProject;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogTtl))
            {
                body["log_ttl"] = request.LogTtl;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateControlPlaneLog",
                Version = "2015-12-15",
                Protocol = "HTTPS",
                Pathname = "/clusters/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId) + "/controlplanelog",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateControlPlaneLogResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary You can call the UpdateControlPlaneLog operation to modify the log collection configurations for control plane components in a Container Service for Kubernetes (ACK) managed cluster.
         *
         * @param request UpdateControlPlaneLogRequest
         * @return UpdateControlPlaneLogResponse
         */
        public UpdateControlPlaneLogResponse UpdateControlPlaneLog(string ClusterId, UpdateControlPlaneLogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateControlPlaneLogWithOptions(ClusterId, request, headers, runtime);
        }

        /**
         * @summary You can call the UpdateControlPlaneLog operation to modify the log collection configurations for control plane components in a Container Service for Kubernetes (ACK) managed cluster.
         *
         * @param request UpdateControlPlaneLogRequest
         * @return UpdateControlPlaneLogResponse
         */
        public async Task<UpdateControlPlaneLogResponse> UpdateControlPlaneLogAsync(string ClusterId, UpdateControlPlaneLogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateControlPlaneLogWithOptionsAsync(ClusterId, request, headers, runtime);
        }

        /**
         * @summary Sets the validity period of a kubeconfig file used by a Resource Access Management (RAM) user or RAM role to connect to a Container Service for Kubernetes (ACK) cluster. The validity period ranges from 1 to 876,000 hours. You can call this API operation when you customize configurations by using an Alibaba Cloud account. The default validity period of a kubeconfig file is three years.
         *
         * @description - You can call this operation only with an Alibaba Cloud account. 
         * - If the kubeconfig file used by your cluster is revoked, the custom validity period of the kubeconfig file is reset. In this case, you need to call this API operation to reconfigure the validity period of the kubeconfig file.
         *
         * @param request UpdateK8sClusterUserConfigExpireRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateK8sClusterUserConfigExpireResponse
         */
        public UpdateK8sClusterUserConfigExpireResponse UpdateK8sClusterUserConfigExpireWithOptions(string ClusterId, UpdateK8sClusterUserConfigExpireRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExpireHour))
            {
                body["expire_hour"] = request.ExpireHour;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.User))
            {
                body["user"] = request.User;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateK8sClusterUserConfigExpire",
                Version = "2015-12-15",
                Protocol = "HTTPS",
                Pathname = "/k8s/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId) + "/user_config/expire",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<UpdateK8sClusterUserConfigExpireResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Sets the validity period of a kubeconfig file used by a Resource Access Management (RAM) user or RAM role to connect to a Container Service for Kubernetes (ACK) cluster. The validity period ranges from 1 to 876,000 hours. You can call this API operation when you customize configurations by using an Alibaba Cloud account. The default validity period of a kubeconfig file is three years.
         *
         * @description - You can call this operation only with an Alibaba Cloud account. 
         * - If the kubeconfig file used by your cluster is revoked, the custom validity period of the kubeconfig file is reset. In this case, you need to call this API operation to reconfigure the validity period of the kubeconfig file.
         *
         * @param request UpdateK8sClusterUserConfigExpireRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateK8sClusterUserConfigExpireResponse
         */
        public async Task<UpdateK8sClusterUserConfigExpireResponse> UpdateK8sClusterUserConfigExpireWithOptionsAsync(string ClusterId, UpdateK8sClusterUserConfigExpireRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExpireHour))
            {
                body["expire_hour"] = request.ExpireHour;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.User))
            {
                body["user"] = request.User;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateK8sClusterUserConfigExpire",
                Version = "2015-12-15",
                Protocol = "HTTPS",
                Pathname = "/k8s/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId) + "/user_config/expire",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<UpdateK8sClusterUserConfigExpireResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Sets the validity period of a kubeconfig file used by a Resource Access Management (RAM) user or RAM role to connect to a Container Service for Kubernetes (ACK) cluster. The validity period ranges from 1 to 876,000 hours. You can call this API operation when you customize configurations by using an Alibaba Cloud account. The default validity period of a kubeconfig file is three years.
         *
         * @description - You can call this operation only with an Alibaba Cloud account. 
         * - If the kubeconfig file used by your cluster is revoked, the custom validity period of the kubeconfig file is reset. In this case, you need to call this API operation to reconfigure the validity period of the kubeconfig file.
         *
         * @param request UpdateK8sClusterUserConfigExpireRequest
         * @return UpdateK8sClusterUserConfigExpireResponse
         */
        public UpdateK8sClusterUserConfigExpireResponse UpdateK8sClusterUserConfigExpire(string ClusterId, UpdateK8sClusterUserConfigExpireRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateK8sClusterUserConfigExpireWithOptions(ClusterId, request, headers, runtime);
        }

        /**
         * @summary Sets the validity period of a kubeconfig file used by a Resource Access Management (RAM) user or RAM role to connect to a Container Service for Kubernetes (ACK) cluster. The validity period ranges from 1 to 876,000 hours. You can call this API operation when you customize configurations by using an Alibaba Cloud account. The default validity period of a kubeconfig file is three years.
         *
         * @description - You can call this operation only with an Alibaba Cloud account. 
         * - If the kubeconfig file used by your cluster is revoked, the custom validity period of the kubeconfig file is reset. In this case, you need to call this API operation to reconfigure the validity period of the kubeconfig file.
         *
         * @param request UpdateK8sClusterUserConfigExpireRequest
         * @return UpdateK8sClusterUserConfigExpireResponse
         */
        public async Task<UpdateK8sClusterUserConfigExpireResponse> UpdateK8sClusterUserConfigExpireAsync(string ClusterId, UpdateK8sClusterUserConfigExpireRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateK8sClusterUserConfigExpireWithOptionsAsync(ClusterId, request, headers, runtime);
        }

        /**
         * @summary Updates the deletion protection status of the specified resources. You can enable or disable deletion protection for namespaces and Services.
         *
         * @param request UpdateResourcesDeleteProtectionRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateResourcesDeleteProtectionResponse
         */
        public UpdateResourcesDeleteProtectionResponse UpdateResourcesDeleteProtectionWithOptions(string ClusterId, UpdateResourcesDeleteProtectionRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Enable))
            {
                body["enable"] = request.Enable;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                body["namespace"] = request.Namespace;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                body["resource_type"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Resources))
            {
                body["resources"] = request.Resources;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateResourcesDeleteProtection",
                Version = "2015-12-15",
                Protocol = "HTTPS",
                Pathname = "/clusters/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId) + "/resources/protection",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateResourcesDeleteProtectionResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Updates the deletion protection status of the specified resources. You can enable or disable deletion protection for namespaces and Services.
         *
         * @param request UpdateResourcesDeleteProtectionRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateResourcesDeleteProtectionResponse
         */
        public async Task<UpdateResourcesDeleteProtectionResponse> UpdateResourcesDeleteProtectionWithOptionsAsync(string ClusterId, UpdateResourcesDeleteProtectionRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Enable))
            {
                body["enable"] = request.Enable;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                body["namespace"] = request.Namespace;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                body["resource_type"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Resources))
            {
                body["resources"] = request.Resources;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateResourcesDeleteProtection",
                Version = "2015-12-15",
                Protocol = "HTTPS",
                Pathname = "/clusters/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId) + "/resources/protection",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateResourcesDeleteProtectionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Updates the deletion protection status of the specified resources. You can enable or disable deletion protection for namespaces and Services.
         *
         * @param request UpdateResourcesDeleteProtectionRequest
         * @return UpdateResourcesDeleteProtectionResponse
         */
        public UpdateResourcesDeleteProtectionResponse UpdateResourcesDeleteProtection(string ClusterId, UpdateResourcesDeleteProtectionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateResourcesDeleteProtectionWithOptions(ClusterId, request, headers, runtime);
        }

        /**
         * @summary Updates the deletion protection status of the specified resources. You can enable or disable deletion protection for namespaces and Services.
         *
         * @param request UpdateResourcesDeleteProtectionRequest
         * @return UpdateResourcesDeleteProtectionResponse
         */
        public async Task<UpdateResourcesDeleteProtectionResponse> UpdateResourcesDeleteProtectionAsync(string ClusterId, UpdateResourcesDeleteProtectionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateResourcesDeleteProtectionWithOptionsAsync(ClusterId, request, headers, runtime);
        }

        /**
         * @summary Updates the configurations of an orchestration template. An orchestration template defines and describes a group of Container Service for Kubernetes (ACK) resources. An orchestration template describes the configurations of an application or how an application runs in a declarative manner.
         *
         * @param request UpdateTemplateRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateTemplateResponse
         */
        public UpdateTemplateResponse UpdateTemplateWithOptions(string TemplateId, UpdateTemplateRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tags))
            {
                body["tags"] = request.Tags;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Template))
            {
                body["template"] = request.Template;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateType))
            {
                body["template_type"] = request.TemplateType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateTemplate",
                Version = "2015-12-15",
                Protocol = "HTTPS",
                Pathname = "/templates/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(TemplateId),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<UpdateTemplateResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Updates the configurations of an orchestration template. An orchestration template defines and describes a group of Container Service for Kubernetes (ACK) resources. An orchestration template describes the configurations of an application or how an application runs in a declarative manner.
         *
         * @param request UpdateTemplateRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateTemplateResponse
         */
        public async Task<UpdateTemplateResponse> UpdateTemplateWithOptionsAsync(string TemplateId, UpdateTemplateRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tags))
            {
                body["tags"] = request.Tags;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Template))
            {
                body["template"] = request.Template;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateType))
            {
                body["template_type"] = request.TemplateType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateTemplate",
                Version = "2015-12-15",
                Protocol = "HTTPS",
                Pathname = "/templates/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(TemplateId),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<UpdateTemplateResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Updates the configurations of an orchestration template. An orchestration template defines and describes a group of Container Service for Kubernetes (ACK) resources. An orchestration template describes the configurations of an application or how an application runs in a declarative manner.
         *
         * @param request UpdateTemplateRequest
         * @return UpdateTemplateResponse
         */
        public UpdateTemplateResponse UpdateTemplate(string TemplateId, UpdateTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateTemplateWithOptions(TemplateId, request, headers, runtime);
        }

        /**
         * @summary Updates the configurations of an orchestration template. An orchestration template defines and describes a group of Container Service for Kubernetes (ACK) resources. An orchestration template describes the configurations of an application or how an application runs in a declarative manner.
         *
         * @param request UpdateTemplateRequest
         * @return UpdateTemplateResponse
         */
        public async Task<UpdateTemplateResponse> UpdateTemplateAsync(string TemplateId, UpdateTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateTemplateWithOptionsAsync(TemplateId, request, headers, runtime);
        }

        /**
         * @summary Updates the role-based access control (RBAC) permissions of a Resource Access Management (RAM) user or RAM role. By default, you do not have the RBAC permissions on a Container Service for Kubernetes (ACK) cluster if you are not the cluster owner or you are not using an Alibaba Cloud account. You can call this operation to specify the resources that can be accessed, permission scope, and predefined roles. This helps you better manage the access control on resources in ACK clusters.
         *
         * @description **Precautions**:
         * *   You can update the permissions of a RAM user or RAM role on a cluster by using full update or incremental update. If you use full update, the existing permissions of the RAM user or RAM role on the cluster are overwritten. You must specify all the permissions that you want to grant to the RAM user or RAM role in the request parameters when you call the operation. If you use incremental update, you can grant permissions to or revoke permissions from the RAM user or RAM role on the cluster. In this case, only the permissions that you specify in the request parameters when you call the operation are granted or revoked, other permissions of the RAM user or RAM role on the cluster are not affected.
         *
         * @param request UpdateUserPermissionsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateUserPermissionsResponse
         */
        public UpdateUserPermissionsResponse UpdateUserPermissionsWithOptions(string uid, UpdateUserPermissionsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mode))
            {
                query["mode"] = request.Mode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToArray(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateUserPermissions",
                Version = "2015-12-15",
                Protocol = "HTTPS",
                Pathname = "/permissions/users/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(uid) + "/update",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<UpdateUserPermissionsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Updates the role-based access control (RBAC) permissions of a Resource Access Management (RAM) user or RAM role. By default, you do not have the RBAC permissions on a Container Service for Kubernetes (ACK) cluster if you are not the cluster owner or you are not using an Alibaba Cloud account. You can call this operation to specify the resources that can be accessed, permission scope, and predefined roles. This helps you better manage the access control on resources in ACK clusters.
         *
         * @description **Precautions**:
         * *   You can update the permissions of a RAM user or RAM role on a cluster by using full update or incremental update. If you use full update, the existing permissions of the RAM user or RAM role on the cluster are overwritten. You must specify all the permissions that you want to grant to the RAM user or RAM role in the request parameters when you call the operation. If you use incremental update, you can grant permissions to or revoke permissions from the RAM user or RAM role on the cluster. In this case, only the permissions that you specify in the request parameters when you call the operation are granted or revoked, other permissions of the RAM user or RAM role on the cluster are not affected.
         *
         * @param request UpdateUserPermissionsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateUserPermissionsResponse
         */
        public async Task<UpdateUserPermissionsResponse> UpdateUserPermissionsWithOptionsAsync(string uid, UpdateUserPermissionsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mode))
            {
                query["mode"] = request.Mode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToArray(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateUserPermissions",
                Version = "2015-12-15",
                Protocol = "HTTPS",
                Pathname = "/permissions/users/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(uid) + "/update",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<UpdateUserPermissionsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Updates the role-based access control (RBAC) permissions of a Resource Access Management (RAM) user or RAM role. By default, you do not have the RBAC permissions on a Container Service for Kubernetes (ACK) cluster if you are not the cluster owner or you are not using an Alibaba Cloud account. You can call this operation to specify the resources that can be accessed, permission scope, and predefined roles. This helps you better manage the access control on resources in ACK clusters.
         *
         * @description **Precautions**:
         * *   You can update the permissions of a RAM user or RAM role on a cluster by using full update or incremental update. If you use full update, the existing permissions of the RAM user or RAM role on the cluster are overwritten. You must specify all the permissions that you want to grant to the RAM user or RAM role in the request parameters when you call the operation. If you use incremental update, you can grant permissions to or revoke permissions from the RAM user or RAM role on the cluster. In this case, only the permissions that you specify in the request parameters when you call the operation are granted or revoked, other permissions of the RAM user or RAM role on the cluster are not affected.
         *
         * @param request UpdateUserPermissionsRequest
         * @return UpdateUserPermissionsResponse
         */
        public UpdateUserPermissionsResponse UpdateUserPermissions(string uid, UpdateUserPermissionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateUserPermissionsWithOptions(uid, request, headers, runtime);
        }

        /**
         * @summary Updates the role-based access control (RBAC) permissions of a Resource Access Management (RAM) user or RAM role. By default, you do not have the RBAC permissions on a Container Service for Kubernetes (ACK) cluster if you are not the cluster owner or you are not using an Alibaba Cloud account. You can call this operation to specify the resources that can be accessed, permission scope, and predefined roles. This helps you better manage the access control on resources in ACK clusters.
         *
         * @description **Precautions**:
         * *   You can update the permissions of a RAM user or RAM role on a cluster by using full update or incremental update. If you use full update, the existing permissions of the RAM user or RAM role on the cluster are overwritten. You must specify all the permissions that you want to grant to the RAM user or RAM role in the request parameters when you call the operation. If you use incremental update, you can grant permissions to or revoke permissions from the RAM user or RAM role on the cluster. In this case, only the permissions that you specify in the request parameters when you call the operation are granted or revoked, other permissions of the RAM user or RAM role on the cluster are not affected.
         *
         * @param request UpdateUserPermissionsRequest
         * @return UpdateUserPermissionsResponse
         */
        public async Task<UpdateUserPermissionsResponse> UpdateUserPermissionsAsync(string uid, UpdateUserPermissionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateUserPermissionsWithOptionsAsync(uid, request, headers, runtime);
        }

        /**
         * @summary You can call the UpgradeCluster operation to upgrade a cluster by cluster ID.
         *
         * @param request UpgradeClusterRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpgradeClusterResponse
         */
        public UpgradeClusterResponse UpgradeClusterWithOptions(string ClusterId, UpgradeClusterRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ComponentName))
            {
                body["component_name"] = request.ComponentName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MasterOnly))
            {
                body["master_only"] = request.MasterOnly;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextVersion))
            {
                body["next_version"] = request.NextVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RollingPolicy))
            {
                body["rolling_policy"] = request.RollingPolicy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Version))
            {
                body["version"] = request.Version;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpgradeCluster",
                Version = "2015-12-15",
                Protocol = "HTTPS",
                Pathname = "/api/v2/clusters/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId) + "/upgrade",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpgradeClusterResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary You can call the UpgradeCluster operation to upgrade a cluster by cluster ID.
         *
         * @param request UpgradeClusterRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpgradeClusterResponse
         */
        public async Task<UpgradeClusterResponse> UpgradeClusterWithOptionsAsync(string ClusterId, UpgradeClusterRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ComponentName))
            {
                body["component_name"] = request.ComponentName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MasterOnly))
            {
                body["master_only"] = request.MasterOnly;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextVersion))
            {
                body["next_version"] = request.NextVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RollingPolicy))
            {
                body["rolling_policy"] = request.RollingPolicy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Version))
            {
                body["version"] = request.Version;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpgradeCluster",
                Version = "2015-12-15",
                Protocol = "HTTPS",
                Pathname = "/api/v2/clusters/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId) + "/upgrade",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpgradeClusterResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary You can call the UpgradeCluster operation to upgrade a cluster by cluster ID.
         *
         * @param request UpgradeClusterRequest
         * @return UpgradeClusterResponse
         */
        public UpgradeClusterResponse UpgradeCluster(string ClusterId, UpgradeClusterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpgradeClusterWithOptions(ClusterId, request, headers, runtime);
        }

        /**
         * @summary You can call the UpgradeCluster operation to upgrade a cluster by cluster ID.
         *
         * @param request UpgradeClusterRequest
         * @return UpgradeClusterResponse
         */
        public async Task<UpgradeClusterResponse> UpgradeClusterAsync(string ClusterId, UpgradeClusterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpgradeClusterWithOptionsAsync(ClusterId, request, headers, runtime);
        }

        /**
         * @summary Updates cluster components to use new features and patch vulnerabilities. You must update cluster components one after one and update a component only after the previous one is successfully updated. Before you update a component, we recommend that you read the update notes for each component. Cluster component updates may affect your businesses. Assess the impact, back up data, and perform the update during off-peak hours.
         *
         * @param request UpgradeClusterAddonsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpgradeClusterAddonsResponse
         */
        public UpgradeClusterAddonsResponse UpgradeClusterAddonsWithOptions(string ClusterId, UpgradeClusterAddonsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.TeaUtil.Common.ToArray(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpgradeClusterAddons",
                Version = "2015-12-15",
                Protocol = "HTTPS",
                Pathname = "/clusters/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId) + "/components/upgrade",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpgradeClusterAddonsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Updates cluster components to use new features and patch vulnerabilities. You must update cluster components one after one and update a component only after the previous one is successfully updated. Before you update a component, we recommend that you read the update notes for each component. Cluster component updates may affect your businesses. Assess the impact, back up data, and perform the update during off-peak hours.
         *
         * @param request UpgradeClusterAddonsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpgradeClusterAddonsResponse
         */
        public async Task<UpgradeClusterAddonsResponse> UpgradeClusterAddonsWithOptionsAsync(string ClusterId, UpgradeClusterAddonsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.TeaUtil.Common.ToArray(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpgradeClusterAddons",
                Version = "2015-12-15",
                Protocol = "HTTPS",
                Pathname = "/clusters/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId) + "/components/upgrade",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpgradeClusterAddonsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Updates cluster components to use new features and patch vulnerabilities. You must update cluster components one after one and update a component only after the previous one is successfully updated. Before you update a component, we recommend that you read the update notes for each component. Cluster component updates may affect your businesses. Assess the impact, back up data, and perform the update during off-peak hours.
         *
         * @param request UpgradeClusterAddonsRequest
         * @return UpgradeClusterAddonsResponse
         */
        public UpgradeClusterAddonsResponse UpgradeClusterAddons(string ClusterId, UpgradeClusterAddonsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpgradeClusterAddonsWithOptions(ClusterId, request, headers, runtime);
        }

        /**
         * @summary Updates cluster components to use new features and patch vulnerabilities. You must update cluster components one after one and update a component only after the previous one is successfully updated. Before you update a component, we recommend that you read the update notes for each component. Cluster component updates may affect your businesses. Assess the impact, back up data, and perform the update during off-peak hours.
         *
         * @param request UpgradeClusterAddonsRequest
         * @return UpgradeClusterAddonsResponse
         */
        public async Task<UpgradeClusterAddonsResponse> UpgradeClusterAddonsAsync(string ClusterId, UpgradeClusterAddonsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpgradeClusterAddonsWithOptionsAsync(ClusterId, request, headers, runtime);
        }

        /**
         * @summary You can call the UpgradeClusterNodepool operation to update the Kubernetes version, OS version, or container runtime version of the nodes in a node pool.
         *
         * @description This operation allows you to update the Kubernetes version, OS version, or container runtime version of the nodes in a node pool.
         *
         * @param request UpgradeClusterNodepoolRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpgradeClusterNodepoolResponse
         */
        public UpgradeClusterNodepoolResponse UpgradeClusterNodepoolWithOptions(string ClusterId, string NodepoolId, UpgradeClusterNodepoolRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageId))
            {
                body["image_id"] = request.ImageId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KubernetesVersion))
            {
                body["kubernetes_version"] = request.KubernetesVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeNames))
            {
                body["node_names"] = request.NodeNames;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RollingPolicy))
            {
                body["rolling_policy"] = request.RollingPolicy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuntimeType))
            {
                body["runtime_type"] = request.RuntimeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuntimeVersion))
            {
                body["runtime_version"] = request.RuntimeVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UseReplace))
            {
                body["use_replace"] = request.UseReplace;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpgradeClusterNodepool",
                Version = "2015-12-15",
                Protocol = "HTTPS",
                Pathname = "/clusters/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId) + "/nodepools/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(NodepoolId) + "/upgrade",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpgradeClusterNodepoolResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary You can call the UpgradeClusterNodepool operation to update the Kubernetes version, OS version, or container runtime version of the nodes in a node pool.
         *
         * @description This operation allows you to update the Kubernetes version, OS version, or container runtime version of the nodes in a node pool.
         *
         * @param request UpgradeClusterNodepoolRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpgradeClusterNodepoolResponse
         */
        public async Task<UpgradeClusterNodepoolResponse> UpgradeClusterNodepoolWithOptionsAsync(string ClusterId, string NodepoolId, UpgradeClusterNodepoolRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageId))
            {
                body["image_id"] = request.ImageId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KubernetesVersion))
            {
                body["kubernetes_version"] = request.KubernetesVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeNames))
            {
                body["node_names"] = request.NodeNames;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RollingPolicy))
            {
                body["rolling_policy"] = request.RollingPolicy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuntimeType))
            {
                body["runtime_type"] = request.RuntimeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuntimeVersion))
            {
                body["runtime_version"] = request.RuntimeVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UseReplace))
            {
                body["use_replace"] = request.UseReplace;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpgradeClusterNodepool",
                Version = "2015-12-15",
                Protocol = "HTTPS",
                Pathname = "/clusters/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId) + "/nodepools/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(NodepoolId) + "/upgrade",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpgradeClusterNodepoolResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary You can call the UpgradeClusterNodepool operation to update the Kubernetes version, OS version, or container runtime version of the nodes in a node pool.
         *
         * @description This operation allows you to update the Kubernetes version, OS version, or container runtime version of the nodes in a node pool.
         *
         * @param request UpgradeClusterNodepoolRequest
         * @return UpgradeClusterNodepoolResponse
         */
        public UpgradeClusterNodepoolResponse UpgradeClusterNodepool(string ClusterId, string NodepoolId, UpgradeClusterNodepoolRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpgradeClusterNodepoolWithOptions(ClusterId, NodepoolId, request, headers, runtime);
        }

        /**
         * @summary You can call the UpgradeClusterNodepool operation to update the Kubernetes version, OS version, or container runtime version of the nodes in a node pool.
         *
         * @description This operation allows you to update the Kubernetes version, OS version, or container runtime version of the nodes in a node pool.
         *
         * @param request UpgradeClusterNodepoolRequest
         * @return UpgradeClusterNodepoolResponse
         */
        public async Task<UpgradeClusterNodepoolResponse> UpgradeClusterNodepoolAsync(string ClusterId, string NodepoolId, UpgradeClusterNodepoolRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpgradeClusterNodepoolWithOptionsAsync(ClusterId, NodepoolId, request, headers, runtime);
        }

    }
}
