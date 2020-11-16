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
    public class Client : AlibabaCloud.RPCClient.Client
    {

        public Client(AlibabaCloud.RPCClient.Models.Config config): base(config)
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


        public AddLiveASRConfigResponse AddLiveASRConfigWithOptions(AddLiveASRConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<AddLiveASRConfigResponse>(DoRequest("AddLiveASRConfig", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
        }

        public async Task<AddLiveASRConfigResponse> AddLiveASRConfigWithOptionsAsync(AddLiveASRConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<AddLiveASRConfigResponse>(await DoRequestAsync("AddLiveASRConfig", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
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

        public DescribeLiveAsrConfigResponse DescribeLiveAsrConfigWithOptions(DescribeLiveAsrConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeLiveAsrConfigResponse>(DoRequest("DescribeLiveAsrConfig", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DescribeLiveAsrConfigResponse> DescribeLiveAsrConfigWithOptionsAsync(DescribeLiveAsrConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeLiveAsrConfigResponse>(await DoRequestAsync("DescribeLiveAsrConfig", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
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

        public DeleteLiveASRConfigResponse DeleteLiveASRConfigWithOptions(DeleteLiveASRConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DeleteLiveASRConfigResponse>(DoRequest("DeleteLiveASRConfig", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DeleteLiveASRConfigResponse> DeleteLiveASRConfigWithOptionsAsync(DeleteLiveASRConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DeleteLiveASRConfigResponse>(await DoRequestAsync("DeleteLiveASRConfig", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
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

        public UpdateLiveASRConfigResponse UpdateLiveASRConfigWithOptions(UpdateLiveASRConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<UpdateLiveASRConfigResponse>(DoRequest("UpdateLiveASRConfig", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
        }

        public async Task<UpdateLiveASRConfigResponse> UpdateLiveASRConfigWithOptionsAsync(UpdateLiveASRConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<UpdateLiveASRConfigResponse>(await DoRequestAsync("UpdateLiveASRConfig", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
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

        public DeleteMixStreamResponse DeleteMixStreamWithOptions(DeleteMixStreamRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DeleteMixStreamResponse>(DoRequest("DeleteMixStream", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DeleteMixStreamResponse> DeleteMixStreamWithOptionsAsync(DeleteMixStreamRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DeleteMixStreamResponse>(await DoRequestAsync("DeleteMixStream", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
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

        public UpdateMixStreamResponse UpdateMixStreamWithOptions(UpdateMixStreamRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<UpdateMixStreamResponse>(DoRequest("UpdateMixStream", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
        }

        public async Task<UpdateMixStreamResponse> UpdateMixStreamWithOptionsAsync(UpdateMixStreamRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<UpdateMixStreamResponse>(await DoRequestAsync("UpdateMixStream", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
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

        public CreateMixStreamResponse CreateMixStreamWithOptions(CreateMixStreamRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CreateMixStreamResponse>(DoRequest("CreateMixStream", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
        }

        public async Task<CreateMixStreamResponse> CreateMixStreamWithOptionsAsync(CreateMixStreamRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CreateMixStreamResponse>(await DoRequestAsync("CreateMixStream", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
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

        public DescribeMixStreamListResponse DescribeMixStreamListWithOptions(DescribeMixStreamListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeMixStreamListResponse>(DoRequest("DescribeMixStreamList", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DescribeMixStreamListResponse> DescribeMixStreamListWithOptionsAsync(DescribeMixStreamListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeMixStreamListResponse>(await DoRequestAsync("DescribeMixStreamList", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
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

        public AddRtsLiveStreamTranscodeResponse AddRtsLiveStreamTranscodeWithOptions(AddRtsLiveStreamTranscodeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<AddRtsLiveStreamTranscodeResponse>(DoRequest("AddRtsLiveStreamTranscode", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
        }

        public async Task<AddRtsLiveStreamTranscodeResponse> AddRtsLiveStreamTranscodeWithOptionsAsync(AddRtsLiveStreamTranscodeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<AddRtsLiveStreamTranscodeResponse>(await DoRequestAsync("AddRtsLiveStreamTranscode", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
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

        public DescribeLiveDomainTimeShiftDataResponse DescribeLiveDomainTimeShiftDataWithOptions(DescribeLiveDomainTimeShiftDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeLiveDomainTimeShiftDataResponse>(DoRequest("DescribeLiveDomainTimeShiftData", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DescribeLiveDomainTimeShiftDataResponse> DescribeLiveDomainTimeShiftDataWithOptionsAsync(DescribeLiveDomainTimeShiftDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeLiveDomainTimeShiftDataResponse>(await DoRequestAsync("DescribeLiveDomainTimeShiftData", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
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

        public DeleteHtmlResourceResponse DeleteHtmlResourceWithOptions(DeleteHtmlResourceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DeleteHtmlResourceResponse>(DoRequest("DeleteHtmlResource", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DeleteHtmlResourceResponse> DeleteHtmlResourceWithOptionsAsync(DeleteHtmlResourceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DeleteHtmlResourceResponse>(await DoRequestAsync("DeleteHtmlResource", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
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

        public DescribeHtmlResourceResponse DescribeHtmlResourceWithOptions(DescribeHtmlResourceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeHtmlResourceResponse>(DoRequest("DescribeHtmlResource", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DescribeHtmlResourceResponse> DescribeHtmlResourceWithOptionsAsync(DescribeHtmlResourceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeHtmlResourceResponse>(await DoRequestAsync("DescribeHtmlResource", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
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

        public ControlHtmlResourceResponse ControlHtmlResourceWithOptions(ControlHtmlResourceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ControlHtmlResourceResponse>(DoRequest("ControlHtmlResource", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
        }

        public async Task<ControlHtmlResourceResponse> ControlHtmlResourceWithOptionsAsync(ControlHtmlResourceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ControlHtmlResourceResponse>(await DoRequestAsync("ControlHtmlResource", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
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

        public EditHtmlResourceResponse EditHtmlResourceWithOptions(EditHtmlResourceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<EditHtmlResourceResponse>(DoRequest("EditHtmlResource", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
        }

        public async Task<EditHtmlResourceResponse> EditHtmlResourceWithOptionsAsync(EditHtmlResourceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<EditHtmlResourceResponse>(await DoRequestAsync("EditHtmlResource", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
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

        public DescribeLiveUserTagsResponse DescribeLiveUserTagsWithOptions(DescribeLiveUserTagsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeLiveUserTagsResponse>(DoRequest("DescribeLiveUserTags", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DescribeLiveUserTagsResponse> DescribeLiveUserTagsWithOptionsAsync(DescribeLiveUserTagsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeLiveUserTagsResponse>(await DoRequestAsync("DescribeLiveUserTags", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
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

        public UnTagLiveResourcesResponse UnTagLiveResourcesWithOptions(UnTagLiveResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<UnTagLiveResourcesResponse>(DoRequest("UnTagLiveResources", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
        }

        public async Task<UnTagLiveResourcesResponse> UnTagLiveResourcesWithOptionsAsync(UnTagLiveResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<UnTagLiveResourcesResponse>(await DoRequestAsync("UnTagLiveResources", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
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

        public TagLiveResourcesResponse TagLiveResourcesWithOptions(TagLiveResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<TagLiveResourcesResponse>(DoRequest("TagLiveResources", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
        }

        public async Task<TagLiveResourcesResponse> TagLiveResourcesWithOptionsAsync(TagLiveResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<TagLiveResourcesResponse>(await DoRequestAsync("TagLiveResources", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
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

        public DescribeLiveTagResourcesResponse DescribeLiveTagResourcesWithOptions(DescribeLiveTagResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeLiveTagResourcesResponse>(DoRequest("DescribeLiveTagResources", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DescribeLiveTagResourcesResponse> DescribeLiveTagResourcesWithOptionsAsync(DescribeLiveTagResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeLiveTagResourcesResponse>(await DoRequestAsync("DescribeLiveTagResources", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
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

        public AddLiveAudioAuditConfigResponse AddLiveAudioAuditConfigWithOptions(AddLiveAudioAuditConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<AddLiveAudioAuditConfigResponse>(DoRequest("AddLiveAudioAuditConfig", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
        }

        public async Task<AddLiveAudioAuditConfigResponse> AddLiveAudioAuditConfigWithOptionsAsync(AddLiveAudioAuditConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<AddLiveAudioAuditConfigResponse>(await DoRequestAsync("AddLiveAudioAuditConfig", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
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

        public DeleteLiveAudioAuditConfigResponse DeleteLiveAudioAuditConfigWithOptions(DeleteLiveAudioAuditConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DeleteLiveAudioAuditConfigResponse>(DoRequest("DeleteLiveAudioAuditConfig", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DeleteLiveAudioAuditConfigResponse> DeleteLiveAudioAuditConfigWithOptionsAsync(DeleteLiveAudioAuditConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DeleteLiveAudioAuditConfigResponse>(await DoRequestAsync("DeleteLiveAudioAuditConfig", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
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

        public DescribeLiveAudioAuditConfigResponse DescribeLiveAudioAuditConfigWithOptions(DescribeLiveAudioAuditConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeLiveAudioAuditConfigResponse>(DoRequest("DescribeLiveAudioAuditConfig", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DescribeLiveAudioAuditConfigResponse> DescribeLiveAudioAuditConfigWithOptionsAsync(DescribeLiveAudioAuditConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeLiveAudioAuditConfigResponse>(await DoRequestAsync("DescribeLiveAudioAuditConfig", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
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

        public UpdateLiveAudioAuditConfigResponse UpdateLiveAudioAuditConfigWithOptions(UpdateLiveAudioAuditConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<UpdateLiveAudioAuditConfigResponse>(DoRequest("UpdateLiveAudioAuditConfig", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
        }

        public async Task<UpdateLiveAudioAuditConfigResponse> UpdateLiveAudioAuditConfigWithOptionsAsync(UpdateLiveAudioAuditConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<UpdateLiveAudioAuditConfigResponse>(await DoRequestAsync("UpdateLiveAudioAuditConfig", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
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

        public AddLiveAudioAuditNotifyConfigResponse AddLiveAudioAuditNotifyConfigWithOptions(AddLiveAudioAuditNotifyConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<AddLiveAudioAuditNotifyConfigResponse>(DoRequest("AddLiveAudioAuditNotifyConfig", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
        }

        public async Task<AddLiveAudioAuditNotifyConfigResponse> AddLiveAudioAuditNotifyConfigWithOptionsAsync(AddLiveAudioAuditNotifyConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<AddLiveAudioAuditNotifyConfigResponse>(await DoRequestAsync("AddLiveAudioAuditNotifyConfig", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
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

        public DeleteLiveAudioAuditNotifyConfigResponse DeleteLiveAudioAuditNotifyConfigWithOptions(DeleteLiveAudioAuditNotifyConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DeleteLiveAudioAuditNotifyConfigResponse>(DoRequest("DeleteLiveAudioAuditNotifyConfig", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DeleteLiveAudioAuditNotifyConfigResponse> DeleteLiveAudioAuditNotifyConfigWithOptionsAsync(DeleteLiveAudioAuditNotifyConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DeleteLiveAudioAuditNotifyConfigResponse>(await DoRequestAsync("DeleteLiveAudioAuditNotifyConfig", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
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

        public DescribeLiveAudioAuditNotifyConfigResponse DescribeLiveAudioAuditNotifyConfigWithOptions(DescribeLiveAudioAuditNotifyConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeLiveAudioAuditNotifyConfigResponse>(DoRequest("DescribeLiveAudioAuditNotifyConfig", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DescribeLiveAudioAuditNotifyConfigResponse> DescribeLiveAudioAuditNotifyConfigWithOptionsAsync(DescribeLiveAudioAuditNotifyConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeLiveAudioAuditNotifyConfigResponse>(await DoRequestAsync("DescribeLiveAudioAuditNotifyConfig", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
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

        public UpdateLiveAudioAuditNotifyConfigResponse UpdateLiveAudioAuditNotifyConfigWithOptions(UpdateLiveAudioAuditNotifyConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<UpdateLiveAudioAuditNotifyConfigResponse>(DoRequest("UpdateLiveAudioAuditNotifyConfig", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
        }

        public async Task<UpdateLiveAudioAuditNotifyConfigResponse> UpdateLiveAudioAuditNotifyConfigWithOptionsAsync(UpdateLiveAudioAuditNotifyConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<UpdateLiveAudioAuditNotifyConfigResponse>(await DoRequestAsync("UpdateLiveAudioAuditNotifyConfig", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
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

        public DescribeLiveDomainPushTrafficDataResponse DescribeLiveDomainPushTrafficDataWithOptions(DescribeLiveDomainPushTrafficDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeLiveDomainPushTrafficDataResponse>(DoRequest("DescribeLiveDomainPushTrafficData", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DescribeLiveDomainPushTrafficDataResponse> DescribeLiveDomainPushTrafficDataWithOptionsAsync(DescribeLiveDomainPushTrafficDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeLiveDomainPushTrafficDataResponse>(await DoRequestAsync("DescribeLiveDomainPushTrafficData", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
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

        public DescribeLiveDomainPushBpsDataResponse DescribeLiveDomainPushBpsDataWithOptions(DescribeLiveDomainPushBpsDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeLiveDomainPushBpsDataResponse>(DoRequest("DescribeLiveDomainPushBpsData", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DescribeLiveDomainPushBpsDataResponse> DescribeLiveDomainPushBpsDataWithOptionsAsync(DescribeLiveDomainPushBpsDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeLiveDomainPushBpsDataResponse>(await DoRequestAsync("DescribeLiveDomainPushBpsData", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
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

        public SetCasterSyncGroupResponse SetCasterSyncGroupWithOptions(SetCasterSyncGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<SetCasterSyncGroupResponse>(DoRequest("SetCasterSyncGroup", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
        }

        public async Task<SetCasterSyncGroupResponse> SetCasterSyncGroupWithOptionsAsync(SetCasterSyncGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<SetCasterSyncGroupResponse>(await DoRequestAsync("SetCasterSyncGroup", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
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

        public DescribeCasterSyncGroupResponse DescribeCasterSyncGroupWithOptions(DescribeCasterSyncGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeCasterSyncGroupResponse>(DoRequest("DescribeCasterSyncGroup", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DescribeCasterSyncGroupResponse> DescribeCasterSyncGroupWithOptionsAsync(DescribeCasterSyncGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeCasterSyncGroupResponse>(await DoRequestAsync("DescribeCasterSyncGroup", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
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

        public DescribeLiveDetectPornDataResponse DescribeLiveDetectPornDataWithOptions(DescribeLiveDetectPornDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeLiveDetectPornDataResponse>(DoRequest("DescribeLiveDetectPornData", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DescribeLiveDetectPornDataResponse> DescribeLiveDetectPornDataWithOptionsAsync(DescribeLiveDetectPornDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeLiveDetectPornDataResponse>(await DoRequestAsync("DescribeLiveDetectPornData", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
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

        public DeleteLiveRealTimeLogLogstoreResponse DeleteLiveRealTimeLogLogstoreWithOptions(DeleteLiveRealTimeLogLogstoreRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DeleteLiveRealTimeLogLogstoreResponse>(DoRequest("DeleteLiveRealTimeLogLogstore", "HTTPS", "GET", "2016-11-01", "AK", request.ToMap(), null, runtime));
        }

        public async Task<DeleteLiveRealTimeLogLogstoreResponse> DeleteLiveRealTimeLogLogstoreWithOptionsAsync(DeleteLiveRealTimeLogLogstoreRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DeleteLiveRealTimeLogLogstoreResponse>(await DoRequestAsync("DeleteLiveRealTimeLogLogstore", "HTTPS", "GET", "2016-11-01", "AK", request.ToMap(), null, runtime));
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

        public DisableLiveRealtimeLogDeliveryResponse DisableLiveRealtimeLogDeliveryWithOptions(DisableLiveRealtimeLogDeliveryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DisableLiveRealtimeLogDeliveryResponse>(DoRequest("DisableLiveRealtimeLogDelivery", "HTTPS", "GET", "2016-11-01", "AK", request.ToMap(), null, runtime));
        }

        public async Task<DisableLiveRealtimeLogDeliveryResponse> DisableLiveRealtimeLogDeliveryWithOptionsAsync(DisableLiveRealtimeLogDeliveryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DisableLiveRealtimeLogDeliveryResponse>(await DoRequestAsync("DisableLiveRealtimeLogDelivery", "HTTPS", "GET", "2016-11-01", "AK", request.ToMap(), null, runtime));
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

        public EnableLiveRealtimeLogDeliveryResponse EnableLiveRealtimeLogDeliveryWithOptions(EnableLiveRealtimeLogDeliveryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<EnableLiveRealtimeLogDeliveryResponse>(DoRequest("EnableLiveRealtimeLogDelivery", "HTTPS", "GET", "2016-11-01", "AK", request.ToMap(), null, runtime));
        }

        public async Task<EnableLiveRealtimeLogDeliveryResponse> EnableLiveRealtimeLogDeliveryWithOptionsAsync(EnableLiveRealtimeLogDeliveryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<EnableLiveRealtimeLogDeliveryResponse>(await DoRequestAsync("EnableLiveRealtimeLogDelivery", "HTTPS", "GET", "2016-11-01", "AK", request.ToMap(), null, runtime));
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

        public ListLiveRealtimeLogDeliveryDomainsResponse ListLiveRealtimeLogDeliveryDomainsWithOptions(ListLiveRealtimeLogDeliveryDomainsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ListLiveRealtimeLogDeliveryDomainsResponse>(DoRequest("ListLiveRealtimeLogDeliveryDomains", "HTTPS", "GET", "2016-11-01", "AK", request.ToMap(), null, runtime));
        }

        public async Task<ListLiveRealtimeLogDeliveryDomainsResponse> ListLiveRealtimeLogDeliveryDomainsWithOptionsAsync(ListLiveRealtimeLogDeliveryDomainsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ListLiveRealtimeLogDeliveryDomainsResponse>(await DoRequestAsync("ListLiveRealtimeLogDeliveryDomains", "HTTPS", "GET", "2016-11-01", "AK", request.ToMap(), null, runtime));
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

        public ModifyLiveRealtimeLogDeliveryResponse ModifyLiveRealtimeLogDeliveryWithOptions(ModifyLiveRealtimeLogDeliveryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ModifyLiveRealtimeLogDeliveryResponse>(DoRequest("ModifyLiveRealtimeLogDelivery", "HTTPS", "GET", "2016-11-01", "AK", request.ToMap(), null, runtime));
        }

        public async Task<ModifyLiveRealtimeLogDeliveryResponse> ModifyLiveRealtimeLogDeliveryWithOptionsAsync(ModifyLiveRealtimeLogDeliveryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ModifyLiveRealtimeLogDeliveryResponse>(await DoRequestAsync("ModifyLiveRealtimeLogDelivery", "HTTPS", "GET", "2016-11-01", "AK", request.ToMap(), null, runtime));
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

        public DescribeLiveRealtimeDeliveryAccResponse DescribeLiveRealtimeDeliveryAccWithOptions(DescribeLiveRealtimeDeliveryAccRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeLiveRealtimeDeliveryAccResponse>(DoRequest("DescribeLiveRealtimeDeliveryAcc", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DescribeLiveRealtimeDeliveryAccResponse> DescribeLiveRealtimeDeliveryAccWithOptionsAsync(DescribeLiveRealtimeDeliveryAccRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeLiveRealtimeDeliveryAccResponse>(await DoRequestAsync("DescribeLiveRealtimeDeliveryAcc", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
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
            return TeaModel.ToObject<DescribeLiveRealtimeLogAuthorizedResponse>(DoRequest("DescribeLiveRealtimeLogAuthorized", "HTTPS", "GET", "2016-11-01", "AK", request.ToMap(), null, runtime));
        }

        public async Task<DescribeLiveRealtimeLogAuthorizedResponse> DescribeLiveRealtimeLogAuthorizedWithOptionsAsync(DescribeLiveRealtimeLogAuthorizedRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeLiveRealtimeLogAuthorizedResponse>(await DoRequestAsync("DescribeLiveRealtimeLogAuthorized", "HTTPS", "GET", "2016-11-01", "AK", request.ToMap(), null, runtime));
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

        public ListLiveRealtimeLogDeliveryResponse ListLiveRealtimeLogDeliveryWithOptions(ListLiveRealtimeLogDeliveryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ListLiveRealtimeLogDeliveryResponse>(DoRequest("ListLiveRealtimeLogDelivery", "HTTPS", "GET", "2016-11-01", "AK", request.ToMap(), null, runtime));
        }

        public async Task<ListLiveRealtimeLogDeliveryResponse> ListLiveRealtimeLogDeliveryWithOptionsAsync(ListLiveRealtimeLogDeliveryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ListLiveRealtimeLogDeliveryResponse>(await DoRequestAsync("ListLiveRealtimeLogDelivery", "HTTPS", "GET", "2016-11-01", "AK", request.ToMap(), null, runtime));
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

        public ListLiveRealtimeLogDeliveryInfosResponse ListLiveRealtimeLogDeliveryInfosWithOptions(ListLiveRealtimeLogDeliveryInfosRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ListLiveRealtimeLogDeliveryInfosResponse>(DoRequest("ListLiveRealtimeLogDeliveryInfos", "HTTPS", "GET", "2016-11-01", "AK", request.ToMap(), null, runtime));
        }

        public async Task<ListLiveRealtimeLogDeliveryInfosResponse> ListLiveRealtimeLogDeliveryInfosWithOptionsAsync(ListLiveRealtimeLogDeliveryInfosRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ListLiveRealtimeLogDeliveryInfosResponse>(await DoRequestAsync("ListLiveRealtimeLogDeliveryInfos", "HTTPS", "GET", "2016-11-01", "AK", request.ToMap(), null, runtime));
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

        public DescribeLiveDomainRealtimeLogDeliveryResponse DescribeLiveDomainRealtimeLogDeliveryWithOptions(DescribeLiveDomainRealtimeLogDeliveryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeLiveDomainRealtimeLogDeliveryResponse>(DoRequest("DescribeLiveDomainRealtimeLogDelivery", "HTTPS", "GET", "2016-11-01", "AK", request.ToMap(), null, runtime));
        }

        public async Task<DescribeLiveDomainRealtimeLogDeliveryResponse> DescribeLiveDomainRealtimeLogDeliveryWithOptionsAsync(DescribeLiveDomainRealtimeLogDeliveryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeLiveDomainRealtimeLogDeliveryResponse>(await DoRequestAsync("DescribeLiveDomainRealtimeLogDelivery", "HTTPS", "GET", "2016-11-01", "AK", request.ToMap(), null, runtime));
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

        public DeleteLiveRealtimeLogDeliveryResponse DeleteLiveRealtimeLogDeliveryWithOptions(DeleteLiveRealtimeLogDeliveryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DeleteLiveRealtimeLogDeliveryResponse>(DoRequest("DeleteLiveRealtimeLogDelivery", "HTTPS", "GET", "2016-11-01", "AK", request.ToMap(), null, runtime));
        }

        public async Task<DeleteLiveRealtimeLogDeliveryResponse> DeleteLiveRealtimeLogDeliveryWithOptionsAsync(DeleteLiveRealtimeLogDeliveryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DeleteLiveRealtimeLogDeliveryResponse>(await DoRequestAsync("DeleteLiveRealtimeLogDelivery", "HTTPS", "GET", "2016-11-01", "AK", request.ToMap(), null, runtime));
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

        public CreateLiveRealTimeLogDeliveryResponse CreateLiveRealTimeLogDeliveryWithOptions(CreateLiveRealTimeLogDeliveryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CreateLiveRealTimeLogDeliveryResponse>(DoRequest("CreateLiveRealTimeLogDelivery", "HTTPS", "GET", "2016-11-01", "AK", request.ToMap(), null, runtime));
        }

        public async Task<CreateLiveRealTimeLogDeliveryResponse> CreateLiveRealTimeLogDeliveryWithOptionsAsync(CreateLiveRealTimeLogDeliveryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CreateLiveRealTimeLogDeliveryResponse>(await DoRequestAsync("CreateLiveRealTimeLogDelivery", "HTTPS", "GET", "2016-11-01", "AK", request.ToMap(), null, runtime));
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

        public DescribeLiveDomainLimitResponse DescribeLiveDomainLimitWithOptions(DescribeLiveDomainLimitRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeLiveDomainLimitResponse>(DoRequest("DescribeLiveDomainLimit", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DescribeLiveDomainLimitResponse> DescribeLiveDomainLimitWithOptionsAsync(DescribeLiveDomainLimitRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeLiveDomainLimitResponse>(await DoRequestAsync("DescribeLiveDomainLimit", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
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

        public DescribeLiveDomainBpsDataByTimeStampResponse DescribeLiveDomainBpsDataByTimeStampWithOptions(DescribeLiveDomainBpsDataByTimeStampRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeLiveDomainBpsDataByTimeStampResponse>(DoRequest("DescribeLiveDomainBpsDataByTimeStamp", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DescribeLiveDomainBpsDataByTimeStampResponse> DescribeLiveDomainBpsDataByTimeStampWithOptionsAsync(DescribeLiveDomainBpsDataByTimeStampRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeLiveDomainBpsDataByTimeStampResponse>(await DoRequestAsync("DescribeLiveDomainBpsDataByTimeStamp", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
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

        public DescribeLiveStreamTranscodeStreamNumResponse DescribeLiveStreamTranscodeStreamNumWithOptions(DescribeLiveStreamTranscodeStreamNumRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeLiveStreamTranscodeStreamNumResponse>(DoRequest("DescribeLiveStreamTranscodeStreamNum", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DescribeLiveStreamTranscodeStreamNumResponse> DescribeLiveStreamTranscodeStreamNumWithOptionsAsync(DescribeLiveStreamTranscodeStreamNumRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeLiveStreamTranscodeStreamNumResponse>(await DoRequestAsync("DescribeLiveStreamTranscodeStreamNum", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
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

        public UpdateLiveTopLevelDomainResponse UpdateLiveTopLevelDomainWithOptions(UpdateLiveTopLevelDomainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<UpdateLiveTopLevelDomainResponse>(DoRequest("UpdateLiveTopLevelDomain", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
        }

        public async Task<UpdateLiveTopLevelDomainResponse> UpdateLiveTopLevelDomainWithOptionsAsync(UpdateLiveTopLevelDomainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<UpdateLiveTopLevelDomainResponse>(await DoRequestAsync("UpdateLiveTopLevelDomain", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
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

        public DescribeLiveDomainCertificateInfoResponse DescribeLiveDomainCertificateInfoWithOptions(DescribeLiveDomainCertificateInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeLiveDomainCertificateInfoResponse>(DoRequest("DescribeLiveDomainCertificateInfo", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DescribeLiveDomainCertificateInfoResponse> DescribeLiveDomainCertificateInfoWithOptionsAsync(DescribeLiveDomainCertificateInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeLiveDomainCertificateInfoResponse>(await DoRequestAsync("DescribeLiveDomainCertificateInfo", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
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

        public ModifyLiveDomainSchdmByPropertyResponse ModifyLiveDomainSchdmByPropertyWithOptions(ModifyLiveDomainSchdmByPropertyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ModifyLiveDomainSchdmByPropertyResponse>(DoRequest("ModifyLiveDomainSchdmByProperty", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
        }

        public async Task<ModifyLiveDomainSchdmByPropertyResponse> ModifyLiveDomainSchdmByPropertyWithOptionsAsync(ModifyLiveDomainSchdmByPropertyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ModifyLiveDomainSchdmByPropertyResponse>(await DoRequestAsync("ModifyLiveDomainSchdmByProperty", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
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

        public SetLiveStreamOptimizedFeatureConfigResponse SetLiveStreamOptimizedFeatureConfigWithOptions(SetLiveStreamOptimizedFeatureConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<SetLiveStreamOptimizedFeatureConfigResponse>(DoRequest("SetLiveStreamOptimizedFeatureConfig", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
        }

        public async Task<SetLiveStreamOptimizedFeatureConfigResponse> SetLiveStreamOptimizedFeatureConfigWithOptionsAsync(SetLiveStreamOptimizedFeatureConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<SetLiveStreamOptimizedFeatureConfigResponse>(await DoRequestAsync("SetLiveStreamOptimizedFeatureConfig", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
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

        public DescribeLiveStreamOptimizedFeatureConfigResponse DescribeLiveStreamOptimizedFeatureConfigWithOptions(DescribeLiveStreamOptimizedFeatureConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeLiveStreamOptimizedFeatureConfigResponse>(DoRequest("DescribeLiveStreamOptimizedFeatureConfig", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DescribeLiveStreamOptimizedFeatureConfigResponse> DescribeLiveStreamOptimizedFeatureConfigWithOptionsAsync(DescribeLiveStreamOptimizedFeatureConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeLiveStreamOptimizedFeatureConfigResponse>(await DoRequestAsync("DescribeLiveStreamOptimizedFeatureConfig", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
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

        public SetLiveStreamDelayConfigResponse SetLiveStreamDelayConfigWithOptions(SetLiveStreamDelayConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<SetLiveStreamDelayConfigResponse>(DoRequest("SetLiveStreamDelayConfig", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
        }

        public async Task<SetLiveStreamDelayConfigResponse> SetLiveStreamDelayConfigWithOptionsAsync(SetLiveStreamDelayConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<SetLiveStreamDelayConfigResponse>(await DoRequestAsync("SetLiveStreamDelayConfig", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
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

        public DescribeLiveStreamDelayConfigResponse DescribeLiveStreamDelayConfigWithOptions(DescribeLiveStreamDelayConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeLiveStreamDelayConfigResponse>(DoRequest("DescribeLiveStreamDelayConfig", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DescribeLiveStreamDelayConfigResponse> DescribeLiveStreamDelayConfigWithOptionsAsync(DescribeLiveStreamDelayConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeLiveStreamDelayConfigResponse>(await DoRequestAsync("DescribeLiveStreamDelayConfig", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
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

        public DescribeLiveDomainOnlineUserNumResponse DescribeLiveDomainOnlineUserNumWithOptions(DescribeLiveDomainOnlineUserNumRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeLiveDomainOnlineUserNumResponse>(DoRequest("DescribeLiveDomainOnlineUserNum", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DescribeLiveDomainOnlineUserNumResponse> DescribeLiveDomainOnlineUserNumWithOptionsAsync(DescribeLiveDomainOnlineUserNumRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeLiveDomainOnlineUserNumResponse>(await DoRequestAsync("DescribeLiveDomainOnlineUserNum", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
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

        public DescribeLiveDomainFrameRateAndBitRateDataResponse DescribeLiveDomainFrameRateAndBitRateDataWithOptions(DescribeLiveDomainFrameRateAndBitRateDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeLiveDomainFrameRateAndBitRateDataResponse>(DoRequest("DescribeLiveDomainFrameRateAndBitRateData", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DescribeLiveDomainFrameRateAndBitRateDataResponse> DescribeLiveDomainFrameRateAndBitRateDataWithOptionsAsync(DescribeLiveDomainFrameRateAndBitRateDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeLiveDomainFrameRateAndBitRateDataResponse>(await DoRequestAsync("DescribeLiveDomainFrameRateAndBitRateData", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
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

        public SetBoardCallbackResponse SetBoardCallbackWithOptions(SetBoardCallbackRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<SetBoardCallbackResponse>(DoRequest("SetBoardCallback", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
        }

        public async Task<SetBoardCallbackResponse> SetBoardCallbackWithOptionsAsync(SetBoardCallbackRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<SetBoardCallbackResponse>(await DoRequestAsync("SetBoardCallback", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
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

        public DescribeRecordsResponse DescribeRecordsWithOptions(DescribeRecordsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeRecordsResponse>(DoRequest("DescribeRecords", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DescribeRecordsResponse> DescribeRecordsWithOptionsAsync(DescribeRecordsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeRecordsResponse>(await DoRequestAsync("DescribeRecords", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
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

        public DescribeRecordResponse DescribeRecordWithOptions(DescribeRecordRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeRecordResponse>(DoRequest("DescribeRecord", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DescribeRecordResponse> DescribeRecordWithOptionsAsync(DescribeRecordRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeRecordResponse>(await DoRequestAsync("DescribeRecord", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
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

        public CompleteBoardRecordResponse CompleteBoardRecordWithOptions(CompleteBoardRecordRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CompleteBoardRecordResponse>(DoRequest("CompleteBoardRecord", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
        }

        public async Task<CompleteBoardRecordResponse> CompleteBoardRecordWithOptionsAsync(CompleteBoardRecordRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CompleteBoardRecordResponse>(await DoRequestAsync("CompleteBoardRecord", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
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

        public StartBoardRecordResponse StartBoardRecordWithOptions(StartBoardRecordRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<StartBoardRecordResponse>(DoRequest("StartBoardRecord", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
        }

        public async Task<StartBoardRecordResponse> StartBoardRecordWithOptionsAsync(StartBoardRecordRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<StartBoardRecordResponse>(await DoRequestAsync("StartBoardRecord", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
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

        public ApplyRecordTokenResponse ApplyRecordTokenWithOptions(ApplyRecordTokenRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ApplyRecordTokenResponse>(DoRequest("ApplyRecordToken", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
        }

        public async Task<ApplyRecordTokenResponse> ApplyRecordTokenWithOptionsAsync(ApplyRecordTokenRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ApplyRecordTokenResponse>(await DoRequestAsync("ApplyRecordToken", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
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

        public UpdateBoardCallbackResponse UpdateBoardCallbackWithOptions(UpdateBoardCallbackRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<UpdateBoardCallbackResponse>(DoRequest("UpdateBoardCallback", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
        }

        public async Task<UpdateBoardCallbackResponse> UpdateBoardCallbackWithOptionsAsync(UpdateBoardCallbackRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<UpdateBoardCallbackResponse>(await DoRequestAsync("UpdateBoardCallback", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
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

        public DescribeLiveDomainMappingResponse DescribeLiveDomainMappingWithOptions(DescribeLiveDomainMappingRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeLiveDomainMappingResponse>(DoRequest("DescribeLiveDomainMapping", "HTTPS", "GET", "2016-11-01", "AK", request.ToMap(), null, runtime));
        }

        public async Task<DescribeLiveDomainMappingResponse> DescribeLiveDomainMappingWithOptionsAsync(DescribeLiveDomainMappingRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeLiveDomainMappingResponse>(await DoRequestAsync("DescribeLiveDomainMapping", "HTTPS", "GET", "2016-11-01", "AK", request.ToMap(), null, runtime));
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

        public StopLiveIndexResponse StopLiveIndexWithOptions(StopLiveIndexRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<StopLiveIndexResponse>(DoRequest("StopLiveIndex", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
        }

        public async Task<StopLiveIndexResponse> StopLiveIndexWithOptionsAsync(StopLiveIndexRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<StopLiveIndexResponse>(await DoRequestAsync("StopLiveIndex", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
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

        public StartLiveIndexResponse StartLiveIndexWithOptions(StartLiveIndexRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<StartLiveIndexResponse>(DoRequest("StartLiveIndex", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
        }

        public async Task<StartLiveIndexResponse> StartLiveIndexWithOptionsAsync(StartLiveIndexRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<StartLiveIndexResponse>(await DoRequestAsync("StartLiveIndex", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
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

        public RealTimeSnapshotCommandResponse RealTimeSnapshotCommandWithOptions(RealTimeSnapshotCommandRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<RealTimeSnapshotCommandResponse>(DoRequest("RealTimeSnapshotCommand", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
        }

        public async Task<RealTimeSnapshotCommandResponse> RealTimeSnapshotCommandWithOptionsAsync(RealTimeSnapshotCommandRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<RealTimeSnapshotCommandResponse>(await DoRequestAsync("RealTimeSnapshotCommand", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
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

        public DescribeLiveTopDomainsByFlowResponse DescribeLiveTopDomainsByFlowWithOptions(DescribeLiveTopDomainsByFlowRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeLiveTopDomainsByFlowResponse>(DoRequest("DescribeLiveTopDomainsByFlow", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DescribeLiveTopDomainsByFlowResponse> DescribeLiveTopDomainsByFlowWithOptionsAsync(DescribeLiveTopDomainsByFlowRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeLiveTopDomainsByFlowResponse>(await DoRequestAsync("DescribeLiveTopDomainsByFlow", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
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

        public DescribeLiveDomainRealTimeBpsDataResponse DescribeLiveDomainRealTimeBpsDataWithOptions(DescribeLiveDomainRealTimeBpsDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeLiveDomainRealTimeBpsDataResponse>(DoRequest("DescribeLiveDomainRealTimeBpsData", "HTTPS", "GET", "2016-11-01", "AK", request.ToMap(), null, runtime));
        }

        public async Task<DescribeLiveDomainRealTimeBpsDataResponse> DescribeLiveDomainRealTimeBpsDataWithOptionsAsync(DescribeLiveDomainRealTimeBpsDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeLiveDomainRealTimeBpsDataResponse>(await DoRequestAsync("DescribeLiveDomainRealTimeBpsData", "HTTPS", "GET", "2016-11-01", "AK", request.ToMap(), null, runtime));
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
            return TeaModel.ToObject<DescribeLiveDomainRealTimeHttpCodeDataResponse>(DoRequest("DescribeLiveDomainRealTimeHttpCodeData", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DescribeLiveDomainRealTimeHttpCodeDataResponse> DescribeLiveDomainRealTimeHttpCodeDataWithOptionsAsync(DescribeLiveDomainRealTimeHttpCodeDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeLiveDomainRealTimeHttpCodeDataResponse>(await DoRequestAsync("DescribeLiveDomainRealTimeHttpCodeData", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
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

        public DescribeLiveDomainRealTimeTrafficDataResponse DescribeLiveDomainRealTimeTrafficDataWithOptions(DescribeLiveDomainRealTimeTrafficDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeLiveDomainRealTimeTrafficDataResponse>(DoRequest("DescribeLiveDomainRealTimeTrafficData", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DescribeLiveDomainRealTimeTrafficDataResponse> DescribeLiveDomainRealTimeTrafficDataWithOptionsAsync(DescribeLiveDomainRealTimeTrafficDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeLiveDomainRealTimeTrafficDataResponse>(await DoRequestAsync("DescribeLiveDomainRealTimeTrafficData", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
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

        public AddLiveDomainPlayMappingResponse AddLiveDomainPlayMappingWithOptions(AddLiveDomainPlayMappingRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<AddLiveDomainPlayMappingResponse>(DoRequest("AddLiveDomainPlayMapping", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
        }

        public async Task<AddLiveDomainPlayMappingResponse> AddLiveDomainPlayMappingWithOptionsAsync(AddLiveDomainPlayMappingRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<AddLiveDomainPlayMappingResponse>(await DoRequestAsync("AddLiveDomainPlayMapping", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
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

        public DeleteLiveLazyPullStreamInfoConfigResponse DeleteLiveLazyPullStreamInfoConfigWithOptions(DeleteLiveLazyPullStreamInfoConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DeleteLiveLazyPullStreamInfoConfigResponse>(DoRequest("DeleteLiveLazyPullStreamInfoConfig", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DeleteLiveLazyPullStreamInfoConfigResponse> DeleteLiveLazyPullStreamInfoConfigWithOptionsAsync(DeleteLiveLazyPullStreamInfoConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DeleteLiveLazyPullStreamInfoConfigResponse>(await DoRequestAsync("DeleteLiveLazyPullStreamInfoConfig", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
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

        public DescribeLiveLazyPullStreamConfigResponse DescribeLiveLazyPullStreamConfigWithOptions(DescribeLiveLazyPullStreamConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeLiveLazyPullStreamConfigResponse>(DoRequest("DescribeLiveLazyPullStreamConfig", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DescribeLiveLazyPullStreamConfigResponse> DescribeLiveLazyPullStreamConfigWithOptionsAsync(DescribeLiveLazyPullStreamConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeLiveLazyPullStreamConfigResponse>(await DoRequestAsync("DescribeLiveLazyPullStreamConfig", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
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

        public SetLiveLazyPullStreamInfoConfigResponse SetLiveLazyPullStreamInfoConfigWithOptions(SetLiveLazyPullStreamInfoConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<SetLiveLazyPullStreamInfoConfigResponse>(DoRequest("SetLiveLazyPullStreamInfoConfig", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
        }

        public async Task<SetLiveLazyPullStreamInfoConfigResponse> SetLiveLazyPullStreamInfoConfigWithOptionsAsync(SetLiveLazyPullStreamInfoConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<SetLiveLazyPullStreamInfoConfigResponse>(await DoRequestAsync("SetLiveLazyPullStreamInfoConfig", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
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

        public UpdateCasterSceneAudioResponse UpdateCasterSceneAudioWithOptions(UpdateCasterSceneAudioRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<UpdateCasterSceneAudioResponse>(DoRequest("UpdateCasterSceneAudio", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
        }

        public async Task<UpdateCasterSceneAudioResponse> UpdateCasterSceneAudioWithOptionsAsync(UpdateCasterSceneAudioRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<UpdateCasterSceneAudioResponse>(await DoRequestAsync("UpdateCasterSceneAudio", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
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

        public SetCasterChannelResponse SetCasterChannelWithOptions(SetCasterChannelRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<SetCasterChannelResponse>(DoRequest("SetCasterChannel", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
        }

        public async Task<SetCasterChannelResponse> SetCasterChannelWithOptionsAsync(SetCasterChannelRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<SetCasterChannelResponse>(await DoRequestAsync("SetCasterChannel", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
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

        public DescribeCasterSceneAudioResponse DescribeCasterSceneAudioWithOptions(DescribeCasterSceneAudioRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeCasterSceneAudioResponse>(DoRequest("DescribeCasterSceneAudio", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DescribeCasterSceneAudioResponse> DescribeCasterSceneAudioWithOptionsAsync(DescribeCasterSceneAudioRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeCasterSceneAudioResponse>(await DoRequestAsync("DescribeCasterSceneAudio", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
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

        public DescribeCasterChannelsResponse DescribeCasterChannelsWithOptions(DescribeCasterChannelsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeCasterChannelsResponse>(DoRequest("DescribeCasterChannels", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DescribeCasterChannelsResponse> DescribeCasterChannelsWithOptionsAsync(DescribeCasterChannelsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeCasterChannelsResponse>(await DoRequestAsync("DescribeCasterChannels", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
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

        public UpdateBoardResponse UpdateBoardWithOptions(UpdateBoardRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<UpdateBoardResponse>(DoRequest("UpdateBoard", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
        }

        public async Task<UpdateBoardResponse> UpdateBoardWithOptionsAsync(UpdateBoardRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<UpdateBoardResponse>(await DoRequestAsync("UpdateBoard", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
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

        public JoinBoardResponse JoinBoardWithOptions(JoinBoardRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<JoinBoardResponse>(DoRequest("JoinBoard", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
        }

        public async Task<JoinBoardResponse> JoinBoardWithOptionsAsync(JoinBoardRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<JoinBoardResponse>(await DoRequestAsync("JoinBoard", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
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

        public DescribeBoardSnapshotResponse DescribeBoardSnapshotWithOptions(DescribeBoardSnapshotRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeBoardSnapshotResponse>(DoRequest("DescribeBoardSnapshot", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DescribeBoardSnapshotResponse> DescribeBoardSnapshotWithOptionsAsync(DescribeBoardSnapshotRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeBoardSnapshotResponse>(await DoRequestAsync("DescribeBoardSnapshot", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
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

        public DescribeBoardsResponse DescribeBoardsWithOptions(DescribeBoardsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeBoardsResponse>(DoRequest("DescribeBoards", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DescribeBoardsResponse> DescribeBoardsWithOptionsAsync(DescribeBoardsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeBoardsResponse>(await DoRequestAsync("DescribeBoards", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
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

        public DescribeBoardEventsResponse DescribeBoardEventsWithOptions(DescribeBoardEventsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeBoardEventsResponse>(DoRequest("DescribeBoardEvents", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DescribeBoardEventsResponse> DescribeBoardEventsWithOptionsAsync(DescribeBoardEventsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeBoardEventsResponse>(await DoRequestAsync("DescribeBoardEvents", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
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

        public DeleteBoardResponse DeleteBoardWithOptions(DeleteBoardRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DeleteBoardResponse>(DoRequest("DeleteBoard", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DeleteBoardResponse> DeleteBoardWithOptionsAsync(DeleteBoardRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DeleteBoardResponse>(await DoRequestAsync("DeleteBoard", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
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

        public CreateBoardResponse CreateBoardWithOptions(CreateBoardRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CreateBoardResponse>(DoRequest("CreateBoard", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
        }

        public async Task<CreateBoardResponse> CreateBoardWithOptionsAsync(CreateBoardRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CreateBoardResponse>(await DoRequestAsync("CreateBoard", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
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

        public CompleteBoardResponse CompleteBoardWithOptions(CompleteBoardRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CompleteBoardResponse>(DoRequest("CompleteBoard", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
        }

        public async Task<CompleteBoardResponse> CompleteBoardWithOptionsAsync(CompleteBoardRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CompleteBoardResponse>(await DoRequestAsync("CompleteBoard", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
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

        public ApplyBoardTokenResponse ApplyBoardTokenWithOptions(ApplyBoardTokenRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ApplyBoardTokenResponse>(DoRequest("ApplyBoardToken", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
        }

        public async Task<ApplyBoardTokenResponse> ApplyBoardTokenWithOptionsAsync(ApplyBoardTokenRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ApplyBoardTokenResponse>(await DoRequestAsync("ApplyBoardToken", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
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

        public DescribeLiveStreamCountResponse DescribeLiveStreamCountWithOptions(DescribeLiveStreamCountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeLiveStreamCountResponse>(DoRequest("DescribeLiveStreamCount", "HTTPS", "GET", "2016-11-01", "AK", request.ToMap(), null, runtime));
        }

        public async Task<DescribeLiveStreamCountResponse> DescribeLiveStreamCountWithOptionsAsync(DescribeLiveStreamCountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeLiveStreamCountResponse>(await DoRequestAsync("DescribeLiveStreamCount", "HTTPS", "GET", "2016-11-01", "AK", request.ToMap(), null, runtime));
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

        public DescribeLiveCertificateDetailResponse DescribeLiveCertificateDetailWithOptions(DescribeLiveCertificateDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeLiveCertificateDetailResponse>(DoRequest("DescribeLiveCertificateDetail", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DescribeLiveCertificateDetailResponse> DescribeLiveCertificateDetailWithOptionsAsync(DescribeLiveCertificateDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeLiveCertificateDetailResponse>(await DoRequestAsync("DescribeLiveCertificateDetail", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
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

        public DescribeHlsLiveStreamRealTimeBpsDataResponse DescribeHlsLiveStreamRealTimeBpsDataWithOptions(DescribeHlsLiveStreamRealTimeBpsDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeHlsLiveStreamRealTimeBpsDataResponse>(DoRequest("DescribeHlsLiveStreamRealTimeBpsData", "HTTPS", "GET", "2016-11-01", "AK", request.ToMap(), null, runtime));
        }

        public async Task<DescribeHlsLiveStreamRealTimeBpsDataResponse> DescribeHlsLiveStreamRealTimeBpsDataWithOptionsAsync(DescribeHlsLiveStreamRealTimeBpsDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeHlsLiveStreamRealTimeBpsDataResponse>(await DoRequestAsync("DescribeHlsLiveStreamRealTimeBpsData", "HTTPS", "GET", "2016-11-01", "AK", request.ToMap(), null, runtime));
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

        public StopLiveDomainResponse StopLiveDomainWithOptions(StopLiveDomainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<StopLiveDomainResponse>(DoRequest("StopLiveDomain", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
        }

        public async Task<StopLiveDomainResponse> StopLiveDomainWithOptionsAsync(StopLiveDomainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<StopLiveDomainResponse>(await DoRequestAsync("StopLiveDomain", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
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

        public StartLiveDomainResponse StartLiveDomainWithOptions(StartLiveDomainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<StartLiveDomainResponse>(DoRequest("StartLiveDomain", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
        }

        public async Task<StartLiveDomainResponse> StartLiveDomainWithOptionsAsync(StartLiveDomainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<StartLiveDomainResponse>(await DoRequestAsync("StartLiveDomain", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
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

        public SetLiveDomainCertificateResponse SetLiveDomainCertificateWithOptions(SetLiveDomainCertificateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<SetLiveDomainCertificateResponse>(DoRequest("SetLiveDomainCertificate", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
        }

        public async Task<SetLiveDomainCertificateResponse> SetLiveDomainCertificateWithOptionsAsync(SetLiveDomainCertificateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<SetLiveDomainCertificateResponse>(await DoRequestAsync("SetLiveDomainCertificate", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
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

        public BatchSetLiveDomainConfigsResponse BatchSetLiveDomainConfigsWithOptions(BatchSetLiveDomainConfigsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<BatchSetLiveDomainConfigsResponse>(DoRequest("BatchSetLiveDomainConfigs", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
        }

        public async Task<BatchSetLiveDomainConfigsResponse> BatchSetLiveDomainConfigsWithOptionsAsync(BatchSetLiveDomainConfigsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<BatchSetLiveDomainConfigsResponse>(await DoRequestAsync("BatchSetLiveDomainConfigs", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
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

        public DescribeLiveCertificateListResponse DescribeLiveCertificateListWithOptions(DescribeLiveCertificateListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeLiveCertificateListResponse>(DoRequest("DescribeLiveCertificateList", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DescribeLiveCertificateListResponse> DescribeLiveCertificateListWithOptionsAsync(DescribeLiveCertificateListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeLiveCertificateListResponse>(await DoRequestAsync("DescribeLiveCertificateList", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
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

        public DeleteLiveDomainResponse DeleteLiveDomainWithOptions(DeleteLiveDomainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DeleteLiveDomainResponse>(DoRequest("DeleteLiveDomain", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DeleteLiveDomainResponse> DeleteLiveDomainWithOptionsAsync(DeleteLiveDomainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DeleteLiveDomainResponse>(await DoRequestAsync("DeleteLiveDomain", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
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

        public DescribeLiveDomainConfigsResponse DescribeLiveDomainConfigsWithOptions(DescribeLiveDomainConfigsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeLiveDomainConfigsResponse>(DoRequest("DescribeLiveDomainConfigs", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DescribeLiveDomainConfigsResponse> DescribeLiveDomainConfigsWithOptionsAsync(DescribeLiveDomainConfigsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeLiveDomainConfigsResponse>(await DoRequestAsync("DescribeLiveDomainConfigs", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
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

        public AddLiveDomainResponse AddLiveDomainWithOptions(AddLiveDomainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<AddLiveDomainResponse>(DoRequest("AddLiveDomain", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
        }

        public async Task<AddLiveDomainResponse> AddLiveDomainWithOptionsAsync(AddLiveDomainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<AddLiveDomainResponse>(await DoRequestAsync("AddLiveDomain", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
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

        public DescribeLiveDomainDetailResponse DescribeLiveDomainDetailWithOptions(DescribeLiveDomainDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeLiveDomainDetailResponse>(DoRequest("DescribeLiveDomainDetail", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DescribeLiveDomainDetailResponse> DescribeLiveDomainDetailWithOptionsAsync(DescribeLiveDomainDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeLiveDomainDetailResponse>(await DoRequestAsync("DescribeLiveDomainDetail", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
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

        public BatchDeleteLiveDomainConfigsResponse BatchDeleteLiveDomainConfigsWithOptions(BatchDeleteLiveDomainConfigsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<BatchDeleteLiveDomainConfigsResponse>(DoRequest("BatchDeleteLiveDomainConfigs", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
        }

        public async Task<BatchDeleteLiveDomainConfigsResponse> BatchDeleteLiveDomainConfigsWithOptionsAsync(BatchDeleteLiveDomainConfigsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<BatchDeleteLiveDomainConfigsResponse>(await DoRequestAsync("BatchDeleteLiveDomainConfigs", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
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

        public DescribeRoomStatusResponse DescribeRoomStatusWithOptions(DescribeRoomStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeRoomStatusResponse>(DoRequest("DescribeRoomStatus", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DescribeRoomStatusResponse> DescribeRoomStatusWithOptionsAsync(DescribeRoomStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeRoomStatusResponse>(await DoRequestAsync("DescribeRoomStatus", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
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

        public DescribeRoomListResponse DescribeRoomListWithOptions(DescribeRoomListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeRoomListResponse>(DoRequest("DescribeRoomList", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DescribeRoomListResponse> DescribeRoomListWithOptionsAsync(DescribeRoomListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeRoomListResponse>(await DoRequestAsync("DescribeRoomList", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
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

        public DescribeRoomKickoutUserListResponse DescribeRoomKickoutUserListWithOptions(DescribeRoomKickoutUserListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeRoomKickoutUserListResponse>(DoRequest("DescribeRoomKickoutUserList", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DescribeRoomKickoutUserListResponse> DescribeRoomKickoutUserListWithOptionsAsync(DescribeRoomKickoutUserListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeRoomKickoutUserListResponse>(await DoRequestAsync("DescribeRoomKickoutUserList", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
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

        public SendRoomUserNotificationResponse SendRoomUserNotificationWithOptions(SendRoomUserNotificationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<SendRoomUserNotificationResponse>(DoRequest("SendRoomUserNotification", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
        }

        public async Task<SendRoomUserNotificationResponse> SendRoomUserNotificationWithOptionsAsync(SendRoomUserNotificationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<SendRoomUserNotificationResponse>(await DoRequestAsync("SendRoomUserNotification", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
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

        public DescribeForbidPushStreamRoomListResponse DescribeForbidPushStreamRoomListWithOptions(DescribeForbidPushStreamRoomListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeForbidPushStreamRoomListResponse>(DoRequest("DescribeForbidPushStreamRoomList", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DescribeForbidPushStreamRoomListResponse> DescribeForbidPushStreamRoomListWithOptionsAsync(DescribeForbidPushStreamRoomListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeForbidPushStreamRoomListResponse>(await DoRequestAsync("DescribeForbidPushStreamRoomList", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
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

        public SendRoomNotificationResponse SendRoomNotificationWithOptions(SendRoomNotificationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<SendRoomNotificationResponse>(DoRequest("SendRoomNotification", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
        }

        public async Task<SendRoomNotificationResponse> SendRoomNotificationWithOptionsAsync(SendRoomNotificationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<SendRoomNotificationResponse>(await DoRequestAsync("SendRoomNotification", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
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

        public ForbidPushStreamResponse ForbidPushStreamWithOptions(ForbidPushStreamRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ForbidPushStreamResponse>(DoRequest("ForbidPushStream", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
        }

        public async Task<ForbidPushStreamResponse> ForbidPushStreamWithOptionsAsync(ForbidPushStreamRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ForbidPushStreamResponse>(await DoRequestAsync("ForbidPushStream", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
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

        public DeleteRoomResponse DeleteRoomWithOptions(DeleteRoomRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DeleteRoomResponse>(DoRequest("DeleteRoom", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DeleteRoomResponse> DeleteRoomWithOptionsAsync(DeleteRoomRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DeleteRoomResponse>(await DoRequestAsync("DeleteRoom", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
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

        public CreateRoomResponse CreateRoomWithOptions(CreateRoomRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CreateRoomResponse>(DoRequest("CreateRoom", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
        }

        public async Task<CreateRoomResponse> CreateRoomWithOptionsAsync(CreateRoomRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CreateRoomResponse>(await DoRequestAsync("CreateRoom", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
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

        public AllowPushStreamResponse AllowPushStreamWithOptions(AllowPushStreamRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<AllowPushStreamResponse>(DoRequest("AllowPushStream", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
        }

        public async Task<AllowPushStreamResponse> AllowPushStreamWithOptionsAsync(AllowPushStreamRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<AllowPushStreamResponse>(await DoRequestAsync("AllowPushStream", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
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

        public DescribeLiveUserDomainsResponse DescribeLiveUserDomainsWithOptions(DescribeLiveUserDomainsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeLiveUserDomainsResponse>(DoRequest("DescribeLiveUserDomains", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DescribeLiveUserDomainsResponse> DescribeLiveUserDomainsWithOptionsAsync(DescribeLiveUserDomainsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeLiveUserDomainsResponse>(await DoRequestAsync("DescribeLiveUserDomains", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
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

        public DescribeCasterRtcInfoResponse DescribeCasterRtcInfoWithOptions(DescribeCasterRtcInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeCasterRtcInfoResponse>(DoRequest("DescribeCasterRtcInfo", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DescribeCasterRtcInfoResponse> DescribeCasterRtcInfoWithOptionsAsync(DescribeCasterRtcInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeCasterRtcInfoResponse>(await DoRequestAsync("DescribeCasterRtcInfo", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
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

        public DescribeUpBpsPeakDataResponse DescribeUpBpsPeakDataWithOptions(DescribeUpBpsPeakDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeUpBpsPeakDataResponse>(DoRequest("DescribeUpBpsPeakData", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DescribeUpBpsPeakDataResponse> DescribeUpBpsPeakDataWithOptionsAsync(DescribeUpBpsPeakDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeUpBpsPeakDataResponse>(await DoRequestAsync("DescribeUpBpsPeakData", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
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
            return TeaModel.ToObject<DescribeUpBpsPeakOfLineResponse>(DoRequest("DescribeUpBpsPeakOfLine", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DescribeUpBpsPeakOfLineResponse> DescribeUpBpsPeakOfLineWithOptionsAsync(DescribeUpBpsPeakOfLineRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeUpBpsPeakOfLineResponse>(await DoRequestAsync("DescribeUpBpsPeakOfLine", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
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
            return TeaModel.ToObject<DescribeUpPeakPublishStreamDataResponse>(DoRequest("DescribeUpPeakPublishStreamData", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DescribeUpPeakPublishStreamDataResponse> DescribeUpPeakPublishStreamDataWithOptionsAsync(DescribeUpPeakPublishStreamDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeUpPeakPublishStreamDataResponse>(await DoRequestAsync("DescribeUpPeakPublishStreamData", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
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

        public DeleteLiveDomainMappingResponse DeleteLiveDomainMappingWithOptions(DeleteLiveDomainMappingRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DeleteLiveDomainMappingResponse>(DoRequest("DeleteLiveDomainMapping", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DeleteLiveDomainMappingResponse> DeleteLiveDomainMappingWithOptionsAsync(DeleteLiveDomainMappingRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DeleteLiveDomainMappingResponse>(await DoRequestAsync("DeleteLiveDomainMapping", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
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

        public AddLiveDomainMappingResponse AddLiveDomainMappingWithOptions(AddLiveDomainMappingRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<AddLiveDomainMappingResponse>(DoRequest("AddLiveDomainMapping", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
        }

        public async Task<AddLiveDomainMappingResponse> AddLiveDomainMappingWithOptionsAsync(AddLiveDomainMappingRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<AddLiveDomainMappingResponse>(await DoRequestAsync("AddLiveDomainMapping", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
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

        public AddCasterEpisodeGroupContentResponse AddCasterEpisodeGroupContentWithOptions(AddCasterEpisodeGroupContentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<AddCasterEpisodeGroupContentResponse>(DoRequest("AddCasterEpisodeGroupContent", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
        }

        public async Task<AddCasterEpisodeGroupContentResponse> AddCasterEpisodeGroupContentWithOptionsAsync(AddCasterEpisodeGroupContentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<AddCasterEpisodeGroupContentResponse>(await DoRequestAsync("AddCasterEpisodeGroupContent", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
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

        public ModifyCasterProgramResponse ModifyCasterProgramWithOptions(ModifyCasterProgramRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ModifyCasterProgramResponse>(DoRequest("ModifyCasterProgram", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
        }

        public async Task<ModifyCasterProgramResponse> ModifyCasterProgramWithOptionsAsync(ModifyCasterProgramRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ModifyCasterProgramResponse>(await DoRequestAsync("ModifyCasterProgram", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
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

        public ModifyCasterEpisodeResponse ModifyCasterEpisodeWithOptions(ModifyCasterEpisodeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ModifyCasterEpisodeResponse>(DoRequest("ModifyCasterEpisode", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
        }

        public async Task<ModifyCasterEpisodeResponse> ModifyCasterEpisodeWithOptionsAsync(ModifyCasterEpisodeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ModifyCasterEpisodeResponse>(await DoRequestAsync("ModifyCasterEpisode", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
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

        public DescribeCasterProgramResponse DescribeCasterProgramWithOptions(DescribeCasterProgramRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeCasterProgramResponse>(DoRequest("DescribeCasterProgram", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DescribeCasterProgramResponse> DescribeCasterProgramWithOptionsAsync(DescribeCasterProgramRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeCasterProgramResponse>(await DoRequestAsync("DescribeCasterProgram", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
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

        public DeleteCasterProgramResponse DeleteCasterProgramWithOptions(DeleteCasterProgramRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DeleteCasterProgramResponse>(DoRequest("DeleteCasterProgram", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DeleteCasterProgramResponse> DeleteCasterProgramWithOptionsAsync(DeleteCasterProgramRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DeleteCasterProgramResponse>(await DoRequestAsync("DeleteCasterProgram", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
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

        public DeleteCasterEpisodeGroupResponse DeleteCasterEpisodeGroupWithOptions(DeleteCasterEpisodeGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DeleteCasterEpisodeGroupResponse>(DoRequest("DeleteCasterEpisodeGroup", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DeleteCasterEpisodeGroupResponse> DeleteCasterEpisodeGroupWithOptionsAsync(DeleteCasterEpisodeGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DeleteCasterEpisodeGroupResponse>(await DoRequestAsync("DeleteCasterEpisodeGroup", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
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

        public DeleteCasterEpisodeResponse DeleteCasterEpisodeWithOptions(DeleteCasterEpisodeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DeleteCasterEpisodeResponse>(DoRequest("DeleteCasterEpisode", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DeleteCasterEpisodeResponse> DeleteCasterEpisodeWithOptionsAsync(DeleteCasterEpisodeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DeleteCasterEpisodeResponse>(await DoRequestAsync("DeleteCasterEpisode", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
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

        public AddCasterProgramResponse AddCasterProgramWithOptions(AddCasterProgramRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<AddCasterProgramResponse>(DoRequest("AddCasterProgram", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
        }

        public async Task<AddCasterProgramResponse> AddCasterProgramWithOptionsAsync(AddCasterProgramRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<AddCasterProgramResponse>(await DoRequestAsync("AddCasterProgram", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
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

        public AddCasterEpisodeGroupResponse AddCasterEpisodeGroupWithOptions(AddCasterEpisodeGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<AddCasterEpisodeGroupResponse>(DoRequest("AddCasterEpisodeGroup", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
        }

        public async Task<AddCasterEpisodeGroupResponse> AddCasterEpisodeGroupWithOptionsAsync(AddCasterEpisodeGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<AddCasterEpisodeGroupResponse>(await DoRequestAsync("AddCasterEpisodeGroup", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
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

        public AddCasterEpisodeResponse AddCasterEpisodeWithOptions(AddCasterEpisodeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<AddCasterEpisodeResponse>(DoRequest("AddCasterEpisode", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
        }

        public async Task<AddCasterEpisodeResponse> AddCasterEpisodeWithOptionsAsync(AddCasterEpisodeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<AddCasterEpisodeResponse>(await DoRequestAsync("AddCasterEpisode", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
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

        public DescribeLiveDomainTranscodeDataResponse DescribeLiveDomainTranscodeDataWithOptions(DescribeLiveDomainTranscodeDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeLiveDomainTranscodeDataResponse>(DoRequest("DescribeLiveDomainTranscodeData", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DescribeLiveDomainTranscodeDataResponse> DescribeLiveDomainTranscodeDataWithOptionsAsync(DescribeLiveDomainTranscodeDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeLiveDomainTranscodeDataResponse>(await DoRequestAsync("DescribeLiveDomainTranscodeData", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
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

        public DescribeLiveDomainSnapshotDataResponse DescribeLiveDomainSnapshotDataWithOptions(DescribeLiveDomainSnapshotDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeLiveDomainSnapshotDataResponse>(DoRequest("DescribeLiveDomainSnapshotData", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DescribeLiveDomainSnapshotDataResponse> DescribeLiveDomainSnapshotDataWithOptionsAsync(DescribeLiveDomainSnapshotDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeLiveDomainSnapshotDataResponse>(await DoRequestAsync("DescribeLiveDomainSnapshotData", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
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

        public DescribeLiveDomainRecordDataResponse DescribeLiveDomainRecordDataWithOptions(DescribeLiveDomainRecordDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeLiveDomainRecordDataResponse>(DoRequest("DescribeLiveDomainRecordData", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DescribeLiveDomainRecordDataResponse> DescribeLiveDomainRecordDataWithOptionsAsync(DescribeLiveDomainRecordDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeLiveDomainRecordDataResponse>(await DoRequestAsync("DescribeLiveDomainRecordData", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
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

        public RealTimeRecordCommandResponse RealTimeRecordCommandWithOptions(RealTimeRecordCommandRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<RealTimeRecordCommandResponse>(DoRequest("RealTimeRecordCommand", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
        }

        public async Task<RealTimeRecordCommandResponse> RealTimeRecordCommandWithOptionsAsync(RealTimeRecordCommandRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<RealTimeRecordCommandResponse>(await DoRequestAsync("RealTimeRecordCommand", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
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

        public DescribeLiveDomainTrafficDataResponse DescribeLiveDomainTrafficDataWithOptions(DescribeLiveDomainTrafficDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeLiveDomainTrafficDataResponse>(DoRequest("DescribeLiveDomainTrafficData", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DescribeLiveDomainTrafficDataResponse> DescribeLiveDomainTrafficDataWithOptionsAsync(DescribeLiveDomainTrafficDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeLiveDomainTrafficDataResponse>(await DoRequestAsync("DescribeLiveDomainTrafficData", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
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

        public DescribeLiveDomainBpsDataResponse DescribeLiveDomainBpsDataWithOptions(DescribeLiveDomainBpsDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeLiveDomainBpsDataResponse>(DoRequest("DescribeLiveDomainBpsData", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DescribeLiveDomainBpsDataResponse> DescribeLiveDomainBpsDataWithOptionsAsync(DescribeLiveDomainBpsDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeLiveDomainBpsDataResponse>(await DoRequestAsync("DescribeLiveDomainBpsData", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
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

        public AddTrancodeSEIResponse AddTrancodeSEIWithOptions(AddTrancodeSEIRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<AddTrancodeSEIResponse>(DoRequest("AddTrancodeSEI", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
        }

        public async Task<AddTrancodeSEIResponse> AddTrancodeSEIWithOptionsAsync(AddTrancodeSEIRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<AddTrancodeSEIResponse>(await DoRequestAsync("AddTrancodeSEI", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
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

        public DeleteCasterSceneConfigResponse DeleteCasterSceneConfigWithOptions(DeleteCasterSceneConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DeleteCasterSceneConfigResponse>(DoRequest("DeleteCasterSceneConfig", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DeleteCasterSceneConfigResponse> DeleteCasterSceneConfigWithOptionsAsync(DeleteCasterSceneConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DeleteCasterSceneConfigResponse>(await DoRequestAsync("DeleteCasterSceneConfig", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
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

        public AddCustomLiveStreamTranscodeResponse AddCustomLiveStreamTranscodeWithOptions(AddCustomLiveStreamTranscodeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<AddCustomLiveStreamTranscodeResponse>(DoRequest("AddCustomLiveStreamTranscode", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
        }

        public async Task<AddCustomLiveStreamTranscodeResponse> AddCustomLiveStreamTranscodeWithOptionsAsync(AddCustomLiveStreamTranscodeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<AddCustomLiveStreamTranscodeResponse>(await DoRequestAsync("AddCustomLiveStreamTranscode", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
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

        public DescribeLiveRecordVodConfigsResponse DescribeLiveRecordVodConfigsWithOptions(DescribeLiveRecordVodConfigsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeLiveRecordVodConfigsResponse>(DoRequest("DescribeLiveRecordVodConfigs", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DescribeLiveRecordVodConfigsResponse> DescribeLiveRecordVodConfigsWithOptionsAsync(DescribeLiveRecordVodConfigsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeLiveRecordVodConfigsResponse>(await DoRequestAsync("DescribeLiveRecordVodConfigs", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
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

        public DeleteLiveRecordVodConfigResponse DeleteLiveRecordVodConfigWithOptions(DeleteLiveRecordVodConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DeleteLiveRecordVodConfigResponse>(DoRequest("DeleteLiveRecordVodConfig", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DeleteLiveRecordVodConfigResponse> DeleteLiveRecordVodConfigWithOptionsAsync(DeleteLiveRecordVodConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DeleteLiveRecordVodConfigResponse>(await DoRequestAsync("DeleteLiveRecordVodConfig", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
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

        public AddLiveRecordVodConfigResponse AddLiveRecordVodConfigWithOptions(AddLiveRecordVodConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<AddLiveRecordVodConfigResponse>(DoRequest("AddLiveRecordVodConfig", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
        }

        public async Task<AddLiveRecordVodConfigResponse> AddLiveRecordVodConfigWithOptionsAsync(AddLiveRecordVodConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<AddLiveRecordVodConfigResponse>(await DoRequestAsync("AddLiveRecordVodConfig", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
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

        public ModifyCasterComponentResponse ModifyCasterComponentWithOptions(ModifyCasterComponentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ModifyCasterComponentResponse>(DoRequest("ModifyCasterComponent", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
        }

        public async Task<ModifyCasterComponentResponse> ModifyCasterComponentWithOptionsAsync(ModifyCasterComponentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ModifyCasterComponentResponse>(await DoRequestAsync("ModifyCasterComponent", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
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

        public DescribeCasterComponentsResponse DescribeCasterComponentsWithOptions(DescribeCasterComponentsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeCasterComponentsResponse>(DoRequest("DescribeCasterComponents", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DescribeCasterComponentsResponse> DescribeCasterComponentsWithOptionsAsync(DescribeCasterComponentsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeCasterComponentsResponse>(await DoRequestAsync("DescribeCasterComponents", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
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

        public DeleteCasterComponentResponse DeleteCasterComponentWithOptions(DeleteCasterComponentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DeleteCasterComponentResponse>(DoRequest("DeleteCasterComponent", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DeleteCasterComponentResponse> DeleteCasterComponentWithOptionsAsync(DeleteCasterComponentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DeleteCasterComponentResponse>(await DoRequestAsync("DeleteCasterComponent", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
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

        public AddCasterComponentResponse AddCasterComponentWithOptions(AddCasterComponentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<AddCasterComponentResponse>(DoRequest("AddCasterComponent", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
        }

        public async Task<AddCasterComponentResponse> AddCasterComponentWithOptionsAsync(AddCasterComponentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<AddCasterComponentResponse>(await DoRequestAsync("AddCasterComponent", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
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

        public StopCasterResponse StopCasterWithOptions(StopCasterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<StopCasterResponse>(DoRequest("StopCaster", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
        }

        public async Task<StopCasterResponse> StopCasterWithOptionsAsync(StopCasterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<StopCasterResponse>(await DoRequestAsync("StopCaster", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
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

        public StartCasterResponse StartCasterWithOptions(StartCasterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<StartCasterResponse>(DoRequest("StartCaster", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
        }

        public async Task<StartCasterResponse> StartCasterWithOptionsAsync(StartCasterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<StartCasterResponse>(await DoRequestAsync("StartCaster", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
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

        public DescribeLiveStreamHistoryUserNumResponse DescribeLiveStreamHistoryUserNumWithOptions(DescribeLiveStreamHistoryUserNumRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeLiveStreamHistoryUserNumResponse>(DoRequest("DescribeLiveStreamHistoryUserNum", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DescribeLiveStreamHistoryUserNumResponse> DescribeLiveStreamHistoryUserNumWithOptionsAsync(DescribeLiveStreamHistoryUserNumRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeLiveStreamHistoryUserNumResponse>(await DoRequestAsync("DescribeLiveStreamHistoryUserNum", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
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

        public UpdateCasterSceneConfigResponse UpdateCasterSceneConfigWithOptions(UpdateCasterSceneConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<UpdateCasterSceneConfigResponse>(DoRequest("UpdateCasterSceneConfig", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
        }

        public async Task<UpdateCasterSceneConfigResponse> UpdateCasterSceneConfigWithOptionsAsync(UpdateCasterSceneConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<UpdateCasterSceneConfigResponse>(await DoRequestAsync("UpdateCasterSceneConfig", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
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

        public StopCasterSceneResponse StopCasterSceneWithOptions(StopCasterSceneRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<StopCasterSceneResponse>(DoRequest("StopCasterScene", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
        }

        public async Task<StopCasterSceneResponse> StopCasterSceneWithOptionsAsync(StopCasterSceneRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<StopCasterSceneResponse>(await DoRequestAsync("StopCasterScene", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
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

        public StartCasterSceneResponse StartCasterSceneWithOptions(StartCasterSceneRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<StartCasterSceneResponse>(DoRequest("StartCasterScene", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
        }

        public async Task<StartCasterSceneResponse> StartCasterSceneWithOptionsAsync(StartCasterSceneRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<StartCasterSceneResponse>(await DoRequestAsync("StartCasterScene", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
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

        public SetCasterSceneConfigResponse SetCasterSceneConfigWithOptions(SetCasterSceneConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<SetCasterSceneConfigResponse>(DoRequest("SetCasterSceneConfig", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
        }

        public async Task<SetCasterSceneConfigResponse> SetCasterSceneConfigWithOptionsAsync(SetCasterSceneConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<SetCasterSceneConfigResponse>(await DoRequestAsync("SetCasterSceneConfig", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
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

        public SetCasterConfigResponse SetCasterConfigWithOptions(SetCasterConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<SetCasterConfigResponse>(DoRequest("SetCasterConfig", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
        }

        public async Task<SetCasterConfigResponse> SetCasterConfigWithOptionsAsync(SetCasterConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<SetCasterConfigResponse>(await DoRequestAsync("SetCasterConfig", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
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

        public ModifyCasterVideoResourceResponse ModifyCasterVideoResourceWithOptions(ModifyCasterVideoResourceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ModifyCasterVideoResourceResponse>(DoRequest("ModifyCasterVideoResource", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
        }

        public async Task<ModifyCasterVideoResourceResponse> ModifyCasterVideoResourceWithOptionsAsync(ModifyCasterVideoResourceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ModifyCasterVideoResourceResponse>(await DoRequestAsync("ModifyCasterVideoResource", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
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

        public ModifyCasterLayoutResponse ModifyCasterLayoutWithOptions(ModifyCasterLayoutRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ModifyCasterLayoutResponse>(DoRequest("ModifyCasterLayout", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
        }

        public async Task<ModifyCasterLayoutResponse> ModifyCasterLayoutWithOptionsAsync(ModifyCasterLayoutRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ModifyCasterLayoutResponse>(await DoRequestAsync("ModifyCasterLayout", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
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

        public EffectCasterVideoResourceResponse EffectCasterVideoResourceWithOptions(EffectCasterVideoResourceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<EffectCasterVideoResourceResponse>(DoRequest("EffectCasterVideoResource", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
        }

        public async Task<EffectCasterVideoResourceResponse> EffectCasterVideoResourceWithOptionsAsync(EffectCasterVideoResourceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<EffectCasterVideoResourceResponse>(await DoRequestAsync("EffectCasterVideoResource", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
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

        public EffectCasterUrgentResponse EffectCasterUrgentWithOptions(EffectCasterUrgentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<EffectCasterUrgentResponse>(DoRequest("EffectCasterUrgent", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
        }

        public async Task<EffectCasterUrgentResponse> EffectCasterUrgentWithOptionsAsync(EffectCasterUrgentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<EffectCasterUrgentResponse>(await DoRequestAsync("EffectCasterUrgent", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
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

        public DescribeCasterVideoResourcesResponse DescribeCasterVideoResourcesWithOptions(DescribeCasterVideoResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeCasterVideoResourcesResponse>(DoRequest("DescribeCasterVideoResources", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DescribeCasterVideoResourcesResponse> DescribeCasterVideoResourcesWithOptionsAsync(DescribeCasterVideoResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeCasterVideoResourcesResponse>(await DoRequestAsync("DescribeCasterVideoResources", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
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

        public DescribeCasterStreamUrlResponse DescribeCasterStreamUrlWithOptions(DescribeCasterStreamUrlRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeCasterStreamUrlResponse>(DoRequest("DescribeCasterStreamUrl", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DescribeCasterStreamUrlResponse> DescribeCasterStreamUrlWithOptionsAsync(DescribeCasterStreamUrlRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeCasterStreamUrlResponse>(await DoRequestAsync("DescribeCasterStreamUrl", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
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

        public DescribeCasterScenesResponse DescribeCasterScenesWithOptions(DescribeCasterScenesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeCasterScenesResponse>(DoRequest("DescribeCasterScenes", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DescribeCasterScenesResponse> DescribeCasterScenesWithOptionsAsync(DescribeCasterScenesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeCasterScenesResponse>(await DoRequestAsync("DescribeCasterScenes", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
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

        public DescribeCastersResponse DescribeCastersWithOptions(DescribeCastersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeCastersResponse>(DoRequest("DescribeCasters", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DescribeCastersResponse> DescribeCastersWithOptionsAsync(DescribeCastersRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeCastersResponse>(await DoRequestAsync("DescribeCasters", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
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

        public DescribeCasterLayoutsResponse DescribeCasterLayoutsWithOptions(DescribeCasterLayoutsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeCasterLayoutsResponse>(DoRequest("DescribeCasterLayouts", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DescribeCasterLayoutsResponse> DescribeCasterLayoutsWithOptionsAsync(DescribeCasterLayoutsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeCasterLayoutsResponse>(await DoRequestAsync("DescribeCasterLayouts", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
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

        public DescribeCasterConfigResponse DescribeCasterConfigWithOptions(DescribeCasterConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeCasterConfigResponse>(DoRequest("DescribeCasterConfig", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DescribeCasterConfigResponse> DescribeCasterConfigWithOptionsAsync(DescribeCasterConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeCasterConfigResponse>(await DoRequestAsync("DescribeCasterConfig", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
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

        public DeleteCasterVideoResourceResponse DeleteCasterVideoResourceWithOptions(DeleteCasterVideoResourceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DeleteCasterVideoResourceResponse>(DoRequest("DeleteCasterVideoResource", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DeleteCasterVideoResourceResponse> DeleteCasterVideoResourceWithOptionsAsync(DeleteCasterVideoResourceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DeleteCasterVideoResourceResponse>(await DoRequestAsync("DeleteCasterVideoResource", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
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

        public DeleteCasterLayoutResponse DeleteCasterLayoutWithOptions(DeleteCasterLayoutRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DeleteCasterLayoutResponse>(DoRequest("DeleteCasterLayout", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DeleteCasterLayoutResponse> DeleteCasterLayoutWithOptionsAsync(DeleteCasterLayoutRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DeleteCasterLayoutResponse>(await DoRequestAsync("DeleteCasterLayout", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
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

        public DeleteCasterResponse DeleteCasterWithOptions(DeleteCasterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DeleteCasterResponse>(DoRequest("DeleteCaster", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DeleteCasterResponse> DeleteCasterWithOptionsAsync(DeleteCasterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DeleteCasterResponse>(await DoRequestAsync("DeleteCaster", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
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

        public CreateCasterResponse CreateCasterWithOptions(CreateCasterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CreateCasterResponse>(DoRequest("CreateCaster", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
        }

        public async Task<CreateCasterResponse> CreateCasterWithOptionsAsync(CreateCasterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CreateCasterResponse>(await DoRequestAsync("CreateCaster", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
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

        public CopyCasterSceneConfigResponse CopyCasterSceneConfigWithOptions(CopyCasterSceneConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CopyCasterSceneConfigResponse>(DoRequest("CopyCasterSceneConfig", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
        }

        public async Task<CopyCasterSceneConfigResponse> CopyCasterSceneConfigWithOptionsAsync(CopyCasterSceneConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CopyCasterSceneConfigResponse>(await DoRequestAsync("CopyCasterSceneConfig", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
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

        public CopyCasterResponse CopyCasterWithOptions(CopyCasterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CopyCasterResponse>(DoRequest("CopyCaster", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
        }

        public async Task<CopyCasterResponse> CopyCasterWithOptionsAsync(CopyCasterRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CopyCasterResponse>(await DoRequestAsync("CopyCaster", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
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

        public AddCasterVideoResourceResponse AddCasterVideoResourceWithOptions(AddCasterVideoResourceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<AddCasterVideoResourceResponse>(DoRequest("AddCasterVideoResource", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
        }

        public async Task<AddCasterVideoResourceResponse> AddCasterVideoResourceWithOptionsAsync(AddCasterVideoResourceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<AddCasterVideoResourceResponse>(await DoRequestAsync("AddCasterVideoResource", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
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

        public AddCasterLayoutResponse AddCasterLayoutWithOptions(AddCasterLayoutRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<AddCasterLayoutResponse>(DoRequest("AddCasterLayout", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
        }

        public async Task<AddCasterLayoutResponse> AddCasterLayoutWithOptionsAsync(AddCasterLayoutRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<AddCasterLayoutResponse>(await DoRequestAsync("AddCasterLayout", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
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

        public DescribeLivePullStreamConfigResponse DescribeLivePullStreamConfigWithOptions(DescribeLivePullStreamConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeLivePullStreamConfigResponse>(DoRequest("DescribeLivePullStreamConfig", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DescribeLivePullStreamConfigResponse> DescribeLivePullStreamConfigWithOptionsAsync(DescribeLivePullStreamConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeLivePullStreamConfigResponse>(await DoRequestAsync("DescribeLivePullStreamConfig", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
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

        public DeleteLivePullStreamInfoConfigResponse DeleteLivePullStreamInfoConfigWithOptions(DeleteLivePullStreamInfoConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DeleteLivePullStreamInfoConfigResponse>(DoRequest("DeleteLivePullStreamInfoConfig", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DeleteLivePullStreamInfoConfigResponse> DeleteLivePullStreamInfoConfigWithOptionsAsync(DeleteLivePullStreamInfoConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DeleteLivePullStreamInfoConfigResponse>(await DoRequestAsync("DeleteLivePullStreamInfoConfig", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
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

        public AddLivePullStreamInfoConfigResponse AddLivePullStreamInfoConfigWithOptions(AddLivePullStreamInfoConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<AddLivePullStreamInfoConfigResponse>(DoRequest("AddLivePullStreamInfoConfig", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
        }

        public async Task<AddLivePullStreamInfoConfigResponse> AddLivePullStreamInfoConfigWithOptionsAsync(AddLivePullStreamInfoConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<AddLivePullStreamInfoConfigResponse>(await DoRequestAsync("AddLivePullStreamInfoConfig", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
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

        public DescribeLiveStreamBitRateDataResponse DescribeLiveStreamBitRateDataWithOptions(DescribeLiveStreamBitRateDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeLiveStreamBitRateDataResponse>(DoRequest("DescribeLiveStreamBitRateData", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DescribeLiveStreamBitRateDataResponse> DescribeLiveStreamBitRateDataWithOptionsAsync(DescribeLiveStreamBitRateDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeLiveStreamBitRateDataResponse>(await DoRequestAsync("DescribeLiveStreamBitRateData", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
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

        public AddLiveDetectNotifyConfigResponse AddLiveDetectNotifyConfigWithOptions(AddLiveDetectNotifyConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<AddLiveDetectNotifyConfigResponse>(DoRequest("AddLiveDetectNotifyConfig", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
        }

        public async Task<AddLiveDetectNotifyConfigResponse> AddLiveDetectNotifyConfigWithOptionsAsync(AddLiveDetectNotifyConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<AddLiveDetectNotifyConfigResponse>(await DoRequestAsync("AddLiveDetectNotifyConfig", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
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

        public AddLiveSnapshotDetectPornConfigResponse AddLiveSnapshotDetectPornConfigWithOptions(AddLiveSnapshotDetectPornConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<AddLiveSnapshotDetectPornConfigResponse>(DoRequest("AddLiveSnapshotDetectPornConfig", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
        }

        public async Task<AddLiveSnapshotDetectPornConfigResponse> AddLiveSnapshotDetectPornConfigWithOptionsAsync(AddLiveSnapshotDetectPornConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<AddLiveSnapshotDetectPornConfigResponse>(await DoRequestAsync("AddLiveSnapshotDetectPornConfig", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
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

        public DeleteLiveDetectNotifyConfigResponse DeleteLiveDetectNotifyConfigWithOptions(DeleteLiveDetectNotifyConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DeleteLiveDetectNotifyConfigResponse>(DoRequest("DeleteLiveDetectNotifyConfig", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DeleteLiveDetectNotifyConfigResponse> DeleteLiveDetectNotifyConfigWithOptionsAsync(DeleteLiveDetectNotifyConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DeleteLiveDetectNotifyConfigResponse>(await DoRequestAsync("DeleteLiveDetectNotifyConfig", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
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

        public DescribeLiveDetectNotifyConfigResponse DescribeLiveDetectNotifyConfigWithOptions(DescribeLiveDetectNotifyConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeLiveDetectNotifyConfigResponse>(DoRequest("DescribeLiveDetectNotifyConfig", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DescribeLiveDetectNotifyConfigResponse> DescribeLiveDetectNotifyConfigWithOptionsAsync(DescribeLiveDetectNotifyConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeLiveDetectNotifyConfigResponse>(await DoRequestAsync("DescribeLiveDetectNotifyConfig", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
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

        public DeleteLiveSnapshotDetectPornConfigResponse DeleteLiveSnapshotDetectPornConfigWithOptions(DeleteLiveSnapshotDetectPornConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DeleteLiveSnapshotDetectPornConfigResponse>(DoRequest("DeleteLiveSnapshotDetectPornConfig", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DeleteLiveSnapshotDetectPornConfigResponse> DeleteLiveSnapshotDetectPornConfigWithOptionsAsync(DeleteLiveSnapshotDetectPornConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DeleteLiveSnapshotDetectPornConfigResponse>(await DoRequestAsync("DeleteLiveSnapshotDetectPornConfig", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
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

        public DescribeLiveSnapshotDetectPornConfigResponse DescribeLiveSnapshotDetectPornConfigWithOptions(DescribeLiveSnapshotDetectPornConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeLiveSnapshotDetectPornConfigResponse>(DoRequest("DescribeLiveSnapshotDetectPornConfig", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DescribeLiveSnapshotDetectPornConfigResponse> DescribeLiveSnapshotDetectPornConfigWithOptionsAsync(DescribeLiveSnapshotDetectPornConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeLiveSnapshotDetectPornConfigResponse>(await DoRequestAsync("DescribeLiveSnapshotDetectPornConfig", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
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

        public UpdateLiveDetectNotifyConfigResponse UpdateLiveDetectNotifyConfigWithOptions(UpdateLiveDetectNotifyConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<UpdateLiveDetectNotifyConfigResponse>(DoRequest("UpdateLiveDetectNotifyConfig", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
        }

        public async Task<UpdateLiveDetectNotifyConfigResponse> UpdateLiveDetectNotifyConfigWithOptionsAsync(UpdateLiveDetectNotifyConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<UpdateLiveDetectNotifyConfigResponse>(await DoRequestAsync("UpdateLiveDetectNotifyConfig", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
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

        public UpdateLiveSnapshotDetectPornConfigResponse UpdateLiveSnapshotDetectPornConfigWithOptions(UpdateLiveSnapshotDetectPornConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<UpdateLiveSnapshotDetectPornConfigResponse>(DoRequest("UpdateLiveSnapshotDetectPornConfig", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
        }

        public async Task<UpdateLiveSnapshotDetectPornConfigResponse> UpdateLiveSnapshotDetectPornConfigWithOptionsAsync(UpdateLiveSnapshotDetectPornConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<UpdateLiveSnapshotDetectPornConfigResponse>(await DoRequestAsync("UpdateLiveSnapshotDetectPornConfig", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
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

        public AddLiveRecordNotifyConfigResponse AddLiveRecordNotifyConfigWithOptions(AddLiveRecordNotifyConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<AddLiveRecordNotifyConfigResponse>(DoRequest("AddLiveRecordNotifyConfig", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
        }

        public async Task<AddLiveRecordNotifyConfigResponse> AddLiveRecordNotifyConfigWithOptionsAsync(AddLiveRecordNotifyConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<AddLiveRecordNotifyConfigResponse>(await DoRequestAsync("AddLiveRecordNotifyConfig", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
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

        public DeleteLiveStreamsNotifyUrlConfigResponse DeleteLiveStreamsNotifyUrlConfigWithOptions(DeleteLiveStreamsNotifyUrlConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DeleteLiveStreamsNotifyUrlConfigResponse>(DoRequest("DeleteLiveStreamsNotifyUrlConfig", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DeleteLiveStreamsNotifyUrlConfigResponse> DeleteLiveStreamsNotifyUrlConfigWithOptionsAsync(DeleteLiveStreamsNotifyUrlConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DeleteLiveStreamsNotifyUrlConfigResponse>(await DoRequestAsync("DeleteLiveStreamsNotifyUrlConfig", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
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

        public DeleteLiveRecordNotifyConfigResponse DeleteLiveRecordNotifyConfigWithOptions(DeleteLiveRecordNotifyConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DeleteLiveRecordNotifyConfigResponse>(DoRequest("DeleteLiveRecordNotifyConfig", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DeleteLiveRecordNotifyConfigResponse> DeleteLiveRecordNotifyConfigWithOptionsAsync(DeleteLiveRecordNotifyConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DeleteLiveRecordNotifyConfigResponse>(await DoRequestAsync("DeleteLiveRecordNotifyConfig", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
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

        public DescribeLiveRecordNotifyConfigResponse DescribeLiveRecordNotifyConfigWithOptions(DescribeLiveRecordNotifyConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeLiveRecordNotifyConfigResponse>(DoRequest("DescribeLiveRecordNotifyConfig", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DescribeLiveRecordNotifyConfigResponse> DescribeLiveRecordNotifyConfigWithOptionsAsync(DescribeLiveRecordNotifyConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeLiveRecordNotifyConfigResponse>(await DoRequestAsync("DescribeLiveRecordNotifyConfig", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
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

        public DescribeLiveStreamsNotifyUrlConfigResponse DescribeLiveStreamsNotifyUrlConfigWithOptions(DescribeLiveStreamsNotifyUrlConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeLiveStreamsNotifyUrlConfigResponse>(DoRequest("DescribeLiveStreamsNotifyUrlConfig", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DescribeLiveStreamsNotifyUrlConfigResponse> DescribeLiveStreamsNotifyUrlConfigWithOptionsAsync(DescribeLiveStreamsNotifyUrlConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeLiveStreamsNotifyUrlConfigResponse>(await DoRequestAsync("DescribeLiveStreamsNotifyUrlConfig", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
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

        public UpdateLiveRecordNotifyConfigResponse UpdateLiveRecordNotifyConfigWithOptions(UpdateLiveRecordNotifyConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<UpdateLiveRecordNotifyConfigResponse>(DoRequest("UpdateLiveRecordNotifyConfig", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
        }

        public async Task<UpdateLiveRecordNotifyConfigResponse> UpdateLiveRecordNotifyConfigWithOptionsAsync(UpdateLiveRecordNotifyConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<UpdateLiveRecordNotifyConfigResponse>(await DoRequestAsync("UpdateLiveRecordNotifyConfig", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
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

        public DescribeLiveStreamsBlockListResponse DescribeLiveStreamsBlockListWithOptions(DescribeLiveStreamsBlockListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeLiveStreamsBlockListResponse>(DoRequest("DescribeLiveStreamsBlockList", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DescribeLiveStreamsBlockListResponse> DescribeLiveStreamsBlockListWithOptionsAsync(DescribeLiveStreamsBlockListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeLiveStreamsBlockListResponse>(await DoRequestAsync("DescribeLiveStreamsBlockList", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
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

        public DescribeLiveStreamOnlineUserNumResponse DescribeLiveStreamOnlineUserNumWithOptions(DescribeLiveStreamOnlineUserNumRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeLiveStreamOnlineUserNumResponse>(DoRequest("DescribeLiveStreamOnlineUserNum", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DescribeLiveStreamOnlineUserNumResponse> DescribeLiveStreamOnlineUserNumWithOptionsAsync(DescribeLiveStreamOnlineUserNumRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeLiveStreamOnlineUserNumResponse>(await DoRequestAsync("DescribeLiveStreamOnlineUserNum", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
        }

        public DescribeLiveStreamOnlineUserNumResponse DescribeLiveStreamOnlineUserNum(DescribeLiveStreamOnlineUserNumRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeLiveStreamOnlineUserNumWithOptions(request, runtime);
        }

        public async Task<DescribeLiveStreamOnlineUserNumResponse> DescribeLiveStreamOnlineUserNumAsync(DescribeLiveStreamOnlineUserNumRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeLiveStreamOnlineUserNumWithOptionsAsync(request, runtime);
        }

        public DescribeLiveStreamsPublishListResponse DescribeLiveStreamsPublishListWithOptions(DescribeLiveStreamsPublishListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeLiveStreamsPublishListResponse>(DoRequest("DescribeLiveStreamsPublishList", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DescribeLiveStreamsPublishListResponse> DescribeLiveStreamsPublishListWithOptionsAsync(DescribeLiveStreamsPublishListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeLiveStreamsPublishListResponse>(await DoRequestAsync("DescribeLiveStreamsPublishList", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
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

        public DescribeLiveStreamsOnlineListResponse DescribeLiveStreamsOnlineListWithOptions(DescribeLiveStreamsOnlineListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeLiveStreamsOnlineListResponse>(DoRequest("DescribeLiveStreamsOnlineList", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DescribeLiveStreamsOnlineListResponse> DescribeLiveStreamsOnlineListWithOptionsAsync(DescribeLiveStreamsOnlineListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeLiveStreamsOnlineListResponse>(await DoRequestAsync("DescribeLiveStreamsOnlineList", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
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

        public DescribeLiveStreamsControlHistoryResponse DescribeLiveStreamsControlHistoryWithOptions(DescribeLiveStreamsControlHistoryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeLiveStreamsControlHistoryResponse>(DoRequest("DescribeLiveStreamsControlHistory", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DescribeLiveStreamsControlHistoryResponse> DescribeLiveStreamsControlHistoryWithOptionsAsync(DescribeLiveStreamsControlHistoryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeLiveStreamsControlHistoryResponse>(await DoRequestAsync("DescribeLiveStreamsControlHistory", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
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

        public AddLiveStreamTranscodeResponse AddLiveStreamTranscodeWithOptions(AddLiveStreamTranscodeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<AddLiveStreamTranscodeResponse>(DoRequest("AddLiveStreamTranscode", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
        }

        public async Task<AddLiveStreamTranscodeResponse> AddLiveStreamTranscodeWithOptionsAsync(AddLiveStreamTranscodeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<AddLiveStreamTranscodeResponse>(await DoRequestAsync("AddLiveStreamTranscode", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
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

        public DeleteLiveStreamTranscodeResponse DeleteLiveStreamTranscodeWithOptions(DeleteLiveStreamTranscodeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DeleteLiveStreamTranscodeResponse>(DoRequest("DeleteLiveStreamTranscode", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DeleteLiveStreamTranscodeResponse> DeleteLiveStreamTranscodeWithOptionsAsync(DeleteLiveStreamTranscodeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DeleteLiveStreamTranscodeResponse>(await DoRequestAsync("DeleteLiveStreamTranscode", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
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

        public DescribeLiveStreamsFrameRateAndBitRateDataResponse DescribeLiveStreamsFrameRateAndBitRateDataWithOptions(DescribeLiveStreamsFrameRateAndBitRateDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeLiveStreamsFrameRateAndBitRateDataResponse>(DoRequest("DescribeLiveStreamsFrameRateAndBitRateData", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DescribeLiveStreamsFrameRateAndBitRateDataResponse> DescribeLiveStreamsFrameRateAndBitRateDataWithOptionsAsync(DescribeLiveStreamsFrameRateAndBitRateDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeLiveStreamsFrameRateAndBitRateDataResponse>(await DoRequestAsync("DescribeLiveStreamsFrameRateAndBitRateData", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
        }

        public DescribeLiveStreamsFrameRateAndBitRateDataResponse DescribeLiveStreamsFrameRateAndBitRateData(DescribeLiveStreamsFrameRateAndBitRateDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeLiveStreamsFrameRateAndBitRateDataWithOptions(request, runtime);
        }

        public async Task<DescribeLiveStreamsFrameRateAndBitRateDataResponse> DescribeLiveStreamsFrameRateAndBitRateDataAsync(DescribeLiveStreamsFrameRateAndBitRateDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeLiveStreamsFrameRateAndBitRateDataWithOptionsAsync(request, runtime);
        }

        public ForbidLiveStreamResponse ForbidLiveStreamWithOptions(ForbidLiveStreamRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ForbidLiveStreamResponse>(DoRequest("ForbidLiveStream", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
        }

        public async Task<ForbidLiveStreamResponse> ForbidLiveStreamWithOptionsAsync(ForbidLiveStreamRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ForbidLiveStreamResponse>(await DoRequestAsync("ForbidLiveStream", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
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

        public DescribeLiveStreamTranscodeInfoResponse DescribeLiveStreamTranscodeInfoWithOptions(DescribeLiveStreamTranscodeInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeLiveStreamTranscodeInfoResponse>(DoRequest("DescribeLiveStreamTranscodeInfo", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DescribeLiveStreamTranscodeInfoResponse> DescribeLiveStreamTranscodeInfoWithOptionsAsync(DescribeLiveStreamTranscodeInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeLiveStreamTranscodeInfoResponse>(await DoRequestAsync("DescribeLiveStreamTranscodeInfo", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
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

        public SetLiveStreamsNotifyUrlConfigResponse SetLiveStreamsNotifyUrlConfigWithOptions(SetLiveStreamsNotifyUrlConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<SetLiveStreamsNotifyUrlConfigResponse>(DoRequest("SetLiveStreamsNotifyUrlConfig", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
        }

        public async Task<SetLiveStreamsNotifyUrlConfigResponse> SetLiveStreamsNotifyUrlConfigWithOptionsAsync(SetLiveStreamsNotifyUrlConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<SetLiveStreamsNotifyUrlConfigResponse>(await DoRequestAsync("SetLiveStreamsNotifyUrlConfig", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
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

        public ResumeLiveStreamResponse ResumeLiveStreamWithOptions(ResumeLiveStreamRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ResumeLiveStreamResponse>(DoRequest("ResumeLiveStream", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
        }

        public async Task<ResumeLiveStreamResponse> ResumeLiveStreamWithOptionsAsync(ResumeLiveStreamRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ResumeLiveStreamResponse>(await DoRequestAsync("ResumeLiveStream", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
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

        public AddLiveAppSnapshotConfigResponse AddLiveAppSnapshotConfigWithOptions(AddLiveAppSnapshotConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<AddLiveAppSnapshotConfigResponse>(DoRequest("AddLiveAppSnapshotConfig", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
        }

        public async Task<AddLiveAppSnapshotConfigResponse> AddLiveAppSnapshotConfigWithOptionsAsync(AddLiveAppSnapshotConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<AddLiveAppSnapshotConfigResponse>(await DoRequestAsync("AddLiveAppSnapshotConfig", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
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

        public AddLiveAppRecordConfigResponse AddLiveAppRecordConfigWithOptions(AddLiveAppRecordConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<AddLiveAppRecordConfigResponse>(DoRequest("AddLiveAppRecordConfig", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
        }

        public async Task<AddLiveAppRecordConfigResponse> AddLiveAppRecordConfigWithOptionsAsync(AddLiveAppRecordConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<AddLiveAppRecordConfigResponse>(await DoRequestAsync("AddLiveAppRecordConfig", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
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

        public DescribeLiveRecordConfigResponse DescribeLiveRecordConfigWithOptions(DescribeLiveRecordConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeLiveRecordConfigResponse>(DoRequest("DescribeLiveRecordConfig", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DescribeLiveRecordConfigResponse> DescribeLiveRecordConfigWithOptionsAsync(DescribeLiveRecordConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeLiveRecordConfigResponse>(await DoRequestAsync("DescribeLiveRecordConfig", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
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

        public DeleteLiveAppSnapshotConfigResponse DeleteLiveAppSnapshotConfigWithOptions(DeleteLiveAppSnapshotConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DeleteLiveAppSnapshotConfigResponse>(DoRequest("DeleteLiveAppSnapshotConfig", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DeleteLiveAppSnapshotConfigResponse> DeleteLiveAppSnapshotConfigWithOptionsAsync(DeleteLiveAppSnapshotConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DeleteLiveAppSnapshotConfigResponse>(await DoRequestAsync("DeleteLiveAppSnapshotConfig", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
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

        public DeleteLiveAppRecordConfigResponse DeleteLiveAppRecordConfigWithOptions(DeleteLiveAppRecordConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DeleteLiveAppRecordConfigResponse>(DoRequest("DeleteLiveAppRecordConfig", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DeleteLiveAppRecordConfigResponse> DeleteLiveAppRecordConfigWithOptionsAsync(DeleteLiveAppRecordConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DeleteLiveAppRecordConfigResponse>(await DoRequestAsync("DeleteLiveAppRecordConfig", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
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

        public CreateLiveStreamRecordIndexFilesResponse CreateLiveStreamRecordIndexFilesWithOptions(CreateLiveStreamRecordIndexFilesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CreateLiveStreamRecordIndexFilesResponse>(DoRequest("CreateLiveStreamRecordIndexFiles", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
        }

        public async Task<CreateLiveStreamRecordIndexFilesResponse> CreateLiveStreamRecordIndexFilesWithOptionsAsync(CreateLiveStreamRecordIndexFilesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CreateLiveStreamRecordIndexFilesResponse>(await DoRequestAsync("CreateLiveStreamRecordIndexFiles", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
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

        public DescribeLiveStreamSnapshotInfoResponse DescribeLiveStreamSnapshotInfoWithOptions(DescribeLiveStreamSnapshotInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeLiveStreamSnapshotInfoResponse>(DoRequest("DescribeLiveStreamSnapshotInfo", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DescribeLiveStreamSnapshotInfoResponse> DescribeLiveStreamSnapshotInfoWithOptionsAsync(DescribeLiveStreamSnapshotInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeLiveStreamSnapshotInfoResponse>(await DoRequestAsync("DescribeLiveStreamSnapshotInfo", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
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

        public DescribeLiveStreamRecordIndexFilesResponse DescribeLiveStreamRecordIndexFilesWithOptions(DescribeLiveStreamRecordIndexFilesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeLiveStreamRecordIndexFilesResponse>(DoRequest("DescribeLiveStreamRecordIndexFiles", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DescribeLiveStreamRecordIndexFilesResponse> DescribeLiveStreamRecordIndexFilesWithOptionsAsync(DescribeLiveStreamRecordIndexFilesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeLiveStreamRecordIndexFilesResponse>(await DoRequestAsync("DescribeLiveStreamRecordIndexFiles", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
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

        public DescribeLiveStreamRecordIndexFileResponse DescribeLiveStreamRecordIndexFileWithOptions(DescribeLiveStreamRecordIndexFileRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeLiveStreamRecordIndexFileResponse>(DoRequest("DescribeLiveStreamRecordIndexFile", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DescribeLiveStreamRecordIndexFileResponse> DescribeLiveStreamRecordIndexFileWithOptionsAsync(DescribeLiveStreamRecordIndexFileRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeLiveStreamRecordIndexFileResponse>(await DoRequestAsync("DescribeLiveStreamRecordIndexFile", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
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

        public DescribeLiveStreamRecordContentResponse DescribeLiveStreamRecordContentWithOptions(DescribeLiveStreamRecordContentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeLiveStreamRecordContentResponse>(DoRequest("DescribeLiveStreamRecordContent", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DescribeLiveStreamRecordContentResponse> DescribeLiveStreamRecordContentWithOptionsAsync(DescribeLiveStreamRecordContentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeLiveStreamRecordContentResponse>(await DoRequestAsync("DescribeLiveStreamRecordContent", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
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

        public DescribeLiveSnapshotConfigResponse DescribeLiveSnapshotConfigWithOptions(DescribeLiveSnapshotConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeLiveSnapshotConfigResponse>(DoRequest("DescribeLiveSnapshotConfig", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DescribeLiveSnapshotConfigResponse> DescribeLiveSnapshotConfigWithOptionsAsync(DescribeLiveSnapshotConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeLiveSnapshotConfigResponse>(await DoRequestAsync("DescribeLiveSnapshotConfig", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
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

        public UpdateLiveAppSnapshotConfigResponse UpdateLiveAppSnapshotConfigWithOptions(UpdateLiveAppSnapshotConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<UpdateLiveAppSnapshotConfigResponse>(DoRequest("UpdateLiveAppSnapshotConfig", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
        }

        public async Task<UpdateLiveAppSnapshotConfigResponse> UpdateLiveAppSnapshotConfigWithOptionsAsync(UpdateLiveAppSnapshotConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<UpdateLiveAppSnapshotConfigResponse>(await DoRequestAsync("UpdateLiveAppSnapshotConfig", "HTTPS", "POST", "2016-11-01", "AK", null, request.ToMap(), runtime));
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

    }
}
