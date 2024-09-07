// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.EHPC20240730.Models;

namespace AlibabaCloud.SDK.EHPC20240730
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "regional";
            CheckConfig(config);
            this._endpoint = GetEndpoint("ehpc", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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
         * @summary 挂载共享存储
         *
         * @param tmpReq AttachSharedStoragesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return AttachSharedStoragesResponse
         */
        public AttachSharedStoragesResponse AttachSharedStoragesWithOptions(AttachSharedStoragesRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            AttachSharedStoragesShrinkRequest request = new AttachSharedStoragesShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SharedStorages))
            {
                request.SharedStoragesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SharedStorages, "SharedStorages", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SharedStoragesShrink))
            {
                query["SharedStorages"] = request.SharedStoragesShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AttachSharedStorages",
                Version = "2024-07-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AttachSharedStoragesResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 挂载共享存储
         *
         * @param tmpReq AttachSharedStoragesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return AttachSharedStoragesResponse
         */
        public async Task<AttachSharedStoragesResponse> AttachSharedStoragesWithOptionsAsync(AttachSharedStoragesRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            AttachSharedStoragesShrinkRequest request = new AttachSharedStoragesShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SharedStorages))
            {
                request.SharedStoragesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SharedStorages, "SharedStorages", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SharedStoragesShrink))
            {
                query["SharedStorages"] = request.SharedStoragesShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AttachSharedStorages",
                Version = "2024-07-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AttachSharedStoragesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 挂载共享存储
         *
         * @param request AttachSharedStoragesRequest
         * @return AttachSharedStoragesResponse
         */
        public AttachSharedStoragesResponse AttachSharedStorages(AttachSharedStoragesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AttachSharedStoragesWithOptions(request, runtime);
        }

        /**
         * @summary 挂载共享存储
         *
         * @param request AttachSharedStoragesRequest
         * @return AttachSharedStoragesResponse
         */
        public async Task<AttachSharedStoragesResponse> AttachSharedStoragesAsync(AttachSharedStoragesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AttachSharedStoragesWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 创建一个按量付费或者预付费（包年包月） 集群	
         *
         * @param tmpReq CreateClusterRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateClusterResponse
         */
        public CreateClusterResponse CreateClusterWithOptions(CreateClusterRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateClusterShrinkRequest request = new CreateClusterShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.AdditionalPackages))
            {
                request.AdditionalPackagesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.AdditionalPackages, "AdditionalPackages", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Addons))
            {
                request.AddonsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Addons, "Addons", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ClusterCredentials))
            {
                request.ClusterCredentialsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ClusterCredentials, "ClusterCredentials", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ClusterCustomConfiguration))
            {
                request.ClusterCustomConfigurationShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ClusterCustomConfiguration, "ClusterCustomConfiguration", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Manager))
            {
                request.ManagerShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Manager, "Manager", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Queues))
            {
                request.QueuesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Queues, "Queues", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SharedStorages))
            {
                request.SharedStoragesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SharedStorages, "SharedStorages", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Tags))
            {
                request.TagsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Tags, "Tags", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AdditionalPackagesShrink))
            {
                query["AdditionalPackages"] = request.AdditionalPackagesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AddonsShrink))
            {
                query["Addons"] = request.AddonsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientVersion))
            {
                query["ClientVersion"] = request.ClientVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterCategory))
            {
                query["ClusterCategory"] = request.ClusterCategory;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterCredentialsShrink))
            {
                query["ClusterCredentials"] = request.ClusterCredentialsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterCustomConfigurationShrink))
            {
                query["ClusterCustomConfiguration"] = request.ClusterCustomConfigurationShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterDescription))
            {
                query["ClusterDescription"] = request.ClusterDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterMode))
            {
                query["ClusterMode"] = request.ClusterMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterName))
            {
                query["ClusterName"] = request.ClusterName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterVSwitchId))
            {
                query["ClusterVSwitchId"] = request.ClusterVSwitchId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterVpcId))
            {
                query["ClusterVpcId"] = request.ClusterVpcId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeletionProtection))
            {
                query["DeletionProtection"] = request.DeletionProtection;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsEnterpriseSecurityGroup))
            {
                query["IsEnterpriseSecurityGroup"] = request.IsEnterpriseSecurityGroup;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ManagerShrink))
            {
                query["Manager"] = request.ManagerShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxCoreCount))
            {
                query["MaxCoreCount"] = request.MaxCoreCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxCount))
            {
                query["MaxCount"] = request.MaxCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueuesShrink))
            {
                query["Queues"] = request.QueuesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityGroupId))
            {
                query["SecurityGroupId"] = request.SecurityGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SharedStoragesShrink))
            {
                query["SharedStorages"] = request.SharedStoragesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagsShrink))
            {
                query["Tags"] = request.TagsShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateCluster",
                Version = "2024-07-30",
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
         * @summary 创建一个按量付费或者预付费（包年包月） 集群	
         *
         * @param tmpReq CreateClusterRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateClusterResponse
         */
        public async Task<CreateClusterResponse> CreateClusterWithOptionsAsync(CreateClusterRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateClusterShrinkRequest request = new CreateClusterShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.AdditionalPackages))
            {
                request.AdditionalPackagesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.AdditionalPackages, "AdditionalPackages", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Addons))
            {
                request.AddonsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Addons, "Addons", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ClusterCredentials))
            {
                request.ClusterCredentialsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ClusterCredentials, "ClusterCredentials", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ClusterCustomConfiguration))
            {
                request.ClusterCustomConfigurationShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ClusterCustomConfiguration, "ClusterCustomConfiguration", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Manager))
            {
                request.ManagerShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Manager, "Manager", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Queues))
            {
                request.QueuesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Queues, "Queues", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SharedStorages))
            {
                request.SharedStoragesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SharedStorages, "SharedStorages", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Tags))
            {
                request.TagsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Tags, "Tags", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AdditionalPackagesShrink))
            {
                query["AdditionalPackages"] = request.AdditionalPackagesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AddonsShrink))
            {
                query["Addons"] = request.AddonsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientVersion))
            {
                query["ClientVersion"] = request.ClientVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterCategory))
            {
                query["ClusterCategory"] = request.ClusterCategory;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterCredentialsShrink))
            {
                query["ClusterCredentials"] = request.ClusterCredentialsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterCustomConfigurationShrink))
            {
                query["ClusterCustomConfiguration"] = request.ClusterCustomConfigurationShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterDescription))
            {
                query["ClusterDescription"] = request.ClusterDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterMode))
            {
                query["ClusterMode"] = request.ClusterMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterName))
            {
                query["ClusterName"] = request.ClusterName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterVSwitchId))
            {
                query["ClusterVSwitchId"] = request.ClusterVSwitchId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterVpcId))
            {
                query["ClusterVpcId"] = request.ClusterVpcId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeletionProtection))
            {
                query["DeletionProtection"] = request.DeletionProtection;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsEnterpriseSecurityGroup))
            {
                query["IsEnterpriseSecurityGroup"] = request.IsEnterpriseSecurityGroup;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ManagerShrink))
            {
                query["Manager"] = request.ManagerShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxCoreCount))
            {
                query["MaxCoreCount"] = request.MaxCoreCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxCount))
            {
                query["MaxCount"] = request.MaxCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueuesShrink))
            {
                query["Queues"] = request.QueuesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityGroupId))
            {
                query["SecurityGroupId"] = request.SecurityGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SharedStoragesShrink))
            {
                query["SharedStorages"] = request.SharedStoragesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagsShrink))
            {
                query["Tags"] = request.TagsShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateCluster",
                Version = "2024-07-30",
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
         * @summary 创建一个按量付费或者预付费（包年包月） 集群	
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
         * @summary 创建一个按量付费或者预付费（包年包月） 集群	
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
         * @summary 集群扩容节点
         *
         * @param tmpReq CreateNodesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateNodesResponse
         */
        public CreateNodesResponse CreateNodesWithOptions(CreateNodesRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateNodesShrinkRequest request = new CreateNodesShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ComputeNode))
            {
                request.ComputeNodeShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ComputeNode, "ComputeNode", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ComputeNodeShrink))
            {
                query["ComputeNode"] = request.ComputeNodeShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Count))
            {
                query["Count"] = request.Count;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HPCInterConnect))
            {
                query["HPCInterConnect"] = request.HPCInterConnect;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HostnamePrefix))
            {
                query["HostnamePrefix"] = request.HostnamePrefix;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HostnameSuffix))
            {
                query["HostnameSuffix"] = request.HostnameSuffix;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeepAlive))
            {
                query["KeepAlive"] = request.KeepAlive;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueueName))
            {
                query["QueueName"] = request.QueueName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RamRole))
            {
                query["RamRole"] = request.RamRole;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VSwitchId))
            {
                query["VSwitchId"] = request.VSwitchId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateNodes",
                Version = "2024-07-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateNodesResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 集群扩容节点
         *
         * @param tmpReq CreateNodesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateNodesResponse
         */
        public async Task<CreateNodesResponse> CreateNodesWithOptionsAsync(CreateNodesRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateNodesShrinkRequest request = new CreateNodesShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ComputeNode))
            {
                request.ComputeNodeShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ComputeNode, "ComputeNode", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ComputeNodeShrink))
            {
                query["ComputeNode"] = request.ComputeNodeShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Count))
            {
                query["Count"] = request.Count;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HPCInterConnect))
            {
                query["HPCInterConnect"] = request.HPCInterConnect;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HostnamePrefix))
            {
                query["HostnamePrefix"] = request.HostnamePrefix;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HostnameSuffix))
            {
                query["HostnameSuffix"] = request.HostnameSuffix;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeepAlive))
            {
                query["KeepAlive"] = request.KeepAlive;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueueName))
            {
                query["QueueName"] = request.QueueName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RamRole))
            {
                query["RamRole"] = request.RamRole;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VSwitchId))
            {
                query["VSwitchId"] = request.VSwitchId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateNodes",
                Version = "2024-07-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateNodesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 集群扩容节点
         *
         * @param request CreateNodesRequest
         * @return CreateNodesResponse
         */
        public CreateNodesResponse CreateNodes(CreateNodesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateNodesWithOptions(request, runtime);
        }

        /**
         * @summary 集群扩容节点
         *
         * @param request CreateNodesRequest
         * @return CreateNodesResponse
         */
        public async Task<CreateNodesResponse> CreateNodesAsync(CreateNodesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateNodesWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Creates a queue for an Enterprise High Performance Computing (E-HPC) cluster.
         *
         * @param tmpReq CreateQueueRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateQueueResponse
         */
        public CreateQueueResponse CreateQueueWithOptions(CreateQueueRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateQueueShrinkRequest request = new CreateQueueShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Queue))
            {
                request.QueueShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Queue, "Queue", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueueShrink))
            {
                query["Queue"] = request.QueueShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateQueue",
                Version = "2024-07-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateQueueResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Creates a queue for an Enterprise High Performance Computing (E-HPC) cluster.
         *
         * @param tmpReq CreateQueueRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateQueueResponse
         */
        public async Task<CreateQueueResponse> CreateQueueWithOptionsAsync(CreateQueueRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateQueueShrinkRequest request = new CreateQueueShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Queue))
            {
                request.QueueShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Queue, "Queue", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueueShrink))
            {
                query["Queue"] = request.QueueShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateQueue",
                Version = "2024-07-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateQueueResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Creates a queue for an Enterprise High Performance Computing (E-HPC) cluster.
         *
         * @param request CreateQueueRequest
         * @return CreateQueueResponse
         */
        public CreateQueueResponse CreateQueue(CreateQueueRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateQueueWithOptions(request, runtime);
        }

        /**
         * @summary Creates a queue for an Enterprise High Performance Computing (E-HPC) cluster.
         *
         * @param request CreateQueueRequest
         * @return CreateQueueResponse
         */
        public async Task<CreateQueueResponse> CreateQueueAsync(CreateQueueRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateQueueWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 创建集群用户
         *
         * @param tmpReq CreateUsersRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateUsersResponse
         */
        public CreateUsersResponse CreateUsersWithOptions(CreateUsersRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateUsersShrinkRequest request = new CreateUsersShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.User))
            {
                request.UserShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.User, "User", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserShrink))
            {
                query["User"] = request.UserShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateUsers",
                Version = "2024-07-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateUsersResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 创建集群用户
         *
         * @param tmpReq CreateUsersRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateUsersResponse
         */
        public async Task<CreateUsersResponse> CreateUsersWithOptionsAsync(CreateUsersRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateUsersShrinkRequest request = new CreateUsersShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.User))
            {
                request.UserShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.User, "User", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserShrink))
            {
                query["User"] = request.UserShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateUsers",
                Version = "2024-07-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateUsersResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 创建集群用户
         *
         * @param request CreateUsersRequest
         * @return CreateUsersResponse
         */
        public CreateUsersResponse CreateUsers(CreateUsersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateUsersWithOptions(request, runtime);
        }

        /**
         * @summary 创建集群用户
         *
         * @param request CreateUsersRequest
         * @return CreateUsersResponse
         */
        public async Task<CreateUsersResponse> CreateUsersAsync(CreateUsersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateUsersWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Releases an Enterprise High Performance Computing (E-HPC) cluster.
         *
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteCluster",
                Version = "2024-07-30",
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
         * @summary Releases an Enterprise High Performance Computing (E-HPC) cluster.
         *
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteCluster",
                Version = "2024-07-30",
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
         * @summary Releases an Enterprise High Performance Computing (E-HPC) cluster.
         *
         * @param request DeleteClusterRequest
         * @return DeleteClusterResponse
         */
        public DeleteClusterResponse DeleteCluster(DeleteClusterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteClusterWithOptions(request, runtime);
        }

        /**
         * @summary Releases an Enterprise High Performance Computing (E-HPC) cluster.
         *
         * @param request DeleteClusterRequest
         * @return DeleteClusterResponse
         */
        public async Task<DeleteClusterResponse> DeleteClusterAsync(DeleteClusterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteClusterWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 删除作业
         *
         * @param tmpReq DeleteJobsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteJobsResponse
         */
        public DeleteJobsResponse DeleteJobsWithOptions(DeleteJobsRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DeleteJobsShrinkRequest request = new DeleteJobsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.JobSpec))
            {
                request.JobSpecShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.JobSpec, "JobSpec", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobSpecShrink))
            {
                query["JobSpec"] = request.JobSpecShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteJobs",
                Version = "2024-07-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteJobsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 删除作业
         *
         * @param tmpReq DeleteJobsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteJobsResponse
         */
        public async Task<DeleteJobsResponse> DeleteJobsWithOptionsAsync(DeleteJobsRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DeleteJobsShrinkRequest request = new DeleteJobsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.JobSpec))
            {
                request.JobSpecShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.JobSpec, "JobSpec", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobSpecShrink))
            {
                query["JobSpec"] = request.JobSpecShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteJobs",
                Version = "2024-07-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteJobsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 删除作业
         *
         * @param request DeleteJobsRequest
         * @return DeleteJobsResponse
         */
        public DeleteJobsResponse DeleteJobs(DeleteJobsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteJobsWithOptions(request, runtime);
        }

        /**
         * @summary 删除作业
         *
         * @param request DeleteJobsRequest
         * @return DeleteJobsResponse
         */
        public async Task<DeleteJobsResponse> DeleteJobsAsync(DeleteJobsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteJobsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Deletes compute nodes from an Enterprise High Performance Computing (E-HPC) cluster at a time.
         *
         * @description ## [](#)Usage notes
         * Before you delete a compute node, we recommend that you export all job data from the node to prevent data loss.
         *
         * @param tmpReq DeleteNodesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteNodesResponse
         */
        public DeleteNodesResponse DeleteNodesWithOptions(DeleteNodesRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DeleteNodesShrinkRequest request = new DeleteNodesShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.InstanceIds))
            {
                request.InstanceIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.InstanceIds, "InstanceIds", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
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
                Action = "DeleteNodes",
                Version = "2024-07-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteNodesResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Deletes compute nodes from an Enterprise High Performance Computing (E-HPC) cluster at a time.
         *
         * @description ## [](#)Usage notes
         * Before you delete a compute node, we recommend that you export all job data from the node to prevent data loss.
         *
         * @param tmpReq DeleteNodesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteNodesResponse
         */
        public async Task<DeleteNodesResponse> DeleteNodesWithOptionsAsync(DeleteNodesRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DeleteNodesShrinkRequest request = new DeleteNodesShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.InstanceIds))
            {
                request.InstanceIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.InstanceIds, "InstanceIds", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
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
                Action = "DeleteNodes",
                Version = "2024-07-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteNodesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Deletes compute nodes from an Enterprise High Performance Computing (E-HPC) cluster at a time.
         *
         * @description ## [](#)Usage notes
         * Before you delete a compute node, we recommend that you export all job data from the node to prevent data loss.
         *
         * @param request DeleteNodesRequest
         * @return DeleteNodesResponse
         */
        public DeleteNodesResponse DeleteNodes(DeleteNodesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteNodesWithOptions(request, runtime);
        }

        /**
         * @summary Deletes compute nodes from an Enterprise High Performance Computing (E-HPC) cluster at a time.
         *
         * @description ## [](#)Usage notes
         * Before you delete a compute node, we recommend that you export all job data from the node to prevent data loss.
         *
         * @param request DeleteNodesRequest
         * @return DeleteNodesResponse
         */
        public async Task<DeleteNodesResponse> DeleteNodesAsync(DeleteNodesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteNodesWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Deletes queues from an Enterprise High Performance Computing (E-HPC) cluster.
         *
         * @description ## [](#)Usage notes
         * Before you delete a queue, you must delete all compute nodes in the queue.
         *
         * @param tmpReq DeleteQueuesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteQueuesResponse
         */
        public DeleteQueuesResponse DeleteQueuesWithOptions(DeleteQueuesRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DeleteQueuesShrinkRequest request = new DeleteQueuesShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.QueueNames))
            {
                request.QueueNamesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.QueueNames, "QueueNames", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueueNamesShrink))
            {
                query["QueueNames"] = request.QueueNamesShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteQueues",
                Version = "2024-07-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteQueuesResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Deletes queues from an Enterprise High Performance Computing (E-HPC) cluster.
         *
         * @description ## [](#)Usage notes
         * Before you delete a queue, you must delete all compute nodes in the queue.
         *
         * @param tmpReq DeleteQueuesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteQueuesResponse
         */
        public async Task<DeleteQueuesResponse> DeleteQueuesWithOptionsAsync(DeleteQueuesRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DeleteQueuesShrinkRequest request = new DeleteQueuesShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.QueueNames))
            {
                request.QueueNamesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.QueueNames, "QueueNames", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueueNamesShrink))
            {
                query["QueueNames"] = request.QueueNamesShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteQueues",
                Version = "2024-07-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteQueuesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Deletes queues from an Enterprise High Performance Computing (E-HPC) cluster.
         *
         * @description ## [](#)Usage notes
         * Before you delete a queue, you must delete all compute nodes in the queue.
         *
         * @param request DeleteQueuesRequest
         * @return DeleteQueuesResponse
         */
        public DeleteQueuesResponse DeleteQueues(DeleteQueuesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteQueuesWithOptions(request, runtime);
        }

        /**
         * @summary Deletes queues from an Enterprise High Performance Computing (E-HPC) cluster.
         *
         * @description ## [](#)Usage notes
         * Before you delete a queue, you must delete all compute nodes in the queue.
         *
         * @param request DeleteQueuesRequest
         * @return DeleteQueuesResponse
         */
        public async Task<DeleteQueuesResponse> DeleteQueuesAsync(DeleteQueuesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteQueuesWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Deletes users from a cluster.
         *
         * @param tmpReq DeleteUsersRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteUsersResponse
         */
        public DeleteUsersResponse DeleteUsersWithOptions(DeleteUsersRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DeleteUsersShrinkRequest request = new DeleteUsersShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.User))
            {
                request.UserShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.User, "User", "json");
            }
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteUsers",
                Version = "2024-07-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteUsersResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Deletes users from a cluster.
         *
         * @param tmpReq DeleteUsersRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteUsersResponse
         */
        public async Task<DeleteUsersResponse> DeleteUsersWithOptionsAsync(DeleteUsersRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DeleteUsersShrinkRequest request = new DeleteUsersShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.User))
            {
                request.UserShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.User, "User", "json");
            }
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteUsers",
                Version = "2024-07-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteUsersResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Deletes users from a cluster.
         *
         * @param request DeleteUsersRequest
         * @return DeleteUsersResponse
         */
        public DeleteUsersResponse DeleteUsers(DeleteUsersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteUsersWithOptions(request, runtime);
        }

        /**
         * @summary Deletes users from a cluster.
         *
         * @param request DeleteUsersRequest
         * @return DeleteUsersResponse
         */
        public async Task<DeleteUsersResponse> DeleteUsersAsync(DeleteUsersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteUsersWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 查询Add-on服务组件模板详情。
         *
         * @param request DescribeAddonTemplateRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeAddonTemplateResponse
         */
        public DescribeAddonTemplateResponse DescribeAddonTemplateWithOptions(DescribeAddonTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AddonName))
            {
                query["AddonName"] = request.AddonName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AddonVersion))
            {
                query["AddonVersion"] = request.AddonVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
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
                Action = "DescribeAddonTemplate",
                Version = "2024-07-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAddonTemplateResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 查询Add-on服务组件模板详情。
         *
         * @param request DescribeAddonTemplateRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeAddonTemplateResponse
         */
        public async Task<DescribeAddonTemplateResponse> DescribeAddonTemplateWithOptionsAsync(DescribeAddonTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AddonName))
            {
                query["AddonName"] = request.AddonName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AddonVersion))
            {
                query["AddonVersion"] = request.AddonVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
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
                Action = "DescribeAddonTemplate",
                Version = "2024-07-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAddonTemplateResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 查询Add-on服务组件模板详情。
         *
         * @param request DescribeAddonTemplateRequest
         * @return DescribeAddonTemplateResponse
         */
        public DescribeAddonTemplateResponse DescribeAddonTemplate(DescribeAddonTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeAddonTemplateWithOptions(request, runtime);
        }

        /**
         * @summary 查询Add-on服务组件模板详情。
         *
         * @param request DescribeAddonTemplateRequest
         * @return DescribeAddonTemplateResponse
         */
        public async Task<DescribeAddonTemplateResponse> DescribeAddonTemplateAsync(DescribeAddonTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeAddonTemplateWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Unmounts shared storage from the mount directory of a cluster.
         *
         * @param tmpReq DetachSharedStoragesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DetachSharedStoragesResponse
         */
        public DetachSharedStoragesResponse DetachSharedStoragesWithOptions(DetachSharedStoragesRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DetachSharedStoragesShrinkRequest request = new DetachSharedStoragesShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SharedStorages))
            {
                request.SharedStoragesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SharedStorages, "SharedStorages", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SharedStoragesShrink))
            {
                query["SharedStorages"] = request.SharedStoragesShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DetachSharedStorages",
                Version = "2024-07-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DetachSharedStoragesResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Unmounts shared storage from the mount directory of a cluster.
         *
         * @param tmpReq DetachSharedStoragesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DetachSharedStoragesResponse
         */
        public async Task<DetachSharedStoragesResponse> DetachSharedStoragesWithOptionsAsync(DetachSharedStoragesRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DetachSharedStoragesShrinkRequest request = new DetachSharedStoragesShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SharedStorages))
            {
                request.SharedStoragesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SharedStorages, "SharedStorages", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SharedStoragesShrink))
            {
                query["SharedStorages"] = request.SharedStoragesShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DetachSharedStorages",
                Version = "2024-07-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DetachSharedStoragesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Unmounts shared storage from the mount directory of a cluster.
         *
         * @param request DetachSharedStoragesRequest
         * @return DetachSharedStoragesResponse
         */
        public DetachSharedStoragesResponse DetachSharedStorages(DetachSharedStoragesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DetachSharedStoragesWithOptions(request, runtime);
        }

        /**
         * @summary Unmounts shared storage from the mount directory of a cluster.
         *
         * @param request DetachSharedStoragesRequest
         * @return DetachSharedStoragesResponse
         */
        public async Task<DetachSharedStoragesResponse> DetachSharedStoragesAsync(DetachSharedStoragesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DetachSharedStoragesWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 查看已安装的Add-on服务组件详情。
         *
         * @param request GetAddonRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetAddonResponse
         */
        public GetAddonResponse GetAddonWithOptions(GetAddonRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AddonId))
            {
                query["AddonId"] = request.AddonId;
            }
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
                Action = "GetAddon",
                Version = "2024-07-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAddonResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 查看已安装的Add-on服务组件详情。
         *
         * @param request GetAddonRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetAddonResponse
         */
        public async Task<GetAddonResponse> GetAddonWithOptionsAsync(GetAddonRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AddonId))
            {
                query["AddonId"] = request.AddonId;
            }
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
                Action = "GetAddon",
                Version = "2024-07-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAddonResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 查看已安装的Add-on服务组件详情。
         *
         * @param request GetAddonRequest
         * @return GetAddonResponse
         */
        public GetAddonResponse GetAddon(GetAddonRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetAddonWithOptions(request, runtime);
        }

        /**
         * @summary 查看已安装的Add-on服务组件详情。
         *
         * @param request GetAddonRequest
         * @return GetAddonResponse
         */
        public async Task<GetAddonResponse> GetAddonAsync(GetAddonRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetAddonWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 查询单个E-HPC集群的详情信息。
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetCluster",
                Version = "2024-07-30",
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
         * @summary 查询单个E-HPC集群的详情信息。
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetCluster",
                Version = "2024-07-30",
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
         * @summary 查询单个E-HPC集群的详情信息。
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
         * @summary 查询单个E-HPC集群的详情信息。
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
         * @summary 查询集群通用日志详细信息
         *
         * @param request GetCommonLogDetailRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetCommonLogDetailResponse
         */
        public GetCommonLogDetailResponse GetCommonLogDetailWithOptions(GetCommonLogDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.From))
            {
                query["From"] = request.From;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HiddenProcess))
            {
                query["HiddenProcess"] = request.HiddenProcess;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogRequestId))
            {
                query["LogRequestId"] = request.LogRequestId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.To))
            {
                query["To"] = request.To;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetCommonLogDetail",
                Version = "2024-07-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetCommonLogDetailResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 查询集群通用日志详细信息
         *
         * @param request GetCommonLogDetailRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetCommonLogDetailResponse
         */
        public async Task<GetCommonLogDetailResponse> GetCommonLogDetailWithOptionsAsync(GetCommonLogDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.From))
            {
                query["From"] = request.From;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HiddenProcess))
            {
                query["HiddenProcess"] = request.HiddenProcess;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogRequestId))
            {
                query["LogRequestId"] = request.LogRequestId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.To))
            {
                query["To"] = request.To;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetCommonLogDetail",
                Version = "2024-07-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetCommonLogDetailResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 查询集群通用日志详细信息
         *
         * @param request GetCommonLogDetailRequest
         * @return GetCommonLogDetailResponse
         */
        public GetCommonLogDetailResponse GetCommonLogDetail(GetCommonLogDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetCommonLogDetailWithOptions(request, runtime);
        }

        /**
         * @summary 查询集群通用日志详细信息
         *
         * @param request GetCommonLogDetailRequest
         * @return GetCommonLogDetailResponse
         */
        public async Task<GetCommonLogDetailResponse> GetCommonLogDetailAsync(GetCommonLogDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetCommonLogDetailWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 查询集群的队列配置信息
         *
         * @param request GetQueueRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetQueueResponse
         */
        public GetQueueResponse GetQueueWithOptions(GetQueueRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueueName))
            {
                query["QueueName"] = request.QueueName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetQueue",
                Version = "2024-07-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetQueueResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 查询集群的队列配置信息
         *
         * @param request GetQueueRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetQueueResponse
         */
        public async Task<GetQueueResponse> GetQueueWithOptionsAsync(GetQueueRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueueName))
            {
                query["QueueName"] = request.QueueName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetQueue",
                Version = "2024-07-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetQueueResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 查询集群的队列配置信息
         *
         * @param request GetQueueRequest
         * @return GetQueueResponse
         */
        public GetQueueResponse GetQueue(GetQueueRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetQueueWithOptions(request, runtime);
        }

        /**
         * @summary 查询集群的队列配置信息
         *
         * @param request GetQueueRequest
         * @return GetQueueResponse
         */
        public async Task<GetQueueResponse> GetQueueAsync(GetQueueRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetQueueWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Installs an addon.
         *
         * @param request InstallAddonRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return InstallAddonResponse
         */
        public InstallAddonResponse InstallAddonWithOptions(InstallAddonRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AddonName))
            {
                query["AddonName"] = request.AddonName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AddonVersion))
            {
                query["AddonVersion"] = request.AddonVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourcesSpec))
            {
                query["ResourcesSpec"] = request.ResourcesSpec;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServicesSpec))
            {
                query["ServicesSpec"] = request.ServicesSpec;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "InstallAddon",
                Version = "2024-07-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<InstallAddonResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Installs an addon.
         *
         * @param request InstallAddonRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return InstallAddonResponse
         */
        public async Task<InstallAddonResponse> InstallAddonWithOptionsAsync(InstallAddonRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AddonName))
            {
                query["AddonName"] = request.AddonName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AddonVersion))
            {
                query["AddonVersion"] = request.AddonVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourcesSpec))
            {
                query["ResourcesSpec"] = request.ResourcesSpec;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServicesSpec))
            {
                query["ServicesSpec"] = request.ServicesSpec;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "InstallAddon",
                Version = "2024-07-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<InstallAddonResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Installs an addon.
         *
         * @param request InstallAddonRequest
         * @return InstallAddonResponse
         */
        public InstallAddonResponse InstallAddon(InstallAddonRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return InstallAddonWithOptions(request, runtime);
        }

        /**
         * @summary Installs an addon.
         *
         * @param request InstallAddonRequest
         * @return InstallAddonResponse
         */
        public async Task<InstallAddonResponse> InstallAddonAsync(InstallAddonRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await InstallAddonWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Installs software for a specified cluster.
         *
         * @param tmpReq InstallSoftwaresRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return InstallSoftwaresResponse
         */
        public InstallSoftwaresResponse InstallSoftwaresWithOptions(InstallSoftwaresRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            InstallSoftwaresShrinkRequest request = new InstallSoftwaresShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.AdditionalPackages))
            {
                request.AdditionalPackagesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.AdditionalPackages, "AdditionalPackages", "json");
            }
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "InstallSoftwares",
                Version = "2024-07-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<InstallSoftwaresResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Installs software for a specified cluster.
         *
         * @param tmpReq InstallSoftwaresRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return InstallSoftwaresResponse
         */
        public async Task<InstallSoftwaresResponse> InstallSoftwaresWithOptionsAsync(InstallSoftwaresRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            InstallSoftwaresShrinkRequest request = new InstallSoftwaresShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.AdditionalPackages))
            {
                request.AdditionalPackagesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.AdditionalPackages, "AdditionalPackages", "json");
            }
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "InstallSoftwares",
                Version = "2024-07-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<InstallSoftwaresResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Installs software for a specified cluster.
         *
         * @param request InstallSoftwaresRequest
         * @return InstallSoftwaresResponse
         */
        public InstallSoftwaresResponse InstallSoftwares(InstallSoftwaresRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return InstallSoftwaresWithOptions(request, runtime);
        }

        /**
         * @summary Installs software for a specified cluster.
         *
         * @param request InstallSoftwaresRequest
         * @return InstallSoftwaresResponse
         */
        public async Task<InstallSoftwaresResponse> InstallSoftwaresAsync(InstallSoftwaresRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await InstallSoftwaresWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 支持的Add-on服务组件模板列表查询。
         *
         * @param request ListAddonTemplatesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListAddonTemplatesResponse
         */
        public ListAddonTemplatesResponse ListAddonTemplatesWithOptions(ListAddonTemplatesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AddonNames))
            {
                query["AddonNames"] = request.AddonNames;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterCategory))
            {
                query["ClusterCategory"] = request.ClusterCategory;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
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
                Action = "ListAddonTemplates",
                Version = "2024-07-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAddonTemplatesResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 支持的Add-on服务组件模板列表查询。
         *
         * @param request ListAddonTemplatesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListAddonTemplatesResponse
         */
        public async Task<ListAddonTemplatesResponse> ListAddonTemplatesWithOptionsAsync(ListAddonTemplatesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AddonNames))
            {
                query["AddonNames"] = request.AddonNames;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterCategory))
            {
                query["ClusterCategory"] = request.ClusterCategory;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
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
                Action = "ListAddonTemplates",
                Version = "2024-07-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAddonTemplatesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 支持的Add-on服务组件模板列表查询。
         *
         * @param request ListAddonTemplatesRequest
         * @return ListAddonTemplatesResponse
         */
        public ListAddonTemplatesResponse ListAddonTemplates(ListAddonTemplatesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListAddonTemplatesWithOptions(request, runtime);
        }

        /**
         * @summary 支持的Add-on服务组件模板列表查询。
         *
         * @param request ListAddonTemplatesRequest
         * @return ListAddonTemplatesResponse
         */
        public async Task<ListAddonTemplatesResponse> ListAddonTemplatesAsync(ListAddonTemplatesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListAddonTemplatesWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 查看已安装的Add-on服务组件列表。
         *
         * @param tmpReq ListAddonsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListAddonsResponse
         */
        public ListAddonsResponse ListAddonsWithOptions(ListAddonsRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListAddonsShrinkRequest request = new ListAddonsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.AddonIds))
            {
                request.AddonIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.AddonIds, "AddonIds", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AddonIdsShrink))
            {
                query["AddonIds"] = request.AddonIdsShrink;
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListAddons",
                Version = "2024-07-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAddonsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 查看已安装的Add-on服务组件列表。
         *
         * @param tmpReq ListAddonsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListAddonsResponse
         */
        public async Task<ListAddonsResponse> ListAddonsWithOptionsAsync(ListAddonsRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListAddonsShrinkRequest request = new ListAddonsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.AddonIds))
            {
                request.AddonIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.AddonIds, "AddonIds", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AddonIdsShrink))
            {
                query["AddonIds"] = request.AddonIdsShrink;
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListAddons",
                Version = "2024-07-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAddonsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 查看已安装的Add-on服务组件列表。
         *
         * @param request ListAddonsRequest
         * @return ListAddonsResponse
         */
        public ListAddonsResponse ListAddons(ListAddonsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListAddonsWithOptions(request, runtime);
        }

        /**
         * @summary 查看已安装的Add-on服务组件列表。
         *
         * @param request ListAddonsRequest
         * @return ListAddonsResponse
         */
        public async Task<ListAddonsResponse> ListAddonsAsync(ListAddonsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListAddonsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 查询可用的共享存储
         *
         * @param request ListAvailableFileSystemsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListAvailableFileSystemsResponse
         */
        public ListAvailableFileSystemsResponse ListAvailableFileSystemsWithOptions(ListAvailableFileSystemsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "ListAvailableFileSystems",
                Version = "2024-07-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAvailableFileSystemsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 查询可用的共享存储
         *
         * @param request ListAvailableFileSystemsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListAvailableFileSystemsResponse
         */
        public async Task<ListAvailableFileSystemsResponse> ListAvailableFileSystemsWithOptionsAsync(ListAvailableFileSystemsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "ListAvailableFileSystems",
                Version = "2024-07-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAvailableFileSystemsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 查询可用的共享存储
         *
         * @param request ListAvailableFileSystemsRequest
         * @return ListAvailableFileSystemsResponse
         */
        public ListAvailableFileSystemsResponse ListAvailableFileSystems(ListAvailableFileSystemsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListAvailableFileSystemsWithOptions(request, runtime);
        }

        /**
         * @summary 查询可用的共享存储
         *
         * @param request ListAvailableFileSystemsRequest
         * @return ListAvailableFileSystemsResponse
         */
        public async Task<ListAvailableFileSystemsResponse> ListAvailableFileSystemsAsync(ListAvailableFileSystemsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListAvailableFileSystemsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 获取可用镜像列表
         *
         * @param tmpReq ListAvailableImagesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListAvailableImagesResponse
         */
        public ListAvailableImagesResponse ListAvailableImagesWithOptions(ListAvailableImagesRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListAvailableImagesShrinkRequest request = new ListAvailableImagesShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DirectoryService))
            {
                request.DirectoryServiceShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DirectoryService, "DirectoryService", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Scheduler))
            {
                request.SchedulerShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Scheduler, "Scheduler", "json");
            }
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListAvailableImages",
                Version = "2024-07-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAvailableImagesResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 获取可用镜像列表
         *
         * @param tmpReq ListAvailableImagesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListAvailableImagesResponse
         */
        public async Task<ListAvailableImagesResponse> ListAvailableImagesWithOptionsAsync(ListAvailableImagesRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListAvailableImagesShrinkRequest request = new ListAvailableImagesShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DirectoryService))
            {
                request.DirectoryServiceShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DirectoryService, "DirectoryService", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Scheduler))
            {
                request.SchedulerShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Scheduler, "Scheduler", "json");
            }
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListAvailableImages",
                Version = "2024-07-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAvailableImagesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 获取可用镜像列表
         *
         * @param request ListAvailableImagesRequest
         * @return ListAvailableImagesResponse
         */
        public ListAvailableImagesResponse ListAvailableImages(ListAvailableImagesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListAvailableImagesWithOptions(request, runtime);
        }

        /**
         * @summary 获取可用镜像列表
         *
         * @param request ListAvailableImagesRequest
         * @return ListAvailableImagesResponse
         */
        public async Task<ListAvailableImagesResponse> ListAvailableImagesAsync(ListAvailableImagesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListAvailableImagesWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 查询用户账号中在每个地域拥有的所有集群的列表。
         *
         * @param tmpReq ListClustersRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListClustersResponse
         */
        public ListClustersResponse ListClustersWithOptions(ListClustersRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListClustersShrinkRequest request = new ListClustersShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ClusterIds))
            {
                request.ClusterIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ClusterIds, "ClusterIds", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ClusterNames))
            {
                request.ClusterNamesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ClusterNames, "ClusterNames", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterIdsShrink))
            {
                query["ClusterIds"] = request.ClusterIdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterNamesShrink))
            {
                query["ClusterNames"] = request.ClusterNamesShrink;
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
                Action = "ListClusters",
                Version = "2024-07-30",
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
         * @summary 查询用户账号中在每个地域拥有的所有集群的列表。
         *
         * @param tmpReq ListClustersRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListClustersResponse
         */
        public async Task<ListClustersResponse> ListClustersWithOptionsAsync(ListClustersRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListClustersShrinkRequest request = new ListClustersShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ClusterIds))
            {
                request.ClusterIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ClusterIds, "ClusterIds", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ClusterNames))
            {
                request.ClusterNamesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ClusterNames, "ClusterNames", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterIdsShrink))
            {
                query["ClusterIds"] = request.ClusterIdsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterNamesShrink))
            {
                query["ClusterNames"] = request.ClusterNamesShrink;
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
                Action = "ListClusters",
                Version = "2024-07-30",
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
         * @summary 查询用户账号中在每个地域拥有的所有集群的列表。
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
         * @summary 查询用户账号中在每个地域拥有的所有集群的列表。
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
         * @summary 查询集群通用日志列表
         *
         * @param tmpReq ListCommonLogsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListCommonLogsResponse
         */
        public ListCommonLogsResponse ListCommonLogsWithOptions(ListCommonLogsRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListCommonLogsShrinkRequest request = new ListCommonLogsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ActionName))
            {
                request.ActionNameShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ActionName, "ActionName", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ActionNameShrink))
            {
                query["ActionName"] = request.ActionNameShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ActionStatus))
            {
                query["ActionStatus"] = request.ActionStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.From))
            {
                query["From"] = request.From;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsReverse))
            {
                query["IsReverse"] = request.IsReverse;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogRequestId))
            {
                query["LogRequestId"] = request.LogRequestId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogType))
            {
                query["LogType"] = request.LogType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorUid))
            {
                query["OperatorUid"] = request.OperatorUid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Resource))
            {
                query["Resource"] = request.Resource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.To))
            {
                query["To"] = request.To;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListCommonLogs",
                Version = "2024-07-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListCommonLogsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 查询集群通用日志列表
         *
         * @param tmpReq ListCommonLogsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListCommonLogsResponse
         */
        public async Task<ListCommonLogsResponse> ListCommonLogsWithOptionsAsync(ListCommonLogsRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListCommonLogsShrinkRequest request = new ListCommonLogsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ActionName))
            {
                request.ActionNameShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ActionName, "ActionName", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ActionNameShrink))
            {
                query["ActionName"] = request.ActionNameShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ActionStatus))
            {
                query["ActionStatus"] = request.ActionStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.From))
            {
                query["From"] = request.From;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsReverse))
            {
                query["IsReverse"] = request.IsReverse;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogRequestId))
            {
                query["LogRequestId"] = request.LogRequestId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogType))
            {
                query["LogType"] = request.LogType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperatorUid))
            {
                query["OperatorUid"] = request.OperatorUid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Resource))
            {
                query["Resource"] = request.Resource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.To))
            {
                query["To"] = request.To;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListCommonLogs",
                Version = "2024-07-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListCommonLogsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 查询集群通用日志列表
         *
         * @param request ListCommonLogsRequest
         * @return ListCommonLogsResponse
         */
        public ListCommonLogsResponse ListCommonLogs(ListCommonLogsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListCommonLogsWithOptions(request, runtime);
        }

        /**
         * @summary 查询集群通用日志列表
         *
         * @param request ListCommonLogsRequest
         * @return ListCommonLogsResponse
         */
        public async Task<ListCommonLogsResponse> ListCommonLogsAsync(ListCommonLogsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListCommonLogsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the installed software of a cluster.
         *
         * @param request ListInstalledSoftwaresRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListInstalledSoftwaresResponse
         */
        public ListInstalledSoftwaresResponse ListInstalledSoftwaresWithOptions(ListInstalledSoftwaresRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListInstalledSoftwares",
                Version = "2024-07-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListInstalledSoftwaresResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the installed software of a cluster.
         *
         * @param request ListInstalledSoftwaresRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListInstalledSoftwaresResponse
         */
        public async Task<ListInstalledSoftwaresResponse> ListInstalledSoftwaresWithOptionsAsync(ListInstalledSoftwaresRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListInstalledSoftwares",
                Version = "2024-07-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListInstalledSoftwaresResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the installed software of a cluster.
         *
         * @param request ListInstalledSoftwaresRequest
         * @return ListInstalledSoftwaresResponse
         */
        public ListInstalledSoftwaresResponse ListInstalledSoftwares(ListInstalledSoftwaresRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListInstalledSoftwaresWithOptions(request, runtime);
        }

        /**
         * @summary Queries the installed software of a cluster.
         *
         * @param request ListInstalledSoftwaresRequest
         * @return ListInstalledSoftwaresResponse
         */
        public async Task<ListInstalledSoftwaresResponse> ListInstalledSoftwaresAsync(ListInstalledSoftwaresRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListInstalledSoftwaresWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 查询节点列表
         *
         * @param tmpReq ListNodesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListNodesResponse
         */
        public ListNodesResponse ListNodesWithOptions(ListNodesRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListNodesShrinkRequest request = new ListNodesShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Hostnames))
            {
                request.HostnamesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Hostnames, "Hostnames", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.PrivateIpAddress))
            {
                request.PrivateIpAddressShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.PrivateIpAddress, "PrivateIpAddress", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.QueueNames))
            {
                request.QueueNamesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.QueueNames, "QueueNames", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Status))
            {
                request.StatusShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Status, "Status", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HostnamesShrink))
            {
                query["Hostnames"] = request.HostnamesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PrivateIpAddressShrink))
            {
                query["PrivateIpAddress"] = request.PrivateIpAddressShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueueNamesShrink))
            {
                query["QueueNames"] = request.QueueNamesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Sequence))
            {
                query["Sequence"] = request.Sequence;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortBy))
            {
                query["SortBy"] = request.SortBy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StatusShrink))
            {
                query["Status"] = request.StatusShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListNodes",
                Version = "2024-07-30",
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
         * @summary 查询节点列表
         *
         * @param tmpReq ListNodesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListNodesResponse
         */
        public async Task<ListNodesResponse> ListNodesWithOptionsAsync(ListNodesRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListNodesShrinkRequest request = new ListNodesShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Hostnames))
            {
                request.HostnamesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Hostnames, "Hostnames", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.PrivateIpAddress))
            {
                request.PrivateIpAddressShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.PrivateIpAddress, "PrivateIpAddress", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.QueueNames))
            {
                request.QueueNamesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.QueueNames, "QueueNames", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Status))
            {
                request.StatusShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Status, "Status", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HostnamesShrink))
            {
                query["Hostnames"] = request.HostnamesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PrivateIpAddressShrink))
            {
                query["PrivateIpAddress"] = request.PrivateIpAddressShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueueNamesShrink))
            {
                query["QueueNames"] = request.QueueNamesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Sequence))
            {
                query["Sequence"] = request.Sequence;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortBy))
            {
                query["SortBy"] = request.SortBy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StatusShrink))
            {
                query["Status"] = request.StatusShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListNodes",
                Version = "2024-07-30",
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
         * @summary 查询节点列表
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
         * @summary 查询节点列表
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
         * @summary 查询集群的队列信息。
         *
         * @param tmpReq ListQueuesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListQueuesResponse
         */
        public ListQueuesResponse ListQueuesWithOptions(ListQueuesRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListQueuesShrinkRequest request = new ListQueuesShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.QueueNames))
            {
                request.QueueNamesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.QueueNames, "QueueNames", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueueNamesShrink))
            {
                query["QueueNames"] = request.QueueNamesShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListQueues",
                Version = "2024-07-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListQueuesResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 查询集群的队列信息。
         *
         * @param tmpReq ListQueuesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListQueuesResponse
         */
        public async Task<ListQueuesResponse> ListQueuesWithOptionsAsync(ListQueuesRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListQueuesShrinkRequest request = new ListQueuesShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.QueueNames))
            {
                request.QueueNamesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.QueueNames, "QueueNames", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueueNamesShrink))
            {
                query["QueueNames"] = request.QueueNamesShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListQueues",
                Version = "2024-07-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListQueuesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 查询集群的队列信息。
         *
         * @param request ListQueuesRequest
         * @return ListQueuesResponse
         */
        public ListQueuesResponse ListQueues(ListQueuesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListQueuesWithOptions(request, runtime);
        }

        /**
         * @summary 查询集群的队列信息。
         *
         * @param request ListQueuesRequest
         * @return ListQueuesResponse
         */
        public async Task<ListQueuesResponse> ListQueuesAsync(ListQueuesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListQueuesWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the shared storage that is attached to a cluster.
         *
         * @param request ListSharedStoragesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListSharedStoragesResponse
         */
        public ListSharedStoragesResponse ListSharedStoragesWithOptions(ListSharedStoragesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileSystemId))
            {
                query["FileSystemId"] = request.FileSystemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileSystemType))
            {
                query["FileSystemType"] = request.FileSystemType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListSharedStorages",
                Version = "2024-07-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListSharedStoragesResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the shared storage that is attached to a cluster.
         *
         * @param request ListSharedStoragesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListSharedStoragesResponse
         */
        public async Task<ListSharedStoragesResponse> ListSharedStoragesWithOptionsAsync(ListSharedStoragesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileSystemId))
            {
                query["FileSystemId"] = request.FileSystemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileSystemType))
            {
                query["FileSystemType"] = request.FileSystemType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListSharedStorages",
                Version = "2024-07-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListSharedStoragesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the shared storage that is attached to a cluster.
         *
         * @param request ListSharedStoragesRequest
         * @return ListSharedStoragesResponse
         */
        public ListSharedStoragesResponse ListSharedStorages(ListSharedStoragesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListSharedStoragesWithOptions(request, runtime);
        }

        /**
         * @summary Queries the shared storage that is attached to a cluster.
         *
         * @param request ListSharedStoragesRequest
         * @return ListSharedStoragesResponse
         */
        public async Task<ListSharedStoragesResponse> ListSharedStoragesAsync(ListSharedStoragesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListSharedStoragesWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the software that can be installed in an Elastic High Performance Computing (E-HPC) cluster.
         *
         * @param request ListSoftwaresRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListSoftwaresResponse
         */
        public ListSoftwaresResponse ListSoftwaresWithOptions(ListSoftwaresRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListSoftwares",
                Version = "2024-07-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListSoftwaresResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the software that can be installed in an Elastic High Performance Computing (E-HPC) cluster.
         *
         * @param request ListSoftwaresRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListSoftwaresResponse
         */
        public async Task<ListSoftwaresResponse> ListSoftwaresWithOptionsAsync(ListSoftwaresRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListSoftwares",
                Version = "2024-07-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListSoftwaresResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the software that can be installed in an Elastic High Performance Computing (E-HPC) cluster.
         *
         * @param request ListSoftwaresRequest
         * @return ListSoftwaresResponse
         */
        public ListSoftwaresResponse ListSoftwares(ListSoftwaresRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListSoftwaresWithOptions(request, runtime);
        }

        /**
         * @summary Queries the software that can be installed in an Elastic High Performance Computing (E-HPC) cluster.
         *
         * @param request ListSoftwaresRequest
         * @return ListSoftwaresResponse
         */
        public async Task<ListSoftwaresResponse> ListSoftwaresAsync(ListSoftwaresRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListSoftwaresWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the users of a cluster.
         *
         * @param request ListUsersRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListUsersResponse
         */
        public ListUsersResponse ListUsersWithOptions(ListUsersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListUsers",
                Version = "2024-07-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListUsersResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the users of a cluster.
         *
         * @param request ListUsersRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListUsersResponse
         */
        public async Task<ListUsersResponse> ListUsersWithOptionsAsync(ListUsersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListUsers",
                Version = "2024-07-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListUsersResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the users of a cluster.
         *
         * @param request ListUsersRequest
         * @return ListUsersResponse
         */
        public ListUsersResponse ListUsers(ListUsersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListUsersWithOptions(request, runtime);
        }

        /**
         * @summary Queries the users of a cluster.
         *
         * @param request ListUsersRequest
         * @return ListUsersResponse
         */
        public async Task<ListUsersResponse> ListUsersAsync(ListUsersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListUsersWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Uninstalls an addon.
         *
         * @param request UnInstallAddonRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UnInstallAddonResponse
         */
        public UnInstallAddonResponse UnInstallAddonWithOptions(UnInstallAddonRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AddonId))
            {
                query["AddonId"] = request.AddonId;
            }
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
                Action = "UnInstallAddon",
                Version = "2024-07-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UnInstallAddonResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Uninstalls an addon.
         *
         * @param request UnInstallAddonRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UnInstallAddonResponse
         */
        public async Task<UnInstallAddonResponse> UnInstallAddonWithOptionsAsync(UnInstallAddonRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AddonId))
            {
                query["AddonId"] = request.AddonId;
            }
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
                Action = "UnInstallAddon",
                Version = "2024-07-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UnInstallAddonResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Uninstalls an addon.
         *
         * @param request UnInstallAddonRequest
         * @return UnInstallAddonResponse
         */
        public UnInstallAddonResponse UnInstallAddon(UnInstallAddonRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UnInstallAddonWithOptions(request, runtime);
        }

        /**
         * @summary Uninstalls an addon.
         *
         * @param request UnInstallAddonRequest
         * @return UnInstallAddonResponse
         */
        public async Task<UnInstallAddonResponse> UnInstallAddonAsync(UnInstallAddonRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UnInstallAddonWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Uninstalls software systems from an Enterprise High Performance Computing (E-HPC) cluster.
         *
         * @param tmpReq UninstallSoftwaresRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UninstallSoftwaresResponse
         */
        public UninstallSoftwaresResponse UninstallSoftwaresWithOptions(UninstallSoftwaresRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UninstallSoftwaresShrinkRequest request = new UninstallSoftwaresShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.AdditionalPackages))
            {
                request.AdditionalPackagesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.AdditionalPackages, "AdditionalPackages", "json");
            }
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UninstallSoftwares",
                Version = "2024-07-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UninstallSoftwaresResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Uninstalls software systems from an Enterprise High Performance Computing (E-HPC) cluster.
         *
         * @param tmpReq UninstallSoftwaresRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UninstallSoftwaresResponse
         */
        public async Task<UninstallSoftwaresResponse> UninstallSoftwaresWithOptionsAsync(UninstallSoftwaresRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UninstallSoftwaresShrinkRequest request = new UninstallSoftwaresShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.AdditionalPackages))
            {
                request.AdditionalPackagesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.AdditionalPackages, "AdditionalPackages", "json");
            }
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UninstallSoftwares",
                Version = "2024-07-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UninstallSoftwaresResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Uninstalls software systems from an Enterprise High Performance Computing (E-HPC) cluster.
         *
         * @param request UninstallSoftwaresRequest
         * @return UninstallSoftwaresResponse
         */
        public UninstallSoftwaresResponse UninstallSoftwares(UninstallSoftwaresRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UninstallSoftwaresWithOptions(request, runtime);
        }

        /**
         * @summary Uninstalls software systems from an Enterprise High Performance Computing (E-HPC) cluster.
         *
         * @param request UninstallSoftwaresRequest
         * @return UninstallSoftwaresResponse
         */
        public async Task<UninstallSoftwaresResponse> UninstallSoftwaresAsync(UninstallSoftwaresRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UninstallSoftwaresWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 修改指定集群的基本信息。
         *
         * @param tmpReq UpdateClusterRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateClusterResponse
         */
        public UpdateClusterResponse UpdateClusterWithOptions(UpdateClusterRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateClusterShrinkRequest request = new UpdateClusterShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ClusterCustomConfiguration))
            {
                request.ClusterCustomConfigurationShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ClusterCustomConfiguration, "ClusterCustomConfiguration", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientVersion))
            {
                query["ClientVersion"] = request.ClientVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterCustomConfigurationShrink))
            {
                query["ClusterCustomConfiguration"] = request.ClusterCustomConfigurationShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterDescription))
            {
                query["ClusterDescription"] = request.ClusterDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterName))
            {
                query["ClusterName"] = request.ClusterName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeletionProtection))
            {
                query["DeletionProtection"] = request.DeletionProtection;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableScaleIn))
            {
                query["EnableScaleIn"] = request.EnableScaleIn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableScaleOut))
            {
                query["EnableScaleOut"] = request.EnableScaleOut;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GrowInterval))
            {
                query["GrowInterval"] = request.GrowInterval;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdleInterval))
            {
                query["IdleInterval"] = request.IdleInterval;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxCoreCount))
            {
                query["MaxCoreCount"] = request.MaxCoreCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxCount))
            {
                query["MaxCount"] = request.MaxCount;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateCluster",
                Version = "2024-07-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateClusterResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 修改指定集群的基本信息。
         *
         * @param tmpReq UpdateClusterRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateClusterResponse
         */
        public async Task<UpdateClusterResponse> UpdateClusterWithOptionsAsync(UpdateClusterRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateClusterShrinkRequest request = new UpdateClusterShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ClusterCustomConfiguration))
            {
                request.ClusterCustomConfigurationShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ClusterCustomConfiguration, "ClusterCustomConfiguration", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientVersion))
            {
                query["ClientVersion"] = request.ClientVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterCustomConfigurationShrink))
            {
                query["ClusterCustomConfiguration"] = request.ClusterCustomConfigurationShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterDescription))
            {
                query["ClusterDescription"] = request.ClusterDescription;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterName))
            {
                query["ClusterName"] = request.ClusterName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeletionProtection))
            {
                query["DeletionProtection"] = request.DeletionProtection;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableScaleIn))
            {
                query["EnableScaleIn"] = request.EnableScaleIn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableScaleOut))
            {
                query["EnableScaleOut"] = request.EnableScaleOut;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GrowInterval))
            {
                query["GrowInterval"] = request.GrowInterval;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdleInterval))
            {
                query["IdleInterval"] = request.IdleInterval;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxCoreCount))
            {
                query["MaxCoreCount"] = request.MaxCoreCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxCount))
            {
                query["MaxCount"] = request.MaxCount;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateCluster",
                Version = "2024-07-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateClusterResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 修改指定集群的基本信息。
         *
         * @param request UpdateClusterRequest
         * @return UpdateClusterResponse
         */
        public UpdateClusterResponse UpdateCluster(UpdateClusterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateClusterWithOptions(request, runtime);
        }

        /**
         * @summary 修改指定集群的基本信息。
         *
         * @param request UpdateClusterRequest
         * @return UpdateClusterResponse
         */
        public async Task<UpdateClusterResponse> UpdateClusterAsync(UpdateClusterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateClusterWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Updates the configurations of compute nodes in an Enterprise High Performance Computing (E-HPC) cluster.
         *
         * @description ## [](#)Usage notes
         * Before you delete a compute node, we recommend that you export all job data from the node to prevent data loss.
         *
         * @param tmpReq UpdateNodesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateNodesResponse
         */
        public UpdateNodesResponse UpdateNodesWithOptions(UpdateNodesRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateNodesShrinkRequest request = new UpdateNodesShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Instances))
            {
                request.InstancesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Instances, "Instances", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstancesShrink))
            {
                query["Instances"] = request.InstancesShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateNodes",
                Version = "2024-07-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateNodesResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Updates the configurations of compute nodes in an Enterprise High Performance Computing (E-HPC) cluster.
         *
         * @description ## [](#)Usage notes
         * Before you delete a compute node, we recommend that you export all job data from the node to prevent data loss.
         *
         * @param tmpReq UpdateNodesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateNodesResponse
         */
        public async Task<UpdateNodesResponse> UpdateNodesWithOptionsAsync(UpdateNodesRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateNodesShrinkRequest request = new UpdateNodesShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Instances))
            {
                request.InstancesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Instances, "Instances", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstancesShrink))
            {
                query["Instances"] = request.InstancesShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateNodes",
                Version = "2024-07-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateNodesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Updates the configurations of compute nodes in an Enterprise High Performance Computing (E-HPC) cluster.
         *
         * @description ## [](#)Usage notes
         * Before you delete a compute node, we recommend that you export all job data from the node to prevent data loss.
         *
         * @param request UpdateNodesRequest
         * @return UpdateNodesResponse
         */
        public UpdateNodesResponse UpdateNodes(UpdateNodesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateNodesWithOptions(request, runtime);
        }

        /**
         * @summary Updates the configurations of compute nodes in an Enterprise High Performance Computing (E-HPC) cluster.
         *
         * @description ## [](#)Usage notes
         * Before you delete a compute node, we recommend that you export all job data from the node to prevent data loss.
         *
         * @param request UpdateNodesRequest
         * @return UpdateNodesResponse
         */
        public async Task<UpdateNodesResponse> UpdateNodesAsync(UpdateNodesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateNodesWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 更新集群的队列配置信息
         *
         * @param tmpReq UpdateQueueRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateQueueResponse
         */
        public UpdateQueueResponse UpdateQueueWithOptions(UpdateQueueRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateQueueShrinkRequest request = new UpdateQueueShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Queue))
            {
                request.QueueShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Queue, "Queue", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueueShrink))
            {
                query["Queue"] = request.QueueShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateQueue",
                Version = "2024-07-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateQueueResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 更新集群的队列配置信息
         *
         * @param tmpReq UpdateQueueRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateQueueResponse
         */
        public async Task<UpdateQueueResponse> UpdateQueueWithOptionsAsync(UpdateQueueRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateQueueShrinkRequest request = new UpdateQueueShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Queue))
            {
                request.QueueShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Queue, "Queue", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueueShrink))
            {
                query["Queue"] = request.QueueShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateQueue",
                Version = "2024-07-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateQueueResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 更新集群的队列配置信息
         *
         * @param request UpdateQueueRequest
         * @return UpdateQueueResponse
         */
        public UpdateQueueResponse UpdateQueue(UpdateQueueRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateQueueWithOptions(request, runtime);
        }

        /**
         * @summary 更新集群的队列配置信息
         *
         * @param request UpdateQueueRequest
         * @return UpdateQueueResponse
         */
        public async Task<UpdateQueueResponse> UpdateQueueAsync(UpdateQueueRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateQueueWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 更新集群单个用户属性
         *
         * @param request UpdateUserRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateUserResponse
         */
        public UpdateUserResponse UpdateUserWithOptions(UpdateUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Group))
            {
                query["Group"] = request.Group;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Password))
            {
                query["Password"] = request.Password;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserName))
            {
                query["UserName"] = request.UserName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateUser",
                Version = "2024-07-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateUserResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 更新集群单个用户属性
         *
         * @param request UpdateUserRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateUserResponse
         */
        public async Task<UpdateUserResponse> UpdateUserWithOptionsAsync(UpdateUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Group))
            {
                query["Group"] = request.Group;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Password))
            {
                query["Password"] = request.Password;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserName))
            {
                query["UserName"] = request.UserName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateUser",
                Version = "2024-07-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateUserResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 更新集群单个用户属性
         *
         * @param request UpdateUserRequest
         * @return UpdateUserResponse
         */
        public UpdateUserResponse UpdateUser(UpdateUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateUserWithOptions(request, runtime);
        }

        /**
         * @summary 更新集群单个用户属性
         *
         * @param request UpdateUserRequest
         * @return UpdateUserResponse
         */
        public async Task<UpdateUserResponse> UpdateUserAsync(UpdateUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateUserWithOptionsAsync(request, runtime);
        }

    }
}
