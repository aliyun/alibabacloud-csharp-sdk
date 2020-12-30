// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Push20160801.Models;

namespace AlibabaCloud.SDK.Push20160801
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "regional";
            this._endpointMap = new Dictionary<string, string>
            {
                {"ap-northeast-1", "cloudpush.aliyuncs.com"},
                {"ap-northeast-2-pop", "cloudpush.aliyuncs.com"},
                {"ap-south-1", "cloudpush.aliyuncs.com"},
                {"ap-southeast-1", "cloudpush.aliyuncs.com"},
                {"ap-southeast-2", "cloudpush.aliyuncs.com"},
                {"ap-southeast-3", "cloudpush.aliyuncs.com"},
                {"ap-southeast-5", "cloudpush.aliyuncs.com"},
                {"cn-beijing", "cloudpush.aliyuncs.com"},
                {"cn-beijing-finance-1", "cloudpush.aliyuncs.com"},
                {"cn-beijing-finance-pop", "cloudpush.aliyuncs.com"},
                {"cn-beijing-gov-1", "cloudpush.aliyuncs.com"},
                {"cn-beijing-nu16-b01", "cloudpush.aliyuncs.com"},
                {"cn-chengdu", "cloudpush.aliyuncs.com"},
                {"cn-edge-1", "cloudpush.aliyuncs.com"},
                {"cn-fujian", "cloudpush.aliyuncs.com"},
                {"cn-haidian-cm12-c01", "cloudpush.aliyuncs.com"},
                {"cn-hangzhou", "cloudpush.aliyuncs.com"},
                {"cn-hangzhou-bj-b01", "cloudpush.aliyuncs.com"},
                {"cn-hangzhou-finance", "cloudpush.aliyuncs.com"},
                {"cn-hangzhou-internal-prod-1", "cloudpush.aliyuncs.com"},
                {"cn-hangzhou-internal-test-1", "cloudpush.aliyuncs.com"},
                {"cn-hangzhou-internal-test-2", "cloudpush.aliyuncs.com"},
                {"cn-hangzhou-internal-test-3", "cloudpush.aliyuncs.com"},
                {"cn-hangzhou-test-306", "cloudpush.aliyuncs.com"},
                {"cn-hongkong", "cloudpush.aliyuncs.com"},
                {"cn-hongkong-finance-pop", "cloudpush.aliyuncs.com"},
                {"cn-huhehaote", "cloudpush.aliyuncs.com"},
                {"cn-north-2-gov-1", "cloudpush.aliyuncs.com"},
                {"cn-qingdao", "cloudpush.aliyuncs.com"},
                {"cn-qingdao-nebula", "cloudpush.aliyuncs.com"},
                {"cn-shanghai", "cloudpush.aliyuncs.com"},
                {"cn-shanghai-et15-b01", "cloudpush.aliyuncs.com"},
                {"cn-shanghai-et2-b01", "cloudpush.aliyuncs.com"},
                {"cn-shanghai-finance-1", "cloudpush.aliyuncs.com"},
                {"cn-shanghai-inner", "cloudpush.aliyuncs.com"},
                {"cn-shanghai-internal-test-1", "cloudpush.aliyuncs.com"},
                {"cn-shenzhen", "cloudpush.aliyuncs.com"},
                {"cn-shenzhen-finance-1", "cloudpush.aliyuncs.com"},
                {"cn-shenzhen-inner", "cloudpush.aliyuncs.com"},
                {"cn-shenzhen-st4-d01", "cloudpush.aliyuncs.com"},
                {"cn-shenzhen-su18-b01", "cloudpush.aliyuncs.com"},
                {"cn-wuhan", "cloudpush.aliyuncs.com"},
                {"cn-yushanfang", "cloudpush.aliyuncs.com"},
                {"cn-zhangbei-na61-b01", "cloudpush.aliyuncs.com"},
                {"cn-zhangjiakou", "cloudpush.aliyuncs.com"},
                {"cn-zhangjiakou-na62-a01", "cloudpush.aliyuncs.com"},
                {"cn-zhengzhou-nebula-1", "cloudpush.aliyuncs.com"},
                {"eu-central-1", "cloudpush.aliyuncs.com"},
                {"eu-west-1", "cloudpush.aliyuncs.com"},
                {"eu-west-1-oxs", "cloudpush.aliyuncs.com"},
                {"me-east-1", "cloudpush.aliyuncs.com"},
                {"rus-west-1-pop", "cloudpush.aliyuncs.com"},
                {"us-east-1", "cloudpush.aliyuncs.com"},
                {"us-west-1", "cloudpush.aliyuncs.com"},
            };
            CheckConfig(config);
            this._endpoint = GetEndpoint("push", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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

        public BindAliasResponse BindAliasWithOptions(BindAliasRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<BindAliasResponse>(DoRPCRequest("BindAlias", "2016-08-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<BindAliasResponse> BindAliasWithOptionsAsync(BindAliasRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<BindAliasResponse>(await DoRPCRequestAsync("BindAlias", "2016-08-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public BindAliasResponse BindAlias(BindAliasRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return BindAliasWithOptions(request, runtime);
        }

        public async Task<BindAliasResponse> BindAliasAsync(BindAliasRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await BindAliasWithOptionsAsync(request, runtime);
        }

        public BindPhoneResponse BindPhoneWithOptions(BindPhoneRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<BindPhoneResponse>(DoRPCRequest("BindPhone", "2016-08-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<BindPhoneResponse> BindPhoneWithOptionsAsync(BindPhoneRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<BindPhoneResponse>(await DoRPCRequestAsync("BindPhone", "2016-08-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public BindPhoneResponse BindPhone(BindPhoneRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return BindPhoneWithOptions(request, runtime);
        }

        public async Task<BindPhoneResponse> BindPhoneAsync(BindPhoneRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await BindPhoneWithOptionsAsync(request, runtime);
        }

        public BindTagResponse BindTagWithOptions(BindTagRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<BindTagResponse>(DoRPCRequest("BindTag", "2016-08-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<BindTagResponse> BindTagWithOptionsAsync(BindTagRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<BindTagResponse>(await DoRPCRequestAsync("BindTag", "2016-08-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public BindTagResponse BindTag(BindTagRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return BindTagWithOptions(request, runtime);
        }

        public async Task<BindTagResponse> BindTagAsync(BindTagRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await BindTagWithOptionsAsync(request, runtime);
        }

        public CancelPushResponse CancelPushWithOptions(CancelPushRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CancelPushResponse>(DoRPCRequest("CancelPush", "2016-08-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CancelPushResponse> CancelPushWithOptionsAsync(CancelPushRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CancelPushResponse>(await DoRPCRequestAsync("CancelPush", "2016-08-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CancelPushResponse CancelPush(CancelPushRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CancelPushWithOptions(request, runtime);
        }

        public async Task<CancelPushResponse> CancelPushAsync(CancelPushRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CancelPushWithOptionsAsync(request, runtime);
        }

        public CheckDeviceResponse CheckDeviceWithOptions(CheckDeviceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CheckDeviceResponse>(DoRPCRequest("CheckDevice", "2016-08-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CheckDeviceResponse> CheckDeviceWithOptionsAsync(CheckDeviceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CheckDeviceResponse>(await DoRPCRequestAsync("CheckDevice", "2016-08-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CheckDeviceResponse CheckDevice(CheckDeviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CheckDeviceWithOptions(request, runtime);
        }

        public async Task<CheckDeviceResponse> CheckDeviceAsync(CheckDeviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CheckDeviceWithOptionsAsync(request, runtime);
        }

        public CheckDevicesResponse CheckDevicesWithOptions(CheckDevicesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CheckDevicesResponse>(DoRPCRequest("CheckDevices", "2016-08-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CheckDevicesResponse> CheckDevicesWithOptionsAsync(CheckDevicesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CheckDevicesResponse>(await DoRPCRequestAsync("CheckDevices", "2016-08-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CheckDevicesResponse CheckDevices(CheckDevicesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CheckDevicesWithOptions(request, runtime);
        }

        public async Task<CheckDevicesResponse> CheckDevicesAsync(CheckDevicesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CheckDevicesWithOptionsAsync(request, runtime);
        }

        public CompleteContinuouslyPushResponse CompleteContinuouslyPushWithOptions(CompleteContinuouslyPushRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CompleteContinuouslyPushResponse>(DoRPCRequest("CompleteContinuouslyPush", "2016-08-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CompleteContinuouslyPushResponse> CompleteContinuouslyPushWithOptionsAsync(CompleteContinuouslyPushRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CompleteContinuouslyPushResponse>(await DoRPCRequestAsync("CompleteContinuouslyPush", "2016-08-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CompleteContinuouslyPushResponse CompleteContinuouslyPush(CompleteContinuouslyPushRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CompleteContinuouslyPushWithOptions(request, runtime);
        }

        public async Task<CompleteContinuouslyPushResponse> CompleteContinuouslyPushAsync(CompleteContinuouslyPushRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CompleteContinuouslyPushWithOptionsAsync(request, runtime);
        }

        public ContinuouslyPushResponse ContinuouslyPushWithOptions(ContinuouslyPushRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ContinuouslyPushResponse>(DoRPCRequest("ContinuouslyPush", "2016-08-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ContinuouslyPushResponse> ContinuouslyPushWithOptionsAsync(ContinuouslyPushRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ContinuouslyPushResponse>(await DoRPCRequestAsync("ContinuouslyPush", "2016-08-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ContinuouslyPushResponse ContinuouslyPush(ContinuouslyPushRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ContinuouslyPushWithOptions(request, runtime);
        }

        public async Task<ContinuouslyPushResponse> ContinuouslyPushAsync(ContinuouslyPushRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ContinuouslyPushWithOptionsAsync(request, runtime);
        }

        public ListSummaryAppsResponse ListSummaryAppsWithOptions(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            return TeaModel.ToObject<ListSummaryAppsResponse>(DoRPCRequest("ListSummaryApps", "2016-08-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListSummaryAppsResponse> ListSummaryAppsWithOptionsAsync(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            return TeaModel.ToObject<ListSummaryAppsResponse>(await DoRPCRequestAsync("ListSummaryApps", "2016-08-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListSummaryAppsResponse ListSummaryApps()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListSummaryAppsWithOptions(runtime);
        }

        public async Task<ListSummaryAppsResponse> ListSummaryAppsAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListSummaryAppsWithOptionsAsync(runtime);
        }

        public ListTagsResponse ListTagsWithOptions(ListTagsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListTagsResponse>(DoRPCRequest("ListTags", "2016-08-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListTagsResponse> ListTagsWithOptionsAsync(ListTagsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListTagsResponse>(await DoRPCRequestAsync("ListTags", "2016-08-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListTagsResponse ListTags(ListTagsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListTagsWithOptions(request, runtime);
        }

        public async Task<ListTagsResponse> ListTagsAsync(ListTagsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListTagsWithOptionsAsync(request, runtime);
        }

        public MassPushResponse MassPushWithOptions(MassPushRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<MassPushResponse>(DoRPCRequest("MassPush", "2016-08-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<MassPushResponse> MassPushWithOptionsAsync(MassPushRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<MassPushResponse>(await DoRPCRequestAsync("MassPush", "2016-08-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public MassPushResponse MassPush(MassPushRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return MassPushWithOptions(request, runtime);
        }

        public async Task<MassPushResponse> MassPushAsync(MassPushRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await MassPushWithOptionsAsync(request, runtime);
        }

        public PushResponse PushWithOptions(PushRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<PushResponse>(DoRPCRequest("Push", "2016-08-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<PushResponse> PushWithOptionsAsync(PushRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<PushResponse>(await DoRPCRequestAsync("Push", "2016-08-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public PushResponse Push(PushRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return PushWithOptions(request, runtime);
        }

        public async Task<PushResponse> PushAsync(PushRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await PushWithOptionsAsync(request, runtime);
        }

        public PushMessageToAndroidResponse PushMessageToAndroidWithOptions(PushMessageToAndroidRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<PushMessageToAndroidResponse>(DoRPCRequest("PushMessageToAndroid", "2016-08-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<PushMessageToAndroidResponse> PushMessageToAndroidWithOptionsAsync(PushMessageToAndroidRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<PushMessageToAndroidResponse>(await DoRPCRequestAsync("PushMessageToAndroid", "2016-08-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public PushMessageToAndroidResponse PushMessageToAndroid(PushMessageToAndroidRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return PushMessageToAndroidWithOptions(request, runtime);
        }

        public async Task<PushMessageToAndroidResponse> PushMessageToAndroidAsync(PushMessageToAndroidRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await PushMessageToAndroidWithOptionsAsync(request, runtime);
        }

        public PushMessageToiOSResponse PushMessageToiOSWithOptions(PushMessageToiOSRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<PushMessageToiOSResponse>(DoRPCRequest("PushMessageToiOS", "2016-08-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<PushMessageToiOSResponse> PushMessageToiOSWithOptionsAsync(PushMessageToiOSRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<PushMessageToiOSResponse>(await DoRPCRequestAsync("PushMessageToiOS", "2016-08-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public PushMessageToiOSResponse PushMessageToiOS(PushMessageToiOSRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return PushMessageToiOSWithOptions(request, runtime);
        }

        public async Task<PushMessageToiOSResponse> PushMessageToiOSAsync(PushMessageToiOSRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await PushMessageToiOSWithOptionsAsync(request, runtime);
        }

        public PushNoticeToAndroidResponse PushNoticeToAndroidWithOptions(PushNoticeToAndroidRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<PushNoticeToAndroidResponse>(DoRPCRequest("PushNoticeToAndroid", "2016-08-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<PushNoticeToAndroidResponse> PushNoticeToAndroidWithOptionsAsync(PushNoticeToAndroidRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<PushNoticeToAndroidResponse>(await DoRPCRequestAsync("PushNoticeToAndroid", "2016-08-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public PushNoticeToAndroidResponse PushNoticeToAndroid(PushNoticeToAndroidRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return PushNoticeToAndroidWithOptions(request, runtime);
        }

        public async Task<PushNoticeToAndroidResponse> PushNoticeToAndroidAsync(PushNoticeToAndroidRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await PushNoticeToAndroidWithOptionsAsync(request, runtime);
        }

        public PushNoticeToiOSResponse PushNoticeToiOSWithOptions(PushNoticeToiOSRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<PushNoticeToiOSResponse>(DoRPCRequest("PushNoticeToiOS", "2016-08-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<PushNoticeToiOSResponse> PushNoticeToiOSWithOptionsAsync(PushNoticeToiOSRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<PushNoticeToiOSResponse>(await DoRPCRequestAsync("PushNoticeToiOS", "2016-08-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public PushNoticeToiOSResponse PushNoticeToiOS(PushNoticeToiOSRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return PushNoticeToiOSWithOptions(request, runtime);
        }

        public async Task<PushNoticeToiOSResponse> PushNoticeToiOSAsync(PushNoticeToiOSRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await PushNoticeToiOSWithOptionsAsync(request, runtime);
        }

        public QueryAliasesResponse QueryAliasesWithOptions(QueryAliasesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryAliasesResponse>(DoRPCRequest("QueryAliases", "2016-08-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<QueryAliasesResponse> QueryAliasesWithOptionsAsync(QueryAliasesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryAliasesResponse>(await DoRPCRequestAsync("QueryAliases", "2016-08-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public QueryAliasesResponse QueryAliases(QueryAliasesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryAliasesWithOptions(request, runtime);
        }

        public async Task<QueryAliasesResponse> QueryAliasesAsync(QueryAliasesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryAliasesWithOptionsAsync(request, runtime);
        }

        public QueryDeviceCountResponse QueryDeviceCountWithOptions(QueryDeviceCountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryDeviceCountResponse>(DoRPCRequest("QueryDeviceCount", "2016-08-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<QueryDeviceCountResponse> QueryDeviceCountWithOptionsAsync(QueryDeviceCountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryDeviceCountResponse>(await DoRPCRequestAsync("QueryDeviceCount", "2016-08-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public QueryDeviceCountResponse QueryDeviceCount(QueryDeviceCountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryDeviceCountWithOptions(request, runtime);
        }

        public async Task<QueryDeviceCountResponse> QueryDeviceCountAsync(QueryDeviceCountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryDeviceCountWithOptionsAsync(request, runtime);
        }

        public QueryDeviceInfoResponse QueryDeviceInfoWithOptions(QueryDeviceInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryDeviceInfoResponse>(DoRPCRequest("QueryDeviceInfo", "2016-08-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<QueryDeviceInfoResponse> QueryDeviceInfoWithOptionsAsync(QueryDeviceInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryDeviceInfoResponse>(await DoRPCRequestAsync("QueryDeviceInfo", "2016-08-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public QueryDeviceInfoResponse QueryDeviceInfo(QueryDeviceInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryDeviceInfoWithOptions(request, runtime);
        }

        public async Task<QueryDeviceInfoResponse> QueryDeviceInfoAsync(QueryDeviceInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryDeviceInfoWithOptionsAsync(request, runtime);
        }

        public QueryDevicesByAccountResponse QueryDevicesByAccountWithOptions(QueryDevicesByAccountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryDevicesByAccountResponse>(DoRPCRequest("QueryDevicesByAccount", "2016-08-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<QueryDevicesByAccountResponse> QueryDevicesByAccountWithOptionsAsync(QueryDevicesByAccountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryDevicesByAccountResponse>(await DoRPCRequestAsync("QueryDevicesByAccount", "2016-08-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public QueryDevicesByAccountResponse QueryDevicesByAccount(QueryDevicesByAccountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryDevicesByAccountWithOptions(request, runtime);
        }

        public async Task<QueryDevicesByAccountResponse> QueryDevicesByAccountAsync(QueryDevicesByAccountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryDevicesByAccountWithOptionsAsync(request, runtime);
        }

        public QueryDevicesByAliasResponse QueryDevicesByAliasWithOptions(QueryDevicesByAliasRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryDevicesByAliasResponse>(DoRPCRequest("QueryDevicesByAlias", "2016-08-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<QueryDevicesByAliasResponse> QueryDevicesByAliasWithOptionsAsync(QueryDevicesByAliasRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryDevicesByAliasResponse>(await DoRPCRequestAsync("QueryDevicesByAlias", "2016-08-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public QueryDevicesByAliasResponse QueryDevicesByAlias(QueryDevicesByAliasRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryDevicesByAliasWithOptions(request, runtime);
        }

        public async Task<QueryDevicesByAliasResponse> QueryDevicesByAliasAsync(QueryDevicesByAliasRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryDevicesByAliasWithOptionsAsync(request, runtime);
        }

        public QueryDeviceStatResponse QueryDeviceStatWithOptions(QueryDeviceStatRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryDeviceStatResponse>(DoRPCRequest("QueryDeviceStat", "2016-08-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<QueryDeviceStatResponse> QueryDeviceStatWithOptionsAsync(QueryDeviceStatRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryDeviceStatResponse>(await DoRPCRequestAsync("QueryDeviceStat", "2016-08-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public QueryDeviceStatResponse QueryDeviceStat(QueryDeviceStatRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryDeviceStatWithOptions(request, runtime);
        }

        public async Task<QueryDeviceStatResponse> QueryDeviceStatAsync(QueryDeviceStatRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryDeviceStatWithOptionsAsync(request, runtime);
        }

        public QueryPushRecordsResponse QueryPushRecordsWithOptions(QueryPushRecordsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryPushRecordsResponse>(DoRPCRequest("QueryPushRecords", "2016-08-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<QueryPushRecordsResponse> QueryPushRecordsWithOptionsAsync(QueryPushRecordsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryPushRecordsResponse>(await DoRPCRequestAsync("QueryPushRecords", "2016-08-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public QueryPushRecordsResponse QueryPushRecords(QueryPushRecordsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryPushRecordsWithOptions(request, runtime);
        }

        public async Task<QueryPushRecordsResponse> QueryPushRecordsAsync(QueryPushRecordsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryPushRecordsWithOptionsAsync(request, runtime);
        }

        public QueryPushStatByAppResponse QueryPushStatByAppWithOptions(QueryPushStatByAppRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryPushStatByAppResponse>(DoRPCRequest("QueryPushStatByApp", "2016-08-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<QueryPushStatByAppResponse> QueryPushStatByAppWithOptionsAsync(QueryPushStatByAppRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryPushStatByAppResponse>(await DoRPCRequestAsync("QueryPushStatByApp", "2016-08-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public QueryPushStatByAppResponse QueryPushStatByApp(QueryPushStatByAppRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryPushStatByAppWithOptions(request, runtime);
        }

        public async Task<QueryPushStatByAppResponse> QueryPushStatByAppAsync(QueryPushStatByAppRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryPushStatByAppWithOptionsAsync(request, runtime);
        }

        public QueryPushStatByMsgResponse QueryPushStatByMsgWithOptions(QueryPushStatByMsgRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryPushStatByMsgResponse>(DoRPCRequest("QueryPushStatByMsg", "2016-08-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<QueryPushStatByMsgResponse> QueryPushStatByMsgWithOptionsAsync(QueryPushStatByMsgRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryPushStatByMsgResponse>(await DoRPCRequestAsync("QueryPushStatByMsg", "2016-08-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public QueryPushStatByMsgResponse QueryPushStatByMsg(QueryPushStatByMsgRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryPushStatByMsgWithOptions(request, runtime);
        }

        public async Task<QueryPushStatByMsgResponse> QueryPushStatByMsgAsync(QueryPushStatByMsgRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryPushStatByMsgWithOptionsAsync(request, runtime);
        }

        public QueryTagsResponse QueryTagsWithOptions(QueryTagsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryTagsResponse>(DoRPCRequest("QueryTags", "2016-08-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<QueryTagsResponse> QueryTagsWithOptionsAsync(QueryTagsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryTagsResponse>(await DoRPCRequestAsync("QueryTags", "2016-08-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public QueryTagsResponse QueryTags(QueryTagsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryTagsWithOptions(request, runtime);
        }

        public async Task<QueryTagsResponse> QueryTagsAsync(QueryTagsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryTagsWithOptionsAsync(request, runtime);
        }

        public QueryUniqueDeviceStatResponse QueryUniqueDeviceStatWithOptions(QueryUniqueDeviceStatRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryUniqueDeviceStatResponse>(DoRPCRequest("QueryUniqueDeviceStat", "2016-08-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<QueryUniqueDeviceStatResponse> QueryUniqueDeviceStatWithOptionsAsync(QueryUniqueDeviceStatRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryUniqueDeviceStatResponse>(await DoRPCRequestAsync("QueryUniqueDeviceStat", "2016-08-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public QueryUniqueDeviceStatResponse QueryUniqueDeviceStat(QueryUniqueDeviceStatRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryUniqueDeviceStatWithOptions(request, runtime);
        }

        public async Task<QueryUniqueDeviceStatResponse> QueryUniqueDeviceStatAsync(QueryUniqueDeviceStatRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryUniqueDeviceStatWithOptionsAsync(request, runtime);
        }

        public RemoveTagResponse RemoveTagWithOptions(RemoveTagRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RemoveTagResponse>(DoRPCRequest("RemoveTag", "2016-08-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<RemoveTagResponse> RemoveTagWithOptionsAsync(RemoveTagRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RemoveTagResponse>(await DoRPCRequestAsync("RemoveTag", "2016-08-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public RemoveTagResponse RemoveTag(RemoveTagRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RemoveTagWithOptions(request, runtime);
        }

        public async Task<RemoveTagResponse> RemoveTagAsync(RemoveTagRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RemoveTagWithOptionsAsync(request, runtime);
        }

        public UnbindAliasResponse UnbindAliasWithOptions(UnbindAliasRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UnbindAliasResponse>(DoRPCRequest("UnbindAlias", "2016-08-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UnbindAliasResponse> UnbindAliasWithOptionsAsync(UnbindAliasRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UnbindAliasResponse>(await DoRPCRequestAsync("UnbindAlias", "2016-08-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UnbindAliasResponse UnbindAlias(UnbindAliasRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UnbindAliasWithOptions(request, runtime);
        }

        public async Task<UnbindAliasResponse> UnbindAliasAsync(UnbindAliasRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UnbindAliasWithOptionsAsync(request, runtime);
        }

        public UnbindPhoneResponse UnbindPhoneWithOptions(UnbindPhoneRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UnbindPhoneResponse>(DoRPCRequest("UnbindPhone", "2016-08-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UnbindPhoneResponse> UnbindPhoneWithOptionsAsync(UnbindPhoneRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UnbindPhoneResponse>(await DoRPCRequestAsync("UnbindPhone", "2016-08-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UnbindPhoneResponse UnbindPhone(UnbindPhoneRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UnbindPhoneWithOptions(request, runtime);
        }

        public async Task<UnbindPhoneResponse> UnbindPhoneAsync(UnbindPhoneRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UnbindPhoneWithOptionsAsync(request, runtime);
        }

        public UnbindTagResponse UnbindTagWithOptions(UnbindTagRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UnbindTagResponse>(DoRPCRequest("UnbindTag", "2016-08-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UnbindTagResponse> UnbindTagWithOptionsAsync(UnbindTagRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UnbindTagResponse>(await DoRPCRequestAsync("UnbindTag", "2016-08-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UnbindTagResponse UnbindTag(UnbindTagRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UnbindTagWithOptions(request, runtime);
        }

        public async Task<UnbindTagResponse> UnbindTagAsync(UnbindTagRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UnbindTagWithOptionsAsync(request, runtime);
        }

    }
}
