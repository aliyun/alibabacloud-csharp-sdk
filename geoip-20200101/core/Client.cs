// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Geoip20200101.Models;

namespace AlibabaCloud.SDK.Geoip20200101
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "";
            CheckConfig(config);
            this._endpoint = GetEndpoint("geoip", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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

        public DescribeGeoipInstanceResponse DescribeGeoipInstanceWithOptions(DescribeGeoipInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeGeoipInstanceResponse>(DoRPCRequest("DescribeGeoipInstance", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeGeoipInstanceResponse> DescribeGeoipInstanceWithOptionsAsync(DescribeGeoipInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeGeoipInstanceResponse>(await DoRPCRequestAsync("DescribeGeoipInstance", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeGeoipInstanceResponse DescribeGeoipInstance(DescribeGeoipInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeGeoipInstanceWithOptions(request, runtime);
        }

        public async Task<DescribeGeoipInstanceResponse> DescribeGeoipInstanceAsync(DescribeGeoipInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeGeoipInstanceWithOptionsAsync(request, runtime);
        }

        public DescribeGeoipInstanceDataInfosResponse DescribeGeoipInstanceDataInfosWithOptions(DescribeGeoipInstanceDataInfosRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeGeoipInstanceDataInfosResponse>(DoRPCRequest("DescribeGeoipInstanceDataInfos", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeGeoipInstanceDataInfosResponse> DescribeGeoipInstanceDataInfosWithOptionsAsync(DescribeGeoipInstanceDataInfosRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeGeoipInstanceDataInfosResponse>(await DoRPCRequestAsync("DescribeGeoipInstanceDataInfos", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeGeoipInstanceDataInfosResponse DescribeGeoipInstanceDataInfos(DescribeGeoipInstanceDataInfosRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeGeoipInstanceDataInfosWithOptions(request, runtime);
        }

        public async Task<DescribeGeoipInstanceDataInfosResponse> DescribeGeoipInstanceDataInfosAsync(DescribeGeoipInstanceDataInfosRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeGeoipInstanceDataInfosWithOptionsAsync(request, runtime);
        }

        public DescribeGeoipInstanceDataUrlResponse DescribeGeoipInstanceDataUrlWithOptions(DescribeGeoipInstanceDataUrlRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeGeoipInstanceDataUrlResponse>(DoRPCRequest("DescribeGeoipInstanceDataUrl", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeGeoipInstanceDataUrlResponse> DescribeGeoipInstanceDataUrlWithOptionsAsync(DescribeGeoipInstanceDataUrlRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeGeoipInstanceDataUrlResponse>(await DoRPCRequestAsync("DescribeGeoipInstanceDataUrl", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeGeoipInstanceDataUrlResponse DescribeGeoipInstanceDataUrl(DescribeGeoipInstanceDataUrlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeGeoipInstanceDataUrlWithOptions(request, runtime);
        }

        public async Task<DescribeGeoipInstanceDataUrlResponse> DescribeGeoipInstanceDataUrlAsync(DescribeGeoipInstanceDataUrlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeGeoipInstanceDataUrlWithOptionsAsync(request, runtime);
        }

        public DescribeGeoipInstancesResponse DescribeGeoipInstancesWithOptions(DescribeGeoipInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeGeoipInstancesResponse>(DoRPCRequest("DescribeGeoipInstances", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeGeoipInstancesResponse> DescribeGeoipInstancesWithOptionsAsync(DescribeGeoipInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeGeoipInstancesResponse>(await DoRPCRequestAsync("DescribeGeoipInstances", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeGeoipInstancesResponse DescribeGeoipInstances(DescribeGeoipInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeGeoipInstancesWithOptions(request, runtime);
        }

        public async Task<DescribeGeoipInstancesResponse> DescribeGeoipInstancesAsync(DescribeGeoipInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeGeoipInstancesWithOptionsAsync(request, runtime);
        }

        public DescribeGeoipInstanceStatisticsResponse DescribeGeoipInstanceStatisticsWithOptions(DescribeGeoipInstanceStatisticsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeGeoipInstanceStatisticsResponse>(DoRPCRequest("DescribeGeoipInstanceStatistics", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeGeoipInstanceStatisticsResponse> DescribeGeoipInstanceStatisticsWithOptionsAsync(DescribeGeoipInstanceStatisticsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeGeoipInstanceStatisticsResponse>(await DoRPCRequestAsync("DescribeGeoipInstanceStatistics", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeGeoipInstanceStatisticsResponse DescribeGeoipInstanceStatistics(DescribeGeoipInstanceStatisticsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeGeoipInstanceStatisticsWithOptions(request, runtime);
        }

        public async Task<DescribeGeoipInstanceStatisticsResponse> DescribeGeoipInstanceStatisticsAsync(DescribeGeoipInstanceStatisticsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeGeoipInstanceStatisticsWithOptionsAsync(request, runtime);
        }

        public DescribeIpv4LocationResponse DescribeIpv4LocationWithOptions(DescribeIpv4LocationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeIpv4LocationResponse>(DoRPCRequest("DescribeIpv4Location", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeIpv4LocationResponse> DescribeIpv4LocationWithOptionsAsync(DescribeIpv4LocationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeIpv4LocationResponse>(await DoRPCRequestAsync("DescribeIpv4Location", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeIpv4LocationResponse DescribeIpv4Location(DescribeIpv4LocationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeIpv4LocationWithOptions(request, runtime);
        }

        public async Task<DescribeIpv4LocationResponse> DescribeIpv4LocationAsync(DescribeIpv4LocationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeIpv4LocationWithOptionsAsync(request, runtime);
        }

        public DescribeIpv6LocationResponse DescribeIpv6LocationWithOptions(DescribeIpv6LocationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeIpv6LocationResponse>(DoRPCRequest("DescribeIpv6Location", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DescribeIpv6LocationResponse> DescribeIpv6LocationWithOptionsAsync(DescribeIpv6LocationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DescribeIpv6LocationResponse>(await DoRPCRequestAsync("DescribeIpv6Location", "2020-01-01", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DescribeIpv6LocationResponse DescribeIpv6Location(DescribeIpv6LocationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeIpv6LocationWithOptions(request, runtime);
        }

        public async Task<DescribeIpv6LocationResponse> DescribeIpv6LocationAsync(DescribeIpv6LocationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeIpv6LocationWithOptionsAsync(request, runtime);
        }

    }
}
