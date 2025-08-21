// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Antiddos_public20170518.Models;

namespace AlibabaCloud.SDK.Antiddos_public20170518
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "regional";
            this._endpointMap = new Dictionary<string, string>
            {
                {"cn-qingdao", "antiddos.aliyuncs.com"},
                {"cn-beijing", "antiddos.aliyuncs.com"},
                {"cn-zhangjiakou", "antiddos-openapi.cn-zhangjiakou.aliyuncs.com"},
                {"cn-huhehaote", "antiddos-openapi.cn-huhehaote.aliyuncs.com"},
                {"cn-wulanchabu", "antiddos-openapi.cn-wulanchabu.aliyuncs.com"},
                {"cn-hangzhou", "antiddos.aliyuncs.com"},
                {"cn-shanghai", "antiddos.aliyuncs.com"},
                {"cn-nanjing", "antiddos-openapi.cn-hangzhou-cloudstone.aliyuncs.com"},
                {"cn-shenzhen", "antiddos.aliyuncs.com"},
                {"cn-heyuan", "antiddos-openapi.cn-heyuan.aliyuncs.com"},
                {"cn-guangzhou", "antiddos-openapi.cn-guangzhou.aliyuncs.com"},
                {"cn-chengdu", "antiddos-openapi.cn-chengdu.aliyuncs.com"},
                {"cn-hongkong", "antiddos.aliyuncs.com"},
                {"ap-northeast-1", "antiddos-openapi.ap-northeast-1.aliyuncs.com"},
                {"ap-northeast-2", "antiddos-openapi.ap-northeast-2.aliyuncs.com"},
                {"ap-southeast-1", "antiddos.aliyuncs.com"},
                {"ap-southeast-2", "antiddos-openapi.ap-southeast-2.aliyuncs.com"},
                {"ap-southeast-3", "antiddos-openapi.ap-southeast-3.aliyuncs.com"},
                {"ap-southeast-5", "antiddos-openapi.ap-southeast-5.aliyuncs.com"},
                {"ap-southeast-6", "antiddos-openapi.ap-southeast-6.aliyuncs.com"},
                {"us-east-1", "antiddos.aliyuncs.com"},
                {"us-west-1", "antiddos.aliyuncs.com"},
                {"eu-west-1", "antiddos-openapi.eu-west-1.aliyuncs.com"},
                {"eu-central-1", "antiddos-openapi.eu-central-1.aliyuncs.com"},
                {"ap-south-1", "antiddos-openapi.ap-south-1.aliyuncs.com"},
                {"me-east-1", "antiddos-openapi.me-east-1.aliyuncs.com"},
                {"cn-shanghai-finance-1", "antiddos.aliyuncs.com"},
                {"cn-shenzhen-finance-1", "antiddos.aliyuncs.com"},
                {"cn-north-2-gov-1", "antiddos.aliyuncs.com"},
                {"ap-northeast-2-pop", "antiddos.aliyuncs.com"},
                {"cn-beijing-finance-1", "antiddos.aliyuncs.com"},
                {"cn-beijing-finance-pop", "antiddos.aliyuncs.com"},
                {"cn-beijing-gov-1", "antiddos.aliyuncs.com"},
                {"cn-beijing-nu16-b01", "antiddos.aliyuncs.com"},
                {"cn-edge-1", "antiddos.aliyuncs.com"},
                {"cn-fujian", "antiddos.aliyuncs.com"},
                {"cn-haidian-cm12-c01", "antiddos.aliyuncs.com"},
                {"cn-hangzhou-bj-b01", "antiddos.aliyuncs.com"},
                {"cn-hangzhou-finance", "antiddos.aliyuncs.com"},
                {"cn-hangzhou-internal-prod-1", "antiddos.aliyuncs.com"},
                {"cn-hangzhou-internal-test-1", "antiddos.aliyuncs.com"},
                {"cn-hangzhou-internal-test-2", "antiddos.aliyuncs.com"},
                {"cn-hangzhou-internal-test-3", "antiddos.aliyuncs.com"},
                {"cn-hangzhou-test-306", "antiddos.aliyuncs.com"},
                {"cn-hongkong-finance-pop", "antiddos.aliyuncs.com"},
                {"cn-huhehaote-nebula-1", "antiddos.aliyuncs.com"},
                {"cn-qingdao-nebula", "antiddos.aliyuncs.com"},
                {"cn-shanghai-et15-b01", "antiddos.aliyuncs.com"},
                {"cn-shanghai-et2-b01", "antiddos.aliyuncs.com"},
                {"cn-shanghai-inner", "antiddos.aliyuncs.com"},
                {"cn-shanghai-internal-test-1", "antiddos.aliyuncs.com"},
                {"cn-shenzhen-inner", "antiddos.aliyuncs.com"},
                {"cn-shenzhen-st4-d01", "antiddos.aliyuncs.com"},
                {"cn-shenzhen-su18-b01", "antiddos.aliyuncs.com"},
                {"cn-wuhan", "antiddos.aliyuncs.com"},
                {"cn-yushanfang", "antiddos.aliyuncs.com"},
                {"cn-zhangbei", "antiddos.aliyuncs.com"},
                {"cn-zhangbei-na61-b01", "antiddos.aliyuncs.com"},
                {"cn-zhangjiakou-na62-a01", "antiddos-openapi.cn-zhangjiakou.aliyuncs.com"},
                {"cn-zhengzhou-nebula-1", "antiddos.aliyuncs.com"},
                {"eu-west-1-oxs", "antiddos.aliyuncs.com"},
                {"rus-west-1-pop", "antiddos.aliyuncs.com"},
            };
            CheckConfig(config);
            this._endpoint = GetEndpoint("antiddos-public", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the configurations of the Anti-DDoS Origin instance that is associated with an asset. The asset is assigned a public IP address.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call the DescribeBgpPackByIp operation to query the configurations of the Anti-DDoS Origin instance that is associated with an asset. The configurations include the basic protection threshold, burstable protection threshold, and expiration time.</para>
        /// <h2><a href="#qps-"></a>Limits</h2>
        /// <para>You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeBgpPackByIpRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeBgpPackByIpResponse
        /// </returns>
        public DescribeBgpPackByIpResponse DescribeBgpPackByIpWithOptions(DescribeBgpPackByIpRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DdosRegionId))
            {
                query["DdosRegionId"] = request.DdosRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ip))
            {
                query["Ip"] = request.Ip;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeBgpPackByIp",
                Version = "2017-05-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeBgpPackByIpResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the configurations of the Anti-DDoS Origin instance that is associated with an asset. The asset is assigned a public IP address.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call the DescribeBgpPackByIp operation to query the configurations of the Anti-DDoS Origin instance that is associated with an asset. The configurations include the basic protection threshold, burstable protection threshold, and expiration time.</para>
        /// <h2><a href="#qps-"></a>Limits</h2>
        /// <para>You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeBgpPackByIpRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeBgpPackByIpResponse
        /// </returns>
        public async Task<DescribeBgpPackByIpResponse> DescribeBgpPackByIpWithOptionsAsync(DescribeBgpPackByIpRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DdosRegionId))
            {
                query["DdosRegionId"] = request.DdosRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ip))
            {
                query["Ip"] = request.Ip;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeBgpPackByIp",
                Version = "2017-05-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeBgpPackByIpResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the configurations of the Anti-DDoS Origin instance that is associated with an asset. The asset is assigned a public IP address.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call the DescribeBgpPackByIp operation to query the configurations of the Anti-DDoS Origin instance that is associated with an asset. The configurations include the basic protection threshold, burstable protection threshold, and expiration time.</para>
        /// <h2><a href="#qps-"></a>Limits</h2>
        /// <para>You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeBgpPackByIpRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeBgpPackByIpResponse
        /// </returns>
        public DescribeBgpPackByIpResponse DescribeBgpPackByIp(DescribeBgpPackByIpRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeBgpPackByIpWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the configurations of the Anti-DDoS Origin instance that is associated with an asset. The asset is assigned a public IP address.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call the DescribeBgpPackByIp operation to query the configurations of the Anti-DDoS Origin instance that is associated with an asset. The configurations include the basic protection threshold, burstable protection threshold, and expiration time.</para>
        /// <h2><a href="#qps-"></a>Limits</h2>
        /// <para>You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeBgpPackByIpRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeBgpPackByIpResponse
        /// </returns>
        public async Task<DescribeBgpPackByIpResponse> DescribeBgpPackByIpAsync(DescribeBgpPackByIpRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeBgpPackByIpWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the download link to the traffic data that is captured when a DDoS attack event occurs.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call the DescribeCap operation to query the download link to the traffic data that is captured when a DDoS attack event occurs. You can download the traffic data from the download link and use the data as evidence.</para>
        /// <h2>Limits</h2>
        /// <para>You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeCapRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeCapResponse
        /// </returns>
        public DescribeCapResponse DescribeCapWithOptions(DescribeCapRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BegTime))
            {
                query["BegTime"] = request.BegTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DdosRegionId))
            {
                query["DdosRegionId"] = request.DdosRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceType))
            {
                query["InstanceType"] = request.InstanceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InternetIp))
            {
                query["InternetIp"] = request.InternetIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeCap",
                Version = "2017-05-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeCapResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the download link to the traffic data that is captured when a DDoS attack event occurs.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call the DescribeCap operation to query the download link to the traffic data that is captured when a DDoS attack event occurs. You can download the traffic data from the download link and use the data as evidence.</para>
        /// <h2>Limits</h2>
        /// <para>You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeCapRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeCapResponse
        /// </returns>
        public async Task<DescribeCapResponse> DescribeCapWithOptionsAsync(DescribeCapRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BegTime))
            {
                query["BegTime"] = request.BegTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DdosRegionId))
            {
                query["DdosRegionId"] = request.DdosRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceType))
            {
                query["InstanceType"] = request.InstanceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InternetIp))
            {
                query["InternetIp"] = request.InternetIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeCap",
                Version = "2017-05-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeCapResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the download link to the traffic data that is captured when a DDoS attack event occurs.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call the DescribeCap operation to query the download link to the traffic data that is captured when a DDoS attack event occurs. You can download the traffic data from the download link and use the data as evidence.</para>
        /// <h2>Limits</h2>
        /// <para>You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeCapRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeCapResponse
        /// </returns>
        public DescribeCapResponse DescribeCap(DescribeCapRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeCapWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the download link to the traffic data that is captured when a DDoS attack event occurs.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call the DescribeCap operation to query the download link to the traffic data that is captured when a DDoS attack event occurs. You can download the traffic data from the download link and use the data as evidence.</para>
        /// <h2>Limits</h2>
        /// <para>You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeCapRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeCapResponse
        /// </returns>
        public async Task<DescribeCapResponse> DescribeCapAsync(DescribeCapRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeCapWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the number of assets that are under DDoS attacks in a specific region. The assets are assigned public IP addresses.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2><a href="#qps-"></a>Limits</h2>
        /// <para>You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeDdosCountRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeDdosCountResponse
        /// </returns>
        public DescribeDdosCountResponse DescribeDdosCountWithOptions(DescribeDdosCountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DdosRegionId))
            {
                query["DdosRegionId"] = request.DdosRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceType))
            {
                query["InstanceType"] = request.InstanceType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDdosCount",
                Version = "2017-05-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDdosCountResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the number of assets that are under DDoS attacks in a specific region. The assets are assigned public IP addresses.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2><a href="#qps-"></a>Limits</h2>
        /// <para>You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeDdosCountRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeDdosCountResponse
        /// </returns>
        public async Task<DescribeDdosCountResponse> DescribeDdosCountWithOptionsAsync(DescribeDdosCountRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DdosRegionId))
            {
                query["DdosRegionId"] = request.DdosRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceType))
            {
                query["InstanceType"] = request.InstanceType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDdosCount",
                Version = "2017-05-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDdosCountResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the number of assets that are under DDoS attacks in a specific region. The assets are assigned public IP addresses.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2><a href="#qps-"></a>Limits</h2>
        /// <para>You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeDdosCountRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeDdosCountResponse
        /// </returns>
        public DescribeDdosCountResponse DescribeDdosCount(DescribeDdosCountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDdosCountWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the number of assets that are under DDoS attacks in a specific region. The assets are assigned public IP addresses.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2><a href="#qps-"></a>Limits</h2>
        /// <para>You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeDdosCountRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeDdosCountResponse
        /// </returns>
        public async Task<DescribeDdosCountResponse> DescribeDdosCountAsync(DescribeDdosCountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDdosCountWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of the security credit score of the current Alibaba Cloud account in a specific region.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call the DescribeDdosCredit operation to query the details of the security credit score of the current Alibaba Cloud account in a specific region. The details include the security credit score, security credit level, and the time period after which blackhole filtering is automatically deactivated.</para>
        /// <h2>Limits</h2>
        /// <para>You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeDdosCreditRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeDdosCreditResponse
        /// </returns>
        public DescribeDdosCreditResponse DescribeDdosCreditWithOptions(DescribeDdosCreditRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DdosRegionId))
            {
                query["DdosRegionId"] = request.DdosRegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDdosCredit",
                Version = "2017-05-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDdosCreditResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of the security credit score of the current Alibaba Cloud account in a specific region.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call the DescribeDdosCredit operation to query the details of the security credit score of the current Alibaba Cloud account in a specific region. The details include the security credit score, security credit level, and the time period after which blackhole filtering is automatically deactivated.</para>
        /// <h2>Limits</h2>
        /// <para>You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeDdosCreditRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeDdosCreditResponse
        /// </returns>
        public async Task<DescribeDdosCreditResponse> DescribeDdosCreditWithOptionsAsync(DescribeDdosCreditRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DdosRegionId))
            {
                query["DdosRegionId"] = request.DdosRegionId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDdosCredit",
                Version = "2017-05-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDdosCreditResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of the security credit score of the current Alibaba Cloud account in a specific region.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call the DescribeDdosCredit operation to query the details of the security credit score of the current Alibaba Cloud account in a specific region. The details include the security credit score, security credit level, and the time period after which blackhole filtering is automatically deactivated.</para>
        /// <h2>Limits</h2>
        /// <para>You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeDdosCreditRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeDdosCreditResponse
        /// </returns>
        public DescribeDdosCreditResponse DescribeDdosCredit(DescribeDdosCreditRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDdosCreditWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of the security credit score of the current Alibaba Cloud account in a specific region.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call the DescribeDdosCredit operation to query the details of the security credit score of the current Alibaba Cloud account in a specific region. The details include the security credit score, security credit level, and the time period after which blackhole filtering is automatically deactivated.</para>
        /// <h2>Limits</h2>
        /// <para>You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeDdosCreditRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeDdosCreditResponse
        /// </returns>
        public async Task<DescribeDdosCreditResponse> DescribeDdosCreditAsync(DescribeDdosCreditRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDdosCreditWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of the DDoS attack events that occur on an asset. The asset is assigned a public IP address.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call the DescribeDdosEventList operation to query the details of the DDoS attack events that occur on an asset by page. The details include the start time, end time, and status of each DDoS attack event.</para>
        /// <h2><a href="#qps-"></a>Limits</h2>
        /// <para>You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeDdosEventListRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeDdosEventListResponse
        /// </returns>
        public DescribeDdosEventListResponse DescribeDdosEventListWithOptions(DescribeDdosEventListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DdosRegionId))
            {
                query["DdosRegionId"] = request.DdosRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceType))
            {
                query["InstanceType"] = request.InstanceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InternetIp))
            {
                query["InternetIp"] = request.InternetIp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueryDays))
            {
                query["QueryDays"] = request.QueryDays;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDdosEventList",
                Version = "2017-05-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDdosEventListResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of the DDoS attack events that occur on an asset. The asset is assigned a public IP address.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call the DescribeDdosEventList operation to query the details of the DDoS attack events that occur on an asset by page. The details include the start time, end time, and status of each DDoS attack event.</para>
        /// <h2><a href="#qps-"></a>Limits</h2>
        /// <para>You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeDdosEventListRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeDdosEventListResponse
        /// </returns>
        public async Task<DescribeDdosEventListResponse> DescribeDdosEventListWithOptionsAsync(DescribeDdosEventListRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DdosRegionId))
            {
                query["DdosRegionId"] = request.DdosRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceType))
            {
                query["InstanceType"] = request.InstanceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InternetIp))
            {
                query["InternetIp"] = request.InternetIp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueryDays))
            {
                query["QueryDays"] = request.QueryDays;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDdosEventList",
                Version = "2017-05-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDdosEventListResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of the DDoS attack events that occur on an asset. The asset is assigned a public IP address.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call the DescribeDdosEventList operation to query the details of the DDoS attack events that occur on an asset by page. The details include the start time, end time, and status of each DDoS attack event.</para>
        /// <h2><a href="#qps-"></a>Limits</h2>
        /// <para>You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeDdosEventListRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeDdosEventListResponse
        /// </returns>
        public DescribeDdosEventListResponse DescribeDdosEventList(DescribeDdosEventListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDdosEventListWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of the DDoS attack events that occur on an asset. The asset is assigned a public IP address.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call the DescribeDdosEventList operation to query the details of the DDoS attack events that occur on an asset by page. The details include the start time, end time, and status of each DDoS attack event.</para>
        /// <h2><a href="#qps-"></a>Limits</h2>
        /// <para>You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeDdosEventListRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeDdosEventListResponse
        /// </returns>
        public async Task<DescribeDdosEventListResponse> DescribeDdosEventListAsync(DescribeDdosEventListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDdosEventListWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of the DDoS mitigation thresholds or traffic scrubbing thresholds for specified assets. The assets can be elastic IP addresses (EIPs). The assets can also be Elastic Compute Service (ECS) instances or Server Load Balancer (SLB) instances that are assigned public IP addresses.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call the DescribeDdosThreshold operation to query the details of the DDoS mitigation thresholds or traffic scrubbing thresholds for specified assets. The details include the current traffic scrubbing threshold, maximum traffic scrubbing threshold, current DDoS mitigation threshold, and maximum DDoS mitigation threshold.</para>
        /// <h3>Limits</h3>
        /// <para>You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeDdosThresholdRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeDdosThresholdResponse
        /// </returns>
        public DescribeDdosThresholdResponse DescribeDdosThresholdWithOptions(DescribeDdosThresholdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DdosRegionId))
            {
                query["DdosRegionId"] = request.DdosRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DdosType))
            {
                query["DdosType"] = request.DdosType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceIds))
            {
                query["InstanceIds"] = request.InstanceIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceType))
            {
                query["InstanceType"] = request.InstanceType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDdosThreshold",
                Version = "2017-05-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDdosThresholdResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of the DDoS mitigation thresholds or traffic scrubbing thresholds for specified assets. The assets can be elastic IP addresses (EIPs). The assets can also be Elastic Compute Service (ECS) instances or Server Load Balancer (SLB) instances that are assigned public IP addresses.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call the DescribeDdosThreshold operation to query the details of the DDoS mitigation thresholds or traffic scrubbing thresholds for specified assets. The details include the current traffic scrubbing threshold, maximum traffic scrubbing threshold, current DDoS mitigation threshold, and maximum DDoS mitigation threshold.</para>
        /// <h3>Limits</h3>
        /// <para>You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeDdosThresholdRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeDdosThresholdResponse
        /// </returns>
        public async Task<DescribeDdosThresholdResponse> DescribeDdosThresholdWithOptionsAsync(DescribeDdosThresholdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DdosRegionId))
            {
                query["DdosRegionId"] = request.DdosRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DdosType))
            {
                query["DdosType"] = request.DdosType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceIds))
            {
                query["InstanceIds"] = request.InstanceIds;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceType))
            {
                query["InstanceType"] = request.InstanceType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeDdosThreshold",
                Version = "2017-05-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeDdosThresholdResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of the DDoS mitigation thresholds or traffic scrubbing thresholds for specified assets. The assets can be elastic IP addresses (EIPs). The assets can also be Elastic Compute Service (ECS) instances or Server Load Balancer (SLB) instances that are assigned public IP addresses.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call the DescribeDdosThreshold operation to query the details of the DDoS mitigation thresholds or traffic scrubbing thresholds for specified assets. The details include the current traffic scrubbing threshold, maximum traffic scrubbing threshold, current DDoS mitigation threshold, and maximum DDoS mitigation threshold.</para>
        /// <h3>Limits</h3>
        /// <para>You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeDdosThresholdRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeDdosThresholdResponse
        /// </returns>
        public DescribeDdosThresholdResponse DescribeDdosThreshold(DescribeDdosThresholdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDdosThresholdWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of the DDoS mitigation thresholds or traffic scrubbing thresholds for specified assets. The assets can be elastic IP addresses (EIPs). The assets can also be Elastic Compute Service (ECS) instances or Server Load Balancer (SLB) instances that are assigned public IP addresses.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call the DescribeDdosThreshold operation to query the details of the DDoS mitigation thresholds or traffic scrubbing thresholds for specified assets. The details include the current traffic scrubbing threshold, maximum traffic scrubbing threshold, current DDoS mitigation threshold, and maximum DDoS mitigation threshold.</para>
        /// <h3>Limits</h3>
        /// <para>You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeDdosThresholdRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeDdosThresholdResponse
        /// </returns>
        public async Task<DescribeDdosThresholdResponse> DescribeDdosThresholdAsync(DescribeDdosThresholdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDdosThresholdWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of the assets within the current Alibaba Cloud account. The assets can be elastic IP addresses (EIPs). The assets can also be Elastic Compute Service (ECS) instances or Server Load Balancer (SLB) instances that are assigned public IP addresses. This operation is phased out. We recommend that you use the DescribeInstanceIpAddress operation.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call the DescribeInstance operation to query the details of the assets that are within the current Alibaba Cloud account by page. The details include the IDs and IP addresses of the assets, the basic protection thresholds and traffic scrubbing thresholds that are configured for the assets in Anti-DDoS Origin, and whether the assets are associated with Anti-DDoS Origin instances.</para>
        /// <h3><a href="#qps-"></a>Limits</h3>
        /// <para>You can call this operation up to 200 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeInstanceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeInstanceResponse
        /// </returns>
        public DescribeInstanceResponse DescribeInstanceWithOptions(DescribeInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DdosRegionId))
            {
                query["DdosRegionId"] = request.DdosRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DdosStatus))
            {
                query["DdosStatus"] = request.DdosStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceIp))
            {
                query["InstanceIp"] = request.InstanceIp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceName))
            {
                query["InstanceName"] = request.InstanceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceType))
            {
                query["InstanceType"] = request.InstanceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeInstance",
                Version = "2017-05-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeInstanceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of the assets within the current Alibaba Cloud account. The assets can be elastic IP addresses (EIPs). The assets can also be Elastic Compute Service (ECS) instances or Server Load Balancer (SLB) instances that are assigned public IP addresses. This operation is phased out. We recommend that you use the DescribeInstanceIpAddress operation.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call the DescribeInstance operation to query the details of the assets that are within the current Alibaba Cloud account by page. The details include the IDs and IP addresses of the assets, the basic protection thresholds and traffic scrubbing thresholds that are configured for the assets in Anti-DDoS Origin, and whether the assets are associated with Anti-DDoS Origin instances.</para>
        /// <h3><a href="#qps-"></a>Limits</h3>
        /// <para>You can call this operation up to 200 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeInstanceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeInstanceResponse
        /// </returns>
        public async Task<DescribeInstanceResponse> DescribeInstanceWithOptionsAsync(DescribeInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DdosRegionId))
            {
                query["DdosRegionId"] = request.DdosRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DdosStatus))
            {
                query["DdosStatus"] = request.DdosStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceIp))
            {
                query["InstanceIp"] = request.InstanceIp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceName))
            {
                query["InstanceName"] = request.InstanceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceType))
            {
                query["InstanceType"] = request.InstanceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeInstance",
                Version = "2017-05-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeInstanceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of the assets within the current Alibaba Cloud account. The assets can be elastic IP addresses (EIPs). The assets can also be Elastic Compute Service (ECS) instances or Server Load Balancer (SLB) instances that are assigned public IP addresses. This operation is phased out. We recommend that you use the DescribeInstanceIpAddress operation.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call the DescribeInstance operation to query the details of the assets that are within the current Alibaba Cloud account by page. The details include the IDs and IP addresses of the assets, the basic protection thresholds and traffic scrubbing thresholds that are configured for the assets in Anti-DDoS Origin, and whether the assets are associated with Anti-DDoS Origin instances.</para>
        /// <h3><a href="#qps-"></a>Limits</h3>
        /// <para>You can call this operation up to 200 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeInstanceResponse
        /// </returns>
        public DescribeInstanceResponse DescribeInstance(DescribeInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeInstanceWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of the assets within the current Alibaba Cloud account. The assets can be elastic IP addresses (EIPs). The assets can also be Elastic Compute Service (ECS) instances or Server Load Balancer (SLB) instances that are assigned public IP addresses. This operation is phased out. We recommend that you use the DescribeInstanceIpAddress operation.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call the DescribeInstance operation to query the details of the assets that are within the current Alibaba Cloud account by page. The details include the IDs and IP addresses of the assets, the basic protection thresholds and traffic scrubbing thresholds that are configured for the assets in Anti-DDoS Origin, and whether the assets are associated with Anti-DDoS Origin instances.</para>
        /// <h3><a href="#qps-"></a>Limits</h3>
        /// <para>You can call this operation up to 200 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeInstanceResponse
        /// </returns>
        public async Task<DescribeInstanceResponse> DescribeInstanceAsync(DescribeInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeInstanceWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of the assets within the current Alibaba Cloud account and the details of the Anti-DDoS Origin instance to which the assets belong. The assets can be elastic IP addresses (EIPs). The assets can also be Elastic Compute Service (ECS) instances or Server Load Balancer (SLB) instances that are assigned public IP addresses.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>If one or more assets of the current Alibaba Cloud account are added to an Anti-DDoS Origin instance, you can call the DescribeInstanceIpAddress operation to query the DDoS mitigation information and the details of the Anti-DDoS Origin instance. The information and the details include the basic protection threshold and traffic scrubbing threshold for the assets, DDoS mitigation status of the assets, ID of the instance, and the mitigation status of the instance.</para>
        /// <h2>Limits</h2>
        /// <para>You can call this operation up to 200 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeInstanceIpAddressRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeInstanceIpAddressResponse
        /// </returns>
        public DescribeInstanceIpAddressResponse DescribeInstanceIpAddressWithOptions(DescribeInstanceIpAddressRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DdosRegionId))
            {
                query["DdosRegionId"] = request.DdosRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DdosStatus))
            {
                query["DdosStatus"] = request.DdosStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceIp))
            {
                query["InstanceIp"] = request.InstanceIp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceName))
            {
                query["InstanceName"] = request.InstanceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceType))
            {
                query["InstanceType"] = request.InstanceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeInstanceIpAddress",
                Version = "2017-05-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeInstanceIpAddressResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of the assets within the current Alibaba Cloud account and the details of the Anti-DDoS Origin instance to which the assets belong. The assets can be elastic IP addresses (EIPs). The assets can also be Elastic Compute Service (ECS) instances or Server Load Balancer (SLB) instances that are assigned public IP addresses.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>If one or more assets of the current Alibaba Cloud account are added to an Anti-DDoS Origin instance, you can call the DescribeInstanceIpAddress operation to query the DDoS mitigation information and the details of the Anti-DDoS Origin instance. The information and the details include the basic protection threshold and traffic scrubbing threshold for the assets, DDoS mitigation status of the assets, ID of the instance, and the mitigation status of the instance.</para>
        /// <h2>Limits</h2>
        /// <para>You can call this operation up to 200 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeInstanceIpAddressRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeInstanceIpAddressResponse
        /// </returns>
        public async Task<DescribeInstanceIpAddressResponse> DescribeInstanceIpAddressWithOptionsAsync(DescribeInstanceIpAddressRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CurrentPage))
            {
                query["CurrentPage"] = request.CurrentPage;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DdosRegionId))
            {
                query["DdosRegionId"] = request.DdosRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DdosStatus))
            {
                query["DdosStatus"] = request.DdosStatus;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceIp))
            {
                query["InstanceIp"] = request.InstanceIp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceName))
            {
                query["InstanceName"] = request.InstanceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceType))
            {
                query["InstanceType"] = request.InstanceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeInstanceIpAddress",
                Version = "2017-05-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeInstanceIpAddressResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of the assets within the current Alibaba Cloud account and the details of the Anti-DDoS Origin instance to which the assets belong. The assets can be elastic IP addresses (EIPs). The assets can also be Elastic Compute Service (ECS) instances or Server Load Balancer (SLB) instances that are assigned public IP addresses.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>If one or more assets of the current Alibaba Cloud account are added to an Anti-DDoS Origin instance, you can call the DescribeInstanceIpAddress operation to query the DDoS mitigation information and the details of the Anti-DDoS Origin instance. The information and the details include the basic protection threshold and traffic scrubbing threshold for the assets, DDoS mitigation status of the assets, ID of the instance, and the mitigation status of the instance.</para>
        /// <h2>Limits</h2>
        /// <para>You can call this operation up to 200 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeInstanceIpAddressRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeInstanceIpAddressResponse
        /// </returns>
        public DescribeInstanceIpAddressResponse DescribeInstanceIpAddress(DescribeInstanceIpAddressRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeInstanceIpAddressWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of the assets within the current Alibaba Cloud account and the details of the Anti-DDoS Origin instance to which the assets belong. The assets can be elastic IP addresses (EIPs). The assets can also be Elastic Compute Service (ECS) instances or Server Load Balancer (SLB) instances that are assigned public IP addresses.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>If one or more assets of the current Alibaba Cloud account are added to an Anti-DDoS Origin instance, you can call the DescribeInstanceIpAddress operation to query the DDoS mitigation information and the details of the Anti-DDoS Origin instance. The information and the details include the basic protection threshold and traffic scrubbing threshold for the assets, DDoS mitigation status of the assets, ID of the instance, and the mitigation status of the instance.</para>
        /// <h2>Limits</h2>
        /// <para>You can call this operation up to 200 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeInstanceIpAddressRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeInstanceIpAddressResponse
        /// </returns>
        public async Task<DescribeInstanceIpAddressResponse> DescribeInstanceIpAddressAsync(DescribeInstanceIpAddressRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeInstanceIpAddressWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of the DDoS mitigation thresholds or traffic scrubbing thresholds for specified assets. The assets can be elastic IP addresses (EIPs). The assets can also be Elastic Compute Service (ECS) instances or Server Load Balancer (SLB) instances that are assigned public IP addresses.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>If one or more assets of the current Alibaba Cloud account are added to an Anti-DDoS Origin instance, you can call the DescribeIpDdosThreshold operation to query the details of the DDoS mitigation threshold or traffic scrubbing threshold for a specific asset. The details include the current traffic scrubbing threshold, maximum scrubbing threshold, current DDoS mitigation threshold, and maximum DDoS mitigation threshold.</para>
        /// <h2>Limits</h2>
        /// <para>You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeIpDdosThresholdRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeIpDdosThresholdResponse
        /// </returns>
        public DescribeIpDdosThresholdResponse DescribeIpDdosThresholdWithOptions(DescribeIpDdosThresholdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DdosRegionId))
            {
                query["DdosRegionId"] = request.DdosRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DdosType))
            {
                query["DdosType"] = request.DdosType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceType))
            {
                query["InstanceType"] = request.InstanceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InternetIp))
            {
                query["InternetIp"] = request.InternetIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeIpDdosThreshold",
                Version = "2017-05-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeIpDdosThresholdResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of the DDoS mitigation thresholds or traffic scrubbing thresholds for specified assets. The assets can be elastic IP addresses (EIPs). The assets can also be Elastic Compute Service (ECS) instances or Server Load Balancer (SLB) instances that are assigned public IP addresses.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>If one or more assets of the current Alibaba Cloud account are added to an Anti-DDoS Origin instance, you can call the DescribeIpDdosThreshold operation to query the details of the DDoS mitigation threshold or traffic scrubbing threshold for a specific asset. The details include the current traffic scrubbing threshold, maximum scrubbing threshold, current DDoS mitigation threshold, and maximum DDoS mitigation threshold.</para>
        /// <h2>Limits</h2>
        /// <para>You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeIpDdosThresholdRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeIpDdosThresholdResponse
        /// </returns>
        public async Task<DescribeIpDdosThresholdResponse> DescribeIpDdosThresholdWithOptionsAsync(DescribeIpDdosThresholdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DdosRegionId))
            {
                query["DdosRegionId"] = request.DdosRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DdosType))
            {
                query["DdosType"] = request.DdosType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceType))
            {
                query["InstanceType"] = request.InstanceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InternetIp))
            {
                query["InternetIp"] = request.InternetIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeIpDdosThreshold",
                Version = "2017-05-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeIpDdosThresholdResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of the DDoS mitigation thresholds or traffic scrubbing thresholds for specified assets. The assets can be elastic IP addresses (EIPs). The assets can also be Elastic Compute Service (ECS) instances or Server Load Balancer (SLB) instances that are assigned public IP addresses.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>If one or more assets of the current Alibaba Cloud account are added to an Anti-DDoS Origin instance, you can call the DescribeIpDdosThreshold operation to query the details of the DDoS mitigation threshold or traffic scrubbing threshold for a specific asset. The details include the current traffic scrubbing threshold, maximum scrubbing threshold, current DDoS mitigation threshold, and maximum DDoS mitigation threshold.</para>
        /// <h2>Limits</h2>
        /// <para>You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeIpDdosThresholdRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeIpDdosThresholdResponse
        /// </returns>
        public DescribeIpDdosThresholdResponse DescribeIpDdosThreshold(DescribeIpDdosThresholdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeIpDdosThresholdWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the details of the DDoS mitigation thresholds or traffic scrubbing thresholds for specified assets. The assets can be elastic IP addresses (EIPs). The assets can also be Elastic Compute Service (ECS) instances or Server Load Balancer (SLB) instances that are assigned public IP addresses.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>If one or more assets of the current Alibaba Cloud account are added to an Anti-DDoS Origin instance, you can call the DescribeIpDdosThreshold operation to query the details of the DDoS mitigation threshold or traffic scrubbing threshold for a specific asset. The details include the current traffic scrubbing threshold, maximum scrubbing threshold, current DDoS mitigation threshold, and maximum DDoS mitigation threshold.</para>
        /// <h2>Limits</h2>
        /// <para>You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeIpDdosThresholdRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeIpDdosThresholdResponse
        /// </returns>
        public async Task<DescribeIpDdosThresholdResponse> DescribeIpDdosThresholdAsync(DescribeIpDdosThresholdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeIpDdosThresholdWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the region to which the public IP address of the asset within the current Alibaba Cloud account belongs. The asset can be an elastic IP address (EIP). The asset can also be an Elastic Compute Service (ECS) instance or Server Load Balancer (SLB) instance that is assigned a public IP address.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call the DescribeIpLocationService operation to query the region of the public IP address for a specified asset that is within the current Alibaba Cloud account. You can also query the details of the Anti-DDoS Origin instance to which the asset is added. The details include the ID and name.</para>
        /// <h2><a href="#qps-"></a>Limits</h2>
        /// <para>You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeIpLocationServiceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeIpLocationServiceResponse
        /// </returns>
        public DescribeIpLocationServiceResponse DescribeIpLocationServiceWithOptions(DescribeIpLocationServiceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InternetIp))
            {
                query["InternetIp"] = request.InternetIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeIpLocationService",
                Version = "2017-05-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeIpLocationServiceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the region to which the public IP address of the asset within the current Alibaba Cloud account belongs. The asset can be an elastic IP address (EIP). The asset can also be an Elastic Compute Service (ECS) instance or Server Load Balancer (SLB) instance that is assigned a public IP address.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call the DescribeIpLocationService operation to query the region of the public IP address for a specified asset that is within the current Alibaba Cloud account. You can also query the details of the Anti-DDoS Origin instance to which the asset is added. The details include the ID and name.</para>
        /// <h2><a href="#qps-"></a>Limits</h2>
        /// <para>You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeIpLocationServiceRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeIpLocationServiceResponse
        /// </returns>
        public async Task<DescribeIpLocationServiceResponse> DescribeIpLocationServiceWithOptionsAsync(DescribeIpLocationServiceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InternetIp))
            {
                query["InternetIp"] = request.InternetIp;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeIpLocationService",
                Version = "2017-05-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeIpLocationServiceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the region to which the public IP address of the asset within the current Alibaba Cloud account belongs. The asset can be an elastic IP address (EIP). The asset can also be an Elastic Compute Service (ECS) instance or Server Load Balancer (SLB) instance that is assigned a public IP address.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call the DescribeIpLocationService operation to query the region of the public IP address for a specified asset that is within the current Alibaba Cloud account. You can also query the details of the Anti-DDoS Origin instance to which the asset is added. The details include the ID and name.</para>
        /// <h2><a href="#qps-"></a>Limits</h2>
        /// <para>You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeIpLocationServiceRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeIpLocationServiceResponse
        /// </returns>
        public DescribeIpLocationServiceResponse DescribeIpLocationService(DescribeIpLocationServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeIpLocationServiceWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the region to which the public IP address of the asset within the current Alibaba Cloud account belongs. The asset can be an elastic IP address (EIP). The asset can also be an Elastic Compute Service (ECS) instance or Server Load Balancer (SLB) instance that is assigned a public IP address.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call the DescribeIpLocationService operation to query the region of the public IP address for a specified asset that is within the current Alibaba Cloud account. You can also query the details of the Anti-DDoS Origin instance to which the asset is added. The details include the ID and name.</para>
        /// <h2><a href="#qps-"></a>Limits</h2>
        /// <para>You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeIpLocationServiceRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeIpLocationServiceResponse
        /// </returns>
        public async Task<DescribeIpLocationServiceResponse> DescribeIpLocationServiceAsync(DescribeIpLocationServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeIpLocationServiceWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the regions in which Anti-DDoS Origin Basic is available.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call this operation to query information about the regions in which Anti-DDoS Origin Basic is available. The information includes the region ID, region name, and code.</para>
        /// <h2>Limits</h2>
        /// <para>You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeRegionsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeRegionsResponse
        /// </returns>
        public DescribeRegionsResponse DescribeRegionsWithOptions(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeRegions",
                Version = "2017-05-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeRegionsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the regions in which Anti-DDoS Origin Basic is available.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call this operation to query information about the regions in which Anti-DDoS Origin Basic is available. The information includes the region ID, region name, and code.</para>
        /// <h2>Limits</h2>
        /// <para>You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeRegionsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeRegionsResponse
        /// </returns>
        public async Task<DescribeRegionsResponse> DescribeRegionsWithOptionsAsync(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeRegions",
                Version = "2017-05-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeRegionsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the regions in which Anti-DDoS Origin Basic is available.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call this operation to query information about the regions in which Anti-DDoS Origin Basic is available. The information includes the region ID, region name, and code.</para>
        /// <h2>Limits</h2>
        /// <para>You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <returns>
        /// DescribeRegionsResponse
        /// </returns>
        public DescribeRegionsResponse DescribeRegions()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeRegionsWithOptions(runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the regions in which Anti-DDoS Origin Basic is available.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>You can call this operation to query information about the regions in which Anti-DDoS Origin Basic is available. The information includes the region ID, region name, and code.</para>
        /// <h2>Limits</h2>
        /// <para>You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <returns>
        /// DescribeRegionsResponse
        /// </returns>
        public async Task<DescribeRegionsResponse> DescribeRegionsAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeRegionsWithOptionsAsync(runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Changes the scrubbing thresholds for an asset that is assigned a public IP address.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2><a href="#qps-"></a>Limits</h2>
        /// <para>You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ModifyDefenseThresholdRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyDefenseThresholdResponse
        /// </returns>
        public ModifyDefenseThresholdResponse ModifyDefenseThresholdWithOptions(ModifyDefenseThresholdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Bps))
            {
                query["Bps"] = request.Bps;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DdosRegionId))
            {
                query["DdosRegionId"] = request.DdosRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceType))
            {
                query["InstanceType"] = request.InstanceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InternetIp))
            {
                query["InternetIp"] = request.InternetIp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsAuto))
            {
                query["IsAuto"] = request.IsAuto;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Pps))
            {
                query["Pps"] = request.Pps;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyDefenseThreshold",
                Version = "2017-05-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyDefenseThresholdResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Changes the scrubbing thresholds for an asset that is assigned a public IP address.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2><a href="#qps-"></a>Limits</h2>
        /// <para>You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ModifyDefenseThresholdRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyDefenseThresholdResponse
        /// </returns>
        public async Task<ModifyDefenseThresholdResponse> ModifyDefenseThresholdWithOptionsAsync(ModifyDefenseThresholdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Bps))
            {
                query["Bps"] = request.Bps;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ClientToken))
            {
                query["ClientToken"] = request.ClientToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DdosRegionId))
            {
                query["DdosRegionId"] = request.DdosRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceType))
            {
                query["InstanceType"] = request.InstanceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InternetIp))
            {
                query["InternetIp"] = request.InternetIp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsAuto))
            {
                query["IsAuto"] = request.IsAuto;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Pps))
            {
                query["Pps"] = request.Pps;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyDefenseThreshold",
                Version = "2017-05-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyDefenseThresholdResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Changes the scrubbing thresholds for an asset that is assigned a public IP address.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2><a href="#qps-"></a>Limits</h2>
        /// <para>You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ModifyDefenseThresholdRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyDefenseThresholdResponse
        /// </returns>
        public ModifyDefenseThresholdResponse ModifyDefenseThreshold(ModifyDefenseThresholdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyDefenseThresholdWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Changes the scrubbing thresholds for an asset that is assigned a public IP address.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2><a href="#qps-"></a>Limits</h2>
        /// <para>You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ModifyDefenseThresholdRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyDefenseThresholdResponse
        /// </returns>
        public async Task<ModifyDefenseThresholdResponse> ModifyDefenseThresholdAsync(ModifyDefenseThresholdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyDefenseThresholdWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the scrubbing thresholds for an asset that is assigned a public IP address. This operation is a synchronous operation that supports Terraform.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Limits</h3>
        /// <para>You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ModifyIpDefenseThresholdRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyIpDefenseThresholdResponse
        /// </returns>
        public ModifyIpDefenseThresholdResponse ModifyIpDefenseThresholdWithOptions(ModifyIpDefenseThresholdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Bps))
            {
                query["Bps"] = request.Bps;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DdosRegionId))
            {
                query["DdosRegionId"] = request.DdosRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceType))
            {
                query["InstanceType"] = request.InstanceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InternetIp))
            {
                query["InternetIp"] = request.InternetIp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsAuto))
            {
                query["IsAuto"] = request.IsAuto;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Pps))
            {
                query["Pps"] = request.Pps;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyIpDefenseThreshold",
                Version = "2017-05-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyIpDefenseThresholdResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the scrubbing thresholds for an asset that is assigned a public IP address. This operation is a synchronous operation that supports Terraform.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Limits</h3>
        /// <para>You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ModifyIpDefenseThresholdRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ModifyIpDefenseThresholdResponse
        /// </returns>
        public async Task<ModifyIpDefenseThresholdResponse> ModifyIpDefenseThresholdWithOptionsAsync(ModifyIpDefenseThresholdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Bps))
            {
                query["Bps"] = request.Bps;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DdosRegionId))
            {
                query["DdosRegionId"] = request.DdosRegionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                query["InstanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceType))
            {
                query["InstanceType"] = request.InstanceType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InternetIp))
            {
                query["InternetIp"] = request.InternetIp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsAuto))
            {
                query["IsAuto"] = request.IsAuto;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Pps))
            {
                query["Pps"] = request.Pps;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ModifyIpDefenseThreshold",
                Version = "2017-05-18",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ModifyIpDefenseThresholdResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the scrubbing thresholds for an asset that is assigned a public IP address. This operation is a synchronous operation that supports Terraform.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Limits</h3>
        /// <para>You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ModifyIpDefenseThresholdRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyIpDefenseThresholdResponse
        /// </returns>
        public ModifyIpDefenseThresholdResponse ModifyIpDefenseThreshold(ModifyIpDefenseThresholdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyIpDefenseThresholdWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the scrubbing thresholds for an asset that is assigned a public IP address. This operation is a synchronous operation that supports Terraform.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h3>Limits</h3>
        /// <para>You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ModifyIpDefenseThresholdRequest
        /// </param>
        /// 
        /// <returns>
        /// ModifyIpDefenseThresholdResponse
        /// </returns>
        public async Task<ModifyIpDefenseThresholdResponse> ModifyIpDefenseThresholdAsync(ModifyIpDefenseThresholdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyIpDefenseThresholdWithOptionsAsync(request, runtime);
        }

    }
}
