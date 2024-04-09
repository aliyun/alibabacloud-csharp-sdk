// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Eventbridge20200401.Models;

namespace AlibabaCloud.SDK.Eventbridge20200401
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "";
            CheckConfig(config);
            this._endpoint = GetEndpoint("eventbridge", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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
          * You can call this API operation to create an API destination.
          *
          * @param tmpReq CreateApiDestinationRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return CreateApiDestinationResponse
         */
        public CreateApiDestinationResponse CreateApiDestinationWithOptions(CreateApiDestinationRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateApiDestinationShrinkRequest request = new CreateApiDestinationShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.HttpApiParameters))
            {
                request.HttpApiParametersShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.HttpApiParameters, "HttpApiParameters", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApiDestinationName))
            {
                query["ApiDestinationName"] = request.ApiDestinationName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConnectionName))
            {
                query["ConnectionName"] = request.ConnectionName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HttpApiParametersShrink))
            {
                query["HttpApiParameters"] = request.HttpApiParametersShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateApiDestination",
                Version = "2020-04-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateApiDestinationResponse>(CallApi(params_, req, runtime));
        }

        /**
          * You can call this API operation to create an API destination.
          *
          * @param tmpReq CreateApiDestinationRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return CreateApiDestinationResponse
         */
        public async Task<CreateApiDestinationResponse> CreateApiDestinationWithOptionsAsync(CreateApiDestinationRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateApiDestinationShrinkRequest request = new CreateApiDestinationShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.HttpApiParameters))
            {
                request.HttpApiParametersShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.HttpApiParameters, "HttpApiParameters", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApiDestinationName))
            {
                query["ApiDestinationName"] = request.ApiDestinationName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConnectionName))
            {
                query["ConnectionName"] = request.ConnectionName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HttpApiParametersShrink))
            {
                query["HttpApiParameters"] = request.HttpApiParametersShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateApiDestination",
                Version = "2020-04-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateApiDestinationResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * You can call this API operation to create an API destination.
          *
          * @param request CreateApiDestinationRequest
          * @return CreateApiDestinationResponse
         */
        public CreateApiDestinationResponse CreateApiDestination(CreateApiDestinationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateApiDestinationWithOptions(request, runtime);
        }

        /**
          * You can call this API operation to create an API destination.
          *
          * @param request CreateApiDestinationRequest
          * @return CreateApiDestinationResponse
         */
        public async Task<CreateApiDestinationResponse> CreateApiDestinationAsync(CreateApiDestinationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateApiDestinationWithOptionsAsync(request, runtime);
        }

        /**
          * You can call this API operation to create a connection.
          *
          * @param tmpReq CreateConnectionRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return CreateConnectionResponse
         */
        public CreateConnectionResponse CreateConnectionWithOptions(CreateConnectionRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateConnectionShrinkRequest request = new CreateConnectionShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.AuthParameters))
            {
                request.AuthParametersShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.AuthParameters, "AuthParameters", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.NetworkParameters))
            {
                request.NetworkParametersShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.NetworkParameters, "NetworkParameters", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthParametersShrink))
            {
                query["AuthParameters"] = request.AuthParametersShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConnectionName))
            {
                query["ConnectionName"] = request.ConnectionName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NetworkParametersShrink))
            {
                query["NetworkParameters"] = request.NetworkParametersShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateConnection",
                Version = "2020-04-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateConnectionResponse>(CallApi(params_, req, runtime));
        }

        /**
          * You can call this API operation to create a connection.
          *
          * @param tmpReq CreateConnectionRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return CreateConnectionResponse
         */
        public async Task<CreateConnectionResponse> CreateConnectionWithOptionsAsync(CreateConnectionRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateConnectionShrinkRequest request = new CreateConnectionShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.AuthParameters))
            {
                request.AuthParametersShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.AuthParameters, "AuthParameters", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.NetworkParameters))
            {
                request.NetworkParametersShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.NetworkParameters, "NetworkParameters", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthParametersShrink))
            {
                query["AuthParameters"] = request.AuthParametersShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConnectionName))
            {
                query["ConnectionName"] = request.ConnectionName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NetworkParametersShrink))
            {
                query["NetworkParameters"] = request.NetworkParametersShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateConnection",
                Version = "2020-04-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateConnectionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * You can call this API operation to create a connection.
          *
          * @param request CreateConnectionRequest
          * @return CreateConnectionResponse
         */
        public CreateConnectionResponse CreateConnection(CreateConnectionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateConnectionWithOptions(request, runtime);
        }

        /**
          * You can call this API operation to create a connection.
          *
          * @param request CreateConnectionRequest
          * @return CreateConnectionResponse
         */
        public async Task<CreateConnectionResponse> CreateConnectionAsync(CreateConnectionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateConnectionWithOptionsAsync(request, runtime);
        }

        /**
          * You can call this API operation to create an event bus.
          *
          * @param request CreateEventBusRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return CreateEventBusResponse
         */
        public CreateEventBusResponse CreateEventBusWithOptions(CreateEventBusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventBusName))
            {
                query["EventBusName"] = request.EventBusName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateEventBus",
                Version = "2020-04-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateEventBusResponse>(CallApi(params_, req, runtime));
        }

        /**
          * You can call this API operation to create an event bus.
          *
          * @param request CreateEventBusRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return CreateEventBusResponse
         */
        public async Task<CreateEventBusResponse> CreateEventBusWithOptionsAsync(CreateEventBusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventBusName))
            {
                query["EventBusName"] = request.EventBusName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateEventBus",
                Version = "2020-04-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateEventBusResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * You can call this API operation to create an event bus.
          *
          * @param request CreateEventBusRequest
          * @return CreateEventBusResponse
         */
        public CreateEventBusResponse CreateEventBus(CreateEventBusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateEventBusWithOptions(request, runtime);
        }

        /**
          * You can call this API operation to create an event bus.
          *
          * @param request CreateEventBusRequest
          * @return CreateEventBusResponse
         */
        public async Task<CreateEventBusResponse> CreateEventBusAsync(CreateEventBusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateEventBusWithOptionsAsync(request, runtime);
        }

        /**
          * You can call this operation to create an event source.
          *
          * @param tmpReq CreateEventSourceRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return CreateEventSourceResponse
         */
        public CreateEventSourceResponse CreateEventSourceWithOptions(CreateEventSourceRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateEventSourceShrinkRequest request = new CreateEventSourceShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SourceHttpEventParameters))
            {
                request.SourceHttpEventParametersShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SourceHttpEventParameters, "SourceHttpEventParameters", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SourceKafkaParameters))
            {
                request.SourceKafkaParametersShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SourceKafkaParameters, "SourceKafkaParameters", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SourceMNSParameters))
            {
                request.SourceMNSParametersShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SourceMNSParameters, "SourceMNSParameters", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SourceRabbitMQParameters))
            {
                request.SourceRabbitMQParametersShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SourceRabbitMQParameters, "SourceRabbitMQParameters", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SourceRocketMQParameters))
            {
                request.SourceRocketMQParametersShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SourceRocketMQParameters, "SourceRocketMQParameters", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SourceSLSParameters))
            {
                request.SourceSLSParametersShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SourceSLSParameters, "SourceSLSParameters", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SourceScheduledEventParameters))
            {
                request.SourceScheduledEventParametersShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SourceScheduledEventParameters, "SourceScheduledEventParameters", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventBusName))
            {
                body["EventBusName"] = request.EventBusName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventSourceName))
            {
                body["EventSourceName"] = request.EventSourceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceHttpEventParametersShrink))
            {
                body["SourceHttpEventParameters"] = request.SourceHttpEventParametersShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceKafkaParametersShrink))
            {
                body["SourceKafkaParameters"] = request.SourceKafkaParametersShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceMNSParametersShrink))
            {
                body["SourceMNSParameters"] = request.SourceMNSParametersShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceRabbitMQParametersShrink))
            {
                body["SourceRabbitMQParameters"] = request.SourceRabbitMQParametersShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceRocketMQParametersShrink))
            {
                body["SourceRocketMQParameters"] = request.SourceRocketMQParametersShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceSLSParametersShrink))
            {
                body["SourceSLSParameters"] = request.SourceSLSParametersShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceScheduledEventParametersShrink))
            {
                body["SourceScheduledEventParameters"] = request.SourceScheduledEventParametersShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateEventSource",
                Version = "2020-04-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateEventSourceResponse>(CallApi(params_, req, runtime));
        }

        /**
          * You can call this operation to create an event source.
          *
          * @param tmpReq CreateEventSourceRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return CreateEventSourceResponse
         */
        public async Task<CreateEventSourceResponse> CreateEventSourceWithOptionsAsync(CreateEventSourceRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateEventSourceShrinkRequest request = new CreateEventSourceShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SourceHttpEventParameters))
            {
                request.SourceHttpEventParametersShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SourceHttpEventParameters, "SourceHttpEventParameters", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SourceKafkaParameters))
            {
                request.SourceKafkaParametersShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SourceKafkaParameters, "SourceKafkaParameters", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SourceMNSParameters))
            {
                request.SourceMNSParametersShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SourceMNSParameters, "SourceMNSParameters", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SourceRabbitMQParameters))
            {
                request.SourceRabbitMQParametersShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SourceRabbitMQParameters, "SourceRabbitMQParameters", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SourceRocketMQParameters))
            {
                request.SourceRocketMQParametersShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SourceRocketMQParameters, "SourceRocketMQParameters", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SourceSLSParameters))
            {
                request.SourceSLSParametersShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SourceSLSParameters, "SourceSLSParameters", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SourceScheduledEventParameters))
            {
                request.SourceScheduledEventParametersShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SourceScheduledEventParameters, "SourceScheduledEventParameters", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventBusName))
            {
                body["EventBusName"] = request.EventBusName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventSourceName))
            {
                body["EventSourceName"] = request.EventSourceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceHttpEventParametersShrink))
            {
                body["SourceHttpEventParameters"] = request.SourceHttpEventParametersShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceKafkaParametersShrink))
            {
                body["SourceKafkaParameters"] = request.SourceKafkaParametersShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceMNSParametersShrink))
            {
                body["SourceMNSParameters"] = request.SourceMNSParametersShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceRabbitMQParametersShrink))
            {
                body["SourceRabbitMQParameters"] = request.SourceRabbitMQParametersShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceRocketMQParametersShrink))
            {
                body["SourceRocketMQParameters"] = request.SourceRocketMQParametersShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceSLSParametersShrink))
            {
                body["SourceSLSParameters"] = request.SourceSLSParametersShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceScheduledEventParametersShrink))
            {
                body["SourceScheduledEventParameters"] = request.SourceScheduledEventParametersShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateEventSource",
                Version = "2020-04-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateEventSourceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * You can call this operation to create an event source.
          *
          * @param request CreateEventSourceRequest
          * @return CreateEventSourceResponse
         */
        public CreateEventSourceResponse CreateEventSource(CreateEventSourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateEventSourceWithOptions(request, runtime);
        }

        /**
          * You can call this operation to create an event source.
          *
          * @param request CreateEventSourceRequest
          * @return CreateEventSourceResponse
         */
        public async Task<CreateEventSourceResponse> CreateEventSourceAsync(CreateEventSourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateEventSourceWithOptionsAsync(request, runtime);
        }

        /**
          * You can call this API operation to create an event stream.
          *
          * @param tmpReq CreateEventStreamingRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return CreateEventStreamingResponse
         */
        public CreateEventStreamingResponse CreateEventStreamingWithOptions(CreateEventStreamingRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateEventStreamingShrinkRequest request = new CreateEventStreamingShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.RunOptions))
            {
                request.RunOptionsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.RunOptions, "RunOptions", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Sink))
            {
                request.SinkShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Sink, "Sink", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Source))
            {
                request.SourceShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Source, "Source", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Transforms))
            {
                request.TransformsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Transforms, "Transforms", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventStreamingName))
            {
                body["EventStreamingName"] = request.EventStreamingName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FilterPattern))
            {
                body["FilterPattern"] = request.FilterPattern;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RunOptionsShrink))
            {
                body["RunOptions"] = request.RunOptionsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SinkShrink))
            {
                body["Sink"] = request.SinkShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceShrink))
            {
                body["Source"] = request.SourceShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransformsShrink))
            {
                body["Transforms"] = request.TransformsShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateEventStreaming",
                Version = "2020-04-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateEventStreamingResponse>(CallApi(params_, req, runtime));
        }

        /**
          * You can call this API operation to create an event stream.
          *
          * @param tmpReq CreateEventStreamingRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return CreateEventStreamingResponse
         */
        public async Task<CreateEventStreamingResponse> CreateEventStreamingWithOptionsAsync(CreateEventStreamingRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateEventStreamingShrinkRequest request = new CreateEventStreamingShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.RunOptions))
            {
                request.RunOptionsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.RunOptions, "RunOptions", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Sink))
            {
                request.SinkShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Sink, "Sink", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Source))
            {
                request.SourceShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Source, "Source", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Transforms))
            {
                request.TransformsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Transforms, "Transforms", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventStreamingName))
            {
                body["EventStreamingName"] = request.EventStreamingName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FilterPattern))
            {
                body["FilterPattern"] = request.FilterPattern;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RunOptionsShrink))
            {
                body["RunOptions"] = request.RunOptionsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SinkShrink))
            {
                body["Sink"] = request.SinkShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceShrink))
            {
                body["Source"] = request.SourceShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransformsShrink))
            {
                body["Transforms"] = request.TransformsShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateEventStreaming",
                Version = "2020-04-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateEventStreamingResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * You can call this API operation to create an event stream.
          *
          * @param request CreateEventStreamingRequest
          * @return CreateEventStreamingResponse
         */
        public CreateEventStreamingResponse CreateEventStreaming(CreateEventStreamingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateEventStreamingWithOptions(request, runtime);
        }

        /**
          * You can call this API operation to create an event stream.
          *
          * @param request CreateEventStreamingRequest
          * @return CreateEventStreamingResponse
         */
        public async Task<CreateEventStreamingResponse> CreateEventStreamingAsync(CreateEventStreamingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateEventStreamingWithOptionsAsync(request, runtime);
        }

        /**
          * You can call this API operation to create an event rule.
          *
          * @param tmpReq CreateRuleRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return CreateRuleResponse
         */
        public CreateRuleResponse CreateRuleWithOptions(CreateRuleRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateRuleShrinkRequest request = new CreateRuleShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.EventTargets))
            {
                request.EventTargetsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.EventTargets, "EventTargets", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventBusName))
            {
                query["EventBusName"] = request.EventBusName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventTargetsShrink))
            {
                query["EventTargets"] = request.EventTargetsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FilterPattern))
            {
                query["FilterPattern"] = request.FilterPattern;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleName))
            {
                query["RuleName"] = request.RuleName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateRule",
                Version = "2020-04-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateRuleResponse>(CallApi(params_, req, runtime));
        }

        /**
          * You can call this API operation to create an event rule.
          *
          * @param tmpReq CreateRuleRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return CreateRuleResponse
         */
        public async Task<CreateRuleResponse> CreateRuleWithOptionsAsync(CreateRuleRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateRuleShrinkRequest request = new CreateRuleShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.EventTargets))
            {
                request.EventTargetsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.EventTargets, "EventTargets", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventBusName))
            {
                query["EventBusName"] = request.EventBusName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventTargetsShrink))
            {
                query["EventTargets"] = request.EventTargetsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FilterPattern))
            {
                query["FilterPattern"] = request.FilterPattern;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleName))
            {
                query["RuleName"] = request.RuleName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateRule",
                Version = "2020-04-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateRuleResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * You can call this API operation to create an event rule.
          *
          * @param request CreateRuleRequest
          * @return CreateRuleResponse
         */
        public CreateRuleResponse CreateRule(CreateRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateRuleWithOptions(request, runtime);
        }

        /**
          * You can call this API operation to create an event rule.
          *
          * @param request CreateRuleRequest
          * @return CreateRuleResponse
         */
        public async Task<CreateRuleResponse> CreateRuleAsync(CreateRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateRuleWithOptionsAsync(request, runtime);
        }

        /**
          * You can call this API operation to create a service-linked role for your cloud service.
          *
          * @param request CreateServiceLinkedRoleForProductRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return CreateServiceLinkedRoleForProductResponse
         */
        public CreateServiceLinkedRoleForProductResponse CreateServiceLinkedRoleForProductWithOptions(CreateServiceLinkedRoleForProductRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductName))
            {
                query["ProductName"] = request.ProductName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateServiceLinkedRoleForProduct",
                Version = "2020-04-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateServiceLinkedRoleForProductResponse>(CallApi(params_, req, runtime));
        }

        /**
          * You can call this API operation to create a service-linked role for your cloud service.
          *
          * @param request CreateServiceLinkedRoleForProductRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return CreateServiceLinkedRoleForProductResponse
         */
        public async Task<CreateServiceLinkedRoleForProductResponse> CreateServiceLinkedRoleForProductWithOptionsAsync(CreateServiceLinkedRoleForProductRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductName))
            {
                query["ProductName"] = request.ProductName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateServiceLinkedRoleForProduct",
                Version = "2020-04-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateServiceLinkedRoleForProductResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * You can call this API operation to create a service-linked role for your cloud service.
          *
          * @param request CreateServiceLinkedRoleForProductRequest
          * @return CreateServiceLinkedRoleForProductResponse
         */
        public CreateServiceLinkedRoleForProductResponse CreateServiceLinkedRoleForProduct(CreateServiceLinkedRoleForProductRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateServiceLinkedRoleForProductWithOptions(request, runtime);
        }

        /**
          * You can call this API operation to create a service-linked role for your cloud service.
          *
          * @param request CreateServiceLinkedRoleForProductRequest
          * @return CreateServiceLinkedRoleForProductResponse
         */
        public async Task<CreateServiceLinkedRoleForProductResponse> CreateServiceLinkedRoleForProductAsync(CreateServiceLinkedRoleForProductRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateServiceLinkedRoleForProductWithOptionsAsync(request, runtime);
        }

        /**
          * You can call this API operation to delete an API destination.
          *
          * @param request DeleteApiDestinationRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DeleteApiDestinationResponse
         */
        public DeleteApiDestinationResponse DeleteApiDestinationWithOptions(DeleteApiDestinationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApiDestinationName))
            {
                query["ApiDestinationName"] = request.ApiDestinationName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteApiDestination",
                Version = "2020-04-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteApiDestinationResponse>(CallApi(params_, req, runtime));
        }

        /**
          * You can call this API operation to delete an API destination.
          *
          * @param request DeleteApiDestinationRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DeleteApiDestinationResponse
         */
        public async Task<DeleteApiDestinationResponse> DeleteApiDestinationWithOptionsAsync(DeleteApiDestinationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApiDestinationName))
            {
                query["ApiDestinationName"] = request.ApiDestinationName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteApiDestination",
                Version = "2020-04-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteApiDestinationResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * You can call this API operation to delete an API destination.
          *
          * @param request DeleteApiDestinationRequest
          * @return DeleteApiDestinationResponse
         */
        public DeleteApiDestinationResponse DeleteApiDestination(DeleteApiDestinationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteApiDestinationWithOptions(request, runtime);
        }

        /**
          * You can call this API operation to delete an API destination.
          *
          * @param request DeleteApiDestinationRequest
          * @return DeleteApiDestinationResponse
         */
        public async Task<DeleteApiDestinationResponse> DeleteApiDestinationAsync(DeleteApiDestinationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteApiDestinationWithOptionsAsync(request, runtime);
        }

        /**
          * You can call this API operation to delete a connection.
          *
          * @param request DeleteConnectionRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DeleteConnectionResponse
         */
        public DeleteConnectionResponse DeleteConnectionWithOptions(DeleteConnectionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConnectionName))
            {
                query["ConnectionName"] = request.ConnectionName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteConnection",
                Version = "2020-04-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteConnectionResponse>(CallApi(params_, req, runtime));
        }

        /**
          * You can call this API operation to delete a connection.
          *
          * @param request DeleteConnectionRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DeleteConnectionResponse
         */
        public async Task<DeleteConnectionResponse> DeleteConnectionWithOptionsAsync(DeleteConnectionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConnectionName))
            {
                query["ConnectionName"] = request.ConnectionName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteConnection",
                Version = "2020-04-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteConnectionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * You can call this API operation to delete a connection.
          *
          * @param request DeleteConnectionRequest
          * @return DeleteConnectionResponse
         */
        public DeleteConnectionResponse DeleteConnection(DeleteConnectionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteConnectionWithOptions(request, runtime);
        }

        /**
          * You can call this API operation to delete a connection.
          *
          * @param request DeleteConnectionRequest
          * @return DeleteConnectionResponse
         */
        public async Task<DeleteConnectionResponse> DeleteConnectionAsync(DeleteConnectionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteConnectionWithOptionsAsync(request, runtime);
        }

        /**
          * You can call this API operation to delete an event bus.
          *
          * @param request DeleteEventBusRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DeleteEventBusResponse
         */
        public DeleteEventBusResponse DeleteEventBusWithOptions(DeleteEventBusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventBusName))
            {
                query["EventBusName"] = request.EventBusName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteEventBus",
                Version = "2020-04-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteEventBusResponse>(CallApi(params_, req, runtime));
        }

        /**
          * You can call this API operation to delete an event bus.
          *
          * @param request DeleteEventBusRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DeleteEventBusResponse
         */
        public async Task<DeleteEventBusResponse> DeleteEventBusWithOptionsAsync(DeleteEventBusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventBusName))
            {
                query["EventBusName"] = request.EventBusName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteEventBus",
                Version = "2020-04-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteEventBusResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * You can call this API operation to delete an event bus.
          *
          * @param request DeleteEventBusRequest
          * @return DeleteEventBusResponse
         */
        public DeleteEventBusResponse DeleteEventBus(DeleteEventBusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteEventBusWithOptions(request, runtime);
        }

        /**
          * You can call this API operation to delete an event bus.
          *
          * @param request DeleteEventBusRequest
          * @return DeleteEventBusResponse
         */
        public async Task<DeleteEventBusResponse> DeleteEventBusAsync(DeleteEventBusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteEventBusWithOptionsAsync(request, runtime);
        }

        /**
          * You can call this API operation to delete an event source.
          *
          * @param request DeleteEventSourceRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DeleteEventSourceResponse
         */
        public DeleteEventSourceResponse DeleteEventSourceWithOptions(DeleteEventSourceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventBusName))
            {
                body["EventBusName"] = request.EventBusName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventSourceName))
            {
                body["EventSourceName"] = request.EventSourceName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteEventSource",
                Version = "2020-04-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteEventSourceResponse>(CallApi(params_, req, runtime));
        }

        /**
          * You can call this API operation to delete an event source.
          *
          * @param request DeleteEventSourceRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DeleteEventSourceResponse
         */
        public async Task<DeleteEventSourceResponse> DeleteEventSourceWithOptionsAsync(DeleteEventSourceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventBusName))
            {
                body["EventBusName"] = request.EventBusName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventSourceName))
            {
                body["EventSourceName"] = request.EventSourceName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteEventSource",
                Version = "2020-04-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteEventSourceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * You can call this API operation to delete an event source.
          *
          * @param request DeleteEventSourceRequest
          * @return DeleteEventSourceResponse
         */
        public DeleteEventSourceResponse DeleteEventSource(DeleteEventSourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteEventSourceWithOptions(request, runtime);
        }

        /**
          * You can call this API operation to delete an event source.
          *
          * @param request DeleteEventSourceRequest
          * @return DeleteEventSourceResponse
         */
        public async Task<DeleteEventSourceResponse> DeleteEventSourceAsync(DeleteEventSourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteEventSourceWithOptionsAsync(request, runtime);
        }

        /**
          * You can call this API operation to delete an event stream.
          *
          * @param request DeleteEventStreamingRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DeleteEventStreamingResponse
         */
        public DeleteEventStreamingResponse DeleteEventStreamingWithOptions(DeleteEventStreamingRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventStreamingName))
            {
                body["EventStreamingName"] = request.EventStreamingName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteEventStreaming",
                Version = "2020-04-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteEventStreamingResponse>(CallApi(params_, req, runtime));
        }

        /**
          * You can call this API operation to delete an event stream.
          *
          * @param request DeleteEventStreamingRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DeleteEventStreamingResponse
         */
        public async Task<DeleteEventStreamingResponse> DeleteEventStreamingWithOptionsAsync(DeleteEventStreamingRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventStreamingName))
            {
                body["EventStreamingName"] = request.EventStreamingName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteEventStreaming",
                Version = "2020-04-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteEventStreamingResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * You can call this API operation to delete an event stream.
          *
          * @param request DeleteEventStreamingRequest
          * @return DeleteEventStreamingResponse
         */
        public DeleteEventStreamingResponse DeleteEventStreaming(DeleteEventStreamingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteEventStreamingWithOptions(request, runtime);
        }

        /**
          * You can call this API operation to delete an event stream.
          *
          * @param request DeleteEventStreamingRequest
          * @return DeleteEventStreamingResponse
         */
        public async Task<DeleteEventStreamingResponse> DeleteEventStreamingAsync(DeleteEventStreamingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteEventStreamingWithOptionsAsync(request, runtime);
        }

        /**
          * You can call this API operation to delete an event rule.
          *
          * @param request DeleteRuleRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DeleteRuleResponse
         */
        public DeleteRuleResponse DeleteRuleWithOptions(DeleteRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventBusName))
            {
                query["EventBusName"] = request.EventBusName;
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
                Action = "DeleteRule",
                Version = "2020-04-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteRuleResponse>(CallApi(params_, req, runtime));
        }

        /**
          * You can call this API operation to delete an event rule.
          *
          * @param request DeleteRuleRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DeleteRuleResponse
         */
        public async Task<DeleteRuleResponse> DeleteRuleWithOptionsAsync(DeleteRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventBusName))
            {
                query["EventBusName"] = request.EventBusName;
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
                Action = "DeleteRule",
                Version = "2020-04-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteRuleResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * You can call this API operation to delete an event rule.
          *
          * @param request DeleteRuleRequest
          * @return DeleteRuleResponse
         */
        public DeleteRuleResponse DeleteRule(DeleteRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteRuleWithOptions(request, runtime);
        }

        /**
          * You can call this API operation to delete an event rule.
          *
          * @param request DeleteRuleRequest
          * @return DeleteRuleResponse
         */
        public async Task<DeleteRuleResponse> DeleteRuleAsync(DeleteRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteRuleWithOptionsAsync(request, runtime);
        }

        /**
          * You can call this API operation to delete one or more event targets of an event rule.
          *
          * @param tmpReq DeleteTargetsRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DeleteTargetsResponse
         */
        public DeleteTargetsResponse DeleteTargetsWithOptions(DeleteTargetsRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DeleteTargetsShrinkRequest request = new DeleteTargetsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TargetIds))
            {
                request.TargetIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TargetIds, "TargetIds", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventBusName))
            {
                query["EventBusName"] = request.EventBusName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleName))
            {
                query["RuleName"] = request.RuleName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetIdsShrink))
            {
                query["TargetIds"] = request.TargetIdsShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteTargets",
                Version = "2020-04-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteTargetsResponse>(CallApi(params_, req, runtime));
        }

        /**
          * You can call this API operation to delete one or more event targets of an event rule.
          *
          * @param tmpReq DeleteTargetsRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DeleteTargetsResponse
         */
        public async Task<DeleteTargetsResponse> DeleteTargetsWithOptionsAsync(DeleteTargetsRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DeleteTargetsShrinkRequest request = new DeleteTargetsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TargetIds))
            {
                request.TargetIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TargetIds, "TargetIds", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventBusName))
            {
                query["EventBusName"] = request.EventBusName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleName))
            {
                query["RuleName"] = request.RuleName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetIdsShrink))
            {
                query["TargetIds"] = request.TargetIdsShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteTargets",
                Version = "2020-04-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteTargetsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * You can call this API operation to delete one or more event targets of an event rule.
          *
          * @param request DeleteTargetsRequest
          * @return DeleteTargetsResponse
         */
        public DeleteTargetsResponse DeleteTargets(DeleteTargetsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteTargetsWithOptions(request, runtime);
        }

        /**
          * You can call this API operation to delete one or more event targets of an event rule.
          *
          * @param request DeleteTargetsRequest
          * @return DeleteTargetsResponse
         */
        public async Task<DeleteTargetsResponse> DeleteTargetsAsync(DeleteTargetsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteTargetsWithOptionsAsync(request, runtime);
        }

        /**
          * You can call this API operation to disable an event rule.
          *
          * @param request DisableRuleRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DisableRuleResponse
         */
        public DisableRuleResponse DisableRuleWithOptions(DisableRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventBusName))
            {
                query["EventBusName"] = request.EventBusName;
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
                Action = "DisableRule",
                Version = "2020-04-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DisableRuleResponse>(CallApi(params_, req, runtime));
        }

        /**
          * You can call this API operation to disable an event rule.
          *
          * @param request DisableRuleRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return DisableRuleResponse
         */
        public async Task<DisableRuleResponse> DisableRuleWithOptionsAsync(DisableRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventBusName))
            {
                query["EventBusName"] = request.EventBusName;
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
                Action = "DisableRule",
                Version = "2020-04-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DisableRuleResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * You can call this API operation to disable an event rule.
          *
          * @param request DisableRuleRequest
          * @return DisableRuleResponse
         */
        public DisableRuleResponse DisableRule(DisableRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DisableRuleWithOptions(request, runtime);
        }

        /**
          * You can call this API operation to disable an event rule.
          *
          * @param request DisableRuleRequest
          * @return DisableRuleResponse
         */
        public async Task<DisableRuleResponse> DisableRuleAsync(DisableRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DisableRuleWithOptionsAsync(request, runtime);
        }

        /**
          * You can call this API operation to enable an event rule.
          *
          * @param request EnableRuleRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return EnableRuleResponse
         */
        public EnableRuleResponse EnableRuleWithOptions(EnableRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventBusName))
            {
                query["EventBusName"] = request.EventBusName;
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
                Action = "EnableRule",
                Version = "2020-04-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<EnableRuleResponse>(CallApi(params_, req, runtime));
        }

        /**
          * You can call this API operation to enable an event rule.
          *
          * @param request EnableRuleRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return EnableRuleResponse
         */
        public async Task<EnableRuleResponse> EnableRuleWithOptionsAsync(EnableRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventBusName))
            {
                query["EventBusName"] = request.EventBusName;
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
                Action = "EnableRule",
                Version = "2020-04-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<EnableRuleResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * You can call this API operation to enable an event rule.
          *
          * @param request EnableRuleRequest
          * @return EnableRuleResponse
         */
        public EnableRuleResponse EnableRule(EnableRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return EnableRuleWithOptions(request, runtime);
        }

        /**
          * You can call this API operation to enable an event rule.
          *
          * @param request EnableRuleRequest
          * @return EnableRuleResponse
         */
        public async Task<EnableRuleResponse> EnableRuleAsync(EnableRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await EnableRuleWithOptionsAsync(request, runtime);
        }

        /**
          * You can call this API operation to query the information about an API destination.
          *
          * @param request GetApiDestinationRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return GetApiDestinationResponse
         */
        public GetApiDestinationResponse GetApiDestinationWithOptions(GetApiDestinationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApiDestinationName))
            {
                query["ApiDestinationName"] = request.ApiDestinationName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetApiDestination",
                Version = "2020-04-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetApiDestinationResponse>(CallApi(params_, req, runtime));
        }

        /**
          * You can call this API operation to query the information about an API destination.
          *
          * @param request GetApiDestinationRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return GetApiDestinationResponse
         */
        public async Task<GetApiDestinationResponse> GetApiDestinationWithOptionsAsync(GetApiDestinationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApiDestinationName))
            {
                query["ApiDestinationName"] = request.ApiDestinationName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetApiDestination",
                Version = "2020-04-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetApiDestinationResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * You can call this API operation to query the information about an API destination.
          *
          * @param request GetApiDestinationRequest
          * @return GetApiDestinationResponse
         */
        public GetApiDestinationResponse GetApiDestination(GetApiDestinationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetApiDestinationWithOptions(request, runtime);
        }

        /**
          * You can call this API operation to query the information about an API destination.
          *
          * @param request GetApiDestinationRequest
          * @return GetApiDestinationResponse
         */
        public async Task<GetApiDestinationResponse> GetApiDestinationAsync(GetApiDestinationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetApiDestinationWithOptionsAsync(request, runtime);
        }

        /**
          * You can call this API operation to query the configurations of a connection.
          *
          * @param request GetConnectionRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return GetConnectionResponse
         */
        public GetConnectionResponse GetConnectionWithOptions(GetConnectionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConnectionName))
            {
                query["ConnectionName"] = request.ConnectionName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetConnection",
                Version = "2020-04-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetConnectionResponse>(CallApi(params_, req, runtime));
        }

        /**
          * You can call this API operation to query the configurations of a connection.
          *
          * @param request GetConnectionRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return GetConnectionResponse
         */
        public async Task<GetConnectionResponse> GetConnectionWithOptionsAsync(GetConnectionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConnectionName))
            {
                query["ConnectionName"] = request.ConnectionName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetConnection",
                Version = "2020-04-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetConnectionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * You can call this API operation to query the configurations of a connection.
          *
          * @param request GetConnectionRequest
          * @return GetConnectionResponse
         */
        public GetConnectionResponse GetConnection(GetConnectionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetConnectionWithOptions(request, runtime);
        }

        /**
          * You can call this API operation to query the configurations of a connection.
          *
          * @param request GetConnectionRequest
          * @return GetConnectionResponse
         */
        public async Task<GetConnectionResponse> GetConnectionAsync(GetConnectionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetConnectionWithOptionsAsync(request, runtime);
        }

        /**
          * You can call this API operation to query the detailed information about an event bus.
          *
          * @param request GetEventBusRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return GetEventBusResponse
         */
        public GetEventBusResponse GetEventBusWithOptions(GetEventBusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventBusName))
            {
                query["EventBusName"] = request.EventBusName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetEventBus",
                Version = "2020-04-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetEventBusResponse>(CallApi(params_, req, runtime));
        }

        /**
          * You can call this API operation to query the detailed information about an event bus.
          *
          * @param request GetEventBusRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return GetEventBusResponse
         */
        public async Task<GetEventBusResponse> GetEventBusWithOptionsAsync(GetEventBusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventBusName))
            {
                query["EventBusName"] = request.EventBusName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetEventBus",
                Version = "2020-04-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetEventBusResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * You can call this API operation to query the detailed information about an event bus.
          *
          * @param request GetEventBusRequest
          * @return GetEventBusResponse
         */
        public GetEventBusResponse GetEventBus(GetEventBusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetEventBusWithOptions(request, runtime);
        }

        /**
          * You can call this API operation to query the detailed information about an event bus.
          *
          * @param request GetEventBusRequest
          * @return GetEventBusResponse
         */
        public async Task<GetEventBusResponse> GetEventBusAsync(GetEventBusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetEventBusWithOptionsAsync(request, runtime);
        }

        /**
          * You can call this API operation to query the details of an event stream.
          *
          * @param request GetEventStreamingRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return GetEventStreamingResponse
         */
        public GetEventStreamingResponse GetEventStreamingWithOptions(GetEventStreamingRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventStreamingName))
            {
                body["EventStreamingName"] = request.EventStreamingName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetEventStreaming",
                Version = "2020-04-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetEventStreamingResponse>(CallApi(params_, req, runtime));
        }

        /**
          * You can call this API operation to query the details of an event stream.
          *
          * @param request GetEventStreamingRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return GetEventStreamingResponse
         */
        public async Task<GetEventStreamingResponse> GetEventStreamingWithOptionsAsync(GetEventStreamingRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventStreamingName))
            {
                body["EventStreamingName"] = request.EventStreamingName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetEventStreaming",
                Version = "2020-04-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetEventStreamingResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * You can call this API operation to query the details of an event stream.
          *
          * @param request GetEventStreamingRequest
          * @return GetEventStreamingResponse
         */
        public GetEventStreamingResponse GetEventStreaming(GetEventStreamingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetEventStreamingWithOptions(request, runtime);
        }

        /**
          * You can call this API operation to query the details of an event stream.
          *
          * @param request GetEventStreamingRequest
          * @return GetEventStreamingResponse
         */
        public async Task<GetEventStreamingResponse> GetEventStreamingAsync(GetEventStreamingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetEventStreamingWithOptionsAsync(request, runtime);
        }

        /**
          * You can call this API operation to query the details of an event rule.
          *
          * @param request GetRuleRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return GetRuleResponse
         */
        public GetRuleResponse GetRuleWithOptions(GetRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventBusName))
            {
                query["EventBusName"] = request.EventBusName;
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
                Action = "GetRule",
                Version = "2020-04-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetRuleResponse>(CallApi(params_, req, runtime));
        }

        /**
          * You can call this API operation to query the details of an event rule.
          *
          * @param request GetRuleRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return GetRuleResponse
         */
        public async Task<GetRuleResponse> GetRuleWithOptionsAsync(GetRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventBusName))
            {
                query["EventBusName"] = request.EventBusName;
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
                Action = "GetRule",
                Version = "2020-04-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetRuleResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * You can call this API operation to query the details of an event rule.
          *
          * @param request GetRuleRequest
          * @return GetRuleResponse
         */
        public GetRuleResponse GetRule(GetRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetRuleWithOptions(request, runtime);
        }

        /**
          * You can call this API operation to query the details of an event rule.
          *
          * @param request GetRuleRequest
          * @return GetRuleResponse
         */
        public async Task<GetRuleResponse> GetRuleAsync(GetRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetRuleWithOptionsAsync(request, runtime);
        }

        /**
          * You can call this API operation to query all Alibaba Cloud service event sources.
          *
          * @param request ListAliyunOfficialEventSourcesRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return ListAliyunOfficialEventSourcesResponse
         */
        public ListAliyunOfficialEventSourcesResponse ListAliyunOfficialEventSourcesWithOptions(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListAliyunOfficialEventSources",
                Version = "2020-04-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAliyunOfficialEventSourcesResponse>(CallApi(params_, req, runtime));
        }

        /**
          * You can call this API operation to query all Alibaba Cloud service event sources.
          *
          * @param request ListAliyunOfficialEventSourcesRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return ListAliyunOfficialEventSourcesResponse
         */
        public async Task<ListAliyunOfficialEventSourcesResponse> ListAliyunOfficialEventSourcesWithOptionsAsync(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListAliyunOfficialEventSources",
                Version = "2020-04-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAliyunOfficialEventSourcesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * You can call this API operation to query all Alibaba Cloud service event sources.
          *
          * @return ListAliyunOfficialEventSourcesResponse
         */
        public ListAliyunOfficialEventSourcesResponse ListAliyunOfficialEventSources()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListAliyunOfficialEventSourcesWithOptions(runtime);
        }

        /**
          * You can call this API operation to query all Alibaba Cloud service event sources.
          *
          * @return ListAliyunOfficialEventSourcesResponse
         */
        public async Task<ListAliyunOfficialEventSourcesResponse> ListAliyunOfficialEventSourcesAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListAliyunOfficialEventSourcesWithOptionsAsync(runtime);
        }

        /**
          * You can use this API operation to query a list of API destinations.
          *
          * @param request ListApiDestinationsRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return ListApiDestinationsResponse
         */
        public ListApiDestinationsResponse ListApiDestinationsWithOptions(ListApiDestinationsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApiDestinationNamePrefix))
            {
                query["ApiDestinationNamePrefix"] = request.ApiDestinationNamePrefix;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConnectionName))
            {
                query["ConnectionName"] = request.ConnectionName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListApiDestinations",
                Version = "2020-04-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListApiDestinationsResponse>(CallApi(params_, req, runtime));
        }

        /**
          * You can use this API operation to query a list of API destinations.
          *
          * @param request ListApiDestinationsRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return ListApiDestinationsResponse
         */
        public async Task<ListApiDestinationsResponse> ListApiDestinationsWithOptionsAsync(ListApiDestinationsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApiDestinationNamePrefix))
            {
                query["ApiDestinationNamePrefix"] = request.ApiDestinationNamePrefix;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConnectionName))
            {
                query["ConnectionName"] = request.ConnectionName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListApiDestinations",
                Version = "2020-04-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListApiDestinationsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * You can use this API operation to query a list of API destinations.
          *
          * @param request ListApiDestinationsRequest
          * @return ListApiDestinationsResponse
         */
        public ListApiDestinationsResponse ListApiDestinations(ListApiDestinationsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListApiDestinationsWithOptions(request, runtime);
        }

        /**
          * You can use this API operation to query a list of API destinations.
          *
          * @param request ListApiDestinationsRequest
          * @return ListApiDestinationsResponse
         */
        public async Task<ListApiDestinationsResponse> ListApiDestinationsAsync(ListApiDestinationsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListApiDestinationsWithOptionsAsync(request, runtime);
        }

        /**
          * You can call this API operation to query connections.
          *
          * @param request ListConnectionsRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return ListConnectionsResponse
         */
        public ListConnectionsResponse ListConnectionsWithOptions(ListConnectionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConnectionNamePrefix))
            {
                body["ConnectionNamePrefix"] = request.ConnectionNamePrefix;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                body["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                body["NextToken"] = request.NextToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListConnections",
                Version = "2020-04-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListConnectionsResponse>(CallApi(params_, req, runtime));
        }

        /**
          * You can call this API operation to query connections.
          *
          * @param request ListConnectionsRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return ListConnectionsResponse
         */
        public async Task<ListConnectionsResponse> ListConnectionsWithOptionsAsync(ListConnectionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConnectionNamePrefix))
            {
                body["ConnectionNamePrefix"] = request.ConnectionNamePrefix;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                body["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                body["NextToken"] = request.NextToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListConnections",
                Version = "2020-04-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListConnectionsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * You can call this API operation to query connections.
          *
          * @param request ListConnectionsRequest
          * @return ListConnectionsResponse
         */
        public ListConnectionsResponse ListConnections(ListConnectionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListConnectionsWithOptions(request, runtime);
        }

        /**
          * You can call this API operation to query connections.
          *
          * @param request ListConnectionsRequest
          * @return ListConnectionsResponse
         */
        public async Task<ListConnectionsResponse> ListConnectionsAsync(ListConnectionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListConnectionsWithOptionsAsync(request, runtime);
        }

        /**
          * You can call this API operation to query all event buses.
          *
          * @param request ListEventBusesRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return ListEventBusesResponse
         */
        public ListEventBusesResponse ListEventBusesWithOptions(ListEventBusesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Limit))
            {
                query["Limit"] = request.Limit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NamePrefix))
            {
                query["NamePrefix"] = request.NamePrefix;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListEventBuses",
                Version = "2020-04-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListEventBusesResponse>(CallApi(params_, req, runtime));
        }

        /**
          * You can call this API operation to query all event buses.
          *
          * @param request ListEventBusesRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return ListEventBusesResponse
         */
        public async Task<ListEventBusesResponse> ListEventBusesWithOptionsAsync(ListEventBusesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Limit))
            {
                query["Limit"] = request.Limit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NamePrefix))
            {
                query["NamePrefix"] = request.NamePrefix;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListEventBuses",
                Version = "2020-04-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListEventBusesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * You can call this API operation to query all event buses.
          *
          * @param request ListEventBusesRequest
          * @return ListEventBusesResponse
         */
        public ListEventBusesResponse ListEventBuses(ListEventBusesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListEventBusesWithOptions(request, runtime);
        }

        /**
          * You can call this API operation to query all event buses.
          *
          * @param request ListEventBusesRequest
          * @return ListEventBusesResponse
         */
        public async Task<ListEventBusesResponse> ListEventBusesAsync(ListEventBusesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListEventBusesWithOptionsAsync(request, runtime);
        }

        /**
          * You can call this API operation to query event streams.
          *
          * @param request ListEventStreamingsRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return ListEventStreamingsResponse
         */
        public ListEventStreamingsResponse ListEventStreamingsWithOptions(ListEventStreamingsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Limit))
            {
                body["Limit"] = request.Limit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NamePrefix))
            {
                body["NamePrefix"] = request.NamePrefix;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                body["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SinkArn))
            {
                body["SinkArn"] = request.SinkArn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceArn))
            {
                body["SourceArn"] = request.SourceArn;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListEventStreamings",
                Version = "2020-04-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListEventStreamingsResponse>(CallApi(params_, req, runtime));
        }

        /**
          * You can call this API operation to query event streams.
          *
          * @param request ListEventStreamingsRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return ListEventStreamingsResponse
         */
        public async Task<ListEventStreamingsResponse> ListEventStreamingsWithOptionsAsync(ListEventStreamingsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Limit))
            {
                body["Limit"] = request.Limit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NamePrefix))
            {
                body["NamePrefix"] = request.NamePrefix;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                body["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SinkArn))
            {
                body["SinkArn"] = request.SinkArn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceArn))
            {
                body["SourceArn"] = request.SourceArn;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListEventStreamings",
                Version = "2020-04-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListEventStreamingsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * You can call this API operation to query event streams.
          *
          * @param request ListEventStreamingsRequest
          * @return ListEventStreamingsResponse
         */
        public ListEventStreamingsResponse ListEventStreamings(ListEventStreamingsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListEventStreamingsWithOptions(request, runtime);
        }

        /**
          * You can call this API operation to query event streams.
          *
          * @param request ListEventStreamingsRequest
          * @return ListEventStreamingsResponse
         */
        public async Task<ListEventStreamingsResponse> ListEventStreamingsAsync(ListEventStreamingsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListEventStreamingsWithOptionsAsync(request, runtime);
        }

        /**
          * You can call this API operation to query all rules of an event bus.
          *
          * @param request ListRulesRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return ListRulesResponse
         */
        public ListRulesResponse ListRulesWithOptions(ListRulesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventBusName))
            {
                query["EventBusName"] = request.EventBusName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Limit))
            {
                query["Limit"] = request.Limit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleNamePrefix))
            {
                query["RuleNamePrefix"] = request.RuleNamePrefix;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListRules",
                Version = "2020-04-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListRulesResponse>(CallApi(params_, req, runtime));
        }

        /**
          * You can call this API operation to query all rules of an event bus.
          *
          * @param request ListRulesRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return ListRulesResponse
         */
        public async Task<ListRulesResponse> ListRulesWithOptionsAsync(ListRulesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventBusName))
            {
                query["EventBusName"] = request.EventBusName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Limit))
            {
                query["Limit"] = request.Limit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleNamePrefix))
            {
                query["RuleNamePrefix"] = request.RuleNamePrefix;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListRules",
                Version = "2020-04-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListRulesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * You can call this API operation to query all rules of an event bus.
          *
          * @param request ListRulesRequest
          * @return ListRulesResponse
         */
        public ListRulesResponse ListRules(ListRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListRulesWithOptions(request, runtime);
        }

        /**
          * You can call this API operation to query all rules of an event bus.
          *
          * @param request ListRulesRequest
          * @return ListRulesResponse
         */
        public async Task<ListRulesResponse> ListRulesAsync(ListRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListRulesWithOptionsAsync(request, runtime);
        }

        public ListTargetsResponse ListTargetsWithOptions(ListTargetsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Arn))
            {
                query["Arn"] = request.Arn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventBusName))
            {
                query["EventBusName"] = request.EventBusName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Limit))
            {
                query["Limit"] = request.Limit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
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
                Action = "ListTargets",
                Version = "2020-04-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTargetsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListTargetsResponse> ListTargetsWithOptionsAsync(ListTargetsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Arn))
            {
                query["Arn"] = request.Arn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventBusName))
            {
                query["EventBusName"] = request.EventBusName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Limit))
            {
                query["Limit"] = request.Limit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
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
                Action = "ListTargets",
                Version = "2020-04-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTargetsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListTargetsResponse ListTargets(ListTargetsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListTargetsWithOptions(request, runtime);
        }

        public async Task<ListTargetsResponse> ListTargetsAsync(ListTargetsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListTargetsWithOptionsAsync(request, runtime);
        }

        /**
          * You can call this API operation to query custom event sources.
          *
          * @param request ListUserDefinedEventSourcesRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return ListUserDefinedEventSourcesResponse
         */
        public ListUserDefinedEventSourcesResponse ListUserDefinedEventSourcesWithOptions(ListUserDefinedEventSourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventBusName))
            {
                query["EventBusName"] = request.EventBusName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Limit))
            {
                query["Limit"] = request.Limit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NamePrefix))
            {
                query["NamePrefix"] = request.NamePrefix;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListUserDefinedEventSources",
                Version = "2020-04-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListUserDefinedEventSourcesResponse>(CallApi(params_, req, runtime));
        }

        /**
          * You can call this API operation to query custom event sources.
          *
          * @param request ListUserDefinedEventSourcesRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return ListUserDefinedEventSourcesResponse
         */
        public async Task<ListUserDefinedEventSourcesResponse> ListUserDefinedEventSourcesWithOptionsAsync(ListUserDefinedEventSourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventBusName))
            {
                query["EventBusName"] = request.EventBusName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Limit))
            {
                query["Limit"] = request.Limit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NamePrefix))
            {
                query["NamePrefix"] = request.NamePrefix;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListUserDefinedEventSources",
                Version = "2020-04-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListUserDefinedEventSourcesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * You can call this API operation to query custom event sources.
          *
          * @param request ListUserDefinedEventSourcesRequest
          * @return ListUserDefinedEventSourcesResponse
         */
        public ListUserDefinedEventSourcesResponse ListUserDefinedEventSources(ListUserDefinedEventSourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListUserDefinedEventSourcesWithOptions(request, runtime);
        }

        /**
          * You can call this API operation to query custom event sources.
          *
          * @param request ListUserDefinedEventSourcesRequest
          * @return ListUserDefinedEventSourcesResponse
         */
        public async Task<ListUserDefinedEventSourcesResponse> ListUserDefinedEventSourcesAsync(ListUserDefinedEventSourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListUserDefinedEventSourcesWithOptionsAsync(request, runtime);
        }

        /**
          * You can call this API operation to stop an event stream that is running.
          *
          * @param request PauseEventStreamingRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return PauseEventStreamingResponse
         */
        public PauseEventStreamingResponse PauseEventStreamingWithOptions(PauseEventStreamingRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventStreamingName))
            {
                body["EventStreamingName"] = request.EventStreamingName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PauseEventStreaming",
                Version = "2020-04-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PauseEventStreamingResponse>(CallApi(params_, req, runtime));
        }

        /**
          * You can call this API operation to stop an event stream that is running.
          *
          * @param request PauseEventStreamingRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return PauseEventStreamingResponse
         */
        public async Task<PauseEventStreamingResponse> PauseEventStreamingWithOptionsAsync(PauseEventStreamingRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventStreamingName))
            {
                body["EventStreamingName"] = request.EventStreamingName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PauseEventStreaming",
                Version = "2020-04-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PauseEventStreamingResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * You can call this API operation to stop an event stream that is running.
          *
          * @param request PauseEventStreamingRequest
          * @return PauseEventStreamingResponse
         */
        public PauseEventStreamingResponse PauseEventStreaming(PauseEventStreamingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return PauseEventStreamingWithOptions(request, runtime);
        }

        /**
          * You can call this API operation to stop an event stream that is running.
          *
          * @param request PauseEventStreamingRequest
          * @return PauseEventStreamingResponse
         */
        public async Task<PauseEventStreamingResponse> PauseEventStreamingAsync(PauseEventStreamingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await PauseEventStreamingWithOptionsAsync(request, runtime);
        }

        /**
          * You can call this API operation to create or update event targets under a rule.
          *
          * @param tmpReq PutTargetsRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return PutTargetsResponse
         */
        public PutTargetsResponse PutTargetsWithOptions(PutTargetsRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            PutTargetsShrinkRequest request = new PutTargetsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Targets))
            {
                request.TargetsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Targets, "Targets", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventBusName))
            {
                query["EventBusName"] = request.EventBusName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleName))
            {
                query["RuleName"] = request.RuleName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetsShrink))
            {
                query["Targets"] = request.TargetsShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PutTargets",
                Version = "2020-04-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PutTargetsResponse>(CallApi(params_, req, runtime));
        }

        /**
          * You can call this API operation to create or update event targets under a rule.
          *
          * @param tmpReq PutTargetsRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return PutTargetsResponse
         */
        public async Task<PutTargetsResponse> PutTargetsWithOptionsAsync(PutTargetsRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            PutTargetsShrinkRequest request = new PutTargetsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Targets))
            {
                request.TargetsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Targets, "Targets", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventBusName))
            {
                query["EventBusName"] = request.EventBusName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleName))
            {
                query["RuleName"] = request.RuleName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetsShrink))
            {
                query["Targets"] = request.TargetsShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PutTargets",
                Version = "2020-04-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<PutTargetsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * You can call this API operation to create or update event targets under a rule.
          *
          * @param request PutTargetsRequest
          * @return PutTargetsResponse
         */
        public PutTargetsResponse PutTargets(PutTargetsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return PutTargetsWithOptions(request, runtime);
        }

        /**
          * You can call this API operation to create or update event targets under a rule.
          *
          * @param request PutTargetsRequest
          * @return PutTargetsResponse
         */
        public async Task<PutTargetsResponse> PutTargetsAsync(PutTargetsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await PutTargetsWithOptionsAsync(request, runtime);
        }

        /**
          * You can call this API operation to query the content of an event.
          *
          * @param request QueryEventRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return QueryEventResponse
         */
        public QueryEventResponse QueryEventWithOptions(QueryEventRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventBusName))
            {
                query["EventBusName"] = request.EventBusName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventId))
            {
                query["EventId"] = request.EventId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventSource))
            {
                query["EventSource"] = request.EventSource;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryEvent",
                Version = "2020-04-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryEventResponse>(CallApi(params_, req, runtime));
        }

        /**
          * You can call this API operation to query the content of an event.
          *
          * @param request QueryEventRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return QueryEventResponse
         */
        public async Task<QueryEventResponse> QueryEventWithOptionsAsync(QueryEventRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventBusName))
            {
                query["EventBusName"] = request.EventBusName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventId))
            {
                query["EventId"] = request.EventId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventSource))
            {
                query["EventSource"] = request.EventSource;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryEvent",
                Version = "2020-04-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryEventResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * You can call this API operation to query the content of an event.
          *
          * @param request QueryEventRequest
          * @return QueryEventResponse
         */
        public QueryEventResponse QueryEvent(QueryEventRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryEventWithOptions(request, runtime);
        }

        /**
          * You can call this API operation to query the content of an event.
          *
          * @param request QueryEventRequest
          * @return QueryEventResponse
         */
        public async Task<QueryEventResponse> QueryEventAsync(QueryEventRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryEventWithOptionsAsync(request, runtime);
        }

        /**
          * You can call this API operation to query event traces.
          *
          * @param request QueryEventTracesRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return QueryEventTracesResponse
         */
        public QueryEventTracesResponse QueryEventTracesWithOptions(QueryEventTracesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventBusName))
            {
                query["EventBusName"] = request.EventBusName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventId))
            {
                query["EventId"] = request.EventId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryEventTraces",
                Version = "2020-04-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryEventTracesResponse>(CallApi(params_, req, runtime));
        }

        /**
          * You can call this API operation to query event traces.
          *
          * @param request QueryEventTracesRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return QueryEventTracesResponse
         */
        public async Task<QueryEventTracesResponse> QueryEventTracesWithOptionsAsync(QueryEventTracesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventBusName))
            {
                query["EventBusName"] = request.EventBusName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventId))
            {
                query["EventId"] = request.EventId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryEventTraces",
                Version = "2020-04-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryEventTracesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * You can call this API operation to query event traces.
          *
          * @param request QueryEventTracesRequest
          * @return QueryEventTracesResponse
         */
        public QueryEventTracesResponse QueryEventTraces(QueryEventTracesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryEventTracesWithOptions(request, runtime);
        }

        /**
          * You can call this API operation to query event traces.
          *
          * @param request QueryEventTracesRequest
          * @return QueryEventTracesResponse
         */
        public async Task<QueryEventTracesResponse> QueryEventTracesAsync(QueryEventTracesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryEventTracesWithOptionsAsync(request, runtime);
        }

        /**
          * You can call this API operation to query event traces by event ID.
          *
          * @param request QueryTracedEventByEventIdRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return QueryTracedEventByEventIdResponse
         */
        public QueryTracedEventByEventIdResponse QueryTracedEventByEventIdWithOptions(QueryTracedEventByEventIdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventBusName))
            {
                query["EventBusName"] = request.EventBusName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventId))
            {
                query["EventId"] = request.EventId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventSource))
            {
                query["EventSource"] = request.EventSource;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryTracedEventByEventId",
                Version = "2020-04-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryTracedEventByEventIdResponse>(CallApi(params_, req, runtime));
        }

        /**
          * You can call this API operation to query event traces by event ID.
          *
          * @param request QueryTracedEventByEventIdRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return QueryTracedEventByEventIdResponse
         */
        public async Task<QueryTracedEventByEventIdResponse> QueryTracedEventByEventIdWithOptionsAsync(QueryTracedEventByEventIdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventBusName))
            {
                query["EventBusName"] = request.EventBusName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventId))
            {
                query["EventId"] = request.EventId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventSource))
            {
                query["EventSource"] = request.EventSource;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryTracedEventByEventId",
                Version = "2020-04-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryTracedEventByEventIdResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * You can call this API operation to query event traces by event ID.
          *
          * @param request QueryTracedEventByEventIdRequest
          * @return QueryTracedEventByEventIdResponse
         */
        public QueryTracedEventByEventIdResponse QueryTracedEventByEventId(QueryTracedEventByEventIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryTracedEventByEventIdWithOptions(request, runtime);
        }

        /**
          * You can call this API operation to query event traces by event ID.
          *
          * @param request QueryTracedEventByEventIdRequest
          * @return QueryTracedEventByEventIdResponse
         */
        public async Task<QueryTracedEventByEventIdResponse> QueryTracedEventByEventIdAsync(QueryTracedEventByEventIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryTracedEventByEventIdWithOptionsAsync(request, runtime);
        }

        /**
          * You can call this API operation to query event traces by time range.
          *
          * @param request QueryTracedEventsRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return QueryTracedEventsResponse
         */
        public QueryTracedEventsResponse QueryTracedEventsWithOptions(QueryTracedEventsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventBusName))
            {
                query["EventBusName"] = request.EventBusName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventSource))
            {
                query["EventSource"] = request.EventSource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventType))
            {
                query["EventType"] = request.EventType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Limit))
            {
                query["Limit"] = request.Limit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MatchedRule))
            {
                query["MatchedRule"] = request.MatchedRule;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
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
                Action = "QueryTracedEvents",
                Version = "2020-04-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryTracedEventsResponse>(CallApi(params_, req, runtime));
        }

        /**
          * You can call this API operation to query event traces by time range.
          *
          * @param request QueryTracedEventsRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return QueryTracedEventsResponse
         */
        public async Task<QueryTracedEventsResponse> QueryTracedEventsWithOptionsAsync(QueryTracedEventsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventBusName))
            {
                query["EventBusName"] = request.EventBusName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventSource))
            {
                query["EventSource"] = request.EventSource;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventType))
            {
                query["EventType"] = request.EventType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Limit))
            {
                query["Limit"] = request.Limit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MatchedRule))
            {
                query["MatchedRule"] = request.MatchedRule;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
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
                Action = "QueryTracedEvents",
                Version = "2020-04-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryTracedEventsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * You can call this API operation to query event traces by time range.
          *
          * @param request QueryTracedEventsRequest
          * @return QueryTracedEventsResponse
         */
        public QueryTracedEventsResponse QueryTracedEvents(QueryTracedEventsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryTracedEventsWithOptions(request, runtime);
        }

        /**
          * You can call this API operation to query event traces by time range.
          *
          * @param request QueryTracedEventsRequest
          * @return QueryTracedEventsResponse
         */
        public async Task<QueryTracedEventsResponse> QueryTracedEventsAsync(QueryTracedEventsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryTracedEventsWithOptionsAsync(request, runtime);
        }

        /**
          * You can call this API operation to enable a created or deactivated event stream.
          *
          * @param request StartEventStreamingRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return StartEventStreamingResponse
         */
        public StartEventStreamingResponse StartEventStreamingWithOptions(StartEventStreamingRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventStreamingName))
            {
                body["EventStreamingName"] = request.EventStreamingName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StartEventStreaming",
                Version = "2020-04-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<StartEventStreamingResponse>(CallApi(params_, req, runtime));
        }

        /**
          * You can call this API operation to enable a created or deactivated event stream.
          *
          * @param request StartEventStreamingRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return StartEventStreamingResponse
         */
        public async Task<StartEventStreamingResponse> StartEventStreamingWithOptionsAsync(StartEventStreamingRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventStreamingName))
            {
                body["EventStreamingName"] = request.EventStreamingName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StartEventStreaming",
                Version = "2020-04-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<StartEventStreamingResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * You can call this API operation to enable a created or deactivated event stream.
          *
          * @param request StartEventStreamingRequest
          * @return StartEventStreamingResponse
         */
        public StartEventStreamingResponse StartEventStreaming(StartEventStreamingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StartEventStreamingWithOptions(request, runtime);
        }

        /**
          * You can call this API operation to enable a created or deactivated event stream.
          *
          * @param request StartEventStreamingRequest
          * @return StartEventStreamingResponse
         */
        public async Task<StartEventStreamingResponse> StartEventStreamingAsync(StartEventStreamingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StartEventStreamingWithOptionsAsync(request, runtime);
        }

        /**
          * You can call this API operation to check whether the event pattern matches the provided JSON format.
          *
          * @param request TestEventPatternRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return TestEventPatternResponse
         */
        public TestEventPatternResponse TestEventPatternWithOptions(TestEventPatternRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Event))
            {
                body["Event"] = request.Event;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventPattern))
            {
                body["EventPattern"] = request.EventPattern;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TestEventPattern",
                Version = "2020-04-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<TestEventPatternResponse>(CallApi(params_, req, runtime));
        }

        /**
          * You can call this API operation to check whether the event pattern matches the provided JSON format.
          *
          * @param request TestEventPatternRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return TestEventPatternResponse
         */
        public async Task<TestEventPatternResponse> TestEventPatternWithOptionsAsync(TestEventPatternRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Event))
            {
                body["Event"] = request.Event;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventPattern))
            {
                body["EventPattern"] = request.EventPattern;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TestEventPattern",
                Version = "2020-04-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<TestEventPatternResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * You can call this API operation to check whether the event pattern matches the provided JSON format.
          *
          * @param request TestEventPatternRequest
          * @return TestEventPatternResponse
         */
        public TestEventPatternResponse TestEventPattern(TestEventPatternRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return TestEventPatternWithOptions(request, runtime);
        }

        /**
          * You can call this API operation to check whether the event pattern matches the provided JSON format.
          *
          * @param request TestEventPatternRequest
          * @return TestEventPatternResponse
         */
        public async Task<TestEventPatternResponse> TestEventPatternAsync(TestEventPatternRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await TestEventPatternWithOptionsAsync(request, runtime);
        }

        /**
          * You can call this API operation to update an API destination.
          *
          * @param tmpReq UpdateApiDestinationRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return UpdateApiDestinationResponse
         */
        public UpdateApiDestinationResponse UpdateApiDestinationWithOptions(UpdateApiDestinationRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateApiDestinationShrinkRequest request = new UpdateApiDestinationShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.HttpApiParameters))
            {
                request.HttpApiParametersShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.HttpApiParameters, "HttpApiParameters", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApiDestinationName))
            {
                query["ApiDestinationName"] = request.ApiDestinationName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConnectionName))
            {
                query["ConnectionName"] = request.ConnectionName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HttpApiParametersShrink))
            {
                query["HttpApiParameters"] = request.HttpApiParametersShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateApiDestination",
                Version = "2020-04-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateApiDestinationResponse>(CallApi(params_, req, runtime));
        }

        /**
          * You can call this API operation to update an API destination.
          *
          * @param tmpReq UpdateApiDestinationRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return UpdateApiDestinationResponse
         */
        public async Task<UpdateApiDestinationResponse> UpdateApiDestinationWithOptionsAsync(UpdateApiDestinationRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateApiDestinationShrinkRequest request = new UpdateApiDestinationShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.HttpApiParameters))
            {
                request.HttpApiParametersShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.HttpApiParameters, "HttpApiParameters", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ApiDestinationName))
            {
                query["ApiDestinationName"] = request.ApiDestinationName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConnectionName))
            {
                query["ConnectionName"] = request.ConnectionName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HttpApiParametersShrink))
            {
                query["HttpApiParameters"] = request.HttpApiParametersShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateApiDestination",
                Version = "2020-04-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateApiDestinationResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * You can call this API operation to update an API destination.
          *
          * @param request UpdateApiDestinationRequest
          * @return UpdateApiDestinationResponse
         */
        public UpdateApiDestinationResponse UpdateApiDestination(UpdateApiDestinationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateApiDestinationWithOptions(request, runtime);
        }

        /**
          * You can call this API operation to update an API destination.
          *
          * @param request UpdateApiDestinationRequest
          * @return UpdateApiDestinationResponse
         */
        public async Task<UpdateApiDestinationResponse> UpdateApiDestinationAsync(UpdateApiDestinationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateApiDestinationWithOptionsAsync(request, runtime);
        }

        /**
          * You can call this API operation to update a connection.
          *
          * @param tmpReq UpdateConnectionRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return UpdateConnectionResponse
         */
        public UpdateConnectionResponse UpdateConnectionWithOptions(UpdateConnectionRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateConnectionShrinkRequest request = new UpdateConnectionShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.AuthParameters))
            {
                request.AuthParametersShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.AuthParameters, "AuthParameters", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.NetworkParameters))
            {
                request.NetworkParametersShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.NetworkParameters, "NetworkParameters", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthParametersShrink))
            {
                query["AuthParameters"] = request.AuthParametersShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConnectionName))
            {
                query["ConnectionName"] = request.ConnectionName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NetworkParametersShrink))
            {
                query["NetworkParameters"] = request.NetworkParametersShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateConnection",
                Version = "2020-04-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateConnectionResponse>(CallApi(params_, req, runtime));
        }

        /**
          * You can call this API operation to update a connection.
          *
          * @param tmpReq UpdateConnectionRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return UpdateConnectionResponse
         */
        public async Task<UpdateConnectionResponse> UpdateConnectionWithOptionsAsync(UpdateConnectionRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateConnectionShrinkRequest request = new UpdateConnectionShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.AuthParameters))
            {
                request.AuthParametersShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.AuthParameters, "AuthParameters", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.NetworkParameters))
            {
                request.NetworkParametersShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.NetworkParameters, "NetworkParameters", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthParametersShrink))
            {
                query["AuthParameters"] = request.AuthParametersShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConnectionName))
            {
                query["ConnectionName"] = request.ConnectionName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NetworkParametersShrink))
            {
                query["NetworkParameters"] = request.NetworkParametersShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateConnection",
                Version = "2020-04-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateConnectionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * You can call this API operation to update a connection.
          *
          * @param request UpdateConnectionRequest
          * @return UpdateConnectionResponse
         */
        public UpdateConnectionResponse UpdateConnection(UpdateConnectionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateConnectionWithOptions(request, runtime);
        }

        /**
          * You can call this API operation to update a connection.
          *
          * @param request UpdateConnectionRequest
          * @return UpdateConnectionResponse
         */
        public async Task<UpdateConnectionResponse> UpdateConnectionAsync(UpdateConnectionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateConnectionWithOptionsAsync(request, runtime);
        }

        /**
          * You can call this API operation to modify an event bus.
          *
          * @param request UpdateEventBusRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return UpdateEventBusResponse
         */
        public UpdateEventBusResponse UpdateEventBusWithOptions(UpdateEventBusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventBusName))
            {
                query["EventBusName"] = request.EventBusName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateEventBus",
                Version = "2020-04-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateEventBusResponse>(CallApi(params_, req, runtime));
        }

        /**
          * You can call this API operation to modify an event bus.
          *
          * @param request UpdateEventBusRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return UpdateEventBusResponse
         */
        public async Task<UpdateEventBusResponse> UpdateEventBusWithOptionsAsync(UpdateEventBusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventBusName))
            {
                query["EventBusName"] = request.EventBusName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateEventBus",
                Version = "2020-04-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateEventBusResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * You can call this API operation to modify an event bus.
          *
          * @param request UpdateEventBusRequest
          * @return UpdateEventBusResponse
         */
        public UpdateEventBusResponse UpdateEventBus(UpdateEventBusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateEventBusWithOptions(request, runtime);
        }

        /**
          * You can call this API operation to modify an event bus.
          *
          * @param request UpdateEventBusRequest
          * @return UpdateEventBusResponse
         */
        public async Task<UpdateEventBusResponse> UpdateEventBusAsync(UpdateEventBusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateEventBusWithOptionsAsync(request, runtime);
        }

        /**
          * You can call this API operation to update an event source.
          *
          * @param tmpReq UpdateEventSourceRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return UpdateEventSourceResponse
         */
        public UpdateEventSourceResponse UpdateEventSourceWithOptions(UpdateEventSourceRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateEventSourceShrinkRequest request = new UpdateEventSourceShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SourceHttpEventParameters))
            {
                request.SourceHttpEventParametersShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SourceHttpEventParameters, "SourceHttpEventParameters", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SourceKafkaParameters))
            {
                request.SourceKafkaParametersShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SourceKafkaParameters, "SourceKafkaParameters", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SourceMNSParameters))
            {
                request.SourceMNSParametersShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SourceMNSParameters, "SourceMNSParameters", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SourceRabbitMQParameters))
            {
                request.SourceRabbitMQParametersShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SourceRabbitMQParameters, "SourceRabbitMQParameters", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SourceRocketMQParameters))
            {
                request.SourceRocketMQParametersShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SourceRocketMQParameters, "SourceRocketMQParameters", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SourceSLSParameters))
            {
                request.SourceSLSParametersShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SourceSLSParameters, "SourceSLSParameters", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SourceScheduledEventParameters))
            {
                request.SourceScheduledEventParametersShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SourceScheduledEventParameters, "SourceScheduledEventParameters", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventBusName))
            {
                body["EventBusName"] = request.EventBusName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventSourceName))
            {
                body["EventSourceName"] = request.EventSourceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceHttpEventParametersShrink))
            {
                body["SourceHttpEventParameters"] = request.SourceHttpEventParametersShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceKafkaParametersShrink))
            {
                body["SourceKafkaParameters"] = request.SourceKafkaParametersShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceMNSParametersShrink))
            {
                body["SourceMNSParameters"] = request.SourceMNSParametersShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceRabbitMQParametersShrink))
            {
                body["SourceRabbitMQParameters"] = request.SourceRabbitMQParametersShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceRocketMQParametersShrink))
            {
                body["SourceRocketMQParameters"] = request.SourceRocketMQParametersShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceSLSParametersShrink))
            {
                body["SourceSLSParameters"] = request.SourceSLSParametersShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceScheduledEventParametersShrink))
            {
                body["SourceScheduledEventParameters"] = request.SourceScheduledEventParametersShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateEventSource",
                Version = "2020-04-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateEventSourceResponse>(CallApi(params_, req, runtime));
        }

        /**
          * You can call this API operation to update an event source.
          *
          * @param tmpReq UpdateEventSourceRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return UpdateEventSourceResponse
         */
        public async Task<UpdateEventSourceResponse> UpdateEventSourceWithOptionsAsync(UpdateEventSourceRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateEventSourceShrinkRequest request = new UpdateEventSourceShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SourceHttpEventParameters))
            {
                request.SourceHttpEventParametersShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SourceHttpEventParameters, "SourceHttpEventParameters", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SourceKafkaParameters))
            {
                request.SourceKafkaParametersShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SourceKafkaParameters, "SourceKafkaParameters", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SourceMNSParameters))
            {
                request.SourceMNSParametersShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SourceMNSParameters, "SourceMNSParameters", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SourceRabbitMQParameters))
            {
                request.SourceRabbitMQParametersShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SourceRabbitMQParameters, "SourceRabbitMQParameters", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SourceRocketMQParameters))
            {
                request.SourceRocketMQParametersShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SourceRocketMQParameters, "SourceRocketMQParameters", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SourceSLSParameters))
            {
                request.SourceSLSParametersShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SourceSLSParameters, "SourceSLSParameters", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.SourceScheduledEventParameters))
            {
                request.SourceScheduledEventParametersShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.SourceScheduledEventParameters, "SourceScheduledEventParameters", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventBusName))
            {
                body["EventBusName"] = request.EventBusName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventSourceName))
            {
                body["EventSourceName"] = request.EventSourceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceHttpEventParametersShrink))
            {
                body["SourceHttpEventParameters"] = request.SourceHttpEventParametersShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceKafkaParametersShrink))
            {
                body["SourceKafkaParameters"] = request.SourceKafkaParametersShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceMNSParametersShrink))
            {
                body["SourceMNSParameters"] = request.SourceMNSParametersShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceRabbitMQParametersShrink))
            {
                body["SourceRabbitMQParameters"] = request.SourceRabbitMQParametersShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceRocketMQParametersShrink))
            {
                body["SourceRocketMQParameters"] = request.SourceRocketMQParametersShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceSLSParametersShrink))
            {
                body["SourceSLSParameters"] = request.SourceSLSParametersShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceScheduledEventParametersShrink))
            {
                body["SourceScheduledEventParameters"] = request.SourceScheduledEventParametersShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateEventSource",
                Version = "2020-04-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateEventSourceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * You can call this API operation to update an event source.
          *
          * @param request UpdateEventSourceRequest
          * @return UpdateEventSourceResponse
         */
        public UpdateEventSourceResponse UpdateEventSource(UpdateEventSourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateEventSourceWithOptions(request, runtime);
        }

        /**
          * You can call this API operation to update an event source.
          *
          * @param request UpdateEventSourceRequest
          * @return UpdateEventSourceResponse
         */
        public async Task<UpdateEventSourceResponse> UpdateEventSourceAsync(UpdateEventSourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateEventSourceWithOptionsAsync(request, runtime);
        }

        /**
          * You can call this API operation to modify the information about an event stream, such as the basic information and the information about the event source, event filtering rule, and event target.
          *
          * @param tmpReq UpdateEventStreamingRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return UpdateEventStreamingResponse
         */
        public UpdateEventStreamingResponse UpdateEventStreamingWithOptions(UpdateEventStreamingRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateEventStreamingShrinkRequest request = new UpdateEventStreamingShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.RunOptions))
            {
                request.RunOptionsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.RunOptions, "RunOptions", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Sink))
            {
                request.SinkShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Sink, "Sink", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Source))
            {
                request.SourceShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Source, "Source", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Transforms))
            {
                request.TransformsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Transforms, "Transforms", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventStreamingName))
            {
                body["EventStreamingName"] = request.EventStreamingName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FilterPattern))
            {
                body["FilterPattern"] = request.FilterPattern;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RunOptionsShrink))
            {
                body["RunOptions"] = request.RunOptionsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SinkShrink))
            {
                body["Sink"] = request.SinkShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceShrink))
            {
                body["Source"] = request.SourceShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransformsShrink))
            {
                body["Transforms"] = request.TransformsShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateEventStreaming",
                Version = "2020-04-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateEventStreamingResponse>(CallApi(params_, req, runtime));
        }

        /**
          * You can call this API operation to modify the information about an event stream, such as the basic information and the information about the event source, event filtering rule, and event target.
          *
          * @param tmpReq UpdateEventStreamingRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return UpdateEventStreamingResponse
         */
        public async Task<UpdateEventStreamingResponse> UpdateEventStreamingWithOptionsAsync(UpdateEventStreamingRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateEventStreamingShrinkRequest request = new UpdateEventStreamingShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.RunOptions))
            {
                request.RunOptionsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.RunOptions, "RunOptions", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Sink))
            {
                request.SinkShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Sink, "Sink", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Source))
            {
                request.SourceShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Source, "Source", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Transforms))
            {
                request.TransformsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Transforms, "Transforms", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventStreamingName))
            {
                body["EventStreamingName"] = request.EventStreamingName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FilterPattern))
            {
                body["FilterPattern"] = request.FilterPattern;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RunOptionsShrink))
            {
                body["RunOptions"] = request.RunOptionsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SinkShrink))
            {
                body["Sink"] = request.SinkShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceShrink))
            {
                body["Source"] = request.SourceShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TransformsShrink))
            {
                body["Transforms"] = request.TransformsShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateEventStreaming",
                Version = "2020-04-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateEventStreamingResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * You can call this API operation to modify the information about an event stream, such as the basic information and the information about the event source, event filtering rule, and event target.
          *
          * @param request UpdateEventStreamingRequest
          * @return UpdateEventStreamingResponse
         */
        public UpdateEventStreamingResponse UpdateEventStreaming(UpdateEventStreamingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateEventStreamingWithOptions(request, runtime);
        }

        /**
          * You can call this API operation to modify the information about an event stream, such as the basic information and the information about the event source, event filtering rule, and event target.
          *
          * @param request UpdateEventStreamingRequest
          * @return UpdateEventStreamingResponse
         */
        public async Task<UpdateEventStreamingResponse> UpdateEventStreamingAsync(UpdateEventStreamingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateEventStreamingWithOptionsAsync(request, runtime);
        }

        /**
          * You can call this API operation to update the configurations of an event rule.
          *
          * @param request UpdateRuleRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return UpdateRuleResponse
         */
        public UpdateRuleResponse UpdateRuleWithOptions(UpdateRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventBusName))
            {
                query["EventBusName"] = request.EventBusName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FilterPattern))
            {
                query["FilterPattern"] = request.FilterPattern;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleName))
            {
                query["RuleName"] = request.RuleName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateRule",
                Version = "2020-04-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateRuleResponse>(CallApi(params_, req, runtime));
        }

        /**
          * You can call this API operation to update the configurations of an event rule.
          *
          * @param request UpdateRuleRequest
          * @param runtime runtime options for this request RuntimeOptions
          * @return UpdateRuleResponse
         */
        public async Task<UpdateRuleResponse> UpdateRuleWithOptionsAsync(UpdateRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EventBusName))
            {
                query["EventBusName"] = request.EventBusName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FilterPattern))
            {
                query["FilterPattern"] = request.FilterPattern;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RuleName))
            {
                query["RuleName"] = request.RuleName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["Status"] = request.Status;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateRule",
                Version = "2020-04-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateRuleResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
          * You can call this API operation to update the configurations of an event rule.
          *
          * @param request UpdateRuleRequest
          * @return UpdateRuleResponse
         */
        public UpdateRuleResponse UpdateRule(UpdateRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateRuleWithOptions(request, runtime);
        }

        /**
          * You can call this API operation to update the configurations of an event rule.
          *
          * @param request UpdateRuleRequest
          * @return UpdateRuleResponse
         */
        public async Task<UpdateRuleResponse> UpdateRuleAsync(UpdateRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateRuleWithOptionsAsync(request, runtime);
        }

    }
}
