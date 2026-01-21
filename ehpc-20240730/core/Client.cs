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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Adds Elastic Compute Service (ECS) instances as compute nodes to Elastic High Performance Computing (E-HPC) clusters.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>The ECS instances must meet the following requirements:</para>
        /// <list type="bullet">
        /// <item><description>The ECS instances do not belong to any E-HPC cluster.</description></item>
        /// <item><description>The ECS instances reside in the same virtual private cloud (VPC) as the cluster.</description></item>
        /// <item><description>The ECS instances are in the Stopped state.
        /// Take of the following limits:</description></item>
        /// <item><description>You can specify multiple instance IDs to add them at a time. However, the instances must be of the same type.</description></item>
        /// <item><description>When an instance is added to the cluster, <a href="https://help.aliyun.com/zh/ecs/user-guide/re-initialize-a-system-disk">the system disk is reset</a> by using the image specified by the input parameters.</description></item>
        /// <item><description>If the instance has data disks, they are not automatically created and mounted after the instance is added.</description></item>
        /// <item><description>The hostname of the instance remains the same. Therefore, you must ensure that the hostname of the instance to be added is different from the hostname of an existing node in the cluster.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// AttachNodesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AttachNodesResponse
        /// </returns>
        public AttachNodesResponse AttachNodesWithOptions(AttachNodesRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            AttachNodesShrinkRequest request = new AttachNodesShrinkRequest();
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
                Action = "AttachNodes",
                Version = "2024-07-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AttachNodesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Adds Elastic Compute Service (ECS) instances as compute nodes to Elastic High Performance Computing (E-HPC) clusters.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>The ECS instances must meet the following requirements:</para>
        /// <list type="bullet">
        /// <item><description>The ECS instances do not belong to any E-HPC cluster.</description></item>
        /// <item><description>The ECS instances reside in the same virtual private cloud (VPC) as the cluster.</description></item>
        /// <item><description>The ECS instances are in the Stopped state.
        /// Take of the following limits:</description></item>
        /// <item><description>You can specify multiple instance IDs to add them at a time. However, the instances must be of the same type.</description></item>
        /// <item><description>When an instance is added to the cluster, <a href="https://help.aliyun.com/zh/ecs/user-guide/re-initialize-a-system-disk">the system disk is reset</a> by using the image specified by the input parameters.</description></item>
        /// <item><description>If the instance has data disks, they are not automatically created and mounted after the instance is added.</description></item>
        /// <item><description>The hostname of the instance remains the same. Therefore, you must ensure that the hostname of the instance to be added is different from the hostname of an existing node in the cluster.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// AttachNodesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AttachNodesResponse
        /// </returns>
        public async Task<AttachNodesResponse> AttachNodesWithOptionsAsync(AttachNodesRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            AttachNodesShrinkRequest request = new AttachNodesShrinkRequest();
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
                Action = "AttachNodes",
                Version = "2024-07-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AttachNodesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Adds Elastic Compute Service (ECS) instances as compute nodes to Elastic High Performance Computing (E-HPC) clusters.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>The ECS instances must meet the following requirements:</para>
        /// <list type="bullet">
        /// <item><description>The ECS instances do not belong to any E-HPC cluster.</description></item>
        /// <item><description>The ECS instances reside in the same virtual private cloud (VPC) as the cluster.</description></item>
        /// <item><description>The ECS instances are in the Stopped state.
        /// Take of the following limits:</description></item>
        /// <item><description>You can specify multiple instance IDs to add them at a time. However, the instances must be of the same type.</description></item>
        /// <item><description>When an instance is added to the cluster, <a href="https://help.aliyun.com/zh/ecs/user-guide/re-initialize-a-system-disk">the system disk is reset</a> by using the image specified by the input parameters.</description></item>
        /// <item><description>If the instance has data disks, they are not automatically created and mounted after the instance is added.</description></item>
        /// <item><description>The hostname of the instance remains the same. Therefore, you must ensure that the hostname of the instance to be added is different from the hostname of an existing node in the cluster.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// AttachNodesRequest
        /// </param>
        /// 
        /// <returns>
        /// AttachNodesResponse
        /// </returns>
        public AttachNodesResponse AttachNodes(AttachNodesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AttachNodesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Adds Elastic Compute Service (ECS) instances as compute nodes to Elastic High Performance Computing (E-HPC) clusters.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>The ECS instances must meet the following requirements:</para>
        /// <list type="bullet">
        /// <item><description>The ECS instances do not belong to any E-HPC cluster.</description></item>
        /// <item><description>The ECS instances reside in the same virtual private cloud (VPC) as the cluster.</description></item>
        /// <item><description>The ECS instances are in the Stopped state.
        /// Take of the following limits:</description></item>
        /// <item><description>You can specify multiple instance IDs to add them at a time. However, the instances must be of the same type.</description></item>
        /// <item><description>When an instance is added to the cluster, <a href="https://help.aliyun.com/zh/ecs/user-guide/re-initialize-a-system-disk">the system disk is reset</a> by using the image specified by the input parameters.</description></item>
        /// <item><description>If the instance has data disks, they are not automatically created and mounted after the instance is added.</description></item>
        /// <item><description>The hostname of the instance remains the same. Therefore, you must ensure that the hostname of the instance to be added is different from the hostname of an existing node in the cluster.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// AttachNodesRequest
        /// </param>
        /// 
        /// <returns>
        /// AttachNodesResponse
        /// </returns>
        public async Task<AttachNodesResponse> AttachNodesAsync(AttachNodesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AttachNodesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Attaches shared storage to an Elastic High Performance Computing (E-HPC) cluster.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2><a href="#"></a>Usage notes</h2>
        /// <para>When you call this operation, take note of the following items:</para>
        /// <list type="bullet">
        /// <item><description>The file system that you want to attach must be created in advance in the same virtual private cloud (VPC) as the destination cluster. For more information, see <a href="https://help.aliyun.com/document_detail/27530.html">Create a file system</a> and <a href="https://help.aliyun.com/document_detail/27531.html">Manage mount targets</a>.</description></item>
        /// <item><description>E-HPC clusters support Apsara File Storage NAS file systems.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// AttachSharedStoragesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AttachSharedStoragesResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Attaches shared storage to an Elastic High Performance Computing (E-HPC) cluster.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2><a href="#"></a>Usage notes</h2>
        /// <para>When you call this operation, take note of the following items:</para>
        /// <list type="bullet">
        /// <item><description>The file system that you want to attach must be created in advance in the same virtual private cloud (VPC) as the destination cluster. For more information, see <a href="https://help.aliyun.com/document_detail/27530.html">Create a file system</a> and <a href="https://help.aliyun.com/document_detail/27531.html">Manage mount targets</a>.</description></item>
        /// <item><description>E-HPC clusters support Apsara File Storage NAS file systems.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// AttachSharedStoragesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AttachSharedStoragesResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Attaches shared storage to an Elastic High Performance Computing (E-HPC) cluster.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2><a href="#"></a>Usage notes</h2>
        /// <para>When you call this operation, take note of the following items:</para>
        /// <list type="bullet">
        /// <item><description>The file system that you want to attach must be created in advance in the same virtual private cloud (VPC) as the destination cluster. For more information, see <a href="https://help.aliyun.com/document_detail/27530.html">Create a file system</a> and <a href="https://help.aliyun.com/document_detail/27531.html">Manage mount targets</a>.</description></item>
        /// <item><description>E-HPC clusters support Apsara File Storage NAS file systems.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// AttachSharedStoragesRequest
        /// </param>
        /// 
        /// <returns>
        /// AttachSharedStoragesResponse
        /// </returns>
        public AttachSharedStoragesResponse AttachSharedStorages(AttachSharedStoragesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AttachSharedStoragesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Attaches shared storage to an Elastic High Performance Computing (E-HPC) cluster.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2><a href="#"></a>Usage notes</h2>
        /// <para>When you call this operation, take note of the following items:</para>
        /// <list type="bullet">
        /// <item><description>The file system that you want to attach must be created in advance in the same virtual private cloud (VPC) as the destination cluster. For more information, see <a href="https://help.aliyun.com/document_detail/27530.html">Create a file system</a> and <a href="https://help.aliyun.com/document_detail/27531.html">Manage mount targets</a>.</description></item>
        /// <item><description>E-HPC clusters support Apsara File Storage NAS file systems.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// AttachSharedStoragesRequest
        /// </param>
        /// 
        /// <returns>
        /// AttachSharedStoragesResponse
        /// </returns>
        public async Task<AttachSharedStoragesResponse> AttachSharedStoragesAsync(AttachSharedStoragesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AttachSharedStoragesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a pay-as-you-go or subscription Elastic High Performance Computing (E-HPC) cluster.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2><a href="#"></a>Usage notes</h2>
        /// <para>Before you call this operation, make sure that you are familiar with the billing and pricing of E-HPC. For more information, see <a href="https://help.aliyun.com/document_detail/2842985.html">Overview</a>.</para>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// CreateClusterRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateClusterResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a pay-as-you-go or subscription Elastic High Performance Computing (E-HPC) cluster.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2><a href="#"></a>Usage notes</h2>
        /// <para>Before you call this operation, make sure that you are familiar with the billing and pricing of E-HPC. For more information, see <a href="https://help.aliyun.com/document_detail/2842985.html">Overview</a>.</para>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// CreateClusterRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateClusterResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a pay-as-you-go or subscription Elastic High Performance Computing (E-HPC) cluster.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2><a href="#"></a>Usage notes</h2>
        /// <para>Before you call this operation, make sure that you are familiar with the billing and pricing of E-HPC. For more information, see <a href="https://help.aliyun.com/document_detail/2842985.html">Overview</a>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateClusterRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateClusterResponse
        /// </returns>
        public CreateClusterResponse CreateCluster(CreateClusterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateClusterWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a pay-as-you-go or subscription Elastic High Performance Computing (E-HPC) cluster.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2><a href="#"></a>Usage notes</h2>
        /// <para>Before you call this operation, make sure that you are familiar with the billing and pricing of E-HPC. For more information, see <a href="https://help.aliyun.com/document_detail/2842985.html">Overview</a>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateClusterRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateClusterResponse
        /// </returns>
        public async Task<CreateClusterResponse> CreateClusterAsync(CreateClusterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateClusterWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a job for a cluster.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you call this operation, make sure that you understand the billing and <a href="https://www.aliyun.com/price/product#/ecs/detail">pricing</a> of E-HPC.</para>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// CreateJobRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateJobResponse
        /// </returns>
        public CreateJobResponse CreateJobWithOptions(CreateJobRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateJobShrinkRequest request = new CreateJobShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.JobSpec))
            {
                request.JobSpecShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.JobSpec, "JobSpec", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobName))
            {
                query["JobName"] = request.JobName;
            }
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
                Action = "CreateJob",
                Version = "2024-07-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateJobResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a job for a cluster.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you call this operation, make sure that you understand the billing and <a href="https://www.aliyun.com/price/product#/ecs/detail">pricing</a> of E-HPC.</para>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// CreateJobRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateJobResponse
        /// </returns>
        public async Task<CreateJobResponse> CreateJobWithOptionsAsync(CreateJobRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateJobShrinkRequest request = new CreateJobShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.JobSpec))
            {
                request.JobSpecShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.JobSpec, "JobSpec", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobName))
            {
                query["JobName"] = request.JobName;
            }
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
                Action = "CreateJob",
                Version = "2024-07-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateJobResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a job for a cluster.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you call this operation, make sure that you understand the billing and <a href="https://www.aliyun.com/price/product#/ecs/detail">pricing</a> of E-HPC.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateJobRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateJobResponse
        /// </returns>
        public CreateJobResponse CreateJob(CreateJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateJobWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a job for a cluster.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you call this operation, make sure that you understand the billing and <a href="https://www.aliyun.com/price/product#/ecs/detail">pricing</a> of E-HPC.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateJobRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateJobResponse
        /// </returns>
        public async Task<CreateJobResponse> CreateJobAsync(CreateJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateJobWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates compute nodes for an Elastic High Performance Computing (E-HPC) cluster.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2><a href="#"></a></h2>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// CreateNodesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateNodesResponse
        /// </returns>
        public CreateNodesResponse CreateNodesWithOptions(CreateNodesRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateNodesShrinkRequest request = new CreateNodesShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ComputeNode))
            {
                request.ComputeNodeShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ComputeNode, "ComputeNode", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Hostnames))
            {
                request.HostnamesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Hostnames, "Hostnames", "json");
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeploymentSetId))
            {
                query["DeploymentSetId"] = request.DeploymentSetId;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HostnamesShrink))
            {
                query["Hostnames"] = request.HostnamesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeepAlive))
            {
                query["KeepAlive"] = request.KeepAlive;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MinCount))
            {
                query["MinCount"] = request.MinCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueueName))
            {
                query["QueueName"] = request.QueueName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RamRole))
            {
                query["RamRole"] = request.RamRole;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReservedNodePoolId))
            {
                query["ReservedNodePoolId"] = request.ReservedNodePoolId;
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates compute nodes for an Elastic High Performance Computing (E-HPC) cluster.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2><a href="#"></a></h2>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// CreateNodesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateNodesResponse
        /// </returns>
        public async Task<CreateNodesResponse> CreateNodesWithOptionsAsync(CreateNodesRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateNodesShrinkRequest request = new CreateNodesShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ComputeNode))
            {
                request.ComputeNodeShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ComputeNode, "ComputeNode", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Hostnames))
            {
                request.HostnamesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Hostnames, "Hostnames", "json");
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeploymentSetId))
            {
                query["DeploymentSetId"] = request.DeploymentSetId;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HostnamesShrink))
            {
                query["Hostnames"] = request.HostnamesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeepAlive))
            {
                query["KeepAlive"] = request.KeepAlive;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MinCount))
            {
                query["MinCount"] = request.MinCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueueName))
            {
                query["QueueName"] = request.QueueName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RamRole))
            {
                query["RamRole"] = request.RamRole;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReservedNodePoolId))
            {
                query["ReservedNodePoolId"] = request.ReservedNodePoolId;
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates compute nodes for an Elastic High Performance Computing (E-HPC) cluster.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2><a href="#"></a></h2>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateNodesRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateNodesResponse
        /// </returns>
        public CreateNodesResponse CreateNodes(CreateNodesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateNodesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates compute nodes for an Elastic High Performance Computing (E-HPC) cluster.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2><a href="#"></a></h2>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateNodesRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateNodesResponse
        /// </returns>
        public async Task<CreateNodesResponse> CreateNodesAsync(CreateNodesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateNodesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a queue for an Enterprise High Performance Computing (E-HPC) cluster.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// CreateQueueRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateQueueResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a queue for an Enterprise High Performance Computing (E-HPC) cluster.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// CreateQueueRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateQueueResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a queue for an Enterprise High Performance Computing (E-HPC) cluster.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateQueueRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateQueueResponse
        /// </returns>
        public CreateQueueResponse CreateQueue(CreateQueueRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateQueueWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a queue for an Enterprise High Performance Computing (E-HPC) cluster.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateQueueRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateQueueResponse
        /// </returns>
        public async Task<CreateQueueResponse> CreateQueueAsync(CreateQueueRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateQueueWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Adds users to an Elastic High Performance Computing (E-HPC) cluster.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// CreateUsersRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateUsersResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Adds users to an Elastic High Performance Computing (E-HPC) cluster.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// CreateUsersRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateUsersResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Adds users to an Elastic High Performance Computing (E-HPC) cluster.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateUsersRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateUsersResponse
        /// </returns>
        public CreateUsersResponse CreateUsers(CreateUsersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateUsersWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Adds users to an Elastic High Performance Computing (E-HPC) cluster.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateUsersRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateUsersResponse
        /// </returns>
        public async Task<CreateUsersResponse> CreateUsersAsync(CreateUsersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateUsersWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Releases an Enterprise High Performance Computing (E-HPC) cluster.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2><a href="#"></a>Usage notes</h2>
        /// <para>Make sure that data of the cluster to be deleted is backed up before you call this operation.</para>
        /// <remarks>
        /// <para>After a cluster is released, you cannot restore the data stored in the cluster. Exercise caution when you release a cluster.</para>
        /// </remarks>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteClusterRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteClusterResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Releases an Enterprise High Performance Computing (E-HPC) cluster.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2><a href="#"></a>Usage notes</h2>
        /// <para>Make sure that data of the cluster to be deleted is backed up before you call this operation.</para>
        /// <remarks>
        /// <para>After a cluster is released, you cannot restore the data stored in the cluster. Exercise caution when you release a cluster.</para>
        /// </remarks>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteClusterRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteClusterResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Releases an Enterprise High Performance Computing (E-HPC) cluster.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2><a href="#"></a>Usage notes</h2>
        /// <para>Make sure that data of the cluster to be deleted is backed up before you call this operation.</para>
        /// <remarks>
        /// <para>After a cluster is released, you cannot restore the data stored in the cluster. Exercise caution when you release a cluster.</para>
        /// </remarks>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteClusterRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteClusterResponse
        /// </returns>
        public DeleteClusterResponse DeleteCluster(DeleteClusterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteClusterWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Releases an Enterprise High Performance Computing (E-HPC) cluster.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2><a href="#"></a>Usage notes</h2>
        /// <para>Make sure that data of the cluster to be deleted is backed up before you call this operation.</para>
        /// <remarks>
        /// <para>After a cluster is released, you cannot restore the data stored in the cluster. Exercise caution when you release a cluster.</para>
        /// </remarks>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteClusterRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteClusterResponse
        /// </returns>
        public async Task<DeleteClusterResponse> DeleteClusterAsync(DeleteClusterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteClusterWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes compute nodes from an Enterprise High Performance Computing (E-HPC) cluster at a time.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2><a href="#"></a>Usage notes</h2>
        /// <para>Before you delete a compute node, we recommend that you export all job data from the node to prevent data loss.</para>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// DeleteNodesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteNodesResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes compute nodes from an Enterprise High Performance Computing (E-HPC) cluster at a time.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2><a href="#"></a>Usage notes</h2>
        /// <para>Before you delete a compute node, we recommend that you export all job data from the node to prevent data loss.</para>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// DeleteNodesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteNodesResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes compute nodes from an Enterprise High Performance Computing (E-HPC) cluster at a time.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2><a href="#"></a>Usage notes</h2>
        /// <para>Before you delete a compute node, we recommend that you export all job data from the node to prevent data loss.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteNodesRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteNodesResponse
        /// </returns>
        public DeleteNodesResponse DeleteNodes(DeleteNodesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteNodesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes compute nodes from an Enterprise High Performance Computing (E-HPC) cluster at a time.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2><a href="#"></a>Usage notes</h2>
        /// <para>Before you delete a compute node, we recommend that you export all job data from the node to prevent data loss.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteNodesRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteNodesResponse
        /// </returns>
        public async Task<DeleteNodesResponse> DeleteNodesAsync(DeleteNodesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteNodesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes queues from an Enterprise High Performance Computing (E-HPC) cluster.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2><a href="#"></a>Usage notes</h2>
        /// <para>Before you delete a queue, you must delete all compute nodes in the queue.</para>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// DeleteQueuesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteQueuesResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes queues from an Enterprise High Performance Computing (E-HPC) cluster.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2><a href="#"></a>Usage notes</h2>
        /// <para>Before you delete a queue, you must delete all compute nodes in the queue.</para>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// DeleteQueuesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteQueuesResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes queues from an Enterprise High Performance Computing (E-HPC) cluster.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2><a href="#"></a>Usage notes</h2>
        /// <para>Before you delete a queue, you must delete all compute nodes in the queue.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteQueuesRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteQueuesResponse
        /// </returns>
        public DeleteQueuesResponse DeleteQueues(DeleteQueuesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteQueuesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes queues from an Enterprise High Performance Computing (E-HPC) cluster.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2><a href="#"></a>Usage notes</h2>
        /// <para>Before you delete a queue, you must delete all compute nodes in the queue.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteQueuesRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteQueuesResponse
        /// </returns>
        public async Task<DeleteQueuesResponse> DeleteQueuesAsync(DeleteQueuesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteQueuesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes users from a cluster.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// DeleteUsersRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteUsersResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes users from a cluster.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// DeleteUsersRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteUsersResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes users from a cluster.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteUsersRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteUsersResponse
        /// </returns>
        public DeleteUsersResponse DeleteUsers(DeleteUsersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteUsersWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes users from a cluster.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteUsersRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteUsersResponse
        /// </returns>
        public async Task<DeleteUsersResponse> DeleteUsersAsync(DeleteUsersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteUsersWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of an addon template.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeAddonTemplateRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeAddonTemplateResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of an addon template.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeAddonTemplateRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeAddonTemplateResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of an addon template.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeAddonTemplateRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeAddonTemplateResponse
        /// </returns>
        public DescribeAddonTemplateResponse DescribeAddonTemplate(DescribeAddonTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeAddonTemplateWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of an addon template.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeAddonTemplateRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeAddonTemplateResponse
        /// </returns>
        public async Task<DescribeAddonTemplateResponse> DescribeAddonTemplateAsync(DescribeAddonTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeAddonTemplateWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Unmounts shared storage from the mount directory of a cluster.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// DetachSharedStoragesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DetachSharedStoragesResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Unmounts shared storage from the mount directory of a cluster.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// DetachSharedStoragesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DetachSharedStoragesResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Unmounts shared storage from the mount directory of a cluster.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DetachSharedStoragesRequest
        /// </param>
        /// 
        /// <returns>
        /// DetachSharedStoragesResponse
        /// </returns>
        public DetachSharedStoragesResponse DetachSharedStorages(DetachSharedStoragesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DetachSharedStoragesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Unmounts shared storage from the mount directory of a cluster.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DetachSharedStoragesRequest
        /// </param>
        /// 
        /// <returns>
        /// DetachSharedStoragesResponse
        /// </returns>
        public async Task<DetachSharedStoragesResponse> DetachSharedStoragesAsync(DetachSharedStoragesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DetachSharedStoragesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of an installed addon.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAddonRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetAddonResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of an installed addon.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAddonRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetAddonResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of an installed addon.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAddonRequest
        /// </param>
        /// 
        /// <returns>
        /// GetAddonResponse
        /// </returns>
        public GetAddonResponse GetAddon(GetAddonRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetAddonWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of an installed addon.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetAddonRequest
        /// </param>
        /// 
        /// <returns>
        /// GetAddonResponse
        /// </returns>
        public async Task<GetAddonResponse> GetAddonAsync(GetAddonRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetAddonWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries information about an Elastic High Performance Computing (E-HPC) cluster.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetClusterRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetClusterResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries information about an Elastic High Performance Computing (E-HPC) cluster.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetClusterRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetClusterResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries information about an Elastic High Performance Computing (E-HPC) cluster.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetClusterRequest
        /// </param>
        /// 
        /// <returns>
        /// GetClusterResponse
        /// </returns>
        public GetClusterResponse GetCluster(GetClusterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetClusterWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries information about an Elastic High Performance Computing (E-HPC) cluster.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetClusterRequest
        /// </param>
        /// 
        /// <returns>
        /// GetClusterResponse
        /// </returns>
        public async Task<GetClusterResponse> GetClusterAsync(GetClusterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetClusterWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Query logs based on a request ID. Logs for specific actions can be queried thanks to an Action-Stage-Method three-layer log splitting structure.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetCommonLogDetailRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetCommonLogDetailResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Query logs based on a request ID. Logs for specific actions can be queried thanks to an Action-Stage-Method three-layer log splitting structure.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetCommonLogDetailRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetCommonLogDetailResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Query logs based on a request ID. Logs for specific actions can be queried thanks to an Action-Stage-Method three-layer log splitting structure.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetCommonLogDetailRequest
        /// </param>
        /// 
        /// <returns>
        /// GetCommonLogDetailResponse
        /// </returns>
        public GetCommonLogDetailResponse GetCommonLogDetail(GetCommonLogDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetCommonLogDetailWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Query logs based on a request ID. Logs for specific actions can be queried thanks to an Action-Stage-Method three-layer log splitting structure.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetCommonLogDetailRequest
        /// </param>
        /// 
        /// <returns>
        /// GetCommonLogDetailResponse
        /// </returns>
        public async Task<GetCommonLogDetailResponse> GetCommonLogDetailAsync(GetCommonLogDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetCommonLogDetailWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains the details of a job.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetJobRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetJobResponse
        /// </returns>
        public GetJobResponse GetJobWithOptions(GetJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobId))
            {
                query["JobId"] = request.JobId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetJob",
                Version = "2024-07-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetJobResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains the details of a job.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetJobRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetJobResponse
        /// </returns>
        public async Task<GetJobResponse> GetJobWithOptionsAsync(GetJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobId))
            {
                query["JobId"] = request.JobId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetJob",
                Version = "2024-07-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetJobResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains the details of a job.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetJobRequest
        /// </param>
        /// 
        /// <returns>
        /// GetJobResponse
        /// </returns>
        public GetJobResponse GetJob(GetJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetJobWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains the details of a job.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetJobRequest
        /// </param>
        /// 
        /// <returns>
        /// GetJobResponse
        /// </returns>
        public async Task<GetJobResponse> GetJobAsync(GetJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetJobWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the output logs of a job, including standard output logs and error output logs.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2><a href="#"></a>Usage notes</h2>
        /// <para>Currently, only Slurm and PBS Pro schedulers for Standard Edition clusters are supported.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetJobLogRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetJobLogResponse
        /// </returns>
        public GetJobLogResponse GetJobLogWithOptions(GetJobLogRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobId))
            {
                query["JobId"] = request.JobId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogType))
            {
                query["LogType"] = request.LogType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Offset))
            {
                query["Offset"] = request.Offset;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Size))
            {
                query["Size"] = request.Size;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetJobLog",
                Version = "2024-07-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetJobLogResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the output logs of a job, including standard output logs and error output logs.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2><a href="#"></a>Usage notes</h2>
        /// <para>Currently, only Slurm and PBS Pro schedulers for Standard Edition clusters are supported.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetJobLogRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetJobLogResponse
        /// </returns>
        public async Task<GetJobLogResponse> GetJobLogWithOptionsAsync(GetJobLogRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobId))
            {
                query["JobId"] = request.JobId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LogType))
            {
                query["LogType"] = request.LogType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Offset))
            {
                query["Offset"] = request.Offset;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Size))
            {
                query["Size"] = request.Size;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetJobLog",
                Version = "2024-07-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetJobLogResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the output logs of a job, including standard output logs and error output logs.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2><a href="#"></a>Usage notes</h2>
        /// <para>Currently, only Slurm and PBS Pro schedulers for Standard Edition clusters are supported.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetJobLogRequest
        /// </param>
        /// 
        /// <returns>
        /// GetJobLogResponse
        /// </returns>
        public GetJobLogResponse GetJobLog(GetJobLogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetJobLogWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the output logs of a job, including standard output logs and error output logs.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2><a href="#"></a>Usage notes</h2>
        /// <para>Currently, only Slurm and PBS Pro schedulers for Standard Edition clusters are supported.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetJobLogRequest
        /// </param>
        /// 
        /// <returns>
        /// GetJobLogResponse
        /// </returns>
        public async Task<GetJobLogResponse> GetJobLogAsync(GetJobLogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetJobLogWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of a queue in an Elastic High Performance Computing (E-HPC) cluster.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetQueueRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetQueueResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of a queue in an Elastic High Performance Computing (E-HPC) cluster.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetQueueRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetQueueResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of a queue in an Elastic High Performance Computing (E-HPC) cluster.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetQueueRequest
        /// </param>
        /// 
        /// <returns>
        /// GetQueueResponse
        /// </returns>
        public GetQueueResponse GetQueue(GetQueueRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetQueueWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of a queue in an Elastic High Performance Computing (E-HPC) cluster.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetQueueRequest
        /// </param>
        /// 
        /// <returns>
        /// GetQueueResponse
        /// </returns>
        public async Task<GetQueueResponse> GetQueueAsync(GetQueueRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetQueueWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Installs an addon.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2><a href="#"></a>Usage notes</h2>
        /// <para>Take note of the following items when you call this operation:</para>
        /// <list type="bullet">
        /// <item><description>The cluster must be in the <c>Running</c> state.</description></item>
        /// <item><description>Clusters fall into two types:<list type="bullet">
        /// <item><description>Regular clusters on Alibaba Cloud Public Cloud</description></item>
        /// <item><description>Managed clusters on Alibaba Cloud Public Cloud</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// InstallAddonRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// InstallAddonResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Installs an addon.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2><a href="#"></a>Usage notes</h2>
        /// <para>Take note of the following items when you call this operation:</para>
        /// <list type="bullet">
        /// <item><description>The cluster must be in the <c>Running</c> state.</description></item>
        /// <item><description>Clusters fall into two types:<list type="bullet">
        /// <item><description>Regular clusters on Alibaba Cloud Public Cloud</description></item>
        /// <item><description>Managed clusters on Alibaba Cloud Public Cloud</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// InstallAddonRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// InstallAddonResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Installs an addon.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2><a href="#"></a>Usage notes</h2>
        /// <para>Take note of the following items when you call this operation:</para>
        /// <list type="bullet">
        /// <item><description>The cluster must be in the <c>Running</c> state.</description></item>
        /// <item><description>Clusters fall into two types:<list type="bullet">
        /// <item><description>Regular clusters on Alibaba Cloud Public Cloud</description></item>
        /// <item><description>Managed clusters on Alibaba Cloud Public Cloud</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// InstallAddonRequest
        /// </param>
        /// 
        /// <returns>
        /// InstallAddonResponse
        /// </returns>
        public InstallAddonResponse InstallAddon(InstallAddonRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return InstallAddonWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Installs an addon.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2><a href="#"></a>Usage notes</h2>
        /// <para>Take note of the following items when you call this operation:</para>
        /// <list type="bullet">
        /// <item><description>The cluster must be in the <c>Running</c> state.</description></item>
        /// <item><description>Clusters fall into two types:<list type="bullet">
        /// <item><description>Regular clusters on Alibaba Cloud Public Cloud</description></item>
        /// <item><description>Managed clusters on Alibaba Cloud Public Cloud</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// InstallAddonRequest
        /// </param>
        /// 
        /// <returns>
        /// InstallAddonResponse
        /// </returns>
        public async Task<InstallAddonResponse> InstallAddonAsync(InstallAddonRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await InstallAddonWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Install software for the specified cluster.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Interface Description</h2>
        /// <para>When calling this interface, please note the following:</para>
        /// <list type="bullet">
        /// <item><description>The cluster status must be <c>Running</c>. </description></item>
        /// <item><description>If the cluster series is <c>Serverless</c>, ensure that there is at least one login node or compute node in the cluster; otherwise, software cannot be added to the target cluster.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// InstallSoftwaresRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// InstallSoftwaresResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Install software for the specified cluster.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Interface Description</h2>
        /// <para>When calling this interface, please note the following:</para>
        /// <list type="bullet">
        /// <item><description>The cluster status must be <c>Running</c>. </description></item>
        /// <item><description>If the cluster series is <c>Serverless</c>, ensure that there is at least one login node or compute node in the cluster; otherwise, software cannot be added to the target cluster.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// InstallSoftwaresRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// InstallSoftwaresResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Install software for the specified cluster.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Interface Description</h2>
        /// <para>When calling this interface, please note the following:</para>
        /// <list type="bullet">
        /// <item><description>The cluster status must be <c>Running</c>. </description></item>
        /// <item><description>If the cluster series is <c>Serverless</c>, ensure that there is at least one login node or compute node in the cluster; otherwise, software cannot be added to the target cluster.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// InstallSoftwaresRequest
        /// </param>
        /// 
        /// <returns>
        /// InstallSoftwaresResponse
        /// </returns>
        public InstallSoftwaresResponse InstallSoftwares(InstallSoftwaresRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return InstallSoftwaresWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Install software for the specified cluster.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Interface Description</h2>
        /// <para>When calling this interface, please note the following:</para>
        /// <list type="bullet">
        /// <item><description>The cluster status must be <c>Running</c>. </description></item>
        /// <item><description>If the cluster series is <c>Serverless</c>, ensure that there is at least one login node or compute node in the cluster; otherwise, software cannot be added to the target cluster.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// InstallSoftwaresRequest
        /// </param>
        /// 
        /// <returns>
        /// InstallSoftwaresResponse
        /// </returns>
        public async Task<InstallSoftwaresResponse> InstallSoftwaresAsync(InstallSoftwaresRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await InstallSoftwaresWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries supported addon templates.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAddonTemplatesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListAddonTemplatesResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries supported addon templates.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAddonTemplatesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListAddonTemplatesResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries supported addon templates.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAddonTemplatesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListAddonTemplatesResponse
        /// </returns>
        public ListAddonTemplatesResponse ListAddonTemplates(ListAddonTemplatesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListAddonTemplatesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries supported addon templates.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAddonTemplatesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListAddonTemplatesResponse
        /// </returns>
        public async Task<ListAddonTemplatesResponse> ListAddonTemplatesAsync(ListAddonTemplatesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListAddonTemplatesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries installed addons of an Elastic High Performance Computing (E-HPC) cluster.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ListAddonsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListAddonsResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries installed addons of an Elastic High Performance Computing (E-HPC) cluster.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ListAddonsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListAddonsResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries installed addons of an Elastic High Performance Computing (E-HPC) cluster.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAddonsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListAddonsResponse
        /// </returns>
        public ListAddonsResponse ListAddons(ListAddonsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListAddonsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries installed addons of an Elastic High Performance Computing (E-HPC) cluster.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAddonsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListAddonsResponse
        /// </returns>
        public async Task<ListAddonsResponse> ListAddonsAsync(ListAddonsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListAddonsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the file systems that can be attached in a region.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAvailableFileSystemsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListAvailableFileSystemsResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the file systems that can be attached in a region.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAvailableFileSystemsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListAvailableFileSystemsResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the file systems that can be attached in a region.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAvailableFileSystemsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListAvailableFileSystemsResponse
        /// </returns>
        public ListAvailableFileSystemsResponse ListAvailableFileSystems(ListAvailableFileSystemsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListAvailableFileSystemsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the file systems that can be attached in a region.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAvailableFileSystemsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListAvailableFileSystemsResponse
        /// </returns>
        public async Task<ListAvailableFileSystemsResponse> ListAvailableFileSystemsAsync(ListAvailableFileSystemsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListAvailableFileSystemsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries images that are available for Elastic High Performance Computing (E-HPC) clusters.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ListAvailableImagesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListAvailableImagesResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries images that are available for Elastic High Performance Computing (E-HPC) clusters.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ListAvailableImagesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListAvailableImagesResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries images that are available for Elastic High Performance Computing (E-HPC) clusters.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAvailableImagesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListAvailableImagesResponse
        /// </returns>
        public ListAvailableImagesResponse ListAvailableImages(ListAvailableImagesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListAvailableImagesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries images that are available for Elastic High Performance Computing (E-HPC) clusters.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAvailableImagesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListAvailableImagesResponse
        /// </returns>
        public async Task<ListAvailableImagesResponse> ListAvailableImagesAsync(ListAvailableImagesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListAvailableImagesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries all clusters of a user in each region.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ListClustersRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListClustersResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries all clusters of a user in each region.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ListClustersRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListClustersResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries all clusters of a user in each region.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListClustersRequest
        /// </param>
        /// 
        /// <returns>
        /// ListClustersResponse
        /// </returns>
        public ListClustersResponse ListClusters(ListClustersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListClustersWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries all clusters of a user in each region.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListClustersRequest
        /// </param>
        /// 
        /// <returns>
        /// ListClustersResponse
        /// </returns>
        public async Task<ListClustersResponse> ListClustersAsync(ListClustersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListClustersWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the logs of a cluster that are generated within a time range.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ListCommonLogsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListCommonLogsResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the logs of a cluster that are generated within a time range.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ListCommonLogsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListCommonLogsResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the logs of a cluster that are generated within a time range.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListCommonLogsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListCommonLogsResponse
        /// </returns>
        public ListCommonLogsResponse ListCommonLogs(ListCommonLogsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListCommonLogsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the logs of a cluster that are generated within a time range.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListCommonLogsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListCommonLogsResponse
        /// </returns>
        public async Task<ListCommonLogsResponse> ListCommonLogsAsync(ListCommonLogsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListCommonLogsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the installed software of a cluster.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListInstalledSoftwaresRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListInstalledSoftwaresResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the installed software of a cluster.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListInstalledSoftwaresRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListInstalledSoftwaresResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the installed software of a cluster.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListInstalledSoftwaresRequest
        /// </param>
        /// 
        /// <returns>
        /// ListInstalledSoftwaresResponse
        /// </returns>
        public ListInstalledSoftwaresResponse ListInstalledSoftwares(ListInstalledSoftwaresRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListInstalledSoftwaresWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the installed software of a cluster.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListInstalledSoftwaresRequest
        /// </param>
        /// 
        /// <returns>
        /// ListInstalledSoftwaresResponse
        /// </returns>
        public async Task<ListInstalledSoftwaresResponse> ListInstalledSoftwaresAsync(ListInstalledSoftwaresRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListInstalledSoftwaresWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the jobs in a cluster.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ListJobsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListJobsResponse
        /// </returns>
        public ListJobsResponse ListJobsWithOptions(ListJobsRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListJobsShrinkRequest request = new ListJobsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.JobFilter))
            {
                request.JobFilterShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.JobFilter, "JobFilter", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobFilterShrink))
            {
                query["JobFilter"] = request.JobFilterShrink;
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
                Action = "ListJobs",
                Version = "2024-07-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListJobsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the jobs in a cluster.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ListJobsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListJobsResponse
        /// </returns>
        public async Task<ListJobsResponse> ListJobsWithOptionsAsync(ListJobsRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListJobsShrinkRequest request = new ListJobsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.JobFilter))
            {
                request.JobFilterShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.JobFilter, "JobFilter", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobFilterShrink))
            {
                query["JobFilter"] = request.JobFilterShrink;
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
                Action = "ListJobs",
                Version = "2024-07-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListJobsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the jobs in a cluster.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListJobsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListJobsResponse
        /// </returns>
        public ListJobsResponse ListJobs(ListJobsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListJobsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the jobs in a cluster.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListJobsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListJobsResponse
        /// </returns>
        public async Task<ListJobsResponse> ListJobsAsync(ListJobsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListJobsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the nodes of an Elastic High Performance Computing (E-HPC) cluster.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ListNodesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListNodesResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the nodes of an Elastic High Performance Computing (E-HPC) cluster.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ListNodesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListNodesResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the nodes of an Elastic High Performance Computing (E-HPC) cluster.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListNodesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListNodesResponse
        /// </returns>
        public ListNodesResponse ListNodes(ListNodesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListNodesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the nodes of an Elastic High Performance Computing (E-HPC) cluster.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListNodesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListNodesResponse
        /// </returns>
        public async Task<ListNodesResponse> ListNodesAsync(ListNodesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListNodesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries queues in an Elastic High Performance Computing (E-HPC) cluster.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ListQueuesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListQueuesResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries queues in an Elastic High Performance Computing (E-HPC) cluster.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ListQueuesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListQueuesResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries queues in an Elastic High Performance Computing (E-HPC) cluster.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListQueuesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListQueuesResponse
        /// </returns>
        public ListQueuesResponse ListQueues(ListQueuesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListQueuesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries queues in an Elastic High Performance Computing (E-HPC) cluster.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListQueuesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListQueuesResponse
        /// </returns>
        public async Task<ListQueuesResponse> ListQueuesAsync(ListQueuesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListQueuesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询产品支持的地域列表。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListRegionsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListRegionsResponse
        /// </returns>
        public ListRegionsResponse ListRegionsWithOptions(ListRegionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AcceptLanguage))
            {
                query["AcceptLanguage"] = request.AcceptLanguage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SpecCode))
            {
                query["SpecCode"] = request.SpecCode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListRegions",
                Version = "2024-07-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListRegionsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询产品支持的地域列表。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListRegionsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListRegionsResponse
        /// </returns>
        public async Task<ListRegionsResponse> ListRegionsWithOptionsAsync(ListRegionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AcceptLanguage))
            {
                query["AcceptLanguage"] = request.AcceptLanguage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SpecCode))
            {
                query["SpecCode"] = request.SpecCode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListRegions",
                Version = "2024-07-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListRegionsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询产品支持的地域列表。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListRegionsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListRegionsResponse
        /// </returns>
        public ListRegionsResponse ListRegions(ListRegionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListRegionsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询产品支持的地域列表。</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListRegionsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListRegionsResponse
        /// </returns>
        public async Task<ListRegionsResponse> ListRegionsAsync(ListRegionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListRegionsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the shared storage that is attached to a cluster.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListSharedStoragesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListSharedStoragesResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the shared storage that is attached to a cluster.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListSharedStoragesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListSharedStoragesResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the shared storage that is attached to a cluster.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListSharedStoragesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListSharedStoragesResponse
        /// </returns>
        public ListSharedStoragesResponse ListSharedStorages(ListSharedStoragesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListSharedStoragesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the shared storage that is attached to a cluster.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListSharedStoragesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListSharedStoragesResponse
        /// </returns>
        public async Task<ListSharedStoragesResponse> ListSharedStoragesAsync(ListSharedStoragesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListSharedStoragesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the software that can be installed in an Elastic High Performance Computing (E-HPC) cluster.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListSoftwaresRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListSoftwaresResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the software that can be installed in an Elastic High Performance Computing (E-HPC) cluster.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListSoftwaresRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListSoftwaresResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the software that can be installed in an Elastic High Performance Computing (E-HPC) cluster.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListSoftwaresRequest
        /// </param>
        /// 
        /// <returns>
        /// ListSoftwaresResponse
        /// </returns>
        public ListSoftwaresResponse ListSoftwares(ListSoftwaresRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListSoftwaresWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the software that can be installed in an Elastic High Performance Computing (E-HPC) cluster.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListSoftwaresRequest
        /// </param>
        /// 
        /// <returns>
        /// ListSoftwaresResponse
        /// </returns>
        public async Task<ListSoftwaresResponse> ListSoftwaresAsync(ListSoftwaresRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListSoftwaresWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the users of a cluster.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListUsersRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListUsersResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the users of a cluster.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListUsersRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListUsersResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the users of a cluster.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListUsersRequest
        /// </param>
        /// 
        /// <returns>
        /// ListUsersResponse
        /// </returns>
        public ListUsersResponse ListUsers(ListUsersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListUsersWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the users of a cluster.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListUsersRequest
        /// </param>
        /// 
        /// <returns>
        /// ListUsersResponse
        /// </returns>
        public async Task<ListUsersResponse> ListUsersAsync(ListUsersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListUsersWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Stops uncompleted jobs in a batch in an Elastic High Performance Computing (E-HPC) cluster.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// StopJobsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// StopJobsResponse
        /// </returns>
        public StopJobsResponse StopJobsWithOptions(StopJobsRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            StopJobsShrinkRequest request = new StopJobsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.JobIds))
            {
                request.JobIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.JobIds, "JobIds", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobIdsShrink))
            {
                query["JobIds"] = request.JobIdsShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StopJobs",
                Version = "2024-07-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<StopJobsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Stops uncompleted jobs in a batch in an Elastic High Performance Computing (E-HPC) cluster.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// StopJobsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// StopJobsResponse
        /// </returns>
        public async Task<StopJobsResponse> StopJobsWithOptionsAsync(StopJobsRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            StopJobsShrinkRequest request = new StopJobsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.JobIds))
            {
                request.JobIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.JobIds, "JobIds", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterId))
            {
                query["ClusterId"] = request.ClusterId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobIdsShrink))
            {
                query["JobIds"] = request.JobIdsShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StopJobs",
                Version = "2024-07-30",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<StopJobsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Stops uncompleted jobs in a batch in an Elastic High Performance Computing (E-HPC) cluster.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// StopJobsRequest
        /// </param>
        /// 
        /// <returns>
        /// StopJobsResponse
        /// </returns>
        public StopJobsResponse StopJobs(StopJobsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StopJobsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Stops uncompleted jobs in a batch in an Elastic High Performance Computing (E-HPC) cluster.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// StopJobsRequest
        /// </param>
        /// 
        /// <returns>
        /// StopJobsResponse
        /// </returns>
        public async Task<StopJobsResponse> StopJobsAsync(StopJobsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StopJobsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Uninstalls an addon.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2><a href="#"></a>Usage notes</h2>
        /// <para>Take note of the following items when you call this operation:</para>
        /// <list type="bullet">
        /// <item><description>The cluster must be in the <c>Running</c> state.</description></item>
        /// <item><description>Clusters fall into the following types:<list type="bullet">
        /// <item><description>Regular clusters on Alibaba Cloud Public Cloud</description></item>
        /// <item><description>Managed clusters on Alibaba Cloud Public Cloud</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// UnInstallAddonRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UnInstallAddonResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Uninstalls an addon.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2><a href="#"></a>Usage notes</h2>
        /// <para>Take note of the following items when you call this operation:</para>
        /// <list type="bullet">
        /// <item><description>The cluster must be in the <c>Running</c> state.</description></item>
        /// <item><description>Clusters fall into the following types:<list type="bullet">
        /// <item><description>Regular clusters on Alibaba Cloud Public Cloud</description></item>
        /// <item><description>Managed clusters on Alibaba Cloud Public Cloud</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// UnInstallAddonRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UnInstallAddonResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Uninstalls an addon.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2><a href="#"></a>Usage notes</h2>
        /// <para>Take note of the following items when you call this operation:</para>
        /// <list type="bullet">
        /// <item><description>The cluster must be in the <c>Running</c> state.</description></item>
        /// <item><description>Clusters fall into the following types:<list type="bullet">
        /// <item><description>Regular clusters on Alibaba Cloud Public Cloud</description></item>
        /// <item><description>Managed clusters on Alibaba Cloud Public Cloud</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// UnInstallAddonRequest
        /// </param>
        /// 
        /// <returns>
        /// UnInstallAddonResponse
        /// </returns>
        public UnInstallAddonResponse UnInstallAddon(UnInstallAddonRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UnInstallAddonWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Uninstalls an addon.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2><a href="#"></a>Usage notes</h2>
        /// <para>Take note of the following items when you call this operation:</para>
        /// <list type="bullet">
        /// <item><description>The cluster must be in the <c>Running</c> state.</description></item>
        /// <item><description>Clusters fall into the following types:<list type="bullet">
        /// <item><description>Regular clusters on Alibaba Cloud Public Cloud</description></item>
        /// <item><description>Managed clusters on Alibaba Cloud Public Cloud</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// UnInstallAddonRequest
        /// </param>
        /// 
        /// <returns>
        /// UnInstallAddonResponse
        /// </returns>
        public async Task<UnInstallAddonResponse> UnInstallAddonAsync(UnInstallAddonRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UnInstallAddonWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Uninstalls software systems from an Enterprise High Performance Computing (E-HPC) cluster.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Interface Description</h2>
        /// <para>When calling this interface, please note:
        /// The cluster status must be <c>Running</c>.</para>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// UninstallSoftwaresRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UninstallSoftwaresResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Uninstalls software systems from an Enterprise High Performance Computing (E-HPC) cluster.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Interface Description</h2>
        /// <para>When calling this interface, please note:
        /// The cluster status must be <c>Running</c>.</para>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// UninstallSoftwaresRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UninstallSoftwaresResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Uninstalls software systems from an Enterprise High Performance Computing (E-HPC) cluster.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Interface Description</h2>
        /// <para>When calling this interface, please note:
        /// The cluster status must be <c>Running</c>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UninstallSoftwaresRequest
        /// </param>
        /// 
        /// <returns>
        /// UninstallSoftwaresResponse
        /// </returns>
        public UninstallSoftwaresResponse UninstallSoftwares(UninstallSoftwaresRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UninstallSoftwaresWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Uninstalls software systems from an Enterprise High Performance Computing (E-HPC) cluster.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Interface Description</h2>
        /// <para>When calling this interface, please note:
        /// The cluster status must be <c>Running</c>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UninstallSoftwaresRequest
        /// </param>
        /// 
        /// <returns>
        /// UninstallSoftwaresResponse
        /// </returns>
        public async Task<UninstallSoftwaresResponse> UninstallSoftwaresAsync(UninstallSoftwaresRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UninstallSoftwaresWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modify the basic information of a specified cluster.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// UpdateClusterRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateClusterResponse
        /// </returns>
        public UpdateClusterResponse UpdateClusterWithOptions(UpdateClusterRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateClusterShrinkRequest request = new UpdateClusterShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ClusterCustomConfiguration))
            {
                request.ClusterCustomConfigurationShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ClusterCustomConfiguration, "ClusterCustomConfiguration", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.MonitorSpec))
            {
                request.MonitorSpecShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.MonitorSpec, "MonitorSpec", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SchedulerSpec))
            {
                request.SchedulerSpecShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SchedulerSpec, "SchedulerSpec", "json");
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MonitorSpecShrink))
            {
                query["MonitorSpec"] = request.MonitorSpecShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SchedulerSpecShrink))
            {
                query["SchedulerSpec"] = request.SchedulerSpecShrink;
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modify the basic information of a specified cluster.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// UpdateClusterRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateClusterResponse
        /// </returns>
        public async Task<UpdateClusterResponse> UpdateClusterWithOptionsAsync(UpdateClusterRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateClusterShrinkRequest request = new UpdateClusterShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ClusterCustomConfiguration))
            {
                request.ClusterCustomConfigurationShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ClusterCustomConfiguration, "ClusterCustomConfiguration", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.MonitorSpec))
            {
                request.MonitorSpecShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.MonitorSpec, "MonitorSpec", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SchedulerSpec))
            {
                request.SchedulerSpecShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SchedulerSpec, "SchedulerSpec", "json");
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MonitorSpecShrink))
            {
                query["MonitorSpec"] = request.MonitorSpecShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SchedulerSpecShrink))
            {
                query["SchedulerSpec"] = request.SchedulerSpecShrink;
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modify the basic information of a specified cluster.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateClusterRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateClusterResponse
        /// </returns>
        public UpdateClusterResponse UpdateCluster(UpdateClusterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateClusterWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modify the basic information of a specified cluster.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateClusterRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateClusterResponse
        /// </returns>
        public async Task<UpdateClusterResponse> UpdateClusterAsync(UpdateClusterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateClusterWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the configurations of compute nodes in an Enterprise High Performance Computing (E-HPC) cluster.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2><a href="#"></a>Usage notes</h2>
        /// <para>Before you delete a compute node, we recommend that you export all job data from the node to prevent data loss.</para>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// UpdateNodesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateNodesResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the configurations of compute nodes in an Enterprise High Performance Computing (E-HPC) cluster.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2><a href="#"></a>Usage notes</h2>
        /// <para>Before you delete a compute node, we recommend that you export all job data from the node to prevent data loss.</para>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// UpdateNodesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateNodesResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the configurations of compute nodes in an Enterprise High Performance Computing (E-HPC) cluster.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2><a href="#"></a>Usage notes</h2>
        /// <para>Before you delete a compute node, we recommend that you export all job data from the node to prevent data loss.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateNodesRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateNodesResponse
        /// </returns>
        public UpdateNodesResponse UpdateNodes(UpdateNodesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateNodesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the configurations of compute nodes in an Enterprise High Performance Computing (E-HPC) cluster.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2><a href="#"></a>Usage notes</h2>
        /// <para>Before you delete a compute node, we recommend that you export all job data from the node to prevent data loss.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateNodesRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateNodesResponse
        /// </returns>
        public async Task<UpdateNodesResponse> UpdateNodesAsync(UpdateNodesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateNodesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the configurations of a queue in an Elastic High Performance Computing (E-HPC) cluster.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// UpdateQueueRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateQueueResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the configurations of a queue in an Elastic High Performance Computing (E-HPC) cluster.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// UpdateQueueRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateQueueResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the configurations of a queue in an Elastic High Performance Computing (E-HPC) cluster.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateQueueRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateQueueResponse
        /// </returns>
        public UpdateQueueResponse UpdateQueue(UpdateQueueRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateQueueWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the configurations of a queue in an Elastic High Performance Computing (E-HPC) cluster.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateQueueRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateQueueResponse
        /// </returns>
        public async Task<UpdateQueueResponse> UpdateQueueAsync(UpdateQueueRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateQueueWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the information of a user in an Elastic High Performance Computing (E-HPC) cluster, including the user group and password.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateUserRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateUserResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the information of a user in an Elastic High Performance Computing (E-HPC) cluster, including the user group and password.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateUserRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateUserResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the information of a user in an Elastic High Performance Computing (E-HPC) cluster, including the user group and password.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateUserRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateUserResponse
        /// </returns>
        public UpdateUserResponse UpdateUser(UpdateUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateUserWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the information of a user in an Elastic High Performance Computing (E-HPC) cluster, including the user group and password.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateUserRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateUserResponse
        /// </returns>
        public async Task<UpdateUserResponse> UpdateUserAsync(UpdateUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateUserWithOptionsAsync(request, runtime);
        }

    }
}
