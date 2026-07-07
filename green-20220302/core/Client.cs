// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Green20220302.Models;

namespace AlibabaCloud.SDK.Green20220302
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "regional";
            this._endpointMap = new Dictionary<string, string>
            {
                {"ap-northeast-1", "green.ap-southeast-1.aliyuncs.com"},
                {"ap-south-1", "green.ap-southeast-1.aliyuncs.com"},
                {"ap-southeast-2", "green.ap-southeast-1.aliyuncs.com"},
                {"ap-southeast-3", "green.ap-southeast-1.aliyuncs.com"},
                {"ap-southeast-5", "green.ap-southeast-1.aliyuncs.com"},
                {"cn-chengdu", "green.aliyuncs.com"},
                {"cn-hongkong", "green.aliyuncs.com"},
                {"cn-huhehaote", "green.aliyuncs.com"},
                {"cn-qingdao", "green.aliyuncs.com"},
                {"cn-zhangjiakou", "green.aliyuncs.com"},
                {"eu-central-1", "green.ap-southeast-1.aliyuncs.com"},
                {"eu-west-1", "green.ap-southeast-1.aliyuncs.com"},
                {"me-east-1", "green.ap-southeast-1.aliyuncs.com"},
                {"us-east-1", "green.ap-southeast-1.aliyuncs.com"},
                {"cn-hangzhou-finance", "green.aliyuncs.com"},
                {"cn-shenzhen-finance-1", "green.aliyuncs.com"},
                {"cn-shanghai-finance-1", "green.aliyuncs.com"},
                {"cn-north-2-gov-1", "green.aliyuncs.com"},
                {"cn-shenzhen", "green-cip.cn-shenzhen.aliyuncs.com"},
                {"cn-shanghai", "green-cip.cn-shanghai.aliyuncs.com"},
                {"cn-hangzhou", "green-cip.cn-hangzhou.aliyuncs.com"},
                {"cn-beijing", "green-cip.cn-beijing.aliyuncs.com"},
                {"ap-southeast-1", "green-cip.ap-southeast-1.aliyuncs.com"},
            };
            CheckConfig(config);
            this._endpoint = GetEndpoint("green", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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
        /// <para>Document review results</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeFileModerationResultRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeFileModerationResultResponse
        /// </returns>
        public DescribeFileModerationResultResponse DescribeFileModerationResultWithOptions(DescribeFileModerationResultRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Service))
            {
                body["Service"] = request.Service;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceParameters))
            {
                body["ServiceParameters"] = request.ServiceParameters;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeFileModerationResult",
                Version = "2022-03-02",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeFileModerationResultResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Document review results</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeFileModerationResultRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeFileModerationResultResponse
        /// </returns>
        public async Task<DescribeFileModerationResultResponse> DescribeFileModerationResultWithOptionsAsync(DescribeFileModerationResultRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Service))
            {
                body["Service"] = request.Service;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceParameters))
            {
                body["ServiceParameters"] = request.ServiceParameters;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeFileModerationResult",
                Version = "2022-03-02",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeFileModerationResultResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Document review results</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeFileModerationResultRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeFileModerationResultResponse
        /// </returns>
        public DescribeFileModerationResultResponse DescribeFileModerationResult(DescribeFileModerationResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeFileModerationResultWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Document review results</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeFileModerationResultRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeFileModerationResultResponse
        /// </returns>
        public async Task<DescribeFileModerationResultResponse> DescribeFileModerationResultAsync(DescribeFileModerationResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeFileModerationResultWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the results of an Image Moderation Pro task.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>Billing information: This operation is not billed.</description></item>
        /// <item><description>QPS limit: This operation is limited to 100 queries per second (QPS) for each user. If you exceed this limit, your API calls are throttled, which may affect your business. We recommend that you call this operation at a reasonable rate.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeImageModerationResultRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeImageModerationResultResponse
        /// </returns>
        public DescribeImageModerationResultResponse DescribeImageModerationResultWithOptions(DescribeImageModerationResultRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReqId))
            {
                query["ReqId"] = request.ReqId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeImageModerationResult",
                Version = "2022-03-02",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeImageModerationResultResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the results of an Image Moderation Pro task.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>Billing information: This operation is not billed.</description></item>
        /// <item><description>QPS limit: This operation is limited to 100 queries per second (QPS) for each user. If you exceed this limit, your API calls are throttled, which may affect your business. We recommend that you call this operation at a reasonable rate.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeImageModerationResultRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeImageModerationResultResponse
        /// </returns>
        public async Task<DescribeImageModerationResultResponse> DescribeImageModerationResultWithOptionsAsync(DescribeImageModerationResultRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReqId))
            {
                query["ReqId"] = request.ReqId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeImageModerationResult",
                Version = "2022-03-02",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeImageModerationResultResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the results of an Image Moderation Pro task.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>Billing information: This operation is not billed.</description></item>
        /// <item><description>QPS limit: This operation is limited to 100 queries per second (QPS) for each user. If you exceed this limit, your API calls are throttled, which may affect your business. We recommend that you call this operation at a reasonable rate.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeImageModerationResultRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeImageModerationResultResponse
        /// </returns>
        public DescribeImageModerationResultResponse DescribeImageModerationResult(DescribeImageModerationResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeImageModerationResultWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the results of an Image Moderation Pro task.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>Billing information: This operation is not billed.</description></item>
        /// <item><description>QPS limit: This operation is limited to 100 queries per second (QPS) for each user. If you exceed this limit, your API calls are throttled, which may affect your business. We recommend that you call this operation at a reasonable rate.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeImageModerationResultRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeImageModerationResultResponse
        /// </returns>
        public async Task<DescribeImageModerationResultResponse> DescribeImageModerationResultAsync(DescribeImageModerationResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeImageModerationResultWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>The enhanced image moderation auxiliary information API operation retrieves additional auxiliary information detected by the enhanced image moderation API operation, including OCR results and custom image library hit information.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This API operation must be used with the enhanced image moderation API. After you call the enhanced image moderation API operation, you can call this API operation to obtain additional detection information. This API operation is free of charge.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeImageResultExtRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeImageResultExtResponse
        /// </returns>
        public DescribeImageResultExtResponse DescribeImageResultExtWithOptions(DescribeImageResultExtRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InfoType))
            {
                body["InfoType"] = request.InfoType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReqId))
            {
                body["ReqId"] = request.ReqId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeImageResultExt",
                Version = "2022-03-02",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeImageResultExtResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>The enhanced image moderation auxiliary information API operation retrieves additional auxiliary information detected by the enhanced image moderation API operation, including OCR results and custom image library hit information.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This API operation must be used with the enhanced image moderation API. After you call the enhanced image moderation API operation, you can call this API operation to obtain additional detection information. This API operation is free of charge.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeImageResultExtRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeImageResultExtResponse
        /// </returns>
        public async Task<DescribeImageResultExtResponse> DescribeImageResultExtWithOptionsAsync(DescribeImageResultExtRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.InfoType))
            {
                body["InfoType"] = request.InfoType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReqId))
            {
                body["ReqId"] = request.ReqId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeImageResultExt",
                Version = "2022-03-02",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeImageResultExtResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>The enhanced image moderation auxiliary information API operation retrieves additional auxiliary information detected by the enhanced image moderation API operation, including OCR results and custom image library hit information.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This API operation must be used with the enhanced image moderation API. After you call the enhanced image moderation API operation, you can call this API operation to obtain additional detection information. This API operation is free of charge.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeImageResultExtRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeImageResultExtResponse
        /// </returns>
        public DescribeImageResultExtResponse DescribeImageResultExt(DescribeImageResultExtRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeImageResultExtWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>The enhanced image moderation auxiliary information API operation retrieves additional auxiliary information detected by the enhanced image moderation API operation, including OCR results and custom image library hit information.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This API operation must be used with the enhanced image moderation API. After you call the enhanced image moderation API operation, you can call this API operation to obtain additional detection information. This API operation is free of charge.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeImageResultExtRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeImageResultExtResponse
        /// </returns>
        public async Task<DescribeImageResultExtResponse> DescribeImageResultExtAsync(DescribeImageResultExtRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeImageResultExtWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Query the results of an asynchronous multimodal moderation task.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>Billing information: This API call is free.</description></item>
        /// <item><description>Query timeout: Wait 30 seconds after you submit an asynchronous moderation task before querying the result. Do not wait longer than 24 hours, or the result will be automatically deleted.</description></item>
        /// <item><description>This API has a per-user rate limiting limit of 10 requests per second. Exceeding this limit triggers rate limiting, which may affect your service. Call the API responsibly.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeMultimodalModerationResultRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeMultimodalModerationResultResponse
        /// </returns>
        public DescribeMultimodalModerationResultResponse DescribeMultimodalModerationResultWithOptions(DescribeMultimodalModerationResultRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReqId))
            {
                query["ReqId"] = request.ReqId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeMultimodalModerationResult",
                Version = "2022-03-02",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeMultimodalModerationResultResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Query the results of an asynchronous multimodal moderation task.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>Billing information: This API call is free.</description></item>
        /// <item><description>Query timeout: Wait 30 seconds after you submit an asynchronous moderation task before querying the result. Do not wait longer than 24 hours, or the result will be automatically deleted.</description></item>
        /// <item><description>This API has a per-user rate limiting limit of 10 requests per second. Exceeding this limit triggers rate limiting, which may affect your service. Call the API responsibly.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeMultimodalModerationResultRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeMultimodalModerationResultResponse
        /// </returns>
        public async Task<DescribeMultimodalModerationResultResponse> DescribeMultimodalModerationResultWithOptionsAsync(DescribeMultimodalModerationResultRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReqId))
            {
                query["ReqId"] = request.ReqId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeMultimodalModerationResult",
                Version = "2022-03-02",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeMultimodalModerationResultResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Query the results of an asynchronous multimodal moderation task.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>Billing information: This API call is free.</description></item>
        /// <item><description>Query timeout: Wait 30 seconds after you submit an asynchronous moderation task before querying the result. Do not wait longer than 24 hours, or the result will be automatically deleted.</description></item>
        /// <item><description>This API has a per-user rate limiting limit of 10 requests per second. Exceeding this limit triggers rate limiting, which may affect your service. Call the API responsibly.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeMultimodalModerationResultRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeMultimodalModerationResultResponse
        /// </returns>
        public DescribeMultimodalModerationResultResponse DescribeMultimodalModerationResult(DescribeMultimodalModerationResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeMultimodalModerationResultWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Query the results of an asynchronous multimodal moderation task.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>Billing information: This API call is free.</description></item>
        /// <item><description>Query timeout: Wait 30 seconds after you submit an asynchronous moderation task before querying the result. Do not wait longer than 24 hours, or the result will be automatically deleted.</description></item>
        /// <item><description>This API has a per-user rate limiting limit of 10 requests per second. Exceeding this limit triggers rate limiting, which may affect your service. Call the API responsibly.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeMultimodalModerationResultRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeMultimodalModerationResultResponse
        /// </returns>
        public async Task<DescribeMultimodalModerationResultResponse> DescribeMultimodalModerationResultAsync(DescribeMultimodalModerationResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeMultimodalModerationResultWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves an upload token.</para>
        /// </summary>
        /// 
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeUploadTokenResponse
        /// </returns>
        public DescribeUploadTokenResponse DescribeUploadTokenWithOptions(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeUploadToken",
                Version = "2022-03-02",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeUploadTokenResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves an upload token.</para>
        /// </summary>
        /// 
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeUploadTokenResponse
        /// </returns>
        public async Task<DescribeUploadTokenResponse> DescribeUploadTokenWithOptionsAsync(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeUploadToken",
                Version = "2022-03-02",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeUploadTokenResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves an upload token.</para>
        /// </summary>
        /// 
        /// <returns>
        /// DescribeUploadTokenResponse
        /// </returns>
        public DescribeUploadTokenResponse DescribeUploadToken()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeUploadTokenWithOptions(runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves an upload token.</para>
        /// </summary>
        /// 
        /// <returns>
        /// DescribeUploadTokenResponse
        /// </returns>
        public async Task<DescribeUploadTokenResponse> DescribeUploadTokenAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeUploadTokenWithOptionsAsync(runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries moderation results based on the ReqId returned by asynchronous URL moderation.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>Billing information: This operation is free of charge.</description></item>
        /// <item><description>Query timeout: We recommend that you set the query interval to 480 seconds (query the results 480 seconds after you submit the asynchronous moderation task). The maximum timeout period is 3 days. After this period, the results are automatically deleted.</description></item>
        /// <item><description>The QPS limit for this operation is 100 queries per second (QPS) per user. If the limit is exceeded, your API calls will be throttled, which may affect your business. Make sure you call the operation at a reasonable rate.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeUrlModerationResultRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeUrlModerationResultResponse
        /// </returns>
        public DescribeUrlModerationResultResponse DescribeUrlModerationResultWithOptions(DescribeUrlModerationResultRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReqId))
            {
                body["ReqId"] = request.ReqId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeUrlModerationResult",
                Version = "2022-03-02",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeUrlModerationResultResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries moderation results based on the ReqId returned by asynchronous URL moderation.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>Billing information: This operation is free of charge.</description></item>
        /// <item><description>Query timeout: We recommend that you set the query interval to 480 seconds (query the results 480 seconds after you submit the asynchronous moderation task). The maximum timeout period is 3 days. After this period, the results are automatically deleted.</description></item>
        /// <item><description>The QPS limit for this operation is 100 queries per second (QPS) per user. If the limit is exceeded, your API calls will be throttled, which may affect your business. Make sure you call the operation at a reasonable rate.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeUrlModerationResultRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DescribeUrlModerationResultResponse
        /// </returns>
        public async Task<DescribeUrlModerationResultResponse> DescribeUrlModerationResultWithOptionsAsync(DescribeUrlModerationResultRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReqId))
            {
                body["ReqId"] = request.ReqId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DescribeUrlModerationResult",
                Version = "2022-03-02",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<DescribeUrlModerationResultResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries moderation results based on the ReqId returned by asynchronous URL moderation.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>Billing information: This operation is free of charge.</description></item>
        /// <item><description>Query timeout: We recommend that you set the query interval to 480 seconds (query the results 480 seconds after you submit the asynchronous moderation task). The maximum timeout period is 3 days. After this period, the results are automatically deleted.</description></item>
        /// <item><description>The QPS limit for this operation is 100 queries per second (QPS) per user. If the limit is exceeded, your API calls will be throttled, which may affect your business. Make sure you call the operation at a reasonable rate.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeUrlModerationResultRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeUrlModerationResultResponse
        /// </returns>
        public DescribeUrlModerationResultResponse DescribeUrlModerationResult(DescribeUrlModerationResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeUrlModerationResultWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries moderation results based on the ReqId returned by asynchronous URL moderation.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>Billing information: This operation is free of charge.</description></item>
        /// <item><description>Query timeout: We recommend that you set the query interval to 480 seconds (query the results 480 seconds after you submit the asynchronous moderation task). The maximum timeout period is 3 days. After this period, the results are automatically deleted.</description></item>
        /// <item><description>The QPS limit for this operation is 100 queries per second (QPS) per user. If the limit is exceeded, your API calls will be throttled, which may affect your business. Make sure you call the operation at a reasonable rate.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// DescribeUrlModerationResultRequest
        /// </param>
        /// 
        /// <returns>
        /// DescribeUrlModerationResultResponse
        /// </returns>
        public async Task<DescribeUrlModerationResultResponse> DescribeUrlModerationResultAsync(DescribeUrlModerationResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeUrlModerationResultWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Moderates document content.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// FileModerationRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// FileModerationResponse
        /// </returns>
        public FileModerationResponse FileModerationWithOptions(FileModerationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Service))
            {
                body["Service"] = request.Service;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceParameters))
            {
                body["ServiceParameters"] = request.ServiceParameters;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "FileModeration",
                Version = "2022-03-02",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<FileModerationResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Moderates document content.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// FileModerationRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// FileModerationResponse
        /// </returns>
        public async Task<FileModerationResponse> FileModerationWithOptionsAsync(FileModerationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Service))
            {
                body["Service"] = request.Service;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceParameters))
            {
                body["ServiceParameters"] = request.ServiceParameters;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "FileModeration",
                Version = "2022-03-02",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<FileModerationResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Moderates document content.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// FileModerationRequest
        /// </param>
        /// 
        /// <returns>
        /// FileModerationResponse
        /// </returns>
        public FileModerationResponse FileModeration(FileModerationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return FileModerationWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Moderates document content.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// FileModerationRequest
        /// </param>
        /// 
        /// <returns>
        /// FileModerationResponse
        /// </returns>
        public async Task<FileModerationResponse> FileModerationAsync(FileModerationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await FileModerationWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>This API is used for asynchronous image moderation. Asynchronous moderation tasks do not return detection results in real time. You can obtain the detection results using a callback or by polling. The detection results are retained for up to three days.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>The following image formats are supported: PNG, JPG, JPEG, BMP, WEBP, TIFF, ICO, HEIC, and SVG.</description></item>
        /// <item><description>The image size cannot exceed 10 MB. The recommended image resolution is greater than 200 × 200 pixels. A low resolution may compromise the accuracy of the Content Moderation algorithm.</description></item>
        /// <item><description>The timeout period for image downloads is 3 seconds. If an image download exceeds this duration, a download timeout error is returned.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ImageAsyncModerationRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ImageAsyncModerationResponse
        /// </returns>
        public ImageAsyncModerationResponse ImageAsyncModerationWithOptions(ImageAsyncModerationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Service))
            {
                query["Service"] = request.Service;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceParameters))
            {
                query["ServiceParameters"] = request.ServiceParameters;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ImageAsyncModeration",
                Version = "2022-03-02",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ImageAsyncModerationResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>This API is used for asynchronous image moderation. Asynchronous moderation tasks do not return detection results in real time. You can obtain the detection results using a callback or by polling. The detection results are retained for up to three days.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>The following image formats are supported: PNG, JPG, JPEG, BMP, WEBP, TIFF, ICO, HEIC, and SVG.</description></item>
        /// <item><description>The image size cannot exceed 10 MB. The recommended image resolution is greater than 200 × 200 pixels. A low resolution may compromise the accuracy of the Content Moderation algorithm.</description></item>
        /// <item><description>The timeout period for image downloads is 3 seconds. If an image download exceeds this duration, a download timeout error is returned.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ImageAsyncModerationRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ImageAsyncModerationResponse
        /// </returns>
        public async Task<ImageAsyncModerationResponse> ImageAsyncModerationWithOptionsAsync(ImageAsyncModerationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Service))
            {
                query["Service"] = request.Service;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceParameters))
            {
                query["ServiceParameters"] = request.ServiceParameters;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ImageAsyncModeration",
                Version = "2022-03-02",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ImageAsyncModerationResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>This API is used for asynchronous image moderation. Asynchronous moderation tasks do not return detection results in real time. You can obtain the detection results using a callback or by polling. The detection results are retained for up to three days.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>The following image formats are supported: PNG, JPG, JPEG, BMP, WEBP, TIFF, ICO, HEIC, and SVG.</description></item>
        /// <item><description>The image size cannot exceed 10 MB. The recommended image resolution is greater than 200 × 200 pixels. A low resolution may compromise the accuracy of the Content Moderation algorithm.</description></item>
        /// <item><description>The timeout period for image downloads is 3 seconds. If an image download exceeds this duration, a download timeout error is returned.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ImageAsyncModerationRequest
        /// </param>
        /// 
        /// <returns>
        /// ImageAsyncModerationResponse
        /// </returns>
        public ImageAsyncModerationResponse ImageAsyncModeration(ImageAsyncModerationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ImageAsyncModerationWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>This API is used for asynchronous image moderation. Asynchronous moderation tasks do not return detection results in real time. You can obtain the detection results using a callback or by polling. The detection results are retained for up to three days.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <list type="bullet">
        /// <item><description>The following image formats are supported: PNG, JPG, JPEG, BMP, WEBP, TIFF, ICO, HEIC, and SVG.</description></item>
        /// <item><description>The image size cannot exceed 10 MB. The recommended image resolution is greater than 200 × 200 pixels. A low resolution may compromise the accuracy of the Content Moderation algorithm.</description></item>
        /// <item><description>The timeout period for image downloads is 3 seconds. If an image download exceeds this duration, a download timeout error is returned.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// ImageAsyncModerationRequest
        /// </param>
        /// 
        /// <returns>
        /// ImageAsyncModerationResponse
        /// </returns>
        public async Task<ImageAsyncModerationResponse> ImageAsyncModerationAsync(ImageAsyncModerationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ImageAsyncModerationWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Batch Invocation of Images</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ImageBatchModerationRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ImageBatchModerationResponse
        /// </returns>
        public ImageBatchModerationResponse ImageBatchModerationWithOptions(ImageBatchModerationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Service))
            {
                query["Service"] = request.Service;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceParameters))
            {
                query["ServiceParameters"] = request.ServiceParameters;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ImageBatchModeration",
                Version = "2022-03-02",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ImageBatchModerationResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Batch Invocation of Images</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ImageBatchModerationRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ImageBatchModerationResponse
        /// </returns>
        public async Task<ImageBatchModerationResponse> ImageBatchModerationWithOptionsAsync(ImageBatchModerationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Service))
            {
                query["Service"] = request.Service;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceParameters))
            {
                query["ServiceParameters"] = request.ServiceParameters;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ImageBatchModeration",
                Version = "2022-03-02",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ImageBatchModerationResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Batch Invocation of Images</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ImageBatchModerationRequest
        /// </param>
        /// 
        /// <returns>
        /// ImageBatchModerationResponse
        /// </returns>
        public ImageBatchModerationResponse ImageBatchModeration(ImageBatchModerationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ImageBatchModerationWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Batch Invocation of Images</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ImageBatchModerationRequest
        /// </param>
        /// 
        /// <returns>
        /// ImageBatchModerationResponse
        /// </returns>
        public async Task<ImageBatchModerationResponse> ImageBatchModerationAsync(ImageBatchModerationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ImageBatchModerationWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Image moderation</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you call this operation, complete the following steps:</para>
        /// <ol>
        /// <item><description><a href="https://common-buy.aliyun.com/?commodityCode=lvwang_cip_public_cn">Activate AI Guardrails-Enhanced Edition</a>.</description></item>
        /// <item><description>Understand the <a href="https://help.aliyun.com/document_detail/467826.html?#section-h06-qz6-1pt">billing methods and pricing</a> of the enhanced image moderation feature.</description></item>
        /// <item><description>For more information about API usage and parameters, see the <a href="https://help.aliyun.com/document_detail/467829.html">API reference</a>.</description></item>
        /// </ol>
        /// </description>
        /// 
        /// <param name="request">
        /// ImageModerationRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ImageModerationResponse
        /// </returns>
        public ImageModerationResponse ImageModerationWithOptions(ImageModerationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Service))
            {
                body["Service"] = request.Service;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceParameters))
            {
                body["ServiceParameters"] = request.ServiceParameters;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ImageModeration",
                Version = "2022-03-02",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ImageModerationResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Image moderation</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you call this operation, complete the following steps:</para>
        /// <ol>
        /// <item><description><a href="https://common-buy.aliyun.com/?commodityCode=lvwang_cip_public_cn">Activate AI Guardrails-Enhanced Edition</a>.</description></item>
        /// <item><description>Understand the <a href="https://help.aliyun.com/document_detail/467826.html?#section-h06-qz6-1pt">billing methods and pricing</a> of the enhanced image moderation feature.</description></item>
        /// <item><description>For more information about API usage and parameters, see the <a href="https://help.aliyun.com/document_detail/467829.html">API reference</a>.</description></item>
        /// </ol>
        /// </description>
        /// 
        /// <param name="request">
        /// ImageModerationRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ImageModerationResponse
        /// </returns>
        public async Task<ImageModerationResponse> ImageModerationWithOptionsAsync(ImageModerationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Service))
            {
                body["Service"] = request.Service;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceParameters))
            {
                body["ServiceParameters"] = request.ServiceParameters;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ImageModeration",
                Version = "2022-03-02",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ImageModerationResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Image moderation</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you call this operation, complete the following steps:</para>
        /// <ol>
        /// <item><description><a href="https://common-buy.aliyun.com/?commodityCode=lvwang_cip_public_cn">Activate AI Guardrails-Enhanced Edition</a>.</description></item>
        /// <item><description>Understand the <a href="https://help.aliyun.com/document_detail/467826.html?#section-h06-qz6-1pt">billing methods and pricing</a> of the enhanced image moderation feature.</description></item>
        /// <item><description>For more information about API usage and parameters, see the <a href="https://help.aliyun.com/document_detail/467829.html">API reference</a>.</description></item>
        /// </ol>
        /// </description>
        /// 
        /// <param name="request">
        /// ImageModerationRequest
        /// </param>
        /// 
        /// <returns>
        /// ImageModerationResponse
        /// </returns>
        public ImageModerationResponse ImageModeration(ImageModerationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ImageModerationWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Image moderation</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you call this operation, complete the following steps:</para>
        /// <ol>
        /// <item><description><a href="https://common-buy.aliyun.com/?commodityCode=lvwang_cip_public_cn">Activate AI Guardrails-Enhanced Edition</a>.</description></item>
        /// <item><description>Understand the <a href="https://help.aliyun.com/document_detail/467826.html?#section-h06-qz6-1pt">billing methods and pricing</a> of the enhanced image moderation feature.</description></item>
        /// <item><description>For more information about API usage and parameters, see the <a href="https://help.aliyun.com/document_detail/467829.html">API reference</a>.</description></item>
        /// </ol>
        /// </description>
        /// 
        /// <param name="request">
        /// ImageModerationRequest
        /// </param>
        /// 
        /// <returns>
        /// ImageModerationResponse
        /// </returns>
        public async Task<ImageModerationResponse> ImageModerationAsync(ImageModerationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ImageModerationWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>图片审核</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ImageQueueModerationRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ImageQueueModerationResponse
        /// </returns>
        public ImageQueueModerationResponse ImageQueueModerationWithOptions(ImageQueueModerationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Service))
            {
                body["Service"] = request.Service;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceParameters))
            {
                body["ServiceParameters"] = request.ServiceParameters;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ImageQueueModeration",
                Version = "2022-03-02",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ImageQueueModerationResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>图片审核</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ImageQueueModerationRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ImageQueueModerationResponse
        /// </returns>
        public async Task<ImageQueueModerationResponse> ImageQueueModerationWithOptionsAsync(ImageQueueModerationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Service))
            {
                body["Service"] = request.Service;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceParameters))
            {
                body["ServiceParameters"] = request.ServiceParameters;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ImageQueueModeration",
                Version = "2022-03-02",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ImageQueueModerationResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>图片审核</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ImageQueueModerationRequest
        /// </param>
        /// 
        /// <returns>
        /// ImageQueueModerationResponse
        /// </returns>
        public ImageQueueModerationResponse ImageQueueModeration(ImageQueueModerationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ImageQueueModerationWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>图片审核</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ImageQueueModerationRequest
        /// </param>
        /// 
        /// <returns>
        /// ImageQueueModerationResponse
        /// </returns>
        public async Task<ImageQueueModerationResponse> ImageQueueModerationAsync(ImageQueueModerationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ImageQueueModerationWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>The channel callback API for manual review results in Content Moderation.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ManualCallbackRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ManualCallbackResponse
        /// </returns>
        public ManualCallbackResponse ManualCallbackWithOptions(ManualCallbackRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Channel))
            {
                body["Channel"] = request.Channel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Checksum))
            {
                body["Checksum"] = request.Checksum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Code))
            {
                body["Code"] = request.Code;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Data))
            {
                body["Data"] = request.Data;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Msg))
            {
                body["Msg"] = request.Msg;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReqId))
            {
                body["ReqId"] = request.ReqId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ManualCallback",
                Version = "2022-03-02",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ManualCallbackResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>The channel callback API for manual review results in Content Moderation.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ManualCallbackRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ManualCallbackResponse
        /// </returns>
        public async Task<ManualCallbackResponse> ManualCallbackWithOptionsAsync(ManualCallbackRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Channel))
            {
                body["Channel"] = request.Channel;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Checksum))
            {
                body["Checksum"] = request.Checksum;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Code))
            {
                body["Code"] = request.Code;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Data))
            {
                body["Data"] = request.Data;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Msg))
            {
                body["Msg"] = request.Msg;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ReqId))
            {
                body["ReqId"] = request.ReqId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ManualCallback",
                Version = "2022-03-02",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ManualCallbackResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>The channel callback API for manual review results in Content Moderation.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ManualCallbackRequest
        /// </param>
        /// 
        /// <returns>
        /// ManualCallbackResponse
        /// </returns>
        public ManualCallbackResponse ManualCallback(ManualCallbackRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ManualCallbackWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>The channel callback API for manual review results in Content Moderation.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ManualCallbackRequest
        /// </param>
        /// 
        /// <returns>
        /// ManualCallbackResponse
        /// </returns>
        public async Task<ManualCallbackResponse> ManualCallbackAsync(ManualCallbackRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ManualCallbackWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Interface for submitting Content Moderation manual review requests</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ManualModerationRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ManualModerationResponse
        /// </returns>
        public ManualModerationResponse ManualModerationWithOptions(ManualModerationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Service))
            {
                body["Service"] = request.Service;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceParameters))
            {
                body["ServiceParameters"] = request.ServiceParameters;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ManualModeration",
                Version = "2022-03-02",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ManualModerationResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Interface for submitting Content Moderation manual review requests</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ManualModerationRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ManualModerationResponse
        /// </returns>
        public async Task<ManualModerationResponse> ManualModerationWithOptionsAsync(ManualModerationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Service))
            {
                body["Service"] = request.Service;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceParameters))
            {
                body["ServiceParameters"] = request.ServiceParameters;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ManualModeration",
                Version = "2022-03-02",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ManualModerationResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Interface for submitting Content Moderation manual review requests</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ManualModerationRequest
        /// </param>
        /// 
        /// <returns>
        /// ManualModerationResponse
        /// </returns>
        public ManualModerationResponse ManualModeration(ManualModerationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ManualModerationWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Interface for submitting Content Moderation manual review requests</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ManualModerationRequest
        /// </param>
        /// 
        /// <returns>
        /// ManualModerationResponse
        /// </returns>
        public async Task<ManualModerationResponse> ManualModerationAsync(ManualModerationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ManualModerationWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the manual review result.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ManualModerationResultRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ManualModerationResultResponse
        /// </returns>
        public ManualModerationResultResponse ManualModerationResultWithOptions(ManualModerationResultRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceParameters))
            {
                body["ServiceParameters"] = request.ServiceParameters;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ManualModerationResult",
                Version = "2022-03-02",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ManualModerationResultResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the manual review result.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ManualModerationResultRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ManualModerationResultResponse
        /// </returns>
        public async Task<ManualModerationResultResponse> ManualModerationResultWithOptionsAsync(ManualModerationResultRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceParameters))
            {
                body["ServiceParameters"] = request.ServiceParameters;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ManualModerationResult",
                Version = "2022-03-02",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<ManualModerationResultResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the manual review result.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ManualModerationResultRequest
        /// </param>
        /// 
        /// <returns>
        /// ManualModerationResultResponse
        /// </returns>
        public ManualModerationResultResponse ManualModerationResult(ManualModerationResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ManualModerationResultWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the manual review result.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ManualModerationResultRequest
        /// </param>
        /// 
        /// <returns>
        /// ManualModerationResultResponse
        /// </returns>
        public async Task<ManualModerationResultResponse> ManualModerationResultAsync(ManualModerationResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ManualModerationResultWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>This is the synchronous detection API for the multi-modal agent.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This is the AI Guardrails agent.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// MultiModalAgentRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// MultiModalAgentResponse
        /// </returns>
        public MultiModalAgentResponse MultiModalAgentWithOptions(MultiModalAgentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppID))
            {
                body["AppID"] = request.AppID;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceParameters))
            {
                body["ServiceParameters"] = request.ServiceParameters;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "MultiModalAgent",
                Version = "2022-03-02",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<MultiModalAgentResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>This is the synchronous detection API for the multi-modal agent.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This is the AI Guardrails agent.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// MultiModalAgentRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// MultiModalAgentResponse
        /// </returns>
        public async Task<MultiModalAgentResponse> MultiModalAgentWithOptionsAsync(MultiModalAgentRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.AppID))
            {
                body["AppID"] = request.AppID;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceParameters))
            {
                body["ServiceParameters"] = request.ServiceParameters;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "MultiModalAgent",
                Version = "2022-03-02",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<MultiModalAgentResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>This is the synchronous detection API for the multi-modal agent.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This is the AI Guardrails agent.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// MultiModalAgentRequest
        /// </param>
        /// 
        /// <returns>
        /// MultiModalAgentResponse
        /// </returns>
        public MultiModalAgentResponse MultiModalAgent(MultiModalAgentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return MultiModalAgentWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>This is the synchronous detection API for the multi-modal agent.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This is the AI Guardrails agent.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// MultiModalAgentRequest
        /// </param>
        /// 
        /// <returns>
        /// MultiModalAgentResponse
        /// </returns>
        public async Task<MultiModalAgentResponse> MultiModalAgentAsync(MultiModalAgentRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await MultiModalAgentWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>API for synchronous detection</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// MultiModalGuardRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// MultiModalGuardResponse
        /// </returns>
        public MultiModalGuardResponse MultiModalGuardWithOptions(MultiModalGuardRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Service))
            {
                body["Service"] = request.Service;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceParameters))
            {
                body["ServiceParameters"] = request.ServiceParameters;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "MultiModalGuard",
                Version = "2022-03-02",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<MultiModalGuardResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>API for synchronous detection</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// MultiModalGuardRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// MultiModalGuardResponse
        /// </returns>
        public async Task<MultiModalGuardResponse> MultiModalGuardWithOptionsAsync(MultiModalGuardRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Service))
            {
                body["Service"] = request.Service;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceParameters))
            {
                body["ServiceParameters"] = request.ServiceParameters;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "MultiModalGuard",
                Version = "2022-03-02",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<MultiModalGuardResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>API for synchronous detection</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// MultiModalGuardRequest
        /// </param>
        /// 
        /// <returns>
        /// MultiModalGuardResponse
        /// </returns>
        public MultiModalGuardResponse MultiModalGuard(MultiModalGuardRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return MultiModalGuardWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>API for synchronous detection</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// MultiModalGuardRequest
        /// </param>
        /// 
        /// <returns>
        /// MultiModalGuardResponse
        /// </returns>
        public async Task<MultiModalGuardResponse> MultiModalGuardAsync(MultiModalGuardRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await MultiModalGuardWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>An asynchronous multimodal AI safety guardrail API for audio and video. It provides comprehensive detection of non-compliant content, sensitive content, prompt injection attacks, malicious files, and malicious URLs.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>If an API is subject to billing, add the following sentence in bold: &quot;Before using this API, ensure that you fully understand the billing methods and pricing of the XXX product.&quot; The word &quot;pricing&quot; must be a hyperlink to https\://www\.aliyun.com/price/product#/ecs/detail.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// MultiModalGuardAsyncRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// MultiModalGuardAsyncResponse
        /// </returns>
        public MultiModalGuardAsyncResponse MultiModalGuardAsyncWithOptions(MultiModalGuardAsyncRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Service))
            {
                body["Service"] = request.Service;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceParameters))
            {
                body["ServiceParameters"] = request.ServiceParameters;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "MultiModalGuardAsync",
                Version = "2022-03-02",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<MultiModalGuardAsyncResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>An asynchronous multimodal AI safety guardrail API for audio and video. It provides comprehensive detection of non-compliant content, sensitive content, prompt injection attacks, malicious files, and malicious URLs.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>If an API is subject to billing, add the following sentence in bold: &quot;Before using this API, ensure that you fully understand the billing methods and pricing of the XXX product.&quot; The word &quot;pricing&quot; must be a hyperlink to https\://www\.aliyun.com/price/product#/ecs/detail.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// MultiModalGuardAsyncRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// MultiModalGuardAsyncResponse
        /// </returns>
        public async Task<MultiModalGuardAsyncResponse> MultiModalGuardAsyncWithOptionsAsync(MultiModalGuardAsyncRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Service))
            {
                body["Service"] = request.Service;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceParameters))
            {
                body["ServiceParameters"] = request.ServiceParameters;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "MultiModalGuardAsync",
                Version = "2022-03-02",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<MultiModalGuardAsyncResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>An asynchronous multimodal AI safety guardrail API for audio and video. It provides comprehensive detection of non-compliant content, sensitive content, prompt injection attacks, malicious files, and malicious URLs.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>If an API is subject to billing, add the following sentence in bold: &quot;Before using this API, ensure that you fully understand the billing methods and pricing of the XXX product.&quot; The word &quot;pricing&quot; must be a hyperlink to https\://www\.aliyun.com/price/product#/ecs/detail.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// MultiModalGuardAsyncRequest
        /// </param>
        /// 
        /// <returns>
        /// MultiModalGuardAsyncResponse
        /// </returns>
        public MultiModalGuardAsyncResponse MultiModalGuardAsync(MultiModalGuardAsyncRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return MultiModalGuardAsyncWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>An asynchronous multimodal AI safety guardrail API for audio and video. It provides comprehensive detection of non-compliant content, sensitive content, prompt injection attacks, malicious files, and malicious URLs.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>If an API is subject to billing, add the following sentence in bold: &quot;Before using this API, ensure that you fully understand the billing methods and pricing of the XXX product.&quot; The word &quot;pricing&quot; must be a hyperlink to https\://www\.aliyun.com/price/product#/ecs/detail.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// MultiModalGuardAsyncRequest
        /// </param>
        /// 
        /// <returns>
        /// MultiModalGuardAsyncResponse
        /// </returns>
        public async Task<MultiModalGuardAsyncResponse> MultiModalGuardAsyncAsync(MultiModalGuardAsyncRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await MultiModalGuardAsyncWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>This AI Security Guardrail API retrieves asynchronous multimodal results from both audio and video.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>For APIs that incur charges, add the following sentence in bold at the beginning of the description: &quot;Before you use this API, make sure that you fully understand the billing methods and pricing of the XXX product.&quot; Link the word \&quot;pricing\&quot; to https\://www\.aliyun.com/price/product#/ecs/detail.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// MultiModalGuardAsyncResultRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// MultiModalGuardAsyncResultResponse
        /// </returns>
        public MultiModalGuardAsyncResultResponse MultiModalGuardAsyncResultWithOptions(MultiModalGuardAsyncResultRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Service))
            {
                body["Service"] = request.Service;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceParameters))
            {
                body["ServiceParameters"] = request.ServiceParameters;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "MultiModalGuardAsyncResult",
                Version = "2022-03-02",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<MultiModalGuardAsyncResultResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>This AI Security Guardrail API retrieves asynchronous multimodal results from both audio and video.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>For APIs that incur charges, add the following sentence in bold at the beginning of the description: &quot;Before you use this API, make sure that you fully understand the billing methods and pricing of the XXX product.&quot; Link the word \&quot;pricing\&quot; to https\://www\.aliyun.com/price/product#/ecs/detail.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// MultiModalGuardAsyncResultRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// MultiModalGuardAsyncResultResponse
        /// </returns>
        public async Task<MultiModalGuardAsyncResultResponse> MultiModalGuardAsyncResultWithOptionsAsync(MultiModalGuardAsyncResultRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Service))
            {
                body["Service"] = request.Service;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceParameters))
            {
                body["ServiceParameters"] = request.ServiceParameters;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "MultiModalGuardAsyncResult",
                Version = "2022-03-02",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<MultiModalGuardAsyncResultResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>This AI Security Guardrail API retrieves asynchronous multimodal results from both audio and video.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>For APIs that incur charges, add the following sentence in bold at the beginning of the description: &quot;Before you use this API, make sure that you fully understand the billing methods and pricing of the XXX product.&quot; Link the word \&quot;pricing\&quot; to https\://www\.aliyun.com/price/product#/ecs/detail.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// MultiModalGuardAsyncResultRequest
        /// </param>
        /// 
        /// <returns>
        /// MultiModalGuardAsyncResultResponse
        /// </returns>
        public MultiModalGuardAsyncResultResponse MultiModalGuardAsyncResult(MultiModalGuardAsyncResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return MultiModalGuardAsyncResultWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>This AI Security Guardrail API retrieves asynchronous multimodal results from both audio and video.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>For APIs that incur charges, add the following sentence in bold at the beginning of the description: &quot;Before you use this API, make sure that you fully understand the billing methods and pricing of the XXX product.&quot; Link the word \&quot;pricing\&quot; to https\://www\.aliyun.com/price/product#/ecs/detail.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// MultiModalGuardAsyncResultRequest
        /// </param>
        /// 
        /// <returns>
        /// MultiModalGuardAsyncResultResponse
        /// </returns>
        public async Task<MultiModalGuardAsyncResultResponse> MultiModalGuardAsyncResultAsync(MultiModalGuardAsyncResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await MultiModalGuardAsyncResultWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>多模态同步检测接口，支持图片base64字符串</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// MultiModalGuardForBase64Request
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// MultiModalGuardForBase64Response
        /// </returns>
        public MultiModalGuardForBase64Response MultiModalGuardForBase64WithOptions(MultiModalGuardForBase64Request request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Service))
            {
                query["Service"] = request.Service;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageBase64Str))
            {
                body["ImageBase64Str"] = request.ImageBase64Str;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceParameters))
            {
                body["ServiceParameters"] = request.ServiceParameters;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "MultiModalGuardForBase64",
                Version = "2022-03-02",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<MultiModalGuardForBase64Response>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>多模态同步检测接口，支持图片base64字符串</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// MultiModalGuardForBase64Request
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// MultiModalGuardForBase64Response
        /// </returns>
        public async Task<MultiModalGuardForBase64Response> MultiModalGuardForBase64WithOptionsAsync(MultiModalGuardForBase64Request request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Service))
            {
                query["Service"] = request.Service;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageBase64Str))
            {
                body["ImageBase64Str"] = request.ImageBase64Str;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceParameters))
            {
                body["ServiceParameters"] = request.ServiceParameters;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "MultiModalGuardForBase64",
                Version = "2022-03-02",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<MultiModalGuardForBase64Response>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>多模态同步检测接口，支持图片base64字符串</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// MultiModalGuardForBase64Request
        /// </param>
        /// 
        /// <returns>
        /// MultiModalGuardForBase64Response
        /// </returns>
        public MultiModalGuardForBase64Response MultiModalGuardForBase64(MultiModalGuardForBase64Request request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return MultiModalGuardForBase64WithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>多模态同步检测接口，支持图片base64字符串</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// MultiModalGuardForBase64Request
        /// </param>
        /// 
        /// <returns>
        /// MultiModalGuardForBase64Response
        /// </returns>
        public async Task<MultiModalGuardForBase64Response> MultiModalGuardForBase64Async(MultiModalGuardForBase64Request request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await MultiModalGuardForBase64WithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Provides a WebSocket-based multimodal detection API for AI safety guardrails. This API supports content compliance detection, sensitive content detection, prompt attack detection, malicious file detection, malicious URL detection, and other comprehensive detection capabilities.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// MultiModalGuardWsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// MultiModalGuardWsResponse
        /// </returns>
        public MultiModalGuardWsResponse MultiModalGuardWsWithOptions(MultiModalGuardWsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "MultiModalGuardWs",
                Version = "2022-03-02",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<MultiModalGuardWsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Provides a WebSocket-based multimodal detection API for AI safety guardrails. This API supports content compliance detection, sensitive content detection, prompt attack detection, malicious file detection, malicious URL detection, and other comprehensive detection capabilities.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// MultiModalGuardWsRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// MultiModalGuardWsResponse
        /// </returns>
        public async Task<MultiModalGuardWsResponse> MultiModalGuardWsWithOptionsAsync(MultiModalGuardWsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "MultiModalGuardWs",
                Version = "2022-03-02",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "GET",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<MultiModalGuardWsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Provides a WebSocket-based multimodal detection API for AI safety guardrails. This API supports content compliance detection, sensitive content detection, prompt attack detection, malicious file detection, malicious URL detection, and other comprehensive detection capabilities.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// MultiModalGuardWsRequest
        /// </param>
        /// 
        /// <returns>
        /// MultiModalGuardWsResponse
        /// </returns>
        public MultiModalGuardWsResponse MultiModalGuardWs(MultiModalGuardWsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return MultiModalGuardWsWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Provides a WebSocket-based multimodal detection API for AI safety guardrails. This API supports content compliance detection, sensitive content detection, prompt attack detection, malicious file detection, malicious URL detection, and other comprehensive detection capabilities.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// MultiModalGuardWsRequest
        /// </param>
        /// 
        /// <returns>
        /// MultiModalGuardWsResponse
        /// </returns>
        public async Task<MultiModalGuardWsResponse> MultiModalGuardWsAsync(MultiModalGuardWsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await MultiModalGuardWsWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Multimodal-Asynchronous Detection</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>The asynchronous URL moderation service supports two billing methods: pay-as-you-go and resource plan usage.</para>
        /// <list type="bullet">
        /// <item><description>After you activate the enhanced text moderation service, the default billing method is pay-as-you-go. You are billed daily based on actual usage. No charges apply if you do not invoke the service.</description></item>
        /// <item><description>If your moderation volume is large or your moderation needs are relatively stable, purchase a resource plan in advance. Larger resource plans offer greater discounts. You can stack multiple resource plans.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// MultimodalAsyncModerationRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// MultimodalAsyncModerationResponse
        /// </returns>
        public MultimodalAsyncModerationResponse MultimodalAsyncModerationWithOptions(MultimodalAsyncModerationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Service))
            {
                query["Service"] = request.Service;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceParameters))
            {
                query["ServiceParameters"] = request.ServiceParameters;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "MultimodalAsyncModeration",
                Version = "2022-03-02",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<MultimodalAsyncModerationResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Multimodal-Asynchronous Detection</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>The asynchronous URL moderation service supports two billing methods: pay-as-you-go and resource plan usage.</para>
        /// <list type="bullet">
        /// <item><description>After you activate the enhanced text moderation service, the default billing method is pay-as-you-go. You are billed daily based on actual usage. No charges apply if you do not invoke the service.</description></item>
        /// <item><description>If your moderation volume is large or your moderation needs are relatively stable, purchase a resource plan in advance. Larger resource plans offer greater discounts. You can stack multiple resource plans.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// MultimodalAsyncModerationRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// MultimodalAsyncModerationResponse
        /// </returns>
        public async Task<MultimodalAsyncModerationResponse> MultimodalAsyncModerationWithOptionsAsync(MultimodalAsyncModerationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Service))
            {
                query["Service"] = request.Service;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceParameters))
            {
                query["ServiceParameters"] = request.ServiceParameters;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "MultimodalAsyncModeration",
                Version = "2022-03-02",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<MultimodalAsyncModerationResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Multimodal-Asynchronous Detection</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>The asynchronous URL moderation service supports two billing methods: pay-as-you-go and resource plan usage.</para>
        /// <list type="bullet">
        /// <item><description>After you activate the enhanced text moderation service, the default billing method is pay-as-you-go. You are billed daily based on actual usage. No charges apply if you do not invoke the service.</description></item>
        /// <item><description>If your moderation volume is large or your moderation needs are relatively stable, purchase a resource plan in advance. Larger resource plans offer greater discounts. You can stack multiple resource plans.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// MultimodalAsyncModerationRequest
        /// </param>
        /// 
        /// <returns>
        /// MultimodalAsyncModerationResponse
        /// </returns>
        public MultimodalAsyncModerationResponse MultimodalAsyncModeration(MultimodalAsyncModerationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return MultimodalAsyncModerationWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Multimodal-Asynchronous Detection</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>The asynchronous URL moderation service supports two billing methods: pay-as-you-go and resource plan usage.</para>
        /// <list type="bullet">
        /// <item><description>After you activate the enhanced text moderation service, the default billing method is pay-as-you-go. You are billed daily based on actual usage. No charges apply if you do not invoke the service.</description></item>
        /// <item><description>If your moderation volume is large or your moderation needs are relatively stable, purchase a resource plan in advance. Larger resource plans offer greater discounts. You can stack multiple resource plans.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// MultimodalAsyncModerationRequest
        /// </param>
        /// 
        /// <returns>
        /// MultimodalAsyncModerationResponse
        /// </returns>
        public async Task<MultimodalAsyncModerationResponse> MultimodalAsyncModerationAsync(MultimodalAsyncModerationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await MultimodalAsyncModerationWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>This service uses dynamic policies and models to defend against adversarial content. It provides moderation services for various business scenarios and detects different types of violations.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you use this operation, review the <a href="https://help.aliyun.com/document_detail/464388.html?#section-itm-m2s-ugq">billing methods and pricing</a> for Text Moderation Plus.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// TextModerationRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// TextModerationResponse
        /// </returns>
        public TextModerationResponse TextModerationWithOptions(TextModerationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Service))
            {
                body["Service"] = request.Service;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceParameters))
            {
                body["ServiceParameters"] = request.ServiceParameters;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TextModeration",
                Version = "2022-03-02",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<TextModerationResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>This service uses dynamic policies and models to defend against adversarial content. It provides moderation services for various business scenarios and detects different types of violations.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you use this operation, review the <a href="https://help.aliyun.com/document_detail/464388.html?#section-itm-m2s-ugq">billing methods and pricing</a> for Text Moderation Plus.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// TextModerationRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// TextModerationResponse
        /// </returns>
        public async Task<TextModerationResponse> TextModerationWithOptionsAsync(TextModerationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Service))
            {
                body["Service"] = request.Service;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceParameters))
            {
                body["ServiceParameters"] = request.ServiceParameters;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TextModeration",
                Version = "2022-03-02",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<TextModerationResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>This service uses dynamic policies and models to defend against adversarial content. It provides moderation services for various business scenarios and detects different types of violations.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you use this operation, review the <a href="https://help.aliyun.com/document_detail/464388.html?#section-itm-m2s-ugq">billing methods and pricing</a> for Text Moderation Plus.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// TextModerationRequest
        /// </param>
        /// 
        /// <returns>
        /// TextModerationResponse
        /// </returns>
        public TextModerationResponse TextModeration(TextModerationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return TextModerationWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>This service uses dynamic policies and models to defend against adversarial content. It provides moderation services for various business scenarios and detects different types of violations.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you use this operation, review the <a href="https://help.aliyun.com/document_detail/464388.html?#section-itm-m2s-ugq">billing methods and pricing</a> for Text Moderation Plus.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// TextModerationRequest
        /// </param>
        /// 
        /// <returns>
        /// TextModerationResponse
        /// </returns>
        public async Task<TextModerationResponse> TextModerationAsync(TextModerationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await TextModerationWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Text Moderation Plus is an upgraded service that moderates the input instructions and generated text of large language models (LLMs). This service can retrieve standard answers for specific input instructions and lets you enable or disable moderation labels.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you use this API, <a href="https://common-buy.aliyun.com/?commodityCode=lvwang_cip_public_cn">activate AI Guardrails Pro</a> and make sure that you understand the <a href="https://help.aliyun.com/document_detail/2671445.html?#section-6od-32j-99n">billing methods and pricing</a> for Text Moderation Plus.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// TextModerationPlusRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// TextModerationPlusResponse
        /// </returns>
        public TextModerationPlusResponse TextModerationPlusWithOptions(TextModerationPlusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Service))
            {
                body["Service"] = request.Service;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceParameters))
            {
                body["ServiceParameters"] = request.ServiceParameters;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TextModerationPlus",
                Version = "2022-03-02",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<TextModerationPlusResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Text Moderation Plus is an upgraded service that moderates the input instructions and generated text of large language models (LLMs). This service can retrieve standard answers for specific input instructions and lets you enable or disable moderation labels.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you use this API, <a href="https://common-buy.aliyun.com/?commodityCode=lvwang_cip_public_cn">activate AI Guardrails Pro</a> and make sure that you understand the <a href="https://help.aliyun.com/document_detail/2671445.html?#section-6od-32j-99n">billing methods and pricing</a> for Text Moderation Plus.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// TextModerationPlusRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// TextModerationPlusResponse
        /// </returns>
        public async Task<TextModerationPlusResponse> TextModerationPlusWithOptionsAsync(TextModerationPlusRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Service))
            {
                body["Service"] = request.Service;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceParameters))
            {
                body["ServiceParameters"] = request.ServiceParameters;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "TextModerationPlus",
                Version = "2022-03-02",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<TextModerationPlusResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Text Moderation Plus is an upgraded service that moderates the input instructions and generated text of large language models (LLMs). This service can retrieve standard answers for specific input instructions and lets you enable or disable moderation labels.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you use this API, <a href="https://common-buy.aliyun.com/?commodityCode=lvwang_cip_public_cn">activate AI Guardrails Pro</a> and make sure that you understand the <a href="https://help.aliyun.com/document_detail/2671445.html?#section-6od-32j-99n">billing methods and pricing</a> for Text Moderation Plus.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// TextModerationPlusRequest
        /// </param>
        /// 
        /// <returns>
        /// TextModerationPlusResponse
        /// </returns>
        public TextModerationPlusResponse TextModerationPlus(TextModerationPlusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return TextModerationPlusWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Text Moderation Plus is an upgraded service that moderates the input instructions and generated text of large language models (LLMs). This service can retrieve standard answers for specific input instructions and lets you enable or disable moderation labels.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you use this API, <a href="https://common-buy.aliyun.com/?commodityCode=lvwang_cip_public_cn">activate AI Guardrails Pro</a> and make sure that you understand the <a href="https://help.aliyun.com/document_detail/2671445.html?#section-6od-32j-99n">billing methods and pricing</a> for Text Moderation Plus.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// TextModerationPlusRequest
        /// </param>
        /// 
        /// <returns>
        /// TextModerationPlusResponse
        /// </returns>
        public async Task<TextModerationPlusResponse> TextModerationPlusAsync(TextModerationPlusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await TextModerationPlusWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>The URL asynchronous moderation service detects threats such as fraud, pornography, and gambling in URLs to protect the content ecosystem of your platform.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>The URL asynchronous moderation service supports the pay-as-you-go and resource plan billing methods.</para>
        /// <list type="bullet">
        /// <item><description>After you activate the enhanced edition of Text Moderation, the default billing method is pay-as-you-go. You are charged CNY 30 per 10,000 calls based on your daily usage. No fees are incurred if you do not call the service.</description></item>
        /// <item><description>If you have many moderation requests or relatively fixed moderation requirements, we recommend that you purchase resource plans in advance. The larger the resource plan you purchase, the greater the discount you receive. You can purchase and use multiple resource plans.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// UrlAsyncModerationRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UrlAsyncModerationResponse
        /// </returns>
        public UrlAsyncModerationResponse UrlAsyncModerationWithOptions(UrlAsyncModerationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Service))
            {
                query["Service"] = request.Service;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceParameters))
            {
                query["ServiceParameters"] = request.ServiceParameters;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UrlAsyncModeration",
                Version = "2022-03-02",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UrlAsyncModerationResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>The URL asynchronous moderation service detects threats such as fraud, pornography, and gambling in URLs to protect the content ecosystem of your platform.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>The URL asynchronous moderation service supports the pay-as-you-go and resource plan billing methods.</para>
        /// <list type="bullet">
        /// <item><description>After you activate the enhanced edition of Text Moderation, the default billing method is pay-as-you-go. You are charged CNY 30 per 10,000 calls based on your daily usage. No fees are incurred if you do not call the service.</description></item>
        /// <item><description>If you have many moderation requests or relatively fixed moderation requirements, we recommend that you purchase resource plans in advance. The larger the resource plan you purchase, the greater the discount you receive. You can purchase and use multiple resource plans.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// UrlAsyncModerationRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UrlAsyncModerationResponse
        /// </returns>
        public async Task<UrlAsyncModerationResponse> UrlAsyncModerationWithOptionsAsync(UrlAsyncModerationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Service))
            {
                query["Service"] = request.Service;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceParameters))
            {
                query["ServiceParameters"] = request.ServiceParameters;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UrlAsyncModeration",
                Version = "2022-03-02",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UrlAsyncModerationResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>The URL asynchronous moderation service detects threats such as fraud, pornography, and gambling in URLs to protect the content ecosystem of your platform.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>The URL asynchronous moderation service supports the pay-as-you-go and resource plan billing methods.</para>
        /// <list type="bullet">
        /// <item><description>After you activate the enhanced edition of Text Moderation, the default billing method is pay-as-you-go. You are charged CNY 30 per 10,000 calls based on your daily usage. No fees are incurred if you do not call the service.</description></item>
        /// <item><description>If you have many moderation requests or relatively fixed moderation requirements, we recommend that you purchase resource plans in advance. The larger the resource plan you purchase, the greater the discount you receive. You can purchase and use multiple resource plans.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// UrlAsyncModerationRequest
        /// </param>
        /// 
        /// <returns>
        /// UrlAsyncModerationResponse
        /// </returns>
        public UrlAsyncModerationResponse UrlAsyncModeration(UrlAsyncModerationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UrlAsyncModerationWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>The URL asynchronous moderation service detects threats such as fraud, pornography, and gambling in URLs to protect the content ecosystem of your platform.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>The URL asynchronous moderation service supports the pay-as-you-go and resource plan billing methods.</para>
        /// <list type="bullet">
        /// <item><description>After you activate the enhanced edition of Text Moderation, the default billing method is pay-as-you-go. You are charged CNY 30 per 10,000 calls based on your daily usage. No fees are incurred if you do not call the service.</description></item>
        /// <item><description>If you have many moderation requests or relatively fixed moderation requirements, we recommend that you purchase resource plans in advance. The larger the resource plan you purchase, the greater the discount you receive. You can purchase and use multiple resource plans.</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// UrlAsyncModerationRequest
        /// </param>
        /// 
        /// <returns>
        /// UrlAsyncModerationResponse
        /// </returns>
        public async Task<UrlAsyncModerationResponse> UrlAsyncModerationAsync(UrlAsyncModerationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UrlAsyncModerationWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>The enhanced video moderation feature of Content Moderation detects threats and non-compliant content in video files. Use this operation to submit a moderation task.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you call this operation, make sure that you have activated the <a href="https://common-buy.aliyun.com/?commodityCode=lvwang_cip_public_cn">enhanced Content Moderation</a> service and understand the <a href="https://help.aliyun.com/document_detail/2505807.html">billing methods</a> and <a href="https://www.aliyun.com/price/product?#/lvwang/detail/cdibag">pricing</a> of the enhanced video moderation feature.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// VideoModerationRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// VideoModerationResponse
        /// </returns>
        public VideoModerationResponse VideoModerationWithOptions(VideoModerationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Service))
            {
                body["Service"] = request.Service;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceParameters))
            {
                body["ServiceParameters"] = request.ServiceParameters;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "VideoModeration",
                Version = "2022-03-02",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<VideoModerationResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>The enhanced video moderation feature of Content Moderation detects threats and non-compliant content in video files. Use this operation to submit a moderation task.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you call this operation, make sure that you have activated the <a href="https://common-buy.aliyun.com/?commodityCode=lvwang_cip_public_cn">enhanced Content Moderation</a> service and understand the <a href="https://help.aliyun.com/document_detail/2505807.html">billing methods</a> and <a href="https://www.aliyun.com/price/product?#/lvwang/detail/cdibag">pricing</a> of the enhanced video moderation feature.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// VideoModerationRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// VideoModerationResponse
        /// </returns>
        public async Task<VideoModerationResponse> VideoModerationWithOptionsAsync(VideoModerationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Service))
            {
                body["Service"] = request.Service;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceParameters))
            {
                body["ServiceParameters"] = request.ServiceParameters;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "VideoModeration",
                Version = "2022-03-02",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<VideoModerationResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>The enhanced video moderation feature of Content Moderation detects threats and non-compliant content in video files. Use this operation to submit a moderation task.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you call this operation, make sure that you have activated the <a href="https://common-buy.aliyun.com/?commodityCode=lvwang_cip_public_cn">enhanced Content Moderation</a> service and understand the <a href="https://help.aliyun.com/document_detail/2505807.html">billing methods</a> and <a href="https://www.aliyun.com/price/product?#/lvwang/detail/cdibag">pricing</a> of the enhanced video moderation feature.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// VideoModerationRequest
        /// </param>
        /// 
        /// <returns>
        /// VideoModerationResponse
        /// </returns>
        public VideoModerationResponse VideoModeration(VideoModerationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return VideoModerationWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>The enhanced video moderation feature of Content Moderation detects threats and non-compliant content in video files. Use this operation to submit a moderation task.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you call this operation, make sure that you have activated the <a href="https://common-buy.aliyun.com/?commodityCode=lvwang_cip_public_cn">enhanced Content Moderation</a> service and understand the <a href="https://help.aliyun.com/document_detail/2505807.html">billing methods</a> and <a href="https://www.aliyun.com/price/product?#/lvwang/detail/cdibag">pricing</a> of the enhanced video moderation feature.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// VideoModerationRequest
        /// </param>
        /// 
        /// <returns>
        /// VideoModerationResponse
        /// </returns>
        public async Task<VideoModerationResponse> VideoModerationAsync(VideoModerationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await VideoModerationWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Cancels an ApsaraVideo Live moderation task.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// VideoModerationCancelRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// VideoModerationCancelResponse
        /// </returns>
        public VideoModerationCancelResponse VideoModerationCancelWithOptions(VideoModerationCancelRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Service))
            {
                body["Service"] = request.Service;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceParameters))
            {
                body["ServiceParameters"] = request.ServiceParameters;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "VideoModerationCancel",
                Version = "2022-03-02",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<VideoModerationCancelResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Cancels an ApsaraVideo Live moderation task.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// VideoModerationCancelRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// VideoModerationCancelResponse
        /// </returns>
        public async Task<VideoModerationCancelResponse> VideoModerationCancelWithOptionsAsync(VideoModerationCancelRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Service))
            {
                body["Service"] = request.Service;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceParameters))
            {
                body["ServiceParameters"] = request.ServiceParameters;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "VideoModerationCancel",
                Version = "2022-03-02",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<VideoModerationCancelResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Cancels an ApsaraVideo Live moderation task.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// VideoModerationCancelRequest
        /// </param>
        /// 
        /// <returns>
        /// VideoModerationCancelResponse
        /// </returns>
        public VideoModerationCancelResponse VideoModerationCancel(VideoModerationCancelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return VideoModerationCancelWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Cancels an ApsaraVideo Live moderation task.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// VideoModerationCancelRequest
        /// </param>
        /// 
        /// <returns>
        /// VideoModerationCancelResponse
        /// </returns>
        public async Task<VideoModerationCancelResponse> VideoModerationCancelAsync(VideoModerationCancelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await VideoModerationCancelWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the task result of an enhanced video content moderation node.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation is not billed. Set the polling interval to 30 seconds (query results 30 seconds after submitting the asynchronous moderation task). The maximum query window is 24 hours. After that, results are automatically deleted.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// VideoModerationResultRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// VideoModerationResultResponse
        /// </returns>
        public VideoModerationResultResponse VideoModerationResultWithOptions(VideoModerationResultRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Service))
            {
                body["Service"] = request.Service;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceParameters))
            {
                body["ServiceParameters"] = request.ServiceParameters;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "VideoModerationResult",
                Version = "2022-03-02",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<VideoModerationResultResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the task result of an enhanced video content moderation node.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation is not billed. Set the polling interval to 30 seconds (query results 30 seconds after submitting the asynchronous moderation task). The maximum query window is 24 hours. After that, results are automatically deleted.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// VideoModerationResultRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// VideoModerationResultResponse
        /// </returns>
        public async Task<VideoModerationResultResponse> VideoModerationResultWithOptionsAsync(VideoModerationResultRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Service))
            {
                body["Service"] = request.Service;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceParameters))
            {
                body["ServiceParameters"] = request.ServiceParameters;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "VideoModerationResult",
                Version = "2022-03-02",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<VideoModerationResultResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the task result of an enhanced video content moderation node.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation is not billed. Set the polling interval to 30 seconds (query results 30 seconds after submitting the asynchronous moderation task). The maximum query window is 24 hours. After that, results are automatically deleted.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// VideoModerationResultRequest
        /// </param>
        /// 
        /// <returns>
        /// VideoModerationResultResponse
        /// </returns>
        public VideoModerationResultResponse VideoModerationResult(VideoModerationResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return VideoModerationResultWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieves the task result of an enhanced video content moderation node.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation is not billed. Set the polling interval to 30 seconds (query results 30 seconds after submitting the asynchronous moderation task). The maximum query window is 24 hours. After that, results are automatically deleted.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// VideoModerationResultRequest
        /// </param>
        /// 
        /// <returns>
        /// VideoModerationResultResponse
        /// </returns>
        public async Task<VideoModerationResultResponse> VideoModerationResultAsync(VideoModerationResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await VideoModerationResultWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Submits a task for enhanced voice moderation.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// VoiceModerationRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// VoiceModerationResponse
        /// </returns>
        public VoiceModerationResponse VoiceModerationWithOptions(VoiceModerationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Service))
            {
                body["Service"] = request.Service;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceParameters))
            {
                body["ServiceParameters"] = request.ServiceParameters;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "VoiceModeration",
                Version = "2022-03-02",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<VoiceModerationResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Submits a task for enhanced voice moderation.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// VoiceModerationRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// VoiceModerationResponse
        /// </returns>
        public async Task<VoiceModerationResponse> VoiceModerationWithOptionsAsync(VoiceModerationRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Service))
            {
                body["Service"] = request.Service;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceParameters))
            {
                body["ServiceParameters"] = request.ServiceParameters;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "VoiceModeration",
                Version = "2022-03-02",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<VoiceModerationResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Submits a task for enhanced voice moderation.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// VoiceModerationRequest
        /// </param>
        /// 
        /// <returns>
        /// VoiceModerationResponse
        /// </returns>
        public VoiceModerationResponse VoiceModeration(VoiceModerationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return VoiceModerationWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Submits a task for enhanced voice moderation.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// VoiceModerationRequest
        /// </param>
        /// 
        /// <returns>
        /// VoiceModerationResponse
        /// </returns>
        public async Task<VoiceModerationResponse> VoiceModerationAsync(VoiceModerationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await VoiceModerationWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>This operation cancels an enhanced voice moderation task.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// VoiceModerationCancelRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// VoiceModerationCancelResponse
        /// </returns>
        public VoiceModerationCancelResponse VoiceModerationCancelWithOptions(VoiceModerationCancelRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Service))
            {
                body["Service"] = request.Service;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceParameters))
            {
                body["ServiceParameters"] = request.ServiceParameters;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "VoiceModerationCancel",
                Version = "2022-03-02",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<VoiceModerationCancelResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>This operation cancels an enhanced voice moderation task.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// VoiceModerationCancelRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// VoiceModerationCancelResponse
        /// </returns>
        public async Task<VoiceModerationCancelResponse> VoiceModerationCancelWithOptionsAsync(VoiceModerationCancelRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Service))
            {
                body["Service"] = request.Service;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceParameters))
            {
                body["ServiceParameters"] = request.ServiceParameters;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "VoiceModerationCancel",
                Version = "2022-03-02",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<VoiceModerationCancelResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>This operation cancels an enhanced voice moderation task.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// VoiceModerationCancelRequest
        /// </param>
        /// 
        /// <returns>
        /// VoiceModerationCancelResponse
        /// </returns>
        public VoiceModerationCancelResponse VoiceModerationCancel(VoiceModerationCancelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return VoiceModerationCancelWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>This operation cancels an enhanced voice moderation task.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// VoiceModerationCancelRequest
        /// </param>
        /// 
        /// <returns>
        /// VoiceModerationCancelResponse
        /// </returns>
        public async Task<VoiceModerationCancelResponse> VoiceModerationCancelAsync(VoiceModerationCancelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await VoiceModerationCancelWithOptionsAsync(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieve the detection results for enhanced voice moderation.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// VoiceModerationResultRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// VoiceModerationResultResponse
        /// </returns>
        public VoiceModerationResultResponse VoiceModerationResultWithOptions(VoiceModerationResultRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Service))
            {
                body["Service"] = request.Service;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceParameters))
            {
                body["ServiceParameters"] = request.ServiceParameters;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "VoiceModerationResult",
                Version = "2022-03-02",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<VoiceModerationResultResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieve the detection results for enhanced voice moderation.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// VoiceModerationResultRequest
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// VoiceModerationResultResponse
        /// </returns>
        public async Task<VoiceModerationResultResponse> VoiceModerationResultWithOptionsAsync(VoiceModerationResultRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Service))
            {
                body["Service"] = request.Service;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ServiceParameters))
            {
                body["ServiceParameters"] = request.ServiceParameters;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "VoiceModerationResult",
                Version = "2022-03-02",
                Protocol = "HTTPS",
                Pathname = "/",
                Method = "POST",
                AuthType = "AK",
                Style = "RPC",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<VoiceModerationResultResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieve the detection results for enhanced voice moderation.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// VoiceModerationResultRequest
        /// </param>
        /// 
        /// <returns>
        /// VoiceModerationResultResponse
        /// </returns>
        public VoiceModerationResultResponse VoiceModerationResult(VoiceModerationResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return VoiceModerationResultWithOptions(request, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Retrieve the detection results for enhanced voice moderation.</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// VoiceModerationResultRequest
        /// </param>
        /// 
        /// <returns>
        /// VoiceModerationResultResponse
        /// </returns>
        public async Task<VoiceModerationResultResponse> VoiceModerationResultAsync(VoiceModerationResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await VoiceModerationResultWithOptionsAsync(request, runtime);
        }

    }
}
