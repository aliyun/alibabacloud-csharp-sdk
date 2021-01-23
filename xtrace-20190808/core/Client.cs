// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Xtrace20190808.Models;

namespace AlibabaCloud.SDK.Xtrace20190808
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "regional";
            CheckConfig(config);
            this._endpoint = GetEndpoint("xtrace", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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

        public GetTagKeyResponse GetTagKeyWithOptions(GetTagKeyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetTagKeyResponse>(DoRPCRequest("GetTagKey", "2019-08-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetTagKeyResponse> GetTagKeyWithOptionsAsync(GetTagKeyRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetTagKeyResponse>(await DoRPCRequestAsync("GetTagKey", "2019-08-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetTagKeyResponse GetTagKey(GetTagKeyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetTagKeyWithOptions(request, runtime);
        }

        public async Task<GetTagKeyResponse> GetTagKeyAsync(GetTagKeyRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetTagKeyWithOptionsAsync(request, runtime);
        }

        public GetTagValResponse GetTagValWithOptions(GetTagValRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetTagValResponse>(DoRPCRequest("GetTagVal", "2019-08-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetTagValResponse> GetTagValWithOptionsAsync(GetTagValRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetTagValResponse>(await DoRPCRequestAsync("GetTagVal", "2019-08-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetTagValResponse GetTagVal(GetTagValRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetTagValWithOptions(request, runtime);
        }

        public async Task<GetTagValResponse> GetTagValAsync(GetTagValRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetTagValWithOptionsAsync(request, runtime);
        }

        public GetTokenResponse GetTokenWithOptions(GetTokenRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetTokenResponse>(DoRPCRequest("GetToken", "2019-08-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetTokenResponse> GetTokenWithOptionsAsync(GetTokenRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetTokenResponse>(await DoRPCRequestAsync("GetToken", "2019-08-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetTokenResponse GetToken(GetTokenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetTokenWithOptions(request, runtime);
        }

        public async Task<GetTokenResponse> GetTokenAsync(GetTokenRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetTokenWithOptionsAsync(request, runtime);
        }

        public GetTraceResponse GetTraceWithOptions(GetTraceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetTraceResponse>(DoRPCRequest("GetTrace", "2019-08-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetTraceResponse> GetTraceWithOptionsAsync(GetTraceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetTraceResponse>(await DoRPCRequestAsync("GetTrace", "2019-08-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetTraceResponse GetTrace(GetTraceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetTraceWithOptions(request, runtime);
        }

        public async Task<GetTraceResponse> GetTraceAsync(GetTraceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetTraceWithOptionsAsync(request, runtime);
        }

        public GetTraceAnalysisResponse GetTraceAnalysisWithOptions(GetTraceAnalysisRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetTraceAnalysisResponse>(DoRPCRequest("GetTraceAnalysis", "2019-08-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetTraceAnalysisResponse> GetTraceAnalysisWithOptionsAsync(GetTraceAnalysisRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetTraceAnalysisResponse>(await DoRPCRequestAsync("GetTraceAnalysis", "2019-08-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetTraceAnalysisResponse GetTraceAnalysis(GetTraceAnalysisRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetTraceAnalysisWithOptions(request, runtime);
        }

        public async Task<GetTraceAnalysisResponse> GetTraceAnalysisAsync(GetTraceAnalysisRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetTraceAnalysisWithOptionsAsync(request, runtime);
        }

        public ListIpOrHostsResponse ListIpOrHostsWithOptions(ListIpOrHostsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListIpOrHostsResponse>(DoRPCRequest("ListIpOrHosts", "2019-08-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListIpOrHostsResponse> ListIpOrHostsWithOptionsAsync(ListIpOrHostsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListIpOrHostsResponse>(await DoRPCRequestAsync("ListIpOrHosts", "2019-08-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListIpOrHostsResponse ListIpOrHosts(ListIpOrHostsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListIpOrHostsWithOptions(request, runtime);
        }

        public async Task<ListIpOrHostsResponse> ListIpOrHostsAsync(ListIpOrHostsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListIpOrHostsWithOptionsAsync(request, runtime);
        }

        public ListServicesResponse ListServicesWithOptions(ListServicesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListServicesResponse>(DoRPCRequest("ListServices", "2019-08-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListServicesResponse> ListServicesWithOptionsAsync(ListServicesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListServicesResponse>(await DoRPCRequestAsync("ListServices", "2019-08-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListServicesResponse ListServices(ListServicesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListServicesWithOptions(request, runtime);
        }

        public async Task<ListServicesResponse> ListServicesAsync(ListServicesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListServicesWithOptionsAsync(request, runtime);
        }

        public ListSpanNamesResponse ListSpanNamesWithOptions(ListSpanNamesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListSpanNamesResponse>(DoRPCRequest("ListSpanNames", "2019-08-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListSpanNamesResponse> ListSpanNamesWithOptionsAsync(ListSpanNamesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListSpanNamesResponse>(await DoRPCRequestAsync("ListSpanNames", "2019-08-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListSpanNamesResponse ListSpanNames(ListSpanNamesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListSpanNamesWithOptions(request, runtime);
        }

        public async Task<ListSpanNamesResponse> ListSpanNamesAsync(ListSpanNamesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListSpanNamesWithOptionsAsync(request, runtime);
        }

        public QueryMetricResponse QueryMetricWithOptions(QueryMetricRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryMetricResponse>(DoRPCRequest("QueryMetric", "2019-08-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<QueryMetricResponse> QueryMetricWithOptionsAsync(QueryMetricRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryMetricResponse>(await DoRPCRequestAsync("QueryMetric", "2019-08-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public QueryMetricResponse QueryMetric(QueryMetricRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryMetricWithOptions(request, runtime);
        }

        public async Task<QueryMetricResponse> QueryMetricAsync(QueryMetricRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryMetricWithOptionsAsync(request, runtime);
        }

        public SearchTracesResponse SearchTracesWithOptions(SearchTracesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SearchTracesResponse>(DoRPCRequest("SearchTraces", "2019-08-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SearchTracesResponse> SearchTracesWithOptionsAsync(SearchTracesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SearchTracesResponse>(await DoRPCRequestAsync("SearchTraces", "2019-08-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public SearchTracesResponse SearchTraces(SearchTracesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SearchTracesWithOptions(request, runtime);
        }

        public async Task<SearchTracesResponse> SearchTracesAsync(SearchTracesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SearchTracesWithOptionsAsync(request, runtime);
        }

    }
}
