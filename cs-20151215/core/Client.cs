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
            this._endpointRule = "regional";
            this._endpointMap = new Dictionary<string, string>
            {
                {"ap-northeast-2-pop", "cs.aliyuncs.com"},
                {"cn-beijing-finance-1", "cs.aliyuncs.com"},
                {"cn-beijing-finance-pop", "cs.aliyuncs.com"},
                {"cn-beijing-gov-1", "cs.aliyuncs.com"},
                {"cn-beijing-nu16-b01", "cs.aliyuncs.com"},
                {"cn-edge-1", "cs.aliyuncs.com"},
                {"cn-fujian", "cs.aliyuncs.com"},
                {"cn-haidian-cm12-c01", "cs.aliyuncs.com"},
                {"cn-hangzhou-bj-b01", "cs.aliyuncs.com"},
                {"cn-hangzhou-finance", "cs-vpc.cn-hangzhou-finance.aliyuncs.com"},
                {"cn-hangzhou-internal-prod-1", "cs.aliyuncs.com"},
                {"cn-hangzhou-internal-test-1", "cs.aliyuncs.com"},
                {"cn-hangzhou-internal-test-2", "cs.aliyuncs.com"},
                {"cn-hangzhou-internal-test-3", "cs.aliyuncs.com"},
                {"cn-hangzhou-test-306", "cs.aliyuncs.com"},
                {"cn-hongkong-finance-pop", "cs.aliyuncs.com"},
                {"cn-huhehaote-nebula-1", "cs.aliyuncs.com"},
                {"cn-qingdao-nebula", "cs.aliyuncs.com"},
                {"cn-shanghai-et15-b01", "cs.aliyuncs.com"},
                {"cn-shanghai-et2-b01", "cs.aliyuncs.com"},
                {"cn-shanghai-finance-1", "cs-vpc.cn-shanghai-finance-1.aliyuncs.com"},
                {"cn-shanghai-inner", "cs.aliyuncs.com"},
                {"cn-shanghai-internal-test-1", "cs.aliyuncs.com"},
                {"cn-shenzhen-finance-1", "cs-vpc.cn-shenzhen-finance-1.aliyuncs.com"},
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

        public AttachInstancesResponse AttachInstances(string ClusterId, AttachInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return AttachInstancesWithOptions(ClusterId, request, headers, runtime);
        }

        public async Task<AttachInstancesResponse> AttachInstancesAsync(string ClusterId, AttachInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await AttachInstancesWithOptionsAsync(ClusterId, request, headers, runtime);
        }

        public AttachInstancesResponse AttachInstancesWithOptions(string ClusterId, AttachInstancesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            ClusterId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId);
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Runtime.ToMap()))
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
                Pathname = "/clusters/" + ClusterId + "/attach",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<AttachInstancesResponse>(CallApi(params_, req, runtime));
        }

        public async Task<AttachInstancesResponse> AttachInstancesWithOptionsAsync(string ClusterId, AttachInstancesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            ClusterId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId);
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Runtime.ToMap()))
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
                Pathname = "/clusters/" + ClusterId + "/attach",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<AttachInstancesResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CancelClusterUpgradeResponse CancelClusterUpgrade(string ClusterId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CancelClusterUpgradeWithOptions(ClusterId, headers, runtime);
        }

        public async Task<CancelClusterUpgradeResponse> CancelClusterUpgradeAsync(string ClusterId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CancelClusterUpgradeWithOptionsAsync(ClusterId, headers, runtime);
        }

        public CancelClusterUpgradeResponse CancelClusterUpgradeWithOptions(string ClusterId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            ClusterId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CancelClusterUpgrade",
                Version = "2015-12-15",
                Protocol = "HTTPS",
                Pathname = "/api/v2/clusters/" + ClusterId + "/upgrade/cancel",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<CancelClusterUpgradeResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CancelClusterUpgradeResponse> CancelClusterUpgradeWithOptionsAsync(string ClusterId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            ClusterId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CancelClusterUpgrade",
                Version = "2015-12-15",
                Protocol = "HTTPS",
                Pathname = "/api/v2/clusters/" + ClusterId + "/upgrade/cancel",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<CancelClusterUpgradeResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CancelComponentUpgradeResponse CancelComponentUpgrade(string clusterId, string componentId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CancelComponentUpgradeWithOptions(clusterId, componentId, headers, runtime);
        }

        public async Task<CancelComponentUpgradeResponse> CancelComponentUpgradeAsync(string clusterId, string componentId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CancelComponentUpgradeWithOptionsAsync(clusterId, componentId, headers, runtime);
        }

        public CancelComponentUpgradeResponse CancelComponentUpgradeWithOptions(string clusterId, string componentId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            clusterId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(clusterId);
            componentId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(componentId);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CancelComponentUpgrade",
                Version = "2015-12-15",
                Protocol = "HTTPS",
                Pathname = "/clusters/" + clusterId + "/components/" + componentId + "/cancel",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<CancelComponentUpgradeResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CancelComponentUpgradeResponse> CancelComponentUpgradeWithOptionsAsync(string clusterId, string componentId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            clusterId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(clusterId);
            componentId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(componentId);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CancelComponentUpgrade",
                Version = "2015-12-15",
                Protocol = "HTTPS",
                Pathname = "/clusters/" + clusterId + "/components/" + componentId + "/cancel",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<CancelComponentUpgradeResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CancelWorkflowResponse CancelWorkflow(string workflowName, CancelWorkflowRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CancelWorkflowWithOptions(workflowName, request, headers, runtime);
        }

        public async Task<CancelWorkflowResponse> CancelWorkflowAsync(string workflowName, CancelWorkflowRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CancelWorkflowWithOptionsAsync(workflowName, request, headers, runtime);
        }

        public CancelWorkflowResponse CancelWorkflowWithOptions(string workflowName, CancelWorkflowRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            workflowName = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workflowName);
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
                Pathname = "/gs/workflow/" + workflowName,
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<CancelWorkflowResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CancelWorkflowResponse> CancelWorkflowWithOptionsAsync(string workflowName, CancelWorkflowRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            workflowName = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workflowName);
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
                Pathname = "/gs/workflow/" + workflowName,
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<CancelWorkflowResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateAutoscalingConfigResponse CreateAutoscalingConfig(string ClusterId, CreateAutoscalingConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateAutoscalingConfigWithOptions(ClusterId, request, headers, runtime);
        }

        public async Task<CreateAutoscalingConfigResponse> CreateAutoscalingConfigAsync(string ClusterId, CreateAutoscalingConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateAutoscalingConfigWithOptionsAsync(ClusterId, request, headers, runtime);
        }

        public CreateAutoscalingConfigResponse CreateAutoscalingConfigWithOptions(string ClusterId, CreateAutoscalingConfigRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            ClusterId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CoolDownDuration))
            {
                body["cool_down_duration"] = request.CoolDownDuration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GpuUtilizationThreshold))
            {
                body["gpu_utilization_threshold"] = request.GpuUtilizationThreshold;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScanInterval))
            {
                body["scan_interval"] = request.ScanInterval;
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
                Pathname = "/cluster/" + ClusterId + "/autoscale/config/",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<CreateAutoscalingConfigResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateAutoscalingConfigResponse> CreateAutoscalingConfigWithOptionsAsync(string ClusterId, CreateAutoscalingConfigRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            ClusterId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CoolDownDuration))
            {
                body["cool_down_duration"] = request.CoolDownDuration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GpuUtilizationThreshold))
            {
                body["gpu_utilization_threshold"] = request.GpuUtilizationThreshold;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScanInterval))
            {
                body["scan_interval"] = request.ScanInterval;
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
                Pathname = "/cluster/" + ClusterId + "/autoscale/config/",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<CreateAutoscalingConfigResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateClusterResponse CreateCluster(CreateClusterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateClusterWithOptions(request, headers, runtime);
        }

        public async Task<CreateClusterResponse> CreateClusterAsync(CreateClusterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateClusterWithOptionsAsync(request, headers, runtime);
        }

        public CreateClusterResponse CreateClusterWithOptions(CreateClusterRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Addons))
            {
                body["addons"] = request.Addons;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApiAudiences))
            {
                body["api_audiences"] = request.ApiAudiences;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NumOfNodes))
            {
                body["num_of_nodes"] = request.NumOfNodes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OsType))
            {
                body["os_type"] = request.OsType;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Runtime.ToMap()))
            {
                body["runtime"] = request.Runtime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityGroupId))
            {
                body["security_group_id"] = request.SecurityGroupId;
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

        public async Task<CreateClusterResponse> CreateClusterWithOptionsAsync(CreateClusterRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Addons))
            {
                body["addons"] = request.Addons;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApiAudiences))
            {
                body["api_audiences"] = request.ApiAudiences;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NumOfNodes))
            {
                body["num_of_nodes"] = request.NumOfNodes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OsType))
            {
                body["os_type"] = request.OsType;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Runtime.ToMap()))
            {
                body["runtime"] = request.Runtime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityGroupId))
            {
                body["security_group_id"] = request.SecurityGroupId;
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

        public CreateClusterNodePoolResponse CreateClusterNodePool(string ClusterId, CreateClusterNodePoolRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateClusterNodePoolWithOptions(ClusterId, request, headers, runtime);
        }

        public async Task<CreateClusterNodePoolResponse> CreateClusterNodePoolAsync(string ClusterId, CreateClusterNodePoolRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateClusterNodePoolWithOptionsAsync(ClusterId, request, headers, runtime);
        }

        public CreateClusterNodePoolResponse CreateClusterNodePoolWithOptions(string ClusterId, CreateClusterNodePoolRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            ClusterId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoScaling.ToMap()))
            {
                body["auto_scaling"] = request.AutoScaling;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Count))
            {
                body["count"] = request.Count;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InterconnectConfig.ToMap()))
            {
                body["interconnect_config"] = request.InterconnectConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InterconnectMode))
            {
                body["interconnect_mode"] = request.InterconnectMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KubernetesConfig.ToMap()))
            {
                body["kubernetes_config"] = request.KubernetesConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Management.ToMap()))
            {
                body["management"] = request.Management;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxNodes))
            {
                body["max_nodes"] = request.MaxNodes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodepoolInfo.ToMap()))
            {
                body["nodepool_info"] = request.NodepoolInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScalingGroup.ToMap()))
            {
                body["scaling_group"] = request.ScalingGroup;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TeeConfig.ToMap()))
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
                Pathname = "/clusters/" + ClusterId + "/nodepools",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateClusterNodePoolResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateClusterNodePoolResponse> CreateClusterNodePoolWithOptionsAsync(string ClusterId, CreateClusterNodePoolRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            ClusterId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoScaling.ToMap()))
            {
                body["auto_scaling"] = request.AutoScaling;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Count))
            {
                body["count"] = request.Count;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InterconnectConfig.ToMap()))
            {
                body["interconnect_config"] = request.InterconnectConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InterconnectMode))
            {
                body["interconnect_mode"] = request.InterconnectMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KubernetesConfig.ToMap()))
            {
                body["kubernetes_config"] = request.KubernetesConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Management.ToMap()))
            {
                body["management"] = request.Management;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxNodes))
            {
                body["max_nodes"] = request.MaxNodes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodepoolInfo.ToMap()))
            {
                body["nodepool_info"] = request.NodepoolInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScalingGroup.ToMap()))
            {
                body["scaling_group"] = request.ScalingGroup;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TeeConfig.ToMap()))
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
                Pathname = "/clusters/" + ClusterId + "/nodepools",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateClusterNodePoolResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateEdgeMachineResponse CreateEdgeMachine(CreateEdgeMachineRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateEdgeMachineWithOptions(request, headers, runtime);
        }

        public async Task<CreateEdgeMachineResponse> CreateEdgeMachineAsync(CreateEdgeMachineRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateEdgeMachineWithOptionsAsync(request, headers, runtime);
        }

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

        public CreateKubernetesTriggerResponse CreateKubernetesTrigger(CreateKubernetesTriggerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateKubernetesTriggerWithOptions(request, headers, runtime);
        }

        public async Task<CreateKubernetesTriggerResponse> CreateKubernetesTriggerAsync(CreateKubernetesTriggerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateKubernetesTriggerWithOptionsAsync(request, headers, runtime);
        }

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

        public CreateTemplateResponse CreateTemplate(CreateTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateTemplateWithOptions(request, headers, runtime);
        }

        public async Task<CreateTemplateResponse> CreateTemplateAsync(CreateTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateTemplateWithOptionsAsync(request, headers, runtime);
        }

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

        public CreateTriggerResponse CreateTrigger(string clusterId, CreateTriggerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateTriggerWithOptions(clusterId, request, headers, runtime);
        }

        public async Task<CreateTriggerResponse> CreateTriggerAsync(string clusterId, CreateTriggerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateTriggerWithOptionsAsync(clusterId, request, headers, runtime);
        }

        public CreateTriggerResponse CreateTriggerWithOptions(string clusterId, CreateTriggerRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            clusterId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(clusterId);
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
                Pathname = "/clusters/" + clusterId + "/triggers",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateTriggerResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateTriggerResponse> CreateTriggerWithOptionsAsync(string clusterId, CreateTriggerRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            clusterId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(clusterId);
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
                Pathname = "/clusters/" + clusterId + "/triggers",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateTriggerResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DeleteAlertContactResponse DeleteAlertContact()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteAlertContactWithOptions(headers, runtime);
        }

        public async Task<DeleteAlertContactResponse> DeleteAlertContactAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteAlertContactWithOptionsAsync(headers, runtime);
        }

        public DeleteAlertContactResponse DeleteAlertContactWithOptions(Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
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
                BodyType = "none",
            };
            return TeaModel.ToObject<DeleteAlertContactResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeleteAlertContactResponse> DeleteAlertContactWithOptionsAsync(Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
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
                BodyType = "none",
            };
            return TeaModel.ToObject<DeleteAlertContactResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DeleteAlertContactGroupResponse DeleteAlertContactGroup()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteAlertContactGroupWithOptions(headers, runtime);
        }

        public async Task<DeleteAlertContactGroupResponse> DeleteAlertContactGroupAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteAlertContactGroupWithOptionsAsync(headers, runtime);
        }

        public DeleteAlertContactGroupResponse DeleteAlertContactGroupWithOptions(Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
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
                BodyType = "none",
            };
            return TeaModel.ToObject<DeleteAlertContactGroupResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeleteAlertContactGroupResponse> DeleteAlertContactGroupWithOptionsAsync(Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
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
                BodyType = "none",
            };
            return TeaModel.ToObject<DeleteAlertContactGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DeleteClusterResponse DeleteCluster(string ClusterId, DeleteClusterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteClusterWithOptions(ClusterId, request, headers, runtime);
        }

        public async Task<DeleteClusterResponse> DeleteClusterAsync(string ClusterId, DeleteClusterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteClusterWithOptionsAsync(ClusterId, request, headers, runtime);
        }

        public DeleteClusterResponse DeleteClusterWithOptions(string ClusterId, DeleteClusterRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ClusterId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId);
            DeleteClusterShrinkRequest request = new DeleteClusterShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.RetainResources))
            {
                request.RetainResourcesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.RetainResources, "retain_resources", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Pathname = "/clusters/" + ClusterId,
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<DeleteClusterResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeleteClusterResponse> DeleteClusterWithOptionsAsync(string ClusterId, DeleteClusterRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ClusterId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId);
            DeleteClusterShrinkRequest request = new DeleteClusterShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.RetainResources))
            {
                request.RetainResourcesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.RetainResources, "retain_resources", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Pathname = "/clusters/" + ClusterId,
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<DeleteClusterResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DeleteClusterNodepoolResponse DeleteClusterNodepool(string ClusterId, string NodepoolId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteClusterNodepoolWithOptions(ClusterId, NodepoolId, headers, runtime);
        }

        public async Task<DeleteClusterNodepoolResponse> DeleteClusterNodepoolAsync(string ClusterId, string NodepoolId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteClusterNodepoolWithOptionsAsync(ClusterId, NodepoolId, headers, runtime);
        }

        public DeleteClusterNodepoolResponse DeleteClusterNodepoolWithOptions(string ClusterId, string NodepoolId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            ClusterId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId);
            NodepoolId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(NodepoolId);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteClusterNodepool",
                Version = "2015-12-15",
                Protocol = "HTTPS",
                Pathname = "/clusters/" + ClusterId + "/nodepools/" + NodepoolId,
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteClusterNodepoolResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeleteClusterNodepoolResponse> DeleteClusterNodepoolWithOptionsAsync(string ClusterId, string NodepoolId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            ClusterId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId);
            NodepoolId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(NodepoolId);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteClusterNodepool",
                Version = "2015-12-15",
                Protocol = "HTTPS",
                Pathname = "/clusters/" + ClusterId + "/nodepools/" + NodepoolId,
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteClusterNodepoolResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DeleteClusterNodesResponse DeleteClusterNodes(string ClusterId, DeleteClusterNodesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteClusterNodesWithOptions(ClusterId, request, headers, runtime);
        }

        public async Task<DeleteClusterNodesResponse> DeleteClusterNodesAsync(string ClusterId, DeleteClusterNodesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteClusterNodesWithOptionsAsync(ClusterId, request, headers, runtime);
        }

        public DeleteClusterNodesResponse DeleteClusterNodesWithOptions(string ClusterId, DeleteClusterNodesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            ClusterId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId);
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
                Pathname = "/clusters/" + ClusterId + "/nodes",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteClusterNodesResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeleteClusterNodesResponse> DeleteClusterNodesWithOptionsAsync(string ClusterId, DeleteClusterNodesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            ClusterId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId);
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
                Pathname = "/clusters/" + ClusterId + "/nodes",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteClusterNodesResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DeleteEdgeMachineResponse DeleteEdgeMachine(string edgeMachineid, DeleteEdgeMachineRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteEdgeMachineWithOptions(edgeMachineid, request, headers, runtime);
        }

        public async Task<DeleteEdgeMachineResponse> DeleteEdgeMachineAsync(string edgeMachineid, DeleteEdgeMachineRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteEdgeMachineWithOptionsAsync(edgeMachineid, request, headers, runtime);
        }

        public DeleteEdgeMachineResponse DeleteEdgeMachineWithOptions(string edgeMachineid, DeleteEdgeMachineRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            edgeMachineid = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(edgeMachineid);
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
                Pathname = "/edge_machines/[edge_machineid]",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<DeleteEdgeMachineResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeleteEdgeMachineResponse> DeleteEdgeMachineWithOptionsAsync(string edgeMachineid, DeleteEdgeMachineRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            edgeMachineid = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(edgeMachineid);
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
                Pathname = "/edge_machines/[edge_machineid]",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<DeleteEdgeMachineResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DeleteKubernetesTriggerResponse DeleteKubernetesTrigger(string Id)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteKubernetesTriggerWithOptions(Id, headers, runtime);
        }

        public async Task<DeleteKubernetesTriggerResponse> DeleteKubernetesTriggerAsync(string Id)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteKubernetesTriggerWithOptionsAsync(Id, headers, runtime);
        }

        public DeleteKubernetesTriggerResponse DeleteKubernetesTriggerWithOptions(string Id, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Id = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(Id);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteKubernetesTrigger",
                Version = "2015-12-15",
                Protocol = "HTTPS",
                Pathname = "/triggers/revoke/" + Id,
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<DeleteKubernetesTriggerResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeleteKubernetesTriggerResponse> DeleteKubernetesTriggerWithOptionsAsync(string Id, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Id = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(Id);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteKubernetesTrigger",
                Version = "2015-12-15",
                Protocol = "HTTPS",
                Pathname = "/triggers/revoke/" + Id,
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<DeleteKubernetesTriggerResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DeletePolicyInstanceResponse DeletePolicyInstance(string clusterId, string policyName, DeletePolicyInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeletePolicyInstanceWithOptions(clusterId, policyName, request, headers, runtime);
        }

        public async Task<DeletePolicyInstanceResponse> DeletePolicyInstanceAsync(string clusterId, string policyName, DeletePolicyInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeletePolicyInstanceWithOptionsAsync(clusterId, policyName, request, headers, runtime);
        }

        public DeletePolicyInstanceResponse DeletePolicyInstanceWithOptions(string clusterId, string policyName, DeletePolicyInstanceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            clusterId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(clusterId);
            policyName = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(policyName);
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
                Pathname = "/clusters/" + clusterId + "/policies/" + policyName,
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeletePolicyInstanceResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeletePolicyInstanceResponse> DeletePolicyInstanceWithOptionsAsync(string clusterId, string policyName, DeletePolicyInstanceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            clusterId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(clusterId);
            policyName = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(policyName);
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
                Pathname = "/clusters/" + clusterId + "/policies/" + policyName,
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeletePolicyInstanceResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DeleteTemplateResponse DeleteTemplate(string TemplateId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteTemplateWithOptions(TemplateId, headers, runtime);
        }

        public async Task<DeleteTemplateResponse> DeleteTemplateAsync(string TemplateId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteTemplateWithOptionsAsync(TemplateId, headers, runtime);
        }

        public DeleteTemplateResponse DeleteTemplateWithOptions(string TemplateId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            TemplateId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(TemplateId);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteTemplate",
                Version = "2015-12-15",
                Protocol = "HTTPS",
                Pathname = "/templates/" + TemplateId,
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<DeleteTemplateResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeleteTemplateResponse> DeleteTemplateWithOptionsAsync(string TemplateId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            TemplateId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(TemplateId);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteTemplate",
                Version = "2015-12-15",
                Protocol = "HTTPS",
                Pathname = "/templates/" + TemplateId,
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<DeleteTemplateResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DeleteTriggerResponse DeleteTrigger(string clusterId, string Id)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteTriggerWithOptions(clusterId, Id, headers, runtime);
        }

        public async Task<DeleteTriggerResponse> DeleteTriggerAsync(string clusterId, string Id)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteTriggerWithOptionsAsync(clusterId, Id, headers, runtime);
        }

        public DeleteTriggerResponse DeleteTriggerWithOptions(string clusterId, string Id, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            clusterId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(clusterId);
            Id = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(Id);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteTrigger",
                Version = "2015-12-15",
                Protocol = "HTTPS",
                Pathname = "/clusters/[cluster_id]/triggers/[Id]",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<DeleteTriggerResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeleteTriggerResponse> DeleteTriggerWithOptionsAsync(string clusterId, string Id, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            clusterId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(clusterId);
            Id = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(Id);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteTrigger",
                Version = "2015-12-15",
                Protocol = "HTTPS",
                Pathname = "/clusters/[cluster_id]/triggers/[Id]",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<DeleteTriggerResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DeployPolicyInstanceResponse DeployPolicyInstance(string clusterId, string policyName, DeployPolicyInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeployPolicyInstanceWithOptions(clusterId, policyName, request, headers, runtime);
        }

        public async Task<DeployPolicyInstanceResponse> DeployPolicyInstanceAsync(string clusterId, string policyName, DeployPolicyInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeployPolicyInstanceWithOptionsAsync(clusterId, policyName, request, headers, runtime);
        }

        public DeployPolicyInstanceResponse DeployPolicyInstanceWithOptions(string clusterId, string policyName, DeployPolicyInstanceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            clusterId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(clusterId);
            policyName = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(policyName);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Action))
            {
                body["action"] = request.Action;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                body["namespace"] = request.Namespace;
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
                Pathname = "/clusters/" + clusterId + "/policies/" + policyName,
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeployPolicyInstanceResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeployPolicyInstanceResponse> DeployPolicyInstanceWithOptionsAsync(string clusterId, string policyName, DeployPolicyInstanceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            clusterId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(clusterId);
            policyName = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(policyName);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Action))
            {
                body["action"] = request.Action;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                body["namespace"] = request.Namespace;
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
                Pathname = "/clusters/" + clusterId + "/policies/" + policyName,
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeployPolicyInstanceResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescirbeWorkflowResponse DescirbeWorkflow(string workflowName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescirbeWorkflowWithOptions(workflowName, headers, runtime);
        }

        public async Task<DescirbeWorkflowResponse> DescirbeWorkflowAsync(string workflowName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescirbeWorkflowWithOptionsAsync(workflowName, headers, runtime);
        }

        public DescirbeWorkflowResponse DescirbeWorkflowWithOptions(string workflowName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            workflowName = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workflowName);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescirbeWorkflow",
                Version = "2015-12-15",
                Protocol = "HTTPS",
                Pathname = "/gs/workflow/" + workflowName,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescirbeWorkflowResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescirbeWorkflowResponse> DescirbeWorkflowWithOptionsAsync(string workflowName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            workflowName = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workflowName);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescirbeWorkflow",
                Version = "2015-12-15",
                Protocol = "HTTPS",
                Pathname = "/gs/workflow/" + workflowName,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescirbeWorkflowResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeAddonsResponse DescribeAddons(DescribeAddonsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeAddonsWithOptions(request, headers, runtime);
        }

        public async Task<DescribeAddonsResponse> DescribeAddonsAsync(DescribeAddonsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeAddonsWithOptionsAsync(request, headers, runtime);
        }

        public DescribeAddonsResponse DescribeAddonsWithOptions(DescribeAddonsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterType))
            {
                query["cluster_type"] = request.ClusterType;
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

        public async Task<DescribeAddonsResponse> DescribeAddonsWithOptionsAsync(DescribeAddonsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterType))
            {
                query["cluster_type"] = request.ClusterType;
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

        public DescribeClusterAddonMetadataResponse DescribeClusterAddonMetadata(string clusterId, string componentId, string version)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeClusterAddonMetadataWithOptions(clusterId, componentId, version, headers, runtime);
        }

        public async Task<DescribeClusterAddonMetadataResponse> DescribeClusterAddonMetadataAsync(string clusterId, string componentId, string version)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeClusterAddonMetadataWithOptionsAsync(clusterId, componentId, version, headers, runtime);
        }

        public DescribeClusterAddonMetadataResponse DescribeClusterAddonMetadataWithOptions(string clusterId, string componentId, string version, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            clusterId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(clusterId);
            componentId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(componentId);
            version = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(version);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeClusterAddonMetadata",
                Version = "2015-12-15",
                Protocol = "HTTPS",
                Pathname = "/clusters/" + clusterId + "/components/" + componentId + "/metadata",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeClusterAddonMetadataResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeClusterAddonMetadataResponse> DescribeClusterAddonMetadataWithOptionsAsync(string clusterId, string componentId, string version, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            clusterId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(clusterId);
            componentId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(componentId);
            version = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(version);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeClusterAddonMetadata",
                Version = "2015-12-15",
                Protocol = "HTTPS",
                Pathname = "/clusters/" + clusterId + "/components/" + componentId + "/metadata",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeClusterAddonMetadataResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeClusterAddonUpgradeStatusResponse DescribeClusterAddonUpgradeStatus(string ClusterId, string ComponentId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeClusterAddonUpgradeStatusWithOptions(ClusterId, ComponentId, headers, runtime);
        }

        public async Task<DescribeClusterAddonUpgradeStatusResponse> DescribeClusterAddonUpgradeStatusAsync(string ClusterId, string ComponentId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeClusterAddonUpgradeStatusWithOptionsAsync(ClusterId, ComponentId, headers, runtime);
        }

        public DescribeClusterAddonUpgradeStatusResponse DescribeClusterAddonUpgradeStatusWithOptions(string ClusterId, string ComponentId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            ClusterId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId);
            ComponentId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ComponentId);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeClusterAddonUpgradeStatus",
                Version = "2015-12-15",
                Protocol = "HTTPS",
                Pathname = "/clusters/" + ClusterId + "/components/" + ComponentId + "/upgradestatus",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeClusterAddonUpgradeStatusResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeClusterAddonUpgradeStatusResponse> DescribeClusterAddonUpgradeStatusWithOptionsAsync(string ClusterId, string ComponentId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            ClusterId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId);
            ComponentId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ComponentId);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeClusterAddonUpgradeStatus",
                Version = "2015-12-15",
                Protocol = "HTTPS",
                Pathname = "/clusters/" + ClusterId + "/components/" + ComponentId + "/upgradestatus",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeClusterAddonUpgradeStatusResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeClusterAddonsUpgradeStatusResponse DescribeClusterAddonsUpgradeStatus(string ClusterId, DescribeClusterAddonsUpgradeStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeClusterAddonsUpgradeStatusWithOptions(ClusterId, request, headers, runtime);
        }

        public async Task<DescribeClusterAddonsUpgradeStatusResponse> DescribeClusterAddonsUpgradeStatusAsync(string ClusterId, DescribeClusterAddonsUpgradeStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeClusterAddonsUpgradeStatusWithOptionsAsync(ClusterId, request, headers, runtime);
        }

        public DescribeClusterAddonsUpgradeStatusResponse DescribeClusterAddonsUpgradeStatusWithOptions(string ClusterId, DescribeClusterAddonsUpgradeStatusRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ClusterId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId);
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
                Pathname = "/clusters/" + ClusterId + "/components/upgradestatus",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeClusterAddonsUpgradeStatusResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeClusterAddonsUpgradeStatusResponse> DescribeClusterAddonsUpgradeStatusWithOptionsAsync(string ClusterId, DescribeClusterAddonsUpgradeStatusRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ClusterId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId);
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
                Pathname = "/clusters/" + ClusterId + "/components/upgradestatus",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeClusterAddonsUpgradeStatusResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeClusterAddonsVersionResponse DescribeClusterAddonsVersion(string ClusterId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeClusterAddonsVersionWithOptions(ClusterId, headers, runtime);
        }

        public async Task<DescribeClusterAddonsVersionResponse> DescribeClusterAddonsVersionAsync(string ClusterId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeClusterAddonsVersionWithOptionsAsync(ClusterId, headers, runtime);
        }

        public DescribeClusterAddonsVersionResponse DescribeClusterAddonsVersionWithOptions(string ClusterId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            ClusterId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeClusterAddonsVersion",
                Version = "2015-12-15",
                Protocol = "HTTPS",
                Pathname = "/clusters/" + ClusterId + "/components/version",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeClusterAddonsVersionResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeClusterAddonsVersionResponse> DescribeClusterAddonsVersionWithOptionsAsync(string ClusterId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            ClusterId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeClusterAddonsVersion",
                Version = "2015-12-15",
                Protocol = "HTTPS",
                Pathname = "/clusters/" + ClusterId + "/components/version",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeClusterAddonsVersionResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeClusterAttachScriptsResponse DescribeClusterAttachScripts(string ClusterId, DescribeClusterAttachScriptsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeClusterAttachScriptsWithOptions(ClusterId, request, headers, runtime);
        }

        public async Task<DescribeClusterAttachScriptsResponse> DescribeClusterAttachScriptsAsync(string ClusterId, DescribeClusterAttachScriptsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeClusterAttachScriptsWithOptionsAsync(ClusterId, request, headers, runtime);
        }

        public DescribeClusterAttachScriptsResponse DescribeClusterAttachScriptsWithOptions(string ClusterId, DescribeClusterAttachScriptsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            ClusterId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId);
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
                Pathname = "/clusters/" + ClusterId + "/attachscript",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "string",
            };
            return TeaModel.ToObject<DescribeClusterAttachScriptsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeClusterAttachScriptsResponse> DescribeClusterAttachScriptsWithOptionsAsync(string ClusterId, DescribeClusterAttachScriptsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            ClusterId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId);
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
                Pathname = "/clusters/" + ClusterId + "/attachscript",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "string",
            };
            return TeaModel.ToObject<DescribeClusterAttachScriptsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeClusterDetailResponse DescribeClusterDetail(string ClusterId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeClusterDetailWithOptions(ClusterId, headers, runtime);
        }

        public async Task<DescribeClusterDetailResponse> DescribeClusterDetailAsync(string ClusterId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeClusterDetailWithOptionsAsync(ClusterId, headers, runtime);
        }

        public DescribeClusterDetailResponse DescribeClusterDetailWithOptions(string ClusterId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            ClusterId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeClusterDetail",
                Version = "2015-12-15",
                Protocol = "HTTPS",
                Pathname = "/clusters/" + ClusterId,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeClusterDetailResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeClusterDetailResponse> DescribeClusterDetailWithOptionsAsync(string ClusterId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            ClusterId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeClusterDetail",
                Version = "2015-12-15",
                Protocol = "HTTPS",
                Pathname = "/clusters/" + ClusterId,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeClusterDetailResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeClusterLogsResponse DescribeClusterLogs(string ClusterId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeClusterLogsWithOptions(ClusterId, headers, runtime);
        }

        public async Task<DescribeClusterLogsResponse> DescribeClusterLogsAsync(string ClusterId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeClusterLogsWithOptionsAsync(ClusterId, headers, runtime);
        }

        public DescribeClusterLogsResponse DescribeClusterLogsWithOptions(string ClusterId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            ClusterId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeClusterLogs",
                Version = "2015-12-15",
                Protocol = "HTTPS",
                Pathname = "/clusters/" + ClusterId + "/logs",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "array",
            };
            return TeaModel.ToObject<DescribeClusterLogsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeClusterLogsResponse> DescribeClusterLogsWithOptionsAsync(string ClusterId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            ClusterId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeClusterLogs",
                Version = "2015-12-15",
                Protocol = "HTTPS",
                Pathname = "/clusters/" + ClusterId + "/logs",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "array",
            };
            return TeaModel.ToObject<DescribeClusterLogsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeClusterNamespacesResponse DescribeClusterNamespaces(string ClusterId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeClusterNamespacesWithOptions(ClusterId, headers, runtime);
        }

        public async Task<DescribeClusterNamespacesResponse> DescribeClusterNamespacesAsync(string ClusterId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeClusterNamespacesWithOptionsAsync(ClusterId, headers, runtime);
        }

        public DescribeClusterNamespacesResponse DescribeClusterNamespacesWithOptions(string ClusterId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            ClusterId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeClusterNamespaces",
                Version = "2015-12-15",
                Protocol = "HTTPS",
                Pathname = "/k8s/" + ClusterId + "/namespaces",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "array",
            };
            return TeaModel.ToObject<DescribeClusterNamespacesResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeClusterNamespacesResponse> DescribeClusterNamespacesWithOptionsAsync(string ClusterId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            ClusterId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeClusterNamespaces",
                Version = "2015-12-15",
                Protocol = "HTTPS",
                Pathname = "/k8s/" + ClusterId + "/namespaces",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "array",
            };
            return TeaModel.ToObject<DescribeClusterNamespacesResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeClusterNodePoolDetailResponse DescribeClusterNodePoolDetail(string ClusterId, string NodepoolId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeClusterNodePoolDetailWithOptions(ClusterId, NodepoolId, headers, runtime);
        }

        public async Task<DescribeClusterNodePoolDetailResponse> DescribeClusterNodePoolDetailAsync(string ClusterId, string NodepoolId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeClusterNodePoolDetailWithOptionsAsync(ClusterId, NodepoolId, headers, runtime);
        }

        public DescribeClusterNodePoolDetailResponse DescribeClusterNodePoolDetailWithOptions(string ClusterId, string NodepoolId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            ClusterId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId);
            NodepoolId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(NodepoolId);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeClusterNodePoolDetail",
                Version = "2015-12-15",
                Protocol = "HTTPS",
                Pathname = "/clusters/" + ClusterId + "/nodepools/" + NodepoolId,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeClusterNodePoolDetailResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeClusterNodePoolDetailResponse> DescribeClusterNodePoolDetailWithOptionsAsync(string ClusterId, string NodepoolId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            ClusterId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId);
            NodepoolId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(NodepoolId);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeClusterNodePoolDetail",
                Version = "2015-12-15",
                Protocol = "HTTPS",
                Pathname = "/clusters/" + ClusterId + "/nodepools/" + NodepoolId,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeClusterNodePoolDetailResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeClusterNodePoolsResponse DescribeClusterNodePools(string ClusterId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeClusterNodePoolsWithOptions(ClusterId, headers, runtime);
        }

        public async Task<DescribeClusterNodePoolsResponse> DescribeClusterNodePoolsAsync(string ClusterId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeClusterNodePoolsWithOptionsAsync(ClusterId, headers, runtime);
        }

        public DescribeClusterNodePoolsResponse DescribeClusterNodePoolsWithOptions(string ClusterId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            ClusterId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeClusterNodePools",
                Version = "2015-12-15",
                Protocol = "HTTPS",
                Pathname = "/clusters/" + ClusterId + "/nodepools",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeClusterNodePoolsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeClusterNodePoolsResponse> DescribeClusterNodePoolsWithOptionsAsync(string ClusterId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            ClusterId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeClusterNodePools",
                Version = "2015-12-15",
                Protocol = "HTTPS",
                Pathname = "/clusters/" + ClusterId + "/nodepools",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeClusterNodePoolsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeClusterNodesResponse DescribeClusterNodes(string ClusterId, DescribeClusterNodesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeClusterNodesWithOptions(ClusterId, request, headers, runtime);
        }

        public async Task<DescribeClusterNodesResponse> DescribeClusterNodesAsync(string ClusterId, DescribeClusterNodesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeClusterNodesWithOptionsAsync(ClusterId, request, headers, runtime);
        }

        public DescribeClusterNodesResponse DescribeClusterNodesWithOptions(string ClusterId, DescribeClusterNodesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            ClusterId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId);
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
                Pathname = "/clusters/" + ClusterId + "/nodes",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeClusterNodesResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeClusterNodesResponse> DescribeClusterNodesWithOptionsAsync(string ClusterId, DescribeClusterNodesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            ClusterId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId);
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
                Pathname = "/clusters/" + ClusterId + "/nodes",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeClusterNodesResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeClusterResourcesResponse DescribeClusterResources(string ClusterId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeClusterResourcesWithOptions(ClusterId, headers, runtime);
        }

        public async Task<DescribeClusterResourcesResponse> DescribeClusterResourcesAsync(string ClusterId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeClusterResourcesWithOptionsAsync(ClusterId, headers, runtime);
        }

        public DescribeClusterResourcesResponse DescribeClusterResourcesWithOptions(string ClusterId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            ClusterId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeClusterResources",
                Version = "2015-12-15",
                Protocol = "HTTPS",
                Pathname = "/clusters/" + ClusterId + "/resources",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "array",
            };
            return TeaModel.ToObject<DescribeClusterResourcesResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeClusterResourcesResponse> DescribeClusterResourcesWithOptionsAsync(string ClusterId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            ClusterId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeClusterResources",
                Version = "2015-12-15",
                Protocol = "HTTPS",
                Pathname = "/clusters/" + ClusterId + "/resources",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "array",
            };
            return TeaModel.ToObject<DescribeClusterResourcesResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeClusterUserKubeconfigResponse DescribeClusterUserKubeconfig(string ClusterId, DescribeClusterUserKubeconfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeClusterUserKubeconfigWithOptions(ClusterId, request, headers, runtime);
        }

        public async Task<DescribeClusterUserKubeconfigResponse> DescribeClusterUserKubeconfigAsync(string ClusterId, DescribeClusterUserKubeconfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeClusterUserKubeconfigWithOptionsAsync(ClusterId, request, headers, runtime);
        }

        public DescribeClusterUserKubeconfigResponse DescribeClusterUserKubeconfigWithOptions(string ClusterId, DescribeClusterUserKubeconfigRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            ClusterId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId);
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
                Pathname = "/k8s/" + ClusterId + "/user_config",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeClusterUserKubeconfigResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeClusterUserKubeconfigResponse> DescribeClusterUserKubeconfigWithOptionsAsync(string ClusterId, DescribeClusterUserKubeconfigRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            ClusterId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId);
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
                Pathname = "/k8s/" + ClusterId + "/user_config",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeClusterUserKubeconfigResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeClusterV2UserKubeconfigResponse DescribeClusterV2UserKubeconfig(string ClusterId, DescribeClusterV2UserKubeconfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeClusterV2UserKubeconfigWithOptions(ClusterId, request, headers, runtime);
        }

        public async Task<DescribeClusterV2UserKubeconfigResponse> DescribeClusterV2UserKubeconfigAsync(string ClusterId, DescribeClusterV2UserKubeconfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeClusterV2UserKubeconfigWithOptionsAsync(ClusterId, request, headers, runtime);
        }

        public DescribeClusterV2UserKubeconfigResponse DescribeClusterV2UserKubeconfigWithOptions(string ClusterId, DescribeClusterV2UserKubeconfigRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            ClusterId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId);
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
                Pathname = "/api/v2/k8s/" + ClusterId + "/user_config",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeClusterV2UserKubeconfigResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeClusterV2UserKubeconfigResponse> DescribeClusterV2UserKubeconfigWithOptionsAsync(string ClusterId, DescribeClusterV2UserKubeconfigRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            ClusterId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId);
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
                Pathname = "/api/v2/k8s/" + ClusterId + "/user_config",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeClusterV2UserKubeconfigResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeClustersResponse DescribeClusters(DescribeClustersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeClustersWithOptions(request, headers, runtime);
        }

        public async Task<DescribeClustersResponse> DescribeClustersAsync(DescribeClustersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeClustersWithOptionsAsync(request, headers, runtime);
        }

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

        public DescribeClustersV1Response DescribeClustersV1(DescribeClustersV1Request request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeClustersV1WithOptions(request, headers, runtime);
        }

        public async Task<DescribeClustersV1Response> DescribeClustersV1Async(DescribeClustersV1Request request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeClustersV1WithOptionsAsync(request, headers, runtime);
        }

        public DescribeClustersV1Response DescribeClustersV1WithOptions(DescribeClustersV1Request request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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

        public async Task<DescribeClustersV1Response> DescribeClustersV1WithOptionsAsync(DescribeClustersV1Request request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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

        public DescribeEdgeMachineActiveProcessResponse DescribeEdgeMachineActiveProcess(string edgeMachineid)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeEdgeMachineActiveProcessWithOptions(edgeMachineid, headers, runtime);
        }

        public async Task<DescribeEdgeMachineActiveProcessResponse> DescribeEdgeMachineActiveProcessAsync(string edgeMachineid)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeEdgeMachineActiveProcessWithOptionsAsync(edgeMachineid, headers, runtime);
        }

        public DescribeEdgeMachineActiveProcessResponse DescribeEdgeMachineActiveProcessWithOptions(string edgeMachineid, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            edgeMachineid = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(edgeMachineid);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeEdgeMachineActiveProcess",
                Version = "2015-12-15",
                Protocol = "HTTPS",
                Pathname = "/edge_machines/[edge_machineid]/activeprocess",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeEdgeMachineActiveProcessResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeEdgeMachineActiveProcessResponse> DescribeEdgeMachineActiveProcessWithOptionsAsync(string edgeMachineid, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            edgeMachineid = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(edgeMachineid);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeEdgeMachineActiveProcess",
                Version = "2015-12-15",
                Protocol = "HTTPS",
                Pathname = "/edge_machines/[edge_machineid]/activeprocess",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeEdgeMachineActiveProcessResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeEdgeMachineModelsResponse DescribeEdgeMachineModels()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeEdgeMachineModelsWithOptions(headers, runtime);
        }

        public async Task<DescribeEdgeMachineModelsResponse> DescribeEdgeMachineModelsAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeEdgeMachineModelsWithOptionsAsync(headers, runtime);
        }

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

        public DescribeEdgeMachineTunnelConfigDetailResponse DescribeEdgeMachineTunnelConfigDetail(string edgeMachineid)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeEdgeMachineTunnelConfigDetailWithOptions(edgeMachineid, headers, runtime);
        }

        public async Task<DescribeEdgeMachineTunnelConfigDetailResponse> DescribeEdgeMachineTunnelConfigDetailAsync(string edgeMachineid)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeEdgeMachineTunnelConfigDetailWithOptionsAsync(edgeMachineid, headers, runtime);
        }

        public DescribeEdgeMachineTunnelConfigDetailResponse DescribeEdgeMachineTunnelConfigDetailWithOptions(string edgeMachineid, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            edgeMachineid = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(edgeMachineid);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeEdgeMachineTunnelConfigDetail",
                Version = "2015-12-15",
                Protocol = "HTTPS",
                Pathname = "/edge_machines/[edge_machineid]/tunnelconfig",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeEdgeMachineTunnelConfigDetailResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeEdgeMachineTunnelConfigDetailResponse> DescribeEdgeMachineTunnelConfigDetailWithOptionsAsync(string edgeMachineid, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            edgeMachineid = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(edgeMachineid);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeEdgeMachineTunnelConfigDetail",
                Version = "2015-12-15",
                Protocol = "HTTPS",
                Pathname = "/edge_machines/[edge_machineid]/tunnelconfig",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeEdgeMachineTunnelConfigDetailResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeEdgeMachinesResponse DescribeEdgeMachines(DescribeEdgeMachinesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeEdgeMachinesWithOptions(request, headers, runtime);
        }

        public async Task<DescribeEdgeMachinesResponse> DescribeEdgeMachinesAsync(DescribeEdgeMachinesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeEdgeMachinesWithOptionsAsync(request, headers, runtime);
        }

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

        public DescribeEventsResponse DescribeEvents(DescribeEventsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeEventsWithOptions(request, headers, runtime);
        }

        public async Task<DescribeEventsResponse> DescribeEventsAsync(DescribeEventsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeEventsWithOptionsAsync(request, headers, runtime);
        }

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

        public DescribeExternalAgentResponse DescribeExternalAgent(string ClusterId, DescribeExternalAgentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeExternalAgentWithOptions(ClusterId, request, headers, runtime);
        }

        public async Task<DescribeExternalAgentResponse> DescribeExternalAgentAsync(string ClusterId, DescribeExternalAgentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeExternalAgentWithOptionsAsync(ClusterId, request, headers, runtime);
        }

        public DescribeExternalAgentResponse DescribeExternalAgentWithOptions(string ClusterId, DescribeExternalAgentRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            ClusterId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId);
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
                Action = "DescribeExternalAgent",
                Version = "2015-12-15",
                Protocol = "HTTPS",
                Pathname = "/k8s/" + ClusterId + "/external/agent/deployment",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeExternalAgentResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeExternalAgentResponse> DescribeExternalAgentWithOptionsAsync(string ClusterId, DescribeExternalAgentRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            ClusterId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId);
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
                Action = "DescribeExternalAgent",
                Version = "2015-12-15",
                Protocol = "HTTPS",
                Pathname = "/k8s/" + ClusterId + "/external/agent/deployment",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeExternalAgentResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeKubernetesVersionMetadataResponse DescribeKubernetesVersionMetadata(DescribeKubernetesVersionMetadataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeKubernetesVersionMetadataWithOptions(request, headers, runtime);
        }

        public async Task<DescribeKubernetesVersionMetadataResponse> DescribeKubernetesVersionMetadataAsync(DescribeKubernetesVersionMetadataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeKubernetesVersionMetadataWithOptionsAsync(request, headers, runtime);
        }

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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Profile))
            {
                query["Profile"] = request.Profile;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                query["Region"] = request.Region;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Profile))
            {
                query["Profile"] = request.Profile;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                query["Region"] = request.Region;
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

        public DescribePoliciesResponse DescribePolicies()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribePoliciesWithOptions(headers, runtime);
        }

        public async Task<DescribePoliciesResponse> DescribePoliciesAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribePoliciesWithOptionsAsync(headers, runtime);
        }

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

        public DescribePolicyDetailsResponse DescribePolicyDetails(string policyName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribePolicyDetailsWithOptions(policyName, headers, runtime);
        }

        public async Task<DescribePolicyDetailsResponse> DescribePolicyDetailsAsync(string policyName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribePolicyDetailsWithOptionsAsync(policyName, headers, runtime);
        }

        public DescribePolicyDetailsResponse DescribePolicyDetailsWithOptions(string policyName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            policyName = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(policyName);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribePolicyDetails",
                Version = "2015-12-15",
                Protocol = "HTTPS",
                Pathname = "/policies/" + policyName,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribePolicyDetailsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribePolicyDetailsResponse> DescribePolicyDetailsWithOptionsAsync(string policyName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            policyName = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(policyName);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribePolicyDetails",
                Version = "2015-12-15",
                Protocol = "HTTPS",
                Pathname = "/policies/" + policyName,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribePolicyDetailsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribePolicyGovernanceInClusterResponse DescribePolicyGovernanceInCluster(string clusterId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribePolicyGovernanceInClusterWithOptions(clusterId, headers, runtime);
        }

        public async Task<DescribePolicyGovernanceInClusterResponse> DescribePolicyGovernanceInClusterAsync(string clusterId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribePolicyGovernanceInClusterWithOptionsAsync(clusterId, headers, runtime);
        }

        public DescribePolicyGovernanceInClusterResponse DescribePolicyGovernanceInClusterWithOptions(string clusterId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            clusterId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(clusterId);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribePolicyGovernanceInCluster",
                Version = "2015-12-15",
                Protocol = "HTTPS",
                Pathname = "/clusters/" + clusterId + "/policygovernance",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribePolicyGovernanceInClusterResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribePolicyGovernanceInClusterResponse> DescribePolicyGovernanceInClusterWithOptionsAsync(string clusterId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            clusterId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(clusterId);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribePolicyGovernanceInCluster",
                Version = "2015-12-15",
                Protocol = "HTTPS",
                Pathname = "/clusters/" + clusterId + "/policygovernance",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribePolicyGovernanceInClusterResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribePolicyInstancesResponse DescribePolicyInstances(string clusterId, DescribePolicyInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribePolicyInstancesWithOptions(clusterId, request, headers, runtime);
        }

        public async Task<DescribePolicyInstancesResponse> DescribePolicyInstancesAsync(string clusterId, DescribePolicyInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribePolicyInstancesWithOptionsAsync(clusterId, request, headers, runtime);
        }

        public DescribePolicyInstancesResponse DescribePolicyInstancesWithOptions(string clusterId, DescribePolicyInstancesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            clusterId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(clusterId);
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
                Pathname = "/clusters/" + clusterId + "/policies",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "array",
            };
            return TeaModel.ToObject<DescribePolicyInstancesResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribePolicyInstancesResponse> DescribePolicyInstancesWithOptionsAsync(string clusterId, DescribePolicyInstancesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            clusterId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(clusterId);
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
                Pathname = "/clusters/" + clusterId + "/policies",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "array",
            };
            return TeaModel.ToObject<DescribePolicyInstancesResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribePolicyInstancesStatusResponse DescribePolicyInstancesStatus(string clusterId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribePolicyInstancesStatusWithOptions(clusterId, headers, runtime);
        }

        public async Task<DescribePolicyInstancesStatusResponse> DescribePolicyInstancesStatusAsync(string clusterId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribePolicyInstancesStatusWithOptionsAsync(clusterId, headers, runtime);
        }

        public DescribePolicyInstancesStatusResponse DescribePolicyInstancesStatusWithOptions(string clusterId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            clusterId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(clusterId);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribePolicyInstancesStatus",
                Version = "2015-12-15",
                Protocol = "HTTPS",
                Pathname = "/clusters/" + clusterId + "/policies/status",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribePolicyInstancesStatusResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribePolicyInstancesStatusResponse> DescribePolicyInstancesStatusWithOptionsAsync(string clusterId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            clusterId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(clusterId);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribePolicyInstancesStatus",
                Version = "2015-12-15",
                Protocol = "HTTPS",
                Pathname = "/clusters/" + clusterId + "/policies/status",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribePolicyInstancesStatusResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeTaskInfoResponse DescribeTaskInfo(string taskId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeTaskInfoWithOptions(taskId, headers, runtime);
        }

        public async Task<DescribeTaskInfoResponse> DescribeTaskInfoAsync(string taskId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeTaskInfoWithOptionsAsync(taskId, headers, runtime);
        }

        public DescribeTaskInfoResponse DescribeTaskInfoWithOptions(string taskId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            taskId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(taskId);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeTaskInfo",
                Version = "2015-12-15",
                Protocol = "HTTPS",
                Pathname = "/tasks/" + taskId,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeTaskInfoResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeTaskInfoResponse> DescribeTaskInfoWithOptionsAsync(string taskId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            taskId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(taskId);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeTaskInfo",
                Version = "2015-12-15",
                Protocol = "HTTPS",
                Pathname = "/tasks/" + taskId,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeTaskInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeTemplateAttributeResponse DescribeTemplateAttribute(string TemplateId, DescribeTemplateAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeTemplateAttributeWithOptions(TemplateId, request, headers, runtime);
        }

        public async Task<DescribeTemplateAttributeResponse> DescribeTemplateAttributeAsync(string TemplateId, DescribeTemplateAttributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeTemplateAttributeWithOptionsAsync(TemplateId, request, headers, runtime);
        }

        public DescribeTemplateAttributeResponse DescribeTemplateAttributeWithOptions(string TemplateId, DescribeTemplateAttributeRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            TemplateId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(TemplateId);
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
                Pathname = "/templates/" + TemplateId,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "array",
            };
            return TeaModel.ToObject<DescribeTemplateAttributeResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeTemplateAttributeResponse> DescribeTemplateAttributeWithOptionsAsync(string TemplateId, DescribeTemplateAttributeRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            TemplateId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(TemplateId);
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
                Pathname = "/templates/" + TemplateId,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "array",
            };
            return TeaModel.ToObject<DescribeTemplateAttributeResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeTemplatesResponse DescribeTemplates(DescribeTemplatesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeTemplatesWithOptions(request, headers, runtime);
        }

        public async Task<DescribeTemplatesResponse> DescribeTemplatesAsync(DescribeTemplatesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeTemplatesWithOptionsAsync(request, headers, runtime);
        }

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

        public DescribeTriggerResponse DescribeTrigger(string clusterId, DescribeTriggerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeTriggerWithOptions(clusterId, request, headers, runtime);
        }

        public async Task<DescribeTriggerResponse> DescribeTriggerAsync(string clusterId, DescribeTriggerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeTriggerWithOptionsAsync(clusterId, request, headers, runtime);
        }

        public DescribeTriggerResponse DescribeTriggerWithOptions(string clusterId, DescribeTriggerRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            clusterId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(clusterId);
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
                Pathname = "/clusters/[cluster_id]/triggers",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "array",
            };
            return TeaModel.ToObject<DescribeTriggerResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeTriggerResponse> DescribeTriggerWithOptionsAsync(string clusterId, DescribeTriggerRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            clusterId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(clusterId);
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
                Pathname = "/clusters/[cluster_id]/triggers",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "array",
            };
            return TeaModel.ToObject<DescribeTriggerResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeUserPermissionResponse DescribeUserPermission(string uid)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeUserPermissionWithOptions(uid, headers, runtime);
        }

        public async Task<DescribeUserPermissionResponse> DescribeUserPermissionAsync(string uid)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeUserPermissionWithOptionsAsync(uid, headers, runtime);
        }

        public DescribeUserPermissionResponse DescribeUserPermissionWithOptions(string uid, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            uid = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(uid);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeUserPermission",
                Version = "2015-12-15",
                Protocol = "HTTPS",
                Pathname = "/permissions/users/" + uid,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "array",
            };
            return TeaModel.ToObject<DescribeUserPermissionResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeUserPermissionResponse> DescribeUserPermissionWithOptionsAsync(string uid, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            uid = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(uid);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeUserPermission",
                Version = "2015-12-15",
                Protocol = "HTTPS",
                Pathname = "/permissions/users/" + uid,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "array",
            };
            return TeaModel.ToObject<DescribeUserPermissionResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeUserQuotaResponse DescribeUserQuota()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeUserQuotaWithOptions(headers, runtime);
        }

        public async Task<DescribeUserQuotaResponse> DescribeUserQuotaAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeUserQuotaWithOptionsAsync(headers, runtime);
        }

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

        public DescribeWorkflowsResponse DescribeWorkflows()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeWorkflowsWithOptions(headers, runtime);
        }

        public async Task<DescribeWorkflowsResponse> DescribeWorkflowsAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeWorkflowsWithOptionsAsync(headers, runtime);
        }

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

        public EdgeClusterAddEdgeMachineResponse EdgeClusterAddEdgeMachine(string clusterid, string edgeMachineid, EdgeClusterAddEdgeMachineRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return EdgeClusterAddEdgeMachineWithOptions(clusterid, edgeMachineid, request, headers, runtime);
        }

        public async Task<EdgeClusterAddEdgeMachineResponse> EdgeClusterAddEdgeMachineAsync(string clusterid, string edgeMachineid, EdgeClusterAddEdgeMachineRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await EdgeClusterAddEdgeMachineWithOptionsAsync(clusterid, edgeMachineid, request, headers, runtime);
        }

        public EdgeClusterAddEdgeMachineResponse EdgeClusterAddEdgeMachineWithOptions(string clusterid, string edgeMachineid, EdgeClusterAddEdgeMachineRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            clusterid = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(clusterid);
            edgeMachineid = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(edgeMachineid);
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
                Pathname = "/clusters/[clusterid]/attachedgemachine/[edge_machineid]",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<EdgeClusterAddEdgeMachineResponse>(CallApi(params_, req, runtime));
        }

        public async Task<EdgeClusterAddEdgeMachineResponse> EdgeClusterAddEdgeMachineWithOptionsAsync(string clusterid, string edgeMachineid, EdgeClusterAddEdgeMachineRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            clusterid = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(clusterid);
            edgeMachineid = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(edgeMachineid);
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
                Pathname = "/clusters/[clusterid]/attachedgemachine/[edge_machineid]",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<EdgeClusterAddEdgeMachineResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetKubernetesTriggerResponse GetKubernetesTrigger(string ClusterId, GetKubernetesTriggerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetKubernetesTriggerWithOptions(ClusterId, request, headers, runtime);
        }

        public async Task<GetKubernetesTriggerResponse> GetKubernetesTriggerAsync(string ClusterId, GetKubernetesTriggerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetKubernetesTriggerWithOptionsAsync(ClusterId, request, headers, runtime);
        }

        public GetKubernetesTriggerResponse GetKubernetesTriggerWithOptions(string ClusterId, GetKubernetesTriggerRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            ClusterId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId);
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
                Pathname = "/triggers/" + ClusterId,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "array",
            };
            return TeaModel.ToObject<GetKubernetesTriggerResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetKubernetesTriggerResponse> GetKubernetesTriggerWithOptionsAsync(string ClusterId, GetKubernetesTriggerRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            ClusterId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId);
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
                Pathname = "/triggers/" + ClusterId,
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "array",
            };
            return TeaModel.ToObject<GetKubernetesTriggerResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetUpgradeStatusResponse GetUpgradeStatus(string ClusterId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetUpgradeStatusWithOptions(ClusterId, headers, runtime);
        }

        public async Task<GetUpgradeStatusResponse> GetUpgradeStatusAsync(string ClusterId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetUpgradeStatusWithOptionsAsync(ClusterId, headers, runtime);
        }

        public GetUpgradeStatusResponse GetUpgradeStatusWithOptions(string ClusterId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            ClusterId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetUpgradeStatus",
                Version = "2015-12-15",
                Protocol = "HTTPS",
                Pathname = "/api/v2/clusters/" + ClusterId + "/upgrade/status",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetUpgradeStatusResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetUpgradeStatusResponse> GetUpgradeStatusWithOptionsAsync(string ClusterId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            ClusterId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetUpgradeStatus",
                Version = "2015-12-15",
                Protocol = "HTTPS",
                Pathname = "/api/v2/clusters/" + ClusterId + "/upgrade/status",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetUpgradeStatusResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GrantPermissionsResponse GrantPermissions(string uid, GrantPermissionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GrantPermissionsWithOptions(uid, request, headers, runtime);
        }

        public async Task<GrantPermissionsResponse> GrantPermissionsAsync(string uid, GrantPermissionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GrantPermissionsWithOptionsAsync(uid, request, headers, runtime);
        }

        public GrantPermissionsResponse GrantPermissionsWithOptions(string uid, GrantPermissionsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            uid = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(uid);
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
                Pathname = "/permissions/users/" + uid,
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<GrantPermissionsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GrantPermissionsResponse> GrantPermissionsWithOptionsAsync(string uid, GrantPermissionsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            uid = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(uid);
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
                Pathname = "/permissions/users/" + uid,
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<GrantPermissionsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public InstallClusterAddonsResponse InstallClusterAddons(string ClusterId, InstallClusterAddonsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return InstallClusterAddonsWithOptions(ClusterId, request, headers, runtime);
        }

        public async Task<InstallClusterAddonsResponse> InstallClusterAddonsAsync(string ClusterId, InstallClusterAddonsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await InstallClusterAddonsWithOptionsAsync(ClusterId, request, headers, runtime);
        }

        public InstallClusterAddonsResponse InstallClusterAddonsWithOptions(string ClusterId, InstallClusterAddonsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            ClusterId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId);
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
                Pathname = "/clusters/" + ClusterId + "/components/install",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<InstallClusterAddonsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<InstallClusterAddonsResponse> InstallClusterAddonsWithOptionsAsync(string ClusterId, InstallClusterAddonsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            ClusterId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId);
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
                Pathname = "/clusters/" + ClusterId + "/components/install",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<InstallClusterAddonsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListTagResourcesResponse ListTagResources(ListTagResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListTagResourcesWithOptions(request, headers, runtime);
        }

        public async Task<ListTagResourcesResponse> ListTagResourcesAsync(ListTagResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListTagResourcesWithOptionsAsync(request, headers, runtime);
        }

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

        public MigrateClusterResponse MigrateCluster(string clusterId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return MigrateClusterWithOptions(clusterId, headers, runtime);
        }

        public async Task<MigrateClusterResponse> MigrateClusterAsync(string clusterId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await MigrateClusterWithOptionsAsync(clusterId, headers, runtime);
        }

        public MigrateClusterResponse MigrateClusterWithOptions(string clusterId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            clusterId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(clusterId);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "MigrateCluster",
                Version = "2015-12-15",
                Protocol = "HTTPS",
                Pathname = "/clusters/" + clusterId + "/migrate",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<MigrateClusterResponse>(CallApi(params_, req, runtime));
        }

        public async Task<MigrateClusterResponse> MigrateClusterWithOptionsAsync(string clusterId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            clusterId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(clusterId);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "MigrateCluster",
                Version = "2015-12-15",
                Protocol = "HTTPS",
                Pathname = "/clusters/" + clusterId + "/migrate",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<MigrateClusterResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ModifyClusterResponse ModifyCluster(string ClusterId, ModifyClusterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ModifyClusterWithOptions(ClusterId, request, headers, runtime);
        }

        public async Task<ModifyClusterResponse> ModifyClusterAsync(string ClusterId, ModifyClusterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ModifyClusterWithOptionsAsync(ClusterId, request, headers, runtime);
        }

        public ModifyClusterResponse ModifyClusterWithOptions(string ClusterId, ModifyClusterRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            ClusterId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApiServerEip))
            {
                body["api_server_eip"] = request.ApiServerEip;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApiServerEipId))
            {
                body["api_server_eip_id"] = request.ApiServerEipId;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaintenanceWindow.ToMap()))
            {
                body["maintenance_window"] = request.MaintenanceWindow;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                body["resource_group_id"] = request.ResourceGroupId;
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
                Pathname = "/api/v2/clusters/" + ClusterId,
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyClusterResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ModifyClusterResponse> ModifyClusterWithOptionsAsync(string ClusterId, ModifyClusterRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            ClusterId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApiServerEip))
            {
                body["api_server_eip"] = request.ApiServerEip;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApiServerEipId))
            {
                body["api_server_eip_id"] = request.ApiServerEipId;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaintenanceWindow.ToMap()))
            {
                body["maintenance_window"] = request.MaintenanceWindow;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                body["resource_group_id"] = request.ResourceGroupId;
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
                Pathname = "/api/v2/clusters/" + ClusterId,
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyClusterResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ModifyClusterAddonResponse ModifyClusterAddon(string clusterId, string componentId, ModifyClusterAddonRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ModifyClusterAddonWithOptions(clusterId, componentId, request, headers, runtime);
        }

        public async Task<ModifyClusterAddonResponse> ModifyClusterAddonAsync(string clusterId, string componentId, ModifyClusterAddonRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ModifyClusterAddonWithOptionsAsync(clusterId, componentId, request, headers, runtime);
        }

        public ModifyClusterAddonResponse ModifyClusterAddonWithOptions(string clusterId, string componentId, ModifyClusterAddonRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            clusterId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(clusterId);
            componentId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(componentId);
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
                Pathname = "/clusters/" + clusterId + "/components/" + componentId + "/config",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<ModifyClusterAddonResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ModifyClusterAddonResponse> ModifyClusterAddonWithOptionsAsync(string clusterId, string componentId, ModifyClusterAddonRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            clusterId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(clusterId);
            componentId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(componentId);
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
                Pathname = "/clusters/" + clusterId + "/components/" + componentId + "/config",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<ModifyClusterAddonResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ModifyClusterConfigurationResponse ModifyClusterConfiguration(string ClusterId, ModifyClusterConfigurationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ModifyClusterConfigurationWithOptions(ClusterId, request, headers, runtime);
        }

        public async Task<ModifyClusterConfigurationResponse> ModifyClusterConfigurationAsync(string ClusterId, ModifyClusterConfigurationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ModifyClusterConfigurationWithOptionsAsync(ClusterId, request, headers, runtime);
        }

        public ModifyClusterConfigurationResponse ModifyClusterConfigurationWithOptions(string ClusterId, ModifyClusterConfigurationRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            ClusterId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId);
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
                Pathname = "/clusters/" + ClusterId + "/configuration",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<ModifyClusterConfigurationResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ModifyClusterConfigurationResponse> ModifyClusterConfigurationWithOptionsAsync(string ClusterId, ModifyClusterConfigurationRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            ClusterId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId);
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
                Pathname = "/clusters/" + ClusterId + "/configuration",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<ModifyClusterConfigurationResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ModifyClusterNodePoolResponse ModifyClusterNodePool(string ClusterId, string NodepoolId, ModifyClusterNodePoolRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ModifyClusterNodePoolWithOptions(ClusterId, NodepoolId, request, headers, runtime);
        }

        public async Task<ModifyClusterNodePoolResponse> ModifyClusterNodePoolAsync(string ClusterId, string NodepoolId, ModifyClusterNodePoolRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ModifyClusterNodePoolWithOptionsAsync(ClusterId, NodepoolId, request, headers, runtime);
        }

        public ModifyClusterNodePoolResponse ModifyClusterNodePoolWithOptions(string ClusterId, string NodepoolId, ModifyClusterNodePoolRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            ClusterId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId);
            NodepoolId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(NodepoolId);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoScaling.ToMap()))
            {
                body["auto_scaling"] = request.AutoScaling;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KubernetesConfig.ToMap()))
            {
                body["kubernetes_config"] = request.KubernetesConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Management.ToMap()))
            {
                body["management"] = request.Management;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodepoolInfo.ToMap()))
            {
                body["nodepool_info"] = request.NodepoolInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScalingGroup.ToMap()))
            {
                body["scaling_group"] = request.ScalingGroup;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TeeConfig.ToMap()))
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
                Pathname = "/clusters/" + ClusterId + "/nodepools/" + NodepoolId,
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyClusterNodePoolResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ModifyClusterNodePoolResponse> ModifyClusterNodePoolWithOptionsAsync(string ClusterId, string NodepoolId, ModifyClusterNodePoolRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            ClusterId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId);
            NodepoolId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(NodepoolId);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoScaling.ToMap()))
            {
                body["auto_scaling"] = request.AutoScaling;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KubernetesConfig.ToMap()))
            {
                body["kubernetes_config"] = request.KubernetesConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Management.ToMap()))
            {
                body["management"] = request.Management;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodepoolInfo.ToMap()))
            {
                body["nodepool_info"] = request.NodepoolInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScalingGroup.ToMap()))
            {
                body["scaling_group"] = request.ScalingGroup;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TeeConfig.ToMap()))
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
                Pathname = "/clusters/" + ClusterId + "/nodepools/" + NodepoolId,
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyClusterNodePoolResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ModifyClusterTagsResponse ModifyClusterTags(string ClusterId, ModifyClusterTagsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ModifyClusterTagsWithOptions(ClusterId, request, headers, runtime);
        }

        public async Task<ModifyClusterTagsResponse> ModifyClusterTagsAsync(string ClusterId, ModifyClusterTagsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ModifyClusterTagsWithOptionsAsync(ClusterId, request, headers, runtime);
        }

        public ModifyClusterTagsResponse ModifyClusterTagsWithOptions(string ClusterId, ModifyClusterTagsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            ClusterId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId);
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
                Pathname = "/clusters/" + ClusterId + "/tags",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<ModifyClusterTagsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ModifyClusterTagsResponse> ModifyClusterTagsWithOptionsAsync(string ClusterId, ModifyClusterTagsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            ClusterId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId);
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
                Pathname = "/clusters/" + ClusterId + "/tags",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<ModifyClusterTagsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ModifyPolicyInstanceResponse ModifyPolicyInstance(string clusterId, string policyName, ModifyPolicyInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ModifyPolicyInstanceWithOptions(clusterId, policyName, request, headers, runtime);
        }

        public async Task<ModifyPolicyInstanceResponse> ModifyPolicyInstanceAsync(string clusterId, string policyName, ModifyPolicyInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ModifyPolicyInstanceWithOptionsAsync(clusterId, policyName, request, headers, runtime);
        }

        public ModifyPolicyInstanceResponse ModifyPolicyInstanceWithOptions(string clusterId, string policyName, ModifyPolicyInstanceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            clusterId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(clusterId);
            policyName = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(policyName);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Action))
            {
                body["action"] = request.Action;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceName))
            {
                body["instance_name"] = request.InstanceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                body["namespace"] = request.Namespace;
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
                Pathname = "/clusters/" + clusterId + "/policies/" + policyName,
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyPolicyInstanceResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ModifyPolicyInstanceResponse> ModifyPolicyInstanceWithOptionsAsync(string clusterId, string policyName, ModifyPolicyInstanceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            clusterId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(clusterId);
            policyName = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(policyName);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Action))
            {
                body["action"] = request.Action;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceName))
            {
                body["instance_name"] = request.InstanceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                body["namespace"] = request.Namespace;
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
                Pathname = "/clusters/" + clusterId + "/policies/" + policyName,
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyPolicyInstanceResponse>(await CallApiAsync(params_, req, runtime));
        }

        public OpenAckServiceResponse OpenAckService(OpenAckServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return OpenAckServiceWithOptions(request, headers, runtime);
        }

        public async Task<OpenAckServiceResponse> OpenAckServiceAsync(OpenAckServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await OpenAckServiceWithOptionsAsync(request, headers, runtime);
        }

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

        public PauseClusterUpgradeResponse PauseClusterUpgrade(string ClusterId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return PauseClusterUpgradeWithOptions(ClusterId, headers, runtime);
        }

        public async Task<PauseClusterUpgradeResponse> PauseClusterUpgradeAsync(string ClusterId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await PauseClusterUpgradeWithOptionsAsync(ClusterId, headers, runtime);
        }

        public PauseClusterUpgradeResponse PauseClusterUpgradeWithOptions(string ClusterId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            ClusterId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PauseClusterUpgrade",
                Version = "2015-12-15",
                Protocol = "HTTPS",
                Pathname = "/api/v2/clusters/" + ClusterId + "/upgrade/pause",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<PauseClusterUpgradeResponse>(CallApi(params_, req, runtime));
        }

        public async Task<PauseClusterUpgradeResponse> PauseClusterUpgradeWithOptionsAsync(string ClusterId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            ClusterId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PauseClusterUpgrade",
                Version = "2015-12-15",
                Protocol = "HTTPS",
                Pathname = "/api/v2/clusters/" + ClusterId + "/upgrade/pause",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<PauseClusterUpgradeResponse>(await CallApiAsync(params_, req, runtime));
        }

        public PauseComponentUpgradeResponse PauseComponentUpgrade(string clusterid, string componentid)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return PauseComponentUpgradeWithOptions(clusterid, componentid, headers, runtime);
        }

        public async Task<PauseComponentUpgradeResponse> PauseComponentUpgradeAsync(string clusterid, string componentid)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await PauseComponentUpgradeWithOptionsAsync(clusterid, componentid, headers, runtime);
        }

        public PauseComponentUpgradeResponse PauseComponentUpgradeWithOptions(string clusterid, string componentid, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            clusterid = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(clusterid);
            componentid = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(componentid);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PauseComponentUpgrade",
                Version = "2015-12-15",
                Protocol = "HTTPS",
                Pathname = "/clusters/" + clusterid + "/components/" + componentid + "/pause",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<PauseComponentUpgradeResponse>(CallApi(params_, req, runtime));
        }

        public async Task<PauseComponentUpgradeResponse> PauseComponentUpgradeWithOptionsAsync(string clusterid, string componentid, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            clusterid = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(clusterid);
            componentid = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(componentid);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PauseComponentUpgrade",
                Version = "2015-12-15",
                Protocol = "HTTPS",
                Pathname = "/clusters/" + clusterid + "/components/" + componentid + "/pause",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<PauseComponentUpgradeResponse>(await CallApiAsync(params_, req, runtime));
        }

        public RemoveClusterNodesResponse RemoveClusterNodes(string ClusterId, RemoveClusterNodesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return RemoveClusterNodesWithOptions(ClusterId, request, headers, runtime);
        }

        public async Task<RemoveClusterNodesResponse> RemoveClusterNodesAsync(string ClusterId, RemoveClusterNodesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await RemoveClusterNodesWithOptionsAsync(ClusterId, request, headers, runtime);
        }

        public RemoveClusterNodesResponse RemoveClusterNodesWithOptions(string ClusterId, RemoveClusterNodesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            ClusterId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId);
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
                Pathname = "/api/v2/clusters/" + ClusterId + "/nodes/remove",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<RemoveClusterNodesResponse>(CallApi(params_, req, runtime));
        }

        public async Task<RemoveClusterNodesResponse> RemoveClusterNodesWithOptionsAsync(string ClusterId, RemoveClusterNodesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            ClusterId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId);
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
                Pathname = "/api/v2/clusters/" + ClusterId + "/nodes/remove",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<RemoveClusterNodesResponse>(await CallApiAsync(params_, req, runtime));
        }

        public RemoveWorkflowResponse RemoveWorkflow(string workflowName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return RemoveWorkflowWithOptions(workflowName, headers, runtime);
        }

        public async Task<RemoveWorkflowResponse> RemoveWorkflowAsync(string workflowName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await RemoveWorkflowWithOptionsAsync(workflowName, headers, runtime);
        }

        public RemoveWorkflowResponse RemoveWorkflowWithOptions(string workflowName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            workflowName = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workflowName);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RemoveWorkflow",
                Version = "2015-12-15",
                Protocol = "HTTPS",
                Pathname = "/gs/workflow/" + workflowName,
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<RemoveWorkflowResponse>(CallApi(params_, req, runtime));
        }

        public async Task<RemoveWorkflowResponse> RemoveWorkflowWithOptionsAsync(string workflowName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            workflowName = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workflowName);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RemoveWorkflow",
                Version = "2015-12-15",
                Protocol = "HTTPS",
                Pathname = "/gs/workflow/" + workflowName,
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<RemoveWorkflowResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ResumeComponentUpgradeResponse ResumeComponentUpgrade(string clusterid, string componentid)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ResumeComponentUpgradeWithOptions(clusterid, componentid, headers, runtime);
        }

        public async Task<ResumeComponentUpgradeResponse> ResumeComponentUpgradeAsync(string clusterid, string componentid)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ResumeComponentUpgradeWithOptionsAsync(clusterid, componentid, headers, runtime);
        }

        public ResumeComponentUpgradeResponse ResumeComponentUpgradeWithOptions(string clusterid, string componentid, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            clusterid = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(clusterid);
            componentid = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(componentid);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ResumeComponentUpgrade",
                Version = "2015-12-15",
                Protocol = "HTTPS",
                Pathname = "/clusters/" + clusterid + "/components/" + componentid + "/resume",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<ResumeComponentUpgradeResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ResumeComponentUpgradeResponse> ResumeComponentUpgradeWithOptionsAsync(string clusterid, string componentid, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            clusterid = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(clusterid);
            componentid = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(componentid);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ResumeComponentUpgrade",
                Version = "2015-12-15",
                Protocol = "HTTPS",
                Pathname = "/clusters/" + clusterid + "/components/" + componentid + "/resume",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<ResumeComponentUpgradeResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ResumeUpgradeClusterResponse ResumeUpgradeCluster(string ClusterId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ResumeUpgradeClusterWithOptions(ClusterId, headers, runtime);
        }

        public async Task<ResumeUpgradeClusterResponse> ResumeUpgradeClusterAsync(string ClusterId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ResumeUpgradeClusterWithOptionsAsync(ClusterId, headers, runtime);
        }

        public ResumeUpgradeClusterResponse ResumeUpgradeClusterWithOptions(string ClusterId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            ClusterId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ResumeUpgradeCluster",
                Version = "2015-12-15",
                Protocol = "HTTPS",
                Pathname = "/api/v2/clusters/" + ClusterId + "/upgrade/resume",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<ResumeUpgradeClusterResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ResumeUpgradeClusterResponse> ResumeUpgradeClusterWithOptionsAsync(string ClusterId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            ClusterId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ResumeUpgradeCluster",
                Version = "2015-12-15",
                Protocol = "HTTPS",
                Pathname = "/api/v2/clusters/" + ClusterId + "/upgrade/resume",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<ResumeUpgradeClusterResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ScaleClusterResponse ScaleCluster(string ClusterId, ScaleClusterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ScaleClusterWithOptions(ClusterId, request, headers, runtime);
        }

        public async Task<ScaleClusterResponse> ScaleClusterAsync(string ClusterId, ScaleClusterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ScaleClusterWithOptionsAsync(ClusterId, request, headers, runtime);
        }

        public ScaleClusterResponse ScaleClusterWithOptions(string ClusterId, ScaleClusterRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            ClusterId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId);
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
                Pathname = "/clusters/" + ClusterId,
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ScaleClusterResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ScaleClusterResponse> ScaleClusterWithOptionsAsync(string ClusterId, ScaleClusterRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            ClusterId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId);
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
                Pathname = "/clusters/" + ClusterId,
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ScaleClusterResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ScaleClusterNodePoolResponse ScaleClusterNodePool(string ClusterId, string NodepoolId, ScaleClusterNodePoolRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ScaleClusterNodePoolWithOptions(ClusterId, NodepoolId, request, headers, runtime);
        }

        public async Task<ScaleClusterNodePoolResponse> ScaleClusterNodePoolAsync(string ClusterId, string NodepoolId, ScaleClusterNodePoolRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ScaleClusterNodePoolWithOptionsAsync(ClusterId, NodepoolId, request, headers, runtime);
        }

        public ScaleClusterNodePoolResponse ScaleClusterNodePoolWithOptions(string ClusterId, string NodepoolId, ScaleClusterNodePoolRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            ClusterId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId);
            NodepoolId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(NodepoolId);
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
                Pathname = "/clusters/" + ClusterId + "/nodepools/" + NodepoolId,
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ScaleClusterNodePoolResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ScaleClusterNodePoolResponse> ScaleClusterNodePoolWithOptionsAsync(string ClusterId, string NodepoolId, ScaleClusterNodePoolRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            ClusterId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId);
            NodepoolId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(NodepoolId);
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
                Pathname = "/clusters/" + ClusterId + "/nodepools/" + NodepoolId,
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ScaleClusterNodePoolResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ScaleOutClusterResponse ScaleOutCluster(string ClusterId, ScaleOutClusterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ScaleOutClusterWithOptions(ClusterId, request, headers, runtime);
        }

        public async Task<ScaleOutClusterResponse> ScaleOutClusterAsync(string ClusterId, ScaleOutClusterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ScaleOutClusterWithOptionsAsync(ClusterId, request, headers, runtime);
        }

        public ScaleOutClusterResponse ScaleOutClusterWithOptions(string ClusterId, ScaleOutClusterRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            ClusterId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId);
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Runtime.ToMap()))
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
                Pathname = "/api/v2/clusters/" + ClusterId,
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ScaleOutClusterResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ScaleOutClusterResponse> ScaleOutClusterWithOptionsAsync(string ClusterId, ScaleOutClusterRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            ClusterId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId);
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Runtime.ToMap()))
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
                Pathname = "/api/v2/clusters/" + ClusterId,
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ScaleOutClusterResponse>(await CallApiAsync(params_, req, runtime));
        }

        public StartAlertResponse StartAlert(string ClusterId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return StartAlertWithOptions(ClusterId, headers, runtime);
        }

        public async Task<StartAlertResponse> StartAlertAsync(string ClusterId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await StartAlertWithOptionsAsync(ClusterId, headers, runtime);
        }

        public StartAlertResponse StartAlertWithOptions(string ClusterId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            ClusterId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StartAlert",
                Version = "2015-12-15",
                Protocol = "HTTPS",
                Pathname = "/alert/" + ClusterId + "/alert_rule/start",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<StartAlertResponse>(CallApi(params_, req, runtime));
        }

        public async Task<StartAlertResponse> StartAlertWithOptionsAsync(string ClusterId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            ClusterId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StartAlert",
                Version = "2015-12-15",
                Protocol = "HTTPS",
                Pathname = "/alert/" + ClusterId + "/alert_rule/start",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<StartAlertResponse>(await CallApiAsync(params_, req, runtime));
        }

        public StartWorkflowResponse StartWorkflow(StartWorkflowRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return StartWorkflowWithOptions(request, headers, runtime);
        }

        public async Task<StartWorkflowResponse> StartWorkflowAsync(StartWorkflowRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await StartWorkflowWithOptionsAsync(request, headers, runtime);
        }

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

        public StopAlertResponse StopAlert(string ClusterId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return StopAlertWithOptions(ClusterId, headers, runtime);
        }

        public async Task<StopAlertResponse> StopAlertAsync(string ClusterId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await StopAlertWithOptionsAsync(ClusterId, headers, runtime);
        }

        public StopAlertResponse StopAlertWithOptions(string ClusterId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            ClusterId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StopAlert",
                Version = "2015-12-15",
                Protocol = "HTTPS",
                Pathname = "/alert/" + ClusterId + "/alert_rule/stop",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<StopAlertResponse>(CallApi(params_, req, runtime));
        }

        public async Task<StopAlertResponse> StopAlertWithOptionsAsync(string ClusterId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            ClusterId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StopAlert",
                Version = "2015-12-15",
                Protocol = "HTTPS",
                Pathname = "/alert/" + ClusterId + "/alert_rule/stop",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<StopAlertResponse>(await CallApiAsync(params_, req, runtime));
        }

        public TagResourcesResponse TagResources(TagResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return TagResourcesWithOptions(request, headers, runtime);
        }

        public async Task<TagResourcesResponse> TagResourcesAsync(TagResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await TagResourcesWithOptionsAsync(request, headers, runtime);
        }

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

        public UnInstallClusterAddonsResponse UnInstallClusterAddons(string ClusterId, UnInstallClusterAddonsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UnInstallClusterAddonsWithOptions(ClusterId, request, headers, runtime);
        }

        public async Task<UnInstallClusterAddonsResponse> UnInstallClusterAddonsAsync(string ClusterId, UnInstallClusterAddonsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UnInstallClusterAddonsWithOptionsAsync(ClusterId, request, headers, runtime);
        }

        public UnInstallClusterAddonsResponse UnInstallClusterAddonsWithOptions(string ClusterId, UnInstallClusterAddonsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            ClusterId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId);
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
                Pathname = "/clusters/" + ClusterId + "/components/uninstall",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<UnInstallClusterAddonsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<UnInstallClusterAddonsResponse> UnInstallClusterAddonsWithOptionsAsync(string ClusterId, UnInstallClusterAddonsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            ClusterId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId);
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
                Pathname = "/clusters/" + ClusterId + "/components/uninstall",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<UnInstallClusterAddonsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public UntagResourcesResponse UntagResources(UntagResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UntagResourcesWithOptions(request, headers, runtime);
        }

        public async Task<UntagResourcesResponse> UntagResourcesAsync(UntagResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UntagResourcesWithOptionsAsync(request, headers, runtime);
        }

        public UntagResourcesResponse UntagResourcesWithOptions(UntagResourcesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.All))
            {
                query["all"] = request.All;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["region_id"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceIds))
            {
                query["resource_ids"] = request.ResourceIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["resource_type"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagKeys))
            {
                query["tag_keys"] = request.TagKeys;
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

        public async Task<UntagResourcesResponse> UntagResourcesWithOptionsAsync(UntagResourcesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.All))
            {
                query["all"] = request.All;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["region_id"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceIds))
            {
                query["resource_ids"] = request.ResourceIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["resource_type"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagKeys))
            {
                query["tag_keys"] = request.TagKeys;
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

        public UpdateContactGroupForAlertResponse UpdateContactGroupForAlert(string ClusterId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateContactGroupForAlertWithOptions(ClusterId, headers, runtime);
        }

        public async Task<UpdateContactGroupForAlertResponse> UpdateContactGroupForAlertAsync(string ClusterId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateContactGroupForAlertWithOptionsAsync(ClusterId, headers, runtime);
        }

        public UpdateContactGroupForAlertResponse UpdateContactGroupForAlertWithOptions(string ClusterId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            ClusterId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateContactGroupForAlert",
                Version = "2015-12-15",
                Protocol = "HTTPS",
                Pathname = "/alert/" + ClusterId + "/alert_rule/contact_groups",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<UpdateContactGroupForAlertResponse>(CallApi(params_, req, runtime));
        }

        public async Task<UpdateContactGroupForAlertResponse> UpdateContactGroupForAlertWithOptionsAsync(string ClusterId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            ClusterId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateContactGroupForAlert",
                Version = "2015-12-15",
                Protocol = "HTTPS",
                Pathname = "/alert/" + ClusterId + "/alert_rule/contact_groups",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<UpdateContactGroupForAlertResponse>(await CallApiAsync(params_, req, runtime));
        }

        public UpdateK8sClusterUserConfigExpireResponse UpdateK8sClusterUserConfigExpire(string ClusterId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateK8sClusterUserConfigExpireWithOptions(ClusterId, headers, runtime);
        }

        public async Task<UpdateK8sClusterUserConfigExpireResponse> UpdateK8sClusterUserConfigExpireAsync(string ClusterId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateK8sClusterUserConfigExpireWithOptionsAsync(ClusterId, headers, runtime);
        }

        public UpdateK8sClusterUserConfigExpireResponse UpdateK8sClusterUserConfigExpireWithOptions(string ClusterId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            ClusterId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateK8sClusterUserConfigExpire",
                Version = "2015-12-15",
                Protocol = "HTTPS",
                Pathname = "/k8s/" + ClusterId + "/user_config/expire",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<UpdateK8sClusterUserConfigExpireResponse>(CallApi(params_, req, runtime));
        }

        public async Task<UpdateK8sClusterUserConfigExpireResponse> UpdateK8sClusterUserConfigExpireWithOptionsAsync(string ClusterId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            ClusterId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateK8sClusterUserConfigExpire",
                Version = "2015-12-15",
                Protocol = "HTTPS",
                Pathname = "/k8s/" + ClusterId + "/user_config/expire",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<UpdateK8sClusterUserConfigExpireResponse>(await CallApiAsync(params_, req, runtime));
        }

        public UpdateTemplateResponse UpdateTemplate(string TemplateId, UpdateTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateTemplateWithOptions(TemplateId, request, headers, runtime);
        }

        public async Task<UpdateTemplateResponse> UpdateTemplateAsync(string TemplateId, UpdateTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateTemplateWithOptionsAsync(TemplateId, request, headers, runtime);
        }

        public UpdateTemplateResponse UpdateTemplateWithOptions(string TemplateId, UpdateTemplateRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            TemplateId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(TemplateId);
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
                Pathname = "/templates/" + TemplateId,
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<UpdateTemplateResponse>(CallApi(params_, req, runtime));
        }

        public async Task<UpdateTemplateResponse> UpdateTemplateWithOptionsAsync(string TemplateId, UpdateTemplateRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            TemplateId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(TemplateId);
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
                Pathname = "/templates/" + TemplateId,
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<UpdateTemplateResponse>(await CallApiAsync(params_, req, runtime));
        }

        public UpgradeClusterResponse UpgradeCluster(string ClusterId, UpgradeClusterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpgradeClusterWithOptions(ClusterId, request, headers, runtime);
        }

        public async Task<UpgradeClusterResponse> UpgradeClusterAsync(string ClusterId, UpgradeClusterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpgradeClusterWithOptionsAsync(ClusterId, request, headers, runtime);
        }

        public UpgradeClusterResponse UpgradeClusterWithOptions(string ClusterId, UpgradeClusterRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            ClusterId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ComponentName))
            {
                body["component_name"] = request.ComponentName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextVersion))
            {
                body["next_version"] = request.NextVersion;
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
                Pathname = "/api/v2/clusters/" + ClusterId + "/upgrade",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<UpgradeClusterResponse>(CallApi(params_, req, runtime));
        }

        public async Task<UpgradeClusterResponse> UpgradeClusterWithOptionsAsync(string ClusterId, UpgradeClusterRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            ClusterId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ComponentName))
            {
                body["component_name"] = request.ComponentName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextVersion))
            {
                body["next_version"] = request.NextVersion;
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
                Pathname = "/api/v2/clusters/" + ClusterId + "/upgrade",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<UpgradeClusterResponse>(await CallApiAsync(params_, req, runtime));
        }

        public UpgradeClusterAddonsResponse UpgradeClusterAddons(string ClusterId, UpgradeClusterAddonsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpgradeClusterAddonsWithOptions(ClusterId, request, headers, runtime);
        }

        public async Task<UpgradeClusterAddonsResponse> UpgradeClusterAddonsAsync(string ClusterId, UpgradeClusterAddonsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpgradeClusterAddonsWithOptionsAsync(ClusterId, request, headers, runtime);
        }

        public UpgradeClusterAddonsResponse UpgradeClusterAddonsWithOptions(string ClusterId, UpgradeClusterAddonsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            ClusterId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId);
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
                Pathname = "/clusters/" + ClusterId + "/components/upgrade",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<UpgradeClusterAddonsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<UpgradeClusterAddonsResponse> UpgradeClusterAddonsWithOptionsAsync(string ClusterId, UpgradeClusterAddonsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            ClusterId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId);
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
                Pathname = "/clusters/" + ClusterId + "/components/upgrade",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<UpgradeClusterAddonsResponse>(await CallApiAsync(params_, req, runtime));
        }

    }
}
