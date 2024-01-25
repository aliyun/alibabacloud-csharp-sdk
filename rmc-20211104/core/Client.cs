// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.RMC20211104.Models;

namespace AlibabaCloud.SDK.RMC20211104
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "";
            CheckConfig(config);
            this._endpoint = GetEndpoint("rmc", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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
          * This section provides the types of resources that can be queried. Two-way queries are supported. For example, you can query the disks (ACS::ECS::Disk) that are associated with a specific Elastic Compute Service (ECS) instance (ACS::ECS::Instance) or query the ECS instance that is associated with a specific disk.  
          * - For ECS instances, the following types of resources can be queried:    - ACS::ECS::Disk
          *   - ACS::EIP::EipAddress
          *   - ACS::VPC::VPC
          *   - ACS::ECS::KeyPair
          *   - ACS::ECS::SecurityGroup
          *   - ACS::ECS::NetworkInterface
          *   - ACS::ECS::Image
          * - For virtual private clouds (VPCs), which are indicated by ACS::VPC::VPC, the following types of resources can be queried:    - ACS::ECS::Instance
          *   - ACS::RDS::DBInstance
          *   - ACS::SLB::LoadBalancer
          *   - ACS::ALB::LoadBalancer
          *   - ACS::Elasticsearch::Instance
          *   - ACS::Redis::DBInstance
          *   - ACS::PolarDB::DBCluster
          *   - ACS::MongoDB::DBInstance
          *   - ACS::DRDS::PolarDBXInstance
          *   - ACS::EDAS::Cluster
          *   - ACS::ECI::ContainerGroup
          *   - ACS::ADB::DBCluster
          *   - ACS::DRDS::DBInstance
          *   - ACS::HBase::Cluster
          *   - ACS::EMR::Cluster
          * This topic provides an example on how to call the API operation to query the resources that are associated with the ECS instance `i-uf6imlgyr1nudhud****` in the China (Shanghai) region.
          * ## Prerequisites
          * Resource Meta Center (RMC) is enabled. For more information, see [Query resources that belong to different resource groups](~~310198~~).
          * ## QPS limits
          * You can call this API operation up to 20 times per second per account. Requests that exceed this limit will fail, and you may experience service interruptions. We recommend that you take note of this limit when you call this operation.
          *
          * @param request ListResourceRelationshipsRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return ListResourceRelationshipsResponse
         */
        public ListResourceRelationshipsResponse ListResourceRelationshipsWithOptions(ListResourceRelationshipsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceRegionId))
            {
                query["SourceRegionId"] = request.SourceRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceResourceId))
            {
                query["SourceResourceId"] = request.SourceResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceResourceType))
            {
                query["SourceResourceType"] = request.SourceResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetResourceType))
            {
                query["TargetResourceType"] = request.TargetResourceType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListResourceRelationships",
                Version = "2021-11-04",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListResourceRelationshipsResponse>(CallApi(params_, req, runtime));
        }

        /**
          * This section provides the types of resources that can be queried. Two-way queries are supported. For example, you can query the disks (ACS::ECS::Disk) that are associated with a specific Elastic Compute Service (ECS) instance (ACS::ECS::Instance) or query the ECS instance that is associated with a specific disk.  
          * - For ECS instances, the following types of resources can be queried:    - ACS::ECS::Disk
          *   - ACS::EIP::EipAddress
          *   - ACS::VPC::VPC
          *   - ACS::ECS::KeyPair
          *   - ACS::ECS::SecurityGroup
          *   - ACS::ECS::NetworkInterface
          *   - ACS::ECS::Image
          * - For virtual private clouds (VPCs), which are indicated by ACS::VPC::VPC, the following types of resources can be queried:    - ACS::ECS::Instance
          *   - ACS::RDS::DBInstance
          *   - ACS::SLB::LoadBalancer
          *   - ACS::ALB::LoadBalancer
          *   - ACS::Elasticsearch::Instance
          *   - ACS::Redis::DBInstance
          *   - ACS::PolarDB::DBCluster
          *   - ACS::MongoDB::DBInstance
          *   - ACS::DRDS::PolarDBXInstance
          *   - ACS::EDAS::Cluster
          *   - ACS::ECI::ContainerGroup
          *   - ACS::ADB::DBCluster
          *   - ACS::DRDS::DBInstance
          *   - ACS::HBase::Cluster
          *   - ACS::EMR::Cluster
          * This topic provides an example on how to call the API operation to query the resources that are associated with the ECS instance `i-uf6imlgyr1nudhud****` in the China (Shanghai) region.
          * ## Prerequisites
          * Resource Meta Center (RMC) is enabled. For more information, see [Query resources that belong to different resource groups](~~310198~~).
          * ## QPS limits
          * You can call this API operation up to 20 times per second per account. Requests that exceed this limit will fail, and you may experience service interruptions. We recommend that you take note of this limit when you call this operation.
          *
          * @param request ListResourceRelationshipsRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return ListResourceRelationshipsResponse
         */
        public async Task<ListResourceRelationshipsResponse> ListResourceRelationshipsWithOptionsAsync(ListResourceRelationshipsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceRegionId))
            {
                query["SourceRegionId"] = request.SourceRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceResourceId))
            {
                query["SourceResourceId"] = request.SourceResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceResourceType))
            {
                query["SourceResourceType"] = request.SourceResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetResourceType))
            {
                query["TargetResourceType"] = request.TargetResourceType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListResourceRelationships",
                Version = "2021-11-04",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListResourceRelationshipsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * This section provides the types of resources that can be queried. Two-way queries are supported. For example, you can query the disks (ACS::ECS::Disk) that are associated with a specific Elastic Compute Service (ECS) instance (ACS::ECS::Instance) or query the ECS instance that is associated with a specific disk.  
          * - For ECS instances, the following types of resources can be queried:    - ACS::ECS::Disk
          *   - ACS::EIP::EipAddress
          *   - ACS::VPC::VPC
          *   - ACS::ECS::KeyPair
          *   - ACS::ECS::SecurityGroup
          *   - ACS::ECS::NetworkInterface
          *   - ACS::ECS::Image
          * - For virtual private clouds (VPCs), which are indicated by ACS::VPC::VPC, the following types of resources can be queried:    - ACS::ECS::Instance
          *   - ACS::RDS::DBInstance
          *   - ACS::SLB::LoadBalancer
          *   - ACS::ALB::LoadBalancer
          *   - ACS::Elasticsearch::Instance
          *   - ACS::Redis::DBInstance
          *   - ACS::PolarDB::DBCluster
          *   - ACS::MongoDB::DBInstance
          *   - ACS::DRDS::PolarDBXInstance
          *   - ACS::EDAS::Cluster
          *   - ACS::ECI::ContainerGroup
          *   - ACS::ADB::DBCluster
          *   - ACS::DRDS::DBInstance
          *   - ACS::HBase::Cluster
          *   - ACS::EMR::Cluster
          * This topic provides an example on how to call the API operation to query the resources that are associated with the ECS instance `i-uf6imlgyr1nudhud****` in the China (Shanghai) region.
          * ## Prerequisites
          * Resource Meta Center (RMC) is enabled. For more information, see [Query resources that belong to different resource groups](~~310198~~).
          * ## QPS limits
          * You can call this API operation up to 20 times per second per account. Requests that exceed this limit will fail, and you may experience service interruptions. We recommend that you take note of this limit when you call this operation.
          *
          * @param request ListResourceRelationshipsRequest
          * @return ListResourceRelationshipsResponse
         */
        public ListResourceRelationshipsResponse ListResourceRelationships(ListResourceRelationshipsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListResourceRelationshipsWithOptions(request, runtime);
        }

        /**
          * This section provides the types of resources that can be queried. Two-way queries are supported. For example, you can query the disks (ACS::ECS::Disk) that are associated with a specific Elastic Compute Service (ECS) instance (ACS::ECS::Instance) or query the ECS instance that is associated with a specific disk.  
          * - For ECS instances, the following types of resources can be queried:    - ACS::ECS::Disk
          *   - ACS::EIP::EipAddress
          *   - ACS::VPC::VPC
          *   - ACS::ECS::KeyPair
          *   - ACS::ECS::SecurityGroup
          *   - ACS::ECS::NetworkInterface
          *   - ACS::ECS::Image
          * - For virtual private clouds (VPCs), which are indicated by ACS::VPC::VPC, the following types of resources can be queried:    - ACS::ECS::Instance
          *   - ACS::RDS::DBInstance
          *   - ACS::SLB::LoadBalancer
          *   - ACS::ALB::LoadBalancer
          *   - ACS::Elasticsearch::Instance
          *   - ACS::Redis::DBInstance
          *   - ACS::PolarDB::DBCluster
          *   - ACS::MongoDB::DBInstance
          *   - ACS::DRDS::PolarDBXInstance
          *   - ACS::EDAS::Cluster
          *   - ACS::ECI::ContainerGroup
          *   - ACS::ADB::DBCluster
          *   - ACS::DRDS::DBInstance
          *   - ACS::HBase::Cluster
          *   - ACS::EMR::Cluster
          * This topic provides an example on how to call the API operation to query the resources that are associated with the ECS instance `i-uf6imlgyr1nudhud****` in the China (Shanghai) region.
          * ## Prerequisites
          * Resource Meta Center (RMC) is enabled. For more information, see [Query resources that belong to different resource groups](~~310198~~).
          * ## QPS limits
          * You can call this API operation up to 20 times per second per account. Requests that exceed this limit will fail, and you may experience service interruptions. We recommend that you take note of this limit when you call this operation.
          *
          * @param request ListResourceRelationshipsRequest
          * @return ListResourceRelationshipsResponse
         */
        public async Task<ListResourceRelationshipsResponse> ListResourceRelationshipsAsync(ListResourceRelationshipsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListResourceRelationshipsWithOptionsAsync(request, runtime);
        }

        /**
          * For more information about resource types that support RMC, see [Resource types that support RMC](https://www.alibabacloud.com/help/en/resource-management/latest/resource-types-that-support-rmc).  
          * This topic provides an example on how to call the API operation to query the resources that can be accessed within the current account in the China (Hangzhou) region.
          * ## Prerequisites
          * Resource Meta Center (RMC) is enabled. For more information, see [Query resources that belong to different resource groups](~~310198~~).
          * ## QPS limits
          * You can call this API operation up to 20 times per second per account. Requests that exceed this limit will fail, and you may experience service interruptions. We recommend that you take note of this limit when you call this operation.
          *
          * @param request SearchResourcesRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return SearchResourcesResponse
         */
        public SearchResourcesResponse SearchResourcesWithOptions(SearchResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Filter))
            {
                query["Filter"] = request.Filter;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortCriterion))
            {
                query["SortCriterion"] = request.SortCriterion;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SearchResources",
                Version = "2021-11-04",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SearchResourcesResponse>(CallApi(params_, req, runtime));
        }

        /**
          * For more information about resource types that support RMC, see [Resource types that support RMC](https://www.alibabacloud.com/help/en/resource-management/latest/resource-types-that-support-rmc).  
          * This topic provides an example on how to call the API operation to query the resources that can be accessed within the current account in the China (Hangzhou) region.
          * ## Prerequisites
          * Resource Meta Center (RMC) is enabled. For more information, see [Query resources that belong to different resource groups](~~310198~~).
          * ## QPS limits
          * You can call this API operation up to 20 times per second per account. Requests that exceed this limit will fail, and you may experience service interruptions. We recommend that you take note of this limit when you call this operation.
          *
          * @param request SearchResourcesRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return SearchResourcesResponse
         */
        public async Task<SearchResourcesResponse> SearchResourcesWithOptionsAsync(SearchResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Filter))
            {
                query["Filter"] = request.Filter;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortCriterion))
            {
                query["SortCriterion"] = request.SortCriterion;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SearchResources",
                Version = "2021-11-04",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SearchResourcesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * For more information about resource types that support RMC, see [Resource types that support RMC](https://www.alibabacloud.com/help/en/resource-management/latest/resource-types-that-support-rmc).  
          * This topic provides an example on how to call the API operation to query the resources that can be accessed within the current account in the China (Hangzhou) region.
          * ## Prerequisites
          * Resource Meta Center (RMC) is enabled. For more information, see [Query resources that belong to different resource groups](~~310198~~).
          * ## QPS limits
          * You can call this API operation up to 20 times per second per account. Requests that exceed this limit will fail, and you may experience service interruptions. We recommend that you take note of this limit when you call this operation.
          *
          * @param request SearchResourcesRequest
          * @return SearchResourcesResponse
         */
        public SearchResourcesResponse SearchResources(SearchResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SearchResourcesWithOptions(request, runtime);
        }

        /**
          * For more information about resource types that support RMC, see [Resource types that support RMC](https://www.alibabacloud.com/help/en/resource-management/latest/resource-types-that-support-rmc).  
          * This topic provides an example on how to call the API operation to query the resources that can be accessed within the current account in the China (Hangzhou) region.
          * ## Prerequisites
          * Resource Meta Center (RMC) is enabled. For more information, see [Query resources that belong to different resource groups](~~310198~~).
          * ## QPS limits
          * You can call this API operation up to 20 times per second per account. Requests that exceed this limit will fail, and you may experience service interruptions. We recommend that you take note of this limit when you call this operation.
          *
          * @param request SearchResourcesRequest
          * @return SearchResourcesResponse
         */
        public async Task<SearchResourcesResponse> SearchResourcesAsync(SearchResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SearchResourcesWithOptionsAsync(request, runtime);
        }

    }
}
