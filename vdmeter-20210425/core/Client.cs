// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Vdmeter20210425.Models;

namespace AlibabaCloud.SDK.Vdmeter20210425
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "";
            CheckConfig(config);
            this._endpoint = GetEndpoint("vdmeter", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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

        public DescribeHuYaRecordByDomainResponse DescribeHuYaRecordByDomainWithOptions(DescribeHuYaRecordByDomainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BusinessType))
            {
                query["BusinessType"] = request.BusinessType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Domain))
            {
                query["Domain"] = request.Domain;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeHuYaRecordByDomain",
                Version = "2021-04-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeHuYaRecordByDomainResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeHuYaRecordByDomainResponse> DescribeHuYaRecordByDomainWithOptionsAsync(DescribeHuYaRecordByDomainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BusinessType))
            {
                query["BusinessType"] = request.BusinessType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Domain))
            {
                query["Domain"] = request.Domain;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeHuYaRecordByDomain",
                Version = "2021-04-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeHuYaRecordByDomainResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeHuYaRecordByDomainResponse DescribeHuYaRecordByDomain(DescribeHuYaRecordByDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeHuYaRecordByDomainWithOptions(request, runtime);
        }

        public async Task<DescribeHuYaRecordByDomainResponse> DescribeHuYaRecordByDomainAsync(DescribeHuYaRecordByDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeHuYaRecordByDomainWithOptionsAsync(request, runtime);
        }

        public DescribeHuYaScreenshotByDomainResponse DescribeHuYaScreenshotByDomainWithOptions(DescribeHuYaScreenshotByDomainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BusinessType))
            {
                query["BusinessType"] = request.BusinessType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Domain))
            {
                query["Domain"] = request.Domain;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeHuYaScreenshotByDomain",
                Version = "2021-04-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeHuYaScreenshotByDomainResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeHuYaScreenshotByDomainResponse> DescribeHuYaScreenshotByDomainWithOptionsAsync(DescribeHuYaScreenshotByDomainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BusinessType))
            {
                query["BusinessType"] = request.BusinessType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Domain))
            {
                query["Domain"] = request.Domain;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeHuYaScreenshotByDomain",
                Version = "2021-04-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeHuYaScreenshotByDomainResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeHuYaScreenshotByDomainResponse DescribeHuYaScreenshotByDomain(DescribeHuYaScreenshotByDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeHuYaScreenshotByDomainWithOptions(request, runtime);
        }

        public async Task<DescribeHuYaScreenshotByDomainResponse> DescribeHuYaScreenshotByDomainAsync(DescribeHuYaScreenshotByDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeHuYaScreenshotByDomainWithOptionsAsync(request, runtime);
        }

        public DescribeHuYaTranscodeByDomainResponse DescribeHuYaTranscodeByDomainWithOptions(DescribeHuYaTranscodeByDomainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BusinessType))
            {
                query["BusinessType"] = request.BusinessType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Domain))
            {
                query["Domain"] = request.Domain;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeHuYaTranscodeByDomain",
                Version = "2021-04-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeHuYaTranscodeByDomainResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeHuYaTranscodeByDomainResponse> DescribeHuYaTranscodeByDomainWithOptionsAsync(DescribeHuYaTranscodeByDomainRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BusinessType))
            {
                query["BusinessType"] = request.BusinessType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Domain))
            {
                query["Domain"] = request.Domain;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["EndTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["StartTime"] = request.StartTime;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeHuYaTranscodeByDomain",
                Version = "2021-04-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeHuYaTranscodeByDomainResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeHuYaTranscodeByDomainResponse DescribeHuYaTranscodeByDomain(DescribeHuYaTranscodeByDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeHuYaTranscodeByDomainWithOptions(request, runtime);
        }

        public async Task<DescribeHuYaTranscodeByDomainResponse> DescribeHuYaTranscodeByDomainAsync(DescribeHuYaTranscodeByDomainRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeHuYaTranscodeByDomainWithOptionsAsync(request, runtime);
        }

        public DescribeMeterBypassRtUsageByTaskProfileResponse DescribeMeterBypassRtUsageByTaskProfileWithOptions(DescribeMeterBypassRtUsageByTaskProfileRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTs))
            {
                query["EndTs"] = request.EndTs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Interval))
            {
                query["Interval"] = request.Interval;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceArea))
            {
                query["ServiceArea"] = request.ServiceArea;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTs))
            {
                query["StartTs"] = request.StartTs;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeMeterBypassRtUsageByTaskProfile",
                Version = "2021-04-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeMeterBypassRtUsageByTaskProfileResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeMeterBypassRtUsageByTaskProfileResponse> DescribeMeterBypassRtUsageByTaskProfileWithOptionsAsync(DescribeMeterBypassRtUsageByTaskProfileRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTs))
            {
                query["EndTs"] = request.EndTs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Interval))
            {
                query["Interval"] = request.Interval;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceArea))
            {
                query["ServiceArea"] = request.ServiceArea;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTs))
            {
                query["StartTs"] = request.StartTs;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeMeterBypassRtUsageByTaskProfile",
                Version = "2021-04-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeMeterBypassRtUsageByTaskProfileResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeMeterBypassRtUsageByTaskProfileResponse DescribeMeterBypassRtUsageByTaskProfile(DescribeMeterBypassRtUsageByTaskProfileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeMeterBypassRtUsageByTaskProfileWithOptions(request, runtime);
        }

        public async Task<DescribeMeterBypassRtUsageByTaskProfileResponse> DescribeMeterBypassRtUsageByTaskProfileAsync(DescribeMeterBypassRtUsageByTaskProfileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeMeterBypassRtUsageByTaskProfileWithOptionsAsync(request, runtime);
        }

        public DescribeMeterMpuTranscodeRtUsageByTaskProfileResponse DescribeMeterMpuTranscodeRtUsageByTaskProfileWithOptions(DescribeMeterMpuTranscodeRtUsageByTaskProfileRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTs))
            {
                query["EndTs"] = request.EndTs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Interval))
            {
                query["Interval"] = request.Interval;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceArea))
            {
                query["ServiceArea"] = request.ServiceArea;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTs))
            {
                query["StartTs"] = request.StartTs;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeMeterMpuTranscodeRtUsageByTaskProfile",
                Version = "2021-04-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeMeterMpuTranscodeRtUsageByTaskProfileResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeMeterMpuTranscodeRtUsageByTaskProfileResponse> DescribeMeterMpuTranscodeRtUsageByTaskProfileWithOptionsAsync(DescribeMeterMpuTranscodeRtUsageByTaskProfileRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTs))
            {
                query["EndTs"] = request.EndTs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Interval))
            {
                query["Interval"] = request.Interval;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceArea))
            {
                query["ServiceArea"] = request.ServiceArea;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTs))
            {
                query["StartTs"] = request.StartTs;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeMeterMpuTranscodeRtUsageByTaskProfile",
                Version = "2021-04-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeMeterMpuTranscodeRtUsageByTaskProfileResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeMeterMpuTranscodeRtUsageByTaskProfileResponse DescribeMeterMpuTranscodeRtUsageByTaskProfile(DescribeMeterMpuTranscodeRtUsageByTaskProfileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeMeterMpuTranscodeRtUsageByTaskProfileWithOptions(request, runtime);
        }

        public async Task<DescribeMeterMpuTranscodeRtUsageByTaskProfileResponse> DescribeMeterMpuTranscodeRtUsageByTaskProfileAsync(DescribeMeterMpuTranscodeRtUsageByTaskProfileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeMeterMpuTranscodeRtUsageByTaskProfileWithOptionsAsync(request, runtime);
        }

        public DescribeMeterRecordRtUsageByTaskProfileResponse DescribeMeterRecordRtUsageByTaskProfileWithOptions(DescribeMeterRecordRtUsageByTaskProfileRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTs))
            {
                query["EndTs"] = request.EndTs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Interval))
            {
                query["Interval"] = request.Interval;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceArea))
            {
                query["ServiceArea"] = request.ServiceArea;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTs))
            {
                query["StartTs"] = request.StartTs;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeMeterRecordRtUsageByTaskProfile",
                Version = "2021-04-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeMeterRecordRtUsageByTaskProfileResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeMeterRecordRtUsageByTaskProfileResponse> DescribeMeterRecordRtUsageByTaskProfileWithOptionsAsync(DescribeMeterRecordRtUsageByTaskProfileRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTs))
            {
                query["EndTs"] = request.EndTs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Interval))
            {
                query["Interval"] = request.Interval;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceArea))
            {
                query["ServiceArea"] = request.ServiceArea;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTs))
            {
                query["StartTs"] = request.StartTs;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeMeterRecordRtUsageByTaskProfile",
                Version = "2021-04-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeMeterRecordRtUsageByTaskProfileResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeMeterRecordRtUsageByTaskProfileResponse DescribeMeterRecordRtUsageByTaskProfile(DescribeMeterRecordRtUsageByTaskProfileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeMeterRecordRtUsageByTaskProfileWithOptions(request, runtime);
        }

        public async Task<DescribeMeterRecordRtUsageByTaskProfileResponse> DescribeMeterRecordRtUsageByTaskProfileAsync(DescribeMeterRecordRtUsageByTaskProfileRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeMeterRecordRtUsageByTaskProfileWithOptionsAsync(request, runtime);
        }

        public DescribeMeterRtcApproxPeakRateResponse DescribeMeterRtcApproxPeakRateWithOptions(DescribeMeterRtcApproxPeakRateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTs))
            {
                query["EndTs"] = request.EndTs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Interval))
            {
                query["Interval"] = request.Interval;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceArea))
            {
                query["ServiceArea"] = request.ServiceArea;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTs))
            {
                query["StartTs"] = request.StartTs;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeMeterRtcApproxPeakRate",
                Version = "2021-04-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeMeterRtcApproxPeakRateResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeMeterRtcApproxPeakRateResponse> DescribeMeterRtcApproxPeakRateWithOptionsAsync(DescribeMeterRtcApproxPeakRateRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTs))
            {
                query["EndTs"] = request.EndTs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Interval))
            {
                query["Interval"] = request.Interval;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceArea))
            {
                query["ServiceArea"] = request.ServiceArea;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTs))
            {
                query["StartTs"] = request.StartTs;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeMeterRtcApproxPeakRate",
                Version = "2021-04-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeMeterRtcApproxPeakRateResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeMeterRtcApproxPeakRateResponse DescribeMeterRtcApproxPeakRate(DescribeMeterRtcApproxPeakRateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeMeterRtcApproxPeakRateWithOptions(request, runtime);
        }

        public async Task<DescribeMeterRtcApproxPeakRateResponse> DescribeMeterRtcApproxPeakRateAsync(DescribeMeterRtcApproxPeakRateRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeMeterRtcApproxPeakRateWithOptionsAsync(request, runtime);
        }

        public DescribeMeterRtcChannelCntDataResponse DescribeMeterRtcChannelCntDataWithOptions(DescribeMeterRtcChannelCntDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTs))
            {
                query["EndTs"] = request.EndTs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Interval))
            {
                query["Interval"] = request.Interval;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceArea))
            {
                query["ServiceArea"] = request.ServiceArea;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTs))
            {
                query["StartTs"] = request.StartTs;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeMeterRtcChannelCntData",
                Version = "2021-04-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeMeterRtcChannelCntDataResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeMeterRtcChannelCntDataResponse> DescribeMeterRtcChannelCntDataWithOptionsAsync(DescribeMeterRtcChannelCntDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTs))
            {
                query["EndTs"] = request.EndTs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Interval))
            {
                query["Interval"] = request.Interval;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceArea))
            {
                query["ServiceArea"] = request.ServiceArea;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTs))
            {
                query["StartTs"] = request.StartTs;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeMeterRtcChannelCntData",
                Version = "2021-04-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeMeterRtcChannelCntDataResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeMeterRtcChannelCntDataResponse DescribeMeterRtcChannelCntData(DescribeMeterRtcChannelCntDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeMeterRtcChannelCntDataWithOptions(request, runtime);
        }

        public async Task<DescribeMeterRtcChannelCntDataResponse> DescribeMeterRtcChannelCntDataAsync(DescribeMeterRtcChannelCntDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeMeterRtcChannelCntDataWithOptionsAsync(request, runtime);
        }

        public DescribeMeterRtcDurationResponse DescribeMeterRtcDurationWithOptions(DescribeMeterRtcDurationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTs))
            {
                query["EndTs"] = request.EndTs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Interval))
            {
                query["Interval"] = request.Interval;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceArea))
            {
                query["ServiceArea"] = request.ServiceArea;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTs))
            {
                query["StartTs"] = request.StartTs;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeMeterRtcDuration",
                Version = "2021-04-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeMeterRtcDurationResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeMeterRtcDurationResponse> DescribeMeterRtcDurationWithOptionsAsync(DescribeMeterRtcDurationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTs))
            {
                query["EndTs"] = request.EndTs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Interval))
            {
                query["Interval"] = request.Interval;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceArea))
            {
                query["ServiceArea"] = request.ServiceArea;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTs))
            {
                query["StartTs"] = request.StartTs;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeMeterRtcDuration",
                Version = "2021-04-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeMeterRtcDurationResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeMeterRtcDurationResponse DescribeMeterRtcDuration(DescribeMeterRtcDurationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeMeterRtcDurationWithOptions(request, runtime);
        }

        public async Task<DescribeMeterRtcDurationResponse> DescribeMeterRtcDurationAsync(DescribeMeterRtcDurationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeMeterRtcDurationWithOptionsAsync(request, runtime);
        }

        public DescribeMeterRtcPeakChannelCntDataResponse DescribeMeterRtcPeakChannelCntDataWithOptions(DescribeMeterRtcPeakChannelCntDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTs))
            {
                query["EndTs"] = request.EndTs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Interval))
            {
                query["Interval"] = request.Interval;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceArea))
            {
                query["ServiceArea"] = request.ServiceArea;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTs))
            {
                query["StartTs"] = request.StartTs;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeMeterRtcPeakChannelCntData",
                Version = "2021-04-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeMeterRtcPeakChannelCntDataResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeMeterRtcPeakChannelCntDataResponse> DescribeMeterRtcPeakChannelCntDataWithOptionsAsync(DescribeMeterRtcPeakChannelCntDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTs))
            {
                query["EndTs"] = request.EndTs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Interval))
            {
                query["Interval"] = request.Interval;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceArea))
            {
                query["ServiceArea"] = request.ServiceArea;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTs))
            {
                query["StartTs"] = request.StartTs;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeMeterRtcPeakChannelCntData",
                Version = "2021-04-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeMeterRtcPeakChannelCntDataResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeMeterRtcPeakChannelCntDataResponse DescribeMeterRtcPeakChannelCntData(DescribeMeterRtcPeakChannelCntDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeMeterRtcPeakChannelCntDataWithOptions(request, runtime);
        }

        public async Task<DescribeMeterRtcPeakChannelCntDataResponse> DescribeMeterRtcPeakChannelCntDataAsync(DescribeMeterRtcPeakChannelCntDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeMeterRtcPeakChannelCntDataWithOptionsAsync(request, runtime);
        }

        public DescribeMeterRtcPeakUserCntDataResponse DescribeMeterRtcPeakUserCntDataWithOptions(DescribeMeterRtcPeakUserCntDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTs))
            {
                query["EndTs"] = request.EndTs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Interval))
            {
                query["Interval"] = request.Interval;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceArea))
            {
                query["ServiceArea"] = request.ServiceArea;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTs))
            {
                query["StartTs"] = request.StartTs;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeMeterRtcPeakUserCntData",
                Version = "2021-04-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeMeterRtcPeakUserCntDataResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeMeterRtcPeakUserCntDataResponse> DescribeMeterRtcPeakUserCntDataWithOptionsAsync(DescribeMeterRtcPeakUserCntDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTs))
            {
                query["EndTs"] = request.EndTs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Interval))
            {
                query["Interval"] = request.Interval;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceArea))
            {
                query["ServiceArea"] = request.ServiceArea;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTs))
            {
                query["StartTs"] = request.StartTs;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeMeterRtcPeakUserCntData",
                Version = "2021-04-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeMeterRtcPeakUserCntDataResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeMeterRtcPeakUserCntDataResponse DescribeMeterRtcPeakUserCntData(DescribeMeterRtcPeakUserCntDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeMeterRtcPeakUserCntDataWithOptions(request, runtime);
        }

        public async Task<DescribeMeterRtcPeakUserCntDataResponse> DescribeMeterRtcPeakUserCntDataAsync(DescribeMeterRtcPeakUserCntDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeMeterRtcPeakUserCntDataWithOptionsAsync(request, runtime);
        }

        public DescribeMeterRtcRtBandWidthUsageResponse DescribeMeterRtcRtBandWidthUsageWithOptions(DescribeMeterRtcRtBandWidthUsageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTs))
            {
                query["EndTs"] = request.EndTs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Interval))
            {
                query["Interval"] = request.Interval;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceArea))
            {
                query["ServiceArea"] = request.ServiceArea;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTs))
            {
                query["StartTs"] = request.StartTs;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeMeterRtcRtBandWidthUsage",
                Version = "2021-04-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeMeterRtcRtBandWidthUsageResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeMeterRtcRtBandWidthUsageResponse> DescribeMeterRtcRtBandWidthUsageWithOptionsAsync(DescribeMeterRtcRtBandWidthUsageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTs))
            {
                query["EndTs"] = request.EndTs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Interval))
            {
                query["Interval"] = request.Interval;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceArea))
            {
                query["ServiceArea"] = request.ServiceArea;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTs))
            {
                query["StartTs"] = request.StartTs;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeMeterRtcRtBandWidthUsage",
                Version = "2021-04-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeMeterRtcRtBandWidthUsageResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeMeterRtcRtBandWidthUsageResponse DescribeMeterRtcRtBandWidthUsage(DescribeMeterRtcRtBandWidthUsageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeMeterRtcRtBandWidthUsageWithOptions(request, runtime);
        }

        public async Task<DescribeMeterRtcRtBandWidthUsageResponse> DescribeMeterRtcRtBandWidthUsageAsync(DescribeMeterRtcRtBandWidthUsageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeMeterRtcRtBandWidthUsageWithOptionsAsync(request, runtime);
        }

        public DescribeMeterRtcRtFlowUsageResponse DescribeMeterRtcRtFlowUsageWithOptions(DescribeMeterRtcRtFlowUsageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTs))
            {
                query["EndTs"] = request.EndTs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Interval))
            {
                query["Interval"] = request.Interval;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceArea))
            {
                query["ServiceArea"] = request.ServiceArea;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTs))
            {
                query["StartTs"] = request.StartTs;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeMeterRtcRtFlowUsage",
                Version = "2021-04-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeMeterRtcRtFlowUsageResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeMeterRtcRtFlowUsageResponse> DescribeMeterRtcRtFlowUsageWithOptionsAsync(DescribeMeterRtcRtFlowUsageRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTs))
            {
                query["EndTs"] = request.EndTs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Interval))
            {
                query["Interval"] = request.Interval;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceArea))
            {
                query["ServiceArea"] = request.ServiceArea;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTs))
            {
                query["StartTs"] = request.StartTs;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeMeterRtcRtFlowUsage",
                Version = "2021-04-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeMeterRtcRtFlowUsageResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeMeterRtcRtFlowUsageResponse DescribeMeterRtcRtFlowUsage(DescribeMeterRtcRtFlowUsageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeMeterRtcRtFlowUsageWithOptions(request, runtime);
        }

        public async Task<DescribeMeterRtcRtFlowUsageResponse> DescribeMeterRtcRtFlowUsageAsync(DescribeMeterRtcRtFlowUsageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeMeterRtcRtFlowUsageWithOptionsAsync(request, runtime);
        }

        public DescribeMeterRtcUserCntDataResponse DescribeMeterRtcUserCntDataWithOptions(DescribeMeterRtcUserCntDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTs))
            {
                query["EndTs"] = request.EndTs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Interval))
            {
                query["Interval"] = request.Interval;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceArea))
            {
                query["ServiceArea"] = request.ServiceArea;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTs))
            {
                query["StartTs"] = request.StartTs;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeMeterRtcUserCntData",
                Version = "2021-04-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeMeterRtcUserCntDataResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeMeterRtcUserCntDataResponse> DescribeMeterRtcUserCntDataWithOptionsAsync(DescribeMeterRtcUserCntDataRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppId))
            {
                query["AppId"] = request.AppId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTs))
            {
                query["EndTs"] = request.EndTs;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Interval))
            {
                query["Interval"] = request.Interval;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceArea))
            {
                query["ServiceArea"] = request.ServiceArea;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTs))
            {
                query["StartTs"] = request.StartTs;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeMeterRtcUserCntData",
                Version = "2021-04-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeMeterRtcUserCntDataResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeMeterRtcUserCntDataResponse DescribeMeterRtcUserCntData(DescribeMeterRtcUserCntDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeMeterRtcUserCntDataWithOptions(request, runtime);
        }

        public async Task<DescribeMeterRtcUserCntDataResponse> DescribeMeterRtcUserCntDataAsync(DescribeMeterRtcUserCntDataRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeMeterRtcUserCntDataWithOptionsAsync(request, runtime);
        }

        public DescribeNewPlayVideoPlaySessionEventDetailResponse DescribeNewPlayVideoPlaySessionEventDetailWithOptions(DescribeNewPlayVideoPlaySessionEventDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizDate))
            {
                query["BizDate"] = request.BizDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InputStatus))
            {
                query["InputStatus"] = request.InputStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNum))
            {
                query["PageNum"] = request.PageNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VPS))
            {
                query["VPS"] = request.VPS;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeNewPlayVideoPlaySessionEventDetail",
                Version = "2021-04-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeNewPlayVideoPlaySessionEventDetailResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeNewPlayVideoPlaySessionEventDetailResponse> DescribeNewPlayVideoPlaySessionEventDetailWithOptionsAsync(DescribeNewPlayVideoPlaySessionEventDetailRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BizDate))
            {
                query["BizDate"] = request.BizDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InputStatus))
            {
                query["InputStatus"] = request.InputStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNum))
            {
                query["PageNum"] = request.PageNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VPS))
            {
                query["VPS"] = request.VPS;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeNewPlayVideoPlaySessionEventDetail",
                Version = "2021-04-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeNewPlayVideoPlaySessionEventDetailResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeNewPlayVideoPlaySessionEventDetailResponse DescribeNewPlayVideoPlaySessionEventDetail(DescribeNewPlayVideoPlaySessionEventDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeNewPlayVideoPlaySessionEventDetailWithOptions(request, runtime);
        }

        public async Task<DescribeNewPlayVideoPlaySessionEventDetailResponse> DescribeNewPlayVideoPlaySessionEventDetailAsync(DescribeNewPlayVideoPlaySessionEventDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeNewPlayVideoPlaySessionEventDetailWithOptionsAsync(request, runtime);
        }

        public DescribeNewPlayVideoPlaySessionListResponse DescribeNewPlayVideoPlaySessionListWithOptions(DescribeNewPlayVideoPlaySessionListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTimeStamp))
            {
                query["EndTimeStamp"] = request.EndTimeStamp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InputStatus))
            {
                query["InputStatus"] = request.InputStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Order))
            {
                query["Order"] = request.Order;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNum))
            {
                query["PageNum"] = request.PageNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTimeStamp))
            {
                query["StartTimeStamp"] = request.StartTimeStamp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UniqueId))
            {
                query["UniqueId"] = request.UniqueId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeNewPlayVideoPlaySessionList",
                Version = "2021-04-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeNewPlayVideoPlaySessionListResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeNewPlayVideoPlaySessionListResponse> DescribeNewPlayVideoPlaySessionListWithOptionsAsync(DescribeNewPlayVideoPlaySessionListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTimeStamp))
            {
                query["EndTimeStamp"] = request.EndTimeStamp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InputStatus))
            {
                query["InputStatus"] = request.InputStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Order))
            {
                query["Order"] = request.Order;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNum))
            {
                query["PageNum"] = request.PageNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTimeStamp))
            {
                query["StartTimeStamp"] = request.StartTimeStamp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UniqueId))
            {
                query["UniqueId"] = request.UniqueId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeNewPlayVideoPlaySessionList",
                Version = "2021-04-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeNewPlayVideoPlaySessionListResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeNewPlayVideoPlaySessionListResponse DescribeNewPlayVideoPlaySessionList(DescribeNewPlayVideoPlaySessionListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeNewPlayVideoPlaySessionListWithOptions(request, runtime);
        }

        public async Task<DescribeNewPlayVideoPlaySessionListResponse> DescribeNewPlayVideoPlaySessionListAsync(DescribeNewPlayVideoPlaySessionListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeNewPlayVideoPlaySessionListWithOptionsAsync(request, runtime);
        }

        public DescribeNewPlayVideoPlaySessioninfoResponse DescribeNewPlayVideoPlaySessioninfoWithOptions(DescribeNewPlayVideoPlaySessioninfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VPS))
            {
                query["VPS"] = request.VPS;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeNewPlayVideoPlaySessioninfo",
                Version = "2021-04-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeNewPlayVideoPlaySessioninfoResponse>(CallApi(params_, req, runtime));
        }

        public async Task<DescribeNewPlayVideoPlaySessioninfoResponse> DescribeNewPlayVideoPlaySessioninfoWithOptionsAsync(DescribeNewPlayVideoPlaySessioninfoRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VPS))
            {
                query["VPS"] = request.VPS;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeNewPlayVideoPlaySessioninfo",
                Version = "2021-04-25",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeNewPlayVideoPlaySessioninfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        public DescribeNewPlayVideoPlaySessioninfoResponse DescribeNewPlayVideoPlaySessioninfo(DescribeNewPlayVideoPlaySessioninfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeNewPlayVideoPlaySessioninfoWithOptions(request, runtime);
        }

        public async Task<DescribeNewPlayVideoPlaySessioninfoResponse> DescribeNewPlayVideoPlaySessioninfoAsync(DescribeNewPlayVideoPlaySessioninfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeNewPlayVideoPlaySessioninfoWithOptionsAsync(request, runtime);
        }

    }
}
