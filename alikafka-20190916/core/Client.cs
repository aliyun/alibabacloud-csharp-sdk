// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Alikafka20190916.Models;

namespace AlibabaCloud.SDK.Alikafka20190916
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "regional";
            CheckConfig(config);
            this._endpoint = GetEndpoint("alikafka", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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
         * @summary Changes the resource group of an ApsaraMQ for Kafka instance.
         *
         * @param request ChangeResourceGroupRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ChangeResourceGroupResponse
         */
        public ChangeResourceGroupResponse ChangeResourceGroupWithOptions(ChangeResourceGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NewResourceGroupId))
            {
                query["NewResourceGroupId"] = request.NewResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceId))
            {
                query["ResourceId"] = request.ResourceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ChangeResourceGroup",
                Version = "2019-09-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ChangeResourceGroupResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Changes the resource group of an ApsaraMQ for Kafka instance.
         *
         * @param request ChangeResourceGroupRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ChangeResourceGroupResponse
         */
        public async Task<ChangeResourceGroupResponse> ChangeResourceGroupWithOptionsAsync(ChangeResourceGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NewResourceGroupId))
            {
                query["NewResourceGroupId"] = request.NewResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceId))
            {
                query["ResourceId"] = request.ResourceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ChangeResourceGroup",
                Version = "2019-09-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ChangeResourceGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Changes the resource group of an ApsaraMQ for Kafka instance.
         *
         * @param request ChangeResourceGroupRequest
         * @return ChangeResourceGroupResponse
         */
        public ChangeResourceGroupResponse ChangeResourceGroup(ChangeResourceGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ChangeResourceGroupWithOptions(request, runtime);
        }

        /**
         * @summary Changes the resource group of an ApsaraMQ for Kafka instance.
         *
         * @param request ChangeResourceGroupRequest
         * @return ChangeResourceGroupResponse
         */
        public async Task<ChangeResourceGroupResponse> ChangeResourceGroupAsync(ChangeResourceGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ChangeResourceGroupWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Changes the billing method of a Message Queue for Apache Kafka instance from pay-as-you-go to subscription.
         *
         * @param request ConvertPostPayOrderRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ConvertPostPayOrderResponse
         */
        public ConvertPostPayOrderResponse ConvertPostPayOrderWithOptions(ConvertPostPayOrderRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Duration))
            {
                query["Duration"] = request.Duration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
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
                Action = "ConvertPostPayOrder",
                Version = "2019-09-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ConvertPostPayOrderResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Changes the billing method of a Message Queue for Apache Kafka instance from pay-as-you-go to subscription.
         *
         * @param request ConvertPostPayOrderRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ConvertPostPayOrderResponse
         */
        public async Task<ConvertPostPayOrderResponse> ConvertPostPayOrderWithOptionsAsync(ConvertPostPayOrderRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Duration))
            {
                query["Duration"] = request.Duration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
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
                Action = "ConvertPostPayOrder",
                Version = "2019-09-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ConvertPostPayOrderResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Changes the billing method of a Message Queue for Apache Kafka instance from pay-as-you-go to subscription.
         *
         * @param request ConvertPostPayOrderRequest
         * @return ConvertPostPayOrderResponse
         */
        public ConvertPostPayOrderResponse ConvertPostPayOrder(ConvertPostPayOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ConvertPostPayOrderWithOptions(request, runtime);
        }

        /**
         * @summary Changes the billing method of a Message Queue for Apache Kafka instance from pay-as-you-go to subscription.
         *
         * @param request ConvertPostPayOrderRequest
         * @return ConvertPostPayOrderResponse
         */
        public async Task<ConvertPostPayOrderResponse> ConvertPostPayOrderAsync(ConvertPostPayOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ConvertPostPayOrderWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Creates an access control list (ACL).
         *
         * @param request CreateAclRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateAclResponse
         */
        public CreateAclResponse CreateAclWithOptions(CreateAclRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AclOperationType))
            {
                query["AclOperationType"] = request.AclOperationType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AclOperationTypes))
            {
                query["AclOperationTypes"] = request.AclOperationTypes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AclPermissionType))
            {
                query["AclPermissionType"] = request.AclPermissionType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AclResourceName))
            {
                query["AclResourceName"] = request.AclResourceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AclResourcePatternType))
            {
                query["AclResourcePatternType"] = request.AclResourcePatternType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AclResourceType))
            {
                query["AclResourceType"] = request.AclResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Host))
            {
                query["Host"] = request.Host;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Username))
            {
                query["Username"] = request.Username;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateAcl",
                Version = "2019-09-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateAclResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Creates an access control list (ACL).
         *
         * @param request CreateAclRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateAclResponse
         */
        public async Task<CreateAclResponse> CreateAclWithOptionsAsync(CreateAclRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AclOperationType))
            {
                query["AclOperationType"] = request.AclOperationType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AclOperationTypes))
            {
                query["AclOperationTypes"] = request.AclOperationTypes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AclPermissionType))
            {
                query["AclPermissionType"] = request.AclPermissionType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AclResourceName))
            {
                query["AclResourceName"] = request.AclResourceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AclResourcePatternType))
            {
                query["AclResourcePatternType"] = request.AclResourcePatternType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AclResourceType))
            {
                query["AclResourceType"] = request.AclResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Host))
            {
                query["Host"] = request.Host;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Username))
            {
                query["Username"] = request.Username;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateAcl",
                Version = "2019-09-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateAclResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Creates an access control list (ACL).
         *
         * @param request CreateAclRequest
         * @return CreateAclResponse
         */
        public CreateAclResponse CreateAcl(CreateAclRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateAclWithOptions(request, runtime);
        }

        /**
         * @summary Creates an access control list (ACL).
         *
         * @param request CreateAclRequest
         * @return CreateAclResponse
         */
        public async Task<CreateAclResponse> CreateAclAsync(CreateAclRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateAclWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Creates a consumer group.
         *
         * @param request CreateConsumerGroupRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateConsumerGroupResponse
         */
        public CreateConsumerGroupResponse CreateConsumerGroupWithOptions(CreateConsumerGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConsumerId))
            {
                query["ConsumerId"] = request.ConsumerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Remark))
            {
                query["Remark"] = request.Remark;
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
                Action = "CreateConsumerGroup",
                Version = "2019-09-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateConsumerGroupResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Creates a consumer group.
         *
         * @param request CreateConsumerGroupRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateConsumerGroupResponse
         */
        public async Task<CreateConsumerGroupResponse> CreateConsumerGroupWithOptionsAsync(CreateConsumerGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConsumerId))
            {
                query["ConsumerId"] = request.ConsumerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Remark))
            {
                query["Remark"] = request.Remark;
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
                Action = "CreateConsumerGroup",
                Version = "2019-09-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateConsumerGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Creates a consumer group.
         *
         * @param request CreateConsumerGroupRequest
         * @return CreateConsumerGroupResponse
         */
        public CreateConsumerGroupResponse CreateConsumerGroup(CreateConsumerGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateConsumerGroupWithOptions(request, runtime);
        }

        /**
         * @summary Creates a consumer group.
         *
         * @param request CreateConsumerGroupRequest
         * @return CreateConsumerGroupResponse
         */
        public async Task<CreateConsumerGroupResponse> CreateConsumerGroupAsync(CreateConsumerGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateConsumerGroupWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Creates a pay-as-you-go ApsaraMQ for Kafka instance. Pay-as-you-go instances allow you to pay after you use the resources. You are charged for pay-as-you-go instances based on the actual resource usage. You can use pay-as-you-go instances in test scenarios or scenarios in which the peak traffic is uncertain.
         *
         * @description Before you call this operation, make sure that you understand the billing method and pricing of pay-as-you-go Message Queue for Apache Kafka instances. For more information, see [Billing](https://help.aliyun.com/document_detail/84737.html).
         *
         * @param tmpReq CreatePostPayOrderRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreatePostPayOrderResponse
         */
        public CreatePostPayOrderResponse CreatePostPayOrderWithOptions(CreatePostPayOrderRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreatePostPayOrderShrinkRequest request = new CreatePostPayOrderShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ServerlessConfig))
            {
                request.ServerlessConfigShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ServerlessConfig, "ServerlessConfig", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeployType))
            {
                query["DeployType"] = request.DeployType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DiskSize))
            {
                query["DiskSize"] = request.DiskSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DiskType))
            {
                query["DiskType"] = request.DiskType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EipMax))
            {
                query["EipMax"] = request.EipMax;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IoMax))
            {
                query["IoMax"] = request.IoMax;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IoMaxSpec))
            {
                query["IoMaxSpec"] = request.IoMaxSpec;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PaidType))
            {
                query["PaidType"] = request.PaidType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PartitionNum))
            {
                query["PartitionNum"] = request.PartitionNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServerlessConfigShrink))
            {
                query["ServerlessConfig"] = request.ServerlessConfigShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SpecType))
            {
                query["SpecType"] = request.SpecType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                query["Tag"] = request.Tag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TopicQuota))
            {
                query["TopicQuota"] = request.TopicQuota;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreatePostPayOrder",
                Version = "2019-09-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreatePostPayOrderResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Creates a pay-as-you-go ApsaraMQ for Kafka instance. Pay-as-you-go instances allow you to pay after you use the resources. You are charged for pay-as-you-go instances based on the actual resource usage. You can use pay-as-you-go instances in test scenarios or scenarios in which the peak traffic is uncertain.
         *
         * @description Before you call this operation, make sure that you understand the billing method and pricing of pay-as-you-go Message Queue for Apache Kafka instances. For more information, see [Billing](https://help.aliyun.com/document_detail/84737.html).
         *
         * @param tmpReq CreatePostPayOrderRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreatePostPayOrderResponse
         */
        public async Task<CreatePostPayOrderResponse> CreatePostPayOrderWithOptionsAsync(CreatePostPayOrderRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreatePostPayOrderShrinkRequest request = new CreatePostPayOrderShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ServerlessConfig))
            {
                request.ServerlessConfigShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ServerlessConfig, "ServerlessConfig", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeployType))
            {
                query["DeployType"] = request.DeployType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DiskSize))
            {
                query["DiskSize"] = request.DiskSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DiskType))
            {
                query["DiskType"] = request.DiskType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EipMax))
            {
                query["EipMax"] = request.EipMax;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IoMax))
            {
                query["IoMax"] = request.IoMax;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IoMaxSpec))
            {
                query["IoMaxSpec"] = request.IoMaxSpec;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PaidType))
            {
                query["PaidType"] = request.PaidType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PartitionNum))
            {
                query["PartitionNum"] = request.PartitionNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServerlessConfigShrink))
            {
                query["ServerlessConfig"] = request.ServerlessConfigShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SpecType))
            {
                query["SpecType"] = request.SpecType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                query["Tag"] = request.Tag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TopicQuota))
            {
                query["TopicQuota"] = request.TopicQuota;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreatePostPayOrder",
                Version = "2019-09-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreatePostPayOrderResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Creates a pay-as-you-go ApsaraMQ for Kafka instance. Pay-as-you-go instances allow you to pay after you use the resources. You are charged for pay-as-you-go instances based on the actual resource usage. You can use pay-as-you-go instances in test scenarios or scenarios in which the peak traffic is uncertain.
         *
         * @description Before you call this operation, make sure that you understand the billing method and pricing of pay-as-you-go Message Queue for Apache Kafka instances. For more information, see [Billing](https://help.aliyun.com/document_detail/84737.html).
         *
         * @param request CreatePostPayOrderRequest
         * @return CreatePostPayOrderResponse
         */
        public CreatePostPayOrderResponse CreatePostPayOrder(CreatePostPayOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreatePostPayOrderWithOptions(request, runtime);
        }

        /**
         * @summary Creates a pay-as-you-go ApsaraMQ for Kafka instance. Pay-as-you-go instances allow you to pay after you use the resources. You are charged for pay-as-you-go instances based on the actual resource usage. You can use pay-as-you-go instances in test scenarios or scenarios in which the peak traffic is uncertain.
         *
         * @description Before you call this operation, make sure that you understand the billing method and pricing of pay-as-you-go Message Queue for Apache Kafka instances. For more information, see [Billing](https://help.aliyun.com/document_detail/84737.html).
         *
         * @param request CreatePostPayOrderRequest
         * @return CreatePostPayOrderResponse
         */
        public async Task<CreatePostPayOrderResponse> CreatePostPayOrderAsync(CreatePostPayOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreatePostPayOrderWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Creates a subscription ApsaraMQ for Kafka instance. You can use subscription instances only after you pay for them. Subscription instances are suitable for long-term and stable business scenarios.
         *
         * @description *   Before you call this operation, make sure that you understand the billing methods and pricing of subscription ApsaraMQ for Kafka instances. For more information, see [Billing](https://help.aliyun.com/document_detail/84737.html).
         * *   If you create an ApsaraMQ for Kafka instance by calling this operation, the subscription duration is one month and the auto-renewal feature is enabled by default. The auto-renewal cycle is also one month. If you want to change the auto-renewal cycle or disable the auto-renewal feature, you can go to the [Renewal](https://renew.console.aliyun.com/#/ecs) page in the Alibaba Cloud Management Console.
         *
         * @param tmpReq CreatePrePayOrderRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreatePrePayOrderResponse
         */
        public CreatePrePayOrderResponse CreatePrePayOrderWithOptions(CreatePrePayOrderRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreatePrePayOrderShrinkRequest request = new CreatePrePayOrderShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ConfluentConfig))
            {
                request.ConfluentConfigShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ConfluentConfig, "ConfluentConfig", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfluentConfigShrink))
            {
                query["ConfluentConfig"] = request.ConfluentConfigShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeployType))
            {
                query["DeployType"] = request.DeployType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DiskSize))
            {
                query["DiskSize"] = request.DiskSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DiskType))
            {
                query["DiskType"] = request.DiskType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Duration))
            {
                query["Duration"] = request.Duration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EipMax))
            {
                query["EipMax"] = request.EipMax;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IoMax))
            {
                query["IoMax"] = request.IoMax;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IoMaxSpec))
            {
                query["IoMaxSpec"] = request.IoMaxSpec;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PaidType))
            {
                query["PaidType"] = request.PaidType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PartitionNum))
            {
                query["PartitionNum"] = request.PartitionNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SpecType))
            {
                query["SpecType"] = request.SpecType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                query["Tag"] = request.Tag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TopicQuota))
            {
                query["TopicQuota"] = request.TopicQuota;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreatePrePayOrder",
                Version = "2019-09-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreatePrePayOrderResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Creates a subscription ApsaraMQ for Kafka instance. You can use subscription instances only after you pay for them. Subscription instances are suitable for long-term and stable business scenarios.
         *
         * @description *   Before you call this operation, make sure that you understand the billing methods and pricing of subscription ApsaraMQ for Kafka instances. For more information, see [Billing](https://help.aliyun.com/document_detail/84737.html).
         * *   If you create an ApsaraMQ for Kafka instance by calling this operation, the subscription duration is one month and the auto-renewal feature is enabled by default. The auto-renewal cycle is also one month. If you want to change the auto-renewal cycle or disable the auto-renewal feature, you can go to the [Renewal](https://renew.console.aliyun.com/#/ecs) page in the Alibaba Cloud Management Console.
         *
         * @param tmpReq CreatePrePayOrderRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreatePrePayOrderResponse
         */
        public async Task<CreatePrePayOrderResponse> CreatePrePayOrderWithOptionsAsync(CreatePrePayOrderRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreatePrePayOrderShrinkRequest request = new CreatePrePayOrderShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ConfluentConfig))
            {
                request.ConfluentConfigShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ConfluentConfig, "ConfluentConfig", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfluentConfigShrink))
            {
                query["ConfluentConfig"] = request.ConfluentConfigShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeployType))
            {
                query["DeployType"] = request.DeployType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DiskSize))
            {
                query["DiskSize"] = request.DiskSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DiskType))
            {
                query["DiskType"] = request.DiskType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Duration))
            {
                query["Duration"] = request.Duration;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EipMax))
            {
                query["EipMax"] = request.EipMax;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IoMax))
            {
                query["IoMax"] = request.IoMax;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IoMaxSpec))
            {
                query["IoMaxSpec"] = request.IoMaxSpec;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PaidType))
            {
                query["PaidType"] = request.PaidType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PartitionNum))
            {
                query["PartitionNum"] = request.PartitionNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SpecType))
            {
                query["SpecType"] = request.SpecType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                query["Tag"] = request.Tag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TopicQuota))
            {
                query["TopicQuota"] = request.TopicQuota;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreatePrePayOrder",
                Version = "2019-09-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreatePrePayOrderResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Creates a subscription ApsaraMQ for Kafka instance. You can use subscription instances only after you pay for them. Subscription instances are suitable for long-term and stable business scenarios.
         *
         * @description *   Before you call this operation, make sure that you understand the billing methods and pricing of subscription ApsaraMQ for Kafka instances. For more information, see [Billing](https://help.aliyun.com/document_detail/84737.html).
         * *   If you create an ApsaraMQ for Kafka instance by calling this operation, the subscription duration is one month and the auto-renewal feature is enabled by default. The auto-renewal cycle is also one month. If you want to change the auto-renewal cycle or disable the auto-renewal feature, you can go to the [Renewal](https://renew.console.aliyun.com/#/ecs) page in the Alibaba Cloud Management Console.
         *
         * @param request CreatePrePayOrderRequest
         * @return CreatePrePayOrderResponse
         */
        public CreatePrePayOrderResponse CreatePrePayOrder(CreatePrePayOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreatePrePayOrderWithOptions(request, runtime);
        }

        /**
         * @summary Creates a subscription ApsaraMQ for Kafka instance. You can use subscription instances only after you pay for them. Subscription instances are suitable for long-term and stable business scenarios.
         *
         * @description *   Before you call this operation, make sure that you understand the billing methods and pricing of subscription ApsaraMQ for Kafka instances. For more information, see [Billing](https://help.aliyun.com/document_detail/84737.html).
         * *   If you create an ApsaraMQ for Kafka instance by calling this operation, the subscription duration is one month and the auto-renewal feature is enabled by default. The auto-renewal cycle is also one month. If you want to change the auto-renewal cycle or disable the auto-renewal feature, you can go to the [Renewal](https://renew.console.aliyun.com/#/ecs) page in the Alibaba Cloud Management Console.
         *
         * @param request CreatePrePayOrderRequest
         * @return CreatePrePayOrderResponse
         */
        public async Task<CreatePrePayOrderResponse> CreatePrePayOrderAsync(CreatePrePayOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreatePrePayOrderWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Creates a Simple Authentication and Security Layer (SASL) user.
         *
         * @param request CreateSaslUserRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateSaslUserResponse
         */
        public CreateSaslUserResponse CreateSaslUserWithOptions(CreateSaslUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mechanism))
            {
                query["Mechanism"] = request.Mechanism;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Password))
            {
                query["Password"] = request.Password;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["Type"] = request.Type;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Username))
            {
                query["Username"] = request.Username;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateSaslUser",
                Version = "2019-09-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateSaslUserResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Creates a Simple Authentication and Security Layer (SASL) user.
         *
         * @param request CreateSaslUserRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateSaslUserResponse
         */
        public async Task<CreateSaslUserResponse> CreateSaslUserWithOptionsAsync(CreateSaslUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mechanism))
            {
                query["Mechanism"] = request.Mechanism;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Password))
            {
                query["Password"] = request.Password;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["Type"] = request.Type;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Username))
            {
                query["Username"] = request.Username;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateSaslUser",
                Version = "2019-09-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateSaslUserResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Creates a Simple Authentication and Security Layer (SASL) user.
         *
         * @param request CreateSaslUserRequest
         * @return CreateSaslUserResponse
         */
        public CreateSaslUserResponse CreateSaslUser(CreateSaslUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateSaslUserWithOptions(request, runtime);
        }

        /**
         * @summary Creates a Simple Authentication and Security Layer (SASL) user.
         *
         * @param request CreateSaslUserRequest
         * @return CreateSaslUserResponse
         */
        public async Task<CreateSaslUserResponse> CreateSaslUserAsync(CreateSaslUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateSaslUserWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 创建定时伸缩配置
         *
         * @param tmpReq CreateScheduledScalingRuleRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateScheduledScalingRuleResponse
         */
        public CreateScheduledScalingRuleResponse CreateScheduledScalingRuleWithOptions(CreateScheduledScalingRuleRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateScheduledScalingRuleShrinkRequest request = new CreateScheduledScalingRuleShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.WeeklyTypes))
            {
                request.WeeklyTypesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.WeeklyTypes, "WeeklyTypes", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DurationMinutes))
            {
                query["DurationMinutes"] = request.DurationMinutes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Enable))
            {
                query["Enable"] = request.Enable;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FirstScheduledTime))
            {
                query["FirstScheduledTime"] = request.FirstScheduledTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RepeatType))
            {
                query["RepeatType"] = request.RepeatType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReservedPubFlow))
            {
                query["ReservedPubFlow"] = request.ReservedPubFlow;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReservedSubFlow))
            {
                query["ReservedSubFlow"] = request.ReservedSubFlow;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleName))
            {
                query["RuleName"] = request.RuleName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScheduleType))
            {
                query["ScheduleType"] = request.ScheduleType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TimeZone))
            {
                query["TimeZone"] = request.TimeZone;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WeeklyTypesShrink))
            {
                query["WeeklyTypes"] = request.WeeklyTypesShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateScheduledScalingRule",
                Version = "2019-09-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateScheduledScalingRuleResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 创建定时伸缩配置
         *
         * @param tmpReq CreateScheduledScalingRuleRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateScheduledScalingRuleResponse
         */
        public async Task<CreateScheduledScalingRuleResponse> CreateScheduledScalingRuleWithOptionsAsync(CreateScheduledScalingRuleRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateScheduledScalingRuleShrinkRequest request = new CreateScheduledScalingRuleShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.WeeklyTypes))
            {
                request.WeeklyTypesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.WeeklyTypes, "WeeklyTypes", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DurationMinutes))
            {
                query["DurationMinutes"] = request.DurationMinutes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Enable))
            {
                query["Enable"] = request.Enable;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FirstScheduledTime))
            {
                query["FirstScheduledTime"] = request.FirstScheduledTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RepeatType))
            {
                query["RepeatType"] = request.RepeatType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReservedPubFlow))
            {
                query["ReservedPubFlow"] = request.ReservedPubFlow;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReservedSubFlow))
            {
                query["ReservedSubFlow"] = request.ReservedSubFlow;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleName))
            {
                query["RuleName"] = request.RuleName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScheduleType))
            {
                query["ScheduleType"] = request.ScheduleType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TimeZone))
            {
                query["TimeZone"] = request.TimeZone;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WeeklyTypesShrink))
            {
                query["WeeklyTypes"] = request.WeeklyTypesShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateScheduledScalingRule",
                Version = "2019-09-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateScheduledScalingRuleResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 创建定时伸缩配置
         *
         * @param request CreateScheduledScalingRuleRequest
         * @return CreateScheduledScalingRuleResponse
         */
        public CreateScheduledScalingRuleResponse CreateScheduledScalingRule(CreateScheduledScalingRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateScheduledScalingRuleWithOptions(request, runtime);
        }

        /**
         * @summary 创建定时伸缩配置
         *
         * @param request CreateScheduledScalingRuleRequest
         * @return CreateScheduledScalingRuleResponse
         */
        public async Task<CreateScheduledScalingRuleResponse> CreateScheduledScalingRuleAsync(CreateScheduledScalingRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateScheduledScalingRuleWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Creates a topic.
         *
         * @description *   Each Alibaba Cloud account can call this operation up to once per second.
         * *   The maximum number of topics that you can create in an instance is determined by the specification of the instance.
         *
         * @param request CreateTopicRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateTopicResponse
         */
        public CreateTopicResponse CreateTopicWithOptions(CreateTopicRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CompactTopic))
            {
                query["CompactTopic"] = request.CompactTopic;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Config))
            {
                query["Config"] = request.Config;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LocalTopic))
            {
                query["LocalTopic"] = request.LocalTopic;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MinInsyncReplicas))
            {
                query["MinInsyncReplicas"] = request.MinInsyncReplicas;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PartitionNum))
            {
                query["PartitionNum"] = request.PartitionNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Remark))
            {
                query["Remark"] = request.Remark;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReplicationFactor))
            {
                query["ReplicationFactor"] = request.ReplicationFactor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                query["Tag"] = request.Tag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Topic))
            {
                query["Topic"] = request.Topic;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateTopic",
                Version = "2019-09-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateTopicResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Creates a topic.
         *
         * @description *   Each Alibaba Cloud account can call this operation up to once per second.
         * *   The maximum number of topics that you can create in an instance is determined by the specification of the instance.
         *
         * @param request CreateTopicRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateTopicResponse
         */
        public async Task<CreateTopicResponse> CreateTopicWithOptionsAsync(CreateTopicRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CompactTopic))
            {
                query["CompactTopic"] = request.CompactTopic;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Config))
            {
                query["Config"] = request.Config;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LocalTopic))
            {
                query["LocalTopic"] = request.LocalTopic;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MinInsyncReplicas))
            {
                query["MinInsyncReplicas"] = request.MinInsyncReplicas;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PartitionNum))
            {
                query["PartitionNum"] = request.PartitionNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Remark))
            {
                query["Remark"] = request.Remark;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReplicationFactor))
            {
                query["ReplicationFactor"] = request.ReplicationFactor;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                query["Tag"] = request.Tag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Topic))
            {
                query["Topic"] = request.Topic;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateTopic",
                Version = "2019-09-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateTopicResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Creates a topic.
         *
         * @description *   Each Alibaba Cloud account can call this operation up to once per second.
         * *   The maximum number of topics that you can create in an instance is determined by the specification of the instance.
         *
         * @param request CreateTopicRequest
         * @return CreateTopicResponse
         */
        public CreateTopicResponse CreateTopic(CreateTopicRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateTopicWithOptions(request, runtime);
        }

        /**
         * @summary Creates a topic.
         *
         * @description *   Each Alibaba Cloud account can call this operation up to once per second.
         * *   The maximum number of topics that you can create in an instance is determined by the specification of the instance.
         *
         * @param request CreateTopicRequest
         * @return CreateTopicResponse
         */
        public async Task<CreateTopicResponse> CreateTopicAsync(CreateTopicRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateTopicWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Deletes an access control list (ACL).
         *
         * @param request DeleteAclRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteAclResponse
         */
        public DeleteAclResponse DeleteAclWithOptions(DeleteAclRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AclOperationType))
            {
                query["AclOperationType"] = request.AclOperationType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AclOperationTypes))
            {
                query["AclOperationTypes"] = request.AclOperationTypes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AclPermissionType))
            {
                query["AclPermissionType"] = request.AclPermissionType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AclResourceName))
            {
                query["AclResourceName"] = request.AclResourceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AclResourcePatternType))
            {
                query["AclResourcePatternType"] = request.AclResourcePatternType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AclResourceType))
            {
                query["AclResourceType"] = request.AclResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Host))
            {
                query["Host"] = request.Host;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Username))
            {
                query["Username"] = request.Username;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteAcl",
                Version = "2019-09-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteAclResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Deletes an access control list (ACL).
         *
         * @param request DeleteAclRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteAclResponse
         */
        public async Task<DeleteAclResponse> DeleteAclWithOptionsAsync(DeleteAclRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AclOperationType))
            {
                query["AclOperationType"] = request.AclOperationType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AclOperationTypes))
            {
                query["AclOperationTypes"] = request.AclOperationTypes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AclPermissionType))
            {
                query["AclPermissionType"] = request.AclPermissionType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AclResourceName))
            {
                query["AclResourceName"] = request.AclResourceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AclResourcePatternType))
            {
                query["AclResourcePatternType"] = request.AclResourcePatternType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AclResourceType))
            {
                query["AclResourceType"] = request.AclResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Host))
            {
                query["Host"] = request.Host;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Username))
            {
                query["Username"] = request.Username;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteAcl",
                Version = "2019-09-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteAclResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Deletes an access control list (ACL).
         *
         * @param request DeleteAclRequest
         * @return DeleteAclResponse
         */
        public DeleteAclResponse DeleteAcl(DeleteAclRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteAclWithOptions(request, runtime);
        }

        /**
         * @summary Deletes an access control list (ACL).
         *
         * @param request DeleteAclRequest
         * @return DeleteAclResponse
         */
        public async Task<DeleteAclResponse> DeleteAclAsync(DeleteAclRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteAclWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Deletes a consumer group from a specified Message Queue for Apache Kafka instance.
         *
         * @param request DeleteConsumerGroupRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteConsumerGroupResponse
         */
        public DeleteConsumerGroupResponse DeleteConsumerGroupWithOptions(DeleteConsumerGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConsumerId))
            {
                query["ConsumerId"] = request.ConsumerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
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
                Action = "DeleteConsumerGroup",
                Version = "2019-09-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteConsumerGroupResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Deletes a consumer group from a specified Message Queue for Apache Kafka instance.
         *
         * @param request DeleteConsumerGroupRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteConsumerGroupResponse
         */
        public async Task<DeleteConsumerGroupResponse> DeleteConsumerGroupWithOptionsAsync(DeleteConsumerGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConsumerId))
            {
                query["ConsumerId"] = request.ConsumerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
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
                Action = "DeleteConsumerGroup",
                Version = "2019-09-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteConsumerGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Deletes a consumer group from a specified Message Queue for Apache Kafka instance.
         *
         * @param request DeleteConsumerGroupRequest
         * @return DeleteConsumerGroupResponse
         */
        public DeleteConsumerGroupResponse DeleteConsumerGroup(DeleteConsumerGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteConsumerGroupWithOptions(request, runtime);
        }

        /**
         * @summary Deletes a consumer group from a specified Message Queue for Apache Kafka instance.
         *
         * @param request DeleteConsumerGroupRequest
         * @return DeleteConsumerGroupResponse
         */
        public async Task<DeleteConsumerGroupResponse> DeleteConsumerGroupAsync(DeleteConsumerGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteConsumerGroupWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Deletes an instance. You can delete subscription and pay-as-you-go instances after you release them.
         *
         * @param request DeleteInstanceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteInstanceResponse
         */
        public DeleteInstanceResponse DeleteInstanceWithOptions(DeleteInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
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
                Action = "DeleteInstance",
                Version = "2019-09-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteInstanceResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Deletes an instance. You can delete subscription and pay-as-you-go instances after you release them.
         *
         * @param request DeleteInstanceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteInstanceResponse
         */
        public async Task<DeleteInstanceResponse> DeleteInstanceWithOptionsAsync(DeleteInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
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
                Action = "DeleteInstance",
                Version = "2019-09-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteInstanceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Deletes an instance. You can delete subscription and pay-as-you-go instances after you release them.
         *
         * @param request DeleteInstanceRequest
         * @return DeleteInstanceResponse
         */
        public DeleteInstanceResponse DeleteInstance(DeleteInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteInstanceWithOptions(request, runtime);
        }

        /**
         * @summary Deletes an instance. You can delete subscription and pay-as-you-go instances after you release them.
         *
         * @param request DeleteInstanceRequest
         * @return DeleteInstanceResponse
         */
        public async Task<DeleteInstanceResponse> DeleteInstanceAsync(DeleteInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteInstanceWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Deletes a Simple Authentication and Security Layer (SASL) user.
         *
         * @param request DeleteSaslUserRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteSaslUserResponse
         */
        public DeleteSaslUserResponse DeleteSaslUserWithOptions(DeleteSaslUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mechanism))
            {
                query["Mechanism"] = request.Mechanism;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["Type"] = request.Type;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Username))
            {
                query["Username"] = request.Username;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteSaslUser",
                Version = "2019-09-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteSaslUserResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Deletes a Simple Authentication and Security Layer (SASL) user.
         *
         * @param request DeleteSaslUserRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteSaslUserResponse
         */
        public async Task<DeleteSaslUserResponse> DeleteSaslUserWithOptionsAsync(DeleteSaslUserRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mechanism))
            {
                query["Mechanism"] = request.Mechanism;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["Type"] = request.Type;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Username))
            {
                query["Username"] = request.Username;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteSaslUser",
                Version = "2019-09-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteSaslUserResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Deletes a Simple Authentication and Security Layer (SASL) user.
         *
         * @param request DeleteSaslUserRequest
         * @return DeleteSaslUserResponse
         */
        public DeleteSaslUserResponse DeleteSaslUser(DeleteSaslUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteSaslUserWithOptions(request, runtime);
        }

        /**
         * @summary Deletes a Simple Authentication and Security Layer (SASL) user.
         *
         * @param request DeleteSaslUserRequest
         * @return DeleteSaslUserResponse
         */
        public async Task<DeleteSaslUserResponse> DeleteSaslUserAsync(DeleteSaslUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteSaslUserWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 删除定时伸缩规则
         *
         * @param request DeleteScheduledScalingRuleRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteScheduledScalingRuleResponse
         */
        public DeleteScheduledScalingRuleResponse DeleteScheduledScalingRuleWithOptions(DeleteScheduledScalingRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleName))
            {
                query["RuleName"] = request.RuleName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteScheduledScalingRule",
                Version = "2019-09-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteScheduledScalingRuleResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 删除定时伸缩规则
         *
         * @param request DeleteScheduledScalingRuleRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteScheduledScalingRuleResponse
         */
        public async Task<DeleteScheduledScalingRuleResponse> DeleteScheduledScalingRuleWithOptionsAsync(DeleteScheduledScalingRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleName))
            {
                query["RuleName"] = request.RuleName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteScheduledScalingRule",
                Version = "2019-09-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteScheduledScalingRuleResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 删除定时伸缩规则
         *
         * @param request DeleteScheduledScalingRuleRequest
         * @return DeleteScheduledScalingRuleResponse
         */
        public DeleteScheduledScalingRuleResponse DeleteScheduledScalingRule(DeleteScheduledScalingRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteScheduledScalingRuleWithOptions(request, runtime);
        }

        /**
         * @summary 删除定时伸缩规则
         *
         * @param request DeleteScheduledScalingRuleRequest
         * @return DeleteScheduledScalingRuleResponse
         */
        public async Task<DeleteScheduledScalingRuleResponse> DeleteScheduledScalingRuleAsync(DeleteScheduledScalingRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteScheduledScalingRuleWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Deletes a topic.
         *
         * @param request DeleteTopicRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteTopicResponse
         */
        public DeleteTopicResponse DeleteTopicWithOptions(DeleteTopicRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Topic))
            {
                query["Topic"] = request.Topic;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteTopic",
                Version = "2019-09-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteTopicResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Deletes a topic.
         *
         * @param request DeleteTopicRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteTopicResponse
         */
        public async Task<DeleteTopicResponse> DeleteTopicWithOptionsAsync(DeleteTopicRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Topic))
            {
                query["Topic"] = request.Topic;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteTopic",
                Version = "2019-09-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteTopicResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Deletes a topic.
         *
         * @param request DeleteTopicRequest
         * @return DeleteTopicResponse
         */
        public DeleteTopicResponse DeleteTopic(DeleteTopicRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteTopicWithOptions(request, runtime);
        }

        /**
         * @summary Deletes a topic.
         *
         * @param request DeleteTopicRequest
         * @return DeleteTopicResponse
         */
        public async Task<DeleteTopicResponse> DeleteTopicAsync(DeleteTopicRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteTopicWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries access control lists (ACLs).
         *
         * @param request DescribeAclsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeAclsResponse
         */
        public DescribeAclsResponse DescribeAclsWithOptions(DescribeAclsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AclOperationType))
            {
                query["AclOperationType"] = request.AclOperationType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AclPermissionType))
            {
                query["AclPermissionType"] = request.AclPermissionType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AclResourceName))
            {
                query["AclResourceName"] = request.AclResourceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AclResourcePatternType))
            {
                query["AclResourcePatternType"] = request.AclResourcePatternType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AclResourceType))
            {
                query["AclResourceType"] = request.AclResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Host))
            {
                query["Host"] = request.Host;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Username))
            {
                query["Username"] = request.Username;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeAcls",
                Version = "2019-09-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAclsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries access control lists (ACLs).
         *
         * @param request DescribeAclsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeAclsResponse
         */
        public async Task<DescribeAclsResponse> DescribeAclsWithOptionsAsync(DescribeAclsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AclOperationType))
            {
                query["AclOperationType"] = request.AclOperationType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AclPermissionType))
            {
                query["AclPermissionType"] = request.AclPermissionType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AclResourceName))
            {
                query["AclResourceName"] = request.AclResourceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AclResourcePatternType))
            {
                query["AclResourcePatternType"] = request.AclResourcePatternType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AclResourceType))
            {
                query["AclResourceType"] = request.AclResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Host))
            {
                query["Host"] = request.Host;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Username))
            {
                query["Username"] = request.Username;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeAcls",
                Version = "2019-09-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeAclsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries access control lists (ACLs).
         *
         * @param request DescribeAclsRequest
         * @return DescribeAclsResponse
         */
        public DescribeAclsResponse DescribeAcls(DescribeAclsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeAclsWithOptions(request, runtime);
        }

        /**
         * @summary Queries access control lists (ACLs).
         *
         * @param request DescribeAclsRequest
         * @return DescribeAclsResponse
         */
        public async Task<DescribeAclsResponse> DescribeAclsAsync(DescribeAclsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeAclsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries Simple Authentication and Security Layer (SASL) users.
         *
         * @param request DescribeSaslUsersRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeSaslUsersResponse
         */
        public DescribeSaslUsersResponse DescribeSaslUsersWithOptions(DescribeSaslUsersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
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
                Action = "DescribeSaslUsers",
                Version = "2019-09-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeSaslUsersResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries Simple Authentication and Security Layer (SASL) users.
         *
         * @param request DescribeSaslUsersRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeSaslUsersResponse
         */
        public async Task<DescribeSaslUsersResponse> DescribeSaslUsersWithOptionsAsync(DescribeSaslUsersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
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
                Action = "DescribeSaslUsers",
                Version = "2019-09-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeSaslUsersResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries Simple Authentication and Security Layer (SASL) users.
         *
         * @param request DescribeSaslUsersRequest
         * @return DescribeSaslUsersResponse
         */
        public DescribeSaslUsersResponse DescribeSaslUsers(DescribeSaslUsersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeSaslUsersWithOptions(request, runtime);
        }

        /**
         * @summary Queries Simple Authentication and Security Layer (SASL) users.
         *
         * @param request DescribeSaslUsersRequest
         * @return DescribeSaslUsersResponse
         */
        public async Task<DescribeSaslUsersResponse> DescribeSaslUsersAsync(DescribeSaslUsersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeSaslUsersWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Enables and disables the flexible group creation feature.
         *
         * @param request EnableAutoGroupCreationRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return EnableAutoGroupCreationResponse
         */
        public EnableAutoGroupCreationResponse EnableAutoGroupCreationWithOptions(EnableAutoGroupCreationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Enable))
            {
                query["Enable"] = request.Enable;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
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
                Action = "EnableAutoGroupCreation",
                Version = "2019-09-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<EnableAutoGroupCreationResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Enables and disables the flexible group creation feature.
         *
         * @param request EnableAutoGroupCreationRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return EnableAutoGroupCreationResponse
         */
        public async Task<EnableAutoGroupCreationResponse> EnableAutoGroupCreationWithOptionsAsync(EnableAutoGroupCreationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Enable))
            {
                query["Enable"] = request.Enable;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
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
                Action = "EnableAutoGroupCreation",
                Version = "2019-09-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<EnableAutoGroupCreationResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Enables and disables the flexible group creation feature.
         *
         * @param request EnableAutoGroupCreationRequest
         * @return EnableAutoGroupCreationResponse
         */
        public EnableAutoGroupCreationResponse EnableAutoGroupCreation(EnableAutoGroupCreationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return EnableAutoGroupCreationWithOptions(request, runtime);
        }

        /**
         * @summary Enables and disables the flexible group creation feature.
         *
         * @param request EnableAutoGroupCreationRequest
         * @return EnableAutoGroupCreationResponse
         */
        public async Task<EnableAutoGroupCreationResponse> EnableAutoGroupCreationAsync(EnableAutoGroupCreationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await EnableAutoGroupCreationWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Enables or disables the automatic topic creation feature, or changes the number of partitions in topics that are automatically created.
         *
         * @param request EnableAutoTopicCreationRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return EnableAutoTopicCreationResponse
         */
        public EnableAutoTopicCreationResponse EnableAutoTopicCreationWithOptions(EnableAutoTopicCreationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Operate))
            {
                query["Operate"] = request.Operate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PartitionNum))
            {
                query["PartitionNum"] = request.PartitionNum;
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
                Action = "EnableAutoTopicCreation",
                Version = "2019-09-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<EnableAutoTopicCreationResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Enables or disables the automatic topic creation feature, or changes the number of partitions in topics that are automatically created.
         *
         * @param request EnableAutoTopicCreationRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return EnableAutoTopicCreationResponse
         */
        public async Task<EnableAutoTopicCreationResponse> EnableAutoTopicCreationWithOptionsAsync(EnableAutoTopicCreationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Operate))
            {
                query["Operate"] = request.Operate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PartitionNum))
            {
                query["PartitionNum"] = request.PartitionNum;
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
                Action = "EnableAutoTopicCreation",
                Version = "2019-09-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<EnableAutoTopicCreationResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Enables or disables the automatic topic creation feature, or changes the number of partitions in topics that are automatically created.
         *
         * @param request EnableAutoTopicCreationRequest
         * @return EnableAutoTopicCreationResponse
         */
        public EnableAutoTopicCreationResponse EnableAutoTopicCreation(EnableAutoTopicCreationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return EnableAutoTopicCreationWithOptions(request, runtime);
        }

        /**
         * @summary Enables or disables the automatic topic creation feature, or changes the number of partitions in topics that are automatically created.
         *
         * @param request EnableAutoTopicCreationRequest
         * @return EnableAutoTopicCreationResponse
         */
        public async Task<EnableAutoTopicCreationResponse> EnableAutoTopicCreationAsync(EnableAutoTopicCreationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await EnableAutoTopicCreationWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the IDs of all instances in the current account.
         *
         * @param request GetAllInstanceIdListRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetAllInstanceIdListResponse
         */
        public GetAllInstanceIdListResponse GetAllInstanceIdListWithOptions(GetAllInstanceIdListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "GetAllInstanceIdList",
                Version = "2019-09-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAllInstanceIdListResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the IDs of all instances in the current account.
         *
         * @param request GetAllInstanceIdListRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetAllInstanceIdListResponse
         */
        public async Task<GetAllInstanceIdListResponse> GetAllInstanceIdListWithOptionsAsync(GetAllInstanceIdListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "GetAllInstanceIdList",
                Version = "2019-09-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAllInstanceIdListResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the IDs of all instances in the current account.
         *
         * @param request GetAllInstanceIdListRequest
         * @return GetAllInstanceIdListResponse
         */
        public GetAllInstanceIdListResponse GetAllInstanceIdList(GetAllInstanceIdListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetAllInstanceIdListWithOptions(request, runtime);
        }

        /**
         * @summary Queries the IDs of all instances in the current account.
         *
         * @param request GetAllInstanceIdListRequest
         * @return GetAllInstanceIdListResponse
         */
        public async Task<GetAllInstanceIdListResponse> GetAllInstanceIdListAsync(GetAllInstanceIdListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetAllInstanceIdListWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the IP address whitelist.
         *
         * @param request GetAllowedIpListRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetAllowedIpListResponse
         */
        public GetAllowedIpListResponse GetAllowedIpListWithOptions(GetAllowedIpListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
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
                Action = "GetAllowedIpList",
                Version = "2019-09-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAllowedIpListResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the IP address whitelist.
         *
         * @param request GetAllowedIpListRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetAllowedIpListResponse
         */
        public async Task<GetAllowedIpListResponse> GetAllowedIpListWithOptionsAsync(GetAllowedIpListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
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
                Action = "GetAllowedIpList",
                Version = "2019-09-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAllowedIpListResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the IP address whitelist.
         *
         * @param request GetAllowedIpListRequest
         * @return GetAllowedIpListResponse
         */
        public GetAllowedIpListResponse GetAllowedIpList(GetAllowedIpListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetAllowedIpListWithOptions(request, runtime);
        }

        /**
         * @summary Queries the IP address whitelist.
         *
         * @param request GetAllowedIpListRequest
         * @return GetAllowedIpListResponse
         */
        public async Task<GetAllowedIpListResponse> GetAllowedIpListAsync(GetAllowedIpListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetAllowedIpListWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 查询自动伸缩配置
         *
         * @param request GetAutoScalingConfigurationRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetAutoScalingConfigurationResponse
         */
        public GetAutoScalingConfigurationResponse GetAutoScalingConfigurationWithOptions(GetAutoScalingConfigurationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
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
                Action = "GetAutoScalingConfiguration",
                Version = "2019-09-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAutoScalingConfigurationResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 查询自动伸缩配置
         *
         * @param request GetAutoScalingConfigurationRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetAutoScalingConfigurationResponse
         */
        public async Task<GetAutoScalingConfigurationResponse> GetAutoScalingConfigurationWithOptionsAsync(GetAutoScalingConfigurationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
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
                Action = "GetAutoScalingConfiguration",
                Version = "2019-09-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAutoScalingConfigurationResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 查询自动伸缩配置
         *
         * @param request GetAutoScalingConfigurationRequest
         * @return GetAutoScalingConfigurationResponse
         */
        public GetAutoScalingConfigurationResponse GetAutoScalingConfiguration(GetAutoScalingConfigurationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetAutoScalingConfigurationWithOptions(request, runtime);
        }

        /**
         * @summary 查询自动伸缩配置
         *
         * @param request GetAutoScalingConfigurationRequest
         * @return GetAutoScalingConfigurationResponse
         */
        public async Task<GetAutoScalingConfigurationResponse> GetAutoScalingConfigurationAsync(GetAutoScalingConfigurationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetAutoScalingConfigurationWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries one or more consumer groups in a specified Message Queue for Apache Kafka instance.
         *
         * @param request GetConsumerListRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetConsumerListResponse
         */
        public GetConsumerListResponse GetConsumerListWithOptions(GetConsumerListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConsumerId))
            {
                query["ConsumerId"] = request.ConsumerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
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
                Action = "GetConsumerList",
                Version = "2019-09-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetConsumerListResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries one or more consumer groups in a specified Message Queue for Apache Kafka instance.
         *
         * @param request GetConsumerListRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetConsumerListResponse
         */
        public async Task<GetConsumerListResponse> GetConsumerListWithOptionsAsync(GetConsumerListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConsumerId))
            {
                query["ConsumerId"] = request.ConsumerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
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
                Action = "GetConsumerList",
                Version = "2019-09-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetConsumerListResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries one or more consumer groups in a specified Message Queue for Apache Kafka instance.
         *
         * @param request GetConsumerListRequest
         * @return GetConsumerListResponse
         */
        public GetConsumerListResponse GetConsumerList(GetConsumerListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetConsumerListWithOptions(request, runtime);
        }

        /**
         * @summary Queries one or more consumer groups in a specified Message Queue for Apache Kafka instance.
         *
         * @param request GetConsumerListRequest
         * @return GetConsumerListResponse
         */
        public async Task<GetConsumerListResponse> GetConsumerListAsync(GetConsumerListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetConsumerListWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the consumer progress of a consumer group.
         *
         * @param request GetConsumerProgressRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetConsumerProgressResponse
         */
        public GetConsumerProgressResponse GetConsumerProgressWithOptions(GetConsumerProgressRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConsumerId))
            {
                query["ConsumerId"] = request.ConsumerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
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
                Action = "GetConsumerProgress",
                Version = "2019-09-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetConsumerProgressResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the consumer progress of a consumer group.
         *
         * @param request GetConsumerProgressRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetConsumerProgressResponse
         */
        public async Task<GetConsumerProgressResponse> GetConsumerProgressWithOptionsAsync(GetConsumerProgressRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConsumerId))
            {
                query["ConsumerId"] = request.ConsumerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
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
                Action = "GetConsumerProgress",
                Version = "2019-09-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetConsumerProgressResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the consumer progress of a consumer group.
         *
         * @param request GetConsumerProgressRequest
         * @return GetConsumerProgressResponse
         */
        public GetConsumerProgressResponse GetConsumerProgress(GetConsumerProgressRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetConsumerProgressWithOptions(request, runtime);
        }

        /**
         * @summary Queries the consumer progress of a consumer group.
         *
         * @param request GetConsumerProgressRequest
         * @return GetConsumerProgressResponse
         */
        public async Task<GetConsumerProgressResponse> GetConsumerProgressAsync(GetConsumerProgressRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetConsumerProgressWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the information about instances in a specified region.
         *
         * @param request GetInstanceListRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetInstanceListResponse
         */
        public GetInstanceListResponse GetInstanceListWithOptions(GetInstanceListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderId))
            {
                query["OrderId"] = request.OrderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Series))
            {
                query["Series"] = request.Series;
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
                Action = "GetInstanceList",
                Version = "2019-09-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetInstanceListResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the information about instances in a specified region.
         *
         * @param request GetInstanceListRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetInstanceListResponse
         */
        public async Task<GetInstanceListResponse> GetInstanceListWithOptionsAsync(GetInstanceListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderId))
            {
                query["OrderId"] = request.OrderId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Series))
            {
                query["Series"] = request.Series;
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
                Action = "GetInstanceList",
                Version = "2019-09-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetInstanceListResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the information about instances in a specified region.
         *
         * @param request GetInstanceListRequest
         * @return GetInstanceListResponse
         */
        public GetInstanceListResponse GetInstanceList(GetInstanceListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetInstanceListWithOptions(request, runtime);
        }

        /**
         * @summary Queries the information about instances in a specified region.
         *
         * @param request GetInstanceListRequest
         * @return GetInstanceListResponse
         */
        public async Task<GetInstanceListResponse> GetInstanceListAsync(GetInstanceListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetInstanceListWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the used quota of topics and partitions.
         *
         * @param request GetQuotaTipRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetQuotaTipResponse
         */
        public GetQuotaTipResponse GetQuotaTipWithOptions(GetQuotaTipRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
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
                Action = "GetQuotaTip",
                Version = "2019-09-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetQuotaTipResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the used quota of topics and partitions.
         *
         * @param request GetQuotaTipRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetQuotaTipResponse
         */
        public async Task<GetQuotaTipResponse> GetQuotaTipWithOptionsAsync(GetQuotaTipRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
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
                Action = "GetQuotaTip",
                Version = "2019-09-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetQuotaTipResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the used quota of topics and partitions.
         *
         * @param request GetQuotaTipRequest
         * @return GetQuotaTipResponse
         */
        public GetQuotaTipResponse GetQuotaTip(GetQuotaTipRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetQuotaTipWithOptions(request, runtime);
        }

        /**
         * @summary Queries the used quota of topics and partitions.
         *
         * @param request GetQuotaTipRequest
         * @return GetQuotaTipResponse
         */
        public async Task<GetQuotaTipResponse> GetQuotaTipAsync(GetQuotaTipRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetQuotaTipWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the information about a topic.
         *
         * @param request GetTopicListRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetTopicListResponse
         */
        public GetTopicListResponse GetTopicListWithOptions(GetTopicListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Topic))
            {
                query["Topic"] = request.Topic;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetTopicList",
                Version = "2019-09-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTopicListResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the information about a topic.
         *
         * @param request GetTopicListRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetTopicListResponse
         */
        public async Task<GetTopicListResponse> GetTopicListWithOptionsAsync(GetTopicListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Topic))
            {
                query["Topic"] = request.Topic;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetTopicList",
                Version = "2019-09-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTopicListResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the information about a topic.
         *
         * @param request GetTopicListRequest
         * @return GetTopicListResponse
         */
        public GetTopicListResponse GetTopicList(GetTopicListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetTopicListWithOptions(request, runtime);
        }

        /**
         * @summary Queries the information about a topic.
         *
         * @param request GetTopicListRequest
         * @return GetTopicListResponse
         */
        public async Task<GetTopicListResponse> GetTopicListAsync(GetTopicListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetTopicListWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the status information about messages in a specified topic.
         *
         * @param request GetTopicStatusRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetTopicStatusResponse
         */
        public GetTopicStatusResponse GetTopicStatusWithOptions(GetTopicStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Topic))
            {
                query["Topic"] = request.Topic;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetTopicStatus",
                Version = "2019-09-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTopicStatusResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the status information about messages in a specified topic.
         *
         * @param request GetTopicStatusRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetTopicStatusResponse
         */
        public async Task<GetTopicStatusResponse> GetTopicStatusWithOptionsAsync(GetTopicStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Topic))
            {
                query["Topic"] = request.Topic;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetTopicStatus",
                Version = "2019-09-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTopicStatusResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the status information about messages in a specified topic.
         *
         * @param request GetTopicStatusRequest
         * @return GetTopicStatusResponse
         */
        public GetTopicStatusResponse GetTopicStatus(GetTopicStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetTopicStatusWithOptions(request, runtime);
        }

        /**
         * @summary Queries the status information about messages in a specified topic.
         *
         * @param request GetTopicStatusRequest
         * @return GetTopicStatusResponse
         */
        public async Task<GetTopicStatusResponse> GetTopicStatusAsync(GetTopicStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetTopicStatusWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Obtains the information about a group that subscribes to a topic.
         *
         * @param request GetTopicSubscribeStatusRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetTopicSubscribeStatusResponse
         */
        public GetTopicSubscribeStatusResponse GetTopicSubscribeStatusWithOptions(GetTopicSubscribeStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Topic))
            {
                query["Topic"] = request.Topic;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetTopicSubscribeStatus",
                Version = "2019-09-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTopicSubscribeStatusResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Obtains the information about a group that subscribes to a topic.
         *
         * @param request GetTopicSubscribeStatusRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetTopicSubscribeStatusResponse
         */
        public async Task<GetTopicSubscribeStatusResponse> GetTopicSubscribeStatusWithOptionsAsync(GetTopicSubscribeStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Topic))
            {
                query["Topic"] = request.Topic;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetTopicSubscribeStatus",
                Version = "2019-09-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTopicSubscribeStatusResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Obtains the information about a group that subscribes to a topic.
         *
         * @param request GetTopicSubscribeStatusRequest
         * @return GetTopicSubscribeStatusResponse
         */
        public GetTopicSubscribeStatusResponse GetTopicSubscribeStatus(GetTopicSubscribeStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetTopicSubscribeStatusWithOptions(request, runtime);
        }

        /**
         * @summary Obtains the information about a group that subscribes to a topic.
         *
         * @param request GetTopicSubscribeStatusRequest
         * @return GetTopicSubscribeStatusResponse
         */
        public async Task<GetTopicSubscribeStatusResponse> GetTopicSubscribeStatusAsync(GetTopicSubscribeStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetTopicSubscribeStatusWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the tags that are attached to a specified resource.
         *
         * @param request ListTagResourcesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListTagResourcesResponse
         */
        public ListTagResourcesResponse ListTagResourcesWithOptions(ListTagResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceId))
            {
                query["ResourceId"] = request.ResourceId;
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
                Version = "2019-09-16",
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
         * @summary Queries the tags that are attached to a specified resource.
         *
         * @param request ListTagResourcesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListTagResourcesResponse
         */
        public async Task<ListTagResourcesResponse> ListTagResourcesWithOptionsAsync(ListTagResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceId))
            {
                query["ResourceId"] = request.ResourceId;
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
                Version = "2019-09-16",
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
         * @summary Queries the tags that are attached to a specified resource.
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
         * @summary Queries the tags that are attached to a specified resource.
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
         * @summary Changes the name of an ApsaraMQ for Kafka instance. After you deploy an instance, you can call this operation to change the name of the instance.
         *
         * @param request ModifyInstanceNameRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyInstanceNameResponse
         */
        public ModifyInstanceNameResponse ModifyInstanceNameWithOptions(ModifyInstanceNameRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceName))
            {
                query["InstanceName"] = request.InstanceName;
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
                Action = "ModifyInstanceName",
                Version = "2019-09-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyInstanceNameResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Changes the name of an ApsaraMQ for Kafka instance. After you deploy an instance, you can call this operation to change the name of the instance.
         *
         * @param request ModifyInstanceNameRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyInstanceNameResponse
         */
        public async Task<ModifyInstanceNameResponse> ModifyInstanceNameWithOptionsAsync(ModifyInstanceNameRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceName))
            {
                query["InstanceName"] = request.InstanceName;
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
                Action = "ModifyInstanceName",
                Version = "2019-09-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyInstanceNameResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Changes the name of an ApsaraMQ for Kafka instance. After you deploy an instance, you can call this operation to change the name of the instance.
         *
         * @param request ModifyInstanceNameRequest
         * @return ModifyInstanceNameResponse
         */
        public ModifyInstanceNameResponse ModifyInstanceName(ModifyInstanceNameRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyInstanceNameWithOptions(request, runtime);
        }

        /**
         * @summary Changes the name of an ApsaraMQ for Kafka instance. After you deploy an instance, you can call this operation to change the name of the instance.
         *
         * @param request ModifyInstanceNameRequest
         * @return ModifyInstanceNameResponse
         */
        public async Task<ModifyInstanceNameResponse> ModifyInstanceNameAsync(ModifyInstanceNameRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyInstanceNameWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Changes the number of partitions in a specified topic.
         *
         * @param request ModifyPartitionNumRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyPartitionNumResponse
         */
        public ModifyPartitionNumResponse ModifyPartitionNumWithOptions(ModifyPartitionNumRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AddPartitionNum))
            {
                query["AddPartitionNum"] = request.AddPartitionNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Topic))
            {
                query["Topic"] = request.Topic;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyPartitionNum",
                Version = "2019-09-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyPartitionNumResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Changes the number of partitions in a specified topic.
         *
         * @param request ModifyPartitionNumRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyPartitionNumResponse
         */
        public async Task<ModifyPartitionNumResponse> ModifyPartitionNumWithOptionsAsync(ModifyPartitionNumRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AddPartitionNum))
            {
                query["AddPartitionNum"] = request.AddPartitionNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Topic))
            {
                query["Topic"] = request.Topic;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyPartitionNum",
                Version = "2019-09-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyPartitionNumResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Changes the number of partitions in a specified topic.
         *
         * @param request ModifyPartitionNumRequest
         * @return ModifyPartitionNumResponse
         */
        public ModifyPartitionNumResponse ModifyPartitionNum(ModifyPartitionNumRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyPartitionNumWithOptions(request, runtime);
        }

        /**
         * @summary Changes the number of partitions in a specified topic.
         *
         * @param request ModifyPartitionNumRequest
         * @return ModifyPartitionNumResponse
         */
        public async Task<ModifyPartitionNumResponse> ModifyPartitionNumAsync(ModifyPartitionNumRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyPartitionNumWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 修改定时伸缩规则
         *
         * @param request ModifyScheduledScalingRuleRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyScheduledScalingRuleResponse
         */
        public ModifyScheduledScalingRuleResponse ModifyScheduledScalingRuleWithOptions(ModifyScheduledScalingRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Enable))
            {
                query["Enable"] = request.Enable;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleName))
            {
                query["RuleName"] = request.RuleName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyScheduledScalingRule",
                Version = "2019-09-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyScheduledScalingRuleResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 修改定时伸缩规则
         *
         * @param request ModifyScheduledScalingRuleRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyScheduledScalingRuleResponse
         */
        public async Task<ModifyScheduledScalingRuleResponse> ModifyScheduledScalingRuleWithOptionsAsync(ModifyScheduledScalingRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Enable))
            {
                query["Enable"] = request.Enable;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleName))
            {
                query["RuleName"] = request.RuleName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyScheduledScalingRule",
                Version = "2019-09-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyScheduledScalingRuleResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 修改定时伸缩规则
         *
         * @param request ModifyScheduledScalingRuleRequest
         * @return ModifyScheduledScalingRuleResponse
         */
        public ModifyScheduledScalingRuleResponse ModifyScheduledScalingRule(ModifyScheduledScalingRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyScheduledScalingRuleWithOptions(request, runtime);
        }

        /**
         * @summary 修改定时伸缩规则
         *
         * @param request ModifyScheduledScalingRuleRequest
         * @return ModifyScheduledScalingRuleResponse
         */
        public async Task<ModifyScheduledScalingRuleResponse> ModifyScheduledScalingRuleAsync(ModifyScheduledScalingRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyScheduledScalingRuleWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Modifies the description of a topic.
         *
         * @param request ModifyTopicRemarkRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyTopicRemarkResponse
         */
        public ModifyTopicRemarkResponse ModifyTopicRemarkWithOptions(ModifyTopicRemarkRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Remark))
            {
                query["Remark"] = request.Remark;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Topic))
            {
                query["Topic"] = request.Topic;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyTopicRemark",
                Version = "2019-09-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyTopicRemarkResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Modifies the description of a topic.
         *
         * @param request ModifyTopicRemarkRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyTopicRemarkResponse
         */
        public async Task<ModifyTopicRemarkResponse> ModifyTopicRemarkWithOptionsAsync(ModifyTopicRemarkRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Remark))
            {
                query["Remark"] = request.Remark;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Topic))
            {
                query["Topic"] = request.Topic;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyTopicRemark",
                Version = "2019-09-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyTopicRemarkResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Modifies the description of a topic.
         *
         * @param request ModifyTopicRemarkRequest
         * @return ModifyTopicRemarkResponse
         */
        public ModifyTopicRemarkResponse ModifyTopicRemark(ModifyTopicRemarkRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyTopicRemarkWithOptions(request, runtime);
        }

        /**
         * @summary Modifies the description of a topic.
         *
         * @param request ModifyTopicRemarkRequest
         * @return ModifyTopicRemarkResponse
         */
        public async Task<ModifyTopicRemarkResponse> ModifyTopicRemarkAsync(ModifyTopicRemarkRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyTopicRemarkWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries messages stored in a topic. You can query messages by creation time or offset.
         *
         * @param request QueryMessageRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryMessageResponse
         */
        public QueryMessageResponse QueryMessageWithOptions(QueryMessageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryMessage",
                Version = "2019-09-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryMessageResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries messages stored in a topic. You can query messages by creation time or offset.
         *
         * @param request QueryMessageRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return QueryMessageResponse
         */
        public async Task<QueryMessageResponse> QueryMessageWithOptionsAsync(QueryMessageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryMessage",
                Version = "2019-09-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryMessageResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries messages stored in a topic. You can query messages by creation time or offset.
         *
         * @param request QueryMessageRequest
         * @return QueryMessageResponse
         */
        public QueryMessageResponse QueryMessage(QueryMessageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryMessageWithOptions(request, runtime);
        }

        /**
         * @summary Queries messages stored in a topic. You can query messages by creation time or offset.
         *
         * @param request QueryMessageRequest
         * @return QueryMessageResponse
         */
        public async Task<QueryMessageResponse> QueryMessageAsync(QueryMessageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryMessageWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Releases a pay-as-you-go Message Queue for Apache Kafka instance.
         *
         * @description You cannot call this operation to release a subscription Message Queue for Apache Kafka instance.
         *
         * @param request ReleaseInstanceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ReleaseInstanceResponse
         */
        public ReleaseInstanceResponse ReleaseInstanceWithOptions(ReleaseInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ForceDeleteInstance))
            {
                query["ForceDeleteInstance"] = request.ForceDeleteInstance;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
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
                Action = "ReleaseInstance",
                Version = "2019-09-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ReleaseInstanceResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Releases a pay-as-you-go Message Queue for Apache Kafka instance.
         *
         * @description You cannot call this operation to release a subscription Message Queue for Apache Kafka instance.
         *
         * @param request ReleaseInstanceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ReleaseInstanceResponse
         */
        public async Task<ReleaseInstanceResponse> ReleaseInstanceWithOptionsAsync(ReleaseInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ForceDeleteInstance))
            {
                query["ForceDeleteInstance"] = request.ForceDeleteInstance;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
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
                Action = "ReleaseInstance",
                Version = "2019-09-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ReleaseInstanceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Releases a pay-as-you-go Message Queue for Apache Kafka instance.
         *
         * @description You cannot call this operation to release a subscription Message Queue for Apache Kafka instance.
         *
         * @param request ReleaseInstanceRequest
         * @return ReleaseInstanceResponse
         */
        public ReleaseInstanceResponse ReleaseInstance(ReleaseInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ReleaseInstanceWithOptions(request, runtime);
        }

        /**
         * @summary Releases a pay-as-you-go Message Queue for Apache Kafka instance.
         *
         * @description You cannot call this operation to release a subscription Message Queue for Apache Kafka instance.
         *
         * @param request ReleaseInstanceRequest
         * @return ReleaseInstanceResponse
         */
        public async Task<ReleaseInstanceResponse> ReleaseInstanceAsync(ReleaseInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ReleaseInstanceWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Enables an ApsaraMQ for Kafka instance.
         *
         * @description You can call this operation only if your instance is in the Stopped state.
         *
         * @param request ReopenInstanceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ReopenInstanceResponse
         */
        public ReopenInstanceResponse ReopenInstanceWithOptions(ReopenInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
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
                Action = "ReopenInstance",
                Version = "2019-09-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ReopenInstanceResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Enables an ApsaraMQ for Kafka instance.
         *
         * @description You can call this operation only if your instance is in the Stopped state.
         *
         * @param request ReopenInstanceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ReopenInstanceResponse
         */
        public async Task<ReopenInstanceResponse> ReopenInstanceWithOptionsAsync(ReopenInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
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
                Action = "ReopenInstance",
                Version = "2019-09-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ReopenInstanceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Enables an ApsaraMQ for Kafka instance.
         *
         * @description You can call this operation only if your instance is in the Stopped state.
         *
         * @param request ReopenInstanceRequest
         * @return ReopenInstanceResponse
         */
        public ReopenInstanceResponse ReopenInstance(ReopenInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ReopenInstanceWithOptions(request, runtime);
        }

        /**
         * @summary Enables an ApsaraMQ for Kafka instance.
         *
         * @description You can call this operation only if your instance is in the Stopped state.
         *
         * @param request ReopenInstanceRequest
         * @return ReopenInstanceResponse
         */
        public async Task<ReopenInstanceResponse> ReopenInstanceAsync(ReopenInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ReopenInstanceWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Deploys an ApsaraMQ for Kafka instance. You must purchase and deploy an ApsaraMQ for Kafka instance before you can use the instance to send and receive messages.
         *
         * @description >  You can call this operation up to twice per second.
         *
         * @param request StartInstanceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return StartInstanceResponse
         */
        public StartInstanceResponse StartInstanceWithOptions(StartInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Config))
            {
                query["Config"] = request.Config;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CrossZone))
            {
                query["CrossZone"] = request.CrossZone;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeployModule))
            {
                query["DeployModule"] = request.DeployModule;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsEipInner))
            {
                query["IsEipInner"] = request.IsEipInner;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsForceSelectedZones))
            {
                query["IsForceSelectedZones"] = request.IsForceSelectedZones;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsSetUserAndPassword))
            {
                query["IsSetUserAndPassword"] = request.IsSetUserAndPassword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KMSKeyId))
            {
                query["KMSKeyId"] = request.KMSKeyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Notifier))
            {
                query["Notifier"] = request.Notifier;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Password))
            {
                query["Password"] = request.Password;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityGroup))
            {
                query["SecurityGroup"] = request.SecurityGroup;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SelectedZones))
            {
                query["SelectedZones"] = request.SelectedZones;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceVersion))
            {
                query["ServiceVersion"] = request.ServiceVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserPhoneNum))
            {
                query["UserPhoneNum"] = request.UserPhoneNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Username))
            {
                query["Username"] = request.Username;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VSwitchId))
            {
                query["VSwitchId"] = request.VSwitchId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VSwitchIds))
            {
                query["VSwitchIds"] = request.VSwitchIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcId))
            {
                query["VpcId"] = request.VpcId;
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
                Action = "StartInstance",
                Version = "2019-09-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<StartInstanceResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Deploys an ApsaraMQ for Kafka instance. You must purchase and deploy an ApsaraMQ for Kafka instance before you can use the instance to send and receive messages.
         *
         * @description >  You can call this operation up to twice per second.
         *
         * @param request StartInstanceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return StartInstanceResponse
         */
        public async Task<StartInstanceResponse> StartInstanceWithOptionsAsync(StartInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Config))
            {
                query["Config"] = request.Config;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CrossZone))
            {
                query["CrossZone"] = request.CrossZone;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeployModule))
            {
                query["DeployModule"] = request.DeployModule;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsEipInner))
            {
                query["IsEipInner"] = request.IsEipInner;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsForceSelectedZones))
            {
                query["IsForceSelectedZones"] = request.IsForceSelectedZones;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsSetUserAndPassword))
            {
                query["IsSetUserAndPassword"] = request.IsSetUserAndPassword;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KMSKeyId))
            {
                query["KMSKeyId"] = request.KMSKeyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["Name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Notifier))
            {
                query["Notifier"] = request.Notifier;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Password))
            {
                query["Password"] = request.Password;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityGroup))
            {
                query["SecurityGroup"] = request.SecurityGroup;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SelectedZones))
            {
                query["SelectedZones"] = request.SelectedZones;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceVersion))
            {
                query["ServiceVersion"] = request.ServiceVersion;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserPhoneNum))
            {
                query["UserPhoneNum"] = request.UserPhoneNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Username))
            {
                query["Username"] = request.Username;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VSwitchId))
            {
                query["VSwitchId"] = request.VSwitchId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VSwitchIds))
            {
                query["VSwitchIds"] = request.VSwitchIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcId))
            {
                query["VpcId"] = request.VpcId;
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
                Action = "StartInstance",
                Version = "2019-09-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<StartInstanceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Deploys an ApsaraMQ for Kafka instance. You must purchase and deploy an ApsaraMQ for Kafka instance before you can use the instance to send and receive messages.
         *
         * @description >  You can call this operation up to twice per second.
         *
         * @param request StartInstanceRequest
         * @return StartInstanceResponse
         */
        public StartInstanceResponse StartInstance(StartInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StartInstanceWithOptions(request, runtime);
        }

        /**
         * @summary Deploys an ApsaraMQ for Kafka instance. You must purchase and deploy an ApsaraMQ for Kafka instance before you can use the instance to send and receive messages.
         *
         * @description >  You can call this operation up to twice per second.
         *
         * @param request StartInstanceRequest
         * @return StartInstanceResponse
         */
        public async Task<StartInstanceResponse> StartInstanceAsync(StartInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StartInstanceWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Stops an ApsaraMQ for Kafka instance.
         *
         * @description You cannot stop a subscription ApsaraMQ for Kafka instance. If you want to stop a subscription ApsaraMQ for Kafka instance, submit a ticket.
         *
         * @param request StopInstanceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return StopInstanceResponse
         */
        public StopInstanceResponse StopInstanceWithOptions(StopInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
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
                Action = "StopInstance",
                Version = "2019-09-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<StopInstanceResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Stops an ApsaraMQ for Kafka instance.
         *
         * @description You cannot stop a subscription ApsaraMQ for Kafka instance. If you want to stop a subscription ApsaraMQ for Kafka instance, submit a ticket.
         *
         * @param request StopInstanceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return StopInstanceResponse
         */
        public async Task<StopInstanceResponse> StopInstanceWithOptionsAsync(StopInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
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
                Action = "StopInstance",
                Version = "2019-09-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<StopInstanceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Stops an ApsaraMQ for Kafka instance.
         *
         * @description You cannot stop a subscription ApsaraMQ for Kafka instance. If you want to stop a subscription ApsaraMQ for Kafka instance, submit a ticket.
         *
         * @param request StopInstanceRequest
         * @return StopInstanceResponse
         */
        public StopInstanceResponse StopInstance(StopInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StopInstanceWithOptions(request, runtime);
        }

        /**
         * @summary Stops an ApsaraMQ for Kafka instance.
         *
         * @description You cannot stop a subscription ApsaraMQ for Kafka instance. If you want to stop a subscription ApsaraMQ for Kafka instance, submit a ticket.
         *
         * @param request StopInstanceRequest
         * @return StopInstanceResponse
         */
        public async Task<StopInstanceResponse> StopInstanceAsync(StopInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StopInstanceWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Attaches a tag to a resource.
         *
         * @param request TagResourcesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return TagResourcesResponse
         */
        public TagResourcesResponse TagResourcesWithOptions(TagResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceId))
            {
                query["ResourceId"] = request.ResourceId;
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
                Version = "2019-09-16",
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
         * @summary Attaches a tag to a resource.
         *
         * @param request TagResourcesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return TagResourcesResponse
         */
        public async Task<TagResourcesResponse> TagResourcesWithOptionsAsync(TagResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceId))
            {
                query["ResourceId"] = request.ResourceId;
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
                Version = "2019-09-16",
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
         * @summary Attaches a tag to a resource.
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
         * @summary Attaches a tag to a resource.
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
         * @summary Detaches tags from a specified resource.
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceId))
            {
                query["ResourceId"] = request.ResourceId;
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
                Version = "2019-09-16",
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
         * @summary Detaches tags from a specified resource.
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceId))
            {
                query["ResourceId"] = request.ResourceId;
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
                Version = "2019-09-16",
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
         * @summary Detaches tags from a specified resource.
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
         * @summary Detaches tags from a specified resource.
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
         * @summary Updates the IP address whitelist of an ApsaraMQ for Kafka instance. Only IP addresses and ports that are configured in the IP address whitelist of an instance can access the instance.
         *
         * @param request UpdateAllowedIpRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateAllowedIpResponse
         */
        public UpdateAllowedIpResponse UpdateAllowedIpWithOptions(UpdateAllowedIpRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AllowedListIp))
            {
                query["AllowedListIp"] = request.AllowedListIp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AllowedListType))
            {
                query["AllowedListType"] = request.AllowedListType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PortRange))
            {
                query["PortRange"] = request.PortRange;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UpdateType))
            {
                query["UpdateType"] = request.UpdateType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateAllowedIp",
                Version = "2019-09-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateAllowedIpResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Updates the IP address whitelist of an ApsaraMQ for Kafka instance. Only IP addresses and ports that are configured in the IP address whitelist of an instance can access the instance.
         *
         * @param request UpdateAllowedIpRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateAllowedIpResponse
         */
        public async Task<UpdateAllowedIpResponse> UpdateAllowedIpWithOptionsAsync(UpdateAllowedIpRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AllowedListIp))
            {
                query["AllowedListIp"] = request.AllowedListIp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AllowedListType))
            {
                query["AllowedListType"] = request.AllowedListType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PortRange))
            {
                query["PortRange"] = request.PortRange;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UpdateType))
            {
                query["UpdateType"] = request.UpdateType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateAllowedIp",
                Version = "2019-09-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateAllowedIpResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Updates the IP address whitelist of an ApsaraMQ for Kafka instance. Only IP addresses and ports that are configured in the IP address whitelist of an instance can access the instance.
         *
         * @param request UpdateAllowedIpRequest
         * @return UpdateAllowedIpResponse
         */
        public UpdateAllowedIpResponse UpdateAllowedIp(UpdateAllowedIpRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateAllowedIpWithOptions(request, runtime);
        }

        /**
         * @summary Updates the IP address whitelist of an ApsaraMQ for Kafka instance. Only IP addresses and ports that are configured in the IP address whitelist of an instance can access the instance.
         *
         * @param request UpdateAllowedIpRequest
         * @return UpdateAllowedIpResponse
         */
        public async Task<UpdateAllowedIpResponse> UpdateAllowedIpAsync(UpdateAllowedIpRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateAllowedIpWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Resets the consumer offsets of the subscribed topics of a consumer group.
         *
         * @description You can call this operation to reset the consumer offset of a specific consumer group. You can use the timestamp or offset parameter to reset the consumer offset of a consumer group. You can implement the following features by configuring a combination of different parameters:
         * *   Reset the consumer offsets of one or all subscribed topics of a consumer group to the latest offset. This way, you can consume messages in the topics from the latest offset.
         * *   Reset the consumer offsets of one or all subscribed topics of a consumer group to a specific point in time. This way, you can consume messages in the topics from the specified point in time.
         * *   Reset the consumer offset of one subscribed topic of a consumer group to a specific offset in a specific partition. This way, you can consume messages from the specified offset in the specified partition.
         *
         * @param tmpReq UpdateConsumerOffsetRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateConsumerOffsetResponse
         */
        public UpdateConsumerOffsetResponse UpdateConsumerOffsetWithOptions(UpdateConsumerOffsetRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateConsumerOffsetShrinkRequest request = new UpdateConsumerOffsetShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Offsets))
            {
                request.OffsetsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Offsets, "Offsets", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConsumerId))
            {
                query["ConsumerId"] = request.ConsumerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OffsetsShrink))
            {
                query["Offsets"] = request.OffsetsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResetType))
            {
                query["ResetType"] = request.ResetType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Time))
            {
                query["Time"] = request.Time;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Topic))
            {
                query["Topic"] = request.Topic;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateConsumerOffset",
                Version = "2019-09-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateConsumerOffsetResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Resets the consumer offsets of the subscribed topics of a consumer group.
         *
         * @description You can call this operation to reset the consumer offset of a specific consumer group. You can use the timestamp or offset parameter to reset the consumer offset of a consumer group. You can implement the following features by configuring a combination of different parameters:
         * *   Reset the consumer offsets of one or all subscribed topics of a consumer group to the latest offset. This way, you can consume messages in the topics from the latest offset.
         * *   Reset the consumer offsets of one or all subscribed topics of a consumer group to a specific point in time. This way, you can consume messages in the topics from the specified point in time.
         * *   Reset the consumer offset of one subscribed topic of a consumer group to a specific offset in a specific partition. This way, you can consume messages from the specified offset in the specified partition.
         *
         * @param tmpReq UpdateConsumerOffsetRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateConsumerOffsetResponse
         */
        public async Task<UpdateConsumerOffsetResponse> UpdateConsumerOffsetWithOptionsAsync(UpdateConsumerOffsetRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateConsumerOffsetShrinkRequest request = new UpdateConsumerOffsetShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Offsets))
            {
                request.OffsetsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Offsets, "Offsets", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConsumerId))
            {
                query["ConsumerId"] = request.ConsumerId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OffsetsShrink))
            {
                query["Offsets"] = request.OffsetsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResetType))
            {
                query["ResetType"] = request.ResetType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Time))
            {
                query["Time"] = request.Time;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Topic))
            {
                query["Topic"] = request.Topic;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateConsumerOffset",
                Version = "2019-09-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateConsumerOffsetResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Resets the consumer offsets of the subscribed topics of a consumer group.
         *
         * @description You can call this operation to reset the consumer offset of a specific consumer group. You can use the timestamp or offset parameter to reset the consumer offset of a consumer group. You can implement the following features by configuring a combination of different parameters:
         * *   Reset the consumer offsets of one or all subscribed topics of a consumer group to the latest offset. This way, you can consume messages in the topics from the latest offset.
         * *   Reset the consumer offsets of one or all subscribed topics of a consumer group to a specific point in time. This way, you can consume messages in the topics from the specified point in time.
         * *   Reset the consumer offset of one subscribed topic of a consumer group to a specific offset in a specific partition. This way, you can consume messages from the specified offset in the specified partition.
         *
         * @param request UpdateConsumerOffsetRequest
         * @return UpdateConsumerOffsetResponse
         */
        public UpdateConsumerOffsetResponse UpdateConsumerOffset(UpdateConsumerOffsetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateConsumerOffsetWithOptions(request, runtime);
        }

        /**
         * @summary Resets the consumer offsets of the subscribed topics of a consumer group.
         *
         * @description You can call this operation to reset the consumer offset of a specific consumer group. You can use the timestamp or offset parameter to reset the consumer offset of a consumer group. You can implement the following features by configuring a combination of different parameters:
         * *   Reset the consumer offsets of one or all subscribed topics of a consumer group to the latest offset. This way, you can consume messages in the topics from the latest offset.
         * *   Reset the consumer offsets of one or all subscribed topics of a consumer group to a specific point in time. This way, you can consume messages in the topics from the specified point in time.
         * *   Reset the consumer offset of one subscribed topic of a consumer group to a specific offset in a specific partition. This way, you can consume messages from the specified offset in the specified partition.
         *
         * @param request UpdateConsumerOffsetRequest
         * @return UpdateConsumerOffsetResponse
         */
        public async Task<UpdateConsumerOffsetResponse> UpdateConsumerOffsetAsync(UpdateConsumerOffsetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateConsumerOffsetWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Modifies the configurations of an ApsaraMQ for Kafka instance. ApsaraMQ for Kafka allows you to modify the configurations of an instance, including the access control list (ACL) feature, the Secure Sockets Layer (SSL) feature, the message retention period, and the maximum message size.
         *
         * @description ## **Permissions**
         * If a RAM user wants to call the **UpdateInstanceConfig** operation, the RAM user must be granted the required permissions. For more information about how to grant permissions, see [RAM policies](https://help.aliyun.com/document_detail/185815.html).
         * |API|Action|Resource|
         * |---|---|---|
         * |UpdateInstanceConfig|alikafka: UpdateInstance|acs:alikafka:*:*:{instanceId}|
         *
         * @param request UpdateInstanceConfigRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateInstanceConfigResponse
         */
        public UpdateInstanceConfigResponse UpdateInstanceConfigWithOptions(UpdateInstanceConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Config))
            {
                query["Config"] = request.Config;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
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
                Action = "UpdateInstanceConfig",
                Version = "2019-09-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateInstanceConfigResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Modifies the configurations of an ApsaraMQ for Kafka instance. ApsaraMQ for Kafka allows you to modify the configurations of an instance, including the access control list (ACL) feature, the Secure Sockets Layer (SSL) feature, the message retention period, and the maximum message size.
         *
         * @description ## **Permissions**
         * If a RAM user wants to call the **UpdateInstanceConfig** operation, the RAM user must be granted the required permissions. For more information about how to grant permissions, see [RAM policies](https://help.aliyun.com/document_detail/185815.html).
         * |API|Action|Resource|
         * |---|---|---|
         * |UpdateInstanceConfig|alikafka: UpdateInstance|acs:alikafka:*:*:{instanceId}|
         *
         * @param request UpdateInstanceConfigRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateInstanceConfigResponse
         */
        public async Task<UpdateInstanceConfigResponse> UpdateInstanceConfigWithOptionsAsync(UpdateInstanceConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Config))
            {
                query["Config"] = request.Config;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
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
                Action = "UpdateInstanceConfig",
                Version = "2019-09-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateInstanceConfigResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Modifies the configurations of an ApsaraMQ for Kafka instance. ApsaraMQ for Kafka allows you to modify the configurations of an instance, including the access control list (ACL) feature, the Secure Sockets Layer (SSL) feature, the message retention period, and the maximum message size.
         *
         * @description ## **Permissions**
         * If a RAM user wants to call the **UpdateInstanceConfig** operation, the RAM user must be granted the required permissions. For more information about how to grant permissions, see [RAM policies](https://help.aliyun.com/document_detail/185815.html).
         * |API|Action|Resource|
         * |---|---|---|
         * |UpdateInstanceConfig|alikafka: UpdateInstance|acs:alikafka:*:*:{instanceId}|
         *
         * @param request UpdateInstanceConfigRequest
         * @return UpdateInstanceConfigResponse
         */
        public UpdateInstanceConfigResponse UpdateInstanceConfig(UpdateInstanceConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateInstanceConfigWithOptions(request, runtime);
        }

        /**
         * @summary Modifies the configurations of an ApsaraMQ for Kafka instance. ApsaraMQ for Kafka allows you to modify the configurations of an instance, including the access control list (ACL) feature, the Secure Sockets Layer (SSL) feature, the message retention period, and the maximum message size.
         *
         * @description ## **Permissions**
         * If a RAM user wants to call the **UpdateInstanceConfig** operation, the RAM user must be granted the required permissions. For more information about how to grant permissions, see [RAM policies](https://help.aliyun.com/document_detail/185815.html).
         * |API|Action|Resource|
         * |---|---|---|
         * |UpdateInstanceConfig|alikafka: UpdateInstance|acs:alikafka:*:*:{instanceId}|
         *
         * @param request UpdateInstanceConfigRequest
         * @return UpdateInstanceConfigResponse
         */
        public async Task<UpdateInstanceConfigResponse> UpdateInstanceConfigAsync(UpdateInstanceConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateInstanceConfigWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Modifies the configurations of a topic. After you create a topic, you can modify the message retention period and maximum message size of the topic.
         *
         * @param request UpdateTopicConfigRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateTopicConfigResponse
         */
        public UpdateTopicConfigResponse UpdateTopicConfigWithOptions(UpdateTopicConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Config))
            {
                query["Config"] = request.Config;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Topic))
            {
                query["Topic"] = request.Topic;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Value))
            {
                query["Value"] = request.Value;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateTopicConfig",
                Version = "2019-09-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateTopicConfigResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Modifies the configurations of a topic. After you create a topic, you can modify the message retention period and maximum message size of the topic.
         *
         * @param request UpdateTopicConfigRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateTopicConfigResponse
         */
        public async Task<UpdateTopicConfigResponse> UpdateTopicConfigWithOptionsAsync(UpdateTopicConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Config))
            {
                query["Config"] = request.Config;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Topic))
            {
                query["Topic"] = request.Topic;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Value))
            {
                query["Value"] = request.Value;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateTopicConfig",
                Version = "2019-09-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateTopicConfigResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Modifies the configurations of a topic. After you create a topic, you can modify the message retention period and maximum message size of the topic.
         *
         * @param request UpdateTopicConfigRequest
         * @return UpdateTopicConfigResponse
         */
        public UpdateTopicConfigResponse UpdateTopicConfig(UpdateTopicConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateTopicConfigWithOptions(request, runtime);
        }

        /**
         * @summary Modifies the configurations of a topic. After you create a topic, you can modify the message retention period and maximum message size of the topic.
         *
         * @param request UpdateTopicConfigRequest
         * @return UpdateTopicConfigResponse
         */
        public async Task<UpdateTopicConfigResponse> UpdateTopicConfigAsync(UpdateTopicConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateTopicConfigWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Updates the version of an instance.
         *
         * @description ## **Permissions**
         * A RAM user must be granted the required permissions before the RAM user calls the **UpgradeInstanceVersion** operation. For information about how to grant permissions, see [RAM policies](https://help.aliyun.com/document_detail/185815.html).
         * |API|Action|Resource|
         * |---|---|---|
         * |UpgradeInstanceVersion|UpdateInstance|acs:alikafka:*:*:{instanceId}|
         * ## **QPS limits**
         * You can send a maximum of two queries per second (QPS).
         *
         * @param request UpgradeInstanceVersionRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpgradeInstanceVersionResponse
         */
        public UpgradeInstanceVersionResponse UpgradeInstanceVersionWithOptions(UpgradeInstanceVersionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetVersion))
            {
                query["TargetVersion"] = request.TargetVersion;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpgradeInstanceVersion",
                Version = "2019-09-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpgradeInstanceVersionResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Updates the version of an instance.
         *
         * @description ## **Permissions**
         * A RAM user must be granted the required permissions before the RAM user calls the **UpgradeInstanceVersion** operation. For information about how to grant permissions, see [RAM policies](https://help.aliyun.com/document_detail/185815.html).
         * |API|Action|Resource|
         * |---|---|---|
         * |UpgradeInstanceVersion|UpdateInstance|acs:alikafka:*:*:{instanceId}|
         * ## **QPS limits**
         * You can send a maximum of two queries per second (QPS).
         *
         * @param request UpgradeInstanceVersionRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpgradeInstanceVersionResponse
         */
        public async Task<UpgradeInstanceVersionResponse> UpgradeInstanceVersionWithOptionsAsync(UpgradeInstanceVersionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetVersion))
            {
                query["TargetVersion"] = request.TargetVersion;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpgradeInstanceVersion",
                Version = "2019-09-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpgradeInstanceVersionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Updates the version of an instance.
         *
         * @description ## **Permissions**
         * A RAM user must be granted the required permissions before the RAM user calls the **UpgradeInstanceVersion** operation. For information about how to grant permissions, see [RAM policies](https://help.aliyun.com/document_detail/185815.html).
         * |API|Action|Resource|
         * |---|---|---|
         * |UpgradeInstanceVersion|UpdateInstance|acs:alikafka:*:*:{instanceId}|
         * ## **QPS limits**
         * You can send a maximum of two queries per second (QPS).
         *
         * @param request UpgradeInstanceVersionRequest
         * @return UpgradeInstanceVersionResponse
         */
        public UpgradeInstanceVersionResponse UpgradeInstanceVersion(UpgradeInstanceVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpgradeInstanceVersionWithOptions(request, runtime);
        }

        /**
         * @summary Updates the version of an instance.
         *
         * @description ## **Permissions**
         * A RAM user must be granted the required permissions before the RAM user calls the **UpgradeInstanceVersion** operation. For information about how to grant permissions, see [RAM policies](https://help.aliyun.com/document_detail/185815.html).
         * |API|Action|Resource|
         * |---|---|---|
         * |UpgradeInstanceVersion|UpdateInstance|acs:alikafka:*:*:{instanceId}|
         * ## **QPS limits**
         * You can send a maximum of two queries per second (QPS).
         *
         * @param request UpgradeInstanceVersionRequest
         * @return UpgradeInstanceVersionResponse
         */
        public async Task<UpgradeInstanceVersionResponse> UpgradeInstanceVersionAsync(UpgradeInstanceVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpgradeInstanceVersionWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Upgrades a pay-as-you-go ApsaraMQ for Kafka instance.
         *
         * @description Before you call this operation, make sure that you understand the billing method and pricing of pay-as-you-go Message Queue for Apache Kafka instances. For more information, see [Billing](https://help.aliyun.com/document_detail/84737.html).
         *
         * @param tmpReq UpgradePostPayOrderRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpgradePostPayOrderResponse
         */
        public UpgradePostPayOrderResponse UpgradePostPayOrderWithOptions(UpgradePostPayOrderRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpgradePostPayOrderShrinkRequest request = new UpgradePostPayOrderShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ServerlessConfig))
            {
                request.ServerlessConfigShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ServerlessConfig, "ServerlessConfig", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DiskSize))
            {
                query["DiskSize"] = request.DiskSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EipMax))
            {
                query["EipMax"] = request.EipMax;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EipModel))
            {
                query["EipModel"] = request.EipModel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IoMax))
            {
                query["IoMax"] = request.IoMax;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IoMaxSpec))
            {
                query["IoMaxSpec"] = request.IoMaxSpec;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PartitionNum))
            {
                query["PartitionNum"] = request.PartitionNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServerlessConfigShrink))
            {
                query["ServerlessConfig"] = request.ServerlessConfigShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SpecType))
            {
                query["SpecType"] = request.SpecType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TopicQuota))
            {
                query["TopicQuota"] = request.TopicQuota;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpgradePostPayOrder",
                Version = "2019-09-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpgradePostPayOrderResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Upgrades a pay-as-you-go ApsaraMQ for Kafka instance.
         *
         * @description Before you call this operation, make sure that you understand the billing method and pricing of pay-as-you-go Message Queue for Apache Kafka instances. For more information, see [Billing](https://help.aliyun.com/document_detail/84737.html).
         *
         * @param tmpReq UpgradePostPayOrderRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpgradePostPayOrderResponse
         */
        public async Task<UpgradePostPayOrderResponse> UpgradePostPayOrderWithOptionsAsync(UpgradePostPayOrderRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpgradePostPayOrderShrinkRequest request = new UpgradePostPayOrderShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ServerlessConfig))
            {
                request.ServerlessConfigShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ServerlessConfig, "ServerlessConfig", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DiskSize))
            {
                query["DiskSize"] = request.DiskSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EipMax))
            {
                query["EipMax"] = request.EipMax;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EipModel))
            {
                query["EipModel"] = request.EipModel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IoMax))
            {
                query["IoMax"] = request.IoMax;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IoMaxSpec))
            {
                query["IoMaxSpec"] = request.IoMaxSpec;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PartitionNum))
            {
                query["PartitionNum"] = request.PartitionNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServerlessConfigShrink))
            {
                query["ServerlessConfig"] = request.ServerlessConfigShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SpecType))
            {
                query["SpecType"] = request.SpecType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TopicQuota))
            {
                query["TopicQuota"] = request.TopicQuota;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpgradePostPayOrder",
                Version = "2019-09-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpgradePostPayOrderResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Upgrades a pay-as-you-go ApsaraMQ for Kafka instance.
         *
         * @description Before you call this operation, make sure that you understand the billing method and pricing of pay-as-you-go Message Queue for Apache Kafka instances. For more information, see [Billing](https://help.aliyun.com/document_detail/84737.html).
         *
         * @param request UpgradePostPayOrderRequest
         * @return UpgradePostPayOrderResponse
         */
        public UpgradePostPayOrderResponse UpgradePostPayOrder(UpgradePostPayOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpgradePostPayOrderWithOptions(request, runtime);
        }

        /**
         * @summary Upgrades a pay-as-you-go ApsaraMQ for Kafka instance.
         *
         * @description Before you call this operation, make sure that you understand the billing method and pricing of pay-as-you-go Message Queue for Apache Kafka instances. For more information, see [Billing](https://help.aliyun.com/document_detail/84737.html).
         *
         * @param request UpgradePostPayOrderRequest
         * @return UpgradePostPayOrderResponse
         */
        public async Task<UpgradePostPayOrderResponse> UpgradePostPayOrderAsync(UpgradePostPayOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpgradePostPayOrderWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Upgrades a Message Queue for Apache Kafka instance that uses the subscription billing method.
         *
         * @description Before you call this operation, make sure that you understand the billing method and pricing of subscription Message Queue for Apache Kafka instances. For more information, see [Billing overview](https://help.aliyun.com/document_detail/84737.html).
         *
         * @param tmpReq UpgradePrePayOrderRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpgradePrePayOrderResponse
         */
        public UpgradePrePayOrderResponse UpgradePrePayOrderWithOptions(UpgradePrePayOrderRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpgradePrePayOrderShrinkRequest request = new UpgradePrePayOrderShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ConfluentConfig))
            {
                request.ConfluentConfigShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ConfluentConfig, "ConfluentConfig", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfluentConfigShrink))
            {
                query["ConfluentConfig"] = request.ConfluentConfigShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DiskSize))
            {
                query["DiskSize"] = request.DiskSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EipMax))
            {
                query["EipMax"] = request.EipMax;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EipModel))
            {
                query["EipModel"] = request.EipModel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IoMax))
            {
                query["IoMax"] = request.IoMax;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IoMaxSpec))
            {
                query["IoMaxSpec"] = request.IoMaxSpec;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PaidType))
            {
                query["PaidType"] = request.PaidType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PartitionNum))
            {
                query["PartitionNum"] = request.PartitionNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SpecType))
            {
                query["SpecType"] = request.SpecType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TopicQuota))
            {
                query["TopicQuota"] = request.TopicQuota;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpgradePrePayOrder",
                Version = "2019-09-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpgradePrePayOrderResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Upgrades a Message Queue for Apache Kafka instance that uses the subscription billing method.
         *
         * @description Before you call this operation, make sure that you understand the billing method and pricing of subscription Message Queue for Apache Kafka instances. For more information, see [Billing overview](https://help.aliyun.com/document_detail/84737.html).
         *
         * @param tmpReq UpgradePrePayOrderRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpgradePrePayOrderResponse
         */
        public async Task<UpgradePrePayOrderResponse> UpgradePrePayOrderWithOptionsAsync(UpgradePrePayOrderRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpgradePrePayOrderShrinkRequest request = new UpgradePrePayOrderShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ConfluentConfig))
            {
                request.ConfluentConfigShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ConfluentConfig, "ConfluentConfig", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConfluentConfigShrink))
            {
                query["ConfluentConfig"] = request.ConfluentConfigShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DiskSize))
            {
                query["DiskSize"] = request.DiskSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EipMax))
            {
                query["EipMax"] = request.EipMax;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EipModel))
            {
                query["EipModel"] = request.EipModel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IoMax))
            {
                query["IoMax"] = request.IoMax;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IoMaxSpec))
            {
                query["IoMaxSpec"] = request.IoMaxSpec;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PaidType))
            {
                query["PaidType"] = request.PaidType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PartitionNum))
            {
                query["PartitionNum"] = request.PartitionNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["RegionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SpecType))
            {
                query["SpecType"] = request.SpecType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TopicQuota))
            {
                query["TopicQuota"] = request.TopicQuota;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpgradePrePayOrder",
                Version = "2019-09-16",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpgradePrePayOrderResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Upgrades a Message Queue for Apache Kafka instance that uses the subscription billing method.
         *
         * @description Before you call this operation, make sure that you understand the billing method and pricing of subscription Message Queue for Apache Kafka instances. For more information, see [Billing overview](https://help.aliyun.com/document_detail/84737.html).
         *
         * @param request UpgradePrePayOrderRequest
         * @return UpgradePrePayOrderResponse
         */
        public UpgradePrePayOrderResponse UpgradePrePayOrder(UpgradePrePayOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpgradePrePayOrderWithOptions(request, runtime);
        }

        /**
         * @summary Upgrades a Message Queue for Apache Kafka instance that uses the subscription billing method.
         *
         * @description Before you call this operation, make sure that you understand the billing method and pricing of subscription Message Queue for Apache Kafka instances. For more information, see [Billing overview](https://help.aliyun.com/document_detail/84737.html).
         *
         * @param request UpgradePrePayOrderRequest
         * @return UpgradePrePayOrderResponse
         */
        public async Task<UpgradePrePayOrderResponse> UpgradePrePayOrderAsync(UpgradePrePayOrderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpgradePrePayOrderWithOptionsAsync(request, runtime);
        }

    }
}
