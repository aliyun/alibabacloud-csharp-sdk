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
                {"ap-northeast-1", "antiddos-openapi.ap-northeast-1.aliyuncs.com"},
                {"ap-northeast-2-pop", "antiddos.aliyuncs.com"},
                {"ap-south-1", "antiddos-openapi.ap-south-1.aliyuncs.com"},
                {"ap-southeast-1", "antiddos.aliyuncs.com"},
                {"ap-southeast-2", "antiddos-openapi.ap-southeast-2.aliyuncs.com"},
                {"ap-southeast-3", "antiddos-openapi.ap-southeast-3.aliyuncs.com"},
                {"ap-southeast-5", "antiddos-openapi-vpc.ap-southeast-5.aliyuncs.com"},
                {"cn-beijing", "antiddos-openapi-vpc.cn-beijing.aliyuncs.com"},
                {"cn-beijing-finance-1", "antiddos.aliyuncs.com"},
                {"cn-beijing-finance-pop", "antiddos.aliyuncs.com"},
                {"cn-beijing-gov-1", "antiddos.aliyuncs.com"},
                {"cn-beijing-nu16-b01", "antiddos.aliyuncs.com"},
                {"cn-chengdu", "antiddos-openapi.cn-chengdu.aliyuncs.com"},
                {"cn-edge-1", "antiddos.aliyuncs.com"},
                {"cn-fujian", "antiddos.aliyuncs.com"},
                {"cn-haidian-cm12-c01", "antiddos.aliyuncs.com"},
                {"cn-hangzhou", "antiddos-openapi-vpc.cn-hangzhou.aliyuncs.com"},
                {"cn-hangzhou-bj-b01", "antiddos.aliyuncs.com"},
                {"cn-hangzhou-finance", "antiddos.aliyuncs.com"},
                {"cn-hangzhou-internal-prod-1", "antiddos.aliyuncs.com"},
                {"cn-hangzhou-internal-test-1", "antiddos.aliyuncs.com"},
                {"cn-hangzhou-internal-test-2", "antiddos.aliyuncs.com"},
                {"cn-hangzhou-internal-test-3", "antiddos.aliyuncs.com"},
                {"cn-hangzhou-test-306", "antiddos.aliyuncs.com"},
                {"cn-hongkong", "antiddos-openapi-vpc.cn-hongkong.aliyuncs.com"},
                {"cn-hongkong-finance-pop", "antiddos.aliyuncs.com"},
                {"cn-huhehaote", "antiddos-openapi.cn-huhehaote.aliyuncs.com"},
                {"cn-huhehaote-nebula-1", "antiddos.aliyuncs.com"},
                {"cn-north-2-gov-1", "antiddos.aliyuncs.com"},
                {"cn-qingdao", "antiddos-openapi-vpc.cn-qingdao.aliyuncs.com"},
                {"cn-qingdao-nebula", "antiddos.aliyuncs.com"},
                {"cn-shanghai", "antiddos-openapi-vpc.cn-shanghai.aliyuncs.com"},
                {"cn-shanghai-et15-b01", "antiddos.aliyuncs.com"},
                {"cn-shanghai-et2-b01", "antiddos.aliyuncs.com"},
                {"cn-shanghai-finance-1", "antiddos.aliyuncs.com"},
                {"cn-shanghai-inner", "antiddos.aliyuncs.com"},
                {"cn-shanghai-internal-test-1", "antiddos.aliyuncs.com"},
                {"cn-shenzhen", "antiddos.aliyuncs.com"},
                {"cn-shenzhen-finance-1", "antiddos.aliyuncs.com"},
                {"cn-shenzhen-inner", "antiddos.aliyuncs.com"},
                {"cn-shenzhen-st4-d01", "antiddos.aliyuncs.com"},
                {"cn-shenzhen-su18-b01", "antiddos.aliyuncs.com"},
                {"cn-wuhan", "antiddos.aliyuncs.com"},
                {"cn-wulanchabu", "antiddos-openapi.cn-wulanchabu.aliyuncs.com"},
                {"cn-yushanfang", "antiddos.aliyuncs.com"},
                {"cn-zhangbei", "antiddos.aliyuncs.com"},
                {"cn-zhangbei-na61-b01", "antiddos.aliyuncs.com"},
                {"cn-zhangjiakou", "antiddos-openapi.cn-zhangjiakou.aliyuncs.com"},
                {"cn-zhangjiakou-na62-a01", "antiddos.aliyuncs.com"},
                {"cn-zhengzhou-nebula-1", "antiddos.aliyuncs.com"},
                {"eu-central-1", "antiddos-openapi.eu-central-1.aliyuncs.com"},
                {"eu-west-1", "antiddos-openapi.eu-west-1.aliyuncs.com"},
                {"eu-west-1-oxs", "antiddos.aliyuncs.com"},
                {"me-east-1", "antiddos-openapi.me-east-1.aliyuncs.com"},
                {"rus-west-1-pop", "antiddos.aliyuncs.com"},
                {"us-east-1", "antiddos.aliyuncs.com"},
                {"us-west-1", "antiddos.aliyuncs.com"},
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

        /**
         * @summary Queries the configurations of the Anti-DDoS Origin Basic instance that is associated with an asset. The asset can be an elastic IP address (EIP). The asset can also be an Elastic Compute Service (ECS) instance or Server Load Balancer (SLB) instance that is assigned a public IP address.
         *
         * @description You can call the DescribeBgpPackByIp operation to query the configurations of the Anti-DDoS Origin instance that is associated with an asset. The configurations include the basic protection threshold, burstable protection threshold, and expiration time.
         * ## Limits
         * You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request DescribeBgpPackByIpRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeBgpPackByIpResponse
         */
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

        /**
         * @summary Queries the configurations of the Anti-DDoS Origin Basic instance that is associated with an asset. The asset can be an elastic IP address (EIP). The asset can also be an Elastic Compute Service (ECS) instance or Server Load Balancer (SLB) instance that is assigned a public IP address.
         *
         * @description You can call the DescribeBgpPackByIp operation to query the configurations of the Anti-DDoS Origin instance that is associated with an asset. The configurations include the basic protection threshold, burstable protection threshold, and expiration time.
         * ## Limits
         * You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request DescribeBgpPackByIpRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeBgpPackByIpResponse
         */
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

        /**
         * @summary Queries the configurations of the Anti-DDoS Origin Basic instance that is associated with an asset. The asset can be an elastic IP address (EIP). The asset can also be an Elastic Compute Service (ECS) instance or Server Load Balancer (SLB) instance that is assigned a public IP address.
         *
         * @description You can call the DescribeBgpPackByIp operation to query the configurations of the Anti-DDoS Origin instance that is associated with an asset. The configurations include the basic protection threshold, burstable protection threshold, and expiration time.
         * ## Limits
         * You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request DescribeBgpPackByIpRequest
         * @return DescribeBgpPackByIpResponse
         */
        public DescribeBgpPackByIpResponse DescribeBgpPackByIp(DescribeBgpPackByIpRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeBgpPackByIpWithOptions(request, runtime);
        }

        /**
         * @summary Queries the configurations of the Anti-DDoS Origin Basic instance that is associated with an asset. The asset can be an elastic IP address (EIP). The asset can also be an Elastic Compute Service (ECS) instance or Server Load Balancer (SLB) instance that is assigned a public IP address.
         *
         * @description You can call the DescribeBgpPackByIp operation to query the configurations of the Anti-DDoS Origin instance that is associated with an asset. The configurations include the basic protection threshold, burstable protection threshold, and expiration time.
         * ## Limits
         * You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request DescribeBgpPackByIpRequest
         * @return DescribeBgpPackByIpResponse
         */
        public async Task<DescribeBgpPackByIpResponse> DescribeBgpPackByIpAsync(DescribeBgpPackByIpRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeBgpPackByIpWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the download link to the traffic data that is captured when a DDoS attack event occurs.
         *
         * @description You can call the DescribeCap operation to query the download link to the traffic data that is captured when a DDoS attack event occurs. You can download the traffic data from the download link and use the data as evidence.
         * ## Limits
         * You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request DescribeCapRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeCapResponse
         */
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

        /**
         * @summary Queries the download link to the traffic data that is captured when a DDoS attack event occurs.
         *
         * @description You can call the DescribeCap operation to query the download link to the traffic data that is captured when a DDoS attack event occurs. You can download the traffic data from the download link and use the data as evidence.
         * ## Limits
         * You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request DescribeCapRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeCapResponse
         */
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

        /**
         * @summary Queries the download link to the traffic data that is captured when a DDoS attack event occurs.
         *
         * @description You can call the DescribeCap operation to query the download link to the traffic data that is captured when a DDoS attack event occurs. You can download the traffic data from the download link and use the data as evidence.
         * ## Limits
         * You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request DescribeCapRequest
         * @return DescribeCapResponse
         */
        public DescribeCapResponse DescribeCap(DescribeCapRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeCapWithOptions(request, runtime);
        }

        /**
         * @summary Queries the download link to the traffic data that is captured when a DDoS attack event occurs.
         *
         * @description You can call the DescribeCap operation to query the download link to the traffic data that is captured when a DDoS attack event occurs. You can download the traffic data from the download link and use the data as evidence.
         * ## Limits
         * You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request DescribeCapRequest
         * @return DescribeCapResponse
         */
        public async Task<DescribeCapResponse> DescribeCapAsync(DescribeCapRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeCapWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the number of assets that are under DDoS attacks in a specific region. The assets can be elastic IP addresses (EIPs). The assets can also be Elastic Compute Service (ECS) instances or Server Load Balancer (SLB) instances that are assigned public IP addresses.
         *
         * @description You can call the DescribeDdosCount operation to query the number of assets that are under DDoS attacks in a specific region.
         * ## Limits
         * You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request DescribeDdosCountRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeDdosCountResponse
         */
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

        /**
         * @summary Queries the number of assets that are under DDoS attacks in a specific region. The assets can be elastic IP addresses (EIPs). The assets can also be Elastic Compute Service (ECS) instances or Server Load Balancer (SLB) instances that are assigned public IP addresses.
         *
         * @description You can call the DescribeDdosCount operation to query the number of assets that are under DDoS attacks in a specific region.
         * ## Limits
         * You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request DescribeDdosCountRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeDdosCountResponse
         */
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

        /**
         * @summary Queries the number of assets that are under DDoS attacks in a specific region. The assets can be elastic IP addresses (EIPs). The assets can also be Elastic Compute Service (ECS) instances or Server Load Balancer (SLB) instances that are assigned public IP addresses.
         *
         * @description You can call the DescribeDdosCount operation to query the number of assets that are under DDoS attacks in a specific region.
         * ## Limits
         * You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request DescribeDdosCountRequest
         * @return DescribeDdosCountResponse
         */
        public DescribeDdosCountResponse DescribeDdosCount(DescribeDdosCountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDdosCountWithOptions(request, runtime);
        }

        /**
         * @summary Queries the number of assets that are under DDoS attacks in a specific region. The assets can be elastic IP addresses (EIPs). The assets can also be Elastic Compute Service (ECS) instances or Server Load Balancer (SLB) instances that are assigned public IP addresses.
         *
         * @description You can call the DescribeDdosCount operation to query the number of assets that are under DDoS attacks in a specific region.
         * ## Limits
         * You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request DescribeDdosCountRequest
         * @return DescribeDdosCountResponse
         */
        public async Task<DescribeDdosCountResponse> DescribeDdosCountAsync(DescribeDdosCountRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDdosCountWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the details of the security credit score of the current Alibaba Cloud account in a specific region.
         *
         * @description You can call the DescribeDdosCredit operation to query the details of the security credit score of the current Alibaba Cloud account in a specific region. The details include the security credit score, security credit level, and the time period after which blackhole filtering is automatically deactivated.
         * ## Limits
         * You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request DescribeDdosCreditRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeDdosCreditResponse
         */
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

        /**
         * @summary Queries the details of the security credit score of the current Alibaba Cloud account in a specific region.
         *
         * @description You can call the DescribeDdosCredit operation to query the details of the security credit score of the current Alibaba Cloud account in a specific region. The details include the security credit score, security credit level, and the time period after which blackhole filtering is automatically deactivated.
         * ## Limits
         * You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request DescribeDdosCreditRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeDdosCreditResponse
         */
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

        /**
         * @summary Queries the details of the security credit score of the current Alibaba Cloud account in a specific region.
         *
         * @description You can call the DescribeDdosCredit operation to query the details of the security credit score of the current Alibaba Cloud account in a specific region. The details include the security credit score, security credit level, and the time period after which blackhole filtering is automatically deactivated.
         * ## Limits
         * You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request DescribeDdosCreditRequest
         * @return DescribeDdosCreditResponse
         */
        public DescribeDdosCreditResponse DescribeDdosCredit(DescribeDdosCreditRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDdosCreditWithOptions(request, runtime);
        }

        /**
         * @summary Queries the details of the security credit score of the current Alibaba Cloud account in a specific region.
         *
         * @description You can call the DescribeDdosCredit operation to query the details of the security credit score of the current Alibaba Cloud account in a specific region. The details include the security credit score, security credit level, and the time period after which blackhole filtering is automatically deactivated.
         * ## Limits
         * You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request DescribeDdosCreditRequest
         * @return DescribeDdosCreditResponse
         */
        public async Task<DescribeDdosCreditResponse> DescribeDdosCreditAsync(DescribeDdosCreditRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDdosCreditWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the details of the DDoS attack events that occur on an asset. The asset can be an Elastic IP address (EIP). The asset can also be an Elastic Compute Service (ECS) instance or Server Load Balancer (SLB) instance that is assigned a public IP address.
         *
         * @description You can call the DescribeDdosEventList operation to query the details of the DDoS attack events that occur on an asset by page. The details include the start time, end time, and status of each DDoS attack event.
         * ## Limits
         * You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request DescribeDdosEventListRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeDdosEventListResponse
         */
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

        /**
         * @summary Queries the details of the DDoS attack events that occur on an asset. The asset can be an Elastic IP address (EIP). The asset can also be an Elastic Compute Service (ECS) instance or Server Load Balancer (SLB) instance that is assigned a public IP address.
         *
         * @description You can call the DescribeDdosEventList operation to query the details of the DDoS attack events that occur on an asset by page. The details include the start time, end time, and status of each DDoS attack event.
         * ## Limits
         * You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request DescribeDdosEventListRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeDdosEventListResponse
         */
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

        /**
         * @summary Queries the details of the DDoS attack events that occur on an asset. The asset can be an Elastic IP address (EIP). The asset can also be an Elastic Compute Service (ECS) instance or Server Load Balancer (SLB) instance that is assigned a public IP address.
         *
         * @description You can call the DescribeDdosEventList operation to query the details of the DDoS attack events that occur on an asset by page. The details include the start time, end time, and status of each DDoS attack event.
         * ## Limits
         * You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request DescribeDdosEventListRequest
         * @return DescribeDdosEventListResponse
         */
        public DescribeDdosEventListResponse DescribeDdosEventList(DescribeDdosEventListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDdosEventListWithOptions(request, runtime);
        }

        /**
         * @summary Queries the details of the DDoS attack events that occur on an asset. The asset can be an Elastic IP address (EIP). The asset can also be an Elastic Compute Service (ECS) instance or Server Load Balancer (SLB) instance that is assigned a public IP address.
         *
         * @description You can call the DescribeDdosEventList operation to query the details of the DDoS attack events that occur on an asset by page. The details include the start time, end time, and status of each DDoS attack event.
         * ## Limits
         * You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request DescribeDdosEventListRequest
         * @return DescribeDdosEventListResponse
         */
        public async Task<DescribeDdosEventListResponse> DescribeDdosEventListAsync(DescribeDdosEventListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDdosEventListWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the details of the DDoS mitigation thresholds or traffic scrubbing thresholds for specified assets. The assets can be elastic IP addresses (EIPs). The assets can also be Elastic Compute Service (ECS) instances or Server Load Balancer (SLB) instances that are assigned public IP addresses.
         *
         * @description You can call the DescribeDdosThreshold operation to query the details of the DDoS mitigation thresholds or traffic scrubbing thresholds for specified assets. The details include the current traffic scrubbing threshold, maximum traffic scrubbing threshold, current DDoS mitigation threshold, and maximum DDoS mitigation threshold.
         * ### Limits
         * You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request DescribeDdosThresholdRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeDdosThresholdResponse
         */
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

        /**
         * @summary Queries the details of the DDoS mitigation thresholds or traffic scrubbing thresholds for specified assets. The assets can be elastic IP addresses (EIPs). The assets can also be Elastic Compute Service (ECS) instances or Server Load Balancer (SLB) instances that are assigned public IP addresses.
         *
         * @description You can call the DescribeDdosThreshold operation to query the details of the DDoS mitigation thresholds or traffic scrubbing thresholds for specified assets. The details include the current traffic scrubbing threshold, maximum traffic scrubbing threshold, current DDoS mitigation threshold, and maximum DDoS mitigation threshold.
         * ### Limits
         * You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request DescribeDdosThresholdRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeDdosThresholdResponse
         */
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

        /**
         * @summary Queries the details of the DDoS mitigation thresholds or traffic scrubbing thresholds for specified assets. The assets can be elastic IP addresses (EIPs). The assets can also be Elastic Compute Service (ECS) instances or Server Load Balancer (SLB) instances that are assigned public IP addresses.
         *
         * @description You can call the DescribeDdosThreshold operation to query the details of the DDoS mitigation thresholds or traffic scrubbing thresholds for specified assets. The details include the current traffic scrubbing threshold, maximum traffic scrubbing threshold, current DDoS mitigation threshold, and maximum DDoS mitigation threshold.
         * ### Limits
         * You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request DescribeDdosThresholdRequest
         * @return DescribeDdosThresholdResponse
         */
        public DescribeDdosThresholdResponse DescribeDdosThreshold(DescribeDdosThresholdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeDdosThresholdWithOptions(request, runtime);
        }

        /**
         * @summary Queries the details of the DDoS mitigation thresholds or traffic scrubbing thresholds for specified assets. The assets can be elastic IP addresses (EIPs). The assets can also be Elastic Compute Service (ECS) instances or Server Load Balancer (SLB) instances that are assigned public IP addresses.
         *
         * @description You can call the DescribeDdosThreshold operation to query the details of the DDoS mitigation thresholds or traffic scrubbing thresholds for specified assets. The details include the current traffic scrubbing threshold, maximum traffic scrubbing threshold, current DDoS mitigation threshold, and maximum DDoS mitigation threshold.
         * ### Limits
         * You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request DescribeDdosThresholdRequest
         * @return DescribeDdosThresholdResponse
         */
        public async Task<DescribeDdosThresholdResponse> DescribeDdosThresholdAsync(DescribeDdosThresholdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeDdosThresholdWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the details of the assets within the current Alibaba Cloud account. The assets can be elastic IP addresses (EIPs). The assets can also be Elastic Compute Service (ECS) instances or Server Load Balancer (SLB) instances that are assigned public IP addresses.
         *
         * @description You can call the DescribeInstance operation to query the details of the assets that are within the current Alibaba Cloud account by page. The details include the IDs and IP addresses of the assets, the basic protection thresholds and traffic scrubbing thresholds that are configured for the assets in Anti-DDoS Origin Basic, and whether the assets are associated with Anti-DDoS Origin Basic instances.
         * ### Limits
         * You can call this operation up to 200 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request DescribeInstanceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeInstanceResponse
         */
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

        /**
         * @summary Queries the details of the assets within the current Alibaba Cloud account. The assets can be elastic IP addresses (EIPs). The assets can also be Elastic Compute Service (ECS) instances or Server Load Balancer (SLB) instances that are assigned public IP addresses.
         *
         * @description You can call the DescribeInstance operation to query the details of the assets that are within the current Alibaba Cloud account by page. The details include the IDs and IP addresses of the assets, the basic protection thresholds and traffic scrubbing thresholds that are configured for the assets in Anti-DDoS Origin Basic, and whether the assets are associated with Anti-DDoS Origin Basic instances.
         * ### Limits
         * You can call this operation up to 200 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request DescribeInstanceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeInstanceResponse
         */
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

        /**
         * @summary Queries the details of the assets within the current Alibaba Cloud account. The assets can be elastic IP addresses (EIPs). The assets can also be Elastic Compute Service (ECS) instances or Server Load Balancer (SLB) instances that are assigned public IP addresses.
         *
         * @description You can call the DescribeInstance operation to query the details of the assets that are within the current Alibaba Cloud account by page. The details include the IDs and IP addresses of the assets, the basic protection thresholds and traffic scrubbing thresholds that are configured for the assets in Anti-DDoS Origin Basic, and whether the assets are associated with Anti-DDoS Origin Basic instances.
         * ### Limits
         * You can call this operation up to 200 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request DescribeInstanceRequest
         * @return DescribeInstanceResponse
         */
        public DescribeInstanceResponse DescribeInstance(DescribeInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeInstanceWithOptions(request, runtime);
        }

        /**
         * @summary Queries the details of the assets within the current Alibaba Cloud account. The assets can be elastic IP addresses (EIPs). The assets can also be Elastic Compute Service (ECS) instances or Server Load Balancer (SLB) instances that are assigned public IP addresses.
         *
         * @description You can call the DescribeInstance operation to query the details of the assets that are within the current Alibaba Cloud account by page. The details include the IDs and IP addresses of the assets, the basic protection thresholds and traffic scrubbing thresholds that are configured for the assets in Anti-DDoS Origin Basic, and whether the assets are associated with Anti-DDoS Origin Basic instances.
         * ### Limits
         * You can call this operation up to 200 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request DescribeInstanceRequest
         * @return DescribeInstanceResponse
         */
        public async Task<DescribeInstanceResponse> DescribeInstanceAsync(DescribeInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeInstanceWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the details of the assets within the current Alibaba Cloud account and the details of the Anti-DDoS Origin instance to which the assets belong. The assets can be elastic IP addresses (EIPs). The assets can also be Elastic Compute Service (ECS) instances or Server Load Balancer (SLB) instances that are assigned public IP addresses.
         *
         * @description If one or more assets of the current Alibaba Cloud account are added to an Anti-DDoS Origin instance, you can call the DescribeInstanceIpAddress operation to query the DDoS mitigation information and the details of the Anti-DDoS Origin instance. The information and the details include the basic protection threshold and traffic scrubbing threshold for the assets, DDoS mitigation status of the assets, ID of the instance, and the mitigation status of the instance.
         * ## Limits
         * You can call this operation up to 200 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request DescribeInstanceIpAddressRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeInstanceIpAddressResponse
         */
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

        /**
         * @summary Queries the details of the assets within the current Alibaba Cloud account and the details of the Anti-DDoS Origin instance to which the assets belong. The assets can be elastic IP addresses (EIPs). The assets can also be Elastic Compute Service (ECS) instances or Server Load Balancer (SLB) instances that are assigned public IP addresses.
         *
         * @description If one or more assets of the current Alibaba Cloud account are added to an Anti-DDoS Origin instance, you can call the DescribeInstanceIpAddress operation to query the DDoS mitigation information and the details of the Anti-DDoS Origin instance. The information and the details include the basic protection threshold and traffic scrubbing threshold for the assets, DDoS mitigation status of the assets, ID of the instance, and the mitigation status of the instance.
         * ## Limits
         * You can call this operation up to 200 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request DescribeInstanceIpAddressRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeInstanceIpAddressResponse
         */
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

        /**
         * @summary Queries the details of the assets within the current Alibaba Cloud account and the details of the Anti-DDoS Origin instance to which the assets belong. The assets can be elastic IP addresses (EIPs). The assets can also be Elastic Compute Service (ECS) instances or Server Load Balancer (SLB) instances that are assigned public IP addresses.
         *
         * @description If one or more assets of the current Alibaba Cloud account are added to an Anti-DDoS Origin instance, you can call the DescribeInstanceIpAddress operation to query the DDoS mitigation information and the details of the Anti-DDoS Origin instance. The information and the details include the basic protection threshold and traffic scrubbing threshold for the assets, DDoS mitigation status of the assets, ID of the instance, and the mitigation status of the instance.
         * ## Limits
         * You can call this operation up to 200 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request DescribeInstanceIpAddressRequest
         * @return DescribeInstanceIpAddressResponse
         */
        public DescribeInstanceIpAddressResponse DescribeInstanceIpAddress(DescribeInstanceIpAddressRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeInstanceIpAddressWithOptions(request, runtime);
        }

        /**
         * @summary Queries the details of the assets within the current Alibaba Cloud account and the details of the Anti-DDoS Origin instance to which the assets belong. The assets can be elastic IP addresses (EIPs). The assets can also be Elastic Compute Service (ECS) instances or Server Load Balancer (SLB) instances that are assigned public IP addresses.
         *
         * @description If one or more assets of the current Alibaba Cloud account are added to an Anti-DDoS Origin instance, you can call the DescribeInstanceIpAddress operation to query the DDoS mitigation information and the details of the Anti-DDoS Origin instance. The information and the details include the basic protection threshold and traffic scrubbing threshold for the assets, DDoS mitigation status of the assets, ID of the instance, and the mitigation status of the instance.
         * ## Limits
         * You can call this operation up to 200 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request DescribeInstanceIpAddressRequest
         * @return DescribeInstanceIpAddressResponse
         */
        public async Task<DescribeInstanceIpAddressResponse> DescribeInstanceIpAddressAsync(DescribeInstanceIpAddressRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeInstanceIpAddressWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the details of the DDoS mitigation thresholds or traffic scrubbing thresholds for specified assets. The assets can be elastic IP addresses (EIPs). The assets can also be Elastic Compute Service (ECS) instances or Server Load Balancer (SLB) instances that are assigned public IP addresses.
         *
         * @description If one or more assets of the current Alibaba Cloud account are added to an Anti-DDoS Origin instance, you can call the DescribeIpDdosThreshold operation to query the details of the DDoS mitigation threshold or traffic scrubbing threshold for a specific asset. The details include the current traffic scrubbing threshold, maximum scrubbing threshold, current DDoS mitigation threshold, and maximum DDoS mitigation threshold.
         * ## Limits
         * You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request DescribeIpDdosThresholdRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeIpDdosThresholdResponse
         */
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

        /**
         * @summary Queries the details of the DDoS mitigation thresholds or traffic scrubbing thresholds for specified assets. The assets can be elastic IP addresses (EIPs). The assets can also be Elastic Compute Service (ECS) instances or Server Load Balancer (SLB) instances that are assigned public IP addresses.
         *
         * @description If one or more assets of the current Alibaba Cloud account are added to an Anti-DDoS Origin instance, you can call the DescribeIpDdosThreshold operation to query the details of the DDoS mitigation threshold or traffic scrubbing threshold for a specific asset. The details include the current traffic scrubbing threshold, maximum scrubbing threshold, current DDoS mitigation threshold, and maximum DDoS mitigation threshold.
         * ## Limits
         * You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request DescribeIpDdosThresholdRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeIpDdosThresholdResponse
         */
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

        /**
         * @summary Queries the details of the DDoS mitigation thresholds or traffic scrubbing thresholds for specified assets. The assets can be elastic IP addresses (EIPs). The assets can also be Elastic Compute Service (ECS) instances or Server Load Balancer (SLB) instances that are assigned public IP addresses.
         *
         * @description If one or more assets of the current Alibaba Cloud account are added to an Anti-DDoS Origin instance, you can call the DescribeIpDdosThreshold operation to query the details of the DDoS mitigation threshold or traffic scrubbing threshold for a specific asset. The details include the current traffic scrubbing threshold, maximum scrubbing threshold, current DDoS mitigation threshold, and maximum DDoS mitigation threshold.
         * ## Limits
         * You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request DescribeIpDdosThresholdRequest
         * @return DescribeIpDdosThresholdResponse
         */
        public DescribeIpDdosThresholdResponse DescribeIpDdosThreshold(DescribeIpDdosThresholdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeIpDdosThresholdWithOptions(request, runtime);
        }

        /**
         * @summary Queries the details of the DDoS mitigation thresholds or traffic scrubbing thresholds for specified assets. The assets can be elastic IP addresses (EIPs). The assets can also be Elastic Compute Service (ECS) instances or Server Load Balancer (SLB) instances that are assigned public IP addresses.
         *
         * @description If one or more assets of the current Alibaba Cloud account are added to an Anti-DDoS Origin instance, you can call the DescribeIpDdosThreshold operation to query the details of the DDoS mitigation threshold or traffic scrubbing threshold for a specific asset. The details include the current traffic scrubbing threshold, maximum scrubbing threshold, current DDoS mitigation threshold, and maximum DDoS mitigation threshold.
         * ## Limits
         * You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request DescribeIpDdosThresholdRequest
         * @return DescribeIpDdosThresholdResponse
         */
        public async Task<DescribeIpDdosThresholdResponse> DescribeIpDdosThresholdAsync(DescribeIpDdosThresholdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeIpDdosThresholdWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the region in which an asset within the current Alibaba Cloud account resides. The asset can be an elastic IP address (EIP). The asset can also be an Elastic Compute Service (ECS) instance or Server Load Balancer (SLB) instance that is assigned a public IP address.
         *
         * @description You can call the DescribeIpLocationService operation to query the region of the public IP address for a specified asset that is within the current Alibaba Cloud account. You can also query the details of the Anti-DDoS Origin instance to which the asset is added. The details include the ID and name.
         * ## Limits
         * You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request DescribeIpLocationServiceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeIpLocationServiceResponse
         */
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

        /**
         * @summary Queries the region in which an asset within the current Alibaba Cloud account resides. The asset can be an elastic IP address (EIP). The asset can also be an Elastic Compute Service (ECS) instance or Server Load Balancer (SLB) instance that is assigned a public IP address.
         *
         * @description You can call the DescribeIpLocationService operation to query the region of the public IP address for a specified asset that is within the current Alibaba Cloud account. You can also query the details of the Anti-DDoS Origin instance to which the asset is added. The details include the ID and name.
         * ## Limits
         * You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request DescribeIpLocationServiceRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeIpLocationServiceResponse
         */
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

        /**
         * @summary Queries the region in which an asset within the current Alibaba Cloud account resides. The asset can be an elastic IP address (EIP). The asset can also be an Elastic Compute Service (ECS) instance or Server Load Balancer (SLB) instance that is assigned a public IP address.
         *
         * @description You can call the DescribeIpLocationService operation to query the region of the public IP address for a specified asset that is within the current Alibaba Cloud account. You can also query the details of the Anti-DDoS Origin instance to which the asset is added. The details include the ID and name.
         * ## Limits
         * You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request DescribeIpLocationServiceRequest
         * @return DescribeIpLocationServiceResponse
         */
        public DescribeIpLocationServiceResponse DescribeIpLocationService(DescribeIpLocationServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeIpLocationServiceWithOptions(request, runtime);
        }

        /**
         * @summary Queries the region in which an asset within the current Alibaba Cloud account resides. The asset can be an elastic IP address (EIP). The asset can also be an Elastic Compute Service (ECS) instance or Server Load Balancer (SLB) instance that is assigned a public IP address.
         *
         * @description You can call the DescribeIpLocationService operation to query the region of the public IP address for a specified asset that is within the current Alibaba Cloud account. You can also query the details of the Anti-DDoS Origin instance to which the asset is added. The details include the ID and name.
         * ## Limits
         * You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request DescribeIpLocationServiceRequest
         * @return DescribeIpLocationServiceResponse
         */
        public async Task<DescribeIpLocationServiceResponse> DescribeIpLocationServiceAsync(DescribeIpLocationServiceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeIpLocationServiceWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Queries the regions in which Anti-DDoS Origin Basic is available.
         *
         * @description You can call this operation to query information about the regions in which Anti-DDoS Origin Basic is available. The information includes the region ID, region name, and code.
         * ## Limits
         * You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request DescribeRegionsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeRegionsResponse
         */
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

        /**
         * @summary Queries the regions in which Anti-DDoS Origin Basic is available.
         *
         * @description You can call this operation to query information about the regions in which Anti-DDoS Origin Basic is available. The information includes the region ID, region name, and code.
         * ## Limits
         * You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request DescribeRegionsRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeRegionsResponse
         */
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

        /**
         * @summary Queries the regions in which Anti-DDoS Origin Basic is available.
         *
         * @description You can call this operation to query information about the regions in which Anti-DDoS Origin Basic is available. The information includes the region ID, region name, and code.
         * ## Limits
         * You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @return DescribeRegionsResponse
         */
        public DescribeRegionsResponse DescribeRegions()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeRegionsWithOptions(runtime);
        }

        /**
         * @summary Queries the regions in which Anti-DDoS Origin Basic is available.
         *
         * @description You can call this operation to query information about the regions in which Anti-DDoS Origin Basic is available. The information includes the region ID, region name, and code.
         * ## Limits
         * You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @return DescribeRegionsResponse
         */
        public async Task<DescribeRegionsResponse> DescribeRegionsAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeRegionsWithOptionsAsync(runtime);
        }

        /**
         * @summary Changes the scrubbing thresholds for an asset. The asset can be an elastic IP address (EIP). The asset can also be an Elastic Compute Service (ECS) instance or Server Load Balancer (SLB) instance that is assigned a public IP address.
         *
         * @description You can call the ModifyDefenseThreshold operation to change the scrubbing thresholds for an asset.
         * ## Limits
         * You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request ModifyDefenseThresholdRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyDefenseThresholdResponse
         */
        public ModifyDefenseThresholdResponse ModifyDefenseThresholdWithOptions(ModifyDefenseThresholdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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

        /**
         * @summary Changes the scrubbing thresholds for an asset. The asset can be an elastic IP address (EIP). The asset can also be an Elastic Compute Service (ECS) instance or Server Load Balancer (SLB) instance that is assigned a public IP address.
         *
         * @description You can call the ModifyDefenseThreshold operation to change the scrubbing thresholds for an asset.
         * ## Limits
         * You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request ModifyDefenseThresholdRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyDefenseThresholdResponse
         */
        public async Task<ModifyDefenseThresholdResponse> ModifyDefenseThresholdWithOptionsAsync(ModifyDefenseThresholdRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
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

        /**
         * @summary Changes the scrubbing thresholds for an asset. The asset can be an elastic IP address (EIP). The asset can also be an Elastic Compute Service (ECS) instance or Server Load Balancer (SLB) instance that is assigned a public IP address.
         *
         * @description You can call the ModifyDefenseThreshold operation to change the scrubbing thresholds for an asset.
         * ## Limits
         * You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request ModifyDefenseThresholdRequest
         * @return ModifyDefenseThresholdResponse
         */
        public ModifyDefenseThresholdResponse ModifyDefenseThreshold(ModifyDefenseThresholdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyDefenseThresholdWithOptions(request, runtime);
        }

        /**
         * @summary Changes the scrubbing thresholds for an asset. The asset can be an elastic IP address (EIP). The asset can also be an Elastic Compute Service (ECS) instance or Server Load Balancer (SLB) instance that is assigned a public IP address.
         *
         * @description You can call the ModifyDefenseThreshold operation to change the scrubbing thresholds for an asset.
         * ## Limits
         * You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request ModifyDefenseThresholdRequest
         * @return ModifyDefenseThresholdResponse
         */
        public async Task<ModifyDefenseThresholdResponse> ModifyDefenseThresholdAsync(ModifyDefenseThresholdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyDefenseThresholdWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Changes the traffic scrubbing thresholds for an asset. The asset can be an elastic IP addresses (EIP). The asset can also be an Elastic Compute Service (ECS) instance or Server Load Balancer (SLB) instance that is assigned a public IP address.
         *
         * @description ### Limits
         * You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request ModifyIpDefenseThresholdRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyIpDefenseThresholdResponse
         */
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

        /**
         * @summary Changes the traffic scrubbing thresholds for an asset. The asset can be an elastic IP addresses (EIP). The asset can also be an Elastic Compute Service (ECS) instance or Server Load Balancer (SLB) instance that is assigned a public IP address.
         *
         * @description ### Limits
         * You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request ModifyIpDefenseThresholdRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ModifyIpDefenseThresholdResponse
         */
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

        /**
         * @summary Changes the traffic scrubbing thresholds for an asset. The asset can be an elastic IP addresses (EIP). The asset can also be an Elastic Compute Service (ECS) instance or Server Load Balancer (SLB) instance that is assigned a public IP address.
         *
         * @description ### Limits
         * You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request ModifyIpDefenseThresholdRequest
         * @return ModifyIpDefenseThresholdResponse
         */
        public ModifyIpDefenseThresholdResponse ModifyIpDefenseThreshold(ModifyIpDefenseThresholdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ModifyIpDefenseThresholdWithOptions(request, runtime);
        }

        /**
         * @summary Changes the traffic scrubbing thresholds for an asset. The asset can be an elastic IP addresses (EIP). The asset can also be an Elastic Compute Service (ECS) instance or Server Load Balancer (SLB) instance that is assigned a public IP address.
         *
         * @description ### Limits
         * You can call this operation up to 10 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request ModifyIpDefenseThresholdRequest
         * @return ModifyIpDefenseThresholdResponse
         */
        public async Task<ModifyIpDefenseThresholdResponse> ModifyIpDefenseThresholdAsync(ModifyIpDefenseThresholdRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ModifyIpDefenseThresholdWithOptionsAsync(request, runtime);
        }

    }
}
