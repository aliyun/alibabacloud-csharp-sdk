// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Quotas20200510.Models;

namespace AlibabaCloud.SDK.Quotas20200510
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "";
            CheckConfig(config);
            this._endpoint = GetEndpoint("quotas", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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

        public CreateQuotaAlarmResponse CreateQuotaAlarmWithOptions(CreateQuotaAlarmRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateQuotaAlarmResponse>(DoRPCRequest("CreateQuotaAlarm", "2020-05-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateQuotaAlarmResponse> CreateQuotaAlarmWithOptionsAsync(CreateQuotaAlarmRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateQuotaAlarmResponse>(await DoRPCRequestAsync("CreateQuotaAlarm", "2020-05-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateQuotaAlarmResponse CreateQuotaAlarm(CreateQuotaAlarmRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateQuotaAlarmWithOptions(request, runtime);
        }

        public async Task<CreateQuotaAlarmResponse> CreateQuotaAlarmAsync(CreateQuotaAlarmRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateQuotaAlarmWithOptionsAsync(request, runtime);
        }

        public CreateQuotaApplicationResponse CreateQuotaApplicationWithOptions(CreateQuotaApplicationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateQuotaApplicationResponse>(DoRPCRequest("CreateQuotaApplication", "2020-05-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateQuotaApplicationResponse> CreateQuotaApplicationWithOptionsAsync(CreateQuotaApplicationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateQuotaApplicationResponse>(await DoRPCRequestAsync("CreateQuotaApplication", "2020-05-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateQuotaApplicationResponse CreateQuotaApplication(CreateQuotaApplicationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateQuotaApplicationWithOptions(request, runtime);
        }

        public async Task<CreateQuotaApplicationResponse> CreateQuotaApplicationAsync(CreateQuotaApplicationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateQuotaApplicationWithOptionsAsync(request, runtime);
        }

        public DeleteQuotaAlarmResponse DeleteQuotaAlarmWithOptions(DeleteQuotaAlarmRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteQuotaAlarmResponse>(DoRPCRequest("DeleteQuotaAlarm", "2020-05-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteQuotaAlarmResponse> DeleteQuotaAlarmWithOptionsAsync(DeleteQuotaAlarmRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteQuotaAlarmResponse>(await DoRPCRequestAsync("DeleteQuotaAlarm", "2020-05-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteQuotaAlarmResponse DeleteQuotaAlarm(DeleteQuotaAlarmRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteQuotaAlarmWithOptions(request, runtime);
        }

        public async Task<DeleteQuotaAlarmResponse> DeleteQuotaAlarmAsync(DeleteQuotaAlarmRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteQuotaAlarmWithOptionsAsync(request, runtime);
        }

        public GetProductQuotaResponse GetProductQuotaWithOptions(GetProductQuotaRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetProductQuotaResponse>(DoRPCRequest("GetProductQuota", "2020-05-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetProductQuotaResponse> GetProductQuotaWithOptionsAsync(GetProductQuotaRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetProductQuotaResponse>(await DoRPCRequestAsync("GetProductQuota", "2020-05-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetProductQuotaResponse GetProductQuota(GetProductQuotaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetProductQuotaWithOptions(request, runtime);
        }

        public async Task<GetProductQuotaResponse> GetProductQuotaAsync(GetProductQuotaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetProductQuotaWithOptionsAsync(request, runtime);
        }

        public GetProductQuotaDimensionResponse GetProductQuotaDimensionWithOptions(GetProductQuotaDimensionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetProductQuotaDimensionResponse>(DoRPCRequest("GetProductQuotaDimension", "2020-05-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetProductQuotaDimensionResponse> GetProductQuotaDimensionWithOptionsAsync(GetProductQuotaDimensionRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetProductQuotaDimensionResponse>(await DoRPCRequestAsync("GetProductQuotaDimension", "2020-05-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetProductQuotaDimensionResponse GetProductQuotaDimension(GetProductQuotaDimensionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetProductQuotaDimensionWithOptions(request, runtime);
        }

        public async Task<GetProductQuotaDimensionResponse> GetProductQuotaDimensionAsync(GetProductQuotaDimensionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetProductQuotaDimensionWithOptionsAsync(request, runtime);
        }

        public GetQuotaAlarmResponse GetQuotaAlarmWithOptions(GetQuotaAlarmRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetQuotaAlarmResponse>(DoRPCRequest("GetQuotaAlarm", "2020-05-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetQuotaAlarmResponse> GetQuotaAlarmWithOptionsAsync(GetQuotaAlarmRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetQuotaAlarmResponse>(await DoRPCRequestAsync("GetQuotaAlarm", "2020-05-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetQuotaAlarmResponse GetQuotaAlarm(GetQuotaAlarmRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetQuotaAlarmWithOptions(request, runtime);
        }

        public async Task<GetQuotaAlarmResponse> GetQuotaAlarmAsync(GetQuotaAlarmRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetQuotaAlarmWithOptionsAsync(request, runtime);
        }

        public GetQuotaApplicationResponse GetQuotaApplicationWithOptions(GetQuotaApplicationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetQuotaApplicationResponse>(DoRPCRequest("GetQuotaApplication", "2020-05-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<GetQuotaApplicationResponse> GetQuotaApplicationWithOptionsAsync(GetQuotaApplicationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<GetQuotaApplicationResponse>(await DoRPCRequestAsync("GetQuotaApplication", "2020-05-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public GetQuotaApplicationResponse GetQuotaApplication(GetQuotaApplicationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetQuotaApplicationWithOptions(request, runtime);
        }

        public async Task<GetQuotaApplicationResponse> GetQuotaApplicationAsync(GetQuotaApplicationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetQuotaApplicationWithOptionsAsync(request, runtime);
        }

        public ListAlarmHistoriesResponse ListAlarmHistoriesWithOptions(ListAlarmHistoriesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListAlarmHistoriesResponse>(DoRPCRequest("ListAlarmHistories", "2020-05-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListAlarmHistoriesResponse> ListAlarmHistoriesWithOptionsAsync(ListAlarmHistoriesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListAlarmHistoriesResponse>(await DoRPCRequestAsync("ListAlarmHistories", "2020-05-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListAlarmHistoriesResponse ListAlarmHistories(ListAlarmHistoriesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListAlarmHistoriesWithOptions(request, runtime);
        }

        public async Task<ListAlarmHistoriesResponse> ListAlarmHistoriesAsync(ListAlarmHistoriesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListAlarmHistoriesWithOptionsAsync(request, runtime);
        }

        public ListDependentQuotasResponse ListDependentQuotasWithOptions(ListDependentQuotasRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListDependentQuotasResponse>(DoRPCRequest("ListDependentQuotas", "2020-05-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListDependentQuotasResponse> ListDependentQuotasWithOptionsAsync(ListDependentQuotasRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListDependentQuotasResponse>(await DoRPCRequestAsync("ListDependentQuotas", "2020-05-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListDependentQuotasResponse ListDependentQuotas(ListDependentQuotasRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListDependentQuotasWithOptions(request, runtime);
        }

        public async Task<ListDependentQuotasResponse> ListDependentQuotasAsync(ListDependentQuotasRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListDependentQuotasWithOptionsAsync(request, runtime);
        }

        public ListProductQuotaDimensionsResponse ListProductQuotaDimensionsWithOptions(ListProductQuotaDimensionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListProductQuotaDimensionsResponse>(DoRPCRequest("ListProductQuotaDimensions", "2020-05-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListProductQuotaDimensionsResponse> ListProductQuotaDimensionsWithOptionsAsync(ListProductQuotaDimensionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListProductQuotaDimensionsResponse>(await DoRPCRequestAsync("ListProductQuotaDimensions", "2020-05-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListProductQuotaDimensionsResponse ListProductQuotaDimensions(ListProductQuotaDimensionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListProductQuotaDimensionsWithOptions(request, runtime);
        }

        public async Task<ListProductQuotaDimensionsResponse> ListProductQuotaDimensionsAsync(ListProductQuotaDimensionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListProductQuotaDimensionsWithOptionsAsync(request, runtime);
        }

        public ListProductQuotasResponse ListProductQuotasWithOptions(ListProductQuotasRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListProductQuotasResponse>(DoRPCRequest("ListProductQuotas", "2020-05-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListProductQuotasResponse> ListProductQuotasWithOptionsAsync(ListProductQuotasRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListProductQuotasResponse>(await DoRPCRequestAsync("ListProductQuotas", "2020-05-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListProductQuotasResponse ListProductQuotas(ListProductQuotasRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListProductQuotasWithOptions(request, runtime);
        }

        public async Task<ListProductQuotasResponse> ListProductQuotasAsync(ListProductQuotasRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListProductQuotasWithOptionsAsync(request, runtime);
        }

        public ListProductsResponse ListProductsWithOptions(ListProductsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListProductsResponse>(DoRPCRequest("ListProducts", "2020-05-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListProductsResponse> ListProductsWithOptionsAsync(ListProductsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListProductsResponse>(await DoRPCRequestAsync("ListProducts", "2020-05-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListProductsResponse ListProducts(ListProductsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListProductsWithOptions(request, runtime);
        }

        public async Task<ListProductsResponse> ListProductsAsync(ListProductsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListProductsWithOptionsAsync(request, runtime);
        }

        public ListQuotaAlarmsResponse ListQuotaAlarmsWithOptions(ListQuotaAlarmsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListQuotaAlarmsResponse>(DoRPCRequest("ListQuotaAlarms", "2020-05-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListQuotaAlarmsResponse> ListQuotaAlarmsWithOptionsAsync(ListQuotaAlarmsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListQuotaAlarmsResponse>(await DoRPCRequestAsync("ListQuotaAlarms", "2020-05-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListQuotaAlarmsResponse ListQuotaAlarms(ListQuotaAlarmsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListQuotaAlarmsWithOptions(request, runtime);
        }

        public async Task<ListQuotaAlarmsResponse> ListQuotaAlarmsAsync(ListQuotaAlarmsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListQuotaAlarmsWithOptionsAsync(request, runtime);
        }

        public ListQuotaApplicationsResponse ListQuotaApplicationsWithOptions(ListQuotaApplicationsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListQuotaApplicationsResponse>(DoRPCRequest("ListQuotaApplications", "2020-05-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListQuotaApplicationsResponse> ListQuotaApplicationsWithOptionsAsync(ListQuotaApplicationsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListQuotaApplicationsResponse>(await DoRPCRequestAsync("ListQuotaApplications", "2020-05-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListQuotaApplicationsResponse ListQuotaApplications(ListQuotaApplicationsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListQuotaApplicationsWithOptions(request, runtime);
        }

        public async Task<ListQuotaApplicationsResponse> ListQuotaApplicationsAsync(ListQuotaApplicationsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListQuotaApplicationsWithOptionsAsync(request, runtime);
        }

        public UpdateQuotaAlarmResponse UpdateQuotaAlarmWithOptions(UpdateQuotaAlarmRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateQuotaAlarmResponse>(DoRPCRequest("UpdateQuotaAlarm", "2020-05-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpdateQuotaAlarmResponse> UpdateQuotaAlarmWithOptionsAsync(UpdateQuotaAlarmRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateQuotaAlarmResponse>(await DoRPCRequestAsync("UpdateQuotaAlarm", "2020-05-10", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UpdateQuotaAlarmResponse UpdateQuotaAlarm(UpdateQuotaAlarmRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateQuotaAlarmWithOptions(request, runtime);
        }

        public async Task<UpdateQuotaAlarmResponse> UpdateQuotaAlarmAsync(UpdateQuotaAlarmRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateQuotaAlarmWithOptionsAsync(request, runtime);
        }

    }
}
