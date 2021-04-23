// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Live20161101.Models;

namespace AlibabaCloud.SDK.Live20161101
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "regional";
            this._endpointMap = new Dictionary<string, string>
            {
                {"cn-qingdao", "live.aliyuncs.com"},
                {"cn-beijing", "live.aliyuncs.com"},
                {"cn-hangzhou", "live.aliyuncs.com"},
                {"cn-shanghai", "live.aliyuncs.com"},
                {"cn-shenzhen", "live.aliyuncs.com"},
                {"ap-southeast-1", "live.aliyuncs.com"},
                {"ap-southeast-5", "live.aliyuncs.com"},
                {"ap-northeast-1", "live.aliyuncs.com"},
                {"eu-central-1", "live.aliyuncs.com"},
                {"ap-south-1", "live.aliyuncs.com"},
                {"ap-northeast-2-pop", "live.ap-southeast-1.aliyuncs.com"},
                {"ap-southeast-2", "live.ap-southeast-1.aliyuncs.com"},
                {"ap-southeast-3", "live.ap-southeast-1.aliyuncs.com"},
                {"cn-beijing-finance-1", "live.aliyuncs.com"},
                {"cn-beijing-finance-pop", "live.aliyuncs.com"},
                {"cn-beijing-gov-1", "live.aliyuncs.com"},
                {"cn-beijing-nu16-b01", "live.aliyuncs.com"},
                {"cn-chengdu", "live.aliyuncs.com"},
                {"cn-edge-1", "live.aliyuncs.com"},
                {"cn-fujian", "live.aliyuncs.com"},
                {"cn-haidian-cm12-c01", "live.aliyuncs.com"},
                {"cn-hangzhou-bj-b01", "live.aliyuncs.com"},
                {"cn-hangzhou-finance", "live.aliyuncs.com"},
                {"cn-hangzhou-internal-prod-1", "live.aliyuncs.com"},
                {"cn-hangzhou-internal-test-1", "live.aliyuncs.com"},
                {"cn-hangzhou-internal-test-2", "live.aliyuncs.com"},
                {"cn-hangzhou-internal-test-3", "live.aliyuncs.com"},
                {"cn-hangzhou-test-306", "live.aliyuncs.com"},
                {"cn-hongkong", "live.aliyuncs.com"},
                {"cn-hongkong-finance-pop", "live.aliyuncs.com"},
                {"cn-huhehaote", "live.aliyuncs.com"},
                {"cn-north-2-gov-1", "live.aliyuncs.com"},
                {"cn-qingdao-nebula", "live.aliyuncs.com"},
                {"cn-shanghai-et15-b01", "live.aliyuncs.com"},
                {"cn-shanghai-et2-b01", "live.aliyuncs.com"},
                {"cn-shanghai-finance-1", "live.aliyuncs.com"},
                {"cn-shanghai-inner", "live.aliyuncs.com"},
                {"cn-shanghai-internal-test-1", "live.aliyuncs.com"},
                {"cn-shenzhen-finance-1", "live.aliyuncs.com"},
                {"cn-shenzhen-inner", "live.aliyuncs.com"},
                {"cn-shenzhen-st4-d01", "live.aliyuncs.com"},
                {"cn-shenzhen-su18-b01", "live.aliyuncs.com"},
                {"cn-wuhan", "live.aliyuncs.com"},
                {"cn-yushanfang", "live.aliyuncs.com"},
                {"cn-zhangbei-na61-b01", "live.aliyuncs.com"},
                {"cn-zhangjiakou", "live.aliyuncs.com"},
                {"cn-zhangjiakou-na62-a01", "live.aliyuncs.com"},
                {"cn-zhengzhou-nebula-1", "live.aliyuncs.com"},
                {"eu-west-1", "live.ap-southeast-1.aliyuncs.com"},
                {"eu-west-1-oxs", "live.ap-southeast-1.aliyuncs.com"},
                {"me-east-1", "live.ap-southeast-1.aliyuncs.com"},
                {"rus-west-1-pop", "live.ap-southeast-1.aliyuncs.com"},
                {"us-east-1", "live.ap-southeast-1.aliyuncs.com"},
                {"us-west-1", "live.ap-southeast-1.aliyuncs.com"},
            };
            CheckConfig(config);
            this._endpoint = GetEndpoint("live", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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

        public AddCasterComponentResponse AddCasterComponentWithOptions(AddCasterComponentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddCasterComponentResponse>(DoRPCRequest("AddCasterComponent", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<AddCasterComponentResponse> AddCasterComponentWithOptionsAsync(AddCasterComponentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddCasterComponentResponse>(await DoRPCRequestAsync("AddCasterComponent", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public AddCasterComponentResponse AddCasterComponent(AddCasterComponentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddCasterComponentWithOptions(request, runtime);
        }

        public async Task<AddCasterComponentResponse> AddCasterComponentAsync(AddCasterComponentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddCasterComponentWithOptionsAsync(request, runtime);
        }

        public AddCasterEpisodeResponse AddCasterEpisodeWithOptions(AddCasterEpisodeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddCasterEpisodeResponse>(DoRPCRequest("AddCasterEpisode", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<AddCasterEpisodeResponse> AddCasterEpisodeWithOptionsAsync(AddCasterEpisodeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddCasterEpisodeResponse>(await DoRPCRequestAsync("AddCasterEpisode", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public AddCasterEpisodeResponse AddCasterEpisode(AddCasterEpisodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddCasterEpisodeWithOptions(request, runtime);
        }

        public async Task<AddCasterEpisodeResponse> AddCasterEpisodeAsync(AddCasterEpisodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddCasterEpisodeWithOptionsAsync(request, runtime);
        }

        public AddCasterEpisodeGroupResponse AddCasterEpisodeGroupWithOptions(AddCasterEpisodeGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddCasterEpisodeGroupResponse>(DoRPCRequest("AddCasterEpisodeGroup", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<AddCasterEpisodeGroupResponse> AddCasterEpisodeGroupWithOptionsAsync(AddCasterEpisodeGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddCasterEpisodeGroupResponse>(await DoRPCRequestAsync("AddCasterEpisodeGroup", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public AddCasterEpisodeGroupResponse AddCasterEpisodeGroup(AddCasterEpisodeGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddCasterEpisodeGroupWithOptions(request, runtime);
        }

        public async Task<AddCasterEpisodeGroupResponse> AddCasterEpisodeGroupAsync(AddCasterEpisodeGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddCasterEpisodeGroupWithOptionsAsync(request, runtime);
        }

        public AddCasterEpisodeGroupContentResponse AddCasterEpisodeGroupContentWithOptions(AddCasterEpisodeGroupContentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddCasterEpisodeGroupContentResponse>(DoRPCRequest("AddCasterEpisodeGroupContent", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<AddCasterEpisodeGroupContentResponse> AddCasterEpisodeGroupContentWithOptionsAsync(AddCasterEpisodeGroupContentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddCasterEpisodeGroupContentResponse>(await DoRPCRequestAsync("AddCasterEpisodeGroupContent", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public AddCasterEpisodeGroupContentResponse AddCasterEpisodeGroupContent(AddCasterEpisodeGroupContentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddCasterEpisodeGroupContentWithOptions(request, runtime);
        }

        public async Task<AddCasterEpisodeGroupContentResponse> AddCasterEpisodeGroupContentAsync(AddCasterEpisodeGroupContentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddCasterEpisodeGroupContentWithOptionsAsync(request, runtime);
        }

        public AddCasterLayoutResponse AddCasterLayoutWithOptions(AddCasterLayoutRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddCasterLayoutResponse>(DoRPCRequest("AddCasterLayout", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<AddCasterLayoutResponse> AddCasterLayoutWithOptionsAsync(AddCasterLayoutRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddCasterLayoutResponse>(await DoRPCRequestAsync("AddCasterLayout", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public AddCasterLayoutResponse AddCasterLayout(AddCasterLayoutRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddCasterLayoutWithOptions(request, runtime);
        }

        public async Task<AddCasterLayoutResponse> AddCasterLayoutAsync(AddCasterLayoutRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddCasterLayoutWithOptionsAsync(request, runtime);
        }

        public AddCasterProgramResponse AddCasterProgramWithOptions(AddCasterProgramRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddCasterProgramResponse>(DoRPCRequest("AddCasterProgram", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<AddCasterProgramResponse> AddCasterProgramWithOptionsAsync(AddCasterProgramRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddCasterProgramResponse>(await DoRPCRequestAsync("AddCasterProgram", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public AddCasterProgramResponse AddCasterProgram(AddCasterProgramRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddCasterProgramWithOptions(request, runtime);
        }

        public async Task<AddCasterProgramResponse> AddCasterProgramAsync(AddCasterProgramRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddCasterProgramWithOptionsAsync(request, runtime);
        }

        public AddCasterVideoResourceResponse AddCasterVideoResourceWithOptions(AddCasterVideoResourceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddCasterVideoResourceResponse>(DoRPCRequest("AddCasterVideoResource", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<AddCasterVideoResourceResponse> AddCasterVideoResourceWithOptionsAsync(AddCasterVideoResourceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddCasterVideoResourceResponse>(await DoRPCRequestAsync("AddCasterVideoResource", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public AddCasterVideoResourceResponse AddCasterVideoResource(AddCasterVideoResourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddCasterVideoResourceWithOptions(request, runtime);
        }

        public async Task<AddCasterVideoResourceResponse> AddCasterVideoResourceAsync(AddCasterVideoResourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddCasterVideoResourceWithOptionsAsync(request, runtime);
        }

        public AddCustomLiveStreamTranscodeResponse AddCustomLiveStreamTranscodeWithOptions(AddCustomLiveStreamTranscodeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddCustomLiveStreamTranscodeResponse>(DoRPCRequest("AddCustomLiveStreamTranscode", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<AddCustomLiveStreamTranscodeResponse> AddCustomLiveStreamTranscodeWithOptionsAsync(AddCustomLiveStreamTranscodeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddCustomLiveStreamTranscodeResponse>(await DoRPCRequestAsync("AddCustomLiveStreamTranscode", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public AddCustomLiveStreamTranscodeResponse AddCustomLiveStreamTranscode(AddCustomLiveStreamTranscodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddCustomLiveStreamTranscodeWithOptions(request, runtime);
        }

        public async Task<AddCustomLiveStreamTranscodeResponse> AddCustomLiveStreamTranscodeAsync(AddCustomLiveStreamTranscodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddCustomLiveStreamTranscodeWithOptionsAsync(request, runtime);
        }

        public AddDRMCertificateResponse AddDRMCertificateWithOptions(AddDRMCertificateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddDRMCertificateResponse>(DoRPCRequest("AddDRMCertificate", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<AddDRMCertificateResponse> AddDRMCertificateWithOptionsAsync(AddDRMCertificateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddDRMCertificateResponse>(await DoRPCRequestAsync("AddDRMCertificate", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public AddDRMCertificateResponse AddDRMCertificate(AddDRMCertificateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddDRMCertificateWithOptions(request, runtime);
        }

        public async Task<AddDRMCertificateResponse> AddDRMCertificateAsync(AddDRMCertificateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddDRMCertificateWithOptionsAsync(request, runtime);
        }

        public AddLiveAppRecordConfigResponse AddLiveAppRecordConfigWithOptions(AddLiveAppRecordConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddLiveAppRecordConfigResponse>(DoRPCRequest("AddLiveAppRecordConfig", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<AddLiveAppRecordConfigResponse> AddLiveAppRecordConfigWithOptionsAsync(AddLiveAppRecordConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddLiveAppRecordConfigResponse>(await DoRPCRequestAsync("AddLiveAppRecordConfig", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public AddLiveAppRecordConfigResponse AddLiveAppRecordConfig(AddLiveAppRecordConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddLiveAppRecordConfigWithOptions(request, runtime);
        }

        public async Task<AddLiveAppRecordConfigResponse> AddLiveAppRecordConfigAsync(AddLiveAppRecordConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddLiveAppRecordConfigWithOptionsAsync(request, runtime);
        }

        public AddLiveAppSnapshotConfigResponse AddLiveAppSnapshotConfigWithOptions(AddLiveAppSnapshotConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddLiveAppSnapshotConfigResponse>(DoRPCRequest("AddLiveAppSnapshotConfig", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<AddLiveAppSnapshotConfigResponse> AddLiveAppSnapshotConfigWithOptionsAsync(AddLiveAppSnapshotConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddLiveAppSnapshotConfigResponse>(await DoRPCRequestAsync("AddLiveAppSnapshotConfig", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public AddLiveAppSnapshotConfigResponse AddLiveAppSnapshotConfig(AddLiveAppSnapshotConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddLiveAppSnapshotConfigWithOptions(request, runtime);
        }

        public async Task<AddLiveAppSnapshotConfigResponse> AddLiveAppSnapshotConfigAsync(AddLiveAppSnapshotConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddLiveAppSnapshotConfigWithOptionsAsync(request, runtime);
        }

        public AddLiveASRConfigResponse AddLiveASRConfigWithOptions(AddLiveASRConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddLiveASRConfigResponse>(DoRPCRequest("AddLiveASRConfig", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<AddLiveASRConfigResponse> AddLiveASRConfigWithOptionsAsync(AddLiveASRConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddLiveASRConfigResponse>(await DoRPCRequestAsync("AddLiveASRConfig", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public AddLiveASRConfigResponse AddLiveASRConfig(AddLiveASRConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddLiveASRConfigWithOptions(request, runtime);
        }

        public async Task<AddLiveASRConfigResponse> AddLiveASRConfigAsync(AddLiveASRConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddLiveASRConfigWithOptionsAsync(request, runtime);
        }

        public AddLiveAudioAuditConfigResponse AddLiveAudioAuditConfigWithOptions(AddLiveAudioAuditConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddLiveAudioAuditConfigResponse>(DoRPCRequest("AddLiveAudioAuditConfig", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<AddLiveAudioAuditConfigResponse> AddLiveAudioAuditConfigWithOptionsAsync(AddLiveAudioAuditConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddLiveAudioAuditConfigResponse>(await DoRPCRequestAsync("AddLiveAudioAuditConfig", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public AddLiveAudioAuditConfigResponse AddLiveAudioAuditConfig(AddLiveAudioAuditConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddLiveAudioAuditConfigWithOptions(request, runtime);
        }

        public async Task<AddLiveAudioAuditConfigResponse> AddLiveAudioAuditConfigAsync(AddLiveAudioAuditConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddLiveAudioAuditConfigWithOptionsAsync(request, runtime);
        }

        public AddLiveAudioAuditNotifyConfigResponse AddLiveAudioAuditNotifyConfigWithOptions(AddLiveAudioAuditNotifyConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddLiveAudioAuditNotifyConfigResponse>(DoRPCRequest("AddLiveAudioAuditNotifyConfig", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<AddLiveAudioAuditNotifyConfigResponse> AddLiveAudioAuditNotifyConfigWithOptionsAsync(AddLiveAudioAuditNotifyConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddLiveAudioAuditNotifyConfigResponse>(await DoRPCRequestAsync("AddLiveAudioAuditNotifyConfig", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public AddLiveAudioAuditNotifyConfigResponse AddLiveAudioAuditNotifyConfig(AddLiveAudioAuditNotifyConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddLiveAudioAuditNotifyConfigWithOptions(request, runtime);
        }

        public async Task<AddLiveAudioAuditNotifyConfigResponse> AddLiveAudioAuditNotifyConfigAsync(AddLiveAudioAuditNotifyConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddLiveAudioAuditNotifyConfigWithOptionsAsync(request, runtime);
        }

        public AddLiveDetectNotifyConfigResponse AddLiveDetectNotifyConfigWithOptions(AddLiveDetectNotifyConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddLiveDetectNotifyConfigResponse>(DoRPCRequest("AddLiveDetectNotifyConfig", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<AddLiveDetectNotifyConfigResponse> AddLiveDetectNotifyConfigWithOptionsAsync(AddLiveDetectNotifyConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddLiveDetectNotifyConfigResponse>(await DoRPCRequestAsync("AddLiveDetectNotifyConfig", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public AddLiveDetectNotifyConfigResponse AddLiveDetectNotifyConfig(AddLiveDetectNotifyConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddLiveDetectNotifyConfigWithOptions(request, runtime);
        }

        public async Task<AddLiveDetectNotifyConfigResponse> AddLiveDetectNotifyConfigAsync(AddLiveDetectNotifyConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddLiveDetectNotifyConfigWithOptionsAsync(request, runtime);
        }

        public AddLiveDomainResponse AddLiveDomainWithOptions(AddLiveDomainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddLiveDomainResponse>(DoRPCRequest("AddLiveDomain", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<AddLiveDomainResponse> AddLiveDomainWithOptionsAsync(AddLiveDomainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddLiveDomainResponse>(await DoRPCRequestAsync("AddLiveDomain", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public AddLiveDomainResponse AddLiveDomain(AddLiveDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddLiveDomainWithOptions(request, runtime);
        }

        public async Task<AddLiveDomainResponse> AddLiveDomainAsync(AddLiveDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddLiveDomainWithOptionsAsync(request, runtime);
        }

        public AddLiveDomainMappingResponse AddLiveDomainMappingWithOptions(AddLiveDomainMappingRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddLiveDomainMappingResponse>(DoRPCRequest("AddLiveDomainMapping", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<AddLiveDomainMappingResponse> AddLiveDomainMappingWithOptionsAsync(AddLiveDomainMappingRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddLiveDomainMappingResponse>(await DoRPCRequestAsync("AddLiveDomainMapping", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public AddLiveDomainMappingResponse AddLiveDomainMapping(AddLiveDomainMappingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddLiveDomainMappingWithOptions(request, runtime);
        }

        public async Task<AddLiveDomainMappingResponse> AddLiveDomainMappingAsync(AddLiveDomainMappingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddLiveDomainMappingWithOptionsAsync(request, runtime);
        }

        public AddLiveDomainPlayMappingResponse AddLiveDomainPlayMappingWithOptions(AddLiveDomainPlayMappingRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddLiveDomainPlayMappingResponse>(DoRPCRequest("AddLiveDomainPlayMapping", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<AddLiveDomainPlayMappingResponse> AddLiveDomainPlayMappingWithOptionsAsync(AddLiveDomainPlayMappingRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddLiveDomainPlayMappingResponse>(await DoRPCRequestAsync("AddLiveDomainPlayMapping", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public AddLiveDomainPlayMappingResponse AddLiveDomainPlayMapping(AddLiveDomainPlayMappingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddLiveDomainPlayMappingWithOptions(request, runtime);
        }

        public async Task<AddLiveDomainPlayMappingResponse> AddLiveDomainPlayMappingAsync(AddLiveDomainPlayMappingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddLiveDomainPlayMappingWithOptionsAsync(request, runtime);
        }

        public AddLivePullStreamInfoConfigResponse AddLivePullStreamInfoConfigWithOptions(AddLivePullStreamInfoConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddLivePullStreamInfoConfigResponse>(DoRPCRequest("AddLivePullStreamInfoConfig", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<AddLivePullStreamInfoConfigResponse> AddLivePullStreamInfoConfigWithOptionsAsync(AddLivePullStreamInfoConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddLivePullStreamInfoConfigResponse>(await DoRPCRequestAsync("AddLivePullStreamInfoConfig", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public AddLivePullStreamInfoConfigResponse AddLivePullStreamInfoConfig(AddLivePullStreamInfoConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddLivePullStreamInfoConfigWithOptions(request, runtime);
        }

        public async Task<AddLivePullStreamInfoConfigResponse> AddLivePullStreamInfoConfigAsync(AddLivePullStreamInfoConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddLivePullStreamInfoConfigWithOptionsAsync(request, runtime);
        }

        public AddLiveRecordNotifyConfigResponse AddLiveRecordNotifyConfigWithOptions(AddLiveRecordNotifyConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddLiveRecordNotifyConfigResponse>(DoRPCRequest("AddLiveRecordNotifyConfig", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<AddLiveRecordNotifyConfigResponse> AddLiveRecordNotifyConfigWithOptionsAsync(AddLiveRecordNotifyConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddLiveRecordNotifyConfigResponse>(await DoRPCRequestAsync("AddLiveRecordNotifyConfig", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public AddLiveRecordNotifyConfigResponse AddLiveRecordNotifyConfig(AddLiveRecordNotifyConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddLiveRecordNotifyConfigWithOptions(request, runtime);
        }

        public async Task<AddLiveRecordNotifyConfigResponse> AddLiveRecordNotifyConfigAsync(AddLiveRecordNotifyConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddLiveRecordNotifyConfigWithOptionsAsync(request, runtime);
        }

        public AddLiveRecordVodConfigResponse AddLiveRecordVodConfigWithOptions(AddLiveRecordVodConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddLiveRecordVodConfigResponse>(DoRPCRequest("AddLiveRecordVodConfig", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<AddLiveRecordVodConfigResponse> AddLiveRecordVodConfigWithOptionsAsync(AddLiveRecordVodConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddLiveRecordVodConfigResponse>(await DoRPCRequestAsync("AddLiveRecordVodConfig", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public AddLiveRecordVodConfigResponse AddLiveRecordVodConfig(AddLiveRecordVodConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddLiveRecordVodConfigWithOptions(request, runtime);
        }

        public async Task<AddLiveRecordVodConfigResponse> AddLiveRecordVodConfigAsync(AddLiveRecordVodConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddLiveRecordVodConfigWithOptionsAsync(request, runtime);
        }

        public AddLiveSnapshotDetectPornConfigResponse AddLiveSnapshotDetectPornConfigWithOptions(AddLiveSnapshotDetectPornConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddLiveSnapshotDetectPornConfigResponse>(DoRPCRequest("AddLiveSnapshotDetectPornConfig", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<AddLiveSnapshotDetectPornConfigResponse> AddLiveSnapshotDetectPornConfigWithOptionsAsync(AddLiveSnapshotDetectPornConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddLiveSnapshotDetectPornConfigResponse>(await DoRPCRequestAsync("AddLiveSnapshotDetectPornConfig", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public AddLiveSnapshotDetectPornConfigResponse AddLiveSnapshotDetectPornConfig(AddLiveSnapshotDetectPornConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddLiveSnapshotDetectPornConfigWithOptions(request, runtime);
        }

        public async Task<AddLiveSnapshotDetectPornConfigResponse> AddLiveSnapshotDetectPornConfigAsync(AddLiveSnapshotDetectPornConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddLiveSnapshotDetectPornConfigWithOptionsAsync(request, runtime);
        }

        public AddLiveStreamTranscodeResponse AddLiveStreamTranscodeWithOptions(AddLiveStreamTranscodeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddLiveStreamTranscodeResponse>(DoRPCRequest("AddLiveStreamTranscode", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<AddLiveStreamTranscodeResponse> AddLiveStreamTranscodeWithOptionsAsync(AddLiveStreamTranscodeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddLiveStreamTranscodeResponse>(await DoRPCRequestAsync("AddLiveStreamTranscode", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public AddLiveStreamTranscodeResponse AddLiveStreamTranscode(AddLiveStreamTranscodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddLiveStreamTranscodeWithOptions(request, runtime);
        }

        public async Task<AddLiveStreamTranscodeResponse> AddLiveStreamTranscodeAsync(AddLiveStreamTranscodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddLiveStreamTranscodeWithOptionsAsync(request, runtime);
        }

        public AddMultiRateConfigResponse AddMultiRateConfigWithOptions(AddMultiRateConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddMultiRateConfigResponse>(DoRPCRequest("AddMultiRateConfig", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<AddMultiRateConfigResponse> AddMultiRateConfigWithOptionsAsync(AddMultiRateConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddMultiRateConfigResponse>(await DoRPCRequestAsync("AddMultiRateConfig", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public AddMultiRateConfigResponse AddMultiRateConfig(AddMultiRateConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddMultiRateConfigWithOptions(request, runtime);
        }

        public async Task<AddMultiRateConfigResponse> AddMultiRateConfigAsync(AddMultiRateConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddMultiRateConfigWithOptionsAsync(request, runtime);
        }

        public AddPlaylistItemsResponse AddPlaylistItemsWithOptions(AddPlaylistItemsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddPlaylistItemsResponse>(DoRPCRequest("AddPlaylistItems", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<AddPlaylistItemsResponse> AddPlaylistItemsWithOptionsAsync(AddPlaylistItemsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddPlaylistItemsResponse>(await DoRPCRequestAsync("AddPlaylistItems", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public AddPlaylistItemsResponse AddPlaylistItems(AddPlaylistItemsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddPlaylistItemsWithOptions(request, runtime);
        }

        public async Task<AddPlaylistItemsResponse> AddPlaylistItemsAsync(AddPlaylistItemsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddPlaylistItemsWithOptionsAsync(request, runtime);
        }

        public AddRtsLiveStreamTranscodeResponse AddRtsLiveStreamTranscodeWithOptions(AddRtsLiveStreamTranscodeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddRtsLiveStreamTranscodeResponse>(DoRPCRequest("AddRtsLiveStreamTranscode", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<AddRtsLiveStreamTranscodeResponse> AddRtsLiveStreamTranscodeWithOptionsAsync(AddRtsLiveStreamTranscodeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddRtsLiveStreamTranscodeResponse>(await DoRPCRequestAsync("AddRtsLiveStreamTranscode", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public AddRtsLiveStreamTranscodeResponse AddRtsLiveStreamTranscode(AddRtsLiveStreamTranscodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddRtsLiveStreamTranscodeWithOptions(request, runtime);
        }

        public async Task<AddRtsLiveStreamTranscodeResponse> AddRtsLiveStreamTranscodeAsync(AddRtsLiveStreamTranscodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddRtsLiveStreamTranscodeWithOptionsAsync(request, runtime);
        }

        public AddStudioLayoutResponse AddStudioLayoutWithOptions(AddStudioLayoutRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddStudioLayoutResponse>(DoRPCRequest("AddStudioLayout", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<AddStudioLayoutResponse> AddStudioLayoutWithOptionsAsync(AddStudioLayoutRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddStudioLayoutResponse>(await DoRPCRequestAsync("AddStudioLayout", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public AddStudioLayoutResponse AddStudioLayout(AddStudioLayoutRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddStudioLayoutWithOptions(request, runtime);
        }

        public async Task<AddStudioLayoutResponse> AddStudioLayoutAsync(AddStudioLayoutRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddStudioLayoutWithOptionsAsync(request, runtime);
        }

        public AddTrancodeSEIResponse AddTrancodeSEIWithOptions(AddTrancodeSEIRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddTrancodeSEIResponse>(DoRPCRequest("AddTrancodeSEI", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<AddTrancodeSEIResponse> AddTrancodeSEIWithOptionsAsync(AddTrancodeSEIRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddTrancodeSEIResponse>(await DoRPCRequestAsync("AddTrancodeSEI", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public AddTrancodeSEIResponse AddTrancodeSEI(AddTrancodeSEIRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddTrancodeSEIWithOptions(request, runtime);
        }

        public async Task<AddTrancodeSEIResponse> AddTrancodeSEIAsync(AddTrancodeSEIRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddTrancodeSEIWithOptionsAsync(request, runtime);
        }

        public AllowPushStreamResponse AllowPushStreamWithOptions(AllowPushStreamRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AllowPushStreamResponse>(DoRPCRequest("AllowPushStream", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<AllowPushStreamResponse> AllowPushStreamWithOptionsAsync(AllowPushStreamRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AllowPushStreamResponse>(await DoRPCRequestAsync("AllowPushStream", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public AllowPushStreamResponse AllowPushStream(AllowPushStreamRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AllowPushStreamWithOptions(request, runtime);
        }

        public async Task<AllowPushStreamResponse> AllowPushStreamAsync(AllowPushStreamRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AllowPushStreamWithOptionsAsync(request, runtime);
        }

        public ApplyBoardTokenResponse ApplyBoardTokenWithOptions(ApplyBoardTokenRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ApplyBoardTokenResponse>(DoRPCRequest("ApplyBoardToken", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ApplyBoardTokenResponse> ApplyBoardTokenWithOptionsAsync(ApplyBoardTokenRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ApplyBoardTokenResponse>(await DoRPCRequestAsync("ApplyBoardToken", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ApplyBoardTokenResponse ApplyBoardToken(ApplyBoardTokenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ApplyBoardTokenWithOptions(request, runtime);
        }

        public async Task<ApplyBoardTokenResponse> ApplyBoardTokenAsync(ApplyBoardTokenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ApplyBoardTokenWithOptionsAsync(request, runtime);
        }

        public ApplyRecordTokenResponse ApplyRecordTokenWithOptions(ApplyRecordTokenRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ApplyRecordTokenResponse>(DoRPCRequest("ApplyRecordToken", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ApplyRecordTokenResponse> ApplyRecordTokenWithOptionsAsync(ApplyRecordTokenRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ApplyRecordTokenResponse>(await DoRPCRequestAsync("ApplyRecordToken", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ApplyRecordTokenResponse ApplyRecordToken(ApplyRecordTokenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ApplyRecordTokenWithOptions(request, runtime);
        }

        public async Task<ApplyRecordTokenResponse> ApplyRecordTokenAsync(ApplyRecordTokenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ApplyRecordTokenWithOptionsAsync(request, runtime);
        }

        public BatchDeleteLiveDomainConfigsResponse BatchDeleteLiveDomainConfigsWithOptions(BatchDeleteLiveDomainConfigsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<BatchDeleteLiveDomainConfigsResponse>(DoRPCRequest("BatchDeleteLiveDomainConfigs", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<BatchDeleteLiveDomainConfigsResponse> BatchDeleteLiveDomainConfigsWithOptionsAsync(BatchDeleteLiveDomainConfigsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<BatchDeleteLiveDomainConfigsResponse>(await DoRPCRequestAsync("BatchDeleteLiveDomainConfigs", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public BatchDeleteLiveDomainConfigsResponse BatchDeleteLiveDomainConfigs(BatchDeleteLiveDomainConfigsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return BatchDeleteLiveDomainConfigsWithOptions(request, runtime);
        }

        public async Task<BatchDeleteLiveDomainConfigsResponse> BatchDeleteLiveDomainConfigsAsync(BatchDeleteLiveDomainConfigsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await BatchDeleteLiveDomainConfigsWithOptionsAsync(request, runtime);
        }

        public BatchSetLiveDomainConfigsResponse BatchSetLiveDomainConfigsWithOptions(BatchSetLiveDomainConfigsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<BatchSetLiveDomainConfigsResponse>(DoRPCRequest("BatchSetLiveDomainConfigs", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<BatchSetLiveDomainConfigsResponse> BatchSetLiveDomainConfigsWithOptionsAsync(BatchSetLiveDomainConfigsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<BatchSetLiveDomainConfigsResponse>(await DoRPCRequestAsync("BatchSetLiveDomainConfigs", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public BatchSetLiveDomainConfigsResponse BatchSetLiveDomainConfigs(BatchSetLiveDomainConfigsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return BatchSetLiveDomainConfigsWithOptions(request, runtime);
        }

        public async Task<BatchSetLiveDomainConfigsResponse> BatchSetLiveDomainConfigsAsync(BatchSetLiveDomainConfigsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await BatchSetLiveDomainConfigsWithOptionsAsync(request, runtime);
        }

        public CheckServiceForRoleResponse CheckServiceForRoleWithOptions(CheckServiceForRoleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CheckServiceForRoleResponse>(DoRPCRequest("CheckServiceForRole", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CheckServiceForRoleResponse> CheckServiceForRoleWithOptionsAsync(CheckServiceForRoleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CheckServiceForRoleResponse>(await DoRPCRequestAsync("CheckServiceForRole", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CheckServiceForRoleResponse CheckServiceForRole(CheckServiceForRoleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CheckServiceForRoleWithOptions(request, runtime);
        }

        public async Task<CheckServiceForRoleResponse> CheckServiceForRoleAsync(CheckServiceForRoleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CheckServiceForRoleWithOptionsAsync(request, runtime);
        }

        public CloseLiveShiftResponse CloseLiveShiftWithOptions(CloseLiveShiftRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CloseLiveShiftResponse>(DoRPCRequest("CloseLiveShift", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CloseLiveShiftResponse> CloseLiveShiftWithOptionsAsync(CloseLiveShiftRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CloseLiveShiftResponse>(await DoRPCRequestAsync("CloseLiveShift", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CloseLiveShiftResponse CloseLiveShift(CloseLiveShiftRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CloseLiveShiftWithOptions(request, runtime);
        }

        public async Task<CloseLiveShiftResponse> CloseLiveShiftAsync(CloseLiveShiftRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CloseLiveShiftWithOptionsAsync(request, runtime);
        }

        public CompleteBoardResponse CompleteBoardWithOptions(CompleteBoardRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CompleteBoardResponse>(DoRPCRequest("CompleteBoard", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CompleteBoardResponse> CompleteBoardWithOptionsAsync(CompleteBoardRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CompleteBoardResponse>(await DoRPCRequestAsync("CompleteBoard", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CompleteBoardResponse CompleteBoard(CompleteBoardRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CompleteBoardWithOptions(request, runtime);
        }

        public async Task<CompleteBoardResponse> CompleteBoardAsync(CompleteBoardRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CompleteBoardWithOptionsAsync(request, runtime);
        }

        public CompleteBoardRecordResponse CompleteBoardRecordWithOptions(CompleteBoardRecordRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CompleteBoardRecordResponse>(DoRPCRequest("CompleteBoardRecord", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CompleteBoardRecordResponse> CompleteBoardRecordWithOptionsAsync(CompleteBoardRecordRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CompleteBoardRecordResponse>(await DoRPCRequestAsync("CompleteBoardRecord", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CompleteBoardRecordResponse CompleteBoardRecord(CompleteBoardRecordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CompleteBoardRecordWithOptions(request, runtime);
        }

        public async Task<CompleteBoardRecordResponse> CompleteBoardRecordAsync(CompleteBoardRecordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CompleteBoardRecordWithOptionsAsync(request, runtime);
        }

        public ControlHtmlResourceResponse ControlHtmlResourceWithOptions(ControlHtmlResourceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ControlHtmlResourceResponse>(DoRPCRequest("ControlHtmlResource", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ControlHtmlResourceResponse> ControlHtmlResourceWithOptionsAsync(ControlHtmlResourceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ControlHtmlResourceResponse>(await DoRPCRequestAsync("ControlHtmlResource", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ControlHtmlResourceResponse ControlHtmlResource(ControlHtmlResourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ControlHtmlResourceWithOptions(request, runtime);
        }

        public async Task<ControlHtmlResourceResponse> ControlHtmlResourceAsync(ControlHtmlResourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ControlHtmlResourceWithOptionsAsync(request, runtime);
        }

        public CopyCasterResponse CopyCasterWithOptions(CopyCasterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CopyCasterResponse>(DoRPCRequest("CopyCaster", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CopyCasterResponse> CopyCasterWithOptionsAsync(CopyCasterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CopyCasterResponse>(await DoRPCRequestAsync("CopyCaster", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CopyCasterResponse CopyCaster(CopyCasterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CopyCasterWithOptions(request, runtime);
        }

        public async Task<CopyCasterResponse> CopyCasterAsync(CopyCasterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CopyCasterWithOptionsAsync(request, runtime);
        }

        public CopyCasterSceneConfigResponse CopyCasterSceneConfigWithOptions(CopyCasterSceneConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CopyCasterSceneConfigResponse>(DoRPCRequest("CopyCasterSceneConfig", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CopyCasterSceneConfigResponse> CopyCasterSceneConfigWithOptionsAsync(CopyCasterSceneConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CopyCasterSceneConfigResponse>(await DoRPCRequestAsync("CopyCasterSceneConfig", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CopyCasterSceneConfigResponse CopyCasterSceneConfig(CopyCasterSceneConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CopyCasterSceneConfigWithOptions(request, runtime);
        }

        public async Task<CopyCasterSceneConfigResponse> CopyCasterSceneConfigAsync(CopyCasterSceneConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CopyCasterSceneConfigWithOptionsAsync(request, runtime);
        }

        public CreateBoardResponse CreateBoardWithOptions(CreateBoardRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateBoardResponse>(DoRPCRequest("CreateBoard", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateBoardResponse> CreateBoardWithOptionsAsync(CreateBoardRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateBoardResponse>(await DoRPCRequestAsync("CreateBoard", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateBoardResponse CreateBoard(CreateBoardRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateBoardWithOptions(request, runtime);
        }

        public async Task<CreateBoardResponse> CreateBoardAsync(CreateBoardRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateBoardWithOptionsAsync(request, runtime);
        }

        public CreateCasterResponse CreateCasterWithOptions(CreateCasterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateCasterResponse>(DoRPCRequest("CreateCaster", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateCasterResponse> CreateCasterWithOptionsAsync(CreateCasterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateCasterResponse>(await DoRPCRequestAsync("CreateCaster", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateCasterResponse CreateCaster(CreateCasterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateCasterWithOptions(request, runtime);
        }

        public async Task<CreateCasterResponse> CreateCasterAsync(CreateCasterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateCasterWithOptionsAsync(request, runtime);
        }

        public CreateLiveRealTimeLogDeliveryResponse CreateLiveRealTimeLogDeliveryWithOptions(CreateLiveRealTimeLogDeliveryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<CreateLiveRealTimeLogDeliveryResponse>(DoRPCRequest("CreateLiveRealTimeLogDelivery", "2016-11-01", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<CreateLiveRealTimeLogDeliveryResponse> CreateLiveRealTimeLogDeliveryWithOptionsAsync(CreateLiveRealTimeLogDeliveryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<CreateLiveRealTimeLogDeliveryResponse>(await DoRPCRequestAsync("CreateLiveRealTimeLogDelivery", "2016-11-01", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public CreateLiveRealTimeLogDeliveryResponse CreateLiveRealTimeLogDelivery(CreateLiveRealTimeLogDeliveryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateLiveRealTimeLogDeliveryWithOptions(request, runtime);
        }

        public async Task<CreateLiveRealTimeLogDeliveryResponse> CreateLiveRealTimeLogDeliveryAsync(CreateLiveRealTimeLogDeliveryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateLiveRealTimeLogDeliveryWithOptionsAsync(request, runtime);
        }

        public CreateLiveStreamRecordIndexFilesResponse CreateLiveStreamRecordIndexFilesWithOptions(CreateLiveStreamRecordIndexFilesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateLiveStreamRecordIndexFilesResponse>(DoRPCRequest("CreateLiveStreamRecordIndexFiles", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateLiveStreamRecordIndexFilesResponse> CreateLiveStreamRecordIndexFilesWithOptionsAsync(CreateLiveStreamRecordIndexFilesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateLiveStreamRecordIndexFilesResponse>(await DoRPCRequestAsync("CreateLiveStreamRecordIndexFiles", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateLiveStreamRecordIndexFilesResponse CreateLiveStreamRecordIndexFiles(CreateLiveStreamRecordIndexFilesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateLiveStreamRecordIndexFilesWithOptions(request, runtime);
        }

        public async Task<CreateLiveStreamRecordIndexFilesResponse> CreateLiveStreamRecordIndexFilesAsync(CreateLiveStreamRecordIndexFilesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateLiveStreamRecordIndexFilesWithOptionsAsync(request, runtime);
        }

        public CreateMixStreamResponse CreateMixStreamWithOptions(CreateMixStreamRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateMixStreamResponse>(DoRPCRequest("CreateMixStream", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateMixStreamResponse> CreateMixStreamWithOptionsAsync(CreateMixStreamRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateMixStreamResponse>(await DoRPCRequestAsync("CreateMixStream", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateMixStreamResponse CreateMixStream(CreateMixStreamRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateMixStreamWithOptions(request, runtime);
        }

        public async Task<CreateMixStreamResponse> CreateMixStreamAsync(CreateMixStreamRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateMixStreamWithOptionsAsync(request, runtime);
        }

        public CreateRoomResponse CreateRoomWithOptions(CreateRoomRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateRoomResponse>(DoRPCRequest("CreateRoom", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateRoomResponse> CreateRoomWithOptionsAsync(CreateRoomRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateRoomResponse>(await DoRPCRequestAsync("CreateRoom", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateRoomResponse CreateRoom(CreateRoomRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateRoomWithOptions(request, runtime);
        }

        public async Task<CreateRoomResponse> CreateRoomAsync(CreateRoomRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateRoomWithOptionsAsync(request, runtime);
        }

        public DeleteBoardResponse DeleteBoardWithOptions(DeleteBoardRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteBoardResponse>(DoRPCRequest("DeleteBoard", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteBoardResponse> DeleteBoardWithOptionsAsync(DeleteBoardRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteBoardResponse>(await DoRPCRequestAsync("DeleteBoard", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteBoardResponse DeleteBoard(DeleteBoardRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteBoardWithOptions(request, runtime);
        }

        public async Task<DeleteBoardResponse> DeleteBoardAsync(DeleteBoardRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteBoardWithOptionsAsync(request, runtime);
        }

        public DeleteCasterResponse DeleteCasterWithOptions(DeleteCasterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteCasterResponse>(DoRPCRequest("DeleteCaster", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteCasterResponse> DeleteCasterWithOptionsAsync(DeleteCasterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteCasterResponse>(await DoRPCRequestAsync("DeleteCaster", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteCasterResponse DeleteCaster(DeleteCasterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteCasterWithOptions(request, runtime);
        }

        public async Task<DeleteCasterResponse> DeleteCasterAsync(DeleteCasterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteCasterWithOptionsAsync(request, runtime);
        }

        public DeleteCasterComponentResponse DeleteCasterComponentWithOptions(DeleteCasterComponentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteCasterComponentResponse>(DoRPCRequest("DeleteCasterComponent", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteCasterComponentResponse> DeleteCasterComponentWithOptionsAsync(DeleteCasterComponentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteCasterComponentResponse>(await DoRPCRequestAsync("DeleteCasterComponent", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteCasterComponentResponse DeleteCasterComponent(DeleteCasterComponentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteCasterComponentWithOptions(request, runtime);
        }

        public async Task<DeleteCasterComponentResponse> DeleteCasterComponentAsync(DeleteCasterComponentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteCasterComponentWithOptionsAsync(request, runtime);
        }

        public DeleteCasterEpisodeResponse DeleteCasterEpisodeWithOptions(DeleteCasterEpisodeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteCasterEpisodeResponse>(DoRPCRequest("DeleteCasterEpisode", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteCasterEpisodeResponse> DeleteCasterEpisodeWithOptionsAsync(DeleteCasterEpisodeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteCasterEpisodeResponse>(await DoRPCRequestAsync("DeleteCasterEpisode", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteCasterEpisodeResponse DeleteCasterEpisode(DeleteCasterEpisodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteCasterEpisodeWithOptions(request, runtime);
        }

        public async Task<DeleteCasterEpisodeResponse> DeleteCasterEpisodeAsync(DeleteCasterEpisodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteCasterEpisodeWithOptionsAsync(request, runtime);
        }

        public DeleteCasterEpisodeGroupResponse DeleteCasterEpisodeGroupWithOptions(DeleteCasterEpisodeGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteCasterEpisodeGroupResponse>(DoRPCRequest("DeleteCasterEpisodeGroup", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteCasterEpisodeGroupResponse> DeleteCasterEpisodeGroupWithOptionsAsync(DeleteCasterEpisodeGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteCasterEpisodeGroupResponse>(await DoRPCRequestAsync("DeleteCasterEpisodeGroup", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteCasterEpisodeGroupResponse DeleteCasterEpisodeGroup(DeleteCasterEpisodeGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteCasterEpisodeGroupWithOptions(request, runtime);
        }

        public async Task<DeleteCasterEpisodeGroupResponse> DeleteCasterEpisodeGroupAsync(DeleteCasterEpisodeGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteCasterEpisodeGroupWithOptionsAsync(request, runtime);
        }

        public DeleteCasterLayoutResponse DeleteCasterLayoutWithOptions(DeleteCasterLayoutRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteCasterLayoutResponse>(DoRPCRequest("DeleteCasterLayout", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteCasterLayoutResponse> DeleteCasterLayoutWithOptionsAsync(DeleteCasterLayoutRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteCasterLayoutResponse>(await DoRPCRequestAsync("DeleteCasterLayout", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteCasterLayoutResponse DeleteCasterLayout(DeleteCasterLayoutRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteCasterLayoutWithOptions(request, runtime);
        }

        public async Task<DeleteCasterLayoutResponse> DeleteCasterLayoutAsync(DeleteCasterLayoutRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteCasterLayoutWithOptionsAsync(request, runtime);
        }

        public DeleteCasterProgramResponse DeleteCasterProgramWithOptions(DeleteCasterProgramRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteCasterProgramResponse>(DoRPCRequest("DeleteCasterProgram", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteCasterProgramResponse> DeleteCasterProgramWithOptionsAsync(DeleteCasterProgramRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteCasterProgramResponse>(await DoRPCRequestAsync("DeleteCasterProgram", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteCasterProgramResponse DeleteCasterProgram(DeleteCasterProgramRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteCasterProgramWithOptions(request, runtime);
        }

        public async Task<DeleteCasterProgramResponse> DeleteCasterProgramAsync(DeleteCasterProgramRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteCasterProgramWithOptionsAsync(request, runtime);
        }

        public DeleteCasterSceneConfigResponse DeleteCasterSceneConfigWithOptions(DeleteCasterSceneConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteCasterSceneConfigResponse>(DoRPCRequest("DeleteCasterSceneConfig", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteCasterSceneConfigResponse> DeleteCasterSceneConfigWithOptionsAsync(DeleteCasterSceneConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteCasterSceneConfigResponse>(await DoRPCRequestAsync("DeleteCasterSceneConfig", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteCasterSceneConfigResponse DeleteCasterSceneConfig(DeleteCasterSceneConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteCasterSceneConfigWithOptions(request, runtime);
        }

        public async Task<DeleteCasterSceneConfigResponse> DeleteCasterSceneConfigAsync(DeleteCasterSceneConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteCasterSceneConfigWithOptionsAsync(request, runtime);
        }

        public DeleteCasterVideoResourceResponse DeleteCasterVideoResourceWithOptions(DeleteCasterVideoResourceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteCasterVideoResourceResponse>(DoRPCRequest("DeleteCasterVideoResource", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteCasterVideoResourceResponse> DeleteCasterVideoResourceWithOptionsAsync(DeleteCasterVideoResourceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteCasterVideoResourceResponse>(await DoRPCRequestAsync("DeleteCasterVideoResource", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteCasterVideoResourceResponse DeleteCasterVideoResource(DeleteCasterVideoResourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteCasterVideoResourceWithOptions(request, runtime);
        }

        public async Task<DeleteCasterVideoResourceResponse> DeleteCasterVideoResourceAsync(DeleteCasterVideoResourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteCasterVideoResourceWithOptionsAsync(request, runtime);
        }

        public DeleteHtmlResourceResponse DeleteHtmlResourceWithOptions(DeleteHtmlResourceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteHtmlResourceResponse>(DoRPCRequest("DeleteHtmlResource", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteHtmlResourceResponse> DeleteHtmlResourceWithOptionsAsync(DeleteHtmlResourceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteHtmlResourceResponse>(await DoRPCRequestAsync("DeleteHtmlResource", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteHtmlResourceResponse DeleteHtmlResource(DeleteHtmlResourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteHtmlResourceWithOptions(request, runtime);
        }

        public async Task<DeleteHtmlResourceResponse> DeleteHtmlResourceAsync(DeleteHtmlResourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteHtmlResourceWithOptionsAsync(request, runtime);
        }

        public DeleteLiveAppRecordConfigResponse DeleteLiveAppRecordConfigWithOptions(DeleteLiveAppRecordConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteLiveAppRecordConfigResponse>(DoRPCRequest("DeleteLiveAppRecordConfig", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteLiveAppRecordConfigResponse> DeleteLiveAppRecordConfigWithOptionsAsync(DeleteLiveAppRecordConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteLiveAppRecordConfigResponse>(await DoRPCRequestAsync("DeleteLiveAppRecordConfig", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteLiveAppRecordConfigResponse DeleteLiveAppRecordConfig(DeleteLiveAppRecordConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteLiveAppRecordConfigWithOptions(request, runtime);
        }

        public async Task<DeleteLiveAppRecordConfigResponse> DeleteLiveAppRecordConfigAsync(DeleteLiveAppRecordConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteLiveAppRecordConfigWithOptionsAsync(request, runtime);
        }

        public DeleteLiveAppSnapshotConfigResponse DeleteLiveAppSnapshotConfigWithOptions(DeleteLiveAppSnapshotConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteLiveAppSnapshotConfigResponse>(DoRPCRequest("DeleteLiveAppSnapshotConfig", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteLiveAppSnapshotConfigResponse> DeleteLiveAppSnapshotConfigWithOptionsAsync(DeleteLiveAppSnapshotConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteLiveAppSnapshotConfigResponse>(await DoRPCRequestAsync("DeleteLiveAppSnapshotConfig", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteLiveAppSnapshotConfigResponse DeleteLiveAppSnapshotConfig(DeleteLiveAppSnapshotConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteLiveAppSnapshotConfigWithOptions(request, runtime);
        }

        public async Task<DeleteLiveAppSnapshotConfigResponse> DeleteLiveAppSnapshotConfigAsync(DeleteLiveAppSnapshotConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteLiveAppSnapshotConfigWithOptionsAsync(request, runtime);
        }

        public DeleteLiveASRConfigResponse DeleteLiveASRConfigWithOptions(DeleteLiveASRConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteLiveASRConfigResponse>(DoRPCRequest("DeleteLiveASRConfig", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteLiveASRConfigResponse> DeleteLiveASRConfigWithOptionsAsync(DeleteLiveASRConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteLiveASRConfigResponse>(await DoRPCRequestAsync("DeleteLiveASRConfig", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteLiveASRConfigResponse DeleteLiveASRConfig(DeleteLiveASRConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteLiveASRConfigWithOptions(request, runtime);
        }

        public async Task<DeleteLiveASRConfigResponse> DeleteLiveASRConfigAsync(DeleteLiveASRConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteLiveASRConfigWithOptionsAsync(request, runtime);
        }

        public DeleteLiveAudioAuditConfigResponse DeleteLiveAudioAuditConfigWithOptions(DeleteLiveAudioAuditConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteLiveAudioAuditConfigResponse>(DoRPCRequest("DeleteLiveAudioAuditConfig", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteLiveAudioAuditConfigResponse> DeleteLiveAudioAuditConfigWithOptionsAsync(DeleteLiveAudioAuditConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteLiveAudioAuditConfigResponse>(await DoRPCRequestAsync("DeleteLiveAudioAuditConfig", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteLiveAudioAuditConfigResponse DeleteLiveAudioAuditConfig(DeleteLiveAudioAuditConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteLiveAudioAuditConfigWithOptions(request, runtime);
        }

        public async Task<DeleteLiveAudioAuditConfigResponse> DeleteLiveAudioAuditConfigAsync(DeleteLiveAudioAuditConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteLiveAudioAuditConfigWithOptionsAsync(request, runtime);
        }

        public DeleteLiveAudioAuditNotifyConfigResponse DeleteLiveAudioAuditNotifyConfigWithOptions(DeleteLiveAudioAuditNotifyConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteLiveAudioAuditNotifyConfigResponse>(DoRPCRequest("DeleteLiveAudioAuditNotifyConfig", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteLiveAudioAuditNotifyConfigResponse> DeleteLiveAudioAuditNotifyConfigWithOptionsAsync(DeleteLiveAudioAuditNotifyConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteLiveAudioAuditNotifyConfigResponse>(await DoRPCRequestAsync("DeleteLiveAudioAuditNotifyConfig", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteLiveAudioAuditNotifyConfigResponse DeleteLiveAudioAuditNotifyConfig(DeleteLiveAudioAuditNotifyConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteLiveAudioAuditNotifyConfigWithOptions(request, runtime);
        }

        public async Task<DeleteLiveAudioAuditNotifyConfigResponse> DeleteLiveAudioAuditNotifyConfigAsync(DeleteLiveAudioAuditNotifyConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteLiveAudioAuditNotifyConfigWithOptionsAsync(request, runtime);
        }

        public DeleteLiveDetectNotifyConfigResponse DeleteLiveDetectNotifyConfigWithOptions(DeleteLiveDetectNotifyConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteLiveDetectNotifyConfigResponse>(DoRPCRequest("DeleteLiveDetectNotifyConfig", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteLiveDetectNotifyConfigResponse> DeleteLiveDetectNotifyConfigWithOptionsAsync(DeleteLiveDetectNotifyConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteLiveDetectNotifyConfigResponse>(await DoRPCRequestAsync("DeleteLiveDetectNotifyConfig", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteLiveDetectNotifyConfigResponse DeleteLiveDetectNotifyConfig(DeleteLiveDetectNotifyConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteLiveDetectNotifyConfigWithOptions(request, runtime);
        }

        public async Task<DeleteLiveDetectNotifyConfigResponse> DeleteLiveDetectNotifyConfigAsync(DeleteLiveDetectNotifyConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteLiveDetectNotifyConfigWithOptionsAsync(request, runtime);
        }

        public DeleteLiveDomainResponse DeleteLiveDomainWithOptions(DeleteLiveDomainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteLiveDomainResponse>(DoRPCRequest("DeleteLiveDomain", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteLiveDomainResponse> DeleteLiveDomainWithOptionsAsync(DeleteLiveDomainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteLiveDomainResponse>(await DoRPCRequestAsync("DeleteLiveDomain", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteLiveDomainResponse DeleteLiveDomain(DeleteLiveDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteLiveDomainWithOptions(request, runtime);
        }

        public async Task<DeleteLiveDomainResponse> DeleteLiveDomainAsync(DeleteLiveDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteLiveDomainWithOptionsAsync(request, runtime);
        }

        public DeleteLiveDomainMappingResponse DeleteLiveDomainMappingWithOptions(DeleteLiveDomainMappingRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteLiveDomainMappingResponse>(DoRPCRequest("DeleteLiveDomainMapping", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteLiveDomainMappingResponse> DeleteLiveDomainMappingWithOptionsAsync(DeleteLiveDomainMappingRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteLiveDomainMappingResponse>(await DoRPCRequestAsync("DeleteLiveDomainMapping", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteLiveDomainMappingResponse DeleteLiveDomainMapping(DeleteLiveDomainMappingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteLiveDomainMappingWithOptions(request, runtime);
        }

        public async Task<DeleteLiveDomainMappingResponse> DeleteLiveDomainMappingAsync(DeleteLiveDomainMappingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteLiveDomainMappingWithOptionsAsync(request, runtime);
        }

        public DeleteLiveDomainPlayMappingResponse DeleteLiveDomainPlayMappingWithOptions(DeleteLiveDomainPlayMappingRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteLiveDomainPlayMappingResponse>(DoRPCRequest("DeleteLiveDomainPlayMapping", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteLiveDomainPlayMappingResponse> DeleteLiveDomainPlayMappingWithOptionsAsync(DeleteLiveDomainPlayMappingRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteLiveDomainPlayMappingResponse>(await DoRPCRequestAsync("DeleteLiveDomainPlayMapping", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteLiveDomainPlayMappingResponse DeleteLiveDomainPlayMapping(DeleteLiveDomainPlayMappingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteLiveDomainPlayMappingWithOptions(request, runtime);
        }

        public async Task<DeleteLiveDomainPlayMappingResponse> DeleteLiveDomainPlayMappingAsync(DeleteLiveDomainPlayMappingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteLiveDomainPlayMappingWithOptionsAsync(request, runtime);
        }

        public DeleteLiveLazyPullStreamInfoConfigResponse DeleteLiveLazyPullStreamInfoConfigWithOptions(DeleteLiveLazyPullStreamInfoConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteLiveLazyPullStreamInfoConfigResponse>(DoRPCRequest("DeleteLiveLazyPullStreamInfoConfig", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteLiveLazyPullStreamInfoConfigResponse> DeleteLiveLazyPullStreamInfoConfigWithOptionsAsync(DeleteLiveLazyPullStreamInfoConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteLiveLazyPullStreamInfoConfigResponse>(await DoRPCRequestAsync("DeleteLiveLazyPullStreamInfoConfig", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteLiveLazyPullStreamInfoConfigResponse DeleteLiveLazyPullStreamInfoConfig(DeleteLiveLazyPullStreamInfoConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteLiveLazyPullStreamInfoConfigWithOptions(request, runtime);
        }

        public async Task<DeleteLiveLazyPullStreamInfoConfigResponse> DeleteLiveLazyPullStreamInfoConfigAsync(DeleteLiveLazyPullStreamInfoConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteLiveLazyPullStreamInfoConfigWithOptionsAsync(request, runtime);
        }

        public DeleteLivePullStreamInfoConfigResponse DeleteLivePullStreamInfoConfigWithOptions(DeleteLivePullStreamInfoConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteLivePullStreamInfoConfigResponse>(DoRPCRequest("DeleteLivePullStreamInfoConfig", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteLivePullStreamInfoConfigResponse> DeleteLivePullStreamInfoConfigWithOptionsAsync(DeleteLivePullStreamInfoConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteLivePullStreamInfoConfigResponse>(await DoRPCRequestAsync("DeleteLivePullStreamInfoConfig", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteLivePullStreamInfoConfigResponse DeleteLivePullStreamInfoConfig(DeleteLivePullStreamInfoConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteLivePullStreamInfoConfigWithOptions(request, runtime);
        }

        public async Task<DeleteLivePullStreamInfoConfigResponse> DeleteLivePullStreamInfoConfigAsync(DeleteLivePullStreamInfoConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteLivePullStreamInfoConfigWithOptionsAsync(request, runtime);
        }

        public DeleteLiveRealtimeLogDeliveryResponse DeleteLiveRealtimeLogDeliveryWithOptions(DeleteLiveRealtimeLogDeliveryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<DeleteLiveRealtimeLogDeliveryResponse>(DoRPCRequest("DeleteLiveRealtimeLogDelivery", "2016-11-01", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<DeleteLiveRealtimeLogDeliveryResponse> DeleteLiveRealtimeLogDeliveryWithOptionsAsync(DeleteLiveRealtimeLogDeliveryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<DeleteLiveRealtimeLogDeliveryResponse>(await DoRPCRequestAsync("DeleteLiveRealtimeLogDelivery", "2016-11-01", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public DeleteLiveRealtimeLogDeliveryResponse DeleteLiveRealtimeLogDelivery(DeleteLiveRealtimeLogDeliveryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteLiveRealtimeLogDeliveryWithOptions(request, runtime);
        }

        public async Task<DeleteLiveRealtimeLogDeliveryResponse> DeleteLiveRealtimeLogDeliveryAsync(DeleteLiveRealtimeLogDeliveryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteLiveRealtimeLogDeliveryWithOptionsAsync(request, runtime);
        }

        public DeleteLiveRealTimeLogLogstoreResponse DeleteLiveRealTimeLogLogstoreWithOptions(DeleteLiveRealTimeLogLogstoreRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<DeleteLiveRealTimeLogLogstoreResponse>(DoRPCRequest("DeleteLiveRealTimeLogLogstore", "2016-11-01", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<DeleteLiveRealTimeLogLogstoreResponse> DeleteLiveRealTimeLogLogstoreWithOptionsAsync(DeleteLiveRealTimeLogLogstoreRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<DeleteLiveRealTimeLogLogstoreResponse>(await DoRPCRequestAsync("DeleteLiveRealTimeLogLogstore", "2016-11-01", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public DeleteLiveRealTimeLogLogstoreResponse DeleteLiveRealTimeLogLogstore(DeleteLiveRealTimeLogLogstoreRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteLiveRealTimeLogLogstoreWithOptions(request, runtime);
        }

        public async Task<DeleteLiveRealTimeLogLogstoreResponse> DeleteLiveRealTimeLogLogstoreAsync(DeleteLiveRealTimeLogLogstoreRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteLiveRealTimeLogLogstoreWithOptionsAsync(request, runtime);
        }

        public DeleteLiveRecordNotifyConfigResponse DeleteLiveRecordNotifyConfigWithOptions(DeleteLiveRecordNotifyConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteLiveRecordNotifyConfigResponse>(DoRPCRequest("DeleteLiveRecordNotifyConfig", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteLiveRecordNotifyConfigResponse> DeleteLiveRecordNotifyConfigWithOptionsAsync(DeleteLiveRecordNotifyConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteLiveRecordNotifyConfigResponse>(await DoRPCRequestAsync("DeleteLiveRecordNotifyConfig", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteLiveRecordNotifyConfigResponse DeleteLiveRecordNotifyConfig(DeleteLiveRecordNotifyConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteLiveRecordNotifyConfigWithOptions(request, runtime);
        }

        public async Task<DeleteLiveRecordNotifyConfigResponse> DeleteLiveRecordNotifyConfigAsync(DeleteLiveRecordNotifyConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteLiveRecordNotifyConfigWithOptionsAsync(request, runtime);
        }

        public DeleteLiveRecordVodConfigResponse DeleteLiveRecordVodConfigWithOptions(DeleteLiveRecordVodConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteLiveRecordVodConfigResponse>(DoRPCRequest("DeleteLiveRecordVodConfig", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteLiveRecordVodConfigResponse> DeleteLiveRecordVodConfigWithOptionsAsync(DeleteLiveRecordVodConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteLiveRecordVodConfigResponse>(await DoRPCRequestAsync("DeleteLiveRecordVodConfig", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteLiveRecordVodConfigResponse DeleteLiveRecordVodConfig(DeleteLiveRecordVodConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteLiveRecordVodConfigWithOptions(request, runtime);
        }

        public async Task<DeleteLiveRecordVodConfigResponse> DeleteLiveRecordVodConfigAsync(DeleteLiveRecordVodConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteLiveRecordVodConfigWithOptionsAsync(request, runtime);
        }

        public DeleteLiveSnapshotDetectPornConfigResponse DeleteLiveSnapshotDetectPornConfigWithOptions(DeleteLiveSnapshotDetectPornConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteLiveSnapshotDetectPornConfigResponse>(DoRPCRequest("DeleteLiveSnapshotDetectPornConfig", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteLiveSnapshotDetectPornConfigResponse> DeleteLiveSnapshotDetectPornConfigWithOptionsAsync(DeleteLiveSnapshotDetectPornConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteLiveSnapshotDetectPornConfigResponse>(await DoRPCRequestAsync("DeleteLiveSnapshotDetectPornConfig", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteLiveSnapshotDetectPornConfigResponse DeleteLiveSnapshotDetectPornConfig(DeleteLiveSnapshotDetectPornConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteLiveSnapshotDetectPornConfigWithOptions(request, runtime);
        }

        public async Task<DeleteLiveSnapshotDetectPornConfigResponse> DeleteLiveSnapshotDetectPornConfigAsync(DeleteLiveSnapshotDetectPornConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteLiveSnapshotDetectPornConfigWithOptionsAsync(request, runtime);
        }

        public DeleteLiveStreamsNotifyUrlConfigResponse DeleteLiveStreamsNotifyUrlConfigWithOptions(DeleteLiveStreamsNotifyUrlConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteLiveStreamsNotifyUrlConfigResponse>(DoRPCRequest("DeleteLiveStreamsNotifyUrlConfig", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteLiveStreamsNotifyUrlConfigResponse> DeleteLiveStreamsNotifyUrlConfigWithOptionsAsync(DeleteLiveStreamsNotifyUrlConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteLiveStreamsNotifyUrlConfigResponse>(await DoRPCRequestAsync("DeleteLiveStreamsNotifyUrlConfig", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteLiveStreamsNotifyUrlConfigResponse DeleteLiveStreamsNotifyUrlConfig(DeleteLiveStreamsNotifyUrlConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteLiveStreamsNotifyUrlConfigWithOptions(request, runtime);
        }

        public async Task<DeleteLiveStreamsNotifyUrlConfigResponse> DeleteLiveStreamsNotifyUrlConfigAsync(DeleteLiveStreamsNotifyUrlConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteLiveStreamsNotifyUrlConfigWithOptionsAsync(request, runtime);
        }

        public DeleteLiveStreamTranscodeResponse DeleteLiveStreamTranscodeWithOptions(DeleteLiveStreamTranscodeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteLiveStreamTranscodeResponse>(DoRPCRequest("DeleteLiveStreamTranscode", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteLiveStreamTranscodeResponse> DeleteLiveStreamTranscodeWithOptionsAsync(DeleteLiveStreamTranscodeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteLiveStreamTranscodeResponse>(await DoRPCRequestAsync("DeleteLiveStreamTranscode", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteLiveStreamTranscodeResponse DeleteLiveStreamTranscode(DeleteLiveStreamTranscodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteLiveStreamTranscodeWithOptions(request, runtime);
        }

        public async Task<DeleteLiveStreamTranscodeResponse> DeleteLiveStreamTranscodeAsync(DeleteLiveStreamTranscodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteLiveStreamTranscodeWithOptionsAsync(request, runtime);
        }

        public DeleteMixStreamResponse DeleteMixStreamWithOptions(DeleteMixStreamRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteMixStreamResponse>(DoRPCRequest("DeleteMixStream", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteMixStreamResponse> DeleteMixStreamWithOptionsAsync(DeleteMixStreamRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteMixStreamResponse>(await DoRPCRequestAsync("DeleteMixStream", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteMixStreamResponse DeleteMixStream(DeleteMixStreamRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteMixStreamWithOptions(request, runtime);
        }

        public async Task<DeleteMixStreamResponse> DeleteMixStreamAsync(DeleteMixStreamRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteMixStreamWithOptionsAsync(request, runtime);
        }

        public DeleteMultiRateConfigResponse DeleteMultiRateConfigWithOptions(DeleteMultiRateConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteMultiRateConfigResponse>(DoRPCRequest("DeleteMultiRateConfig", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteMultiRateConfigResponse> DeleteMultiRateConfigWithOptionsAsync(DeleteMultiRateConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteMultiRateConfigResponse>(await DoRPCRequestAsync("DeleteMultiRateConfig", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteMultiRateConfigResponse DeleteMultiRateConfig(DeleteMultiRateConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteMultiRateConfigWithOptions(request, runtime);
        }

        public async Task<DeleteMultiRateConfigResponse> DeleteMultiRateConfigAsync(DeleteMultiRateConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteMultiRateConfigWithOptionsAsync(request, runtime);
        }

        public DeletePlaylistResponse DeletePlaylistWithOptions(DeletePlaylistRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeletePlaylistResponse>(DoRPCRequest("DeletePlaylist", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeletePlaylistResponse> DeletePlaylistWithOptionsAsync(DeletePlaylistRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeletePlaylistResponse>(await DoRPCRequestAsync("DeletePlaylist", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeletePlaylistResponse DeletePlaylist(DeletePlaylistRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeletePlaylistWithOptions(request, runtime);
        }

        public async Task<DeletePlaylistResponse> DeletePlaylistAsync(DeletePlaylistRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeletePlaylistWithOptionsAsync(request, runtime);
        }

        public DeletePlaylistItemsResponse DeletePlaylistItemsWithOptions(DeletePlaylistItemsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeletePlaylistItemsResponse>(DoRPCRequest("DeletePlaylistItems", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeletePlaylistItemsResponse> DeletePlaylistItemsWithOptionsAsync(DeletePlaylistItemsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeletePlaylistItemsResponse>(await DoRPCRequestAsync("DeletePlaylistItems", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeletePlaylistItemsResponse DeletePlaylistItems(DeletePlaylistItemsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeletePlaylistItemsWithOptions(request, runtime);
        }

        public async Task<DeletePlaylistItemsResponse> DeletePlaylistItemsAsync(DeletePlaylistItemsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeletePlaylistItemsWithOptionsAsync(request, runtime);
        }

        public DeleteRoomResponse DeleteRoomWithOptions(DeleteRoomRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteRoomResponse>(DoRPCRequest("DeleteRoom", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteRoomResponse> DeleteRoomWithOptionsAsync(DeleteRoomRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteRoomResponse>(await DoRPCRequestAsync("DeleteRoom", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteRoomResponse DeleteRoom(DeleteRoomRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteRoomWithOptions(request, runtime);
        }

        public async Task<DeleteRoomResponse> DeleteRoomAsync(DeleteRoomRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteRoomWithOptionsAsync(request, runtime);
        }

        public DeleteStudioLayoutResponse DeleteStudioLayoutWithOptions(DeleteStudioLayoutRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteStudioLayoutResponse>(DoRPCRequest("DeleteStudioLayout", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteStudioLayoutResponse> DeleteStudioLayoutWithOptionsAsync(DeleteStudioLayoutRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteStudioLayoutResponse>(await DoRPCRequestAsync("DeleteStudioLayout", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteStudioLayoutResponse DeleteStudioLayout(DeleteStudioLayoutRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteStudioLayoutWithOptions(request, runtime);
        }

        public async Task<DeleteStudioLayoutResponse> DeleteStudioLayoutAsync(DeleteStudioLayoutRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteStudioLayoutWithOptionsAsync(request, runtime);
        }

        public DescribeBoardEventsResponse DescribeBoardEventsWithOptions(DescribeBoardEventsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeBoardEventsResponse>(DoRPCRequest("DescribeBoardEvents", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeBoardEventsResponse> DescribeBoardEventsWithOptionsAsync(DescribeBoardEventsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeBoardEventsResponse>(await DoRPCRequestAsync("DescribeBoardEvents", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeBoardEventsResponse DescribeBoardEvents(DescribeBoardEventsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeBoardEventsWithOptions(request, runtime);
        }

        public async Task<DescribeBoardEventsResponse> DescribeBoardEventsAsync(DescribeBoardEventsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeBoardEventsWithOptionsAsync(request, runtime);
        }

        public DescribeBoardsResponse DescribeBoardsWithOptions(DescribeBoardsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeBoardsResponse>(DoRPCRequest("DescribeBoards", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeBoardsResponse> DescribeBoardsWithOptionsAsync(DescribeBoardsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeBoardsResponse>(await DoRPCRequestAsync("DescribeBoards", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeBoardsResponse DescribeBoards(DescribeBoardsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeBoardsWithOptions(request, runtime);
        }

        public async Task<DescribeBoardsResponse> DescribeBoardsAsync(DescribeBoardsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeBoardsWithOptionsAsync(request, runtime);
        }

        public DescribeBoardSnapshotResponse DescribeBoardSnapshotWithOptions(DescribeBoardSnapshotRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeBoardSnapshotResponse>(DoRPCRequest("DescribeBoardSnapshot", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeBoardSnapshotResponse> DescribeBoardSnapshotWithOptionsAsync(DescribeBoardSnapshotRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeBoardSnapshotResponse>(await DoRPCRequestAsync("DescribeBoardSnapshot", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeBoardSnapshotResponse DescribeBoardSnapshot(DescribeBoardSnapshotRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeBoardSnapshotWithOptions(request, runtime);
        }

        public async Task<DescribeBoardSnapshotResponse> DescribeBoardSnapshotAsync(DescribeBoardSnapshotRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeBoardSnapshotWithOptionsAsync(request, runtime);
        }

        public DescribeCasterChannelsResponse DescribeCasterChannelsWithOptions(DescribeCasterChannelsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeCasterChannelsResponse>(DoRPCRequest("DescribeCasterChannels", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeCasterChannelsResponse> DescribeCasterChannelsWithOptionsAsync(DescribeCasterChannelsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeCasterChannelsResponse>(await DoRPCRequestAsync("DescribeCasterChannels", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeCasterChannelsResponse DescribeCasterChannels(DescribeCasterChannelsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeCasterChannelsWithOptions(request, runtime);
        }

        public async Task<DescribeCasterChannelsResponse> DescribeCasterChannelsAsync(DescribeCasterChannelsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeCasterChannelsWithOptionsAsync(request, runtime);
        }

        public DescribeCasterComponentsResponse DescribeCasterComponentsWithOptions(DescribeCasterComponentsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeCasterComponentsResponse>(DoRPCRequest("DescribeCasterComponents", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeCasterComponentsResponse> DescribeCasterComponentsWithOptionsAsync(DescribeCasterComponentsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeCasterComponentsResponse>(await DoRPCRequestAsync("DescribeCasterComponents", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeCasterComponentsResponse DescribeCasterComponents(DescribeCasterComponentsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeCasterComponentsWithOptions(request, runtime);
        }

        public async Task<DescribeCasterComponentsResponse> DescribeCasterComponentsAsync(DescribeCasterComponentsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeCasterComponentsWithOptionsAsync(request, runtime);
        }

        public DescribeCasterConfigResponse DescribeCasterConfigWithOptions(DescribeCasterConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeCasterConfigResponse>(DoRPCRequest("DescribeCasterConfig", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeCasterConfigResponse> DescribeCasterConfigWithOptionsAsync(DescribeCasterConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeCasterConfigResponse>(await DoRPCRequestAsync("DescribeCasterConfig", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeCasterConfigResponse DescribeCasterConfig(DescribeCasterConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeCasterConfigWithOptions(request, runtime);
        }

        public async Task<DescribeCasterConfigResponse> DescribeCasterConfigAsync(DescribeCasterConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeCasterConfigWithOptionsAsync(request, runtime);
        }

        public DescribeCasterLayoutsResponse DescribeCasterLayoutsWithOptions(DescribeCasterLayoutsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeCasterLayoutsResponse>(DoRPCRequest("DescribeCasterLayouts", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeCasterLayoutsResponse> DescribeCasterLayoutsWithOptionsAsync(DescribeCasterLayoutsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeCasterLayoutsResponse>(await DoRPCRequestAsync("DescribeCasterLayouts", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeCasterLayoutsResponse DescribeCasterLayouts(DescribeCasterLayoutsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeCasterLayoutsWithOptions(request, runtime);
        }

        public async Task<DescribeCasterLayoutsResponse> DescribeCasterLayoutsAsync(DescribeCasterLayoutsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeCasterLayoutsWithOptionsAsync(request, runtime);
        }

        public DescribeCasterProgramResponse DescribeCasterProgramWithOptions(DescribeCasterProgramRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeCasterProgramResponse>(DoRPCRequest("DescribeCasterProgram", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeCasterProgramResponse> DescribeCasterProgramWithOptionsAsync(DescribeCasterProgramRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeCasterProgramResponse>(await DoRPCRequestAsync("DescribeCasterProgram", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeCasterProgramResponse DescribeCasterProgram(DescribeCasterProgramRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeCasterProgramWithOptions(request, runtime);
        }

        public async Task<DescribeCasterProgramResponse> DescribeCasterProgramAsync(DescribeCasterProgramRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeCasterProgramWithOptionsAsync(request, runtime);
        }

        public DescribeCasterRtcInfoResponse DescribeCasterRtcInfoWithOptions(DescribeCasterRtcInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeCasterRtcInfoResponse>(DoRPCRequest("DescribeCasterRtcInfo", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeCasterRtcInfoResponse> DescribeCasterRtcInfoWithOptionsAsync(DescribeCasterRtcInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeCasterRtcInfoResponse>(await DoRPCRequestAsync("DescribeCasterRtcInfo", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeCasterRtcInfoResponse DescribeCasterRtcInfo(DescribeCasterRtcInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeCasterRtcInfoWithOptions(request, runtime);
        }

        public async Task<DescribeCasterRtcInfoResponse> DescribeCasterRtcInfoAsync(DescribeCasterRtcInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeCasterRtcInfoWithOptionsAsync(request, runtime);
        }

        public DescribeCastersResponse DescribeCastersWithOptions(DescribeCastersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeCastersResponse>(DoRPCRequest("DescribeCasters", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeCastersResponse> DescribeCastersWithOptionsAsync(DescribeCastersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeCastersResponse>(await DoRPCRequestAsync("DescribeCasters", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeCastersResponse DescribeCasters(DescribeCastersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeCastersWithOptions(request, runtime);
        }

        public async Task<DescribeCastersResponse> DescribeCastersAsync(DescribeCastersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeCastersWithOptionsAsync(request, runtime);
        }

        public DescribeCasterSceneAudioResponse DescribeCasterSceneAudioWithOptions(DescribeCasterSceneAudioRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeCasterSceneAudioResponse>(DoRPCRequest("DescribeCasterSceneAudio", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeCasterSceneAudioResponse> DescribeCasterSceneAudioWithOptionsAsync(DescribeCasterSceneAudioRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeCasterSceneAudioResponse>(await DoRPCRequestAsync("DescribeCasterSceneAudio", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeCasterSceneAudioResponse DescribeCasterSceneAudio(DescribeCasterSceneAudioRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeCasterSceneAudioWithOptions(request, runtime);
        }

        public async Task<DescribeCasterSceneAudioResponse> DescribeCasterSceneAudioAsync(DescribeCasterSceneAudioRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeCasterSceneAudioWithOptionsAsync(request, runtime);
        }

        public DescribeCasterScenesResponse DescribeCasterScenesWithOptions(DescribeCasterScenesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeCasterScenesResponse>(DoRPCRequest("DescribeCasterScenes", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeCasterScenesResponse> DescribeCasterScenesWithOptionsAsync(DescribeCasterScenesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeCasterScenesResponse>(await DoRPCRequestAsync("DescribeCasterScenes", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeCasterScenesResponse DescribeCasterScenes(DescribeCasterScenesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeCasterScenesWithOptions(request, runtime);
        }

        public async Task<DescribeCasterScenesResponse> DescribeCasterScenesAsync(DescribeCasterScenesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeCasterScenesWithOptionsAsync(request, runtime);
        }

        public DescribeCasterStreamUrlResponse DescribeCasterStreamUrlWithOptions(DescribeCasterStreamUrlRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeCasterStreamUrlResponse>(DoRPCRequest("DescribeCasterStreamUrl", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeCasterStreamUrlResponse> DescribeCasterStreamUrlWithOptionsAsync(DescribeCasterStreamUrlRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeCasterStreamUrlResponse>(await DoRPCRequestAsync("DescribeCasterStreamUrl", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeCasterStreamUrlResponse DescribeCasterStreamUrl(DescribeCasterStreamUrlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeCasterStreamUrlWithOptions(request, runtime);
        }

        public async Task<DescribeCasterStreamUrlResponse> DescribeCasterStreamUrlAsync(DescribeCasterStreamUrlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeCasterStreamUrlWithOptionsAsync(request, runtime);
        }

        public DescribeCasterSyncGroupResponse DescribeCasterSyncGroupWithOptions(DescribeCasterSyncGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeCasterSyncGroupResponse>(DoRPCRequest("DescribeCasterSyncGroup", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeCasterSyncGroupResponse> DescribeCasterSyncGroupWithOptionsAsync(DescribeCasterSyncGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeCasterSyncGroupResponse>(await DoRPCRequestAsync("DescribeCasterSyncGroup", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeCasterSyncGroupResponse DescribeCasterSyncGroup(DescribeCasterSyncGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeCasterSyncGroupWithOptions(request, runtime);
        }

        public async Task<DescribeCasterSyncGroupResponse> DescribeCasterSyncGroupAsync(DescribeCasterSyncGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeCasterSyncGroupWithOptionsAsync(request, runtime);
        }

        public DescribeCasterVideoResourcesResponse DescribeCasterVideoResourcesWithOptions(DescribeCasterVideoResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeCasterVideoResourcesResponse>(DoRPCRequest("DescribeCasterVideoResources", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeCasterVideoResourcesResponse> DescribeCasterVideoResourcesWithOptionsAsync(DescribeCasterVideoResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeCasterVideoResourcesResponse>(await DoRPCRequestAsync("DescribeCasterVideoResources", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeCasterVideoResourcesResponse DescribeCasterVideoResources(DescribeCasterVideoResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeCasterVideoResourcesWithOptions(request, runtime);
        }

        public async Task<DescribeCasterVideoResourcesResponse> DescribeCasterVideoResourcesAsync(DescribeCasterVideoResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeCasterVideoResourcesWithOptionsAsync(request, runtime);
        }

        public DescribeDomainUsageDataResponse DescribeDomainUsageDataWithOptions(DescribeDomainUsageDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDomainUsageDataResponse>(DoRPCRequest("DescribeDomainUsageData", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDomainUsageDataResponse> DescribeDomainUsageDataWithOptionsAsync(DescribeDomainUsageDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDomainUsageDataResponse>(await DoRPCRequestAsync("DescribeDomainUsageData", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeDomainUsageDataResponse DescribeDomainUsageData(DescribeDomainUsageDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDomainUsageDataWithOptions(request, runtime);
        }

        public async Task<DescribeDomainUsageDataResponse> DescribeDomainUsageDataAsync(DescribeDomainUsageDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDomainUsageDataWithOptionsAsync(request, runtime);
        }

        public DescribeDRMCertListResponse DescribeDRMCertListWithOptions(DescribeDRMCertListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDRMCertListResponse>(DoRPCRequest("DescribeDRMCertList", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeDRMCertListResponse> DescribeDRMCertListWithOptionsAsync(DescribeDRMCertListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeDRMCertListResponse>(await DoRPCRequestAsync("DescribeDRMCertList", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeDRMCertListResponse DescribeDRMCertList(DescribeDRMCertListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDRMCertListWithOptions(request, runtime);
        }

        public async Task<DescribeDRMCertListResponse> DescribeDRMCertListAsync(DescribeDRMCertListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDRMCertListWithOptionsAsync(request, runtime);
        }

        public DescribeForbidPushStreamRoomListResponse DescribeForbidPushStreamRoomListWithOptions(DescribeForbidPushStreamRoomListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeForbidPushStreamRoomListResponse>(DoRPCRequest("DescribeForbidPushStreamRoomList", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeForbidPushStreamRoomListResponse> DescribeForbidPushStreamRoomListWithOptionsAsync(DescribeForbidPushStreamRoomListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeForbidPushStreamRoomListResponse>(await DoRPCRequestAsync("DescribeForbidPushStreamRoomList", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeForbidPushStreamRoomListResponse DescribeForbidPushStreamRoomList(DescribeForbidPushStreamRoomListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeForbidPushStreamRoomListWithOptions(request, runtime);
        }

        public async Task<DescribeForbidPushStreamRoomListResponse> DescribeForbidPushStreamRoomListAsync(DescribeForbidPushStreamRoomListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeForbidPushStreamRoomListWithOptionsAsync(request, runtime);
        }

        public DescribeHlsLiveStreamRealTimeBpsDataResponse DescribeHlsLiveStreamRealTimeBpsDataWithOptions(DescribeHlsLiveStreamRealTimeBpsDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<DescribeHlsLiveStreamRealTimeBpsDataResponse>(DoRPCRequest("DescribeHlsLiveStreamRealTimeBpsData", "2016-11-01", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<DescribeHlsLiveStreamRealTimeBpsDataResponse> DescribeHlsLiveStreamRealTimeBpsDataWithOptionsAsync(DescribeHlsLiveStreamRealTimeBpsDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<DescribeHlsLiveStreamRealTimeBpsDataResponse>(await DoRPCRequestAsync("DescribeHlsLiveStreamRealTimeBpsData", "2016-11-01", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public DescribeHlsLiveStreamRealTimeBpsDataResponse DescribeHlsLiveStreamRealTimeBpsData(DescribeHlsLiveStreamRealTimeBpsDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeHlsLiveStreamRealTimeBpsDataWithOptions(request, runtime);
        }

        public async Task<DescribeHlsLiveStreamRealTimeBpsDataResponse> DescribeHlsLiveStreamRealTimeBpsDataAsync(DescribeHlsLiveStreamRealTimeBpsDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeHlsLiveStreamRealTimeBpsDataWithOptionsAsync(request, runtime);
        }

        public DescribeHtmlResourceResponse DescribeHtmlResourceWithOptions(DescribeHtmlResourceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeHtmlResourceResponse>(DoRPCRequest("DescribeHtmlResource", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeHtmlResourceResponse> DescribeHtmlResourceWithOptionsAsync(DescribeHtmlResourceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeHtmlResourceResponse>(await DoRPCRequestAsync("DescribeHtmlResource", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeHtmlResourceResponse DescribeHtmlResource(DescribeHtmlResourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeHtmlResourceWithOptions(request, runtime);
        }

        public async Task<DescribeHtmlResourceResponse> DescribeHtmlResourceAsync(DescribeHtmlResourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeHtmlResourceWithOptionsAsync(request, runtime);
        }

        public DescribeLiveAsrConfigResponse DescribeLiveAsrConfigWithOptions(DescribeLiveAsrConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeLiveAsrConfigResponse>(DoRPCRequest("DescribeLiveAsrConfig", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeLiveAsrConfigResponse> DescribeLiveAsrConfigWithOptionsAsync(DescribeLiveAsrConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeLiveAsrConfigResponse>(await DoRPCRequestAsync("DescribeLiveAsrConfig", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeLiveAsrConfigResponse DescribeLiveAsrConfig(DescribeLiveAsrConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeLiveAsrConfigWithOptions(request, runtime);
        }

        public async Task<DescribeLiveAsrConfigResponse> DescribeLiveAsrConfigAsync(DescribeLiveAsrConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeLiveAsrConfigWithOptionsAsync(request, runtime);
        }

        public DescribeLiveAudioAuditConfigResponse DescribeLiveAudioAuditConfigWithOptions(DescribeLiveAudioAuditConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeLiveAudioAuditConfigResponse>(DoRPCRequest("DescribeLiveAudioAuditConfig", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeLiveAudioAuditConfigResponse> DescribeLiveAudioAuditConfigWithOptionsAsync(DescribeLiveAudioAuditConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeLiveAudioAuditConfigResponse>(await DoRPCRequestAsync("DescribeLiveAudioAuditConfig", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeLiveAudioAuditConfigResponse DescribeLiveAudioAuditConfig(DescribeLiveAudioAuditConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeLiveAudioAuditConfigWithOptions(request, runtime);
        }

        public async Task<DescribeLiveAudioAuditConfigResponse> DescribeLiveAudioAuditConfigAsync(DescribeLiveAudioAuditConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeLiveAudioAuditConfigWithOptionsAsync(request, runtime);
        }

        public DescribeLiveAudioAuditNotifyConfigResponse DescribeLiveAudioAuditNotifyConfigWithOptions(DescribeLiveAudioAuditNotifyConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeLiveAudioAuditNotifyConfigResponse>(DoRPCRequest("DescribeLiveAudioAuditNotifyConfig", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeLiveAudioAuditNotifyConfigResponse> DescribeLiveAudioAuditNotifyConfigWithOptionsAsync(DescribeLiveAudioAuditNotifyConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeLiveAudioAuditNotifyConfigResponse>(await DoRPCRequestAsync("DescribeLiveAudioAuditNotifyConfig", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeLiveAudioAuditNotifyConfigResponse DescribeLiveAudioAuditNotifyConfig(DescribeLiveAudioAuditNotifyConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeLiveAudioAuditNotifyConfigWithOptions(request, runtime);
        }

        public async Task<DescribeLiveAudioAuditNotifyConfigResponse> DescribeLiveAudioAuditNotifyConfigAsync(DescribeLiveAudioAuditNotifyConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeLiveAudioAuditNotifyConfigWithOptionsAsync(request, runtime);
        }

        public DescribeLiveCertificateDetailResponse DescribeLiveCertificateDetailWithOptions(DescribeLiveCertificateDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeLiveCertificateDetailResponse>(DoRPCRequest("DescribeLiveCertificateDetail", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeLiveCertificateDetailResponse> DescribeLiveCertificateDetailWithOptionsAsync(DescribeLiveCertificateDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeLiveCertificateDetailResponse>(await DoRPCRequestAsync("DescribeLiveCertificateDetail", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeLiveCertificateDetailResponse DescribeLiveCertificateDetail(DescribeLiveCertificateDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeLiveCertificateDetailWithOptions(request, runtime);
        }

        public async Task<DescribeLiveCertificateDetailResponse> DescribeLiveCertificateDetailAsync(DescribeLiveCertificateDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeLiveCertificateDetailWithOptionsAsync(request, runtime);
        }

        public DescribeLiveCertificateListResponse DescribeLiveCertificateListWithOptions(DescribeLiveCertificateListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeLiveCertificateListResponse>(DoRPCRequest("DescribeLiveCertificateList", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeLiveCertificateListResponse> DescribeLiveCertificateListWithOptionsAsync(DescribeLiveCertificateListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeLiveCertificateListResponse>(await DoRPCRequestAsync("DescribeLiveCertificateList", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeLiveCertificateListResponse DescribeLiveCertificateList(DescribeLiveCertificateListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeLiveCertificateListWithOptions(request, runtime);
        }

        public async Task<DescribeLiveCertificateListResponse> DescribeLiveCertificateListAsync(DescribeLiveCertificateListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeLiveCertificateListWithOptionsAsync(request, runtime);
        }

        public DescribeLiveDetectNotifyConfigResponse DescribeLiveDetectNotifyConfigWithOptions(DescribeLiveDetectNotifyConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeLiveDetectNotifyConfigResponse>(DoRPCRequest("DescribeLiveDetectNotifyConfig", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeLiveDetectNotifyConfigResponse> DescribeLiveDetectNotifyConfigWithOptionsAsync(DescribeLiveDetectNotifyConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeLiveDetectNotifyConfigResponse>(await DoRPCRequestAsync("DescribeLiveDetectNotifyConfig", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeLiveDetectNotifyConfigResponse DescribeLiveDetectNotifyConfig(DescribeLiveDetectNotifyConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeLiveDetectNotifyConfigWithOptions(request, runtime);
        }

        public async Task<DescribeLiveDetectNotifyConfigResponse> DescribeLiveDetectNotifyConfigAsync(DescribeLiveDetectNotifyConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeLiveDetectNotifyConfigWithOptionsAsync(request, runtime);
        }

        public DescribeLiveDetectPornDataResponse DescribeLiveDetectPornDataWithOptions(DescribeLiveDetectPornDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeLiveDetectPornDataResponse>(DoRPCRequest("DescribeLiveDetectPornData", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeLiveDetectPornDataResponse> DescribeLiveDetectPornDataWithOptionsAsync(DescribeLiveDetectPornDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeLiveDetectPornDataResponse>(await DoRPCRequestAsync("DescribeLiveDetectPornData", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeLiveDetectPornDataResponse DescribeLiveDetectPornData(DescribeLiveDetectPornDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeLiveDetectPornDataWithOptions(request, runtime);
        }

        public async Task<DescribeLiveDetectPornDataResponse> DescribeLiveDetectPornDataAsync(DescribeLiveDetectPornDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeLiveDetectPornDataWithOptionsAsync(request, runtime);
        }

        public DescribeLiveDomainBpsDataResponse DescribeLiveDomainBpsDataWithOptions(DescribeLiveDomainBpsDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeLiveDomainBpsDataResponse>(DoRPCRequest("DescribeLiveDomainBpsData", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeLiveDomainBpsDataResponse> DescribeLiveDomainBpsDataWithOptionsAsync(DescribeLiveDomainBpsDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeLiveDomainBpsDataResponse>(await DoRPCRequestAsync("DescribeLiveDomainBpsData", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeLiveDomainBpsDataResponse DescribeLiveDomainBpsData(DescribeLiveDomainBpsDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeLiveDomainBpsDataWithOptions(request, runtime);
        }

        public async Task<DescribeLiveDomainBpsDataResponse> DescribeLiveDomainBpsDataAsync(DescribeLiveDomainBpsDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeLiveDomainBpsDataWithOptionsAsync(request, runtime);
        }

        public DescribeLiveDomainBpsDataByTimeStampResponse DescribeLiveDomainBpsDataByTimeStampWithOptions(DescribeLiveDomainBpsDataByTimeStampRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeLiveDomainBpsDataByTimeStampResponse>(DoRPCRequest("DescribeLiveDomainBpsDataByTimeStamp", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeLiveDomainBpsDataByTimeStampResponse> DescribeLiveDomainBpsDataByTimeStampWithOptionsAsync(DescribeLiveDomainBpsDataByTimeStampRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeLiveDomainBpsDataByTimeStampResponse>(await DoRPCRequestAsync("DescribeLiveDomainBpsDataByTimeStamp", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeLiveDomainBpsDataByTimeStampResponse DescribeLiveDomainBpsDataByTimeStamp(DescribeLiveDomainBpsDataByTimeStampRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeLiveDomainBpsDataByTimeStampWithOptions(request, runtime);
        }

        public async Task<DescribeLiveDomainBpsDataByTimeStampResponse> DescribeLiveDomainBpsDataByTimeStampAsync(DescribeLiveDomainBpsDataByTimeStampRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeLiveDomainBpsDataByTimeStampWithOptionsAsync(request, runtime);
        }

        public DescribeLiveDomainCertificateInfoResponse DescribeLiveDomainCertificateInfoWithOptions(DescribeLiveDomainCertificateInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeLiveDomainCertificateInfoResponse>(DoRPCRequest("DescribeLiveDomainCertificateInfo", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeLiveDomainCertificateInfoResponse> DescribeLiveDomainCertificateInfoWithOptionsAsync(DescribeLiveDomainCertificateInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeLiveDomainCertificateInfoResponse>(await DoRPCRequestAsync("DescribeLiveDomainCertificateInfo", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeLiveDomainCertificateInfoResponse DescribeLiveDomainCertificateInfo(DescribeLiveDomainCertificateInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeLiveDomainCertificateInfoWithOptions(request, runtime);
        }

        public async Task<DescribeLiveDomainCertificateInfoResponse> DescribeLiveDomainCertificateInfoAsync(DescribeLiveDomainCertificateInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeLiveDomainCertificateInfoWithOptionsAsync(request, runtime);
        }

        public DescribeLiveDomainConfigsResponse DescribeLiveDomainConfigsWithOptions(DescribeLiveDomainConfigsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeLiveDomainConfigsResponse>(DoRPCRequest("DescribeLiveDomainConfigs", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeLiveDomainConfigsResponse> DescribeLiveDomainConfigsWithOptionsAsync(DescribeLiveDomainConfigsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeLiveDomainConfigsResponse>(await DoRPCRequestAsync("DescribeLiveDomainConfigs", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeLiveDomainConfigsResponse DescribeLiveDomainConfigs(DescribeLiveDomainConfigsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeLiveDomainConfigsWithOptions(request, runtime);
        }

        public async Task<DescribeLiveDomainConfigsResponse> DescribeLiveDomainConfigsAsync(DescribeLiveDomainConfigsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeLiveDomainConfigsWithOptionsAsync(request, runtime);
        }

        public DescribeLiveDomainDetailResponse DescribeLiveDomainDetailWithOptions(DescribeLiveDomainDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeLiveDomainDetailResponse>(DoRPCRequest("DescribeLiveDomainDetail", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeLiveDomainDetailResponse> DescribeLiveDomainDetailWithOptionsAsync(DescribeLiveDomainDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeLiveDomainDetailResponse>(await DoRPCRequestAsync("DescribeLiveDomainDetail", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeLiveDomainDetailResponse DescribeLiveDomainDetail(DescribeLiveDomainDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeLiveDomainDetailWithOptions(request, runtime);
        }

        public async Task<DescribeLiveDomainDetailResponse> DescribeLiveDomainDetailAsync(DescribeLiveDomainDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeLiveDomainDetailWithOptionsAsync(request, runtime);
        }

        public DescribeLiveDomainFrameRateAndBitRateDataResponse DescribeLiveDomainFrameRateAndBitRateDataWithOptions(DescribeLiveDomainFrameRateAndBitRateDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeLiveDomainFrameRateAndBitRateDataResponse>(DoRPCRequest("DescribeLiveDomainFrameRateAndBitRateData", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeLiveDomainFrameRateAndBitRateDataResponse> DescribeLiveDomainFrameRateAndBitRateDataWithOptionsAsync(DescribeLiveDomainFrameRateAndBitRateDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeLiveDomainFrameRateAndBitRateDataResponse>(await DoRPCRequestAsync("DescribeLiveDomainFrameRateAndBitRateData", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeLiveDomainFrameRateAndBitRateDataResponse DescribeLiveDomainFrameRateAndBitRateData(DescribeLiveDomainFrameRateAndBitRateDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeLiveDomainFrameRateAndBitRateDataWithOptions(request, runtime);
        }

        public async Task<DescribeLiveDomainFrameRateAndBitRateDataResponse> DescribeLiveDomainFrameRateAndBitRateDataAsync(DescribeLiveDomainFrameRateAndBitRateDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeLiveDomainFrameRateAndBitRateDataWithOptionsAsync(request, runtime);
        }

        public DescribeLiveDomainLimitResponse DescribeLiveDomainLimitWithOptions(DescribeLiveDomainLimitRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeLiveDomainLimitResponse>(DoRPCRequest("DescribeLiveDomainLimit", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeLiveDomainLimitResponse> DescribeLiveDomainLimitWithOptionsAsync(DescribeLiveDomainLimitRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeLiveDomainLimitResponse>(await DoRPCRequestAsync("DescribeLiveDomainLimit", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeLiveDomainLimitResponse DescribeLiveDomainLimit(DescribeLiveDomainLimitRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeLiveDomainLimitWithOptions(request, runtime);
        }

        public async Task<DescribeLiveDomainLimitResponse> DescribeLiveDomainLimitAsync(DescribeLiveDomainLimitRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeLiveDomainLimitWithOptionsAsync(request, runtime);
        }

        public DescribeLiveDomainMappingResponse DescribeLiveDomainMappingWithOptions(DescribeLiveDomainMappingRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<DescribeLiveDomainMappingResponse>(DoRPCRequest("DescribeLiveDomainMapping", "2016-11-01", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<DescribeLiveDomainMappingResponse> DescribeLiveDomainMappingWithOptionsAsync(DescribeLiveDomainMappingRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<DescribeLiveDomainMappingResponse>(await DoRPCRequestAsync("DescribeLiveDomainMapping", "2016-11-01", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public DescribeLiveDomainMappingResponse DescribeLiveDomainMapping(DescribeLiveDomainMappingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeLiveDomainMappingWithOptions(request, runtime);
        }

        public async Task<DescribeLiveDomainMappingResponse> DescribeLiveDomainMappingAsync(DescribeLiveDomainMappingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeLiveDomainMappingWithOptionsAsync(request, runtime);
        }

        public DescribeLiveDomainOnlineUserNumResponse DescribeLiveDomainOnlineUserNumWithOptions(DescribeLiveDomainOnlineUserNumRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeLiveDomainOnlineUserNumResponse>(DoRPCRequest("DescribeLiveDomainOnlineUserNum", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeLiveDomainOnlineUserNumResponse> DescribeLiveDomainOnlineUserNumWithOptionsAsync(DescribeLiveDomainOnlineUserNumRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeLiveDomainOnlineUserNumResponse>(await DoRPCRequestAsync("DescribeLiveDomainOnlineUserNum", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeLiveDomainOnlineUserNumResponse DescribeLiveDomainOnlineUserNum(DescribeLiveDomainOnlineUserNumRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeLiveDomainOnlineUserNumWithOptions(request, runtime);
        }

        public async Task<DescribeLiveDomainOnlineUserNumResponse> DescribeLiveDomainOnlineUserNumAsync(DescribeLiveDomainOnlineUserNumRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeLiveDomainOnlineUserNumWithOptionsAsync(request, runtime);
        }

        public DescribeLiveDomainPushBpsDataResponse DescribeLiveDomainPushBpsDataWithOptions(DescribeLiveDomainPushBpsDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeLiveDomainPushBpsDataResponse>(DoRPCRequest("DescribeLiveDomainPushBpsData", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeLiveDomainPushBpsDataResponse> DescribeLiveDomainPushBpsDataWithOptionsAsync(DescribeLiveDomainPushBpsDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeLiveDomainPushBpsDataResponse>(await DoRPCRequestAsync("DescribeLiveDomainPushBpsData", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeLiveDomainPushBpsDataResponse DescribeLiveDomainPushBpsData(DescribeLiveDomainPushBpsDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeLiveDomainPushBpsDataWithOptions(request, runtime);
        }

        public async Task<DescribeLiveDomainPushBpsDataResponse> DescribeLiveDomainPushBpsDataAsync(DescribeLiveDomainPushBpsDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeLiveDomainPushBpsDataWithOptionsAsync(request, runtime);
        }

        public DescribeLiveDomainPushTrafficDataResponse DescribeLiveDomainPushTrafficDataWithOptions(DescribeLiveDomainPushTrafficDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeLiveDomainPushTrafficDataResponse>(DoRPCRequest("DescribeLiveDomainPushTrafficData", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeLiveDomainPushTrafficDataResponse> DescribeLiveDomainPushTrafficDataWithOptionsAsync(DescribeLiveDomainPushTrafficDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeLiveDomainPushTrafficDataResponse>(await DoRPCRequestAsync("DescribeLiveDomainPushTrafficData", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeLiveDomainPushTrafficDataResponse DescribeLiveDomainPushTrafficData(DescribeLiveDomainPushTrafficDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeLiveDomainPushTrafficDataWithOptions(request, runtime);
        }

        public async Task<DescribeLiveDomainPushTrafficDataResponse> DescribeLiveDomainPushTrafficDataAsync(DescribeLiveDomainPushTrafficDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeLiveDomainPushTrafficDataWithOptionsAsync(request, runtime);
        }

        public DescribeLiveDomainPvUvDataResponse DescribeLiveDomainPvUvDataWithOptions(DescribeLiveDomainPvUvDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeLiveDomainPvUvDataResponse>(DoRPCRequest("DescribeLiveDomainPvUvData", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeLiveDomainPvUvDataResponse> DescribeLiveDomainPvUvDataWithOptionsAsync(DescribeLiveDomainPvUvDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeLiveDomainPvUvDataResponse>(await DoRPCRequestAsync("DescribeLiveDomainPvUvData", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeLiveDomainPvUvDataResponse DescribeLiveDomainPvUvData(DescribeLiveDomainPvUvDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeLiveDomainPvUvDataWithOptions(request, runtime);
        }

        public async Task<DescribeLiveDomainPvUvDataResponse> DescribeLiveDomainPvUvDataAsync(DescribeLiveDomainPvUvDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeLiveDomainPvUvDataWithOptionsAsync(request, runtime);
        }

        public DescribeLiveDomainRealTimeBpsDataResponse DescribeLiveDomainRealTimeBpsDataWithOptions(DescribeLiveDomainRealTimeBpsDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<DescribeLiveDomainRealTimeBpsDataResponse>(DoRPCRequest("DescribeLiveDomainRealTimeBpsData", "2016-11-01", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<DescribeLiveDomainRealTimeBpsDataResponse> DescribeLiveDomainRealTimeBpsDataWithOptionsAsync(DescribeLiveDomainRealTimeBpsDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<DescribeLiveDomainRealTimeBpsDataResponse>(await DoRPCRequestAsync("DescribeLiveDomainRealTimeBpsData", "2016-11-01", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public DescribeLiveDomainRealTimeBpsDataResponse DescribeLiveDomainRealTimeBpsData(DescribeLiveDomainRealTimeBpsDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeLiveDomainRealTimeBpsDataWithOptions(request, runtime);
        }

        public async Task<DescribeLiveDomainRealTimeBpsDataResponse> DescribeLiveDomainRealTimeBpsDataAsync(DescribeLiveDomainRealTimeBpsDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeLiveDomainRealTimeBpsDataWithOptionsAsync(request, runtime);
        }

        public DescribeLiveDomainRealTimeHttpCodeDataResponse DescribeLiveDomainRealTimeHttpCodeDataWithOptions(DescribeLiveDomainRealTimeHttpCodeDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeLiveDomainRealTimeHttpCodeDataResponse>(DoRPCRequest("DescribeLiveDomainRealTimeHttpCodeData", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeLiveDomainRealTimeHttpCodeDataResponse> DescribeLiveDomainRealTimeHttpCodeDataWithOptionsAsync(DescribeLiveDomainRealTimeHttpCodeDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeLiveDomainRealTimeHttpCodeDataResponse>(await DoRPCRequestAsync("DescribeLiveDomainRealTimeHttpCodeData", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeLiveDomainRealTimeHttpCodeDataResponse DescribeLiveDomainRealTimeHttpCodeData(DescribeLiveDomainRealTimeHttpCodeDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeLiveDomainRealTimeHttpCodeDataWithOptions(request, runtime);
        }

        public async Task<DescribeLiveDomainRealTimeHttpCodeDataResponse> DescribeLiveDomainRealTimeHttpCodeDataAsync(DescribeLiveDomainRealTimeHttpCodeDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeLiveDomainRealTimeHttpCodeDataWithOptionsAsync(request, runtime);
        }

        public DescribeLiveDomainRealtimeLogDeliveryResponse DescribeLiveDomainRealtimeLogDeliveryWithOptions(DescribeLiveDomainRealtimeLogDeliveryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<DescribeLiveDomainRealtimeLogDeliveryResponse>(DoRPCRequest("DescribeLiveDomainRealtimeLogDelivery", "2016-11-01", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<DescribeLiveDomainRealtimeLogDeliveryResponse> DescribeLiveDomainRealtimeLogDeliveryWithOptionsAsync(DescribeLiveDomainRealtimeLogDeliveryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<DescribeLiveDomainRealtimeLogDeliveryResponse>(await DoRPCRequestAsync("DescribeLiveDomainRealtimeLogDelivery", "2016-11-01", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public DescribeLiveDomainRealtimeLogDeliveryResponse DescribeLiveDomainRealtimeLogDelivery(DescribeLiveDomainRealtimeLogDeliveryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeLiveDomainRealtimeLogDeliveryWithOptions(request, runtime);
        }

        public async Task<DescribeLiveDomainRealtimeLogDeliveryResponse> DescribeLiveDomainRealtimeLogDeliveryAsync(DescribeLiveDomainRealtimeLogDeliveryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeLiveDomainRealtimeLogDeliveryWithOptionsAsync(request, runtime);
        }

        public DescribeLiveDomainRealTimeTrafficDataResponse DescribeLiveDomainRealTimeTrafficDataWithOptions(DescribeLiveDomainRealTimeTrafficDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeLiveDomainRealTimeTrafficDataResponse>(DoRPCRequest("DescribeLiveDomainRealTimeTrafficData", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeLiveDomainRealTimeTrafficDataResponse> DescribeLiveDomainRealTimeTrafficDataWithOptionsAsync(DescribeLiveDomainRealTimeTrafficDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeLiveDomainRealTimeTrafficDataResponse>(await DoRPCRequestAsync("DescribeLiveDomainRealTimeTrafficData", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeLiveDomainRealTimeTrafficDataResponse DescribeLiveDomainRealTimeTrafficData(DescribeLiveDomainRealTimeTrafficDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeLiveDomainRealTimeTrafficDataWithOptions(request, runtime);
        }

        public async Task<DescribeLiveDomainRealTimeTrafficDataResponse> DescribeLiveDomainRealTimeTrafficDataAsync(DescribeLiveDomainRealTimeTrafficDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeLiveDomainRealTimeTrafficDataWithOptionsAsync(request, runtime);
        }

        public DescribeLiveDomainRecordDataResponse DescribeLiveDomainRecordDataWithOptions(DescribeLiveDomainRecordDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeLiveDomainRecordDataResponse>(DoRPCRequest("DescribeLiveDomainRecordData", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeLiveDomainRecordDataResponse> DescribeLiveDomainRecordDataWithOptionsAsync(DescribeLiveDomainRecordDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeLiveDomainRecordDataResponse>(await DoRPCRequestAsync("DescribeLiveDomainRecordData", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeLiveDomainRecordDataResponse DescribeLiveDomainRecordData(DescribeLiveDomainRecordDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeLiveDomainRecordDataWithOptions(request, runtime);
        }

        public async Task<DescribeLiveDomainRecordDataResponse> DescribeLiveDomainRecordDataAsync(DescribeLiveDomainRecordDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeLiveDomainRecordDataWithOptionsAsync(request, runtime);
        }

        public DescribeLiveDomainSnapshotDataResponse DescribeLiveDomainSnapshotDataWithOptions(DescribeLiveDomainSnapshotDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeLiveDomainSnapshotDataResponse>(DoRPCRequest("DescribeLiveDomainSnapshotData", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeLiveDomainSnapshotDataResponse> DescribeLiveDomainSnapshotDataWithOptionsAsync(DescribeLiveDomainSnapshotDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeLiveDomainSnapshotDataResponse>(await DoRPCRequestAsync("DescribeLiveDomainSnapshotData", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeLiveDomainSnapshotDataResponse DescribeLiveDomainSnapshotData(DescribeLiveDomainSnapshotDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeLiveDomainSnapshotDataWithOptions(request, runtime);
        }

        public async Task<DescribeLiveDomainSnapshotDataResponse> DescribeLiveDomainSnapshotDataAsync(DescribeLiveDomainSnapshotDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeLiveDomainSnapshotDataWithOptionsAsync(request, runtime);
        }

        public DescribeLiveDomainStreamTranscodeDataResponse DescribeLiveDomainStreamTranscodeDataWithOptions(DescribeLiveDomainStreamTranscodeDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeLiveDomainStreamTranscodeDataResponse>(DoRPCRequest("DescribeLiveDomainStreamTranscodeData", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeLiveDomainStreamTranscodeDataResponse> DescribeLiveDomainStreamTranscodeDataWithOptionsAsync(DescribeLiveDomainStreamTranscodeDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeLiveDomainStreamTranscodeDataResponse>(await DoRPCRequestAsync("DescribeLiveDomainStreamTranscodeData", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeLiveDomainStreamTranscodeDataResponse DescribeLiveDomainStreamTranscodeData(DescribeLiveDomainStreamTranscodeDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeLiveDomainStreamTranscodeDataWithOptions(request, runtime);
        }

        public async Task<DescribeLiveDomainStreamTranscodeDataResponse> DescribeLiveDomainStreamTranscodeDataAsync(DescribeLiveDomainStreamTranscodeDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeLiveDomainStreamTranscodeDataWithOptionsAsync(request, runtime);
        }

        public DescribeLiveDomainTimeShiftDataResponse DescribeLiveDomainTimeShiftDataWithOptions(DescribeLiveDomainTimeShiftDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeLiveDomainTimeShiftDataResponse>(DoRPCRequest("DescribeLiveDomainTimeShiftData", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeLiveDomainTimeShiftDataResponse> DescribeLiveDomainTimeShiftDataWithOptionsAsync(DescribeLiveDomainTimeShiftDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeLiveDomainTimeShiftDataResponse>(await DoRPCRequestAsync("DescribeLiveDomainTimeShiftData", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeLiveDomainTimeShiftDataResponse DescribeLiveDomainTimeShiftData(DescribeLiveDomainTimeShiftDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeLiveDomainTimeShiftDataWithOptions(request, runtime);
        }

        public async Task<DescribeLiveDomainTimeShiftDataResponse> DescribeLiveDomainTimeShiftDataAsync(DescribeLiveDomainTimeShiftDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeLiveDomainTimeShiftDataWithOptionsAsync(request, runtime);
        }

        public DescribeLiveDomainTrafficDataResponse DescribeLiveDomainTrafficDataWithOptions(DescribeLiveDomainTrafficDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeLiveDomainTrafficDataResponse>(DoRPCRequest("DescribeLiveDomainTrafficData", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeLiveDomainTrafficDataResponse> DescribeLiveDomainTrafficDataWithOptionsAsync(DescribeLiveDomainTrafficDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeLiveDomainTrafficDataResponse>(await DoRPCRequestAsync("DescribeLiveDomainTrafficData", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeLiveDomainTrafficDataResponse DescribeLiveDomainTrafficData(DescribeLiveDomainTrafficDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeLiveDomainTrafficDataWithOptions(request, runtime);
        }

        public async Task<DescribeLiveDomainTrafficDataResponse> DescribeLiveDomainTrafficDataAsync(DescribeLiveDomainTrafficDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeLiveDomainTrafficDataWithOptionsAsync(request, runtime);
        }

        public DescribeLiveDomainTranscodeDataResponse DescribeLiveDomainTranscodeDataWithOptions(DescribeLiveDomainTranscodeDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeLiveDomainTranscodeDataResponse>(DoRPCRequest("DescribeLiveDomainTranscodeData", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeLiveDomainTranscodeDataResponse> DescribeLiveDomainTranscodeDataWithOptionsAsync(DescribeLiveDomainTranscodeDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeLiveDomainTranscodeDataResponse>(await DoRPCRequestAsync("DescribeLiveDomainTranscodeData", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeLiveDomainTranscodeDataResponse DescribeLiveDomainTranscodeData(DescribeLiveDomainTranscodeDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeLiveDomainTranscodeDataWithOptions(request, runtime);
        }

        public async Task<DescribeLiveDomainTranscodeDataResponse> DescribeLiveDomainTranscodeDataAsync(DescribeLiveDomainTranscodeDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeLiveDomainTranscodeDataWithOptionsAsync(request, runtime);
        }

        public DescribeLiveLazyPullStreamConfigResponse DescribeLiveLazyPullStreamConfigWithOptions(DescribeLiveLazyPullStreamConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeLiveLazyPullStreamConfigResponse>(DoRPCRequest("DescribeLiveLazyPullStreamConfig", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeLiveLazyPullStreamConfigResponse> DescribeLiveLazyPullStreamConfigWithOptionsAsync(DescribeLiveLazyPullStreamConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeLiveLazyPullStreamConfigResponse>(await DoRPCRequestAsync("DescribeLiveLazyPullStreamConfig", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeLiveLazyPullStreamConfigResponse DescribeLiveLazyPullStreamConfig(DescribeLiveLazyPullStreamConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeLiveLazyPullStreamConfigWithOptions(request, runtime);
        }

        public async Task<DescribeLiveLazyPullStreamConfigResponse> DescribeLiveLazyPullStreamConfigAsync(DescribeLiveLazyPullStreamConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeLiveLazyPullStreamConfigWithOptionsAsync(request, runtime);
        }

        public DescribeLivePullStreamConfigResponse DescribeLivePullStreamConfigWithOptions(DescribeLivePullStreamConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeLivePullStreamConfigResponse>(DoRPCRequest("DescribeLivePullStreamConfig", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeLivePullStreamConfigResponse> DescribeLivePullStreamConfigWithOptionsAsync(DescribeLivePullStreamConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeLivePullStreamConfigResponse>(await DoRPCRequestAsync("DescribeLivePullStreamConfig", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeLivePullStreamConfigResponse DescribeLivePullStreamConfig(DescribeLivePullStreamConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeLivePullStreamConfigWithOptions(request, runtime);
        }

        public async Task<DescribeLivePullStreamConfigResponse> DescribeLivePullStreamConfigAsync(DescribeLivePullStreamConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeLivePullStreamConfigWithOptionsAsync(request, runtime);
        }

        public DescribeLiveRealtimeDeliveryAccResponse DescribeLiveRealtimeDeliveryAccWithOptions(DescribeLiveRealtimeDeliveryAccRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeLiveRealtimeDeliveryAccResponse>(DoRPCRequest("DescribeLiveRealtimeDeliveryAcc", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeLiveRealtimeDeliveryAccResponse> DescribeLiveRealtimeDeliveryAccWithOptionsAsync(DescribeLiveRealtimeDeliveryAccRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeLiveRealtimeDeliveryAccResponse>(await DoRPCRequestAsync("DescribeLiveRealtimeDeliveryAcc", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeLiveRealtimeDeliveryAccResponse DescribeLiveRealtimeDeliveryAcc(DescribeLiveRealtimeDeliveryAccRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeLiveRealtimeDeliveryAccWithOptions(request, runtime);
        }

        public async Task<DescribeLiveRealtimeDeliveryAccResponse> DescribeLiveRealtimeDeliveryAccAsync(DescribeLiveRealtimeDeliveryAccRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeLiveRealtimeDeliveryAccWithOptionsAsync(request, runtime);
        }

        public DescribeLiveRealtimeLogAuthorizedResponse DescribeLiveRealtimeLogAuthorizedWithOptions(DescribeLiveRealtimeLogAuthorizedRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<DescribeLiveRealtimeLogAuthorizedResponse>(DoRPCRequest("DescribeLiveRealtimeLogAuthorized", "2016-11-01", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<DescribeLiveRealtimeLogAuthorizedResponse> DescribeLiveRealtimeLogAuthorizedWithOptionsAsync(DescribeLiveRealtimeLogAuthorizedRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<DescribeLiveRealtimeLogAuthorizedResponse>(await DoRPCRequestAsync("DescribeLiveRealtimeLogAuthorized", "2016-11-01", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public DescribeLiveRealtimeLogAuthorizedResponse DescribeLiveRealtimeLogAuthorized(DescribeLiveRealtimeLogAuthorizedRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeLiveRealtimeLogAuthorizedWithOptions(request, runtime);
        }

        public async Task<DescribeLiveRealtimeLogAuthorizedResponse> DescribeLiveRealtimeLogAuthorizedAsync(DescribeLiveRealtimeLogAuthorizedRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeLiveRealtimeLogAuthorizedWithOptionsAsync(request, runtime);
        }

        public DescribeLiveRecordConfigResponse DescribeLiveRecordConfigWithOptions(DescribeLiveRecordConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeLiveRecordConfigResponse>(DoRPCRequest("DescribeLiveRecordConfig", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeLiveRecordConfigResponse> DescribeLiveRecordConfigWithOptionsAsync(DescribeLiveRecordConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeLiveRecordConfigResponse>(await DoRPCRequestAsync("DescribeLiveRecordConfig", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeLiveRecordConfigResponse DescribeLiveRecordConfig(DescribeLiveRecordConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeLiveRecordConfigWithOptions(request, runtime);
        }

        public async Task<DescribeLiveRecordConfigResponse> DescribeLiveRecordConfigAsync(DescribeLiveRecordConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeLiveRecordConfigWithOptionsAsync(request, runtime);
        }

        public DescribeLiveRecordNotifyConfigResponse DescribeLiveRecordNotifyConfigWithOptions(DescribeLiveRecordNotifyConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeLiveRecordNotifyConfigResponse>(DoRPCRequest("DescribeLiveRecordNotifyConfig", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeLiveRecordNotifyConfigResponse> DescribeLiveRecordNotifyConfigWithOptionsAsync(DescribeLiveRecordNotifyConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeLiveRecordNotifyConfigResponse>(await DoRPCRequestAsync("DescribeLiveRecordNotifyConfig", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeLiveRecordNotifyConfigResponse DescribeLiveRecordNotifyConfig(DescribeLiveRecordNotifyConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeLiveRecordNotifyConfigWithOptions(request, runtime);
        }

        public async Task<DescribeLiveRecordNotifyConfigResponse> DescribeLiveRecordNotifyConfigAsync(DescribeLiveRecordNotifyConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeLiveRecordNotifyConfigWithOptionsAsync(request, runtime);
        }

        public DescribeLiveRecordVodConfigsResponse DescribeLiveRecordVodConfigsWithOptions(DescribeLiveRecordVodConfigsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeLiveRecordVodConfigsResponse>(DoRPCRequest("DescribeLiveRecordVodConfigs", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeLiveRecordVodConfigsResponse> DescribeLiveRecordVodConfigsWithOptionsAsync(DescribeLiveRecordVodConfigsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeLiveRecordVodConfigsResponse>(await DoRPCRequestAsync("DescribeLiveRecordVodConfigs", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeLiveRecordVodConfigsResponse DescribeLiveRecordVodConfigs(DescribeLiveRecordVodConfigsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeLiveRecordVodConfigsWithOptions(request, runtime);
        }

        public async Task<DescribeLiveRecordVodConfigsResponse> DescribeLiveRecordVodConfigsAsync(DescribeLiveRecordVodConfigsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeLiveRecordVodConfigsWithOptionsAsync(request, runtime);
        }

        public DescribeLiveShiftConfigsResponse DescribeLiveShiftConfigsWithOptions(DescribeLiveShiftConfigsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeLiveShiftConfigsResponse>(DoRPCRequest("DescribeLiveShiftConfigs", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeLiveShiftConfigsResponse> DescribeLiveShiftConfigsWithOptionsAsync(DescribeLiveShiftConfigsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeLiveShiftConfigsResponse>(await DoRPCRequestAsync("DescribeLiveShiftConfigs", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeLiveShiftConfigsResponse DescribeLiveShiftConfigs(DescribeLiveShiftConfigsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeLiveShiftConfigsWithOptions(request, runtime);
        }

        public async Task<DescribeLiveShiftConfigsResponse> DescribeLiveShiftConfigsAsync(DescribeLiveShiftConfigsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeLiveShiftConfigsWithOptionsAsync(request, runtime);
        }

        public DescribeLiveSnapshotConfigResponse DescribeLiveSnapshotConfigWithOptions(DescribeLiveSnapshotConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeLiveSnapshotConfigResponse>(DoRPCRequest("DescribeLiveSnapshotConfig", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeLiveSnapshotConfigResponse> DescribeLiveSnapshotConfigWithOptionsAsync(DescribeLiveSnapshotConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeLiveSnapshotConfigResponse>(await DoRPCRequestAsync("DescribeLiveSnapshotConfig", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeLiveSnapshotConfigResponse DescribeLiveSnapshotConfig(DescribeLiveSnapshotConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeLiveSnapshotConfigWithOptions(request, runtime);
        }

        public async Task<DescribeLiveSnapshotConfigResponse> DescribeLiveSnapshotConfigAsync(DescribeLiveSnapshotConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeLiveSnapshotConfigWithOptionsAsync(request, runtime);
        }

        public DescribeLiveSnapshotDetectPornConfigResponse DescribeLiveSnapshotDetectPornConfigWithOptions(DescribeLiveSnapshotDetectPornConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeLiveSnapshotDetectPornConfigResponse>(DoRPCRequest("DescribeLiveSnapshotDetectPornConfig", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeLiveSnapshotDetectPornConfigResponse> DescribeLiveSnapshotDetectPornConfigWithOptionsAsync(DescribeLiveSnapshotDetectPornConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeLiveSnapshotDetectPornConfigResponse>(await DoRPCRequestAsync("DescribeLiveSnapshotDetectPornConfig", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeLiveSnapshotDetectPornConfigResponse DescribeLiveSnapshotDetectPornConfig(DescribeLiveSnapshotDetectPornConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeLiveSnapshotDetectPornConfigWithOptions(request, runtime);
        }

        public async Task<DescribeLiveSnapshotDetectPornConfigResponse> DescribeLiveSnapshotDetectPornConfigAsync(DescribeLiveSnapshotDetectPornConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeLiveSnapshotDetectPornConfigWithOptionsAsync(request, runtime);
        }

        public DescribeLiveStreamBitRateDataResponse DescribeLiveStreamBitRateDataWithOptions(DescribeLiveStreamBitRateDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeLiveStreamBitRateDataResponse>(DoRPCRequest("DescribeLiveStreamBitRateData", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeLiveStreamBitRateDataResponse> DescribeLiveStreamBitRateDataWithOptionsAsync(DescribeLiveStreamBitRateDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeLiveStreamBitRateDataResponse>(await DoRPCRequestAsync("DescribeLiveStreamBitRateData", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeLiveStreamBitRateDataResponse DescribeLiveStreamBitRateData(DescribeLiveStreamBitRateDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeLiveStreamBitRateDataWithOptions(request, runtime);
        }

        public async Task<DescribeLiveStreamBitRateDataResponse> DescribeLiveStreamBitRateDataAsync(DescribeLiveStreamBitRateDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeLiveStreamBitRateDataWithOptionsAsync(request, runtime);
        }

        public DescribeLiveStreamCountResponse DescribeLiveStreamCountWithOptions(DescribeLiveStreamCountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<DescribeLiveStreamCountResponse>(DoRPCRequest("DescribeLiveStreamCount", "2016-11-01", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<DescribeLiveStreamCountResponse> DescribeLiveStreamCountWithOptionsAsync(DescribeLiveStreamCountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<DescribeLiveStreamCountResponse>(await DoRPCRequestAsync("DescribeLiveStreamCount", "2016-11-01", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public DescribeLiveStreamCountResponse DescribeLiveStreamCount(DescribeLiveStreamCountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeLiveStreamCountWithOptions(request, runtime);
        }

        public async Task<DescribeLiveStreamCountResponse> DescribeLiveStreamCountAsync(DescribeLiveStreamCountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeLiveStreamCountWithOptionsAsync(request, runtime);
        }

        public DescribeLiveStreamDelayConfigResponse DescribeLiveStreamDelayConfigWithOptions(DescribeLiveStreamDelayConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeLiveStreamDelayConfigResponse>(DoRPCRequest("DescribeLiveStreamDelayConfig", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeLiveStreamDelayConfigResponse> DescribeLiveStreamDelayConfigWithOptionsAsync(DescribeLiveStreamDelayConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeLiveStreamDelayConfigResponse>(await DoRPCRequestAsync("DescribeLiveStreamDelayConfig", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeLiveStreamDelayConfigResponse DescribeLiveStreamDelayConfig(DescribeLiveStreamDelayConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeLiveStreamDelayConfigWithOptions(request, runtime);
        }

        public async Task<DescribeLiveStreamDelayConfigResponse> DescribeLiveStreamDelayConfigAsync(DescribeLiveStreamDelayConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeLiveStreamDelayConfigWithOptionsAsync(request, runtime);
        }

        public DescribeLiveStreamHistoryUserNumResponse DescribeLiveStreamHistoryUserNumWithOptions(DescribeLiveStreamHistoryUserNumRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeLiveStreamHistoryUserNumResponse>(DoRPCRequest("DescribeLiveStreamHistoryUserNum", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeLiveStreamHistoryUserNumResponse> DescribeLiveStreamHistoryUserNumWithOptionsAsync(DescribeLiveStreamHistoryUserNumRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeLiveStreamHistoryUserNumResponse>(await DoRPCRequestAsync("DescribeLiveStreamHistoryUserNum", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeLiveStreamHistoryUserNumResponse DescribeLiveStreamHistoryUserNum(DescribeLiveStreamHistoryUserNumRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeLiveStreamHistoryUserNumWithOptions(request, runtime);
        }

        public async Task<DescribeLiveStreamHistoryUserNumResponse> DescribeLiveStreamHistoryUserNumAsync(DescribeLiveStreamHistoryUserNumRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeLiveStreamHistoryUserNumWithOptionsAsync(request, runtime);
        }

        public DescribeLiveStreamOptimizedFeatureConfigResponse DescribeLiveStreamOptimizedFeatureConfigWithOptions(DescribeLiveStreamOptimizedFeatureConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeLiveStreamOptimizedFeatureConfigResponse>(DoRPCRequest("DescribeLiveStreamOptimizedFeatureConfig", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeLiveStreamOptimizedFeatureConfigResponse> DescribeLiveStreamOptimizedFeatureConfigWithOptionsAsync(DescribeLiveStreamOptimizedFeatureConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeLiveStreamOptimizedFeatureConfigResponse>(await DoRPCRequestAsync("DescribeLiveStreamOptimizedFeatureConfig", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeLiveStreamOptimizedFeatureConfigResponse DescribeLiveStreamOptimizedFeatureConfig(DescribeLiveStreamOptimizedFeatureConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeLiveStreamOptimizedFeatureConfigWithOptions(request, runtime);
        }

        public async Task<DescribeLiveStreamOptimizedFeatureConfigResponse> DescribeLiveStreamOptimizedFeatureConfigAsync(DescribeLiveStreamOptimizedFeatureConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeLiveStreamOptimizedFeatureConfigWithOptionsAsync(request, runtime);
        }

        public DescribeLiveStreamRecordContentResponse DescribeLiveStreamRecordContentWithOptions(DescribeLiveStreamRecordContentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeLiveStreamRecordContentResponse>(DoRPCRequest("DescribeLiveStreamRecordContent", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeLiveStreamRecordContentResponse> DescribeLiveStreamRecordContentWithOptionsAsync(DescribeLiveStreamRecordContentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeLiveStreamRecordContentResponse>(await DoRPCRequestAsync("DescribeLiveStreamRecordContent", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeLiveStreamRecordContentResponse DescribeLiveStreamRecordContent(DescribeLiveStreamRecordContentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeLiveStreamRecordContentWithOptions(request, runtime);
        }

        public async Task<DescribeLiveStreamRecordContentResponse> DescribeLiveStreamRecordContentAsync(DescribeLiveStreamRecordContentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeLiveStreamRecordContentWithOptionsAsync(request, runtime);
        }

        public DescribeLiveStreamRecordIndexFileResponse DescribeLiveStreamRecordIndexFileWithOptions(DescribeLiveStreamRecordIndexFileRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeLiveStreamRecordIndexFileResponse>(DoRPCRequest("DescribeLiveStreamRecordIndexFile", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeLiveStreamRecordIndexFileResponse> DescribeLiveStreamRecordIndexFileWithOptionsAsync(DescribeLiveStreamRecordIndexFileRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeLiveStreamRecordIndexFileResponse>(await DoRPCRequestAsync("DescribeLiveStreamRecordIndexFile", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeLiveStreamRecordIndexFileResponse DescribeLiveStreamRecordIndexFile(DescribeLiveStreamRecordIndexFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeLiveStreamRecordIndexFileWithOptions(request, runtime);
        }

        public async Task<DescribeLiveStreamRecordIndexFileResponse> DescribeLiveStreamRecordIndexFileAsync(DescribeLiveStreamRecordIndexFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeLiveStreamRecordIndexFileWithOptionsAsync(request, runtime);
        }

        public DescribeLiveStreamRecordIndexFilesResponse DescribeLiveStreamRecordIndexFilesWithOptions(DescribeLiveStreamRecordIndexFilesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeLiveStreamRecordIndexFilesResponse>(DoRPCRequest("DescribeLiveStreamRecordIndexFiles", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeLiveStreamRecordIndexFilesResponse> DescribeLiveStreamRecordIndexFilesWithOptionsAsync(DescribeLiveStreamRecordIndexFilesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeLiveStreamRecordIndexFilesResponse>(await DoRPCRequestAsync("DescribeLiveStreamRecordIndexFiles", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeLiveStreamRecordIndexFilesResponse DescribeLiveStreamRecordIndexFiles(DescribeLiveStreamRecordIndexFilesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeLiveStreamRecordIndexFilesWithOptions(request, runtime);
        }

        public async Task<DescribeLiveStreamRecordIndexFilesResponse> DescribeLiveStreamRecordIndexFilesAsync(DescribeLiveStreamRecordIndexFilesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeLiveStreamRecordIndexFilesWithOptionsAsync(request, runtime);
        }

        public DescribeLiveStreamsBlockListResponse DescribeLiveStreamsBlockListWithOptions(DescribeLiveStreamsBlockListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeLiveStreamsBlockListResponse>(DoRPCRequest("DescribeLiveStreamsBlockList", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeLiveStreamsBlockListResponse> DescribeLiveStreamsBlockListWithOptionsAsync(DescribeLiveStreamsBlockListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeLiveStreamsBlockListResponse>(await DoRPCRequestAsync("DescribeLiveStreamsBlockList", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeLiveStreamsBlockListResponse DescribeLiveStreamsBlockList(DescribeLiveStreamsBlockListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeLiveStreamsBlockListWithOptions(request, runtime);
        }

        public async Task<DescribeLiveStreamsBlockListResponse> DescribeLiveStreamsBlockListAsync(DescribeLiveStreamsBlockListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeLiveStreamsBlockListWithOptionsAsync(request, runtime);
        }

        public DescribeLiveStreamsControlHistoryResponse DescribeLiveStreamsControlHistoryWithOptions(DescribeLiveStreamsControlHistoryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeLiveStreamsControlHistoryResponse>(DoRPCRequest("DescribeLiveStreamsControlHistory", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeLiveStreamsControlHistoryResponse> DescribeLiveStreamsControlHistoryWithOptionsAsync(DescribeLiveStreamsControlHistoryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeLiveStreamsControlHistoryResponse>(await DoRPCRequestAsync("DescribeLiveStreamsControlHistory", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeLiveStreamsControlHistoryResponse DescribeLiveStreamsControlHistory(DescribeLiveStreamsControlHistoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeLiveStreamsControlHistoryWithOptions(request, runtime);
        }

        public async Task<DescribeLiveStreamsControlHistoryResponse> DescribeLiveStreamsControlHistoryAsync(DescribeLiveStreamsControlHistoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeLiveStreamsControlHistoryWithOptionsAsync(request, runtime);
        }

        public DescribeLiveStreamSnapshotInfoResponse DescribeLiveStreamSnapshotInfoWithOptions(DescribeLiveStreamSnapshotInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeLiveStreamSnapshotInfoResponse>(DoRPCRequest("DescribeLiveStreamSnapshotInfo", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeLiveStreamSnapshotInfoResponse> DescribeLiveStreamSnapshotInfoWithOptionsAsync(DescribeLiveStreamSnapshotInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeLiveStreamSnapshotInfoResponse>(await DoRPCRequestAsync("DescribeLiveStreamSnapshotInfo", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeLiveStreamSnapshotInfoResponse DescribeLiveStreamSnapshotInfo(DescribeLiveStreamSnapshotInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeLiveStreamSnapshotInfoWithOptions(request, runtime);
        }

        public async Task<DescribeLiveStreamSnapshotInfoResponse> DescribeLiveStreamSnapshotInfoAsync(DescribeLiveStreamSnapshotInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeLiveStreamSnapshotInfoWithOptionsAsync(request, runtime);
        }

        public DescribeLiveStreamsNotifyUrlConfigResponse DescribeLiveStreamsNotifyUrlConfigWithOptions(DescribeLiveStreamsNotifyUrlConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeLiveStreamsNotifyUrlConfigResponse>(DoRPCRequest("DescribeLiveStreamsNotifyUrlConfig", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeLiveStreamsNotifyUrlConfigResponse> DescribeLiveStreamsNotifyUrlConfigWithOptionsAsync(DescribeLiveStreamsNotifyUrlConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeLiveStreamsNotifyUrlConfigResponse>(await DoRPCRequestAsync("DescribeLiveStreamsNotifyUrlConfig", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeLiveStreamsNotifyUrlConfigResponse DescribeLiveStreamsNotifyUrlConfig(DescribeLiveStreamsNotifyUrlConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeLiveStreamsNotifyUrlConfigWithOptions(request, runtime);
        }

        public async Task<DescribeLiveStreamsNotifyUrlConfigResponse> DescribeLiveStreamsNotifyUrlConfigAsync(DescribeLiveStreamsNotifyUrlConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeLiveStreamsNotifyUrlConfigWithOptionsAsync(request, runtime);
        }

        public DescribeLiveStreamsOnlineListResponse DescribeLiveStreamsOnlineListWithOptions(DescribeLiveStreamsOnlineListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeLiveStreamsOnlineListResponse>(DoRPCRequest("DescribeLiveStreamsOnlineList", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeLiveStreamsOnlineListResponse> DescribeLiveStreamsOnlineListWithOptionsAsync(DescribeLiveStreamsOnlineListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeLiveStreamsOnlineListResponse>(await DoRPCRequestAsync("DescribeLiveStreamsOnlineList", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeLiveStreamsOnlineListResponse DescribeLiveStreamsOnlineList(DescribeLiveStreamsOnlineListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeLiveStreamsOnlineListWithOptions(request, runtime);
        }

        public async Task<DescribeLiveStreamsOnlineListResponse> DescribeLiveStreamsOnlineListAsync(DescribeLiveStreamsOnlineListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeLiveStreamsOnlineListWithOptionsAsync(request, runtime);
        }

        public DescribeLiveStreamsPublishListResponse DescribeLiveStreamsPublishListWithOptions(DescribeLiveStreamsPublishListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeLiveStreamsPublishListResponse>(DoRPCRequest("DescribeLiveStreamsPublishList", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeLiveStreamsPublishListResponse> DescribeLiveStreamsPublishListWithOptionsAsync(DescribeLiveStreamsPublishListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeLiveStreamsPublishListResponse>(await DoRPCRequestAsync("DescribeLiveStreamsPublishList", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeLiveStreamsPublishListResponse DescribeLiveStreamsPublishList(DescribeLiveStreamsPublishListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeLiveStreamsPublishListWithOptions(request, runtime);
        }

        public async Task<DescribeLiveStreamsPublishListResponse> DescribeLiveStreamsPublishListAsync(DescribeLiveStreamsPublishListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeLiveStreamsPublishListWithOptionsAsync(request, runtime);
        }

        public DescribeLiveStreamTranscodeInfoResponse DescribeLiveStreamTranscodeInfoWithOptions(DescribeLiveStreamTranscodeInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeLiveStreamTranscodeInfoResponse>(DoRPCRequest("DescribeLiveStreamTranscodeInfo", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeLiveStreamTranscodeInfoResponse> DescribeLiveStreamTranscodeInfoWithOptionsAsync(DescribeLiveStreamTranscodeInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeLiveStreamTranscodeInfoResponse>(await DoRPCRequestAsync("DescribeLiveStreamTranscodeInfo", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeLiveStreamTranscodeInfoResponse DescribeLiveStreamTranscodeInfo(DescribeLiveStreamTranscodeInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeLiveStreamTranscodeInfoWithOptions(request, runtime);
        }

        public async Task<DescribeLiveStreamTranscodeInfoResponse> DescribeLiveStreamTranscodeInfoAsync(DescribeLiveStreamTranscodeInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeLiveStreamTranscodeInfoWithOptionsAsync(request, runtime);
        }

        public DescribeLiveStreamTranscodeStreamNumResponse DescribeLiveStreamTranscodeStreamNumWithOptions(DescribeLiveStreamTranscodeStreamNumRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeLiveStreamTranscodeStreamNumResponse>(DoRPCRequest("DescribeLiveStreamTranscodeStreamNum", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeLiveStreamTranscodeStreamNumResponse> DescribeLiveStreamTranscodeStreamNumWithOptionsAsync(DescribeLiveStreamTranscodeStreamNumRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeLiveStreamTranscodeStreamNumResponse>(await DoRPCRequestAsync("DescribeLiveStreamTranscodeStreamNum", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeLiveStreamTranscodeStreamNumResponse DescribeLiveStreamTranscodeStreamNum(DescribeLiveStreamTranscodeStreamNumRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeLiveStreamTranscodeStreamNumWithOptions(request, runtime);
        }

        public async Task<DescribeLiveStreamTranscodeStreamNumResponse> DescribeLiveStreamTranscodeStreamNumAsync(DescribeLiveStreamTranscodeStreamNumRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeLiveStreamTranscodeStreamNumWithOptionsAsync(request, runtime);
        }

        public DescribeLiveTagResourcesResponse DescribeLiveTagResourcesWithOptions(DescribeLiveTagResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeLiveTagResourcesResponse>(DoRPCRequest("DescribeLiveTagResources", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeLiveTagResourcesResponse> DescribeLiveTagResourcesWithOptionsAsync(DescribeLiveTagResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeLiveTagResourcesResponse>(await DoRPCRequestAsync("DescribeLiveTagResources", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeLiveTagResourcesResponse DescribeLiveTagResources(DescribeLiveTagResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeLiveTagResourcesWithOptions(request, runtime);
        }

        public async Task<DescribeLiveTagResourcesResponse> DescribeLiveTagResourcesAsync(DescribeLiveTagResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeLiveTagResourcesWithOptionsAsync(request, runtime);
        }

        public DescribeLiveTopDomainsByFlowResponse DescribeLiveTopDomainsByFlowWithOptions(DescribeLiveTopDomainsByFlowRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeLiveTopDomainsByFlowResponse>(DoRPCRequest("DescribeLiveTopDomainsByFlow", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeLiveTopDomainsByFlowResponse> DescribeLiveTopDomainsByFlowWithOptionsAsync(DescribeLiveTopDomainsByFlowRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeLiveTopDomainsByFlowResponse>(await DoRPCRequestAsync("DescribeLiveTopDomainsByFlow", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeLiveTopDomainsByFlowResponse DescribeLiveTopDomainsByFlow(DescribeLiveTopDomainsByFlowRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeLiveTopDomainsByFlowWithOptions(request, runtime);
        }

        public async Task<DescribeLiveTopDomainsByFlowResponse> DescribeLiveTopDomainsByFlowAsync(DescribeLiveTopDomainsByFlowRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeLiveTopDomainsByFlowWithOptionsAsync(request, runtime);
        }

        public DescribeLiveUserDomainsResponse DescribeLiveUserDomainsWithOptions(DescribeLiveUserDomainsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeLiveUserDomainsResponse>(DoRPCRequest("DescribeLiveUserDomains", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeLiveUserDomainsResponse> DescribeLiveUserDomainsWithOptionsAsync(DescribeLiveUserDomainsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeLiveUserDomainsResponse>(await DoRPCRequestAsync("DescribeLiveUserDomains", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeLiveUserDomainsResponse DescribeLiveUserDomains(DescribeLiveUserDomainsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeLiveUserDomainsWithOptions(request, runtime);
        }

        public async Task<DescribeLiveUserDomainsResponse> DescribeLiveUserDomainsAsync(DescribeLiveUserDomainsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeLiveUserDomainsWithOptionsAsync(request, runtime);
        }

        public DescribeLiveUserTagsResponse DescribeLiveUserTagsWithOptions(DescribeLiveUserTagsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeLiveUserTagsResponse>(DoRPCRequest("DescribeLiveUserTags", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeLiveUserTagsResponse> DescribeLiveUserTagsWithOptionsAsync(DescribeLiveUserTagsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeLiveUserTagsResponse>(await DoRPCRequestAsync("DescribeLiveUserTags", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeLiveUserTagsResponse DescribeLiveUserTags(DescribeLiveUserTagsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeLiveUserTagsWithOptions(request, runtime);
        }

        public async Task<DescribeLiveUserTagsResponse> DescribeLiveUserTagsAsync(DescribeLiveUserTagsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeLiveUserTagsWithOptionsAsync(request, runtime);
        }

        public DescribeLiveVerifyContentResponse DescribeLiveVerifyContentWithOptions(DescribeLiveVerifyContentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeLiveVerifyContentResponse>(DoRPCRequest("DescribeLiveVerifyContent", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeLiveVerifyContentResponse> DescribeLiveVerifyContentWithOptionsAsync(DescribeLiveVerifyContentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeLiveVerifyContentResponse>(await DoRPCRequestAsync("DescribeLiveVerifyContent", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeLiveVerifyContentResponse DescribeLiveVerifyContent(DescribeLiveVerifyContentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeLiveVerifyContentWithOptions(request, runtime);
        }

        public async Task<DescribeLiveVerifyContentResponse> DescribeLiveVerifyContentAsync(DescribeLiveVerifyContentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeLiveVerifyContentWithOptionsAsync(request, runtime);
        }

        public DescribeMixStreamListResponse DescribeMixStreamListWithOptions(DescribeMixStreamListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeMixStreamListResponse>(DoRPCRequest("DescribeMixStreamList", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeMixStreamListResponse> DescribeMixStreamListWithOptionsAsync(DescribeMixStreamListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeMixStreamListResponse>(await DoRPCRequestAsync("DescribeMixStreamList", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeMixStreamListResponse DescribeMixStreamList(DescribeMixStreamListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeMixStreamListWithOptions(request, runtime);
        }

        public async Task<DescribeMixStreamListResponse> DescribeMixStreamListAsync(DescribeMixStreamListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeMixStreamListWithOptionsAsync(request, runtime);
        }

        public DescribeRecordResponse DescribeRecordWithOptions(DescribeRecordRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeRecordResponse>(DoRPCRequest("DescribeRecord", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeRecordResponse> DescribeRecordWithOptionsAsync(DescribeRecordRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeRecordResponse>(await DoRPCRequestAsync("DescribeRecord", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeRecordResponse DescribeRecord(DescribeRecordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeRecordWithOptions(request, runtime);
        }

        public async Task<DescribeRecordResponse> DescribeRecordAsync(DescribeRecordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeRecordWithOptionsAsync(request, runtime);
        }

        public DescribeRecordsResponse DescribeRecordsWithOptions(DescribeRecordsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeRecordsResponse>(DoRPCRequest("DescribeRecords", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeRecordsResponse> DescribeRecordsWithOptionsAsync(DescribeRecordsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeRecordsResponse>(await DoRPCRequestAsync("DescribeRecords", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeRecordsResponse DescribeRecords(DescribeRecordsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeRecordsWithOptions(request, runtime);
        }

        public async Task<DescribeRecordsResponse> DescribeRecordsAsync(DescribeRecordsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeRecordsWithOptionsAsync(request, runtime);
        }

        public DescribeRoomKickoutUserListResponse DescribeRoomKickoutUserListWithOptions(DescribeRoomKickoutUserListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeRoomKickoutUserListResponse>(DoRPCRequest("DescribeRoomKickoutUserList", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeRoomKickoutUserListResponse> DescribeRoomKickoutUserListWithOptionsAsync(DescribeRoomKickoutUserListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeRoomKickoutUserListResponse>(await DoRPCRequestAsync("DescribeRoomKickoutUserList", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeRoomKickoutUserListResponse DescribeRoomKickoutUserList(DescribeRoomKickoutUserListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeRoomKickoutUserListWithOptions(request, runtime);
        }

        public async Task<DescribeRoomKickoutUserListResponse> DescribeRoomKickoutUserListAsync(DescribeRoomKickoutUserListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeRoomKickoutUserListWithOptionsAsync(request, runtime);
        }

        public DescribeRoomListResponse DescribeRoomListWithOptions(DescribeRoomListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeRoomListResponse>(DoRPCRequest("DescribeRoomList", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeRoomListResponse> DescribeRoomListWithOptionsAsync(DescribeRoomListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeRoomListResponse>(await DoRPCRequestAsync("DescribeRoomList", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeRoomListResponse DescribeRoomList(DescribeRoomListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeRoomListWithOptions(request, runtime);
        }

        public async Task<DescribeRoomListResponse> DescribeRoomListAsync(DescribeRoomListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeRoomListWithOptionsAsync(request, runtime);
        }

        public DescribeRoomStatusResponse DescribeRoomStatusWithOptions(DescribeRoomStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeRoomStatusResponse>(DoRPCRequest("DescribeRoomStatus", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeRoomStatusResponse> DescribeRoomStatusWithOptionsAsync(DescribeRoomStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeRoomStatusResponse>(await DoRPCRequestAsync("DescribeRoomStatus", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeRoomStatusResponse DescribeRoomStatus(DescribeRoomStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeRoomStatusWithOptions(request, runtime);
        }

        public async Task<DescribeRoomStatusResponse> DescribeRoomStatusAsync(DescribeRoomStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeRoomStatusWithOptionsAsync(request, runtime);
        }

        public DescribeStudioLayoutsResponse DescribeStudioLayoutsWithOptions(DescribeStudioLayoutsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeStudioLayoutsResponse>(DoRPCRequest("DescribeStudioLayouts", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeStudioLayoutsResponse> DescribeStudioLayoutsWithOptionsAsync(DescribeStudioLayoutsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeStudioLayoutsResponse>(await DoRPCRequestAsync("DescribeStudioLayouts", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeStudioLayoutsResponse DescribeStudioLayouts(DescribeStudioLayoutsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeStudioLayoutsWithOptions(request, runtime);
        }

        public async Task<DescribeStudioLayoutsResponse> DescribeStudioLayoutsAsync(DescribeStudioLayoutsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeStudioLayoutsWithOptionsAsync(request, runtime);
        }

        public DescribeUpBpsPeakDataResponse DescribeUpBpsPeakDataWithOptions(DescribeUpBpsPeakDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeUpBpsPeakDataResponse>(DoRPCRequest("DescribeUpBpsPeakData", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeUpBpsPeakDataResponse> DescribeUpBpsPeakDataWithOptionsAsync(DescribeUpBpsPeakDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeUpBpsPeakDataResponse>(await DoRPCRequestAsync("DescribeUpBpsPeakData", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeUpBpsPeakDataResponse DescribeUpBpsPeakData(DescribeUpBpsPeakDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeUpBpsPeakDataWithOptions(request, runtime);
        }

        public async Task<DescribeUpBpsPeakDataResponse> DescribeUpBpsPeakDataAsync(DescribeUpBpsPeakDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeUpBpsPeakDataWithOptionsAsync(request, runtime);
        }

        public DescribeUpBpsPeakOfLineResponse DescribeUpBpsPeakOfLineWithOptions(DescribeUpBpsPeakOfLineRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeUpBpsPeakOfLineResponse>(DoRPCRequest("DescribeUpBpsPeakOfLine", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeUpBpsPeakOfLineResponse> DescribeUpBpsPeakOfLineWithOptionsAsync(DescribeUpBpsPeakOfLineRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeUpBpsPeakOfLineResponse>(await DoRPCRequestAsync("DescribeUpBpsPeakOfLine", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeUpBpsPeakOfLineResponse DescribeUpBpsPeakOfLine(DescribeUpBpsPeakOfLineRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeUpBpsPeakOfLineWithOptions(request, runtime);
        }

        public async Task<DescribeUpBpsPeakOfLineResponse> DescribeUpBpsPeakOfLineAsync(DescribeUpBpsPeakOfLineRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeUpBpsPeakOfLineWithOptionsAsync(request, runtime);
        }

        public DescribeUpPeakPublishStreamDataResponse DescribeUpPeakPublishStreamDataWithOptions(DescribeUpPeakPublishStreamDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeUpPeakPublishStreamDataResponse>(DoRPCRequest("DescribeUpPeakPublishStreamData", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeUpPeakPublishStreamDataResponse> DescribeUpPeakPublishStreamDataWithOptionsAsync(DescribeUpPeakPublishStreamDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeUpPeakPublishStreamDataResponse>(await DoRPCRequestAsync("DescribeUpPeakPublishStreamData", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeUpPeakPublishStreamDataResponse DescribeUpPeakPublishStreamData(DescribeUpPeakPublishStreamDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeUpPeakPublishStreamDataWithOptions(request, runtime);
        }

        public async Task<DescribeUpPeakPublishStreamDataResponse> DescribeUpPeakPublishStreamDataAsync(DescribeUpPeakPublishStreamDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeUpPeakPublishStreamDataWithOptionsAsync(request, runtime);
        }

        public DisableLiveRealtimeLogDeliveryResponse DisableLiveRealtimeLogDeliveryWithOptions(DisableLiveRealtimeLogDeliveryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<DisableLiveRealtimeLogDeliveryResponse>(DoRPCRequest("DisableLiveRealtimeLogDelivery", "2016-11-01", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<DisableLiveRealtimeLogDeliveryResponse> DisableLiveRealtimeLogDeliveryWithOptionsAsync(DisableLiveRealtimeLogDeliveryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<DisableLiveRealtimeLogDeliveryResponse>(await DoRPCRequestAsync("DisableLiveRealtimeLogDelivery", "2016-11-01", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public DisableLiveRealtimeLogDeliveryResponse DisableLiveRealtimeLogDelivery(DisableLiveRealtimeLogDeliveryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DisableLiveRealtimeLogDeliveryWithOptions(request, runtime);
        }

        public async Task<DisableLiveRealtimeLogDeliveryResponse> DisableLiveRealtimeLogDeliveryAsync(DisableLiveRealtimeLogDeliveryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DisableLiveRealtimeLogDeliveryWithOptionsAsync(request, runtime);
        }

        public EditHtmlResourceResponse EditHtmlResourceWithOptions(EditHtmlResourceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<EditHtmlResourceResponse>(DoRPCRequest("EditHtmlResource", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<EditHtmlResourceResponse> EditHtmlResourceWithOptionsAsync(EditHtmlResourceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<EditHtmlResourceResponse>(await DoRPCRequestAsync("EditHtmlResource", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public EditHtmlResourceResponse EditHtmlResource(EditHtmlResourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return EditHtmlResourceWithOptions(request, runtime);
        }

        public async Task<EditHtmlResourceResponse> EditHtmlResourceAsync(EditHtmlResourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await EditHtmlResourceWithOptionsAsync(request, runtime);
        }

        public EditPlaylistResponse EditPlaylistWithOptions(EditPlaylistRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<EditPlaylistResponse>(DoRPCRequest("EditPlaylist", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<EditPlaylistResponse> EditPlaylistWithOptionsAsync(EditPlaylistRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<EditPlaylistResponse>(await DoRPCRequestAsync("EditPlaylist", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public EditPlaylistResponse EditPlaylist(EditPlaylistRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return EditPlaylistWithOptions(request, runtime);
        }

        public async Task<EditPlaylistResponse> EditPlaylistAsync(EditPlaylistRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await EditPlaylistWithOptionsAsync(request, runtime);
        }

        public EffectCasterUrgentResponse EffectCasterUrgentWithOptions(EffectCasterUrgentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<EffectCasterUrgentResponse>(DoRPCRequest("EffectCasterUrgent", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<EffectCasterUrgentResponse> EffectCasterUrgentWithOptionsAsync(EffectCasterUrgentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<EffectCasterUrgentResponse>(await DoRPCRequestAsync("EffectCasterUrgent", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public EffectCasterUrgentResponse EffectCasterUrgent(EffectCasterUrgentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return EffectCasterUrgentWithOptions(request, runtime);
        }

        public async Task<EffectCasterUrgentResponse> EffectCasterUrgentAsync(EffectCasterUrgentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await EffectCasterUrgentWithOptionsAsync(request, runtime);
        }

        public EffectCasterVideoResourceResponse EffectCasterVideoResourceWithOptions(EffectCasterVideoResourceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<EffectCasterVideoResourceResponse>(DoRPCRequest("EffectCasterVideoResource", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<EffectCasterVideoResourceResponse> EffectCasterVideoResourceWithOptionsAsync(EffectCasterVideoResourceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<EffectCasterVideoResourceResponse>(await DoRPCRequestAsync("EffectCasterVideoResource", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public EffectCasterVideoResourceResponse EffectCasterVideoResource(EffectCasterVideoResourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return EffectCasterVideoResourceWithOptions(request, runtime);
        }

        public async Task<EffectCasterVideoResourceResponse> EffectCasterVideoResourceAsync(EffectCasterVideoResourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await EffectCasterVideoResourceWithOptionsAsync(request, runtime);
        }

        public EnableLiveRealtimeLogDeliveryResponse EnableLiveRealtimeLogDeliveryWithOptions(EnableLiveRealtimeLogDeliveryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<EnableLiveRealtimeLogDeliveryResponse>(DoRPCRequest("EnableLiveRealtimeLogDelivery", "2016-11-01", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<EnableLiveRealtimeLogDeliveryResponse> EnableLiveRealtimeLogDeliveryWithOptionsAsync(EnableLiveRealtimeLogDeliveryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<EnableLiveRealtimeLogDeliveryResponse>(await DoRPCRequestAsync("EnableLiveRealtimeLogDelivery", "2016-11-01", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public EnableLiveRealtimeLogDeliveryResponse EnableLiveRealtimeLogDelivery(EnableLiveRealtimeLogDeliveryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return EnableLiveRealtimeLogDeliveryWithOptions(request, runtime);
        }

        public async Task<EnableLiveRealtimeLogDeliveryResponse> EnableLiveRealtimeLogDeliveryAsync(EnableLiveRealtimeLogDeliveryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await EnableLiveRealtimeLogDeliveryWithOptionsAsync(request, runtime);
        }

        public ForbidLiveStreamResponse ForbidLiveStreamWithOptions(ForbidLiveStreamRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ForbidLiveStreamResponse>(DoRPCRequest("ForbidLiveStream", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ForbidLiveStreamResponse> ForbidLiveStreamWithOptionsAsync(ForbidLiveStreamRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ForbidLiveStreamResponse>(await DoRPCRequestAsync("ForbidLiveStream", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ForbidLiveStreamResponse ForbidLiveStream(ForbidLiveStreamRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ForbidLiveStreamWithOptions(request, runtime);
        }

        public async Task<ForbidLiveStreamResponse> ForbidLiveStreamAsync(ForbidLiveStreamRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ForbidLiveStreamWithOptionsAsync(request, runtime);
        }

        public ForbidPushStreamResponse ForbidPushStreamWithOptions(ForbidPushStreamRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ForbidPushStreamResponse>(DoRPCRequest("ForbidPushStream", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ForbidPushStreamResponse> ForbidPushStreamWithOptionsAsync(ForbidPushStreamRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ForbidPushStreamResponse>(await DoRPCRequestAsync("ForbidPushStream", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ForbidPushStreamResponse ForbidPushStream(ForbidPushStreamRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ForbidPushStreamWithOptions(request, runtime);
        }

        public async Task<ForbidPushStreamResponse> ForbidPushStreamAsync(ForbidPushStreamRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ForbidPushStreamWithOptionsAsync(request, runtime);
        }

        public GetMultiRateConfigResponse GetMultiRateConfigWithOptions(GetMultiRateConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetMultiRateConfigResponse>(DoRPCRequest("GetMultiRateConfig", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetMultiRateConfigResponse> GetMultiRateConfigWithOptionsAsync(GetMultiRateConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetMultiRateConfigResponse>(await DoRPCRequestAsync("GetMultiRateConfig", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetMultiRateConfigResponse GetMultiRateConfig(GetMultiRateConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetMultiRateConfigWithOptions(request, runtime);
        }

        public async Task<GetMultiRateConfigResponse> GetMultiRateConfigAsync(GetMultiRateConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetMultiRateConfigWithOptionsAsync(request, runtime);
        }

        public GetMultiRateConfigListResponse GetMultiRateConfigListWithOptions(GetMultiRateConfigListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetMultiRateConfigListResponse>(DoRPCRequest("GetMultiRateConfigList", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetMultiRateConfigListResponse> GetMultiRateConfigListWithOptionsAsync(GetMultiRateConfigListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetMultiRateConfigListResponse>(await DoRPCRequestAsync("GetMultiRateConfigList", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetMultiRateConfigListResponse GetMultiRateConfigList(GetMultiRateConfigListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetMultiRateConfigListWithOptions(request, runtime);
        }

        public async Task<GetMultiRateConfigListResponse> GetMultiRateConfigListAsync(GetMultiRateConfigListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetMultiRateConfigListWithOptionsAsync(request, runtime);
        }

        public JoinBoardResponse JoinBoardWithOptions(JoinBoardRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<JoinBoardResponse>(DoRPCRequest("JoinBoard", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<JoinBoardResponse> JoinBoardWithOptionsAsync(JoinBoardRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<JoinBoardResponse>(await DoRPCRequestAsync("JoinBoard", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public JoinBoardResponse JoinBoard(JoinBoardRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return JoinBoardWithOptions(request, runtime);
        }

        public async Task<JoinBoardResponse> JoinBoardAsync(JoinBoardRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await JoinBoardWithOptionsAsync(request, runtime);
        }

        public ListLiveRealtimeLogDeliveryResponse ListLiveRealtimeLogDeliveryWithOptions(ListLiveRealtimeLogDeliveryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<ListLiveRealtimeLogDeliveryResponse>(DoRPCRequest("ListLiveRealtimeLogDelivery", "2016-11-01", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<ListLiveRealtimeLogDeliveryResponse> ListLiveRealtimeLogDeliveryWithOptionsAsync(ListLiveRealtimeLogDeliveryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<ListLiveRealtimeLogDeliveryResponse>(await DoRPCRequestAsync("ListLiveRealtimeLogDelivery", "2016-11-01", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public ListLiveRealtimeLogDeliveryResponse ListLiveRealtimeLogDelivery(ListLiveRealtimeLogDeliveryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListLiveRealtimeLogDeliveryWithOptions(request, runtime);
        }

        public async Task<ListLiveRealtimeLogDeliveryResponse> ListLiveRealtimeLogDeliveryAsync(ListLiveRealtimeLogDeliveryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListLiveRealtimeLogDeliveryWithOptionsAsync(request, runtime);
        }

        public ListLiveRealtimeLogDeliveryDomainsResponse ListLiveRealtimeLogDeliveryDomainsWithOptions(ListLiveRealtimeLogDeliveryDomainsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<ListLiveRealtimeLogDeliveryDomainsResponse>(DoRPCRequest("ListLiveRealtimeLogDeliveryDomains", "2016-11-01", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<ListLiveRealtimeLogDeliveryDomainsResponse> ListLiveRealtimeLogDeliveryDomainsWithOptionsAsync(ListLiveRealtimeLogDeliveryDomainsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<ListLiveRealtimeLogDeliveryDomainsResponse>(await DoRPCRequestAsync("ListLiveRealtimeLogDeliveryDomains", "2016-11-01", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public ListLiveRealtimeLogDeliveryDomainsResponse ListLiveRealtimeLogDeliveryDomains(ListLiveRealtimeLogDeliveryDomainsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListLiveRealtimeLogDeliveryDomainsWithOptions(request, runtime);
        }

        public async Task<ListLiveRealtimeLogDeliveryDomainsResponse> ListLiveRealtimeLogDeliveryDomainsAsync(ListLiveRealtimeLogDeliveryDomainsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListLiveRealtimeLogDeliveryDomainsWithOptionsAsync(request, runtime);
        }

        public ListLiveRealtimeLogDeliveryInfosResponse ListLiveRealtimeLogDeliveryInfosWithOptions(ListLiveRealtimeLogDeliveryInfosRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<ListLiveRealtimeLogDeliveryInfosResponse>(DoRPCRequest("ListLiveRealtimeLogDeliveryInfos", "2016-11-01", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<ListLiveRealtimeLogDeliveryInfosResponse> ListLiveRealtimeLogDeliveryInfosWithOptionsAsync(ListLiveRealtimeLogDeliveryInfosRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<ListLiveRealtimeLogDeliveryInfosResponse>(await DoRPCRequestAsync("ListLiveRealtimeLogDeliveryInfos", "2016-11-01", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public ListLiveRealtimeLogDeliveryInfosResponse ListLiveRealtimeLogDeliveryInfos(ListLiveRealtimeLogDeliveryInfosRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListLiveRealtimeLogDeliveryInfosWithOptions(request, runtime);
        }

        public async Task<ListLiveRealtimeLogDeliveryInfosResponse> ListLiveRealtimeLogDeliveryInfosAsync(ListLiveRealtimeLogDeliveryInfosRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListLiveRealtimeLogDeliveryInfosWithOptionsAsync(request, runtime);
        }

        public ListPlaylistResponse ListPlaylistWithOptions(ListPlaylistRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListPlaylistResponse>(DoRPCRequest("ListPlaylist", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListPlaylistResponse> ListPlaylistWithOptionsAsync(ListPlaylistRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListPlaylistResponse>(await DoRPCRequestAsync("ListPlaylist", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListPlaylistResponse ListPlaylist(ListPlaylistRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListPlaylistWithOptions(request, runtime);
        }

        public async Task<ListPlaylistResponse> ListPlaylistAsync(ListPlaylistRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListPlaylistWithOptionsAsync(request, runtime);
        }

        public ListPlaylistItemsResponse ListPlaylistItemsWithOptions(ListPlaylistItemsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListPlaylistItemsResponse>(DoRPCRequest("ListPlaylistItems", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListPlaylistItemsResponse> ListPlaylistItemsWithOptionsAsync(ListPlaylistItemsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListPlaylistItemsResponse>(await DoRPCRequestAsync("ListPlaylistItems", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListPlaylistItemsResponse ListPlaylistItems(ListPlaylistItemsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListPlaylistItemsWithOptions(request, runtime);
        }

        public async Task<ListPlaylistItemsResponse> ListPlaylistItemsAsync(ListPlaylistItemsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListPlaylistItemsWithOptionsAsync(request, runtime);
        }

        public ModifyCasterComponentResponse ModifyCasterComponentWithOptions(ModifyCasterComponentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyCasterComponentResponse>(DoRPCRequest("ModifyCasterComponent", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyCasterComponentResponse> ModifyCasterComponentWithOptionsAsync(ModifyCasterComponentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyCasterComponentResponse>(await DoRPCRequestAsync("ModifyCasterComponent", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyCasterComponentResponse ModifyCasterComponent(ModifyCasterComponentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyCasterComponentWithOptions(request, runtime);
        }

        public async Task<ModifyCasterComponentResponse> ModifyCasterComponentAsync(ModifyCasterComponentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyCasterComponentWithOptionsAsync(request, runtime);
        }

        public ModifyCasterEpisodeResponse ModifyCasterEpisodeWithOptions(ModifyCasterEpisodeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyCasterEpisodeResponse>(DoRPCRequest("ModifyCasterEpisode", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyCasterEpisodeResponse> ModifyCasterEpisodeWithOptionsAsync(ModifyCasterEpisodeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyCasterEpisodeResponse>(await DoRPCRequestAsync("ModifyCasterEpisode", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyCasterEpisodeResponse ModifyCasterEpisode(ModifyCasterEpisodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyCasterEpisodeWithOptions(request, runtime);
        }

        public async Task<ModifyCasterEpisodeResponse> ModifyCasterEpisodeAsync(ModifyCasterEpisodeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyCasterEpisodeWithOptionsAsync(request, runtime);
        }

        public ModifyCasterLayoutResponse ModifyCasterLayoutWithOptions(ModifyCasterLayoutRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyCasterLayoutResponse>(DoRPCRequest("ModifyCasterLayout", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyCasterLayoutResponse> ModifyCasterLayoutWithOptionsAsync(ModifyCasterLayoutRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyCasterLayoutResponse>(await DoRPCRequestAsync("ModifyCasterLayout", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyCasterLayoutResponse ModifyCasterLayout(ModifyCasterLayoutRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyCasterLayoutWithOptions(request, runtime);
        }

        public async Task<ModifyCasterLayoutResponse> ModifyCasterLayoutAsync(ModifyCasterLayoutRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyCasterLayoutWithOptionsAsync(request, runtime);
        }

        public ModifyCasterProgramResponse ModifyCasterProgramWithOptions(ModifyCasterProgramRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyCasterProgramResponse>(DoRPCRequest("ModifyCasterProgram", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyCasterProgramResponse> ModifyCasterProgramWithOptionsAsync(ModifyCasterProgramRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyCasterProgramResponse>(await DoRPCRequestAsync("ModifyCasterProgram", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyCasterProgramResponse ModifyCasterProgram(ModifyCasterProgramRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyCasterProgramWithOptions(request, runtime);
        }

        public async Task<ModifyCasterProgramResponse> ModifyCasterProgramAsync(ModifyCasterProgramRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyCasterProgramWithOptionsAsync(request, runtime);
        }

        public ModifyCasterVideoResourceResponse ModifyCasterVideoResourceWithOptions(ModifyCasterVideoResourceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyCasterVideoResourceResponse>(DoRPCRequest("ModifyCasterVideoResource", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyCasterVideoResourceResponse> ModifyCasterVideoResourceWithOptionsAsync(ModifyCasterVideoResourceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyCasterVideoResourceResponse>(await DoRPCRequestAsync("ModifyCasterVideoResource", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyCasterVideoResourceResponse ModifyCasterVideoResource(ModifyCasterVideoResourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyCasterVideoResourceWithOptions(request, runtime);
        }

        public async Task<ModifyCasterVideoResourceResponse> ModifyCasterVideoResourceAsync(ModifyCasterVideoResourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyCasterVideoResourceWithOptionsAsync(request, runtime);
        }

        public ModifyLiveDomainSchdmByPropertyResponse ModifyLiveDomainSchdmByPropertyWithOptions(ModifyLiveDomainSchdmByPropertyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyLiveDomainSchdmByPropertyResponse>(DoRPCRequest("ModifyLiveDomainSchdmByProperty", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyLiveDomainSchdmByPropertyResponse> ModifyLiveDomainSchdmByPropertyWithOptionsAsync(ModifyLiveDomainSchdmByPropertyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyLiveDomainSchdmByPropertyResponse>(await DoRPCRequestAsync("ModifyLiveDomainSchdmByProperty", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyLiveDomainSchdmByPropertyResponse ModifyLiveDomainSchdmByProperty(ModifyLiveDomainSchdmByPropertyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyLiveDomainSchdmByPropertyWithOptions(request, runtime);
        }

        public async Task<ModifyLiveDomainSchdmByPropertyResponse> ModifyLiveDomainSchdmByPropertyAsync(ModifyLiveDomainSchdmByPropertyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyLiveDomainSchdmByPropertyWithOptionsAsync(request, runtime);
        }

        public ModifyLiveRealtimeLogDeliveryResponse ModifyLiveRealtimeLogDeliveryWithOptions(ModifyLiveRealtimeLogDeliveryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<ModifyLiveRealtimeLogDeliveryResponse>(DoRPCRequest("ModifyLiveRealtimeLogDelivery", "2016-11-01", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<ModifyLiveRealtimeLogDeliveryResponse> ModifyLiveRealtimeLogDeliveryWithOptionsAsync(ModifyLiveRealtimeLogDeliveryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<ModifyLiveRealtimeLogDeliveryResponse>(await DoRPCRequestAsync("ModifyLiveRealtimeLogDelivery", "2016-11-01", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public ModifyLiveRealtimeLogDeliveryResponse ModifyLiveRealtimeLogDelivery(ModifyLiveRealtimeLogDeliveryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyLiveRealtimeLogDeliveryWithOptions(request, runtime);
        }

        public async Task<ModifyLiveRealtimeLogDeliveryResponse> ModifyLiveRealtimeLogDeliveryAsync(ModifyLiveRealtimeLogDeliveryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyLiveRealtimeLogDeliveryWithOptionsAsync(request, runtime);
        }

        public ModifyStudioLayoutResponse ModifyStudioLayoutWithOptions(ModifyStudioLayoutRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyStudioLayoutResponse>(DoRPCRequest("ModifyStudioLayout", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ModifyStudioLayoutResponse> ModifyStudioLayoutWithOptionsAsync(ModifyStudioLayoutRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ModifyStudioLayoutResponse>(await DoRPCRequestAsync("ModifyStudioLayout", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ModifyStudioLayoutResponse ModifyStudioLayout(ModifyStudioLayoutRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyStudioLayoutWithOptions(request, runtime);
        }

        public async Task<ModifyStudioLayoutResponse> ModifyStudioLayoutAsync(ModifyStudioLayoutRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyStudioLayoutWithOptionsAsync(request, runtime);
        }

        public OpenLiveShiftResponse OpenLiveShiftWithOptions(OpenLiveShiftRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<OpenLiveShiftResponse>(DoRPCRequest("OpenLiveShift", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<OpenLiveShiftResponse> OpenLiveShiftWithOptionsAsync(OpenLiveShiftRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<OpenLiveShiftResponse>(await DoRPCRequestAsync("OpenLiveShift", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public OpenLiveShiftResponse OpenLiveShift(OpenLiveShiftRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return OpenLiveShiftWithOptions(request, runtime);
        }

        public async Task<OpenLiveShiftResponse> OpenLiveShiftAsync(OpenLiveShiftRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await OpenLiveShiftWithOptionsAsync(request, runtime);
        }

        public RealTimeRecordCommandResponse RealTimeRecordCommandWithOptions(RealTimeRecordCommandRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RealTimeRecordCommandResponse>(DoRPCRequest("RealTimeRecordCommand", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<RealTimeRecordCommandResponse> RealTimeRecordCommandWithOptionsAsync(RealTimeRecordCommandRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RealTimeRecordCommandResponse>(await DoRPCRequestAsync("RealTimeRecordCommand", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public RealTimeRecordCommandResponse RealTimeRecordCommand(RealTimeRecordCommandRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RealTimeRecordCommandWithOptions(request, runtime);
        }

        public async Task<RealTimeRecordCommandResponse> RealTimeRecordCommandAsync(RealTimeRecordCommandRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RealTimeRecordCommandWithOptionsAsync(request, runtime);
        }

        public RealTimeSnapshotCommandResponse RealTimeSnapshotCommandWithOptions(RealTimeSnapshotCommandRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RealTimeSnapshotCommandResponse>(DoRPCRequest("RealTimeSnapshotCommand", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<RealTimeSnapshotCommandResponse> RealTimeSnapshotCommandWithOptionsAsync(RealTimeSnapshotCommandRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RealTimeSnapshotCommandResponse>(await DoRPCRequestAsync("RealTimeSnapshotCommand", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public RealTimeSnapshotCommandResponse RealTimeSnapshotCommand(RealTimeSnapshotCommandRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RealTimeSnapshotCommandWithOptions(request, runtime);
        }

        public async Task<RealTimeSnapshotCommandResponse> RealTimeSnapshotCommandAsync(RealTimeSnapshotCommandRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RealTimeSnapshotCommandWithOptionsAsync(request, runtime);
        }

        public ResumeLiveStreamResponse ResumeLiveStreamWithOptions(ResumeLiveStreamRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ResumeLiveStreamResponse>(DoRPCRequest("ResumeLiveStream", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ResumeLiveStreamResponse> ResumeLiveStreamWithOptionsAsync(ResumeLiveStreamRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ResumeLiveStreamResponse>(await DoRPCRequestAsync("ResumeLiveStream", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ResumeLiveStreamResponse ResumeLiveStream(ResumeLiveStreamRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ResumeLiveStreamWithOptions(request, runtime);
        }

        public async Task<ResumeLiveStreamResponse> ResumeLiveStreamAsync(ResumeLiveStreamRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ResumeLiveStreamWithOptionsAsync(request, runtime);
        }

        public SendRoomNotificationResponse SendRoomNotificationWithOptions(SendRoomNotificationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SendRoomNotificationResponse>(DoRPCRequest("SendRoomNotification", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SendRoomNotificationResponse> SendRoomNotificationWithOptionsAsync(SendRoomNotificationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SendRoomNotificationResponse>(await DoRPCRequestAsync("SendRoomNotification", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public SendRoomNotificationResponse SendRoomNotification(SendRoomNotificationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SendRoomNotificationWithOptions(request, runtime);
        }

        public async Task<SendRoomNotificationResponse> SendRoomNotificationAsync(SendRoomNotificationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SendRoomNotificationWithOptionsAsync(request, runtime);
        }

        public SendRoomUserNotificationResponse SendRoomUserNotificationWithOptions(SendRoomUserNotificationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SendRoomUserNotificationResponse>(DoRPCRequest("SendRoomUserNotification", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SendRoomUserNotificationResponse> SendRoomUserNotificationWithOptionsAsync(SendRoomUserNotificationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SendRoomUserNotificationResponse>(await DoRPCRequestAsync("SendRoomUserNotification", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public SendRoomUserNotificationResponse SendRoomUserNotification(SendRoomUserNotificationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SendRoomUserNotificationWithOptions(request, runtime);
        }

        public async Task<SendRoomUserNotificationResponse> SendRoomUserNotificationAsync(SendRoomUserNotificationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SendRoomUserNotificationWithOptionsAsync(request, runtime);
        }

        public SetBoardCallbackResponse SetBoardCallbackWithOptions(SetBoardCallbackRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SetBoardCallbackResponse>(DoRPCRequest("SetBoardCallback", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SetBoardCallbackResponse> SetBoardCallbackWithOptionsAsync(SetBoardCallbackRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SetBoardCallbackResponse>(await DoRPCRequestAsync("SetBoardCallback", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public SetBoardCallbackResponse SetBoardCallback(SetBoardCallbackRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetBoardCallbackWithOptions(request, runtime);
        }

        public async Task<SetBoardCallbackResponse> SetBoardCallbackAsync(SetBoardCallbackRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetBoardCallbackWithOptionsAsync(request, runtime);
        }

        public SetCasterChannelResponse SetCasterChannelWithOptions(SetCasterChannelRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SetCasterChannelResponse>(DoRPCRequest("SetCasterChannel", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SetCasterChannelResponse> SetCasterChannelWithOptionsAsync(SetCasterChannelRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SetCasterChannelResponse>(await DoRPCRequestAsync("SetCasterChannel", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public SetCasterChannelResponse SetCasterChannel(SetCasterChannelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetCasterChannelWithOptions(request, runtime);
        }

        public async Task<SetCasterChannelResponse> SetCasterChannelAsync(SetCasterChannelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetCasterChannelWithOptionsAsync(request, runtime);
        }

        public SetCasterConfigResponse SetCasterConfigWithOptions(SetCasterConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SetCasterConfigResponse>(DoRPCRequest("SetCasterConfig", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SetCasterConfigResponse> SetCasterConfigWithOptionsAsync(SetCasterConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SetCasterConfigResponse>(await DoRPCRequestAsync("SetCasterConfig", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public SetCasterConfigResponse SetCasterConfig(SetCasterConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetCasterConfigWithOptions(request, runtime);
        }

        public async Task<SetCasterConfigResponse> SetCasterConfigAsync(SetCasterConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetCasterConfigWithOptionsAsync(request, runtime);
        }

        public SetCasterSceneConfigResponse SetCasterSceneConfigWithOptions(SetCasterSceneConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SetCasterSceneConfigResponse>(DoRPCRequest("SetCasterSceneConfig", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SetCasterSceneConfigResponse> SetCasterSceneConfigWithOptionsAsync(SetCasterSceneConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SetCasterSceneConfigResponse>(await DoRPCRequestAsync("SetCasterSceneConfig", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public SetCasterSceneConfigResponse SetCasterSceneConfig(SetCasterSceneConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetCasterSceneConfigWithOptions(request, runtime);
        }

        public async Task<SetCasterSceneConfigResponse> SetCasterSceneConfigAsync(SetCasterSceneConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetCasterSceneConfigWithOptionsAsync(request, runtime);
        }

        public SetCasterSyncGroupResponse SetCasterSyncGroupWithOptions(SetCasterSyncGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SetCasterSyncGroupResponse>(DoRPCRequest("SetCasterSyncGroup", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SetCasterSyncGroupResponse> SetCasterSyncGroupWithOptionsAsync(SetCasterSyncGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SetCasterSyncGroupResponse>(await DoRPCRequestAsync("SetCasterSyncGroup", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public SetCasterSyncGroupResponse SetCasterSyncGroup(SetCasterSyncGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetCasterSyncGroupWithOptions(request, runtime);
        }

        public async Task<SetCasterSyncGroupResponse> SetCasterSyncGroupAsync(SetCasterSyncGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetCasterSyncGroupWithOptionsAsync(request, runtime);
        }

        public SetLiveDomainCertificateResponse SetLiveDomainCertificateWithOptions(SetLiveDomainCertificateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SetLiveDomainCertificateResponse>(DoRPCRequest("SetLiveDomainCertificate", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SetLiveDomainCertificateResponse> SetLiveDomainCertificateWithOptionsAsync(SetLiveDomainCertificateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SetLiveDomainCertificateResponse>(await DoRPCRequestAsync("SetLiveDomainCertificate", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public SetLiveDomainCertificateResponse SetLiveDomainCertificate(SetLiveDomainCertificateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetLiveDomainCertificateWithOptions(request, runtime);
        }

        public async Task<SetLiveDomainCertificateResponse> SetLiveDomainCertificateAsync(SetLiveDomainCertificateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetLiveDomainCertificateWithOptionsAsync(request, runtime);
        }

        public SetLiveLazyPullStreamInfoConfigResponse SetLiveLazyPullStreamInfoConfigWithOptions(SetLiveLazyPullStreamInfoConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SetLiveLazyPullStreamInfoConfigResponse>(DoRPCRequest("SetLiveLazyPullStreamInfoConfig", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SetLiveLazyPullStreamInfoConfigResponse> SetLiveLazyPullStreamInfoConfigWithOptionsAsync(SetLiveLazyPullStreamInfoConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SetLiveLazyPullStreamInfoConfigResponse>(await DoRPCRequestAsync("SetLiveLazyPullStreamInfoConfig", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public SetLiveLazyPullStreamInfoConfigResponse SetLiveLazyPullStreamInfoConfig(SetLiveLazyPullStreamInfoConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetLiveLazyPullStreamInfoConfigWithOptions(request, runtime);
        }

        public async Task<SetLiveLazyPullStreamInfoConfigResponse> SetLiveLazyPullStreamInfoConfigAsync(SetLiveLazyPullStreamInfoConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetLiveLazyPullStreamInfoConfigWithOptionsAsync(request, runtime);
        }

        public SetLiveStreamDelayConfigResponse SetLiveStreamDelayConfigWithOptions(SetLiveStreamDelayConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SetLiveStreamDelayConfigResponse>(DoRPCRequest("SetLiveStreamDelayConfig", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SetLiveStreamDelayConfigResponse> SetLiveStreamDelayConfigWithOptionsAsync(SetLiveStreamDelayConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SetLiveStreamDelayConfigResponse>(await DoRPCRequestAsync("SetLiveStreamDelayConfig", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public SetLiveStreamDelayConfigResponse SetLiveStreamDelayConfig(SetLiveStreamDelayConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetLiveStreamDelayConfigWithOptions(request, runtime);
        }

        public async Task<SetLiveStreamDelayConfigResponse> SetLiveStreamDelayConfigAsync(SetLiveStreamDelayConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetLiveStreamDelayConfigWithOptionsAsync(request, runtime);
        }

        public SetLiveStreamOptimizedFeatureConfigResponse SetLiveStreamOptimizedFeatureConfigWithOptions(SetLiveStreamOptimizedFeatureConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SetLiveStreamOptimizedFeatureConfigResponse>(DoRPCRequest("SetLiveStreamOptimizedFeatureConfig", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SetLiveStreamOptimizedFeatureConfigResponse> SetLiveStreamOptimizedFeatureConfigWithOptionsAsync(SetLiveStreamOptimizedFeatureConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SetLiveStreamOptimizedFeatureConfigResponse>(await DoRPCRequestAsync("SetLiveStreamOptimizedFeatureConfig", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public SetLiveStreamOptimizedFeatureConfigResponse SetLiveStreamOptimizedFeatureConfig(SetLiveStreamOptimizedFeatureConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetLiveStreamOptimizedFeatureConfigWithOptions(request, runtime);
        }

        public async Task<SetLiveStreamOptimizedFeatureConfigResponse> SetLiveStreamOptimizedFeatureConfigAsync(SetLiveStreamOptimizedFeatureConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetLiveStreamOptimizedFeatureConfigWithOptionsAsync(request, runtime);
        }

        public SetLiveStreamsNotifyUrlConfigResponse SetLiveStreamsNotifyUrlConfigWithOptions(SetLiveStreamsNotifyUrlConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SetLiveStreamsNotifyUrlConfigResponse>(DoRPCRequest("SetLiveStreamsNotifyUrlConfig", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SetLiveStreamsNotifyUrlConfigResponse> SetLiveStreamsNotifyUrlConfigWithOptionsAsync(SetLiveStreamsNotifyUrlConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SetLiveStreamsNotifyUrlConfigResponse>(await DoRPCRequestAsync("SetLiveStreamsNotifyUrlConfig", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public SetLiveStreamsNotifyUrlConfigResponse SetLiveStreamsNotifyUrlConfig(SetLiveStreamsNotifyUrlConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetLiveStreamsNotifyUrlConfigWithOptions(request, runtime);
        }

        public async Task<SetLiveStreamsNotifyUrlConfigResponse> SetLiveStreamsNotifyUrlConfigAsync(SetLiveStreamsNotifyUrlConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetLiveStreamsNotifyUrlConfigWithOptionsAsync(request, runtime);
        }

        public StartBoardRecordResponse StartBoardRecordWithOptions(StartBoardRecordRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<StartBoardRecordResponse>(DoRPCRequest("StartBoardRecord", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<StartBoardRecordResponse> StartBoardRecordWithOptionsAsync(StartBoardRecordRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<StartBoardRecordResponse>(await DoRPCRequestAsync("StartBoardRecord", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public StartBoardRecordResponse StartBoardRecord(StartBoardRecordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StartBoardRecordWithOptions(request, runtime);
        }

        public async Task<StartBoardRecordResponse> StartBoardRecordAsync(StartBoardRecordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StartBoardRecordWithOptionsAsync(request, runtime);
        }

        public StartCasterResponse StartCasterWithOptions(StartCasterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<StartCasterResponse>(DoRPCRequest("StartCaster", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<StartCasterResponse> StartCasterWithOptionsAsync(StartCasterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<StartCasterResponse>(await DoRPCRequestAsync("StartCaster", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public StartCasterResponse StartCaster(StartCasterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StartCasterWithOptions(request, runtime);
        }

        public async Task<StartCasterResponse> StartCasterAsync(StartCasterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StartCasterWithOptionsAsync(request, runtime);
        }

        public StartCasterSceneResponse StartCasterSceneWithOptions(StartCasterSceneRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<StartCasterSceneResponse>(DoRPCRequest("StartCasterScene", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<StartCasterSceneResponse> StartCasterSceneWithOptionsAsync(StartCasterSceneRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<StartCasterSceneResponse>(await DoRPCRequestAsync("StartCasterScene", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public StartCasterSceneResponse StartCasterScene(StartCasterSceneRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StartCasterSceneWithOptions(request, runtime);
        }

        public async Task<StartCasterSceneResponse> StartCasterSceneAsync(StartCasterSceneRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StartCasterSceneWithOptionsAsync(request, runtime);
        }

        public StartLiveDomainResponse StartLiveDomainWithOptions(StartLiveDomainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<StartLiveDomainResponse>(DoRPCRequest("StartLiveDomain", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<StartLiveDomainResponse> StartLiveDomainWithOptionsAsync(StartLiveDomainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<StartLiveDomainResponse>(await DoRPCRequestAsync("StartLiveDomain", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public StartLiveDomainResponse StartLiveDomain(StartLiveDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StartLiveDomainWithOptions(request, runtime);
        }

        public async Task<StartLiveDomainResponse> StartLiveDomainAsync(StartLiveDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StartLiveDomainWithOptionsAsync(request, runtime);
        }

        public StartLiveIndexResponse StartLiveIndexWithOptions(StartLiveIndexRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<StartLiveIndexResponse>(DoRPCRequest("StartLiveIndex", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<StartLiveIndexResponse> StartLiveIndexWithOptionsAsync(StartLiveIndexRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<StartLiveIndexResponse>(await DoRPCRequestAsync("StartLiveIndex", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public StartLiveIndexResponse StartLiveIndex(StartLiveIndexRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StartLiveIndexWithOptions(request, runtime);
        }

        public async Task<StartLiveIndexResponse> StartLiveIndexAsync(StartLiveIndexRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StartLiveIndexWithOptionsAsync(request, runtime);
        }

        public StartPlaylistResponse StartPlaylistWithOptions(StartPlaylistRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<StartPlaylistResponse>(DoRPCRequest("StartPlaylist", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<StartPlaylistResponse> StartPlaylistWithOptionsAsync(StartPlaylistRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<StartPlaylistResponse>(await DoRPCRequestAsync("StartPlaylist", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public StartPlaylistResponse StartPlaylist(StartPlaylistRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StartPlaylistWithOptions(request, runtime);
        }

        public async Task<StartPlaylistResponse> StartPlaylistAsync(StartPlaylistRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StartPlaylistWithOptionsAsync(request, runtime);
        }

        public StopCasterResponse StopCasterWithOptions(StopCasterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<StopCasterResponse>(DoRPCRequest("StopCaster", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<StopCasterResponse> StopCasterWithOptionsAsync(StopCasterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<StopCasterResponse>(await DoRPCRequestAsync("StopCaster", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public StopCasterResponse StopCaster(StopCasterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StopCasterWithOptions(request, runtime);
        }

        public async Task<StopCasterResponse> StopCasterAsync(StopCasterRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StopCasterWithOptionsAsync(request, runtime);
        }

        public StopCasterSceneResponse StopCasterSceneWithOptions(StopCasterSceneRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<StopCasterSceneResponse>(DoRPCRequest("StopCasterScene", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<StopCasterSceneResponse> StopCasterSceneWithOptionsAsync(StopCasterSceneRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<StopCasterSceneResponse>(await DoRPCRequestAsync("StopCasterScene", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public StopCasterSceneResponse StopCasterScene(StopCasterSceneRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StopCasterSceneWithOptions(request, runtime);
        }

        public async Task<StopCasterSceneResponse> StopCasterSceneAsync(StopCasterSceneRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StopCasterSceneWithOptionsAsync(request, runtime);
        }

        public StopLiveDomainResponse StopLiveDomainWithOptions(StopLiveDomainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<StopLiveDomainResponse>(DoRPCRequest("StopLiveDomain", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<StopLiveDomainResponse> StopLiveDomainWithOptionsAsync(StopLiveDomainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<StopLiveDomainResponse>(await DoRPCRequestAsync("StopLiveDomain", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public StopLiveDomainResponse StopLiveDomain(StopLiveDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StopLiveDomainWithOptions(request, runtime);
        }

        public async Task<StopLiveDomainResponse> StopLiveDomainAsync(StopLiveDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StopLiveDomainWithOptionsAsync(request, runtime);
        }

        public StopLiveIndexResponse StopLiveIndexWithOptions(StopLiveIndexRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<StopLiveIndexResponse>(DoRPCRequest("StopLiveIndex", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<StopLiveIndexResponse> StopLiveIndexWithOptionsAsync(StopLiveIndexRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<StopLiveIndexResponse>(await DoRPCRequestAsync("StopLiveIndex", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public StopLiveIndexResponse StopLiveIndex(StopLiveIndexRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StopLiveIndexWithOptions(request, runtime);
        }

        public async Task<StopLiveIndexResponse> StopLiveIndexAsync(StopLiveIndexRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StopLiveIndexWithOptionsAsync(request, runtime);
        }

        public StopPlaylistResponse StopPlaylistWithOptions(StopPlaylistRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<StopPlaylistResponse>(DoRPCRequest("StopPlaylist", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<StopPlaylistResponse> StopPlaylistWithOptionsAsync(StopPlaylistRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<StopPlaylistResponse>(await DoRPCRequestAsync("StopPlaylist", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public StopPlaylistResponse StopPlaylist(StopPlaylistRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StopPlaylistWithOptions(request, runtime);
        }

        public async Task<StopPlaylistResponse> StopPlaylistAsync(StopPlaylistRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StopPlaylistWithOptionsAsync(request, runtime);
        }

        public TagLiveResourcesResponse TagLiveResourcesWithOptions(TagLiveResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<TagLiveResourcesResponse>(DoRPCRequest("TagLiveResources", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<TagLiveResourcesResponse> TagLiveResourcesWithOptionsAsync(TagLiveResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<TagLiveResourcesResponse>(await DoRPCRequestAsync("TagLiveResources", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public TagLiveResourcesResponse TagLiveResources(TagLiveResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return TagLiveResourcesWithOptions(request, runtime);
        }

        public async Task<TagLiveResourcesResponse> TagLiveResourcesAsync(TagLiveResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await TagLiveResourcesWithOptionsAsync(request, runtime);
        }

        public UnTagLiveResourcesResponse UnTagLiveResourcesWithOptions(UnTagLiveResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UnTagLiveResourcesResponse>(DoRPCRequest("UnTagLiveResources", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UnTagLiveResourcesResponse> UnTagLiveResourcesWithOptionsAsync(UnTagLiveResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UnTagLiveResourcesResponse>(await DoRPCRequestAsync("UnTagLiveResources", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UnTagLiveResourcesResponse UnTagLiveResources(UnTagLiveResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UnTagLiveResourcesWithOptions(request, runtime);
        }

        public async Task<UnTagLiveResourcesResponse> UnTagLiveResourcesAsync(UnTagLiveResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UnTagLiveResourcesWithOptionsAsync(request, runtime);
        }

        public UpdateBoardResponse UpdateBoardWithOptions(UpdateBoardRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateBoardResponse>(DoRPCRequest("UpdateBoard", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpdateBoardResponse> UpdateBoardWithOptionsAsync(UpdateBoardRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateBoardResponse>(await DoRPCRequestAsync("UpdateBoard", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UpdateBoardResponse UpdateBoard(UpdateBoardRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateBoardWithOptions(request, runtime);
        }

        public async Task<UpdateBoardResponse> UpdateBoardAsync(UpdateBoardRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateBoardWithOptionsAsync(request, runtime);
        }

        public UpdateBoardCallbackResponse UpdateBoardCallbackWithOptions(UpdateBoardCallbackRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateBoardCallbackResponse>(DoRPCRequest("UpdateBoardCallback", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpdateBoardCallbackResponse> UpdateBoardCallbackWithOptionsAsync(UpdateBoardCallbackRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateBoardCallbackResponse>(await DoRPCRequestAsync("UpdateBoardCallback", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UpdateBoardCallbackResponse UpdateBoardCallback(UpdateBoardCallbackRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateBoardCallbackWithOptions(request, runtime);
        }

        public async Task<UpdateBoardCallbackResponse> UpdateBoardCallbackAsync(UpdateBoardCallbackRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateBoardCallbackWithOptionsAsync(request, runtime);
        }

        public UpdateCasterSceneAudioResponse UpdateCasterSceneAudioWithOptions(UpdateCasterSceneAudioRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateCasterSceneAudioResponse>(DoRPCRequest("UpdateCasterSceneAudio", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpdateCasterSceneAudioResponse> UpdateCasterSceneAudioWithOptionsAsync(UpdateCasterSceneAudioRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateCasterSceneAudioResponse>(await DoRPCRequestAsync("UpdateCasterSceneAudio", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UpdateCasterSceneAudioResponse UpdateCasterSceneAudio(UpdateCasterSceneAudioRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateCasterSceneAudioWithOptions(request, runtime);
        }

        public async Task<UpdateCasterSceneAudioResponse> UpdateCasterSceneAudioAsync(UpdateCasterSceneAudioRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateCasterSceneAudioWithOptionsAsync(request, runtime);
        }

        public UpdateCasterSceneConfigResponse UpdateCasterSceneConfigWithOptions(UpdateCasterSceneConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateCasterSceneConfigResponse>(DoRPCRequest("UpdateCasterSceneConfig", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpdateCasterSceneConfigResponse> UpdateCasterSceneConfigWithOptionsAsync(UpdateCasterSceneConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateCasterSceneConfigResponse>(await DoRPCRequestAsync("UpdateCasterSceneConfig", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UpdateCasterSceneConfigResponse UpdateCasterSceneConfig(UpdateCasterSceneConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateCasterSceneConfigWithOptions(request, runtime);
        }

        public async Task<UpdateCasterSceneConfigResponse> UpdateCasterSceneConfigAsync(UpdateCasterSceneConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateCasterSceneConfigWithOptionsAsync(request, runtime);
        }

        public UpdateLiveAppSnapshotConfigResponse UpdateLiveAppSnapshotConfigWithOptions(UpdateLiveAppSnapshotConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateLiveAppSnapshotConfigResponse>(DoRPCRequest("UpdateLiveAppSnapshotConfig", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpdateLiveAppSnapshotConfigResponse> UpdateLiveAppSnapshotConfigWithOptionsAsync(UpdateLiveAppSnapshotConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateLiveAppSnapshotConfigResponse>(await DoRPCRequestAsync("UpdateLiveAppSnapshotConfig", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UpdateLiveAppSnapshotConfigResponse UpdateLiveAppSnapshotConfig(UpdateLiveAppSnapshotConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateLiveAppSnapshotConfigWithOptions(request, runtime);
        }

        public async Task<UpdateLiveAppSnapshotConfigResponse> UpdateLiveAppSnapshotConfigAsync(UpdateLiveAppSnapshotConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateLiveAppSnapshotConfigWithOptionsAsync(request, runtime);
        }

        public UpdateLiveASRConfigResponse UpdateLiveASRConfigWithOptions(UpdateLiveASRConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateLiveASRConfigResponse>(DoRPCRequest("UpdateLiveASRConfig", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpdateLiveASRConfigResponse> UpdateLiveASRConfigWithOptionsAsync(UpdateLiveASRConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateLiveASRConfigResponse>(await DoRPCRequestAsync("UpdateLiveASRConfig", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UpdateLiveASRConfigResponse UpdateLiveASRConfig(UpdateLiveASRConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateLiveASRConfigWithOptions(request, runtime);
        }

        public async Task<UpdateLiveASRConfigResponse> UpdateLiveASRConfigAsync(UpdateLiveASRConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateLiveASRConfigWithOptionsAsync(request, runtime);
        }

        public UpdateLiveAudioAuditConfigResponse UpdateLiveAudioAuditConfigWithOptions(UpdateLiveAudioAuditConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateLiveAudioAuditConfigResponse>(DoRPCRequest("UpdateLiveAudioAuditConfig", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpdateLiveAudioAuditConfigResponse> UpdateLiveAudioAuditConfigWithOptionsAsync(UpdateLiveAudioAuditConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateLiveAudioAuditConfigResponse>(await DoRPCRequestAsync("UpdateLiveAudioAuditConfig", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UpdateLiveAudioAuditConfigResponse UpdateLiveAudioAuditConfig(UpdateLiveAudioAuditConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateLiveAudioAuditConfigWithOptions(request, runtime);
        }

        public async Task<UpdateLiveAudioAuditConfigResponse> UpdateLiveAudioAuditConfigAsync(UpdateLiveAudioAuditConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateLiveAudioAuditConfigWithOptionsAsync(request, runtime);
        }

        public UpdateLiveAudioAuditNotifyConfigResponse UpdateLiveAudioAuditNotifyConfigWithOptions(UpdateLiveAudioAuditNotifyConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateLiveAudioAuditNotifyConfigResponse>(DoRPCRequest("UpdateLiveAudioAuditNotifyConfig", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpdateLiveAudioAuditNotifyConfigResponse> UpdateLiveAudioAuditNotifyConfigWithOptionsAsync(UpdateLiveAudioAuditNotifyConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateLiveAudioAuditNotifyConfigResponse>(await DoRPCRequestAsync("UpdateLiveAudioAuditNotifyConfig", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UpdateLiveAudioAuditNotifyConfigResponse UpdateLiveAudioAuditNotifyConfig(UpdateLiveAudioAuditNotifyConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateLiveAudioAuditNotifyConfigWithOptions(request, runtime);
        }

        public async Task<UpdateLiveAudioAuditNotifyConfigResponse> UpdateLiveAudioAuditNotifyConfigAsync(UpdateLiveAudioAuditNotifyConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateLiveAudioAuditNotifyConfigWithOptionsAsync(request, runtime);
        }

        public UpdateLiveDetectNotifyConfigResponse UpdateLiveDetectNotifyConfigWithOptions(UpdateLiveDetectNotifyConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateLiveDetectNotifyConfigResponse>(DoRPCRequest("UpdateLiveDetectNotifyConfig", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpdateLiveDetectNotifyConfigResponse> UpdateLiveDetectNotifyConfigWithOptionsAsync(UpdateLiveDetectNotifyConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateLiveDetectNotifyConfigResponse>(await DoRPCRequestAsync("UpdateLiveDetectNotifyConfig", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UpdateLiveDetectNotifyConfigResponse UpdateLiveDetectNotifyConfig(UpdateLiveDetectNotifyConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateLiveDetectNotifyConfigWithOptions(request, runtime);
        }

        public async Task<UpdateLiveDetectNotifyConfigResponse> UpdateLiveDetectNotifyConfigAsync(UpdateLiveDetectNotifyConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateLiveDetectNotifyConfigWithOptionsAsync(request, runtime);
        }

        public UpdateLiveRecordNotifyConfigResponse UpdateLiveRecordNotifyConfigWithOptions(UpdateLiveRecordNotifyConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateLiveRecordNotifyConfigResponse>(DoRPCRequest("UpdateLiveRecordNotifyConfig", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpdateLiveRecordNotifyConfigResponse> UpdateLiveRecordNotifyConfigWithOptionsAsync(UpdateLiveRecordNotifyConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateLiveRecordNotifyConfigResponse>(await DoRPCRequestAsync("UpdateLiveRecordNotifyConfig", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UpdateLiveRecordNotifyConfigResponse UpdateLiveRecordNotifyConfig(UpdateLiveRecordNotifyConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateLiveRecordNotifyConfigWithOptions(request, runtime);
        }

        public async Task<UpdateLiveRecordNotifyConfigResponse> UpdateLiveRecordNotifyConfigAsync(UpdateLiveRecordNotifyConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateLiveRecordNotifyConfigWithOptionsAsync(request, runtime);
        }

        public UpdateLiveSnapshotDetectPornConfigResponse UpdateLiveSnapshotDetectPornConfigWithOptions(UpdateLiveSnapshotDetectPornConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateLiveSnapshotDetectPornConfigResponse>(DoRPCRequest("UpdateLiveSnapshotDetectPornConfig", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpdateLiveSnapshotDetectPornConfigResponse> UpdateLiveSnapshotDetectPornConfigWithOptionsAsync(UpdateLiveSnapshotDetectPornConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateLiveSnapshotDetectPornConfigResponse>(await DoRPCRequestAsync("UpdateLiveSnapshotDetectPornConfig", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UpdateLiveSnapshotDetectPornConfigResponse UpdateLiveSnapshotDetectPornConfig(UpdateLiveSnapshotDetectPornConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateLiveSnapshotDetectPornConfigWithOptions(request, runtime);
        }

        public async Task<UpdateLiveSnapshotDetectPornConfigResponse> UpdateLiveSnapshotDetectPornConfigAsync(UpdateLiveSnapshotDetectPornConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateLiveSnapshotDetectPornConfigWithOptionsAsync(request, runtime);
        }

        public UpdateLiveTopLevelDomainResponse UpdateLiveTopLevelDomainWithOptions(UpdateLiveTopLevelDomainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateLiveTopLevelDomainResponse>(DoRPCRequest("UpdateLiveTopLevelDomain", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpdateLiveTopLevelDomainResponse> UpdateLiveTopLevelDomainWithOptionsAsync(UpdateLiveTopLevelDomainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateLiveTopLevelDomainResponse>(await DoRPCRequestAsync("UpdateLiveTopLevelDomain", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UpdateLiveTopLevelDomainResponse UpdateLiveTopLevelDomain(UpdateLiveTopLevelDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateLiveTopLevelDomainWithOptions(request, runtime);
        }

        public async Task<UpdateLiveTopLevelDomainResponse> UpdateLiveTopLevelDomainAsync(UpdateLiveTopLevelDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateLiveTopLevelDomainWithOptionsAsync(request, runtime);
        }

        public UpdateMixStreamResponse UpdateMixStreamWithOptions(UpdateMixStreamRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateMixStreamResponse>(DoRPCRequest("UpdateMixStream", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpdateMixStreamResponse> UpdateMixStreamWithOptionsAsync(UpdateMixStreamRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateMixStreamResponse>(await DoRPCRequestAsync("UpdateMixStream", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UpdateMixStreamResponse UpdateMixStream(UpdateMixStreamRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateMixStreamWithOptions(request, runtime);
        }

        public async Task<UpdateMixStreamResponse> UpdateMixStreamAsync(UpdateMixStreamRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateMixStreamWithOptionsAsync(request, runtime);
        }

        public VerifyLiveDomainOwnerResponse VerifyLiveDomainOwnerWithOptions(VerifyLiveDomainOwnerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<VerifyLiveDomainOwnerResponse>(DoRPCRequest("VerifyLiveDomainOwner", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<VerifyLiveDomainOwnerResponse> VerifyLiveDomainOwnerWithOptionsAsync(VerifyLiveDomainOwnerRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<VerifyLiveDomainOwnerResponse>(await DoRPCRequestAsync("VerifyLiveDomainOwner", "2016-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public VerifyLiveDomainOwnerResponse VerifyLiveDomainOwner(VerifyLiveDomainOwnerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return VerifyLiveDomainOwnerWithOptions(request, runtime);
        }

        public async Task<VerifyLiveDomainOwnerResponse> VerifyLiveDomainOwnerAsync(VerifyLiveDomainOwnerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await VerifyLiveDomainOwnerWithOptionsAsync(request, runtime);
        }

    }
}
