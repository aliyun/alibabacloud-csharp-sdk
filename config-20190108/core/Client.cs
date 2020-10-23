// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Config20190108.Models;

namespace AlibabaCloud.SDK.Config20190108
{
    public class Client : AlibabaCloud.RPCClient.Client
    {

        public Client(AlibabaCloud.RPCClient.Models.Config config): base(config)
        {
            this._endpointRule = "central";
            this._endpointMap = new Dictionary<string, string>
            {
                {"cn-shanghai", "config.cn-shanghai.aliyuncs.com"},
                {"ap-southeast-1", "config.ap-southeast-1.aliyuncs.com"},
            };
            CheckConfig(config);
            this._endpoint = GetEndpoint("config", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
        }


        public GetResourceComplianceTimelineResponse GetResourceComplianceTimelineWithOptions(GetResourceComplianceTimelineRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetResourceComplianceTimelineResponse>(DoRequest("GetResourceComplianceTimeline", "HTTPS", "GET", "2019-01-08", "AK", request.ToMap(), null, runtime));
        }

        public async Task<GetResourceComplianceTimelineResponse> GetResourceComplianceTimelineWithOptionsAsync(GetResourceComplianceTimelineRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetResourceComplianceTimelineResponse>(await DoRequestAsync("GetResourceComplianceTimeline", "HTTPS", "GET", "2019-01-08", "AK", request.ToMap(), null, runtime));
        }

        public GetResourceComplianceTimelineResponse GetResourceComplianceTimeline(GetResourceComplianceTimelineRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetResourceComplianceTimelineWithOptions(request, runtime);
        }

        public async Task<GetResourceComplianceTimelineResponse> GetResourceComplianceTimelineAsync(GetResourceComplianceTimelineRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetResourceComplianceTimelineWithOptionsAsync(request, runtime);
        }

        public GetResourceConfigurationTimelineResponse GetResourceConfigurationTimelineWithOptions(GetResourceConfigurationTimelineRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetResourceConfigurationTimelineResponse>(DoRequest("GetResourceConfigurationTimeline", "HTTPS", "GET", "2019-01-08", "AK", request.ToMap(), null, runtime));
        }

        public async Task<GetResourceConfigurationTimelineResponse> GetResourceConfigurationTimelineWithOptionsAsync(GetResourceConfigurationTimelineRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetResourceConfigurationTimelineResponse>(await DoRequestAsync("GetResourceConfigurationTimeline", "HTTPS", "GET", "2019-01-08", "AK", request.ToMap(), null, runtime));
        }

        public GetResourceConfigurationTimelineResponse GetResourceConfigurationTimeline(GetResourceConfigurationTimelineRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetResourceConfigurationTimelineWithOptions(request, runtime);
        }

        public async Task<GetResourceConfigurationTimelineResponse> GetResourceConfigurationTimelineAsync(GetResourceConfigurationTimelineRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetResourceConfigurationTimelineWithOptionsAsync(request, runtime);
        }

        public DescribeDeliveryChannelsResponse DescribeDeliveryChannelsWithOptions(DescribeDeliveryChannelsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeDeliveryChannelsResponse>(DoRequest("DescribeDeliveryChannels", "HTTPS", "GET", "2019-01-08", "AK", request.ToMap(), null, runtime));
        }

        public async Task<DescribeDeliveryChannelsResponse> DescribeDeliveryChannelsWithOptionsAsync(DescribeDeliveryChannelsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeDeliveryChannelsResponse>(await DoRequestAsync("DescribeDeliveryChannels", "HTTPS", "GET", "2019-01-08", "AK", request.ToMap(), null, runtime));
        }

        public DescribeDeliveryChannelsResponse DescribeDeliveryChannels(DescribeDeliveryChannelsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDeliveryChannelsWithOptions(request, runtime);
        }

        public async Task<DescribeDeliveryChannelsResponse> DescribeDeliveryChannelsAsync(DescribeDeliveryChannelsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDeliveryChannelsWithOptionsAsync(request, runtime);
        }

        public PutConfigurationRecorderResponse PutConfigurationRecorderWithOptions(PutConfigurationRecorderRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<PutConfigurationRecorderResponse>(DoRequest("PutConfigurationRecorder", "HTTPS", "POST", "2019-01-08", "AK", null, request.ToMap(), runtime));
        }

        public async Task<PutConfigurationRecorderResponse> PutConfigurationRecorderWithOptionsAsync(PutConfigurationRecorderRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<PutConfigurationRecorderResponse>(await DoRequestAsync("PutConfigurationRecorder", "HTTPS", "POST", "2019-01-08", "AK", null, request.ToMap(), runtime));
        }

        public PutConfigurationRecorderResponse PutConfigurationRecorder(PutConfigurationRecorderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return PutConfigurationRecorderWithOptions(request, runtime);
        }

        public async Task<PutConfigurationRecorderResponse> PutConfigurationRecorderAsync(PutConfigurationRecorderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await PutConfigurationRecorderWithOptionsAsync(request, runtime);
        }

        public GetDiscoveredResourceSummaryResponse GetDiscoveredResourceSummaryWithOptions(GetDiscoveredResourceSummaryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetDiscoveredResourceSummaryResponse>(DoRequest("GetDiscoveredResourceSummary", "HTTPS", "GET", "2019-01-08", "AK", request.ToMap(), null, runtime));
        }

        public async Task<GetDiscoveredResourceSummaryResponse> GetDiscoveredResourceSummaryWithOptionsAsync(GetDiscoveredResourceSummaryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetDiscoveredResourceSummaryResponse>(await DoRequestAsync("GetDiscoveredResourceSummary", "HTTPS", "GET", "2019-01-08", "AK", request.ToMap(), null, runtime));
        }

        public GetDiscoveredResourceSummaryResponse GetDiscoveredResourceSummary(GetDiscoveredResourceSummaryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetDiscoveredResourceSummaryWithOptions(request, runtime);
        }

        public async Task<GetDiscoveredResourceSummaryResponse> GetDiscoveredResourceSummaryAsync(GetDiscoveredResourceSummaryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetDiscoveredResourceSummaryWithOptionsAsync(request, runtime);
        }

        public ActiveConfigRulesResponse ActiveConfigRulesWithOptions(ActiveConfigRulesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ActiveConfigRulesResponse>(DoRequest("ActiveConfigRules", "HTTPS", "POST", "2019-01-08", "AK", null, request.ToMap(), runtime));
        }

        public async Task<ActiveConfigRulesResponse> ActiveConfigRulesWithOptionsAsync(ActiveConfigRulesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ActiveConfigRulesResponse>(await DoRequestAsync("ActiveConfigRules", "HTTPS", "POST", "2019-01-08", "AK", null, request.ToMap(), runtime));
        }

        public ActiveConfigRulesResponse ActiveConfigRules(ActiveConfigRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ActiveConfigRulesWithOptions(request, runtime);
        }

        public async Task<ActiveConfigRulesResponse> ActiveConfigRulesAsync(ActiveConfigRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ActiveConfigRulesWithOptionsAsync(request, runtime);
        }

        public StopConfigRulesResponse StopConfigRulesWithOptions(StopConfigRulesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<StopConfigRulesResponse>(DoRequest("StopConfigRules", "HTTPS", "POST", "2019-01-08", "AK", null, request.ToMap(), runtime));
        }

        public async Task<StopConfigRulesResponse> StopConfigRulesWithOptionsAsync(StopConfigRulesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<StopConfigRulesResponse>(await DoRequestAsync("StopConfigRules", "HTTPS", "POST", "2019-01-08", "AK", null, request.ToMap(), runtime));
        }

        public StopConfigRulesResponse StopConfigRules(StopConfigRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StopConfigRulesWithOptions(request, runtime);
        }

        public async Task<StopConfigRulesResponse> StopConfigRulesAsync(StopConfigRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StopConfigRulesWithOptionsAsync(request, runtime);
        }

        public DescribeComplianceSummaryResponse DescribeComplianceSummaryWithOptions(DescribeComplianceSummaryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeComplianceSummaryResponse>(DoRequest("DescribeComplianceSummary", "HTTPS", "GET", "2019-01-08", "AK", request.ToMap(), null, runtime));
        }

        public async Task<DescribeComplianceSummaryResponse> DescribeComplianceSummaryWithOptionsAsync(DescribeComplianceSummaryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeComplianceSummaryResponse>(await DoRequestAsync("DescribeComplianceSummary", "HTTPS", "GET", "2019-01-08", "AK", request.ToMap(), null, runtime));
        }

        public DescribeComplianceSummaryResponse DescribeComplianceSummary(DescribeComplianceSummaryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeComplianceSummaryWithOptions(request, runtime);
        }

        public async Task<DescribeComplianceSummaryResponse> DescribeComplianceSummaryAsync(DescribeComplianceSummaryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeComplianceSummaryWithOptionsAsync(request, runtime);
        }

        public ListConfigRulesResponse ListConfigRulesWithOptions(ListConfigRulesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ListConfigRulesResponse>(DoRequest("ListConfigRules", "HTTPS", "GET", "2019-01-08", "AK", request.ToMap(), null, runtime));
        }

        public async Task<ListConfigRulesResponse> ListConfigRulesWithOptionsAsync(ListConfigRulesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ListConfigRulesResponse>(await DoRequestAsync("ListConfigRules", "HTTPS", "GET", "2019-01-08", "AK", request.ToMap(), null, runtime));
        }

        public ListConfigRulesResponse ListConfigRules(ListConfigRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListConfigRulesWithOptions(request, runtime);
        }

        public async Task<ListConfigRulesResponse> ListConfigRulesAsync(ListConfigRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListConfigRulesWithOptionsAsync(request, runtime);
        }

        public PutConfigRuleResponse PutConfigRuleWithOptions(PutConfigRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<PutConfigRuleResponse>(DoRequest("PutConfigRule", "HTTPS", "POST", "2019-01-08", "AK", null, request.ToMap(), runtime));
        }

        public async Task<PutConfigRuleResponse> PutConfigRuleWithOptionsAsync(PutConfigRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<PutConfigRuleResponse>(await DoRequestAsync("PutConfigRule", "HTTPS", "POST", "2019-01-08", "AK", null, request.ToMap(), runtime));
        }

        public PutConfigRuleResponse PutConfigRule(PutConfigRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return PutConfigRuleWithOptions(request, runtime);
        }

        public async Task<PutConfigRuleResponse> PutConfigRuleAsync(PutConfigRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await PutConfigRuleWithOptionsAsync(request, runtime);
        }

        public DescribeEvaluationResultsResponse DescribeEvaluationResultsWithOptions(DescribeEvaluationResultsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeEvaluationResultsResponse>(DoRequest("DescribeEvaluationResults", "HTTPS", "GET", "2019-01-08", "AK", request.ToMap(), null, runtime));
        }

        public async Task<DescribeEvaluationResultsResponse> DescribeEvaluationResultsWithOptionsAsync(DescribeEvaluationResultsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeEvaluationResultsResponse>(await DoRequestAsync("DescribeEvaluationResults", "HTTPS", "GET", "2019-01-08", "AK", request.ToMap(), null, runtime));
        }

        public DescribeEvaluationResultsResponse DescribeEvaluationResults(DescribeEvaluationResultsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeEvaluationResultsWithOptions(request, runtime);
        }

        public async Task<DescribeEvaluationResultsResponse> DescribeEvaluationResultsAsync(DescribeEvaluationResultsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeEvaluationResultsWithOptionsAsync(request, runtime);
        }

        public DeleteConfigRulesResponse DeleteConfigRulesWithOptions(DeleteConfigRulesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DeleteConfigRulesResponse>(DoRequest("DeleteConfigRules", "HTTPS", "POST", "2019-01-08", "AK", null, request.ToMap(), runtime));
        }

        public async Task<DeleteConfigRulesResponse> DeleteConfigRulesWithOptionsAsync(DeleteConfigRulesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DeleteConfigRulesResponse>(await DoRequestAsync("DeleteConfigRules", "HTTPS", "POST", "2019-01-08", "AK", null, request.ToMap(), runtime));
        }

        public DeleteConfigRulesResponse DeleteConfigRules(DeleteConfigRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteConfigRulesWithOptions(request, runtime);
        }

        public async Task<DeleteConfigRulesResponse> DeleteConfigRulesAsync(DeleteConfigRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteConfigRulesWithOptionsAsync(request, runtime);
        }

        public DescribeComplianceResponse DescribeComplianceWithOptions(DescribeComplianceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeComplianceResponse>(DoRequest("DescribeCompliance", "HTTPS", "GET", "2019-01-08", "AK", request.ToMap(), null, runtime));
        }

        public async Task<DescribeComplianceResponse> DescribeComplianceWithOptionsAsync(DescribeComplianceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeComplianceResponse>(await DoRequestAsync("DescribeCompliance", "HTTPS", "GET", "2019-01-08", "AK", request.ToMap(), null, runtime));
        }

        public DescribeComplianceResponse DescribeCompliance(DescribeComplianceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeComplianceWithOptions(request, runtime);
        }

        public async Task<DescribeComplianceResponse> DescribeComplianceAsync(DescribeComplianceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeComplianceWithOptionsAsync(request, runtime);
        }

        public GetDiscoveredResourceCountsResponse GetDiscoveredResourceCountsWithOptions(GetDiscoveredResourceCountsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetDiscoveredResourceCountsResponse>(DoRequest("GetDiscoveredResourceCounts", "HTTPS", "GET", "2019-01-08", "AK", request.ToMap(), null, runtime));
        }

        public async Task<GetDiscoveredResourceCountsResponse> GetDiscoveredResourceCountsWithOptionsAsync(GetDiscoveredResourceCountsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetDiscoveredResourceCountsResponse>(await DoRequestAsync("GetDiscoveredResourceCounts", "HTTPS", "GET", "2019-01-08", "AK", request.ToMap(), null, runtime));
        }

        public GetDiscoveredResourceCountsResponse GetDiscoveredResourceCounts(GetDiscoveredResourceCountsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetDiscoveredResourceCountsWithOptions(request, runtime);
        }

        public async Task<GetDiscoveredResourceCountsResponse> GetDiscoveredResourceCountsAsync(GetDiscoveredResourceCountsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetDiscoveredResourceCountsWithOptionsAsync(request, runtime);
        }

        public ListDiscoveredResourcesResponse ListDiscoveredResourcesWithOptions(ListDiscoveredResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ListDiscoveredResourcesResponse>(DoRequest("ListDiscoveredResources", "HTTPS", "GET", "2019-01-08", "AK", request.ToMap(), null, runtime));
        }

        public async Task<ListDiscoveredResourcesResponse> ListDiscoveredResourcesWithOptionsAsync(ListDiscoveredResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<ListDiscoveredResourcesResponse>(await DoRequestAsync("ListDiscoveredResources", "HTTPS", "GET", "2019-01-08", "AK", request.ToMap(), null, runtime));
        }

        public ListDiscoveredResourcesResponse ListDiscoveredResources(ListDiscoveredResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListDiscoveredResourcesWithOptions(request, runtime);
        }

        public async Task<ListDiscoveredResourcesResponse> ListDiscoveredResourcesAsync(ListDiscoveredResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListDiscoveredResourcesWithOptionsAsync(request, runtime);
        }

        public DescribeConfigurationRecorderResponse DescribeConfigurationRecorderWithOptions(DescribeConfigurationRecorderRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeConfigurationRecorderResponse>(DoRequest("DescribeConfigurationRecorder", "HTTPS", "GET", "2019-01-08", "AK", request.ToMap(), null, runtime));
        }

        public async Task<DescribeConfigurationRecorderResponse> DescribeConfigurationRecorderWithOptionsAsync(DescribeConfigurationRecorderRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeConfigurationRecorderResponse>(await DoRequestAsync("DescribeConfigurationRecorder", "HTTPS", "GET", "2019-01-08", "AK", request.ToMap(), null, runtime));
        }

        public DescribeConfigurationRecorderResponse DescribeConfigurationRecorder(DescribeConfigurationRecorderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeConfigurationRecorderWithOptions(request, runtime);
        }

        public async Task<DescribeConfigurationRecorderResponse> DescribeConfigurationRecorderAsync(DescribeConfigurationRecorderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeConfigurationRecorderWithOptionsAsync(request, runtime);
        }

        public DescribeDiscoveredResourceResponse DescribeDiscoveredResourceWithOptions(DescribeDiscoveredResourceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeDiscoveredResourceResponse>(DoRequest("DescribeDiscoveredResource", "HTTPS", "GET", "2019-01-08", "AK", request.ToMap(), null, runtime));
        }

        public async Task<DescribeDiscoveredResourceResponse> DescribeDiscoveredResourceWithOptionsAsync(DescribeDiscoveredResourceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeDiscoveredResourceResponse>(await DoRequestAsync("DescribeDiscoveredResource", "HTTPS", "GET", "2019-01-08", "AK", request.ToMap(), null, runtime));
        }

        public DescribeDiscoveredResourceResponse DescribeDiscoveredResource(DescribeDiscoveredResourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDiscoveredResourceWithOptions(request, runtime);
        }

        public async Task<DescribeDiscoveredResourceResponse> DescribeDiscoveredResourceAsync(DescribeDiscoveredResourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDiscoveredResourceWithOptionsAsync(request, runtime);
        }

        public StartConfigurationRecorderResponse StartConfigurationRecorderWithOptions(StartConfigurationRecorderRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<StartConfigurationRecorderResponse>(DoRequest("StartConfigurationRecorder", "HTTPS", "POST", "2019-01-08", "AK", null, request.ToMap(), runtime));
        }

        public async Task<StartConfigurationRecorderResponse> StartConfigurationRecorderWithOptionsAsync(StartConfigurationRecorderRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<StartConfigurationRecorderResponse>(await DoRequestAsync("StartConfigurationRecorder", "HTTPS", "POST", "2019-01-08", "AK", null, request.ToMap(), runtime));
        }

        public StartConfigurationRecorderResponse StartConfigurationRecorder(StartConfigurationRecorderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StartConfigurationRecorderWithOptions(request, runtime);
        }

        public async Task<StartConfigurationRecorderResponse> StartConfigurationRecorderAsync(StartConfigurationRecorderRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StartConfigurationRecorderWithOptionsAsync(request, runtime);
        }

        public DescribeConfigRuleResponse DescribeConfigRuleWithOptions(DescribeConfigRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeConfigRuleResponse>(DoRequest("DescribeConfigRule", "HTTPS", "GET", "2019-01-08", "AK", request.ToMap(), null, runtime));
        }

        public async Task<DescribeConfigRuleResponse> DescribeConfigRuleWithOptionsAsync(DescribeConfigRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<DescribeConfigRuleResponse>(await DoRequestAsync("DescribeConfigRule", "HTTPS", "GET", "2019-01-08", "AK", request.ToMap(), null, runtime));
        }

        public DescribeConfigRuleResponse DescribeConfigRule(DescribeConfigRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeConfigRuleWithOptions(request, runtime);
        }

        public async Task<DescribeConfigRuleResponse> DescribeConfigRuleAsync(DescribeConfigRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeConfigRuleWithOptionsAsync(request, runtime);
        }

        public GetSupportedResourceTypesResponse GetSupportedResourceTypesWithOptions(GetSupportedResourceTypesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetSupportedResourceTypesResponse>(DoRequest("GetSupportedResourceTypes", "HTTPS", "GET", "2019-01-08", "AK", request.ToMap(), null, runtime));
        }

        public async Task<GetSupportedResourceTypesResponse> GetSupportedResourceTypesWithOptionsAsync(GetSupportedResourceTypesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<GetSupportedResourceTypesResponse>(await DoRequestAsync("GetSupportedResourceTypes", "HTTPS", "GET", "2019-01-08", "AK", request.ToMap(), null, runtime));
        }

        public GetSupportedResourceTypesResponse GetSupportedResourceTypes(GetSupportedResourceTypesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetSupportedResourceTypesWithOptions(request, runtime);
        }

        public async Task<GetSupportedResourceTypesResponse> GetSupportedResourceTypesAsync(GetSupportedResourceTypesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetSupportedResourceTypesWithOptionsAsync(request, runtime);
        }

        public PutDeliveryChannelResponse PutDeliveryChannelWithOptions(PutDeliveryChannelRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<PutDeliveryChannelResponse>(DoRequest("PutDeliveryChannel", "HTTPS", "POST", "2019-01-08", "AK", null, request.ToMap(), runtime));
        }

        public async Task<PutDeliveryChannelResponse> PutDeliveryChannelWithOptionsAsync(PutDeliveryChannelRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<PutDeliveryChannelResponse>(await DoRequestAsync("PutDeliveryChannel", "HTTPS", "POST", "2019-01-08", "AK", null, request.ToMap(), runtime));
        }

        public PutDeliveryChannelResponse PutDeliveryChannel(PutDeliveryChannelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return PutDeliveryChannelWithOptions(request, runtime);
        }

        public async Task<PutDeliveryChannelResponse> PutDeliveryChannelAsync(PutDeliveryChannelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await PutDeliveryChannelWithOptionsAsync(request, runtime);
        }

        public PutEvaluationsResponse PutEvaluationsWithOptions(PutEvaluationsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<PutEvaluationsResponse>(DoRequest("PutEvaluations", "HTTPS", "POST", "2019-01-08", "AK", null, request.ToMap(), runtime));
        }

        public async Task<PutEvaluationsResponse> PutEvaluationsWithOptionsAsync(PutEvaluationsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<PutEvaluationsResponse>(await DoRequestAsync("PutEvaluations", "HTTPS", "POST", "2019-01-08", "AK", null, request.ToMap(), runtime));
        }

        public PutEvaluationsResponse PutEvaluations(PutEvaluationsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return PutEvaluationsWithOptions(request, runtime);
        }

        public async Task<PutEvaluationsResponse> PutEvaluationsAsync(PutEvaluationsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await PutEvaluationsWithOptionsAsync(request, runtime);
        }

        public StartConfigRuleEvaluationResponse StartConfigRuleEvaluationWithOptions(StartConfigRuleEvaluationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<StartConfigRuleEvaluationResponse>(DoRequest("StartConfigRuleEvaluation", "HTTPS", "POST", "2019-01-08", "AK", null, request.ToMap(), runtime));
        }

        public async Task<StartConfigRuleEvaluationResponse> StartConfigRuleEvaluationWithOptionsAsync(StartConfigRuleEvaluationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            return TeaModel.ToObject<StartConfigRuleEvaluationResponse>(await DoRequestAsync("StartConfigRuleEvaluation", "HTTPS", "POST", "2019-01-08", "AK", null, request.ToMap(), runtime));
        }

        public StartConfigRuleEvaluationResponse StartConfigRuleEvaluation(StartConfigRuleEvaluationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StartConfigRuleEvaluationWithOptions(request, runtime);
        }

        public async Task<StartConfigRuleEvaluationResponse> StartConfigRuleEvaluationAsync(StartConfigRuleEvaluationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StartConfigRuleEvaluationWithOptionsAsync(request, runtime);
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
