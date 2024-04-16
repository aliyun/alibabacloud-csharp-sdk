// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.AliGenieiap_1_0.Models;

namespace AlibabaCloud.SDK.AliGenieiap_1_0
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "";
            CheckConfig(config);
            this._endpoint = GetEndpoint("aligenie", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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

        public AppUseTimeReportResponse AppUseTimeReportWithOptions(AppUseTimeReportRequest tmpReq, AppUseTimeReportHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            AppUseTimeReportShrinkRequest request = new AppUseTimeReportShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DeviceInfo))
            {
                request.DeviceInfoShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DeviceInfo, "DeviceInfo", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Payload))
            {
                request.PayloadShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Payload, "Payload", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.UserInfo))
            {
                request.UserInfoShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.UserInfo, "UserInfo", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceInfoShrink))
            {
                body["DeviceInfo"] = request.DeviceInfoShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PayloadShrink))
            {
                body["Payload"] = request.PayloadShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserInfoShrink))
            {
                body["UserInfo"] = request.UserInfoShrink;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsAligenieAccessToken))
            {
                realHeaders["x-acs-aligenie-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsAligenieAccessToken);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Authorization))
            {
                realHeaders["Authorization"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Authorization);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AppUseTimeReport",
                Version = "iap_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/iap/vip/use/time/report",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AppUseTimeReportResponse>(CallApi(params_, req, runtime));
        }

        public async Task<AppUseTimeReportResponse> AppUseTimeReportWithOptionsAsync(AppUseTimeReportRequest tmpReq, AppUseTimeReportHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            AppUseTimeReportShrinkRequest request = new AppUseTimeReportShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DeviceInfo))
            {
                request.DeviceInfoShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DeviceInfo, "DeviceInfo", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Payload))
            {
                request.PayloadShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Payload, "Payload", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.UserInfo))
            {
                request.UserInfoShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.UserInfo, "UserInfo", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceInfoShrink))
            {
                body["DeviceInfo"] = request.DeviceInfoShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PayloadShrink))
            {
                body["Payload"] = request.PayloadShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserInfoShrink))
            {
                body["UserInfo"] = request.UserInfoShrink;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsAligenieAccessToken))
            {
                realHeaders["x-acs-aligenie-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsAligenieAccessToken);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Authorization))
            {
                realHeaders["Authorization"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Authorization);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "AppUseTimeReport",
                Version = "iap_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/iap/vip/use/time/report",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<AppUseTimeReportResponse>(await CallApiAsync(params_, req, runtime));
        }

        public AppUseTimeReportResponse AppUseTimeReport(AppUseTimeReportRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AppUseTimeReportHeaders headers = new AppUseTimeReportHeaders();
            return AppUseTimeReportWithOptions(request, headers, runtime);
        }

        public async Task<AppUseTimeReportResponse> AppUseTimeReportAsync(AppUseTimeReportRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            AppUseTimeReportHeaders headers = new AppUseTimeReportHeaders();
            return await AppUseTimeReportWithOptionsAsync(request, headers, runtime);
        }

        public CallBackThirdRightSendPlanResponse CallBackThirdRightSendPlanWithOptions(CallBackThirdRightSendPlanRequest tmpReq, CallBackThirdRightSendPlanHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CallBackThirdRightSendPlanShrinkRequest request = new CallBackThirdRightSendPlanShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ExtendInfo))
            {
                request.ExtendInfoShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ExtendInfo, "ExtendInfo", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizGroup))
            {
                query["BizGroup"] = request.BizGroup;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizType))
            {
                query["BizType"] = request.BizType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CardType))
            {
                query["CardType"] = request.CardType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ErrorMsg))
            {
                query["ErrorMsg"] = request.ErrorMsg;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtendInfoShrink))
            {
                query["ExtendInfo"] = request.ExtendInfoShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GenieOpenId))
            {
                query["GenieOpenId"] = request.GenieOpenId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReceiveStatus))
            {
                query["ReceiveStatus"] = request.ReceiveStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Sn))
            {
                query["Sn"] = request.Sn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SupplierId))
            {
                query["SupplierId"] = request.SupplierId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsAligenieAccessToken))
            {
                realHeaders["x-acs-aligenie-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsAligenieAccessToken);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Authorization))
            {
                realHeaders["Authorization"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Authorization);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CallBackThirdRightSendPlan",
                Version = "iap_1.0",
                Protocol = "HTTPS",
                Pathname = "/1.0/iap/business/CallBackThirdRightSendPlan",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CallBackThirdRightSendPlanResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CallBackThirdRightSendPlanResponse> CallBackThirdRightSendPlanWithOptionsAsync(CallBackThirdRightSendPlanRequest tmpReq, CallBackThirdRightSendPlanHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CallBackThirdRightSendPlanShrinkRequest request = new CallBackThirdRightSendPlanShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ExtendInfo))
            {
                request.ExtendInfoShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ExtendInfo, "ExtendInfo", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizGroup))
            {
                query["BizGroup"] = request.BizGroup;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizType))
            {
                query["BizType"] = request.BizType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CardType))
            {
                query["CardType"] = request.CardType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ErrorMsg))
            {
                query["ErrorMsg"] = request.ErrorMsg;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtendInfoShrink))
            {
                query["ExtendInfo"] = request.ExtendInfoShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GenieOpenId))
            {
                query["GenieOpenId"] = request.GenieOpenId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReceiveStatus))
            {
                query["ReceiveStatus"] = request.ReceiveStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Sn))
            {
                query["Sn"] = request.Sn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SupplierId))
            {
                query["SupplierId"] = request.SupplierId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsAligenieAccessToken))
            {
                realHeaders["x-acs-aligenie-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsAligenieAccessToken);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Authorization))
            {
                realHeaders["Authorization"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Authorization);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CallBackThirdRightSendPlan",
                Version = "iap_1.0",
                Protocol = "HTTPS",
                Pathname = "/1.0/iap/business/CallBackThirdRightSendPlan",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CallBackThirdRightSendPlanResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CallBackThirdRightSendPlanResponse CallBackThirdRightSendPlan(CallBackThirdRightSendPlanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CallBackThirdRightSendPlanHeaders headers = new CallBackThirdRightSendPlanHeaders();
            return CallBackThirdRightSendPlanWithOptions(request, headers, runtime);
        }

        public async Task<CallBackThirdRightSendPlanResponse> CallBackThirdRightSendPlanAsync(CallBackThirdRightSendPlanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CallBackThirdRightSendPlanHeaders headers = new CallBackThirdRightSendPlanHeaders();
            return await CallBackThirdRightSendPlanWithOptionsAsync(request, headers, runtime);
        }

        public CheckThirdRightSendPlanResponse CheckThirdRightSendPlanWithOptions(CheckThirdRightSendPlanRequest tmpReq, CheckThirdRightSendPlanHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CheckThirdRightSendPlanShrinkRequest request = new CheckThirdRightSendPlanShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ExtendInfo))
            {
                request.ExtendInfoShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ExtendInfo, "ExtendInfo", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizGroup))
            {
                query["BizGroup"] = request.BizGroup;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizType))
            {
                query["BizType"] = request.BizType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtendInfoShrink))
            {
                query["ExtendInfo"] = request.ExtendInfoShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Sn))
            {
                query["Sn"] = request.Sn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SupplierId))
            {
                query["SupplierId"] = request.SupplierId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsAligenieAccessToken))
            {
                realHeaders["x-acs-aligenie-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsAligenieAccessToken);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Authorization))
            {
                realHeaders["Authorization"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Authorization);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CheckThirdRightSendPlan",
                Version = "iap_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/iap/business/CheckThirdRightSendPlan",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CheckThirdRightSendPlanResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CheckThirdRightSendPlanResponse> CheckThirdRightSendPlanWithOptionsAsync(CheckThirdRightSendPlanRequest tmpReq, CheckThirdRightSendPlanHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CheckThirdRightSendPlanShrinkRequest request = new CheckThirdRightSendPlanShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ExtendInfo))
            {
                request.ExtendInfoShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ExtendInfo, "ExtendInfo", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizGroup))
            {
                query["BizGroup"] = request.BizGroup;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizType))
            {
                query["BizType"] = request.BizType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtendInfoShrink))
            {
                query["ExtendInfo"] = request.ExtendInfoShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Sn))
            {
                query["Sn"] = request.Sn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SupplierId))
            {
                query["SupplierId"] = request.SupplierId;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsAligenieAccessToken))
            {
                realHeaders["x-acs-aligenie-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsAligenieAccessToken);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Authorization))
            {
                realHeaders["Authorization"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Authorization);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CheckThirdRightSendPlan",
                Version = "iap_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/iap/business/CheckThirdRightSendPlan",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CheckThirdRightSendPlanResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CheckThirdRightSendPlanResponse CheckThirdRightSendPlan(CheckThirdRightSendPlanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CheckThirdRightSendPlanHeaders headers = new CheckThirdRightSendPlanHeaders();
            return CheckThirdRightSendPlanWithOptions(request, headers, runtime);
        }

        public async Task<CheckThirdRightSendPlanResponse> CheckThirdRightSendPlanAsync(CheckThirdRightSendPlanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CheckThirdRightSendPlanHeaders headers = new CheckThirdRightSendPlanHeaders();
            return await CheckThirdRightSendPlanWithOptionsAsync(request, headers, runtime);
        }

        public CreateReminderResponse CreateReminderWithOptions(CreateReminderRequest tmpReq, CreateReminderHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateReminderShrinkRequest request = new CreateReminderShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DeviceInfo))
            {
                request.DeviceInfoShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DeviceInfo, "DeviceInfo", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Payload))
            {
                request.PayloadShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Payload, "Payload", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.UserInfo))
            {
                request.UserInfoShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.UserInfo, "UserInfo", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceInfoShrink))
            {
                body["DeviceInfo"] = request.DeviceInfoShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PayloadShrink))
            {
                body["Payload"] = request.PayloadShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserInfoShrink))
            {
                body["UserInfo"] = request.UserInfoShrink;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsAligenieAccessToken))
            {
                realHeaders["x-acs-aligenie-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsAligenieAccessToken);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Authorization))
            {
                realHeaders["Authorization"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Authorization);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateReminder",
                Version = "iap_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/iap/reminder/create",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateReminderResponse>(CallApi(params_, req, runtime));
        }

        public async Task<CreateReminderResponse> CreateReminderWithOptionsAsync(CreateReminderRequest tmpReq, CreateReminderHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateReminderShrinkRequest request = new CreateReminderShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DeviceInfo))
            {
                request.DeviceInfoShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DeviceInfo, "DeviceInfo", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Payload))
            {
                request.PayloadShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Payload, "Payload", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.UserInfo))
            {
                request.UserInfoShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.UserInfo, "UserInfo", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceInfoShrink))
            {
                body["DeviceInfo"] = request.DeviceInfoShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PayloadShrink))
            {
                body["Payload"] = request.PayloadShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserInfoShrink))
            {
                body["UserInfo"] = request.UserInfoShrink;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsAligenieAccessToken))
            {
                realHeaders["x-acs-aligenie-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsAligenieAccessToken);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Authorization))
            {
                realHeaders["Authorization"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Authorization);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateReminder",
                Version = "iap_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/iap/reminder/create",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateReminderResponse>(await CallApiAsync(params_, req, runtime));
        }

        public CreateReminderResponse CreateReminder(CreateReminderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateReminderHeaders headers = new CreateReminderHeaders();
            return CreateReminderWithOptions(request, headers, runtime);
        }

        public async Task<CreateReminderResponse> CreateReminderAsync(CreateReminderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateReminderHeaders headers = new CreateReminderHeaders();
            return await CreateReminderWithOptionsAsync(request, headers, runtime);
        }

        public DeleteReminderResponse DeleteReminderWithOptions(DeleteReminderRequest tmpReq, DeleteReminderHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DeleteReminderShrinkRequest request = new DeleteReminderShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DeviceInfo))
            {
                request.DeviceInfoShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DeviceInfo, "DeviceInfo", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Payload))
            {
                request.PayloadShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Payload, "Payload", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.UserInfo))
            {
                request.UserInfoShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.UserInfo, "UserInfo", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceInfoShrink))
            {
                query["DeviceInfo"] = request.DeviceInfoShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PayloadShrink))
            {
                query["Payload"] = request.PayloadShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserInfoShrink))
            {
                query["UserInfo"] = request.UserInfoShrink;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsAligenieAccessToken))
            {
                realHeaders["x-acs-aligenie-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsAligenieAccessToken);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Authorization))
            {
                realHeaders["Authorization"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Authorization);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteReminder",
                Version = "iap_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/iap/reminder/delete",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteReminderResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DeleteReminderResponse> DeleteReminderWithOptionsAsync(DeleteReminderRequest tmpReq, DeleteReminderHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            DeleteReminderShrinkRequest request = new DeleteReminderShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DeviceInfo))
            {
                request.DeviceInfoShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DeviceInfo, "DeviceInfo", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Payload))
            {
                request.PayloadShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Payload, "Payload", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.UserInfo))
            {
                request.UserInfoShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.UserInfo, "UserInfo", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceInfoShrink))
            {
                query["DeviceInfo"] = request.DeviceInfoShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PayloadShrink))
            {
                query["Payload"] = request.PayloadShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserInfoShrink))
            {
                query["UserInfo"] = request.UserInfoShrink;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsAligenieAccessToken))
            {
                realHeaders["x-acs-aligenie-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsAligenieAccessToken);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Authorization))
            {
                realHeaders["Authorization"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Authorization);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteReminder",
                Version = "iap_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/iap/reminder/delete",
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteReminderResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DeleteReminderResponse DeleteReminder(DeleteReminderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteReminderHeaders headers = new DeleteReminderHeaders();
            return DeleteReminderWithOptions(request, headers, runtime);
        }

        public async Task<DeleteReminderResponse> DeleteReminderAsync(DeleteReminderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteReminderHeaders headers = new DeleteReminderHeaders();
            return await DeleteReminderWithOptionsAsync(request, headers, runtime);
        }

        public GetAccountForAppResponse GetAccountForAppWithOptions(GetAccountForAppRequest tmpReq, GetAccountForAppHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GetAccountForAppShrinkRequest request = new GetAccountForAppShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DeviceInfo))
            {
                request.DeviceInfoShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DeviceInfo, "DeviceInfo", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Payload))
            {
                request.PayloadShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Payload, "Payload", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.UserInfo))
            {
                request.UserInfoShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.UserInfo, "UserInfo", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceInfoShrink))
            {
                query["DeviceInfo"] = request.DeviceInfoShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PayloadShrink))
            {
                query["Payload"] = request.PayloadShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserInfoShrink))
            {
                query["UserInfo"] = request.UserInfoShrink;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsAligenieAccessToken))
            {
                realHeaders["x-acs-aligenie-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsAligenieAccessToken);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Authorization))
            {
                realHeaders["Authorization"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Authorization);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAccountForApp",
                Version = "iap_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/iap/vip/account/get",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAccountForAppResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetAccountForAppResponse> GetAccountForAppWithOptionsAsync(GetAccountForAppRequest tmpReq, GetAccountForAppHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GetAccountForAppShrinkRequest request = new GetAccountForAppShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DeviceInfo))
            {
                request.DeviceInfoShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DeviceInfo, "DeviceInfo", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Payload))
            {
                request.PayloadShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Payload, "Payload", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.UserInfo))
            {
                request.UserInfoShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.UserInfo, "UserInfo", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceInfoShrink))
            {
                query["DeviceInfo"] = request.DeviceInfoShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PayloadShrink))
            {
                query["Payload"] = request.PayloadShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserInfoShrink))
            {
                query["UserInfo"] = request.UserInfoShrink;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsAligenieAccessToken))
            {
                realHeaders["x-acs-aligenie-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsAligenieAccessToken);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Authorization))
            {
                realHeaders["Authorization"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Authorization);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetAccountForApp",
                Version = "iap_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/iap/vip/account/get",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetAccountForAppResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetAccountForAppResponse GetAccountForApp(GetAccountForAppRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetAccountForAppHeaders headers = new GetAccountForAppHeaders();
            return GetAccountForAppWithOptions(request, headers, runtime);
        }

        public async Task<GetAccountForAppResponse> GetAccountForAppAsync(GetAccountForAppRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetAccountForAppHeaders headers = new GetAccountForAppHeaders();
            return await GetAccountForAppWithOptionsAsync(request, headers, runtime);
        }

        public GetBusAppConfigResponse GetBusAppConfigWithOptions(GetBusAppConfigRequest tmpReq, GetBusAppConfigHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GetBusAppConfigShrinkRequest request = new GetBusAppConfigShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DeviceInfo))
            {
                request.DeviceInfoShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DeviceInfo, "DeviceInfo", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Payload))
            {
                request.PayloadShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Payload, "Payload", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.UserInfo))
            {
                request.UserInfoShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.UserInfo, "UserInfo", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceInfoShrink))
            {
                query["DeviceInfo"] = request.DeviceInfoShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PayloadShrink))
            {
                query["Payload"] = request.PayloadShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserInfoShrink))
            {
                query["UserInfo"] = request.UserInfoShrink;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsAligenieAccessToken))
            {
                realHeaders["x-acs-aligenie-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsAligenieAccessToken);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Authorization))
            {
                realHeaders["Authorization"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Authorization);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetBusAppConfig",
                Version = "iap_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/iap/app/config/get",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetBusAppConfigResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetBusAppConfigResponse> GetBusAppConfigWithOptionsAsync(GetBusAppConfigRequest tmpReq, GetBusAppConfigHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GetBusAppConfigShrinkRequest request = new GetBusAppConfigShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DeviceInfo))
            {
                request.DeviceInfoShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DeviceInfo, "DeviceInfo", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Payload))
            {
                request.PayloadShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Payload, "Payload", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.UserInfo))
            {
                request.UserInfoShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.UserInfo, "UserInfo", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceInfoShrink))
            {
                query["DeviceInfo"] = request.DeviceInfoShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PayloadShrink))
            {
                query["Payload"] = request.PayloadShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserInfoShrink))
            {
                query["UserInfo"] = request.UserInfoShrink;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsAligenieAccessToken))
            {
                realHeaders["x-acs-aligenie-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsAligenieAccessToken);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Authorization))
            {
                realHeaders["Authorization"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Authorization);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetBusAppConfig",
                Version = "iap_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/iap/app/config/get",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetBusAppConfigResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetBusAppConfigResponse GetBusAppConfig(GetBusAppConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetBusAppConfigHeaders headers = new GetBusAppConfigHeaders();
            return GetBusAppConfigWithOptions(request, headers, runtime);
        }

        public async Task<GetBusAppConfigResponse> GetBusAppConfigAsync(GetBusAppConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetBusAppConfigHeaders headers = new GetBusAppConfigHeaders();
            return await GetBusAppConfigWithOptionsAsync(request, headers, runtime);
        }

        public GetPhoneNumberResponse GetPhoneNumberWithOptions(GetPhoneNumberRequest tmpReq, GetPhoneNumberHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GetPhoneNumberShrinkRequest request = new GetPhoneNumberShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DeviceInfo))
            {
                request.DeviceInfoShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DeviceInfo, "DeviceInfo", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.UserInfo))
            {
                request.UserInfoShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.UserInfo, "UserInfo", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceInfoShrink))
            {
                query["DeviceInfo"] = request.DeviceInfoShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserInfoShrink))
            {
                query["UserInfo"] = request.UserInfoShrink;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsAligenieAccessToken))
            {
                realHeaders["x-acs-aligenie-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsAligenieAccessToken);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Authorization))
            {
                realHeaders["Authorization"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Authorization);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetPhoneNumber",
                Version = "iap_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/iap/profile/phoneNumber",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetPhoneNumberResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetPhoneNumberResponse> GetPhoneNumberWithOptionsAsync(GetPhoneNumberRequest tmpReq, GetPhoneNumberHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GetPhoneNumberShrinkRequest request = new GetPhoneNumberShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DeviceInfo))
            {
                request.DeviceInfoShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DeviceInfo, "DeviceInfo", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.UserInfo))
            {
                request.UserInfoShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.UserInfo, "UserInfo", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceInfoShrink))
            {
                query["DeviceInfo"] = request.DeviceInfoShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserInfoShrink))
            {
                query["UserInfo"] = request.UserInfoShrink;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsAligenieAccessToken))
            {
                realHeaders["x-acs-aligenie-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsAligenieAccessToken);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Authorization))
            {
                realHeaders["Authorization"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Authorization);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetPhoneNumber",
                Version = "iap_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/iap/profile/phoneNumber",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetPhoneNumberResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetPhoneNumberResponse GetPhoneNumber(GetPhoneNumberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetPhoneNumberHeaders headers = new GetPhoneNumberHeaders();
            return GetPhoneNumberWithOptions(request, headers, runtime);
        }

        public async Task<GetPhoneNumberResponse> GetPhoneNumberAsync(GetPhoneNumberRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetPhoneNumberHeaders headers = new GetPhoneNumberHeaders();
            return await GetPhoneNumberWithOptionsAsync(request, headers, runtime);
        }

        public GetReminderResponse GetReminderWithOptions(GetReminderRequest tmpReq, GetReminderHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GetReminderShrinkRequest request = new GetReminderShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DeviceInfo))
            {
                request.DeviceInfoShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DeviceInfo, "DeviceInfo", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Payload))
            {
                request.PayloadShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Payload, "Payload", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.UserInfo))
            {
                request.UserInfoShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.UserInfo, "UserInfo", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceInfoShrink))
            {
                query["DeviceInfo"] = request.DeviceInfoShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PayloadShrink))
            {
                query["Payload"] = request.PayloadShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserInfoShrink))
            {
                query["UserInfo"] = request.UserInfoShrink;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsAligenieAccessToken))
            {
                realHeaders["x-acs-aligenie-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsAligenieAccessToken);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Authorization))
            {
                realHeaders["Authorization"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Authorization);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetReminder",
                Version = "iap_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/iap/reminder/get",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetReminderResponse>(CallApi(params_, req, runtime));
        }

        public async Task<GetReminderResponse> GetReminderWithOptionsAsync(GetReminderRequest tmpReq, GetReminderHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GetReminderShrinkRequest request = new GetReminderShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DeviceInfo))
            {
                request.DeviceInfoShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DeviceInfo, "DeviceInfo", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Payload))
            {
                request.PayloadShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Payload, "Payload", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.UserInfo))
            {
                request.UserInfoShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.UserInfo, "UserInfo", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceInfoShrink))
            {
                query["DeviceInfo"] = request.DeviceInfoShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PayloadShrink))
            {
                query["Payload"] = request.PayloadShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserInfoShrink))
            {
                query["UserInfo"] = request.UserInfoShrink;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsAligenieAccessToken))
            {
                realHeaders["x-acs-aligenie-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsAligenieAccessToken);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Authorization))
            {
                realHeaders["Authorization"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Authorization);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetReminder",
                Version = "iap_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/iap/reminder/get",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetReminderResponse>(await CallApiAsync(params_, req, runtime));
        }

        public GetReminderResponse GetReminder(GetReminderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetReminderHeaders headers = new GetReminderHeaders();
            return GetReminderWithOptions(request, headers, runtime);
        }

        public async Task<GetReminderResponse> GetReminderAsync(GetReminderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            GetReminderHeaders headers = new GetReminderHeaders();
            return await GetReminderWithOptionsAsync(request, headers, runtime);
        }

        public ListRemindersResponse ListRemindersWithOptions(ListRemindersRequest tmpReq, ListRemindersHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListRemindersShrinkRequest request = new ListRemindersShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DeviceInfo))
            {
                request.DeviceInfoShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DeviceInfo, "DeviceInfo", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Payload))
            {
                request.PayloadShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Payload, "Payload", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.UserInfo))
            {
                request.UserInfoShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.UserInfo, "UserInfo", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceInfoShrink))
            {
                query["DeviceInfo"] = request.DeviceInfoShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PayloadShrink))
            {
                query["Payload"] = request.PayloadShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserInfoShrink))
            {
                query["UserInfo"] = request.UserInfoShrink;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsAligenieAccessToken))
            {
                realHeaders["x-acs-aligenie-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsAligenieAccessToken);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Authorization))
            {
                realHeaders["Authorization"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Authorization);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListReminders",
                Version = "iap_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/iap/reminder/list",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListRemindersResponse>(CallApi(params_, req, runtime));
        }

        public async Task<ListRemindersResponse> ListRemindersWithOptionsAsync(ListRemindersRequest tmpReq, ListRemindersHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListRemindersShrinkRequest request = new ListRemindersShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DeviceInfo))
            {
                request.DeviceInfoShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DeviceInfo, "DeviceInfo", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Payload))
            {
                request.PayloadShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Payload, "Payload", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.UserInfo))
            {
                request.UserInfoShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.UserInfo, "UserInfo", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceInfoShrink))
            {
                query["DeviceInfo"] = request.DeviceInfoShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PayloadShrink))
            {
                query["Payload"] = request.PayloadShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserInfoShrink))
            {
                query["UserInfo"] = request.UserInfoShrink;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsAligenieAccessToken))
            {
                realHeaders["x-acs-aligenie-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsAligenieAccessToken);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Authorization))
            {
                realHeaders["Authorization"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Authorization);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListReminders",
                Version = "iap_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/iap/reminder/list",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListRemindersResponse>(await CallApiAsync(params_, req, runtime));
        }

        public ListRemindersResponse ListReminders(ListRemindersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListRemindersHeaders headers = new ListRemindersHeaders();
            return ListRemindersWithOptions(request, headers, runtime);
        }

        public async Task<ListRemindersResponse> ListRemindersAsync(ListRemindersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            ListRemindersHeaders headers = new ListRemindersHeaders();
            return await ListRemindersWithOptionsAsync(request, headers, runtime);
        }

        public PullCashierResponse PullCashierWithOptions(PullCashierRequest tmpReq, PullCashierHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            PullCashierShrinkRequest request = new PullCashierShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DeviceInfo))
            {
                request.DeviceInfoShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DeviceInfo, "DeviceInfo", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Payload))
            {
                request.PayloadShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Payload, "Payload", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.UserInfo))
            {
                request.UserInfoShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.UserInfo, "UserInfo", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceInfoShrink))
            {
                query["DeviceInfo"] = request.DeviceInfoShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PayloadShrink))
            {
                query["Payload"] = request.PayloadShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserInfoShrink))
            {
                query["UserInfo"] = request.UserInfoShrink;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsAligenieAccessToken))
            {
                realHeaders["x-acs-aligenie-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsAligenieAccessToken);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Authorization))
            {
                realHeaders["Authorization"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Authorization);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PullCashier",
                Version = "iap_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/iap/pull/cashier/",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<PullCashierResponse>(CallApi(params_, req, runtime));
        }

        public async Task<PullCashierResponse> PullCashierWithOptionsAsync(PullCashierRequest tmpReq, PullCashierHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            PullCashierShrinkRequest request = new PullCashierShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DeviceInfo))
            {
                request.DeviceInfoShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DeviceInfo, "DeviceInfo", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Payload))
            {
                request.PayloadShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Payload, "Payload", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.UserInfo))
            {
                request.UserInfoShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.UserInfo, "UserInfo", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceInfoShrink))
            {
                query["DeviceInfo"] = request.DeviceInfoShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PayloadShrink))
            {
                query["Payload"] = request.PayloadShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserInfoShrink))
            {
                query["UserInfo"] = request.UserInfoShrink;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsAligenieAccessToken))
            {
                realHeaders["x-acs-aligenie-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsAligenieAccessToken);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Authorization))
            {
                realHeaders["Authorization"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Authorization);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PullCashier",
                Version = "iap_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/iap/pull/cashier/",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<PullCashierResponse>(await CallApiAsync(params_, req, runtime));
        }

        public PullCashierResponse PullCashier(PullCashierRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            PullCashierHeaders headers = new PullCashierHeaders();
            return PullCashierWithOptions(request, headers, runtime);
        }

        public async Task<PullCashierResponse> PullCashierAsync(PullCashierRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            PullCashierHeaders headers = new PullCashierHeaders();
            return await PullCashierWithOptionsAsync(request, headers, runtime);
        }

        public PushNotificationsResponse PushNotificationsWithOptions(PushNotificationsRequest tmpReq, PushNotificationsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            PushNotificationsShrinkRequest request = new PushNotificationsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.NotificationUnicastRequest))
            {
                request.NotificationUnicastRequestShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.NotificationUnicastRequest, "NotificationUnicastRequest", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TenantInfo))
            {
                request.TenantInfoShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TenantInfo, "TenantInfo", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NotificationUnicastRequestShrink))
            {
                body["NotificationUnicastRequest"] = request.NotificationUnicastRequestShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantInfoShrink))
            {
                body["TenantInfo"] = request.TenantInfoShrink;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsAligenieAccessToken))
            {
                realHeaders["x-acs-aligenie-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsAligenieAccessToken);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Authorization))
            {
                realHeaders["Authorization"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Authorization);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PushNotifications",
                Version = "iap_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/iap/notifications",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "none",
            };
            return TeaModel.ToObject<PushNotificationsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<PushNotificationsResponse> PushNotificationsWithOptionsAsync(PushNotificationsRequest tmpReq, PushNotificationsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            PushNotificationsShrinkRequest request = new PushNotificationsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.NotificationUnicastRequest))
            {
                request.NotificationUnicastRequestShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.NotificationUnicastRequest, "NotificationUnicastRequest", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TenantInfo))
            {
                request.TenantInfoShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TenantInfo, "TenantInfo", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NotificationUnicastRequestShrink))
            {
                body["NotificationUnicastRequest"] = request.NotificationUnicastRequestShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantInfoShrink))
            {
                body["TenantInfo"] = request.TenantInfoShrink;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsAligenieAccessToken))
            {
                realHeaders["x-acs-aligenie-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsAligenieAccessToken);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Authorization))
            {
                realHeaders["Authorization"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Authorization);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "PushNotifications",
                Version = "iap_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/iap/notifications",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "none",
            };
            return TeaModel.ToObject<PushNotificationsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public PushNotificationsResponse PushNotifications(PushNotificationsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            PushNotificationsHeaders headers = new PushNotificationsHeaders();
            return PushNotificationsWithOptions(request, headers, runtime);
        }

        public async Task<PushNotificationsResponse> PushNotificationsAsync(PushNotificationsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            PushNotificationsHeaders headers = new PushNotificationsHeaders();
            return await PushNotificationsWithOptionsAsync(request, headers, runtime);
        }

        public SendNotificationsResponse SendNotificationsWithOptions(SendNotificationsRequest tmpReq, SendNotificationsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            SendNotificationsShrinkRequest request = new SendNotificationsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DeviceInfo))
            {
                request.DeviceInfoShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DeviceInfo, "DeviceInfo", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.NotificationUnicastRequest))
            {
                request.NotificationUnicastRequestShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.NotificationUnicastRequest, "NotificationUnicastRequest", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TenantInfo))
            {
                request.TenantInfoShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TenantInfo, "TenantInfo", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.UserInfo))
            {
                request.UserInfoShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.UserInfo, "UserInfo", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceInfoShrink))
            {
                body["DeviceInfo"] = request.DeviceInfoShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NotificationUnicastRequestShrink))
            {
                body["NotificationUnicastRequest"] = request.NotificationUnicastRequestShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantInfoShrink))
            {
                body["TenantInfo"] = request.TenantInfoShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserInfoShrink))
            {
                body["UserInfo"] = request.UserInfoShrink;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsAligenieAccessToken))
            {
                realHeaders["x-acs-aligenie-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsAligenieAccessToken);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Authorization))
            {
                realHeaders["Authorization"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Authorization);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SendNotifications",
                Version = "iap_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/iap/general/notifications",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "none",
            };
            return TeaModel.ToObject<SendNotificationsResponse>(CallApi(params_, req, runtime));
        }

        public async Task<SendNotificationsResponse> SendNotificationsWithOptionsAsync(SendNotificationsRequest tmpReq, SendNotificationsHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            SendNotificationsShrinkRequest request = new SendNotificationsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DeviceInfo))
            {
                request.DeviceInfoShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DeviceInfo, "DeviceInfo", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.NotificationUnicastRequest))
            {
                request.NotificationUnicastRequestShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.NotificationUnicastRequest, "NotificationUnicastRequest", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TenantInfo))
            {
                request.TenantInfoShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TenantInfo, "TenantInfo", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.UserInfo))
            {
                request.UserInfoShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.UserInfo, "UserInfo", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceInfoShrink))
            {
                body["DeviceInfo"] = request.DeviceInfoShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NotificationUnicastRequestShrink))
            {
                body["NotificationUnicastRequest"] = request.NotificationUnicastRequestShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantInfoShrink))
            {
                body["TenantInfo"] = request.TenantInfoShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserInfoShrink))
            {
                body["UserInfo"] = request.UserInfoShrink;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsAligenieAccessToken))
            {
                realHeaders["x-acs-aligenie-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsAligenieAccessToken);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Authorization))
            {
                realHeaders["Authorization"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Authorization);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SendNotifications",
                Version = "iap_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/iap/general/notifications",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "none",
            };
            return TeaModel.ToObject<SendNotificationsResponse>(await CallApiAsync(params_, req, runtime));
        }

        public SendNotificationsResponse SendNotifications(SendNotificationsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SendNotificationsHeaders headers = new SendNotificationsHeaders();
            return SendNotificationsWithOptions(request, headers, runtime);
        }

        public async Task<SendNotificationsResponse> SendNotificationsAsync(SendNotificationsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SendNotificationsHeaders headers = new SendNotificationsHeaders();
            return await SendNotificationsWithOptionsAsync(request, headers, runtime);
        }

        public UpdateReminderResponse UpdateReminderWithOptions(UpdateReminderRequest tmpReq, UpdateReminderHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateReminderShrinkRequest request = new UpdateReminderShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DeviceInfo))
            {
                request.DeviceInfoShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DeviceInfo, "DeviceInfo", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Payload))
            {
                request.PayloadShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Payload, "Payload", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.UserInfo))
            {
                request.UserInfoShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.UserInfo, "UserInfo", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceInfoShrink))
            {
                body["DeviceInfo"] = request.DeviceInfoShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PayloadShrink))
            {
                body["Payload"] = request.PayloadShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserInfoShrink))
            {
                body["UserInfo"] = request.UserInfoShrink;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsAligenieAccessToken))
            {
                realHeaders["x-acs-aligenie-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsAligenieAccessToken);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Authorization))
            {
                realHeaders["Authorization"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Authorization);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateReminder",
                Version = "iap_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/iap/reminder/update",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateReminderResponse>(CallApi(params_, req, runtime));
        }

        public async Task<UpdateReminderResponse> UpdateReminderWithOptionsAsync(UpdateReminderRequest tmpReq, UpdateReminderHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateReminderShrinkRequest request = new UpdateReminderShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DeviceInfo))
            {
                request.DeviceInfoShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DeviceInfo, "DeviceInfo", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Payload))
            {
                request.PayloadShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Payload, "Payload", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.UserInfo))
            {
                request.UserInfoShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.UserInfo, "UserInfo", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceInfoShrink))
            {
                body["DeviceInfo"] = request.DeviceInfoShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PayloadShrink))
            {
                body["Payload"] = request.PayloadShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserInfoShrink))
            {
                body["UserInfo"] = request.UserInfoShrink;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsAligenieAccessToken))
            {
                realHeaders["x-acs-aligenie-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsAligenieAccessToken);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Authorization))
            {
                realHeaders["Authorization"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Authorization);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateReminder",
                Version = "iap_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/iap/reminder/update",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateReminderResponse>(await CallApiAsync(params_, req, runtime));
        }

        public UpdateReminderResponse UpdateReminder(UpdateReminderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateReminderHeaders headers = new UpdateReminderHeaders();
            return UpdateReminderWithOptions(request, headers, runtime);
        }

        public async Task<UpdateReminderResponse> UpdateReminderAsync(UpdateReminderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateReminderHeaders headers = new UpdateReminderHeaders();
            return await UpdateReminderWithOptionsAsync(request, headers, runtime);
        }

        public VideoAppReportResponse VideoAppReportWithOptions(VideoAppReportRequest tmpReq, VideoAppReportHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            VideoAppReportShrinkRequest request = new VideoAppReportShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DeviceInfo))
            {
                request.DeviceInfoShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DeviceInfo, "DeviceInfo", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Payload))
            {
                request.PayloadShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Payload, "Payload", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.UserInfo))
            {
                request.UserInfoShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.UserInfo, "UserInfo", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceInfoShrink))
            {
                body["DeviceInfo"] = request.DeviceInfoShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PayloadShrink))
            {
                body["Payload"] = request.PayloadShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserInfoShrink))
            {
                body["UserInfo"] = request.UserInfoShrink;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsAligenieAccessToken))
            {
                realHeaders["x-acs-aligenie-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsAligenieAccessToken);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Authorization))
            {
                realHeaders["Authorization"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Authorization);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "VideoAppReport",
                Version = "iap_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/iap/vip/use/video/report",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<VideoAppReportResponse>(CallApi(params_, req, runtime));
        }

        public async Task<VideoAppReportResponse> VideoAppReportWithOptionsAsync(VideoAppReportRequest tmpReq, VideoAppReportHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            VideoAppReportShrinkRequest request = new VideoAppReportShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DeviceInfo))
            {
                request.DeviceInfoShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DeviceInfo, "DeviceInfo", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Payload))
            {
                request.PayloadShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Payload, "Payload", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.UserInfo))
            {
                request.UserInfoShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.UserInfo, "UserInfo", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DeviceInfoShrink))
            {
                body["DeviceInfo"] = request.DeviceInfoShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PayloadShrink))
            {
                body["Payload"] = request.PayloadShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserInfoShrink))
            {
                body["UserInfo"] = request.UserInfoShrink;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsAligenieAccessToken))
            {
                realHeaders["x-acs-aligenie-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsAligenieAccessToken);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Authorization))
            {
                realHeaders["Authorization"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Authorization);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "VideoAppReport",
                Version = "iap_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/iap/vip/use/video/report",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<VideoAppReportResponse>(await CallApiAsync(params_, req, runtime));
        }

        public VideoAppReportResponse VideoAppReport(VideoAppReportRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            VideoAppReportHeaders headers = new VideoAppReportHeaders();
            return VideoAppReportWithOptions(request, headers, runtime);
        }

        public async Task<VideoAppReportResponse> VideoAppReportAsync(VideoAppReportRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            VideoAppReportHeaders headers = new VideoAppReportHeaders();
            return await VideoAppReportWithOptionsAsync(request, headers, runtime);
        }

        public WakeUpAppResponse WakeUpAppWithOptions(WakeUpAppRequest request, WakeUpAppHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsDebug))
            {
                body["IsDebug"] = request.IsDebug;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Path))
            {
                body["Path"] = request.Path;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetInfo))
            {
                body["TargetInfo"] = request.TargetInfo;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsAligenieAccessToken))
            {
                realHeaders["x-acs-aligenie-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsAligenieAccessToken);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Authorization))
            {
                realHeaders["Authorization"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Authorization);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "WakeUpApp",
                Version = "iap_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/iap/wakeup",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<WakeUpAppResponse>(CallApi(params_, req, runtime));
        }

        public async Task<WakeUpAppResponse> WakeUpAppWithOptionsAsync(WakeUpAppRequest request, WakeUpAppHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsDebug))
            {
                body["IsDebug"] = request.IsDebug;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Path))
            {
                body["Path"] = request.Path;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TargetInfo))
            {
                body["TargetInfo"] = request.TargetInfo;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XAcsAligenieAccessToken))
            {
                realHeaders["x-acs-aligenie-access-token"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XAcsAligenieAccessToken);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.Authorization))
            {
                realHeaders["Authorization"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.Authorization);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "WakeUpApp",
                Version = "iap_1.0",
                Protocol = "HTTPS",
                Pathname = "/v1.0/iap/wakeup",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "none",
            };
            return TeaModel.ToObject<WakeUpAppResponse>(await CallApiAsync(params_, req, runtime));
        }

        public WakeUpAppResponse WakeUpApp(WakeUpAppRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            WakeUpAppHeaders headers = new WakeUpAppHeaders();
            return WakeUpAppWithOptions(request, headers, runtime);
        }

        public async Task<WakeUpAppResponse> WakeUpAppAsync(WakeUpAppRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            WakeUpAppHeaders headers = new WakeUpAppHeaders();
            return await WakeUpAppWithOptionsAsync(request, headers, runtime);
        }

    }
}
