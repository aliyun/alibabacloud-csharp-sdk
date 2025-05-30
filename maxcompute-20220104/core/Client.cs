// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.MaxCompute20220104.Models;

namespace AlibabaCloud.SDK.MaxCompute20220104
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "regional";
            this._endpointMap = new Dictionary<string, string>
            {
                {"ap-northeast-1", "maxcompute.aliyuncs.com"},
                {"ap-northeast-2-pop", "maxcompute.aliyuncs.com"},
                {"ap-south-1", "maxcompute.aliyuncs.com"},
                {"ap-southeast-1", "maxcompute.aliyuncs.com"},
                {"ap-southeast-2", "maxcompute.aliyuncs.com"},
                {"ap-southeast-3", "maxcompute.aliyuncs.com"},
                {"ap-southeast-5", "maxcompute.aliyuncs.com"},
                {"cn-beijing", "maxcompute.aliyuncs.com"},
                {"cn-beijing-finance-1", "maxcompute.aliyuncs.com"},
                {"cn-beijing-finance-pop", "maxcompute.aliyuncs.com"},
                {"cn-beijing-gov-1", "maxcompute.aliyuncs.com"},
                {"cn-beijing-nu16-b01", "maxcompute.aliyuncs.com"},
                {"cn-chengdu", "maxcompute.aliyuncs.com"},
                {"cn-edge-1", "maxcompute.aliyuncs.com"},
                {"cn-fujian", "maxcompute.aliyuncs.com"},
                {"cn-haidian-cm12-c01", "maxcompute.aliyuncs.com"},
                {"cn-hangzhou", "maxcompute.aliyuncs.com"},
                {"cn-hangzhou-bj-b01", "maxcompute.aliyuncs.com"},
                {"cn-hangzhou-finance", "maxcompute.aliyuncs.com"},
                {"cn-hangzhou-internal-prod-1", "maxcompute.aliyuncs.com"},
                {"cn-hangzhou-internal-test-1", "maxcompute.aliyuncs.com"},
                {"cn-hangzhou-internal-test-2", "maxcompute.aliyuncs.com"},
                {"cn-hangzhou-internal-test-3", "maxcompute.aliyuncs.com"},
                {"cn-hangzhou-test-306", "maxcompute.aliyuncs.com"},
                {"cn-hongkong", "maxcompute.aliyuncs.com"},
                {"cn-hongkong-finance-pop", "maxcompute.aliyuncs.com"},
                {"cn-huhehaote", "maxcompute.aliyuncs.com"},
                {"cn-north-2-gov-1", "maxcompute.aliyuncs.com"},
                {"cn-qingdao", "maxcompute.aliyuncs.com"},
                {"cn-qingdao-nebula", "maxcompute.aliyuncs.com"},
                {"cn-shanghai", "maxcompute.aliyuncs.com"},
                {"cn-shanghai-et15-b01", "maxcompute.aliyuncs.com"},
                {"cn-shanghai-et2-b01", "maxcompute.aliyuncs.com"},
                {"cn-shanghai-finance-1", "maxcompute.aliyuncs.com"},
                {"cn-shanghai-inner", "maxcompute.aliyuncs.com"},
                {"cn-shanghai-internal-test-1", "maxcompute.aliyuncs.com"},
                {"cn-shenzhen", "maxcompute.aliyuncs.com"},
                {"cn-shenzhen-finance-1", "maxcompute.aliyuncs.com"},
                {"cn-shenzhen-inner", "maxcompute.aliyuncs.com"},
                {"cn-shenzhen-st4-d01", "maxcompute.aliyuncs.com"},
                {"cn-shenzhen-su18-b01", "maxcompute.aliyuncs.com"},
                {"cn-wuhan", "maxcompute.aliyuncs.com"},
                {"cn-yushanfang", "maxcompute.aliyuncs.com"},
                {"cn-zhangbei-na61-b01", "maxcompute.aliyuncs.com"},
                {"cn-zhangjiakou", "maxcompute.aliyuncs.com"},
                {"cn-zhangjiakou-na62-a01", "maxcompute.aliyuncs.com"},
                {"cn-zhengzhou-nebula-1", "maxcompute.aliyuncs.com"},
                {"eu-central-1", "maxcompute.aliyuncs.com"},
                {"eu-west-1", "maxcompute.aliyuncs.com"},
                {"eu-west-1-oxs", "maxcompute.aliyuncs.com"},
                {"me-east-1", "maxcompute.aliyuncs.com"},
                {"rus-west-1-pop", "maxcompute.aliyuncs.com"},
                {"us-east-1", "maxcompute.aliyuncs.com"},
                {"us-west-1", "maxcompute.aliyuncs.com"},
            };
            CheckConfig(config);
            this._endpoint = GetEndpoint("maxcompute", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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
        /// <para>Activate a Quota Plan Immediately.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Please ensure that before using this interface, you have fully understood the &lt;props=&quot;china&quot;&gt;<a href="https://help.aliyun.com/zh/maxcompute/product-overview/computing-pricing-1">Pricing and Charges</a>
        /// &lt;props=&quot;intl&quot;&gt;<a href="https://www.alibabacloud.com/help/maxcompute/product-overview/computing-pricing-1">Pricing and Charges</a> of MaxCompute Elastic Reserved CU.</para>
        /// </description>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ApplyComputeQuotaPlanResponse
        /// </returns>
        public ApplyComputeQuotaPlanResponse ApplyComputeQuotaPlanWithOptions(string nickname, string planName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ApplyComputeQuotaPlan",
                Version = "2022-01-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/quotas/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(nickname) + "/computeQuotaPlan/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(planName) + "/apply",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ApplyComputeQuotaPlanResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Activate a Quota Plan Immediately.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Please ensure that before using this interface, you have fully understood the &lt;props=&quot;china&quot;&gt;<a href="https://help.aliyun.com/zh/maxcompute/product-overview/computing-pricing-1">Pricing and Charges</a>
        /// &lt;props=&quot;intl&quot;&gt;<a href="https://www.alibabacloud.com/help/maxcompute/product-overview/computing-pricing-1">Pricing and Charges</a> of MaxCompute Elastic Reserved CU.</para>
        /// </description>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ApplyComputeQuotaPlanResponse
        /// </returns>
        public async Task<ApplyComputeQuotaPlanResponse> ApplyComputeQuotaPlanWithOptionsAsync(string nickname, string planName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ApplyComputeQuotaPlan",
                Version = "2022-01-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/quotas/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(nickname) + "/computeQuotaPlan/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(planName) + "/apply",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ApplyComputeQuotaPlanResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Activate a Quota Plan Immediately.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Please ensure that before using this interface, you have fully understood the &lt;props=&quot;china&quot;&gt;<a href="https://help.aliyun.com/zh/maxcompute/product-overview/computing-pricing-1">Pricing and Charges</a>
        /// &lt;props=&quot;intl&quot;&gt;<a href="https://www.alibabacloud.com/help/maxcompute/product-overview/computing-pricing-1">Pricing and Charges</a> of MaxCompute Elastic Reserved CU.</para>
        /// </description>
        /// 
        /// <returns>
        /// ApplyComputeQuotaPlanResponse
        /// </returns>
        public ApplyComputeQuotaPlanResponse ApplyComputeQuotaPlan(string nickname, string planName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ApplyComputeQuotaPlanWithOptions(nickname, planName, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Activate a Quota Plan Immediately.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Please ensure that before using this interface, you have fully understood the &lt;props=&quot;china&quot;&gt;<a href="https://help.aliyun.com/zh/maxcompute/product-overview/computing-pricing-1">Pricing and Charges</a>
        /// &lt;props=&quot;intl&quot;&gt;<a href="https://www.alibabacloud.com/help/maxcompute/product-overview/computing-pricing-1">Pricing and Charges</a> of MaxCompute Elastic Reserved CU.</para>
        /// </description>
        /// 
        /// <returns>
        /// ApplyComputeQuotaPlanResponse
        /// </returns>
        public async Task<ApplyComputeQuotaPlanResponse> ApplyComputeQuotaPlanAsync(string nickname, string planName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ApplyComputeQuotaPlanWithOptionsAsync(nickname, planName, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Create MaxCompute ComputeQuotaPlan.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Please ensure that before using this interface, you have fully understood the &lt;props=&quot;china&quot;&gt;<a href="https://help.aliyun.com/zh/maxcompute/product-overview/computing-pricing-1">Pricing and Charges</a>
        /// &lt;props=&quot;intl&quot;&gt;<a href="https://www.alibabacloud.com/help/maxcompute/product-overview/computing-pricing-1">Pricing and Charges</a> of MaxCompute Elastic Reserved CU.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateComputeQuotaPlanRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateComputeQuotaPlanResponse
        /// </returns>
        public CreateComputeQuotaPlanResponse CreateComputeQuotaPlanWithOptions(string nickname, CreateComputeQuotaPlanRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Quota))
            {
                body["quota"] = request.Quota;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateComputeQuotaPlan",
                Version = "2022-01-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/quotas/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(nickname) + "/computeQuotaPlan",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateComputeQuotaPlanResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Create MaxCompute ComputeQuotaPlan.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Please ensure that before using this interface, you have fully understood the &lt;props=&quot;china&quot;&gt;<a href="https://help.aliyun.com/zh/maxcompute/product-overview/computing-pricing-1">Pricing and Charges</a>
        /// &lt;props=&quot;intl&quot;&gt;<a href="https://www.alibabacloud.com/help/maxcompute/product-overview/computing-pricing-1">Pricing and Charges</a> of MaxCompute Elastic Reserved CU.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateComputeQuotaPlanRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateComputeQuotaPlanResponse
        /// </returns>
        public async Task<CreateComputeQuotaPlanResponse> CreateComputeQuotaPlanWithOptionsAsync(string nickname, CreateComputeQuotaPlanRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Quota))
            {
                body["quota"] = request.Quota;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateComputeQuotaPlan",
                Version = "2022-01-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/quotas/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(nickname) + "/computeQuotaPlan",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateComputeQuotaPlanResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Create MaxCompute ComputeQuotaPlan.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Please ensure that before using this interface, you have fully understood the &lt;props=&quot;china&quot;&gt;<a href="https://help.aliyun.com/zh/maxcompute/product-overview/computing-pricing-1">Pricing and Charges</a>
        /// &lt;props=&quot;intl&quot;&gt;<a href="https://www.alibabacloud.com/help/maxcompute/product-overview/computing-pricing-1">Pricing and Charges</a> of MaxCompute Elastic Reserved CU.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateComputeQuotaPlanRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateComputeQuotaPlanResponse
        /// </returns>
        public CreateComputeQuotaPlanResponse CreateComputeQuotaPlan(string nickname, CreateComputeQuotaPlanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateComputeQuotaPlanWithOptions(nickname, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Create MaxCompute ComputeQuotaPlan.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Please ensure that before using this interface, you have fully understood the &lt;props=&quot;china&quot;&gt;<a href="https://help.aliyun.com/zh/maxcompute/product-overview/computing-pricing-1">Pricing and Charges</a>
        /// &lt;props=&quot;intl&quot;&gt;<a href="https://www.alibabacloud.com/help/maxcompute/product-overview/computing-pricing-1">Pricing and Charges</a> of MaxCompute Elastic Reserved CU.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateComputeQuotaPlanRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateComputeQuotaPlanResponse
        /// </returns>
        public async Task<CreateComputeQuotaPlanResponse> CreateComputeQuotaPlanAsync(string nickname, CreateComputeQuotaPlanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateComputeQuotaPlanWithOptionsAsync(nickname, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>CreateMmsDataSource</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateMmsDataSourceRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateMmsDataSourceResponse
        /// </returns>
        public CreateMmsDataSourceResponse CreateMmsDataSourceWithOptions(CreateMmsDataSourceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Config))
            {
                body["config"] = request.Config;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Networklink))
            {
                body["networklink"] = request.Networklink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                body["type"] = request.Type;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateMmsDataSource",
                Version = "2022-01-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/mms/datasources",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateMmsDataSourceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>CreateMmsDataSource</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateMmsDataSourceRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateMmsDataSourceResponse
        /// </returns>
        public async Task<CreateMmsDataSourceResponse> CreateMmsDataSourceWithOptionsAsync(CreateMmsDataSourceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Config))
            {
                body["config"] = request.Config;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Networklink))
            {
                body["networklink"] = request.Networklink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                body["type"] = request.Type;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateMmsDataSource",
                Version = "2022-01-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/mms/datasources",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateMmsDataSourceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>CreateMmsDataSource</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateMmsDataSourceRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateMmsDataSourceResponse
        /// </returns>
        public CreateMmsDataSourceResponse CreateMmsDataSource(CreateMmsDataSourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateMmsDataSourceWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>CreateMmsDataSource</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateMmsDataSourceRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateMmsDataSourceResponse
        /// </returns>
        public async Task<CreateMmsDataSourceResponse> CreateMmsDataSourceAsync(CreateMmsDataSourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateMmsDataSourceWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建数据源的更新元数据操作</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateMmsFetchMetadataJobResponse
        /// </returns>
        public CreateMmsFetchMetadataJobResponse CreateMmsFetchMetadataJobWithOptions(string sourceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateMmsFetchMetadataJob",
                Version = "2022-01-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/mms/datasources/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(sourceId) + "/scans",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateMmsFetchMetadataJobResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建数据源的更新元数据操作</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateMmsFetchMetadataJobResponse
        /// </returns>
        public async Task<CreateMmsFetchMetadataJobResponse> CreateMmsFetchMetadataJobWithOptionsAsync(string sourceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateMmsFetchMetadataJob",
                Version = "2022-01-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/mms/datasources/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(sourceId) + "/scans",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateMmsFetchMetadataJobResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建数据源的更新元数据操作</para>
        /// </summary>
        /// 
        /// <returns>
        /// CreateMmsFetchMetadataJobResponse
        /// </returns>
        public CreateMmsFetchMetadataJobResponse CreateMmsFetchMetadataJob(string sourceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateMmsFetchMetadataJobWithOptions(sourceId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建数据源的更新元数据操作</para>
        /// </summary>
        /// 
        /// <returns>
        /// CreateMmsFetchMetadataJobResponse
        /// </returns>
        public async Task<CreateMmsFetchMetadataJobResponse> CreateMmsFetchMetadataJobAsync(string sourceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateMmsFetchMetadataJobWithOptionsAsync(sourceId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建迁移任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateMmsJobRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateMmsJobResponse
        /// </returns>
        public CreateMmsJobResponse CreateMmsJobWithOptions(string sourceId, CreateMmsJobRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ColumnMapping))
            {
                body["columnMapping"] = request.ColumnMapping;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DstDbName))
            {
                body["dstDbName"] = request.DstDbName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DstSchemaName))
            {
                body["dstSchemaName"] = request.DstSchemaName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableVerification))
            {
                body["enableVerification"] = request.EnableVerification;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Eta))
            {
                body["eta"] = request.Eta;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Increment))
            {
                body["increment"] = request.Increment;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Others))
            {
                body["others"] = request.Others;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PartitionFilters))
            {
                body["partitionFilters"] = request.PartitionFilters;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Partitions))
            {
                body["partitions"] = request.Partitions;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SchemaOnly))
            {
                body["schemaOnly"] = request.SchemaOnly;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceId))
            {
                body["sourceId"] = request.SourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceName))
            {
                body["sourceName"] = request.SourceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SrcDbName))
            {
                body["srcDbName"] = request.SrcDbName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SrcSchemaName))
            {
                body["srcSchemaName"] = request.SrcSchemaName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TableBlackList))
            {
                body["tableBlackList"] = request.TableBlackList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TableMapping))
            {
                body["tableMapping"] = request.TableMapping;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TableWhiteList))
            {
                body["tableWhiteList"] = request.TableWhiteList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tables))
            {
                body["tables"] = request.Tables;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskType))
            {
                body["taskType"] = request.TaskType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateMmsJob",
                Version = "2022-01-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/mms/datasources/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(sourceId) + "/jobs",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateMmsJobResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建迁移任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateMmsJobRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateMmsJobResponse
        /// </returns>
        public async Task<CreateMmsJobResponse> CreateMmsJobWithOptionsAsync(string sourceId, CreateMmsJobRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ColumnMapping))
            {
                body["columnMapping"] = request.ColumnMapping;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DstDbName))
            {
                body["dstDbName"] = request.DstDbName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DstSchemaName))
            {
                body["dstSchemaName"] = request.DstSchemaName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnableVerification))
            {
                body["enableVerification"] = request.EnableVerification;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Eta))
            {
                body["eta"] = request.Eta;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Increment))
            {
                body["increment"] = request.Increment;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Others))
            {
                body["others"] = request.Others;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PartitionFilters))
            {
                body["partitionFilters"] = request.PartitionFilters;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Partitions))
            {
                body["partitions"] = request.Partitions;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SchemaOnly))
            {
                body["schemaOnly"] = request.SchemaOnly;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceId))
            {
                body["sourceId"] = request.SourceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceName))
            {
                body["sourceName"] = request.SourceName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SrcDbName))
            {
                body["srcDbName"] = request.SrcDbName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SrcSchemaName))
            {
                body["srcSchemaName"] = request.SrcSchemaName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TableBlackList))
            {
                body["tableBlackList"] = request.TableBlackList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TableMapping))
            {
                body["tableMapping"] = request.TableMapping;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TableWhiteList))
            {
                body["tableWhiteList"] = request.TableWhiteList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Tables))
            {
                body["tables"] = request.Tables;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskType))
            {
                body["taskType"] = request.TaskType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateMmsJob",
                Version = "2022-01-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/mms/datasources/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(sourceId) + "/jobs",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateMmsJobResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建迁移任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateMmsJobRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateMmsJobResponse
        /// </returns>
        public CreateMmsJobResponse CreateMmsJob(string sourceId, CreateMmsJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateMmsJobWithOptions(sourceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建迁移任务</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateMmsJobRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateMmsJobResponse
        /// </returns>
        public async Task<CreateMmsJobResponse> CreateMmsJobAsync(string sourceId, CreateMmsJobRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateMmsJobWithOptionsAsync(sourceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a package.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreatePackageRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreatePackageResponse
        /// </returns>
        public CreatePackageResponse CreatePackageWithOptions(string projectName, CreatePackageRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsInstall))
            {
                query["isInstall"] = request.IsInstall;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreatePackage",
                Version = "2022-01-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/projects/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(projectName) + "/packages",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreatePackageResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a package.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreatePackageRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreatePackageResponse
        /// </returns>
        public async Task<CreatePackageResponse> CreatePackageWithOptionsAsync(string projectName, CreatePackageRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.IsInstall))
            {
                query["isInstall"] = request.IsInstall;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreatePackage",
                Version = "2022-01-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/projects/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(projectName) + "/packages",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreatePackageResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a package.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreatePackageRequest
        /// </param>
        /// 
        /// <returns>
        /// CreatePackageResponse
        /// </returns>
        public CreatePackageResponse CreatePackage(string projectName, CreatePackageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreatePackageWithOptions(projectName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a package.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreatePackageRequest
        /// </param>
        /// 
        /// <returns>
        /// CreatePackageResponse
        /// </returns>
        public async Task<CreatePackageResponse> CreatePackageAsync(string projectName, CreatePackageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreatePackageWithOptionsAsync(projectName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a MaxCompute project.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateProjectRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateProjectResponse
        /// </returns>
        public CreateProjectResponse CreateProjectWithOptions(CreateProjectRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateProject",
                Version = "2022-01-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/projects",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateProjectResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a MaxCompute project.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateProjectRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateProjectResponse
        /// </returns>
        public async Task<CreateProjectResponse> CreateProjectWithOptionsAsync(CreateProjectRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateProject",
                Version = "2022-01-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/projects",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateProjectResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a MaxCompute project.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateProjectRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateProjectResponse
        /// </returns>
        public CreateProjectResponse CreateProject(CreateProjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateProjectWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a MaxCompute project.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateProjectRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateProjectResponse
        /// </returns>
        public async Task<CreateProjectResponse> CreateProjectAsync(CreateProjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateProjectWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a quota plan.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateQuotaPlanRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateQuotaPlanResponse
        /// </returns>
        public CreateQuotaPlanResponse CreateQuotaPlanWithOptions(string nickname, CreateQuotaPlanRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                query["region"] = request.Region;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["tenantId"] = request.TenantId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateQuotaPlan",
                Version = "2022-01-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/quotas/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(nickname) + "/plans",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateQuotaPlanResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a quota plan.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateQuotaPlanRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateQuotaPlanResponse
        /// </returns>
        public async Task<CreateQuotaPlanResponse> CreateQuotaPlanWithOptionsAsync(string nickname, CreateQuotaPlanRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                query["region"] = request.Region;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["tenantId"] = request.TenantId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateQuotaPlan",
                Version = "2022-01-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/quotas/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(nickname) + "/plans",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateQuotaPlanResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a quota plan.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateQuotaPlanRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateQuotaPlanResponse
        /// </returns>
        public CreateQuotaPlanResponse CreateQuotaPlan(string nickname, CreateQuotaPlanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateQuotaPlanWithOptions(nickname, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a quota plan.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateQuotaPlanRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateQuotaPlanResponse
        /// </returns>
        public async Task<CreateQuotaPlanResponse> CreateQuotaPlanAsync(string nickname, CreateQuotaPlanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateQuotaPlanWithOptionsAsync(nickname, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a role at the MaxCompute project level.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateRoleRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateRoleResponse
        /// </returns>
        public CreateRoleResponse CreateRoleWithOptions(string projectName, CreateRoleRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateRole",
                Version = "2022-01-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/projects/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(projectName) + "/roles",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateRoleResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a role at the MaxCompute project level.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateRoleRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateRoleResponse
        /// </returns>
        public async Task<CreateRoleResponse> CreateRoleWithOptionsAsync(string projectName, CreateRoleRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateRole",
                Version = "2022-01-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/projects/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(projectName) + "/roles",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateRoleResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a role at the MaxCompute project level.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateRoleRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateRoleResponse
        /// </returns>
        public CreateRoleResponse CreateRole(string projectName, CreateRoleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateRoleWithOptions(projectName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a role at the MaxCompute project level.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateRoleRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateRoleResponse
        /// </returns>
        public async Task<CreateRoleResponse> CreateRoleAsync(string projectName, CreateRoleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateRoleWithOptionsAsync(projectName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Delete MaxCompute compute quota plan.</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteComputeQuotaPlanResponse
        /// </returns>
        public DeleteComputeQuotaPlanResponse DeleteComputeQuotaPlanWithOptions(string nickname, string planName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteComputeQuotaPlan",
                Version = "2022-01-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/quotas/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(nickname) + "/computeQuotaPlan/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(planName),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteComputeQuotaPlanResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Delete MaxCompute compute quota plan.</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteComputeQuotaPlanResponse
        /// </returns>
        public async Task<DeleteComputeQuotaPlanResponse> DeleteComputeQuotaPlanWithOptionsAsync(string nickname, string planName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteComputeQuotaPlan",
                Version = "2022-01-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/quotas/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(nickname) + "/computeQuotaPlan/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(planName),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteComputeQuotaPlanResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Delete MaxCompute compute quota plan.</para>
        /// </summary>
        /// 
        /// <returns>
        /// DeleteComputeQuotaPlanResponse
        /// </returns>
        public DeleteComputeQuotaPlanResponse DeleteComputeQuotaPlan(string nickname, string planName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteComputeQuotaPlanWithOptions(nickname, planName, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Delete MaxCompute compute quota plan.</para>
        /// </summary>
        /// 
        /// <returns>
        /// DeleteComputeQuotaPlanResponse
        /// </returns>
        public async Task<DeleteComputeQuotaPlanResponse> DeleteComputeQuotaPlanAsync(string nickname, string planName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteComputeQuotaPlanWithOptionsAsync(nickname, planName, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除数据源</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteMmsDataSourceResponse
        /// </returns>
        public DeleteMmsDataSourceResponse DeleteMmsDataSourceWithOptions(string sourceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteMmsDataSource",
                Version = "2022-01-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/mms/datasources/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(sourceId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteMmsDataSourceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除数据源</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteMmsDataSourceResponse
        /// </returns>
        public async Task<DeleteMmsDataSourceResponse> DeleteMmsDataSourceWithOptionsAsync(string sourceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteMmsDataSource",
                Version = "2022-01-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/mms/datasources/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(sourceId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteMmsDataSourceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除数据源</para>
        /// </summary>
        /// 
        /// <returns>
        /// DeleteMmsDataSourceResponse
        /// </returns>
        public DeleteMmsDataSourceResponse DeleteMmsDataSource(string sourceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteMmsDataSourceWithOptions(sourceId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除数据源</para>
        /// </summary>
        /// 
        /// <returns>
        /// DeleteMmsDataSourceResponse
        /// </returns>
        public async Task<DeleteMmsDataSourceResponse> DeleteMmsDataSourceAsync(string sourceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteMmsDataSourceWithOptionsAsync(sourceId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除迁移计划</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteMmsJobResponse
        /// </returns>
        public DeleteMmsJobResponse DeleteMmsJobWithOptions(string sourceId, string jobId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteMmsJob",
                Version = "2022-01-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/mms/datasources/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(sourceId) + "/jobs/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(jobId),
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteMmsJobResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除迁移计划</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteMmsJobResponse
        /// </returns>
        public async Task<DeleteMmsJobResponse> DeleteMmsJobWithOptionsAsync(string sourceId, string jobId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteMmsJob",
                Version = "2022-01-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/mms/datasources/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(sourceId) + "/jobs/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(jobId),
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteMmsJobResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除迁移计划</para>
        /// </summary>
        /// 
        /// <returns>
        /// DeleteMmsJobResponse
        /// </returns>
        public DeleteMmsJobResponse DeleteMmsJob(string sourceId, string jobId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteMmsJobWithOptions(sourceId, jobId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除迁移计划</para>
        /// </summary>
        /// 
        /// <returns>
        /// DeleteMmsJobResponse
        /// </returns>
        public async Task<DeleteMmsJobResponse> DeleteMmsJobAsync(string sourceId, string jobId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteMmsJobWithOptionsAsync(sourceId, jobId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a quota plan.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteQuotaPlanRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteQuotaPlanResponse
        /// </returns>
        public DeleteQuotaPlanResponse DeleteQuotaPlanWithOptions(string nickname, string planName, DeleteQuotaPlanRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                query["region"] = request.Region;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["tenantId"] = request.TenantId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteQuotaPlan",
                Version = "2022-01-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/quotas/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(nickname) + "/plans/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(planName),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteQuotaPlanResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a quota plan.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteQuotaPlanRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteQuotaPlanResponse
        /// </returns>
        public async Task<DeleteQuotaPlanResponse> DeleteQuotaPlanWithOptionsAsync(string nickname, string planName, DeleteQuotaPlanRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                query["region"] = request.Region;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["tenantId"] = request.TenantId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteQuotaPlan",
                Version = "2022-01-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/quotas/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(nickname) + "/plans/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(planName),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteQuotaPlanResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a quota plan.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteQuotaPlanRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteQuotaPlanResponse
        /// </returns>
        public DeleteQuotaPlanResponse DeleteQuotaPlan(string nickname, string planName, DeleteQuotaPlanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteQuotaPlanWithOptions(nickname, planName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a quota plan.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteQuotaPlanRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteQuotaPlanResponse
        /// </returns>
        public async Task<DeleteQuotaPlanResponse> DeleteQuotaPlanAsync(string nickname, string planName, DeleteQuotaPlanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteQuotaPlanWithOptionsAsync(nickname, planName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>GetComputeEffectivePlan.</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetComputeEffectivePlanResponse
        /// </returns>
        public GetComputeEffectivePlanResponse GetComputeEffectivePlanWithOptions(string nickname, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetComputeEffectivePlan",
                Version = "2022-01-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/quotas/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(nickname) + "/computeEffectivePlan/",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetComputeEffectivePlanResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>GetComputeEffectivePlan.</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetComputeEffectivePlanResponse
        /// </returns>
        public async Task<GetComputeEffectivePlanResponse> GetComputeEffectivePlanWithOptionsAsync(string nickname, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetComputeEffectivePlan",
                Version = "2022-01-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/quotas/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(nickname) + "/computeEffectivePlan/",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetComputeEffectivePlanResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>GetComputeEffectivePlan.</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetComputeEffectivePlanResponse
        /// </returns>
        public GetComputeEffectivePlanResponse GetComputeEffectivePlan(string nickname)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetComputeEffectivePlanWithOptions(nickname, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>GetComputeEffectivePlan.</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetComputeEffectivePlanResponse
        /// </returns>
        public async Task<GetComputeEffectivePlanResponse> GetComputeEffectivePlanAsync(string nickname)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetComputeEffectivePlanWithOptionsAsync(nickname, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Get detailed information of a single compute quota plan.</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetComputeQuotaPlanResponse
        /// </returns>
        public GetComputeQuotaPlanResponse GetComputeQuotaPlanWithOptions(string nickname, string planName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetComputeQuotaPlan",
                Version = "2022-01-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/quotas/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(nickname) + "/computeQuotaPlan/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(planName),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetComputeQuotaPlanResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Get detailed information of a single compute quota plan.</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetComputeQuotaPlanResponse
        /// </returns>
        public async Task<GetComputeQuotaPlanResponse> GetComputeQuotaPlanWithOptionsAsync(string nickname, string planName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetComputeQuotaPlan",
                Version = "2022-01-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/quotas/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(nickname) + "/computeQuotaPlan/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(planName),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetComputeQuotaPlanResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Get detailed information of a single compute quota plan.</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetComputeQuotaPlanResponse
        /// </returns>
        public GetComputeQuotaPlanResponse GetComputeQuotaPlan(string nickname, string planName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetComputeQuotaPlanWithOptions(nickname, planName, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Get detailed information of a single compute quota plan.</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetComputeQuotaPlanResponse
        /// </returns>
        public async Task<GetComputeQuotaPlanResponse> GetComputeQuotaPlanAsync(string nickname, string planName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetComputeQuotaPlanWithOptionsAsync(nickname, planName, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Displays the time-specific configuration of compute quota.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetComputeQuotaScheduleRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetComputeQuotaScheduleResponse
        /// </returns>
        public GetComputeQuotaScheduleResponse GetComputeQuotaScheduleWithOptions(string nickname, GetComputeQuotaScheduleRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisplayTimezone))
            {
                query["displayTimezone"] = request.DisplayTimezone;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetComputeQuotaSchedule",
                Version = "2022-01-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/quotas/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(nickname) + "/computeQuotaSchedule",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetComputeQuotaScheduleResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Displays the time-specific configuration of compute quota.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetComputeQuotaScheduleRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetComputeQuotaScheduleResponse
        /// </returns>
        public async Task<GetComputeQuotaScheduleResponse> GetComputeQuotaScheduleWithOptionsAsync(string nickname, GetComputeQuotaScheduleRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisplayTimezone))
            {
                query["displayTimezone"] = request.DisplayTimezone;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetComputeQuotaSchedule",
                Version = "2022-01-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/quotas/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(nickname) + "/computeQuotaSchedule",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetComputeQuotaScheduleResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Displays the time-specific configuration of compute quota.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetComputeQuotaScheduleRequest
        /// </param>
        /// 
        /// <returns>
        /// GetComputeQuotaScheduleResponse
        /// </returns>
        public GetComputeQuotaScheduleResponse GetComputeQuotaSchedule(string nickname, GetComputeQuotaScheduleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetComputeQuotaScheduleWithOptions(nickname, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Displays the time-specific configuration of compute quota.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetComputeQuotaScheduleRequest
        /// </param>
        /// 
        /// <returns>
        /// GetComputeQuotaScheduleResponse
        /// </returns>
        public async Task<GetComputeQuotaScheduleResponse> GetComputeQuotaScheduleAsync(string nickname, GetComputeQuotaScheduleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetComputeQuotaScheduleWithOptionsAsync(nickname, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the basic information about a job.</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetJobInfoResponse
        /// </returns>
        public GetJobInfoResponse GetJobInfoWithOptions(string instanceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetJobInfo",
                Version = "2022-01-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/jobs/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/info",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetJobInfoResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the basic information about a job.</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetJobInfoResponse
        /// </returns>
        public async Task<GetJobInfoResponse> GetJobInfoWithOptionsAsync(string instanceId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetJobInfo",
                Version = "2022-01-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/jobs/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(instanceId) + "/info",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetJobInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the basic information about a job.</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetJobInfoResponse
        /// </returns>
        public GetJobInfoResponse GetJobInfo(string instanceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetJobInfoWithOptions(instanceId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the basic information about a job.</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetJobInfoResponse
        /// </returns>
        public async Task<GetJobInfoResponse> GetJobInfoAsync(string instanceId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetJobInfoWithOptionsAsync(instanceId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Performs statistics on all jobs that are complete on a specified day and obtains the total resource usage of each job executor on a daily basis.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// GetJobResourceUsageRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetJobResourceUsageResponse
        /// </returns>
        public GetJobResourceUsageResponse GetJobResourceUsageWithOptions(GetJobResourceUsageRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GetJobResourceUsageShrinkRequest request = new GetJobResourceUsageShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.JobOwnerList))
            {
                request.JobOwnerListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.JobOwnerList, "jobOwnerList", "simple");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.QuotaNicknameList))
            {
                request.QuotaNicknameListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.QuotaNicknameList, "quotaNicknameList", "simple");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Date))
            {
                query["date"] = request.Date;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobOwnerListShrink))
            {
                query["jobOwnerList"] = request.JobOwnerListShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QuotaNicknameListShrink))
            {
                query["quotaNicknameList"] = request.QuotaNicknameListShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetJobResourceUsage",
                Version = "2022-01-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/jobs/resourceUsage",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetJobResourceUsageResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Performs statistics on all jobs that are complete on a specified day and obtains the total resource usage of each job executor on a daily basis.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// GetJobResourceUsageRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetJobResourceUsageResponse
        /// </returns>
        public async Task<GetJobResourceUsageResponse> GetJobResourceUsageWithOptionsAsync(GetJobResourceUsageRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GetJobResourceUsageShrinkRequest request = new GetJobResourceUsageShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.JobOwnerList))
            {
                request.JobOwnerListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.JobOwnerList, "jobOwnerList", "simple");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.QuotaNicknameList))
            {
                request.QuotaNicknameListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.QuotaNicknameList, "quotaNicknameList", "simple");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Date))
            {
                query["date"] = request.Date;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobOwnerListShrink))
            {
                query["jobOwnerList"] = request.JobOwnerListShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QuotaNicknameListShrink))
            {
                query["quotaNicknameList"] = request.QuotaNicknameListShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetJobResourceUsage",
                Version = "2022-01-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/jobs/resourceUsage",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetJobResourceUsageResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Performs statistics on all jobs that are complete on a specified day and obtains the total resource usage of each job executor on a daily basis.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetJobResourceUsageRequest
        /// </param>
        /// 
        /// <returns>
        /// GetJobResourceUsageResponse
        /// </returns>
        public GetJobResourceUsageResponse GetJobResourceUsage(GetJobResourceUsageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetJobResourceUsageWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Performs statistics on all jobs that are complete on a specified day and obtains the total resource usage of each job executor on a daily basis.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetJobResourceUsageRequest
        /// </param>
        /// 
        /// <returns>
        /// GetJobResourceUsageResponse
        /// </returns>
        public async Task<GetJobResourceUsageResponse> GetJobResourceUsageAsync(GetJobResourceUsageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetJobResourceUsageWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>GetMmsAsyncTask</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetMmsAsyncTaskResponse
        /// </returns>
        public GetMmsAsyncTaskResponse GetMmsAsyncTaskWithOptions(string sourceId, string asyncTaskId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetMmsAsyncTask",
                Version = "2022-01-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/mms/datasources/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(sourceId) + "/asyncTasks/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(asyncTaskId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetMmsAsyncTaskResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>GetMmsAsyncTask</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetMmsAsyncTaskResponse
        /// </returns>
        public async Task<GetMmsAsyncTaskResponse> GetMmsAsyncTaskWithOptionsAsync(string sourceId, string asyncTaskId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetMmsAsyncTask",
                Version = "2022-01-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/mms/datasources/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(sourceId) + "/asyncTasks/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(asyncTaskId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetMmsAsyncTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>GetMmsAsyncTask</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetMmsAsyncTaskResponse
        /// </returns>
        public GetMmsAsyncTaskResponse GetMmsAsyncTask(string sourceId, string asyncTaskId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetMmsAsyncTaskWithOptions(sourceId, asyncTaskId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>GetMmsAsyncTask</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetMmsAsyncTaskResponse
        /// </returns>
        public async Task<GetMmsAsyncTaskResponse> GetMmsAsyncTaskAsync(string sourceId, string asyncTaskId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetMmsAsyncTaskWithOptionsAsync(sourceId, asyncTaskId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取数据源</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetMmsDataSourceRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetMmsDataSourceResponse
        /// </returns>
        public GetMmsDataSourceResponse GetMmsDataSourceWithOptions(string sourceId, GetMmsDataSourceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WithConfig))
            {
                query["withConfig"] = request.WithConfig;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetMmsDataSource",
                Version = "2022-01-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/mms/datasources/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(sourceId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetMmsDataSourceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取数据源</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetMmsDataSourceRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetMmsDataSourceResponse
        /// </returns>
        public async Task<GetMmsDataSourceResponse> GetMmsDataSourceWithOptionsAsync(string sourceId, GetMmsDataSourceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Lang))
            {
                query["lang"] = request.Lang;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WithConfig))
            {
                query["withConfig"] = request.WithConfig;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetMmsDataSource",
                Version = "2022-01-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/mms/datasources/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(sourceId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetMmsDataSourceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取数据源</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetMmsDataSourceRequest
        /// </param>
        /// 
        /// <returns>
        /// GetMmsDataSourceResponse
        /// </returns>
        public GetMmsDataSourceResponse GetMmsDataSource(string sourceId, GetMmsDataSourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetMmsDataSourceWithOptions(sourceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取数据源</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetMmsDataSourceRequest
        /// </param>
        /// 
        /// <returns>
        /// GetMmsDataSourceResponse
        /// </returns>
        public async Task<GetMmsDataSourceResponse> GetMmsDataSourceAsync(string sourceId, GetMmsDataSourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetMmsDataSourceWithOptionsAsync(sourceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>GetMmsDb</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetMmsDbResponse
        /// </returns>
        public GetMmsDbResponse GetMmsDbWithOptions(string sourceId, string dbId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetMmsDb",
                Version = "2022-01-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/mms/datasources/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(sourceId) + "/dbs/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(dbId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetMmsDbResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>GetMmsDb</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetMmsDbResponse
        /// </returns>
        public async Task<GetMmsDbResponse> GetMmsDbWithOptionsAsync(string sourceId, string dbId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetMmsDb",
                Version = "2022-01-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/mms/datasources/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(sourceId) + "/dbs/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(dbId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetMmsDbResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>GetMmsDb</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetMmsDbResponse
        /// </returns>
        public GetMmsDbResponse GetMmsDb(string sourceId, string dbId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetMmsDbWithOptions(sourceId, dbId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>GetMmsDb</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetMmsDbResponse
        /// </returns>
        public async Task<GetMmsDbResponse> GetMmsDbAsync(string sourceId, string dbId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetMmsDbWithOptionsAsync(sourceId, dbId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>GetMmsFetchMetadataJob</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetMmsFetchMetadataJobResponse
        /// </returns>
        public GetMmsFetchMetadataJobResponse GetMmsFetchMetadataJobWithOptions(string sourceId, string scanId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetMmsFetchMetadataJob",
                Version = "2022-01-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/mms/datasources/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(sourceId) + "/scans/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(scanId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetMmsFetchMetadataJobResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>GetMmsFetchMetadataJob</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetMmsFetchMetadataJobResponse
        /// </returns>
        public async Task<GetMmsFetchMetadataJobResponse> GetMmsFetchMetadataJobWithOptionsAsync(string sourceId, string scanId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetMmsFetchMetadataJob",
                Version = "2022-01-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/mms/datasources/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(sourceId) + "/scans/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(scanId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetMmsFetchMetadataJobResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>GetMmsFetchMetadataJob</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetMmsFetchMetadataJobResponse
        /// </returns>
        public GetMmsFetchMetadataJobResponse GetMmsFetchMetadataJob(string sourceId, string scanId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetMmsFetchMetadataJobWithOptions(sourceId, scanId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>GetMmsFetchMetadataJob</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetMmsFetchMetadataJobResponse
        /// </returns>
        public async Task<GetMmsFetchMetadataJobResponse> GetMmsFetchMetadataJobAsync(string sourceId, string scanId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetMmsFetchMetadataJobWithOptionsAsync(sourceId, scanId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取迁移计划</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetMmsJobResponse
        /// </returns>
        public GetMmsJobResponse GetMmsJobWithOptions(string sourceId, string jobId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetMmsJob",
                Version = "2022-01-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/mms/datasources/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(sourceId) + "/jobs/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(jobId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetMmsJobResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取迁移计划</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetMmsJobResponse
        /// </returns>
        public async Task<GetMmsJobResponse> GetMmsJobWithOptionsAsync(string sourceId, string jobId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetMmsJob",
                Version = "2022-01-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/mms/datasources/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(sourceId) + "/jobs/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(jobId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetMmsJobResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取迁移计划</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetMmsJobResponse
        /// </returns>
        public GetMmsJobResponse GetMmsJob(string sourceId, string jobId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetMmsJobWithOptions(sourceId, jobId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取迁移计划</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetMmsJobResponse
        /// </returns>
        public async Task<GetMmsJobResponse> GetMmsJobAsync(string sourceId, string jobId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetMmsJobWithOptionsAsync(sourceId, jobId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>GetMmsPartition</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetMmsPartitionResponse
        /// </returns>
        public GetMmsPartitionResponse GetMmsPartitionWithOptions(string sourceId, string partitionId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetMmsPartition",
                Version = "2022-01-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/mms/datasources/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(sourceId) + "/partitions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(partitionId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetMmsPartitionResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>GetMmsPartition</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetMmsPartitionResponse
        /// </returns>
        public async Task<GetMmsPartitionResponse> GetMmsPartitionWithOptionsAsync(string sourceId, string partitionId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetMmsPartition",
                Version = "2022-01-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/mms/datasources/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(sourceId) + "/partitions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(partitionId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetMmsPartitionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>GetMmsPartition</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetMmsPartitionResponse
        /// </returns>
        public GetMmsPartitionResponse GetMmsPartition(string sourceId, string partitionId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetMmsPartitionWithOptions(sourceId, partitionId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>GetMmsPartition</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetMmsPartitionResponse
        /// </returns>
        public async Task<GetMmsPartitionResponse> GetMmsPartitionAsync(string sourceId, string partitionId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetMmsPartitionWithOptionsAsync(sourceId, partitionId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>GetMmsTable</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetMmsTableResponse
        /// </returns>
        public GetMmsTableResponse GetMmsTableWithOptions(string sourceId, string tableId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetMmsTable",
                Version = "2022-01-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/mms/datasources/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(sourceId) + "/tables/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(tableId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetMmsTableResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>GetMmsTable</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetMmsTableResponse
        /// </returns>
        public async Task<GetMmsTableResponse> GetMmsTableWithOptionsAsync(string sourceId, string tableId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetMmsTable",
                Version = "2022-01-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/mms/datasources/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(sourceId) + "/tables/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(tableId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetMmsTableResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>GetMmsTable</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetMmsTableResponse
        /// </returns>
        public GetMmsTableResponse GetMmsTable(string sourceId, string tableId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetMmsTableWithOptions(sourceId, tableId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>GetMmsTable</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetMmsTableResponse
        /// </returns>
        public async Task<GetMmsTableResponse> GetMmsTableAsync(string sourceId, string tableId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetMmsTableWithOptionsAsync(sourceId, tableId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>GetMmsTask</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetMmsTaskResponse
        /// </returns>
        public GetMmsTaskResponse GetMmsTaskWithOptions(string sourceId, string taskId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetMmsTask",
                Version = "2022-01-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/mms/datasources/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(sourceId) + "/tasks/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(taskId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetMmsTaskResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>GetMmsTask</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetMmsTaskResponse
        /// </returns>
        public async Task<GetMmsTaskResponse> GetMmsTaskWithOptionsAsync(string sourceId, string taskId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetMmsTask",
                Version = "2022-01-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/mms/datasources/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(sourceId) + "/tasks/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(taskId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetMmsTaskResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>GetMmsTask</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetMmsTaskResponse
        /// </returns>
        public GetMmsTaskResponse GetMmsTask(string sourceId, string taskId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetMmsTaskWithOptions(sourceId, taskId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>GetMmsTask</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetMmsTaskResponse
        /// </returns>
        public async Task<GetMmsTaskResponse> GetMmsTaskAsync(string sourceId, string taskId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetMmsTaskWithOptionsAsync(sourceId, taskId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains the information about a package.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetPackageRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetPackageResponse
        /// </returns>
        public GetPackageResponse GetPackageWithOptions(string projectName, string packageName, GetPackageRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceProject))
            {
                query["sourceProject"] = request.SourceProject;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetPackage",
                Version = "2022-01-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/projects/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(projectName) + "/packages/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(packageName),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetPackageResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains the information about a package.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetPackageRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetPackageResponse
        /// </returns>
        public async Task<GetPackageResponse> GetPackageWithOptionsAsync(string projectName, string packageName, GetPackageRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SourceProject))
            {
                query["sourceProject"] = request.SourceProject;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetPackage",
                Version = "2022-01-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/projects/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(projectName) + "/packages/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(packageName),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetPackageResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains the information about a package.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetPackageRequest
        /// </param>
        /// 
        /// <returns>
        /// GetPackageResponse
        /// </returns>
        public GetPackageResponse GetPackage(string projectName, string packageName, GetPackageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetPackageWithOptions(projectName, packageName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains the information about a package.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetPackageRequest
        /// </param>
        /// 
        /// <returns>
        /// GetPackageResponse
        /// </returns>
        public async Task<GetPackageResponse> GetPackageAsync(string projectName, string packageName, GetPackageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetPackageWithOptionsAsync(projectName, packageName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about a MaxCompute project.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetProjectRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetProjectResponse
        /// </returns>
        public GetProjectResponse GetProjectWithOptions(string projectName, GetProjectRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Verbose))
            {
                query["verbose"] = request.Verbose;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetProject",
                Version = "2022-01-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/projects/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(projectName),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetProjectResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about a MaxCompute project.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetProjectRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetProjectResponse
        /// </returns>
        public async Task<GetProjectResponse> GetProjectWithOptionsAsync(string projectName, GetProjectRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Verbose))
            {
                query["verbose"] = request.Verbose;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetProject",
                Version = "2022-01-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/projects/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(projectName),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetProjectResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about a MaxCompute project.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetProjectRequest
        /// </param>
        /// 
        /// <returns>
        /// GetProjectResponse
        /// </returns>
        public GetProjectResponse GetProject(string projectName, GetProjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetProjectWithOptions(projectName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about a MaxCompute project.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetProjectRequest
        /// </param>
        /// 
        /// <returns>
        /// GetProjectResponse
        /// </returns>
        public async Task<GetProjectResponse> GetProjectAsync(string projectName, GetProjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetProjectWithOptionsAsync(projectName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains the information about a specified level-1 quota.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetQuotaRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetQuotaResponse
        /// </returns>
        public GetQuotaResponse GetQuotaWithOptions(string nickname, GetQuotaRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AkProven))
            {
                query["AkProven"] = request.AkProven;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mock))
            {
                query["mock"] = request.Mock;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                query["region"] = request.Region;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["tenantId"] = request.TenantId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetQuota",
                Version = "2022-01-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/quotas/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(nickname),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetQuotaResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains the information about a specified level-1 quota.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetQuotaRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetQuotaResponse
        /// </returns>
        public async Task<GetQuotaResponse> GetQuotaWithOptionsAsync(string nickname, GetQuotaRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AkProven))
            {
                query["AkProven"] = request.AkProven;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mock))
            {
                query["mock"] = request.Mock;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                query["region"] = request.Region;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["tenantId"] = request.TenantId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetQuota",
                Version = "2022-01-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/quotas/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(nickname),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetQuotaResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains the information about a specified level-1 quota.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetQuotaRequest
        /// </param>
        /// 
        /// <returns>
        /// GetQuotaResponse
        /// </returns>
        public GetQuotaResponse GetQuota(string nickname, GetQuotaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetQuotaWithOptions(nickname, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains the information about a specified level-1 quota.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetQuotaRequest
        /// </param>
        /// 
        /// <returns>
        /// GetQuotaResponse
        /// </returns>
        public async Task<GetQuotaResponse> GetQuotaAsync(string nickname, GetQuotaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetQuotaWithOptionsAsync(nickname, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains the information of a quota plan.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetQuotaPlanRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetQuotaPlanResponse
        /// </returns>
        public GetQuotaPlanResponse GetQuotaPlanWithOptions(string nickname, string planName, GetQuotaPlanRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                query["region"] = request.Region;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["tenantId"] = request.TenantId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetQuotaPlan",
                Version = "2022-01-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/quotas/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(nickname) + "/plans/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(planName),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetQuotaPlanResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains the information of a quota plan.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetQuotaPlanRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetQuotaPlanResponse
        /// </returns>
        public async Task<GetQuotaPlanResponse> GetQuotaPlanWithOptionsAsync(string nickname, string planName, GetQuotaPlanRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                query["region"] = request.Region;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["tenantId"] = request.TenantId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetQuotaPlan",
                Version = "2022-01-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/quotas/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(nickname) + "/plans/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(planName),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetQuotaPlanResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains the information of a quota plan.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetQuotaPlanRequest
        /// </param>
        /// 
        /// <returns>
        /// GetQuotaPlanResponse
        /// </returns>
        public GetQuotaPlanResponse GetQuotaPlan(string nickname, string planName, GetQuotaPlanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetQuotaPlanWithOptions(nickname, planName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains the information of a quota plan.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetQuotaPlanRequest
        /// </param>
        /// 
        /// <returns>
        /// GetQuotaPlanResponse
        /// </returns>
        public async Task<GetQuotaPlanResponse> GetQuotaPlanAsync(string nickname, string planName, GetQuotaPlanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetQuotaPlanWithOptionsAsync(nickname, planName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains the scheduling plan for a quota plan.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetQuotaScheduleRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetQuotaScheduleResponse
        /// </returns>
        public GetQuotaScheduleResponse GetQuotaScheduleWithOptions(string nickname, GetQuotaScheduleRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisplayTimezone))
            {
                query["displayTimezone"] = request.DisplayTimezone;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                query["region"] = request.Region;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["tenantId"] = request.TenantId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetQuotaSchedule",
                Version = "2022-01-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/quotas/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(nickname) + "/schedule",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetQuotaScheduleResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains the scheduling plan for a quota plan.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetQuotaScheduleRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetQuotaScheduleResponse
        /// </returns>
        public async Task<GetQuotaScheduleResponse> GetQuotaScheduleWithOptionsAsync(string nickname, GetQuotaScheduleRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DisplayTimezone))
            {
                query["displayTimezone"] = request.DisplayTimezone;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                query["region"] = request.Region;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["tenantId"] = request.TenantId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetQuotaSchedule",
                Version = "2022-01-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/quotas/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(nickname) + "/schedule",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetQuotaScheduleResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains the scheduling plan for a quota plan.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetQuotaScheduleRequest
        /// </param>
        /// 
        /// <returns>
        /// GetQuotaScheduleResponse
        /// </returns>
        public GetQuotaScheduleResponse GetQuotaSchedule(string nickname, GetQuotaScheduleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetQuotaScheduleWithOptions(nickname, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains the scheduling plan for a quota plan.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetQuotaScheduleRequest
        /// </param>
        /// 
        /// <returns>
        /// GetQuotaScheduleResponse
        /// </returns>
        public async Task<GetQuotaScheduleResponse> GetQuotaScheduleAsync(string nickname, GetQuotaScheduleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetQuotaScheduleWithOptionsAsync(nickname, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries quota resource consumption information.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// GetQuotaUsageRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetQuotaUsageResponse
        /// </returns>
        public GetQuotaUsageResponse GetQuotaUsageWithOptions(string nickname, GetQuotaUsageRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GetQuotaUsageShrinkRequest request = new GetQuotaUsageShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.PlotTypes))
            {
                request.PlotTypesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.PlotTypes, "plotTypes", "simple");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.YAxisTypes))
            {
                request.YAxisTypesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.YAxisTypes, "yAxisTypes", "simple");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AggMethod))
            {
                query["aggMethod"] = request.AggMethod;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.From))
            {
                query["from"] = request.From;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PlotTypesShrink))
            {
                query["plotTypes"] = request.PlotTypesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductId))
            {
                query["productId"] = request.ProductId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                query["region"] = request.Region;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubQuotaNickname))
            {
                query["subQuotaNickname"] = request.SubQuotaNickname;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["tenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.To))
            {
                query["to"] = request.To;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.YAxisTypesShrink))
            {
                query["yAxisTypes"] = request.YAxisTypesShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetQuotaUsage",
                Version = "2022-01-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/quotas/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(nickname) + "/usage",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetQuotaUsageResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries quota resource consumption information.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// GetQuotaUsageRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetQuotaUsageResponse
        /// </returns>
        public async Task<GetQuotaUsageResponse> GetQuotaUsageWithOptionsAsync(string nickname, GetQuotaUsageRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GetQuotaUsageShrinkRequest request = new GetQuotaUsageShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.PlotTypes))
            {
                request.PlotTypesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.PlotTypes, "plotTypes", "simple");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.YAxisTypes))
            {
                request.YAxisTypesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.YAxisTypes, "yAxisTypes", "simple");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AggMethod))
            {
                query["aggMethod"] = request.AggMethod;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.From))
            {
                query["from"] = request.From;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PlotTypesShrink))
            {
                query["plotTypes"] = request.PlotTypesShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductId))
            {
                query["productId"] = request.ProductId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                query["region"] = request.Region;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubQuotaNickname))
            {
                query["subQuotaNickname"] = request.SubQuotaNickname;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["tenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.To))
            {
                query["to"] = request.To;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.YAxisTypesShrink))
            {
                query["yAxisTypes"] = request.YAxisTypesShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetQuotaUsage",
                Version = "2022-01-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/quotas/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(nickname) + "/usage",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetQuotaUsageResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries quota resource consumption information.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetQuotaUsageRequest
        /// </param>
        /// 
        /// <returns>
        /// GetQuotaUsageResponse
        /// </returns>
        public GetQuotaUsageResponse GetQuotaUsage(string nickname, GetQuotaUsageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetQuotaUsageWithOptions(nickname, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries quota resource consumption information.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetQuotaUsageRequest
        /// </param>
        /// 
        /// <returns>
        /// GetQuotaUsageResponse
        /// </returns>
        public async Task<GetQuotaUsageResponse> GetQuotaUsageAsync(string nickname, GetQuotaUsageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetQuotaUsageWithOptionsAsync(nickname, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains the ACL-based permissions that is granted to a project-level role.</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetRoleAclResponse
        /// </returns>
        public GetRoleAclResponse GetRoleAclWithOptions(string projectName, string roleName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetRoleAcl",
                Version = "2022-01-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/projects/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(projectName) + "/roles/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(roleName) + "/roleAcl",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetRoleAclResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains the ACL-based permissions that is granted to a project-level role.</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetRoleAclResponse
        /// </returns>
        public async Task<GetRoleAclResponse> GetRoleAclWithOptionsAsync(string projectName, string roleName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetRoleAcl",
                Version = "2022-01-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/projects/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(projectName) + "/roles/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(roleName) + "/roleAcl",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetRoleAclResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains the ACL-based permissions that is granted to a project-level role.</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetRoleAclResponse
        /// </returns>
        public GetRoleAclResponse GetRoleAcl(string projectName, string roleName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetRoleAclWithOptions(projectName, roleName, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains the ACL-based permissions that is granted to a project-level role.</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetRoleAclResponse
        /// </returns>
        public async Task<GetRoleAclResponse> GetRoleAclAsync(string projectName, string roleName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetRoleAclWithOptionsAsync(projectName, roleName, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains ACL-based permissions on an object that are granted to a project-level role.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetRoleAclOnObjectRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetRoleAclOnObjectResponse
        /// </returns>
        public GetRoleAclOnObjectResponse GetRoleAclOnObjectWithOptions(string projectName, string roleName, GetRoleAclOnObjectRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ObjectName))
            {
                query["objectName"] = request.ObjectName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ObjectType))
            {
                query["objectType"] = request.ObjectType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetRoleAclOnObject",
                Version = "2022-01-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/projects/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(projectName) + "/roles/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(roleName) + "/acl",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetRoleAclOnObjectResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains ACL-based permissions on an object that are granted to a project-level role.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetRoleAclOnObjectRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetRoleAclOnObjectResponse
        /// </returns>
        public async Task<GetRoleAclOnObjectResponse> GetRoleAclOnObjectWithOptionsAsync(string projectName, string roleName, GetRoleAclOnObjectRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ObjectName))
            {
                query["objectName"] = request.ObjectName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ObjectType))
            {
                query["objectType"] = request.ObjectType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetRoleAclOnObject",
                Version = "2022-01-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/projects/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(projectName) + "/roles/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(roleName) + "/acl",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetRoleAclOnObjectResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains ACL-based permissions on an object that are granted to a project-level role.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetRoleAclOnObjectRequest
        /// </param>
        /// 
        /// <returns>
        /// GetRoleAclOnObjectResponse
        /// </returns>
        public GetRoleAclOnObjectResponse GetRoleAclOnObject(string projectName, string roleName, GetRoleAclOnObjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetRoleAclOnObjectWithOptions(projectName, roleName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains ACL-based permissions on an object that are granted to a project-level role.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetRoleAclOnObjectRequest
        /// </param>
        /// 
        /// <returns>
        /// GetRoleAclOnObjectResponse
        /// </returns>
        public async Task<GetRoleAclOnObjectResponse> GetRoleAclOnObjectAsync(string projectName, string roleName, GetRoleAclOnObjectRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetRoleAclOnObjectWithOptionsAsync(projectName, roleName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains the policy that is attached to a project-level role.</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetRolePolicyResponse
        /// </returns>
        public GetRolePolicyResponse GetRolePolicyWithOptions(string projectName, string roleName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetRolePolicy",
                Version = "2022-01-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/projects/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(projectName) + "/roles/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(roleName) + "/policy",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetRolePolicyResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains the policy that is attached to a project-level role.</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetRolePolicyResponse
        /// </returns>
        public async Task<GetRolePolicyResponse> GetRolePolicyWithOptionsAsync(string projectName, string roleName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetRolePolicy",
                Version = "2022-01-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/projects/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(projectName) + "/roles/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(roleName) + "/policy",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetRolePolicyResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains the policy that is attached to a project-level role.</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetRolePolicyResponse
        /// </returns>
        public GetRolePolicyResponse GetRolePolicy(string projectName, string roleName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetRolePolicyWithOptions(projectName, roleName, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains the policy that is attached to a project-level role.</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetRolePolicyResponse
        /// </returns>
        public async Task<GetRolePolicyResponse> GetRolePolicyAsync(string projectName, string roleName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetRolePolicyWithOptionsAsync(projectName, roleName, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains the running state data of jobs that are in the running state in a specified period of time.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// GetRunningJobsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetRunningJobsResponse
        /// </returns>
        public GetRunningJobsResponse GetRunningJobsWithOptions(GetRunningJobsRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GetRunningJobsShrinkRequest request = new GetRunningJobsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.JobOwnerList))
            {
                request.JobOwnerListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.JobOwnerList, "jobOwnerList", "simple");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.QuotaNicknameList))
            {
                request.QuotaNicknameListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.QuotaNicknameList, "quotaNicknameList", "simple");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.From))
            {
                query["from"] = request.From;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobOwnerListShrink))
            {
                query["jobOwnerList"] = request.JobOwnerListShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QuotaNicknameListShrink))
            {
                query["quotaNicknameList"] = request.QuotaNicknameListShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.To))
            {
                query["to"] = request.To;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetRunningJobs",
                Version = "2022-01-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/jobs/runningJobs",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetRunningJobsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains the running state data of jobs that are in the running state in a specified period of time.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// GetRunningJobsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetRunningJobsResponse
        /// </returns>
        public async Task<GetRunningJobsResponse> GetRunningJobsWithOptionsAsync(GetRunningJobsRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            GetRunningJobsShrinkRequest request = new GetRunningJobsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.JobOwnerList))
            {
                request.JobOwnerListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.JobOwnerList, "jobOwnerList", "simple");
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.QuotaNicknameList))
            {
                request.QuotaNicknameListShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.QuotaNicknameList, "quotaNicknameList", "simple");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.From))
            {
                query["from"] = request.From;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobOwnerListShrink))
            {
                query["jobOwnerList"] = request.JobOwnerListShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QuotaNicknameListShrink))
            {
                query["quotaNicknameList"] = request.QuotaNicknameListShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.To))
            {
                query["to"] = request.To;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetRunningJobs",
                Version = "2022-01-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/jobs/runningJobs",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetRunningJobsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains the running state data of jobs that are in the running state in a specified period of time.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetRunningJobsRequest
        /// </param>
        /// 
        /// <returns>
        /// GetRunningJobsResponse
        /// </returns>
        public GetRunningJobsResponse GetRunningJobs(GetRunningJobsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetRunningJobsWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains the running state data of jobs that are in the running state in a specified period of time.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetRunningJobsRequest
        /// </param>
        /// 
        /// <returns>
        /// GetRunningJobsResponse
        /// </returns>
        public async Task<GetRunningJobsResponse> GetRunningJobsAsync(GetRunningJobsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetRunningJobsWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Views the information about MaxCompute internal tables, views, external tables, clustered tables, or transactional tables.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetTableInfoRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetTableInfoResponse
        /// </returns>
        public GetTableInfoResponse GetTableInfoWithOptions(string projectName, string tableName, GetTableInfoRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SchemaName))
            {
                query["schemaName"] = request.SchemaName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["type"] = request.Type;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetTableInfo",
                Version = "2022-01-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/projects/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(projectName) + "/tables/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(tableName),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTableInfoResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Views the information about MaxCompute internal tables, views, external tables, clustered tables, or transactional tables.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetTableInfoRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetTableInfoResponse
        /// </returns>
        public async Task<GetTableInfoResponse> GetTableInfoWithOptionsAsync(string projectName, string tableName, GetTableInfoRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SchemaName))
            {
                query["schemaName"] = request.SchemaName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["type"] = request.Type;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetTableInfo",
                Version = "2022-01-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/projects/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(projectName) + "/tables/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(tableName),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTableInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Views the information about MaxCompute internal tables, views, external tables, clustered tables, or transactional tables.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetTableInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// GetTableInfoResponse
        /// </returns>
        public GetTableInfoResponse GetTableInfo(string projectName, string tableName, GetTableInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetTableInfoWithOptions(projectName, tableName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Views the information about MaxCompute internal tables, views, external tables, clustered tables, or transactional tables.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetTableInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// GetTableInfoResponse
        /// </returns>
        public async Task<GetTableInfoResponse> GetTableInfoAsync(string projectName, string tableName, GetTableInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetTableInfoWithOptionsAsync(projectName, tableName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains the trusted projects of the current project.</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetTrustedProjectsResponse
        /// </returns>
        public GetTrustedProjectsResponse GetTrustedProjectsWithOptions(string projectName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetTrustedProjects",
                Version = "2022-01-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/projects/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(projectName) + "/trustedProjects",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTrustedProjectsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains the trusted projects of the current project.</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetTrustedProjectsResponse
        /// </returns>
        public async Task<GetTrustedProjectsResponse> GetTrustedProjectsWithOptionsAsync(string projectName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetTrustedProjects",
                Version = "2022-01-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/projects/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(projectName) + "/trustedProjects",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetTrustedProjectsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains the trusted projects of the current project.</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetTrustedProjectsResponse
        /// </returns>
        public GetTrustedProjectsResponse GetTrustedProjects(string projectName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetTrustedProjectsWithOptions(projectName, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains the trusted projects of the current project.</para>
        /// </summary>
        /// 
        /// <returns>
        /// GetTrustedProjectsResponse
        /// </returns>
        public async Task<GetTrustedProjectsResponse> GetTrustedProjectsAsync(string projectName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetTrustedProjectsWithOptionsAsync(projectName, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Terminates a running job.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// KillJobsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// KillJobsResponse
        /// </returns>
        public KillJobsResponse KillJobsWithOptions(KillJobsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                query["region"] = request.Region;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["tenantId"] = request.TenantId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "KillJobs",
                Version = "2022-01-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/jobs/kill",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<KillJobsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Terminates a running job.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// KillJobsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// KillJobsResponse
        /// </returns>
        public async Task<KillJobsResponse> KillJobsWithOptionsAsync(KillJobsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                query["region"] = request.Region;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["tenantId"] = request.TenantId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "KillJobs",
                Version = "2022-01-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/jobs/kill",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<KillJobsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Terminates a running job.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// KillJobsRequest
        /// </param>
        /// 
        /// <returns>
        /// KillJobsResponse
        /// </returns>
        public KillJobsResponse KillJobs(KillJobsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return KillJobsWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Terminates a running job.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// KillJobsRequest
        /// </param>
        /// 
        /// <returns>
        /// KillJobsResponse
        /// </returns>
        public async Task<KillJobsResponse> KillJobsAsync(KillJobsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await KillJobsWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Get compute usage of pay-as-you-go jobs.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListComputeMetricsByInstanceRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListComputeMetricsByInstanceResponse
        /// </returns>
        public ListComputeMetricsByInstanceResponse ListComputeMetricsByInstanceWithOptions(ListComputeMetricsByInstanceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndDate))
            {
                body["endDate"] = request.EndDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["instanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobOwner))
            {
                body["jobOwner"] = request.JobOwner;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectNames))
            {
                body["projectNames"] = request.ProjectNames;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                body["region"] = request.Region;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Signature))
            {
                body["signature"] = request.Signature;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SpecCodes))
            {
                body["specCodes"] = request.SpecCodes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartDate))
            {
                body["startDate"] = request.StartDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Types))
            {
                body["types"] = request.Types;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListComputeMetricsByInstance",
                Version = "2022-01-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/computeMetrics/listByInstance",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListComputeMetricsByInstanceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Get compute usage of pay-as-you-go jobs.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListComputeMetricsByInstanceRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListComputeMetricsByInstanceResponse
        /// </returns>
        public async Task<ListComputeMetricsByInstanceResponse> ListComputeMetricsByInstanceWithOptionsAsync(ListComputeMetricsByInstanceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndDate))
            {
                body["endDate"] = request.EndDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceId))
            {
                body["instanceId"] = request.InstanceId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobOwner))
            {
                body["jobOwner"] = request.JobOwner;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                body["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                body["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectNames))
            {
                body["projectNames"] = request.ProjectNames;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                body["region"] = request.Region;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Signature))
            {
                body["signature"] = request.Signature;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SpecCodes))
            {
                body["specCodes"] = request.SpecCodes;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartDate))
            {
                body["startDate"] = request.StartDate;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Types))
            {
                body["types"] = request.Types;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListComputeMetricsByInstance",
                Version = "2022-01-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/computeMetrics/listByInstance",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListComputeMetricsByInstanceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Get compute usage of pay-as-you-go jobs.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListComputeMetricsByInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// ListComputeMetricsByInstanceResponse
        /// </returns>
        public ListComputeMetricsByInstanceResponse ListComputeMetricsByInstance(ListComputeMetricsByInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListComputeMetricsByInstanceWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Get compute usage of pay-as-you-go jobs.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListComputeMetricsByInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// ListComputeMetricsByInstanceResponse
        /// </returns>
        public async Task<ListComputeMetricsByInstanceResponse> ListComputeMetricsByInstanceAsync(ListComputeMetricsByInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListComputeMetricsByInstanceWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Get computeQuotaPlan list.</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListComputeQuotaPlanResponse
        /// </returns>
        public ListComputeQuotaPlanResponse ListComputeQuotaPlanWithOptions(string nickname, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListComputeQuotaPlan",
                Version = "2022-01-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/quotas/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(nickname) + "/computeQuotaPlan",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListComputeQuotaPlanResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Get computeQuotaPlan list.</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListComputeQuotaPlanResponse
        /// </returns>
        public async Task<ListComputeQuotaPlanResponse> ListComputeQuotaPlanWithOptionsAsync(string nickname, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListComputeQuotaPlan",
                Version = "2022-01-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/quotas/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(nickname) + "/computeQuotaPlan",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListComputeQuotaPlanResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Get computeQuotaPlan list.</para>
        /// </summary>
        /// 
        /// <returns>
        /// ListComputeQuotaPlanResponse
        /// </returns>
        public ListComputeQuotaPlanResponse ListComputeQuotaPlan(string nickname)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListComputeQuotaPlanWithOptions(nickname, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Get computeQuotaPlan list.</para>
        /// </summary>
        /// 
        /// <returns>
        /// ListComputeQuotaPlanResponse
        /// </returns>
        public async Task<ListComputeQuotaPlanResponse> ListComputeQuotaPlanAsync(string nickname)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListComputeQuotaPlanWithOptionsAsync(nickname, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains functions in a MaxCompute project.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListFunctionsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListFunctionsResponse
        /// </returns>
        public ListFunctionsResponse ListFunctionsWithOptions(string projectName, ListFunctionsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Marker))
            {
                query["marker"] = request.Marker;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxItem))
            {
                query["maxItem"] = request.MaxItem;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Prefix))
            {
                query["prefix"] = request.Prefix;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SchemaName))
            {
                query["schemaName"] = request.SchemaName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListFunctions",
                Version = "2022-01-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/projects/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(projectName) + "/functions",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListFunctionsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains functions in a MaxCompute project.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListFunctionsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListFunctionsResponse
        /// </returns>
        public async Task<ListFunctionsResponse> ListFunctionsWithOptionsAsync(string projectName, ListFunctionsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Marker))
            {
                query["marker"] = request.Marker;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxItem))
            {
                query["maxItem"] = request.MaxItem;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Prefix))
            {
                query["prefix"] = request.Prefix;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SchemaName))
            {
                query["schemaName"] = request.SchemaName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListFunctions",
                Version = "2022-01-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/projects/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(projectName) + "/functions",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListFunctionsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains functions in a MaxCompute project.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListFunctionsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListFunctionsResponse
        /// </returns>
        public ListFunctionsResponse ListFunctions(string projectName, ListFunctionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListFunctionsWithOptions(projectName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains functions in a MaxCompute project.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListFunctionsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListFunctionsResponse
        /// </returns>
        public async Task<ListFunctionsResponse> ListFunctionsAsync(string projectName, ListFunctionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListFunctionsWithOptionsAsync(projectName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Views a list of jobs.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListJobInfosRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListJobInfosResponse
        /// </returns>
        public ListJobInfosResponse ListJobInfosWithOptions(ListJobInfosRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AscOrder))
            {
                query["ascOrder"] = request.AscOrder;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderColumn))
            {
                query["orderColumn"] = request.OrderColumn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                query["region"] = request.Region;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["tenantId"] = request.TenantId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtNodeIdList))
            {
                body["extNodeIdList"] = request.ExtNodeIdList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.From))
            {
                body["from"] = request.From;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceIdList))
            {
                body["instanceIdList"] = request.InstanceIdList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobOwnerList))
            {
                body["jobOwnerList"] = request.JobOwnerList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PriorityList))
            {
                body["priorityList"] = request.PriorityList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectList))
            {
                body["projectList"] = request.ProjectList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QuotaNickname))
            {
                body["quotaNickname"] = request.QuotaNickname;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SceneTagList))
            {
                body["sceneTagList"] = request.SceneTagList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SignatureList))
            {
                body["signatureList"] = request.SignatureList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortByList))
            {
                body["sortByList"] = request.SortByList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortOrderList))
            {
                body["sortOrderList"] = request.SortOrderList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StatusList))
            {
                body["statusList"] = request.StatusList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.To))
            {
                body["to"] = request.To;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TypeList))
            {
                body["typeList"] = request.TypeList;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListJobInfos",
                Version = "2022-01-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/jobs",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListJobInfosResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Views a list of jobs.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListJobInfosRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListJobInfosResponse
        /// </returns>
        public async Task<ListJobInfosResponse> ListJobInfosWithOptionsAsync(ListJobInfosRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AscOrder))
            {
                query["ascOrder"] = request.AscOrder;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderColumn))
            {
                query["orderColumn"] = request.OrderColumn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                query["region"] = request.Region;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["tenantId"] = request.TenantId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtNodeIdList))
            {
                body["extNodeIdList"] = request.ExtNodeIdList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.From))
            {
                body["from"] = request.From;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceIdList))
            {
                body["instanceIdList"] = request.InstanceIdList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobOwnerList))
            {
                body["jobOwnerList"] = request.JobOwnerList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PriorityList))
            {
                body["priorityList"] = request.PriorityList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectList))
            {
                body["projectList"] = request.ProjectList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QuotaNickname))
            {
                body["quotaNickname"] = request.QuotaNickname;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SceneTagList))
            {
                body["sceneTagList"] = request.SceneTagList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SignatureList))
            {
                body["signatureList"] = request.SignatureList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortByList))
            {
                body["sortByList"] = request.SortByList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortOrderList))
            {
                body["sortOrderList"] = request.SortOrderList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StatusList))
            {
                body["statusList"] = request.StatusList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.To))
            {
                body["to"] = request.To;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TypeList))
            {
                body["typeList"] = request.TypeList;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListJobInfos",
                Version = "2022-01-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/jobs",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListJobInfosResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Views a list of jobs.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListJobInfosRequest
        /// </param>
        /// 
        /// <returns>
        /// ListJobInfosResponse
        /// </returns>
        public ListJobInfosResponse ListJobInfos(ListJobInfosRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListJobInfosWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Views a list of jobs.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListJobInfosRequest
        /// </param>
        /// 
        /// <returns>
        /// ListJobInfosResponse
        /// </returns>
        public async Task<ListJobInfosResponse> ListJobInfosAsync(ListJobInfosRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListJobInfosWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieve performance metrics for completed jobs.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListJobMetricRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListJobMetricResponse
        /// </returns>
        public ListJobMetricResponse ListJobMetricWithOptions(ListJobMetricRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["endTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["startTime"] = request.StartTime;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Group))
            {
                body["group"] = request.Group;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Metric))
            {
                body["metric"] = request.Metric;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Period))
            {
                body["period"] = request.Period;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Project))
            {
                body["project"] = request.Project;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Quota))
            {
                body["quota"] = request.Quota;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                body["type"] = request.Type;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListJobMetric",
                Version = "2022-01-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/jobs/metric",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListJobMetricResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieve performance metrics for completed jobs.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListJobMetricRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListJobMetricResponse
        /// </returns>
        public async Task<ListJobMetricResponse> ListJobMetricWithOptionsAsync(ListJobMetricRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["endTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["startTime"] = request.StartTime;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Group))
            {
                body["group"] = request.Group;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Metric))
            {
                body["metric"] = request.Metric;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Period))
            {
                body["period"] = request.Period;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Project))
            {
                body["project"] = request.Project;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Quota))
            {
                body["quota"] = request.Quota;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                body["type"] = request.Type;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListJobMetric",
                Version = "2022-01-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/jobs/metric",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListJobMetricResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieve performance metrics for completed jobs.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListJobMetricRequest
        /// </param>
        /// 
        /// <returns>
        /// ListJobMetricResponse
        /// </returns>
        public ListJobMetricResponse ListJobMetric(ListJobMetricRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListJobMetricWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieve performance metrics for completed jobs.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListJobMetricRequest
        /// </param>
        /// 
        /// <returns>
        /// ListJobMetricResponse
        /// </returns>
        public async Task<ListJobMetricResponse> ListJobMetricAsync(ListJobMetricRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListJobMetricWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Views a list of job snapshot data at a specific point in time.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListJobSnapshotInfosRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListJobSnapshotInfosResponse
        /// </returns>
        public ListJobSnapshotInfosResponse ListJobSnapshotInfosWithOptions(ListJobSnapshotInfosRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AscOrder))
            {
                query["ascOrder"] = request.AscOrder;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderColumn))
            {
                query["orderColumn"] = request.OrderColumn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                query["region"] = request.Region;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["tenantId"] = request.TenantId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtNodeIdList))
            {
                body["extNodeIdList"] = request.ExtNodeIdList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.From))
            {
                body["from"] = request.From;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceIdList))
            {
                body["instanceIdList"] = request.InstanceIdList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobOwnerList))
            {
                body["jobOwnerList"] = request.JobOwnerList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PriorityList))
            {
                body["priorityList"] = request.PriorityList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectList))
            {
                body["projectList"] = request.ProjectList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QuotaNickname))
            {
                body["quotaNickname"] = request.QuotaNickname;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SignatureList))
            {
                body["signatureList"] = request.SignatureList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortByList))
            {
                body["sortByList"] = request.SortByList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortOrderList))
            {
                body["sortOrderList"] = request.SortOrderList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StatusList))
            {
                body["statusList"] = request.StatusList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.To))
            {
                body["to"] = request.To;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TypeList))
            {
                body["typeList"] = request.TypeList;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListJobSnapshotInfos",
                Version = "2022-01-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/jobs/snapshot",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListJobSnapshotInfosResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Views a list of job snapshot data at a specific point in time.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListJobSnapshotInfosRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListJobSnapshotInfosResponse
        /// </returns>
        public async Task<ListJobSnapshotInfosResponse> ListJobSnapshotInfosWithOptionsAsync(ListJobSnapshotInfosRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AscOrder))
            {
                query["ascOrder"] = request.AscOrder;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderColumn))
            {
                query["orderColumn"] = request.OrderColumn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                query["region"] = request.Region;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["tenantId"] = request.TenantId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtNodeIdList))
            {
                body["extNodeIdList"] = request.ExtNodeIdList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.From))
            {
                body["from"] = request.From;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InstanceIdList))
            {
                body["instanceIdList"] = request.InstanceIdList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobOwnerList))
            {
                body["jobOwnerList"] = request.JobOwnerList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PriorityList))
            {
                body["priorityList"] = request.PriorityList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProjectList))
            {
                body["projectList"] = request.ProjectList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QuotaNickname))
            {
                body["quotaNickname"] = request.QuotaNickname;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SignatureList))
            {
                body["signatureList"] = request.SignatureList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortByList))
            {
                body["sortByList"] = request.SortByList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortOrderList))
            {
                body["sortOrderList"] = request.SortOrderList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StatusList))
            {
                body["statusList"] = request.StatusList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.To))
            {
                body["to"] = request.To;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TypeList))
            {
                body["typeList"] = request.TypeList;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListJobSnapshotInfos",
                Version = "2022-01-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/jobs/snapshot",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListJobSnapshotInfosResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Views a list of job snapshot data at a specific point in time.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListJobSnapshotInfosRequest
        /// </param>
        /// 
        /// <returns>
        /// ListJobSnapshotInfosResponse
        /// </returns>
        public ListJobSnapshotInfosResponse ListJobSnapshotInfos(ListJobSnapshotInfosRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListJobSnapshotInfosWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Views a list of job snapshot data at a specific point in time.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListJobSnapshotInfosRequest
        /// </param>
        /// 
        /// <returns>
        /// ListJobSnapshotInfosResponse
        /// </returns>
        public async Task<ListJobSnapshotInfosResponse> ListJobSnapshotInfosAsync(ListJobSnapshotInfosRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListJobSnapshotInfosWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>ListMmsDataSources</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListMmsDataSourcesRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListMmsDataSourcesResponse
        /// </returns>
        public ListMmsDataSourcesResponse ListMmsDataSourcesWithOptions(ListMmsDataSourcesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNum))
            {
                query["pageNum"] = request.PageNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                query["region"] = request.Region;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["type"] = request.Type;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListMmsDataSources",
                Version = "2022-01-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/mms/datasources",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListMmsDataSourcesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>ListMmsDataSources</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListMmsDataSourcesRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListMmsDataSourcesResponse
        /// </returns>
        public async Task<ListMmsDataSourcesResponse> ListMmsDataSourcesWithOptionsAsync(ListMmsDataSourcesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNum))
            {
                query["pageNum"] = request.PageNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                query["region"] = request.Region;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["type"] = request.Type;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListMmsDataSources",
                Version = "2022-01-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/mms/datasources",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListMmsDataSourcesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>ListMmsDataSources</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListMmsDataSourcesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListMmsDataSourcesResponse
        /// </returns>
        public ListMmsDataSourcesResponse ListMmsDataSources(ListMmsDataSourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListMmsDataSourcesWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>ListMmsDataSources</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListMmsDataSourcesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListMmsDataSourcesResponse
        /// </returns>
        public async Task<ListMmsDataSourcesResponse> ListMmsDataSourcesAsync(ListMmsDataSourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListMmsDataSourcesWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取一个数据源内“库”列表</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ListMmsDbsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListMmsDbsResponse
        /// </returns>
        public ListMmsDbsResponse ListMmsDbsWithOptions(string sourceId, ListMmsDbsRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListMmsDbsShrinkRequest request = new ListMmsDbsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Sorter))
            {
                request.SorterShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Sorter, "sorter", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNum))
            {
                query["pageNum"] = request.PageNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SorterShrink))
            {
                query["sorter"] = request.SorterShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["status"] = request.Status;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListMmsDbs",
                Version = "2022-01-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/mms/datasources/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(sourceId) + "/dbs",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListMmsDbsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取一个数据源内“库”列表</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ListMmsDbsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListMmsDbsResponse
        /// </returns>
        public async Task<ListMmsDbsResponse> ListMmsDbsWithOptionsAsync(string sourceId, ListMmsDbsRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListMmsDbsShrinkRequest request = new ListMmsDbsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Sorter))
            {
                request.SorterShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Sorter, "sorter", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNum))
            {
                query["pageNum"] = request.PageNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SorterShrink))
            {
                query["sorter"] = request.SorterShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["status"] = request.Status;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListMmsDbs",
                Version = "2022-01-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/mms/datasources/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(sourceId) + "/dbs",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListMmsDbsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取一个数据源内“库”列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListMmsDbsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListMmsDbsResponse
        /// </returns>
        public ListMmsDbsResponse ListMmsDbs(string sourceId, ListMmsDbsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListMmsDbsWithOptions(sourceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取一个数据源内“库”列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListMmsDbsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListMmsDbsResponse
        /// </returns>
        public async Task<ListMmsDbsResponse> ListMmsDbsAsync(string sourceId, ListMmsDbsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListMmsDbsWithOptionsAsync(sourceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>ListMmsJobs</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListMmsJobsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListMmsJobsResponse
        /// </returns>
        public ListMmsJobsResponse ListMmsJobsWithOptions(string sourceId, ListMmsJobsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DstDbName))
            {
                query["dstDbName"] = request.DstDbName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DstTableName))
            {
                query["dstTableName"] = request.DstTableName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNum))
            {
                query["pageNum"] = request.PageNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SrcDbName))
            {
                query["srcDbName"] = request.SrcDbName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SrcTableName))
            {
                query["srcTableName"] = request.SrcTableName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Stopped))
            {
                query["stopped"] = request.Stopped;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Sorter))
            {
                query["sorter"] = request.Sorter;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListMmsJobs",
                Version = "2022-01-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/mms/datasources/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(sourceId) + "/jobs",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListMmsJobsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>ListMmsJobs</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListMmsJobsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListMmsJobsResponse
        /// </returns>
        public async Task<ListMmsJobsResponse> ListMmsJobsWithOptionsAsync(string sourceId, ListMmsJobsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DstDbName))
            {
                query["dstDbName"] = request.DstDbName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DstTableName))
            {
                query["dstTableName"] = request.DstTableName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNum))
            {
                query["pageNum"] = request.PageNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SrcDbName))
            {
                query["srcDbName"] = request.SrcDbName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SrcTableName))
            {
                query["srcTableName"] = request.SrcTableName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Stopped))
            {
                query["stopped"] = request.Stopped;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Sorter))
            {
                query["sorter"] = request.Sorter;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListMmsJobs",
                Version = "2022-01-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/mms/datasources/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(sourceId) + "/jobs",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListMmsJobsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>ListMmsJobs</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListMmsJobsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListMmsJobsResponse
        /// </returns>
        public ListMmsJobsResponse ListMmsJobs(string sourceId, ListMmsJobsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListMmsJobsWithOptions(sourceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>ListMmsJobs</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListMmsJobsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListMmsJobsResponse
        /// </returns>
        public async Task<ListMmsJobsResponse> ListMmsJobsAsync(string sourceId, ListMmsJobsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListMmsJobsWithOptionsAsync(sourceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取元数据-分区</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ListMmsPartitionsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListMmsPartitionsResponse
        /// </returns>
        public ListMmsPartitionsResponse ListMmsPartitionsWithOptions(string sourceId, ListMmsPartitionsRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListMmsPartitionsShrinkRequest request = new ListMmsPartitionsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Status))
            {
                request.StatusShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Status, "status", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DbId))
            {
                query["dbId"] = request.DbId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DbName))
            {
                query["dbName"] = request.DbName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LastDdlTimeEnd))
            {
                query["lastDdlTimeEnd"] = request.LastDdlTimeEnd;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LastDdlTimeStart))
            {
                query["lastDdlTimeStart"] = request.LastDdlTimeStart;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNum))
            {
                query["pageNum"] = request.PageNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StatusShrink))
            {
                query["status"] = request.StatusShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TableName))
            {
                query["tableName"] = request.TableName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Updated))
            {
                query["updated"] = request.Updated;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Value))
            {
                query["value"] = request.Value;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Sorter))
            {
                query["sorter"] = request.Sorter;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListMmsPartitions",
                Version = "2022-01-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/mms/datasources/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(sourceId) + "/partitions",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListMmsPartitionsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取元数据-分区</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ListMmsPartitionsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListMmsPartitionsResponse
        /// </returns>
        public async Task<ListMmsPartitionsResponse> ListMmsPartitionsWithOptionsAsync(string sourceId, ListMmsPartitionsRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListMmsPartitionsShrinkRequest request = new ListMmsPartitionsShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Status))
            {
                request.StatusShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Status, "status", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DbId))
            {
                query["dbId"] = request.DbId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DbName))
            {
                query["dbName"] = request.DbName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LastDdlTimeEnd))
            {
                query["lastDdlTimeEnd"] = request.LastDdlTimeEnd;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LastDdlTimeStart))
            {
                query["lastDdlTimeStart"] = request.LastDdlTimeStart;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNum))
            {
                query["pageNum"] = request.PageNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StatusShrink))
            {
                query["status"] = request.StatusShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TableName))
            {
                query["tableName"] = request.TableName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Updated))
            {
                query["updated"] = request.Updated;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Value))
            {
                query["value"] = request.Value;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Sorter))
            {
                query["sorter"] = request.Sorter;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListMmsPartitions",
                Version = "2022-01-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/mms/datasources/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(sourceId) + "/partitions",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListMmsPartitionsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取元数据-分区</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListMmsPartitionsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListMmsPartitionsResponse
        /// </returns>
        public ListMmsPartitionsResponse ListMmsPartitions(string sourceId, ListMmsPartitionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListMmsPartitionsWithOptions(sourceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取元数据-分区</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListMmsPartitionsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListMmsPartitionsResponse
        /// </returns>
        public async Task<ListMmsPartitionsResponse> ListMmsPartitionsAsync(string sourceId, ListMmsPartitionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListMmsPartitionsWithOptionsAsync(sourceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>ListMmsTables</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ListMmsTablesRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListMmsTablesResponse
        /// </returns>
        public ListMmsTablesResponse ListMmsTablesWithOptions(string sourceId, ListMmsTablesRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListMmsTablesShrinkRequest request = new ListMmsTablesShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Status))
            {
                request.StatusShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Status, "status", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DbId))
            {
                query["dbId"] = request.DbId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DbName))
            {
                query["dbName"] = request.DbName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HasPartitions))
            {
                query["hasPartitions"] = request.HasPartitions;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LastDdlTimeEnd))
            {
                query["lastDdlTimeEnd"] = request.LastDdlTimeEnd;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LastDdlTimeStart))
            {
                query["lastDdlTimeStart"] = request.LastDdlTimeStart;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OnlyName))
            {
                query["onlyName"] = request.OnlyName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNum))
            {
                query["pageNum"] = request.PageNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StatusShrink))
            {
                query["status"] = request.StatusShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["type"] = request.Type;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Sorter))
            {
                query["sorter"] = request.Sorter;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListMmsTables",
                Version = "2022-01-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/mms/datasources/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(sourceId) + "/tables",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListMmsTablesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>ListMmsTables</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ListMmsTablesRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListMmsTablesResponse
        /// </returns>
        public async Task<ListMmsTablesResponse> ListMmsTablesWithOptionsAsync(string sourceId, ListMmsTablesRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListMmsTablesShrinkRequest request = new ListMmsTablesShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Status))
            {
                request.StatusShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Status, "status", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DbId))
            {
                query["dbId"] = request.DbId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DbName))
            {
                query["dbName"] = request.DbName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.HasPartitions))
            {
                query["hasPartitions"] = request.HasPartitions;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LastDdlTimeEnd))
            {
                query["lastDdlTimeEnd"] = request.LastDdlTimeEnd;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.LastDdlTimeStart))
            {
                query["lastDdlTimeStart"] = request.LastDdlTimeStart;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OnlyName))
            {
                query["onlyName"] = request.OnlyName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNum))
            {
                query["pageNum"] = request.PageNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StatusShrink))
            {
                query["status"] = request.StatusShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["type"] = request.Type;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Sorter))
            {
                query["sorter"] = request.Sorter;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListMmsTables",
                Version = "2022-01-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/mms/datasources/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(sourceId) + "/tables",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListMmsTablesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>ListMmsTables</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListMmsTablesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListMmsTablesResponse
        /// </returns>
        public ListMmsTablesResponse ListMmsTables(string sourceId, ListMmsTablesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListMmsTablesWithOptions(sourceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>ListMmsTables</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListMmsTablesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListMmsTablesResponse
        /// </returns>
        public async Task<ListMmsTablesResponse> ListMmsTablesAsync(string sourceId, ListMmsTablesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListMmsTablesWithOptionsAsync(sourceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>ListMmsTaskLogs</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListMmsTaskLogsResponse
        /// </returns>
        public ListMmsTaskLogsResponse ListMmsTaskLogsWithOptions(string sourceId, string taskId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListMmsTaskLogs",
                Version = "2022-01-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/mms/datasources/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(sourceId) + "/tasks/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(taskId) + "/logs",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListMmsTaskLogsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>ListMmsTaskLogs</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListMmsTaskLogsResponse
        /// </returns>
        public async Task<ListMmsTaskLogsResponse> ListMmsTaskLogsWithOptionsAsync(string sourceId, string taskId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListMmsTaskLogs",
                Version = "2022-01-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/mms/datasources/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(sourceId) + "/tasks/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(taskId) + "/logs",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListMmsTaskLogsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>ListMmsTaskLogs</para>
        /// </summary>
        /// 
        /// <returns>
        /// ListMmsTaskLogsResponse
        /// </returns>
        public ListMmsTaskLogsResponse ListMmsTaskLogs(string sourceId, string taskId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListMmsTaskLogsWithOptions(sourceId, taskId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>ListMmsTaskLogs</para>
        /// </summary>
        /// 
        /// <returns>
        /// ListMmsTaskLogsResponse
        /// </returns>
        public async Task<ListMmsTaskLogsResponse> ListMmsTaskLogsAsync(string sourceId, string taskId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListMmsTaskLogsWithOptionsAsync(sourceId, taskId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>ListMmsTasks</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListMmsTasksRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListMmsTasksResponse
        /// </returns>
        public ListMmsTasksResponse ListMmsTasksWithOptions(string sourceId, ListMmsTasksRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DstDbName))
            {
                query["dstDbName"] = request.DstDbName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DstTableName))
            {
                query["dstTableName"] = request.DstTableName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobId))
            {
                query["jobId"] = request.JobId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobName))
            {
                query["jobName"] = request.JobName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNum))
            {
                query["pageNum"] = request.PageNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Partition))
            {
                query["partition"] = request.Partition;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SrcDbName))
            {
                query["srcDbName"] = request.SrcDbName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SrcTableName))
            {
                query["srcTableName"] = request.SrcTableName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Sorter))
            {
                query["sorter"] = request.Sorter;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListMmsTasks",
                Version = "2022-01-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/mms/datasources/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(sourceId) + "/tasks",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListMmsTasksResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>ListMmsTasks</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListMmsTasksRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListMmsTasksResponse
        /// </returns>
        public async Task<ListMmsTasksResponse> ListMmsTasksWithOptionsAsync(string sourceId, ListMmsTasksRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DstDbName))
            {
                query["dstDbName"] = request.DstDbName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.DstTableName))
            {
                query["dstTableName"] = request.DstTableName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobId))
            {
                query["jobId"] = request.JobId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.JobName))
            {
                query["jobName"] = request.JobName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNum))
            {
                query["pageNum"] = request.PageNum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Partition))
            {
                query["partition"] = request.Partition;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SrcDbName))
            {
                query["srcDbName"] = request.SrcDbName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SrcTableName))
            {
                query["srcTableName"] = request.SrcTableName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Status))
            {
                query["status"] = request.Status;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Sorter))
            {
                query["sorter"] = request.Sorter;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListMmsTasks",
                Version = "2022-01-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/mms/datasources/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(sourceId) + "/tasks",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListMmsTasksResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>ListMmsTasks</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListMmsTasksRequest
        /// </param>
        /// 
        /// <returns>
        /// ListMmsTasksResponse
        /// </returns>
        public ListMmsTasksResponse ListMmsTasks(string sourceId, ListMmsTasksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListMmsTasksWithOptions(sourceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>ListMmsTasks</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListMmsTasksRequest
        /// </param>
        /// 
        /// <returns>
        /// ListMmsTasksResponse
        /// </returns>
        public async Task<ListMmsTasksResponse> ListMmsTasksAsync(string sourceId, ListMmsTasksRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListMmsTasksWithOptionsAsync(sourceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the packages in a MaxCompute project.</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListPackagesResponse
        /// </returns>
        public ListPackagesResponse ListPackagesWithOptions(string projectName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListPackages",
                Version = "2022-01-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/projects/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(projectName) + "/packages",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListPackagesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the packages in a MaxCompute project.</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListPackagesResponse
        /// </returns>
        public async Task<ListPackagesResponse> ListPackagesWithOptionsAsync(string projectName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListPackages",
                Version = "2022-01-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/projects/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(projectName) + "/packages",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListPackagesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the packages in a MaxCompute project.</para>
        /// </summary>
        /// 
        /// <returns>
        /// ListPackagesResponse
        /// </returns>
        public ListPackagesResponse ListPackages(string projectName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListPackagesWithOptions(projectName, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the packages in a MaxCompute project.</para>
        /// </summary>
        /// 
        /// <returns>
        /// ListPackagesResponse
        /// </returns>
        public async Task<ListPackagesResponse> ListPackagesAsync(string projectName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListPackagesWithOptionsAsync(projectName, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of users in a project.</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListProjectUsersResponse
        /// </returns>
        public ListProjectUsersResponse ListProjectUsersWithOptions(string projectName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListProjectUsers",
                Version = "2022-01-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/projects/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(projectName) + "/users",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListProjectUsersResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of users in a project.</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListProjectUsersResponse
        /// </returns>
        public async Task<ListProjectUsersResponse> ListProjectUsersWithOptionsAsync(string projectName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListProjectUsers",
                Version = "2022-01-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/projects/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(projectName) + "/users",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListProjectUsersResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of users in a project.</para>
        /// </summary>
        /// 
        /// <returns>
        /// ListProjectUsersResponse
        /// </returns>
        public ListProjectUsersResponse ListProjectUsers(string projectName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListProjectUsersWithOptions(projectName, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of users in a project.</para>
        /// </summary>
        /// 
        /// <returns>
        /// ListProjectUsersResponse
        /// </returns>
        public async Task<ListProjectUsersResponse> ListProjectUsersAsync(string projectName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListProjectUsersWithOptionsAsync(projectName, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of MaxCompute projects.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListProjectsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListProjectsResponse
        /// </returns>
        public ListProjectsResponse ListProjectsWithOptions(ListProjectsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ListSystemCatalog))
            {
                query["listSystemCatalog"] = request.ListSystemCatalog;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Marker))
            {
                query["marker"] = request.Marker;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxItem))
            {
                query["maxItem"] = request.MaxItem;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Prefix))
            {
                query["prefix"] = request.Prefix;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QuotaName))
            {
                query["quotaName"] = request.QuotaName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QuotaNickName))
            {
                query["quotaNickName"] = request.QuotaNickName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                query["region"] = request.Region;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SaleTags))
            {
                query["saleTags"] = request.SaleTags;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["tenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["type"] = request.Type;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListProjects",
                Version = "2022-01-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/projects",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListProjectsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of MaxCompute projects.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListProjectsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListProjectsResponse
        /// </returns>
        public async Task<ListProjectsResponse> ListProjectsWithOptionsAsync(ListProjectsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ListSystemCatalog))
            {
                query["listSystemCatalog"] = request.ListSystemCatalog;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Marker))
            {
                query["marker"] = request.Marker;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxItem))
            {
                query["maxItem"] = request.MaxItem;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Prefix))
            {
                query["prefix"] = request.Prefix;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QuotaName))
            {
                query["quotaName"] = request.QuotaName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QuotaNickName))
            {
                query["quotaNickName"] = request.QuotaNickName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                query["region"] = request.Region;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SaleTags))
            {
                query["saleTags"] = request.SaleTags;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["tenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["type"] = request.Type;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListProjects",
                Version = "2022-01-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/projects",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListProjectsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of MaxCompute projects.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListProjectsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListProjectsResponse
        /// </returns>
        public ListProjectsResponse ListProjects(ListProjectsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListProjectsWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of MaxCompute projects.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListProjectsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListProjectsResponse
        /// </returns>
        public async Task<ListProjectsResponse> ListProjectsAsync(ListProjectsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListProjectsWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries quotas.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListQuotasRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListQuotasResponse
        /// </returns>
        public ListQuotasResponse ListQuotasWithOptions(ListQuotasRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BillingType))
            {
                query["billingType"] = request.BillingType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Marker))
            {
                query["marker"] = request.Marker;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxItem))
            {
                query["maxItem"] = request.MaxItem;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductId))
            {
                query["productId"] = request.ProductId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                query["region"] = request.Region;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SaleTags))
            {
                query["saleTags"] = request.SaleTags;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["tenantId"] = request.TenantId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListQuotas",
                Version = "2022-01-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/quotas",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListQuotasResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries quotas.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListQuotasRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListQuotasResponse
        /// </returns>
        public async Task<ListQuotasResponse> ListQuotasWithOptionsAsync(ListQuotasRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BillingType))
            {
                query["billingType"] = request.BillingType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Marker))
            {
                query["marker"] = request.Marker;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxItem))
            {
                query["maxItem"] = request.MaxItem;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ProductId))
            {
                query["productId"] = request.ProductId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                query["region"] = request.Region;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SaleTags))
            {
                query["saleTags"] = request.SaleTags;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["tenantId"] = request.TenantId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListQuotas",
                Version = "2022-01-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/quotas",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListQuotasResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries quotas.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListQuotasRequest
        /// </param>
        /// 
        /// <returns>
        /// ListQuotasResponse
        /// </returns>
        public ListQuotasResponse ListQuotas(ListQuotasRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListQuotasWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries quotas.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListQuotasRequest
        /// </param>
        /// 
        /// <returns>
        /// ListQuotasResponse
        /// </returns>
        public async Task<ListQuotasResponse> ListQuotasAsync(ListQuotasRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListQuotasWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains quota plans.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListQuotasPlansRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListQuotasPlansResponse
        /// </returns>
        public ListQuotasPlansResponse ListQuotasPlansWithOptions(string nickname, ListQuotasPlansRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                query["region"] = request.Region;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["tenantId"] = request.TenantId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListQuotasPlans",
                Version = "2022-01-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/quotas/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(nickname) + "/plans",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListQuotasPlansResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains quota plans.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListQuotasPlansRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListQuotasPlansResponse
        /// </returns>
        public async Task<ListQuotasPlansResponse> ListQuotasPlansWithOptionsAsync(string nickname, ListQuotasPlansRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                query["region"] = request.Region;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["tenantId"] = request.TenantId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListQuotasPlans",
                Version = "2022-01-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/quotas/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(nickname) + "/plans",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListQuotasPlansResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains quota plans.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListQuotasPlansRequest
        /// </param>
        /// 
        /// <returns>
        /// ListQuotasPlansResponse
        /// </returns>
        public ListQuotasPlansResponse ListQuotasPlans(string nickname, ListQuotasPlansRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListQuotasPlansWithOptions(nickname, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains quota plans.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListQuotasPlansRequest
        /// </param>
        /// 
        /// <returns>
        /// ListQuotasPlansResponse
        /// </returns>
        public async Task<ListQuotasPlansResponse> ListQuotasPlansAsync(string nickname, ListQuotasPlansRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListQuotasPlansWithOptionsAsync(nickname, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains resources in a MaxCompute project.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListResourcesRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListResourcesResponse
        /// </returns>
        public ListResourcesResponse ListResourcesWithOptions(string projectName, ListResourcesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Marker))
            {
                query["marker"] = request.Marker;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxItem))
            {
                query["maxItem"] = request.MaxItem;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SchemaName))
            {
                query["schemaName"] = request.SchemaName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListResources",
                Version = "2022-01-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/projects/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(projectName) + "/resources",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListResourcesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains resources in a MaxCompute project.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListResourcesRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListResourcesResponse
        /// </returns>
        public async Task<ListResourcesResponse> ListResourcesWithOptionsAsync(string projectName, ListResourcesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Marker))
            {
                query["marker"] = request.Marker;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxItem))
            {
                query["maxItem"] = request.MaxItem;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                query["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SchemaName))
            {
                query["schemaName"] = request.SchemaName;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListResources",
                Version = "2022-01-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/projects/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(projectName) + "/resources",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListResourcesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains resources in a MaxCompute project.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListResourcesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListResourcesResponse
        /// </returns>
        public ListResourcesResponse ListResources(string projectName, ListResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListResourcesWithOptions(projectName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains resources in a MaxCompute project.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListResourcesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListResourcesResponse
        /// </returns>
        public async Task<ListResourcesResponse> ListResourcesAsync(string projectName, ListResourcesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListResourcesWithOptionsAsync(projectName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains MaxCompute project-level roles.</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListRolesResponse
        /// </returns>
        public ListRolesResponse ListRolesWithOptions(string projectName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListRoles",
                Version = "2022-01-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/projects/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(projectName) + "/roles",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListRolesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains MaxCompute project-level roles.</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListRolesResponse
        /// </returns>
        public async Task<ListRolesResponse> ListRolesWithOptionsAsync(string projectName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListRoles",
                Version = "2022-01-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/projects/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(projectName) + "/roles",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListRolesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains MaxCompute project-level roles.</para>
        /// </summary>
        /// 
        /// <returns>
        /// ListRolesResponse
        /// </returns>
        public ListRolesResponse ListRoles(string projectName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListRolesWithOptions(projectName, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains MaxCompute project-level roles.</para>
        /// </summary>
        /// 
        /// <returns>
        /// ListRolesResponse
        /// </returns>
        public async Task<ListRolesResponse> ListRolesAsync(string projectName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListRolesWithOptionsAsync(projectName, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the storage details of a specific partition in a partitioned table in a MaxCompute project.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ListStoragePartitionsInfoRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListStoragePartitionsInfoResponse
        /// </returns>
        public ListStoragePartitionsInfoResponse ListStoragePartitionsInfoWithOptions(string project, string table, ListStoragePartitionsInfoRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListStoragePartitionsInfoShrinkRequest request = new ListStoragePartitionsInfoShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Types))
            {
                request.TypesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Types, "types", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AscOrder))
            {
                query["ascOrder"] = request.AscOrder;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Date))
            {
                query["date"] = request.Date;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderColumn))
            {
                query["orderColumn"] = request.OrderColumn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PartitionPrefix))
            {
                query["partitionPrefix"] = request.PartitionPrefix;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                query["region"] = request.Region;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Schema))
            {
                query["schema"] = request.Schema;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["tenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TypesShrink))
            {
                query["types"] = request.TypesShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListStoragePartitionsInfo",
                Version = "2022-01-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/observations/analysis/storage/projects/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(project) + "/tables/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(table) + "/partitionsInfo",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListStoragePartitionsInfoResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the storage details of a specific partition in a partitioned table in a MaxCompute project.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ListStoragePartitionsInfoRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListStoragePartitionsInfoResponse
        /// </returns>
        public async Task<ListStoragePartitionsInfoResponse> ListStoragePartitionsInfoWithOptionsAsync(string project, string table, ListStoragePartitionsInfoRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListStoragePartitionsInfoShrinkRequest request = new ListStoragePartitionsInfoShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Types))
            {
                request.TypesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Types, "types", "json");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AscOrder))
            {
                query["ascOrder"] = request.AscOrder;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Date))
            {
                query["date"] = request.Date;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderColumn))
            {
                query["orderColumn"] = request.OrderColumn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PartitionPrefix))
            {
                query["partitionPrefix"] = request.PartitionPrefix;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                query["region"] = request.Region;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Schema))
            {
                query["schema"] = request.Schema;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["tenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TypesShrink))
            {
                query["types"] = request.TypesShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListStoragePartitionsInfo",
                Version = "2022-01-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/observations/analysis/storage/projects/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(project) + "/tables/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(table) + "/partitionsInfo",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListStoragePartitionsInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the storage details of a specific partition in a partitioned table in a MaxCompute project.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListStoragePartitionsInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// ListStoragePartitionsInfoResponse
        /// </returns>
        public ListStoragePartitionsInfoResponse ListStoragePartitionsInfo(string project, string table, ListStoragePartitionsInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListStoragePartitionsInfoWithOptions(project, table, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the storage details of a specific partition in a partitioned table in a MaxCompute project.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListStoragePartitionsInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// ListStoragePartitionsInfoResponse
        /// </returns>
        public async Task<ListStoragePartitionsInfoResponse> ListStoragePartitionsInfoAsync(string project, string table, ListStoragePartitionsInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListStoragePartitionsInfoWithOptionsAsync(project, table, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the table storage details of a MaxCompute project.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ListStorageTablesInfoRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListStorageTablesInfoResponse
        /// </returns>
        public ListStorageTablesInfoResponse ListStorageTablesInfoWithOptions(string project, ListStorageTablesInfoRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListStorageTablesInfoShrinkRequest request = new ListStorageTablesInfoShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Types))
            {
                request.TypesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Types, "types", "simple");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AscOrder))
            {
                query["ascOrder"] = request.AscOrder;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Date))
            {
                query["date"] = request.Date;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderColumn))
            {
                query["orderColumn"] = request.OrderColumn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecentDays))
            {
                query["recentDays"] = request.RecentDays;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                query["region"] = request.Region;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Schema))
            {
                query["schema"] = request.Schema;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TablePrefix))
            {
                query["tablePrefix"] = request.TablePrefix;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["tenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TypesShrink))
            {
                query["types"] = request.TypesShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListStorageTablesInfo",
                Version = "2022-01-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/observations/analysis/storage/projects/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(project) + "/tablesInfo",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListStorageTablesInfoResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the table storage details of a MaxCompute project.</para>
        /// </summary>
        /// 
        /// <param name="tmpReq">
        /// ListStorageTablesInfoRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListStorageTablesInfoResponse
        /// </returns>
        public async Task<ListStorageTablesInfoResponse> ListStorageTablesInfoWithOptionsAsync(string project, ListStorageTablesInfoRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            ListStorageTablesInfoShrinkRequest request = new ListStorageTablesInfoShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Types))
            {
                request.TypesShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Types, "types", "simple");
            }
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AscOrder))
            {
                query["ascOrder"] = request.AscOrder;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Date))
            {
                query["date"] = request.Date;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderColumn))
            {
                query["orderColumn"] = request.OrderColumn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RecentDays))
            {
                query["recentDays"] = request.RecentDays;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                query["region"] = request.Region;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Schema))
            {
                query["schema"] = request.Schema;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TablePrefix))
            {
                query["tablePrefix"] = request.TablePrefix;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["tenantId"] = request.TenantId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TypesShrink))
            {
                query["types"] = request.TypesShrink;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListStorageTablesInfo",
                Version = "2022-01-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/observations/analysis/storage/projects/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(project) + "/tablesInfo",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListStorageTablesInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the table storage details of a MaxCompute project.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListStorageTablesInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// ListStorageTablesInfoResponse
        /// </returns>
        public ListStorageTablesInfoResponse ListStorageTablesInfo(string project, ListStorageTablesInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListStorageTablesInfoWithOptions(project, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the table storage details of a MaxCompute project.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListStorageTablesInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// ListStorageTablesInfoResponse
        /// </returns>
        public async Task<ListStorageTablesInfoResponse> ListStorageTablesInfoAsync(string project, ListStorageTablesInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListStorageTablesInfoWithOptionsAsync(project, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains tables in a MaxCompute project.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListTablesRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListTablesResponse
        /// </returns>
        public ListTablesResponse ListTablesWithOptions(string projectName, ListTablesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Marker))
            {
                query["marker"] = request.Marker;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxItem))
            {
                query["maxItem"] = request.MaxItem;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Prefix))
            {
                query["prefix"] = request.Prefix;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SchemaName))
            {
                query["schemaName"] = request.SchemaName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["type"] = request.Type;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTables",
                Version = "2022-01-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/projects/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(projectName) + "/tables",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTablesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains tables in a MaxCompute project.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListTablesRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListTablesResponse
        /// </returns>
        public async Task<ListTablesResponse> ListTablesWithOptionsAsync(string projectName, ListTablesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Marker))
            {
                query["marker"] = request.Marker;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxItem))
            {
                query["maxItem"] = request.MaxItem;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Prefix))
            {
                query["prefix"] = request.Prefix;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SchemaName))
            {
                query["schemaName"] = request.SchemaName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                query["type"] = request.Type;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTables",
                Version = "2022-01-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/projects/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(projectName) + "/tables",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTablesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains tables in a MaxCompute project.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListTablesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListTablesResponse
        /// </returns>
        public ListTablesResponse ListTables(string projectName, ListTablesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListTablesWithOptions(projectName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains tables in a MaxCompute project.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListTablesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListTablesResponse
        /// </returns>
        public async Task<ListTablesResponse> ListTablesAsync(string projectName, ListTablesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListTablesWithOptionsAsync(projectName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Displays the time-specific configuration of an exclusive resource group for Tunnel (referred to as Tunnel quota).</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListTunnelQuotaTimerResponse
        /// </returns>
        public ListTunnelQuotaTimerResponse ListTunnelQuotaTimerWithOptions(string nickname, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTunnelQuotaTimer",
                Version = "2022-01-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/tunnel/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(nickname) + "/timers",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTunnelQuotaTimerResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Displays the time-specific configuration of an exclusive resource group for Tunnel (referred to as Tunnel quota).</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListTunnelQuotaTimerResponse
        /// </returns>
        public async Task<ListTunnelQuotaTimerResponse> ListTunnelQuotaTimerWithOptionsAsync(string nickname, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListTunnelQuotaTimer",
                Version = "2022-01-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/tunnel/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(nickname) + "/timers",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListTunnelQuotaTimerResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Displays the time-specific configuration of an exclusive resource group for Tunnel (referred to as Tunnel quota).</para>
        /// </summary>
        /// 
        /// <returns>
        /// ListTunnelQuotaTimerResponse
        /// </returns>
        public ListTunnelQuotaTimerResponse ListTunnelQuotaTimer(string nickname)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListTunnelQuotaTimerWithOptions(nickname, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Displays the time-specific configuration of an exclusive resource group for Tunnel (referred to as Tunnel quota).</para>
        /// </summary>
        /// 
        /// <returns>
        /// ListTunnelQuotaTimerResponse
        /// </returns>
        public async Task<ListTunnelQuotaTimerResponse> ListTunnelQuotaTimerAsync(string nickname)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListTunnelQuotaTimerWithOptionsAsync(nickname, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of all users under a tenant.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListUsersRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListUsersResponse
        /// </returns>
        public ListUsersResponse ListUsersWithOptions(ListUsersRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListUsers",
                Version = "2022-01-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/users",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListUsersResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of all users under a tenant.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListUsersRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListUsersResponse
        /// </returns>
        public async Task<ListUsersResponse> ListUsersWithOptionsAsync(ListUsersRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["pageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["pageSize"] = request.PageSize;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListUsers",
                Version = "2022-01-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/users",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListUsersResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of all users under a tenant.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListUsersRequest
        /// </param>
        /// 
        /// <returns>
        /// ListUsersResponse
        /// </returns>
        public ListUsersResponse ListUsers(ListUsersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListUsersWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a list of all users under a tenant.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListUsersRequest
        /// </param>
        /// 
        /// <returns>
        /// ListUsersResponse
        /// </returns>
        public async Task<ListUsersResponse> ListUsersAsync(ListUsersRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListUsersWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains information about the users who are assigned a project-level role.</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListUsersByRoleResponse
        /// </returns>
        public ListUsersByRoleResponse ListUsersByRoleWithOptions(string projectName, string roleName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListUsersByRole",
                Version = "2022-01-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/projects/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(projectName) + "/roles/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(roleName) + "/users",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListUsersByRoleResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains information about the users who are assigned a project-level role.</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListUsersByRoleResponse
        /// </returns>
        public async Task<ListUsersByRoleResponse> ListUsersByRoleWithOptionsAsync(string projectName, string roleName, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListUsersByRole",
                Version = "2022-01-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/projects/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(projectName) + "/roles/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(roleName) + "/users",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListUsersByRoleResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains information about the users who are assigned a project-level role.</para>
        /// </summary>
        /// 
        /// <returns>
        /// ListUsersByRoleResponse
        /// </returns>
        public ListUsersByRoleResponse ListUsersByRole(string projectName, string roleName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListUsersByRoleWithOptions(projectName, roleName, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Obtains information about the users who are assigned a project-level role.</para>
        /// </summary>
        /// 
        /// <returns>
        /// ListUsersByRoleResponse
        /// </returns>
        public async Task<ListUsersByRoleResponse> ListUsersByRoleAsync(string projectName, string roleName)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListUsersByRoleWithOptionsAsync(projectName, roleName, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about a specified level-1 quota group.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryQuotaRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryQuotaResponse
        /// </returns>
        public QueryQuotaResponse QueryQuotaWithOptions(string nickname, QueryQuotaRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AkProven))
            {
                query["AkProven"] = request.AkProven;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mock))
            {
                query["mock"] = request.Mock;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                query["region"] = request.Region;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["tenantId"] = request.TenantId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryQuota",
                Version = "2022-01-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/quotas/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(nickname) + "/query",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryQuotaResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about a specified level-1 quota group.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryQuotaRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryQuotaResponse
        /// </returns>
        public async Task<QueryQuotaResponse> QueryQuotaWithOptionsAsync(string nickname, QueryQuotaRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AkProven))
            {
                query["AkProven"] = request.AkProven;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Mock))
            {
                query["mock"] = request.Mock;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                query["region"] = request.Region;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["tenantId"] = request.TenantId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryQuota",
                Version = "2022-01-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/quotas/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(nickname) + "/query",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryQuotaResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about a specified level-1 quota group.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryQuotaRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryQuotaResponse
        /// </returns>
        public QueryQuotaResponse QueryQuota(string nickname, QueryQuotaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return QueryQuotaWithOptions(nickname, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the information about a specified level-1 quota group.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryQuotaRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryQuotaResponse
        /// </returns>
        public async Task<QueryQuotaResponse> QueryQuotaAsync(string nickname, QueryQuotaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await QueryQuotaWithOptionsAsync(nickname, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询tunnel资源使用信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryTunnelMetricRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryTunnelMetricResponse
        /// </returns>
        public QueryTunnelMetricResponse QueryTunnelMetricWithOptions(string metric, QueryTunnelMetricRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["endTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["startTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Strategy))
            {
                query["strategy"] = request.Strategy;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CodeList))
            {
                body["codeList"] = request.CodeList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupList))
            {
                body["groupList"] = request.GroupList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperationList))
            {
                body["operationList"] = request.OperationList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Project))
            {
                body["project"] = request.Project;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QuotaNickname))
            {
                body["quotaNickname"] = request.QuotaNickname;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TableList))
            {
                body["tableList"] = request.TableList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TopN))
            {
                body["topN"] = request.TopN;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryTunnelMetric",
                Version = "2022-01-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/observations/tunnel/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(metric),
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryTunnelMetricResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询tunnel资源使用信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryTunnelMetricRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryTunnelMetricResponse
        /// </returns>
        public async Task<QueryTunnelMetricResponse> QueryTunnelMetricWithOptionsAsync(string metric, QueryTunnelMetricRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["endTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["startTime"] = request.StartTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Strategy))
            {
                query["strategy"] = request.Strategy;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.CodeList))
            {
                body["codeList"] = request.CodeList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupList))
            {
                body["groupList"] = request.GroupList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperationList))
            {
                body["operationList"] = request.OperationList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Project))
            {
                body["project"] = request.Project;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QuotaNickname))
            {
                body["quotaNickname"] = request.QuotaNickname;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TableList))
            {
                body["tableList"] = request.TableList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TopN))
            {
                body["topN"] = request.TopN;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryTunnelMetric",
                Version = "2022-01-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/observations/tunnel/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(metric),
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryTunnelMetricResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询tunnel资源使用信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryTunnelMetricRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryTunnelMetricResponse
        /// </returns>
        public QueryTunnelMetricResponse QueryTunnelMetric(string metric, QueryTunnelMetricRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return QueryTunnelMetricWithOptions(metric, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询tunnel资源使用信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryTunnelMetricRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryTunnelMetricResponse
        /// </returns>
        public async Task<QueryTunnelMetricResponse> QueryTunnelMetricAsync(string metric, QueryTunnelMetricRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await QueryTunnelMetricWithOptionsAsync(metric, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询tunnel资源使用详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryTunnelMetricDetailRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryTunnelMetricDetailResponse
        /// </returns>
        public QueryTunnelMetricDetailResponse QueryTunnelMetricDetailWithOptions(string metric, QueryTunnelMetricDetailRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["endTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["startTime"] = request.StartTime;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AscOrder))
            {
                body["ascOrder"] = request.AscOrder;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupList))
            {
                body["groupList"] = request.GroupList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Limit))
            {
                body["limit"] = request.Limit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperationList))
            {
                body["operationList"] = request.OperationList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderColumn))
            {
                body["orderColumn"] = request.OrderColumn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Project))
            {
                body["project"] = request.Project;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QuotaNickname))
            {
                body["quotaNickname"] = request.QuotaNickname;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TableList))
            {
                body["tableList"] = request.TableList;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryTunnelMetricDetail",
                Version = "2022-01-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/observations/tunnel/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(metric) + "/detail",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryTunnelMetricDetailResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询tunnel资源使用详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryTunnelMetricDetailRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// QueryTunnelMetricDetailResponse
        /// </returns>
        public async Task<QueryTunnelMetricDetailResponse> QueryTunnelMetricDetailWithOptionsAsync(string metric, QueryTunnelMetricDetailRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EndTime))
            {
                query["endTime"] = request.EndTime;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.StartTime))
            {
                query["startTime"] = request.StartTime;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AscOrder))
            {
                body["ascOrder"] = request.AscOrder;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GroupList))
            {
                body["groupList"] = request.GroupList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Limit))
            {
                body["limit"] = request.Limit;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OperationList))
            {
                body["operationList"] = request.OperationList;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.OrderColumn))
            {
                body["orderColumn"] = request.OrderColumn;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Project))
            {
                body["project"] = request.Project;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QuotaNickname))
            {
                body["quotaNickname"] = request.QuotaNickname;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TableList))
            {
                body["tableList"] = request.TableList;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "QueryTunnelMetricDetail",
                Version = "2022-01-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/observations/tunnel/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(metric) + "/detail",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<QueryTunnelMetricDetailResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询tunnel资源使用详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryTunnelMetricDetailRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryTunnelMetricDetailResponse
        /// </returns>
        public QueryTunnelMetricDetailResponse QueryTunnelMetricDetail(string metric, QueryTunnelMetricDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return QueryTunnelMetricDetailWithOptions(metric, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询tunnel资源使用详情</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// QueryTunnelMetricDetailRequest
        /// </param>
        /// 
        /// <returns>
        /// QueryTunnelMetricDetailResponse
        /// </returns>
        public async Task<QueryTunnelMetricDetailResponse> QueryTunnelMetricDetailAsync(string metric, QueryTunnelMetricDetailRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await QueryTunnelMetricDetailWithOptionsAsync(metric, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>RetryMmsJob</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RetryMmsJobResponse
        /// </returns>
        public RetryMmsJobResponse RetryMmsJobWithOptions(string sourceId, string jobId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RetryMmsJob",
                Version = "2022-01-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/mms/datasources/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(sourceId) + "/jobs/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(jobId) + "/retry",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RetryMmsJobResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>RetryMmsJob</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RetryMmsJobResponse
        /// </returns>
        public async Task<RetryMmsJobResponse> RetryMmsJobWithOptionsAsync(string sourceId, string jobId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RetryMmsJob",
                Version = "2022-01-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/mms/datasources/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(sourceId) + "/jobs/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(jobId) + "/retry",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RetryMmsJobResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>RetryMmsJob</para>
        /// </summary>
        /// 
        /// <returns>
        /// RetryMmsJobResponse
        /// </returns>
        public RetryMmsJobResponse RetryMmsJob(string sourceId, string jobId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return RetryMmsJobWithOptions(sourceId, jobId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>RetryMmsJob</para>
        /// </summary>
        /// 
        /// <returns>
        /// RetryMmsJobResponse
        /// </returns>
        public async Task<RetryMmsJobResponse> RetryMmsJobAsync(string sourceId, string jobId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await RetryMmsJobWithOptionsAsync(sourceId, jobId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>StartMmsJob</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// StartMmsJobResponse
        /// </returns>
        public StartMmsJobResponse StartMmsJobWithOptions(string sourceId, string jobId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StartMmsJob",
                Version = "2022-01-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/mms/datasources/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(sourceId) + "/jobs/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(jobId) + "/start",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<StartMmsJobResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>StartMmsJob</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// StartMmsJobResponse
        /// </returns>
        public async Task<StartMmsJobResponse> StartMmsJobWithOptionsAsync(string sourceId, string jobId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StartMmsJob",
                Version = "2022-01-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/mms/datasources/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(sourceId) + "/jobs/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(jobId) + "/start",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<StartMmsJobResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>StartMmsJob</para>
        /// </summary>
        /// 
        /// <returns>
        /// StartMmsJobResponse
        /// </returns>
        public StartMmsJobResponse StartMmsJob(string sourceId, string jobId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return StartMmsJobWithOptions(sourceId, jobId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>StartMmsJob</para>
        /// </summary>
        /// 
        /// <returns>
        /// StartMmsJobResponse
        /// </returns>
        public async Task<StartMmsJobResponse> StartMmsJobAsync(string sourceId, string jobId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await StartMmsJobWithOptionsAsync(sourceId, jobId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>StopMmsJob</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// StopMmsJobResponse
        /// </returns>
        public StopMmsJobResponse StopMmsJobWithOptions(string sourceId, string jobId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StopMmsJob",
                Version = "2022-01-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/mms/datasources/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(sourceId) + "/jobs/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(jobId) + "/stop",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<StopMmsJobResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>StopMmsJob</para>
        /// </summary>
        /// 
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// StopMmsJobResponse
        /// </returns>
        public async Task<StopMmsJobResponse> StopMmsJobWithOptionsAsync(string sourceId, string jobId, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "StopMmsJob",
                Version = "2022-01-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/mms/datasources/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(sourceId) + "/jobs/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(jobId) + "/stop",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<StopMmsJobResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>StopMmsJob</para>
        /// </summary>
        /// 
        /// <returns>
        /// StopMmsJobResponse
        /// </returns>
        public StopMmsJobResponse StopMmsJob(string sourceId, string jobId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return StopMmsJobWithOptions(sourceId, jobId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>StopMmsJob</para>
        /// </summary>
        /// 
        /// <returns>
        /// StopMmsJobResponse
        /// </returns>
        public async Task<StopMmsJobResponse> StopMmsJobAsync(string sourceId, string jobId)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await StopMmsJobWithOptionsAsync(sourceId, jobId, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Update the ComputeQuotaPlan.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Please ensure that before using this interface, you have fully understood the &lt;props=&quot;china&quot;&gt;<a href="https://help.aliyun.com/zh/maxcompute/product-overview/computing-pricing-1">Pricing and Charges</a>
        /// &lt;props=&quot;intl&quot;&gt;<a href="https://www.alibabacloud.com/help/maxcompute/product-overview/computing-pricing-1">Pricing and Charges</a> of MaxCompute Elastic Reserved CU.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateComputeQuotaPlanRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateComputeQuotaPlanResponse
        /// </returns>
        public UpdateComputeQuotaPlanResponse UpdateComputeQuotaPlanWithOptions(string nickname, UpdateComputeQuotaPlanRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Quota))
            {
                body["quota"] = request.Quota;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateComputeQuotaPlan",
                Version = "2022-01-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/quotas/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(nickname) + "/computeQuotaPlan",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateComputeQuotaPlanResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Update the ComputeQuotaPlan.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Please ensure that before using this interface, you have fully understood the &lt;props=&quot;china&quot;&gt;<a href="https://help.aliyun.com/zh/maxcompute/product-overview/computing-pricing-1">Pricing and Charges</a>
        /// &lt;props=&quot;intl&quot;&gt;<a href="https://www.alibabacloud.com/help/maxcompute/product-overview/computing-pricing-1">Pricing and Charges</a> of MaxCompute Elastic Reserved CU.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateComputeQuotaPlanRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateComputeQuotaPlanResponse
        /// </returns>
        public async Task<UpdateComputeQuotaPlanResponse> UpdateComputeQuotaPlanWithOptionsAsync(string nickname, UpdateComputeQuotaPlanRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Quota))
            {
                body["quota"] = request.Quota;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateComputeQuotaPlan",
                Version = "2022-01-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/quotas/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(nickname) + "/computeQuotaPlan",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateComputeQuotaPlanResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Update the ComputeQuotaPlan.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Please ensure that before using this interface, you have fully understood the &lt;props=&quot;china&quot;&gt;<a href="https://help.aliyun.com/zh/maxcompute/product-overview/computing-pricing-1">Pricing and Charges</a>
        /// &lt;props=&quot;intl&quot;&gt;<a href="https://www.alibabacloud.com/help/maxcompute/product-overview/computing-pricing-1">Pricing and Charges</a> of MaxCompute Elastic Reserved CU.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateComputeQuotaPlanRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateComputeQuotaPlanResponse
        /// </returns>
        public UpdateComputeQuotaPlanResponse UpdateComputeQuotaPlan(string nickname, UpdateComputeQuotaPlanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateComputeQuotaPlanWithOptions(nickname, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Update the ComputeQuotaPlan.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Please ensure that before using this interface, you have fully understood the &lt;props=&quot;china&quot;&gt;<a href="https://help.aliyun.com/zh/maxcompute/product-overview/computing-pricing-1">Pricing and Charges</a>
        /// &lt;props=&quot;intl&quot;&gt;<a href="https://www.alibabacloud.com/help/maxcompute/product-overview/computing-pricing-1">Pricing and Charges</a> of MaxCompute Elastic Reserved CU.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateComputeQuotaPlanRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateComputeQuotaPlanResponse
        /// </returns>
        public async Task<UpdateComputeQuotaPlanResponse> UpdateComputeQuotaPlanAsync(string nickname, UpdateComputeQuotaPlanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateComputeQuotaPlanWithOptionsAsync(nickname, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Update the time-based plan for computing quota.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Please ensure that before using this interface, you have fully understood the&lt;props=&quot;china&quot;&gt;<a href="https://help.aliyun.com/zh/maxcompute/product-overview/computing-pricing-1">Pricing and Billing</a>
        /// &lt;props=&quot;intl&quot;&gt;<a href="https://www.alibabacloud.com/help/maxcompute/product-overview/computing-pricing-1">Pricing and Billing</a> of MaxCompute Elastic Reserved CU.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateComputeQuotaScheduleRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateComputeQuotaScheduleResponse
        /// </returns>
        public UpdateComputeQuotaScheduleResponse UpdateComputeQuotaScheduleWithOptions(string nickname, UpdateComputeQuotaScheduleRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScheduleTimezone))
            {
                query["scheduleTimezone"] = request.ScheduleTimezone;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToArray(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateComputeQuotaSchedule",
                Version = "2022-01-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/quotas/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(nickname) + "/computeQuotaSchedule",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateComputeQuotaScheduleResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Update the time-based plan for computing quota.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Please ensure that before using this interface, you have fully understood the&lt;props=&quot;china&quot;&gt;<a href="https://help.aliyun.com/zh/maxcompute/product-overview/computing-pricing-1">Pricing and Billing</a>
        /// &lt;props=&quot;intl&quot;&gt;<a href="https://www.alibabacloud.com/help/maxcompute/product-overview/computing-pricing-1">Pricing and Billing</a> of MaxCompute Elastic Reserved CU.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateComputeQuotaScheduleRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateComputeQuotaScheduleResponse
        /// </returns>
        public async Task<UpdateComputeQuotaScheduleResponse> UpdateComputeQuotaScheduleWithOptionsAsync(string nickname, UpdateComputeQuotaScheduleRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ScheduleTimezone))
            {
                query["scheduleTimezone"] = request.ScheduleTimezone;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToArray(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateComputeQuotaSchedule",
                Version = "2022-01-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/quotas/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(nickname) + "/computeQuotaSchedule",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateComputeQuotaScheduleResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Update the time-based plan for computing quota.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Please ensure that before using this interface, you have fully understood the&lt;props=&quot;china&quot;&gt;<a href="https://help.aliyun.com/zh/maxcompute/product-overview/computing-pricing-1">Pricing and Billing</a>
        /// &lt;props=&quot;intl&quot;&gt;<a href="https://www.alibabacloud.com/help/maxcompute/product-overview/computing-pricing-1">Pricing and Billing</a> of MaxCompute Elastic Reserved CU.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateComputeQuotaScheduleRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateComputeQuotaScheduleResponse
        /// </returns>
        public UpdateComputeQuotaScheduleResponse UpdateComputeQuotaSchedule(string nickname, UpdateComputeQuotaScheduleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateComputeQuotaScheduleWithOptions(nickname, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Update the time-based plan for computing quota.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Please ensure that before using this interface, you have fully understood the&lt;props=&quot;china&quot;&gt;<a href="https://help.aliyun.com/zh/maxcompute/product-overview/computing-pricing-1">Pricing and Billing</a>
        /// &lt;props=&quot;intl&quot;&gt;<a href="https://www.alibabacloud.com/help/maxcompute/product-overview/computing-pricing-1">Pricing and Billing</a> of MaxCompute Elastic Reserved CU.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateComputeQuotaScheduleRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateComputeQuotaScheduleResponse
        /// </returns>
        public async Task<UpdateComputeQuotaScheduleResponse> UpdateComputeQuotaScheduleAsync(string nickname, UpdateComputeQuotaScheduleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateComputeQuotaScheduleWithOptionsAsync(nickname, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Update the basic configuration of the calculation quota, including adding or deleting the sub quota, modifying the basic properties of the secondary quota, and the CU configuration of the effective quota plan.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateComputeSubQuotaRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateComputeSubQuotaResponse
        /// </returns>
        public UpdateComputeSubQuotaResponse UpdateComputeSubQuotaWithOptions(string nickname, UpdateComputeSubQuotaRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubQuotaInfoList))
            {
                body["subQuotaInfoList"] = request.SubQuotaInfoList;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateComputeSubQuota",
                Version = "2022-01-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/quotas/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(nickname) + "/computeSubQuota",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateComputeSubQuotaResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Update the basic configuration of the calculation quota, including adding or deleting the sub quota, modifying the basic properties of the secondary quota, and the CU configuration of the effective quota plan.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateComputeSubQuotaRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateComputeSubQuotaResponse
        /// </returns>
        public async Task<UpdateComputeSubQuotaResponse> UpdateComputeSubQuotaWithOptionsAsync(string nickname, UpdateComputeSubQuotaRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SubQuotaInfoList))
            {
                body["subQuotaInfoList"] = request.SubQuotaInfoList;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateComputeSubQuota",
                Version = "2022-01-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/quotas/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(nickname) + "/computeSubQuota",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateComputeSubQuotaResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Update the basic configuration of the calculation quota, including adding or deleting the sub quota, modifying the basic properties of the secondary quota, and the CU configuration of the effective quota plan.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateComputeSubQuotaRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateComputeSubQuotaResponse
        /// </returns>
        public UpdateComputeSubQuotaResponse UpdateComputeSubQuota(string nickname, UpdateComputeSubQuotaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateComputeSubQuotaWithOptions(nickname, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Update the basic configuration of the calculation quota, including adding or deleting the sub quota, modifying the basic properties of the secondary quota, and the CU configuration of the effective quota plan.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateComputeSubQuotaRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateComputeSubQuotaResponse
        /// </returns>
        public async Task<UpdateComputeSubQuotaResponse> UpdateComputeSubQuotaAsync(string nickname, UpdateComputeSubQuotaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateComputeSubQuotaWithOptionsAsync(nickname, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新数据源配置、名称，启/停数据源实例</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateMmsDataSourceRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateMmsDataSourceResponse
        /// </returns>
        public UpdateMmsDataSourceResponse UpdateMmsDataSourceWithOptions(string sourceId, UpdateMmsDataSourceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Action))
            {
                body["action"] = request.Action;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Config))
            {
                body["config"] = request.Config;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Test))
            {
                body["test"] = request.Test;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateMmsDataSource",
                Version = "2022-01-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/mms/datasources/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(sourceId),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateMmsDataSourceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新数据源配置、名称，启/停数据源实例</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateMmsDataSourceRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateMmsDataSourceResponse
        /// </returns>
        public async Task<UpdateMmsDataSourceResponse> UpdateMmsDataSourceWithOptionsAsync(string sourceId, UpdateMmsDataSourceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Action))
            {
                body["action"] = request.Action;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Config))
            {
                body["config"] = request.Config;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Test))
            {
                body["test"] = request.Test;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateMmsDataSource",
                Version = "2022-01-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/mms/datasources/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(sourceId),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateMmsDataSourceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新数据源配置、名称，启/停数据源实例</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateMmsDataSourceRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateMmsDataSourceResponse
        /// </returns>
        public UpdateMmsDataSourceResponse UpdateMmsDataSource(string sourceId, UpdateMmsDataSourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateMmsDataSourceWithOptions(sourceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新数据源配置、名称，启/停数据源实例</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateMmsDataSourceRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateMmsDataSourceResponse
        /// </returns>
        public async Task<UpdateMmsDataSourceResponse> UpdateMmsDataSourceAsync(string sourceId, UpdateMmsDataSourceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateMmsDataSourceWithOptionsAsync(sourceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the objects in a package and projects in which the package can be installed.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdatePackageRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdatePackageResponse
        /// </returns>
        public UpdatePackageResponse UpdatePackageWithOptions(string projectName, string packageName, UpdatePackageRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdatePackage",
                Version = "2022-01-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/projects/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(projectName) + "/packages/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(packageName),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdatePackageResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the objects in a package and projects in which the package can be installed.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdatePackageRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdatePackageResponse
        /// </returns>
        public async Task<UpdatePackageResponse> UpdatePackageWithOptionsAsync(string projectName, string packageName, UpdatePackageRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdatePackage",
                Version = "2022-01-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/projects/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(projectName) + "/packages/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(packageName),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdatePackageResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the objects in a package and projects in which the package can be installed.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdatePackageRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdatePackageResponse
        /// </returns>
        public UpdatePackageResponse UpdatePackage(string projectName, string packageName, UpdatePackageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdatePackageWithOptions(projectName, packageName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the objects in a package and projects in which the package can be installed.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdatePackageRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdatePackageResponse
        /// </returns>
        public async Task<UpdatePackageResponse> UpdatePackageAsync(string projectName, string packageName, UpdatePackageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdatePackageWithOptionsAsync(projectName, packageName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Update Project Basic Information</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateProjectBasicMetaRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateProjectBasicMetaResponse
        /// </returns>
        public UpdateProjectBasicMetaResponse UpdateProjectBasicMetaWithOptions(string projectName, UpdateProjectBasicMetaRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Comment))
            {
                body["comment"] = request.Comment;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Properties))
            {
                body["properties"] = request.Properties;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateProjectBasicMeta",
                Version = "2022-01-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/projects/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(projectName) + "/meta",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateProjectBasicMetaResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Update Project Basic Information</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateProjectBasicMetaRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateProjectBasicMetaResponse
        /// </returns>
        public async Task<UpdateProjectBasicMetaResponse> UpdateProjectBasicMetaWithOptionsAsync(string projectName, UpdateProjectBasicMetaRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Comment))
            {
                body["comment"] = request.Comment;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Properties))
            {
                body["properties"] = request.Properties;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateProjectBasicMeta",
                Version = "2022-01-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/projects/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(projectName) + "/meta",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateProjectBasicMetaResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Update Project Basic Information</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateProjectBasicMetaRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateProjectBasicMetaResponse
        /// </returns>
        public UpdateProjectBasicMetaResponse UpdateProjectBasicMeta(string projectName, UpdateProjectBasicMetaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateProjectBasicMetaWithOptions(projectName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Update Project Basic Information</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateProjectBasicMetaRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateProjectBasicMetaResponse
        /// </returns>
        public async Task<UpdateProjectBasicMetaResponse> UpdateProjectBasicMetaAsync(string projectName, UpdateProjectBasicMetaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateProjectBasicMetaWithOptionsAsync(projectName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modify Default Project Compute Quota</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateProjectDefaultQuotaRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateProjectDefaultQuotaResponse
        /// </returns>
        public UpdateProjectDefaultQuotaResponse UpdateProjectDefaultQuotaWithOptions(string projectName, UpdateProjectDefaultQuotaRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Quota))
            {
                body["quota"] = request.Quota;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateProjectDefaultQuota",
                Version = "2022-01-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/projects/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(projectName) + "/quota",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateProjectDefaultQuotaResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modify Default Project Compute Quota</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateProjectDefaultQuotaRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateProjectDefaultQuotaResponse
        /// </returns>
        public async Task<UpdateProjectDefaultQuotaResponse> UpdateProjectDefaultQuotaWithOptionsAsync(string projectName, UpdateProjectDefaultQuotaRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Quota))
            {
                body["quota"] = request.Quota;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateProjectDefaultQuota",
                Version = "2022-01-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/projects/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(projectName) + "/quota",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateProjectDefaultQuotaResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modify Default Project Compute Quota</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateProjectDefaultQuotaRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateProjectDefaultQuotaResponse
        /// </returns>
        public UpdateProjectDefaultQuotaResponse UpdateProjectDefaultQuota(string projectName, UpdateProjectDefaultQuotaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateProjectDefaultQuotaWithOptions(projectName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modify Default Project Compute Quota</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateProjectDefaultQuotaRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateProjectDefaultQuotaResponse
        /// </returns>
        public async Task<UpdateProjectDefaultQuotaResponse> UpdateProjectDefaultQuotaAsync(string projectName, UpdateProjectDefaultQuotaRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateProjectDefaultQuotaWithOptionsAsync(projectName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the IP address whitelist of a MaxCompute project.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateProjectIpWhiteListRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateProjectIpWhiteListResponse
        /// </returns>
        public UpdateProjectIpWhiteListResponse UpdateProjectIpWhiteListWithOptions(string projectName, UpdateProjectIpWhiteListRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateProjectIpWhiteList",
                Version = "2022-01-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/projects/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(projectName) + "/ipWhiteList",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateProjectIpWhiteListResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the IP address whitelist of a MaxCompute project.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateProjectIpWhiteListRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateProjectIpWhiteListResponse
        /// </returns>
        public async Task<UpdateProjectIpWhiteListResponse> UpdateProjectIpWhiteListWithOptionsAsync(string projectName, UpdateProjectIpWhiteListRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateProjectIpWhiteList",
                Version = "2022-01-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/projects/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(projectName) + "/ipWhiteList",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateProjectIpWhiteListResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the IP address whitelist of a MaxCompute project.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateProjectIpWhiteListRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateProjectIpWhiteListResponse
        /// </returns>
        public UpdateProjectIpWhiteListResponse UpdateProjectIpWhiteList(string projectName, UpdateProjectIpWhiteListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateProjectIpWhiteListWithOptions(projectName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Modifies the IP address whitelist of a MaxCompute project.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateProjectIpWhiteListRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateProjectIpWhiteListResponse
        /// </returns>
        public async Task<UpdateProjectIpWhiteListResponse> UpdateProjectIpWhiteListAsync(string projectName, UpdateProjectIpWhiteListRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateProjectIpWhiteListWithOptionsAsync(projectName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates a quota plan.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateQuotaPlanRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateQuotaPlanResponse
        /// </returns>
        public UpdateQuotaPlanResponse UpdateQuotaPlanWithOptions(string nickname, string planName, UpdateQuotaPlanRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                query["region"] = request.Region;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["tenantId"] = request.TenantId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateQuotaPlan",
                Version = "2022-01-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/quotas/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(nickname) + "/plans/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(planName),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateQuotaPlanResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates a quota plan.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateQuotaPlanRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateQuotaPlanResponse
        /// </returns>
        public async Task<UpdateQuotaPlanResponse> UpdateQuotaPlanWithOptionsAsync(string nickname, string planName, UpdateQuotaPlanRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                query["region"] = request.Region;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["tenantId"] = request.TenantId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateQuotaPlan",
                Version = "2022-01-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/quotas/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(nickname) + "/plans/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(planName),
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateQuotaPlanResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates a quota plan.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateQuotaPlanRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateQuotaPlanResponse
        /// </returns>
        public UpdateQuotaPlanResponse UpdateQuotaPlan(string nickname, string planName, UpdateQuotaPlanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateQuotaPlanWithOptions(nickname, planName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates a quota plan.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateQuotaPlanRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateQuotaPlanResponse
        /// </returns>
        public async Task<UpdateQuotaPlanResponse> UpdateQuotaPlanAsync(string nickname, string planName, UpdateQuotaPlanRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateQuotaPlanWithOptionsAsync(nickname, planName, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the scheduling plan for a quota plan.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateQuotaScheduleRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateQuotaScheduleResponse
        /// </returns>
        public UpdateQuotaScheduleResponse UpdateQuotaScheduleWithOptions(string nickname, UpdateQuotaScheduleRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                query["region"] = request.Region;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["tenantId"] = request.TenantId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateQuotaSchedule",
                Version = "2022-01-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/quotas/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(nickname) + "/schedule",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateQuotaScheduleResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the scheduling plan for a quota plan.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateQuotaScheduleRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateQuotaScheduleResponse
        /// </returns>
        public async Task<UpdateQuotaScheduleResponse> UpdateQuotaScheduleWithOptionsAsync(string nickname, UpdateQuotaScheduleRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Region))
            {
                query["region"] = request.Region;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TenantId))
            {
                query["tenantId"] = request.TenantId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = request.Body,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateQuotaSchedule",
                Version = "2022-01-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/quotas/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(nickname) + "/schedule",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateQuotaScheduleResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the scheduling plan for a quota plan.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateQuotaScheduleRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateQuotaScheduleResponse
        /// </returns>
        public UpdateQuotaScheduleResponse UpdateQuotaSchedule(string nickname, UpdateQuotaScheduleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateQuotaScheduleWithOptions(nickname, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the scheduling plan for a quota plan.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateQuotaScheduleRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateQuotaScheduleResponse
        /// </returns>
        public async Task<UpdateQuotaScheduleResponse> UpdateQuotaScheduleAsync(string nickname, UpdateQuotaScheduleRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateQuotaScheduleWithOptionsAsync(nickname, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the time-specific configuration of an exclusive resource group for Tunnel (referred to as Tunnel quota).</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you call this operation, make sure that you are familiar with the <a href="https://www.alibabacloud.com/help/maxcompute/product-overview/data-transfer-fees-hourly-billing">billing and prices</a> of Tunnel quotas and elastically reserved computing resources.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateTunnelQuotaTimerRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateTunnelQuotaTimerResponse
        /// </returns>
        public UpdateTunnelQuotaTimerResponse UpdateTunnelQuotaTimerWithOptions(string nickname, UpdateTunnelQuotaTimerRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Timezone))
            {
                query["timezone"] = request.Timezone;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToArray(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateTunnelQuotaTimer",
                Version = "2022-01-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/tunnel/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(nickname) + "/timers",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateTunnelQuotaTimerResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the time-specific configuration of an exclusive resource group for Tunnel (referred to as Tunnel quota).</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you call this operation, make sure that you are familiar with the <a href="https://www.alibabacloud.com/help/maxcompute/product-overview/data-transfer-fees-hourly-billing">billing and prices</a> of Tunnel quotas and elastically reserved computing resources.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateTunnelQuotaTimerRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateTunnelQuotaTimerResponse
        /// </returns>
        public async Task<UpdateTunnelQuotaTimerResponse> UpdateTunnelQuotaTimerWithOptionsAsync(string nickname, UpdateTunnelQuotaTimerRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Timezone))
            {
                query["timezone"] = request.Timezone;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.TeaUtil.Common.ToArray(request.Body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateTunnelQuotaTimer",
                Version = "2022-01-04",
                Protocol = "HTTPS",
                Pathname = "/api/v1/tunnel/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(nickname) + "/timers",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateTunnelQuotaTimerResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the time-specific configuration of an exclusive resource group for Tunnel (referred to as Tunnel quota).</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you call this operation, make sure that you are familiar with the <a href="https://www.alibabacloud.com/help/maxcompute/product-overview/data-transfer-fees-hourly-billing">billing and prices</a> of Tunnel quotas and elastically reserved computing resources.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateTunnelQuotaTimerRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateTunnelQuotaTimerResponse
        /// </returns>
        public UpdateTunnelQuotaTimerResponse UpdateTunnelQuotaTimer(string nickname, UpdateTunnelQuotaTimerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateTunnelQuotaTimerWithOptions(nickname, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the time-specific configuration of an exclusive resource group for Tunnel (referred to as Tunnel quota).</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you call this operation, make sure that you are familiar with the <a href="https://www.alibabacloud.com/help/maxcompute/product-overview/data-transfer-fees-hourly-billing">billing and prices</a> of Tunnel quotas and elastically reserved computing resources.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateTunnelQuotaTimerRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateTunnelQuotaTimerResponse
        /// </returns>
        public async Task<UpdateTunnelQuotaTimerResponse> UpdateTunnelQuotaTimerAsync(string nickname, UpdateTunnelQuotaTimerRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateTunnelQuotaTimerWithOptionsAsync(nickname, request, headers, runtime);
        }

    }
}
