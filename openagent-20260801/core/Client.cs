// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.OpenAgent20260801.Models;

namespace AlibabaCloud.SDK.OpenAgent20260801
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "regional";
            CheckConfig(config);
            this._endpoint = GetEndpoint("openagent", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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
        /// <para>Cancels a run.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Cancels a specified run and returns the run status after the cancellation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CancelRunRequest
        /// </param>
        /// <param name="headers">
        /// CancelRunHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CancelRunResponse
        /// </returns>
        public CancelRunResponse CancelRunWithOptions(string sessionId, string runId, CancelRunRequest request, CancelRunHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Reason))
            {
                body["reason"] = request.Reason;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XOpenAgentIdempotencyKey))
            {
                realHeaders["X-OpenAgent-Idempotency-Key"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XOpenAgentIdempotencyKey);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CancelRun",
                Version = "2026-08-01",
                Protocol = "HTTPS",
                Pathname = "/openapi/v1/agent/sessions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(sessionId) + "/runs/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(runId) + "/cancel",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CancelRunResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Cancels a run.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Cancels a specified run and returns the run status after the cancellation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CancelRunRequest
        /// </param>
        /// <param name="headers">
        /// CancelRunHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CancelRunResponse
        /// </returns>
        public async Task<CancelRunResponse> CancelRunWithOptionsAsync(string sessionId, string runId, CancelRunRequest request, CancelRunHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Reason))
            {
                body["reason"] = request.Reason;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XOpenAgentIdempotencyKey))
            {
                realHeaders["X-OpenAgent-Idempotency-Key"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XOpenAgentIdempotencyKey);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CancelRun",
                Version = "2026-08-01",
                Protocol = "HTTPS",
                Pathname = "/openapi/v1/agent/sessions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(sessionId) + "/runs/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(runId) + "/cancel",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CancelRunResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Cancels a run.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Cancels a specified run and returns the run status after the cancellation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CancelRunRequest
        /// </param>
        /// 
        /// <returns>
        /// CancelRunResponse
        /// </returns>
        public CancelRunResponse CancelRun(string sessionId, string runId, CancelRunRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CancelRunHeaders headers = new CancelRunHeaders();
            return CancelRunWithOptions(sessionId, runId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Cancels a run.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Cancels a specified run and returns the run status after the cancellation.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CancelRunRequest
        /// </param>
        /// 
        /// <returns>
        /// CancelRunResponse
        /// </returns>
        public async Task<CancelRunResponse> CancelRunAsync(string sessionId, string runId, CancelRunRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CancelRunHeaders headers = new CancelRunHeaders();
            return await CancelRunWithOptionsAsync(sessionId, runId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a session.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Creates a session and returns the session information. Use the returned sessionId for subsequent operations such as sending messages, querying records, and updating the session.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateSessionRequest
        /// </param>
        /// <param name="headers">
        /// CreateSessionHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateSessionResponse
        /// </returns>
        public CreateSessionResponse CreateSessionWithOptions(CreateSessionRequest request, CreateSessionHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Title))
            {
                body["title"] = request.Title;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XOpenAgentIdempotencyKey))
            {
                realHeaders["X-OpenAgent-Idempotency-Key"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XOpenAgentIdempotencyKey);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateSession",
                Version = "2026-08-01",
                Protocol = "HTTPS",
                Pathname = "/openapi/v1/agent/sessions",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateSessionResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a session.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Creates a session and returns the session information. Use the returned sessionId for subsequent operations such as sending messages, querying records, and updating the session.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateSessionRequest
        /// </param>
        /// <param name="headers">
        /// CreateSessionHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateSessionResponse
        /// </returns>
        public async Task<CreateSessionResponse> CreateSessionWithOptionsAsync(CreateSessionRequest request, CreateSessionHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Title))
            {
                body["title"] = request.Title;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XOpenAgentIdempotencyKey))
            {
                realHeaders["X-OpenAgent-Idempotency-Key"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XOpenAgentIdempotencyKey);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateSession",
                Version = "2026-08-01",
                Protocol = "HTTPS",
                Pathname = "/openapi/v1/agent/sessions",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateSessionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a session.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Creates a session and returns the session information. Use the returned sessionId for subsequent operations such as sending messages, querying records, and updating the session.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateSessionRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateSessionResponse
        /// </returns>
        public CreateSessionResponse CreateSession(CreateSessionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateSessionHeaders headers = new CreateSessionHeaders();
            return CreateSessionWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Creates a session.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Creates a session and returns the session information. Use the returned sessionId for subsequent operations such as sending messages, querying records, and updating the session.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// CreateSessionRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateSessionResponse
        /// </returns>
        public async Task<CreateSessionResponse> CreateSessionAsync(CreateSessionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            CreateSessionHeaders headers = new CreateSessionHeaders();
            return await CreateSessionWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a session.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Deletes a specified session. Returns 404 Session.NotFound if the session does not exist or has been deleted.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteSessionRequest
        /// </param>
        /// <param name="headers">
        /// DeleteSessionHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteSessionResponse
        /// </returns>
        public DeleteSessionResponse DeleteSessionWithOptions(string sessionId, DeleteSessionRequest request, DeleteSessionHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XOpenAgentIdempotencyKey))
            {
                realHeaders["X-OpenAgent-Idempotency-Key"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XOpenAgentIdempotencyKey);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteSession",
                Version = "2026-08-01",
                Protocol = "HTTPS",
                Pathname = "/openapi/v1/agent/sessions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(sessionId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteSessionResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a session.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Deletes a specified session. Returns 404 Session.NotFound if the session does not exist or has been deleted.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteSessionRequest
        /// </param>
        /// <param name="headers">
        /// DeleteSessionHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteSessionResponse
        /// </returns>
        public async Task<DeleteSessionResponse> DeleteSessionWithOptionsAsync(string sessionId, DeleteSessionRequest request, DeleteSessionHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XOpenAgentIdempotencyKey))
            {
                realHeaders["X-OpenAgent-Idempotency-Key"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XOpenAgentIdempotencyKey);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteSession",
                Version = "2026-08-01",
                Protocol = "HTTPS",
                Pathname = "/openapi/v1/agent/sessions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(sessionId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteSessionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a session.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Deletes a specified session. Returns 404 Session.NotFound if the session does not exist or has been deleted.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteSessionRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteSessionResponse
        /// </returns>
        public DeleteSessionResponse DeleteSession(string sessionId, DeleteSessionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteSessionHeaders headers = new DeleteSessionHeaders();
            return DeleteSessionWithOptions(sessionId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Deletes a session.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Deletes a specified session. Returns 404 Session.NotFound if the session does not exist or has been deleted.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// DeleteSessionRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteSessionResponse
        /// </returns>
        public async Task<DeleteSessionResponse> DeleteSessionAsync(string sessionId, DeleteSessionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            DeleteSessionHeaders headers = new DeleteSessionHeaders();
            return await DeleteSessionWithOptionsAsync(sessionId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the read-only mode.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries the read-only mode switch for the current account. The read-only mode is enabled by default if it is not configured.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetReadonlyModeRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetReadonlyModeResponse
        /// </returns>
        public GetReadonlyModeResponse GetReadonlyModeWithOptions(GetReadonlyModeRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetReadonlyMode",
                Version = "2026-08-01",
                Protocol = "HTTPS",
                Pathname = "/openapi/v1/user/configs/readonly",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetReadonlyModeResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the read-only mode.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries the read-only mode switch for the current account. The read-only mode is enabled by default if it is not configured.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetReadonlyModeRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetReadonlyModeResponse
        /// </returns>
        public async Task<GetReadonlyModeResponse> GetReadonlyModeWithOptionsAsync(GetReadonlyModeRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetReadonlyMode",
                Version = "2026-08-01",
                Protocol = "HTTPS",
                Pathname = "/openapi/v1/user/configs/readonly",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetReadonlyModeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the read-only mode.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries the read-only mode switch for the current account. The read-only mode is enabled by default if it is not configured.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetReadonlyModeRequest
        /// </param>
        /// 
        /// <returns>
        /// GetReadonlyModeResponse
        /// </returns>
        public GetReadonlyModeResponse GetReadonlyMode(GetReadonlyModeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetReadonlyModeWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries the read-only mode.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries the read-only mode switch for the current account. The read-only mode is enabled by default if it is not configured.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetReadonlyModeRequest
        /// </param>
        /// 
        /// <returns>
        /// GetReadonlyModeResponse
        /// </returns>
        public async Task<GetReadonlyModeResponse> GetReadonlyModeAsync(GetReadonlyModeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetReadonlyModeWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a run.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries the status and interrupt information of a specified run.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetRunRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetRunResponse
        /// </returns>
        public GetRunResponse GetRunWithOptions(string sessionId, string runId, GetRunRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetRun",
                Version = "2026-08-01",
                Protocol = "HTTPS",
                Pathname = "/openapi/v1/agent/sessions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(sessionId) + "/runs/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(runId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetRunResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a run.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries the status and interrupt information of a specified run.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetRunRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetRunResponse
        /// </returns>
        public async Task<GetRunResponse> GetRunWithOptionsAsync(string sessionId, string runId, GetRunRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetRun",
                Version = "2026-08-01",
                Protocol = "HTTPS",
                Pathname = "/openapi/v1/agent/sessions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(sessionId) + "/runs/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(runId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetRunResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a run.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries the status and interrupt information of a specified run.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetRunRequest
        /// </param>
        /// 
        /// <returns>
        /// GetRunResponse
        /// </returns>
        public GetRunResponse GetRun(string sessionId, string runId, GetRunRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetRunWithOptions(sessionId, runId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a run.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries the status and interrupt information of a specified run.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetRunRequest
        /// </param>
        /// 
        /// <returns>
        /// GetRunResponse
        /// </returns>
        public async Task<GetRunResponse> GetRunAsync(string sessionId, string runId, GetRunRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetRunWithOptionsAsync(sessionId, runId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a session.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries the title, status, pinning information, and the ID and status of the most recent run of a specified session.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetSessionRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetSessionResponse
        /// </returns>
        public GetSessionResponse GetSessionWithOptions(string sessionId, GetSessionRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetSession",
                Version = "2026-08-01",
                Protocol = "HTTPS",
                Pathname = "/openapi/v1/agent/sessions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(sessionId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSessionResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a session.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries the title, status, pinning information, and the ID and status of the most recent run of a specified session.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetSessionRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetSessionResponse
        /// </returns>
        public async Task<GetSessionResponse> GetSessionWithOptionsAsync(string sessionId, GetSessionRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetSession",
                Version = "2026-08-01",
                Protocol = "HTTPS",
                Pathname = "/openapi/v1/agent/sessions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(sessionId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetSessionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a session.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries the title, status, pinning information, and the ID and status of the most recent run of a specified session.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetSessionRequest
        /// </param>
        /// 
        /// <returns>
        /// GetSessionResponse
        /// </returns>
        public GetSessionResponse GetSession(string sessionId, GetSessionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetSessionWithOptions(sessionId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Queries a session.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Queries the title, status, pinning information, and the ID and status of the most recent run of a specified session.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// GetSessionRequest
        /// </param>
        /// 
        /// <returns>
        /// GetSessionResponse
        /// </returns>
        public async Task<GetSessionResponse> GetSessionAsync(string sessionId, GetSessionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetSessionWithOptionsAsync(sessionId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Lists messages.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Performs a paging query on the message timeline of a specified session. Use the returned nextToken to retrieve the next page.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListMessagesRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListMessagesResponse
        /// </returns>
        public ListMessagesResponse ListMessagesWithOptions(string sessionId, ListMessagesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RunId))
            {
                query["runId"] = request.RunId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListMessages",
                Version = "2026-08-01",
                Protocol = "HTTPS",
                Pathname = "/openapi/v1/agent/sessions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(sessionId) + "/messages",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListMessagesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Lists messages.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Performs a paging query on the message timeline of a specified session. Use the returned nextToken to retrieve the next page.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListMessagesRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListMessagesResponse
        /// </returns>
        public async Task<ListMessagesResponse> ListMessagesWithOptionsAsync(string sessionId, ListMessagesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RunId))
            {
                query["runId"] = request.RunId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListMessages",
                Version = "2026-08-01",
                Protocol = "HTTPS",
                Pathname = "/openapi/v1/agent/sessions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(sessionId) + "/messages",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListMessagesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Lists messages.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Performs a paging query on the message timeline of a specified session. Use the returned nextToken to retrieve the next page.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListMessagesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListMessagesResponse
        /// </returns>
        public ListMessagesResponse ListMessages(string sessionId, ListMessagesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListMessagesWithOptions(sessionId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Lists messages.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Performs a paging query on the message timeline of a specified session. Use the returned nextToken to retrieve the next page.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListMessagesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListMessagesResponse
        /// </returns>
        public async Task<ListMessagesResponse> ListMessagesAsync(string sessionId, ListMessagesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListMessagesWithOptionsAsync(sessionId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Lists sessions.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Uses paging to query the list of sessions accessible to the current identity used to invoke. Use the returned nextToken to retrieve the next page.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListSessionsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListSessionsResponse
        /// </returns>
        public ListSessionsResponse ListSessionsWithOptions(ListSessionsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListSessions",
                Version = "2026-08-01",
                Protocol = "HTTPS",
                Pathname = "/openapi/v1/agent/sessions",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListSessionsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Lists sessions.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Uses paging to query the list of sessions accessible to the current identity used to invoke. Use the returned nextToken to retrieve the next page.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListSessionsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListSessionsResponse
        /// </returns>
        public async Task<ListSessionsResponse> ListSessionsWithOptionsAsync(ListSessionsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                query["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                query["nextToken"] = request.NextToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListSessions",
                Version = "2026-08-01",
                Protocol = "HTTPS",
                Pathname = "/openapi/v1/agent/sessions",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListSessionsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Lists sessions.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Uses paging to query the list of sessions accessible to the current identity used to invoke. Use the returned nextToken to retrieve the next page.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListSessionsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListSessionsResponse
        /// </returns>
        public ListSessionsResponse ListSessions(ListSessionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListSessionsWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Lists sessions.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Uses paging to query the list of sessions accessible to the current identity used to invoke. Use the returned nextToken to retrieve the next page.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// ListSessionsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListSessionsResponse
        /// </returns>
        public async Task<ListSessionsResponse> ListSessionsAsync(ListSessionsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListSessionsWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Sends a message.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Sends a message to a specified session, submits interrupt handling results, or reconnects to a specified run. Returns the run progress and results through a Server-Sent Events (SSE) event stream.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// SendMessageRequest
        /// </param>
        /// <param name="headers">
        /// SendMessageHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SendMessageResponse
        /// </returns>
        public SendMessageResponse SendMessageWithOptions(string sessionId, SendMessageRequest request, SendMessageHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Content))
            {
                body["content"] = request.Content;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Resume))
            {
                body["resume"] = request.Resume;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RunId))
            {
                body["runId"] = request.RunId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                body["type"] = request.Type;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XOpenAgentIdempotencyKey))
            {
                realHeaders["X-OpenAgent-Idempotency-Key"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XOpenAgentIdempotencyKey);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SendMessage",
                Version = "2026-08-01",
                Protocol = "HTTPS",
                Pathname = "/openapi/v1/agent/sessions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(sessionId) + "/messages",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "string",
            };
            return TeaModel.ToObject<SendMessageResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Sends a message.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Sends a message to a specified session, submits interrupt handling results, or reconnects to a specified run. Returns the run progress and results through a Server-Sent Events (SSE) event stream.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// SendMessageRequest
        /// </param>
        /// <param name="headers">
        /// SendMessageHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SendMessageResponse
        /// </returns>
        public async Task<SendMessageResponse> SendMessageWithOptionsAsync(string sessionId, SendMessageRequest request, SendMessageHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Content))
            {
                body["content"] = request.Content;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Resume))
            {
                body["resume"] = request.Resume;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RunId))
            {
                body["runId"] = request.RunId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                body["type"] = request.Type;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XOpenAgentIdempotencyKey))
            {
                realHeaders["X-OpenAgent-Idempotency-Key"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XOpenAgentIdempotencyKey);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SendMessage",
                Version = "2026-08-01",
                Protocol = "HTTPS",
                Pathname = "/openapi/v1/agent/sessions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(sessionId) + "/messages",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "string",
            };
            return TeaModel.ToObject<SendMessageResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Sends a message.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Sends a message to a specified session, submits interrupt handling results, or reconnects to a specified run. Returns the run progress and results through a Server-Sent Events (SSE) event stream.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// SendMessageRequest
        /// </param>
        /// 
        /// <returns>
        /// SendMessageResponse
        /// </returns>
        public SendMessageResponse SendMessage(string sessionId, SendMessageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SendMessageHeaders headers = new SendMessageHeaders();
            return SendMessageWithOptions(sessionId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Sends a message.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Sends a message to a specified session, submits interrupt handling results, or reconnects to a specified run. Returns the run progress and results through a Server-Sent Events (SSE) event stream.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// SendMessageRequest
        /// </param>
        /// 
        /// <returns>
        /// SendMessageResponse
        /// </returns>
        public async Task<SendMessageResponse> SendMessageAsync(string sessionId, SendMessageRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            SendMessageHeaders headers = new SendMessageHeaders();
            return await SendMessageWithOptionsAsync(sessionId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the read-only mode.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Enables or disables the read-only mode for the current account.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateReadonlyModeRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateReadonlyModeResponse
        /// </returns>
        public UpdateReadonlyModeResponse UpdateReadonlyModeWithOptions(UpdateReadonlyModeRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Value))
            {
                body["value"] = request.Value;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateReadonlyMode",
                Version = "2026-08-01",
                Protocol = "HTTPS",
                Pathname = "/openapi/v1/user/configs/readonly",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateReadonlyModeResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the read-only mode.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Enables or disables the read-only mode for the current account.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateReadonlyModeRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateReadonlyModeResponse
        /// </returns>
        public async Task<UpdateReadonlyModeResponse> UpdateReadonlyModeWithOptionsAsync(UpdateReadonlyModeRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Value))
            {
                body["value"] = request.Value;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateReadonlyMode",
                Version = "2026-08-01",
                Protocol = "HTTPS",
                Pathname = "/openapi/v1/user/configs/readonly",
                Method = "PUT",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "formData",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateReadonlyModeResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the read-only mode.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Enables or disables the read-only mode for the current account.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateReadonlyModeRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateReadonlyModeResponse
        /// </returns>
        public UpdateReadonlyModeResponse UpdateReadonlyMode(UpdateReadonlyModeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateReadonlyModeWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the read-only mode.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Enables or disables the read-only mode for the current account.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateReadonlyModeRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateReadonlyModeResponse
        /// </returns>
        public async Task<UpdateReadonlyModeResponse> UpdateReadonlyModeAsync(UpdateReadonlyModeRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateReadonlyModeWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the title or pinned status of a session.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Updates the title or pinned status of a specified session. Specify at least one of the title and pinned fields. Unspecified fields remain unchanged.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateSessionRequest
        /// </param>
        /// <param name="headers">
        /// UpdateSessionHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateSessionResponse
        /// </returns>
        public UpdateSessionResponse UpdateSessionWithOptions(string sessionId, UpdateSessionRequest request, UpdateSessionHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Pinned))
            {
                body["pinned"] = request.Pinned;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Title))
            {
                body["title"] = request.Title;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XOpenAgentIdempotencyKey))
            {
                realHeaders["X-OpenAgent-Idempotency-Key"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XOpenAgentIdempotencyKey);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateSession",
                Version = "2026-08-01",
                Protocol = "HTTPS",
                Pathname = "/openapi/v1/agent/sessions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(sessionId),
                Method = "PATCH",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateSessionResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the title or pinned status of a session.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Updates the title or pinned status of a specified session. Specify at least one of the title and pinned fields. Unspecified fields remain unchanged.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateSessionRequest
        /// </param>
        /// <param name="headers">
        /// UpdateSessionHeaders
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateSessionResponse
        /// </returns>
        public async Task<UpdateSessionResponse> UpdateSessionWithOptionsAsync(string sessionId, UpdateSessionRequest request, UpdateSessionHeaders headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Pinned))
            {
                body["pinned"] = request.Pinned;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Title))
            {
                body["title"] = request.Title;
            }
            Dictionary<string, string> realHeaders = new Dictionary<string, string>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.CommonHeaders))
            {
                realHeaders = headers.CommonHeaders;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(headers.XOpenAgentIdempotencyKey))
            {
                realHeaders["X-OpenAgent-Idempotency-Key"] = AlibabaCloud.TeaUtil.Common.ToJSONString(headers.XOpenAgentIdempotencyKey);
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = realHeaders,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateSession",
                Version = "2026-08-01",
                Protocol = "HTTPS",
                Pathname = "/openapi/v1/agent/sessions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(sessionId),
                Method = "PATCH",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateSessionResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the title or pinned status of a session.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Updates the title or pinned status of a specified session. Specify at least one of the title and pinned fields. Unspecified fields remain unchanged.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateSessionRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateSessionResponse
        /// </returns>
        public UpdateSessionResponse UpdateSession(string sessionId, UpdateSessionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateSessionHeaders headers = new UpdateSessionHeaders();
            return UpdateSessionWithOptions(sessionId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>Updates the title or pinned status of a session.</para>
        /// </summary>
        /// 
        /// <term><b>Description:</b></term>
        /// <description>
        /// <para>Updates the title or pinned status of a specified session. Specify at least one of the title and pinned fields. Unspecified fields remain unchanged.</para>
        /// </description>
        /// 
        /// <param name="request">
        /// UpdateSessionRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateSessionResponse
        /// </returns>
        public async Task<UpdateSessionResponse> UpdateSessionAsync(string sessionId, UpdateSessionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            UpdateSessionHeaders headers = new UpdateSessionHeaders();
            return await UpdateSessionWithOptionsAsync(sessionId, request, headers, runtime);
        }

    }
}
