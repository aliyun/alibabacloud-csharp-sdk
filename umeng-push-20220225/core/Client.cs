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

    }
}
