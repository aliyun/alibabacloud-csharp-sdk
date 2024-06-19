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

        /**
         * @summary Creates an asynchronous task to store a specified container in an elastic container instance as an image and pushes the image to an image repository of Alibaba Cloud Container Registry.
         *
         * @description You must specify the Alibaba Cloud Resource Name (ARN) of the RAM role of the Container Registry Enterprise Edition instance to grant the elastic container instance to assume the RAM role to push images.
         *
         * @param request CommitContainerRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CommitContainerResponse
         */
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

        /**
         * @summary Creates an asynchronous task to store a specified container in an elastic container instance as an image and pushes the image to an image repository of Alibaba Cloud Container Registry.
         *
         * @description You must specify the Alibaba Cloud Resource Name (ARN) of the RAM role of the Container Registry Enterprise Edition instance to grant the elastic container instance to assume the RAM role to push images.
         *
         * @param request CommitContainerRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CommitContainerResponse
         */
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

        /**
         * @summary Creates an asynchronous task to store a specified container in an elastic container instance as an image and pushes the image to an image repository of Alibaba Cloud Container Registry.
         *
         * @description You must specify the Alibaba Cloud Resource Name (ARN) of the RAM role of the Container Registry Enterprise Edition instance to grant the elastic container instance to assume the RAM role to push images.
         *
         * @param request CommitContainerRequest
         * @return CommitContainerResponse
         */
        public CommitContainerResponse CommitContainer(CommitContainerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CommitContainerWithOptions(request, runtime);
        }

        /**
         * @summary Creates an asynchronous task to store a specified container in an elastic container instance as an image and pushes the image to an image repository of Alibaba Cloud Container Registry.
         *
         * @description You must specify the Alibaba Cloud Resource Name (ARN) of the RAM role of the Container Registry Enterprise Edition instance to grant the elastic container instance to assume the RAM role to push images.
         *
         * @param request CommitContainerRequest
         * @return CommitContainerResponse
         */
        public async Task<CommitContainerResponse> CommitContainerAsync(CommitContainerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CommitContainerWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Copies a DataCache from one region to another region.
         *
         * @description You cannot directly use a DataCache across regions. You can call this operation to copy a DataCache from one region to another region. This operation is suitable for the following scenarios:
         * *   If you want to use a DataCache across regions and the DataCache exists in Region A, you can call this operation to quickly copy the DataCache to Region B.
         * *   If you directly pull data from a region outside China to a region inside the Chinese mainland when you create a DataCache, the data may be pulled at a slow speed due to network limits. In this case, you can create a DataCache in a region outside the Chinese mainland but inside China, such as the China (Hong Kong) region, and call this operation to copy the data to the region inside the Chinese mainland.
         * > The process of copying a DataCache is equivalent to copying a snapshot. You are charged for the traffic generated during the copy process and the storage of the generated DataCache.
         *
         * @param request CopyDataCacheRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CopyDataCacheResponse
         */
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

        /**
         * @summary Copies a DataCache from one region to another region.
         *
         * @description You cannot directly use a DataCache across regions. You can call this operation to copy a DataCache from one region to another region. This operation is suitable for the following scenarios:
         * *   If you want to use a DataCache across regions and the DataCache exists in Region A, you can call this operation to quickly copy the DataCache to Region B.
         * *   If you directly pull data from a region outside China to a region inside the Chinese mainland when you create a DataCache, the data may be pulled at a slow speed due to network limits. In this case, you can create a DataCache in a region outside the Chinese mainland but inside China, such as the China (Hong Kong) region, and call this operation to copy the data to the region inside the Chinese mainland.
         * > The process of copying a DataCache is equivalent to copying a snapshot. You are charged for the traffic generated during the copy process and the storage of the generated DataCache.
         *
         * @param request CopyDataCacheRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CopyDataCacheResponse
         */
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

        /**
         * @summary Copies a DataCache from one region to another region.
         *
         * @description You cannot directly use a DataCache across regions. You can call this operation to copy a DataCache from one region to another region. This operation is suitable for the following scenarios:
         * *   If you want to use a DataCache across regions and the DataCache exists in Region A, you can call this operation to quickly copy the DataCache to Region B.
         * *   If you directly pull data from a region outside China to a region inside the Chinese mainland when you create a DataCache, the data may be pulled at a slow speed due to network limits. In this case, you can create a DataCache in a region outside the Chinese mainland but inside China, such as the China (Hong Kong) region, and call this operation to copy the data to the region inside the Chinese mainland.
         * > The process of copying a DataCache is equivalent to copying a snapshot. You are charged for the traffic generated during the copy process and the storage of the generated DataCache.
         *
         * @param request CopyDataCacheRequest
         * @return CopyDataCacheResponse
         */
        public CopyDataCacheResponse CopyDataCache(CopyDataCacheRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CopyDataCacheWithOptions(request, runtime);
        }

        /**
         * @summary Copies a DataCache from one region to another region.
         *
         * @description You cannot directly use a DataCache across regions. You can call this operation to copy a DataCache from one region to another region. This operation is suitable for the following scenarios:
         * *   If you want to use a DataCache across regions and the DataCache exists in Region A, you can call this operation to quickly copy the DataCache to Region B.
         * *   If you directly pull data from a region outside China to a region inside the Chinese mainland when you create a DataCache, the data may be pulled at a slow speed due to network limits. In this case, you can create a DataCache in a region outside the Chinese mainland but inside China, such as the China (Hong Kong) region, and call this operation to copy the data to the region inside the Chinese mainland.
         * > The process of copying a DataCache is equivalent to copying a snapshot. You are charged for the traffic generated during the copy process and the storage of the generated DataCache.
         *
         * @param request CopyDataCacheRequest
         * @return CopyDataCacheResponse
         */
        public async Task<CopyDataCacheResponse> CopyDataCacheAsync(CopyDataCacheRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CopyDataCacheWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Creates an elastic container instance.
         *
         * @description When you call the CreateContainerGroup operation to create an elastic container instance, the system automatically creates a service-linked role named AliyunServiceRoleForECI. You can assume the service-linked role to access relevant cloud services such as Elastic Compute Service (ECS) and Virtual Private Cloud (VPC). For more information, see [Elastic Container Instance service-linked role](https://help.aliyun.com/document_detail/212914.html).
         * When you create an elastic container instance, you can configure features that are related to instances, images, and storage based on your business requirements. For information about parameters configured for the features and the description of the parameters, see the following documents:
         * **Instances**
         * You can use one of the following methods to create an elastic container instance:
         * *   [Specify the number of vCPUs and memory size to create an elastic container instance](https://help.aliyun.com/document_detail/114662.html)
         * *   [Specify ECS instance types to create an elastic container instance](https://help.aliyun.com/document_detail/114664.html)
         * Both the preceding creation methods support the following features:
         * *   [Create a preemptible elastic container instance](https://help.aliyun.com/document_detail/157759.html)
         * *   [Configure multiple zones](https://help.aliyun.com/document_detail/157290.html)
         * *   [Configure multiple specifications](https://help.aliyun.com/document_detail/146468.html)
         * *   [Use tags to manage elastic container instances](https://help.aliyun.com/document_detail/146608.html)
         * **Images**
         * *   [Configure a container image](https://help.aliyun.com/document_detail/461311.html)
         * *   [Use the image cache feature to accelerate the creation of an elastic container instance](https://help.aliyun.com/document_detail/141281.html)
         * *   [Specify a Container Registry Enterprise Edition instance](https://help.aliyun.com/document_detail/194250.html)
         * *   [Use self-managed image repositories](https://help.aliyun.com/document_detail/378059.html)
         * **Networking**
         * *   [Create and Associate an EIP](https://help.aliyun.com/document_detail/99146.html)
         * *   [Assign a security group](https://help.aliyun.com/document_detail/176237.html)
         * *   [Assign an IPv6 address to an elastic container instance](https://help.aliyun.com/document_detail/451282.html)
         * *   [Configure maximum bandwidth](https://help.aliyun.com/document_detail/190635.html)
         * **Storage**
         * *   [Mount a disk volume](https://help.aliyun.com/document_detail/144571.html)
         * *   [Mount a NAS volume](https://help.aliyun.com/document_detail/464075.html)
         * *   [Mount an OSS bucket to an elastic container instance as a volume](https://help.aliyun.com/document_detail/464076.html)
         * *   [Mount an emptyDir volume](https://help.aliyun.com/document_detail/464078.html)
         * *   [Mount a ConfigFile volume](https://help.aliyun.com/document_detail/464080.html)
         * *   [Increase the size of the temporary storage space](https://help.aliyun.com/document_detail/204066.html)
         * **Container configuration**
         * *   [Configure startup commands and arguments for a container](https://help.aliyun.com/document_detail/94593.html)
         * *   [Use probes to perform health checks on a container](https://help.aliyun.com/document_detail/99053.html)
         * *   [Obtain metadata by using environment variables](https://help.aliyun.com/document_detail/141788.html)
         * *   [Configure a security context for an elastic container instance or a container](https://help.aliyun.com/document_detail/462313.html)
         * *   [Configure the NTP service](https://help.aliyun.com/document_detail/462768.html)
         * **Logging and O\\&M**
         * *   [Use environment variables to configure log collection](https://help.aliyun.com/document_detail/121973.html)
         * *   [Save core files to volumes](https://help.aliyun.com/document_detail/167801.html)
         *
         * @param request CreateContainerGroupRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateContainerGroupResponse
         */
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

        /**
         * @summary Creates an elastic container instance.
         *
         * @description When you call the CreateContainerGroup operation to create an elastic container instance, the system automatically creates a service-linked role named AliyunServiceRoleForECI. You can assume the service-linked role to access relevant cloud services such as Elastic Compute Service (ECS) and Virtual Private Cloud (VPC). For more information, see [Elastic Container Instance service-linked role](https://help.aliyun.com/document_detail/212914.html).
         * When you create an elastic container instance, you can configure features that are related to instances, images, and storage based on your business requirements. For information about parameters configured for the features and the description of the parameters, see the following documents:
         * **Instances**
         * You can use one of the following methods to create an elastic container instance:
         * *   [Specify the number of vCPUs and memory size to create an elastic container instance](https://help.aliyun.com/document_detail/114662.html)
         * *   [Specify ECS instance types to create an elastic container instance](https://help.aliyun.com/document_detail/114664.html)
         * Both the preceding creation methods support the following features:
         * *   [Create a preemptible elastic container instance](https://help.aliyun.com/document_detail/157759.html)
         * *   [Configure multiple zones](https://help.aliyun.com/document_detail/157290.html)
         * *   [Configure multiple specifications](https://help.aliyun.com/document_detail/146468.html)
         * *   [Use tags to manage elastic container instances](https://help.aliyun.com/document_detail/146608.html)
         * **Images**
         * *   [Configure a container image](https://help.aliyun.com/document_detail/461311.html)
         * *   [Use the image cache feature to accelerate the creation of an elastic container instance](https://help.aliyun.com/document_detail/141281.html)
         * *   [Specify a Container Registry Enterprise Edition instance](https://help.aliyun.com/document_detail/194250.html)
         * *   [Use self-managed image repositories](https://help.aliyun.com/document_detail/378059.html)
         * **Networking**
         * *   [Create and Associate an EIP](https://help.aliyun.com/document_detail/99146.html)
         * *   [Assign a security group](https://help.aliyun.com/document_detail/176237.html)
         * *   [Assign an IPv6 address to an elastic container instance](https://help.aliyun.com/document_detail/451282.html)
         * *   [Configure maximum bandwidth](https://help.aliyun.com/document_detail/190635.html)
         * **Storage**
         * *   [Mount a disk volume](https://help.aliyun.com/document_detail/144571.html)
         * *   [Mount a NAS volume](https://help.aliyun.com/document_detail/464075.html)
         * *   [Mount an OSS bucket to an elastic container instance as a volume](https://help.aliyun.com/document_detail/464076.html)
         * *   [Mount an emptyDir volume](https://help.aliyun.com/document_detail/464078.html)
         * *   [Mount a ConfigFile volume](https://help.aliyun.com/document_detail/464080.html)
         * *   [Increase the size of the temporary storage space](https://help.aliyun.com/document_detail/204066.html)
         * **Container configuration**
         * *   [Configure startup commands and arguments for a container](https://help.aliyun.com/document_detail/94593.html)
         * *   [Use probes to perform health checks on a container](https://help.aliyun.com/document_detail/99053.html)
         * *   [Obtain metadata by using environment variables](https://help.aliyun.com/document_detail/141788.html)
         * *   [Configure a security context for an elastic container instance or a container](https://help.aliyun.com/document_detail/462313.html)
         * *   [Configure the NTP service](https://help.aliyun.com/document_detail/462768.html)
         * **Logging and O\\&M**
         * *   [Use environment variables to configure log collection](https://help.aliyun.com/document_detail/121973.html)
         * *   [Save core files to volumes](https://help.aliyun.com/document_detail/167801.html)
         *
         * @param request CreateContainerGroupRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateContainerGroupResponse
         */
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

        /**
         * @summary Creates an elastic container instance.
         *
         * @description When you call the CreateContainerGroup operation to create an elastic container instance, the system automatically creates a service-linked role named AliyunServiceRoleForECI. You can assume the service-linked role to access relevant cloud services such as Elastic Compute Service (ECS) and Virtual Private Cloud (VPC). For more information, see [Elastic Container Instance service-linked role](https://help.aliyun.com/document_detail/212914.html).
         * When you create an elastic container instance, you can configure features that are related to instances, images, and storage based on your business requirements. For information about parameters configured for the features and the description of the parameters, see the following documents:
         * **Instances**
         * You can use one of the following methods to create an elastic container instance:
         * *   [Specify the number of vCPUs and memory size to create an elastic container instance](https://help.aliyun.com/document_detail/114662.html)
         * *   [Specify ECS instance types to create an elastic container instance](https://help.aliyun.com/document_detail/114664.html)
         * Both the preceding creation methods support the following features:
         * *   [Create a preemptible elastic container instance](https://help.aliyun.com/document_detail/157759.html)
         * *   [Configure multiple zones](https://help.aliyun.com/document_detail/157290.html)
         * *   [Configure multiple specifications](https://help.aliyun.com/document_detail/146468.html)
         * *   [Use tags to manage elastic container instances](https://help.aliyun.com/document_detail/146608.html)
         * **Images**
         * *   [Configure a container image](https://help.aliyun.com/document_detail/461311.html)
         * *   [Use the image cache feature to accelerate the creation of an elastic container instance](https://help.aliyun.com/document_detail/141281.html)
         * *   [Specify a Container Registry Enterprise Edition instance](https://help.aliyun.com/document_detail/194250.html)
         * *   [Use self-managed image repositories](https://help.aliyun.com/document_detail/378059.html)
         * **Networking**
         * *   [Create and Associate an EIP](https://help.aliyun.com/document_detail/99146.html)
         * *   [Assign a security group](https://help.aliyun.com/document_detail/176237.html)
         * *   [Assign an IPv6 address to an elastic container instance](https://help.aliyun.com/document_detail/451282.html)
         * *   [Configure maximum bandwidth](https://help.aliyun.com/document_detail/190635.html)
         * **Storage**
         * *   [Mount a disk volume](https://help.aliyun.com/document_detail/144571.html)
         * *   [Mount a NAS volume](https://help.aliyun.com/document_detail/464075.html)
         * *   [Mount an OSS bucket to an elastic container instance as a volume](https://help.aliyun.com/document_detail/464076.html)
         * *   [Mount an emptyDir volume](https://help.aliyun.com/document_detail/464078.html)
         * *   [Mount a ConfigFile volume](https://help.aliyun.com/document_detail/464080.html)
         * *   [Increase the size of the temporary storage space](https://help.aliyun.com/document_detail/204066.html)
         * **Container configuration**
         * *   [Configure startup commands and arguments for a container](https://help.aliyun.com/document_detail/94593.html)
         * *   [Use probes to perform health checks on a container](https://help.aliyun.com/document_detail/99053.html)
         * *   [Obtain metadata by using environment variables](https://help.aliyun.com/document_detail/141788.html)
         * *   [Configure a security context for an elastic container instance or a container](https://help.aliyun.com/document_detail/462313.html)
         * *   [Configure the NTP service](https://help.aliyun.com/document_detail/462768.html)
         * **Logging and O\\&M**
         * *   [Use environment variables to configure log collection](https://help.aliyun.com/document_detail/121973.html)
         * *   [Save core files to volumes](https://help.aliyun.com/document_detail/167801.html)
         *
         * @param request CreateContainerGroupRequest
         * @return CreateContainerGroupResponse
         */
        public CreateContainerGroupResponse CreateContainerGroup(CreateContainerGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateContainerGroupWithOptions(request, runtime);
        }

        /**
         * @summary Creates an elastic container instance.
         *
         * @description When you call the CreateContainerGroup operation to create an elastic container instance, the system automatically creates a service-linked role named AliyunServiceRoleForECI. You can assume the service-linked role to access relevant cloud services such as Elastic Compute Service (ECS) and Virtual Private Cloud (VPC). For more information, see [Elastic Container Instance service-linked role](https://help.aliyun.com/document_detail/212914.html).
         * When you create an elastic container instance, you can configure features that are related to instances, images, and storage based on your business requirements. For information about parameters configured for the features and the description of the parameters, see the following documents:
         * **Instances**
         * You can use one of the following methods to create an elastic container instance:
         * *   [Specify the number of vCPUs and memory size to create an elastic container instance](https://help.aliyun.com/document_detail/114662.html)
         * *   [Specify ECS instance types to create an elastic container instance](https://help.aliyun.com/document_detail/114664.html)
         * Both the preceding creation methods support the following features:
         * *   [Create a preemptible elastic container instance](https://help.aliyun.com/document_detail/157759.html)
         * *   [Configure multiple zones](https://help.aliyun.com/document_detail/157290.html)
         * *   [Configure multiple specifications](https://help.aliyun.com/document_detail/146468.html)
         * *   [Use tags to manage elastic container instances](https://help.aliyun.com/document_detail/146608.html)
         * **Images**
         * *   [Configure a container image](https://help.aliyun.com/document_detail/461311.html)
         * *   [Use the image cache feature to accelerate the creation of an elastic container instance](https://help.aliyun.com/document_detail/141281.html)
         * *   [Specify a Container Registry Enterprise Edition instance](https://help.aliyun.com/document_detail/194250.html)
         * *   [Use self-managed image repositories](https://help.aliyun.com/document_detail/378059.html)
         * **Networking**
         * *   [Create and Associate an EIP](https://help.aliyun.com/document_detail/99146.html)
         * *   [Assign a security group](https://help.aliyun.com/document_detail/176237.html)
         * *   [Assign an IPv6 address to an elastic container instance](https://help.aliyun.com/document_detail/451282.html)
         * *   [Configure maximum bandwidth](https://help.aliyun.com/document_detail/190635.html)
         * **Storage**
         * *   [Mount a disk volume](https://help.aliyun.com/document_detail/144571.html)
         * *   [Mount a NAS volume](https://help.aliyun.com/document_detail/464075.html)
         * *   [Mount an OSS bucket to an elastic container instance as a volume](https://help.aliyun.com/document_detail/464076.html)
         * *   [Mount an emptyDir volume](https://help.aliyun.com/document_detail/464078.html)
         * *   [Mount a ConfigFile volume](https://help.aliyun.com/document_detail/464080.html)
         * *   [Increase the size of the temporary storage space](https://help.aliyun.com/document_detail/204066.html)
         * **Container configuration**
         * *   [Configure startup commands and arguments for a container](https://help.aliyun.com/document_detail/94593.html)
         * *   [Use probes to perform health checks on a container](https://help.aliyun.com/document_detail/99053.html)
         * *   [Obtain metadata by using environment variables](https://help.aliyun.com/document_detail/141788.html)
         * *   [Configure a security context for an elastic container instance or a container](https://help.aliyun.com/document_detail/462313.html)
         * *   [Configure the NTP service](https://help.aliyun.com/document_detail/462768.html)
         * **Logging and O\\&M**
         * *   [Use environment variables to configure log collection](https://help.aliyun.com/document_detail/121973.html)
         * *   [Save core files to volumes](https://help.aliyun.com/document_detail/167801.html)
         *
         * @param request CreateContainerGroupRequest
         * @return CreateContainerGroupResponse
         */
        public async Task<CreateContainerGroupResponse> CreateContainerGroupAsync(CreateContainerGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateContainerGroupWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Creates a DataCache.
         *
         * @description *   You are charged for the creation of image caches. We recommend that you learn the relevant billing information in advance. For more information, see [DataCaches](https://help.aliyun.com/document_detail/2503093.html).
         * *   Before you create an image cache, you must evaluate the size of the data to be cached. If the size of the data exceeds the specified cache size, the image cache fails to be created.
         * *   When a data cache is being created, the system automatically creates a temporary elastic container instance (ECI) and an enhanced SSD (ESSD) for the data cache. During the creation, do not delete the ECI and ESSD. Otherwise, the data cache fails to be created.
         * *   When a data cache is being created, a snapshot is generated for the data cache. Do not delete the snapshot. Otherwise, the data cache becomes invalid.
         *
         * @param request CreateDataCacheRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateDataCacheResponse
         */
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

        /**
         * @summary Creates a DataCache.
         *
         * @description *   You are charged for the creation of image caches. We recommend that you learn the relevant billing information in advance. For more information, see [DataCaches](https://help.aliyun.com/document_detail/2503093.html).
         * *   Before you create an image cache, you must evaluate the size of the data to be cached. If the size of the data exceeds the specified cache size, the image cache fails to be created.
         * *   When a data cache is being created, the system automatically creates a temporary elastic container instance (ECI) and an enhanced SSD (ESSD) for the data cache. During the creation, do not delete the ECI and ESSD. Otherwise, the data cache fails to be created.
         * *   When a data cache is being created, a snapshot is generated for the data cache. Do not delete the snapshot. Otherwise, the data cache becomes invalid.
         *
         * @param request CreateDataCacheRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateDataCacheResponse
         */
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

        /**
         * @summary Creates a DataCache.
         *
         * @description *   You are charged for the creation of image caches. We recommend that you learn the relevant billing information in advance. For more information, see [DataCaches](https://help.aliyun.com/document_detail/2503093.html).
         * *   Before you create an image cache, you must evaluate the size of the data to be cached. If the size of the data exceeds the specified cache size, the image cache fails to be created.
         * *   When a data cache is being created, the system automatically creates a temporary elastic container instance (ECI) and an enhanced SSD (ESSD) for the data cache. During the creation, do not delete the ECI and ESSD. Otherwise, the data cache fails to be created.
         * *   When a data cache is being created, a snapshot is generated for the data cache. Do not delete the snapshot. Otherwise, the data cache becomes invalid.
         *
         * @param request CreateDataCacheRequest
         * @return CreateDataCacheResponse
         */
        public CreateDataCacheResponse CreateDataCache(CreateDataCacheRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateDataCacheWithOptions(request, runtime);
        }

        /**
         * @summary Creates a DataCache.
         *
         * @description *   You are charged for the creation of image caches. We recommend that you learn the relevant billing information in advance. For more information, see [DataCaches](https://help.aliyun.com/document_detail/2503093.html).
         * *   Before you create an image cache, you must evaluate the size of the data to be cached. If the size of the data exceeds the specified cache size, the image cache fails to be created.
         * *   When a data cache is being created, the system automatically creates a temporary elastic container instance (ECI) and an enhanced SSD (ESSD) for the data cache. During the creation, do not delete the ECI and ESSD. Otherwise, the data cache fails to be created.
         * *   When a data cache is being created, a snapshot is generated for the data cache. Do not delete the snapshot. Otherwise, the data cache becomes invalid.
         *
         * @param request CreateDataCacheRequest
         * @return CreateDataCacheResponse
         */
        public async Task<CreateDataCacheResponse> CreateDataCacheAsync(CreateDataCacheRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateDataCacheWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Creates an image cache. The image cache can accelerate image pulling and reduce the instance startup time when you create an elastic container instance later.
         *
         * @description *   **Precautions**
         *     *   You are charged for creation of image caches. We recommend that you learn the relevant billing information in advance. For more information about billing of image caches, see [Image caches](https://help.aliyun.com/document_detail/447682.html).
         *     *   Before you create an image cache, you must estimate the total size of the images that you want to cache. If the total size of the images exceeds the specified cache size, the image cache cannot be created.
         *     *   When an image cache is being created, the system creates an intermediate elastic container instance and an intermediate enhanced SSD (ESSD) at performance level 1 (PL1). Do not delete the intermediate instance and the ESSD while the image cache is being created. If you delete the intermediate instance or the ESSD, the image cache cannot be created.
         *     *   A temporary local snapshot and a specific number of regular snapshots are generated during the creation of the image cache. Do not delete these snapshots. If you delete these snapshots, the image cache becomes invalid.
         *     *   If you use SDKs, SDK for Java 1.0.10 or later and SDK for Python 1.0.7 or later are supported.
         * *   **Usage notes**
         *     *   For images that are created based on Container Registry Enterprise Edition instances and use custom domain names, if you want to configure password-free access to the image caches, you must use AcrRegistryInfo-related parameters to specify Container Registry instances. When you configure AcrRegistryInfo-related parameters, you must set the AcrRegistryInfo.N.InstanceId parameter.
         *     *   If the image cache that you created will be used to create more than 1,000 elastic container instances at a time, we recommend that you use the StandardCopyCount and FlashCopyCount parameters to create multiple temporary local snapshots and regular snapshots of the image. The multiple snapshots are billed based on incremental data. If no incremental data exists on the multiple snapshots, you are not charged for the multiple snapshots.
         * >  When you call the CreateImageCache operation to create an image cache, the system automatically creates a service-linked role named AliyunServiceRoleForECI. The role is used to access other Alibaba Cloud services such as Elastic Compute Service (ECS) and Virtual Private Cloud (VPC). For more information, see [Elastic Container Instance service-linked role](https://help.aliyun.com/document_detail/212914.html).
         *
         * @param request CreateImageCacheRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateImageCacheResponse
         */
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

        /**
         * @summary Creates an image cache. The image cache can accelerate image pulling and reduce the instance startup time when you create an elastic container instance later.
         *
         * @description *   **Precautions**
         *     *   You are charged for creation of image caches. We recommend that you learn the relevant billing information in advance. For more information about billing of image caches, see [Image caches](https://help.aliyun.com/document_detail/447682.html).
         *     *   Before you create an image cache, you must estimate the total size of the images that you want to cache. If the total size of the images exceeds the specified cache size, the image cache cannot be created.
         *     *   When an image cache is being created, the system creates an intermediate elastic container instance and an intermediate enhanced SSD (ESSD) at performance level 1 (PL1). Do not delete the intermediate instance and the ESSD while the image cache is being created. If you delete the intermediate instance or the ESSD, the image cache cannot be created.
         *     *   A temporary local snapshot and a specific number of regular snapshots are generated during the creation of the image cache. Do not delete these snapshots. If you delete these snapshots, the image cache becomes invalid.
         *     *   If you use SDKs, SDK for Java 1.0.10 or later and SDK for Python 1.0.7 or later are supported.
         * *   **Usage notes**
         *     *   For images that are created based on Container Registry Enterprise Edition instances and use custom domain names, if you want to configure password-free access to the image caches, you must use AcrRegistryInfo-related parameters to specify Container Registry instances. When you configure AcrRegistryInfo-related parameters, you must set the AcrRegistryInfo.N.InstanceId parameter.
         *     *   If the image cache that you created will be used to create more than 1,000 elastic container instances at a time, we recommend that you use the StandardCopyCount and FlashCopyCount parameters to create multiple temporary local snapshots and regular snapshots of the image. The multiple snapshots are billed based on incremental data. If no incremental data exists on the multiple snapshots, you are not charged for the multiple snapshots.
         * >  When you call the CreateImageCache operation to create an image cache, the system automatically creates a service-linked role named AliyunServiceRoleForECI. The role is used to access other Alibaba Cloud services such as Elastic Compute Service (ECS) and Virtual Private Cloud (VPC). For more information, see [Elastic Container Instance service-linked role](https://help.aliyun.com/document_detail/212914.html).
         *
         * @param request CreateImageCacheRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateImageCacheResponse
         */
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

        /**
         * @summary Creates an image cache. The image cache can accelerate image pulling and reduce the instance startup time when you create an elastic container instance later.
         *
         * @description *   **Precautions**
         *     *   You are charged for creation of image caches. We recommend that you learn the relevant billing information in advance. For more information about billing of image caches, see [Image caches](https://help.aliyun.com/document_detail/447682.html).
         *     *   Before you create an image cache, you must estimate the total size of the images that you want to cache. If the total size of the images exceeds the specified cache size, the image cache cannot be created.
         *     *   When an image cache is being created, the system creates an intermediate elastic container instance and an intermediate enhanced SSD (ESSD) at performance level 1 (PL1). Do not delete the intermediate instance and the ESSD while the image cache is being created. If you delete the intermediate instance or the ESSD, the image cache cannot be created.
         *     *   A temporary local snapshot and a specific number of regular snapshots are generated during the creation of the image cache. Do not delete these snapshots. If you delete these snapshots, the image cache becomes invalid.
         *     *   If you use SDKs, SDK for Java 1.0.10 or later and SDK for Python 1.0.7 or later are supported.
         * *   **Usage notes**
         *     *   For images that are created based on Container Registry Enterprise Edition instances and use custom domain names, if you want to configure password-free access to the image caches, you must use AcrRegistryInfo-related parameters to specify Container Registry instances. When you configure AcrRegistryInfo-related parameters, you must set the AcrRegistryInfo.N.InstanceId parameter.
         *     *   If the image cache that you created will be used to create more than 1,000 elastic container instances at a time, we recommend that you use the StandardCopyCount and FlashCopyCount parameters to create multiple temporary local snapshots and regular snapshots of the image. The multiple snapshots are billed based on incremental data. If no incremental data exists on the multiple snapshots, you are not charged for the multiple snapshots.
         * >  When you call the CreateImageCache operation to create an image cache, the system automatically creates a service-linked role named AliyunServiceRoleForECI. The role is used to access other Alibaba Cloud services such as Elastic Compute Service (ECS) and Virtual Private Cloud (VPC). For more information, see [Elastic Container Instance service-linked role](https://help.aliyun.com/document_detail/212914.html).
         *
         * @param request CreateImageCacheRequest
         * @return CreateImageCacheResponse
         */
        public CreateImageCacheResponse CreateImageCache(CreateImageCacheRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateImageCacheWithOptions(request, runtime);
        }

        /**
         * @summary Creates an image cache. The image cache can accelerate image pulling and reduce the instance startup time when you create an elastic container instance later.
         *
         * @description *   **Precautions**
         *     *   You are charged for creation of image caches. We recommend that you learn the relevant billing information in advance. For more information about billing of image caches, see [Image caches](https://help.aliyun.com/document_detail/447682.html).
         *     *   Before you create an image cache, you must estimate the total size of the images that you want to cache. If the total size of the images exceeds the specified cache size, the image cache cannot be created.
         *     *   When an image cache is being created, the system creates an intermediate elastic container instance and an intermediate enhanced SSD (ESSD) at performance level 1 (PL1). Do not delete the intermediate instance and the ESSD while the image cache is being created. If you delete the intermediate instance or the ESSD, the image cache cannot be created.
         *     *   A temporary local snapshot and a specific number of regular snapshots are generated during the creation of the image cache. Do not delete these snapshots. If you delete these snapshots, the image cache becomes invalid.
         *     *   If you use SDKs, SDK for Java 1.0.10 or later and SDK for Python 1.0.7 or later are supported.
         * *   **Usage notes**
         *     *   For images that are created based on Container Registry Enterprise Edition instances and use custom domain names, if you want to configure password-free access to the image caches, you must use AcrRegistryInfo-related parameters to specify Container Registry instances. When you configure AcrRegistryInfo-related parameters, you must set the AcrRegistryInfo.N.InstanceId parameter.
         *     *   If the image cache that you created will be used to create more than 1,000 elastic container instances at a time, we recommend that you use the StandardCopyCount and FlashCopyCount parameters to create multiple temporary local snapshots and regular snapshots of the image. The multiple snapshots are billed based on incremental data. If no incremental data exists on the multiple snapshots, you are not charged for the multiple snapshots.
         * >  When you call the CreateImageCache operation to create an image cache, the system automatically creates a service-linked role named AliyunServiceRoleForECI. The role is used to access other Alibaba Cloud services such as Elastic Compute Service (ECS) and Virtual Private Cloud (VPC). For more information, see [Elastic Container Instance service-linked role](https://help.aliyun.com/document_detail/212914.html).
         *
         * @param request CreateImageCacheRequest
         * @return CreateImageCacheResponse
         */
        public async Task<CreateImageCacheResponse> CreateImageCacheAsync(CreateImageCacheRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateImageCacheWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Creates an O&M task.
         *
         * @description O&M tasks are classified into:
         * *   coredump: After you enable coredump, the system generates a core dump file when a container unexpectedly stops. You can use the core dump file to analyze the exception and find out the cause of the problem. For more information, see [Enable coredump](https://help.aliyun.com/document_detail/167801.html).
         * *   tcpdump: After you enable tcpdump, the system captures network packets when a container unexpectedly stops. You can analyze the packets and locate network problems. For more information, see Enable [tcpdump](https://help.aliyun.com/document_detail/429749.html).
         *
         * @param request CreateInstanceOpsTaskRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateInstanceOpsTaskResponse
         */
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

        /**
         * @summary Creates an O&M task.
         *
         * @description O&M tasks are classified into:
         * *   coredump: After you enable coredump, the system generates a core dump file when a container unexpectedly stops. You can use the core dump file to analyze the exception and find out the cause of the problem. For more information, see [Enable coredump](https://help.aliyun.com/document_detail/167801.html).
         * *   tcpdump: After you enable tcpdump, the system captures network packets when a container unexpectedly stops. You can analyze the packets and locate network problems. For more information, see Enable [tcpdump](https://help.aliyun.com/document_detail/429749.html).
         *
         * @param request CreateInstanceOpsTaskRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateInstanceOpsTaskResponse
         */
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

        /**
         * @summary Creates an O&M task.
         *
         * @description O&M tasks are classified into:
         * *   coredump: After you enable coredump, the system generates a core dump file when a container unexpectedly stops. You can use the core dump file to analyze the exception and find out the cause of the problem. For more information, see [Enable coredump](https://help.aliyun.com/document_detail/167801.html).
         * *   tcpdump: After you enable tcpdump, the system captures network packets when a container unexpectedly stops. You can analyze the packets and locate network problems. For more information, see Enable [tcpdump](https://help.aliyun.com/document_detail/429749.html).
         *
         * @param request CreateInstanceOpsTaskRequest
         * @return CreateInstanceOpsTaskResponse
         */
        public CreateInstanceOpsTaskResponse CreateInstanceOpsTask(CreateInstanceOpsTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateInstanceOpsTaskWithOptions(request, runtime);
        }

        /**
         * @summary Creates an O&M task.
         *
         * @description O&M tasks are classified into:
         * *   coredump: After you enable coredump, the system generates a core dump file when a container unexpectedly stops. You can use the core dump file to analyze the exception and find out the cause of the problem. For more information, see [Enable coredump](https://help.aliyun.com/document_detail/167801.html).
         * *   tcpdump: After you enable tcpdump, the system captures network packets when a container unexpectedly stops. You can analyze the packets and locate network problems. For more information, see Enable [tcpdump](https://help.aliyun.com/document_detail/429749.html).
         *
         * @param request CreateInstanceOpsTaskRequest
         * @return CreateInstanceOpsTaskResponse
         */
        public async Task<CreateInstanceOpsTaskResponse> CreateInstanceOpsTaskAsync(CreateInstanceOpsTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateInstanceOpsTaskWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Creates a VNode to connect self-managed Kubernetes clusters to elastic container instances.
         *
         * @description *   When you call this operation to create a virtual node, the system automatically creates a service-linked role AliyunServiceRoleForECIVnode. This way, you can use the service-linked role to access relevant cloud services such as Elastic Container Instance, Elastic Compute Service (ECS), and Virtual Private Cloud (VPC). For more information, see [Service-linked role for virtual nodes](https://help.aliyun.com/document_detail/311014.html).
         * *   You are charged for virtual nodes based on number of virtual nodes that you use. Each virtual node has a resident node, which is equivalent to an ECI instance with 2 vCPU cores and 8 GiB memory. You are charged for virtual nodes based on elastic container instances.
         *
         * @param request CreateVirtualNodeRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateVirtualNodeResponse
         */
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

        /**
         * @summary Creates a VNode to connect self-managed Kubernetes clusters to elastic container instances.
         *
         * @description *   When you call this operation to create a virtual node, the system automatically creates a service-linked role AliyunServiceRoleForECIVnode. This way, you can use the service-linked role to access relevant cloud services such as Elastic Container Instance, Elastic Compute Service (ECS), and Virtual Private Cloud (VPC). For more information, see [Service-linked role for virtual nodes](https://help.aliyun.com/document_detail/311014.html).
         * *   You are charged for virtual nodes based on number of virtual nodes that you use. Each virtual node has a resident node, which is equivalent to an ECI instance with 2 vCPU cores and 8 GiB memory. You are charged for virtual nodes based on elastic container instances.
         *
         * @param request CreateVirtualNodeRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateVirtualNodeResponse
         */
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

        /**
         * @summary Creates a VNode to connect self-managed Kubernetes clusters to elastic container instances.
         *
         * @description *   When you call this operation to create a virtual node, the system automatically creates a service-linked role AliyunServiceRoleForECIVnode. This way, you can use the service-linked role to access relevant cloud services such as Elastic Container Instance, Elastic Compute Service (ECS), and Virtual Private Cloud (VPC). For more information, see [Service-linked role for virtual nodes](https://help.aliyun.com/document_detail/311014.html).
         * *   You are charged for virtual nodes based on number of virtual nodes that you use. Each virtual node has a resident node, which is equivalent to an ECI instance with 2 vCPU cores and 8 GiB memory. You are charged for virtual nodes based on elastic container instances.
         *
         * @param request CreateVirtualNodeRequest
         * @return CreateVirtualNodeResponse
         */
        public CreateVirtualNodeResponse CreateVirtualNode(CreateVirtualNodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateVirtualNodeWithOptions(request, runtime);
        }

        /**
         * @summary Creates a VNode to connect self-managed Kubernetes clusters to elastic container instances.
         *
         * @description *   When you call this operation to create a virtual node, the system automatically creates a service-linked role AliyunServiceRoleForECIVnode. This way, you can use the service-linked role to access relevant cloud services such as Elastic Container Instance, Elastic Compute Service (ECS), and Virtual Private Cloud (VPC). For more information, see [Service-linked role for virtual nodes](https://help.aliyun.com/document_detail/311014.html).
         * *   You are charged for virtual nodes based on number of virtual nodes that you use. Each virtual node has a resident node, which is equivalent to an ECI instance with 2 vCPU cores and 8 GiB memory. You are charged for virtual nodes based on elastic container instances.
         *
         * @param request CreateVirtualNodeRequest
         * @return CreateVirtualNodeResponse
         */
        public async Task<CreateVirtualNodeResponse> CreateVirtualNodeAsync(CreateVirtualNodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateVirtualNodeWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Deletes a container group.
         *
         * @description You can delete a container group that you no longer need. Before you delete a container group, make sure that you understand the lifecycle of container groups. For more information, see [Lifecycle of an elastic container instance](https://help.aliyun.com/document_detail/122385.html).
         *
         * @param request DeleteContainerGroupRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteContainerGroupResponse
         */
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

        /**
         * @summary Deletes a container group.
         *
         * @description You can delete a container group that you no longer need. Before you delete a container group, make sure that you understand the lifecycle of container groups. For more information, see [Lifecycle of an elastic container instance](https://help.aliyun.com/document_detail/122385.html).
         *
         * @param request DeleteContainerGroupRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteContainerGroupResponse
         */
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

        /**
         * @summary Deletes a container group.
         *
         * @description You can delete a container group that you no longer need. Before you delete a container group, make sure that you understand the lifecycle of container groups. For more information, see [Lifecycle of an elastic container instance](https://help.aliyun.com/document_detail/122385.html).
         *
         * @param request DeleteContainerGroupRequest
         * @return DeleteContainerGroupResponse
         */
        public DeleteContainerGroupResponse DeleteContainerGroup(DeleteContainerGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteContainerGroupWithOptions(request, runtime);
        }

        /**
         * @summary Deletes a container group.
         *
         * @description You can delete a container group that you no longer need. Before you delete a container group, make sure that you understand the lifecycle of container groups. For more information, see [Lifecycle of an elastic container instance](https://help.aliyun.com/document_detail/122385.html).
         *
         * @param request DeleteContainerGroupRequest
         * @return DeleteContainerGroupResponse
         */
        public async Task<DeleteContainerGroupResponse> DeleteContainerGroupAsync(DeleteContainerGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteContainerGroupWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Deletes a DataCache.
         *
         * @param request DeleteDataCacheRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteDataCacheResponse
         */
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

        /**
         * @summary Deletes a DataCache.
         *
         * @param request DeleteDataCacheRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteDataCacheResponse
         */
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

        /**
         * @summary Deletes a DataCache.
         *
         * @param request DeleteDataCacheRequest
         * @return DeleteDataCacheResponse
         */
        public DeleteDataCacheResponse DeleteDataCache(DeleteDataCacheRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteDataCacheWithOptions(request, runtime);
        }

        /**
         * @summary Deletes a DataCache.
         *
         * @param request DeleteDataCacheRequest
         * @return DeleteDataCacheResponse
         */
        public async Task<DeleteDataCacheResponse> DeleteDataCacheAsync(DeleteDataCacheRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteDataCacheWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Deletes an image cache.
         *
         * @param request DeleteImageCacheRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteImageCacheResponse
         */
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

        /**
         * @summary Deletes an image cache.
         *
         * @param request DeleteImageCacheRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteImageCacheResponse
         */
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

        /**
         * @summary Deletes an image cache.
         *
         * @param request DeleteImageCacheRequest
         * @return DeleteImageCacheResponse
         */
        public DeleteImageCacheResponse DeleteImageCache(DeleteImageCacheRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteImageCacheWithOptions(request, runtime);
        }

        /**
         * @summary Deletes an image cache.
         *
         * @param request DeleteImageCacheRequest
         * @return DeleteImageCacheResponse
         */
        public async Task<DeleteImageCacheResponse> DeleteImageCacheAsync(DeleteImageCacheRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteImageCacheWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Deletes a virtual node.
         *
         * @param request DeleteVirtualNodeRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteVirtualNodeResponse
         */
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

        /**
         * @summary Deletes a virtual node.
         *
         * @param request DeleteVirtualNodeRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteVirtualNodeResponse
         */
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

        /**
         * @summary Deletes a virtual node.
         *
         * @param request DeleteVirtualNodeRequest
         * @return DeleteVirtualNodeResponse
         */
        public DeleteVirtualNodeResponse DeleteVirtualNode(DeleteVirtualNodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteVirtualNodeWithOptions(request, runtime);
        }

        /**
         * @summary Deletes a virtual node.
         *
         * @param request DeleteVirtualNodeRequest
         * @return DeleteVirtualNodeResponse
         */
        public async Task<DeleteVirtualNodeResponse> DeleteVirtualNodeAsync(DeleteVirtualNodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteVirtualNodeWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the Elastic Compute Service (ECS) instance families that are available in a specified region and zone.
         *
         * @description When you call the CreateContainerGroup operation to create an elastic container instance, you can use the InstanceType parameter to specify ECS instance types that fit your specific needs. To ensure that the elastic container instance can be created, you can call the DescribeAvailableResource operation to query which ECS instance types and instance families are available in the specified region and zone before you create the elastic container instance.
         *
         * @param request DescribeAvailableResourceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeAvailableResourceResponse
         */
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

        /**
         * @summary Queries the Elastic Compute Service (ECS) instance families that are available in a specified region and zone.
         *
         * @description When you call the CreateContainerGroup operation to create an elastic container instance, you can use the InstanceType parameter to specify ECS instance types that fit your specific needs. To ensure that the elastic container instance can be created, you can call the DescribeAvailableResource operation to query which ECS instance types and instance families are available in the specified region and zone before you create the elastic container instance.
         *
         * @param request DescribeAvailableResourceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeAvailableResourceResponse
         */
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

        /**
         * @summary Queries the Elastic Compute Service (ECS) instance families that are available in a specified region and zone.
         *
         * @description When you call the CreateContainerGroup operation to create an elastic container instance, you can use the InstanceType parameter to specify ECS instance types that fit your specific needs. To ensure that the elastic container instance can be created, you can call the DescribeAvailableResource operation to query which ECS instance types and instance families are available in the specified region and zone before you create the elastic container instance.
         *
         * @param request DescribeAvailableResourceRequest
         * @return DescribeAvailableResourceResponse
         */
        public DescribeAvailableResourceResponse DescribeAvailableResource(DescribeAvailableResourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeAvailableResourceWithOptions(request, runtime);
        }

        /**
         * @summary Queries the Elastic Compute Service (ECS) instance families that are available in a specified region and zone.
         *
         * @description When you call the CreateContainerGroup operation to create an elastic container instance, you can use the InstanceType parameter to specify ECS instance types that fit your specific needs. To ensure that the elastic container instance can be created, you can call the DescribeAvailableResource operation to query which ECS instance types and instance families are available in the specified region and zone before you create the elastic container instance.
         *
         * @param request DescribeAvailableResourceRequest
         * @return DescribeAvailableResourceResponse
         */
        public async Task<DescribeAvailableResourceResponse> DescribeAvailableResourceAsync(DescribeAvailableResourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeAvailableResourceWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the details of a CommitContainer task.
         *
         * @param request DescribeCommitContainerTaskRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeCommitContainerTaskResponse
         */
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

        /**
         * @summary Queries the details of a CommitContainer task.
         *
         * @param request DescribeCommitContainerTaskRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeCommitContainerTaskResponse
         */
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

        /**
         * @summary Queries the details of a CommitContainer task.
         *
         * @param request DescribeCommitContainerTaskRequest
         * @return DescribeCommitContainerTaskResponse
         */
        public DescribeCommitContainerTaskResponse DescribeCommitContainerTask(DescribeCommitContainerTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeCommitContainerTaskWithOptions(request, runtime);
        }

        /**
         * @summary Queries the details of a CommitContainer task.
         *
         * @param request DescribeCommitContainerTaskRequest
         * @return DescribeCommitContainerTaskResponse
         */
        public async Task<DescribeCommitContainerTaskResponse> DescribeCommitContainerTaskAsync(DescribeCommitContainerTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeCommitContainerTaskWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries event information about multiple container groups at a time.
         *
         * @description You can call this operation to query the event information about multiple elastic container instances at a time. By default, the most recent 50 entries of events of each elastic container instance are returned.
         *
         * @param request DescribeContainerGroupEventsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeContainerGroupEventsResponse
         */
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

        /**
         * @summary Queries event information about multiple container groups at a time.
         *
         * @description You can call this operation to query the event information about multiple elastic container instances at a time. By default, the most recent 50 entries of events of each elastic container instance are returned.
         *
         * @param request DescribeContainerGroupEventsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeContainerGroupEventsResponse
         */
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

        /**
         * @summary Queries event information about multiple container groups at a time.
         *
         * @description You can call this operation to query the event information about multiple elastic container instances at a time. By default, the most recent 50 entries of events of each elastic container instance are returned.
         *
         * @param request DescribeContainerGroupEventsRequest
         * @return DescribeContainerGroupEventsResponse
         */
        public DescribeContainerGroupEventsResponse DescribeContainerGroupEvents(DescribeContainerGroupEventsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeContainerGroupEventsWithOptions(request, runtime);
        }

        /**
         * @summary Queries event information about multiple container groups at a time.
         *
         * @description You can call this operation to query the event information about multiple elastic container instances at a time. By default, the most recent 50 entries of events of each elastic container instance are returned.
         *
         * @param request DescribeContainerGroupEventsRequest
         * @return DescribeContainerGroupEventsResponse
         */
        public async Task<DescribeContainerGroupEventsResponse> DescribeContainerGroupEventsAsync(DescribeContainerGroupEventsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeContainerGroupEventsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the monitoring data of an elastic container instance.
         *
         * @description *   A maximum of 50 monitoring data entries can be returned. If the number of monitoring data entries exceeds this limit, an error message is returned.
         * *   You can query real-time monitoring data (data generated within the last 5 minutes) and historical data (data generated more than 5 minutes ago). If the time range to query starts or ends later than the current time, historical monitoring data generated more than 5 minutes ago is returned.
         * *   The elastic container instance whose monitoring data you want to query must be created after April 3, 2019, 15:00 UTC+8.
         *
         * @param request DescribeContainerGroupMetricRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeContainerGroupMetricResponse
         */
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

        /**
         * @summary Queries the monitoring data of an elastic container instance.
         *
         * @description *   A maximum of 50 monitoring data entries can be returned. If the number of monitoring data entries exceeds this limit, an error message is returned.
         * *   You can query real-time monitoring data (data generated within the last 5 minutes) and historical data (data generated more than 5 minutes ago). If the time range to query starts or ends later than the current time, historical monitoring data generated more than 5 minutes ago is returned.
         * *   The elastic container instance whose monitoring data you want to query must be created after April 3, 2019, 15:00 UTC+8.
         *
         * @param request DescribeContainerGroupMetricRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeContainerGroupMetricResponse
         */
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

        /**
         * @summary Queries the monitoring data of an elastic container instance.
         *
         * @description *   A maximum of 50 monitoring data entries can be returned. If the number of monitoring data entries exceeds this limit, an error message is returned.
         * *   You can query real-time monitoring data (data generated within the last 5 minutes) and historical data (data generated more than 5 minutes ago). If the time range to query starts or ends later than the current time, historical monitoring data generated more than 5 minutes ago is returned.
         * *   The elastic container instance whose monitoring data you want to query must be created after April 3, 2019, 15:00 UTC+8.
         *
         * @param request DescribeContainerGroupMetricRequest
         * @return DescribeContainerGroupMetricResponse
         */
        public DescribeContainerGroupMetricResponse DescribeContainerGroupMetric(DescribeContainerGroupMetricRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeContainerGroupMetricWithOptions(request, runtime);
        }

        /**
         * @summary Queries the monitoring data of an elastic container instance.
         *
         * @description *   A maximum of 50 monitoring data entries can be returned. If the number of monitoring data entries exceeds this limit, an error message is returned.
         * *   You can query real-time monitoring data (data generated within the last 5 minutes) and historical data (data generated more than 5 minutes ago). If the time range to query starts or ends later than the current time, historical monitoring data generated more than 5 minutes ago is returned.
         * *   The elastic container instance whose monitoring data you want to query must be created after April 3, 2019, 15:00 UTC+8.
         *
         * @param request DescribeContainerGroupMetricRequest
         * @return DescribeContainerGroupMetricResponse
         */
        public async Task<DescribeContainerGroupMetricResponse> DescribeContainerGroupMetricAsync(DescribeContainerGroupMetricRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeContainerGroupMetricWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the price of an elastic container instance.
         *
         * @description *   When you call this operation, you cannot use resource groups to control the permissions of a RAM user.
         * *   You can create an elastic container instance by specifying vCPU and memory resource specifications or by specifying ECS instance types. When you call this operation to query the prices of elastic container instances, pass in specifications of the elastic container instances.
         *     *   [vCPU and memory specifications](https://help.aliyun.com/document_detail/114662.html).
         *     *   [ECS instance types that are supported by Elastic Container Instance](https://help.aliyun.com/document_detail/114664.html).
         *
         * @param request DescribeContainerGroupPriceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeContainerGroupPriceResponse
         */
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

        /**
         * @summary Queries the price of an elastic container instance.
         *
         * @description *   When you call this operation, you cannot use resource groups to control the permissions of a RAM user.
         * *   You can create an elastic container instance by specifying vCPU and memory resource specifications or by specifying ECS instance types. When you call this operation to query the prices of elastic container instances, pass in specifications of the elastic container instances.
         *     *   [vCPU and memory specifications](https://help.aliyun.com/document_detail/114662.html).
         *     *   [ECS instance types that are supported by Elastic Container Instance](https://help.aliyun.com/document_detail/114664.html).
         *
         * @param request DescribeContainerGroupPriceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeContainerGroupPriceResponse
         */
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

        /**
         * @summary Queries the price of an elastic container instance.
         *
         * @description *   When you call this operation, you cannot use resource groups to control the permissions of a RAM user.
         * *   You can create an elastic container instance by specifying vCPU and memory resource specifications or by specifying ECS instance types. When you call this operation to query the prices of elastic container instances, pass in specifications of the elastic container instances.
         *     *   [vCPU and memory specifications](https://help.aliyun.com/document_detail/114662.html).
         *     *   [ECS instance types that are supported by Elastic Container Instance](https://help.aliyun.com/document_detail/114664.html).
         *
         * @param request DescribeContainerGroupPriceRequest
         * @return DescribeContainerGroupPriceResponse
         */
        public DescribeContainerGroupPriceResponse DescribeContainerGroupPrice(DescribeContainerGroupPriceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeContainerGroupPriceWithOptions(request, runtime);
        }

        /**
         * @summary Queries the price of an elastic container instance.
         *
         * @description *   When you call this operation, you cannot use resource groups to control the permissions of a RAM user.
         * *   You can create an elastic container instance by specifying vCPU and memory resource specifications or by specifying ECS instance types. When you call this operation to query the prices of elastic container instances, pass in specifications of the elastic container instances.
         *     *   [vCPU and memory specifications](https://help.aliyun.com/document_detail/114662.html).
         *     *   [ECS instance types that are supported by Elastic Container Instance](https://help.aliyun.com/document_detail/114664.html).
         *
         * @param request DescribeContainerGroupPriceRequest
         * @return DescribeContainerGroupPriceResponse
         */
        public async Task<DescribeContainerGroupPriceResponse> DescribeContainerGroupPriceAsync(DescribeContainerGroupPriceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeContainerGroupPriceWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the statuses of multiple container groups at a time.
         *
         * @param request DescribeContainerGroupStatusRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeContainerGroupStatusResponse
         */
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

        /**
         * @summary Queries the statuses of multiple container groups at a time.
         *
         * @param request DescribeContainerGroupStatusRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeContainerGroupStatusResponse
         */
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

        /**
         * @summary Queries the statuses of multiple container groups at a time.
         *
         * @param request DescribeContainerGroupStatusRequest
         * @return DescribeContainerGroupStatusResponse
         */
        public DescribeContainerGroupStatusResponse DescribeContainerGroupStatus(DescribeContainerGroupStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeContainerGroupStatusWithOptions(request, runtime);
        }

        /**
         * @summary Queries the statuses of multiple container groups at a time.
         *
         * @param request DescribeContainerGroupStatusRequest
         * @return DescribeContainerGroupStatusResponse
         */
        public async Task<DescribeContainerGroupStatusResponse> DescribeContainerGroupStatusAsync(DescribeContainerGroupStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeContainerGroupStatusWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries information about multiple elastic container instances at a time.
         *
         * @description *   After an elastic container instance is terminated, its underlying computing resources are recycled. By default, other resources, such as elastic IP addresses (EIPs), that are created together with the instance are released together with the instance.
         * *   The metadata of an instance in the final status (Failed, Succeeded, or Expired) is retained based on the following rules:
         *     *   All metadata information is retained within 1 hour since the instance enters the final status.
         *     *   One hour after the instance enters the final status, only the latest 100 entries of metadata information in each region are retained.
         *
         * @param request DescribeContainerGroupsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeContainerGroupsResponse
         */
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

        /**
         * @summary Queries information about multiple elastic container instances at a time.
         *
         * @description *   After an elastic container instance is terminated, its underlying computing resources are recycled. By default, other resources, such as elastic IP addresses (EIPs), that are created together with the instance are released together with the instance.
         * *   The metadata of an instance in the final status (Failed, Succeeded, or Expired) is retained based on the following rules:
         *     *   All metadata information is retained within 1 hour since the instance enters the final status.
         *     *   One hour after the instance enters the final status, only the latest 100 entries of metadata information in each region are retained.
         *
         * @param request DescribeContainerGroupsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeContainerGroupsResponse
         */
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

        /**
         * @summary Queries information about multiple elastic container instances at a time.
         *
         * @description *   After an elastic container instance is terminated, its underlying computing resources are recycled. By default, other resources, such as elastic IP addresses (EIPs), that are created together with the instance are released together with the instance.
         * *   The metadata of an instance in the final status (Failed, Succeeded, or Expired) is retained based on the following rules:
         *     *   All metadata information is retained within 1 hour since the instance enters the final status.
         *     *   One hour after the instance enters the final status, only the latest 100 entries of metadata information in each region are retained.
         *
         * @param request DescribeContainerGroupsRequest
         * @return DescribeContainerGroupsResponse
         */
        public DescribeContainerGroupsResponse DescribeContainerGroups(DescribeContainerGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeContainerGroupsWithOptions(request, runtime);
        }

        /**
         * @summary Queries information about multiple elastic container instances at a time.
         *
         * @description *   After an elastic container instance is terminated, its underlying computing resources are recycled. By default, other resources, such as elastic IP addresses (EIPs), that are created together with the instance are released together with the instance.
         * *   The metadata of an instance in the final status (Failed, Succeeded, or Expired) is retained based on the following rules:
         *     *   All metadata information is retained within 1 hour since the instance enters the final status.
         *     *   One hour after the instance enters the final status, only the latest 100 entries of metadata information in each region are retained.
         *
         * @param request DescribeContainerGroupsRequest
         * @return DescribeContainerGroupsResponse
         */
        public async Task<DescribeContainerGroupsResponse> DescribeContainerGroupsAsync(DescribeContainerGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeContainerGroupsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the logs of a container in a container group.
         *
         * @param request DescribeContainerLogRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeContainerLogResponse
         */
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

        /**
         * @summary Queries the logs of a container in a container group.
         *
         * @param request DescribeContainerLogRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeContainerLogResponse
         */
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

        /**
         * @summary Queries the logs of a container in a container group.
         *
         * @param request DescribeContainerLogRequest
         * @return DescribeContainerLogResponse
         */
        public DescribeContainerLogResponse DescribeContainerLog(DescribeContainerLogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeContainerLogWithOptions(request, runtime);
        }

        /**
         * @summary Queries the logs of a container in a container group.
         *
         * @param request DescribeContainerLogRequest
         * @return DescribeContainerLogResponse
         */
        public async Task<DescribeContainerLogResponse> DescribeContainerLogAsync(DescribeContainerLogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeContainerLogWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the information about data caches.
         *
         * @param request DescribeDataCachesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeDataCachesResponse
         */
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

        /**
         * @summary Queries the information about data caches.
         *
         * @param request DescribeDataCachesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeDataCachesResponse
         */
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

        /**
         * @summary Queries the information about data caches.
         *
         * @param request DescribeDataCachesRequest
         * @return DescribeDataCachesResponse
         */
        public DescribeDataCachesResponse DescribeDataCaches(DescribeDataCachesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDataCachesWithOptions(request, runtime);
        }

        /**
         * @summary Queries the information about data caches.
         *
         * @param request DescribeDataCachesRequest
         * @return DescribeDataCachesResponse
         */
        public async Task<DescribeDataCachesResponse> DescribeDataCachesAsync(DescribeDataCachesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDataCachesWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries information about image caches.
         *
         * @param request DescribeImageCachesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeImageCachesResponse
         */
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

        /**
         * @summary Queries information about image caches.
         *
         * @param request DescribeImageCachesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeImageCachesResponse
         */
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

        /**
         * @summary Queries information about image caches.
         *
         * @param request DescribeImageCachesRequest
         * @return DescribeImageCachesResponse
         */
        public DescribeImageCachesResponse DescribeImageCaches(DescribeImageCachesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeImageCachesWithOptions(request, runtime);
        }

        /**
         * @summary Queries information about image caches.
         *
         * @param request DescribeImageCachesRequest
         * @return DescribeImageCachesResponse
         */
        public async Task<DescribeImageCachesResponse> DescribeImageCachesAsync(DescribeImageCachesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeImageCachesWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the information about operations and maintenance tasks of an elastic container instance.
         *
         * @param request DescribeInstanceOpsRecordsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeInstanceOpsRecordsResponse
         */
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

        /**
         * @summary Queries the information about operations and maintenance tasks of an elastic container instance.
         *
         * @param request DescribeInstanceOpsRecordsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeInstanceOpsRecordsResponse
         */
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

        /**
         * @summary Queries the information about operations and maintenance tasks of an elastic container instance.
         *
         * @param request DescribeInstanceOpsRecordsRequest
         * @return DescribeInstanceOpsRecordsResponse
         */
        public DescribeInstanceOpsRecordsResponse DescribeInstanceOpsRecords(DescribeInstanceOpsRecordsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeInstanceOpsRecordsWithOptions(request, runtime);
        }

        /**
         * @summary Queries the information about operations and maintenance tasks of an elastic container instance.
         *
         * @param request DescribeInstanceOpsRecordsRequest
         * @return DescribeInstanceOpsRecordsResponse
         */
        public async Task<DescribeInstanceOpsRecordsResponse> DescribeInstanceOpsRecordsAsync(DescribeInstanceOpsRecordsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeInstanceOpsRecordsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the monitoring data of elastic container instances.
         *
         * @description *   Only the latest entry of monitoring data of each elastic container instance is returned.
         * *   You can query only the monitoring data of elastic container instances that are created after April 3, 2019 15:00:00 UTC+8.
         *
         * @param request DescribeMultiContainerGroupMetricRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeMultiContainerGroupMetricResponse
         */
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

        /**
         * @summary Queries the monitoring data of elastic container instances.
         *
         * @description *   Only the latest entry of monitoring data of each elastic container instance is returned.
         * *   You can query only the monitoring data of elastic container instances that are created after April 3, 2019 15:00:00 UTC+8.
         *
         * @param request DescribeMultiContainerGroupMetricRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeMultiContainerGroupMetricResponse
         */
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

        /**
         * @summary Queries the monitoring data of elastic container instances.
         *
         * @description *   Only the latest entry of monitoring data of each elastic container instance is returned.
         * *   You can query only the monitoring data of elastic container instances that are created after April 3, 2019 15:00:00 UTC+8.
         *
         * @param request DescribeMultiContainerGroupMetricRequest
         * @return DescribeMultiContainerGroupMetricResponse
         */
        public DescribeMultiContainerGroupMetricResponse DescribeMultiContainerGroupMetric(DescribeMultiContainerGroupMetricRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeMultiContainerGroupMetricWithOptions(request, runtime);
        }

        /**
         * @summary Queries the monitoring data of elastic container instances.
         *
         * @description *   Only the latest entry of monitoring data of each elastic container instance is returned.
         * *   You can query only the monitoring data of elastic container instances that are created after April 3, 2019 15:00:00 UTC+8.
         *
         * @param request DescribeMultiContainerGroupMetricRequest
         * @return DescribeMultiContainerGroupMetricResponse
         */
        public async Task<DescribeMultiContainerGroupMetricResponse> DescribeMultiContainerGroupMetricAsync(DescribeMultiContainerGroupMetricRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeMultiContainerGroupMetricWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the regions and zones in which Elastic Container Instance is available.
         *
         * @param request DescribeRegionsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeRegionsResponse
         */
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

        /**
         * @summary Queries the regions and zones in which Elastic Container Instance is available.
         *
         * @param request DescribeRegionsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeRegionsResponse
         */
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

        /**
         * @summary Queries the regions and zones in which Elastic Container Instance is available.
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
         * @summary Queries the regions and zones in which Elastic Container Instance is available.
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
         * @summary Queries information about virtual nodes.
         *
         * @param request DescribeVirtualNodesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeVirtualNodesResponse
         */
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

        /**
         * @summary Queries information about virtual nodes.
         *
         * @param request DescribeVirtualNodesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeVirtualNodesResponse
         */
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

        /**
         * @summary Queries information about virtual nodes.
         *
         * @param request DescribeVirtualNodesRequest
         * @return DescribeVirtualNodesResponse
         */
        public DescribeVirtualNodesResponse DescribeVirtualNodes(DescribeVirtualNodesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeVirtualNodesWithOptions(request, runtime);
        }

        /**
         * @summary Queries information about virtual nodes.
         *
         * @param request DescribeVirtualNodesRequest
         * @return DescribeVirtualNodesResponse
         */
        public async Task<DescribeVirtualNodesResponse> DescribeVirtualNodesAsync(DescribeVirtualNodesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeVirtualNodesWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Runs commands in a container.
         *
         * @param request ExecContainerCommandRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ExecContainerCommandResponse
         */
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

        /**
         * @summary Runs commands in a container.
         *
         * @param request ExecContainerCommandRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ExecContainerCommandResponse
         */
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

        /**
         * @summary Runs commands in a container.
         *
         * @param request ExecContainerCommandRequest
         * @return ExecContainerCommandResponse
         */
        public ExecContainerCommandResponse ExecContainerCommand(ExecContainerCommandRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ExecContainerCommandWithOptions(request, runtime);
        }

        /**
         * @summary Runs commands in a container.
         *
         * @param request ExecContainerCommandRequest
         * @return ExecContainerCommandResponse
         */
        public async Task<ExecContainerCommandResponse> ExecContainerCommandAsync(ExecContainerCommandRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ExecContainerCommandWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 查询用户tag
         *
         * @param request ListTagResourcesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListTagResourcesResponse
         */
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

        /**
         * @summary 查询用户tag
         *
         * @param request ListTagResourcesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListTagResourcesResponse
         */
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

        /**
         * @summary 查询用户tag
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
         * @summary 查询用户tag
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
         * @summary Queries the used amounts and upper limits of privileges and quotas that you have in a specified region.
         *
         * @description This operation does not support resource group authentication.
         *
         * @param request ListUsageRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListUsageResponse
         */
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

        /**
         * @summary Queries the used amounts and upper limits of privileges and quotas that you have in a specified region.
         *
         * @description This operation does not support resource group authentication.
         *
         * @param request ListUsageRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListUsageResponse
         */
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

        /**
         * @summary Queries the used amounts and upper limits of privileges and quotas that you have in a specified region.
         *
         * @description This operation does not support resource group authentication.
         *
         * @param request ListUsageRequest
         * @return ListUsageResponse
         */
        public ListUsageResponse ListUsage(ListUsageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListUsageWithOptions(request, runtime);
        }

        /**
         * @summary Queries the used amounts and upper limits of privileges and quotas that you have in a specified region.
         *
         * @description This operation does not support resource group authentication.
         *
         * @param request ListUsageRequest
         * @return ListUsageResponse
         */
        public async Task<ListUsageResponse> ListUsageAsync(ListUsageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListUsageWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Scales out volumes on an elastic container instance.
         *
         * @description You can scale up volumes by calling this operation. You cannot scale down volumes by calling this operation. Only volumes of Alibaba Cloud disks can be scaled up.
         *
         * @param request ResizeContainerGroupVolumeRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ResizeContainerGroupVolumeResponse
         */
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

        /**
         * @summary Scales out volumes on an elastic container instance.
         *
         * @description You can scale up volumes by calling this operation. You cannot scale down volumes by calling this operation. Only volumes of Alibaba Cloud disks can be scaled up.
         *
         * @param request ResizeContainerGroupVolumeRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ResizeContainerGroupVolumeResponse
         */
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

        /**
         * @summary Scales out volumes on an elastic container instance.
         *
         * @description You can scale up volumes by calling this operation. You cannot scale down volumes by calling this operation. Only volumes of Alibaba Cloud disks can be scaled up.
         *
         * @param request ResizeContainerGroupVolumeRequest
         * @return ResizeContainerGroupVolumeResponse
         */
        public ResizeContainerGroupVolumeResponse ResizeContainerGroupVolume(ResizeContainerGroupVolumeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ResizeContainerGroupVolumeWithOptions(request, runtime);
        }

        /**
         * @summary Scales out volumes on an elastic container instance.
         *
         * @description You can scale up volumes by calling this operation. You cannot scale down volumes by calling this operation. Only volumes of Alibaba Cloud disks can be scaled up.
         *
         * @param request ResizeContainerGroupVolumeRequest
         * @return ResizeContainerGroupVolumeResponse
         */
        public async Task<ResizeContainerGroupVolumeResponse> ResizeContainerGroupVolumeAsync(ResizeContainerGroupVolumeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ResizeContainerGroupVolumeWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Restarts an elastic container instance.
         *
         * @description *   Only elastic container instances that are in the Pending or Running state can be restarted. Instances that are in the Succeeded or Failed state cannot be restarted.
         * *   Elastic container instances that were created before 15:00:00 on March 7, 2019 cannot be restarted.
         * *   When an elastic container instance is being restarted, its status changes into Restarting.
         *
         * @param request RestartContainerGroupRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RestartContainerGroupResponse
         */
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

        /**
         * @summary Restarts an elastic container instance.
         *
         * @description *   Only elastic container instances that are in the Pending or Running state can be restarted. Instances that are in the Succeeded or Failed state cannot be restarted.
         * *   Elastic container instances that were created before 15:00:00 on March 7, 2019 cannot be restarted.
         * *   When an elastic container instance is being restarted, its status changes into Restarting.
         *
         * @param request RestartContainerGroupRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return RestartContainerGroupResponse
         */
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

        /**
         * @summary Restarts an elastic container instance.
         *
         * @description *   Only elastic container instances that are in the Pending or Running state can be restarted. Instances that are in the Succeeded or Failed state cannot be restarted.
         * *   Elastic container instances that were created before 15:00:00 on March 7, 2019 cannot be restarted.
         * *   When an elastic container instance is being restarted, its status changes into Restarting.
         *
         * @param request RestartContainerGroupRequest
         * @return RestartContainerGroupResponse
         */
        public RestartContainerGroupResponse RestartContainerGroup(RestartContainerGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RestartContainerGroupWithOptions(request, runtime);
        }

        /**
         * @summary Restarts an elastic container instance.
         *
         * @description *   Only elastic container instances that are in the Pending or Running state can be restarted. Instances that are in the Succeeded or Failed state cannot be restarted.
         * *   Elastic container instances that were created before 15:00:00 on March 7, 2019 cannot be restarted.
         * *   When an elastic container instance is being restarted, its status changes into Restarting.
         *
         * @param request RestartContainerGroupRequest
         * @return RestartContainerGroupResponse
         */
        public async Task<RestartContainerGroupResponse> RestartContainerGroupAsync(RestartContainerGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RestartContainerGroupWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 打用户tag
         *
         * @param request TagResourcesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return TagResourcesResponse
         */
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

        /**
         * @summary 打用户tag
         *
         * @param request TagResourcesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return TagResourcesResponse
         */
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

        /**
         * @summary 打用户tag
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
         * @summary 打用户tag
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
         * @summary 去除用户tag
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

        /**
         * @summary 去除用户tag
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

        /**
         * @summary 去除用户tag
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
         * @summary 去除用户tag
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
         * @summary Updates an elastic container instance.
         *
         * @description *   Only elastic container instances that are in the Pending or Running state can be updated. After you call this operation to update an elastic container instance, the instance enters the Updating state.
         * *   If the RestartPolicy parameter is set to Never for the elastic container instance that you are updating, the containers of the instance may fail. Exercise caution if you want to update the kind of instances.
         *
         * @param request UpdateContainerGroupRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateContainerGroupResponse
         */
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

        /**
         * @summary Updates an elastic container instance.
         *
         * @description *   Only elastic container instances that are in the Pending or Running state can be updated. After you call this operation to update an elastic container instance, the instance enters the Updating state.
         * *   If the RestartPolicy parameter is set to Never for the elastic container instance that you are updating, the containers of the instance may fail. Exercise caution if you want to update the kind of instances.
         *
         * @param request UpdateContainerGroupRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateContainerGroupResponse
         */
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

        /**
         * @summary Updates an elastic container instance.
         *
         * @description *   Only elastic container instances that are in the Pending or Running state can be updated. After you call this operation to update an elastic container instance, the instance enters the Updating state.
         * *   If the RestartPolicy parameter is set to Never for the elastic container instance that you are updating, the containers of the instance may fail. Exercise caution if you want to update the kind of instances.
         *
         * @param request UpdateContainerGroupRequest
         * @return UpdateContainerGroupResponse
         */
        public UpdateContainerGroupResponse UpdateContainerGroup(UpdateContainerGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateContainerGroupWithOptions(request, runtime);
        }

        /**
         * @summary Updates an elastic container instance.
         *
         * @description *   Only elastic container instances that are in the Pending or Running state can be updated. After you call this operation to update an elastic container instance, the instance enters the Updating state.
         * *   If the RestartPolicy parameter is set to Never for the elastic container instance that you are updating, the containers of the instance may fail. Exercise caution if you want to update the kind of instances.
         *
         * @param request UpdateContainerGroupRequest
         * @return UpdateContainerGroupResponse
         */
        public async Task<UpdateContainerGroupResponse> UpdateContainerGroupAsync(UpdateContainerGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateContainerGroupWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Updates a data cache.
         *
         * @param request UpdateDataCacheRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateDataCacheResponse
         */
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

        /**
         * @summary Updates a data cache.
         *
         * @param request UpdateDataCacheRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateDataCacheResponse
         */
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

        /**
         * @summary Updates a data cache.
         *
         * @param request UpdateDataCacheRequest
         * @return UpdateDataCacheResponse
         */
        public UpdateDataCacheResponse UpdateDataCache(UpdateDataCacheRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateDataCacheWithOptions(request, runtime);
        }

        /**
         * @summary Updates a data cache.
         *
         * @param request UpdateDataCacheRequest
         * @return UpdateDataCacheResponse
         */
        public async Task<UpdateDataCacheResponse> UpdateDataCacheAsync(UpdateDataCacheRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateDataCacheWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Updates an image cache.
         *
         * @description Only image caches that are in the Ready or UpdateFailed state can be updated.
         *
         * @param request UpdateImageCacheRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateImageCacheResponse
         */
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

        /**
         * @summary Updates an image cache.
         *
         * @description Only image caches that are in the Ready or UpdateFailed state can be updated.
         *
         * @param request UpdateImageCacheRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateImageCacheResponse
         */
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

        /**
         * @summary Updates an image cache.
         *
         * @description Only image caches that are in the Ready or UpdateFailed state can be updated.
         *
         * @param request UpdateImageCacheRequest
         * @return UpdateImageCacheResponse
         */
        public UpdateImageCacheResponse UpdateImageCache(UpdateImageCacheRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateImageCacheWithOptions(request, runtime);
        }

        /**
         * @summary Updates an image cache.
         *
         * @description Only image caches that are in the Ready or UpdateFailed state can be updated.
         *
         * @param request UpdateImageCacheRequest
         * @return UpdateImageCacheResponse
         */
        public async Task<UpdateImageCacheResponse> UpdateImageCacheAsync(UpdateImageCacheRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateImageCacheWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Updates attributes of a virtual node.
         *
         * @description ## Usage notes
         * Only virtual nodes that are in the Ready state can be updated.
         *
         * @param request UpdateVirtualNodeRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateVirtualNodeResponse
         */
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

        /**
         * @summary Updates attributes of a virtual node.
         *
         * @description ## Usage notes
         * Only virtual nodes that are in the Ready state can be updated.
         *
         * @param request UpdateVirtualNodeRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateVirtualNodeResponse
         */
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

        /**
         * @summary Updates attributes of a virtual node.
         *
         * @description ## Usage notes
         * Only virtual nodes that are in the Ready state can be updated.
         *
         * @param request UpdateVirtualNodeRequest
         * @return UpdateVirtualNodeResponse
         */
        public UpdateVirtualNodeResponse UpdateVirtualNode(UpdateVirtualNodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateVirtualNodeWithOptions(request, runtime);
        }

        /**
         * @summary Updates attributes of a virtual node.
         *
         * @description ## Usage notes
         * Only virtual nodes that are in the Ready state can be updated.
         *
         * @param request UpdateVirtualNodeRequest
         * @return UpdateVirtualNodeResponse
         */
        public async Task<UpdateVirtualNodeResponse> UpdateVirtualNodeAsync(UpdateVirtualNodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateVirtualNodeWithOptionsAsync(request, runtime);
        }

    }
}
