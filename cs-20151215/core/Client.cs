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
            return TeaModel.ToObject<AttachInstancesResponse>(DoROARequest("AttachInstances", "2015-12-15", "HTTPS", "POST", "AK", "/clusters/" + ClusterId + "/attach", "json", req, runtime));
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
            return TeaModel.ToObject<AttachInstancesResponse>(await DoROARequestAsync("AttachInstances", "2015-12-15", "HTTPS", "POST", "AK", "/clusters/" + ClusterId + "/attach", "json", req, runtime));
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
            return TeaModel.ToObject<CancelClusterUpgradeResponse>(DoROARequest("CancelClusterUpgrade", "2015-12-15", "HTTPS", "POST", "AK", "/api/v2/clusters/" + ClusterId + "/upgrade/cancel", "none", req, runtime));
        }

        public async Task<CancelClusterUpgradeResponse> CancelClusterUpgradeWithOptionsAsync(string ClusterId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            ClusterId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<CancelClusterUpgradeResponse>(await DoROARequestAsync("CancelClusterUpgrade", "2015-12-15", "HTTPS", "POST", "AK", "/api/v2/clusters/" + ClusterId + "/upgrade/cancel", "none", req, runtime));
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
            return TeaModel.ToObject<CancelComponentUpgradeResponse>(DoROARequest("CancelComponentUpgrade", "2015-12-15", "HTTPS", "POST", "AK", "/clusters/" + clusterId + "/components/" + componentId + "/cancel", "none", req, runtime));
        }

        public async Task<CancelComponentUpgradeResponse> CancelComponentUpgradeWithOptionsAsync(string clusterId, string componentId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            clusterId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(clusterId);
            componentId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(componentId);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<CancelComponentUpgradeResponse>(await DoROARequestAsync("CancelComponentUpgrade", "2015-12-15", "HTTPS", "POST", "AK", "/clusters/" + clusterId + "/components/" + componentId + "/cancel", "none", req, runtime));
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
            return TeaModel.ToObject<CancelWorkflowResponse>(DoROARequest("CancelWorkflow", "2015-12-15", "HTTPS", "PUT", "AK", "/gs/workflow/" + workflowName, "none", req, runtime));
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
            return TeaModel.ToObject<CancelWorkflowResponse>(await DoROARequestAsync("CancelWorkflow", "2015-12-15", "HTTPS", "PUT", "AK", "/gs/workflow/" + workflowName, "none", req, runtime));
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
            return TeaModel.ToObject<CreateAutoscalingConfigResponse>(DoROARequest("CreateAutoscalingConfig", "2015-12-15", "HTTPS", "POST", "AK", "/cluster/" + ClusterId + "/autoscale/config/", "none", req, runtime));
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
            return TeaModel.ToObject<CreateAutoscalingConfigResponse>(await DoROARequestAsync("CreateAutoscalingConfig", "2015-12-15", "HTTPS", "POST", "AK", "/cluster/" + ClusterId + "/autoscale/config/", "none", req, runtime));
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
            return TeaModel.ToObject<CreateClusterResponse>(DoROARequest("CreateCluster", "2015-12-15", "HTTPS", "POST", "AK", "/clusters", "json", req, runtime));
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
            return TeaModel.ToObject<CreateClusterResponse>(await DoROARequestAsync("CreateCluster", "2015-12-15", "HTTPS", "POST", "AK", "/clusters", "json", req, runtime));
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<CreateClusterNodePoolResponse>(DoROARequest("CreateClusterNodePool", "2015-12-15", "HTTPS", "POST", "AK", "/clusters/" + ClusterId + "/nodepools", "json", req, runtime));
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            return TeaModel.ToObject<CreateClusterNodePoolResponse>(await DoROARequestAsync("CreateClusterNodePool", "2015-12-15", "HTTPS", "POST", "AK", "/clusters/" + ClusterId + "/nodepools", "json", req, runtime));
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
            return TeaModel.ToObject<CreateEdgeMachineResponse>(DoROARequest("CreateEdgeMachine", "2015-12-15", "HTTPS", "POST", "AK", "/edge_machines", "json", req, runtime));
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
            return TeaModel.ToObject<CreateEdgeMachineResponse>(await DoROARequestAsync("CreateEdgeMachine", "2015-12-15", "HTTPS", "POST", "AK", "/edge_machines", "json", req, runtime));
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
            return TeaModel.ToObject<CreateKubernetesTriggerResponse>(DoROARequest("CreateKubernetesTrigger", "2015-12-15", "HTTPS", "POST", "AK", "/triggers", "json", req, runtime));
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
            return TeaModel.ToObject<CreateKubernetesTriggerResponse>(await DoROARequestAsync("CreateKubernetesTrigger", "2015-12-15", "HTTPS", "POST", "AK", "/triggers", "json", req, runtime));
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
            return TeaModel.ToObject<CreateTemplateResponse>(DoROARequest("CreateTemplate", "2015-12-15", "HTTPS", "POST", "AK", "/templates", "json", req, runtime));
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
            return TeaModel.ToObject<CreateTemplateResponse>(await DoROARequestAsync("CreateTemplate", "2015-12-15", "HTTPS", "POST", "AK", "/templates", "json", req, runtime));
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
            return TeaModel.ToObject<CreateTriggerResponse>(DoROARequest("CreateTrigger", "2015-12-15", "HTTPS", "POST", "AK", "/clusters/" + clusterId + "/triggers", "json", req, runtime));
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
            return TeaModel.ToObject<CreateTriggerResponse>(await DoROARequestAsync("CreateTrigger", "2015-12-15", "HTTPS", "POST", "AK", "/clusters/" + clusterId + "/triggers", "json", req, runtime));
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
            return TeaModel.ToObject<DeleteClusterResponse>(DoROARequest("DeleteCluster", "2015-12-15", "HTTPS", "DELETE", "AK", "/clusters/" + ClusterId, "none", req, runtime));
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
            return TeaModel.ToObject<DeleteClusterResponse>(await DoROARequestAsync("DeleteCluster", "2015-12-15", "HTTPS", "DELETE", "AK", "/clusters/" + ClusterId, "none", req, runtime));
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
            return TeaModel.ToObject<DeleteClusterNodepoolResponse>(DoROARequest("DeleteClusterNodepool", "2015-12-15", "HTTPS", "DELETE", "AK", "/clusters/" + ClusterId + "/nodepools/" + NodepoolId, "json", req, runtime));
        }

        public async Task<DeleteClusterNodepoolResponse> DeleteClusterNodepoolWithOptionsAsync(string ClusterId, string NodepoolId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            ClusterId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId);
            NodepoolId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(NodepoolId);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<DeleteClusterNodepoolResponse>(await DoROARequestAsync("DeleteClusterNodepool", "2015-12-15", "HTTPS", "DELETE", "AK", "/clusters/" + ClusterId + "/nodepools/" + NodepoolId, "json", req, runtime));
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
            return TeaModel.ToObject<DeleteClusterNodesResponse>(DoROARequest("DeleteClusterNodes", "2015-12-15", "HTTPS", "POST", "AK", "/clusters/" + ClusterId + "/nodes", "json", req, runtime));
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
            return TeaModel.ToObject<DeleteClusterNodesResponse>(await DoROARequestAsync("DeleteClusterNodes", "2015-12-15", "HTTPS", "POST", "AK", "/clusters/" + ClusterId + "/nodes", "json", req, runtime));
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
            return TeaModel.ToObject<DeleteEdgeMachineResponse>(DoROARequest("DeleteEdgeMachine", "2015-12-15", "HTTPS", "DELETE", "AK", "/edge_machines/[edge_machineid]", "none", req, runtime));
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
            return TeaModel.ToObject<DeleteEdgeMachineResponse>(await DoROARequestAsync("DeleteEdgeMachine", "2015-12-15", "HTTPS", "DELETE", "AK", "/edge_machines/[edge_machineid]", "none", req, runtime));
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
            return TeaModel.ToObject<DeleteKubernetesTriggerResponse>(DoROARequest("DeleteKubernetesTrigger", "2015-12-15", "HTTPS", "DELETE", "AK", "/triggers/revoke/" + Id, "none", req, runtime));
        }

        public async Task<DeleteKubernetesTriggerResponse> DeleteKubernetesTriggerWithOptionsAsync(string Id, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            Id = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(Id);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<DeleteKubernetesTriggerResponse>(await DoROARequestAsync("DeleteKubernetesTrigger", "2015-12-15", "HTTPS", "DELETE", "AK", "/triggers/revoke/" + Id, "none", req, runtime));
        }

        public DeletePolicyInstanceResponse DeletePolicyInstance(string clusterId, string policyName, string instanceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeletePolicyInstanceWithOptions(clusterId, policyName, instanceId, headers, runtime);
        }

        public async Task<DeletePolicyInstanceResponse> DeletePolicyInstanceAsync(string clusterId, string policyName, string instanceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeletePolicyInstanceWithOptionsAsync(clusterId, policyName, instanceId, headers, runtime);
        }

        public DeletePolicyInstanceResponse DeletePolicyInstanceWithOptions(string clusterId, string policyName, string instanceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            clusterId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(clusterId);
            policyName = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(policyName);
            instanceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<DeletePolicyInstanceResponse>(DoROARequest("DeletePolicyInstance", "2015-12-15", "HTTPS", "DELETE", "AK", "/clusters/" + clusterId + "/policies/" + policyName + "/instances/" + instanceId, "none", req, runtime));
        }

        public async Task<DeletePolicyInstanceResponse> DeletePolicyInstanceWithOptionsAsync(string clusterId, string policyName, string instanceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            clusterId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(clusterId);
            policyName = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(policyName);
            instanceId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<DeletePolicyInstanceResponse>(await DoROARequestAsync("DeletePolicyInstance", "2015-12-15", "HTTPS", "DELETE", "AK", "/clusters/" + clusterId + "/policies/" + policyName + "/instances/" + instanceId, "none", req, runtime));
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
            return TeaModel.ToObject<DeleteTemplateResponse>(DoROARequest("DeleteTemplate", "2015-12-15", "HTTPS", "DELETE", "AK", "/templates/" + TemplateId, "none", req, runtime));
        }

        public async Task<DeleteTemplateResponse> DeleteTemplateWithOptionsAsync(string TemplateId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            TemplateId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(TemplateId);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<DeleteTemplateResponse>(await DoROARequestAsync("DeleteTemplate", "2015-12-15", "HTTPS", "DELETE", "AK", "/templates/" + TemplateId, "none", req, runtime));
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
            return TeaModel.ToObject<DeleteTriggerResponse>(DoROARequest("DeleteTrigger", "2015-12-15", "HTTPS", "DELETE", "AK", "/clusters/[cluster_id]/triggers/[Id]", "none", req, runtime));
        }

        public async Task<DeleteTriggerResponse> DeleteTriggerWithOptionsAsync(string clusterId, string Id, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            clusterId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(clusterId);
            Id = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(Id);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<DeleteTriggerResponse>(await DoROARequestAsync("DeleteTrigger", "2015-12-15", "HTTPS", "DELETE", "AK", "/clusters/[cluster_id]/triggers/[Id]", "none", req, runtime));
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
            return TeaModel.ToObject<DeployPolicyInstanceResponse>(DoROARequest("DeployPolicyInstance", "2015-12-15", "HTTPS", "POST", "AK", "/clusters/" + clusterId + "/policies/" + policyName, "none", req, runtime));
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
            return TeaModel.ToObject<DeployPolicyInstanceResponse>(await DoROARequestAsync("DeployPolicyInstance", "2015-12-15", "HTTPS", "POST", "AK", "/clusters/" + clusterId + "/policies/" + policyName, "none", req, runtime));
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
            return TeaModel.ToObject<DescirbeWorkflowResponse>(DoROARequest("DescirbeWorkflow", "2015-12-15", "HTTPS", "GET", "AK", "/gs/workflow/" + workflowName, "json", req, runtime));
        }

        public async Task<DescirbeWorkflowResponse> DescirbeWorkflowWithOptionsAsync(string workflowName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            workflowName = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workflowName);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<DescirbeWorkflowResponse>(await DoROARequestAsync("DescirbeWorkflow", "2015-12-15", "HTTPS", "GET", "AK", "/gs/workflow/" + workflowName, "json", req, runtime));
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
            return TeaModel.ToObject<DescribeAddonsResponse>(DoROARequest("DescribeAddons", "2015-12-15", "HTTPS", "GET", "AK", "/clusters/components/metadata", "json", req, runtime));
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
            return TeaModel.ToObject<DescribeAddonsResponse>(await DoROARequestAsync("DescribeAddons", "2015-12-15", "HTTPS", "GET", "AK", "/clusters/components/metadata", "json", req, runtime));
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
            return TeaModel.ToObject<DescribeClusterAddonMetadataResponse>(DoROARequest("DescribeClusterAddonMetadata", "2015-12-15", "HTTPS", "GET", "AK", "/clusters/" + clusterId + "/components/" + componentId + "/metadata", "json", req, runtime));
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
            return TeaModel.ToObject<DescribeClusterAddonMetadataResponse>(await DoROARequestAsync("DescribeClusterAddonMetadata", "2015-12-15", "HTTPS", "GET", "AK", "/clusters/" + clusterId + "/components/" + componentId + "/metadata", "json", req, runtime));
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
            return TeaModel.ToObject<DescribeClusterAddonUpgradeStatusResponse>(DoROARequest("DescribeClusterAddonUpgradeStatus", "2015-12-15", "HTTPS", "GET", "AK", "/clusters/" + ClusterId + "/components/" + ComponentId + "/upgradestatus", "json", req, runtime));
        }

        public async Task<DescribeClusterAddonUpgradeStatusResponse> DescribeClusterAddonUpgradeStatusWithOptionsAsync(string ClusterId, string ComponentId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            ClusterId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId);
            ComponentId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ComponentId);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<DescribeClusterAddonUpgradeStatusResponse>(await DoROARequestAsync("DescribeClusterAddonUpgradeStatus", "2015-12-15", "HTTPS", "GET", "AK", "/clusters/" + ClusterId + "/components/" + ComponentId + "/upgradestatus", "json", req, runtime));
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
            return TeaModel.ToObject<DescribeClusterAddonsUpgradeStatusResponse>(DoROARequest("DescribeClusterAddonsUpgradeStatus", "2015-12-15", "HTTPS", "GET", "AK", "/clusters/" + ClusterId + "/components/upgradestatus", "json", req, runtime));
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
            return TeaModel.ToObject<DescribeClusterAddonsUpgradeStatusResponse>(await DoROARequestAsync("DescribeClusterAddonsUpgradeStatus", "2015-12-15", "HTTPS", "GET", "AK", "/clusters/" + ClusterId + "/components/upgradestatus", "json", req, runtime));
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
            return TeaModel.ToObject<DescribeClusterAddonsVersionResponse>(DoROARequest("DescribeClusterAddonsVersion", "2015-12-15", "HTTPS", "GET", "AK", "/clusters/" + ClusterId + "/components/version", "json", req, runtime));
        }

        public async Task<DescribeClusterAddonsVersionResponse> DescribeClusterAddonsVersionWithOptionsAsync(string ClusterId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            ClusterId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<DescribeClusterAddonsVersionResponse>(await DoROARequestAsync("DescribeClusterAddonsVersion", "2015-12-15", "HTTPS", "GET", "AK", "/clusters/" + ClusterId + "/components/version", "json", req, runtime));
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
            return TeaModel.ToObject<DescribeClusterAttachScriptsResponse>(DoROARequest("DescribeClusterAttachScripts", "2015-12-15", "HTTPS", "POST", "AK", "/clusters/" + ClusterId + "/attachscript", "string", req, runtime));
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
            return TeaModel.ToObject<DescribeClusterAttachScriptsResponse>(await DoROARequestAsync("DescribeClusterAttachScripts", "2015-12-15", "HTTPS", "POST", "AK", "/clusters/" + ClusterId + "/attachscript", "string", req, runtime));
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
            return TeaModel.ToObject<DescribeClusterDetailResponse>(DoROARequest("DescribeClusterDetail", "2015-12-15", "HTTPS", "GET", "AK", "/clusters/" + ClusterId, "json", req, runtime));
        }

        public async Task<DescribeClusterDetailResponse> DescribeClusterDetailWithOptionsAsync(string ClusterId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            ClusterId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<DescribeClusterDetailResponse>(await DoROARequestAsync("DescribeClusterDetail", "2015-12-15", "HTTPS", "GET", "AK", "/clusters/" + ClusterId, "json", req, runtime));
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
            return TeaModel.ToObject<DescribeClusterLogsResponse>(DoROARequest("DescribeClusterLogs", "2015-12-15", "HTTPS", "GET", "AK", "/clusters/" + ClusterId + "/logs", "array", req, runtime));
        }

        public async Task<DescribeClusterLogsResponse> DescribeClusterLogsWithOptionsAsync(string ClusterId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            ClusterId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<DescribeClusterLogsResponse>(await DoROARequestAsync("DescribeClusterLogs", "2015-12-15", "HTTPS", "GET", "AK", "/clusters/" + ClusterId + "/logs", "array", req, runtime));
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
            return TeaModel.ToObject<DescribeClusterNamespacesResponse>(DoROARequest("DescribeClusterNamespaces", "2015-12-15", "HTTPS", "GET", "AK", "/k8s/" + ClusterId + "/namespaces", "array", req, runtime));
        }

        public async Task<DescribeClusterNamespacesResponse> DescribeClusterNamespacesWithOptionsAsync(string ClusterId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            ClusterId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<DescribeClusterNamespacesResponse>(await DoROARequestAsync("DescribeClusterNamespaces", "2015-12-15", "HTTPS", "GET", "AK", "/k8s/" + ClusterId + "/namespaces", "array", req, runtime));
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
            return TeaModel.ToObject<DescribeClusterNodePoolDetailResponse>(DoROARequest("DescribeClusterNodePoolDetail", "2015-12-15", "HTTPS", "GET", "AK", "/clusters/" + ClusterId + "/nodepools/" + NodepoolId, "json", req, runtime));
        }

        public async Task<DescribeClusterNodePoolDetailResponse> DescribeClusterNodePoolDetailWithOptionsAsync(string ClusterId, string NodepoolId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            ClusterId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId);
            NodepoolId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(NodepoolId);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<DescribeClusterNodePoolDetailResponse>(await DoROARequestAsync("DescribeClusterNodePoolDetail", "2015-12-15", "HTTPS", "GET", "AK", "/clusters/" + ClusterId + "/nodepools/" + NodepoolId, "json", req, runtime));
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
            return TeaModel.ToObject<DescribeClusterNodePoolsResponse>(DoROARequest("DescribeClusterNodePools", "2015-12-15", "HTTPS", "GET", "AK", "/clusters/" + ClusterId + "/nodepools", "json", req, runtime));
        }

        public async Task<DescribeClusterNodePoolsResponse> DescribeClusterNodePoolsWithOptionsAsync(string ClusterId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            ClusterId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<DescribeClusterNodePoolsResponse>(await DoROARequestAsync("DescribeClusterNodePools", "2015-12-15", "HTTPS", "GET", "AK", "/clusters/" + ClusterId + "/nodepools", "json", req, runtime));
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
            return TeaModel.ToObject<DescribeClusterNodesResponse>(DoROARequest("DescribeClusterNodes", "2015-12-15", "HTTPS", "GET", "AK", "/clusters/" + ClusterId + "/nodes", "json", req, runtime));
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
            return TeaModel.ToObject<DescribeClusterNodesResponse>(await DoROARequestAsync("DescribeClusterNodes", "2015-12-15", "HTTPS", "GET", "AK", "/clusters/" + ClusterId + "/nodes", "json", req, runtime));
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
            return TeaModel.ToObject<DescribeClusterResourcesResponse>(DoROARequest("DescribeClusterResources", "2015-12-15", "HTTPS", "GET", "AK", "/clusters/" + ClusterId + "/resources", "array", req, runtime));
        }

        public async Task<DescribeClusterResourcesResponse> DescribeClusterResourcesWithOptionsAsync(string ClusterId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            ClusterId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<DescribeClusterResourcesResponse>(await DoROARequestAsync("DescribeClusterResources", "2015-12-15", "HTTPS", "GET", "AK", "/clusters/" + ClusterId + "/resources", "array", req, runtime));
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
            return TeaModel.ToObject<DescribeClusterUserKubeconfigResponse>(DoROARequest("DescribeClusterUserKubeconfig", "2015-12-15", "HTTPS", "GET", "AK", "/k8s/" + ClusterId + "/user_config", "json", req, runtime));
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
            return TeaModel.ToObject<DescribeClusterUserKubeconfigResponse>(await DoROARequestAsync("DescribeClusterUserKubeconfig", "2015-12-15", "HTTPS", "GET", "AK", "/k8s/" + ClusterId + "/user_config", "json", req, runtime));
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
            return TeaModel.ToObject<DescribeClusterV2UserKubeconfigResponse>(DoROARequest("DescribeClusterV2UserKubeconfig", "2015-12-15", "HTTPS", "GET", "AK", "/api/v2/k8s/" + ClusterId + "/user_config", "json", req, runtime));
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
            return TeaModel.ToObject<DescribeClusterV2UserKubeconfigResponse>(await DoROARequestAsync("DescribeClusterV2UserKubeconfig", "2015-12-15", "HTTPS", "GET", "AK", "/api/v2/k8s/" + ClusterId + "/user_config", "json", req, runtime));
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
            return TeaModel.ToObject<DescribeClustersResponse>(DoROARequest("DescribeClusters", "2015-12-15", "HTTPS", "GET", "AK", "/clusters", "array", req, runtime));
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
            return TeaModel.ToObject<DescribeClustersResponse>(await DoROARequestAsync("DescribeClusters", "2015-12-15", "HTTPS", "GET", "AK", "/clusters", "array", req, runtime));
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
            return TeaModel.ToObject<DescribeClustersV1Response>(DoROARequest("DescribeClustersV1", "2015-12-15", "HTTPS", "GET", "AK", "/api/v1/clusters", "json", req, runtime));
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
            return TeaModel.ToObject<DescribeClustersV1Response>(await DoROARequestAsync("DescribeClustersV1", "2015-12-15", "HTTPS", "GET", "AK", "/api/v1/clusters", "json", req, runtime));
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
            return TeaModel.ToObject<DescribeEdgeMachineActiveProcessResponse>(DoROARequest("DescribeEdgeMachineActiveProcess", "2015-12-15", "HTTPS", "GET", "AK", "/edge_machines/[edge_machineid]/activeprocess", "json", req, runtime));
        }

        public async Task<DescribeEdgeMachineActiveProcessResponse> DescribeEdgeMachineActiveProcessWithOptionsAsync(string edgeMachineid, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            edgeMachineid = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(edgeMachineid);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<DescribeEdgeMachineActiveProcessResponse>(await DoROARequestAsync("DescribeEdgeMachineActiveProcess", "2015-12-15", "HTTPS", "GET", "AK", "/edge_machines/[edge_machineid]/activeprocess", "json", req, runtime));
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
            return TeaModel.ToObject<DescribeEdgeMachineModelsResponse>(DoROARequest("DescribeEdgeMachineModels", "2015-12-15", "HTTPS", "GET", "AK", "/edge_machines/models", "json", req, runtime));
        }

        public async Task<DescribeEdgeMachineModelsResponse> DescribeEdgeMachineModelsWithOptionsAsync(Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<DescribeEdgeMachineModelsResponse>(await DoROARequestAsync("DescribeEdgeMachineModels", "2015-12-15", "HTTPS", "GET", "AK", "/edge_machines/models", "json", req, runtime));
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
            return TeaModel.ToObject<DescribeEdgeMachineTunnelConfigDetailResponse>(DoROARequest("DescribeEdgeMachineTunnelConfigDetail", "2015-12-15", "HTTPS", "POST", "AK", "/edge_machines/[edge_machineid]/tunnelconfig", "json", req, runtime));
        }

        public async Task<DescribeEdgeMachineTunnelConfigDetailResponse> DescribeEdgeMachineTunnelConfigDetailWithOptionsAsync(string edgeMachineid, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            edgeMachineid = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(edgeMachineid);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<DescribeEdgeMachineTunnelConfigDetailResponse>(await DoROARequestAsync("DescribeEdgeMachineTunnelConfigDetail", "2015-12-15", "HTTPS", "POST", "AK", "/edge_machines/[edge_machineid]/tunnelconfig", "json", req, runtime));
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
            return TeaModel.ToObject<DescribeEdgeMachinesResponse>(DoROARequest("DescribeEdgeMachines", "2015-12-15", "HTTPS", "GET", "AK", "/edge_machines", "json", req, runtime));
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
            return TeaModel.ToObject<DescribeEdgeMachinesResponse>(await DoROARequestAsync("DescribeEdgeMachines", "2015-12-15", "HTTPS", "GET", "AK", "/edge_machines", "json", req, runtime));
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
            return TeaModel.ToObject<DescribeEventsResponse>(DoROARequest("DescribeEvents", "2015-12-15", "HTTPS", "GET", "AK", "/events", "json", req, runtime));
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
            return TeaModel.ToObject<DescribeEventsResponse>(await DoROARequestAsync("DescribeEvents", "2015-12-15", "HTTPS", "GET", "AK", "/events", "json", req, runtime));
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
            return TeaModel.ToObject<DescribeExternalAgentResponse>(DoROARequest("DescribeExternalAgent", "2015-12-15", "HTTPS", "GET", "AK", "/k8s/" + ClusterId + "/external/agent/deployment", "json", req, runtime));
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
            return TeaModel.ToObject<DescribeExternalAgentResponse>(await DoROARequestAsync("DescribeExternalAgent", "2015-12-15", "HTTPS", "GET", "AK", "/k8s/" + ClusterId + "/external/agent/deployment", "json", req, runtime));
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
            return TeaModel.ToObject<DescribeKubernetesVersionMetadataResponse>(DoROARequest("DescribeKubernetesVersionMetadata", "2015-12-15", "HTTPS", "GET", "AK", "/api/v1/metadata/versions", "array", req, runtime));
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
            return TeaModel.ToObject<DescribeKubernetesVersionMetadataResponse>(await DoROARequestAsync("DescribeKubernetesVersionMetadata", "2015-12-15", "HTTPS", "GET", "AK", "/api/v1/metadata/versions", "array", req, runtime));
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
            return TeaModel.ToObject<DescribePoliciesResponse>(DoROARequest("DescribePolicies", "2015-12-15", "HTTPS", "GET", "AK", "/policies", "json", req, runtime));
        }

        public async Task<DescribePoliciesResponse> DescribePoliciesWithOptionsAsync(Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<DescribePoliciesResponse>(await DoROARequestAsync("DescribePolicies", "2015-12-15", "HTTPS", "GET", "AK", "/policies", "json", req, runtime));
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
            return TeaModel.ToObject<DescribePolicyDetailsResponse>(DoROARequest("DescribePolicyDetails", "2015-12-15", "HTTPS", "GET", "AK", "/policies/" + policyName, "json", req, runtime));
        }

        public async Task<DescribePolicyDetailsResponse> DescribePolicyDetailsWithOptionsAsync(string policyName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            policyName = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(policyName);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<DescribePolicyDetailsResponse>(await DoROARequestAsync("DescribePolicyDetails", "2015-12-15", "HTTPS", "GET", "AK", "/policies/" + policyName, "json", req, runtime));
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
            return TeaModel.ToObject<DescribePolicyGovernanceInClusterResponse>(DoROARequest("DescribePolicyGovernanceInCluster", "2015-12-15", "HTTPS", "GET", "AK", "/clusters/" + clusterId + "/policygovernance", "json", req, runtime));
        }

        public async Task<DescribePolicyGovernanceInClusterResponse> DescribePolicyGovernanceInClusterWithOptionsAsync(string clusterId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            clusterId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(clusterId);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<DescribePolicyGovernanceInClusterResponse>(await DoROARequestAsync("DescribePolicyGovernanceInCluster", "2015-12-15", "HTTPS", "GET", "AK", "/clusters/" + clusterId + "/policygovernance", "json", req, runtime));
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
            return TeaModel.ToObject<DescribePolicyInstancesResponse>(DoROARequest("DescribePolicyInstances", "2015-12-15", "HTTPS", "GET", "AK", "/clusters/" + clusterId + "/policies", "array", req, runtime));
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
            return TeaModel.ToObject<DescribePolicyInstancesResponse>(await DoROARequestAsync("DescribePolicyInstances", "2015-12-15", "HTTPS", "GET", "AK", "/clusters/" + clusterId + "/policies", "array", req, runtime));
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
            return TeaModel.ToObject<DescribePolicyInstancesStatusResponse>(DoROARequest("DescribePolicyInstancesStatus", "2015-12-15", "HTTPS", "GET", "AK", "/clusters/" + clusterId + "/policies/status", "json", req, runtime));
        }

        public async Task<DescribePolicyInstancesStatusResponse> DescribePolicyInstancesStatusWithOptionsAsync(string clusterId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            clusterId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(clusterId);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<DescribePolicyInstancesStatusResponse>(await DoROARequestAsync("DescribePolicyInstancesStatus", "2015-12-15", "HTTPS", "GET", "AK", "/clusters/" + clusterId + "/policies/status", "json", req, runtime));
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
            return TeaModel.ToObject<DescribeTaskInfoResponse>(DoROARequest("DescribeTaskInfo", "2015-12-15", "HTTPS", "GET", "AK", "/tasks/" + taskId, "json", req, runtime));
        }

        public async Task<DescribeTaskInfoResponse> DescribeTaskInfoWithOptionsAsync(string taskId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            taskId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(taskId);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<DescribeTaskInfoResponse>(await DoROARequestAsync("DescribeTaskInfo", "2015-12-15", "HTTPS", "GET", "AK", "/tasks/" + taskId, "json", req, runtime));
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
            return TeaModel.ToObject<DescribeTemplateAttributeResponse>(DoROARequest("DescribeTemplateAttribute", "2015-12-15", "HTTPS", "GET", "AK", "/templates/" + TemplateId, "array", req, runtime));
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
            return TeaModel.ToObject<DescribeTemplateAttributeResponse>(await DoROARequestAsync("DescribeTemplateAttribute", "2015-12-15", "HTTPS", "GET", "AK", "/templates/" + TemplateId, "array", req, runtime));
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
            return TeaModel.ToObject<DescribeTemplatesResponse>(DoROARequest("DescribeTemplates", "2015-12-15", "HTTPS", "GET", "AK", "/templates", "json", req, runtime));
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
            return TeaModel.ToObject<DescribeTemplatesResponse>(await DoROARequestAsync("DescribeTemplates", "2015-12-15", "HTTPS", "GET", "AK", "/templates", "json", req, runtime));
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
            return TeaModel.ToObject<DescribeTriggerResponse>(DoROARequest("DescribeTrigger", "2015-12-15", "HTTPS", "GET", "AK", "/clusters/[cluster_id]/triggers", "array", req, runtime));
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
            return TeaModel.ToObject<DescribeTriggerResponse>(await DoROARequestAsync("DescribeTrigger", "2015-12-15", "HTTPS", "GET", "AK", "/clusters/[cluster_id]/triggers", "array", req, runtime));
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
            return TeaModel.ToObject<DescribeUserPermissionResponse>(DoROARequest("DescribeUserPermission", "2015-12-15", "HTTPS", "GET", "AK", "/permissions/users/" + uid, "array", req, runtime));
        }

        public async Task<DescribeUserPermissionResponse> DescribeUserPermissionWithOptionsAsync(string uid, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            uid = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(uid);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<DescribeUserPermissionResponse>(await DoROARequestAsync("DescribeUserPermission", "2015-12-15", "HTTPS", "GET", "AK", "/permissions/users/" + uid, "array", req, runtime));
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
            return TeaModel.ToObject<DescribeUserQuotaResponse>(DoROARequest("DescribeUserQuota", "2015-12-15", "HTTPS", "GET", "AK", "/quota", "json", req, runtime));
        }

        public async Task<DescribeUserQuotaResponse> DescribeUserQuotaWithOptionsAsync(Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<DescribeUserQuotaResponse>(await DoROARequestAsync("DescribeUserQuota", "2015-12-15", "HTTPS", "GET", "AK", "/quota", "json", req, runtime));
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
            return TeaModel.ToObject<DescribeWorkflowsResponse>(DoROARequest("DescribeWorkflows", "2015-12-15", "HTTPS", "GET", "AK", "/gs/workflows", "json", req, runtime));
        }

        public async Task<DescribeWorkflowsResponse> DescribeWorkflowsWithOptionsAsync(Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<DescribeWorkflowsResponse>(await DoROARequestAsync("DescribeWorkflows", "2015-12-15", "HTTPS", "GET", "AK", "/gs/workflows", "json", req, runtime));
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
            return TeaModel.ToObject<EdgeClusterAddEdgeMachineResponse>(DoROARequest("EdgeClusterAddEdgeMachine", "2015-12-15", "HTTPS", "POST", "AK", "/clusters/[clusterid]/attachedgemachine/[edge_machineid]", "json", req, runtime));
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
            return TeaModel.ToObject<EdgeClusterAddEdgeMachineResponse>(await DoROARequestAsync("EdgeClusterAddEdgeMachine", "2015-12-15", "HTTPS", "POST", "AK", "/clusters/[clusterid]/attachedgemachine/[edge_machineid]", "json", req, runtime));
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
            return TeaModel.ToObject<GetKubernetesTriggerResponse>(DoROARequest("GetKubernetesTrigger", "2015-12-15", "HTTPS", "GET", "AK", "/triggers/" + ClusterId, "array", req, runtime));
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
            return TeaModel.ToObject<GetKubernetesTriggerResponse>(await DoROARequestAsync("GetKubernetesTrigger", "2015-12-15", "HTTPS", "GET", "AK", "/triggers/" + ClusterId, "array", req, runtime));
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
            return TeaModel.ToObject<GetUpgradeStatusResponse>(DoROARequest("GetUpgradeStatus", "2015-12-15", "HTTPS", "GET", "AK", "/api/v2/clusters/" + ClusterId + "/upgrade/status", "json", req, runtime));
        }

        public async Task<GetUpgradeStatusResponse> GetUpgradeStatusWithOptionsAsync(string ClusterId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            ClusterId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<GetUpgradeStatusResponse>(await DoROARequestAsync("GetUpgradeStatus", "2015-12-15", "HTTPS", "GET", "AK", "/api/v2/clusters/" + ClusterId + "/upgrade/status", "json", req, runtime));
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
            return TeaModel.ToObject<GrantPermissionsResponse>(DoROARequest("GrantPermissions", "2015-12-15", "HTTPS", "POST", "AK", "/permissions/users/" + uid, "none", req, runtime));
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
            return TeaModel.ToObject<GrantPermissionsResponse>(await DoROARequestAsync("GrantPermissions", "2015-12-15", "HTTPS", "POST", "AK", "/permissions/users/" + uid, "none", req, runtime));
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
            return TeaModel.ToObject<InstallClusterAddonsResponse>(DoROARequest("InstallClusterAddons", "2015-12-15", "HTTPS", "POST", "AK", "/clusters/" + ClusterId + "/components/install", "none", req, runtime));
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
            return TeaModel.ToObject<InstallClusterAddonsResponse>(await DoROARequestAsync("InstallClusterAddons", "2015-12-15", "HTTPS", "POST", "AK", "/clusters/" + ClusterId + "/components/install", "none", req, runtime));
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
            return TeaModel.ToObject<ListTagResourcesResponse>(DoROARequest("ListTagResources", "2015-12-15", "HTTPS", "GET", "AK", "/tags", "json", req, runtime));
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
            return TeaModel.ToObject<ListTagResourcesResponse>(await DoROARequestAsync("ListTagResources", "2015-12-15", "HTTPS", "GET", "AK", "/tags", "json", req, runtime));
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
            return TeaModel.ToObject<MigrateClusterResponse>(DoROARequest("MigrateCluster", "2015-12-15", "HTTPS", "POST", "AK", "/clusters/" + clusterId + "/migrate", "none", req, runtime));
        }

        public async Task<MigrateClusterResponse> MigrateClusterWithOptionsAsync(string clusterId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            clusterId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(clusterId);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<MigrateClusterResponse>(await DoROARequestAsync("MigrateCluster", "2015-12-15", "HTTPS", "POST", "AK", "/clusters/" + clusterId + "/migrate", "none", req, runtime));
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
            return TeaModel.ToObject<ModifyClusterResponse>(DoROARequest("ModifyCluster", "2015-12-15", "HTTPS", "PUT", "AK", "/api/v2/clusters/" + ClusterId, "json", req, runtime));
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
            return TeaModel.ToObject<ModifyClusterResponse>(await DoROARequestAsync("ModifyCluster", "2015-12-15", "HTTPS", "PUT", "AK", "/api/v2/clusters/" + ClusterId, "json", req, runtime));
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
            return TeaModel.ToObject<ModifyClusterAddonResponse>(DoROARequest("ModifyClusterAddon", "2015-12-15", "HTTPS", "POST", "AK", "/clusters/" + clusterId + "/components/" + componentId + "/config", "none", req, runtime));
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
            return TeaModel.ToObject<ModifyClusterAddonResponse>(await DoROARequestAsync("ModifyClusterAddon", "2015-12-15", "HTTPS", "POST", "AK", "/clusters/" + clusterId + "/components/" + componentId + "/config", "none", req, runtime));
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
            return TeaModel.ToObject<ModifyClusterConfigurationResponse>(DoROARequest("ModifyClusterConfiguration", "2015-12-15", "HTTPS", "PUT", "AK", "/clusters/" + ClusterId + "/configuration", "none", req, runtime));
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
            return TeaModel.ToObject<ModifyClusterConfigurationResponse>(await DoROARequestAsync("ModifyClusterConfiguration", "2015-12-15", "HTTPS", "PUT", "AK", "/clusters/" + ClusterId + "/configuration", "none", req, runtime));
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
            return TeaModel.ToObject<ModifyClusterNodePoolResponse>(DoROARequest("ModifyClusterNodePool", "2015-12-15", "HTTPS", "PUT", "AK", "/clusters/" + ClusterId + "/nodepools/" + NodepoolId, "json", req, runtime));
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
            return TeaModel.ToObject<ModifyClusterNodePoolResponse>(await DoROARequestAsync("ModifyClusterNodePool", "2015-12-15", "HTTPS", "PUT", "AK", "/clusters/" + ClusterId + "/nodepools/" + NodepoolId, "json", req, runtime));
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
            return TeaModel.ToObject<ModifyClusterTagsResponse>(DoROARequest("ModifyClusterTags", "2015-12-15", "HTTPS", "POST", "AK", "/clusters/" + ClusterId + "/tags", "none", req, runtime));
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
            return TeaModel.ToObject<ModifyClusterTagsResponse>(await DoROARequestAsync("ModifyClusterTags", "2015-12-15", "HTTPS", "POST", "AK", "/clusters/" + ClusterId + "/tags", "none", req, runtime));
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
            return TeaModel.ToObject<ModifyPolicyInstanceResponse>(DoROARequest("ModifyPolicyInstance", "2015-12-15", "HTTPS", "PUT", "AK", "/clusters/" + clusterId + "/policies/" + policyName, "none", req, runtime));
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
            return TeaModel.ToObject<ModifyPolicyInstanceResponse>(await DoROARequestAsync("ModifyPolicyInstance", "2015-12-15", "HTTPS", "PUT", "AK", "/clusters/" + clusterId + "/policies/" + policyName, "none", req, runtime));
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
            return TeaModel.ToObject<OpenAckServiceResponse>(DoROARequest("OpenAckService", "2015-12-15", "HTTPS", "POST", "AK", "/service/open", "json", req, runtime));
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
            return TeaModel.ToObject<OpenAckServiceResponse>(await DoROARequestAsync("OpenAckService", "2015-12-15", "HTTPS", "POST", "AK", "/service/open", "json", req, runtime));
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
            return TeaModel.ToObject<PauseClusterUpgradeResponse>(DoROARequest("PauseClusterUpgrade", "2015-12-15", "HTTPS", "POST", "AK", "/api/v2/clusters/" + ClusterId + "/upgrade/pause", "none", req, runtime));
        }

        public async Task<PauseClusterUpgradeResponse> PauseClusterUpgradeWithOptionsAsync(string ClusterId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            ClusterId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<PauseClusterUpgradeResponse>(await DoROARequestAsync("PauseClusterUpgrade", "2015-12-15", "HTTPS", "POST", "AK", "/api/v2/clusters/" + ClusterId + "/upgrade/pause", "none", req, runtime));
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
            return TeaModel.ToObject<PauseComponentUpgradeResponse>(DoROARequest("PauseComponentUpgrade", "2015-12-15", "HTTPS", "POST", "AK", "/clusters/" + clusterid + "/components/" + componentid + "/pause", "none", req, runtime));
        }

        public async Task<PauseComponentUpgradeResponse> PauseComponentUpgradeWithOptionsAsync(string clusterid, string componentid, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            clusterid = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(clusterid);
            componentid = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(componentid);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<PauseComponentUpgradeResponse>(await DoROARequestAsync("PauseComponentUpgrade", "2015-12-15", "HTTPS", "POST", "AK", "/clusters/" + clusterid + "/components/" + componentid + "/pause", "none", req, runtime));
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
            return TeaModel.ToObject<RemoveClusterNodesResponse>(DoROARequest("RemoveClusterNodes", "2015-12-15", "HTTPS", "POST", "AK", "/api/v2/clusters/" + ClusterId + "/nodes/remove", "none", req, runtime));
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
            return TeaModel.ToObject<RemoveClusterNodesResponse>(await DoROARequestAsync("RemoveClusterNodes", "2015-12-15", "HTTPS", "POST", "AK", "/api/v2/clusters/" + ClusterId + "/nodes/remove", "none", req, runtime));
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
            return TeaModel.ToObject<RemoveWorkflowResponse>(DoROARequest("RemoveWorkflow", "2015-12-15", "HTTPS", "DELETE", "AK", "/gs/workflow/" + workflowName, "none", req, runtime));
        }

        public async Task<RemoveWorkflowResponse> RemoveWorkflowWithOptionsAsync(string workflowName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            workflowName = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workflowName);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<RemoveWorkflowResponse>(await DoROARequestAsync("RemoveWorkflow", "2015-12-15", "HTTPS", "DELETE", "AK", "/gs/workflow/" + workflowName, "none", req, runtime));
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
            return TeaModel.ToObject<ResumeComponentUpgradeResponse>(DoROARequest("ResumeComponentUpgrade", "2015-12-15", "HTTPS", "POST", "AK", "/clusters/" + clusterid + "/components/" + componentid + "/resume", "none", req, runtime));
        }

        public async Task<ResumeComponentUpgradeResponse> ResumeComponentUpgradeWithOptionsAsync(string clusterid, string componentid, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            clusterid = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(clusterid);
            componentid = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(componentid);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<ResumeComponentUpgradeResponse>(await DoROARequestAsync("ResumeComponentUpgrade", "2015-12-15", "HTTPS", "POST", "AK", "/clusters/" + clusterid + "/components/" + componentid + "/resume", "none", req, runtime));
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
            return TeaModel.ToObject<ResumeUpgradeClusterResponse>(DoROARequest("ResumeUpgradeCluster", "2015-12-15", "HTTPS", "POST", "AK", "/api/v2/clusters/" + ClusterId + "/upgrade/resume", "none", req, runtime));
        }

        public async Task<ResumeUpgradeClusterResponse> ResumeUpgradeClusterWithOptionsAsync(string ClusterId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            ClusterId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<ResumeUpgradeClusterResponse>(await DoROARequestAsync("ResumeUpgradeCluster", "2015-12-15", "HTTPS", "POST", "AK", "/api/v2/clusters/" + ClusterId + "/upgrade/resume", "none", req, runtime));
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
            return TeaModel.ToObject<ScaleClusterResponse>(DoROARequest("ScaleCluster", "2015-12-15", "HTTPS", "PUT", "AK", "/clusters/" + ClusterId, "json", req, runtime));
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
            return TeaModel.ToObject<ScaleClusterResponse>(await DoROARequestAsync("ScaleCluster", "2015-12-15", "HTTPS", "PUT", "AK", "/clusters/" + ClusterId, "json", req, runtime));
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
            return TeaModel.ToObject<ScaleClusterNodePoolResponse>(DoROARequest("ScaleClusterNodePool", "2015-12-15", "HTTPS", "POST", "AK", "/clusters/" + ClusterId + "/nodepools/" + NodepoolId, "json", req, runtime));
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
            return TeaModel.ToObject<ScaleClusterNodePoolResponse>(await DoROARequestAsync("ScaleClusterNodePool", "2015-12-15", "HTTPS", "POST", "AK", "/clusters/" + ClusterId + "/nodepools/" + NodepoolId, "json", req, runtime));
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
            return TeaModel.ToObject<ScaleOutClusterResponse>(DoROARequest("ScaleOutCluster", "2015-12-15", "HTTPS", "POST", "AK", "/api/v2/clusters/" + ClusterId, "json", req, runtime));
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
            return TeaModel.ToObject<ScaleOutClusterResponse>(await DoROARequestAsync("ScaleOutCluster", "2015-12-15", "HTTPS", "POST", "AK", "/api/v2/clusters/" + ClusterId, "json", req, runtime));
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
            return TeaModel.ToObject<StartWorkflowResponse>(DoROARequest("StartWorkflow", "2015-12-15", "HTTPS", "POST", "AK", "/gs/workflow", "json", req, runtime));
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
            return TeaModel.ToObject<StartWorkflowResponse>(await DoROARequestAsync("StartWorkflow", "2015-12-15", "HTTPS", "POST", "AK", "/gs/workflow", "json", req, runtime));
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
            return TeaModel.ToObject<TagResourcesResponse>(DoROARequest("TagResources", "2015-12-15", "HTTPS", "PUT", "AK", "/tags", "none", req, runtime));
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
            return TeaModel.ToObject<TagResourcesResponse>(await DoROARequestAsync("TagResources", "2015-12-15", "HTTPS", "PUT", "AK", "/tags", "none", req, runtime));
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
            return TeaModel.ToObject<UnInstallClusterAddonsResponse>(DoROARequest("UnInstallClusterAddons", "2015-12-15", "HTTPS", "POST", "AK", "/clusters/" + ClusterId + "/components/uninstall", "none", req, runtime));
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
            return TeaModel.ToObject<UnInstallClusterAddonsResponse>(await DoROARequestAsync("UnInstallClusterAddons", "2015-12-15", "HTTPS", "POST", "AK", "/clusters/" + ClusterId + "/components/uninstall", "none", req, runtime));
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
            return TeaModel.ToObject<UntagResourcesResponse>(DoROARequest("UntagResources", "2015-12-15", "HTTPS", "DELETE", "AK", "/tags", "none", req, runtime));
        }

        public async Task<UntagResourcesResponse> UntagResourcesWithOptionsAsync(UntagResourcesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
            return TeaModel.ToObject<UntagResourcesResponse>(await DoROARequestAsync("UntagResources", "2015-12-15", "HTTPS", "DELETE", "AK", "/tags", "none", req, runtime));
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
            return TeaModel.ToObject<UpdateK8sClusterUserConfigExpireResponse>(DoROARequest("UpdateK8sClusterUserConfigExpire", "2015-12-15", "HTTPS", "POST", "AK", "/k8s/" + ClusterId + "/user_config/expire", "none", req, runtime));
        }

        public async Task<UpdateK8sClusterUserConfigExpireResponse> UpdateK8sClusterUserConfigExpireWithOptionsAsync(string ClusterId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            ClusterId = AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ClusterId);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<UpdateK8sClusterUserConfigExpireResponse>(await DoROARequestAsync("UpdateK8sClusterUserConfigExpire", "2015-12-15", "HTTPS", "POST", "AK", "/k8s/" + ClusterId + "/user_config/expire", "none", req, runtime));
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
            return TeaModel.ToObject<UpdateTemplateResponse>(DoROARequest("UpdateTemplate", "2015-12-15", "HTTPS", "PUT", "AK", "/templates/" + TemplateId, "none", req, runtime));
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
            return TeaModel.ToObject<UpdateTemplateResponse>(await DoROARequestAsync("UpdateTemplate", "2015-12-15", "HTTPS", "PUT", "AK", "/templates/" + TemplateId, "none", req, runtime));
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
            return TeaModel.ToObject<UpgradeClusterResponse>(DoROARequest("UpgradeCluster", "2015-12-15", "HTTPS", "POST", "AK", "/api/v2/clusters/" + ClusterId + "/upgrade", "none", req, runtime));
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
            return TeaModel.ToObject<UpgradeClusterResponse>(await DoROARequestAsync("UpgradeCluster", "2015-12-15", "HTTPS", "POST", "AK", "/api/v2/clusters/" + ClusterId + "/upgrade", "none", req, runtime));
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
            return TeaModel.ToObject<UpgradeClusterAddonsResponse>(DoROARequest("UpgradeClusterAddons", "2015-12-15", "HTTPS", "POST", "AK", "/clusters/" + ClusterId + "/components/upgrade", "none", req, runtime));
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
            return TeaModel.ToObject<UpgradeClusterAddonsResponse>(await DoROARequestAsync("UpgradeClusterAddons", "2015-12-15", "HTTPS", "POST", "AK", "/clusters/" + ClusterId + "/components/upgrade", "none", req, runtime));
        }

    }
}
