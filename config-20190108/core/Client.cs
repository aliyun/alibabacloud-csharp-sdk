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
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
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

        public ActiveConfigRulesResponse ActiveConfigRulesWithOptions(ActiveConfigRulesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ActiveConfigRulesResponse>(DoRPCRequest("ActiveConfigRules", "2019-01-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ActiveConfigRulesResponse> ActiveConfigRulesWithOptionsAsync(ActiveConfigRulesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ActiveConfigRulesResponse>(await DoRPCRequestAsync("ActiveConfigRules", "2019-01-08", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public DeleteConfigRulesResponse DeleteConfigRulesWithOptions(DeleteConfigRulesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteConfigRulesResponse>(DoRPCRequest("DeleteConfigRules", "2019-01-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteConfigRulesResponse> DeleteConfigRulesWithOptionsAsync(DeleteConfigRulesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteConfigRulesResponse>(await DoRPCRequestAsync("DeleteConfigRules", "2019-01-08", "HTTPS", "POST", "AK", "json", req, runtime));
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
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<DescribeComplianceResponse>(DoRPCRequest("DescribeCompliance", "2019-01-08", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<DescribeComplianceResponse> DescribeComplianceWithOptionsAsync(DescribeComplianceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<DescribeComplianceResponse>(await DoRPCRequestAsync("DescribeCompliance", "2019-01-08", "HTTPS", "GET", "AK", "json", req, runtime));
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

        public DescribeComplianceSummaryResponse DescribeComplianceSummaryWithOptions(DescribeComplianceSummaryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<DescribeComplianceSummaryResponse>(DoRPCRequest("DescribeComplianceSummary", "2019-01-08", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<DescribeComplianceSummaryResponse> DescribeComplianceSummaryWithOptionsAsync(DescribeComplianceSummaryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<DescribeComplianceSummaryResponse>(await DoRPCRequestAsync("DescribeComplianceSummary", "2019-01-08", "HTTPS", "GET", "AK", "json", req, runtime));
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

        public DescribeConfigRuleResponse DescribeConfigRuleWithOptions(DescribeConfigRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<DescribeConfigRuleResponse>(DoRPCRequest("DescribeConfigRule", "2019-01-08", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<DescribeConfigRuleResponse> DescribeConfigRuleWithOptionsAsync(DescribeConfigRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<DescribeConfigRuleResponse>(await DoRPCRequestAsync("DescribeConfigRule", "2019-01-08", "HTTPS", "GET", "AK", "json", req, runtime));
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

        public DescribeConfigurationRecorderResponse DescribeConfigurationRecorderWithOptions(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            return TeaModel.ToObject<DescribeConfigurationRecorderResponse>(DoRPCRequest("DescribeConfigurationRecorder", "2019-01-08", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<DescribeConfigurationRecorderResponse> DescribeConfigurationRecorderWithOptionsAsync(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            return TeaModel.ToObject<DescribeConfigurationRecorderResponse>(await DoRPCRequestAsync("DescribeConfigurationRecorder", "2019-01-08", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public DescribeConfigurationRecorderResponse DescribeConfigurationRecorder()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeConfigurationRecorderWithOptions(runtime);
        }

        public async Task<DescribeConfigurationRecorderResponse> DescribeConfigurationRecorderAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeConfigurationRecorderWithOptionsAsync(runtime);
        }

        public DescribeDeliveryChannelsResponse DescribeDeliveryChannelsWithOptions(DescribeDeliveryChannelsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<DescribeDeliveryChannelsResponse>(DoRPCRequest("DescribeDeliveryChannels", "2019-01-08", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<DescribeDeliveryChannelsResponse> DescribeDeliveryChannelsWithOptionsAsync(DescribeDeliveryChannelsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<DescribeDeliveryChannelsResponse>(await DoRPCRequestAsync("DescribeDeliveryChannels", "2019-01-08", "HTTPS", "GET", "AK", "json", req, runtime));
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

        public DescribeDiscoveredResourceResponse DescribeDiscoveredResourceWithOptions(DescribeDiscoveredResourceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<DescribeDiscoveredResourceResponse>(DoRPCRequest("DescribeDiscoveredResource", "2019-01-08", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<DescribeDiscoveredResourceResponse> DescribeDiscoveredResourceWithOptionsAsync(DescribeDiscoveredResourceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<DescribeDiscoveredResourceResponse>(await DoRPCRequestAsync("DescribeDiscoveredResource", "2019-01-08", "HTTPS", "GET", "AK", "json", req, runtime));
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

        public DescribeEvaluationResultsResponse DescribeEvaluationResultsWithOptions(DescribeEvaluationResultsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<DescribeEvaluationResultsResponse>(DoRPCRequest("DescribeEvaluationResults", "2019-01-08", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<DescribeEvaluationResultsResponse> DescribeEvaluationResultsWithOptionsAsync(DescribeEvaluationResultsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<DescribeEvaluationResultsResponse>(await DoRPCRequestAsync("DescribeEvaluationResults", "2019-01-08", "HTTPS", "GET", "AK", "json", req, runtime));
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

        public GetAggregateDiscoveredResourceResponse GetAggregateDiscoveredResourceWithOptions(GetAggregateDiscoveredResourceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<GetAggregateDiscoveredResourceResponse>(DoRPCRequest("GetAggregateDiscoveredResource", "2019-01-08", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<GetAggregateDiscoveredResourceResponse> GetAggregateDiscoveredResourceWithOptionsAsync(GetAggregateDiscoveredResourceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<GetAggregateDiscoveredResourceResponse>(await DoRPCRequestAsync("GetAggregateDiscoveredResource", "2019-01-08", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public GetAggregateDiscoveredResourceResponse GetAggregateDiscoveredResource(GetAggregateDiscoveredResourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetAggregateDiscoveredResourceWithOptions(request, runtime);
        }

        public async Task<GetAggregateDiscoveredResourceResponse> GetAggregateDiscoveredResourceAsync(GetAggregateDiscoveredResourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetAggregateDiscoveredResourceWithOptionsAsync(request, runtime);
        }

        public GetDiscoveredResourceCountsResponse GetDiscoveredResourceCountsWithOptions(GetDiscoveredResourceCountsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<GetDiscoveredResourceCountsResponse>(DoRPCRequest("GetDiscoveredResourceCounts", "2019-01-08", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<GetDiscoveredResourceCountsResponse> GetDiscoveredResourceCountsWithOptionsAsync(GetDiscoveredResourceCountsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<GetDiscoveredResourceCountsResponse>(await DoRPCRequestAsync("GetDiscoveredResourceCounts", "2019-01-08", "HTTPS", "GET", "AK", "json", req, runtime));
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

        public GetDiscoveredResourceSummaryResponse GetDiscoveredResourceSummaryWithOptions(GetDiscoveredResourceSummaryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<GetDiscoveredResourceSummaryResponse>(DoRPCRequest("GetDiscoveredResourceSummary", "2019-01-08", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<GetDiscoveredResourceSummaryResponse> GetDiscoveredResourceSummaryWithOptionsAsync(GetDiscoveredResourceSummaryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<GetDiscoveredResourceSummaryResponse>(await DoRPCRequestAsync("GetDiscoveredResourceSummary", "2019-01-08", "HTTPS", "GET", "AK", "json", req, runtime));
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

        public GetResourceComplianceTimelineResponse GetResourceComplianceTimelineWithOptions(GetResourceComplianceTimelineRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<GetResourceComplianceTimelineResponse>(DoRPCRequest("GetResourceComplianceTimeline", "2019-01-08", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<GetResourceComplianceTimelineResponse> GetResourceComplianceTimelineWithOptionsAsync(GetResourceComplianceTimelineRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<GetResourceComplianceTimelineResponse>(await DoRPCRequestAsync("GetResourceComplianceTimeline", "2019-01-08", "HTTPS", "GET", "AK", "json", req, runtime));
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
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<GetResourceConfigurationTimelineResponse>(DoRPCRequest("GetResourceConfigurationTimeline", "2019-01-08", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<GetResourceConfigurationTimelineResponse> GetResourceConfigurationTimelineWithOptionsAsync(GetResourceConfigurationTimelineRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<GetResourceConfigurationTimelineResponse>(await DoRPCRequestAsync("GetResourceConfigurationTimeline", "2019-01-08", "HTTPS", "GET", "AK", "json", req, runtime));
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

        public GetSupportedResourceTypesResponse GetSupportedResourceTypesWithOptions(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            return TeaModel.ToObject<GetSupportedResourceTypesResponse>(DoRPCRequest("GetSupportedResourceTypes", "2019-01-08", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<GetSupportedResourceTypesResponse> GetSupportedResourceTypesWithOptionsAsync(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            return TeaModel.ToObject<GetSupportedResourceTypesResponse>(await DoRPCRequestAsync("GetSupportedResourceTypes", "2019-01-08", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public GetSupportedResourceTypesResponse GetSupportedResourceTypes()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetSupportedResourceTypesWithOptions(runtime);
        }

        public async Task<GetSupportedResourceTypesResponse> GetSupportedResourceTypesAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetSupportedResourceTypesWithOptionsAsync(runtime);
        }

        public ListAggregateDiscoveredResourcesResponse ListAggregateDiscoveredResourcesWithOptions(ListAggregateDiscoveredResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<ListAggregateDiscoveredResourcesResponse>(DoRPCRequest("ListAggregateDiscoveredResources", "2019-01-08", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<ListAggregateDiscoveredResourcesResponse> ListAggregateDiscoveredResourcesWithOptionsAsync(ListAggregateDiscoveredResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<ListAggregateDiscoveredResourcesResponse>(await DoRPCRequestAsync("ListAggregateDiscoveredResources", "2019-01-08", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public ListAggregateDiscoveredResourcesResponse ListAggregateDiscoveredResources(ListAggregateDiscoveredResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListAggregateDiscoveredResourcesWithOptions(request, runtime);
        }

        public async Task<ListAggregateDiscoveredResourcesResponse> ListAggregateDiscoveredResourcesAsync(ListAggregateDiscoveredResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListAggregateDiscoveredResourcesWithOptionsAsync(request, runtime);
        }

        public ListConfigRulesResponse ListConfigRulesWithOptions(ListConfigRulesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<ListConfigRulesResponse>(DoRPCRequest("ListConfigRules", "2019-01-08", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<ListConfigRulesResponse> ListConfigRulesWithOptionsAsync(ListConfigRulesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<ListConfigRulesResponse>(await DoRPCRequestAsync("ListConfigRules", "2019-01-08", "HTTPS", "GET", "AK", "json", req, runtime));
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

        public ListDiscoveredResourcesResponse ListDiscoveredResourcesWithOptions(ListDiscoveredResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<ListDiscoveredResourcesResponse>(DoRPCRequest("ListDiscoveredResources", "2019-01-08", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<ListDiscoveredResourcesResponse> ListDiscoveredResourcesWithOptionsAsync(ListDiscoveredResourcesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<ListDiscoveredResourcesResponse>(await DoRPCRequestAsync("ListDiscoveredResources", "2019-01-08", "HTTPS", "GET", "AK", "json", req, runtime));
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

        public ListRemediationTemplatesResponse ListRemediationTemplatesWithOptions(ListRemediationTemplatesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListRemediationTemplatesResponse>(DoRPCRequest("ListRemediationTemplates", "2019-01-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListRemediationTemplatesResponse> ListRemediationTemplatesWithOptionsAsync(ListRemediationTemplatesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListRemediationTemplatesResponse>(await DoRPCRequestAsync("ListRemediationTemplates", "2019-01-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListRemediationTemplatesResponse ListRemediationTemplates(ListRemediationTemplatesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListRemediationTemplatesWithOptions(request, runtime);
        }

        public async Task<ListRemediationTemplatesResponse> ListRemediationTemplatesAsync(ListRemediationTemplatesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListRemediationTemplatesWithOptionsAsync(request, runtime);
        }

        public PutConfigRuleResponse PutConfigRuleWithOptions(PutConfigRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<PutConfigRuleResponse>(DoRPCRequest("PutConfigRule", "2019-01-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<PutConfigRuleResponse> PutConfigRuleWithOptionsAsync(PutConfigRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<PutConfigRuleResponse>(await DoRPCRequestAsync("PutConfigRule", "2019-01-08", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public PutConfigurationRecorderResponse PutConfigurationRecorderWithOptions(PutConfigurationRecorderRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<PutConfigurationRecorderResponse>(DoRPCRequest("PutConfigurationRecorder", "2019-01-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<PutConfigurationRecorderResponse> PutConfigurationRecorderWithOptionsAsync(PutConfigurationRecorderRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<PutConfigurationRecorderResponse>(await DoRPCRequestAsync("PutConfigurationRecorder", "2019-01-08", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public PutDeliveryChannelResponse PutDeliveryChannelWithOptions(PutDeliveryChannelRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<PutDeliveryChannelResponse>(DoRPCRequest("PutDeliveryChannel", "2019-01-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<PutDeliveryChannelResponse> PutDeliveryChannelWithOptionsAsync(PutDeliveryChannelRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<PutDeliveryChannelResponse>(await DoRPCRequestAsync("PutDeliveryChannel", "2019-01-08", "HTTPS", "POST", "AK", "json", req, runtime));
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<PutEvaluationsResponse>(DoRPCRequest("PutEvaluations", "2019-01-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<PutEvaluationsResponse> PutEvaluationsWithOptionsAsync(PutEvaluationsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<PutEvaluationsResponse>(await DoRPCRequestAsync("PutEvaluations", "2019-01-08", "HTTPS", "POST", "AK", "json", req, runtime));
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
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<StartConfigRuleEvaluationResponse>(DoRPCRequest("StartConfigRuleEvaluation", "2019-01-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<StartConfigRuleEvaluationResponse> StartConfigRuleEvaluationWithOptionsAsync(StartConfigRuleEvaluationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<StartConfigRuleEvaluationResponse>(await DoRPCRequestAsync("StartConfigRuleEvaluation", "2019-01-08", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public StartConfigurationRecorderResponse StartConfigurationRecorderWithOptions(StartConfigurationRecorderRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<StartConfigurationRecorderResponse>(DoRPCRequest("StartConfigurationRecorder", "2019-01-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<StartConfigurationRecorderResponse> StartConfigurationRecorderWithOptionsAsync(StartConfigurationRecorderRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<StartConfigurationRecorderResponse>(await DoRPCRequestAsync("StartConfigurationRecorder", "2019-01-08", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public StopConfigRulesResponse StopConfigRulesWithOptions(StopConfigRulesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<StopConfigRulesResponse>(DoRPCRequest("StopConfigRules", "2019-01-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<StopConfigRulesResponse> StopConfigRulesWithOptionsAsync(StopConfigRulesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<StopConfigRulesResponse>(await DoRPCRequestAsync("StopConfigRules", "2019-01-08", "HTTPS", "POST", "AK", "json", req, runtime));
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

    }
}
