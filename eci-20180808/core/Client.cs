// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Eci20180808.Models;

namespace AlibabaCloud.SDK.Eci20180808
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "";
            CheckConfig(config);
            this._endpoint = GetEndpoint("eci", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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
        /// <para>Creates an asynchronous task to store a specified container in an elastic container instance as an image and pushes the image to an image repository of Alibaba Cloud Container Registry.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You must specify the Alibaba Cloud Resource Name (ARN) of the RAM role of the Container Registry Enterprise Edition instance to grant the elastic container instance to assume the RAM role to push images.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CommitContainerRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CommitContainerResponse
        /// </returns>
        public CommitContainerResponse CommitContainerWithOptions(CommitContainerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AcrRegistryInfo))
            {
                query["AcrRegistryInfo"] = request.AcrRegistryInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Arn))
            {
                query["Arn"] = request.Arn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContainerGroupId))
            {
                query["ContainerGroupId"] = request.ContainerGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContainerName))
            {
                query["ContainerName"] = request.ContainerName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Image))
            {
                query["Image"] = request.Image;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CommitContainer",
                Version = "2018-08-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CommitContainerResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an asynchronous task to store a specified container in an elastic container instance as an image and pushes the image to an image repository of Alibaba Cloud Container Registry.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You must specify the Alibaba Cloud Resource Name (ARN) of the RAM role of the Container Registry Enterprise Edition instance to grant the elastic container instance to assume the RAM role to push images.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CommitContainerRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CommitContainerResponse
        /// </returns>
        public async Task<CommitContainerResponse> CommitContainerWithOptionsAsync(CommitContainerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AcrRegistryInfo))
            {
                query["AcrRegistryInfo"] = request.AcrRegistryInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Arn))
            {
                query["Arn"] = request.Arn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContainerGroupId))
            {
                query["ContainerGroupId"] = request.ContainerGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContainerName))
            {
                query["ContainerName"] = request.ContainerName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Image))
            {
                query["Image"] = request.Image;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CommitContainer",
                Version = "2018-08-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CommitContainerResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an asynchronous task to store a specified container in an elastic container instance as an image and pushes the image to an image repository of Alibaba Cloud Container Registry.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You must specify the Alibaba Cloud Resource Name (ARN) of the RAM role of the Container Registry Enterprise Edition instance to grant the elastic container instance to assume the RAM role to push images.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CommitContainerRequest
        /// </param>
        /// 
        /// <returns>
        /// CommitContainerResponse
        /// </returns>
        public CommitContainerResponse CommitContainer(CommitContainerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CommitContainerWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an asynchronous task to store a specified container in an elastic container instance as an image and pushes the image to an image repository of Alibaba Cloud Container Registry.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You must specify the Alibaba Cloud Resource Name (ARN) of the RAM role of the Container Registry Enterprise Edition instance to grant the elastic container instance to assume the RAM role to push images.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CommitContainerRequest
        /// </param>
        /// 
        /// <returns>
        /// CommitContainerResponse
        /// </returns>
        public async Task<CommitContainerResponse> CommitContainerAsync(CommitContainerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CommitContainerWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Copies a DataCache from one region to another region.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You cannot directly use a DataCache across regions. You can call this operation to copy a DataCache from one region to another region. This operation is suitable for the following scenarios:</para>
        /// <list type="bullet">
        /// <item><description>If you want to use a DataCache across regions and the DataCache exists in Region A, you can call this operation to quickly copy the DataCache to Region B.</description></item>
        /// <item><description>If you directly pull data from a region outside China to a region inside the Chinese mainland when you create a DataCache, the data may be pulled at a slow speed due to network limits. In this case, you can create a DataCache in a region outside the Chinese mainland but inside China, such as the China (Hong Kong) region, and call this operation to copy the data to the region inside the Chinese mainland.<remarks>
        /// <para>The process of copying a DataCache is equivalent to copying a snapshot. You are charged for the traffic generated during the copy process and the storage of the generated DataCache.</para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CopyDataCacheRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CopyDataCacheResponse
        /// </returns>
        public CopyDataCacheResponse CopyDataCacheWithOptions(CopyDataCacheRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Bucket))
            {
                query["Bucket"] = request.Bucket;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataCacheId))
            {
                query["DataCacheId"] = request.DataCacheId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestinationRegionId))
            {
                query["DestinationRegionId"] = request.DestinationRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Path))
            {
                query["Path"] = request.Path;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RetentionDays))
            {
                query["RetentionDays"] = request.RetentionDays;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                query["Tag"] = request.Tag;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CopyDataCache",
                Version = "2018-08-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CopyDataCacheResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Copies a DataCache from one region to another region.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You cannot directly use a DataCache across regions. You can call this operation to copy a DataCache from one region to another region. This operation is suitable for the following scenarios:</para>
        /// <list type="bullet">
        /// <item><description>If you want to use a DataCache across regions and the DataCache exists in Region A, you can call this operation to quickly copy the DataCache to Region B.</description></item>
        /// <item><description>If you directly pull data from a region outside China to a region inside the Chinese mainland when you create a DataCache, the data may be pulled at a slow speed due to network limits. In this case, you can create a DataCache in a region outside the Chinese mainland but inside China, such as the China (Hong Kong) region, and call this operation to copy the data to the region inside the Chinese mainland.<remarks>
        /// <para>The process of copying a DataCache is equivalent to copying a snapshot. You are charged for the traffic generated during the copy process and the storage of the generated DataCache.</para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CopyDataCacheRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CopyDataCacheResponse
        /// </returns>
        public async Task<CopyDataCacheResponse> CopyDataCacheWithOptionsAsync(CopyDataCacheRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Bucket))
            {
                query["Bucket"] = request.Bucket;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataCacheId))
            {
                query["DataCacheId"] = request.DataCacheId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestinationRegionId))
            {
                query["DestinationRegionId"] = request.DestinationRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Path))
            {
                query["Path"] = request.Path;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RetentionDays))
            {
                query["RetentionDays"] = request.RetentionDays;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                query["Tag"] = request.Tag;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CopyDataCache",
                Version = "2018-08-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CopyDataCacheResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Copies a DataCache from one region to another region.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You cannot directly use a DataCache across regions. You can call this operation to copy a DataCache from one region to another region. This operation is suitable for the following scenarios:</para>
        /// <list type="bullet">
        /// <item><description>If you want to use a DataCache across regions and the DataCache exists in Region A, you can call this operation to quickly copy the DataCache to Region B.</description></item>
        /// <item><description>If you directly pull data from a region outside China to a region inside the Chinese mainland when you create a DataCache, the data may be pulled at a slow speed due to network limits. In this case, you can create a DataCache in a region outside the Chinese mainland but inside China, such as the China (Hong Kong) region, and call this operation to copy the data to the region inside the Chinese mainland.<remarks>
        /// <para>The process of copying a DataCache is equivalent to copying a snapshot. You are charged for the traffic generated during the copy process and the storage of the generated DataCache.</para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CopyDataCacheRequest
        /// </param>
        /// 
        /// <returns>
        /// CopyDataCacheResponse
        /// </returns>
        public CopyDataCacheResponse CopyDataCache(CopyDataCacheRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CopyDataCacheWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Copies a DataCache from one region to another region.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You cannot directly use a DataCache across regions. You can call this operation to copy a DataCache from one region to another region. This operation is suitable for the following scenarios:</para>
        /// <list type="bullet">
        /// <item><description>If you want to use a DataCache across regions and the DataCache exists in Region A, you can call this operation to quickly copy the DataCache to Region B.</description></item>
        /// <item><description>If you directly pull data from a region outside China to a region inside the Chinese mainland when you create a DataCache, the data may be pulled at a slow speed due to network limits. In this case, you can create a DataCache in a region outside the Chinese mainland but inside China, such as the China (Hong Kong) region, and call this operation to copy the data to the region inside the Chinese mainland.<remarks>
        /// <para>The process of copying a DataCache is equivalent to copying a snapshot. You are charged for the traffic generated during the copy process and the storage of the generated DataCache.</para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CopyDataCacheRequest
        /// </param>
        /// 
        /// <returns>
        /// CopyDataCacheResponse
        /// </returns>
        public async Task<CopyDataCacheResponse> CopyDataCacheAsync(CopyDataCacheRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CopyDataCacheWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an elastic container instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>When you call the CreateContainerGroup operation to create an elastic container instance, the system automatically creates a service-linked role named AliyunServiceRoleForECI. You can assume the service-linked role to access relevant cloud services such as Elastic Compute Service (ECS) and Virtual Private Cloud (VPC). For more information, see <a href="https://help.aliyun.com/document_detail/212914.html">Elastic Container Instance service-linked role</a>.
        /// When you create an elastic container instance, you can configure features that are related to instances, images, and storage based on your business requirements. For information about parameters configured for the features and the description of the parameters, see the following documents:
        /// <b>Instances</b>
        /// You can use one of the following methods to create an elastic container instance:</para>
        /// <list type="bullet">
        /// <item><description><a href="https://help.aliyun.com/document_detail/114662.html">Specify the number of vCPUs and memory size to create an elastic container instance</a></description></item>
        /// <item><description><a href="https://help.aliyun.com/document_detail/114664.html">Specify ECS instance types to create an elastic container instance</a>
        /// Both the preceding creation methods support the following features:</description></item>
        /// <item><description><a href="https://help.aliyun.com/document_detail/157759.html">Create a preemptible elastic container instance</a></description></item>
        /// <item><description><a href="https://help.aliyun.com/document_detail/157290.html">Configure multiple zones</a></description></item>
        /// <item><description><a href="https://help.aliyun.com/document_detail/146468.html">Configure multiple specifications</a></description></item>
        /// <item><description><a href="https://help.aliyun.com/document_detail/146608.html">Use tags to manage elastic container instances</a>
        /// <b>Images</b></description></item>
        /// <item><description><a href="https://help.aliyun.com/document_detail/461311.html">Configure a container image</a></description></item>
        /// <item><description><a href="https://help.aliyun.com/document_detail/141281.html">Use the image cache feature to accelerate the creation of an elastic container instance</a></description></item>
        /// <item><description><a href="https://help.aliyun.com/document_detail/194250.html">Specify a Container Registry Enterprise Edition instance</a></description></item>
        /// <item><description><a href="https://help.aliyun.com/document_detail/378059.html">Use self-managed image repositories</a>
        /// <b>Networking</b></description></item>
        /// <item><description><a href="https://help.aliyun.com/document_detail/99146.html">Create and Associate an EIP</a></description></item>
        /// <item><description><a href="https://help.aliyun.com/document_detail/176237.html">Assign a security group</a></description></item>
        /// <item><description><a href="https://help.aliyun.com/document_detail/451282.html">Assign an IPv6 address to an elastic container instance</a></description></item>
        /// <item><description><a href="https://help.aliyun.com/document_detail/190635.html">Configure maximum bandwidth</a>
        /// <b>Storage</b></description></item>
        /// <item><description><a href="https://help.aliyun.com/document_detail/144571.html">Mount a disk volume</a></description></item>
        /// <item><description><a href="https://help.aliyun.com/document_detail/464075.html">Mount a NAS volume</a></description></item>
        /// <item><description><a href="https://help.aliyun.com/document_detail/464076.html">Mount an OSS bucket to an elastic container instance as a volume</a></description></item>
        /// <item><description><a href="https://help.aliyun.com/document_detail/464078.html">Mount an emptyDir volume</a></description></item>
        /// <item><description><a href="https://help.aliyun.com/document_detail/464080.html">Mount a ConfigFile volume</a></description></item>
        /// <item><description><a href="https://help.aliyun.com/document_detail/204066.html">Increase the size of the temporary storage space</a>
        /// <b>Container configuration</b></description></item>
        /// <item><description><a href="https://help.aliyun.com/document_detail/94593.html">Configure startup commands and arguments for a container</a></description></item>
        /// <item><description><a href="https://help.aliyun.com/document_detail/99053.html">Use probes to perform health checks on a container</a></description></item>
        /// <item><description><a href="https://help.aliyun.com/document_detail/141788.html">Obtain metadata by using environment variables</a></description></item>
        /// <item><description><a href="https://help.aliyun.com/document_detail/462313.html">Configure a security context for an elastic container instance or a container</a></description></item>
        /// <item><description><a href="https://help.aliyun.com/document_detail/462768.html">Configure the NTP service</a>
        /// <b>Logging and O\&amp;M</b></description></item>
        /// <item><description><a href="https://help.aliyun.com/document_detail/121973.html">Use environment variables to configure log collection</a></description></item>
        /// <item><description><a href="https://help.aliyun.com/document_detail/167801.html">Save core files to volumes</a></description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateContainerGroupRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateContainerGroupResponse
        /// </returns>
        public CreateContainerGroupResponse CreateContainerGroupWithOptions(CreateContainerGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AcrRegistryInfo))
            {
                query["AcrRegistryInfo"] = request.AcrRegistryInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ActiveDeadlineSeconds))
            {
                query["ActiveDeadlineSeconds"] = request.ActiveDeadlineSeconds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoCreateEip))
            {
                query["AutoCreateEip"] = request.AutoCreateEip;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoMatchImageCache))
            {
                query["AutoMatchImageCache"] = request.AutoMatchImageCache;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ComputeCategory))
            {
                query["ComputeCategory"] = request.ComputeCategory;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Container))
            {
                query["Container"] = request.Container;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContainerGroupName))
            {
                query["ContainerGroupName"] = request.ContainerGroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContainerResourceView))
            {
                query["ContainerResourceView"] = request.ContainerResourceView;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CorePattern))
            {
                query["CorePattern"] = request.CorePattern;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cpu))
            {
                query["Cpu"] = request.Cpu;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CpuArchitecture))
            {
                query["CpuArchitecture"] = request.CpuArchitecture;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CpuOptionsCore))
            {
                query["CpuOptionsCore"] = request.CpuOptionsCore;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CpuOptionsNuma))
            {
                query["CpuOptionsNuma"] = request.CpuOptionsNuma;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CpuOptionsThreadsPerCore))
            {
                query["CpuOptionsThreadsPerCore"] = request.CpuOptionsThreadsPerCore;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataCacheBucket))
            {
                query["DataCacheBucket"] = request.DataCacheBucket;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataCacheBurstingEnabled))
            {
                query["DataCacheBurstingEnabled"] = request.DataCacheBurstingEnabled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataCachePL))
            {
                query["DataCachePL"] = request.DataCachePL;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataCacheProvisionedIops))
            {
                query["DataCacheProvisionedIops"] = request.DataCacheProvisionedIops;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DnsPolicy))
            {
                query["DnsPolicy"] = request.DnsPolicy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EgressBandwidth))
            {
                query["EgressBandwidth"] = request.EgressBandwidth;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EipBandwidth))
            {
                query["EipBandwidth"] = request.EipBandwidth;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EipCommonBandwidthPackage))
            {
                query["EipCommonBandwidthPackage"] = request.EipCommonBandwidthPackage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EipISP))
            {
                query["EipISP"] = request.EipISP;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EipInstanceId))
            {
                query["EipInstanceId"] = request.EipInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EphemeralStorage))
            {
                query["EphemeralStorage"] = request.EphemeralStorage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FixedIp))
            {
                query["FixedIp"] = request.FixedIp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FixedIpRetainHour))
            {
                query["FixedIpRetainHour"] = request.FixedIpRetainHour;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GpuDriverVersion))
            {
                query["GpuDriverVersion"] = request.GpuDriverVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HostAliase))
            {
                query["HostAliase"] = request.HostAliase;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HostName))
            {
                query["HostName"] = request.HostName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageAccelerateMode))
            {
                query["ImageAccelerateMode"] = request.ImageAccelerateMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageRegistryCredential))
            {
                query["ImageRegistryCredential"] = request.ImageRegistryCredential;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageSnapshotId))
            {
                query["ImageSnapshotId"] = request.ImageSnapshotId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IngressBandwidth))
            {
                query["IngressBandwidth"] = request.IngressBandwidth;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InitContainer))
            {
                query["InitContainer"] = request.InitContainer;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InsecureRegistry))
            {
                query["InsecureRegistry"] = request.InsecureRegistry;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceType))
            {
                query["InstanceType"] = request.InstanceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ipv6AddressCount))
            {
                query["Ipv6AddressCount"] = request.Ipv6AddressCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ipv6GatewayBandwidth))
            {
                query["Ipv6GatewayBandwidth"] = request.Ipv6GatewayBandwidth;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ipv6GatewayBandwidthEnable))
            {
                query["Ipv6GatewayBandwidthEnable"] = request.Ipv6GatewayBandwidthEnable;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Memory))
            {
                query["Memory"] = request.Memory;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NtpServer))
            {
                query["NtpServer"] = request.NtpServer;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OsType))
            {
                query["OsType"] = request.OsType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OverheadReservationOption))
            {
                query["OverheadReservationOption"] = request.OverheadReservationOption;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PlainHttpRegistry))
            {
                query["PlainHttpRegistry"] = request.PlainHttpRegistry;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PrivateIpAddress))
            {
                query["PrivateIpAddress"] = request.PrivateIpAddress;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RamRoleName))
            {
                query["RamRoleName"] = request.RamRoleName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RestartPolicy))
            {
                query["RestartPolicy"] = request.RestartPolicy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScheduleStrategy))
            {
                query["ScheduleStrategy"] = request.ScheduleStrategy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityGroupId))
            {
                query["SecurityGroupId"] = request.SecurityGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ShareProcessNamespace))
            {
                query["ShareProcessNamespace"] = request.ShareProcessNamespace;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SpotDuration))
            {
                query["SpotDuration"] = request.SpotDuration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SpotPriceLimit))
            {
                query["SpotPriceLimit"] = request.SpotPriceLimit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SpotStrategy))
            {
                query["SpotStrategy"] = request.SpotStrategy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StrictSpot))
            {
                query["StrictSpot"] = request.StrictSpot;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                query["Tag"] = request.Tag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TerminationGracePeriodSeconds))
            {
                query["TerminationGracePeriodSeconds"] = request.TerminationGracePeriodSeconds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VSwitchId))
            {
                query["VSwitchId"] = request.VSwitchId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Volume))
            {
                query["Volume"] = request.Volume;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ZoneId))
            {
                query["ZoneId"] = request.ZoneId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DnsConfig))
            {
                query["DnsConfig"] = request.DnsConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HostSecurityContext))
            {
                query["HostSecurityContext"] = request.HostSecurityContext;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityContext))
            {
                query["SecurityContext"] = request.SecurityContext;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateContainerGroup",
                Version = "2018-08-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateContainerGroupResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an elastic container instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>When you call the CreateContainerGroup operation to create an elastic container instance, the system automatically creates a service-linked role named AliyunServiceRoleForECI. You can assume the service-linked role to access relevant cloud services such as Elastic Compute Service (ECS) and Virtual Private Cloud (VPC). For more information, see <a href="https://help.aliyun.com/document_detail/212914.html">Elastic Container Instance service-linked role</a>.
        /// When you create an elastic container instance, you can configure features that are related to instances, images, and storage based on your business requirements. For information about parameters configured for the features and the description of the parameters, see the following documents:
        /// <b>Instances</b>
        /// You can use one of the following methods to create an elastic container instance:</para>
        /// <list type="bullet">
        /// <item><description><a href="https://help.aliyun.com/document_detail/114662.html">Specify the number of vCPUs and memory size to create an elastic container instance</a></description></item>
        /// <item><description><a href="https://help.aliyun.com/document_detail/114664.html">Specify ECS instance types to create an elastic container instance</a>
        /// Both the preceding creation methods support the following features:</description></item>
        /// <item><description><a href="https://help.aliyun.com/document_detail/157759.html">Create a preemptible elastic container instance</a></description></item>
        /// <item><description><a href="https://help.aliyun.com/document_detail/157290.html">Configure multiple zones</a></description></item>
        /// <item><description><a href="https://help.aliyun.com/document_detail/146468.html">Configure multiple specifications</a></description></item>
        /// <item><description><a href="https://help.aliyun.com/document_detail/146608.html">Use tags to manage elastic container instances</a>
        /// <b>Images</b></description></item>
        /// <item><description><a href="https://help.aliyun.com/document_detail/461311.html">Configure a container image</a></description></item>
        /// <item><description><a href="https://help.aliyun.com/document_detail/141281.html">Use the image cache feature to accelerate the creation of an elastic container instance</a></description></item>
        /// <item><description><a href="https://help.aliyun.com/document_detail/194250.html">Specify a Container Registry Enterprise Edition instance</a></description></item>
        /// <item><description><a href="https://help.aliyun.com/document_detail/378059.html">Use self-managed image repositories</a>
        /// <b>Networking</b></description></item>
        /// <item><description><a href="https://help.aliyun.com/document_detail/99146.html">Create and Associate an EIP</a></description></item>
        /// <item><description><a href="https://help.aliyun.com/document_detail/176237.html">Assign a security group</a></description></item>
        /// <item><description><a href="https://help.aliyun.com/document_detail/451282.html">Assign an IPv6 address to an elastic container instance</a></description></item>
        /// <item><description><a href="https://help.aliyun.com/document_detail/190635.html">Configure maximum bandwidth</a>
        /// <b>Storage</b></description></item>
        /// <item><description><a href="https://help.aliyun.com/document_detail/144571.html">Mount a disk volume</a></description></item>
        /// <item><description><a href="https://help.aliyun.com/document_detail/464075.html">Mount a NAS volume</a></description></item>
        /// <item><description><a href="https://help.aliyun.com/document_detail/464076.html">Mount an OSS bucket to an elastic container instance as a volume</a></description></item>
        /// <item><description><a href="https://help.aliyun.com/document_detail/464078.html">Mount an emptyDir volume</a></description></item>
        /// <item><description><a href="https://help.aliyun.com/document_detail/464080.html">Mount a ConfigFile volume</a></description></item>
        /// <item><description><a href="https://help.aliyun.com/document_detail/204066.html">Increase the size of the temporary storage space</a>
        /// <b>Container configuration</b></description></item>
        /// <item><description><a href="https://help.aliyun.com/document_detail/94593.html">Configure startup commands and arguments for a container</a></description></item>
        /// <item><description><a href="https://help.aliyun.com/document_detail/99053.html">Use probes to perform health checks on a container</a></description></item>
        /// <item><description><a href="https://help.aliyun.com/document_detail/141788.html">Obtain metadata by using environment variables</a></description></item>
        /// <item><description><a href="https://help.aliyun.com/document_detail/462313.html">Configure a security context for an elastic container instance or a container</a></description></item>
        /// <item><description><a href="https://help.aliyun.com/document_detail/462768.html">Configure the NTP service</a>
        /// <b>Logging and O\&amp;M</b></description></item>
        /// <item><description><a href="https://help.aliyun.com/document_detail/121973.html">Use environment variables to configure log collection</a></description></item>
        /// <item><description><a href="https://help.aliyun.com/document_detail/167801.html">Save core files to volumes</a></description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateContainerGroupRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateContainerGroupResponse
        /// </returns>
        public async Task<CreateContainerGroupResponse> CreateContainerGroupWithOptionsAsync(CreateContainerGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AcrRegistryInfo))
            {
                query["AcrRegistryInfo"] = request.AcrRegistryInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ActiveDeadlineSeconds))
            {
                query["ActiveDeadlineSeconds"] = request.ActiveDeadlineSeconds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoCreateEip))
            {
                query["AutoCreateEip"] = request.AutoCreateEip;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoMatchImageCache))
            {
                query["AutoMatchImageCache"] = request.AutoMatchImageCache;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ComputeCategory))
            {
                query["ComputeCategory"] = request.ComputeCategory;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Container))
            {
                query["Container"] = request.Container;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContainerGroupName))
            {
                query["ContainerGroupName"] = request.ContainerGroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContainerResourceView))
            {
                query["ContainerResourceView"] = request.ContainerResourceView;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CorePattern))
            {
                query["CorePattern"] = request.CorePattern;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cpu))
            {
                query["Cpu"] = request.Cpu;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CpuArchitecture))
            {
                query["CpuArchitecture"] = request.CpuArchitecture;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CpuOptionsCore))
            {
                query["CpuOptionsCore"] = request.CpuOptionsCore;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CpuOptionsNuma))
            {
                query["CpuOptionsNuma"] = request.CpuOptionsNuma;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CpuOptionsThreadsPerCore))
            {
                query["CpuOptionsThreadsPerCore"] = request.CpuOptionsThreadsPerCore;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataCacheBucket))
            {
                query["DataCacheBucket"] = request.DataCacheBucket;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataCacheBurstingEnabled))
            {
                query["DataCacheBurstingEnabled"] = request.DataCacheBurstingEnabled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataCachePL))
            {
                query["DataCachePL"] = request.DataCachePL;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataCacheProvisionedIops))
            {
                query["DataCacheProvisionedIops"] = request.DataCacheProvisionedIops;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DnsPolicy))
            {
                query["DnsPolicy"] = request.DnsPolicy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DryRun))
            {
                query["DryRun"] = request.DryRun;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EgressBandwidth))
            {
                query["EgressBandwidth"] = request.EgressBandwidth;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EipBandwidth))
            {
                query["EipBandwidth"] = request.EipBandwidth;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EipCommonBandwidthPackage))
            {
                query["EipCommonBandwidthPackage"] = request.EipCommonBandwidthPackage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EipISP))
            {
                query["EipISP"] = request.EipISP;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EipInstanceId))
            {
                query["EipInstanceId"] = request.EipInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EphemeralStorage))
            {
                query["EphemeralStorage"] = request.EphemeralStorage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FixedIp))
            {
                query["FixedIp"] = request.FixedIp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FixedIpRetainHour))
            {
                query["FixedIpRetainHour"] = request.FixedIpRetainHour;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GpuDriverVersion))
            {
                query["GpuDriverVersion"] = request.GpuDriverVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HostAliase))
            {
                query["HostAliase"] = request.HostAliase;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HostName))
            {
                query["HostName"] = request.HostName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageAccelerateMode))
            {
                query["ImageAccelerateMode"] = request.ImageAccelerateMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageRegistryCredential))
            {
                query["ImageRegistryCredential"] = request.ImageRegistryCredential;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageSnapshotId))
            {
                query["ImageSnapshotId"] = request.ImageSnapshotId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IngressBandwidth))
            {
                query["IngressBandwidth"] = request.IngressBandwidth;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InitContainer))
            {
                query["InitContainer"] = request.InitContainer;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InsecureRegistry))
            {
                query["InsecureRegistry"] = request.InsecureRegistry;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceType))
            {
                query["InstanceType"] = request.InstanceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ipv6AddressCount))
            {
                query["Ipv6AddressCount"] = request.Ipv6AddressCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ipv6GatewayBandwidth))
            {
                query["Ipv6GatewayBandwidth"] = request.Ipv6GatewayBandwidth;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ipv6GatewayBandwidthEnable))
            {
                query["Ipv6GatewayBandwidthEnable"] = request.Ipv6GatewayBandwidthEnable;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Memory))
            {
                query["Memory"] = request.Memory;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NtpServer))
            {
                query["NtpServer"] = request.NtpServer;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OsType))
            {
                query["OsType"] = request.OsType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OverheadReservationOption))
            {
                query["OverheadReservationOption"] = request.OverheadReservationOption;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PlainHttpRegistry))
            {
                query["PlainHttpRegistry"] = request.PlainHttpRegistry;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PrivateIpAddress))
            {
                query["PrivateIpAddress"] = request.PrivateIpAddress;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RamRoleName))
            {
                query["RamRoleName"] = request.RamRoleName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RestartPolicy))
            {
                query["RestartPolicy"] = request.RestartPolicy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScheduleStrategy))
            {
                query["ScheduleStrategy"] = request.ScheduleStrategy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityGroupId))
            {
                query["SecurityGroupId"] = request.SecurityGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ShareProcessNamespace))
            {
                query["ShareProcessNamespace"] = request.ShareProcessNamespace;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SpotDuration))
            {
                query["SpotDuration"] = request.SpotDuration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SpotPriceLimit))
            {
                query["SpotPriceLimit"] = request.SpotPriceLimit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SpotStrategy))
            {
                query["SpotStrategy"] = request.SpotStrategy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StrictSpot))
            {
                query["StrictSpot"] = request.StrictSpot;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                query["Tag"] = request.Tag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TerminationGracePeriodSeconds))
            {
                query["TerminationGracePeriodSeconds"] = request.TerminationGracePeriodSeconds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VSwitchId))
            {
                query["VSwitchId"] = request.VSwitchId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Volume))
            {
                query["Volume"] = request.Volume;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ZoneId))
            {
                query["ZoneId"] = request.ZoneId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DnsConfig))
            {
                query["DnsConfig"] = request.DnsConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HostSecurityContext))
            {
                query["HostSecurityContext"] = request.HostSecurityContext;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityContext))
            {
                query["SecurityContext"] = request.SecurityContext;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateContainerGroup",
                Version = "2018-08-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateContainerGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an elastic container instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>When you call the CreateContainerGroup operation to create an elastic container instance, the system automatically creates a service-linked role named AliyunServiceRoleForECI. You can assume the service-linked role to access relevant cloud services such as Elastic Compute Service (ECS) and Virtual Private Cloud (VPC). For more information, see <a href="https://help.aliyun.com/document_detail/212914.html">Elastic Container Instance service-linked role</a>.
        /// When you create an elastic container instance, you can configure features that are related to instances, images, and storage based on your business requirements. For information about parameters configured for the features and the description of the parameters, see the following documents:
        /// <b>Instances</b>
        /// You can use one of the following methods to create an elastic container instance:</para>
        /// <list type="bullet">
        /// <item><description><a href="https://help.aliyun.com/document_detail/114662.html">Specify the number of vCPUs and memory size to create an elastic container instance</a></description></item>
        /// <item><description><a href="https://help.aliyun.com/document_detail/114664.html">Specify ECS instance types to create an elastic container instance</a>
        /// Both the preceding creation methods support the following features:</description></item>
        /// <item><description><a href="https://help.aliyun.com/document_detail/157759.html">Create a preemptible elastic container instance</a></description></item>
        /// <item><description><a href="https://help.aliyun.com/document_detail/157290.html">Configure multiple zones</a></description></item>
        /// <item><description><a href="https://help.aliyun.com/document_detail/146468.html">Configure multiple specifications</a></description></item>
        /// <item><description><a href="https://help.aliyun.com/document_detail/146608.html">Use tags to manage elastic container instances</a>
        /// <b>Images</b></description></item>
        /// <item><description><a href="https://help.aliyun.com/document_detail/461311.html">Configure a container image</a></description></item>
        /// <item><description><a href="https://help.aliyun.com/document_detail/141281.html">Use the image cache feature to accelerate the creation of an elastic container instance</a></description></item>
        /// <item><description><a href="https://help.aliyun.com/document_detail/194250.html">Specify a Container Registry Enterprise Edition instance</a></description></item>
        /// <item><description><a href="https://help.aliyun.com/document_detail/378059.html">Use self-managed image repositories</a>
        /// <b>Networking</b></description></item>
        /// <item><description><a href="https://help.aliyun.com/document_detail/99146.html">Create and Associate an EIP</a></description></item>
        /// <item><description><a href="https://help.aliyun.com/document_detail/176237.html">Assign a security group</a></description></item>
        /// <item><description><a href="https://help.aliyun.com/document_detail/451282.html">Assign an IPv6 address to an elastic container instance</a></description></item>
        /// <item><description><a href="https://help.aliyun.com/document_detail/190635.html">Configure maximum bandwidth</a>
        /// <b>Storage</b></description></item>
        /// <item><description><a href="https://help.aliyun.com/document_detail/144571.html">Mount a disk volume</a></description></item>
        /// <item><description><a href="https://help.aliyun.com/document_detail/464075.html">Mount a NAS volume</a></description></item>
        /// <item><description><a href="https://help.aliyun.com/document_detail/464076.html">Mount an OSS bucket to an elastic container instance as a volume</a></description></item>
        /// <item><description><a href="https://help.aliyun.com/document_detail/464078.html">Mount an emptyDir volume</a></description></item>
        /// <item><description><a href="https://help.aliyun.com/document_detail/464080.html">Mount a ConfigFile volume</a></description></item>
        /// <item><description><a href="https://help.aliyun.com/document_detail/204066.html">Increase the size of the temporary storage space</a>
        /// <b>Container configuration</b></description></item>
        /// <item><description><a href="https://help.aliyun.com/document_detail/94593.html">Configure startup commands and arguments for a container</a></description></item>
        /// <item><description><a href="https://help.aliyun.com/document_detail/99053.html">Use probes to perform health checks on a container</a></description></item>
        /// <item><description><a href="https://help.aliyun.com/document_detail/141788.html">Obtain metadata by using environment variables</a></description></item>
        /// <item><description><a href="https://help.aliyun.com/document_detail/462313.html">Configure a security context for an elastic container instance or a container</a></description></item>
        /// <item><description><a href="https://help.aliyun.com/document_detail/462768.html">Configure the NTP service</a>
        /// <b>Logging and O\&amp;M</b></description></item>
        /// <item><description><a href="https://help.aliyun.com/document_detail/121973.html">Use environment variables to configure log collection</a></description></item>
        /// <item><description><a href="https://help.aliyun.com/document_detail/167801.html">Save core files to volumes</a></description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateContainerGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateContainerGroupResponse
        /// </returns>
        public CreateContainerGroupResponse CreateContainerGroup(CreateContainerGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateContainerGroupWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an elastic container instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>When you call the CreateContainerGroup operation to create an elastic container instance, the system automatically creates a service-linked role named AliyunServiceRoleForECI. You can assume the service-linked role to access relevant cloud services such as Elastic Compute Service (ECS) and Virtual Private Cloud (VPC). For more information, see <a href="https://help.aliyun.com/document_detail/212914.html">Elastic Container Instance service-linked role</a>.
        /// When you create an elastic container instance, you can configure features that are related to instances, images, and storage based on your business requirements. For information about parameters configured for the features and the description of the parameters, see the following documents:
        /// <b>Instances</b>
        /// You can use one of the following methods to create an elastic container instance:</para>
        /// <list type="bullet">
        /// <item><description><a href="https://help.aliyun.com/document_detail/114662.html">Specify the number of vCPUs and memory size to create an elastic container instance</a></description></item>
        /// <item><description><a href="https://help.aliyun.com/document_detail/114664.html">Specify ECS instance types to create an elastic container instance</a>
        /// Both the preceding creation methods support the following features:</description></item>
        /// <item><description><a href="https://help.aliyun.com/document_detail/157759.html">Create a preemptible elastic container instance</a></description></item>
        /// <item><description><a href="https://help.aliyun.com/document_detail/157290.html">Configure multiple zones</a></description></item>
        /// <item><description><a href="https://help.aliyun.com/document_detail/146468.html">Configure multiple specifications</a></description></item>
        /// <item><description><a href="https://help.aliyun.com/document_detail/146608.html">Use tags to manage elastic container instances</a>
        /// <b>Images</b></description></item>
        /// <item><description><a href="https://help.aliyun.com/document_detail/461311.html">Configure a container image</a></description></item>
        /// <item><description><a href="https://help.aliyun.com/document_detail/141281.html">Use the image cache feature to accelerate the creation of an elastic container instance</a></description></item>
        /// <item><description><a href="https://help.aliyun.com/document_detail/194250.html">Specify a Container Registry Enterprise Edition instance</a></description></item>
        /// <item><description><a href="https://help.aliyun.com/document_detail/378059.html">Use self-managed image repositories</a>
        /// <b>Networking</b></description></item>
        /// <item><description><a href="https://help.aliyun.com/document_detail/99146.html">Create and Associate an EIP</a></description></item>
        /// <item><description><a href="https://help.aliyun.com/document_detail/176237.html">Assign a security group</a></description></item>
        /// <item><description><a href="https://help.aliyun.com/document_detail/451282.html">Assign an IPv6 address to an elastic container instance</a></description></item>
        /// <item><description><a href="https://help.aliyun.com/document_detail/190635.html">Configure maximum bandwidth</a>
        /// <b>Storage</b></description></item>
        /// <item><description><a href="https://help.aliyun.com/document_detail/144571.html">Mount a disk volume</a></description></item>
        /// <item><description><a href="https://help.aliyun.com/document_detail/464075.html">Mount a NAS volume</a></description></item>
        /// <item><description><a href="https://help.aliyun.com/document_detail/464076.html">Mount an OSS bucket to an elastic container instance as a volume</a></description></item>
        /// <item><description><a href="https://help.aliyun.com/document_detail/464078.html">Mount an emptyDir volume</a></description></item>
        /// <item><description><a href="https://help.aliyun.com/document_detail/464080.html">Mount a ConfigFile volume</a></description></item>
        /// <item><description><a href="https://help.aliyun.com/document_detail/204066.html">Increase the size of the temporary storage space</a>
        /// <b>Container configuration</b></description></item>
        /// <item><description><a href="https://help.aliyun.com/document_detail/94593.html">Configure startup commands and arguments for a container</a></description></item>
        /// <item><description><a href="https://help.aliyun.com/document_detail/99053.html">Use probes to perform health checks on a container</a></description></item>
        /// <item><description><a href="https://help.aliyun.com/document_detail/141788.html">Obtain metadata by using environment variables</a></description></item>
        /// <item><description><a href="https://help.aliyun.com/document_detail/462313.html">Configure a security context for an elastic container instance or a container</a></description></item>
        /// <item><description><a href="https://help.aliyun.com/document_detail/462768.html">Configure the NTP service</a>
        /// <b>Logging and O\&amp;M</b></description></item>
        /// <item><description><a href="https://help.aliyun.com/document_detail/121973.html">Use environment variables to configure log collection</a></description></item>
        /// <item><description><a href="https://help.aliyun.com/document_detail/167801.html">Save core files to volumes</a></description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateContainerGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateContainerGroupResponse
        /// </returns>
        public async Task<CreateContainerGroupResponse> CreateContainerGroupAsync(CreateContainerGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateContainerGroupWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a DataCache.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  You are charged for the creation of image caches. We recommend that you learn the relevant billing information in advance. For more information, see <a href="https://help.aliyun.com/document_detail/2503093.html">DataCaches</a>.</para>
        /// <list type="bullet">
        /// <item><description>Before you create an image cache, you must evaluate the size of the data to be cached. If the size of the data exceeds the specified cache size, the image cache fails to be created.</description></item>
        /// <item><description>When a data cache is being created, the system automatically creates a temporary elastic container instance (ECI) and an enhanced SSD (ESSD) for the data cache. During the creation, do not delete the ECI and ESSD. Otherwise, the data cache fails to be created.</description></item>
        /// <item><description>When a data cache is being created, a snapshot is generated for the data cache. Do not delete the snapshot. Otherwise, the data cache becomes invalid.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateDataCacheRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateDataCacheResponse
        /// </returns>
        public CreateDataCacheResponse CreateDataCacheWithOptions(CreateDataCacheRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Bucket))
            {
                query["Bucket"] = request.Bucket;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSource))
            {
                query["DataSource"] = request.DataSource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EipCreateParam))
            {
                query["EipCreateParam"] = request.EipCreateParam;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EipInstanceId))
            {
                query["EipInstanceId"] = request.EipInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Path))
            {
                query["Path"] = request.Path;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RetentionDays))
            {
                query["RetentionDays"] = request.RetentionDays;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityGroupId))
            {
                query["SecurityGroupId"] = request.SecurityGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Size))
            {
                query["Size"] = request.Size;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                query["Tag"] = request.Tag;
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
                Action = "CreateDataCache",
                Version = "2018-08-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateDataCacheResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a DataCache.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  You are charged for the creation of image caches. We recommend that you learn the relevant billing information in advance. For more information, see <a href="https://help.aliyun.com/document_detail/2503093.html">DataCaches</a>.</para>
        /// <list type="bullet">
        /// <item><description>Before you create an image cache, you must evaluate the size of the data to be cached. If the size of the data exceeds the specified cache size, the image cache fails to be created.</description></item>
        /// <item><description>When a data cache is being created, the system automatically creates a temporary elastic container instance (ECI) and an enhanced SSD (ESSD) for the data cache. During the creation, do not delete the ECI and ESSD. Otherwise, the data cache fails to be created.</description></item>
        /// <item><description>When a data cache is being created, a snapshot is generated for the data cache. Do not delete the snapshot. Otherwise, the data cache becomes invalid.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateDataCacheRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateDataCacheResponse
        /// </returns>
        public async Task<CreateDataCacheResponse> CreateDataCacheWithOptionsAsync(CreateDataCacheRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Bucket))
            {
                query["Bucket"] = request.Bucket;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSource))
            {
                query["DataSource"] = request.DataSource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EipCreateParam))
            {
                query["EipCreateParam"] = request.EipCreateParam;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EipInstanceId))
            {
                query["EipInstanceId"] = request.EipInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Path))
            {
                query["Path"] = request.Path;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RetentionDays))
            {
                query["RetentionDays"] = request.RetentionDays;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityGroupId))
            {
                query["SecurityGroupId"] = request.SecurityGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Size))
            {
                query["Size"] = request.Size;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                query["Tag"] = request.Tag;
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
                Action = "CreateDataCache",
                Version = "2018-08-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateDataCacheResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a DataCache.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  You are charged for the creation of image caches. We recommend that you learn the relevant billing information in advance. For more information, see <a href="https://help.aliyun.com/document_detail/2503093.html">DataCaches</a>.</para>
        /// <list type="bullet">
        /// <item><description>Before you create an image cache, you must evaluate the size of the data to be cached. If the size of the data exceeds the specified cache size, the image cache fails to be created.</description></item>
        /// <item><description>When a data cache is being created, the system automatically creates a temporary elastic container instance (ECI) and an enhanced SSD (ESSD) for the data cache. During the creation, do not delete the ECI and ESSD. Otherwise, the data cache fails to be created.</description></item>
        /// <item><description>When a data cache is being created, a snapshot is generated for the data cache. Do not delete the snapshot. Otherwise, the data cache becomes invalid.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateDataCacheRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateDataCacheResponse
        /// </returns>
        public CreateDataCacheResponse CreateDataCache(CreateDataCacheRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateDataCacheWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a DataCache.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  You are charged for the creation of image caches. We recommend that you learn the relevant billing information in advance. For more information, see <a href="https://help.aliyun.com/document_detail/2503093.html">DataCaches</a>.</para>
        /// <list type="bullet">
        /// <item><description>Before you create an image cache, you must evaluate the size of the data to be cached. If the size of the data exceeds the specified cache size, the image cache fails to be created.</description></item>
        /// <item><description>When a data cache is being created, the system automatically creates a temporary elastic container instance (ECI) and an enhanced SSD (ESSD) for the data cache. During the creation, do not delete the ECI and ESSD. Otherwise, the data cache fails to be created.</description></item>
        /// <item><description>When a data cache is being created, a snapshot is generated for the data cache. Do not delete the snapshot. Otherwise, the data cache becomes invalid.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateDataCacheRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateDataCacheResponse
        /// </returns>
        public async Task<CreateDataCacheResponse> CreateDataCacheAsync(CreateDataCacheRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateDataCacheWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an image cache. The image cache can accelerate image pulling and reduce the instance startup time when you create an elastic container instance later.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  <b>Precautions</b>
        ///     *   You are charged for creation of image caches. We recommend that you learn the relevant billing information in advance. For more information about billing of image caches, see <a href="https://help.aliyun.com/document_detail/447682.html">Image caches</a>.
        ///     *   Before you create an image cache, you must estimate the total size of the images that you want to cache. If the total size of the images exceeds the specified cache size, the image cache cannot be created.
        ///     *   When an image cache is being created, the system creates an intermediate elastic container instance and an intermediate enhanced SSD (ESSD) at performance level 1 (PL1). Do not delete the intermediate instance and the ESSD while the image cache is being created. If you delete the intermediate instance or the ESSD, the image cache cannot be created.
        ///     *   A temporary local snapshot and a specific number of regular snapshots are generated during the creation of the image cache. Do not delete these snapshots. If you delete these snapshots, the image cache becomes invalid.
        ///     *   If you use SDKs, SDK for Java 1.0.10 or later and SDK for Python 1.0.7 or later are supported.</para>
        /// <list type="bullet">
        /// <item><description><b>Usage notes</b><list type="bullet">
        /// <item><description>For images that are created based on Container Registry Enterprise Edition instances and use custom domain names, if you want to configure password-free access to the image caches, you must use AcrRegistryInfo-related parameters to specify Container Registry instances. When you configure AcrRegistryInfo-related parameters, you must set the AcrRegistryInfo.N.InstanceId parameter.</description></item>
        /// <item><description>If the image cache that you created will be used to create more than 1,000 elastic container instances at a time, we recommend that you use the StandardCopyCount and FlashCopyCount parameters to create multiple temporary local snapshots and regular snapshots of the image. The multiple snapshots are billed based on incremental data. If no incremental data exists on the multiple snapshots, you are not charged for the multiple snapshots.<remarks>
        /// <para> When you call the CreateImageCache operation to create an image cache, the system automatically creates a service-linked role named AliyunServiceRoleForECI. The role is used to access other Alibaba Cloud services such as Elastic Compute Service (ECS) and Virtual Private Cloud (VPC). For more information, see <a href="https://help.aliyun.com/document_detail/212914.html">Elastic Container Instance service-linked role</a>.</para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateImageCacheRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateImageCacheResponse
        /// </returns>
        public CreateImageCacheResponse CreateImageCacheWithOptions(CreateImageCacheRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AcrRegistryInfo))
            {
                query["AcrRegistryInfo"] = request.AcrRegistryInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Annotations))
            {
                query["Annotations"] = request.Annotations;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoMatchImageCache))
            {
                query["AutoMatchImageCache"] = request.AutoMatchImageCache;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EipInstanceId))
            {
                query["EipInstanceId"] = request.EipInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EliminationStrategy))
            {
                query["EliminationStrategy"] = request.EliminationStrategy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Flash))
            {
                query["Flash"] = request.Flash;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FlashCopyCount))
            {
                query["FlashCopyCount"] = request.FlashCopyCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Image))
            {
                query["Image"] = request.Image;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageCacheName))
            {
                query["ImageCacheName"] = request.ImageCacheName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageCacheSize))
            {
                query["ImageCacheSize"] = request.ImageCacheSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageRegistryCredential))
            {
                query["ImageRegistryCredential"] = request.ImageRegistryCredential;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InsecureRegistry))
            {
                query["InsecureRegistry"] = request.InsecureRegistry;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OsType))
            {
                query["OsType"] = request.OsType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PlainHttpRegistry))
            {
                query["PlainHttpRegistry"] = request.PlainHttpRegistry;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RetentionDays))
            {
                query["RetentionDays"] = request.RetentionDays;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityGroupId))
            {
                query["SecurityGroupId"] = request.SecurityGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StandardCopyCount))
            {
                query["StandardCopyCount"] = request.StandardCopyCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                query["Tag"] = request.Tag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VSwitchId))
            {
                query["VSwitchId"] = request.VSwitchId;
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
                Action = "CreateImageCache",
                Version = "2018-08-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateImageCacheResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an image cache. The image cache can accelerate image pulling and reduce the instance startup time when you create an elastic container instance later.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  <b>Precautions</b>
        ///     *   You are charged for creation of image caches. We recommend that you learn the relevant billing information in advance. For more information about billing of image caches, see <a href="https://help.aliyun.com/document_detail/447682.html">Image caches</a>.
        ///     *   Before you create an image cache, you must estimate the total size of the images that you want to cache. If the total size of the images exceeds the specified cache size, the image cache cannot be created.
        ///     *   When an image cache is being created, the system creates an intermediate elastic container instance and an intermediate enhanced SSD (ESSD) at performance level 1 (PL1). Do not delete the intermediate instance and the ESSD while the image cache is being created. If you delete the intermediate instance or the ESSD, the image cache cannot be created.
        ///     *   A temporary local snapshot and a specific number of regular snapshots are generated during the creation of the image cache. Do not delete these snapshots. If you delete these snapshots, the image cache becomes invalid.
        ///     *   If you use SDKs, SDK for Java 1.0.10 or later and SDK for Python 1.0.7 or later are supported.</para>
        /// <list type="bullet">
        /// <item><description><b>Usage notes</b><list type="bullet">
        /// <item><description>For images that are created based on Container Registry Enterprise Edition instances and use custom domain names, if you want to configure password-free access to the image caches, you must use AcrRegistryInfo-related parameters to specify Container Registry instances. When you configure AcrRegistryInfo-related parameters, you must set the AcrRegistryInfo.N.InstanceId parameter.</description></item>
        /// <item><description>If the image cache that you created will be used to create more than 1,000 elastic container instances at a time, we recommend that you use the StandardCopyCount and FlashCopyCount parameters to create multiple temporary local snapshots and regular snapshots of the image. The multiple snapshots are billed based on incremental data. If no incremental data exists on the multiple snapshots, you are not charged for the multiple snapshots.<remarks>
        /// <para> When you call the CreateImageCache operation to create an image cache, the system automatically creates a service-linked role named AliyunServiceRoleForECI. The role is used to access other Alibaba Cloud services such as Elastic Compute Service (ECS) and Virtual Private Cloud (VPC). For more information, see <a href="https://help.aliyun.com/document_detail/212914.html">Elastic Container Instance service-linked role</a>.</para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateImageCacheRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateImageCacheResponse
        /// </returns>
        public async Task<CreateImageCacheResponse> CreateImageCacheWithOptionsAsync(CreateImageCacheRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AcrRegistryInfo))
            {
                query["AcrRegistryInfo"] = request.AcrRegistryInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Annotations))
            {
                query["Annotations"] = request.Annotations;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoMatchImageCache))
            {
                query["AutoMatchImageCache"] = request.AutoMatchImageCache;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EipInstanceId))
            {
                query["EipInstanceId"] = request.EipInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EliminationStrategy))
            {
                query["EliminationStrategy"] = request.EliminationStrategy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Flash))
            {
                query["Flash"] = request.Flash;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FlashCopyCount))
            {
                query["FlashCopyCount"] = request.FlashCopyCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Image))
            {
                query["Image"] = request.Image;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageCacheName))
            {
                query["ImageCacheName"] = request.ImageCacheName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageCacheSize))
            {
                query["ImageCacheSize"] = request.ImageCacheSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageRegistryCredential))
            {
                query["ImageRegistryCredential"] = request.ImageRegistryCredential;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InsecureRegistry))
            {
                query["InsecureRegistry"] = request.InsecureRegistry;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OsType))
            {
                query["OsType"] = request.OsType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PlainHttpRegistry))
            {
                query["PlainHttpRegistry"] = request.PlainHttpRegistry;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RetentionDays))
            {
                query["RetentionDays"] = request.RetentionDays;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityGroupId))
            {
                query["SecurityGroupId"] = request.SecurityGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StandardCopyCount))
            {
                query["StandardCopyCount"] = request.StandardCopyCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                query["Tag"] = request.Tag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VSwitchId))
            {
                query["VSwitchId"] = request.VSwitchId;
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
                Action = "CreateImageCache",
                Version = "2018-08-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateImageCacheResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an image cache. The image cache can accelerate image pulling and reduce the instance startup time when you create an elastic container instance later.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  <b>Precautions</b>
        ///     *   You are charged for creation of image caches. We recommend that you learn the relevant billing information in advance. For more information about billing of image caches, see <a href="https://help.aliyun.com/document_detail/447682.html">Image caches</a>.
        ///     *   Before you create an image cache, you must estimate the total size of the images that you want to cache. If the total size of the images exceeds the specified cache size, the image cache cannot be created.
        ///     *   When an image cache is being created, the system creates an intermediate elastic container instance and an intermediate enhanced SSD (ESSD) at performance level 1 (PL1). Do not delete the intermediate instance and the ESSD while the image cache is being created. If you delete the intermediate instance or the ESSD, the image cache cannot be created.
        ///     *   A temporary local snapshot and a specific number of regular snapshots are generated during the creation of the image cache. Do not delete these snapshots. If you delete these snapshots, the image cache becomes invalid.
        ///     *   If you use SDKs, SDK for Java 1.0.10 or later and SDK for Python 1.0.7 or later are supported.</para>
        /// <list type="bullet">
        /// <item><description><b>Usage notes</b><list type="bullet">
        /// <item><description>For images that are created based on Container Registry Enterprise Edition instances and use custom domain names, if you want to configure password-free access to the image caches, you must use AcrRegistryInfo-related parameters to specify Container Registry instances. When you configure AcrRegistryInfo-related parameters, you must set the AcrRegistryInfo.N.InstanceId parameter.</description></item>
        /// <item><description>If the image cache that you created will be used to create more than 1,000 elastic container instances at a time, we recommend that you use the StandardCopyCount and FlashCopyCount parameters to create multiple temporary local snapshots and regular snapshots of the image. The multiple snapshots are billed based on incremental data. If no incremental data exists on the multiple snapshots, you are not charged for the multiple snapshots.<remarks>
        /// <para> When you call the CreateImageCache operation to create an image cache, the system automatically creates a service-linked role named AliyunServiceRoleForECI. The role is used to access other Alibaba Cloud services such as Elastic Compute Service (ECS) and Virtual Private Cloud (VPC). For more information, see <a href="https://help.aliyun.com/document_detail/212914.html">Elastic Container Instance service-linked role</a>.</para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateImageCacheRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateImageCacheResponse
        /// </returns>
        public CreateImageCacheResponse CreateImageCache(CreateImageCacheRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateImageCacheWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an image cache. The image cache can accelerate image pulling and reduce the instance startup time when you create an elastic container instance later.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  <b>Precautions</b>
        ///     *   You are charged for creation of image caches. We recommend that you learn the relevant billing information in advance. For more information about billing of image caches, see <a href="https://help.aliyun.com/document_detail/447682.html">Image caches</a>.
        ///     *   Before you create an image cache, you must estimate the total size of the images that you want to cache. If the total size of the images exceeds the specified cache size, the image cache cannot be created.
        ///     *   When an image cache is being created, the system creates an intermediate elastic container instance and an intermediate enhanced SSD (ESSD) at performance level 1 (PL1). Do not delete the intermediate instance and the ESSD while the image cache is being created. If you delete the intermediate instance or the ESSD, the image cache cannot be created.
        ///     *   A temporary local snapshot and a specific number of regular snapshots are generated during the creation of the image cache. Do not delete these snapshots. If you delete these snapshots, the image cache becomes invalid.
        ///     *   If you use SDKs, SDK for Java 1.0.10 or later and SDK for Python 1.0.7 or later are supported.</para>
        /// <list type="bullet">
        /// <item><description><b>Usage notes</b><list type="bullet">
        /// <item><description>For images that are created based on Container Registry Enterprise Edition instances and use custom domain names, if you want to configure password-free access to the image caches, you must use AcrRegistryInfo-related parameters to specify Container Registry instances. When you configure AcrRegistryInfo-related parameters, you must set the AcrRegistryInfo.N.InstanceId parameter.</description></item>
        /// <item><description>If the image cache that you created will be used to create more than 1,000 elastic container instances at a time, we recommend that you use the StandardCopyCount and FlashCopyCount parameters to create multiple temporary local snapshots and regular snapshots of the image. The multiple snapshots are billed based on incremental data. If no incremental data exists on the multiple snapshots, you are not charged for the multiple snapshots.<remarks>
        /// <para> When you call the CreateImageCache operation to create an image cache, the system automatically creates a service-linked role named AliyunServiceRoleForECI. The role is used to access other Alibaba Cloud services such as Elastic Compute Service (ECS) and Virtual Private Cloud (VPC). For more information, see <a href="https://help.aliyun.com/document_detail/212914.html">Elastic Container Instance service-linked role</a>.</para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateImageCacheRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateImageCacheResponse
        /// </returns>
        public async Task<CreateImageCacheResponse> CreateImageCacheAsync(CreateImageCacheRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateImageCacheWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an O&amp;M task.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>O&amp;M tasks are classified into:</para>
        /// <list type="bullet">
        /// <item><description>coredump: After you enable coredump, the system generates a core dump file when a container unexpectedly stops. You can use the core dump file to analyze the exception and find out the cause of the problem. For more information, see <a href="https://help.aliyun.com/document_detail/167801.html">Enable coredump</a>.</description></item>
        /// <item><description>tcpdump: After you enable tcpdump, the system captures network packets when a container unexpectedly stops. You can analyze the packets and locate network problems. For more information, see Enable <a href="https://help.aliyun.com/document_detail/429749.html">tcpdump</a>.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateInstanceOpsTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateInstanceOpsTaskResponse
        /// </returns>
        public CreateInstanceOpsTaskResponse CreateInstanceOpsTaskWithOptions(CreateInstanceOpsTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContainerGroupId))
            {
                query["ContainerGroupId"] = request.ContainerGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpsType))
            {
                query["OpsType"] = request.OpsType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpsValue))
            {
                query["OpsValue"] = request.OpsValue;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateInstanceOpsTask",
                Version = "2018-08-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateInstanceOpsTaskResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an O&amp;M task.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>O&amp;M tasks are classified into:</para>
        /// <list type="bullet">
        /// <item><description>coredump: After you enable coredump, the system generates a core dump file when a container unexpectedly stops. You can use the core dump file to analyze the exception and find out the cause of the problem. For more information, see <a href="https://help.aliyun.com/document_detail/167801.html">Enable coredump</a>.</description></item>
        /// <item><description>tcpdump: After you enable tcpdump, the system captures network packets when a container unexpectedly stops. You can analyze the packets and locate network problems. For more information, see Enable <a href="https://help.aliyun.com/document_detail/429749.html">tcpdump</a>.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateInstanceOpsTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateInstanceOpsTaskResponse
        /// </returns>
        public async Task<CreateInstanceOpsTaskResponse> CreateInstanceOpsTaskWithOptionsAsync(CreateInstanceOpsTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContainerGroupId))
            {
                query["ContainerGroupId"] = request.ContainerGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpsType))
            {
                query["OpsType"] = request.OpsType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpsValue))
            {
                query["OpsValue"] = request.OpsValue;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateInstanceOpsTask",
                Version = "2018-08-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateInstanceOpsTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an O&amp;M task.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>O&amp;M tasks are classified into:</para>
        /// <list type="bullet">
        /// <item><description>coredump: After you enable coredump, the system generates a core dump file when a container unexpectedly stops. You can use the core dump file to analyze the exception and find out the cause of the problem. For more information, see <a href="https://help.aliyun.com/document_detail/167801.html">Enable coredump</a>.</description></item>
        /// <item><description>tcpdump: After you enable tcpdump, the system captures network packets when a container unexpectedly stops. You can analyze the packets and locate network problems. For more information, see Enable <a href="https://help.aliyun.com/document_detail/429749.html">tcpdump</a>.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateInstanceOpsTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateInstanceOpsTaskResponse
        /// </returns>
        public CreateInstanceOpsTaskResponse CreateInstanceOpsTask(CreateInstanceOpsTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateInstanceOpsTaskWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an O&amp;M task.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>O&amp;M tasks are classified into:</para>
        /// <list type="bullet">
        /// <item><description>coredump: After you enable coredump, the system generates a core dump file when a container unexpectedly stops. You can use the core dump file to analyze the exception and find out the cause of the problem. For more information, see <a href="https://help.aliyun.com/document_detail/167801.html">Enable coredump</a>.</description></item>
        /// <item><description>tcpdump: After you enable tcpdump, the system captures network packets when a container unexpectedly stops. You can analyze the packets and locate network problems. For more information, see Enable <a href="https://help.aliyun.com/document_detail/429749.html">tcpdump</a>.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateInstanceOpsTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateInstanceOpsTaskResponse
        /// </returns>
        public async Task<CreateInstanceOpsTaskResponse> CreateInstanceOpsTaskAsync(CreateInstanceOpsTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateInstanceOpsTaskWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a VNode to connect self-managed Kubernetes clusters to elastic container instances.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  When you call this operation to create a virtual node, the system automatically creates a service-linked role AliyunServiceRoleForECIVnode. This way, you can use the service-linked role to access relevant cloud services such as Elastic Container Instance, Elastic Compute Service (ECS), and Virtual Private Cloud (VPC). For more information, see <a href="https://help.aliyun.com/document_detail/311014.html">Service-linked role for virtual nodes</a>.</para>
        /// <list type="bullet">
        /// <item><description>You are charged for virtual nodes based on number of virtual nodes that you use. Each virtual node has a resident node, which is equivalent to an ECI instance with 2 vCPU cores and 8 GiB memory. You are charged for virtual nodes based on elastic container instances.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateVirtualNodeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateVirtualNodeResponse
        /// </returns>
        public CreateVirtualNodeResponse CreateVirtualNodeWithOptions(CreateVirtualNodeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterDNS))
            {
                query["ClusterDNS"] = request.ClusterDNS;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterDomain))
            {
                query["ClusterDomain"] = request.ClusterDomain;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomResources))
            {
                query["CustomResources"] = request.CustomResources;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EipInstanceId))
            {
                query["EipInstanceId"] = request.EipInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnablePublicNetwork))
            {
                query["EnablePublicNetwork"] = request.EnablePublicNetwork;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KubeConfig))
            {
                query["KubeConfig"] = request.KubeConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityGroupId))
            {
                query["SecurityGroupId"] = request.SecurityGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                query["Tag"] = request.Tag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Taint))
            {
                query["Taint"] = request.Taint;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TlsBootstrapEnabled))
            {
                query["TlsBootstrapEnabled"] = request.TlsBootstrapEnabled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VSwitchId))
            {
                query["VSwitchId"] = request.VSwitchId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VirtualNodeName))
            {
                query["VirtualNodeName"] = request.VirtualNodeName;
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
                Action = "CreateVirtualNode",
                Version = "2018-08-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateVirtualNodeResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a VNode to connect self-managed Kubernetes clusters to elastic container instances.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  When you call this operation to create a virtual node, the system automatically creates a service-linked role AliyunServiceRoleForECIVnode. This way, you can use the service-linked role to access relevant cloud services such as Elastic Container Instance, Elastic Compute Service (ECS), and Virtual Private Cloud (VPC). For more information, see <a href="https://help.aliyun.com/document_detail/311014.html">Service-linked role for virtual nodes</a>.</para>
        /// <list type="bullet">
        /// <item><description>You are charged for virtual nodes based on number of virtual nodes that you use. Each virtual node has a resident node, which is equivalent to an ECI instance with 2 vCPU cores and 8 GiB memory. You are charged for virtual nodes based on elastic container instances.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateVirtualNodeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateVirtualNodeResponse
        /// </returns>
        public async Task<CreateVirtualNodeResponse> CreateVirtualNodeWithOptionsAsync(CreateVirtualNodeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterDNS))
            {
                query["ClusterDNS"] = request.ClusterDNS;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterDomain))
            {
                query["ClusterDomain"] = request.ClusterDomain;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomResources))
            {
                query["CustomResources"] = request.CustomResources;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EipInstanceId))
            {
                query["EipInstanceId"] = request.EipInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnablePublicNetwork))
            {
                query["EnablePublicNetwork"] = request.EnablePublicNetwork;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KubeConfig))
            {
                query["KubeConfig"] = request.KubeConfig;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityGroupId))
            {
                query["SecurityGroupId"] = request.SecurityGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                query["Tag"] = request.Tag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Taint))
            {
                query["Taint"] = request.Taint;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TlsBootstrapEnabled))
            {
                query["TlsBootstrapEnabled"] = request.TlsBootstrapEnabled;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VSwitchId))
            {
                query["VSwitchId"] = request.VSwitchId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VirtualNodeName))
            {
                query["VirtualNodeName"] = request.VirtualNodeName;
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
                Action = "CreateVirtualNode",
                Version = "2018-08-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateVirtualNodeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a VNode to connect self-managed Kubernetes clusters to elastic container instances.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  When you call this operation to create a virtual node, the system automatically creates a service-linked role AliyunServiceRoleForECIVnode. This way, you can use the service-linked role to access relevant cloud services such as Elastic Container Instance, Elastic Compute Service (ECS), and Virtual Private Cloud (VPC). For more information, see <a href="https://help.aliyun.com/document_detail/311014.html">Service-linked role for virtual nodes</a>.</para>
        /// <list type="bullet">
        /// <item><description>You are charged for virtual nodes based on number of virtual nodes that you use. Each virtual node has a resident node, which is equivalent to an ECI instance with 2 vCPU cores and 8 GiB memory. You are charged for virtual nodes based on elastic container instances.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateVirtualNodeRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateVirtualNodeResponse
        /// </returns>
        public CreateVirtualNodeResponse CreateVirtualNode(CreateVirtualNodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateVirtualNodeWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a VNode to connect self-managed Kubernetes clusters to elastic container instances.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  When you call this operation to create a virtual node, the system automatically creates a service-linked role AliyunServiceRoleForECIVnode. This way, you can use the service-linked role to access relevant cloud services such as Elastic Container Instance, Elastic Compute Service (ECS), and Virtual Private Cloud (VPC). For more information, see <a href="https://help.aliyun.com/document_detail/311014.html">Service-linked role for virtual nodes</a>.</para>
        /// <list type="bullet">
        /// <item><description>You are charged for virtual nodes based on number of virtual nodes that you use. Each virtual node has a resident node, which is equivalent to an ECI instance with 2 vCPU cores and 8 GiB memory. You are charged for virtual nodes based on elastic container instances.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateVirtualNodeRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateVirtualNodeResponse
        /// </returns>
        public async Task<CreateVirtualNodeResponse> CreateVirtualNodeAsync(CreateVirtualNodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateVirtualNodeWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a container group.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can delete a container group that you no longer need. Before you delete a container group, make sure that you understand the lifecycle of container groups. For more information, see <a href="https://help.aliyun.com/document_detail/122385.html">Lifecycle of an elastic container instance</a>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteContainerGroupRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteContainerGroupResponse
        /// </returns>
        public DeleteContainerGroupResponse DeleteContainerGroupWithOptions(DeleteContainerGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContainerGroupId))
            {
                query["ContainerGroupId"] = request.ContainerGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Force))
            {
                query["Force"] = request.Force;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteContainerGroup",
                Version = "2018-08-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteContainerGroupResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a container group.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can delete a container group that you no longer need. Before you delete a container group, make sure that you understand the lifecycle of container groups. For more information, see <a href="https://help.aliyun.com/document_detail/122385.html">Lifecycle of an elastic container instance</a>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteContainerGroupRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteContainerGroupResponse
        /// </returns>
        public async Task<DeleteContainerGroupResponse> DeleteContainerGroupWithOptionsAsync(DeleteContainerGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContainerGroupId))
            {
                query["ContainerGroupId"] = request.ContainerGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Force))
            {
                query["Force"] = request.Force;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteContainerGroup",
                Version = "2018-08-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteContainerGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a container group.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can delete a container group that you no longer need. Before you delete a container group, make sure that you understand the lifecycle of container groups. For more information, see <a href="https://help.aliyun.com/document_detail/122385.html">Lifecycle of an elastic container instance</a>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteContainerGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteContainerGroupResponse
        /// </returns>
        public DeleteContainerGroupResponse DeleteContainerGroup(DeleteContainerGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteContainerGroupWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a container group.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can delete a container group that you no longer need. Before you delete a container group, make sure that you understand the lifecycle of container groups. For more information, see <a href="https://help.aliyun.com/document_detail/122385.html">Lifecycle of an elastic container instance</a>.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteContainerGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteContainerGroupResponse
        /// </returns>
        public async Task<DeleteContainerGroupResponse> DeleteContainerGroupAsync(DeleteContainerGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteContainerGroupWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a DataCache.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteDataCacheRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteDataCacheResponse
        /// </returns>
        public DeleteDataCacheResponse DeleteDataCacheWithOptions(DeleteDataCacheRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Bucket))
            {
                query["Bucket"] = request.Bucket;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataCacheId))
            {
                query["DataCacheId"] = request.DataCacheId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Path))
            {
                query["Path"] = request.Path;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteDataCache",
                Version = "2018-08-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteDataCacheResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a DataCache.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteDataCacheRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteDataCacheResponse
        /// </returns>
        public async Task<DeleteDataCacheResponse> DeleteDataCacheWithOptionsAsync(DeleteDataCacheRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Bucket))
            {
                query["Bucket"] = request.Bucket;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataCacheId))
            {
                query["DataCacheId"] = request.DataCacheId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Path))
            {
                query["Path"] = request.Path;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteDataCache",
                Version = "2018-08-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteDataCacheResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a DataCache.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteDataCacheRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteDataCacheResponse
        /// </returns>
        public DeleteDataCacheResponse DeleteDataCache(DeleteDataCacheRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteDataCacheWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a DataCache.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteDataCacheRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteDataCacheResponse
        /// </returns>
        public async Task<DeleteDataCacheResponse> DeleteDataCacheAsync(DeleteDataCacheRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteDataCacheWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an image cache.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteImageCacheRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteImageCacheResponse
        /// </returns>
        public DeleteImageCacheResponse DeleteImageCacheWithOptions(DeleteImageCacheRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageCacheId))
            {
                query["ImageCacheId"] = request.ImageCacheId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteImageCache",
                Version = "2018-08-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteImageCacheResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an image cache.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteImageCacheRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteImageCacheResponse
        /// </returns>
        public async Task<DeleteImageCacheResponse> DeleteImageCacheWithOptionsAsync(DeleteImageCacheRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageCacheId))
            {
                query["ImageCacheId"] = request.ImageCacheId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteImageCache",
                Version = "2018-08-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteImageCacheResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an image cache.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteImageCacheRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteImageCacheResponse
        /// </returns>
        public DeleteImageCacheResponse DeleteImageCache(DeleteImageCacheRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteImageCacheWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an image cache.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteImageCacheRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteImageCacheResponse
        /// </returns>
        public async Task<DeleteImageCacheResponse> DeleteImageCacheAsync(DeleteImageCacheRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteImageCacheWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a virtual node.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteVirtualNodeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteVirtualNodeResponse
        /// </returns>
        public DeleteVirtualNodeResponse DeleteVirtualNodeWithOptions(DeleteVirtualNodeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VirtualNodeId))
            {
                query["VirtualNodeId"] = request.VirtualNodeId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteVirtualNode",
                Version = "2018-08-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteVirtualNodeResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a virtual node.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteVirtualNodeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteVirtualNodeResponse
        /// </returns>
        public async Task<DeleteVirtualNodeResponse> DeleteVirtualNodeWithOptionsAsync(DeleteVirtualNodeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VirtualNodeId))
            {
                query["VirtualNodeId"] = request.VirtualNodeId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteVirtualNode",
                Version = "2018-08-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteVirtualNodeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a virtual node.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteVirtualNodeRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteVirtualNodeResponse
        /// </returns>
        public DeleteVirtualNodeResponse DeleteVirtualNode(DeleteVirtualNodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteVirtualNodeWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a virtual node.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteVirtualNodeRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteVirtualNodeResponse
        /// </returns>
        public async Task<DeleteVirtualNodeResponse> DeleteVirtualNodeAsync(DeleteVirtualNodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteVirtualNodeWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the Elastic Compute Service (ECS) instance families that are available in a specified region and zone.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>When you call the CreateContainerGroup operation to create an elastic container instance, you can use the InstanceType parameter to specify ECS instance types that fit your specific needs. To ensure that the elastic container instance can be created, you can call the DescribeAvailableResource operation to query which ECS instance types and instance families are available in the specified region and zone before you create the elastic container instance.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeAvailableResourceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeAvailableResourceResponse
        /// </returns>
        public DescribeAvailableResourceResponse DescribeAvailableResourceWithOptions(DescribeAvailableResourceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestinationResource))
            {
                query["DestinationResource"] = request.DestinationResource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SpotResource))
            {
                query["SpotResource"] = request.SpotResource;
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
                Action = "DescribeAvailableResource",
                Version = "2018-08-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAvailableResourceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the Elastic Compute Service (ECS) instance families that are available in a specified region and zone.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>When you call the CreateContainerGroup operation to create an elastic container instance, you can use the InstanceType parameter to specify ECS instance types that fit your specific needs. To ensure that the elastic container instance can be created, you can call the DescribeAvailableResource operation to query which ECS instance types and instance families are available in the specified region and zone before you create the elastic container instance.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeAvailableResourceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeAvailableResourceResponse
        /// </returns>
        public async Task<DescribeAvailableResourceResponse> DescribeAvailableResourceWithOptionsAsync(DescribeAvailableResourceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestinationResource))
            {
                query["DestinationResource"] = request.DestinationResource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SpotResource))
            {
                query["SpotResource"] = request.SpotResource;
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
                Action = "DescribeAvailableResource",
                Version = "2018-08-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAvailableResourceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the Elastic Compute Service (ECS) instance families that are available in a specified region and zone.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>When you call the CreateContainerGroup operation to create an elastic container instance, you can use the InstanceType parameter to specify ECS instance types that fit your specific needs. To ensure that the elastic container instance can be created, you can call the DescribeAvailableResource operation to query which ECS instance types and instance families are available in the specified region and zone before you create the elastic container instance.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeAvailableResourceRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeAvailableResourceResponse
        /// </returns>
        public DescribeAvailableResourceResponse DescribeAvailableResource(DescribeAvailableResourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeAvailableResourceWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the Elastic Compute Service (ECS) instance families that are available in a specified region and zone.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>When you call the CreateContainerGroup operation to create an elastic container instance, you can use the InstanceType parameter to specify ECS instance types that fit your specific needs. To ensure that the elastic container instance can be created, you can call the DescribeAvailableResource operation to query which ECS instance types and instance families are available in the specified region and zone before you create the elastic container instance.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeAvailableResourceRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeAvailableResourceResponse
        /// </returns>
        public async Task<DescribeAvailableResourceResponse> DescribeAvailableResourceAsync(DescribeAvailableResourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeAvailableResourceWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of a CommitContainer task.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeCommitContainerTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeCommitContainerTaskResponse
        /// </returns>
        public DescribeCommitContainerTaskResponse DescribeCommitContainerTaskWithOptions(DescribeCommitContainerTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContainerGroupId))
            {
                query["ContainerGroupId"] = request.ContainerGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                query["TaskId"] = request.TaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskStatus))
            {
                query["TaskStatus"] = request.TaskStatus;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeCommitContainerTask",
                Version = "2018-08-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeCommitContainerTaskResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of a CommitContainer task.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeCommitContainerTaskRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeCommitContainerTaskResponse
        /// </returns>
        public async Task<DescribeCommitContainerTaskResponse> DescribeCommitContainerTaskWithOptionsAsync(DescribeCommitContainerTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContainerGroupId))
            {
                query["ContainerGroupId"] = request.ContainerGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                query["TaskId"] = request.TaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskStatus))
            {
                query["TaskStatus"] = request.TaskStatus;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeCommitContainerTask",
                Version = "2018-08-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeCommitContainerTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of a CommitContainer task.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeCommitContainerTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeCommitContainerTaskResponse
        /// </returns>
        public DescribeCommitContainerTaskResponse DescribeCommitContainerTask(DescribeCommitContainerTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeCommitContainerTaskWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of a CommitContainer task.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeCommitContainerTaskRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeCommitContainerTaskResponse
        /// </returns>
        public async Task<DescribeCommitContainerTaskResponse> DescribeCommitContainerTaskAsync(DescribeCommitContainerTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeCommitContainerTaskWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries event information about multiple container groups at a time.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call this operation to query the event information about multiple elastic container instances at a time. By default, the most recent 50 entries of events of each elastic container instance are returned.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeContainerGroupEventsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeContainerGroupEventsResponse
        /// </returns>
        public DescribeContainerGroupEventsResponse DescribeContainerGroupEventsWithOptions(DescribeContainerGroupEventsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContainerGroupIds))
            {
                query["ContainerGroupIds"] = request.ContainerGroupIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventSource))
            {
                query["EventSource"] = request.EventSource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Limit))
            {
                query["Limit"] = request.Limit;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SinceSecond))
            {
                query["SinceSecond"] = request.SinceSecond;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                query["Tag"] = request.Tag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VSwitchId))
            {
                query["VSwitchId"] = request.VSwitchId;
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
                Action = "DescribeContainerGroupEvents",
                Version = "2018-08-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeContainerGroupEventsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries event information about multiple container groups at a time.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call this operation to query the event information about multiple elastic container instances at a time. By default, the most recent 50 entries of events of each elastic container instance are returned.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeContainerGroupEventsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeContainerGroupEventsResponse
        /// </returns>
        public async Task<DescribeContainerGroupEventsResponse> DescribeContainerGroupEventsWithOptionsAsync(DescribeContainerGroupEventsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContainerGroupIds))
            {
                query["ContainerGroupIds"] = request.ContainerGroupIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventSource))
            {
                query["EventSource"] = request.EventSource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Limit))
            {
                query["Limit"] = request.Limit;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SinceSecond))
            {
                query["SinceSecond"] = request.SinceSecond;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                query["Tag"] = request.Tag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VSwitchId))
            {
                query["VSwitchId"] = request.VSwitchId;
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
                Action = "DescribeContainerGroupEvents",
                Version = "2018-08-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeContainerGroupEventsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries event information about multiple container groups at a time.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call this operation to query the event information about multiple elastic container instances at a time. By default, the most recent 50 entries of events of each elastic container instance are returned.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeContainerGroupEventsRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeContainerGroupEventsResponse
        /// </returns>
        public DescribeContainerGroupEventsResponse DescribeContainerGroupEvents(DescribeContainerGroupEventsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeContainerGroupEventsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries event information about multiple container groups at a time.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call this operation to query the event information about multiple elastic container instances at a time. By default, the most recent 50 entries of events of each elastic container instance are returned.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeContainerGroupEventsRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeContainerGroupEventsResponse
        /// </returns>
        public async Task<DescribeContainerGroupEventsResponse> DescribeContainerGroupEventsAsync(DescribeContainerGroupEventsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeContainerGroupEventsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the monitoring data of an elastic container instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  A maximum of 50 monitoring data entries can be returned. If the number of monitoring data entries exceeds this limit, an error message is returned.</para>
        /// <list type="bullet">
        /// <item><description>You can query real-time monitoring data (data generated within the last 5 minutes) and historical data (data generated more than 5 minutes ago). If the time range to query starts or ends later than the current time, historical monitoring data generated more than 5 minutes ago is returned.</description></item>
        /// <item><description>The elastic container instance whose monitoring data you want to query must be created after April 3, 2019, 15:00 UTC+8.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeContainerGroupMetricRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeContainerGroupMetricResponse
        /// </returns>
        public DescribeContainerGroupMetricResponse DescribeContainerGroupMetricWithOptions(DescribeContainerGroupMetricRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContainerGroupId))
            {
                query["ContainerGroupId"] = request.ContainerGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Period))
            {
                query["Period"] = request.Period;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
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
                Action = "DescribeContainerGroupMetric",
                Version = "2018-08-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeContainerGroupMetricResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the monitoring data of an elastic container instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  A maximum of 50 monitoring data entries can be returned. If the number of monitoring data entries exceeds this limit, an error message is returned.</para>
        /// <list type="bullet">
        /// <item><description>You can query real-time monitoring data (data generated within the last 5 minutes) and historical data (data generated more than 5 minutes ago). If the time range to query starts or ends later than the current time, historical monitoring data generated more than 5 minutes ago is returned.</description></item>
        /// <item><description>The elastic container instance whose monitoring data you want to query must be created after April 3, 2019, 15:00 UTC+8.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeContainerGroupMetricRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeContainerGroupMetricResponse
        /// </returns>
        public async Task<DescribeContainerGroupMetricResponse> DescribeContainerGroupMetricWithOptionsAsync(DescribeContainerGroupMetricRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContainerGroupId))
            {
                query["ContainerGroupId"] = request.ContainerGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Period))
            {
                query["Period"] = request.Period;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
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
                Action = "DescribeContainerGroupMetric",
                Version = "2018-08-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeContainerGroupMetricResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the monitoring data of an elastic container instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  A maximum of 50 monitoring data entries can be returned. If the number of monitoring data entries exceeds this limit, an error message is returned.</para>
        /// <list type="bullet">
        /// <item><description>You can query real-time monitoring data (data generated within the last 5 minutes) and historical data (data generated more than 5 minutes ago). If the time range to query starts or ends later than the current time, historical monitoring data generated more than 5 minutes ago is returned.</description></item>
        /// <item><description>The elastic container instance whose monitoring data you want to query must be created after April 3, 2019, 15:00 UTC+8.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeContainerGroupMetricRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeContainerGroupMetricResponse
        /// </returns>
        public DescribeContainerGroupMetricResponse DescribeContainerGroupMetric(DescribeContainerGroupMetricRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeContainerGroupMetricWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the monitoring data of an elastic container instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  A maximum of 50 monitoring data entries can be returned. If the number of monitoring data entries exceeds this limit, an error message is returned.</para>
        /// <list type="bullet">
        /// <item><description>You can query real-time monitoring data (data generated within the last 5 minutes) and historical data (data generated more than 5 minutes ago). If the time range to query starts or ends later than the current time, historical monitoring data generated more than 5 minutes ago is returned.</description></item>
        /// <item><description>The elastic container instance whose monitoring data you want to query must be created after April 3, 2019, 15:00 UTC+8.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeContainerGroupMetricRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeContainerGroupMetricResponse
        /// </returns>
        public async Task<DescribeContainerGroupMetricResponse> DescribeContainerGroupMetricAsync(DescribeContainerGroupMetricRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeContainerGroupMetricWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the price of an elastic container instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  When you call this operation, you cannot use resource groups to control the permissions of a RAM user.</para>
        /// <list type="bullet">
        /// <item><description>You can create an elastic container instance by specifying vCPU and memory resource specifications or by specifying ECS instance types. When you call this operation to query the prices of elastic container instances, pass in specifications of the elastic container instances.<list type="bullet">
        /// <item><description><a href="https://help.aliyun.com/document_detail/114662.html">vCPU and memory specifications</a>.</description></item>
        /// <item><description><a href="https://help.aliyun.com/document_detail/114664.html">ECS instance types that are supported by Elastic Container Instance</a>.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeContainerGroupPriceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeContainerGroupPriceResponse
        /// </returns>
        public DescribeContainerGroupPriceResponse DescribeContainerGroupPriceWithOptions(DescribeContainerGroupPriceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ComputeCategory))
            {
                query["ComputeCategory"] = request.ComputeCategory;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cpu))
            {
                query["Cpu"] = request.Cpu;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EphemeralStorage))
            {
                query["EphemeralStorage"] = request.EphemeralStorage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceType))
            {
                query["InstanceType"] = request.InstanceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Memory))
            {
                query["Memory"] = request.Memory;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SpotDuration))
            {
                query["SpotDuration"] = request.SpotDuration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SpotPriceLimit))
            {
                query["SpotPriceLimit"] = request.SpotPriceLimit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SpotStrategy))
            {
                query["SpotStrategy"] = request.SpotStrategy;
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
                Action = "DescribeContainerGroupPrice",
                Version = "2018-08-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeContainerGroupPriceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the price of an elastic container instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  When you call this operation, you cannot use resource groups to control the permissions of a RAM user.</para>
        /// <list type="bullet">
        /// <item><description>You can create an elastic container instance by specifying vCPU and memory resource specifications or by specifying ECS instance types. When you call this operation to query the prices of elastic container instances, pass in specifications of the elastic container instances.<list type="bullet">
        /// <item><description><a href="https://help.aliyun.com/document_detail/114662.html">vCPU and memory specifications</a>.</description></item>
        /// <item><description><a href="https://help.aliyun.com/document_detail/114664.html">ECS instance types that are supported by Elastic Container Instance</a>.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeContainerGroupPriceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeContainerGroupPriceResponse
        /// </returns>
        public async Task<DescribeContainerGroupPriceResponse> DescribeContainerGroupPriceWithOptionsAsync(DescribeContainerGroupPriceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ComputeCategory))
            {
                query["ComputeCategory"] = request.ComputeCategory;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cpu))
            {
                query["Cpu"] = request.Cpu;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EphemeralStorage))
            {
                query["EphemeralStorage"] = request.EphemeralStorage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceType))
            {
                query["InstanceType"] = request.InstanceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Memory))
            {
                query["Memory"] = request.Memory;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SpotDuration))
            {
                query["SpotDuration"] = request.SpotDuration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SpotPriceLimit))
            {
                query["SpotPriceLimit"] = request.SpotPriceLimit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SpotStrategy))
            {
                query["SpotStrategy"] = request.SpotStrategy;
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
                Action = "DescribeContainerGroupPrice",
                Version = "2018-08-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeContainerGroupPriceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the price of an elastic container instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  When you call this operation, you cannot use resource groups to control the permissions of a RAM user.</para>
        /// <list type="bullet">
        /// <item><description>You can create an elastic container instance by specifying vCPU and memory resource specifications or by specifying ECS instance types. When you call this operation to query the prices of elastic container instances, pass in specifications of the elastic container instances.<list type="bullet">
        /// <item><description><a href="https://help.aliyun.com/document_detail/114662.html">vCPU and memory specifications</a>.</description></item>
        /// <item><description><a href="https://help.aliyun.com/document_detail/114664.html">ECS instance types that are supported by Elastic Container Instance</a>.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeContainerGroupPriceRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeContainerGroupPriceResponse
        /// </returns>
        public DescribeContainerGroupPriceResponse DescribeContainerGroupPrice(DescribeContainerGroupPriceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeContainerGroupPriceWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the price of an elastic container instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  When you call this operation, you cannot use resource groups to control the permissions of a RAM user.</para>
        /// <list type="bullet">
        /// <item><description>You can create an elastic container instance by specifying vCPU and memory resource specifications or by specifying ECS instance types. When you call this operation to query the prices of elastic container instances, pass in specifications of the elastic container instances.<list type="bullet">
        /// <item><description><a href="https://help.aliyun.com/document_detail/114662.html">vCPU and memory specifications</a>.</description></item>
        /// <item><description><a href="https://help.aliyun.com/document_detail/114664.html">ECS instance types that are supported by Elastic Container Instance</a>.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeContainerGroupPriceRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeContainerGroupPriceResponse
        /// </returns>
        public async Task<DescribeContainerGroupPriceResponse> DescribeContainerGroupPriceAsync(DescribeContainerGroupPriceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeContainerGroupPriceWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the statuses of multiple container groups at a time.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeContainerGroupStatusRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeContainerGroupStatusResponse
        /// </returns>
        public DescribeContainerGroupStatusResponse DescribeContainerGroupStatusWithOptions(DescribeContainerGroupStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContainerGroupIds))
            {
                query["ContainerGroupIds"] = request.ContainerGroupIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Limit))
            {
                query["Limit"] = request.Limit;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SinceSecond))
            {
                query["SinceSecond"] = request.SinceSecond;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                query["Tag"] = request.Tag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VSwitchId))
            {
                query["VSwitchId"] = request.VSwitchId;
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
                Action = "DescribeContainerGroupStatus",
                Version = "2018-08-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeContainerGroupStatusResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the statuses of multiple container groups at a time.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeContainerGroupStatusRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeContainerGroupStatusResponse
        /// </returns>
        public async Task<DescribeContainerGroupStatusResponse> DescribeContainerGroupStatusWithOptionsAsync(DescribeContainerGroupStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContainerGroupIds))
            {
                query["ContainerGroupIds"] = request.ContainerGroupIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Limit))
            {
                query["Limit"] = request.Limit;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SinceSecond))
            {
                query["SinceSecond"] = request.SinceSecond;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                query["Tag"] = request.Tag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VSwitchId))
            {
                query["VSwitchId"] = request.VSwitchId;
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
                Action = "DescribeContainerGroupStatus",
                Version = "2018-08-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeContainerGroupStatusResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the statuses of multiple container groups at a time.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeContainerGroupStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeContainerGroupStatusResponse
        /// </returns>
        public DescribeContainerGroupStatusResponse DescribeContainerGroupStatus(DescribeContainerGroupStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeContainerGroupStatusWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the statuses of multiple container groups at a time.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeContainerGroupStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeContainerGroupStatusResponse
        /// </returns>
        public async Task<DescribeContainerGroupStatusResponse> DescribeContainerGroupStatusAsync(DescribeContainerGroupStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeContainerGroupStatusWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries information about multiple elastic container instances at a time.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  After an elastic container instance is terminated, its underlying computing resources are recycled. By default, other resources, such as elastic IP addresses (EIPs), that are created together with the instance are released together with the instance.</para>
        /// <list type="bullet">
        /// <item><description>The metadata of an instance in the final status (Failed, Succeeded, or Expired) is retained based on the following rules:<list type="bullet">
        /// <item><description>All metadata information is retained within 1 hour since the instance enters the final status.</description></item>
        /// <item><description>One hour after the instance enters the final status, only the latest 100 entries of metadata information in each region are retained.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeContainerGroupsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeContainerGroupsResponse
        /// </returns>
        public DescribeContainerGroupsResponse DescribeContainerGroupsWithOptions(DescribeContainerGroupsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ComputeCategory))
            {
                query["ComputeCategory"] = request.ComputeCategory;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContainerGroupIds))
            {
                query["ContainerGroupIds"] = request.ContainerGroupIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContainerGroupName))
            {
                query["ContainerGroupName"] = request.ContainerGroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Limit))
            {
                query["Limit"] = request.Limit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityGroupId))
            {
                query["SecurityGroupId"] = request.SecurityGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                query["Tag"] = request.Tag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VSwitchId))
            {
                query["VSwitchId"] = request.VSwitchId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WithEvent))
            {
                query["WithEvent"] = request.WithEvent;
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
                Action = "DescribeContainerGroups",
                Version = "2018-08-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeContainerGroupsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries information about multiple elastic container instances at a time.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  After an elastic container instance is terminated, its underlying computing resources are recycled. By default, other resources, such as elastic IP addresses (EIPs), that are created together with the instance are released together with the instance.</para>
        /// <list type="bullet">
        /// <item><description>The metadata of an instance in the final status (Failed, Succeeded, or Expired) is retained based on the following rules:<list type="bullet">
        /// <item><description>All metadata information is retained within 1 hour since the instance enters the final status.</description></item>
        /// <item><description>One hour after the instance enters the final status, only the latest 100 entries of metadata information in each region are retained.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeContainerGroupsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeContainerGroupsResponse
        /// </returns>
        public async Task<DescribeContainerGroupsResponse> DescribeContainerGroupsWithOptionsAsync(DescribeContainerGroupsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ComputeCategory))
            {
                query["ComputeCategory"] = request.ComputeCategory;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContainerGroupIds))
            {
                query["ContainerGroupIds"] = request.ContainerGroupIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContainerGroupName))
            {
                query["ContainerGroupName"] = request.ContainerGroupName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Limit))
            {
                query["Limit"] = request.Limit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityGroupId))
            {
                query["SecurityGroupId"] = request.SecurityGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                query["Tag"] = request.Tag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VSwitchId))
            {
                query["VSwitchId"] = request.VSwitchId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WithEvent))
            {
                query["WithEvent"] = request.WithEvent;
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
                Action = "DescribeContainerGroups",
                Version = "2018-08-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeContainerGroupsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries information about multiple elastic container instances at a time.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  After an elastic container instance is terminated, its underlying computing resources are recycled. By default, other resources, such as elastic IP addresses (EIPs), that are created together with the instance are released together with the instance.</para>
        /// <list type="bullet">
        /// <item><description>The metadata of an instance in the final status (Failed, Succeeded, or Expired) is retained based on the following rules:<list type="bullet">
        /// <item><description>All metadata information is retained within 1 hour since the instance enters the final status.</description></item>
        /// <item><description>One hour after the instance enters the final status, only the latest 100 entries of metadata information in each region are retained.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeContainerGroupsRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeContainerGroupsResponse
        /// </returns>
        public DescribeContainerGroupsResponse DescribeContainerGroups(DescribeContainerGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeContainerGroupsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries information about multiple elastic container instances at a time.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  After an elastic container instance is terminated, its underlying computing resources are recycled. By default, other resources, such as elastic IP addresses (EIPs), that are created together with the instance are released together with the instance.</para>
        /// <list type="bullet">
        /// <item><description>The metadata of an instance in the final status (Failed, Succeeded, or Expired) is retained based on the following rules:<list type="bullet">
        /// <item><description>All metadata information is retained within 1 hour since the instance enters the final status.</description></item>
        /// <item><description>One hour after the instance enters the final status, only the latest 100 entries of metadata information in each region are retained.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeContainerGroupsRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeContainerGroupsResponse
        /// </returns>
        public async Task<DescribeContainerGroupsResponse> DescribeContainerGroupsAsync(DescribeContainerGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeContainerGroupsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the logs of a container in a container group.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeContainerLogRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeContainerLogResponse
        /// </returns>
        public DescribeContainerLogResponse DescribeContainerLogWithOptions(DescribeContainerLogRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContainerGroupId))
            {
                query["ContainerGroupId"] = request.ContainerGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContainerName))
            {
                query["ContainerName"] = request.ContainerName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LastTime))
            {
                query["LastTime"] = request.LastTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LimitBytes))
            {
                query["LimitBytes"] = request.LimitBytes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SinceSeconds))
            {
                query["SinceSeconds"] = request.SinceSeconds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tail))
            {
                query["Tail"] = request.Tail;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Timestamps))
            {
                query["Timestamps"] = request.Timestamps;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeContainerLog",
                Version = "2018-08-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeContainerLogResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the logs of a container in a container group.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeContainerLogRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeContainerLogResponse
        /// </returns>
        public async Task<DescribeContainerLogResponse> DescribeContainerLogWithOptionsAsync(DescribeContainerLogRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContainerGroupId))
            {
                query["ContainerGroupId"] = request.ContainerGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContainerName))
            {
                query["ContainerName"] = request.ContainerName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LastTime))
            {
                query["LastTime"] = request.LastTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LimitBytes))
            {
                query["LimitBytes"] = request.LimitBytes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SinceSeconds))
            {
                query["SinceSeconds"] = request.SinceSeconds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tail))
            {
                query["Tail"] = request.Tail;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Timestamps))
            {
                query["Timestamps"] = request.Timestamps;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeContainerLog",
                Version = "2018-08-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeContainerLogResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the logs of a container in a container group.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeContainerLogRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeContainerLogResponse
        /// </returns>
        public DescribeContainerLogResponse DescribeContainerLog(DescribeContainerLogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeContainerLogWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the logs of a container in a container group.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeContainerLogRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeContainerLogResponse
        /// </returns>
        public async Task<DescribeContainerLogResponse> DescribeContainerLogAsync(DescribeContainerLogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeContainerLogWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about data caches.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeDataCachesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeDataCachesResponse
        /// </returns>
        public DescribeDataCachesResponse DescribeDataCachesWithOptions(DescribeDataCachesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Bucket))
            {
                query["Bucket"] = request.Bucket;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataCacheId))
            {
                query["DataCacheId"] = request.DataCacheId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Limit))
            {
                query["Limit"] = request.Limit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Path))
            {
                query["Path"] = request.Path;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                query["Tag"] = request.Tag;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDataCaches",
                Version = "2018-08-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDataCachesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about data caches.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeDataCachesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeDataCachesResponse
        /// </returns>
        public async Task<DescribeDataCachesResponse> DescribeDataCachesWithOptionsAsync(DescribeDataCachesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Bucket))
            {
                query["Bucket"] = request.Bucket;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataCacheId))
            {
                query["DataCacheId"] = request.DataCacheId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Limit))
            {
                query["Limit"] = request.Limit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Path))
            {
                query["Path"] = request.Path;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                query["Tag"] = request.Tag;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDataCaches",
                Version = "2018-08-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDataCachesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about data caches.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeDataCachesRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeDataCachesResponse
        /// </returns>
        public DescribeDataCachesResponse DescribeDataCaches(DescribeDataCachesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDataCachesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about data caches.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeDataCachesRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeDataCachesResponse
        /// </returns>
        public async Task<DescribeDataCachesResponse> DescribeDataCachesAsync(DescribeDataCachesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDataCachesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries information about image caches.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeImageCachesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeImageCachesResponse
        /// </returns>
        public DescribeImageCachesResponse DescribeImageCachesWithOptions(DescribeImageCachesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Image))
            {
                query["Image"] = request.Image;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageCacheId))
            {
                query["ImageCacheId"] = request.ImageCacheId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageCacheName))
            {
                query["ImageCacheName"] = request.ImageCacheName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageFullMatch))
            {
                query["ImageFullMatch"] = request.ImageFullMatch;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageMatchCountRequest))
            {
                query["ImageMatchCountRequest"] = request.ImageMatchCountRequest;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Limit))
            {
                query["Limit"] = request.Limit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MatchImage))
            {
                query["MatchImage"] = request.MatchImage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SnapshotId))
            {
                query["SnapshotId"] = request.SnapshotId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                query["Tag"] = request.Tag;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeImageCaches",
                Version = "2018-08-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeImageCachesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries information about image caches.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeImageCachesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeImageCachesResponse
        /// </returns>
        public async Task<DescribeImageCachesResponse> DescribeImageCachesWithOptionsAsync(DescribeImageCachesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Image))
            {
                query["Image"] = request.Image;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageCacheId))
            {
                query["ImageCacheId"] = request.ImageCacheId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageCacheName))
            {
                query["ImageCacheName"] = request.ImageCacheName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageFullMatch))
            {
                query["ImageFullMatch"] = request.ImageFullMatch;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageMatchCountRequest))
            {
                query["ImageMatchCountRequest"] = request.ImageMatchCountRequest;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Limit))
            {
                query["Limit"] = request.Limit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MatchImage))
            {
                query["MatchImage"] = request.MatchImage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SnapshotId))
            {
                query["SnapshotId"] = request.SnapshotId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                query["Tag"] = request.Tag;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeImageCaches",
                Version = "2018-08-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeImageCachesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries information about image caches.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeImageCachesRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeImageCachesResponse
        /// </returns>
        public DescribeImageCachesResponse DescribeImageCaches(DescribeImageCachesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeImageCachesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries information about image caches.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeImageCachesRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeImageCachesResponse
        /// </returns>
        public async Task<DescribeImageCachesResponse> DescribeImageCachesAsync(DescribeImageCachesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeImageCachesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about operations and maintenance tasks of an elastic container instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeInstanceOpsRecordsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeInstanceOpsRecordsResponse
        /// </returns>
        public DescribeInstanceOpsRecordsResponse DescribeInstanceOpsRecordsWithOptions(DescribeInstanceOpsRecordsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContainerGroupId))
            {
                query["ContainerGroupId"] = request.ContainerGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpsType))
            {
                query["OpsType"] = request.OpsType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeInstanceOpsRecords",
                Version = "2018-08-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeInstanceOpsRecordsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about operations and maintenance tasks of an elastic container instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeInstanceOpsRecordsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeInstanceOpsRecordsResponse
        /// </returns>
        public async Task<DescribeInstanceOpsRecordsResponse> DescribeInstanceOpsRecordsWithOptionsAsync(DescribeInstanceOpsRecordsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContainerGroupId))
            {
                query["ContainerGroupId"] = request.ContainerGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OpsType))
            {
                query["OpsType"] = request.OpsType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeInstanceOpsRecords",
                Version = "2018-08-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeInstanceOpsRecordsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about operations and maintenance tasks of an elastic container instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeInstanceOpsRecordsRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeInstanceOpsRecordsResponse
        /// </returns>
        public DescribeInstanceOpsRecordsResponse DescribeInstanceOpsRecords(DescribeInstanceOpsRecordsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeInstanceOpsRecordsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about operations and maintenance tasks of an elastic container instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeInstanceOpsRecordsRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeInstanceOpsRecordsResponse
        /// </returns>
        public async Task<DescribeInstanceOpsRecordsResponse> DescribeInstanceOpsRecordsAsync(DescribeInstanceOpsRecordsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeInstanceOpsRecordsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the monitoring data of elastic container instances.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  Only the latest entry of monitoring data of each elastic container instance is returned.</para>
        /// <list type="bullet">
        /// <item><description>You can query only the monitoring data of elastic container instances that are created after April 3, 2019 15:00:00 UTC+8.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeMultiContainerGroupMetricRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeMultiContainerGroupMetricResponse
        /// </returns>
        public DescribeMultiContainerGroupMetricResponse DescribeMultiContainerGroupMetricWithOptions(DescribeMultiContainerGroupMetricRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContainerGroupIds))
            {
                query["ContainerGroupIds"] = request.ContainerGroupIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MetricType))
            {
                query["MetricType"] = request.MetricType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeMultiContainerGroupMetric",
                Version = "2018-08-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeMultiContainerGroupMetricResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the monitoring data of elastic container instances.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  Only the latest entry of monitoring data of each elastic container instance is returned.</para>
        /// <list type="bullet">
        /// <item><description>You can query only the monitoring data of elastic container instances that are created after April 3, 2019 15:00:00 UTC+8.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeMultiContainerGroupMetricRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeMultiContainerGroupMetricResponse
        /// </returns>
        public async Task<DescribeMultiContainerGroupMetricResponse> DescribeMultiContainerGroupMetricWithOptionsAsync(DescribeMultiContainerGroupMetricRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContainerGroupIds))
            {
                query["ContainerGroupIds"] = request.ContainerGroupIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MetricType))
            {
                query["MetricType"] = request.MetricType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeMultiContainerGroupMetric",
                Version = "2018-08-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeMultiContainerGroupMetricResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the monitoring data of elastic container instances.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  Only the latest entry of monitoring data of each elastic container instance is returned.</para>
        /// <list type="bullet">
        /// <item><description>You can query only the monitoring data of elastic container instances that are created after April 3, 2019 15:00:00 UTC+8.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeMultiContainerGroupMetricRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeMultiContainerGroupMetricResponse
        /// </returns>
        public DescribeMultiContainerGroupMetricResponse DescribeMultiContainerGroupMetric(DescribeMultiContainerGroupMetricRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeMultiContainerGroupMetricWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the monitoring data of elastic container instances.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  Only the latest entry of monitoring data of each elastic container instance is returned.</para>
        /// <list type="bullet">
        /// <item><description>You can query only the monitoring data of elastic container instances that are created after April 3, 2019 15:00:00 UTC+8.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeMultiContainerGroupMetricRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeMultiContainerGroupMetricResponse
        /// </returns>
        public async Task<DescribeMultiContainerGroupMetricResponse> DescribeMultiContainerGroupMetricAsync(DescribeMultiContainerGroupMetricRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeMultiContainerGroupMetricWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the regions and zones in which Elastic Container Instance is available.</para>
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
        public DescribeRegionsResponse DescribeRegionsWithOptions(DescribeRegionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeRegions",
                Version = "2018-08-08",
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
        /// <para>Queries the regions and zones in which Elastic Container Instance is available.</para>
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
        public async Task<DescribeRegionsResponse> DescribeRegionsWithOptionsAsync(DescribeRegionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeRegions",
                Version = "2018-08-08",
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
        /// <para>Queries the regions and zones in which Elastic Container Instance is available.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeRegionsRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeRegionsResponse
        /// </returns>
        public DescribeRegionsResponse DescribeRegions(DescribeRegionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeRegionsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the regions and zones in which Elastic Container Instance is available.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeRegionsRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeRegionsResponse
        /// </returns>
        public async Task<DescribeRegionsResponse> DescribeRegionsAsync(DescribeRegionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeRegionsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries information about virtual nodes.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeVirtualNodesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeVirtualNodesResponse
        /// </returns>
        public DescribeVirtualNodesResponse DescribeVirtualNodesWithOptions(DescribeVirtualNodesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Limit))
            {
                query["Limit"] = request.Limit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                query["Tag"] = request.Tag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VirtualNodeIds))
            {
                query["VirtualNodeIds"] = request.VirtualNodeIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VirtualNodeName))
            {
                query["VirtualNodeName"] = request.VirtualNodeName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeVirtualNodes",
                Version = "2018-08-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeVirtualNodesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries information about virtual nodes.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeVirtualNodesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeVirtualNodesResponse
        /// </returns>
        public async Task<DescribeVirtualNodesResponse> DescribeVirtualNodesWithOptionsAsync(DescribeVirtualNodesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Limit))
            {
                query["Limit"] = request.Limit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                query["Tag"] = request.Tag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VirtualNodeIds))
            {
                query["VirtualNodeIds"] = request.VirtualNodeIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VirtualNodeName))
            {
                query["VirtualNodeName"] = request.VirtualNodeName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeVirtualNodes",
                Version = "2018-08-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeVirtualNodesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries information about virtual nodes.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeVirtualNodesRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeVirtualNodesResponse
        /// </returns>
        public DescribeVirtualNodesResponse DescribeVirtualNodes(DescribeVirtualNodesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeVirtualNodesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries information about virtual nodes.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeVirtualNodesRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeVirtualNodesResponse
        /// </returns>
        public async Task<DescribeVirtualNodesResponse> DescribeVirtualNodesAsync(DescribeVirtualNodesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeVirtualNodesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Runs commands in a container.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ExecContainerCommandRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ExecContainerCommandResponse
        /// </returns>
        public ExecContainerCommandResponse ExecContainerCommandWithOptions(ExecContainerCommandRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Command))
            {
                query["Command"] = request.Command;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContainerGroupId))
            {
                query["ContainerGroupId"] = request.ContainerGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContainerName))
            {
                query["ContainerName"] = request.ContainerName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Stdin))
            {
                query["Stdin"] = request.Stdin;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Sync))
            {
                query["Sync"] = request.Sync;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TTY))
            {
                query["TTY"] = request.TTY;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ExecContainerCommand",
                Version = "2018-08-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ExecContainerCommandResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Runs commands in a container.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ExecContainerCommandRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ExecContainerCommandResponse
        /// </returns>
        public async Task<ExecContainerCommandResponse> ExecContainerCommandWithOptionsAsync(ExecContainerCommandRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Command))
            {
                query["Command"] = request.Command;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContainerGroupId))
            {
                query["ContainerGroupId"] = request.ContainerGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContainerName))
            {
                query["ContainerName"] = request.ContainerName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Stdin))
            {
                query["Stdin"] = request.Stdin;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Sync))
            {
                query["Sync"] = request.Sync;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TTY))
            {
                query["TTY"] = request.TTY;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ExecContainerCommand",
                Version = "2018-08-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ExecContainerCommandResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Runs commands in a container.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ExecContainerCommandRequest
        /// </param>
        /// 
        /// <returns>
        /// ExecContainerCommandResponse
        /// </returns>
        public ExecContainerCommandResponse ExecContainerCommand(ExecContainerCommandRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ExecContainerCommandWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Runs commands in a container.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ExecContainerCommandRequest
        /// </param>
        /// 
        /// <returns>
        /// ExecContainerCommandResponse
        /// </returns>
        public async Task<ExecContainerCommandResponse> ExecContainerCommandAsync(ExecContainerCommandRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ExecContainerCommandWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the tags that are added to an Elastic Container Instance resource.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListTagResourcesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListTagResourcesResponse
        /// </returns>
        public ListTagResourcesResponse ListTagResourcesWithOptions(ListTagResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Limit))
            {
                query["Limit"] = request.Limit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceId))
            {
                query["ResourceId"] = request.ResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["ResourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                query["Tag"] = request.Tag;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTagResources",
                Version = "2018-08-08",
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the tags that are added to an Elastic Container Instance resource.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListTagResourcesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListTagResourcesResponse
        /// </returns>
        public async Task<ListTagResourcesResponse> ListTagResourcesWithOptionsAsync(ListTagResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Limit))
            {
                query["Limit"] = request.Limit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceId))
            {
                query["ResourceId"] = request.ResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["ResourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                query["Tag"] = request.Tag;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTagResources",
                Version = "2018-08-08",
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the tags that are added to an Elastic Container Instance resource.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListTagResourcesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListTagResourcesResponse
        /// </returns>
        public ListTagResourcesResponse ListTagResources(ListTagResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListTagResourcesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the tags that are added to an Elastic Container Instance resource.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListTagResourcesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListTagResourcesResponse
        /// </returns>
        public async Task<ListTagResourcesResponse> ListTagResourcesAsync(ListTagResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListTagResourcesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the used amounts and upper limits of privileges and quotas that you have in a specified region.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation does not support resource group authentication.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListUsageRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListUsageResponse
        /// </returns>
        public ListUsageResponse ListUsageWithOptions(ListUsageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListUsage",
                Version = "2018-08-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListUsageResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the used amounts and upper limits of privileges and quotas that you have in a specified region.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation does not support resource group authentication.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListUsageRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListUsageResponse
        /// </returns>
        public async Task<ListUsageResponse> ListUsageWithOptionsAsync(ListUsageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListUsage",
                Version = "2018-08-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListUsageResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the used amounts and upper limits of privileges and quotas that you have in a specified region.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation does not support resource group authentication.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListUsageRequest
        /// </param>
        /// 
        /// <returns>
        /// ListUsageResponse
        /// </returns>
        public ListUsageResponse ListUsage(ListUsageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListUsageWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the used amounts and upper limits of privileges and quotas that you have in a specified region.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation does not support resource group authentication.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListUsageRequest
        /// </param>
        /// 
        /// <returns>
        /// ListUsageResponse
        /// </returns>
        public async Task<ListUsageResponse> ListUsageAsync(ListUsageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListUsageWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Scales up a disk volume that is mounted to an elastic container instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2><a href="#"></a>Usage notes</h2>
        /// <list type="bullet">
        /// <item><description>You can scale up volumes by calling this operation. You cannot scale down volumes by calling this operation.</description></item>
        /// <item><description>Only volumes of the disk type can be scaled up. Volumes of other types cannot be scaled up.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ResizeContainerGroupVolumeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ResizeContainerGroupVolumeResponse
        /// </returns>
        public ResizeContainerGroupVolumeResponse ResizeContainerGroupVolumeWithOptions(ResizeContainerGroupVolumeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContainerGroupId))
            {
                query["ContainerGroupId"] = request.ContainerGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NewSize))
            {
                query["NewSize"] = request.NewSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VolumeName))
            {
                query["VolumeName"] = request.VolumeName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ResizeContainerGroupVolume",
                Version = "2018-08-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ResizeContainerGroupVolumeResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Scales up a disk volume that is mounted to an elastic container instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2><a href="#"></a>Usage notes</h2>
        /// <list type="bullet">
        /// <item><description>You can scale up volumes by calling this operation. You cannot scale down volumes by calling this operation.</description></item>
        /// <item><description>Only volumes of the disk type can be scaled up. Volumes of other types cannot be scaled up.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ResizeContainerGroupVolumeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ResizeContainerGroupVolumeResponse
        /// </returns>
        public async Task<ResizeContainerGroupVolumeResponse> ResizeContainerGroupVolumeWithOptionsAsync(ResizeContainerGroupVolumeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContainerGroupId))
            {
                query["ContainerGroupId"] = request.ContainerGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NewSize))
            {
                query["NewSize"] = request.NewSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VolumeName))
            {
                query["VolumeName"] = request.VolumeName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ResizeContainerGroupVolume",
                Version = "2018-08-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ResizeContainerGroupVolumeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Scales up a disk volume that is mounted to an elastic container instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2><a href="#"></a>Usage notes</h2>
        /// <list type="bullet">
        /// <item><description>You can scale up volumes by calling this operation. You cannot scale down volumes by calling this operation.</description></item>
        /// <item><description>Only volumes of the disk type can be scaled up. Volumes of other types cannot be scaled up.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ResizeContainerGroupVolumeRequest
        /// </param>
        /// 
        /// <returns>
        /// ResizeContainerGroupVolumeResponse
        /// </returns>
        public ResizeContainerGroupVolumeResponse ResizeContainerGroupVolume(ResizeContainerGroupVolumeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ResizeContainerGroupVolumeWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Scales up a disk volume that is mounted to an elastic container instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2><a href="#"></a>Usage notes</h2>
        /// <list type="bullet">
        /// <item><description>You can scale up volumes by calling this operation. You cannot scale down volumes by calling this operation.</description></item>
        /// <item><description>Only volumes of the disk type can be scaled up. Volumes of other types cannot be scaled up.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ResizeContainerGroupVolumeRequest
        /// </param>
        /// 
        /// <returns>
        /// ResizeContainerGroupVolumeResponse
        /// </returns>
        public async Task<ResizeContainerGroupVolumeResponse> ResizeContainerGroupVolumeAsync(ResizeContainerGroupVolumeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ResizeContainerGroupVolumeWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Restarts an elastic container instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  Only elastic container instances that are in the Pending or Running state can be restarted. Instances that are in the Succeeded or Failed state cannot be restarted.</para>
        /// <list type="bullet">
        /// <item><description>Elastic container instances that were created before 15:00:00 on March 7, 2019 cannot be restarted.</description></item>
        /// <item><description>When an elastic container instance is being restarted, its status changes into Restarting.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// RestartContainerGroupRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RestartContainerGroupResponse
        /// </returns>
        public RestartContainerGroupResponse RestartContainerGroupWithOptions(RestartContainerGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContainerGroupId))
            {
                query["ContainerGroupId"] = request.ContainerGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RestartContainerGroup",
                Version = "2018-08-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RestartContainerGroupResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Restarts an elastic container instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  Only elastic container instances that are in the Pending or Running state can be restarted. Instances that are in the Succeeded or Failed state cannot be restarted.</para>
        /// <list type="bullet">
        /// <item><description>Elastic container instances that were created before 15:00:00 on March 7, 2019 cannot be restarted.</description></item>
        /// <item><description>When an elastic container instance is being restarted, its status changes into Restarting.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// RestartContainerGroupRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RestartContainerGroupResponse
        /// </returns>
        public async Task<RestartContainerGroupResponse> RestartContainerGroupWithOptionsAsync(RestartContainerGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContainerGroupId))
            {
                query["ContainerGroupId"] = request.ContainerGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RestartContainerGroup",
                Version = "2018-08-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RestartContainerGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Restarts an elastic container instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  Only elastic container instances that are in the Pending or Running state can be restarted. Instances that are in the Succeeded or Failed state cannot be restarted.</para>
        /// <list type="bullet">
        /// <item><description>Elastic container instances that were created before 15:00:00 on March 7, 2019 cannot be restarted.</description></item>
        /// <item><description>When an elastic container instance is being restarted, its status changes into Restarting.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// RestartContainerGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// RestartContainerGroupResponse
        /// </returns>
        public RestartContainerGroupResponse RestartContainerGroup(RestartContainerGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RestartContainerGroupWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Restarts an elastic container instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  Only elastic container instances that are in the Pending or Running state can be restarted. Instances that are in the Succeeded or Failed state cannot be restarted.</para>
        /// <list type="bullet">
        /// <item><description>Elastic container instances that were created before 15:00:00 on March 7, 2019 cannot be restarted.</description></item>
        /// <item><description>When an elastic container instance is being restarted, its status changes into Restarting.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// RestartContainerGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// RestartContainerGroupResponse
        /// </returns>
        public async Task<RestartContainerGroupResponse> RestartContainerGroupAsync(RestartContainerGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RestartContainerGroupWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Adds tags to an Elastic Container Instance resource.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// TagResourcesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// TagResourcesResponse
        /// </returns>
        public TagResourcesResponse TagResourcesWithOptions(TagResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceId))
            {
                query["ResourceId"] = request.ResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["ResourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                query["Tag"] = request.Tag;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TagResources",
                Version = "2018-08-08",
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Adds tags to an Elastic Container Instance resource.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// TagResourcesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// TagResourcesResponse
        /// </returns>
        public async Task<TagResourcesResponse> TagResourcesWithOptionsAsync(TagResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceId))
            {
                query["ResourceId"] = request.ResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["ResourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                query["Tag"] = request.Tag;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TagResources",
                Version = "2018-08-08",
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Adds tags to an Elastic Container Instance resource.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// TagResourcesRequest
        /// </param>
        /// 
        /// <returns>
        /// TagResourcesResponse
        /// </returns>
        public TagResourcesResponse TagResources(TagResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return TagResourcesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Adds tags to an Elastic Container Instance resource.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// TagResourcesRequest
        /// </param>
        /// 
        /// <returns>
        /// TagResourcesResponse
        /// </returns>
        public async Task<TagResourcesResponse> TagResourcesAsync(TagResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await TagResourcesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Removes tags from an Elastic Container Instance resource.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UntagResourcesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UntagResourcesResponse
        /// </returns>
        public UntagResourcesResponse UntagResourcesWithOptions(UntagResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.All))
            {
                query["All"] = request.All;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceId))
            {
                query["ResourceId"] = request.ResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["ResourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagKey))
            {
                query["TagKey"] = request.TagKey;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UntagResources",
                Version = "2018-08-08",
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Removes tags from an Elastic Container Instance resource.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UntagResourcesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UntagResourcesResponse
        /// </returns>
        public async Task<UntagResourcesResponse> UntagResourcesWithOptionsAsync(UntagResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.All))
            {
                query["All"] = request.All;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceId))
            {
                query["ResourceId"] = request.ResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["ResourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagKey))
            {
                query["TagKey"] = request.TagKey;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UntagResources",
                Version = "2018-08-08",
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Removes tags from an Elastic Container Instance resource.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UntagResourcesRequest
        /// </param>
        /// 
        /// <returns>
        /// UntagResourcesResponse
        /// </returns>
        public UntagResourcesResponse UntagResources(UntagResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UntagResourcesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Removes tags from an Elastic Container Instance resource.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UntagResourcesRequest
        /// </param>
        /// 
        /// <returns>
        /// UntagResourcesResponse
        /// </returns>
        public async Task<UntagResourcesResponse> UntagResourcesAsync(UntagResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UntagResourcesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates an elastic container instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  Only elastic container instances that are in the Pending or Running state can be updated. After you call this operation to update an elastic container instance, the instance enters the Updating state.</para>
        /// <list type="bullet">
        /// <item><description>If the RestartPolicy parameter is set to Never for the elastic container instance that you are updating, the containers of the instance may fail. Exercise caution if you want to update the kind of instances.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateContainerGroupRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateContainerGroupResponse
        /// </returns>
        public UpdateContainerGroupResponse UpdateContainerGroupWithOptions(UpdateContainerGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AcrRegistryInfo))
            {
                query["AcrRegistryInfo"] = request.AcrRegistryInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Container))
            {
                query["Container"] = request.Container;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContainerGroupId))
            {
                query["ContainerGroupId"] = request.ContainerGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cpu))
            {
                query["Cpu"] = request.Cpu;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageRegistryCredential))
            {
                query["ImageRegistryCredential"] = request.ImageRegistryCredential;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InitContainer))
            {
                query["InitContainer"] = request.InitContainer;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Memory))
            {
                query["Memory"] = request.Memory;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RestartPolicy))
            {
                query["RestartPolicy"] = request.RestartPolicy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                query["Tag"] = request.Tag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UpdateType))
            {
                query["UpdateType"] = request.UpdateType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Volume))
            {
                query["Volume"] = request.Volume;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DnsConfig))
            {
                query["DnsConfig"] = request.DnsConfig;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateContainerGroup",
                Version = "2018-08-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateContainerGroupResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates an elastic container instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  Only elastic container instances that are in the Pending or Running state can be updated. After you call this operation to update an elastic container instance, the instance enters the Updating state.</para>
        /// <list type="bullet">
        /// <item><description>If the RestartPolicy parameter is set to Never for the elastic container instance that you are updating, the containers of the instance may fail. Exercise caution if you want to update the kind of instances.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateContainerGroupRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateContainerGroupResponse
        /// </returns>
        public async Task<UpdateContainerGroupResponse> UpdateContainerGroupWithOptionsAsync(UpdateContainerGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AcrRegistryInfo))
            {
                query["AcrRegistryInfo"] = request.AcrRegistryInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Container))
            {
                query["Container"] = request.Container;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ContainerGroupId))
            {
                query["ContainerGroupId"] = request.ContainerGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Cpu))
            {
                query["Cpu"] = request.Cpu;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageRegistryCredential))
            {
                query["ImageRegistryCredential"] = request.ImageRegistryCredential;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InitContainer))
            {
                query["InitContainer"] = request.InitContainer;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Memory))
            {
                query["Memory"] = request.Memory;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RestartPolicy))
            {
                query["RestartPolicy"] = request.RestartPolicy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                query["Tag"] = request.Tag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UpdateType))
            {
                query["UpdateType"] = request.UpdateType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Volume))
            {
                query["Volume"] = request.Volume;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DnsConfig))
            {
                query["DnsConfig"] = request.DnsConfig;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateContainerGroup",
                Version = "2018-08-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateContainerGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates an elastic container instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  Only elastic container instances that are in the Pending or Running state can be updated. After you call this operation to update an elastic container instance, the instance enters the Updating state.</para>
        /// <list type="bullet">
        /// <item><description>If the RestartPolicy parameter is set to Never for the elastic container instance that you are updating, the containers of the instance may fail. Exercise caution if you want to update the kind of instances.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateContainerGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateContainerGroupResponse
        /// </returns>
        public UpdateContainerGroupResponse UpdateContainerGroup(UpdateContainerGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateContainerGroupWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates an elastic container instance.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  Only elastic container instances that are in the Pending or Running state can be updated. After you call this operation to update an elastic container instance, the instance enters the Updating state.</para>
        /// <list type="bullet">
        /// <item><description>If the RestartPolicy parameter is set to Never for the elastic container instance that you are updating, the containers of the instance may fail. Exercise caution if you want to update the kind of instances.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateContainerGroupRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateContainerGroupResponse
        /// </returns>
        public async Task<UpdateContainerGroupResponse> UpdateContainerGroupAsync(UpdateContainerGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateContainerGroupWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates a data cache.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateDataCacheRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateDataCacheResponse
        /// </returns>
        public UpdateDataCacheResponse UpdateDataCacheWithOptions(UpdateDataCacheRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Bucket))
            {
                query["Bucket"] = request.Bucket;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataCacheId))
            {
                query["DataCacheId"] = request.DataCacheId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSource))
            {
                query["DataSource"] = request.DataSource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EipCreateParam))
            {
                query["EipCreateParam"] = request.EipCreateParam;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EipInstanceId))
            {
                query["EipInstanceId"] = request.EipInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RetentionDays))
            {
                query["RetentionDays"] = request.RetentionDays;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityGroupId))
            {
                query["SecurityGroupId"] = request.SecurityGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Size))
            {
                query["Size"] = request.Size;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                query["Tag"] = request.Tag;
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
                Action = "UpdateDataCache",
                Version = "2018-08-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateDataCacheResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates a data cache.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateDataCacheRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateDataCacheResponse
        /// </returns>
        public async Task<UpdateDataCacheResponse> UpdateDataCacheWithOptionsAsync(UpdateDataCacheRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Bucket))
            {
                query["Bucket"] = request.Bucket;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataCacheId))
            {
                query["DataCacheId"] = request.DataCacheId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DataSource))
            {
                query["DataSource"] = request.DataSource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EipCreateParam))
            {
                query["EipCreateParam"] = request.EipCreateParam;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EipInstanceId))
            {
                query["EipInstanceId"] = request.EipInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RetentionDays))
            {
                query["RetentionDays"] = request.RetentionDays;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityGroupId))
            {
                query["SecurityGroupId"] = request.SecurityGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Size))
            {
                query["Size"] = request.Size;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                query["Tag"] = request.Tag;
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
                Action = "UpdateDataCache",
                Version = "2018-08-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateDataCacheResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates a data cache.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateDataCacheRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateDataCacheResponse
        /// </returns>
        public UpdateDataCacheResponse UpdateDataCache(UpdateDataCacheRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateDataCacheWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates a data cache.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateDataCacheRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateDataCacheResponse
        /// </returns>
        public async Task<UpdateDataCacheResponse> UpdateDataCacheAsync(UpdateDataCacheRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateDataCacheWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates an image cache.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Only image caches that are in the Ready or UpdateFailed state can be updated.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateImageCacheRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateImageCacheResponse
        /// </returns>
        public UpdateImageCacheResponse UpdateImageCacheWithOptions(UpdateImageCacheRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AcrRegistryInfo))
            {
                query["AcrRegistryInfo"] = request.AcrRegistryInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoMatchImageCache))
            {
                query["AutoMatchImageCache"] = request.AutoMatchImageCache;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EipInstanceId))
            {
                query["EipInstanceId"] = request.EipInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EliminationStrategy))
            {
                query["EliminationStrategy"] = request.EliminationStrategy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Flash))
            {
                query["Flash"] = request.Flash;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FlashCopyCount))
            {
                query["FlashCopyCount"] = request.FlashCopyCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Image))
            {
                query["Image"] = request.Image;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageCacheId))
            {
                query["ImageCacheId"] = request.ImageCacheId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageCacheName))
            {
                query["ImageCacheName"] = request.ImageCacheName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageCacheSize))
            {
                query["ImageCacheSize"] = request.ImageCacheSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageRegistryCredential))
            {
                query["ImageRegistryCredential"] = request.ImageRegistryCredential;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RetentionDays))
            {
                query["RetentionDays"] = request.RetentionDays;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityGroupId))
            {
                query["SecurityGroupId"] = request.SecurityGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StandardCopyCount))
            {
                query["StandardCopyCount"] = request.StandardCopyCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                query["Tag"] = request.Tag;
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
                Action = "UpdateImageCache",
                Version = "2018-08-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateImageCacheResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates an image cache.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Only image caches that are in the Ready or UpdateFailed state can be updated.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateImageCacheRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateImageCacheResponse
        /// </returns>
        public async Task<UpdateImageCacheResponse> UpdateImageCacheWithOptionsAsync(UpdateImageCacheRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AcrRegistryInfo))
            {
                query["AcrRegistryInfo"] = request.AcrRegistryInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoMatchImageCache))
            {
                query["AutoMatchImageCache"] = request.AutoMatchImageCache;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EipInstanceId))
            {
                query["EipInstanceId"] = request.EipInstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EliminationStrategy))
            {
                query["EliminationStrategy"] = request.EliminationStrategy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Flash))
            {
                query["Flash"] = request.Flash;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FlashCopyCount))
            {
                query["FlashCopyCount"] = request.FlashCopyCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Image))
            {
                query["Image"] = request.Image;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageCacheId))
            {
                query["ImageCacheId"] = request.ImageCacheId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageCacheName))
            {
                query["ImageCacheName"] = request.ImageCacheName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageCacheSize))
            {
                query["ImageCacheSize"] = request.ImageCacheSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageRegistryCredential))
            {
                query["ImageRegistryCredential"] = request.ImageRegistryCredential;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RetentionDays))
            {
                query["RetentionDays"] = request.RetentionDays;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityGroupId))
            {
                query["SecurityGroupId"] = request.SecurityGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StandardCopyCount))
            {
                query["StandardCopyCount"] = request.StandardCopyCount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                query["Tag"] = request.Tag;
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
                Action = "UpdateImageCache",
                Version = "2018-08-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateImageCacheResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates an image cache.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Only image caches that are in the Ready or UpdateFailed state can be updated.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateImageCacheRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateImageCacheResponse
        /// </returns>
        public UpdateImageCacheResponse UpdateImageCache(UpdateImageCacheRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateImageCacheWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates an image cache.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Only image caches that are in the Ready or UpdateFailed state can be updated.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateImageCacheRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateImageCacheResponse
        /// </returns>
        public async Task<UpdateImageCacheResponse> UpdateImageCacheAsync(UpdateImageCacheRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateImageCacheWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates attributes of a virtual node.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Usage notes</h2>
        /// <para>Only virtual nodes that are in the Ready state can be updated.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateVirtualNodeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateVirtualNodeResponse
        /// </returns>
        public UpdateVirtualNodeResponse UpdateVirtualNodeWithOptions(UpdateVirtualNodeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterDNS))
            {
                query["ClusterDNS"] = request.ClusterDNS;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterDomain))
            {
                query["ClusterDomain"] = request.ClusterDomain;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomResources))
            {
                query["CustomResources"] = request.CustomResources;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                query["Tag"] = request.Tag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VirtualNodeId))
            {
                query["VirtualNodeId"] = request.VirtualNodeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VirtualNodeName))
            {
                query["VirtualNodeName"] = request.VirtualNodeName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateVirtualNode",
                Version = "2018-08-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateVirtualNodeResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates attributes of a virtual node.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Usage notes</h2>
        /// <para>Only virtual nodes that are in the Ready state can be updated.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateVirtualNodeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateVirtualNodeResponse
        /// </returns>
        public async Task<UpdateVirtualNodeResponse> UpdateVirtualNodeWithOptionsAsync(UpdateVirtualNodeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterDNS))
            {
                query["ClusterDNS"] = request.ClusterDNS;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClusterDomain))
            {
                query["ClusterDomain"] = request.ClusterDomain;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CustomResources))
            {
                query["CustomResources"] = request.CustomResources;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerAccount))
            {
                query["OwnerAccount"] = request.OwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OwnerId))
            {
                query["OwnerId"] = request.OwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerAccount))
            {
                query["ResourceOwnerAccount"] = request.ResourceOwnerAccount;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceOwnerId))
            {
                query["ResourceOwnerId"] = request.ResourceOwnerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                query["Tag"] = request.Tag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VirtualNodeId))
            {
                query["VirtualNodeId"] = request.VirtualNodeId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VirtualNodeName))
            {
                query["VirtualNodeName"] = request.VirtualNodeName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateVirtualNode",
                Version = "2018-08-08",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateVirtualNodeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates attributes of a virtual node.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Usage notes</h2>
        /// <para>Only virtual nodes that are in the Ready state can be updated.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateVirtualNodeRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateVirtualNodeResponse
        /// </returns>
        public UpdateVirtualNodeResponse UpdateVirtualNode(UpdateVirtualNodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateVirtualNodeWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates attributes of a virtual node.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Usage notes</h2>
        /// <para>Only virtual nodes that are in the Ready state can be updated.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateVirtualNodeRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateVirtualNodeResponse
        /// </returns>
        public async Task<UpdateVirtualNodeResponse> UpdateVirtualNodeAsync(UpdateVirtualNodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateVirtualNodeWithOptionsAsync(request, runtime);
        }

    }
}
