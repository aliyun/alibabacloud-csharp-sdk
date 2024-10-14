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
        /// <para>文档审核结果</para>
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
        /// <para>文档审核结果</para>
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
        /// <para>文档审核结果</para>
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
        /// <para>文档审核结果</para>
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
        /// <para>Obtains the moderation results of an Image Moderation 2.0 task.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  Billing: This operation is free of charge.</para>
        /// <list type="bullet">
        /// <item><description>QPS limit: You can call this operation up to 100 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</description></item>
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
        /// <para>Obtains the moderation results of an Image Moderation 2.0 task.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  Billing: This operation is free of charge.</para>
        /// <list type="bullet">
        /// <item><description>QPS limit: You can call this operation up to 100 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</description></item>
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
        /// <para>Obtains the moderation results of an Image Moderation 2.0 task.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  Billing: This operation is free of charge.</para>
        /// <list type="bullet">
        /// <item><description>QPS limit: You can call this operation up to 100 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</description></item>
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
        /// <para>Obtains the moderation results of an Image Moderation 2.0 task.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  Billing: This operation is free of charge.</para>
        /// <list type="bullet">
        /// <item><description>QPS limit: You can call this operation up to 100 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</description></item>
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
        /// <para>查询检测结果辅助信息</para>
        /// </summary>
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
        /// <para>查询检测结果辅助信息</para>
        /// </summary>
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
        /// <para>查询检测结果辅助信息</para>
        /// </summary>
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
        /// <para>查询检测结果辅助信息</para>
        /// </summary>
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
        /// <para>查询上传token</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeUploadTokenRequest
        /// </param>
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
        /// <para>查询上传token</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DescribeUploadTokenRequest
        /// </param>
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
        /// <para>查询上传token</para>
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
        /// <para>查询上传token</para>
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
        /// <para>Queries the moderation results based on the ReqId returned by asynchronous URL moderation.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  Billing: This operation is free of charge.</para>
        /// <list type="bullet">
        /// <item><description>Query timeout: We recommend that you query moderation results at least 480 seconds after you send an asynchronous moderation request. Content Moderation retains moderation results for up to 3 days. After 3 days, the results are deleted.</description></item>
        /// <item><description>You can call this operation up to 100 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</description></item>
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
        /// <para>Queries the moderation results based on the ReqId returned by asynchronous URL moderation.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  Billing: This operation is free of charge.</para>
        /// <list type="bullet">
        /// <item><description>Query timeout: We recommend that you query moderation results at least 480 seconds after you send an asynchronous moderation request. Content Moderation retains moderation results for up to 3 days. After 3 days, the results are deleted.</description></item>
        /// <item><description>You can call this operation up to 100 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</description></item>
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
        /// <para>Queries the moderation results based on the ReqId returned by asynchronous URL moderation.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  Billing: This operation is free of charge.</para>
        /// <list type="bullet">
        /// <item><description>Query timeout: We recommend that you query moderation results at least 480 seconds after you send an asynchronous moderation request. Content Moderation retains moderation results for up to 3 days. After 3 days, the results are deleted.</description></item>
        /// <item><description>You can call this operation up to 100 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</description></item>
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
        /// <para>Queries the moderation results based on the ReqId returned by asynchronous URL moderation.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>  Billing: This operation is free of charge.</para>
        /// <list type="bullet">
        /// <item><description>Query timeout: We recommend that you query moderation results at least 480 seconds after you send an asynchronous moderation request. Content Moderation retains moderation results for up to 3 days. After 3 days, the results are deleted.</description></item>
        /// <item><description>You can call this operation up to 100 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.</description></item>
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
        /// <para>文档审核</para>
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
        /// <para>文档审核</para>
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
        /// <para>文档审核</para>
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
        /// <para>文档审核</para>
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
        /// <para>图片异步检测</para>
        /// </summary>
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
        /// <para>图片异步检测</para>
        /// </summary>
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
        /// <para>图片异步检测</para>
        /// </summary>
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
        /// <para>图片异步检测</para>
        /// </summary>
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
        /// <para>Identifies whether an image contains content or elements that violate relevant regulations on network content dissemination, affect the content order of a specific platform, or affect user experience. Image Moderation 2.0 supports over 90 content risk labels and over 100 risk control items. Image Moderation 2.0 of Content Moderation allows you to develop further moderation or governance measures for specific image content based on business scenarios, platform-specific content governance rules, or rich risk labels and scores of confidence levels returned by API calls.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>*Before you call this operation, make sure that you are familiar with the <a href="https://help.aliyun.com/document_detail/467826.html">billing</a><a href="https://www.aliyun.com/price/product?#/lvwang/detail/cdibag"></a> of Image Moderation 2.0.</para>
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
        /// <para>Identifies whether an image contains content or elements that violate relevant regulations on network content dissemination, affect the content order of a specific platform, or affect user experience. Image Moderation 2.0 supports over 90 content risk labels and over 100 risk control items. Image Moderation 2.0 of Content Moderation allows you to develop further moderation or governance measures for specific image content based on business scenarios, platform-specific content governance rules, or rich risk labels and scores of confidence levels returned by API calls.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>*Before you call this operation, make sure that you are familiar with the <a href="https://help.aliyun.com/document_detail/467826.html">billing</a><a href="https://www.aliyun.com/price/product?#/lvwang/detail/cdibag"></a> of Image Moderation 2.0.</para>
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
        /// <para>Identifies whether an image contains content or elements that violate relevant regulations on network content dissemination, affect the content order of a specific platform, or affect user experience. Image Moderation 2.0 supports over 90 content risk labels and over 100 risk control items. Image Moderation 2.0 of Content Moderation allows you to develop further moderation or governance measures for specific image content based on business scenarios, platform-specific content governance rules, or rich risk labels and scores of confidence levels returned by API calls.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>*Before you call this operation, make sure that you are familiar with the <a href="https://help.aliyun.com/document_detail/467826.html">billing</a><a href="https://www.aliyun.com/price/product?#/lvwang/detail/cdibag"></a> of Image Moderation 2.0.</para>
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
        /// <para>Identifies whether an image contains content or elements that violate relevant regulations on network content dissemination, affect the content order of a specific platform, or affect user experience. Image Moderation 2.0 supports over 90 content risk labels and over 100 risk control items. Image Moderation 2.0 of Content Moderation allows you to develop further moderation or governance measures for specific image content based on business scenarios, platform-specific content governance rules, or rich risk labels and scores of confidence levels returned by API calls.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>*Before you call this operation, make sure that you are familiar with the <a href="https://help.aliyun.com/document_detail/467826.html">billing</a><a href="https://www.aliyun.com/price/product?#/lvwang/detail/cdibag"></a> of Image Moderation 2.0.</para>
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
        /// <para>文本审核</para>
        /// </summary>
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
        /// <para>文本审核</para>
        /// </summary>
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
        /// <para>文本审核</para>
        /// </summary>
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
        /// <para>文本审核</para>
        /// </summary>
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
        /// <para>Moderates the input command and generated text of large language models (LLMs). Specific model input commands can be used to retrieve standard answers. The feature of enabling and disabling the moderation labels is also available.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you call this operation, make sure that you have <a href="https://common-buy.aliyun.com/?commodityCode=lvwang_cip_public_cn">activated the Content Moderation 2.0 service</a> and are familiar with the <a href="https://help.aliyun.com/document_detail/2671445.html?#section-6od-32j-99n">billing</a> of the Text Moderation 2.0 Plus service.</para>
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
        /// <para>Moderates the input command and generated text of large language models (LLMs). Specific model input commands can be used to retrieve standard answers. The feature of enabling and disabling the moderation labels is also available.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you call this operation, make sure that you have <a href="https://common-buy.aliyun.com/?commodityCode=lvwang_cip_public_cn">activated the Content Moderation 2.0 service</a> and are familiar with the <a href="https://help.aliyun.com/document_detail/2671445.html?#section-6od-32j-99n">billing</a> of the Text Moderation 2.0 Plus service.</para>
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
        /// <para>Moderates the input command and generated text of large language models (LLMs). Specific model input commands can be used to retrieve standard answers. The feature of enabling and disabling the moderation labels is also available.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you call this operation, make sure that you have <a href="https://common-buy.aliyun.com/?commodityCode=lvwang_cip_public_cn">activated the Content Moderation 2.0 service</a> and are familiar with the <a href="https://help.aliyun.com/document_detail/2671445.html?#section-6od-32j-99n">billing</a> of the Text Moderation 2.0 Plus service.</para>
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
        /// <para>Moderates the input command and generated text of large language models (LLMs). Specific model input commands can be used to retrieve standard answers. The feature of enabling and disabling the moderation labels is also available.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Before you call this operation, make sure that you have <a href="https://common-buy.aliyun.com/?commodityCode=lvwang_cip_public_cn">activated the Content Moderation 2.0 service</a> and are familiar with the <a href="https://help.aliyun.com/document_detail/2671445.html?#section-6od-32j-99n">billing</a> of the Text Moderation 2.0 Plus service.</para>
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
        /// <para>url异步检测</para>
        /// </summary>
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
        /// <para>url异步检测</para>
        /// </summary>
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
        /// <para>url异步检测</para>
        /// </summary>
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
        /// <para>url异步检测</para>
        /// </summary>
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
        /// <para>视频检测任务提交</para>
        /// </summary>
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
        /// <para>视频检测任务提交</para>
        /// </summary>
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
        /// <para>视频检测任务提交</para>
        /// </summary>
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
        /// <para>视频检测任务提交</para>
        /// </summary>
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
        /// <para>取消视频直播流检测</para>
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
        /// <para>取消视频直播流检测</para>
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
        /// <para>取消视频直播流检测</para>
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
        /// <para>取消视频直播流检测</para>
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
        /// <para>Obtains the moderation results of a Video Moderation 2.0 task</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation is free of charge. We recommend that you query moderation results at least 30 seconds after you send an asynchronous moderation request. Content Moderation retains moderation results for at most 24 hours. After 24 hours, the results are deleted.</para>
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
        /// <para>Obtains the moderation results of a Video Moderation 2.0 task</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation is free of charge. We recommend that you query moderation results at least 30 seconds after you send an asynchronous moderation request. Content Moderation retains moderation results for at most 24 hours. After 24 hours, the results are deleted.</para>
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
        /// <para>Obtains the moderation results of a Video Moderation 2.0 task</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation is free of charge. We recommend that you query moderation results at least 30 seconds after you send an asynchronous moderation request. Content Moderation retains moderation results for at most 24 hours. After 24 hours, the results are deleted.</para>
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
        /// <para>Obtains the moderation results of a Video Moderation 2.0 task</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>This operation is free of charge. We recommend that you query moderation results at least 30 seconds after you send an asynchronous moderation request. Content Moderation retains moderation results for at most 24 hours. After 24 hours, the results are deleted.</para>
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
        /// <para>语音审核</para>
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
        /// <para>语音审核</para>
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
        /// <para>语音审核</para>
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
        /// <para>语音审核</para>
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
        /// <para>取消检测</para>
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
        /// <para>取消检测</para>
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
        /// <para>取消检测</para>
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
        /// <para>取消检测</para>
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
        /// <para>语音检测结果获取接口</para>
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
        /// <para>语音检测结果获取接口</para>
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
        /// <para>语音检测结果获取接口</para>
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
        /// <para>语音检测结果获取接口</para>
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
