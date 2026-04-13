// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.PAICopilot20250731.Models;

namespace AlibabaCloud.SDK.PAICopilot20250731
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "";
            CheckConfig(config);
            this._endpoint = GetEndpoint("paicopilot", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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
        /// <para>CreateChat</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateChatRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateChatResponse
        /// </returns>
        public CreateChatResponse CreateChatWithOptions(string SessionId, CreateChatRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtraData))
            {
                body["ExtraData"] = request.ExtraData;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Payload))
            {
                body["Payload"] = request.Payload;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Question))
            {
                body["Question"] = request.Question;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Title))
            {
                body["Title"] = request.Title;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateChat",
                Version = "2025-07-31",
                Protocol = "HTTPS",
                Pathname = "/api/v1/sessions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(SessionId) + "/chats",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateChatResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>CreateChat</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateChatRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateChatResponse
        /// </returns>
        public async Task<CreateChatResponse> CreateChatWithOptionsAsync(string SessionId, CreateChatRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ExtraData))
            {
                body["ExtraData"] = request.ExtraData;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Payload))
            {
                body["Payload"] = request.Payload;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Question))
            {
                body["Question"] = request.Question;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Title))
            {
                body["Title"] = request.Title;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateChat",
                Version = "2025-07-31",
                Protocol = "HTTPS",
                Pathname = "/api/v1/sessions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(SessionId) + "/chats",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateChatResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>CreateChat</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateChatRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateChatResponse
        /// </returns>
        public CreateChatResponse CreateChat(string SessionId, CreateChatRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateChatWithOptions(SessionId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>CreateChat</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateChatRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateChatResponse
        /// </returns>
        public async Task<CreateChatResponse> CreateChatAsync(string SessionId, CreateChatRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateChatWithOptionsAsync(SessionId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>/api/v1/sessions</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateSessionRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateSessionResponse
        /// </returns>
        public CreateSessionResponse CreateSessionWithOptions(CreateSessionRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Labels))
            {
                body["Labels"] = request.Labels;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Title))
            {
                body["Title"] = request.Title;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateSession",
                Version = "2025-07-31",
                Protocol = "HTTPS",
                Pathname = "/api/v1/sessions",
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
        /// <para>/api/v1/sessions</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateSessionRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateSessionResponse
        /// </returns>
        public async Task<CreateSessionResponse> CreateSessionWithOptionsAsync(CreateSessionRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Labels))
            {
                body["Labels"] = request.Labels;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Title))
            {
                body["Title"] = request.Title;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateSession",
                Version = "2025-07-31",
                Protocol = "HTTPS",
                Pathname = "/api/v1/sessions",
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
        /// <para>/api/v1/sessions</para>
        /// </summary>
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
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateSessionWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>/api/v1/sessions</para>
        /// </summary>
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
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateSessionWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>DeleteChat</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteChatRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteChatResponse
        /// </returns>
        public DeleteChatResponse DeleteChatWithOptions(string SessionId, string ChatId, DeleteChatRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteChat",
                Version = "2025-07-31",
                Protocol = "HTTPS",
                Pathname = "/api/v1/sessions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(SessionId) + "/chats/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ChatId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteChatResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>DeleteChat</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteChatRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteChatResponse
        /// </returns>
        public async Task<DeleteChatResponse> DeleteChatWithOptionsAsync(string SessionId, string ChatId, DeleteChatRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteChat",
                Version = "2025-07-31",
                Protocol = "HTTPS",
                Pathname = "/api/v1/sessions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(SessionId) + "/chats/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ChatId),
                Method = "DELETE",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteChatResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>DeleteChat</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteChatRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteChatResponse
        /// </returns>
        public DeleteChatResponse DeleteChat(string SessionId, string ChatId, DeleteChatRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteChatWithOptions(SessionId, ChatId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>DeleteChat</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteChatRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteChatResponse
        /// </returns>
        public async Task<DeleteChatResponse> DeleteChatAsync(string SessionId, string ChatId, DeleteChatRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteChatWithOptionsAsync(SessionId, ChatId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>DeleteSession</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteSessionRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteSessionResponse
        /// </returns>
        public DeleteSessionResponse DeleteSessionWithOptions(string SessionId, DeleteSessionRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteSession",
                Version = "2025-07-31",
                Protocol = "HTTPS",
                Pathname = "/api/v1/sessions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(SessionId),
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
        /// <para>DeleteSession</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteSessionRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteSessionResponse
        /// </returns>
        public async Task<DeleteSessionResponse> DeleteSessionWithOptionsAsync(string SessionId, DeleteSessionRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteSession",
                Version = "2025-07-31",
                Protocol = "HTTPS",
                Pathname = "/api/v1/sessions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(SessionId),
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
        /// <para>DeleteSession</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteSessionRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteSessionResponse
        /// </returns>
        public DeleteSessionResponse DeleteSession(string SessionId, DeleteSessionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteSessionWithOptions(SessionId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>DeleteSession</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteSessionRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteSessionResponse
        /// </returns>
        public async Task<DeleteSessionResponse> DeleteSessionAsync(string SessionId, DeleteSessionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteSessionWithOptionsAsync(SessionId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>GetChat</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetChatRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetChatResponse
        /// </returns>
        public GetChatResponse GetChatWithOptions(string ChatId, string SessionId, GetChatRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Verbose))
            {
                query["Verbose"] = request.Verbose;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetChat",
                Version = "2025-07-31",
                Protocol = "HTTPS",
                Pathname = "/api/v1/sessions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(SessionId) + "/chats/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ChatId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetChatResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>GetChat</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetChatRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// GetChatResponse
        /// </returns>
        public async Task<GetChatResponse> GetChatWithOptionsAsync(string ChatId, string SessionId, GetChatRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Verbose))
            {
                query["Verbose"] = request.Verbose;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetChat",
                Version = "2025-07-31",
                Protocol = "HTTPS",
                Pathname = "/api/v1/sessions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(SessionId) + "/chats/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(ChatId),
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<GetChatResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>GetChat</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetChatRequest
        /// </param>
        /// 
        /// <returns>
        /// GetChatResponse
        /// </returns>
        public GetChatResponse GetChat(string ChatId, string SessionId, GetChatRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetChatWithOptions(ChatId, SessionId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>GetChat</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetChatRequest
        /// </param>
        /// 
        /// <returns>
        /// GetChatResponse
        /// </returns>
        public async Task<GetChatResponse> GetChatAsync(string ChatId, string SessionId, GetChatRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetChatWithOptionsAsync(ChatId, SessionId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>GetSession</para>
        /// </summary>
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
        public GetSessionResponse GetSessionWithOptions(string SessionId, GetSessionRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetSession",
                Version = "2025-07-31",
                Protocol = "HTTPS",
                Pathname = "/api/v1/sessions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(SessionId),
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
        /// <para>GetSession</para>
        /// </summary>
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
        public async Task<GetSessionResponse> GetSessionWithOptionsAsync(string SessionId, GetSessionRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "GetSession",
                Version = "2025-07-31",
                Protocol = "HTTPS",
                Pathname = "/api/v1/sessions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(SessionId),
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
        /// <para>GetSession</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetSessionRequest
        /// </param>
        /// 
        /// <returns>
        /// GetSessionResponse
        /// </returns>
        public GetSessionResponse GetSession(string SessionId, GetSessionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return GetSessionWithOptions(SessionId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>GetSession</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// GetSessionRequest
        /// </param>
        /// 
        /// <returns>
        /// GetSessionResponse
        /// </returns>
        public async Task<GetSessionResponse> GetSessionAsync(string SessionId, GetSessionRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await GetSessionWithOptionsAsync(SessionId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>ListChats</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListChatsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListChatsResponse
        /// </returns>
        public ListChatsResponse ListChatsWithOptions(string SessionId, ListChatsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Order))
            {
                query["Order"] = request.Order;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortBy))
            {
                query["SortBy"] = request.SortBy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Verbose))
            {
                query["Verbose"] = request.Verbose;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListChats",
                Version = "2025-07-31",
                Protocol = "HTTPS",
                Pathname = "/api/v1/sessions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(SessionId) + "/chats",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListChatsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>ListChats</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListChatsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListChatsResponse
        /// </returns>
        public async Task<ListChatsResponse> ListChatsWithOptionsAsync(string SessionId, ListChatsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Order))
            {
                query["Order"] = request.Order;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortBy))
            {
                query["SortBy"] = request.SortBy;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Verbose))
            {
                query["Verbose"] = request.Verbose;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListChats",
                Version = "2025-07-31",
                Protocol = "HTTPS",
                Pathname = "/api/v1/sessions/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(SessionId) + "/chats",
                Method = "GET",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListChatsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>ListChats</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListChatsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListChatsResponse
        /// </returns>
        public ListChatsResponse ListChats(string SessionId, ListChatsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListChatsWithOptions(SessionId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>ListChats</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListChatsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListChatsResponse
        /// </returns>
        public async Task<ListChatsResponse> ListChatsAsync(string SessionId, ListChatsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListChatsWithOptionsAsync(SessionId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>GetChat</para>
        /// </summary>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Labels))
            {
                query["Labels"] = request.Labels;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Order))
            {
                query["Order"] = request.Order;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortBy))
            {
                query["SortBy"] = request.SortBy;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListSessions",
                Version = "2025-07-31",
                Protocol = "HTTPS",
                Pathname = "/api/v1/sessions",
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
        /// <para>GetChat</para>
        /// </summary>
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
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Labels))
            {
                query["Labels"] = request.Labels;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Order))
            {
                query["Order"] = request.Order;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageNumber))
            {
                query["PageNumber"] = request.PageNumber;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PageSize))
            {
                query["PageSize"] = request.PageSize;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SortBy))
            {
                query["SortBy"] = request.SortBy;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListSessions",
                Version = "2025-07-31",
                Protocol = "HTTPS",
                Pathname = "/api/v1/sessions",
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
        /// <para>GetChat</para>
        /// </summary>
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
        /// <para>GetChat</para>
        /// </summary>
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
        /// <para>/api/v1/sessions</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SearchInfoRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SearchInfoResponse
        /// </returns>
        public SearchInfoResponse SearchInfoWithOptions(SearchInfoRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KnowledgeBaseFilters))
            {
                body["KnowledgeBaseFilters"] = request.KnowledgeBaseFilters;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WebFilters))
            {
                body["WebFilters"] = request.WebFilters;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SearchInfo",
                Version = "2025-07-31",
                Protocol = "HTTPS",
                Pathname = "/api/v1/searches",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<SearchInfoResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>/api/v1/sessions</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SearchInfoRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SearchInfoResponse
        /// </returns>
        public async Task<SearchInfoResponse> SearchInfoWithOptionsAsync(SearchInfoRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KnowledgeBaseFilters))
            {
                body["KnowledgeBaseFilters"] = request.KnowledgeBaseFilters;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WebFilters))
            {
                body["WebFilters"] = request.WebFilters;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SearchInfo",
                Version = "2025-07-31",
                Protocol = "HTTPS",
                Pathname = "/api/v1/searches",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<SearchInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>/api/v1/sessions</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SearchInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// SearchInfoResponse
        /// </returns>
        public SearchInfoResponse SearchInfo(SearchInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return SearchInfoWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>/api/v1/sessions</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SearchInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// SearchInfoResponse
        /// </returns>
        public async Task<SearchInfoResponse> SearchInfoAsync(SearchInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await SearchInfoWithOptionsAsync(request, headers, runtime);
        }

    }
}
