// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Pvtz20180101.Models;

namespace AlibabaCloud.SDK.Pvtz20180101
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "central";
            CheckConfig(config);
            this._endpoint = GetEndpoint("pvtz", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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

        public AddZoneResponse AddZoneWithOptions(AddZoneRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddZoneResponse>(DoRPCRequest("AddZone", "2018-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<AddZoneResponse> AddZoneWithOptionsAsync(AddZoneRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddZoneResponse>(await DoRPCRequestAsync("AddZone", "2018-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public AddZoneResponse AddZone(AddZoneRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddZoneWithOptions(request, runtime);
        }

        public async Task<AddZoneResponse> AddZoneAsync(AddZoneRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddZoneWithOptionsAsync(request, runtime);
        }

        public AddZoneRecordResponse AddZoneRecordWithOptions(AddZoneRecordRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddZoneRecordResponse>(DoRPCRequest("AddZoneRecord", "2018-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<AddZoneRecordResponse> AddZoneRecordWithOptionsAsync(AddZoneRecordRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AddZoneRecordResponse>(await DoRPCRequestAsync("AddZoneRecord", "2018-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public AddZoneRecordResponse AddZoneRecord(AddZoneRecordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AddZoneRecordWithOptions(request, runtime);
        }

        public async Task<AddZoneRecordResponse> AddZoneRecordAsync(AddZoneRecordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AddZoneRecordWithOptionsAsync(request, runtime);
        }

        public BindZoneVpcResponse BindZoneVpcWithOptions(BindZoneVpcRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<BindZoneVpcResponse>(DoRPCRequest("BindZoneVpc", "2018-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<BindZoneVpcResponse> BindZoneVpcWithOptionsAsync(BindZoneVpcRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<BindZoneVpcResponse>(await DoRPCRequestAsync("BindZoneVpc", "2018-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public BindZoneVpcResponse BindZoneVpc(BindZoneVpcRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return BindZoneVpcWithOptions(request, runtime);
        }

        public async Task<BindZoneVpcResponse> BindZoneVpcAsync(BindZoneVpcRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await BindZoneVpcWithOptionsAsync(request, runtime);
        }

        public CheckZoneNameResponse CheckZoneNameWithOptions(CheckZoneNameRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CheckZoneNameResponse>(DoRPCRequest("CheckZoneName", "2018-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CheckZoneNameResponse> CheckZoneNameWithOptionsAsync(CheckZoneNameRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CheckZoneNameResponse>(await DoRPCRequestAsync("CheckZoneName", "2018-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CheckZoneNameResponse CheckZoneName(CheckZoneNameRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CheckZoneNameWithOptions(request, runtime);
        }

        public async Task<CheckZoneNameResponse> CheckZoneNameAsync(CheckZoneNameRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CheckZoneNameWithOptionsAsync(request, runtime);
        }

        public DeleteZoneResponse DeleteZoneWithOptions(DeleteZoneRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteZoneResponse>(DoRPCRequest("DeleteZone", "2018-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteZoneResponse> DeleteZoneWithOptionsAsync(DeleteZoneRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteZoneResponse>(await DoRPCRequestAsync("DeleteZone", "2018-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteZoneResponse DeleteZone(DeleteZoneRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteZoneWithOptions(request, runtime);
        }

        public async Task<DeleteZoneResponse> DeleteZoneAsync(DeleteZoneRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteZoneWithOptionsAsync(request, runtime);
        }

        public DeleteZoneRecordResponse DeleteZoneRecordWithOptions(DeleteZoneRecordRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteZoneRecordResponse>(DoRPCRequest("DeleteZoneRecord", "2018-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteZoneRecordResponse> DeleteZoneRecordWithOptionsAsync(DeleteZoneRecordRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteZoneRecordResponse>(await DoRPCRequestAsync("DeleteZoneRecord", "2018-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteZoneRecordResponse DeleteZoneRecord(DeleteZoneRecordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteZoneRecordWithOptions(request, runtime);
        }

        public async Task<DeleteZoneRecordResponse> DeleteZoneRecordAsync(DeleteZoneRecordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteZoneRecordWithOptionsAsync(request, runtime);
        }

        public DescribeChangeLogsResponse DescribeChangeLogsWithOptions(DescribeChangeLogsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeChangeLogsResponse>(DoRPCRequest("DescribeChangeLogs", "2018-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeChangeLogsResponse> DescribeChangeLogsWithOptionsAsync(DescribeChangeLogsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeChangeLogsResponse>(await DoRPCRequestAsync("DescribeChangeLogs", "2018-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeChangeLogsResponse DescribeChangeLogs(DescribeChangeLogsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeChangeLogsWithOptions(request, runtime);
        }

        public async Task<DescribeChangeLogsResponse> DescribeChangeLogsAsync(DescribeChangeLogsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeChangeLogsWithOptionsAsync(request, runtime);
        }

        public DescribeRegionsResponse DescribeRegionsWithOptions(DescribeRegionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeRegionsResponse>(DoRPCRequest("DescribeRegions", "2018-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeRegionsResponse> DescribeRegionsWithOptionsAsync(DescribeRegionsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeRegionsResponse>(await DoRPCRequestAsync("DescribeRegions", "2018-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
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

        public DescribeRequestGraphResponse DescribeRequestGraphWithOptions(DescribeRequestGraphRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeRequestGraphResponse>(DoRPCRequest("DescribeRequestGraph", "2018-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeRequestGraphResponse> DescribeRequestGraphWithOptionsAsync(DescribeRequestGraphRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeRequestGraphResponse>(await DoRPCRequestAsync("DescribeRequestGraph", "2018-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeRequestGraphResponse DescribeRequestGraph(DescribeRequestGraphRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeRequestGraphWithOptions(request, runtime);
        }

        public async Task<DescribeRequestGraphResponse> DescribeRequestGraphAsync(DescribeRequestGraphRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeRequestGraphWithOptionsAsync(request, runtime);
        }

        public DescribeStatisticSummaryResponse DescribeStatisticSummaryWithOptions(DescribeStatisticSummaryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeStatisticSummaryResponse>(DoRPCRequest("DescribeStatisticSummary", "2018-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeStatisticSummaryResponse> DescribeStatisticSummaryWithOptionsAsync(DescribeStatisticSummaryRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeStatisticSummaryResponse>(await DoRPCRequestAsync("DescribeStatisticSummary", "2018-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeStatisticSummaryResponse DescribeStatisticSummary(DescribeStatisticSummaryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeStatisticSummaryWithOptions(request, runtime);
        }

        public async Task<DescribeStatisticSummaryResponse> DescribeStatisticSummaryAsync(DescribeStatisticSummaryRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeStatisticSummaryWithOptionsAsync(request, runtime);
        }

        public DescribeUserServiceStatusResponse DescribeUserServiceStatusWithOptions(DescribeUserServiceStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeUserServiceStatusResponse>(DoRPCRequest("DescribeUserServiceStatus", "2018-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeUserServiceStatusResponse> DescribeUserServiceStatusWithOptionsAsync(DescribeUserServiceStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeUserServiceStatusResponse>(await DoRPCRequestAsync("DescribeUserServiceStatus", "2018-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeUserServiceStatusResponse DescribeUserServiceStatus(DescribeUserServiceStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeUserServiceStatusWithOptions(request, runtime);
        }

        public async Task<DescribeUserServiceStatusResponse> DescribeUserServiceStatusAsync(DescribeUserServiceStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeUserServiceStatusWithOptionsAsync(request, runtime);
        }

        public DescribeZoneInfoResponse DescribeZoneInfoWithOptions(DescribeZoneInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeZoneInfoResponse>(DoRPCRequest("DescribeZoneInfo", "2018-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeZoneInfoResponse> DescribeZoneInfoWithOptionsAsync(DescribeZoneInfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeZoneInfoResponse>(await DoRPCRequestAsync("DescribeZoneInfo", "2018-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeZoneInfoResponse DescribeZoneInfo(DescribeZoneInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeZoneInfoWithOptions(request, runtime);
        }

        public async Task<DescribeZoneInfoResponse> DescribeZoneInfoAsync(DescribeZoneInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeZoneInfoWithOptionsAsync(request, runtime);
        }

        public DescribeZoneRecordsResponse DescribeZoneRecordsWithOptions(DescribeZoneRecordsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeZoneRecordsResponse>(DoRPCRequest("DescribeZoneRecords", "2018-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeZoneRecordsResponse> DescribeZoneRecordsWithOptionsAsync(DescribeZoneRecordsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeZoneRecordsResponse>(await DoRPCRequestAsync("DescribeZoneRecords", "2018-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeZoneRecordsResponse DescribeZoneRecords(DescribeZoneRecordsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeZoneRecordsWithOptions(request, runtime);
        }

        public async Task<DescribeZoneRecordsResponse> DescribeZoneRecordsAsync(DescribeZoneRecordsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeZoneRecordsWithOptionsAsync(request, runtime);
        }

        public DescribeZonesResponse DescribeZonesWithOptions(DescribeZonesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeZonesResponse>(DoRPCRequest("DescribeZones", "2018-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeZonesResponse> DescribeZonesWithOptionsAsync(DescribeZonesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeZonesResponse>(await DoRPCRequestAsync("DescribeZones", "2018-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeZonesResponse DescribeZones(DescribeZonesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeZonesWithOptions(request, runtime);
        }

        public async Task<DescribeZonesResponse> DescribeZonesAsync(DescribeZonesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeZonesWithOptionsAsync(request, runtime);
        }

        public DescribeZoneVpcTreeResponse DescribeZoneVpcTreeWithOptions(DescribeZoneVpcTreeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeZoneVpcTreeResponse>(DoRPCRequest("DescribeZoneVpcTree", "2018-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeZoneVpcTreeResponse> DescribeZoneVpcTreeWithOptionsAsync(DescribeZoneVpcTreeRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeZoneVpcTreeResponse>(await DoRPCRequestAsync("DescribeZoneVpcTree", "2018-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeZoneVpcTreeResponse DescribeZoneVpcTree(DescribeZoneVpcTreeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeZoneVpcTreeWithOptions(request, runtime);
        }

        public async Task<DescribeZoneVpcTreeResponse> DescribeZoneVpcTreeAsync(DescribeZoneVpcTreeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeZoneVpcTreeWithOptionsAsync(request, runtime);
        }

        public MoveResourceGroupResponse MoveResourceGroupWithOptions(MoveResourceGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<MoveResourceGroupResponse>(DoRPCRequest("MoveResourceGroup", "2018-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<MoveResourceGroupResponse> MoveResourceGroupWithOptionsAsync(MoveResourceGroupRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<MoveResourceGroupResponse>(await DoRPCRequestAsync("MoveResourceGroup", "2018-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public MoveResourceGroupResponse MoveResourceGroup(MoveResourceGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return MoveResourceGroupWithOptions(request, runtime);
        }

        public async Task<MoveResourceGroupResponse> MoveResourceGroupAsync(MoveResourceGroupRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await MoveResourceGroupWithOptionsAsync(request, runtime);
        }

        public SetProxyPatternResponse SetProxyPatternWithOptions(SetProxyPatternRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SetProxyPatternResponse>(DoRPCRequest("SetProxyPattern", "2018-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SetProxyPatternResponse> SetProxyPatternWithOptionsAsync(SetProxyPatternRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SetProxyPatternResponse>(await DoRPCRequestAsync("SetProxyPattern", "2018-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public SetProxyPatternResponse SetProxyPattern(SetProxyPatternRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetProxyPatternWithOptions(request, runtime);
        }

        public async Task<SetProxyPatternResponse> SetProxyPatternAsync(SetProxyPatternRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetProxyPatternWithOptionsAsync(request, runtime);
        }

        public SetZoneRecordStatusResponse SetZoneRecordStatusWithOptions(SetZoneRecordStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SetZoneRecordStatusResponse>(DoRPCRequest("SetZoneRecordStatus", "2018-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SetZoneRecordStatusResponse> SetZoneRecordStatusWithOptionsAsync(SetZoneRecordStatusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<SetZoneRecordStatusResponse>(await DoRPCRequestAsync("SetZoneRecordStatus", "2018-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public SetZoneRecordStatusResponse SetZoneRecordStatus(SetZoneRecordStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SetZoneRecordStatusWithOptions(request, runtime);
        }

        public async Task<SetZoneRecordStatusResponse> SetZoneRecordStatusAsync(SetZoneRecordStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SetZoneRecordStatusWithOptionsAsync(request, runtime);
        }

        public UpdateRecordRemarkResponse UpdateRecordRemarkWithOptions(UpdateRecordRemarkRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateRecordRemarkResponse>(DoRPCRequest("UpdateRecordRemark", "2018-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpdateRecordRemarkResponse> UpdateRecordRemarkWithOptionsAsync(UpdateRecordRemarkRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateRecordRemarkResponse>(await DoRPCRequestAsync("UpdateRecordRemark", "2018-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UpdateRecordRemarkResponse UpdateRecordRemark(UpdateRecordRemarkRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateRecordRemarkWithOptions(request, runtime);
        }

        public async Task<UpdateRecordRemarkResponse> UpdateRecordRemarkAsync(UpdateRecordRemarkRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateRecordRemarkWithOptionsAsync(request, runtime);
        }

        public UpdateZoneRecordResponse UpdateZoneRecordWithOptions(UpdateZoneRecordRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateZoneRecordResponse>(DoRPCRequest("UpdateZoneRecord", "2018-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpdateZoneRecordResponse> UpdateZoneRecordWithOptionsAsync(UpdateZoneRecordRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateZoneRecordResponse>(await DoRPCRequestAsync("UpdateZoneRecord", "2018-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UpdateZoneRecordResponse UpdateZoneRecord(UpdateZoneRecordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateZoneRecordWithOptions(request, runtime);
        }

        public async Task<UpdateZoneRecordResponse> UpdateZoneRecordAsync(UpdateZoneRecordRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateZoneRecordWithOptionsAsync(request, runtime);
        }

        public UpdateZoneRemarkResponse UpdateZoneRemarkWithOptions(UpdateZoneRemarkRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateZoneRemarkResponse>(DoRPCRequest("UpdateZoneRemark", "2018-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpdateZoneRemarkResponse> UpdateZoneRemarkWithOptionsAsync(UpdateZoneRemarkRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateZoneRemarkResponse>(await DoRPCRequestAsync("UpdateZoneRemark", "2018-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UpdateZoneRemarkResponse UpdateZoneRemark(UpdateZoneRemarkRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateZoneRemarkWithOptions(request, runtime);
        }

        public async Task<UpdateZoneRemarkResponse> UpdateZoneRemarkAsync(UpdateZoneRemarkRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateZoneRemarkWithOptionsAsync(request, runtime);
        }

    }
}
