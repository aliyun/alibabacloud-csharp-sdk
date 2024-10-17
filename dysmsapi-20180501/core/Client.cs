// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Dysmsapi20180501.Models;

namespace AlibabaCloud.SDK.Dysmsapi20180501
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "central";
            this._endpointMap = new Dictionary<string, string>
            {
                {"ap-southeast-1", "dysmsapi.ap-southeast-1.aliyuncs.com"},
                {"ap-southeast-5", "dysmsapi.ap-southeast-5.aliyuncs.com"},
                {"cn-beijing", "dysmsapi-proxy.cn-beijing.aliyuncs.com"},
                {"cn-hongkong", "dysmsapi-xman.cn-hongkong.aliyuncs.com"},
                {"eu-central-1", "dysmsapi.eu-central-1.aliyuncs.com"},
                {"us-east-1", "dysmsapi.us-east-1.aliyuncs.com"},
            };
            CheckConfig(config);
            this._endpoint = GetEndpoint("dysmsapi", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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
        /// <para>Sends a message to multiple recipients in countries or regions outside the Chinese mainland.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  You cannot call the BatchSendMessageToGlobe operation to send messages to the Chinese mainland.</para>
        /// <list type="bullet">
        /// <item><description>You can call the BatchSendMessageToGlobe operation to send notifications and promotional messages to a limited number of mobile phone numbers at a time. To send messages to a large number of mobile phone numbers at a time, use the mass messaging feature in the SMS console.</description></item>
        /// <item><description>For time-sensitive related messages, we recommend that you use the <a href="https://www.alibabacloud.com/help/en/sms/developer-reference/api-dysmsapi-2018-05-01-batchsendmessagetoglobe">SendMessageToGlobe</a> operation to ensure that messages are delivered on time.</description></item>
        /// <item><description>In each request, you can send messages to up to 1,000 mobile phone numbers.</description></item>
        /// </list>
        /// <h3><a href="#qps-"></a>QPS limit</h3>
        /// <para>You can call this operation only once per second. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// BatchSendMessageToGlobeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// BatchSendMessageToGlobeResponse
        /// </returns>
        public BatchSendMessageToGlobeResponse BatchSendMessageToGlobeWithOptions(BatchSendMessageToGlobeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelId))
            {
                query["ChannelId"] = request.ChannelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.From))
            {
                query["From"] = request.From;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Message))
            {
                query["Message"] = request.Message;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                query["TaskId"] = request.TaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.To))
            {
                query["To"] = request.To;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["Type"] = request.Type;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ValidityPeriod))
            {
                query["ValidityPeriod"] = request.ValidityPeriod;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BatchSendMessageToGlobe",
                Version = "2018-05-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchSendMessageToGlobeResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Sends a message to multiple recipients in countries or regions outside the Chinese mainland.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  You cannot call the BatchSendMessageToGlobe operation to send messages to the Chinese mainland.</para>
        /// <list type="bullet">
        /// <item><description>You can call the BatchSendMessageToGlobe operation to send notifications and promotional messages to a limited number of mobile phone numbers at a time. To send messages to a large number of mobile phone numbers at a time, use the mass messaging feature in the SMS console.</description></item>
        /// <item><description>For time-sensitive related messages, we recommend that you use the <a href="https://www.alibabacloud.com/help/en/sms/developer-reference/api-dysmsapi-2018-05-01-batchsendmessagetoglobe">SendMessageToGlobe</a> operation to ensure that messages are delivered on time.</description></item>
        /// <item><description>In each request, you can send messages to up to 1,000 mobile phone numbers.</description></item>
        /// </list>
        /// <h3><a href="#qps-"></a>QPS limit</h3>
        /// <para>You can call this operation only once per second. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// BatchSendMessageToGlobeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// BatchSendMessageToGlobeResponse
        /// </returns>
        public async Task<BatchSendMessageToGlobeResponse> BatchSendMessageToGlobeWithOptionsAsync(BatchSendMessageToGlobeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelId))
            {
                query["ChannelId"] = request.ChannelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.From))
            {
                query["From"] = request.From;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Message))
            {
                query["Message"] = request.Message;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                query["TaskId"] = request.TaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.To))
            {
                query["To"] = request.To;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["Type"] = request.Type;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ValidityPeriod))
            {
                query["ValidityPeriod"] = request.ValidityPeriod;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BatchSendMessageToGlobe",
                Version = "2018-05-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchSendMessageToGlobeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Sends a message to multiple recipients in countries or regions outside the Chinese mainland.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  You cannot call the BatchSendMessageToGlobe operation to send messages to the Chinese mainland.</para>
        /// <list type="bullet">
        /// <item><description>You can call the BatchSendMessageToGlobe operation to send notifications and promotional messages to a limited number of mobile phone numbers at a time. To send messages to a large number of mobile phone numbers at a time, use the mass messaging feature in the SMS console.</description></item>
        /// <item><description>For time-sensitive related messages, we recommend that you use the <a href="https://www.alibabacloud.com/help/en/sms/developer-reference/api-dysmsapi-2018-05-01-batchsendmessagetoglobe">SendMessageToGlobe</a> operation to ensure that messages are delivered on time.</description></item>
        /// <item><description>In each request, you can send messages to up to 1,000 mobile phone numbers.</description></item>
        /// </list>
        /// <h3><a href="#qps-"></a>QPS limit</h3>
        /// <para>You can call this operation only once per second. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// BatchSendMessageToGlobeRequest
        /// </param>
        /// 
        /// <returns>
        /// BatchSendMessageToGlobeResponse
        /// </returns>
        public BatchSendMessageToGlobeResponse BatchSendMessageToGlobe(BatchSendMessageToGlobeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return BatchSendMessageToGlobeWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Sends a message to multiple recipients in countries or regions outside the Chinese mainland.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  You cannot call the BatchSendMessageToGlobe operation to send messages to the Chinese mainland.</para>
        /// <list type="bullet">
        /// <item><description>You can call the BatchSendMessageToGlobe operation to send notifications and promotional messages to a limited number of mobile phone numbers at a time. To send messages to a large number of mobile phone numbers at a time, use the mass messaging feature in the SMS console.</description></item>
        /// <item><description>For time-sensitive related messages, we recommend that you use the <a href="https://www.alibabacloud.com/help/en/sms/developer-reference/api-dysmsapi-2018-05-01-batchsendmessagetoglobe">SendMessageToGlobe</a> operation to ensure that messages are delivered on time.</description></item>
        /// <item><description>In each request, you can send messages to up to 1,000 mobile phone numbers.</description></item>
        /// </list>
        /// <h3><a href="#qps-"></a>QPS limit</h3>
        /// <para>You can call this operation only once per second. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// BatchSendMessageToGlobeRequest
        /// </param>
        /// 
        /// <returns>
        /// BatchSendMessageToGlobeResponse
        /// </returns>
        public async Task<BatchSendMessageToGlobeResponse> BatchSendMessageToGlobeAsync(BatchSendMessageToGlobeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await BatchSendMessageToGlobeWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>This API, sends conversion data to the Alibaba SMS service.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Metrics:</para>
        /// <list type="bullet">
        /// <item><description>Requested OTP messages</description></item>
        /// <item><description>Verified OTP messages
        /// An OTP conversion rate is calculated based on the following formula: OTP conversion rate = Number of verified OTP messages/Number of requested OTP messages.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ConversionDataRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ConversionDataResponse
        /// </returns>
        public ConversionDataResponse ConversionDataWithOptions(ConversionDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConversionRate))
            {
                body["ConversionRate"] = request.ConversionRate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReportTime))
            {
                body["ReportTime"] = request.ReportTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ConversionData",
                Version = "2018-05-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ConversionDataResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>This API, sends conversion data to the Alibaba SMS service.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Metrics:</para>
        /// <list type="bullet">
        /// <item><description>Requested OTP messages</description></item>
        /// <item><description>Verified OTP messages
        /// An OTP conversion rate is calculated based on the following formula: OTP conversion rate = Number of verified OTP messages/Number of requested OTP messages.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ConversionDataRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ConversionDataResponse
        /// </returns>
        public async Task<ConversionDataResponse> ConversionDataWithOptionsAsync(ConversionDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConversionRate))
            {
                body["ConversionRate"] = request.ConversionRate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReportTime))
            {
                body["ReportTime"] = request.ReportTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ConversionData",
                Version = "2018-05-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ConversionDataResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>This API, sends conversion data to the Alibaba SMS service.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Metrics:</para>
        /// <list type="bullet">
        /// <item><description>Requested OTP messages</description></item>
        /// <item><description>Verified OTP messages
        /// An OTP conversion rate is calculated based on the following formula: OTP conversion rate = Number of verified OTP messages/Number of requested OTP messages.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ConversionDataRequest
        /// </param>
        /// 
        /// <returns>
        /// ConversionDataResponse
        /// </returns>
        public ConversionDataResponse ConversionData(ConversionDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ConversionDataWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>This API, sends conversion data to the Alibaba SMS service.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Metrics:</para>
        /// <list type="bullet">
        /// <item><description>Requested OTP messages</description></item>
        /// <item><description>Verified OTP messages
        /// An OTP conversion rate is calculated based on the following formula: OTP conversion rate = Number of verified OTP messages/Number of requested OTP messages.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ConversionDataRequest
        /// </param>
        /// 
        /// <returns>
        /// ConversionDataResponse
        /// </returns>
        public async Task<ConversionDataResponse> ConversionDataAsync(ConversionDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ConversionDataWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the delivery report of a message.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>QPS limit</h3>
        /// <para>You can call this operation up to 300 times per second. If the number of the calls per second exceeds a limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limits when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// QueryMessageRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryMessageResponse
        /// </returns>
        public QueryMessageResponse QueryMessageWithOptions(QueryMessageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MessageId))
            {
                query["MessageId"] = request.MessageId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryMessage",
                Version = "2018-05-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryMessageResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the delivery report of a message.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>QPS limit</h3>
        /// <para>You can call this operation up to 300 times per second. If the number of the calls per second exceeds a limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limits when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// QueryMessageRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryMessageResponse
        /// </returns>
        public async Task<QueryMessageResponse> QueryMessageWithOptionsAsync(QueryMessageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MessageId))
            {
                query["MessageId"] = request.MessageId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryMessage",
                Version = "2018-05-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryMessageResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the delivery report of a message.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>QPS limit</h3>
        /// <para>You can call this operation up to 300 times per second. If the number of the calls per second exceeds a limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limits when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// QueryMessageRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryMessageResponse
        /// </returns>
        public QueryMessageResponse QueryMessage(QueryMessageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryMessageWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the delivery report of a message.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>QPS limit</h3>
        /// <para>You can call this operation up to 300 times per second. If the number of the calls per second exceeds a limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limits when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// QueryMessageRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryMessageResponse
        /// </returns>
        public async Task<QueryMessageResponse> QueryMessageAsync(QueryMessageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryMessageWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Sends a message to regions outside the Chinese mainland.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3><a href="#"></a>Usage notes</h3>
        /// <para>The SendMessageToGlobe API operation does not support message delivery to the Chinese mainland.</para>
        /// <h3><a href="#qps-"></a>QPS limit</h3>
        /// <para>You can call this operation up to 30 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// SendMessageToGlobeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SendMessageToGlobeResponse
        /// </returns>
        public SendMessageToGlobeResponse SendMessageToGlobeWithOptions(SendMessageToGlobeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelId))
            {
                query["ChannelId"] = request.ChannelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.From))
            {
                query["From"] = request.From;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Message))
            {
                query["Message"] = request.Message;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                query["TaskId"] = request.TaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.To))
            {
                query["To"] = request.To;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ValidityPeriod))
            {
                query["ValidityPeriod"] = request.ValidityPeriod;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SendMessageToGlobe",
                Version = "2018-05-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SendMessageToGlobeResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Sends a message to regions outside the Chinese mainland.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3><a href="#"></a>Usage notes</h3>
        /// <para>The SendMessageToGlobe API operation does not support message delivery to the Chinese mainland.</para>
        /// <h3><a href="#qps-"></a>QPS limit</h3>
        /// <para>You can call this operation up to 30 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// SendMessageToGlobeRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SendMessageToGlobeResponse
        /// </returns>
        public async Task<SendMessageToGlobeResponse> SendMessageToGlobeWithOptionsAsync(SendMessageToGlobeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelId))
            {
                query["ChannelId"] = request.ChannelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.From))
            {
                query["From"] = request.From;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Message))
            {
                query["Message"] = request.Message;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                query["TaskId"] = request.TaskId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.To))
            {
                query["To"] = request.To;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ValidityPeriod))
            {
                query["ValidityPeriod"] = request.ValidityPeriod;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SendMessageToGlobe",
                Version = "2018-05-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SendMessageToGlobeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Sends a message to regions outside the Chinese mainland.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3><a href="#"></a>Usage notes</h3>
        /// <para>The SendMessageToGlobe API operation does not support message delivery to the Chinese mainland.</para>
        /// <h3><a href="#qps-"></a>QPS limit</h3>
        /// <para>You can call this operation up to 30 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// SendMessageToGlobeRequest
        /// </param>
        /// 
        /// <returns>
        /// SendMessageToGlobeResponse
        /// </returns>
        public SendMessageToGlobeResponse SendMessageToGlobe(SendMessageToGlobeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SendMessageToGlobeWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Sends a message to regions outside the Chinese mainland.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3><a href="#"></a>Usage notes</h3>
        /// <para>The SendMessageToGlobe API operation does not support message delivery to the Chinese mainland.</para>
        /// <h3><a href="#qps-"></a>QPS limit</h3>
        /// <para>You can call this operation up to 30 times per second per account. If the number of calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// SendMessageToGlobeRequest
        /// </param>
        /// 
        /// <returns>
        /// SendMessageToGlobeResponse
        /// </returns>
        public async Task<SendMessageToGlobeResponse> SendMessageToGlobeAsync(SendMessageToGlobeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SendMessageToGlobeWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Sends a message to the Chinese mainland by using a message template.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Usage notes</h3>
        /// <para>You can call the SendMessageWithTemplate operation to send messages only to the Chinese mainland.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// SendMessageWithTemplateRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SendMessageWithTemplateResponse
        /// </returns>
        public SendMessageWithTemplateResponse SendMessageWithTemplateWithOptions(SendMessageWithTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelId))
            {
                query["ChannelId"] = request.ChannelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.From))
            {
                query["From"] = request.From;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SmsUpExtendCode))
            {
                query["SmsUpExtendCode"] = request.SmsUpExtendCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateCode))
            {
                query["TemplateCode"] = request.TemplateCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateParam))
            {
                query["TemplateParam"] = request.TemplateParam;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.To))
            {
                query["To"] = request.To;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ValidityPeriod))
            {
                query["ValidityPeriod"] = request.ValidityPeriod;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SendMessageWithTemplate",
                Version = "2018-05-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SendMessageWithTemplateResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Sends a message to the Chinese mainland by using a message template.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Usage notes</h3>
        /// <para>You can call the SendMessageWithTemplate operation to send messages only to the Chinese mainland.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// SendMessageWithTemplateRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SendMessageWithTemplateResponse
        /// </returns>
        public async Task<SendMessageWithTemplateResponse> SendMessageWithTemplateWithOptionsAsync(SendMessageWithTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelId))
            {
                query["ChannelId"] = request.ChannelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.From))
            {
                query["From"] = request.From;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SmsUpExtendCode))
            {
                query["SmsUpExtendCode"] = request.SmsUpExtendCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateCode))
            {
                query["TemplateCode"] = request.TemplateCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateParam))
            {
                query["TemplateParam"] = request.TemplateParam;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.To))
            {
                query["To"] = request.To;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ValidityPeriod))
            {
                query["ValidityPeriod"] = request.ValidityPeriod;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SendMessageWithTemplate",
                Version = "2018-05-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SendMessageWithTemplateResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Sends a message to the Chinese mainland by using a message template.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Usage notes</h3>
        /// <para>You can call the SendMessageWithTemplate operation to send messages only to the Chinese mainland.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// SendMessageWithTemplateRequest
        /// </param>
        /// 
        /// <returns>
        /// SendMessageWithTemplateResponse
        /// </returns>
        public SendMessageWithTemplateResponse SendMessageWithTemplate(SendMessageWithTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SendMessageWithTemplateWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Sends a message to the Chinese mainland by using a message template.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Usage notes</h3>
        /// <para>You can call the SendMessageWithTemplate operation to send messages only to the Chinese mainland.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// SendMessageWithTemplateRequest
        /// </param>
        /// 
        /// <returns>
        /// SendMessageWithTemplateResponse
        /// </returns>
        public async Task<SendMessageWithTemplateResponse> SendMessageWithTemplateAsync(SendMessageWithTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SendMessageWithTemplateWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Delivers one-time password (OTP) message statuses to Alibaba Cloud, which calculates and monitors OTP conversion rates.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Metrics:</para>
        /// <list type="bullet">
        /// <item><description>Requested OTP messages</description></item>
        /// <item><description>Verified OTP messages
        /// An OTP conversion rate is calculated based on the following formula: OTP conversion rate = Number of verified OTP messages/Number of requested OTP messages.<remarks>
        /// <para>If you call the SmsConversion operation to query OTP conversion rates, your business may be affected. We recommend that you perform the following operations:</para>
        /// <list type="bullet">
        /// <item><description>Call the SmsConversion operation in an asynchronous manner by configuring queues or events.</description></item>
        /// <item><description>Manually degrade your services or use a circuit breaker to automatically degrade services.</description></item>
        /// </list>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// SmsConversionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SmsConversionResponse
        /// </returns>
        public SmsConversionResponse SmsConversionWithOptions(SmsConversionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConversionTime))
            {
                query["ConversionTime"] = request.ConversionTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Delivered))
            {
                query["Delivered"] = request.Delivered;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MessageId))
            {
                query["MessageId"] = request.MessageId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SmsConversion",
                Version = "2018-05-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SmsConversionResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Delivers one-time password (OTP) message statuses to Alibaba Cloud, which calculates and monitors OTP conversion rates.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Metrics:</para>
        /// <list type="bullet">
        /// <item><description>Requested OTP messages</description></item>
        /// <item><description>Verified OTP messages
        /// An OTP conversion rate is calculated based on the following formula: OTP conversion rate = Number of verified OTP messages/Number of requested OTP messages.<remarks>
        /// <para>If you call the SmsConversion operation to query OTP conversion rates, your business may be affected. We recommend that you perform the following operations:</para>
        /// <list type="bullet">
        /// <item><description>Call the SmsConversion operation in an asynchronous manner by configuring queues or events.</description></item>
        /// <item><description>Manually degrade your services or use a circuit breaker to automatically degrade services.</description></item>
        /// </list>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// SmsConversionRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SmsConversionResponse
        /// </returns>
        public async Task<SmsConversionResponse> SmsConversionWithOptionsAsync(SmsConversionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ConversionTime))
            {
                query["ConversionTime"] = request.ConversionTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Delivered))
            {
                query["Delivered"] = request.Delivered;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MessageId))
            {
                query["MessageId"] = request.MessageId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SmsConversion",
                Version = "2018-05-01",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SmsConversionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Delivers one-time password (OTP) message statuses to Alibaba Cloud, which calculates and monitors OTP conversion rates.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Metrics:</para>
        /// <list type="bullet">
        /// <item><description>Requested OTP messages</description></item>
        /// <item><description>Verified OTP messages
        /// An OTP conversion rate is calculated based on the following formula: OTP conversion rate = Number of verified OTP messages/Number of requested OTP messages.<remarks>
        /// <para>If you call the SmsConversion operation to query OTP conversion rates, your business may be affected. We recommend that you perform the following operations:</para>
        /// <list type="bullet">
        /// <item><description>Call the SmsConversion operation in an asynchronous manner by configuring queues or events.</description></item>
        /// <item><description>Manually degrade your services or use a circuit breaker to automatically degrade services.</description></item>
        /// </list>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// SmsConversionRequest
        /// </param>
        /// 
        /// <returns>
        /// SmsConversionResponse
        /// </returns>
        public SmsConversionResponse SmsConversion(SmsConversionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SmsConversionWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Delivers one-time password (OTP) message statuses to Alibaba Cloud, which calculates and monitors OTP conversion rates.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Metrics:</para>
        /// <list type="bullet">
        /// <item><description>Requested OTP messages</description></item>
        /// <item><description>Verified OTP messages
        /// An OTP conversion rate is calculated based on the following formula: OTP conversion rate = Number of verified OTP messages/Number of requested OTP messages.<remarks>
        /// <para>If you call the SmsConversion operation to query OTP conversion rates, your business may be affected. We recommend that you perform the following operations:</para>
        /// <list type="bullet">
        /// <item><description>Call the SmsConversion operation in an asynchronous manner by configuring queues or events.</description></item>
        /// <item><description>Manually degrade your services or use a circuit breaker to automatically degrade services.</description></item>
        /// </list>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// SmsConversionRequest
        /// </param>
        /// 
        /// <returns>
        /// SmsConversionResponse
        /// </returns>
        public async Task<SmsConversionResponse> SmsConversionAsync(SmsConversionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SmsConversionWithOptionsAsync(request, runtime);
        }

    }
}
