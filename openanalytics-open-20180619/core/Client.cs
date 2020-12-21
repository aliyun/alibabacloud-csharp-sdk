// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Openanalytics_open20180619.Models;

namespace AlibabaCloud.SDK.Openanalytics_open20180619
{
    public class Client : AlibabaCloud.RPCClient.Client
    {

        public Client(AlibabaCloud.RPCClient.Models.Config config): base(config)
        {
            this._endpointRule = "central";
            this._endpointMap = new Dictionary<string, string>
            {
                {"cn-beijing", "openanalytics.cn-beijing.aliyuncs.com"},
                {"cn-zhangjiakou", "openanalytics.cn-zhangjiakou.aliyuncs.com"},
                {"cn-hangzhou", "openanalytics.cn-hangzhou.aliyuncs.com"},
                {"cn-shanghai", "openanalytics.cn-shanghai.aliyuncs.com"},
                {"cn-shenzhen", "openanalytics.cn-shenzhen.aliyuncs.com"},
                {"cn-hongkong", "openanalytics.cn-hongkong.aliyuncs.com"},
                {"ap-southeast-1", "openanalytics.ap-southeast-1.aliyuncs.com"},
                {"ap-southeast-2", "datalakeanalytics.ap-southeast-2.aliyuncs.com"},
                {"ap-southeast-3", "openanalytics.ap-southeast-3.aliyuncs.com"},
                {"ap-northeast-1", "datalakeanalytics.ap-northeast-1.aliyuncs.com"},
                {"eu-west-1", "openanalytics.eu-west-1.aliyuncs.com"},
                {"us-west-1", "openanalytics.us-west-1.aliyuncs.com"},
                {"us-east-1", "datalakeanalytics.us-east-1.aliyuncs.com"},
                {"eu-central-1", "datalakeanalytics.eu-central-1.aliyuncs.com"},
                {"ap-south-1", "openanalytics.ap-south-1.aliyuncs.com"},
                {"ap-northeast-2-pop", "openanalytics.ap-northeast-1.aliyuncs.com"},
                {"ap-southeast-5", "openanalytics.ap-southeast-5.aliyuncs.com"},
                {"cn-beijing-finance-1", "openanalytics.aliyuncs.com"},
                {"cn-beijing-finance-pop", "openanalytics.aliyuncs.com"},
                {"cn-beijing-gov-1", "openanalytics.aliyuncs.com"},
                {"cn-beijing-nu16-b01", "openanalytics.aliyuncs.com"},
                {"cn-chengdu", "openanalytics.aliyuncs.com"},
                {"cn-edge-1", "openanalytics.aliyuncs.com"},
                {"cn-fujian", "openanalytics.aliyuncs.com"},
                {"cn-haidian-cm12-c01", "openanalytics.aliyuncs.com"},
                {"cn-hangzhou-bj-b01", "openanalytics.aliyuncs.com"},
                {"cn-hangzhou-finance", "openanalytics.aliyuncs.com"},
                {"cn-hangzhou-internal-prod-1", "openanalytics.aliyuncs.com"},
                {"cn-hangzhou-internal-test-1", "openanalytics.aliyuncs.com"},
                {"cn-hangzhou-internal-test-2", "openanalytics.aliyuncs.com"},
                {"cn-hangzhou-internal-test-3", "openanalytics.aliyuncs.com"},
                {"cn-hangzhou-test-306", "openanalytics.aliyuncs.com"},
                {"cn-hongkong-finance-pop", "openanalytics.aliyuncs.com"},
                {"cn-huhehaote", "openanalytics.cn-huhehaote.aliyuncs.com"},
                {"cn-north-2-gov-1", "openanalytics.aliyuncs.com"},
                {"cn-qingdao", "openanalytics.cn-qingdao.aliyuncs.com"},
                {"cn-qingdao-nebula", "openanalytics.aliyuncs.com"},
                {"cn-shanghai-et15-b01", "openanalytics.aliyuncs.com"},
                {"cn-shanghai-et2-b01", "openanalytics.aliyuncs.com"},
                {"cn-shanghai-finance-1", "openanalytics.aliyuncs.com"},
                {"cn-shanghai-inner", "openanalytics.aliyuncs.com"},
                {"cn-shanghai-internal-test-1", "openanalytics.aliyuncs.com"},
                {"cn-shenzhen-finance-1", "openanalytics.aliyuncs.com"},
                {"cn-shenzhen-inner", "openanalytics.aliyuncs.com"},
                {"cn-shenzhen-st4-d01", "openanalytics.aliyuncs.com"},
                {"cn-shenzhen-su18-b01", "openanalytics.aliyuncs.com"},
                {"cn-wuhan", "openanalytics.aliyuncs.com"},
                {"cn-yushanfang", "openanalytics.aliyuncs.com"},
                {"cn-zhangbei-na61-b01", "openanalytics.aliyuncs.com"},
                {"cn-zhangjiakou-na62-a01", "openanalytics.aliyuncs.com"},
                {"cn-zhengzhou-nebula-1", "openanalytics.aliyuncs.com"},
                {"eu-west-1-oxs", "openanalytics.ap-northeast-1.aliyuncs.com"},
                {"me-east-1", "openanalytics.me-east-1.aliyuncs.com"},
                {"rus-west-1-pop", "openanalytics.ap-northeast-1.aliyuncs.com"},
            };
            CheckConfig(config);
            this._endpoint = GetEndpoint("openanalytics-open", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
        }


        public ValidateVirtualClusterNameResponse ValidateVirtualClusterNameWithOptions(ValidateVirtualClusterNameRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ValidateVirtualClusterNameResponse>(DoRequest("ValidateVirtualClusterName", "HTTPS", "POST", "2018-06-19", "AK", null, request.ToMap(), runtime));
        }

        public async Task<ValidateVirtualClusterNameResponse> ValidateVirtualClusterNameWithOptionsAsync(ValidateVirtualClusterNameRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ValidateVirtualClusterNameResponse>(await DoRequestAsync("ValidateVirtualClusterName", "HTTPS", "POST", "2018-06-19", "AK", null, request.ToMap(), runtime));
        }

        public ValidateVirtualClusterNameResponse ValidateVirtualClusterName(ValidateVirtualClusterNameRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ValidateVirtualClusterNameWithOptions(request, runtime);
        }

        public async Task<ValidateVirtualClusterNameResponse> ValidateVirtualClusterNameAsync(ValidateVirtualClusterNameRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ValidateVirtualClusterNameWithOptionsAsync(request, runtime);
        }

        public UpgradeInstanceResponse UpgradeInstanceWithOptions(UpgradeInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<UpgradeInstanceResponse>(DoRequest("UpgradeInstance", "HTTPS", "POST", "2018-06-19", "AK", null, request.ToMap(), runtime));
        }

        public async Task<UpgradeInstanceResponse> UpgradeInstanceWithOptionsAsync(UpgradeInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<UpgradeInstanceResponse>(await DoRequestAsync("UpgradeInstance", "HTTPS", "POST", "2018-06-19", "AK", null, request.ToMap(), runtime));
        }

        public UpgradeInstanceResponse UpgradeInstance(UpgradeInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpgradeInstanceWithOptions(request, runtime);
        }

        public async Task<UpgradeInstanceResponse> UpgradeInstanceAsync(UpgradeInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpgradeInstanceWithOptionsAsync(request, runtime);
        }

        public CreateInstanceResponse CreateInstanceWithOptions(CreateInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CreateInstanceResponse>(DoRequest("CreateInstance", "HTTPS", "POST", "2018-06-19", "AK", null, request.ToMap(), runtime));
        }

        public async Task<CreateInstanceResponse> CreateInstanceWithOptionsAsync(CreateInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CreateInstanceResponse>(await DoRequestAsync("CreateInstance", "HTTPS", "POST", "2018-06-19", "AK", null, request.ToMap(), runtime));
        }

        public CreateInstanceResponse CreateInstance(CreateInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateInstanceWithOptions(request, runtime);
        }

        public async Task<CreateInstanceResponse> CreateInstanceAsync(CreateInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateInstanceWithOptionsAsync(request, runtime);
        }

        public ReleaseInstanceResponse ReleaseInstanceWithOptions(ReleaseInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ReleaseInstanceResponse>(DoRequest("ReleaseInstance", "HTTPS", "POST", "2018-06-19", "AK", null, request.ToMap(), runtime));
        }

        public async Task<ReleaseInstanceResponse> ReleaseInstanceWithOptionsAsync(ReleaseInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ReleaseInstanceResponse>(await DoRequestAsync("ReleaseInstance", "HTTPS", "POST", "2018-06-19", "AK", null, request.ToMap(), runtime));
        }

        public ReleaseInstanceResponse ReleaseInstance(ReleaseInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ReleaseInstanceWithOptions(request, runtime);
        }

        public async Task<ReleaseInstanceResponse> ReleaseInstanceAsync(ReleaseInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ReleaseInstanceWithOptionsAsync(request, runtime);
        }

        public GetJobDetailResponse GetJobDetailWithOptions(GetJobDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetJobDetailResponse>(DoRequest("GetJobDetail", "HTTPS", "POST", "2018-06-19", "AK", null, request.ToMap(), runtime));
        }

        public async Task<GetJobDetailResponse> GetJobDetailWithOptionsAsync(GetJobDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetJobDetailResponse>(await DoRequestAsync("GetJobDetail", "HTTPS", "POST", "2018-06-19", "AK", null, request.ToMap(), runtime));
        }

        public GetJobDetailResponse GetJobDetail(GetJobDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetJobDetailWithOptions(request, runtime);
        }

        public async Task<GetJobDetailResponse> GetJobDetailAsync(GetJobDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetJobDetailWithOptionsAsync(request, runtime);
        }

        public GetJobStatusResponse GetJobStatusWithOptions(GetJobStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetJobStatusResponse>(DoRequest("GetJobStatus", "HTTPS", "POST", "2018-06-19", "AK", null, request.ToMap(), runtime));
        }

        public async Task<GetJobStatusResponse> GetJobStatusWithOptionsAsync(GetJobStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetJobStatusResponse>(await DoRequestAsync("GetJobStatus", "HTTPS", "POST", "2018-06-19", "AK", null, request.ToMap(), runtime));
        }

        public GetJobStatusResponse GetJobStatus(GetJobStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetJobStatusWithOptions(request, runtime);
        }

        public async Task<GetJobStatusResponse> GetJobStatusAsync(GetJobStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetJobStatusWithOptionsAsync(request, runtime);
        }

        public KillSparkJobResponse KillSparkJobWithOptions(KillSparkJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<KillSparkJobResponse>(DoRequest("KillSparkJob", "HTTPS", "POST", "2018-06-19", "AK", null, request.ToMap(), runtime));
        }

        public async Task<KillSparkJobResponse> KillSparkJobWithOptionsAsync(KillSparkJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<KillSparkJobResponse>(await DoRequestAsync("KillSparkJob", "HTTPS", "POST", "2018-06-19", "AK", null, request.ToMap(), runtime));
        }

        public KillSparkJobResponse KillSparkJob(KillSparkJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return KillSparkJobWithOptions(request, runtime);
        }

        public async Task<KillSparkJobResponse> KillSparkJobAsync(KillSparkJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await KillSparkJobWithOptionsAsync(request, runtime);
        }

        public SubmitSparkJobResponse SubmitSparkJobWithOptions(SubmitSparkJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<SubmitSparkJobResponse>(DoRequest("SubmitSparkJob", "HTTPS", "POST", "2018-06-19", "AK", null, request.ToMap(), runtime));
        }

        public async Task<SubmitSparkJobResponse> SubmitSparkJobWithOptionsAsync(SubmitSparkJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<SubmitSparkJobResponse>(await DoRequestAsync("SubmitSparkJob", "HTTPS", "POST", "2018-06-19", "AK", null, request.ToMap(), runtime));
        }

        public SubmitSparkJobResponse SubmitSparkJob(SubmitSparkJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SubmitSparkJobWithOptions(request, runtime);
        }

        public async Task<SubmitSparkJobResponse> SubmitSparkJobAsync(SubmitSparkJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SubmitSparkJobWithOptionsAsync(request, runtime);
        }

        public GetJobLogResponse GetJobLogWithOptions(GetJobLogRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetJobLogResponse>(DoRequest("GetJobLog", "HTTPS", "POST", "2018-06-19", "AK", null, request.ToMap(), runtime));
        }

        public async Task<GetJobLogResponse> GetJobLogWithOptionsAsync(GetJobLogRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetJobLogResponse>(await DoRequestAsync("GetJobLog", "HTTPS", "POST", "2018-06-19", "AK", null, request.ToMap(), runtime));
        }

        public GetJobLogResponse GetJobLog(GetJobLogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetJobLogWithOptions(request, runtime);
        }

        public async Task<GetJobLogResponse> GetJobLogAsync(GetJobLogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetJobLogWithOptionsAsync(request, runtime);
        }

        public ListSparkJobResponse ListSparkJobWithOptions(ListSparkJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ListSparkJobResponse>(DoRequest("ListSparkJob", "HTTPS", "POST", "2018-06-19", "AK", null, request.ToMap(), runtime));
        }

        public async Task<ListSparkJobResponse> ListSparkJobWithOptionsAsync(ListSparkJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ListSparkJobResponse>(await DoRequestAsync("ListSparkJob", "HTTPS", "POST", "2018-06-19", "AK", null, request.ToMap(), runtime));
        }

        public ListSparkJobResponse ListSparkJob(ListSparkJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListSparkJobWithOptions(request, runtime);
        }

        public async Task<ListSparkJobResponse> ListSparkJobAsync(ListSparkJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListSparkJobWithOptionsAsync(request, runtime);
        }

        public GetAllowIPResponse GetAllowIPWithOptions(GetAllowIPRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetAllowIPResponse>(DoRequest("GetAllowIP", "HTTPS", "POST", "2018-06-19", "AK", null, request.ToMap(), runtime));
        }

        public async Task<GetAllowIPResponse> GetAllowIPWithOptionsAsync(GetAllowIPRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetAllowIPResponse>(await DoRequestAsync("GetAllowIP", "HTTPS", "POST", "2018-06-19", "AK", null, request.ToMap(), runtime));
        }

        public GetAllowIPResponse GetAllowIP(GetAllowIPRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetAllowIPWithOptions(request, runtime);
        }

        public async Task<GetAllowIPResponse> GetAllowIPAsync(GetAllowIPRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetAllowIPWithOptionsAsync(request, runtime);
        }

        public SetAllowIPResponse SetAllowIPWithOptions(SetAllowIPRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<SetAllowIPResponse>(DoRequest("SetAllowIP", "HTTPS", "POST", "2018-06-19", "AK", null, request.ToMap(), runtime));
        }

        public async Task<SetAllowIPResponse> SetAllowIPWithOptionsAsync(SetAllowIPRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<SetAllowIPResponse>(await DoRequestAsync("SetAllowIP", "HTTPS", "POST", "2018-06-19", "AK", null, request.ToMap(), runtime));
        }

        public SetAllowIPResponse SetAllowIP(SetAllowIPRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetAllowIPWithOptions(request, runtime);
        }

        public async Task<SetAllowIPResponse> SetAllowIPAsync(SetAllowIPRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetAllowIPWithOptionsAsync(request, runtime);
        }

        public ResetMainPasswordResponse ResetMainPasswordWithOptions(ResetMainPasswordRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ResetMainPasswordResponse>(DoRequest("ResetMainPassword", "HTTPS", "POST", "2018-06-19", "AK", null, request.ToMap(), runtime));
        }

        public async Task<ResetMainPasswordResponse> ResetMainPasswordWithOptionsAsync(ResetMainPasswordRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ResetMainPasswordResponse>(await DoRequestAsync("ResetMainPassword", "HTTPS", "POST", "2018-06-19", "AK", null, request.ToMap(), runtime));
        }

        public ResetMainPasswordResponse ResetMainPassword(ResetMainPasswordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ResetMainPasswordWithOptions(request, runtime);
        }

        public async Task<ResetMainPasswordResponse> ResetMainPasswordAsync(ResetMainPasswordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ResetMainPasswordWithOptionsAsync(request, runtime);
        }

        public UnSubscribeRegionResponse UnSubscribeRegionWithOptions(UnSubscribeRegionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<UnSubscribeRegionResponse>(DoRequest("UnSubscribeRegion", "HTTPS", "POST", "2018-06-19", "AK", null, request.ToMap(), runtime));
        }

        public async Task<UnSubscribeRegionResponse> UnSubscribeRegionWithOptionsAsync(UnSubscribeRegionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<UnSubscribeRegionResponse>(await DoRequestAsync("UnSubscribeRegion", "HTTPS", "POST", "2018-06-19", "AK", null, request.ToMap(), runtime));
        }

        public UnSubscribeRegionResponse UnSubscribeRegion(UnSubscribeRegionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UnSubscribeRegionWithOptions(request, runtime);
        }

        public async Task<UnSubscribeRegionResponse> UnSubscribeRegionAsync(UnSubscribeRegionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UnSubscribeRegionWithOptionsAsync(request, runtime);
        }

        public QueryAccountListResponse QueryAccountListWithOptions(QueryAccountListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<QueryAccountListResponse>(DoRequest("QueryAccountList", "HTTPS", "POST", "2018-06-19", "AK", null, request.ToMap(), runtime));
        }

        public async Task<QueryAccountListResponse> QueryAccountListWithOptionsAsync(QueryAccountListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<QueryAccountListResponse>(await DoRequestAsync("QueryAccountList", "HTTPS", "POST", "2018-06-19", "AK", null, request.ToMap(), runtime));
        }

        public QueryAccountListResponse QueryAccountList(QueryAccountListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryAccountListWithOptions(request, runtime);
        }

        public async Task<QueryAccountListResponse> QueryAccountListAsync(QueryAccountListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryAccountListWithOptionsAsync(request, runtime);
        }

        public DeleteAccountResponse DeleteAccountWithOptions(DeleteAccountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DeleteAccountResponse>(DoRequest("DeleteAccount", "HTTPS", "POST", "2018-06-19", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DeleteAccountResponse> DeleteAccountWithOptionsAsync(DeleteAccountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DeleteAccountResponse>(await DoRequestAsync("DeleteAccount", "HTTPS", "POST", "2018-06-19", "AK", null, request.ToMap(), runtime));
        }

        public DeleteAccountResponse DeleteAccount(DeleteAccountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteAccountWithOptions(request, runtime);
        }

        public async Task<DeleteAccountResponse> DeleteAccountAsync(DeleteAccountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteAccountWithOptionsAsync(request, runtime);
        }

        public AddAccountResponse AddAccountWithOptions(AddAccountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<AddAccountResponse>(DoRequest("AddAccount", "HTTPS", "POST", "2018-06-19", "AK", null, request.ToMap(), runtime));
        }

        public async Task<AddAccountResponse> AddAccountWithOptionsAsync(AddAccountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<AddAccountResponse>(await DoRequestAsync("AddAccount", "HTTPS", "POST", "2018-06-19", "AK", null, request.ToMap(), runtime));
        }

        public AddAccountResponse AddAccount(AddAccountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddAccountWithOptions(request, runtime);
        }

        public async Task<AddAccountResponse> AddAccountAsync(AddAccountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddAccountWithOptionsAsync(request, runtime);
        }

        public UpdateAccountPasswordResponse UpdateAccountPasswordWithOptions(UpdateAccountPasswordRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<UpdateAccountPasswordResponse>(DoRequest("UpdateAccountPassword", "HTTPS", "POST", "2018-06-19", "AK", null, request.ToMap(), runtime));
        }

        public async Task<UpdateAccountPasswordResponse> UpdateAccountPasswordWithOptionsAsync(UpdateAccountPasswordRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<UpdateAccountPasswordResponse>(await DoRequestAsync("UpdateAccountPassword", "HTTPS", "POST", "2018-06-19", "AK", null, request.ToMap(), runtime));
        }

        public UpdateAccountPasswordResponse UpdateAccountPassword(UpdateAccountPasswordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateAccountPasswordWithOptions(request, runtime);
        }

        public async Task<UpdateAccountPasswordResponse> UpdateAccountPasswordAsync(UpdateAccountPasswordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateAccountPasswordWithOptionsAsync(request, runtime);
        }

        public RemoveEndPointResponse RemoveEndPointWithOptions(RemoveEndPointRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<RemoveEndPointResponse>(DoRequest("RemoveEndPoint", "HTTPS", "POST", "2018-06-19", "AK", null, request.ToMap(), runtime));
        }

        public async Task<RemoveEndPointResponse> RemoveEndPointWithOptionsAsync(RemoveEndPointRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<RemoveEndPointResponse>(await DoRequestAsync("RemoveEndPoint", "HTTPS", "POST", "2018-06-19", "AK", null, request.ToMap(), runtime));
        }

        public RemoveEndPointResponse RemoveEndPoint(RemoveEndPointRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RemoveEndPointWithOptions(request, runtime);
        }

        public async Task<RemoveEndPointResponse> RemoveEndPointAsync(RemoveEndPointRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RemoveEndPointWithOptionsAsync(request, runtime);
        }

        public QueryEndPointListResponse QueryEndPointListWithOptions(QueryEndPointListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<QueryEndPointListResponse>(DoRequest("QueryEndPointList", "HTTPS", "POST", "2018-06-19", "AK", null, request.ToMap(), runtime));
        }

        public async Task<QueryEndPointListResponse> QueryEndPointListWithOptionsAsync(QueryEndPointListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<QueryEndPointListResponse>(await DoRequestAsync("QueryEndPointList", "HTTPS", "POST", "2018-06-19", "AK", null, request.ToMap(), runtime));
        }

        public QueryEndPointListResponse QueryEndPointList(QueryEndPointListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryEndPointListWithOptions(request, runtime);
        }

        public async Task<QueryEndPointListResponse> QueryEndPointListAsync(QueryEndPointListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryEndPointListWithOptionsAsync(request, runtime);
        }

        public AddEndPointResponse AddEndPointWithOptions(AddEndPointRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<AddEndPointResponse>(DoRequest("AddEndPoint", "HTTPS", "POST", "2018-06-19", "AK", null, request.ToMap(), runtime));
        }

        public async Task<AddEndPointResponse> AddEndPointWithOptionsAsync(AddEndPointRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<AddEndPointResponse>(await DoRequestAsync("AddEndPoint", "HTTPS", "POST", "2018-06-19", "AK", null, request.ToMap(), runtime));
        }

        public AddEndPointResponse AddEndPoint(AddEndPointRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddEndPointWithOptions(request, runtime);
        }

        public async Task<AddEndPointResponse> AddEndPointAsync(AddEndPointRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddEndPointWithOptionsAsync(request, runtime);
        }

        public GetEndPointResponse GetEndPointWithOptions(GetEndPointRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetEndPointResponse>(DoRequest("GetEndPoint", "HTTPS", "POST", "2018-06-19", "AK", null, request.ToMap(), runtime));
        }

        public async Task<GetEndPointResponse> GetEndPointWithOptionsAsync(GetEndPointRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetEndPointResponse>(await DoRequestAsync("GetEndPoint", "HTTPS", "POST", "2018-06-19", "AK", null, request.ToMap(), runtime));
        }

        public GetEndPointResponse GetEndPoint(GetEndPointRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetEndPointWithOptions(request, runtime);
        }

        public async Task<GetEndPointResponse> GetEndPointAsync(GetEndPointRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetEndPointWithOptionsAsync(request, runtime);
        }

        public GetEndPointByDomainResponse GetEndPointByDomainWithOptions(GetEndPointByDomainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetEndPointByDomainResponse>(DoRequest("GetEndPointByDomain", "HTTPS", "POST", "2018-06-19", "AK", null, request.ToMap(), runtime));
        }

        public async Task<GetEndPointByDomainResponse> GetEndPointByDomainWithOptionsAsync(GetEndPointByDomainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetEndPointByDomainResponse>(await DoRequestAsync("GetEndPointByDomain", "HTTPS", "POST", "2018-06-19", "AK", null, request.ToMap(), runtime));
        }

        public GetEndPointByDomainResponse GetEndPointByDomain(GetEndPointByDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetEndPointByDomainWithOptions(request, runtime);
        }

        public async Task<GetEndPointByDomainResponse> GetEndPointByDomainAsync(GetEndPointByDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetEndPointByDomainWithOptionsAsync(request, runtime);
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
