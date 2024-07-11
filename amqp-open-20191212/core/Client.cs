// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Amqp_open20191212.Models;

namespace AlibabaCloud.SDK.Amqp_open20191212
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "regional";
            CheckConfig(config);
            this._endpoint = GetEndpoint("amqp-open", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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
         * @summary Creates a pair of static username and password. If you access an ApsaraMQ for RabbitMQ broker from an open source RabbitMQ client, you must use a pair of username and password for authentication. You can access the ApsaraMQ for RabbitMQ broker only after the authentication is passed. ApsaraMQ for RabbitMQ allows you to generate usernames and passwords by using AccessKey pairs provided by Alibaba Cloud Resource Access Management (RAM).
         *
         * @param request CreateAccountRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateAccountResponse
         */
        public CreateAccountResponse CreateAccountWithOptions(CreateAccountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountAccessKey))
            {
                query["accountAccessKey"] = request.AccountAccessKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreateTimestamp))
            {
                query["createTimestamp"] = request.CreateTimestamp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["instanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecretSign))
            {
                query["secretSign"] = request.SecretSign;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Signature))
            {
                query["signature"] = request.Signature;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserName))
            {
                query["userName"] = request.UserName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateAccount",
                Version = "2019-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateAccountResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Creates a pair of static username and password. If you access an ApsaraMQ for RabbitMQ broker from an open source RabbitMQ client, you must use a pair of username and password for authentication. You can access the ApsaraMQ for RabbitMQ broker only after the authentication is passed. ApsaraMQ for RabbitMQ allows you to generate usernames and passwords by using AccessKey pairs provided by Alibaba Cloud Resource Access Management (RAM).
         *
         * @param request CreateAccountRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateAccountResponse
         */
        public async Task<CreateAccountResponse> CreateAccountWithOptionsAsync(CreateAccountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AccountAccessKey))
            {
                query["accountAccessKey"] = request.AccountAccessKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreateTimestamp))
            {
                query["createTimestamp"] = request.CreateTimestamp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["instanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecretSign))
            {
                query["secretSign"] = request.SecretSign;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Signature))
            {
                query["signature"] = request.Signature;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserName))
            {
                query["userName"] = request.UserName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateAccount",
                Version = "2019-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateAccountResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Creates a pair of static username and password. If you access an ApsaraMQ for RabbitMQ broker from an open source RabbitMQ client, you must use a pair of username and password for authentication. You can access the ApsaraMQ for RabbitMQ broker only after the authentication is passed. ApsaraMQ for RabbitMQ allows you to generate usernames and passwords by using AccessKey pairs provided by Alibaba Cloud Resource Access Management (RAM).
         *
         * @param request CreateAccountRequest
         * @return CreateAccountResponse
         */
        public CreateAccountResponse CreateAccount(CreateAccountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateAccountWithOptions(request, runtime);
        }

        /**
         * @summary Creates a pair of static username and password. If you access an ApsaraMQ for RabbitMQ broker from an open source RabbitMQ client, you must use a pair of username and password for authentication. You can access the ApsaraMQ for RabbitMQ broker only after the authentication is passed. ApsaraMQ for RabbitMQ allows you to generate usernames and passwords by using AccessKey pairs provided by Alibaba Cloud Resource Access Management (RAM).
         *
         * @param request CreateAccountRequest
         * @return CreateAccountResponse
         */
        public async Task<CreateAccountResponse> CreateAccountAsync(CreateAccountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateAccountWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Creates a binding. In ApsaraMQ for RabbitMQ, after a producer sends a message to an exchange, the exchange routes the message to a queue or another exchange based on the binding relationship and the routing rule.
         *
         * @param request CreateBindingRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateBindingResponse
         */
        public CreateBindingResponse CreateBindingWithOptions(CreateBindingRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Argument))
            {
                body["Argument"] = request.Argument;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BindingKey))
            {
                body["BindingKey"] = request.BindingKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BindingType))
            {
                body["BindingType"] = request.BindingType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestinationName))
            {
                body["DestinationName"] = request.DestinationName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceExchange))
            {
                body["SourceExchange"] = request.SourceExchange;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VirtualHost))
            {
                body["VirtualHost"] = request.VirtualHost;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateBinding",
                Version = "2019-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateBindingResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Creates a binding. In ApsaraMQ for RabbitMQ, after a producer sends a message to an exchange, the exchange routes the message to a queue or another exchange based on the binding relationship and the routing rule.
         *
         * @param request CreateBindingRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateBindingResponse
         */
        public async Task<CreateBindingResponse> CreateBindingWithOptionsAsync(CreateBindingRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Argument))
            {
                body["Argument"] = request.Argument;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BindingKey))
            {
                body["BindingKey"] = request.BindingKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BindingType))
            {
                body["BindingType"] = request.BindingType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestinationName))
            {
                body["DestinationName"] = request.DestinationName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceExchange))
            {
                body["SourceExchange"] = request.SourceExchange;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VirtualHost))
            {
                body["VirtualHost"] = request.VirtualHost;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateBinding",
                Version = "2019-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateBindingResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Creates a binding. In ApsaraMQ for RabbitMQ, after a producer sends a message to an exchange, the exchange routes the message to a queue or another exchange based on the binding relationship and the routing rule.
         *
         * @param request CreateBindingRequest
         * @return CreateBindingResponse
         */
        public CreateBindingResponse CreateBinding(CreateBindingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateBindingWithOptions(request, runtime);
        }

        /**
         * @summary Creates a binding. In ApsaraMQ for RabbitMQ, after a producer sends a message to an exchange, the exchange routes the message to a queue or another exchange based on the binding relationship and the routing rule.
         *
         * @param request CreateBindingRequest
         * @return CreateBindingResponse
         */
        public async Task<CreateBindingResponse> CreateBindingAsync(CreateBindingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateBindingWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Creates an exchange. In ApsaraMQ for RabbitMQ, an exchange is used to route a message that is received from a producer to one or more queues or to discard the message. An exchange routes a message to queues by using the routing key and binding keys.
         *
         * @param request CreateExchangeRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateExchangeResponse
         */
        public CreateExchangeResponse CreateExchangeWithOptions(CreateExchangeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlternateExchange))
            {
                body["AlternateExchange"] = request.AlternateExchange;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoDeleteState))
            {
                body["AutoDeleteState"] = request.AutoDeleteState;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExchangeName))
            {
                body["ExchangeName"] = request.ExchangeName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExchangeType))
            {
                body["ExchangeType"] = request.ExchangeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Internal))
            {
                body["Internal"] = request.Internal;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VirtualHost))
            {
                body["VirtualHost"] = request.VirtualHost;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.XDelayedType))
            {
                body["XDelayedType"] = request.XDelayedType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateExchange",
                Version = "2019-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateExchangeResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Creates an exchange. In ApsaraMQ for RabbitMQ, an exchange is used to route a message that is received from a producer to one or more queues or to discard the message. An exchange routes a message to queues by using the routing key and binding keys.
         *
         * @param request CreateExchangeRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateExchangeResponse
         */
        public async Task<CreateExchangeResponse> CreateExchangeWithOptionsAsync(CreateExchangeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AlternateExchange))
            {
                body["AlternateExchange"] = request.AlternateExchange;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoDeleteState))
            {
                body["AutoDeleteState"] = request.AutoDeleteState;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExchangeName))
            {
                body["ExchangeName"] = request.ExchangeName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExchangeType))
            {
                body["ExchangeType"] = request.ExchangeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Internal))
            {
                body["Internal"] = request.Internal;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VirtualHost))
            {
                body["VirtualHost"] = request.VirtualHost;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.XDelayedType))
            {
                body["XDelayedType"] = request.XDelayedType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateExchange",
                Version = "2019-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateExchangeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Creates an exchange. In ApsaraMQ for RabbitMQ, an exchange is used to route a message that is received from a producer to one or more queues or to discard the message. An exchange routes a message to queues by using the routing key and binding keys.
         *
         * @param request CreateExchangeRequest
         * @return CreateExchangeResponse
         */
        public CreateExchangeResponse CreateExchange(CreateExchangeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateExchangeWithOptions(request, runtime);
        }

        /**
         * @summary Creates an exchange. In ApsaraMQ for RabbitMQ, an exchange is used to route a message that is received from a producer to one or more queues or to discard the message. An exchange routes a message to queues by using the routing key and binding keys.
         *
         * @param request CreateExchangeRequest
         * @return CreateExchangeResponse
         */
        public async Task<CreateExchangeResponse> CreateExchangeAsync(CreateExchangeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateExchangeWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 创建实例-基于 openAPI 构建南天门购买工单信息数据
         *
         * @param request CreateInstanceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateInstanceResponse
         */
        public CreateInstanceResponse CreateInstanceWithOptions(CreateInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoRenew))
            {
                query["AutoRenew"] = request.AutoRenew;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoRenewPeriod))
            {
                query["AutoRenewPeriod"] = request.AutoRenewPeriod;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceName))
            {
                query["InstanceName"] = request.InstanceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceType))
            {
                query["InstanceType"] = request.InstanceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxConnections))
            {
                query["MaxConnections"] = request.MaxConnections;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxEipTps))
            {
                query["MaxEipTps"] = request.MaxEipTps;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxPrivateTps))
            {
                query["MaxPrivateTps"] = request.MaxPrivateTps;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PaymentType))
            {
                query["PaymentType"] = request.PaymentType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Period))
            {
                query["Period"] = request.Period;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PeriodCycle))
            {
                query["PeriodCycle"] = request.PeriodCycle;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueueCapacity))
            {
                query["QueueCapacity"] = request.QueueCapacity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RenewStatus))
            {
                query["RenewStatus"] = request.RenewStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RenewalDurationUnit))
            {
                query["RenewalDurationUnit"] = request.RenewalDurationUnit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServerlessChargeType))
            {
                query["ServerlessChargeType"] = request.ServerlessChargeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StorageSize))
            {
                query["StorageSize"] = request.StorageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SupportEip))
            {
                query["SupportEip"] = request.SupportEip;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SupportTracing))
            {
                query["SupportTracing"] = request.SupportTracing;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TracingStorageTime))
            {
                query["TracingStorageTime"] = request.TracingStorageTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateInstance",
                Version = "2019-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateInstanceResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 创建实例-基于 openAPI 构建南天门购买工单信息数据
         *
         * @param request CreateInstanceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateInstanceResponse
         */
        public async Task<CreateInstanceResponse> CreateInstanceWithOptionsAsync(CreateInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoRenew))
            {
                query["AutoRenew"] = request.AutoRenew;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoRenewPeriod))
            {
                query["AutoRenewPeriod"] = request.AutoRenewPeriod;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceName))
            {
                query["InstanceName"] = request.InstanceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceType))
            {
                query["InstanceType"] = request.InstanceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxConnections))
            {
                query["MaxConnections"] = request.MaxConnections;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxEipTps))
            {
                query["MaxEipTps"] = request.MaxEipTps;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxPrivateTps))
            {
                query["MaxPrivateTps"] = request.MaxPrivateTps;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PaymentType))
            {
                query["PaymentType"] = request.PaymentType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Period))
            {
                query["Period"] = request.Period;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PeriodCycle))
            {
                query["PeriodCycle"] = request.PeriodCycle;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueueCapacity))
            {
                query["QueueCapacity"] = request.QueueCapacity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RenewStatus))
            {
                query["RenewStatus"] = request.RenewStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RenewalDurationUnit))
            {
                query["RenewalDurationUnit"] = request.RenewalDurationUnit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServerlessChargeType))
            {
                query["ServerlessChargeType"] = request.ServerlessChargeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StorageSize))
            {
                query["StorageSize"] = request.StorageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SupportEip))
            {
                query["SupportEip"] = request.SupportEip;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SupportTracing))
            {
                query["SupportTracing"] = request.SupportTracing;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TracingStorageTime))
            {
                query["TracingStorageTime"] = request.TracingStorageTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateInstance",
                Version = "2019-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateInstanceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 创建实例-基于 openAPI 构建南天门购买工单信息数据
         *
         * @param request CreateInstanceRequest
         * @return CreateInstanceResponse
         */
        public CreateInstanceResponse CreateInstance(CreateInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateInstanceWithOptions(request, runtime);
        }

        /**
         * @summary 创建实例-基于 openAPI 构建南天门购买工单信息数据
         *
         * @param request CreateInstanceRequest
         * @return CreateInstanceResponse
         */
        public async Task<CreateInstanceResponse> CreateInstanceAsync(CreateInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateInstanceWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Creates a queue. In ApsaraMQ for RabbitMQ, a queue is a message queue. All messages in ApsaraMQ for RabbitMQ are sent to a specific exchange and then routed to a bound queue by the exchange.
         *
         * @param request CreateQueueRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateQueueResponse
         */
        public CreateQueueResponse CreateQueueWithOptions(CreateQueueRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoDeleteState))
            {
                body["AutoDeleteState"] = request.AutoDeleteState;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoExpireState))
            {
                body["AutoExpireState"] = request.AutoExpireState;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeadLetterExchange))
            {
                body["DeadLetterExchange"] = request.DeadLetterExchange;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeadLetterRoutingKey))
            {
                body["DeadLetterRoutingKey"] = request.DeadLetterRoutingKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExclusiveState))
            {
                body["ExclusiveState"] = request.ExclusiveState;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxLength))
            {
                body["MaxLength"] = request.MaxLength;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaximumPriority))
            {
                body["MaximumPriority"] = request.MaximumPriority;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MessageTTL))
            {
                body["MessageTTL"] = request.MessageTTL;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueueName))
            {
                body["QueueName"] = request.QueueName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VirtualHost))
            {
                body["VirtualHost"] = request.VirtualHost;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateQueue",
                Version = "2019-12-12",
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
         * @summary Creates a queue. In ApsaraMQ for RabbitMQ, a queue is a message queue. All messages in ApsaraMQ for RabbitMQ are sent to a specific exchange and then routed to a bound queue by the exchange.
         *
         * @param request CreateQueueRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateQueueResponse
         */
        public async Task<CreateQueueResponse> CreateQueueWithOptionsAsync(CreateQueueRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoDeleteState))
            {
                body["AutoDeleteState"] = request.AutoDeleteState;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AutoExpireState))
            {
                body["AutoExpireState"] = request.AutoExpireState;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeadLetterExchange))
            {
                body["DeadLetterExchange"] = request.DeadLetterExchange;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeadLetterRoutingKey))
            {
                body["DeadLetterRoutingKey"] = request.DeadLetterRoutingKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExclusiveState))
            {
                body["ExclusiveState"] = request.ExclusiveState;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxLength))
            {
                body["MaxLength"] = request.MaxLength;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaximumPriority))
            {
                body["MaximumPriority"] = request.MaximumPriority;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MessageTTL))
            {
                body["MessageTTL"] = request.MessageTTL;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueueName))
            {
                body["QueueName"] = request.QueueName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VirtualHost))
            {
                body["VirtualHost"] = request.VirtualHost;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateQueue",
                Version = "2019-12-12",
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
         * @summary Creates a queue. In ApsaraMQ for RabbitMQ, a queue is a message queue. All messages in ApsaraMQ for RabbitMQ are sent to a specific exchange and then routed to a bound queue by the exchange.
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
         * @summary Creates a queue. In ApsaraMQ for RabbitMQ, a queue is a message queue. All messages in ApsaraMQ for RabbitMQ are sent to a specific exchange and then routed to a bound queue by the exchange.
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
         * @summary Creates a vhost. A vhost is used to logically isolate resources. Each vhost manages its own exchanges, queues, and bindings. Applications can run on independent vhosts in a secure manner. This way, the business of an application is not affected by other applications. Before you connect producers and consumers to an ApsaraMQ for RabbitMQ instance, you must specify vhosts for the producers and consumers.
         *
         * @param request CreateVirtualHostRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateVirtualHostResponse
         */
        public CreateVirtualHostResponse CreateVirtualHostWithOptions(CreateVirtualHostRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VirtualHost))
            {
                body["VirtualHost"] = request.VirtualHost;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateVirtualHost",
                Version = "2019-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateVirtualHostResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Creates a vhost. A vhost is used to logically isolate resources. Each vhost manages its own exchanges, queues, and bindings. Applications can run on independent vhosts in a secure manner. This way, the business of an application is not affected by other applications. Before you connect producers and consumers to an ApsaraMQ for RabbitMQ instance, you must specify vhosts for the producers and consumers.
         *
         * @param request CreateVirtualHostRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return CreateVirtualHostResponse
         */
        public async Task<CreateVirtualHostResponse> CreateVirtualHostWithOptionsAsync(CreateVirtualHostRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VirtualHost))
            {
                body["VirtualHost"] = request.VirtualHost;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateVirtualHost",
                Version = "2019-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateVirtualHostResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Creates a vhost. A vhost is used to logically isolate resources. Each vhost manages its own exchanges, queues, and bindings. Applications can run on independent vhosts in a secure manner. This way, the business of an application is not affected by other applications. Before you connect producers and consumers to an ApsaraMQ for RabbitMQ instance, you must specify vhosts for the producers and consumers.
         *
         * @param request CreateVirtualHostRequest
         * @return CreateVirtualHostResponse
         */
        public CreateVirtualHostResponse CreateVirtualHost(CreateVirtualHostRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateVirtualHostWithOptions(request, runtime);
        }

        /**
         * @summary Creates a vhost. A vhost is used to logically isolate resources. Each vhost manages its own exchanges, queues, and bindings. Applications can run on independent vhosts in a secure manner. This way, the business of an application is not affected by other applications. Before you connect producers and consumers to an ApsaraMQ for RabbitMQ instance, you must specify vhosts for the producers and consumers.
         *
         * @param request CreateVirtualHostRequest
         * @return CreateVirtualHostResponse
         */
        public async Task<CreateVirtualHostResponse> CreateVirtualHostAsync(CreateVirtualHostRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateVirtualHostWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Deletes a pair of username and password.
         *
         * @param request DeleteAccountRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteAccountResponse
         */
        public DeleteAccountResponse DeleteAccountWithOptions(DeleteAccountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreateTimestamp))
            {
                query["CreateTimestamp"] = request.CreateTimestamp;
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
                Action = "DeleteAccount",
                Version = "2019-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteAccountResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Deletes a pair of username and password.
         *
         * @param request DeleteAccountRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteAccountResponse
         */
        public async Task<DeleteAccountResponse> DeleteAccountWithOptionsAsync(DeleteAccountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreateTimestamp))
            {
                query["CreateTimestamp"] = request.CreateTimestamp;
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
                Action = "DeleteAccount",
                Version = "2019-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteAccountResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Deletes a pair of username and password.
         *
         * @param request DeleteAccountRequest
         * @return DeleteAccountResponse
         */
        public DeleteAccountResponse DeleteAccount(DeleteAccountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteAccountWithOptions(request, runtime);
        }

        /**
         * @summary Deletes a pair of username and password.
         *
         * @param request DeleteAccountRequest
         * @return DeleteAccountResponse
         */
        public async Task<DeleteAccountResponse> DeleteAccountAsync(DeleteAccountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteAccountWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Deletes a binding to unbind a queue or an exchange from a source exchange.
         *
         * @param request DeleteBindingRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteBindingResponse
         */
        public DeleteBindingResponse DeleteBindingWithOptions(DeleteBindingRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BindingKey))
            {
                body["BindingKey"] = request.BindingKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BindingType))
            {
                body["BindingType"] = request.BindingType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestinationName))
            {
                body["DestinationName"] = request.DestinationName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceExchange))
            {
                body["SourceExchange"] = request.SourceExchange;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VirtualHost))
            {
                body["VirtualHost"] = request.VirtualHost;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteBinding",
                Version = "2019-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteBindingResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Deletes a binding to unbind a queue or an exchange from a source exchange.
         *
         * @param request DeleteBindingRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteBindingResponse
         */
        public async Task<DeleteBindingResponse> DeleteBindingWithOptionsAsync(DeleteBindingRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BindingKey))
            {
                body["BindingKey"] = request.BindingKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BindingType))
            {
                body["BindingType"] = request.BindingType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestinationName))
            {
                body["DestinationName"] = request.DestinationName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceExchange))
            {
                body["SourceExchange"] = request.SourceExchange;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VirtualHost))
            {
                body["VirtualHost"] = request.VirtualHost;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteBinding",
                Version = "2019-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteBindingResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Deletes a binding to unbind a queue or an exchange from a source exchange.
         *
         * @param request DeleteBindingRequest
         * @return DeleteBindingResponse
         */
        public DeleteBindingResponse DeleteBinding(DeleteBindingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteBindingWithOptions(request, runtime);
        }

        /**
         * @summary Deletes a binding to unbind a queue or an exchange from a source exchange.
         *
         * @param request DeleteBindingRequest
         * @return DeleteBindingResponse
         */
        public async Task<DeleteBindingResponse> DeleteBindingAsync(DeleteBindingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteBindingWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Deletes an exchange.
         *
         * @description ## [](#)Usage notes
         * *   You cannot delete exchanges of the **headers** and **x-jms-topic** types.
         * *   You cannot delete built-in exchanges in a vhost. These exchanges are amq.direct, amq.topic, and amq.fanout.
         *
         * @param request DeleteExchangeRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteExchangeResponse
         */
        public DeleteExchangeResponse DeleteExchangeWithOptions(DeleteExchangeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExchangeName))
            {
                body["ExchangeName"] = request.ExchangeName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VirtualHost))
            {
                body["VirtualHost"] = request.VirtualHost;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteExchange",
                Version = "2019-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteExchangeResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Deletes an exchange.
         *
         * @description ## [](#)Usage notes
         * *   You cannot delete exchanges of the **headers** and **x-jms-topic** types.
         * *   You cannot delete built-in exchanges in a vhost. These exchanges are amq.direct, amq.topic, and amq.fanout.
         *
         * @param request DeleteExchangeRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteExchangeResponse
         */
        public async Task<DeleteExchangeResponse> DeleteExchangeWithOptionsAsync(DeleteExchangeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExchangeName))
            {
                body["ExchangeName"] = request.ExchangeName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VirtualHost))
            {
                body["VirtualHost"] = request.VirtualHost;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteExchange",
                Version = "2019-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteExchangeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Deletes an exchange.
         *
         * @description ## [](#)Usage notes
         * *   You cannot delete exchanges of the **headers** and **x-jms-topic** types.
         * *   You cannot delete built-in exchanges in a vhost. These exchanges are amq.direct, amq.topic, and amq.fanout.
         *
         * @param request DeleteExchangeRequest
         * @return DeleteExchangeResponse
         */
        public DeleteExchangeResponse DeleteExchange(DeleteExchangeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteExchangeWithOptions(request, runtime);
        }

        /**
         * @summary Deletes an exchange.
         *
         * @description ## [](#)Usage notes
         * *   You cannot delete exchanges of the **headers** and **x-jms-topic** types.
         * *   You cannot delete built-in exchanges in a vhost. These exchanges are amq.direct, amq.topic, and amq.fanout.
         *
         * @param request DeleteExchangeRequest
         * @return DeleteExchangeResponse
         */
        public async Task<DeleteExchangeResponse> DeleteExchangeAsync(DeleteExchangeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteExchangeWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Deletes a queue.
         *
         * @param request DeleteQueueRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteQueueResponse
         */
        public DeleteQueueResponse DeleteQueueWithOptions(DeleteQueueRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueueName))
            {
                body["QueueName"] = request.QueueName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VirtualHost))
            {
                body["VirtualHost"] = request.VirtualHost;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteQueue",
                Version = "2019-12-12",
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
         * @summary Deletes a queue.
         *
         * @param request DeleteQueueRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteQueueResponse
         */
        public async Task<DeleteQueueResponse> DeleteQueueWithOptionsAsync(DeleteQueueRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueueName))
            {
                body["QueueName"] = request.QueueName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VirtualHost))
            {
                body["VirtualHost"] = request.VirtualHost;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteQueue",
                Version = "2019-12-12",
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
         * @summary Deletes a queue.
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
         * @summary Deletes a queue.
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
         * @summary Deletes a virtual host (vhost).
         *
         * @description Before you delete a vhost, make sure that all exchanges and queues in the vhost are deleted.
         *
         * @param request DeleteVirtualHostRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteVirtualHostResponse
         */
        public DeleteVirtualHostResponse DeleteVirtualHostWithOptions(DeleteVirtualHostRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VirtualHost))
            {
                body["VirtualHost"] = request.VirtualHost;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteVirtualHost",
                Version = "2019-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteVirtualHostResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Deletes a virtual host (vhost).
         *
         * @description Before you delete a vhost, make sure that all exchanges and queues in the vhost are deleted.
         *
         * @param request DeleteVirtualHostRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DeleteVirtualHostResponse
         */
        public async Task<DeleteVirtualHostResponse> DeleteVirtualHostWithOptionsAsync(DeleteVirtualHostRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VirtualHost))
            {
                body["VirtualHost"] = request.VirtualHost;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteVirtualHost",
                Version = "2019-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteVirtualHostResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Deletes a virtual host (vhost).
         *
         * @description Before you delete a vhost, make sure that all exchanges and queues in the vhost are deleted.
         *
         * @param request DeleteVirtualHostRequest
         * @return DeleteVirtualHostResponse
         */
        public DeleteVirtualHostResponse DeleteVirtualHost(DeleteVirtualHostRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteVirtualHostWithOptions(request, runtime);
        }

        /**
         * @summary Deletes a virtual host (vhost).
         *
         * @description Before you delete a vhost, make sure that all exchanges and queues in the vhost are deleted.
         *
         * @param request DeleteVirtualHostRequest
         * @return DeleteVirtualHostResponse
         */
        public async Task<DeleteVirtualHostResponse> DeleteVirtualHostAsync(DeleteVirtualHostRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteVirtualHostWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the maximum number of vhosts, exchanges, and queues that you can create and the number of created vhosts, exchanges, and queues on an ApsaraMQ for RabbitMQ instance.
         *
         * @param request GetMetadataAmountRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetMetadataAmountResponse
         */
        public GetMetadataAmountResponse GetMetadataAmountWithOptions(GetMetadataAmountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetMetadataAmount",
                Version = "2019-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetMetadataAmountResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the maximum number of vhosts, exchanges, and queues that you can create and the number of created vhosts, exchanges, and queues on an ApsaraMQ for RabbitMQ instance.
         *
         * @param request GetMetadataAmountRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return GetMetadataAmountResponse
         */
        public async Task<GetMetadataAmountResponse> GetMetadataAmountWithOptionsAsync(GetMetadataAmountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetMetadataAmount",
                Version = "2019-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetMetadataAmountResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the maximum number of vhosts, exchanges, and queues that you can create and the number of created vhosts, exchanges, and queues on an ApsaraMQ for RabbitMQ instance.
         *
         * @param request GetMetadataAmountRequest
         * @return GetMetadataAmountResponse
         */
        public GetMetadataAmountResponse GetMetadataAmount(GetMetadataAmountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetMetadataAmountWithOptions(request, runtime);
        }

        /**
         * @summary Queries the maximum number of vhosts, exchanges, and queues that you can create and the number of created vhosts, exchanges, and queues on an ApsaraMQ for RabbitMQ instance.
         *
         * @param request GetMetadataAmountRequest
         * @return GetMetadataAmountResponse
         */
        public async Task<GetMetadataAmountResponse> GetMetadataAmountAsync(GetMetadataAmountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetMetadataAmountWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the static username and password of an ApsaraMQ for RabbitMQ.
         *
         * @param request ListAccountsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListAccountsResponse
         */
        public ListAccountsResponse ListAccountsWithOptions(ListAccountsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "ListAccounts",
                Version = "2019-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAccountsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the static username and password of an ApsaraMQ for RabbitMQ.
         *
         * @param request ListAccountsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListAccountsResponse
         */
        public async Task<ListAccountsResponse> ListAccountsWithOptionsAsync(ListAccountsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
                Action = "ListAccounts",
                Version = "2019-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListAccountsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the static username and password of an ApsaraMQ for RabbitMQ.
         *
         * @param request ListAccountsRequest
         * @return ListAccountsResponse
         */
        public ListAccountsResponse ListAccounts(ListAccountsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListAccountsWithOptions(request, runtime);
        }

        /**
         * @summary Queries the static username and password of an ApsaraMQ for RabbitMQ.
         *
         * @param request ListAccountsRequest
         * @return ListAccountsResponse
         */
        public async Task<ListAccountsResponse> ListAccountsAsync(ListAccountsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListAccountsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries all bindings of a virtual host (vhost) on an ApsaraMQ for RabbitMQ instance.
         *
         * @param request ListBindingsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListBindingsResponse
         */
        public ListBindingsResponse ListBindingsWithOptions(ListBindingsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListBindings",
                Version = "2019-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListBindingsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries all bindings of a virtual host (vhost) on an ApsaraMQ for RabbitMQ instance.
         *
         * @param request ListBindingsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListBindingsResponse
         */
        public async Task<ListBindingsResponse> ListBindingsWithOptionsAsync(ListBindingsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListBindings",
                Version = "2019-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListBindingsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries all bindings of a virtual host (vhost) on an ApsaraMQ for RabbitMQ instance.
         *
         * @param request ListBindingsRequest
         * @return ListBindingsResponse
         */
        public ListBindingsResponse ListBindings(ListBindingsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListBindingsWithOptions(request, runtime);
        }

        /**
         * @summary Queries all bindings of a virtual host (vhost) on an ApsaraMQ for RabbitMQ instance.
         *
         * @param request ListBindingsRequest
         * @return ListBindingsResponse
         */
        public async Task<ListBindingsResponse> ListBindingsAsync(ListBindingsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListBindingsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries all exchanges or queues to which an exchange is bound.
         *
         * @param request ListDownStreamBindingsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListDownStreamBindingsResponse
         */
        public ListDownStreamBindingsResponse ListDownStreamBindingsWithOptions(ListDownStreamBindingsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListDownStreamBindings",
                Version = "2019-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDownStreamBindingsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries all exchanges or queues to which an exchange is bound.
         *
         * @param request ListDownStreamBindingsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListDownStreamBindingsResponse
         */
        public async Task<ListDownStreamBindingsResponse> ListDownStreamBindingsWithOptionsAsync(ListDownStreamBindingsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListDownStreamBindings",
                Version = "2019-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListDownStreamBindingsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries all exchanges or queues to which an exchange is bound.
         *
         * @param request ListDownStreamBindingsRequest
         * @return ListDownStreamBindingsResponse
         */
        public ListDownStreamBindingsResponse ListDownStreamBindings(ListDownStreamBindingsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListDownStreamBindingsWithOptions(request, runtime);
        }

        /**
         * @summary Queries all exchanges or queues to which an exchange is bound.
         *
         * @param request ListDownStreamBindingsRequest
         * @return ListDownStreamBindingsResponse
         */
        public async Task<ListDownStreamBindingsResponse> ListDownStreamBindingsAsync(ListDownStreamBindingsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListDownStreamBindingsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries all queues or exchanges that are bound to an exchange.
         *
         * @param request ListExchangeUpStreamBindingsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListExchangeUpStreamBindingsResponse
         */
        public ListExchangeUpStreamBindingsResponse ListExchangeUpStreamBindingsWithOptions(ListExchangeUpStreamBindingsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListExchangeUpStreamBindings",
                Version = "2019-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListExchangeUpStreamBindingsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries all queues or exchanges that are bound to an exchange.
         *
         * @param request ListExchangeUpStreamBindingsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListExchangeUpStreamBindingsResponse
         */
        public async Task<ListExchangeUpStreamBindingsResponse> ListExchangeUpStreamBindingsWithOptionsAsync(ListExchangeUpStreamBindingsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListExchangeUpStreamBindings",
                Version = "2019-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListExchangeUpStreamBindingsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries all queues or exchanges that are bound to an exchange.
         *
         * @param request ListExchangeUpStreamBindingsRequest
         * @return ListExchangeUpStreamBindingsResponse
         */
        public ListExchangeUpStreamBindingsResponse ListExchangeUpStreamBindings(ListExchangeUpStreamBindingsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListExchangeUpStreamBindingsWithOptions(request, runtime);
        }

        /**
         * @summary Queries all queues or exchanges that are bound to an exchange.
         *
         * @param request ListExchangeUpStreamBindingsRequest
         * @return ListExchangeUpStreamBindingsResponse
         */
        public async Task<ListExchangeUpStreamBindingsResponse> ListExchangeUpStreamBindingsAsync(ListExchangeUpStreamBindingsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListExchangeUpStreamBindingsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries all exchanges that are created in a virtual host (vhost).
         *
         * @param request ListExchangesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListExchangesResponse
         */
        public ListExchangesResponse ListExchangesWithOptions(ListExchangesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListExchanges",
                Version = "2019-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListExchangesResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries all exchanges that are created in a virtual host (vhost).
         *
         * @param request ListExchangesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListExchangesResponse
         */
        public async Task<ListExchangesResponse> ListExchangesWithOptionsAsync(ListExchangesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListExchanges",
                Version = "2019-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListExchangesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries all exchanges that are created in a virtual host (vhost).
         *
         * @param request ListExchangesRequest
         * @return ListExchangesResponse
         */
        public ListExchangesResponse ListExchanges(ListExchangesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListExchangesWithOptions(request, runtime);
        }

        /**
         * @summary Queries all exchanges that are created in a virtual host (vhost).
         *
         * @param request ListExchangesRequest
         * @return ListExchangesResponse
         */
        public async Task<ListExchangesResponse> ListExchangesAsync(ListExchangesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListExchangesWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries all AparaMQ for RabbitMQ instances in a region. The returned data includes the basic information, endpoint, and specification limits of each instance.
         *
         * @param request ListInstancesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListInstancesResponse
         */
        public ListInstancesResponse ListInstancesWithOptions(ListInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListInstances",
                Version = "2019-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListInstancesResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries all AparaMQ for RabbitMQ instances in a region. The returned data includes the basic information, endpoint, and specification limits of each instance.
         *
         * @param request ListInstancesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListInstancesResponse
         */
        public async Task<ListInstancesResponse> ListInstancesWithOptionsAsync(ListInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListInstances",
                Version = "2019-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListInstancesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries all AparaMQ for RabbitMQ instances in a region. The returned data includes the basic information, endpoint, and specification limits of each instance.
         *
         * @param request ListInstancesRequest
         * @return ListInstancesResponse
         */
        public ListInstancesResponse ListInstances(ListInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListInstancesWithOptions(request, runtime);
        }

        /**
         * @summary Queries all AparaMQ for RabbitMQ instances in a region. The returned data includes the basic information, endpoint, and specification limits of each instance.
         *
         * @param request ListInstancesRequest
         * @return ListInstancesResponse
         */
        public async Task<ListInstancesResponse> ListInstancesAsync(ListInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListInstancesWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the online consumers of a queue.
         *
         * @description ApsaraMQ for RabbitMQ allows you to query only online consumers.
         *
         * @param request ListQueueConsumersRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListQueueConsumersResponse
         */
        public ListQueueConsumersResponse ListQueueConsumersWithOptions(ListQueueConsumersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListQueueConsumers",
                Version = "2019-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListQueueConsumersResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the online consumers of a queue.
         *
         * @description ApsaraMQ for RabbitMQ allows you to query only online consumers.
         *
         * @param request ListQueueConsumersRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListQueueConsumersResponse
         */
        public async Task<ListQueueConsumersResponse> ListQueueConsumersWithOptionsAsync(ListQueueConsumersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListQueueConsumers",
                Version = "2019-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListQueueConsumersResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the online consumers of a queue.
         *
         * @description ApsaraMQ for RabbitMQ allows you to query only online consumers.
         *
         * @param request ListQueueConsumersRequest
         * @return ListQueueConsumersResponse
         */
        public ListQueueConsumersResponse ListQueueConsumers(ListQueueConsumersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListQueueConsumersWithOptions(request, runtime);
        }

        /**
         * @summary Queries the online consumers of a queue.
         *
         * @description ApsaraMQ for RabbitMQ allows you to query only online consumers.
         *
         * @param request ListQueueConsumersRequest
         * @return ListQueueConsumersResponse
         */
        public async Task<ListQueueConsumersResponse> ListQueueConsumersAsync(ListQueueConsumersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListQueueConsumersWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the exchanges that are bound to a queue.
         *
         * @param request ListQueueUpStreamBindingsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListQueueUpStreamBindingsResponse
         */
        public ListQueueUpStreamBindingsResponse ListQueueUpStreamBindingsWithOptions(ListQueueUpStreamBindingsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListQueueUpStreamBindings",
                Version = "2019-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListQueueUpStreamBindingsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries the exchanges that are bound to a queue.
         *
         * @param request ListQueueUpStreamBindingsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListQueueUpStreamBindingsResponse
         */
        public async Task<ListQueueUpStreamBindingsResponse> ListQueueUpStreamBindingsWithOptionsAsync(ListQueueUpStreamBindingsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListQueueUpStreamBindings",
                Version = "2019-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListQueueUpStreamBindingsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries the exchanges that are bound to a queue.
         *
         * @param request ListQueueUpStreamBindingsRequest
         * @return ListQueueUpStreamBindingsResponse
         */
        public ListQueueUpStreamBindingsResponse ListQueueUpStreamBindings(ListQueueUpStreamBindingsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListQueueUpStreamBindingsWithOptions(request, runtime);
        }

        /**
         * @summary Queries the exchanges that are bound to a queue.
         *
         * @param request ListQueueUpStreamBindingsRequest
         * @return ListQueueUpStreamBindingsResponse
         */
        public async Task<ListQueueUpStreamBindingsResponse> ListQueueUpStreamBindingsAsync(ListQueueUpStreamBindingsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListQueueUpStreamBindingsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries all queues in a vhost of an ApsaraMQ for RabbitMQ instance.
         *
         * @param request ListQueuesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListQueuesResponse
         */
        public ListQueuesResponse ListQueuesWithOptions(ListQueuesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListQueues",
                Version = "2019-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListQueuesResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries all queues in a vhost of an ApsaraMQ for RabbitMQ instance.
         *
         * @param request ListQueuesRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListQueuesResponse
         */
        public async Task<ListQueuesResponse> ListQueuesWithOptionsAsync(ListQueuesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListQueues",
                Version = "2019-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListQueuesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries all queues in a vhost of an ApsaraMQ for RabbitMQ instance.
         *
         * @param request ListQueuesRequest
         * @return ListQueuesResponse
         */
        public ListQueuesResponse ListQueues(ListQueuesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListQueuesWithOptions(request, runtime);
        }

        /**
         * @summary Queries all queues in a vhost of an ApsaraMQ for RabbitMQ instance.
         *
         * @param request ListQueuesRequest
         * @return ListQueuesResponse
         */
        public async Task<ListQueuesResponse> ListQueuesAsync(ListQueuesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListQueuesWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries all virtual hosts (vhosts) on an ApsaraMQ for RabbitMQ instance.
         *
         * @param request ListVirtualHostsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListVirtualHostsResponse
         */
        public ListVirtualHostsResponse ListVirtualHostsWithOptions(ListVirtualHostsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListVirtualHosts",
                Version = "2019-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListVirtualHostsResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Queries all virtual hosts (vhosts) on an ApsaraMQ for RabbitMQ instance.
         *
         * @param request ListVirtualHostsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ListVirtualHostsResponse
         */
        public async Task<ListVirtualHostsResponse> ListVirtualHostsWithOptionsAsync(ListVirtualHostsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListVirtualHosts",
                Version = "2019-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListVirtualHostsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Queries all virtual hosts (vhosts) on an ApsaraMQ for RabbitMQ instance.
         *
         * @param request ListVirtualHostsRequest
         * @return ListVirtualHostsResponse
         */
        public ListVirtualHostsResponse ListVirtualHosts(ListVirtualHostsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListVirtualHostsWithOptions(request, runtime);
        }

        /**
         * @summary Queries all virtual hosts (vhosts) on an ApsaraMQ for RabbitMQ instance.
         *
         * @param request ListVirtualHostsRequest
         * @return ListVirtualHostsResponse
         */
        public async Task<ListVirtualHostsResponse> ListVirtualHostsAsync(ListVirtualHostsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListVirtualHostsWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 变更实例，升降配
         *
         * @param request UpdateInstanceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateInstanceResponse
         */
        public UpdateInstanceResponse UpdateInstanceWithOptions(UpdateInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceType))
            {
                query["InstanceType"] = request.InstanceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxConnections))
            {
                query["MaxConnections"] = request.MaxConnections;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxEipTps))
            {
                query["MaxEipTps"] = request.MaxEipTps;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxPrivateTps))
            {
                query["MaxPrivateTps"] = request.MaxPrivateTps;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModifyType))
            {
                query["ModifyType"] = request.ModifyType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueueCapacity))
            {
                query["QueueCapacity"] = request.QueueCapacity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServerlessChargeType))
            {
                query["ServerlessChargeType"] = request.ServerlessChargeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StorageSize))
            {
                query["StorageSize"] = request.StorageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SupportEip))
            {
                query["SupportEip"] = request.SupportEip;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SupportTracing))
            {
                query["SupportTracing"] = request.SupportTracing;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TracingStorageTime))
            {
                query["TracingStorageTime"] = request.TracingStorageTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateInstance",
                Version = "2019-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateInstanceResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary 变更实例，升降配
         *
         * @param request UpdateInstanceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateInstanceResponse
         */
        public async Task<UpdateInstanceResponse> UpdateInstanceWithOptionsAsync(UpdateInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceType))
            {
                query["InstanceType"] = request.InstanceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxConnections))
            {
                query["MaxConnections"] = request.MaxConnections;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxEipTps))
            {
                query["MaxEipTps"] = request.MaxEipTps;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxPrivateTps))
            {
                query["MaxPrivateTps"] = request.MaxPrivateTps;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ModifyType))
            {
                query["ModifyType"] = request.ModifyType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueueCapacity))
            {
                query["QueueCapacity"] = request.QueueCapacity;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServerlessChargeType))
            {
                query["ServerlessChargeType"] = request.ServerlessChargeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StorageSize))
            {
                query["StorageSize"] = request.StorageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SupportEip))
            {
                query["SupportEip"] = request.SupportEip;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SupportTracing))
            {
                query["SupportTracing"] = request.SupportTracing;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TracingStorageTime))
            {
                query["TracingStorageTime"] = request.TracingStorageTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateInstance",
                Version = "2019-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateInstanceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary 变更实例，升降配
         *
         * @param request UpdateInstanceRequest
         * @return UpdateInstanceResponse
         */
        public UpdateInstanceResponse UpdateInstance(UpdateInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateInstanceWithOptions(request, runtime);
        }

        /**
         * @summary 变更实例，升降配
         *
         * @param request UpdateInstanceRequest
         * @return UpdateInstanceResponse
         */
        public async Task<UpdateInstanceResponse> UpdateInstanceAsync(UpdateInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateInstanceWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Updates the name of an ApsaraMQ for RabbitMQ instance. After an ApsaraMQ for RabbitMQ instance is created, the ID of the instance is used as its name by default. You can specify a custom name for an instance to facilitate instance identification.
         *
         * @param request UpdateInstanceNameRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateInstanceNameResponse
         */
        public UpdateInstanceNameResponse UpdateInstanceNameWithOptions(UpdateInstanceNameRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateInstanceName",
                Version = "2019-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateInstanceNameResponse>(CallApi(params_, req, runtime));
        }

        /**
         * @summary Updates the name of an ApsaraMQ for RabbitMQ instance. After an ApsaraMQ for RabbitMQ instance is created, the ID of the instance is used as its name by default. You can specify a custom name for an instance to facilitate instance identification.
         *
         * @param request UpdateInstanceNameRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UpdateInstanceNameResponse
         */
        public async Task<UpdateInstanceNameResponse> UpdateInstanceNameWithOptionsAsync(UpdateInstanceNameRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateInstanceName",
                Version = "2019-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateInstanceNameResponse>(await CallApiAsync(params_, req, runtime));
        }

        /**
         * @summary Updates the name of an ApsaraMQ for RabbitMQ instance. After an ApsaraMQ for RabbitMQ instance is created, the ID of the instance is used as its name by default. You can specify a custom name for an instance to facilitate instance identification.
         *
         * @param request UpdateInstanceNameRequest
         * @return UpdateInstanceNameResponse
         */
        public UpdateInstanceNameResponse UpdateInstanceName(UpdateInstanceNameRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateInstanceNameWithOptions(request, runtime);
        }

        /**
         * @summary Updates the name of an ApsaraMQ for RabbitMQ instance. After an ApsaraMQ for RabbitMQ instance is created, the ID of the instance is used as its name by default. You can specify a custom name for an instance to facilitate instance identification.
         *
         * @param request UpdateInstanceNameRequest
         * @return UpdateInstanceNameResponse
         */
        public async Task<UpdateInstanceNameResponse> UpdateInstanceNameAsync(UpdateInstanceNameRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateInstanceNameWithOptionsAsync(request, runtime);
        }

    }
}
