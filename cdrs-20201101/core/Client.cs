// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.CDRS20201101.Models;

namespace AlibabaCloud.SDK.CDRS20201101
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "";
            CheckConfig(config);
            this._endpoint = GetEndpoint("cdrs", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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

        public SearchObjectResponse SearchObjectWithOptions(SearchObjectRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SearchObjectResponse>(DoRPCRequest("SearchObject", "2020-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SearchObjectResponse> SearchObjectWithOptionsAsync(SearchObjectRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SearchObjectResponse>(await DoRPCRequestAsync("SearchObject", "2020-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public SearchObjectResponse SearchObject(SearchObjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SearchObjectWithOptions(request, runtime);
        }

        public async Task<SearchObjectResponse> SearchObjectAsync(SearchObjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SearchObjectWithOptionsAsync(request, runtime);
        }

        public ListAreaHotSpotMetricsResponse ListAreaHotSpotMetricsWithOptions(ListAreaHotSpotMetricsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListAreaHotSpotMetricsResponse>(DoRPCRequest("ListAreaHotSpotMetrics", "2020-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListAreaHotSpotMetricsResponse> ListAreaHotSpotMetricsWithOptionsAsync(ListAreaHotSpotMetricsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListAreaHotSpotMetricsResponse>(await DoRPCRequestAsync("ListAreaHotSpotMetrics", "2020-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListAreaHotSpotMetricsResponse ListAreaHotSpotMetrics(ListAreaHotSpotMetricsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListAreaHotSpotMetricsWithOptions(request, runtime);
        }

        public async Task<ListAreaHotSpotMetricsResponse> ListAreaHotSpotMetricsAsync(ListAreaHotSpotMetricsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListAreaHotSpotMetricsWithOptionsAsync(request, runtime);
        }

        public BindDeviceResponse BindDeviceWithOptions(BindDeviceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<BindDeviceResponse>(DoRPCRequest("BindDevice", "2020-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<BindDeviceResponse> BindDeviceWithOptionsAsync(BindDeviceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<BindDeviceResponse>(await DoRPCRequestAsync("BindDevice", "2020-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public BindDeviceResponse BindDevice(BindDeviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return BindDeviceWithOptions(request, runtime);
        }

        public async Task<BindDeviceResponse> BindDeviceAsync(BindDeviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await BindDeviceWithOptionsAsync(request, runtime);
        }

        public GetCdrsMonitorResultResponse GetCdrsMonitorResultWithOptions(GetCdrsMonitorResultRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetCdrsMonitorResultResponse>(DoRPCRequest("GetCdrsMonitorResult", "2020-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetCdrsMonitorResultResponse> GetCdrsMonitorResultWithOptionsAsync(GetCdrsMonitorResultRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetCdrsMonitorResultResponse>(await DoRPCRequestAsync("GetCdrsMonitorResult", "2020-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetCdrsMonitorResultResponse GetCdrsMonitorResult(GetCdrsMonitorResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetCdrsMonitorResultWithOptions(request, runtime);
        }

        public async Task<GetCdrsMonitorResultResponse> GetCdrsMonitorResultAsync(GetCdrsMonitorResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetCdrsMonitorResultWithOptionsAsync(request, runtime);
        }

        public ListVehicleDetailsResponse ListVehicleDetailsWithOptions(ListVehicleDetailsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListVehicleDetailsResponse>(DoRPCRequest("ListVehicleDetails", "2020-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListVehicleDetailsResponse> ListVehicleDetailsWithOptionsAsync(ListVehicleDetailsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListVehicleDetailsResponse>(await DoRPCRequestAsync("ListVehicleDetails", "2020-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListVehicleDetailsResponse ListVehicleDetails(ListVehicleDetailsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListVehicleDetailsWithOptions(request, runtime);
        }

        public async Task<ListVehicleDetailsResponse> ListVehicleDetailsAsync(ListVehicleDetailsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListVehicleDetailsWithOptionsAsync(request, runtime);
        }

        public GetCdrsMonitorListResponse GetCdrsMonitorListWithOptions(GetCdrsMonitorListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetCdrsMonitorListResponse>(DoRPCRequest("GetCdrsMonitorList", "2020-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetCdrsMonitorListResponse> GetCdrsMonitorListWithOptionsAsync(GetCdrsMonitorListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetCdrsMonitorListResponse>(await DoRPCRequestAsync("GetCdrsMonitorList", "2020-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetCdrsMonitorListResponse GetCdrsMonitorList(GetCdrsMonitorListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetCdrsMonitorListWithOptions(request, runtime);
        }

        public async Task<GetCdrsMonitorListResponse> GetCdrsMonitorListAsync(GetCdrsMonitorListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetCdrsMonitorListWithOptionsAsync(request, runtime);
        }

        public UpdateMonitorResponse UpdateMonitorWithOptions(UpdateMonitorRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateMonitorResponse>(DoRPCRequest("UpdateMonitor", "2020-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpdateMonitorResponse> UpdateMonitorWithOptionsAsync(UpdateMonitorRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateMonitorResponse>(await DoRPCRequestAsync("UpdateMonitor", "2020-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UpdateMonitorResponse UpdateMonitor(UpdateMonitorRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateMonitorWithOptions(request, runtime);
        }

        public async Task<UpdateMonitorResponse> UpdateMonitorAsync(UpdateMonitorRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateMonitorWithOptionsAsync(request, runtime);
        }

        public ListDataStatisticsResponse ListDataStatisticsWithOptions(ListDataStatisticsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListDataStatisticsResponse>(DoRPCRequest("ListDataStatistics", "2020-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListDataStatisticsResponse> ListDataStatisticsWithOptionsAsync(ListDataStatisticsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListDataStatisticsResponse>(await DoRPCRequestAsync("ListDataStatistics", "2020-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListDataStatisticsResponse ListDataStatistics(ListDataStatisticsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListDataStatisticsWithOptions(request, runtime);
        }

        public async Task<ListDataStatisticsResponse> ListDataStatisticsAsync(ListDataStatisticsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListDataStatisticsWithOptionsAsync(request, runtime);
        }

        public UnbindDeviceResponse UnbindDeviceWithOptions(UnbindDeviceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UnbindDeviceResponse>(DoRPCRequest("UnbindDevice", "2020-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UnbindDeviceResponse> UnbindDeviceWithOptionsAsync(UnbindDeviceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UnbindDeviceResponse>(await DoRPCRequestAsync("UnbindDevice", "2020-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UnbindDeviceResponse UnbindDevice(UnbindDeviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UnbindDeviceWithOptions(request, runtime);
        }

        public async Task<UnbindDeviceResponse> UnbindDeviceAsync(UnbindDeviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UnbindDeviceWithOptionsAsync(request, runtime);
        }

        public ListPersonDetailsResponse ListPersonDetailsWithOptions(ListPersonDetailsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListPersonDetailsResponse>(DoRPCRequest("ListPersonDetails", "2020-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListPersonDetailsResponse> ListPersonDetailsWithOptionsAsync(ListPersonDetailsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListPersonDetailsResponse>(await DoRPCRequestAsync("ListPersonDetails", "2020-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListPersonDetailsResponse ListPersonDetails(ListPersonDetailsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListPersonDetailsWithOptions(request, runtime);
        }

        public async Task<ListPersonDetailsResponse> ListPersonDetailsAsync(ListPersonDetailsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListPersonDetailsWithOptionsAsync(request, runtime);
        }

        public ListVehicleTagDistributeResponse ListVehicleTagDistributeWithOptions(ListVehicleTagDistributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListVehicleTagDistributeResponse>(DoRPCRequest("ListVehicleTagDistribute", "2020-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListVehicleTagDistributeResponse> ListVehicleTagDistributeWithOptionsAsync(ListVehicleTagDistributeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListVehicleTagDistributeResponse>(await DoRPCRequestAsync("ListVehicleTagDistribute", "2020-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListVehicleTagDistributeResponse ListVehicleTagDistribute(ListVehicleTagDistributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListVehicleTagDistributeWithOptions(request, runtime);
        }

        public async Task<ListVehicleTagDistributeResponse> ListVehicleTagDistributeAsync(ListVehicleTagDistributeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListVehicleTagDistributeWithOptionsAsync(request, runtime);
        }

        public ListDevicePersonStatisticsResponse ListDevicePersonStatisticsWithOptions(ListDevicePersonStatisticsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListDevicePersonStatisticsResponse>(DoRPCRequest("ListDevicePersonStatistics", "2020-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListDevicePersonStatisticsResponse> ListDevicePersonStatisticsWithOptionsAsync(ListDevicePersonStatisticsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListDevicePersonStatisticsResponse>(await DoRPCRequestAsync("ListDevicePersonStatistics", "2020-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListDevicePersonStatisticsResponse ListDevicePersonStatistics(ListDevicePersonStatisticsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListDevicePersonStatisticsWithOptions(request, runtime);
        }

        public async Task<ListDevicePersonStatisticsResponse> ListDevicePersonStatisticsAsync(ListDevicePersonStatisticsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListDevicePersonStatisticsWithOptionsAsync(request, runtime);
        }

        public AddMonitorResponse AddMonitorWithOptions(AddMonitorRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddMonitorResponse>(DoRPCRequest("AddMonitor", "2020-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<AddMonitorResponse> AddMonitorWithOptionsAsync(AddMonitorRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddMonitorResponse>(await DoRPCRequestAsync("AddMonitor", "2020-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public AddMonitorResponse AddMonitor(AddMonitorRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddMonitorWithOptions(request, runtime);
        }

        public async Task<AddMonitorResponse> AddMonitorAsync(AddMonitorRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddMonitorWithOptionsAsync(request, runtime);
        }

        public PaginateDeviceResponse PaginateDeviceWithOptions(PaginateDeviceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<PaginateDeviceResponse>(DoRPCRequest("PaginateDevice", "2020-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<PaginateDeviceResponse> PaginateDeviceWithOptionsAsync(PaginateDeviceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<PaginateDeviceResponse>(await DoRPCRequestAsync("PaginateDevice", "2020-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public PaginateDeviceResponse PaginateDevice(PaginateDeviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return PaginateDeviceWithOptions(request, runtime);
        }

        public async Task<PaginateDeviceResponse> PaginateDeviceAsync(PaginateDeviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await PaginateDeviceWithOptionsAsync(request, runtime);
        }

        public StopCdrsMonitorResponse StopCdrsMonitorWithOptions(StopCdrsMonitorRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<StopCdrsMonitorResponse>(DoRPCRequest("StopCdrsMonitor", "2020-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<StopCdrsMonitorResponse> StopCdrsMonitorWithOptionsAsync(StopCdrsMonitorRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<StopCdrsMonitorResponse>(await DoRPCRequestAsync("StopCdrsMonitor", "2020-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public StopCdrsMonitorResponse StopCdrsMonitor(StopCdrsMonitorRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StopCdrsMonitorWithOptions(request, runtime);
        }

        public async Task<StopCdrsMonitorResponse> StopCdrsMonitorAsync(StopCdrsMonitorRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StopCdrsMonitorWithOptionsAsync(request, runtime);
        }

        public RecallTrajectoryByCoordinateTimeResponse RecallTrajectoryByCoordinateTimeWithOptions(RecallTrajectoryByCoordinateTimeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RecallTrajectoryByCoordinateTimeResponse>(DoRPCRequest("RecallTrajectoryByCoordinateTime", "2020-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<RecallTrajectoryByCoordinateTimeResponse> RecallTrajectoryByCoordinateTimeWithOptionsAsync(RecallTrajectoryByCoordinateTimeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RecallTrajectoryByCoordinateTimeResponse>(await DoRPCRequestAsync("RecallTrajectoryByCoordinateTime", "2020-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public RecallTrajectoryByCoordinateTimeResponse RecallTrajectoryByCoordinateTime(RecallTrajectoryByCoordinateTimeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RecallTrajectoryByCoordinateTimeWithOptions(request, runtime);
        }

        public async Task<RecallTrajectoryByCoordinateTimeResponse> RecallTrajectoryByCoordinateTimeAsync(RecallTrajectoryByCoordinateTimeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RecallTrajectoryByCoordinateTimeWithOptionsAsync(request, runtime);
        }

        public ListCityMapPersonFlowResponse ListCityMapPersonFlowWithOptions(ListCityMapPersonFlowRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListCityMapPersonFlowShrinkRequest request = new ListCityMapPersonFlowShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.OriginDataSourceIdList))
            {
                request.OriginDataSourceIdListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.OriginDataSourceIdList, "OriginDataSourceIdList", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TargetDataSourceIdList))
            {
                request.TargetDataSourceIdListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TargetDataSourceIdList, "TargetDataSourceIdList", "json");
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListCityMapPersonFlowResponse>(DoRPCRequest("ListCityMapPersonFlow", "2020-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListCityMapPersonFlowResponse> ListCityMapPersonFlowWithOptionsAsync(ListCityMapPersonFlowRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListCityMapPersonFlowShrinkRequest request = new ListCityMapPersonFlowShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.OriginDataSourceIdList))
            {
                request.OriginDataSourceIdListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.OriginDataSourceIdList, "OriginDataSourceIdList", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TargetDataSourceIdList))
            {
                request.TargetDataSourceIdListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TargetDataSourceIdList, "TargetDataSourceIdList", "json");
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListCityMapPersonFlowResponse>(await DoRPCRequestAsync("ListCityMapPersonFlow", "2020-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListCityMapPersonFlowResponse ListCityMapPersonFlow(ListCityMapPersonFlowRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListCityMapPersonFlowWithOptions(request, runtime);
        }

        public async Task<ListCityMapPersonFlowResponse> ListCityMapPersonFlowAsync(ListCityMapPersonFlowRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListCityMapPersonFlowWithOptionsAsync(request, runtime);
        }

        public AddCdrsMonitorResponse AddCdrsMonitorWithOptions(AddCdrsMonitorRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddCdrsMonitorResponse>(DoRPCRequest("AddCdrsMonitor", "2020-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<AddCdrsMonitorResponse> AddCdrsMonitorWithOptionsAsync(AddCdrsMonitorRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddCdrsMonitorResponse>(await DoRPCRequestAsync("AddCdrsMonitor", "2020-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public AddCdrsMonitorResponse AddCdrsMonitor(AddCdrsMonitorRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddCdrsMonitorWithOptions(request, runtime);
        }

        public async Task<AddCdrsMonitorResponse> AddCdrsMonitorAsync(AddCdrsMonitorRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddCdrsMonitorWithOptionsAsync(request, runtime);
        }

        public ListMapRouteDetailsResponse ListMapRouteDetailsWithOptions(ListMapRouteDetailsRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListMapRouteDetailsShrinkRequest request = new ListMapRouteDetailsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.RouteList))
            {
                request.RouteListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.RouteList, "RouteList", "json");
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListMapRouteDetailsResponse>(DoRPCRequest("ListMapRouteDetails", "2020-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListMapRouteDetailsResponse> ListMapRouteDetailsWithOptionsAsync(ListMapRouteDetailsRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListMapRouteDetailsShrinkRequest request = new ListMapRouteDetailsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.RouteList))
            {
                request.RouteListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.RouteList, "RouteList", "json");
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListMapRouteDetailsResponse>(await DoRPCRequestAsync("ListMapRouteDetails", "2020-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListMapRouteDetailsResponse ListMapRouteDetails(ListMapRouteDetailsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListMapRouteDetailsWithOptions(request, runtime);
        }

        public async Task<ListMapRouteDetailsResponse> ListMapRouteDetailsAsync(ListMapRouteDetailsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListMapRouteDetailsWithOptionsAsync(request, runtime);
        }

        public ListPersonTopResponse ListPersonTopWithOptions(ListPersonTopRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListPersonTopResponse>(DoRPCRequest("ListPersonTop", "2020-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListPersonTopResponse> ListPersonTopWithOptionsAsync(ListPersonTopRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListPersonTopResponse>(await DoRPCRequestAsync("ListPersonTop", "2020-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListPersonTopResponse ListPersonTop(ListPersonTopRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListPersonTopWithOptions(request, runtime);
        }

        public async Task<ListPersonTopResponse> ListPersonTopAsync(ListPersonTopRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListPersonTopWithOptionsAsync(request, runtime);
        }

        public GetMonitorResultResponse GetMonitorResultWithOptions(GetMonitorResultRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetMonitorResultResponse>(DoRPCRequest("GetMonitorResult", "2020-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetMonitorResultResponse> GetMonitorResultWithOptionsAsync(GetMonitorResultRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetMonitorResultResponse>(await DoRPCRequestAsync("GetMonitorResult", "2020-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetMonitorResultResponse GetMonitorResult(GetMonitorResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetMonitorResultWithOptions(request, runtime);
        }

        public async Task<GetMonitorResultResponse> GetMonitorResultAsync(GetMonitorResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetMonitorResultWithOptionsAsync(request, runtime);
        }

        public ListCityMapAoisResponse ListCityMapAoisWithOptions(ListCityMapAoisRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListCityMapAoisResponse>(DoRPCRequest("ListCityMapAois", "2020-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListCityMapAoisResponse> ListCityMapAoisWithOptionsAsync(ListCityMapAoisRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListCityMapAoisResponse>(await DoRPCRequestAsync("ListCityMapAois", "2020-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListCityMapAoisResponse ListCityMapAois(ListCityMapAoisRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListCityMapAoisWithOptions(request, runtime);
        }

        public async Task<ListCityMapAoisResponse> ListCityMapAoisAsync(ListCityMapAoisRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListCityMapAoisWithOptionsAsync(request, runtime);
        }

        public RecognizeImageResponse RecognizeImageWithOptions(RecognizeImageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RecognizeImageResponse>(DoRPCRequest("RecognizeImage", "2020-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<RecognizeImageResponse> RecognizeImageWithOptionsAsync(RecognizeImageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RecognizeImageResponse>(await DoRPCRequestAsync("RecognizeImage", "2020-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public RecognizeImageResponse RecognizeImage(RecognizeImageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RecognizeImageWithOptions(request, runtime);
        }

        public async Task<RecognizeImageResponse> RecognizeImageAsync(RecognizeImageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RecognizeImageWithOptionsAsync(request, runtime);
        }

        public GetMonitorListResponse GetMonitorListWithOptions(GetMonitorListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetMonitorListResponse>(DoRPCRequest("GetMonitorList", "2020-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetMonitorListResponse> GetMonitorListWithOptionsAsync(GetMonitorListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetMonitorListResponse>(await DoRPCRequestAsync("GetMonitorList", "2020-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetMonitorListResponse GetMonitorList(GetMonitorListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetMonitorListWithOptions(request, runtime);
        }

        public async Task<GetMonitorListResponse> GetMonitorListAsync(GetMonitorListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetMonitorListWithOptionsAsync(request, runtime);
        }

        public ListDeviceRelationResponse ListDeviceRelationWithOptions(ListDeviceRelationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListDeviceRelationResponse>(DoRPCRequest("ListDeviceRelation", "2020-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListDeviceRelationResponse> ListDeviceRelationWithOptionsAsync(ListDeviceRelationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListDeviceRelationResponse>(await DoRPCRequestAsync("ListDeviceRelation", "2020-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListDeviceRelationResponse ListDeviceRelation(ListDeviceRelationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListDeviceRelationWithOptions(request, runtime);
        }

        public async Task<ListDeviceRelationResponse> ListDeviceRelationAsync(ListDeviceRelationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListDeviceRelationWithOptionsAsync(request, runtime);
        }

        public ListPersonTrackResponse ListPersonTrackWithOptions(ListPersonTrackRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListPersonTrackResponse>(DoRPCRequest("ListPersonTrack", "2020-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListPersonTrackResponse> ListPersonTrackWithOptionsAsync(ListPersonTrackRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListPersonTrackResponse>(await DoRPCRequestAsync("ListPersonTrack", "2020-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListPersonTrackResponse ListPersonTrack(ListPersonTrackRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListPersonTrackWithOptions(request, runtime);
        }

        public async Task<ListPersonTrackResponse> ListPersonTrackAsync(ListPersonTrackRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListPersonTrackWithOptionsAsync(request, runtime);
        }

        public ListCityMapCameraResultsResponse ListCityMapCameraResultsWithOptions(ListCityMapCameraResultsRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListCityMapCameraResultsShrinkRequest request = new ListCityMapCameraResultsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DataSourceIdList))
            {
                request.DataSourceIdListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DataSourceIdList, "DataSourceIdList", "json");
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListCityMapCameraResultsResponse>(DoRPCRequest("ListCityMapCameraResults", "2020-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListCityMapCameraResultsResponse> ListCityMapCameraResultsWithOptionsAsync(ListCityMapCameraResultsRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListCityMapCameraResultsShrinkRequest request = new ListCityMapCameraResultsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DataSourceIdList))
            {
                request.DataSourceIdListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DataSourceIdList, "DataSourceIdList", "json");
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListCityMapCameraResultsResponse>(await DoRPCRequestAsync("ListCityMapCameraResults", "2020-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListCityMapCameraResultsResponse ListCityMapCameraResults(ListCityMapCameraResultsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListCityMapCameraResultsWithOptions(request, runtime);
        }

        public async Task<ListCityMapCameraResultsResponse> ListCityMapCameraResultsAsync(ListCityMapCameraResultsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListCityMapCameraResultsWithOptionsAsync(request, runtime);
        }

        public QueryTrajectoryByIdResponse QueryTrajectoryByIdWithOptions(QueryTrajectoryByIdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryTrajectoryByIdResponse>(DoRPCRequest("QueryTrajectoryById", "2020-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<QueryTrajectoryByIdResponse> QueryTrajectoryByIdWithOptionsAsync(QueryTrajectoryByIdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<QueryTrajectoryByIdResponse>(await DoRPCRequestAsync("QueryTrajectoryById", "2020-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public QueryTrajectoryByIdResponse QueryTrajectoryById(QueryTrajectoryByIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return QueryTrajectoryByIdWithOptions(request, runtime);
        }

        public async Task<QueryTrajectoryByIdResponse> QueryTrajectoryByIdAsync(QueryTrajectoryByIdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await QueryTrajectoryByIdWithOptionsAsync(request, runtime);
        }

        public ListCityMapImageDetailsResponse ListCityMapImageDetailsWithOptions(ListCityMapImageDetailsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListCityMapImageDetailsResponse>(DoRPCRequest("ListCityMapImageDetails", "2020-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListCityMapImageDetailsResponse> ListCityMapImageDetailsWithOptionsAsync(ListCityMapImageDetailsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListCityMapImageDetailsResponse>(await DoRPCRequestAsync("ListCityMapImageDetails", "2020-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListCityMapImageDetailsResponse ListCityMapImageDetails(ListCityMapImageDetailsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListCityMapImageDetailsWithOptions(request, runtime);
        }

        public async Task<ListCityMapImageDetailsResponse> ListCityMapImageDetailsAsync(ListCityMapImageDetailsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListCityMapImageDetailsWithOptionsAsync(request, runtime);
        }

        public CreateProjectResponse CreateProjectWithOptions(CreateProjectRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateProjectResponse>(DoRPCRequest("CreateProject", "2020-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateProjectResponse> CreateProjectWithOptionsAsync(CreateProjectRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateProjectResponse>(await DoRPCRequestAsync("CreateProject", "2020-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateProjectResponse CreateProject(CreateProjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateProjectWithOptions(request, runtime);
        }

        public async Task<CreateProjectResponse> CreateProjectAsync(CreateProjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateProjectWithOptionsAsync(request, runtime);
        }

        public ListVehicleTopResponse ListVehicleTopWithOptions(ListVehicleTopRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListVehicleTopResponse>(DoRPCRequest("ListVehicleTop", "2020-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListVehicleTopResponse> ListVehicleTopWithOptionsAsync(ListVehicleTopRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListVehicleTopResponse>(await DoRPCRequestAsync("ListVehicleTop", "2020-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListVehicleTopResponse ListVehicleTop(ListVehicleTopRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListVehicleTopWithOptions(request, runtime);
        }

        public async Task<ListVehicleTopResponse> ListVehicleTopAsync(ListVehicleTopRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListVehicleTopWithOptionsAsync(request, runtime);
        }

        public ListDataStatisticsByDayResponse ListDataStatisticsByDayWithOptions(ListDataStatisticsByDayRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListDataStatisticsByDayResponse>(DoRPCRequest("ListDataStatisticsByDay", "2020-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListDataStatisticsByDayResponse> ListDataStatisticsByDayWithOptionsAsync(ListDataStatisticsByDayRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListDataStatisticsByDayResponse>(await DoRPCRequestAsync("ListDataStatisticsByDay", "2020-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListDataStatisticsByDayResponse ListDataStatisticsByDay(ListDataStatisticsByDayRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListDataStatisticsByDayWithOptions(request, runtime);
        }

        public async Task<ListDataStatisticsByDayResponse> ListDataStatisticsByDayAsync(ListDataStatisticsByDayRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListDataStatisticsByDayWithOptionsAsync(request, runtime);
        }

        public ListVehicleResultsResponse ListVehicleResultsWithOptions(ListVehicleResultsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListVehicleResultsResponse>(DoRPCRequest("ListVehicleResults", "2020-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListVehicleResultsResponse> ListVehicleResultsWithOptionsAsync(ListVehicleResultsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListVehicleResultsResponse>(await DoRPCRequestAsync("ListVehicleResults", "2020-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListVehicleResultsResponse ListVehicleResults(ListVehicleResultsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListVehicleResultsWithOptions(request, runtime);
        }

        public async Task<ListVehicleResultsResponse> ListVehicleResultsAsync(ListVehicleResultsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListVehicleResultsWithOptionsAsync(request, runtime);
        }

        public SearchAggregateObjectResponse SearchAggregateObjectWithOptions(SearchAggregateObjectRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SearchAggregateObjectResponse>(DoRPCRequest("SearchAggregateObject", "2020-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SearchAggregateObjectResponse> SearchAggregateObjectWithOptionsAsync(SearchAggregateObjectRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SearchAggregateObjectResponse>(await DoRPCRequestAsync("SearchAggregateObject", "2020-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public SearchAggregateObjectResponse SearchAggregateObject(SearchAggregateObjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SearchAggregateObjectWithOptions(request, runtime);
        }

        public async Task<SearchAggregateObjectResponse> SearchAggregateObjectAsync(SearchAggregateObjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SearchAggregateObjectWithOptionsAsync(request, runtime);
        }

        public ListCorpMetricsStatisticResponse ListCorpMetricsStatisticWithOptions(ListCorpMetricsStatisticRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListCorpMetricsStatisticShrinkRequest request = new ListCorpMetricsStatisticShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.UserGroupList))
            {
                request.UserGroupListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.UserGroupList, "UserGroupList", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DeviceGroupList))
            {
                request.DeviceGroupListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DeviceGroupList, "DeviceGroupList", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DeviceIdList))
            {
                request.DeviceIdListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DeviceIdList, "DeviceIdList", "json");
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListCorpMetricsStatisticResponse>(DoRPCRequest("ListCorpMetricsStatistic", "2020-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListCorpMetricsStatisticResponse> ListCorpMetricsStatisticWithOptionsAsync(ListCorpMetricsStatisticRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListCorpMetricsStatisticShrinkRequest request = new ListCorpMetricsStatisticShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.UserGroupList))
            {
                request.UserGroupListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.UserGroupList, "UserGroupList", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DeviceGroupList))
            {
                request.DeviceGroupListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DeviceGroupList, "DeviceGroupList", "json");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.DeviceIdList))
            {
                request.DeviceIdListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.DeviceIdList, "DeviceIdList", "json");
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListCorpMetricsStatisticResponse>(await DoRPCRequestAsync("ListCorpMetricsStatistic", "2020-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListCorpMetricsStatisticResponse ListCorpMetricsStatistic(ListCorpMetricsStatisticRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListCorpMetricsStatisticWithOptions(request, runtime);
        }

        public async Task<ListCorpMetricsStatisticResponse> ListCorpMetricsStatisticAsync(ListCorpMetricsStatisticRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListCorpMetricsStatisticWithOptionsAsync(request, runtime);
        }

        public DetectTrajectoryRegularPatternResponse DetectTrajectoryRegularPatternWithOptions(DetectTrajectoryRegularPatternRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DetectTrajectoryRegularPatternResponse>(DoRPCRequest("DetectTrajectoryRegularPattern", "2020-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DetectTrajectoryRegularPatternResponse> DetectTrajectoryRegularPatternWithOptionsAsync(DetectTrajectoryRegularPatternRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DetectTrajectoryRegularPatternResponse>(await DoRPCRequestAsync("DetectTrajectoryRegularPattern", "2020-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DetectTrajectoryRegularPatternResponse DetectTrajectoryRegularPattern(DetectTrajectoryRegularPatternRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DetectTrajectoryRegularPatternWithOptions(request, runtime);
        }

        public async Task<DetectTrajectoryRegularPatternResponse> DetectTrajectoryRegularPatternAsync(DetectTrajectoryRegularPatternRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DetectTrajectoryRegularPatternWithOptionsAsync(request, runtime);
        }

        public ListVehicleTrackResponse ListVehicleTrackWithOptions(ListVehicleTrackRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListVehicleTrackResponse>(DoRPCRequest("ListVehicleTrack", "2020-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListVehicleTrackResponse> ListVehicleTrackWithOptionsAsync(ListVehicleTrackRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListVehicleTrackResponse>(await DoRPCRequestAsync("ListVehicleTrack", "2020-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListVehicleTrackResponse ListVehicleTrack(ListVehicleTrackRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListVehicleTrackWithOptions(request, runtime);
        }

        public async Task<ListVehicleTrackResponse> ListVehicleTrackAsync(ListVehicleTrackRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListVehicleTrackWithOptionsAsync(request, runtime);
        }

        public ListStructureStatisticsResponse ListStructureStatisticsWithOptions(ListStructureStatisticsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListStructureStatisticsResponse>(DoRPCRequest("ListStructureStatistics", "2020-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListStructureStatisticsResponse> ListStructureStatisticsWithOptionsAsync(ListStructureStatisticsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListStructureStatisticsResponse>(await DoRPCRequestAsync("ListStructureStatistics", "2020-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListStructureStatisticsResponse ListStructureStatistics(ListStructureStatisticsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListStructureStatisticsWithOptions(request, runtime);
        }

        public async Task<ListStructureStatisticsResponse> ListStructureStatisticsAsync(ListStructureStatisticsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListStructureStatisticsWithOptionsAsync(request, runtime);
        }

        public StopMonitorResponse StopMonitorWithOptions(StopMonitorRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<StopMonitorResponse>(DoRPCRequest("StopMonitor", "2020-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<StopMonitorResponse> StopMonitorWithOptionsAsync(StopMonitorRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<StopMonitorResponse>(await DoRPCRequestAsync("StopMonitor", "2020-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public StopMonitorResponse StopMonitor(StopMonitorRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return StopMonitorWithOptions(request, runtime);
        }

        public async Task<StopMonitorResponse> StopMonitorAsync(StopMonitorRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await StopMonitorWithOptionsAsync(request, runtime);
        }

        public PredictTrajectoryDestinationResponse PredictTrajectoryDestinationWithOptions(PredictTrajectoryDestinationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<PredictTrajectoryDestinationResponse>(DoRPCRequest("PredictTrajectoryDestination", "2020-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<PredictTrajectoryDestinationResponse> PredictTrajectoryDestinationWithOptionsAsync(PredictTrajectoryDestinationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<PredictTrajectoryDestinationResponse>(await DoRPCRequestAsync("PredictTrajectoryDestination", "2020-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public PredictTrajectoryDestinationResponse PredictTrajectoryDestination(PredictTrajectoryDestinationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return PredictTrajectoryDestinationWithOptions(request, runtime);
        }

        public async Task<PredictTrajectoryDestinationResponse> PredictTrajectoryDestinationAsync(PredictTrajectoryDestinationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await PredictTrajectoryDestinationWithOptionsAsync(request, runtime);
        }

        public ListRangeDeviceResponse ListRangeDeviceWithOptions(ListRangeDeviceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListRangeDeviceResponse>(DoRPCRequest("ListRangeDevice", "2020-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListRangeDeviceResponse> ListRangeDeviceWithOptionsAsync(ListRangeDeviceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListRangeDeviceResponse>(await DoRPCRequestAsync("ListRangeDevice", "2020-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListRangeDeviceResponse ListRangeDevice(ListRangeDeviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListRangeDeviceWithOptions(request, runtime);
        }

        public async Task<ListRangeDeviceResponse> ListRangeDeviceAsync(ListRangeDeviceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListRangeDeviceWithOptionsAsync(request, runtime);
        }

        public ListCityMapRangeStatisticResponse ListCityMapRangeStatisticWithOptions(ListCityMapRangeStatisticRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListCityMapRangeStatisticResponse>(DoRPCRequest("ListCityMapRangeStatistic", "2020-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListCityMapRangeStatisticResponse> ListCityMapRangeStatisticWithOptionsAsync(ListCityMapRangeStatisticRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListCityMapRangeStatisticResponse>(await DoRPCRequestAsync("ListCityMapRangeStatistic", "2020-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListCityMapRangeStatisticResponse ListCityMapRangeStatistic(ListCityMapRangeStatisticRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListCityMapRangeStatisticWithOptions(request, runtime);
        }

        public async Task<ListCityMapRangeStatisticResponse> ListCityMapRangeStatisticAsync(ListCityMapRangeStatisticRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListCityMapRangeStatisticWithOptionsAsync(request, runtime);
        }

        public ListStorageStatisticsResponse ListStorageStatisticsWithOptions(ListStorageStatisticsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListStorageStatisticsResponse>(DoRPCRequest("ListStorageStatistics", "2020-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListStorageStatisticsResponse> ListStorageStatisticsWithOptionsAsync(ListStorageStatisticsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListStorageStatisticsResponse>(await DoRPCRequestAsync("ListStorageStatistics", "2020-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListStorageStatisticsResponse ListStorageStatistics(ListStorageStatisticsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListStorageStatisticsWithOptions(request, runtime);
        }

        public async Task<ListStorageStatisticsResponse> ListStorageStatisticsAsync(ListStorageStatisticsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListStorageStatisticsWithOptionsAsync(request, runtime);
        }

        public PaginateProjectResponse PaginateProjectWithOptions(PaginateProjectRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<PaginateProjectResponse>(DoRPCRequest("PaginateProject", "2020-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<PaginateProjectResponse> PaginateProjectWithOptionsAsync(PaginateProjectRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<PaginateProjectResponse>(await DoRPCRequestAsync("PaginateProject", "2020-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public PaginateProjectResponse PaginateProject(PaginateProjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return PaginateProjectWithOptions(request, runtime);
        }

        public async Task<PaginateProjectResponse> PaginateProjectAsync(PaginateProjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await PaginateProjectWithOptionsAsync(request, runtime);
        }

        public ListCityMapCameraStatisticsResponse ListCityMapCameraStatisticsWithOptions(ListCityMapCameraStatisticsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListCityMapCameraStatisticsResponse>(DoRPCRequest("ListCityMapCameraStatistics", "2020-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListCityMapCameraStatisticsResponse> ListCityMapCameraStatisticsWithOptionsAsync(ListCityMapCameraStatisticsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListCityMapCameraStatisticsResponse>(await DoRPCRequestAsync("ListCityMapCameraStatistics", "2020-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListCityMapCameraStatisticsResponse ListCityMapCameraStatistics(ListCityMapCameraStatisticsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListCityMapCameraStatisticsWithOptions(request, runtime);
        }

        public async Task<ListCityMapCameraStatisticsResponse> ListCityMapCameraStatisticsAsync(ListCityMapCameraStatisticsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListCityMapCameraStatisticsWithOptionsAsync(request, runtime);
        }

        public UpdateCdrsMonitorResponse UpdateCdrsMonitorWithOptions(UpdateCdrsMonitorRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateCdrsMonitorResponse>(DoRPCRequest("UpdateCdrsMonitor", "2020-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpdateCdrsMonitorResponse> UpdateCdrsMonitorWithOptionsAsync(UpdateCdrsMonitorRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateCdrsMonitorResponse>(await DoRPCRequestAsync("UpdateCdrsMonitor", "2020-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UpdateCdrsMonitorResponse UpdateCdrsMonitor(UpdateCdrsMonitorRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateCdrsMonitorWithOptions(request, runtime);
        }

        public async Task<UpdateCdrsMonitorResponse> UpdateCdrsMonitorAsync(UpdateCdrsMonitorRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateCdrsMonitorWithOptionsAsync(request, runtime);
        }

        public ListPersonResultResponse ListPersonResultWithOptions(ListPersonResultRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListPersonResultResponse>(DoRPCRequest("ListPersonResult", "2020-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListPersonResultResponse> ListPersonResultWithOptionsAsync(ListPersonResultRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListPersonResultResponse>(await DoRPCRequestAsync("ListPersonResult", "2020-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListPersonResultResponse ListPersonResult(ListPersonResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListPersonResultWithOptions(request, runtime);
        }

        public async Task<ListPersonResultResponse> ListPersonResultAsync(ListPersonResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListPersonResultWithOptionsAsync(request, runtime);
        }

        public ListTagMetricsResponse ListTagMetricsWithOptions(ListTagMetricsRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListTagMetricsShrinkRequest request = new ListTagMetricsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TagCode))
            {
                request.TagCodeShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TagCode, "TagCode", "json");
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListTagMetricsResponse>(DoRPCRequest("ListTagMetrics", "2020-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListTagMetricsResponse> ListTagMetricsWithOptionsAsync(ListTagMetricsRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListTagMetricsShrinkRequest request = new ListTagMetricsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.TagCode))
            {
                request.TagCodeShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.TagCode, "TagCode", "json");
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListTagMetricsResponse>(await DoRPCRequestAsync("ListTagMetrics", "2020-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListTagMetricsResponse ListTagMetrics(ListTagMetricsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListTagMetricsWithOptions(request, runtime);
        }

        public async Task<ListTagMetricsResponse> ListTagMetricsAsync(ListTagMetricsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListTagMetricsWithOptionsAsync(request, runtime);
        }

        public ListPersonTagResponse ListPersonTagWithOptions(ListPersonTagRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListPersonTagResponse>(DoRPCRequest("ListPersonTag", "2020-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListPersonTagResponse> ListPersonTagWithOptionsAsync(ListPersonTagRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListPersonTagResponse>(await DoRPCRequestAsync("ListPersonTag", "2020-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListPersonTagResponse ListPersonTag(ListPersonTagRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListPersonTagWithOptions(request, runtime);
        }

        public async Task<ListPersonTagResponse> ListPersonTagAsync(ListPersonTagRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListPersonTagWithOptionsAsync(request, runtime);
        }

        public UpdateProjectResponse UpdateProjectWithOptions(UpdateProjectRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateProjectResponse>(DoRPCRequest("UpdateProject", "2020-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpdateProjectResponse> UpdateProjectWithOptionsAsync(UpdateProjectRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateProjectResponse>(await DoRPCRequestAsync("UpdateProject", "2020-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UpdateProjectResponse UpdateProject(UpdateProjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateProjectWithOptions(request, runtime);
        }

        public async Task<UpdateProjectResponse> UpdateProjectAsync(UpdateProjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateProjectWithOptionsAsync(request, runtime);
        }

        public ListDevicePersonResponse ListDevicePersonWithOptions(ListDevicePersonRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListDevicePersonResponse>(DoRPCRequest("ListDevicePerson", "2020-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListDevicePersonResponse> ListDevicePersonWithOptionsAsync(ListDevicePersonRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListDevicePersonResponse>(await DoRPCRequestAsync("ListDevicePerson", "2020-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListDevicePersonResponse ListDevicePerson(ListDevicePersonRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListDevicePersonWithOptions(request, runtime);
        }

        public async Task<ListDevicePersonResponse> ListDevicePersonAsync(ListDevicePersonRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListDevicePersonWithOptionsAsync(request, runtime);
        }

        public ListDeviceDetailResponse ListDeviceDetailWithOptions(ListDeviceDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListDeviceDetailResponse>(DoRPCRequest("ListDeviceDetail", "2020-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListDeviceDetailResponse> ListDeviceDetailWithOptionsAsync(ListDeviceDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListDeviceDetailResponse>(await DoRPCRequestAsync("ListDeviceDetail", "2020-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListDeviceDetailResponse ListDeviceDetail(ListDeviceDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListDeviceDetailWithOptions(request, runtime);
        }

        public async Task<ListDeviceDetailResponse> ListDeviceDetailAsync(ListDeviceDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListDeviceDetailWithOptionsAsync(request, runtime);
        }

        public ListDeviceGenderStatisticsResponse ListDeviceGenderStatisticsWithOptions(ListDeviceGenderStatisticsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListDeviceGenderStatisticsResponse>(DoRPCRequest("ListDeviceGenderStatistics", "2020-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListDeviceGenderStatisticsResponse> ListDeviceGenderStatisticsWithOptionsAsync(ListDeviceGenderStatisticsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListDeviceGenderStatisticsResponse>(await DoRPCRequestAsync("ListDeviceGenderStatistics", "2020-11-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListDeviceGenderStatisticsResponse ListDeviceGenderStatistics(ListDeviceGenderStatisticsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListDeviceGenderStatisticsWithOptions(request, runtime);
        }

        public async Task<ListDeviceGenderStatisticsResponse> ListDeviceGenderStatisticsAsync(ListDeviceGenderStatisticsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListDeviceGenderStatisticsWithOptionsAsync(request, runtime);
        }

    }
}
