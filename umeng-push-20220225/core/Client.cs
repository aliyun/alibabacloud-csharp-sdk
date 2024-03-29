// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Umeng_push20220225.Models;

namespace AlibabaCloud.SDK.Umeng_push20220225
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "";
            CheckConfig(config);
            this._endpoint = GetEndpoint("umeng-push", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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

        public CancelByMsgIdResponse CancelByMsgIdWithOptions(CancelByMsgIdRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MsgId))
            {
                body["MsgId"] = request.MsgId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CancelByMsgId",
                Version = "2022-02-25",
                Protocol = "HTTPS",
                Pathname = "/CancelByMsgId",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CancelByMsgIdResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CancelByMsgIdResponse> CancelByMsgIdWithOptionsAsync(CancelByMsgIdRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MsgId))
            {
                body["MsgId"] = request.MsgId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CancelByMsgId",
                Version = "2022-02-25",
                Protocol = "HTTPS",
                Pathname = "/CancelByMsgId",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CancelByMsgIdResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CancelByMsgIdResponse CancelByMsgId(CancelByMsgIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CancelByMsgIdWithOptions(request, headers, runtime);
        }

        public async Task<CancelByMsgIdResponse> CancelByMsgIdAsync(CancelByMsgIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CancelByMsgIdWithOptionsAsync(request, headers, runtime);
        }

        public QueryMsgStatResponse QueryMsgStatWithOptions(QueryMsgStatRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MsgId))
            {
                body["MsgId"] = request.MsgId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryMsgStat",
                Version = "2022-02-25",
                Protocol = "HTTPS",
                Pathname = "/QueryMsgStat",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryMsgStatResponse>(CallApi(params_, req, runtime));
        }

        public async Task<QueryMsgStatResponse> QueryMsgStatWithOptionsAsync(QueryMsgStatRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MsgId))
            {
                body["MsgId"] = request.MsgId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryMsgStat",
                Version = "2022-02-25",
                Protocol = "HTTPS",
                Pathname = "/QueryMsgStat",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryMsgStatResponse>(await CallApiAsync(params_, req, runtime));
        }

        public QueryMsgStatResponse QueryMsgStat(QueryMsgStatRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return QueryMsgStatWithOptions(request, headers, runtime);
        }

        public async Task<QueryMsgStatResponse> QueryMsgStatAsync(QueryMsgStatRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await QueryMsgStatWithOptionsAsync(request, headers, runtime);
        }

        public SendByAliasResponse SendByAliasWithOptions(SendByAliasRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            SendByAliasShrinkRequest request = new SendByAliasShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.AndroidPayload))
            {
                request.AndroidPayloadShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.AndroidPayload, "AndroidPayload", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ChannelProperties))
            {
                request.ChannelPropertiesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ChannelProperties, "ChannelProperties", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.IosPayload))
            {
                request.IosPayloadShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.IosPayload, "IosPayload", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Policy))
            {
                request.PolicyShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Policy, "Policy", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Alias))
            {
                body["Alias"] = request.Alias;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AliasType))
            {
                body["AliasType"] = request.AliasType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AndroidPayloadShrink))
            {
                body["AndroidPayload"] = request.AndroidPayloadShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelPropertiesShrink))
            {
                body["ChannelProperties"] = request.ChannelPropertiesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IosPayloadShrink))
            {
                body["IosPayload"] = request.IosPayloadShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyShrink))
            {
                body["Policy"] = request.PolicyShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductionMode))
            {
                body["ProductionMode"] = request.ProductionMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReceiptType))
            {
                body["ReceiptType"] = request.ReceiptType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReceiptUrl))
            {
                body["ReceiptUrl"] = request.ReceiptUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdPartyId))
            {
                body["ThirdPartyId"] = request.ThirdPartyId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SendByAlias",
                Version = "2022-02-25",
                Protocol = "HTTPS",
                Pathname = "/SendByAlias",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SendByAliasResponse>(CallApi(params_, req, runtime));
        }

        public async Task<SendByAliasResponse> SendByAliasWithOptionsAsync(SendByAliasRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            SendByAliasShrinkRequest request = new SendByAliasShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.AndroidPayload))
            {
                request.AndroidPayloadShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.AndroidPayload, "AndroidPayload", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ChannelProperties))
            {
                request.ChannelPropertiesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ChannelProperties, "ChannelProperties", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.IosPayload))
            {
                request.IosPayloadShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.IosPayload, "IosPayload", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Policy))
            {
                request.PolicyShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Policy, "Policy", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Alias))
            {
                body["Alias"] = request.Alias;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AliasType))
            {
                body["AliasType"] = request.AliasType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AndroidPayloadShrink))
            {
                body["AndroidPayload"] = request.AndroidPayloadShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelPropertiesShrink))
            {
                body["ChannelProperties"] = request.ChannelPropertiesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IosPayloadShrink))
            {
                body["IosPayload"] = request.IosPayloadShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyShrink))
            {
                body["Policy"] = request.PolicyShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductionMode))
            {
                body["ProductionMode"] = request.ProductionMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReceiptType))
            {
                body["ReceiptType"] = request.ReceiptType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReceiptUrl))
            {
                body["ReceiptUrl"] = request.ReceiptUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdPartyId))
            {
                body["ThirdPartyId"] = request.ThirdPartyId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SendByAlias",
                Version = "2022-02-25",
                Protocol = "HTTPS",
                Pathname = "/SendByAlias",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SendByAliasResponse>(await CallApiAsync(params_, req, runtime));
        }

        public SendByAliasResponse SendByAlias(SendByAliasRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return SendByAliasWithOptions(request, headers, runtime);
        }

        public async Task<SendByAliasResponse> SendByAliasAsync(SendByAliasRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await SendByAliasWithOptionsAsync(request, headers, runtime);
        }

        public SendByAliasFileIdResponse SendByAliasFileIdWithOptions(SendByAliasFileIdRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            SendByAliasFileIdShrinkRequest request = new SendByAliasFileIdShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.AndroidPayload))
            {
                request.AndroidPayloadShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.AndroidPayload, "AndroidPayload", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ChannelProperties))
            {
                request.ChannelPropertiesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ChannelProperties, "ChannelProperties", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.IosPayload))
            {
                request.IosPayloadShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.IosPayload, "IosPayload", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Policy))
            {
                request.PolicyShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Policy, "Policy", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AliasType))
            {
                body["AliasType"] = request.AliasType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AndroidPayloadShrink))
            {
                body["AndroidPayload"] = request.AndroidPayloadShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelPropertiesShrink))
            {
                body["ChannelProperties"] = request.ChannelPropertiesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileId))
            {
                body["FileId"] = request.FileId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IosPayloadShrink))
            {
                body["IosPayload"] = request.IosPayloadShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyShrink))
            {
                body["Policy"] = request.PolicyShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductionMode))
            {
                body["ProductionMode"] = request.ProductionMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReceiptType))
            {
                body["ReceiptType"] = request.ReceiptType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReceiptUrl))
            {
                body["ReceiptUrl"] = request.ReceiptUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdPartyId))
            {
                body["ThirdPartyId"] = request.ThirdPartyId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SendByAliasFileId",
                Version = "2022-02-25",
                Protocol = "HTTPS",
                Pathname = "/SendByAliasFileId",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SendByAliasFileIdResponse>(CallApi(params_, req, runtime));
        }

        public async Task<SendByAliasFileIdResponse> SendByAliasFileIdWithOptionsAsync(SendByAliasFileIdRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            SendByAliasFileIdShrinkRequest request = new SendByAliasFileIdShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.AndroidPayload))
            {
                request.AndroidPayloadShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.AndroidPayload, "AndroidPayload", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ChannelProperties))
            {
                request.ChannelPropertiesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ChannelProperties, "ChannelProperties", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.IosPayload))
            {
                request.IosPayloadShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.IosPayload, "IosPayload", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Policy))
            {
                request.PolicyShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Policy, "Policy", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AliasType))
            {
                body["AliasType"] = request.AliasType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AndroidPayloadShrink))
            {
                body["AndroidPayload"] = request.AndroidPayloadShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelPropertiesShrink))
            {
                body["ChannelProperties"] = request.ChannelPropertiesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileId))
            {
                body["FileId"] = request.FileId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IosPayloadShrink))
            {
                body["IosPayload"] = request.IosPayloadShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyShrink))
            {
                body["Policy"] = request.PolicyShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductionMode))
            {
                body["ProductionMode"] = request.ProductionMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReceiptType))
            {
                body["ReceiptType"] = request.ReceiptType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReceiptUrl))
            {
                body["ReceiptUrl"] = request.ReceiptUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdPartyId))
            {
                body["ThirdPartyId"] = request.ThirdPartyId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SendByAliasFileId",
                Version = "2022-02-25",
                Protocol = "HTTPS",
                Pathname = "/SendByAliasFileId",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SendByAliasFileIdResponse>(await CallApiAsync(params_, req, runtime));
        }

        public SendByAliasFileIdResponse SendByAliasFileId(SendByAliasFileIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return SendByAliasFileIdWithOptions(request, headers, runtime);
        }

        public async Task<SendByAliasFileIdResponse> SendByAliasFileIdAsync(SendByAliasFileIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await SendByAliasFileIdWithOptionsAsync(request, headers, runtime);
        }

        public SendByAppResponse SendByAppWithOptions(SendByAppRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            SendByAppShrinkRequest request = new SendByAppShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.AndroidPayload))
            {
                request.AndroidPayloadShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.AndroidPayload, "AndroidPayload", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ChannelProperties))
            {
                request.ChannelPropertiesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ChannelProperties, "ChannelProperties", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.IosPayload))
            {
                request.IosPayloadShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.IosPayload, "IosPayload", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Policy))
            {
                request.PolicyShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Policy, "Policy", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AndroidPayloadShrink))
            {
                body["AndroidPayload"] = request.AndroidPayloadShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelPropertiesShrink))
            {
                body["ChannelProperties"] = request.ChannelPropertiesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IosPayloadShrink))
            {
                body["IosPayload"] = request.IosPayloadShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyShrink))
            {
                body["Policy"] = request.PolicyShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductionMode))
            {
                body["ProductionMode"] = request.ProductionMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReceiptType))
            {
                body["ReceiptType"] = request.ReceiptType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReceiptUrl))
            {
                body["ReceiptUrl"] = request.ReceiptUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdPartyId))
            {
                body["ThirdPartyId"] = request.ThirdPartyId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SendByApp",
                Version = "2022-02-25",
                Protocol = "HTTPS",
                Pathname = "/SendByApp",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SendByAppResponse>(CallApi(params_, req, runtime));
        }

        public async Task<SendByAppResponse> SendByAppWithOptionsAsync(SendByAppRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            SendByAppShrinkRequest request = new SendByAppShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.AndroidPayload))
            {
                request.AndroidPayloadShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.AndroidPayload, "AndroidPayload", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ChannelProperties))
            {
                request.ChannelPropertiesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ChannelProperties, "ChannelProperties", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.IosPayload))
            {
                request.IosPayloadShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.IosPayload, "IosPayload", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Policy))
            {
                request.PolicyShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Policy, "Policy", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AndroidPayloadShrink))
            {
                body["AndroidPayload"] = request.AndroidPayloadShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelPropertiesShrink))
            {
                body["ChannelProperties"] = request.ChannelPropertiesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IosPayloadShrink))
            {
                body["IosPayload"] = request.IosPayloadShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyShrink))
            {
                body["Policy"] = request.PolicyShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductionMode))
            {
                body["ProductionMode"] = request.ProductionMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReceiptType))
            {
                body["ReceiptType"] = request.ReceiptType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReceiptUrl))
            {
                body["ReceiptUrl"] = request.ReceiptUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdPartyId))
            {
                body["ThirdPartyId"] = request.ThirdPartyId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SendByApp",
                Version = "2022-02-25",
                Protocol = "HTTPS",
                Pathname = "/SendByApp",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SendByAppResponse>(await CallApiAsync(params_, req, runtime));
        }

        public SendByAppResponse SendByApp(SendByAppRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return SendByAppWithOptions(request, headers, runtime);
        }

        public async Task<SendByAppResponse> SendByAppAsync(SendByAppRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await SendByAppWithOptionsAsync(request, headers, runtime);
        }

        public SendByDeviceResponse SendByDeviceWithOptions(SendByDeviceRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            SendByDeviceShrinkRequest request = new SendByDeviceShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.AndroidPayload))
            {
                request.AndroidPayloadShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.AndroidPayload, "AndroidPayload", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ChannelProperties))
            {
                request.ChannelPropertiesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ChannelProperties, "ChannelProperties", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.IosPayload))
            {
                request.IosPayloadShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.IosPayload, "IosPayload", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Policy))
            {
                request.PolicyShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Policy, "Policy", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AndroidPayloadShrink))
            {
                body["AndroidPayload"] = request.AndroidPayloadShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelPropertiesShrink))
            {
                body["ChannelProperties"] = request.ChannelPropertiesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceTokens))
            {
                body["DeviceTokens"] = request.DeviceTokens;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IosPayloadShrink))
            {
                body["IosPayload"] = request.IosPayloadShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyShrink))
            {
                body["Policy"] = request.PolicyShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductionMode))
            {
                body["ProductionMode"] = request.ProductionMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReceiptType))
            {
                body["ReceiptType"] = request.ReceiptType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReceiptUrl))
            {
                body["ReceiptUrl"] = request.ReceiptUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdPartyId))
            {
                body["ThirdPartyId"] = request.ThirdPartyId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SendByDevice",
                Version = "2022-02-25",
                Protocol = "HTTPS",
                Pathname = "/SendByDevice",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SendByDeviceResponse>(CallApi(params_, req, runtime));
        }

        public async Task<SendByDeviceResponse> SendByDeviceWithOptionsAsync(SendByDeviceRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            SendByDeviceShrinkRequest request = new SendByDeviceShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.AndroidPayload))
            {
                request.AndroidPayloadShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.AndroidPayload, "AndroidPayload", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ChannelProperties))
            {
                request.ChannelPropertiesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ChannelProperties, "ChannelProperties", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.IosPayload))
            {
                request.IosPayloadShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.IosPayload, "IosPayload", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Policy))
            {
                request.PolicyShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Policy, "Policy", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AndroidPayloadShrink))
            {
                body["AndroidPayload"] = request.AndroidPayloadShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelPropertiesShrink))
            {
                body["ChannelProperties"] = request.ChannelPropertiesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceTokens))
            {
                body["DeviceTokens"] = request.DeviceTokens;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IosPayloadShrink))
            {
                body["IosPayload"] = request.IosPayloadShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyShrink))
            {
                body["Policy"] = request.PolicyShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductionMode))
            {
                body["ProductionMode"] = request.ProductionMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReceiptType))
            {
                body["ReceiptType"] = request.ReceiptType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReceiptUrl))
            {
                body["ReceiptUrl"] = request.ReceiptUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdPartyId))
            {
                body["ThirdPartyId"] = request.ThirdPartyId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SendByDevice",
                Version = "2022-02-25",
                Protocol = "HTTPS",
                Pathname = "/SendByDevice",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SendByDeviceResponse>(await CallApiAsync(params_, req, runtime));
        }

        public SendByDeviceResponse SendByDevice(SendByDeviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return SendByDeviceWithOptions(request, headers, runtime);
        }

        public async Task<SendByDeviceResponse> SendByDeviceAsync(SendByDeviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await SendByDeviceWithOptionsAsync(request, headers, runtime);
        }

        public SendByDeviceFileIdResponse SendByDeviceFileIdWithOptions(SendByDeviceFileIdRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            SendByDeviceFileIdShrinkRequest request = new SendByDeviceFileIdShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.AndroidPayload))
            {
                request.AndroidPayloadShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.AndroidPayload, "AndroidPayload", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ChannelProperties))
            {
                request.ChannelPropertiesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ChannelProperties, "ChannelProperties", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.IosPayload))
            {
                request.IosPayloadShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.IosPayload, "IosPayload", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Policy))
            {
                request.PolicyShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Policy, "Policy", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AndroidPayloadShrink))
            {
                body["AndroidPayload"] = request.AndroidPayloadShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelPropertiesShrink))
            {
                body["ChannelProperties"] = request.ChannelPropertiesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileId))
            {
                body["FileId"] = request.FileId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IosPayloadShrink))
            {
                body["IosPayload"] = request.IosPayloadShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyShrink))
            {
                body["Policy"] = request.PolicyShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductionMode))
            {
                body["ProductionMode"] = request.ProductionMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReceiptType))
            {
                body["ReceiptType"] = request.ReceiptType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReceiptUrl))
            {
                body["ReceiptUrl"] = request.ReceiptUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdPartyId))
            {
                body["ThirdPartyId"] = request.ThirdPartyId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SendByDeviceFileId",
                Version = "2022-02-25",
                Protocol = "HTTPS",
                Pathname = "/SendByDeviceFileId",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SendByDeviceFileIdResponse>(CallApi(params_, req, runtime));
        }

        public async Task<SendByDeviceFileIdResponse> SendByDeviceFileIdWithOptionsAsync(SendByDeviceFileIdRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            SendByDeviceFileIdShrinkRequest request = new SendByDeviceFileIdShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.AndroidPayload))
            {
                request.AndroidPayloadShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.AndroidPayload, "AndroidPayload", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ChannelProperties))
            {
                request.ChannelPropertiesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ChannelProperties, "ChannelProperties", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.IosPayload))
            {
                request.IosPayloadShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.IosPayload, "IosPayload", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Policy))
            {
                request.PolicyShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Policy, "Policy", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AndroidPayloadShrink))
            {
                body["AndroidPayload"] = request.AndroidPayloadShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelPropertiesShrink))
            {
                body["ChannelProperties"] = request.ChannelPropertiesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FileId))
            {
                body["FileId"] = request.FileId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IosPayloadShrink))
            {
                body["IosPayload"] = request.IosPayloadShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyShrink))
            {
                body["Policy"] = request.PolicyShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductionMode))
            {
                body["ProductionMode"] = request.ProductionMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReceiptType))
            {
                body["ReceiptType"] = request.ReceiptType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReceiptUrl))
            {
                body["ReceiptUrl"] = request.ReceiptUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdPartyId))
            {
                body["ThirdPartyId"] = request.ThirdPartyId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SendByDeviceFileId",
                Version = "2022-02-25",
                Protocol = "HTTPS",
                Pathname = "/SendByDeviceFileId",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SendByDeviceFileIdResponse>(await CallApiAsync(params_, req, runtime));
        }

        public SendByDeviceFileIdResponse SendByDeviceFileId(SendByDeviceFileIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return SendByDeviceFileIdWithOptions(request, headers, runtime);
        }

        public async Task<SendByDeviceFileIdResponse> SendByDeviceFileIdAsync(SendByDeviceFileIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await SendByDeviceFileIdWithOptionsAsync(request, headers, runtime);
        }

        public SendByFilterResponse SendByFilterWithOptions(SendByFilterRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            SendByFilterShrinkRequest request = new SendByFilterShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.AndroidPayload))
            {
                request.AndroidPayloadShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.AndroidPayload, "AndroidPayload", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ChannelProperties))
            {
                request.ChannelPropertiesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ChannelProperties, "ChannelProperties", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.IosPayload))
            {
                request.IosPayloadShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.IosPayload, "IosPayload", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Policy))
            {
                request.PolicyShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Policy, "Policy", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AndroidPayloadShrink))
            {
                body["AndroidPayload"] = request.AndroidPayloadShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelPropertiesShrink))
            {
                body["ChannelProperties"] = request.ChannelPropertiesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Filter))
            {
                body["Filter"] = request.Filter;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IosPayloadShrink))
            {
                body["IosPayload"] = request.IosPayloadShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyShrink))
            {
                body["Policy"] = request.PolicyShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductionMode))
            {
                body["ProductionMode"] = request.ProductionMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReceiptType))
            {
                body["ReceiptType"] = request.ReceiptType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReceiptUrl))
            {
                body["ReceiptUrl"] = request.ReceiptUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdPartyId))
            {
                body["ThirdPartyId"] = request.ThirdPartyId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SendByFilter",
                Version = "2022-02-25",
                Protocol = "HTTPS",
                Pathname = "/SendByFilter",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SendByFilterResponse>(CallApi(params_, req, runtime));
        }

        public async Task<SendByFilterResponse> SendByFilterWithOptionsAsync(SendByFilterRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            SendByFilterShrinkRequest request = new SendByFilterShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.AndroidPayload))
            {
                request.AndroidPayloadShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.AndroidPayload, "AndroidPayload", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ChannelProperties))
            {
                request.ChannelPropertiesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ChannelProperties, "ChannelProperties", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.IosPayload))
            {
                request.IosPayloadShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.IosPayload, "IosPayload", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Policy))
            {
                request.PolicyShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Policy, "Policy", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AndroidPayloadShrink))
            {
                body["AndroidPayload"] = request.AndroidPayloadShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelPropertiesShrink))
            {
                body["ChannelProperties"] = request.ChannelPropertiesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["Description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Filter))
            {
                body["Filter"] = request.Filter;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IosPayloadShrink))
            {
                body["IosPayload"] = request.IosPayloadShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PolicyShrink))
            {
                body["Policy"] = request.PolicyShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductionMode))
            {
                body["ProductionMode"] = request.ProductionMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReceiptType))
            {
                body["ReceiptType"] = request.ReceiptType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReceiptUrl))
            {
                body["ReceiptUrl"] = request.ReceiptUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ThirdPartyId))
            {
                body["ThirdPartyId"] = request.ThirdPartyId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SendByFilter",
                Version = "2022-02-25",
                Protocol = "HTTPS",
                Pathname = "/SendByFilter",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<SendByFilterResponse>(await CallApiAsync(params_, req, runtime));
        }

        public SendByFilterResponse SendByFilter(SendByFilterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return SendByFilterWithOptions(request, headers, runtime);
        }

        public async Task<SendByFilterResponse> SendByFilterAsync(SendByFilterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await SendByFilterWithOptionsAsync(request, headers, runtime);
        }

        public UploadDeviceResponse UploadDeviceWithOptions(UploadDeviceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceTokens))
            {
                body["DeviceTokens"] = request.DeviceTokens;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UploadDevice",
                Version = "2022-02-25",
                Protocol = "HTTPS",
                Pathname = "/UploadDevice",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UploadDeviceResponse>(CallApi(params_, req, runtime));
        }

        public async Task<UploadDeviceResponse> UploadDeviceWithOptionsAsync(UploadDeviceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceTokens))
            {
                body["DeviceTokens"] = request.DeviceTokens;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UploadDevice",
                Version = "2022-02-25",
                Protocol = "HTTPS",
                Pathname = "/UploadDevice",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UploadDeviceResponse>(await CallApiAsync(params_, req, runtime));
        }

        public UploadDeviceResponse UploadDevice(UploadDeviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UploadDeviceWithOptions(request, headers, runtime);
        }

        public async Task<UploadDeviceResponse> UploadDeviceAsync(UploadDeviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UploadDeviceWithOptionsAsync(request, headers, runtime);
        }

    }
}
