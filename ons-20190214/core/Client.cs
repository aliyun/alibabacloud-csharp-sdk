// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Ons20190214.Models;

namespace AlibabaCloud.SDK.Ons20190214
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "regional";
            this._endpointMap = new Dictionary<string, string>
            {
                {"ap-northeast-2-pop", "ons.ap-northeast-1.aliyuncs.com"},
                {"cn-beijing-finance-1", "ons.aliyuncs.com"},
                {"cn-beijing-finance-pop", "ons.aliyuncs.com"},
                {"cn-beijing-gov-1", "ons.aliyuncs.com"},
                {"cn-beijing-nu16-b01", "ons.aliyuncs.com"},
                {"cn-edge-1", "ons.aliyuncs.com"},
                {"cn-fujian", "ons.aliyuncs.com"},
                {"cn-haidian-cm12-c01", "ons.aliyuncs.com"},
                {"cn-hangzhou-bj-b01", "ons.aliyuncs.com"},
                {"cn-hangzhou-internal-prod-1", "ons.aliyuncs.com"},
                {"cn-hangzhou-internal-test-1", "ons.aliyuncs.com"},
                {"cn-hangzhou-internal-test-2", "ons.aliyuncs.com"},
                {"cn-hangzhou-internal-test-3", "ons.aliyuncs.com"},
                {"cn-hangzhou-test-306", "ons.aliyuncs.com"},
                {"cn-hongkong-finance-pop", "ons.aliyuncs.com"},
                {"cn-qingdao-nebula", "ons.aliyuncs.com"},
                {"cn-shanghai-et15-b01", "ons.aliyuncs.com"},
                {"cn-shanghai-et2-b01", "ons.aliyuncs.com"},
                {"cn-shanghai-inner", "ons.aliyuncs.com"},
                {"cn-shanghai-internal-test-1", "ons.aliyuncs.com"},
                {"cn-shenzhen-inner", "ons.aliyuncs.com"},
                {"cn-shenzhen-st4-d01", "ons.aliyuncs.com"},
                {"cn-shenzhen-su18-b01", "ons.aliyuncs.com"},
                {"cn-wuhan", "ons.aliyuncs.com"},
                {"cn-yushanfang", "ons.aliyuncs.com"},
                {"cn-zhangbei-na61-b01", "ons.aliyuncs.com"},
                {"cn-zhangjiakou-na62-a01", "ons.aliyuncs.com"},
                {"cn-zhengzhou-nebula-1", "ons.aliyuncs.com"},
                {"eu-west-1-oxs", "ons.ap-northeast-1.aliyuncs.com"},
                {"rus-west-1-pop", "ons.ap-northeast-1.aliyuncs.com"},
            };
            CheckConfig(config);
            this._endpoint = GetEndpoint("ons", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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
          * > : The API operations that are provided by Alibaba Cloud are used to manage and query resources of Alibaba Cloud services. We recommend that you integrate these API operations only in management systems. Do not use these API operations in the core system of messaging services. Otherwise, system risks may occur.
          * When you call the **ListTagResources** operation, specify at least one of the following parameters in the request: **Tag.N.Key** and **ResourceId.N**. You can specify a resource ID to query all tags that are attached to the specified resource. You can also specify a tag key to query the tag value and the resource to which the tag is attached.
          * *   If you include the **Tag.N.Key** parameter in a request, you can obtain the tag value and the ID of the resource to which the tag is attached.********
          * *   If you include the **ResourceId.N** parameter in a request, you can obtain the keys and values of all tags that are attached to the specified resource.
          *
          * @param request ListTagResourcesRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return ListTagResourcesResponse
         */
        public ListTagResourcesResponse ListTagResourcesWithOptions(ListTagResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
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
                Version = "2019-02-14",
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
          * > : The API operations that are provided by Alibaba Cloud are used to manage and query resources of Alibaba Cloud services. We recommend that you integrate these API operations only in management systems. Do not use these API operations in the core system of messaging services. Otherwise, system risks may occur.
          * When you call the **ListTagResources** operation, specify at least one of the following parameters in the request: **Tag.N.Key** and **ResourceId.N**. You can specify a resource ID to query all tags that are attached to the specified resource. You can also specify a tag key to query the tag value and the resource to which the tag is attached.
          * *   If you include the **Tag.N.Key** parameter in a request, you can obtain the tag value and the ID of the resource to which the tag is attached.********
          * *   If you include the **ResourceId.N** parameter in a request, you can obtain the keys and values of all tags that are attached to the specified resource.
          *
          * @param request ListTagResourcesRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return ListTagResourcesResponse
         */
        public async Task<ListTagResourcesResponse> ListTagResourcesWithOptionsAsync(ListTagResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
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
                Version = "2019-02-14",
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
          * > : The API operations that are provided by Alibaba Cloud are used to manage and query resources of Alibaba Cloud services. We recommend that you integrate these API operations only in management systems. Do not use these API operations in the core system of messaging services. Otherwise, system risks may occur.
          * When you call the **ListTagResources** operation, specify at least one of the following parameters in the request: **Tag.N.Key** and **ResourceId.N**. You can specify a resource ID to query all tags that are attached to the specified resource. You can also specify a tag key to query the tag value and the resource to which the tag is attached.
          * *   If you include the **Tag.N.Key** parameter in a request, you can obtain the tag value and the ID of the resource to which the tag is attached.********
          * *   If you include the **ResourceId.N** parameter in a request, you can obtain the keys and values of all tags that are attached to the specified resource.
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
          * > : The API operations that are provided by Alibaba Cloud are used to manage and query resources of Alibaba Cloud services. We recommend that you integrate these API operations only in management systems. Do not use these API operations in the core system of messaging services. Otherwise, system risks may occur.
          * When you call the **ListTagResources** operation, specify at least one of the following parameters in the request: **Tag.N.Key** and **ResourceId.N**. You can specify a resource ID to query all tags that are attached to the specified resource. You can also specify a tag key to query the tag value and the resource to which the tag is attached.
          * *   If you include the **Tag.N.Key** parameter in a request, you can obtain the tag value and the ID of the resource to which the tag is attached.********
          * *   If you include the **ResourceId.N** parameter in a request, you can obtain the keys and values of all tags that are attached to the specified resource.
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
          * > : The API operations that are provided by Alibaba Cloud are used to manage and query resources of Alibaba Cloud services. We recommend that you integrate these API operations only in management systems. Do not use these API operations in the core system of messaging services. Otherwise, system risks may occur.
          * You can call this operation in scenarios in which you want to know the message consumption progress of a specified consumer group in production environments. You can obtain the information about message consumption and consumption latency based on the returned information. This operation returns the total number of accumulated messages in all topics to which the specified consumer group subscribes and the number of accumulated messages in each topic.
          *
          * @param request OnsConsumerAccumulateRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return OnsConsumerAccumulateResponse
         */
        public OnsConsumerAccumulateResponse OnsConsumerAccumulateWithOptions(OnsConsumerAccumulateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Detail))
            {
                query["Detail"] = request.Detail;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                query["GroupId"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "OnsConsumerAccumulate",
                Version = "2019-02-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<OnsConsumerAccumulateResponse>(CallApi(params_, req, runtime));
        }

        /**
          * > : The API operations that are provided by Alibaba Cloud are used to manage and query resources of Alibaba Cloud services. We recommend that you integrate these API operations only in management systems. Do not use these API operations in the core system of messaging services. Otherwise, system risks may occur.
          * You can call this operation in scenarios in which you want to know the message consumption progress of a specified consumer group in production environments. You can obtain the information about message consumption and consumption latency based on the returned information. This operation returns the total number of accumulated messages in all topics to which the specified consumer group subscribes and the number of accumulated messages in each topic.
          *
          * @param request OnsConsumerAccumulateRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return OnsConsumerAccumulateResponse
         */
        public async Task<OnsConsumerAccumulateResponse> OnsConsumerAccumulateWithOptionsAsync(OnsConsumerAccumulateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Detail))
            {
                query["Detail"] = request.Detail;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                query["GroupId"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "OnsConsumerAccumulate",
                Version = "2019-02-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<OnsConsumerAccumulateResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * > : The API operations that are provided by Alibaba Cloud are used to manage and query resources of Alibaba Cloud services. We recommend that you integrate these API operations only in management systems. Do not use these API operations in the core system of messaging services. Otherwise, system risks may occur.
          * You can call this operation in scenarios in which you want to know the message consumption progress of a specified consumer group in production environments. You can obtain the information about message consumption and consumption latency based on the returned information. This operation returns the total number of accumulated messages in all topics to which the specified consumer group subscribes and the number of accumulated messages in each topic.
          *
          * @param request OnsConsumerAccumulateRequest
          * @return OnsConsumerAccumulateResponse
         */
        public OnsConsumerAccumulateResponse OnsConsumerAccumulate(OnsConsumerAccumulateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return OnsConsumerAccumulateWithOptions(request, runtime);
        }

        /**
          * > : The API operations that are provided by Alibaba Cloud are used to manage and query resources of Alibaba Cloud services. We recommend that you integrate these API operations only in management systems. Do not use these API operations in the core system of messaging services. Otherwise, system risks may occur.
          * You can call this operation in scenarios in which you want to know the message consumption progress of a specified consumer group in production environments. You can obtain the information about message consumption and consumption latency based on the returned information. This operation returns the total number of accumulated messages in all topics to which the specified consumer group subscribes and the number of accumulated messages in each topic.
          *
          * @param request OnsConsumerAccumulateRequest
          * @return OnsConsumerAccumulateResponse
         */
        public async Task<OnsConsumerAccumulateResponse> OnsConsumerAccumulateAsync(OnsConsumerAccumulateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await OnsConsumerAccumulateWithOptionsAsync(request, runtime);
        }

        /**
          * > : The API operations that are provided by Alibaba Cloud are used to manage and query resources of Alibaba Cloud services. We recommend that you integrate these API operations only in management systems. Do not use these API operations in the core system of messaging services. Otherwise, system risks may occur.
          * When messages are accumulated in a topic, you can call this operation to check whether a consumer is online.
          *
          * @param request OnsConsumerGetConnectionRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return OnsConsumerGetConnectionResponse
         */
        public OnsConsumerGetConnectionResponse OnsConsumerGetConnectionWithOptions(OnsConsumerGetConnectionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                query["GroupId"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "OnsConsumerGetConnection",
                Version = "2019-02-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<OnsConsumerGetConnectionResponse>(CallApi(params_, req, runtime));
        }

        /**
          * > : The API operations that are provided by Alibaba Cloud are used to manage and query resources of Alibaba Cloud services. We recommend that you integrate these API operations only in management systems. Do not use these API operations in the core system of messaging services. Otherwise, system risks may occur.
          * When messages are accumulated in a topic, you can call this operation to check whether a consumer is online.
          *
          * @param request OnsConsumerGetConnectionRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return OnsConsumerGetConnectionResponse
         */
        public async Task<OnsConsumerGetConnectionResponse> OnsConsumerGetConnectionWithOptionsAsync(OnsConsumerGetConnectionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                query["GroupId"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "OnsConsumerGetConnection",
                Version = "2019-02-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<OnsConsumerGetConnectionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * > : The API operations that are provided by Alibaba Cloud are used to manage and query resources of Alibaba Cloud services. We recommend that you integrate these API operations only in management systems. Do not use these API operations in the core system of messaging services. Otherwise, system risks may occur.
          * When messages are accumulated in a topic, you can call this operation to check whether a consumer is online.
          *
          * @param request OnsConsumerGetConnectionRequest
          * @return OnsConsumerGetConnectionResponse
         */
        public OnsConsumerGetConnectionResponse OnsConsumerGetConnection(OnsConsumerGetConnectionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return OnsConsumerGetConnectionWithOptions(request, runtime);
        }

        /**
          * > : The API operations that are provided by Alibaba Cloud are used to manage and query resources of Alibaba Cloud services. We recommend that you integrate these API operations only in management systems. Do not use these API operations in the core system of messaging services. Otherwise, system risks may occur.
          * When messages are accumulated in a topic, you can call this operation to check whether a consumer is online.
          *
          * @param request OnsConsumerGetConnectionRequest
          * @return OnsConsumerGetConnectionResponse
         */
        public async Task<OnsConsumerGetConnectionResponse> OnsConsumerGetConnectionAsync(OnsConsumerGetConnectionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await OnsConsumerGetConnectionWithOptionsAsync(request, runtime);
        }

        /**
          * > : The API operations that are provided by Alibaba Cloud are used to manage and query resources of Alibaba Cloud services. We recommend that you integrate these API operations only in management systems. Do not use these API operations in the core system of messaging services. Otherwise, system risks may occur.
          * You can call this operation to clear accumulated messages or reset the consumption progress. You can use one of the following methods to clear accumulated messages:
          * *   Clear all accumulated messages in a specified topic.
          * *   Clear the messages that were published to the specified topic before a specified point in time.
          *
          * @param request OnsConsumerResetOffsetRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return OnsConsumerResetOffsetResponse
         */
        public OnsConsumerResetOffsetResponse OnsConsumerResetOffsetWithOptions(OnsConsumerResetOffsetRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                query["GroupId"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResetTimestamp))
            {
                query["ResetTimestamp"] = request.ResetTimestamp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Topic))
            {
                query["Topic"] = request.Topic;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["Type"] = request.Type;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "OnsConsumerResetOffset",
                Version = "2019-02-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<OnsConsumerResetOffsetResponse>(CallApi(params_, req, runtime));
        }

        /**
          * > : The API operations that are provided by Alibaba Cloud are used to manage and query resources of Alibaba Cloud services. We recommend that you integrate these API operations only in management systems. Do not use these API operations in the core system of messaging services. Otherwise, system risks may occur.
          * You can call this operation to clear accumulated messages or reset the consumption progress. You can use one of the following methods to clear accumulated messages:
          * *   Clear all accumulated messages in a specified topic.
          * *   Clear the messages that were published to the specified topic before a specified point in time.
          *
          * @param request OnsConsumerResetOffsetRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return OnsConsumerResetOffsetResponse
         */
        public async Task<OnsConsumerResetOffsetResponse> OnsConsumerResetOffsetWithOptionsAsync(OnsConsumerResetOffsetRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                query["GroupId"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResetTimestamp))
            {
                query["ResetTimestamp"] = request.ResetTimestamp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Topic))
            {
                query["Topic"] = request.Topic;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["Type"] = request.Type;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "OnsConsumerResetOffset",
                Version = "2019-02-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<OnsConsumerResetOffsetResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * > : The API operations that are provided by Alibaba Cloud are used to manage and query resources of Alibaba Cloud services. We recommend that you integrate these API operations only in management systems. Do not use these API operations in the core system of messaging services. Otherwise, system risks may occur.
          * You can call this operation to clear accumulated messages or reset the consumption progress. You can use one of the following methods to clear accumulated messages:
          * *   Clear all accumulated messages in a specified topic.
          * *   Clear the messages that were published to the specified topic before a specified point in time.
          *
          * @param request OnsConsumerResetOffsetRequest
          * @return OnsConsumerResetOffsetResponse
         */
        public OnsConsumerResetOffsetResponse OnsConsumerResetOffset(OnsConsumerResetOffsetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return OnsConsumerResetOffsetWithOptions(request, runtime);
        }

        /**
          * > : The API operations that are provided by Alibaba Cloud are used to manage and query resources of Alibaba Cloud services. We recommend that you integrate these API operations only in management systems. Do not use these API operations in the core system of messaging services. Otherwise, system risks may occur.
          * You can call this operation to clear accumulated messages or reset the consumption progress. You can use one of the following methods to clear accumulated messages:
          * *   Clear all accumulated messages in a specified topic.
          * *   Clear the messages that were published to the specified topic before a specified point in time.
          *
          * @param request OnsConsumerResetOffsetRequest
          * @return OnsConsumerResetOffsetResponse
         */
        public async Task<OnsConsumerResetOffsetResponse> OnsConsumerResetOffsetAsync(OnsConsumerResetOffsetRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await OnsConsumerResetOffsetWithOptionsAsync(request, runtime);
        }

        /**
          * > : The API operations that are provided by Alibaba Cloud are used to manage and query resources of Alibaba Cloud services. We recommend that you integrate these API operations only in management systems. Do not use these API operations in the core system of messaging services. Otherwise, system risks may occur.
          * *   You can call this operation in scenarios in which consumers are online and messages are accumulated. You can troubleshoot errors based on the information that is returned by this operation. You can check whether all consumers in the consumer group subscribe to the same topics and tags, and whether load balancing is performed as expected. You can also obtain the information about thread stack traces of online consumers.
          * *   This operation uses multiple backend operations to query and aggregate data. The system requires a long period of time to process a request. We recommend that you do not frequently call this operation.
          *
          * @param request OnsConsumerStatusRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return OnsConsumerStatusResponse
         */
        public OnsConsumerStatusResponse OnsConsumerStatusWithOptions(OnsConsumerStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Detail))
            {
                query["Detail"] = request.Detail;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                query["GroupId"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NeedJstack))
            {
                query["NeedJstack"] = request.NeedJstack;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "OnsConsumerStatus",
                Version = "2019-02-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<OnsConsumerStatusResponse>(CallApi(params_, req, runtime));
        }

        /**
          * > : The API operations that are provided by Alibaba Cloud are used to manage and query resources of Alibaba Cloud services. We recommend that you integrate these API operations only in management systems. Do not use these API operations in the core system of messaging services. Otherwise, system risks may occur.
          * *   You can call this operation in scenarios in which consumers are online and messages are accumulated. You can troubleshoot errors based on the information that is returned by this operation. You can check whether all consumers in the consumer group subscribe to the same topics and tags, and whether load balancing is performed as expected. You can also obtain the information about thread stack traces of online consumers.
          * *   This operation uses multiple backend operations to query and aggregate data. The system requires a long period of time to process a request. We recommend that you do not frequently call this operation.
          *
          * @param request OnsConsumerStatusRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return OnsConsumerStatusResponse
         */
        public async Task<OnsConsumerStatusResponse> OnsConsumerStatusWithOptionsAsync(OnsConsumerStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Detail))
            {
                query["Detail"] = request.Detail;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                query["GroupId"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NeedJstack))
            {
                query["NeedJstack"] = request.NeedJstack;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "OnsConsumerStatus",
                Version = "2019-02-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<OnsConsumerStatusResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * > : The API operations that are provided by Alibaba Cloud are used to manage and query resources of Alibaba Cloud services. We recommend that you integrate these API operations only in management systems. Do not use these API operations in the core system of messaging services. Otherwise, system risks may occur.
          * *   You can call this operation in scenarios in which consumers are online and messages are accumulated. You can troubleshoot errors based on the information that is returned by this operation. You can check whether all consumers in the consumer group subscribe to the same topics and tags, and whether load balancing is performed as expected. You can also obtain the information about thread stack traces of online consumers.
          * *   This operation uses multiple backend operations to query and aggregate data. The system requires a long period of time to process a request. We recommend that you do not frequently call this operation.
          *
          * @param request OnsConsumerStatusRequest
          * @return OnsConsumerStatusResponse
         */
        public OnsConsumerStatusResponse OnsConsumerStatus(OnsConsumerStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return OnsConsumerStatusWithOptions(request, runtime);
        }

        /**
          * > : The API operations that are provided by Alibaba Cloud are used to manage and query resources of Alibaba Cloud services. We recommend that you integrate these API operations only in management systems. Do not use these API operations in the core system of messaging services. Otherwise, system risks may occur.
          * *   You can call this operation in scenarios in which consumers are online and messages are accumulated. You can troubleshoot errors based on the information that is returned by this operation. You can check whether all consumers in the consumer group subscribe to the same topics and tags, and whether load balancing is performed as expected. You can also obtain the information about thread stack traces of online consumers.
          * *   This operation uses multiple backend operations to query and aggregate data. The system requires a long period of time to process a request. We recommend that you do not frequently call this operation.
          *
          * @param request OnsConsumerStatusRequest
          * @return OnsConsumerStatusResponse
         */
        public async Task<OnsConsumerStatusResponse> OnsConsumerStatusAsync(OnsConsumerStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await OnsConsumerStatusWithOptionsAsync(request, runtime);
        }

        /**
          * > : The API operations that are provided by Alibaba Cloud are used to manage and query resources of Alibaba Cloud services. We recommend that you integrate these API operations only in management systems. Do not use these API operations in the core system of messaging services. Otherwise, system risks may occur.
          * You can call this operation to query the earliest point in time when a message was published to a specified topic and the most recent point in time when a message was published to the specified topic. You can also obtain the most recent point in time when a message in the topic was consumed. This operation is usually used with the \\*\\*OnsConsumerAccumulate\\*\\* operation to display the overview of the consumption progress.
          *
          * @param request OnsConsumerTimeSpanRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return OnsConsumerTimeSpanResponse
         */
        public OnsConsumerTimeSpanResponse OnsConsumerTimeSpanWithOptions(OnsConsumerTimeSpanRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                query["GroupId"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
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
                Action = "OnsConsumerTimeSpan",
                Version = "2019-02-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<OnsConsumerTimeSpanResponse>(CallApi(params_, req, runtime));
        }

        /**
          * > : The API operations that are provided by Alibaba Cloud are used to manage and query resources of Alibaba Cloud services. We recommend that you integrate these API operations only in management systems. Do not use these API operations in the core system of messaging services. Otherwise, system risks may occur.
          * You can call this operation to query the earliest point in time when a message was published to a specified topic and the most recent point in time when a message was published to the specified topic. You can also obtain the most recent point in time when a message in the topic was consumed. This operation is usually used with the \\*\\*OnsConsumerAccumulate\\*\\* operation to display the overview of the consumption progress.
          *
          * @param request OnsConsumerTimeSpanRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return OnsConsumerTimeSpanResponse
         */
        public async Task<OnsConsumerTimeSpanResponse> OnsConsumerTimeSpanWithOptionsAsync(OnsConsumerTimeSpanRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                query["GroupId"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
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
                Action = "OnsConsumerTimeSpan",
                Version = "2019-02-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<OnsConsumerTimeSpanResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * > : The API operations that are provided by Alibaba Cloud are used to manage and query resources of Alibaba Cloud services. We recommend that you integrate these API operations only in management systems. Do not use these API operations in the core system of messaging services. Otherwise, system risks may occur.
          * You can call this operation to query the earliest point in time when a message was published to a specified topic and the most recent point in time when a message was published to the specified topic. You can also obtain the most recent point in time when a message in the topic was consumed. This operation is usually used with the \\*\\*OnsConsumerAccumulate\\*\\* operation to display the overview of the consumption progress.
          *
          * @param request OnsConsumerTimeSpanRequest
          * @return OnsConsumerTimeSpanResponse
         */
        public OnsConsumerTimeSpanResponse OnsConsumerTimeSpan(OnsConsumerTimeSpanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return OnsConsumerTimeSpanWithOptions(request, runtime);
        }

        /**
          * > : The API operations that are provided by Alibaba Cloud are used to manage and query resources of Alibaba Cloud services. We recommend that you integrate these API operations only in management systems. Do not use these API operations in the core system of messaging services. Otherwise, system risks may occur.
          * You can call this operation to query the earliest point in time when a message was published to a specified topic and the most recent point in time when a message was published to the specified topic. You can also obtain the most recent point in time when a message in the topic was consumed. This operation is usually used with the \\*\\*OnsConsumerAccumulate\\*\\* operation to display the overview of the consumption progress.
          *
          * @param request OnsConsumerTimeSpanRequest
          * @return OnsConsumerTimeSpanResponse
         */
        public async Task<OnsConsumerTimeSpanResponse> OnsConsumerTimeSpanAsync(OnsConsumerTimeSpanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await OnsConsumerTimeSpanWithOptionsAsync(request, runtime);
        }

        /**
          * > : The API operations that are provided by Alibaba Cloud are used to manage and query resources of Alibaba Cloud services. We recommend that you integrate these API operations only in management systems. Do not use these API operations in the core system of messaging services. Otherwise, system risks may occur.
          * This operation uses the exact match method to query a dead-letter message based on the message ID. You can obtain the message ID that is required to query the information about a dead-letter message from the SendResult parameter that is returned after the message is sent. You can also obtain the message ID by calling the OnsDLQMessagePageQueryByGroupId operation to query multiple messages at a time. The queried information about the dead-letter message includes the point in time when the message is stored, the message body, and attributes such as the message tag and the message key.
          *
          * @param request OnsDLQMessageGetByIdRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return OnsDLQMessageGetByIdResponse
         */
        public OnsDLQMessageGetByIdResponse OnsDLQMessageGetByIdWithOptions(OnsDLQMessageGetByIdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                query["GroupId"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MsgId))
            {
                query["MsgId"] = request.MsgId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "OnsDLQMessageGetById",
                Version = "2019-02-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<OnsDLQMessageGetByIdResponse>(CallApi(params_, req, runtime));
        }

        /**
          * > : The API operations that are provided by Alibaba Cloud are used to manage and query resources of Alibaba Cloud services. We recommend that you integrate these API operations only in management systems. Do not use these API operations in the core system of messaging services. Otherwise, system risks may occur.
          * This operation uses the exact match method to query a dead-letter message based on the message ID. You can obtain the message ID that is required to query the information about a dead-letter message from the SendResult parameter that is returned after the message is sent. You can also obtain the message ID by calling the OnsDLQMessagePageQueryByGroupId operation to query multiple messages at a time. The queried information about the dead-letter message includes the point in time when the message is stored, the message body, and attributes such as the message tag and the message key.
          *
          * @param request OnsDLQMessageGetByIdRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return OnsDLQMessageGetByIdResponse
         */
        public async Task<OnsDLQMessageGetByIdResponse> OnsDLQMessageGetByIdWithOptionsAsync(OnsDLQMessageGetByIdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                query["GroupId"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MsgId))
            {
                query["MsgId"] = request.MsgId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "OnsDLQMessageGetById",
                Version = "2019-02-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<OnsDLQMessageGetByIdResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * > : The API operations that are provided by Alibaba Cloud are used to manage and query resources of Alibaba Cloud services. We recommend that you integrate these API operations only in management systems. Do not use these API operations in the core system of messaging services. Otherwise, system risks may occur.
          * This operation uses the exact match method to query a dead-letter message based on the message ID. You can obtain the message ID that is required to query the information about a dead-letter message from the SendResult parameter that is returned after the message is sent. You can also obtain the message ID by calling the OnsDLQMessagePageQueryByGroupId operation to query multiple messages at a time. The queried information about the dead-letter message includes the point in time when the message is stored, the message body, and attributes such as the message tag and the message key.
          *
          * @param request OnsDLQMessageGetByIdRequest
          * @return OnsDLQMessageGetByIdResponse
         */
        public OnsDLQMessageGetByIdResponse OnsDLQMessageGetById(OnsDLQMessageGetByIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return OnsDLQMessageGetByIdWithOptions(request, runtime);
        }

        /**
          * > : The API operations that are provided by Alibaba Cloud are used to manage and query resources of Alibaba Cloud services. We recommend that you integrate these API operations only in management systems. Do not use these API operations in the core system of messaging services. Otherwise, system risks may occur.
          * This operation uses the exact match method to query a dead-letter message based on the message ID. You can obtain the message ID that is required to query the information about a dead-letter message from the SendResult parameter that is returned after the message is sent. You can also obtain the message ID by calling the OnsDLQMessagePageQueryByGroupId operation to query multiple messages at a time. The queried information about the dead-letter message includes the point in time when the message is stored, the message body, and attributes such as the message tag and the message key.
          *
          * @param request OnsDLQMessageGetByIdRequest
          * @return OnsDLQMessageGetByIdResponse
         */
        public async Task<OnsDLQMessageGetByIdResponse> OnsDLQMessageGetByIdAsync(OnsDLQMessageGetByIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await OnsDLQMessageGetByIdWithOptionsAsync(request, runtime);
        }

        /**
          * > : The API operations that are provided by Alibaba Cloud are used to manage and query resources of Alibaba Cloud services. We recommend that you integrate these API operations only in management systems. Do not use these API operations in the core system of messaging services. Otherwise, system risks may occur.
          * *   If you do not know the ID of the dead-letter message that you want to query, you can call this operation to query all dead-letter messages that are sent to a specified consumer group within a specified time range. The results are returned by page.
          * *   We recommend that you specify a short time range to query dead-letter messages in this method. If you specify a long time range, a large number of dead-letter messages are returned. In this case, you cannot find the dead-letter message that you want to query in an efficient manner. You can perform the following steps to query dead-letter messages:
          *     1.  Perform a paged query by specifying the group ID, start time, end time, and number of entries to return on each page. If matched messages are found, the information about the dead-letter messages on the first page, total number of pages, and task ID are returned by default.
          *     2.  Specify the task ID and a page number to call this operation again to query the dead-letter messages on the specified page. In this query, the BeginTime, EndTime, and PageSize parameters do not take effect. By default, the system uses the values of these parameters that you specified in the request when you created the specified query task.
          *
          * @param request OnsDLQMessagePageQueryByGroupIdRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return OnsDLQMessagePageQueryByGroupIdResponse
         */
        public OnsDLQMessagePageQueryByGroupIdResponse OnsDLQMessagePageQueryByGroupIdWithOptions(OnsDLQMessagePageQueryByGroupIdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BeginTime))
            {
                query["BeginTime"] = request.BeginTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                query["GroupId"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                query["TaskId"] = request.TaskId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "OnsDLQMessagePageQueryByGroupId",
                Version = "2019-02-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<OnsDLQMessagePageQueryByGroupIdResponse>(CallApi(params_, req, runtime));
        }

        /**
          * > : The API operations that are provided by Alibaba Cloud are used to manage and query resources of Alibaba Cloud services. We recommend that you integrate these API operations only in management systems. Do not use these API operations in the core system of messaging services. Otherwise, system risks may occur.
          * *   If you do not know the ID of the dead-letter message that you want to query, you can call this operation to query all dead-letter messages that are sent to a specified consumer group within a specified time range. The results are returned by page.
          * *   We recommend that you specify a short time range to query dead-letter messages in this method. If you specify a long time range, a large number of dead-letter messages are returned. In this case, you cannot find the dead-letter message that you want to query in an efficient manner. You can perform the following steps to query dead-letter messages:
          *     1.  Perform a paged query by specifying the group ID, start time, end time, and number of entries to return on each page. If matched messages are found, the information about the dead-letter messages on the first page, total number of pages, and task ID are returned by default.
          *     2.  Specify the task ID and a page number to call this operation again to query the dead-letter messages on the specified page. In this query, the BeginTime, EndTime, and PageSize parameters do not take effect. By default, the system uses the values of these parameters that you specified in the request when you created the specified query task.
          *
          * @param request OnsDLQMessagePageQueryByGroupIdRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return OnsDLQMessagePageQueryByGroupIdResponse
         */
        public async Task<OnsDLQMessagePageQueryByGroupIdResponse> OnsDLQMessagePageQueryByGroupIdWithOptionsAsync(OnsDLQMessagePageQueryByGroupIdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BeginTime))
            {
                query["BeginTime"] = request.BeginTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                query["GroupId"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                query["TaskId"] = request.TaskId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "OnsDLQMessagePageQueryByGroupId",
                Version = "2019-02-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<OnsDLQMessagePageQueryByGroupIdResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * > : The API operations that are provided by Alibaba Cloud are used to manage and query resources of Alibaba Cloud services. We recommend that you integrate these API operations only in management systems. Do not use these API operations in the core system of messaging services. Otherwise, system risks may occur.
          * *   If you do not know the ID of the dead-letter message that you want to query, you can call this operation to query all dead-letter messages that are sent to a specified consumer group within a specified time range. The results are returned by page.
          * *   We recommend that you specify a short time range to query dead-letter messages in this method. If you specify a long time range, a large number of dead-letter messages are returned. In this case, you cannot find the dead-letter message that you want to query in an efficient manner. You can perform the following steps to query dead-letter messages:
          *     1.  Perform a paged query by specifying the group ID, start time, end time, and number of entries to return on each page. If matched messages are found, the information about the dead-letter messages on the first page, total number of pages, and task ID are returned by default.
          *     2.  Specify the task ID and a page number to call this operation again to query the dead-letter messages on the specified page. In this query, the BeginTime, EndTime, and PageSize parameters do not take effect. By default, the system uses the values of these parameters that you specified in the request when you created the specified query task.
          *
          * @param request OnsDLQMessagePageQueryByGroupIdRequest
          * @return OnsDLQMessagePageQueryByGroupIdResponse
         */
        public OnsDLQMessagePageQueryByGroupIdResponse OnsDLQMessagePageQueryByGroupId(OnsDLQMessagePageQueryByGroupIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return OnsDLQMessagePageQueryByGroupIdWithOptions(request, runtime);
        }

        /**
          * > : The API operations that are provided by Alibaba Cloud are used to manage and query resources of Alibaba Cloud services. We recommend that you integrate these API operations only in management systems. Do not use these API operations in the core system of messaging services. Otherwise, system risks may occur.
          * *   If you do not know the ID of the dead-letter message that you want to query, you can call this operation to query all dead-letter messages that are sent to a specified consumer group within a specified time range. The results are returned by page.
          * *   We recommend that you specify a short time range to query dead-letter messages in this method. If you specify a long time range, a large number of dead-letter messages are returned. In this case, you cannot find the dead-letter message that you want to query in an efficient manner. You can perform the following steps to query dead-letter messages:
          *     1.  Perform a paged query by specifying the group ID, start time, end time, and number of entries to return on each page. If matched messages are found, the information about the dead-letter messages on the first page, total number of pages, and task ID are returned by default.
          *     2.  Specify the task ID and a page number to call this operation again to query the dead-letter messages on the specified page. In this query, the BeginTime, EndTime, and PageSize parameters do not take effect. By default, the system uses the values of these parameters that you specified in the request when you created the specified query task.
          *
          * @param request OnsDLQMessagePageQueryByGroupIdRequest
          * @return OnsDLQMessagePageQueryByGroupIdResponse
         */
        public async Task<OnsDLQMessagePageQueryByGroupIdResponse> OnsDLQMessagePageQueryByGroupIdAsync(OnsDLQMessagePageQueryByGroupIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await OnsDLQMessagePageQueryByGroupIdWithOptionsAsync(request, runtime);
        }

        /**
          * > : The API operations that are provided by Alibaba Cloud are used to manage and query resources of Alibaba Cloud services. We recommend that you integrate these API operations only in management systems. Do not use these API operations in the core system of messaging services. Otherwise, system risks may occur.
          * *   After the number of retries to send a message to a consumer group for consumption reaches the upper limit and the message is not consumed by a consumer in the group, the message is added to the dead-letter queue of the consumer group. The message is a dead-letter message. After you resend the dead-letter message to the consumer group for consumption and the message fails to be consumed again after the maximum number of retries, a dead-letter message with the same message ID is added to the dead-letter queue. You can view the details of the dead-letter message on the Dead-letter Queues page in the Message Queue for Apache RocketMQ console or by calling the API operations that are used to query dead-letter messages. You can obtain the number of consumption failures for a message based on the number of dead-letter messages with the same message ID in the dead-letter queue.
          * *   A dead-letter message is a message that fails to be consumed after the number of consumption retries reaches the upper limit. Generally, dead-letter messages are produced because of incorrect consumption logic. We recommend that you troubleshoot the consumption failures and then call this operation to send the message to the consumer group for consumption again.
          * *   Message Queue for Apache RocketMQ does not manage the status of dead-letter messages based on the consumption status of the dead-letter messages. After you call this operation to send a dead-letter message to a consumer group and the message is consumed, Message Queue for Apache RocketMQ does not remove the dead-letter message from the dead-letter queue. You must manage dead-letter messages and determine whether to send a dead-letter message to a consumer group for consumption. This way, you do not resend and reconsume the messages that are consumed.
          *
          * @param request OnsDLQMessageResendByIdRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return OnsDLQMessageResendByIdResponse
         */
        public OnsDLQMessageResendByIdResponse OnsDLQMessageResendByIdWithOptions(OnsDLQMessageResendByIdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                query["GroupId"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MsgId))
            {
                query["MsgId"] = request.MsgId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "OnsDLQMessageResendById",
                Version = "2019-02-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<OnsDLQMessageResendByIdResponse>(CallApi(params_, req, runtime));
        }

        /**
          * > : The API operations that are provided by Alibaba Cloud are used to manage and query resources of Alibaba Cloud services. We recommend that you integrate these API operations only in management systems. Do not use these API operations in the core system of messaging services. Otherwise, system risks may occur.
          * *   After the number of retries to send a message to a consumer group for consumption reaches the upper limit and the message is not consumed by a consumer in the group, the message is added to the dead-letter queue of the consumer group. The message is a dead-letter message. After you resend the dead-letter message to the consumer group for consumption and the message fails to be consumed again after the maximum number of retries, a dead-letter message with the same message ID is added to the dead-letter queue. You can view the details of the dead-letter message on the Dead-letter Queues page in the Message Queue for Apache RocketMQ console or by calling the API operations that are used to query dead-letter messages. You can obtain the number of consumption failures for a message based on the number of dead-letter messages with the same message ID in the dead-letter queue.
          * *   A dead-letter message is a message that fails to be consumed after the number of consumption retries reaches the upper limit. Generally, dead-letter messages are produced because of incorrect consumption logic. We recommend that you troubleshoot the consumption failures and then call this operation to send the message to the consumer group for consumption again.
          * *   Message Queue for Apache RocketMQ does not manage the status of dead-letter messages based on the consumption status of the dead-letter messages. After you call this operation to send a dead-letter message to a consumer group and the message is consumed, Message Queue for Apache RocketMQ does not remove the dead-letter message from the dead-letter queue. You must manage dead-letter messages and determine whether to send a dead-letter message to a consumer group for consumption. This way, you do not resend and reconsume the messages that are consumed.
          *
          * @param request OnsDLQMessageResendByIdRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return OnsDLQMessageResendByIdResponse
         */
        public async Task<OnsDLQMessageResendByIdResponse> OnsDLQMessageResendByIdWithOptionsAsync(OnsDLQMessageResendByIdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                query["GroupId"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MsgId))
            {
                query["MsgId"] = request.MsgId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "OnsDLQMessageResendById",
                Version = "2019-02-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<OnsDLQMessageResendByIdResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * > : The API operations that are provided by Alibaba Cloud are used to manage and query resources of Alibaba Cloud services. We recommend that you integrate these API operations only in management systems. Do not use these API operations in the core system of messaging services. Otherwise, system risks may occur.
          * *   After the number of retries to send a message to a consumer group for consumption reaches the upper limit and the message is not consumed by a consumer in the group, the message is added to the dead-letter queue of the consumer group. The message is a dead-letter message. After you resend the dead-letter message to the consumer group for consumption and the message fails to be consumed again after the maximum number of retries, a dead-letter message with the same message ID is added to the dead-letter queue. You can view the details of the dead-letter message on the Dead-letter Queues page in the Message Queue for Apache RocketMQ console or by calling the API operations that are used to query dead-letter messages. You can obtain the number of consumption failures for a message based on the number of dead-letter messages with the same message ID in the dead-letter queue.
          * *   A dead-letter message is a message that fails to be consumed after the number of consumption retries reaches the upper limit. Generally, dead-letter messages are produced because of incorrect consumption logic. We recommend that you troubleshoot the consumption failures and then call this operation to send the message to the consumer group for consumption again.
          * *   Message Queue for Apache RocketMQ does not manage the status of dead-letter messages based on the consumption status of the dead-letter messages. After you call this operation to send a dead-letter message to a consumer group and the message is consumed, Message Queue for Apache RocketMQ does not remove the dead-letter message from the dead-letter queue. You must manage dead-letter messages and determine whether to send a dead-letter message to a consumer group for consumption. This way, you do not resend and reconsume the messages that are consumed.
          *
          * @param request OnsDLQMessageResendByIdRequest
          * @return OnsDLQMessageResendByIdResponse
         */
        public OnsDLQMessageResendByIdResponse OnsDLQMessageResendById(OnsDLQMessageResendByIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return OnsDLQMessageResendByIdWithOptions(request, runtime);
        }

        /**
          * > : The API operations that are provided by Alibaba Cloud are used to manage and query resources of Alibaba Cloud services. We recommend that you integrate these API operations only in management systems. Do not use these API operations in the core system of messaging services. Otherwise, system risks may occur.
          * *   After the number of retries to send a message to a consumer group for consumption reaches the upper limit and the message is not consumed by a consumer in the group, the message is added to the dead-letter queue of the consumer group. The message is a dead-letter message. After you resend the dead-letter message to the consumer group for consumption and the message fails to be consumed again after the maximum number of retries, a dead-letter message with the same message ID is added to the dead-letter queue. You can view the details of the dead-letter message on the Dead-letter Queues page in the Message Queue for Apache RocketMQ console or by calling the API operations that are used to query dead-letter messages. You can obtain the number of consumption failures for a message based on the number of dead-letter messages with the same message ID in the dead-letter queue.
          * *   A dead-letter message is a message that fails to be consumed after the number of consumption retries reaches the upper limit. Generally, dead-letter messages are produced because of incorrect consumption logic. We recommend that you troubleshoot the consumption failures and then call this operation to send the message to the consumer group for consumption again.
          * *   Message Queue for Apache RocketMQ does not manage the status of dead-letter messages based on the consumption status of the dead-letter messages. After you call this operation to send a dead-letter message to a consumer group and the message is consumed, Message Queue for Apache RocketMQ does not remove the dead-letter message from the dead-letter queue. You must manage dead-letter messages and determine whether to send a dead-letter message to a consumer group for consumption. This way, you do not resend and reconsume the messages that are consumed.
          *
          * @param request OnsDLQMessageResendByIdRequest
          * @return OnsDLQMessageResendByIdResponse
         */
        public async Task<OnsDLQMessageResendByIdResponse> OnsDLQMessageResendByIdAsync(OnsDLQMessageResendByIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await OnsDLQMessageResendByIdWithOptionsAsync(request, runtime);
        }

        /**
          * > : The API operations that are provided by Alibaba Cloud are used to manage and query resources of Alibaba Cloud services. We recommend that you integrate these API operations only in management systems. Do not use these API operations in the core system of messaging services. Otherwise, system risks may occur.
          * You can call this operation to configure the permissions for a consumer group to read messages based on a specified region of Message Queue for Apache RocketMQ and a specified group ID. You can call this operation in scenarios in which you want to forbid consumers in a specific group from reading messages.
          *
          * @param request OnsGroupConsumerUpdateRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return OnsGroupConsumerUpdateResponse
         */
        public OnsGroupConsumerUpdateResponse OnsGroupConsumerUpdateWithOptions(OnsGroupConsumerUpdateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                query["GroupId"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReadEnable))
            {
                query["ReadEnable"] = request.ReadEnable;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "OnsGroupConsumerUpdate",
                Version = "2019-02-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<OnsGroupConsumerUpdateResponse>(CallApi(params_, req, runtime));
        }

        /**
          * > : The API operations that are provided by Alibaba Cloud are used to manage and query resources of Alibaba Cloud services. We recommend that you integrate these API operations only in management systems. Do not use these API operations in the core system of messaging services. Otherwise, system risks may occur.
          * You can call this operation to configure the permissions for a consumer group to read messages based on a specified region of Message Queue for Apache RocketMQ and a specified group ID. You can call this operation in scenarios in which you want to forbid consumers in a specific group from reading messages.
          *
          * @param request OnsGroupConsumerUpdateRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return OnsGroupConsumerUpdateResponse
         */
        public async Task<OnsGroupConsumerUpdateResponse> OnsGroupConsumerUpdateWithOptionsAsync(OnsGroupConsumerUpdateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                query["GroupId"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReadEnable))
            {
                query["ReadEnable"] = request.ReadEnable;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "OnsGroupConsumerUpdate",
                Version = "2019-02-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<OnsGroupConsumerUpdateResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * > : The API operations that are provided by Alibaba Cloud are used to manage and query resources of Alibaba Cloud services. We recommend that you integrate these API operations only in management systems. Do not use these API operations in the core system of messaging services. Otherwise, system risks may occur.
          * You can call this operation to configure the permissions for a consumer group to read messages based on a specified region of Message Queue for Apache RocketMQ and a specified group ID. You can call this operation in scenarios in which you want to forbid consumers in a specific group from reading messages.
          *
          * @param request OnsGroupConsumerUpdateRequest
          * @return OnsGroupConsumerUpdateResponse
         */
        public OnsGroupConsumerUpdateResponse OnsGroupConsumerUpdate(OnsGroupConsumerUpdateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return OnsGroupConsumerUpdateWithOptions(request, runtime);
        }

        /**
          * > : The API operations that are provided by Alibaba Cloud are used to manage and query resources of Alibaba Cloud services. We recommend that you integrate these API operations only in management systems. Do not use these API operations in the core system of messaging services. Otherwise, system risks may occur.
          * You can call this operation to configure the permissions for a consumer group to read messages based on a specified region of Message Queue for Apache RocketMQ and a specified group ID. You can call this operation in scenarios in which you want to forbid consumers in a specific group from reading messages.
          *
          * @param request OnsGroupConsumerUpdateRequest
          * @return OnsGroupConsumerUpdateResponse
         */
        public async Task<OnsGroupConsumerUpdateResponse> OnsGroupConsumerUpdateAsync(OnsGroupConsumerUpdateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await OnsGroupConsumerUpdateWithOptionsAsync(request, runtime);
        }

        /**
          * > : The API operations that are provided by Alibaba Cloud are used to manage and query resources of Alibaba Cloud services. We recommend that you integrate these API operations only in management systems. Do not use these API operations in the core system of messaging services. Otherwise, system risks may occur.
          * When you release a new application or implement new business logic, you need new consumer groups. You can call this operation to create a consumer group.
          *
          * @param request OnsGroupCreateRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return OnsGroupCreateResponse
         */
        public OnsGroupCreateResponse OnsGroupCreateWithOptions(OnsGroupCreateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                query["GroupId"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupType))
            {
                query["GroupType"] = request.GroupType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Remark))
            {
                query["Remark"] = request.Remark;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "OnsGroupCreate",
                Version = "2019-02-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<OnsGroupCreateResponse>(CallApi(params_, req, runtime));
        }

        /**
          * > : The API operations that are provided by Alibaba Cloud are used to manage and query resources of Alibaba Cloud services. We recommend that you integrate these API operations only in management systems. Do not use these API operations in the core system of messaging services. Otherwise, system risks may occur.
          * When you release a new application or implement new business logic, you need new consumer groups. You can call this operation to create a consumer group.
          *
          * @param request OnsGroupCreateRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return OnsGroupCreateResponse
         */
        public async Task<OnsGroupCreateResponse> OnsGroupCreateWithOptionsAsync(OnsGroupCreateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                query["GroupId"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupType))
            {
                query["GroupType"] = request.GroupType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Remark))
            {
                query["Remark"] = request.Remark;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "OnsGroupCreate",
                Version = "2019-02-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<OnsGroupCreateResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * > : The API operations that are provided by Alibaba Cloud are used to manage and query resources of Alibaba Cloud services. We recommend that you integrate these API operations only in management systems. Do not use these API operations in the core system of messaging services. Otherwise, system risks may occur.
          * When you release a new application or implement new business logic, you need new consumer groups. You can call this operation to create a consumer group.
          *
          * @param request OnsGroupCreateRequest
          * @return OnsGroupCreateResponse
         */
        public OnsGroupCreateResponse OnsGroupCreate(OnsGroupCreateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return OnsGroupCreateWithOptions(request, runtime);
        }

        /**
          * > : The API operations that are provided by Alibaba Cloud are used to manage and query resources of Alibaba Cloud services. We recommend that you integrate these API operations only in management systems. Do not use these API operations in the core system of messaging services. Otherwise, system risks may occur.
          * When you release a new application or implement new business logic, you need new consumer groups. You can call this operation to create a consumer group.
          *
          * @param request OnsGroupCreateRequest
          * @return OnsGroupCreateResponse
         */
        public async Task<OnsGroupCreateResponse> OnsGroupCreateAsync(OnsGroupCreateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await OnsGroupCreateWithOptionsAsync(request, runtime);
        }

        /**
          * > 
          * *   The API operations that are provided by Alibaba Cloud are used to manage and query resources of Alibaba Cloud services. We recommend that you integrate these API operations only in management systems. Do not use these API operations in the core system of messaging services. Otherwise, system risks may occur.
          * *   After you delete a group, the consumers in the group immediately stop receiving messages. Exercise caution when you call this operation.
          * You can call this operation to delete a group when you need to deallocate the resources of the group. For example, after an application is brought offline, you can delete the groups that are used for the application. After you delete a group, the backend of Message Queue for Apache RocketMQ deallocates the resources of the group. The system requires a long period of time to deallocate the resources. We recommend that you do not create a group that uses the same name as a deleted group immediately after you delete the group. If the system fails to delete the specified group, troubleshoot the issue based on the error code.
          *
          * @param request OnsGroupDeleteRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return OnsGroupDeleteResponse
         */
        public OnsGroupDeleteResponse OnsGroupDeleteWithOptions(OnsGroupDeleteRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                query["GroupId"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "OnsGroupDelete",
                Version = "2019-02-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<OnsGroupDeleteResponse>(CallApi(params_, req, runtime));
        }

        /**
          * > 
          * *   The API operations that are provided by Alibaba Cloud are used to manage and query resources of Alibaba Cloud services. We recommend that you integrate these API operations only in management systems. Do not use these API operations in the core system of messaging services. Otherwise, system risks may occur.
          * *   After you delete a group, the consumers in the group immediately stop receiving messages. Exercise caution when you call this operation.
          * You can call this operation to delete a group when you need to deallocate the resources of the group. For example, after an application is brought offline, you can delete the groups that are used for the application. After you delete a group, the backend of Message Queue for Apache RocketMQ deallocates the resources of the group. The system requires a long period of time to deallocate the resources. We recommend that you do not create a group that uses the same name as a deleted group immediately after you delete the group. If the system fails to delete the specified group, troubleshoot the issue based on the error code.
          *
          * @param request OnsGroupDeleteRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return OnsGroupDeleteResponse
         */
        public async Task<OnsGroupDeleteResponse> OnsGroupDeleteWithOptionsAsync(OnsGroupDeleteRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                query["GroupId"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "OnsGroupDelete",
                Version = "2019-02-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<OnsGroupDeleteResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * > 
          * *   The API operations that are provided by Alibaba Cloud are used to manage and query resources of Alibaba Cloud services. We recommend that you integrate these API operations only in management systems. Do not use these API operations in the core system of messaging services. Otherwise, system risks may occur.
          * *   After you delete a group, the consumers in the group immediately stop receiving messages. Exercise caution when you call this operation.
          * You can call this operation to delete a group when you need to deallocate the resources of the group. For example, after an application is brought offline, you can delete the groups that are used for the application. After you delete a group, the backend of Message Queue for Apache RocketMQ deallocates the resources of the group. The system requires a long period of time to deallocate the resources. We recommend that you do not create a group that uses the same name as a deleted group immediately after you delete the group. If the system fails to delete the specified group, troubleshoot the issue based on the error code.
          *
          * @param request OnsGroupDeleteRequest
          * @return OnsGroupDeleteResponse
         */
        public OnsGroupDeleteResponse OnsGroupDelete(OnsGroupDeleteRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return OnsGroupDeleteWithOptions(request, runtime);
        }

        /**
          * > 
          * *   The API operations that are provided by Alibaba Cloud are used to manage and query resources of Alibaba Cloud services. We recommend that you integrate these API operations only in management systems. Do not use these API operations in the core system of messaging services. Otherwise, system risks may occur.
          * *   After you delete a group, the consumers in the group immediately stop receiving messages. Exercise caution when you call this operation.
          * You can call this operation to delete a group when you need to deallocate the resources of the group. For example, after an application is brought offline, you can delete the groups that are used for the application. After you delete a group, the backend of Message Queue for Apache RocketMQ deallocates the resources of the group. The system requires a long period of time to deallocate the resources. We recommend that you do not create a group that uses the same name as a deleted group immediately after you delete the group. If the system fails to delete the specified group, troubleshoot the issue based on the error code.
          *
          * @param request OnsGroupDeleteRequest
          * @return OnsGroupDeleteResponse
         */
        public async Task<OnsGroupDeleteResponse> OnsGroupDeleteAsync(OnsGroupDeleteRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await OnsGroupDeleteWithOptionsAsync(request, runtime);
        }

        /**
          * > : The API operations that are provided by Alibaba Cloud are used to manage and query resources of Alibaba Cloud services. We recommend that you integrate these API operations only in management systems. Do not use these API operations in the core system of messaging services. Otherwise, system risks may occur.
          *
          * @param request OnsGroupListRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return OnsGroupListResponse
         */
        public OnsGroupListResponse OnsGroupListWithOptions(OnsGroupListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                query["GroupId"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupType))
            {
                query["GroupType"] = request.GroupType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
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
                Action = "OnsGroupList",
                Version = "2019-02-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<OnsGroupListResponse>(CallApi(params_, req, runtime));
        }

        /**
          * > : The API operations that are provided by Alibaba Cloud are used to manage and query resources of Alibaba Cloud services. We recommend that you integrate these API operations only in management systems. Do not use these API operations in the core system of messaging services. Otherwise, system risks may occur.
          *
          * @param request OnsGroupListRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return OnsGroupListResponse
         */
        public async Task<OnsGroupListResponse> OnsGroupListWithOptionsAsync(OnsGroupListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                query["GroupId"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupType))
            {
                query["GroupType"] = request.GroupType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
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
                Action = "OnsGroupList",
                Version = "2019-02-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<OnsGroupListResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * > : The API operations that are provided by Alibaba Cloud are used to manage and query resources of Alibaba Cloud services. We recommend that you integrate these API operations only in management systems. Do not use these API operations in the core system of messaging services. Otherwise, system risks may occur.
          *
          * @param request OnsGroupListRequest
          * @return OnsGroupListResponse
         */
        public OnsGroupListResponse OnsGroupList(OnsGroupListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return OnsGroupListWithOptions(request, runtime);
        }

        /**
          * > : The API operations that are provided by Alibaba Cloud are used to manage and query resources of Alibaba Cloud services. We recommend that you integrate these API operations only in management systems. Do not use these API operations in the core system of messaging services. Otherwise, system risks may occur.
          *
          * @param request OnsGroupListRequest
          * @return OnsGroupListResponse
         */
        public async Task<OnsGroupListResponse> OnsGroupListAsync(OnsGroupListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await OnsGroupListWithOptionsAsync(request, runtime);
        }

        /**
          * > : The API operations that are provided by Alibaba Cloud are used to manage and query resources of Alibaba Cloud services. We recommend that you integrate these API operations only in management systems. Do not use these API operations in the core system of messaging services. Otherwise, system risks may occur.
          *
          * @param request OnsGroupSubDetailRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return OnsGroupSubDetailResponse
         */
        public OnsGroupSubDetailResponse OnsGroupSubDetailWithOptions(OnsGroupSubDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                query["GroupId"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "OnsGroupSubDetail",
                Version = "2019-02-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<OnsGroupSubDetailResponse>(CallApi(params_, req, runtime));
        }

        /**
          * > : The API operations that are provided by Alibaba Cloud are used to manage and query resources of Alibaba Cloud services. We recommend that you integrate these API operations only in management systems. Do not use these API operations in the core system of messaging services. Otherwise, system risks may occur.
          *
          * @param request OnsGroupSubDetailRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return OnsGroupSubDetailResponse
         */
        public async Task<OnsGroupSubDetailResponse> OnsGroupSubDetailWithOptionsAsync(OnsGroupSubDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                query["GroupId"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "OnsGroupSubDetail",
                Version = "2019-02-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<OnsGroupSubDetailResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * > : The API operations that are provided by Alibaba Cloud are used to manage and query resources of Alibaba Cloud services. We recommend that you integrate these API operations only in management systems. Do not use these API operations in the core system of messaging services. Otherwise, system risks may occur.
          *
          * @param request OnsGroupSubDetailRequest
          * @return OnsGroupSubDetailResponse
         */
        public OnsGroupSubDetailResponse OnsGroupSubDetail(OnsGroupSubDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return OnsGroupSubDetailWithOptions(request, runtime);
        }

        /**
          * > : The API operations that are provided by Alibaba Cloud are used to manage and query resources of Alibaba Cloud services. We recommend that you integrate these API operations only in management systems. Do not use these API operations in the core system of messaging services. Otherwise, system risks may occur.
          *
          * @param request OnsGroupSubDetailRequest
          * @return OnsGroupSubDetailResponse
         */
        public async Task<OnsGroupSubDetailResponse> OnsGroupSubDetailAsync(OnsGroupSubDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await OnsGroupSubDetailWithOptionsAsync(request, runtime);
        }

        /**
          * > : The API operations that are provided by Alibaba Cloud are used to manage and query resources of Alibaba Cloud services. We recommend that you integrate these API operations only in management systems. Do not use these API operations in the core system of messaging services. Otherwise, system risks may occur.
          * To send and receive messages, a client must be connected to a Message Queue for Apache RocketMQ instance by using an endpoint. You can call this operation to query the endpoints of the instance.
          *
          * @param request OnsInstanceBaseInfoRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return OnsInstanceBaseInfoResponse
         */
        public OnsInstanceBaseInfoResponse OnsInstanceBaseInfoWithOptions(OnsInstanceBaseInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "OnsInstanceBaseInfo",
                Version = "2019-02-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<OnsInstanceBaseInfoResponse>(CallApi(params_, req, runtime));
        }

        /**
          * > : The API operations that are provided by Alibaba Cloud are used to manage and query resources of Alibaba Cloud services. We recommend that you integrate these API operations only in management systems. Do not use these API operations in the core system of messaging services. Otherwise, system risks may occur.
          * To send and receive messages, a client must be connected to a Message Queue for Apache RocketMQ instance by using an endpoint. You can call this operation to query the endpoints of the instance.
          *
          * @param request OnsInstanceBaseInfoRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return OnsInstanceBaseInfoResponse
         */
        public async Task<OnsInstanceBaseInfoResponse> OnsInstanceBaseInfoWithOptionsAsync(OnsInstanceBaseInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "OnsInstanceBaseInfo",
                Version = "2019-02-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<OnsInstanceBaseInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * > : The API operations that are provided by Alibaba Cloud are used to manage and query resources of Alibaba Cloud services. We recommend that you integrate these API operations only in management systems. Do not use these API operations in the core system of messaging services. Otherwise, system risks may occur.
          * To send and receive messages, a client must be connected to a Message Queue for Apache RocketMQ instance by using an endpoint. You can call this operation to query the endpoints of the instance.
          *
          * @param request OnsInstanceBaseInfoRequest
          * @return OnsInstanceBaseInfoResponse
         */
        public OnsInstanceBaseInfoResponse OnsInstanceBaseInfo(OnsInstanceBaseInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return OnsInstanceBaseInfoWithOptions(request, runtime);
        }

        /**
          * > : The API operations that are provided by Alibaba Cloud are used to manage and query resources of Alibaba Cloud services. We recommend that you integrate these API operations only in management systems. Do not use these API operations in the core system of messaging services. Otherwise, system risks may occur.
          * To send and receive messages, a client must be connected to a Message Queue for Apache RocketMQ instance by using an endpoint. You can call this operation to query the endpoints of the instance.
          *
          * @param request OnsInstanceBaseInfoRequest
          * @return OnsInstanceBaseInfoResponse
         */
        public async Task<OnsInstanceBaseInfoResponse> OnsInstanceBaseInfoAsync(OnsInstanceBaseInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await OnsInstanceBaseInfoWithOptionsAsync(request, runtime);
        }

        /**
          * > : The API operations that are provided by Alibaba Cloud are used to manage and query resources of Alibaba Cloud services. We recommend that you integrate these API operations only in management systems. Do not use these API operations in the core system of messaging services. Otherwise, system risks may occur.
          * An instance is a virtual machine (VM) that can be used to store information about the topics and groups of Message Queue for Apache RocketMQ. You can call this operation when you need to create service resources for the business that you want to launch. Take note of the following points when you call this operation:
          * *   A maximum of eight Message Queue for Apache RocketMQ instances can be deployed in each region.
          * *   This operation can be called to create only a Standard Edition instance. You can use the Message Queue for Apache RocketMQ console to create Standard Edition instances and Enterprise Platinum Edition instances. For information about how to create Message Queue for Apache RocketMQ instances, see [Manage instances](~~200153~~).
          *
          * @param request OnsInstanceCreateRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return OnsInstanceCreateResponse
         */
        public OnsInstanceCreateResponse OnsInstanceCreateWithOptions(OnsInstanceCreateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceName))
            {
                query["InstanceName"] = request.InstanceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Remark))
            {
                query["Remark"] = request.Remark;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "OnsInstanceCreate",
                Version = "2019-02-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<OnsInstanceCreateResponse>(CallApi(params_, req, runtime));
        }

        /**
          * > : The API operations that are provided by Alibaba Cloud are used to manage and query resources of Alibaba Cloud services. We recommend that you integrate these API operations only in management systems. Do not use these API operations in the core system of messaging services. Otherwise, system risks may occur.
          * An instance is a virtual machine (VM) that can be used to store information about the topics and groups of Message Queue for Apache RocketMQ. You can call this operation when you need to create service resources for the business that you want to launch. Take note of the following points when you call this operation:
          * *   A maximum of eight Message Queue for Apache RocketMQ instances can be deployed in each region.
          * *   This operation can be called to create only a Standard Edition instance. You can use the Message Queue for Apache RocketMQ console to create Standard Edition instances and Enterprise Platinum Edition instances. For information about how to create Message Queue for Apache RocketMQ instances, see [Manage instances](~~200153~~).
          *
          * @param request OnsInstanceCreateRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return OnsInstanceCreateResponse
         */
        public async Task<OnsInstanceCreateResponse> OnsInstanceCreateWithOptionsAsync(OnsInstanceCreateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceName))
            {
                query["InstanceName"] = request.InstanceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Remark))
            {
                query["Remark"] = request.Remark;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "OnsInstanceCreate",
                Version = "2019-02-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<OnsInstanceCreateResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * > : The API operations that are provided by Alibaba Cloud are used to manage and query resources of Alibaba Cloud services. We recommend that you integrate these API operations only in management systems. Do not use these API operations in the core system of messaging services. Otherwise, system risks may occur.
          * An instance is a virtual machine (VM) that can be used to store information about the topics and groups of Message Queue for Apache RocketMQ. You can call this operation when you need to create service resources for the business that you want to launch. Take note of the following points when you call this operation:
          * *   A maximum of eight Message Queue for Apache RocketMQ instances can be deployed in each region.
          * *   This operation can be called to create only a Standard Edition instance. You can use the Message Queue for Apache RocketMQ console to create Standard Edition instances and Enterprise Platinum Edition instances. For information about how to create Message Queue for Apache RocketMQ instances, see [Manage instances](~~200153~~).
          *
          * @param request OnsInstanceCreateRequest
          * @return OnsInstanceCreateResponse
         */
        public OnsInstanceCreateResponse OnsInstanceCreate(OnsInstanceCreateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return OnsInstanceCreateWithOptions(request, runtime);
        }

        /**
          * > : The API operations that are provided by Alibaba Cloud are used to manage and query resources of Alibaba Cloud services. We recommend that you integrate these API operations only in management systems. Do not use these API operations in the core system of messaging services. Otherwise, system risks may occur.
          * An instance is a virtual machine (VM) that can be used to store information about the topics and groups of Message Queue for Apache RocketMQ. You can call this operation when you need to create service resources for the business that you want to launch. Take note of the following points when you call this operation:
          * *   A maximum of eight Message Queue for Apache RocketMQ instances can be deployed in each region.
          * *   This operation can be called to create only a Standard Edition instance. You can use the Message Queue for Apache RocketMQ console to create Standard Edition instances and Enterprise Platinum Edition instances. For information about how to create Message Queue for Apache RocketMQ instances, see [Manage instances](~~200153~~).
          *
          * @param request OnsInstanceCreateRequest
          * @return OnsInstanceCreateResponse
         */
        public async Task<OnsInstanceCreateResponse> OnsInstanceCreateAsync(OnsInstanceCreateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await OnsInstanceCreateWithOptionsAsync(request, runtime);
        }

        /**
          * > : The API operations that are provided by Alibaba Cloud are used to manage and query resources of Alibaba Cloud services. We recommend that you integrate these API operations only in management systems. Do not use these API operations in the core system of messaging services. Otherwise, system risks may occur.
          * *   You can call this operation when you need to reclaim resources. For example, after you unpublish an application, you can reclaim the resources that were used for the application. An instance can be deleted only when the instance does not contain topics and groups.
          * *   After an instance is deleted, the instance cannot be recovered. Exercise caution when you call this operation.
          *
          * @param request OnsInstanceDeleteRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return OnsInstanceDeleteResponse
         */
        public OnsInstanceDeleteResponse OnsInstanceDeleteWithOptions(OnsInstanceDeleteRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "OnsInstanceDelete",
                Version = "2019-02-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<OnsInstanceDeleteResponse>(CallApi(params_, req, runtime));
        }

        /**
          * > : The API operations that are provided by Alibaba Cloud are used to manage and query resources of Alibaba Cloud services. We recommend that you integrate these API operations only in management systems. Do not use these API operations in the core system of messaging services. Otherwise, system risks may occur.
          * *   You can call this operation when you need to reclaim resources. For example, after you unpublish an application, you can reclaim the resources that were used for the application. An instance can be deleted only when the instance does not contain topics and groups.
          * *   After an instance is deleted, the instance cannot be recovered. Exercise caution when you call this operation.
          *
          * @param request OnsInstanceDeleteRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return OnsInstanceDeleteResponse
         */
        public async Task<OnsInstanceDeleteResponse> OnsInstanceDeleteWithOptionsAsync(OnsInstanceDeleteRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "OnsInstanceDelete",
                Version = "2019-02-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<OnsInstanceDeleteResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * > : The API operations that are provided by Alibaba Cloud are used to manage and query resources of Alibaba Cloud services. We recommend that you integrate these API operations only in management systems. Do not use these API operations in the core system of messaging services. Otherwise, system risks may occur.
          * *   You can call this operation when you need to reclaim resources. For example, after you unpublish an application, you can reclaim the resources that were used for the application. An instance can be deleted only when the instance does not contain topics and groups.
          * *   After an instance is deleted, the instance cannot be recovered. Exercise caution when you call this operation.
          *
          * @param request OnsInstanceDeleteRequest
          * @return OnsInstanceDeleteResponse
         */
        public OnsInstanceDeleteResponse OnsInstanceDelete(OnsInstanceDeleteRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return OnsInstanceDeleteWithOptions(request, runtime);
        }

        /**
          * > : The API operations that are provided by Alibaba Cloud are used to manage and query resources of Alibaba Cloud services. We recommend that you integrate these API operations only in management systems. Do not use these API operations in the core system of messaging services. Otherwise, system risks may occur.
          * *   You can call this operation when you need to reclaim resources. For example, after you unpublish an application, you can reclaim the resources that were used for the application. An instance can be deleted only when the instance does not contain topics and groups.
          * *   After an instance is deleted, the instance cannot be recovered. Exercise caution when you call this operation.
          *
          * @param request OnsInstanceDeleteRequest
          * @return OnsInstanceDeleteResponse
         */
        public async Task<OnsInstanceDeleteResponse> OnsInstanceDeleteAsync(OnsInstanceDeleteRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await OnsInstanceDeleteWithOptionsAsync(request, runtime);
        }

        /**
          * > : The API operations that are provided by Alibaba Cloud are used to manage and query resources of Alibaba Cloud services. We recommend that you integrate these API operations only in management systems. Do not use these API operations in the core system of messaging services. Otherwise, system risks may occur.
          *
          * @param request OnsInstanceInServiceListRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return OnsInstanceInServiceListResponse
         */
        public OnsInstanceInServiceListResponse OnsInstanceInServiceListWithOptions(OnsInstanceInServiceListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "OnsInstanceInServiceList",
                Version = "2019-02-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<OnsInstanceInServiceListResponse>(CallApi(params_, req, runtime));
        }

        /**
          * > : The API operations that are provided by Alibaba Cloud are used to manage and query resources of Alibaba Cloud services. We recommend that you integrate these API operations only in management systems. Do not use these API operations in the core system of messaging services. Otherwise, system risks may occur.
          *
          * @param request OnsInstanceInServiceListRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return OnsInstanceInServiceListResponse
         */
        public async Task<OnsInstanceInServiceListResponse> OnsInstanceInServiceListWithOptionsAsync(OnsInstanceInServiceListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "OnsInstanceInServiceList",
                Version = "2019-02-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<OnsInstanceInServiceListResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * > : The API operations that are provided by Alibaba Cloud are used to manage and query resources of Alibaba Cloud services. We recommend that you integrate these API operations only in management systems. Do not use these API operations in the core system of messaging services. Otherwise, system risks may occur.
          *
          * @param request OnsInstanceInServiceListRequest
          * @return OnsInstanceInServiceListResponse
         */
        public OnsInstanceInServiceListResponse OnsInstanceInServiceList(OnsInstanceInServiceListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return OnsInstanceInServiceListWithOptions(request, runtime);
        }

        /**
          * > : The API operations that are provided by Alibaba Cloud are used to manage and query resources of Alibaba Cloud services. We recommend that you integrate these API operations only in management systems. Do not use these API operations in the core system of messaging services. Otherwise, system risks may occur.
          *
          * @param request OnsInstanceInServiceListRequest
          * @return OnsInstanceInServiceListResponse
         */
        public async Task<OnsInstanceInServiceListResponse> OnsInstanceInServiceListAsync(OnsInstanceInServiceListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await OnsInstanceInServiceListWithOptionsAsync(request, runtime);
        }

        /**
          * > : The API operations that are provided by Alibaba Cloud are used to manage and query resources of Alibaba Cloud services. We recommend that you integrate these API operations only in management systems. Do not use these API operations in the core system of messaging services. Otherwise, system risks may occur.
          * A maximum of eight Message Queue for Apache RocketMQ instances can be deployed in each region.
          *
          * @param request OnsInstanceUpdateRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return OnsInstanceUpdateResponse
         */
        public OnsInstanceUpdateResponse OnsInstanceUpdateWithOptions(OnsInstanceUpdateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Remark))
            {
                query["Remark"] = request.Remark;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "OnsInstanceUpdate",
                Version = "2019-02-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<OnsInstanceUpdateResponse>(CallApi(params_, req, runtime));
        }

        /**
          * > : The API operations that are provided by Alibaba Cloud are used to manage and query resources of Alibaba Cloud services. We recommend that you integrate these API operations only in management systems. Do not use these API operations in the core system of messaging services. Otherwise, system risks may occur.
          * A maximum of eight Message Queue for Apache RocketMQ instances can be deployed in each region.
          *
          * @param request OnsInstanceUpdateRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return OnsInstanceUpdateResponse
         */
        public async Task<OnsInstanceUpdateResponse> OnsInstanceUpdateWithOptionsAsync(OnsInstanceUpdateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Remark))
            {
                query["Remark"] = request.Remark;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "OnsInstanceUpdate",
                Version = "2019-02-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<OnsInstanceUpdateResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * > : The API operations that are provided by Alibaba Cloud are used to manage and query resources of Alibaba Cloud services. We recommend that you integrate these API operations only in management systems. Do not use these API operations in the core system of messaging services. Otherwise, system risks may occur.
          * A maximum of eight Message Queue for Apache RocketMQ instances can be deployed in each region.
          *
          * @param request OnsInstanceUpdateRequest
          * @return OnsInstanceUpdateResponse
         */
        public OnsInstanceUpdateResponse OnsInstanceUpdate(OnsInstanceUpdateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return OnsInstanceUpdateWithOptions(request, runtime);
        }

        /**
          * > : The API operations that are provided by Alibaba Cloud are used to manage and query resources of Alibaba Cloud services. We recommend that you integrate these API operations only in management systems. Do not use these API operations in the core system of messaging services. Otherwise, system risks may occur.
          * A maximum of eight Message Queue for Apache RocketMQ instances can be deployed in each region.
          *
          * @param request OnsInstanceUpdateRequest
          * @return OnsInstanceUpdateResponse
         */
        public async Task<OnsInstanceUpdateResponse> OnsInstanceUpdateAsync(OnsInstanceUpdateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await OnsInstanceUpdateWithOptionsAsync(request, runtime);
        }

        public OnsMessageDetailResponse OnsMessageDetailWithOptions(OnsMessageDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "OnsMessageDetail",
                Version = "2019-02-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<OnsMessageDetailResponse>(CallApi(params_, req, runtime));
        }

        public async Task<OnsMessageDetailResponse> OnsMessageDetailWithOptionsAsync(OnsMessageDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "OnsMessageDetail",
                Version = "2019-02-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<OnsMessageDetailResponse>(await CallApiAsync(params_, req, runtime));
        }

        public OnsMessageDetailResponse OnsMessageDetail(OnsMessageDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return OnsMessageDetailWithOptions(request, runtime);
        }

        public async Task<OnsMessageDetailResponse> OnsMessageDetailAsync(OnsMessageDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await OnsMessageDetailWithOptionsAsync(request, runtime);
        }

        /**
          * > : The API operations that are provided by Alibaba Cloud are used to manage and query resources of Alibaba Cloud services. We recommend that you integrate these API operations only in management systems. Do not use these API operations in the core system of messaging services. Otherwise, system risks may occur.
          * *   This operation uses the fuzzy match method to query messages based on a specified message key. The same message key may be used by multiple messages. Therefore, the returned result may contain the information about multiple messages.
          * *   This operation can be used in scenarios in which you cannot obtain the IDs of the messages that you want to query. You can perform the following steps to query the information about messages:
          *     1.  Call this operation to query message IDs.
          *     2.  Call the **OnsMessageGetByMsgId** operation to query the details of a specified message. The OnsMessageGetByMsgId operation uses the exact match method. For more information about the **OnsMessageGetByMsgId** operation, see [OnsMessageGetByMsgId](~~29607~~).
          *
          * @param request OnsMessageGetByKeyRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return OnsMessageGetByKeyResponse
         */
        public OnsMessageGetByKeyResponse OnsMessageGetByKeyWithOptions(OnsMessageGetByKeyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Key))
            {
                query["Key"] = request.Key;
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
                Action = "OnsMessageGetByKey",
                Version = "2019-02-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<OnsMessageGetByKeyResponse>(CallApi(params_, req, runtime));
        }

        /**
          * > : The API operations that are provided by Alibaba Cloud are used to manage and query resources of Alibaba Cloud services. We recommend that you integrate these API operations only in management systems. Do not use these API operations in the core system of messaging services. Otherwise, system risks may occur.
          * *   This operation uses the fuzzy match method to query messages based on a specified message key. The same message key may be used by multiple messages. Therefore, the returned result may contain the information about multiple messages.
          * *   This operation can be used in scenarios in which you cannot obtain the IDs of the messages that you want to query. You can perform the following steps to query the information about messages:
          *     1.  Call this operation to query message IDs.
          *     2.  Call the **OnsMessageGetByMsgId** operation to query the details of a specified message. The OnsMessageGetByMsgId operation uses the exact match method. For more information about the **OnsMessageGetByMsgId** operation, see [OnsMessageGetByMsgId](~~29607~~).
          *
          * @param request OnsMessageGetByKeyRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return OnsMessageGetByKeyResponse
         */
        public async Task<OnsMessageGetByKeyResponse> OnsMessageGetByKeyWithOptionsAsync(OnsMessageGetByKeyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Key))
            {
                query["Key"] = request.Key;
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
                Action = "OnsMessageGetByKey",
                Version = "2019-02-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<OnsMessageGetByKeyResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * > : The API operations that are provided by Alibaba Cloud are used to manage and query resources of Alibaba Cloud services. We recommend that you integrate these API operations only in management systems. Do not use these API operations in the core system of messaging services. Otherwise, system risks may occur.
          * *   This operation uses the fuzzy match method to query messages based on a specified message key. The same message key may be used by multiple messages. Therefore, the returned result may contain the information about multiple messages.
          * *   This operation can be used in scenarios in which you cannot obtain the IDs of the messages that you want to query. You can perform the following steps to query the information about messages:
          *     1.  Call this operation to query message IDs.
          *     2.  Call the **OnsMessageGetByMsgId** operation to query the details of a specified message. The OnsMessageGetByMsgId operation uses the exact match method. For more information about the **OnsMessageGetByMsgId** operation, see [OnsMessageGetByMsgId](~~29607~~).
          *
          * @param request OnsMessageGetByKeyRequest
          * @return OnsMessageGetByKeyResponse
         */
        public OnsMessageGetByKeyResponse OnsMessageGetByKey(OnsMessageGetByKeyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return OnsMessageGetByKeyWithOptions(request, runtime);
        }

        /**
          * > : The API operations that are provided by Alibaba Cloud are used to manage and query resources of Alibaba Cloud services. We recommend that you integrate these API operations only in management systems. Do not use these API operations in the core system of messaging services. Otherwise, system risks may occur.
          * *   This operation uses the fuzzy match method to query messages based on a specified message key. The same message key may be used by multiple messages. Therefore, the returned result may contain the information about multiple messages.
          * *   This operation can be used in scenarios in which you cannot obtain the IDs of the messages that you want to query. You can perform the following steps to query the information about messages:
          *     1.  Call this operation to query message IDs.
          *     2.  Call the **OnsMessageGetByMsgId** operation to query the details of a specified message. The OnsMessageGetByMsgId operation uses the exact match method. For more information about the **OnsMessageGetByMsgId** operation, see [OnsMessageGetByMsgId](~~29607~~).
          *
          * @param request OnsMessageGetByKeyRequest
          * @return OnsMessageGetByKeyResponse
         */
        public async Task<OnsMessageGetByKeyResponse> OnsMessageGetByKeyAsync(OnsMessageGetByKeyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await OnsMessageGetByKeyWithOptionsAsync(request, runtime);
        }

        /**
          * > : The API operations that are provided by Alibaba Cloud are used to manage and query resources of Alibaba Cloud services. We recommend that you integrate these API operations only in management systems. Do not use these API operations in the core system of messaging services. Otherwise, system risks may occur.
          * *   If a message is not consumed as expected, you can call this operation to query the information about the message for troubleshooting.
          * *   This operation uses the exact match method to query a message based on the message ID. You can obtain the message ID from the SendResult parameter that is returned after the message is sent. You must store the returned information after each message is sent. The queried information about a message includes the point in time when the message was sent, the broker on which the message is stored, and the attributes of the message such as the message key and tag.
          *
          * @param request OnsMessageGetByMsgIdRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return OnsMessageGetByMsgIdResponse
         */
        public OnsMessageGetByMsgIdResponse OnsMessageGetByMsgIdWithOptions(OnsMessageGetByMsgIdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MsgId))
            {
                query["MsgId"] = request.MsgId;
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
                Action = "OnsMessageGetByMsgId",
                Version = "2019-02-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<OnsMessageGetByMsgIdResponse>(CallApi(params_, req, runtime));
        }

        /**
          * > : The API operations that are provided by Alibaba Cloud are used to manage and query resources of Alibaba Cloud services. We recommend that you integrate these API operations only in management systems. Do not use these API operations in the core system of messaging services. Otherwise, system risks may occur.
          * *   If a message is not consumed as expected, you can call this operation to query the information about the message for troubleshooting.
          * *   This operation uses the exact match method to query a message based on the message ID. You can obtain the message ID from the SendResult parameter that is returned after the message is sent. You must store the returned information after each message is sent. The queried information about a message includes the point in time when the message was sent, the broker on which the message is stored, and the attributes of the message such as the message key and tag.
          *
          * @param request OnsMessageGetByMsgIdRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return OnsMessageGetByMsgIdResponse
         */
        public async Task<OnsMessageGetByMsgIdResponse> OnsMessageGetByMsgIdWithOptionsAsync(OnsMessageGetByMsgIdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MsgId))
            {
                query["MsgId"] = request.MsgId;
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
                Action = "OnsMessageGetByMsgId",
                Version = "2019-02-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<OnsMessageGetByMsgIdResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * > : The API operations that are provided by Alibaba Cloud are used to manage and query resources of Alibaba Cloud services. We recommend that you integrate these API operations only in management systems. Do not use these API operations in the core system of messaging services. Otherwise, system risks may occur.
          * *   If a message is not consumed as expected, you can call this operation to query the information about the message for troubleshooting.
          * *   This operation uses the exact match method to query a message based on the message ID. You can obtain the message ID from the SendResult parameter that is returned after the message is sent. You must store the returned information after each message is sent. The queried information about a message includes the point in time when the message was sent, the broker on which the message is stored, and the attributes of the message such as the message key and tag.
          *
          * @param request OnsMessageGetByMsgIdRequest
          * @return OnsMessageGetByMsgIdResponse
         */
        public OnsMessageGetByMsgIdResponse OnsMessageGetByMsgId(OnsMessageGetByMsgIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return OnsMessageGetByMsgIdWithOptions(request, runtime);
        }

        /**
          * > : The API operations that are provided by Alibaba Cloud are used to manage and query resources of Alibaba Cloud services. We recommend that you integrate these API operations only in management systems. Do not use these API operations in the core system of messaging services. Otherwise, system risks may occur.
          * *   If a message is not consumed as expected, you can call this operation to query the information about the message for troubleshooting.
          * *   This operation uses the exact match method to query a message based on the message ID. You can obtain the message ID from the SendResult parameter that is returned after the message is sent. You must store the returned information after each message is sent. The queried information about a message includes the point in time when the message was sent, the broker on which the message is stored, and the attributes of the message such as the message key and tag.
          *
          * @param request OnsMessageGetByMsgIdRequest
          * @return OnsMessageGetByMsgIdResponse
         */
        public async Task<OnsMessageGetByMsgIdResponse> OnsMessageGetByMsgIdAsync(OnsMessageGetByMsgIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await OnsMessageGetByMsgIdWithOptionsAsync(request, runtime);
        }

        /**
          * > : The API operations that are provided by Alibaba Cloud are used to manage and query resources of Alibaba Cloud services. We recommend that you integrate these API operations only in management systems. Do not use these API operations in the core system of messaging services. Otherwise, system risks may occur.
          * *   If you do not know the message ID or message key of a message that you want to query, you can call this operation to query all messages that are stored in a topic within a specified time range. The results are displayed by page.
          * *   We recommend that you specify a short time range to query messages. If you specify a long time range, a large number of messages are returned. In this case, you cannot find the message that you want to query in an efficient manner. You can perform the following steps to query messages:
          *     1.  Perform a paged query by specifying the topic, start time, end time, and number of entries to return on each page. If the topic contains messages, the information about the messages on the first page, total number of pages, and task ID are returned by default.
          *     2.  Specify the task ID and a page number to call this operation again to query the messages on the specified page. In this query, the BeginTime, EndTime, and PageSize parameters do not take effect. By default, the system uses the values of these parameters that you specified in the request when you created the specified query task.
          *
          * @param request OnsMessagePageQueryByTopicRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return OnsMessagePageQueryByTopicResponse
         */
        public OnsMessagePageQueryByTopicResponse OnsMessagePageQueryByTopicWithOptions(OnsMessagePageQueryByTopicRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BeginTime))
            {
                query["BeginTime"] = request.BeginTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                query["TaskId"] = request.TaskId;
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
                Action = "OnsMessagePageQueryByTopic",
                Version = "2019-02-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<OnsMessagePageQueryByTopicResponse>(CallApi(params_, req, runtime));
        }

        /**
          * > : The API operations that are provided by Alibaba Cloud are used to manage and query resources of Alibaba Cloud services. We recommend that you integrate these API operations only in management systems. Do not use these API operations in the core system of messaging services. Otherwise, system risks may occur.
          * *   If you do not know the message ID or message key of a message that you want to query, you can call this operation to query all messages that are stored in a topic within a specified time range. The results are displayed by page.
          * *   We recommend that you specify a short time range to query messages. If you specify a long time range, a large number of messages are returned. In this case, you cannot find the message that you want to query in an efficient manner. You can perform the following steps to query messages:
          *     1.  Perform a paged query by specifying the topic, start time, end time, and number of entries to return on each page. If the topic contains messages, the information about the messages on the first page, total number of pages, and task ID are returned by default.
          *     2.  Specify the task ID and a page number to call this operation again to query the messages on the specified page. In this query, the BeginTime, EndTime, and PageSize parameters do not take effect. By default, the system uses the values of these parameters that you specified in the request when you created the specified query task.
          *
          * @param request OnsMessagePageQueryByTopicRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return OnsMessagePageQueryByTopicResponse
         */
        public async Task<OnsMessagePageQueryByTopicResponse> OnsMessagePageQueryByTopicWithOptionsAsync(OnsMessagePageQueryByTopicRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BeginTime))
            {
                query["BeginTime"] = request.BeginTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                query["TaskId"] = request.TaskId;
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
                Action = "OnsMessagePageQueryByTopic",
                Version = "2019-02-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<OnsMessagePageQueryByTopicResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * > : The API operations that are provided by Alibaba Cloud are used to manage and query resources of Alibaba Cloud services. We recommend that you integrate these API operations only in management systems. Do not use these API operations in the core system of messaging services. Otherwise, system risks may occur.
          * *   If you do not know the message ID or message key of a message that you want to query, you can call this operation to query all messages that are stored in a topic within a specified time range. The results are displayed by page.
          * *   We recommend that you specify a short time range to query messages. If you specify a long time range, a large number of messages are returned. In this case, you cannot find the message that you want to query in an efficient manner. You can perform the following steps to query messages:
          *     1.  Perform a paged query by specifying the topic, start time, end time, and number of entries to return on each page. If the topic contains messages, the information about the messages on the first page, total number of pages, and task ID are returned by default.
          *     2.  Specify the task ID and a page number to call this operation again to query the messages on the specified page. In this query, the BeginTime, EndTime, and PageSize parameters do not take effect. By default, the system uses the values of these parameters that you specified in the request when you created the specified query task.
          *
          * @param request OnsMessagePageQueryByTopicRequest
          * @return OnsMessagePageQueryByTopicResponse
         */
        public OnsMessagePageQueryByTopicResponse OnsMessagePageQueryByTopic(OnsMessagePageQueryByTopicRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return OnsMessagePageQueryByTopicWithOptions(request, runtime);
        }

        /**
          * > : The API operations that are provided by Alibaba Cloud are used to manage and query resources of Alibaba Cloud services. We recommend that you integrate these API operations only in management systems. Do not use these API operations in the core system of messaging services. Otherwise, system risks may occur.
          * *   If you do not know the message ID or message key of a message that you want to query, you can call this operation to query all messages that are stored in a topic within a specified time range. The results are displayed by page.
          * *   We recommend that you specify a short time range to query messages. If you specify a long time range, a large number of messages are returned. In this case, you cannot find the message that you want to query in an efficient manner. You can perform the following steps to query messages:
          *     1.  Perform a paged query by specifying the topic, start time, end time, and number of entries to return on each page. If the topic contains messages, the information about the messages on the first page, total number of pages, and task ID are returned by default.
          *     2.  Specify the task ID and a page number to call this operation again to query the messages on the specified page. In this query, the BeginTime, EndTime, and PageSize parameters do not take effect. By default, the system uses the values of these parameters that you specified in the request when you created the specified query task.
          *
          * @param request OnsMessagePageQueryByTopicRequest
          * @return OnsMessagePageQueryByTopicResponse
         */
        public async Task<OnsMessagePageQueryByTopicResponse> OnsMessagePageQueryByTopicAsync(OnsMessagePageQueryByTopicRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await OnsMessagePageQueryByTopicWithOptionsAsync(request, runtime);
        }

        /**
          * ## Note
          * This operation can be used to check whether messages in a specified topic can be consumed by consumers in a specified consumer group. This operation obtains the body of the message that is specified by the MsgId parameter, re-encapsulates the message body to produce a new message, and then pushes the new message to a specified consumer. The content of the message that is sent to the consumer is the same as the content of the original message. They are not the same message because they use different message IDs.
          *
          * @param request OnsMessagePushRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return OnsMessagePushResponse
         */
        public OnsMessagePushResponse OnsMessagePushWithOptions(OnsMessagePushRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientId))
            {
                query["ClientId"] = request.ClientId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                query["GroupId"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MsgId))
            {
                query["MsgId"] = request.MsgId;
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
                Action = "OnsMessagePush",
                Version = "2019-02-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<OnsMessagePushResponse>(CallApi(params_, req, runtime));
        }

        /**
          * ## Note
          * This operation can be used to check whether messages in a specified topic can be consumed by consumers in a specified consumer group. This operation obtains the body of the message that is specified by the MsgId parameter, re-encapsulates the message body to produce a new message, and then pushes the new message to a specified consumer. The content of the message that is sent to the consumer is the same as the content of the original message. They are not the same message because they use different message IDs.
          *
          * @param request OnsMessagePushRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return OnsMessagePushResponse
         */
        public async Task<OnsMessagePushResponse> OnsMessagePushWithOptionsAsync(OnsMessagePushRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientId))
            {
                query["ClientId"] = request.ClientId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                query["GroupId"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MsgId))
            {
                query["MsgId"] = request.MsgId;
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
                Action = "OnsMessagePush",
                Version = "2019-02-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<OnsMessagePushResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * ## Note
          * This operation can be used to check whether messages in a specified topic can be consumed by consumers in a specified consumer group. This operation obtains the body of the message that is specified by the MsgId parameter, re-encapsulates the message body to produce a new message, and then pushes the new message to a specified consumer. The content of the message that is sent to the consumer is the same as the content of the original message. They are not the same message because they use different message IDs.
          *
          * @param request OnsMessagePushRequest
          * @return OnsMessagePushResponse
         */
        public OnsMessagePushResponse OnsMessagePush(OnsMessagePushRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return OnsMessagePushWithOptions(request, runtime);
        }

        /**
          * ## Note
          * This operation can be used to check whether messages in a specified topic can be consumed by consumers in a specified consumer group. This operation obtains the body of the message that is specified by the MsgId parameter, re-encapsulates the message body to produce a new message, and then pushes the new message to a specified consumer. The content of the message that is sent to the consumer is the same as the content of the original message. They are not the same message because they use different message IDs.
          *
          * @param request OnsMessagePushRequest
          * @return OnsMessagePushResponse
         */
        public async Task<OnsMessagePushResponse> OnsMessagePushAsync(OnsMessagePushRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await OnsMessagePushWithOptionsAsync(request, runtime);
        }

        /**
          * > : The API operations that are provided by Alibaba Cloud are used to manage and query resources of Alibaba Cloud services. We recommend that you integrate these API operations only in management systems. Do not use these API operations in the core system of messaging services. Otherwise, system risks may occur.
          * *   You can call this operation to check whether a specified message is consumed. If the message is not consumed, you can troubleshoot the issue based on the returned information.
          * *   This operation queries information based on the built-in offset mechanism of Message Queue for Apache RocketMQ. In most cases, the results are correct. If you have reset the consumer offset or cleared accumulated messages, the results may not be correct.
          *
          * @param request OnsMessageTraceRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return OnsMessageTraceResponse
         */
        public OnsMessageTraceResponse OnsMessageTraceWithOptions(OnsMessageTraceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MsgId))
            {
                query["MsgId"] = request.MsgId;
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
                Action = "OnsMessageTrace",
                Version = "2019-02-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<OnsMessageTraceResponse>(CallApi(params_, req, runtime));
        }

        /**
          * > : The API operations that are provided by Alibaba Cloud are used to manage and query resources of Alibaba Cloud services. We recommend that you integrate these API operations only in management systems. Do not use these API operations in the core system of messaging services. Otherwise, system risks may occur.
          * *   You can call this operation to check whether a specified message is consumed. If the message is not consumed, you can troubleshoot the issue based on the returned information.
          * *   This operation queries information based on the built-in offset mechanism of Message Queue for Apache RocketMQ. In most cases, the results are correct. If you have reset the consumer offset or cleared accumulated messages, the results may not be correct.
          *
          * @param request OnsMessageTraceRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return OnsMessageTraceResponse
         */
        public async Task<OnsMessageTraceResponse> OnsMessageTraceWithOptionsAsync(OnsMessageTraceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MsgId))
            {
                query["MsgId"] = request.MsgId;
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
                Action = "OnsMessageTrace",
                Version = "2019-02-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<OnsMessageTraceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * > : The API operations that are provided by Alibaba Cloud are used to manage and query resources of Alibaba Cloud services. We recommend that you integrate these API operations only in management systems. Do not use these API operations in the core system of messaging services. Otherwise, system risks may occur.
          * *   You can call this operation to check whether a specified message is consumed. If the message is not consumed, you can troubleshoot the issue based on the returned information.
          * *   This operation queries information based on the built-in offset mechanism of Message Queue for Apache RocketMQ. In most cases, the results are correct. If you have reset the consumer offset or cleared accumulated messages, the results may not be correct.
          *
          * @param request OnsMessageTraceRequest
          * @return OnsMessageTraceResponse
         */
        public OnsMessageTraceResponse OnsMessageTrace(OnsMessageTraceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return OnsMessageTraceWithOptions(request, runtime);
        }

        /**
          * > : The API operations that are provided by Alibaba Cloud are used to manage and query resources of Alibaba Cloud services. We recommend that you integrate these API operations only in management systems. Do not use these API operations in the core system of messaging services. Otherwise, system risks may occur.
          * *   You can call this operation to check whether a specified message is consumed. If the message is not consumed, you can troubleshoot the issue based on the returned information.
          * *   This operation queries information based on the built-in offset mechanism of Message Queue for Apache RocketMQ. In most cases, the results are correct. If you have reset the consumer offset or cleared accumulated messages, the results may not be correct.
          *
          * @param request OnsMessageTraceRequest
          * @return OnsMessageTraceResponse
         */
        public async Task<OnsMessageTraceResponse> OnsMessageTraceAsync(OnsMessageTraceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await OnsMessageTraceWithOptionsAsync(request, runtime);
        }

        /**
          * > : The API operations that are provided by Alibaba Cloud are used to manage and query resources of Alibaba Cloud services. We recommend that you integrate these API operations only in management systems. Do not use these API operations in the core system of messaging services. Otherwise, system risks may occur.
          * When you use an SDK to access and manage a Message Queue for Apache RocketMQ instance, you must sequentially specify the information about two regions. You can query the information about the second region by calling the \\*\\*OnsRegionList\\*\\* operation. You must apply for a public endpoint in the following scenarios:
          * *   Connect your application to Message Queue for Apache RocketMQ: Select the nearest API gateway endpoint based on the region where your application is deployed, and enter the corresponding **region ID**. The **regionId** is used to access Alibaba Cloud API Gateway because Message Queue for Apache RocketMQ instances provide API services by using the OpenAPI Explorer platform, which is also called POP.
          * *   Access a region to manage its resources: Specify a region where you want to manage Message Queue for Apache RocketMQ resources and enter the region ID. You can query the region ID by calling the **OnsRegionList** operation.
          *
          * @param request OnsRegionListRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return OnsRegionListResponse
         */
        public OnsRegionListResponse OnsRegionListWithOptions(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "OnsRegionList",
                Version = "2019-02-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<OnsRegionListResponse>(CallApi(params_, req, runtime));
        }

        /**
          * > : The API operations that are provided by Alibaba Cloud are used to manage and query resources of Alibaba Cloud services. We recommend that you integrate these API operations only in management systems. Do not use these API operations in the core system of messaging services. Otherwise, system risks may occur.
          * When you use an SDK to access and manage a Message Queue for Apache RocketMQ instance, you must sequentially specify the information about two regions. You can query the information about the second region by calling the \\*\\*OnsRegionList\\*\\* operation. You must apply for a public endpoint in the following scenarios:
          * *   Connect your application to Message Queue for Apache RocketMQ: Select the nearest API gateway endpoint based on the region where your application is deployed, and enter the corresponding **region ID**. The **regionId** is used to access Alibaba Cloud API Gateway because Message Queue for Apache RocketMQ instances provide API services by using the OpenAPI Explorer platform, which is also called POP.
          * *   Access a region to manage its resources: Specify a region where you want to manage Message Queue for Apache RocketMQ resources and enter the region ID. You can query the region ID by calling the **OnsRegionList** operation.
          *
          * @param request OnsRegionListRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return OnsRegionListResponse
         */
        public async Task<OnsRegionListResponse> OnsRegionListWithOptionsAsync(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "OnsRegionList",
                Version = "2019-02-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<OnsRegionListResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * > : The API operations that are provided by Alibaba Cloud are used to manage and query resources of Alibaba Cloud services. We recommend that you integrate these API operations only in management systems. Do not use these API operations in the core system of messaging services. Otherwise, system risks may occur.
          * When you use an SDK to access and manage a Message Queue for Apache RocketMQ instance, you must sequentially specify the information about two regions. You can query the information about the second region by calling the \\*\\*OnsRegionList\\*\\* operation. You must apply for a public endpoint in the following scenarios:
          * *   Connect your application to Message Queue for Apache RocketMQ: Select the nearest API gateway endpoint based on the region where your application is deployed, and enter the corresponding **region ID**. The **regionId** is used to access Alibaba Cloud API Gateway because Message Queue for Apache RocketMQ instances provide API services by using the OpenAPI Explorer platform, which is also called POP.
          * *   Access a region to manage its resources: Specify a region where you want to manage Message Queue for Apache RocketMQ resources and enter the region ID. You can query the region ID by calling the **OnsRegionList** operation.
          *
          * @return OnsRegionListResponse
         */
        public OnsRegionListResponse OnsRegionList()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return OnsRegionListWithOptions(runtime);
        }

        /**
          * > : The API operations that are provided by Alibaba Cloud are used to manage and query resources of Alibaba Cloud services. We recommend that you integrate these API operations only in management systems. Do not use these API operations in the core system of messaging services. Otherwise, system risks may occur.
          * When you use an SDK to access and manage a Message Queue for Apache RocketMQ instance, you must sequentially specify the information about two regions. You can query the information about the second region by calling the \\*\\*OnsRegionList\\*\\* operation. You must apply for a public endpoint in the following scenarios:
          * *   Connect your application to Message Queue for Apache RocketMQ: Select the nearest API gateway endpoint based on the region where your application is deployed, and enter the corresponding **region ID**. The **regionId** is used to access Alibaba Cloud API Gateway because Message Queue for Apache RocketMQ instances provide API services by using the OpenAPI Explorer platform, which is also called POP.
          * *   Access a region to manage its resources: Specify a region where you want to manage Message Queue for Apache RocketMQ resources and enter the region ID. You can query the region ID by calling the **OnsRegionList** operation.
          *
          * @return OnsRegionListResponse
         */
        public async Task<OnsRegionListResponse> OnsRegionListAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await OnsRegionListWithOptionsAsync(runtime);
        }

        /**
          * > : The API operations that are provided by Alibaba Cloud are used to manage and query resources of Alibaba Cloud services. We recommend that you integrate these API operations only in management systems. Do not use these API operations in the core system of messaging services. Otherwise, system risks may occur.
          * When you want to release a new application or expand your business, you can call this operation to create a topic based on your business requirements.
          *
          * @param request OnsTopicCreateRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return OnsTopicCreateResponse
         */
        public OnsTopicCreateResponse OnsTopicCreateWithOptions(OnsTopicCreateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MessageType))
            {
                query["MessageType"] = request.MessageType;
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
                Action = "OnsTopicCreate",
                Version = "2019-02-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<OnsTopicCreateResponse>(CallApi(params_, req, runtime));
        }

        /**
          * > : The API operations that are provided by Alibaba Cloud are used to manage and query resources of Alibaba Cloud services. We recommend that you integrate these API operations only in management systems. Do not use these API operations in the core system of messaging services. Otherwise, system risks may occur.
          * When you want to release a new application or expand your business, you can call this operation to create a topic based on your business requirements.
          *
          * @param request OnsTopicCreateRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return OnsTopicCreateResponse
         */
        public async Task<OnsTopicCreateResponse> OnsTopicCreateWithOptionsAsync(OnsTopicCreateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MessageType))
            {
                query["MessageType"] = request.MessageType;
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
                Action = "OnsTopicCreate",
                Version = "2019-02-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<OnsTopicCreateResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * > : The API operations that are provided by Alibaba Cloud are used to manage and query resources of Alibaba Cloud services. We recommend that you integrate these API operations only in management systems. Do not use these API operations in the core system of messaging services. Otherwise, system risks may occur.
          * When you want to release a new application or expand your business, you can call this operation to create a topic based on your business requirements.
          *
          * @param request OnsTopicCreateRequest
          * @return OnsTopicCreateResponse
         */
        public OnsTopicCreateResponse OnsTopicCreate(OnsTopicCreateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return OnsTopicCreateWithOptions(request, runtime);
        }

        /**
          * > : The API operations that are provided by Alibaba Cloud are used to manage and query resources of Alibaba Cloud services. We recommend that you integrate these API operations only in management systems. Do not use these API operations in the core system of messaging services. Otherwise, system risks may occur.
          * When you want to release a new application or expand your business, you can call this operation to create a topic based on your business requirements.
          *
          * @param request OnsTopicCreateRequest
          * @return OnsTopicCreateResponse
         */
        public async Task<OnsTopicCreateResponse> OnsTopicCreateAsync(OnsTopicCreateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await OnsTopicCreateWithOptionsAsync(request, runtime);
        }

        /**
          * >  The API operations that are provided by Alibaba Cloud are used to manage and query resources of Alibaba Cloud services. We recommend that you integrate these API operations only in management systems. Do not use these API operations in the core system of messaging services. Otherwise, system risks may occur. - After you delete the topic, the publishing and subscription relationships that are constructed based on the topic are cleared. Exercise caution when you call this operation.
          * You can call this operation to delete a topic when you need to reclaim the resources from the topic. For example, after an application is brought offline, you can delete the topics that are used for the application. After you delete a topic, the backend of Message Queue for Apache RocketMQ reclaims the resources from the topic. The system requires a long period of time to reclaim the resources. After you delete a topic, we recommend that you do not create a topic that uses the same name as the deleted topic within a short period of time. If the system fails to delete the specified topic, troubleshoot the issue based on the error code.
          *
          * @param request OnsTopicDeleteRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return OnsTopicDeleteResponse
         */
        public OnsTopicDeleteResponse OnsTopicDeleteWithOptions(OnsTopicDeleteRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
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
                Action = "OnsTopicDelete",
                Version = "2019-02-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<OnsTopicDeleteResponse>(CallApi(params_, req, runtime));
        }

        /**
          * >  The API operations that are provided by Alibaba Cloud are used to manage and query resources of Alibaba Cloud services. We recommend that you integrate these API operations only in management systems. Do not use these API operations in the core system of messaging services. Otherwise, system risks may occur. - After you delete the topic, the publishing and subscription relationships that are constructed based on the topic are cleared. Exercise caution when you call this operation.
          * You can call this operation to delete a topic when you need to reclaim the resources from the topic. For example, after an application is brought offline, you can delete the topics that are used for the application. After you delete a topic, the backend of Message Queue for Apache RocketMQ reclaims the resources from the topic. The system requires a long period of time to reclaim the resources. After you delete a topic, we recommend that you do not create a topic that uses the same name as the deleted topic within a short period of time. If the system fails to delete the specified topic, troubleshoot the issue based on the error code.
          *
          * @param request OnsTopicDeleteRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return OnsTopicDeleteResponse
         */
        public async Task<OnsTopicDeleteResponse> OnsTopicDeleteWithOptionsAsync(OnsTopicDeleteRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
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
                Action = "OnsTopicDelete",
                Version = "2019-02-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<OnsTopicDeleteResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * >  The API operations that are provided by Alibaba Cloud are used to manage and query resources of Alibaba Cloud services. We recommend that you integrate these API operations only in management systems. Do not use these API operations in the core system of messaging services. Otherwise, system risks may occur. - After you delete the topic, the publishing and subscription relationships that are constructed based on the topic are cleared. Exercise caution when you call this operation.
          * You can call this operation to delete a topic when you need to reclaim the resources from the topic. For example, after an application is brought offline, you can delete the topics that are used for the application. After you delete a topic, the backend of Message Queue for Apache RocketMQ reclaims the resources from the topic. The system requires a long period of time to reclaim the resources. After you delete a topic, we recommend that you do not create a topic that uses the same name as the deleted topic within a short period of time. If the system fails to delete the specified topic, troubleshoot the issue based on the error code.
          *
          * @param request OnsTopicDeleteRequest
          * @return OnsTopicDeleteResponse
         */
        public OnsTopicDeleteResponse OnsTopicDelete(OnsTopicDeleteRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return OnsTopicDeleteWithOptions(request, runtime);
        }

        /**
          * >  The API operations that are provided by Alibaba Cloud are used to manage and query resources of Alibaba Cloud services. We recommend that you integrate these API operations only in management systems. Do not use these API operations in the core system of messaging services. Otherwise, system risks may occur. - After you delete the topic, the publishing and subscription relationships that are constructed based on the topic are cleared. Exercise caution when you call this operation.
          * You can call this operation to delete a topic when you need to reclaim the resources from the topic. For example, after an application is brought offline, you can delete the topics that are used for the application. After you delete a topic, the backend of Message Queue for Apache RocketMQ reclaims the resources from the topic. The system requires a long period of time to reclaim the resources. After you delete a topic, we recommend that you do not create a topic that uses the same name as the deleted topic within a short period of time. If the system fails to delete the specified topic, troubleshoot the issue based on the error code.
          *
          * @param request OnsTopicDeleteRequest
          * @return OnsTopicDeleteResponse
         */
        public async Task<OnsTopicDeleteResponse> OnsTopicDeleteAsync(OnsTopicDeleteRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await OnsTopicDeleteWithOptionsAsync(request, runtime);
        }

        /**
          * > : The API operations that are provided by Alibaba Cloud are used to manage and query resources of Alibaba Cloud services. We recommend that you integrate these API operations only in management systems. Do not use these API operations in the core system of messaging services. Otherwise, system risks may occur.
          * This operation returns the basic information about topics and does not return the details of topics.
          *
          * @param request OnsTopicListRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return OnsTopicListResponse
         */
        public OnsTopicListResponse OnsTopicListWithOptions(OnsTopicListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                query["Tag"] = request.Tag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Topic))
            {
                query["Topic"] = request.Topic;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["UserId"] = request.UserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "OnsTopicList",
                Version = "2019-02-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<OnsTopicListResponse>(CallApi(params_, req, runtime));
        }

        /**
          * > : The API operations that are provided by Alibaba Cloud are used to manage and query resources of Alibaba Cloud services. We recommend that you integrate these API operations only in management systems. Do not use these API operations in the core system of messaging services. Otherwise, system risks may occur.
          * This operation returns the basic information about topics and does not return the details of topics.
          *
          * @param request OnsTopicListRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return OnsTopicListResponse
         */
        public async Task<OnsTopicListResponse> OnsTopicListWithOptionsAsync(OnsTopicListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                query["Tag"] = request.Tag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Topic))
            {
                query["Topic"] = request.Topic;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["UserId"] = request.UserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "OnsTopicList",
                Version = "2019-02-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<OnsTopicListResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * > : The API operations that are provided by Alibaba Cloud are used to manage and query resources of Alibaba Cloud services. We recommend that you integrate these API operations only in management systems. Do not use these API operations in the core system of messaging services. Otherwise, system risks may occur.
          * This operation returns the basic information about topics and does not return the details of topics.
          *
          * @param request OnsTopicListRequest
          * @return OnsTopicListResponse
         */
        public OnsTopicListResponse OnsTopicList(OnsTopicListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return OnsTopicListWithOptions(request, runtime);
        }

        /**
          * > : The API operations that are provided by Alibaba Cloud are used to manage and query resources of Alibaba Cloud services. We recommend that you integrate these API operations only in management systems. Do not use these API operations in the core system of messaging services. Otherwise, system risks may occur.
          * This operation returns the basic information about topics and does not return the details of topics.
          *
          * @param request OnsTopicListRequest
          * @return OnsTopicListResponse
         */
        public async Task<OnsTopicListResponse> OnsTopicListAsync(OnsTopicListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await OnsTopicListWithOptionsAsync(request, runtime);
        }

        /**
          * > : The API operations that are provided by Alibaba Cloud are used to manage and query resources of Alibaba Cloud services. We recommend that you integrate these API operations only in management systems. Do not use these API operations in the core system of messaging services. Otherwise, system risks may occur.
          * You can determine the resource usage of a topic based on the information that is returned by this operation. The returned information includes the total number of messages in the topic and the most recent point in time when a message was published to the topic.
          *
          * @param request OnsTopicStatusRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return OnsTopicStatusResponse
         */
        public OnsTopicStatusResponse OnsTopicStatusWithOptions(OnsTopicStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
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
                Action = "OnsTopicStatus",
                Version = "2019-02-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<OnsTopicStatusResponse>(CallApi(params_, req, runtime));
        }

        /**
          * > : The API operations that are provided by Alibaba Cloud are used to manage and query resources of Alibaba Cloud services. We recommend that you integrate these API operations only in management systems. Do not use these API operations in the core system of messaging services. Otherwise, system risks may occur.
          * You can determine the resource usage of a topic based on the information that is returned by this operation. The returned information includes the total number of messages in the topic and the most recent point in time when a message was published to the topic.
          *
          * @param request OnsTopicStatusRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return OnsTopicStatusResponse
         */
        public async Task<OnsTopicStatusResponse> OnsTopicStatusWithOptionsAsync(OnsTopicStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
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
                Action = "OnsTopicStatus",
                Version = "2019-02-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<OnsTopicStatusResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * > : The API operations that are provided by Alibaba Cloud are used to manage and query resources of Alibaba Cloud services. We recommend that you integrate these API operations only in management systems. Do not use these API operations in the core system of messaging services. Otherwise, system risks may occur.
          * You can determine the resource usage of a topic based on the information that is returned by this operation. The returned information includes the total number of messages in the topic and the most recent point in time when a message was published to the topic.
          *
          * @param request OnsTopicStatusRequest
          * @return OnsTopicStatusResponse
         */
        public OnsTopicStatusResponse OnsTopicStatus(OnsTopicStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return OnsTopicStatusWithOptions(request, runtime);
        }

        /**
          * > : The API operations that are provided by Alibaba Cloud are used to manage and query resources of Alibaba Cloud services. We recommend that you integrate these API operations only in management systems. Do not use these API operations in the core system of messaging services. Otherwise, system risks may occur.
          * You can determine the resource usage of a topic based on the information that is returned by this operation. The returned information includes the total number of messages in the topic and the most recent point in time when a message was published to the topic.
          *
          * @param request OnsTopicStatusRequest
          * @return OnsTopicStatusResponse
         */
        public async Task<OnsTopicStatusResponse> OnsTopicStatusAsync(OnsTopicStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await OnsTopicStatusWithOptionsAsync(request, runtime);
        }

        /**
          * > : The API operations that are provided by Alibaba Cloud are used to manage and query resources of Alibaba Cloud services. We recommend that you integrate these API operations only in management systems. Do not use these API operations in the core system of messaging services. Otherwise, system risks may occur.
          * You can call this operation to query the online consumer groups that subscribe to a specified topic. If all consumers in a group are offline, the information about the group is not returned.
          *
          * @param request OnsTopicSubDetailRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return OnsTopicSubDetailResponse
         */
        public OnsTopicSubDetailResponse OnsTopicSubDetailWithOptions(OnsTopicSubDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
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
                Action = "OnsTopicSubDetail",
                Version = "2019-02-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<OnsTopicSubDetailResponse>(CallApi(params_, req, runtime));
        }

        /**
          * > : The API operations that are provided by Alibaba Cloud are used to manage and query resources of Alibaba Cloud services. We recommend that you integrate these API operations only in management systems. Do not use these API operations in the core system of messaging services. Otherwise, system risks may occur.
          * You can call this operation to query the online consumer groups that subscribe to a specified topic. If all consumers in a group are offline, the information about the group is not returned.
          *
          * @param request OnsTopicSubDetailRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return OnsTopicSubDetailResponse
         */
        public async Task<OnsTopicSubDetailResponse> OnsTopicSubDetailWithOptionsAsync(OnsTopicSubDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
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
                Action = "OnsTopicSubDetail",
                Version = "2019-02-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<OnsTopicSubDetailResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * > : The API operations that are provided by Alibaba Cloud are used to manage and query resources of Alibaba Cloud services. We recommend that you integrate these API operations only in management systems. Do not use these API operations in the core system of messaging services. Otherwise, system risks may occur.
          * You can call this operation to query the online consumer groups that subscribe to a specified topic. If all consumers in a group are offline, the information about the group is not returned.
          *
          * @param request OnsTopicSubDetailRequest
          * @return OnsTopicSubDetailResponse
         */
        public OnsTopicSubDetailResponse OnsTopicSubDetail(OnsTopicSubDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return OnsTopicSubDetailWithOptions(request, runtime);
        }

        /**
          * > : The API operations that are provided by Alibaba Cloud are used to manage and query resources of Alibaba Cloud services. We recommend that you integrate these API operations only in management systems. Do not use these API operations in the core system of messaging services. Otherwise, system risks may occur.
          * You can call this operation to query the online consumer groups that subscribe to a specified topic. If all consumers in a group are offline, the information about the group is not returned.
          *
          * @param request OnsTopicSubDetailRequest
          * @return OnsTopicSubDetailResponse
         */
        public async Task<OnsTopicSubDetailResponse> OnsTopicSubDetailAsync(OnsTopicSubDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await OnsTopicSubDetailWithOptionsAsync(request, runtime);
        }

        /**
          * @deprecated
          * > : The API operations that are provided by Alibaba Cloud are used to manage and query resources of Alibaba Cloud services. We recommend that you integrate these API operations only in management systems. Do not use these API operations in the core system of messaging services. Otherwise system risks may occur.
          * You can call this operation to forbid read or write operations on a specific topic.
          *
          * @param request OnsTopicUpdateRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return OnsTopicUpdateResponse
         */
        // Deprecated
        public OnsTopicUpdateResponse OnsTopicUpdateWithOptions(OnsTopicUpdateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Perm))
            {
                query["Perm"] = request.Perm;
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
                Action = "OnsTopicUpdate",
                Version = "2019-02-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<OnsTopicUpdateResponse>(CallApi(params_, req, runtime));
        }

        /**
          * @deprecated
          * > : The API operations that are provided by Alibaba Cloud are used to manage and query resources of Alibaba Cloud services. We recommend that you integrate these API operations only in management systems. Do not use these API operations in the core system of messaging services. Otherwise system risks may occur.
          * You can call this operation to forbid read or write operations on a specific topic.
          *
          * @param request OnsTopicUpdateRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return OnsTopicUpdateResponse
         */
        // Deprecated
        public async Task<OnsTopicUpdateResponse> OnsTopicUpdateWithOptionsAsync(OnsTopicUpdateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Perm))
            {
                query["Perm"] = request.Perm;
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
                Action = "OnsTopicUpdate",
                Version = "2019-02-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<OnsTopicUpdateResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * @deprecated
          * > : The API operations that are provided by Alibaba Cloud are used to manage and query resources of Alibaba Cloud services. We recommend that you integrate these API operations only in management systems. Do not use these API operations in the core system of messaging services. Otherwise system risks may occur.
          * You can call this operation to forbid read or write operations on a specific topic.
          *
          * @param request OnsTopicUpdateRequest
          * @return OnsTopicUpdateResponse
         */
        // Deprecated
        public OnsTopicUpdateResponse OnsTopicUpdate(OnsTopicUpdateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return OnsTopicUpdateWithOptions(request, runtime);
        }

        /**
          * @deprecated
          * > : The API operations that are provided by Alibaba Cloud are used to manage and query resources of Alibaba Cloud services. We recommend that you integrate these API operations only in management systems. Do not use these API operations in the core system of messaging services. Otherwise system risks may occur.
          * You can call this operation to forbid read or write operations on a specific topic.
          *
          * @param request OnsTopicUpdateRequest
          * @return OnsTopicUpdateResponse
         */
        // Deprecated
        public async Task<OnsTopicUpdateResponse> OnsTopicUpdateAsync(OnsTopicUpdateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await OnsTopicUpdateWithOptionsAsync(request, runtime);
        }

        /**
          * ## Usage notes
          * *   Before you call this operation to query the details of the trace of a message, you must create a task to query the trace of the message based on the message ID or message key and obtains the task ID. Then, you can call this operation to query the details of the message trace based on the task ID. You can call the [OnsTraceQueryByMsgId](~~59830~~) operation or the [OnsTraceQueryByMsgKey](~~59831~~) operation to create a task to query the trace of the message and obtain the task ID from the **QueryId** response parameter.
          * *   A trace query task is time-consuming. If you call this operation to query the details immediately after you create a trace query task, the results may be empty. In this case, we recommend that you try again later.
          *
          * @param request OnsTraceGetResultRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return OnsTraceGetResultResponse
         */
        public OnsTraceGetResultResponse OnsTraceGetResultWithOptions(OnsTraceGetResultRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueryId))
            {
                query["QueryId"] = request.QueryId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "OnsTraceGetResult",
                Version = "2019-02-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<OnsTraceGetResultResponse>(CallApi(params_, req, runtime));
        }

        /**
          * ## Usage notes
          * *   Before you call this operation to query the details of the trace of a message, you must create a task to query the trace of the message based on the message ID or message key and obtains the task ID. Then, you can call this operation to query the details of the message trace based on the task ID. You can call the [OnsTraceQueryByMsgId](~~59830~~) operation or the [OnsTraceQueryByMsgKey](~~59831~~) operation to create a task to query the trace of the message and obtain the task ID from the **QueryId** response parameter.
          * *   A trace query task is time-consuming. If you call this operation to query the details immediately after you create a trace query task, the results may be empty. In this case, we recommend that you try again later.
          *
          * @param request OnsTraceGetResultRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return OnsTraceGetResultResponse
         */
        public async Task<OnsTraceGetResultResponse> OnsTraceGetResultWithOptionsAsync(OnsTraceGetResultRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueryId))
            {
                query["QueryId"] = request.QueryId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "OnsTraceGetResult",
                Version = "2019-02-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<OnsTraceGetResultResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * ## Usage notes
          * *   Before you call this operation to query the details of the trace of a message, you must create a task to query the trace of the message based on the message ID or message key and obtains the task ID. Then, you can call this operation to query the details of the message trace based on the task ID. You can call the [OnsTraceQueryByMsgId](~~59830~~) operation or the [OnsTraceQueryByMsgKey](~~59831~~) operation to create a task to query the trace of the message and obtain the task ID from the **QueryId** response parameter.
          * *   A trace query task is time-consuming. If you call this operation to query the details immediately after you create a trace query task, the results may be empty. In this case, we recommend that you try again later.
          *
          * @param request OnsTraceGetResultRequest
          * @return OnsTraceGetResultResponse
         */
        public OnsTraceGetResultResponse OnsTraceGetResult(OnsTraceGetResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return OnsTraceGetResultWithOptions(request, runtime);
        }

        /**
          * ## Usage notes
          * *   Before you call this operation to query the details of the trace of a message, you must create a task to query the trace of the message based on the message ID or message key and obtains the task ID. Then, you can call this operation to query the details of the message trace based on the task ID. You can call the [OnsTraceQueryByMsgId](~~59830~~) operation or the [OnsTraceQueryByMsgKey](~~59831~~) operation to create a task to query the trace of the message and obtain the task ID from the **QueryId** response parameter.
          * *   A trace query task is time-consuming. If you call this operation to query the details immediately after you create a trace query task, the results may be empty. In this case, we recommend that you try again later.
          *
          * @param request OnsTraceGetResultRequest
          * @return OnsTraceGetResultResponse
         */
        public async Task<OnsTraceGetResultResponse> OnsTraceGetResultAsync(OnsTraceGetResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await OnsTraceGetResultWithOptionsAsync(request, runtime);
        }

        /**
          * ## Note
          * If you want to query the trace of a message based on the message ID, you can call this operation to create a query task. After you obtain the task ID, you can call the [OnsTraceGetResult](~~59832~~) operation to query the details of the message trace based on the task ID.
          *
          * @param request OnsTraceQueryByMsgIdRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return OnsTraceQueryByMsgIdResponse
         */
        public OnsTraceQueryByMsgIdResponse OnsTraceQueryByMsgIdWithOptions(OnsTraceQueryByMsgIdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BeginTime))
            {
                query["BeginTime"] = request.BeginTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MsgId))
            {
                query["MsgId"] = request.MsgId;
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
                Action = "OnsTraceQueryByMsgId",
                Version = "2019-02-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<OnsTraceQueryByMsgIdResponse>(CallApi(params_, req, runtime));
        }

        /**
          * ## Note
          * If you want to query the trace of a message based on the message ID, you can call this operation to create a query task. After you obtain the task ID, you can call the [OnsTraceGetResult](~~59832~~) operation to query the details of the message trace based on the task ID.
          *
          * @param request OnsTraceQueryByMsgIdRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return OnsTraceQueryByMsgIdResponse
         */
        public async Task<OnsTraceQueryByMsgIdResponse> OnsTraceQueryByMsgIdWithOptionsAsync(OnsTraceQueryByMsgIdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BeginTime))
            {
                query["BeginTime"] = request.BeginTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MsgId))
            {
                query["MsgId"] = request.MsgId;
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
                Action = "OnsTraceQueryByMsgId",
                Version = "2019-02-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<OnsTraceQueryByMsgIdResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * ## Note
          * If you want to query the trace of a message based on the message ID, you can call this operation to create a query task. After you obtain the task ID, you can call the [OnsTraceGetResult](~~59832~~) operation to query the details of the message trace based on the task ID.
          *
          * @param request OnsTraceQueryByMsgIdRequest
          * @return OnsTraceQueryByMsgIdResponse
         */
        public OnsTraceQueryByMsgIdResponse OnsTraceQueryByMsgId(OnsTraceQueryByMsgIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return OnsTraceQueryByMsgIdWithOptions(request, runtime);
        }

        /**
          * ## Note
          * If you want to query the trace of a message based on the message ID, you can call this operation to create a query task. After you obtain the task ID, you can call the [OnsTraceGetResult](~~59832~~) operation to query the details of the message trace based on the task ID.
          *
          * @param request OnsTraceQueryByMsgIdRequest
          * @return OnsTraceQueryByMsgIdResponse
         */
        public async Task<OnsTraceQueryByMsgIdResponse> OnsTraceQueryByMsgIdAsync(OnsTraceQueryByMsgIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await OnsTraceQueryByMsgIdWithOptionsAsync(request, runtime);
        }

        /**
          * > : The API operations that are provided by Alibaba Cloud are used to manage and query resources of Alibaba Cloud services. We recommend that you integrate these API operations only in management systems. Do not use these API operations in the core system of messaging services. Otherwise, system risks may occur.
          * If you obtain the key of a message and want to query the trace of the message, you can call this operation to create a query task. After you obtain the task ID, you can call the OnsTraceGetResult operation to query the details of the message trace based on the task ID.
          *
          * @param request OnsTraceQueryByMsgKeyRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return OnsTraceQueryByMsgKeyResponse
         */
        public OnsTraceQueryByMsgKeyResponse OnsTraceQueryByMsgKeyWithOptions(OnsTraceQueryByMsgKeyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BeginTime))
            {
                query["BeginTime"] = request.BeginTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MsgKey))
            {
                query["MsgKey"] = request.MsgKey;
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
                Action = "OnsTraceQueryByMsgKey",
                Version = "2019-02-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<OnsTraceQueryByMsgKeyResponse>(CallApi(params_, req, runtime));
        }

        /**
          * > : The API operations that are provided by Alibaba Cloud are used to manage and query resources of Alibaba Cloud services. We recommend that you integrate these API operations only in management systems. Do not use these API operations in the core system of messaging services. Otherwise, system risks may occur.
          * If you obtain the key of a message and want to query the trace of the message, you can call this operation to create a query task. After you obtain the task ID, you can call the OnsTraceGetResult operation to query the details of the message trace based on the task ID.
          *
          * @param request OnsTraceQueryByMsgKeyRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return OnsTraceQueryByMsgKeyResponse
         */
        public async Task<OnsTraceQueryByMsgKeyResponse> OnsTraceQueryByMsgKeyWithOptionsAsync(OnsTraceQueryByMsgKeyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BeginTime))
            {
                query["BeginTime"] = request.BeginTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MsgKey))
            {
                query["MsgKey"] = request.MsgKey;
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
                Action = "OnsTraceQueryByMsgKey",
                Version = "2019-02-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<OnsTraceQueryByMsgKeyResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * > : The API operations that are provided by Alibaba Cloud are used to manage and query resources of Alibaba Cloud services. We recommend that you integrate these API operations only in management systems. Do not use these API operations in the core system of messaging services. Otherwise, system risks may occur.
          * If you obtain the key of a message and want to query the trace of the message, you can call this operation to create a query task. After you obtain the task ID, you can call the OnsTraceGetResult operation to query the details of the message trace based on the task ID.
          *
          * @param request OnsTraceQueryByMsgKeyRequest
          * @return OnsTraceQueryByMsgKeyResponse
         */
        public OnsTraceQueryByMsgKeyResponse OnsTraceQueryByMsgKey(OnsTraceQueryByMsgKeyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return OnsTraceQueryByMsgKeyWithOptions(request, runtime);
        }

        /**
          * > : The API operations that are provided by Alibaba Cloud are used to manage and query resources of Alibaba Cloud services. We recommend that you integrate these API operations only in management systems. Do not use these API operations in the core system of messaging services. Otherwise, system risks may occur.
          * If you obtain the key of a message and want to query the trace of the message, you can call this operation to create a query task. After you obtain the task ID, you can call the OnsTraceGetResult operation to query the details of the message trace based on the task ID.
          *
          * @param request OnsTraceQueryByMsgKeyRequest
          * @return OnsTraceQueryByMsgKeyResponse
         */
        public async Task<OnsTraceQueryByMsgKeyResponse> OnsTraceQueryByMsgKeyAsync(OnsTraceQueryByMsgKeyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await OnsTraceQueryByMsgKeyWithOptionsAsync(request, runtime);
        }

        /**
          * ## Note
          * You can call this operation to query the following statistics that are collected in the production environment:
          * *   The number of messages that are consumed during each sampling period
          * *   The transactions per second (TPS) for message consumption during each sampling period
          * >  If your application publishes a small number of messages and does not publish messages at a specific interval, we recommend that you query the number of messages that are consumed during each sampling period because the statistics of TPS may not show a clear change trend.
          *
          * @param request OnsTrendGroupOutputTpsRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return OnsTrendGroupOutputTpsResponse
         */
        public OnsTrendGroupOutputTpsResponse OnsTrendGroupOutputTpsWithOptions(OnsTrendGroupOutputTpsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BeginTime))
            {
                query["BeginTime"] = request.BeginTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                query["GroupId"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Period))
            {
                query["Period"] = request.Period;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Topic))
            {
                query["Topic"] = request.Topic;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["Type"] = request.Type;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "OnsTrendGroupOutputTps",
                Version = "2019-02-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<OnsTrendGroupOutputTpsResponse>(CallApi(params_, req, runtime));
        }

        /**
          * ## Note
          * You can call this operation to query the following statistics that are collected in the production environment:
          * *   The number of messages that are consumed during each sampling period
          * *   The transactions per second (TPS) for message consumption during each sampling period
          * >  If your application publishes a small number of messages and does not publish messages at a specific interval, we recommend that you query the number of messages that are consumed during each sampling period because the statistics of TPS may not show a clear change trend.
          *
          * @param request OnsTrendGroupOutputTpsRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return OnsTrendGroupOutputTpsResponse
         */
        public async Task<OnsTrendGroupOutputTpsResponse> OnsTrendGroupOutputTpsWithOptionsAsync(OnsTrendGroupOutputTpsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BeginTime))
            {
                query["BeginTime"] = request.BeginTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupId))
            {
                query["GroupId"] = request.GroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Period))
            {
                query["Period"] = request.Period;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Topic))
            {
                query["Topic"] = request.Topic;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["Type"] = request.Type;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "OnsTrendGroupOutputTps",
                Version = "2019-02-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<OnsTrendGroupOutputTpsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * ## Note
          * You can call this operation to query the following statistics that are collected in the production environment:
          * *   The number of messages that are consumed during each sampling period
          * *   The transactions per second (TPS) for message consumption during each sampling period
          * >  If your application publishes a small number of messages and does not publish messages at a specific interval, we recommend that you query the number of messages that are consumed during each sampling period because the statistics of TPS may not show a clear change trend.
          *
          * @param request OnsTrendGroupOutputTpsRequest
          * @return OnsTrendGroupOutputTpsResponse
         */
        public OnsTrendGroupOutputTpsResponse OnsTrendGroupOutputTps(OnsTrendGroupOutputTpsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return OnsTrendGroupOutputTpsWithOptions(request, runtime);
        }

        /**
          * ## Note
          * You can call this operation to query the following statistics that are collected in the production environment:
          * *   The number of messages that are consumed during each sampling period
          * *   The transactions per second (TPS) for message consumption during each sampling period
          * >  If your application publishes a small number of messages and does not publish messages at a specific interval, we recommend that you query the number of messages that are consumed during each sampling period because the statistics of TPS may not show a clear change trend.
          *
          * @param request OnsTrendGroupOutputTpsRequest
          * @return OnsTrendGroupOutputTpsResponse
         */
        public async Task<OnsTrendGroupOutputTpsResponse> OnsTrendGroupOutputTpsAsync(OnsTrendGroupOutputTpsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await OnsTrendGroupOutputTpsWithOptionsAsync(request, runtime);
        }

        /**
          * ## Note
          * You can call this operation to query the statistics of messages that are published to a specified topic in the production environment. You can obtain the number of messages that are published to the topic or the transactions per second (TPS) for message publishing during each sampling period within a specified time range.
          * >  If your application publishes a small number of messages and does not publish messages at a specific interval, we recommend that you query the number of messages that are published to the topic during each sampling period because the statistics of TPS may not show a clear change trend.
          *
          * @param request OnsTrendTopicInputTpsRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return OnsTrendTopicInputTpsResponse
         */
        public OnsTrendTopicInputTpsResponse OnsTrendTopicInputTpsWithOptions(OnsTrendTopicInputTpsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BeginTime))
            {
                query["BeginTime"] = request.BeginTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Period))
            {
                query["Period"] = request.Period;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Topic))
            {
                query["Topic"] = request.Topic;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["Type"] = request.Type;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "OnsTrendTopicInputTps",
                Version = "2019-02-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<OnsTrendTopicInputTpsResponse>(CallApi(params_, req, runtime));
        }

        /**
          * ## Note
          * You can call this operation to query the statistics of messages that are published to a specified topic in the production environment. You can obtain the number of messages that are published to the topic or the transactions per second (TPS) for message publishing during each sampling period within a specified time range.
          * >  If your application publishes a small number of messages and does not publish messages at a specific interval, we recommend that you query the number of messages that are published to the topic during each sampling period because the statistics of TPS may not show a clear change trend.
          *
          * @param request OnsTrendTopicInputTpsRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return OnsTrendTopicInputTpsResponse
         */
        public async Task<OnsTrendTopicInputTpsResponse> OnsTrendTopicInputTpsWithOptionsAsync(OnsTrendTopicInputTpsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BeginTime))
            {
                query["BeginTime"] = request.BeginTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Period))
            {
                query["Period"] = request.Period;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Topic))
            {
                query["Topic"] = request.Topic;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["Type"] = request.Type;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "OnsTrendTopicInputTps",
                Version = "2019-02-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<OnsTrendTopicInputTpsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * ## Note
          * You can call this operation to query the statistics of messages that are published to a specified topic in the production environment. You can obtain the number of messages that are published to the topic or the transactions per second (TPS) for message publishing during each sampling period within a specified time range.
          * >  If your application publishes a small number of messages and does not publish messages at a specific interval, we recommend that you query the number of messages that are published to the topic during each sampling period because the statistics of TPS may not show a clear change trend.
          *
          * @param request OnsTrendTopicInputTpsRequest
          * @return OnsTrendTopicInputTpsResponse
         */
        public OnsTrendTopicInputTpsResponse OnsTrendTopicInputTps(OnsTrendTopicInputTpsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return OnsTrendTopicInputTpsWithOptions(request, runtime);
        }

        /**
          * ## Note
          * You can call this operation to query the statistics of messages that are published to a specified topic in the production environment. You can obtain the number of messages that are published to the topic or the transactions per second (TPS) for message publishing during each sampling period within a specified time range.
          * >  If your application publishes a small number of messages and does not publish messages at a specific interval, we recommend that you query the number of messages that are published to the topic during each sampling period because the statistics of TPS may not show a clear change trend.
          *
          * @param request OnsTrendTopicInputTpsRequest
          * @return OnsTrendTopicInputTpsResponse
         */
        public async Task<OnsTrendTopicInputTpsResponse> OnsTrendTopicInputTpsAsync(OnsTrendTopicInputTpsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await OnsTrendTopicInputTpsWithOptionsAsync(request, runtime);
        }

        /**
          * > : The API operations that are provided by Alibaba Cloud are used to manage and query resources of Alibaba Cloud services. We recommend that you integrate these API operations only in management systems. Do not use these API operations in the core system of messaging services. Otherwise, system risks may occur.
          * You can call this operation when you use Message Queue for Apache RocketMQ for the first time. You can use Message Queue for Apache RocketMQ only after this service is activated.
          * The Message Queue for Apache RocketMQ service can be activated only in the China (Hangzhou) region. Service activation is not billed.
          *
          * @param request OpenOnsServiceRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return OpenOnsServiceResponse
         */
        public OpenOnsServiceResponse OpenOnsServiceWithOptions(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "OpenOnsService",
                Version = "2019-02-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<OpenOnsServiceResponse>(CallApi(params_, req, runtime));
        }

        /**
          * > : The API operations that are provided by Alibaba Cloud are used to manage and query resources of Alibaba Cloud services. We recommend that you integrate these API operations only in management systems. Do not use these API operations in the core system of messaging services. Otherwise, system risks may occur.
          * You can call this operation when you use Message Queue for Apache RocketMQ for the first time. You can use Message Queue for Apache RocketMQ only after this service is activated.
          * The Message Queue for Apache RocketMQ service can be activated only in the China (Hangzhou) region. Service activation is not billed.
          *
          * @param request OpenOnsServiceRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return OpenOnsServiceResponse
         */
        public async Task<OpenOnsServiceResponse> OpenOnsServiceWithOptionsAsync(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "OpenOnsService",
                Version = "2019-02-14",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<OpenOnsServiceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * > : The API operations that are provided by Alibaba Cloud are used to manage and query resources of Alibaba Cloud services. We recommend that you integrate these API operations only in management systems. Do not use these API operations in the core system of messaging services. Otherwise, system risks may occur.
          * You can call this operation when you use Message Queue for Apache RocketMQ for the first time. You can use Message Queue for Apache RocketMQ only after this service is activated.
          * The Message Queue for Apache RocketMQ service can be activated only in the China (Hangzhou) region. Service activation is not billed.
          *
          * @return OpenOnsServiceResponse
         */
        public OpenOnsServiceResponse OpenOnsService()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return OpenOnsServiceWithOptions(runtime);
        }

        /**
          * > : The API operations that are provided by Alibaba Cloud are used to manage and query resources of Alibaba Cloud services. We recommend that you integrate these API operations only in management systems. Do not use these API operations in the core system of messaging services. Otherwise, system risks may occur.
          * You can call this operation when you use Message Queue for Apache RocketMQ for the first time. You can use Message Queue for Apache RocketMQ only after this service is activated.
          * The Message Queue for Apache RocketMQ service can be activated only in the China (Hangzhou) region. Service activation is not billed.
          *
          * @return OpenOnsServiceResponse
         */
        public async Task<OpenOnsServiceResponse> OpenOnsServiceAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await OpenOnsServiceWithOptionsAsync(runtime);
        }

        /**
          * > : The API operations that are provided by Alibaba Cloud are used to manage and query resources of Alibaba Cloud services. We recommend that you integrate these API operations only in management systems. Do not use these API operations in the core system of messaging services. Otherwise, system risks may occur.
          * You can call this operation to attach tags to a source. You can use tags to classify resources in Message Queue for Apache RocketMQ. This can help you aggregate and search resources in an efficient manner.
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
                Version = "2019-02-14",
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
          * > : The API operations that are provided by Alibaba Cloud are used to manage and query resources of Alibaba Cloud services. We recommend that you integrate these API operations only in management systems. Do not use these API operations in the core system of messaging services. Otherwise, system risks may occur.
          * You can call this operation to attach tags to a source. You can use tags to classify resources in Message Queue for Apache RocketMQ. This can help you aggregate and search resources in an efficient manner.
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
                Version = "2019-02-14",
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
          * > : The API operations that are provided by Alibaba Cloud are used to manage and query resources of Alibaba Cloud services. We recommend that you integrate these API operations only in management systems. Do not use these API operations in the core system of messaging services. Otherwise, system risks may occur.
          * You can call this operation to attach tags to a source. You can use tags to classify resources in Message Queue for Apache RocketMQ. This can help you aggregate and search resources in an efficient manner.
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
          * > : The API operations that are provided by Alibaba Cloud are used to manage and query resources of Alibaba Cloud services. We recommend that you integrate these API operations only in management systems. Do not use these API operations in the core system of messaging services. Otherwise, system risks may occur.
          * You can call this operation to attach tags to a source. You can use tags to classify resources in Message Queue for Apache RocketMQ. This can help you aggregate and search resources in an efficient manner.
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
          * > : The API operations that are provided by Alibaba Cloud are used to manage and query resources of Alibaba Cloud services. We recommend that you integrate these API operations only in management systems. Do not use these API operations in the core system of messaging services. Otherwise, system risks may occur.
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
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
                Version = "2019-02-14",
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
          * > : The API operations that are provided by Alibaba Cloud are used to manage and query resources of Alibaba Cloud services. We recommend that you integrate these API operations only in management systems. Do not use these API operations in the core system of messaging services. Otherwise, system risks may occur.
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
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
                Version = "2019-02-14",
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
          * > : The API operations that are provided by Alibaba Cloud are used to manage and query resources of Alibaba Cloud services. We recommend that you integrate these API operations only in management systems. Do not use these API operations in the core system of messaging services. Otherwise, system risks may occur.
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
          * > : The API operations that are provided by Alibaba Cloud are used to manage and query resources of Alibaba Cloud services. We recommend that you integrate these API operations only in management systems. Do not use these API operations in the core system of messaging services. Otherwise, system risks may occur.
          *
          * @param request UntagResourcesRequest
          * @return UntagResourcesResponse
         */
        public async Task<UntagResourcesResponse> UntagResourcesAsync(UntagResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UntagResourcesWithOptionsAsync(request, runtime);
        }

    }
}
