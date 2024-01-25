// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Umeng_finplus20211125.Models;

namespace AlibabaCloud.SDK.Umeng_finplus20211125
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._signatureAlgorithm = "v2";
            this._endpointRule = "";
            CheckConfig(config);
            this._endpoint = GetEndpoint("umeng-finplus", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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

        public GetMessageStatusResponse GetMessageStatusWithOptions(GetMessageStatusRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                query["TaskId"] = request.TaskId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetMessageStatus",
                Version = "2021-11-25",
                Protocol = "HTTPS",
                Pathname = "/sms/message/status",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetMessageStatusResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetMessageStatusResponse> GetMessageStatusWithOptionsAsync(GetMessageStatusRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                query["TaskId"] = request.TaskId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetMessageStatus",
                Version = "2021-11-25",
                Protocol = "HTTPS",
                Pathname = "/sms/message/status",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetMessageStatusResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetMessageStatusResponse GetMessageStatus(GetMessageStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetMessageStatusWithOptions(request, headers, runtime);
        }

        public async Task<GetMessageStatusResponse> GetMessageStatusAsync(GetMessageStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetMessageStatusWithOptionsAsync(request, headers, runtime);
        }

        public SendBatchMessageResponse SendBatchMessageWithOptions(SendBatchMessageRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BatchFlag))
            {
                body["BatchFlag"] = request.BatchFlag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtendInfo))
            {
                body["ExtendInfo"] = request.ExtendInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdType))
            {
                body["IdType"] = request.IdType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhoneNumberJson))
            {
                body["PhoneNumberJson"] = request.PhoneNumberJson;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SignNameJson))
            {
                body["SignNameJson"] = request.SignNameJson;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SpecificChannel))
            {
                body["SpecificChannel"] = request.SpecificChannel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateCode))
            {
                body["TemplateCode"] = request.TemplateCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateParamJson))
            {
                body["TemplateParamJson"] = request.TemplateParamJson;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SendBatchMessage",
                Version = "2021-11-25",
                Protocol = "HTTPS",
                Pathname = "/sms/message/send",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SendBatchMessageResponse>(CallApi(params_, req, runtime));
        }

        public async Task<SendBatchMessageResponse> SendBatchMessageWithOptionsAsync(SendBatchMessageRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BatchFlag))
            {
                body["BatchFlag"] = request.BatchFlag;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtendInfo))
            {
                body["ExtendInfo"] = request.ExtendInfo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IdType))
            {
                body["IdType"] = request.IdType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PhoneNumberJson))
            {
                body["PhoneNumberJson"] = request.PhoneNumberJson;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SignNameJson))
            {
                body["SignNameJson"] = request.SignNameJson;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SpecificChannel))
            {
                body["SpecificChannel"] = request.SpecificChannel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateCode))
            {
                body["TemplateCode"] = request.TemplateCode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TemplateParamJson))
            {
                body["TemplateParamJson"] = request.TemplateParamJson;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SendBatchMessage",
                Version = "2021-11-25",
                Protocol = "HTTPS",
                Pathname = "/sms/message/send",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SendBatchMessageResponse>(await CallApiAsync(params_, req, runtime));
        }

        public SendBatchMessageResponse SendBatchMessage(SendBatchMessageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return SendBatchMessageWithOptions(request, headers, runtime);
        }

        public async Task<SendBatchMessageResponse> SendBatchMessageAsync(SendBatchMessageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await SendBatchMessageWithOptionsAsync(request, headers, runtime);
        }

    }
}
