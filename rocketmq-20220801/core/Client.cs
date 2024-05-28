// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.RocketMQ20220801.Models;

namespace AlibabaCloud.SDK.RocketMQ20220801
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "";
            CheckConfig(config);
            this._endpoint = GetEndpoint("rocketmq", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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
         * @summary Changes the resource group to which a ApsaraMQ for RocketMQ instance belongs.
         *
         * @param request ChangeResourceGroupRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ChangeResourceGroupResponse
         */
        public ChangeResourceGroupResponse ChangeResourceGroupWithOptions(ChangeResourceGroupRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["regionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["resourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceId))
            {
                query["resourceId"] = request.ResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["resourceType"] = request.ResourceType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ChangeResourceGroup",
                Version = "2022-08-01",
                Protocol = "HTTPS",
                Pathname = "/resourceGroup/change",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ChangeResourceGroupResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Changes the resource group to which a ApsaraMQ for RocketMQ instance belongs.
         *
         * @param request ChangeResourceGroupRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ChangeResourceGroupResponse
         */
        public async Task<ChangeResourceGroupResponse> ChangeResourceGroupWithOptionsAsync(ChangeResourceGroupRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["regionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["resourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceId))
            {
                query["resourceId"] = request.ResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["resourceType"] = request.ResourceType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ChangeResourceGroup",
                Version = "2022-08-01",
                Protocol = "HTTPS",
                Pathname = "/resourceGroup/change",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ChangeResourceGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Changes the resource group to which a ApsaraMQ for RocketMQ instance belongs.
         *
         * @param request ChangeResourceGroupRequest
         * @return ChangeResourceGroupResponse
         */
        public ChangeResourceGroupResponse ChangeResourceGroup(ChangeResourceGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ChangeResourceGroupWithOptions(request, headers, runtime);
        }

        /**
         * @summary Changes the resource group to which a ApsaraMQ for RocketMQ instance belongs.
         *
         * @param request ChangeResourceGroupRequest
         * @return ChangeResourceGroupResponse
         */
        public async Task<ChangeResourceGroupResponse> ChangeResourceGroupAsync(ChangeResourceGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ChangeResourceGroupWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary Creates a consumer group.
         *
         * @description > API operations provided by Alibaba Cloud are used to manage and query resources of Alibaba Cloud services. We recommend that you integrate these API operations only in management systems. Do not use these API operations in the core system of messaging services. Otherwise, system risks may occur.
         *
         * @param request CreateConsumerGroupRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateConsumerGroupResponse
         */
        public CreateConsumerGroupResponse CreateConsumerGroupWithOptions(string instanceId, string consumerGroupId, CreateConsumerGroupRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConsumeRetryPolicy))
            {
                body["consumeRetryPolicy"] = request.ConsumeRetryPolicy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeliveryOrderType))
            {
                body["deliveryOrderType"] = request.DeliveryOrderType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Remark))
            {
                body["remark"] = request.Remark;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateConsumerGroup",
                Version = "2022-08-01",
                Protocol = "HTTPS",
                Pathname = "/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/consumerGroups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(consumerGroupId),
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateConsumerGroupResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Creates a consumer group.
         *
         * @description > API operations provided by Alibaba Cloud are used to manage and query resources of Alibaba Cloud services. We recommend that you integrate these API operations only in management systems. Do not use these API operations in the core system of messaging services. Otherwise, system risks may occur.
         *
         * @param request CreateConsumerGroupRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateConsumerGroupResponse
         */
        public async Task<CreateConsumerGroupResponse> CreateConsumerGroupWithOptionsAsync(string instanceId, string consumerGroupId, CreateConsumerGroupRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConsumeRetryPolicy))
            {
                body["consumeRetryPolicy"] = request.ConsumeRetryPolicy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeliveryOrderType))
            {
                body["deliveryOrderType"] = request.DeliveryOrderType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Remark))
            {
                body["remark"] = request.Remark;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateConsumerGroup",
                Version = "2022-08-01",
                Protocol = "HTTPS",
                Pathname = "/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/consumerGroups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(consumerGroupId),
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateConsumerGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Creates a consumer group.
         *
         * @description > API operations provided by Alibaba Cloud are used to manage and query resources of Alibaba Cloud services. We recommend that you integrate these API operations only in management systems. Do not use these API operations in the core system of messaging services. Otherwise, system risks may occur.
         *
         * @param request CreateConsumerGroupRequest
         * @return CreateConsumerGroupResponse
         */
        public CreateConsumerGroupResponse CreateConsumerGroup(string instanceId, string consumerGroupId, CreateConsumerGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateConsumerGroupWithOptions(instanceId, consumerGroupId, request, headers, runtime);
        }

        /**
         * @summary Creates a consumer group.
         *
         * @description > API operations provided by Alibaba Cloud are used to manage and query resources of Alibaba Cloud services. We recommend that you integrate these API operations only in management systems. Do not use these API operations in the core system of messaging services. Otherwise, system risks may occur.
         *
         * @param request CreateConsumerGroupRequest
         * @return CreateConsumerGroupResponse
         */
        public async Task<CreateConsumerGroupResponse> CreateConsumerGroupAsync(string instanceId, string consumerGroupId, CreateConsumerGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateConsumerGroupWithOptionsAsync(instanceId, consumerGroupId, request, headers, runtime);
        }

        /**
         * @summary Creates an ApsaraMQ for RocketMQ 5.x instance.
         *
         * @description > API operations provided by Alibaba Cloud are used to manage and query resources of Alibaba Cloud services. We recommend that you integrate these API operations only in management systems. Do not use these API operations in the core system of messaging services. Otherwise, system risks may occur.
         *
         * @param request CreateInstanceRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateInstanceResponse
         */
        public CreateInstanceResponse CreateInstanceWithOptions(CreateInstanceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["clientToken"] = request.ClientToken;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoRenew))
            {
                body["autoRenew"] = request.AutoRenew;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoRenewPeriod))
            {
                body["autoRenewPeriod"] = request.AutoRenewPeriod;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CommodityCode))
            {
                body["commodityCode"] = request.CommodityCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceName))
            {
                body["instanceName"] = request.InstanceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NetworkInfo))
            {
                body["networkInfo"] = request.NetworkInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PaymentType))
            {
                body["paymentType"] = request.PaymentType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Period))
            {
                body["period"] = request.Period;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PeriodUnit))
            {
                body["periodUnit"] = request.PeriodUnit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductInfo))
            {
                body["productInfo"] = request.ProductInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Remark))
            {
                body["remark"] = request.Remark;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                body["resourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SeriesCode))
            {
                body["seriesCode"] = request.SeriesCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceCode))
            {
                body["serviceCode"] = request.ServiceCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubSeriesCode))
            {
                body["subSeriesCode"] = request.SubSeriesCode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateInstance",
                Version = "2022-08-01",
                Protocol = "HTTPS",
                Pathname = "/instances",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateInstanceResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Creates an ApsaraMQ for RocketMQ 5.x instance.
         *
         * @description > API operations provided by Alibaba Cloud are used to manage and query resources of Alibaba Cloud services. We recommend that you integrate these API operations only in management systems. Do not use these API operations in the core system of messaging services. Otherwise, system risks may occur.
         *
         * @param request CreateInstanceRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateInstanceResponse
         */
        public async Task<CreateInstanceResponse> CreateInstanceWithOptionsAsync(CreateInstanceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["clientToken"] = request.ClientToken;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoRenew))
            {
                body["autoRenew"] = request.AutoRenew;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoRenewPeriod))
            {
                body["autoRenewPeriod"] = request.AutoRenewPeriod;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CommodityCode))
            {
                body["commodityCode"] = request.CommodityCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceName))
            {
                body["instanceName"] = request.InstanceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NetworkInfo))
            {
                body["networkInfo"] = request.NetworkInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PaymentType))
            {
                body["paymentType"] = request.PaymentType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Period))
            {
                body["period"] = request.Period;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PeriodUnit))
            {
                body["periodUnit"] = request.PeriodUnit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductInfo))
            {
                body["productInfo"] = request.ProductInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Remark))
            {
                body["remark"] = request.Remark;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                body["resourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SeriesCode))
            {
                body["seriesCode"] = request.SeriesCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceCode))
            {
                body["serviceCode"] = request.ServiceCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubSeriesCode))
            {
                body["subSeriesCode"] = request.SubSeriesCode;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateInstance",
                Version = "2022-08-01",
                Protocol = "HTTPS",
                Pathname = "/instances",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateInstanceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Creates an ApsaraMQ for RocketMQ 5.x instance.
         *
         * @description > API operations provided by Alibaba Cloud are used to manage and query resources of Alibaba Cloud services. We recommend that you integrate these API operations only in management systems. Do not use these API operations in the core system of messaging services. Otherwise, system risks may occur.
         *
         * @param request CreateInstanceRequest
         * @return CreateInstanceResponse
         */
        public CreateInstanceResponse CreateInstance(CreateInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateInstanceWithOptions(request, headers, runtime);
        }

        /**
         * @summary Creates an ApsaraMQ for RocketMQ 5.x instance.
         *
         * @description > API operations provided by Alibaba Cloud are used to manage and query resources of Alibaba Cloud services. We recommend that you integrate these API operations only in management systems. Do not use these API operations in the core system of messaging services. Otherwise, system risks may occur.
         *
         * @param request CreateInstanceRequest
         * @return CreateInstanceResponse
         */
        public async Task<CreateInstanceResponse> CreateInstanceAsync(CreateInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateInstanceWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary Creates a topic.
         *
         * @param request CreateTopicRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateTopicResponse
         */
        public CreateTopicResponse CreateTopicWithOptions(string instanceId, string topicName, CreateTopicRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MessageType))
            {
                body["messageType"] = request.MessageType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Remark))
            {
                body["remark"] = request.Remark;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateTopic",
                Version = "2022-08-01",
                Protocol = "HTTPS",
                Pathname = "/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/topics/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(topicName),
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateTopicResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Creates a topic.
         *
         * @param request CreateTopicRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateTopicResponse
         */
        public async Task<CreateTopicResponse> CreateTopicWithOptionsAsync(string instanceId, string topicName, CreateTopicRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MessageType))
            {
                body["messageType"] = request.MessageType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Remark))
            {
                body["remark"] = request.Remark;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateTopic",
                Version = "2022-08-01",
                Protocol = "HTTPS",
                Pathname = "/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/topics/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(topicName),
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateTopicResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Creates a topic.
         *
         * @param request CreateTopicRequest
         * @return CreateTopicResponse
         */
        public CreateTopicResponse CreateTopic(string instanceId, string topicName, CreateTopicRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateTopicWithOptions(instanceId, topicName, request, headers, runtime);
        }

        /**
         * @summary Creates a topic.
         *
         * @param request CreateTopicRequest
         * @return CreateTopicResponse
         */
        public async Task<CreateTopicResponse> CreateTopicAsync(string instanceId, string topicName, CreateTopicRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateTopicWithOptionsAsync(instanceId, topicName, request, headers, runtime);
        }

        /**
         * @summary Deletes a specified consumer group.
         *
         * @description > API operations provided by Alibaba Cloud are used to manage and query resources of Alibaba Cloud services. We recommend that you integrate these API operations only in management systems. Do not use these API operations in the core system of messaging services. Otherwise, system risks may occur.
         * After you delete a consumer group, the consumer client associated with the consumer group cannot consume messages. Exercise caution when you call this operation.
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteConsumerGroupResponse
         */
        public DeleteConsumerGroupResponse DeleteConsumerGroupWithOptions(string instanceId, string consumerGroupId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteConsumerGroup",
                Version = "2022-08-01",
                Protocol = "HTTPS",
                Pathname = "/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/consumerGroups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(consumerGroupId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteConsumerGroupResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Deletes a specified consumer group.
         *
         * @description > API operations provided by Alibaba Cloud are used to manage and query resources of Alibaba Cloud services. We recommend that you integrate these API operations only in management systems. Do not use these API operations in the core system of messaging services. Otherwise, system risks may occur.
         * After you delete a consumer group, the consumer client associated with the consumer group cannot consume messages. Exercise caution when you call this operation.
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteConsumerGroupResponse
         */
        public async Task<DeleteConsumerGroupResponse> DeleteConsumerGroupWithOptionsAsync(string instanceId, string consumerGroupId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteConsumerGroup",
                Version = "2022-08-01",
                Protocol = "HTTPS",
                Pathname = "/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/consumerGroups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(consumerGroupId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteConsumerGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Deletes a specified consumer group.
         *
         * @description > API operations provided by Alibaba Cloud are used to manage and query resources of Alibaba Cloud services. We recommend that you integrate these API operations only in management systems. Do not use these API operations in the core system of messaging services. Otherwise, system risks may occur.
         * After you delete a consumer group, the consumer client associated with the consumer group cannot consume messages. Exercise caution when you call this operation.
         *
         * @return DeleteConsumerGroupResponse
         */
        public DeleteConsumerGroupResponse DeleteConsumerGroup(string instanceId, string consumerGroupId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteConsumerGroupWithOptions(instanceId, consumerGroupId, headers, runtime);
        }

        /**
         * @summary Deletes a specified consumer group.
         *
         * @description > API operations provided by Alibaba Cloud are used to manage and query resources of Alibaba Cloud services. We recommend that you integrate these API operations only in management systems. Do not use these API operations in the core system of messaging services. Otherwise, system risks may occur.
         * After you delete a consumer group, the consumer client associated with the consumer group cannot consume messages. Exercise caution when you call this operation.
         *
         * @return DeleteConsumerGroupResponse
         */
        public async Task<DeleteConsumerGroupResponse> DeleteConsumerGroupAsync(string instanceId, string consumerGroupId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteConsumerGroupWithOptionsAsync(instanceId, consumerGroupId, headers, runtime);
        }

        /**
         * @summary Deletes a ApsaraMQ for RocketMQ instance.
         *
         * @description > API operations provided by Alibaba Cloud are used to manage and query resources of Alibaba Cloud services. We recommend that you integrate these API operations only in management systems. Do not use these API operations in the core system of messaging services. Otherwise, system risks may occur.
         * *   After an instance is deleted, the instance cannot be restored. Exercise caution when you call this operation.
         * *   This operation is used to delete a pay-as-you-go instance. A subscription instance is automatically released after it expires. You do not need to manually delete a subscription instance.
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteInstanceResponse
         */
        public DeleteInstanceResponse DeleteInstanceWithOptions(string instanceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteInstance",
                Version = "2022-08-01",
                Protocol = "HTTPS",
                Pathname = "/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteInstanceResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Deletes a ApsaraMQ for RocketMQ instance.
         *
         * @description > API operations provided by Alibaba Cloud are used to manage and query resources of Alibaba Cloud services. We recommend that you integrate these API operations only in management systems. Do not use these API operations in the core system of messaging services. Otherwise, system risks may occur.
         * *   After an instance is deleted, the instance cannot be restored. Exercise caution when you call this operation.
         * *   This operation is used to delete a pay-as-you-go instance. A subscription instance is automatically released after it expires. You do not need to manually delete a subscription instance.
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteInstanceResponse
         */
        public async Task<DeleteInstanceResponse> DeleteInstanceWithOptionsAsync(string instanceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteInstance",
                Version = "2022-08-01",
                Protocol = "HTTPS",
                Pathname = "/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteInstanceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Deletes a ApsaraMQ for RocketMQ instance.
         *
         * @description > API operations provided by Alibaba Cloud are used to manage and query resources of Alibaba Cloud services. We recommend that you integrate these API operations only in management systems. Do not use these API operations in the core system of messaging services. Otherwise, system risks may occur.
         * *   After an instance is deleted, the instance cannot be restored. Exercise caution when you call this operation.
         * *   This operation is used to delete a pay-as-you-go instance. A subscription instance is automatically released after it expires. You do not need to manually delete a subscription instance.
         *
         * @return DeleteInstanceResponse
         */
        public DeleteInstanceResponse DeleteInstance(string instanceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteInstanceWithOptions(instanceId, headers, runtime);
        }

        /**
         * @summary Deletes a ApsaraMQ for RocketMQ instance.
         *
         * @description > API operations provided by Alibaba Cloud are used to manage and query resources of Alibaba Cloud services. We recommend that you integrate these API operations only in management systems. Do not use these API operations in the core system of messaging services. Otherwise, system risks may occur.
         * *   After an instance is deleted, the instance cannot be restored. Exercise caution when you call this operation.
         * *   This operation is used to delete a pay-as-you-go instance. A subscription instance is automatically released after it expires. You do not need to manually delete a subscription instance.
         *
         * @return DeleteInstanceResponse
         */
        public async Task<DeleteInstanceResponse> DeleteInstanceAsync(string instanceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteInstanceWithOptionsAsync(instanceId, headers, runtime);
        }

        /**
         * @summary Deletes a specified topic.
         *
         * @description If you delete the topic, the publishing and subscription relationships that are established based on the topic are cleared. Exercise caution when you call this operation.
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteTopicResponse
         */
        public DeleteTopicResponse DeleteTopicWithOptions(string instanceId, string topicName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteTopic",
                Version = "2022-08-01",
                Protocol = "HTTPS",
                Pathname = "/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/topics/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(topicName),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteTopicResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Deletes a specified topic.
         *
         * @description If you delete the topic, the publishing and subscription relationships that are established based on the topic are cleared. Exercise caution when you call this operation.
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteTopicResponse
         */
        public async Task<DeleteTopicResponse> DeleteTopicWithOptionsAsync(string instanceId, string topicName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteTopic",
                Version = "2022-08-01",
                Protocol = "HTTPS",
                Pathname = "/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/topics/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(topicName),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteTopicResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Deletes a specified topic.
         *
         * @description If you delete the topic, the publishing and subscription relationships that are established based on the topic are cleared. Exercise caution when you call this operation.
         *
         * @return DeleteTopicResponse
         */
        public DeleteTopicResponse DeleteTopic(string instanceId, string topicName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteTopicWithOptions(instanceId, topicName, headers, runtime);
        }

        /**
         * @summary Deletes a specified topic.
         *
         * @description If you delete the topic, the publishing and subscription relationships that are established based on the topic are cleared. Exercise caution when you call this operation.
         *
         * @return DeleteTopicResponse
         */
        public async Task<DeleteTopicResponse> DeleteTopicAsync(string instanceId, string topicName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteTopicWithOptionsAsync(instanceId, topicName, headers, runtime);
        }

        /**
         * @summary Queries the details of a specified consumer group.
         *
         * @description > API operations provided by Alibaba Cloud are used to manage and query resources of Alibaba Cloud services. We recommend that you integrate these API operations only in management systems. Do not use these API operations in the core system of messaging services. Otherwise, system risks may occur.
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetConsumerGroupResponse
         */
        public GetConsumerGroupResponse GetConsumerGroupWithOptions(string instanceId, string consumerGroupId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetConsumerGroup",
                Version = "2022-08-01",
                Protocol = "HTTPS",
                Pathname = "/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/consumerGroups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(consumerGroupId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetConsumerGroupResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the details of a specified consumer group.
         *
         * @description > API operations provided by Alibaba Cloud are used to manage and query resources of Alibaba Cloud services. We recommend that you integrate these API operations only in management systems. Do not use these API operations in the core system of messaging services. Otherwise, system risks may occur.
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetConsumerGroupResponse
         */
        public async Task<GetConsumerGroupResponse> GetConsumerGroupWithOptionsAsync(string instanceId, string consumerGroupId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetConsumerGroup",
                Version = "2022-08-01",
                Protocol = "HTTPS",
                Pathname = "/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/consumerGroups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(consumerGroupId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetConsumerGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the details of a specified consumer group.
         *
         * @description > API operations provided by Alibaba Cloud are used to manage and query resources of Alibaba Cloud services. We recommend that you integrate these API operations only in management systems. Do not use these API operations in the core system of messaging services. Otherwise, system risks may occur.
         *
         * @return GetConsumerGroupResponse
         */
        public GetConsumerGroupResponse GetConsumerGroup(string instanceId, string consumerGroupId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetConsumerGroupWithOptions(instanceId, consumerGroupId, headers, runtime);
        }

        /**
         * @summary Queries the details of a specified consumer group.
         *
         * @description > API operations provided by Alibaba Cloud are used to manage and query resources of Alibaba Cloud services. We recommend that you integrate these API operations only in management systems. Do not use these API operations in the core system of messaging services. Otherwise, system risks may occur.
         *
         * @return GetConsumerGroupResponse
         */
        public async Task<GetConsumerGroupResponse> GetConsumerGroupAsync(string instanceId, string consumerGroupId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetConsumerGroupWithOptionsAsync(instanceId, consumerGroupId, headers, runtime);
        }

        /**
         * @summary Queries the detailed information about an instance.
         *
         * @description > API operations provided by Alibaba Cloud are used to manage and query resources of Alibaba Cloud services. We recommend that you integrate these API operations only in management systems. Do not use these API operations in the core system of messaging services. Otherwise, system risks may occur.
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetInstanceResponse
         */
        public GetInstanceResponse GetInstanceWithOptions(string instanceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetInstance",
                Version = "2022-08-01",
                Protocol = "HTTPS",
                Pathname = "/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetInstanceResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the detailed information about an instance.
         *
         * @description > API operations provided by Alibaba Cloud are used to manage and query resources of Alibaba Cloud services. We recommend that you integrate these API operations only in management systems. Do not use these API operations in the core system of messaging services. Otherwise, system risks may occur.
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetInstanceResponse
         */
        public async Task<GetInstanceResponse> GetInstanceWithOptionsAsync(string instanceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetInstance",
                Version = "2022-08-01",
                Protocol = "HTTPS",
                Pathname = "/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetInstanceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the detailed information about an instance.
         *
         * @description > API operations provided by Alibaba Cloud are used to manage and query resources of Alibaba Cloud services. We recommend that you integrate these API operations only in management systems. Do not use these API operations in the core system of messaging services. Otherwise, system risks may occur.
         *
         * @return GetInstanceResponse
         */
        public GetInstanceResponse GetInstance(string instanceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetInstanceWithOptions(instanceId, headers, runtime);
        }

        /**
         * @summary Queries the detailed information about an instance.
         *
         * @description > API operations provided by Alibaba Cloud are used to manage and query resources of Alibaba Cloud services. We recommend that you integrate these API operations only in management systems. Do not use these API operations in the core system of messaging services. Otherwise, system risks may occur.
         *
         * @return GetInstanceResponse
         */
        public async Task<GetInstanceResponse> GetInstanceAsync(string instanceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetInstanceWithOptionsAsync(instanceId, headers, runtime);
        }

        /**
         * @summary Queries the details of a specified topic.
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetTopicResponse
         */
        public GetTopicResponse GetTopicWithOptions(string instanceId, string topicName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetTopic",
                Version = "2022-08-01",
                Protocol = "HTTPS",
                Pathname = "/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/topics/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(topicName),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTopicResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the details of a specified topic.
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetTopicResponse
         */
        public async Task<GetTopicResponse> GetTopicWithOptionsAsync(string instanceId, string topicName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetTopic",
                Version = "2022-08-01",
                Protocol = "HTTPS",
                Pathname = "/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/topics/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(topicName),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTopicResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the details of a specified topic.
         *
         * @return GetTopicResponse
         */
        public GetTopicResponse GetTopic(string instanceId, string topicName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetTopicWithOptions(instanceId, topicName, headers, runtime);
        }

        /**
         * @summary Queries the details of a specified topic.
         *
         * @return GetTopicResponse
         */
        public async Task<GetTopicResponse> GetTopicAsync(string instanceId, string topicName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetTopicWithOptionsAsync(instanceId, topicName, headers, runtime);
        }

        /**
         * @summary 查询支持的可用区
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListAvailableZonesResponse
         */
        public ListAvailableZonesResponse ListAvailableZonesWithOptions(Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListAvailableZones",
                Version = "2022-08-01",
                Protocol = "HTTPS",
                Pathname = "/zones",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAvailableZonesResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 查询支持的可用区
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListAvailableZonesResponse
         */
        public async Task<ListAvailableZonesResponse> ListAvailableZonesWithOptionsAsync(Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListAvailableZones",
                Version = "2022-08-01",
                Protocol = "HTTPS",
                Pathname = "/zones",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAvailableZonesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 查询支持的可用区
         *
         * @return ListAvailableZonesResponse
         */
        public ListAvailableZonesResponse ListAvailableZones()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListAvailableZonesWithOptions(headers, runtime);
        }

        /**
         * @summary 查询支持的可用区
         *
         * @return ListAvailableZonesResponse
         */
        public async Task<ListAvailableZonesResponse> ListAvailableZonesAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListAvailableZonesWithOptionsAsync(headers, runtime);
        }

        /**
         * @summary 查询消费者客户端连接信息
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListConsumerConnectionsResponse
         */
        public ListConsumerConnectionsResponse ListConsumerConnectionsWithOptions(string instanceId, string consumerGroupId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListConsumerConnections",
                Version = "2022-08-01",
                Protocol = "HTTPS",
                Pathname = "/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/consumerGroups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(consumerGroupId) + "/connections",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListConsumerConnectionsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 查询消费者客户端连接信息
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListConsumerConnectionsResponse
         */
        public async Task<ListConsumerConnectionsResponse> ListConsumerConnectionsWithOptionsAsync(string instanceId, string consumerGroupId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListConsumerConnections",
                Version = "2022-08-01",
                Protocol = "HTTPS",
                Pathname = "/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/consumerGroups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(consumerGroupId) + "/connections",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListConsumerConnectionsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 查询消费者客户端连接信息
         *
         * @return ListConsumerConnectionsResponse
         */
        public ListConsumerConnectionsResponse ListConsumerConnections(string instanceId, string consumerGroupId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListConsumerConnectionsWithOptions(instanceId, consumerGroupId, headers, runtime);
        }

        /**
         * @summary 查询消费者客户端连接信息
         *
         * @return ListConsumerConnectionsResponse
         */
        public async Task<ListConsumerConnectionsResponse> ListConsumerConnectionsAsync(string instanceId, string consumerGroupId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListConsumerConnectionsWithOptionsAsync(instanceId, consumerGroupId, headers, runtime);
        }

        /**
         * @summary Queries the subscriptions of a consumer group.
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListConsumerGroupSubscriptionsResponse
         */
        public ListConsumerGroupSubscriptionsResponse ListConsumerGroupSubscriptionsWithOptions(string instanceId, string consumerGroupId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListConsumerGroupSubscriptions",
                Version = "2022-08-01",
                Protocol = "HTTPS",
                Pathname = "/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/consumerGroups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(consumerGroupId) + "/subscriptions",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListConsumerGroupSubscriptionsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the subscriptions of a consumer group.
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListConsumerGroupSubscriptionsResponse
         */
        public async Task<ListConsumerGroupSubscriptionsResponse> ListConsumerGroupSubscriptionsWithOptionsAsync(string instanceId, string consumerGroupId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListConsumerGroupSubscriptions",
                Version = "2022-08-01",
                Protocol = "HTTPS",
                Pathname = "/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/consumerGroups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(consumerGroupId) + "/subscriptions",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListConsumerGroupSubscriptionsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the subscriptions of a consumer group.
         *
         * @return ListConsumerGroupSubscriptionsResponse
         */
        public ListConsumerGroupSubscriptionsResponse ListConsumerGroupSubscriptions(string instanceId, string consumerGroupId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListConsumerGroupSubscriptionsWithOptions(instanceId, consumerGroupId, headers, runtime);
        }

        /**
         * @summary Queries the subscriptions of a consumer group.
         *
         * @return ListConsumerGroupSubscriptionsResponse
         */
        public async Task<ListConsumerGroupSubscriptionsResponse> ListConsumerGroupSubscriptionsAsync(string instanceId, string consumerGroupId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListConsumerGroupSubscriptionsWithOptionsAsync(instanceId, consumerGroupId, headers, runtime);
        }

        /**
         * @summary Queries the consumer groups in a specified instance.
         *
         * @description > API operations provided by Alibaba Cloud are used to manage and query resources of Alibaba Cloud services. We recommend that you integrate these API operations only in management systems. Do not use these API operations in the core system of messaging services. Otherwise, system risks may occur.
         *
         * @param request ListConsumerGroupsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListConsumerGroupsResponse
         */
        public ListConsumerGroupsResponse ListConsumerGroupsWithOptions(string instanceId, ListConsumerGroupsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Filter))
            {
                query["filter"] = request.Filter;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListConsumerGroups",
                Version = "2022-08-01",
                Protocol = "HTTPS",
                Pathname = "/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/consumerGroups",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListConsumerGroupsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the consumer groups in a specified instance.
         *
         * @description > API operations provided by Alibaba Cloud are used to manage and query resources of Alibaba Cloud services. We recommend that you integrate these API operations only in management systems. Do not use these API operations in the core system of messaging services. Otherwise, system risks may occur.
         *
         * @param request ListConsumerGroupsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListConsumerGroupsResponse
         */
        public async Task<ListConsumerGroupsResponse> ListConsumerGroupsWithOptionsAsync(string instanceId, ListConsumerGroupsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Filter))
            {
                query["filter"] = request.Filter;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListConsumerGroups",
                Version = "2022-08-01",
                Protocol = "HTTPS",
                Pathname = "/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/consumerGroups",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListConsumerGroupsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the consumer groups in a specified instance.
         *
         * @description > API operations provided by Alibaba Cloud are used to manage and query resources of Alibaba Cloud services. We recommend that you integrate these API operations only in management systems. Do not use these API operations in the core system of messaging services. Otherwise, system risks may occur.
         *
         * @param request ListConsumerGroupsRequest
         * @return ListConsumerGroupsResponse
         */
        public ListConsumerGroupsResponse ListConsumerGroups(string instanceId, ListConsumerGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListConsumerGroupsWithOptions(instanceId, request, headers, runtime);
        }

        /**
         * @summary Queries the consumer groups in a specified instance.
         *
         * @description > API operations provided by Alibaba Cloud are used to manage and query resources of Alibaba Cloud services. We recommend that you integrate these API operations only in management systems. Do not use these API operations in the core system of messaging services. Otherwise, system risks may occur.
         *
         * @param request ListConsumerGroupsRequest
         * @return ListConsumerGroupsResponse
         */
        public async Task<ListConsumerGroupsResponse> ListConsumerGroupsAsync(string instanceId, ListConsumerGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListConsumerGroupsWithOptionsAsync(instanceId, request, headers, runtime);
        }

        /**
         * @summary Queries instances.
         *
         * @description > API operations provided by Alibaba Cloud are used to manage and query resources of Alibaba Cloud services. We recommend that you integrate these API operations only in management systems. Do not use these API operations in the core system of messaging services. Otherwise, system risks may occur.
         *
         * @param request ListInstancesRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListInstancesResponse
         */
        public ListInstancesResponse ListInstancesWithOptions(ListInstancesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Filter))
            {
                query["filter"] = request.Filter;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["resourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tags))
            {
                query["tags"] = request.Tags;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListInstances",
                Version = "2022-08-01",
                Protocol = "HTTPS",
                Pathname = "/instances",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListInstancesResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries instances.
         *
         * @description > API operations provided by Alibaba Cloud are used to manage and query resources of Alibaba Cloud services. We recommend that you integrate these API operations only in management systems. Do not use these API operations in the core system of messaging services. Otherwise, system risks may occur.
         *
         * @param request ListInstancesRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListInstancesResponse
         */
        public async Task<ListInstancesResponse> ListInstancesWithOptionsAsync(ListInstancesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Filter))
            {
                query["filter"] = request.Filter;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["resourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tags))
            {
                query["tags"] = request.Tags;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListInstances",
                Version = "2022-08-01",
                Protocol = "HTTPS",
                Pathname = "/instances",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListInstancesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries instances.
         *
         * @description > API operations provided by Alibaba Cloud are used to manage and query resources of Alibaba Cloud services. We recommend that you integrate these API operations only in management systems. Do not use these API operations in the core system of messaging services. Otherwise, system risks may occur.
         *
         * @param request ListInstancesRequest
         * @return ListInstancesResponse
         */
        public ListInstancesResponse ListInstances(ListInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListInstancesWithOptions(request, headers, runtime);
        }

        /**
         * @summary Queries instances.
         *
         * @description > API operations provided by Alibaba Cloud are used to manage and query resources of Alibaba Cloud services. We recommend that you integrate these API operations only in management systems. Do not use these API operations in the core system of messaging services. Otherwise, system risks may occur.
         *
         * @param request ListInstancesRequest
         * @return ListInstancesResponse
         */
        public async Task<ListInstancesResponse> ListInstancesAsync(ListInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListInstancesWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 查询region列表
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListRegionsResponse
         */
        public ListRegionsResponse ListRegionsWithOptions(Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListRegions",
                Version = "2022-08-01",
                Protocol = "HTTPS",
                Pathname = "/regions",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListRegionsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 查询region列表
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListRegionsResponse
         */
        public async Task<ListRegionsResponse> ListRegionsWithOptionsAsync(Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListRegions",
                Version = "2022-08-01",
                Protocol = "HTTPS",
                Pathname = "/regions",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListRegionsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 查询region列表
         *
         * @return ListRegionsResponse
         */
        public ListRegionsResponse ListRegions()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListRegionsWithOptions(headers, runtime);
        }

        /**
         * @summary 查询region列表
         *
         * @return ListRegionsResponse
         */
        public async Task<ListRegionsResponse> ListRegionsAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListRegionsWithOptionsAsync(headers, runtime);
        }

        /**
         * @summary 查询主题订阅关系列表
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListTopicSubscriptionsResponse
         */
        public ListTopicSubscriptionsResponse ListTopicSubscriptionsWithOptions(string instanceId, string topicName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTopicSubscriptions",
                Version = "2022-08-01",
                Protocol = "HTTPS",
                Pathname = "/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/topics/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(topicName) + "/subscriptions",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTopicSubscriptionsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 查询主题订阅关系列表
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListTopicSubscriptionsResponse
         */
        public async Task<ListTopicSubscriptionsResponse> ListTopicSubscriptionsWithOptionsAsync(string instanceId, string topicName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTopicSubscriptions",
                Version = "2022-08-01",
                Protocol = "HTTPS",
                Pathname = "/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/topics/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(topicName) + "/subscriptions",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTopicSubscriptionsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 查询主题订阅关系列表
         *
         * @return ListTopicSubscriptionsResponse
         */
        public ListTopicSubscriptionsResponse ListTopicSubscriptions(string instanceId, string topicName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListTopicSubscriptionsWithOptions(instanceId, topicName, headers, runtime);
        }

        /**
         * @summary 查询主题订阅关系列表
         *
         * @return ListTopicSubscriptionsResponse
         */
        public async Task<ListTopicSubscriptionsResponse> ListTopicSubscriptionsAsync(string instanceId, string topicName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListTopicSubscriptionsWithOptionsAsync(instanceId, topicName, headers, runtime);
        }

        /**
         * @summary Queries the topics in a specified instance.
         *
         * @param tmpReq ListTopicsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListTopicsResponse
         */
        public ListTopicsResponse ListTopicsWithOptions(string instanceId, ListTopicsRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListTopicsShrinkRequest request = new ListTopicsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.MessageTypes))
            {
                request.MessageTypesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.MessageTypes, "messageTypes", "simple");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Filter))
            {
                query["filter"] = request.Filter;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MessageTypesShrink))
            {
                query["messageTypes"] = request.MessageTypesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTopics",
                Version = "2022-08-01",
                Protocol = "HTTPS",
                Pathname = "/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/topics",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTopicsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the topics in a specified instance.
         *
         * @param tmpReq ListTopicsRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListTopicsResponse
         */
        public async Task<ListTopicsResponse> ListTopicsWithOptionsAsync(string instanceId, ListTopicsRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListTopicsShrinkRequest request = new ListTopicsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.MessageTypes))
            {
                request.MessageTypesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.MessageTypes, "messageTypes", "simple");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Filter))
            {
                query["filter"] = request.Filter;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MessageTypesShrink))
            {
                query["messageTypes"] = request.MessageTypesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTopics",
                Version = "2022-08-01",
                Protocol = "HTTPS",
                Pathname = "/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/topics",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTopicsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the topics in a specified instance.
         *
         * @param request ListTopicsRequest
         * @return ListTopicsResponse
         */
        public ListTopicsResponse ListTopics(string instanceId, ListTopicsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListTopicsWithOptions(instanceId, request, headers, runtime);
        }

        /**
         * @summary Queries the topics in a specified instance.
         *
         * @param request ListTopicsRequest
         * @return ListTopicsResponse
         */
        public async Task<ListTopicsResponse> ListTopicsAsync(string instanceId, ListTopicsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListTopicsWithOptionsAsync(instanceId, request, headers, runtime);
        }

        /**
         * @summary Resets the consumer offset of a consumer group.
         *
         * @param request ResetConsumeOffsetRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ResetConsumeOffsetResponse
         */
        public ResetConsumeOffsetResponse ResetConsumeOffsetWithOptions(string instanceId, string consumerGroupId, string topicName, ResetConsumeOffsetRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResetTime))
            {
                body["resetTime"] = request.ResetTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResetType))
            {
                body["resetType"] = request.ResetType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ResetConsumeOffset",
                Version = "2022-08-01",
                Protocol = "HTTPS",
                Pathname = "/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/consumerGroups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(consumerGroupId) + "/consumeOffsets/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(topicName),
                Method = "PATCH",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ResetConsumeOffsetResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Resets the consumer offset of a consumer group.
         *
         * @param request ResetConsumeOffsetRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ResetConsumeOffsetResponse
         */
        public async Task<ResetConsumeOffsetResponse> ResetConsumeOffsetWithOptionsAsync(string instanceId, string consumerGroupId, string topicName, ResetConsumeOffsetRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResetTime))
            {
                body["resetTime"] = request.ResetTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResetType))
            {
                body["resetType"] = request.ResetType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ResetConsumeOffset",
                Version = "2022-08-01",
                Protocol = "HTTPS",
                Pathname = "/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/consumerGroups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(consumerGroupId) + "/consumeOffsets/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(topicName),
                Method = "PATCH",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ResetConsumeOffsetResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Resets the consumer offset of a consumer group.
         *
         * @param request ResetConsumeOffsetRequest
         * @return ResetConsumeOffsetResponse
         */
        public ResetConsumeOffsetResponse ResetConsumeOffset(string instanceId, string consumerGroupId, string topicName, ResetConsumeOffsetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ResetConsumeOffsetWithOptions(instanceId, consumerGroupId, topicName, request, headers, runtime);
        }

        /**
         * @summary Resets the consumer offset of a consumer group.
         *
         * @param request ResetConsumeOffsetRequest
         * @return ResetConsumeOffsetResponse
         */
        public async Task<ResetConsumeOffsetResponse> ResetConsumeOffsetAsync(string instanceId, string consumerGroupId, string topicName, ResetConsumeOffsetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ResetConsumeOffsetWithOptionsAsync(instanceId, consumerGroupId, topicName, request, headers, runtime);
        }

        /**
         * @summary Updates the basic information about and the consumption retry policy of a consumer group.
         *
         * @description > API operations provided by Alibaba Cloud are used to manage and query resources of Alibaba Cloud services. We recommend that you integrate these API operations only in management systems. Do not use these API operations in the core system of messaging services. Otherwise, system risks may occur.
         *
         * @param request UpdateConsumerGroupRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateConsumerGroupResponse
         */
        public UpdateConsumerGroupResponse UpdateConsumerGroupWithOptions(string instanceId, string consumerGroupId, UpdateConsumerGroupRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConsumeRetryPolicy))
            {
                body["consumeRetryPolicy"] = request.ConsumeRetryPolicy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeliveryOrderType))
            {
                body["deliveryOrderType"] = request.DeliveryOrderType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Remark))
            {
                body["remark"] = request.Remark;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateConsumerGroup",
                Version = "2022-08-01",
                Protocol = "HTTPS",
                Pathname = "/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/consumerGroups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(consumerGroupId),
                Method = "PATCH",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateConsumerGroupResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Updates the basic information about and the consumption retry policy of a consumer group.
         *
         * @description > API operations provided by Alibaba Cloud are used to manage and query resources of Alibaba Cloud services. We recommend that you integrate these API operations only in management systems. Do not use these API operations in the core system of messaging services. Otherwise, system risks may occur.
         *
         * @param request UpdateConsumerGroupRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateConsumerGroupResponse
         */
        public async Task<UpdateConsumerGroupResponse> UpdateConsumerGroupWithOptionsAsync(string instanceId, string consumerGroupId, UpdateConsumerGroupRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConsumeRetryPolicy))
            {
                body["consumeRetryPolicy"] = request.ConsumeRetryPolicy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeliveryOrderType))
            {
                body["deliveryOrderType"] = request.DeliveryOrderType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Remark))
            {
                body["remark"] = request.Remark;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateConsumerGroup",
                Version = "2022-08-01",
                Protocol = "HTTPS",
                Pathname = "/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/consumerGroups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(consumerGroupId),
                Method = "PATCH",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateConsumerGroupResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Updates the basic information about and the consumption retry policy of a consumer group.
         *
         * @description > API operations provided by Alibaba Cloud are used to manage and query resources of Alibaba Cloud services. We recommend that you integrate these API operations only in management systems. Do not use these API operations in the core system of messaging services. Otherwise, system risks may occur.
         *
         * @param request UpdateConsumerGroupRequest
         * @return UpdateConsumerGroupResponse
         */
        public UpdateConsumerGroupResponse UpdateConsumerGroup(string instanceId, string consumerGroupId, UpdateConsumerGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateConsumerGroupWithOptions(instanceId, consumerGroupId, request, headers, runtime);
        }

        /**
         * @summary Updates the basic information about and the consumption retry policy of a consumer group.
         *
         * @description > API operations provided by Alibaba Cloud are used to manage and query resources of Alibaba Cloud services. We recommend that you integrate these API operations only in management systems. Do not use these API operations in the core system of messaging services. Otherwise, system risks may occur.
         *
         * @param request UpdateConsumerGroupRequest
         * @return UpdateConsumerGroupResponse
         */
        public async Task<UpdateConsumerGroupResponse> UpdateConsumerGroupAsync(string instanceId, string consumerGroupId, UpdateConsumerGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateConsumerGroupWithOptionsAsync(instanceId, consumerGroupId, request, headers, runtime);
        }

        /**
         * @summary Updates the basic information and specifications of an ApsaraMQ for RocketMQ instance.
         *
         * @description > API operations provided by Alibaba Cloud are used to manage and query resources of Alibaba Cloud services. We recommend that you integrate these API operations only in management systems. Do not use these API operations in the core system of messaging services. Otherwise, system risks may occur.
         *
         * @param request UpdateInstanceRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateInstanceResponse
         */
        public UpdateInstanceResponse UpdateInstanceWithOptions(string instanceId, UpdateInstanceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AclInfo))
            {
                body["aclInfo"] = request.AclInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceName))
            {
                body["instanceName"] = request.InstanceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NetworkInfo))
            {
                body["networkInfo"] = request.NetworkInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductInfo))
            {
                body["productInfo"] = request.ProductInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Remark))
            {
                body["remark"] = request.Remark;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateInstance",
                Version = "2022-08-01",
                Protocol = "HTTPS",
                Pathname = "/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId),
                Method = "PATCH",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateInstanceResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Updates the basic information and specifications of an ApsaraMQ for RocketMQ instance.
         *
         * @description > API operations provided by Alibaba Cloud are used to manage and query resources of Alibaba Cloud services. We recommend that you integrate these API operations only in management systems. Do not use these API operations in the core system of messaging services. Otherwise, system risks may occur.
         *
         * @param request UpdateInstanceRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateInstanceResponse
         */
        public async Task<UpdateInstanceResponse> UpdateInstanceWithOptionsAsync(string instanceId, UpdateInstanceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AclInfo))
            {
                body["aclInfo"] = request.AclInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceName))
            {
                body["instanceName"] = request.InstanceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NetworkInfo))
            {
                body["networkInfo"] = request.NetworkInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductInfo))
            {
                body["productInfo"] = request.ProductInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Remark))
            {
                body["remark"] = request.Remark;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateInstance",
                Version = "2022-08-01",
                Protocol = "HTTPS",
                Pathname = "/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId),
                Method = "PATCH",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateInstanceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Updates the basic information and specifications of an ApsaraMQ for RocketMQ instance.
         *
         * @description > API operations provided by Alibaba Cloud are used to manage and query resources of Alibaba Cloud services. We recommend that you integrate these API operations only in management systems. Do not use these API operations in the core system of messaging services. Otherwise, system risks may occur.
         *
         * @param request UpdateInstanceRequest
         * @return UpdateInstanceResponse
         */
        public UpdateInstanceResponse UpdateInstance(string instanceId, UpdateInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateInstanceWithOptions(instanceId, request, headers, runtime);
        }

        /**
         * @summary Updates the basic information and specifications of an ApsaraMQ for RocketMQ instance.
         *
         * @description > API operations provided by Alibaba Cloud are used to manage and query resources of Alibaba Cloud services. We recommend that you integrate these API operations only in management systems. Do not use these API operations in the core system of messaging services. Otherwise, system risks may occur.
         *
         * @param request UpdateInstanceRequest
         * @return UpdateInstanceResponse
         */
        public async Task<UpdateInstanceResponse> UpdateInstanceAsync(string instanceId, UpdateInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateInstanceWithOptionsAsync(instanceId, request, headers, runtime);
        }

        /**
         * @summary Updates the basic information about a topic.
         *
         * @param request UpdateTopicRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateTopicResponse
         */
        public UpdateTopicResponse UpdateTopicWithOptions(string instanceId, string topicName, UpdateTopicRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Remark))
            {
                body["remark"] = request.Remark;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateTopic",
                Version = "2022-08-01",
                Protocol = "HTTPS",
                Pathname = "/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/topics/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(topicName),
                Method = "PATCH",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateTopicResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Updates the basic information about a topic.
         *
         * @param request UpdateTopicRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateTopicResponse
         */
        public async Task<UpdateTopicResponse> UpdateTopicWithOptionsAsync(string instanceId, string topicName, UpdateTopicRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Remark))
            {
                body["remark"] = request.Remark;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateTopic",
                Version = "2022-08-01",
                Protocol = "HTTPS",
                Pathname = "/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/topics/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(topicName),
                Method = "PATCH",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateTopicResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Updates the basic information about a topic.
         *
         * @param request UpdateTopicRequest
         * @return UpdateTopicResponse
         */
        public UpdateTopicResponse UpdateTopic(string instanceId, string topicName, UpdateTopicRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateTopicWithOptions(instanceId, topicName, request, headers, runtime);
        }

        /**
         * @summary Updates the basic information about a topic.
         *
         * @param request UpdateTopicRequest
         * @return UpdateTopicResponse
         */
        public async Task<UpdateTopicResponse> UpdateTopicAsync(string instanceId, string topicName, UpdateTopicRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateTopicWithOptionsAsync(instanceId, topicName, request, headers, runtime);
        }

    }
}
