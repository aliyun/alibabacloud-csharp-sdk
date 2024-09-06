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

        /**
         * @summary 文档审核结果
         *
         * @param request DescribeFileModerationResultRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeFileModerationResultResponse
         */
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

        /**
         * @summary 文档审核结果
         *
         * @param request DescribeFileModerationResultRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeFileModerationResultResponse
         */
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

        /**
         * @summary 文档审核结果
         *
         * @param request DescribeFileModerationResultRequest
         * @return DescribeFileModerationResultResponse
         */
        public DescribeFileModerationResultResponse DescribeFileModerationResult(DescribeFileModerationResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeFileModerationResultWithOptions(request, runtime);
        }

        /**
         * @summary 文档审核结果
         *
         * @param request DescribeFileModerationResultRequest
         * @return DescribeFileModerationResultResponse
         */
        public async Task<DescribeFileModerationResultResponse> DescribeFileModerationResultAsync(DescribeFileModerationResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeFileModerationResultWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Obtains the moderation results of an Image Moderation 2.0 task.
         *
         * @description *   Billing: This operation is free of charge.
         * *   QPS limit: You can call this operation up to 100 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request DescribeImageModerationResultRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeImageModerationResultResponse
         */
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

        /**
         * @summary Obtains the moderation results of an Image Moderation 2.0 task.
         *
         * @description *   Billing: This operation is free of charge.
         * *   QPS limit: You can call this operation up to 100 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request DescribeImageModerationResultRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeImageModerationResultResponse
         */
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

        /**
         * @summary Obtains the moderation results of an Image Moderation 2.0 task.
         *
         * @description *   Billing: This operation is free of charge.
         * *   QPS limit: You can call this operation up to 100 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request DescribeImageModerationResultRequest
         * @return DescribeImageModerationResultResponse
         */
        public DescribeImageModerationResultResponse DescribeImageModerationResult(DescribeImageModerationResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeImageModerationResultWithOptions(request, runtime);
        }

        /**
         * @summary Obtains the moderation results of an Image Moderation 2.0 task.
         *
         * @description *   Billing: This operation is free of charge.
         * *   QPS limit: You can call this operation up to 100 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request DescribeImageModerationResultRequest
         * @return DescribeImageModerationResultResponse
         */
        public async Task<DescribeImageModerationResultResponse> DescribeImageModerationResultAsync(DescribeImageModerationResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeImageModerationResultWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 查询检测结果辅助信息
         *
         * @param request DescribeImageResultExtRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeImageResultExtResponse
         */
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

        /**
         * @summary 查询检测结果辅助信息
         *
         * @param request DescribeImageResultExtRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeImageResultExtResponse
         */
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

        /**
         * @summary 查询检测结果辅助信息
         *
         * @param request DescribeImageResultExtRequest
         * @return DescribeImageResultExtResponse
         */
        public DescribeImageResultExtResponse DescribeImageResultExt(DescribeImageResultExtRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeImageResultExtWithOptions(request, runtime);
        }

        /**
         * @summary 查询检测结果辅助信息
         *
         * @param request DescribeImageResultExtRequest
         * @return DescribeImageResultExtResponse
         */
        public async Task<DescribeImageResultExtResponse> DescribeImageResultExtAsync(DescribeImageResultExtRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeImageResultExtWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 查询上传token
         *
         * @param request DescribeUploadTokenRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeUploadTokenResponse
         */
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

        /**
         * @summary 查询上传token
         *
         * @param request DescribeUploadTokenRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeUploadTokenResponse
         */
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

        /**
         * @summary 查询上传token
         *
         * @return DescribeUploadTokenResponse
         */
        public DescribeUploadTokenResponse DescribeUploadToken()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeUploadTokenWithOptions(runtime);
        }

        /**
         * @summary 查询上传token
         *
         * @return DescribeUploadTokenResponse
         */
        public async Task<DescribeUploadTokenResponse> DescribeUploadTokenAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeUploadTokenWithOptionsAsync(runtime);
        }

        /**
         * @summary Queries the moderation results based on the ReqId returned by asynchronous URL moderation.
         *
         * @description *   Billing: This operation is free of charge.
         * *   Query timeout: We recommend that you query moderation results at least 480 seconds after you send an asynchronous moderation request. Content Moderation retains moderation results for up to 3 days. After 3 days, the results are deleted.
         * *   You can call this operation up to 100 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request DescribeUrlModerationResultRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeUrlModerationResultResponse
         */
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

        /**
         * @summary Queries the moderation results based on the ReqId returned by asynchronous URL moderation.
         *
         * @description *   Billing: This operation is free of charge.
         * *   Query timeout: We recommend that you query moderation results at least 480 seconds after you send an asynchronous moderation request. Content Moderation retains moderation results for up to 3 days. After 3 days, the results are deleted.
         * *   You can call this operation up to 100 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request DescribeUrlModerationResultRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return DescribeUrlModerationResultResponse
         */
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

        /**
         * @summary Queries the moderation results based on the ReqId returned by asynchronous URL moderation.
         *
         * @description *   Billing: This operation is free of charge.
         * *   Query timeout: We recommend that you query moderation results at least 480 seconds after you send an asynchronous moderation request. Content Moderation retains moderation results for up to 3 days. After 3 days, the results are deleted.
         * *   You can call this operation up to 100 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request DescribeUrlModerationResultRequest
         * @return DescribeUrlModerationResultResponse
         */
        public DescribeUrlModerationResultResponse DescribeUrlModerationResult(DescribeUrlModerationResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DescribeUrlModerationResultWithOptions(request, runtime);
        }

        /**
         * @summary Queries the moderation results based on the ReqId returned by asynchronous URL moderation.
         *
         * @description *   Billing: This operation is free of charge.
         * *   Query timeout: We recommend that you query moderation results at least 480 seconds after you send an asynchronous moderation request. Content Moderation retains moderation results for up to 3 days. After 3 days, the results are deleted.
         * *   You can call this operation up to 100 times per second per account. If the number of the calls per second exceeds the limit, throttling is triggered. As a result, your business may be affected. We recommend that you take note of the limit when you call this operation.
         *
         * @param request DescribeUrlModerationResultRequest
         * @return DescribeUrlModerationResultResponse
         */
        public async Task<DescribeUrlModerationResultResponse> DescribeUrlModerationResultAsync(DescribeUrlModerationResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DescribeUrlModerationResultWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 文档审核
         *
         * @param request FileModerationRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return FileModerationResponse
         */
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

        /**
         * @summary 文档审核
         *
         * @param request FileModerationRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return FileModerationResponse
         */
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

        /**
         * @summary 文档审核
         *
         * @param request FileModerationRequest
         * @return FileModerationResponse
         */
        public FileModerationResponse FileModeration(FileModerationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return FileModerationWithOptions(request, runtime);
        }

        /**
         * @summary 文档审核
         *
         * @param request FileModerationRequest
         * @return FileModerationResponse
         */
        public async Task<FileModerationResponse> FileModerationAsync(FileModerationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await FileModerationWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 图片异步检测
         *
         * @param request ImageAsyncModerationRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ImageAsyncModerationResponse
         */
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

        /**
         * @summary 图片异步检测
         *
         * @param request ImageAsyncModerationRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ImageAsyncModerationResponse
         */
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

        /**
         * @summary 图片异步检测
         *
         * @param request ImageAsyncModerationRequest
         * @return ImageAsyncModerationResponse
         */
        public ImageAsyncModerationResponse ImageAsyncModeration(ImageAsyncModerationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ImageAsyncModerationWithOptions(request, runtime);
        }

        /**
         * @summary 图片异步检测
         *
         * @param request ImageAsyncModerationRequest
         * @return ImageAsyncModerationResponse
         */
        public async Task<ImageAsyncModerationResponse> ImageAsyncModerationAsync(ImageAsyncModerationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ImageAsyncModerationWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Identifies whether an image contains content or elements that violate relevant regulations on network content dissemination, affect the content order of a specific platform, or affect user experience. Image Moderation 2.0 supports over 90 content risk labels and over 100 risk control items. Image Moderation 2.0 of Content Moderation allows you to develop further moderation or governance measures for specific image content based on business scenarios, platform-specific content governance rules, or rich risk labels and scores of confidence levels returned by API calls.
         *
         * @description **Before you call this operation, make sure that you are familiar with the [billing](https://help.aliyun.com/document_detail/467826.html)[](https://www.aliyun.com/price/product?#/lvwang/detail/cdibag) of Image Moderation 2.0.
         *
         * @param request ImageModerationRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ImageModerationResponse
         */
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

        /**
         * @summary Identifies whether an image contains content or elements that violate relevant regulations on network content dissemination, affect the content order of a specific platform, or affect user experience. Image Moderation 2.0 supports over 90 content risk labels and over 100 risk control items. Image Moderation 2.0 of Content Moderation allows you to develop further moderation or governance measures for specific image content based on business scenarios, platform-specific content governance rules, or rich risk labels and scores of confidence levels returned by API calls.
         *
         * @description **Before you call this operation, make sure that you are familiar with the [billing](https://help.aliyun.com/document_detail/467826.html)[](https://www.aliyun.com/price/product?#/lvwang/detail/cdibag) of Image Moderation 2.0.
         *
         * @param request ImageModerationRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return ImageModerationResponse
         */
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

        /**
         * @summary Identifies whether an image contains content or elements that violate relevant regulations on network content dissemination, affect the content order of a specific platform, or affect user experience. Image Moderation 2.0 supports over 90 content risk labels and over 100 risk control items. Image Moderation 2.0 of Content Moderation allows you to develop further moderation or governance measures for specific image content based on business scenarios, platform-specific content governance rules, or rich risk labels and scores of confidence levels returned by API calls.
         *
         * @description **Before you call this operation, make sure that you are familiar with the [billing](https://help.aliyun.com/document_detail/467826.html)[](https://www.aliyun.com/price/product?#/lvwang/detail/cdibag) of Image Moderation 2.0.
         *
         * @param request ImageModerationRequest
         * @return ImageModerationResponse
         */
        public ImageModerationResponse ImageModeration(ImageModerationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ImageModerationWithOptions(request, runtime);
        }

        /**
         * @summary Identifies whether an image contains content or elements that violate relevant regulations on network content dissemination, affect the content order of a specific platform, or affect user experience. Image Moderation 2.0 supports over 90 content risk labels and over 100 risk control items. Image Moderation 2.0 of Content Moderation allows you to develop further moderation or governance measures for specific image content based on business scenarios, platform-specific content governance rules, or rich risk labels and scores of confidence levels returned by API calls.
         *
         * @description **Before you call this operation, make sure that you are familiar with the [billing](https://help.aliyun.com/document_detail/467826.html)[](https://www.aliyun.com/price/product?#/lvwang/detail/cdibag) of Image Moderation 2.0.
         *
         * @param request ImageModerationRequest
         * @return ImageModerationResponse
         */
        public async Task<ImageModerationResponse> ImageModerationAsync(ImageModerationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ImageModerationWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 文本审核
         *
         * @param request TextModerationRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return TextModerationResponse
         */
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

        /**
         * @summary 文本审核
         *
         * @param request TextModerationRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return TextModerationResponse
         */
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

        /**
         * @summary 文本审核
         *
         * @param request TextModerationRequest
         * @return TextModerationResponse
         */
        public TextModerationResponse TextModeration(TextModerationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return TextModerationWithOptions(request, runtime);
        }

        /**
         * @summary 文本审核
         *
         * @param request TextModerationRequest
         * @return TextModerationResponse
         */
        public async Task<TextModerationResponse> TextModerationAsync(TextModerationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await TextModerationWithOptionsAsync(request, runtime);
        }

        /**
         * @summary Moderates the input command and generated text of large language models (LLMs). Specific model input commands can be used to retrieve standard answers. The feature of enabling and disabling the moderation labels is also available.
         *
         * @description Before you call this operation, make sure that you have [activated the Content Moderation 2.0 service](https://common-buy.aliyun.com/?commodityCode=lvwang_cip_public_cn) and are familiar with the [billing](https://help.aliyun.com/document_detail/2671445.html?#section-6od-32j-99n) of the Text Moderation 2.0 Plus service.
         *
         * @param request TextModerationPlusRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return TextModerationPlusResponse
         */
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

        /**
         * @summary Moderates the input command and generated text of large language models (LLMs). Specific model input commands can be used to retrieve standard answers. The feature of enabling and disabling the moderation labels is also available.
         *
         * @description Before you call this operation, make sure that you have [activated the Content Moderation 2.0 service](https://common-buy.aliyun.com/?commodityCode=lvwang_cip_public_cn) and are familiar with the [billing](https://help.aliyun.com/document_detail/2671445.html?#section-6od-32j-99n) of the Text Moderation 2.0 Plus service.
         *
         * @param request TextModerationPlusRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return TextModerationPlusResponse
         */
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

        /**
         * @summary Moderates the input command and generated text of large language models (LLMs). Specific model input commands can be used to retrieve standard answers. The feature of enabling and disabling the moderation labels is also available.
         *
         * @description Before you call this operation, make sure that you have [activated the Content Moderation 2.0 service](https://common-buy.aliyun.com/?commodityCode=lvwang_cip_public_cn) and are familiar with the [billing](https://help.aliyun.com/document_detail/2671445.html?#section-6od-32j-99n) of the Text Moderation 2.0 Plus service.
         *
         * @param request TextModerationPlusRequest
         * @return TextModerationPlusResponse
         */
        public TextModerationPlusResponse TextModerationPlus(TextModerationPlusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return TextModerationPlusWithOptions(request, runtime);
        }

        /**
         * @summary Moderates the input command and generated text of large language models (LLMs). Specific model input commands can be used to retrieve standard answers. The feature of enabling and disabling the moderation labels is also available.
         *
         * @description Before you call this operation, make sure that you have [activated the Content Moderation 2.0 service](https://common-buy.aliyun.com/?commodityCode=lvwang_cip_public_cn) and are familiar with the [billing](https://help.aliyun.com/document_detail/2671445.html?#section-6od-32j-99n) of the Text Moderation 2.0 Plus service.
         *
         * @param request TextModerationPlusRequest
         * @return TextModerationPlusResponse
         */
        public async Task<TextModerationPlusResponse> TextModerationPlusAsync(TextModerationPlusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await TextModerationPlusWithOptionsAsync(request, runtime);
        }

        /**
         * @summary url异步检测
         *
         * @param request UrlAsyncModerationRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UrlAsyncModerationResponse
         */
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

        /**
         * @summary url异步检测
         *
         * @param request UrlAsyncModerationRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return UrlAsyncModerationResponse
         */
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

        /**
         * @summary url异步检测
         *
         * @param request UrlAsyncModerationRequest
         * @return UrlAsyncModerationResponse
         */
        public UrlAsyncModerationResponse UrlAsyncModeration(UrlAsyncModerationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UrlAsyncModerationWithOptions(request, runtime);
        }

        /**
         * @summary url异步检测
         *
         * @param request UrlAsyncModerationRequest
         * @return UrlAsyncModerationResponse
         */
        public async Task<UrlAsyncModerationResponse> UrlAsyncModerationAsync(UrlAsyncModerationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UrlAsyncModerationWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 视频检测任务提交
         *
         * @param request VideoModerationRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return VideoModerationResponse
         */
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

        /**
         * @summary 视频检测任务提交
         *
         * @param request VideoModerationRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return VideoModerationResponse
         */
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

        /**
         * @summary 视频检测任务提交
         *
         * @param request VideoModerationRequest
         * @return VideoModerationResponse
         */
        public VideoModerationResponse VideoModeration(VideoModerationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return VideoModerationWithOptions(request, runtime);
        }

        /**
         * @summary 视频检测任务提交
         *
         * @param request VideoModerationRequest
         * @return VideoModerationResponse
         */
        public async Task<VideoModerationResponse> VideoModerationAsync(VideoModerationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await VideoModerationWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 取消视频直播流检测
         *
         * @param request VideoModerationCancelRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return VideoModerationCancelResponse
         */
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

        /**
         * @summary 取消视频直播流检测
         *
         * @param request VideoModerationCancelRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return VideoModerationCancelResponse
         */
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

        /**
         * @summary 取消视频直播流检测
         *
         * @param request VideoModerationCancelRequest
         * @return VideoModerationCancelResponse
         */
        public VideoModerationCancelResponse VideoModerationCancel(VideoModerationCancelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return VideoModerationCancelWithOptions(request, runtime);
        }

        /**
         * @summary 取消视频直播流检测
         *
         * @param request VideoModerationCancelRequest
         * @return VideoModerationCancelResponse
         */
        public async Task<VideoModerationCancelResponse> VideoModerationCancelAsync(VideoModerationCancelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await VideoModerationCancelWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 获取视频检测结果
         *
         * @param request VideoModerationResultRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return VideoModerationResultResponse
         */
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

        /**
         * @summary 获取视频检测结果
         *
         * @param request VideoModerationResultRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return VideoModerationResultResponse
         */
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

        /**
         * @summary 获取视频检测结果
         *
         * @param request VideoModerationResultRequest
         * @return VideoModerationResultResponse
         */
        public VideoModerationResultResponse VideoModerationResult(VideoModerationResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return VideoModerationResultWithOptions(request, runtime);
        }

        /**
         * @summary 获取视频检测结果
         *
         * @param request VideoModerationResultRequest
         * @return VideoModerationResultResponse
         */
        public async Task<VideoModerationResultResponse> VideoModerationResultAsync(VideoModerationResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await VideoModerationResultWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 语音审核
         *
         * @param request VoiceModerationRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return VoiceModerationResponse
         */
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

        /**
         * @summary 语音审核
         *
         * @param request VoiceModerationRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return VoiceModerationResponse
         */
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

        /**
         * @summary 语音审核
         *
         * @param request VoiceModerationRequest
         * @return VoiceModerationResponse
         */
        public VoiceModerationResponse VoiceModeration(VoiceModerationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return VoiceModerationWithOptions(request, runtime);
        }

        /**
         * @summary 语音审核
         *
         * @param request VoiceModerationRequest
         * @return VoiceModerationResponse
         */
        public async Task<VoiceModerationResponse> VoiceModerationAsync(VoiceModerationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await VoiceModerationWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 取消检测
         *
         * @param request VoiceModerationCancelRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return VoiceModerationCancelResponse
         */
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

        /**
         * @summary 取消检测
         *
         * @param request VoiceModerationCancelRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return VoiceModerationCancelResponse
         */
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

        /**
         * @summary 取消检测
         *
         * @param request VoiceModerationCancelRequest
         * @return VoiceModerationCancelResponse
         */
        public VoiceModerationCancelResponse VoiceModerationCancel(VoiceModerationCancelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return VoiceModerationCancelWithOptions(request, runtime);
        }

        /**
         * @summary 取消检测
         *
         * @param request VoiceModerationCancelRequest
         * @return VoiceModerationCancelResponse
         */
        public async Task<VoiceModerationCancelResponse> VoiceModerationCancelAsync(VoiceModerationCancelRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await VoiceModerationCancelWithOptionsAsync(request, runtime);
        }

        /**
         * @summary 语音检测结果获取接口
         *
         * @param request VoiceModerationResultRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return VoiceModerationResultResponse
         */
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

        /**
         * @summary 语音检测结果获取接口
         *
         * @param request VoiceModerationResultRequest
         * @param runtime runtime options for this request RuntimeOptions
         * @return VoiceModerationResultResponse
         */
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

        /**
         * @summary 语音检测结果获取接口
         *
         * @param request VoiceModerationResultRequest
         * @return VoiceModerationResultResponse
         */
        public VoiceModerationResultResponse VoiceModerationResult(VoiceModerationResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return VoiceModerationResultWithOptions(request, runtime);
        }

        /**
         * @summary 语音检测结果获取接口
         *
         * @param request VoiceModerationResultRequest
         * @return VoiceModerationResultResponse
         */
        public async Task<VoiceModerationResultResponse> VoiceModerationResultAsync(VoiceModerationResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await VoiceModerationResultWithOptionsAsync(request, runtime);
        }

    }
}
