// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Eci20180808.Models;

namespace AlibabaCloud.SDK.Eci20180808
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "";
            CheckConfig(config);
            this._endpoint = GetEndpoint("eci", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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

        public CreateContainerGroupResponse CreateContainerGroupWithOptions(CreateContainerGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateContainerGroupResponse>(DoRPCRequest("CreateContainerGroup", "2018-08-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateContainerGroupResponse> CreateContainerGroupWithOptionsAsync(CreateContainerGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateContainerGroupResponse>(await DoRPCRequestAsync("CreateContainerGroup", "2018-08-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateContainerGroupResponse CreateContainerGroup(CreateContainerGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateContainerGroupWithOptions(request, runtime);
        }

        public async Task<CreateContainerGroupResponse> CreateContainerGroupAsync(CreateContainerGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateContainerGroupWithOptionsAsync(request, runtime);
        }

        public CreateImageCacheResponse CreateImageCacheWithOptions(CreateImageCacheRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateImageCacheResponse>(DoRPCRequest("CreateImageCache", "2018-08-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateImageCacheResponse> CreateImageCacheWithOptionsAsync(CreateImageCacheRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateImageCacheResponse>(await DoRPCRequestAsync("CreateImageCache", "2018-08-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateImageCacheResponse CreateImageCache(CreateImageCacheRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateImageCacheWithOptions(request, runtime);
        }

        public async Task<CreateImageCacheResponse> CreateImageCacheAsync(CreateImageCacheRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateImageCacheWithOptionsAsync(request, runtime);
        }

        public DeleteContainerGroupResponse DeleteContainerGroupWithOptions(DeleteContainerGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteContainerGroupResponse>(DoRPCRequest("DeleteContainerGroup", "2018-08-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteContainerGroupResponse> DeleteContainerGroupWithOptionsAsync(DeleteContainerGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteContainerGroupResponse>(await DoRPCRequestAsync("DeleteContainerGroup", "2018-08-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteContainerGroupResponse DeleteContainerGroup(DeleteContainerGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteContainerGroupWithOptions(request, runtime);
        }

        public async Task<DeleteContainerGroupResponse> DeleteContainerGroupAsync(DeleteContainerGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteContainerGroupWithOptionsAsync(request, runtime);
        }

        public DeleteImageCacheResponse DeleteImageCacheWithOptions(DeleteImageCacheRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteImageCacheResponse>(DoRPCRequest("DeleteImageCache", "2018-08-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteImageCacheResponse> DeleteImageCacheWithOptionsAsync(DeleteImageCacheRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteImageCacheResponse>(await DoRPCRequestAsync("DeleteImageCache", "2018-08-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteImageCacheResponse DeleteImageCache(DeleteImageCacheRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteImageCacheWithOptions(request, runtime);
        }

        public async Task<DeleteImageCacheResponse> DeleteImageCacheAsync(DeleteImageCacheRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteImageCacheWithOptionsAsync(request, runtime);
        }

        public DescribeContainerGroupEventsResponse DescribeContainerGroupEventsWithOptions(DescribeContainerGroupEventsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeContainerGroupEventsResponse>(DoRPCRequest("DescribeContainerGroupEvents", "2018-08-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeContainerGroupEventsResponse> DescribeContainerGroupEventsWithOptionsAsync(DescribeContainerGroupEventsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeContainerGroupEventsResponse>(await DoRPCRequestAsync("DescribeContainerGroupEvents", "2018-08-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeContainerGroupEventsResponse DescribeContainerGroupEvents(DescribeContainerGroupEventsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeContainerGroupEventsWithOptions(request, runtime);
        }

        public async Task<DescribeContainerGroupEventsResponse> DescribeContainerGroupEventsAsync(DescribeContainerGroupEventsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeContainerGroupEventsWithOptionsAsync(request, runtime);
        }

        public DescribeContainerGroupMetricResponse DescribeContainerGroupMetricWithOptions(DescribeContainerGroupMetricRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeContainerGroupMetricResponse>(DoRPCRequest("DescribeContainerGroupMetric", "2018-08-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeContainerGroupMetricResponse> DescribeContainerGroupMetricWithOptionsAsync(DescribeContainerGroupMetricRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeContainerGroupMetricResponse>(await DoRPCRequestAsync("DescribeContainerGroupMetric", "2018-08-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeContainerGroupMetricResponse DescribeContainerGroupMetric(DescribeContainerGroupMetricRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeContainerGroupMetricWithOptions(request, runtime);
        }

        public async Task<DescribeContainerGroupMetricResponse> DescribeContainerGroupMetricAsync(DescribeContainerGroupMetricRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeContainerGroupMetricWithOptionsAsync(request, runtime);
        }

        public DescribeContainerGroupPriceResponse DescribeContainerGroupPriceWithOptions(DescribeContainerGroupPriceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeContainerGroupPriceResponse>(DoRPCRequest("DescribeContainerGroupPrice", "2018-08-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeContainerGroupPriceResponse> DescribeContainerGroupPriceWithOptionsAsync(DescribeContainerGroupPriceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeContainerGroupPriceResponse>(await DoRPCRequestAsync("DescribeContainerGroupPrice", "2018-08-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeContainerGroupPriceResponse DescribeContainerGroupPrice(DescribeContainerGroupPriceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeContainerGroupPriceWithOptions(request, runtime);
        }

        public async Task<DescribeContainerGroupPriceResponse> DescribeContainerGroupPriceAsync(DescribeContainerGroupPriceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeContainerGroupPriceWithOptionsAsync(request, runtime);
        }

        public DescribeContainerGroupsResponse DescribeContainerGroupsWithOptions(DescribeContainerGroupsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeContainerGroupsResponse>(DoRPCRequest("DescribeContainerGroups", "2018-08-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeContainerGroupsResponse> DescribeContainerGroupsWithOptionsAsync(DescribeContainerGroupsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeContainerGroupsResponse>(await DoRPCRequestAsync("DescribeContainerGroups", "2018-08-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeContainerGroupsResponse DescribeContainerGroups(DescribeContainerGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeContainerGroupsWithOptions(request, runtime);
        }

        public async Task<DescribeContainerGroupsResponse> DescribeContainerGroupsAsync(DescribeContainerGroupsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeContainerGroupsWithOptionsAsync(request, runtime);
        }

        public DescribeContainerGroupStatusResponse DescribeContainerGroupStatusWithOptions(DescribeContainerGroupStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeContainerGroupStatusResponse>(DoRPCRequest("DescribeContainerGroupStatus", "2018-08-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeContainerGroupStatusResponse> DescribeContainerGroupStatusWithOptionsAsync(DescribeContainerGroupStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeContainerGroupStatusResponse>(await DoRPCRequestAsync("DescribeContainerGroupStatus", "2018-08-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeContainerGroupStatusResponse DescribeContainerGroupStatus(DescribeContainerGroupStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeContainerGroupStatusWithOptions(request, runtime);
        }

        public async Task<DescribeContainerGroupStatusResponse> DescribeContainerGroupStatusAsync(DescribeContainerGroupStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeContainerGroupStatusWithOptionsAsync(request, runtime);
        }

        public DescribeContainerLogResponse DescribeContainerLogWithOptions(DescribeContainerLogRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeContainerLogResponse>(DoRPCRequest("DescribeContainerLog", "2018-08-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeContainerLogResponse> DescribeContainerLogWithOptionsAsync(DescribeContainerLogRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeContainerLogResponse>(await DoRPCRequestAsync("DescribeContainerLog", "2018-08-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeContainerLogResponse DescribeContainerLog(DescribeContainerLogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeContainerLogWithOptions(request, runtime);
        }

        public async Task<DescribeContainerLogResponse> DescribeContainerLogAsync(DescribeContainerLogRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeContainerLogWithOptionsAsync(request, runtime);
        }

        public DescribeImageCachesResponse DescribeImageCachesWithOptions(DescribeImageCachesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeImageCachesResponse>(DoRPCRequest("DescribeImageCaches", "2018-08-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeImageCachesResponse> DescribeImageCachesWithOptionsAsync(DescribeImageCachesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeImageCachesResponse>(await DoRPCRequestAsync("DescribeImageCaches", "2018-08-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeImageCachesResponse DescribeImageCaches(DescribeImageCachesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeImageCachesWithOptions(request, runtime);
        }

        public async Task<DescribeImageCachesResponse> DescribeImageCachesAsync(DescribeImageCachesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeImageCachesWithOptionsAsync(request, runtime);
        }

        public DescribeMultiContainerGroupMetricResponse DescribeMultiContainerGroupMetricWithOptions(DescribeMultiContainerGroupMetricRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeMultiContainerGroupMetricResponse>(DoRPCRequest("DescribeMultiContainerGroupMetric", "2018-08-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeMultiContainerGroupMetricResponse> DescribeMultiContainerGroupMetricWithOptionsAsync(DescribeMultiContainerGroupMetricRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeMultiContainerGroupMetricResponse>(await DoRPCRequestAsync("DescribeMultiContainerGroupMetric", "2018-08-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeMultiContainerGroupMetricResponse DescribeMultiContainerGroupMetric(DescribeMultiContainerGroupMetricRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeMultiContainerGroupMetricWithOptions(request, runtime);
        }

        public async Task<DescribeMultiContainerGroupMetricResponse> DescribeMultiContainerGroupMetricAsync(DescribeMultiContainerGroupMetricRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeMultiContainerGroupMetricWithOptionsAsync(request, runtime);
        }

        public DescribeRegionsResponse DescribeRegionsWithOptions(DescribeRegionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeRegionsResponse>(DoRPCRequest("DescribeRegions", "2018-08-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeRegionsResponse> DescribeRegionsWithOptionsAsync(DescribeRegionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeRegionsResponse>(await DoRPCRequestAsync("DescribeRegions", "2018-08-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeRegionsResponse DescribeRegions(DescribeRegionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeRegionsWithOptions(request, runtime);
        }

        public async Task<DescribeRegionsResponse> DescribeRegionsAsync(DescribeRegionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeRegionsWithOptionsAsync(request, runtime);
        }

        public ExecContainerCommandResponse ExecContainerCommandWithOptions(ExecContainerCommandRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ExecContainerCommandResponse>(DoRPCRequest("ExecContainerCommand", "2018-08-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ExecContainerCommandResponse> ExecContainerCommandWithOptionsAsync(ExecContainerCommandRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ExecContainerCommandResponse>(await DoRPCRequestAsync("ExecContainerCommand", "2018-08-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ExecContainerCommandResponse ExecContainerCommand(ExecContainerCommandRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ExecContainerCommandWithOptions(request, runtime);
        }

        public async Task<ExecContainerCommandResponse> ExecContainerCommandAsync(ExecContainerCommandRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ExecContainerCommandWithOptionsAsync(request, runtime);
        }

        public ListUsageResponse ListUsageWithOptions(ListUsageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListUsageResponse>(DoRPCRequest("ListUsage", "2018-08-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<ListUsageResponse> ListUsageWithOptionsAsync(ListUsageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<ListUsageResponse>(await DoRPCRequestAsync("ListUsage", "2018-08-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public ListUsageResponse ListUsage(ListUsageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListUsageWithOptions(request, runtime);
        }

        public async Task<ListUsageResponse> ListUsageAsync(ListUsageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListUsageWithOptionsAsync(request, runtime);
        }

        public RestartContainerGroupResponse RestartContainerGroupWithOptions(RestartContainerGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RestartContainerGroupResponse>(DoRPCRequest("RestartContainerGroup", "2018-08-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<RestartContainerGroupResponse> RestartContainerGroupWithOptionsAsync(RestartContainerGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<RestartContainerGroupResponse>(await DoRPCRequestAsync("RestartContainerGroup", "2018-08-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public RestartContainerGroupResponse RestartContainerGroup(RestartContainerGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return RestartContainerGroupWithOptions(request, runtime);
        }

        public async Task<RestartContainerGroupResponse> RestartContainerGroupAsync(RestartContainerGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await RestartContainerGroupWithOptionsAsync(request, runtime);
        }

        public UpdateContainerGroupResponse UpdateContainerGroupWithOptions(UpdateContainerGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateContainerGroupResponse>(DoRPCRequest("UpdateContainerGroup", "2018-08-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpdateContainerGroupResponse> UpdateContainerGroupWithOptionsAsync(UpdateContainerGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateContainerGroupResponse>(await DoRPCRequestAsync("UpdateContainerGroup", "2018-08-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UpdateContainerGroupResponse UpdateContainerGroup(UpdateContainerGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateContainerGroupWithOptions(request, runtime);
        }

        public async Task<UpdateContainerGroupResponse> UpdateContainerGroupAsync(UpdateContainerGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateContainerGroupWithOptionsAsync(request, runtime);
        }

        public UpdateImageCacheResponse UpdateImageCacheWithOptions(UpdateImageCacheRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateImageCacheResponse>(DoRPCRequest("UpdateImageCache", "2018-08-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpdateImageCacheResponse> UpdateImageCacheWithOptionsAsync(UpdateImageCacheRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateImageCacheResponse>(await DoRPCRequestAsync("UpdateImageCache", "2018-08-08", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UpdateImageCacheResponse UpdateImageCache(UpdateImageCacheRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateImageCacheWithOptions(request, runtime);
        }

        public async Task<UpdateImageCacheResponse> UpdateImageCacheAsync(UpdateImageCacheRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateImageCacheWithOptionsAsync(request, runtime);
        }

    }
}
