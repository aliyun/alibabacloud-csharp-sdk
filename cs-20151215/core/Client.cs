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
            body["instances"] = request.Instances;
            body["runtime"] = request.Runtime;
            body["image_id"] = request.ImageId;
            body["format_disk"] = request.FormatDisk;
            body["keep_instance_name"] = request.KeepInstanceName;
            body["cpu_policy"] = request.CpuPolicy;
            body["key_pair"] = request.KeyPair;
            body["password"] = request.Password;
            body["is_edge_worker"] = request.IsEdgeWorker;
            body["user_data"] = request.UserData;
            body["nodepool_id"] = request.NodepoolId;
            body["rds_instances"] = request.RdsInstances;
            body["tags"] = request.Tags;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = body,
            };
            return TeaModel.ToObject<AttachInstancesResponse>(DoROARequestWithForm("AttachInstances", "2015-12-15", "HTTPS", "POST", "AK", "/clusters/" + ClusterId + "/attach", "json", req, runtime));
        }

        public async Task<AttachInstancesResponse> AttachInstancesWithOptionsAsync(string ClusterId, AttachInstancesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            body["instances"] = request.Instances;
            body["runtime"] = request.Runtime;
            body["image_id"] = request.ImageId;
            body["format_disk"] = request.FormatDisk;
            body["keep_instance_name"] = request.KeepInstanceName;
            body["cpu_policy"] = request.CpuPolicy;
            body["key_pair"] = request.KeyPair;
            body["password"] = request.Password;
            body["is_edge_worker"] = request.IsEdgeWorker;
            body["user_data"] = request.UserData;
            body["nodepool_id"] = request.NodepoolId;
            body["rds_instances"] = request.RdsInstances;
            body["tags"] = request.Tags;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = body,
            };
            return TeaModel.ToObject<AttachInstancesResponse>(await DoROARequestWithFormAsync("AttachInstances", "2015-12-15", "HTTPS", "POST", "AK", "/clusters/" + ClusterId + "/attach", "json", req, runtime));
        }

        public CancelClusterUpgradeResponse CancelClusterUpgrade(string ClusterId, CancelClusterUpgradeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CancelClusterUpgradeWithOptions(ClusterId, request, headers, runtime);
        }

        public async Task<CancelClusterUpgradeResponse> CancelClusterUpgradeAsync(string ClusterId, CancelClusterUpgradeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CancelClusterUpgradeWithOptionsAsync(ClusterId, request, headers, runtime);
        }

        public CancelClusterUpgradeResponse CancelClusterUpgradeWithOptions(string ClusterId, CancelClusterUpgradeRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<CancelClusterUpgradeResponse>(DoROARequest("CancelClusterUpgrade", "2015-12-15", "HTTPS", "POST", "AK", "/api/v2/clusters/" + ClusterId + "/upgrade/cancel", "none", req, runtime));
        }

        public async Task<CancelClusterUpgradeResponse> CancelClusterUpgradeWithOptionsAsync(string ClusterId, CancelClusterUpgradeRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<CancelClusterUpgradeResponse>(await DoROARequestAsync("CancelClusterUpgrade", "2015-12-15", "HTTPS", "POST", "AK", "/api/v2/clusters/" + ClusterId + "/upgrade/cancel", "none", req, runtime));
        }

        public CancelComponentUpgradeResponse CancelComponentUpgrade(string clusterid, string componentid, CancelComponentUpgradeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CancelComponentUpgradeWithOptions(clusterid, componentid, request, headers, runtime);
        }

        public async Task<CancelComponentUpgradeResponse> CancelComponentUpgradeAsync(string clusterid, string componentid, CancelComponentUpgradeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CancelComponentUpgradeWithOptionsAsync(clusterid, componentid, request, headers, runtime);
        }

        public CancelComponentUpgradeResponse CancelComponentUpgradeWithOptions(string clusterid, string componentid, CancelComponentUpgradeRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<CancelComponentUpgradeResponse>(DoROARequest("CancelComponentUpgrade", "2015-12-15", "HTTPS", "POST", "AK", "/clusters/" + clusterid + "/components/{componentid}/cancel", "none", req, runtime));
        }

        public async Task<CancelComponentUpgradeResponse> CancelComponentUpgradeWithOptionsAsync(string clusterid, string componentid, CancelComponentUpgradeRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
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
            body["name"] = request.Name;
            body["cluster_type"] = request.ClusterType;
            body["region_id"] = request.RegionId;
            body["zone_id"] = request.ZoneId;
            body["kubernetes_version"] = request.KubernetesVersion;
            body["deletion_protection"] = request.DeletionProtection;
            body["runtime"] = request.Runtime;
            body["vpcid"] = request.Vpcid;
            body["worker_vswitch_ids"] = request.WorkerVswitchIds;
            body["container_cidr"] = request.ContainerCidr;
            body["service_cidr"] = request.ServiceCidr;
            body["node_cidr_mask"] = request.NodeCidrMask;
            body["snat_entry"] = request.SnatEntry;
            body["endpoint_public_access"] = request.EndpointPublicAccess;
            body["ssh_flags"] = request.SshFlags;
            body["rds_instances"] = request.RdsInstances;
            body["security_group_id"] = request.SecurityGroupId;
            body["is_enterprise_security_group"] = request.IsEnterpriseSecurityGroup;
            body["proxy_mode"] = request.ProxyMode;
            body["tags"] = request.Tags;
            body["images_id"] = request.ImagesId;
            body["master_instance_charge_type"] = request.MasterInstanceChargeType;
            body["master_period"] = request.MasterPeriod;
            body["master_period_unit"] = request.MasterPeriodUnit;
            body["master_auto_renew"] = request.MasterAutoRenew;
            body["master_auto_renew_period"] = request.MasterAutoRenewPeriod;
            body["master_count"] = request.MasterCount;
            body["master_vswitch_ids"] = request.MasterVswitchIds;
            body["master_instance_types"] = request.MasterInstanceTypes;
            body["master_system_disk_category"] = request.MasterSystemDiskCategory;
            body["master_system_disk_size"] = request.MasterSystemDiskSize;
            body["worker_instance_charge_type"] = request.WorkerInstanceChargeType;
            body["worker_period"] = request.WorkerPeriod;
            body["worker_period_unit"] = request.WorkerPeriodUnit;
            body["worker_auto_renew"] = request.WorkerAutoRenew;
            body["worker_auto_renew_period"] = request.WorkerAutoRenewPeriod;
            body["num_of_nodes"] = request.NumOfNodes;
            body["worker_instance_types"] = request.WorkerInstanceTypes;
            body["worker_system_disk_category"] = request.WorkerSystemDiskCategory;
            body["worker_system_disk_size"] = request.WorkerSystemDiskSize;
            body["worker_data_disks"] = request.WorkerDataDisks;
            body["os_type"] = request.OsType;
            body["key_pair"] = request.KeyPair;
            body["login_password"] = request.LoginPassword;
            body["user_data"] = request.UserData;
            body["node_port_range"] = request.NodePortRange;
            body["cpu_policy"] = request.CpuPolicy;
            body["taints"] = request.Taints;
            body["cloud_monitor_flags"] = request.CloudMonitorFlags;
            body["addons"] = request.Addons;
            body["platform"] = request.Platform;
            body["vswitch_ids"] = request.VswitchIds;
            body["private_zone"] = request.PrivateZone;
            body["profile"] = request.Profile;
            body["pod_vswitch_ids"] = request.PodVswitchIds;
            body["disable_rollback"] = request.DisableRollback;
            body["timeout_mins"] = request.TimeoutMins;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = body,
            };
            return TeaModel.ToObject<CreateClusterResponse>(DoROARequestWithForm("CreateCluster", "2015-12-15", "HTTPS", "POST", "AK", "/clusters", "json", req, runtime));
        }

        public async Task<CreateClusterResponse> CreateClusterWithOptionsAsync(CreateClusterRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            body["name"] = request.Name;
            body["cluster_type"] = request.ClusterType;
            body["region_id"] = request.RegionId;
            body["zone_id"] = request.ZoneId;
            body["kubernetes_version"] = request.KubernetesVersion;
            body["deletion_protection"] = request.DeletionProtection;
            body["runtime"] = request.Runtime;
            body["vpcid"] = request.Vpcid;
            body["worker_vswitch_ids"] = request.WorkerVswitchIds;
            body["container_cidr"] = request.ContainerCidr;
            body["service_cidr"] = request.ServiceCidr;
            body["node_cidr_mask"] = request.NodeCidrMask;
            body["snat_entry"] = request.SnatEntry;
            body["endpoint_public_access"] = request.EndpointPublicAccess;
            body["ssh_flags"] = request.SshFlags;
            body["rds_instances"] = request.RdsInstances;
            body["security_group_id"] = request.SecurityGroupId;
            body["is_enterprise_security_group"] = request.IsEnterpriseSecurityGroup;
            body["proxy_mode"] = request.ProxyMode;
            body["tags"] = request.Tags;
            body["images_id"] = request.ImagesId;
            body["master_instance_charge_type"] = request.MasterInstanceChargeType;
            body["master_period"] = request.MasterPeriod;
            body["master_period_unit"] = request.MasterPeriodUnit;
            body["master_auto_renew"] = request.MasterAutoRenew;
            body["master_auto_renew_period"] = request.MasterAutoRenewPeriod;
            body["master_count"] = request.MasterCount;
            body["master_vswitch_ids"] = request.MasterVswitchIds;
            body["master_instance_types"] = request.MasterInstanceTypes;
            body["master_system_disk_category"] = request.MasterSystemDiskCategory;
            body["master_system_disk_size"] = request.MasterSystemDiskSize;
            body["worker_instance_charge_type"] = request.WorkerInstanceChargeType;
            body["worker_period"] = request.WorkerPeriod;
            body["worker_period_unit"] = request.WorkerPeriodUnit;
            body["worker_auto_renew"] = request.WorkerAutoRenew;
            body["worker_auto_renew_period"] = request.WorkerAutoRenewPeriod;
            body["num_of_nodes"] = request.NumOfNodes;
            body["worker_instance_types"] = request.WorkerInstanceTypes;
            body["worker_system_disk_category"] = request.WorkerSystemDiskCategory;
            body["worker_system_disk_size"] = request.WorkerSystemDiskSize;
            body["worker_data_disks"] = request.WorkerDataDisks;
            body["os_type"] = request.OsType;
            body["key_pair"] = request.KeyPair;
            body["login_password"] = request.LoginPassword;
            body["user_data"] = request.UserData;
            body["node_port_range"] = request.NodePortRange;
            body["cpu_policy"] = request.CpuPolicy;
            body["taints"] = request.Taints;
            body["cloud_monitor_flags"] = request.CloudMonitorFlags;
            body["addons"] = request.Addons;
            body["platform"] = request.Platform;
            body["vswitch_ids"] = request.VswitchIds;
            body["private_zone"] = request.PrivateZone;
            body["profile"] = request.Profile;
            body["pod_vswitch_ids"] = request.PodVswitchIds;
            body["disable_rollback"] = request.DisableRollback;
            body["timeout_mins"] = request.TimeoutMins;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = body,
            };
            return TeaModel.ToObject<CreateClusterResponse>(await DoROARequestWithFormAsync("CreateCluster", "2015-12-15", "HTTPS", "POST", "AK", "/clusters", "json", req, runtime));
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
            body["RegionId"] = request.RegionId;
            body["ClusterId"] = request.ClusterId;
            body["ProjectId"] = request.ProjectId;
            body["Type"] = request.Type;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = body,
            };
            return TeaModel.ToObject<CreateKubernetesTriggerResponse>(DoROARequestWithForm("CreateKubernetesTrigger", "2015-12-15", "HTTPS", "POST", "AK", "/triggers", "json", req, runtime));
        }

        public async Task<CreateKubernetesTriggerResponse> CreateKubernetesTriggerWithOptionsAsync(CreateKubernetesTriggerRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            body["RegionId"] = request.RegionId;
            body["ClusterId"] = request.ClusterId;
            body["ProjectId"] = request.ProjectId;
            body["Type"] = request.Type;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = body,
            };
            return TeaModel.ToObject<CreateKubernetesTriggerResponse>(await DoROARequestWithFormAsync("CreateKubernetesTrigger", "2015-12-15", "HTTPS", "POST", "AK", "/triggers", "json", req, runtime));
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
            query["retain_resources"] = request.RetainResources;
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
            query["retain_resources"] = request.RetainResources;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<DeleteClusterResponse>(await DoROARequestAsync("DeleteCluster", "2015-12-15", "HTTPS", "DELETE", "AK", "/clusters/" + ClusterId, "none", req, runtime));
        }

        public DeleteKubernetesTriggerResponse DeleteKubernetesTrigger(string Id, DeleteKubernetesTriggerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteKubernetesTriggerWithOptions(Id, request, headers, runtime);
        }

        public async Task<DeleteKubernetesTriggerResponse> DeleteKubernetesTriggerAsync(string Id, DeleteKubernetesTriggerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteKubernetesTriggerWithOptionsAsync(Id, request, headers, runtime);
        }

        public DeleteKubernetesTriggerResponse DeleteKubernetesTriggerWithOptions(string Id, DeleteKubernetesTriggerRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<DeleteKubernetesTriggerResponse>(DoROARequest("DeleteKubernetesTrigger", "2015-12-15", "HTTPS", "DELETE", "AK", "/triggers/revoke/" + Id, "none", req, runtime));
        }

        public async Task<DeleteKubernetesTriggerResponse> DeleteKubernetesTriggerWithOptionsAsync(string Id, DeleteKubernetesTriggerRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
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
            query["region"] = request.Region;
            query["cluster_type"] = request.ClusterType;
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
            query["region"] = request.Region;
            query["cluster_type"] = request.ClusterType;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<DescribeAddonsResponse>(await DoROARequestAsync("DescribeAddons", "2015-12-15", "HTTPS", "GET", "AK", "/clusters/components/metadata", "json", req, runtime));
        }

        public DescribeClusterAddonUpgradeStatusResponse DescribeClusterAddonUpgradeStatus(string ClusterId, string ComponentId, DescribeClusterAddonUpgradeStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeClusterAddonUpgradeStatusWithOptions(ClusterId, ComponentId, request, headers, runtime);
        }

        public async Task<DescribeClusterAddonUpgradeStatusResponse> DescribeClusterAddonUpgradeStatusAsync(string ClusterId, string ComponentId, DescribeClusterAddonUpgradeStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeClusterAddonUpgradeStatusWithOptionsAsync(ClusterId, ComponentId, request, headers, runtime);
        }

        public DescribeClusterAddonUpgradeStatusResponse DescribeClusterAddonUpgradeStatusWithOptions(string ClusterId, string ComponentId, DescribeClusterAddonUpgradeStatusRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<DescribeClusterAddonUpgradeStatusResponse>(DoROARequest("DescribeClusterAddonUpgradeStatus", "2015-12-15", "HTTPS", "GET", "AK", "/clusters/" + ClusterId + "/components/{ComponentId}/upgradestatus", "json", req, runtime));
        }

        public async Task<DescribeClusterAddonUpgradeStatusResponse> DescribeClusterAddonUpgradeStatusWithOptionsAsync(string ClusterId, string ComponentId, DescribeClusterAddonUpgradeStatusRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
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
            query["componentIds"] = request.ComponentIds;
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
            query["componentIds"] = request.ComponentIds;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<DescribeClusterAddonsUpgradeStatusResponse>(await DoROARequestAsync("DescribeClusterAddonsUpgradeStatus", "2015-12-15", "HTTPS", "GET", "AK", "/clusters/[ClusterId]/components/upgradestatus", "none", req, runtime));
        }

        public DescribeClusterAddonsVersionResponse DescribeClusterAddonsVersion(string ClusterId, DescribeClusterAddonsVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeClusterAddonsVersionWithOptions(ClusterId, request, headers, runtime);
        }

        public async Task<DescribeClusterAddonsVersionResponse> DescribeClusterAddonsVersionAsync(string ClusterId, DescribeClusterAddonsVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeClusterAddonsVersionWithOptionsAsync(ClusterId, request, headers, runtime);
        }

        public DescribeClusterAddonsVersionResponse DescribeClusterAddonsVersionWithOptions(string ClusterId, DescribeClusterAddonsVersionRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<DescribeClusterAddonsVersionResponse>(DoROARequest("DescribeClusterAddonsVersion", "2015-12-15", "HTTPS", "GET", "AK", "/clusters/" + ClusterId + "/components/version", "json", req, runtime));
        }

        public async Task<DescribeClusterAddonsVersionResponse> DescribeClusterAddonsVersionWithOptionsAsync(string ClusterId, DescribeClusterAddonsVersionRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
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
            body["arch"] = request.Arch;
            body["options"] = request.Options;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = body,
            };
            return TeaModel.ToObject<DescribeClusterAttachScriptsResponse>(DoROARequestWithForm("DescribeClusterAttachScripts", "2015-12-15", "HTTPS", "POST", "AK", "/clusters/" + ClusterId + "/attachscript", "string", req, runtime));
        }

        public async Task<DescribeClusterAttachScriptsResponse> DescribeClusterAttachScriptsWithOptionsAsync(string ClusterId, DescribeClusterAttachScriptsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            body["arch"] = request.Arch;
            body["options"] = request.Options;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = body,
            };
            return TeaModel.ToObject<DescribeClusterAttachScriptsResponse>(await DoROARequestWithFormAsync("DescribeClusterAttachScripts", "2015-12-15", "HTTPS", "POST", "AK", "/clusters/" + ClusterId + "/attachscript", "string", req, runtime));
        }

        public DescribeClusterDetailResponse DescribeClusterDetail(string ClusterId, DescribeClusterDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeClusterDetailWithOptions(ClusterId, request, headers, runtime);
        }

        public async Task<DescribeClusterDetailResponse> DescribeClusterDetailAsync(string ClusterId, DescribeClusterDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeClusterDetailWithOptionsAsync(ClusterId, request, headers, runtime);
        }

        public DescribeClusterDetailResponse DescribeClusterDetailWithOptions(string ClusterId, DescribeClusterDetailRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<DescribeClusterDetailResponse>(DoROARequest("DescribeClusterDetail", "2015-12-15", "HTTPS", "GET", "AK", "/clusters/" + ClusterId, "json", req, runtime));
        }

        public async Task<DescribeClusterDetailResponse> DescribeClusterDetailWithOptionsAsync(string ClusterId, DescribeClusterDetailRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<DescribeClusterDetailResponse>(await DoROARequestAsync("DescribeClusterDetail", "2015-12-15", "HTTPS", "GET", "AK", "/clusters/" + ClusterId, "json", req, runtime));
        }

        public DescribeClusterLogsResponse DescribeClusterLogs(string ClusterId, DescribeClusterLogsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeClusterLogsWithOptions(ClusterId, request, headers, runtime);
        }

        public async Task<DescribeClusterLogsResponse> DescribeClusterLogsAsync(string ClusterId, DescribeClusterLogsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeClusterLogsWithOptionsAsync(ClusterId, request, headers, runtime);
        }

        public DescribeClusterLogsResponse DescribeClusterLogsWithOptions(string ClusterId, DescribeClusterLogsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<DescribeClusterLogsResponse>(DoROARequest("DescribeClusterLogs", "2015-12-15", "HTTPS", "GET", "AK", "/clusters/" + ClusterId + "/logs", "json", req, runtime));
        }

        public async Task<DescribeClusterLogsResponse> DescribeClusterLogsWithOptionsAsync(string ClusterId, DescribeClusterLogsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<DescribeClusterLogsResponse>(await DoROARequestAsync("DescribeClusterLogs", "2015-12-15", "HTTPS", "GET", "AK", "/clusters/" + ClusterId + "/logs", "json", req, runtime));
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
            query["pageSize"] = request.PageSize;
            query["pageNumber"] = request.PageNumber;
            query["nodepool_id"] = request.NodepoolId;
            query["state"] = request.State;
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
            query["pageSize"] = request.PageSize;
            query["pageNumber"] = request.PageNumber;
            query["nodepool_id"] = request.NodepoolId;
            query["state"] = request.State;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<DescribeClusterNodesResponse>(await DoROARequestAsync("DescribeClusterNodes", "2015-12-15", "HTTPS", "GET", "AK", "/clusters/" + ClusterId + "/nodes", "json", req, runtime));
        }

        public DescribeClusterResourcesResponse DescribeClusterResources(string ClusterId, DescribeClusterResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeClusterResourcesWithOptions(ClusterId, request, headers, runtime);
        }

        public async Task<DescribeClusterResourcesResponse> DescribeClusterResourcesAsync(string ClusterId, DescribeClusterResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeClusterResourcesWithOptionsAsync(ClusterId, request, headers, runtime);
        }

        public DescribeClusterResourcesResponse DescribeClusterResourcesWithOptions(string ClusterId, DescribeClusterResourcesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<DescribeClusterResourcesResponse>(DoROARequest("DescribeClusterResources", "2015-12-15", "HTTPS", "GET", "AK", "/clusters/" + ClusterId + "/resources", "array", req, runtime));
        }

        public async Task<DescribeClusterResourcesResponse> DescribeClusterResourcesWithOptionsAsync(string ClusterId, DescribeClusterResourcesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
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
            query["PrivateIpAddress"] = request.PrivateIpAddress;
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
            query["PrivateIpAddress"] = request.PrivateIpAddress;
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
            query["PrivateIpAddress"] = request.PrivateIpAddress;
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
            query["PrivateIpAddress"] = request.PrivateIpAddress;
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
            query["name"] = request.Name;
            query["clusterType"] = request.ClusterType;
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
            query["name"] = request.Name;
            query["clusterType"] = request.ClusterType;
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
            query["Name"] = request.Name;
            query["ClusterType"] = request.ClusterType;
            query["page_size"] = request.PageSize;
            query["page_number"] = request.PageNumber;
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
            query["Name"] = request.Name;
            query["ClusterType"] = request.ClusterType;
            query["page_size"] = request.PageSize;
            query["page_number"] = request.PageNumber;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<DescribeClustersV1Response>(await DoROARequestAsync("DescribeClustersV1", "2015-12-15", "HTTPS", "GET", "AK", "/api/v1/clusters", "json", req, runtime));
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<DescribeExternalAgentResponse>(DoROARequest("DescribeExternalAgent", "2015-12-15", "HTTPS", "GET", "AK", "/k8s/" + ClusterId + "/external/agent/deployment", "json", req, runtime));
        }

        public async Task<DescribeExternalAgentResponse> DescribeExternalAgentWithOptionsAsync(string ClusterId, DescribeExternalAgentRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<DescribeExternalAgentResponse>(await DoROARequestAsync("DescribeExternalAgent", "2015-12-15", "HTTPS", "GET", "AK", "/k8s/" + ClusterId + "/external/agent/deployment", "json", req, runtime));
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
            query["template_type"] = request.TemplateType;
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
            query["template_type"] = request.TemplateType;
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
            query["Namespace"] = request.Namespace;
            query["Type"] = request.Type;
            query["Name"] = request.Name;
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
            query["Namespace"] = request.Namespace;
            query["Type"] = request.Type;
            query["Name"] = request.Name;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<GetKubernetesTriggerResponse>(await DoROARequestAsync("GetKubernetesTrigger", "2015-12-15", "HTTPS", "GET", "AK", "/triggers/" + ClusterId, "json", req, runtime));
        }

        public GetUpgradeStatusResponse GetUpgradeStatus(string ClusterId, GetUpgradeStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetUpgradeStatusWithOptions(ClusterId, request, headers, runtime);
        }

        public async Task<GetUpgradeStatusResponse> GetUpgradeStatusAsync(string ClusterId, GetUpgradeStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetUpgradeStatusWithOptionsAsync(ClusterId, request, headers, runtime);
        }

        public GetUpgradeStatusResponse GetUpgradeStatusWithOptions(string ClusterId, GetUpgradeStatusRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<GetUpgradeStatusResponse>(DoROARequest("GetUpgradeStatus", "2015-12-15", "HTTPS", "GET", "AK", "/api/v2/clusters/" + ClusterId + "/upgrade/status", "json", req, runtime));
        }

        public async Task<GetUpgradeStatusResponse> GetUpgradeStatusWithOptionsAsync(string ClusterId, GetUpgradeStatusRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
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
            body["deletion_protection"] = request.DeletionProtection;
            body["ingress_loadbalancer_id"] = request.IngressLoadbalancerId;
            body["api_server_eip"] = request.ApiServerEip;
            body["api_server_eip_id"] = request.ApiServerEipId;
            body["resource_group_id"] = request.ResourceGroupId;
            body["ingress_domain_rebinding"] = request.IngressDomainRebinding;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = body,
            };
            return TeaModel.ToObject<ModifyClusterResponse>(DoROARequestWithForm("ModifyCluster", "2015-12-15", "HTTPS", "PUT", "AK", "/api/v2/clusters/" + ClusterId, "json", req, runtime));
        }

        public async Task<ModifyClusterResponse> ModifyClusterWithOptionsAsync(string ClusterId, ModifyClusterRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            body["deletion_protection"] = request.DeletionProtection;
            body["ingress_loadbalancer_id"] = request.IngressLoadbalancerId;
            body["api_server_eip"] = request.ApiServerEip;
            body["api_server_eip_id"] = request.ApiServerEipId;
            body["resource_group_id"] = request.ResourceGroupId;
            body["ingress_domain_rebinding"] = request.IngressDomainRebinding;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = body,
            };
            return TeaModel.ToObject<ModifyClusterResponse>(await DoROARequestWithFormAsync("ModifyCluster", "2015-12-15", "HTTPS", "PUT", "AK", "/api/v2/clusters/" + ClusterId, "json", req, runtime));
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
            body["customize_config"] = request.CustomizeConfig;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = body,
            };
            return TeaModel.ToObject<ModifyClusterConfigurationResponse>(DoROARequestWithForm("ModifyClusterConfiguration", "2015-12-15", "HTTPS", "PUT", "AK", "/clusters/" + ClusterId + "/configuration", "none", req, runtime));
        }

        public async Task<ModifyClusterConfigurationResponse> ModifyClusterConfigurationWithOptionsAsync(string ClusterId, ModifyClusterConfigurationRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            body["customize_config"] = request.CustomizeConfig;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = body,
            };
            return TeaModel.ToObject<ModifyClusterConfigurationResponse>(await DoROARequestWithFormAsync("ModifyClusterConfiguration", "2015-12-15", "HTTPS", "PUT", "AK", "/clusters/" + ClusterId + "/configuration", "none", req, runtime));
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

        public PauseComponentUpgradeResponse PauseComponentUpgrade(string clusterid, string componentid, PauseComponentUpgradeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return PauseComponentUpgradeWithOptions(clusterid, componentid, request, headers, runtime);
        }

        public async Task<PauseComponentUpgradeResponse> PauseComponentUpgradeAsync(string clusterid, string componentid, PauseComponentUpgradeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await PauseComponentUpgradeWithOptionsAsync(clusterid, componentid, request, headers, runtime);
        }

        public PauseComponentUpgradeResponse PauseComponentUpgradeWithOptions(string clusterid, string componentid, PauseComponentUpgradeRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<PauseComponentUpgradeResponse>(DoROARequest("PauseComponentUpgrade", "2015-12-15", "HTTPS", "POST", "AK", "/clusters/" + clusterid + "/components/{componentid}/pause", "none", req, runtime));
        }

        public async Task<PauseComponentUpgradeResponse> PauseComponentUpgradeWithOptionsAsync(string clusterid, string componentid, PauseComponentUpgradeRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
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
            body["release_node"] = request.ReleaseNode;
            body["drain_node"] = request.DrainNode;
            body["nodes"] = request.Nodes;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = body,
            };
            return TeaModel.ToObject<RemoveClusterNodesResponse>(DoROARequestWithForm("RemoveClusterNodes", "2015-12-15", "HTTPS", "POST", "AK", "/api/v2/clusters/" + ClusterId + "/nodes/remove", "none", req, runtime));
        }

        public async Task<RemoveClusterNodesResponse> RemoveClusterNodesWithOptionsAsync(string ClusterId, RemoveClusterNodesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            body["release_node"] = request.ReleaseNode;
            body["drain_node"] = request.DrainNode;
            body["nodes"] = request.Nodes;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = body,
            };
            return TeaModel.ToObject<RemoveClusterNodesResponse>(await DoROARequestWithFormAsync("RemoveClusterNodes", "2015-12-15", "HTTPS", "POST", "AK", "/api/v2/clusters/" + ClusterId + "/nodes/remove", "none", req, runtime));
        }

        public ResumeComponentUpgradeResponse ResumeComponentUpgrade(string clusterid, string componentid, ResumeComponentUpgradeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ResumeComponentUpgradeWithOptions(clusterid, componentid, request, headers, runtime);
        }

        public async Task<ResumeComponentUpgradeResponse> ResumeComponentUpgradeAsync(string clusterid, string componentid, ResumeComponentUpgradeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ResumeComponentUpgradeWithOptionsAsync(clusterid, componentid, request, headers, runtime);
        }

        public ResumeComponentUpgradeResponse ResumeComponentUpgradeWithOptions(string clusterid, string componentid, ResumeComponentUpgradeRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<ResumeComponentUpgradeResponse>(DoROARequest("ResumeComponentUpgrade", "2015-12-15", "HTTPS", "POST", "AK", "/clusters/" + clusterid + "/components/{componentid}/resume", "none", req, runtime));
        }

        public async Task<ResumeComponentUpgradeResponse> ResumeComponentUpgradeWithOptionsAsync(string clusterid, string componentid, ResumeComponentUpgradeRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<ResumeComponentUpgradeResponse>(await DoROARequestAsync("ResumeComponentUpgrade", "2015-12-15", "HTTPS", "POST", "AK", "/clusters/" + clusterid + "/components/{componentid}/resume", "none", req, runtime));
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

        public ScaleClusterResponse ScaleClusterWithOptions(string ClusterId, ScaleClusterRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ScaleClusterShrinkRequest request = new ScaleClusterShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Taints))
            {
                request.TaintsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Taints, "taints", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            body["count"] = request.Count;
            body["key_pair"] = request.KeyPair;
            body["login_password"] = request.LoginPassword;
            body["worker_data_disk"] = request.WorkerDataDisk;
            body["worker_instance_types"] = request.WorkerInstanceTypes;
            body["worker_instance_charge_type"] = request.WorkerInstanceChargeType;
            body["worker_period"] = request.WorkerPeriod;
            body["worker_period_unit"] = request.WorkerPeriodUnit;
            body["worker_auto_renew"] = request.WorkerAutoRenew;
            body["worker_auto_renew_period"] = request.WorkerAutoRenewPeriod;
            body["worker_system_disk_category"] = request.WorkerSystemDiskCategory;
            body["worker_system_disk_size"] = request.WorkerSystemDiskSize;
            body["cloud_monitor_flags"] = request.CloudMonitorFlags;
            body["cpu_policy"] = request.CpuPolicy;
            body["disable_rollback"] = request.DisableRollback;
            body["vswitch_ids"] = request.VswitchIds;
            body["worker_data_disks"] = request.WorkerDataDisks;
            body["tags"] = request.Tags;
            body["taints"] = request.TaintsShrink;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = body,
            };
            return TeaModel.ToObject<ScaleClusterResponse>(DoROARequestWithForm("ScaleCluster", "2015-12-15", "HTTPS", "PUT", "AK", "/clusters/" + ClusterId, "json", req, runtime));
        }

        public async Task<ScaleClusterResponse> ScaleClusterWithOptionsAsync(string ClusterId, ScaleClusterRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ScaleClusterShrinkRequest request = new ScaleClusterShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Taints))
            {
                request.TaintsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Taints, "taints", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            body["count"] = request.Count;
            body["key_pair"] = request.KeyPair;
            body["login_password"] = request.LoginPassword;
            body["worker_data_disk"] = request.WorkerDataDisk;
            body["worker_instance_types"] = request.WorkerInstanceTypes;
            body["worker_instance_charge_type"] = request.WorkerInstanceChargeType;
            body["worker_period"] = request.WorkerPeriod;
            body["worker_period_unit"] = request.WorkerPeriodUnit;
            body["worker_auto_renew"] = request.WorkerAutoRenew;
            body["worker_auto_renew_period"] = request.WorkerAutoRenewPeriod;
            body["worker_system_disk_category"] = request.WorkerSystemDiskCategory;
            body["worker_system_disk_size"] = request.WorkerSystemDiskSize;
            body["cloud_monitor_flags"] = request.CloudMonitorFlags;
            body["cpu_policy"] = request.CpuPolicy;
            body["disable_rollback"] = request.DisableRollback;
            body["vswitch_ids"] = request.VswitchIds;
            body["worker_data_disks"] = request.WorkerDataDisks;
            body["tags"] = request.Tags;
            body["taints"] = request.TaintsShrink;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = body,
            };
            return TeaModel.ToObject<ScaleClusterResponse>(await DoROARequestWithFormAsync("ScaleCluster", "2015-12-15", "HTTPS", "PUT", "AK", "/clusters/" + ClusterId, "json", req, runtime));
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
            body["count"] = request.Count;
            body["worker_instance_charge_type"] = request.WorkerInstanceChargeType;
            body["worker_period"] = request.WorkerPeriod;
            body["worker_period_unit"] = request.WorkerPeriodUnit;
            body["worker_auto_renew"] = request.WorkerAutoRenew;
            body["worker_auto_renew_period"] = request.WorkerAutoRenewPeriod;
            body["worker_system_disk_category"] = request.WorkerSystemDiskCategory;
            body["worker_system_disk_size"] = request.WorkerSystemDiskSize;
            body["worker_data_disk"] = request.WorkerDataDisk;
            body["key_pair"] = request.KeyPair;
            body["login_password"] = request.LoginPassword;
            body["cloud_monitor_flags"] = request.CloudMonitorFlags;
            body["cpu_policy"] = request.CpuPolicy;
            body["disable_rollback"] = request.DisableRollback;
            body["image_id"] = request.ImageId;
            body["user_data"] = request.UserData;
            body["runtime"] = request.Runtime;
            body["vswitch_ids"] = request.VswitchIds;
            body["worker_instance_types"] = request.WorkerInstanceTypes;
            body["rds_instances"] = request.RdsInstances;
            body["worker_data_disks"] = request.WorkerDataDisks;
            body["tags"] = request.Tags;
            body["taints"] = request.Taints;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = body,
            };
            return TeaModel.ToObject<ScaleOutClusterResponse>(DoROARequestWithForm("ScaleOutCluster", "2015-12-15", "HTTPS", "POST", "AK", "/api/v2/clusters/" + ClusterId, "json", req, runtime));
        }

        public async Task<ScaleOutClusterResponse> ScaleOutClusterWithOptionsAsync(string ClusterId, ScaleOutClusterRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            body["count"] = request.Count;
            body["worker_instance_charge_type"] = request.WorkerInstanceChargeType;
            body["worker_period"] = request.WorkerPeriod;
            body["worker_period_unit"] = request.WorkerPeriodUnit;
            body["worker_auto_renew"] = request.WorkerAutoRenew;
            body["worker_auto_renew_period"] = request.WorkerAutoRenewPeriod;
            body["worker_system_disk_category"] = request.WorkerSystemDiskCategory;
            body["worker_system_disk_size"] = request.WorkerSystemDiskSize;
            body["worker_data_disk"] = request.WorkerDataDisk;
            body["key_pair"] = request.KeyPair;
            body["login_password"] = request.LoginPassword;
            body["cloud_monitor_flags"] = request.CloudMonitorFlags;
            body["cpu_policy"] = request.CpuPolicy;
            body["disable_rollback"] = request.DisableRollback;
            body["image_id"] = request.ImageId;
            body["user_data"] = request.UserData;
            body["runtime"] = request.Runtime;
            body["vswitch_ids"] = request.VswitchIds;
            body["worker_instance_types"] = request.WorkerInstanceTypes;
            body["rds_instances"] = request.RdsInstances;
            body["worker_data_disks"] = request.WorkerDataDisks;
            body["tags"] = request.Tags;
            body["taints"] = request.Taints;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = body,
            };
            return TeaModel.ToObject<ScaleOutClusterResponse>(await DoROARequestWithFormAsync("ScaleOutCluster", "2015-12-15", "HTTPS", "POST", "AK", "/api/v2/clusters/" + ClusterId, "json", req, runtime));
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
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            body["addons"] = request.Addons;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = body,
            };
            return TeaModel.ToObject<UnInstallClusterAddonsResponse>(DoROARequestWithForm("UnInstallClusterAddons", "2015-12-15", "HTTPS", "POST", "AK", "/clusters/" + ClusterId + "/components/uninstall", "none", req, runtime));
        }

        public async Task<UnInstallClusterAddonsResponse> UnInstallClusterAddonsWithOptionsAsync(string ClusterId, UnInstallClusterAddonsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            body["addons"] = request.Addons;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = body,
            };
            return TeaModel.ToObject<UnInstallClusterAddonsResponse>(await DoROARequestWithFormAsync("UnInstallClusterAddons", "2015-12-15", "HTTPS", "POST", "AK", "/clusters/" + ClusterId + "/components/uninstall", "none", req, runtime));
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
            body["name"] = request.Name;
            body["template"] = request.Template;
            body["tags"] = request.Tags;
            body["description"] = request.Description;
            body["template_type"] = request.TemplateType;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = body,
            };
            return TeaModel.ToObject<UpdateTemplateResponse>(DoROARequestWithForm("UpdateTemplate", "2015-12-15", "HTTPS", "PUT", "AK", "/templates/" + TemplateId, "none", req, runtime));
        }

        public async Task<UpdateTemplateResponse> UpdateTemplateWithOptionsAsync(string TemplateId, UpdateTemplateRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            body["name"] = request.Name;
            body["template"] = request.Template;
            body["tags"] = request.Tags;
            body["description"] = request.Description;
            body["template_type"] = request.TemplateType;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = body,
            };
            return TeaModel.ToObject<UpdateTemplateResponse>(await DoROARequestWithFormAsync("UpdateTemplate", "2015-12-15", "HTTPS", "PUT", "AK", "/templates/" + TemplateId, "none", req, runtime));
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
            body["component_name"] = request.ComponentName;
            body["version"] = request.Version;
            body["next_version"] = request.NextVersion;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = body,
            };
            return TeaModel.ToObject<UpgradeClusterResponse>(DoROARequestWithForm("UpgradeCluster", "2015-12-15", "HTTPS", "POST", "AK", "/api/v2/clusters/" + ClusterId + "/upgrade", "none", req, runtime));
        }

        public async Task<UpgradeClusterResponse> UpgradeClusterWithOptionsAsync(string ClusterId, UpgradeClusterRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            body["component_name"] = request.ComponentName;
            body["version"] = request.Version;
            body["next_version"] = request.NextVersion;
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = body,
            };
            return TeaModel.ToObject<UpgradeClusterResponse>(await DoROARequestWithFormAsync("UpgradeCluster", "2015-12-15", "HTTPS", "POST", "AK", "/api/v2/clusters/" + ClusterId + "/upgrade", "none", req, runtime));
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
