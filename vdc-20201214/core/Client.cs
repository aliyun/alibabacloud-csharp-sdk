// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Vdc20201214.Models;

namespace AlibabaCloud.SDK.Vdc20201214
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "";
            CheckConfig(config);
            this._endpoint = GetEndpoint("vdc", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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

        public DescribeFaultDiagnosisOverallDataResponse DescribeFaultDiagnosisOverallData(DescribeFaultDiagnosisOverallDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeFaultDiagnosisOverallDataWithOptions(request, headers, runtime);
        }

        public async Task<DescribeFaultDiagnosisOverallDataResponse> DescribeFaultDiagnosisOverallDataAsync(DescribeFaultDiagnosisOverallDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeFaultDiagnosisOverallDataWithOptionsAsync(request, headers, runtime);
        }

        public DescribeFaultDiagnosisOverallDataResponse DescribeFaultDiagnosisOverallDataWithOptions(DescribeFaultDiagnosisOverallDataRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTs))
            {
                query["StartTs"] = request.StartTs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTs))
            {
                query["EndTs"] = request.EndTs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StatDim))
            {
                query["StatDim"] = request.StatDim;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<DescribeFaultDiagnosisOverallDataResponse>(DoROARequest("DescribeFaultDiagnosisOverallData", "2020-12-14", "HTTPS", "POST", "AK", "/api/diagnosis/describeFaultDiagnosisOverallData", "json", req, runtime));
        }

        public async Task<DescribeFaultDiagnosisOverallDataResponse> DescribeFaultDiagnosisOverallDataWithOptionsAsync(DescribeFaultDiagnosisOverallDataRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTs))
            {
                query["StartTs"] = request.StartTs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTs))
            {
                query["EndTs"] = request.EndTs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StatDim))
            {
                query["StatDim"] = request.StatDim;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<DescribeFaultDiagnosisOverallDataResponse>(await DoROARequestAsync("DescribeFaultDiagnosisOverallData", "2020-12-14", "HTTPS", "POST", "AK", "/api/diagnosis/describeFaultDiagnosisOverallData", "json", req, runtime));
        }

        public DescribeRtcChannelUsersResponse DescribeRtcChannelUsers(DescribeRtcChannelUsersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeRtcChannelUsersWithOptions(request, headers, runtime);
        }

        public async Task<DescribeRtcChannelUsersResponse> DescribeRtcChannelUsersAsync(DescribeRtcChannelUsersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeRtcChannelUsersWithOptionsAsync(request, headers, runtime);
        }

        public DescribeRtcChannelUsersResponse DescribeRtcChannelUsersWithOptions(DescribeRtcChannelUsersRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelId))
            {
                query["ChannelId"] = request.ChannelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TimePoint))
            {
                query["TimePoint"] = request.TimePoint;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNo))
            {
                query["PageNo"] = request.PageNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<DescribeRtcChannelUsersResponse>(DoROARequest("DescribeRtcChannelUsers", "2020-12-14", "HTTPS", "POST", "AK", "/api/channel/describeRtcChannelUsers", "json", req, runtime));
        }

        public async Task<DescribeRtcChannelUsersResponse> DescribeRtcChannelUsersWithOptionsAsync(DescribeRtcChannelUsersRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelId))
            {
                query["ChannelId"] = request.ChannelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TimePoint))
            {
                query["TimePoint"] = request.TimePoint;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNo))
            {
                query["PageNo"] = request.PageNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<DescribeRtcChannelUsersResponse>(await DoROARequestAsync("DescribeRtcChannelUsers", "2020-12-14", "HTTPS", "POST", "AK", "/api/channel/describeRtcChannelUsers", "json", req, runtime));
        }

        public DescribeChannelOverallDataResponse DescribeChannelOverallData(DescribeChannelOverallDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeChannelOverallDataWithOptions(request, headers, runtime);
        }

        public async Task<DescribeChannelOverallDataResponse> DescribeChannelOverallDataAsync(DescribeChannelOverallDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeChannelOverallDataWithOptionsAsync(request, headers, runtime);
        }

        public DescribeChannelOverallDataResponse DescribeChannelOverallDataWithOptions(DescribeChannelOverallDataRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelId))
            {
                query["ChannelId"] = request.ChannelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreatedTs))
            {
                query["CreatedTs"] = request.CreatedTs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestroyedTs))
            {
                query["DestroyedTs"] = request.DestroyedTs;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<DescribeChannelOverallDataResponse>(DoROARequest("DescribeChannelOverallData", "2020-12-14", "HTTPS", "POST", "AK", "/api/channel/describeChannelOverallData", "json", req, runtime));
        }

        public async Task<DescribeChannelOverallDataResponse> DescribeChannelOverallDataWithOptionsAsync(DescribeChannelOverallDataRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelId))
            {
                query["ChannelId"] = request.ChannelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreatedTs))
            {
                query["CreatedTs"] = request.CreatedTs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestroyedTs))
            {
                query["DestroyedTs"] = request.DestroyedTs;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<DescribeChannelOverallDataResponse>(await DoROARequestAsync("DescribeChannelOverallData", "2020-12-14", "HTTPS", "POST", "AK", "/api/channel/describeChannelOverallData", "json", req, runtime));
        }

        public DescribeUsageOsSdkVersionDistributionStatDataResponse DescribeUsageOsSdkVersionDistributionStatData(DescribeUsageOsSdkVersionDistributionStatDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeUsageOsSdkVersionDistributionStatDataWithOptions(request, headers, runtime);
        }

        public async Task<DescribeUsageOsSdkVersionDistributionStatDataResponse> DescribeUsageOsSdkVersionDistributionStatDataAsync(DescribeUsageOsSdkVersionDistributionStatDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeUsageOsSdkVersionDistributionStatDataWithOptionsAsync(request, headers, runtime);
        }

        public DescribeUsageOsSdkVersionDistributionStatDataResponse DescribeUsageOsSdkVersionDistributionStatDataWithOptions(DescribeUsageOsSdkVersionDistributionStatDataRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartDate))
            {
                query["StartDate"] = request.StartDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndDate))
            {
                query["EndDate"] = request.EndDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<DescribeUsageOsSdkVersionDistributionStatDataResponse>(DoROARequest("DescribeUsageOsSdkVersionDistributionStatData", "2020-12-14", "HTTPS", "POST", "AK", "/api/usage/describeUsageOsSdkVersionDistributionStatData", "json", req, runtime));
        }

        public async Task<DescribeUsageOsSdkVersionDistributionStatDataResponse> DescribeUsageOsSdkVersionDistributionStatDataWithOptionsAsync(DescribeUsageOsSdkVersionDistributionStatDataRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartDate))
            {
                query["StartDate"] = request.StartDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndDate))
            {
                query["EndDate"] = request.EndDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<DescribeUsageOsSdkVersionDistributionStatDataResponse>(await DoROARequestAsync("DescribeUsageOsSdkVersionDistributionStatData", "2020-12-14", "HTTPS", "POST", "AK", "/api/usage/describeUsageOsSdkVersionDistributionStatData", "json", req, runtime));
        }

        public DescribeIceDurPeriodByDaySubTypeResponse DescribeIceDurPeriodByDaySubType(DescribeIceDurPeriodByDaySubTypeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeIceDurPeriodByDaySubTypeWithOptions(request, headers, runtime);
        }

        public async Task<DescribeIceDurPeriodByDaySubTypeResponse> DescribeIceDurPeriodByDaySubTypeAsync(DescribeIceDurPeriodByDaySubTypeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeIceDurPeriodByDaySubTypeWithOptionsAsync(request, headers, runtime);
        }

        public DescribeIceDurPeriodByDaySubTypeResponse DescribeIceDurPeriodByDaySubTypeWithOptions(DescribeIceDurPeriodByDaySubTypeRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobType))
            {
                query["JobType"] = request.JobType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTs))
            {
                query["StartTs"] = request.StartTs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTs))
            {
                query["EndTs"] = request.EndTs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TimeZone))
            {
                query["TimeZone"] = request.TimeZone;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<DescribeIceDurPeriodByDaySubTypeResponse>(DoROARequest("DescribeIceDurPeriodByDaySubType", "2020-12-14", "HTTPS", "POST", "AK", "/api/ice/describeIceDurPeriodByDaySubType", "json", req, runtime));
        }

        public async Task<DescribeIceDurPeriodByDaySubTypeResponse> DescribeIceDurPeriodByDaySubTypeWithOptionsAsync(DescribeIceDurPeriodByDaySubTypeRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobType))
            {
                query["JobType"] = request.JobType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTs))
            {
                query["StartTs"] = request.StartTs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTs))
            {
                query["EndTs"] = request.EndTs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TimeZone))
            {
                query["TimeZone"] = request.TimeZone;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<DescribeIceDurPeriodByDaySubTypeResponse>(await DoROARequestAsync("DescribeIceDurPeriodByDaySubType", "2020-12-14", "HTTPS", "POST", "AK", "/api/ice/describeIceDurPeriodByDaySubType", "json", req, runtime));
        }

        public DescribeCallListResponse DescribeCallList(DescribeCallListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeCallListWithOptions(request, headers, runtime);
        }

        public async Task<DescribeCallListResponse> DescribeCallListAsync(DescribeCallListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeCallListWithOptionsAsync(request, headers, runtime);
        }

        public DescribeCallListResponse DescribeCallListWithOptions(DescribeCallListRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTs))
            {
                query["StartTs"] = request.StartTs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTs))
            {
                query["EndTs"] = request.EndTs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelId))
            {
                query["ChannelId"] = request.ChannelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["UserId"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallStatus))
            {
                query["CallStatus"] = request.CallStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderBy))
            {
                query["OrderBy"] = request.OrderBy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueryMode))
            {
                query["QueryMode"] = request.QueryMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNo))
            {
                query["PageNo"] = request.PageNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<DescribeCallListResponse>(DoROARequest("DescribeCallList", "2020-12-14", "HTTPS", "POST", "AK", "/api/call/describeCallList", "json", req, runtime));
        }

        public async Task<DescribeCallListResponse> DescribeCallListWithOptionsAsync(DescribeCallListRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTs))
            {
                query["StartTs"] = request.StartTs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTs))
            {
                query["EndTs"] = request.EndTs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelId))
            {
                query["ChannelId"] = request.ChannelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["UserId"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CallStatus))
            {
                query["CallStatus"] = request.CallStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderBy))
            {
                query["OrderBy"] = request.OrderBy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueryMode))
            {
                query["QueryMode"] = request.QueryMode;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNo))
            {
                query["PageNo"] = request.PageNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<DescribeCallListResponse>(await DoROARequestAsync("DescribeCallList", "2020-12-14", "HTTPS", "POST", "AK", "/api/call/describeCallList", "json", req, runtime));
        }

        public DescribeQualityAreaDistributionStatDataResponse DescribeQualityAreaDistributionStatData(DescribeQualityAreaDistributionStatDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeQualityAreaDistributionStatDataWithOptions(request, headers, runtime);
        }

        public async Task<DescribeQualityAreaDistributionStatDataResponse> DescribeQualityAreaDistributionStatDataAsync(DescribeQualityAreaDistributionStatDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeQualityAreaDistributionStatDataWithOptionsAsync(request, headers, runtime);
        }

        public DescribeQualityAreaDistributionStatDataResponse DescribeQualityAreaDistributionStatDataWithOptions(DescribeQualityAreaDistributionStatDataRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartDate))
            {
                query["StartDate"] = request.StartDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndDate))
            {
                query["EndDate"] = request.EndDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParentArea))
            {
                query["ParentArea"] = request.ParentArea;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<DescribeQualityAreaDistributionStatDataResponse>(DoROARequest("DescribeQualityAreaDistributionStatData", "2020-12-14", "HTTPS", "POST", "AK", "/api/quality/describeQualityAreaDistributionStatData", "json", req, runtime));
        }

        public async Task<DescribeQualityAreaDistributionStatDataResponse> DescribeQualityAreaDistributionStatDataWithOptionsAsync(DescribeQualityAreaDistributionStatDataRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartDate))
            {
                query["StartDate"] = request.StartDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndDate))
            {
                query["EndDate"] = request.EndDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParentArea))
            {
                query["ParentArea"] = request.ParentArea;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<DescribeQualityAreaDistributionStatDataResponse>(await DoROARequestAsync("DescribeQualityAreaDistributionStatData", "2020-12-14", "HTTPS", "POST", "AK", "/api/quality/describeQualityAreaDistributionStatData", "json", req, runtime));
        }

        public DescribeRtcUserEventListResponse DescribeRtcUserEventList(DescribeRtcUserEventListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeRtcUserEventListWithOptions(request, headers, runtime);
        }

        public async Task<DescribeRtcUserEventListResponse> DescribeRtcUserEventListAsync(DescribeRtcUserEventListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeRtcUserEventListWithOptionsAsync(request, headers, runtime);
        }

        public DescribeRtcUserEventListResponse DescribeRtcUserEventListWithOptions(DescribeRtcUserEventListRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelId))
            {
                query["ChannelId"] = request.ChannelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Uid))
            {
                query["Uid"] = request.Uid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<DescribeRtcUserEventListResponse>(DoROARequest("DescribeRtcUserEventList", "2020-12-14", "HTTPS", "POST", "AK", "/api/call/describeRtcUserEventList", "json", req, runtime));
        }

        public async Task<DescribeRtcUserEventListResponse> DescribeRtcUserEventListWithOptionsAsync(DescribeRtcUserEventListRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelId))
            {
                query["ChannelId"] = request.ChannelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Uid))
            {
                query["Uid"] = request.Uid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<DescribeRtcUserEventListResponse>(await DoROARequestAsync("DescribeRtcUserEventList", "2020-12-14", "HTTPS", "POST", "AK", "/api/call/describeRtcUserEventList", "json", req, runtime));
        }

        public DeleteAppExpMetricRuleResponse DeleteAppExpMetricRule(DeleteAppExpMetricRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteAppExpMetricRuleWithOptions(request, headers, runtime);
        }

        public async Task<DeleteAppExpMetricRuleResponse> DeleteAppExpMetricRuleAsync(DeleteAppExpMetricRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteAppExpMetricRuleWithOptionsAsync(request, headers, runtime);
        }

        public DeleteAppExpMetricRuleResponse DeleteAppExpMetricRuleWithOptions(DeleteAppExpMetricRuleRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<DeleteAppExpMetricRuleResponse>(DoROARequest("DeleteAppExpMetricRule", "2020-12-14", "HTTPS", "POST", "AK", "/api/config/deleteAppExpMetricRule", "json", req, runtime));
        }

        public async Task<DeleteAppExpMetricRuleResponse> DeleteAppExpMetricRuleWithOptionsAsync(DeleteAppExpMetricRuleRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<DeleteAppExpMetricRuleResponse>(await DoROARequestAsync("DeleteAppExpMetricRule", "2020-12-14", "HTTPS", "POST", "AK", "/api/config/deleteAppExpMetricRule", "json", req, runtime));
        }

        public DescribeEndPointEventListResponse DescribeEndPointEventList(DescribeEndPointEventListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeEndPointEventListWithOptions(request, headers, runtime);
        }

        public async Task<DescribeEndPointEventListResponse> DescribeEndPointEventListAsync(DescribeEndPointEventListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeEndPointEventListWithOptionsAsync(request, headers, runtime);
        }

        public DescribeEndPointEventListResponse DescribeEndPointEventListWithOptions(DescribeEndPointEventListRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelId))
            {
                query["ChannelId"] = request.ChannelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreatedTs))
            {
                query["CreatedTs"] = request.CreatedTs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestroyedTs))
            {
                query["DestroyedTs"] = request.DestroyedTs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserIdList))
            {
                query["UserIdList"] = request.UserIdList;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<DescribeEndPointEventListResponse>(DoROARequest("DescribeEndPointEventList", "2020-12-14", "HTTPS", "POST", "AK", "/api/call/describeEndPointEventList", "json", req, runtime));
        }

        public async Task<DescribeEndPointEventListResponse> DescribeEndPointEventListWithOptionsAsync(DescribeEndPointEventListRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelId))
            {
                query["ChannelId"] = request.ChannelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreatedTs))
            {
                query["CreatedTs"] = request.CreatedTs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestroyedTs))
            {
                query["DestroyedTs"] = request.DestroyedTs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserIdList))
            {
                query["UserIdList"] = request.UserIdList;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<DescribeEndPointEventListResponse>(await DoROARequestAsync("DescribeEndPointEventList", "2020-12-14", "HTTPS", "POST", "AK", "/api/call/describeEndPointEventList", "json", req, runtime));
        }

        public DescribeQualityDistributionStatDataResponse DescribeQualityDistributionStatData(DescribeQualityDistributionStatDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeQualityDistributionStatDataWithOptions(request, headers, runtime);
        }

        public async Task<DescribeQualityDistributionStatDataResponse> DescribeQualityDistributionStatDataAsync(DescribeQualityDistributionStatDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeQualityDistributionStatDataWithOptionsAsync(request, headers, runtime);
        }

        public DescribeQualityDistributionStatDataResponse DescribeQualityDistributionStatDataWithOptions(DescribeQualityDistributionStatDataRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartDate))
            {
                query["StartDate"] = request.StartDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndDate))
            {
                query["EndDate"] = request.EndDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StatDim))
            {
                query["StatDim"] = request.StatDim;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<DescribeQualityDistributionStatDataResponse>(DoROARequest("DescribeQualityDistributionStatData", "2020-12-14", "HTTPS", "POST", "AK", "/api/quality/describeQualityDistributionStatData", "json", req, runtime));
        }

        public async Task<DescribeQualityDistributionStatDataResponse> DescribeQualityDistributionStatDataWithOptionsAsync(DescribeQualityDistributionStatDataRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartDate))
            {
                query["StartDate"] = request.StartDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndDate))
            {
                query["EndDate"] = request.EndDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StatDim))
            {
                query["StatDim"] = request.StatDim;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<DescribeQualityDistributionStatDataResponse>(await DoROARequestAsync("DescribeQualityDistributionStatData", "2020-12-14", "HTTPS", "POST", "AK", "/api/quality/describeQualityDistributionStatData", "json", req, runtime));
        }

        public DescribeCallListTestResponse DescribeCallListTest(DescribeCallListTestRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeCallListTestWithOptions(request, headers, runtime);
        }

        public async Task<DescribeCallListTestResponse> DescribeCallListTestAsync(DescribeCallListTestRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeCallListTestWithOptionsAsync(request, headers, runtime);
        }

        public DescribeCallListTestResponse DescribeCallListTestWithOptions(DescribeCallListTestRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTs))
            {
                query["StartTs"] = request.StartTs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTs))
            {
                query["EndTs"] = request.EndTs;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<DescribeCallListTestResponse>(DoROARequest("DescribeCallListTest", "2020-12-14", "HTTPS", "POST", "AK", "/api/call/describeCallListTest", "json", req, runtime));
        }

        public async Task<DescribeCallListTestResponse> DescribeCallListTestWithOptionsAsync(DescribeCallListTestRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTs))
            {
                query["StartTs"] = request.StartTs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTs))
            {
                query["EndTs"] = request.EndTs;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<DescribeCallListTestResponse>(await DoROARequestAsync("DescribeCallListTest", "2020-12-14", "HTTPS", "POST", "AK", "/api/call/describeCallListTest", "json", req, runtime));
        }

        public DescribeCallResponse DescribeCall(DescribeCallRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeCallWithOptions(request, headers, runtime);
        }

        public async Task<DescribeCallResponse> DescribeCallAsync(DescribeCallRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeCallWithOptionsAsync(request, headers, runtime);
        }

        public DescribeCallResponse DescribeCallWithOptions(DescribeCallRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelId))
            {
                query["ChannelId"] = request.ChannelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreatedTs))
            {
                query["CreatedTs"] = request.CreatedTs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestroyedTs))
            {
                query["DestroyedTs"] = request.DestroyedTs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtDataType))
            {
                query["ExtDataType"] = request.ExtDataType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueryExpInfo))
            {
                query["QueryExpInfo"] = request.QueryExpInfo;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<DescribeCallResponse>(DoROARequest("DescribeCall", "2020-12-14", "HTTPS", "POST", "AK", "/api/call/describeCall", "json", req, runtime));
        }

        public async Task<DescribeCallResponse> DescribeCallWithOptionsAsync(DescribeCallRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelId))
            {
                query["ChannelId"] = request.ChannelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreatedTs))
            {
                query["CreatedTs"] = request.CreatedTs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestroyedTs))
            {
                query["DestroyedTs"] = request.DestroyedTs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtDataType))
            {
                query["ExtDataType"] = request.ExtDataType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueryExpInfo))
            {
                query["QueryExpInfo"] = request.QueryExpInfo;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<DescribeCallResponse>(await DoROARequestAsync("DescribeCall", "2020-12-14", "HTTPS", "POST", "AK", "/api/call/describeCall", "json", req, runtime));
        }

        public DescribeAppFollowCallRuleListResponse DescribeAppFollowCallRuleList()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeAppFollowCallRuleListWithOptions(headers, runtime);
        }

        public async Task<DescribeAppFollowCallRuleListResponse> DescribeAppFollowCallRuleListAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeAppFollowCallRuleListWithOptionsAsync(headers, runtime);
        }

        public DescribeAppFollowCallRuleListResponse DescribeAppFollowCallRuleListWithOptions(Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<DescribeAppFollowCallRuleListResponse>(DoROARequest("DescribeAppFollowCallRuleList", "2020-12-14", "HTTPS", "POST", "AK", "/api/config/describeAppFollowCallRuleList", "json", req, runtime));
        }

        public async Task<DescribeAppFollowCallRuleListResponse> DescribeAppFollowCallRuleListWithOptionsAsync(Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<DescribeAppFollowCallRuleListResponse>(await DoROARequestAsync("DescribeAppFollowCallRuleList", "2020-12-14", "HTTPS", "POST", "AK", "/api/config/describeAppFollowCallRuleList", "json", req, runtime));
        }

        public DescribeChannelAreaDistributionStatDataResponse DescribeChannelAreaDistributionStatData(DescribeChannelAreaDistributionStatDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeChannelAreaDistributionStatDataWithOptions(request, headers, runtime);
        }

        public async Task<DescribeChannelAreaDistributionStatDataResponse> DescribeChannelAreaDistributionStatDataAsync(DescribeChannelAreaDistributionStatDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeChannelAreaDistributionStatDataWithOptionsAsync(request, headers, runtime);
        }

        public DescribeChannelAreaDistributionStatDataResponse DescribeChannelAreaDistributionStatDataWithOptions(DescribeChannelAreaDistributionStatDataRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelId))
            {
                query["ChannelId"] = request.ChannelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreatedTs))
            {
                query["CreatedTs"] = request.CreatedTs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestroyedTs))
            {
                query["DestroyedTs"] = request.DestroyedTs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParentArea))
            {
                query["ParentArea"] = request.ParentArea;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<DescribeChannelAreaDistributionStatDataResponse>(DoROARequest("DescribeChannelAreaDistributionStatData", "2020-12-14", "HTTPS", "POST", "AK", "/api/channel/describeChannelAreaDistributionStatData", "json", req, runtime));
        }

        public async Task<DescribeChannelAreaDistributionStatDataResponse> DescribeChannelAreaDistributionStatDataWithOptionsAsync(DescribeChannelAreaDistributionStatDataRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelId))
            {
                query["ChannelId"] = request.ChannelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreatedTs))
            {
                query["CreatedTs"] = request.CreatedTs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestroyedTs))
            {
                query["DestroyedTs"] = request.DestroyedTs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParentArea))
            {
                query["ParentArea"] = request.ParentArea;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<DescribeChannelAreaDistributionStatDataResponse>(await DoROARequestAsync("DescribeChannelAreaDistributionStatData", "2020-12-14", "HTTPS", "POST", "AK", "/api/channel/describeChannelAreaDistributionStatData", "json", req, runtime));
        }

        public DescribeAppExpMetricRuleResponse DescribeAppExpMetricRule(DescribeAppExpMetricRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeAppExpMetricRuleWithOptions(request, headers, runtime);
        }

        public async Task<DescribeAppExpMetricRuleResponse> DescribeAppExpMetricRuleAsync(DescribeAppExpMetricRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeAppExpMetricRuleWithOptionsAsync(request, headers, runtime);
        }

        public DescribeAppExpMetricRuleResponse DescribeAppExpMetricRuleWithOptions(DescribeAppExpMetricRuleRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<DescribeAppExpMetricRuleResponse>(DoROARequest("DescribeAppExpMetricRule", "2020-12-14", "HTTPS", "POST", "AK", "/api/config/describeAppExpMetricRule", "json", req, runtime));
        }

        public async Task<DescribeAppExpMetricRuleResponse> DescribeAppExpMetricRuleWithOptionsAsync(DescribeAppExpMetricRuleRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<DescribeAppExpMetricRuleResponse>(await DoROARequestAsync("DescribeAppExpMetricRule", "2020-12-14", "HTTPS", "POST", "AK", "/api/config/describeAppExpMetricRule", "json", req, runtime));
        }

        public DescribeRtcChannelDetailsResponse DescribeRtcChannelDetails(DescribeRtcChannelDetailsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeRtcChannelDetailsWithOptions(request, headers, runtime);
        }

        public async Task<DescribeRtcChannelDetailsResponse> DescribeRtcChannelDetailsAsync(DescribeRtcChannelDetailsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeRtcChannelDetailsWithOptionsAsync(request, headers, runtime);
        }

        public DescribeRtcChannelDetailsResponse DescribeRtcChannelDetailsWithOptions(DescribeRtcChannelDetailsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelId))
            {
                query["ChannelId"] = request.ChannelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNo))
            {
                query["PageNo"] = request.PageNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<DescribeRtcChannelDetailsResponse>(DoROARequest("DescribeRtcChannelDetails", "2020-12-14", "HTTPS", "POST", "AK", "/api/channel/describeRtcChannelDetails", "json", req, runtime));
        }

        public async Task<DescribeRtcChannelDetailsResponse> DescribeRtcChannelDetailsWithOptionsAsync(DescribeRtcChannelDetailsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelId))
            {
                query["ChannelId"] = request.ChannelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNo))
            {
                query["PageNo"] = request.PageNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<DescribeRtcChannelDetailsResponse>(await DoROARequestAsync("DescribeRtcChannelDetails", "2020-12-14", "HTTPS", "POST", "AK", "/api/channel/describeRtcChannelDetails", "json", req, runtime));
        }

        public DescribeIceDurSummaryOverviewResponse DescribeIceDurSummaryOverview(DescribeIceDurSummaryOverviewRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeIceDurSummaryOverviewWithOptions(request, headers, runtime);
        }

        public async Task<DescribeIceDurSummaryOverviewResponse> DescribeIceDurSummaryOverviewAsync(DescribeIceDurSummaryOverviewRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeIceDurSummaryOverviewWithOptionsAsync(request, headers, runtime);
        }

        public DescribeIceDurSummaryOverviewResponse DescribeIceDurSummaryOverviewWithOptions(DescribeIceDurSummaryOverviewRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurTs))
            {
                query["CurTs"] = request.CurTs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TimeZone))
            {
                query["TimeZone"] = request.TimeZone;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<DescribeIceDurSummaryOverviewResponse>(DoROARequest("DescribeIceDurSummaryOverview", "2020-12-14", "HTTPS", "POST", "AK", "/api/ice/describeIceDurSummaryOverview", "json", req, runtime));
        }

        public async Task<DescribeIceDurSummaryOverviewResponse> DescribeIceDurSummaryOverviewWithOptionsAsync(DescribeIceDurSummaryOverviewRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurTs))
            {
                query["CurTs"] = request.CurTs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TimeZone))
            {
                query["TimeZone"] = request.TimeZone;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<DescribeIceDurSummaryOverviewResponse>(await DoROARequestAsync("DescribeIceDurSummaryOverview", "2020-12-14", "HTTPS", "POST", "AK", "/api/ice/describeIceDurSummaryOverview", "json", req, runtime));
        }

        public DescribeCallUserExpResponse DescribeCallUserExp(DescribeCallUserExpRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeCallUserExpWithOptions(request, headers, runtime);
        }

        public async Task<DescribeCallUserExpResponse> DescribeCallUserExpAsync(DescribeCallUserExpRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeCallUserExpWithOptionsAsync(request, headers, runtime);
        }

        public DescribeCallUserExpResponse DescribeCallUserExpWithOptions(DescribeCallUserExpRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelId))
            {
                query["ChannelId"] = request.ChannelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreatedTs))
            {
                query["CreatedTs"] = request.CreatedTs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestroyedTs))
            {
                query["DestroyedTs"] = request.DestroyedTs;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<DescribeCallUserExpResponse>(DoROARequest("DescribeCallUserExp", "2020-12-14", "HTTPS", "POST", "AK", "/api/call/describeCallUserExp", "json", req, runtime));
        }

        public async Task<DescribeCallUserExpResponse> DescribeCallUserExpWithOptionsAsync(DescribeCallUserExpRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelId))
            {
                query["ChannelId"] = request.ChannelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreatedTs))
            {
                query["CreatedTs"] = request.CreatedTs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestroyedTs))
            {
                query["DestroyedTs"] = request.DestroyedTs;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<DescribeCallUserExpResponse>(await DoROARequestAsync("DescribeCallUserExp", "2020-12-14", "HTTPS", "POST", "AK", "/api/call/describeCallUserExp", "json", req, runtime));
        }

        public DescribeChannelJoinInfoResponse DescribeChannelJoinInfo(DescribeChannelJoinInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeChannelJoinInfoWithOptions(request, headers, runtime);
        }

        public async Task<DescribeChannelJoinInfoResponse> DescribeChannelJoinInfoAsync(DescribeChannelJoinInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeChannelJoinInfoWithOptionsAsync(request, headers, runtime);
        }

        public DescribeChannelJoinInfoResponse DescribeChannelJoinInfoWithOptions(DescribeChannelJoinInfoRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelId))
            {
                query["ChannelId"] = request.ChannelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreatedTs))
            {
                query["CreatedTs"] = request.CreatedTs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestroyedTs))
            {
                query["DestroyedTs"] = request.DestroyedTs;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<DescribeChannelJoinInfoResponse>(DoROARequest("DescribeChannelJoinInfo", "2020-12-14", "HTTPS", "POST", "AK", "/api/channel/describeChannelJoinInfo", "json", req, runtime));
        }

        public async Task<DescribeChannelJoinInfoResponse> DescribeChannelJoinInfoWithOptionsAsync(DescribeChannelJoinInfoRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelId))
            {
                query["ChannelId"] = request.ChannelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreatedTs))
            {
                query["CreatedTs"] = request.CreatedTs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestroyedTs))
            {
                query["DestroyedTs"] = request.DestroyedTs;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<DescribeChannelJoinInfoResponse>(await DoROARequestAsync("DescribeChannelJoinInfo", "2020-12-14", "HTTPS", "POST", "AK", "/api/channel/describeChannelJoinInfo", "json", req, runtime));
        }

        public DeleteAppFollowCallRuleResponse DeleteAppFollowCallRule(DeleteAppFollowCallRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteAppFollowCallRuleWithOptions(request, headers, runtime);
        }

        public async Task<DeleteAppFollowCallRuleResponse> DeleteAppFollowCallRuleAsync(DeleteAppFollowCallRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteAppFollowCallRuleWithOptionsAsync(request, headers, runtime);
        }

        public DeleteAppFollowCallRuleResponse DeleteAppFollowCallRuleWithOptions(DeleteAppFollowCallRuleRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<DeleteAppFollowCallRuleResponse>(DoROARequest("DeleteAppFollowCallRule", "2020-12-14", "HTTPS", "POST", "AK", "/api/config/deleteAppFollowCallRule", "json", req, runtime));
        }

        public async Task<DeleteAppFollowCallRuleResponse> DeleteAppFollowCallRuleWithOptionsAsync(DeleteAppFollowCallRuleRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<DeleteAppFollowCallRuleResponse>(await DoROARequestAsync("DeleteAppFollowCallRule", "2020-12-14", "HTTPS", "POST", "AK", "/api/config/deleteAppFollowCallRule", "json", req, runtime));
        }

        public DescribeAppExpMetricRuleListResponse DescribeAppExpMetricRuleList()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeAppExpMetricRuleListWithOptions(headers, runtime);
        }

        public async Task<DescribeAppExpMetricRuleListResponse> DescribeAppExpMetricRuleListAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeAppExpMetricRuleListWithOptionsAsync(headers, runtime);
        }

        public DescribeAppExpMetricRuleListResponse DescribeAppExpMetricRuleListWithOptions(Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<DescribeAppExpMetricRuleListResponse>(DoROARequest("DescribeAppExpMetricRuleList", "2020-12-14", "HTTPS", "POST", "AK", "/api/config/describeAppExpMetricRuleList", "json", req, runtime));
        }

        public async Task<DescribeAppExpMetricRuleListResponse> DescribeAppExpMetricRuleListWithOptionsAsync(Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            return TeaModel.ToObject<DescribeAppExpMetricRuleListResponse>(await DoROARequestAsync("DescribeAppExpMetricRuleList", "2020-12-14", "HTTPS", "POST", "AK", "/api/config/describeAppExpMetricRuleList", "json", req, runtime));
        }

        public DescribeChannelTopPubUserListResponse DescribeChannelTopPubUserList(DescribeChannelTopPubUserListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeChannelTopPubUserListWithOptions(request, headers, runtime);
        }

        public async Task<DescribeChannelTopPubUserListResponse> DescribeChannelTopPubUserListAsync(DescribeChannelTopPubUserListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeChannelTopPubUserListWithOptionsAsync(request, headers, runtime);
        }

        public DescribeChannelTopPubUserListResponse DescribeChannelTopPubUserListWithOptions(DescribeChannelTopPubUserListRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelId))
            {
                query["ChannelId"] = request.ChannelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreatedTs))
            {
                query["CreatedTs"] = request.CreatedTs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestroyedTs))
            {
                query["DestroyedTs"] = request.DestroyedTs;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<DescribeChannelTopPubUserListResponse>(DoROARequest("DescribeChannelTopPubUserList", "2020-12-14", "HTTPS", "POST", "AK", "/api/channel/describeChannelTopPubUserList", "json", req, runtime));
        }

        public async Task<DescribeChannelTopPubUserListResponse> DescribeChannelTopPubUserListWithOptionsAsync(DescribeChannelTopPubUserListRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelId))
            {
                query["ChannelId"] = request.ChannelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreatedTs))
            {
                query["CreatedTs"] = request.CreatedTs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestroyedTs))
            {
                query["DestroyedTs"] = request.DestroyedTs;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<DescribeChannelTopPubUserListResponse>(await DoROARequestAsync("DescribeChannelTopPubUserList", "2020-12-14", "HTTPS", "POST", "AK", "/api/channel/describeChannelTopPubUserList", "json", req, runtime));
        }

        public DescribeAppFollowCallRuleResponse DescribeAppFollowCallRule(DescribeAppFollowCallRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeAppFollowCallRuleWithOptions(request, headers, runtime);
        }

        public async Task<DescribeAppFollowCallRuleResponse> DescribeAppFollowCallRuleAsync(DescribeAppFollowCallRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeAppFollowCallRuleWithOptionsAsync(request, headers, runtime);
        }

        public DescribeAppFollowCallRuleResponse DescribeAppFollowCallRuleWithOptions(DescribeAppFollowCallRuleRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<DescribeAppFollowCallRuleResponse>(DoROARequest("DescribeAppFollowCallRule", "2020-12-14", "HTTPS", "POST", "AK", "/api/config/describeAppFollowCallRule", "json", req, runtime));
        }

        public async Task<DescribeAppFollowCallRuleResponse> DescribeAppFollowCallRuleWithOptionsAsync(DescribeAppFollowCallRuleRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<DescribeAppFollowCallRuleResponse>(await DoROARequestAsync("DescribeAppFollowCallRule", "2020-12-14", "HTTPS", "POST", "AK", "/api/config/describeAppFollowCallRule", "json", req, runtime));
        }

        public DescribeUsageDistributionStatDataResponse DescribeUsageDistributionStatData(DescribeUsageDistributionStatDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeUsageDistributionStatDataWithOptions(request, headers, runtime);
        }

        public async Task<DescribeUsageDistributionStatDataResponse> DescribeUsageDistributionStatDataAsync(DescribeUsageDistributionStatDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeUsageDistributionStatDataWithOptionsAsync(request, headers, runtime);
        }

        public DescribeUsageDistributionStatDataResponse DescribeUsageDistributionStatDataWithOptions(DescribeUsageDistributionStatDataRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartDate))
            {
                query["StartDate"] = request.StartDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndDate))
            {
                query["EndDate"] = request.EndDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StatDim))
            {
                query["StatDim"] = request.StatDim;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<DescribeUsageDistributionStatDataResponse>(DoROARequest("DescribeUsageDistributionStatData", "2020-12-14", "HTTPS", "POST", "AK", "/api/usage/describeUsageDistributionStatData", "json", req, runtime));
        }

        public async Task<DescribeUsageDistributionStatDataResponse> DescribeUsageDistributionStatDataWithOptionsAsync(DescribeUsageDistributionStatDataRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartDate))
            {
                query["StartDate"] = request.StartDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndDate))
            {
                query["EndDate"] = request.EndDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StatDim))
            {
                query["StatDim"] = request.StatDim;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<DescribeUsageDistributionStatDataResponse>(await DoROARequestAsync("DescribeUsageDistributionStatData", "2020-12-14", "HTTPS", "POST", "AK", "/api/usage/describeUsageDistributionStatData", "json", req, runtime));
        }

        public DescribeUsageAreaDistributionStatDataResponse DescribeUsageAreaDistributionStatData(DescribeUsageAreaDistributionStatDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeUsageAreaDistributionStatDataWithOptions(request, headers, runtime);
        }

        public async Task<DescribeUsageAreaDistributionStatDataResponse> DescribeUsageAreaDistributionStatDataAsync(DescribeUsageAreaDistributionStatDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeUsageAreaDistributionStatDataWithOptionsAsync(request, headers, runtime);
        }

        public DescribeUsageAreaDistributionStatDataResponse DescribeUsageAreaDistributionStatDataWithOptions(DescribeUsageAreaDistributionStatDataRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartDate))
            {
                query["StartDate"] = request.StartDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndDate))
            {
                query["EndDate"] = request.EndDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParentArea))
            {
                query["ParentArea"] = request.ParentArea;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<DescribeUsageAreaDistributionStatDataResponse>(DoROARequest("DescribeUsageAreaDistributionStatData", "2020-12-14", "HTTPS", "POST", "AK", "/api/usage/describeUsageAreaDistributionStatData", "json", req, runtime));
        }

        public async Task<DescribeUsageAreaDistributionStatDataResponse> DescribeUsageAreaDistributionStatDataWithOptionsAsync(DescribeUsageAreaDistributionStatDataRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartDate))
            {
                query["StartDate"] = request.StartDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndDate))
            {
                query["EndDate"] = request.EndDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ParentArea))
            {
                query["ParentArea"] = request.ParentArea;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<DescribeUsageAreaDistributionStatDataResponse>(await DoROARequestAsync("DescribeUsageAreaDistributionStatData", "2020-12-14", "HTTPS", "POST", "AK", "/api/usage/describeUsageAreaDistributionStatData", "json", req, runtime));
        }

        public DescribeEndPointMetricDataResponse DescribeEndPointMetricData(DescribeEndPointMetricDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeEndPointMetricDataWithOptions(request, headers, runtime);
        }

        public async Task<DescribeEndPointMetricDataResponse> DescribeEndPointMetricDataAsync(DescribeEndPointMetricDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeEndPointMetricDataWithOptionsAsync(request, headers, runtime);
        }

        public DescribeEndPointMetricDataResponse DescribeEndPointMetricDataWithOptions(DescribeEndPointMetricDataRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelId))
            {
                query["ChannelId"] = request.ChannelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreatedTs))
            {
                query["CreatedTs"] = request.CreatedTs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestroyedTs))
            {
                query["DestroyedTs"] = request.DestroyedTs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubUserId))
            {
                query["SubUserId"] = request.SubUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PubUserId))
            {
                query["PubUserId"] = request.PubUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PubCallIdList))
            {
                query["PubCallIdList"] = request.PubCallIdList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Metrics))
            {
                query["Metrics"] = request.Metrics;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<DescribeEndPointMetricDataResponse>(DoROARequest("DescribeEndPointMetricData", "2020-12-14", "HTTPS", "POST", "AK", "/api/call/describeEndPointMetricData", "json", req, runtime));
        }

        public async Task<DescribeEndPointMetricDataResponse> DescribeEndPointMetricDataWithOptionsAsync(DescribeEndPointMetricDataRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelId))
            {
                query["ChannelId"] = request.ChannelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreatedTs))
            {
                query["CreatedTs"] = request.CreatedTs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestroyedTs))
            {
                query["DestroyedTs"] = request.DestroyedTs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubUserId))
            {
                query["SubUserId"] = request.SubUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PubUserId))
            {
                query["PubUserId"] = request.PubUserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PubCallIdList))
            {
                query["PubCallIdList"] = request.PubCallIdList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Metrics))
            {
                query["Metrics"] = request.Metrics;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<DescribeEndPointMetricDataResponse>(await DoROARequestAsync("DescribeEndPointMetricData", "2020-12-14", "HTTPS", "POST", "AK", "/api/call/describeEndPointMetricData", "json", req, runtime));
        }

        public DescribeAppConfigResponse DescribeAppConfig(DescribeAppConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeAppConfigWithOptions(request, headers, runtime);
        }

        public async Task<DescribeAppConfigResponse> DescribeAppConfigAsync(DescribeAppConfigRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeAppConfigWithOptionsAsync(request, headers, runtime);
        }

        public DescribeAppConfigResponse DescribeAppConfigWithOptions(DescribeAppConfigRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<DescribeAppConfigResponse>(DoROARequest("DescribeAppConfig", "2020-12-14", "HTTPS", "POST", "AK", "/api/config/describeAppConfig", "json", req, runtime));
        }

        public async Task<DescribeAppConfigResponse> DescribeAppConfigWithOptionsAsync(DescribeAppConfigRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<DescribeAppConfigResponse>(await DoROARequestAsync("DescribeAppConfig", "2020-12-14", "HTTPS", "POST", "AK", "/api/config/describeAppConfig", "json", req, runtime));
        }

        public DescribeUsageOverallDataResponse DescribeUsageOverallData(DescribeUsageOverallDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeUsageOverallDataWithOptions(request, headers, runtime);
        }

        public async Task<DescribeUsageOverallDataResponse> DescribeUsageOverallDataAsync(DescribeUsageOverallDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeUsageOverallDataWithOptionsAsync(request, headers, runtime);
        }

        public DescribeUsageOverallDataResponse DescribeUsageOverallDataWithOptions(DescribeUsageOverallDataRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartDate))
            {
                query["StartDate"] = request.StartDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndDate))
            {
                query["EndDate"] = request.EndDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Types))
            {
                query["Types"] = request.Types;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<DescribeUsageOverallDataResponse>(DoROARequest("DescribeUsageOverallData", "2020-12-14", "HTTPS", "POST", "AK", "/api/usage/describeUsageOverallData", "json", req, runtime));
        }

        public async Task<DescribeUsageOverallDataResponse> DescribeUsageOverallDataWithOptionsAsync(DescribeUsageOverallDataRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartDate))
            {
                query["StartDate"] = request.StartDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndDate))
            {
                query["EndDate"] = request.EndDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Types))
            {
                query["Types"] = request.Types;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<DescribeUsageOverallDataResponse>(await DoROARequestAsync("DescribeUsageOverallData", "2020-12-14", "HTTPS", "POST", "AK", "/api/usage/describeUsageOverallData", "json", req, runtime));
        }

        public UpdateAppExpMetricRuleResponse UpdateAppExpMetricRule(UpdateAppExpMetricRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateAppExpMetricRuleWithOptions(request, headers, runtime);
        }

        public async Task<UpdateAppExpMetricRuleResponse> UpdateAppExpMetricRuleAsync(UpdateAppExpMetricRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateAppExpMetricRuleWithOptionsAsync(request, headers, runtime);
        }

        public UpdateAppExpMetricRuleResponse UpdateAppExpMetricRuleWithOptions(UpdateAppExpMetricRuleRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Rule))
            {
                query["Rule"] = request.Rule;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<UpdateAppExpMetricRuleResponse>(DoROARequest("UpdateAppExpMetricRule", "2020-12-14", "HTTPS", "POST", "AK", "/api/config/updateAppExpMetricRule", "json", req, runtime));
        }

        public async Task<UpdateAppExpMetricRuleResponse> UpdateAppExpMetricRuleWithOptionsAsync(UpdateAppExpMetricRuleRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Rule))
            {
                query["Rule"] = request.Rule;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<UpdateAppExpMetricRuleResponse>(await DoROARequestAsync("UpdateAppExpMetricRule", "2020-12-14", "HTTPS", "POST", "AK", "/api/config/updateAppExpMetricRule", "json", req, runtime));
        }

        public DescribeFaultDiagnosisUserDetailResponse DescribeFaultDiagnosisUserDetail(DescribeFaultDiagnosisUserDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeFaultDiagnosisUserDetailWithOptions(request, headers, runtime);
        }

        public async Task<DescribeFaultDiagnosisUserDetailResponse> DescribeFaultDiagnosisUserDetailAsync(DescribeFaultDiagnosisUserDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeFaultDiagnosisUserDetailWithOptionsAsync(request, headers, runtime);
        }

        public DescribeFaultDiagnosisUserDetailResponse DescribeFaultDiagnosisUserDetailWithOptions(DescribeFaultDiagnosisUserDetailRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelId))
            {
                query["ChannelId"] = request.ChannelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreatedTs))
            {
                query["CreatedTs"] = request.CreatedTs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["UserId"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FaultType))
            {
                query["FaultType"] = request.FaultType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueryCallUserInfo))
            {
                query["QueryCallUserInfo"] = request.QueryCallUserInfo;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<DescribeFaultDiagnosisUserDetailResponse>(DoROARequest("DescribeFaultDiagnosisUserDetail", "2020-12-14", "HTTPS", "POST", "AK", "/api/diagnosis/describeFaultDiagnosisUserDetail", "json", req, runtime));
        }

        public async Task<DescribeFaultDiagnosisUserDetailResponse> DescribeFaultDiagnosisUserDetailWithOptionsAsync(DescribeFaultDiagnosisUserDetailRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelId))
            {
                query["ChannelId"] = request.ChannelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreatedTs))
            {
                query["CreatedTs"] = request.CreatedTs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["UserId"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FaultType))
            {
                query["FaultType"] = request.FaultType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueryCallUserInfo))
            {
                query["QueryCallUserInfo"] = request.QueryCallUserInfo;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<DescribeFaultDiagnosisUserDetailResponse>(await DoROARequestAsync("DescribeFaultDiagnosisUserDetail", "2020-12-14", "HTTPS", "POST", "AK", "/api/diagnosis/describeFaultDiagnosisUserDetail", "json", req, runtime));
        }

        public DescribeChannelDistributionStatDataResponse DescribeChannelDistributionStatData(DescribeChannelDistributionStatDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeChannelDistributionStatDataWithOptions(request, headers, runtime);
        }

        public async Task<DescribeChannelDistributionStatDataResponse> DescribeChannelDistributionStatDataAsync(DescribeChannelDistributionStatDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeChannelDistributionStatDataWithOptionsAsync(request, headers, runtime);
        }

        public DescribeChannelDistributionStatDataResponse DescribeChannelDistributionStatDataWithOptions(DescribeChannelDistributionStatDataRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelId))
            {
                query["ChannelId"] = request.ChannelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreatedTs))
            {
                query["CreatedTs"] = request.CreatedTs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestroyedTs))
            {
                query["DestroyedTs"] = request.DestroyedTs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StatDim))
            {
                query["StatDim"] = request.StatDim;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<DescribeChannelDistributionStatDataResponse>(DoROARequest("DescribeChannelDistributionStatData", "2020-12-14", "HTTPS", "POST", "AK", "/api/channel/describeChannelDistributionStatData", "json", req, runtime));
        }

        public async Task<DescribeChannelDistributionStatDataResponse> DescribeChannelDistributionStatDataWithOptionsAsync(DescribeChannelDistributionStatDataRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelId))
            {
                query["ChannelId"] = request.ChannelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreatedTs))
            {
                query["CreatedTs"] = request.CreatedTs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestroyedTs))
            {
                query["DestroyedTs"] = request.DestroyedTs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StatDim))
            {
                query["StatDim"] = request.StatDim;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<DescribeChannelDistributionStatDataResponse>(await DoROARequestAsync("DescribeChannelDistributionStatData", "2020-12-14", "HTTPS", "POST", "AK", "/api/channel/describeChannelDistributionStatData", "json", req, runtime));
        }

        public DescribeChannelUserMetricsResponse DescribeChannelUserMetrics(DescribeChannelUserMetricsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeChannelUserMetricsWithOptions(request, headers, runtime);
        }

        public async Task<DescribeChannelUserMetricsResponse> DescribeChannelUserMetricsAsync(DescribeChannelUserMetricsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeChannelUserMetricsWithOptionsAsync(request, headers, runtime);
        }

        public DescribeChannelUserMetricsResponse DescribeChannelUserMetricsWithOptions(DescribeChannelUserMetricsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelId))
            {
                query["ChannelId"] = request.ChannelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreatedTs))
            {
                query["CreatedTs"] = request.CreatedTs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestroyedTs))
            {
                query["DestroyedTs"] = request.DestroyedTs;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<DescribeChannelUserMetricsResponse>(DoROARequest("DescribeChannelUserMetrics", "2020-12-14", "HTTPS", "POST", "AK", "/api/channel/describeChannelUserMetrics", "json", req, runtime));
        }

        public async Task<DescribeChannelUserMetricsResponse> DescribeChannelUserMetricsWithOptionsAsync(DescribeChannelUserMetricsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelId))
            {
                query["ChannelId"] = request.ChannelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreatedTs))
            {
                query["CreatedTs"] = request.CreatedTs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestroyedTs))
            {
                query["DestroyedTs"] = request.DestroyedTs;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<DescribeChannelUserMetricsResponse>(await DoROARequestAsync("DescribeChannelUserMetrics", "2020-12-14", "HTTPS", "POST", "AK", "/api/channel/describeChannelUserMetrics", "json", req, runtime));
        }

        public DescribeFaultDiagnosisFactorDistributionStatResponse DescribeFaultDiagnosisFactorDistributionStat(DescribeFaultDiagnosisFactorDistributionStatRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeFaultDiagnosisFactorDistributionStatWithOptions(request, headers, runtime);
        }

        public async Task<DescribeFaultDiagnosisFactorDistributionStatResponse> DescribeFaultDiagnosisFactorDistributionStatAsync(DescribeFaultDiagnosisFactorDistributionStatRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeFaultDiagnosisFactorDistributionStatWithOptionsAsync(request, headers, runtime);
        }

        public DescribeFaultDiagnosisFactorDistributionStatResponse DescribeFaultDiagnosisFactorDistributionStatWithOptions(DescribeFaultDiagnosisFactorDistributionStatRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTs))
            {
                query["StartTs"] = request.StartTs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTs))
            {
                query["EndTs"] = request.EndTs;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<DescribeFaultDiagnosisFactorDistributionStatResponse>(DoROARequest("DescribeFaultDiagnosisFactorDistributionStat", "2020-12-14", "HTTPS", "POST", "AK", "/api/diagnosis/describeFaultDiagnosisFactorDistributionStat", "json", req, runtime));
        }

        public async Task<DescribeFaultDiagnosisFactorDistributionStatResponse> DescribeFaultDiagnosisFactorDistributionStatWithOptionsAsync(DescribeFaultDiagnosisFactorDistributionStatRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTs))
            {
                query["StartTs"] = request.StartTs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTs))
            {
                query["EndTs"] = request.EndTs;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<DescribeFaultDiagnosisFactorDistributionStatResponse>(await DoROARequestAsync("DescribeFaultDiagnosisFactorDistributionStat", "2020-12-14", "HTTPS", "POST", "AK", "/api/diagnosis/describeFaultDiagnosisFactorDistributionStat", "json", req, runtime));
        }

        public DescribeRtcChannelListResponse DescribeRtcChannelList(DescribeRtcChannelListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeRtcChannelListWithOptions(request, headers, runtime);
        }

        public async Task<DescribeRtcChannelListResponse> DescribeRtcChannelListAsync(DescribeRtcChannelListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeRtcChannelListWithOptionsAsync(request, headers, runtime);
        }

        public DescribeRtcChannelListResponse DescribeRtcChannelListWithOptions(DescribeRtcChannelListRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelId))
            {
                query["ChannelId"] = request.ChannelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNo))
            {
                query["PageNo"] = request.PageNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<DescribeRtcChannelListResponse>(DoROARequest("DescribeRtcChannelList", "2020-12-14", "HTTPS", "POST", "AK", "/api/channel/describeRtcChannelList", "json", req, runtime));
        }

        public async Task<DescribeRtcChannelListResponse> DescribeRtcChannelListWithOptionsAsync(DescribeRtcChannelListRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelId))
            {
                query["ChannelId"] = request.ChannelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNo))
            {
                query["PageNo"] = request.PageNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<DescribeRtcChannelListResponse>(await DoROARequestAsync("DescribeRtcChannelList", "2020-12-14", "HTTPS", "POST", "AK", "/api/channel/describeRtcChannelList", "json", req, runtime));
        }

        public DescribeFaultDiagnosisUserListResponse DescribeFaultDiagnosisUserList(DescribeFaultDiagnosisUserListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeFaultDiagnosisUserListWithOptions(request, headers, runtime);
        }

        public async Task<DescribeFaultDiagnosisUserListResponse> DescribeFaultDiagnosisUserListAsync(DescribeFaultDiagnosisUserListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeFaultDiagnosisUserListWithOptionsAsync(request, headers, runtime);
        }

        public DescribeFaultDiagnosisUserListResponse DescribeFaultDiagnosisUserListWithOptions(DescribeFaultDiagnosisUserListRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTs))
            {
                query["StartTs"] = request.StartTs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTs))
            {
                query["EndTs"] = request.EndTs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelId))
            {
                query["ChannelId"] = request.ChannelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["UserId"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FaultTypes))
            {
                query["FaultTypes"] = request.FaultTypes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNo))
            {
                query["PageNo"] = request.PageNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<DescribeFaultDiagnosisUserListResponse>(DoROARequest("DescribeFaultDiagnosisUserList", "2020-12-14", "HTTPS", "POST", "AK", "/api/diagnosis/describeFaultDiagnosisUserList", "json", req, runtime));
        }

        public async Task<DescribeFaultDiagnosisUserListResponse> DescribeFaultDiagnosisUserListWithOptionsAsync(DescribeFaultDiagnosisUserListRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTs))
            {
                query["StartTs"] = request.StartTs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTs))
            {
                query["EndTs"] = request.EndTs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelId))
            {
                query["ChannelId"] = request.ChannelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["UserId"] = request.UserId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.FaultTypes))
            {
                query["FaultTypes"] = request.FaultTypes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNo))
            {
                query["PageNo"] = request.PageNo;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<DescribeFaultDiagnosisUserListResponse>(await DoROARequestAsync("DescribeFaultDiagnosisUserList", "2020-12-14", "HTTPS", "POST", "AK", "/api/diagnosis/describeFaultDiagnosisUserList", "json", req, runtime));
        }

        public DescribeRtcChannelMetricListResponse DescribeRtcChannelMetricList(DescribeRtcChannelMetricListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeRtcChannelMetricListWithOptions(request, headers, runtime);
        }

        public async Task<DescribeRtcChannelMetricListResponse> DescribeRtcChannelMetricListAsync(DescribeRtcChannelMetricListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeRtcChannelMetricListWithOptionsAsync(request, headers, runtime);
        }

        public DescribeRtcChannelMetricListResponse DescribeRtcChannelMetricListWithOptions(DescribeRtcChannelMetricListRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelId))
            {
                query["ChannelId"] = request.ChannelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PubUid))
            {
                query["PubUid"] = request.PubUid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubUid))
            {
                query["SubUid"] = request.SubUid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<DescribeRtcChannelMetricListResponse>(DoROARequest("DescribeRtcChannelMetricList", "2020-12-14", "HTTPS", "POST", "AK", "/api/call/describeRtcChannelMetricList", "json", req, runtime));
        }

        public async Task<DescribeRtcChannelMetricListResponse> DescribeRtcChannelMetricListWithOptionsAsync(DescribeRtcChannelMetricListRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelId))
            {
                query["ChannelId"] = request.ChannelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PubUid))
            {
                query["PubUid"] = request.PubUid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubUid))
            {
                query["SubUid"] = request.SubUid;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<DescribeRtcChannelMetricListResponse>(await DoROARequestAsync("DescribeRtcChannelMetricList", "2020-12-14", "HTTPS", "POST", "AK", "/api/call/describeRtcChannelMetricList", "json", req, runtime));
        }

        public DescribeQoeMetricDataResponse DescribeQoeMetricData(DescribeQoeMetricDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeQoeMetricDataWithOptions(request, headers, runtime);
        }

        public async Task<DescribeQoeMetricDataResponse> DescribeQoeMetricDataAsync(DescribeQoeMetricDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeQoeMetricDataWithOptionsAsync(request, headers, runtime);
        }

        public DescribeQoeMetricDataResponse DescribeQoeMetricDataWithOptions(DescribeQoeMetricDataRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelId))
            {
                query["ChannelId"] = request.ChannelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreatedTs))
            {
                query["CreatedTs"] = request.CreatedTs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestroyedTs))
            {
                query["DestroyedTs"] = request.DestroyedTs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["UserId"] = request.UserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<DescribeQoeMetricDataResponse>(DoROARequest("DescribeQoeMetricData", "2020-12-14", "HTTPS", "POST", "AK", "/api/call/describeQoeMetricData", "json", req, runtime));
        }

        public async Task<DescribeQoeMetricDataResponse> DescribeQoeMetricDataWithOptionsAsync(DescribeQoeMetricDataRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelId))
            {
                query["ChannelId"] = request.ChannelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreatedTs))
            {
                query["CreatedTs"] = request.CreatedTs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestroyedTs))
            {
                query["DestroyedTs"] = request.DestroyedTs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserId))
            {
                query["UserId"] = request.UserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<DescribeQoeMetricDataResponse>(await DoROARequestAsync("DescribeQoeMetricData", "2020-12-14", "HTTPS", "POST", "AK", "/api/call/describeQoeMetricData", "json", req, runtime));
        }

        public DescribePubUserListBySubUserResponse DescribePubUserListBySubUser(DescribePubUserListBySubUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribePubUserListBySubUserWithOptions(request, headers, runtime);
        }

        public async Task<DescribePubUserListBySubUserResponse> DescribePubUserListBySubUserAsync(DescribePubUserListBySubUserRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribePubUserListBySubUserWithOptionsAsync(request, headers, runtime);
        }

        public DescribePubUserListBySubUserResponse DescribePubUserListBySubUserWithOptions(DescribePubUserListBySubUserRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelId))
            {
                query["ChannelId"] = request.ChannelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreatedTs))
            {
                query["CreatedTs"] = request.CreatedTs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestroyedTs))
            {
                query["DestroyedTs"] = request.DestroyedTs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubUserId))
            {
                query["SubUserId"] = request.SubUserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<DescribePubUserListBySubUserResponse>(DoROARequest("DescribePubUserListBySubUser", "2020-12-14", "HTTPS", "POST", "AK", "/api/call/describePubUserListBySubUser", "json", req, runtime));
        }

        public async Task<DescribePubUserListBySubUserResponse> DescribePubUserListBySubUserWithOptionsAsync(DescribePubUserListBySubUserRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChannelId))
            {
                query["ChannelId"] = request.ChannelId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CreatedTs))
            {
                query["CreatedTs"] = request.CreatedTs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DestroyedTs))
            {
                query["DestroyedTs"] = request.DestroyedTs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubUserId))
            {
                query["SubUserId"] = request.SubUserId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<DescribePubUserListBySubUserResponse>(await DoROARequestAsync("DescribePubUserListBySubUser", "2020-12-14", "HTTPS", "POST", "AK", "/api/call/describePubUserListBySubUser", "json", req, runtime));
        }

        public UpdateAppFollowCallRuleResponse UpdateAppFollowCallRule(UpdateAppFollowCallRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateAppFollowCallRuleWithOptions(request, headers, runtime);
        }

        public async Task<UpdateAppFollowCallRuleResponse> UpdateAppFollowCallRuleAsync(UpdateAppFollowCallRuleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateAppFollowCallRuleWithOptionsAsync(request, headers, runtime);
        }

        public UpdateAppFollowCallRuleResponse UpdateAppFollowCallRuleWithOptions(UpdateAppFollowCallRuleRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Rule))
            {
                query["Rule"] = request.Rule;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<UpdateAppFollowCallRuleResponse>(DoROARequest("UpdateAppFollowCallRule", "2020-12-14", "HTTPS", "POST", "AK", "/api/config/updateAppFollowCallRule", "json", req, runtime));
        }

        public async Task<UpdateAppFollowCallRuleResponse> UpdateAppFollowCallRuleWithOptionsAsync(UpdateAppFollowCallRuleRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Rule))
            {
                query["Rule"] = request.Rule;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<UpdateAppFollowCallRuleResponse>(await DoROARequestAsync("UpdateAppFollowCallRule", "2020-12-14", "HTTPS", "POST", "AK", "/api/config/updateAppFollowCallRule", "json", req, runtime));
        }

        public DescribeQualityOsSdkVersionDistributionStatDataResponse DescribeQualityOsSdkVersionDistributionStatData(DescribeQualityOsSdkVersionDistributionStatDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeQualityOsSdkVersionDistributionStatDataWithOptions(request, headers, runtime);
        }

        public async Task<DescribeQualityOsSdkVersionDistributionStatDataResponse> DescribeQualityOsSdkVersionDistributionStatDataAsync(DescribeQualityOsSdkVersionDistributionStatDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeQualityOsSdkVersionDistributionStatDataWithOptionsAsync(request, headers, runtime);
        }

        public DescribeQualityOsSdkVersionDistributionStatDataResponse DescribeQualityOsSdkVersionDistributionStatDataWithOptions(DescribeQualityOsSdkVersionDistributionStatDataRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartDate))
            {
                query["StartDate"] = request.StartDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndDate))
            {
                query["EndDate"] = request.EndDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<DescribeQualityOsSdkVersionDistributionStatDataResponse>(DoROARequest("DescribeQualityOsSdkVersionDistributionStatData", "2020-12-14", "HTTPS", "POST", "AK", "/api/quality/describeQualityOsSdkVersionDistributionStatData", "json", req, runtime));
        }

        public async Task<DescribeQualityOsSdkVersionDistributionStatDataResponse> DescribeQualityOsSdkVersionDistributionStatDataWithOptionsAsync(DescribeQualityOsSdkVersionDistributionStatDataRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartDate))
            {
                query["StartDate"] = request.StartDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndDate))
            {
                query["EndDate"] = request.EndDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<DescribeQualityOsSdkVersionDistributionStatDataResponse>(await DoROARequestAsync("DescribeQualityOsSdkVersionDistributionStatData", "2020-12-14", "HTTPS", "POST", "AK", "/api/quality/describeQualityOsSdkVersionDistributionStatData", "json", req, runtime));
        }

        public DescribeRtcRecordMetricDataResponse DescribeRtcRecordMetricData(DescribeRtcRecordMetricDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeRtcRecordMetricDataWithOptions(request, headers, runtime);
        }

        public async Task<DescribeRtcRecordMetricDataResponse> DescribeRtcRecordMetricDataAsync(DescribeRtcRecordMetricDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeRtcRecordMetricDataWithOptionsAsync(request, headers, runtime);
        }

        public DescribeRtcRecordMetricDataResponse DescribeRtcRecordMetricDataWithOptions(DescribeRtcRecordMetricDataRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceArea))
            {
                query["ServiceArea"] = request.ServiceArea;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<DescribeRtcRecordMetricDataResponse>(DoROARequest("DescribeRtcRecordMetricData", "2020-12-14", "HTTPS", "POST", "AK", "/api/record/describeRtcRecordMetricData", "json", req, runtime));
        }

        public async Task<DescribeRtcRecordMetricDataResponse> DescribeRtcRecordMetricDataWithOptionsAsync(DescribeRtcRecordMetricDataRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceArea))
            {
                query["ServiceArea"] = request.ServiceArea;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<DescribeRtcRecordMetricDataResponse>(await DoROARequestAsync("DescribeRtcRecordMetricData", "2020-12-14", "HTTPS", "POST", "AK", "/api/record/describeRtcRecordMetricData", "json", req, runtime));
        }

        public DescribeQualityOverallDataResponse DescribeQualityOverallData(DescribeQualityOverallDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DescribeQualityOverallDataWithOptions(request, headers, runtime);
        }

        public async Task<DescribeQualityOverallDataResponse> DescribeQualityOverallDataAsync(DescribeQualityOverallDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DescribeQualityOverallDataWithOptionsAsync(request, headers, runtime);
        }

        public DescribeQualityOverallDataResponse DescribeQualityOverallDataWithOptions(DescribeQualityOverallDataRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartDate))
            {
                query["StartDate"] = request.StartDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndDate))
            {
                query["EndDate"] = request.EndDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Types))
            {
                query["Types"] = request.Types;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<DescribeQualityOverallDataResponse>(DoROARequest("DescribeQualityOverallData", "2020-12-14", "HTTPS", "POST", "AK", "/api/quality/describeQualityOverallData", "json", req, runtime));
        }

        public async Task<DescribeQualityOverallDataResponse> DescribeQualityOverallDataWithOptionsAsync(DescribeQualityOverallDataRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartDate))
            {
                query["StartDate"] = request.StartDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndDate))
            {
                query["EndDate"] = request.EndDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Types))
            {
                query["Types"] = request.Types;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            return TeaModel.ToObject<DescribeQualityOverallDataResponse>(await DoROARequestAsync("DescribeQualityOverallData", "2020-12-14", "HTTPS", "POST", "AK", "/api/quality/describeQualityOverallData", "json", req, runtime));
        }

    }
}
