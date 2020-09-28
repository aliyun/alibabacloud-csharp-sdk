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
                {"cn-hangzhou-finance", "cs.aliyuncs.com"},
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
                {"cn-shanghai-finance-1", "cs.aliyuncs.com"},
                {"cn-shanghai-inner", "cs.aliyuncs.com"},
                {"cn-shanghai-internal-test-1", "cs.aliyuncs.com"},
                {"cn-shenzhen-finance-1", "cs.aliyuncs.com"},
                {"cn-shenzhen-inner", "cs.aliyuncs.com"},
                {"cn-shenzhen-st4-d01", "cs.aliyuncs.com"},
                {"cn-shenzhen-su18-b01", "cs.aliyuncs.com"},
                {"cn-wuhan", "cs.aliyuncs.com"},
                {"cn-wulanchabu", "cs.aliyuncs.com"},
                {"cn-yushanfang", "cs.aliyuncs.com"},
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
                Body = body,
            };
            return TeaModel.ToObject<AttachInstancesResponse>(DoROARequest("AttachInstances", "2015-12-15", "HTTPS", "POST", "AK", "/clusters/" + ClusterId + "/attach", "json", req, runtime));
        }

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
                Body = body,
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<CancelClusterUpgradeResponse>(DoROARequest("CancelClusterUpgrade", "2015-12-15", "HTTPS", "POST", "AK", "/api/v2/clusters/" + ClusterId + "/upgrade/cancel", "none", req, runtime));
        }

        public async Task<CancelClusterUpgradeResponse> CancelClusterUpgradeWithOptionsAsync(string ClusterId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<CancelClusterUpgradeResponse>(await DoROARequestAsync("CancelClusterUpgrade", "2015-12-15", "HTTPS", "POST", "AK", "/api/v2/clusters/" + ClusterId + "/upgrade/cancel", "none", req, runtime));
        }

        public CancelComponentUpgradeResponse CancelComponentUpgrade(string clusterid, string componentid)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CancelComponentUpgradeWithOptions(clusterid, componentid, headers, runtime);
        }

        public async Task<CancelComponentUpgradeResponse> CancelComponentUpgradeAsync(string clusterid, string componentid)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CancelComponentUpgradeWithOptionsAsync(clusterid, componentid, headers, runtime);
        }

        public CancelComponentUpgradeResponse CancelComponentUpgradeWithOptions(string clusterid, string componentid, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<CancelComponentUpgradeResponse>(DoROARequest("CancelComponentUpgrade", "2015-12-15", "HTTPS", "POST", "AK", "/clusters/" + clusterid + "/components/{componentid}/cancel", "none", req, runtime));
        }

        public async Task<CancelComponentUpgradeResponse> CancelComponentUpgradeWithOptionsAsync(string clusterid, string componentid, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<CancelComponentUpgradeResponse>(await DoROARequestAsync("CancelComponentUpgrade", "2015-12-15", "HTTPS", "POST", "AK", "/clusters/" + clusterid + "/components/{componentid}/cancel", "none", req, runtime));
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CloudMonitorFlags))
            {
                body["cloud_monitor_flags"] = request.CloudMonitorFlags;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterType))
            {
                body["cluster_type"] = request.ClusterType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContainerCidr))
            {
                body["container_cidr"] = request.ContainerCidr;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CpuPolicy))
            {
                body["cpu_policy"] = request.CpuPolicy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeletionProtection))
            {
                body["deletion_protection"] = request.DeletionProtection;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisableRollback))
            {
                body["disable_rollback"] = request.DisableRollback;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndpointPublicAccess))
            {
                body["endpoint_public_access"] = request.EndpointPublicAccess;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImagesId))
            {
                body["images_id"] = request.ImagesId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsEnterpriseSecurityGroup))
            {
                body["is_enterprise_security_group"] = request.IsEnterpriseSecurityGroup;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeyPair))
            {
                body["key_pair"] = request.KeyPair;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KubernetesVersion))
            {
                body["kubernetes_version"] = request.KubernetesVersion;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MasterSystemDiskSize))
            {
                body["master_system_disk_size"] = request.MasterSystemDiskSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MasterVswitchIds))
            {
                body["master_vswitch_ids"] = request.MasterVswitchIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeCidrMask))
            {
                body["node_cidr_mask"] = request.NodeCidrMask;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PrivateZone))
            {
                body["private_zone"] = request.PrivateZone;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceCidr))
            {
                body["service_cidr"] = request.ServiceCidr;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SnatEntry))
            {
                body["snat_entry"] = request.SnatEntry;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkerSystemDiskSize))
            {
                body["worker_system_disk_size"] = request.WorkerSystemDiskSize;
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
                Body = body,
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CloudMonitorFlags))
            {
                body["cloud_monitor_flags"] = request.CloudMonitorFlags;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterType))
            {
                body["cluster_type"] = request.ClusterType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContainerCidr))
            {
                body["container_cidr"] = request.ContainerCidr;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CpuPolicy))
            {
                body["cpu_policy"] = request.CpuPolicy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeletionProtection))
            {
                body["deletion_protection"] = request.DeletionProtection;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisableRollback))
            {
                body["disable_rollback"] = request.DisableRollback;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndpointPublicAccess))
            {
                body["endpoint_public_access"] = request.EndpointPublicAccess;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImagesId))
            {
                body["images_id"] = request.ImagesId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsEnterpriseSecurityGroup))
            {
                body["is_enterprise_security_group"] = request.IsEnterpriseSecurityGroup;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeyPair))
            {
                body["key_pair"] = request.KeyPair;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KubernetesVersion))
            {
                body["kubernetes_version"] = request.KubernetesVersion;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MasterSystemDiskSize))
            {
                body["master_system_disk_size"] = request.MasterSystemDiskSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MasterVswitchIds))
            {
                body["master_vswitch_ids"] = request.MasterVswitchIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodeCidrMask))
            {
                body["node_cidr_mask"] = request.NodeCidrMask;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PrivateZone))
            {
                body["private_zone"] = request.PrivateZone;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceCidr))
            {
                body["service_cidr"] = request.ServiceCidr;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SnatEntry))
            {
                body["snat_entry"] = request.SnatEntry;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkerSystemDiskSize))
            {
                body["worker_system_disk_size"] = request.WorkerSystemDiskSize;
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
                Body = body,
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
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoScaling.ToMap()))
            {
                body["auto_scaling"] = request.AutoScaling;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KubernetesConfig.ToMap()))
            {
                body["kubernetes_config"] = request.KubernetesConfig;
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
                Body = body,
            };
            return TeaModel.ToObject<CreateClusterNodePoolResponse>(DoROARequest("CreateClusterNodePool", "2015-12-15", "HTTPS", "POST", "AK", "/clusters/" + ClusterId + "/nodepools", "json", req, runtime));
        }

        public async Task<CreateClusterNodePoolResponse> CreateClusterNodePoolWithOptionsAsync(string ClusterId, CreateClusterNodePoolRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoScaling.ToMap()))
            {
                body["auto_scaling"] = request.AutoScaling;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KubernetesConfig.ToMap()))
            {
                body["kubernetes_config"] = request.KubernetesConfig;
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
                Body = body,
            };
            return TeaModel.ToObject<CreateClusterNodePoolResponse>(await DoROARequestAsync("CreateClusterNodePool", "2015-12-15", "HTTPS", "POST", "AK", "/clusters/" + ClusterId + "/nodepools", "json", req, runtime));
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
                body["Action"] = request.Action;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                body["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectId))
            {
                body["ProjectId"] = request.ProjectId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                body["Type"] = request.Type;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = body,
            };
            return TeaModel.ToObject<CreateKubernetesTriggerResponse>(DoROARequest("CreateKubernetesTrigger", "2015-12-15", "HTTPS", "POST", "AK", "/triggers", "json", req, runtime));
        }

        public async Task<CreateKubernetesTriggerResponse> CreateKubernetesTriggerWithOptionsAsync(CreateKubernetesTriggerRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Action))
            {
                body["Action"] = request.Action;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                body["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectId))
            {
                body["ProjectId"] = request.ProjectId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                body["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                body["Type"] = request.Type;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = body,
            };
            return TeaModel.ToObject<CreateKubernetesTriggerResponse>(await DoROARequestAsync("CreateKubernetesTrigger", "2015-12-15", "HTTPS", "POST", "AK", "/triggers", "json", req, runtime));
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

        public DeleteClusterResponse DeleteClusterWithOptions(string ClusterId, DeleteClusterRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RetainResources))
            {
                query["retain_resources"] = request.RetainResources;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<DeleteClusterResponse>(DoROARequest("DeleteCluster", "2015-12-15", "HTTPS", "DELETE", "AK", "/clusters/" + ClusterId, "none", req, runtime));
        }

        public async Task<DeleteClusterResponse> DeleteClusterWithOptionsAsync(string ClusterId, DeleteClusterRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RetainResources))
            {
                query["retain_resources"] = request.RetainResources;
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<DeleteClusterNodepoolResponse>(DoROARequest("DeleteClusterNodepool", "2015-12-15", "HTTPS", "DELETE", "AK", "/clusters/" + ClusterId + "/nodepools/{NodepoolId}", "none", req, runtime));
        }

        public async Task<DeleteClusterNodepoolResponse> DeleteClusterNodepoolWithOptionsAsync(string ClusterId, string NodepoolId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<DeleteClusterNodepoolResponse>(await DoROARequestAsync("DeleteClusterNodepool", "2015-12-15", "HTTPS", "DELETE", "AK", "/clusters/" + ClusterId + "/nodepools/{NodepoolId}", "none", req, runtime));
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<DeleteKubernetesTriggerResponse>(DoROARequest("DeleteKubernetesTrigger", "2015-12-15", "HTTPS", "DELETE", "AK", "/triggers/revoke/" + Id, "none", req, runtime));
        }

        public async Task<DeleteKubernetesTriggerResponse> DeleteKubernetesTriggerWithOptionsAsync(string Id, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<DeleteKubernetesTriggerResponse>(await DoROARequestAsync("DeleteKubernetesTrigger", "2015-12-15", "HTTPS", "DELETE", "AK", "/triggers/revoke/" + Id, "none", req, runtime));
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                query["region"] = request.Region;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterType))
            {
                query["cluster_type"] = request.ClusterType;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                query["region"] = request.Region;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterType))
            {
                query["cluster_type"] = request.ClusterType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<DescribeAddonsResponse>(await DoROARequestAsync("DescribeAddons", "2015-12-15", "HTTPS", "GET", "AK", "/clusters/components/metadata", "json", req, runtime));
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<DescribeClusterAddonUpgradeStatusResponse>(DoROARequest("DescribeClusterAddonUpgradeStatus", "2015-12-15", "HTTPS", "GET", "AK", "/clusters/" + ClusterId + "/components/{ComponentId}/upgradestatus", "json", req, runtime));
        }

        public async Task<DescribeClusterAddonUpgradeStatusResponse> DescribeClusterAddonUpgradeStatusWithOptionsAsync(string ClusterId, string ComponentId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<DescribeClusterAddonUpgradeStatusResponse>(await DoROARequestAsync("DescribeClusterAddonUpgradeStatus", "2015-12-15", "HTTPS", "GET", "AK", "/clusters/" + ClusterId + "/components/{ComponentId}/upgradestatus", "json", req, runtime));
        }

        /**
         * 批量查询集群Addon升级状态
        
         */
        public DescribeClusterAddonsUpgradeStatusResponse DescribeClusterAddonsUpgradeStatus(string ClusterId, DescribeClusterAddonsUpgradeStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeClusterAddonsUpgradeStatusWithOptions(ClusterId, request, headers, runtime);
        }

        /**
         * 批量查询集群Addon升级状态
        
         */
        public async Task<DescribeClusterAddonsUpgradeStatusResponse> DescribeClusterAddonsUpgradeStatusAsync(string ClusterId, DescribeClusterAddonsUpgradeStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeClusterAddonsUpgradeStatusWithOptionsAsync(ClusterId, request, headers, runtime);
        }

        public DescribeClusterAddonsUpgradeStatusResponse DescribeClusterAddonsUpgradeStatusWithOptions(string ClusterId, DescribeClusterAddonsUpgradeStatusRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ComponentIds))
            {
                query["componentIds"] = request.ComponentIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<DescribeClusterAddonsUpgradeStatusResponse>(DoROARequest("DescribeClusterAddonsUpgradeStatus", "2015-12-15", "HTTPS", "GET", "AK", "/clusters/[ClusterId]/components/upgradestatus", "none", req, runtime));
        }

        public async Task<DescribeClusterAddonsUpgradeStatusResponse> DescribeClusterAddonsUpgradeStatusWithOptionsAsync(string ClusterId, DescribeClusterAddonsUpgradeStatusRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ComponentIds))
            {
                query["componentIds"] = request.ComponentIds;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<DescribeClusterAddonsUpgradeStatusResponse>(await DoROARequestAsync("DescribeClusterAddonsUpgradeStatus", "2015-12-15", "HTTPS", "GET", "AK", "/clusters/[ClusterId]/components/upgradestatus", "none", req, runtime));
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<DescribeClusterAddonsVersionResponse>(DoROARequest("DescribeClusterAddonsVersion", "2015-12-15", "HTTPS", "GET", "AK", "/clusters/" + ClusterId + "/components/version", "json", req, runtime));
        }

        public async Task<DescribeClusterAddonsVersionResponse> DescribeClusterAddonsVersionWithOptionsAsync(string ClusterId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
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
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Arch))
            {
                body["arch"] = request.Arch;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Options.ToMap()))
            {
                body["options"] = request.Options;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = body,
            };
            return TeaModel.ToObject<DescribeClusterAttachScriptsResponse>(DoROARequest("DescribeClusterAttachScripts", "2015-12-15", "HTTPS", "POST", "AK", "/clusters/" + ClusterId + "/attachscript", "string", req, runtime));
        }

        public async Task<DescribeClusterAttachScriptsResponse> DescribeClusterAttachScriptsWithOptionsAsync(string ClusterId, DescribeClusterAttachScriptsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Arch))
            {
                body["arch"] = request.Arch;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Options.ToMap()))
            {
                body["options"] = request.Options;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = body,
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<DescribeClusterDetailResponse>(DoROARequest("DescribeClusterDetail", "2015-12-15", "HTTPS", "GET", "AK", "/clusters/" + ClusterId, "json", req, runtime));
        }

        public async Task<DescribeClusterDetailResponse> DescribeClusterDetailWithOptionsAsync(string ClusterId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<DescribeClusterLogsResponse>(DoROARequest("DescribeClusterLogs", "2015-12-15", "HTTPS", "GET", "AK", "/clusters/" + ClusterId + "/logs", "array", req, runtime));
        }

        public async Task<DescribeClusterLogsResponse> DescribeClusterLogsWithOptionsAsync(string ClusterId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<DescribeClusterLogsResponse>(await DoROARequestAsync("DescribeClusterLogs", "2015-12-15", "HTTPS", "GET", "AK", "/clusters/" + ClusterId + "/logs", "array", req, runtime));
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<DescribeClusterNodePoolDetailResponse>(DoROARequest("DescribeClusterNodePoolDetail", "2015-12-15", "HTTPS", "GET", "AK", "/clusters/" + ClusterId + "/nodepools/{NodepoolId}", "json", req, runtime));
        }

        public async Task<DescribeClusterNodePoolDetailResponse> DescribeClusterNodePoolDetailWithOptionsAsync(string ClusterId, string NodepoolId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<DescribeClusterNodePoolDetailResponse>(await DoROARequestAsync("DescribeClusterNodePoolDetail", "2015-12-15", "HTTPS", "GET", "AK", "/clusters/" + ClusterId + "/nodepools/{NodepoolId}", "json", req, runtime));
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<DescribeClusterNodePoolsResponse>(DoROARequest("DescribeClusterNodePools", "2015-12-15", "HTTPS", "GET", "AK", "/clusters/" + ClusterId + "/nodepools", "json", req, runtime));
        }

        public async Task<DescribeClusterNodePoolsResponse> DescribeClusterNodePoolsWithOptionsAsync(string ClusterId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
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
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodepoolId))
            {
                query["nodepool_id"] = request.NodepoolId;
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
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NodepoolId))
            {
                query["nodepool_id"] = request.NodepoolId;
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<DescribeClusterResourcesResponse>(DoROARequest("DescribeClusterResources", "2015-12-15", "HTTPS", "GET", "AK", "/clusters/" + ClusterId + "/resources", "array", req, runtime));
        }

        public async Task<DescribeClusterResourcesResponse> DescribeClusterResourcesWithOptionsAsync(string ClusterId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
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
            return TeaModel.ToObject<DescribeClusterUserKubeconfigResponse>(DoROARequest("DescribeClusterUserKubeconfig", "2015-12-15", "HTTPS", "GET", "AK", "/k8s/" + ClusterId + "/user_config", "json", req, runtime));
        }

        public async Task<DescribeClusterUserKubeconfigResponse> DescribeClusterUserKubeconfigWithOptionsAsync(string ClusterId, DescribeClusterUserKubeconfigRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterType))
            {
                query["clusterType"] = request.ClusterType;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterType))
            {
                query["clusterType"] = request.ClusterType;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterType))
            {
                query["ClusterType"] = request.ClusterType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["page_size"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["page_number"] = request.PageNumber;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterType))
            {
                query["ClusterType"] = request.ClusterType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["page_size"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["page_number"] = request.PageNumber;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<DescribeClustersV1Response>(await DoROARequestAsync("DescribeClustersV1", "2015-12-15", "HTTPS", "GET", "AK", "/api/v1/clusters", "json", req, runtime));
        }

        public DescribeExternalAgentResponse DescribeExternalAgent(string ClusterId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeExternalAgentWithOptions(ClusterId, headers, runtime);
        }

        public async Task<DescribeExternalAgentResponse> DescribeExternalAgentAsync(string ClusterId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeExternalAgentWithOptionsAsync(ClusterId, headers, runtime);
        }

        public DescribeExternalAgentResponse DescribeExternalAgentWithOptions(string ClusterId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<DescribeExternalAgentResponse>(DoROARequest("DescribeExternalAgent", "2015-12-15", "HTTPS", "GET", "AK", "/k8s/" + ClusterId + "/external/agent/deployment", "json", req, runtime));
        }

        public async Task<DescribeExternalAgentResponse> DescribeExternalAgentWithOptionsAsync(string ClusterId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                query["Region"] = request.Region;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MultiAZ))
            {
                query["MultiAZ"] = request.MultiAZ;
            }
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                query["Region"] = request.Region;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MultiAZ))
            {
                query["MultiAZ"] = request.MultiAZ;
            }
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<DescribeKubernetesVersionMetadataResponse>(await DoROARequestAsync("DescribeKubernetesVersionMetadata", "2015-12-15", "HTTPS", "GET", "AK", "/api/v1/metadata/versions", "array", req, runtime));
        }

        public DescribeTemplateAttributeResponse DescribeTemplateAttribute(string TemplateId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeTemplateAttributeWithOptions(TemplateId, headers, runtime);
        }

        public async Task<DescribeTemplateAttributeResponse> DescribeTemplateAttributeAsync(string TemplateId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeTemplateAttributeWithOptionsAsync(TemplateId, headers, runtime);
        }

        public DescribeTemplateAttributeResponse DescribeTemplateAttributeWithOptions(string TemplateId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<DescribeTemplateAttributeResponse>(DoROARequest("DescribeTemplateAttribute", "2015-12-15", "HTTPS", "GET", "AK", "/templates/" + TemplateId, "array", req, runtime));
        }

        public async Task<DescribeTemplateAttributeResponse> DescribeTemplateAttributeWithOptionsAsync(string TemplateId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
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
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                query["Namespace"] = request.Namespace;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["Type"] = request.Type;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<GetKubernetesTriggerResponse>(DoROARequest("GetKubernetesTrigger", "2015-12-15", "HTTPS", "GET", "AK", "/triggers/" + ClusterId, "json", req, runtime));
        }

        public async Task<GetKubernetesTriggerResponse> GetKubernetesTriggerWithOptionsAsync(string ClusterId, GetKubernetesTriggerRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Namespace))
            {
                query["Namespace"] = request.Namespace;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["Type"] = request.Type;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<GetKubernetesTriggerResponse>(await DoROARequestAsync("GetKubernetesTrigger", "2015-12-15", "HTTPS", "GET", "AK", "/triggers/" + ClusterId, "json", req, runtime));
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<GetUpgradeStatusResponse>(DoROARequest("GetUpgradeStatus", "2015-12-15", "HTTPS", "GET", "AK", "/api/v2/clusters/" + ClusterId + "/upgrade/status", "json", req, runtime));
        }

        public async Task<GetUpgradeStatusResponse> GetUpgradeStatusWithOptionsAsync(string ClusterId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<GetUpgradeStatusResponse>(await DoROARequestAsync("GetUpgradeStatus", "2015-12-15", "HTTPS", "GET", "AK", "/api/v2/clusters/" + ClusterId + "/upgrade/status", "json", req, runtime));
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

        public ListTagResourcesResponse ListTagResourcesWithOptions(ListTagResourcesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["next_token"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceIds))
            {
                query["resource_ids"] = request.ResourceIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tags))
            {
                query["tags"] = request.Tags;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["resource_type"] = request.ResourceType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<ListTagResourcesResponse>(DoROARequest("ListTagResources", "2015-12-15", "HTTPS", "GET", "AK", "/tags", "json", req, runtime));
        }

        public async Task<ListTagResourcesResponse> ListTagResourcesWithOptionsAsync(ListTagResourcesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["next_token"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceIds))
            {
                query["resource_ids"] = request.ResourceIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tags))
            {
                query["tags"] = request.Tags;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["resource_type"] = request.ResourceType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<ListTagResourcesResponse>(await DoROARequestAsync("ListTagResources", "2015-12-15", "HTTPS", "GET", "AK", "/tags", "json", req, runtime));
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                body["resource_group_id"] = request.ResourceGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = body,
            };
            return TeaModel.ToObject<ModifyClusterResponse>(DoROARequest("ModifyCluster", "2015-12-15", "HTTPS", "PUT", "AK", "/api/v2/clusters/" + ClusterId, "json", req, runtime));
        }

        public async Task<ModifyClusterResponse> ModifyClusterWithOptionsAsync(string ClusterId, ModifyClusterRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                body["resource_group_id"] = request.ResourceGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = body,
            };
            return TeaModel.ToObject<ModifyClusterResponse>(await DoROARequestAsync("ModifyCluster", "2015-12-15", "HTTPS", "PUT", "AK", "/api/v2/clusters/" + ClusterId, "json", req, runtime));
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
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Configs.ToMap()))
            {
                body["configs"] = request.Configs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = body,
            };
            return TeaModel.ToObject<ModifyClusterConfigurationResponse>(DoROARequest("ModifyClusterConfiguration", "2015-12-15", "HTTPS", "PUT", "AK", "/clusters/" + ClusterId + "/configuration", "none", req, runtime));
        }

        public async Task<ModifyClusterConfigurationResponse> ModifyClusterConfigurationWithOptionsAsync(string ClusterId, ModifyClusterConfigurationRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Configs.ToMap()))
            {
                body["configs"] = request.Configs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = body,
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
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoScaling.ToMap()))
            {
                body["auto_scaling"] = request.AutoScaling;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KubernetesConfig.ToMap()))
            {
                body["kubernetes_config"] = request.KubernetesConfig;
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
                Body = body,
            };
            return TeaModel.ToObject<ModifyClusterNodePoolResponse>(DoROARequest("ModifyClusterNodePool", "2015-12-15", "HTTPS", "PUT", "AK", "/clusters/" + ClusterId + "/nodepools/{NodepoolId}", "none", req, runtime));
        }

        public async Task<ModifyClusterNodePoolResponse> ModifyClusterNodePoolWithOptionsAsync(string ClusterId, string NodepoolId, ModifyClusterNodePoolRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoScaling.ToMap()))
            {
                body["auto_scaling"] = request.AutoScaling;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KubernetesConfig.ToMap()))
            {
                body["kubernetes_config"] = request.KubernetesConfig;
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
                Body = body,
            };
            return TeaModel.ToObject<ModifyClusterNodePoolResponse>(await DoROARequestAsync("ModifyClusterNodePool", "2015-12-15", "HTTPS", "PUT", "AK", "/clusters/" + ClusterId + "/nodepools/{NodepoolId}", "none", req, runtime));
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.TeaUtil.Common.ToArray(request.Body),
            };
            return TeaModel.ToObject<ModifyClusterTagsResponse>(await DoROARequestAsync("ModifyClusterTags", "2015-12-15", "HTTPS", "POST", "AK", "/clusters/" + ClusterId + "/tags", "none", req, runtime));
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<PauseClusterUpgradeResponse>(DoROARequest("PauseClusterUpgrade", "2015-12-15", "HTTPS", "POST", "AK", "/api/v2/clusters/" + ClusterId + "/upgrade/pause", "none", req, runtime));
        }

        public async Task<PauseClusterUpgradeResponse> PauseClusterUpgradeWithOptionsAsync(string ClusterId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<PauseComponentUpgradeResponse>(DoROARequest("PauseComponentUpgrade", "2015-12-15", "HTTPS", "POST", "AK", "/clusters/" + clusterid + "/components/{componentid}/pause", "none", req, runtime));
        }

        public async Task<PauseComponentUpgradeResponse> PauseComponentUpgradeWithOptionsAsync(string clusterid, string componentid, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<PauseComponentUpgradeResponse>(await DoROARequestAsync("PauseComponentUpgrade", "2015-12-15", "HTTPS", "POST", "AK", "/clusters/" + clusterid + "/components/{componentid}/pause", "none", req, runtime));
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
                Body = body,
            };
            return TeaModel.ToObject<RemoveClusterNodesResponse>(DoROARequest("RemoveClusterNodes", "2015-12-15", "HTTPS", "POST", "AK", "/api/v2/clusters/" + ClusterId + "/nodes/remove", "none", req, runtime));
        }

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
                Body = body,
            };
            return TeaModel.ToObject<RemoveClusterNodesResponse>(await DoROARequestAsync("RemoveClusterNodes", "2015-12-15", "HTTPS", "POST", "AK", "/api/v2/clusters/" + ClusterId + "/nodes/remove", "none", req, runtime));
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<ResumeComponentUpgradeResponse>(DoROARequest("ResumeComponentUpgrade", "2015-12-15", "HTTPS", "POST", "AK", "/clusters/" + clusterid + "/components/{componentid}/resume", "none", req, runtime));
        }

        public async Task<ResumeComponentUpgradeResponse> ResumeComponentUpgradeWithOptionsAsync(string clusterid, string componentid, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<ResumeComponentUpgradeResponse>(await DoROARequestAsync("ResumeComponentUpgrade", "2015-12-15", "HTTPS", "POST", "AK", "/clusters/" + clusterid + "/components/{componentid}/resume", "none", req, runtime));
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<ResumeUpgradeClusterResponse>(DoROARequest("ResumeUpgradeCluster", "2015-12-15", "HTTPS", "POST", "AK", "/api/v2/clusters/" + ClusterId + "/upgrade/resume", "none", req, runtime));
        }

        public async Task<ResumeUpgradeClusterResponse> ResumeUpgradeClusterWithOptionsAsync(string ClusterId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
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
                Body = body,
            };
            return TeaModel.ToObject<ScaleClusterResponse>(DoROARequest("ScaleCluster", "2015-12-15", "HTTPS", "PUT", "AK", "/clusters/" + ClusterId, "json", req, runtime));
        }

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
                Body = body,
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
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Count))
            {
                body["count"] = request.Count;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KubernetesConfig.ToMap()))
            {
                body["kubernetes_config"] = request.KubernetesConfig;
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
                Body = body,
            };
            return TeaModel.ToObject<ScaleClusterNodePoolResponse>(DoROARequest("ScaleClusterNodePool", "2015-12-15", "HTTPS", "POST", "AK", "/clusters/" + ClusterId + "/nodepools/{NodepoolId}", "none", req, runtime));
        }

        public async Task<ScaleClusterNodePoolResponse> ScaleClusterNodePoolWithOptionsAsync(string ClusterId, string NodepoolId, ScaleClusterNodePoolRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Count))
            {
                body["count"] = request.Count;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KubernetesConfig.ToMap()))
            {
                body["kubernetes_config"] = request.KubernetesConfig;
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
                Body = body,
            };
            return TeaModel.ToObject<ScaleClusterNodePoolResponse>(await DoROARequestAsync("ScaleClusterNodePool", "2015-12-15", "HTTPS", "POST", "AK", "/clusters/" + ClusterId + "/nodepools/{NodepoolId}", "none", req, runtime));
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
                Body = body,
            };
            return TeaModel.ToObject<ScaleOutClusterResponse>(DoROARequest("ScaleOutCluster", "2015-12-15", "HTTPS", "POST", "AK", "/api/v2/clusters/" + ClusterId, "json", req, runtime));
        }

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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisableRollback))
            {
                body["disable_rollback"] = request.DisableRollback;
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
                Body = body,
            };
            return TeaModel.ToObject<ScaleOutClusterResponse>(await DoROARequestAsync("ScaleOutCluster", "2015-12-15", "HTTPS", "POST", "AK", "/api/v2/clusters/" + ClusterId, "json", req, runtime));
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.TeaUtil.Common.ToArray(request.Addons),
            };
            return TeaModel.ToObject<UnInstallClusterAddonsResponse>(await DoROARequestAsync("UnInstallClusterAddons", "2015-12-15", "HTTPS", "POST", "AK", "/clusters/" + ClusterId + "/components/uninstall", "none", req, runtime));
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
                Body = body,
            };
            return TeaModel.ToObject<UpdateTemplateResponse>(DoROARequest("UpdateTemplate", "2015-12-15", "HTTPS", "PUT", "AK", "/templates/" + TemplateId, "none", req, runtime));
        }

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
                Body = body,
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
                Body = body,
            };
            return TeaModel.ToObject<UpgradeClusterResponse>(DoROARequest("UpgradeCluster", "2015-12-15", "HTTPS", "POST", "AK", "/api/v2/clusters/" + ClusterId + "/upgrade", "none", req, runtime));
        }

        public async Task<UpgradeClusterResponse> UpgradeClusterWithOptionsAsync(string ClusterId, UpgradeClusterRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
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
                Body = body,
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.TeaUtil.Common.ToArray(request.Body),
            };
            return TeaModel.ToObject<UpgradeClusterAddonsResponse>(await DoROARequestAsync("UpgradeClusterAddons", "2015-12-15", "HTTPS", "POST", "AK", "/clusters/" + ClusterId + "/components/upgrade", "none", req, runtime));
        }

    }
}
