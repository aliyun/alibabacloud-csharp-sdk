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
            this._endpointRule = "regional";
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
        /// <para>Activates the learning capability for the current Alibaba Cloud account and supports querying the activation status.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Request description</h2>
        /// <list type="bullet">
        /// <item><description>This operation activates the Qwen learning AI suite capability for the current Alibaba Cloud account.</description></item>
        /// <item><description>You must call this operation first. You can call business API operations such as problem solving and grading only after <c>ACTIVE</c> is returned.</description></item>
        /// </list>
        /// <h3>Precautions</h3>
        /// <list type="bullet">
        /// <item><description>Both Alibaba Cloud accounts and RAM users can call this operation.</description></item>
        /// <item><description>When a RAM user calls this operation, ensure that the RAM user has the required RAM permissions. The service is activated for the Alibaba Cloud account to which the RAM user belongs.</description></item>
        /// <item><description>This operation is idempotent based on the Alibaba Cloud account ID. Repeated calls do not result in multiple activations.</description></item>
        /// </list>
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
        /// <para>Activates the learning capability for the current Alibaba Cloud account and supports querying the activation status.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Request description</h2>
        /// <list type="bullet">
        /// <item><description>This operation activates the Qwen learning AI suite capability for the current Alibaba Cloud account.</description></item>
        /// <item><description>You must call this operation first. You can call business API operations such as problem solving and grading only after <c>ACTIVE</c> is returned.</description></item>
        /// </list>
        /// <h3>Precautions</h3>
        /// <list type="bullet">
        /// <item><description>Both Alibaba Cloud accounts and RAM users can call this operation.</description></item>
        /// <item><description>When a RAM user calls this operation, ensure that the RAM user has the required RAM permissions. The service is activated for the Alibaba Cloud account to which the RAM user belongs.</description></item>
        /// <item><description>This operation is idempotent based on the Alibaba Cloud account ID. Repeated calls do not result in multiple activations.</description></item>
        /// </list>
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
        /// <para>Activates the learning capability for the current Alibaba Cloud account and supports querying the activation status.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Request description</h2>
        /// <list type="bullet">
        /// <item><description>This operation activates the Qwen learning AI suite capability for the current Alibaba Cloud account.</description></item>
        /// <item><description>You must call this operation first. You can call business API operations such as problem solving and grading only after <c>ACTIVE</c> is returned.</description></item>
        /// </list>
        /// <h3>Precautions</h3>
        /// <list type="bullet">
        /// <item><description>Both Alibaba Cloud accounts and RAM users can call this operation.</description></item>
        /// <item><description>When a RAM user calls this operation, ensure that the RAM user has the required RAM permissions. The service is activated for the Alibaba Cloud account to which the RAM user belongs.</description></item>
        /// <item><description>This operation is idempotent based on the Alibaba Cloud account ID. Repeated calls do not result in multiple activations.</description></item>
        /// </list>
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
        /// <para>Activates the learning capability for the current Alibaba Cloud account and supports querying the activation status.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Request description</h2>
        /// <list type="bullet">
        /// <item><description>This operation activates the Qwen learning AI suite capability for the current Alibaba Cloud account.</description></item>
        /// <item><description>You must call this operation first. You can call business API operations such as problem solving and grading only after <c>ACTIVE</c> is returned.</description></item>
        /// </list>
        /// <h3>Precautions</h3>
        /// <list type="bullet">
        /// <item><description>Both Alibaba Cloud accounts and RAM users can call this operation.</description></item>
        /// <item><description>When a RAM user calls this operation, ensure that the RAM user has the required RAM permissions. The service is activated for the Alibaba Cloud account to which the RAM user belongs.</description></item>
        /// <item><description>This operation is idempotent based on the Alibaba Cloud account ID. Repeated calls do not result in multiple activations.</description></item>
        /// </list>
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
        /// <para>Submits a single-page homework image and asynchronously retrieves the grading results.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Request description</h2>
        /// <list type="bullet">
        /// <item><description>This operation submits a homework image to the server for question segmentation, recognition, and grading.</description></item>
        /// <item><description>You can submit the image by using <c>imageBase64</c> or <c>imageUrl</c>. <c>imageBase64</c> takes precedence.</description></item>
        /// <item><description>The optional <c>dewarp</c> parameter specifies whether to correct the image distortion. Default value: <c>true</c>.</description></item>
        /// <item><description>Provide <c>requestId</c> to facilitate troubleshooting and reconciliation.</description></item>
        /// <item><description>Image size limit: The Base64-encoded image size cannot exceed 15 MB.</description></item>
        /// <item><description>All requests and responses use the JSON format.</description></item>
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
        /// <para>Submits a single-page homework image and asynchronously retrieves the grading results.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Request description</h2>
        /// <list type="bullet">
        /// <item><description>This operation submits a homework image to the server for question segmentation, recognition, and grading.</description></item>
        /// <item><description>You can submit the image by using <c>imageBase64</c> or <c>imageUrl</c>. <c>imageBase64</c> takes precedence.</description></item>
        /// <item><description>The optional <c>dewarp</c> parameter specifies whether to correct the image distortion. Default value: <c>true</c>.</description></item>
        /// <item><description>Provide <c>requestId</c> to facilitate troubleshooting and reconciliation.</description></item>
        /// <item><description>Image size limit: The Base64-encoded image size cannot exceed 15 MB.</description></item>
        /// <item><description>All requests and responses use the JSON format.</description></item>
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
        /// <para>Submits a single-page homework image and asynchronously retrieves the grading results.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Request description</h2>
        /// <list type="bullet">
        /// <item><description>This operation submits a homework image to the server for question segmentation, recognition, and grading.</description></item>
        /// <item><description>You can submit the image by using <c>imageBase64</c> or <c>imageUrl</c>. <c>imageBase64</c> takes precedence.</description></item>
        /// <item><description>The optional <c>dewarp</c> parameter specifies whether to correct the image distortion. Default value: <c>true</c>.</description></item>
        /// <item><description>Provide <c>requestId</c> to facilitate troubleshooting and reconciliation.</description></item>
        /// <item><description>Image size limit: The Base64-encoded image size cannot exceed 15 MB.</description></item>
        /// <item><description>All requests and responses use the JSON format.</description></item>
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
        /// <para>Submits a single-page homework image and asynchronously retrieves the grading results.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Request description</h2>
        /// <list type="bullet">
        /// <item><description>This operation submits a homework image to the server for question segmentation, recognition, and grading.</description></item>
        /// <item><description>You can submit the image by using <c>imageBase64</c> or <c>imageUrl</c>. <c>imageBase64</c> takes precedence.</description></item>
        /// <item><description>The optional <c>dewarp</c> parameter specifies whether to correct the image distortion. Default value: <c>true</c>.</description></item>
        /// <item><description>Provide <c>requestId</c> to facilitate troubleshooting and reconciliation.</description></item>
        /// <item><description>Image size limit: The Base64-encoded image size cannot exceed 15 MB.</description></item>
        /// <item><description>All requests and responses use the JSON format.</description></item>
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
        /// <para>Provides question resolution services by using image URLs or Base64 encoding.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Request description</h2>
        /// <list type="bullet">
        /// <item><description>This API supports obtaining question resolution results by providing the URL or Base64 encoding of a question image.</description></item>
        /// <item><description>Supports processing a single image. The image format must be JPG, JPEG, or PNG.</description></item>
        /// <item><description>The image must be clear and complete. Avoid tilted, obscured, or irrelevant content.</description></item>
        /// <item><description>Each request can process only one image. Multi-image or plain text requests are not supported.</description></item>
        /// <item><description>The recommended image size is up to 1 MB, with a maximum of 10 MB. The image width and height must not exceed 8,000 pixels, and the total pixel count must not exceed 2.6 million.</description></item>
        /// <item><description>You must use the HTTPS protocol to call the API and provide image URLs.</description></item>
        /// <item><description>The user_id parameter must be an anonymized identifier. Do not pass direct identity information such as names or phone numbers.</description></item>
        /// <item><description>The API uses the HTTP POST method combined with Server-Sent Events (SSE) streaming response. The client must read the response event by event, rather than waiting for the connection to close to read the entire response.</description></item>
        /// <item><description>A successful response returns the question resolution process through a series of message events and ends with a complete event. If an error occurs, an error event is returned.</description></item>
        /// <item><description>For retryable errors such as TOO_MANY_ACTIVE_STREAMS, use an exponential backoff strategy to retry the request.</description></item>
        /// <item><description>Set a reasonable timeout period of at least 3 minutes on the client, and ensure that the proxy layer does not cache SSE responses.</description></item>
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
        /// <para>Provides question resolution services by using image URLs or Base64 encoding.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Request description</h2>
        /// <list type="bullet">
        /// <item><description>This API supports obtaining question resolution results by providing the URL or Base64 encoding of a question image.</description></item>
        /// <item><description>Supports processing a single image. The image format must be JPG, JPEG, or PNG.</description></item>
        /// <item><description>The image must be clear and complete. Avoid tilted, obscured, or irrelevant content.</description></item>
        /// <item><description>Each request can process only one image. Multi-image or plain text requests are not supported.</description></item>
        /// <item><description>The recommended image size is up to 1 MB, with a maximum of 10 MB. The image width and height must not exceed 8,000 pixels, and the total pixel count must not exceed 2.6 million.</description></item>
        /// <item><description>You must use the HTTPS protocol to call the API and provide image URLs.</description></item>
        /// <item><description>The user_id parameter must be an anonymized identifier. Do not pass direct identity information such as names or phone numbers.</description></item>
        /// <item><description>The API uses the HTTP POST method combined with Server-Sent Events (SSE) streaming response. The client must read the response event by event, rather than waiting for the connection to close to read the entire response.</description></item>
        /// <item><description>A successful response returns the question resolution process through a series of message events and ends with a complete event. If an error occurs, an error event is returned.</description></item>
        /// <item><description>For retryable errors such as TOO_MANY_ACTIVE_STREAMS, use an exponential backoff strategy to retry the request.</description></item>
        /// <item><description>Set a reasonable timeout period of at least 3 minutes on the client, and ensure that the proxy layer does not cache SSE responses.</description></item>
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
        /// <para>Provides question resolution services by using image URLs or Base64 encoding.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Request description</h2>
        /// <list type="bullet">
        /// <item><description>This API supports obtaining question resolution results by providing the URL or Base64 encoding of a question image.</description></item>
        /// <item><description>Supports processing a single image. The image format must be JPG, JPEG, or PNG.</description></item>
        /// <item><description>The image must be clear and complete. Avoid tilted, obscured, or irrelevant content.</description></item>
        /// <item><description>Each request can process only one image. Multi-image or plain text requests are not supported.</description></item>
        /// <item><description>The recommended image size is up to 1 MB, with a maximum of 10 MB. The image width and height must not exceed 8,000 pixels, and the total pixel count must not exceed 2.6 million.</description></item>
        /// <item><description>You must use the HTTPS protocol to call the API and provide image URLs.</description></item>
        /// <item><description>The user_id parameter must be an anonymized identifier. Do not pass direct identity information such as names or phone numbers.</description></item>
        /// <item><description>The API uses the HTTP POST method combined with Server-Sent Events (SSE) streaming response. The client must read the response event by event, rather than waiting for the connection to close to read the entire response.</description></item>
        /// <item><description>A successful response returns the question resolution process through a series of message events and ends with a complete event. If an error occurs, an error event is returned.</description></item>
        /// <item><description>For retryable errors such as TOO_MANY_ACTIVE_STREAMS, use an exponential backoff strategy to retry the request.</description></item>
        /// <item><description>Set a reasonable timeout period of at least 3 minutes on the client, and ensure that the proxy layer does not cache SSE responses.</description></item>
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
        /// <para>Provides question resolution services by using image URLs or Base64 encoding.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Request description</h2>
        /// <list type="bullet">
        /// <item><description>This API supports obtaining question resolution results by providing the URL or Base64 encoding of a question image.</description></item>
        /// <item><description>Supports processing a single image. The image format must be JPG, JPEG, or PNG.</description></item>
        /// <item><description>The image must be clear and complete. Avoid tilted, obscured, or irrelevant content.</description></item>
        /// <item><description>Each request can process only one image. Multi-image or plain text requests are not supported.</description></item>
        /// <item><description>The recommended image size is up to 1 MB, with a maximum of 10 MB. The image width and height must not exceed 8,000 pixels, and the total pixel count must not exceed 2.6 million.</description></item>
        /// <item><description>You must use the HTTPS protocol to call the API and provide image URLs.</description></item>
        /// <item><description>The user_id parameter must be an anonymized identifier. Do not pass direct identity information such as names or phone numbers.</description></item>
        /// <item><description>The API uses the HTTP POST method combined with Server-Sent Events (SSE) streaming response. The client must read the response event by event, rather than waiting for the connection to close to read the entire response.</description></item>
        /// <item><description>A successful response returns the question resolution process through a series of message events and ends with a complete event. If an error occurs, an error event is returned.</description></item>
        /// <item><description>For retryable errors such as TOO_MANY_ACTIVE_STREAMS, use an exponential backoff strategy to retry the request.</description></item>
        /// <item><description>Set a reasonable timeout period of at least 3 minutes on the client, and ensure that the proxy layer does not cache SSE responses.</description></item>
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
        /// <para>Queries the progress and final results of homework grading based on the task ID.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Request description</h2>
        /// <list type="bullet">
        /// <item><description>This operation queries the status and detailed results of single-page homework grading by using the <c>taskId</c> returned when the task is submitted.</description></item>
        /// <item><description>The caller should poll this operation at an interval of 1 to 2 seconds until the task status changes to <c>finished</c> or <c>failed</c>.</description></item>
        /// <item><description>When the task status is <c>finished</c>, the response contains complete grading information, including question recognition, grading conclusions, dewarped images, and rendered images.</description></item>
        /// <item><description>If the task fails (the status is <c>failed</c>), check the <c>message</c> field in the response or the specific fault information in <c>data</c>.</description></item>
        /// <item><description>All requests and responses are in JSON format.</description></item>
        /// </list>
        /// </description>
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
        /// <para>Queries the progress and final results of homework grading based on the task ID.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Request description</h2>
        /// <list type="bullet">
        /// <item><description>This operation queries the status and detailed results of single-page homework grading by using the <c>taskId</c> returned when the task is submitted.</description></item>
        /// <item><description>The caller should poll this operation at an interval of 1 to 2 seconds until the task status changes to <c>finished</c> or <c>failed</c>.</description></item>
        /// <item><description>When the task status is <c>finished</c>, the response contains complete grading information, including question recognition, grading conclusions, dewarped images, and rendered images.</description></item>
        /// <item><description>If the task fails (the status is <c>failed</c>), check the <c>message</c> field in the response or the specific fault information in <c>data</c>.</description></item>
        /// <item><description>All requests and responses are in JSON format.</description></item>
        /// </list>
        /// </description>
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
        /// <para>Queries the progress and final results of homework grading based on the task ID.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Request description</h2>
        /// <list type="bullet">
        /// <item><description>This operation queries the status and detailed results of single-page homework grading by using the <c>taskId</c> returned when the task is submitted.</description></item>
        /// <item><description>The caller should poll this operation at an interval of 1 to 2 seconds until the task status changes to <c>finished</c> or <c>failed</c>.</description></item>
        /// <item><description>When the task status is <c>finished</c>, the response contains complete grading information, including question recognition, grading conclusions, dewarped images, and rendered images.</description></item>
        /// <item><description>If the task fails (the status is <c>failed</c>), check the <c>message</c> field in the response or the specific fault information in <c>data</c>.</description></item>
        /// <item><description>All requests and responses are in JSON format.</description></item>
        /// </list>
        /// </description>
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
        /// <para>Queries the progress and final results of homework grading based on the task ID.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Request description</h2>
        /// <list type="bullet">
        /// <item><description>This operation queries the status and detailed results of single-page homework grading by using the <c>taskId</c> returned when the task is submitted.</description></item>
        /// <item><description>The caller should poll this operation at an interval of 1 to 2 seconds until the task status changes to <c>finished</c> or <c>failed</c>.</description></item>
        /// <item><description>When the task status is <c>finished</c>, the response contains complete grading information, including question recognition, grading conclusions, dewarped images, and rendered images.</description></item>
        /// <item><description>If the task fails (the status is <c>failed</c>), check the <c>message</c> field in the response or the specific fault information in <c>data</c>.</description></item>
        /// <item><description>All requests and responses are in JSON format.</description></item>
        /// </list>
        /// </description>
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
        /// <para>Queries whether the current account has activated Qwen education-related services.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Request description</h2>
        /// <para>This operation queries whether a specified Alibaba Cloud account or RAM user has successfully activated the Qwen learning AI suite. Before calling any business API operations, you must use this operation to confirm that the service status is <c>ACTIVE</c>. If the service is not activated, perform the corresponding operations based on the returned status information, such as waiting for a period of time and retrying.</para>
        /// <h3>Precautions</h3>
        /// <list type="bullet">
        /// <item><description>This operation supports calls from Alibaba Cloud accounts and RAM users.</description></item>
        /// <item><description>When a RAM user calls this operation, make sure that the RAM user has the required RAM permissions. The service is activated for the Alibaba Cloud account to which the RAM user belongs.</description></item>
        /// <item><description>This operation is idempotent based on the Alibaba Cloud account ID. Repeated calls do not result in multiple activations.</description></item>
        /// <item><description>If the status is <c>ACTIVATING</c>, retry the query after the time interval recommended by the returned <c>retry_after_seconds</c> field.</description></item>
        /// <item><description>If a failure occurs (<c>FAILED</c>), refer to the specific error code, take corresponding measures, and then try again.</description></item>
        /// </list>
        /// </description>
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
        /// <para>Queries whether the current account has activated Qwen education-related services.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Request description</h2>
        /// <para>This operation queries whether a specified Alibaba Cloud account or RAM user has successfully activated the Qwen learning AI suite. Before calling any business API operations, you must use this operation to confirm that the service status is <c>ACTIVE</c>. If the service is not activated, perform the corresponding operations based on the returned status information, such as waiting for a period of time and retrying.</para>
        /// <h3>Precautions</h3>
        /// <list type="bullet">
        /// <item><description>This operation supports calls from Alibaba Cloud accounts and RAM users.</description></item>
        /// <item><description>When a RAM user calls this operation, make sure that the RAM user has the required RAM permissions. The service is activated for the Alibaba Cloud account to which the RAM user belongs.</description></item>
        /// <item><description>This operation is idempotent based on the Alibaba Cloud account ID. Repeated calls do not result in multiple activations.</description></item>
        /// <item><description>If the status is <c>ACTIVATING</c>, retry the query after the time interval recommended by the returned <c>retry_after_seconds</c> field.</description></item>
        /// <item><description>If a failure occurs (<c>FAILED</c>), refer to the specific error code, take corresponding measures, and then try again.</description></item>
        /// </list>
        /// </description>
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
        /// <para>Queries whether the current account has activated Qwen education-related services.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Request description</h2>
        /// <para>This operation queries whether a specified Alibaba Cloud account or RAM user has successfully activated the Qwen learning AI suite. Before calling any business API operations, you must use this operation to confirm that the service status is <c>ACTIVE</c>. If the service is not activated, perform the corresponding operations based on the returned status information, such as waiting for a period of time and retrying.</para>
        /// <h3>Precautions</h3>
        /// <list type="bullet">
        /// <item><description>This operation supports calls from Alibaba Cloud accounts and RAM users.</description></item>
        /// <item><description>When a RAM user calls this operation, make sure that the RAM user has the required RAM permissions. The service is activated for the Alibaba Cloud account to which the RAM user belongs.</description></item>
        /// <item><description>This operation is idempotent based on the Alibaba Cloud account ID. Repeated calls do not result in multiple activations.</description></item>
        /// <item><description>If the status is <c>ACTIVATING</c>, retry the query after the time interval recommended by the returned <c>retry_after_seconds</c> field.</description></item>
        /// <item><description>If a failure occurs (<c>FAILED</c>), refer to the specific error code, take corresponding measures, and then try again.</description></item>
        /// </list>
        /// </description>
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
        /// <para>Queries whether the current account has activated Qwen education-related services.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <h2>Request description</h2>
        /// <para>This operation queries whether a specified Alibaba Cloud account or RAM user has successfully activated the Qwen learning AI suite. Before calling any business API operations, you must use this operation to confirm that the service status is <c>ACTIVE</c>. If the service is not activated, perform the corresponding operations based on the returned status information, such as waiting for a period of time and retrying.</para>
        /// <h3>Precautions</h3>
        /// <list type="bullet">
        /// <item><description>This operation supports calls from Alibaba Cloud accounts and RAM users.</description></item>
        /// <item><description>When a RAM user calls this operation, make sure that the RAM user has the required RAM permissions. The service is activated for the Alibaba Cloud account to which the RAM user belongs.</description></item>
        /// <item><description>This operation is idempotent based on the Alibaba Cloud account ID. Repeated calls do not result in multiple activations.</description></item>
        /// <item><description>If the status is <c>ACTIVATING</c>, retry the query after the time interval recommended by the returned <c>retry_after_seconds</c> field.</description></item>
        /// <item><description>If a failure occurs (<c>FAILED</c>), refer to the specific error code, take corresponding measures, and then try again.</description></item>
        /// </list>
        /// </description>
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
