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
            this._endpointMap = new Dictionary<string, string>
            {
                {"us-west-1", "amqp-open.us-west-1.aliyuncs.com"},
                {"us-east-1", "amqp-open.us-east-1.aliyuncs.com"},
                {"me-central-1", "amqp-open.me-central-1.aliyuncs.com"},
                {"eu-central-1", "amqp-open.eu-central-1.aliyuncs.com"},
                {"cn-zhengzhou-jva", "amqp-open.cn-zhengzhou-jva.aliyuncs.com"},
                {"cn-zhangjiakou", "amqp-open.cn-zhangjiakou.aliyuncs.com"},
                {"cn-wulanchabu", "amqp-open.cn-wulanchabu.aliyuncs.com"},
                {"cn-shenzhen", "amqp-open.cn-shenzhen.aliyuncs.com"},
                {"cn-shanghai-finance-1", "amqp-open.cn-shanghai-finance-1.aliyuncs.com"},
                {"cn-shanghai", "amqp-open.cn-shanghai.aliyuncs.com"},
                {"cn-qingdao", "amqp-open.cn-qingdao.aliyuncs.com"},
                {"cn-huhehaote", "amqp-open.cn-huhehaote.aliyuncs.com"},
                {"cn-hongkong", "amqp-open.cn-hongkong.aliyuncs.com"},
                {"cn-hangzhou", "amqp-open.cn-hangzhou.aliyuncs.com"},
                {"cn-guangzhou", "amqp-open.cn-guangzhou.aliyuncs.com"},
                {"cn-chengdu", "amqp-open.cn-chengdu.aliyuncs.com"},
                {"cn-beijing-finance-1", "amqp-open.cn-beijing-finance-1.aliyuncs.com"},
                {"cn-beijing", "amqp-open.cn-beijing.aliyuncs.com"},
                {"ap-southeast-7", "amqp-open.ap-southeast-7.aliyuncs.com"},
                {"ap-southeast-6", "amqp-open.ap-southeast-6.aliyuncs.com"},
                {"ap-southeast-5", "amqp-open.ap-southeast-5.aliyuncs.com"},
                {"ap-southeast-3", "amqp-open.ap-southeast-3.aliyuncs.com"},
                {"ap-southeast-1", "amqp-open.ap-southeast-1.aliyuncs.com"},
                {"ap-northeast-1", "amqp-open.ap-northeast-1.aliyuncs.com"},
            };
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Adds an entry to the whitelist of an instance.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// AddInstanceWhiteListRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AddInstanceWhiteListResponse
        /// </returns>
        public AddInstanceWhiteListResponse AddInstanceWhiteListWithOptions(AddInstanceWhiteListRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            AddInstanceWhiteListShrinkRequest request = new AddInstanceWhiteListShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.WhiteListItem))
            {
                request.WhiteListItemShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.WhiteListItem, "WhiteListItem", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WhiteListItemShrink))
            {
                query["WhiteListItem"] = request.WhiteListItemShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WhiteListType))
            {
                query["WhiteListType"] = request.WhiteListType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddInstanceWhiteList",
                Version = "2019-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddInstanceWhiteListResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Adds an entry to the whitelist of an instance.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// AddInstanceWhiteListRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// AddInstanceWhiteListResponse
        /// </returns>
        public async Task<AddInstanceWhiteListResponse> AddInstanceWhiteListWithOptionsAsync(AddInstanceWhiteListRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            AddInstanceWhiteListShrinkRequest request = new AddInstanceWhiteListShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.WhiteListItem))
            {
                request.WhiteListItemShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.WhiteListItem, "WhiteListItem", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WhiteListItemShrink))
            {
                query["WhiteListItem"] = request.WhiteListItemShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WhiteListType))
            {
                query["WhiteListType"] = request.WhiteListType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AddInstanceWhiteList",
                Version = "2019-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AddInstanceWhiteListResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Adds an entry to the whitelist of an instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddInstanceWhiteListRequest
        /// </param>
        /// 
        /// <returns>
        /// AddInstanceWhiteListResponse
        /// </returns>
        public AddInstanceWhiteListResponse AddInstanceWhiteList(AddInstanceWhiteListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddInstanceWhiteListWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Adds an entry to the whitelist of an instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// AddInstanceWhiteListRequest
        /// </param>
        /// 
        /// <returns>
        /// AddInstanceWhiteListResponse
        /// </returns>
        public async Task<AddInstanceWhiteListResponse> AddInstanceWhiteListAsync(AddInstanceWhiteListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddInstanceWhiteListWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>When an open-source client accesses an ApsaraMQ for RabbitMQ server, it must provide a username and password for authentication. ApsaraMQ for RabbitMQ lets you generate a username and password from an AccessKey ID and AccessKey secret provided by Resource Access Management (RAM).</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateAccountRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateAccountResponse
        /// </returns>
        public CreateAccountResponse CreateAccountWithOptions(CreateAccountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Remark))
            {
                query["Remark"] = request.Remark;
            }
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>When an open-source client accesses an ApsaraMQ for RabbitMQ server, it must provide a username and password for authentication. ApsaraMQ for RabbitMQ lets you generate a username and password from an AccessKey ID and AccessKey secret provided by Resource Access Management (RAM).</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateAccountRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateAccountResponse
        /// </returns>
        public async Task<CreateAccountResponse> CreateAccountWithOptionsAsync(CreateAccountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Remark))
            {
                query["Remark"] = request.Remark;
            }
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>When an open-source client accesses an ApsaraMQ for RabbitMQ server, it must provide a username and password for authentication. ApsaraMQ for RabbitMQ lets you generate a username and password from an AccessKey ID and AccessKey secret provided by Resource Access Management (RAM).</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateAccountRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateAccountResponse
        /// </returns>
        public CreateAccountResponse CreateAccount(CreateAccountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateAccountWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>When an open-source client accesses an ApsaraMQ for RabbitMQ server, it must provide a username and password for authentication. ApsaraMQ for RabbitMQ lets you generate a username and password from an AccessKey ID and AccessKey secret provided by Resource Access Management (RAM).</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateAccountRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateAccountResponse
        /// </returns>
        public async Task<CreateAccountResponse> CreateAccountAsync(CreateAccountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateAccountWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>A producer sends a message to an exchange, which then routes the message to a specified queue or another exchange based on the binding and routing rules.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateBindingRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateBindingResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>A producer sends a message to an exchange, which then routes the message to a specified queue or another exchange based on the binding and routing rules.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateBindingRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateBindingResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>A producer sends a message to an exchange, which then routes the message to a specified queue or another exchange based on the binding and routing rules.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateBindingRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateBindingResponse
        /// </returns>
        public CreateBindingResponse CreateBinding(CreateBindingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateBindingWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>A producer sends a message to an exchange, which then routes the message to a specified queue or another exchange based on the binding and routing rules.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateBindingRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateBindingResponse
        /// </returns>
        public async Task<CreateBindingResponse> CreateBindingAsync(CreateBindingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateBindingWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>A producer sends a message to an exchange. The exchange then routes the message to one or more queues based on the routing key and the binding key, or discards the message.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateExchangeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateExchangeResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>A producer sends a message to an exchange. The exchange then routes the message to one or more queues based on the routing key and the binding key, or discards the message.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateExchangeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateExchangeResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>A producer sends a message to an exchange. The exchange then routes the message to one or more queues based on the routing key and the binding key, or discards the message.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateExchangeRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateExchangeResponse
        /// </returns>
        public CreateExchangeResponse CreateExchange(CreateExchangeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateExchangeWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>A producer sends a message to an exchange. The exchange then routes the message to one or more queues based on the routing key and the binding key, or discards the message.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateExchangeRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateExchangeResponse
        /// </returns>
        public async Task<CreateExchangeResponse> CreateExchangeAsync(CreateExchangeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateExchangeWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an ApsaraMQ for RabbitMQ instance.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// CreateInstanceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateInstanceResponse
        /// </returns>
        public CreateInstanceResponse CreateInstanceWithOptions(CreateInstanceRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateInstanceShrinkRequest request = new CreateInstanceShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Tags))
            {
                request.TagsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Tags, "Tags", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.VswitchIds))
            {
                request.VswitchIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.VswitchIds, "VswitchIds", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthModel))
            {
                query["AuthModel"] = request.AuthModel;
            }
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Edition))
            {
                query["Edition"] = request.Edition;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EncryptedInstance))
            {
                query["EncryptedInstance"] = request.EncryptedInstance;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceName))
            {
                query["InstanceName"] = request.InstanceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceType))
            {
                query["InstanceType"] = request.InstanceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KmsKeyId))
            {
                query["KmsKeyId"] = request.KmsKeyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ListenerMode))
            {
                query["ListenerMode"] = request.ListenerMode;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProvisionedCapacity))
            {
                query["ProvisionedCapacity"] = request.ProvisionedCapacity;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityGroupId))
            {
                query["SecurityGroupId"] = request.SecurityGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServerlessChargeType))
            {
                query["ServerlessChargeType"] = request.ServerlessChargeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServerlessSwitch))
            {
                query["ServerlessSwitch"] = request.ServerlessSwitch;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagsShrink))
            {
                query["Tags"] = request.TagsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TracingStorageTime))
            {
                query["TracingStorageTime"] = request.TracingStorageTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcId))
            {
                query["VpcId"] = request.VpcId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VswitchIdsShrink))
            {
                query["VswitchIds"] = request.VswitchIdsShrink;
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an ApsaraMQ for RabbitMQ instance.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// CreateInstanceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateInstanceResponse
        /// </returns>
        public async Task<CreateInstanceResponse> CreateInstanceWithOptionsAsync(CreateInstanceRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateInstanceShrinkRequest request = new CreateInstanceShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Tags))
            {
                request.TagsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Tags, "Tags", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.VswitchIds))
            {
                request.VswitchIdsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.VswitchIds, "VswitchIds", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AuthModel))
            {
                query["AuthModel"] = request.AuthModel;
            }
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Edition))
            {
                query["Edition"] = request.Edition;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EncryptedInstance))
            {
                query["EncryptedInstance"] = request.EncryptedInstance;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceName))
            {
                query["InstanceName"] = request.InstanceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceType))
            {
                query["InstanceType"] = request.InstanceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KmsKeyId))
            {
                query["KmsKeyId"] = request.KmsKeyId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ListenerMode))
            {
                query["ListenerMode"] = request.ListenerMode;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProvisionedCapacity))
            {
                query["ProvisionedCapacity"] = request.ProvisionedCapacity;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ResourceGroupId))
            {
                query["ResourceGroupId"] = request.ResourceGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SecurityGroupId))
            {
                query["SecurityGroupId"] = request.SecurityGroupId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServerlessChargeType))
            {
                query["ServerlessChargeType"] = request.ServerlessChargeType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServerlessSwitch))
            {
                query["ServerlessSwitch"] = request.ServerlessSwitch;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TagsShrink))
            {
                query["Tags"] = request.TagsShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TracingStorageTime))
            {
                query["TracingStorageTime"] = request.TracingStorageTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VpcId))
            {
                query["VpcId"] = request.VpcId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VswitchIdsShrink))
            {
                query["VswitchIds"] = request.VswitchIdsShrink;
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an ApsaraMQ for RabbitMQ instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateInstanceResponse
        /// </returns>
        public CreateInstanceResponse CreateInstance(CreateInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateInstanceWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an ApsaraMQ for RabbitMQ instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateInstanceResponse
        /// </returns>
        public async Task<CreateInstanceResponse> CreateInstanceAsync(CreateInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateInstanceWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an open-source username and password.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateOpenSourceAccountRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateOpenSourceAccountResponse
        /// </returns>
        public CreateOpenSourceAccountResponse CreateOpenSourceAccountWithOptions(CreateOpenSourceAccountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Password))
            {
                query["Password"] = request.Password;
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
                Action = "CreateOpenSourceAccount",
                Version = "2019-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateOpenSourceAccountResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an open-source username and password.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateOpenSourceAccountRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateOpenSourceAccountResponse
        /// </returns>
        public async Task<CreateOpenSourceAccountResponse> CreateOpenSourceAccountWithOptionsAsync(CreateOpenSourceAccountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Password))
            {
                query["Password"] = request.Password;
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
                Action = "CreateOpenSourceAccount",
                Version = "2019-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateOpenSourceAccountResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an open-source username and password.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateOpenSourceAccountRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateOpenSourceAccountResponse
        /// </returns>
        public CreateOpenSourceAccountResponse CreateOpenSourceAccount(CreateOpenSourceAccountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateOpenSourceAccountWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an open-source username and password.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateOpenSourceAccountRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateOpenSourceAccountResponse
        /// </returns>
        public async Task<CreateOpenSourceAccountResponse> CreateOpenSourceAccountAsync(CreateOpenSourceAccountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateOpenSourceAccountWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an open source permission.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateOpenSourcePermissionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateOpenSourcePermissionResponse
        /// </returns>
        public CreateOpenSourcePermissionResponse CreateOpenSourcePermissionWithOptions(CreateOpenSourcePermissionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Configure))
            {
                query["Configure"] = request.Configure;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Read))
            {
                query["Read"] = request.Read;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserName))
            {
                query["UserName"] = request.UserName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Vhost))
            {
                query["Vhost"] = request.Vhost;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Write))
            {
                query["Write"] = request.Write;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateOpenSourcePermission",
                Version = "2019-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateOpenSourcePermissionResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an open source permission.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateOpenSourcePermissionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateOpenSourcePermissionResponse
        /// </returns>
        public async Task<CreateOpenSourcePermissionResponse> CreateOpenSourcePermissionWithOptionsAsync(CreateOpenSourcePermissionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Configure))
            {
                query["Configure"] = request.Configure;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Read))
            {
                query["Read"] = request.Read;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserName))
            {
                query["UserName"] = request.UserName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Vhost))
            {
                query["Vhost"] = request.Vhost;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Write))
            {
                query["Write"] = request.Write;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateOpenSourcePermission",
                Version = "2019-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateOpenSourcePermissionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an open source permission.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateOpenSourcePermissionRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateOpenSourcePermissionResponse
        /// </returns>
        public CreateOpenSourcePermissionResponse CreateOpenSourcePermission(CreateOpenSourcePermissionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateOpenSourcePermissionWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates an open source permission.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateOpenSourcePermissionRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateOpenSourcePermissionResponse
        /// </returns>
        public async Task<CreateOpenSourcePermissionResponse> CreateOpenSourcePermissionAsync(CreateOpenSourcePermissionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateOpenSourcePermissionWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>A queue is a buffer that stores messages. In ApsaraMQ for RabbitMQ, messages are sent to a specified exchange and then routed to a bound queue.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateQueueRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateQueueResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>A queue is a buffer that stores messages. In ApsaraMQ for RabbitMQ, messages are sent to a specified exchange and then routed to a bound queue.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateQueueRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateQueueResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>A queue is a buffer that stores messages. In ApsaraMQ for RabbitMQ, messages are sent to a specified exchange and then routed to a bound queue.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateQueueRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateQueueResponse
        /// </returns>
        public CreateQueueResponse CreateQueue(CreateQueueRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateQueueWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>A queue is a buffer that stores messages. In ApsaraMQ for RabbitMQ, messages are sent to a specified exchange and then routed to a bound queue.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateQueueRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateQueueResponse
        /// </returns>
        public async Task<CreateQueueResponse> CreateQueueAsync(CreateQueueRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateQueueWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a vhost. A vhost is used to logically isolate resources. Each vhost manages its own exchanges, queues, and bindings. Applications can run on independent vhosts in a secure manner. This way, the business of an application is not affected by other applications. Before you connect producers and consumers to an ApsaraMQ for RabbitMQ instance, you must specify vhosts for the producers and consumers.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateVirtualHostRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateVirtualHostResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a vhost. A vhost is used to logically isolate resources. Each vhost manages its own exchanges, queues, and bindings. Applications can run on independent vhosts in a secure manner. This way, the business of an application is not affected by other applications. Before you connect producers and consumers to an ApsaraMQ for RabbitMQ instance, you must specify vhosts for the producers and consumers.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateVirtualHostRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateVirtualHostResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a vhost. A vhost is used to logically isolate resources. Each vhost manages its own exchanges, queues, and bindings. Applications can run on independent vhosts in a secure manner. This way, the business of an application is not affected by other applications. Before you connect producers and consumers to an ApsaraMQ for RabbitMQ instance, you must specify vhosts for the producers and consumers.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateVirtualHostRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateVirtualHostResponse
        /// </returns>
        public CreateVirtualHostResponse CreateVirtualHost(CreateVirtualHostRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateVirtualHostWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a vhost. A vhost is used to logically isolate resources. Each vhost manages its own exchanges, queues, and bindings. Applications can run on independent vhosts in a secure manner. This way, the business of an application is not affected by other applications. Before you connect producers and consumers to an ApsaraMQ for RabbitMQ instance, you must specify vhosts for the producers and consumers.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateVirtualHostRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateVirtualHostResponse
        /// </returns>
        public async Task<CreateVirtualHostResponse> CreateVirtualHostAsync(CreateVirtualHostRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateVirtualHostWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a static username and password.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteAccountRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteAccountResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a static username and password.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteAccountRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteAccountResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a static username and password.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteAccountRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteAccountResponse
        /// </returns>
        public DeleteAccountResponse DeleteAccount(DeleteAccountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteAccountWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a static username and password.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteAccountRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteAccountResponse
        /// </returns>
        public async Task<DeleteAccountResponse> DeleteAccountAsync(DeleteAccountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteAccountWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>The DeleteBinding operation detaches a source exchange from a target queue or another exchange.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteBindingRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteBindingResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>The DeleteBinding operation detaches a source exchange from a target queue or another exchange.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteBindingRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteBindingResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>The DeleteBinding operation detaches a source exchange from a target queue or another exchange.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteBindingRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteBindingResponse
        /// </returns>
        public DeleteBindingResponse DeleteBinding(DeleteBindingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteBindingWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>The DeleteBinding operation detaches a source exchange from a target queue or another exchange.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteBindingRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteBindingResponse
        /// </returns>
        public async Task<DeleteBindingResponse> DeleteBindingAsync(DeleteBindingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteBindingWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an exchange.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Usage notes</h2>
        /// <list type="bullet">
        /// <item><description>You cannot delete exchanges with the type <b>headers</b>.</description></item>
        /// <item><description>You cannot delete the three built-in exchanges in a vhost: amq.direct, amq.topic, or amq.fanout.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteExchangeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteExchangeResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an exchange.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Usage notes</h2>
        /// <list type="bullet">
        /// <item><description>You cannot delete exchanges with the type <b>headers</b>.</description></item>
        /// <item><description>You cannot delete the three built-in exchanges in a vhost: amq.direct, amq.topic, or amq.fanout.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteExchangeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteExchangeResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an exchange.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Usage notes</h2>
        /// <list type="bullet">
        /// <item><description>You cannot delete exchanges with the type <b>headers</b>.</description></item>
        /// <item><description>You cannot delete the three built-in exchanges in a vhost: amq.direct, amq.topic, or amq.fanout.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteExchangeRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteExchangeResponse
        /// </returns>
        public DeleteExchangeResponse DeleteExchange(DeleteExchangeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteExchangeWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an exchange.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Usage notes</h2>
        /// <list type="bullet">
        /// <item><description>You cannot delete exchanges with the type <b>headers</b>.</description></item>
        /// <item><description>You cannot delete the three built-in exchanges in a vhost: amq.direct, amq.topic, or amq.fanout.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteExchangeRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteExchangeResponse
        /// </returns>
        public async Task<DeleteExchangeResponse> DeleteExchangeAsync(DeleteExchangeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteExchangeWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes the username and password of an open-source user.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteOpenSourceAccountRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteOpenSourceAccountResponse
        /// </returns>
        public DeleteOpenSourceAccountResponse DeleteOpenSourceAccountWithOptions(DeleteOpenSourceAccountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
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
                Action = "DeleteOpenSourceAccount",
                Version = "2019-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteOpenSourceAccountResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes the username and password of an open-source user.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteOpenSourceAccountRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteOpenSourceAccountResponse
        /// </returns>
        public async Task<DeleteOpenSourceAccountResponse> DeleteOpenSourceAccountWithOptionsAsync(DeleteOpenSourceAccountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
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
                Action = "DeleteOpenSourceAccount",
                Version = "2019-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteOpenSourceAccountResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes the username and password of an open-source user.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteOpenSourceAccountRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteOpenSourceAccountResponse
        /// </returns>
        public DeleteOpenSourceAccountResponse DeleteOpenSourceAccount(DeleteOpenSourceAccountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteOpenSourceAccountWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes the username and password of an open-source user.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteOpenSourceAccountRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteOpenSourceAccountResponse
        /// </returns>
        public async Task<DeleteOpenSourceAccountResponse> DeleteOpenSourceAccountAsync(DeleteOpenSourceAccountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteOpenSourceAccountWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an open source permission.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteOpenSourcePermissionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteOpenSourcePermissionResponse
        /// </returns>
        public DeleteOpenSourcePermissionResponse DeleteOpenSourcePermissionWithOptions(DeleteOpenSourcePermissionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserName))
            {
                query["UserName"] = request.UserName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Vhost))
            {
                query["Vhost"] = request.Vhost;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteOpenSourcePermission",
                Version = "2019-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteOpenSourcePermissionResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an open source permission.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteOpenSourcePermissionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteOpenSourcePermissionResponse
        /// </returns>
        public async Task<DeleteOpenSourcePermissionResponse> DeleteOpenSourcePermissionWithOptionsAsync(DeleteOpenSourcePermissionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserName))
            {
                query["UserName"] = request.UserName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Vhost))
            {
                query["Vhost"] = request.Vhost;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteOpenSourcePermission",
                Version = "2019-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteOpenSourcePermissionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an open source permission.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteOpenSourcePermissionRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteOpenSourcePermissionResponse
        /// </returns>
        public DeleteOpenSourcePermissionResponse DeleteOpenSourcePermission(DeleteOpenSourcePermissionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteOpenSourcePermissionWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes an open source permission.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteOpenSourcePermissionRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteOpenSourcePermissionResponse
        /// </returns>
        public async Task<DeleteOpenSourcePermissionResponse> DeleteOpenSourcePermissionAsync(DeleteOpenSourcePermissionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteOpenSourcePermissionWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a queue.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteQueueRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteQueueResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a queue.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteQueueRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteQueueResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a queue.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteQueueRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteQueueResponse
        /// </returns>
        public DeleteQueueResponse DeleteQueue(DeleteQueueRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteQueueWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a queue.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteQueueRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteQueueResponse
        /// </returns>
        public async Task<DeleteQueueResponse> DeleteQueueAsync(DeleteQueueRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteQueueWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a virtual host (vhost).</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you delete a vhost, you must delete all exchanges and queues in it.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteVirtualHostRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteVirtualHostResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a virtual host (vhost).</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you delete a vhost, you must delete all exchanges and queues in it.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteVirtualHostRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteVirtualHostResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a virtual host (vhost).</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you delete a vhost, you must delete all exchanges and queues in it.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteVirtualHostRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteVirtualHostResponse
        /// </returns>
        public DeleteVirtualHostResponse DeleteVirtualHost(DeleteVirtualHostRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteVirtualHostWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a virtual host (vhost).</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you delete a vhost, you must delete all exchanges and queues in it.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteVirtualHostRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteVirtualHostResponse
        /// </returns>
        public async Task<DeleteVirtualHostResponse> DeleteVirtualHostAsync(DeleteVirtualHostRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteVirtualHostWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the details of an ApsaraMQ for RabbitMQ instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetInstanceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetInstanceResponse
        /// </returns>
        public GetInstanceResponse GetInstanceWithOptions(GetInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetInstance",
                Version = "2019-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetInstanceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the details of an ApsaraMQ for RabbitMQ instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetInstanceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetInstanceResponse
        /// </returns>
        public async Task<GetInstanceResponse> GetInstanceWithOptionsAsync(GetInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetInstance",
                Version = "2019-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetInstanceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the details of an ApsaraMQ for RabbitMQ instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// GetInstanceResponse
        /// </returns>
        public GetInstanceResponse GetInstance(GetInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetInstanceWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the details of an ApsaraMQ for RabbitMQ instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// GetInstanceResponse
        /// </returns>
        public async Task<GetInstanceResponse> GetInstanceAsync(GetInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetInstanceWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the current and maximum numbers of vhosts, exchanges, and queues for a specified ApsaraMQ for RabbitMQ instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetMetadataAmountRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetMetadataAmountResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the current and maximum numbers of vhosts, exchanges, and queues for a specified ApsaraMQ for RabbitMQ instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetMetadataAmountRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetMetadataAmountResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the current and maximum numbers of vhosts, exchanges, and queues for a specified ApsaraMQ for RabbitMQ instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetMetadataAmountRequest
        /// </param>
        /// 
        /// <returns>
        /// GetMetadataAmountResponse
        /// </returns>
        public GetMetadataAmountResponse GetMetadataAmount(GetMetadataAmountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetMetadataAmountWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the current and maximum numbers of vhosts, exchanges, and queues for a specified ApsaraMQ for RabbitMQ instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetMetadataAmountRequest
        /// </param>
        /// 
        /// <returns>
        /// GetMetadataAmountResponse
        /// </returns>
        public async Task<GetMetadataAmountResponse> GetMetadataAmountAsync(GetMetadataAmountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetMetadataAmountWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Lists the usernames and passwords for a specified ApsaraMQ for RabbitMQ instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAccountsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListAccountsResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Lists the usernames and passwords for a specified ApsaraMQ for RabbitMQ instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAccountsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListAccountsResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Lists the usernames and passwords for a specified ApsaraMQ for RabbitMQ instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAccountsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListAccountsResponse
        /// </returns>
        public ListAccountsResponse ListAccounts(ListAccountsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListAccountsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Lists the usernames and passwords for a specified ApsaraMQ for RabbitMQ instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListAccountsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListAccountsResponse
        /// </returns>
        public async Task<ListAccountsResponse> ListAccountsAsync(ListAccountsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListAccountsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries all bindings that are created in a vhost of a specified ApsaraMQ for RabbitMQ instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListBindingsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListBindingsResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries all bindings that are created in a vhost of a specified ApsaraMQ for RabbitMQ instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListBindingsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListBindingsResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries all bindings that are created in a vhost of a specified ApsaraMQ for RabbitMQ instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListBindingsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListBindingsResponse
        /// </returns>
        public ListBindingsResponse ListBindings(ListBindingsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListBindingsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries all bindings that are created in a vhost of a specified ApsaraMQ for RabbitMQ instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListBindingsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListBindingsResponse
        /// </returns>
        public async Task<ListBindingsResponse> ListBindingsAsync(ListBindingsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListBindingsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the exchanges or queues that are bound to a specified exchange.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListDownStreamBindingsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListDownStreamBindingsResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the exchanges or queues that are bound to a specified exchange.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListDownStreamBindingsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListDownStreamBindingsResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the exchanges or queues that are bound to a specified exchange.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListDownStreamBindingsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListDownStreamBindingsResponse
        /// </returns>
        public ListDownStreamBindingsResponse ListDownStreamBindings(ListDownStreamBindingsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListDownStreamBindingsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the exchanges or queues that are bound to a specified exchange.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListDownStreamBindingsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListDownStreamBindingsResponse
        /// </returns>
        public async Task<ListDownStreamBindingsResponse> ListDownStreamBindingsAsync(ListDownStreamBindingsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListDownStreamBindingsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the queues or other exchanges that are bound to a specified exchange.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListExchangeUpStreamBindingsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListExchangeUpStreamBindingsResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the queues or other exchanges that are bound to a specified exchange.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListExchangeUpStreamBindingsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListExchangeUpStreamBindingsResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the queues or other exchanges that are bound to a specified exchange.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListExchangeUpStreamBindingsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListExchangeUpStreamBindingsResponse
        /// </returns>
        public ListExchangeUpStreamBindingsResponse ListExchangeUpStreamBindings(ListExchangeUpStreamBindingsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListExchangeUpStreamBindingsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the queues or other exchanges that are bound to a specified exchange.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListExchangeUpStreamBindingsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListExchangeUpStreamBindingsResponse
        /// </returns>
        public async Task<ListExchangeUpStreamBindingsResponse> ListExchangeUpStreamBindingsAsync(ListExchangeUpStreamBindingsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListExchangeUpStreamBindingsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Lists all exchanges in a specified vhost of an instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListExchangesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListExchangesResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Lists all exchanges in a specified vhost of an instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListExchangesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListExchangesResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Lists all exchanges in a specified vhost of an instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListExchangesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListExchangesResponse
        /// </returns>
        public ListExchangesResponse ListExchanges(ListExchangesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListExchangesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Lists all exchanges in a specified vhost of an instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListExchangesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListExchangesResponse
        /// </returns>
        public async Task<ListExchangesResponse> ListExchangesAsync(ListExchangesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListExchangesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the IP or VPC whitelist for an instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListInstanceWhiteListRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListInstanceWhiteListResponse
        /// </returns>
        public ListInstanceWhiteListResponse ListInstanceWhiteListWithOptions(ListInstanceWhiteListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WhiteListType))
            {
                query["whiteListType"] = request.WhiteListType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListInstanceWhiteList",
                Version = "2019-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListInstanceWhiteListResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the IP or VPC whitelist for an instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListInstanceWhiteListRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListInstanceWhiteListResponse
        /// </returns>
        public async Task<ListInstanceWhiteListResponse> ListInstanceWhiteListWithOptionsAsync(ListInstanceWhiteListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WhiteListType))
            {
                query["whiteListType"] = request.WhiteListType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListInstanceWhiteList",
                Version = "2019-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListInstanceWhiteListResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the IP or VPC whitelist for an instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListInstanceWhiteListRequest
        /// </param>
        /// 
        /// <returns>
        /// ListInstanceWhiteListResponse
        /// </returns>
        public ListInstanceWhiteListResponse ListInstanceWhiteList(ListInstanceWhiteListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListInstanceWhiteListWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the IP or VPC whitelist for an instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListInstanceWhiteListRequest
        /// </param>
        /// 
        /// <returns>
        /// ListInstanceWhiteListResponse
        /// </returns>
        public async Task<ListInstanceWhiteListResponse> ListInstanceWhiteListAsync(ListInstanceWhiteListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListInstanceWhiteListWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of ApsaraMQ for RabbitMQ instances in a specified region and returns basic information about each instance, such as its endpoints and specification limits.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListInstancesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListInstancesResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of ApsaraMQ for RabbitMQ instances in a specified region and returns basic information about each instance, such as its endpoints and specification limits.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListInstancesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListInstancesResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of ApsaraMQ for RabbitMQ instances in a specified region and returns basic information about each instance, such as its endpoints and specification limits.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListInstancesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListInstancesResponse
        /// </returns>
        public ListInstancesResponse ListInstances(ListInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListInstancesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of ApsaraMQ for RabbitMQ instances in a specified region and returns basic information about each instance, such as its endpoints and specification limits.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListInstancesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListInstancesResponse
        /// </returns>
        public async Task<ListInstancesResponse> ListInstancesAsync(ListInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListInstancesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Enumerates open-source usernames and passwords.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListOpenSourceAccountsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListOpenSourceAccountsResponse
        /// </returns>
        public ListOpenSourceAccountsResponse ListOpenSourceAccountsWithOptions(ListOpenSourceAccountsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
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
                Action = "ListOpenSourceAccounts",
                Version = "2019-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListOpenSourceAccountsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Enumerates open-source usernames and passwords.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListOpenSourceAccountsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListOpenSourceAccountsResponse
        /// </returns>
        public async Task<ListOpenSourceAccountsResponse> ListOpenSourceAccountsWithOptionsAsync(ListOpenSourceAccountsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
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
                Action = "ListOpenSourceAccounts",
                Version = "2019-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListOpenSourceAccountsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Enumerates open-source usernames and passwords.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListOpenSourceAccountsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListOpenSourceAccountsResponse
        /// </returns>
        public ListOpenSourceAccountsResponse ListOpenSourceAccounts(ListOpenSourceAccountsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListOpenSourceAccountsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Enumerates open-source usernames and passwords.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListOpenSourceAccountsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListOpenSourceAccountsResponse
        /// </returns>
        public async Task<ListOpenSourceAccountsResponse> ListOpenSourceAccountsAsync(ListOpenSourceAccountsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListOpenSourceAccountsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Lists open source permissions.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListOpenSourcePermissionsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListOpenSourcePermissionsResponse
        /// </returns>
        public ListOpenSourcePermissionsResponse ListOpenSourcePermissionsWithOptions(ListOpenSourcePermissionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
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
                Action = "ListOpenSourcePermissions",
                Version = "2019-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListOpenSourcePermissionsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Lists open source permissions.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListOpenSourcePermissionsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListOpenSourcePermissionsResponse
        /// </returns>
        public async Task<ListOpenSourcePermissionsResponse> ListOpenSourcePermissionsWithOptionsAsync(ListOpenSourcePermissionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["MaxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["NextToken"] = request.NextToken;
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
                Action = "ListOpenSourcePermissions",
                Version = "2019-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListOpenSourcePermissionsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Lists open source permissions.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListOpenSourcePermissionsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListOpenSourcePermissionsResponse
        /// </returns>
        public ListOpenSourcePermissionsResponse ListOpenSourcePermissions(ListOpenSourcePermissionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListOpenSourcePermissionsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Lists open source permissions.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListOpenSourcePermissionsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListOpenSourcePermissionsResponse
        /// </returns>
        public async Task<ListOpenSourcePermissionsResponse> ListOpenSourcePermissionsAsync(ListOpenSourcePermissionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListOpenSourcePermissionsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the online consumer clients of a specified queue.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>ApsaraMQ for RabbitMQ lets you query only online consumer clients. You cannot query offline consumer clients.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListQueueConsumersRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListQueueConsumersResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the online consumer clients of a specified queue.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>ApsaraMQ for RabbitMQ lets you query only online consumer clients. You cannot query offline consumer clients.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListQueueConsumersRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListQueueConsumersResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the online consumer clients of a specified queue.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>ApsaraMQ for RabbitMQ lets you query only online consumer clients. You cannot query offline consumer clients.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListQueueConsumersRequest
        /// </param>
        /// 
        /// <returns>
        /// ListQueueConsumersResponse
        /// </returns>
        public ListQueueConsumersResponse ListQueueConsumers(ListQueueConsumersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListQueueConsumersWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the online consumer clients of a specified queue.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>ApsaraMQ for RabbitMQ lets you query only online consumer clients. You cannot query offline consumer clients.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListQueueConsumersRequest
        /// </param>
        /// 
        /// <returns>
        /// ListQueueConsumersResponse
        /// </returns>
        public async Task<ListQueueConsumersResponse> ListQueueConsumersAsync(ListQueueConsumersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListQueueConsumersWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the exchanges that are bound to a specified queue.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListQueueUpStreamBindingsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListQueueUpStreamBindingsResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the exchanges that are bound to a specified queue.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListQueueUpStreamBindingsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListQueueUpStreamBindingsResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the exchanges that are bound to a specified queue.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListQueueUpStreamBindingsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListQueueUpStreamBindingsResponse
        /// </returns>
        public ListQueueUpStreamBindingsResponse ListQueueUpStreamBindings(ListQueueUpStreamBindingsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListQueueUpStreamBindingsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the exchanges that are bound to a specified queue.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListQueueUpStreamBindingsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListQueueUpStreamBindingsResponse
        /// </returns>
        public async Task<ListQueueUpStreamBindingsResponse> ListQueueUpStreamBindingsAsync(ListQueueUpStreamBindingsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListQueueUpStreamBindingsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries information about all queues in a vhost on a specified ApsaraMQ for RabbitMQ instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListQueuesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListQueuesResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries information about all queues in a vhost on a specified ApsaraMQ for RabbitMQ instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListQueuesRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListQueuesResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries information about all queues in a vhost on a specified ApsaraMQ for RabbitMQ instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListQueuesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListQueuesResponse
        /// </returns>
        public ListQueuesResponse ListQueues(ListQueuesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListQueuesWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries information about all queues in a vhost on a specified ApsaraMQ for RabbitMQ instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListQueuesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListQueuesResponse
        /// </returns>
        public async Task<ListQueuesResponse> ListQueuesAsync(ListQueuesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListQueuesWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Lists all vhosts in a specified ApsaraMQ for RabbitMQ instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListVirtualHostsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListVirtualHostsResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Lists all vhosts in a specified ApsaraMQ for RabbitMQ instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListVirtualHostsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListVirtualHostsResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Lists all vhosts in a specified ApsaraMQ for RabbitMQ instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListVirtualHostsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListVirtualHostsResponse
        /// </returns>
        public ListVirtualHostsResponse ListVirtualHosts(ListVirtualHostsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListVirtualHostsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Lists all vhosts in a specified ApsaraMQ for RabbitMQ instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListVirtualHostsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListVirtualHostsResponse
        /// </returns>
        public async Task<ListVirtualHostsResponse> ListVirtualHostsAsync(ListVirtualHostsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListVirtualHostsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Removes an IP address or a VPC from an instance\&quot;s whitelist.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RemoveInstanceWhiteListRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RemoveInstanceWhiteListResponse
        /// </returns>
        public RemoveInstanceWhiteListResponse RemoveInstanceWhiteListWithOptions(RemoveInstanceWhiteListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WhiteListItemId))
            {
                query["whiteListItemId"] = request.WhiteListItemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WhiteListType))
            {
                query["whiteListType"] = request.WhiteListType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RemoveInstanceWhiteList",
                Version = "2019-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RemoveInstanceWhiteListResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Removes an IP address or a VPC from an instance\&quot;s whitelist.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RemoveInstanceWhiteListRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RemoveInstanceWhiteListResponse
        /// </returns>
        public async Task<RemoveInstanceWhiteListResponse> RemoveInstanceWhiteListWithOptionsAsync(RemoveInstanceWhiteListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WhiteListItemId))
            {
                query["whiteListItemId"] = request.WhiteListItemId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WhiteListType))
            {
                query["whiteListType"] = request.WhiteListType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RemoveInstanceWhiteList",
                Version = "2019-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<RemoveInstanceWhiteListResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Removes an IP address or a VPC from an instance\&quot;s whitelist.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RemoveInstanceWhiteListRequest
        /// </param>
        /// 
        /// <returns>
        /// RemoveInstanceWhiteListResponse
        /// </returns>
        public RemoveInstanceWhiteListResponse RemoveInstanceWhiteList(RemoveInstanceWhiteListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RemoveInstanceWhiteListWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Removes an IP address or a VPC from an instance\&quot;s whitelist.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RemoveInstanceWhiteListRequest
        /// </param>
        /// 
        /// <returns>
        /// RemoveInstanceWhiteListResponse
        /// </returns>
        public async Task<RemoveInstanceWhiteListResponse> RemoveInstanceWhiteListAsync(RemoveInstanceWhiteListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RemoveInstanceWhiteListWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Upgrades or downgrades the specifications of an ApsaraMQ for RabbitMQ instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateInstanceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateInstanceResponse
        /// </returns>
        public UpdateInstanceResponse UpdateInstanceWithOptions(UpdateInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Edition))
            {
                query["Edition"] = request.Edition;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EncryptedInstance))
            {
                query["EncryptedInstance"] = request.EncryptedInstance;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceType))
            {
                query["InstanceType"] = request.InstanceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KmsKeyId))
            {
                query["KmsKeyId"] = request.KmsKeyId;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProvisionedCapacity))
            {
                query["ProvisionedCapacity"] = request.ProvisionedCapacity;
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Upgrades or downgrades the specifications of an ApsaraMQ for RabbitMQ instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateInstanceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateInstanceResponse
        /// </returns>
        public async Task<UpdateInstanceResponse> UpdateInstanceWithOptionsAsync(UpdateInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Edition))
            {
                query["Edition"] = request.Edition;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EncryptedInstance))
            {
                query["EncryptedInstance"] = request.EncryptedInstance;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceType))
            {
                query["InstanceType"] = request.InstanceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KmsKeyId))
            {
                query["KmsKeyId"] = request.KmsKeyId;
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProvisionedCapacity))
            {
                query["ProvisionedCapacity"] = request.ProvisionedCapacity;
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Upgrades or downgrades the specifications of an ApsaraMQ for RabbitMQ instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateInstanceResponse
        /// </returns>
        public UpdateInstanceResponse UpdateInstance(UpdateInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateInstanceWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Upgrades or downgrades the specifications of an ApsaraMQ for RabbitMQ instance.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateInstanceResponse
        /// </returns>
        public async Task<UpdateInstanceResponse> UpdateInstanceAsync(UpdateInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateInstanceWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>An ApsaraMQ for RabbitMQ instance is named after its instance ID by default. You can change the name for easier identification.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateInstanceNameRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateInstanceNameResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>An ApsaraMQ for RabbitMQ instance is named after its instance ID by default. You can change the name for easier identification.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateInstanceNameRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateInstanceNameResponse
        /// </returns>
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>An ApsaraMQ for RabbitMQ instance is named after its instance ID by default. You can change the name for easier identification.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateInstanceNameRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateInstanceNameResponse
        /// </returns>
        public UpdateInstanceNameResponse UpdateInstanceName(UpdateInstanceNameRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateInstanceNameWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>An ApsaraMQ for RabbitMQ instance is named after its instance ID by default. You can change the name for easier identification.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateInstanceNameRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateInstanceNameResponse
        /// </returns>
        public async Task<UpdateInstanceNameResponse> UpdateInstanceNameAsync(UpdateInstanceNameRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateInstanceNameWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Update serverless switch</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateInstanceServerlessSwitchRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateInstanceServerlessSwitchResponse
        /// </returns>
        public UpdateInstanceServerlessSwitchResponse UpdateInstanceServerlessSwitchWithOptions(UpdateInstanceServerlessSwitchRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServerlessSwitch))
            {
                query["ServerlessSwitch"] = request.ServerlessSwitch;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateInstanceServerlessSwitch",
                Version = "2019-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateInstanceServerlessSwitchResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Update serverless switch</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateInstanceServerlessSwitchRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateInstanceServerlessSwitchResponse
        /// </returns>
        public async Task<UpdateInstanceServerlessSwitchResponse> UpdateInstanceServerlessSwitchWithOptionsAsync(UpdateInstanceServerlessSwitchRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServerlessSwitch))
            {
                query["ServerlessSwitch"] = request.ServerlessSwitch;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateInstanceServerlessSwitch",
                Version = "2019-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateInstanceServerlessSwitchResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Update serverless switch</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateInstanceServerlessSwitchRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateInstanceServerlessSwitchResponse
        /// </returns>
        public UpdateInstanceServerlessSwitchResponse UpdateInstanceServerlessSwitch(UpdateInstanceServerlessSwitchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateInstanceServerlessSwitchWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Update serverless switch</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateInstanceServerlessSwitchRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateInstanceServerlessSwitchResponse
        /// </returns>
        public async Task<UpdateInstanceServerlessSwitchResponse> UpdateInstanceServerlessSwitchAsync(UpdateInstanceServerlessSwitchRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateInstanceServerlessSwitchWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the username and password for open-source access.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateOpenSourceAccountRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateOpenSourceAccountResponse
        /// </returns>
        public UpdateOpenSourceAccountResponse UpdateOpenSourceAccountWithOptions(UpdateOpenSourceAccountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Password))
            {
                query["Password"] = request.Password;
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
                Action = "UpdateOpenSourceAccount",
                Version = "2019-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateOpenSourceAccountResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the username and password for open-source access.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateOpenSourceAccountRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateOpenSourceAccountResponse
        /// </returns>
        public async Task<UpdateOpenSourceAccountResponse> UpdateOpenSourceAccountWithOptionsAsync(UpdateOpenSourceAccountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                query["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Password))
            {
                query["Password"] = request.Password;
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
                Action = "UpdateOpenSourceAccount",
                Version = "2019-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateOpenSourceAccountResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the username and password for open-source access.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateOpenSourceAccountRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateOpenSourceAccountResponse
        /// </returns>
        public UpdateOpenSourceAccountResponse UpdateOpenSourceAccount(UpdateOpenSourceAccountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateOpenSourceAccountWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the username and password for open-source access.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateOpenSourceAccountRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateOpenSourceAccountResponse
        /// </returns>
        public async Task<UpdateOpenSourceAccountResponse> UpdateOpenSourceAccountAsync(UpdateOpenSourceAccountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateOpenSourceAccountWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates open source permissions.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateOpenSourcePermissionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateOpenSourcePermissionResponse
        /// </returns>
        public UpdateOpenSourcePermissionResponse UpdateOpenSourcePermissionWithOptions(UpdateOpenSourcePermissionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Configure))
            {
                query["Configure"] = request.Configure;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Read))
            {
                query["Read"] = request.Read;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserName))
            {
                query["UserName"] = request.UserName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Vhost))
            {
                query["Vhost"] = request.Vhost;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Write))
            {
                query["Write"] = request.Write;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateOpenSourcePermission",
                Version = "2019-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateOpenSourcePermissionResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates open source permissions.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateOpenSourcePermissionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateOpenSourcePermissionResponse
        /// </returns>
        public async Task<UpdateOpenSourcePermissionResponse> UpdateOpenSourcePermissionWithOptionsAsync(UpdateOpenSourcePermissionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Configure))
            {
                query["Configure"] = request.Configure;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Read))
            {
                query["Read"] = request.Read;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserName))
            {
                query["UserName"] = request.UserName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Vhost))
            {
                query["Vhost"] = request.Vhost;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Write))
            {
                query["Write"] = request.Write;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateOpenSourcePermission",
                Version = "2019-12-12",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateOpenSourcePermissionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates open source permissions.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateOpenSourcePermissionRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateOpenSourcePermissionResponse
        /// </returns>
        public UpdateOpenSourcePermissionResponse UpdateOpenSourcePermission(UpdateOpenSourcePermissionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateOpenSourcePermissionWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates open source permissions.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateOpenSourcePermissionRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateOpenSourcePermissionResponse
        /// </returns>
        public async Task<UpdateOpenSourcePermissionResponse> UpdateOpenSourcePermissionAsync(UpdateOpenSourcePermissionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateOpenSourcePermissionWithOptionsAsync(request, runtime);
        }

    }
}
