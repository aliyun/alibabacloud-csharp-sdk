// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.DataAnalysisGBI20240823.Models;

namespace AlibabaCloud.SDK.DataAnalysisGBI20240823
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "";
            CheckConfig(config);
            this._endpoint = GetEndpoint("dataanalysisgbi", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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
        /// <para>批量删除当前指定业务空间下的同义词</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BatchDeleteSynonymsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// BatchDeleteSynonymsResponse
        /// </returns>
        public BatchDeleteSynonymsResponse BatchDeleteSynonymsWithOptions(BatchDeleteSynonymsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["workspaceId"] = request.WorkspaceId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SynonymIdKeys))
            {
                body["synonymIdKeys"] = request.SynonymIdKeys;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BatchDeleteSynonyms",
                Version = "2024-08-23",
                Protocol = "HTTPS",
                Pathname = "/gbi/batchDelete/synonyms",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchDeleteSynonymsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量删除当前指定业务空间下的同义词</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BatchDeleteSynonymsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// BatchDeleteSynonymsResponse
        /// </returns>
        public async Task<BatchDeleteSynonymsResponse> BatchDeleteSynonymsWithOptionsAsync(BatchDeleteSynonymsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["workspaceId"] = request.WorkspaceId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SynonymIdKeys))
            {
                body["synonymIdKeys"] = request.SynonymIdKeys;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "BatchDeleteSynonyms",
                Version = "2024-08-23",
                Protocol = "HTTPS",
                Pathname = "/gbi/batchDelete/synonyms",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<BatchDeleteSynonymsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量删除当前指定业务空间下的同义词</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BatchDeleteSynonymsRequest
        /// </param>
        /// 
        /// <returns>
        /// BatchDeleteSynonymsResponse
        /// </returns>
        public BatchDeleteSynonymsResponse BatchDeleteSynonyms(BatchDeleteSynonymsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return BatchDeleteSynonymsWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>批量删除当前指定业务空间下的同义词</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// BatchDeleteSynonymsRequest
        /// </param>
        /// 
        /// <returns>
        /// BatchDeleteSynonymsResponse
        /// </returns>
        public async Task<BatchDeleteSynonymsResponse> BatchDeleteSynonymsAsync(BatchDeleteSynonymsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await BatchDeleteSynonymsWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>取消关联的数据源授权</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CancelDatasourceAuthorizationRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CancelDatasourceAuthorizationResponse
        /// </returns>
        public CancelDatasourceAuthorizationResponse CancelDatasourceAuthorizationWithOptions(CancelDatasourceAuthorizationRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["workspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CancelDatasourceAuthorization",
                Version = "2024-08-23",
                Protocol = "HTTPS",
                Pathname = "/gbi/cancel/datasource",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CancelDatasourceAuthorizationResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>取消关联的数据源授权</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CancelDatasourceAuthorizationRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CancelDatasourceAuthorizationResponse
        /// </returns>
        public async Task<CancelDatasourceAuthorizationResponse> CancelDatasourceAuthorizationWithOptionsAsync(CancelDatasourceAuthorizationRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["workspaceId"] = request.WorkspaceId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CancelDatasourceAuthorization",
                Version = "2024-08-23",
                Protocol = "HTTPS",
                Pathname = "/gbi/cancel/datasource",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CancelDatasourceAuthorizationResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>取消关联的数据源授权</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CancelDatasourceAuthorizationRequest
        /// </param>
        /// 
        /// <returns>
        /// CancelDatasourceAuthorizationResponse
        /// </returns>
        public CancelDatasourceAuthorizationResponse CancelDatasourceAuthorization(CancelDatasourceAuthorizationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CancelDatasourceAuthorizationWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>取消关联的数据源授权</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CancelDatasourceAuthorizationRequest
        /// </param>
        /// 
        /// <returns>
        /// CancelDatasourceAuthorizationResponse
        /// </returns>
        public async Task<CancelDatasourceAuthorizationResponse> CancelDatasourceAuthorizationAsync(CancelDatasourceAuthorizationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CancelDatasourceAuthorizationWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>在指定的业务空间下创建新的业务逻辑解释</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateBusinessLogicRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateBusinessLogicResponse
        /// </returns>
        public CreateBusinessLogicResponse CreateBusinessLogicWithOptions(CreateBusinessLogicRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["workspaceId"] = request.WorkspaceId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
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
                Action = "CreateBusinessLogic",
                Version = "2024-08-23",
                Protocol = "HTTPS",
                Pathname = "/gbi/create/logic",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateBusinessLogicResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>在指定的业务空间下创建新的业务逻辑解释</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateBusinessLogicRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateBusinessLogicResponse
        /// </returns>
        public async Task<CreateBusinessLogicResponse> CreateBusinessLogicWithOptionsAsync(CreateBusinessLogicRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["workspaceId"] = request.WorkspaceId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
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
                Action = "CreateBusinessLogic",
                Version = "2024-08-23",
                Protocol = "HTTPS",
                Pathname = "/gbi/create/logic",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateBusinessLogicResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>在指定的业务空间下创建新的业务逻辑解释</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateBusinessLogicRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateBusinessLogicResponse
        /// </returns>
        public CreateBusinessLogicResponse CreateBusinessLogic(CreateBusinessLogicRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateBusinessLogicWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>在指定的业务空间下创建新的业务逻辑解释</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateBusinessLogicRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateBusinessLogicResponse
        /// </returns>
        public async Task<CreateBusinessLogicResponse> CreateBusinessLogicAsync(CreateBusinessLogicRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateBusinessLogicWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建数据库关联授权</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateDatasourceAuthorizationRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateDatasourceAuthorizationResponse
        /// </returns>
        public CreateDatasourceAuthorizationResponse CreateDatasourceAuthorizationWithOptions(CreateDatasourceAuthorizationRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["workspaceId"] = request.WorkspaceId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Password))
            {
                body["password"] = request.Password;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                body["type"] = request.Type;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                body["url"] = request.Url;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserName))
            {
                body["userName"] = request.UserName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VdbId))
            {
                body["vdbId"] = request.VdbId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateDatasourceAuthorization",
                Version = "2024-08-23",
                Protocol = "HTTPS",
                Pathname = "/gbi/create/datasource",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateDatasourceAuthorizationResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建数据库关联授权</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateDatasourceAuthorizationRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateDatasourceAuthorizationResponse
        /// </returns>
        public async Task<CreateDatasourceAuthorizationResponse> CreateDatasourceAuthorizationWithOptionsAsync(CreateDatasourceAuthorizationRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["workspaceId"] = request.WorkspaceId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Password))
            {
                body["password"] = request.Password;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                body["type"] = request.Type;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Url))
            {
                body["url"] = request.Url;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.UserName))
            {
                body["userName"] = request.UserName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VdbId))
            {
                body["vdbId"] = request.VdbId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateDatasourceAuthorization",
                Version = "2024-08-23",
                Protocol = "HTTPS",
                Pathname = "/gbi/create/datasource",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateDatasourceAuthorizationResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建数据库关联授权</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateDatasourceAuthorizationRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateDatasourceAuthorizationResponse
        /// </returns>
        public CreateDatasourceAuthorizationResponse CreateDatasourceAuthorization(CreateDatasourceAuthorizationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateDatasourceAuthorizationWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>创建数据库关联授权</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateDatasourceAuthorizationRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateDatasourceAuthorizationResponse
        /// </returns>
        public async Task<CreateDatasourceAuthorizationResponse> CreateDatasourceAuthorizationAsync(CreateDatasourceAuthorizationRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateDatasourceAuthorizationWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>在当前指定的业务空间下面，新建同义词</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateSynonymsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateSynonymsResponse
        /// </returns>
        public CreateSynonymsResponse CreateSynonymsWithOptions(CreateSynonymsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["workspaceId"] = request.WorkspaceId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Columns))
            {
                body["columns"] = request.Columns;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Word))
            {
                body["word"] = request.Word;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WordSynonyms))
            {
                body["wordSynonyms"] = request.WordSynonyms;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateSynonyms",
                Version = "2024-08-23",
                Protocol = "HTTPS",
                Pathname = "/gbi/create/synonyms",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateSynonymsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>在当前指定的业务空间下面，新建同义词</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateSynonymsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateSynonymsResponse
        /// </returns>
        public async Task<CreateSynonymsResponse> CreateSynonymsWithOptionsAsync(CreateSynonymsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["workspaceId"] = request.WorkspaceId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Columns))
            {
                body["columns"] = request.Columns;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Word))
            {
                body["word"] = request.Word;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WordSynonyms))
            {
                body["wordSynonyms"] = request.WordSynonyms;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "CreateSynonyms",
                Version = "2024-08-23",
                Protocol = "HTTPS",
                Pathname = "/gbi/create/synonyms",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateSynonymsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>在当前指定的业务空间下面，新建同义词</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateSynonymsRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateSynonymsResponse
        /// </returns>
        public CreateSynonymsResponse CreateSynonyms(CreateSynonymsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateSynonymsWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>在当前指定的业务空间下面，新建同义词</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateSynonymsRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateSynonymsResponse
        /// </returns>
        public async Task<CreateSynonymsResponse> CreateSynonymsAsync(CreateSynonymsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateSynonymsWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>在指定的业务空间创建虚拟数据源</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateVirtualDatasourceInstanceRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateVirtualDatasourceInstanceResponse
        /// </returns>
        public CreateVirtualDatasourceInstanceResponse CreateVirtualDatasourceInstanceWithOptions(CreateVirtualDatasourceInstanceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["workspaceId"] = request.WorkspaceId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
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
                Action = "CreateVirtualDatasourceInstance",
                Version = "2024-08-23",
                Protocol = "HTTPS",
                Pathname = "/gbi/virtualDatasource/createVirtualDatasourceInstance",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateVirtualDatasourceInstanceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>在指定的业务空间创建虚拟数据源</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateVirtualDatasourceInstanceRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// CreateVirtualDatasourceInstanceResponse
        /// </returns>
        public async Task<CreateVirtualDatasourceInstanceResponse> CreateVirtualDatasourceInstanceWithOptionsAsync(CreateVirtualDatasourceInstanceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["workspaceId"] = request.WorkspaceId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
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
                Action = "CreateVirtualDatasourceInstance",
                Version = "2024-08-23",
                Protocol = "HTTPS",
                Pathname = "/gbi/virtualDatasource/createVirtualDatasourceInstance",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<CreateVirtualDatasourceInstanceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>在指定的业务空间创建虚拟数据源</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateVirtualDatasourceInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateVirtualDatasourceInstanceResponse
        /// </returns>
        public CreateVirtualDatasourceInstanceResponse CreateVirtualDatasourceInstance(CreateVirtualDatasourceInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return CreateVirtualDatasourceInstanceWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>在指定的业务空间创建虚拟数据源</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// CreateVirtualDatasourceInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// CreateVirtualDatasourceInstanceResponse
        /// </returns>
        public async Task<CreateVirtualDatasourceInstanceResponse> CreateVirtualDatasourceInstanceAsync(CreateVirtualDatasourceInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await CreateVirtualDatasourceInstanceWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除指定业务空间下所指定的业务逻辑解释</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteBusinessLogicRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteBusinessLogicResponse
        /// </returns>
        public DeleteBusinessLogicResponse DeleteBusinessLogicWithOptions(DeleteBusinessLogicRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["workspaceId"] = request.WorkspaceId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BusinessLogicIdKeys))
            {
                body["businessLogicIdKeys"] = request.BusinessLogicIdKeys;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteBusinessLogic",
                Version = "2024-08-23",
                Protocol = "HTTPS",
                Pathname = "/gbi/delete/logic",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteBusinessLogicResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除指定业务空间下所指定的业务逻辑解释</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteBusinessLogicRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteBusinessLogicResponse
        /// </returns>
        public async Task<DeleteBusinessLogicResponse> DeleteBusinessLogicWithOptionsAsync(DeleteBusinessLogicRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["workspaceId"] = request.WorkspaceId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BusinessLogicIdKeys))
            {
                body["businessLogicIdKeys"] = request.BusinessLogicIdKeys;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteBusinessLogic",
                Version = "2024-08-23",
                Protocol = "HTTPS",
                Pathname = "/gbi/delete/logic",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteBusinessLogicResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除指定业务空间下所指定的业务逻辑解释</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteBusinessLogicRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteBusinessLogicResponse
        /// </returns>
        public DeleteBusinessLogicResponse DeleteBusinessLogic(DeleteBusinessLogicRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteBusinessLogicWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除指定业务空间下所指定的业务逻辑解释</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteBusinessLogicRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteBusinessLogicResponse
        /// </returns>
        public async Task<DeleteBusinessLogicResponse> DeleteBusinessLogicAsync(DeleteBusinessLogicRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteBusinessLogicWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>从当前所指定的业务空间中，删除所指定的列</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteColumnRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteColumnResponse
        /// </returns>
        public DeleteColumnResponse DeleteColumnWithOptions(DeleteColumnRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["workspaceId"] = request.WorkspaceId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ColumnIdKey))
            {
                body["columnIdKey"] = request.ColumnIdKey;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteColumn",
                Version = "2024-08-23",
                Protocol = "HTTPS",
                Pathname = "/gbi/delete/column",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteColumnResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>从当前所指定的业务空间中，删除所指定的列</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteColumnRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteColumnResponse
        /// </returns>
        public async Task<DeleteColumnResponse> DeleteColumnWithOptionsAsync(DeleteColumnRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["workspaceId"] = request.WorkspaceId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ColumnIdKey))
            {
                body["columnIdKey"] = request.ColumnIdKey;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteColumn",
                Version = "2024-08-23",
                Protocol = "HTTPS",
                Pathname = "/gbi/delete/column",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteColumnResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>从当前所指定的业务空间中，删除所指定的列</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteColumnRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteColumnResponse
        /// </returns>
        public DeleteColumnResponse DeleteColumn(DeleteColumnRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteColumnWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>从当前所指定的业务空间中，删除所指定的列</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteColumnRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteColumnResponse
        /// </returns>
        public async Task<DeleteColumnResponse> DeleteColumnAsync(DeleteColumnRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteColumnWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>将当前指定数据表从指定业务空间管控中删除</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteSelectedTableRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteSelectedTableResponse
        /// </returns>
        public DeleteSelectedTableResponse DeleteSelectedTableWithOptions(DeleteSelectedTableRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["workspaceId"] = request.WorkspaceId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TableIdKey))
            {
                body["tableIdKey"] = request.TableIdKey;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteSelectedTable",
                Version = "2024-08-23",
                Protocol = "HTTPS",
                Pathname = "/gbi/delete/table",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteSelectedTableResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>将当前指定数据表从指定业务空间管控中删除</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteSelectedTableRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteSelectedTableResponse
        /// </returns>
        public async Task<DeleteSelectedTableResponse> DeleteSelectedTableWithOptionsAsync(DeleteSelectedTableRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["workspaceId"] = request.WorkspaceId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TableIdKey))
            {
                body["tableIdKey"] = request.TableIdKey;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteSelectedTable",
                Version = "2024-08-23",
                Protocol = "HTTPS",
                Pathname = "/gbi/delete/table",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteSelectedTableResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>将当前指定数据表从指定业务空间管控中删除</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteSelectedTableRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteSelectedTableResponse
        /// </returns>
        public DeleteSelectedTableResponse DeleteSelectedTable(DeleteSelectedTableRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteSelectedTableWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>将当前指定数据表从指定业务空间管控中删除</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteSelectedTableRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteSelectedTableResponse
        /// </returns>
        public async Task<DeleteSelectedTableResponse> DeleteSelectedTableAsync(DeleteSelectedTableRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteSelectedTableWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除指定业务空间下面的虚拟数据源实例</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteVirtualDatasourceInstanceRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteVirtualDatasourceInstanceResponse
        /// </returns>
        public DeleteVirtualDatasourceInstanceResponse DeleteVirtualDatasourceInstanceWithOptions(DeleteVirtualDatasourceInstanceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["workspaceId"] = request.WorkspaceId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VdbId))
            {
                body["vdbId"] = request.VdbId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteVirtualDatasourceInstance",
                Version = "2024-08-23",
                Protocol = "HTTPS",
                Pathname = "/gbi/virtualDatasource/deleteVirtualDatasourceInstance",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteVirtualDatasourceInstanceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除指定业务空间下面的虚拟数据源实例</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteVirtualDatasourceInstanceRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// DeleteVirtualDatasourceInstanceResponse
        /// </returns>
        public async Task<DeleteVirtualDatasourceInstanceResponse> DeleteVirtualDatasourceInstanceWithOptionsAsync(DeleteVirtualDatasourceInstanceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["workspaceId"] = request.WorkspaceId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VdbId))
            {
                body["vdbId"] = request.VdbId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "DeleteVirtualDatasourceInstance",
                Version = "2024-08-23",
                Protocol = "HTTPS",
                Pathname = "/gbi/virtualDatasource/deleteVirtualDatasourceInstance",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<DeleteVirtualDatasourceInstanceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除指定业务空间下面的虚拟数据源实例</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteVirtualDatasourceInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteVirtualDatasourceInstanceResponse
        /// </returns>
        public DeleteVirtualDatasourceInstanceResponse DeleteVirtualDatasourceInstance(DeleteVirtualDatasourceInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return DeleteVirtualDatasourceInstanceWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>删除指定业务空间下面的虚拟数据源实例</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// DeleteVirtualDatasourceInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// DeleteVirtualDatasourceInstanceResponse
        /// </returns>
        public async Task<DeleteVirtualDatasourceInstanceResponse> DeleteVirtualDatasourceInstanceAsync(DeleteVirtualDatasourceInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await DeleteVirtualDatasourceInstanceWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取当前指定业务空间下的企业知识名词解释列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListBusinessLogicRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListBusinessLogicResponse
        /// </returns>
        public ListBusinessLogicResponse ListBusinessLogicWithOptions(ListBusinessLogicRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["workspaceId"] = request.WorkspaceId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                body["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                body["nextToken"] = request.NextToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListBusinessLogic",
                Version = "2024-08-23",
                Protocol = "HTTPS",
                Pathname = "/gbi/list/logic",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListBusinessLogicResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取当前指定业务空间下的企业知识名词解释列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListBusinessLogicRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListBusinessLogicResponse
        /// </returns>
        public async Task<ListBusinessLogicResponse> ListBusinessLogicWithOptionsAsync(ListBusinessLogicRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["workspaceId"] = request.WorkspaceId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                body["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                body["nextToken"] = request.NextToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListBusinessLogic",
                Version = "2024-08-23",
                Protocol = "HTTPS",
                Pathname = "/gbi/list/logic",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListBusinessLogicResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取当前指定业务空间下的企业知识名词解释列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListBusinessLogicRequest
        /// </param>
        /// 
        /// <returns>
        /// ListBusinessLogicResponse
        /// </returns>
        public ListBusinessLogicResponse ListBusinessLogic(ListBusinessLogicRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListBusinessLogicWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取当前指定业务空间下的企业知识名词解释列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListBusinessLogicRequest
        /// </param>
        /// 
        /// <returns>
        /// ListBusinessLogicResponse
        /// </returns>
        public async Task<ListBusinessLogicResponse> ListBusinessLogicAsync(ListBusinessLogicRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListBusinessLogicWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取当前指定业务空间，指定表下面的列信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListColumnRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListColumnResponse
        /// </returns>
        public ListColumnResponse ListColumnWithOptions(ListColumnRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["workspaceId"] = request.WorkspaceId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                body["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                body["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TableIdKey))
            {
                body["tableIdKey"] = request.TableIdKey;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListColumn",
                Version = "2024-08-23",
                Protocol = "HTTPS",
                Pathname = "/gbi/list/column",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListColumnResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取当前指定业务空间，指定表下面的列信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListColumnRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListColumnResponse
        /// </returns>
        public async Task<ListColumnResponse> ListColumnWithOptionsAsync(ListColumnRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["workspaceId"] = request.WorkspaceId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                body["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                body["nextToken"] = request.NextToken;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TableIdKey))
            {
                body["tableIdKey"] = request.TableIdKey;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListColumn",
                Version = "2024-08-23",
                Protocol = "HTTPS",
                Pathname = "/gbi/list/column",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListColumnResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取当前指定业务空间，指定表下面的列信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListColumnRequest
        /// </param>
        /// 
        /// <returns>
        /// ListColumnResponse
        /// </returns>
        public ListColumnResponse ListColumn(ListColumnRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListColumnWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取当前指定业务空间，指定表下面的列信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListColumnRequest
        /// </param>
        /// 
        /// <returns>
        /// ListColumnResponse
        /// </returns>
        public async Task<ListColumnResponse> ListColumnAsync(ListColumnRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListColumnWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取当前业务空间，指定表、列下的枚举值</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListEnumMappingRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListEnumMappingResponse
        /// </returns>
        public ListEnumMappingResponse ListEnumMappingWithOptions(ListEnumMappingRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["workspaceId"] = request.WorkspaceId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ColumnIdKey))
            {
                body["columnIdKey"] = request.ColumnIdKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TableIdKey))
            {
                body["tableIdKey"] = request.TableIdKey;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListEnumMapping",
                Version = "2024-08-23",
                Protocol = "HTTPS",
                Pathname = "/gbi/list/mapping",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListEnumMappingResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取当前业务空间，指定表、列下的枚举值</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListEnumMappingRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListEnumMappingResponse
        /// </returns>
        public async Task<ListEnumMappingResponse> ListEnumMappingWithOptionsAsync(ListEnumMappingRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["workspaceId"] = request.WorkspaceId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ColumnIdKey))
            {
                body["columnIdKey"] = request.ColumnIdKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TableIdKey))
            {
                body["tableIdKey"] = request.TableIdKey;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListEnumMapping",
                Version = "2024-08-23",
                Protocol = "HTTPS",
                Pathname = "/gbi/list/mapping",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListEnumMappingResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取当前业务空间，指定表、列下的枚举值</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListEnumMappingRequest
        /// </param>
        /// 
        /// <returns>
        /// ListEnumMappingResponse
        /// </returns>
        public ListEnumMappingResponse ListEnumMapping(ListEnumMappingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListEnumMappingWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取当前业务空间，指定表、列下的枚举值</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListEnumMappingRequest
        /// </param>
        /// 
        /// <returns>
        /// ListEnumMappingResponse
        /// </returns>
        public async Task<ListEnumMappingResponse> ListEnumMappingAsync(ListEnumMappingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListEnumMappingWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取当前业务空间处于以关联状态的数据表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListSelectedTablesRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListSelectedTablesResponse
        /// </returns>
        public ListSelectedTablesResponse ListSelectedTablesWithOptions(ListSelectedTablesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["workspaceId"] = request.WorkspaceId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                body["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                body["nextToken"] = request.NextToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListSelectedTables",
                Version = "2024-08-23",
                Protocol = "HTTPS",
                Pathname = "/gbi/list/datasource/table",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListSelectedTablesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取当前业务空间处于以关联状态的数据表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListSelectedTablesRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListSelectedTablesResponse
        /// </returns>
        public async Task<ListSelectedTablesResponse> ListSelectedTablesWithOptionsAsync(ListSelectedTablesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["workspaceId"] = request.WorkspaceId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                body["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                body["nextToken"] = request.NextToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListSelectedTables",
                Version = "2024-08-23",
                Protocol = "HTTPS",
                Pathname = "/gbi/list/datasource/table",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListSelectedTablesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取当前业务空间处于以关联状态的数据表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListSelectedTablesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListSelectedTablesResponse
        /// </returns>
        public ListSelectedTablesResponse ListSelectedTables(ListSelectedTablesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListSelectedTablesWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取当前业务空间处于以关联状态的数据表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListSelectedTablesRequest
        /// </param>
        /// 
        /// <returns>
        /// ListSelectedTablesResponse
        /// </returns>
        public async Task<ListSelectedTablesResponse> ListSelectedTablesAsync(ListSelectedTablesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListSelectedTablesWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取当前指定业务空间下的同义词列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListSynonymsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListSynonymsResponse
        /// </returns>
        public ListSynonymsResponse ListSynonymsWithOptions(ListSynonymsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["workspaceId"] = request.WorkspaceId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                body["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                body["nextToken"] = request.NextToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListSynonyms",
                Version = "2024-08-23",
                Protocol = "HTTPS",
                Pathname = "/gbi/list/synonyms",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListSynonymsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取当前指定业务空间下的同义词列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListSynonymsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListSynonymsResponse
        /// </returns>
        public async Task<ListSynonymsResponse> ListSynonymsWithOptionsAsync(ListSynonymsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["workspaceId"] = request.WorkspaceId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                body["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                body["nextToken"] = request.NextToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListSynonyms",
                Version = "2024-08-23",
                Protocol = "HTTPS",
                Pathname = "/gbi/list/synonyms",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListSynonymsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取当前指定业务空间下的同义词列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListSynonymsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListSynonymsResponse
        /// </returns>
        public ListSynonymsResponse ListSynonyms(ListSynonymsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListSynonymsWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取当前指定业务空间下的同义词列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListSynonymsRequest
        /// </param>
        /// 
        /// <returns>
        /// ListSynonymsResponse
        /// </returns>
        public async Task<ListSynonymsResponse> ListSynonymsAsync(ListSynonymsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListSynonymsWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取当前业务空间下的数据源实例列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListVirtualDatasourceInstanceRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListVirtualDatasourceInstanceResponse
        /// </returns>
        public ListVirtualDatasourceInstanceResponse ListVirtualDatasourceInstanceWithOptions(ListVirtualDatasourceInstanceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["workspaceId"] = request.WorkspaceId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                body["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                body["nextToken"] = request.NextToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListVirtualDatasourceInstance",
                Version = "2024-08-23",
                Protocol = "HTTPS",
                Pathname = "/gbi/virtualDatasource/listVirtualDatasourceInstance",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListVirtualDatasourceInstanceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取当前业务空间下的数据源实例列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListVirtualDatasourceInstanceRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ListVirtualDatasourceInstanceResponse
        /// </returns>
        public async Task<ListVirtualDatasourceInstanceResponse> ListVirtualDatasourceInstanceWithOptionsAsync(ListVirtualDatasourceInstanceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["workspaceId"] = request.WorkspaceId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.MaxResults))
            {
                body["maxResults"] = request.MaxResults;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.NextToken))
            {
                body["nextToken"] = request.NextToken;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ListVirtualDatasourceInstance",
                Version = "2024-08-23",
                Protocol = "HTTPS",
                Pathname = "/gbi/virtualDatasource/listVirtualDatasourceInstance",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ListVirtualDatasourceInstanceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取当前业务空间下的数据源实例列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListVirtualDatasourceInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// ListVirtualDatasourceInstanceResponse
        /// </returns>
        public ListVirtualDatasourceInstanceResponse ListVirtualDatasourceInstance(ListVirtualDatasourceInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ListVirtualDatasourceInstanceWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>获取当前业务空间下的数据源实例列表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ListVirtualDatasourceInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// ListVirtualDatasourceInstanceResponse
        /// </returns>
        public async Task<ListVirtualDatasourceInstanceResponse> ListVirtualDatasourceInstanceAsync(ListVirtualDatasourceInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ListVirtualDatasourceInstanceWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>将指定数据表的数据列恢复到初始话状态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RecoverColumnRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RecoverColumnResponse
        /// </returns>
        public RecoverColumnResponse RecoverColumnWithOptions(RecoverColumnRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["workspaceId"] = request.WorkspaceId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ColumnIdKey))
            {
                body["columnIdKey"] = request.ColumnIdKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TableIdKey))
            {
                body["tableIdKey"] = request.TableIdKey;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecoverColumn",
                Version = "2024-08-23",
                Protocol = "HTTPS",
                Pathname = "/gbi/recover/column",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecoverColumnResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>将指定数据表的数据列恢复到初始话状态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RecoverColumnRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RecoverColumnResponse
        /// </returns>
        public async Task<RecoverColumnResponse> RecoverColumnWithOptionsAsync(RecoverColumnRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["workspaceId"] = request.WorkspaceId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ColumnIdKey))
            {
                body["columnIdKey"] = request.ColumnIdKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TableIdKey))
            {
                body["tableIdKey"] = request.TableIdKey;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RecoverColumn",
                Version = "2024-08-23",
                Protocol = "HTTPS",
                Pathname = "/gbi/recover/column",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RecoverColumnResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>将指定数据表的数据列恢复到初始话状态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RecoverColumnRequest
        /// </param>
        /// 
        /// <returns>
        /// RecoverColumnResponse
        /// </returns>
        public RecoverColumnResponse RecoverColumn(RecoverColumnRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return RecoverColumnWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>将指定数据表的数据列恢复到初始话状态</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RecoverColumnRequest
        /// </param>
        /// 
        /// <returns>
        /// RecoverColumnResponse
        /// </returns>
        public async Task<RecoverColumnResponse> RecoverColumnAsync(RecoverColumnRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await RecoverColumnWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>从远程数据库刷新当前所关联的数据表信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ResyncTableRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ResyncTableResponse
        /// </returns>
        public ResyncTableResponse ResyncTableWithOptions(ResyncTableRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["workspaceId"] = request.WorkspaceId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TableIdKey))
            {
                body["tableIdKey"] = request.TableIdKey;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ResyncTable",
                Version = "2024-08-23",
                Protocol = "HTTPS",
                Pathname = "/gbi/refresh/table",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ResyncTableResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>从远程数据库刷新当前所关联的数据表信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ResyncTableRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// ResyncTableResponse
        /// </returns>
        public async Task<ResyncTableResponse> ResyncTableWithOptionsAsync(ResyncTableRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["workspaceId"] = request.WorkspaceId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TableIdKey))
            {
                body["tableIdKey"] = request.TableIdKey;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "ResyncTable",
                Version = "2024-08-23",
                Protocol = "HTTPS",
                Pathname = "/gbi/refresh/table",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<ResyncTableResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>从远程数据库刷新当前所关联的数据表信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ResyncTableRequest
        /// </param>
        /// 
        /// <returns>
        /// ResyncTableResponse
        /// </returns>
        public ResyncTableResponse ResyncTable(ResyncTableRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return ResyncTableWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>从远程数据库刷新当前所关联的数据表信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// ResyncTableRequest
        /// </param>
        /// 
        /// <returns>
        /// ResyncTableResponse
        /// </returns>
        public async Task<ResyncTableResponse> ResyncTableAsync(ResyncTableRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await ResyncTableWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>运行数据分析</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RunDataAnalysisRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RunDataAnalysisResponse
        /// </returns>
        public RunDataAnalysisResponse RunDataAnalysisWithOptions(string workspaceId, RunDataAnalysisRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GenerateSqlOnly))
            {
                body["generateSqlOnly"] = request.GenerateSqlOnly;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Query))
            {
                body["query"] = request.Query;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionId))
            {
                body["sessionId"] = request.SessionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SpecificationType))
            {
                body["specificationType"] = request.SpecificationType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RunDataAnalysis",
                Version = "2024-08-23",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/gbi/runDataAnalysis",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RunDataAnalysisResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>运行数据分析</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RunDataAnalysisRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// RunDataAnalysisResponse
        /// </returns>
        public async Task<RunDataAnalysisResponse> RunDataAnalysisWithOptionsAsync(string workspaceId, RunDataAnalysisRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.GenerateSqlOnly))
            {
                body["generateSqlOnly"] = request.GenerateSqlOnly;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Query))
            {
                body["query"] = request.Query;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SessionId))
            {
                body["sessionId"] = request.SessionId;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SpecificationType))
            {
                body["specificationType"] = request.SpecificationType;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "RunDataAnalysis",
                Version = "2024-08-23",
                Protocol = "HTTPS",
                Pathname = "/" + AlibabaCloud.OpenApiUtil.Client.GetEncodeParam(workspaceId) + "/gbi/runDataAnalysis",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<RunDataAnalysisResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>运行数据分析</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RunDataAnalysisRequest
        /// </param>
        /// 
        /// <returns>
        /// RunDataAnalysisResponse
        /// </returns>
        public RunDataAnalysisResponse RunDataAnalysis(string workspaceId, RunDataAnalysisRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return RunDataAnalysisWithOptions(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>运行数据分析</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// RunDataAnalysisRequest
        /// </param>
        /// 
        /// <returns>
        /// RunDataAnalysisResponse
        /// </returns>
        public async Task<RunDataAnalysisResponse> RunDataAnalysisAsync(string workspaceId, RunDataAnalysisRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await RunDataAnalysisWithOptionsAsync(workspaceId, request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>向当前指定的业务空间下的指定虚拟数据源实例添加ddl语句</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SaveVirtualDatasourceDdlRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SaveVirtualDatasourceDdlResponse
        /// </returns>
        public SaveVirtualDatasourceDdlResponse SaveVirtualDatasourceDdlWithOptions(SaveVirtualDatasourceDdlRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["workspaceId"] = request.WorkspaceId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ddl))
            {
                body["ddl"] = request.Ddl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VdbId))
            {
                body["vdbId"] = request.VdbId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SaveVirtualDatasourceDdl",
                Version = "2024-08-23",
                Protocol = "HTTPS",
                Pathname = "/gbi/virtualDatasource/addDdl2VirtualInstance",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<SaveVirtualDatasourceDdlResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>向当前指定的业务空间下的指定虚拟数据源实例添加ddl语句</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SaveVirtualDatasourceDdlRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SaveVirtualDatasourceDdlResponse
        /// </returns>
        public async Task<SaveVirtualDatasourceDdlResponse> SaveVirtualDatasourceDdlWithOptionsAsync(SaveVirtualDatasourceDdlRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["workspaceId"] = request.WorkspaceId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Ddl))
            {
                body["ddl"] = request.Ddl;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VdbId))
            {
                body["vdbId"] = request.VdbId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SaveVirtualDatasourceDdl",
                Version = "2024-08-23",
                Protocol = "HTTPS",
                Pathname = "/gbi/virtualDatasource/addDdl2VirtualInstance",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<SaveVirtualDatasourceDdlResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>向当前指定的业务空间下的指定虚拟数据源实例添加ddl语句</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SaveVirtualDatasourceDdlRequest
        /// </param>
        /// 
        /// <returns>
        /// SaveVirtualDatasourceDdlResponse
        /// </returns>
        public SaveVirtualDatasourceDdlResponse SaveVirtualDatasourceDdl(SaveVirtualDatasourceDdlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return SaveVirtualDatasourceDdlWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>向当前指定的业务空间下的指定虚拟数据源实例添加ddl语句</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SaveVirtualDatasourceDdlRequest
        /// </param>
        /// 
        /// <returns>
        /// SaveVirtualDatasourceDdlResponse
        /// </returns>
        public async Task<SaveVirtualDatasourceDdlResponse> SaveVirtualDatasourceDdlAsync(SaveVirtualDatasourceDdlRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await SaveVirtualDatasourceDdlWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新当前业务空间所关联的数据表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SyncRemoteTablesRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SyncRemoteTablesResponse
        /// </returns>
        public SyncRemoteTablesResponse SyncRemoteTablesWithOptions(SyncRemoteTablesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["workspaceId"] = request.WorkspaceId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeepTableNames))
            {
                body["keepTableNames"] = request.KeepTableNames;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PullSamples))
            {
                body["pullSamples"] = request.PullSamples;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TableNames))
            {
                body["tableNames"] = request.TableNames;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SyncRemoteTables",
                Version = "2024-08-23",
                Protocol = "HTTPS",
                Pathname = "/gbi/update/datasource/tables",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<SyncRemoteTablesResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新当前业务空间所关联的数据表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SyncRemoteTablesRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// SyncRemoteTablesResponse
        /// </returns>
        public async Task<SyncRemoteTablesResponse> SyncRemoteTablesWithOptionsAsync(SyncRemoteTablesRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["workspaceId"] = request.WorkspaceId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.KeepTableNames))
            {
                body["keepTableNames"] = request.KeepTableNames;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PullSamples))
            {
                body["pullSamples"] = request.PullSamples;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TableNames))
            {
                body["tableNames"] = request.TableNames;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "SyncRemoteTables",
                Version = "2024-08-23",
                Protocol = "HTTPS",
                Pathname = "/gbi/update/datasource/tables",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<SyncRemoteTablesResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新当前业务空间所关联的数据表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SyncRemoteTablesRequest
        /// </param>
        /// 
        /// <returns>
        /// SyncRemoteTablesResponse
        /// </returns>
        public SyncRemoteTablesResponse SyncRemoteTables(SyncRemoteTablesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return SyncRemoteTablesWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>更新当前业务空间所关联的数据表</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// SyncRemoteTablesRequest
        /// </param>
        /// 
        /// <returns>
        /// SyncRemoteTablesResponse
        /// </returns>
        public async Task<SyncRemoteTablesResponse> SyncRemoteTablesAsync(SyncRemoteTablesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await SyncRemoteTablesWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改当前指定业务空间下所指定的业务逻辑解释</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateBusinessLogicRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateBusinessLogicResponse
        /// </returns>
        public UpdateBusinessLogicResponse UpdateBusinessLogicWithOptions(UpdateBusinessLogicRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["workspaceId"] = request.WorkspaceId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BusinessLogicIdKey))
            {
                body["businessLogicIdKey"] = request.BusinessLogicIdKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
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
                Action = "UpdateBusinessLogic",
                Version = "2024-08-23",
                Protocol = "HTTPS",
                Pathname = "/gbi/update/logic",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateBusinessLogicResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改当前指定业务空间下所指定的业务逻辑解释</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateBusinessLogicRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateBusinessLogicResponse
        /// </returns>
        public async Task<UpdateBusinessLogicResponse> UpdateBusinessLogicWithOptionsAsync(UpdateBusinessLogicRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["workspaceId"] = request.WorkspaceId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.BusinessLogicIdKey))
            {
                body["businessLogicIdKey"] = request.BusinessLogicIdKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
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
                Action = "UpdateBusinessLogic",
                Version = "2024-08-23",
                Protocol = "HTTPS",
                Pathname = "/gbi/update/logic",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateBusinessLogicResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改当前指定业务空间下所指定的业务逻辑解释</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateBusinessLogicRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateBusinessLogicResponse
        /// </returns>
        public UpdateBusinessLogicResponse UpdateBusinessLogic(UpdateBusinessLogicRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateBusinessLogicWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改当前指定业务空间下所指定的业务逻辑解释</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateBusinessLogicRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateBusinessLogicResponse
        /// </returns>
        public async Task<UpdateBusinessLogicResponse> UpdateBusinessLogicAsync(UpdateBusinessLogicRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateBusinessLogicWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改当前指定业务空间中，指定列的信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateColumnRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateColumnResponse
        /// </returns>
        public UpdateColumnResponse UpdateColumnWithOptions(UpdateColumnRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["workspaceId"] = request.WorkspaceId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChineseName))
            {
                body["chineseName"] = request.ChineseName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ColumnIdKey))
            {
                body["columnIdKey"] = request.ColumnIdKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnumType))
            {
                body["enumType"] = request.EnumType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnumValues))
            {
                body["enumValues"] = request.EnumValues;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RangeMax))
            {
                body["rangeMax"] = request.RangeMax;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RangeMin))
            {
                body["rangeMin"] = request.RangeMin;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Samples))
            {
                body["samples"] = request.Samples;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TableIdKey))
            {
                body["tableIdKey"] = request.TableIdKey;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateColumn",
                Version = "2024-08-23",
                Protocol = "HTTPS",
                Pathname = "/gbi/update/column",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateColumnResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改当前指定业务空间中，指定列的信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateColumnRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateColumnResponse
        /// </returns>
        public async Task<UpdateColumnResponse> UpdateColumnWithOptionsAsync(UpdateColumnRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["workspaceId"] = request.WorkspaceId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ChineseName))
            {
                body["chineseName"] = request.ChineseName;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ColumnIdKey))
            {
                body["columnIdKey"] = request.ColumnIdKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnumType))
            {
                body["enumType"] = request.EnumType;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnumValues))
            {
                body["enumValues"] = request.EnumValues;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RangeMax))
            {
                body["rangeMax"] = request.RangeMax;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.RangeMin))
            {
                body["rangeMin"] = request.RangeMin;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Samples))
            {
                body["samples"] = request.Samples;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TableIdKey))
            {
                body["tableIdKey"] = request.TableIdKey;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateColumn",
                Version = "2024-08-23",
                Protocol = "HTTPS",
                Pathname = "/gbi/update/column",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateColumnResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改当前指定业务空间中，指定列的信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateColumnRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateColumnResponse
        /// </returns>
        public UpdateColumnResponse UpdateColumn(UpdateColumnRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateColumnWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改当前指定业务空间中，指定列的信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateColumnRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateColumnResponse
        /// </returns>
        public async Task<UpdateColumnResponse> UpdateColumnAsync(UpdateColumnRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateColumnWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改当前指定业务空间指定列下的枚举值信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateEnumMappingRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateEnumMappingResponse
        /// </returns>
        public UpdateEnumMappingResponse UpdateEnumMappingWithOptions(UpdateEnumMappingRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["workspaceId"] = request.WorkspaceId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ColumnIdKey))
            {
                body["columnIdKey"] = request.ColumnIdKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnumMapping))
            {
                body["enumMapping"] = request.EnumMapping;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TableIdKey))
            {
                body["tableIdKey"] = request.TableIdKey;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateEnumMapping",
                Version = "2024-08-23",
                Protocol = "HTTPS",
                Pathname = "/gbi/update/mapping",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateEnumMappingResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改当前指定业务空间指定列下的枚举值信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateEnumMappingRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateEnumMappingResponse
        /// </returns>
        public async Task<UpdateEnumMappingResponse> UpdateEnumMappingWithOptionsAsync(UpdateEnumMappingRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["workspaceId"] = request.WorkspaceId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ColumnIdKey))
            {
                body["columnIdKey"] = request.ColumnIdKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.EnumMapping))
            {
                body["enumMapping"] = request.EnumMapping;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TableIdKey))
            {
                body["tableIdKey"] = request.TableIdKey;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateEnumMapping",
                Version = "2024-08-23",
                Protocol = "HTTPS",
                Pathname = "/gbi/update/mapping",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateEnumMappingResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改当前指定业务空间指定列下的枚举值信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateEnumMappingRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateEnumMappingResponse
        /// </returns>
        public UpdateEnumMappingResponse UpdateEnumMapping(UpdateEnumMappingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateEnumMappingWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改当前指定业务空间指定列下的枚举值信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateEnumMappingRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateEnumMappingResponse
        /// </returns>
        public async Task<UpdateEnumMappingResponse> UpdateEnumMappingAsync(UpdateEnumMappingRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateEnumMappingWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改当前业务空间指定的同义词信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateSynonymsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateSynonymsResponse
        /// </returns>
        public UpdateSynonymsResponse UpdateSynonymsWithOptions(UpdateSynonymsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["workspaceId"] = request.WorkspaceId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Columns))
            {
                body["columns"] = request.Columns;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SynonymIdKey))
            {
                body["synonymIdKey"] = request.SynonymIdKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Word))
            {
                body["word"] = request.Word;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WordSynonyms))
            {
                body["wordSynonyms"] = request.WordSynonyms;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateSynonyms",
                Version = "2024-08-23",
                Protocol = "HTTPS",
                Pathname = "/gbi/update/synonyms",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateSynonymsResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改当前业务空间指定的同义词信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateSynonymsRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateSynonymsResponse
        /// </returns>
        public async Task<UpdateSynonymsResponse> UpdateSynonymsWithOptionsAsync(UpdateSynonymsRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["workspaceId"] = request.WorkspaceId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Columns))
            {
                body["columns"] = request.Columns;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.SynonymIdKey))
            {
                body["synonymIdKey"] = request.SynonymIdKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Word))
            {
                body["word"] = request.Word;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WordSynonyms))
            {
                body["wordSynonyms"] = request.WordSynonyms;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateSynonyms",
                Version = "2024-08-23",
                Protocol = "HTTPS",
                Pathname = "/gbi/update/synonyms",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateSynonymsResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改当前业务空间指定的同义词信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateSynonymsRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateSynonymsResponse
        /// </returns>
        public UpdateSynonymsResponse UpdateSynonyms(UpdateSynonymsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateSynonymsWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改当前业务空间指定的同义词信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateSynonymsRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateSynonymsResponse
        /// </returns>
        public async Task<UpdateSynonymsResponse> UpdateSynonymsAsync(UpdateSynonymsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateSynonymsWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改当前所指定的数据表的信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateTableInfoRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateTableInfoResponse
        /// </returns>
        public UpdateTableInfoResponse UpdateTableInfoWithOptions(UpdateTableInfoRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["workspaceId"] = request.WorkspaceId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ForeignKeys))
            {
                body["foreignKeys"] = request.ForeignKeys;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PrimaryKey))
            {
                body["primaryKey"] = request.PrimaryKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TableIdKey))
            {
                body["tableIdKey"] = request.TableIdKey;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateTableInfo",
                Version = "2024-08-23",
                Protocol = "HTTPS",
                Pathname = "/gbi/update/table",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateTableInfoResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改当前所指定的数据表的信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateTableInfoRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateTableInfoResponse
        /// </returns>
        public async Task<UpdateTableInfoResponse> UpdateTableInfoWithOptionsAsync(UpdateTableInfoRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["workspaceId"] = request.WorkspaceId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.ForeignKeys))
            {
                body["foreignKeys"] = request.ForeignKeys;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.PrimaryKey))
            {
                body["primaryKey"] = request.PrimaryKey;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.TableIdKey))
            {
                body["tableIdKey"] = request.TableIdKey;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateTableInfo",
                Version = "2024-08-23",
                Protocol = "HTTPS",
                Pathname = "/gbi/update/table",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateTableInfoResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改当前所指定的数据表的信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateTableInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateTableInfoResponse
        /// </returns>
        public UpdateTableInfoResponse UpdateTableInfo(UpdateTableInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateTableInfoWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改当前所指定的数据表的信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateTableInfoRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateTableInfoResponse
        /// </returns>
        public async Task<UpdateTableInfoResponse> UpdateTableInfoAsync(UpdateTableInfoRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateTableInfoWithOptionsAsync(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改指定业务空间下所指定的虚拟数据源的信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateVirtualDatasourceInstanceRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateVirtualDatasourceInstanceResponse
        /// </returns>
        public UpdateVirtualDatasourceInstanceResponse UpdateVirtualDatasourceInstanceWithOptions(UpdateVirtualDatasourceInstanceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["workspaceId"] = request.WorkspaceId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                body["type"] = request.Type;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VdbId))
            {
                body["vdbId"] = request.VdbId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateVirtualDatasourceInstance",
                Version = "2024-08-23",
                Protocol = "HTTPS",
                Pathname = "/gbi/virtualDatasource/updateVirtualDatasourceInstance",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateVirtualDatasourceInstanceResponse>(CallApi(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改指定业务空间下所指定的虚拟数据源的信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateVirtualDatasourceInstanceRequest
        /// </param>
        /// <param name="headers">
        /// map
        /// </param>
        /// <param name="runtime">
        /// runtime options for this request RuntimeOptions
        /// </param>
        /// 
        /// <returns>
        /// UpdateVirtualDatasourceInstanceResponse
        /// </returns>
        public async Task<UpdateVirtualDatasourceInstanceResponse> UpdateVirtualDatasourceInstanceWithOptionsAsync(UpdateVirtualDatasourceInstanceRequest request, Dictionary<string, string> headers, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, object> query = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.WorkspaceId))
            {
                query["workspaceId"] = request.WorkspaceId;
            }
            Dictionary<string, object> body = new Dictionary<string, object>(){};
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Description))
            {
                body["description"] = request.Description;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Name))
            {
                body["name"] = request.Name;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.Type))
            {
                body["type"] = request.Type;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(request.VdbId))
            {
                body["vdbId"] = request.VdbId;
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Headers = headers,
                Query = AlibabaCloud.OpenApiUtil.Client.Query(query),
                Body = AlibabaCloud.OpenApiUtil.Client.ParseToMap(body),
            };
            AlibabaCloud.OpenApiClient.Models.Params params_ = new AlibabaCloud.OpenApiClient.Models.Params
            {
                Action = "UpdateVirtualDatasourceInstance",
                Version = "2024-08-23",
                Protocol = "HTTPS",
                Pathname = "/gbi/virtualDatasource/updateVirtualDatasourceInstance",
                Method = "POST",
                AuthType = "AK",
                Style = "ROA",
                ReqBodyType = "json",
                BodyType = "json",
            };
            return TeaModel.ToObject<UpdateVirtualDatasourceInstanceResponse>(await CallApiAsync(params_, req, runtime));
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改指定业务空间下所指定的虚拟数据源的信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateVirtualDatasourceInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateVirtualDatasourceInstanceResponse
        /// </returns>
        public UpdateVirtualDatasourceInstanceResponse UpdateVirtualDatasourceInstance(UpdateVirtualDatasourceInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return UpdateVirtualDatasourceInstanceWithOptions(request, headers, runtime);
        }

        /// <term><b>Summary:</b></term>
        /// <summary>
        /// <para>修改指定业务空间下所指定的虚拟数据源的信息</para>
        /// </summary>
        /// 
        /// <param name="request">
        /// UpdateVirtualDatasourceInstanceRequest
        /// </param>
        /// 
        /// <returns>
        /// UpdateVirtualDatasourceInstanceResponse
        /// </returns>
        public async Task<UpdateVirtualDatasourceInstanceResponse> UpdateVirtualDatasourceInstanceAsync(UpdateVirtualDatasourceInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            Dictionary<string, string> headers = new Dictionary<string, string>(){};
            return await UpdateVirtualDatasourceInstanceWithOptionsAsync(request, headers, runtime);
        }

    }
}
