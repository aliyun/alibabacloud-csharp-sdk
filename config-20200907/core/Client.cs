// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Config20200907.Models;

namespace AlibabaCloud.SDK.Config20200907
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

        public DeleteAggregateConfigRulesResponse DeleteAggregateConfigRulesWithOptions(DeleteAggregateConfigRulesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteAggregateConfigRulesResponse>(DoRPCRequest("DeleteAggregateConfigRules", "2020-09-07", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteAggregateConfigRulesResponse> DeleteAggregateConfigRulesWithOptionsAsync(DeleteAggregateConfigRulesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteAggregateConfigRulesResponse>(await DoRPCRequestAsync("DeleteAggregateConfigRules", "2020-09-07", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteAggregateConfigRulesResponse DeleteAggregateConfigRules(DeleteAggregateConfigRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteAggregateConfigRulesWithOptions(request, runtime);
        }

        public async Task<DeleteAggregateConfigRulesResponse> DeleteAggregateConfigRulesAsync(DeleteAggregateConfigRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteAggregateConfigRulesWithOptionsAsync(request, runtime);
        }

        public DeactiveAggregateConfigRulesResponse DeactiveAggregateConfigRulesWithOptions(DeactiveAggregateConfigRulesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeactiveAggregateConfigRulesResponse>(DoRPCRequest("DeactiveAggregateConfigRules", "2020-09-07", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeactiveAggregateConfigRulesResponse> DeactiveAggregateConfigRulesWithOptionsAsync(DeactiveAggregateConfigRulesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeactiveAggregateConfigRulesResponse>(await DoRPCRequestAsync("DeactiveAggregateConfigRules", "2020-09-07", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeactiveAggregateConfigRulesResponse DeactiveAggregateConfigRules(DeactiveAggregateConfigRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeactiveAggregateConfigRulesWithOptions(request, runtime);
        }

        public async Task<DeactiveAggregateConfigRulesResponse> DeactiveAggregateConfigRulesAsync(DeactiveAggregateConfigRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeactiveAggregateConfigRulesWithOptionsAsync(request, runtime);
        }

        public GetAggregateConfigRulesReportResponse GetAggregateConfigRulesReportWithOptions(GetAggregateConfigRulesReportRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<GetAggregateConfigRulesReportResponse>(DoRPCRequest("GetAggregateConfigRulesReport", "2020-09-07", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<GetAggregateConfigRulesReportResponse> GetAggregateConfigRulesReportWithOptionsAsync(GetAggregateConfigRulesReportRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<GetAggregateConfigRulesReportResponse>(await DoRPCRequestAsync("GetAggregateConfigRulesReport", "2020-09-07", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public GetAggregateConfigRulesReportResponse GetAggregateConfigRulesReport(GetAggregateConfigRulesReportRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetAggregateConfigRulesReportWithOptions(request, runtime);
        }

        public async Task<GetAggregateConfigRulesReportResponse> GetAggregateConfigRulesReportAsync(GetAggregateConfigRulesReportRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetAggregateConfigRulesReportWithOptionsAsync(request, runtime);
        }

        public GetResourceInventoryResponse GetResourceInventoryWithOptions(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            return TeaModel.ToObject<GetResourceInventoryResponse>(DoRPCRequest("GetResourceInventory", "2020-09-07", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetResourceInventoryResponse> GetResourceInventoryWithOptionsAsync(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            return TeaModel.ToObject<GetResourceInventoryResponse>(await DoRPCRequestAsync("GetResourceInventory", "2020-09-07", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetResourceInventoryResponse GetResourceInventory()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetResourceInventoryWithOptions(runtime);
        }

        public async Task<GetResourceInventoryResponse> GetResourceInventoryAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetResourceInventoryWithOptionsAsync(runtime);
        }

        public ListAggregateConfigRuleEvaluationResultsResponse ListAggregateConfigRuleEvaluationResultsWithOptions(ListAggregateConfigRuleEvaluationResultsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<ListAggregateConfigRuleEvaluationResultsResponse>(DoRPCRequest("ListAggregateConfigRuleEvaluationResults", "2020-09-07", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<ListAggregateConfigRuleEvaluationResultsResponse> ListAggregateConfigRuleEvaluationResultsWithOptionsAsync(ListAggregateConfigRuleEvaluationResultsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<ListAggregateConfigRuleEvaluationResultsResponse>(await DoRPCRequestAsync("ListAggregateConfigRuleEvaluationResults", "2020-09-07", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public ListAggregateConfigRuleEvaluationResultsResponse ListAggregateConfigRuleEvaluationResults(ListAggregateConfigRuleEvaluationResultsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListAggregateConfigRuleEvaluationResultsWithOptions(request, runtime);
        }

        public async Task<ListAggregateConfigRuleEvaluationResultsResponse> ListAggregateConfigRuleEvaluationResultsAsync(ListAggregateConfigRuleEvaluationResultsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListAggregateConfigRuleEvaluationResultsWithOptionsAsync(request, runtime);
        }

        public ListAggregateRemediationsResponse ListAggregateRemediationsWithOptions(ListAggregateRemediationsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListAggregateRemediationsResponse>(DoRPCRequest("ListAggregateRemediations", "2020-09-07", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListAggregateRemediationsResponse> ListAggregateRemediationsWithOptionsAsync(ListAggregateRemediationsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListAggregateRemediationsResponse>(await DoRPCRequestAsync("ListAggregateRemediations", "2020-09-07", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListAggregateRemediationsResponse ListAggregateRemediations(ListAggregateRemediationsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListAggregateRemediationsWithOptions(request, runtime);
        }

        public async Task<ListAggregateRemediationsResponse> ListAggregateRemediationsAsync(ListAggregateRemediationsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListAggregateRemediationsWithOptionsAsync(request, runtime);
        }

        public GetAggregatorResponse GetAggregatorWithOptions(GetAggregatorRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<GetAggregatorResponse>(DoRPCRequest("GetAggregator", "2020-09-07", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<GetAggregatorResponse> GetAggregatorWithOptionsAsync(GetAggregatorRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<GetAggregatorResponse>(await DoRPCRequestAsync("GetAggregator", "2020-09-07", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public GetAggregatorResponse GetAggregator(GetAggregatorRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetAggregatorWithOptions(request, runtime);
        }

        public async Task<GetAggregatorResponse> GetAggregatorAsync(GetAggregatorRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetAggregatorWithOptionsAsync(request, runtime);
        }

        public GetResourceComplianceTimelineResponse GetResourceComplianceTimelineWithOptions(GetResourceComplianceTimelineRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<GetResourceComplianceTimelineResponse>(DoRPCRequest("GetResourceComplianceTimeline", "2020-09-07", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<GetResourceComplianceTimelineResponse> GetResourceComplianceTimelineWithOptionsAsync(GetResourceComplianceTimelineRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<GetResourceComplianceTimelineResponse>(await DoRPCRequestAsync("GetResourceComplianceTimeline", "2020-09-07", "HTTPS", "GET", "AK", "json", req, runtime));
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

        public GenerateAggregateConfigRulesReportResponse GenerateAggregateConfigRulesReportWithOptions(GenerateAggregateConfigRulesReportRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GenerateAggregateConfigRulesReportResponse>(DoRPCRequest("GenerateAggregateConfigRulesReport", "2020-09-07", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GenerateAggregateConfigRulesReportResponse> GenerateAggregateConfigRulesReportWithOptionsAsync(GenerateAggregateConfigRulesReportRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GenerateAggregateConfigRulesReportResponse>(await DoRPCRequestAsync("GenerateAggregateConfigRulesReport", "2020-09-07", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GenerateAggregateConfigRulesReportResponse GenerateAggregateConfigRulesReport(GenerateAggregateConfigRulesReportRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GenerateAggregateConfigRulesReportWithOptions(request, runtime);
        }

        public async Task<GenerateAggregateConfigRulesReportResponse> GenerateAggregateConfigRulesReportAsync(GenerateAggregateConfigRulesReportRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GenerateAggregateConfigRulesReportWithOptionsAsync(request, runtime);
        }

        public ListAggregateCompliancePacksResponse ListAggregateCompliancePacksWithOptions(ListAggregateCompliancePacksRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<ListAggregateCompliancePacksResponse>(DoRPCRequest("ListAggregateCompliancePacks", "2020-09-07", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<ListAggregateCompliancePacksResponse> ListAggregateCompliancePacksWithOptionsAsync(ListAggregateCompliancePacksRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<ListAggregateCompliancePacksResponse>(await DoRPCRequestAsync("ListAggregateCompliancePacks", "2020-09-07", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public ListAggregateCompliancePacksResponse ListAggregateCompliancePacks(ListAggregateCompliancePacksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListAggregateCompliancePacksWithOptions(request, runtime);
        }

        public async Task<ListAggregateCompliancePacksResponse> ListAggregateCompliancePacksAsync(ListAggregateCompliancePacksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListAggregateCompliancePacksWithOptionsAsync(request, runtime);
        }

        public ListConfigRuleEvaluationResultsResponse ListConfigRuleEvaluationResultsWithOptions(ListConfigRuleEvaluationResultsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<ListConfigRuleEvaluationResultsResponse>(DoRPCRequest("ListConfigRuleEvaluationResults", "2020-09-07", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<ListConfigRuleEvaluationResultsResponse> ListConfigRuleEvaluationResultsWithOptionsAsync(ListConfigRuleEvaluationResultsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<ListConfigRuleEvaluationResultsResponse>(await DoRPCRequestAsync("ListConfigRuleEvaluationResults", "2020-09-07", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public ListConfigRuleEvaluationResultsResponse ListConfigRuleEvaluationResults(ListConfigRuleEvaluationResultsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListConfigRuleEvaluationResultsWithOptions(request, runtime);
        }

        public async Task<ListConfigRuleEvaluationResultsResponse> ListConfigRuleEvaluationResultsAsync(ListConfigRuleEvaluationResultsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListConfigRuleEvaluationResultsWithOptionsAsync(request, runtime);
        }

        public DeleteCompliancePacksResponse DeleteCompliancePacksWithOptions(DeleteCompliancePacksRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteCompliancePacksResponse>(DoRPCRequest("DeleteCompliancePacks", "2020-09-07", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteCompliancePacksResponse> DeleteCompliancePacksWithOptionsAsync(DeleteCompliancePacksRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteCompliancePacksResponse>(await DoRPCRequestAsync("DeleteCompliancePacks", "2020-09-07", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteCompliancePacksResponse DeleteCompliancePacks(DeleteCompliancePacksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteCompliancePacksWithOptions(request, runtime);
        }

        public async Task<DeleteCompliancePacksResponse> DeleteCompliancePacksAsync(DeleteCompliancePacksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteCompliancePacksWithOptionsAsync(request, runtime);
        }

        public UpdateAggregateRemediationResponse UpdateAggregateRemediationWithOptions(UpdateAggregateRemediationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateAggregateRemediationResponse>(DoRPCRequest("UpdateAggregateRemediation", "2020-09-07", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpdateAggregateRemediationResponse> UpdateAggregateRemediationWithOptionsAsync(UpdateAggregateRemediationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateAggregateRemediationResponse>(await DoRPCRequestAsync("UpdateAggregateRemediation", "2020-09-07", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UpdateAggregateRemediationResponse UpdateAggregateRemediation(UpdateAggregateRemediationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateAggregateRemediationWithOptions(request, runtime);
        }

        public async Task<UpdateAggregateRemediationResponse> UpdateAggregateRemediationAsync(UpdateAggregateRemediationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateAggregateRemediationWithOptionsAsync(request, runtime);
        }

        public DeleteAggregateCompliancePacksResponse DeleteAggregateCompliancePacksWithOptions(DeleteAggregateCompliancePacksRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteAggregateCompliancePacksResponse>(DoRPCRequest("DeleteAggregateCompliancePacks", "2020-09-07", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteAggregateCompliancePacksResponse> DeleteAggregateCompliancePacksWithOptionsAsync(DeleteAggregateCompliancePacksRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteAggregateCompliancePacksResponse>(await DoRPCRequestAsync("DeleteAggregateCompliancePacks", "2020-09-07", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteAggregateCompliancePacksResponse DeleteAggregateCompliancePacks(DeleteAggregateCompliancePacksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteAggregateCompliancePacksWithOptions(request, runtime);
        }

        public async Task<DeleteAggregateCompliancePacksResponse> DeleteAggregateCompliancePacksAsync(DeleteAggregateCompliancePacksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteAggregateCompliancePacksWithOptionsAsync(request, runtime);
        }

        public ListAggregatorsResponse ListAggregatorsWithOptions(ListAggregatorsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<ListAggregatorsResponse>(DoRPCRequest("ListAggregators", "2020-09-07", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<ListAggregatorsResponse> ListAggregatorsWithOptionsAsync(ListAggregatorsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<ListAggregatorsResponse>(await DoRPCRequestAsync("ListAggregators", "2020-09-07", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public ListAggregatorsResponse ListAggregators(ListAggregatorsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListAggregatorsWithOptions(request, runtime);
        }

        public async Task<ListAggregatorsResponse> ListAggregatorsAsync(ListAggregatorsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListAggregatorsWithOptionsAsync(request, runtime);
        }

        public UpdateAggregateCompliancePackResponse UpdateAggregateCompliancePackWithOptions(UpdateAggregateCompliancePackRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateAggregateCompliancePackShrinkRequest request = new UpdateAggregateCompliancePackShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ConfigRules))
            {
                request.ConfigRulesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ConfigRules, "ConfigRules", "json");
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateAggregateCompliancePackResponse>(DoRPCRequest("UpdateAggregateCompliancePack", "2020-09-07", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpdateAggregateCompliancePackResponse> UpdateAggregateCompliancePackWithOptionsAsync(UpdateAggregateCompliancePackRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateAggregateCompliancePackShrinkRequest request = new UpdateAggregateCompliancePackShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ConfigRules))
            {
                request.ConfigRulesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ConfigRules, "ConfigRules", "json");
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateAggregateCompliancePackResponse>(await DoRPCRequestAsync("UpdateAggregateCompliancePack", "2020-09-07", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UpdateAggregateCompliancePackResponse UpdateAggregateCompliancePack(UpdateAggregateCompliancePackRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateAggregateCompliancePackWithOptions(request, runtime);
        }

        public async Task<UpdateAggregateCompliancePackResponse> UpdateAggregateCompliancePackAsync(UpdateAggregateCompliancePackRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateAggregateCompliancePackWithOptionsAsync(request, runtime);
        }

        public GetAggregateCompliancePackResponse GetAggregateCompliancePackWithOptions(GetAggregateCompliancePackRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<GetAggregateCompliancePackResponse>(DoRPCRequest("GetAggregateCompliancePack", "2020-09-07", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<GetAggregateCompliancePackResponse> GetAggregateCompliancePackWithOptionsAsync(GetAggregateCompliancePackRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<GetAggregateCompliancePackResponse>(await DoRPCRequestAsync("GetAggregateCompliancePack", "2020-09-07", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public GetAggregateCompliancePackResponse GetAggregateCompliancePack(GetAggregateCompliancePackRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetAggregateCompliancePackWithOptions(request, runtime);
        }

        public async Task<GetAggregateCompliancePackResponse> GetAggregateCompliancePackAsync(GetAggregateCompliancePackRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetAggregateCompliancePackWithOptionsAsync(request, runtime);
        }

        public DeleteAggregateRemediationsResponse DeleteAggregateRemediationsWithOptions(DeleteAggregateRemediationsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteAggregateRemediationsResponse>(DoRPCRequest("DeleteAggregateRemediations", "2020-09-07", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteAggregateRemediationsResponse> DeleteAggregateRemediationsWithOptionsAsync(DeleteAggregateRemediationsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteAggregateRemediationsResponse>(await DoRPCRequestAsync("DeleteAggregateRemediations", "2020-09-07", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteAggregateRemediationsResponse DeleteAggregateRemediations(DeleteAggregateRemediationsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteAggregateRemediationsWithOptions(request, runtime);
        }

        public async Task<DeleteAggregateRemediationsResponse> DeleteAggregateRemediationsAsync(DeleteAggregateRemediationsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteAggregateRemediationsWithOptionsAsync(request, runtime);
        }

        public GenerateConfigRulesReportResponse GenerateConfigRulesReportWithOptions(GenerateConfigRulesReportRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GenerateConfigRulesReportResponse>(DoRPCRequest("GenerateConfigRulesReport", "2020-09-07", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GenerateConfigRulesReportResponse> GenerateConfigRulesReportWithOptionsAsync(GenerateConfigRulesReportRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GenerateConfigRulesReportResponse>(await DoRPCRequestAsync("GenerateConfigRulesReport", "2020-09-07", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GenerateConfigRulesReportResponse GenerateConfigRulesReport(GenerateConfigRulesReportRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GenerateConfigRulesReportWithOptions(request, runtime);
        }

        public async Task<GenerateConfigRulesReportResponse> GenerateConfigRulesReportAsync(GenerateConfigRulesReportRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GenerateConfigRulesReportWithOptionsAsync(request, runtime);
        }

        public GetAggregateResourceComplianceByPackResponse GetAggregateResourceComplianceByPackWithOptions(GetAggregateResourceComplianceByPackRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<GetAggregateResourceComplianceByPackResponse>(DoRPCRequest("GetAggregateResourceComplianceByPack", "2020-09-07", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<GetAggregateResourceComplianceByPackResponse> GetAggregateResourceComplianceByPackWithOptionsAsync(GetAggregateResourceComplianceByPackRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<GetAggregateResourceComplianceByPackResponse>(await DoRPCRequestAsync("GetAggregateResourceComplianceByPack", "2020-09-07", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public GetAggregateResourceComplianceByPackResponse GetAggregateResourceComplianceByPack(GetAggregateResourceComplianceByPackRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetAggregateResourceComplianceByPackWithOptions(request, runtime);
        }

        public async Task<GetAggregateResourceComplianceByPackResponse> GetAggregateResourceComplianceByPackAsync(GetAggregateResourceComplianceByPackRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetAggregateResourceComplianceByPackWithOptionsAsync(request, runtime);
        }

        public DeleteRemediationsResponse DeleteRemediationsWithOptions(DeleteRemediationsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteRemediationsResponse>(DoRPCRequest("DeleteRemediations", "2020-09-07", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteRemediationsResponse> DeleteRemediationsWithOptionsAsync(DeleteRemediationsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteRemediationsResponse>(await DoRPCRequestAsync("DeleteRemediations", "2020-09-07", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteRemediationsResponse DeleteRemediations(DeleteRemediationsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteRemediationsWithOptions(request, runtime);
        }

        public async Task<DeleteRemediationsResponse> DeleteRemediationsAsync(DeleteRemediationsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteRemediationsWithOptionsAsync(request, runtime);
        }

        public ListCompliancePacksResponse ListCompliancePacksWithOptions(ListCompliancePacksRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<ListCompliancePacksResponse>(DoRPCRequest("ListCompliancePacks", "2020-09-07", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<ListCompliancePacksResponse> ListCompliancePacksWithOptionsAsync(ListCompliancePacksRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<ListCompliancePacksResponse>(await DoRPCRequestAsync("ListCompliancePacks", "2020-09-07", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public ListCompliancePacksResponse ListCompliancePacks(ListCompliancePacksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListCompliancePacksWithOptions(request, runtime);
        }

        public async Task<ListCompliancePacksResponse> ListCompliancePacksAsync(ListCompliancePacksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListCompliancePacksWithOptionsAsync(request, runtime);
        }

        public ActiveAggregateConfigRulesResponse ActiveAggregateConfigRulesWithOptions(ActiveAggregateConfigRulesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ActiveAggregateConfigRulesResponse>(DoRPCRequest("ActiveAggregateConfigRules", "2020-09-07", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ActiveAggregateConfigRulesResponse> ActiveAggregateConfigRulesWithOptionsAsync(ActiveAggregateConfigRulesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ActiveAggregateConfigRulesResponse>(await DoRPCRequestAsync("ActiveAggregateConfigRules", "2020-09-07", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ActiveAggregateConfigRulesResponse ActiveAggregateConfigRules(ActiveAggregateConfigRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ActiveAggregateConfigRulesWithOptions(request, runtime);
        }

        public async Task<ActiveAggregateConfigRulesResponse> ActiveAggregateConfigRulesAsync(ActiveAggregateConfigRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ActiveAggregateConfigRulesWithOptionsAsync(request, runtime);
        }

        public GetResourceComplianceByPackResponse GetResourceComplianceByPackWithOptions(GetResourceComplianceByPackRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<GetResourceComplianceByPackResponse>(DoRPCRequest("GetResourceComplianceByPack", "2020-09-07", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<GetResourceComplianceByPackResponse> GetResourceComplianceByPackWithOptionsAsync(GetResourceComplianceByPackRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<GetResourceComplianceByPackResponse>(await DoRPCRequestAsync("GetResourceComplianceByPack", "2020-09-07", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public GetResourceComplianceByPackResponse GetResourceComplianceByPack(GetResourceComplianceByPackRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetResourceComplianceByPackWithOptions(request, runtime);
        }

        public async Task<GetResourceComplianceByPackResponse> GetResourceComplianceByPackAsync(GetResourceComplianceByPackRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetResourceComplianceByPackWithOptionsAsync(request, runtime);
        }

        public ListResourceOwnerInAllAggregatorResponse ListResourceOwnerInAllAggregatorWithOptions(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            return TeaModel.ToObject<ListResourceOwnerInAllAggregatorResponse>(DoRPCRequest("ListResourceOwnerInAllAggregator", "2020-09-07", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<ListResourceOwnerInAllAggregatorResponse> ListResourceOwnerInAllAggregatorWithOptionsAsync(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            return TeaModel.ToObject<ListResourceOwnerInAllAggregatorResponse>(await DoRPCRequestAsync("ListResourceOwnerInAllAggregator", "2020-09-07", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public ListResourceOwnerInAllAggregatorResponse ListResourceOwnerInAllAggregator()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListResourceOwnerInAllAggregatorWithOptions(runtime);
        }

        public async Task<ListResourceOwnerInAllAggregatorResponse> ListResourceOwnerInAllAggregatorAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListResourceOwnerInAllAggregatorWithOptionsAsync(runtime);
        }

        public ListCompliancePackTemplatesResponse ListCompliancePackTemplatesWithOptions(ListCompliancePackTemplatesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<ListCompliancePackTemplatesResponse>(DoRPCRequest("ListCompliancePackTemplates", "2020-09-07", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<ListCompliancePackTemplatesResponse> ListCompliancePackTemplatesWithOptionsAsync(ListCompliancePackTemplatesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<ListCompliancePackTemplatesResponse>(await DoRPCRequestAsync("ListCompliancePackTemplates", "2020-09-07", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public ListCompliancePackTemplatesResponse ListCompliancePackTemplates(ListCompliancePackTemplatesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListCompliancePackTemplatesWithOptions(request, runtime);
        }

        public async Task<ListCompliancePackTemplatesResponse> ListCompliancePackTemplatesAsync(ListCompliancePackTemplatesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListCompliancePackTemplatesWithOptionsAsync(request, runtime);
        }

        public UpdateRemediationResponse UpdateRemediationWithOptions(UpdateRemediationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateRemediationResponse>(DoRPCRequest("UpdateRemediation", "2020-09-07", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpdateRemediationResponse> UpdateRemediationWithOptionsAsync(UpdateRemediationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateRemediationResponse>(await DoRPCRequestAsync("UpdateRemediation", "2020-09-07", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UpdateRemediationResponse UpdateRemediation(UpdateRemediationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateRemediationWithOptions(request, runtime);
        }

        public async Task<UpdateRemediationResponse> UpdateRemediationAsync(UpdateRemediationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateRemediationWithOptionsAsync(request, runtime);
        }

        public GetAggregateAccountComplianceByPackResponse GetAggregateAccountComplianceByPackWithOptions(GetAggregateAccountComplianceByPackRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<GetAggregateAccountComplianceByPackResponse>(DoRPCRequest("GetAggregateAccountComplianceByPack", "2020-09-07", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<GetAggregateAccountComplianceByPackResponse> GetAggregateAccountComplianceByPackWithOptionsAsync(GetAggregateAccountComplianceByPackRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<GetAggregateAccountComplianceByPackResponse>(await DoRPCRequestAsync("GetAggregateAccountComplianceByPack", "2020-09-07", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public GetAggregateAccountComplianceByPackResponse GetAggregateAccountComplianceByPack(GetAggregateAccountComplianceByPackRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetAggregateAccountComplianceByPackWithOptions(request, runtime);
        }

        public async Task<GetAggregateAccountComplianceByPackResponse> GetAggregateAccountComplianceByPackAsync(GetAggregateAccountComplianceByPackRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetAggregateAccountComplianceByPackWithOptionsAsync(request, runtime);
        }

        public CreateConfigRuleResponse CreateConfigRuleWithOptions(CreateConfigRuleRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateConfigRuleShrinkRequest request = new CreateConfigRuleShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.InputParameters))
            {
                request.InputParametersShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.InputParameters, "InputParameters", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ResourceTypesScope))
            {
                request.ResourceTypesScopeShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ResourceTypesScope, "ResourceTypesScope", "simple");
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateConfigRuleResponse>(DoRPCRequest("CreateConfigRule", "2020-09-07", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateConfigRuleResponse> CreateConfigRuleWithOptionsAsync(CreateConfigRuleRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateConfigRuleShrinkRequest request = new CreateConfigRuleShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.InputParameters))
            {
                request.InputParametersShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.InputParameters, "InputParameters", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ResourceTypesScope))
            {
                request.ResourceTypesScopeShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ResourceTypesScope, "ResourceTypesScope", "simple");
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateConfigRuleResponse>(await DoRPCRequestAsync("CreateConfigRule", "2020-09-07", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateConfigRuleResponse CreateConfigRule(CreateConfigRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateConfigRuleWithOptions(request, runtime);
        }

        public async Task<CreateConfigRuleResponse> CreateConfigRuleAsync(CreateConfigRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateConfigRuleWithOptionsAsync(request, runtime);
        }

        public GetAggregateResourceConfigurationTimelineResponse GetAggregateResourceConfigurationTimelineWithOptions(GetAggregateResourceConfigurationTimelineRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<GetAggregateResourceConfigurationTimelineResponse>(DoRPCRequest("GetAggregateResourceConfigurationTimeline", "2020-09-07", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<GetAggregateResourceConfigurationTimelineResponse> GetAggregateResourceConfigurationTimelineWithOptionsAsync(GetAggregateResourceConfigurationTimelineRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<GetAggregateResourceConfigurationTimelineResponse>(await DoRPCRequestAsync("GetAggregateResourceConfigurationTimeline", "2020-09-07", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public GetAggregateResourceConfigurationTimelineResponse GetAggregateResourceConfigurationTimeline(GetAggregateResourceConfigurationTimelineRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetAggregateResourceConfigurationTimelineWithOptions(request, runtime);
        }

        public async Task<GetAggregateResourceConfigurationTimelineResponse> GetAggregateResourceConfigurationTimelineAsync(GetAggregateResourceConfigurationTimelineRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetAggregateResourceConfigurationTimelineWithOptionsAsync(request, runtime);
        }

        public DeleteAggregatorsResponse DeleteAggregatorsWithOptions(DeleteAggregatorsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteAggregatorsResponse>(DoRPCRequest("DeleteAggregators", "2020-09-07", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteAggregatorsResponse> DeleteAggregatorsWithOptionsAsync(DeleteAggregatorsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteAggregatorsResponse>(await DoRPCRequestAsync("DeleteAggregators", "2020-09-07", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteAggregatorsResponse DeleteAggregators(DeleteAggregatorsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteAggregatorsWithOptions(request, runtime);
        }

        public async Task<DeleteAggregatorsResponse> DeleteAggregatorsAsync(DeleteAggregatorsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteAggregatorsWithOptionsAsync(request, runtime);
        }

        public GenerateResourceInventoryResponse GenerateResourceInventoryWithOptions(GenerateResourceInventoryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GenerateResourceInventoryResponse>(DoRPCRequest("GenerateResourceInventory", "2020-09-07", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GenerateResourceInventoryResponse> GenerateResourceInventoryWithOptionsAsync(GenerateResourceInventoryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GenerateResourceInventoryResponse>(await DoRPCRequestAsync("GenerateResourceInventory", "2020-09-07", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GenerateResourceInventoryResponse GenerateResourceInventory(GenerateResourceInventoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GenerateResourceInventoryWithOptions(request, runtime);
        }

        public async Task<GenerateResourceInventoryResponse> GenerateResourceInventoryAsync(GenerateResourceInventoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GenerateResourceInventoryWithOptionsAsync(request, runtime);
        }

        public CreateRemediationResponse CreateRemediationWithOptions(CreateRemediationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateRemediationResponse>(DoRPCRequest("CreateRemediation", "2020-09-07", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateRemediationResponse> CreateRemediationWithOptionsAsync(CreateRemediationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateRemediationResponse>(await DoRPCRequestAsync("CreateRemediation", "2020-09-07", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateRemediationResponse CreateRemediation(CreateRemediationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateRemediationWithOptions(request, runtime);
        }

        public async Task<CreateRemediationResponse> CreateRemediationAsync(CreateRemediationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateRemediationWithOptionsAsync(request, runtime);
        }

        public GetCompliancePackResponse GetCompliancePackWithOptions(GetCompliancePackRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<GetCompliancePackResponse>(DoRPCRequest("GetCompliancePack", "2020-09-07", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<GetCompliancePackResponse> GetCompliancePackWithOptionsAsync(GetCompliancePackRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<GetCompliancePackResponse>(await DoRPCRequestAsync("GetCompliancePack", "2020-09-07", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public GetCompliancePackResponse GetCompliancePack(GetCompliancePackRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetCompliancePackWithOptions(request, runtime);
        }

        public async Task<GetCompliancePackResponse> GetCompliancePackAsync(GetCompliancePackRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetCompliancePackWithOptionsAsync(request, runtime);
        }

        public GetConfigRulesReportResponse GetConfigRulesReportWithOptions(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            return TeaModel.ToObject<GetConfigRulesReportResponse>(DoRPCRequest("GetConfigRulesReport", "2020-09-07", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<GetConfigRulesReportResponse> GetConfigRulesReportWithOptionsAsync(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            return TeaModel.ToObject<GetConfigRulesReportResponse>(await DoRPCRequestAsync("GetConfigRulesReport", "2020-09-07", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public GetConfigRulesReportResponse GetConfigRulesReport()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetConfigRulesReportWithOptions(runtime);
        }

        public async Task<GetConfigRulesReportResponse> GetConfigRulesReportAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetConfigRulesReportWithOptionsAsync(runtime);
        }

        public GetResourceConfigurationTimelineResponse GetResourceConfigurationTimelineWithOptions(GetResourceConfigurationTimelineRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<GetResourceConfigurationTimelineResponse>(DoRPCRequest("GetResourceConfigurationTimeline", "2020-09-07", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<GetResourceConfigurationTimelineResponse> GetResourceConfigurationTimelineWithOptionsAsync(GetResourceConfigurationTimelineRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<GetResourceConfigurationTimelineResponse>(await DoRPCRequestAsync("GetResourceConfigurationTimeline", "2020-09-07", "HTTPS", "GET", "AK", "json", req, runtime));
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

        public GetDiscoveredResourceCountsGroupByResourceTypeResponse GetDiscoveredResourceCountsGroupByResourceTypeWithOptions(GetDiscoveredResourceCountsGroupByResourceTypeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<GetDiscoveredResourceCountsGroupByResourceTypeResponse>(DoRPCRequest("GetDiscoveredResourceCountsGroupByResourceType", "2020-09-07", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<GetDiscoveredResourceCountsGroupByResourceTypeResponse> GetDiscoveredResourceCountsGroupByResourceTypeWithOptionsAsync(GetDiscoveredResourceCountsGroupByResourceTypeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<GetDiscoveredResourceCountsGroupByResourceTypeResponse>(await DoRPCRequestAsync("GetDiscoveredResourceCountsGroupByResourceType", "2020-09-07", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public GetDiscoveredResourceCountsGroupByResourceTypeResponse GetDiscoveredResourceCountsGroupByResourceType(GetDiscoveredResourceCountsGroupByResourceTypeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetDiscoveredResourceCountsGroupByResourceTypeWithOptions(request, runtime);
        }

        public async Task<GetDiscoveredResourceCountsGroupByResourceTypeResponse> GetDiscoveredResourceCountsGroupByResourceTypeAsync(GetDiscoveredResourceCountsGroupByResourceTypeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetDiscoveredResourceCountsGroupByResourceTypeWithOptionsAsync(request, runtime);
        }

        public CreateAggregatorResponse CreateAggregatorWithOptions(CreateAggregatorRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateAggregatorShrinkRequest request = new CreateAggregatorShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.AggregatorAccounts))
            {
                request.AggregatorAccountsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.AggregatorAccounts, "AggregatorAccounts", "json");
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateAggregatorResponse>(DoRPCRequest("CreateAggregator", "2020-09-07", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateAggregatorResponse> CreateAggregatorWithOptionsAsync(CreateAggregatorRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateAggregatorShrinkRequest request = new CreateAggregatorShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.AggregatorAccounts))
            {
                request.AggregatorAccountsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.AggregatorAccounts, "AggregatorAccounts", "json");
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateAggregatorResponse>(await DoRPCRequestAsync("CreateAggregator", "2020-09-07", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateAggregatorResponse CreateAggregator(CreateAggregatorRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateAggregatorWithOptions(request, runtime);
        }

        public async Task<CreateAggregatorResponse> CreateAggregatorAsync(CreateAggregatorRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateAggregatorWithOptionsAsync(request, runtime);
        }

        public ListAggregateConfigRulesResponse ListAggregateConfigRulesWithOptions(ListAggregateConfigRulesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<ListAggregateConfigRulesResponse>(DoRPCRequest("ListAggregateConfigRules", "2020-09-07", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<ListAggregateConfigRulesResponse> ListAggregateConfigRulesWithOptionsAsync(ListAggregateConfigRulesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<ListAggregateConfigRulesResponse>(await DoRPCRequestAsync("ListAggregateConfigRules", "2020-09-07", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public ListAggregateConfigRulesResponse ListAggregateConfigRules(ListAggregateConfigRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListAggregateConfigRulesWithOptions(request, runtime);
        }

        public async Task<ListAggregateConfigRulesResponse> ListAggregateConfigRulesAsync(ListAggregateConfigRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListAggregateConfigRulesWithOptionsAsync(request, runtime);
        }

        public GenerateAggregateResourceInventoryResponse GenerateAggregateResourceInventoryWithOptions(GenerateAggregateResourceInventoryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GenerateAggregateResourceInventoryResponse>(DoRPCRequest("GenerateAggregateResourceInventory", "2020-09-07", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GenerateAggregateResourceInventoryResponse> GenerateAggregateResourceInventoryWithOptionsAsync(GenerateAggregateResourceInventoryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GenerateAggregateResourceInventoryResponse>(await DoRPCRequestAsync("GenerateAggregateResourceInventory", "2020-09-07", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GenerateAggregateResourceInventoryResponse GenerateAggregateResourceInventory(GenerateAggregateResourceInventoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GenerateAggregateResourceInventoryWithOptions(request, runtime);
        }

        public async Task<GenerateAggregateResourceInventoryResponse> GenerateAggregateResourceInventoryAsync(GenerateAggregateResourceInventoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GenerateAggregateResourceInventoryWithOptionsAsync(request, runtime);
        }

        public CreateAggregateConfigRuleResponse CreateAggregateConfigRuleWithOptions(CreateAggregateConfigRuleRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateAggregateConfigRuleShrinkRequest request = new CreateAggregateConfigRuleShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.InputParameters))
            {
                request.InputParametersShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.InputParameters, "InputParameters", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ResourceTypesScope))
            {
                request.ResourceTypesScopeShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ResourceTypesScope, "ResourceTypesScope", "simple");
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateAggregateConfigRuleResponse>(DoRPCRequest("CreateAggregateConfigRule", "2020-09-07", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateAggregateConfigRuleResponse> CreateAggregateConfigRuleWithOptionsAsync(CreateAggregateConfigRuleRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateAggregateConfigRuleShrinkRequest request = new CreateAggregateConfigRuleShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.InputParameters))
            {
                request.InputParametersShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.InputParameters, "InputParameters", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ResourceTypesScope))
            {
                request.ResourceTypesScopeShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ResourceTypesScope, "ResourceTypesScope", "simple");
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateAggregateConfigRuleResponse>(await DoRPCRequestAsync("CreateAggregateConfigRule", "2020-09-07", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateAggregateConfigRuleResponse CreateAggregateConfigRule(CreateAggregateConfigRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateAggregateConfigRuleWithOptions(request, runtime);
        }

        public async Task<CreateAggregateConfigRuleResponse> CreateAggregateConfigRuleAsync(CreateAggregateConfigRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateAggregateConfigRuleWithOptionsAsync(request, runtime);
        }

        public CreateAggregateRemediationResponse CreateAggregateRemediationWithOptions(CreateAggregateRemediationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateAggregateRemediationResponse>(DoRPCRequest("CreateAggregateRemediation", "2020-09-07", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateAggregateRemediationResponse> CreateAggregateRemediationWithOptionsAsync(CreateAggregateRemediationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateAggregateRemediationResponse>(await DoRPCRequestAsync("CreateAggregateRemediation", "2020-09-07", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateAggregateRemediationResponse CreateAggregateRemediation(CreateAggregateRemediationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateAggregateRemediationWithOptions(request, runtime);
        }

        public async Task<CreateAggregateRemediationResponse> CreateAggregateRemediationAsync(CreateAggregateRemediationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateAggregateRemediationWithOptionsAsync(request, runtime);
        }

        public StartAggregateConfigRuleEvaluationResponse StartAggregateConfigRuleEvaluationWithOptions(StartAggregateConfigRuleEvaluationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<StartAggregateConfigRuleEvaluationResponse>(DoRPCRequest("StartAggregateConfigRuleEvaluation", "2020-09-07", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<StartAggregateConfigRuleEvaluationResponse> StartAggregateConfigRuleEvaluationWithOptionsAsync(StartAggregateConfigRuleEvaluationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<StartAggregateConfigRuleEvaluationResponse>(await DoRPCRequestAsync("StartAggregateConfigRuleEvaluation", "2020-09-07", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public StartAggregateConfigRuleEvaluationResponse StartAggregateConfigRuleEvaluation(StartAggregateConfigRuleEvaluationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StartAggregateConfigRuleEvaluationWithOptions(request, runtime);
        }

        public async Task<StartAggregateConfigRuleEvaluationResponse> StartAggregateConfigRuleEvaluationAsync(StartAggregateConfigRuleEvaluationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StartAggregateConfigRuleEvaluationWithOptionsAsync(request, runtime);
        }

        public GenerateAggregateCompliancePackReportResponse GenerateAggregateCompliancePackReportWithOptions(GenerateAggregateCompliancePackReportRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GenerateAggregateCompliancePackReportResponse>(DoRPCRequest("GenerateAggregateCompliancePackReport", "2020-09-07", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GenerateAggregateCompliancePackReportResponse> GenerateAggregateCompliancePackReportWithOptionsAsync(GenerateAggregateCompliancePackReportRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GenerateAggregateCompliancePackReportResponse>(await DoRPCRequestAsync("GenerateAggregateCompliancePackReport", "2020-09-07", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GenerateAggregateCompliancePackReportResponse GenerateAggregateCompliancePackReport(GenerateAggregateCompliancePackReportRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GenerateAggregateCompliancePackReportWithOptions(request, runtime);
        }

        public async Task<GenerateAggregateCompliancePackReportResponse> GenerateAggregateCompliancePackReportAsync(GenerateAggregateCompliancePackReportRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GenerateAggregateCompliancePackReportWithOptionsAsync(request, runtime);
        }

        public GetCompliancePackReportResponse GetCompliancePackReportWithOptions(GetCompliancePackReportRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<GetCompliancePackReportResponse>(DoRPCRequest("GetCompliancePackReport", "2020-09-07", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<GetCompliancePackReportResponse> GetCompliancePackReportWithOptionsAsync(GetCompliancePackReportRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<GetCompliancePackReportResponse>(await DoRPCRequestAsync("GetCompliancePackReport", "2020-09-07", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public GetCompliancePackReportResponse GetCompliancePackReport(GetCompliancePackReportRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetCompliancePackReportWithOptions(request, runtime);
        }

        public async Task<GetCompliancePackReportResponse> GetCompliancePackReportAsync(GetCompliancePackReportRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetCompliancePackReportWithOptionsAsync(request, runtime);
        }

        public GetResourceComplianceByConfigRuleResponse GetResourceComplianceByConfigRuleWithOptions(GetResourceComplianceByConfigRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<GetResourceComplianceByConfigRuleResponse>(DoRPCRequest("GetResourceComplianceByConfigRule", "2020-09-07", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<GetResourceComplianceByConfigRuleResponse> GetResourceComplianceByConfigRuleWithOptionsAsync(GetResourceComplianceByConfigRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<GetResourceComplianceByConfigRuleResponse>(await DoRPCRequestAsync("GetResourceComplianceByConfigRule", "2020-09-07", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public GetResourceComplianceByConfigRuleResponse GetResourceComplianceByConfigRule(GetResourceComplianceByConfigRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetResourceComplianceByConfigRuleWithOptions(request, runtime);
        }

        public async Task<GetResourceComplianceByConfigRuleResponse> GetResourceComplianceByConfigRuleAsync(GetResourceComplianceByConfigRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetResourceComplianceByConfigRuleWithOptionsAsync(request, runtime);
        }

        public ListResourceEvaluationResultsResponse ListResourceEvaluationResultsWithOptions(ListResourceEvaluationResultsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<ListResourceEvaluationResultsResponse>(DoRPCRequest("ListResourceEvaluationResults", "2020-09-07", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<ListResourceEvaluationResultsResponse> ListResourceEvaluationResultsWithOptionsAsync(ListResourceEvaluationResultsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<ListResourceEvaluationResultsResponse>(await DoRPCRequestAsync("ListResourceEvaluationResults", "2020-09-07", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public ListResourceEvaluationResultsResponse ListResourceEvaluationResults(ListResourceEvaluationResultsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListResourceEvaluationResultsWithOptions(request, runtime);
        }

        public async Task<ListResourceEvaluationResultsResponse> ListResourceEvaluationResultsAsync(ListResourceEvaluationResultsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListResourceEvaluationResultsWithOptionsAsync(request, runtime);
        }

        public UpdateCompliancePackResponse UpdateCompliancePackWithOptions(UpdateCompliancePackRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateCompliancePackShrinkRequest request = new UpdateCompliancePackShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ConfigRules))
            {
                request.ConfigRulesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ConfigRules, "ConfigRules", "json");
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateCompliancePackResponse>(DoRPCRequest("UpdateCompliancePack", "2020-09-07", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpdateCompliancePackResponse> UpdateCompliancePackWithOptionsAsync(UpdateCompliancePackRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateCompliancePackShrinkRequest request = new UpdateCompliancePackShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ConfigRules))
            {
                request.ConfigRulesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ConfigRules, "ConfigRules", "json");
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateCompliancePackResponse>(await DoRPCRequestAsync("UpdateCompliancePack", "2020-09-07", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UpdateCompliancePackResponse UpdateCompliancePack(UpdateCompliancePackRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateCompliancePackWithOptions(request, runtime);
        }

        public async Task<UpdateCompliancePackResponse> UpdateCompliancePackAsync(UpdateCompliancePackRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateCompliancePackWithOptionsAsync(request, runtime);
        }

        public ListAggregateResourceEvaluationResultsResponse ListAggregateResourceEvaluationResultsWithOptions(ListAggregateResourceEvaluationResultsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<ListAggregateResourceEvaluationResultsResponse>(DoRPCRequest("ListAggregateResourceEvaluationResults", "2020-09-07", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<ListAggregateResourceEvaluationResultsResponse> ListAggregateResourceEvaluationResultsWithOptionsAsync(ListAggregateResourceEvaluationResultsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<ListAggregateResourceEvaluationResultsResponse>(await DoRPCRequestAsync("ListAggregateResourceEvaluationResults", "2020-09-07", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public ListAggregateResourceEvaluationResultsResponse ListAggregateResourceEvaluationResults(ListAggregateResourceEvaluationResultsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListAggregateResourceEvaluationResultsWithOptions(request, runtime);
        }

        public async Task<ListAggregateResourceEvaluationResultsResponse> ListAggregateResourceEvaluationResultsAsync(ListAggregateResourceEvaluationResultsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListAggregateResourceEvaluationResultsWithOptionsAsync(request, runtime);
        }

        public GetConfigRuleResponse GetConfigRuleWithOptions(GetConfigRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetConfigRuleResponse>(DoRPCRequest("GetConfigRule", "2020-09-07", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetConfigRuleResponse> GetConfigRuleWithOptionsAsync(GetConfigRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetConfigRuleResponse>(await DoRPCRequestAsync("GetConfigRule", "2020-09-07", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetConfigRuleResponse GetConfigRule(GetConfigRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetConfigRuleWithOptions(request, runtime);
        }

        public async Task<GetConfigRuleResponse> GetConfigRuleAsync(GetConfigRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetConfigRuleWithOptionsAsync(request, runtime);
        }

        public DeactiveConfigRulesResponse DeactiveConfigRulesWithOptions(DeactiveConfigRulesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeactiveConfigRulesResponse>(DoRPCRequest("DeactiveConfigRules", "2020-09-07", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeactiveConfigRulesResponse> DeactiveConfigRulesWithOptionsAsync(DeactiveConfigRulesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeactiveConfigRulesResponse>(await DoRPCRequestAsync("DeactiveConfigRules", "2020-09-07", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeactiveConfigRulesResponse DeactiveConfigRules(DeactiveConfigRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeactiveConfigRulesWithOptions(request, runtime);
        }

        public async Task<DeactiveConfigRulesResponse> DeactiveConfigRulesAsync(DeactiveConfigRulesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeactiveConfigRulesWithOptionsAsync(request, runtime);
        }

        public CreateCompliancePackResponse CreateCompliancePackWithOptions(CreateCompliancePackRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateCompliancePackShrinkRequest request = new CreateCompliancePackShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ConfigRules))
            {
                request.ConfigRulesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ConfigRules, "ConfigRules", "json");
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateCompliancePackResponse>(DoRPCRequest("CreateCompliancePack", "2020-09-07", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateCompliancePackResponse> CreateCompliancePackWithOptionsAsync(CreateCompliancePackRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateCompliancePackShrinkRequest request = new CreateCompliancePackShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ConfigRules))
            {
                request.ConfigRulesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ConfigRules, "ConfigRules", "json");
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateCompliancePackResponse>(await DoRPCRequestAsync("CreateCompliancePack", "2020-09-07", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateCompliancePackResponse CreateCompliancePack(CreateCompliancePackRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateCompliancePackWithOptions(request, runtime);
        }

        public async Task<CreateCompliancePackResponse> CreateCompliancePackAsync(CreateCompliancePackRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateCompliancePackWithOptionsAsync(request, runtime);
        }

        public GetDiscoveredResourceCountsGroupByRegionResponse GetDiscoveredResourceCountsGroupByRegionWithOptions(GetDiscoveredResourceCountsGroupByRegionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<GetDiscoveredResourceCountsGroupByRegionResponse>(DoRPCRequest("GetDiscoveredResourceCountsGroupByRegion", "2020-09-07", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<GetDiscoveredResourceCountsGroupByRegionResponse> GetDiscoveredResourceCountsGroupByRegionWithOptionsAsync(GetDiscoveredResourceCountsGroupByRegionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<GetDiscoveredResourceCountsGroupByRegionResponse>(await DoRPCRequestAsync("GetDiscoveredResourceCountsGroupByRegion", "2020-09-07", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public GetDiscoveredResourceCountsGroupByRegionResponse GetDiscoveredResourceCountsGroupByRegion(GetDiscoveredResourceCountsGroupByRegionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetDiscoveredResourceCountsGroupByRegionWithOptions(request, runtime);
        }

        public async Task<GetDiscoveredResourceCountsGroupByRegionResponse> GetDiscoveredResourceCountsGroupByRegionAsync(GetDiscoveredResourceCountsGroupByRegionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetDiscoveredResourceCountsGroupByRegionWithOptionsAsync(request, runtime);
        }

        public GetAggregateConfigRuleComplianceByPackResponse GetAggregateConfigRuleComplianceByPackWithOptions(GetAggregateConfigRuleComplianceByPackRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<GetAggregateConfigRuleComplianceByPackResponse>(DoRPCRequest("GetAggregateConfigRuleComplianceByPack", "2020-09-07", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<GetAggregateConfigRuleComplianceByPackResponse> GetAggregateConfigRuleComplianceByPackWithOptionsAsync(GetAggregateConfigRuleComplianceByPackRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<GetAggregateConfigRuleComplianceByPackResponse>(await DoRPCRequestAsync("GetAggregateConfigRuleComplianceByPack", "2020-09-07", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public GetAggregateConfigRuleComplianceByPackResponse GetAggregateConfigRuleComplianceByPack(GetAggregateConfigRuleComplianceByPackRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetAggregateConfigRuleComplianceByPackWithOptions(request, runtime);
        }

        public async Task<GetAggregateConfigRuleComplianceByPackResponse> GetAggregateConfigRuleComplianceByPackAsync(GetAggregateConfigRuleComplianceByPackRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetAggregateConfigRuleComplianceByPackWithOptionsAsync(request, runtime);
        }

        public GetAggregateResourceComplianceByConfigRuleResponse GetAggregateResourceComplianceByConfigRuleWithOptions(GetAggregateResourceComplianceByConfigRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<GetAggregateResourceComplianceByConfigRuleResponse>(DoRPCRequest("GetAggregateResourceComplianceByConfigRule", "2020-09-07", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<GetAggregateResourceComplianceByConfigRuleResponse> GetAggregateResourceComplianceByConfigRuleWithOptionsAsync(GetAggregateResourceComplianceByConfigRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<GetAggregateResourceComplianceByConfigRuleResponse>(await DoRPCRequestAsync("GetAggregateResourceComplianceByConfigRule", "2020-09-07", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public GetAggregateResourceComplianceByConfigRuleResponse GetAggregateResourceComplianceByConfigRule(GetAggregateResourceComplianceByConfigRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetAggregateResourceComplianceByConfigRuleWithOptions(request, runtime);
        }

        public async Task<GetAggregateResourceComplianceByConfigRuleResponse> GetAggregateResourceComplianceByConfigRuleAsync(GetAggregateResourceComplianceByConfigRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetAggregateResourceComplianceByConfigRuleWithOptionsAsync(request, runtime);
        }

        public GetAggregateConfigRuleSummaryByRiskLevelResponse GetAggregateConfigRuleSummaryByRiskLevelWithOptions(GetAggregateConfigRuleSummaryByRiskLevelRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<GetAggregateConfigRuleSummaryByRiskLevelResponse>(DoRPCRequest("GetAggregateConfigRuleSummaryByRiskLevel", "2020-09-07", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<GetAggregateConfigRuleSummaryByRiskLevelResponse> GetAggregateConfigRuleSummaryByRiskLevelWithOptionsAsync(GetAggregateConfigRuleSummaryByRiskLevelRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<GetAggregateConfigRuleSummaryByRiskLevelResponse>(await DoRPCRequestAsync("GetAggregateConfigRuleSummaryByRiskLevel", "2020-09-07", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public GetAggregateConfigRuleSummaryByRiskLevelResponse GetAggregateConfigRuleSummaryByRiskLevel(GetAggregateConfigRuleSummaryByRiskLevelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetAggregateConfigRuleSummaryByRiskLevelWithOptions(request, runtime);
        }

        public async Task<GetAggregateConfigRuleSummaryByRiskLevelResponse> GetAggregateConfigRuleSummaryByRiskLevelAsync(GetAggregateConfigRuleSummaryByRiskLevelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetAggregateConfigRuleSummaryByRiskLevelWithOptionsAsync(request, runtime);
        }

        public UpdateConfigRuleResponse UpdateConfigRuleWithOptions(UpdateConfigRuleRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateConfigRuleShrinkRequest request = new UpdateConfigRuleShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.InputParameters))
            {
                request.InputParametersShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.InputParameters, "InputParameters", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ResourceTypesScope))
            {
                request.ResourceTypesScopeShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ResourceTypesScope, "ResourceTypesScope", "simple");
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateConfigRuleResponse>(DoRPCRequest("UpdateConfigRule", "2020-09-07", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpdateConfigRuleResponse> UpdateConfigRuleWithOptionsAsync(UpdateConfigRuleRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateConfigRuleShrinkRequest request = new UpdateConfigRuleShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.InputParameters))
            {
                request.InputParametersShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.InputParameters, "InputParameters", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ResourceTypesScope))
            {
                request.ResourceTypesScopeShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ResourceTypesScope, "ResourceTypesScope", "simple");
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateConfigRuleResponse>(await DoRPCRequestAsync("UpdateConfigRule", "2020-09-07", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UpdateConfigRuleResponse UpdateConfigRule(UpdateConfigRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateConfigRuleWithOptions(request, runtime);
        }

        public async Task<UpdateConfigRuleResponse> UpdateConfigRuleAsync(UpdateConfigRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateConfigRuleWithOptionsAsync(request, runtime);
        }

        public GetAggregateResourceInventoryResponse GetAggregateResourceInventoryWithOptions(GetAggregateResourceInventoryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetAggregateResourceInventoryResponse>(DoRPCRequest("GetAggregateResourceInventory", "2020-09-07", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetAggregateResourceInventoryResponse> GetAggregateResourceInventoryWithOptionsAsync(GetAggregateResourceInventoryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetAggregateResourceInventoryResponse>(await DoRPCRequestAsync("GetAggregateResourceInventory", "2020-09-07", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetAggregateResourceInventoryResponse GetAggregateResourceInventory(GetAggregateResourceInventoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetAggregateResourceInventoryWithOptions(request, runtime);
        }

        public async Task<GetAggregateResourceInventoryResponse> GetAggregateResourceInventoryAsync(GetAggregateResourceInventoryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetAggregateResourceInventoryWithOptionsAsync(request, runtime);
        }

        public GetAggregateResourceComplianceTimelineResponse GetAggregateResourceComplianceTimelineWithOptions(GetAggregateResourceComplianceTimelineRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<GetAggregateResourceComplianceTimelineResponse>(DoRPCRequest("GetAggregateResourceComplianceTimeline", "2020-09-07", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<GetAggregateResourceComplianceTimelineResponse> GetAggregateResourceComplianceTimelineWithOptionsAsync(GetAggregateResourceComplianceTimelineRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<GetAggregateResourceComplianceTimelineResponse>(await DoRPCRequestAsync("GetAggregateResourceComplianceTimeline", "2020-09-07", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public GetAggregateResourceComplianceTimelineResponse GetAggregateResourceComplianceTimeline(GetAggregateResourceComplianceTimelineRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetAggregateResourceComplianceTimelineWithOptions(request, runtime);
        }

        public async Task<GetAggregateResourceComplianceTimelineResponse> GetAggregateResourceComplianceTimelineAsync(GetAggregateResourceComplianceTimelineRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetAggregateResourceComplianceTimelineWithOptionsAsync(request, runtime);
        }

        public UpdateAggregateConfigRuleResponse UpdateAggregateConfigRuleWithOptions(UpdateAggregateConfigRuleRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateAggregateConfigRuleShrinkRequest request = new UpdateAggregateConfigRuleShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.InputParameters))
            {
                request.InputParametersShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.InputParameters, "InputParameters", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ResourceTypesScope))
            {
                request.ResourceTypesScopeShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ResourceTypesScope, "ResourceTypesScope", "simple");
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateAggregateConfigRuleResponse>(DoRPCRequest("UpdateAggregateConfigRule", "2020-09-07", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpdateAggregateConfigRuleResponse> UpdateAggregateConfigRuleWithOptionsAsync(UpdateAggregateConfigRuleRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateAggregateConfigRuleShrinkRequest request = new UpdateAggregateConfigRuleShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.InputParameters))
            {
                request.InputParametersShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.InputParameters, "InputParameters", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ResourceTypesScope))
            {
                request.ResourceTypesScopeShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ResourceTypesScope, "ResourceTypesScope", "simple");
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateAggregateConfigRuleResponse>(await DoRPCRequestAsync("UpdateAggregateConfigRule", "2020-09-07", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UpdateAggregateConfigRuleResponse UpdateAggregateConfigRule(UpdateAggregateConfigRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateAggregateConfigRuleWithOptions(request, runtime);
        }

        public async Task<UpdateAggregateConfigRuleResponse> UpdateAggregateConfigRuleAsync(UpdateAggregateConfigRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateAggregateConfigRuleWithOptionsAsync(request, runtime);
        }

        public GetAggregateCompliancePackReportResponse GetAggregateCompliancePackReportWithOptions(GetAggregateCompliancePackReportRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<GetAggregateCompliancePackReportResponse>(DoRPCRequest("GetAggregateCompliancePackReport", "2020-09-07", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<GetAggregateCompliancePackReportResponse> GetAggregateCompliancePackReportWithOptionsAsync(GetAggregateCompliancePackReportRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<GetAggregateCompliancePackReportResponse>(await DoRPCRequestAsync("GetAggregateCompliancePackReport", "2020-09-07", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public GetAggregateCompliancePackReportResponse GetAggregateCompliancePackReport(GetAggregateCompliancePackReportRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetAggregateCompliancePackReportWithOptions(request, runtime);
        }

        public async Task<GetAggregateCompliancePackReportResponse> GetAggregateCompliancePackReportAsync(GetAggregateCompliancePackReportRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetAggregateCompliancePackReportWithOptionsAsync(request, runtime);
        }

        public CreateAggregateCompliancePackResponse CreateAggregateCompliancePackWithOptions(CreateAggregateCompliancePackRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateAggregateCompliancePackShrinkRequest request = new CreateAggregateCompliancePackShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ConfigRules))
            {
                request.ConfigRulesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ConfigRules, "ConfigRules", "json");
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateAggregateCompliancePackResponse>(DoRPCRequest("CreateAggregateCompliancePack", "2020-09-07", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateAggregateCompliancePackResponse> CreateAggregateCompliancePackWithOptionsAsync(CreateAggregateCompliancePackRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateAggregateCompliancePackShrinkRequest request = new CreateAggregateCompliancePackShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.ConfigRules))
            {
                request.ConfigRulesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.ConfigRules, "ConfigRules", "json");
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateAggregateCompliancePackResponse>(await DoRPCRequestAsync("CreateAggregateCompliancePack", "2020-09-07", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateAggregateCompliancePackResponse CreateAggregateCompliancePack(CreateAggregateCompliancePackRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateAggregateCompliancePackWithOptions(request, runtime);
        }

        public async Task<CreateAggregateCompliancePackResponse> CreateAggregateCompliancePackAsync(CreateAggregateCompliancePackRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateAggregateCompliancePackWithOptionsAsync(request, runtime);
        }

        public GetAggregateResourceCountsGroupByResourceTypeResponse GetAggregateResourceCountsGroupByResourceTypeWithOptions(GetAggregateResourceCountsGroupByResourceTypeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<GetAggregateResourceCountsGroupByResourceTypeResponse>(DoRPCRequest("GetAggregateResourceCountsGroupByResourceType", "2020-09-07", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<GetAggregateResourceCountsGroupByResourceTypeResponse> GetAggregateResourceCountsGroupByResourceTypeWithOptionsAsync(GetAggregateResourceCountsGroupByResourceTypeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<GetAggregateResourceCountsGroupByResourceTypeResponse>(await DoRPCRequestAsync("GetAggregateResourceCountsGroupByResourceType", "2020-09-07", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public GetAggregateResourceCountsGroupByResourceTypeResponse GetAggregateResourceCountsGroupByResourceType(GetAggregateResourceCountsGroupByResourceTypeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetAggregateResourceCountsGroupByResourceTypeWithOptions(request, runtime);
        }

        public async Task<GetAggregateResourceCountsGroupByResourceTypeResponse> GetAggregateResourceCountsGroupByResourceTypeAsync(GetAggregateResourceCountsGroupByResourceTypeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetAggregateResourceCountsGroupByResourceTypeWithOptionsAsync(request, runtime);
        }

        public GetAggregateConfigRuleResponse GetAggregateConfigRuleWithOptions(GetAggregateConfigRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetAggregateConfigRuleResponse>(DoRPCRequest("GetAggregateConfigRule", "2020-09-07", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetAggregateConfigRuleResponse> GetAggregateConfigRuleWithOptionsAsync(GetAggregateConfigRuleRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetAggregateConfigRuleResponse>(await DoRPCRequestAsync("GetAggregateConfigRule", "2020-09-07", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetAggregateConfigRuleResponse GetAggregateConfigRule(GetAggregateConfigRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetAggregateConfigRuleWithOptions(request, runtime);
        }

        public async Task<GetAggregateConfigRuleResponse> GetAggregateConfigRuleAsync(GetAggregateConfigRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetAggregateConfigRuleWithOptionsAsync(request, runtime);
        }

        public GetAggregateResourceCountsGroupByRegionResponse GetAggregateResourceCountsGroupByRegionWithOptions(GetAggregateResourceCountsGroupByRegionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<GetAggregateResourceCountsGroupByRegionResponse>(DoRPCRequest("GetAggregateResourceCountsGroupByRegion", "2020-09-07", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<GetAggregateResourceCountsGroupByRegionResponse> GetAggregateResourceCountsGroupByRegionWithOptionsAsync(GetAggregateResourceCountsGroupByRegionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<GetAggregateResourceCountsGroupByRegionResponse>(await DoRPCRequestAsync("GetAggregateResourceCountsGroupByRegion", "2020-09-07", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public GetAggregateResourceCountsGroupByRegionResponse GetAggregateResourceCountsGroupByRegion(GetAggregateResourceCountsGroupByRegionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetAggregateResourceCountsGroupByRegionWithOptions(request, runtime);
        }

        public async Task<GetAggregateResourceCountsGroupByRegionResponse> GetAggregateResourceCountsGroupByRegionAsync(GetAggregateResourceCountsGroupByRegionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetAggregateResourceCountsGroupByRegionWithOptionsAsync(request, runtime);
        }

        public GetConfigRuleComplianceByPackResponse GetConfigRuleComplianceByPackWithOptions(GetConfigRuleComplianceByPackRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<GetConfigRuleComplianceByPackResponse>(DoRPCRequest("GetConfigRuleComplianceByPack", "2020-09-07", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<GetConfigRuleComplianceByPackResponse> GetConfigRuleComplianceByPackWithOptionsAsync(GetConfigRuleComplianceByPackRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<GetConfigRuleComplianceByPackResponse>(await DoRPCRequestAsync("GetConfigRuleComplianceByPack", "2020-09-07", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public GetConfigRuleComplianceByPackResponse GetConfigRuleComplianceByPack(GetConfigRuleComplianceByPackRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetConfigRuleComplianceByPackWithOptions(request, runtime);
        }

        public async Task<GetConfigRuleComplianceByPackResponse> GetConfigRuleComplianceByPackAsync(GetConfigRuleComplianceByPackRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetConfigRuleComplianceByPackWithOptionsAsync(request, runtime);
        }

        public GetConfigRuleSummaryByRiskLevelResponse GetConfigRuleSummaryByRiskLevelWithOptions(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            return TeaModel.ToObject<GetConfigRuleSummaryByRiskLevelResponse>(DoRPCRequest("GetConfigRuleSummaryByRiskLevel", "2020-09-07", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<GetConfigRuleSummaryByRiskLevelResponse> GetConfigRuleSummaryByRiskLevelWithOptionsAsync(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            return TeaModel.ToObject<GetConfigRuleSummaryByRiskLevelResponse>(await DoRPCRequestAsync("GetConfigRuleSummaryByRiskLevel", "2020-09-07", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public GetConfigRuleSummaryByRiskLevelResponse GetConfigRuleSummaryByRiskLevel()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetConfigRuleSummaryByRiskLevelWithOptions(runtime);
        }

        public async Task<GetConfigRuleSummaryByRiskLevelResponse> GetConfigRuleSummaryByRiskLevelAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetConfigRuleSummaryByRiskLevelWithOptionsAsync(runtime);
        }

        public StartRemediationResponse StartRemediationWithOptions(StartRemediationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<StartRemediationResponse>(DoRPCRequest("StartRemediation", "2020-09-07", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<StartRemediationResponse> StartRemediationWithOptionsAsync(StartRemediationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<StartRemediationResponse>(await DoRPCRequestAsync("StartRemediation", "2020-09-07", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public StartRemediationResponse StartRemediation(StartRemediationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StartRemediationWithOptions(request, runtime);
        }

        public async Task<StartRemediationResponse> StartRemediationAsync(StartRemediationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StartRemediationWithOptionsAsync(request, runtime);
        }

        public GenerateCompliancePackReportResponse GenerateCompliancePackReportWithOptions(GenerateCompliancePackReportRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GenerateCompliancePackReportResponse>(DoRPCRequest("GenerateCompliancePackReport", "2020-09-07", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GenerateCompliancePackReportResponse> GenerateCompliancePackReportWithOptionsAsync(GenerateCompliancePackReportRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GenerateCompliancePackReportResponse>(await DoRPCRequestAsync("GenerateCompliancePackReport", "2020-09-07", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GenerateCompliancePackReportResponse GenerateCompliancePackReport(GenerateCompliancePackReportRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GenerateCompliancePackReportWithOptions(request, runtime);
        }

        public async Task<GenerateCompliancePackReportResponse> GenerateCompliancePackReportAsync(GenerateCompliancePackReportRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GenerateCompliancePackReportWithOptionsAsync(request, runtime);
        }

        public StartAggregateRemediationResponse StartAggregateRemediationWithOptions(StartAggregateRemediationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<StartAggregateRemediationResponse>(DoRPCRequest("StartAggregateRemediation", "2020-09-07", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<StartAggregateRemediationResponse> StartAggregateRemediationWithOptionsAsync(StartAggregateRemediationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<StartAggregateRemediationResponse>(await DoRPCRequestAsync("StartAggregateRemediation", "2020-09-07", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public StartAggregateRemediationResponse StartAggregateRemediation(StartAggregateRemediationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StartAggregateRemediationWithOptions(request, runtime);
        }

        public async Task<StartAggregateRemediationResponse> StartAggregateRemediationAsync(StartAggregateRemediationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StartAggregateRemediationWithOptionsAsync(request, runtime);
        }

        public ListRemediationsResponse ListRemediationsWithOptions(ListRemediationsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListRemediationsResponse>(DoRPCRequest("ListRemediations", "2020-09-07", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListRemediationsResponse> ListRemediationsWithOptionsAsync(ListRemediationsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListRemediationsResponse>(await DoRPCRequestAsync("ListRemediations", "2020-09-07", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListRemediationsResponse ListRemediations(ListRemediationsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListRemediationsWithOptions(request, runtime);
        }

        public async Task<ListRemediationsResponse> ListRemediationsAsync(ListRemediationsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListRemediationsWithOptionsAsync(request, runtime);
        }

        public UpdateAggregatorResponse UpdateAggregatorWithOptions(UpdateAggregatorRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateAggregatorShrinkRequest request = new UpdateAggregatorShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.AggregatorAccounts))
            {
                request.AggregatorAccountsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.AggregatorAccounts, "AggregatorAccounts", "json");
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateAggregatorResponse>(DoRPCRequest("UpdateAggregator", "2020-09-07", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpdateAggregatorResponse> UpdateAggregatorWithOptionsAsync(UpdateAggregatorRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            UpdateAggregatorShrinkRequest request = new UpdateAggregatorShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.AggregatorAccounts))
            {
                request.AggregatorAccountsShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.AggregatorAccounts, "AggregatorAccounts", "json");
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateAggregatorResponse>(await DoRPCRequestAsync("UpdateAggregator", "2020-09-07", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UpdateAggregatorResponse UpdateAggregator(UpdateAggregatorRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateAggregatorWithOptions(request, runtime);
        }

        public async Task<UpdateAggregatorResponse> UpdateAggregatorAsync(UpdateAggregatorRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateAggregatorWithOptionsAsync(request, runtime);
        }

    }
}
