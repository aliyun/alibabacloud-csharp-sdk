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
         * @summary 创建访问控制acl用户
         *
         * @param request CreateInstanceAccountRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateInstanceAccountResponse
         */
        public CreateInstanceAccountResponse CreateInstanceAccountWithOptions(string instanceId, CreateInstanceAccountRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Password))
            {
                body["password"] = request.Password;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Username))
            {
                body["username"] = request.Username;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateInstanceAccount",
                Version = "2022-08-01",
                Protocol = "HTTPS",
                Pathname = "/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/accounts",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateInstanceAccountResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 创建访问控制acl用户
         *
         * @param request CreateInstanceAccountRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateInstanceAccountResponse
         */
        public async Task<CreateInstanceAccountResponse> CreateInstanceAccountWithOptionsAsync(string instanceId, CreateInstanceAccountRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Password))
            {
                body["password"] = request.Password;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Username))
            {
                body["username"] = request.Username;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateInstanceAccount",
                Version = "2022-08-01",
                Protocol = "HTTPS",
                Pathname = "/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/accounts",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateInstanceAccountResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 创建访问控制acl用户
         *
         * @param request CreateInstanceAccountRequest
         * @return CreateInstanceAccountResponse
         */
        public CreateInstanceAccountResponse CreateInstanceAccount(string instanceId, CreateInstanceAccountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateInstanceAccountWithOptions(instanceId, request, headers, runtime);
        }

        /**
         * @summary 创建访问控制acl用户
         *
         * @param request CreateInstanceAccountRequest
         * @return CreateInstanceAccountResponse
         */
        public async Task<CreateInstanceAccountResponse> CreateInstanceAccountAsync(string instanceId, CreateInstanceAccountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateInstanceAccountWithOptionsAsync(instanceId, request, headers, runtime);
        }

        /**
         * @summary 创建访问控制acl数据
         *
         * @param request CreateInstanceAclRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateInstanceAclResponse
         */
        public CreateInstanceAclResponse CreateInstanceAclWithOptions(string instanceId, string username, CreateInstanceAclRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Actions))
            {
                body["actions"] = request.Actions;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Decision))
            {
                body["decision"] = request.Decision;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IpWhitelists))
            {
                body["ipWhitelists"] = request.IpWhitelists;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceName))
            {
                body["resourceName"] = request.ResourceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                body["resourceType"] = request.ResourceType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateInstanceAcl",
                Version = "2022-08-01",
                Protocol = "HTTPS",
                Pathname = "/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/acl/account/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(username),
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateInstanceAclResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 创建访问控制acl数据
         *
         * @param request CreateInstanceAclRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateInstanceAclResponse
         */
        public async Task<CreateInstanceAclResponse> CreateInstanceAclWithOptionsAsync(string instanceId, string username, CreateInstanceAclRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Actions))
            {
                body["actions"] = request.Actions;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Decision))
            {
                body["decision"] = request.Decision;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IpWhitelists))
            {
                body["ipWhitelists"] = request.IpWhitelists;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceName))
            {
                body["resourceName"] = request.ResourceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                body["resourceType"] = request.ResourceType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateInstanceAcl",
                Version = "2022-08-01",
                Protocol = "HTTPS",
                Pathname = "/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/acl/account/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(username),
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateInstanceAclResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 创建访问控制acl数据
         *
         * @param request CreateInstanceAclRequest
         * @return CreateInstanceAclResponse
         */
        public CreateInstanceAclResponse CreateInstanceAcl(string instanceId, string username, CreateInstanceAclRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateInstanceAclWithOptions(instanceId, username, request, headers, runtime);
        }

        /**
         * @summary 创建访问控制acl数据
         *
         * @param request CreateInstanceAclRequest
         * @return CreateInstanceAclResponse
         */
        public async Task<CreateInstanceAclResponse> CreateInstanceAclAsync(string instanceId, string username, CreateInstanceAclRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateInstanceAclWithOptionsAsync(instanceId, username, request, headers, runtime);
        }

        /**
         * @summary 创建访问控制ip白名单
         *
         * @param request CreateInstanceIpWhitelistRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateInstanceIpWhitelistResponse
         */
        public CreateInstanceIpWhitelistResponse CreateInstanceIpWhitelistWithOptions(string instanceId, CreateInstanceIpWhitelistRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IpWhitelists))
            {
                body["ipWhitelists"] = request.IpWhitelists;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateInstanceIpWhitelist",
                Version = "2022-08-01",
                Protocol = "HTTPS",
                Pathname = "/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/ip/whitelist",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateInstanceIpWhitelistResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 创建访问控制ip白名单
         *
         * @param request CreateInstanceIpWhitelistRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateInstanceIpWhitelistResponse
         */
        public async Task<CreateInstanceIpWhitelistResponse> CreateInstanceIpWhitelistWithOptionsAsync(string instanceId, CreateInstanceIpWhitelistRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IpWhitelists))
            {
                body["ipWhitelists"] = request.IpWhitelists;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateInstanceIpWhitelist",
                Version = "2022-08-01",
                Protocol = "HTTPS",
                Pathname = "/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/ip/whitelist",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateInstanceIpWhitelistResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 创建访问控制ip白名单
         *
         * @param request CreateInstanceIpWhitelistRequest
         * @return CreateInstanceIpWhitelistResponse
         */
        public CreateInstanceIpWhitelistResponse CreateInstanceIpWhitelist(string instanceId, CreateInstanceIpWhitelistRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateInstanceIpWhitelistWithOptions(instanceId, request, headers, runtime);
        }

        /**
         * @summary 创建访问控制ip白名单
         *
         * @param request CreateInstanceIpWhitelistRequest
         * @return CreateInstanceIpWhitelistResponse
         */
        public async Task<CreateInstanceIpWhitelistResponse> CreateInstanceIpWhitelistAsync(string instanceId, CreateInstanceIpWhitelistRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateInstanceIpWhitelistWithOptionsAsync(instanceId, request, headers, runtime);
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
         * @summary 取消消费组订阅关系
         *
         * @param request DeleteConsumerGroupSubscriptionRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteConsumerGroupSubscriptionResponse
         */
        public DeleteConsumerGroupSubscriptionResponse DeleteConsumerGroupSubscriptionWithOptions(string instanceId, string consumerGroupId, DeleteConsumerGroupSubscriptionRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FilterExpression))
            {
                query["filterExpression"] = request.FilterExpression;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FilterType))
            {
                query["filterType"] = request.FilterType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TopicName))
            {
                query["topicName"] = request.TopicName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteConsumerGroupSubscription",
                Version = "2022-08-01",
                Protocol = "HTTPS",
                Pathname = "/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/consumerGroups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(consumerGroupId) + "/subscriptions",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteConsumerGroupSubscriptionResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 取消消费组订阅关系
         *
         * @param request DeleteConsumerGroupSubscriptionRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteConsumerGroupSubscriptionResponse
         */
        public async Task<DeleteConsumerGroupSubscriptionResponse> DeleteConsumerGroupSubscriptionWithOptionsAsync(string instanceId, string consumerGroupId, DeleteConsumerGroupSubscriptionRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FilterExpression))
            {
                query["filterExpression"] = request.FilterExpression;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FilterType))
            {
                query["filterType"] = request.FilterType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TopicName))
            {
                query["topicName"] = request.TopicName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteConsumerGroupSubscription",
                Version = "2022-08-01",
                Protocol = "HTTPS",
                Pathname = "/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/consumerGroups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(consumerGroupId) + "/subscriptions",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteConsumerGroupSubscriptionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 取消消费组订阅关系
         *
         * @param request DeleteConsumerGroupSubscriptionRequest
         * @return DeleteConsumerGroupSubscriptionResponse
         */
        public DeleteConsumerGroupSubscriptionResponse DeleteConsumerGroupSubscription(string instanceId, string consumerGroupId, DeleteConsumerGroupSubscriptionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteConsumerGroupSubscriptionWithOptions(instanceId, consumerGroupId, request, headers, runtime);
        }

        /**
         * @summary 取消消费组订阅关系
         *
         * @param request DeleteConsumerGroupSubscriptionRequest
         * @return DeleteConsumerGroupSubscriptionResponse
         */
        public async Task<DeleteConsumerGroupSubscriptionResponse> DeleteConsumerGroupSubscriptionAsync(string instanceId, string consumerGroupId, DeleteConsumerGroupSubscriptionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteConsumerGroupSubscriptionWithOptionsAsync(instanceId, consumerGroupId, request, headers, runtime);
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
         * @summary 删除访问控制acl用户
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteInstanceAccountResponse
         */
        public DeleteInstanceAccountResponse DeleteInstanceAccountWithOptions(string instanceId, string username, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteInstanceAccount",
                Version = "2022-08-01",
                Protocol = "HTTPS",
                Pathname = "/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/accounts/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(username),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteInstanceAccountResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 删除访问控制acl用户
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteInstanceAccountResponse
         */
        public async Task<DeleteInstanceAccountResponse> DeleteInstanceAccountWithOptionsAsync(string instanceId, string username, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteInstanceAccount",
                Version = "2022-08-01",
                Protocol = "HTTPS",
                Pathname = "/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/accounts/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(username),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteInstanceAccountResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 删除访问控制acl用户
         *
         * @return DeleteInstanceAccountResponse
         */
        public DeleteInstanceAccountResponse DeleteInstanceAccount(string instanceId, string username)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteInstanceAccountWithOptions(instanceId, username, headers, runtime);
        }

        /**
         * @summary 删除访问控制acl用户
         *
         * @return DeleteInstanceAccountResponse
         */
        public async Task<DeleteInstanceAccountResponse> DeleteInstanceAccountAsync(string instanceId, string username)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteInstanceAccountWithOptionsAsync(instanceId, username, headers, runtime);
        }

        /**
         * @summary 删除访问控制acl数据
         *
         * @param request DeleteInstanceAclRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteInstanceAclResponse
         */
        public DeleteInstanceAclResponse DeleteInstanceAclWithOptions(string instanceId, string username, DeleteInstanceAclRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceName))
            {
                query["resourceName"] = request.ResourceName;
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
                Action = "DeleteInstanceAcl",
                Version = "2022-08-01",
                Protocol = "HTTPS",
                Pathname = "/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/acl/account/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(username),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteInstanceAclResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 删除访问控制acl数据
         *
         * @param request DeleteInstanceAclRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteInstanceAclResponse
         */
        public async Task<DeleteInstanceAclResponse> DeleteInstanceAclWithOptionsAsync(string instanceId, string username, DeleteInstanceAclRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceName))
            {
                query["resourceName"] = request.ResourceName;
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
                Action = "DeleteInstanceAcl",
                Version = "2022-08-01",
                Protocol = "HTTPS",
                Pathname = "/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/acl/account/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(username),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteInstanceAclResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 删除访问控制acl数据
         *
         * @param request DeleteInstanceAclRequest
         * @return DeleteInstanceAclResponse
         */
        public DeleteInstanceAclResponse DeleteInstanceAcl(string instanceId, string username, DeleteInstanceAclRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteInstanceAclWithOptions(instanceId, username, request, headers, runtime);
        }

        /**
         * @summary 删除访问控制acl数据
         *
         * @param request DeleteInstanceAclRequest
         * @return DeleteInstanceAclResponse
         */
        public async Task<DeleteInstanceAclResponse> DeleteInstanceAclAsync(string instanceId, string username, DeleteInstanceAclRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteInstanceAclWithOptionsAsync(instanceId, username, request, headers, runtime);
        }

        /**
         * @summary 删除访问控制ip白名单
         *
         * @param request DeleteInstanceIpWhitelistRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteInstanceIpWhitelistResponse
         */
        public DeleteInstanceIpWhitelistResponse DeleteInstanceIpWhitelistWithOptions(string instanceId, DeleteInstanceIpWhitelistRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IpWhitelist))
            {
                query["ipWhitelist"] = request.IpWhitelist;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteInstanceIpWhitelist",
                Version = "2022-08-01",
                Protocol = "HTTPS",
                Pathname = "/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/ip/whitelist",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteInstanceIpWhitelistResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 删除访问控制ip白名单
         *
         * @param request DeleteInstanceIpWhitelistRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteInstanceIpWhitelistResponse
         */
        public async Task<DeleteInstanceIpWhitelistResponse> DeleteInstanceIpWhitelistWithOptionsAsync(string instanceId, DeleteInstanceIpWhitelistRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IpWhitelist))
            {
                query["ipWhitelist"] = request.IpWhitelist;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteInstanceIpWhitelist",
                Version = "2022-08-01",
                Protocol = "HTTPS",
                Pathname = "/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/ip/whitelist",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteInstanceIpWhitelistResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 删除访问控制ip白名单
         *
         * @param request DeleteInstanceIpWhitelistRequest
         * @return DeleteInstanceIpWhitelistResponse
         */
        public DeleteInstanceIpWhitelistResponse DeleteInstanceIpWhitelist(string instanceId, DeleteInstanceIpWhitelistRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteInstanceIpWhitelistWithOptions(instanceId, request, headers, runtime);
        }

        /**
         * @summary 删除访问控制ip白名单
         *
         * @param request DeleteInstanceIpWhitelistRequest
         * @return DeleteInstanceIpWhitelistResponse
         */
        public async Task<DeleteInstanceIpWhitelistResponse> DeleteInstanceIpWhitelistAsync(string instanceId, DeleteInstanceIpWhitelistRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteInstanceIpWhitelistWithOptionsAsync(instanceId, request, headers, runtime);
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
         * @summary 查询消费者组堆积信息
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetConsumerGroupLagResponse
         */
        public GetConsumerGroupLagResponse GetConsumerGroupLagWithOptions(string instanceId, string consumerGroupId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetConsumerGroupLag",
                Version = "2022-08-01",
                Protocol = "HTTPS",
                Pathname = "/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/consumerGroups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(consumerGroupId) + "/lag",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetConsumerGroupLagResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 查询消费者组堆积信息
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetConsumerGroupLagResponse
         */
        public async Task<GetConsumerGroupLagResponse> GetConsumerGroupLagWithOptionsAsync(string instanceId, string consumerGroupId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetConsumerGroupLag",
                Version = "2022-08-01",
                Protocol = "HTTPS",
                Pathname = "/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/consumerGroups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(consumerGroupId) + "/lag",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetConsumerGroupLagResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 查询消费者组堆积信息
         *
         * @return GetConsumerGroupLagResponse
         */
        public GetConsumerGroupLagResponse GetConsumerGroupLag(string instanceId, string consumerGroupId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetConsumerGroupLagWithOptions(instanceId, consumerGroupId, headers, runtime);
        }

        /**
         * @summary 查询消费者组堆积信息
         *
         * @return GetConsumerGroupLagResponse
         */
        public async Task<GetConsumerGroupLagResponse> GetConsumerGroupLagAsync(string instanceId, string consumerGroupId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetConsumerGroupLagWithOptionsAsync(instanceId, consumerGroupId, headers, runtime);
        }

        /**
         * @summary 查询消费组订阅关系列表客户端分布
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetConsumerGroupSubscriptionResponse
         */
        public GetConsumerGroupSubscriptionResponse GetConsumerGroupSubscriptionWithOptions(string instanceId, string consumerGroupId, string topicName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetConsumerGroupSubscription",
                Version = "2022-08-01",
                Protocol = "HTTPS",
                Pathname = "/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/consumerGroups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(consumerGroupId) + "/subscriptions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(topicName),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetConsumerGroupSubscriptionResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 查询消费组订阅关系列表客户端分布
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetConsumerGroupSubscriptionResponse
         */
        public async Task<GetConsumerGroupSubscriptionResponse> GetConsumerGroupSubscriptionWithOptionsAsync(string instanceId, string consumerGroupId, string topicName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetConsumerGroupSubscription",
                Version = "2022-08-01",
                Protocol = "HTTPS",
                Pathname = "/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/consumerGroups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(consumerGroupId) + "/subscriptions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(topicName),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetConsumerGroupSubscriptionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 查询消费组订阅关系列表客户端分布
         *
         * @return GetConsumerGroupSubscriptionResponse
         */
        public GetConsumerGroupSubscriptionResponse GetConsumerGroupSubscription(string instanceId, string consumerGroupId, string topicName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetConsumerGroupSubscriptionWithOptions(instanceId, consumerGroupId, topicName, headers, runtime);
        }

        /**
         * @summary 查询消费组订阅关系列表客户端分布
         *
         * @return GetConsumerGroupSubscriptionResponse
         */
        public async Task<GetConsumerGroupSubscriptionResponse> GetConsumerGroupSubscriptionAsync(string instanceId, string consumerGroupId, string topicName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetConsumerGroupSubscriptionWithOptionsAsync(instanceId, consumerGroupId, topicName, headers, runtime);
        }

        /**
         * @summary 查询消费者堆栈信息
         *
         * @param request GetConsumerStackRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetConsumerStackResponse
         */
        public GetConsumerStackResponse GetConsumerStackWithOptions(string instanceId, string consumerGroupId, GetConsumerStackRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientId))
            {
                query["clientId"] = request.ClientId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetConsumerStack",
                Version = "2022-08-01",
                Protocol = "HTTPS",
                Pathname = "/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/consumerGroups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(consumerGroupId) + "/stack",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetConsumerStackResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 查询消费者堆栈信息
         *
         * @param request GetConsumerStackRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetConsumerStackResponse
         */
        public async Task<GetConsumerStackResponse> GetConsumerStackWithOptionsAsync(string instanceId, string consumerGroupId, GetConsumerStackRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientId))
            {
                query["clientId"] = request.ClientId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetConsumerStack",
                Version = "2022-08-01",
                Protocol = "HTTPS",
                Pathname = "/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/consumerGroups/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(consumerGroupId) + "/stack",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetConsumerStackResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 查询消费者堆栈信息
         *
         * @param request GetConsumerStackRequest
         * @return GetConsumerStackResponse
         */
        public GetConsumerStackResponse GetConsumerStack(string instanceId, string consumerGroupId, GetConsumerStackRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetConsumerStackWithOptions(instanceId, consumerGroupId, request, headers, runtime);
        }

        /**
         * @summary 查询消费者堆栈信息
         *
         * @param request GetConsumerStackRequest
         * @return GetConsumerStackResponse
         */
        public async Task<GetConsumerStackResponse> GetConsumerStackAsync(string instanceId, string consumerGroupId, GetConsumerStackRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetConsumerStackWithOptionsAsync(instanceId, consumerGroupId, request, headers, runtime);
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
         * @summary 获取实例账号
         *
         * @param request GetInstanceAccountRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetInstanceAccountResponse
         */
        public GetInstanceAccountResponse GetInstanceAccountWithOptions(string instanceId, GetInstanceAccountRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Username))
            {
                query["username"] = request.Username;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetInstanceAccount",
                Version = "2022-08-01",
                Protocol = "HTTPS",
                Pathname = "/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/account",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetInstanceAccountResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 获取实例账号
         *
         * @param request GetInstanceAccountRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetInstanceAccountResponse
         */
        public async Task<GetInstanceAccountResponse> GetInstanceAccountWithOptionsAsync(string instanceId, GetInstanceAccountRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Username))
            {
                query["username"] = request.Username;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetInstanceAccount",
                Version = "2022-08-01",
                Protocol = "HTTPS",
                Pathname = "/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/account",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetInstanceAccountResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 获取实例账号
         *
         * @param request GetInstanceAccountRequest
         * @return GetInstanceAccountResponse
         */
        public GetInstanceAccountResponse GetInstanceAccount(string instanceId, GetInstanceAccountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetInstanceAccountWithOptions(instanceId, request, headers, runtime);
        }

        /**
         * @summary 获取实例账号
         *
         * @param request GetInstanceAccountRequest
         * @return GetInstanceAccountResponse
         */
        public async Task<GetInstanceAccountResponse> GetInstanceAccountAsync(string instanceId, GetInstanceAccountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetInstanceAccountWithOptionsAsync(instanceId, request, headers, runtime);
        }

        /**
         * @summary 消息详情
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetMessageDetailResponse
         */
        public GetMessageDetailResponse GetMessageDetailWithOptions(string instanceId, string topicName, string messageId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetMessageDetail",
                Version = "2022-08-01",
                Protocol = "HTTPS",
                Pathname = "/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/topics/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(topicName) + "/messages/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(messageId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetMessageDetailResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 消息详情
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetMessageDetailResponse
         */
        public async Task<GetMessageDetailResponse> GetMessageDetailWithOptionsAsync(string instanceId, string topicName, string messageId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetMessageDetail",
                Version = "2022-08-01",
                Protocol = "HTTPS",
                Pathname = "/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/topics/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(topicName) + "/messages/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(messageId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetMessageDetailResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 消息详情
         *
         * @return GetMessageDetailResponse
         */
        public GetMessageDetailResponse GetMessageDetail(string instanceId, string topicName, string messageId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetMessageDetailWithOptions(instanceId, topicName, messageId, headers, runtime);
        }

        /**
         * @summary 消息详情
         *
         * @return GetMessageDetailResponse
         */
        public async Task<GetMessageDetailResponse> GetMessageDetailAsync(string instanceId, string topicName, string messageId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetMessageDetailWithOptionsAsync(instanceId, topicName, messageId, headers, runtime);
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
         * @summary 轨迹查询
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetTraceResponse
         */
        public GetTraceResponse GetTraceWithOptions(string instanceId, string topicName, string messageId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetTrace",
                Version = "2022-08-01",
                Protocol = "HTTPS",
                Pathname = "/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/topics/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(topicName) + "/traces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(messageId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTraceResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 轨迹查询
         *
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetTraceResponse
         */
        public async Task<GetTraceResponse> GetTraceWithOptionsAsync(string instanceId, string topicName, string messageId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetTrace",
                Version = "2022-08-01",
                Protocol = "HTTPS",
                Pathname = "/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/topics/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(topicName) + "/traces/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(messageId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTraceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 轨迹查询
         *
         * @return GetTraceResponse
         */
        public GetTraceResponse GetTrace(string instanceId, string topicName, string messageId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetTraceWithOptions(instanceId, topicName, messageId, headers, runtime);
        }

        /**
         * @summary 轨迹查询
         *
         * @return GetTraceResponse
         */
        public async Task<GetTraceResponse> GetTraceAsync(string instanceId, string topicName, string messageId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetTraceWithOptionsAsync(instanceId, topicName, messageId, headers, runtime);
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
         * @summary Queries the subscriptions of a specific consumer group.
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
         * @summary Queries the subscriptions of a specific consumer group.
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
         * @summary Queries the subscriptions of a specific consumer group.
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
         * @summary Queries the subscriptions of a specific consumer group.
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
         * @summary 访问控制acl用户列表
         *
         * @param request ListInstanceAccountRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListInstanceAccountResponse
         */
        public ListInstanceAccountResponse ListInstanceAccountWithOptions(string instanceId, ListInstanceAccountRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountStatus))
            {
                query["accountStatus"] = request.AccountStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountType))
            {
                query["accountType"] = request.AccountType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Username))
            {
                query["username"] = request.Username;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListInstanceAccount",
                Version = "2022-08-01",
                Protocol = "HTTPS",
                Pathname = "/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/accounts",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListInstanceAccountResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 访问控制acl用户列表
         *
         * @param request ListInstanceAccountRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListInstanceAccountResponse
         */
        public async Task<ListInstanceAccountResponse> ListInstanceAccountWithOptionsAsync(string instanceId, ListInstanceAccountRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountStatus))
            {
                query["accountStatus"] = request.AccountStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountType))
            {
                query["accountType"] = request.AccountType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Username))
            {
                query["username"] = request.Username;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListInstanceAccount",
                Version = "2022-08-01",
                Protocol = "HTTPS",
                Pathname = "/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/accounts",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListInstanceAccountResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 访问控制acl用户列表
         *
         * @param request ListInstanceAccountRequest
         * @return ListInstanceAccountResponse
         */
        public ListInstanceAccountResponse ListInstanceAccount(string instanceId, ListInstanceAccountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListInstanceAccountWithOptions(instanceId, request, headers, runtime);
        }

        /**
         * @summary 访问控制acl用户列表
         *
         * @param request ListInstanceAccountRequest
         * @return ListInstanceAccountResponse
         */
        public async Task<ListInstanceAccountResponse> ListInstanceAccountAsync(string instanceId, ListInstanceAccountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListInstanceAccountWithOptionsAsync(instanceId, request, headers, runtime);
        }

        /**
         * @summary 访问控制acl数据列表
         *
         * @param request ListInstanceAclRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListInstanceAclResponse
         */
        public ListInstanceAclResponse ListInstanceAclWithOptions(string instanceId, ListInstanceAclRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "ListInstanceAcl",
                Version = "2022-08-01",
                Protocol = "HTTPS",
                Pathname = "/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/acl",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListInstanceAclResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 访问控制acl数据列表
         *
         * @param request ListInstanceAclRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListInstanceAclResponse
         */
        public async Task<ListInstanceAclResponse> ListInstanceAclWithOptionsAsync(string instanceId, ListInstanceAclRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "ListInstanceAcl",
                Version = "2022-08-01",
                Protocol = "HTTPS",
                Pathname = "/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/acl",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListInstanceAclResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 访问控制acl数据列表
         *
         * @param request ListInstanceAclRequest
         * @return ListInstanceAclResponse
         */
        public ListInstanceAclResponse ListInstanceAcl(string instanceId, ListInstanceAclRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListInstanceAclWithOptions(instanceId, request, headers, runtime);
        }

        /**
         * @summary 访问控制acl数据列表
         *
         * @param request ListInstanceAclRequest
         * @return ListInstanceAclResponse
         */
        public async Task<ListInstanceAclResponse> ListInstanceAclAsync(string instanceId, ListInstanceAclRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListInstanceAclWithOptionsAsync(instanceId, request, headers, runtime);
        }

        /**
         * @summary 查询访问控制ip白名单列表
         *
         * @param request ListInstanceIpWhitelistRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListInstanceIpWhitelistResponse
         */
        public ListInstanceIpWhitelistResponse ListInstanceIpWhitelistWithOptions(string instanceId, ListInstanceIpWhitelistRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IpWhitelist))
            {
                query["ipWhitelist"] = request.IpWhitelist;
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
                Action = "ListInstanceIpWhitelist",
                Version = "2022-08-01",
                Protocol = "HTTPS",
                Pathname = "/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/ip/whitelist",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListInstanceIpWhitelistResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 查询访问控制ip白名单列表
         *
         * @param request ListInstanceIpWhitelistRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListInstanceIpWhitelistResponse
         */
        public async Task<ListInstanceIpWhitelistResponse> ListInstanceIpWhitelistWithOptionsAsync(string instanceId, ListInstanceIpWhitelistRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IpWhitelist))
            {
                query["ipWhitelist"] = request.IpWhitelist;
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
                Action = "ListInstanceIpWhitelist",
                Version = "2022-08-01",
                Protocol = "HTTPS",
                Pathname = "/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/ip/whitelist",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListInstanceIpWhitelistResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 查询访问控制ip白名单列表
         *
         * @param request ListInstanceIpWhitelistRequest
         * @return ListInstanceIpWhitelistResponse
         */
        public ListInstanceIpWhitelistResponse ListInstanceIpWhitelist(string instanceId, ListInstanceIpWhitelistRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListInstanceIpWhitelistWithOptions(instanceId, request, headers, runtime);
        }

        /**
         * @summary 查询访问控制ip白名单列表
         *
         * @param request ListInstanceIpWhitelistRequest
         * @return ListInstanceIpWhitelistResponse
         */
        public async Task<ListInstanceIpWhitelistResponse> ListInstanceIpWhitelistAsync(string instanceId, ListInstanceIpWhitelistRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListInstanceIpWhitelistWithOptionsAsync(instanceId, request, headers, runtime);
        }

        /**
         * @summary Queries all ApsaraMQ for RocketMQ instances in a specific region.
         *
         * @description > API operations provided by Alibaba Cloud are used to manage and query resources of Alibaba Cloud services. We recommend that you integrate these API operations only in management systems. Do not use these API operations in the core system of messaging services. Otherwise, system risks may occur.
         *
         * @param tmpReq ListInstancesRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListInstancesResponse
         */
        public ListInstancesResponse ListInstancesWithOptions(ListInstancesRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListInstancesShrinkRequest request = new ListInstancesShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SeriesCodes))
            {
                request.SeriesCodesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SeriesCodes, "seriesCodes", "simple");
            }
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SeriesCodesShrink))
            {
                query["seriesCodes"] = request.SeriesCodesShrink;
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
         * @summary Queries all ApsaraMQ for RocketMQ instances in a specific region.
         *
         * @description > API operations provided by Alibaba Cloud are used to manage and query resources of Alibaba Cloud services. We recommend that you integrate these API operations only in management systems. Do not use these API operations in the core system of messaging services. Otherwise, system risks may occur.
         *
         * @param tmpReq ListInstancesRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListInstancesResponse
         */
        public async Task<ListInstancesResponse> ListInstancesWithOptionsAsync(ListInstancesRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListInstancesShrinkRequest request = new ListInstancesShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SeriesCodes))
            {
                request.SeriesCodesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SeriesCodes, "seriesCodes", "simple");
            }
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SeriesCodesShrink))
            {
                query["seriesCodes"] = request.SeriesCodesShrink;
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
         * @summary Queries all ApsaraMQ for RocketMQ instances in a specific region.
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
         * @summary Queries all ApsaraMQ for RocketMQ instances in a specific region.
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
         * @summary 查询消息列表
         *
         * @param request ListMessagesRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListMessagesResponse
         */
        public ListMessagesResponse ListMessagesWithOptions(string instanceId, string topicName, ListMessagesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["endTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MessageId))
            {
                query["messageId"] = request.MessageId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MessageKey))
            {
                query["messageKey"] = request.MessageKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScrollId))
            {
                query["scrollId"] = request.ScrollId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["startTime"] = request.StartTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListMessages",
                Version = "2022-08-01",
                Protocol = "HTTPS",
                Pathname = "/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/topics/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(topicName) + "/messages",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListMessagesResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 查询消息列表
         *
         * @param request ListMessagesRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListMessagesResponse
         */
        public async Task<ListMessagesResponse> ListMessagesWithOptionsAsync(string instanceId, string topicName, ListMessagesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["endTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MessageId))
            {
                query["messageId"] = request.MessageId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MessageKey))
            {
                query["messageKey"] = request.MessageKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScrollId))
            {
                query["scrollId"] = request.ScrollId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["startTime"] = request.StartTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListMessages",
                Version = "2022-08-01",
                Protocol = "HTTPS",
                Pathname = "/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/topics/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(topicName) + "/messages",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListMessagesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 查询消息列表
         *
         * @param request ListMessagesRequest
         * @return ListMessagesResponse
         */
        public ListMessagesResponse ListMessages(string instanceId, string topicName, ListMessagesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListMessagesWithOptions(instanceId, topicName, request, headers, runtime);
        }

        /**
         * @summary 查询消息列表
         *
         * @param request ListMessagesRequest
         * @return ListMessagesResponse
         */
        public async Task<ListMessagesResponse> ListMessagesAsync(string instanceId, string topicName, ListMessagesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListMessagesWithOptionsAsync(instanceId, topicName, request, headers, runtime);
        }

        /**
         * @summary Queries regions in which ApsaraMQ for RocketMQ is available.
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
         * @summary Queries regions in which ApsaraMQ for RocketMQ is available.
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
         * @summary Queries regions in which ApsaraMQ for RocketMQ is available.
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
         * @summary Queries regions in which ApsaraMQ for RocketMQ is available.
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
         * @summary 查询可见的资源标签关系
         *
         * @param request ListTagResourcesRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListTagResourcesResponse
         */
        public ListTagResourcesResponse ListTagResourcesWithOptions(ListTagResourcesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                query["tag"] = request.Tag;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTagResources",
                Version = "2022-08-01",
                Protocol = "HTTPS",
                Pathname = "/resourceTag/list",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTagResourcesResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 查询可见的资源标签关系
         *
         * @param request ListTagResourcesRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListTagResourcesResponse
         */
        public async Task<ListTagResourcesResponse> ListTagResourcesWithOptionsAsync(ListTagResourcesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                query["tag"] = request.Tag;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTagResources",
                Version = "2022-08-01",
                Protocol = "HTTPS",
                Pathname = "/resourceTag/list",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTagResourcesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 查询可见的资源标签关系
         *
         * @param request ListTagResourcesRequest
         * @return ListTagResourcesResponse
         */
        public ListTagResourcesResponse ListTagResources(ListTagResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListTagResourcesWithOptions(request, headers, runtime);
        }

        /**
         * @summary 查询可见的资源标签关系
         *
         * @param request ListTagResourcesRequest
         * @return ListTagResourcesResponse
         */
        public async Task<ListTagResourcesResponse> ListTagResourcesAsync(ListTagResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListTagResourcesWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary Queries the subscriptions of a specific topic.
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
         * @summary Queries the subscriptions of a specific topic.
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
         * @summary Queries the subscriptions of a specific topic.
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
         * @summary Queries the subscriptions of a specific topic.
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
         * @summary 轨迹消息列表
         *
         * @param request ListTracesRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListTracesResponse
         */
        public ListTracesResponse ListTracesWithOptions(string instanceId, string topicName, ListTracesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["endTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MessageId))
            {
                query["messageId"] = request.MessageId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MessageKey))
            {
                query["messageKey"] = request.MessageKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueryType))
            {
                query["queryType"] = request.QueryType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["startTime"] = request.StartTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTraces",
                Version = "2022-08-01",
                Protocol = "HTTPS",
                Pathname = "/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/topics/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(topicName) + "/traces",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTracesResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 轨迹消息列表
         *
         * @param request ListTracesRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListTracesResponse
         */
        public async Task<ListTracesResponse> ListTracesWithOptionsAsync(string instanceId, string topicName, ListTracesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["endTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MessageId))
            {
                query["messageId"] = request.MessageId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MessageKey))
            {
                query["messageKey"] = request.MessageKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueryType))
            {
                query["queryType"] = request.QueryType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["startTime"] = request.StartTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTraces",
                Version = "2022-08-01",
                Protocol = "HTTPS",
                Pathname = "/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/topics/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(topicName) + "/traces",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTracesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 轨迹消息列表
         *
         * @param request ListTracesRequest
         * @return ListTracesResponse
         */
        public ListTracesResponse ListTraces(string instanceId, string topicName, ListTracesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListTracesWithOptions(instanceId, topicName, request, headers, runtime);
        }

        /**
         * @summary 轨迹消息列表
         *
         * @param request ListTracesRequest
         * @return ListTracesResponse
         */
        public async Task<ListTracesResponse> ListTracesAsync(string instanceId, string topicName, ListTracesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListTracesWithOptionsAsync(instanceId, topicName, request, headers, runtime);
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
         * @summary 用户创建标签资源关系（用户标签）
         *
         * @param request TagResourcesRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return TagResourcesResponse
         */
        public TagResourcesResponse TagResourcesWithOptions(TagResourcesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["regionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceId))
            {
                query["resourceId"] = request.ResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["resourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                query["tag"] = request.Tag;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TagResources",
                Version = "2022-08-01",
                Protocol = "HTTPS",
                Pathname = "/resourceTag/create",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<TagResourcesResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 用户创建标签资源关系（用户标签）
         *
         * @param request TagResourcesRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return TagResourcesResponse
         */
        public async Task<TagResourcesResponse> TagResourcesWithOptionsAsync(TagResourcesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["regionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceId))
            {
                query["resourceId"] = request.ResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["resourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                query["tag"] = request.Tag;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TagResources",
                Version = "2022-08-01",
                Protocol = "HTTPS",
                Pathname = "/resourceTag/create",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<TagResourcesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 用户创建标签资源关系（用户标签）
         *
         * @param request TagResourcesRequest
         * @return TagResourcesResponse
         */
        public TagResourcesResponse TagResources(TagResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return TagResourcesWithOptions(request, headers, runtime);
        }

        /**
         * @summary 用户创建标签资源关系（用户标签）
         *
         * @param request TagResourcesRequest
         * @return TagResourcesResponse
         */
        public async Task<TagResourcesResponse> TagResourcesAsync(TagResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await TagResourcesWithOptionsAsync(request, headers, runtime);
        }

        /**
         * @summary 用户删除标签资源关系
         *
         * @param request UntagResourcesRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UntagResourcesResponse
         */
        public UntagResourcesResponse UntagResourcesWithOptions(UntagResourcesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.All))
            {
                query["all"] = request.All;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["regionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceId))
            {
                query["resourceId"] = request.ResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["resourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagKey))
            {
                query["tagKey"] = request.TagKey;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UntagResources",
                Version = "2022-08-01",
                Protocol = "HTTPS",
                Pathname = "/resourceTag/delete",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UntagResourcesResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 用户删除标签资源关系
         *
         * @param request UntagResourcesRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UntagResourcesResponse
         */
        public async Task<UntagResourcesResponse> UntagResourcesWithOptionsAsync(UntagResourcesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.All))
            {
                query["all"] = request.All;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RegionId))
            {
                query["regionId"] = request.RegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceId))
            {
                query["resourceId"] = request.ResourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                query["resourceType"] = request.ResourceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagKey))
            {
                query["tagKey"] = request.TagKey;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UntagResources",
                Version = "2022-08-01",
                Protocol = "HTTPS",
                Pathname = "/resourceTag/delete",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UntagResourcesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 用户删除标签资源关系
         *
         * @param request UntagResourcesRequest
         * @return UntagResourcesResponse
         */
        public UntagResourcesResponse UntagResources(UntagResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UntagResourcesWithOptions(request, headers, runtime);
        }

        /**
         * @summary 用户删除标签资源关系
         *
         * @param request UntagResourcesRequest
         * @return UntagResourcesResponse
         */
        public async Task<UntagResourcesResponse> UntagResourcesAsync(UntagResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UntagResourcesWithOptionsAsync(request, headers, runtime);
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
         * @summary 修改访问控制acl用户
         *
         * @param request UpdateInstanceAccountRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateInstanceAccountResponse
         */
        public UpdateInstanceAccountResponse UpdateInstanceAccountWithOptions(string instanceId, string username, UpdateInstanceAccountRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountStatus))
            {
                query["accountStatus"] = request.AccountStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Password))
            {
                query["password"] = request.Password;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateInstanceAccount",
                Version = "2022-08-01",
                Protocol = "HTTPS",
                Pathname = "/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/accounts/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(username),
                Method = "PATCH",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateInstanceAccountResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 修改访问控制acl用户
         *
         * @param request UpdateInstanceAccountRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateInstanceAccountResponse
         */
        public async Task<UpdateInstanceAccountResponse> UpdateInstanceAccountWithOptionsAsync(string instanceId, string username, UpdateInstanceAccountRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountStatus))
            {
                query["accountStatus"] = request.AccountStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Password))
            {
                query["password"] = request.Password;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateInstanceAccount",
                Version = "2022-08-01",
                Protocol = "HTTPS",
                Pathname = "/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/accounts/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(username),
                Method = "PATCH",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateInstanceAccountResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 修改访问控制acl用户
         *
         * @param request UpdateInstanceAccountRequest
         * @return UpdateInstanceAccountResponse
         */
        public UpdateInstanceAccountResponse UpdateInstanceAccount(string instanceId, string username, UpdateInstanceAccountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateInstanceAccountWithOptions(instanceId, username, request, headers, runtime);
        }

        /**
         * @summary 修改访问控制acl用户
         *
         * @param request UpdateInstanceAccountRequest
         * @return UpdateInstanceAccountResponse
         */
        public async Task<UpdateInstanceAccountResponse> UpdateInstanceAccountAsync(string instanceId, string username, UpdateInstanceAccountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateInstanceAccountWithOptionsAsync(instanceId, username, request, headers, runtime);
        }

        /**
         * @summary 删除访问控制acl数据
         *
         * @param request UpdateInstanceAclRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateInstanceAclResponse
         */
        public UpdateInstanceAclResponse UpdateInstanceAclWithOptions(string instanceId, string username, UpdateInstanceAclRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Actions))
            {
                body["actions"] = request.Actions;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Decision))
            {
                body["decision"] = request.Decision;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IpWhitelists))
            {
                body["ipWhitelists"] = request.IpWhitelists;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceName))
            {
                body["resourceName"] = request.ResourceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                body["resourceType"] = request.ResourceType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateInstanceAcl",
                Version = "2022-08-01",
                Protocol = "HTTPS",
                Pathname = "/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/acl/account/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(username),
                Method = "PATCH",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateInstanceAclResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 删除访问控制acl数据
         *
         * @param request UpdateInstanceAclRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateInstanceAclResponse
         */
        public async Task<UpdateInstanceAclResponse> UpdateInstanceAclWithOptionsAsync(string instanceId, string username, UpdateInstanceAclRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Actions))
            {
                body["actions"] = request.Actions;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Decision))
            {
                body["decision"] = request.Decision;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IpWhitelists))
            {
                body["ipWhitelists"] = request.IpWhitelists;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceName))
            {
                body["resourceName"] = request.ResourceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceType))
            {
                body["resourceType"] = request.ResourceType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateInstanceAcl",
                Version = "2022-08-01",
                Protocol = "HTTPS",
                Pathname = "/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/acl/account/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(username),
                Method = "PATCH",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateInstanceAclResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 删除访问控制acl数据
         *
         * @param request UpdateInstanceAclRequest
         * @return UpdateInstanceAclResponse
         */
        public UpdateInstanceAclResponse UpdateInstanceAcl(string instanceId, string username, UpdateInstanceAclRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateInstanceAclWithOptions(instanceId, username, request, headers, runtime);
        }

        /**
         * @summary 删除访问控制acl数据
         *
         * @param request UpdateInstanceAclRequest
         * @return UpdateInstanceAclResponse
         */
        public async Task<UpdateInstanceAclResponse> UpdateInstanceAclAsync(string instanceId, string username, UpdateInstanceAclRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateInstanceAclWithOptionsAsync(instanceId, username, request, headers, runtime);
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

        /**
         * @summary 消费验证
         *
         * @param request VerifyConsumeMessageRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return VerifyConsumeMessageResponse
         */
        public VerifyConsumeMessageResponse VerifyConsumeMessageWithOptions(string instanceId, string topicName, string messageId, VerifyConsumeMessageRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientId))
            {
                query["clientId"] = request.ClientId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConsumerGroupId))
            {
                query["consumerGroupId"] = request.ConsumerGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "VerifyConsumeMessage",
                Version = "2022-08-01",
                Protocol = "HTTPS",
                Pathname = "/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/topics/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(topicName) + "/messages/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(messageId) + "/action/verifyConsume",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<VerifyConsumeMessageResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 消费验证
         *
         * @param request VerifyConsumeMessageRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return VerifyConsumeMessageResponse
         */
        public async Task<VerifyConsumeMessageResponse> VerifyConsumeMessageWithOptionsAsync(string instanceId, string topicName, string messageId, VerifyConsumeMessageRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientId))
            {
                query["clientId"] = request.ClientId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConsumerGroupId))
            {
                query["consumerGroupId"] = request.ConsumerGroupId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "VerifyConsumeMessage",
                Version = "2022-08-01",
                Protocol = "HTTPS",
                Pathname = "/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/topics/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(topicName) + "/messages/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(messageId) + "/action/verifyConsume",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<VerifyConsumeMessageResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 消费验证
         *
         * @param request VerifyConsumeMessageRequest
         * @return VerifyConsumeMessageResponse
         */
        public VerifyConsumeMessageResponse VerifyConsumeMessage(string instanceId, string topicName, string messageId, VerifyConsumeMessageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return VerifyConsumeMessageWithOptions(instanceId, topicName, messageId, request, headers, runtime);
        }

        /**
         * @summary 消费验证
         *
         * @param request VerifyConsumeMessageRequest
         * @return VerifyConsumeMessageResponse
         */
        public async Task<VerifyConsumeMessageResponse> VerifyConsumeMessageAsync(string instanceId, string topicName, string messageId, VerifyConsumeMessageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await VerifyConsumeMessageWithOptionsAsync(instanceId, topicName, messageId, request, headers, runtime);
        }

        /**
         * @summary 发送消息
         *
         * @param request VerifySendMessageRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return VerifySendMessageResponse
         */
        public VerifySendMessageResponse VerifySendMessageWithOptions(string instanceId, string topicName, VerifySendMessageRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Message))
            {
                body["message"] = request.Message;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MessageKey))
            {
                body["messageKey"] = request.MessageKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MessageTag))
            {
                body["messageTag"] = request.MessageTag;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "VerifySendMessage",
                Version = "2022-08-01",
                Protocol = "HTTPS",
                Pathname = "/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/topics/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(topicName) + "/messages",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<VerifySendMessageResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 发送消息
         *
         * @param request VerifySendMessageRequest
         * @param headers map
         * @param runtime runtime options for this request RuntimeOptions
         * @return VerifySendMessageResponse
         */
        public async Task<VerifySendMessageResponse> VerifySendMessageWithOptionsAsync(string instanceId, string topicName, VerifySendMessageRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Message))
            {
                body["message"] = request.Message;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MessageKey))
            {
                body["messageKey"] = request.MessageKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MessageTag))
            {
                body["messageTag"] = request.MessageTag;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "VerifySendMessage",
                Version = "2022-08-01",
                Protocol = "HTTPS",
                Pathname = "/instances/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/topics/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(topicName) + "/messages",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<VerifySendMessageResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 发送消息
         *
         * @param request VerifySendMessageRequest
         * @return VerifySendMessageResponse
         */
        public VerifySendMessageResponse VerifySendMessage(string instanceId, string topicName, VerifySendMessageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return VerifySendMessageWithOptions(instanceId, topicName, request, headers, runtime);
        }

        /**
         * @summary 发送消息
         *
         * @param request VerifySendMessageRequest
         * @return VerifySendMessageResponse
         */
        public async Task<VerifySendMessageResponse> VerifySendMessageAsync(string instanceId, string topicName, VerifySendMessageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await VerifySendMessageWithOptionsAsync(instanceId, topicName, request, headers, runtime);
        }

    }
}
