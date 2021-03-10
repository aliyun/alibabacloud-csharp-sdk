// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Iot20180120.Models;

namespace AlibabaCloud.SDK.Iot20180120
{
    public class Client : AlibabaCloud.RPCClient.Client
    {

        public Client(AlibabaCloud.RPCClient.Models.Config config): base(config)
        {
            this._endpointRule = "regional";
            this._endpointMap = new Dictionary<string, string>
            {
                {"ap-northeast-2-pop", "iot.ap-northeast-1.aliyuncs.com"},
                {"ap-south-1", "iot.ap-northeast-1.aliyuncs.com"},
                {"ap-southeast-2", "iot.ap-northeast-1.aliyuncs.com"},
                {"ap-southeast-3", "iot.ap-northeast-1.aliyuncs.com"},
                {"ap-southeast-5", "iot.ap-northeast-1.aliyuncs.com"},
                {"cn-beijing", "iot.aliyuncs.com"},
                {"cn-beijing-finance-1", "iot.aliyuncs.com"},
                {"cn-beijing-finance-pop", "iot.aliyuncs.com"},
                {"cn-beijing-gov-1", "iot.aliyuncs.com"},
                {"cn-beijing-nu16-b01", "iot.aliyuncs.com"},
                {"cn-chengdu", "iot.aliyuncs.com"},
                {"cn-edge-1", "iot.aliyuncs.com"},
                {"cn-fujian", "iot.aliyuncs.com"},
                {"cn-haidian-cm12-c01", "iot.aliyuncs.com"},
                {"cn-hangzhou-bj-b01", "iot.aliyuncs.com"},
                {"cn-hangzhou-finance", "iot.aliyuncs.com"},
                {"cn-hangzhou-internal-prod-1", "iot.aliyuncs.com"},
                {"cn-hangzhou-internal-test-1", "iot.aliyuncs.com"},
                {"cn-hangzhou-internal-test-2", "iot.aliyuncs.com"},
                {"cn-hangzhou-internal-test-3", "iot.aliyuncs.com"},
                {"cn-hangzhou-test-306", "iot.aliyuncs.com"},
                {"cn-hongkong", "iot.aliyuncs.com"},
                {"cn-hongkong-finance-pop", "iot.aliyuncs.com"},
                {"cn-huhehaote", "iot.aliyuncs.com"},
                {"cn-north-2-gov-1", "iot.aliyuncs.com"},
                {"cn-qingdao", "iot.aliyuncs.com"},
                {"cn-qingdao-nebula", "iot.aliyuncs.com"},
                {"cn-shanghai-et15-b01", "iot.aliyuncs.com"},
                {"cn-shanghai-et2-b01", "iot.aliyuncs.com"},
                {"cn-shanghai-finance-1", "iot.aliyuncs.com"},
                {"cn-shanghai-inner", "iot.aliyuncs.com"},
                {"cn-shanghai-internal-test-1", "iot.aliyuncs.com"},
                {"cn-shenzhen", "iot.aliyuncs.com"},
                {"cn-shenzhen-finance-1", "iot.aliyuncs.com"},
                {"cn-shenzhen-inner", "iot.aliyuncs.com"},
                {"cn-shenzhen-st4-d01", "iot.aliyuncs.com"},
                {"cn-shenzhen-su18-b01", "iot.aliyuncs.com"},
                {"cn-wuhan", "iot.aliyuncs.com"},
                {"cn-yushanfang", "iot.aliyuncs.com"},
                {"cn-zhangbei-na61-b01", "iot.aliyuncs.com"},
                {"cn-zhangjiakou", "iot.aliyuncs.com"},
                {"cn-zhangjiakou-na62-a01", "iot.aliyuncs.com"},
                {"cn-zhengzhou-nebula-1", "iot.aliyuncs.com"},
                {"eu-west-1", "iot.ap-northeast-1.aliyuncs.com"},
                {"eu-west-1-oxs", "iot.ap-northeast-1.aliyuncs.com"},
                {"me-east-1", "iot.ap-northeast-1.aliyuncs.com"},
                {"rus-west-1-pop", "iot.ap-northeast-1.aliyuncs.com"},
            };
            CheckConfig(config);
            this._endpoint = GetEndpoint("iot", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
        }


        public ListAnalyticsDataResponse ListAnalyticsDataWithOptions(ListAnalyticsDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ListAnalyticsDataResponse>(DoRequest("ListAnalyticsData", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<ListAnalyticsDataResponse> ListAnalyticsDataWithOptionsAsync(ListAnalyticsDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ListAnalyticsDataResponse>(await DoRequestAsync("ListAnalyticsData", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public ListAnalyticsDataResponse ListAnalyticsData(ListAnalyticsDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListAnalyticsDataWithOptions(request, runtime);
        }

        public async Task<ListAnalyticsDataResponse> ListAnalyticsDataAsync(ListAnalyticsDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListAnalyticsDataWithOptionsAsync(request, runtime);
        }

        public BatchBindDevicesIntoProjectResponse BatchBindDevicesIntoProjectWithOptions(BatchBindDevicesIntoProjectRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<BatchBindDevicesIntoProjectResponse>(DoRequest("BatchBindDevicesIntoProject", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<BatchBindDevicesIntoProjectResponse> BatchBindDevicesIntoProjectWithOptionsAsync(BatchBindDevicesIntoProjectRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<BatchBindDevicesIntoProjectResponse>(await DoRequestAsync("BatchBindDevicesIntoProject", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public BatchBindDevicesIntoProjectResponse BatchBindDevicesIntoProject(BatchBindDevicesIntoProjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return BatchBindDevicesIntoProjectWithOptions(request, runtime);
        }

        public async Task<BatchBindDevicesIntoProjectResponse> BatchBindDevicesIntoProjectAsync(BatchBindDevicesIntoProjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await BatchBindDevicesIntoProjectWithOptionsAsync(request, runtime);
        }

        public BatchBindProductsIntoProjectResponse BatchBindProductsIntoProjectWithOptions(BatchBindProductsIntoProjectRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<BatchBindProductsIntoProjectResponse>(DoRequest("BatchBindProductsIntoProject", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<BatchBindProductsIntoProjectResponse> BatchBindProductsIntoProjectWithOptionsAsync(BatchBindProductsIntoProjectRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<BatchBindProductsIntoProjectResponse>(await DoRequestAsync("BatchBindProductsIntoProject", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public BatchBindProductsIntoProjectResponse BatchBindProductsIntoProject(BatchBindProductsIntoProjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return BatchBindProductsIntoProjectWithOptions(request, runtime);
        }

        public async Task<BatchBindProductsIntoProjectResponse> BatchBindProductsIntoProjectAsync(BatchBindProductsIntoProjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await BatchBindProductsIntoProjectWithOptionsAsync(request, runtime);
        }

        public BatchUnbindProjectDevicesResponse BatchUnbindProjectDevicesWithOptions(BatchUnbindProjectDevicesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<BatchUnbindProjectDevicesResponse>(DoRequest("BatchUnbindProjectDevices", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<BatchUnbindProjectDevicesResponse> BatchUnbindProjectDevicesWithOptionsAsync(BatchUnbindProjectDevicesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<BatchUnbindProjectDevicesResponse>(await DoRequestAsync("BatchUnbindProjectDevices", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public BatchUnbindProjectDevicesResponse BatchUnbindProjectDevices(BatchUnbindProjectDevicesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return BatchUnbindProjectDevicesWithOptions(request, runtime);
        }

        public async Task<BatchUnbindProjectDevicesResponse> BatchUnbindProjectDevicesAsync(BatchUnbindProjectDevicesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await BatchUnbindProjectDevicesWithOptionsAsync(request, runtime);
        }

        public BatchUnbindProjectProductsResponse BatchUnbindProjectProductsWithOptions(BatchUnbindProjectProductsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<BatchUnbindProjectProductsResponse>(DoRequest("BatchUnbindProjectProducts", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<BatchUnbindProjectProductsResponse> BatchUnbindProjectProductsWithOptionsAsync(BatchUnbindProjectProductsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<BatchUnbindProjectProductsResponse>(await DoRequestAsync("BatchUnbindProjectProducts", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public BatchUnbindProjectProductsResponse BatchUnbindProjectProducts(BatchUnbindProjectProductsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return BatchUnbindProjectProductsWithOptions(request, runtime);
        }

        public async Task<BatchUnbindProjectProductsResponse> BatchUnbindProjectProductsAsync(BatchUnbindProjectProductsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await BatchUnbindProjectProductsWithOptionsAsync(request, runtime);
        }

        public SyncSpeechByCombinationResponse SyncSpeechByCombinationWithOptions(SyncSpeechByCombinationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<SyncSpeechByCombinationResponse>(DoRequest("SyncSpeechByCombination", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<SyncSpeechByCombinationResponse> SyncSpeechByCombinationWithOptionsAsync(SyncSpeechByCombinationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<SyncSpeechByCombinationResponse>(await DoRequestAsync("SyncSpeechByCombination", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public SyncSpeechByCombinationResponse SyncSpeechByCombination(SyncSpeechByCombinationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SyncSpeechByCombinationWithOptions(request, runtime);
        }

        public async Task<SyncSpeechByCombinationResponse> SyncSpeechByCombinationAsync(SyncSpeechByCombinationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SyncSpeechByCombinationWithOptionsAsync(request, runtime);
        }

        public OpenIotServiceResponse OpenIotServiceWithOptions(OpenIotServiceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<OpenIotServiceResponse>(DoRequest("OpenIotService", "HTTPS", "POST", "2018-01-20", "AK,APP,PrivateKey,BearerToken", null, request.ToMap(), runtime));
        }

        public async Task<OpenIotServiceResponse> OpenIotServiceWithOptionsAsync(OpenIotServiceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<OpenIotServiceResponse>(await DoRequestAsync("OpenIotService", "HTTPS", "POST", "2018-01-20", "AK,APP,PrivateKey,BearerToken", null, request.ToMap(), runtime));
        }

        public OpenIotServiceResponse OpenIotService(OpenIotServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return OpenIotServiceWithOptions(request, runtime);
        }

        public async Task<OpenIotServiceResponse> OpenIotServiceAsync(OpenIotServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await OpenIotServiceWithOptionsAsync(request, runtime);
        }

        public CreateRulengDistributeJobResponse CreateRulengDistributeJobWithOptions(CreateRulengDistributeJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CreateRulengDistributeJobResponse>(DoRequest("CreateRulengDistributeJob", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<CreateRulengDistributeJobResponse> CreateRulengDistributeJobWithOptionsAsync(CreateRulengDistributeJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CreateRulengDistributeJobResponse>(await DoRequestAsync("CreateRulengDistributeJob", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public CreateRulengDistributeJobResponse CreateRulengDistributeJob(CreateRulengDistributeJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateRulengDistributeJobWithOptions(request, runtime);
        }

        public async Task<CreateRulengDistributeJobResponse> CreateRulengDistributeJobAsync(CreateRulengDistributeJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateRulengDistributeJobWithOptionsAsync(request, runtime);
        }

        public ListTaskByPageResponse ListTaskByPageWithOptions(ListTaskByPageRequest tmp, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmp);
            ListTaskByPageShrinkRequest request = new ListTaskByPageShrinkRequest();
            AlibabaCloud.Commons.Common.Convert(tmp, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmp.Device))
            {
                request.DeviceShrink = AlibabaCloud.TeaUtil.Common.ToJSONString(tmp.Device);
            }
            return TeaModel.ToObject<ListTaskByPageResponse>(DoRequest("ListTaskByPage", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<ListTaskByPageResponse> ListTaskByPageWithOptionsAsync(ListTaskByPageRequest tmp, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmp);
            ListTaskByPageShrinkRequest request = new ListTaskByPageShrinkRequest();
            AlibabaCloud.Commons.Common.Convert(tmp, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmp.Device))
            {
                request.DeviceShrink = AlibabaCloud.TeaUtil.Common.ToJSONString(tmp.Device);
            }
            return TeaModel.ToObject<ListTaskByPageResponse>(await DoRequestAsync("ListTaskByPage", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public ListTaskByPageResponse ListTaskByPage(ListTaskByPageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListTaskByPageWithOptions(request, runtime);
        }

        public async Task<ListTaskByPageResponse> ListTaskByPageAsync(ListTaskByPageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListTaskByPageWithOptionsAsync(request, runtime);
        }

        public ListTaskResponse ListTaskWithOptions(ListTaskRequest tmp, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmp);
            ListTaskShrinkRequest request = new ListTaskShrinkRequest();
            AlibabaCloud.Commons.Common.Convert(tmp, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmp.Device))
            {
                request.DeviceShrink = AlibabaCloud.TeaUtil.Common.ToJSONString(tmp.Device);
            }
            return TeaModel.ToObject<ListTaskResponse>(DoRequest("ListTask", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<ListTaskResponse> ListTaskWithOptionsAsync(ListTaskRequest tmp, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmp);
            ListTaskShrinkRequest request = new ListTaskShrinkRequest();
            AlibabaCloud.Commons.Common.Convert(tmp, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmp.Device))
            {
                request.DeviceShrink = AlibabaCloud.TeaUtil.Common.ToJSONString(tmp.Device);
            }
            return TeaModel.ToObject<ListTaskResponse>(await DoRequestAsync("ListTask", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public ListTaskResponse ListTask(ListTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListTaskWithOptions(request, runtime);
        }

        public async Task<ListTaskResponse> ListTaskAsync(ListTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListTaskWithOptionsAsync(request, runtime);
        }

        public QueryJobStatisticsResponse QueryJobStatisticsWithOptions(QueryJobStatisticsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<QueryJobStatisticsResponse>(DoRequest("QueryJobStatistics", "HTTPS", "GET", "2018-01-20", "AK", request.ToMap(), null, runtime));
        }

        public async Task<QueryJobStatisticsResponse> QueryJobStatisticsWithOptionsAsync(QueryJobStatisticsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<QueryJobStatisticsResponse>(await DoRequestAsync("QueryJobStatistics", "HTTPS", "GET", "2018-01-20", "AK", request.ToMap(), null, runtime));
        }

        public QueryJobStatisticsResponse QueryJobStatistics(QueryJobStatisticsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryJobStatisticsWithOptions(request, runtime);
        }

        public async Task<QueryJobStatisticsResponse> QueryJobStatisticsAsync(QueryJobStatisticsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryJobStatisticsWithOptionsAsync(request, runtime);
        }

        public DeleteJobResponse DeleteJobWithOptions(DeleteJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DeleteJobResponse>(DoRequest("DeleteJob", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DeleteJobResponse> DeleteJobWithOptionsAsync(DeleteJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DeleteJobResponse>(await DoRequestAsync("DeleteJob", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public DeleteJobResponse DeleteJob(DeleteJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteJobWithOptions(request, runtime);
        }

        public async Task<DeleteJobResponse> DeleteJobAsync(DeleteJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteJobWithOptionsAsync(request, runtime);
        }

        public CancelJobResponse CancelJobWithOptions(CancelJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CancelJobResponse>(DoRequest("CancelJob", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<CancelJobResponse> CancelJobWithOptionsAsync(CancelJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CancelJobResponse>(await DoRequestAsync("CancelJob", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public CancelJobResponse CancelJob(CancelJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CancelJobWithOptions(request, runtime);
        }

        public async Task<CancelJobResponse> CancelJobAsync(CancelJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CancelJobWithOptionsAsync(request, runtime);
        }

        public ListJobResponse ListJobWithOptions(ListJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ListJobResponse>(DoRequest("ListJob", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<ListJobResponse> ListJobWithOptionsAsync(ListJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ListJobResponse>(await DoRequestAsync("ListJob", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public ListJobResponse ListJob(ListJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListJobWithOptions(request, runtime);
        }

        public async Task<ListJobResponse> ListJobAsync(ListJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListJobWithOptionsAsync(request, runtime);
        }

        public QueryJobResponse QueryJobWithOptions(QueryJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<QueryJobResponse>(DoRequest("QueryJob", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<QueryJobResponse> QueryJobWithOptionsAsync(QueryJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<QueryJobResponse>(await DoRequestAsync("QueryJob", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public QueryJobResponse QueryJob(QueryJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryJobWithOptions(request, runtime);
        }

        public async Task<QueryJobResponse> QueryJobAsync(QueryJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryJobWithOptionsAsync(request, runtime);
        }

        public UpdateJobResponse UpdateJobWithOptions(UpdateJobRequest tmp, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmp);
            UpdateJobShrinkRequest request = new UpdateJobShrinkRequest();
            AlibabaCloud.Commons.Common.Convert(tmp, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmp.TimeoutConfig))
            {
                request.TimeoutConfigShrink = AlibabaCloud.TeaUtil.Common.ToJSONString(tmp.TimeoutConfig);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmp.RolloutConfig))
            {
                request.RolloutConfigShrink = AlibabaCloud.TeaUtil.Common.ToJSONString(tmp.RolloutConfig);
            }
            return TeaModel.ToObject<UpdateJobResponse>(DoRequest("UpdateJob", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<UpdateJobResponse> UpdateJobWithOptionsAsync(UpdateJobRequest tmp, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmp);
            UpdateJobShrinkRequest request = new UpdateJobShrinkRequest();
            AlibabaCloud.Commons.Common.Convert(tmp, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmp.TimeoutConfig))
            {
                request.TimeoutConfigShrink = AlibabaCloud.TeaUtil.Common.ToJSONString(tmp.TimeoutConfig);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmp.RolloutConfig))
            {
                request.RolloutConfigShrink = AlibabaCloud.TeaUtil.Common.ToJSONString(tmp.RolloutConfig);
            }
            return TeaModel.ToObject<UpdateJobResponse>(await DoRequestAsync("UpdateJob", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public UpdateJobResponse UpdateJob(UpdateJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateJobWithOptions(request, runtime);
        }

        public async Task<UpdateJobResponse> UpdateJobAsync(UpdateJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateJobWithOptionsAsync(request, runtime);
        }

        public CreateJobResponse CreateJobWithOptions(CreateJobRequest tmp, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmp);
            CreateJobShrinkRequest request = new CreateJobShrinkRequest();
            AlibabaCloud.Commons.Common.Convert(tmp, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmp.JobFile))
            {
                request.JobFileShrink = AlibabaCloud.TeaUtil.Common.ToJSONString(tmp.JobFile);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmp.TimeoutConfig))
            {
                request.TimeoutConfigShrink = AlibabaCloud.TeaUtil.Common.ToJSONString(tmp.TimeoutConfig);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmp.RolloutConfig))
            {
                request.RolloutConfigShrink = AlibabaCloud.TeaUtil.Common.ToJSONString(tmp.RolloutConfig);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmp.TargetConfig))
            {
                request.TargetConfigShrink = AlibabaCloud.TeaUtil.Common.ToJSONString(tmp.TargetConfig);
            }
            return TeaModel.ToObject<CreateJobResponse>(DoRequest("CreateJob", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<CreateJobResponse> CreateJobWithOptionsAsync(CreateJobRequest tmp, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmp);
            CreateJobShrinkRequest request = new CreateJobShrinkRequest();
            AlibabaCloud.Commons.Common.Convert(tmp, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmp.JobFile))
            {
                request.JobFileShrink = AlibabaCloud.TeaUtil.Common.ToJSONString(tmp.JobFile);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmp.TimeoutConfig))
            {
                request.TimeoutConfigShrink = AlibabaCloud.TeaUtil.Common.ToJSONString(tmp.TimeoutConfig);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmp.RolloutConfig))
            {
                request.RolloutConfigShrink = AlibabaCloud.TeaUtil.Common.ToJSONString(tmp.RolloutConfig);
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmp.TargetConfig))
            {
                request.TargetConfigShrink = AlibabaCloud.TeaUtil.Common.ToJSONString(tmp.TargetConfig);
            }
            return TeaModel.ToObject<CreateJobResponse>(await DoRequestAsync("CreateJob", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public CreateJobResponse CreateJob(CreateJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateJobWithOptions(request, runtime);
        }

        public async Task<CreateJobResponse> CreateJobAsync(CreateJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateJobWithOptionsAsync(request, runtime);
        }

        public GenerateFileUploadURLResponse GenerateFileUploadURLWithOptions(GenerateFileUploadURLRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GenerateFileUploadURLResponse>(DoRequest("GenerateFileUploadURL", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<GenerateFileUploadURLResponse> GenerateFileUploadURLWithOptionsAsync(GenerateFileUploadURLRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GenerateFileUploadURLResponse>(await DoRequestAsync("GenerateFileUploadURL", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public GenerateFileUploadURLResponse GenerateFileUploadURL(GenerateFileUploadURLRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GenerateFileUploadURLWithOptions(request, runtime);
        }

        public async Task<GenerateFileUploadURLResponse> GenerateFileUploadURLAsync(GenerateFileUploadURLRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GenerateFileUploadURLWithOptionsAsync(request, runtime);
        }

        public CreateProductDistributeJobResponse CreateProductDistributeJobWithOptions(CreateProductDistributeJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CreateProductDistributeJobResponse>(DoRequest("CreateProductDistributeJob", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<CreateProductDistributeJobResponse> CreateProductDistributeJobWithOptionsAsync(CreateProductDistributeJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CreateProductDistributeJobResponse>(await DoRequestAsync("CreateProductDistributeJob", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public CreateProductDistributeJobResponse CreateProductDistributeJob(CreateProductDistributeJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateProductDistributeJobWithOptions(request, runtime);
        }

        public async Task<CreateProductDistributeJobResponse> CreateProductDistributeJobAsync(CreateProductDistributeJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateProductDistributeJobWithOptionsAsync(request, runtime);
        }

        public QueryDeviceOriginalPropertyDataResponse QueryDeviceOriginalPropertyDataWithOptions(QueryDeviceOriginalPropertyDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<QueryDeviceOriginalPropertyDataResponse>(DoRequest("QueryDeviceOriginalPropertyData", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<QueryDeviceOriginalPropertyDataResponse> QueryDeviceOriginalPropertyDataWithOptionsAsync(QueryDeviceOriginalPropertyDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<QueryDeviceOriginalPropertyDataResponse>(await DoRequestAsync("QueryDeviceOriginalPropertyData", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public QueryDeviceOriginalPropertyDataResponse QueryDeviceOriginalPropertyData(QueryDeviceOriginalPropertyDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryDeviceOriginalPropertyDataWithOptions(request, runtime);
        }

        public async Task<QueryDeviceOriginalPropertyDataResponse> QueryDeviceOriginalPropertyDataAsync(QueryDeviceOriginalPropertyDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryDeviceOriginalPropertyDataWithOptionsAsync(request, runtime);
        }

        public QueryDeviceOriginalEventDataResponse QueryDeviceOriginalEventDataWithOptions(QueryDeviceOriginalEventDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<QueryDeviceOriginalEventDataResponse>(DoRequest("QueryDeviceOriginalEventData", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<QueryDeviceOriginalEventDataResponse> QueryDeviceOriginalEventDataWithOptionsAsync(QueryDeviceOriginalEventDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<QueryDeviceOriginalEventDataResponse>(await DoRequestAsync("QueryDeviceOriginalEventData", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public QueryDeviceOriginalEventDataResponse QueryDeviceOriginalEventData(QueryDeviceOriginalEventDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryDeviceOriginalEventDataWithOptions(request, runtime);
        }

        public async Task<QueryDeviceOriginalEventDataResponse> QueryDeviceOriginalEventDataAsync(QueryDeviceOriginalEventDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryDeviceOriginalEventDataWithOptionsAsync(request, runtime);
        }

        public QueryDeviceOriginalPropertyStatusResponse QueryDeviceOriginalPropertyStatusWithOptions(QueryDeviceOriginalPropertyStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<QueryDeviceOriginalPropertyStatusResponse>(DoRequest("QueryDeviceOriginalPropertyStatus", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<QueryDeviceOriginalPropertyStatusResponse> QueryDeviceOriginalPropertyStatusWithOptionsAsync(QueryDeviceOriginalPropertyStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<QueryDeviceOriginalPropertyStatusResponse>(await DoRequestAsync("QueryDeviceOriginalPropertyStatus", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public QueryDeviceOriginalPropertyStatusResponse QueryDeviceOriginalPropertyStatus(QueryDeviceOriginalPropertyStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryDeviceOriginalPropertyStatusWithOptions(request, runtime);
        }

        public async Task<QueryDeviceOriginalPropertyStatusResponse> QueryDeviceOriginalPropertyStatusAsync(QueryDeviceOriginalPropertyStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryDeviceOriginalPropertyStatusWithOptionsAsync(request, runtime);
        }

        public QueryDeviceOriginalServiceDataResponse QueryDeviceOriginalServiceDataWithOptions(QueryDeviceOriginalServiceDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<QueryDeviceOriginalServiceDataResponse>(DoRequest("QueryDeviceOriginalServiceData", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<QueryDeviceOriginalServiceDataResponse> QueryDeviceOriginalServiceDataWithOptionsAsync(QueryDeviceOriginalServiceDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<QueryDeviceOriginalServiceDataResponse>(await DoRequestAsync("QueryDeviceOriginalServiceData", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public QueryDeviceOriginalServiceDataResponse QueryDeviceOriginalServiceData(QueryDeviceOriginalServiceDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryDeviceOriginalServiceDataWithOptions(request, runtime);
        }

        public async Task<QueryDeviceOriginalServiceDataResponse> QueryDeviceOriginalServiceDataAsync(QueryDeviceOriginalServiceDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryDeviceOriginalServiceDataWithOptionsAsync(request, runtime);
        }

        public CreateThingScriptResponse CreateThingScriptWithOptions(CreateThingScriptRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CreateThingScriptResponse>(DoRequest("CreateThingScript", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<CreateThingScriptResponse> CreateThingScriptWithOptionsAsync(CreateThingScriptRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CreateThingScriptResponse>(await DoRequestAsync("CreateThingScript", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public CreateThingScriptResponse CreateThingScript(CreateThingScriptRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateThingScriptWithOptions(request, runtime);
        }

        public async Task<CreateThingScriptResponse> CreateThingScriptAsync(CreateThingScriptRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateThingScriptWithOptionsAsync(request, runtime);
        }

        public UpdateThingScriptResponse UpdateThingScriptWithOptions(UpdateThingScriptRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<UpdateThingScriptResponse>(DoRequest("UpdateThingScript", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<UpdateThingScriptResponse> UpdateThingScriptWithOptionsAsync(UpdateThingScriptRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<UpdateThingScriptResponse>(await DoRequestAsync("UpdateThingScript", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public UpdateThingScriptResponse UpdateThingScript(UpdateThingScriptRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateThingScriptWithOptions(request, runtime);
        }

        public async Task<UpdateThingScriptResponse> UpdateThingScriptAsync(UpdateThingScriptRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateThingScriptWithOptionsAsync(request, runtime);
        }

        public GetThingScriptResponse GetThingScriptWithOptions(GetThingScriptRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetThingScriptResponse>(DoRequest("GetThingScript", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<GetThingScriptResponse> GetThingScriptWithOptionsAsync(GetThingScriptRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetThingScriptResponse>(await DoRequestAsync("GetThingScript", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public GetThingScriptResponse GetThingScript(GetThingScriptRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetThingScriptWithOptions(request, runtime);
        }

        public async Task<GetThingScriptResponse> GetThingScriptAsync(GetThingScriptRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetThingScriptWithOptionsAsync(request, runtime);
        }

        public ListOTAModuleVersionsByDeviceResponse ListOTAModuleVersionsByDeviceWithOptions(ListOTAModuleVersionsByDeviceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ListOTAModuleVersionsByDeviceResponse>(DoRequest("ListOTAModuleVersionsByDevice", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<ListOTAModuleVersionsByDeviceResponse> ListOTAModuleVersionsByDeviceWithOptionsAsync(ListOTAModuleVersionsByDeviceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ListOTAModuleVersionsByDeviceResponse>(await DoRequestAsync("ListOTAModuleVersionsByDevice", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public ListOTAModuleVersionsByDeviceResponse ListOTAModuleVersionsByDevice(ListOTAModuleVersionsByDeviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListOTAModuleVersionsByDeviceWithOptions(request, runtime);
        }

        public async Task<ListOTAModuleVersionsByDeviceResponse> ListOTAModuleVersionsByDeviceAsync(ListOTAModuleVersionsByDeviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListOTAModuleVersionsByDeviceWithOptionsAsync(request, runtime);
        }

        public BatchPubResponse BatchPubWithOptions(BatchPubRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<BatchPubResponse>(DoRequest("BatchPub", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<BatchPubResponse> BatchPubWithOptionsAsync(BatchPubRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<BatchPubResponse>(await DoRequestAsync("BatchPub", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public BatchPubResponse BatchPub(BatchPubRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return BatchPubWithOptions(request, runtime);
        }

        public async Task<BatchPubResponse> BatchPubAsync(BatchPubRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await BatchPubWithOptionsAsync(request, runtime);
        }

        public SpeechByCombinationResponse SpeechByCombinationWithOptions(SpeechByCombinationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<SpeechByCombinationResponse>(DoRequest("SpeechByCombination", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<SpeechByCombinationResponse> SpeechByCombinationWithOptionsAsync(SpeechByCombinationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<SpeechByCombinationResponse>(await DoRequestAsync("SpeechByCombination", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public SpeechByCombinationResponse SpeechByCombination(SpeechByCombinationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SpeechByCombinationWithOptions(request, runtime);
        }

        public async Task<SpeechByCombinationResponse> SpeechByCombinationAsync(SpeechByCombinationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SpeechByCombinationWithOptionsAsync(request, runtime);
        }

        public UpdateThingModelValidationConfigResponse UpdateThingModelValidationConfigWithOptions(UpdateThingModelValidationConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<UpdateThingModelValidationConfigResponse>(DoRequest("UpdateThingModelValidationConfig", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<UpdateThingModelValidationConfigResponse> UpdateThingModelValidationConfigWithOptionsAsync(UpdateThingModelValidationConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<UpdateThingModelValidationConfigResponse>(await DoRequestAsync("UpdateThingModelValidationConfig", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public UpdateThingModelValidationConfigResponse UpdateThingModelValidationConfig(UpdateThingModelValidationConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateThingModelValidationConfigWithOptions(request, runtime);
        }

        public async Task<UpdateThingModelValidationConfigResponse> UpdateThingModelValidationConfigAsync(UpdateThingModelValidationConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateThingModelValidationConfigWithOptionsAsync(request, runtime);
        }

        public QueryDeviceBySQLResponse QueryDeviceBySQLWithOptions(QueryDeviceBySQLRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<QueryDeviceBySQLResponse>(DoRequest("QueryDeviceBySQL", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<QueryDeviceBySQLResponse> QueryDeviceBySQLWithOptionsAsync(QueryDeviceBySQLRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<QueryDeviceBySQLResponse>(await DoRequestAsync("QueryDeviceBySQL", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public QueryDeviceBySQLResponse QueryDeviceBySQL(QueryDeviceBySQLRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryDeviceBySQLWithOptions(request, runtime);
        }

        public async Task<QueryDeviceBySQLResponse> QueryDeviceBySQLAsync(QueryDeviceBySQLRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryDeviceBySQLWithOptionsAsync(request, runtime);
        }

        public ListOTAModuleByProductResponse ListOTAModuleByProductWithOptions(ListOTAModuleByProductRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ListOTAModuleByProductResponse>(DoRequest("ListOTAModuleByProduct", "HTTPS", "GET", "2018-01-20", "AK", request.ToMap(), null, runtime));
        }

        public async Task<ListOTAModuleByProductResponse> ListOTAModuleByProductWithOptionsAsync(ListOTAModuleByProductRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ListOTAModuleByProductResponse>(await DoRequestAsync("ListOTAModuleByProduct", "HTTPS", "GET", "2018-01-20", "AK", request.ToMap(), null, runtime));
        }

        public ListOTAModuleByProductResponse ListOTAModuleByProduct(ListOTAModuleByProductRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListOTAModuleByProductWithOptions(request, runtime);
        }

        public async Task<ListOTAModuleByProductResponse> ListOTAModuleByProductAsync(ListOTAModuleByProductRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListOTAModuleByProductWithOptionsAsync(request, runtime);
        }

        public DeleteOTAModuleResponse DeleteOTAModuleWithOptions(DeleteOTAModuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DeleteOTAModuleResponse>(DoRequest("DeleteOTAModule", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DeleteOTAModuleResponse> DeleteOTAModuleWithOptionsAsync(DeleteOTAModuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DeleteOTAModuleResponse>(await DoRequestAsync("DeleteOTAModule", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public DeleteOTAModuleResponse DeleteOTAModule(DeleteOTAModuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteOTAModuleWithOptions(request, runtime);
        }

        public async Task<DeleteOTAModuleResponse> DeleteOTAModuleAsync(DeleteOTAModuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteOTAModuleWithOptionsAsync(request, runtime);
        }

        public GenerateDeviceNameListURLResponse GenerateDeviceNameListURLWithOptions(GenerateDeviceNameListURLRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GenerateDeviceNameListURLResponse>(DoRequest("GenerateDeviceNameListURL", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<GenerateDeviceNameListURLResponse> GenerateDeviceNameListURLWithOptionsAsync(GenerateDeviceNameListURLRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GenerateDeviceNameListURLResponse>(await DoRequestAsync("GenerateDeviceNameListURL", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public GenerateDeviceNameListURLResponse GenerateDeviceNameListURL(GenerateDeviceNameListURLRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GenerateDeviceNameListURLWithOptions(request, runtime);
        }

        public async Task<GenerateDeviceNameListURLResponse> GenerateDeviceNameListURLAsync(GenerateDeviceNameListURLRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GenerateDeviceNameListURLWithOptionsAsync(request, runtime);
        }

        public UpdateOTAModuleResponse UpdateOTAModuleWithOptions(UpdateOTAModuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<UpdateOTAModuleResponse>(DoRequest("UpdateOTAModule", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<UpdateOTAModuleResponse> UpdateOTAModuleWithOptionsAsync(UpdateOTAModuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<UpdateOTAModuleResponse>(await DoRequestAsync("UpdateOTAModule", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public UpdateOTAModuleResponse UpdateOTAModule(UpdateOTAModuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateOTAModuleWithOptions(request, runtime);
        }

        public async Task<UpdateOTAModuleResponse> UpdateOTAModuleAsync(UpdateOTAModuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateOTAModuleWithOptionsAsync(request, runtime);
        }

        public CreateOTAModuleResponse CreateOTAModuleWithOptions(CreateOTAModuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CreateOTAModuleResponse>(DoRequest("CreateOTAModule", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<CreateOTAModuleResponse> CreateOTAModuleWithOptionsAsync(CreateOTAModuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CreateOTAModuleResponse>(await DoRequestAsync("CreateOTAModule", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public CreateOTAModuleResponse CreateOTAModule(CreateOTAModuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateOTAModuleWithOptions(request, runtime);
        }

        public async Task<CreateOTAModuleResponse> CreateOTAModuleAsync(CreateOTAModuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateOTAModuleWithOptionsAsync(request, runtime);
        }

        public QueryThingModelExtendConfigPublishedResponse QueryThingModelExtendConfigPublishedWithOptions(QueryThingModelExtendConfigPublishedRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<QueryThingModelExtendConfigPublishedResponse>(DoRequest("QueryThingModelExtendConfigPublished", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<QueryThingModelExtendConfigPublishedResponse> QueryThingModelExtendConfigPublishedWithOptionsAsync(QueryThingModelExtendConfigPublishedRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<QueryThingModelExtendConfigPublishedResponse>(await DoRequestAsync("QueryThingModelExtendConfigPublished", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public QueryThingModelExtendConfigPublishedResponse QueryThingModelExtendConfigPublished(QueryThingModelExtendConfigPublishedRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryThingModelExtendConfigPublishedWithOptions(request, runtime);
        }

        public async Task<QueryThingModelExtendConfigPublishedResponse> QueryThingModelExtendConfigPublishedAsync(QueryThingModelExtendConfigPublishedRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryThingModelExtendConfigPublishedWithOptionsAsync(request, runtime);
        }

        public GetThingModelTslPublishedResponse GetThingModelTslPublishedWithOptions(GetThingModelTslPublishedRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetThingModelTslPublishedResponse>(DoRequest("GetThingModelTslPublished", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<GetThingModelTslPublishedResponse> GetThingModelTslPublishedWithOptionsAsync(GetThingModelTslPublishedRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetThingModelTslPublishedResponse>(await DoRequestAsync("GetThingModelTslPublished", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public GetThingModelTslPublishedResponse GetThingModelTslPublished(GetThingModelTslPublishedRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetThingModelTslPublishedWithOptions(request, runtime);
        }

        public async Task<GetThingModelTslPublishedResponse> GetThingModelTslPublishedAsync(GetThingModelTslPublishedRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetThingModelTslPublishedWithOptionsAsync(request, runtime);
        }

        public QueryThingModelPublishedResponse QueryThingModelPublishedWithOptions(QueryThingModelPublishedRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<QueryThingModelPublishedResponse>(DoRequest("QueryThingModelPublished", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<QueryThingModelPublishedResponse> QueryThingModelPublishedWithOptionsAsync(QueryThingModelPublishedRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<QueryThingModelPublishedResponse>(await DoRequestAsync("QueryThingModelPublished", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public QueryThingModelPublishedResponse QueryThingModelPublished(QueryThingModelPublishedRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryThingModelPublishedWithOptions(request, runtime);
        }

        public async Task<QueryThingModelPublishedResponse> QueryThingModelPublishedAsync(QueryThingModelPublishedRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryThingModelPublishedWithOptionsAsync(request, runtime);
        }

        public QueryThingModelExtendConfigResponse QueryThingModelExtendConfigWithOptions(QueryThingModelExtendConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<QueryThingModelExtendConfigResponse>(DoRequest("QueryThingModelExtendConfig", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<QueryThingModelExtendConfigResponse> QueryThingModelExtendConfigWithOptionsAsync(QueryThingModelExtendConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<QueryThingModelExtendConfigResponse>(await DoRequestAsync("QueryThingModelExtendConfig", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public QueryThingModelExtendConfigResponse QueryThingModelExtendConfig(QueryThingModelExtendConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryThingModelExtendConfigWithOptions(request, runtime);
        }

        public async Task<QueryThingModelExtendConfigResponse> QueryThingModelExtendConfigAsync(QueryThingModelExtendConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryThingModelExtendConfigWithOptionsAsync(request, runtime);
        }

        public ListDistributedDeviceResponse ListDistributedDeviceWithOptions(ListDistributedDeviceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ListDistributedDeviceResponse>(DoRequest("ListDistributedDevice", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<ListDistributedDeviceResponse> ListDistributedDeviceWithOptionsAsync(ListDistributedDeviceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ListDistributedDeviceResponse>(await DoRequestAsync("ListDistributedDevice", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public ListDistributedDeviceResponse ListDistributedDevice(ListDistributedDeviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListDistributedDeviceWithOptions(request, runtime);
        }

        public async Task<ListDistributedDeviceResponse> ListDistributedDeviceAsync(ListDistributedDeviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListDistributedDeviceWithOptionsAsync(request, runtime);
        }

        public ListDistributedProductResponse ListDistributedProductWithOptions(ListDistributedProductRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ListDistributedProductResponse>(DoRequest("ListDistributedProduct", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<ListDistributedProductResponse> ListDistributedProductWithOptionsAsync(ListDistributedProductRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ListDistributedProductResponse>(await DoRequestAsync("ListDistributedProduct", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public ListDistributedProductResponse ListDistributedProduct(ListDistributedProductRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListDistributedProductWithOptions(request, runtime);
        }

        public async Task<ListDistributedProductResponse> ListDistributedProductAsync(ListDistributedProductRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListDistributedProductWithOptionsAsync(request, runtime);
        }

        public QuerySubscribeRelationResponse QuerySubscribeRelationWithOptions(QuerySubscribeRelationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<QuerySubscribeRelationResponse>(DoRequest("QuerySubscribeRelation", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<QuerySubscribeRelationResponse> QuerySubscribeRelationWithOptionsAsync(QuerySubscribeRelationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<QuerySubscribeRelationResponse>(await DoRequestAsync("QuerySubscribeRelation", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public QuerySubscribeRelationResponse QuerySubscribeRelation(QuerySubscribeRelationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QuerySubscribeRelationWithOptions(request, runtime);
        }

        public async Task<QuerySubscribeRelationResponse> QuerySubscribeRelationAsync(QuerySubscribeRelationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QuerySubscribeRelationWithOptionsAsync(request, runtime);
        }

        public CreateConsumerGroupSubscribeRelationResponse CreateConsumerGroupSubscribeRelationWithOptions(CreateConsumerGroupSubscribeRelationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CreateConsumerGroupSubscribeRelationResponse>(DoRequest("CreateConsumerGroupSubscribeRelation", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<CreateConsumerGroupSubscribeRelationResponse> CreateConsumerGroupSubscribeRelationWithOptionsAsync(CreateConsumerGroupSubscribeRelationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CreateConsumerGroupSubscribeRelationResponse>(await DoRequestAsync("CreateConsumerGroupSubscribeRelation", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public CreateConsumerGroupSubscribeRelationResponse CreateConsumerGroupSubscribeRelation(CreateConsumerGroupSubscribeRelationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateConsumerGroupSubscribeRelationWithOptions(request, runtime);
        }

        public async Task<CreateConsumerGroupSubscribeRelationResponse> CreateConsumerGroupSubscribeRelationAsync(CreateConsumerGroupSubscribeRelationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateConsumerGroupSubscribeRelationWithOptionsAsync(request, runtime);
        }

        public UpdateSubscribeRelationResponse UpdateSubscribeRelationWithOptions(UpdateSubscribeRelationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<UpdateSubscribeRelationResponse>(DoRequest("UpdateSubscribeRelation", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<UpdateSubscribeRelationResponse> UpdateSubscribeRelationWithOptionsAsync(UpdateSubscribeRelationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<UpdateSubscribeRelationResponse>(await DoRequestAsync("UpdateSubscribeRelation", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public UpdateSubscribeRelationResponse UpdateSubscribeRelation(UpdateSubscribeRelationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateSubscribeRelationWithOptions(request, runtime);
        }

        public async Task<UpdateSubscribeRelationResponse> UpdateSubscribeRelationAsync(UpdateSubscribeRelationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateSubscribeRelationWithOptionsAsync(request, runtime);
        }

        public DeleteConsumerGroupSubscribeRelationResponse DeleteConsumerGroupSubscribeRelationWithOptions(DeleteConsumerGroupSubscribeRelationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DeleteConsumerGroupSubscribeRelationResponse>(DoRequest("DeleteConsumerGroupSubscribeRelation", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DeleteConsumerGroupSubscribeRelationResponse> DeleteConsumerGroupSubscribeRelationWithOptionsAsync(DeleteConsumerGroupSubscribeRelationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DeleteConsumerGroupSubscribeRelationResponse>(await DoRequestAsync("DeleteConsumerGroupSubscribeRelation", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public DeleteConsumerGroupSubscribeRelationResponse DeleteConsumerGroupSubscribeRelation(DeleteConsumerGroupSubscribeRelationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteConsumerGroupSubscribeRelationWithOptions(request, runtime);
        }

        public async Task<DeleteConsumerGroupSubscribeRelationResponse> DeleteConsumerGroupSubscribeRelationAsync(DeleteConsumerGroupSubscribeRelationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteConsumerGroupSubscribeRelationWithOptionsAsync(request, runtime);
        }

        public ResetConsumerGroupPositionResponse ResetConsumerGroupPositionWithOptions(ResetConsumerGroupPositionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ResetConsumerGroupPositionResponse>(DoRequest("ResetConsumerGroupPosition", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<ResetConsumerGroupPositionResponse> ResetConsumerGroupPositionWithOptionsAsync(ResetConsumerGroupPositionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ResetConsumerGroupPositionResponse>(await DoRequestAsync("ResetConsumerGroupPosition", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public ResetConsumerGroupPositionResponse ResetConsumerGroupPosition(ResetConsumerGroupPositionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ResetConsumerGroupPositionWithOptions(request, runtime);
        }

        public async Task<ResetConsumerGroupPositionResponse> ResetConsumerGroupPositionAsync(ResetConsumerGroupPositionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ResetConsumerGroupPositionWithOptionsAsync(request, runtime);
        }

        public UpdateConsumerGroupResponse UpdateConsumerGroupWithOptions(UpdateConsumerGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<UpdateConsumerGroupResponse>(DoRequest("UpdateConsumerGroup", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<UpdateConsumerGroupResponse> UpdateConsumerGroupWithOptionsAsync(UpdateConsumerGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<UpdateConsumerGroupResponse>(await DoRequestAsync("UpdateConsumerGroup", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public UpdateConsumerGroupResponse UpdateConsumerGroup(UpdateConsumerGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateConsumerGroupWithOptions(request, runtime);
        }

        public async Task<UpdateConsumerGroupResponse> UpdateConsumerGroupAsync(UpdateConsumerGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateConsumerGroupWithOptionsAsync(request, runtime);
        }

        public BatchDeleteEdgeInstanceChannelResponse BatchDeleteEdgeInstanceChannelWithOptions(BatchDeleteEdgeInstanceChannelRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<BatchDeleteEdgeInstanceChannelResponse>(DoRequest("BatchDeleteEdgeInstanceChannel", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<BatchDeleteEdgeInstanceChannelResponse> BatchDeleteEdgeInstanceChannelWithOptionsAsync(BatchDeleteEdgeInstanceChannelRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<BatchDeleteEdgeInstanceChannelResponse>(await DoRequestAsync("BatchDeleteEdgeInstanceChannel", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public BatchDeleteEdgeInstanceChannelResponse BatchDeleteEdgeInstanceChannel(BatchDeleteEdgeInstanceChannelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return BatchDeleteEdgeInstanceChannelWithOptions(request, runtime);
        }

        public async Task<BatchDeleteEdgeInstanceChannelResponse> BatchDeleteEdgeInstanceChannelAsync(BatchDeleteEdgeInstanceChannelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await BatchDeleteEdgeInstanceChannelWithOptionsAsync(request, runtime);
        }

        public BatchSetEdgeInstanceDeviceChannelResponse BatchSetEdgeInstanceDeviceChannelWithOptions(BatchSetEdgeInstanceDeviceChannelRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<BatchSetEdgeInstanceDeviceChannelResponse>(DoRequest("BatchSetEdgeInstanceDeviceChannel", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<BatchSetEdgeInstanceDeviceChannelResponse> BatchSetEdgeInstanceDeviceChannelWithOptionsAsync(BatchSetEdgeInstanceDeviceChannelRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<BatchSetEdgeInstanceDeviceChannelResponse>(await DoRequestAsync("BatchSetEdgeInstanceDeviceChannel", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public BatchSetEdgeInstanceDeviceChannelResponse BatchSetEdgeInstanceDeviceChannel(BatchSetEdgeInstanceDeviceChannelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return BatchSetEdgeInstanceDeviceChannelWithOptions(request, runtime);
        }

        public async Task<BatchSetEdgeInstanceDeviceChannelResponse> BatchSetEdgeInstanceDeviceChannelAsync(BatchSetEdgeInstanceDeviceChannelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await BatchSetEdgeInstanceDeviceChannelWithOptionsAsync(request, runtime);
        }

        public BatchGetEdgeInstanceDeviceDriverResponse BatchGetEdgeInstanceDeviceDriverWithOptions(BatchGetEdgeInstanceDeviceDriverRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<BatchGetEdgeInstanceDeviceDriverResponse>(DoRequest("BatchGetEdgeInstanceDeviceDriver", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<BatchGetEdgeInstanceDeviceDriverResponse> BatchGetEdgeInstanceDeviceDriverWithOptionsAsync(BatchGetEdgeInstanceDeviceDriverRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<BatchGetEdgeInstanceDeviceDriverResponse>(await DoRequestAsync("BatchGetEdgeInstanceDeviceDriver", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public BatchGetEdgeInstanceDeviceDriverResponse BatchGetEdgeInstanceDeviceDriver(BatchGetEdgeInstanceDeviceDriverRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return BatchGetEdgeInstanceDeviceDriverWithOptions(request, runtime);
        }

        public async Task<BatchGetEdgeInstanceDeviceDriverResponse> BatchGetEdgeInstanceDeviceDriverAsync(BatchGetEdgeInstanceDeviceDriverRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await BatchGetEdgeInstanceDeviceDriverWithOptionsAsync(request, runtime);
        }

        public BatchGetEdgeInstanceDeviceChannelResponse BatchGetEdgeInstanceDeviceChannelWithOptions(BatchGetEdgeInstanceDeviceChannelRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<BatchGetEdgeInstanceDeviceChannelResponse>(DoRequest("BatchGetEdgeInstanceDeviceChannel", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<BatchGetEdgeInstanceDeviceChannelResponse> BatchGetEdgeInstanceDeviceChannelWithOptionsAsync(BatchGetEdgeInstanceDeviceChannelRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<BatchGetEdgeInstanceDeviceChannelResponse>(await DoRequestAsync("BatchGetEdgeInstanceDeviceChannel", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public BatchGetEdgeInstanceDeviceChannelResponse BatchGetEdgeInstanceDeviceChannel(BatchGetEdgeInstanceDeviceChannelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return BatchGetEdgeInstanceDeviceChannelWithOptions(request, runtime);
        }

        public async Task<BatchGetEdgeInstanceDeviceChannelResponse> BatchGetEdgeInstanceDeviceChannelAsync(BatchGetEdgeInstanceDeviceChannelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await BatchGetEdgeInstanceDeviceChannelWithOptionsAsync(request, runtime);
        }

        public ReleaseEdgeDriverVersionResponse ReleaseEdgeDriverVersionWithOptions(ReleaseEdgeDriverVersionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ReleaseEdgeDriverVersionResponse>(DoRequest("ReleaseEdgeDriverVersion", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<ReleaseEdgeDriverVersionResponse> ReleaseEdgeDriverVersionWithOptionsAsync(ReleaseEdgeDriverVersionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ReleaseEdgeDriverVersionResponse>(await DoRequestAsync("ReleaseEdgeDriverVersion", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public ReleaseEdgeDriverVersionResponse ReleaseEdgeDriverVersion(ReleaseEdgeDriverVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ReleaseEdgeDriverVersionWithOptions(request, runtime);
        }

        public async Task<ReleaseEdgeDriverVersionResponse> ReleaseEdgeDriverVersionAsync(ReleaseEdgeDriverVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ReleaseEdgeDriverVersionWithOptionsAsync(request, runtime);
        }

        public QueryEdgeInstanceDeviceByDriverResponse QueryEdgeInstanceDeviceByDriverWithOptions(QueryEdgeInstanceDeviceByDriverRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<QueryEdgeInstanceDeviceByDriverResponse>(DoRequest("QueryEdgeInstanceDeviceByDriver", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<QueryEdgeInstanceDeviceByDriverResponse> QueryEdgeInstanceDeviceByDriverWithOptionsAsync(QueryEdgeInstanceDeviceByDriverRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<QueryEdgeInstanceDeviceByDriverResponse>(await DoRequestAsync("QueryEdgeInstanceDeviceByDriver", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public QueryEdgeInstanceDeviceByDriverResponse QueryEdgeInstanceDeviceByDriver(QueryEdgeInstanceDeviceByDriverRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryEdgeInstanceDeviceByDriverWithOptions(request, runtime);
        }

        public async Task<QueryEdgeInstanceDeviceByDriverResponse> QueryEdgeInstanceDeviceByDriverAsync(QueryEdgeInstanceDeviceByDriverRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryEdgeInstanceDeviceByDriverWithOptionsAsync(request, runtime);
        }

        public DisableSceneRuleResponse DisableSceneRuleWithOptions(DisableSceneRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DisableSceneRuleResponse>(DoRequest("DisableSceneRule", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DisableSceneRuleResponse> DisableSceneRuleWithOptionsAsync(DisableSceneRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DisableSceneRuleResponse>(await DoRequestAsync("DisableSceneRule", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public DisableSceneRuleResponse DisableSceneRule(DisableSceneRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DisableSceneRuleWithOptions(request, runtime);
        }

        public async Task<DisableSceneRuleResponse> DisableSceneRuleAsync(DisableSceneRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DisableSceneRuleWithOptionsAsync(request, runtime);
        }

        public TriggerSceneRuleResponse TriggerSceneRuleWithOptions(TriggerSceneRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<TriggerSceneRuleResponse>(DoRequest("TriggerSceneRule", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<TriggerSceneRuleResponse> TriggerSceneRuleWithOptionsAsync(TriggerSceneRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<TriggerSceneRuleResponse>(await DoRequestAsync("TriggerSceneRule", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public TriggerSceneRuleResponse TriggerSceneRule(TriggerSceneRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return TriggerSceneRuleWithOptions(request, runtime);
        }

        public async Task<TriggerSceneRuleResponse> TriggerSceneRuleAsync(TriggerSceneRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await TriggerSceneRuleWithOptionsAsync(request, runtime);
        }

        public UnbindSceneRuleFromEdgeInstanceResponse UnbindSceneRuleFromEdgeInstanceWithOptions(UnbindSceneRuleFromEdgeInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<UnbindSceneRuleFromEdgeInstanceResponse>(DoRequest("UnbindSceneRuleFromEdgeInstance", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<UnbindSceneRuleFromEdgeInstanceResponse> UnbindSceneRuleFromEdgeInstanceWithOptionsAsync(UnbindSceneRuleFromEdgeInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<UnbindSceneRuleFromEdgeInstanceResponse>(await DoRequestAsync("UnbindSceneRuleFromEdgeInstance", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public UnbindSceneRuleFromEdgeInstanceResponse UnbindSceneRuleFromEdgeInstance(UnbindSceneRuleFromEdgeInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UnbindSceneRuleFromEdgeInstanceWithOptions(request, runtime);
        }

        public async Task<UnbindSceneRuleFromEdgeInstanceResponse> UnbindSceneRuleFromEdgeInstanceAsync(UnbindSceneRuleFromEdgeInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UnbindSceneRuleFromEdgeInstanceWithOptionsAsync(request, runtime);
        }

        public QueryEdgeInstanceSceneRuleResponse QueryEdgeInstanceSceneRuleWithOptions(QueryEdgeInstanceSceneRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<QueryEdgeInstanceSceneRuleResponse>(DoRequest("QueryEdgeInstanceSceneRule", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<QueryEdgeInstanceSceneRuleResponse> QueryEdgeInstanceSceneRuleWithOptionsAsync(QueryEdgeInstanceSceneRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<QueryEdgeInstanceSceneRuleResponse>(await DoRequestAsync("QueryEdgeInstanceSceneRule", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public QueryEdgeInstanceSceneRuleResponse QueryEdgeInstanceSceneRule(QueryEdgeInstanceSceneRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryEdgeInstanceSceneRuleWithOptions(request, runtime);
        }

        public async Task<QueryEdgeInstanceSceneRuleResponse> QueryEdgeInstanceSceneRuleAsync(QueryEdgeInstanceSceneRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryEdgeInstanceSceneRuleWithOptionsAsync(request, runtime);
        }

        public CreateSceneRuleResponse CreateSceneRuleWithOptions(CreateSceneRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CreateSceneRuleResponse>(DoRequest("CreateSceneRule", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<CreateSceneRuleResponse> CreateSceneRuleWithOptionsAsync(CreateSceneRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CreateSceneRuleResponse>(await DoRequestAsync("CreateSceneRule", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public CreateSceneRuleResponse CreateSceneRule(CreateSceneRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateSceneRuleWithOptions(request, runtime);
        }

        public async Task<CreateSceneRuleResponse> CreateSceneRuleAsync(CreateSceneRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateSceneRuleWithOptionsAsync(request, runtime);
        }

        public QueryDetailSceneRuleLogResponse QueryDetailSceneRuleLogWithOptions(QueryDetailSceneRuleLogRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<QueryDetailSceneRuleLogResponse>(DoRequest("QueryDetailSceneRuleLog", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<QueryDetailSceneRuleLogResponse> QueryDetailSceneRuleLogWithOptionsAsync(QueryDetailSceneRuleLogRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<QueryDetailSceneRuleLogResponse>(await DoRequestAsync("QueryDetailSceneRuleLog", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public QueryDetailSceneRuleLogResponse QueryDetailSceneRuleLog(QueryDetailSceneRuleLogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryDetailSceneRuleLogWithOptions(request, runtime);
        }

        public async Task<QueryDetailSceneRuleLogResponse> QueryDetailSceneRuleLogAsync(QueryDetailSceneRuleLogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryDetailSceneRuleLogWithOptionsAsync(request, runtime);
        }

        public EnableSceneRuleResponse EnableSceneRuleWithOptions(EnableSceneRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<EnableSceneRuleResponse>(DoRequest("EnableSceneRule", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<EnableSceneRuleResponse> EnableSceneRuleWithOptionsAsync(EnableSceneRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<EnableSceneRuleResponse>(await DoRequestAsync("EnableSceneRule", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public EnableSceneRuleResponse EnableSceneRule(EnableSceneRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return EnableSceneRuleWithOptions(request, runtime);
        }

        public async Task<EnableSceneRuleResponse> EnableSceneRuleAsync(EnableSceneRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await EnableSceneRuleWithOptionsAsync(request, runtime);
        }

        public UpdateSceneRuleResponse UpdateSceneRuleWithOptions(UpdateSceneRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<UpdateSceneRuleResponse>(DoRequest("UpdateSceneRule", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<UpdateSceneRuleResponse> UpdateSceneRuleWithOptionsAsync(UpdateSceneRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<UpdateSceneRuleResponse>(await DoRequestAsync("UpdateSceneRule", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public UpdateSceneRuleResponse UpdateSceneRule(UpdateSceneRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateSceneRuleWithOptions(request, runtime);
        }

        public async Task<UpdateSceneRuleResponse> UpdateSceneRuleAsync(UpdateSceneRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateSceneRuleWithOptionsAsync(request, runtime);
        }

        public QuerySceneRuleResponse QuerySceneRuleWithOptions(QuerySceneRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<QuerySceneRuleResponse>(DoRequest("QuerySceneRule", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<QuerySceneRuleResponse> QuerySceneRuleWithOptionsAsync(QuerySceneRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<QuerySceneRuleResponse>(await DoRequestAsync("QuerySceneRule", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public QuerySceneRuleResponse QuerySceneRule(QuerySceneRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QuerySceneRuleWithOptions(request, runtime);
        }

        public async Task<QuerySceneRuleResponse> QuerySceneRuleAsync(QuerySceneRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QuerySceneRuleWithOptionsAsync(request, runtime);
        }

        public QuerySummarySceneRuleLogResponse QuerySummarySceneRuleLogWithOptions(QuerySummarySceneRuleLogRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<QuerySummarySceneRuleLogResponse>(DoRequest("QuerySummarySceneRuleLog", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<QuerySummarySceneRuleLogResponse> QuerySummarySceneRuleLogWithOptionsAsync(QuerySummarySceneRuleLogRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<QuerySummarySceneRuleLogResponse>(await DoRequestAsync("QuerySummarySceneRuleLog", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public QuerySummarySceneRuleLogResponse QuerySummarySceneRuleLog(QuerySummarySceneRuleLogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QuerySummarySceneRuleLogWithOptions(request, runtime);
        }

        public async Task<QuerySummarySceneRuleLogResponse> QuerySummarySceneRuleLogAsync(QuerySummarySceneRuleLogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QuerySummarySceneRuleLogWithOptionsAsync(request, runtime);
        }

        public GetSceneRuleResponse GetSceneRuleWithOptions(GetSceneRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetSceneRuleResponse>(DoRequest("GetSceneRule", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<GetSceneRuleResponse> GetSceneRuleWithOptionsAsync(GetSceneRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetSceneRuleResponse>(await DoRequestAsync("GetSceneRule", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public GetSceneRuleResponse GetSceneRule(GetSceneRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetSceneRuleWithOptions(request, runtime);
        }

        public async Task<GetSceneRuleResponse> GetSceneRuleAsync(GetSceneRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetSceneRuleWithOptionsAsync(request, runtime);
        }

        public DeleteSceneRuleResponse DeleteSceneRuleWithOptions(DeleteSceneRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DeleteSceneRuleResponse>(DoRequest("DeleteSceneRule", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DeleteSceneRuleResponse> DeleteSceneRuleWithOptionsAsync(DeleteSceneRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DeleteSceneRuleResponse>(await DoRequestAsync("DeleteSceneRule", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public DeleteSceneRuleResponse DeleteSceneRule(DeleteSceneRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteSceneRuleWithOptions(request, runtime);
        }

        public async Task<DeleteSceneRuleResponse> DeleteSceneRuleAsync(DeleteSceneRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteSceneRuleWithOptionsAsync(request, runtime);
        }

        public BindSceneRuleToEdgeInstanceResponse BindSceneRuleToEdgeInstanceWithOptions(BindSceneRuleToEdgeInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<BindSceneRuleToEdgeInstanceResponse>(DoRequest("BindSceneRuleToEdgeInstance", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<BindSceneRuleToEdgeInstanceResponse> BindSceneRuleToEdgeInstanceWithOptionsAsync(BindSceneRuleToEdgeInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<BindSceneRuleToEdgeInstanceResponse>(await DoRequestAsync("BindSceneRuleToEdgeInstance", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public BindSceneRuleToEdgeInstanceResponse BindSceneRuleToEdgeInstance(BindSceneRuleToEdgeInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return BindSceneRuleToEdgeInstanceWithOptions(request, runtime);
        }

        public async Task<BindSceneRuleToEdgeInstanceResponse> BindSceneRuleToEdgeInstanceAsync(BindSceneRuleToEdgeInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await BindSceneRuleToEdgeInstanceWithOptionsAsync(request, runtime);
        }

        public CreateEdgeOssPreSignedAddressResponse CreateEdgeOssPreSignedAddressWithOptions(CreateEdgeOssPreSignedAddressRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CreateEdgeOssPreSignedAddressResponse>(DoRequest("CreateEdgeOssPreSignedAddress", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<CreateEdgeOssPreSignedAddressResponse> CreateEdgeOssPreSignedAddressWithOptionsAsync(CreateEdgeOssPreSignedAddressRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CreateEdgeOssPreSignedAddressResponse>(await DoRequestAsync("CreateEdgeOssPreSignedAddress", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public CreateEdgeOssPreSignedAddressResponse CreateEdgeOssPreSignedAddress(CreateEdgeOssPreSignedAddressRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateEdgeOssPreSignedAddressWithOptions(request, runtime);
        }

        public async Task<CreateEdgeOssPreSignedAddressResponse> CreateEdgeOssPreSignedAddressAsync(CreateEdgeOssPreSignedAddressRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateEdgeOssPreSignedAddressWithOptionsAsync(request, runtime);
        }

        public UpdateEdgeDriverVersionResponse UpdateEdgeDriverVersionWithOptions(UpdateEdgeDriverVersionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<UpdateEdgeDriverVersionResponse>(DoRequest("UpdateEdgeDriverVersion", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<UpdateEdgeDriverVersionResponse> UpdateEdgeDriverVersionWithOptionsAsync(UpdateEdgeDriverVersionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<UpdateEdgeDriverVersionResponse>(await DoRequestAsync("UpdateEdgeDriverVersion", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public UpdateEdgeDriverVersionResponse UpdateEdgeDriverVersion(UpdateEdgeDriverVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateEdgeDriverVersionWithOptions(request, runtime);
        }

        public async Task<UpdateEdgeDriverVersionResponse> UpdateEdgeDriverVersionAsync(UpdateEdgeDriverVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateEdgeDriverVersionWithOptionsAsync(request, runtime);
        }

        public DeleteEdgeDriverVersionResponse DeleteEdgeDriverVersionWithOptions(DeleteEdgeDriverVersionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DeleteEdgeDriverVersionResponse>(DoRequest("DeleteEdgeDriverVersion", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DeleteEdgeDriverVersionResponse> DeleteEdgeDriverVersionWithOptionsAsync(DeleteEdgeDriverVersionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DeleteEdgeDriverVersionResponse>(await DoRequestAsync("DeleteEdgeDriverVersion", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public DeleteEdgeDriverVersionResponse DeleteEdgeDriverVersion(DeleteEdgeDriverVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteEdgeDriverVersionWithOptions(request, runtime);
        }

        public async Task<DeleteEdgeDriverVersionResponse> DeleteEdgeDriverVersionAsync(DeleteEdgeDriverVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteEdgeDriverVersionWithOptionsAsync(request, runtime);
        }

        public CreateEdgeDriverVersionResponse CreateEdgeDriverVersionWithOptions(CreateEdgeDriverVersionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CreateEdgeDriverVersionResponse>(DoRequest("CreateEdgeDriverVersion", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<CreateEdgeDriverVersionResponse> CreateEdgeDriverVersionWithOptionsAsync(CreateEdgeDriverVersionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CreateEdgeDriverVersionResponse>(await DoRequestAsync("CreateEdgeDriverVersion", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public CreateEdgeDriverVersionResponse CreateEdgeDriverVersion(CreateEdgeDriverVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateEdgeDriverVersionWithOptions(request, runtime);
        }

        public async Task<CreateEdgeDriverVersionResponse> CreateEdgeDriverVersionAsync(CreateEdgeDriverVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateEdgeDriverVersionWithOptionsAsync(request, runtime);
        }

        public DeleteEdgeDriverResponse DeleteEdgeDriverWithOptions(DeleteEdgeDriverRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DeleteEdgeDriverResponse>(DoRequest("DeleteEdgeDriver", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DeleteEdgeDriverResponse> DeleteEdgeDriverWithOptionsAsync(DeleteEdgeDriverRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DeleteEdgeDriverResponse>(await DoRequestAsync("DeleteEdgeDriver", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public DeleteEdgeDriverResponse DeleteEdgeDriver(DeleteEdgeDriverRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteEdgeDriverWithOptions(request, runtime);
        }

        public async Task<DeleteEdgeDriverResponse> DeleteEdgeDriverAsync(DeleteEdgeDriverRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteEdgeDriverWithOptionsAsync(request, runtime);
        }

        public QueryEdgeDriverResponse QueryEdgeDriverWithOptions(QueryEdgeDriverRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<QueryEdgeDriverResponse>(DoRequest("QueryEdgeDriver", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<QueryEdgeDriverResponse> QueryEdgeDriverWithOptionsAsync(QueryEdgeDriverRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<QueryEdgeDriverResponse>(await DoRequestAsync("QueryEdgeDriver", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public QueryEdgeDriverResponse QueryEdgeDriver(QueryEdgeDriverRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryEdgeDriverWithOptions(request, runtime);
        }

        public async Task<QueryEdgeDriverResponse> QueryEdgeDriverAsync(QueryEdgeDriverRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryEdgeDriverWithOptionsAsync(request, runtime);
        }

        public BatchGetEdgeDriverResponse BatchGetEdgeDriverWithOptions(BatchGetEdgeDriverRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<BatchGetEdgeDriverResponse>(DoRequest("BatchGetEdgeDriver", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<BatchGetEdgeDriverResponse> BatchGetEdgeDriverWithOptionsAsync(BatchGetEdgeDriverRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<BatchGetEdgeDriverResponse>(await DoRequestAsync("BatchGetEdgeDriver", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public BatchGetEdgeDriverResponse BatchGetEdgeDriver(BatchGetEdgeDriverRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return BatchGetEdgeDriverWithOptions(request, runtime);
        }

        public async Task<BatchGetEdgeDriverResponse> BatchGetEdgeDriverAsync(BatchGetEdgeDriverRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await BatchGetEdgeDriverWithOptionsAsync(request, runtime);
        }

        public CreateEdgeDriverResponse CreateEdgeDriverWithOptions(CreateEdgeDriverRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CreateEdgeDriverResponse>(DoRequest("CreateEdgeDriver", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<CreateEdgeDriverResponse> CreateEdgeDriverWithOptionsAsync(CreateEdgeDriverRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CreateEdgeDriverResponse>(await DoRequestAsync("CreateEdgeDriver", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public CreateEdgeDriverResponse CreateEdgeDriver(CreateEdgeDriverRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateEdgeDriverWithOptions(request, runtime);
        }

        public async Task<CreateEdgeDriverResponse> CreateEdgeDriverAsync(CreateEdgeDriverRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateEdgeDriverWithOptionsAsync(request, runtime);
        }

        public GetEdgeDriverVersionResponse GetEdgeDriverVersionWithOptions(GetEdgeDriverVersionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetEdgeDriverVersionResponse>(DoRequest("GetEdgeDriverVersion", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<GetEdgeDriverVersionResponse> GetEdgeDriverVersionWithOptionsAsync(GetEdgeDriverVersionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetEdgeDriverVersionResponse>(await DoRequestAsync("GetEdgeDriverVersion", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public GetEdgeDriverVersionResponse GetEdgeDriverVersion(GetEdgeDriverVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetEdgeDriverVersionWithOptions(request, runtime);
        }

        public async Task<GetEdgeDriverVersionResponse> GetEdgeDriverVersionAsync(GetEdgeDriverVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetEdgeDriverVersionWithOptionsAsync(request, runtime);
        }

        public QueryEdgeDriverVersionResponse QueryEdgeDriverVersionWithOptions(QueryEdgeDriverVersionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<QueryEdgeDriverVersionResponse>(DoRequest("QueryEdgeDriverVersion", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<QueryEdgeDriverVersionResponse> QueryEdgeDriverVersionWithOptionsAsync(QueryEdgeDriverVersionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<QueryEdgeDriverVersionResponse>(await DoRequestAsync("QueryEdgeDriverVersion", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public QueryEdgeDriverVersionResponse QueryEdgeDriverVersion(QueryEdgeDriverVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryEdgeDriverVersionWithOptions(request, runtime);
        }

        public async Task<QueryEdgeDriverVersionResponse> QueryEdgeDriverVersionAsync(QueryEdgeDriverVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryEdgeDriverVersionWithOptionsAsync(request, runtime);
        }

        public BatchGetDeviceBindStatusResponse BatchGetDeviceBindStatusWithOptions(BatchGetDeviceBindStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<BatchGetDeviceBindStatusResponse>(DoRequest("BatchGetDeviceBindStatus", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<BatchGetDeviceBindStatusResponse> BatchGetDeviceBindStatusWithOptionsAsync(BatchGetDeviceBindStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<BatchGetDeviceBindStatusResponse>(await DoRequestAsync("BatchGetDeviceBindStatus", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public BatchGetDeviceBindStatusResponse BatchGetDeviceBindStatus(BatchGetDeviceBindStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return BatchGetDeviceBindStatusWithOptions(request, runtime);
        }

        public async Task<BatchGetDeviceBindStatusResponse> BatchGetDeviceBindStatusAsync(BatchGetDeviceBindStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await BatchGetDeviceBindStatusWithOptionsAsync(request, runtime);
        }

        public ListOTAJobByDeviceResponse ListOTAJobByDeviceWithOptions(ListOTAJobByDeviceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ListOTAJobByDeviceResponse>(DoRequest("ListOTAJobByDevice", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<ListOTAJobByDeviceResponse> ListOTAJobByDeviceWithOptionsAsync(ListOTAJobByDeviceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ListOTAJobByDeviceResponse>(await DoRequestAsync("ListOTAJobByDevice", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public ListOTAJobByDeviceResponse ListOTAJobByDevice(ListOTAJobByDeviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListOTAJobByDeviceWithOptions(request, runtime);
        }

        public async Task<ListOTAJobByDeviceResponse> ListOTAJobByDeviceAsync(ListOTAJobByDeviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListOTAJobByDeviceWithOptionsAsync(request, runtime);
        }

        public UpdateThingModelResponse UpdateThingModelWithOptions(UpdateThingModelRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<UpdateThingModelResponse>(DoRequest("UpdateThingModel", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<UpdateThingModelResponse> UpdateThingModelWithOptionsAsync(UpdateThingModelRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<UpdateThingModelResponse>(await DoRequestAsync("UpdateThingModel", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public UpdateThingModelResponse UpdateThingModel(UpdateThingModelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateThingModelWithOptions(request, runtime);
        }

        public async Task<UpdateThingModelResponse> UpdateThingModelAsync(UpdateThingModelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateThingModelWithOptionsAsync(request, runtime);
        }

        public CreateThingModelResponse CreateThingModelWithOptions(CreateThingModelRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CreateThingModelResponse>(DoRequest("CreateThingModel", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<CreateThingModelResponse> CreateThingModelWithOptionsAsync(CreateThingModelRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CreateThingModelResponse>(await DoRequestAsync("CreateThingModel", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public CreateThingModelResponse CreateThingModel(CreateThingModelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateThingModelWithOptions(request, runtime);
        }

        public async Task<CreateThingModelResponse> CreateThingModelAsync(CreateThingModelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateThingModelWithOptionsAsync(request, runtime);
        }

        public ListOTATaskByJobResponse ListOTATaskByJobWithOptions(ListOTATaskByJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ListOTATaskByJobResponse>(DoRequest("ListOTATaskByJob", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<ListOTATaskByJobResponse> ListOTATaskByJobWithOptionsAsync(ListOTATaskByJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ListOTATaskByJobResponse>(await DoRequestAsync("ListOTATaskByJob", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public ListOTATaskByJobResponse ListOTATaskByJob(ListOTATaskByJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListOTATaskByJobWithOptions(request, runtime);
        }

        public async Task<ListOTATaskByJobResponse> ListOTATaskByJobAsync(ListOTATaskByJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListOTATaskByJobWithOptionsAsync(request, runtime);
        }

        public ListThingTemplatesResponse ListThingTemplatesWithOptions(ListThingTemplatesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ListThingTemplatesResponse>(DoRequest("ListThingTemplates", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<ListThingTemplatesResponse> ListThingTemplatesWithOptionsAsync(ListThingTemplatesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ListThingTemplatesResponse>(await DoRequestAsync("ListThingTemplates", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public ListThingTemplatesResponse ListThingTemplates(ListThingTemplatesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListThingTemplatesWithOptions(request, runtime);
        }

        public async Task<ListThingTemplatesResponse> ListThingTemplatesAsync(ListThingTemplatesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListThingTemplatesWithOptionsAsync(request, runtime);
        }

        public GetThingTemplateResponse GetThingTemplateWithOptions(GetThingTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetThingTemplateResponse>(DoRequest("GetThingTemplate", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<GetThingTemplateResponse> GetThingTemplateWithOptionsAsync(GetThingTemplateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetThingTemplateResponse>(await DoRequestAsync("GetThingTemplate", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public GetThingTemplateResponse GetThingTemplate(GetThingTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetThingTemplateWithOptions(request, runtime);
        }

        public async Task<GetThingTemplateResponse> GetThingTemplateAsync(GetThingTemplateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetThingTemplateWithOptionsAsync(request, runtime);
        }

        public ListThingModelVersionResponse ListThingModelVersionWithOptions(ListThingModelVersionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ListThingModelVersionResponse>(DoRequest("ListThingModelVersion", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<ListThingModelVersionResponse> ListThingModelVersionWithOptionsAsync(ListThingModelVersionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ListThingModelVersionResponse>(await DoRequestAsync("ListThingModelVersion", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public ListThingModelVersionResponse ListThingModelVersion(ListThingModelVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListThingModelVersionWithOptions(request, runtime);
        }

        public async Task<ListThingModelVersionResponse> ListThingModelVersionAsync(ListThingModelVersionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListThingModelVersionWithOptionsAsync(request, runtime);
        }

        public ImportThingModelTslResponse ImportThingModelTslWithOptions(ImportThingModelTslRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ImportThingModelTslResponse>(DoRequest("ImportThingModelTsl", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<ImportThingModelTslResponse> ImportThingModelTslWithOptionsAsync(ImportThingModelTslRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ImportThingModelTslResponse>(await DoRequestAsync("ImportThingModelTsl", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public ImportThingModelTslResponse ImportThingModelTsl(ImportThingModelTslRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ImportThingModelTslWithOptions(request, runtime);
        }

        public async Task<ImportThingModelTslResponse> ImportThingModelTslAsync(ImportThingModelTslRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ImportThingModelTslWithOptionsAsync(request, runtime);
        }

        public PublishThingModelResponse PublishThingModelWithOptions(PublishThingModelRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<PublishThingModelResponse>(DoRequest("PublishThingModel", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<PublishThingModelResponse> PublishThingModelWithOptionsAsync(PublishThingModelRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<PublishThingModelResponse>(await DoRequestAsync("PublishThingModel", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public PublishThingModelResponse PublishThingModel(PublishThingModelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return PublishThingModelWithOptions(request, runtime);
        }

        public async Task<PublishThingModelResponse> PublishThingModelAsync(PublishThingModelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await PublishThingModelWithOptionsAsync(request, runtime);
        }

        public CopyThingModelResponse CopyThingModelWithOptions(CopyThingModelRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CopyThingModelResponse>(DoRequest("CopyThingModel", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<CopyThingModelResponse> CopyThingModelWithOptionsAsync(CopyThingModelRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CopyThingModelResponse>(await DoRequestAsync("CopyThingModel", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public CopyThingModelResponse CopyThingModel(CopyThingModelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CopyThingModelWithOptions(request, runtime);
        }

        public async Task<CopyThingModelResponse> CopyThingModelAsync(CopyThingModelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CopyThingModelWithOptionsAsync(request, runtime);
        }

        public GetThingModelTslResponse GetThingModelTslWithOptions(GetThingModelTslRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetThingModelTslResponse>(DoRequest("GetThingModelTsl", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<GetThingModelTslResponse> GetThingModelTslWithOptionsAsync(GetThingModelTslRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetThingModelTslResponse>(await DoRequestAsync("GetThingModelTsl", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public GetThingModelTslResponse GetThingModelTsl(GetThingModelTslRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetThingModelTslWithOptions(request, runtime);
        }

        public async Task<GetThingModelTslResponse> GetThingModelTslAsync(GetThingModelTslRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetThingModelTslWithOptionsAsync(request, runtime);
        }

        public QueryThingModelResponse QueryThingModelWithOptions(QueryThingModelRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<QueryThingModelResponse>(DoRequest("QueryThingModel", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<QueryThingModelResponse> QueryThingModelWithOptionsAsync(QueryThingModelRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<QueryThingModelResponse>(await DoRequestAsync("QueryThingModel", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public QueryThingModelResponse QueryThingModel(QueryThingModelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryThingModelWithOptions(request, runtime);
        }

        public async Task<QueryThingModelResponse> QueryThingModelAsync(QueryThingModelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryThingModelWithOptionsAsync(request, runtime);
        }

        public DeleteThingModelResponse DeleteThingModelWithOptions(DeleteThingModelRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DeleteThingModelResponse>(DoRequest("DeleteThingModel", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DeleteThingModelResponse> DeleteThingModelWithOptionsAsync(DeleteThingModelRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DeleteThingModelResponse>(await DoRequestAsync("DeleteThingModel", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public DeleteThingModelResponse DeleteThingModel(DeleteThingModelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteThingModelWithOptions(request, runtime);
        }

        public async Task<DeleteThingModelResponse> DeleteThingModelAsync(DeleteThingModelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteThingModelWithOptionsAsync(request, runtime);
        }

        public UpdateProductFilterConfigResponse UpdateProductFilterConfigWithOptions(UpdateProductFilterConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<UpdateProductFilterConfigResponse>(DoRequest("UpdateProductFilterConfig", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<UpdateProductFilterConfigResponse> UpdateProductFilterConfigWithOptionsAsync(UpdateProductFilterConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<UpdateProductFilterConfigResponse>(await DoRequestAsync("UpdateProductFilterConfig", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public UpdateProductFilterConfigResponse UpdateProductFilterConfig(UpdateProductFilterConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateProductFilterConfigWithOptions(request, runtime);
        }

        public async Task<UpdateProductFilterConfigResponse> UpdateProductFilterConfigAsync(UpdateProductFilterConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateProductFilterConfigWithOptionsAsync(request, runtime);
        }

        public CancelOTAStrategyByJobResponse CancelOTAStrategyByJobWithOptions(CancelOTAStrategyByJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CancelOTAStrategyByJobResponse>(DoRequest("CancelOTAStrategyByJob", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<CancelOTAStrategyByJobResponse> CancelOTAStrategyByJobWithOptionsAsync(CancelOTAStrategyByJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CancelOTAStrategyByJobResponse>(await DoRequestAsync("CancelOTAStrategyByJob", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public CancelOTAStrategyByJobResponse CancelOTAStrategyByJob(CancelOTAStrategyByJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CancelOTAStrategyByJobWithOptions(request, runtime);
        }

        public async Task<CancelOTAStrategyByJobResponse> CancelOTAStrategyByJobAsync(CancelOTAStrategyByJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CancelOTAStrategyByJobWithOptionsAsync(request, runtime);
        }

        public ListOTAJobByFirmwareResponse ListOTAJobByFirmwareWithOptions(ListOTAJobByFirmwareRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ListOTAJobByFirmwareResponse>(DoRequest("ListOTAJobByFirmware", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<ListOTAJobByFirmwareResponse> ListOTAJobByFirmwareWithOptionsAsync(ListOTAJobByFirmwareRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ListOTAJobByFirmwareResponse>(await DoRequestAsync("ListOTAJobByFirmware", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public ListOTAJobByFirmwareResponse ListOTAJobByFirmware(ListOTAJobByFirmwareRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListOTAJobByFirmwareWithOptions(request, runtime);
        }

        public async Task<ListOTAJobByFirmwareResponse> ListOTAJobByFirmwareAsync(ListOTAJobByFirmwareRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListOTAJobByFirmwareWithOptionsAsync(request, runtime);
        }

        public ListOTAFirmwareResponse ListOTAFirmwareWithOptions(ListOTAFirmwareRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ListOTAFirmwareResponse>(DoRequest("ListOTAFirmware", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<ListOTAFirmwareResponse> ListOTAFirmwareWithOptionsAsync(ListOTAFirmwareRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ListOTAFirmwareResponse>(await DoRequestAsync("ListOTAFirmware", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public ListOTAFirmwareResponse ListOTAFirmware(ListOTAFirmwareRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListOTAFirmwareWithOptions(request, runtime);
        }

        public async Task<ListOTAFirmwareResponse> ListOTAFirmwareAsync(ListOTAFirmwareRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListOTAFirmwareWithOptionsAsync(request, runtime);
        }

        public CancelOTATaskByJobResponse CancelOTATaskByJobWithOptions(CancelOTATaskByJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CancelOTATaskByJobResponse>(DoRequest("CancelOTATaskByJob", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<CancelOTATaskByJobResponse> CancelOTATaskByJobWithOptionsAsync(CancelOTATaskByJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CancelOTATaskByJobResponse>(await DoRequestAsync("CancelOTATaskByJob", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public CancelOTATaskByJobResponse CancelOTATaskByJob(CancelOTATaskByJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CancelOTATaskByJobWithOptions(request, runtime);
        }

        public async Task<CancelOTATaskByJobResponse> CancelOTATaskByJobAsync(CancelOTATaskByJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CancelOTATaskByJobWithOptionsAsync(request, runtime);
        }

        public CreateDeviceDistributeJobResponse CreateDeviceDistributeJobWithOptions(CreateDeviceDistributeJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CreateDeviceDistributeJobResponse>(DoRequest("CreateDeviceDistributeJob", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<CreateDeviceDistributeJobResponse> CreateDeviceDistributeJobWithOptionsAsync(CreateDeviceDistributeJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CreateDeviceDistributeJobResponse>(await DoRequestAsync("CreateDeviceDistributeJob", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public CreateDeviceDistributeJobResponse CreateDeviceDistributeJob(CreateDeviceDistributeJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateDeviceDistributeJobWithOptions(request, runtime);
        }

        public async Task<CreateDeviceDistributeJobResponse> CreateDeviceDistributeJobAsync(CreateDeviceDistributeJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateDeviceDistributeJobWithOptionsAsync(request, runtime);
        }

        public QueryDeviceDistributeDetailResponse QueryDeviceDistributeDetailWithOptions(QueryDeviceDistributeDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<QueryDeviceDistributeDetailResponse>(DoRequest("QueryDeviceDistributeDetail", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<QueryDeviceDistributeDetailResponse> QueryDeviceDistributeDetailWithOptionsAsync(QueryDeviceDistributeDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<QueryDeviceDistributeDetailResponse>(await DoRequestAsync("QueryDeviceDistributeDetail", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public QueryDeviceDistributeDetailResponse QueryDeviceDistributeDetail(QueryDeviceDistributeDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryDeviceDistributeDetailWithOptions(request, runtime);
        }

        public async Task<QueryDeviceDistributeDetailResponse> QueryDeviceDistributeDetailAsync(QueryDeviceDistributeDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryDeviceDistributeDetailWithOptionsAsync(request, runtime);
        }

        public ListDeviceDistributeJobResponse ListDeviceDistributeJobWithOptions(ListDeviceDistributeJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ListDeviceDistributeJobResponse>(DoRequest("ListDeviceDistributeJob", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<ListDeviceDistributeJobResponse> ListDeviceDistributeJobWithOptionsAsync(ListDeviceDistributeJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ListDeviceDistributeJobResponse>(await DoRequestAsync("ListDeviceDistributeJob", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public ListDeviceDistributeJobResponse ListDeviceDistributeJob(ListDeviceDistributeJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListDeviceDistributeJobWithOptions(request, runtime);
        }

        public async Task<ListDeviceDistributeJobResponse> ListDeviceDistributeJobAsync(ListDeviceDistributeJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListDeviceDistributeJobWithOptionsAsync(request, runtime);
        }

        public QueryDeviceDistributeJobResponse QueryDeviceDistributeJobWithOptions(QueryDeviceDistributeJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<QueryDeviceDistributeJobResponse>(DoRequest("QueryDeviceDistributeJob", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<QueryDeviceDistributeJobResponse> QueryDeviceDistributeJobWithOptionsAsync(QueryDeviceDistributeJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<QueryDeviceDistributeJobResponse>(await DoRequestAsync("QueryDeviceDistributeJob", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public QueryDeviceDistributeJobResponse QueryDeviceDistributeJob(QueryDeviceDistributeJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryDeviceDistributeJobWithOptions(request, runtime);
        }

        public async Task<QueryDeviceDistributeJobResponse> QueryDeviceDistributeJobAsync(QueryDeviceDistributeJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryDeviceDistributeJobWithOptionsAsync(request, runtime);
        }

        public DeleteDeviceDistributeJobResponse DeleteDeviceDistributeJobWithOptions(DeleteDeviceDistributeJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DeleteDeviceDistributeJobResponse>(DoRequest("DeleteDeviceDistributeJob", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DeleteDeviceDistributeJobResponse> DeleteDeviceDistributeJobWithOptionsAsync(DeleteDeviceDistributeJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DeleteDeviceDistributeJobResponse>(await DoRequestAsync("DeleteDeviceDistributeJob", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public DeleteDeviceDistributeJobResponse DeleteDeviceDistributeJob(DeleteDeviceDistributeJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteDeviceDistributeJobWithOptions(request, runtime);
        }

        public async Task<DeleteDeviceDistributeJobResponse> DeleteDeviceDistributeJobAsync(DeleteDeviceDistributeJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteDeviceDistributeJobWithOptionsAsync(request, runtime);
        }

        public QueryDeviceByStatusResponse QueryDeviceByStatusWithOptions(QueryDeviceByStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<QueryDeviceByStatusResponse>(DoRequest("QueryDeviceByStatus", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<QueryDeviceByStatusResponse> QueryDeviceByStatusWithOptionsAsync(QueryDeviceByStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<QueryDeviceByStatusResponse>(await DoRequestAsync("QueryDeviceByStatus", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public QueryDeviceByStatusResponse QueryDeviceByStatus(QueryDeviceByStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryDeviceByStatusWithOptions(request, runtime);
        }

        public async Task<QueryDeviceByStatusResponse> QueryDeviceByStatusAsync(QueryDeviceByStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryDeviceByStatusWithOptionsAsync(request, runtime);
        }

        public GenerateOTAUploadURLResponse GenerateOTAUploadURLWithOptions(GenerateOTAUploadURLRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GenerateOTAUploadURLResponse>(DoRequest("GenerateOTAUploadURL", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<GenerateOTAUploadURLResponse> GenerateOTAUploadURLWithOptionsAsync(GenerateOTAUploadURLRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GenerateOTAUploadURLResponse>(await DoRequestAsync("GenerateOTAUploadURL", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public GenerateOTAUploadURLResponse GenerateOTAUploadURL(GenerateOTAUploadURLRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GenerateOTAUploadURLWithOptions(request, runtime);
        }

        public async Task<GenerateOTAUploadURLResponse> GenerateOTAUploadURLAsync(GenerateOTAUploadURLRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GenerateOTAUploadURLWithOptionsAsync(request, runtime);
        }

        public QueryProductCertInfoResponse QueryProductCertInfoWithOptions(QueryProductCertInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<QueryProductCertInfoResponse>(DoRequest("QueryProductCertInfo", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<QueryProductCertInfoResponse> QueryProductCertInfoWithOptionsAsync(QueryProductCertInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<QueryProductCertInfoResponse>(await DoRequestAsync("QueryProductCertInfo", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public QueryProductCertInfoResponse QueryProductCertInfo(QueryProductCertInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryProductCertInfoWithOptions(request, runtime);
        }

        public async Task<QueryProductCertInfoResponse> QueryProductCertInfoAsync(QueryProductCertInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryProductCertInfoWithOptionsAsync(request, runtime);
        }

        public SetProductCertInfoResponse SetProductCertInfoWithOptions(SetProductCertInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<SetProductCertInfoResponse>(DoRequest("SetProductCertInfo", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<SetProductCertInfoResponse> SetProductCertInfoWithOptionsAsync(SetProductCertInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<SetProductCertInfoResponse>(await DoRequestAsync("SetProductCertInfo", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public SetProductCertInfoResponse SetProductCertInfo(SetProductCertInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetProductCertInfoWithOptions(request, runtime);
        }

        public async Task<SetProductCertInfoResponse> SetProductCertInfoAsync(SetProductCertInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetProductCertInfoWithOptionsAsync(request, runtime);
        }

        public CreateSubscribeRelationResponse CreateSubscribeRelationWithOptions(CreateSubscribeRelationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CreateSubscribeRelationResponse>(DoRequest("CreateSubscribeRelation", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<CreateSubscribeRelationResponse> CreateSubscribeRelationWithOptionsAsync(CreateSubscribeRelationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CreateSubscribeRelationResponse>(await DoRequestAsync("CreateSubscribeRelation", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public CreateSubscribeRelationResponse CreateSubscribeRelation(CreateSubscribeRelationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateSubscribeRelationWithOptions(request, runtime);
        }

        public async Task<CreateSubscribeRelationResponse> CreateSubscribeRelationAsync(CreateSubscribeRelationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateSubscribeRelationWithOptionsAsync(request, runtime);
        }

        public DeleteSubscribeRelationResponse DeleteSubscribeRelationWithOptions(DeleteSubscribeRelationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DeleteSubscribeRelationResponse>(DoRequest("DeleteSubscribeRelation", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DeleteSubscribeRelationResponse> DeleteSubscribeRelationWithOptionsAsync(DeleteSubscribeRelationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DeleteSubscribeRelationResponse>(await DoRequestAsync("DeleteSubscribeRelation", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public DeleteSubscribeRelationResponse DeleteSubscribeRelation(DeleteSubscribeRelationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteSubscribeRelationWithOptions(request, runtime);
        }

        public async Task<DeleteSubscribeRelationResponse> DeleteSubscribeRelationAsync(DeleteSubscribeRelationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteSubscribeRelationWithOptionsAsync(request, runtime);
        }

        public QueryConsumerGroupStatusResponse QueryConsumerGroupStatusWithOptions(QueryConsumerGroupStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<QueryConsumerGroupStatusResponse>(DoRequest("QueryConsumerGroupStatus", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<QueryConsumerGroupStatusResponse> QueryConsumerGroupStatusWithOptionsAsync(QueryConsumerGroupStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<QueryConsumerGroupStatusResponse>(await DoRequestAsync("QueryConsumerGroupStatus", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public QueryConsumerGroupStatusResponse QueryConsumerGroupStatus(QueryConsumerGroupStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryConsumerGroupStatusWithOptions(request, runtime);
        }

        public async Task<QueryConsumerGroupStatusResponse> QueryConsumerGroupStatusAsync(QueryConsumerGroupStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryConsumerGroupStatusWithOptionsAsync(request, runtime);
        }

        public DeleteConsumerGroupResponse DeleteConsumerGroupWithOptions(DeleteConsumerGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DeleteConsumerGroupResponse>(DoRequest("DeleteConsumerGroup", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DeleteConsumerGroupResponse> DeleteConsumerGroupWithOptionsAsync(DeleteConsumerGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DeleteConsumerGroupResponse>(await DoRequestAsync("DeleteConsumerGroup", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public DeleteConsumerGroupResponse DeleteConsumerGroup(DeleteConsumerGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteConsumerGroupWithOptions(request, runtime);
        }

        public async Task<DeleteConsumerGroupResponse> DeleteConsumerGroupAsync(DeleteConsumerGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteConsumerGroupWithOptionsAsync(request, runtime);
        }

        public QueryConsumerGroupListResponse QueryConsumerGroupListWithOptions(QueryConsumerGroupListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<QueryConsumerGroupListResponse>(DoRequest("QueryConsumerGroupList", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<QueryConsumerGroupListResponse> QueryConsumerGroupListWithOptionsAsync(QueryConsumerGroupListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<QueryConsumerGroupListResponse>(await DoRequestAsync("QueryConsumerGroupList", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public QueryConsumerGroupListResponse QueryConsumerGroupList(QueryConsumerGroupListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryConsumerGroupListWithOptions(request, runtime);
        }

        public async Task<QueryConsumerGroupListResponse> QueryConsumerGroupListAsync(QueryConsumerGroupListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryConsumerGroupListWithOptionsAsync(request, runtime);
        }

        public QueryConsumerGroupByGroupIdResponse QueryConsumerGroupByGroupIdWithOptions(QueryConsumerGroupByGroupIdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<QueryConsumerGroupByGroupIdResponse>(DoRequest("QueryConsumerGroupByGroupId", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<QueryConsumerGroupByGroupIdResponse> QueryConsumerGroupByGroupIdWithOptionsAsync(QueryConsumerGroupByGroupIdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<QueryConsumerGroupByGroupIdResponse>(await DoRequestAsync("QueryConsumerGroupByGroupId", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public QueryConsumerGroupByGroupIdResponse QueryConsumerGroupByGroupId(QueryConsumerGroupByGroupIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryConsumerGroupByGroupIdWithOptions(request, runtime);
        }

        public async Task<QueryConsumerGroupByGroupIdResponse> QueryConsumerGroupByGroupIdAsync(QueryConsumerGroupByGroupIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryConsumerGroupByGroupIdWithOptionsAsync(request, runtime);
        }

        public CreateConsumerGroupResponse CreateConsumerGroupWithOptions(CreateConsumerGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CreateConsumerGroupResponse>(DoRequest("CreateConsumerGroup", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<CreateConsumerGroupResponse> CreateConsumerGroupWithOptionsAsync(CreateConsumerGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CreateConsumerGroupResponse>(await DoRequestAsync("CreateConsumerGroup", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public CreateConsumerGroupResponse CreateConsumerGroup(CreateConsumerGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateConsumerGroupWithOptions(request, runtime);
        }

        public async Task<CreateConsumerGroupResponse> CreateConsumerGroupAsync(CreateConsumerGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateConsumerGroupWithOptionsAsync(request, runtime);
        }

        public CreateOTADynamicUpgradeJobResponse CreateOTADynamicUpgradeJobWithOptions(CreateOTADynamicUpgradeJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CreateOTADynamicUpgradeJobResponse>(DoRequest("CreateOTADynamicUpgradeJob", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<CreateOTADynamicUpgradeJobResponse> CreateOTADynamicUpgradeJobWithOptionsAsync(CreateOTADynamicUpgradeJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CreateOTADynamicUpgradeJobResponse>(await DoRequestAsync("CreateOTADynamicUpgradeJob", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public CreateOTADynamicUpgradeJobResponse CreateOTADynamicUpgradeJob(CreateOTADynamicUpgradeJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateOTADynamicUpgradeJobWithOptions(request, runtime);
        }

        public async Task<CreateOTADynamicUpgradeJobResponse> CreateOTADynamicUpgradeJobAsync(CreateOTADynamicUpgradeJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateOTADynamicUpgradeJobWithOptionsAsync(request, runtime);
        }

        public CreateOTAStaticUpgradeJobResponse CreateOTAStaticUpgradeJobWithOptions(CreateOTAStaticUpgradeJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CreateOTAStaticUpgradeJobResponse>(DoRequest("CreateOTAStaticUpgradeJob", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<CreateOTAStaticUpgradeJobResponse> CreateOTAStaticUpgradeJobWithOptionsAsync(CreateOTAStaticUpgradeJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CreateOTAStaticUpgradeJobResponse>(await DoRequestAsync("CreateOTAStaticUpgradeJob", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public CreateOTAStaticUpgradeJobResponse CreateOTAStaticUpgradeJob(CreateOTAStaticUpgradeJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateOTAStaticUpgradeJobWithOptions(request, runtime);
        }

        public async Task<CreateOTAStaticUpgradeJobResponse> CreateOTAStaticUpgradeJobAsync(CreateOTAStaticUpgradeJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateOTAStaticUpgradeJobWithOptionsAsync(request, runtime);
        }

        public CreateOTAFirmwareResponse CreateOTAFirmwareWithOptions(CreateOTAFirmwareRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CreateOTAFirmwareResponse>(DoRequest("CreateOTAFirmware", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<CreateOTAFirmwareResponse> CreateOTAFirmwareWithOptionsAsync(CreateOTAFirmwareRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CreateOTAFirmwareResponse>(await DoRequestAsync("CreateOTAFirmware", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public CreateOTAFirmwareResponse CreateOTAFirmware(CreateOTAFirmwareRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateOTAFirmwareWithOptions(request, runtime);
        }

        public async Task<CreateOTAFirmwareResponse> CreateOTAFirmwareAsync(CreateOTAFirmwareRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateOTAFirmwareWithOptionsAsync(request, runtime);
        }

        public CreateOTAVerifyJobResponse CreateOTAVerifyJobWithOptions(CreateOTAVerifyJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CreateOTAVerifyJobResponse>(DoRequest("CreateOTAVerifyJob", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<CreateOTAVerifyJobResponse> CreateOTAVerifyJobWithOptionsAsync(CreateOTAVerifyJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CreateOTAVerifyJobResponse>(await DoRequestAsync("CreateOTAVerifyJob", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public CreateOTAVerifyJobResponse CreateOTAVerifyJob(CreateOTAVerifyJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateOTAVerifyJobWithOptions(request, runtime);
        }

        public async Task<CreateOTAVerifyJobResponse> CreateOTAVerifyJobAsync(CreateOTAVerifyJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateOTAVerifyJobWithOptionsAsync(request, runtime);
        }

        public QueryOTAJobResponse QueryOTAJobWithOptions(QueryOTAJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<QueryOTAJobResponse>(DoRequest("QueryOTAJob", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<QueryOTAJobResponse> QueryOTAJobWithOptionsAsync(QueryOTAJobRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<QueryOTAJobResponse>(await DoRequestAsync("QueryOTAJob", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public QueryOTAJobResponse QueryOTAJob(QueryOTAJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryOTAJobWithOptions(request, runtime);
        }

        public async Task<QueryOTAJobResponse> QueryOTAJobAsync(QueryOTAJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryOTAJobWithOptionsAsync(request, runtime);
        }

        public CancelOTATaskByDeviceResponse CancelOTATaskByDeviceWithOptions(CancelOTATaskByDeviceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CancelOTATaskByDeviceResponse>(DoRequest("CancelOTATaskByDevice", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<CancelOTATaskByDeviceResponse> CancelOTATaskByDeviceWithOptionsAsync(CancelOTATaskByDeviceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CancelOTATaskByDeviceResponse>(await DoRequestAsync("CancelOTATaskByDevice", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public CancelOTATaskByDeviceResponse CancelOTATaskByDevice(CancelOTATaskByDeviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CancelOTATaskByDeviceWithOptions(request, runtime);
        }

        public async Task<CancelOTATaskByDeviceResponse> CancelOTATaskByDeviceAsync(CancelOTATaskByDeviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CancelOTATaskByDeviceWithOptionsAsync(request, runtime);
        }

        public DeleteOTAFirmwareResponse DeleteOTAFirmwareWithOptions(DeleteOTAFirmwareRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DeleteOTAFirmwareResponse>(DoRequest("DeleteOTAFirmware", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DeleteOTAFirmwareResponse> DeleteOTAFirmwareWithOptionsAsync(DeleteOTAFirmwareRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DeleteOTAFirmwareResponse>(await DoRequestAsync("DeleteOTAFirmware", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public DeleteOTAFirmwareResponse DeleteOTAFirmware(DeleteOTAFirmwareRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteOTAFirmwareWithOptions(request, runtime);
        }

        public async Task<DeleteOTAFirmwareResponse> DeleteOTAFirmwareAsync(DeleteOTAFirmwareRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteOTAFirmwareWithOptionsAsync(request, runtime);
        }

        public QueryOTAFirmwareResponse QueryOTAFirmwareWithOptions(QueryOTAFirmwareRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<QueryOTAFirmwareResponse>(DoRequest("QueryOTAFirmware", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<QueryOTAFirmwareResponse> QueryOTAFirmwareWithOptionsAsync(QueryOTAFirmwareRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<QueryOTAFirmwareResponse>(await DoRequestAsync("QueryOTAFirmware", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public QueryOTAFirmwareResponse QueryOTAFirmware(QueryOTAFirmwareRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryOTAFirmwareWithOptions(request, runtime);
        }

        public async Task<QueryOTAFirmwareResponse> QueryOTAFirmwareAsync(QueryOTAFirmwareRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryOTAFirmwareWithOptionsAsync(request, runtime);
        }

        public UnbindApplicationFromEdgeInstanceResponse UnbindApplicationFromEdgeInstanceWithOptions(UnbindApplicationFromEdgeInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<UnbindApplicationFromEdgeInstanceResponse>(DoRequest("UnbindApplicationFromEdgeInstance", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<UnbindApplicationFromEdgeInstanceResponse> UnbindApplicationFromEdgeInstanceWithOptionsAsync(UnbindApplicationFromEdgeInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<UnbindApplicationFromEdgeInstanceResponse>(await DoRequestAsync("UnbindApplicationFromEdgeInstance", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public UnbindApplicationFromEdgeInstanceResponse UnbindApplicationFromEdgeInstance(UnbindApplicationFromEdgeInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UnbindApplicationFromEdgeInstanceWithOptions(request, runtime);
        }

        public async Task<UnbindApplicationFromEdgeInstanceResponse> UnbindApplicationFromEdgeInstanceAsync(UnbindApplicationFromEdgeInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UnbindApplicationFromEdgeInstanceWithOptionsAsync(request, runtime);
        }

        public BindApplicationToEdgeInstanceResponse BindApplicationToEdgeInstanceWithOptions(BindApplicationToEdgeInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<BindApplicationToEdgeInstanceResponse>(DoRequest("BindApplicationToEdgeInstance", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<BindApplicationToEdgeInstanceResponse> BindApplicationToEdgeInstanceWithOptionsAsync(BindApplicationToEdgeInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<BindApplicationToEdgeInstanceResponse>(await DoRequestAsync("BindApplicationToEdgeInstance", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public BindApplicationToEdgeInstanceResponse BindApplicationToEdgeInstance(BindApplicationToEdgeInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return BindApplicationToEdgeInstanceWithOptions(request, runtime);
        }

        public async Task<BindApplicationToEdgeInstanceResponse> BindApplicationToEdgeInstanceAsync(BindApplicationToEdgeInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await BindApplicationToEdgeInstanceWithOptionsAsync(request, runtime);
        }

        public QueryCertUrlByApplyIdResponse QueryCertUrlByApplyIdWithOptions(QueryCertUrlByApplyIdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<QueryCertUrlByApplyIdResponse>(DoRequest("QueryCertUrlByApplyId", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<QueryCertUrlByApplyIdResponse> QueryCertUrlByApplyIdWithOptionsAsync(QueryCertUrlByApplyIdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<QueryCertUrlByApplyIdResponse>(await DoRequestAsync("QueryCertUrlByApplyId", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public QueryCertUrlByApplyIdResponse QueryCertUrlByApplyId(QueryCertUrlByApplyIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryCertUrlByApplyIdWithOptions(request, runtime);
        }

        public async Task<QueryCertUrlByApplyIdResponse> QueryCertUrlByApplyIdAsync(QueryCertUrlByApplyIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryCertUrlByApplyIdWithOptionsAsync(request, runtime);
        }

        public QueryDeviceCertResponse QueryDeviceCertWithOptions(QueryDeviceCertRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<QueryDeviceCertResponse>(DoRequest("QueryDeviceCert", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<QueryDeviceCertResponse> QueryDeviceCertWithOptionsAsync(QueryDeviceCertRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<QueryDeviceCertResponse>(await DoRequestAsync("QueryDeviceCert", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public QueryDeviceCertResponse QueryDeviceCert(QueryDeviceCertRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryDeviceCertWithOptions(request, runtime);
        }

        public async Task<QueryDeviceCertResponse> QueryDeviceCertAsync(QueryDeviceCertRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryDeviceCertWithOptionsAsync(request, runtime);
        }

        public CloseEdgeInstanceDeploymentResponse CloseEdgeInstanceDeploymentWithOptions(CloseEdgeInstanceDeploymentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CloseEdgeInstanceDeploymentResponse>(DoRequest("CloseEdgeInstanceDeployment", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<CloseEdgeInstanceDeploymentResponse> CloseEdgeInstanceDeploymentWithOptionsAsync(CloseEdgeInstanceDeploymentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CloseEdgeInstanceDeploymentResponse>(await DoRequestAsync("CloseEdgeInstanceDeployment", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public CloseEdgeInstanceDeploymentResponse CloseEdgeInstanceDeployment(CloseEdgeInstanceDeploymentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CloseEdgeInstanceDeploymentWithOptions(request, runtime);
        }

        public async Task<CloseEdgeInstanceDeploymentResponse> CloseEdgeInstanceDeploymentAsync(CloseEdgeInstanceDeploymentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CloseEdgeInstanceDeploymentWithOptionsAsync(request, runtime);
        }

        public UnbindDriverFromEdgeInstanceResponse UnbindDriverFromEdgeInstanceWithOptions(UnbindDriverFromEdgeInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<UnbindDriverFromEdgeInstanceResponse>(DoRequest("UnbindDriverFromEdgeInstance", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<UnbindDriverFromEdgeInstanceResponse> UnbindDriverFromEdgeInstanceWithOptionsAsync(UnbindDriverFromEdgeInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<UnbindDriverFromEdgeInstanceResponse>(await DoRequestAsync("UnbindDriverFromEdgeInstance", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public UnbindDriverFromEdgeInstanceResponse UnbindDriverFromEdgeInstance(UnbindDriverFromEdgeInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UnbindDriverFromEdgeInstanceWithOptions(request, runtime);
        }

        public async Task<UnbindDriverFromEdgeInstanceResponse> UnbindDriverFromEdgeInstanceAsync(UnbindDriverFromEdgeInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UnbindDriverFromEdgeInstanceWithOptionsAsync(request, runtime);
        }

        public ReplaceEdgeInstanceGatewayResponse ReplaceEdgeInstanceGatewayWithOptions(ReplaceEdgeInstanceGatewayRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ReplaceEdgeInstanceGatewayResponse>(DoRequest("ReplaceEdgeInstanceGateway", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<ReplaceEdgeInstanceGatewayResponse> ReplaceEdgeInstanceGatewayWithOptionsAsync(ReplaceEdgeInstanceGatewayRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ReplaceEdgeInstanceGatewayResponse>(await DoRequestAsync("ReplaceEdgeInstanceGateway", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public ReplaceEdgeInstanceGatewayResponse ReplaceEdgeInstanceGateway(ReplaceEdgeInstanceGatewayRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ReplaceEdgeInstanceGatewayWithOptions(request, runtime);
        }

        public async Task<ReplaceEdgeInstanceGatewayResponse> ReplaceEdgeInstanceGatewayAsync(ReplaceEdgeInstanceGatewayRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ReplaceEdgeInstanceGatewayWithOptionsAsync(request, runtime);
        }

        public BindDriverToEdgeInstanceResponse BindDriverToEdgeInstanceWithOptions(BindDriverToEdgeInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<BindDriverToEdgeInstanceResponse>(DoRequest("BindDriverToEdgeInstance", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<BindDriverToEdgeInstanceResponse> BindDriverToEdgeInstanceWithOptionsAsync(BindDriverToEdgeInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<BindDriverToEdgeInstanceResponse>(await DoRequestAsync("BindDriverToEdgeInstance", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public BindDriverToEdgeInstanceResponse BindDriverToEdgeInstance(BindDriverToEdgeInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return BindDriverToEdgeInstanceWithOptions(request, runtime);
        }

        public async Task<BindDriverToEdgeInstanceResponse> BindDriverToEdgeInstanceAsync(BindDriverToEdgeInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await BindDriverToEdgeInstanceWithOptionsAsync(request, runtime);
        }

        public BatchQueryDeviceDetailResponse BatchQueryDeviceDetailWithOptions(BatchQueryDeviceDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<BatchQueryDeviceDetailResponse>(DoRequest("BatchQueryDeviceDetail", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<BatchQueryDeviceDetailResponse> BatchQueryDeviceDetailWithOptionsAsync(BatchQueryDeviceDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<BatchQueryDeviceDetailResponse>(await DoRequestAsync("BatchQueryDeviceDetail", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public BatchQueryDeviceDetailResponse BatchQueryDeviceDetail(BatchQueryDeviceDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return BatchQueryDeviceDetailWithOptions(request, runtime);
        }

        public async Task<BatchQueryDeviceDetailResponse> BatchQueryDeviceDetailAsync(BatchQueryDeviceDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await BatchQueryDeviceDetailWithOptionsAsync(request, runtime);
        }

        public GetEdgeInstanceDeploymentResponse GetEdgeInstanceDeploymentWithOptions(GetEdgeInstanceDeploymentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetEdgeInstanceDeploymentResponse>(DoRequest("GetEdgeInstanceDeployment", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<GetEdgeInstanceDeploymentResponse> GetEdgeInstanceDeploymentWithOptionsAsync(GetEdgeInstanceDeploymentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetEdgeInstanceDeploymentResponse>(await DoRequestAsync("GetEdgeInstanceDeployment", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public GetEdgeInstanceDeploymentResponse GetEdgeInstanceDeployment(GetEdgeInstanceDeploymentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetEdgeInstanceDeploymentWithOptions(request, runtime);
        }

        public async Task<GetEdgeInstanceDeploymentResponse> GetEdgeInstanceDeploymentAsync(GetEdgeInstanceDeploymentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetEdgeInstanceDeploymentWithOptionsAsync(request, runtime);
        }

        public QueryTaskResponse QueryTaskWithOptions(QueryTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<QueryTaskResponse>(DoRequest("QueryTask", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<QueryTaskResponse> QueryTaskWithOptionsAsync(QueryTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<QueryTaskResponse>(await DoRequestAsync("QueryTask", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public QueryTaskResponse QueryTask(QueryTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryTaskWithOptions(request, runtime);
        }

        public async Task<QueryTaskResponse> QueryTaskAsync(QueryTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryTaskWithOptionsAsync(request, runtime);
        }

        public CreateDataAPIServiceResponse CreateDataAPIServiceWithOptions(CreateDataAPIServiceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CreateDataAPIServiceResponse>(DoRequest("CreateDataAPIService", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<CreateDataAPIServiceResponse> CreateDataAPIServiceWithOptionsAsync(CreateDataAPIServiceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CreateDataAPIServiceResponse>(await DoRequestAsync("CreateDataAPIService", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public CreateDataAPIServiceResponse CreateDataAPIService(CreateDataAPIServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateDataAPIServiceWithOptions(request, runtime);
        }

        public async Task<CreateDataAPIServiceResponse> CreateDataAPIServiceAsync(CreateDataAPIServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateDataAPIServiceWithOptionsAsync(request, runtime);
        }

        public GetDataAPIServiceDetailResponse GetDataAPIServiceDetailWithOptions(GetDataAPIServiceDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetDataAPIServiceDetailResponse>(DoRequest("GetDataAPIServiceDetail", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<GetDataAPIServiceDetailResponse> GetDataAPIServiceDetailWithOptionsAsync(GetDataAPIServiceDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetDataAPIServiceDetailResponse>(await DoRequestAsync("GetDataAPIServiceDetail", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public GetDataAPIServiceDetailResponse GetDataAPIServiceDetail(GetDataAPIServiceDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetDataAPIServiceDetailWithOptions(request, runtime);
        }

        public async Task<GetDataAPIServiceDetailResponse> GetDataAPIServiceDetailAsync(GetDataAPIServiceDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetDataAPIServiceDetailWithOptionsAsync(request, runtime);
        }

        public InvokeDataAPIServiceResponse InvokeDataAPIServiceWithOptions(InvokeDataAPIServiceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<InvokeDataAPIServiceResponse>(DoRequest("InvokeDataAPIService", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<InvokeDataAPIServiceResponse> InvokeDataAPIServiceWithOptionsAsync(InvokeDataAPIServiceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<InvokeDataAPIServiceResponse>(await DoRequestAsync("InvokeDataAPIService", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public InvokeDataAPIServiceResponse InvokeDataAPIService(InvokeDataAPIServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return InvokeDataAPIServiceWithOptions(request, runtime);
        }

        public async Task<InvokeDataAPIServiceResponse> InvokeDataAPIServiceAsync(InvokeDataAPIServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await InvokeDataAPIServiceWithOptionsAsync(request, runtime);
        }

        public UpdateEdgeInstanceChannelResponse UpdateEdgeInstanceChannelWithOptions(UpdateEdgeInstanceChannelRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<UpdateEdgeInstanceChannelResponse>(DoRequest("UpdateEdgeInstanceChannel", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<UpdateEdgeInstanceChannelResponse> UpdateEdgeInstanceChannelWithOptionsAsync(UpdateEdgeInstanceChannelRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<UpdateEdgeInstanceChannelResponse>(await DoRequestAsync("UpdateEdgeInstanceChannel", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public UpdateEdgeInstanceChannelResponse UpdateEdgeInstanceChannel(UpdateEdgeInstanceChannelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateEdgeInstanceChannelWithOptions(request, runtime);
        }

        public async Task<UpdateEdgeInstanceChannelResponse> UpdateEdgeInstanceChannelAsync(UpdateEdgeInstanceChannelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateEdgeInstanceChannelWithOptionsAsync(request, runtime);
        }

        public QueryEdgeInstanceChannelResponse QueryEdgeInstanceChannelWithOptions(QueryEdgeInstanceChannelRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<QueryEdgeInstanceChannelResponse>(DoRequest("QueryEdgeInstanceChannel", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<QueryEdgeInstanceChannelResponse> QueryEdgeInstanceChannelWithOptionsAsync(QueryEdgeInstanceChannelRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<QueryEdgeInstanceChannelResponse>(await DoRequestAsync("QueryEdgeInstanceChannel", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public QueryEdgeInstanceChannelResponse QueryEdgeInstanceChannel(QueryEdgeInstanceChannelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryEdgeInstanceChannelWithOptions(request, runtime);
        }

        public async Task<QueryEdgeInstanceChannelResponse> QueryEdgeInstanceChannelAsync(QueryEdgeInstanceChannelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryEdgeInstanceChannelWithOptionsAsync(request, runtime);
        }

        public BatchUnbindDeviceFromEdgeInstanceResponse BatchUnbindDeviceFromEdgeInstanceWithOptions(BatchUnbindDeviceFromEdgeInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<BatchUnbindDeviceFromEdgeInstanceResponse>(DoRequest("BatchUnbindDeviceFromEdgeInstance", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<BatchUnbindDeviceFromEdgeInstanceResponse> BatchUnbindDeviceFromEdgeInstanceWithOptionsAsync(BatchUnbindDeviceFromEdgeInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<BatchUnbindDeviceFromEdgeInstanceResponse>(await DoRequestAsync("BatchUnbindDeviceFromEdgeInstance", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public BatchUnbindDeviceFromEdgeInstanceResponse BatchUnbindDeviceFromEdgeInstance(BatchUnbindDeviceFromEdgeInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return BatchUnbindDeviceFromEdgeInstanceWithOptions(request, runtime);
        }

        public async Task<BatchUnbindDeviceFromEdgeInstanceResponse> BatchUnbindDeviceFromEdgeInstanceAsync(BatchUnbindDeviceFromEdgeInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await BatchUnbindDeviceFromEdgeInstanceWithOptionsAsync(request, runtime);
        }

        public SetEdgeInstanceDriverConfigsResponse SetEdgeInstanceDriverConfigsWithOptions(SetEdgeInstanceDriverConfigsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<SetEdgeInstanceDriverConfigsResponse>(DoRequest("SetEdgeInstanceDriverConfigs", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<SetEdgeInstanceDriverConfigsResponse> SetEdgeInstanceDriverConfigsWithOptionsAsync(SetEdgeInstanceDriverConfigsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<SetEdgeInstanceDriverConfigsResponse>(await DoRequestAsync("SetEdgeInstanceDriverConfigs", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public SetEdgeInstanceDriverConfigsResponse SetEdgeInstanceDriverConfigs(SetEdgeInstanceDriverConfigsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetEdgeInstanceDriverConfigsWithOptions(request, runtime);
        }

        public async Task<SetEdgeInstanceDriverConfigsResponse> SetEdgeInstanceDriverConfigsAsync(SetEdgeInstanceDriverConfigsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetEdgeInstanceDriverConfigsWithOptionsAsync(request, runtime);
        }

        public CreateEdgeInstanceChannelResponse CreateEdgeInstanceChannelWithOptions(CreateEdgeInstanceChannelRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CreateEdgeInstanceChannelResponse>(DoRequest("CreateEdgeInstanceChannel", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<CreateEdgeInstanceChannelResponse> CreateEdgeInstanceChannelWithOptionsAsync(CreateEdgeInstanceChannelRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CreateEdgeInstanceChannelResponse>(await DoRequestAsync("CreateEdgeInstanceChannel", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public CreateEdgeInstanceChannelResponse CreateEdgeInstanceChannel(CreateEdgeInstanceChannelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateEdgeInstanceChannelWithOptions(request, runtime);
        }

        public async Task<CreateEdgeInstanceChannelResponse> CreateEdgeInstanceChannelAsync(CreateEdgeInstanceChannelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateEdgeInstanceChannelWithOptionsAsync(request, runtime);
        }

        public BatchBindDeviceToEdgeInstanceWithDriverResponse BatchBindDeviceToEdgeInstanceWithDriverWithOptions(BatchBindDeviceToEdgeInstanceWithDriverRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<BatchBindDeviceToEdgeInstanceWithDriverResponse>(DoRequest("BatchBindDeviceToEdgeInstanceWithDriver", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<BatchBindDeviceToEdgeInstanceWithDriverResponse> BatchBindDeviceToEdgeInstanceWithDriverWithOptionsAsync(BatchBindDeviceToEdgeInstanceWithDriverRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<BatchBindDeviceToEdgeInstanceWithDriverResponse>(await DoRequestAsync("BatchBindDeviceToEdgeInstanceWithDriver", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public BatchBindDeviceToEdgeInstanceWithDriverResponse BatchBindDeviceToEdgeInstanceWithDriver(BatchBindDeviceToEdgeInstanceWithDriverRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return BatchBindDeviceToEdgeInstanceWithDriverWithOptions(request, runtime);
        }

        public async Task<BatchBindDeviceToEdgeInstanceWithDriverResponse> BatchBindDeviceToEdgeInstanceWithDriverAsync(BatchBindDeviceToEdgeInstanceWithDriverRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await BatchBindDeviceToEdgeInstanceWithDriverWithOptionsAsync(request, runtime);
        }

        public BatchGetEdgeInstanceChannelResponse BatchGetEdgeInstanceChannelWithOptions(BatchGetEdgeInstanceChannelRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<BatchGetEdgeInstanceChannelResponse>(DoRequest("BatchGetEdgeInstanceChannel", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<BatchGetEdgeInstanceChannelResponse> BatchGetEdgeInstanceChannelWithOptionsAsync(BatchGetEdgeInstanceChannelRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<BatchGetEdgeInstanceChannelResponse>(await DoRequestAsync("BatchGetEdgeInstanceChannel", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public BatchGetEdgeInstanceChannelResponse BatchGetEdgeInstanceChannel(BatchGetEdgeInstanceChannelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return BatchGetEdgeInstanceChannelWithOptions(request, runtime);
        }

        public async Task<BatchGetEdgeInstanceChannelResponse> BatchGetEdgeInstanceChannelAsync(BatchGetEdgeInstanceChannelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await BatchGetEdgeInstanceChannelWithOptionsAsync(request, runtime);
        }

        public BatchSetEdgeInstanceDeviceConfigResponse BatchSetEdgeInstanceDeviceConfigWithOptions(BatchSetEdgeInstanceDeviceConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<BatchSetEdgeInstanceDeviceConfigResponse>(DoRequest("BatchSetEdgeInstanceDeviceConfig", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<BatchSetEdgeInstanceDeviceConfigResponse> BatchSetEdgeInstanceDeviceConfigWithOptionsAsync(BatchSetEdgeInstanceDeviceConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<BatchSetEdgeInstanceDeviceConfigResponse>(await DoRequestAsync("BatchSetEdgeInstanceDeviceConfig", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public BatchSetEdgeInstanceDeviceConfigResponse BatchSetEdgeInstanceDeviceConfig(BatchSetEdgeInstanceDeviceConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return BatchSetEdgeInstanceDeviceConfigWithOptions(request, runtime);
        }

        public async Task<BatchSetEdgeInstanceDeviceConfigResponse> BatchSetEdgeInstanceDeviceConfigAsync(BatchSetEdgeInstanceDeviceConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await BatchSetEdgeInstanceDeviceConfigWithOptionsAsync(request, runtime);
        }

        public BatchClearEdgeInstanceDeviceConfigResponse BatchClearEdgeInstanceDeviceConfigWithOptions(BatchClearEdgeInstanceDeviceConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<BatchClearEdgeInstanceDeviceConfigResponse>(DoRequest("BatchClearEdgeInstanceDeviceConfig", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<BatchClearEdgeInstanceDeviceConfigResponse> BatchClearEdgeInstanceDeviceConfigWithOptionsAsync(BatchClearEdgeInstanceDeviceConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<BatchClearEdgeInstanceDeviceConfigResponse>(await DoRequestAsync("BatchClearEdgeInstanceDeviceConfig", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public BatchClearEdgeInstanceDeviceConfigResponse BatchClearEdgeInstanceDeviceConfig(BatchClearEdgeInstanceDeviceConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return BatchClearEdgeInstanceDeviceConfigWithOptions(request, runtime);
        }

        public async Task<BatchClearEdgeInstanceDeviceConfigResponse> BatchClearEdgeInstanceDeviceConfigAsync(BatchClearEdgeInstanceDeviceConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await BatchClearEdgeInstanceDeviceConfigWithOptionsAsync(request, runtime);
        }

        public BatchGetEdgeInstanceDeviceConfigResponse BatchGetEdgeInstanceDeviceConfigWithOptions(BatchGetEdgeInstanceDeviceConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<BatchGetEdgeInstanceDeviceConfigResponse>(DoRequest("BatchGetEdgeInstanceDeviceConfig", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<BatchGetEdgeInstanceDeviceConfigResponse> BatchGetEdgeInstanceDeviceConfigWithOptionsAsync(BatchGetEdgeInstanceDeviceConfigRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<BatchGetEdgeInstanceDeviceConfigResponse>(await DoRequestAsync("BatchGetEdgeInstanceDeviceConfig", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public BatchGetEdgeInstanceDeviceConfigResponse BatchGetEdgeInstanceDeviceConfig(BatchGetEdgeInstanceDeviceConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return BatchGetEdgeInstanceDeviceConfigWithOptions(request, runtime);
        }

        public async Task<BatchGetEdgeInstanceDeviceConfigResponse> BatchGetEdgeInstanceDeviceConfigAsync(BatchGetEdgeInstanceDeviceConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await BatchGetEdgeInstanceDeviceConfigWithOptionsAsync(request, runtime);
        }

        public BatchGetEdgeInstanceDriverConfigsResponse BatchGetEdgeInstanceDriverConfigsWithOptions(BatchGetEdgeInstanceDriverConfigsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<BatchGetEdgeInstanceDriverConfigsResponse>(DoRequest("BatchGetEdgeInstanceDriverConfigs", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<BatchGetEdgeInstanceDriverConfigsResponse> BatchGetEdgeInstanceDriverConfigsWithOptionsAsync(BatchGetEdgeInstanceDriverConfigsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<BatchGetEdgeInstanceDriverConfigsResponse>(await DoRequestAsync("BatchGetEdgeInstanceDriverConfigs", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public BatchGetEdgeInstanceDriverConfigsResponse BatchGetEdgeInstanceDriverConfigs(BatchGetEdgeInstanceDriverConfigsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return BatchGetEdgeInstanceDriverConfigsWithOptions(request, runtime);
        }

        public async Task<BatchGetEdgeInstanceDriverConfigsResponse> BatchGetEdgeInstanceDriverConfigsAsync(BatchGetEdgeInstanceDriverConfigsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await BatchGetEdgeInstanceDriverConfigsWithOptionsAsync(request, runtime);
        }

        public ClearEdgeInstanceDriverConfigsResponse ClearEdgeInstanceDriverConfigsWithOptions(ClearEdgeInstanceDriverConfigsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ClearEdgeInstanceDriverConfigsResponse>(DoRequest("ClearEdgeInstanceDriverConfigs", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<ClearEdgeInstanceDriverConfigsResponse> ClearEdgeInstanceDriverConfigsWithOptionsAsync(ClearEdgeInstanceDriverConfigsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ClearEdgeInstanceDriverConfigsResponse>(await DoRequestAsync("ClearEdgeInstanceDriverConfigs", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public ClearEdgeInstanceDriverConfigsResponse ClearEdgeInstanceDriverConfigs(ClearEdgeInstanceDriverConfigsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ClearEdgeInstanceDriverConfigsWithOptions(request, runtime);
        }

        public async Task<ClearEdgeInstanceDriverConfigsResponse> ClearEdgeInstanceDriverConfigsAsync(ClearEdgeInstanceDriverConfigsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ClearEdgeInstanceDriverConfigsWithOptionsAsync(request, runtime);
        }

        public CreateLoRaNodesTaskResponse CreateLoRaNodesTaskWithOptions(CreateLoRaNodesTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CreateLoRaNodesTaskResponse>(DoRequest("CreateLoRaNodesTask", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<CreateLoRaNodesTaskResponse> CreateLoRaNodesTaskWithOptionsAsync(CreateLoRaNodesTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CreateLoRaNodesTaskResponse>(await DoRequestAsync("CreateLoRaNodesTask", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public CreateLoRaNodesTaskResponse CreateLoRaNodesTask(CreateLoRaNodesTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateLoRaNodesTaskWithOptions(request, runtime);
        }

        public async Task<CreateLoRaNodesTaskResponse> CreateLoRaNodesTaskAsync(CreateLoRaNodesTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateLoRaNodesTaskWithOptionsAsync(request, runtime);
        }

        public GetLoraNodesTaskResponse GetLoraNodesTaskWithOptions(GetLoraNodesTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetLoraNodesTaskResponse>(DoRequest("GetLoraNodesTask", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<GetLoraNodesTaskResponse> GetLoraNodesTaskWithOptionsAsync(GetLoraNodesTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetLoraNodesTaskResponse>(await DoRequestAsync("GetLoraNodesTask", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public GetLoraNodesTaskResponse GetLoraNodesTask(GetLoraNodesTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetLoraNodesTaskWithOptions(request, runtime);
        }

        public async Task<GetLoraNodesTaskResponse> GetLoraNodesTaskAsync(GetLoraNodesTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetLoraNodesTaskWithOptionsAsync(request, runtime);
        }

        public QueryLoRaJoinPermissionsResponse QueryLoRaJoinPermissionsWithOptions(QueryLoRaJoinPermissionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<QueryLoRaJoinPermissionsResponse>(DoRequest("QueryLoRaJoinPermissions", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<QueryLoRaJoinPermissionsResponse> QueryLoRaJoinPermissionsWithOptionsAsync(QueryLoRaJoinPermissionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<QueryLoRaJoinPermissionsResponse>(await DoRequestAsync("QueryLoRaJoinPermissions", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public QueryLoRaJoinPermissionsResponse QueryLoRaJoinPermissions(QueryLoRaJoinPermissionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryLoRaJoinPermissionsWithOptions(request, runtime);
        }

        public async Task<QueryLoRaJoinPermissionsResponse> QueryLoRaJoinPermissionsAsync(QueryLoRaJoinPermissionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryLoRaJoinPermissionsWithOptionsAsync(request, runtime);
        }

        public QueryEdgeInstanceDriverResponse QueryEdgeInstanceDriverWithOptions(QueryEdgeInstanceDriverRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<QueryEdgeInstanceDriverResponse>(DoRequest("QueryEdgeInstanceDriver", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<QueryEdgeInstanceDriverResponse> QueryEdgeInstanceDriverWithOptionsAsync(QueryEdgeInstanceDriverRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<QueryEdgeInstanceDriverResponse>(await DoRequestAsync("QueryEdgeInstanceDriver", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public QueryEdgeInstanceDriverResponse QueryEdgeInstanceDriver(QueryEdgeInstanceDriverRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryEdgeInstanceDriverWithOptions(request, runtime);
        }

        public async Task<QueryEdgeInstanceDriverResponse> QueryEdgeInstanceDriverAsync(QueryEdgeInstanceDriverRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryEdgeInstanceDriverWithOptionsAsync(request, runtime);
        }

        public BatchUpdateDeviceNicknameResponse BatchUpdateDeviceNicknameWithOptions(BatchUpdateDeviceNicknameRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<BatchUpdateDeviceNicknameResponse>(DoRequest("BatchUpdateDeviceNickname", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<BatchUpdateDeviceNicknameResponse> BatchUpdateDeviceNicknameWithOptionsAsync(BatchUpdateDeviceNicknameRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<BatchUpdateDeviceNicknameResponse>(await DoRequestAsync("BatchUpdateDeviceNickname", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public BatchUpdateDeviceNicknameResponse BatchUpdateDeviceNickname(BatchUpdateDeviceNicknameRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return BatchUpdateDeviceNicknameWithOptions(request, runtime);
        }

        public async Task<BatchUpdateDeviceNicknameResponse> BatchUpdateDeviceNicknameAsync(BatchUpdateDeviceNicknameRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await BatchUpdateDeviceNicknameWithOptionsAsync(request, runtime);
        }

        public QueryDeviceFileResponse QueryDeviceFileWithOptions(QueryDeviceFileRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<QueryDeviceFileResponse>(DoRequest("QueryDeviceFile", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<QueryDeviceFileResponse> QueryDeviceFileWithOptionsAsync(QueryDeviceFileRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<QueryDeviceFileResponse>(await DoRequestAsync("QueryDeviceFile", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public QueryDeviceFileResponse QueryDeviceFile(QueryDeviceFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryDeviceFileWithOptions(request, runtime);
        }

        public async Task<QueryDeviceFileResponse> QueryDeviceFileAsync(QueryDeviceFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryDeviceFileWithOptionsAsync(request, runtime);
        }

        public QueryDeviceFileListResponse QueryDeviceFileListWithOptions(QueryDeviceFileListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<QueryDeviceFileListResponse>(DoRequest("QueryDeviceFileList", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<QueryDeviceFileListResponse> QueryDeviceFileListWithOptionsAsync(QueryDeviceFileListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<QueryDeviceFileListResponse>(await DoRequestAsync("QueryDeviceFileList", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public QueryDeviceFileListResponse QueryDeviceFileList(QueryDeviceFileListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryDeviceFileListWithOptions(request, runtime);
        }

        public async Task<QueryDeviceFileListResponse> QueryDeviceFileListAsync(QueryDeviceFileListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryDeviceFileListWithOptionsAsync(request, runtime);
        }

        public DeleteDeviceFileResponse DeleteDeviceFileWithOptions(DeleteDeviceFileRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DeleteDeviceFileResponse>(DoRequest("DeleteDeviceFile", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DeleteDeviceFileResponse> DeleteDeviceFileWithOptionsAsync(DeleteDeviceFileRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DeleteDeviceFileResponse>(await DoRequestAsync("DeleteDeviceFile", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public DeleteDeviceFileResponse DeleteDeviceFile(DeleteDeviceFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteDeviceFileWithOptions(request, runtime);
        }

        public async Task<DeleteDeviceFileResponse> DeleteDeviceFileAsync(DeleteDeviceFileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteDeviceFileWithOptionsAsync(request, runtime);
        }

        public GetNodesAddingTaskResponse GetNodesAddingTaskWithOptions(GetNodesAddingTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetNodesAddingTaskResponse>(DoRequest("GetNodesAddingTask", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<GetNodesAddingTaskResponse> GetNodesAddingTaskWithOptionsAsync(GetNodesAddingTaskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetNodesAddingTaskResponse>(await DoRequestAsync("GetNodesAddingTask", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public GetNodesAddingTaskResponse GetNodesAddingTask(GetNodesAddingTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetNodesAddingTaskWithOptions(request, runtime);
        }

        public async Task<GetNodesAddingTaskResponse> GetNodesAddingTaskAsync(GetNodesAddingTaskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetNodesAddingTaskWithOptionsAsync(request, runtime);
        }

        public SetDeviceDesiredPropertyResponse SetDeviceDesiredPropertyWithOptions(SetDeviceDesiredPropertyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<SetDeviceDesiredPropertyResponse>(DoRequest("SetDeviceDesiredProperty", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<SetDeviceDesiredPropertyResponse> SetDeviceDesiredPropertyWithOptionsAsync(SetDeviceDesiredPropertyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<SetDeviceDesiredPropertyResponse>(await DoRequestAsync("SetDeviceDesiredProperty", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public SetDeviceDesiredPropertyResponse SetDeviceDesiredProperty(SetDeviceDesiredPropertyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetDeviceDesiredPropertyWithOptions(request, runtime);
        }

        public async Task<SetDeviceDesiredPropertyResponse> SetDeviceDesiredPropertyAsync(SetDeviceDesiredPropertyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetDeviceDesiredPropertyWithOptionsAsync(request, runtime);
        }

        public QueryDeviceDesiredPropertyResponse QueryDeviceDesiredPropertyWithOptions(QueryDeviceDesiredPropertyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<QueryDeviceDesiredPropertyResponse>(DoRequest("QueryDeviceDesiredProperty", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<QueryDeviceDesiredPropertyResponse> QueryDeviceDesiredPropertyWithOptionsAsync(QueryDeviceDesiredPropertyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<QueryDeviceDesiredPropertyResponse>(await DoRequestAsync("QueryDeviceDesiredProperty", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public QueryDeviceDesiredPropertyResponse QueryDeviceDesiredProperty(QueryDeviceDesiredPropertyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryDeviceDesiredPropertyWithOptions(request, runtime);
        }

        public async Task<QueryDeviceDesiredPropertyResponse> QueryDeviceDesiredPropertyAsync(QueryDeviceDesiredPropertyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryDeviceDesiredPropertyWithOptionsAsync(request, runtime);
        }

        public QueryEdgeInstanceHistoricDeploymentResponse QueryEdgeInstanceHistoricDeploymentWithOptions(QueryEdgeInstanceHistoricDeploymentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<QueryEdgeInstanceHistoricDeploymentResponse>(DoRequest("QueryEdgeInstanceHistoricDeployment", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<QueryEdgeInstanceHistoricDeploymentResponse> QueryEdgeInstanceHistoricDeploymentWithOptionsAsync(QueryEdgeInstanceHistoricDeploymentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<QueryEdgeInstanceHistoricDeploymentResponse>(await DoRequestAsync("QueryEdgeInstanceHistoricDeployment", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public QueryEdgeInstanceHistoricDeploymentResponse QueryEdgeInstanceHistoricDeployment(QueryEdgeInstanceHistoricDeploymentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryEdgeInstanceHistoricDeploymentWithOptions(request, runtime);
        }

        public async Task<QueryEdgeInstanceHistoricDeploymentResponse> QueryEdgeInstanceHistoricDeploymentAsync(QueryEdgeInstanceHistoricDeploymentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryEdgeInstanceHistoricDeploymentWithOptionsAsync(request, runtime);
        }

        public CreateProductTagsResponse CreateProductTagsWithOptions(CreateProductTagsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CreateProductTagsResponse>(DoRequest("CreateProductTags", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<CreateProductTagsResponse> CreateProductTagsWithOptionsAsync(CreateProductTagsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CreateProductTagsResponse>(await DoRequestAsync("CreateProductTags", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public CreateProductTagsResponse CreateProductTags(CreateProductTagsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateProductTagsWithOptions(request, runtime);
        }

        public async Task<CreateProductTagsResponse> CreateProductTagsAsync(CreateProductTagsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateProductTagsWithOptionsAsync(request, runtime);
        }

        public UpdateProductTagsResponse UpdateProductTagsWithOptions(UpdateProductTagsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<UpdateProductTagsResponse>(DoRequest("UpdateProductTags", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<UpdateProductTagsResponse> UpdateProductTagsWithOptionsAsync(UpdateProductTagsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<UpdateProductTagsResponse>(await DoRequestAsync("UpdateProductTags", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public UpdateProductTagsResponse UpdateProductTags(UpdateProductTagsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateProductTagsWithOptions(request, runtime);
        }

        public async Task<UpdateProductTagsResponse> UpdateProductTagsAsync(UpdateProductTagsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateProductTagsWithOptionsAsync(request, runtime);
        }

        public DeleteProductTagsResponse DeleteProductTagsWithOptions(DeleteProductTagsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DeleteProductTagsResponse>(DoRequest("DeleteProductTags", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DeleteProductTagsResponse> DeleteProductTagsWithOptionsAsync(DeleteProductTagsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DeleteProductTagsResponse>(await DoRequestAsync("DeleteProductTags", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public DeleteProductTagsResponse DeleteProductTags(DeleteProductTagsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteProductTagsWithOptions(request, runtime);
        }

        public async Task<DeleteProductTagsResponse> DeleteProductTagsAsync(DeleteProductTagsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteProductTagsWithOptionsAsync(request, runtime);
        }

        public ListProductTagsResponse ListProductTagsWithOptions(ListProductTagsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ListProductTagsResponse>(DoRequest("ListProductTags", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<ListProductTagsResponse> ListProductTagsWithOptionsAsync(ListProductTagsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ListProductTagsResponse>(await DoRequestAsync("ListProductTags", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public ListProductTagsResponse ListProductTags(ListProductTagsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListProductTagsWithOptions(request, runtime);
        }

        public async Task<ListProductTagsResponse> ListProductTagsAsync(ListProductTagsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListProductTagsWithOptionsAsync(request, runtime);
        }

        public ListProductByTagsResponse ListProductByTagsWithOptions(ListProductByTagsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ListProductByTagsResponse>(DoRequest("ListProductByTags", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<ListProductByTagsResponse> ListProductByTagsWithOptionsAsync(ListProductByTagsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ListProductByTagsResponse>(await DoRequestAsync("ListProductByTags", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public ListProductByTagsResponse ListProductByTags(ListProductByTagsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListProductByTagsWithOptions(request, runtime);
        }

        public async Task<ListProductByTagsResponse> ListProductByTagsAsync(ListProductByTagsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListProductByTagsWithOptionsAsync(request, runtime);
        }

        public QueryDeviceGroupByTagsResponse QueryDeviceGroupByTagsWithOptions(QueryDeviceGroupByTagsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<QueryDeviceGroupByTagsResponse>(DoRequest("QueryDeviceGroupByTags", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<QueryDeviceGroupByTagsResponse> QueryDeviceGroupByTagsWithOptionsAsync(QueryDeviceGroupByTagsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<QueryDeviceGroupByTagsResponse>(await DoRequestAsync("QueryDeviceGroupByTags", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public QueryDeviceGroupByTagsResponse QueryDeviceGroupByTags(QueryDeviceGroupByTagsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryDeviceGroupByTagsWithOptions(request, runtime);
        }

        public async Task<QueryDeviceGroupByTagsResponse> QueryDeviceGroupByTagsAsync(QueryDeviceGroupByTagsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryDeviceGroupByTagsWithOptionsAsync(request, runtime);
        }

        public BatchAddThingTopoResponse BatchAddThingTopoWithOptions(BatchAddThingTopoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<BatchAddThingTopoResponse>(DoRequest("BatchAddThingTopo", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<BatchAddThingTopoResponse> BatchAddThingTopoWithOptionsAsync(BatchAddThingTopoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<BatchAddThingTopoResponse>(await DoRequestAsync("BatchAddThingTopo", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public BatchAddThingTopoResponse BatchAddThingTopo(BatchAddThingTopoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return BatchAddThingTopoWithOptions(request, runtime);
        }

        public async Task<BatchAddThingTopoResponse> BatchAddThingTopoAsync(BatchAddThingTopoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await BatchAddThingTopoWithOptionsAsync(request, runtime);
        }

        public QueryDeviceListByDeviceGroupResponse QueryDeviceListByDeviceGroupWithOptions(QueryDeviceListByDeviceGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<QueryDeviceListByDeviceGroupResponse>(DoRequest("QueryDeviceListByDeviceGroup", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<QueryDeviceListByDeviceGroupResponse> QueryDeviceListByDeviceGroupWithOptionsAsync(QueryDeviceListByDeviceGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<QueryDeviceListByDeviceGroupResponse>(await DoRequestAsync("QueryDeviceListByDeviceGroup", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public QueryDeviceListByDeviceGroupResponse QueryDeviceListByDeviceGroup(QueryDeviceListByDeviceGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryDeviceListByDeviceGroupWithOptions(request, runtime);
        }

        public async Task<QueryDeviceListByDeviceGroupResponse> QueryDeviceListByDeviceGroupAsync(QueryDeviceListByDeviceGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryDeviceListByDeviceGroupWithOptionsAsync(request, runtime);
        }

        public QueryDevicePropertiesDataResponse QueryDevicePropertiesDataWithOptions(QueryDevicePropertiesDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<QueryDevicePropertiesDataResponse>(DoRequest("QueryDevicePropertiesData", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<QueryDevicePropertiesDataResponse> QueryDevicePropertiesDataWithOptionsAsync(QueryDevicePropertiesDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<QueryDevicePropertiesDataResponse>(await DoRequestAsync("QueryDevicePropertiesData", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public QueryDevicePropertiesDataResponse QueryDevicePropertiesData(QueryDevicePropertiesDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryDevicePropertiesDataWithOptions(request, runtime);
        }

        public async Task<QueryDevicePropertiesDataResponse> QueryDevicePropertiesDataAsync(QueryDevicePropertiesDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryDevicePropertiesDataWithOptionsAsync(request, runtime);
        }

        public UnbindRoleFromEdgeInstanceResponse UnbindRoleFromEdgeInstanceWithOptions(UnbindRoleFromEdgeInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<UnbindRoleFromEdgeInstanceResponse>(DoRequest("UnbindRoleFromEdgeInstance", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<UnbindRoleFromEdgeInstanceResponse> UnbindRoleFromEdgeInstanceWithOptionsAsync(UnbindRoleFromEdgeInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<UnbindRoleFromEdgeInstanceResponse>(await DoRequestAsync("UnbindRoleFromEdgeInstance", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public UnbindRoleFromEdgeInstanceResponse UnbindRoleFromEdgeInstance(UnbindRoleFromEdgeInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UnbindRoleFromEdgeInstanceWithOptions(request, runtime);
        }

        public async Task<UnbindRoleFromEdgeInstanceResponse> UnbindRoleFromEdgeInstanceAsync(UnbindRoleFromEdgeInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UnbindRoleFromEdgeInstanceWithOptionsAsync(request, runtime);
        }

        public UpdateEdgeInstanceResponse UpdateEdgeInstanceWithOptions(UpdateEdgeInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<UpdateEdgeInstanceResponse>(DoRequest("UpdateEdgeInstance", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<UpdateEdgeInstanceResponse> UpdateEdgeInstanceWithOptionsAsync(UpdateEdgeInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<UpdateEdgeInstanceResponse>(await DoRequestAsync("UpdateEdgeInstance", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public UpdateEdgeInstanceResponse UpdateEdgeInstance(UpdateEdgeInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateEdgeInstanceWithOptions(request, runtime);
        }

        public async Task<UpdateEdgeInstanceResponse> UpdateEdgeInstanceAsync(UpdateEdgeInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateEdgeInstanceWithOptionsAsync(request, runtime);
        }

        public GetEdgeInstanceResponse GetEdgeInstanceWithOptions(GetEdgeInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetEdgeInstanceResponse>(DoRequest("GetEdgeInstance", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<GetEdgeInstanceResponse> GetEdgeInstanceWithOptionsAsync(GetEdgeInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetEdgeInstanceResponse>(await DoRequestAsync("GetEdgeInstance", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public GetEdgeInstanceResponse GetEdgeInstance(GetEdgeInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetEdgeInstanceWithOptions(request, runtime);
        }

        public async Task<GetEdgeInstanceResponse> GetEdgeInstanceAsync(GetEdgeInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetEdgeInstanceWithOptionsAsync(request, runtime);
        }

        public DeleteEdgeInstanceResponse DeleteEdgeInstanceWithOptions(DeleteEdgeInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DeleteEdgeInstanceResponse>(DoRequest("DeleteEdgeInstance", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DeleteEdgeInstanceResponse> DeleteEdgeInstanceWithOptionsAsync(DeleteEdgeInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DeleteEdgeInstanceResponse>(await DoRequestAsync("DeleteEdgeInstance", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public DeleteEdgeInstanceResponse DeleteEdgeInstance(DeleteEdgeInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteEdgeInstanceWithOptions(request, runtime);
        }

        public async Task<DeleteEdgeInstanceResponse> DeleteEdgeInstanceAsync(DeleteEdgeInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteEdgeInstanceWithOptionsAsync(request, runtime);
        }

        public CreateEdgeInstanceResponse CreateEdgeInstanceWithOptions(CreateEdgeInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CreateEdgeInstanceResponse>(DoRequest("CreateEdgeInstance", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<CreateEdgeInstanceResponse> CreateEdgeInstanceWithOptionsAsync(CreateEdgeInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CreateEdgeInstanceResponse>(await DoRequestAsync("CreateEdgeInstance", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public CreateEdgeInstanceResponse CreateEdgeInstance(CreateEdgeInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateEdgeInstanceWithOptions(request, runtime);
        }

        public async Task<CreateEdgeInstanceResponse> CreateEdgeInstanceAsync(CreateEdgeInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateEdgeInstanceWithOptionsAsync(request, runtime);
        }

        public QueryEdgeInstanceGatewayResponse QueryEdgeInstanceGatewayWithOptions(QueryEdgeInstanceGatewayRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<QueryEdgeInstanceGatewayResponse>(DoRequest("QueryEdgeInstanceGateway", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<QueryEdgeInstanceGatewayResponse> QueryEdgeInstanceGatewayWithOptionsAsync(QueryEdgeInstanceGatewayRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<QueryEdgeInstanceGatewayResponse>(await DoRequestAsync("QueryEdgeInstanceGateway", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public QueryEdgeInstanceGatewayResponse QueryEdgeInstanceGateway(QueryEdgeInstanceGatewayRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryEdgeInstanceGatewayWithOptions(request, runtime);
        }

        public async Task<QueryEdgeInstanceGatewayResponse> QueryEdgeInstanceGatewayAsync(QueryEdgeInstanceGatewayRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryEdgeInstanceGatewayWithOptionsAsync(request, runtime);
        }

        public QueryEdgeInstanceDeviceResponse QueryEdgeInstanceDeviceWithOptions(QueryEdgeInstanceDeviceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<QueryEdgeInstanceDeviceResponse>(DoRequest("QueryEdgeInstanceDevice", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<QueryEdgeInstanceDeviceResponse> QueryEdgeInstanceDeviceWithOptionsAsync(QueryEdgeInstanceDeviceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<QueryEdgeInstanceDeviceResponse>(await DoRequestAsync("QueryEdgeInstanceDevice", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public QueryEdgeInstanceDeviceResponse QueryEdgeInstanceDevice(QueryEdgeInstanceDeviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryEdgeInstanceDeviceWithOptions(request, runtime);
        }

        public async Task<QueryEdgeInstanceDeviceResponse> QueryEdgeInstanceDeviceAsync(QueryEdgeInstanceDeviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryEdgeInstanceDeviceWithOptionsAsync(request, runtime);
        }

        public BindGatewayToEdgeInstanceResponse BindGatewayToEdgeInstanceWithOptions(BindGatewayToEdgeInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<BindGatewayToEdgeInstanceResponse>(DoRequest("BindGatewayToEdgeInstance", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<BindGatewayToEdgeInstanceResponse> BindGatewayToEdgeInstanceWithOptionsAsync(BindGatewayToEdgeInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<BindGatewayToEdgeInstanceResponse>(await DoRequestAsync("BindGatewayToEdgeInstance", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public BindGatewayToEdgeInstanceResponse BindGatewayToEdgeInstance(BindGatewayToEdgeInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return BindGatewayToEdgeInstanceWithOptions(request, runtime);
        }

        public async Task<BindGatewayToEdgeInstanceResponse> BindGatewayToEdgeInstanceAsync(BindGatewayToEdgeInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await BindGatewayToEdgeInstanceWithOptionsAsync(request, runtime);
        }

        public QueryEdgeInstanceResponse QueryEdgeInstanceWithOptions(QueryEdgeInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<QueryEdgeInstanceResponse>(DoRequest("QueryEdgeInstance", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<QueryEdgeInstanceResponse> QueryEdgeInstanceWithOptionsAsync(QueryEdgeInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<QueryEdgeInstanceResponse>(await DoRequestAsync("QueryEdgeInstance", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public QueryEdgeInstanceResponse QueryEdgeInstance(QueryEdgeInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryEdgeInstanceWithOptions(request, runtime);
        }

        public async Task<QueryEdgeInstanceResponse> QueryEdgeInstanceAsync(QueryEdgeInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryEdgeInstanceWithOptionsAsync(request, runtime);
        }

        public CreateEdgeInstanceDeploymentResponse CreateEdgeInstanceDeploymentWithOptions(CreateEdgeInstanceDeploymentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CreateEdgeInstanceDeploymentResponse>(DoRequest("CreateEdgeInstanceDeployment", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<CreateEdgeInstanceDeploymentResponse> CreateEdgeInstanceDeploymentWithOptionsAsync(CreateEdgeInstanceDeploymentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CreateEdgeInstanceDeploymentResponse>(await DoRequestAsync("CreateEdgeInstanceDeployment", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public CreateEdgeInstanceDeploymentResponse CreateEdgeInstanceDeployment(CreateEdgeInstanceDeploymentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateEdgeInstanceDeploymentWithOptions(request, runtime);
        }

        public async Task<CreateEdgeInstanceDeploymentResponse> CreateEdgeInstanceDeploymentAsync(CreateEdgeInstanceDeploymentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateEdgeInstanceDeploymentWithOptionsAsync(request, runtime);
        }

        public BindRoleToEdgeInstanceResponse BindRoleToEdgeInstanceWithOptions(BindRoleToEdgeInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<BindRoleToEdgeInstanceResponse>(DoRequest("BindRoleToEdgeInstance", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<BindRoleToEdgeInstanceResponse> BindRoleToEdgeInstanceWithOptionsAsync(BindRoleToEdgeInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<BindRoleToEdgeInstanceResponse>(await DoRequestAsync("BindRoleToEdgeInstance", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public BindRoleToEdgeInstanceResponse BindRoleToEdgeInstance(BindRoleToEdgeInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return BindRoleToEdgeInstanceWithOptions(request, runtime);
        }

        public async Task<BindRoleToEdgeInstanceResponse> BindRoleToEdgeInstanceAsync(BindRoleToEdgeInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await BindRoleToEdgeInstanceWithOptionsAsync(request, runtime);
        }

        public QuerySuperDeviceGroupResponse QuerySuperDeviceGroupWithOptions(QuerySuperDeviceGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<QuerySuperDeviceGroupResponse>(DoRequest("QuerySuperDeviceGroup", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<QuerySuperDeviceGroupResponse> QuerySuperDeviceGroupWithOptionsAsync(QuerySuperDeviceGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<QuerySuperDeviceGroupResponse>(await DoRequestAsync("QuerySuperDeviceGroup", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public QuerySuperDeviceGroupResponse QuerySuperDeviceGroup(QuerySuperDeviceGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QuerySuperDeviceGroupWithOptions(request, runtime);
        }

        public async Task<QuerySuperDeviceGroupResponse> QuerySuperDeviceGroupAsync(QuerySuperDeviceGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QuerySuperDeviceGroupWithOptionsAsync(request, runtime);
        }

        public QueryDeviceByTagsResponse QueryDeviceByTagsWithOptions(QueryDeviceByTagsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<QueryDeviceByTagsResponse>(DoRequest("QueryDeviceByTags", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<QueryDeviceByTagsResponse> QueryDeviceByTagsWithOptionsAsync(QueryDeviceByTagsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<QueryDeviceByTagsResponse>(await DoRequestAsync("QueryDeviceByTags", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public QueryDeviceByTagsResponse QueryDeviceByTags(QueryDeviceByTagsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryDeviceByTagsWithOptions(request, runtime);
        }

        public async Task<QueryDeviceByTagsResponse> QueryDeviceByTagsAsync(QueryDeviceByTagsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryDeviceByTagsWithOptionsAsync(request, runtime);
        }

        public SetDevicesPropertyResponse SetDevicesPropertyWithOptions(SetDevicesPropertyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<SetDevicesPropertyResponse>(DoRequest("SetDevicesProperty", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<SetDevicesPropertyResponse> SetDevicesPropertyWithOptionsAsync(SetDevicesPropertyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<SetDevicesPropertyResponse>(await DoRequestAsync("SetDevicesProperty", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public SetDevicesPropertyResponse SetDevicesProperty(SetDevicesPropertyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetDevicesPropertyWithOptions(request, runtime);
        }

        public async Task<SetDevicesPropertyResponse> SetDevicesPropertyAsync(SetDevicesPropertyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetDevicesPropertyWithOptionsAsync(request, runtime);
        }

        public InvokeThingsServiceResponse InvokeThingsServiceWithOptions(InvokeThingsServiceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<InvokeThingsServiceResponse>(DoRequest("InvokeThingsService", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<InvokeThingsServiceResponse> InvokeThingsServiceWithOptionsAsync(InvokeThingsServiceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<InvokeThingsServiceResponse>(await DoRequestAsync("InvokeThingsService", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public InvokeThingsServiceResponse InvokeThingsService(InvokeThingsServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return InvokeThingsServiceWithOptions(request, runtime);
        }

        public async Task<InvokeThingsServiceResponse> InvokeThingsServiceAsync(InvokeThingsServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await InvokeThingsServiceWithOptionsAsync(request, runtime);
        }

        public SetDeviceGroupTagsResponse SetDeviceGroupTagsWithOptions(SetDeviceGroupTagsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<SetDeviceGroupTagsResponse>(DoRequest("SetDeviceGroupTags", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<SetDeviceGroupTagsResponse> SetDeviceGroupTagsWithOptionsAsync(SetDeviceGroupTagsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<SetDeviceGroupTagsResponse>(await DoRequestAsync("SetDeviceGroupTags", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public SetDeviceGroupTagsResponse SetDeviceGroupTags(SetDeviceGroupTagsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetDeviceGroupTagsWithOptions(request, runtime);
        }

        public async Task<SetDeviceGroupTagsResponse> SetDeviceGroupTagsAsync(SetDeviceGroupTagsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetDeviceGroupTagsWithOptionsAsync(request, runtime);
        }

        public QueryAppDeviceListResponse QueryAppDeviceListWithOptions(QueryAppDeviceListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<QueryAppDeviceListResponse>(DoRequest("QueryAppDeviceList", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<QueryAppDeviceListResponse> QueryAppDeviceListWithOptionsAsync(QueryAppDeviceListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<QueryAppDeviceListResponse>(await DoRequestAsync("QueryAppDeviceList", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public QueryAppDeviceListResponse QueryAppDeviceList(QueryAppDeviceListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryAppDeviceListWithOptions(request, runtime);
        }

        public async Task<QueryAppDeviceListResponse> QueryAppDeviceListAsync(QueryAppDeviceListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryAppDeviceListWithOptionsAsync(request, runtime);
        }

        public UpdateDeviceGroupResponse UpdateDeviceGroupWithOptions(UpdateDeviceGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<UpdateDeviceGroupResponse>(DoRequest("UpdateDeviceGroup", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<UpdateDeviceGroupResponse> UpdateDeviceGroupWithOptionsAsync(UpdateDeviceGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<UpdateDeviceGroupResponse>(await DoRequestAsync("UpdateDeviceGroup", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public UpdateDeviceGroupResponse UpdateDeviceGroup(UpdateDeviceGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateDeviceGroupWithOptions(request, runtime);
        }

        public async Task<UpdateDeviceGroupResponse> UpdateDeviceGroupAsync(UpdateDeviceGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateDeviceGroupWithOptionsAsync(request, runtime);
        }

        public QueryDeviceGroupTagListResponse QueryDeviceGroupTagListWithOptions(QueryDeviceGroupTagListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<QueryDeviceGroupTagListResponse>(DoRequest("QueryDeviceGroupTagList", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<QueryDeviceGroupTagListResponse> QueryDeviceGroupTagListWithOptionsAsync(QueryDeviceGroupTagListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<QueryDeviceGroupTagListResponse>(await DoRequestAsync("QueryDeviceGroupTagList", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public QueryDeviceGroupTagListResponse QueryDeviceGroupTagList(QueryDeviceGroupTagListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryDeviceGroupTagListWithOptions(request, runtime);
        }

        public async Task<QueryDeviceGroupTagListResponse> QueryDeviceGroupTagListAsync(QueryDeviceGroupTagListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryDeviceGroupTagListWithOptionsAsync(request, runtime);
        }

        public QueryDeviceGroupListResponse QueryDeviceGroupListWithOptions(QueryDeviceGroupListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<QueryDeviceGroupListResponse>(DoRequest("QueryDeviceGroupList", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<QueryDeviceGroupListResponse> QueryDeviceGroupListWithOptionsAsync(QueryDeviceGroupListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<QueryDeviceGroupListResponse>(await DoRequestAsync("QueryDeviceGroupList", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public QueryDeviceGroupListResponse QueryDeviceGroupList(QueryDeviceGroupListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryDeviceGroupListWithOptions(request, runtime);
        }

        public async Task<QueryDeviceGroupListResponse> QueryDeviceGroupListAsync(QueryDeviceGroupListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryDeviceGroupListWithOptionsAsync(request, runtime);
        }

        public QueryDeviceGroupInfoResponse QueryDeviceGroupInfoWithOptions(QueryDeviceGroupInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<QueryDeviceGroupInfoResponse>(DoRequest("QueryDeviceGroupInfo", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<QueryDeviceGroupInfoResponse> QueryDeviceGroupInfoWithOptionsAsync(QueryDeviceGroupInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<QueryDeviceGroupInfoResponse>(await DoRequestAsync("QueryDeviceGroupInfo", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public QueryDeviceGroupInfoResponse QueryDeviceGroupInfo(QueryDeviceGroupInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryDeviceGroupInfoWithOptions(request, runtime);
        }

        public async Task<QueryDeviceGroupInfoResponse> QueryDeviceGroupInfoAsync(QueryDeviceGroupInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryDeviceGroupInfoWithOptionsAsync(request, runtime);
        }

        public QueryDeviceGroupByDeviceResponse QueryDeviceGroupByDeviceWithOptions(QueryDeviceGroupByDeviceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<QueryDeviceGroupByDeviceResponse>(DoRequest("QueryDeviceGroupByDevice", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<QueryDeviceGroupByDeviceResponse> QueryDeviceGroupByDeviceWithOptionsAsync(QueryDeviceGroupByDeviceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<QueryDeviceGroupByDeviceResponse>(await DoRequestAsync("QueryDeviceGroupByDevice", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public QueryDeviceGroupByDeviceResponse QueryDeviceGroupByDevice(QueryDeviceGroupByDeviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryDeviceGroupByDeviceWithOptions(request, runtime);
        }

        public async Task<QueryDeviceGroupByDeviceResponse> QueryDeviceGroupByDeviceAsync(QueryDeviceGroupByDeviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryDeviceGroupByDeviceWithOptionsAsync(request, runtime);
        }

        public DeleteDeviceGroupResponse DeleteDeviceGroupWithOptions(DeleteDeviceGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DeleteDeviceGroupResponse>(DoRequest("DeleteDeviceGroup", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DeleteDeviceGroupResponse> DeleteDeviceGroupWithOptionsAsync(DeleteDeviceGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DeleteDeviceGroupResponse>(await DoRequestAsync("DeleteDeviceGroup", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public DeleteDeviceGroupResponse DeleteDeviceGroup(DeleteDeviceGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteDeviceGroupWithOptions(request, runtime);
        }

        public async Task<DeleteDeviceGroupResponse> DeleteDeviceGroupAsync(DeleteDeviceGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteDeviceGroupWithOptionsAsync(request, runtime);
        }

        public CreateDeviceGroupResponse CreateDeviceGroupWithOptions(CreateDeviceGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CreateDeviceGroupResponse>(DoRequest("CreateDeviceGroup", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<CreateDeviceGroupResponse> CreateDeviceGroupWithOptionsAsync(CreateDeviceGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CreateDeviceGroupResponse>(await DoRequestAsync("CreateDeviceGroup", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public CreateDeviceGroupResponse CreateDeviceGroup(CreateDeviceGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateDeviceGroupWithOptions(request, runtime);
        }

        public async Task<CreateDeviceGroupResponse> CreateDeviceGroupAsync(CreateDeviceGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateDeviceGroupWithOptionsAsync(request, runtime);
        }

        public BatchDeleteDeviceGroupRelationsResponse BatchDeleteDeviceGroupRelationsWithOptions(BatchDeleteDeviceGroupRelationsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<BatchDeleteDeviceGroupRelationsResponse>(DoRequest("BatchDeleteDeviceGroupRelations", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<BatchDeleteDeviceGroupRelationsResponse> BatchDeleteDeviceGroupRelationsWithOptionsAsync(BatchDeleteDeviceGroupRelationsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<BatchDeleteDeviceGroupRelationsResponse>(await DoRequestAsync("BatchDeleteDeviceGroupRelations", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public BatchDeleteDeviceGroupRelationsResponse BatchDeleteDeviceGroupRelations(BatchDeleteDeviceGroupRelationsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return BatchDeleteDeviceGroupRelationsWithOptions(request, runtime);
        }

        public async Task<BatchDeleteDeviceGroupRelationsResponse> BatchDeleteDeviceGroupRelationsAsync(BatchDeleteDeviceGroupRelationsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await BatchDeleteDeviceGroupRelationsWithOptionsAsync(request, runtime);
        }

        public BatchAddDeviceGroupRelationsResponse BatchAddDeviceGroupRelationsWithOptions(BatchAddDeviceGroupRelationsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<BatchAddDeviceGroupRelationsResponse>(DoRequest("BatchAddDeviceGroupRelations", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<BatchAddDeviceGroupRelationsResponse> BatchAddDeviceGroupRelationsWithOptionsAsync(BatchAddDeviceGroupRelationsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<BatchAddDeviceGroupRelationsResponse>(await DoRequestAsync("BatchAddDeviceGroupRelations", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public BatchAddDeviceGroupRelationsResponse BatchAddDeviceGroupRelations(BatchAddDeviceGroupRelationsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return BatchAddDeviceGroupRelationsWithOptions(request, runtime);
        }

        public async Task<BatchAddDeviceGroupRelationsResponse> BatchAddDeviceGroupRelationsAsync(BatchAddDeviceGroupRelationsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await BatchAddDeviceGroupRelationsWithOptionsAsync(request, runtime);
        }

        public RRpcResponse RRpcWithOptions(RRpcRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<RRpcResponse>(DoRequest("RRpc", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<RRpcResponse> RRpcWithOptionsAsync(RRpcRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<RRpcResponse>(await DoRequestAsync("RRpc", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public RRpcResponse RRpc(RRpcRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RRpcWithOptions(request, runtime);
        }

        public async Task<RRpcResponse> RRpcAsync(RRpcRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RRpcWithOptionsAsync(request, runtime);
        }

        public QueryPageByApplyIdResponse QueryPageByApplyIdWithOptions(QueryPageByApplyIdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<QueryPageByApplyIdResponse>(DoRequest("QueryPageByApplyId", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<QueryPageByApplyIdResponse> QueryPageByApplyIdWithOptionsAsync(QueryPageByApplyIdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<QueryPageByApplyIdResponse>(await DoRequestAsync("QueryPageByApplyId", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public QueryPageByApplyIdResponse QueryPageByApplyId(QueryPageByApplyIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryPageByApplyIdWithOptions(request, runtime);
        }

        public async Task<QueryPageByApplyIdResponse> QueryPageByApplyIdAsync(QueryPageByApplyIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryPageByApplyIdWithOptionsAsync(request, runtime);
        }

        public QueryDeviceResponse QueryDeviceWithOptions(QueryDeviceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<QueryDeviceResponse>(DoRequest("QueryDevice", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<QueryDeviceResponse> QueryDeviceWithOptionsAsync(QueryDeviceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<QueryDeviceResponse>(await DoRequestAsync("QueryDevice", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public QueryDeviceResponse QueryDevice(QueryDeviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryDeviceWithOptions(request, runtime);
        }

        public async Task<QueryDeviceResponse> QueryDeviceAsync(QueryDeviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryDeviceWithOptionsAsync(request, runtime);
        }

        public SaveDevicePropResponse SaveDevicePropWithOptions(SaveDevicePropRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<SaveDevicePropResponse>(DoRequest("SaveDeviceProp", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<SaveDevicePropResponse> SaveDevicePropWithOptionsAsync(SaveDevicePropRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<SaveDevicePropResponse>(await DoRequestAsync("SaveDeviceProp", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public SaveDevicePropResponse SaveDeviceProp(SaveDevicePropRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SaveDevicePropWithOptions(request, runtime);
        }

        public async Task<SaveDevicePropResponse> SaveDevicePropAsync(SaveDevicePropRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SaveDevicePropWithOptionsAsync(request, runtime);
        }

        public QueryTopicRouteTableResponse QueryTopicRouteTableWithOptions(QueryTopicRouteTableRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<QueryTopicRouteTableResponse>(DoRequest("QueryTopicRouteTable", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<QueryTopicRouteTableResponse> QueryTopicRouteTableWithOptionsAsync(QueryTopicRouteTableRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<QueryTopicRouteTableResponse>(await DoRequestAsync("QueryTopicRouteTable", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public QueryTopicRouteTableResponse QueryTopicRouteTable(QueryTopicRouteTableRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryTopicRouteTableWithOptions(request, runtime);
        }

        public async Task<QueryTopicRouteTableResponse> QueryTopicRouteTableAsync(QueryTopicRouteTableRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryTopicRouteTableWithOptionsAsync(request, runtime);
        }

        public QueryTopicReverseRouteTableResponse QueryTopicReverseRouteTableWithOptions(QueryTopicReverseRouteTableRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<QueryTopicReverseRouteTableResponse>(DoRequest("QueryTopicReverseRouteTable", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<QueryTopicReverseRouteTableResponse> QueryTopicReverseRouteTableWithOptionsAsync(QueryTopicReverseRouteTableRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<QueryTopicReverseRouteTableResponse>(await DoRequestAsync("QueryTopicReverseRouteTable", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public QueryTopicReverseRouteTableResponse QueryTopicReverseRouteTable(QueryTopicReverseRouteTableRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryTopicReverseRouteTableWithOptions(request, runtime);
        }

        public async Task<QueryTopicReverseRouteTableResponse> QueryTopicReverseRouteTableAsync(QueryTopicReverseRouteTableRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryTopicReverseRouteTableWithOptionsAsync(request, runtime);
        }

        public PubBroadcastResponse PubBroadcastWithOptions(PubBroadcastRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<PubBroadcastResponse>(DoRequest("PubBroadcast", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<PubBroadcastResponse> PubBroadcastWithOptionsAsync(PubBroadcastRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<PubBroadcastResponse>(await DoRequestAsync("PubBroadcast", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public PubBroadcastResponse PubBroadcast(PubBroadcastRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return PubBroadcastWithOptions(request, runtime);
        }

        public async Task<PubBroadcastResponse> PubBroadcastAsync(PubBroadcastRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await PubBroadcastWithOptionsAsync(request, runtime);
        }

        public DeleteTopicRouteTableResponse DeleteTopicRouteTableWithOptions(DeleteTopicRouteTableRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DeleteTopicRouteTableResponse>(DoRequest("DeleteTopicRouteTable", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DeleteTopicRouteTableResponse> DeleteTopicRouteTableWithOptionsAsync(DeleteTopicRouteTableRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DeleteTopicRouteTableResponse>(await DoRequestAsync("DeleteTopicRouteTable", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public DeleteTopicRouteTableResponse DeleteTopicRouteTable(DeleteTopicRouteTableRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteTopicRouteTableWithOptions(request, runtime);
        }

        public async Task<DeleteTopicRouteTableResponse> DeleteTopicRouteTableAsync(DeleteTopicRouteTableRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteTopicRouteTableWithOptionsAsync(request, runtime);
        }

        public DeleteDevicePropResponse DeleteDevicePropWithOptions(DeleteDevicePropRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DeleteDevicePropResponse>(DoRequest("DeleteDeviceProp", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DeleteDevicePropResponse> DeleteDevicePropWithOptionsAsync(DeleteDevicePropRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DeleteDevicePropResponse>(await DoRequestAsync("DeleteDeviceProp", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public DeleteDevicePropResponse DeleteDeviceProp(DeleteDevicePropRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteDevicePropWithOptions(request, runtime);
        }

        public async Task<DeleteDevicePropResponse> DeleteDevicePropAsync(DeleteDevicePropRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteDevicePropWithOptionsAsync(request, runtime);
        }

        public CreateTopicRouteTableResponse CreateTopicRouteTableWithOptions(CreateTopicRouteTableRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CreateTopicRouteTableResponse>(DoRequest("CreateTopicRouteTable", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<CreateTopicRouteTableResponse> CreateTopicRouteTableWithOptionsAsync(CreateTopicRouteTableRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CreateTopicRouteTableResponse>(await DoRequestAsync("CreateTopicRouteTable", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public CreateTopicRouteTableResponse CreateTopicRouteTable(CreateTopicRouteTableRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateTopicRouteTableWithOptions(request, runtime);
        }

        public async Task<CreateTopicRouteTableResponse> CreateTopicRouteTableAsync(CreateTopicRouteTableRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateTopicRouteTableWithOptionsAsync(request, runtime);
        }

        public BatchGetDeviceStateResponse BatchGetDeviceStateWithOptions(BatchGetDeviceStateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<BatchGetDeviceStateResponse>(DoRequest("BatchGetDeviceState", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<BatchGetDeviceStateResponse> BatchGetDeviceStateWithOptionsAsync(BatchGetDeviceStateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<BatchGetDeviceStateResponse>(await DoRequestAsync("BatchGetDeviceState", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public BatchGetDeviceStateResponse BatchGetDeviceState(BatchGetDeviceStateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return BatchGetDeviceStateWithOptions(request, runtime);
        }

        public async Task<BatchGetDeviceStateResponse> BatchGetDeviceStateAsync(BatchGetDeviceStateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await BatchGetDeviceStateWithOptionsAsync(request, runtime);
        }

        public UpdateRuleActionResponse UpdateRuleActionWithOptions(UpdateRuleActionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<UpdateRuleActionResponse>(DoRequest("UpdateRuleAction", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<UpdateRuleActionResponse> UpdateRuleActionWithOptionsAsync(UpdateRuleActionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<UpdateRuleActionResponse>(await DoRequestAsync("UpdateRuleAction", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public UpdateRuleActionResponse UpdateRuleAction(UpdateRuleActionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateRuleActionWithOptions(request, runtime);
        }

        public async Task<UpdateRuleActionResponse> UpdateRuleActionAsync(UpdateRuleActionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateRuleActionWithOptionsAsync(request, runtime);
        }

        public UpdateRuleResponse UpdateRuleWithOptions(UpdateRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<UpdateRuleResponse>(DoRequest("UpdateRule", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<UpdateRuleResponse> UpdateRuleWithOptionsAsync(UpdateRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<UpdateRuleResponse>(await DoRequestAsync("UpdateRule", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public UpdateRuleResponse UpdateRule(UpdateRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateRuleWithOptions(request, runtime);
        }

        public async Task<UpdateRuleResponse> UpdateRuleAsync(UpdateRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateRuleWithOptionsAsync(request, runtime);
        }

        public UpdateProductTopicResponse UpdateProductTopicWithOptions(UpdateProductTopicRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<UpdateProductTopicResponse>(DoRequest("UpdateProductTopic", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<UpdateProductTopicResponse> UpdateProductTopicWithOptionsAsync(UpdateProductTopicRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<UpdateProductTopicResponse>(await DoRequestAsync("UpdateProductTopic", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public UpdateProductTopicResponse UpdateProductTopic(UpdateProductTopicRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateProductTopicWithOptions(request, runtime);
        }

        public async Task<UpdateProductTopicResponse> UpdateProductTopicAsync(UpdateProductTopicRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateProductTopicWithOptionsAsync(request, runtime);
        }

        public UpdateDeviceShadowResponse UpdateDeviceShadowWithOptions(UpdateDeviceShadowRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<UpdateDeviceShadowResponse>(DoRequest("UpdateDeviceShadow", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<UpdateDeviceShadowResponse> UpdateDeviceShadowWithOptionsAsync(UpdateDeviceShadowRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<UpdateDeviceShadowResponse>(await DoRequestAsync("UpdateDeviceShadow", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public UpdateDeviceShadowResponse UpdateDeviceShadow(UpdateDeviceShadowRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateDeviceShadowWithOptions(request, runtime);
        }

        public async Task<UpdateDeviceShadowResponse> UpdateDeviceShadowAsync(UpdateDeviceShadowRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateDeviceShadowWithOptionsAsync(request, runtime);
        }

        public StopRuleResponse StopRuleWithOptions(StopRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<StopRuleResponse>(DoRequest("StopRule", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<StopRuleResponse> StopRuleWithOptionsAsync(StopRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<StopRuleResponse>(await DoRequestAsync("StopRule", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public StopRuleResponse StopRule(StopRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StopRuleWithOptions(request, runtime);
        }

        public async Task<StopRuleResponse> StopRuleAsync(StopRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StopRuleWithOptionsAsync(request, runtime);
        }

        public StartRuleResponse StartRuleWithOptions(StartRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<StartRuleResponse>(DoRequest("StartRule", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<StartRuleResponse> StartRuleWithOptionsAsync(StartRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<StartRuleResponse>(await DoRequestAsync("StartRule", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public StartRuleResponse StartRule(StartRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StartRuleWithOptions(request, runtime);
        }

        public async Task<StartRuleResponse> StartRuleAsync(StartRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StartRuleWithOptionsAsync(request, runtime);
        }

        public QueryProductTopicResponse QueryProductTopicWithOptions(QueryProductTopicRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<QueryProductTopicResponse>(DoRequest("QueryProductTopic", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<QueryProductTopicResponse> QueryProductTopicWithOptionsAsync(QueryProductTopicRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<QueryProductTopicResponse>(await DoRequestAsync("QueryProductTopic", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public QueryProductTopicResponse QueryProductTopic(QueryProductTopicRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryProductTopicWithOptions(request, runtime);
        }

        public async Task<QueryProductTopicResponse> QueryProductTopicAsync(QueryProductTopicRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryProductTopicWithOptionsAsync(request, runtime);
        }

        public QueryDevicePropResponse QueryDevicePropWithOptions(QueryDevicePropRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<QueryDevicePropResponse>(DoRequest("QueryDeviceProp", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<QueryDevicePropResponse> QueryDevicePropWithOptionsAsync(QueryDevicePropRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<QueryDevicePropResponse>(await DoRequestAsync("QueryDeviceProp", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public QueryDevicePropResponse QueryDeviceProp(QueryDevicePropRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryDevicePropWithOptions(request, runtime);
        }

        public async Task<QueryDevicePropResponse> QueryDevicePropAsync(QueryDevicePropRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryDevicePropWithOptionsAsync(request, runtime);
        }

        public PubResponse PubWithOptions(PubRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<PubResponse>(DoRequest("Pub", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<PubResponse> PubWithOptionsAsync(PubRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<PubResponse>(await DoRequestAsync("Pub", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public PubResponse Pub(PubRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return PubWithOptions(request, runtime);
        }

        public async Task<PubResponse> PubAsync(PubRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await PubWithOptionsAsync(request, runtime);
        }

        public ListRuleActionsResponse ListRuleActionsWithOptions(ListRuleActionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ListRuleActionsResponse>(DoRequest("ListRuleActions", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<ListRuleActionsResponse> ListRuleActionsWithOptionsAsync(ListRuleActionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ListRuleActionsResponse>(await DoRequestAsync("ListRuleActions", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public ListRuleActionsResponse ListRuleActions(ListRuleActionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListRuleActionsWithOptions(request, runtime);
        }

        public async Task<ListRuleActionsResponse> ListRuleActionsAsync(ListRuleActionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListRuleActionsWithOptionsAsync(request, runtime);
        }

        public ListRuleResponse ListRuleWithOptions(ListRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ListRuleResponse>(DoRequest("ListRule", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<ListRuleResponse> ListRuleWithOptionsAsync(ListRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ListRuleResponse>(await DoRequestAsync("ListRule", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public ListRuleResponse ListRule(ListRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListRuleWithOptions(request, runtime);
        }

        public async Task<ListRuleResponse> ListRuleAsync(ListRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListRuleWithOptionsAsync(request, runtime);
        }

        public GetRuleActionResponse GetRuleActionWithOptions(GetRuleActionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetRuleActionResponse>(DoRequest("GetRuleAction", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<GetRuleActionResponse> GetRuleActionWithOptionsAsync(GetRuleActionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetRuleActionResponse>(await DoRequestAsync("GetRuleAction", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public GetRuleActionResponse GetRuleAction(GetRuleActionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetRuleActionWithOptions(request, runtime);
        }

        public async Task<GetRuleActionResponse> GetRuleActionAsync(GetRuleActionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetRuleActionWithOptionsAsync(request, runtime);
        }

        public GetRuleResponse GetRuleWithOptions(GetRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetRuleResponse>(DoRequest("GetRule", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<GetRuleResponse> GetRuleWithOptionsAsync(GetRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetRuleResponse>(await DoRequestAsync("GetRule", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public GetRuleResponse GetRule(GetRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetRuleWithOptions(request, runtime);
        }

        public async Task<GetRuleResponse> GetRuleAsync(GetRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetRuleWithOptionsAsync(request, runtime);
        }

        public GetDeviceShadowResponse GetDeviceShadowWithOptions(GetDeviceShadowRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetDeviceShadowResponse>(DoRequest("GetDeviceShadow", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<GetDeviceShadowResponse> GetDeviceShadowWithOptionsAsync(GetDeviceShadowRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetDeviceShadowResponse>(await DoRequestAsync("GetDeviceShadow", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public GetDeviceShadowResponse GetDeviceShadow(GetDeviceShadowRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetDeviceShadowWithOptions(request, runtime);
        }

        public async Task<GetDeviceShadowResponse> GetDeviceShadowAsync(GetDeviceShadowRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetDeviceShadowWithOptionsAsync(request, runtime);
        }

        public DeleteRuleActionResponse DeleteRuleActionWithOptions(DeleteRuleActionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DeleteRuleActionResponse>(DoRequest("DeleteRuleAction", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DeleteRuleActionResponse> DeleteRuleActionWithOptionsAsync(DeleteRuleActionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DeleteRuleActionResponse>(await DoRequestAsync("DeleteRuleAction", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public DeleteRuleActionResponse DeleteRuleAction(DeleteRuleActionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteRuleActionWithOptions(request, runtime);
        }

        public async Task<DeleteRuleActionResponse> DeleteRuleActionAsync(DeleteRuleActionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteRuleActionWithOptionsAsync(request, runtime);
        }

        public DeleteRuleResponse DeleteRuleWithOptions(DeleteRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DeleteRuleResponse>(DoRequest("DeleteRule", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DeleteRuleResponse> DeleteRuleWithOptionsAsync(DeleteRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DeleteRuleResponse>(await DoRequestAsync("DeleteRule", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public DeleteRuleResponse DeleteRule(DeleteRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteRuleWithOptions(request, runtime);
        }

        public async Task<DeleteRuleResponse> DeleteRuleAsync(DeleteRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteRuleWithOptionsAsync(request, runtime);
        }

        public DeleteProductTopicResponse DeleteProductTopicWithOptions(DeleteProductTopicRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DeleteProductTopicResponse>(DoRequest("DeleteProductTopic", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DeleteProductTopicResponse> DeleteProductTopicWithOptionsAsync(DeleteProductTopicRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DeleteProductTopicResponse>(await DoRequestAsync("DeleteProductTopic", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public DeleteProductTopicResponse DeleteProductTopic(DeleteProductTopicRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteProductTopicWithOptions(request, runtime);
        }

        public async Task<DeleteProductTopicResponse> DeleteProductTopicAsync(DeleteProductTopicRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteProductTopicWithOptionsAsync(request, runtime);
        }

        public CreateRuleActionResponse CreateRuleActionWithOptions(CreateRuleActionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CreateRuleActionResponse>(DoRequest("CreateRuleAction", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<CreateRuleActionResponse> CreateRuleActionWithOptionsAsync(CreateRuleActionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CreateRuleActionResponse>(await DoRequestAsync("CreateRuleAction", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public CreateRuleActionResponse CreateRuleAction(CreateRuleActionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateRuleActionWithOptions(request, runtime);
        }

        public async Task<CreateRuleActionResponse> CreateRuleActionAsync(CreateRuleActionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateRuleActionWithOptionsAsync(request, runtime);
        }

        public CreateRuleResponse CreateRuleWithOptions(CreateRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CreateRuleResponse>(DoRequest("CreateRule", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<CreateRuleResponse> CreateRuleWithOptionsAsync(CreateRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CreateRuleResponse>(await DoRequestAsync("CreateRule", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public CreateRuleResponse CreateRule(CreateRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateRuleWithOptions(request, runtime);
        }

        public async Task<CreateRuleResponse> CreateRuleAsync(CreateRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateRuleWithOptionsAsync(request, runtime);
        }

        public CreateProductTopicResponse CreateProductTopicWithOptions(CreateProductTopicRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CreateProductTopicResponse>(DoRequest("CreateProductTopic", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<CreateProductTopicResponse> CreateProductTopicWithOptionsAsync(CreateProductTopicRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CreateProductTopicResponse>(await DoRequestAsync("CreateProductTopic", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public CreateProductTopicResponse CreateProductTopic(CreateProductTopicRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateProductTopicWithOptions(request, runtime);
        }

        public async Task<CreateProductTopicResponse> CreateProductTopicAsync(CreateProductTopicRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateProductTopicWithOptionsAsync(request, runtime);
        }

        public QueryBatchRegisterDeviceStatusResponse QueryBatchRegisterDeviceStatusWithOptions(QueryBatchRegisterDeviceStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<QueryBatchRegisterDeviceStatusResponse>(DoRequest("QueryBatchRegisterDeviceStatus", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<QueryBatchRegisterDeviceStatusResponse> QueryBatchRegisterDeviceStatusWithOptionsAsync(QueryBatchRegisterDeviceStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<QueryBatchRegisterDeviceStatusResponse>(await DoRequestAsync("QueryBatchRegisterDeviceStatus", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public QueryBatchRegisterDeviceStatusResponse QueryBatchRegisterDeviceStatus(QueryBatchRegisterDeviceStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryBatchRegisterDeviceStatusWithOptions(request, runtime);
        }

        public async Task<QueryBatchRegisterDeviceStatusResponse> QueryBatchRegisterDeviceStatusAsync(QueryBatchRegisterDeviceStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryBatchRegisterDeviceStatusWithOptionsAsync(request, runtime);
        }

        public GetGatewayBySubDeviceResponse GetGatewayBySubDeviceWithOptions(GetGatewayBySubDeviceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetGatewayBySubDeviceResponse>(DoRequest("GetGatewayBySubDevice", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<GetGatewayBySubDeviceResponse> GetGatewayBySubDeviceWithOptionsAsync(GetGatewayBySubDeviceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetGatewayBySubDeviceResponse>(await DoRequestAsync("GetGatewayBySubDevice", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public GetGatewayBySubDeviceResponse GetGatewayBySubDevice(GetGatewayBySubDeviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetGatewayBySubDeviceWithOptions(request, runtime);
        }

        public async Task<GetGatewayBySubDeviceResponse> GetGatewayBySubDeviceAsync(GetGatewayBySubDeviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetGatewayBySubDeviceWithOptionsAsync(request, runtime);
        }

        public ResetThingResponse ResetThingWithOptions(ResetThingRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ResetThingResponse>(DoRequest("ResetThing", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<ResetThingResponse> ResetThingWithOptionsAsync(ResetThingRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ResetThingResponse>(await DoRequestAsync("ResetThing", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public ResetThingResponse ResetThing(ResetThingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ResetThingWithOptions(request, runtime);
        }

        public async Task<ResetThingResponse> ResetThingAsync(ResetThingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ResetThingWithOptionsAsync(request, runtime);
        }

        public RemoveThingTopoResponse RemoveThingTopoWithOptions(RemoveThingTopoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<RemoveThingTopoResponse>(DoRequest("RemoveThingTopo", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<RemoveThingTopoResponse> RemoveThingTopoWithOptionsAsync(RemoveThingTopoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<RemoveThingTopoResponse>(await DoRequestAsync("RemoveThingTopo", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public RemoveThingTopoResponse RemoveThingTopo(RemoveThingTopoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RemoveThingTopoWithOptions(request, runtime);
        }

        public async Task<RemoveThingTopoResponse> RemoveThingTopoAsync(RemoveThingTopoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RemoveThingTopoWithOptionsAsync(request, runtime);
        }

        public NotifyAddThingTopoResponse NotifyAddThingTopoWithOptions(NotifyAddThingTopoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<NotifyAddThingTopoResponse>(DoRequest("NotifyAddThingTopo", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<NotifyAddThingTopoResponse> NotifyAddThingTopoWithOptionsAsync(NotifyAddThingTopoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<NotifyAddThingTopoResponse>(await DoRequestAsync("NotifyAddThingTopo", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public NotifyAddThingTopoResponse NotifyAddThingTopo(NotifyAddThingTopoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return NotifyAddThingTopoWithOptions(request, runtime);
        }

        public async Task<NotifyAddThingTopoResponse> NotifyAddThingTopoAsync(NotifyAddThingTopoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await NotifyAddThingTopoWithOptionsAsync(request, runtime);
        }

        public GetThingTopoResponse GetThingTopoWithOptions(GetThingTopoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetThingTopoResponse>(DoRequest("GetThingTopo", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<GetThingTopoResponse> GetThingTopoWithOptionsAsync(GetThingTopoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetThingTopoResponse>(await DoRequestAsync("GetThingTopo", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public GetThingTopoResponse GetThingTopo(GetThingTopoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetThingTopoWithOptions(request, runtime);
        }

        public async Task<GetThingTopoResponse> GetThingTopoAsync(GetThingTopoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetThingTopoWithOptionsAsync(request, runtime);
        }

        public QueryDevicePropertyStatusResponse QueryDevicePropertyStatusWithOptions(QueryDevicePropertyStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<QueryDevicePropertyStatusResponse>(DoRequest("QueryDevicePropertyStatus", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<QueryDevicePropertyStatusResponse> QueryDevicePropertyStatusWithOptionsAsync(QueryDevicePropertyStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<QueryDevicePropertyStatusResponse>(await DoRequestAsync("QueryDevicePropertyStatus", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public QueryDevicePropertyStatusResponse QueryDevicePropertyStatus(QueryDevicePropertyStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryDevicePropertyStatusWithOptions(request, runtime);
        }

        public async Task<QueryDevicePropertyStatusResponse> QueryDevicePropertyStatusAsync(QueryDevicePropertyStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryDevicePropertyStatusWithOptionsAsync(request, runtime);
        }

        public QueryDevicePropertyDataResponse QueryDevicePropertyDataWithOptions(QueryDevicePropertyDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<QueryDevicePropertyDataResponse>(DoRequest("QueryDevicePropertyData", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<QueryDevicePropertyDataResponse> QueryDevicePropertyDataWithOptionsAsync(QueryDevicePropertyDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<QueryDevicePropertyDataResponse>(await DoRequestAsync("QueryDevicePropertyData", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public QueryDevicePropertyDataResponse QueryDevicePropertyData(QueryDevicePropertyDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryDevicePropertyDataWithOptions(request, runtime);
        }

        public async Task<QueryDevicePropertyDataResponse> QueryDevicePropertyDataAsync(QueryDevicePropertyDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryDevicePropertyDataWithOptionsAsync(request, runtime);
        }

        public BatchRegisterDeviceWithApplyIdResponse BatchRegisterDeviceWithApplyIdWithOptions(BatchRegisterDeviceWithApplyIdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<BatchRegisterDeviceWithApplyIdResponse>(DoRequest("BatchRegisterDeviceWithApplyId", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<BatchRegisterDeviceWithApplyIdResponse> BatchRegisterDeviceWithApplyIdWithOptionsAsync(BatchRegisterDeviceWithApplyIdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<BatchRegisterDeviceWithApplyIdResponse>(await DoRequestAsync("BatchRegisterDeviceWithApplyId", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public BatchRegisterDeviceWithApplyIdResponse BatchRegisterDeviceWithApplyId(BatchRegisterDeviceWithApplyIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return BatchRegisterDeviceWithApplyIdWithOptions(request, runtime);
        }

        public async Task<BatchRegisterDeviceWithApplyIdResponse> BatchRegisterDeviceWithApplyIdAsync(BatchRegisterDeviceWithApplyIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await BatchRegisterDeviceWithApplyIdWithOptionsAsync(request, runtime);
        }

        public BatchRegisterDeviceResponse BatchRegisterDeviceWithOptions(BatchRegisterDeviceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<BatchRegisterDeviceResponse>(DoRequest("BatchRegisterDevice", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<BatchRegisterDeviceResponse> BatchRegisterDeviceWithOptionsAsync(BatchRegisterDeviceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<BatchRegisterDeviceResponse>(await DoRequestAsync("BatchRegisterDevice", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public BatchRegisterDeviceResponse BatchRegisterDevice(BatchRegisterDeviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return BatchRegisterDeviceWithOptions(request, runtime);
        }

        public async Task<BatchRegisterDeviceResponse> BatchRegisterDeviceAsync(BatchRegisterDeviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await BatchRegisterDeviceWithOptionsAsync(request, runtime);
        }

        public BatchCheckDeviceNamesResponse BatchCheckDeviceNamesWithOptions(BatchCheckDeviceNamesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<BatchCheckDeviceNamesResponse>(DoRequest("BatchCheckDeviceNames", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<BatchCheckDeviceNamesResponse> BatchCheckDeviceNamesWithOptionsAsync(BatchCheckDeviceNamesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<BatchCheckDeviceNamesResponse>(await DoRequestAsync("BatchCheckDeviceNames", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public BatchCheckDeviceNamesResponse BatchCheckDeviceNames(BatchCheckDeviceNamesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return BatchCheckDeviceNamesWithOptions(request, runtime);
        }

        public async Task<BatchCheckDeviceNamesResponse> BatchCheckDeviceNamesAsync(BatchCheckDeviceNamesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await BatchCheckDeviceNamesWithOptionsAsync(request, runtime);
        }

        public UpdateProductResponse UpdateProductWithOptions(UpdateProductRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<UpdateProductResponse>(DoRequest("UpdateProduct", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<UpdateProductResponse> UpdateProductWithOptionsAsync(UpdateProductRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<UpdateProductResponse>(await DoRequestAsync("UpdateProduct", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public UpdateProductResponse UpdateProduct(UpdateProductRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateProductWithOptions(request, runtime);
        }

        public async Task<UpdateProductResponse> UpdateProductAsync(UpdateProductRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateProductWithOptionsAsync(request, runtime);
        }

        public SetDevicePropertyResponse SetDevicePropertyWithOptions(SetDevicePropertyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<SetDevicePropertyResponse>(DoRequest("SetDeviceProperty", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<SetDevicePropertyResponse> SetDevicePropertyWithOptionsAsync(SetDevicePropertyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<SetDevicePropertyResponse>(await DoRequestAsync("SetDeviceProperty", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public SetDevicePropertyResponse SetDeviceProperty(SetDevicePropertyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetDevicePropertyWithOptions(request, runtime);
        }

        public async Task<SetDevicePropertyResponse> SetDevicePropertyAsync(SetDevicePropertyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetDevicePropertyWithOptionsAsync(request, runtime);
        }

        public RegisterDeviceResponse RegisterDeviceWithOptions(RegisterDeviceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<RegisterDeviceResponse>(DoRequest("RegisterDevice", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<RegisterDeviceResponse> RegisterDeviceWithOptionsAsync(RegisterDeviceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<RegisterDeviceResponse>(await DoRequestAsync("RegisterDevice", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public RegisterDeviceResponse RegisterDevice(RegisterDeviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RegisterDeviceWithOptions(request, runtime);
        }

        public async Task<RegisterDeviceResponse> RegisterDeviceAsync(RegisterDeviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RegisterDeviceWithOptionsAsync(request, runtime);
        }

        public QueryProductListResponse QueryProductListWithOptions(QueryProductListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<QueryProductListResponse>(DoRequest("QueryProductList", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<QueryProductListResponse> QueryProductListWithOptionsAsync(QueryProductListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<QueryProductListResponse>(await DoRequestAsync("QueryProductList", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public QueryProductListResponse QueryProductList(QueryProductListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryProductListWithOptions(request, runtime);
        }

        public async Task<QueryProductListResponse> QueryProductListAsync(QueryProductListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryProductListWithOptionsAsync(request, runtime);
        }

        public QueryProductResponse QueryProductWithOptions(QueryProductRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<QueryProductResponse>(DoRequest("QueryProduct", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<QueryProductResponse> QueryProductWithOptionsAsync(QueryProductRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<QueryProductResponse>(await DoRequestAsync("QueryProduct", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public QueryProductResponse QueryProduct(QueryProductRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryProductWithOptions(request, runtime);
        }

        public async Task<QueryProductResponse> QueryProductAsync(QueryProductRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryProductWithOptionsAsync(request, runtime);
        }

        public QueryDeviceStatisticsResponse QueryDeviceStatisticsWithOptions(QueryDeviceStatisticsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<QueryDeviceStatisticsResponse>(DoRequest("QueryDeviceStatistics", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<QueryDeviceStatisticsResponse> QueryDeviceStatisticsWithOptionsAsync(QueryDeviceStatisticsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<QueryDeviceStatisticsResponse>(await DoRequestAsync("QueryDeviceStatistics", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public QueryDeviceStatisticsResponse QueryDeviceStatistics(QueryDeviceStatisticsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryDeviceStatisticsWithOptions(request, runtime);
        }

        public async Task<QueryDeviceStatisticsResponse> QueryDeviceStatisticsAsync(QueryDeviceStatisticsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryDeviceStatisticsWithOptionsAsync(request, runtime);
        }

        public QueryDeviceServiceDataResponse QueryDeviceServiceDataWithOptions(QueryDeviceServiceDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<QueryDeviceServiceDataResponse>(DoRequest("QueryDeviceServiceData", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<QueryDeviceServiceDataResponse> QueryDeviceServiceDataWithOptionsAsync(QueryDeviceServiceDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<QueryDeviceServiceDataResponse>(await DoRequestAsync("QueryDeviceServiceData", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public QueryDeviceServiceDataResponse QueryDeviceServiceData(QueryDeviceServiceDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryDeviceServiceDataWithOptions(request, runtime);
        }

        public async Task<QueryDeviceServiceDataResponse> QueryDeviceServiceDataAsync(QueryDeviceServiceDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryDeviceServiceDataWithOptionsAsync(request, runtime);
        }

        public QueryDeviceEventDataResponse QueryDeviceEventDataWithOptions(QueryDeviceEventDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<QueryDeviceEventDataResponse>(DoRequest("QueryDeviceEventData", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<QueryDeviceEventDataResponse> QueryDeviceEventDataWithOptionsAsync(QueryDeviceEventDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<QueryDeviceEventDataResponse>(await DoRequestAsync("QueryDeviceEventData", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public QueryDeviceEventDataResponse QueryDeviceEventData(QueryDeviceEventDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryDeviceEventDataWithOptions(request, runtime);
        }

        public async Task<QueryDeviceEventDataResponse> QueryDeviceEventDataAsync(QueryDeviceEventDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryDeviceEventDataWithOptionsAsync(request, runtime);
        }

        public QueryDeviceDetailResponse QueryDeviceDetailWithOptions(QueryDeviceDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<QueryDeviceDetailResponse>(DoRequest("QueryDeviceDetail", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<QueryDeviceDetailResponse> QueryDeviceDetailWithOptionsAsync(QueryDeviceDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<QueryDeviceDetailResponse>(await DoRequestAsync("QueryDeviceDetail", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public QueryDeviceDetailResponse QueryDeviceDetail(QueryDeviceDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryDeviceDetailWithOptions(request, runtime);
        }

        public async Task<QueryDeviceDetailResponse> QueryDeviceDetailAsync(QueryDeviceDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryDeviceDetailWithOptionsAsync(request, runtime);
        }

        public InvokeThingServiceResponse InvokeThingServiceWithOptions(InvokeThingServiceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<InvokeThingServiceResponse>(DoRequest("InvokeThingService", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<InvokeThingServiceResponse> InvokeThingServiceWithOptionsAsync(InvokeThingServiceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<InvokeThingServiceResponse>(await DoRequestAsync("InvokeThingService", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public InvokeThingServiceResponse InvokeThingService(InvokeThingServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return InvokeThingServiceWithOptions(request, runtime);
        }

        public async Task<InvokeThingServiceResponse> InvokeThingServiceAsync(InvokeThingServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await InvokeThingServiceWithOptionsAsync(request, runtime);
        }

        public GetDeviceStatusResponse GetDeviceStatusWithOptions(GetDeviceStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetDeviceStatusResponse>(DoRequest("GetDeviceStatus", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<GetDeviceStatusResponse> GetDeviceStatusWithOptionsAsync(GetDeviceStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetDeviceStatusResponse>(await DoRequestAsync("GetDeviceStatus", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public GetDeviceStatusResponse GetDeviceStatus(GetDeviceStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetDeviceStatusWithOptions(request, runtime);
        }

        public async Task<GetDeviceStatusResponse> GetDeviceStatusAsync(GetDeviceStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetDeviceStatusWithOptionsAsync(request, runtime);
        }

        public EnableThingResponse EnableThingWithOptions(EnableThingRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<EnableThingResponse>(DoRequest("EnableThing", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<EnableThingResponse> EnableThingWithOptionsAsync(EnableThingRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<EnableThingResponse>(await DoRequestAsync("EnableThing", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public EnableThingResponse EnableThing(EnableThingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return EnableThingWithOptions(request, runtime);
        }

        public async Task<EnableThingResponse> EnableThingAsync(EnableThingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await EnableThingWithOptionsAsync(request, runtime);
        }

        public DisableThingResponse DisableThingWithOptions(DisableThingRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DisableThingResponse>(DoRequest("DisableThing", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DisableThingResponse> DisableThingWithOptionsAsync(DisableThingRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DisableThingResponse>(await DoRequestAsync("DisableThing", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public DisableThingResponse DisableThing(DisableThingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DisableThingWithOptions(request, runtime);
        }

        public async Task<DisableThingResponse> DisableThingAsync(DisableThingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DisableThingWithOptionsAsync(request, runtime);
        }

        public DeleteProductResponse DeleteProductWithOptions(DeleteProductRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DeleteProductResponse>(DoRequest("DeleteProduct", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DeleteProductResponse> DeleteProductWithOptionsAsync(DeleteProductRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DeleteProductResponse>(await DoRequestAsync("DeleteProduct", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public DeleteProductResponse DeleteProduct(DeleteProductRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteProductWithOptions(request, runtime);
        }

        public async Task<DeleteProductResponse> DeleteProductAsync(DeleteProductRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteProductWithOptionsAsync(request, runtime);
        }

        public DeleteDeviceResponse DeleteDeviceWithOptions(DeleteDeviceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DeleteDeviceResponse>(DoRequest("DeleteDevice", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DeleteDeviceResponse> DeleteDeviceWithOptionsAsync(DeleteDeviceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DeleteDeviceResponse>(await DoRequestAsync("DeleteDevice", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public DeleteDeviceResponse DeleteDevice(DeleteDeviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteDeviceWithOptions(request, runtime);
        }

        public async Task<DeleteDeviceResponse> DeleteDeviceAsync(DeleteDeviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteDeviceWithOptionsAsync(request, runtime);
        }

        public CreateProductResponse CreateProductWithOptions(CreateProductRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CreateProductResponse>(DoRequest("CreateProduct", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public async Task<CreateProductResponse> CreateProductWithOptionsAsync(CreateProductRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<CreateProductResponse>(await DoRequestAsync("CreateProduct", "HTTPS", "POST", "2018-01-20", "AK", null, request.ToMap(), runtime));
        }

        public CreateProductResponse CreateProduct(CreateProductRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateProductWithOptions(request, runtime);
        }

        public async Task<CreateProductResponse> CreateProductAsync(CreateProductRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateProductWithOptionsAsync(request, runtime);
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
