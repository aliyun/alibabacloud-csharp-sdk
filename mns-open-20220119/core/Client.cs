// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Mns_open20220119.Models;

namespace AlibabaCloud.SDK.Mns_open20220119
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "regional";
            CheckConfig(config);
            this._endpoint = GetEndpoint("mns-open", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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
         * @summary CreateQueue
         *
         * @param request CreateQueueRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateQueueResponse
         */
        public CreateQueueResponse CreateQueueWithOptions(CreateQueueRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DelaySeconds))
            {
                query["DelaySeconds"] = request.DelaySeconds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableLogging))
            {
                query["EnableLogging"] = request.EnableLogging;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaximumMessageSize))
            {
                query["MaximumMessageSize"] = request.MaximumMessageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MessageRetentionPeriod))
            {
                query["MessageRetentionPeriod"] = request.MessageRetentionPeriod;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PollingWaitSeconds))
            {
                query["PollingWaitSeconds"] = request.PollingWaitSeconds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueueName))
            {
                query["QueueName"] = request.QueueName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                query["Tag"] = request.Tag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VisibilityTimeout))
            {
                query["VisibilityTimeout"] = request.VisibilityTimeout;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateQueue",
                Version = "2022-01-19",
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
         * @summary CreateQueue
         *
         * @param request CreateQueueRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateQueueResponse
         */
        public async Task<CreateQueueResponse> CreateQueueWithOptionsAsync(CreateQueueRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DelaySeconds))
            {
                query["DelaySeconds"] = request.DelaySeconds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableLogging))
            {
                query["EnableLogging"] = request.EnableLogging;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaximumMessageSize))
            {
                query["MaximumMessageSize"] = request.MaximumMessageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MessageRetentionPeriod))
            {
                query["MessageRetentionPeriod"] = request.MessageRetentionPeriod;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PollingWaitSeconds))
            {
                query["PollingWaitSeconds"] = request.PollingWaitSeconds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueueName))
            {
                query["QueueName"] = request.QueueName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                query["Tag"] = request.Tag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VisibilityTimeout))
            {
                query["VisibilityTimeout"] = request.VisibilityTimeout;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateQueue",
                Version = "2022-01-19",
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
         * @summary CreateQueue
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
         * @summary CreateQueue
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
         * @summary CreateTopic
         *
         * @param request CreateTopicRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateTopicResponse
         */
        public CreateTopicResponse CreateTopicWithOptions(CreateTopicRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                query["Tag"] = request.Tag;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableLogging))
            {
                body["EnableLogging"] = request.EnableLogging;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxMessageSize))
            {
                body["MaxMessageSize"] = request.MaxMessageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TopicName))
            {
                body["TopicName"] = request.TopicName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateTopic",
                Version = "2022-01-19",
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
         * @summary CreateTopic
         *
         * @param request CreateTopicRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateTopicResponse
         */
        public async Task<CreateTopicResponse> CreateTopicWithOptionsAsync(CreateTopicRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                query["Tag"] = request.Tag;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableLogging))
            {
                body["EnableLogging"] = request.EnableLogging;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxMessageSize))
            {
                body["MaxMessageSize"] = request.MaxMessageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TopicName))
            {
                body["TopicName"] = request.TopicName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateTopic",
                Version = "2022-01-19",
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
         * @summary CreateTopic
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
         * @summary CreateTopic
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
         * @summary DeleteQueue
         *
         * @param request DeleteQueueRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteQueueResponse
         */
        public DeleteQueueResponse DeleteQueueWithOptions(DeleteQueueRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "DeleteQueue",
                Version = "2022-01-19",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteQueueResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary DeleteQueue
         *
         * @param request DeleteQueueRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteQueueResponse
         */
        public async Task<DeleteQueueResponse> DeleteQueueWithOptionsAsync(DeleteQueueRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
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
                Action = "DeleteQueue",
                Version = "2022-01-19",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteQueueResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary DeleteQueue
         *
         * @param request DeleteQueueRequest
         * @return DeleteQueueResponse
         */
        public DeleteQueueResponse DeleteQueue(DeleteQueueRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteQueueWithOptions(request, runtime);
        }

        /**
         * @summary DeleteQueue
         *
         * @param request DeleteQueueRequest
         * @return DeleteQueueResponse
         */
        public async Task<DeleteQueueResponse> DeleteQueueAsync(DeleteQueueRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteQueueWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 删除订阅主题
         *
         * @param request DeleteTopicRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteTopicResponse
         */
        public DeleteTopicResponse DeleteTopicWithOptions(DeleteTopicRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TopicName))
            {
                query["TopicName"] = request.TopicName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteTopic",
                Version = "2022-01-19",
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
         * @summary 删除订阅主题
         *
         * @param request DeleteTopicRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteTopicResponse
         */
        public async Task<DeleteTopicResponse> DeleteTopicWithOptionsAsync(DeleteTopicRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TopicName))
            {
                query["TopicName"] = request.TopicName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteTopic",
                Version = "2022-01-19",
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
         * @summary 删除订阅主题
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
         * @summary 删除订阅主题
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
         * @summary GetQueueAttributes
         *
         * @param request GetQueueAttributesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetQueueAttributesResponse
         */
        public GetQueueAttributesResponse GetQueueAttributesWithOptions(GetQueueAttributesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueueName))
            {
                query["QueueName"] = request.QueueName;
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
                Action = "GetQueueAttributes",
                Version = "2022-01-19",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetQueueAttributesResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary GetQueueAttributes
         *
         * @param request GetQueueAttributesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetQueueAttributesResponse
         */
        public async Task<GetQueueAttributesResponse> GetQueueAttributesWithOptionsAsync(GetQueueAttributesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueueName))
            {
                query["QueueName"] = request.QueueName;
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
                Action = "GetQueueAttributes",
                Version = "2022-01-19",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetQueueAttributesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary GetQueueAttributes
         *
         * @param request GetQueueAttributesRequest
         * @return GetQueueAttributesResponse
         */
        public GetQueueAttributesResponse GetQueueAttributes(GetQueueAttributesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetQueueAttributesWithOptions(request, runtime);
        }

        /**
         * @summary GetQueueAttributes
         *
         * @param request GetQueueAttributesRequest
         * @return GetQueueAttributesResponse
         */
        public async Task<GetQueueAttributesResponse> GetQueueAttributesAsync(GetQueueAttributesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetQueueAttributesWithOptionsAsync(request, runtime);
        }

        /**
         * @summary GetSubscription
         *
         * @param request GetSubscriptionAttributesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetSubscriptionAttributesResponse
         */
        public GetSubscriptionAttributesResponse GetSubscriptionAttributesWithOptions(GetSubscriptionAttributesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubscriptionName))
            {
                query["SubscriptionName"] = request.SubscriptionName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TopicName))
            {
                query["TopicName"] = request.TopicName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetSubscriptionAttributes",
                Version = "2022-01-19",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSubscriptionAttributesResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary GetSubscription
         *
         * @param request GetSubscriptionAttributesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetSubscriptionAttributesResponse
         */
        public async Task<GetSubscriptionAttributesResponse> GetSubscriptionAttributesWithOptionsAsync(GetSubscriptionAttributesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubscriptionName))
            {
                query["SubscriptionName"] = request.SubscriptionName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TopicName))
            {
                query["TopicName"] = request.TopicName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetSubscriptionAttributes",
                Version = "2022-01-19",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSubscriptionAttributesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary GetSubscription
         *
         * @param request GetSubscriptionAttributesRequest
         * @return GetSubscriptionAttributesResponse
         */
        public GetSubscriptionAttributesResponse GetSubscriptionAttributes(GetSubscriptionAttributesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetSubscriptionAttributesWithOptions(request, runtime);
        }

        /**
         * @summary GetSubscription
         *
         * @param request GetSubscriptionAttributesRequest
         * @return GetSubscriptionAttributesResponse
         */
        public async Task<GetSubscriptionAttributesResponse> GetSubscriptionAttributesAsync(GetSubscriptionAttributesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetSubscriptionAttributesWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 查询主题
         *
         * @param request GetTopicAttributesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetTopicAttributesResponse
         */
        public GetTopicAttributesResponse GetTopicAttributesWithOptions(GetTopicAttributesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                query["Tag"] = request.Tag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TopicName))
            {
                query["TopicName"] = request.TopicName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetTopicAttributes",
                Version = "2022-01-19",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTopicAttributesResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 查询主题
         *
         * @param request GetTopicAttributesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetTopicAttributesResponse
         */
        public async Task<GetTopicAttributesResponse> GetTopicAttributesWithOptionsAsync(GetTopicAttributesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                query["Tag"] = request.Tag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TopicName))
            {
                query["TopicName"] = request.TopicName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetTopicAttributes",
                Version = "2022-01-19",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTopicAttributesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 查询主题
         *
         * @param request GetTopicAttributesRequest
         * @return GetTopicAttributesResponse
         */
        public GetTopicAttributesResponse GetTopicAttributes(GetTopicAttributesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetTopicAttributesWithOptions(request, runtime);
        }

        /**
         * @summary 查询主题
         *
         * @param request GetTopicAttributesRequest
         * @return GetTopicAttributesResponse
         */
        public async Task<GetTopicAttributesResponse> GetTopicAttributesAsync(GetTopicAttributesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetTopicAttributesWithOptionsAsync(request, runtime);
        }

        /**
         * @summary ListQueue
         *
         * @param request ListQueueRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListQueueResponse
         */
        public ListQueueResponse ListQueueWithOptions(ListQueueRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNum))
            {
                query["PageNum"] = request.PageNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueueName))
            {
                query["QueueName"] = request.QueueName;
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
                Action = "ListQueue",
                Version = "2022-01-19",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListQueueResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary ListQueue
         *
         * @param request ListQueueRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListQueueResponse
         */
        public async Task<ListQueueResponse> ListQueueWithOptionsAsync(ListQueueRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNum))
            {
                query["PageNum"] = request.PageNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueueName))
            {
                query["QueueName"] = request.QueueName;
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
                Action = "ListQueue",
                Version = "2022-01-19",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListQueueResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary ListQueue
         *
         * @param request ListQueueRequest
         * @return ListQueueResponse
         */
        public ListQueueResponse ListQueue(ListQueueRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListQueueWithOptions(request, runtime);
        }

        /**
         * @summary ListQueue
         *
         * @param request ListQueueRequest
         * @return ListQueueResponse
         */
        public async Task<ListQueueResponse> ListQueueAsync(ListQueueRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListQueueWithOptionsAsync(request, runtime);
        }

        /**
         * @summary ListSubscription
         *
         * @param request ListSubscriptionByTopicRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListSubscriptionByTopicResponse
         */
        public ListSubscriptionByTopicResponse ListSubscriptionByTopicWithOptions(ListSubscriptionByTopicRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNum))
            {
                query["PageNum"] = request.PageNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubscriptionName))
            {
                query["SubscriptionName"] = request.SubscriptionName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TopicName))
            {
                query["TopicName"] = request.TopicName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListSubscriptionByTopic",
                Version = "2022-01-19",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListSubscriptionByTopicResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary ListSubscription
         *
         * @param request ListSubscriptionByTopicRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListSubscriptionByTopicResponse
         */
        public async Task<ListSubscriptionByTopicResponse> ListSubscriptionByTopicWithOptionsAsync(ListSubscriptionByTopicRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNum))
            {
                query["PageNum"] = request.PageNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubscriptionName))
            {
                query["SubscriptionName"] = request.SubscriptionName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TopicName))
            {
                query["TopicName"] = request.TopicName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListSubscriptionByTopic",
                Version = "2022-01-19",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListSubscriptionByTopicResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary ListSubscription
         *
         * @param request ListSubscriptionByTopicRequest
         * @return ListSubscriptionByTopicResponse
         */
        public ListSubscriptionByTopicResponse ListSubscriptionByTopic(ListSubscriptionByTopicRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListSubscriptionByTopicWithOptions(request, runtime);
        }

        /**
         * @summary ListSubscription
         *
         * @param request ListSubscriptionByTopicRequest
         * @return ListSubscriptionByTopicResponse
         */
        public async Task<ListSubscriptionByTopicResponse> ListSubscriptionByTopicAsync(ListSubscriptionByTopicRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListSubscriptionByTopicWithOptionsAsync(request, runtime);
        }

        /**
         * @summary ListTopic
         *
         * @param request ListTopicRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListTopicResponse
         */
        public ListTopicResponse ListTopicWithOptions(ListTopicRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNum))
            {
                query["PageNum"] = request.PageNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                query["Tag"] = request.Tag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TopicName))
            {
                query["TopicName"] = request.TopicName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTopic",
                Version = "2022-01-19",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTopicResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary ListTopic
         *
         * @param request ListTopicRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListTopicResponse
         */
        public async Task<ListTopicResponse> ListTopicWithOptionsAsync(ListTopicRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNum))
            {
                query["PageNum"] = request.PageNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tag))
            {
                query["Tag"] = request.Tag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TopicName))
            {
                query["TopicName"] = request.TopicName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTopic",
                Version = "2022-01-19",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTopicResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary ListTopic
         *
         * @param request ListTopicRequest
         * @return ListTopicResponse
         */
        public ListTopicResponse ListTopic(ListTopicRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListTopicWithOptions(request, runtime);
        }

        /**
         * @summary ListTopic
         *
         * @param request ListTopicRequest
         * @return ListTopicResponse
         */
        public async Task<ListTopicResponse> ListTopicAsync(ListTopicRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListTopicWithOptionsAsync(request, runtime);
        }

        /**
         * @summary SetQueueAttributes
         *
         * @param request SetQueueAttributesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SetQueueAttributesResponse
         */
        public SetQueueAttributesResponse SetQueueAttributesWithOptions(SetQueueAttributesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DelaySeconds))
            {
                query["DelaySeconds"] = request.DelaySeconds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableLogging))
            {
                query["EnableLogging"] = request.EnableLogging;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaximumMessageSize))
            {
                query["MaximumMessageSize"] = request.MaximumMessageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MessageRetentionPeriod))
            {
                query["MessageRetentionPeriod"] = request.MessageRetentionPeriod;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PollingWaitSeconds))
            {
                query["PollingWaitSeconds"] = request.PollingWaitSeconds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueueName))
            {
                query["QueueName"] = request.QueueName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VisibilityTimeout))
            {
                query["VisibilityTimeout"] = request.VisibilityTimeout;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SetQueueAttributes",
                Version = "2022-01-19",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetQueueAttributesResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary SetQueueAttributes
         *
         * @param request SetQueueAttributesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SetQueueAttributesResponse
         */
        public async Task<SetQueueAttributesResponse> SetQueueAttributesWithOptionsAsync(SetQueueAttributesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DelaySeconds))
            {
                query["DelaySeconds"] = request.DelaySeconds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableLogging))
            {
                query["EnableLogging"] = request.EnableLogging;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaximumMessageSize))
            {
                query["MaximumMessageSize"] = request.MaximumMessageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MessageRetentionPeriod))
            {
                query["MessageRetentionPeriod"] = request.MessageRetentionPeriod;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PollingWaitSeconds))
            {
                query["PollingWaitSeconds"] = request.PollingWaitSeconds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueueName))
            {
                query["QueueName"] = request.QueueName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VisibilityTimeout))
            {
                query["VisibilityTimeout"] = request.VisibilityTimeout;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SetQueueAttributes",
                Version = "2022-01-19",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetQueueAttributesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary SetQueueAttributes
         *
         * @param request SetQueueAttributesRequest
         * @return SetQueueAttributesResponse
         */
        public SetQueueAttributesResponse SetQueueAttributes(SetQueueAttributesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetQueueAttributesWithOptions(request, runtime);
        }

        /**
         * @summary SetQueueAttributes
         *
         * @param request SetQueueAttributesRequest
         * @return SetQueueAttributesResponse
         */
        public async Task<SetQueueAttributesResponse> SetQueueAttributesAsync(SetQueueAttributesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetQueueAttributesWithOptionsAsync(request, runtime);
        }

        /**
         * @summary ModifySubscription
         *
         * @param request SetSubscriptionAttributesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SetSubscriptionAttributesResponse
         */
        public SetSubscriptionAttributesResponse SetSubscriptionAttributesWithOptions(SetSubscriptionAttributesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NotifyStrategy))
            {
                query["NotifyStrategy"] = request.NotifyStrategy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubscriptionName))
            {
                query["SubscriptionName"] = request.SubscriptionName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TopicName))
            {
                query["TopicName"] = request.TopicName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SetSubscriptionAttributes",
                Version = "2022-01-19",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetSubscriptionAttributesResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary ModifySubscription
         *
         * @param request SetSubscriptionAttributesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SetSubscriptionAttributesResponse
         */
        public async Task<SetSubscriptionAttributesResponse> SetSubscriptionAttributesWithOptionsAsync(SetSubscriptionAttributesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NotifyStrategy))
            {
                query["NotifyStrategy"] = request.NotifyStrategy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubscriptionName))
            {
                query["SubscriptionName"] = request.SubscriptionName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TopicName))
            {
                query["TopicName"] = request.TopicName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SetSubscriptionAttributes",
                Version = "2022-01-19",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetSubscriptionAttributesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary ModifySubscription
         *
         * @param request SetSubscriptionAttributesRequest
         * @return SetSubscriptionAttributesResponse
         */
        public SetSubscriptionAttributesResponse SetSubscriptionAttributes(SetSubscriptionAttributesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetSubscriptionAttributesWithOptions(request, runtime);
        }

        /**
         * @summary ModifySubscription
         *
         * @param request SetSubscriptionAttributesRequest
         * @return SetSubscriptionAttributesResponse
         */
        public async Task<SetSubscriptionAttributesResponse> SetSubscriptionAttributesAsync(SetSubscriptionAttributesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetSubscriptionAttributesWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 编辑订阅主题
         *
         * @param request SetTopicAttributesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SetTopicAttributesResponse
         */
        public SetTopicAttributesResponse SetTopicAttributesWithOptions(SetTopicAttributesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableLogging))
            {
                query["EnableLogging"] = request.EnableLogging;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxMessageSize))
            {
                query["MaxMessageSize"] = request.MaxMessageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TopicName))
            {
                query["TopicName"] = request.TopicName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SetTopicAttributes",
                Version = "2022-01-19",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetTopicAttributesResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 编辑订阅主题
         *
         * @param request SetTopicAttributesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SetTopicAttributesResponse
         */
        public async Task<SetTopicAttributesResponse> SetTopicAttributesWithOptionsAsync(SetTopicAttributesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableLogging))
            {
                query["EnableLogging"] = request.EnableLogging;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxMessageSize))
            {
                query["MaxMessageSize"] = request.MaxMessageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TopicName))
            {
                query["TopicName"] = request.TopicName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SetTopicAttributes",
                Version = "2022-01-19",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SetTopicAttributesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 编辑订阅主题
         *
         * @param request SetTopicAttributesRequest
         * @return SetTopicAttributesResponse
         */
        public SetTopicAttributesResponse SetTopicAttributes(SetTopicAttributesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetTopicAttributesWithOptions(request, runtime);
        }

        /**
         * @summary 编辑订阅主题
         *
         * @param request SetTopicAttributesRequest
         * @return SetTopicAttributesResponse
         */
        public async Task<SetTopicAttributesResponse> SetTopicAttributesAsync(SetTopicAttributesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetTopicAttributesWithOptionsAsync(request, runtime);
        }

        /**
         * @summary CreateSubscription
         *
         * @param request SubscribeRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SubscribeResponse
         */
        public SubscribeResponse SubscribeWithOptions(SubscribeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Endpoint))
            {
                query["Endpoint"] = request.Endpoint;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MessageTag))
            {
                query["MessageTag"] = request.MessageTag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NotifyContentFormat))
            {
                query["NotifyContentFormat"] = request.NotifyContentFormat;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NotifyStrategy))
            {
                query["NotifyStrategy"] = request.NotifyStrategy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PushType))
            {
                query["PushType"] = request.PushType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubscriptionName))
            {
                query["SubscriptionName"] = request.SubscriptionName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TopicName))
            {
                query["TopicName"] = request.TopicName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "Subscribe",
                Version = "2022-01-19",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SubscribeResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary CreateSubscription
         *
         * @param request SubscribeRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return SubscribeResponse
         */
        public async Task<SubscribeResponse> SubscribeWithOptionsAsync(SubscribeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Endpoint))
            {
                query["Endpoint"] = request.Endpoint;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MessageTag))
            {
                query["MessageTag"] = request.MessageTag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NotifyContentFormat))
            {
                query["NotifyContentFormat"] = request.NotifyContentFormat;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NotifyStrategy))
            {
                query["NotifyStrategy"] = request.NotifyStrategy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PushType))
            {
                query["PushType"] = request.PushType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubscriptionName))
            {
                query["SubscriptionName"] = request.SubscriptionName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TopicName))
            {
                query["TopicName"] = request.TopicName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "Subscribe",
                Version = "2022-01-19",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SubscribeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary CreateSubscription
         *
         * @param request SubscribeRequest
         * @return SubscribeResponse
         */
        public SubscribeResponse Subscribe(SubscribeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SubscribeWithOptions(request, runtime);
        }

        /**
         * @summary CreateSubscription
         *
         * @param request SubscribeRequest
         * @return SubscribeResponse
         */
        public async Task<SubscribeResponse> SubscribeAsync(SubscribeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SubscribeWithOptionsAsync(request, runtime);
        }

        /**
         * @summary DeleteSubscription
         *
         * @param request UnsubscribeRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UnsubscribeResponse
         */
        public UnsubscribeResponse UnsubscribeWithOptions(UnsubscribeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubscriptionName))
            {
                query["SubscriptionName"] = request.SubscriptionName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TopicName))
            {
                query["TopicName"] = request.TopicName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "Unsubscribe",
                Version = "2022-01-19",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UnsubscribeResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary DeleteSubscription
         *
         * @param request UnsubscribeRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UnsubscribeResponse
         */
        public async Task<UnsubscribeResponse> UnsubscribeWithOptionsAsync(UnsubscribeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubscriptionName))
            {
                query["SubscriptionName"] = request.SubscriptionName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TopicName))
            {
                query["TopicName"] = request.TopicName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "Unsubscribe",
                Version = "2022-01-19",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UnsubscribeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary DeleteSubscription
         *
         * @param request UnsubscribeRequest
         * @return UnsubscribeResponse
         */
        public UnsubscribeResponse Unsubscribe(UnsubscribeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UnsubscribeWithOptions(request, runtime);
        }

        /**
         * @summary DeleteSubscription
         *
         * @param request UnsubscribeRequest
         * @return UnsubscribeResponse
         */
        public async Task<UnsubscribeResponse> UnsubscribeAsync(UnsubscribeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UnsubscribeWithOptionsAsync(request, runtime);
        }

    }
}
