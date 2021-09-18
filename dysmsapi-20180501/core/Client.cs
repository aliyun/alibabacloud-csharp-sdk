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
                {"ap-southeast-5", "dysmsapi-xman.ap-southeast-5.aliyuncs.com"},
                {"cn-beijing", "dysmsapi-proxy.cn-beijing.aliyuncs.com"},
                {"cn-hongkong", "dysmsapi-xman.cn-hongkong.aliyuncs.com"},
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

        public QueryMessageResponse QueryMessageWithOptions(QueryMessageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryMessageResponse>(DoRPCRequest("QueryMessage", "2018-05-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<QueryMessageResponse> QueryMessageWithOptionsAsync(QueryMessageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryMessageResponse>(await DoRPCRequestAsync("QueryMessage", "2018-05-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public QueryMessageResponse QueryMessage(QueryMessageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryMessageWithOptions(request, runtime);
        }

        public async Task<QueryMessageResponse> QueryMessageAsync(QueryMessageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryMessageWithOptionsAsync(request, runtime);
        }

        public BatchSendMessageToGlobeResponse BatchSendMessageToGlobeWithOptions(BatchSendMessageToGlobeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<BatchSendMessageToGlobeResponse>(DoRPCRequest("BatchSendMessageToGlobe", "2018-05-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<BatchSendMessageToGlobeResponse> BatchSendMessageToGlobeWithOptionsAsync(BatchSendMessageToGlobeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<BatchSendMessageToGlobeResponse>(await DoRPCRequestAsync("BatchSendMessageToGlobe", "2018-05-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public BatchSendMessageToGlobeResponse BatchSendMessageToGlobe(BatchSendMessageToGlobeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return BatchSendMessageToGlobeWithOptions(request, runtime);
        }

        public async Task<BatchSendMessageToGlobeResponse> BatchSendMessageToGlobeAsync(BatchSendMessageToGlobeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await BatchSendMessageToGlobeWithOptionsAsync(request, runtime);
        }

        public SmsConversionResponse SmsConversionWithOptions(SmsConversionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SmsConversionResponse>(DoRPCRequest("SmsConversion", "2018-05-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SmsConversionResponse> SmsConversionWithOptionsAsync(SmsConversionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SmsConversionResponse>(await DoRPCRequestAsync("SmsConversion", "2018-05-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public SmsConversionResponse SmsConversion(SmsConversionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SmsConversionWithOptions(request, runtime);
        }

        public async Task<SmsConversionResponse> SmsConversionAsync(SmsConversionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SmsConversionWithOptionsAsync(request, runtime);
        }

        public SendMessageToGlobeResponse SendMessageToGlobeWithOptions(SendMessageToGlobeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SendMessageToGlobeResponse>(DoRPCRequest("SendMessageToGlobe", "2018-05-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SendMessageToGlobeResponse> SendMessageToGlobeWithOptionsAsync(SendMessageToGlobeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SendMessageToGlobeResponse>(await DoRPCRequestAsync("SendMessageToGlobe", "2018-05-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public SendMessageToGlobeResponse SendMessageToGlobe(SendMessageToGlobeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SendMessageToGlobeWithOptions(request, runtime);
        }

        public async Task<SendMessageToGlobeResponse> SendMessageToGlobeAsync(SendMessageToGlobeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SendMessageToGlobeWithOptionsAsync(request, runtime);
        }

        public ConversionDataResponse ConversionDataWithOptions(ConversionDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ConversionDataResponse>(DoRPCRequest("ConversionData", "2018-05-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ConversionDataResponse> ConversionDataWithOptionsAsync(ConversionDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ConversionDataResponse>(await DoRPCRequestAsync("ConversionData", "2018-05-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ConversionDataResponse ConversionData(ConversionDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ConversionDataWithOptions(request, runtime);
        }

        public async Task<ConversionDataResponse> ConversionDataAsync(ConversionDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ConversionDataWithOptionsAsync(request, runtime);
        }

        public SendMessageWithTemplateResponse SendMessageWithTemplateWithOptions(SendMessageWithTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SendMessageWithTemplateResponse>(DoRPCRequest("SendMessageWithTemplate", "2018-05-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SendMessageWithTemplateResponse> SendMessageWithTemplateWithOptionsAsync(SendMessageWithTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SendMessageWithTemplateResponse>(await DoRPCRequestAsync("SendMessageWithTemplate", "2018-05-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public SendMessageWithTemplateResponse SendMessageWithTemplate(SendMessageWithTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SendMessageWithTemplateWithOptions(request, runtime);
        }

        public async Task<SendMessageWithTemplateResponse> SendMessageWithTemplateAsync(SendMessageWithTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SendMessageWithTemplateWithOptionsAsync(request, runtime);
        }

    }
}
