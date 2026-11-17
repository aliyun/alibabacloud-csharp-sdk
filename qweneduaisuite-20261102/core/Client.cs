// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.QwenEduAiSuite20261102.Models;

namespace AlibabaCloud.SDK.QwenEduAiSuite20261102
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._productId = "QwenEduAiSuite";
            AlibabaCloud.GatewayPop.Client gatewayClient = new AlibabaCloud.GatewayPop.Client();
            this._spi = gatewayClient;
            this._endpointRule = "";
            CheckConfig(config);
            this._endpoint = GetEndpoint("qweneduaisuite", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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
        /// <para>开通千问教育API权限</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>开通千问教育API权限</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ActivateQwenEduApiRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ActivateQwenEduApiResponse
        /// </returns>
        public ActivateQwenEduApiResponse ActivateQwenEduApiWithOptions(ActivateQwenEduApiRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ActivateQwenEduApi",
                Version = "2026-11-02",
                Protocol = "HTTPS",
                Pathname = "/v1/service/activate",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ActivateQwenEduApiResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>开通千问教育API权限</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>开通千问教育API权限</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ActivateQwenEduApiRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ActivateQwenEduApiResponse
        /// </returns>
        public async Task<ActivateQwenEduApiResponse> ActivateQwenEduApiWithOptionsAsync(ActivateQwenEduApiRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ActivateQwenEduApi",
                Version = "2026-11-02",
                Protocol = "HTTPS",
                Pathname = "/v1/service/activate",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ActivateQwenEduApiResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>开通千问教育API权限</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>开通千问教育API权限</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ActivateQwenEduApiRequest
        /// </param>
        /// 
        /// <returns>
        /// ActivateQwenEduApiResponse
        /// </returns>
        public ActivateQwenEduApiResponse ActivateQwenEduApi(ActivateQwenEduApiRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ActivateQwenEduApiWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>开通千问教育API权限</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>开通千问教育API权限</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ActivateQwenEduApiRequest
        /// </param>
        /// 
        /// <returns>
        /// ActivateQwenEduApiResponse
        /// </returns>
        public async Task<ActivateQwenEduApiResponse> ActivateQwenEduApiAsync(ActivateQwenEduApiRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ActivateQwenEduApiWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>提交单页作业图片，返回任务ID及初步检测结果。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>该接口用于提交单页作业图片进行批改，支持通过图片URL或Base64编码的图片数据。</description></item>
        /// <item><description>提交后会立即返回任务ID、矫正图及题目检测结果，但不包含具体的批改结论。</description></item>
        /// <item><description>需要通过查询接口轮询获取最终的批改结果。</description></item>
        /// <item><description>支持对图片进行透视矫正，默认开启。</description></item>
        /// <item><description>图片要求：支持多种格式（JPEG, PNG, GIF等），推荐体积不超过1MB，最大支持15MB（Base64编码后）。</description></item>
        /// <item><description>每次请求仅处理一张图片，多张图片需分别提交。</description></item>
        /// <item><description><c>request_id</c>字段建议由调用方生成并传递，以便于问题排查和对账。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateEduHomeworkCorrectSubmitRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateEduHomeworkCorrectSubmitResponse
        /// </returns>
        public CreateEduHomeworkCorrectSubmitResponse CreateEduHomeworkCorrectSubmitWithOptions(CreateEduHomeworkCorrectSubmitRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Dewarp))
            {
                body["dewarp"] = request.Dewarp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageBase64))
            {
                body["imageBase64"] = request.ImageBase64;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageUrl))
            {
                body["imageUrl"] = request.ImageUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RequestId))
            {
                body["requestId"] = request.RequestId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateEduHomeworkCorrectSubmit",
                Version = "2026-11-02",
                Protocol = "HTTPS",
                Pathname = "/v1/homework/correct/submit",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateEduHomeworkCorrectSubmitResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>提交单页作业图片，返回任务ID及初步检测结果。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>该接口用于提交单页作业图片进行批改，支持通过图片URL或Base64编码的图片数据。</description></item>
        /// <item><description>提交后会立即返回任务ID、矫正图及题目检测结果，但不包含具体的批改结论。</description></item>
        /// <item><description>需要通过查询接口轮询获取最终的批改结果。</description></item>
        /// <item><description>支持对图片进行透视矫正，默认开启。</description></item>
        /// <item><description>图片要求：支持多种格式（JPEG, PNG, GIF等），推荐体积不超过1MB，最大支持15MB（Base64编码后）。</description></item>
        /// <item><description>每次请求仅处理一张图片，多张图片需分别提交。</description></item>
        /// <item><description><c>request_id</c>字段建议由调用方生成并传递，以便于问题排查和对账。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateEduHomeworkCorrectSubmitRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateEduHomeworkCorrectSubmitResponse
        /// </returns>
        public async Task<CreateEduHomeworkCorrectSubmitResponse> CreateEduHomeworkCorrectSubmitWithOptionsAsync(CreateEduHomeworkCorrectSubmitRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Dewarp))
            {
                body["dewarp"] = request.Dewarp;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageBase64))
            {
                body["imageBase64"] = request.ImageBase64;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ImageUrl))
            {
                body["imageUrl"] = request.ImageUrl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RequestId))
            {
                body["requestId"] = request.RequestId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateEduHomeworkCorrectSubmit",
                Version = "2026-11-02",
                Protocol = "HTTPS",
                Pathname = "/v1/homework/correct/submit",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateEduHomeworkCorrectSubmitResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>提交单页作业图片，返回任务ID及初步检测结果。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>该接口用于提交单页作业图片进行批改，支持通过图片URL或Base64编码的图片数据。</description></item>
        /// <item><description>提交后会立即返回任务ID、矫正图及题目检测结果，但不包含具体的批改结论。</description></item>
        /// <item><description>需要通过查询接口轮询获取最终的批改结果。</description></item>
        /// <item><description>支持对图片进行透视矫正，默认开启。</description></item>
        /// <item><description>图片要求：支持多种格式（JPEG, PNG, GIF等），推荐体积不超过1MB，最大支持15MB（Base64编码后）。</description></item>
        /// <item><description>每次请求仅处理一张图片，多张图片需分别提交。</description></item>
        /// <item><description><c>request_id</c>字段建议由调用方生成并传递，以便于问题排查和对账。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateEduHomeworkCorrectSubmitRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateEduHomeworkCorrectSubmitResponse
        /// </returns>
        public CreateEduHomeworkCorrectSubmitResponse CreateEduHomeworkCorrectSubmit(CreateEduHomeworkCorrectSubmitRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateEduHomeworkCorrectSubmitWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>提交单页作业图片，返回任务ID及初步检测结果。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>该接口用于提交单页作业图片进行批改，支持通过图片URL或Base64编码的图片数据。</description></item>
        /// <item><description>提交后会立即返回任务ID、矫正图及题目检测结果，但不包含具体的批改结论。</description></item>
        /// <item><description>需要通过查询接口轮询获取最终的批改结果。</description></item>
        /// <item><description>支持对图片进行透视矫正，默认开启。</description></item>
        /// <item><description>图片要求：支持多种格式（JPEG, PNG, GIF等），推荐体积不超过1MB，最大支持15MB（Base64编码后）。</description></item>
        /// <item><description>每次请求仅处理一张图片，多张图片需分别提交。</description></item>
        /// <item><description><c>request_id</c>字段建议由调用方生成并传递，以便于问题排查和对账。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateEduHomeworkCorrectSubmitRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateEduHomeworkCorrectSubmitResponse
        /// </returns>
        public async Task<CreateEduHomeworkCorrectSubmitResponse> CreateEduHomeworkCorrectSubmitAsync(CreateEduHomeworkCorrectSubmitRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateEduHomeworkCorrectSubmitWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>通过图片URL或Base64编码接收题目，返回解题过程和结果。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>本接口支持通过单张题目图片的URL或Base64编码进行解题请求。</description></item>
        /// <item><description>支持处理JPEG、JPG、PNG格式的图片，且图片大小不超过10MB，像素总数不超过260万。</description></item>
        /// <item><description>请求必须携带<c>request_id</c>字段，用于链路关联和对账；建议使用UUID以保证唯一性。</description></item>
        /// <item><description><c>Authorization</c>头部需包含有效的<c>appKey</c>，采用<c>Bearer &lt;appKey&gt;</c>格式。</description></item>
        /// <item><description>接口响应为SSE流式数据，客户端应逐事件读取并解析，不得等待连接关闭后整体读取。</description></item>
        /// <item><description>成功响应包括<c>message</c>（过程态全量解题快照）和<c>complete</c>（最终完整结果）两种事件类型。</description></item>
        /// <item><description>错误处理分为建流前与建流后两个阶段，根据错误码及<c>retryable</c>字段决定是否重试。</description></item>
        /// <item><description>客户端超时设置建议不低于3分钟，并确保代理层不会缓存SSE响应或提前关闭长连接。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// CreateEduProblemSolveRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateEduProblemSolveResponse
        /// </returns>
        public CreateEduProblemSolveResponse CreateEduProblemSolveWithOptions(CreateEduProblemSolveRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateEduProblemSolveShrinkRequest request = new CreateEduProblemSolveShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Query))
            {
                request.QueryShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Query, "query", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueryShrink))
            {
                body["query"] = request.QueryShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RequestId))
            {
                body["requestId"] = request.RequestId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateEduProblemSolve",
                Version = "2026-11-02",
                Protocol = "HTTPS",
                Pathname = "/v1/problem/solve/stream",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateEduProblemSolveResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>通过图片URL或Base64编码接收题目，返回解题过程和结果。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>本接口支持通过单张题目图片的URL或Base64编码进行解题请求。</description></item>
        /// <item><description>支持处理JPEG、JPG、PNG格式的图片，且图片大小不超过10MB，像素总数不超过260万。</description></item>
        /// <item><description>请求必须携带<c>request_id</c>字段，用于链路关联和对账；建议使用UUID以保证唯一性。</description></item>
        /// <item><description><c>Authorization</c>头部需包含有效的<c>appKey</c>，采用<c>Bearer &lt;appKey&gt;</c>格式。</description></item>
        /// <item><description>接口响应为SSE流式数据，客户端应逐事件读取并解析，不得等待连接关闭后整体读取。</description></item>
        /// <item><description>成功响应包括<c>message</c>（过程态全量解题快照）和<c>complete</c>（最终完整结果）两种事件类型。</description></item>
        /// <item><description>错误处理分为建流前与建流后两个阶段，根据错误码及<c>retryable</c>字段决定是否重试。</description></item>
        /// <item><description>客户端超时设置建议不低于3分钟，并确保代理层不会缓存SSE响应或提前关闭长连接。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="tmpReq">
        /// CreateEduProblemSolveRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateEduProblemSolveResponse
        /// </returns>
        public async Task<CreateEduProblemSolveResponse> CreateEduProblemSolveWithOptionsAsync(CreateEduProblemSolveRequest tmpReq, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            CreateEduProblemSolveShrinkRequest request = new CreateEduProblemSolveShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Query))
            {
                request.QueryShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Query, "query", "json");
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.QueryShrink))
            {
                body["query"] = request.QueryShrink;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RequestId))
            {
                body["requestId"] = request.RequestId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateEduProblemSolve",
                Version = "2026-11-02",
                Protocol = "HTTPS",
                Pathname = "/v1/problem/solve/stream",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateEduProblemSolveResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>通过图片URL或Base64编码接收题目，返回解题过程和结果。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>本接口支持通过单张题目图片的URL或Base64编码进行解题请求。</description></item>
        /// <item><description>支持处理JPEG、JPG、PNG格式的图片，且图片大小不超过10MB，像素总数不超过260万。</description></item>
        /// <item><description>请求必须携带<c>request_id</c>字段，用于链路关联和对账；建议使用UUID以保证唯一性。</description></item>
        /// <item><description><c>Authorization</c>头部需包含有效的<c>appKey</c>，采用<c>Bearer &lt;appKey&gt;</c>格式。</description></item>
        /// <item><description>接口响应为SSE流式数据，客户端应逐事件读取并解析，不得等待连接关闭后整体读取。</description></item>
        /// <item><description>成功响应包括<c>message</c>（过程态全量解题快照）和<c>complete</c>（最终完整结果）两种事件类型。</description></item>
        /// <item><description>错误处理分为建流前与建流后两个阶段，根据错误码及<c>retryable</c>字段决定是否重试。</description></item>
        /// <item><description>客户端超时设置建议不低于3分钟，并确保代理层不会缓存SSE响应或提前关闭长连接。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateEduProblemSolveRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateEduProblemSolveResponse
        /// </returns>
        public CreateEduProblemSolveResponse CreateEduProblemSolve(CreateEduProblemSolveRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateEduProblemSolveWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>通过图片URL或Base64编码接收题目，返回解题过程和结果。</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>请求说明</h2>
        /// <list type="bullet">
        /// <item><description>本接口支持通过单张题目图片的URL或Base64编码进行解题请求。</description></item>
        /// <item><description>支持处理JPEG、JPG、PNG格式的图片，且图片大小不超过10MB，像素总数不超过260万。</description></item>
        /// <item><description>请求必须携带<c>request_id</c>字段，用于链路关联和对账；建议使用UUID以保证唯一性。</description></item>
        /// <item><description><c>Authorization</c>头部需包含有效的<c>appKey</c>，采用<c>Bearer &lt;appKey&gt;</c>格式。</description></item>
        /// <item><description>接口响应为SSE流式数据，客户端应逐事件读取并解析，不得等待连接关闭后整体读取。</description></item>
        /// <item><description>成功响应包括<c>message</c>（过程态全量解题快照）和<c>complete</c>（最终完整结果）两种事件类型。</description></item>
        /// <item><description>错误处理分为建流前与建流后两个阶段，根据错误码及<c>retryable</c>字段决定是否重试。</description></item>
        /// <item><description>客户端超时设置建议不低于3分钟，并确保代理层不会缓存SSE响应或提前关闭长连接。</description></item>
        /// </list>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateEduProblemSolveRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateEduProblemSolveResponse
        /// </returns>
        public async Task<CreateEduProblemSolveResponse> CreateEduProblemSolveAsync(CreateEduProblemSolveRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateEduProblemSolveWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询批改进度、增量结果、终态结果及 Token 用量</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetEduHomeworkCorrectionResultRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetEduHomeworkCorrectionResultResponse
        /// </returns>
        public GetEduHomeworkCorrectionResultResponse GetEduHomeworkCorrectionResultWithOptions(GetEduHomeworkCorrectionResultRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                query["taskId"] = request.TaskId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetEduHomeworkCorrectionResult",
                Version = "2026-11-02",
                Protocol = "HTTPS",
                Pathname = "/v1/homework/correct/result",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetEduHomeworkCorrectionResultResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询批改进度、增量结果、终态结果及 Token 用量</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetEduHomeworkCorrectionResultRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetEduHomeworkCorrectionResultResponse
        /// </returns>
        public async Task<GetEduHomeworkCorrectionResultResponse> GetEduHomeworkCorrectionResultWithOptionsAsync(GetEduHomeworkCorrectionResultRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TaskId))
            {
                query["taskId"] = request.TaskId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetEduHomeworkCorrectionResult",
                Version = "2026-11-02",
                Protocol = "HTTPS",
                Pathname = "/v1/homework/correct/result",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetEduHomeworkCorrectionResultResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询批改进度、增量结果、终态结果及 Token 用量</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetEduHomeworkCorrectionResultRequest
        /// </param>
        /// 
        /// <returns>
        /// GetEduHomeworkCorrectionResultResponse
        /// </returns>
        public GetEduHomeworkCorrectionResultResponse GetEduHomeworkCorrectionResult(GetEduHomeworkCorrectionResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetEduHomeworkCorrectionResultWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>查询批改进度、增量结果、终态结果及 Token 用量</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetEduHomeworkCorrectionResultRequest
        /// </param>
        /// 
        /// <returns>
        /// GetEduHomeworkCorrectionResultResponse
        /// </returns>
        public async Task<GetEduHomeworkCorrectionResultResponse> GetEduHomeworkCorrectionResultAsync(GetEduHomeworkCorrectionResultRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetEduHomeworkCorrectionResultWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>千问教育API开通状态查询</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetQwenEduApiActivationStatusRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetQwenEduApiActivationStatusResponse
        /// </returns>
        public GetQwenEduApiActivationStatusResponse GetQwenEduApiActivationStatusWithOptions(GetQwenEduApiActivationStatusRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetQwenEduApiActivationStatus",
                Version = "2026-11-02",
                Protocol = "HTTPS",
                Pathname = "/v1/service/activation/status",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetQwenEduApiActivationStatusResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>千问教育API开通状态查询</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetQwenEduApiActivationStatusRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetQwenEduApiActivationStatusResponse
        /// </returns>
        public async Task<GetQwenEduApiActivationStatusResponse> GetQwenEduApiActivationStatusWithOptionsAsync(GetQwenEduApiActivationStatusRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetQwenEduApiActivationStatus",
                Version = "2026-11-02",
                Protocol = "HTTPS",
                Pathname = "/v1/service/activation/status",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetQwenEduApiActivationStatusResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>千问教育API开通状态查询</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetQwenEduApiActivationStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// GetQwenEduApiActivationStatusResponse
        /// </returns>
        public GetQwenEduApiActivationStatusResponse GetQwenEduApiActivationStatus(GetQwenEduApiActivationStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetQwenEduApiActivationStatusWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>千问教育API开通状态查询</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetQwenEduApiActivationStatusRequest
        /// </param>
        /// 
        /// <returns>
        /// GetQwenEduApiActivationStatusResponse
        /// </returns>
        public async Task<GetQwenEduApiActivationStatusResponse> GetQwenEduApiActivationStatusAsync(GetQwenEduApiActivationStatusRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetQwenEduApiActivationStatusWithOptionsAsync(request, headers, runtime);
        }

    }
}
